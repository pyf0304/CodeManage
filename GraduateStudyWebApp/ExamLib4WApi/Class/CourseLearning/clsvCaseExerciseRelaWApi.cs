
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseExerciseRelaWApi
 表名:vCaseExerciseRela(01120436)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:29
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
public static class clsvCaseExerciseRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseExerciseRelaEN Setid_CaseExerciseRela(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, long lngid_CaseExerciseRela, string strComparisonOp="")
	{
objvCaseExerciseRelaEN.id_CaseExerciseRela = lngid_CaseExerciseRela; //案例习题关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(convCaseExerciseRela.id_CaseExerciseRela) == false)
{
objvCaseExerciseRelaEN.dicFldComparisonOp.Add(convCaseExerciseRela.id_CaseExerciseRela, strComparisonOp);
}
else
{
objvCaseExerciseRelaEN.dicFldComparisonOp[convCaseExerciseRela.id_CaseExerciseRela] = strComparisonOp;
}
}
return objvCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetFuncModuleId(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCaseExerciseRela.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCaseExerciseRela.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCaseExerciseRela.FuncModuleId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetFuncModuleName(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convCaseExerciseRela.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCaseExerciseRela.FuncModuleName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetCaseId(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strCaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseId, 8, convCaseExerciseRela.CaseId);
clsCheckSql.CheckFieldForeignKey(strCaseId, 8, convCaseExerciseRela.CaseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetCaseName(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseName, 100, convCaseExerciseRela.CaseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetOwnerId(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convCaseExerciseRela.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCaseExerciseRela.OwnerId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetOwnerName(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCaseExerciseRela.OwnerName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetCourseExamPaperId(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convCaseExerciseRela.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convCaseExerciseRela.CourseExamPaperId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetExamPaperName(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strExamPaperName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, convCaseExerciseRela.ExamPaperName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetCourseId(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convCaseExerciseRela.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, convCaseExerciseRela.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCaseExerciseRela.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetCourseName(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCaseExerciseRela.CourseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetExamPaperTypeId(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strExamPaperTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamPaperTypeId, convCaseExerciseRela.ExamPaperTypeId);
clsCheckSql.CheckFieldLen(strExamPaperTypeId, 2, convCaseExerciseRela.ExamPaperTypeId);
clsCheckSql.CheckFieldForeignKey(strExamPaperTypeId, 2, convCaseExerciseRela.ExamPaperTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetExamPaperTypeName(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strExamPaperTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperTypeName, 30, convCaseExerciseRela.ExamPaperTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetBrowseCount(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, int intBrowseCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetUpdDate(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCaseExerciseRela.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetUpdUserId(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convCaseExerciseRela.UpdUserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseExerciseRelaEN SetMemo(this clsvCaseExerciseRelaEN objvCaseExerciseRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCaseExerciseRela.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCaseExerciseRelaEN objvCaseExerciseRela_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCaseExerciseRela_Cond.IsUpdated(convCaseExerciseRela.id_CaseExerciseRela) == true)
{
string strComparisonOp_id_CaseExerciseRela = objvCaseExerciseRela_Cond.dicFldComparisonOp[convCaseExerciseRela.id_CaseExerciseRela];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseExerciseRela.id_CaseExerciseRela, objvCaseExerciseRela_Cond.id_CaseExerciseRela, strComparisonOp_id_CaseExerciseRela);
}
if (objvCaseExerciseRela_Cond.IsUpdated(convCaseExerciseRela.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvCaseExerciseRela_Cond.dicFldComparisonOp[convCaseExerciseRela.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.FuncModuleId, objvCaseExerciseRela_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvCaseExerciseRela_Cond.IsUpdated(convCaseExerciseRela.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvCaseExerciseRela_Cond.dicFldComparisonOp[convCaseExerciseRela.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.FuncModuleName, objvCaseExerciseRela_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvCaseExerciseRela_Cond.IsUpdated(convCaseExerciseRela.CaseId) == true)
{
string strComparisonOp_CaseId = objvCaseExerciseRela_Cond.dicFldComparisonOp[convCaseExerciseRela.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.CaseId, objvCaseExerciseRela_Cond.CaseId, strComparisonOp_CaseId);
}
if (objvCaseExerciseRela_Cond.IsUpdated(convCaseExerciseRela.CaseName) == true)
{
string strComparisonOp_CaseName = objvCaseExerciseRela_Cond.dicFldComparisonOp[convCaseExerciseRela.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.CaseName, objvCaseExerciseRela_Cond.CaseName, strComparisonOp_CaseName);
}
if (objvCaseExerciseRela_Cond.IsUpdated(convCaseExerciseRela.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvCaseExerciseRela_Cond.dicFldComparisonOp[convCaseExerciseRela.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.OwnerId, objvCaseExerciseRela_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvCaseExerciseRela_Cond.IsUpdated(convCaseExerciseRela.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvCaseExerciseRela_Cond.dicFldComparisonOp[convCaseExerciseRela.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.OwnerName, objvCaseExerciseRela_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvCaseExerciseRela_Cond.IsUpdated(convCaseExerciseRela.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objvCaseExerciseRela_Cond.dicFldComparisonOp[convCaseExerciseRela.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.CourseExamPaperId, objvCaseExerciseRela_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objvCaseExerciseRela_Cond.IsUpdated(convCaseExerciseRela.ExamPaperName) == true)
{
string strComparisonOp_ExamPaperName = objvCaseExerciseRela_Cond.dicFldComparisonOp[convCaseExerciseRela.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.ExamPaperName, objvCaseExerciseRela_Cond.ExamPaperName, strComparisonOp_ExamPaperName);
}
if (objvCaseExerciseRela_Cond.IsUpdated(convCaseExerciseRela.CourseId) == true)
{
string strComparisonOp_CourseId = objvCaseExerciseRela_Cond.dicFldComparisonOp[convCaseExerciseRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.CourseId, objvCaseExerciseRela_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCaseExerciseRela_Cond.IsUpdated(convCaseExerciseRela.CourseName) == true)
{
string strComparisonOp_CourseName = objvCaseExerciseRela_Cond.dicFldComparisonOp[convCaseExerciseRela.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.CourseName, objvCaseExerciseRela_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCaseExerciseRela_Cond.IsUpdated(convCaseExerciseRela.ExamPaperTypeId) == true)
{
string strComparisonOp_ExamPaperTypeId = objvCaseExerciseRela_Cond.dicFldComparisonOp[convCaseExerciseRela.ExamPaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.ExamPaperTypeId, objvCaseExerciseRela_Cond.ExamPaperTypeId, strComparisonOp_ExamPaperTypeId);
}
if (objvCaseExerciseRela_Cond.IsUpdated(convCaseExerciseRela.ExamPaperTypeName) == true)
{
string strComparisonOp_ExamPaperTypeName = objvCaseExerciseRela_Cond.dicFldComparisonOp[convCaseExerciseRela.ExamPaperTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.ExamPaperTypeName, objvCaseExerciseRela_Cond.ExamPaperTypeName, strComparisonOp_ExamPaperTypeName);
}
if (objvCaseExerciseRela_Cond.IsUpdated(convCaseExerciseRela.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvCaseExerciseRela_Cond.dicFldComparisonOp[convCaseExerciseRela.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseExerciseRela.BrowseCount, objvCaseExerciseRela_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvCaseExerciseRela_Cond.IsUpdated(convCaseExerciseRela.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvCaseExerciseRela_Cond.dicFldComparisonOp[convCaseExerciseRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.UpdDate, objvCaseExerciseRela_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvCaseExerciseRela_Cond.IsUpdated(convCaseExerciseRela.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvCaseExerciseRela_Cond.dicFldComparisonOp[convCaseExerciseRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.UpdUserId, objvCaseExerciseRela_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvCaseExerciseRela_Cond.IsUpdated(convCaseExerciseRela.Memo) == true)
{
string strComparisonOp_Memo = objvCaseExerciseRela_Cond.dicFldComparisonOp[convCaseExerciseRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseExerciseRela.Memo, objvCaseExerciseRela_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v案例习题关系(vCaseExerciseRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCaseExerciseRelaWApi
{
private static readonly string mstrApiControllerName = "vCaseExerciseRelaApi";

 public clsvCaseExerciseRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_CaseExerciseRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseExerciseRelaEN GetObjByid_CaseExerciseRela(long lngid_CaseExerciseRela)
{
string strAction = "GetObjByid_CaseExerciseRela";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseExerciseRela"] = lngid_CaseExerciseRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCaseExerciseRelaEN = JsonConvert.DeserializeObject<clsvCaseExerciseRelaEN>((string)jobjReturn["ReturnObj"]);
return objvCaseExerciseRelaEN;
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
 /// <param name = "lngid_CaseExerciseRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseExerciseRelaEN GetObjByid_CaseExerciseRela_WA_Cache(long lngid_CaseExerciseRela, string strCourseId)
{
string strAction = "GetObjByid_CaseExerciseRela_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseExerciseRela"] = lngid_CaseExerciseRela.ToString(),
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCaseExerciseRelaEN = JsonConvert.DeserializeObject<clsvCaseExerciseRelaEN>((string)jobjReturn["ReturnObj"]);
return objvCaseExerciseRelaEN;
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
public static clsvCaseExerciseRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = null;
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
objvCaseExerciseRelaEN = JsonConvert.DeserializeObject<clsvCaseExerciseRelaEN>((string)jobjReturn["ReturnObj"]);
return objvCaseExerciseRelaEN;
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
 /// <param name = "lngid_CaseExerciseRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCaseExerciseRelaEN GetObjByid_CaseExerciseRela_Cache(long lngid_CaseExerciseRela, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCaseExerciseRelaEN._CurrTabName_S, strCourseId);
List<clsvCaseExerciseRelaEN> arrvCaseExerciseRelaObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvCaseExerciseRelaEN> arrvCaseExerciseRelaObjLst_Sel =
from objvCaseExerciseRelaEN in arrvCaseExerciseRelaObjLst_Cache
where objvCaseExerciseRelaEN.id_CaseExerciseRela == lngid_CaseExerciseRela
select objvCaseExerciseRelaEN;
if (arrvCaseExerciseRelaObjLst_Sel.Count() == 0)
{
   clsvCaseExerciseRelaEN obj = clsvCaseExerciseRelaWApi.GetObjByid_CaseExerciseRela(lngid_CaseExerciseRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCaseExerciseRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseExerciseRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvCaseExerciseRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseExerciseRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseExerciseRelaEN> GetObjLstById_CaseExerciseRelaLst(List<long> arrId_CaseExerciseRela)
{
 List<clsvCaseExerciseRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_CaseExerciseRelaLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CaseExerciseRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseExerciseRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_CaseExerciseRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvCaseExerciseRelaEN> GetObjLstById_CaseExerciseRelaLst_Cache(List<long> arrId_CaseExerciseRela, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCaseExerciseRelaEN._CurrTabName_S, strCourseId);
List<clsvCaseExerciseRelaEN> arrvCaseExerciseRelaObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvCaseExerciseRelaEN> arrvCaseExerciseRelaObjLst_Sel =
from objvCaseExerciseRelaEN in arrvCaseExerciseRelaObjLst_Cache
where arrId_CaseExerciseRela.Contains(objvCaseExerciseRelaEN.id_CaseExerciseRela)
select objvCaseExerciseRelaEN;
return arrvCaseExerciseRelaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseExerciseRelaEN> GetObjLstById_CaseExerciseRelaLst_WA_Cache(List<long> arrId_CaseExerciseRela, string strCourseId)
{
 List<clsvCaseExerciseRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_CaseExerciseRelaLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CaseExerciseRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseExerciseRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseExerciseRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCaseExerciseRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseExerciseRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseExerciseRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCaseExerciseRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseExerciseRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseExerciseRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCaseExerciseRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseExerciseRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseExerciseRelaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCaseExerciseRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseExerciseRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_CaseExerciseRela)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseExerciseRela"] = lngid_CaseExerciseRela.ToString()
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
 /// <param name = "objvCaseExerciseRelaENS">源对象</param>
 /// <param name = "objvCaseExerciseRelaENT">目标对象</param>
 public static void CopyTo(clsvCaseExerciseRelaEN objvCaseExerciseRelaENS, clsvCaseExerciseRelaEN objvCaseExerciseRelaENT)
{
try
{
objvCaseExerciseRelaENT.id_CaseExerciseRela = objvCaseExerciseRelaENS.id_CaseExerciseRela; //案例习题关系流水号
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
public static DataTable ToDataTable(List<clsvCaseExerciseRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCaseExerciseRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCaseExerciseRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCaseExerciseRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCaseExerciseRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCaseExerciseRelaEN.AttributeName)
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
if (clscc_ExamPaperTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamPaperTypeWApi没有刷新缓存机制(clscc_ExamPaperTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseExerciseRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseExerciseRelaWApi没有刷新缓存机制(clsCaseExerciseRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseExamPaperWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperWApi没有刷新缓存机制(clscc_CourseExamPaperWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_PaperDispModeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PaperDispModeWApi没有刷新缓存机制(clscc_PaperDispModeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesWApi没有刷新缓存机制(clscc_ThemesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_CaseExerciseRela");
//if (arrvCaseExerciseRelaObjLst_Cache == null)
//{
//arrvCaseExerciseRelaObjLst_Cache = await clsvCaseExerciseRelaWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvCaseExerciseRelaEN._CurrTabName_S, strCourseId);
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
public static List<clsvCaseExerciseRelaEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvCaseExerciseRelaEN._CurrTabName_S, strCourseId);
List<clsvCaseExerciseRelaEN> arrvCaseExerciseRelaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvCaseExerciseRelaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCaseExerciseRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCaseExerciseRela.id_CaseExerciseRela, Type.GetType("System.Int64"));
objDT.Columns.Add(convCaseExerciseRela.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseExerciseRela.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseExerciseRela.CaseId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseExerciseRela.CaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseExerciseRela.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseExerciseRela.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseExerciseRela.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseExerciseRela.ExamPaperName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseExerciseRela.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseExerciseRela.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseExerciseRela.ExamPaperTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseExerciseRela.ExamPaperTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseExerciseRela.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCaseExerciseRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCaseExerciseRela.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseExerciseRela.Memo, Type.GetType("System.String"));
foreach (clsvCaseExerciseRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCaseExerciseRela.id_CaseExerciseRela] = objInFor[convCaseExerciseRela.id_CaseExerciseRela];
objDR[convCaseExerciseRela.FuncModuleId] = objInFor[convCaseExerciseRela.FuncModuleId];
objDR[convCaseExerciseRela.FuncModuleName] = objInFor[convCaseExerciseRela.FuncModuleName];
objDR[convCaseExerciseRela.CaseId] = objInFor[convCaseExerciseRela.CaseId];
objDR[convCaseExerciseRela.CaseName] = objInFor[convCaseExerciseRela.CaseName];
objDR[convCaseExerciseRela.OwnerId] = objInFor[convCaseExerciseRela.OwnerId];
objDR[convCaseExerciseRela.OwnerName] = objInFor[convCaseExerciseRela.OwnerName];
objDR[convCaseExerciseRela.CourseExamPaperId] = objInFor[convCaseExerciseRela.CourseExamPaperId];
objDR[convCaseExerciseRela.ExamPaperName] = objInFor[convCaseExerciseRela.ExamPaperName];
objDR[convCaseExerciseRela.CourseId] = objInFor[convCaseExerciseRela.CourseId];
objDR[convCaseExerciseRela.CourseName] = objInFor[convCaseExerciseRela.CourseName];
objDR[convCaseExerciseRela.ExamPaperTypeId] = objInFor[convCaseExerciseRela.ExamPaperTypeId];
objDR[convCaseExerciseRela.ExamPaperTypeName] = objInFor[convCaseExerciseRela.ExamPaperTypeName];
objDR[convCaseExerciseRela.BrowseCount] = objInFor[convCaseExerciseRela.BrowseCount];
objDR[convCaseExerciseRela.UpdDate] = objInFor[convCaseExerciseRela.UpdDate];
objDR[convCaseExerciseRela.UpdUserId] = objInFor[convCaseExerciseRela.UpdUserId];
objDR[convCaseExerciseRela.Memo] = objInFor[convCaseExerciseRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}