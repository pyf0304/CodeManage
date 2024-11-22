
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserAnswerResultWApi
 表名:UserAnswerResult(01120032)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:31
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷结果
 模块英文名:QuestionnaireResult
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
public static class clsUserAnswerResultWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetMinID(this clsUserAnswerResultEN objUserAnswerResultEN, long lngMinID, string strComparisonOp="")
	{
objUserAnswerResultEN.MinID = lngMinID; //MinID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.MinID) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.MinID, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.MinID] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetQuestionID(this clsUserAnswerResultEN objUserAnswerResultEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, conUserAnswerResult.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, conUserAnswerResult.QuestionID);
objUserAnswerResultEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.QuestionID) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.QuestionID, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.QuestionID] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetQuestionnaireSetId(this clsUserAnswerResultEN objUserAnswerResultEN, string strQuestionnaireSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionnaireSetId, 4, conUserAnswerResult.QuestionnaireSetId);
clsCheckSql.CheckFieldForeignKey(strQuestionnaireSetId, 4, conUserAnswerResult.QuestionnaireSetId);
objUserAnswerResultEN.QuestionnaireSetId = strQuestionnaireSetId; //问卷集ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.QuestionnaireSetId) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.QuestionnaireSetId, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.QuestionnaireSetId] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetCourseId(this clsUserAnswerResultEN objUserAnswerResultEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, conUserAnswerResult.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conUserAnswerResult.CourseId);
objUserAnswerResultEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.CourseId) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.CourseId, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.CourseId] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetExamBatchNo(this clsUserAnswerResultEN objUserAnswerResultEN, string strExamBatchNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamBatchNo, 20, conUserAnswerResult.ExamBatchNo);
objUserAnswerResultEN.ExamBatchNo = strExamBatchNo; //学生批次号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.ExamBatchNo) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.ExamBatchNo, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.ExamBatchNo] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetCourseExamPaperId(this clsUserAnswerResultEN objUserAnswerResultEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, conUserAnswerResult.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, conUserAnswerResult.CourseExamPaperId);
objUserAnswerResultEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.CourseExamPaperId) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.CourseExamPaperId, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.CourseExamPaperId] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetAnswerOptionId(this clsUserAnswerResultEN objUserAnswerResultEN, string strAnswerOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerOptionId, 8, conUserAnswerResult.AnswerOptionId);
clsCheckSql.CheckFieldForeignKey(strAnswerOptionId, 8, conUserAnswerResult.AnswerOptionId);
objUserAnswerResultEN.AnswerOptionId = strAnswerOptionId; //回答选项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.AnswerOptionId) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.AnswerOptionId, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.AnswerOptionId] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetBatchId(this clsUserAnswerResultEN objUserAnswerResultEN, string strBatchId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBatchId, 4, conUserAnswerResult.BatchId);
clsCheckSql.CheckFieldForeignKey(strBatchId, 4, conUserAnswerResult.BatchId);
objUserAnswerResultEN.BatchId = strBatchId; //批次ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.BatchId) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.BatchId, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.BatchId] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetUserId(this clsUserAnswerResultEN objUserAnswerResultEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, conUserAnswerResult.UserId);
objUserAnswerResultEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.UserId) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.UserId, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.UserId] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetAnswerText(this clsUserAnswerResultEN objUserAnswerResultEN, string strAnswerText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerText, 8000, conUserAnswerResult.AnswerText);
objUserAnswerResultEN.AnswerText = strAnswerText; //回答文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.AnswerText) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.AnswerText, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.AnswerText] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetAnswerDate(this clsUserAnswerResultEN objUserAnswerResultEN, string strAnswerDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, conUserAnswerResult.AnswerDate);
objUserAnswerResultEN.AnswerDate = strAnswerDate; //回答日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.AnswerDate) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.AnswerDate, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.AnswerDate] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetAnswerTime(this clsUserAnswerResultEN objUserAnswerResultEN, string strAnswerTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, conUserAnswerResult.AnswerTime);
objUserAnswerResultEN.AnswerTime = strAnswerTime; //回答时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.AnswerTime) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.AnswerTime, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.AnswerTime] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetAnswerIP(this clsUserAnswerResultEN objUserAnswerResultEN, string strAnswerIP, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerIP, 30, conUserAnswerResult.AnswerIP);
objUserAnswerResultEN.AnswerIP = strAnswerIP; //回答IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.AnswerIP) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.AnswerIP, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.AnswerIP] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetIsAccess(this clsUserAnswerResultEN objUserAnswerResultEN, bool bolIsAccess, string strComparisonOp="")
	{
objUserAnswerResultEN.IsAccess = bolIsAccess; //IsAccess
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.IsAccess) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.IsAccess, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.IsAccess] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetIsAccessC(this clsUserAnswerResultEN objUserAnswerResultEN, bool bolIsAccessC, string strComparisonOp="")
	{
objUserAnswerResultEN.IsAccessC = bolIsAccessC; //IsAccessC
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.IsAccessC) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.IsAccessC, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.IsAccessC] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN Setid_School(this clsUserAnswerResultEN objUserAnswerResultEN, string strid_School, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School, 4, conUserAnswerResult.id_School);
clsCheckSql.CheckFieldForeignKey(strid_School, 4, conUserAnswerResult.id_School);
objUserAnswerResultEN.id_School = strid_School; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.id_School) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.id_School, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.id_School] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetSchool(this clsUserAnswerResultEN objUserAnswerResultEN, string strSchool, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchool, 50, conUserAnswerResult.School);
objUserAnswerResultEN.School = strSchool; //School
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.School) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.School, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.School] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetAnswerMode(this clsUserAnswerResultEN objUserAnswerResultEN, int intAnswerMode, string strComparisonOp="")
	{
objUserAnswerResultEN.AnswerMode = intAnswerMode; //AnswerMode
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.AnswerMode) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.AnswerMode, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.AnswerMode] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetIsMarking(this clsUserAnswerResultEN objUserAnswerResultEN, bool bolIsMarking, string strComparisonOp="")
	{
objUserAnswerResultEN.IsMarking = bolIsMarking; //是否批阅
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.IsMarking) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.IsMarking, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.IsMarking] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetIsRight(this clsUserAnswerResultEN objUserAnswerResultEN, bool bolIsRight, string strComparisonOp="")
	{
objUserAnswerResultEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.IsRight) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.IsRight, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.IsRight] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetScore(this clsUserAnswerResultEN objUserAnswerResultEN, double dblScore, string strComparisonOp="")
	{
objUserAnswerResultEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.Score) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.Score, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.Score] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetMarkTime(this clsUserAnswerResultEN objUserAnswerResultEN, string strMarkTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkTime, 14, conUserAnswerResult.MarkTime);
objUserAnswerResultEN.MarkTime = strMarkTime; //批改时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.MarkTime) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.MarkTime, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.MarkTime] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetMarkerId(this clsUserAnswerResultEN objUserAnswerResultEN, string strMarkerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkerId, 20, conUserAnswerResult.MarkerId);
objUserAnswerResultEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.MarkerId) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.MarkerId, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.MarkerId] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetComment(this clsUserAnswerResultEN objUserAnswerResultEN, string strComment, string strComparisonOp="")
	{
objUserAnswerResultEN.Comment = strComment; //批注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.Comment) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.Comment, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.Comment] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetIsAccessKnowledge(this clsUserAnswerResultEN objUserAnswerResultEN, bool bolIsAccessKnowledge, string strComparisonOp="")
	{
objUserAnswerResultEN.IsAccessKnowledge = bolIsAccessKnowledge; //是否处理知识点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.IsAccessKnowledge) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.IsAccessKnowledge, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.IsAccessKnowledge] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetUpdDate(this clsUserAnswerResultEN objUserAnswerResultEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conUserAnswerResult.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conUserAnswerResult.UpdDate);
objUserAnswerResultEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.UpdDate) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.UpdDate, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.UpdDate] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetUpdUser(this clsUserAnswerResultEN objUserAnswerResultEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conUserAnswerResult.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conUserAnswerResult.UpdUser);
objUserAnswerResultEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.UpdUser) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.UpdUser, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.UpdUser] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetMemo(this clsUserAnswerResultEN objUserAnswerResultEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conUserAnswerResult.Memo);
objUserAnswerResultEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.Memo) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.Memo, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.Memo] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetAnswerID(this clsUserAnswerResultEN objUserAnswerResultEN, long lngAnswerID, string strComparisonOp="")
	{
objUserAnswerResultEN.AnswerID = lngAnswerID; //问答ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.AnswerID) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.AnswerID, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.AnswerID] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserAnswerResultEN SetAnswerMultiOption(this clsUserAnswerResultEN objUserAnswerResultEN, string strAnswerMultiOption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerMultiOption, 300, conUserAnswerResult.AnswerMultiOption);
objUserAnswerResultEN.AnswerMultiOption = strAnswerMultiOption; //多选项答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.AnswerMultiOption) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.AnswerMultiOption, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.AnswerMultiOption] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsUserAnswerResultEN objUserAnswerResult_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.MinID) == true)
{
string strComparisonOp_MinID = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.MinID];
strWhereCond += string.Format(" And {0} {2} {1}", conUserAnswerResult.MinID, objUserAnswerResult_Cond.MinID, strComparisonOp_MinID);
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.QuestionID) == true)
{
string strComparisonOp_QuestionID = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.QuestionID, objUserAnswerResult_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.QuestionnaireSetId) == true)
{
string strComparisonOp_QuestionnaireSetId = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.QuestionnaireSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.QuestionnaireSetId, objUserAnswerResult_Cond.QuestionnaireSetId, strComparisonOp_QuestionnaireSetId);
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.CourseId) == true)
{
string strComparisonOp_CourseId = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.CourseId, objUserAnswerResult_Cond.CourseId, strComparisonOp_CourseId);
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.ExamBatchNo) == true)
{
string strComparisonOp_ExamBatchNo = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.ExamBatchNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.ExamBatchNo, objUserAnswerResult_Cond.ExamBatchNo, strComparisonOp_ExamBatchNo);
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.CourseExamPaperId, objUserAnswerResult_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.AnswerOptionId) == true)
{
string strComparisonOp_AnswerOptionId = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.AnswerOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.AnswerOptionId, objUserAnswerResult_Cond.AnswerOptionId, strComparisonOp_AnswerOptionId);
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.BatchId) == true)
{
string strComparisonOp_BatchId = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.BatchId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.BatchId, objUserAnswerResult_Cond.BatchId, strComparisonOp_BatchId);
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.UserId) == true)
{
string strComparisonOp_UserId = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.UserId, objUserAnswerResult_Cond.UserId, strComparisonOp_UserId);
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.AnswerText) == true)
{
string strComparisonOp_AnswerText = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.AnswerText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.AnswerText, objUserAnswerResult_Cond.AnswerText, strComparisonOp_AnswerText);
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.AnswerDate) == true)
{
string strComparisonOp_AnswerDate = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.AnswerDate, objUserAnswerResult_Cond.AnswerDate, strComparisonOp_AnswerDate);
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.AnswerTime) == true)
{
string strComparisonOp_AnswerTime = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.AnswerTime, objUserAnswerResult_Cond.AnswerTime, strComparisonOp_AnswerTime);
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.AnswerIP) == true)
{
string strComparisonOp_AnswerIP = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.AnswerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.AnswerIP, objUserAnswerResult_Cond.AnswerIP, strComparisonOp_AnswerIP);
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.IsAccess) == true)
{
if (objUserAnswerResult_Cond.IsAccess == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUserAnswerResult.IsAccess);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUserAnswerResult.IsAccess);
}
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.IsAccessC) == true)
{
if (objUserAnswerResult_Cond.IsAccessC == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUserAnswerResult.IsAccessC);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUserAnswerResult.IsAccessC);
}
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.id_School) == true)
{
string strComparisonOp_id_School = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.id_School];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.id_School, objUserAnswerResult_Cond.id_School, strComparisonOp_id_School);
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.School) == true)
{
string strComparisonOp_School = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.School];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.School, objUserAnswerResult_Cond.School, strComparisonOp_School);
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.AnswerMode) == true)
{
string strComparisonOp_AnswerMode = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.AnswerMode];
strWhereCond += string.Format(" And {0} {2} {1}", conUserAnswerResult.AnswerMode, objUserAnswerResult_Cond.AnswerMode, strComparisonOp_AnswerMode);
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.IsMarking) == true)
{
if (objUserAnswerResult_Cond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUserAnswerResult.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUserAnswerResult.IsMarking);
}
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.IsRight) == true)
{
if (objUserAnswerResult_Cond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUserAnswerResult.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUserAnswerResult.IsRight);
}
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.Score) == true)
{
string strComparisonOp_Score = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conUserAnswerResult.Score, objUserAnswerResult_Cond.Score, strComparisonOp_Score);
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.MarkTime) == true)
{
string strComparisonOp_MarkTime = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.MarkTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.MarkTime, objUserAnswerResult_Cond.MarkTime, strComparisonOp_MarkTime);
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.MarkerId) == true)
{
string strComparisonOp_MarkerId = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.MarkerId, objUserAnswerResult_Cond.MarkerId, strComparisonOp_MarkerId);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.IsAccessKnowledge) == true)
{
if (objUserAnswerResult_Cond.IsAccessKnowledge == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUserAnswerResult.IsAccessKnowledge);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUserAnswerResult.IsAccessKnowledge);
}
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.UpdDate) == true)
{
string strComparisonOp_UpdDate = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.UpdDate, objUserAnswerResult_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.UpdUser) == true)
{
string strComparisonOp_UpdUser = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.UpdUser, objUserAnswerResult_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.Memo) == true)
{
string strComparisonOp_Memo = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.Memo, objUserAnswerResult_Cond.Memo, strComparisonOp_Memo);
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.AnswerID) == true)
{
string strComparisonOp_AnswerID = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.AnswerID];
strWhereCond += string.Format(" And {0} {2} {1}", conUserAnswerResult.AnswerID, objUserAnswerResult_Cond.AnswerID, strComparisonOp_AnswerID);
}
if (objUserAnswerResult_Cond.IsUpdated(conUserAnswerResult.AnswerMultiOption) == true)
{
string strComparisonOp_AnswerMultiOption = objUserAnswerResult_Cond.dicFldComparisonOp[conUserAnswerResult.AnswerMultiOption];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.AnswerMultiOption, objUserAnswerResult_Cond.AnswerMultiOption, strComparisonOp_AnswerMultiOption);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserAnswerResultEN objUserAnswerResultEN)
{
 if (objUserAnswerResultEN.MinID == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objUserAnswerResultEN.sf_UpdFldSetStr = objUserAnswerResultEN.getsf_UpdFldSetStr();
clsUserAnswerResultWApi.CheckPropertyNew(objUserAnswerResultEN); 
bool bolResult = clsUserAnswerResultWApi.UpdateRecord(objUserAnswerResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserAnswerResultWApi.ReFreshCache(objUserAnswerResultEN.CourseId);
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
 /// 检查唯一性(Uniqueness)--UserAnswerResult(用户答题结果), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_QuestionID_UserId_CourseExamPaperId(this clsUserAnswerResultEN objUserAnswerResultEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objUserAnswerResultEN == null) return "";
if (objUserAnswerResultEN.MinID == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objUserAnswerResultEN.QuestionID);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserAnswerResultEN.UserId);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objUserAnswerResultEN.CourseExamPaperId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("MinID !=  {0}", objUserAnswerResultEN.MinID);
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objUserAnswerResultEN.QuestionID);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserAnswerResultEN.UserId);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objUserAnswerResultEN.CourseExamPaperId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUserAnswerResultEN objUserAnswerResultEN)
{
try
{
clsUserAnswerResultWApi.CheckPropertyNew(objUserAnswerResultEN); 
bool bolResult = clsUserAnswerResultWApi.AddNewRecord(objUserAnswerResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserAnswerResultWApi.ReFreshCache(objUserAnswerResultEN.CourseId);
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
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserAnswerResultEN objUserAnswerResultEN, string strWhereCond)
{
try
{
clsUserAnswerResultWApi.CheckPropertyNew(objUserAnswerResultEN); 
bool bolResult = clsUserAnswerResultWApi.UpdateWithCondition(objUserAnswerResultEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserAnswerResultWApi.ReFreshCache(objUserAnswerResultEN.CourseId);
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
 /// 用户答题结果(UserAnswerResult)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsUserAnswerResultWApi
{
private static readonly string mstrApiControllerName = "UserAnswerResultApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clsUserAnswerResultWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsUserAnswerResultEN objUserAnswerResultEN)
{
if (!Object.Equals(null, objUserAnswerResultEN.QuestionID) && GetStrLen(objUserAnswerResultEN.QuestionID) > 8)
{
 throw new Exception("字段[题目ID]的长度不能超过8!");
}
if (!Object.Equals(null, objUserAnswerResultEN.QuestionnaireSetId) && GetStrLen(objUserAnswerResultEN.QuestionnaireSetId) > 4)
{
 throw new Exception("字段[问卷集ID]的长度不能超过4!");
}
if (!Object.Equals(null, objUserAnswerResultEN.CourseId) && GetStrLen(objUserAnswerResultEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objUserAnswerResultEN.ExamBatchNo) && GetStrLen(objUserAnswerResultEN.ExamBatchNo) > 20)
{
 throw new Exception("字段[学生批次号]的长度不能超过20!");
}
if (!Object.Equals(null, objUserAnswerResultEN.CourseExamPaperId) && GetStrLen(objUserAnswerResultEN.CourseExamPaperId) > 8)
{
 throw new Exception("字段[考卷流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objUserAnswerResultEN.AnswerOptionId) && GetStrLen(objUserAnswerResultEN.AnswerOptionId) > 8)
{
 throw new Exception("字段[回答选项Id]的长度不能超过8!");
}
if (!Object.Equals(null, objUserAnswerResultEN.BatchId) && GetStrLen(objUserAnswerResultEN.BatchId) > 4)
{
 throw new Exception("字段[批次ID]的长度不能超过4!");
}
if (!Object.Equals(null, objUserAnswerResultEN.UserId) && GetStrLen(objUserAnswerResultEN.UserId) > 20)
{
 throw new Exception("字段[用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objUserAnswerResultEN.AnswerText) && GetStrLen(objUserAnswerResultEN.AnswerText) > 8000)
{
 throw new Exception("字段[回答文本]的长度不能超过8000!");
}
if (!Object.Equals(null, objUserAnswerResultEN.AnswerDate) && GetStrLen(objUserAnswerResultEN.AnswerDate) > 8)
{
 throw new Exception("字段[回答日期]的长度不能超过8!");
}
if (!Object.Equals(null, objUserAnswerResultEN.AnswerTime) && GetStrLen(objUserAnswerResultEN.AnswerTime) > 10)
{
 throw new Exception("字段[回答时间]的长度不能超过10!");
}
if (!Object.Equals(null, objUserAnswerResultEN.AnswerIP) && GetStrLen(objUserAnswerResultEN.AnswerIP) > 30)
{
 throw new Exception("字段[回答IP]的长度不能超过30!");
}
if (!Object.Equals(null, objUserAnswerResultEN.id_School) && GetStrLen(objUserAnswerResultEN.id_School) > 4)
{
 throw new Exception("字段[学校流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objUserAnswerResultEN.School) && GetStrLen(objUserAnswerResultEN.School) > 50)
{
 throw new Exception("字段[School]的长度不能超过50!");
}
if (!Object.Equals(null, objUserAnswerResultEN.MarkTime) && GetStrLen(objUserAnswerResultEN.MarkTime) > 14)
{
 throw new Exception("字段[批改时间]的长度不能超过14!");
}
if (!Object.Equals(null, objUserAnswerResultEN.MarkerId) && GetStrLen(objUserAnswerResultEN.MarkerId) > 20)
{
 throw new Exception("字段[打分者]的长度不能超过20!");
}
if (!Object.Equals(null, objUserAnswerResultEN.UpdDate) && GetStrLen(objUserAnswerResultEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objUserAnswerResultEN.UpdUser) && GetStrLen(objUserAnswerResultEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objUserAnswerResultEN.Memo) && GetStrLen(objUserAnswerResultEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objUserAnswerResultEN.AnswerMultiOption) && GetStrLen(objUserAnswerResultEN.AnswerMultiOption) > 300)
{
 throw new Exception("字段[多选项答案]的长度不能超过300!");
}
 objUserAnswerResultEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngMinID">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserAnswerResultEN GetObjByMinID(long lngMinID)
{
string strAction = "GetObjByMinID";
string strErrMsg = string.Empty;
string strResult = "";
clsUserAnswerResultEN objUserAnswerResultEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MinID"] = lngMinID.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objUserAnswerResultEN = JsonConvert.DeserializeObject<clsUserAnswerResultEN>((string)jobjReturn["ReturnObj"]);
return objUserAnswerResultEN;
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
 /// <param name = "lngMinID">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserAnswerResultEN GetObjByMinID_WA_Cache(long lngMinID, string strCourseId)
{
string strAction = "GetObjByMinID_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsUserAnswerResultEN objUserAnswerResultEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MinID"] = lngMinID.ToString(),
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objUserAnswerResultEN = JsonConvert.DeserializeObject<clsUserAnswerResultEN>((string)jobjReturn["ReturnObj"]);
return objUserAnswerResultEN;
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
public static clsUserAnswerResultEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsUserAnswerResultEN objUserAnswerResultEN = null;
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
objUserAnswerResultEN = JsonConvert.DeserializeObject<clsUserAnswerResultEN>((string)jobjReturn["ReturnObj"]);
return objUserAnswerResultEN;
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
 /// <param name = "lngMinID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUserAnswerResultEN GetObjByMinID_Cache(long lngMinID, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsUserAnswerResultEN._CurrTabName_S, strCourseId);
List<clsUserAnswerResultEN> arrUserAnswerResultObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsUserAnswerResultEN> arrUserAnswerResultObjLst_Sel =
from objUserAnswerResultEN in arrUserAnswerResultObjLst_Cache
where objUserAnswerResultEN.MinID == lngMinID
select objUserAnswerResultEN;
if (arrUserAnswerResultObjLst_Sel.Count() == 0)
{
   clsUserAnswerResultEN obj = clsUserAnswerResultWApi.GetObjByMinID(lngMinID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrUserAnswerResultObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserAnswerResultEN> GetObjLst(string strWhereCond)
{
 List<clsUserAnswerResultEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserAnswerResultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsUserAnswerResultEN> GetObjLstByMinIDLst(List<long> arrMinID)
{
 List<clsUserAnswerResultEN> arrObjLst = null; 
string strAction = "GetObjLstByMinIDLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMinID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsUserAnswerResultEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngMinID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsUserAnswerResultEN> GetObjLstByMinIDLst_Cache(List<long> arrMinID, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsUserAnswerResultEN._CurrTabName_S, strCourseId);
List<clsUserAnswerResultEN> arrUserAnswerResultObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsUserAnswerResultEN> arrUserAnswerResultObjLst_Sel =
from objUserAnswerResultEN in arrUserAnswerResultObjLst_Cache
where arrMinID.Contains(objUserAnswerResultEN.MinID)
select objUserAnswerResultEN;
return arrUserAnswerResultObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserAnswerResultEN> GetObjLstByMinIDLst_WA_Cache(List<long> arrMinID, string strCourseId)
{
 List<clsUserAnswerResultEN> arrObjLst = null; 
string strAction = "GetObjLstByMinIDLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMinID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsUserAnswerResultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsUserAnswerResultEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsUserAnswerResultEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserAnswerResultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsUserAnswerResultEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsUserAnswerResultEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserAnswerResultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsUserAnswerResultEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsUserAnswerResultEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserAnswerResultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsUserAnswerResultEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsUserAnswerResultEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserAnswerResultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngMinID)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsUserAnswerResultEN objUserAnswerResultEN = clsUserAnswerResultWApi.GetObjByMinID(lngMinID);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngMinID.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsUserAnswerResultWApi.ReFreshCache(objUserAnswerResultEN.CourseId);
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
public static int DelUserAnswerResults(List<string> arrMinID)
{
string strAction = "DelUserAnswerResults";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMinID);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clsUserAnswerResultEN objUserAnswerResultEN = clsUserAnswerResultWApi.GetObjByMinID(long.Parse(arrMinID[0]));
clsUserAnswerResultWApi.ReFreshCache(objUserAnswerResultEN.CourseId);
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
public static int DelUserAnswerResultsByCond(string strWhereCond)
{
string strAction = "DelUserAnswerResultsByCond";
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
public static bool AddNewRecord(clsUserAnswerResultEN objUserAnswerResultEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserAnswerResultEN>(objUserAnswerResultEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserAnswerResultWApi.ReFreshCache(objUserAnswerResultEN.CourseId);
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsUserAnswerResultEN objUserAnswerResultEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserAnswerResultEN>(objUserAnswerResultEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserAnswerResultWApi.ReFreshCache(objUserAnswerResultEN.CourseId);
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsUserAnswerResultEN objUserAnswerResultEN)
{
if (string.IsNullOrEmpty(objUserAnswerResultEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objUserAnswerResultEN.MinID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserAnswerResultEN>(objUserAnswerResultEN);
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
 /// <param name = "objUserAnswerResultEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsUserAnswerResultEN objUserAnswerResultEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objUserAnswerResultEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objUserAnswerResultEN.MinID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objUserAnswerResultEN.MinID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserAnswerResultEN>(objUserAnswerResultEN);
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
public static bool IsExist(long lngMinID)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MinID"] = lngMinID.ToString()
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
 /// <param name = "objUserAnswerResultENS">源对象</param>
 /// <param name = "objUserAnswerResultENT">目标对象</param>
 public static void CopyTo(clsUserAnswerResultEN objUserAnswerResultENS, clsUserAnswerResultEN objUserAnswerResultENT)
{
try
{
objUserAnswerResultENT.MinID = objUserAnswerResultENS.MinID; //MinID
objUserAnswerResultENT.QuestionID = objUserAnswerResultENS.QuestionID; //题目ID
objUserAnswerResultENT.QuestionnaireSetId = objUserAnswerResultENS.QuestionnaireSetId; //问卷集ID
objUserAnswerResultENT.CourseId = objUserAnswerResultENS.CourseId; //课程Id
objUserAnswerResultENT.ExamBatchNo = objUserAnswerResultENS.ExamBatchNo; //学生批次号
objUserAnswerResultENT.CourseExamPaperId = objUserAnswerResultENS.CourseExamPaperId; //考卷流水号
objUserAnswerResultENT.AnswerOptionId = objUserAnswerResultENS.AnswerOptionId; //回答选项Id
objUserAnswerResultENT.BatchId = objUserAnswerResultENS.BatchId; //批次ID
objUserAnswerResultENT.UserId = objUserAnswerResultENS.UserId; //用户ID
objUserAnswerResultENT.AnswerText = objUserAnswerResultENS.AnswerText; //回答文本
objUserAnswerResultENT.AnswerDate = objUserAnswerResultENS.AnswerDate; //回答日期
objUserAnswerResultENT.AnswerTime = objUserAnswerResultENS.AnswerTime; //回答时间
objUserAnswerResultENT.AnswerIP = objUserAnswerResultENS.AnswerIP; //回答IP
objUserAnswerResultENT.IsAccess = objUserAnswerResultENS.IsAccess; //IsAccess
objUserAnswerResultENT.IsAccessC = objUserAnswerResultENS.IsAccessC; //IsAccessC
objUserAnswerResultENT.id_School = objUserAnswerResultENS.id_School; //学校流水号
objUserAnswerResultENT.School = objUserAnswerResultENS.School; //School
objUserAnswerResultENT.AnswerMode = objUserAnswerResultENS.AnswerMode; //AnswerMode
objUserAnswerResultENT.IsMarking = objUserAnswerResultENS.IsMarking; //是否批阅
objUserAnswerResultENT.IsRight = objUserAnswerResultENS.IsRight; //是否正确
objUserAnswerResultENT.Score = objUserAnswerResultENS.Score; //得分
objUserAnswerResultENT.MarkTime = objUserAnswerResultENS.MarkTime; //批改时间
objUserAnswerResultENT.MarkerId = objUserAnswerResultENS.MarkerId; //打分者
objUserAnswerResultENT.Comment = objUserAnswerResultENS.Comment; //批注
objUserAnswerResultENT.IsAccessKnowledge = objUserAnswerResultENS.IsAccessKnowledge; //是否处理知识点
objUserAnswerResultENT.UpdDate = objUserAnswerResultENS.UpdDate; //修改日期
objUserAnswerResultENT.UpdUser = objUserAnswerResultENS.UpdUser; //修改人
objUserAnswerResultENT.Memo = objUserAnswerResultENS.Memo; //备注
objUserAnswerResultENT.AnswerID = objUserAnswerResultENS.AnswerID; //问答ID
objUserAnswerResultENT.AnswerMultiOption = objUserAnswerResultENS.AnswerMultiOption; //多选项答案
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
public static DataTable ToDataTable(List<clsUserAnswerResultEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsUserAnswerResultEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsUserAnswerResultEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsUserAnswerResultEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsUserAnswerResultEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsUserAnswerResultEN.AttributeName)
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
if (clsUserAnswerResultWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserAnswerResultWApi没有刷新缓存机制(clsUserAnswerResultWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by MinID");
//if (arrUserAnswerResultObjLst_Cache == null)
//{
//arrUserAnswerResultObjLst_Cache = await clsUserAnswerResultWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsUserAnswerResultEN._CurrTabName_S, strCourseId);
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
public static void ReFreshCache(string strCourseId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsUserAnswerResultWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsUserAnswerResultEN._CurrTabName_S, strCourseId);
CacheHelper.Remove(strKey);
clsUserAnswerResultWApi.objCommFun4BL.ReFreshCache(strCourseId);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserAnswerResultEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsUserAnswerResultEN._CurrTabName_S, strCourseId);
List<clsUserAnswerResultEN> arrUserAnswerResultObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrUserAnswerResultObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsUserAnswerResultEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conUserAnswerResult.MinID, Type.GetType("System.Int64"));
objDT.Columns.Add(conUserAnswerResult.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(conUserAnswerResult.QuestionnaireSetId, Type.GetType("System.String"));
objDT.Columns.Add(conUserAnswerResult.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(conUserAnswerResult.ExamBatchNo, Type.GetType("System.String"));
objDT.Columns.Add(conUserAnswerResult.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(conUserAnswerResult.AnswerOptionId, Type.GetType("System.String"));
objDT.Columns.Add(conUserAnswerResult.BatchId, Type.GetType("System.String"));
objDT.Columns.Add(conUserAnswerResult.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conUserAnswerResult.AnswerText, Type.GetType("System.String"));
objDT.Columns.Add(conUserAnswerResult.AnswerDate, Type.GetType("System.String"));
objDT.Columns.Add(conUserAnswerResult.AnswerTime, Type.GetType("System.String"));
objDT.Columns.Add(conUserAnswerResult.AnswerIP, Type.GetType("System.String"));
objDT.Columns.Add(conUserAnswerResult.IsAccess, Type.GetType("System.Boolean"));
objDT.Columns.Add(conUserAnswerResult.IsAccessC, Type.GetType("System.Boolean"));
objDT.Columns.Add(conUserAnswerResult.id_School, Type.GetType("System.String"));
objDT.Columns.Add(conUserAnswerResult.School, Type.GetType("System.String"));
objDT.Columns.Add(conUserAnswerResult.AnswerMode, Type.GetType("System.Int32"));
objDT.Columns.Add(conUserAnswerResult.IsMarking, Type.GetType("System.Boolean"));
objDT.Columns.Add(conUserAnswerResult.IsRight, Type.GetType("System.Boolean"));
objDT.Columns.Add(conUserAnswerResult.Score, Type.GetType("System.Decimal"));
objDT.Columns.Add(conUserAnswerResult.MarkTime, Type.GetType("System.String"));
objDT.Columns.Add(conUserAnswerResult.MarkerId, Type.GetType("System.String"));
objDT.Columns.Add(conUserAnswerResult.Comment, Type.GetType("System.String"));
objDT.Columns.Add(conUserAnswerResult.IsAccessKnowledge, Type.GetType("System.Boolean"));
objDT.Columns.Add(conUserAnswerResult.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conUserAnswerResult.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conUserAnswerResult.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conUserAnswerResult.AnswerID, Type.GetType("System.Int64"));
objDT.Columns.Add(conUserAnswerResult.AnswerMultiOption, Type.GetType("System.String"));
foreach (clsUserAnswerResultEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conUserAnswerResult.MinID] = objInFor[conUserAnswerResult.MinID];
objDR[conUserAnswerResult.QuestionID] = objInFor[conUserAnswerResult.QuestionID];
objDR[conUserAnswerResult.QuestionnaireSetId] = objInFor[conUserAnswerResult.QuestionnaireSetId];
objDR[conUserAnswerResult.CourseId] = objInFor[conUserAnswerResult.CourseId];
objDR[conUserAnswerResult.ExamBatchNo] = objInFor[conUserAnswerResult.ExamBatchNo];
objDR[conUserAnswerResult.CourseExamPaperId] = objInFor[conUserAnswerResult.CourseExamPaperId];
objDR[conUserAnswerResult.AnswerOptionId] = objInFor[conUserAnswerResult.AnswerOptionId];
objDR[conUserAnswerResult.BatchId] = objInFor[conUserAnswerResult.BatchId];
objDR[conUserAnswerResult.UserId] = objInFor[conUserAnswerResult.UserId];
objDR[conUserAnswerResult.AnswerText] = objInFor[conUserAnswerResult.AnswerText];
objDR[conUserAnswerResult.AnswerDate] = objInFor[conUserAnswerResult.AnswerDate];
objDR[conUserAnswerResult.AnswerTime] = objInFor[conUserAnswerResult.AnswerTime];
objDR[conUserAnswerResult.AnswerIP] = objInFor[conUserAnswerResult.AnswerIP];
objDR[conUserAnswerResult.IsAccess] = objInFor[conUserAnswerResult.IsAccess];
objDR[conUserAnswerResult.IsAccessC] = objInFor[conUserAnswerResult.IsAccessC];
objDR[conUserAnswerResult.id_School] = objInFor[conUserAnswerResult.id_School];
objDR[conUserAnswerResult.School] = objInFor[conUserAnswerResult.School];
objDR[conUserAnswerResult.AnswerMode] = objInFor[conUserAnswerResult.AnswerMode];
objDR[conUserAnswerResult.IsMarking] = objInFor[conUserAnswerResult.IsMarking];
objDR[conUserAnswerResult.IsRight] = objInFor[conUserAnswerResult.IsRight];
objDR[conUserAnswerResult.Score] = objInFor[conUserAnswerResult.Score];
objDR[conUserAnswerResult.MarkTime] = objInFor[conUserAnswerResult.MarkTime];
objDR[conUserAnswerResult.MarkerId] = objInFor[conUserAnswerResult.MarkerId];
objDR[conUserAnswerResult.Comment] = objInFor[conUserAnswerResult.Comment];
objDR[conUserAnswerResult.IsAccessKnowledge] = objInFor[conUserAnswerResult.IsAccessKnowledge];
objDR[conUserAnswerResult.UpdDate] = objInFor[conUserAnswerResult.UpdDate];
objDR[conUserAnswerResult.UpdUser] = objInFor[conUserAnswerResult.UpdUser];
objDR[conUserAnswerResult.Memo] = objInFor[conUserAnswerResult.Memo];
objDR[conUserAnswerResult.AnswerID] = objInFor[conUserAnswerResult.AnswerID];
objDR[conUserAnswerResult.AnswerMultiOption] = objInFor[conUserAnswerResult.AnswerMultiOption];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 用户答题结果(UserAnswerResult)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4UserAnswerResult : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId)
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
clsUserAnswerResultWApi.ReFreshThisCache(strCourseId);
clsvUserAnswerResultWApi.ReFreshThisCache(strCourseId);
}
}

}