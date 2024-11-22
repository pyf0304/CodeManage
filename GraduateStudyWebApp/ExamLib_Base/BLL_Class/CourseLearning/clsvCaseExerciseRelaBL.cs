
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseExerciseRelaBL
 表名:vCaseExerciseRela(01120436)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:58:33
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
public static class  clsvCaseExerciseRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdCaseExerciseRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseExerciseRelaEN GetObj(this K_IdCaseExerciseRela_vCaseExerciseRela myKey)
{
clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = clsvCaseExerciseRelaBL.vCaseExerciseRelaDA.GetObjByIdCaseExerciseRela(myKey.Value);
return objvCaseExerciseRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetIdCaseExerciseRela(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, long lngIdCaseExerciseRela, string strComparisonOp="")
	{
objvCaseExerciseRelaEN.IdCaseExerciseRela = lngIdCaseExerciseRela; //案例习题关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(convCaseExerciseRela.IdCaseExerciseRela) == false)
{
objvCaseExerciseRelaEN.dicFldComparisonOp.Add(convCaseExerciseRela.IdCaseExerciseRela, strComparisonOp);
}
else
{
objvCaseExerciseRelaEN.dicFldComparisonOp[convCaseExerciseRela.IdCaseExerciseRela] = strComparisonOp;
}
}
return objvCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetFuncModuleId(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCaseExerciseRela.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCaseExerciseRela.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCaseExerciseRela.FuncModuleId);
}
objvCaseExerciseRelaEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(convCaseExerciseRela.FuncModuleId) == false)
{
objvCaseExerciseRelaEN.dicFldComparisonOp.Add(convCaseExerciseRela.FuncModuleId, strComparisonOp);
}
else
{
objvCaseExerciseRelaEN.dicFldComparisonOp[convCaseExerciseRela.FuncModuleId] = strComparisonOp;
}
}
return objvCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetFuncModuleName(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convCaseExerciseRela.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCaseExerciseRela.FuncModuleName);
}
objvCaseExerciseRelaEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(convCaseExerciseRela.FuncModuleName) == false)
{
objvCaseExerciseRelaEN.dicFldComparisonOp.Add(convCaseExerciseRela.FuncModuleName, strComparisonOp);
}
else
{
objvCaseExerciseRelaEN.dicFldComparisonOp[convCaseExerciseRela.FuncModuleName] = strComparisonOp;
}
}
return objvCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetCaseId(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strCaseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseId, 8, convCaseExerciseRela.CaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseId, 8, convCaseExerciseRela.CaseId);
}
objvCaseExerciseRelaEN.CaseId = strCaseId; //案例Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(convCaseExerciseRela.CaseId) == false)
{
objvCaseExerciseRelaEN.dicFldComparisonOp.Add(convCaseExerciseRela.CaseId, strComparisonOp);
}
else
{
objvCaseExerciseRelaEN.dicFldComparisonOp[convCaseExerciseRela.CaseId] = strComparisonOp;
}
}
return objvCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetCaseName(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strCaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseName, 100, convCaseExerciseRela.CaseName);
}
objvCaseExerciseRelaEN.CaseName = strCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(convCaseExerciseRela.CaseName) == false)
{
objvCaseExerciseRelaEN.dicFldComparisonOp.Add(convCaseExerciseRela.CaseName, strComparisonOp);
}
else
{
objvCaseExerciseRelaEN.dicFldComparisonOp[convCaseExerciseRela.CaseName] = strComparisonOp;
}
}
return objvCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetOwnerId(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convCaseExerciseRela.OwnerId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCaseExerciseRela.OwnerId);
}
objvCaseExerciseRelaEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(convCaseExerciseRela.OwnerId) == false)
{
objvCaseExerciseRelaEN.dicFldComparisonOp.Add(convCaseExerciseRela.OwnerId, strComparisonOp);
}
else
{
objvCaseExerciseRelaEN.dicFldComparisonOp[convCaseExerciseRela.OwnerId] = strComparisonOp;
}
}
return objvCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetOwnerName(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCaseExerciseRela.OwnerName);
}
objvCaseExerciseRelaEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(convCaseExerciseRela.OwnerName) == false)
{
objvCaseExerciseRelaEN.dicFldComparisonOp.Add(convCaseExerciseRela.OwnerName, strComparisonOp);
}
else
{
objvCaseExerciseRelaEN.dicFldComparisonOp[convCaseExerciseRela.OwnerName] = strComparisonOp;
}
}
return objvCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetCourseExamPaperId(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strCourseExamPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convCaseExerciseRela.CourseExamPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convCaseExerciseRela.CourseExamPaperId);
}
objvCaseExerciseRelaEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(convCaseExerciseRela.CourseExamPaperId) == false)
{
objvCaseExerciseRelaEN.dicFldComparisonOp.Add(convCaseExerciseRela.CourseExamPaperId, strComparisonOp);
}
else
{
objvCaseExerciseRelaEN.dicFldComparisonOp[convCaseExerciseRela.CourseExamPaperId] = strComparisonOp;
}
}
return objvCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetExamPaperName(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strExamPaperName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, convCaseExerciseRela.ExamPaperName);
}
objvCaseExerciseRelaEN.ExamPaperName = strExamPaperName; //考卷名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(convCaseExerciseRela.ExamPaperName) == false)
{
objvCaseExerciseRelaEN.dicFldComparisonOp.Add(convCaseExerciseRela.ExamPaperName, strComparisonOp);
}
else
{
objvCaseExerciseRelaEN.dicFldComparisonOp[convCaseExerciseRela.ExamPaperName] = strComparisonOp;
}
}
return objvCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetCourseId(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convCaseExerciseRela.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCaseExerciseRela.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCaseExerciseRela.CourseId);
}
objvCaseExerciseRelaEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(convCaseExerciseRela.CourseId) == false)
{
objvCaseExerciseRelaEN.dicFldComparisonOp.Add(convCaseExerciseRela.CourseId, strComparisonOp);
}
else
{
objvCaseExerciseRelaEN.dicFldComparisonOp[convCaseExerciseRela.CourseId] = strComparisonOp;
}
}
return objvCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetCourseName(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCaseExerciseRela.CourseName);
}
objvCaseExerciseRelaEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(convCaseExerciseRela.CourseName) == false)
{
objvCaseExerciseRelaEN.dicFldComparisonOp.Add(convCaseExerciseRela.CourseName, strComparisonOp);
}
else
{
objvCaseExerciseRelaEN.dicFldComparisonOp[convCaseExerciseRela.CourseName] = strComparisonOp;
}
}
return objvCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetExamPaperTypeId(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strExamPaperTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamPaperTypeId, convCaseExerciseRela.ExamPaperTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamPaperTypeId, 2, convCaseExerciseRela.ExamPaperTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExamPaperTypeId, 2, convCaseExerciseRela.ExamPaperTypeId);
}
objvCaseExerciseRelaEN.ExamPaperTypeId = strExamPaperTypeId; //试卷类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(convCaseExerciseRela.ExamPaperTypeId) == false)
{
objvCaseExerciseRelaEN.dicFldComparisonOp.Add(convCaseExerciseRela.ExamPaperTypeId, strComparisonOp);
}
else
{
objvCaseExerciseRelaEN.dicFldComparisonOp[convCaseExerciseRela.ExamPaperTypeId] = strComparisonOp;
}
}
return objvCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetExamPaperTypeName(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strExamPaperTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamPaperTypeName, 30, convCaseExerciseRela.ExamPaperTypeName);
}
objvCaseExerciseRelaEN.ExamPaperTypeName = strExamPaperTypeName; //试卷类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(convCaseExerciseRela.ExamPaperTypeName) == false)
{
objvCaseExerciseRelaEN.dicFldComparisonOp.Add(convCaseExerciseRela.ExamPaperTypeName, strComparisonOp);
}
else
{
objvCaseExerciseRelaEN.dicFldComparisonOp[convCaseExerciseRela.ExamPaperTypeName] = strComparisonOp;
}
}
return objvCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetBrowseCount(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, int? intBrowseCount, string strComparisonOp="")
	{
objvCaseExerciseRelaEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(convCaseExerciseRela.BrowseCount) == false)
{
objvCaseExerciseRelaEN.dicFldComparisonOp.Add(convCaseExerciseRela.BrowseCount, strComparisonOp);
}
else
{
objvCaseExerciseRelaEN.dicFldComparisonOp[convCaseExerciseRela.BrowseCount] = strComparisonOp;
}
}
return objvCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetUpdDate(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCaseExerciseRela.UpdDate);
}
objvCaseExerciseRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(convCaseExerciseRela.UpdDate) == false)
{
objvCaseExerciseRelaEN.dicFldComparisonOp.Add(convCaseExerciseRela.UpdDate, strComparisonOp);
}
else
{
objvCaseExerciseRelaEN.dicFldComparisonOp[convCaseExerciseRela.UpdDate] = strComparisonOp;
}
}
return objvCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetUpdUserId(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convCaseExerciseRela.UpdUserId);
}
objvCaseExerciseRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(convCaseExerciseRela.UpdUserId) == false)
{
objvCaseExerciseRelaEN.dicFldComparisonOp.Add(convCaseExerciseRela.UpdUserId, strComparisonOp);
}
else
{
objvCaseExerciseRelaEN.dicFldComparisonOp[convCaseExerciseRela.UpdUserId] = strComparisonOp;
}
}
return objvCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetMemo(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCaseExerciseRela.Memo);
}
objvCaseExerciseRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(convCaseExerciseRela.Memo) == false)
{
objvCaseExerciseRelaEN.dicFldComparisonOp.Add(convCaseExerciseRela.Memo, strComparisonOp);
}
else
{
objvCaseExerciseRelaEN.dicFldComparisonOp[convCaseExerciseRela.Memo] = strComparisonOp;
}
}
return objvCaseExerciseRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaENS">源对象</param>
 /// <param name = "objvCaseExerciseRelaENT">目标对象</param>
 public static void CopyTo(this clsvCaseExerciseRelaEN objvCaseExerciseRelaENS, clsvCaseExerciseRelaEN objvCaseExerciseRelaENT)
{
try
{
objvCaseExerciseRelaENT.IdCaseExerciseRela = objvCaseExerciseRelaENS.IdCaseExerciseRela; //案例习题关系流水号
objvCaseExerciseRelaENT.FuncModuleId = objvCaseExerciseRelaENS.FuncModuleId; //功能模块Id
objvCaseExerciseRelaENT.FuncModuleName = objvCaseExerciseRelaENS.FuncModuleName; //功能模块名称
objvCaseExerciseRelaENT.CaseId = objvCaseExerciseRelaENS.CaseId; //案例Id
objvCaseExerciseRelaENT.CaseName = objvCaseExerciseRelaENS.CaseName; //案例名称
objvCaseExerciseRelaENT.OwnerId = objvCaseExerciseRelaENS.OwnerId; //拥有者Id
objvCaseExerciseRelaENT.OwnerName = objvCaseExerciseRelaENS.OwnerName; //拥有者姓名
objvCaseExerciseRelaENT.CourseExamPaperId = objvCaseExerciseRelaENS.CourseExamPaperId; //考卷流水号
objvCaseExerciseRelaENT.ExamPaperName = objvCaseExerciseRelaENS.ExamPaperName; //考卷名称
objvCaseExerciseRelaENT.CourseId = objvCaseExerciseRelaENS.CourseId; //课程Id
objvCaseExerciseRelaENT.CourseName = objvCaseExerciseRelaENS.CourseName; //课程名称
objvCaseExerciseRelaENT.ExamPaperTypeId = objvCaseExerciseRelaENS.ExamPaperTypeId; //试卷类型Id
objvCaseExerciseRelaENT.ExamPaperTypeName = objvCaseExerciseRelaENS.ExamPaperTypeName; //试卷类型名称
objvCaseExerciseRelaENT.BrowseCount = objvCaseExerciseRelaENS.BrowseCount; //浏览次数
objvCaseExerciseRelaENT.UpdDate = objvCaseExerciseRelaENS.UpdDate; //修改日期
objvCaseExerciseRelaENT.UpdUserId = objvCaseExerciseRelaENS.UpdUserId; //修改用户Id
objvCaseExerciseRelaENT.Memo = objvCaseExerciseRelaENS.Memo; //备注
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
 /// <param name = "objvCaseExerciseRelaENS">源对象</param>
 /// <returns>目标对象=>clsvCaseExerciseRelaEN:objvCaseExerciseRelaENT</returns>
 public static clsvCaseExerciseRelaEN CopyTo(this clsvCaseExerciseRelaEN objvCaseExerciseRelaENS)
{
try
{
 clsvCaseExerciseRelaEN objvCaseExerciseRelaENT = new clsvCaseExerciseRelaEN()
{
IdCaseExerciseRela = objvCaseExerciseRelaENS.IdCaseExerciseRela, //案例习题关系流水号
FuncModuleId = objvCaseExerciseRelaENS.FuncModuleId, //功能模块Id
FuncModuleName = objvCaseExerciseRelaENS.FuncModuleName, //功能模块名称
CaseId = objvCaseExerciseRelaENS.CaseId, //案例Id
CaseName = objvCaseExerciseRelaENS.CaseName, //案例名称
OwnerId = objvCaseExerciseRelaENS.OwnerId, //拥有者Id
OwnerName = objvCaseExerciseRelaENS.OwnerName, //拥有者姓名
CourseExamPaperId = objvCaseExerciseRelaENS.CourseExamPaperId, //考卷流水号
ExamPaperName = objvCaseExerciseRelaENS.ExamPaperName, //考卷名称
CourseId = objvCaseExerciseRelaENS.CourseId, //课程Id
CourseName = objvCaseExerciseRelaENS.CourseName, //课程名称
ExamPaperTypeId = objvCaseExerciseRelaENS.ExamPaperTypeId, //试卷类型Id
ExamPaperTypeName = objvCaseExerciseRelaENS.ExamPaperTypeName, //试卷类型名称
BrowseCount = objvCaseExerciseRelaENS.BrowseCount, //浏览次数
UpdDate = objvCaseExerciseRelaENS.UpdDate, //修改日期
UpdUserId = objvCaseExerciseRelaENS.UpdUserId, //修改用户Id
Memo = objvCaseExerciseRelaENS.Memo, //备注
};
 return objvCaseExerciseRelaENT;
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
public static void CheckProperty4Condition(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN)
{
 clsvCaseExerciseRelaBL.vCaseExerciseRelaDA.CheckProperty4Condition(objvCaseExerciseRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCaseExerciseRelaEN objvCaseExerciseRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCaseExerciseRelaCond.IsUpdated(convCaseExerciseRela.IdCaseExerciseRela) == true)
{
string strComparisonOpIdCaseExerciseRela = objvCaseExerciseRelaCond.dicFldComparisonOp[convCaseExerciseRela.IdCaseExerciseRela];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseExerciseRela.IdCaseExerciseRela, objvCaseExerciseRelaCond.IdCaseExerciseRela, strComparisonOpIdCaseExerciseRela);
}
if (objvCaseExerciseRelaCond.IsUpdated(convCaseExerciseRela.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvCaseExerciseRelaCond.dicFldComparisonOp[convCaseExerciseRela.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.FuncModuleId, objvCaseExerciseRelaCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvCaseExerciseRelaCond.IsUpdated(convCaseExerciseRela.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvCaseExerciseRelaCond.dicFldComparisonOp[convCaseExerciseRela.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.FuncModuleName, objvCaseExerciseRelaCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvCaseExerciseRelaCond.IsUpdated(convCaseExerciseRela.CaseId) == true)
{
string strComparisonOpCaseId = objvCaseExerciseRelaCond.dicFldComparisonOp[convCaseExerciseRela.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.CaseId, objvCaseExerciseRelaCond.CaseId, strComparisonOpCaseId);
}
if (objvCaseExerciseRelaCond.IsUpdated(convCaseExerciseRela.CaseName) == true)
{
string strComparisonOpCaseName = objvCaseExerciseRelaCond.dicFldComparisonOp[convCaseExerciseRela.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.CaseName, objvCaseExerciseRelaCond.CaseName, strComparisonOpCaseName);
}
if (objvCaseExerciseRelaCond.IsUpdated(convCaseExerciseRela.OwnerId) == true)
{
string strComparisonOpOwnerId = objvCaseExerciseRelaCond.dicFldComparisonOp[convCaseExerciseRela.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.OwnerId, objvCaseExerciseRelaCond.OwnerId, strComparisonOpOwnerId);
}
if (objvCaseExerciseRelaCond.IsUpdated(convCaseExerciseRela.OwnerName) == true)
{
string strComparisonOpOwnerName = objvCaseExerciseRelaCond.dicFldComparisonOp[convCaseExerciseRela.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.OwnerName, objvCaseExerciseRelaCond.OwnerName, strComparisonOpOwnerName);
}
if (objvCaseExerciseRelaCond.IsUpdated(convCaseExerciseRela.CourseExamPaperId) == true)
{
string strComparisonOpCourseExamPaperId = objvCaseExerciseRelaCond.dicFldComparisonOp[convCaseExerciseRela.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.CourseExamPaperId, objvCaseExerciseRelaCond.CourseExamPaperId, strComparisonOpCourseExamPaperId);
}
if (objvCaseExerciseRelaCond.IsUpdated(convCaseExerciseRela.ExamPaperName) == true)
{
string strComparisonOpExamPaperName = objvCaseExerciseRelaCond.dicFldComparisonOp[convCaseExerciseRela.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.ExamPaperName, objvCaseExerciseRelaCond.ExamPaperName, strComparisonOpExamPaperName);
}
if (objvCaseExerciseRelaCond.IsUpdated(convCaseExerciseRela.CourseId) == true)
{
string strComparisonOpCourseId = objvCaseExerciseRelaCond.dicFldComparisonOp[convCaseExerciseRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.CourseId, objvCaseExerciseRelaCond.CourseId, strComparisonOpCourseId);
}
if (objvCaseExerciseRelaCond.IsUpdated(convCaseExerciseRela.CourseName) == true)
{
string strComparisonOpCourseName = objvCaseExerciseRelaCond.dicFldComparisonOp[convCaseExerciseRela.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.CourseName, objvCaseExerciseRelaCond.CourseName, strComparisonOpCourseName);
}
if (objvCaseExerciseRelaCond.IsUpdated(convCaseExerciseRela.ExamPaperTypeId) == true)
{
string strComparisonOpExamPaperTypeId = objvCaseExerciseRelaCond.dicFldComparisonOp[convCaseExerciseRela.ExamPaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.ExamPaperTypeId, objvCaseExerciseRelaCond.ExamPaperTypeId, strComparisonOpExamPaperTypeId);
}
if (objvCaseExerciseRelaCond.IsUpdated(convCaseExerciseRela.ExamPaperTypeName) == true)
{
string strComparisonOpExamPaperTypeName = objvCaseExerciseRelaCond.dicFldComparisonOp[convCaseExerciseRela.ExamPaperTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.ExamPaperTypeName, objvCaseExerciseRelaCond.ExamPaperTypeName, strComparisonOpExamPaperTypeName);
}
if (objvCaseExerciseRelaCond.IsUpdated(convCaseExerciseRela.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvCaseExerciseRelaCond.dicFldComparisonOp[convCaseExerciseRela.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseExerciseRela.BrowseCount, objvCaseExerciseRelaCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvCaseExerciseRelaCond.IsUpdated(convCaseExerciseRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCaseExerciseRelaCond.dicFldComparisonOp[convCaseExerciseRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.UpdDate, objvCaseExerciseRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCaseExerciseRelaCond.IsUpdated(convCaseExerciseRela.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvCaseExerciseRelaCond.dicFldComparisonOp[convCaseExerciseRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.UpdUserId, objvCaseExerciseRelaCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvCaseExerciseRelaCond.IsUpdated(convCaseExerciseRela.Memo) == true)
{
string strComparisonOpMemo = objvCaseExerciseRelaCond.dicFldComparisonOp[convCaseExerciseRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.Memo, objvCaseExerciseRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCaseExerciseRela
{
public virtual bool UpdRelaTabDate(long lngIdCaseExerciseRela, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v案例习题关系(vCaseExerciseRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCaseExerciseRelaBL
{
public static RelatedActions_vCaseExerciseRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCaseExerciseRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCaseExerciseRelaDA vCaseExerciseRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCaseExerciseRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCaseExerciseRelaBL()
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
if (string.IsNullOrEmpty(clsvCaseExerciseRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCaseExerciseRelaEN._ConnectString);
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
public static DataTable GetDataTable_vCaseExerciseRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCaseExerciseRelaDA.GetDataTable_vCaseExerciseRela(strWhereCond);
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
objDT = vCaseExerciseRelaDA.GetDataTable(strWhereCond);
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
objDT = vCaseExerciseRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCaseExerciseRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCaseExerciseRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCaseExerciseRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vCaseExerciseRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCaseExerciseRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCaseExerciseRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdCaseExerciseRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCaseExerciseRelaEN> GetObjLstByIdCaseExerciseRelaLst(List<long> arrIdCaseExerciseRelaLst)
{
List<clsvCaseExerciseRelaEN> arrObjLst = new List<clsvCaseExerciseRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdCaseExerciseRelaLst);
 string strWhereCond = string.Format("IdCaseExerciseRela in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = new clsvCaseExerciseRelaEN();
try
{
objvCaseExerciseRelaEN.IdCaseExerciseRela = Int32.Parse(objRow[convCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objvCaseExerciseRelaEN.FuncModuleId = objRow[convCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseExerciseRelaEN.FuncModuleName = objRow[convCaseExerciseRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseExerciseRelaEN.CaseId = objRow[convCaseExerciseRela.CaseId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objvCaseExerciseRelaEN.CaseName = objRow[convCaseExerciseRela.CaseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objvCaseExerciseRelaEN.OwnerId = objRow[convCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseExerciseRelaEN.OwnerName = objRow[convCaseExerciseRela.OwnerName] == DBNull.Value ? null : objRow[convCaseExerciseRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseExerciseRelaEN.CourseExamPaperId = objRow[convCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvCaseExerciseRelaEN.ExamPaperName = objRow[convCaseExerciseRela.ExamPaperName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperName].ToString().Trim(); //考卷名称
objvCaseExerciseRelaEN.CourseId = objRow[convCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objvCaseExerciseRelaEN.CourseName = objRow[convCaseExerciseRela.CourseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseName].ToString().Trim(); //课程名称
objvCaseExerciseRelaEN.ExamPaperTypeId = objRow[convCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvCaseExerciseRelaEN.ExamPaperTypeName = objRow[convCaseExerciseRela.ExamPaperTypeName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvCaseExerciseRelaEN.BrowseCount = objRow[convCaseExerciseRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseExerciseRelaEN.UpdDate = objRow[convCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objvCaseExerciseRelaEN.UpdUserId = objRow[convCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseExerciseRelaEN.Memo = objRow[convCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[convCaseExerciseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseExerciseRelaEN.IdCaseExerciseRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseExerciseRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCaseExerciseRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCaseExerciseRelaEN> GetObjLstByIdCaseExerciseRelaLstCache(List<long> arrIdCaseExerciseRelaLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvCaseExerciseRelaEN._CurrTabName, strCourseId);
List<clsvCaseExerciseRelaEN> arrvCaseExerciseRelaObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvCaseExerciseRelaEN> arrvCaseExerciseRelaObjLst_Sel =
arrvCaseExerciseRelaObjLstCache
.Where(x => arrIdCaseExerciseRelaLst.Contains(x.IdCaseExerciseRela));
return arrvCaseExerciseRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseExerciseRelaEN> GetObjLst(string strWhereCond)
{
List<clsvCaseExerciseRelaEN> arrObjLst = new List<clsvCaseExerciseRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = new clsvCaseExerciseRelaEN();
try
{
objvCaseExerciseRelaEN.IdCaseExerciseRela = Int32.Parse(objRow[convCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objvCaseExerciseRelaEN.FuncModuleId = objRow[convCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseExerciseRelaEN.FuncModuleName = objRow[convCaseExerciseRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseExerciseRelaEN.CaseId = objRow[convCaseExerciseRela.CaseId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objvCaseExerciseRelaEN.CaseName = objRow[convCaseExerciseRela.CaseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objvCaseExerciseRelaEN.OwnerId = objRow[convCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseExerciseRelaEN.OwnerName = objRow[convCaseExerciseRela.OwnerName] == DBNull.Value ? null : objRow[convCaseExerciseRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseExerciseRelaEN.CourseExamPaperId = objRow[convCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvCaseExerciseRelaEN.ExamPaperName = objRow[convCaseExerciseRela.ExamPaperName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperName].ToString().Trim(); //考卷名称
objvCaseExerciseRelaEN.CourseId = objRow[convCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objvCaseExerciseRelaEN.CourseName = objRow[convCaseExerciseRela.CourseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseName].ToString().Trim(); //课程名称
objvCaseExerciseRelaEN.ExamPaperTypeId = objRow[convCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvCaseExerciseRelaEN.ExamPaperTypeName = objRow[convCaseExerciseRela.ExamPaperTypeName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvCaseExerciseRelaEN.BrowseCount = objRow[convCaseExerciseRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseExerciseRelaEN.UpdDate = objRow[convCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objvCaseExerciseRelaEN.UpdUserId = objRow[convCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseExerciseRelaEN.Memo = objRow[convCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[convCaseExerciseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseExerciseRelaEN.IdCaseExerciseRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseExerciseRelaEN);
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
public static List<clsvCaseExerciseRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCaseExerciseRelaEN> arrObjLst = new List<clsvCaseExerciseRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = new clsvCaseExerciseRelaEN();
try
{
objvCaseExerciseRelaEN.IdCaseExerciseRela = Int32.Parse(objRow[convCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objvCaseExerciseRelaEN.FuncModuleId = objRow[convCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseExerciseRelaEN.FuncModuleName = objRow[convCaseExerciseRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseExerciseRelaEN.CaseId = objRow[convCaseExerciseRela.CaseId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objvCaseExerciseRelaEN.CaseName = objRow[convCaseExerciseRela.CaseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objvCaseExerciseRelaEN.OwnerId = objRow[convCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseExerciseRelaEN.OwnerName = objRow[convCaseExerciseRela.OwnerName] == DBNull.Value ? null : objRow[convCaseExerciseRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseExerciseRelaEN.CourseExamPaperId = objRow[convCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvCaseExerciseRelaEN.ExamPaperName = objRow[convCaseExerciseRela.ExamPaperName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperName].ToString().Trim(); //考卷名称
objvCaseExerciseRelaEN.CourseId = objRow[convCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objvCaseExerciseRelaEN.CourseName = objRow[convCaseExerciseRela.CourseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseName].ToString().Trim(); //课程名称
objvCaseExerciseRelaEN.ExamPaperTypeId = objRow[convCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvCaseExerciseRelaEN.ExamPaperTypeName = objRow[convCaseExerciseRela.ExamPaperTypeName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvCaseExerciseRelaEN.BrowseCount = objRow[convCaseExerciseRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseExerciseRelaEN.UpdDate = objRow[convCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objvCaseExerciseRelaEN.UpdUserId = objRow[convCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseExerciseRelaEN.Memo = objRow[convCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[convCaseExerciseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseExerciseRelaEN.IdCaseExerciseRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseExerciseRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCaseExerciseRelaEN> GetSubObjLstCache(clsvCaseExerciseRelaEN objvCaseExerciseRelaCond)
{
 string strCourseId = objvCaseExerciseRelaCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvCaseExerciseRelaBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvCaseExerciseRelaEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvCaseExerciseRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCaseExerciseRela.AttributeName)
{
if (objvCaseExerciseRelaCond.IsUpdated(strFldName) == false) continue;
if (objvCaseExerciseRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseExerciseRelaCond[strFldName].ToString());
}
else
{
if (objvCaseExerciseRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCaseExerciseRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseExerciseRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCaseExerciseRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCaseExerciseRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCaseExerciseRelaCond[strFldName]));
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
public static List<clsvCaseExerciseRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCaseExerciseRelaEN> arrObjLst = new List<clsvCaseExerciseRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = new clsvCaseExerciseRelaEN();
try
{
objvCaseExerciseRelaEN.IdCaseExerciseRela = Int32.Parse(objRow[convCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objvCaseExerciseRelaEN.FuncModuleId = objRow[convCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseExerciseRelaEN.FuncModuleName = objRow[convCaseExerciseRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseExerciseRelaEN.CaseId = objRow[convCaseExerciseRela.CaseId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objvCaseExerciseRelaEN.CaseName = objRow[convCaseExerciseRela.CaseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objvCaseExerciseRelaEN.OwnerId = objRow[convCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseExerciseRelaEN.OwnerName = objRow[convCaseExerciseRela.OwnerName] == DBNull.Value ? null : objRow[convCaseExerciseRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseExerciseRelaEN.CourseExamPaperId = objRow[convCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvCaseExerciseRelaEN.ExamPaperName = objRow[convCaseExerciseRela.ExamPaperName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperName].ToString().Trim(); //考卷名称
objvCaseExerciseRelaEN.CourseId = objRow[convCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objvCaseExerciseRelaEN.CourseName = objRow[convCaseExerciseRela.CourseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseName].ToString().Trim(); //课程名称
objvCaseExerciseRelaEN.ExamPaperTypeId = objRow[convCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvCaseExerciseRelaEN.ExamPaperTypeName = objRow[convCaseExerciseRela.ExamPaperTypeName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvCaseExerciseRelaEN.BrowseCount = objRow[convCaseExerciseRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseExerciseRelaEN.UpdDate = objRow[convCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objvCaseExerciseRelaEN.UpdUserId = objRow[convCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseExerciseRelaEN.Memo = objRow[convCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[convCaseExerciseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseExerciseRelaEN.IdCaseExerciseRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseExerciseRelaEN);
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
public static List<clsvCaseExerciseRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCaseExerciseRelaEN> arrObjLst = new List<clsvCaseExerciseRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = new clsvCaseExerciseRelaEN();
try
{
objvCaseExerciseRelaEN.IdCaseExerciseRela = Int32.Parse(objRow[convCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objvCaseExerciseRelaEN.FuncModuleId = objRow[convCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseExerciseRelaEN.FuncModuleName = objRow[convCaseExerciseRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseExerciseRelaEN.CaseId = objRow[convCaseExerciseRela.CaseId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objvCaseExerciseRelaEN.CaseName = objRow[convCaseExerciseRela.CaseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objvCaseExerciseRelaEN.OwnerId = objRow[convCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseExerciseRelaEN.OwnerName = objRow[convCaseExerciseRela.OwnerName] == DBNull.Value ? null : objRow[convCaseExerciseRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseExerciseRelaEN.CourseExamPaperId = objRow[convCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvCaseExerciseRelaEN.ExamPaperName = objRow[convCaseExerciseRela.ExamPaperName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperName].ToString().Trim(); //考卷名称
objvCaseExerciseRelaEN.CourseId = objRow[convCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objvCaseExerciseRelaEN.CourseName = objRow[convCaseExerciseRela.CourseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseName].ToString().Trim(); //课程名称
objvCaseExerciseRelaEN.ExamPaperTypeId = objRow[convCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvCaseExerciseRelaEN.ExamPaperTypeName = objRow[convCaseExerciseRela.ExamPaperTypeName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvCaseExerciseRelaEN.BrowseCount = objRow[convCaseExerciseRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseExerciseRelaEN.UpdDate = objRow[convCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objvCaseExerciseRelaEN.UpdUserId = objRow[convCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseExerciseRelaEN.Memo = objRow[convCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[convCaseExerciseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseExerciseRelaEN.IdCaseExerciseRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseExerciseRelaEN);
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
List<clsvCaseExerciseRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCaseExerciseRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseExerciseRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCaseExerciseRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCaseExerciseRelaEN> arrObjLst = new List<clsvCaseExerciseRelaEN>(); 
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
	clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = new clsvCaseExerciseRelaEN();
try
{
objvCaseExerciseRelaEN.IdCaseExerciseRela = Int32.Parse(objRow[convCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objvCaseExerciseRelaEN.FuncModuleId = objRow[convCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseExerciseRelaEN.FuncModuleName = objRow[convCaseExerciseRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseExerciseRelaEN.CaseId = objRow[convCaseExerciseRela.CaseId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objvCaseExerciseRelaEN.CaseName = objRow[convCaseExerciseRela.CaseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objvCaseExerciseRelaEN.OwnerId = objRow[convCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseExerciseRelaEN.OwnerName = objRow[convCaseExerciseRela.OwnerName] == DBNull.Value ? null : objRow[convCaseExerciseRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseExerciseRelaEN.CourseExamPaperId = objRow[convCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvCaseExerciseRelaEN.ExamPaperName = objRow[convCaseExerciseRela.ExamPaperName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperName].ToString().Trim(); //考卷名称
objvCaseExerciseRelaEN.CourseId = objRow[convCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objvCaseExerciseRelaEN.CourseName = objRow[convCaseExerciseRela.CourseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseName].ToString().Trim(); //课程名称
objvCaseExerciseRelaEN.ExamPaperTypeId = objRow[convCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvCaseExerciseRelaEN.ExamPaperTypeName = objRow[convCaseExerciseRela.ExamPaperTypeName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvCaseExerciseRelaEN.BrowseCount = objRow[convCaseExerciseRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseExerciseRelaEN.UpdDate = objRow[convCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objvCaseExerciseRelaEN.UpdUserId = objRow[convCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseExerciseRelaEN.Memo = objRow[convCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[convCaseExerciseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseExerciseRelaEN.IdCaseExerciseRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseExerciseRelaEN);
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
public static List<clsvCaseExerciseRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCaseExerciseRelaEN> arrObjLst = new List<clsvCaseExerciseRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = new clsvCaseExerciseRelaEN();
try
{
objvCaseExerciseRelaEN.IdCaseExerciseRela = Int32.Parse(objRow[convCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objvCaseExerciseRelaEN.FuncModuleId = objRow[convCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseExerciseRelaEN.FuncModuleName = objRow[convCaseExerciseRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseExerciseRelaEN.CaseId = objRow[convCaseExerciseRela.CaseId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objvCaseExerciseRelaEN.CaseName = objRow[convCaseExerciseRela.CaseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objvCaseExerciseRelaEN.OwnerId = objRow[convCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseExerciseRelaEN.OwnerName = objRow[convCaseExerciseRela.OwnerName] == DBNull.Value ? null : objRow[convCaseExerciseRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseExerciseRelaEN.CourseExamPaperId = objRow[convCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvCaseExerciseRelaEN.ExamPaperName = objRow[convCaseExerciseRela.ExamPaperName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperName].ToString().Trim(); //考卷名称
objvCaseExerciseRelaEN.CourseId = objRow[convCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objvCaseExerciseRelaEN.CourseName = objRow[convCaseExerciseRela.CourseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseName].ToString().Trim(); //课程名称
objvCaseExerciseRelaEN.ExamPaperTypeId = objRow[convCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvCaseExerciseRelaEN.ExamPaperTypeName = objRow[convCaseExerciseRela.ExamPaperTypeName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvCaseExerciseRelaEN.BrowseCount = objRow[convCaseExerciseRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseExerciseRelaEN.UpdDate = objRow[convCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objvCaseExerciseRelaEN.UpdUserId = objRow[convCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseExerciseRelaEN.Memo = objRow[convCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[convCaseExerciseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseExerciseRelaEN.IdCaseExerciseRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseExerciseRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCaseExerciseRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCaseExerciseRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCaseExerciseRelaEN> arrObjLst = new List<clsvCaseExerciseRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = new clsvCaseExerciseRelaEN();
try
{
objvCaseExerciseRelaEN.IdCaseExerciseRela = Int32.Parse(objRow[convCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objvCaseExerciseRelaEN.FuncModuleId = objRow[convCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseExerciseRelaEN.FuncModuleName = objRow[convCaseExerciseRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseExerciseRelaEN.CaseId = objRow[convCaseExerciseRela.CaseId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objvCaseExerciseRelaEN.CaseName = objRow[convCaseExerciseRela.CaseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objvCaseExerciseRelaEN.OwnerId = objRow[convCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseExerciseRelaEN.OwnerName = objRow[convCaseExerciseRela.OwnerName] == DBNull.Value ? null : objRow[convCaseExerciseRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseExerciseRelaEN.CourseExamPaperId = objRow[convCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvCaseExerciseRelaEN.ExamPaperName = objRow[convCaseExerciseRela.ExamPaperName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperName].ToString().Trim(); //考卷名称
objvCaseExerciseRelaEN.CourseId = objRow[convCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objvCaseExerciseRelaEN.CourseName = objRow[convCaseExerciseRela.CourseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseName].ToString().Trim(); //课程名称
objvCaseExerciseRelaEN.ExamPaperTypeId = objRow[convCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvCaseExerciseRelaEN.ExamPaperTypeName = objRow[convCaseExerciseRela.ExamPaperTypeName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvCaseExerciseRelaEN.BrowseCount = objRow[convCaseExerciseRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseExerciseRelaEN.UpdDate = objRow[convCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objvCaseExerciseRelaEN.UpdUserId = objRow[convCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseExerciseRelaEN.Memo = objRow[convCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[convCaseExerciseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseExerciseRelaEN.IdCaseExerciseRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseExerciseRelaEN);
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
public static List<clsvCaseExerciseRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCaseExerciseRelaEN> arrObjLst = new List<clsvCaseExerciseRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = new clsvCaseExerciseRelaEN();
try
{
objvCaseExerciseRelaEN.IdCaseExerciseRela = Int32.Parse(objRow[convCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objvCaseExerciseRelaEN.FuncModuleId = objRow[convCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseExerciseRelaEN.FuncModuleName = objRow[convCaseExerciseRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseExerciseRelaEN.CaseId = objRow[convCaseExerciseRela.CaseId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objvCaseExerciseRelaEN.CaseName = objRow[convCaseExerciseRela.CaseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objvCaseExerciseRelaEN.OwnerId = objRow[convCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseExerciseRelaEN.OwnerName = objRow[convCaseExerciseRela.OwnerName] == DBNull.Value ? null : objRow[convCaseExerciseRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseExerciseRelaEN.CourseExamPaperId = objRow[convCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvCaseExerciseRelaEN.ExamPaperName = objRow[convCaseExerciseRela.ExamPaperName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperName].ToString().Trim(); //考卷名称
objvCaseExerciseRelaEN.CourseId = objRow[convCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objvCaseExerciseRelaEN.CourseName = objRow[convCaseExerciseRela.CourseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseName].ToString().Trim(); //课程名称
objvCaseExerciseRelaEN.ExamPaperTypeId = objRow[convCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvCaseExerciseRelaEN.ExamPaperTypeName = objRow[convCaseExerciseRela.ExamPaperTypeName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvCaseExerciseRelaEN.BrowseCount = objRow[convCaseExerciseRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseExerciseRelaEN.UpdDate = objRow[convCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objvCaseExerciseRelaEN.UpdUserId = objRow[convCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseExerciseRelaEN.Memo = objRow[convCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[convCaseExerciseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseExerciseRelaEN.IdCaseExerciseRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseExerciseRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseExerciseRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCaseExerciseRelaEN> arrObjLst = new List<clsvCaseExerciseRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = new clsvCaseExerciseRelaEN();
try
{
objvCaseExerciseRelaEN.IdCaseExerciseRela = Int32.Parse(objRow[convCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objvCaseExerciseRelaEN.FuncModuleId = objRow[convCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseExerciseRelaEN.FuncModuleName = objRow[convCaseExerciseRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseExerciseRelaEN.CaseId = objRow[convCaseExerciseRela.CaseId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objvCaseExerciseRelaEN.CaseName = objRow[convCaseExerciseRela.CaseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objvCaseExerciseRelaEN.OwnerId = objRow[convCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseExerciseRelaEN.OwnerName = objRow[convCaseExerciseRela.OwnerName] == DBNull.Value ? null : objRow[convCaseExerciseRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseExerciseRelaEN.CourseExamPaperId = objRow[convCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvCaseExerciseRelaEN.ExamPaperName = objRow[convCaseExerciseRela.ExamPaperName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperName].ToString().Trim(); //考卷名称
objvCaseExerciseRelaEN.CourseId = objRow[convCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objvCaseExerciseRelaEN.CourseName = objRow[convCaseExerciseRela.CourseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseName].ToString().Trim(); //课程名称
objvCaseExerciseRelaEN.ExamPaperTypeId = objRow[convCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvCaseExerciseRelaEN.ExamPaperTypeName = objRow[convCaseExerciseRela.ExamPaperTypeName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvCaseExerciseRelaEN.BrowseCount = objRow[convCaseExerciseRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseExerciseRelaEN.UpdDate = objRow[convCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objvCaseExerciseRelaEN.UpdUserId = objRow[convCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseExerciseRelaEN.Memo = objRow[convCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[convCaseExerciseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseExerciseRelaEN.IdCaseExerciseRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseExerciseRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCaseExerciseRela(ref clsvCaseExerciseRelaEN objvCaseExerciseRelaEN)
{
bool bolResult = vCaseExerciseRelaDA.GetvCaseExerciseRela(ref objvCaseExerciseRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdCaseExerciseRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseExerciseRelaEN GetObjByIdCaseExerciseRela(long lngIdCaseExerciseRela)
{
clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = vCaseExerciseRelaDA.GetObjByIdCaseExerciseRela(lngIdCaseExerciseRela);
return objvCaseExerciseRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCaseExerciseRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = vCaseExerciseRelaDA.GetFirstObj(strWhereCond);
 return objvCaseExerciseRelaEN;
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
public static clsvCaseExerciseRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = vCaseExerciseRelaDA.GetObjByDataRow(objRow);
 return objvCaseExerciseRelaEN;
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
public static clsvCaseExerciseRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = vCaseExerciseRelaDA.GetObjByDataRow(objRow);
 return objvCaseExerciseRelaEN;
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
 /// <param name = "lngIdCaseExerciseRela">所给的关键字</param>
 /// <param name = "lstvCaseExerciseRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCaseExerciseRelaEN GetObjByIdCaseExerciseRelaFromList(long lngIdCaseExerciseRela, List<clsvCaseExerciseRelaEN> lstvCaseExerciseRelaObjLst)
{
foreach (clsvCaseExerciseRelaEN objvCaseExerciseRelaEN in lstvCaseExerciseRelaObjLst)
{
if (objvCaseExerciseRelaEN.IdCaseExerciseRela == lngIdCaseExerciseRela)
{
return objvCaseExerciseRelaEN;
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
 long lngIdCaseExerciseRela;
 try
 {
 lngIdCaseExerciseRela = new clsvCaseExerciseRelaDA().GetFirstID(strWhereCond);
 return lngIdCaseExerciseRela;
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
 arrList = vCaseExerciseRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vCaseExerciseRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdCaseExerciseRela">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdCaseExerciseRela)
{
//检测记录是否存在
bool bolIsExist = vCaseExerciseRelaDA.IsExist(lngIdCaseExerciseRela);
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
 bolIsExist = clsvCaseExerciseRelaDA.IsExistTable();
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
 bolIsExist = vCaseExerciseRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvCaseExerciseRelaENS">源对象</param>
 /// <param name = "objvCaseExerciseRelaENT">目标对象</param>
 public static void CopyTo(clsvCaseExerciseRelaEN objvCaseExerciseRelaENS, clsvCaseExerciseRelaEN objvCaseExerciseRelaENT)
{
try
{
objvCaseExerciseRelaENT.IdCaseExerciseRela = objvCaseExerciseRelaENS.IdCaseExerciseRela; //案例习题关系流水号
objvCaseExerciseRelaENT.FuncModuleId = objvCaseExerciseRelaENS.FuncModuleId; //功能模块Id
objvCaseExerciseRelaENT.FuncModuleName = objvCaseExerciseRelaENS.FuncModuleName; //功能模块名称
objvCaseExerciseRelaENT.CaseId = objvCaseExerciseRelaENS.CaseId; //案例Id
objvCaseExerciseRelaENT.CaseName = objvCaseExerciseRelaENS.CaseName; //案例名称
objvCaseExerciseRelaENT.OwnerId = objvCaseExerciseRelaENS.OwnerId; //拥有者Id
objvCaseExerciseRelaENT.OwnerName = objvCaseExerciseRelaENS.OwnerName; //拥有者姓名
objvCaseExerciseRelaENT.CourseExamPaperId = objvCaseExerciseRelaENS.CourseExamPaperId; //考卷流水号
objvCaseExerciseRelaENT.ExamPaperName = objvCaseExerciseRelaENS.ExamPaperName; //考卷名称
objvCaseExerciseRelaENT.CourseId = objvCaseExerciseRelaENS.CourseId; //课程Id
objvCaseExerciseRelaENT.CourseName = objvCaseExerciseRelaENS.CourseName; //课程名称
objvCaseExerciseRelaENT.ExamPaperTypeId = objvCaseExerciseRelaENS.ExamPaperTypeId; //试卷类型Id
objvCaseExerciseRelaENT.ExamPaperTypeName = objvCaseExerciseRelaENS.ExamPaperTypeName; //试卷类型名称
objvCaseExerciseRelaENT.BrowseCount = objvCaseExerciseRelaENS.BrowseCount; //浏览次数
objvCaseExerciseRelaENT.UpdDate = objvCaseExerciseRelaENS.UpdDate; //修改日期
objvCaseExerciseRelaENT.UpdUserId = objvCaseExerciseRelaENS.UpdUserId; //修改用户Id
objvCaseExerciseRelaENT.Memo = objvCaseExerciseRelaENS.Memo; //备注
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
 /// <param name = "objvCaseExerciseRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvCaseExerciseRelaEN objvCaseExerciseRelaEN)
{
try
{
objvCaseExerciseRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCaseExerciseRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCaseExerciseRela.IdCaseExerciseRela, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseExerciseRelaEN.IdCaseExerciseRela = objvCaseExerciseRelaEN.IdCaseExerciseRela; //案例习题关系流水号
}
if (arrFldSet.Contains(convCaseExerciseRela.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseExerciseRelaEN.FuncModuleId = objvCaseExerciseRelaEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convCaseExerciseRela.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseExerciseRelaEN.FuncModuleName = objvCaseExerciseRelaEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convCaseExerciseRela.CaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseExerciseRelaEN.CaseId = objvCaseExerciseRelaEN.CaseId == "[null]" ? null :  objvCaseExerciseRelaEN.CaseId; //案例Id
}
if (arrFldSet.Contains(convCaseExerciseRela.CaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseExerciseRelaEN.CaseName = objvCaseExerciseRelaEN.CaseName == "[null]" ? null :  objvCaseExerciseRelaEN.CaseName; //案例名称
}
if (arrFldSet.Contains(convCaseExerciseRela.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseExerciseRelaEN.OwnerId = objvCaseExerciseRelaEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convCaseExerciseRela.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseExerciseRelaEN.OwnerName = objvCaseExerciseRelaEN.OwnerName == "[null]" ? null :  objvCaseExerciseRelaEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convCaseExerciseRela.CourseExamPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseExerciseRelaEN.CourseExamPaperId = objvCaseExerciseRelaEN.CourseExamPaperId == "[null]" ? null :  objvCaseExerciseRelaEN.CourseExamPaperId; //考卷流水号
}
if (arrFldSet.Contains(convCaseExerciseRela.ExamPaperName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseExerciseRelaEN.ExamPaperName = objvCaseExerciseRelaEN.ExamPaperName == "[null]" ? null :  objvCaseExerciseRelaEN.ExamPaperName; //考卷名称
}
if (arrFldSet.Contains(convCaseExerciseRela.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseExerciseRelaEN.CourseId = objvCaseExerciseRelaEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convCaseExerciseRela.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseExerciseRelaEN.CourseName = objvCaseExerciseRelaEN.CourseName == "[null]" ? null :  objvCaseExerciseRelaEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convCaseExerciseRela.ExamPaperTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseExerciseRelaEN.ExamPaperTypeId = objvCaseExerciseRelaEN.ExamPaperTypeId; //试卷类型Id
}
if (arrFldSet.Contains(convCaseExerciseRela.ExamPaperTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseExerciseRelaEN.ExamPaperTypeName = objvCaseExerciseRelaEN.ExamPaperTypeName == "[null]" ? null :  objvCaseExerciseRelaEN.ExamPaperTypeName; //试卷类型名称
}
if (arrFldSet.Contains(convCaseExerciseRela.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseExerciseRelaEN.BrowseCount = objvCaseExerciseRelaEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convCaseExerciseRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseExerciseRelaEN.UpdDate = objvCaseExerciseRelaEN.UpdDate == "[null]" ? null :  objvCaseExerciseRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCaseExerciseRela.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseExerciseRelaEN.UpdUserId = objvCaseExerciseRelaEN.UpdUserId == "[null]" ? null :  objvCaseExerciseRelaEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convCaseExerciseRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseExerciseRelaEN.Memo = objvCaseExerciseRelaEN.Memo == "[null]" ? null :  objvCaseExerciseRelaEN.Memo; //备注
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
 /// <param name = "objvCaseExerciseRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCaseExerciseRelaEN objvCaseExerciseRelaEN)
{
try
{
if (objvCaseExerciseRelaEN.CaseId == "[null]") objvCaseExerciseRelaEN.CaseId = null; //案例Id
if (objvCaseExerciseRelaEN.CaseName == "[null]") objvCaseExerciseRelaEN.CaseName = null; //案例名称
if (objvCaseExerciseRelaEN.OwnerName == "[null]") objvCaseExerciseRelaEN.OwnerName = null; //拥有者姓名
if (objvCaseExerciseRelaEN.CourseExamPaperId == "[null]") objvCaseExerciseRelaEN.CourseExamPaperId = null; //考卷流水号
if (objvCaseExerciseRelaEN.ExamPaperName == "[null]") objvCaseExerciseRelaEN.ExamPaperName = null; //考卷名称
if (objvCaseExerciseRelaEN.CourseName == "[null]") objvCaseExerciseRelaEN.CourseName = null; //课程名称
if (objvCaseExerciseRelaEN.ExamPaperTypeName == "[null]") objvCaseExerciseRelaEN.ExamPaperTypeName = null; //试卷类型名称
if (objvCaseExerciseRelaEN.UpdDate == "[null]") objvCaseExerciseRelaEN.UpdDate = null; //修改日期
if (objvCaseExerciseRelaEN.UpdUserId == "[null]") objvCaseExerciseRelaEN.UpdUserId = null; //修改用户Id
if (objvCaseExerciseRelaEN.Memo == "[null]") objvCaseExerciseRelaEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvCaseExerciseRelaEN objvCaseExerciseRelaEN)
{
 vCaseExerciseRelaDA.CheckProperty4Condition(objvCaseExerciseRelaEN);
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
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamPaperTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamPaperTypeBL没有刷新缓存机制(clscc_ExamPaperTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseExerciseRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseExerciseRelaBL没有刷新缓存机制(clsCaseExerciseRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseExamPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperBL没有刷新缓存机制(clscc_CourseExamPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_PaperDispModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PaperDispModeBL没有刷新缓存机制(clscc_PaperDispModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterBL没有刷新缓存机制(clscc_CourseChapterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeBL没有刷新缓存机制(clscc_CourseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeBL没有刷新缓存机制(clscc_ExcellentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesBL没有刷新缓存机制(clscc_ThemesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdCaseExerciseRela");
//if (arrvCaseExerciseRelaObjLstCache == null)
//{
//arrvCaseExerciseRelaObjLstCache = vCaseExerciseRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdCaseExerciseRela">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCaseExerciseRelaEN GetObjByIdCaseExerciseRelaCache(long lngIdCaseExerciseRela, string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvCaseExerciseRelaEN._CurrTabName, strCourseId);
List<clsvCaseExerciseRelaEN> arrvCaseExerciseRelaObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvCaseExerciseRelaEN> arrvCaseExerciseRelaObjLst_Sel =
arrvCaseExerciseRelaObjLstCache
.Where(x=> x.IdCaseExerciseRela == lngIdCaseExerciseRela 
);
if (arrvCaseExerciseRelaObjLst_Sel.Count() == 0)
{
   clsvCaseExerciseRelaEN obj = clsvCaseExerciseRelaBL.GetObjByIdCaseExerciseRela(lngIdCaseExerciseRela);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngIdCaseExerciseRela, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvCaseExerciseRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCaseExerciseRelaEN> GetAllvCaseExerciseRelaObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvCaseExerciseRelaEN> arrvCaseExerciseRelaObjLstCache = GetObjLstCache(strCourseId); 
return arrvCaseExerciseRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCaseExerciseRelaEN> GetObjLstCache(string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvCaseExerciseRelaEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvCaseExerciseRelaEN> arrvCaseExerciseRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvCaseExerciseRelaObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvCaseExerciseRelaEN._CurrTabName, strCourseId);
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
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngIdCaseExerciseRela, string strCourseId)
{
if (strInFldName != convCaseExerciseRela.IdCaseExerciseRela)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCaseExerciseRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCaseExerciseRela.AttributeName));
throw new Exception(strMsg);
}
var objvCaseExerciseRela = clsvCaseExerciseRelaBL.GetObjByIdCaseExerciseRelaCache(lngIdCaseExerciseRela, strCourseId);
if (objvCaseExerciseRela == null) return "";
return objvCaseExerciseRela[strOutFldName].ToString();
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
int intRecCount = clsvCaseExerciseRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvCaseExerciseRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCaseExerciseRelaDA.GetRecCount();
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
int intRecCount = clsvCaseExerciseRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCaseExerciseRelaEN objvCaseExerciseRelaCond)
{
 string strCourseId = objvCaseExerciseRelaCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvCaseExerciseRelaBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvCaseExerciseRelaEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvCaseExerciseRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCaseExerciseRela.AttributeName)
{
if (objvCaseExerciseRelaCond.IsUpdated(strFldName) == false) continue;
if (objvCaseExerciseRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseExerciseRelaCond[strFldName].ToString());
}
else
{
if (objvCaseExerciseRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCaseExerciseRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseExerciseRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCaseExerciseRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCaseExerciseRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCaseExerciseRelaCond[strFldName]));
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
 List<string> arrList = clsvCaseExerciseRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCaseExerciseRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCaseExerciseRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}