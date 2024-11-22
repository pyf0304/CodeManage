
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseCommonBaseWApi
 表名:vCaseCommonBase(01120344)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:54
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
public static class clsvCaseCommonBaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetId_Case(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strId_Case, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_Case, 8, convCaseCommonBase.Id_Case);
clsCheckSql.CheckFieldForeignKey(strId_Case, 8, convCaseCommonBase.Id_Case);
objvCaseCommonBaseEN.Id_Case = strId_Case; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.Id_Case) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.Id_Case, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.Id_Case] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCaseId(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseId, 8, convCaseCommonBase.CaseId);
clsCheckSql.CheckFieldForeignKey(strCaseId, 8, convCaseCommonBase.CaseId);
objvCaseCommonBaseEN.CaseId = strCaseId; //案例Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CaseId) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CaseId, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CaseId] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCaseName(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseName, 100, convCaseCommonBase.CaseName);
objvCaseCommonBaseEN.CaseName = strCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CaseName) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CaseName, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CaseName] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCourseName(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCaseCommonBase.CourseName);
objvCaseCommonBaseEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CourseName) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CourseName, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CourseName] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetFuncModuleId(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCaseCommonBase.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCaseCommonBase.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCaseCommonBase.FuncModuleId);
objvCaseCommonBaseEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.FuncModuleId) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.FuncModuleId, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.FuncModuleId] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetFuncModuleName(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convCaseCommonBase.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCaseCommonBase.FuncModuleName);
objvCaseCommonBaseEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.FuncModuleName) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.FuncModuleName, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.FuncModuleName] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetFuncModuleName_Sim(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strFuncModuleName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName_Sim, 30, convCaseCommonBase.FuncModuleName_Sim);
objvCaseCommonBaseEN.FuncModuleName_Sim = strFuncModuleName_Sim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.FuncModuleName_Sim) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.FuncModuleName_Sim, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.FuncModuleName_Sim] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetOwnerId(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convCaseCommonBase.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCaseCommonBase.OwnerId);
objvCaseCommonBaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.OwnerId) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.OwnerId, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.OwnerId] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetOwnerName(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCaseCommonBase.OwnerName);
objvCaseCommonBaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.OwnerName) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.OwnerName, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.OwnerName] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCourseId(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCaseCommonBase.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCaseCommonBase.CourseId);
objvCaseCommonBaseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CourseId) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CourseId, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CourseId] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCourseCode(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCaseCommonBase.CourseCode);
objvCaseCommonBaseEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CourseCode) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CourseCode, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CourseCode] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCourseChapterId(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convCaseCommonBase.CourseChapterId);
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convCaseCommonBase.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convCaseCommonBase.CourseChapterId);
objvCaseCommonBaseEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CourseChapterId) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CourseChapterId, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CourseChapterId] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCourseChapterName(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterName, convCaseCommonBase.CourseChapterName);
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convCaseCommonBase.CourseChapterName);
objvCaseCommonBaseEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CourseChapterName) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CourseChapterName, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CourseChapterName] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCaseDate(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseDate, 8, convCaseCommonBase.CaseDate);
clsCheckSql.CheckFieldForeignKey(strCaseDate, 8, convCaseCommonBase.CaseDate);
objvCaseCommonBaseEN.CaseDate = strCaseDate; //案例建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CaseDate) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CaseDate, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CaseDate] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCaseDateIn(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseDateIn, 8, convCaseCommonBase.CaseDateIn);
clsCheckSql.CheckFieldForeignKey(strCaseDateIn, 8, convCaseCommonBase.CaseDateIn);
objvCaseCommonBaseEN.CaseDateIn = strCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CaseDateIn) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CaseDateIn, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CaseDateIn] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCaseText(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseText, 8000, convCaseCommonBase.CaseText);
objvCaseCommonBaseEN.CaseText = strCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CaseText) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CaseText, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CaseText] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCaseTheme(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseTheme, 200, convCaseCommonBase.CaseTheme);
objvCaseCommonBaseEN.CaseTheme = strCaseTheme; //案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CaseTheme) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CaseTheme, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CaseTheme] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCaseTime(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseTime, 6, convCaseCommonBase.CaseTime);
clsCheckSql.CheckFieldForeignKey(strCaseTime, 6, convCaseCommonBase.CaseTime);
objvCaseCommonBaseEN.CaseTime = strCaseTime; //案例建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CaseTime) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CaseTime, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CaseTime] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCaseTimeIn(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseTimeIn, 6, convCaseCommonBase.CaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strCaseTimeIn, 6, convCaseCommonBase.CaseTimeIn);
objvCaseCommonBaseEN.CaseTimeIn = strCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CaseTimeIn) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CaseTimeIn, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CaseTimeIn] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetIsVisible(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvCaseCommonBaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.IsVisible) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.IsVisible, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.IsVisible] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN Setid_TeachSkill(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convCaseCommonBase.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convCaseCommonBase.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convCaseCommonBase.id_TeachSkill);
objvCaseCommonBaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.id_TeachSkill) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.id_TeachSkill, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.id_TeachSkill] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN Setid_Discipline(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convCaseCommonBase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convCaseCommonBase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convCaseCommonBase.id_Discipline);
objvCaseCommonBaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.id_Discipline) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.id_Discipline, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.id_Discipline] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN Setid_StudyLevel(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, convCaseCommonBase.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convCaseCommonBase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convCaseCommonBase.id_StudyLevel);
objvCaseCommonBaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.id_StudyLevel) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.id_StudyLevel, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.id_StudyLevel] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetId_CaseType(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strId_CaseType, convCaseCommonBase.Id_CaseType);
clsCheckSql.CheckFieldLen(strId_CaseType, 4, convCaseCommonBase.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, convCaseCommonBase.Id_CaseType);
objvCaseCommonBaseEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.Id_CaseType) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.Id_CaseType, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.Id_CaseType] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN Setid_TeachingPlan(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachingPlan, convCaseCommonBase.id_TeachingPlan);
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convCaseCommonBase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convCaseCommonBase.id_TeachingPlan);
objvCaseCommonBaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.id_TeachingPlan) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.id_TeachingPlan, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.id_TeachingPlan] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN Setid_XzMajor(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, convCaseCommonBase.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convCaseCommonBase.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convCaseCommonBase.id_XzMajor);
objvCaseCommonBaseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.id_XzMajor) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.id_XzMajor, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.id_XzMajor] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetBrowseCount(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, int intBrowseCount, string strComparisonOp="")
	{
objvCaseCommonBaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.BrowseCount) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.BrowseCount, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.BrowseCount] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN Setid_SenateGaugeVersion(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, convCaseCommonBase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convCaseCommonBase.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convCaseCommonBase.id_SenateGaugeVersion);
objvCaseCommonBaseEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.id_SenateGaugeVersion) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetDocFile(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, convCaseCommonBase.DocFile);
objvCaseCommonBaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.DocFile) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.DocFile, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.DocFile] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetIsNeedGeneWord(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvCaseCommonBaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.IsNeedGeneWord) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.IsNeedGeneWord, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.IsNeedGeneWord] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetMemo(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCaseCommonBase.Memo);
objvCaseCommonBaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.Memo) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.Memo, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.Memo] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetUpdUserId(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convCaseCommonBase.UpdUserId);
objvCaseCommonBaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.UpdUserId) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.UpdUserId, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.UpdUserId] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetIsDualVideo(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDualVideo, convCaseCommonBase.IsDualVideo);
objvCaseCommonBaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.IsDualVideo) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.IsDualVideo, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.IsDualVideo] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetLikeCount(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, long lngLikeCount, string strComparisonOp="")
	{
objvCaseCommonBaseEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.LikeCount) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.LikeCount, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.LikeCount] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetWordCreateDate(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convCaseCommonBase.WordCreateDate);
objvCaseCommonBaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.WordCreateDate) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.WordCreateDate, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.WordCreateDate] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetUpdDate(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCaseCommonBase.UpdDate);
objvCaseCommonBaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.UpdDate) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.UpdDate, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.UpdDate] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCaseLevelId(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convCaseCommonBase.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convCaseCommonBase.CaseLevelId);
objvCaseCommonBaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CaseLevelId) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CaseLevelId, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CaseLevelId] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetViewCount(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, int intViewCount, string strComparisonOp="")
	{
objvCaseCommonBaseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.ViewCount) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.ViewCount, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.ViewCount] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetIsShow(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, bool bolIsShow, string strComparisonOp="")
	{
objvCaseCommonBaseEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.IsShow) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.IsShow, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.IsShow] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetDownloadNumber(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, int intDownloadNumber, string strComparisonOp="")
	{
objvCaseCommonBaseEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.DownloadNumber) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.DownloadNumber, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.DownloadNumber] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetFileIntegration(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, int intFileIntegration, string strComparisonOp="")
	{
objvCaseCommonBaseEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.FileIntegration) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.FileIntegration, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.FileIntegration] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCollectionCount(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, long lngCollectionCount, string strComparisonOp="")
	{
objvCaseCommonBaseEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CollectionCount) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CollectionCount, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CollectionCount] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCaseCommonBaseEN objvCaseCommonBase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.Id_Case) == true)
{
string strComparisonOp_Id_Case = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.Id_Case];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.Id_Case, objvCaseCommonBase_Cond.Id_Case, strComparisonOp_Id_Case);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.CaseId) == true)
{
string strComparisonOp_CaseId = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CaseId, objvCaseCommonBase_Cond.CaseId, strComparisonOp_CaseId);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.CaseName) == true)
{
string strComparisonOp_CaseName = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CaseName, objvCaseCommonBase_Cond.CaseName, strComparisonOp_CaseName);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.CourseName) == true)
{
string strComparisonOp_CourseName = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CourseName, objvCaseCommonBase_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.FuncModuleId, objvCaseCommonBase_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.FuncModuleName, objvCaseCommonBase_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.FuncModuleName_Sim) == true)
{
string strComparisonOp_FuncModuleName_Sim = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.FuncModuleName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.FuncModuleName_Sim, objvCaseCommonBase_Cond.FuncModuleName_Sim, strComparisonOp_FuncModuleName_Sim);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.OwnerId, objvCaseCommonBase_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.OwnerName, objvCaseCommonBase_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.CourseId) == true)
{
string strComparisonOp_CourseId = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CourseId, objvCaseCommonBase_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CourseCode, objvCaseCommonBase_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CourseChapterId, objvCaseCommonBase_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CourseChapterName, objvCaseCommonBase_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.CaseDate) == true)
{
string strComparisonOp_CaseDate = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.CaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CaseDate, objvCaseCommonBase_Cond.CaseDate, strComparisonOp_CaseDate);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.CaseDateIn) == true)
{
string strComparisonOp_CaseDateIn = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.CaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CaseDateIn, objvCaseCommonBase_Cond.CaseDateIn, strComparisonOp_CaseDateIn);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.CaseText) == true)
{
string strComparisonOp_CaseText = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.CaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CaseText, objvCaseCommonBase_Cond.CaseText, strComparisonOp_CaseText);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.CaseTheme) == true)
{
string strComparisonOp_CaseTheme = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.CaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CaseTheme, objvCaseCommonBase_Cond.CaseTheme, strComparisonOp_CaseTheme);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.CaseTime) == true)
{
string strComparisonOp_CaseTime = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.CaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CaseTime, objvCaseCommonBase_Cond.CaseTime, strComparisonOp_CaseTime);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.CaseTimeIn) == true)
{
string strComparisonOp_CaseTimeIn = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.CaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CaseTimeIn, objvCaseCommonBase_Cond.CaseTimeIn, strComparisonOp_CaseTimeIn);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.IsVisible) == true)
{
if (objvCaseCommonBase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCaseCommonBase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCaseCommonBase.IsVisible);
}
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.id_TeachSkill, objvCaseCommonBase_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.id_Discipline, objvCaseCommonBase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.id_StudyLevel, objvCaseCommonBase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.Id_CaseType, objvCaseCommonBase_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.id_TeachingPlan, objvCaseCommonBase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.id_XzMajor, objvCaseCommonBase_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCommonBase.BrowseCount, objvCaseCommonBase_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.id_SenateGaugeVersion, objvCaseCommonBase_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.DocFile) == true)
{
string strComparisonOp_DocFile = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.DocFile, objvCaseCommonBase_Cond.DocFile, strComparisonOp_DocFile);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.IsNeedGeneWord) == true)
{
if (objvCaseCommonBase_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCaseCommonBase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCaseCommonBase.IsNeedGeneWord);
}
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.Memo) == true)
{
string strComparisonOp_Memo = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.Memo, objvCaseCommonBase_Cond.Memo, strComparisonOp_Memo);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.UpdUserId, objvCaseCommonBase_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.IsDualVideo) == true)
{
if (objvCaseCommonBase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCaseCommonBase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCaseCommonBase.IsDualVideo);
}
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCommonBase.LikeCount, objvCaseCommonBase_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.WordCreateDate, objvCaseCommonBase_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.UpdDate, objvCaseCommonBase_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CaseLevelId, objvCaseCommonBase_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCommonBase.ViewCount, objvCaseCommonBase_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.IsShow) == true)
{
if (objvCaseCommonBase_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCaseCommonBase.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCaseCommonBase.IsShow);
}
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCommonBase.DownloadNumber, objvCaseCommonBase_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCommonBase.FileIntegration, objvCaseCommonBase_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objvCaseCommonBase_Cond.IsUpdated(convCaseCommonBase.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvCaseCommonBase_Cond.dicFldComparisonOp[convCaseCommonBase.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCommonBase.CollectionCount, objvCaseCommonBase_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v案例公共基类(vCaseCommonBase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCaseCommonBaseWApi
{
private static readonly string mstrApiControllerName = "vCaseCommonBaseApi";

 public clsvCaseCommonBaseWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_Id_Case(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v案例公共基类]...","0");
List<clsvCaseCommonBaseEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="Id_Case";
objDDL.DataTextField="CaseName";
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
public static void BindCbo_Id_Case(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convCaseCommonBase.Id_Case); 
List<clsvCaseCommonBaseEN> arrObjLst = clsvCaseCommonBaseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvCaseCommonBaseEN objvCaseCommonBaseEN = new clsvCaseCommonBaseEN()
{
Id_Case = "0",
CaseName = "选[v案例公共基类]..."
};
arrObjLst.Insert(0, objvCaseCommonBaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convCaseCommonBase.Id_Case;
objComboBox.DisplayMember = convCaseCommonBase.CaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_Case">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseCommonBaseEN GetObjById_Case(string strId_Case)
{
string strAction = "GetObjById_Case";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseCommonBaseEN objvCaseCommonBaseEN = null;
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
objvCaseCommonBaseEN = JsonConvert.DeserializeObject<clsvCaseCommonBaseEN>((string)jobjReturn["ReturnObj"]);
return objvCaseCommonBaseEN;
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
public static clsvCaseCommonBaseEN GetObjById_Case_WA_Cache(string strId_Case)
{
string strAction = "GetObjById_Case_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseCommonBaseEN objvCaseCommonBaseEN = null;
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
objvCaseCommonBaseEN = JsonConvert.DeserializeObject<clsvCaseCommonBaseEN>((string)jobjReturn["ReturnObj"]);
return objvCaseCommonBaseEN;
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
public static clsvCaseCommonBaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseCommonBaseEN objvCaseCommonBaseEN = null;
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
objvCaseCommonBaseEN = JsonConvert.DeserializeObject<clsvCaseCommonBaseEN>((string)jobjReturn["ReturnObj"]);
return objvCaseCommonBaseEN;
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
public static clsvCaseCommonBaseEN GetObjById_Case_Cache(string strId_Case)
{
if (string.IsNullOrEmpty(strId_Case) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvCaseCommonBaseEN._CurrTabName_S);
List<clsvCaseCommonBaseEN> arrvCaseCommonBaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCaseCommonBaseEN> arrvCaseCommonBaseObjLst_Sel =
from objvCaseCommonBaseEN in arrvCaseCommonBaseObjLst_Cache
where objvCaseCommonBaseEN.Id_Case == strId_Case
select objvCaseCommonBaseEN;
if (arrvCaseCommonBaseObjLst_Sel.Count() == 0)
{
   clsvCaseCommonBaseEN obj = clsvCaseCommonBaseWApi.GetObjById_Case(strId_Case);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCaseCommonBaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strId_Case">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCaseNameById_Case_Cache(string strId_Case)
{
if (string.IsNullOrEmpty(strId_Case) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvCaseCommonBaseEN._CurrTabName_S);
List<clsvCaseCommonBaseEN> arrvCaseCommonBaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCaseCommonBaseEN> arrvCaseCommonBaseObjLst_Sel1 =
from objvCaseCommonBaseEN in arrvCaseCommonBaseObjLst_Cache
where objvCaseCommonBaseEN.Id_Case == strId_Case
select objvCaseCommonBaseEN;
List <clsvCaseCommonBaseEN> arrvCaseCommonBaseObjLst_Sel = new List<clsvCaseCommonBaseEN>();
foreach (clsvCaseCommonBaseEN obj in arrvCaseCommonBaseObjLst_Sel1)
{
arrvCaseCommonBaseObjLst_Sel.Add(obj);
}
if (arrvCaseCommonBaseObjLst_Sel.Count > 0)
{
return arrvCaseCommonBaseObjLst_Sel[0].CaseName;
}
string strErrMsgForGetObjById = string.Format("在vCaseCommonBase对象缓存列表中,找不到记录[Id_Case = {0}](函数:{1})", strId_Case, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvCaseCommonBaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strId_Case">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameById_Case_Cache(string strId_Case)
{
if (string.IsNullOrEmpty(strId_Case) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvCaseCommonBaseEN._CurrTabName_S);
List<clsvCaseCommonBaseEN> arrvCaseCommonBaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCaseCommonBaseEN> arrvCaseCommonBaseObjLst_Sel1 =
from objvCaseCommonBaseEN in arrvCaseCommonBaseObjLst_Cache
where objvCaseCommonBaseEN.Id_Case == strId_Case
select objvCaseCommonBaseEN;
List <clsvCaseCommonBaseEN> arrvCaseCommonBaseObjLst_Sel = new List<clsvCaseCommonBaseEN>();
foreach (clsvCaseCommonBaseEN obj in arrvCaseCommonBaseObjLst_Sel1)
{
arrvCaseCommonBaseObjLst_Sel.Add(obj);
}
if (arrvCaseCommonBaseObjLst_Sel.Count > 0)
{
return arrvCaseCommonBaseObjLst_Sel[0].CaseName;
}
string strErrMsgForGetObjById = string.Format("在vCaseCommonBase对象缓存列表中,找不到记录的相关名称[Id_Case = {0}](函数:{1})", strId_Case, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvCaseCommonBaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseCommonBaseEN> GetObjLst(string strWhereCond)
{
 List<clsvCaseCommonBaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseCommonBaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseCommonBaseEN> GetObjLstById_CaseLst(List<string> arrId_Case)
{
 List<clsvCaseCommonBaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseCommonBaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvCaseCommonBaseEN> GetObjLstById_CaseLst_Cache(List<string> arrId_Case)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCaseCommonBaseEN._CurrTabName_S);
List<clsvCaseCommonBaseEN> arrvCaseCommonBaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCaseCommonBaseEN> arrvCaseCommonBaseObjLst_Sel =
from objvCaseCommonBaseEN in arrvCaseCommonBaseObjLst_Cache
where arrId_Case.Contains(objvCaseCommonBaseEN.Id_Case)
select objvCaseCommonBaseEN;
return arrvCaseCommonBaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseCommonBaseEN> GetObjLstById_CaseLst_WA_Cache(List<string> arrId_Case)
{
 List<clsvCaseCommonBaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseCommonBaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseCommonBaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCaseCommonBaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseCommonBaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseCommonBaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCaseCommonBaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseCommonBaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseCommonBaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCaseCommonBaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseCommonBaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseCommonBaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCaseCommonBaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseCommonBaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvCaseCommonBaseENS">源对象</param>
 /// <param name = "objvCaseCommonBaseENT">目标对象</param>
 public static void CopyTo(clsvCaseCommonBaseEN objvCaseCommonBaseENS, clsvCaseCommonBaseEN objvCaseCommonBaseENT)
{
try
{
objvCaseCommonBaseENT.Id_Case = objvCaseCommonBaseENS.Id_Case; //案例流水号
objvCaseCommonBaseENT.CaseId = objvCaseCommonBaseENS.CaseId; //案例Id
objvCaseCommonBaseENT.CaseName = objvCaseCommonBaseENS.CaseName; //案例名称
objvCaseCommonBaseENT.CourseName = objvCaseCommonBaseENS.CourseName; //课程名称
objvCaseCommonBaseENT.FuncModuleId = objvCaseCommonBaseENS.FuncModuleId; //功能模块Id
objvCaseCommonBaseENT.FuncModuleName = objvCaseCommonBaseENS.FuncModuleName; //功能模块名称
objvCaseCommonBaseENT.FuncModuleName_Sim = objvCaseCommonBaseENS.FuncModuleName_Sim; //功能模块简称
objvCaseCommonBaseENT.OwnerId = objvCaseCommonBaseENS.OwnerId; //拥有者Id
objvCaseCommonBaseENT.OwnerName = objvCaseCommonBaseENS.OwnerName; //拥有者姓名
objvCaseCommonBaseENT.CourseId = objvCaseCommonBaseENS.CourseId; //课程Id
objvCaseCommonBaseENT.CourseCode = objvCaseCommonBaseENS.CourseCode; //课程代码
objvCaseCommonBaseENT.CourseChapterId = objvCaseCommonBaseENS.CourseChapterId; //课程章节ID
objvCaseCommonBaseENT.CourseChapterName = objvCaseCommonBaseENS.CourseChapterName; //课程章节名称
objvCaseCommonBaseENT.CaseDate = objvCaseCommonBaseENS.CaseDate; //案例建立日期
objvCaseCommonBaseENT.CaseDateIn = objvCaseCommonBaseENS.CaseDateIn; //案例入库日期
objvCaseCommonBaseENT.CaseText = objvCaseCommonBaseENS.CaseText; //案例文本内容
objvCaseCommonBaseENT.CaseTheme = objvCaseCommonBaseENS.CaseTheme; //案例主题词
objvCaseCommonBaseENT.CaseTime = objvCaseCommonBaseENS.CaseTime; //案例建立时间
objvCaseCommonBaseENT.CaseTimeIn = objvCaseCommonBaseENS.CaseTimeIn; //案例入库时间
objvCaseCommonBaseENT.IsVisible = objvCaseCommonBaseENS.IsVisible; //是否显示
objvCaseCommonBaseENT.id_TeachSkill = objvCaseCommonBaseENS.id_TeachSkill; //教学技能流水号
objvCaseCommonBaseENT.id_Discipline = objvCaseCommonBaseENS.id_Discipline; //学科流水号
objvCaseCommonBaseENT.id_StudyLevel = objvCaseCommonBaseENS.id_StudyLevel; //id_StudyLevel
objvCaseCommonBaseENT.Id_CaseType = objvCaseCommonBaseENS.Id_CaseType; //案例类型流水号
objvCaseCommonBaseENT.id_TeachingPlan = objvCaseCommonBaseENS.id_TeachingPlan; //教案流水号
objvCaseCommonBaseENT.id_XzMajor = objvCaseCommonBaseENS.id_XzMajor; //专业流水号
objvCaseCommonBaseENT.BrowseCount = objvCaseCommonBaseENS.BrowseCount; //浏览次数
objvCaseCommonBaseENT.id_SenateGaugeVersion = objvCaseCommonBaseENS.id_SenateGaugeVersion; //评价量表版本流水号
objvCaseCommonBaseENT.DocFile = objvCaseCommonBaseENS.DocFile; //生成的Word文件名
objvCaseCommonBaseENT.IsNeedGeneWord = objvCaseCommonBaseENS.IsNeedGeneWord; //是否需要生成Word
objvCaseCommonBaseENT.Memo = objvCaseCommonBaseENS.Memo; //备注
objvCaseCommonBaseENT.UpdUserId = objvCaseCommonBaseENS.UpdUserId; //修改用户Id
objvCaseCommonBaseENT.IsDualVideo = objvCaseCommonBaseENS.IsDualVideo; //是否双视频
objvCaseCommonBaseENT.LikeCount = objvCaseCommonBaseENS.LikeCount; //资源喜欢数量
objvCaseCommonBaseENT.WordCreateDate = objvCaseCommonBaseENS.WordCreateDate; //Word生成日期
objvCaseCommonBaseENT.UpdDate = objvCaseCommonBaseENS.UpdDate; //修改日期
objvCaseCommonBaseENT.CaseLevelId = objvCaseCommonBaseENS.CaseLevelId; //课例等级Id
objvCaseCommonBaseENT.ViewCount = objvCaseCommonBaseENS.ViewCount; //浏览量
objvCaseCommonBaseENT.IsShow = objvCaseCommonBaseENS.IsShow; //是否启用
objvCaseCommonBaseENT.DownloadNumber = objvCaseCommonBaseENS.DownloadNumber; //下载数目
objvCaseCommonBaseENT.FileIntegration = objvCaseCommonBaseENS.FileIntegration; //文件积分
objvCaseCommonBaseENT.CollectionCount = objvCaseCommonBaseENS.CollectionCount; //收藏数量
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
public static DataTable ToDataTable(List<clsvCaseCommonBaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCaseCommonBaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCaseCommonBaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCaseCommonBaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCaseCommonBaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCaseCommonBaseEN.AttributeName)
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
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseCommonBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseCommonBaseWApi没有刷新缓存机制(clsCaseCommonBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_Case");
//if (arrvCaseCommonBaseObjLst_Cache == null)
//{
//arrvCaseCommonBaseObjLst_Cache = await clsvCaseCommonBaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCaseCommonBaseEN._CurrTabName_S);
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
public static List<clsvCaseCommonBaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCaseCommonBaseEN._CurrTabName_S);
List<clsvCaseCommonBaseEN> arrvCaseCommonBaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCaseCommonBaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCaseCommonBaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCaseCommonBase.Id_Case, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.CaseId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.CaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.FuncModuleName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.CaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.CaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.CaseText, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.CaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.CaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.CaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCaseCommonBase.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCaseCommonBase.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCaseCommonBase.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCaseCommonBase.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convCaseCommonBase.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCommonBase.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCaseCommonBase.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCaseCommonBase.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convCaseCommonBase.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(convCaseCommonBase.CollectionCount, Type.GetType("System.Int64"));
foreach (clsvCaseCommonBaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCaseCommonBase.Id_Case] = objInFor[convCaseCommonBase.Id_Case];
objDR[convCaseCommonBase.CaseId] = objInFor[convCaseCommonBase.CaseId];
objDR[convCaseCommonBase.CaseName] = objInFor[convCaseCommonBase.CaseName];
objDR[convCaseCommonBase.CourseName] = objInFor[convCaseCommonBase.CourseName];
objDR[convCaseCommonBase.FuncModuleId] = objInFor[convCaseCommonBase.FuncModuleId];
objDR[convCaseCommonBase.FuncModuleName] = objInFor[convCaseCommonBase.FuncModuleName];
objDR[convCaseCommonBase.FuncModuleName_Sim] = objInFor[convCaseCommonBase.FuncModuleName_Sim];
objDR[convCaseCommonBase.OwnerId] = objInFor[convCaseCommonBase.OwnerId];
objDR[convCaseCommonBase.OwnerName] = objInFor[convCaseCommonBase.OwnerName];
objDR[convCaseCommonBase.CourseId] = objInFor[convCaseCommonBase.CourseId];
objDR[convCaseCommonBase.CourseCode] = objInFor[convCaseCommonBase.CourseCode];
objDR[convCaseCommonBase.CourseChapterId] = objInFor[convCaseCommonBase.CourseChapterId];
objDR[convCaseCommonBase.CourseChapterName] = objInFor[convCaseCommonBase.CourseChapterName];
objDR[convCaseCommonBase.CaseDate] = objInFor[convCaseCommonBase.CaseDate];
objDR[convCaseCommonBase.CaseDateIn] = objInFor[convCaseCommonBase.CaseDateIn];
objDR[convCaseCommonBase.CaseText] = objInFor[convCaseCommonBase.CaseText];
objDR[convCaseCommonBase.CaseTheme] = objInFor[convCaseCommonBase.CaseTheme];
objDR[convCaseCommonBase.CaseTime] = objInFor[convCaseCommonBase.CaseTime];
objDR[convCaseCommonBase.CaseTimeIn] = objInFor[convCaseCommonBase.CaseTimeIn];
objDR[convCaseCommonBase.IsVisible] = objInFor[convCaseCommonBase.IsVisible];
objDR[convCaseCommonBase.id_TeachSkill] = objInFor[convCaseCommonBase.id_TeachSkill];
objDR[convCaseCommonBase.id_Discipline] = objInFor[convCaseCommonBase.id_Discipline];
objDR[convCaseCommonBase.id_StudyLevel] = objInFor[convCaseCommonBase.id_StudyLevel];
objDR[convCaseCommonBase.Id_CaseType] = objInFor[convCaseCommonBase.Id_CaseType];
objDR[convCaseCommonBase.id_TeachingPlan] = objInFor[convCaseCommonBase.id_TeachingPlan];
objDR[convCaseCommonBase.id_XzMajor] = objInFor[convCaseCommonBase.id_XzMajor];
objDR[convCaseCommonBase.BrowseCount] = objInFor[convCaseCommonBase.BrowseCount];
objDR[convCaseCommonBase.id_SenateGaugeVersion] = objInFor[convCaseCommonBase.id_SenateGaugeVersion];
objDR[convCaseCommonBase.DocFile] = objInFor[convCaseCommonBase.DocFile];
objDR[convCaseCommonBase.IsNeedGeneWord] = objInFor[convCaseCommonBase.IsNeedGeneWord];
objDR[convCaseCommonBase.Memo] = objInFor[convCaseCommonBase.Memo];
objDR[convCaseCommonBase.UpdUserId] = objInFor[convCaseCommonBase.UpdUserId];
objDR[convCaseCommonBase.IsDualVideo] = objInFor[convCaseCommonBase.IsDualVideo];
objDR[convCaseCommonBase.LikeCount] = objInFor[convCaseCommonBase.LikeCount];
objDR[convCaseCommonBase.WordCreateDate] = objInFor[convCaseCommonBase.WordCreateDate];
objDR[convCaseCommonBase.UpdDate] = objInFor[convCaseCommonBase.UpdDate];
objDR[convCaseCommonBase.CaseLevelId] = objInFor[convCaseCommonBase.CaseLevelId];
objDR[convCaseCommonBase.ViewCount] = objInFor[convCaseCommonBase.ViewCount];
objDR[convCaseCommonBase.IsShow] = objInFor[convCaseCommonBase.IsShow];
objDR[convCaseCommonBase.DownloadNumber] = objInFor[convCaseCommonBase.DownloadNumber];
objDR[convCaseCommonBase.FileIntegration] = objInFor[convCaseCommonBase.FileIntegration];
objDR[convCaseCommonBase.CollectionCount] = objInFor[convCaseCommonBase.CollectionCount];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}