
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseCourseExamRelaWApi
 表名:vCaseCourseExamRela(01120391)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:08
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
public static class clsvCaseCourseExamRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN Setid_CaseCourseExamRela(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, long lngid_CaseCourseExamRela, string strComparisonOp="")
	{
objvCaseCourseExamRelaEN.id_CaseCourseExamRela = lngid_CaseCourseExamRela; //案例题库关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.id_CaseCourseExamRela) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.id_CaseCourseExamRela, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.id_CaseCourseExamRela] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetFuncModuleId(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCaseCourseExamRela.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCaseCourseExamRela.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCaseCourseExamRela.FuncModuleId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetFuncModuleName(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convCaseCourseExamRela.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCaseCourseExamRela.FuncModuleName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetCaseId(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strCaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseId, 8, convCaseCourseExamRela.CaseId);
clsCheckSql.CheckFieldForeignKey(strCaseId, 8, convCaseCourseExamRela.CaseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetCaseName(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseName, 100, convCaseCourseExamRela.CaseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetOwnerId(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convCaseCourseExamRela.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCaseCourseExamRela.OwnerId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetOwnerName(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCaseCourseExamRela.OwnerName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetQuestionID(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convCaseCourseExamRela.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convCaseCourseExamRela.QuestionID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetExamAnswer(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strExamAnswer, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamAnswer, 8000, convCaseCourseExamRela.ExamAnswer);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetStartTime(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, double dblStartTime, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetParentNodeID(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convCaseCourseExamRela.ParentNodeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetParentNodeName(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convCaseCourseExamRela.ParentNodeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetCourseId(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCaseCourseExamRela.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCaseCourseExamRela.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetCourseName(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCaseCourseExamRela.CourseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN Setid_CaseCourseExamRelaType(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strid_CaseCourseExamRelaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CaseCourseExamRelaType, convCaseCourseExamRela.id_CaseCourseExamRelaType);
clsCheckSql.CheckFieldLen(strid_CaseCourseExamRelaType, 4, convCaseCourseExamRela.id_CaseCourseExamRelaType);
clsCheckSql.CheckFieldForeignKey(strid_CaseCourseExamRelaType, 4, convCaseCourseExamRela.id_CaseCourseExamRelaType);
objvCaseCourseExamRelaEN.id_CaseCourseExamRelaType = strid_CaseCourseExamRelaType; //案例题库关系类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseExamRela.id_CaseCourseExamRelaType) == false)
{
objvCaseCourseExamRelaEN.dicFldComparisonOp.Add(convCaseCourseExamRela.id_CaseCourseExamRelaType, strComparisonOp);
}
else
{
objvCaseCourseExamRelaEN.dicFldComparisonOp[convCaseCourseExamRela.id_CaseCourseExamRelaType] = strComparisonOp;
}
}
return objvCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetCaseCourseExamRelaTypeName(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strCaseCourseExamRelaTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseCourseExamRelaTypeName, convCaseCourseExamRela.CaseCourseExamRelaTypeName);
clsCheckSql.CheckFieldLen(strCaseCourseExamRelaTypeName, 50, convCaseCourseExamRela.CaseCourseExamRelaTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetBrowseCount(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, int intBrowseCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetOrderNum(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, int intOrderNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetUpdDate(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCaseCourseExamRela.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetUpdUserId(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convCaseCourseExamRela.UpdUserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetMemo(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCaseCourseExamRela.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetQuestionContent(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strQuestionContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, convCaseCourseExamRela.QuestionContent);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetQuestionName(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convCaseCourseExamRela.QuestionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseExamRelaEN SetQuestionNo(this clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN, string strQuestionNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, convCaseCourseExamRela.QuestionNo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCaseCourseExamRelaEN objvCaseCourseExamRela_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.id_CaseCourseExamRela) == true)
{
string strComparisonOp_id_CaseCourseExamRela = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.id_CaseCourseExamRela];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCourseExamRela.id_CaseCourseExamRela, objvCaseCourseExamRela_Cond.id_CaseCourseExamRela, strComparisonOp_id_CaseCourseExamRela);
}
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.FuncModuleId, objvCaseCourseExamRela_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.FuncModuleName, objvCaseCourseExamRela_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.CaseId) == true)
{
string strComparisonOp_CaseId = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.CaseId, objvCaseCourseExamRela_Cond.CaseId, strComparisonOp_CaseId);
}
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.CaseName) == true)
{
string strComparisonOp_CaseName = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.CaseName, objvCaseCourseExamRela_Cond.CaseName, strComparisonOp_CaseName);
}
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.OwnerId, objvCaseCourseExamRela_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.OwnerName, objvCaseCourseExamRela_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.QuestionID, objvCaseCourseExamRela_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.ExamAnswer) == true)
{
string strComparisonOp_ExamAnswer = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.ExamAnswer];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.ExamAnswer, objvCaseCourseExamRela_Cond.ExamAnswer, strComparisonOp_ExamAnswer);
}
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.StartTime) == true)
{
string strComparisonOp_StartTime = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.StartTime];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCourseExamRela.StartTime, objvCaseCourseExamRela_Cond.StartTime, strComparisonOp_StartTime);
}
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.ParentNodeID, objvCaseCourseExamRela_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.ParentNodeName, objvCaseCourseExamRela_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.CourseId) == true)
{
string strComparisonOp_CourseId = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.CourseId, objvCaseCourseExamRela_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.CourseName) == true)
{
string strComparisonOp_CourseName = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.CourseName, objvCaseCourseExamRela_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.id_CaseCourseExamRelaType) == true)
{
string strComparisonOp_id_CaseCourseExamRelaType = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.id_CaseCourseExamRelaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.id_CaseCourseExamRelaType, objvCaseCourseExamRela_Cond.id_CaseCourseExamRelaType, strComparisonOp_id_CaseCourseExamRelaType);
}
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.CaseCourseExamRelaTypeName) == true)
{
string strComparisonOp_CaseCourseExamRelaTypeName = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.CaseCourseExamRelaTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.CaseCourseExamRelaTypeName, objvCaseCourseExamRela_Cond.CaseCourseExamRelaTypeName, strComparisonOp_CaseCourseExamRelaTypeName);
}
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCourseExamRela.BrowseCount, objvCaseCourseExamRela_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCourseExamRela.OrderNum, objvCaseCourseExamRela_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.UpdDate, objvCaseCourseExamRela_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.UpdUserId, objvCaseCourseExamRela_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.Memo) == true)
{
string strComparisonOp_Memo = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.Memo, objvCaseCourseExamRela_Cond.Memo, strComparisonOp_Memo);
}
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.QuestionContent) == true)
{
string strComparisonOp_QuestionContent = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.QuestionContent, objvCaseCourseExamRela_Cond.QuestionContent, strComparisonOp_QuestionContent);
}
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.QuestionName, objvCaseCourseExamRela_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvCaseCourseExamRela_Cond.IsUpdated(convCaseCourseExamRela.QuestionNo) == true)
{
string strComparisonOp_QuestionNo = objvCaseCourseExamRela_Cond.dicFldComparisonOp[convCaseCourseExamRela.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseExamRela.QuestionNo, objvCaseCourseExamRela_Cond.QuestionNo, strComparisonOp_QuestionNo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v案例题库关系(vCaseCourseExamRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCaseCourseExamRelaWApi
{
private static readonly string mstrApiControllerName = "vCaseCourseExamRelaApi";

 public clsvCaseCourseExamRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_CaseCourseExamRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseCourseExamRelaEN GetObjByid_CaseCourseExamRela(long lngid_CaseCourseExamRela)
{
string strAction = "GetObjByid_CaseCourseExamRela";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseCourseExamRela"] = lngid_CaseCourseExamRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCaseCourseExamRelaEN = JsonConvert.DeserializeObject<clsvCaseCourseExamRelaEN>((string)jobjReturn["ReturnObj"]);
return objvCaseCourseExamRelaEN;
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
 /// <param name = "lngid_CaseCourseExamRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseCourseExamRelaEN GetObjByid_CaseCourseExamRela_WA_Cache(long lngid_CaseCourseExamRela)
{
string strAction = "GetObjByid_CaseCourseExamRela_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseCourseExamRela"] = lngid_CaseCourseExamRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCaseCourseExamRelaEN = JsonConvert.DeserializeObject<clsvCaseCourseExamRelaEN>((string)jobjReturn["ReturnObj"]);
return objvCaseCourseExamRelaEN;
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
public static clsvCaseCourseExamRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = null;
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
objvCaseCourseExamRelaEN = JsonConvert.DeserializeObject<clsvCaseCourseExamRelaEN>((string)jobjReturn["ReturnObj"]);
return objvCaseCourseExamRelaEN;
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
 /// <param name = "lngid_CaseCourseExamRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCaseCourseExamRelaEN GetObjByid_CaseCourseExamRela_Cache(long lngid_CaseCourseExamRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCaseCourseExamRelaEN._CurrTabName_S);
List<clsvCaseCourseExamRelaEN> arrvCaseCourseExamRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCaseCourseExamRelaEN> arrvCaseCourseExamRelaObjLst_Sel =
from objvCaseCourseExamRelaEN in arrvCaseCourseExamRelaObjLst_Cache
where objvCaseCourseExamRelaEN.id_CaseCourseExamRela == lngid_CaseCourseExamRela
select objvCaseCourseExamRelaEN;
if (arrvCaseCourseExamRelaObjLst_Sel.Count() == 0)
{
   clsvCaseCourseExamRelaEN obj = clsvCaseCourseExamRelaWApi.GetObjByid_CaseCourseExamRela(lngid_CaseCourseExamRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCaseCourseExamRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseCourseExamRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvCaseCourseExamRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseCourseExamRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseCourseExamRelaEN> GetObjLstById_CaseCourseExamRelaLst(List<long> arrId_CaseCourseExamRela)
{
 List<clsvCaseCourseExamRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_CaseCourseExamRelaLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CaseCourseExamRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseCourseExamRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_CaseCourseExamRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvCaseCourseExamRelaEN> GetObjLstById_CaseCourseExamRelaLst_Cache(List<long> arrId_CaseCourseExamRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCaseCourseExamRelaEN._CurrTabName_S);
List<clsvCaseCourseExamRelaEN> arrvCaseCourseExamRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCaseCourseExamRelaEN> arrvCaseCourseExamRelaObjLst_Sel =
from objvCaseCourseExamRelaEN in arrvCaseCourseExamRelaObjLst_Cache
where arrId_CaseCourseExamRela.Contains(objvCaseCourseExamRelaEN.id_CaseCourseExamRela)
select objvCaseCourseExamRelaEN;
return arrvCaseCourseExamRelaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseCourseExamRelaEN> GetObjLstById_CaseCourseExamRelaLst_WA_Cache(List<long> arrId_CaseCourseExamRela)
{
 List<clsvCaseCourseExamRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_CaseCourseExamRelaLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CaseCourseExamRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseCourseExamRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseCourseExamRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCaseCourseExamRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseCourseExamRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseCourseExamRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCaseCourseExamRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseCourseExamRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseCourseExamRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCaseCourseExamRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseCourseExamRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseCourseExamRelaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCaseCourseExamRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseCourseExamRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_CaseCourseExamRela)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseCourseExamRela"] = lngid_CaseCourseExamRela.ToString()
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
 /// <param name = "objvCaseCourseExamRelaENS">源对象</param>
 /// <param name = "objvCaseCourseExamRelaENT">目标对象</param>
 public static void CopyTo(clsvCaseCourseExamRelaEN objvCaseCourseExamRelaENS, clsvCaseCourseExamRelaEN objvCaseCourseExamRelaENT)
{
try
{
objvCaseCourseExamRelaENT.id_CaseCourseExamRela = objvCaseCourseExamRelaENS.id_CaseCourseExamRela; //案例题库关系流水号
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
objvCaseCourseExamRelaENT.id_CaseCourseExamRelaType = objvCaseCourseExamRelaENS.id_CaseCourseExamRelaType; //案例题库关系类型流水号
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
public static DataTable ToDataTable(List<clsvCaseCourseExamRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCaseCourseExamRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCaseCourseExamRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCaseCourseExamRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCaseCourseExamRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCaseCourseExamRelaEN.AttributeName)
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
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseCourseExamRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseCourseExamRelaWApi没有刷新缓存机制(clsCaseCourseExamRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseCourseExamRelaTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseCourseExamRelaTypeWApi没有刷新缓存机制(clsCaseCourseExamRelaTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionnaireWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireWApi没有刷新缓存机制(clsQuestionnaireWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerModeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerModeWApi没有刷新缓存机制(clsAnswerModeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerTypeWApi没有刷新缓存机制(clsAnswerTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeWApi没有刷新缓存机制(clsQuestionTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamGradeWApi没有刷新缓存机制(clscc_ExamGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionType4CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionType4CourseWApi没有刷新缓存机制(clsQuestionType4CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by id_CaseCourseExamRela");
//if (arrvCaseCourseExamRelaObjLst_Cache == null)
//{
//arrvCaseCourseExamRelaObjLst_Cache = await clsvCaseCourseExamRelaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCaseCourseExamRelaEN._CurrTabName_S);
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
public static List<clsvCaseCourseExamRelaEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCaseCourseExamRelaEN._CurrTabName_S);
List<clsvCaseCourseExamRelaEN> arrvCaseCourseExamRelaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCaseCourseExamRelaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCaseCourseExamRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCaseCourseExamRela.id_CaseCourseExamRela, Type.GetType("System.Int64"));
objDT.Columns.Add(convCaseCourseExamRela.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseExamRela.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseExamRela.CaseId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseExamRela.CaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseExamRela.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseExamRela.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseExamRela.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseExamRela.ExamAnswer, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseExamRela.StartTime, Type.GetType("System.Decimal"));
objDT.Columns.Add(convCaseCourseExamRela.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseExamRela.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseExamRela.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseExamRela.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseExamRela.id_CaseCourseExamRelaType, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseExamRela.CaseCourseExamRelaTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseExamRela.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCaseCourseExamRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCaseCourseExamRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseExamRela.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseExamRela.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseExamRela.QuestionContent, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseExamRela.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseExamRela.QuestionNo, Type.GetType("System.String"));
foreach (clsvCaseCourseExamRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCaseCourseExamRela.id_CaseCourseExamRela] = objInFor[convCaseCourseExamRela.id_CaseCourseExamRela];
objDR[convCaseCourseExamRela.FuncModuleId] = objInFor[convCaseCourseExamRela.FuncModuleId];
objDR[convCaseCourseExamRela.FuncModuleName] = objInFor[convCaseCourseExamRela.FuncModuleName];
objDR[convCaseCourseExamRela.CaseId] = objInFor[convCaseCourseExamRela.CaseId];
objDR[convCaseCourseExamRela.CaseName] = objInFor[convCaseCourseExamRela.CaseName];
objDR[convCaseCourseExamRela.OwnerId] = objInFor[convCaseCourseExamRela.OwnerId];
objDR[convCaseCourseExamRela.OwnerName] = objInFor[convCaseCourseExamRela.OwnerName];
objDR[convCaseCourseExamRela.QuestionID] = objInFor[convCaseCourseExamRela.QuestionID];
objDR[convCaseCourseExamRela.ExamAnswer] = objInFor[convCaseCourseExamRela.ExamAnswer];
objDR[convCaseCourseExamRela.StartTime] = objInFor[convCaseCourseExamRela.StartTime];
objDR[convCaseCourseExamRela.ParentNodeID] = objInFor[convCaseCourseExamRela.ParentNodeID];
objDR[convCaseCourseExamRela.ParentNodeName] = objInFor[convCaseCourseExamRela.ParentNodeName];
objDR[convCaseCourseExamRela.CourseId] = objInFor[convCaseCourseExamRela.CourseId];
objDR[convCaseCourseExamRela.CourseName] = objInFor[convCaseCourseExamRela.CourseName];
objDR[convCaseCourseExamRela.id_CaseCourseExamRelaType] = objInFor[convCaseCourseExamRela.id_CaseCourseExamRelaType];
objDR[convCaseCourseExamRela.CaseCourseExamRelaTypeName] = objInFor[convCaseCourseExamRela.CaseCourseExamRelaTypeName];
objDR[convCaseCourseExamRela.BrowseCount] = objInFor[convCaseCourseExamRela.BrowseCount];
objDR[convCaseCourseExamRela.OrderNum] = objInFor[convCaseCourseExamRela.OrderNum];
objDR[convCaseCourseExamRela.UpdDate] = objInFor[convCaseCourseExamRela.UpdDate];
objDR[convCaseCourseExamRela.UpdUserId] = objInFor[convCaseCourseExamRela.UpdUserId];
objDR[convCaseCourseExamRela.Memo] = objInFor[convCaseCourseExamRela.Memo];
objDR[convCaseCourseExamRela.QuestionContent] = objInFor[convCaseCourseExamRela.QuestionContent];
objDR[convCaseCourseExamRela.QuestionName] = objInFor[convCaseCourseExamRela.QuestionName];
objDR[convCaseCourseExamRela.QuestionNo] = objInFor[convCaseCourseExamRela.QuestionNo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}