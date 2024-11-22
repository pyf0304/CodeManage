
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseCommonBaseWApi
 表名:CaseCommonBase(01120343)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:40
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
public static class clsCaseCommonBaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetId_Case(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strId_Case, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_Case, 8, conCaseCommonBase.Id_Case);
clsCheckSql.CheckFieldForeignKey(strId_Case, 8, conCaseCommonBase.Id_Case);
objCaseCommonBaseEN.Id_Case = strId_Case; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.Id_Case) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.Id_Case, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.Id_Case] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetCaseId(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strCaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseId, conCaseCommonBase.CaseId);
clsCheckSql.CheckFieldLen(strCaseId, 8, conCaseCommonBase.CaseId);
clsCheckSql.CheckFieldForeignKey(strCaseId, 8, conCaseCommonBase.CaseId);
objCaseCommonBaseEN.CaseId = strCaseId; //案例Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CaseId) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CaseId, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CaseId] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetCaseName(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseName, conCaseCommonBase.CaseName);
clsCheckSql.CheckFieldLen(strCaseName, 100, conCaseCommonBase.CaseName);
objCaseCommonBaseEN.CaseName = strCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CaseName) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CaseName, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CaseName] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetCaseText(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseText, 8000, conCaseCommonBase.CaseText);
objCaseCommonBaseEN.CaseText = strCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CaseText) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CaseText, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CaseText] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetCaseTheme(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseTheme, 200, conCaseCommonBase.CaseTheme);
objCaseCommonBaseEN.CaseTheme = strCaseTheme; //案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CaseTheme) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CaseTheme, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CaseTheme] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetFuncModuleId(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, conCaseCommonBase.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conCaseCommonBase.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conCaseCommonBase.FuncModuleId);
objCaseCommonBaseEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.FuncModuleId) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.FuncModuleId, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.FuncModuleId] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetCourseChapterId(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, conCaseCommonBase.CourseChapterId);
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, conCaseCommonBase.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, conCaseCommonBase.CourseChapterId);
objCaseCommonBaseEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CourseChapterId) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CourseChapterId, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CourseChapterId] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetId_CaseType(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CaseType, 4, conCaseCommonBase.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, conCaseCommonBase.Id_CaseType);
objCaseCommonBaseEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.Id_CaseType) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.Id_CaseType, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.Id_CaseType] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetCaseDate(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseDate, 8, conCaseCommonBase.CaseDate);
clsCheckSql.CheckFieldForeignKey(strCaseDate, 8, conCaseCommonBase.CaseDate);
objCaseCommonBaseEN.CaseDate = strCaseDate; //案例建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CaseDate) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CaseDate, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CaseDate] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetCaseTime(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseTime, 6, conCaseCommonBase.CaseTime);
clsCheckSql.CheckFieldForeignKey(strCaseTime, 6, conCaseCommonBase.CaseTime);
objCaseCommonBaseEN.CaseTime = strCaseTime; //案例建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CaseTime) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CaseTime, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CaseTime] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetCaseDateIn(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseDateIn, 8, conCaseCommonBase.CaseDateIn);
clsCheckSql.CheckFieldForeignKey(strCaseDateIn, 8, conCaseCommonBase.CaseDateIn);
objCaseCommonBaseEN.CaseDateIn = strCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CaseDateIn) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CaseDateIn, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CaseDateIn] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetCaseTimeIn(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseTimeIn, 6, conCaseCommonBase.CaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strCaseTimeIn, 6, conCaseCommonBase.CaseTimeIn);
objCaseCommonBaseEN.CaseTimeIn = strCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CaseTimeIn) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CaseTimeIn, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CaseTimeIn] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetOwnerId(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, conCaseCommonBase.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, conCaseCommonBase.OwnerId);
objCaseCommonBaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.OwnerId) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.OwnerId, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.OwnerId] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN Setid_StudyLevel(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, conCaseCommonBase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, conCaseCommonBase.id_StudyLevel);
objCaseCommonBaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.id_StudyLevel) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.id_StudyLevel, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.id_StudyLevel] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN Setid_TeachingPlan(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, conCaseCommonBase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, conCaseCommonBase.id_TeachingPlan);
objCaseCommonBaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.id_TeachingPlan) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.id_TeachingPlan, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.id_TeachingPlan] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN Setid_Discipline(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, conCaseCommonBase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, conCaseCommonBase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, conCaseCommonBase.id_Discipline);
objCaseCommonBaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.id_Discipline) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.id_Discipline, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.id_Discipline] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetBrowseCount(this clsCaseCommonBaseEN objCaseCommonBaseEN, int intBrowseCount, string strComparisonOp="")
	{
objCaseCommonBaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.BrowseCount) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.BrowseCount, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.BrowseCount] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN Setid_SenateGaugeVersion(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, conCaseCommonBase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, conCaseCommonBase.id_SenateGaugeVersion);
objCaseCommonBaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.id_SenateGaugeVersion) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN Setid_TeachSkill(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, conCaseCommonBase.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, conCaseCommonBase.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, conCaseCommonBase.id_TeachSkill);
objCaseCommonBaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.id_TeachSkill) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.id_TeachSkill, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.id_TeachSkill] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetCaseLevelId(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, conCaseCommonBase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, conCaseCommonBase.CaseLevelId);
objCaseCommonBaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CaseLevelId) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CaseLevelId, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CaseLevelId] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetDocFile(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, conCaseCommonBase.DocFile);
objCaseCommonBaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.DocFile) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.DocFile, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.DocFile] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetIsNeedGeneWord(this clsCaseCommonBaseEN objCaseCommonBaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objCaseCommonBaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.IsNeedGeneWord) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.IsNeedGeneWord, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.IsNeedGeneWord] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetWordCreateDate(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, conCaseCommonBase.WordCreateDate);
objCaseCommonBaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.WordCreateDate) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.WordCreateDate, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.WordCreateDate] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetIsVisible(this clsCaseCommonBaseEN objCaseCommonBaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objCaseCommonBaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.IsVisible) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.IsVisible, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.IsVisible] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetIsDualVideo(this clsCaseCommonBaseEN objCaseCommonBaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objCaseCommonBaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.IsDualVideo) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.IsDualVideo, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.IsDualVideo] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN Setid_XzCollege(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzCollege, conCaseCommonBase.id_XzCollege);
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, conCaseCommonBase.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, conCaseCommonBase.id_XzCollege);
objCaseCommonBaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.id_XzCollege) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.id_XzCollege, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.id_XzCollege] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN Setid_XzMajor(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, conCaseCommonBase.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, conCaseCommonBase.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, conCaseCommonBase.id_XzMajor);
objCaseCommonBaseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.id_XzMajor) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.id_XzMajor, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.id_XzMajor] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetViewCount(this clsCaseCommonBaseEN objCaseCommonBaseEN, int intViewCount, string strComparisonOp="")
	{
objCaseCommonBaseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.ViewCount) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.ViewCount, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.ViewCount] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetIsShow(this clsCaseCommonBaseEN objCaseCommonBaseEN, bool bolIsShow, string strComparisonOp="")
	{
objCaseCommonBaseEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.IsShow) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.IsShow, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.IsShow] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetDownloadNumber(this clsCaseCommonBaseEN objCaseCommonBaseEN, int intDownloadNumber, string strComparisonOp="")
	{
objCaseCommonBaseEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.DownloadNumber) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.DownloadNumber, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.DownloadNumber] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetFileIntegration(this clsCaseCommonBaseEN objCaseCommonBaseEN, int intFileIntegration, string strComparisonOp="")
	{
objCaseCommonBaseEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.FileIntegration) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.FileIntegration, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.FileIntegration] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetLikeCount(this clsCaseCommonBaseEN objCaseCommonBaseEN, long lngLikeCount, string strComparisonOp="")
	{
objCaseCommonBaseEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.LikeCount) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.LikeCount, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.LikeCount] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetCollectionCount(this clsCaseCommonBaseEN objCaseCommonBaseEN, long lngCollectionCount, string strComparisonOp="")
	{
objCaseCommonBaseEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CollectionCount) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CollectionCount, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CollectionCount] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetRecommendedDegreeId(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, conCaseCommonBase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, conCaseCommonBase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, conCaseCommonBase.RecommendedDegreeId);
objCaseCommonBaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.RecommendedDegreeId) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.RecommendedDegreeId, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.RecommendedDegreeId] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetCourseId(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conCaseCommonBase.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, conCaseCommonBase.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conCaseCommonBase.CourseId);
objCaseCommonBaseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CourseId) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CourseId, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CourseId] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN Setid_CaseType4FuncModuleId(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strid_CaseType4FuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CaseType4FuncModuleId, 4, conCaseCommonBase.id_CaseType4FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strid_CaseType4FuncModuleId, 4, conCaseCommonBase.id_CaseType4FuncModuleId);
objCaseCommonBaseEN.id_CaseType4FuncModuleId = strid_CaseType4FuncModuleId; //案例类型流水号4模块
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.id_CaseType4FuncModuleId) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.id_CaseType4FuncModuleId, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.id_CaseType4FuncModuleId] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetftpFileType(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, conCaseCommonBase.ftpFileType);
objCaseCommonBaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.ftpFileType) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.ftpFileType, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.ftpFileType] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetVideoUrl(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, conCaseCommonBase.VideoUrl);
objCaseCommonBaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.VideoUrl) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.VideoUrl, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.VideoUrl] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetVideoPath(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, conCaseCommonBase.VideoPath);
objCaseCommonBaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.VideoPath) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.VideoPath, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.VideoPath] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetResErrMsg(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, conCaseCommonBase.ResErrMsg);
objCaseCommonBaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.ResErrMsg) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.ResErrMsg, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.ResErrMsg] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetUpdDate(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCaseCommonBase.UpdDate);
objCaseCommonBaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.UpdDate) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.UpdDate, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.UpdDate] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetUpdUserId(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conCaseCommonBase.UpdUserId);
objCaseCommonBaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.UpdUserId) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.UpdUserId, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.UpdUserId] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCommonBaseEN SetMemo(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCaseCommonBase.Memo);
objCaseCommonBaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.Memo) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.Memo, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.Memo] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCaseCommonBaseEN objCaseCommonBase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.Id_Case) == true)
{
string strComparisonOp_Id_Case = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.Id_Case];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.Id_Case, objCaseCommonBase_Cond.Id_Case, strComparisonOp_Id_Case);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.CaseId) == true)
{
string strComparisonOp_CaseId = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.CaseId, objCaseCommonBase_Cond.CaseId, strComparisonOp_CaseId);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.CaseName) == true)
{
string strComparisonOp_CaseName = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.CaseName, objCaseCommonBase_Cond.CaseName, strComparisonOp_CaseName);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.CaseText) == true)
{
string strComparisonOp_CaseText = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.CaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.CaseText, objCaseCommonBase_Cond.CaseText, strComparisonOp_CaseText);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.CaseTheme) == true)
{
string strComparisonOp_CaseTheme = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.CaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.CaseTheme, objCaseCommonBase_Cond.CaseTheme, strComparisonOp_CaseTheme);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.FuncModuleId, objCaseCommonBase_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.CourseChapterId, objCaseCommonBase_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.Id_CaseType, objCaseCommonBase_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.CaseDate) == true)
{
string strComparisonOp_CaseDate = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.CaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.CaseDate, objCaseCommonBase_Cond.CaseDate, strComparisonOp_CaseDate);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.CaseTime) == true)
{
string strComparisonOp_CaseTime = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.CaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.CaseTime, objCaseCommonBase_Cond.CaseTime, strComparisonOp_CaseTime);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.CaseDateIn) == true)
{
string strComparisonOp_CaseDateIn = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.CaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.CaseDateIn, objCaseCommonBase_Cond.CaseDateIn, strComparisonOp_CaseDateIn);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.CaseTimeIn) == true)
{
string strComparisonOp_CaseTimeIn = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.CaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.CaseTimeIn, objCaseCommonBase_Cond.CaseTimeIn, strComparisonOp_CaseTimeIn);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.OwnerId, objCaseCommonBase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.id_StudyLevel, objCaseCommonBase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.id_TeachingPlan, objCaseCommonBase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.id_Discipline, objCaseCommonBase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCommonBase.BrowseCount, objCaseCommonBase_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.id_SenateGaugeVersion, objCaseCommonBase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.id_TeachSkill, objCaseCommonBase_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.CaseLevelId, objCaseCommonBase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.DocFile) == true)
{
string strComparisonOp_DocFile = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.DocFile, objCaseCommonBase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.IsNeedGeneWord) == true)
{
if (objCaseCommonBase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCaseCommonBase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCaseCommonBase.IsNeedGeneWord);
}
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.WordCreateDate, objCaseCommonBase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.IsVisible) == true)
{
if (objCaseCommonBase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCaseCommonBase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCaseCommonBase.IsVisible);
}
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.IsDualVideo) == true)
{
if (objCaseCommonBase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCaseCommonBase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCaseCommonBase.IsDualVideo);
}
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.id_XzCollege, objCaseCommonBase_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.id_XzMajor, objCaseCommonBase_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.ViewCount) == true)
{
string strComparisonOp_ViewCount = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCommonBase.ViewCount, objCaseCommonBase_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.IsShow) == true)
{
if (objCaseCommonBase_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCaseCommonBase.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCaseCommonBase.IsShow);
}
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCommonBase.DownloadNumber, objCaseCommonBase_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCommonBase.FileIntegration, objCaseCommonBase_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.LikeCount) == true)
{
string strComparisonOp_LikeCount = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCommonBase.LikeCount, objCaseCommonBase_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCommonBase.CollectionCount, objCaseCommonBase_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.RecommendedDegreeId, objCaseCommonBase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.CourseId) == true)
{
string strComparisonOp_CourseId = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.CourseId, objCaseCommonBase_Cond.CourseId, strComparisonOp_CourseId);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.id_CaseType4FuncModuleId) == true)
{
string strComparisonOp_id_CaseType4FuncModuleId = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.id_CaseType4FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.id_CaseType4FuncModuleId, objCaseCommonBase_Cond.id_CaseType4FuncModuleId, strComparisonOp_id_CaseType4FuncModuleId);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.ftpFileType, objCaseCommonBase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.VideoUrl, objCaseCommonBase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.VideoPath, objCaseCommonBase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.ResErrMsg, objCaseCommonBase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.UpdDate) == true)
{
string strComparisonOp_UpdDate = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.UpdDate, objCaseCommonBase_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.UpdUserId, objCaseCommonBase_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objCaseCommonBase_Cond.IsUpdated(conCaseCommonBase.Memo) == true)
{
string strComparisonOp_Memo = objCaseCommonBase_Cond.dicFldComparisonOp[conCaseCommonBase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.Memo, objCaseCommonBase_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCaseCommonBaseEN objCaseCommonBaseEN)
{
 if (string.IsNullOrEmpty(objCaseCommonBaseEN.Id_Case) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCaseCommonBaseEN.sf_UpdFldSetStr = objCaseCommonBaseEN.getsf_UpdFldSetStr();
clsCaseCommonBaseWApi.CheckPropertyNew(objCaseCommonBaseEN); 
bool bolResult = clsCaseCommonBaseWApi.UpdateRecord(objCaseCommonBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCommonBaseWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCaseCommonBaseEN objCaseCommonBaseEN)
{
 if (string.IsNullOrEmpty(objCaseCommonBaseEN.Id_Case) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCaseCommonBaseWApi.IsExist(objCaseCommonBaseEN.Id_Case) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objCaseCommonBaseEN.Id_Case, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsCaseCommonBaseWApi.CheckPropertyNew(objCaseCommonBaseEN); 
bool bolResult = clsCaseCommonBaseWApi.AddNewRecord(objCaseCommonBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCommonBaseWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCaseCommonBaseEN objCaseCommonBaseEN)
{
try
{
clsCaseCommonBaseWApi.CheckPropertyNew(objCaseCommonBaseEN); 
string strId_Case = clsCaseCommonBaseWApi.AddNewRecordWithMaxId(objCaseCommonBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCommonBaseWApi.ReFreshCache();
return strId_Case;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strWhereCond)
{
try
{
clsCaseCommonBaseWApi.CheckPropertyNew(objCaseCommonBaseEN); 
bool bolResult = clsCaseCommonBaseWApi.UpdateWithCondition(objCaseCommonBaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCommonBaseWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 案例公共基类(CaseCommonBase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCaseCommonBaseWApi
{
private static readonly string mstrApiControllerName = "CaseCommonBaseApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsCaseCommonBaseWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCaseCommonBaseEN objCaseCommonBaseEN)
{
if (!Object.Equals(null, objCaseCommonBaseEN.Id_Case) && GetStrLen(objCaseCommonBaseEN.Id_Case) > 8)
{
 throw new Exception("字段[案例流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.CaseId) && GetStrLen(objCaseCommonBaseEN.CaseId) > 8)
{
 throw new Exception("字段[案例Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.CaseName) && GetStrLen(objCaseCommonBaseEN.CaseName) > 100)
{
 throw new Exception("字段[案例名称]的长度不能超过100!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.CaseText) && GetStrLen(objCaseCommonBaseEN.CaseText) > 8000)
{
 throw new Exception("字段[案例文本内容]的长度不能超过8000!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.CaseTheme) && GetStrLen(objCaseCommonBaseEN.CaseTheme) > 200)
{
 throw new Exception("字段[案例主题词]的长度不能超过200!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.FuncModuleId) && GetStrLen(objCaseCommonBaseEN.FuncModuleId) > 4)
{
 throw new Exception("字段[功能模块Id]的长度不能超过4!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.CourseChapterId) && GetStrLen(objCaseCommonBaseEN.CourseChapterId) > 8)
{
 throw new Exception("字段[课程章节ID]的长度不能超过8!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.Id_CaseType) && GetStrLen(objCaseCommonBaseEN.Id_CaseType) > 4)
{
 throw new Exception("字段[案例类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.CaseDate) && GetStrLen(objCaseCommonBaseEN.CaseDate) > 8)
{
 throw new Exception("字段[案例建立日期]的长度不能超过8!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.CaseTime) && GetStrLen(objCaseCommonBaseEN.CaseTime) > 6)
{
 throw new Exception("字段[案例建立时间]的长度不能超过6!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.CaseDateIn) && GetStrLen(objCaseCommonBaseEN.CaseDateIn) > 8)
{
 throw new Exception("字段[案例入库日期]的长度不能超过8!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.CaseTimeIn) && GetStrLen(objCaseCommonBaseEN.CaseTimeIn) > 6)
{
 throw new Exception("字段[案例入库时间]的长度不能超过6!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.OwnerId) && GetStrLen(objCaseCommonBaseEN.OwnerId) > 20)
{
 throw new Exception("字段[拥有者Id]的长度不能超过20!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.id_StudyLevel) && GetStrLen(objCaseCommonBaseEN.id_StudyLevel) > 4)
{
 throw new Exception("字段[id_StudyLevel]的长度不能超过4!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.id_TeachingPlan) && GetStrLen(objCaseCommonBaseEN.id_TeachingPlan) > 8)
{
 throw new Exception("字段[教案流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.id_Discipline) && GetStrLen(objCaseCommonBaseEN.id_Discipline) > 4)
{
 throw new Exception("字段[学科流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.id_SenateGaugeVersion) && GetStrLen(objCaseCommonBaseEN.id_SenateGaugeVersion) > 4)
{
 throw new Exception("字段[评价量表版本流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.id_TeachSkill) && GetStrLen(objCaseCommonBaseEN.id_TeachSkill) > 8)
{
 throw new Exception("字段[教学技能流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.CaseLevelId) && GetStrLen(objCaseCommonBaseEN.CaseLevelId) > 2)
{
 throw new Exception("字段[课例等级Id]的长度不能超过2!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.DocFile) && GetStrLen(objCaseCommonBaseEN.DocFile) > 200)
{
 throw new Exception("字段[生成的Word文件名]的长度不能超过200!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.WordCreateDate) && GetStrLen(objCaseCommonBaseEN.WordCreateDate) > 14)
{
 throw new Exception("字段[Word生成日期]的长度不能超过14!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.id_XzCollege) && GetStrLen(objCaseCommonBaseEN.id_XzCollege) > 4)
{
 throw new Exception("字段[学院流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.id_XzMajor) && GetStrLen(objCaseCommonBaseEN.id_XzMajor) > 8)
{
 throw new Exception("字段[专业流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.RecommendedDegreeId) && GetStrLen(objCaseCommonBaseEN.RecommendedDegreeId) > 2)
{
 throw new Exception("字段[推荐度Id]的长度不能超过2!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.CourseId) && GetStrLen(objCaseCommonBaseEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.id_CaseType4FuncModuleId) && GetStrLen(objCaseCommonBaseEN.id_CaseType4FuncModuleId) > 4)
{
 throw new Exception("字段[案例类型流水号4模块]的长度不能超过4!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.ftpFileType) && GetStrLen(objCaseCommonBaseEN.ftpFileType) > 30)
{
 throw new Exception("字段[ftp文件类型]的长度不能超过30!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.VideoUrl) && GetStrLen(objCaseCommonBaseEN.VideoUrl) > 1000)
{
 throw new Exception("字段[视频Url]的长度不能超过1000!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.VideoPath) && GetStrLen(objCaseCommonBaseEN.VideoPath) > 1000)
{
 throw new Exception("字段[视频目录]的长度不能超过1000!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.ResErrMsg) && GetStrLen(objCaseCommonBaseEN.ResErrMsg) > 30)
{
 throw new Exception("字段[资源错误信息]的长度不能超过30!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.UpdDate) && GetStrLen(objCaseCommonBaseEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.UpdUserId) && GetStrLen(objCaseCommonBaseEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objCaseCommonBaseEN.Memo) && GetStrLen(objCaseCommonBaseEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objCaseCommonBaseEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_Case">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseCommonBaseEN GetObjById_Case(string strId_Case)
{
string strAction = "GetObjById_Case";
string strErrMsg = string.Empty;
string strResult = "";
clsCaseCommonBaseEN objCaseCommonBaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_Case"] = strId_Case
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCaseCommonBaseEN = JsonConvert.DeserializeObject<clsCaseCommonBaseEN>((string)jobjReturn["ReturnObj"]);
return objCaseCommonBaseEN;
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
 /// <param name = "strId_Case">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseCommonBaseEN GetObjById_Case_WA_Cache(string strId_Case)
{
string strAction = "GetObjById_Case_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsCaseCommonBaseEN objCaseCommonBaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_Case"] = strId_Case
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCaseCommonBaseEN = JsonConvert.DeserializeObject<clsCaseCommonBaseEN>((string)jobjReturn["ReturnObj"]);
return objCaseCommonBaseEN;
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
public static clsCaseCommonBaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsCaseCommonBaseEN objCaseCommonBaseEN = null;
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
objCaseCommonBaseEN = JsonConvert.DeserializeObject<clsCaseCommonBaseEN>((string)jobjReturn["ReturnObj"]);
return objCaseCommonBaseEN;
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
 /// <param name = "strId_Case">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCaseCommonBaseEN GetObjById_Case_Cache(string strId_Case)
{
if (string.IsNullOrEmpty(strId_Case) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsCaseCommonBaseEN._CurrTabName_S);
List<clsCaseCommonBaseEN> arrCaseCommonBaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCaseCommonBaseEN> arrCaseCommonBaseObjLst_Sel =
from objCaseCommonBaseEN in arrCaseCommonBaseObjLst_Cache
where objCaseCommonBaseEN.Id_Case == strId_Case
select objCaseCommonBaseEN;
if (arrCaseCommonBaseObjLst_Sel.Count() == 0)
{
   clsCaseCommonBaseEN obj = clsCaseCommonBaseWApi.GetObjById_Case(strId_Case);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCaseCommonBaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseCommonBaseEN> GetObjLst(string strWhereCond)
{
 List<clsCaseCommonBaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCommonBaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseCommonBaseEN> GetObjLstById_CaseLst(List<string> arrId_Case)
{
 List<clsCaseCommonBaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_CaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_Case);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCommonBaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strId_Case">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsCaseCommonBaseEN> GetObjLstById_CaseLst_Cache(List<string> arrId_Case)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCaseCommonBaseEN._CurrTabName_S);
List<clsCaseCommonBaseEN> arrCaseCommonBaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCaseCommonBaseEN> arrCaseCommonBaseObjLst_Sel =
from objCaseCommonBaseEN in arrCaseCommonBaseObjLst_Cache
where arrId_Case.Contains(objCaseCommonBaseEN.Id_Case)
select objCaseCommonBaseEN;
return arrCaseCommonBaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseCommonBaseEN> GetObjLstById_CaseLst_WA_Cache(List<string> arrId_Case)
{
 List<clsCaseCommonBaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_CaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_Case);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCommonBaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseCommonBaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCaseCommonBaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCommonBaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseCommonBaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCaseCommonBaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCommonBaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseCommonBaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCaseCommonBaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCommonBaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseCommonBaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsCaseCommonBaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCommonBaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strId_Case)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsCaseCommonBaseEN objCaseCommonBaseEN = clsCaseCommonBaseWApi.GetObjById_Case(strId_Case);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strId_Case.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCaseCommonBaseWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelCaseCommonBases(List<string> arrId_Case)
{
string strAction = "DelCaseCommonBases";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_Case);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCaseCommonBaseWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelCaseCommonBasesByCond(string strWhereCond)
{
string strAction = "DelCaseCommonBasesByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsCaseCommonBaseEN objCaseCommonBaseEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseCommonBaseEN>(objCaseCommonBaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCommonBaseWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clsCaseCommonBaseEN objCaseCommonBaseEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseCommonBaseEN>(objCaseCommonBaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCommonBaseWApi.ReFreshCache();
var strId_Case = (string)jobjReturn["ReturnStr"];
return strId_Case;
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsCaseCommonBaseEN objCaseCommonBaseEN)
{
if (string.IsNullOrEmpty(objCaseCommonBaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCaseCommonBaseEN.Id_Case, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseCommonBaseEN>(objCaseCommonBaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCaseCommonBaseEN objCaseCommonBaseEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCaseCommonBaseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCaseCommonBaseEN.Id_Case, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCaseCommonBaseEN.Id_Case, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseCommonBaseEN>(objCaseCommonBaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
public static bool IsExist(string strId_Case)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_Case"] = strId_Case
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objCaseCommonBaseENS">源对象</param>
 /// <param name = "objCaseCommonBaseENT">目标对象</param>
 public static void CopyTo(clsCaseCommonBaseEN objCaseCommonBaseENS, clsCaseCommonBaseEN objCaseCommonBaseENT)
{
try
{
objCaseCommonBaseENT.Id_Case = objCaseCommonBaseENS.Id_Case; //案例流水号
objCaseCommonBaseENT.CaseId = objCaseCommonBaseENS.CaseId; //案例Id
objCaseCommonBaseENT.CaseName = objCaseCommonBaseENS.CaseName; //案例名称
objCaseCommonBaseENT.CaseText = objCaseCommonBaseENS.CaseText; //案例文本内容
objCaseCommonBaseENT.CaseTheme = objCaseCommonBaseENS.CaseTheme; //案例主题词
objCaseCommonBaseENT.FuncModuleId = objCaseCommonBaseENS.FuncModuleId; //功能模块Id
objCaseCommonBaseENT.CourseChapterId = objCaseCommonBaseENS.CourseChapterId; //课程章节ID
objCaseCommonBaseENT.Id_CaseType = objCaseCommonBaseENS.Id_CaseType; //案例类型流水号
objCaseCommonBaseENT.CaseDate = objCaseCommonBaseENS.CaseDate; //案例建立日期
objCaseCommonBaseENT.CaseTime = objCaseCommonBaseENS.CaseTime; //案例建立时间
objCaseCommonBaseENT.CaseDateIn = objCaseCommonBaseENS.CaseDateIn; //案例入库日期
objCaseCommonBaseENT.CaseTimeIn = objCaseCommonBaseENS.CaseTimeIn; //案例入库时间
objCaseCommonBaseENT.OwnerId = objCaseCommonBaseENS.OwnerId; //拥有者Id
objCaseCommonBaseENT.id_StudyLevel = objCaseCommonBaseENS.id_StudyLevel; //id_StudyLevel
objCaseCommonBaseENT.id_TeachingPlan = objCaseCommonBaseENS.id_TeachingPlan; //教案流水号
objCaseCommonBaseENT.id_Discipline = objCaseCommonBaseENS.id_Discipline; //学科流水号
objCaseCommonBaseENT.BrowseCount = objCaseCommonBaseENS.BrowseCount; //浏览次数
objCaseCommonBaseENT.id_SenateGaugeVersion = objCaseCommonBaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objCaseCommonBaseENT.id_TeachSkill = objCaseCommonBaseENS.id_TeachSkill; //教学技能流水号
objCaseCommonBaseENT.CaseLevelId = objCaseCommonBaseENS.CaseLevelId; //课例等级Id
objCaseCommonBaseENT.DocFile = objCaseCommonBaseENS.DocFile; //生成的Word文件名
objCaseCommonBaseENT.IsNeedGeneWord = objCaseCommonBaseENS.IsNeedGeneWord; //是否需要生成Word
objCaseCommonBaseENT.WordCreateDate = objCaseCommonBaseENS.WordCreateDate; //Word生成日期
objCaseCommonBaseENT.IsVisible = objCaseCommonBaseENS.IsVisible; //是否显示
objCaseCommonBaseENT.IsDualVideo = objCaseCommonBaseENS.IsDualVideo; //是否双视频
objCaseCommonBaseENT.id_XzCollege = objCaseCommonBaseENS.id_XzCollege; //学院流水号
objCaseCommonBaseENT.id_XzMajor = objCaseCommonBaseENS.id_XzMajor; //专业流水号
objCaseCommonBaseENT.ViewCount = objCaseCommonBaseENS.ViewCount; //浏览量
objCaseCommonBaseENT.IsShow = objCaseCommonBaseENS.IsShow; //是否启用
objCaseCommonBaseENT.DownloadNumber = objCaseCommonBaseENS.DownloadNumber; //下载数目
objCaseCommonBaseENT.FileIntegration = objCaseCommonBaseENS.FileIntegration; //文件积分
objCaseCommonBaseENT.LikeCount = objCaseCommonBaseENS.LikeCount; //资源喜欢数量
objCaseCommonBaseENT.CollectionCount = objCaseCommonBaseENS.CollectionCount; //收藏数量
objCaseCommonBaseENT.RecommendedDegreeId = objCaseCommonBaseENS.RecommendedDegreeId; //推荐度Id
objCaseCommonBaseENT.CourseId = objCaseCommonBaseENS.CourseId; //课程Id
objCaseCommonBaseENT.id_CaseType4FuncModuleId = objCaseCommonBaseENS.id_CaseType4FuncModuleId; //案例类型流水号4模块
objCaseCommonBaseENT.ftpFileType = objCaseCommonBaseENS.ftpFileType; //ftp文件类型
objCaseCommonBaseENT.VideoUrl = objCaseCommonBaseENS.VideoUrl; //视频Url
objCaseCommonBaseENT.VideoPath = objCaseCommonBaseENS.VideoPath; //视频目录
objCaseCommonBaseENT.ResErrMsg = objCaseCommonBaseENS.ResErrMsg; //资源错误信息
objCaseCommonBaseENT.UpdDate = objCaseCommonBaseENS.UpdDate; //修改日期
objCaseCommonBaseENT.UpdUserId = objCaseCommonBaseENS.UpdUserId; //修改用户Id
objCaseCommonBaseENT.Memo = objCaseCommonBaseENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsCaseCommonBaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCaseCommonBaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCaseCommonBaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCaseCommonBaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCaseCommonBaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCaseCommonBaseEN.AttributeName)
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
if (clsCaseCommonBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseCommonBaseWApi没有刷新缓存机制(clsCaseCommonBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_Case");
//if (arrCaseCommonBaseObjLst_Cache == null)
//{
//arrCaseCommonBaseObjLst_Cache = await clsCaseCommonBaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsCaseCommonBaseEN._CurrTabName_S);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsCaseCommonBaseWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCaseCommonBaseEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsCaseCommonBaseWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCaseCommonBaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsCaseCommonBaseEN._CurrTabName_S);
List<clsCaseCommonBaseEN> arrCaseCommonBaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCaseCommonBaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCaseCommonBaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCaseCommonBase.Id_Case, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.CaseId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.CaseName, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.CaseText, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.CaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.CaseDate, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.CaseTime, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.CaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.CaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conCaseCommonBase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCaseCommonBase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCaseCommonBase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCaseCommonBase.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conCaseCommonBase.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCaseCommonBase.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(conCaseCommonBase.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(conCaseCommonBase.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(conCaseCommonBase.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(conCaseCommonBase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.id_CaseType4FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCommonBase.Memo, Type.GetType("System.String"));
foreach (clsCaseCommonBaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCaseCommonBase.Id_Case] = objInFor[conCaseCommonBase.Id_Case];
objDR[conCaseCommonBase.CaseId] = objInFor[conCaseCommonBase.CaseId];
objDR[conCaseCommonBase.CaseName] = objInFor[conCaseCommonBase.CaseName];
objDR[conCaseCommonBase.CaseText] = objInFor[conCaseCommonBase.CaseText];
objDR[conCaseCommonBase.CaseTheme] = objInFor[conCaseCommonBase.CaseTheme];
objDR[conCaseCommonBase.FuncModuleId] = objInFor[conCaseCommonBase.FuncModuleId];
objDR[conCaseCommonBase.CourseChapterId] = objInFor[conCaseCommonBase.CourseChapterId];
objDR[conCaseCommonBase.Id_CaseType] = objInFor[conCaseCommonBase.Id_CaseType];
objDR[conCaseCommonBase.CaseDate] = objInFor[conCaseCommonBase.CaseDate];
objDR[conCaseCommonBase.CaseTime] = objInFor[conCaseCommonBase.CaseTime];
objDR[conCaseCommonBase.CaseDateIn] = objInFor[conCaseCommonBase.CaseDateIn];
objDR[conCaseCommonBase.CaseTimeIn] = objInFor[conCaseCommonBase.CaseTimeIn];
objDR[conCaseCommonBase.OwnerId] = objInFor[conCaseCommonBase.OwnerId];
objDR[conCaseCommonBase.id_StudyLevel] = objInFor[conCaseCommonBase.id_StudyLevel];
objDR[conCaseCommonBase.id_TeachingPlan] = objInFor[conCaseCommonBase.id_TeachingPlan];
objDR[conCaseCommonBase.id_Discipline] = objInFor[conCaseCommonBase.id_Discipline];
objDR[conCaseCommonBase.BrowseCount] = objInFor[conCaseCommonBase.BrowseCount];
objDR[conCaseCommonBase.id_SenateGaugeVersion] = objInFor[conCaseCommonBase.id_SenateGaugeVersion];
objDR[conCaseCommonBase.id_TeachSkill] = objInFor[conCaseCommonBase.id_TeachSkill];
objDR[conCaseCommonBase.CaseLevelId] = objInFor[conCaseCommonBase.CaseLevelId];
objDR[conCaseCommonBase.DocFile] = objInFor[conCaseCommonBase.DocFile];
objDR[conCaseCommonBase.IsNeedGeneWord] = objInFor[conCaseCommonBase.IsNeedGeneWord];
objDR[conCaseCommonBase.WordCreateDate] = objInFor[conCaseCommonBase.WordCreateDate];
objDR[conCaseCommonBase.IsVisible] = objInFor[conCaseCommonBase.IsVisible];
objDR[conCaseCommonBase.IsDualVideo] = objInFor[conCaseCommonBase.IsDualVideo];
objDR[conCaseCommonBase.id_XzCollege] = objInFor[conCaseCommonBase.id_XzCollege];
objDR[conCaseCommonBase.id_XzMajor] = objInFor[conCaseCommonBase.id_XzMajor];
objDR[conCaseCommonBase.ViewCount] = objInFor[conCaseCommonBase.ViewCount];
objDR[conCaseCommonBase.IsShow] = objInFor[conCaseCommonBase.IsShow];
objDR[conCaseCommonBase.DownloadNumber] = objInFor[conCaseCommonBase.DownloadNumber];
objDR[conCaseCommonBase.FileIntegration] = objInFor[conCaseCommonBase.FileIntegration];
objDR[conCaseCommonBase.LikeCount] = objInFor[conCaseCommonBase.LikeCount];
objDR[conCaseCommonBase.CollectionCount] = objInFor[conCaseCommonBase.CollectionCount];
objDR[conCaseCommonBase.RecommendedDegreeId] = objInFor[conCaseCommonBase.RecommendedDegreeId];
objDR[conCaseCommonBase.CourseId] = objInFor[conCaseCommonBase.CourseId];
objDR[conCaseCommonBase.id_CaseType4FuncModuleId] = objInFor[conCaseCommonBase.id_CaseType4FuncModuleId];
objDR[conCaseCommonBase.ftpFileType] = objInFor[conCaseCommonBase.ftpFileType];
objDR[conCaseCommonBase.VideoUrl] = objInFor[conCaseCommonBase.VideoUrl];
objDR[conCaseCommonBase.VideoPath] = objInFor[conCaseCommonBase.VideoPath];
objDR[conCaseCommonBase.ResErrMsg] = objInFor[conCaseCommonBase.ResErrMsg];
objDR[conCaseCommonBase.UpdDate] = objInFor[conCaseCommonBase.UpdDate];
objDR[conCaseCommonBase.UpdUserId] = objInFor[conCaseCommonBase.UpdUserId];
objDR[conCaseCommonBase.Memo] = objInFor[conCaseCommonBase.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 案例公共基类(CaseCommonBase)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4CaseCommonBase : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCommonBaseWApi.ReFreshThisCache();
}
}

}