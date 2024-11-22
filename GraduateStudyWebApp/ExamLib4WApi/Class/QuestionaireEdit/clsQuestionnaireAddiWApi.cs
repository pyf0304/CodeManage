
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionnaireAddiWApi
 表名:QuestionnaireAddi(01120886)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:57
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
public static class clsQuestionnaireAddiWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetQuestionID(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, conQuestionnaireAddi.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, conQuestionnaireAddi.QuestionID);
objQuestionnaireAddiEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.QuestionID) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.QuestionID, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.QuestionID] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetQuestionIndex(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, int intQuestionIndex, string strComparisonOp="")
	{
objQuestionnaireAddiEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.QuestionIndex) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.QuestionIndex, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.QuestionIndex] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetQuestionName(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionName, conQuestionnaireAddi.QuestionName);
clsCheckSql.CheckFieldLen(strQuestionName, 1000, conQuestionnaireAddi.QuestionName);
objQuestionnaireAddiEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.QuestionName) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.QuestionName, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.QuestionName] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetQuestionContent(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strQuestionContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, conQuestionnaireAddi.QuestionContent);
objQuestionnaireAddiEN.QuestionContent = strQuestionContent; //题目内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.QuestionContent) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.QuestionContent, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.QuestionContent] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetQuestionMemo(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strQuestionMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionMemo, 1000, conQuestionnaireAddi.QuestionMemo);
objQuestionnaireAddiEN.QuestionMemo = strQuestionMemo; //题目说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.QuestionMemo) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.QuestionMemo, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.QuestionMemo] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetQuestionNo(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strQuestionNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, conQuestionnaireAddi.QuestionNo);
objQuestionnaireAddiEN.QuestionNo = strQuestionNo; //题目编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.QuestionNo) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.QuestionNo, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.QuestionNo] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetParentQuestionId(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strParentQuestionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentQuestionId, 8, conQuestionnaireAddi.ParentQuestionId);
clsCheckSql.CheckFieldForeignKey(strParentQuestionId, 8, conQuestionnaireAddi.ParentQuestionId);
objQuestionnaireAddiEN.ParentQuestionId = strParentQuestionId; //父题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.ParentQuestionId) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.ParentQuestionId, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.ParentQuestionId] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetExamAnswer(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strExamAnswer, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamAnswer, 8000, conQuestionnaireAddi.ExamAnswer);
objQuestionnaireAddiEN.ExamAnswer = strExamAnswer; //题目答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.ExamAnswer) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.ExamAnswer, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.ExamAnswer] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetCourseId(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conQuestionnaireAddi.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, conQuestionnaireAddi.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conQuestionnaireAddi.CourseId);
objQuestionnaireAddiEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.CourseId) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.CourseId, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.CourseId] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetLevelNo(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, int intLevelNo, string strComparisonOp="")
	{
objQuestionnaireAddiEN.LevelNo = intLevelNo; //学习关号2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.LevelNo) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.LevelNo, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.LevelNo] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetCourseChapterId(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, conQuestionnaireAddi.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, conQuestionnaireAddi.CourseChapterId);
objQuestionnaireAddiEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.CourseChapterId) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.CourseChapterId, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.CourseChapterId] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetQuestionTypeId(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, conQuestionnaireAddi.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, conQuestionnaireAddi.QuestionTypeId);
objQuestionnaireAddiEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.QuestionTypeId) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.QuestionTypeId, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.QuestionTypeId] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetQuestionTypeId4Course(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strQuestionTypeId4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeId4Course, conQuestionnaireAddi.QuestionTypeId4Course);
clsCheckSql.CheckFieldLen(strQuestionTypeId4Course, 8, conQuestionnaireAddi.QuestionTypeId4Course);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId4Course, 8, conQuestionnaireAddi.QuestionTypeId4Course);
objQuestionnaireAddiEN.QuestionTypeId4Course = strQuestionTypeId4Course; //题目类型Id4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.QuestionTypeId4Course) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.QuestionTypeId4Course, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.QuestionTypeId4Course] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetExamGradeId(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strExamGradeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamGradeId, 2, conQuestionnaireAddi.ExamGradeId);
clsCheckSql.CheckFieldForeignKey(strExamGradeId, 2, conQuestionnaireAddi.ExamGradeId);
objQuestionnaireAddiEN.ExamGradeId = strExamGradeId; //题库等级ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.ExamGradeId) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.ExamGradeId, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.ExamGradeId] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetAnswerTypeId(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAnswerTypeId, conQuestionnaireAddi.AnswerTypeId);
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, conQuestionnaireAddi.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, conQuestionnaireAddi.AnswerTypeId);
objQuestionnaireAddiEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.AnswerTypeId) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.AnswerTypeId, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.AnswerTypeId] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetGridTitle(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strGridTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGridTitle, 30, conQuestionnaireAddi.GridTitle);
objQuestionnaireAddiEN.GridTitle = strGridTitle; //表格标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.GridTitle) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.GridTitle, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.GridTitle] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetAnswerModeId(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, conQuestionnaireAddi.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, conQuestionnaireAddi.AnswerModeId);
objQuestionnaireAddiEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.AnswerModeId) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.AnswerModeId, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.AnswerModeId] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetIsHaveAdditionalMemo(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, bool bolIsHaveAdditionalMemo, string strComparisonOp="")
	{
objQuestionnaireAddiEN.IsHaveAdditionalMemo = bolIsHaveAdditionalMemo; //是否有附加说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.IsHaveAdditionalMemo) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.IsHaveAdditionalMemo, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.IsHaveAdditionalMemo] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetQuestionnaireSetId(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strQuestionnaireSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionnaireSetId, 4, conQuestionnaireAddi.QuestionnaireSetId);
clsCheckSql.CheckFieldForeignKey(strQuestionnaireSetId, 4, conQuestionnaireAddi.QuestionnaireSetId);
objQuestionnaireAddiEN.QuestionnaireSetId = strQuestionnaireSetId; //问卷集ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.QuestionnaireSetId) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.QuestionnaireSetId, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.QuestionnaireSetId] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetQuestionScore(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, float fltQuestionScore, string strComparisonOp="")
	{
objQuestionnaireAddiEN.QuestionScore = fltQuestionScore; //题目得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.QuestionScore) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.QuestionScore, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.QuestionScore] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetQuestionName_Add(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strQuestionName_Add, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName_Add, 500, conQuestionnaireAddi.QuestionName_Add);
objQuestionnaireAddiEN.QuestionName_Add = strQuestionName_Add; //题目补充
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.QuestionName_Add) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.QuestionName_Add, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.QuestionName_Add] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetDefaultValue(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, conQuestionnaireAddi.DefaultValue);
objQuestionnaireAddiEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.DefaultValue) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.DefaultValue, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.DefaultValue] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetTextDirectId(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strTextDirectId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextDirectId, conQuestionnaireAddi.TextDirectId);
clsCheckSql.CheckFieldLen(strTextDirectId, 4, conQuestionnaireAddi.TextDirectId);
clsCheckSql.CheckFieldForeignKey(strTextDirectId, 4, conQuestionnaireAddi.TextDirectId);
objQuestionnaireAddiEN.TextDirectId = strTextDirectId; //文本方向ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.TextDirectId) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.TextDirectId, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.TextDirectId] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetFillInTextWidth(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, int intFillInTextWidth, string strComparisonOp="")
	{
objQuestionnaireAddiEN.FillInTextWidth = intFillInTextWidth; //填空框宽度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.FillInTextWidth) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.FillInTextWidth, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.FillInTextWidth] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetMemoTextWidth(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, int intMemoTextWidth, string strComparisonOp="")
	{
objQuestionnaireAddiEN.MemoTextWidth = intMemoTextWidth; //备注框宽度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.MemoTextWidth) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.MemoTextWidth, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.MemoTextWidth] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetCodeTab(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strCodeTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTab, 50, conQuestionnaireAddi.CodeTab);
objQuestionnaireAddiEN.CodeTab = strCodeTab; //代码表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.CodeTab) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.CodeTab, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.CodeTab] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetCodeTab_Code(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strCodeTab_Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTab_Code, 50, conQuestionnaireAddi.CodeTab_Code);
objQuestionnaireAddiEN.CodeTab_Code = strCodeTab_Code; //CodeTab_Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.CodeTab_Code) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.CodeTab_Code, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.CodeTab_Code] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetCodeTab_Name(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strCodeTab_Name, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTab_Name, 50, conQuestionnaireAddi.CodeTab_Name);
objQuestionnaireAddiEN.CodeTab_Name = strCodeTab_Name; //CodeTab_Name
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.CodeTab_Name) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.CodeTab_Name, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.CodeTab_Name] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetCodeTab_Condition(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strCodeTab_Condition, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTab_Condition, 200, conQuestionnaireAddi.CodeTab_Condition);
objQuestionnaireAddiEN.CodeTab_Condition = strCodeTab_Condition; //代码表_条件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.CodeTab_Condition) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.CodeTab_Condition, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.CodeTab_Condition] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetRelaEvent(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strRelaEvent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaEvent, 4000, conQuestionnaireAddi.RelaEvent);
objQuestionnaireAddiEN.RelaEvent = strRelaEvent; //相关事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.RelaEvent) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.RelaEvent, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.RelaEvent] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetFirstIndent(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, bool bolFirstIndent, string strComparisonOp="")
	{
objQuestionnaireAddiEN.FirstIndent = bolFirstIndent; //首行缩进
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.FirstIndent) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.FirstIndent, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.FirstIndent] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetDefaultSelectItem(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strDefaultSelectItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultSelectItem, 20, conQuestionnaireAddi.DefaultSelectItem);
objQuestionnaireAddiEN.DefaultSelectItem = strDefaultSelectItem; //默认选项
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.DefaultSelectItem) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.DefaultSelectItem, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.DefaultSelectItem] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetIfLinkage(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, bool bolIfLinkage, string strComparisonOp="")
	{
objQuestionnaireAddiEN.IfLinkage = bolIfLinkage; //是否联动
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.IfLinkage) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.IfLinkage, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.IfLinkage] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetLinkageIndex(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, int intLinkageIndex, string strComparisonOp="")
	{
objQuestionnaireAddiEN.LinkageIndex = intLinkageIndex; //联动题序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.LinkageIndex) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.LinkageIndex, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.LinkageIndex] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetIsAutoGridTitle(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, bool bolIsAutoGridTitle, string strComparisonOp="")
	{
objQuestionnaireAddiEN.IsAutoGridTitle = bolIsAutoGridTitle; //是否自动编表格标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.IsAutoGridTitle) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.IsAutoGridTitle, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.IsAutoGridTitle] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetFillInTextHeight(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, int intFillInTextHeight, string strComparisonOp="")
	{
objQuestionnaireAddiEN.FillInTextHeight = intFillInTextHeight; //填空框高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.FillInTextHeight) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.FillInTextHeight, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.FillInTextHeight] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetIsMulti4FillInText(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, bool bolIsMulti4FillInText, string strComparisonOp="")
	{
objQuestionnaireAddiEN.IsMulti4FillInText = bolIsMulti4FillInText; //是否填空框多行
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.IsMulti4FillInText) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.IsMulti4FillInText, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.IsMulti4FillInText] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetCheckBoxLimitCount(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, int intCheckBoxLimitCount, string strComparisonOp="")
	{
objQuestionnaireAddiEN.CheckBoxLimitCount = intCheckBoxLimitCount; //复选框限制数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.CheckBoxLimitCount) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.CheckBoxLimitCount, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.CheckBoxLimitCount] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetRoleId(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleId, 8, conQuestionnaireAddi.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, conQuestionnaireAddi.RoleId);
objQuestionnaireAddiEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.RoleId) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.RoleId, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.RoleId] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetIsShow(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, bool bolIsShow, string strComparisonOp="")
	{
objQuestionnaireAddiEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.IsShow) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.IsShow, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.IsShow] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetIsCast(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, bool bolIsCast, string strComparisonOp="")
	{
objQuestionnaireAddiEN.IsCast = bolIsCast; //是否播放
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.IsCast) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.IsCast, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.IsCast] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetLikeCount(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, long lngLikeCount, string strComparisonOp="")
	{
objQuestionnaireAddiEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.LikeCount) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.LikeCount, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.LikeCount] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetAnswerAttLimitSize(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, long lngAnswerAttLimitSize, string strComparisonOp="")
	{
objQuestionnaireAddiEN.AnswerAttLimitSize = lngAnswerAttLimitSize; //回答附件限制大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.AnswerAttLimitSize) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.AnswerAttLimitSize, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.AnswerAttLimitSize] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetLimitedResourceType(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strLimitedResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLimitedResourceType, 100, conQuestionnaireAddi.LimitedResourceType);
objQuestionnaireAddiEN.LimitedResourceType = strLimitedResourceType; //限制资源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.LimitedResourceType) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.LimitedResourceType, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.LimitedResourceType] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetIsEffective(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, bool bolIsEffective, string strComparisonOp="")
	{
objQuestionnaireAddiEN.IsEffective = bolIsEffective; //是否有效
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.IsEffective) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.IsEffective, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.IsEffective] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetIsCanInPaper(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, bool bolIsCanInPaper, string strComparisonOp="")
	{
objQuestionnaireAddiEN.IsCanInPaper = bolIsCanInPaper; //是否可在Paper
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.IsCanInPaper) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.IsCanInPaper, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.IsCanInPaper] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetUpdDate(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conQuestionnaireAddi.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQuestionnaireAddi.UpdDate);
objQuestionnaireAddiEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.UpdDate) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.UpdDate, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.UpdDate] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetUpdUser(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conQuestionnaireAddi.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQuestionnaireAddi.UpdUser);
objQuestionnaireAddiEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.UpdUser) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.UpdUser, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.UpdUser] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireAddiEN SetMemo(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQuestionnaireAddi.Memo);
objQuestionnaireAddiEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.Memo) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.Memo, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.Memo] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQuestionnaireAddiEN objQuestionnaireAddi_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.QuestionID) == true)
{
string strComparisonOp_QuestionID = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.QuestionID, objQuestionnaireAddi_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireAddi.QuestionIndex, objQuestionnaireAddi_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.QuestionName) == true)
{
string strComparisonOp_QuestionName = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.QuestionName, objQuestionnaireAddi_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.QuestionContent) == true)
{
string strComparisonOp_QuestionContent = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.QuestionContent, objQuestionnaireAddi_Cond.QuestionContent, strComparisonOp_QuestionContent);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.QuestionMemo) == true)
{
string strComparisonOp_QuestionMemo = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.QuestionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.QuestionMemo, objQuestionnaireAddi_Cond.QuestionMemo, strComparisonOp_QuestionMemo);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.QuestionNo) == true)
{
string strComparisonOp_QuestionNo = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.QuestionNo, objQuestionnaireAddi_Cond.QuestionNo, strComparisonOp_QuestionNo);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.ParentQuestionId) == true)
{
string strComparisonOp_ParentQuestionId = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.ParentQuestionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.ParentQuestionId, objQuestionnaireAddi_Cond.ParentQuestionId, strComparisonOp_ParentQuestionId);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.ExamAnswer) == true)
{
string strComparisonOp_ExamAnswer = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.ExamAnswer];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.ExamAnswer, objQuestionnaireAddi_Cond.ExamAnswer, strComparisonOp_ExamAnswer);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.CourseId) == true)
{
string strComparisonOp_CourseId = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.CourseId, objQuestionnaireAddi_Cond.CourseId, strComparisonOp_CourseId);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.LevelNo) == true)
{
string strComparisonOp_LevelNo = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.LevelNo];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireAddi.LevelNo, objQuestionnaireAddi_Cond.LevelNo, strComparisonOp_LevelNo);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.CourseChapterId, objQuestionnaireAddi_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.QuestionTypeId, objQuestionnaireAddi_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.QuestionTypeId4Course) == true)
{
string strComparisonOp_QuestionTypeId4Course = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.QuestionTypeId4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.QuestionTypeId4Course, objQuestionnaireAddi_Cond.QuestionTypeId4Course, strComparisonOp_QuestionTypeId4Course);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.ExamGradeId) == true)
{
string strComparisonOp_ExamGradeId = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.ExamGradeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.ExamGradeId, objQuestionnaireAddi_Cond.ExamGradeId, strComparisonOp_ExamGradeId);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.AnswerTypeId) == true)
{
string strComparisonOp_AnswerTypeId = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.AnswerTypeId, objQuestionnaireAddi_Cond.AnswerTypeId, strComparisonOp_AnswerTypeId);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.GridTitle) == true)
{
string strComparisonOp_GridTitle = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.GridTitle, objQuestionnaireAddi_Cond.GridTitle, strComparisonOp_GridTitle);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.AnswerModeId) == true)
{
string strComparisonOp_AnswerModeId = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.AnswerModeId, objQuestionnaireAddi_Cond.AnswerModeId, strComparisonOp_AnswerModeId);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.IsHaveAdditionalMemo) == true)
{
if (objQuestionnaireAddi_Cond.IsHaveAdditionalMemo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireAddi.IsHaveAdditionalMemo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireAddi.IsHaveAdditionalMemo);
}
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.QuestionnaireSetId) == true)
{
string strComparisonOp_QuestionnaireSetId = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.QuestionnaireSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.QuestionnaireSetId, objQuestionnaireAddi_Cond.QuestionnaireSetId, strComparisonOp_QuestionnaireSetId);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.QuestionScore) == true)
{
string strComparisonOp_QuestionScore = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.QuestionScore];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireAddi.QuestionScore, objQuestionnaireAddi_Cond.QuestionScore, strComparisonOp_QuestionScore);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.QuestionName_Add) == true)
{
string strComparisonOp_QuestionName_Add = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.QuestionName_Add];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.QuestionName_Add, objQuestionnaireAddi_Cond.QuestionName_Add, strComparisonOp_QuestionName_Add);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.DefaultValue) == true)
{
string strComparisonOp_DefaultValue = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.DefaultValue, objQuestionnaireAddi_Cond.DefaultValue, strComparisonOp_DefaultValue);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.TextDirectId) == true)
{
string strComparisonOp_TextDirectId = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.TextDirectId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.TextDirectId, objQuestionnaireAddi_Cond.TextDirectId, strComparisonOp_TextDirectId);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.FillInTextWidth) == true)
{
string strComparisonOp_FillInTextWidth = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.FillInTextWidth];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireAddi.FillInTextWidth, objQuestionnaireAddi_Cond.FillInTextWidth, strComparisonOp_FillInTextWidth);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.MemoTextWidth) == true)
{
string strComparisonOp_MemoTextWidth = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.MemoTextWidth];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireAddi.MemoTextWidth, objQuestionnaireAddi_Cond.MemoTextWidth, strComparisonOp_MemoTextWidth);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.CodeTab) == true)
{
string strComparisonOp_CodeTab = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.CodeTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.CodeTab, objQuestionnaireAddi_Cond.CodeTab, strComparisonOp_CodeTab);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.CodeTab_Code) == true)
{
string strComparisonOp_CodeTab_Code = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.CodeTab_Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.CodeTab_Code, objQuestionnaireAddi_Cond.CodeTab_Code, strComparisonOp_CodeTab_Code);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.CodeTab_Name) == true)
{
string strComparisonOp_CodeTab_Name = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.CodeTab_Name];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.CodeTab_Name, objQuestionnaireAddi_Cond.CodeTab_Name, strComparisonOp_CodeTab_Name);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.CodeTab_Condition) == true)
{
string strComparisonOp_CodeTab_Condition = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.CodeTab_Condition];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.CodeTab_Condition, objQuestionnaireAddi_Cond.CodeTab_Condition, strComparisonOp_CodeTab_Condition);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.RelaEvent) == true)
{
string strComparisonOp_RelaEvent = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.RelaEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.RelaEvent, objQuestionnaireAddi_Cond.RelaEvent, strComparisonOp_RelaEvent);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.FirstIndent) == true)
{
if (objQuestionnaireAddi_Cond.FirstIndent == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireAddi.FirstIndent);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireAddi.FirstIndent);
}
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.DefaultSelectItem) == true)
{
string strComparisonOp_DefaultSelectItem = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.DefaultSelectItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.DefaultSelectItem, objQuestionnaireAddi_Cond.DefaultSelectItem, strComparisonOp_DefaultSelectItem);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.IfLinkage) == true)
{
if (objQuestionnaireAddi_Cond.IfLinkage == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireAddi.IfLinkage);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireAddi.IfLinkage);
}
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.LinkageIndex) == true)
{
string strComparisonOp_LinkageIndex = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.LinkageIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireAddi.LinkageIndex, objQuestionnaireAddi_Cond.LinkageIndex, strComparisonOp_LinkageIndex);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.IsAutoGridTitle) == true)
{
if (objQuestionnaireAddi_Cond.IsAutoGridTitle == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireAddi.IsAutoGridTitle);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireAddi.IsAutoGridTitle);
}
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.FillInTextHeight) == true)
{
string strComparisonOp_FillInTextHeight = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.FillInTextHeight];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireAddi.FillInTextHeight, objQuestionnaireAddi_Cond.FillInTextHeight, strComparisonOp_FillInTextHeight);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.IsMulti4FillInText) == true)
{
if (objQuestionnaireAddi_Cond.IsMulti4FillInText == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireAddi.IsMulti4FillInText);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireAddi.IsMulti4FillInText);
}
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.CheckBoxLimitCount) == true)
{
string strComparisonOp_CheckBoxLimitCount = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.CheckBoxLimitCount];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireAddi.CheckBoxLimitCount, objQuestionnaireAddi_Cond.CheckBoxLimitCount, strComparisonOp_CheckBoxLimitCount);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.RoleId) == true)
{
string strComparisonOp_RoleId = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.RoleId, objQuestionnaireAddi_Cond.RoleId, strComparisonOp_RoleId);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.IsShow) == true)
{
if (objQuestionnaireAddi_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireAddi.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireAddi.IsShow);
}
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.IsCast) == true)
{
if (objQuestionnaireAddi_Cond.IsCast == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireAddi.IsCast);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireAddi.IsCast);
}
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.LikeCount) == true)
{
string strComparisonOp_LikeCount = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireAddi.LikeCount, objQuestionnaireAddi_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.AnswerAttLimitSize) == true)
{
string strComparisonOp_AnswerAttLimitSize = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.AnswerAttLimitSize];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireAddi.AnswerAttLimitSize, objQuestionnaireAddi_Cond.AnswerAttLimitSize, strComparisonOp_AnswerAttLimitSize);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.LimitedResourceType) == true)
{
string strComparisonOp_LimitedResourceType = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.LimitedResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.LimitedResourceType, objQuestionnaireAddi_Cond.LimitedResourceType, strComparisonOp_LimitedResourceType);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.IsEffective) == true)
{
if (objQuestionnaireAddi_Cond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireAddi.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireAddi.IsEffective);
}
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.IsCanInPaper) == true)
{
if (objQuestionnaireAddi_Cond.IsCanInPaper == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireAddi.IsCanInPaper);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireAddi.IsCanInPaper);
}
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.UpdDate) == true)
{
string strComparisonOp_UpdDate = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.UpdDate, objQuestionnaireAddi_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.UpdUser) == true)
{
string strComparisonOp_UpdUser = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.UpdUser, objQuestionnaireAddi_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objQuestionnaireAddi_Cond.IsUpdated(conQuestionnaireAddi.Memo) == true)
{
string strComparisonOp_Memo = objQuestionnaireAddi_Cond.dicFldComparisonOp[conQuestionnaireAddi.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.Memo, objQuestionnaireAddi_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
 if (string.IsNullOrEmpty(objQuestionnaireAddiEN.QuestionID) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQuestionnaireAddiEN.sf_UpdFldSetStr = objQuestionnaireAddiEN.getsf_UpdFldSetStr();
clsQuestionnaireAddiWApi.CheckPropertyNew(objQuestionnaireAddiEN); 
bool bolResult = clsQuestionnaireAddiWApi.UpdateRecord(objQuestionnaireAddiEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireAddiWApi.ReFreshCache(objQuestionnaireAddiEN.CourseId);
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
 /// <param name = "objQuestionnaireAddiEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
try
{
 if (string.IsNullOrEmpty(objQuestionnaireAddiEN.QuestionID) == true || clsQuestionnaireAddiWApi.IsExist(objQuestionnaireAddiEN.QuestionID) == true)
 {
     objQuestionnaireAddiEN.QuestionID = clsQuestionnaireAddiWApi.GetMaxStrId();
 }
clsQuestionnaireAddiWApi.CheckPropertyNew(objQuestionnaireAddiEN); 
bool bolResult = clsQuestionnaireAddiWApi.AddNewRecord(objQuestionnaireAddiEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireAddiWApi.ReFreshCache(objQuestionnaireAddiEN.CourseId);
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
 /// <param name = "objQuestionnaireAddiEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
try
{
clsQuestionnaireAddiWApi.CheckPropertyNew(objQuestionnaireAddiEN); 
string strQuestionID = clsQuestionnaireAddiWApi.AddNewRecordWithMaxId(objQuestionnaireAddiEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireAddiWApi.ReFreshCache(objQuestionnaireAddiEN.CourseId);
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
 /// <param name = "objQuestionnaireAddiEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strWhereCond)
{
try
{
clsQuestionnaireAddiWApi.CheckPropertyNew(objQuestionnaireAddiEN); 
bool bolResult = clsQuestionnaireAddiWApi.UpdateWithCondition(objQuestionnaireAddiEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireAddiWApi.ReFreshCache(objQuestionnaireAddiEN.CourseId);
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
 /// 题目附加(QuestionnaireAddi)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQuestionnaireAddiWApi
{
private static readonly string mstrApiControllerName = "QuestionnaireAddiApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clsQuestionnaireAddiWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[题目附加]...","0");
List<clsQuestionnaireAddiEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", conQuestionnaireAddi.QuestionID); 
List<clsQuestionnaireAddiEN> arrObjLst = clsQuestionnaireAddiWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQuestionnaireAddiEN objQuestionnaireAddiEN = new clsQuestionnaireAddiEN()
{
QuestionID = "0",
QuestionName = "选[题目附加]..."
};
arrObjLst.Insert(0, objQuestionnaireAddiEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQuestionnaireAddi.QuestionID;
objComboBox.DisplayMember = conQuestionnaireAddi.QuestionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
if (!Object.Equals(null, objQuestionnaireAddiEN.QuestionID) && GetStrLen(objQuestionnaireAddiEN.QuestionID) > 8)
{
 throw new Exception("字段[题目ID]的长度不能超过8!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.QuestionName) && GetStrLen(objQuestionnaireAddiEN.QuestionName) > 1000)
{
 throw new Exception("字段[题目名称]的长度不能超过1000!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.QuestionContent) && GetStrLen(objQuestionnaireAddiEN.QuestionContent) > 4000)
{
 throw new Exception("字段[题目内容]的长度不能超过4000!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.QuestionMemo) && GetStrLen(objQuestionnaireAddiEN.QuestionMemo) > 1000)
{
 throw new Exception("字段[题目说明]的长度不能超过1000!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.QuestionNo) && GetStrLen(objQuestionnaireAddiEN.QuestionNo) > 10)
{
 throw new Exception("字段[题目编号]的长度不能超过10!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.ParentQuestionId) && GetStrLen(objQuestionnaireAddiEN.ParentQuestionId) > 8)
{
 throw new Exception("字段[父题目Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.ExamAnswer) && GetStrLen(objQuestionnaireAddiEN.ExamAnswer) > 8000)
{
 throw new Exception("字段[题目答案]的长度不能超过8000!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.CourseId) && GetStrLen(objQuestionnaireAddiEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.CourseChapterId) && GetStrLen(objQuestionnaireAddiEN.CourseChapterId) > 8)
{
 throw new Exception("字段[课程章节ID]的长度不能超过8!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.QuestionTypeId) && GetStrLen(objQuestionnaireAddiEN.QuestionTypeId) > 2)
{
 throw new Exception("字段[题目类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.QuestionTypeId4Course) && GetStrLen(objQuestionnaireAddiEN.QuestionTypeId4Course) > 8)
{
 throw new Exception("字段[题目类型Id4课程]的长度不能超过8!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.ExamGradeId) && GetStrLen(objQuestionnaireAddiEN.ExamGradeId) > 2)
{
 throw new Exception("字段[题库等级ID]的长度不能超过2!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.AnswerTypeId) && GetStrLen(objQuestionnaireAddiEN.AnswerTypeId) > 2)
{
 throw new Exception("字段[答案类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.GridTitle) && GetStrLen(objQuestionnaireAddiEN.GridTitle) > 30)
{
 throw new Exception("字段[表格标题]的长度不能超过30!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.AnswerModeId) && GetStrLen(objQuestionnaireAddiEN.AnswerModeId) > 4)
{
 throw new Exception("字段[答案模式Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.QuestionnaireSetId) && GetStrLen(objQuestionnaireAddiEN.QuestionnaireSetId) > 4)
{
 throw new Exception("字段[问卷集ID]的长度不能超过4!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.QuestionName_Add) && GetStrLen(objQuestionnaireAddiEN.QuestionName_Add) > 500)
{
 throw new Exception("字段[题目补充]的长度不能超过500!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.DefaultValue) && GetStrLen(objQuestionnaireAddiEN.DefaultValue) > 50)
{
 throw new Exception("字段[缺省值]的长度不能超过50!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.TextDirectId) && GetStrLen(objQuestionnaireAddiEN.TextDirectId) > 4)
{
 throw new Exception("字段[文本方向ID]的长度不能超过4!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.CodeTab) && GetStrLen(objQuestionnaireAddiEN.CodeTab) > 50)
{
 throw new Exception("字段[代码表]的长度不能超过50!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.CodeTab_Code) && GetStrLen(objQuestionnaireAddiEN.CodeTab_Code) > 50)
{
 throw new Exception("字段[CodeTab_Code]的长度不能超过50!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.CodeTab_Name) && GetStrLen(objQuestionnaireAddiEN.CodeTab_Name) > 50)
{
 throw new Exception("字段[CodeTab_Name]的长度不能超过50!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.CodeTab_Condition) && GetStrLen(objQuestionnaireAddiEN.CodeTab_Condition) > 200)
{
 throw new Exception("字段[代码表_条件]的长度不能超过200!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.RelaEvent) && GetStrLen(objQuestionnaireAddiEN.RelaEvent) > 4000)
{
 throw new Exception("字段[相关事件]的长度不能超过4000!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.DefaultSelectItem) && GetStrLen(objQuestionnaireAddiEN.DefaultSelectItem) > 20)
{
 throw new Exception("字段[默认选项]的长度不能超过20!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.RoleId) && GetStrLen(objQuestionnaireAddiEN.RoleId) > 8)
{
 throw new Exception("字段[角色Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.LimitedResourceType) && GetStrLen(objQuestionnaireAddiEN.LimitedResourceType) > 100)
{
 throw new Exception("字段[限制资源类型]的长度不能超过100!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.UpdDate) && GetStrLen(objQuestionnaireAddiEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.UpdUser) && GetStrLen(objQuestionnaireAddiEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objQuestionnaireAddiEN.Memo) && GetStrLen(objQuestionnaireAddiEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objQuestionnaireAddiEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQuestionID">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionnaireAddiEN GetObjByQuestionID(string strQuestionID)
{
string strAction = "GetObjByQuestionID";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionnaireAddiEN objQuestionnaireAddiEN = null;
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
objQuestionnaireAddiEN = JsonConvert.DeserializeObject<clsQuestionnaireAddiEN>((string)jobjReturn["ReturnObj"]);
return objQuestionnaireAddiEN;
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
public static clsQuestionnaireAddiEN GetObjByQuestionID_WA_Cache(string strQuestionID, string strCourseId)
{
string strAction = "GetObjByQuestionID_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionnaireAddiEN objQuestionnaireAddiEN = null;
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
objQuestionnaireAddiEN = JsonConvert.DeserializeObject<clsQuestionnaireAddiEN>((string)jobjReturn["ReturnObj"]);
return objQuestionnaireAddiEN;
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
public static clsQuestionnaireAddiEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionnaireAddiEN objQuestionnaireAddiEN = null;
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
objQuestionnaireAddiEN = JsonConvert.DeserializeObject<clsQuestionnaireAddiEN>((string)jobjReturn["ReturnObj"]);
return objQuestionnaireAddiEN;
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
public static clsQuestionnaireAddiEN GetObjByQuestionID_Cache(string strQuestionID, string strCourseId)
{
if (string.IsNullOrEmpty(strQuestionID) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsQuestionnaireAddiEN._CurrTabName_S, strCourseId);
List<clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLst_Sel =
from objQuestionnaireAddiEN in arrQuestionnaireAddiObjLst_Cache
where objQuestionnaireAddiEN.QuestionID == strQuestionID
select objQuestionnaireAddiEN;
if (arrQuestionnaireAddiObjLst_Sel.Count() == 0)
{
   clsQuestionnaireAddiEN obj = clsQuestionnaireAddiWApi.GetObjByQuestionID(strQuestionID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrQuestionnaireAddiObjLst_Sel.First();
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
string strKey = string.Format("{0}_{1}", clsQuestionnaireAddiEN._CurrTabName_S, strCourseId);
List<clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLst_Sel1 =
from objQuestionnaireAddiEN in arrQuestionnaireAddiObjLst_Cache
where objQuestionnaireAddiEN.QuestionID == strQuestionID
select objQuestionnaireAddiEN;
List <clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLst_Sel = new List<clsQuestionnaireAddiEN>();
foreach (clsQuestionnaireAddiEN obj in arrQuestionnaireAddiObjLst_Sel1)
{
arrQuestionnaireAddiObjLst_Sel.Add(obj);
}
if (arrQuestionnaireAddiObjLst_Sel.Count > 0)
{
return arrQuestionnaireAddiObjLst_Sel[0].QuestionName;
}
string strErrMsgForGetObjById = string.Format("在QuestionnaireAddi对象缓存列表中,找不到记录[QuestionID = {0}](函数:{1})", strQuestionID, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQuestionnaireAddiBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
string strKey = string.Format("{0}_{1}", clsQuestionnaireAddiEN._CurrTabName_S, strCourseId);
List<clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLst_Sel1 =
from objQuestionnaireAddiEN in arrQuestionnaireAddiObjLst_Cache
where objQuestionnaireAddiEN.QuestionID == strQuestionID
select objQuestionnaireAddiEN;
List <clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLst_Sel = new List<clsQuestionnaireAddiEN>();
foreach (clsQuestionnaireAddiEN obj in arrQuestionnaireAddiObjLst_Sel1)
{
arrQuestionnaireAddiObjLst_Sel.Add(obj);
}
if (arrQuestionnaireAddiObjLst_Sel.Count > 0)
{
return arrQuestionnaireAddiObjLst_Sel[0].QuestionName;
}
string strErrMsgForGetObjById = string.Format("在QuestionnaireAddi对象缓存列表中,找不到记录的相关名称[QuestionID = {0}](函数:{1})", strQuestionID, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQuestionnaireAddiBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionnaireAddiEN> GetObjLst(string strWhereCond)
{
 List<clsQuestionnaireAddiEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireAddiEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionnaireAddiEN> GetObjLstByQuestionIDLst(List<string> arrQuestionID)
{
 List<clsQuestionnaireAddiEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireAddiEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsQuestionnaireAddiEN> GetObjLstByQuestionIDLst_Cache(List<string> arrQuestionID, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsQuestionnaireAddiEN._CurrTabName_S, strCourseId);
List<clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLst_Sel =
from objQuestionnaireAddiEN in arrQuestionnaireAddiObjLst_Cache
where arrQuestionID.Contains(objQuestionnaireAddiEN.QuestionID)
select objQuestionnaireAddiEN;
return arrQuestionnaireAddiObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionnaireAddiEN> GetObjLstByQuestionIDLst_WA_Cache(List<string> arrQuestionID, string strCourseId)
{
 List<clsQuestionnaireAddiEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireAddiEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionnaireAddiEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQuestionnaireAddiEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireAddiEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionnaireAddiEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQuestionnaireAddiEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireAddiEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionnaireAddiEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQuestionnaireAddiEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireAddiEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionnaireAddiEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsQuestionnaireAddiEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireAddiEN>>((string)jobjReturn["ReturnObjLst"]);
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
 clsQuestionnaireAddiEN objQuestionnaireAddiEN = clsQuestionnaireAddiWApi.GetObjByQuestionID(strQuestionID);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strQuestionID.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsQuestionnaireAddiWApi.ReFreshCache(objQuestionnaireAddiEN.CourseId);
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
public static int DelQuestionnaireAddis(List<string> arrQuestionID)
{
string strAction = "DelQuestionnaireAddis";
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
 clsQuestionnaireAddiEN objQuestionnaireAddiEN = clsQuestionnaireAddiWApi.GetObjByQuestionID(arrQuestionID[0]);
clsQuestionnaireAddiWApi.ReFreshCache(objQuestionnaireAddiEN.CourseId);
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
public static int DelQuestionnaireAddisByCond(string strWhereCond)
{
string strAction = "DelQuestionnaireAddisByCond";
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
public static bool AddNewRecord(clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionnaireAddiEN>(objQuestionnaireAddiEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireAddiWApi.ReFreshCache(objQuestionnaireAddiEN.CourseId);
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
public static string AddNewRecordWithMaxId(clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionnaireAddiEN>(objQuestionnaireAddiEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireAddiWApi.ReFreshCache(objQuestionnaireAddiEN.CourseId);
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
public static bool UpdateRecord(clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
if (string.IsNullOrEmpty(objQuestionnaireAddiEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionnaireAddiEN.QuestionID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionnaireAddiEN>(objQuestionnaireAddiEN);
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
 /// <param name = "objQuestionnaireAddiEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQuestionnaireAddiEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionnaireAddiEN.QuestionID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionnaireAddiEN.QuestionID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionnaireAddiEN>(objQuestionnaireAddiEN);
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
 /// <param name = "objQuestionnaireAddiENS">源对象</param>
 /// <param name = "objQuestionnaireAddiENT">目标对象</param>
 public static void CopyTo(clsQuestionnaireAddiEN objQuestionnaireAddiENS, clsQuestionnaireAddiEN objQuestionnaireAddiENT)
{
try
{
objQuestionnaireAddiENT.QuestionID = objQuestionnaireAddiENS.QuestionID; //题目ID
objQuestionnaireAddiENT.QuestionIndex = objQuestionnaireAddiENS.QuestionIndex; //题目序号
objQuestionnaireAddiENT.QuestionName = objQuestionnaireAddiENS.QuestionName; //题目名称
objQuestionnaireAddiENT.QuestionContent = objQuestionnaireAddiENS.QuestionContent; //题目内容
objQuestionnaireAddiENT.QuestionMemo = objQuestionnaireAddiENS.QuestionMemo; //题目说明
objQuestionnaireAddiENT.QuestionNo = objQuestionnaireAddiENS.QuestionNo; //题目编号
objQuestionnaireAddiENT.ParentQuestionId = objQuestionnaireAddiENS.ParentQuestionId; //父题目Id
objQuestionnaireAddiENT.ExamAnswer = objQuestionnaireAddiENS.ExamAnswer; //题目答案
objQuestionnaireAddiENT.CourseId = objQuestionnaireAddiENS.CourseId; //课程Id
objQuestionnaireAddiENT.LevelNo = objQuestionnaireAddiENS.LevelNo; //学习关号2
objQuestionnaireAddiENT.CourseChapterId = objQuestionnaireAddiENS.CourseChapterId; //课程章节ID
objQuestionnaireAddiENT.QuestionTypeId = objQuestionnaireAddiENS.QuestionTypeId; //题目类型Id
objQuestionnaireAddiENT.QuestionTypeId4Course = objQuestionnaireAddiENS.QuestionTypeId4Course; //题目类型Id4课程
objQuestionnaireAddiENT.ExamGradeId = objQuestionnaireAddiENS.ExamGradeId; //题库等级ID
objQuestionnaireAddiENT.AnswerTypeId = objQuestionnaireAddiENS.AnswerTypeId; //答案类型ID
objQuestionnaireAddiENT.GridTitle = objQuestionnaireAddiENS.GridTitle; //表格标题
objQuestionnaireAddiENT.AnswerModeId = objQuestionnaireAddiENS.AnswerModeId; //答案模式Id
objQuestionnaireAddiENT.IsHaveAdditionalMemo = objQuestionnaireAddiENS.IsHaveAdditionalMemo; //是否有附加说明
objQuestionnaireAddiENT.QuestionnaireSetId = objQuestionnaireAddiENS.QuestionnaireSetId; //问卷集ID
objQuestionnaireAddiENT.QuestionScore = objQuestionnaireAddiENS.QuestionScore; //题目得分
objQuestionnaireAddiENT.QuestionName_Add = objQuestionnaireAddiENS.QuestionName_Add; //题目补充
objQuestionnaireAddiENT.DefaultValue = objQuestionnaireAddiENS.DefaultValue; //缺省值
objQuestionnaireAddiENT.TextDirectId = objQuestionnaireAddiENS.TextDirectId; //文本方向ID
objQuestionnaireAddiENT.FillInTextWidth = objQuestionnaireAddiENS.FillInTextWidth; //填空框宽度
objQuestionnaireAddiENT.MemoTextWidth = objQuestionnaireAddiENS.MemoTextWidth; //备注框宽度
objQuestionnaireAddiENT.CodeTab = objQuestionnaireAddiENS.CodeTab; //代码表
objQuestionnaireAddiENT.CodeTab_Code = objQuestionnaireAddiENS.CodeTab_Code; //CodeTab_Code
objQuestionnaireAddiENT.CodeTab_Name = objQuestionnaireAddiENS.CodeTab_Name; //CodeTab_Name
objQuestionnaireAddiENT.CodeTab_Condition = objQuestionnaireAddiENS.CodeTab_Condition; //代码表_条件
objQuestionnaireAddiENT.RelaEvent = objQuestionnaireAddiENS.RelaEvent; //相关事件
objQuestionnaireAddiENT.FirstIndent = objQuestionnaireAddiENS.FirstIndent; //首行缩进
objQuestionnaireAddiENT.DefaultSelectItem = objQuestionnaireAddiENS.DefaultSelectItem; //默认选项
objQuestionnaireAddiENT.IfLinkage = objQuestionnaireAddiENS.IfLinkage; //是否联动
objQuestionnaireAddiENT.LinkageIndex = objQuestionnaireAddiENS.LinkageIndex; //联动题序号
objQuestionnaireAddiENT.IsAutoGridTitle = objQuestionnaireAddiENS.IsAutoGridTitle; //是否自动编表格标题
objQuestionnaireAddiENT.FillInTextHeight = objQuestionnaireAddiENS.FillInTextHeight; //填空框高度
objQuestionnaireAddiENT.IsMulti4FillInText = objQuestionnaireAddiENS.IsMulti4FillInText; //是否填空框多行
objQuestionnaireAddiENT.CheckBoxLimitCount = objQuestionnaireAddiENS.CheckBoxLimitCount; //复选框限制数
objQuestionnaireAddiENT.RoleId = objQuestionnaireAddiENS.RoleId; //角色Id
objQuestionnaireAddiENT.IsShow = objQuestionnaireAddiENS.IsShow; //是否启用
objQuestionnaireAddiENT.IsCast = objQuestionnaireAddiENS.IsCast; //是否播放
objQuestionnaireAddiENT.LikeCount = objQuestionnaireAddiENS.LikeCount; //资源喜欢数量
objQuestionnaireAddiENT.AnswerAttLimitSize = objQuestionnaireAddiENS.AnswerAttLimitSize; //回答附件限制大小
objQuestionnaireAddiENT.LimitedResourceType = objQuestionnaireAddiENS.LimitedResourceType; //限制资源类型
objQuestionnaireAddiENT.IsEffective = objQuestionnaireAddiENS.IsEffective; //是否有效
objQuestionnaireAddiENT.IsCanInPaper = objQuestionnaireAddiENS.IsCanInPaper; //是否可在Paper
objQuestionnaireAddiENT.UpdDate = objQuestionnaireAddiENS.UpdDate; //修改日期
objQuestionnaireAddiENT.UpdUser = objQuestionnaireAddiENS.UpdUser; //修改人
objQuestionnaireAddiENT.Memo = objQuestionnaireAddiENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsQuestionnaireAddiEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQuestionnaireAddiEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQuestionnaireAddiEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQuestionnaireAddiEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQuestionnaireAddiEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQuestionnaireAddiEN.AttributeName)
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
if (clsQuestionnaireAddiWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireAddiWApi没有刷新缓存机制(clsQuestionnaireAddiWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionID");
//if (arrQuestionnaireAddiObjLst_Cache == null)
//{
//arrQuestionnaireAddiObjLst_Cache = await clsQuestionnaireAddiWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsQuestionnaireAddiEN._CurrTabName_S, strCourseId);
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
if (clsQuestionnaireAddiWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsQuestionnaireAddiEN._CurrTabName_S, strCourseId);
CacheHelper.Remove(strKey);
clsQuestionnaireAddiWApi.objCommFun4BL.ReFreshCache(strCourseId);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionnaireAddiEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsQuestionnaireAddiEN._CurrTabName_S, strCourseId);
List<clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrQuestionnaireAddiObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQuestionnaireAddiEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQuestionnaireAddi.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(conQuestionnaireAddi.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.QuestionContent, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.QuestionMemo, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.QuestionNo, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.ParentQuestionId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.ExamAnswer, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.LevelNo, Type.GetType("System.Int32"));
objDT.Columns.Add(conQuestionnaireAddi.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.QuestionTypeId4Course, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.ExamGradeId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.AnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.GridTitle, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.AnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.IsHaveAdditionalMemo, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionnaireAddi.QuestionnaireSetId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.QuestionScore, Type.GetType("System.Single"));
objDT.Columns.Add(conQuestionnaireAddi.QuestionName_Add, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.TextDirectId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.FillInTextWidth, Type.GetType("System.Int32"));
objDT.Columns.Add(conQuestionnaireAddi.MemoTextWidth, Type.GetType("System.Int32"));
objDT.Columns.Add(conQuestionnaireAddi.CodeTab, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.CodeTab_Code, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.CodeTab_Name, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.CodeTab_Condition, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.RelaEvent, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.FirstIndent, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionnaireAddi.DefaultSelectItem, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.IfLinkage, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionnaireAddi.LinkageIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(conQuestionnaireAddi.IsAutoGridTitle, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionnaireAddi.FillInTextHeight, Type.GetType("System.Int32"));
objDT.Columns.Add(conQuestionnaireAddi.IsMulti4FillInText, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionnaireAddi.CheckBoxLimitCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conQuestionnaireAddi.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionnaireAddi.IsCast, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionnaireAddi.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(conQuestionnaireAddi.AnswerAttLimitSize, Type.GetType("System.Int64"));
objDT.Columns.Add(conQuestionnaireAddi.LimitedResourceType, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.IsEffective, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionnaireAddi.IsCanInPaper, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionnaireAddi.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireAddi.Memo, Type.GetType("System.String"));
foreach (clsQuestionnaireAddiEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQuestionnaireAddi.QuestionID] = objInFor[conQuestionnaireAddi.QuestionID];
objDR[conQuestionnaireAddi.QuestionIndex] = objInFor[conQuestionnaireAddi.QuestionIndex];
objDR[conQuestionnaireAddi.QuestionName] = objInFor[conQuestionnaireAddi.QuestionName];
objDR[conQuestionnaireAddi.QuestionContent] = objInFor[conQuestionnaireAddi.QuestionContent];
objDR[conQuestionnaireAddi.QuestionMemo] = objInFor[conQuestionnaireAddi.QuestionMemo];
objDR[conQuestionnaireAddi.QuestionNo] = objInFor[conQuestionnaireAddi.QuestionNo];
objDR[conQuestionnaireAddi.ParentQuestionId] = objInFor[conQuestionnaireAddi.ParentQuestionId];
objDR[conQuestionnaireAddi.ExamAnswer] = objInFor[conQuestionnaireAddi.ExamAnswer];
objDR[conQuestionnaireAddi.CourseId] = objInFor[conQuestionnaireAddi.CourseId];
objDR[conQuestionnaireAddi.LevelNo] = objInFor[conQuestionnaireAddi.LevelNo];
objDR[conQuestionnaireAddi.CourseChapterId] = objInFor[conQuestionnaireAddi.CourseChapterId];
objDR[conQuestionnaireAddi.QuestionTypeId] = objInFor[conQuestionnaireAddi.QuestionTypeId];
objDR[conQuestionnaireAddi.QuestionTypeId4Course] = objInFor[conQuestionnaireAddi.QuestionTypeId4Course];
objDR[conQuestionnaireAddi.ExamGradeId] = objInFor[conQuestionnaireAddi.ExamGradeId];
objDR[conQuestionnaireAddi.AnswerTypeId] = objInFor[conQuestionnaireAddi.AnswerTypeId];
objDR[conQuestionnaireAddi.GridTitle] = objInFor[conQuestionnaireAddi.GridTitle];
objDR[conQuestionnaireAddi.AnswerModeId] = objInFor[conQuestionnaireAddi.AnswerModeId];
objDR[conQuestionnaireAddi.IsHaveAdditionalMemo] = objInFor[conQuestionnaireAddi.IsHaveAdditionalMemo];
objDR[conQuestionnaireAddi.QuestionnaireSetId] = objInFor[conQuestionnaireAddi.QuestionnaireSetId];
objDR[conQuestionnaireAddi.QuestionScore] = objInFor[conQuestionnaireAddi.QuestionScore];
objDR[conQuestionnaireAddi.QuestionName_Add] = objInFor[conQuestionnaireAddi.QuestionName_Add];
objDR[conQuestionnaireAddi.DefaultValue] = objInFor[conQuestionnaireAddi.DefaultValue];
objDR[conQuestionnaireAddi.TextDirectId] = objInFor[conQuestionnaireAddi.TextDirectId];
objDR[conQuestionnaireAddi.FillInTextWidth] = objInFor[conQuestionnaireAddi.FillInTextWidth];
objDR[conQuestionnaireAddi.MemoTextWidth] = objInFor[conQuestionnaireAddi.MemoTextWidth];
objDR[conQuestionnaireAddi.CodeTab] = objInFor[conQuestionnaireAddi.CodeTab];
objDR[conQuestionnaireAddi.CodeTab_Code] = objInFor[conQuestionnaireAddi.CodeTab_Code];
objDR[conQuestionnaireAddi.CodeTab_Name] = objInFor[conQuestionnaireAddi.CodeTab_Name];
objDR[conQuestionnaireAddi.CodeTab_Condition] = objInFor[conQuestionnaireAddi.CodeTab_Condition];
objDR[conQuestionnaireAddi.RelaEvent] = objInFor[conQuestionnaireAddi.RelaEvent];
objDR[conQuestionnaireAddi.FirstIndent] = objInFor[conQuestionnaireAddi.FirstIndent];
objDR[conQuestionnaireAddi.DefaultSelectItem] = objInFor[conQuestionnaireAddi.DefaultSelectItem];
objDR[conQuestionnaireAddi.IfLinkage] = objInFor[conQuestionnaireAddi.IfLinkage];
objDR[conQuestionnaireAddi.LinkageIndex] = objInFor[conQuestionnaireAddi.LinkageIndex];
objDR[conQuestionnaireAddi.IsAutoGridTitle] = objInFor[conQuestionnaireAddi.IsAutoGridTitle];
objDR[conQuestionnaireAddi.FillInTextHeight] = objInFor[conQuestionnaireAddi.FillInTextHeight];
objDR[conQuestionnaireAddi.IsMulti4FillInText] = objInFor[conQuestionnaireAddi.IsMulti4FillInText];
objDR[conQuestionnaireAddi.CheckBoxLimitCount] = objInFor[conQuestionnaireAddi.CheckBoxLimitCount];
objDR[conQuestionnaireAddi.RoleId] = objInFor[conQuestionnaireAddi.RoleId];
objDR[conQuestionnaireAddi.IsShow] = objInFor[conQuestionnaireAddi.IsShow];
objDR[conQuestionnaireAddi.IsCast] = objInFor[conQuestionnaireAddi.IsCast];
objDR[conQuestionnaireAddi.LikeCount] = objInFor[conQuestionnaireAddi.LikeCount];
objDR[conQuestionnaireAddi.AnswerAttLimitSize] = objInFor[conQuestionnaireAddi.AnswerAttLimitSize];
objDR[conQuestionnaireAddi.LimitedResourceType] = objInFor[conQuestionnaireAddi.LimitedResourceType];
objDR[conQuestionnaireAddi.IsEffective] = objInFor[conQuestionnaireAddi.IsEffective];
objDR[conQuestionnaireAddi.IsCanInPaper] = objInFor[conQuestionnaireAddi.IsCanInPaper];
objDR[conQuestionnaireAddi.UpdDate] = objInFor[conQuestionnaireAddi.UpdDate];
objDR[conQuestionnaireAddi.UpdUser] = objInFor[conQuestionnaireAddi.UpdUser];
objDR[conQuestionnaireAddi.Memo] = objInFor[conQuestionnaireAddi.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 题目附加(QuestionnaireAddi)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4QuestionnaireAddi : clsCommFun4BLV2
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
clsQuestionnaireAddiWApi.ReFreshThisCache(strCourseId);
}
}

}