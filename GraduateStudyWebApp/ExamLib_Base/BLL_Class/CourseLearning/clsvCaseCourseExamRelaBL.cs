
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseCourseExamRelaBL
 表名:vCaseCourseExamRela(01120391)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:37
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
public static class  clsvCaseCourseExamRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdCaseCourseExamRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseCourseExamRelaEN GetObj(this K_IdCaseCourseExamRela_vCaseCourseExamRela myKey)
{
clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = clsvCaseCourseExamRelaBL.vCaseCourseExamRelaDA.GetObjByIdCaseCourseExamRela(myKey.Value);
return objvCaseCourseExamRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetIdCaseCourseExamRela(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, long lngIdCaseCourseExamRela, string strComparisonOp="")
	{
objvCaseCourseExamRelaEN.IdCaseCourseExamRela = lngIdCaseCourseExamRela; //案例题库关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.IdCaseCourseExamRela) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.IdCaseCourseExamRela, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.IdCaseCourseExamRela] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetFuncModuleId(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCaseCourseExamRela.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCaseCourseExamRela.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCaseCourseExamRela.FuncModuleId);
}
objvCaseCourseExamRelaEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.FuncModuleId) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.FuncModuleId, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.FuncModuleId] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetFuncModuleName(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convCaseCourseExamRela.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCaseCourseExamRela.FuncModuleName);
}
objvCaseCourseExamRelaEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.FuncModuleName) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.FuncModuleName, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.FuncModuleName] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetCaseId(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strCaseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseId, 8, convCaseCourseExamRela.CaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseId, 8, convCaseCourseExamRela.CaseId);
}
objvCaseCourseExamRelaEN.CaseId = strCaseId; //案例Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.CaseId) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.CaseId, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.CaseId] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetCaseName(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strCaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseName, 100, convCaseCourseExamRela.CaseName);
}
objvCaseCourseExamRelaEN.CaseName = strCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.CaseName) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.CaseName, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.CaseName] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetOwnerId(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convCaseCourseExamRela.OwnerId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCaseCourseExamRela.OwnerId);
}
objvCaseCourseExamRelaEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.OwnerId) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.OwnerId, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.OwnerId] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetOwnerName(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCaseCourseExamRela.OwnerName);
}
objvCaseCourseExamRelaEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.OwnerName) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.OwnerName, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.OwnerName] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetQuestionID(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strQuestionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convCaseCourseExamRela.QuestionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convCaseCourseExamRela.QuestionID);
}
objvCaseCourseExamRelaEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.QuestionID) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.QuestionID, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.QuestionID] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetExamAnswer(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strExamAnswer, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamAnswer, 8000, convCaseCourseExamRela.ExamAnswer);
}
objvCaseCourseExamRelaEN.ExamAnswer = strExamAnswer; //题目答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.ExamAnswer) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.ExamAnswer, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.ExamAnswer] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetStartTime(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, double? dblStartTime, string strComparisonOp="")
	{
objvCaseCourseExamRelaEN.StartTime = dblStartTime; //开始时间(s)
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.StartTime) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.StartTime, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.StartTime] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetParentNodeID(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strParentNodeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convCaseCourseExamRela.ParentNodeID);
}
objvCaseCourseExamRelaEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.ParentNodeID) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.ParentNodeID, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.ParentNodeID] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetParentNodeName(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strParentNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convCaseCourseExamRela.ParentNodeName);
}
objvCaseCourseExamRelaEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.ParentNodeName) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.ParentNodeName, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.ParentNodeName] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetCourseId(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCaseCourseExamRela.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCaseCourseExamRela.CourseId);
}
objvCaseCourseExamRelaEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.CourseId) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.CourseId, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.CourseId] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetCourseName(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCaseCourseExamRela.CourseName);
}
objvCaseCourseExamRelaEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.CourseName) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.CourseName, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.CourseName] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetIdCaseCourseExamRelaType(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strIdCaseCourseExamRelaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCaseCourseExamRelaType, convCaseCourseExamRela.IdCaseCourseExamRelaType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseCourseExamRelaType, 4, convCaseCourseExamRela.IdCaseCourseExamRelaType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseCourseExamRelaType, 4, convCaseCourseExamRela.IdCaseCourseExamRelaType);
}
objvCaseCourseExamRelaEN.IdCaseCourseExamRelaType = strIdCaseCourseExamRelaType; //案例题库关系类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.IdCaseCourseExamRelaType) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.IdCaseCourseExamRelaType, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.IdCaseCourseExamRelaType] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetCaseCourseExamRelaTypeName(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strCaseCourseExamRelaTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseCourseExamRelaTypeName, convCaseCourseExamRela.CaseCourseExamRelaTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseCourseExamRelaTypeName, 50, convCaseCourseExamRela.CaseCourseExamRelaTypeName);
}
objvCaseCourseExamRelaEN.CaseCourseExamRelaTypeName = strCaseCourseExamRelaTypeName; //案例题库关系类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.CaseCourseExamRelaTypeName) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.CaseCourseExamRelaTypeName, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.CaseCourseExamRelaTypeName] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetBrowseCount(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, int? intBrowseCount, string strComparisonOp="")
	{
objvCaseCourseExamRelaEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.BrowseCount) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.BrowseCount, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.BrowseCount] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetOrderNum(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, int? intOrderNum, string strComparisonOp="")
	{
objvCaseCourseExamRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.OrderNum) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.OrderNum, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.OrderNum] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetUpdDate(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCaseCourseExamRela.UpdDate);
}
objvCaseCourseExamRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.UpdDate) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.UpdDate, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.UpdDate] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetUpdUserId(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convCaseCourseExamRela.UpdUserId);
}
objvCaseCourseExamRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.UpdUserId) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.UpdUserId, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.UpdUserId] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetMemo(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCaseCourseExamRela.Memo);
}
objvCaseCourseExamRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.Memo) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.Memo, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.Memo] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetQuestionContent(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strQuestionContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, convCaseCourseExamRela.QuestionContent);
}
objvCaseCourseExamRelaEN.QuestionContent = strQuestionContent; //题目内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.QuestionContent) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.QuestionContent, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.QuestionContent] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetQuestionName(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strQuestionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionName, 500, convCaseCourseExamRela.QuestionName);
}
objvCaseCourseExamRelaEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.QuestionName) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.QuestionName, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.QuestionName] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetQuestionNo(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strQuestionNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, convCaseCourseExamRela.QuestionNo);
}
objvCaseCourseExamRelaEN.QuestionNo = strQuestionNo; //题目编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.QuestionNo) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.QuestionNo, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.QuestionNo] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaENS">源对象</param>
 /// <param name = "objvCaseCourseExamRelaENT">目标对象</param>
 public static void CopyTo(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaENS, clsvCaseCourseExamRelaEN objvCaseCourseExamRelaENT)
{
try
{
objvCaseCourseExamRelaENT.IdCaseCourseExamRela = objvCaseCourseExamRelaENS.IdCaseCourseExamRela; //案例题库关系流水号
objvCaseCourseExamRelaENT.FuncModuleId = objvCaseCourseExamRelaENS.FuncModuleId; //功能模块Id
objvCaseCourseExamRelaENT.FuncModuleName = objvCaseCourseExamRelaENS.FuncModuleName; //功能模块名称
objvCaseCourseExamRelaENT.CaseId = objvCaseCourseExamRelaENS.CaseId; //案例Id
objvCaseCourseExamRelaENT.CaseName = objvCaseCourseExamRelaENS.CaseName; //案例名称
objvCaseCourseExamRelaENT.OwnerId = objvCaseCourseExamRelaENS.OwnerId; //拥有者Id
objvCaseCourseExamRelaENT.OwnerName = objvCaseCourseExamRelaENS.OwnerName; //拥有者姓名
objvCaseCourseExamRelaENT.QuestionID = objvCaseCourseExamRelaENS.QuestionID; //题目ID
objvCaseCourseExamRelaENT.ExamAnswer = objvCaseCourseExamRelaENS.ExamAnswer; //题目答案
objvCaseCourseExamRelaENT.StartTime = objvCaseCourseExamRelaENS.StartTime; //开始时间(s)
objvCaseCourseExamRelaENT.ParentNodeID = objvCaseCourseExamRelaENS.ParentNodeID; //父节点编号
objvCaseCourseExamRelaENT.ParentNodeName = objvCaseCourseExamRelaENS.ParentNodeName; //父节点名称
objvCaseCourseExamRelaENT.CourseId = objvCaseCourseExamRelaENS.CourseId; //课程Id
objvCaseCourseExamRelaENT.CourseName = objvCaseCourseExamRelaENS.CourseName; //课程名称
objvCaseCourseExamRelaENT.IdCaseCourseExamRelaType = objvCaseCourseExamRelaENS.IdCaseCourseExamRelaType; //案例题库关系类型流水号
objvCaseCourseExamRelaENT.CaseCourseExamRelaTypeName = objvCaseCourseExamRelaENS.CaseCourseExamRelaTypeName; //案例题库关系类型名称
objvCaseCourseExamRelaENT.BrowseCount = objvCaseCourseExamRelaENS.BrowseCount; //浏览次数
objvCaseCourseExamRelaENT.OrderNum = objvCaseCourseExamRelaENS.OrderNum; //序号
objvCaseCourseExamRelaENT.UpdDate = objvCaseCourseExamRelaENS.UpdDate; //修改日期
objvCaseCourseExamRelaENT.UpdUserId = objvCaseCourseExamRelaENS.UpdUserId; //修改用户Id
objvCaseCourseExamRelaENT.Memo = objvCaseCourseExamRelaENS.Memo; //备注
objvCaseCourseExamRelaENT.QuestionContent = objvCaseCourseExamRelaENS.QuestionContent; //题目内容
objvCaseCourseExamRelaENT.QuestionName = objvCaseCourseExamRelaENS.QuestionName; //题目名称
objvCaseCourseExamRelaENT.QuestionNo = objvCaseCourseExamRelaENS.QuestionNo; //题目编号
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
 /// <param name = "objvCaseCourseExamRelaENS">源对象</param>
 /// <returns>目标对象=>clsvCaseCourseExamRelaEN:objvCaseCourseExamRelaENT</returns>
 public static clsvCaseCourseExamRelaEN CopyTo(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaENS)
{
try
{
 clsvCaseCourseExamRelaEN objvCaseCourseExamRelaENT = new clsvCaseCourseExamRelaEN()
{
IdCaseCourseExamRela = objvCaseCourseExamRelaENS.IdCaseCourseExamRela, //案例题库关系流水号
FuncModuleId = objvCaseCourseExamRelaENS.FuncModuleId, //功能模块Id
FuncModuleName = objvCaseCourseExamRelaENS.FuncModuleName, //功能模块名称
CaseId = objvCaseCourseExamRelaENS.CaseId, //案例Id
CaseName = objvCaseCourseExamRelaENS.CaseName, //案例名称
OwnerId = objvCaseCourseExamRelaENS.OwnerId, //拥有者Id
OwnerName = objvCaseCourseExamRelaENS.OwnerName, //拥有者姓名
QuestionID = objvCaseCourseExamRelaENS.QuestionID, //题目ID
ExamAnswer = objvCaseCourseExamRelaENS.ExamAnswer, //题目答案
StartTime = objvCaseCourseExamRelaENS.StartTime, //开始时间(s)
ParentNodeID = objvCaseCourseExamRelaENS.ParentNodeID, //父节点编号
ParentNodeName = objvCaseCourseExamRelaENS.ParentNodeName, //父节点名称
CourseId = objvCaseCourseExamRelaENS.CourseId, //课程Id
CourseName = objvCaseCourseExamRelaENS.CourseName, //课程名称
IdCaseCourseExamRelaType = objvCaseCourseExamRelaENS.IdCaseCourseExamRelaType, //案例题库关系类型流水号
CaseCourseExamRelaTypeName = objvCaseCourseExamRelaENS.CaseCourseExamRelaTypeName, //案例题库关系类型名称
BrowseCount = objvCaseCourseExamRelaENS.BrowseCount, //浏览次数
OrderNum = objvCaseCourseExamRelaENS.OrderNum, //序号
UpdDate = objvCaseCourseExamRelaENS.UpdDate, //修改日期
UpdUserId = objvCaseCourseExamRelaENS.UpdUserId, //修改用户Id
Memo = objvCaseCourseExamRelaENS.Memo, //备注
QuestionContent = objvCaseCourseExamRelaENS.QuestionContent, //题目内容
QuestionName = objvCaseCourseExamRelaENS.QuestionName, //题目名称
QuestionNo = objvCaseCourseExamRelaENS.QuestionNo, //题目编号
};
 return objvCaseCourseExamRelaENT;
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
public static void CheckProperty4Condition(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN)
{
 clsvCaseCourseExamRelaBL.vCaseCourseExamRelaDA.CheckProperty4Condition(objvCaseCourseExamRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.IdCaseCourseExamRela) == true)
{
string strComparisonOpIdCaseCourseExamRela = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.IdCaseCourseExamRela];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCourseExamRela.IdCaseCourseExamRela, objvCaseCourseExamRelaCond.IdCaseCourseExamRela, strComparisonOpIdCaseCourseExamRela);
}
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.FuncModuleId, objvCaseCourseExamRelaCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.FuncModuleName, objvCaseCourseExamRelaCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.CaseId) == true)
{
string strComparisonOpCaseId = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.CaseId, objvCaseCourseExamRelaCond.CaseId, strComparisonOpCaseId);
}
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.CaseName) == true)
{
string strComparisonOpCaseName = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.CaseName, objvCaseCourseExamRelaCond.CaseName, strComparisonOpCaseName);
}
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.OwnerId) == true)
{
string strComparisonOpOwnerId = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.OwnerId, objvCaseCourseExamRelaCond.OwnerId, strComparisonOpOwnerId);
}
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.OwnerName) == true)
{
string strComparisonOpOwnerName = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.OwnerName, objvCaseCourseExamRelaCond.OwnerName, strComparisonOpOwnerName);
}
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.QuestionID) == true)
{
string strComparisonOpQuestionID = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.QuestionID, objvCaseCourseExamRelaCond.QuestionID, strComparisonOpQuestionID);
}
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.ExamAnswer) == true)
{
string strComparisonOpExamAnswer = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.ExamAnswer];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.ExamAnswer, objvCaseCourseExamRelaCond.ExamAnswer, strComparisonOpExamAnswer);
}
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.StartTime) == true)
{
string strComparisonOpStartTime = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.StartTime];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCourseExamRela.StartTime, objvCaseCourseExamRelaCond.StartTime, strComparisonOpStartTime);
}
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.ParentNodeID) == true)
{
string strComparisonOpParentNodeID = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.ParentNodeID, objvCaseCourseExamRelaCond.ParentNodeID, strComparisonOpParentNodeID);
}
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.ParentNodeName) == true)
{
string strComparisonOpParentNodeName = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.ParentNodeName, objvCaseCourseExamRelaCond.ParentNodeName, strComparisonOpParentNodeName);
}
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.CourseId) == true)
{
string strComparisonOpCourseId = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.CourseId, objvCaseCourseExamRelaCond.CourseId, strComparisonOpCourseId);
}
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.CourseName) == true)
{
string strComparisonOpCourseName = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.CourseName, objvCaseCourseExamRelaCond.CourseName, strComparisonOpCourseName);
}
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.IdCaseCourseExamRelaType) == true)
{
string strComparisonOpIdCaseCourseExamRelaType = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.IdCaseCourseExamRelaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.IdCaseCourseExamRelaType, objvCaseCourseExamRelaCond.IdCaseCourseExamRelaType, strComparisonOpIdCaseCourseExamRelaType);
}
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.CaseCourseExamRelaTypeName) == true)
{
string strComparisonOpCaseCourseExamRelaTypeName = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.CaseCourseExamRelaTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.CaseCourseExamRelaTypeName, objvCaseCourseExamRelaCond.CaseCourseExamRelaTypeName, strComparisonOpCaseCourseExamRelaTypeName);
}
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCourseExamRela.BrowseCount, objvCaseCourseExamRelaCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCourseExamRela.OrderNum, objvCaseCourseExamRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.UpdDate, objvCaseCourseExamRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.UpdUserId, objvCaseCourseExamRelaCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.Memo) == true)
{
string strComparisonOpMemo = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.Memo, objvCaseCourseExamRelaCond.Memo, strComparisonOpMemo);
}
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.QuestionContent) == true)
{
string strComparisonOpQuestionContent = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.QuestionContent, objvCaseCourseExamRelaCond.QuestionContent, strComparisonOpQuestionContent);
}
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.QuestionName) == true)
{
string strComparisonOpQuestionName = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.QuestionName, objvCaseCourseExamRelaCond.QuestionName, strComparisonOpQuestionName);
}
if (objvCaseCourseExamRelaCond.IsUpdated(convCaseCourseExamRela.QuestionNo) == true)
{
string strComparisonOpQuestionNo = objvCaseCourseExamRelaCond.dicFldComparisonOp[convCaseCourseExamRela.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.QuestionNo, objvCaseCourseExamRelaCond.QuestionNo, strComparisonOpQuestionNo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCaseCourseExamRela
{
public virtual bool UpdRelaTabDate(long lngIdCaseCourseExamRela, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v案例题库关系(vCaseCourseExamRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCaseCourseExamRelaBL
{
public static RelatedActions_vCaseCourseExamRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCaseCourseExamRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCaseCourseExamRelaDA vCaseCourseExamRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCaseCourseExamRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCaseCourseExamRelaBL()
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
if (string.IsNullOrEmpty(clsvCaseCourseExamRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCaseCourseExamRelaEN._ConnectString);
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
public static DataTable GetDataTable_vCaseCourseExamRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCaseCourseExamRelaDA.GetDataTable_vCaseCourseExamRela(strWhereCond);
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
objDT = vCaseCourseExamRelaDA.GetDataTable(strWhereCond);
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
objDT = vCaseCourseExamRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCaseCourseExamRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCaseCourseExamRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCaseCourseExamRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vCaseCourseExamRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCaseCourseExamRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCaseCourseExamRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdCaseCourseExamRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCaseCourseExamRelaEN> GetObjLstByIdCaseCourseExamRelaLst(List<long> arrIdCaseCourseExamRelaLst)
{
List<clsvCaseCourseExamRelaEN> arrObjLst = new List<clsvCaseCourseExamRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdCaseCourseExamRelaLst);
 string strWhereCond = string.Format("IdCaseCourseExamRela in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = new clsvCaseCourseExamRelaEN();
try
{
objvCaseCourseExamRelaEN.IdCaseCourseExamRela = Int32.Parse(objRow[convCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objvCaseCourseExamRelaEN.FuncModuleId = objRow[convCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseExamRelaEN.FuncModuleName = objRow[convCaseCourseExamRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseExamRelaEN.CaseId = objRow[convCaseCourseExamRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseExamRelaEN.CaseName = objRow[convCaseCourseExamRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseExamRelaEN.OwnerId = objRow[convCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseExamRelaEN.OwnerName = objRow[convCaseCourseExamRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseExamRelaEN.QuestionID = objRow[convCaseCourseExamRela.QuestionID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionID].ToString().Trim(); //题目ID
objvCaseCourseExamRelaEN.ExamAnswer = objRow[convCaseCourseExamRela.ExamAnswer] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ExamAnswer].ToString().Trim(); //题目答案
objvCaseCourseExamRelaEN.StartTime = objRow[convCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objvCaseCourseExamRelaEN.ParentNodeID = objRow[convCaseCourseExamRela.ParentNodeID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeID].ToString().Trim(); //父节点编号
objvCaseCourseExamRelaEN.ParentNodeName = objRow[convCaseCourseExamRela.ParentNodeName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeName].ToString().Trim(); //父节点名称
objvCaseCourseExamRelaEN.CourseId = objRow[convCaseCourseExamRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseExamRelaEN.CourseName = objRow[convCaseCourseExamRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[convCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objvCaseCourseExamRelaEN.CaseCourseExamRelaTypeName = objRow[convCaseCourseExamRela.CaseCourseExamRelaTypeName].ToString().Trim(); //案例题库关系类型名称
objvCaseCourseExamRelaEN.BrowseCount = objRow[convCaseCourseExamRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseExamRelaEN.OrderNum = objRow[convCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseExamRelaEN.UpdDate = objRow[convCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseExamRelaEN.UpdUserId = objRow[convCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseExamRelaEN.Memo = objRow[convCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.Memo].ToString().Trim(); //备注
objvCaseCourseExamRelaEN.QuestionContent = objRow[convCaseCourseExamRela.QuestionContent] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionContent].ToString().Trim(); //题目内容
objvCaseCourseExamRelaEN.QuestionName = objRow[convCaseCourseExamRela.QuestionName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionName].ToString().Trim(); //题目名称
objvCaseCourseExamRelaEN.QuestionNo = objRow[convCaseCourseExamRela.QuestionNo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionNo].ToString().Trim(); //题目编号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCourseExamRelaEN.IdCaseCourseExamRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCourseExamRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCaseCourseExamRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCaseCourseExamRelaEN> GetObjLstByIdCaseCourseExamRelaLstCache(List<long> arrIdCaseCourseExamRelaLst)
{
string strKey = string.Format("{0}", clsvCaseCourseExamRelaEN._CurrTabName);
List<clsvCaseCourseExamRelaEN> arrvCaseCourseExamRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvCaseCourseExamRelaEN> arrvCaseCourseExamRelaObjLst_Sel =
arrvCaseCourseExamRelaObjLstCache
.Where(x => arrIdCaseCourseExamRelaLst.Contains(x.IdCaseCourseExamRela));
return arrvCaseCourseExamRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseCourseExamRelaEN> GetObjLst(string strWhereCond)
{
List<clsvCaseCourseExamRelaEN> arrObjLst = new List<clsvCaseCourseExamRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = new clsvCaseCourseExamRelaEN();
try
{
objvCaseCourseExamRelaEN.IdCaseCourseExamRela = Int32.Parse(objRow[convCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objvCaseCourseExamRelaEN.FuncModuleId = objRow[convCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseExamRelaEN.FuncModuleName = objRow[convCaseCourseExamRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseExamRelaEN.CaseId = objRow[convCaseCourseExamRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseExamRelaEN.CaseName = objRow[convCaseCourseExamRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseExamRelaEN.OwnerId = objRow[convCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseExamRelaEN.OwnerName = objRow[convCaseCourseExamRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseExamRelaEN.QuestionID = objRow[convCaseCourseExamRela.QuestionID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionID].ToString().Trim(); //题目ID
objvCaseCourseExamRelaEN.ExamAnswer = objRow[convCaseCourseExamRela.ExamAnswer] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ExamAnswer].ToString().Trim(); //题目答案
objvCaseCourseExamRelaEN.StartTime = objRow[convCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objvCaseCourseExamRelaEN.ParentNodeID = objRow[convCaseCourseExamRela.ParentNodeID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeID].ToString().Trim(); //父节点编号
objvCaseCourseExamRelaEN.ParentNodeName = objRow[convCaseCourseExamRela.ParentNodeName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeName].ToString().Trim(); //父节点名称
objvCaseCourseExamRelaEN.CourseId = objRow[convCaseCourseExamRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseExamRelaEN.CourseName = objRow[convCaseCourseExamRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[convCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objvCaseCourseExamRelaEN.CaseCourseExamRelaTypeName = objRow[convCaseCourseExamRela.CaseCourseExamRelaTypeName].ToString().Trim(); //案例题库关系类型名称
objvCaseCourseExamRelaEN.BrowseCount = objRow[convCaseCourseExamRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseExamRelaEN.OrderNum = objRow[convCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseExamRelaEN.UpdDate = objRow[convCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseExamRelaEN.UpdUserId = objRow[convCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseExamRelaEN.Memo = objRow[convCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.Memo].ToString().Trim(); //备注
objvCaseCourseExamRelaEN.QuestionContent = objRow[convCaseCourseExamRela.QuestionContent] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionContent].ToString().Trim(); //题目内容
objvCaseCourseExamRelaEN.QuestionName = objRow[convCaseCourseExamRela.QuestionName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionName].ToString().Trim(); //题目名称
objvCaseCourseExamRelaEN.QuestionNo = objRow[convCaseCourseExamRela.QuestionNo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionNo].ToString().Trim(); //题目编号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCourseExamRelaEN.IdCaseCourseExamRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCourseExamRelaEN);
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
public static List<clsvCaseCourseExamRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCaseCourseExamRelaEN> arrObjLst = new List<clsvCaseCourseExamRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = new clsvCaseCourseExamRelaEN();
try
{
objvCaseCourseExamRelaEN.IdCaseCourseExamRela = Int32.Parse(objRow[convCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objvCaseCourseExamRelaEN.FuncModuleId = objRow[convCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseExamRelaEN.FuncModuleName = objRow[convCaseCourseExamRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseExamRelaEN.CaseId = objRow[convCaseCourseExamRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseExamRelaEN.CaseName = objRow[convCaseCourseExamRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseExamRelaEN.OwnerId = objRow[convCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseExamRelaEN.OwnerName = objRow[convCaseCourseExamRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseExamRelaEN.QuestionID = objRow[convCaseCourseExamRela.QuestionID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionID].ToString().Trim(); //题目ID
objvCaseCourseExamRelaEN.ExamAnswer = objRow[convCaseCourseExamRela.ExamAnswer] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ExamAnswer].ToString().Trim(); //题目答案
objvCaseCourseExamRelaEN.StartTime = objRow[convCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objvCaseCourseExamRelaEN.ParentNodeID = objRow[convCaseCourseExamRela.ParentNodeID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeID].ToString().Trim(); //父节点编号
objvCaseCourseExamRelaEN.ParentNodeName = objRow[convCaseCourseExamRela.ParentNodeName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeName].ToString().Trim(); //父节点名称
objvCaseCourseExamRelaEN.CourseId = objRow[convCaseCourseExamRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseExamRelaEN.CourseName = objRow[convCaseCourseExamRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[convCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objvCaseCourseExamRelaEN.CaseCourseExamRelaTypeName = objRow[convCaseCourseExamRela.CaseCourseExamRelaTypeName].ToString().Trim(); //案例题库关系类型名称
objvCaseCourseExamRelaEN.BrowseCount = objRow[convCaseCourseExamRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseExamRelaEN.OrderNum = objRow[convCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseExamRelaEN.UpdDate = objRow[convCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseExamRelaEN.UpdUserId = objRow[convCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseExamRelaEN.Memo = objRow[convCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.Memo].ToString().Trim(); //备注
objvCaseCourseExamRelaEN.QuestionContent = objRow[convCaseCourseExamRela.QuestionContent] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionContent].ToString().Trim(); //题目内容
objvCaseCourseExamRelaEN.QuestionName = objRow[convCaseCourseExamRela.QuestionName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionName].ToString().Trim(); //题目名称
objvCaseCourseExamRelaEN.QuestionNo = objRow[convCaseCourseExamRela.QuestionNo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionNo].ToString().Trim(); //题目编号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCourseExamRelaEN.IdCaseCourseExamRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCourseExamRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCaseCourseExamRelaEN> GetSubObjLstCache(clsvCaseCourseExamRelaEN objvCaseCourseExamRelaCond)
{
List<clsvCaseCourseExamRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCaseCourseExamRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCaseCourseExamRela.AttributeName)
{
if (objvCaseCourseExamRelaCond.IsUpdated(strFldName) == false) continue;
if (objvCaseCourseExamRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseCourseExamRelaCond[strFldName].ToString());
}
else
{
if (objvCaseCourseExamRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCaseCourseExamRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseCourseExamRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCaseCourseExamRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCaseCourseExamRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCaseCourseExamRelaCond[strFldName]));
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
public static List<clsvCaseCourseExamRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCaseCourseExamRelaEN> arrObjLst = new List<clsvCaseCourseExamRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = new clsvCaseCourseExamRelaEN();
try
{
objvCaseCourseExamRelaEN.IdCaseCourseExamRela = Int32.Parse(objRow[convCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objvCaseCourseExamRelaEN.FuncModuleId = objRow[convCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseExamRelaEN.FuncModuleName = objRow[convCaseCourseExamRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseExamRelaEN.CaseId = objRow[convCaseCourseExamRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseExamRelaEN.CaseName = objRow[convCaseCourseExamRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseExamRelaEN.OwnerId = objRow[convCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseExamRelaEN.OwnerName = objRow[convCaseCourseExamRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseExamRelaEN.QuestionID = objRow[convCaseCourseExamRela.QuestionID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionID].ToString().Trim(); //题目ID
objvCaseCourseExamRelaEN.ExamAnswer = objRow[convCaseCourseExamRela.ExamAnswer] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ExamAnswer].ToString().Trim(); //题目答案
objvCaseCourseExamRelaEN.StartTime = objRow[convCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objvCaseCourseExamRelaEN.ParentNodeID = objRow[convCaseCourseExamRela.ParentNodeID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeID].ToString().Trim(); //父节点编号
objvCaseCourseExamRelaEN.ParentNodeName = objRow[convCaseCourseExamRela.ParentNodeName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeName].ToString().Trim(); //父节点名称
objvCaseCourseExamRelaEN.CourseId = objRow[convCaseCourseExamRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseExamRelaEN.CourseName = objRow[convCaseCourseExamRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[convCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objvCaseCourseExamRelaEN.CaseCourseExamRelaTypeName = objRow[convCaseCourseExamRela.CaseCourseExamRelaTypeName].ToString().Trim(); //案例题库关系类型名称
objvCaseCourseExamRelaEN.BrowseCount = objRow[convCaseCourseExamRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseExamRelaEN.OrderNum = objRow[convCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseExamRelaEN.UpdDate = objRow[convCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseExamRelaEN.UpdUserId = objRow[convCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseExamRelaEN.Memo = objRow[convCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.Memo].ToString().Trim(); //备注
objvCaseCourseExamRelaEN.QuestionContent = objRow[convCaseCourseExamRela.QuestionContent] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionContent].ToString().Trim(); //题目内容
objvCaseCourseExamRelaEN.QuestionName = objRow[convCaseCourseExamRela.QuestionName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionName].ToString().Trim(); //题目名称
objvCaseCourseExamRelaEN.QuestionNo = objRow[convCaseCourseExamRela.QuestionNo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionNo].ToString().Trim(); //题目编号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCourseExamRelaEN.IdCaseCourseExamRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCourseExamRelaEN);
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
public static List<clsvCaseCourseExamRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCaseCourseExamRelaEN> arrObjLst = new List<clsvCaseCourseExamRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = new clsvCaseCourseExamRelaEN();
try
{
objvCaseCourseExamRelaEN.IdCaseCourseExamRela = Int32.Parse(objRow[convCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objvCaseCourseExamRelaEN.FuncModuleId = objRow[convCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseExamRelaEN.FuncModuleName = objRow[convCaseCourseExamRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseExamRelaEN.CaseId = objRow[convCaseCourseExamRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseExamRelaEN.CaseName = objRow[convCaseCourseExamRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseExamRelaEN.OwnerId = objRow[convCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseExamRelaEN.OwnerName = objRow[convCaseCourseExamRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseExamRelaEN.QuestionID = objRow[convCaseCourseExamRela.QuestionID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionID].ToString().Trim(); //题目ID
objvCaseCourseExamRelaEN.ExamAnswer = objRow[convCaseCourseExamRela.ExamAnswer] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ExamAnswer].ToString().Trim(); //题目答案
objvCaseCourseExamRelaEN.StartTime = objRow[convCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objvCaseCourseExamRelaEN.ParentNodeID = objRow[convCaseCourseExamRela.ParentNodeID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeID].ToString().Trim(); //父节点编号
objvCaseCourseExamRelaEN.ParentNodeName = objRow[convCaseCourseExamRela.ParentNodeName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeName].ToString().Trim(); //父节点名称
objvCaseCourseExamRelaEN.CourseId = objRow[convCaseCourseExamRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseExamRelaEN.CourseName = objRow[convCaseCourseExamRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[convCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objvCaseCourseExamRelaEN.CaseCourseExamRelaTypeName = objRow[convCaseCourseExamRela.CaseCourseExamRelaTypeName].ToString().Trim(); //案例题库关系类型名称
objvCaseCourseExamRelaEN.BrowseCount = objRow[convCaseCourseExamRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseExamRelaEN.OrderNum = objRow[convCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseExamRelaEN.UpdDate = objRow[convCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseExamRelaEN.UpdUserId = objRow[convCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseExamRelaEN.Memo = objRow[convCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.Memo].ToString().Trim(); //备注
objvCaseCourseExamRelaEN.QuestionContent = objRow[convCaseCourseExamRela.QuestionContent] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionContent].ToString().Trim(); //题目内容
objvCaseCourseExamRelaEN.QuestionName = objRow[convCaseCourseExamRela.QuestionName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionName].ToString().Trim(); //题目名称
objvCaseCourseExamRelaEN.QuestionNo = objRow[convCaseCourseExamRela.QuestionNo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionNo].ToString().Trim(); //题目编号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCourseExamRelaEN.IdCaseCourseExamRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCourseExamRelaEN);
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
List<clsvCaseCourseExamRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCaseCourseExamRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseCourseExamRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCaseCourseExamRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCaseCourseExamRelaEN> arrObjLst = new List<clsvCaseCourseExamRelaEN>(); 
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
	clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = new clsvCaseCourseExamRelaEN();
try
{
objvCaseCourseExamRelaEN.IdCaseCourseExamRela = Int32.Parse(objRow[convCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objvCaseCourseExamRelaEN.FuncModuleId = objRow[convCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseExamRelaEN.FuncModuleName = objRow[convCaseCourseExamRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseExamRelaEN.CaseId = objRow[convCaseCourseExamRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseExamRelaEN.CaseName = objRow[convCaseCourseExamRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseExamRelaEN.OwnerId = objRow[convCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseExamRelaEN.OwnerName = objRow[convCaseCourseExamRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseExamRelaEN.QuestionID = objRow[convCaseCourseExamRela.QuestionID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionID].ToString().Trim(); //题目ID
objvCaseCourseExamRelaEN.ExamAnswer = objRow[convCaseCourseExamRela.ExamAnswer] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ExamAnswer].ToString().Trim(); //题目答案
objvCaseCourseExamRelaEN.StartTime = objRow[convCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objvCaseCourseExamRelaEN.ParentNodeID = objRow[convCaseCourseExamRela.ParentNodeID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeID].ToString().Trim(); //父节点编号
objvCaseCourseExamRelaEN.ParentNodeName = objRow[convCaseCourseExamRela.ParentNodeName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeName].ToString().Trim(); //父节点名称
objvCaseCourseExamRelaEN.CourseId = objRow[convCaseCourseExamRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseExamRelaEN.CourseName = objRow[convCaseCourseExamRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[convCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objvCaseCourseExamRelaEN.CaseCourseExamRelaTypeName = objRow[convCaseCourseExamRela.CaseCourseExamRelaTypeName].ToString().Trim(); //案例题库关系类型名称
objvCaseCourseExamRelaEN.BrowseCount = objRow[convCaseCourseExamRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseExamRelaEN.OrderNum = objRow[convCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseExamRelaEN.UpdDate = objRow[convCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseExamRelaEN.UpdUserId = objRow[convCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseExamRelaEN.Memo = objRow[convCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.Memo].ToString().Trim(); //备注
objvCaseCourseExamRelaEN.QuestionContent = objRow[convCaseCourseExamRela.QuestionContent] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionContent].ToString().Trim(); //题目内容
objvCaseCourseExamRelaEN.QuestionName = objRow[convCaseCourseExamRela.QuestionName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionName].ToString().Trim(); //题目名称
objvCaseCourseExamRelaEN.QuestionNo = objRow[convCaseCourseExamRela.QuestionNo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionNo].ToString().Trim(); //题目编号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCourseExamRelaEN.IdCaseCourseExamRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCourseExamRelaEN);
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
public static List<clsvCaseCourseExamRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCaseCourseExamRelaEN> arrObjLst = new List<clsvCaseCourseExamRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = new clsvCaseCourseExamRelaEN();
try
{
objvCaseCourseExamRelaEN.IdCaseCourseExamRela = Int32.Parse(objRow[convCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objvCaseCourseExamRelaEN.FuncModuleId = objRow[convCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseExamRelaEN.FuncModuleName = objRow[convCaseCourseExamRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseExamRelaEN.CaseId = objRow[convCaseCourseExamRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseExamRelaEN.CaseName = objRow[convCaseCourseExamRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseExamRelaEN.OwnerId = objRow[convCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseExamRelaEN.OwnerName = objRow[convCaseCourseExamRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseExamRelaEN.QuestionID = objRow[convCaseCourseExamRela.QuestionID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionID].ToString().Trim(); //题目ID
objvCaseCourseExamRelaEN.ExamAnswer = objRow[convCaseCourseExamRela.ExamAnswer] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ExamAnswer].ToString().Trim(); //题目答案
objvCaseCourseExamRelaEN.StartTime = objRow[convCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objvCaseCourseExamRelaEN.ParentNodeID = objRow[convCaseCourseExamRela.ParentNodeID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeID].ToString().Trim(); //父节点编号
objvCaseCourseExamRelaEN.ParentNodeName = objRow[convCaseCourseExamRela.ParentNodeName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeName].ToString().Trim(); //父节点名称
objvCaseCourseExamRelaEN.CourseId = objRow[convCaseCourseExamRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseExamRelaEN.CourseName = objRow[convCaseCourseExamRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[convCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objvCaseCourseExamRelaEN.CaseCourseExamRelaTypeName = objRow[convCaseCourseExamRela.CaseCourseExamRelaTypeName].ToString().Trim(); //案例题库关系类型名称
objvCaseCourseExamRelaEN.BrowseCount = objRow[convCaseCourseExamRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseExamRelaEN.OrderNum = objRow[convCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseExamRelaEN.UpdDate = objRow[convCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseExamRelaEN.UpdUserId = objRow[convCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseExamRelaEN.Memo = objRow[convCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.Memo].ToString().Trim(); //备注
objvCaseCourseExamRelaEN.QuestionContent = objRow[convCaseCourseExamRela.QuestionContent] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionContent].ToString().Trim(); //题目内容
objvCaseCourseExamRelaEN.QuestionName = objRow[convCaseCourseExamRela.QuestionName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionName].ToString().Trim(); //题目名称
objvCaseCourseExamRelaEN.QuestionNo = objRow[convCaseCourseExamRela.QuestionNo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionNo].ToString().Trim(); //题目编号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCourseExamRelaEN.IdCaseCourseExamRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCourseExamRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCaseCourseExamRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCaseCourseExamRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCaseCourseExamRelaEN> arrObjLst = new List<clsvCaseCourseExamRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = new clsvCaseCourseExamRelaEN();
try
{
objvCaseCourseExamRelaEN.IdCaseCourseExamRela = Int32.Parse(objRow[convCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objvCaseCourseExamRelaEN.FuncModuleId = objRow[convCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseExamRelaEN.FuncModuleName = objRow[convCaseCourseExamRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseExamRelaEN.CaseId = objRow[convCaseCourseExamRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseExamRelaEN.CaseName = objRow[convCaseCourseExamRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseExamRelaEN.OwnerId = objRow[convCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseExamRelaEN.OwnerName = objRow[convCaseCourseExamRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseExamRelaEN.QuestionID = objRow[convCaseCourseExamRela.QuestionID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionID].ToString().Trim(); //题目ID
objvCaseCourseExamRelaEN.ExamAnswer = objRow[convCaseCourseExamRela.ExamAnswer] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ExamAnswer].ToString().Trim(); //题目答案
objvCaseCourseExamRelaEN.StartTime = objRow[convCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objvCaseCourseExamRelaEN.ParentNodeID = objRow[convCaseCourseExamRela.ParentNodeID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeID].ToString().Trim(); //父节点编号
objvCaseCourseExamRelaEN.ParentNodeName = objRow[convCaseCourseExamRela.ParentNodeName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeName].ToString().Trim(); //父节点名称
objvCaseCourseExamRelaEN.CourseId = objRow[convCaseCourseExamRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseExamRelaEN.CourseName = objRow[convCaseCourseExamRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[convCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objvCaseCourseExamRelaEN.CaseCourseExamRelaTypeName = objRow[convCaseCourseExamRela.CaseCourseExamRelaTypeName].ToString().Trim(); //案例题库关系类型名称
objvCaseCourseExamRelaEN.BrowseCount = objRow[convCaseCourseExamRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseExamRelaEN.OrderNum = objRow[convCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseExamRelaEN.UpdDate = objRow[convCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseExamRelaEN.UpdUserId = objRow[convCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseExamRelaEN.Memo = objRow[convCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.Memo].ToString().Trim(); //备注
objvCaseCourseExamRelaEN.QuestionContent = objRow[convCaseCourseExamRela.QuestionContent] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionContent].ToString().Trim(); //题目内容
objvCaseCourseExamRelaEN.QuestionName = objRow[convCaseCourseExamRela.QuestionName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionName].ToString().Trim(); //题目名称
objvCaseCourseExamRelaEN.QuestionNo = objRow[convCaseCourseExamRela.QuestionNo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionNo].ToString().Trim(); //题目编号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCourseExamRelaEN.IdCaseCourseExamRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCourseExamRelaEN);
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
public static List<clsvCaseCourseExamRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCaseCourseExamRelaEN> arrObjLst = new List<clsvCaseCourseExamRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = new clsvCaseCourseExamRelaEN();
try
{
objvCaseCourseExamRelaEN.IdCaseCourseExamRela = Int32.Parse(objRow[convCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objvCaseCourseExamRelaEN.FuncModuleId = objRow[convCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseExamRelaEN.FuncModuleName = objRow[convCaseCourseExamRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseExamRelaEN.CaseId = objRow[convCaseCourseExamRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseExamRelaEN.CaseName = objRow[convCaseCourseExamRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseExamRelaEN.OwnerId = objRow[convCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseExamRelaEN.OwnerName = objRow[convCaseCourseExamRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseExamRelaEN.QuestionID = objRow[convCaseCourseExamRela.QuestionID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionID].ToString().Trim(); //题目ID
objvCaseCourseExamRelaEN.ExamAnswer = objRow[convCaseCourseExamRela.ExamAnswer] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ExamAnswer].ToString().Trim(); //题目答案
objvCaseCourseExamRelaEN.StartTime = objRow[convCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objvCaseCourseExamRelaEN.ParentNodeID = objRow[convCaseCourseExamRela.ParentNodeID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeID].ToString().Trim(); //父节点编号
objvCaseCourseExamRelaEN.ParentNodeName = objRow[convCaseCourseExamRela.ParentNodeName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeName].ToString().Trim(); //父节点名称
objvCaseCourseExamRelaEN.CourseId = objRow[convCaseCourseExamRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseExamRelaEN.CourseName = objRow[convCaseCourseExamRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[convCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objvCaseCourseExamRelaEN.CaseCourseExamRelaTypeName = objRow[convCaseCourseExamRela.CaseCourseExamRelaTypeName].ToString().Trim(); //案例题库关系类型名称
objvCaseCourseExamRelaEN.BrowseCount = objRow[convCaseCourseExamRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseExamRelaEN.OrderNum = objRow[convCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseExamRelaEN.UpdDate = objRow[convCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseExamRelaEN.UpdUserId = objRow[convCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseExamRelaEN.Memo = objRow[convCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.Memo].ToString().Trim(); //备注
objvCaseCourseExamRelaEN.QuestionContent = objRow[convCaseCourseExamRela.QuestionContent] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionContent].ToString().Trim(); //题目内容
objvCaseCourseExamRelaEN.QuestionName = objRow[convCaseCourseExamRela.QuestionName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionName].ToString().Trim(); //题目名称
objvCaseCourseExamRelaEN.QuestionNo = objRow[convCaseCourseExamRela.QuestionNo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionNo].ToString().Trim(); //题目编号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCourseExamRelaEN.IdCaseCourseExamRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCourseExamRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseCourseExamRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCaseCourseExamRelaEN> arrObjLst = new List<clsvCaseCourseExamRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = new clsvCaseCourseExamRelaEN();
try
{
objvCaseCourseExamRelaEN.IdCaseCourseExamRela = Int32.Parse(objRow[convCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objvCaseCourseExamRelaEN.FuncModuleId = objRow[convCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseExamRelaEN.FuncModuleName = objRow[convCaseCourseExamRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseExamRelaEN.CaseId = objRow[convCaseCourseExamRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseExamRelaEN.CaseName = objRow[convCaseCourseExamRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseExamRelaEN.OwnerId = objRow[convCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseExamRelaEN.OwnerName = objRow[convCaseCourseExamRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseExamRelaEN.QuestionID = objRow[convCaseCourseExamRela.QuestionID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionID].ToString().Trim(); //题目ID
objvCaseCourseExamRelaEN.ExamAnswer = objRow[convCaseCourseExamRela.ExamAnswer] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ExamAnswer].ToString().Trim(); //题目答案
objvCaseCourseExamRelaEN.StartTime = objRow[convCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objvCaseCourseExamRelaEN.ParentNodeID = objRow[convCaseCourseExamRela.ParentNodeID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeID].ToString().Trim(); //父节点编号
objvCaseCourseExamRelaEN.ParentNodeName = objRow[convCaseCourseExamRela.ParentNodeName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeName].ToString().Trim(); //父节点名称
objvCaseCourseExamRelaEN.CourseId = objRow[convCaseCourseExamRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseExamRelaEN.CourseName = objRow[convCaseCourseExamRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[convCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objvCaseCourseExamRelaEN.CaseCourseExamRelaTypeName = objRow[convCaseCourseExamRela.CaseCourseExamRelaTypeName].ToString().Trim(); //案例题库关系类型名称
objvCaseCourseExamRelaEN.BrowseCount = objRow[convCaseCourseExamRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseExamRelaEN.OrderNum = objRow[convCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseExamRelaEN.UpdDate = objRow[convCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseExamRelaEN.UpdUserId = objRow[convCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseExamRelaEN.Memo = objRow[convCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.Memo].ToString().Trim(); //备注
objvCaseCourseExamRelaEN.QuestionContent = objRow[convCaseCourseExamRela.QuestionContent] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionContent].ToString().Trim(); //题目内容
objvCaseCourseExamRelaEN.QuestionName = objRow[convCaseCourseExamRela.QuestionName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionName].ToString().Trim(); //题目名称
objvCaseCourseExamRelaEN.QuestionNo = objRow[convCaseCourseExamRela.QuestionNo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionNo].ToString().Trim(); //题目编号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCourseExamRelaEN.IdCaseCourseExamRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCourseExamRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCaseCourseExamRela(ref clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN)
{
bool bolResult = vCaseCourseExamRelaDA.GetvCaseCourseExamRela(ref objvCaseCourseExamRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdCaseCourseExamRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseCourseExamRelaEN GetObjByIdCaseCourseExamRela(long lngIdCaseCourseExamRela)
{
clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = vCaseCourseExamRelaDA.GetObjByIdCaseCourseExamRela(lngIdCaseCourseExamRela);
return objvCaseCourseExamRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCaseCourseExamRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = vCaseCourseExamRelaDA.GetFirstObj(strWhereCond);
 return objvCaseCourseExamRelaEN;
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
public static clsvCaseCourseExamRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = vCaseCourseExamRelaDA.GetObjByDataRow(objRow);
 return objvCaseCourseExamRelaEN;
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
public static clsvCaseCourseExamRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = vCaseCourseExamRelaDA.GetObjByDataRow(objRow);
 return objvCaseCourseExamRelaEN;
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
 /// <param name = "lngIdCaseCourseExamRela">所给的关键字</param>
 /// <param name = "lstvCaseCourseExamRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCaseCourseExamRelaEN GetObjByIdCaseCourseExamRelaFromList(long lngIdCaseCourseExamRela, List<clsvCaseCourseExamRelaEN> lstvCaseCourseExamRelaObjLst)
{
foreach (clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN in lstvCaseCourseExamRelaObjLst)
{
if (objvCaseCourseExamRelaEN.IdCaseCourseExamRela == lngIdCaseCourseExamRela)
{
return objvCaseCourseExamRelaEN;
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
 long lngIdCaseCourseExamRela;
 try
 {
 lngIdCaseCourseExamRela = new clsvCaseCourseExamRelaDA().GetFirstID(strWhereCond);
 return lngIdCaseCourseExamRela;
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
 arrList = vCaseCourseExamRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vCaseCourseExamRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdCaseCourseExamRela">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdCaseCourseExamRela)
{
//检测记录是否存在
bool bolIsExist = vCaseCourseExamRelaDA.IsExist(lngIdCaseCourseExamRela);
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
 bolIsExist = clsvCaseCourseExamRelaDA.IsExistTable();
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
 bolIsExist = vCaseCourseExamRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvCaseCourseExamRelaENS">源对象</param>
 /// <param name = "objvCaseCourseExamRelaENT">目标对象</param>
 public static void CopyTo(clsvCaseCourseExamRelaEN objvCaseCourseExamRelaENS, clsvCaseCourseExamRelaEN objvCaseCourseExamRelaENT)
{
try
{
objvCaseCourseExamRelaENT.IdCaseCourseExamRela = objvCaseCourseExamRelaENS.IdCaseCourseExamRela; //案例题库关系流水号
objvCaseCourseExamRelaENT.FuncModuleId = objvCaseCourseExamRelaENS.FuncModuleId; //功能模块Id
objvCaseCourseExamRelaENT.FuncModuleName = objvCaseCourseExamRelaENS.FuncModuleName; //功能模块名称
objvCaseCourseExamRelaENT.CaseId = objvCaseCourseExamRelaENS.CaseId; //案例Id
objvCaseCourseExamRelaENT.CaseName = objvCaseCourseExamRelaENS.CaseName; //案例名称
objvCaseCourseExamRelaENT.OwnerId = objvCaseCourseExamRelaENS.OwnerId; //拥有者Id
objvCaseCourseExamRelaENT.OwnerName = objvCaseCourseExamRelaENS.OwnerName; //拥有者姓名
objvCaseCourseExamRelaENT.QuestionID = objvCaseCourseExamRelaENS.QuestionID; //题目ID
objvCaseCourseExamRelaENT.ExamAnswer = objvCaseCourseExamRelaENS.ExamAnswer; //题目答案
objvCaseCourseExamRelaENT.StartTime = objvCaseCourseExamRelaENS.StartTime; //开始时间(s)
objvCaseCourseExamRelaENT.ParentNodeID = objvCaseCourseExamRelaENS.ParentNodeID; //父节点编号
objvCaseCourseExamRelaENT.ParentNodeName = objvCaseCourseExamRelaENS.ParentNodeName; //父节点名称
objvCaseCourseExamRelaENT.CourseId = objvCaseCourseExamRelaENS.CourseId; //课程Id
objvCaseCourseExamRelaENT.CourseName = objvCaseCourseExamRelaENS.CourseName; //课程名称
objvCaseCourseExamRelaENT.IdCaseCourseExamRelaType = objvCaseCourseExamRelaENS.IdCaseCourseExamRelaType; //案例题库关系类型流水号
objvCaseCourseExamRelaENT.CaseCourseExamRelaTypeName = objvCaseCourseExamRelaENS.CaseCourseExamRelaTypeName; //案例题库关系类型名称
objvCaseCourseExamRelaENT.BrowseCount = objvCaseCourseExamRelaENS.BrowseCount; //浏览次数
objvCaseCourseExamRelaENT.OrderNum = objvCaseCourseExamRelaENS.OrderNum; //序号
objvCaseCourseExamRelaENT.UpdDate = objvCaseCourseExamRelaENS.UpdDate; //修改日期
objvCaseCourseExamRelaENT.UpdUserId = objvCaseCourseExamRelaENS.UpdUserId; //修改用户Id
objvCaseCourseExamRelaENT.Memo = objvCaseCourseExamRelaENS.Memo; //备注
objvCaseCourseExamRelaENT.QuestionContent = objvCaseCourseExamRelaENS.QuestionContent; //题目内容
objvCaseCourseExamRelaENT.QuestionName = objvCaseCourseExamRelaENS.QuestionName; //题目名称
objvCaseCourseExamRelaENT.QuestionNo = objvCaseCourseExamRelaENS.QuestionNo; //题目编号
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
 /// <param name = "objvCaseCourseExamRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN)
{
try
{
objvCaseCourseExamRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCaseCourseExamRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCaseCourseExamRela.IdCaseCourseExamRela, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.IdCaseCourseExamRela = objvCaseCourseExamRelaEN.IdCaseCourseExamRela; //案例题库关系流水号
}
if (arrFldSet.Contains(convCaseCourseExamRela.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.FuncModuleId = objvCaseCourseExamRelaEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convCaseCourseExamRela.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.FuncModuleName = objvCaseCourseExamRelaEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convCaseCourseExamRela.CaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.CaseId = objvCaseCourseExamRelaEN.CaseId == "[null]" ? null :  objvCaseCourseExamRelaEN.CaseId; //案例Id
}
if (arrFldSet.Contains(convCaseCourseExamRela.CaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.CaseName = objvCaseCourseExamRelaEN.CaseName == "[null]" ? null :  objvCaseCourseExamRelaEN.CaseName; //案例名称
}
if (arrFldSet.Contains(convCaseCourseExamRela.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.OwnerId = objvCaseCourseExamRelaEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convCaseCourseExamRela.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.OwnerName = objvCaseCourseExamRelaEN.OwnerName == "[null]" ? null :  objvCaseCourseExamRelaEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convCaseCourseExamRela.QuestionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.QuestionID = objvCaseCourseExamRelaEN.QuestionID == "[null]" ? null :  objvCaseCourseExamRelaEN.QuestionID; //题目ID
}
if (arrFldSet.Contains(convCaseCourseExamRela.ExamAnswer, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.ExamAnswer = objvCaseCourseExamRelaEN.ExamAnswer == "[null]" ? null :  objvCaseCourseExamRelaEN.ExamAnswer; //题目答案
}
if (arrFldSet.Contains(convCaseCourseExamRela.StartTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.StartTime = objvCaseCourseExamRelaEN.StartTime; //开始时间(s)
}
if (arrFldSet.Contains(convCaseCourseExamRela.ParentNodeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.ParentNodeID = objvCaseCourseExamRelaEN.ParentNodeID == "[null]" ? null :  objvCaseCourseExamRelaEN.ParentNodeID; //父节点编号
}
if (arrFldSet.Contains(convCaseCourseExamRela.ParentNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.ParentNodeName = objvCaseCourseExamRelaEN.ParentNodeName == "[null]" ? null :  objvCaseCourseExamRelaEN.ParentNodeName; //父节点名称
}
if (arrFldSet.Contains(convCaseCourseExamRela.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.CourseId = objvCaseCourseExamRelaEN.CourseId == "[null]" ? null :  objvCaseCourseExamRelaEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convCaseCourseExamRela.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.CourseName = objvCaseCourseExamRelaEN.CourseName == "[null]" ? null :  objvCaseCourseExamRelaEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convCaseCourseExamRela.IdCaseCourseExamRelaType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objvCaseCourseExamRelaEN.IdCaseCourseExamRelaType; //案例题库关系类型流水号
}
if (arrFldSet.Contains(convCaseCourseExamRela.CaseCourseExamRelaTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.CaseCourseExamRelaTypeName = objvCaseCourseExamRelaEN.CaseCourseExamRelaTypeName; //案例题库关系类型名称
}
if (arrFldSet.Contains(convCaseCourseExamRela.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.BrowseCount = objvCaseCourseExamRelaEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convCaseCourseExamRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.OrderNum = objvCaseCourseExamRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convCaseCourseExamRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.UpdDate = objvCaseCourseExamRelaEN.UpdDate == "[null]" ? null :  objvCaseCourseExamRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCaseCourseExamRela.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.UpdUserId = objvCaseCourseExamRelaEN.UpdUserId == "[null]" ? null :  objvCaseCourseExamRelaEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convCaseCourseExamRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.Memo = objvCaseCourseExamRelaEN.Memo == "[null]" ? null :  objvCaseCourseExamRelaEN.Memo; //备注
}
if (arrFldSet.Contains(convCaseCourseExamRela.QuestionContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.QuestionContent = objvCaseCourseExamRelaEN.QuestionContent == "[null]" ? null :  objvCaseCourseExamRelaEN.QuestionContent; //题目内容
}
if (arrFldSet.Contains(convCaseCourseExamRela.QuestionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.QuestionName = objvCaseCourseExamRelaEN.QuestionName == "[null]" ? null :  objvCaseCourseExamRelaEN.QuestionName; //题目名称
}
if (arrFldSet.Contains(convCaseCourseExamRela.QuestionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseExamRelaEN.QuestionNo = objvCaseCourseExamRelaEN.QuestionNo == "[null]" ? null :  objvCaseCourseExamRelaEN.QuestionNo; //题目编号
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
 /// <param name = "objvCaseCourseExamRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN)
{
try
{
if (objvCaseCourseExamRelaEN.CaseId == "[null]") objvCaseCourseExamRelaEN.CaseId = null; //案例Id
if (objvCaseCourseExamRelaEN.CaseName == "[null]") objvCaseCourseExamRelaEN.CaseName = null; //案例名称
if (objvCaseCourseExamRelaEN.OwnerName == "[null]") objvCaseCourseExamRelaEN.OwnerName = null; //拥有者姓名
if (objvCaseCourseExamRelaEN.QuestionID == "[null]") objvCaseCourseExamRelaEN.QuestionID = null; //题目ID
if (objvCaseCourseExamRelaEN.ExamAnswer == "[null]") objvCaseCourseExamRelaEN.ExamAnswer = null; //题目答案
if (objvCaseCourseExamRelaEN.ParentNodeID == "[null]") objvCaseCourseExamRelaEN.ParentNodeID = null; //父节点编号
if (objvCaseCourseExamRelaEN.ParentNodeName == "[null]") objvCaseCourseExamRelaEN.ParentNodeName = null; //父节点名称
if (objvCaseCourseExamRelaEN.CourseId == "[null]") objvCaseCourseExamRelaEN.CourseId = null; //课程Id
if (objvCaseCourseExamRelaEN.CourseName == "[null]") objvCaseCourseExamRelaEN.CourseName = null; //课程名称
if (objvCaseCourseExamRelaEN.UpdDate == "[null]") objvCaseCourseExamRelaEN.UpdDate = null; //修改日期
if (objvCaseCourseExamRelaEN.UpdUserId == "[null]") objvCaseCourseExamRelaEN.UpdUserId = null; //修改用户Id
if (objvCaseCourseExamRelaEN.Memo == "[null]") objvCaseCourseExamRelaEN.Memo = null; //备注
if (objvCaseCourseExamRelaEN.QuestionContent == "[null]") objvCaseCourseExamRelaEN.QuestionContent = null; //题目内容
if (objvCaseCourseExamRelaEN.QuestionName == "[null]") objvCaseCourseExamRelaEN.QuestionName = null; //题目名称
if (objvCaseCourseExamRelaEN.QuestionNo == "[null]") objvCaseCourseExamRelaEN.QuestionNo = null; //题目编号
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
public static void CheckProperty4Condition(clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN)
{
 vCaseCourseExamRelaDA.CheckProperty4Condition(objvCaseCourseExamRelaEN);
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
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseCourseExamRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseCourseExamRelaBL没有刷新缓存机制(clsCaseCourseExamRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseCourseExamRelaTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseCourseExamRelaTypeBL没有刷新缓存机制(clsCaseCourseExamRelaTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionnaireBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireBL没有刷新缓存机制(clsQuestionnaireBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerModeBL没有刷新缓存机制(clsAnswerModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerTypeBL没有刷新缓存机制(clsAnswerTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeBL没有刷新缓存机制(clsQuestionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamGradeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamGradeBL没有刷新缓存机制(clscc_ExamGradeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionType4CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionType4CourseBL没有刷新缓存机制(clsQuestionType4CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by IdCaseCourseExamRela");
//if (arrvCaseCourseExamRelaObjLstCache == null)
//{
//arrvCaseCourseExamRelaObjLstCache = vCaseCourseExamRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdCaseCourseExamRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCaseCourseExamRelaEN GetObjByIdCaseCourseExamRelaCache(long lngIdCaseCourseExamRela)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCaseCourseExamRelaEN._CurrTabName);
List<clsvCaseCourseExamRelaEN> arrvCaseCourseExamRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvCaseCourseExamRelaEN> arrvCaseCourseExamRelaObjLst_Sel =
arrvCaseCourseExamRelaObjLstCache
.Where(x=> x.IdCaseCourseExamRela == lngIdCaseCourseExamRela 
);
if (arrvCaseCourseExamRelaObjLst_Sel.Count() == 0)
{
   clsvCaseCourseExamRelaEN obj = clsvCaseCourseExamRelaBL.GetObjByIdCaseCourseExamRela(lngIdCaseCourseExamRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCaseCourseExamRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCaseCourseExamRelaEN> GetAllvCaseCourseExamRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvCaseCourseExamRelaEN> arrvCaseCourseExamRelaObjLstCache = GetObjLstCache(); 
return arrvCaseCourseExamRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCaseCourseExamRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCaseCourseExamRelaEN._CurrTabName);
List<clsvCaseCourseExamRelaEN> arrvCaseCourseExamRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCaseCourseExamRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvCaseCourseExamRelaEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdCaseCourseExamRela)
{
if (strInFldName != convCaseCourseExamRela.IdCaseCourseExamRela)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCaseCourseExamRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCaseCourseExamRela.AttributeName));
throw new Exception(strMsg);
}
var objvCaseCourseExamRela = clsvCaseCourseExamRelaBL.GetObjByIdCaseCourseExamRelaCache(lngIdCaseCourseExamRela);
if (objvCaseCourseExamRela == null) return "";
return objvCaseCourseExamRela[strOutFldName].ToString();
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
int intRecCount = clsvCaseCourseExamRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvCaseCourseExamRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCaseCourseExamRelaDA.GetRecCount();
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
int intRecCount = clsvCaseCourseExamRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCaseCourseExamRelaEN objvCaseCourseExamRelaCond)
{
List<clsvCaseCourseExamRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCaseCourseExamRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCaseCourseExamRela.AttributeName)
{
if (objvCaseCourseExamRelaCond.IsUpdated(strFldName) == false) continue;
if (objvCaseCourseExamRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseCourseExamRelaCond[strFldName].ToString());
}
else
{
if (objvCaseCourseExamRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCaseCourseExamRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseCourseExamRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCaseCourseExamRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCaseCourseExamRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCaseCourseExamRelaCond[strFldName]));
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
 List<string> arrList = clsvCaseCourseExamRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCaseCourseExamRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCaseCourseExamRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}