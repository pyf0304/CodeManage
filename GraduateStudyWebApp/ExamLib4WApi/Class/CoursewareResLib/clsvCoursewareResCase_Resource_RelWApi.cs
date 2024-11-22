
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareResCase_Resource_RelWApi
 表名:vCoursewareResCase_Resource_Rel(01120432)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:40
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件资源库
 模块英文名:CoursewareResLib
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
public static class clsvCoursewareResCase_Resource_RelWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN Setid_MicroteachCase_Resource_Rel(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, long lngid_MicroteachCase_Resource_Rel, string strComparisonOp="")
	{
objvCoursewareResCase_Resource_RelEN.id_MicroteachCase_Resource_Rel = lngid_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.id_MicroteachCase_Resource_Rel) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.id_MicroteachCase_Resource_Rel, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_MicroteachCase_Resource_Rel] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetFuncModuleId(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCoursewareResCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCoursewareResCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCoursewareResCase_Resource_Rel.FuncModuleId);
objvCoursewareResCase_Resource_RelEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.FuncModuleId) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.FuncModuleId, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FuncModuleId] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetFuncModuleName(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCoursewareResCase_Resource_Rel.FuncModuleName);
objvCoursewareResCase_Resource_RelEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.FuncModuleName) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.FuncModuleName, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FuncModuleName] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN Setid_MicroteachCase(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convCoursewareResCase_Resource_Rel.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convCoursewareResCase_Resource_Rel.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convCoursewareResCase_Resource_Rel.id_MicroteachCase);
objvCoursewareResCase_Resource_RelEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.id_MicroteachCase) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.id_MicroteachCase, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_MicroteachCase] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetCoursewareResCaseID(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strCoursewareResCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseID, 8, convCoursewareResCase_Resource_Rel.CoursewareResCaseID);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseID, 8, convCoursewareResCase_Resource_Rel.CoursewareResCaseID);
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseID = strCoursewareResCaseID; //课件资源案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.CoursewareResCaseID) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.CoursewareResCaseID, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CoursewareResCaseID] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetCoursewareResCaseName(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strCoursewareResCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseName, 100, convCoursewareResCase_Resource_Rel.CoursewareResCaseName);
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseName = strCoursewareResCaseName; //课件资源案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.CoursewareResCaseName) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.CoursewareResCaseName, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CoursewareResCaseName] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetCoursewareResCaseTheme(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strCoursewareResCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseTheme, 200, convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme);
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTheme = strCoursewareResCaseTheme; //课件资源案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetCoursewareResCaseText(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strCoursewareResCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseText, 8000, convCoursewareResCase_Resource_Rel.CoursewareResCaseText);
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseText = strCoursewareResCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.CoursewareResCaseText) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.CoursewareResCaseText, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CoursewareResCaseText] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN Setid_CoursewareResCaseType(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strid_CoursewareResCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CoursewareResCaseType, 4, convCoursewareResCase_Resource_Rel.id_CoursewareResCaseType);
clsCheckSql.CheckFieldForeignKey(strid_CoursewareResCaseType, 4, convCoursewareResCase_Resource_Rel.id_CoursewareResCaseType);
objvCoursewareResCase_Resource_RelEN.id_CoursewareResCaseType = strid_CoursewareResCaseType; //课件资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.id_CoursewareResCaseType) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.id_CoursewareResCaseType, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_CoursewareResCaseType] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetCoursewareResCaseTypeName(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strCoursewareResCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseTypeName, 30, convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName);
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTypeName = strCoursewareResCaseTypeName; //课件资源案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetCoursewareResCaseDate(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strCoursewareResCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseDate, 8, convCoursewareResCase_Resource_Rel.CoursewareResCaseDate);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseDate, 8, convCoursewareResCase_Resource_Rel.CoursewareResCaseDate);
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseDate = strCoursewareResCaseDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.CoursewareResCaseDate) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.CoursewareResCaseDate, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CoursewareResCaseDate] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetCoursewareResCaseTime(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strCoursewareResCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseTime, 6, convCoursewareResCase_Resource_Rel.CoursewareResCaseTime);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseTime, 6, convCoursewareResCase_Resource_Rel.CoursewareResCaseTime);
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTime = strCoursewareResCaseTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.CoursewareResCaseTime) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.CoursewareResCaseTime, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CoursewareResCaseTime] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetCoursewareResCaseDateIn(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strCoursewareResCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseDateIn, 8, convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseDateIn, 8, convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn);
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseDateIn = strCoursewareResCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetCoursewareResCaseTimeIn(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strCoursewareResCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseTimeIn, 6, convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strCoursewareResCaseTimeIn, 6, convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn);
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTimeIn = strCoursewareResCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetOwnerId(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCoursewareResCase_Resource_Rel.OwnerId);
objvCoursewareResCase_Resource_RelEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.OwnerId) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.OwnerId, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.OwnerId] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetOwnerName(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCoursewareResCase_Resource_Rel.OwnerName);
objvCoursewareResCase_Resource_RelEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.OwnerName) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.OwnerName, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.OwnerName] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetOwnerNameWithId(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convCoursewareResCase_Resource_Rel.OwnerNameWithId);
objvCoursewareResCase_Resource_RelEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.OwnerNameWithId) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.OwnerNameWithId, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.OwnerNameWithId] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN Setid_StudyLevel(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convCoursewareResCase_Resource_Rel.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convCoursewareResCase_Resource_Rel.id_StudyLevel);
objvCoursewareResCase_Resource_RelEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.id_StudyLevel) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.id_StudyLevel, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_StudyLevel] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetStudyLevelName(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convCoursewareResCase_Resource_Rel.StudyLevelName);
objvCoursewareResCase_Resource_RelEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.StudyLevelName) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.StudyLevelName, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.StudyLevelName] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN Setid_TeachingPlan(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convCoursewareResCase_Resource_Rel.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convCoursewareResCase_Resource_Rel.id_TeachingPlan);
objvCoursewareResCase_Resource_RelEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.id_TeachingPlan) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.id_TeachingPlan, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_TeachingPlan] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN Setid_Discipline(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convCoursewareResCase_Resource_Rel.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convCoursewareResCase_Resource_Rel.id_Discipline);
objvCoursewareResCase_Resource_RelEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.id_Discipline) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.id_Discipline, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_Discipline] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetDisciplineID(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convCoursewareResCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convCoursewareResCase_Resource_Rel.DisciplineID);
objvCoursewareResCase_Resource_RelEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.DisciplineID) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.DisciplineID, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.DisciplineID] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetDisciplineName(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convCoursewareResCase_Resource_Rel.DisciplineName);
objvCoursewareResCase_Resource_RelEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.DisciplineName) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.DisciplineName, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.DisciplineName] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetsenateGaugeVersionID(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convCoursewareResCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convCoursewareResCase_Resource_Rel.senateGaugeVersionID);
objvCoursewareResCase_Resource_RelEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.senateGaugeVersionID) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.senateGaugeVersionID, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.senateGaugeVersionID] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetsenateGaugeVersionName(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convCoursewareResCase_Resource_Rel.senateGaugeVersionName);
objvCoursewareResCase_Resource_RelEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.senateGaugeVersionName) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.senateGaugeVersionName, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.senateGaugeVersionName] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetsenateGaugeVersionTtlScore(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvCoursewareResCase_Resource_RelEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.senateGaugeVersionTtlScore) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetVersionNo(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, int intVersionNo, string strComparisonOp="")
	{
objvCoursewareResCase_Resource_RelEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.VersionNo) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.VersionNo, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.VersionNo] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN Setid_TeachSkill(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convCoursewareResCase_Resource_Rel.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convCoursewareResCase_Resource_Rel.id_TeachSkill);
objvCoursewareResCase_Resource_RelEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.id_TeachSkill) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.id_TeachSkill, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_TeachSkill] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetTeachSkillID(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convCoursewareResCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convCoursewareResCase_Resource_Rel.TeachSkillID);
objvCoursewareResCase_Resource_RelEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.TeachSkillID) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.TeachSkillID, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.TeachSkillID] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetSkillTypeName(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convCoursewareResCase_Resource_Rel.SkillTypeName);
objvCoursewareResCase_Resource_RelEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.SkillTypeName) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.SkillTypeName, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.SkillTypeName] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetTeachSkillName(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convCoursewareResCase_Resource_Rel.TeachSkillName);
objvCoursewareResCase_Resource_RelEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.TeachSkillName) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.TeachSkillName, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.TeachSkillName] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetTeachSkillTheory(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convCoursewareResCase_Resource_Rel.TeachSkillTheory);
objvCoursewareResCase_Resource_RelEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.TeachSkillTheory) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.TeachSkillTheory, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.TeachSkillTheory] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetTeachSkillOperMethod(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convCoursewareResCase_Resource_Rel.TeachSkillOperMethod);
objvCoursewareResCase_Resource_RelEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.TeachSkillOperMethod) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN Setid_SkillType(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convCoursewareResCase_Resource_Rel.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convCoursewareResCase_Resource_Rel.id_SkillType);
objvCoursewareResCase_Resource_RelEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.id_SkillType) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.id_SkillType, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_SkillType] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetSkillTypeID(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convCoursewareResCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convCoursewareResCase_Resource_Rel.SkillTypeID);
objvCoursewareResCase_Resource_RelEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.SkillTypeID) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.SkillTypeID, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.SkillTypeID] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetCaseLevelId(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convCoursewareResCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convCoursewareResCase_Resource_Rel.CaseLevelId);
objvCoursewareResCase_Resource_RelEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.CaseLevelId) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.CaseLevelId, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CaseLevelId] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetIsDualVideo(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvCoursewareResCase_Resource_RelEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.IsDualVideo) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.IsDualVideo, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.IsDualVideo] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN Setid_XzCollege(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCoursewareResCase_Resource_Rel.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCoursewareResCase_Resource_Rel.id_XzCollege);
objvCoursewareResCase_Resource_RelEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.id_XzCollege) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.id_XzCollege, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_XzCollege] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetCollegeID(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCoursewareResCase_Resource_Rel.CollegeID);
objvCoursewareResCase_Resource_RelEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.CollegeID) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.CollegeID, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CollegeID] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetCollegeName(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCoursewareResCase_Resource_Rel.CollegeName);
objvCoursewareResCase_Resource_RelEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.CollegeName) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.CollegeName, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CollegeName] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN Setid_XzMajor(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convCoursewareResCase_Resource_Rel.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convCoursewareResCase_Resource_Rel.id_XzMajor);
objvCoursewareResCase_Resource_RelEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.id_XzMajor) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.id_XzMajor, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_XzMajor] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetMajorID(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convCoursewareResCase_Resource_Rel.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convCoursewareResCase_Resource_Rel.MajorID);
objvCoursewareResCase_Resource_RelEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.MajorID) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.MajorID, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.MajorID] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetMajorName(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCoursewareResCase_Resource_Rel.MajorName);
objvCoursewareResCase_Resource_RelEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.MajorName) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.MajorName, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.MajorName] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetCourseId(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCoursewareResCase_Resource_Rel.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCoursewareResCase_Resource_Rel.CourseId);
objvCoursewareResCase_Resource_RelEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.CourseId) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.CourseId, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CourseId] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetCourseCode(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCoursewareResCase_Resource_Rel.CourseCode);
objvCoursewareResCase_Resource_RelEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.CourseCode) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.CourseCode, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CourseCode] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetCourseName(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCoursewareResCase_Resource_Rel.CourseName);
objvCoursewareResCase_Resource_RelEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.CourseName) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.CourseName, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CourseName] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetCourseChapterId(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convCoursewareResCase_Resource_Rel.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convCoursewareResCase_Resource_Rel.CourseChapterId);
objvCoursewareResCase_Resource_RelEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.CourseChapterId) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.CourseChapterId, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CourseChapterId] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetCourseChapterName(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convCoursewareResCase_Resource_Rel.CourseChapterName);
objvCoursewareResCase_Resource_RelEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.CourseChapterName) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.CourseChapterName, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CourseChapterName] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetParentNodeID(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convCoursewareResCase_Resource_Rel.ParentNodeID);
objvCoursewareResCase_Resource_RelEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.ParentNodeID) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.ParentNodeID, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.ParentNodeID] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetParentNodeName(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convCoursewareResCase_Resource_Rel.ParentNodeName);
objvCoursewareResCase_Resource_RelEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.ParentNodeName) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.ParentNodeName, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.ParentNodeName] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetViewCount(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, int intViewCount, string strComparisonOp="")
	{
objvCoursewareResCase_Resource_RelEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.ViewCount) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.ViewCount, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.ViewCount] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetIsShow(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, bool bolIsShow, string strComparisonOp="")
	{
objvCoursewareResCase_Resource_RelEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.IsShow) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.IsShow, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.IsShow] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetDownloadNumber(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, int intDownloadNumber, string strComparisonOp="")
	{
objvCoursewareResCase_Resource_RelEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.DownloadNumber) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.DownloadNumber, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.DownloadNumber] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetFileIntegration(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, int intFileIntegration, string strComparisonOp="")
	{
objvCoursewareResCase_Resource_RelEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.FileIntegration) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.FileIntegration, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileIntegration] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetLikeCount(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, long lngLikeCount, string strComparisonOp="")
	{
objvCoursewareResCase_Resource_RelEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.LikeCount) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.LikeCount, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.LikeCount] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetCollectionCount(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, long lngCollectionCount, string strComparisonOp="")
	{
objvCoursewareResCase_Resource_RelEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.CollectionCount) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.CollectionCount, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CollectionCount] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetRecommendedDegreeId(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convCoursewareResCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convCoursewareResCase_Resource_Rel.RecommendedDegreeId);
objvCoursewareResCase_Resource_RelEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.RecommendedDegreeId) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.RecommendedDegreeId, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.RecommendedDegreeId] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetRecommendedDegreeName(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convCoursewareResCase_Resource_Rel.RecommendedDegreeName);
objvCoursewareResCase_Resource_RelEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.RecommendedDegreeName) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.RecommendedDegreeName, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.RecommendedDegreeName] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetBrowseCount4Case(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvCoursewareResCase_Resource_RelEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.BrowseCount4Case) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.BrowseCount4Case, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.BrowseCount4Case] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetCollegeNameA(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convCoursewareResCase_Resource_Rel.CollegeNameA);
objvCoursewareResCase_Resource_RelEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.CollegeNameA) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.CollegeNameA, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CollegeNameA] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN Setid_Resource(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convCoursewareResCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convCoursewareResCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convCoursewareResCase_Resource_Rel.id_Resource);
objvCoursewareResCase_Resource_RelEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.id_Resource) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.id_Resource, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_Resource] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetResourceID(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceID, 8, convCoursewareResCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convCoursewareResCase_Resource_Rel.ResourceID);
objvCoursewareResCase_Resource_RelEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.ResourceID) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.ResourceID, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.ResourceID] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetResourceName(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceName, 100, convCoursewareResCase_Resource_Rel.ResourceName);
objvCoursewareResCase_Resource_RelEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.ResourceName) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.ResourceName, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.ResourceName] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN Setid_FtpResource(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convCoursewareResCase_Resource_Rel.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convCoursewareResCase_Resource_Rel.id_FtpResource);
objvCoursewareResCase_Resource_RelEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.id_FtpResource) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.id_FtpResource, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_FtpResource] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN Setid_File(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convCoursewareResCase_Resource_Rel.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convCoursewareResCase_Resource_Rel.id_File);
objvCoursewareResCase_Resource_RelEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.id_File) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.id_File, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_File] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetFileName(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convCoursewareResCase_Resource_Rel.FileName);
objvCoursewareResCase_Resource_RelEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.FileName) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.FileName, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileName] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetFileType(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convCoursewareResCase_Resource_Rel.FileType);
objvCoursewareResCase_Resource_RelEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.FileType) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.FileType, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileType] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetSaveDate(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convCoursewareResCase_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convCoursewareResCase_Resource_Rel.SaveDate);
objvCoursewareResCase_Resource_RelEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.SaveDate) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.SaveDate, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.SaveDate] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetFileSize(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convCoursewareResCase_Resource_Rel.FileSize);
objvCoursewareResCase_Resource_RelEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.FileSize) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.FileSize, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileSize] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetSaveTime(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convCoursewareResCase_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convCoursewareResCase_Resource_Rel.SaveTime);
objvCoursewareResCase_Resource_RelEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.SaveTime) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.SaveTime, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.SaveTime] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetFtpResourceID(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convCoursewareResCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convCoursewareResCase_Resource_Rel.FtpResourceID);
objvCoursewareResCase_Resource_RelEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.FtpResourceID) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.FtpResourceID, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FtpResourceID] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetFileOriginalName(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convCoursewareResCase_Resource_Rel.FileOriginalName);
objvCoursewareResCase_Resource_RelEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.FileOriginalName) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.FileOriginalName, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileOriginalName] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetFileDirName(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convCoursewareResCase_Resource_Rel.FileDirName);
objvCoursewareResCase_Resource_RelEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.FileDirName) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.FileDirName, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileDirName] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetFileRename(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convCoursewareResCase_Resource_Rel.FileRename);
objvCoursewareResCase_Resource_RelEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.FileRename) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.FileRename, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileRename] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetFileUpDate(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convCoursewareResCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convCoursewareResCase_Resource_Rel.FileUpDate);
objvCoursewareResCase_Resource_RelEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.FileUpDate) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.FileUpDate, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileUpDate] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetFileUpTime(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convCoursewareResCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convCoursewareResCase_Resource_Rel.FileUpTime);
objvCoursewareResCase_Resource_RelEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.FileUpTime) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.FileUpTime, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileUpTime] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetSaveMode(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, bool bolSaveMode, string strComparisonOp="")
	{
objvCoursewareResCase_Resource_RelEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.SaveMode) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.SaveMode, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.SaveMode] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN Setid_ResourceType(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convCoursewareResCase_Resource_Rel.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convCoursewareResCase_Resource_Rel.id_ResourceType);
objvCoursewareResCase_Resource_RelEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.id_ResourceType) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.id_ResourceType, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_ResourceType] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetResourceTypeID(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convCoursewareResCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convCoursewareResCase_Resource_Rel.ResourceTypeID);
objvCoursewareResCase_Resource_RelEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.ResourceTypeID) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.ResourceTypeID, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.ResourceTypeID] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetResourceTypeName(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convCoursewareResCase_Resource_Rel.ResourceTypeName);
objvCoursewareResCase_Resource_RelEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.ResourceTypeName) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.ResourceTypeName, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.ResourceTypeName] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetResourceOwner(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convCoursewareResCase_Resource_Rel.ResourceOwner);
objvCoursewareResCase_Resource_RelEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.ResourceOwner) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.ResourceOwner, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.ResourceOwner] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetftpFileType(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convCoursewareResCase_Resource_Rel.ftpFileType);
objvCoursewareResCase_Resource_RelEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.ftpFileType) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.ftpFileType, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.ftpFileType] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetftpFileSize(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convCoursewareResCase_Resource_Rel.ftpFileSize);
objvCoursewareResCase_Resource_RelEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.ftpFileSize) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.ftpFileSize, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.ftpFileSize] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetftpResourceOwner(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convCoursewareResCase_Resource_Rel.ftpResourceOwner);
objvCoursewareResCase_Resource_RelEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.ftpResourceOwner) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.ftpResourceOwner, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.ftpResourceOwner] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetFileOriginName(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convCoursewareResCase_Resource_Rel.FileOriginName);
objvCoursewareResCase_Resource_RelEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.FileOriginName) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.FileOriginName, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileOriginName] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetIsExistFile(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvCoursewareResCase_Resource_RelEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.IsExistFile) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.IsExistFile, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.IsExistFile] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetFileNewName(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convCoursewareResCase_Resource_Rel.FileNewName);
objvCoursewareResCase_Resource_RelEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.FileNewName) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.FileNewName, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileNewName] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetFileOldName(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convCoursewareResCase_Resource_Rel.FileOldName);
objvCoursewareResCase_Resource_RelEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.FileOldName) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.FileOldName, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileOldName] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetIsMain(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, bool bolIsMain, string strComparisonOp="")
	{
objvCoursewareResCase_Resource_RelEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.IsMain) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.IsMain, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.IsMain] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN Setid_UsingMode(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strid_UsingMode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UsingMode, 4, convCoursewareResCase_Resource_Rel.id_UsingMode);
clsCheckSql.CheckFieldForeignKey(strid_UsingMode, 4, convCoursewareResCase_Resource_Rel.id_UsingMode);
objvCoursewareResCase_Resource_RelEN.id_UsingMode = strid_UsingMode; //资源使用模式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.id_UsingMode) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.id_UsingMode, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_UsingMode] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetIsVisible(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, bool bolIsVisible, string strComparisonOp="")
	{
objvCoursewareResCase_Resource_RelEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.IsVisible) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.IsVisible, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.IsVisible] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetIndexNO(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, int intIndexNO, string strComparisonOp="")
	{
objvCoursewareResCase_Resource_RelEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.IndexNO) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.IndexNO, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.IndexNO] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetBrowseCount(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, int intBrowseCount, string strComparisonOp="")
	{
objvCoursewareResCase_Resource_RelEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.BrowseCount) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.BrowseCount, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.BrowseCount] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetUpdDate(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCoursewareResCase_Resource_Rel.UpdDate);
objvCoursewareResCase_Resource_RelEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.UpdDate) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.UpdDate, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.UpdDate] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetUpdUser(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCoursewareResCase_Resource_Rel.UpdUser);
objvCoursewareResCase_Resource_RelEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.UpdUser) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.UpdUser, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.UpdUser] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCase_Resource_RelEN SetMemo(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCoursewareResCase_Resource_Rel.Memo);
objvCoursewareResCase_Resource_RelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convCoursewareResCase_Resource_Rel.Memo) == false)
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp.Add(convCoursewareResCase_Resource_Rel.Memo, strComparisonOp);
}
else
{
objvCoursewareResCase_Resource_RelEN.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.Memo] = strComparisonOp;
}
}
return objvCoursewareResCase_Resource_RelEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_Rel_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.id_MicroteachCase_Resource_Rel) == true)
{
string strComparisonOp_id_MicroteachCase_Resource_Rel = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_MicroteachCase_Resource_Rel];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase_Resource_Rel.id_MicroteachCase_Resource_Rel, objvCoursewareResCase_Resource_Rel_Cond.id_MicroteachCase_Resource_Rel, strComparisonOp_id_MicroteachCase_Resource_Rel);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.FuncModuleId, objvCoursewareResCase_Resource_Rel_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.FuncModuleName, objvCoursewareResCase_Resource_Rel_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.id_MicroteachCase, objvCoursewareResCase_Resource_Rel_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.CoursewareResCaseID) == true)
{
string strComparisonOp_CoursewareResCaseID = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CoursewareResCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.CoursewareResCaseID, objvCoursewareResCase_Resource_Rel_Cond.CoursewareResCaseID, strComparisonOp_CoursewareResCaseID);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.CoursewareResCaseName) == true)
{
string strComparisonOp_CoursewareResCaseName = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CoursewareResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.CoursewareResCaseName, objvCoursewareResCase_Resource_Rel_Cond.CoursewareResCaseName, strComparisonOp_CoursewareResCaseName);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme) == true)
{
string strComparisonOp_CoursewareResCaseTheme = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme, objvCoursewareResCase_Resource_Rel_Cond.CoursewareResCaseTheme, strComparisonOp_CoursewareResCaseTheme);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.CoursewareResCaseText) == true)
{
string strComparisonOp_CoursewareResCaseText = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CoursewareResCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.CoursewareResCaseText, objvCoursewareResCase_Resource_Rel_Cond.CoursewareResCaseText, strComparisonOp_CoursewareResCaseText);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.id_CoursewareResCaseType) == true)
{
string strComparisonOp_id_CoursewareResCaseType = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_CoursewareResCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.id_CoursewareResCaseType, objvCoursewareResCase_Resource_Rel_Cond.id_CoursewareResCaseType, strComparisonOp_id_CoursewareResCaseType);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName) == true)
{
string strComparisonOp_CoursewareResCaseTypeName = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName, objvCoursewareResCase_Resource_Rel_Cond.CoursewareResCaseTypeName, strComparisonOp_CoursewareResCaseTypeName);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.CoursewareResCaseDate) == true)
{
string strComparisonOp_CoursewareResCaseDate = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CoursewareResCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.CoursewareResCaseDate, objvCoursewareResCase_Resource_Rel_Cond.CoursewareResCaseDate, strComparisonOp_CoursewareResCaseDate);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.CoursewareResCaseTime) == true)
{
string strComparisonOp_CoursewareResCaseTime = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CoursewareResCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.CoursewareResCaseTime, objvCoursewareResCase_Resource_Rel_Cond.CoursewareResCaseTime, strComparisonOp_CoursewareResCaseTime);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn) == true)
{
string strComparisonOp_CoursewareResCaseDateIn = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn, objvCoursewareResCase_Resource_Rel_Cond.CoursewareResCaseDateIn, strComparisonOp_CoursewareResCaseDateIn);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn) == true)
{
string strComparisonOp_CoursewareResCaseTimeIn = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn, objvCoursewareResCase_Resource_Rel_Cond.CoursewareResCaseTimeIn, strComparisonOp_CoursewareResCaseTimeIn);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.OwnerId, objvCoursewareResCase_Resource_Rel_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.OwnerName, objvCoursewareResCase_Resource_Rel_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.OwnerNameWithId, objvCoursewareResCase_Resource_Rel_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.id_StudyLevel, objvCoursewareResCase_Resource_Rel_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.StudyLevelName, objvCoursewareResCase_Resource_Rel_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.id_TeachingPlan, objvCoursewareResCase_Resource_Rel_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.id_Discipline, objvCoursewareResCase_Resource_Rel_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.DisciplineID, objvCoursewareResCase_Resource_Rel_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.DisciplineName, objvCoursewareResCase_Resource_Rel_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.senateGaugeVersionID, objvCoursewareResCase_Resource_Rel_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.senateGaugeVersionName, objvCoursewareResCase_Resource_Rel_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase_Resource_Rel.senateGaugeVersionTtlScore, objvCoursewareResCase_Resource_Rel_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase_Resource_Rel.VersionNo, objvCoursewareResCase_Resource_Rel_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.id_TeachSkill, objvCoursewareResCase_Resource_Rel_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.TeachSkillID, objvCoursewareResCase_Resource_Rel_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.SkillTypeName, objvCoursewareResCase_Resource_Rel_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.TeachSkillName, objvCoursewareResCase_Resource_Rel_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.TeachSkillTheory, objvCoursewareResCase_Resource_Rel_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.TeachSkillOperMethod, objvCoursewareResCase_Resource_Rel_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.id_SkillType, objvCoursewareResCase_Resource_Rel_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.SkillTypeID, objvCoursewareResCase_Resource_Rel_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.CaseLevelId, objvCoursewareResCase_Resource_Rel_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.IsDualVideo) == true)
{
if (objvCoursewareResCase_Resource_Rel_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareResCase_Resource_Rel.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareResCase_Resource_Rel.IsDualVideo);
}
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.id_XzCollege, objvCoursewareResCase_Resource_Rel_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.CollegeID, objvCoursewareResCase_Resource_Rel_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.CollegeName, objvCoursewareResCase_Resource_Rel_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.id_XzMajor, objvCoursewareResCase_Resource_Rel_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.MajorID) == true)
{
string strComparisonOp_MajorID = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.MajorID, objvCoursewareResCase_Resource_Rel_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.MajorName) == true)
{
string strComparisonOp_MajorName = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.MajorName, objvCoursewareResCase_Resource_Rel_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.CourseId) == true)
{
string strComparisonOp_CourseId = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.CourseId, objvCoursewareResCase_Resource_Rel_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.CourseCode, objvCoursewareResCase_Resource_Rel_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.CourseName) == true)
{
string strComparisonOp_CourseName = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.CourseName, objvCoursewareResCase_Resource_Rel_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.CourseChapterId, objvCoursewareResCase_Resource_Rel_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.CourseChapterName, objvCoursewareResCase_Resource_Rel_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.ParentNodeID, objvCoursewareResCase_Resource_Rel_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.ParentNodeName, objvCoursewareResCase_Resource_Rel_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase_Resource_Rel.ViewCount, objvCoursewareResCase_Resource_Rel_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.IsShow) == true)
{
if (objvCoursewareResCase_Resource_Rel_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareResCase_Resource_Rel.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareResCase_Resource_Rel.IsShow);
}
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase_Resource_Rel.DownloadNumber, objvCoursewareResCase_Resource_Rel_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase_Resource_Rel.FileIntegration, objvCoursewareResCase_Resource_Rel_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase_Resource_Rel.LikeCount, objvCoursewareResCase_Resource_Rel_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase_Resource_Rel.CollectionCount, objvCoursewareResCase_Resource_Rel_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.RecommendedDegreeId, objvCoursewareResCase_Resource_Rel_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.RecommendedDegreeName, objvCoursewareResCase_Resource_Rel_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase_Resource_Rel.BrowseCount4Case, objvCoursewareResCase_Resource_Rel_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.CollegeNameA, objvCoursewareResCase_Resource_Rel_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.id_Resource, objvCoursewareResCase_Resource_Rel_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.ResourceID, objvCoursewareResCase_Resource_Rel_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.ResourceName) == true)
{
string strComparisonOp_ResourceName = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.ResourceName, objvCoursewareResCase_Resource_Rel_Cond.ResourceName, strComparisonOp_ResourceName);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.id_FtpResource, objvCoursewareResCase_Resource_Rel_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.id_File) == true)
{
string strComparisonOp_id_File = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.id_File, objvCoursewareResCase_Resource_Rel_Cond.id_File, strComparisonOp_id_File);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.FileName) == true)
{
string strComparisonOp_FileName = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.FileName, objvCoursewareResCase_Resource_Rel_Cond.FileName, strComparisonOp_FileName);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.FileType) == true)
{
string strComparisonOp_FileType = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.FileType, objvCoursewareResCase_Resource_Rel_Cond.FileType, strComparisonOp_FileType);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.SaveDate, objvCoursewareResCase_Resource_Rel_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.FileSize) == true)
{
string strComparisonOp_FileSize = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.FileSize, objvCoursewareResCase_Resource_Rel_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.SaveTime, objvCoursewareResCase_Resource_Rel_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.FtpResourceID, objvCoursewareResCase_Resource_Rel_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.FileOriginalName, objvCoursewareResCase_Resource_Rel_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.FileDirName, objvCoursewareResCase_Resource_Rel_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.FileRename) == true)
{
string strComparisonOp_FileRename = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.FileRename, objvCoursewareResCase_Resource_Rel_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.FileUpDate, objvCoursewareResCase_Resource_Rel_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.FileUpTime, objvCoursewareResCase_Resource_Rel_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.SaveMode) == true)
{
if (objvCoursewareResCase_Resource_Rel_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareResCase_Resource_Rel.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareResCase_Resource_Rel.SaveMode);
}
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.id_ResourceType, objvCoursewareResCase_Resource_Rel_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.ResourceTypeID, objvCoursewareResCase_Resource_Rel_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.ResourceTypeName, objvCoursewareResCase_Resource_Rel_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.ResourceOwner, objvCoursewareResCase_Resource_Rel_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.ftpFileType, objvCoursewareResCase_Resource_Rel_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.ftpFileSize, objvCoursewareResCase_Resource_Rel_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.ftpResourceOwner, objvCoursewareResCase_Resource_Rel_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.FileOriginName, objvCoursewareResCase_Resource_Rel_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.IsExistFile) == true)
{
if (objvCoursewareResCase_Resource_Rel_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareResCase_Resource_Rel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareResCase_Resource_Rel.IsExistFile);
}
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.FileNewName, objvCoursewareResCase_Resource_Rel_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.FileOldName, objvCoursewareResCase_Resource_Rel_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.IsMain) == true)
{
if (objvCoursewareResCase_Resource_Rel_Cond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareResCase_Resource_Rel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareResCase_Resource_Rel.IsMain);
}
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.id_UsingMode) == true)
{
string strComparisonOp_id_UsingMode = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.id_UsingMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.id_UsingMode, objvCoursewareResCase_Resource_Rel_Cond.id_UsingMode, strComparisonOp_id_UsingMode);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.IsVisible) == true)
{
if (objvCoursewareResCase_Resource_Rel_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareResCase_Resource_Rel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareResCase_Resource_Rel.IsVisible);
}
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.IndexNO) == true)
{
string strComparisonOp_IndexNO = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase_Resource_Rel.IndexNO, objvCoursewareResCase_Resource_Rel_Cond.IndexNO, strComparisonOp_IndexNO);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCase_Resource_Rel.BrowseCount, objvCoursewareResCase_Resource_Rel_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.UpdDate, objvCoursewareResCase_Resource_Rel_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.UpdUser, objvCoursewareResCase_Resource_Rel_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvCoursewareResCase_Resource_Rel_Cond.IsUpdated(convCoursewareResCase_Resource_Rel.Memo) == true)
{
string strComparisonOp_Memo = objvCoursewareResCase_Resource_Rel_Cond.dicFldComparisonOp[convCoursewareResCase_Resource_Rel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCase_Resource_Rel.Memo, objvCoursewareResCase_Resource_Rel_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课件资源案例资源关系(vCoursewareResCase_Resource_Rel)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCoursewareResCase_Resource_RelWApi
{
private static readonly string mstrApiControllerName = "vCoursewareResCase_Resource_RelApi";

 public clsvCoursewareResCase_Resource_RelWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroteachCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCoursewareResCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN = null;
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
objvCoursewareResCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvCoursewareResCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareResCase_Resource_RelEN;
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
public static clsvCoursewareResCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_WA_Cache(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN = null;
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
objvCoursewareResCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvCoursewareResCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareResCase_Resource_RelEN;
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
public static clsvCoursewareResCase_Resource_RelEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN = null;
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
objvCoursewareResCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvCoursewareResCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareResCase_Resource_RelEN;
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
public static clsvCoursewareResCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_Cache(long lngid_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCoursewareResCase_Resource_RelEN._CurrTabName_S);
List<clsvCoursewareResCase_Resource_RelEN> arrvCoursewareResCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCoursewareResCase_Resource_RelEN> arrvCoursewareResCase_Resource_RelObjLst_Sel =
from objvCoursewareResCase_Resource_RelEN in arrvCoursewareResCase_Resource_RelObjLst_Cache
where objvCoursewareResCase_Resource_RelEN.id_MicroteachCase_Resource_Rel == lngid_MicroteachCase_Resource_Rel
select objvCoursewareResCase_Resource_RelEN;
if (arrvCoursewareResCase_Resource_RelObjLst_Sel.Count() == 0)
{
   clsvCoursewareResCase_Resource_RelEN obj = clsvCoursewareResCase_Resource_RelWApi.GetObjByid_MicroteachCase_Resource_Rel(lngid_MicroteachCase_Resource_Rel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCoursewareResCase_Resource_RelObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCoursewareResCase_Resource_RelEN> GetObjLst(string strWhereCond)
{
 List<clsvCoursewareResCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvCoursewareResCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvCoursewareResCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCoursewareResCase_Resource_RelEN._CurrTabName_S);
List<clsvCoursewareResCase_Resource_RelEN> arrvCoursewareResCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCoursewareResCase_Resource_RelEN> arrvCoursewareResCase_Resource_RelObjLst_Sel =
from objvCoursewareResCase_Resource_RelEN in arrvCoursewareResCase_Resource_RelObjLst_Cache
where arrId_MicroteachCase_Resource_Rel.Contains(objvCoursewareResCase_Resource_RelEN.id_MicroteachCase_Resource_Rel)
select objvCoursewareResCase_Resource_RelEN;
return arrvCoursewareResCase_Resource_RelObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCoursewareResCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_WA_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvCoursewareResCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCase_Resource_RelEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCoursewareResCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCase_Resource_RelEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCoursewareResCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCase_Resource_RelEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCoursewareResCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCase_Resource_RelEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCoursewareResCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvCoursewareResCase_Resource_RelENS">源对象</param>
 /// <param name = "objvCoursewareResCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelENS, clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelENT)
{
try
{
objvCoursewareResCase_Resource_RelENT.id_MicroteachCase_Resource_Rel = objvCoursewareResCase_Resource_RelENS.id_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
objvCoursewareResCase_Resource_RelENT.FuncModuleId = objvCoursewareResCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvCoursewareResCase_Resource_RelENT.FuncModuleName = objvCoursewareResCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvCoursewareResCase_Resource_RelENT.id_MicroteachCase = objvCoursewareResCase_Resource_RelENS.id_MicroteachCase; //微格教学案例流水号
objvCoursewareResCase_Resource_RelENT.CoursewareResCaseID = objvCoursewareResCase_Resource_RelENS.CoursewareResCaseID; //课件资源案例ID
objvCoursewareResCase_Resource_RelENT.CoursewareResCaseName = objvCoursewareResCase_Resource_RelENS.CoursewareResCaseName; //课件资源案例名称
objvCoursewareResCase_Resource_RelENT.CoursewareResCaseTheme = objvCoursewareResCase_Resource_RelENS.CoursewareResCaseTheme; //课件资源案例主题词
objvCoursewareResCase_Resource_RelENT.CoursewareResCaseText = objvCoursewareResCase_Resource_RelENS.CoursewareResCaseText; //案例文本内容
objvCoursewareResCase_Resource_RelENT.id_CoursewareResCaseType = objvCoursewareResCase_Resource_RelENS.id_CoursewareResCaseType; //课件资源类型流水号
objvCoursewareResCase_Resource_RelENT.CoursewareResCaseTypeName = objvCoursewareResCase_Resource_RelENS.CoursewareResCaseTypeName; //课件资源案例类型名称
objvCoursewareResCase_Resource_RelENT.CoursewareResCaseDate = objvCoursewareResCase_Resource_RelENS.CoursewareResCaseDate; //视频资源日期
objvCoursewareResCase_Resource_RelENT.CoursewareResCaseTime = objvCoursewareResCase_Resource_RelENS.CoursewareResCaseTime; //视频资源时间
objvCoursewareResCase_Resource_RelENT.CoursewareResCaseDateIn = objvCoursewareResCase_Resource_RelENS.CoursewareResCaseDateIn; //案例入库日期
objvCoursewareResCase_Resource_RelENT.CoursewareResCaseTimeIn = objvCoursewareResCase_Resource_RelENS.CoursewareResCaseTimeIn; //案例入库时间
objvCoursewareResCase_Resource_RelENT.OwnerId = objvCoursewareResCase_Resource_RelENS.OwnerId; //拥有者Id
objvCoursewareResCase_Resource_RelENT.OwnerName = objvCoursewareResCase_Resource_RelENS.OwnerName; //拥有者姓名
objvCoursewareResCase_Resource_RelENT.OwnerNameWithId = objvCoursewareResCase_Resource_RelENS.OwnerNameWithId; //拥有者名称附Id
objvCoursewareResCase_Resource_RelENT.id_StudyLevel = objvCoursewareResCase_Resource_RelENS.id_StudyLevel; //id_StudyLevel
objvCoursewareResCase_Resource_RelENT.StudyLevelName = objvCoursewareResCase_Resource_RelENS.StudyLevelName; //学段名称
objvCoursewareResCase_Resource_RelENT.id_TeachingPlan = objvCoursewareResCase_Resource_RelENS.id_TeachingPlan; //教案流水号
objvCoursewareResCase_Resource_RelENT.id_Discipline = objvCoursewareResCase_Resource_RelENS.id_Discipline; //学科流水号
objvCoursewareResCase_Resource_RelENT.DisciplineID = objvCoursewareResCase_Resource_RelENS.DisciplineID; //学科ID
objvCoursewareResCase_Resource_RelENT.DisciplineName = objvCoursewareResCase_Resource_RelENS.DisciplineName; //学科名称
objvCoursewareResCase_Resource_RelENT.senateGaugeVersionID = objvCoursewareResCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvCoursewareResCase_Resource_RelENT.senateGaugeVersionName = objvCoursewareResCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvCoursewareResCase_Resource_RelENT.senateGaugeVersionTtlScore = objvCoursewareResCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCoursewareResCase_Resource_RelENT.VersionNo = objvCoursewareResCase_Resource_RelENS.VersionNo; //版本号
objvCoursewareResCase_Resource_RelENT.id_TeachSkill = objvCoursewareResCase_Resource_RelENS.id_TeachSkill; //教学技能流水号
objvCoursewareResCase_Resource_RelENT.TeachSkillID = objvCoursewareResCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvCoursewareResCase_Resource_RelENT.SkillTypeName = objvCoursewareResCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvCoursewareResCase_Resource_RelENT.TeachSkillName = objvCoursewareResCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvCoursewareResCase_Resource_RelENT.TeachSkillTheory = objvCoursewareResCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvCoursewareResCase_Resource_RelENT.TeachSkillOperMethod = objvCoursewareResCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCoursewareResCase_Resource_RelENT.id_SkillType = objvCoursewareResCase_Resource_RelENS.id_SkillType; //技能类型流水号
objvCoursewareResCase_Resource_RelENT.SkillTypeID = objvCoursewareResCase_Resource_RelENS.SkillTypeID; //技能类型ID
objvCoursewareResCase_Resource_RelENT.CaseLevelId = objvCoursewareResCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvCoursewareResCase_Resource_RelENT.IsDualVideo = objvCoursewareResCase_Resource_RelENS.IsDualVideo; //是否双视频
objvCoursewareResCase_Resource_RelENT.id_XzCollege = objvCoursewareResCase_Resource_RelENS.id_XzCollege; //学院流水号
objvCoursewareResCase_Resource_RelENT.CollegeID = objvCoursewareResCase_Resource_RelENS.CollegeID; //学院ID
objvCoursewareResCase_Resource_RelENT.CollegeName = objvCoursewareResCase_Resource_RelENS.CollegeName; //学院名称
objvCoursewareResCase_Resource_RelENT.id_XzMajor = objvCoursewareResCase_Resource_RelENS.id_XzMajor; //专业流水号
objvCoursewareResCase_Resource_RelENT.MajorID = objvCoursewareResCase_Resource_RelENS.MajorID; //专业ID
objvCoursewareResCase_Resource_RelENT.MajorName = objvCoursewareResCase_Resource_RelENS.MajorName; //专业名称
objvCoursewareResCase_Resource_RelENT.CourseId = objvCoursewareResCase_Resource_RelENS.CourseId; //课程Id
objvCoursewareResCase_Resource_RelENT.CourseCode = objvCoursewareResCase_Resource_RelENS.CourseCode; //课程代码
objvCoursewareResCase_Resource_RelENT.CourseName = objvCoursewareResCase_Resource_RelENS.CourseName; //课程名称
objvCoursewareResCase_Resource_RelENT.CourseChapterId = objvCoursewareResCase_Resource_RelENS.CourseChapterId; //课程章节ID
objvCoursewareResCase_Resource_RelENT.CourseChapterName = objvCoursewareResCase_Resource_RelENS.CourseChapterName; //课程章节名称
objvCoursewareResCase_Resource_RelENT.ParentNodeID = objvCoursewareResCase_Resource_RelENS.ParentNodeID; //父节点编号
objvCoursewareResCase_Resource_RelENT.ParentNodeName = objvCoursewareResCase_Resource_RelENS.ParentNodeName; //父节点名称
objvCoursewareResCase_Resource_RelENT.ViewCount = objvCoursewareResCase_Resource_RelENS.ViewCount; //浏览量
objvCoursewareResCase_Resource_RelENT.IsShow = objvCoursewareResCase_Resource_RelENS.IsShow; //是否启用
objvCoursewareResCase_Resource_RelENT.DownloadNumber = objvCoursewareResCase_Resource_RelENS.DownloadNumber; //下载数目
objvCoursewareResCase_Resource_RelENT.FileIntegration = objvCoursewareResCase_Resource_RelENS.FileIntegration; //文件积分
objvCoursewareResCase_Resource_RelENT.LikeCount = objvCoursewareResCase_Resource_RelENS.LikeCount; //资源喜欢数量
objvCoursewareResCase_Resource_RelENT.CollectionCount = objvCoursewareResCase_Resource_RelENS.CollectionCount; //收藏数量
objvCoursewareResCase_Resource_RelENT.RecommendedDegreeId = objvCoursewareResCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvCoursewareResCase_Resource_RelENT.RecommendedDegreeName = objvCoursewareResCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvCoursewareResCase_Resource_RelENT.BrowseCount4Case = objvCoursewareResCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvCoursewareResCase_Resource_RelENT.CollegeNameA = objvCoursewareResCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvCoursewareResCase_Resource_RelENT.id_Resource = objvCoursewareResCase_Resource_RelENS.id_Resource; //资源流水号
objvCoursewareResCase_Resource_RelENT.ResourceID = objvCoursewareResCase_Resource_RelENS.ResourceID; //资源ID
objvCoursewareResCase_Resource_RelENT.ResourceName = objvCoursewareResCase_Resource_RelENS.ResourceName; //资源名称
objvCoursewareResCase_Resource_RelENT.id_FtpResource = objvCoursewareResCase_Resource_RelENS.id_FtpResource; //FTP资源流水号
objvCoursewareResCase_Resource_RelENT.id_File = objvCoursewareResCase_Resource_RelENS.id_File; //文件流水号
objvCoursewareResCase_Resource_RelENT.FileName = objvCoursewareResCase_Resource_RelENS.FileName; //文件名称
objvCoursewareResCase_Resource_RelENT.FileType = objvCoursewareResCase_Resource_RelENS.FileType; //文件类型
objvCoursewareResCase_Resource_RelENT.SaveDate = objvCoursewareResCase_Resource_RelENS.SaveDate; //创建日期
objvCoursewareResCase_Resource_RelENT.FileSize = objvCoursewareResCase_Resource_RelENS.FileSize; //文件大小
objvCoursewareResCase_Resource_RelENT.SaveTime = objvCoursewareResCase_Resource_RelENS.SaveTime; //创建时间
objvCoursewareResCase_Resource_RelENT.FtpResourceID = objvCoursewareResCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvCoursewareResCase_Resource_RelENT.FileOriginalName = objvCoursewareResCase_Resource_RelENS.FileOriginalName; //文件原名
objvCoursewareResCase_Resource_RelENT.FileDirName = objvCoursewareResCase_Resource_RelENS.FileDirName; //文件目录名
objvCoursewareResCase_Resource_RelENT.FileRename = objvCoursewareResCase_Resource_RelENS.FileRename; //文件新名
objvCoursewareResCase_Resource_RelENT.FileUpDate = objvCoursewareResCase_Resource_RelENS.FileUpDate; //创建日期
objvCoursewareResCase_Resource_RelENT.FileUpTime = objvCoursewareResCase_Resource_RelENS.FileUpTime; //创建时间
objvCoursewareResCase_Resource_RelENT.SaveMode = objvCoursewareResCase_Resource_RelENS.SaveMode; //文件存放方式
objvCoursewareResCase_Resource_RelENT.id_ResourceType = objvCoursewareResCase_Resource_RelENS.id_ResourceType; //资源类型流水号
objvCoursewareResCase_Resource_RelENT.ResourceTypeID = objvCoursewareResCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvCoursewareResCase_Resource_RelENT.ResourceTypeName = objvCoursewareResCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvCoursewareResCase_Resource_RelENT.ResourceOwner = objvCoursewareResCase_Resource_RelENS.ResourceOwner; //上传者
objvCoursewareResCase_Resource_RelENT.ftpFileType = objvCoursewareResCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvCoursewareResCase_Resource_RelENT.ftpFileSize = objvCoursewareResCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvCoursewareResCase_Resource_RelENT.ftpResourceOwner = objvCoursewareResCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvCoursewareResCase_Resource_RelENT.FileOriginName = objvCoursewareResCase_Resource_RelENS.FileOriginName; //原文件名
objvCoursewareResCase_Resource_RelENT.IsExistFile = objvCoursewareResCase_Resource_RelENS.IsExistFile; //是否存在文件
objvCoursewareResCase_Resource_RelENT.FileNewName = objvCoursewareResCase_Resource_RelENS.FileNewName; //新文件名
objvCoursewareResCase_Resource_RelENT.FileOldName = objvCoursewareResCase_Resource_RelENS.FileOldName; //旧文件名
objvCoursewareResCase_Resource_RelENT.IsMain = objvCoursewareResCase_Resource_RelENS.IsMain; //是否主资源
objvCoursewareResCase_Resource_RelENT.id_UsingMode = objvCoursewareResCase_Resource_RelENS.id_UsingMode; //资源使用模式流水号
objvCoursewareResCase_Resource_RelENT.IsVisible = objvCoursewareResCase_Resource_RelENS.IsVisible; //是否显示
objvCoursewareResCase_Resource_RelENT.IndexNO = objvCoursewareResCase_Resource_RelENS.IndexNO; //序号
objvCoursewareResCase_Resource_RelENT.BrowseCount = objvCoursewareResCase_Resource_RelENS.BrowseCount; //浏览次数
objvCoursewareResCase_Resource_RelENT.UpdDate = objvCoursewareResCase_Resource_RelENS.UpdDate; //修改日期
objvCoursewareResCase_Resource_RelENT.UpdUser = objvCoursewareResCase_Resource_RelENS.UpdUser; //修改人
objvCoursewareResCase_Resource_RelENT.Memo = objvCoursewareResCase_Resource_RelENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvCoursewareResCase_Resource_RelEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCoursewareResCase_Resource_RelEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCoursewareResCase_Resource_RelEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCoursewareResCase_Resource_RelEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCoursewareResCase_Resource_RelEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCoursewareResCase_Resource_RelEN.AttributeName)
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
if (clsCoursewareResCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCoursewareResCaseWApi没有刷新缓存机制(clsCoursewareResCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCoursewareResCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCoursewareResCaseTypeWApi没有刷新缓存机制(clsCoursewareResCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvCoursewareResCase_Resource_RelObjLst_Cache == null)
//{
//arrvCoursewareResCase_Resource_RelObjLst_Cache = await clsvCoursewareResCase_Resource_RelWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCoursewareResCase_Resource_RelEN._CurrTabName_S);
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
public static List<clsvCoursewareResCase_Resource_RelEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCoursewareResCase_Resource_RelEN._CurrTabName_S);
List<clsvCoursewareResCase_Resource_RelEN> arrvCoursewareResCase_Resource_RelObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCoursewareResCase_Resource_RelObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCoursewareResCase_Resource_RelEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.id_MicroteachCase_Resource_Rel, Type.GetType("System.Int64"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.CoursewareResCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.CoursewareResCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.CoursewareResCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.id_CoursewareResCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.CoursewareResCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.CoursewareResCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.ResourceName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.IsMain, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.id_UsingMode, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.IndexNO, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCase_Resource_Rel.Memo, Type.GetType("System.String"));
foreach (clsvCoursewareResCase_Resource_RelEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCoursewareResCase_Resource_Rel.id_MicroteachCase_Resource_Rel] = objInFor[convCoursewareResCase_Resource_Rel.id_MicroteachCase_Resource_Rel];
objDR[convCoursewareResCase_Resource_Rel.FuncModuleId] = objInFor[convCoursewareResCase_Resource_Rel.FuncModuleId];
objDR[convCoursewareResCase_Resource_Rel.FuncModuleName] = objInFor[convCoursewareResCase_Resource_Rel.FuncModuleName];
objDR[convCoursewareResCase_Resource_Rel.id_MicroteachCase] = objInFor[convCoursewareResCase_Resource_Rel.id_MicroteachCase];
objDR[convCoursewareResCase_Resource_Rel.CoursewareResCaseID] = objInFor[convCoursewareResCase_Resource_Rel.CoursewareResCaseID];
objDR[convCoursewareResCase_Resource_Rel.CoursewareResCaseName] = objInFor[convCoursewareResCase_Resource_Rel.CoursewareResCaseName];
objDR[convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme] = objInFor[convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme];
objDR[convCoursewareResCase_Resource_Rel.CoursewareResCaseText] = objInFor[convCoursewareResCase_Resource_Rel.CoursewareResCaseText];
objDR[convCoursewareResCase_Resource_Rel.id_CoursewareResCaseType] = objInFor[convCoursewareResCase_Resource_Rel.id_CoursewareResCaseType];
objDR[convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName] = objInFor[convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName];
objDR[convCoursewareResCase_Resource_Rel.CoursewareResCaseDate] = objInFor[convCoursewareResCase_Resource_Rel.CoursewareResCaseDate];
objDR[convCoursewareResCase_Resource_Rel.CoursewareResCaseTime] = objInFor[convCoursewareResCase_Resource_Rel.CoursewareResCaseTime];
objDR[convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn] = objInFor[convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn];
objDR[convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn] = objInFor[convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn];
objDR[convCoursewareResCase_Resource_Rel.OwnerId] = objInFor[convCoursewareResCase_Resource_Rel.OwnerId];
objDR[convCoursewareResCase_Resource_Rel.OwnerName] = objInFor[convCoursewareResCase_Resource_Rel.OwnerName];
objDR[convCoursewareResCase_Resource_Rel.OwnerNameWithId] = objInFor[convCoursewareResCase_Resource_Rel.OwnerNameWithId];
objDR[convCoursewareResCase_Resource_Rel.id_StudyLevel] = objInFor[convCoursewareResCase_Resource_Rel.id_StudyLevel];
objDR[convCoursewareResCase_Resource_Rel.StudyLevelName] = objInFor[convCoursewareResCase_Resource_Rel.StudyLevelName];
objDR[convCoursewareResCase_Resource_Rel.id_TeachingPlan] = objInFor[convCoursewareResCase_Resource_Rel.id_TeachingPlan];
objDR[convCoursewareResCase_Resource_Rel.id_Discipline] = objInFor[convCoursewareResCase_Resource_Rel.id_Discipline];
objDR[convCoursewareResCase_Resource_Rel.DisciplineID] = objInFor[convCoursewareResCase_Resource_Rel.DisciplineID];
objDR[convCoursewareResCase_Resource_Rel.DisciplineName] = objInFor[convCoursewareResCase_Resource_Rel.DisciplineName];
objDR[convCoursewareResCase_Resource_Rel.senateGaugeVersionID] = objInFor[convCoursewareResCase_Resource_Rel.senateGaugeVersionID];
objDR[convCoursewareResCase_Resource_Rel.senateGaugeVersionName] = objInFor[convCoursewareResCase_Resource_Rel.senateGaugeVersionName];
objDR[convCoursewareResCase_Resource_Rel.senateGaugeVersionTtlScore] = objInFor[convCoursewareResCase_Resource_Rel.senateGaugeVersionTtlScore];
objDR[convCoursewareResCase_Resource_Rel.VersionNo] = objInFor[convCoursewareResCase_Resource_Rel.VersionNo];
objDR[convCoursewareResCase_Resource_Rel.id_TeachSkill] = objInFor[convCoursewareResCase_Resource_Rel.id_TeachSkill];
objDR[convCoursewareResCase_Resource_Rel.TeachSkillID] = objInFor[convCoursewareResCase_Resource_Rel.TeachSkillID];
objDR[convCoursewareResCase_Resource_Rel.SkillTypeName] = objInFor[convCoursewareResCase_Resource_Rel.SkillTypeName];
objDR[convCoursewareResCase_Resource_Rel.TeachSkillName] = objInFor[convCoursewareResCase_Resource_Rel.TeachSkillName];
objDR[convCoursewareResCase_Resource_Rel.TeachSkillTheory] = objInFor[convCoursewareResCase_Resource_Rel.TeachSkillTheory];
objDR[convCoursewareResCase_Resource_Rel.TeachSkillOperMethod] = objInFor[convCoursewareResCase_Resource_Rel.TeachSkillOperMethod];
objDR[convCoursewareResCase_Resource_Rel.id_SkillType] = objInFor[convCoursewareResCase_Resource_Rel.id_SkillType];
objDR[convCoursewareResCase_Resource_Rel.SkillTypeID] = objInFor[convCoursewareResCase_Resource_Rel.SkillTypeID];
objDR[convCoursewareResCase_Resource_Rel.CaseLevelId] = objInFor[convCoursewareResCase_Resource_Rel.CaseLevelId];
objDR[convCoursewareResCase_Resource_Rel.IsDualVideo] = objInFor[convCoursewareResCase_Resource_Rel.IsDualVideo];
objDR[convCoursewareResCase_Resource_Rel.id_XzCollege] = objInFor[convCoursewareResCase_Resource_Rel.id_XzCollege];
objDR[convCoursewareResCase_Resource_Rel.CollegeID] = objInFor[convCoursewareResCase_Resource_Rel.CollegeID];
objDR[convCoursewareResCase_Resource_Rel.CollegeName] = objInFor[convCoursewareResCase_Resource_Rel.CollegeName];
objDR[convCoursewareResCase_Resource_Rel.id_XzMajor] = objInFor[convCoursewareResCase_Resource_Rel.id_XzMajor];
objDR[convCoursewareResCase_Resource_Rel.MajorID] = objInFor[convCoursewareResCase_Resource_Rel.MajorID];
objDR[convCoursewareResCase_Resource_Rel.MajorName] = objInFor[convCoursewareResCase_Resource_Rel.MajorName];
objDR[convCoursewareResCase_Resource_Rel.CourseId] = objInFor[convCoursewareResCase_Resource_Rel.CourseId];
objDR[convCoursewareResCase_Resource_Rel.CourseCode] = objInFor[convCoursewareResCase_Resource_Rel.CourseCode];
objDR[convCoursewareResCase_Resource_Rel.CourseName] = objInFor[convCoursewareResCase_Resource_Rel.CourseName];
objDR[convCoursewareResCase_Resource_Rel.CourseChapterId] = objInFor[convCoursewareResCase_Resource_Rel.CourseChapterId];
objDR[convCoursewareResCase_Resource_Rel.CourseChapterName] = objInFor[convCoursewareResCase_Resource_Rel.CourseChapterName];
objDR[convCoursewareResCase_Resource_Rel.ParentNodeID] = objInFor[convCoursewareResCase_Resource_Rel.ParentNodeID];
objDR[convCoursewareResCase_Resource_Rel.ParentNodeName] = objInFor[convCoursewareResCase_Resource_Rel.ParentNodeName];
objDR[convCoursewareResCase_Resource_Rel.ViewCount] = objInFor[convCoursewareResCase_Resource_Rel.ViewCount];
objDR[convCoursewareResCase_Resource_Rel.IsShow] = objInFor[convCoursewareResCase_Resource_Rel.IsShow];
objDR[convCoursewareResCase_Resource_Rel.DownloadNumber] = objInFor[convCoursewareResCase_Resource_Rel.DownloadNumber];
objDR[convCoursewareResCase_Resource_Rel.FileIntegration] = objInFor[convCoursewareResCase_Resource_Rel.FileIntegration];
objDR[convCoursewareResCase_Resource_Rel.LikeCount] = objInFor[convCoursewareResCase_Resource_Rel.LikeCount];
objDR[convCoursewareResCase_Resource_Rel.CollectionCount] = objInFor[convCoursewareResCase_Resource_Rel.CollectionCount];
objDR[convCoursewareResCase_Resource_Rel.RecommendedDegreeId] = objInFor[convCoursewareResCase_Resource_Rel.RecommendedDegreeId];
objDR[convCoursewareResCase_Resource_Rel.RecommendedDegreeName] = objInFor[convCoursewareResCase_Resource_Rel.RecommendedDegreeName];
objDR[convCoursewareResCase_Resource_Rel.BrowseCount4Case] = objInFor[convCoursewareResCase_Resource_Rel.BrowseCount4Case];
objDR[convCoursewareResCase_Resource_Rel.CollegeNameA] = objInFor[convCoursewareResCase_Resource_Rel.CollegeNameA];
objDR[convCoursewareResCase_Resource_Rel.id_Resource] = objInFor[convCoursewareResCase_Resource_Rel.id_Resource];
objDR[convCoursewareResCase_Resource_Rel.ResourceID] = objInFor[convCoursewareResCase_Resource_Rel.ResourceID];
objDR[convCoursewareResCase_Resource_Rel.ResourceName] = objInFor[convCoursewareResCase_Resource_Rel.ResourceName];
objDR[convCoursewareResCase_Resource_Rel.id_FtpResource] = objInFor[convCoursewareResCase_Resource_Rel.id_FtpResource];
objDR[convCoursewareResCase_Resource_Rel.id_File] = objInFor[convCoursewareResCase_Resource_Rel.id_File];
objDR[convCoursewareResCase_Resource_Rel.FileName] = objInFor[convCoursewareResCase_Resource_Rel.FileName];
objDR[convCoursewareResCase_Resource_Rel.FileType] = objInFor[convCoursewareResCase_Resource_Rel.FileType];
objDR[convCoursewareResCase_Resource_Rel.SaveDate] = objInFor[convCoursewareResCase_Resource_Rel.SaveDate];
objDR[convCoursewareResCase_Resource_Rel.FileSize] = objInFor[convCoursewareResCase_Resource_Rel.FileSize];
objDR[convCoursewareResCase_Resource_Rel.SaveTime] = objInFor[convCoursewareResCase_Resource_Rel.SaveTime];
objDR[convCoursewareResCase_Resource_Rel.FtpResourceID] = objInFor[convCoursewareResCase_Resource_Rel.FtpResourceID];
objDR[convCoursewareResCase_Resource_Rel.FileOriginalName] = objInFor[convCoursewareResCase_Resource_Rel.FileOriginalName];
objDR[convCoursewareResCase_Resource_Rel.FileDirName] = objInFor[convCoursewareResCase_Resource_Rel.FileDirName];
objDR[convCoursewareResCase_Resource_Rel.FileRename] = objInFor[convCoursewareResCase_Resource_Rel.FileRename];
objDR[convCoursewareResCase_Resource_Rel.FileUpDate] = objInFor[convCoursewareResCase_Resource_Rel.FileUpDate];
objDR[convCoursewareResCase_Resource_Rel.FileUpTime] = objInFor[convCoursewareResCase_Resource_Rel.FileUpTime];
objDR[convCoursewareResCase_Resource_Rel.SaveMode] = objInFor[convCoursewareResCase_Resource_Rel.SaveMode];
objDR[convCoursewareResCase_Resource_Rel.id_ResourceType] = objInFor[convCoursewareResCase_Resource_Rel.id_ResourceType];
objDR[convCoursewareResCase_Resource_Rel.ResourceTypeID] = objInFor[convCoursewareResCase_Resource_Rel.ResourceTypeID];
objDR[convCoursewareResCase_Resource_Rel.ResourceTypeName] = objInFor[convCoursewareResCase_Resource_Rel.ResourceTypeName];
objDR[convCoursewareResCase_Resource_Rel.ResourceOwner] = objInFor[convCoursewareResCase_Resource_Rel.ResourceOwner];
objDR[convCoursewareResCase_Resource_Rel.ftpFileType] = objInFor[convCoursewareResCase_Resource_Rel.ftpFileType];
objDR[convCoursewareResCase_Resource_Rel.ftpFileSize] = objInFor[convCoursewareResCase_Resource_Rel.ftpFileSize];
objDR[convCoursewareResCase_Resource_Rel.ftpResourceOwner] = objInFor[convCoursewareResCase_Resource_Rel.ftpResourceOwner];
objDR[convCoursewareResCase_Resource_Rel.FileOriginName] = objInFor[convCoursewareResCase_Resource_Rel.FileOriginName];
objDR[convCoursewareResCase_Resource_Rel.IsExistFile] = objInFor[convCoursewareResCase_Resource_Rel.IsExistFile];
objDR[convCoursewareResCase_Resource_Rel.FileNewName] = objInFor[convCoursewareResCase_Resource_Rel.FileNewName];
objDR[convCoursewareResCase_Resource_Rel.FileOldName] = objInFor[convCoursewareResCase_Resource_Rel.FileOldName];
objDR[convCoursewareResCase_Resource_Rel.IsMain] = objInFor[convCoursewareResCase_Resource_Rel.IsMain];
objDR[convCoursewareResCase_Resource_Rel.id_UsingMode] = objInFor[convCoursewareResCase_Resource_Rel.id_UsingMode];
objDR[convCoursewareResCase_Resource_Rel.IsVisible] = objInFor[convCoursewareResCase_Resource_Rel.IsVisible];
objDR[convCoursewareResCase_Resource_Rel.IndexNO] = objInFor[convCoursewareResCase_Resource_Rel.IndexNO];
objDR[convCoursewareResCase_Resource_Rel.BrowseCount] = objInFor[convCoursewareResCase_Resource_Rel.BrowseCount];
objDR[convCoursewareResCase_Resource_Rel.UpdDate] = objInFor[convCoursewareResCase_Resource_Rel.UpdDate];
objDR[convCoursewareResCase_Resource_Rel.UpdUser] = objInFor[convCoursewareResCase_Resource_Rel.UpdUser];
objDR[convCoursewareResCase_Resource_Rel.Memo] = objInFor[convCoursewareResCase_Resource_Rel.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}