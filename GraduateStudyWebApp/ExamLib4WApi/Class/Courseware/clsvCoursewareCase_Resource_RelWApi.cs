
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareCase_Resource_RelWApi
 表名:vCoursewareCase_Resource_Rel(01120433)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:03
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件
 模块英文名:Courseware
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
public static class clsvCoursewareCase_Resource_RelWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN Setid_MicroteachCase_Resource_Rel(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, long lngid_MicroteachCase_Resource_Rel, string strComparisonOp="")
	{
objvCoursewareCase_Resource_RelEN.id_MicroteachCase_Resource_Rel = lngid_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.id_MicroteachCase_Resource_Rel) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.id_MicroteachCase_Resource_Rel, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_MicroteachCase_Resource_Rel] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetFuncModuleId(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCoursewareCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCoursewareCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCoursewareCase_Resource_Rel.FuncModuleId);
objvCoursewareCase_Resource_RelEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.FuncModuleId) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.FuncModuleId, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FuncModuleId] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetFuncModuleName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCoursewareCase_Resource_Rel.FuncModuleName);
objvCoursewareCase_Resource_RelEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.FuncModuleName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.FuncModuleName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FuncModuleName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN Setid_MicroteachCase(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convCoursewareCase_Resource_Rel.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convCoursewareCase_Resource_Rel.id_MicroteachCase);
objvCoursewareCase_Resource_RelEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.id_MicroteachCase) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.id_MicroteachCase, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_MicroteachCase] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetCoursewareCaseID(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strCoursewareCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseID, 8, convCoursewareCase_Resource_Rel.CoursewareCaseID);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseID, 8, convCoursewareCase_Resource_Rel.CoursewareCaseID);
objvCoursewareCase_Resource_RelEN.CoursewareCaseID = strCoursewareCaseID; //课件教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.CoursewareCaseID) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.CoursewareCaseID, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CoursewareCaseID] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetCoursewareCaseName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strCoursewareCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseName, 100, convCoursewareCase_Resource_Rel.CoursewareCaseName);
objvCoursewareCase_Resource_RelEN.CoursewareCaseName = strCoursewareCaseName; //课件教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.CoursewareCaseName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.CoursewareCaseName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CoursewareCaseName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetCoursewareCaseTheme(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strCoursewareCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseTheme, 200, convCoursewareCase_Resource_Rel.CoursewareCaseTheme);
objvCoursewareCase_Resource_RelEN.CoursewareCaseTheme = strCoursewareCaseTheme; //课件教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.CoursewareCaseTheme) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.CoursewareCaseTheme, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CoursewareCaseTheme] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN Setid_CoursewareCaseType(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strid_CoursewareCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CoursewareCaseType, 4, convCoursewareCase_Resource_Rel.id_CoursewareCaseType);
clsCheckSql.CheckFieldForeignKey(strid_CoursewareCaseType, 4, convCoursewareCase_Resource_Rel.id_CoursewareCaseType);
objvCoursewareCase_Resource_RelEN.id_CoursewareCaseType = strid_CoursewareCaseType; //课件案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.id_CoursewareCaseType) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.id_CoursewareCaseType, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_CoursewareCaseType] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetCoursewareCaseTypeName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strCoursewareCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseTypeName, 50, convCoursewareCase_Resource_Rel.CoursewareCaseTypeName);
objvCoursewareCase_Resource_RelEN.CoursewareCaseTypeName = strCoursewareCaseTypeName; //课件案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.CoursewareCaseTypeName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.CoursewareCaseTypeName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CoursewareCaseTypeName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetCoursewareCaseText(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strCoursewareCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseText, 8000, convCoursewareCase_Resource_Rel.CoursewareCaseText);
objvCoursewareCase_Resource_RelEN.CoursewareCaseText = strCoursewareCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.CoursewareCaseText) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.CoursewareCaseText, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CoursewareCaseText] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetCoursewareCaseDate(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strCoursewareCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseDate, 8, convCoursewareCase_Resource_Rel.CoursewareCaseDate);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseDate, 8, convCoursewareCase_Resource_Rel.CoursewareCaseDate);
objvCoursewareCase_Resource_RelEN.CoursewareCaseDate = strCoursewareCaseDate; //课件教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.CoursewareCaseDate) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.CoursewareCaseDate, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CoursewareCaseDate] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetCoursewareCaseTime(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strCoursewareCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseTime, 6, convCoursewareCase_Resource_Rel.CoursewareCaseTime);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseTime, 6, convCoursewareCase_Resource_Rel.CoursewareCaseTime);
objvCoursewareCase_Resource_RelEN.CoursewareCaseTime = strCoursewareCaseTime; //课件教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.CoursewareCaseTime) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.CoursewareCaseTime, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CoursewareCaseTime] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetCoursewareCaseDateIn(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strCoursewareCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseDateIn, 8, convCoursewareCase_Resource_Rel.CoursewareCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseDateIn, 8, convCoursewareCase_Resource_Rel.CoursewareCaseDateIn);
objvCoursewareCase_Resource_RelEN.CoursewareCaseDateIn = strCoursewareCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.CoursewareCaseDateIn) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.CoursewareCaseDateIn, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CoursewareCaseDateIn] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetCoursewareCaseTimeIn(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strCoursewareCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseTimeIn, 6, convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strCoursewareCaseTimeIn, 6, convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn);
objvCoursewareCase_Resource_RelEN.CoursewareCaseTimeIn = strCoursewareCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN Setid_StudyLevel(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convCoursewareCase_Resource_Rel.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convCoursewareCase_Resource_Rel.id_StudyLevel);
objvCoursewareCase_Resource_RelEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.id_StudyLevel) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.id_StudyLevel, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_StudyLevel] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetStudyLevelName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convCoursewareCase_Resource_Rel.StudyLevelName);
objvCoursewareCase_Resource_RelEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.StudyLevelName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.StudyLevelName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.StudyLevelName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN Setid_TeachingPlan(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convCoursewareCase_Resource_Rel.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convCoursewareCase_Resource_Rel.id_TeachingPlan);
objvCoursewareCase_Resource_RelEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.id_TeachingPlan) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.id_TeachingPlan, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_TeachingPlan] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetId_CaseType(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strId_CaseType, convCoursewareCase_Resource_Rel.Id_CaseType);
clsCheckSql.CheckFieldLen(strId_CaseType, 4, convCoursewareCase_Resource_Rel.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, convCoursewareCase_Resource_Rel.Id_CaseType);
objvCoursewareCase_Resource_RelEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.Id_CaseType) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.Id_CaseType, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.Id_CaseType] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN Setid_Discipline(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convCoursewareCase_Resource_Rel.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convCoursewareCase_Resource_Rel.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convCoursewareCase_Resource_Rel.id_Discipline);
objvCoursewareCase_Resource_RelEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.id_Discipline) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.id_Discipline, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_Discipline] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetDisciplineID(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convCoursewareCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convCoursewareCase_Resource_Rel.DisciplineID);
objvCoursewareCase_Resource_RelEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.DisciplineID) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.DisciplineID, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.DisciplineID] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetDisciplineName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convCoursewareCase_Resource_Rel.DisciplineName);
objvCoursewareCase_Resource_RelEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.DisciplineName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.DisciplineName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.DisciplineName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetsenateGaugeVersionID(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convCoursewareCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convCoursewareCase_Resource_Rel.senateGaugeVersionID);
objvCoursewareCase_Resource_RelEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.senateGaugeVersionID) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.senateGaugeVersionID, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.senateGaugeVersionID] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetsenateGaugeVersionName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convCoursewareCase_Resource_Rel.senateGaugeVersionName);
objvCoursewareCase_Resource_RelEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.senateGaugeVersionName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.senateGaugeVersionName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.senateGaugeVersionName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetsenateGaugeVersionTtlScore(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvCoursewareCase_Resource_RelEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetVersionNo(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, int intVersionNo, string strComparisonOp="")
	{
objvCoursewareCase_Resource_RelEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.VersionNo) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.VersionNo, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.VersionNo] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN Setid_TeachSkill(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convCoursewareCase_Resource_Rel.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convCoursewareCase_Resource_Rel.id_TeachSkill);
objvCoursewareCase_Resource_RelEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.id_TeachSkill) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.id_TeachSkill, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_TeachSkill] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetTeachSkillID(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convCoursewareCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convCoursewareCase_Resource_Rel.TeachSkillID);
objvCoursewareCase_Resource_RelEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.TeachSkillID) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.TeachSkillID, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.TeachSkillID] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetSkillTypeName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convCoursewareCase_Resource_Rel.SkillTypeName);
objvCoursewareCase_Resource_RelEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.SkillTypeName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.SkillTypeName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.SkillTypeName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetTeachSkillName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convCoursewareCase_Resource_Rel.TeachSkillName);
objvCoursewareCase_Resource_RelEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.TeachSkillName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.TeachSkillName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.TeachSkillName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetTeachSkillTheory(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convCoursewareCase_Resource_Rel.TeachSkillTheory);
objvCoursewareCase_Resource_RelEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.TeachSkillTheory) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.TeachSkillTheory, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.TeachSkillTheory] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetTeachSkillOperMethod(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convCoursewareCase_Resource_Rel.TeachSkillOperMethod);
objvCoursewareCase_Resource_RelEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.TeachSkillOperMethod) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN Setid_SkillType(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convCoursewareCase_Resource_Rel.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convCoursewareCase_Resource_Rel.id_SkillType);
objvCoursewareCase_Resource_RelEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.id_SkillType) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.id_SkillType, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_SkillType] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetSkillTypeID(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convCoursewareCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convCoursewareCase_Resource_Rel.SkillTypeID);
objvCoursewareCase_Resource_RelEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.SkillTypeID) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.SkillTypeID, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.SkillTypeID] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetCaseLevelId(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convCoursewareCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convCoursewareCase_Resource_Rel.CaseLevelId);
objvCoursewareCase_Resource_RelEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.CaseLevelId) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.CaseLevelId, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CaseLevelId] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetOwnerId(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCoursewareCase_Resource_Rel.OwnerId);
objvCoursewareCase_Resource_RelEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.OwnerId) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.OwnerId, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.OwnerId] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetStuName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convCoursewareCase_Resource_Rel.StuName);
objvCoursewareCase_Resource_RelEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.StuName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.StuName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.StuName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetStuID(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convCoursewareCase_Resource_Rel.StuID);
objvCoursewareCase_Resource_RelEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.StuID) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.StuID, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.StuID] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetPoliticsName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strPoliticsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPoliticsName, 30, convCoursewareCase_Resource_Rel.PoliticsName);
objvCoursewareCase_Resource_RelEN.PoliticsName = strPoliticsName; //政治面貌
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.PoliticsName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.PoliticsName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.PoliticsName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetSexDesc(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strSexDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convCoursewareCase_Resource_Rel.SexDesc);
objvCoursewareCase_Resource_RelEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.SexDesc) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.SexDesc, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.SexDesc] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetEthnicName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strEthnicName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEthnicName, 30, convCoursewareCase_Resource_Rel.EthnicName);
objvCoursewareCase_Resource_RelEN.EthnicName = strEthnicName; //民族名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.EthnicName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.EthnicName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.EthnicName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetUniZoneDesc(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strUniZoneDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convCoursewareCase_Resource_Rel.UniZoneDesc);
objvCoursewareCase_Resource_RelEN.UniZoneDesc = strUniZoneDesc; //校区名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.UniZoneDesc) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.UniZoneDesc, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.UniZoneDesc] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetStuTypeDesc(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strStuTypeDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuTypeDesc, 50, convCoursewareCase_Resource_Rel.StuTypeDesc);
objvCoursewareCase_Resource_RelEN.StuTypeDesc = strStuTypeDesc; //学生类别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.StuTypeDesc) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.StuTypeDesc, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.StuTypeDesc] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN Setid_XzCollege(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCoursewareCase_Resource_Rel.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCoursewareCase_Resource_Rel.id_XzCollege);
objvCoursewareCase_Resource_RelEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.id_XzCollege) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.id_XzCollege, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_XzCollege] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetCollegeName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCoursewareCase_Resource_Rel.CollegeName);
objvCoursewareCase_Resource_RelEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.CollegeName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.CollegeName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CollegeName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetCollegeNameA(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convCoursewareCase_Resource_Rel.CollegeNameA);
objvCoursewareCase_Resource_RelEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.CollegeNameA) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.CollegeNameA, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CollegeNameA] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN Setid_XzMajor(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convCoursewareCase_Resource_Rel.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convCoursewareCase_Resource_Rel.id_XzMajor);
objvCoursewareCase_Resource_RelEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.id_XzMajor) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.id_XzMajor, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_XzMajor] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetMajorName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCoursewareCase_Resource_Rel.MajorName);
objvCoursewareCase_Resource_RelEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.MajorName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.MajorName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.MajorName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN Setid_GradeBase(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convCoursewareCase_Resource_Rel.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convCoursewareCase_Resource_Rel.id_GradeBase);
objvCoursewareCase_Resource_RelEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.id_GradeBase) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.id_GradeBase, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_GradeBase] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetGradeBaseName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convCoursewareCase_Resource_Rel.GradeBaseName);
objvCoursewareCase_Resource_RelEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.GradeBaseName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.GradeBaseName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.GradeBaseName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN Setid_AdminCls(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strid_AdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminCls, 8, convCoursewareCase_Resource_Rel.id_AdminCls);
clsCheckSql.CheckFieldForeignKey(strid_AdminCls, 8, convCoursewareCase_Resource_Rel.id_AdminCls);
objvCoursewareCase_Resource_RelEN.id_AdminCls = strid_AdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.id_AdminCls) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.id_AdminCls, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_AdminCls] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetAdminClsId(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strAdminClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convCoursewareCase_Resource_Rel.AdminClsId);
objvCoursewareCase_Resource_RelEN.AdminClsId = strAdminClsId; //行政班代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.AdminClsId) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.AdminClsId, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.AdminClsId] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetAdminClsName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strAdminClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convCoursewareCase_Resource_Rel.AdminClsName);
objvCoursewareCase_Resource_RelEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.AdminClsName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.AdminClsName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.AdminClsName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetBirthday(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strBirthday, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBirthday, 8, convCoursewareCase_Resource_Rel.Birthday);
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convCoursewareCase_Resource_Rel.Birthday);
objvCoursewareCase_Resource_RelEN.Birthday = strBirthday; //出生日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.Birthday) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.Birthday, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.Birthday] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetNativePlace(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strNativePlace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNativePlace, 200, convCoursewareCase_Resource_Rel.NativePlace);
objvCoursewareCase_Resource_RelEN.NativePlace = strNativePlace; //籍贯
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.NativePlace) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.NativePlace, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.NativePlace] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetDuty(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strDuty, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDuty, 30, convCoursewareCase_Resource_Rel.Duty);
objvCoursewareCase_Resource_RelEN.Duty = strDuty; //职位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.Duty) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.Duty, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.Duty] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetIDCardNo(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strIDCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIDCardNo, 20, convCoursewareCase_Resource_Rel.IDCardNo);
objvCoursewareCase_Resource_RelEN.IDCardNo = strIDCardNo; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.IDCardNo) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.IDCardNo, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.IDCardNo] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetStuCardNo(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strStuCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuCardNo, 20, convCoursewareCase_Resource_Rel.StuCardNo);
objvCoursewareCase_Resource_RelEN.StuCardNo = strStuCardNo; //学生证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.StuCardNo) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.StuCardNo, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.StuCardNo] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetLiveAddress(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strLiveAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLiveAddress, 200, convCoursewareCase_Resource_Rel.LiveAddress);
objvCoursewareCase_Resource_RelEN.LiveAddress = strLiveAddress; //居住地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.LiveAddress) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.LiveAddress, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.LiveAddress] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetHomePhone(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strHomePhone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHomePhone, 20, convCoursewareCase_Resource_Rel.HomePhone);
objvCoursewareCase_Resource_RelEN.HomePhone = strHomePhone; //住宅电话
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.HomePhone) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.HomePhone, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.HomePhone] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetEnrollmentDate(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strEnrollmentDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEnrollmentDate, 8, convCoursewareCase_Resource_Rel.EnrollmentDate);
objvCoursewareCase_Resource_RelEN.EnrollmentDate = strEnrollmentDate; //入校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.EnrollmentDate) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.EnrollmentDate, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.EnrollmentDate] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetPostCode(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strPostCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPostCode, 6, convCoursewareCase_Resource_Rel.PostCode);
clsCheckSql.CheckFieldForeignKey(strPostCode, 6, convCoursewareCase_Resource_Rel.PostCode);
objvCoursewareCase_Resource_RelEN.PostCode = strPostCode; //邮编
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.PostCode) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.PostCode, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.PostCode] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetUserKindId(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindId, 2, convCoursewareCase_Resource_Rel.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convCoursewareCase_Resource_Rel.UserKindId);
objvCoursewareCase_Resource_RelEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.UserKindId) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.UserKindId, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.UserKindId] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetUserKindName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strUserKindName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convCoursewareCase_Resource_Rel.UserKindName);
objvCoursewareCase_Resource_RelEN.UserKindName = strUserKindName; //用户类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.UserKindName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.UserKindName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.UserKindName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetUserTypeId(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convCoursewareCase_Resource_Rel.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convCoursewareCase_Resource_Rel.UserTypeId);
objvCoursewareCase_Resource_RelEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.UserTypeId) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.UserTypeId, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.UserTypeId] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetIsDualVideo(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvCoursewareCase_Resource_RelEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.IsDualVideo) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.IsDualVideo, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.IsDualVideo] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetRecommendedDegreeId(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convCoursewareCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convCoursewareCase_Resource_Rel.RecommendedDegreeId);
objvCoursewareCase_Resource_RelEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.RecommendedDegreeId) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.RecommendedDegreeId, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.RecommendedDegreeId] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetRecommendedDegreeName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convCoursewareCase_Resource_Rel.RecommendedDegreeName);
objvCoursewareCase_Resource_RelEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.RecommendedDegreeName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.RecommendedDegreeName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.RecommendedDegreeName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetBrowseCount4Case(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvCoursewareCase_Resource_RelEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.BrowseCount4Case) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.BrowseCount4Case, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.BrowseCount4Case] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN Setid_Resource(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convCoursewareCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convCoursewareCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convCoursewareCase_Resource_Rel.id_Resource);
objvCoursewareCase_Resource_RelEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.id_Resource) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.id_Resource, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_Resource] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetResourceID(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceID, 8, convCoursewareCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convCoursewareCase_Resource_Rel.ResourceID);
objvCoursewareCase_Resource_RelEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.ResourceID) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.ResourceID, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.ResourceID] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetResourceName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceName, 100, convCoursewareCase_Resource_Rel.ResourceName);
objvCoursewareCase_Resource_RelEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.ResourceName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.ResourceName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.ResourceName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN Setid_FtpResource(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convCoursewareCase_Resource_Rel.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convCoursewareCase_Resource_Rel.id_FtpResource);
objvCoursewareCase_Resource_RelEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.id_FtpResource) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.id_FtpResource, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_FtpResource] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN Setid_File(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convCoursewareCase_Resource_Rel.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convCoursewareCase_Resource_Rel.id_File);
objvCoursewareCase_Resource_RelEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.id_File) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.id_File, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_File] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetFileName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convCoursewareCase_Resource_Rel.FileName);
objvCoursewareCase_Resource_RelEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.FileName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.FileName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FileName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetFileType(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convCoursewareCase_Resource_Rel.FileType);
objvCoursewareCase_Resource_RelEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.FileType) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.FileType, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FileType] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetSaveDate(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convCoursewareCase_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convCoursewareCase_Resource_Rel.SaveDate);
objvCoursewareCase_Resource_RelEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.SaveDate) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.SaveDate, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.SaveDate] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetFileSize(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convCoursewareCase_Resource_Rel.FileSize);
objvCoursewareCase_Resource_RelEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.FileSize) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.FileSize, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FileSize] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetSaveTime(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convCoursewareCase_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convCoursewareCase_Resource_Rel.SaveTime);
objvCoursewareCase_Resource_RelEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.SaveTime) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.SaveTime, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.SaveTime] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetFtpResourceID(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convCoursewareCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convCoursewareCase_Resource_Rel.FtpResourceID);
objvCoursewareCase_Resource_RelEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.FtpResourceID) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.FtpResourceID, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FtpResourceID] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetFileOriginalName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convCoursewareCase_Resource_Rel.FileOriginalName);
objvCoursewareCase_Resource_RelEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.FileOriginalName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.FileOriginalName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FileOriginalName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetFileDirName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convCoursewareCase_Resource_Rel.FileDirName);
objvCoursewareCase_Resource_RelEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.FileDirName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.FileDirName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FileDirName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetFileRename(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convCoursewareCase_Resource_Rel.FileRename);
objvCoursewareCase_Resource_RelEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.FileRename) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.FileRename, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FileRename] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetFileUpDate(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convCoursewareCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convCoursewareCase_Resource_Rel.FileUpDate);
objvCoursewareCase_Resource_RelEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.FileUpDate) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.FileUpDate, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FileUpDate] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetFileUpTime(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convCoursewareCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convCoursewareCase_Resource_Rel.FileUpTime);
objvCoursewareCase_Resource_RelEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.FileUpTime) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.FileUpTime, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FileUpTime] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetSaveMode(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, bool bolSaveMode, string strComparisonOp="")
	{
objvCoursewareCase_Resource_RelEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.SaveMode) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.SaveMode, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.SaveMode] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN Setid_ResourceType(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convCoursewareCase_Resource_Rel.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convCoursewareCase_Resource_Rel.id_ResourceType);
objvCoursewareCase_Resource_RelEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.id_ResourceType) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.id_ResourceType, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_ResourceType] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetResourceTypeID(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convCoursewareCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convCoursewareCase_Resource_Rel.ResourceTypeID);
objvCoursewareCase_Resource_RelEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.ResourceTypeID) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.ResourceTypeID, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.ResourceTypeID] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetResourceTypeName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convCoursewareCase_Resource_Rel.ResourceTypeName);
objvCoursewareCase_Resource_RelEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.ResourceTypeName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.ResourceTypeName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.ResourceTypeName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetResourceOwner(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convCoursewareCase_Resource_Rel.ResourceOwner);
objvCoursewareCase_Resource_RelEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.ResourceOwner) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.ResourceOwner, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.ResourceOwner] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetftpFileType(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convCoursewareCase_Resource_Rel.ftpFileType);
objvCoursewareCase_Resource_RelEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.ftpFileType) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.ftpFileType, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.ftpFileType] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetftpFileSize(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convCoursewareCase_Resource_Rel.ftpFileSize);
objvCoursewareCase_Resource_RelEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.ftpFileSize) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.ftpFileSize, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.ftpFileSize] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetftpResourceOwner(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convCoursewareCase_Resource_Rel.ftpResourceOwner);
objvCoursewareCase_Resource_RelEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.ftpResourceOwner) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.ftpResourceOwner, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.ftpResourceOwner] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetFileOriginName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convCoursewareCase_Resource_Rel.FileOriginName);
objvCoursewareCase_Resource_RelEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.FileOriginName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.FileOriginName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FileOriginName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetIsExistFile(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvCoursewareCase_Resource_RelEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.IsExistFile) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.IsExistFile, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.IsExistFile] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetFileNewName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convCoursewareCase_Resource_Rel.FileNewName);
objvCoursewareCase_Resource_RelEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.FileNewName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.FileNewName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FileNewName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetFileOldName(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convCoursewareCase_Resource_Rel.FileOldName);
objvCoursewareCase_Resource_RelEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.FileOldName) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.FileOldName, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FileOldName] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetIsMain(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, bool bolIsMain, string strComparisonOp="")
	{
objvCoursewareCase_Resource_RelEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.IsMain) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.IsMain, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.IsMain] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN Setid_UsingMode(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strid_UsingMode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UsingMode, 4, convCoursewareCase_Resource_Rel.id_UsingMode);
clsCheckSql.CheckFieldForeignKey(strid_UsingMode, 4, convCoursewareCase_Resource_Rel.id_UsingMode);
objvCoursewareCase_Resource_RelEN.id_UsingMode = strid_UsingMode; //资源使用模式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.id_UsingMode) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.id_UsingMode, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_UsingMode] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetIsVisible(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, bool bolIsVisible, string strComparisonOp="")
	{
objvCoursewareCase_Resource_RelEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.IsVisible) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.IsVisible, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.IsVisible] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetIndexNO(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, int intIndexNO, string strComparisonOp="")
	{
objvCoursewareCase_Resource_RelEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.IndexNO) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.IndexNO, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.IndexNO] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetBrowseCount(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, int intBrowseCount, string strComparisonOp="")
	{
objvCoursewareCase_Resource_RelEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.BrowseCount) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.BrowseCount, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.BrowseCount] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetUpdDate(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCoursewareCase_Resource_Rel.UpdDate);
objvCoursewareCase_Resource_RelEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.UpdDate) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.UpdDate, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.UpdDate] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetUpdUser(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCoursewareCase_Resource_Rel.UpdUser);
objvCoursewareCase_Resource_RelEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.UpdUser) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.UpdUser, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.UpdUser] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCase_Resource_RelEN SetMemo(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCoursewareCase_Resource_Rel.Memo);
objvCoursewareCase_Resource_RelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareCase_Resource_Rel.Memo) == false)
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareCase_Resource_Rel.Memo, strComparisonOp);
}
else
{
objvCoursewareCase_Resource_RelEN.dicFldComparisonOp[convCoursewareCase_Resource_Rel.Memo] = strComparisonOp;
}
}
return objvCoursewareCase_Resource_RelEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_Rel_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.id_MicroteachCase_Resource_Rel) == true)
{
string strComparisonOp_id_MicroteachCase_Resource_Rel = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_MicroteachCase_Resource_Rel];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareCase_Resource_Rel.id_MicroteachCase_Resource_Rel, objvCoursewareCase_Resource_Rel_Cond.id_MicroteachCase_Resource_Rel, strComparisonOp_id_MicroteachCase_Resource_Rel);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.FuncModuleId, objvCoursewareCase_Resource_Rel_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.FuncModuleName, objvCoursewareCase_Resource_Rel_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.id_MicroteachCase, objvCoursewareCase_Resource_Rel_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.CoursewareCaseID) == true)
{
string strComparisonOp_CoursewareCaseID = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CoursewareCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.CoursewareCaseID, objvCoursewareCase_Resource_Rel_Cond.CoursewareCaseID, strComparisonOp_CoursewareCaseID);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.CoursewareCaseName) == true)
{
string strComparisonOp_CoursewareCaseName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CoursewareCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.CoursewareCaseName, objvCoursewareCase_Resource_Rel_Cond.CoursewareCaseName, strComparisonOp_CoursewareCaseName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.CoursewareCaseTheme) == true)
{
string strComparisonOp_CoursewareCaseTheme = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CoursewareCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.CoursewareCaseTheme, objvCoursewareCase_Resource_Rel_Cond.CoursewareCaseTheme, strComparisonOp_CoursewareCaseTheme);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.id_CoursewareCaseType) == true)
{
string strComparisonOp_id_CoursewareCaseType = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_CoursewareCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.id_CoursewareCaseType, objvCoursewareCase_Resource_Rel_Cond.id_CoursewareCaseType, strComparisonOp_id_CoursewareCaseType);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.CoursewareCaseTypeName) == true)
{
string strComparisonOp_CoursewareCaseTypeName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CoursewareCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.CoursewareCaseTypeName, objvCoursewareCase_Resource_Rel_Cond.CoursewareCaseTypeName, strComparisonOp_CoursewareCaseTypeName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.CoursewareCaseText) == true)
{
string strComparisonOp_CoursewareCaseText = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CoursewareCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.CoursewareCaseText, objvCoursewareCase_Resource_Rel_Cond.CoursewareCaseText, strComparisonOp_CoursewareCaseText);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.CoursewareCaseDate) == true)
{
string strComparisonOp_CoursewareCaseDate = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CoursewareCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.CoursewareCaseDate, objvCoursewareCase_Resource_Rel_Cond.CoursewareCaseDate, strComparisonOp_CoursewareCaseDate);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.CoursewareCaseTime) == true)
{
string strComparisonOp_CoursewareCaseTime = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CoursewareCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.CoursewareCaseTime, objvCoursewareCase_Resource_Rel_Cond.CoursewareCaseTime, strComparisonOp_CoursewareCaseTime);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.CoursewareCaseDateIn) == true)
{
string strComparisonOp_CoursewareCaseDateIn = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CoursewareCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.CoursewareCaseDateIn, objvCoursewareCase_Resource_Rel_Cond.CoursewareCaseDateIn, strComparisonOp_CoursewareCaseDateIn);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn) == true)
{
string strComparisonOp_CoursewareCaseTimeIn = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn, objvCoursewareCase_Resource_Rel_Cond.CoursewareCaseTimeIn, strComparisonOp_CoursewareCaseTimeIn);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.id_StudyLevel, objvCoursewareCase_Resource_Rel_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.StudyLevelName, objvCoursewareCase_Resource_Rel_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.id_TeachingPlan, objvCoursewareCase_Resource_Rel_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.Id_CaseType, objvCoursewareCase_Resource_Rel_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.id_Discipline, objvCoursewareCase_Resource_Rel_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.DisciplineID, objvCoursewareCase_Resource_Rel_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.DisciplineName, objvCoursewareCase_Resource_Rel_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.senateGaugeVersionID, objvCoursewareCase_Resource_Rel_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.senateGaugeVersionName, objvCoursewareCase_Resource_Rel_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore, objvCoursewareCase_Resource_Rel_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareCase_Resource_Rel.VersionNo, objvCoursewareCase_Resource_Rel_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.id_TeachSkill, objvCoursewareCase_Resource_Rel_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.TeachSkillID, objvCoursewareCase_Resource_Rel_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.SkillTypeName, objvCoursewareCase_Resource_Rel_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.TeachSkillName, objvCoursewareCase_Resource_Rel_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.TeachSkillTheory, objvCoursewareCase_Resource_Rel_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.TeachSkillOperMethod, objvCoursewareCase_Resource_Rel_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.id_SkillType, objvCoursewareCase_Resource_Rel_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.SkillTypeID, objvCoursewareCase_Resource_Rel_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.CaseLevelId, objvCoursewareCase_Resource_Rel_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.OwnerId, objvCoursewareCase_Resource_Rel_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.StuName) == true)
{
string strComparisonOp_StuName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.StuName, objvCoursewareCase_Resource_Rel_Cond.StuName, strComparisonOp_StuName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.StuID) == true)
{
string strComparisonOp_StuID = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.StuID, objvCoursewareCase_Resource_Rel_Cond.StuID, strComparisonOp_StuID);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.PoliticsName) == true)
{
string strComparisonOp_PoliticsName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.PoliticsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.PoliticsName, objvCoursewareCase_Resource_Rel_Cond.PoliticsName, strComparisonOp_PoliticsName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.SexDesc) == true)
{
string strComparisonOp_SexDesc = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.SexDesc, objvCoursewareCase_Resource_Rel_Cond.SexDesc, strComparisonOp_SexDesc);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.EthnicName) == true)
{
string strComparisonOp_EthnicName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.EthnicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.EthnicName, objvCoursewareCase_Resource_Rel_Cond.EthnicName, strComparisonOp_EthnicName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.UniZoneDesc) == true)
{
string strComparisonOp_UniZoneDesc = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.UniZoneDesc, objvCoursewareCase_Resource_Rel_Cond.UniZoneDesc, strComparisonOp_UniZoneDesc);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.StuTypeDesc) == true)
{
string strComparisonOp_StuTypeDesc = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.StuTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.StuTypeDesc, objvCoursewareCase_Resource_Rel_Cond.StuTypeDesc, strComparisonOp_StuTypeDesc);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.id_XzCollege, objvCoursewareCase_Resource_Rel_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.CollegeName, objvCoursewareCase_Resource_Rel_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.CollegeNameA, objvCoursewareCase_Resource_Rel_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.id_XzMajor, objvCoursewareCase_Resource_Rel_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.MajorName) == true)
{
string strComparisonOp_MajorName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.MajorName, objvCoursewareCase_Resource_Rel_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.id_GradeBase, objvCoursewareCase_Resource_Rel_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.GradeBaseName, objvCoursewareCase_Resource_Rel_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.id_AdminCls) == true)
{
string strComparisonOp_id_AdminCls = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_AdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.id_AdminCls, objvCoursewareCase_Resource_Rel_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.AdminClsId) == true)
{
string strComparisonOp_AdminClsId = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.AdminClsId, objvCoursewareCase_Resource_Rel_Cond.AdminClsId, strComparisonOp_AdminClsId);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.AdminClsName) == true)
{
string strComparisonOp_AdminClsName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.AdminClsName, objvCoursewareCase_Resource_Rel_Cond.AdminClsName, strComparisonOp_AdminClsName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.Birthday) == true)
{
string strComparisonOp_Birthday = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.Birthday, objvCoursewareCase_Resource_Rel_Cond.Birthday, strComparisonOp_Birthday);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.NativePlace) == true)
{
string strComparisonOp_NativePlace = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.NativePlace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.NativePlace, objvCoursewareCase_Resource_Rel_Cond.NativePlace, strComparisonOp_NativePlace);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.Duty) == true)
{
string strComparisonOp_Duty = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.Duty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.Duty, objvCoursewareCase_Resource_Rel_Cond.Duty, strComparisonOp_Duty);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.IDCardNo) == true)
{
string strComparisonOp_IDCardNo = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.IDCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.IDCardNo, objvCoursewareCase_Resource_Rel_Cond.IDCardNo, strComparisonOp_IDCardNo);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.StuCardNo) == true)
{
string strComparisonOp_StuCardNo = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.StuCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.StuCardNo, objvCoursewareCase_Resource_Rel_Cond.StuCardNo, strComparisonOp_StuCardNo);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.LiveAddress) == true)
{
string strComparisonOp_LiveAddress = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.LiveAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.LiveAddress, objvCoursewareCase_Resource_Rel_Cond.LiveAddress, strComparisonOp_LiveAddress);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.HomePhone) == true)
{
string strComparisonOp_HomePhone = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.HomePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.HomePhone, objvCoursewareCase_Resource_Rel_Cond.HomePhone, strComparisonOp_HomePhone);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.EnrollmentDate) == true)
{
string strComparisonOp_EnrollmentDate = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.EnrollmentDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.EnrollmentDate, objvCoursewareCase_Resource_Rel_Cond.EnrollmentDate, strComparisonOp_EnrollmentDate);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.PostCode) == true)
{
string strComparisonOp_PostCode = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.PostCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.PostCode, objvCoursewareCase_Resource_Rel_Cond.PostCode, strComparisonOp_PostCode);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.UserKindId) == true)
{
string strComparisonOp_UserKindId = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.UserKindId, objvCoursewareCase_Resource_Rel_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.UserKindName) == true)
{
string strComparisonOp_UserKindName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.UserKindName, objvCoursewareCase_Resource_Rel_Cond.UserKindName, strComparisonOp_UserKindName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.UserTypeId, objvCoursewareCase_Resource_Rel_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.IsDualVideo) == true)
{
if (objvCoursewareCase_Resource_Rel_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareCase_Resource_Rel.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareCase_Resource_Rel.IsDualVideo);
}
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.RecommendedDegreeId, objvCoursewareCase_Resource_Rel_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.RecommendedDegreeName, objvCoursewareCase_Resource_Rel_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareCase_Resource_Rel.BrowseCount4Case, objvCoursewareCase_Resource_Rel_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.id_Resource, objvCoursewareCase_Resource_Rel_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.ResourceID, objvCoursewareCase_Resource_Rel_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.ResourceName) == true)
{
string strComparisonOp_ResourceName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.ResourceName, objvCoursewareCase_Resource_Rel_Cond.ResourceName, strComparisonOp_ResourceName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.id_FtpResource, objvCoursewareCase_Resource_Rel_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.id_File) == true)
{
string strComparisonOp_id_File = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.id_File, objvCoursewareCase_Resource_Rel_Cond.id_File, strComparisonOp_id_File);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.FileName) == true)
{
string strComparisonOp_FileName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.FileName, objvCoursewareCase_Resource_Rel_Cond.FileName, strComparisonOp_FileName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.FileType) == true)
{
string strComparisonOp_FileType = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.FileType, objvCoursewareCase_Resource_Rel_Cond.FileType, strComparisonOp_FileType);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.SaveDate, objvCoursewareCase_Resource_Rel_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.FileSize) == true)
{
string strComparisonOp_FileSize = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.FileSize, objvCoursewareCase_Resource_Rel_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.SaveTime, objvCoursewareCase_Resource_Rel_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.FtpResourceID, objvCoursewareCase_Resource_Rel_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.FileOriginalName, objvCoursewareCase_Resource_Rel_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.FileDirName, objvCoursewareCase_Resource_Rel_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.FileRename) == true)
{
string strComparisonOp_FileRename = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.FileRename, objvCoursewareCase_Resource_Rel_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.FileUpDate, objvCoursewareCase_Resource_Rel_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.FileUpTime, objvCoursewareCase_Resource_Rel_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.SaveMode) == true)
{
if (objvCoursewareCase_Resource_Rel_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareCase_Resource_Rel.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareCase_Resource_Rel.SaveMode);
}
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.id_ResourceType, objvCoursewareCase_Resource_Rel_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.ResourceTypeID, objvCoursewareCase_Resource_Rel_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.ResourceTypeName, objvCoursewareCase_Resource_Rel_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.ResourceOwner, objvCoursewareCase_Resource_Rel_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.ftpFileType, objvCoursewareCase_Resource_Rel_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.ftpFileSize, objvCoursewareCase_Resource_Rel_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.ftpResourceOwner, objvCoursewareCase_Resource_Rel_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.FileOriginName, objvCoursewareCase_Resource_Rel_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.IsExistFile) == true)
{
if (objvCoursewareCase_Resource_Rel_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareCase_Resource_Rel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareCase_Resource_Rel.IsExistFile);
}
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.FileNewName, objvCoursewareCase_Resource_Rel_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.FileOldName, objvCoursewareCase_Resource_Rel_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.IsMain) == true)
{
if (objvCoursewareCase_Resource_Rel_Cond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareCase_Resource_Rel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareCase_Resource_Rel.IsMain);
}
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.id_UsingMode) == true)
{
string strComparisonOp_id_UsingMode = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.id_UsingMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.id_UsingMode, objvCoursewareCase_Resource_Rel_Cond.id_UsingMode, strComparisonOp_id_UsingMode);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.IsVisible) == true)
{
if (objvCoursewareCase_Resource_Rel_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareCase_Resource_Rel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareCase_Resource_Rel.IsVisible);
}
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.IndexNO) == true)
{
string strComparisonOp_IndexNO = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareCase_Resource_Rel.IndexNO, objvCoursewareCase_Resource_Rel_Cond.IndexNO, strComparisonOp_IndexNO);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareCase_Resource_Rel.BrowseCount, objvCoursewareCase_Resource_Rel_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.UpdDate, objvCoursewareCase_Resource_Rel_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.UpdUser, objvCoursewareCase_Resource_Rel_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvCoursewareCase_Resource_Rel_Cond.IsUpdated(convCoursewareCase_Resource_Rel.Memo) == true)
{
string strComparisonOp_Memo = objvCoursewareCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareCase_Resource_Rel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCase_Resource_Rel.Memo, objvCoursewareCase_Resource_Rel_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课件案例资源关系(vCoursewareCase_Resource_Rel)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCoursewareCase_Resource_RelWApi
{
private static readonly string mstrApiControllerName = "vCoursewareCase_Resource_RelApi";

 public clsvCoursewareCase_Resource_RelWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroteachCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCoursewareCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN = null;
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
objvCoursewareCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvCoursewareCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareCase_Resource_RelEN;
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
public static clsvCoursewareCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_WA_Cache(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN = null;
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
objvCoursewareCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvCoursewareCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareCase_Resource_RelEN;
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
public static clsvCoursewareCase_Resource_RelEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN = null;
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
objvCoursewareCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvCoursewareCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareCase_Resource_RelEN;
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
public static clsvCoursewareCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_Cache(long lngid_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCoursewareCase_Resource_RelEN._CurrTabName_S);
List<clsvCoursewareCase_Resource_RelEN> arrvCoursewareCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCoursewareCase_Resource_RelEN> arrvCoursewareCase_Resource_RelObjLst_Sel =
from objvCoursewareCase_Resource_RelEN in arrvCoursewareCase_Resource_RelObjLst_Cache
where objvCoursewareCase_Resource_RelEN.id_MicroteachCase_Resource_Rel == lngid_MicroteachCase_Resource_Rel
select objvCoursewareCase_Resource_RelEN;
if (arrvCoursewareCase_Resource_RelObjLst_Sel.Count() == 0)
{
   clsvCoursewareCase_Resource_RelEN obj = clsvCoursewareCase_Resource_RelWApi.GetObjByid_MicroteachCase_Resource_Rel(lngid_MicroteachCase_Resource_Rel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCoursewareCase_Resource_RelObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCoursewareCase_Resource_RelEN> GetObjLst(string strWhereCond)
{
 List<clsvCoursewareCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvCoursewareCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvCoursewareCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCoursewareCase_Resource_RelEN._CurrTabName_S);
List<clsvCoursewareCase_Resource_RelEN> arrvCoursewareCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCoursewareCase_Resource_RelEN> arrvCoursewareCase_Resource_RelObjLst_Sel =
from objvCoursewareCase_Resource_RelEN in arrvCoursewareCase_Resource_RelObjLst_Cache
where arrId_MicroteachCase_Resource_Rel.Contains(objvCoursewareCase_Resource_RelEN.id_MicroteachCase_Resource_Rel)
select objvCoursewareCase_Resource_RelEN;
return arrvCoursewareCase_Resource_RelObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCoursewareCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_WA_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvCoursewareCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCase_Resource_RelEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCoursewareCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCase_Resource_RelEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCoursewareCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCase_Resource_RelEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCoursewareCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCase_Resource_RelEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCoursewareCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvCoursewareCase_Resource_RelENS">源对象</param>
 /// <param name = "objvCoursewareCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelENS, clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelENT)
{
try
{
objvCoursewareCase_Resource_RelENT.id_MicroteachCase_Resource_Rel = objvCoursewareCase_Resource_RelENS.id_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
objvCoursewareCase_Resource_RelENT.FuncModuleId = objvCoursewareCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvCoursewareCase_Resource_RelENT.FuncModuleName = objvCoursewareCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvCoursewareCase_Resource_RelENT.id_MicroteachCase = objvCoursewareCase_Resource_RelENS.id_MicroteachCase; //微格教学案例流水号
objvCoursewareCase_Resource_RelENT.CoursewareCaseID = objvCoursewareCase_Resource_RelENS.CoursewareCaseID; //课件教学案例ID
objvCoursewareCase_Resource_RelENT.CoursewareCaseName = objvCoursewareCase_Resource_RelENS.CoursewareCaseName; //课件教学案例名称
objvCoursewareCase_Resource_RelENT.CoursewareCaseTheme = objvCoursewareCase_Resource_RelENS.CoursewareCaseTheme; //课件教学案例主题词
objvCoursewareCase_Resource_RelENT.id_CoursewareCaseType = objvCoursewareCase_Resource_RelENS.id_CoursewareCaseType; //课件案例类型流水号
objvCoursewareCase_Resource_RelENT.CoursewareCaseTypeName = objvCoursewareCase_Resource_RelENS.CoursewareCaseTypeName; //课件案例类型名称
objvCoursewareCase_Resource_RelENT.CoursewareCaseText = objvCoursewareCase_Resource_RelENS.CoursewareCaseText; //案例文本内容
objvCoursewareCase_Resource_RelENT.CoursewareCaseDate = objvCoursewareCase_Resource_RelENS.CoursewareCaseDate; //课件教学日期
objvCoursewareCase_Resource_RelENT.CoursewareCaseTime = objvCoursewareCase_Resource_RelENS.CoursewareCaseTime; //课件教学时间
objvCoursewareCase_Resource_RelENT.CoursewareCaseDateIn = objvCoursewareCase_Resource_RelENS.CoursewareCaseDateIn; //案例入库日期
objvCoursewareCase_Resource_RelENT.CoursewareCaseTimeIn = objvCoursewareCase_Resource_RelENS.CoursewareCaseTimeIn; //案例入库时间
objvCoursewareCase_Resource_RelENT.id_StudyLevel = objvCoursewareCase_Resource_RelENS.id_StudyLevel; //id_StudyLevel
objvCoursewareCase_Resource_RelENT.StudyLevelName = objvCoursewareCase_Resource_RelENS.StudyLevelName; //学段名称
objvCoursewareCase_Resource_RelENT.id_TeachingPlan = objvCoursewareCase_Resource_RelENS.id_TeachingPlan; //教案流水号
objvCoursewareCase_Resource_RelENT.Id_CaseType = objvCoursewareCase_Resource_RelENS.Id_CaseType; //案例类型流水号
objvCoursewareCase_Resource_RelENT.id_Discipline = objvCoursewareCase_Resource_RelENS.id_Discipline; //学科流水号
objvCoursewareCase_Resource_RelENT.DisciplineID = objvCoursewareCase_Resource_RelENS.DisciplineID; //学科ID
objvCoursewareCase_Resource_RelENT.DisciplineName = objvCoursewareCase_Resource_RelENS.DisciplineName; //学科名称
objvCoursewareCase_Resource_RelENT.senateGaugeVersionID = objvCoursewareCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvCoursewareCase_Resource_RelENT.senateGaugeVersionName = objvCoursewareCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvCoursewareCase_Resource_RelENT.senateGaugeVersionTtlScore = objvCoursewareCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCoursewareCase_Resource_RelENT.VersionNo = objvCoursewareCase_Resource_RelENS.VersionNo; //版本号
objvCoursewareCase_Resource_RelENT.id_TeachSkill = objvCoursewareCase_Resource_RelENS.id_TeachSkill; //教学技能流水号
objvCoursewareCase_Resource_RelENT.TeachSkillID = objvCoursewareCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvCoursewareCase_Resource_RelENT.SkillTypeName = objvCoursewareCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvCoursewareCase_Resource_RelENT.TeachSkillName = objvCoursewareCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvCoursewareCase_Resource_RelENT.TeachSkillTheory = objvCoursewareCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvCoursewareCase_Resource_RelENT.TeachSkillOperMethod = objvCoursewareCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCoursewareCase_Resource_RelENT.id_SkillType = objvCoursewareCase_Resource_RelENS.id_SkillType; //技能类型流水号
objvCoursewareCase_Resource_RelENT.SkillTypeID = objvCoursewareCase_Resource_RelENS.SkillTypeID; //技能类型ID
objvCoursewareCase_Resource_RelENT.CaseLevelId = objvCoursewareCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvCoursewareCase_Resource_RelENT.OwnerId = objvCoursewareCase_Resource_RelENS.OwnerId; //拥有者Id
objvCoursewareCase_Resource_RelENT.StuName = objvCoursewareCase_Resource_RelENS.StuName; //姓名
objvCoursewareCase_Resource_RelENT.StuID = objvCoursewareCase_Resource_RelENS.StuID; //学号
objvCoursewareCase_Resource_RelENT.PoliticsName = objvCoursewareCase_Resource_RelENS.PoliticsName; //政治面貌
objvCoursewareCase_Resource_RelENT.SexDesc = objvCoursewareCase_Resource_RelENS.SexDesc; //性别名称
objvCoursewareCase_Resource_RelENT.EthnicName = objvCoursewareCase_Resource_RelENS.EthnicName; //民族名称
objvCoursewareCase_Resource_RelENT.UniZoneDesc = objvCoursewareCase_Resource_RelENS.UniZoneDesc; //校区名称
objvCoursewareCase_Resource_RelENT.StuTypeDesc = objvCoursewareCase_Resource_RelENS.StuTypeDesc; //学生类别名称
objvCoursewareCase_Resource_RelENT.id_XzCollege = objvCoursewareCase_Resource_RelENS.id_XzCollege; //学院流水号
objvCoursewareCase_Resource_RelENT.CollegeName = objvCoursewareCase_Resource_RelENS.CollegeName; //学院名称
objvCoursewareCase_Resource_RelENT.CollegeNameA = objvCoursewareCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvCoursewareCase_Resource_RelENT.id_XzMajor = objvCoursewareCase_Resource_RelENS.id_XzMajor; //专业流水号
objvCoursewareCase_Resource_RelENT.MajorName = objvCoursewareCase_Resource_RelENS.MajorName; //专业名称
objvCoursewareCase_Resource_RelENT.id_GradeBase = objvCoursewareCase_Resource_RelENS.id_GradeBase; //年级流水号
objvCoursewareCase_Resource_RelENT.GradeBaseName = objvCoursewareCase_Resource_RelENS.GradeBaseName; //年级名称
objvCoursewareCase_Resource_RelENT.id_AdminCls = objvCoursewareCase_Resource_RelENS.id_AdminCls; //行政班流水号
objvCoursewareCase_Resource_RelENT.AdminClsId = objvCoursewareCase_Resource_RelENS.AdminClsId; //行政班代号
objvCoursewareCase_Resource_RelENT.AdminClsName = objvCoursewareCase_Resource_RelENS.AdminClsName; //行政班名称
objvCoursewareCase_Resource_RelENT.Birthday = objvCoursewareCase_Resource_RelENS.Birthday; //出生日期
objvCoursewareCase_Resource_RelENT.NativePlace = objvCoursewareCase_Resource_RelENS.NativePlace; //籍贯
objvCoursewareCase_Resource_RelENT.Duty = objvCoursewareCase_Resource_RelENS.Duty; //职位
objvCoursewareCase_Resource_RelENT.IDCardNo = objvCoursewareCase_Resource_RelENS.IDCardNo; //身份证号
objvCoursewareCase_Resource_RelENT.StuCardNo = objvCoursewareCase_Resource_RelENS.StuCardNo; //学生证号
objvCoursewareCase_Resource_RelENT.LiveAddress = objvCoursewareCase_Resource_RelENS.LiveAddress; //居住地址
objvCoursewareCase_Resource_RelENT.HomePhone = objvCoursewareCase_Resource_RelENS.HomePhone; //住宅电话
objvCoursewareCase_Resource_RelENT.EnrollmentDate = objvCoursewareCase_Resource_RelENS.EnrollmentDate; //入校日期
objvCoursewareCase_Resource_RelENT.PostCode = objvCoursewareCase_Resource_RelENS.PostCode; //邮编
objvCoursewareCase_Resource_RelENT.UserKindId = objvCoursewareCase_Resource_RelENS.UserKindId; //用户类别Id
objvCoursewareCase_Resource_RelENT.UserKindName = objvCoursewareCase_Resource_RelENS.UserKindName; //用户类别名
objvCoursewareCase_Resource_RelENT.UserTypeId = objvCoursewareCase_Resource_RelENS.UserTypeId; //用户类型Id
objvCoursewareCase_Resource_RelENT.IsDualVideo = objvCoursewareCase_Resource_RelENS.IsDualVideo; //是否双视频
objvCoursewareCase_Resource_RelENT.RecommendedDegreeId = objvCoursewareCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvCoursewareCase_Resource_RelENT.RecommendedDegreeName = objvCoursewareCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvCoursewareCase_Resource_RelENT.BrowseCount4Case = objvCoursewareCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvCoursewareCase_Resource_RelENT.id_Resource = objvCoursewareCase_Resource_RelENS.id_Resource; //资源流水号
objvCoursewareCase_Resource_RelENT.ResourceID = objvCoursewareCase_Resource_RelENS.ResourceID; //资源ID
objvCoursewareCase_Resource_RelENT.ResourceName = objvCoursewareCase_Resource_RelENS.ResourceName; //资源名称
objvCoursewareCase_Resource_RelENT.id_FtpResource = objvCoursewareCase_Resource_RelENS.id_FtpResource; //FTP资源流水号
objvCoursewareCase_Resource_RelENT.id_File = objvCoursewareCase_Resource_RelENS.id_File; //文件流水号
objvCoursewareCase_Resource_RelENT.FileName = objvCoursewareCase_Resource_RelENS.FileName; //文件名称
objvCoursewareCase_Resource_RelENT.FileType = objvCoursewareCase_Resource_RelENS.FileType; //文件类型
objvCoursewareCase_Resource_RelENT.SaveDate = objvCoursewareCase_Resource_RelENS.SaveDate; //创建日期
objvCoursewareCase_Resource_RelENT.FileSize = objvCoursewareCase_Resource_RelENS.FileSize; //文件大小
objvCoursewareCase_Resource_RelENT.SaveTime = objvCoursewareCase_Resource_RelENS.SaveTime; //创建时间
objvCoursewareCase_Resource_RelENT.FtpResourceID = objvCoursewareCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvCoursewareCase_Resource_RelENT.FileOriginalName = objvCoursewareCase_Resource_RelENS.FileOriginalName; //文件原名
objvCoursewareCase_Resource_RelENT.FileDirName = objvCoursewareCase_Resource_RelENS.FileDirName; //文件目录名
objvCoursewareCase_Resource_RelENT.FileRename = objvCoursewareCase_Resource_RelENS.FileRename; //文件新名
objvCoursewareCase_Resource_RelENT.FileUpDate = objvCoursewareCase_Resource_RelENS.FileUpDate; //创建日期
objvCoursewareCase_Resource_RelENT.FileUpTime = objvCoursewareCase_Resource_RelENS.FileUpTime; //创建时间
objvCoursewareCase_Resource_RelENT.SaveMode = objvCoursewareCase_Resource_RelENS.SaveMode; //文件存放方式
objvCoursewareCase_Resource_RelENT.id_ResourceType = objvCoursewareCase_Resource_RelENS.id_ResourceType; //资源类型流水号
objvCoursewareCase_Resource_RelENT.ResourceTypeID = objvCoursewareCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvCoursewareCase_Resource_RelENT.ResourceTypeName = objvCoursewareCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvCoursewareCase_Resource_RelENT.ResourceOwner = objvCoursewareCase_Resource_RelENS.ResourceOwner; //上传者
objvCoursewareCase_Resource_RelENT.ftpFileType = objvCoursewareCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvCoursewareCase_Resource_RelENT.ftpFileSize = objvCoursewareCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvCoursewareCase_Resource_RelENT.ftpResourceOwner = objvCoursewareCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvCoursewareCase_Resource_RelENT.FileOriginName = objvCoursewareCase_Resource_RelENS.FileOriginName; //原文件名
objvCoursewareCase_Resource_RelENT.IsExistFile = objvCoursewareCase_Resource_RelENS.IsExistFile; //是否存在文件
objvCoursewareCase_Resource_RelENT.FileNewName = objvCoursewareCase_Resource_RelENS.FileNewName; //新文件名
objvCoursewareCase_Resource_RelENT.FileOldName = objvCoursewareCase_Resource_RelENS.FileOldName; //旧文件名
objvCoursewareCase_Resource_RelENT.IsMain = objvCoursewareCase_Resource_RelENS.IsMain; //是否主资源
objvCoursewareCase_Resource_RelENT.id_UsingMode = objvCoursewareCase_Resource_RelENS.id_UsingMode; //资源使用模式流水号
objvCoursewareCase_Resource_RelENT.IsVisible = objvCoursewareCase_Resource_RelENS.IsVisible; //是否显示
objvCoursewareCase_Resource_RelENT.IndexNO = objvCoursewareCase_Resource_RelENS.IndexNO; //序号
objvCoursewareCase_Resource_RelENT.BrowseCount = objvCoursewareCase_Resource_RelENS.BrowseCount; //浏览次数
objvCoursewareCase_Resource_RelENT.UpdDate = objvCoursewareCase_Resource_RelENS.UpdDate; //修改日期
objvCoursewareCase_Resource_RelENT.UpdUser = objvCoursewareCase_Resource_RelENS.UpdUser; //修改人
objvCoursewareCase_Resource_RelENT.Memo = objvCoursewareCase_Resource_RelENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvCoursewareCase_Resource_RelEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCoursewareCase_Resource_RelEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCoursewareCase_Resource_RelEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCoursewareCase_Resource_RelEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCoursewareCase_Resource_RelEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCoursewareCase_Resource_RelEN.AttributeName)
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
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindWApi没有刷新缓存机制(clsUserKindWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCoursewareCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCoursewareCaseWApi没有刷新缓存机制(clsCoursewareCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCoursewareCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCoursewareCaseTypeWApi没有刷新缓存机制(clsCoursewareCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvCoursewareCase_Resource_RelObjLst_Cache == null)
//{
//arrvCoursewareCase_Resource_RelObjLst_Cache = await clsvCoursewareCase_Resource_RelWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCoursewareCase_Resource_RelEN._CurrTabName_S);
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
public static List<clsvCoursewareCase_Resource_RelEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCoursewareCase_Resource_RelEN._CurrTabName_S);
List<clsvCoursewareCase_Resource_RelEN> arrvCoursewareCase_Resource_RelObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCoursewareCase_Resource_RelObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCoursewareCase_Resource_RelEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCoursewareCase_Resource_Rel.id_MicroteachCase_Resource_Rel, Type.GetType("System.Int64"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.CoursewareCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.CoursewareCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.CoursewareCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.id_CoursewareCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.CoursewareCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.CoursewareCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.CoursewareCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.CoursewareCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.CoursewareCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.PoliticsName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.SexDesc, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.EthnicName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.UniZoneDesc, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.StuTypeDesc, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.id_AdminCls, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.AdminClsId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.AdminClsName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.Birthday, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.NativePlace, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.Duty, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.IDCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.StuCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.LiveAddress, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.HomePhone, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.EnrollmentDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.PostCode, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.UserKindName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.ResourceName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.IsMain, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.id_UsingMode, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.IndexNO, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCase_Resource_Rel.Memo, Type.GetType("System.String"));
foreach (clsvCoursewareCase_Resource_RelEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCoursewareCase_Resource_Rel.id_MicroteachCase_Resource_Rel] = objInFor[convCoursewareCase_Resource_Rel.id_MicroteachCase_Resource_Rel];
objDR[convCoursewareCase_Resource_Rel.FuncModuleId] = objInFor[convCoursewareCase_Resource_Rel.FuncModuleId];
objDR[convCoursewareCase_Resource_Rel.FuncModuleName] = objInFor[convCoursewareCase_Resource_Rel.FuncModuleName];
objDR[convCoursewareCase_Resource_Rel.id_MicroteachCase] = objInFor[convCoursewareCase_Resource_Rel.id_MicroteachCase];
objDR[convCoursewareCase_Resource_Rel.CoursewareCaseID] = objInFor[convCoursewareCase_Resource_Rel.CoursewareCaseID];
objDR[convCoursewareCase_Resource_Rel.CoursewareCaseName] = objInFor[convCoursewareCase_Resource_Rel.CoursewareCaseName];
objDR[convCoursewareCase_Resource_Rel.CoursewareCaseTheme] = objInFor[convCoursewareCase_Resource_Rel.CoursewareCaseTheme];
objDR[convCoursewareCase_Resource_Rel.id_CoursewareCaseType] = objInFor[convCoursewareCase_Resource_Rel.id_CoursewareCaseType];
objDR[convCoursewareCase_Resource_Rel.CoursewareCaseTypeName] = objInFor[convCoursewareCase_Resource_Rel.CoursewareCaseTypeName];
objDR[convCoursewareCase_Resource_Rel.CoursewareCaseText] = objInFor[convCoursewareCase_Resource_Rel.CoursewareCaseText];
objDR[convCoursewareCase_Resource_Rel.CoursewareCaseDate] = objInFor[convCoursewareCase_Resource_Rel.CoursewareCaseDate];
objDR[convCoursewareCase_Resource_Rel.CoursewareCaseTime] = objInFor[convCoursewareCase_Resource_Rel.CoursewareCaseTime];
objDR[convCoursewareCase_Resource_Rel.CoursewareCaseDateIn] = objInFor[convCoursewareCase_Resource_Rel.CoursewareCaseDateIn];
objDR[convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn] = objInFor[convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn];
objDR[convCoursewareCase_Resource_Rel.id_StudyLevel] = objInFor[convCoursewareCase_Resource_Rel.id_StudyLevel];
objDR[convCoursewareCase_Resource_Rel.StudyLevelName] = objInFor[convCoursewareCase_Resource_Rel.StudyLevelName];
objDR[convCoursewareCase_Resource_Rel.id_TeachingPlan] = objInFor[convCoursewareCase_Resource_Rel.id_TeachingPlan];
objDR[convCoursewareCase_Resource_Rel.Id_CaseType] = objInFor[convCoursewareCase_Resource_Rel.Id_CaseType];
objDR[convCoursewareCase_Resource_Rel.id_Discipline] = objInFor[convCoursewareCase_Resource_Rel.id_Discipline];
objDR[convCoursewareCase_Resource_Rel.DisciplineID] = objInFor[convCoursewareCase_Resource_Rel.DisciplineID];
objDR[convCoursewareCase_Resource_Rel.DisciplineName] = objInFor[convCoursewareCase_Resource_Rel.DisciplineName];
objDR[convCoursewareCase_Resource_Rel.senateGaugeVersionID] = objInFor[convCoursewareCase_Resource_Rel.senateGaugeVersionID];
objDR[convCoursewareCase_Resource_Rel.senateGaugeVersionName] = objInFor[convCoursewareCase_Resource_Rel.senateGaugeVersionName];
objDR[convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore] = objInFor[convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore];
objDR[convCoursewareCase_Resource_Rel.VersionNo] = objInFor[convCoursewareCase_Resource_Rel.VersionNo];
objDR[convCoursewareCase_Resource_Rel.id_TeachSkill] = objInFor[convCoursewareCase_Resource_Rel.id_TeachSkill];
objDR[convCoursewareCase_Resource_Rel.TeachSkillID] = objInFor[convCoursewareCase_Resource_Rel.TeachSkillID];
objDR[convCoursewareCase_Resource_Rel.SkillTypeName] = objInFor[convCoursewareCase_Resource_Rel.SkillTypeName];
objDR[convCoursewareCase_Resource_Rel.TeachSkillName] = objInFor[convCoursewareCase_Resource_Rel.TeachSkillName];
objDR[convCoursewareCase_Resource_Rel.TeachSkillTheory] = objInFor[convCoursewareCase_Resource_Rel.TeachSkillTheory];
objDR[convCoursewareCase_Resource_Rel.TeachSkillOperMethod] = objInFor[convCoursewareCase_Resource_Rel.TeachSkillOperMethod];
objDR[convCoursewareCase_Resource_Rel.id_SkillType] = objInFor[convCoursewareCase_Resource_Rel.id_SkillType];
objDR[convCoursewareCase_Resource_Rel.SkillTypeID] = objInFor[convCoursewareCase_Resource_Rel.SkillTypeID];
objDR[convCoursewareCase_Resource_Rel.CaseLevelId] = objInFor[convCoursewareCase_Resource_Rel.CaseLevelId];
objDR[convCoursewareCase_Resource_Rel.OwnerId] = objInFor[convCoursewareCase_Resource_Rel.OwnerId];
objDR[convCoursewareCase_Resource_Rel.StuName] = objInFor[convCoursewareCase_Resource_Rel.StuName];
objDR[convCoursewareCase_Resource_Rel.StuID] = objInFor[convCoursewareCase_Resource_Rel.StuID];
objDR[convCoursewareCase_Resource_Rel.PoliticsName] = objInFor[convCoursewareCase_Resource_Rel.PoliticsName];
objDR[convCoursewareCase_Resource_Rel.SexDesc] = objInFor[convCoursewareCase_Resource_Rel.SexDesc];
objDR[convCoursewareCase_Resource_Rel.EthnicName] = objInFor[convCoursewareCase_Resource_Rel.EthnicName];
objDR[convCoursewareCase_Resource_Rel.UniZoneDesc] = objInFor[convCoursewareCase_Resource_Rel.UniZoneDesc];
objDR[convCoursewareCase_Resource_Rel.StuTypeDesc] = objInFor[convCoursewareCase_Resource_Rel.StuTypeDesc];
objDR[convCoursewareCase_Resource_Rel.id_XzCollege] = objInFor[convCoursewareCase_Resource_Rel.id_XzCollege];
objDR[convCoursewareCase_Resource_Rel.CollegeName] = objInFor[convCoursewareCase_Resource_Rel.CollegeName];
objDR[convCoursewareCase_Resource_Rel.CollegeNameA] = objInFor[convCoursewareCase_Resource_Rel.CollegeNameA];
objDR[convCoursewareCase_Resource_Rel.id_XzMajor] = objInFor[convCoursewareCase_Resource_Rel.id_XzMajor];
objDR[convCoursewareCase_Resource_Rel.MajorName] = objInFor[convCoursewareCase_Resource_Rel.MajorName];
objDR[convCoursewareCase_Resource_Rel.id_GradeBase] = objInFor[convCoursewareCase_Resource_Rel.id_GradeBase];
objDR[convCoursewareCase_Resource_Rel.GradeBaseName] = objInFor[convCoursewareCase_Resource_Rel.GradeBaseName];
objDR[convCoursewareCase_Resource_Rel.id_AdminCls] = objInFor[convCoursewareCase_Resource_Rel.id_AdminCls];
objDR[convCoursewareCase_Resource_Rel.AdminClsId] = objInFor[convCoursewareCase_Resource_Rel.AdminClsId];
objDR[convCoursewareCase_Resource_Rel.AdminClsName] = objInFor[convCoursewareCase_Resource_Rel.AdminClsName];
objDR[convCoursewareCase_Resource_Rel.Birthday] = objInFor[convCoursewareCase_Resource_Rel.Birthday];
objDR[convCoursewareCase_Resource_Rel.NativePlace] = objInFor[convCoursewareCase_Resource_Rel.NativePlace];
objDR[convCoursewareCase_Resource_Rel.Duty] = objInFor[convCoursewareCase_Resource_Rel.Duty];
objDR[convCoursewareCase_Resource_Rel.IDCardNo] = objInFor[convCoursewareCase_Resource_Rel.IDCardNo];
objDR[convCoursewareCase_Resource_Rel.StuCardNo] = objInFor[convCoursewareCase_Resource_Rel.StuCardNo];
objDR[convCoursewareCase_Resource_Rel.LiveAddress] = objInFor[convCoursewareCase_Resource_Rel.LiveAddress];
objDR[convCoursewareCase_Resource_Rel.HomePhone] = objInFor[convCoursewareCase_Resource_Rel.HomePhone];
objDR[convCoursewareCase_Resource_Rel.EnrollmentDate] = objInFor[convCoursewareCase_Resource_Rel.EnrollmentDate];
objDR[convCoursewareCase_Resource_Rel.PostCode] = objInFor[convCoursewareCase_Resource_Rel.PostCode];
objDR[convCoursewareCase_Resource_Rel.UserKindId] = objInFor[convCoursewareCase_Resource_Rel.UserKindId];
objDR[convCoursewareCase_Resource_Rel.UserKindName] = objInFor[convCoursewareCase_Resource_Rel.UserKindName];
objDR[convCoursewareCase_Resource_Rel.UserTypeId] = objInFor[convCoursewareCase_Resource_Rel.UserTypeId];
objDR[convCoursewareCase_Resource_Rel.IsDualVideo] = objInFor[convCoursewareCase_Resource_Rel.IsDualVideo];
objDR[convCoursewareCase_Resource_Rel.RecommendedDegreeId] = objInFor[convCoursewareCase_Resource_Rel.RecommendedDegreeId];
objDR[convCoursewareCase_Resource_Rel.RecommendedDegreeName] = objInFor[convCoursewareCase_Resource_Rel.RecommendedDegreeName];
objDR[convCoursewareCase_Resource_Rel.BrowseCount4Case] = objInFor[convCoursewareCase_Resource_Rel.BrowseCount4Case];
objDR[convCoursewareCase_Resource_Rel.id_Resource] = objInFor[convCoursewareCase_Resource_Rel.id_Resource];
objDR[convCoursewareCase_Resource_Rel.ResourceID] = objInFor[convCoursewareCase_Resource_Rel.ResourceID];
objDR[convCoursewareCase_Resource_Rel.ResourceName] = objInFor[convCoursewareCase_Resource_Rel.ResourceName];
objDR[convCoursewareCase_Resource_Rel.id_FtpResource] = objInFor[convCoursewareCase_Resource_Rel.id_FtpResource];
objDR[convCoursewareCase_Resource_Rel.id_File] = objInFor[convCoursewareCase_Resource_Rel.id_File];
objDR[convCoursewareCase_Resource_Rel.FileName] = objInFor[convCoursewareCase_Resource_Rel.FileName];
objDR[convCoursewareCase_Resource_Rel.FileType] = objInFor[convCoursewareCase_Resource_Rel.FileType];
objDR[convCoursewareCase_Resource_Rel.SaveDate] = objInFor[convCoursewareCase_Resource_Rel.SaveDate];
objDR[convCoursewareCase_Resource_Rel.FileSize] = objInFor[convCoursewareCase_Resource_Rel.FileSize];
objDR[convCoursewareCase_Resource_Rel.SaveTime] = objInFor[convCoursewareCase_Resource_Rel.SaveTime];
objDR[convCoursewareCase_Resource_Rel.FtpResourceID] = objInFor[convCoursewareCase_Resource_Rel.FtpResourceID];
objDR[convCoursewareCase_Resource_Rel.FileOriginalName] = objInFor[convCoursewareCase_Resource_Rel.FileOriginalName];
objDR[convCoursewareCase_Resource_Rel.FileDirName] = objInFor[convCoursewareCase_Resource_Rel.FileDirName];
objDR[convCoursewareCase_Resource_Rel.FileRename] = objInFor[convCoursewareCase_Resource_Rel.FileRename];
objDR[convCoursewareCase_Resource_Rel.FileUpDate] = objInFor[convCoursewareCase_Resource_Rel.FileUpDate];
objDR[convCoursewareCase_Resource_Rel.FileUpTime] = objInFor[convCoursewareCase_Resource_Rel.FileUpTime];
objDR[convCoursewareCase_Resource_Rel.SaveMode] = objInFor[convCoursewareCase_Resource_Rel.SaveMode];
objDR[convCoursewareCase_Resource_Rel.id_ResourceType] = objInFor[convCoursewareCase_Resource_Rel.id_ResourceType];
objDR[convCoursewareCase_Resource_Rel.ResourceTypeID] = objInFor[convCoursewareCase_Resource_Rel.ResourceTypeID];
objDR[convCoursewareCase_Resource_Rel.ResourceTypeName] = objInFor[convCoursewareCase_Resource_Rel.ResourceTypeName];
objDR[convCoursewareCase_Resource_Rel.ResourceOwner] = objInFor[convCoursewareCase_Resource_Rel.ResourceOwner];
objDR[convCoursewareCase_Resource_Rel.ftpFileType] = objInFor[convCoursewareCase_Resource_Rel.ftpFileType];
objDR[convCoursewareCase_Resource_Rel.ftpFileSize] = objInFor[convCoursewareCase_Resource_Rel.ftpFileSize];
objDR[convCoursewareCase_Resource_Rel.ftpResourceOwner] = objInFor[convCoursewareCase_Resource_Rel.ftpResourceOwner];
objDR[convCoursewareCase_Resource_Rel.FileOriginName] = objInFor[convCoursewareCase_Resource_Rel.FileOriginName];
objDR[convCoursewareCase_Resource_Rel.IsExistFile] = objInFor[convCoursewareCase_Resource_Rel.IsExistFile];
objDR[convCoursewareCase_Resource_Rel.FileNewName] = objInFor[convCoursewareCase_Resource_Rel.FileNewName];
objDR[convCoursewareCase_Resource_Rel.FileOldName] = objInFor[convCoursewareCase_Resource_Rel.FileOldName];
objDR[convCoursewareCase_Resource_Rel.IsMain] = objInFor[convCoursewareCase_Resource_Rel.IsMain];
objDR[convCoursewareCase_Resource_Rel.id_UsingMode] = objInFor[convCoursewareCase_Resource_Rel.id_UsingMode];
objDR[convCoursewareCase_Resource_Rel.IsVisible] = objInFor[convCoursewareCase_Resource_Rel.IsVisible];
objDR[convCoursewareCase_Resource_Rel.IndexNO] = objInFor[convCoursewareCase_Resource_Rel.IndexNO];
objDR[convCoursewareCase_Resource_Rel.BrowseCount] = objInFor[convCoursewareCase_Resource_Rel.BrowseCount];
objDR[convCoursewareCase_Resource_Rel.UpdDate] = objInFor[convCoursewareCase_Resource_Rel.UpdDate];
objDR[convCoursewareCase_Resource_Rel.UpdUser] = objInFor[convCoursewareCase_Resource_Rel.UpdUser];
objDR[convCoursewareCase_Resource_Rel.Memo] = objInFor[convCoursewareCase_Resource_Rel.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}