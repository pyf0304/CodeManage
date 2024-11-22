
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionnaireWApi
 表名:Questionnaire(01120001)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:40:01
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护
 模块英文名:QuestionaireEdit
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
public static class clsQuestionnaireWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetQuestionID(this clsQuestionnaireEN objQuestionnaireEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, conQuestionnaire.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, conQuestionnaire.QuestionID);
objQuestionnaireEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.QuestionID) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.QuestionID, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.QuestionID] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetQuestionIndex(this clsQuestionnaireEN objQuestionnaireEN, int intQuestionIndex, string strComparisonOp="")
	{
objQuestionnaireEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.QuestionIndex) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.QuestionIndex, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.QuestionIndex] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetQuestionName(this clsQuestionnaireEN objQuestionnaireEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionName, conQuestionnaire.QuestionName);
clsCheckSql.CheckFieldLen(strQuestionName, 1000, conQuestionnaire.QuestionName);
objQuestionnaireEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.QuestionName) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.QuestionName, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.QuestionName] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetQuestionContent(this clsQuestionnaireEN objQuestionnaireEN, string strQuestionContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, conQuestionnaire.QuestionContent);
objQuestionnaireEN.QuestionContent = strQuestionContent; //题目内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.QuestionContent) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.QuestionContent, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.QuestionContent] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetQuestionMemo(this clsQuestionnaireEN objQuestionnaireEN, string strQuestionMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionMemo, 1000, conQuestionnaire.QuestionMemo);
objQuestionnaireEN.QuestionMemo = strQuestionMemo; //题目说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.QuestionMemo) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.QuestionMemo, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.QuestionMemo] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetQuestionNo(this clsQuestionnaireEN objQuestionnaireEN, string strQuestionNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, conQuestionnaire.QuestionNo);
objQuestionnaireEN.QuestionNo = strQuestionNo; //题目编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.QuestionNo) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.QuestionNo, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.QuestionNo] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetParentQuestionId(this clsQuestionnaireEN objQuestionnaireEN, string strParentQuestionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentQuestionId, 8, conQuestionnaire.ParentQuestionId);
clsCheckSql.CheckFieldForeignKey(strParentQuestionId, 8, conQuestionnaire.ParentQuestionId);
objQuestionnaireEN.ParentQuestionId = strParentQuestionId; //父题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.ParentQuestionId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.ParentQuestionId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.ParentQuestionId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetExamAnswer(this clsQuestionnaireEN objQuestionnaireEN, string strExamAnswer, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamAnswer, 8000, conQuestionnaire.ExamAnswer);
objQuestionnaireEN.ExamAnswer = strExamAnswer; //题目答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.ExamAnswer) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.ExamAnswer, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.ExamAnswer] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetCourseId(this clsQuestionnaireEN objQuestionnaireEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conQuestionnaire.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, conQuestionnaire.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conQuestionnaire.CourseId);
objQuestionnaireEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.CourseId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.CourseId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.CourseId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetLevelNo(this clsQuestionnaireEN objQuestionnaireEN, int intLevelNo, string strComparisonOp="")
	{
objQuestionnaireEN.LevelNo = intLevelNo; //学习关号2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.LevelNo) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.LevelNo, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.LevelNo] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetCourseChapterId(this clsQuestionnaireEN objQuestionnaireEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, conQuestionnaire.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, conQuestionnaire.CourseChapterId);
objQuestionnaireEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.CourseChapterId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.CourseChapterId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.CourseChapterId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetQuestionTypeId(this clsQuestionnaireEN objQuestionnaireEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, conQuestionnaire.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, conQuestionnaire.QuestionTypeId);
objQuestionnaireEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.QuestionTypeId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.QuestionTypeId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.QuestionTypeId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetQuestionTypeId4Course(this clsQuestionnaireEN objQuestionnaireEN, string strQuestionTypeId4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId4Course, 8, conQuestionnaire.QuestionTypeId4Course);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId4Course, 8, conQuestionnaire.QuestionTypeId4Course);
objQuestionnaireEN.QuestionTypeId4Course = strQuestionTypeId4Course; //题目类型Id4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.QuestionTypeId4Course) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.QuestionTypeId4Course, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.QuestionTypeId4Course] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetAnswerTypeId(this clsQuestionnaireEN objQuestionnaireEN, string strAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, conQuestionnaire.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, conQuestionnaire.AnswerTypeId);
objQuestionnaireEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.AnswerTypeId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.AnswerTypeId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.AnswerTypeId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetGridTitle(this clsQuestionnaireEN objQuestionnaireEN, string strGridTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGridTitle, 30, conQuestionnaire.GridTitle);
objQuestionnaireEN.GridTitle = strGridTitle; //表格标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.GridTitle) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.GridTitle, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.GridTitle] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetAnswerModeId(this clsQuestionnaireEN objQuestionnaireEN, string strAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, conQuestionnaire.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, conQuestionnaire.AnswerModeId);
objQuestionnaireEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.AnswerModeId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.AnswerModeId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.AnswerModeId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetIsHaveAdditionalMemo(this clsQuestionnaireEN objQuestionnaireEN, bool bolIsHaveAdditionalMemo, string strComparisonOp="")
	{
objQuestionnaireEN.IsHaveAdditionalMemo = bolIsHaveAdditionalMemo; //是否有附加说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.IsHaveAdditionalMemo) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.IsHaveAdditionalMemo, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.IsHaveAdditionalMemo] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetQuestionScore(this clsQuestionnaireEN objQuestionnaireEN, float fltQuestionScore, string strComparisonOp="")
	{
objQuestionnaireEN.QuestionScore = fltQuestionScore; //题目得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.QuestionScore) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.QuestionScore, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.QuestionScore] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetDefaultValue(this clsQuestionnaireEN objQuestionnaireEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, conQuestionnaire.DefaultValue);
objQuestionnaireEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.DefaultValue) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.DefaultValue, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.DefaultValue] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetDefaultSelectItem(this clsQuestionnaireEN objQuestionnaireEN, string strDefaultSelectItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultSelectItem, 20, conQuestionnaire.DefaultSelectItem);
objQuestionnaireEN.DefaultSelectItem = strDefaultSelectItem; //默认选项
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.DefaultSelectItem) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.DefaultSelectItem, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.DefaultSelectItem] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetIsShow(this clsQuestionnaireEN objQuestionnaireEN, bool bolIsShow, string strComparisonOp="")
	{
objQuestionnaireEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.IsShow) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.IsShow, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.IsShow] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetIsCast(this clsQuestionnaireEN objQuestionnaireEN, bool bolIsCast, string strComparisonOp="")
	{
objQuestionnaireEN.IsCast = bolIsCast; //是否播放
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.IsCast) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.IsCast, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.IsCast] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetLikeCount(this clsQuestionnaireEN objQuestionnaireEN, long lngLikeCount, string strComparisonOp="")
	{
objQuestionnaireEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.LikeCount) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.LikeCount, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.LikeCount] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetAnswerAttLimitSize(this clsQuestionnaireEN objQuestionnaireEN, long lngAnswerAttLimitSize, string strComparisonOp="")
	{
objQuestionnaireEN.AnswerAttLimitSize = lngAnswerAttLimitSize; //回答附件限制大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.AnswerAttLimitSize) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.AnswerAttLimitSize, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.AnswerAttLimitSize] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetLimitedResourceType(this clsQuestionnaireEN objQuestionnaireEN, string strLimitedResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLimitedResourceType, 100, conQuestionnaire.LimitedResourceType);
objQuestionnaireEN.LimitedResourceType = strLimitedResourceType; //限制资源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.LimitedResourceType) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.LimitedResourceType, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.LimitedResourceType] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetIsEffective(this clsQuestionnaireEN objQuestionnaireEN, bool bolIsEffective, string strComparisonOp="")
	{
objQuestionnaireEN.IsEffective = bolIsEffective; //是否有效
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.IsEffective) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.IsEffective, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.IsEffective] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetIsCanInPaper(this clsQuestionnaireEN objQuestionnaireEN, bool bolIsCanInPaper, string strComparisonOp="")
	{
objQuestionnaireEN.IsCanInPaper = bolIsCanInPaper; //是否可在Paper
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.IsCanInPaper) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.IsCanInPaper, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.IsCanInPaper] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetExamGradeId(this clsQuestionnaireEN objQuestionnaireEN, string strExamGradeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamGradeId, 2, conQuestionnaire.ExamGradeId);
clsCheckSql.CheckFieldForeignKey(strExamGradeId, 2, conQuestionnaire.ExamGradeId);
objQuestionnaireEN.ExamGradeId = strExamGradeId; //题库等级ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.ExamGradeId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.ExamGradeId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.ExamGradeId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetTextDirectId(this clsQuestionnaireEN objQuestionnaireEN, string strTextDirectId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTextDirectId, 4, conQuestionnaire.TextDirectId);
clsCheckSql.CheckFieldForeignKey(strTextDirectId, 4, conQuestionnaire.TextDirectId);
objQuestionnaireEN.TextDirectId = strTextDirectId; //文本方向ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.TextDirectId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.TextDirectId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.TextDirectId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetUpdDate(this clsQuestionnaireEN objQuestionnaireEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conQuestionnaire.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQuestionnaire.UpdDate);
objQuestionnaireEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.UpdDate) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.UpdDate, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.UpdDate] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetUpdUser(this clsQuestionnaireEN objQuestionnaireEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conQuestionnaire.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQuestionnaire.UpdUser);
objQuestionnaireEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.UpdUser) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.UpdUser, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.UpdUser] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetMemo(this clsQuestionnaireEN objQuestionnaireEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQuestionnaire.Memo);
objQuestionnaireEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.Memo) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.Memo, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.Memo] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetQuestionCode(this clsQuestionnaireEN objQuestionnaireEN, string strQuestionCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionCode, 8000, conQuestionnaire.QuestionCode);
objQuestionnaireEN.QuestionCode = strQuestionCode; //html代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.QuestionCode) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.QuestionCode, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.QuestionCode] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetDifficultyLevelId(this clsQuestionnaireEN objQuestionnaireEN, string strDifficultyLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDifficultyLevelId, 2, conQuestionnaire.DifficultyLevelId);
clsCheckSql.CheckFieldForeignKey(strDifficultyLevelId, 2, conQuestionnaire.DifficultyLevelId);
objQuestionnaireEN.DifficultyLevelId = strDifficultyLevelId; //难度等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.DifficultyLevelId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.DifficultyLevelId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.DifficultyLevelId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetSectionTypeId(this clsQuestionnaireEN objQuestionnaireEN, string strSectionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionTypeId, 8, conQuestionnaire.SectionTypeId);
clsCheckSql.CheckFieldForeignKey(strSectionTypeId, 8, conQuestionnaire.SectionTypeId);
objQuestionnaireEN.SectionTypeId = strSectionTypeId; //节点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.SectionTypeId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.SectionTypeId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.SectionTypeId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetKnowledgeGraphId(this clsQuestionnaireEN objQuestionnaireEN, string strKnowledgeGraphId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKnowledgeGraphId, 10, conQuestionnaire.KnowledgeGraphId);
clsCheckSql.CheckFieldForeignKey(strKnowledgeGraphId, 10, conQuestionnaire.KnowledgeGraphId);
objQuestionnaireEN.KnowledgeGraphId = strKnowledgeGraphId; //知识点图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.KnowledgeGraphId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.KnowledgeGraphId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.KnowledgeGraphId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetFirstIndent(this clsQuestionnaireEN objQuestionnaireEN, bool bolFirstIndent, string strComparisonOp="")
	{
objQuestionnaireEN.FirstIndent = bolFirstIndent; //首行缩进
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.FirstIndent) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.FirstIndent, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.FirstIndent] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetQuestionName_Add(this clsQuestionnaireEN objQuestionnaireEN, string strQuestionName_Add, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName_Add, 500, conQuestionnaire.QuestionName_Add);
objQuestionnaireEN.QuestionName_Add = strQuestionName_Add; //题目补充
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.QuestionName_Add) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.QuestionName_Add, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.QuestionName_Add] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetCodeTab(this clsQuestionnaireEN objQuestionnaireEN, string strCodeTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTab, 50, conQuestionnaire.CodeTab);
objQuestionnaireEN.CodeTab = strCodeTab; //代码表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.CodeTab) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.CodeTab, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.CodeTab] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetCodeTab_Code(this clsQuestionnaireEN objQuestionnaireEN, string strCodeTab_Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTab_Code, 50, conQuestionnaire.CodeTab_Code);
objQuestionnaireEN.CodeTab_Code = strCodeTab_Code; //CodeTab_Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.CodeTab_Code) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.CodeTab_Code, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.CodeTab_Code] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetCodeTab_Condition(this clsQuestionnaireEN objQuestionnaireEN, string strCodeTab_Condition, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTab_Condition, 200, conQuestionnaire.CodeTab_Condition);
objQuestionnaireEN.CodeTab_Condition = strCodeTab_Condition; //代码表_条件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.CodeTab_Condition) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.CodeTab_Condition, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.CodeTab_Condition] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetCodeTab_Name(this clsQuestionnaireEN objQuestionnaireEN, string strCodeTab_Name, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTab_Name, 50, conQuestionnaire.CodeTab_Name);
objQuestionnaireEN.CodeTab_Name = strCodeTab_Name; //CodeTab_Name
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.CodeTab_Name) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.CodeTab_Name, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.CodeTab_Name] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetFillInTextHeight(this clsQuestionnaireEN objQuestionnaireEN, int intFillInTextHeight, string strComparisonOp="")
	{
objQuestionnaireEN.FillInTextHeight = intFillInTextHeight; //填空框高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.FillInTextHeight) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.FillInTextHeight, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.FillInTextHeight] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetFillInTextWidth(this clsQuestionnaireEN objQuestionnaireEN, int intFillInTextWidth, string strComparisonOp="")
	{
objQuestionnaireEN.FillInTextWidth = intFillInTextWidth; //填空框宽度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.FillInTextWidth) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.FillInTextWidth, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.FillInTextWidth] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetIsMulti4FillInText(this clsQuestionnaireEN objQuestionnaireEN, bool bolIsMulti4FillInText, string strComparisonOp="")
	{
objQuestionnaireEN.IsMulti4FillInText = bolIsMulti4FillInText; //是否填空框多行
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.IsMulti4FillInText) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.IsMulti4FillInText, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.IsMulti4FillInText] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetCheckBoxLimitCount(this clsQuestionnaireEN objQuestionnaireEN, int intCheckBoxLimitCount, string strComparisonOp="")
	{
objQuestionnaireEN.CheckBoxLimitCount = intCheckBoxLimitCount; //复选框限制数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.CheckBoxLimitCount) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.CheckBoxLimitCount, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.CheckBoxLimitCount] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetIsJs(this clsQuestionnaireEN objQuestionnaireEN, bool bolIsJs, string strComparisonOp="")
	{
objQuestionnaireEN.IsJs = bolIsJs; //是否是JS
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.IsJs) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.IsJs, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.IsJs] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetMemoTextWidth(this clsQuestionnaireEN objQuestionnaireEN, int intMemoTextWidth, string strComparisonOp="")
	{
objQuestionnaireEN.MemoTextWidth = intMemoTextWidth; //备注框宽度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.MemoTextWidth) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.MemoTextWidth, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.MemoTextWidth] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetRelaEvent(this clsQuestionnaireEN objQuestionnaireEN, string strRelaEvent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaEvent, 4000, conQuestionnaire.RelaEvent);
objQuestionnaireEN.RelaEvent = strRelaEvent; //相关事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.RelaEvent) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.RelaEvent, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.RelaEvent] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetIsTest(this clsQuestionnaireEN objQuestionnaireEN, bool bolIsTest, string strComparisonOp="")
	{
objQuestionnaireEN.IsTest = bolIsTest; //是否测试
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.IsTest) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.IsTest, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.IsTest] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetLevelModeTypeId(this clsQuestionnaireEN objQuestionnaireEN, string strLevelModeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLevelModeTypeId, conQuestionnaire.LevelModeTypeId);
clsCheckSql.CheckFieldLen(strLevelModeTypeId, 2, conQuestionnaire.LevelModeTypeId);
clsCheckSql.CheckFieldForeignKey(strLevelModeTypeId, 2, conQuestionnaire.LevelModeTypeId);
objQuestionnaireEN.LevelModeTypeId = strLevelModeTypeId; //模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.LevelModeTypeId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.LevelModeTypeId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.LevelModeTypeId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireEN SetIsRandom(this clsQuestionnaireEN objQuestionnaireEN, bool bolIsRandom, string strComparisonOp="")
	{
objQuestionnaireEN.IsRandom = bolIsRandom; //是否随机
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.IsRandom) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.IsRandom, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.IsRandom] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQuestionnaireEN objQuestionnaire_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.QuestionID) == true)
{
string strComparisonOp_QuestionID = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.QuestionID, objQuestionnaire_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaire.QuestionIndex, objQuestionnaire_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.QuestionName) == true)
{
string strComparisonOp_QuestionName = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.QuestionName, objQuestionnaire_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.QuestionContent) == true)
{
string strComparisonOp_QuestionContent = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.QuestionContent, objQuestionnaire_Cond.QuestionContent, strComparisonOp_QuestionContent);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.QuestionMemo) == true)
{
string strComparisonOp_QuestionMemo = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.QuestionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.QuestionMemo, objQuestionnaire_Cond.QuestionMemo, strComparisonOp_QuestionMemo);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.QuestionNo) == true)
{
string strComparisonOp_QuestionNo = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.QuestionNo, objQuestionnaire_Cond.QuestionNo, strComparisonOp_QuestionNo);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.ParentQuestionId) == true)
{
string strComparisonOp_ParentQuestionId = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.ParentQuestionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.ParentQuestionId, objQuestionnaire_Cond.ParentQuestionId, strComparisonOp_ParentQuestionId);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.ExamAnswer) == true)
{
string strComparisonOp_ExamAnswer = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.ExamAnswer];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.ExamAnswer, objQuestionnaire_Cond.ExamAnswer, strComparisonOp_ExamAnswer);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.CourseId) == true)
{
string strComparisonOp_CourseId = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.CourseId, objQuestionnaire_Cond.CourseId, strComparisonOp_CourseId);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.LevelNo) == true)
{
string strComparisonOp_LevelNo = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.LevelNo];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaire.LevelNo, objQuestionnaire_Cond.LevelNo, strComparisonOp_LevelNo);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.CourseChapterId, objQuestionnaire_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.QuestionTypeId, objQuestionnaire_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.QuestionTypeId4Course) == true)
{
string strComparisonOp_QuestionTypeId4Course = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.QuestionTypeId4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.QuestionTypeId4Course, objQuestionnaire_Cond.QuestionTypeId4Course, strComparisonOp_QuestionTypeId4Course);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.AnswerTypeId) == true)
{
string strComparisonOp_AnswerTypeId = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.AnswerTypeId, objQuestionnaire_Cond.AnswerTypeId, strComparisonOp_AnswerTypeId);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.GridTitle) == true)
{
string strComparisonOp_GridTitle = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.GridTitle, objQuestionnaire_Cond.GridTitle, strComparisonOp_GridTitle);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.AnswerModeId) == true)
{
string strComparisonOp_AnswerModeId = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.AnswerModeId, objQuestionnaire_Cond.AnswerModeId, strComparisonOp_AnswerModeId);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.IsHaveAdditionalMemo) == true)
{
if (objQuestionnaire_Cond.IsHaveAdditionalMemo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaire.IsHaveAdditionalMemo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaire.IsHaveAdditionalMemo);
}
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.QuestionScore) == true)
{
string strComparisonOp_QuestionScore = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.QuestionScore];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaire.QuestionScore, objQuestionnaire_Cond.QuestionScore, strComparisonOp_QuestionScore);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.DefaultValue) == true)
{
string strComparisonOp_DefaultValue = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.DefaultValue, objQuestionnaire_Cond.DefaultValue, strComparisonOp_DefaultValue);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.DefaultSelectItem) == true)
{
string strComparisonOp_DefaultSelectItem = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.DefaultSelectItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.DefaultSelectItem, objQuestionnaire_Cond.DefaultSelectItem, strComparisonOp_DefaultSelectItem);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.IsShow) == true)
{
if (objQuestionnaire_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaire.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaire.IsShow);
}
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.IsCast) == true)
{
if (objQuestionnaire_Cond.IsCast == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaire.IsCast);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaire.IsCast);
}
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.LikeCount) == true)
{
string strComparisonOp_LikeCount = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaire.LikeCount, objQuestionnaire_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.AnswerAttLimitSize) == true)
{
string strComparisonOp_AnswerAttLimitSize = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.AnswerAttLimitSize];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaire.AnswerAttLimitSize, objQuestionnaire_Cond.AnswerAttLimitSize, strComparisonOp_AnswerAttLimitSize);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.LimitedResourceType) == true)
{
string strComparisonOp_LimitedResourceType = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.LimitedResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.LimitedResourceType, objQuestionnaire_Cond.LimitedResourceType, strComparisonOp_LimitedResourceType);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.IsEffective) == true)
{
if (objQuestionnaire_Cond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaire.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaire.IsEffective);
}
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.IsCanInPaper) == true)
{
if (objQuestionnaire_Cond.IsCanInPaper == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaire.IsCanInPaper);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaire.IsCanInPaper);
}
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.ExamGradeId) == true)
{
string strComparisonOp_ExamGradeId = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.ExamGradeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.ExamGradeId, objQuestionnaire_Cond.ExamGradeId, strComparisonOp_ExamGradeId);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.TextDirectId) == true)
{
string strComparisonOp_TextDirectId = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.TextDirectId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.TextDirectId, objQuestionnaire_Cond.TextDirectId, strComparisonOp_TextDirectId);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.UpdDate) == true)
{
string strComparisonOp_UpdDate = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.UpdDate, objQuestionnaire_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.UpdUser) == true)
{
string strComparisonOp_UpdUser = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.UpdUser, objQuestionnaire_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.Memo) == true)
{
string strComparisonOp_Memo = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.Memo, objQuestionnaire_Cond.Memo, strComparisonOp_Memo);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.QuestionCode) == true)
{
string strComparisonOp_QuestionCode = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.QuestionCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.QuestionCode, objQuestionnaire_Cond.QuestionCode, strComparisonOp_QuestionCode);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.DifficultyLevelId) == true)
{
string strComparisonOp_DifficultyLevelId = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.DifficultyLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.DifficultyLevelId, objQuestionnaire_Cond.DifficultyLevelId, strComparisonOp_DifficultyLevelId);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.SectionTypeId) == true)
{
string strComparisonOp_SectionTypeId = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.SectionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.SectionTypeId, objQuestionnaire_Cond.SectionTypeId, strComparisonOp_SectionTypeId);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.KnowledgeGraphId) == true)
{
string strComparisonOp_KnowledgeGraphId = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.KnowledgeGraphId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.KnowledgeGraphId, objQuestionnaire_Cond.KnowledgeGraphId, strComparisonOp_KnowledgeGraphId);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.FirstIndent) == true)
{
if (objQuestionnaire_Cond.FirstIndent == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaire.FirstIndent);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaire.FirstIndent);
}
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.QuestionName_Add) == true)
{
string strComparisonOp_QuestionName_Add = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.QuestionName_Add];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.QuestionName_Add, objQuestionnaire_Cond.QuestionName_Add, strComparisonOp_QuestionName_Add);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.CodeTab) == true)
{
string strComparisonOp_CodeTab = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.CodeTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.CodeTab, objQuestionnaire_Cond.CodeTab, strComparisonOp_CodeTab);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.CodeTab_Code) == true)
{
string strComparisonOp_CodeTab_Code = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.CodeTab_Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.CodeTab_Code, objQuestionnaire_Cond.CodeTab_Code, strComparisonOp_CodeTab_Code);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.CodeTab_Condition) == true)
{
string strComparisonOp_CodeTab_Condition = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.CodeTab_Condition];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.CodeTab_Condition, objQuestionnaire_Cond.CodeTab_Condition, strComparisonOp_CodeTab_Condition);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.CodeTab_Name) == true)
{
string strComparisonOp_CodeTab_Name = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.CodeTab_Name];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.CodeTab_Name, objQuestionnaire_Cond.CodeTab_Name, strComparisonOp_CodeTab_Name);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.FillInTextHeight) == true)
{
string strComparisonOp_FillInTextHeight = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.FillInTextHeight];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaire.FillInTextHeight, objQuestionnaire_Cond.FillInTextHeight, strComparisonOp_FillInTextHeight);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.FillInTextWidth) == true)
{
string strComparisonOp_FillInTextWidth = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.FillInTextWidth];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaire.FillInTextWidth, objQuestionnaire_Cond.FillInTextWidth, strComparisonOp_FillInTextWidth);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.IsMulti4FillInText) == true)
{
if (objQuestionnaire_Cond.IsMulti4FillInText == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaire.IsMulti4FillInText);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaire.IsMulti4FillInText);
}
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.CheckBoxLimitCount) == true)
{
string strComparisonOp_CheckBoxLimitCount = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.CheckBoxLimitCount];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaire.CheckBoxLimitCount, objQuestionnaire_Cond.CheckBoxLimitCount, strComparisonOp_CheckBoxLimitCount);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.IsJs) == true)
{
if (objQuestionnaire_Cond.IsJs == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaire.IsJs);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaire.IsJs);
}
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.MemoTextWidth) == true)
{
string strComparisonOp_MemoTextWidth = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.MemoTextWidth];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaire.MemoTextWidth, objQuestionnaire_Cond.MemoTextWidth, strComparisonOp_MemoTextWidth);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.RelaEvent) == true)
{
string strComparisonOp_RelaEvent = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.RelaEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.RelaEvent, objQuestionnaire_Cond.RelaEvent, strComparisonOp_RelaEvent);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.IsTest) == true)
{
if (objQuestionnaire_Cond.IsTest == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaire.IsTest);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaire.IsTest);
}
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.LevelModeTypeId) == true)
{
string strComparisonOp_LevelModeTypeId = objQuestionnaire_Cond.dicFldComparisonOp[conQuestionnaire.LevelModeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.LevelModeTypeId, objQuestionnaire_Cond.LevelModeTypeId, strComparisonOp_LevelModeTypeId);
}
if (objQuestionnaire_Cond.IsUpdated(conQuestionnaire.IsRandom) == true)
{
if (objQuestionnaire_Cond.IsRandom == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaire.IsRandom);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaire.IsRandom);
}
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionnaireEN objQuestionnaireEN)
{
 if (string.IsNullOrEmpty(objQuestionnaireEN.QuestionID) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQuestionnaireEN.sf_UpdFldSetStr = objQuestionnaireEN.getsf_UpdFldSetStr();
clsQuestionnaireWApi.CheckPropertyNew(objQuestionnaireEN); 
bool bolResult = clsQuestionnaireWApi.UpdateRecord(objQuestionnaireEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireWApi.ReFreshCache(objQuestionnaireEN.CourseId);
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
 /// 检查唯一性(Uniqueness)--Questionnaire(题目), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQuestionnaireEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_QuestionID(this clsQuestionnaireEN objQuestionnaireEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQuestionnaireEN == null) return "";
if (objQuestionnaireEN.QuestionID == null || objQuestionnaireEN.QuestionID == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objQuestionnaireEN.QuestionID);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("QuestionID !=  '{0}'", objQuestionnaireEN.QuestionID);
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objQuestionnaireEN.QuestionID);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQuestionnaireEN objQuestionnaireEN)
{
try
{
 if (string.IsNullOrEmpty(objQuestionnaireEN.QuestionID) == true || clsQuestionnaireWApi.IsExist(objQuestionnaireEN.QuestionID) == true)
 {
     objQuestionnaireEN.QuestionID = clsQuestionnaireWApi.GetMaxStrId();
 }
clsQuestionnaireWApi.CheckPropertyNew(objQuestionnaireEN); 
bool bolResult = clsQuestionnaireWApi.AddNewRecord(objQuestionnaireEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireWApi.ReFreshCache(objQuestionnaireEN.CourseId);
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
 /// <param name = "objQuestionnaireEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQuestionnaireEN objQuestionnaireEN)
{
try
{
clsQuestionnaireWApi.CheckPropertyNew(objQuestionnaireEN); 
string strQuestionID = clsQuestionnaireWApi.AddNewRecordWithMaxId(objQuestionnaireEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireWApi.ReFreshCache(objQuestionnaireEN.CourseId);
return strQuestionID;
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
 /// <param name = "objQuestionnaireEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionnaireEN objQuestionnaireEN, string strWhereCond)
{
try
{
clsQuestionnaireWApi.CheckPropertyNew(objQuestionnaireEN); 
bool bolResult = clsQuestionnaireWApi.UpdateWithCondition(objQuestionnaireEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireWApi.ReFreshCache(objQuestionnaireEN.CourseId);
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
 /// 题目(Questionnaire)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQuestionnaireWApi
{
private static readonly string mstrApiControllerName = "QuestionnaireApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clsQuestionnaireWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_QuestionID(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[题目]...","0");
List<clsQuestionnaireEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="QuestionID";
objDDL.DataTextField="QuestionName";
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
public static void BindCbo_QuestionID(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQuestionnaire.QuestionID); 
List<clsQuestionnaireEN> arrObjLst = clsQuestionnaireWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQuestionnaireEN objQuestionnaireEN = new clsQuestionnaireEN()
{
QuestionID = "0",
QuestionName = "选[题目]..."
};
arrObjLst.Insert(0, objQuestionnaireEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQuestionnaire.QuestionID;
objComboBox.DisplayMember = conQuestionnaire.QuestionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQuestionnaireEN objQuestionnaireEN)
{
if (!Object.Equals(null, objQuestionnaireEN.QuestionID) && GetStrLen(objQuestionnaireEN.QuestionID) > 8)
{
 throw new Exception("字段[题目ID]的长度不能超过8!");
}
if (!Object.Equals(null, objQuestionnaireEN.QuestionName) && GetStrLen(objQuestionnaireEN.QuestionName) > 1000)
{
 throw new Exception("字段[题目名称]的长度不能超过1000!");
}
if (!Object.Equals(null, objQuestionnaireEN.QuestionContent) && GetStrLen(objQuestionnaireEN.QuestionContent) > 4000)
{
 throw new Exception("字段[题目内容]的长度不能超过4000!");
}
if (!Object.Equals(null, objQuestionnaireEN.QuestionMemo) && GetStrLen(objQuestionnaireEN.QuestionMemo) > 1000)
{
 throw new Exception("字段[题目说明]的长度不能超过1000!");
}
if (!Object.Equals(null, objQuestionnaireEN.QuestionNo) && GetStrLen(objQuestionnaireEN.QuestionNo) > 10)
{
 throw new Exception("字段[题目编号]的长度不能超过10!");
}
if (!Object.Equals(null, objQuestionnaireEN.ParentQuestionId) && GetStrLen(objQuestionnaireEN.ParentQuestionId) > 8)
{
 throw new Exception("字段[父题目Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQuestionnaireEN.ExamAnswer) && GetStrLen(objQuestionnaireEN.ExamAnswer) > 8000)
{
 throw new Exception("字段[题目答案]的长度不能超过8000!");
}
if (!Object.Equals(null, objQuestionnaireEN.CourseId) && GetStrLen(objQuestionnaireEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQuestionnaireEN.CourseChapterId) && GetStrLen(objQuestionnaireEN.CourseChapterId) > 8)
{
 throw new Exception("字段[课程章节ID]的长度不能超过8!");
}
if (!Object.Equals(null, objQuestionnaireEN.QuestionTypeId) && GetStrLen(objQuestionnaireEN.QuestionTypeId) > 2)
{
 throw new Exception("字段[题目类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objQuestionnaireEN.QuestionTypeId4Course) && GetStrLen(objQuestionnaireEN.QuestionTypeId4Course) > 8)
{
 throw new Exception("字段[题目类型Id4课程]的长度不能超过8!");
}
if (!Object.Equals(null, objQuestionnaireEN.AnswerTypeId) && GetStrLen(objQuestionnaireEN.AnswerTypeId) > 2)
{
 throw new Exception("字段[答案类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objQuestionnaireEN.GridTitle) && GetStrLen(objQuestionnaireEN.GridTitle) > 30)
{
 throw new Exception("字段[表格标题]的长度不能超过30!");
}
if (!Object.Equals(null, objQuestionnaireEN.AnswerModeId) && GetStrLen(objQuestionnaireEN.AnswerModeId) > 4)
{
 throw new Exception("字段[答案模式Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQuestionnaireEN.DefaultValue) && GetStrLen(objQuestionnaireEN.DefaultValue) > 50)
{
 throw new Exception("字段[缺省值]的长度不能超过50!");
}
if (!Object.Equals(null, objQuestionnaireEN.DefaultSelectItem) && GetStrLen(objQuestionnaireEN.DefaultSelectItem) > 20)
{
 throw new Exception("字段[默认选项]的长度不能超过20!");
}
if (!Object.Equals(null, objQuestionnaireEN.LimitedResourceType) && GetStrLen(objQuestionnaireEN.LimitedResourceType) > 100)
{
 throw new Exception("字段[限制资源类型]的长度不能超过100!");
}
if (!Object.Equals(null, objQuestionnaireEN.ExamGradeId) && GetStrLen(objQuestionnaireEN.ExamGradeId) > 2)
{
 throw new Exception("字段[题库等级ID]的长度不能超过2!");
}
if (!Object.Equals(null, objQuestionnaireEN.TextDirectId) && GetStrLen(objQuestionnaireEN.TextDirectId) > 4)
{
 throw new Exception("字段[文本方向ID]的长度不能超过4!");
}
if (!Object.Equals(null, objQuestionnaireEN.UpdDate) && GetStrLen(objQuestionnaireEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQuestionnaireEN.UpdUser) && GetStrLen(objQuestionnaireEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objQuestionnaireEN.Memo) && GetStrLen(objQuestionnaireEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objQuestionnaireEN.QuestionCode) && GetStrLen(objQuestionnaireEN.QuestionCode) > 8000)
{
 throw new Exception("字段[html代码]的长度不能超过8000!");
}
if (!Object.Equals(null, objQuestionnaireEN.DifficultyLevelId) && GetStrLen(objQuestionnaireEN.DifficultyLevelId) > 2)
{
 throw new Exception("字段[难度等级Id]的长度不能超过2!");
}
if (!Object.Equals(null, objQuestionnaireEN.SectionTypeId) && GetStrLen(objQuestionnaireEN.SectionTypeId) > 8)
{
 throw new Exception("字段[节点类型Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQuestionnaireEN.KnowledgeGraphId) && GetStrLen(objQuestionnaireEN.KnowledgeGraphId) > 10)
{
 throw new Exception("字段[知识点图Id]的长度不能超过10!");
}
if (!Object.Equals(null, objQuestionnaireEN.QuestionName_Add) && GetStrLen(objQuestionnaireEN.QuestionName_Add) > 500)
{
 throw new Exception("字段[题目补充]的长度不能超过500!");
}
if (!Object.Equals(null, objQuestionnaireEN.CodeTab) && GetStrLen(objQuestionnaireEN.CodeTab) > 50)
{
 throw new Exception("字段[代码表]的长度不能超过50!");
}
if (!Object.Equals(null, objQuestionnaireEN.CodeTab_Code) && GetStrLen(objQuestionnaireEN.CodeTab_Code) > 50)
{
 throw new Exception("字段[CodeTab_Code]的长度不能超过50!");
}
if (!Object.Equals(null, objQuestionnaireEN.CodeTab_Condition) && GetStrLen(objQuestionnaireEN.CodeTab_Condition) > 200)
{
 throw new Exception("字段[代码表_条件]的长度不能超过200!");
}
if (!Object.Equals(null, objQuestionnaireEN.CodeTab_Name) && GetStrLen(objQuestionnaireEN.CodeTab_Name) > 50)
{
 throw new Exception("字段[CodeTab_Name]的长度不能超过50!");
}
if (!Object.Equals(null, objQuestionnaireEN.RelaEvent) && GetStrLen(objQuestionnaireEN.RelaEvent) > 4000)
{
 throw new Exception("字段[相关事件]的长度不能超过4000!");
}
if (!Object.Equals(null, objQuestionnaireEN.LevelModeTypeId) && GetStrLen(objQuestionnaireEN.LevelModeTypeId) > 2)
{
 throw new Exception("字段[模式Id]的长度不能超过2!");
}
 objQuestionnaireEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQuestionID">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionnaireEN GetObjByQuestionID(string strQuestionID)
{
string strAction = "GetObjByQuestionID";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionnaireEN objQuestionnaireEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionID"] = strQuestionID
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objQuestionnaireEN = JsonConvert.DeserializeObject<clsQuestionnaireEN>((string)jobjReturn["ReturnObj"]);
return objQuestionnaireEN;
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
 /// <param name = "strQuestionID">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionnaireEN GetObjByQuestionID_WA_Cache(string strQuestionID, string strCourseId)
{
string strAction = "GetObjByQuestionID_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionnaireEN objQuestionnaireEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionID"] = strQuestionID,
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objQuestionnaireEN = JsonConvert.DeserializeObject<clsQuestionnaireEN>((string)jobjReturn["ReturnObj"]);
return objQuestionnaireEN;
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
public static clsQuestionnaireEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionnaireEN objQuestionnaireEN = null;
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
objQuestionnaireEN = JsonConvert.DeserializeObject<clsQuestionnaireEN>((string)jobjReturn["ReturnObj"]);
return objQuestionnaireEN;
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
 /// <param name = "strQuestionID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQuestionnaireEN GetObjByQuestionID_Cache(string strQuestionID, string strCourseId)
{
if (string.IsNullOrEmpty(strQuestionID) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsQuestionnaireEN._CurrTabName_S, strCourseId);
List<clsQuestionnaireEN> arrQuestionnaireObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsQuestionnaireEN> arrQuestionnaireObjLst_Sel =
from objQuestionnaireEN in arrQuestionnaireObjLst_Cache
where objQuestionnaireEN.QuestionID == strQuestionID
select objQuestionnaireEN;
if (arrQuestionnaireObjLst_Sel.Count() == 0)
{
   clsQuestionnaireEN obj = clsQuestionnaireWApi.GetObjByQuestionID(strQuestionID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrQuestionnaireObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strQuestionID">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetQuestionNameByQuestionID_Cache(string strQuestionID, string strCourseId)
{
if (string.IsNullOrEmpty(strQuestionID) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsQuestionnaireEN._CurrTabName_S, strCourseId);
List<clsQuestionnaireEN> arrQuestionnaireObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsQuestionnaireEN> arrQuestionnaireObjLst_Sel1 =
from objQuestionnaireEN in arrQuestionnaireObjLst_Cache
where objQuestionnaireEN.QuestionID == strQuestionID
select objQuestionnaireEN;
List <clsQuestionnaireEN> arrQuestionnaireObjLst_Sel = new List<clsQuestionnaireEN>();
foreach (clsQuestionnaireEN obj in arrQuestionnaireObjLst_Sel1)
{
arrQuestionnaireObjLst_Sel.Add(obj);
}
if (arrQuestionnaireObjLst_Sel.Count > 0)
{
return arrQuestionnaireObjLst_Sel[0].QuestionName;
}
string strErrMsgForGetObjById = string.Format("在Questionnaire对象缓存列表中,找不到记录[QuestionID = {0}](函数:{1})", strQuestionID, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQuestionnaireBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strQuestionID">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByQuestionID_Cache(string strQuestionID, string strCourseId)
{
if (string.IsNullOrEmpty(strQuestionID) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsQuestionnaireEN._CurrTabName_S, strCourseId);
List<clsQuestionnaireEN> arrQuestionnaireObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsQuestionnaireEN> arrQuestionnaireObjLst_Sel1 =
from objQuestionnaireEN in arrQuestionnaireObjLst_Cache
where objQuestionnaireEN.QuestionID == strQuestionID
select objQuestionnaireEN;
List <clsQuestionnaireEN> arrQuestionnaireObjLst_Sel = new List<clsQuestionnaireEN>();
foreach (clsQuestionnaireEN obj in arrQuestionnaireObjLst_Sel1)
{
arrQuestionnaireObjLst_Sel.Add(obj);
}
if (arrQuestionnaireObjLst_Sel.Count > 0)
{
return arrQuestionnaireObjLst_Sel[0].QuestionName;
}
string strErrMsgForGetObjById = string.Format("在Questionnaire对象缓存列表中,找不到记录的相关名称[QuestionID = {0}](函数:{1})", strQuestionID, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQuestionnaireBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionnaireEN> GetObjLst(string strWhereCond)
{
 List<clsQuestionnaireEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionnaireEN> GetObjLstByQuestionIDLst(List<string> arrQuestionID)
{
 List<clsQuestionnaireEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionIDLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strQuestionID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsQuestionnaireEN> GetObjLstByQuestionIDLst_Cache(List<string> arrQuestionID, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsQuestionnaireEN._CurrTabName_S, strCourseId);
List<clsQuestionnaireEN> arrQuestionnaireObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsQuestionnaireEN> arrQuestionnaireObjLst_Sel =
from objQuestionnaireEN in arrQuestionnaireObjLst_Cache
where arrQuestionID.Contains(objQuestionnaireEN.QuestionID)
select objQuestionnaireEN;
return arrQuestionnaireObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionnaireEN> GetObjLstByQuestionIDLst_WA_Cache(List<string> arrQuestionID, string strCourseId)
{
 List<clsQuestionnaireEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionIDLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionnaireEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQuestionnaireEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionnaireEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQuestionnaireEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionnaireEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQuestionnaireEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionnaireEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsQuestionnaireEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strQuestionID)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsQuestionnaireEN objQuestionnaireEN = clsQuestionnaireWApi.GetObjByQuestionID(strQuestionID);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strQuestionID.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsQuestionnaireWApi.ReFreshCache(objQuestionnaireEN.CourseId);
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
public static int DelQuestionnaires(List<string> arrQuestionID)
{
string strAction = "DelQuestionnaires";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionID);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clsQuestionnaireEN objQuestionnaireEN = clsQuestionnaireWApi.GetObjByQuestionID(arrQuestionID[0]);
clsQuestionnaireWApi.ReFreshCache(objQuestionnaireEN.CourseId);
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
public static int DelQuestionnairesByCond(string strWhereCond)
{
string strAction = "DelQuestionnairesByCond";
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
public static bool AddNewRecord(clsQuestionnaireEN objQuestionnaireEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionnaireEN>(objQuestionnaireEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireWApi.ReFreshCache(objQuestionnaireEN.CourseId);
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
public static string AddNewRecordWithMaxId(clsQuestionnaireEN objQuestionnaireEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionnaireEN>(objQuestionnaireEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireWApi.ReFreshCache(objQuestionnaireEN.CourseId);
var strQuestionID = (string)jobjReturn["ReturnStr"];
return strQuestionID;
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
public static bool UpdateRecord(clsQuestionnaireEN objQuestionnaireEN)
{
if (string.IsNullOrEmpty(objQuestionnaireEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionnaireEN.QuestionID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionnaireEN>(objQuestionnaireEN);
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
 /// <param name = "objQuestionnaireEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQuestionnaireEN objQuestionnaireEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQuestionnaireEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionnaireEN.QuestionID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionnaireEN.QuestionID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionnaireEN>(objQuestionnaireEN);
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
public static bool IsExist(string strQuestionID)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionID"] = strQuestionID
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
 /// <param name = "objQuestionnaireENS">源对象</param>
 /// <param name = "objQuestionnaireENT">目标对象</param>
 public static void CopyTo(clsQuestionnaireEN objQuestionnaireENS, clsQuestionnaireEN objQuestionnaireENT)
{
try
{
objQuestionnaireENT.QuestionID = objQuestionnaireENS.QuestionID; //题目ID
objQuestionnaireENT.QuestionIndex = objQuestionnaireENS.QuestionIndex; //题目序号
objQuestionnaireENT.QuestionName = objQuestionnaireENS.QuestionName; //题目名称
objQuestionnaireENT.QuestionContent = objQuestionnaireENS.QuestionContent; //题目内容
objQuestionnaireENT.QuestionMemo = objQuestionnaireENS.QuestionMemo; //题目说明
objQuestionnaireENT.QuestionNo = objQuestionnaireENS.QuestionNo; //题目编号
objQuestionnaireENT.ParentQuestionId = objQuestionnaireENS.ParentQuestionId; //父题目Id
objQuestionnaireENT.ExamAnswer = objQuestionnaireENS.ExamAnswer; //题目答案
objQuestionnaireENT.CourseId = objQuestionnaireENS.CourseId; //课程Id
objQuestionnaireENT.LevelNo = objQuestionnaireENS.LevelNo; //学习关号2
objQuestionnaireENT.CourseChapterId = objQuestionnaireENS.CourseChapterId; //课程章节ID
objQuestionnaireENT.QuestionTypeId = objQuestionnaireENS.QuestionTypeId; //题目类型Id
objQuestionnaireENT.QuestionTypeId4Course = objQuestionnaireENS.QuestionTypeId4Course; //题目类型Id4课程
objQuestionnaireENT.AnswerTypeId = objQuestionnaireENS.AnswerTypeId; //答案类型ID
objQuestionnaireENT.GridTitle = objQuestionnaireENS.GridTitle; //表格标题
objQuestionnaireENT.AnswerModeId = objQuestionnaireENS.AnswerModeId; //答案模式Id
objQuestionnaireENT.IsHaveAdditionalMemo = objQuestionnaireENS.IsHaveAdditionalMemo; //是否有附加说明
objQuestionnaireENT.QuestionScore = objQuestionnaireENS.QuestionScore; //题目得分
objQuestionnaireENT.DefaultValue = objQuestionnaireENS.DefaultValue; //缺省值
objQuestionnaireENT.DefaultSelectItem = objQuestionnaireENS.DefaultSelectItem; //默认选项
objQuestionnaireENT.IsShow = objQuestionnaireENS.IsShow; //是否启用
objQuestionnaireENT.IsCast = objQuestionnaireENS.IsCast; //是否播放
objQuestionnaireENT.LikeCount = objQuestionnaireENS.LikeCount; //资源喜欢数量
objQuestionnaireENT.AnswerAttLimitSize = objQuestionnaireENS.AnswerAttLimitSize; //回答附件限制大小
objQuestionnaireENT.LimitedResourceType = objQuestionnaireENS.LimitedResourceType; //限制资源类型
objQuestionnaireENT.IsEffective = objQuestionnaireENS.IsEffective; //是否有效
objQuestionnaireENT.IsCanInPaper = objQuestionnaireENS.IsCanInPaper; //是否可在Paper
objQuestionnaireENT.ExamGradeId = objQuestionnaireENS.ExamGradeId; //题库等级ID
objQuestionnaireENT.TextDirectId = objQuestionnaireENS.TextDirectId; //文本方向ID
objQuestionnaireENT.UpdDate = objQuestionnaireENS.UpdDate; //修改日期
objQuestionnaireENT.UpdUser = objQuestionnaireENS.UpdUser; //修改人
objQuestionnaireENT.Memo = objQuestionnaireENS.Memo; //备注
objQuestionnaireENT.QuestionCode = objQuestionnaireENS.QuestionCode; //html代码
objQuestionnaireENT.DifficultyLevelId = objQuestionnaireENS.DifficultyLevelId; //难度等级Id
objQuestionnaireENT.SectionTypeId = objQuestionnaireENS.SectionTypeId; //节点类型Id
objQuestionnaireENT.KnowledgeGraphId = objQuestionnaireENS.KnowledgeGraphId; //知识点图Id
objQuestionnaireENT.FirstIndent = objQuestionnaireENS.FirstIndent; //首行缩进
objQuestionnaireENT.QuestionName_Add = objQuestionnaireENS.QuestionName_Add; //题目补充
objQuestionnaireENT.CodeTab = objQuestionnaireENS.CodeTab; //代码表
objQuestionnaireENT.CodeTab_Code = objQuestionnaireENS.CodeTab_Code; //CodeTab_Code
objQuestionnaireENT.CodeTab_Condition = objQuestionnaireENS.CodeTab_Condition; //代码表_条件
objQuestionnaireENT.CodeTab_Name = objQuestionnaireENS.CodeTab_Name; //CodeTab_Name
objQuestionnaireENT.FillInTextHeight = objQuestionnaireENS.FillInTextHeight; //填空框高度
objQuestionnaireENT.FillInTextWidth = objQuestionnaireENS.FillInTextWidth; //填空框宽度
objQuestionnaireENT.IsMulti4FillInText = objQuestionnaireENS.IsMulti4FillInText; //是否填空框多行
objQuestionnaireENT.CheckBoxLimitCount = objQuestionnaireENS.CheckBoxLimitCount; //复选框限制数
objQuestionnaireENT.IsJs = objQuestionnaireENS.IsJs; //是否是JS
objQuestionnaireENT.MemoTextWidth = objQuestionnaireENS.MemoTextWidth; //备注框宽度
objQuestionnaireENT.RelaEvent = objQuestionnaireENS.RelaEvent; //相关事件
objQuestionnaireENT.IsTest = objQuestionnaireENS.IsTest; //是否测试
objQuestionnaireENT.LevelModeTypeId = objQuestionnaireENS.LevelModeTypeId; //模式Id
objQuestionnaireENT.IsRandom = objQuestionnaireENS.IsRandom; //是否随机
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
public static DataTable ToDataTable(List<clsQuestionnaireEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQuestionnaireEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQuestionnaireEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQuestionnaireEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQuestionnaireEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQuestionnaireEN.AttributeName)
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
if (clsQuestionnaireWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireWApi没有刷新缓存机制(clsQuestionnaireWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionID");
//if (arrQuestionnaireObjLst_Cache == null)
//{
//arrQuestionnaireObjLst_Cache = await clsQuestionnaireWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsQuestionnaireEN._CurrTabName_S, strCourseId);
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
if (clsQuestionnaireWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsQuestionnaireEN._CurrTabName_S, strCourseId);
CacheHelper.Remove(strKey);
clsQuestionnaireWApi.objCommFun4BL.ReFreshCache(strCourseId);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionnaireEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsQuestionnaireEN._CurrTabName_S, strCourseId);
List<clsQuestionnaireEN> arrQuestionnaireObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrQuestionnaireObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQuestionnaireEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQuestionnaire.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(conQuestionnaire.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.QuestionContent, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.QuestionMemo, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.QuestionNo, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.ParentQuestionId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.ExamAnswer, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.LevelNo, Type.GetType("System.Int32"));
objDT.Columns.Add(conQuestionnaire.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.QuestionTypeId4Course, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.AnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.GridTitle, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.AnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.IsHaveAdditionalMemo, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionnaire.QuestionScore, Type.GetType("System.Single"));
objDT.Columns.Add(conQuestionnaire.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.DefaultSelectItem, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionnaire.IsCast, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionnaire.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(conQuestionnaire.AnswerAttLimitSize, Type.GetType("System.Int64"));
objDT.Columns.Add(conQuestionnaire.LimitedResourceType, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.IsEffective, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionnaire.IsCanInPaper, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionnaire.ExamGradeId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.TextDirectId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.QuestionCode, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.DifficultyLevelId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.SectionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.KnowledgeGraphId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.FirstIndent, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionnaire.QuestionName_Add, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.CodeTab, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.CodeTab_Code, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.CodeTab_Condition, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.CodeTab_Name, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.FillInTextHeight, Type.GetType("System.Int32"));
objDT.Columns.Add(conQuestionnaire.FillInTextWidth, Type.GetType("System.Int32"));
objDT.Columns.Add(conQuestionnaire.IsMulti4FillInText, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionnaire.CheckBoxLimitCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conQuestionnaire.IsJs, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionnaire.MemoTextWidth, Type.GetType("System.Int32"));
objDT.Columns.Add(conQuestionnaire.RelaEvent, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.IsTest, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionnaire.LevelModeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaire.IsRandom, Type.GetType("System.Boolean"));
foreach (clsQuestionnaireEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQuestionnaire.QuestionID] = objInFor[conQuestionnaire.QuestionID];
objDR[conQuestionnaire.QuestionIndex] = objInFor[conQuestionnaire.QuestionIndex];
objDR[conQuestionnaire.QuestionName] = objInFor[conQuestionnaire.QuestionName];
objDR[conQuestionnaire.QuestionContent] = objInFor[conQuestionnaire.QuestionContent];
objDR[conQuestionnaire.QuestionMemo] = objInFor[conQuestionnaire.QuestionMemo];
objDR[conQuestionnaire.QuestionNo] = objInFor[conQuestionnaire.QuestionNo];
objDR[conQuestionnaire.ParentQuestionId] = objInFor[conQuestionnaire.ParentQuestionId];
objDR[conQuestionnaire.ExamAnswer] = objInFor[conQuestionnaire.ExamAnswer];
objDR[conQuestionnaire.CourseId] = objInFor[conQuestionnaire.CourseId];
objDR[conQuestionnaire.LevelNo] = objInFor[conQuestionnaire.LevelNo];
objDR[conQuestionnaire.CourseChapterId] = objInFor[conQuestionnaire.CourseChapterId];
objDR[conQuestionnaire.QuestionTypeId] = objInFor[conQuestionnaire.QuestionTypeId];
objDR[conQuestionnaire.QuestionTypeId4Course] = objInFor[conQuestionnaire.QuestionTypeId4Course];
objDR[conQuestionnaire.AnswerTypeId] = objInFor[conQuestionnaire.AnswerTypeId];
objDR[conQuestionnaire.GridTitle] = objInFor[conQuestionnaire.GridTitle];
objDR[conQuestionnaire.AnswerModeId] = objInFor[conQuestionnaire.AnswerModeId];
objDR[conQuestionnaire.IsHaveAdditionalMemo] = objInFor[conQuestionnaire.IsHaveAdditionalMemo];
objDR[conQuestionnaire.QuestionScore] = objInFor[conQuestionnaire.QuestionScore];
objDR[conQuestionnaire.DefaultValue] = objInFor[conQuestionnaire.DefaultValue];
objDR[conQuestionnaire.DefaultSelectItem] = objInFor[conQuestionnaire.DefaultSelectItem];
objDR[conQuestionnaire.IsShow] = objInFor[conQuestionnaire.IsShow];
objDR[conQuestionnaire.IsCast] = objInFor[conQuestionnaire.IsCast];
objDR[conQuestionnaire.LikeCount] = objInFor[conQuestionnaire.LikeCount];
objDR[conQuestionnaire.AnswerAttLimitSize] = objInFor[conQuestionnaire.AnswerAttLimitSize];
objDR[conQuestionnaire.LimitedResourceType] = objInFor[conQuestionnaire.LimitedResourceType];
objDR[conQuestionnaire.IsEffective] = objInFor[conQuestionnaire.IsEffective];
objDR[conQuestionnaire.IsCanInPaper] = objInFor[conQuestionnaire.IsCanInPaper];
objDR[conQuestionnaire.ExamGradeId] = objInFor[conQuestionnaire.ExamGradeId];
objDR[conQuestionnaire.TextDirectId] = objInFor[conQuestionnaire.TextDirectId];
objDR[conQuestionnaire.UpdDate] = objInFor[conQuestionnaire.UpdDate];
objDR[conQuestionnaire.UpdUser] = objInFor[conQuestionnaire.UpdUser];
objDR[conQuestionnaire.Memo] = objInFor[conQuestionnaire.Memo];
objDR[conQuestionnaire.QuestionCode] = objInFor[conQuestionnaire.QuestionCode];
objDR[conQuestionnaire.DifficultyLevelId] = objInFor[conQuestionnaire.DifficultyLevelId];
objDR[conQuestionnaire.SectionTypeId] = objInFor[conQuestionnaire.SectionTypeId];
objDR[conQuestionnaire.KnowledgeGraphId] = objInFor[conQuestionnaire.KnowledgeGraphId];
objDR[conQuestionnaire.FirstIndent] = objInFor[conQuestionnaire.FirstIndent];
objDR[conQuestionnaire.QuestionName_Add] = objInFor[conQuestionnaire.QuestionName_Add];
objDR[conQuestionnaire.CodeTab] = objInFor[conQuestionnaire.CodeTab];
objDR[conQuestionnaire.CodeTab_Code] = objInFor[conQuestionnaire.CodeTab_Code];
objDR[conQuestionnaire.CodeTab_Condition] = objInFor[conQuestionnaire.CodeTab_Condition];
objDR[conQuestionnaire.CodeTab_Name] = objInFor[conQuestionnaire.CodeTab_Name];
objDR[conQuestionnaire.FillInTextHeight] = objInFor[conQuestionnaire.FillInTextHeight];
objDR[conQuestionnaire.FillInTextWidth] = objInFor[conQuestionnaire.FillInTextWidth];
objDR[conQuestionnaire.IsMulti4FillInText] = objInFor[conQuestionnaire.IsMulti4FillInText];
objDR[conQuestionnaire.CheckBoxLimitCount] = objInFor[conQuestionnaire.CheckBoxLimitCount];
objDR[conQuestionnaire.IsJs] = objInFor[conQuestionnaire.IsJs];
objDR[conQuestionnaire.MemoTextWidth] = objInFor[conQuestionnaire.MemoTextWidth];
objDR[conQuestionnaire.RelaEvent] = objInFor[conQuestionnaire.RelaEvent];
objDR[conQuestionnaire.IsTest] = objInFor[conQuestionnaire.IsTest];
objDR[conQuestionnaire.LevelModeTypeId] = objInFor[conQuestionnaire.LevelModeTypeId];
objDR[conQuestionnaire.IsRandom] = objInFor[conQuestionnaire.IsRandom];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 题目(Questionnaire)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4Questionnaire : clsCommFun4BLV2
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
clsQuestionnaireWApi.ReFreshThisCache(strCourseId);
clsvQuestionnaireWApi.ReFreshThisCache(strCourseId);
clsvQuestionnaire_KnowledgeWApi.ReFreshThisCache(strCourseId);
clsvQuestionnaire4AppWApi.ReFreshThisCache(strCourseId);
clsvQuestionnaire4App_TWApi.ReFreshThisCache(strCourseId);
}
}

}