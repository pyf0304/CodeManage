
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaire_KnowledgeWApi
 表名:vQuestionnaire_Knowledge(01120143)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:12
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
public static class clsvQuestionnaire_KnowledgeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionID(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convQuestionnaire_Knowledge.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convQuestionnaire_Knowledge.QuestionID);
objvQuestionnaire_KnowledgeEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.QuestionID) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.QuestionID, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionID] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionIndex(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, int intQuestionIndex, string strComparisonOp="")
	{
objvQuestionnaire_KnowledgeEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.QuestionIndex) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.QuestionIndex, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionIndex] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convQuestionnaire_Knowledge.QuestionName);
objvQuestionnaire_KnowledgeEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.QuestionName) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.QuestionName, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionName] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionContent(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strQuestionContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, convQuestionnaire_Knowledge.QuestionContent);
objvQuestionnaire_KnowledgeEN.QuestionContent = strQuestionContent; //题目内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.QuestionContent) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.QuestionContent, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionContent] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionMemo(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strQuestionMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionMemo, 1000, convQuestionnaire_Knowledge.QuestionMemo);
objvQuestionnaire_KnowledgeEN.QuestionMemo = strQuestionMemo; //题目说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.QuestionMemo) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.QuestionMemo, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionMemo] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionNo(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strQuestionNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, convQuestionnaire_Knowledge.QuestionNo);
objvQuestionnaire_KnowledgeEN.QuestionNo = strQuestionNo; //题目编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.QuestionNo) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.QuestionNo, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionNo] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetExamAnswer(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strExamAnswer, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamAnswer, 8000, convQuestionnaire_Knowledge.ExamAnswer);
objvQuestionnaire_KnowledgeEN.ExamAnswer = strExamAnswer; //题目答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.ExamAnswer) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.ExamAnswer, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.ExamAnswer] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetCourseId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convQuestionnaire_Knowledge.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convQuestionnaire_Knowledge.CourseId);
objvQuestionnaire_KnowledgeEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.CourseId) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.CourseId, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.CourseId] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetCourseName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convQuestionnaire_Knowledge.CourseName);
objvQuestionnaire_KnowledgeEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.CourseName) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.CourseName, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.CourseName] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetCourseChapterId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convQuestionnaire_Knowledge.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convQuestionnaire_Knowledge.CourseChapterId);
objvQuestionnaire_KnowledgeEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.CourseChapterId) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.CourseChapterId, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.CourseChapterId] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetCourseChapterName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convQuestionnaire_Knowledge.CourseChapterName);
objvQuestionnaire_KnowledgeEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.CourseChapterName) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.CourseChapterName, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.CourseChapterName] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetChapterId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, convQuestionnaire_Knowledge.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convQuestionnaire_Knowledge.ChapterId);
objvQuestionnaire_KnowledgeEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.ChapterId) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.ChapterId, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.ChapterId] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetSectionId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionId, 8, convQuestionnaire_Knowledge.SectionId);
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convQuestionnaire_Knowledge.SectionId);
objvQuestionnaire_KnowledgeEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.SectionId) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.SectionId, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.SectionId] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetChapterName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convQuestionnaire_Knowledge.ChapterName);
objvQuestionnaire_KnowledgeEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.ChapterName) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.ChapterName, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.ChapterName] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetSectionName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convQuestionnaire_Knowledge.SectionName);
objvQuestionnaire_KnowledgeEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.SectionName) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.SectionName, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.SectionName] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetChapterName_Sim(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convQuestionnaire_Knowledge.ChapterName_Sim);
objvQuestionnaire_KnowledgeEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.ChapterName_Sim) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.ChapterName_Sim, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.ChapterName_Sim] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetSectionName_Sim(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convQuestionnaire_Knowledge.SectionName_Sim);
objvQuestionnaire_KnowledgeEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.SectionName_Sim) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.SectionName_Sim, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.SectionName_Sim] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetParentNodeID(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convQuestionnaire_Knowledge.ParentNodeID);
objvQuestionnaire_KnowledgeEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.ParentNodeID) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.ParentNodeID, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.ParentNodeID] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetCourseChapterReferred(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strCourseChapterReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convQuestionnaire_Knowledge.CourseChapterReferred);
objvQuestionnaire_KnowledgeEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.CourseChapterReferred) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.CourseChapterReferred, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.CourseChapterReferred] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetParentNodeName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convQuestionnaire_Knowledge.ParentNodeName);
objvQuestionnaire_KnowledgeEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.ParentNodeName) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.ParentNodeName, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.ParentNodeName] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetParentNodeReferred(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strParentNodeReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convQuestionnaire_Knowledge.ParentNodeReferred);
objvQuestionnaire_KnowledgeEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.ParentNodeReferred) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.ParentNodeReferred, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.ParentNodeReferred] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionTypeId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convQuestionnaire_Knowledge.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convQuestionnaire_Knowledge.QuestionTypeId);
objvQuestionnaire_KnowledgeEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.QuestionTypeId) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.QuestionTypeId, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionTypeId] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionTypeName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convQuestionnaire_Knowledge.QuestionTypeName);
objvQuestionnaire_KnowledgeEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.QuestionTypeName) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.QuestionTypeName, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionTypeName] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetExamGradeId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strExamGradeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamGradeId, 2, convQuestionnaire_Knowledge.ExamGradeId);
clsCheckSql.CheckFieldForeignKey(strExamGradeId, 2, convQuestionnaire_Knowledge.ExamGradeId);
objvQuestionnaire_KnowledgeEN.ExamGradeId = strExamGradeId; //题库等级ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.ExamGradeId) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.ExamGradeId, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.ExamGradeId] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetExamGradeName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strExamGradeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamGradeName, 50, convQuestionnaire_Knowledge.ExamGradeName);
objvQuestionnaire_KnowledgeEN.ExamGradeName = strExamGradeName; //题库等级名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.ExamGradeName) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.ExamGradeName, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.ExamGradeName] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetAnswerTypeId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convQuestionnaire_Knowledge.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convQuestionnaire_Knowledge.AnswerTypeId);
objvQuestionnaire_KnowledgeEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.AnswerTypeId) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.AnswerTypeId, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.AnswerTypeId] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetAnswerTypeName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strAnswerTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeName, 50, convQuestionnaire_Knowledge.AnswerTypeName);
objvQuestionnaire_KnowledgeEN.AnswerTypeName = strAnswerTypeName; //答案类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.AnswerTypeName) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.AnswerTypeName, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.AnswerTypeName] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetGridTitle(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strGridTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGridTitle, 30, convQuestionnaire_Knowledge.GridTitle);
objvQuestionnaire_KnowledgeEN.GridTitle = strGridTitle; //表格标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.GridTitle) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.GridTitle, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.GridTitle] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetAnswerModeId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convQuestionnaire_Knowledge.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convQuestionnaire_Knowledge.AnswerModeId);
objvQuestionnaire_KnowledgeEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.AnswerModeId) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.AnswerModeId, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.AnswerModeId] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetAnswerModeName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strAnswerModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeName, 30, convQuestionnaire_Knowledge.AnswerModeName);
objvQuestionnaire_KnowledgeEN.AnswerModeName = strAnswerModeName; //答案模式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.AnswerModeName) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.AnswerModeName, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.AnswerModeName] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetIsHaveAdditionalMemo(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, bool bolIsHaveAdditionalMemo, string strComparisonOp="")
	{
objvQuestionnaire_KnowledgeEN.IsHaveAdditionalMemo = bolIsHaveAdditionalMemo; //是否有附加说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.IsHaveAdditionalMemo) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.IsHaveAdditionalMemo, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.IsHaveAdditionalMemo] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionnaireSetId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strQuestionnaireSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionnaireSetId, 4, convQuestionnaire_Knowledge.QuestionnaireSetId);
clsCheckSql.CheckFieldForeignKey(strQuestionnaireSetId, 4, convQuestionnaire_Knowledge.QuestionnaireSetId);
objvQuestionnaire_KnowledgeEN.QuestionnaireSetId = strQuestionnaireSetId; //问卷集ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.QuestionnaireSetId) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.QuestionnaireSetId, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionnaireSetId] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionnaireSetName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strQuestionnaireSetName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionnaireSetName, 50, convQuestionnaire_Knowledge.QuestionnaireSetName);
objvQuestionnaire_KnowledgeEN.QuestionnaireSetName = strQuestionnaireSetName; //问卷集名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.QuestionnaireSetName) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.QuestionnaireSetName, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionnaireSetName] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionScore(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, float fltQuestionScore, string strComparisonOp="")
	{
objvQuestionnaire_KnowledgeEN.QuestionScore = fltQuestionScore; //题目得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.QuestionScore) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.QuestionScore, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionScore] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionName_Add(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strQuestionName_Add, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName_Add, 500, convQuestionnaire_Knowledge.QuestionName_Add);
objvQuestionnaire_KnowledgeEN.QuestionName_Add = strQuestionName_Add; //题目补充
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.QuestionName_Add) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.QuestionName_Add, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionName_Add] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetDefaultValue(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convQuestionnaire_Knowledge.DefaultValue);
objvQuestionnaire_KnowledgeEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.DefaultValue) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.DefaultValue, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.DefaultValue] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetTextDirectId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strTextDirectId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTextDirectId, 4, convQuestionnaire_Knowledge.TextDirectId);
clsCheckSql.CheckFieldForeignKey(strTextDirectId, 4, convQuestionnaire_Knowledge.TextDirectId);
objvQuestionnaire_KnowledgeEN.TextDirectId = strTextDirectId; //文本方向ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.TextDirectId) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.TextDirectId, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.TextDirectId] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetTextDirectName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strTextDirectName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTextDirectName, 40, convQuestionnaire_Knowledge.TextDirectName);
objvQuestionnaire_KnowledgeEN.TextDirectName = strTextDirectName; //文本方向名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.TextDirectName) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.TextDirectName, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.TextDirectName] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetFillInTextWidth(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, int intFillInTextWidth, string strComparisonOp="")
	{
objvQuestionnaire_KnowledgeEN.FillInTextWidth = intFillInTextWidth; //填空框宽度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.FillInTextWidth) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.FillInTextWidth, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.FillInTextWidth] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetMemoTextWidth(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, int intMemoTextWidth, string strComparisonOp="")
	{
objvQuestionnaire_KnowledgeEN.MemoTextWidth = intMemoTextWidth; //备注框宽度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.MemoTextWidth) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.MemoTextWidth, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.MemoTextWidth] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetCodeTab(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strCodeTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTab, 50, convQuestionnaire_Knowledge.CodeTab);
objvQuestionnaire_KnowledgeEN.CodeTab = strCodeTab; //代码表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.CodeTab) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.CodeTab, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.CodeTab] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetCodeTab_Code(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strCodeTab_Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTab_Code, 50, convQuestionnaire_Knowledge.CodeTab_Code);
objvQuestionnaire_KnowledgeEN.CodeTab_Code = strCodeTab_Code; //CodeTab_Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.CodeTab_Code) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.CodeTab_Code, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.CodeTab_Code] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetCodeTab_Name(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strCodeTab_Name, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTab_Name, 50, convQuestionnaire_Knowledge.CodeTab_Name);
objvQuestionnaire_KnowledgeEN.CodeTab_Name = strCodeTab_Name; //CodeTab_Name
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.CodeTab_Name) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.CodeTab_Name, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.CodeTab_Name] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetCodeTab_Condition(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strCodeTab_Condition, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTab_Condition, 200, convQuestionnaire_Knowledge.CodeTab_Condition);
objvQuestionnaire_KnowledgeEN.CodeTab_Condition = strCodeTab_Condition; //代码表_条件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.CodeTab_Condition) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.CodeTab_Condition, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.CodeTab_Condition] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetRelaEvent(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strRelaEvent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaEvent, 4000, convQuestionnaire_Knowledge.RelaEvent);
objvQuestionnaire_KnowledgeEN.RelaEvent = strRelaEvent; //相关事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.RelaEvent) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.RelaEvent, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.RelaEvent] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetFirstIndent(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, bool bolFirstIndent, string strComparisonOp="")
	{
objvQuestionnaire_KnowledgeEN.FirstIndent = bolFirstIndent; //首行缩进
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.FirstIndent) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.FirstIndent, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.FirstIndent] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetDefaultSelectItem(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strDefaultSelectItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultSelectItem, 20, convQuestionnaire_Knowledge.DefaultSelectItem);
objvQuestionnaire_KnowledgeEN.DefaultSelectItem = strDefaultSelectItem; //默认选项
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.DefaultSelectItem) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.DefaultSelectItem, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.DefaultSelectItem] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetIsAutoGridTitle(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, bool bolIsAutoGridTitle, string strComparisonOp="")
	{
objvQuestionnaire_KnowledgeEN.IsAutoGridTitle = bolIsAutoGridTitle; //是否自动编表格标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.IsAutoGridTitle) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.IsAutoGridTitle, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.IsAutoGridTitle] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetFillInTextHeight(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, int intFillInTextHeight, string strComparisonOp="")
	{
objvQuestionnaire_KnowledgeEN.FillInTextHeight = intFillInTextHeight; //填空框高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.FillInTextHeight) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.FillInTextHeight, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.FillInTextHeight] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetIsMulti4FillInText(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, bool bolIsMulti4FillInText, string strComparisonOp="")
	{
objvQuestionnaire_KnowledgeEN.IsMulti4FillInText = bolIsMulti4FillInText; //是否填空框多行
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.IsMulti4FillInText) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.IsMulti4FillInText, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.IsMulti4FillInText] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetCheckBoxLimitCount(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, int intCheckBoxLimitCount, string strComparisonOp="")
	{
objvQuestionnaire_KnowledgeEN.CheckBoxLimitCount = intCheckBoxLimitCount; //复选框限制数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.CheckBoxLimitCount) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.CheckBoxLimitCount, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.CheckBoxLimitCount] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetRoleId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQuestionnaire_Knowledge.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQuestionnaire_Knowledge.RoleId);
objvQuestionnaire_KnowledgeEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.RoleId) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.RoleId, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.RoleId] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetRoleName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleName, 100, convQuestionnaire_Knowledge.RoleName);
objvQuestionnaire_KnowledgeEN.RoleName = strRoleName; //角色名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.RoleName) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.RoleName, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.RoleName] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetIsShow(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, bool bolIsShow, string strComparisonOp="")
	{
objvQuestionnaire_KnowledgeEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.IsShow) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.IsShow, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.IsShow] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetIsCast(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, bool bolIsCast, string strComparisonOp="")
	{
objvQuestionnaire_KnowledgeEN.IsCast = bolIsCast; //是否播放
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.IsCast) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.IsCast, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.IsCast] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetLikeCount(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, long lngLikeCount, string strComparisonOp="")
	{
objvQuestionnaire_KnowledgeEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.LikeCount) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.LikeCount, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.LikeCount] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetIsEffective(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, bool bolIsEffective, string strComparisonOp="")
	{
objvQuestionnaire_KnowledgeEN.IsEffective = bolIsEffective; //是否有效
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.IsEffective) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.IsEffective, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.IsEffective] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetIsCanInPaper(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, bool bolIsCanInPaper, string strComparisonOp="")
	{
objvQuestionnaire_KnowledgeEN.IsCanInPaper = bolIsCanInPaper; //是否可在Paper
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.IsCanInPaper) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.IsCanInPaper, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.IsCanInPaper] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetUpdDate(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQuestionnaire_Knowledge.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQuestionnaire_Knowledge.UpdDate);
objvQuestionnaire_KnowledgeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.UpdDate) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.UpdDate, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.UpdDate] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetUpdUser(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convQuestionnaire_Knowledge.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQuestionnaire_Knowledge.UpdUser);
objvQuestionnaire_KnowledgeEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.UpdUser) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.UpdUser, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.UpdUser] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetMemo(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQuestionnaire_Knowledge.Memo);
objvQuestionnaire_KnowledgeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.Memo) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.Memo, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.Memo] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetKnowledgeNum(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, int intKnowledgeNum, string strComparisonOp="")
	{
objvQuestionnaire_KnowledgeEN.KnowledgeNum = intKnowledgeNum; //知识点数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.KnowledgeNum) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.KnowledgeNum, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.KnowledgeNum] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetAnswerNum(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, int intAnswerNum, string strComparisonOp="")
	{
objvQuestionnaire_KnowledgeEN.AnswerNum = intAnswerNum; //答案数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.AnswerNum) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.AnswerNum, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.AnswerNum] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_Knowledge_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.QuestionID, objvQuestionnaire_Knowledge_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Knowledge.QuestionIndex, objvQuestionnaire_Knowledge_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.QuestionName, objvQuestionnaire_Knowledge_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.QuestionContent) == true)
{
string strComparisonOp_QuestionContent = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.QuestionContent, objvQuestionnaire_Knowledge_Cond.QuestionContent, strComparisonOp_QuestionContent);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.QuestionMemo) == true)
{
string strComparisonOp_QuestionMemo = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.QuestionMemo, objvQuestionnaire_Knowledge_Cond.QuestionMemo, strComparisonOp_QuestionMemo);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.QuestionNo) == true)
{
string strComparisonOp_QuestionNo = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.QuestionNo, objvQuestionnaire_Knowledge_Cond.QuestionNo, strComparisonOp_QuestionNo);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.ExamAnswer) == true)
{
string strComparisonOp_ExamAnswer = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.ExamAnswer];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.ExamAnswer, objvQuestionnaire_Knowledge_Cond.ExamAnswer, strComparisonOp_ExamAnswer);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.CourseId) == true)
{
string strComparisonOp_CourseId = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.CourseId, objvQuestionnaire_Knowledge_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.CourseName) == true)
{
string strComparisonOp_CourseName = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.CourseName, objvQuestionnaire_Knowledge_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.CourseChapterId, objvQuestionnaire_Knowledge_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.CourseChapterName, objvQuestionnaire_Knowledge_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.ChapterId) == true)
{
string strComparisonOp_ChapterId = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.ChapterId, objvQuestionnaire_Knowledge_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.SectionId) == true)
{
string strComparisonOp_SectionId = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.SectionId, objvQuestionnaire_Knowledge_Cond.SectionId, strComparisonOp_SectionId);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.ChapterName, objvQuestionnaire_Knowledge_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.SectionName) == true)
{
string strComparisonOp_SectionName = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.SectionName, objvQuestionnaire_Knowledge_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.ChapterName_Sim, objvQuestionnaire_Knowledge_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.SectionName_Sim, objvQuestionnaire_Knowledge_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.ParentNodeID, objvQuestionnaire_Knowledge_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.CourseChapterReferred) == true)
{
string strComparisonOp_CourseChapterReferred = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.CourseChapterReferred, objvQuestionnaire_Knowledge_Cond.CourseChapterReferred, strComparisonOp_CourseChapterReferred);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.ParentNodeName, objvQuestionnaire_Knowledge_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.ParentNodeReferred) == true)
{
string strComparisonOp_ParentNodeReferred = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.ParentNodeReferred, objvQuestionnaire_Knowledge_Cond.ParentNodeReferred, strComparisonOp_ParentNodeReferred);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.QuestionTypeId, objvQuestionnaire_Knowledge_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.QuestionTypeName, objvQuestionnaire_Knowledge_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.ExamGradeId) == true)
{
string strComparisonOp_ExamGradeId = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.ExamGradeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.ExamGradeId, objvQuestionnaire_Knowledge_Cond.ExamGradeId, strComparisonOp_ExamGradeId);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.ExamGradeName) == true)
{
string strComparisonOp_ExamGradeName = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.ExamGradeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.ExamGradeName, objvQuestionnaire_Knowledge_Cond.ExamGradeName, strComparisonOp_ExamGradeName);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.AnswerTypeId) == true)
{
string strComparisonOp_AnswerTypeId = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.AnswerTypeId, objvQuestionnaire_Knowledge_Cond.AnswerTypeId, strComparisonOp_AnswerTypeId);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.AnswerTypeName) == true)
{
string strComparisonOp_AnswerTypeName = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.AnswerTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.AnswerTypeName, objvQuestionnaire_Knowledge_Cond.AnswerTypeName, strComparisonOp_AnswerTypeName);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.GridTitle) == true)
{
string strComparisonOp_GridTitle = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.GridTitle, objvQuestionnaire_Knowledge_Cond.GridTitle, strComparisonOp_GridTitle);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.AnswerModeId) == true)
{
string strComparisonOp_AnswerModeId = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.AnswerModeId, objvQuestionnaire_Knowledge_Cond.AnswerModeId, strComparisonOp_AnswerModeId);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.AnswerModeName) == true)
{
string strComparisonOp_AnswerModeName = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.AnswerModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.AnswerModeName, objvQuestionnaire_Knowledge_Cond.AnswerModeName, strComparisonOp_AnswerModeName);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.IsHaveAdditionalMemo) == true)
{
if (objvQuestionnaire_Knowledge_Cond.IsHaveAdditionalMemo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire_Knowledge.IsHaveAdditionalMemo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire_Knowledge.IsHaveAdditionalMemo);
}
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.QuestionnaireSetId) == true)
{
string strComparisonOp_QuestionnaireSetId = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionnaireSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.QuestionnaireSetId, objvQuestionnaire_Knowledge_Cond.QuestionnaireSetId, strComparisonOp_QuestionnaireSetId);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.QuestionnaireSetName) == true)
{
string strComparisonOp_QuestionnaireSetName = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionnaireSetName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.QuestionnaireSetName, objvQuestionnaire_Knowledge_Cond.QuestionnaireSetName, strComparisonOp_QuestionnaireSetName);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.QuestionScore) == true)
{
string strComparisonOp_QuestionScore = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionScore];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Knowledge.QuestionScore, objvQuestionnaire_Knowledge_Cond.QuestionScore, strComparisonOp_QuestionScore);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.QuestionName_Add) == true)
{
string strComparisonOp_QuestionName_Add = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionName_Add];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.QuestionName_Add, objvQuestionnaire_Knowledge_Cond.QuestionName_Add, strComparisonOp_QuestionName_Add);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.DefaultValue) == true)
{
string strComparisonOp_DefaultValue = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.DefaultValue, objvQuestionnaire_Knowledge_Cond.DefaultValue, strComparisonOp_DefaultValue);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.TextDirectId) == true)
{
string strComparisonOp_TextDirectId = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.TextDirectId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.TextDirectId, objvQuestionnaire_Knowledge_Cond.TextDirectId, strComparisonOp_TextDirectId);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.TextDirectName) == true)
{
string strComparisonOp_TextDirectName = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.TextDirectName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.TextDirectName, objvQuestionnaire_Knowledge_Cond.TextDirectName, strComparisonOp_TextDirectName);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.FillInTextWidth) == true)
{
string strComparisonOp_FillInTextWidth = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.FillInTextWidth];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Knowledge.FillInTextWidth, objvQuestionnaire_Knowledge_Cond.FillInTextWidth, strComparisonOp_FillInTextWidth);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.MemoTextWidth) == true)
{
string strComparisonOp_MemoTextWidth = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.MemoTextWidth];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Knowledge.MemoTextWidth, objvQuestionnaire_Knowledge_Cond.MemoTextWidth, strComparisonOp_MemoTextWidth);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.CodeTab) == true)
{
string strComparisonOp_CodeTab = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.CodeTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.CodeTab, objvQuestionnaire_Knowledge_Cond.CodeTab, strComparisonOp_CodeTab);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.CodeTab_Code) == true)
{
string strComparisonOp_CodeTab_Code = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.CodeTab_Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.CodeTab_Code, objvQuestionnaire_Knowledge_Cond.CodeTab_Code, strComparisonOp_CodeTab_Code);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.CodeTab_Name) == true)
{
string strComparisonOp_CodeTab_Name = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.CodeTab_Name];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.CodeTab_Name, objvQuestionnaire_Knowledge_Cond.CodeTab_Name, strComparisonOp_CodeTab_Name);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.CodeTab_Condition) == true)
{
string strComparisonOp_CodeTab_Condition = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.CodeTab_Condition];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.CodeTab_Condition, objvQuestionnaire_Knowledge_Cond.CodeTab_Condition, strComparisonOp_CodeTab_Condition);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.RelaEvent) == true)
{
string strComparisonOp_RelaEvent = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.RelaEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.RelaEvent, objvQuestionnaire_Knowledge_Cond.RelaEvent, strComparisonOp_RelaEvent);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.FirstIndent) == true)
{
if (objvQuestionnaire_Knowledge_Cond.FirstIndent == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire_Knowledge.FirstIndent);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire_Knowledge.FirstIndent);
}
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.DefaultSelectItem) == true)
{
string strComparisonOp_DefaultSelectItem = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.DefaultSelectItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.DefaultSelectItem, objvQuestionnaire_Knowledge_Cond.DefaultSelectItem, strComparisonOp_DefaultSelectItem);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.IsAutoGridTitle) == true)
{
if (objvQuestionnaire_Knowledge_Cond.IsAutoGridTitle == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire_Knowledge.IsAutoGridTitle);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire_Knowledge.IsAutoGridTitle);
}
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.FillInTextHeight) == true)
{
string strComparisonOp_FillInTextHeight = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.FillInTextHeight];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Knowledge.FillInTextHeight, objvQuestionnaire_Knowledge_Cond.FillInTextHeight, strComparisonOp_FillInTextHeight);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.IsMulti4FillInText) == true)
{
if (objvQuestionnaire_Knowledge_Cond.IsMulti4FillInText == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire_Knowledge.IsMulti4FillInText);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire_Knowledge.IsMulti4FillInText);
}
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.CheckBoxLimitCount) == true)
{
string strComparisonOp_CheckBoxLimitCount = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.CheckBoxLimitCount];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Knowledge.CheckBoxLimitCount, objvQuestionnaire_Knowledge_Cond.CheckBoxLimitCount, strComparisonOp_CheckBoxLimitCount);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.RoleId) == true)
{
string strComparisonOp_RoleId = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.RoleId, objvQuestionnaire_Knowledge_Cond.RoleId, strComparisonOp_RoleId);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.RoleName) == true)
{
string strComparisonOp_RoleName = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.RoleName, objvQuestionnaire_Knowledge_Cond.RoleName, strComparisonOp_RoleName);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.IsShow) == true)
{
if (objvQuestionnaire_Knowledge_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire_Knowledge.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire_Knowledge.IsShow);
}
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.IsCast) == true)
{
if (objvQuestionnaire_Knowledge_Cond.IsCast == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire_Knowledge.IsCast);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire_Knowledge.IsCast);
}
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Knowledge.LikeCount, objvQuestionnaire_Knowledge_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.IsEffective) == true)
{
if (objvQuestionnaire_Knowledge_Cond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire_Knowledge.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire_Knowledge.IsEffective);
}
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.IsCanInPaper) == true)
{
if (objvQuestionnaire_Knowledge_Cond.IsCanInPaper == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire_Knowledge.IsCanInPaper);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire_Knowledge.IsCanInPaper);
}
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.UpdDate, objvQuestionnaire_Knowledge_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.UpdUser, objvQuestionnaire_Knowledge_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.Memo) == true)
{
string strComparisonOp_Memo = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.Memo, objvQuestionnaire_Knowledge_Cond.Memo, strComparisonOp_Memo);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.KnowledgeNum) == true)
{
string strComparisonOp_KnowledgeNum = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.KnowledgeNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Knowledge.KnowledgeNum, objvQuestionnaire_Knowledge_Cond.KnowledgeNum, strComparisonOp_KnowledgeNum);
}
if (objvQuestionnaire_Knowledge_Cond.IsUpdated(convQuestionnaire_Knowledge.AnswerNum) == true)
{
string strComparisonOp_AnswerNum = objvQuestionnaire_Knowledge_Cond.dicFldComparisonOp[convQuestionnaire_Knowledge.AnswerNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Knowledge.AnswerNum, objvQuestionnaire_Knowledge_Cond.AnswerNum, strComparisonOp_AnswerNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v题目表_知识点(vQuestionnaire_Knowledge)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionnaire_KnowledgeWApi
{
private static readonly string mstrApiControllerName = "vQuestionnaire_KnowledgeApi";

 public clsvQuestionnaire_KnowledgeWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v题目表_知识点]...","0");
List<clsvQuestionnaire_KnowledgeEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", convQuestionnaire_Knowledge.QuestionID); 
List<clsvQuestionnaire_KnowledgeEN> arrObjLst = clsvQuestionnaire_KnowledgeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = new clsvQuestionnaire_KnowledgeEN()
{
QuestionID = "0",
QuestionName = "选[v题目表_知识点]..."
};
arrObjLst.Insert(0, objvQuestionnaire_KnowledgeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQuestionnaire_Knowledge.QuestionID;
objComboBox.DisplayMember = convQuestionnaire_Knowledge.QuestionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQuestionID">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaire_KnowledgeEN GetObjByQuestionID(string strQuestionID)
{
string strAction = "GetObjByQuestionID";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = null;
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
objvQuestionnaire_KnowledgeEN = JsonConvert.DeserializeObject<clsvQuestionnaire_KnowledgeEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionnaire_KnowledgeEN;
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
public static clsvQuestionnaire_KnowledgeEN GetObjByQuestionID_WA_Cache(string strQuestionID, string strCourseId)
{
string strAction = "GetObjByQuestionID_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = null;
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
objvQuestionnaire_KnowledgeEN = JsonConvert.DeserializeObject<clsvQuestionnaire_KnowledgeEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionnaire_KnowledgeEN;
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
public static clsvQuestionnaire_KnowledgeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = null;
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
objvQuestionnaire_KnowledgeEN = JsonConvert.DeserializeObject<clsvQuestionnaire_KnowledgeEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionnaire_KnowledgeEN;
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
public static clsvQuestionnaire_KnowledgeEN GetObjByQuestionID_Cache(string strQuestionID, string strCourseId)
{
if (string.IsNullOrEmpty(strQuestionID) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvQuestionnaire_KnowledgeEN._CurrTabName_S, strCourseId);
List<clsvQuestionnaire_KnowledgeEN> arrvQuestionnaire_KnowledgeObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvQuestionnaire_KnowledgeEN> arrvQuestionnaire_KnowledgeObjLst_Sel =
from objvQuestionnaire_KnowledgeEN in arrvQuestionnaire_KnowledgeObjLst_Cache
where objvQuestionnaire_KnowledgeEN.QuestionID == strQuestionID
select objvQuestionnaire_KnowledgeEN;
if (arrvQuestionnaire_KnowledgeObjLst_Sel.Count() == 0)
{
   clsvQuestionnaire_KnowledgeEN obj = clsvQuestionnaire_KnowledgeWApi.GetObjByQuestionID(strQuestionID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvQuestionnaire_KnowledgeObjLst_Sel.First();
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
string strKey = string.Format("{0}_{1}", clsvQuestionnaire_KnowledgeEN._CurrTabName_S, strCourseId);
List<clsvQuestionnaire_KnowledgeEN> arrvQuestionnaire_KnowledgeObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvQuestionnaire_KnowledgeEN> arrvQuestionnaire_KnowledgeObjLst_Sel1 =
from objvQuestionnaire_KnowledgeEN in arrvQuestionnaire_KnowledgeObjLst_Cache
where objvQuestionnaire_KnowledgeEN.QuestionID == strQuestionID
select objvQuestionnaire_KnowledgeEN;
List <clsvQuestionnaire_KnowledgeEN> arrvQuestionnaire_KnowledgeObjLst_Sel = new List<clsvQuestionnaire_KnowledgeEN>();
foreach (clsvQuestionnaire_KnowledgeEN obj in arrvQuestionnaire_KnowledgeObjLst_Sel1)
{
arrvQuestionnaire_KnowledgeObjLst_Sel.Add(obj);
}
if (arrvQuestionnaire_KnowledgeObjLst_Sel.Count > 0)
{
return arrvQuestionnaire_KnowledgeObjLst_Sel[0].QuestionName;
}
string strErrMsgForGetObjById = string.Format("在vQuestionnaire_Knowledge对象缓存列表中,找不到记录[QuestionID = {0}](函数:{1})", strQuestionID, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvQuestionnaire_KnowledgeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
string strKey = string.Format("{0}_{1}", clsvQuestionnaire_KnowledgeEN._CurrTabName_S, strCourseId);
List<clsvQuestionnaire_KnowledgeEN> arrvQuestionnaire_KnowledgeObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvQuestionnaire_KnowledgeEN> arrvQuestionnaire_KnowledgeObjLst_Sel1 =
from objvQuestionnaire_KnowledgeEN in arrvQuestionnaire_KnowledgeObjLst_Cache
where objvQuestionnaire_KnowledgeEN.QuestionID == strQuestionID
select objvQuestionnaire_KnowledgeEN;
List <clsvQuestionnaire_KnowledgeEN> arrvQuestionnaire_KnowledgeObjLst_Sel = new List<clsvQuestionnaire_KnowledgeEN>();
foreach (clsvQuestionnaire_KnowledgeEN obj in arrvQuestionnaire_KnowledgeObjLst_Sel1)
{
arrvQuestionnaire_KnowledgeObjLst_Sel.Add(obj);
}
if (arrvQuestionnaire_KnowledgeObjLst_Sel.Count > 0)
{
return arrvQuestionnaire_KnowledgeObjLst_Sel[0].QuestionName;
}
string strErrMsgForGetObjById = string.Format("在vQuestionnaire_Knowledge对象缓存列表中,找不到记录的相关名称[QuestionID = {0}](函数:{1})", strQuestionID, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvQuestionnaire_KnowledgeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaire_KnowledgeEN> GetObjLst(string strWhereCond)
{
 List<clsvQuestionnaire_KnowledgeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire_KnowledgeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaire_KnowledgeEN> GetObjLstByQuestionIDLst(List<string> arrQuestionID)
{
 List<clsvQuestionnaire_KnowledgeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire_KnowledgeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvQuestionnaire_KnowledgeEN> GetObjLstByQuestionIDLst_Cache(List<string> arrQuestionID, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvQuestionnaire_KnowledgeEN._CurrTabName_S, strCourseId);
List<clsvQuestionnaire_KnowledgeEN> arrvQuestionnaire_KnowledgeObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvQuestionnaire_KnowledgeEN> arrvQuestionnaire_KnowledgeObjLst_Sel =
from objvQuestionnaire_KnowledgeEN in arrvQuestionnaire_KnowledgeObjLst_Cache
where arrQuestionID.Contains(objvQuestionnaire_KnowledgeEN.QuestionID)
select objvQuestionnaire_KnowledgeEN;
return arrvQuestionnaire_KnowledgeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaire_KnowledgeEN> GetObjLstByQuestionIDLst_WA_Cache(List<string> arrQuestionID, string strCourseId)
{
 List<clsvQuestionnaire_KnowledgeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire_KnowledgeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaire_KnowledgeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQuestionnaire_KnowledgeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire_KnowledgeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaire_KnowledgeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQuestionnaire_KnowledgeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire_KnowledgeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaire_KnowledgeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQuestionnaire_KnowledgeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire_KnowledgeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaire_KnowledgeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvQuestionnaire_KnowledgeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire_KnowledgeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeENS">源对象</param>
 /// <param name = "objvQuestionnaire_KnowledgeENT">目标对象</param>
 public static void CopyTo(clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeENS, clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeENT)
{
try
{
objvQuestionnaire_KnowledgeENT.QuestionID = objvQuestionnaire_KnowledgeENS.QuestionID; //题目ID
objvQuestionnaire_KnowledgeENT.QuestionIndex = objvQuestionnaire_KnowledgeENS.QuestionIndex; //题目序号
objvQuestionnaire_KnowledgeENT.QuestionName = objvQuestionnaire_KnowledgeENS.QuestionName; //题目名称
objvQuestionnaire_KnowledgeENT.QuestionContent = objvQuestionnaire_KnowledgeENS.QuestionContent; //题目内容
objvQuestionnaire_KnowledgeENT.QuestionMemo = objvQuestionnaire_KnowledgeENS.QuestionMemo; //题目说明
objvQuestionnaire_KnowledgeENT.QuestionNo = objvQuestionnaire_KnowledgeENS.QuestionNo; //题目编号
objvQuestionnaire_KnowledgeENT.ExamAnswer = objvQuestionnaire_KnowledgeENS.ExamAnswer; //题目答案
objvQuestionnaire_KnowledgeENT.CourseId = objvQuestionnaire_KnowledgeENS.CourseId; //课程Id
objvQuestionnaire_KnowledgeENT.CourseName = objvQuestionnaire_KnowledgeENS.CourseName; //课程名称
objvQuestionnaire_KnowledgeENT.CourseChapterId = objvQuestionnaire_KnowledgeENS.CourseChapterId; //课程章节ID
objvQuestionnaire_KnowledgeENT.CourseChapterName = objvQuestionnaire_KnowledgeENS.CourseChapterName; //课程章节名称
objvQuestionnaire_KnowledgeENT.ChapterId = objvQuestionnaire_KnowledgeENS.ChapterId; //章Id
objvQuestionnaire_KnowledgeENT.SectionId = objvQuestionnaire_KnowledgeENS.SectionId; //节Id
objvQuestionnaire_KnowledgeENT.ChapterName = objvQuestionnaire_KnowledgeENS.ChapterName; //章名
objvQuestionnaire_KnowledgeENT.SectionName = objvQuestionnaire_KnowledgeENS.SectionName; //节名
objvQuestionnaire_KnowledgeENT.ChapterName_Sim = objvQuestionnaire_KnowledgeENS.ChapterName_Sim; //章名简称
objvQuestionnaire_KnowledgeENT.SectionName_Sim = objvQuestionnaire_KnowledgeENS.SectionName_Sim; //节名简称
objvQuestionnaire_KnowledgeENT.ParentNodeID = objvQuestionnaire_KnowledgeENS.ParentNodeID; //父节点编号
objvQuestionnaire_KnowledgeENT.CourseChapterReferred = objvQuestionnaire_KnowledgeENS.CourseChapterReferred; //节简称
objvQuestionnaire_KnowledgeENT.ParentNodeName = objvQuestionnaire_KnowledgeENS.ParentNodeName; //父节点名称
objvQuestionnaire_KnowledgeENT.ParentNodeReferred = objvQuestionnaire_KnowledgeENS.ParentNodeReferred; //章简称
objvQuestionnaire_KnowledgeENT.QuestionTypeId = objvQuestionnaire_KnowledgeENS.QuestionTypeId; //题目类型Id
objvQuestionnaire_KnowledgeENT.QuestionTypeName = objvQuestionnaire_KnowledgeENS.QuestionTypeName; //题目类型名
objvQuestionnaire_KnowledgeENT.ExamGradeId = objvQuestionnaire_KnowledgeENS.ExamGradeId; //题库等级ID
objvQuestionnaire_KnowledgeENT.ExamGradeName = objvQuestionnaire_KnowledgeENS.ExamGradeName; //题库等级名
objvQuestionnaire_KnowledgeENT.AnswerTypeId = objvQuestionnaire_KnowledgeENS.AnswerTypeId; //答案类型ID
objvQuestionnaire_KnowledgeENT.AnswerTypeName = objvQuestionnaire_KnowledgeENS.AnswerTypeName; //答案类型名
objvQuestionnaire_KnowledgeENT.GridTitle = objvQuestionnaire_KnowledgeENS.GridTitle; //表格标题
objvQuestionnaire_KnowledgeENT.AnswerModeId = objvQuestionnaire_KnowledgeENS.AnswerModeId; //答案模式Id
objvQuestionnaire_KnowledgeENT.AnswerModeName = objvQuestionnaire_KnowledgeENS.AnswerModeName; //答案模式名称
objvQuestionnaire_KnowledgeENT.IsHaveAdditionalMemo = objvQuestionnaire_KnowledgeENS.IsHaveAdditionalMemo; //是否有附加说明
objvQuestionnaire_KnowledgeENT.QuestionnaireSetId = objvQuestionnaire_KnowledgeENS.QuestionnaireSetId; //问卷集ID
objvQuestionnaire_KnowledgeENT.QuestionnaireSetName = objvQuestionnaire_KnowledgeENS.QuestionnaireSetName; //问卷集名
objvQuestionnaire_KnowledgeENT.QuestionScore = objvQuestionnaire_KnowledgeENS.QuestionScore; //题目得分
objvQuestionnaire_KnowledgeENT.QuestionName_Add = objvQuestionnaire_KnowledgeENS.QuestionName_Add; //题目补充
objvQuestionnaire_KnowledgeENT.DefaultValue = objvQuestionnaire_KnowledgeENS.DefaultValue; //缺省值
objvQuestionnaire_KnowledgeENT.TextDirectId = objvQuestionnaire_KnowledgeENS.TextDirectId; //文本方向ID
objvQuestionnaire_KnowledgeENT.TextDirectName = objvQuestionnaire_KnowledgeENS.TextDirectName; //文本方向名
objvQuestionnaire_KnowledgeENT.FillInTextWidth = objvQuestionnaire_KnowledgeENS.FillInTextWidth; //填空框宽度
objvQuestionnaire_KnowledgeENT.MemoTextWidth = objvQuestionnaire_KnowledgeENS.MemoTextWidth; //备注框宽度
objvQuestionnaire_KnowledgeENT.CodeTab = objvQuestionnaire_KnowledgeENS.CodeTab; //代码表
objvQuestionnaire_KnowledgeENT.CodeTab_Code = objvQuestionnaire_KnowledgeENS.CodeTab_Code; //CodeTab_Code
objvQuestionnaire_KnowledgeENT.CodeTab_Name = objvQuestionnaire_KnowledgeENS.CodeTab_Name; //CodeTab_Name
objvQuestionnaire_KnowledgeENT.CodeTab_Condition = objvQuestionnaire_KnowledgeENS.CodeTab_Condition; //代码表_条件
objvQuestionnaire_KnowledgeENT.RelaEvent = objvQuestionnaire_KnowledgeENS.RelaEvent; //相关事件
objvQuestionnaire_KnowledgeENT.FirstIndent = objvQuestionnaire_KnowledgeENS.FirstIndent; //首行缩进
objvQuestionnaire_KnowledgeENT.DefaultSelectItem = objvQuestionnaire_KnowledgeENS.DefaultSelectItem; //默认选项
objvQuestionnaire_KnowledgeENT.IsAutoGridTitle = objvQuestionnaire_KnowledgeENS.IsAutoGridTitle; //是否自动编表格标题
objvQuestionnaire_KnowledgeENT.FillInTextHeight = objvQuestionnaire_KnowledgeENS.FillInTextHeight; //填空框高度
objvQuestionnaire_KnowledgeENT.IsMulti4FillInText = objvQuestionnaire_KnowledgeENS.IsMulti4FillInText; //是否填空框多行
objvQuestionnaire_KnowledgeENT.CheckBoxLimitCount = objvQuestionnaire_KnowledgeENS.CheckBoxLimitCount; //复选框限制数
objvQuestionnaire_KnowledgeENT.RoleId = objvQuestionnaire_KnowledgeENS.RoleId; //角色Id
objvQuestionnaire_KnowledgeENT.RoleName = objvQuestionnaire_KnowledgeENS.RoleName; //角色名
objvQuestionnaire_KnowledgeENT.IsShow = objvQuestionnaire_KnowledgeENS.IsShow; //是否启用
objvQuestionnaire_KnowledgeENT.IsCast = objvQuestionnaire_KnowledgeENS.IsCast; //是否播放
objvQuestionnaire_KnowledgeENT.LikeCount = objvQuestionnaire_KnowledgeENS.LikeCount; //资源喜欢数量
objvQuestionnaire_KnowledgeENT.IsEffective = objvQuestionnaire_KnowledgeENS.IsEffective; //是否有效
objvQuestionnaire_KnowledgeENT.IsCanInPaper = objvQuestionnaire_KnowledgeENS.IsCanInPaper; //是否可在Paper
objvQuestionnaire_KnowledgeENT.UpdDate = objvQuestionnaire_KnowledgeENS.UpdDate; //修改日期
objvQuestionnaire_KnowledgeENT.UpdUser = objvQuestionnaire_KnowledgeENS.UpdUser; //修改人
objvQuestionnaire_KnowledgeENT.Memo = objvQuestionnaire_KnowledgeENS.Memo; //备注
objvQuestionnaire_KnowledgeENT.KnowledgeNum = objvQuestionnaire_KnowledgeENS.KnowledgeNum; //知识点数
objvQuestionnaire_KnowledgeENT.AnswerNum = objvQuestionnaire_KnowledgeENS.AnswerNum; //答案数
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
public static DataTable ToDataTable(List<clsvQuestionnaire_KnowledgeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQuestionnaire_KnowledgeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQuestionnaire_KnowledgeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQuestionnaire_KnowledgeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQuestionnaire_KnowledgeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQuestionnaire_KnowledgeEN.AttributeName)
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
if (clsQuestionnaireSetWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireSetWApi没有刷新缓存机制(clsQuestionnaireSetWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeWApi没有刷新缓存机制(clsQuestionTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserRolesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserRolesWApi没有刷新缓存机制(clsUserRolesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTextDirectWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTextDirectWApi没有刷新缓存机制(clsTextDirectWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by QuestionID");
//if (arrvQuestionnaire_KnowledgeObjLst_Cache == null)
//{
//arrvQuestionnaire_KnowledgeObjLst_Cache = await clsvQuestionnaire_KnowledgeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvQuestionnaire_KnowledgeEN._CurrTabName_S, strCourseId);
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
public static List<clsvQuestionnaire_KnowledgeEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvQuestionnaire_KnowledgeEN._CurrTabName_S, strCourseId);
List<clsvQuestionnaire_KnowledgeEN> arrvQuestionnaire_KnowledgeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvQuestionnaire_KnowledgeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQuestionnaire_KnowledgeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQuestionnaire_Knowledge.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionnaire_Knowledge.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.QuestionContent, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.QuestionMemo, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.QuestionNo, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.ExamAnswer, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.SectionId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.CourseChapterReferred, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.ParentNodeReferred, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.ExamGradeId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.ExamGradeName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.AnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.AnswerTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.GridTitle, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.AnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.AnswerModeName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.IsHaveAdditionalMemo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQuestionnaire_Knowledge.QuestionnaireSetId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.QuestionnaireSetName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.QuestionScore, Type.GetType("System.Single"));
objDT.Columns.Add(convQuestionnaire_Knowledge.QuestionName_Add, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.TextDirectId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.TextDirectName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.FillInTextWidth, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionnaire_Knowledge.MemoTextWidth, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionnaire_Knowledge.CodeTab, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.CodeTab_Code, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.CodeTab_Name, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.CodeTab_Condition, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.RelaEvent, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.FirstIndent, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQuestionnaire_Knowledge.DefaultSelectItem, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.IsAutoGridTitle, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQuestionnaire_Knowledge.FillInTextHeight, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionnaire_Knowledge.IsMulti4FillInText, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQuestionnaire_Knowledge.CheckBoxLimitCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionnaire_Knowledge.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.RoleName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQuestionnaire_Knowledge.IsCast, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQuestionnaire_Knowledge.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convQuestionnaire_Knowledge.IsEffective, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQuestionnaire_Knowledge.IsCanInPaper, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQuestionnaire_Knowledge.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Knowledge.KnowledgeNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionnaire_Knowledge.AnswerNum, Type.GetType("System.Int32"));
foreach (clsvQuestionnaire_KnowledgeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQuestionnaire_Knowledge.QuestionID] = objInFor[convQuestionnaire_Knowledge.QuestionID];
objDR[convQuestionnaire_Knowledge.QuestionIndex] = objInFor[convQuestionnaire_Knowledge.QuestionIndex];
objDR[convQuestionnaire_Knowledge.QuestionName] = objInFor[convQuestionnaire_Knowledge.QuestionName];
objDR[convQuestionnaire_Knowledge.QuestionContent] = objInFor[convQuestionnaire_Knowledge.QuestionContent];
objDR[convQuestionnaire_Knowledge.QuestionMemo] = objInFor[convQuestionnaire_Knowledge.QuestionMemo];
objDR[convQuestionnaire_Knowledge.QuestionNo] = objInFor[convQuestionnaire_Knowledge.QuestionNo];
objDR[convQuestionnaire_Knowledge.ExamAnswer] = objInFor[convQuestionnaire_Knowledge.ExamAnswer];
objDR[convQuestionnaire_Knowledge.CourseId] = objInFor[convQuestionnaire_Knowledge.CourseId];
objDR[convQuestionnaire_Knowledge.CourseName] = objInFor[convQuestionnaire_Knowledge.CourseName];
objDR[convQuestionnaire_Knowledge.CourseChapterId] = objInFor[convQuestionnaire_Knowledge.CourseChapterId];
objDR[convQuestionnaire_Knowledge.CourseChapterName] = objInFor[convQuestionnaire_Knowledge.CourseChapterName];
objDR[convQuestionnaire_Knowledge.ChapterId] = objInFor[convQuestionnaire_Knowledge.ChapterId];
objDR[convQuestionnaire_Knowledge.SectionId] = objInFor[convQuestionnaire_Knowledge.SectionId];
objDR[convQuestionnaire_Knowledge.ChapterName] = objInFor[convQuestionnaire_Knowledge.ChapterName];
objDR[convQuestionnaire_Knowledge.SectionName] = objInFor[convQuestionnaire_Knowledge.SectionName];
objDR[convQuestionnaire_Knowledge.ChapterName_Sim] = objInFor[convQuestionnaire_Knowledge.ChapterName_Sim];
objDR[convQuestionnaire_Knowledge.SectionName_Sim] = objInFor[convQuestionnaire_Knowledge.SectionName_Sim];
objDR[convQuestionnaire_Knowledge.ParentNodeID] = objInFor[convQuestionnaire_Knowledge.ParentNodeID];
objDR[convQuestionnaire_Knowledge.CourseChapterReferred] = objInFor[convQuestionnaire_Knowledge.CourseChapterReferred];
objDR[convQuestionnaire_Knowledge.ParentNodeName] = objInFor[convQuestionnaire_Knowledge.ParentNodeName];
objDR[convQuestionnaire_Knowledge.ParentNodeReferred] = objInFor[convQuestionnaire_Knowledge.ParentNodeReferred];
objDR[convQuestionnaire_Knowledge.QuestionTypeId] = objInFor[convQuestionnaire_Knowledge.QuestionTypeId];
objDR[convQuestionnaire_Knowledge.QuestionTypeName] = objInFor[convQuestionnaire_Knowledge.QuestionTypeName];
objDR[convQuestionnaire_Knowledge.ExamGradeId] = objInFor[convQuestionnaire_Knowledge.ExamGradeId];
objDR[convQuestionnaire_Knowledge.ExamGradeName] = objInFor[convQuestionnaire_Knowledge.ExamGradeName];
objDR[convQuestionnaire_Knowledge.AnswerTypeId] = objInFor[convQuestionnaire_Knowledge.AnswerTypeId];
objDR[convQuestionnaire_Knowledge.AnswerTypeName] = objInFor[convQuestionnaire_Knowledge.AnswerTypeName];
objDR[convQuestionnaire_Knowledge.GridTitle] = objInFor[convQuestionnaire_Knowledge.GridTitle];
objDR[convQuestionnaire_Knowledge.AnswerModeId] = objInFor[convQuestionnaire_Knowledge.AnswerModeId];
objDR[convQuestionnaire_Knowledge.AnswerModeName] = objInFor[convQuestionnaire_Knowledge.AnswerModeName];
objDR[convQuestionnaire_Knowledge.IsHaveAdditionalMemo] = objInFor[convQuestionnaire_Knowledge.IsHaveAdditionalMemo];
objDR[convQuestionnaire_Knowledge.QuestionnaireSetId] = objInFor[convQuestionnaire_Knowledge.QuestionnaireSetId];
objDR[convQuestionnaire_Knowledge.QuestionnaireSetName] = objInFor[convQuestionnaire_Knowledge.QuestionnaireSetName];
objDR[convQuestionnaire_Knowledge.QuestionScore] = objInFor[convQuestionnaire_Knowledge.QuestionScore];
objDR[convQuestionnaire_Knowledge.QuestionName_Add] = objInFor[convQuestionnaire_Knowledge.QuestionName_Add];
objDR[convQuestionnaire_Knowledge.DefaultValue] = objInFor[convQuestionnaire_Knowledge.DefaultValue];
objDR[convQuestionnaire_Knowledge.TextDirectId] = objInFor[convQuestionnaire_Knowledge.TextDirectId];
objDR[convQuestionnaire_Knowledge.TextDirectName] = objInFor[convQuestionnaire_Knowledge.TextDirectName];
objDR[convQuestionnaire_Knowledge.FillInTextWidth] = objInFor[convQuestionnaire_Knowledge.FillInTextWidth];
objDR[convQuestionnaire_Knowledge.MemoTextWidth] = objInFor[convQuestionnaire_Knowledge.MemoTextWidth];
objDR[convQuestionnaire_Knowledge.CodeTab] = objInFor[convQuestionnaire_Knowledge.CodeTab];
objDR[convQuestionnaire_Knowledge.CodeTab_Code] = objInFor[convQuestionnaire_Knowledge.CodeTab_Code];
objDR[convQuestionnaire_Knowledge.CodeTab_Name] = objInFor[convQuestionnaire_Knowledge.CodeTab_Name];
objDR[convQuestionnaire_Knowledge.CodeTab_Condition] = objInFor[convQuestionnaire_Knowledge.CodeTab_Condition];
objDR[convQuestionnaire_Knowledge.RelaEvent] = objInFor[convQuestionnaire_Knowledge.RelaEvent];
objDR[convQuestionnaire_Knowledge.FirstIndent] = objInFor[convQuestionnaire_Knowledge.FirstIndent];
objDR[convQuestionnaire_Knowledge.DefaultSelectItem] = objInFor[convQuestionnaire_Knowledge.DefaultSelectItem];
objDR[convQuestionnaire_Knowledge.IsAutoGridTitle] = objInFor[convQuestionnaire_Knowledge.IsAutoGridTitle];
objDR[convQuestionnaire_Knowledge.FillInTextHeight] = objInFor[convQuestionnaire_Knowledge.FillInTextHeight];
objDR[convQuestionnaire_Knowledge.IsMulti4FillInText] = objInFor[convQuestionnaire_Knowledge.IsMulti4FillInText];
objDR[convQuestionnaire_Knowledge.CheckBoxLimitCount] = objInFor[convQuestionnaire_Knowledge.CheckBoxLimitCount];
objDR[convQuestionnaire_Knowledge.RoleId] = objInFor[convQuestionnaire_Knowledge.RoleId];
objDR[convQuestionnaire_Knowledge.RoleName] = objInFor[convQuestionnaire_Knowledge.RoleName];
objDR[convQuestionnaire_Knowledge.IsShow] = objInFor[convQuestionnaire_Knowledge.IsShow];
objDR[convQuestionnaire_Knowledge.IsCast] = objInFor[convQuestionnaire_Knowledge.IsCast];
objDR[convQuestionnaire_Knowledge.LikeCount] = objInFor[convQuestionnaire_Knowledge.LikeCount];
objDR[convQuestionnaire_Knowledge.IsEffective] = objInFor[convQuestionnaire_Knowledge.IsEffective];
objDR[convQuestionnaire_Knowledge.IsCanInPaper] = objInFor[convQuestionnaire_Knowledge.IsCanInPaper];
objDR[convQuestionnaire_Knowledge.UpdDate] = objInFor[convQuestionnaire_Knowledge.UpdDate];
objDR[convQuestionnaire_Knowledge.UpdUser] = objInFor[convQuestionnaire_Knowledge.UpdUser];
objDR[convQuestionnaire_Knowledge.Memo] = objInFor[convQuestionnaire_Knowledge.Memo];
objDR[convQuestionnaire_Knowledge.KnowledgeNum] = objInFor[convQuestionnaire_Knowledge.KnowledgeNum];
objDR[convQuestionnaire_Knowledge.AnswerNum] = objInFor[convQuestionnaire_Knowledge.AnswerNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}