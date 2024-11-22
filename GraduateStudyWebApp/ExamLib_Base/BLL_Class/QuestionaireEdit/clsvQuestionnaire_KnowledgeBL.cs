
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaire_KnowledgeBL
 表名:vQuestionnaire_Knowledge(01120143)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:29:18
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
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
public static class  clsvQuestionnaire_KnowledgeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaire_KnowledgeEN GetObj(this K_QuestionId_vQuestionnaire_Knowledge myKey)
{
clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = clsvQuestionnaire_KnowledgeBL.vQuestionnaire_KnowledgeDA.GetObjByQuestionId(myKey.Value);
return objvQuestionnaire_KnowledgeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, long lngQuestionId, string strComparisonOp="")
	{
objvQuestionnaire_KnowledgeEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.QuestionId) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.QuestionId, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionId] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionIndex(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, int? intQuestionIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strQuestionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionName, 500, convQuestionnaire_Knowledge.QuestionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionContent(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strQuestionContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, convQuestionnaire_Knowledge.QuestionContent);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionMemo(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strQuestionMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionMemo, 1000, convQuestionnaire_Knowledge.QuestionMemo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionNo(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strQuestionNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, convQuestionnaire_Knowledge.QuestionNo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetExamAnswer(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strExamAnswer, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamAnswer, 8000, convQuestionnaire_Knowledge.ExamAnswer);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetCourseId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convQuestionnaire_Knowledge.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convQuestionnaire_Knowledge.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetCourseName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convQuestionnaire_Knowledge.CourseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetCourseChapterId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convQuestionnaire_Knowledge.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convQuestionnaire_Knowledge.CourseChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetCourseChapterName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strCourseChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convQuestionnaire_Knowledge.CourseChapterName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetChapterId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterId, 8, convQuestionnaire_Knowledge.ChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convQuestionnaire_Knowledge.ChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetSectionId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, convQuestionnaire_Knowledge.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convQuestionnaire_Knowledge.SectionId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetChapterName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterName, 100, convQuestionnaire_Knowledge.ChapterName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetSectionName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convQuestionnaire_Knowledge.SectionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetChapterNameSim(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, convQuestionnaire_Knowledge.ChapterNameSim);
}
objvQuestionnaire_KnowledgeEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.ChapterNameSim) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.ChapterNameSim, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.ChapterNameSim] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetSectionNameSim(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strSectionNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionNameSim, 10, convQuestionnaire_Knowledge.SectionNameSim);
}
objvQuestionnaire_KnowledgeEN.SectionNameSim = strSectionNameSim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.SectionNameSim) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.SectionNameSim, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.SectionNameSim] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetParentNodeId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strParentNodeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeId, 8, convQuestionnaire_Knowledge.ParentNodeId);
}
objvQuestionnaire_KnowledgeEN.ParentNodeId = strParentNodeId; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.ParentNodeId) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.ParentNodeId, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.ParentNodeId] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetCourseChapterReferred(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strCourseChapterReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convQuestionnaire_Knowledge.CourseChapterReferred);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetParentNodeName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strParentNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeName, 100, convQuestionnaire_Knowledge.ParentNodeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetParentNodeReferred(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strParentNodeReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convQuestionnaire_Knowledge.ParentNodeReferred);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionTypeId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convQuestionnaire_Knowledge.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convQuestionnaire_Knowledge.QuestionTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionTypeName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strQuestionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convQuestionnaire_Knowledge.QuestionTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetExamGradeId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strExamGradeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamGradeId, 2, convQuestionnaire_Knowledge.ExamGradeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExamGradeId, 2, convQuestionnaire_Knowledge.ExamGradeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetExamGradeName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strExamGradeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamGradeName, 50, convQuestionnaire_Knowledge.ExamGradeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetAnswerTypeId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strAnswerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convQuestionnaire_Knowledge.AnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convQuestionnaire_Knowledge.AnswerTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetAnswerTypeName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strAnswerTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeName, 50, convQuestionnaire_Knowledge.AnswerTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetGridTitle(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strGridTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGridTitle, 30, convQuestionnaire_Knowledge.GridTitle);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetAnswerModeId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strAnswerModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convQuestionnaire_Knowledge.AnswerModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convQuestionnaire_Knowledge.AnswerModeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetAnswerModeName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strAnswerModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeName, 30, convQuestionnaire_Knowledge.AnswerModeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionnaireSetId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strQuestionnaireSetId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionnaireSetId, 4, convQuestionnaire_Knowledge.QuestionnaireSetId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionnaireSetId, 4, convQuestionnaire_Knowledge.QuestionnaireSetId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionnaireSetName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strQuestionnaireSetName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionnaireSetName, 50, convQuestionnaire_Knowledge.QuestionnaireSetName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionScore(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, float? fltQuestionScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetQuestionNameAdd(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strQuestionNameAdd, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionNameAdd, 500, convQuestionnaire_Knowledge.QuestionNameAdd);
}
objvQuestionnaire_KnowledgeEN.QuestionNameAdd = strQuestionNameAdd; //题目补充
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.QuestionNameAdd) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.QuestionNameAdd, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionNameAdd] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetDefaultValue(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strDefaultValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convQuestionnaire_Knowledge.DefaultValue);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetTextDirectId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strTextDirectId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextDirectId, 4, convQuestionnaire_Knowledge.TextDirectId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextDirectId, 4, convQuestionnaire_Knowledge.TextDirectId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetTextDirectName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strTextDirectName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextDirectName, 40, convQuestionnaire_Knowledge.TextDirectName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetFillInTextWidth(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, int? intFillInTextWidth, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetMemoTextWidth(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, int? intMemoTextWidth, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetCodeTab(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strCodeTab, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTab, 50, convQuestionnaire_Knowledge.CodeTab);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetCodeTabCode(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strCodeTabCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabCode, 50, convQuestionnaire_Knowledge.CodeTabCode);
}
objvQuestionnaire_KnowledgeEN.CodeTabCode = strCodeTabCode; //CodeTab_Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.CodeTabCode) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.CodeTabCode, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.CodeTabCode] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetCodeTabName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strCodeTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabName, 50, convQuestionnaire_Knowledge.CodeTabName);
}
objvQuestionnaire_KnowledgeEN.CodeTabName = strCodeTabName; //CodeTab_Name
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.CodeTabName) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.CodeTabName, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.CodeTabName] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetCodeTabCondition(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strCodeTabCondition, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabCondition, 200, convQuestionnaire_Knowledge.CodeTabCondition);
}
objvQuestionnaire_KnowledgeEN.CodeTabCondition = strCodeTabCondition; //代码表_条件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Knowledge.CodeTabCondition) == false)
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp.Add(convQuestionnaire_Knowledge.CodeTabCondition, strComparisonOp);
}
else
{
objvQuestionnaire_KnowledgeEN.dicFldComparisonOp[convQuestionnaire_Knowledge.CodeTabCondition] = strComparisonOp;
}
}
return objvQuestionnaire_KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetRelaEvent(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strRelaEvent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaEvent, 4000, convQuestionnaire_Knowledge.RelaEvent);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetDefaultSelectItem(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strDefaultSelectItem, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultSelectItem, 20, convQuestionnaire_Knowledge.DefaultSelectItem);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetFillInTextHeight(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, int? intFillInTextHeight, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetCheckBoxLimitCount(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, int? intCheckBoxLimitCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetRoleId(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQuestionnaire_Knowledge.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQuestionnaire_Knowledge.RoleId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetRoleName(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strRoleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleName, 100, convQuestionnaire_Knowledge.RoleName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetLikeCount(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, long? lngLikeCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetUpdDate(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQuestionnaire_Knowledge.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQuestionnaire_Knowledge.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetUpdUser(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convQuestionnaire_Knowledge.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQuestionnaire_Knowledge.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetMemo(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQuestionnaire_Knowledge.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetKnowledgeNum(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, int? intKnowledgeNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_KnowledgeEN SetAnswerNum(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN, int? intAnswerNum, string strComparisonOp="")
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeENS">源对象</param>
 /// <param name = "objvQuestionnaire_KnowledgeENT">目标对象</param>
 public static void CopyTo(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeENS, clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeENT)
{
try
{
objvQuestionnaire_KnowledgeENT.QuestionId = objvQuestionnaire_KnowledgeENS.QuestionId; //题目Id
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
objvQuestionnaire_KnowledgeENT.ChapterNameSim = objvQuestionnaire_KnowledgeENS.ChapterNameSim; //章名简称
objvQuestionnaire_KnowledgeENT.SectionNameSim = objvQuestionnaire_KnowledgeENS.SectionNameSim; //节名简称
objvQuestionnaire_KnowledgeENT.ParentNodeId = objvQuestionnaire_KnowledgeENS.ParentNodeId; //父节点编号
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
objvQuestionnaire_KnowledgeENT.QuestionNameAdd = objvQuestionnaire_KnowledgeENS.QuestionNameAdd; //题目补充
objvQuestionnaire_KnowledgeENT.DefaultValue = objvQuestionnaire_KnowledgeENS.DefaultValue; //缺省值
objvQuestionnaire_KnowledgeENT.TextDirectId = objvQuestionnaire_KnowledgeENS.TextDirectId; //文本方向ID
objvQuestionnaire_KnowledgeENT.TextDirectName = objvQuestionnaire_KnowledgeENS.TextDirectName; //文本方向名
objvQuestionnaire_KnowledgeENT.FillInTextWidth = objvQuestionnaire_KnowledgeENS.FillInTextWidth; //填空框宽度
objvQuestionnaire_KnowledgeENT.MemoTextWidth = objvQuestionnaire_KnowledgeENS.MemoTextWidth; //备注框宽度
objvQuestionnaire_KnowledgeENT.CodeTab = objvQuestionnaire_KnowledgeENS.CodeTab; //代码表
objvQuestionnaire_KnowledgeENT.CodeTabCode = objvQuestionnaire_KnowledgeENS.CodeTabCode; //CodeTab_Code
objvQuestionnaire_KnowledgeENT.CodeTabName = objvQuestionnaire_KnowledgeENS.CodeTabName; //CodeTab_Name
objvQuestionnaire_KnowledgeENT.CodeTabCondition = objvQuestionnaire_KnowledgeENS.CodeTabCondition; //代码表_条件
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
 /// <param name = "objvQuestionnaire_KnowledgeENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionnaire_KnowledgeEN:objvQuestionnaire_KnowledgeENT</returns>
 public static clsvQuestionnaire_KnowledgeEN CopyTo(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeENS)
{
try
{
 clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeENT = new clsvQuestionnaire_KnowledgeEN()
{
QuestionId = objvQuestionnaire_KnowledgeENS.QuestionId, //题目Id
QuestionIndex = objvQuestionnaire_KnowledgeENS.QuestionIndex, //题目序号
QuestionName = objvQuestionnaire_KnowledgeENS.QuestionName, //题目名称
QuestionContent = objvQuestionnaire_KnowledgeENS.QuestionContent, //题目内容
QuestionMemo = objvQuestionnaire_KnowledgeENS.QuestionMemo, //题目说明
QuestionNo = objvQuestionnaire_KnowledgeENS.QuestionNo, //题目编号
ExamAnswer = objvQuestionnaire_KnowledgeENS.ExamAnswer, //题目答案
CourseId = objvQuestionnaire_KnowledgeENS.CourseId, //课程Id
CourseName = objvQuestionnaire_KnowledgeENS.CourseName, //课程名称
CourseChapterId = objvQuestionnaire_KnowledgeENS.CourseChapterId, //课程章节ID
CourseChapterName = objvQuestionnaire_KnowledgeENS.CourseChapterName, //课程章节名称
ChapterId = objvQuestionnaire_KnowledgeENS.ChapterId, //章Id
SectionId = objvQuestionnaire_KnowledgeENS.SectionId, //节Id
ChapterName = objvQuestionnaire_KnowledgeENS.ChapterName, //章名
SectionName = objvQuestionnaire_KnowledgeENS.SectionName, //节名
ChapterNameSim = objvQuestionnaire_KnowledgeENS.ChapterNameSim, //章名简称
SectionNameSim = objvQuestionnaire_KnowledgeENS.SectionNameSim, //节名简称
ParentNodeId = objvQuestionnaire_KnowledgeENS.ParentNodeId, //父节点编号
CourseChapterReferred = objvQuestionnaire_KnowledgeENS.CourseChapterReferred, //节简称
ParentNodeName = objvQuestionnaire_KnowledgeENS.ParentNodeName, //父节点名称
ParentNodeReferred = objvQuestionnaire_KnowledgeENS.ParentNodeReferred, //章简称
QuestionTypeId = objvQuestionnaire_KnowledgeENS.QuestionTypeId, //题目类型Id
QuestionTypeName = objvQuestionnaire_KnowledgeENS.QuestionTypeName, //题目类型名
ExamGradeId = objvQuestionnaire_KnowledgeENS.ExamGradeId, //题库等级ID
ExamGradeName = objvQuestionnaire_KnowledgeENS.ExamGradeName, //题库等级名
AnswerTypeId = objvQuestionnaire_KnowledgeENS.AnswerTypeId, //答案类型ID
AnswerTypeName = objvQuestionnaire_KnowledgeENS.AnswerTypeName, //答案类型名
GridTitle = objvQuestionnaire_KnowledgeENS.GridTitle, //表格标题
AnswerModeId = objvQuestionnaire_KnowledgeENS.AnswerModeId, //答案模式Id
AnswerModeName = objvQuestionnaire_KnowledgeENS.AnswerModeName, //答案模式名称
IsHaveAdditionalMemo = objvQuestionnaire_KnowledgeENS.IsHaveAdditionalMemo, //是否有附加说明
QuestionnaireSetId = objvQuestionnaire_KnowledgeENS.QuestionnaireSetId, //问卷集ID
QuestionnaireSetName = objvQuestionnaire_KnowledgeENS.QuestionnaireSetName, //问卷集名
QuestionScore = objvQuestionnaire_KnowledgeENS.QuestionScore, //题目得分
QuestionNameAdd = objvQuestionnaire_KnowledgeENS.QuestionNameAdd, //题目补充
DefaultValue = objvQuestionnaire_KnowledgeENS.DefaultValue, //缺省值
TextDirectId = objvQuestionnaire_KnowledgeENS.TextDirectId, //文本方向ID
TextDirectName = objvQuestionnaire_KnowledgeENS.TextDirectName, //文本方向名
FillInTextWidth = objvQuestionnaire_KnowledgeENS.FillInTextWidth, //填空框宽度
MemoTextWidth = objvQuestionnaire_KnowledgeENS.MemoTextWidth, //备注框宽度
CodeTab = objvQuestionnaire_KnowledgeENS.CodeTab, //代码表
CodeTabCode = objvQuestionnaire_KnowledgeENS.CodeTabCode, //CodeTab_Code
CodeTabName = objvQuestionnaire_KnowledgeENS.CodeTabName, //CodeTab_Name
CodeTabCondition = objvQuestionnaire_KnowledgeENS.CodeTabCondition, //代码表_条件
RelaEvent = objvQuestionnaire_KnowledgeENS.RelaEvent, //相关事件
FirstIndent = objvQuestionnaire_KnowledgeENS.FirstIndent, //首行缩进
DefaultSelectItem = objvQuestionnaire_KnowledgeENS.DefaultSelectItem, //默认选项
IsAutoGridTitle = objvQuestionnaire_KnowledgeENS.IsAutoGridTitle, //是否自动编表格标题
FillInTextHeight = objvQuestionnaire_KnowledgeENS.FillInTextHeight, //填空框高度
IsMulti4FillInText = objvQuestionnaire_KnowledgeENS.IsMulti4FillInText, //是否填空框多行
CheckBoxLimitCount = objvQuestionnaire_KnowledgeENS.CheckBoxLimitCount, //复选框限制数
RoleId = objvQuestionnaire_KnowledgeENS.RoleId, //角色Id
RoleName = objvQuestionnaire_KnowledgeENS.RoleName, //角色名
IsShow = objvQuestionnaire_KnowledgeENS.IsShow, //是否启用
IsCast = objvQuestionnaire_KnowledgeENS.IsCast, //是否播放
LikeCount = objvQuestionnaire_KnowledgeENS.LikeCount, //资源喜欢数量
IsEffective = objvQuestionnaire_KnowledgeENS.IsEffective, //是否有效
IsCanInPaper = objvQuestionnaire_KnowledgeENS.IsCanInPaper, //是否可在Paper
UpdDate = objvQuestionnaire_KnowledgeENS.UpdDate, //修改日期
UpdUser = objvQuestionnaire_KnowledgeENS.UpdUser, //修改人
Memo = objvQuestionnaire_KnowledgeENS.Memo, //备注
KnowledgeNum = objvQuestionnaire_KnowledgeENS.KnowledgeNum, //知识点数
AnswerNum = objvQuestionnaire_KnowledgeENS.AnswerNum, //答案数
};
 return objvQuestionnaire_KnowledgeENT;
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
public static void CheckProperty4Condition(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN)
{
 clsvQuestionnaire_KnowledgeBL.vQuestionnaire_KnowledgeDA.CheckProperty4Condition(objvQuestionnaire_KnowledgeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.QuestionId) == true)
{
string strComparisonOpQuestionId = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Knowledge.QuestionId, objvQuestionnaire_KnowledgeCond.QuestionId, strComparisonOpQuestionId);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.QuestionIndex) == true)
{
string strComparisonOpQuestionIndex = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Knowledge.QuestionIndex, objvQuestionnaire_KnowledgeCond.QuestionIndex, strComparisonOpQuestionIndex);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.QuestionName) == true)
{
string strComparisonOpQuestionName = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.QuestionName, objvQuestionnaire_KnowledgeCond.QuestionName, strComparisonOpQuestionName);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.QuestionContent) == true)
{
string strComparisonOpQuestionContent = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.QuestionContent, objvQuestionnaire_KnowledgeCond.QuestionContent, strComparisonOpQuestionContent);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.QuestionMemo) == true)
{
string strComparisonOpQuestionMemo = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.QuestionMemo, objvQuestionnaire_KnowledgeCond.QuestionMemo, strComparisonOpQuestionMemo);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.QuestionNo) == true)
{
string strComparisonOpQuestionNo = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.QuestionNo, objvQuestionnaire_KnowledgeCond.QuestionNo, strComparisonOpQuestionNo);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.ExamAnswer) == true)
{
string strComparisonOpExamAnswer = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.ExamAnswer];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.ExamAnswer, objvQuestionnaire_KnowledgeCond.ExamAnswer, strComparisonOpExamAnswer);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.CourseId) == true)
{
string strComparisonOpCourseId = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.CourseId, objvQuestionnaire_KnowledgeCond.CourseId, strComparisonOpCourseId);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.CourseName) == true)
{
string strComparisonOpCourseName = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.CourseName, objvQuestionnaire_KnowledgeCond.CourseName, strComparisonOpCourseName);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.CourseChapterId, objvQuestionnaire_KnowledgeCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.CourseChapterName, objvQuestionnaire_KnowledgeCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.ChapterId) == true)
{
string strComparisonOpChapterId = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.ChapterId, objvQuestionnaire_KnowledgeCond.ChapterId, strComparisonOpChapterId);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.SectionId) == true)
{
string strComparisonOpSectionId = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.SectionId, objvQuestionnaire_KnowledgeCond.SectionId, strComparisonOpSectionId);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.ChapterName) == true)
{
string strComparisonOpChapterName = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.ChapterName, objvQuestionnaire_KnowledgeCond.ChapterName, strComparisonOpChapterName);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.SectionName) == true)
{
string strComparisonOpSectionName = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.SectionName, objvQuestionnaire_KnowledgeCond.SectionName, strComparisonOpSectionName);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.ChapterNameSim, objvQuestionnaire_KnowledgeCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.SectionNameSim) == true)
{
string strComparisonOpSectionNameSim = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.SectionNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.SectionNameSim, objvQuestionnaire_KnowledgeCond.SectionNameSim, strComparisonOpSectionNameSim);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.ParentNodeId) == true)
{
string strComparisonOpParentNodeId = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.ParentNodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.ParentNodeId, objvQuestionnaire_KnowledgeCond.ParentNodeId, strComparisonOpParentNodeId);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.CourseChapterReferred) == true)
{
string strComparisonOpCourseChapterReferred = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.CourseChapterReferred, objvQuestionnaire_KnowledgeCond.CourseChapterReferred, strComparisonOpCourseChapterReferred);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.ParentNodeName) == true)
{
string strComparisonOpParentNodeName = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.ParentNodeName, objvQuestionnaire_KnowledgeCond.ParentNodeName, strComparisonOpParentNodeName);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.ParentNodeReferred) == true)
{
string strComparisonOpParentNodeReferred = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.ParentNodeReferred, objvQuestionnaire_KnowledgeCond.ParentNodeReferred, strComparisonOpParentNodeReferred);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.QuestionTypeId, objvQuestionnaire_KnowledgeCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.QuestionTypeName) == true)
{
string strComparisonOpQuestionTypeName = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.QuestionTypeName, objvQuestionnaire_KnowledgeCond.QuestionTypeName, strComparisonOpQuestionTypeName);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.ExamGradeId) == true)
{
string strComparisonOpExamGradeId = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.ExamGradeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.ExamGradeId, objvQuestionnaire_KnowledgeCond.ExamGradeId, strComparisonOpExamGradeId);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.ExamGradeName) == true)
{
string strComparisonOpExamGradeName = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.ExamGradeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.ExamGradeName, objvQuestionnaire_KnowledgeCond.ExamGradeName, strComparisonOpExamGradeName);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.AnswerTypeId) == true)
{
string strComparisonOpAnswerTypeId = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.AnswerTypeId, objvQuestionnaire_KnowledgeCond.AnswerTypeId, strComparisonOpAnswerTypeId);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.AnswerTypeName) == true)
{
string strComparisonOpAnswerTypeName = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.AnswerTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.AnswerTypeName, objvQuestionnaire_KnowledgeCond.AnswerTypeName, strComparisonOpAnswerTypeName);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.GridTitle) == true)
{
string strComparisonOpGridTitle = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.GridTitle, objvQuestionnaire_KnowledgeCond.GridTitle, strComparisonOpGridTitle);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.AnswerModeId) == true)
{
string strComparisonOpAnswerModeId = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.AnswerModeId, objvQuestionnaire_KnowledgeCond.AnswerModeId, strComparisonOpAnswerModeId);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.AnswerModeName) == true)
{
string strComparisonOpAnswerModeName = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.AnswerModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.AnswerModeName, objvQuestionnaire_KnowledgeCond.AnswerModeName, strComparisonOpAnswerModeName);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.IsHaveAdditionalMemo) == true)
{
if (objvQuestionnaire_KnowledgeCond.IsHaveAdditionalMemo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire_Knowledge.IsHaveAdditionalMemo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire_Knowledge.IsHaveAdditionalMemo);
}
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.QuestionnaireSetId) == true)
{
string strComparisonOpQuestionnaireSetId = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionnaireSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.QuestionnaireSetId, objvQuestionnaire_KnowledgeCond.QuestionnaireSetId, strComparisonOpQuestionnaireSetId);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.QuestionnaireSetName) == true)
{
string strComparisonOpQuestionnaireSetName = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionnaireSetName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.QuestionnaireSetName, objvQuestionnaire_KnowledgeCond.QuestionnaireSetName, strComparisonOpQuestionnaireSetName);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.QuestionScore) == true)
{
string strComparisonOpQuestionScore = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionScore];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Knowledge.QuestionScore, objvQuestionnaire_KnowledgeCond.QuestionScore, strComparisonOpQuestionScore);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.QuestionNameAdd) == true)
{
string strComparisonOpQuestionNameAdd = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.QuestionNameAdd];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.QuestionNameAdd, objvQuestionnaire_KnowledgeCond.QuestionNameAdd, strComparisonOpQuestionNameAdd);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.DefaultValue, objvQuestionnaire_KnowledgeCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.TextDirectId) == true)
{
string strComparisonOpTextDirectId = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.TextDirectId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.TextDirectId, objvQuestionnaire_KnowledgeCond.TextDirectId, strComparisonOpTextDirectId);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.TextDirectName) == true)
{
string strComparisonOpTextDirectName = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.TextDirectName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.TextDirectName, objvQuestionnaire_KnowledgeCond.TextDirectName, strComparisonOpTextDirectName);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.FillInTextWidth) == true)
{
string strComparisonOpFillInTextWidth = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.FillInTextWidth];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Knowledge.FillInTextWidth, objvQuestionnaire_KnowledgeCond.FillInTextWidth, strComparisonOpFillInTextWidth);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.MemoTextWidth) == true)
{
string strComparisonOpMemoTextWidth = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.MemoTextWidth];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Knowledge.MemoTextWidth, objvQuestionnaire_KnowledgeCond.MemoTextWidth, strComparisonOpMemoTextWidth);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.CodeTab) == true)
{
string strComparisonOpCodeTab = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.CodeTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.CodeTab, objvQuestionnaire_KnowledgeCond.CodeTab, strComparisonOpCodeTab);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.CodeTabCode) == true)
{
string strComparisonOpCodeTabCode = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.CodeTabCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.CodeTabCode, objvQuestionnaire_KnowledgeCond.CodeTabCode, strComparisonOpCodeTabCode);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.CodeTabName) == true)
{
string strComparisonOpCodeTabName = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.CodeTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.CodeTabName, objvQuestionnaire_KnowledgeCond.CodeTabName, strComparisonOpCodeTabName);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.CodeTabCondition) == true)
{
string strComparisonOpCodeTabCondition = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.CodeTabCondition];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.CodeTabCondition, objvQuestionnaire_KnowledgeCond.CodeTabCondition, strComparisonOpCodeTabCondition);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.RelaEvent) == true)
{
string strComparisonOpRelaEvent = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.RelaEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.RelaEvent, objvQuestionnaire_KnowledgeCond.RelaEvent, strComparisonOpRelaEvent);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.FirstIndent) == true)
{
if (objvQuestionnaire_KnowledgeCond.FirstIndent == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire_Knowledge.FirstIndent);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire_Knowledge.FirstIndent);
}
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.DefaultSelectItem) == true)
{
string strComparisonOpDefaultSelectItem = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.DefaultSelectItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.DefaultSelectItem, objvQuestionnaire_KnowledgeCond.DefaultSelectItem, strComparisonOpDefaultSelectItem);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.IsAutoGridTitle) == true)
{
if (objvQuestionnaire_KnowledgeCond.IsAutoGridTitle == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire_Knowledge.IsAutoGridTitle);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire_Knowledge.IsAutoGridTitle);
}
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.FillInTextHeight) == true)
{
string strComparisonOpFillInTextHeight = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.FillInTextHeight];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Knowledge.FillInTextHeight, objvQuestionnaire_KnowledgeCond.FillInTextHeight, strComparisonOpFillInTextHeight);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.IsMulti4FillInText) == true)
{
if (objvQuestionnaire_KnowledgeCond.IsMulti4FillInText == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire_Knowledge.IsMulti4FillInText);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire_Knowledge.IsMulti4FillInText);
}
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.CheckBoxLimitCount) == true)
{
string strComparisonOpCheckBoxLimitCount = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.CheckBoxLimitCount];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Knowledge.CheckBoxLimitCount, objvQuestionnaire_KnowledgeCond.CheckBoxLimitCount, strComparisonOpCheckBoxLimitCount);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.RoleId) == true)
{
string strComparisonOpRoleId = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.RoleId, objvQuestionnaire_KnowledgeCond.RoleId, strComparisonOpRoleId);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.RoleName) == true)
{
string strComparisonOpRoleName = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.RoleName, objvQuestionnaire_KnowledgeCond.RoleName, strComparisonOpRoleName);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.IsShow) == true)
{
if (objvQuestionnaire_KnowledgeCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire_Knowledge.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire_Knowledge.IsShow);
}
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.IsCast) == true)
{
if (objvQuestionnaire_KnowledgeCond.IsCast == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire_Knowledge.IsCast);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire_Knowledge.IsCast);
}
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.LikeCount) == true)
{
string strComparisonOpLikeCount = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Knowledge.LikeCount, objvQuestionnaire_KnowledgeCond.LikeCount, strComparisonOpLikeCount);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.IsEffective) == true)
{
if (objvQuestionnaire_KnowledgeCond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire_Knowledge.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire_Knowledge.IsEffective);
}
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.IsCanInPaper) == true)
{
if (objvQuestionnaire_KnowledgeCond.IsCanInPaper == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire_Knowledge.IsCanInPaper);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire_Knowledge.IsCanInPaper);
}
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.UpdDate, objvQuestionnaire_KnowledgeCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.UpdUser) == true)
{
string strComparisonOpUpdUser = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.UpdUser, objvQuestionnaire_KnowledgeCond.UpdUser, strComparisonOpUpdUser);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.Memo) == true)
{
string strComparisonOpMemo = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Knowledge.Memo, objvQuestionnaire_KnowledgeCond.Memo, strComparisonOpMemo);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.KnowledgeNum) == true)
{
string strComparisonOpKnowledgeNum = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.KnowledgeNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Knowledge.KnowledgeNum, objvQuestionnaire_KnowledgeCond.KnowledgeNum, strComparisonOpKnowledgeNum);
}
if (objvQuestionnaire_KnowledgeCond.IsUpdated(convQuestionnaire_Knowledge.AnswerNum) == true)
{
string strComparisonOpAnswerNum = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[convQuestionnaire_Knowledge.AnswerNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Knowledge.AnswerNum, objvQuestionnaire_KnowledgeCond.AnswerNum, strComparisonOpAnswerNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQuestionnaire_Knowledge
{
public virtual bool UpdRelaTabDate(long lngQuestionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v题目表_知识点(vQuestionnaire_Knowledge)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionnaire_KnowledgeBL
{
public static RelatedActions_vQuestionnaire_Knowledge relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQuestionnaire_KnowledgeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQuestionnaire_KnowledgeDA vQuestionnaire_KnowledgeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQuestionnaire_KnowledgeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQuestionnaire_KnowledgeBL()
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
if (string.IsNullOrEmpty(clsvQuestionnaire_KnowledgeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQuestionnaire_KnowledgeEN._ConnectString);
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
public static DataTable GetDataTable_vQuestionnaire_Knowledge(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQuestionnaire_KnowledgeDA.GetDataTable_vQuestionnaire_Knowledge(strWhereCond);
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
objDT = vQuestionnaire_KnowledgeDA.GetDataTable(strWhereCond);
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
objDT = vQuestionnaire_KnowledgeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQuestionnaire_KnowledgeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQuestionnaire_KnowledgeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQuestionnaire_KnowledgeDA.GetDataTable_Top(objTopPara);
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
objDT = vQuestionnaire_KnowledgeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQuestionnaire_KnowledgeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQuestionnaire_KnowledgeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrQuestionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQuestionnaire_KnowledgeEN> GetObjLstByQuestionIdLst(List<long> arrQuestionIdLst)
{
List<clsvQuestionnaire_KnowledgeEN> arrObjLst = new List<clsvQuestionnaire_KnowledgeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrQuestionIdLst);
 string strWhereCond = string.Format("QuestionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = new clsvQuestionnaire_KnowledgeEN();
try
{
objvQuestionnaire_KnowledgeEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Knowledge.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_KnowledgeEN.QuestionIndex = objRow[convQuestionnaire_Knowledge.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_KnowledgeEN.QuestionName = objRow[convQuestionnaire_Knowledge.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_KnowledgeEN.QuestionContent = objRow[convQuestionnaire_Knowledge.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaire_KnowledgeEN.QuestionMemo = objRow[convQuestionnaire_Knowledge.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaire_KnowledgeEN.QuestionNo = objRow[convQuestionnaire_Knowledge.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_KnowledgeEN.ExamAnswer = objRow[convQuestionnaire_Knowledge.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaire_KnowledgeEN.CourseId = objRow[convQuestionnaire_Knowledge.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_KnowledgeEN.CourseName = objRow[convQuestionnaire_Knowledge.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire_KnowledgeEN.CourseChapterId = objRow[convQuestionnaire_Knowledge.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_KnowledgeEN.CourseChapterName = objRow[convQuestionnaire_Knowledge.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaire_KnowledgeEN.ChapterId = objRow[convQuestionnaire_Knowledge.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_KnowledgeEN.SectionId = objRow[convQuestionnaire_Knowledge.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_KnowledgeEN.ChapterName = objRow[convQuestionnaire_Knowledge.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_KnowledgeEN.SectionName = objRow[convQuestionnaire_Knowledge.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionName].ToString().Trim(); //节名
objvQuestionnaire_KnowledgeEN.ChapterNameSim = objRow[convQuestionnaire_Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_KnowledgeEN.SectionNameSim = objRow[convQuestionnaire_Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_KnowledgeEN.ParentNodeId = objRow[convQuestionnaire_Knowledge.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire_KnowledgeEN.CourseChapterReferred = objRow[convQuestionnaire_Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaire_KnowledgeEN.ParentNodeName = objRow[convQuestionnaire_Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaire_KnowledgeEN.ParentNodeReferred = objRow[convQuestionnaire_Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaire_KnowledgeEN.QuestionTypeId = objRow[convQuestionnaire_Knowledge.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_KnowledgeEN.QuestionTypeName = objRow[convQuestionnaire_Knowledge.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire_KnowledgeEN.ExamGradeId = objRow[convQuestionnaire_Knowledge.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire_KnowledgeEN.ExamGradeName = objRow[convQuestionnaire_Knowledge.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire_KnowledgeEN.AnswerTypeId = objRow[convQuestionnaire_Knowledge.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_KnowledgeEN.AnswerTypeName = objRow[convQuestionnaire_Knowledge.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaire_KnowledgeEN.GridTitle = objRow[convQuestionnaire_Knowledge.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_KnowledgeEN.AnswerModeId = objRow[convQuestionnaire_Knowledge.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_KnowledgeEN.AnswerModeName = objRow[convQuestionnaire_Knowledge.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaire_KnowledgeEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaire_KnowledgeEN.QuestionnaireSetId = objRow[convQuestionnaire_Knowledge.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaire_KnowledgeEN.QuestionnaireSetName = objRow[convQuestionnaire_Knowledge.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaire_KnowledgeEN.QuestionScore = objRow[convQuestionnaire_Knowledge.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire_Knowledge.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire_KnowledgeEN.QuestionNameAdd = objRow[convQuestionnaire_Knowledge.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaire_KnowledgeEN.DefaultValue = objRow[convQuestionnaire_Knowledge.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaire_KnowledgeEN.TextDirectId = objRow[convQuestionnaire_Knowledge.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaire_KnowledgeEN.TextDirectName = objRow[convQuestionnaire_Knowledge.TextDirectName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectName].ToString().Trim(); //文本方向名
objvQuestionnaire_KnowledgeEN.FillInTextWidth = objRow[convQuestionnaire_Knowledge.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaire_KnowledgeEN.MemoTextWidth = objRow[convQuestionnaire_Knowledge.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaire_KnowledgeEN.CodeTab = objRow[convQuestionnaire_Knowledge.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTab].ToString().Trim(); //代码表
objvQuestionnaire_KnowledgeEN.CodeTabCode = objRow[convQuestionnaire_Knowledge.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaire_KnowledgeEN.CodeTabName = objRow[convQuestionnaire_Knowledge.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaire_KnowledgeEN.CodeTabCondition = objRow[convQuestionnaire_Knowledge.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaire_KnowledgeEN.RelaEvent = objRow[convQuestionnaire_Knowledge.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RelaEvent].ToString().Trim(); //相关事件
objvQuestionnaire_KnowledgeEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaire_KnowledgeEN.DefaultSelectItem = objRow[convQuestionnaire_Knowledge.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaire_KnowledgeEN.IsAutoGridTitle = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objvQuestionnaire_KnowledgeEN.FillInTextHeight = objRow[convQuestionnaire_Knowledge.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaire_KnowledgeEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaire_KnowledgeEN.CheckBoxLimitCount = objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaire_KnowledgeEN.RoleId = objRow[convQuestionnaire_Knowledge.RoleId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleId].ToString().Trim(); //角色Id
objvQuestionnaire_KnowledgeEN.RoleName = objRow[convQuestionnaire_Knowledge.RoleName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleName].ToString().Trim(); //角色名
objvQuestionnaire_KnowledgeEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_KnowledgeEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsCast].ToString().Trim()); //是否播放
objvQuestionnaire_KnowledgeEN.LikeCount = objRow[convQuestionnaire_Knowledge.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaire_KnowledgeEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaire_KnowledgeEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaire_KnowledgeEN.UpdDate = objRow[convQuestionnaire_Knowledge.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire_KnowledgeEN.UpdUser = objRow[convQuestionnaire_Knowledge.UpdUser].ToString().Trim(); //修改人
objvQuestionnaire_KnowledgeEN.Memo = objRow[convQuestionnaire_Knowledge.Memo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.Memo].ToString().Trim(); //备注
objvQuestionnaire_KnowledgeEN.KnowledgeNum = objRow[convQuestionnaire_Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
objvQuestionnaire_KnowledgeEN.AnswerNum = objRow[convQuestionnaire_Knowledge.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.AnswerNum].ToString().Trim()); //答案数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_KnowledgeEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_KnowledgeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrQuestionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQuestionnaire_KnowledgeEN> GetObjLstByQuestionIdLstCache(List<long> arrQuestionIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvQuestionnaire_KnowledgeEN._CurrTabName, strCourseId);
List<clsvQuestionnaire_KnowledgeEN> arrvQuestionnaire_KnowledgeObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionnaire_KnowledgeEN> arrvQuestionnaire_KnowledgeObjLst_Sel =
arrvQuestionnaire_KnowledgeObjLstCache
.Where(x => arrQuestionIdLst.Contains(x.QuestionId));
return arrvQuestionnaire_KnowledgeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaire_KnowledgeEN> GetObjLst(string strWhereCond)
{
List<clsvQuestionnaire_KnowledgeEN> arrObjLst = new List<clsvQuestionnaire_KnowledgeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = new clsvQuestionnaire_KnowledgeEN();
try
{
objvQuestionnaire_KnowledgeEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Knowledge.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_KnowledgeEN.QuestionIndex = objRow[convQuestionnaire_Knowledge.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_KnowledgeEN.QuestionName = objRow[convQuestionnaire_Knowledge.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_KnowledgeEN.QuestionContent = objRow[convQuestionnaire_Knowledge.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaire_KnowledgeEN.QuestionMemo = objRow[convQuestionnaire_Knowledge.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaire_KnowledgeEN.QuestionNo = objRow[convQuestionnaire_Knowledge.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_KnowledgeEN.ExamAnswer = objRow[convQuestionnaire_Knowledge.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaire_KnowledgeEN.CourseId = objRow[convQuestionnaire_Knowledge.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_KnowledgeEN.CourseName = objRow[convQuestionnaire_Knowledge.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire_KnowledgeEN.CourseChapterId = objRow[convQuestionnaire_Knowledge.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_KnowledgeEN.CourseChapterName = objRow[convQuestionnaire_Knowledge.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaire_KnowledgeEN.ChapterId = objRow[convQuestionnaire_Knowledge.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_KnowledgeEN.SectionId = objRow[convQuestionnaire_Knowledge.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_KnowledgeEN.ChapterName = objRow[convQuestionnaire_Knowledge.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_KnowledgeEN.SectionName = objRow[convQuestionnaire_Knowledge.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionName].ToString().Trim(); //节名
objvQuestionnaire_KnowledgeEN.ChapterNameSim = objRow[convQuestionnaire_Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_KnowledgeEN.SectionNameSim = objRow[convQuestionnaire_Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_KnowledgeEN.ParentNodeId = objRow[convQuestionnaire_Knowledge.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire_KnowledgeEN.CourseChapterReferred = objRow[convQuestionnaire_Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaire_KnowledgeEN.ParentNodeName = objRow[convQuestionnaire_Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaire_KnowledgeEN.ParentNodeReferred = objRow[convQuestionnaire_Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaire_KnowledgeEN.QuestionTypeId = objRow[convQuestionnaire_Knowledge.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_KnowledgeEN.QuestionTypeName = objRow[convQuestionnaire_Knowledge.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire_KnowledgeEN.ExamGradeId = objRow[convQuestionnaire_Knowledge.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire_KnowledgeEN.ExamGradeName = objRow[convQuestionnaire_Knowledge.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire_KnowledgeEN.AnswerTypeId = objRow[convQuestionnaire_Knowledge.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_KnowledgeEN.AnswerTypeName = objRow[convQuestionnaire_Knowledge.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaire_KnowledgeEN.GridTitle = objRow[convQuestionnaire_Knowledge.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_KnowledgeEN.AnswerModeId = objRow[convQuestionnaire_Knowledge.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_KnowledgeEN.AnswerModeName = objRow[convQuestionnaire_Knowledge.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaire_KnowledgeEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaire_KnowledgeEN.QuestionnaireSetId = objRow[convQuestionnaire_Knowledge.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaire_KnowledgeEN.QuestionnaireSetName = objRow[convQuestionnaire_Knowledge.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaire_KnowledgeEN.QuestionScore = objRow[convQuestionnaire_Knowledge.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire_Knowledge.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire_KnowledgeEN.QuestionNameAdd = objRow[convQuestionnaire_Knowledge.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaire_KnowledgeEN.DefaultValue = objRow[convQuestionnaire_Knowledge.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaire_KnowledgeEN.TextDirectId = objRow[convQuestionnaire_Knowledge.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaire_KnowledgeEN.TextDirectName = objRow[convQuestionnaire_Knowledge.TextDirectName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectName].ToString().Trim(); //文本方向名
objvQuestionnaire_KnowledgeEN.FillInTextWidth = objRow[convQuestionnaire_Knowledge.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaire_KnowledgeEN.MemoTextWidth = objRow[convQuestionnaire_Knowledge.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaire_KnowledgeEN.CodeTab = objRow[convQuestionnaire_Knowledge.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTab].ToString().Trim(); //代码表
objvQuestionnaire_KnowledgeEN.CodeTabCode = objRow[convQuestionnaire_Knowledge.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaire_KnowledgeEN.CodeTabName = objRow[convQuestionnaire_Knowledge.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaire_KnowledgeEN.CodeTabCondition = objRow[convQuestionnaire_Knowledge.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaire_KnowledgeEN.RelaEvent = objRow[convQuestionnaire_Knowledge.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RelaEvent].ToString().Trim(); //相关事件
objvQuestionnaire_KnowledgeEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaire_KnowledgeEN.DefaultSelectItem = objRow[convQuestionnaire_Knowledge.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaire_KnowledgeEN.IsAutoGridTitle = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objvQuestionnaire_KnowledgeEN.FillInTextHeight = objRow[convQuestionnaire_Knowledge.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaire_KnowledgeEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaire_KnowledgeEN.CheckBoxLimitCount = objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaire_KnowledgeEN.RoleId = objRow[convQuestionnaire_Knowledge.RoleId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleId].ToString().Trim(); //角色Id
objvQuestionnaire_KnowledgeEN.RoleName = objRow[convQuestionnaire_Knowledge.RoleName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleName].ToString().Trim(); //角色名
objvQuestionnaire_KnowledgeEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_KnowledgeEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsCast].ToString().Trim()); //是否播放
objvQuestionnaire_KnowledgeEN.LikeCount = objRow[convQuestionnaire_Knowledge.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaire_KnowledgeEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaire_KnowledgeEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaire_KnowledgeEN.UpdDate = objRow[convQuestionnaire_Knowledge.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire_KnowledgeEN.UpdUser = objRow[convQuestionnaire_Knowledge.UpdUser].ToString().Trim(); //修改人
objvQuestionnaire_KnowledgeEN.Memo = objRow[convQuestionnaire_Knowledge.Memo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.Memo].ToString().Trim(); //备注
objvQuestionnaire_KnowledgeEN.KnowledgeNum = objRow[convQuestionnaire_Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
objvQuestionnaire_KnowledgeEN.AnswerNum = objRow[convQuestionnaire_Knowledge.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.AnswerNum].ToString().Trim()); //答案数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_KnowledgeEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_KnowledgeEN);
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
public static List<clsvQuestionnaire_KnowledgeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionnaire_KnowledgeEN> arrObjLst = new List<clsvQuestionnaire_KnowledgeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = new clsvQuestionnaire_KnowledgeEN();
try
{
objvQuestionnaire_KnowledgeEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Knowledge.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_KnowledgeEN.QuestionIndex = objRow[convQuestionnaire_Knowledge.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_KnowledgeEN.QuestionName = objRow[convQuestionnaire_Knowledge.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_KnowledgeEN.QuestionContent = objRow[convQuestionnaire_Knowledge.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaire_KnowledgeEN.QuestionMemo = objRow[convQuestionnaire_Knowledge.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaire_KnowledgeEN.QuestionNo = objRow[convQuestionnaire_Knowledge.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_KnowledgeEN.ExamAnswer = objRow[convQuestionnaire_Knowledge.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaire_KnowledgeEN.CourseId = objRow[convQuestionnaire_Knowledge.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_KnowledgeEN.CourseName = objRow[convQuestionnaire_Knowledge.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire_KnowledgeEN.CourseChapterId = objRow[convQuestionnaire_Knowledge.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_KnowledgeEN.CourseChapterName = objRow[convQuestionnaire_Knowledge.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaire_KnowledgeEN.ChapterId = objRow[convQuestionnaire_Knowledge.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_KnowledgeEN.SectionId = objRow[convQuestionnaire_Knowledge.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_KnowledgeEN.ChapterName = objRow[convQuestionnaire_Knowledge.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_KnowledgeEN.SectionName = objRow[convQuestionnaire_Knowledge.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionName].ToString().Trim(); //节名
objvQuestionnaire_KnowledgeEN.ChapterNameSim = objRow[convQuestionnaire_Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_KnowledgeEN.SectionNameSim = objRow[convQuestionnaire_Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_KnowledgeEN.ParentNodeId = objRow[convQuestionnaire_Knowledge.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire_KnowledgeEN.CourseChapterReferred = objRow[convQuestionnaire_Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaire_KnowledgeEN.ParentNodeName = objRow[convQuestionnaire_Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaire_KnowledgeEN.ParentNodeReferred = objRow[convQuestionnaire_Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaire_KnowledgeEN.QuestionTypeId = objRow[convQuestionnaire_Knowledge.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_KnowledgeEN.QuestionTypeName = objRow[convQuestionnaire_Knowledge.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire_KnowledgeEN.ExamGradeId = objRow[convQuestionnaire_Knowledge.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire_KnowledgeEN.ExamGradeName = objRow[convQuestionnaire_Knowledge.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire_KnowledgeEN.AnswerTypeId = objRow[convQuestionnaire_Knowledge.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_KnowledgeEN.AnswerTypeName = objRow[convQuestionnaire_Knowledge.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaire_KnowledgeEN.GridTitle = objRow[convQuestionnaire_Knowledge.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_KnowledgeEN.AnswerModeId = objRow[convQuestionnaire_Knowledge.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_KnowledgeEN.AnswerModeName = objRow[convQuestionnaire_Knowledge.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaire_KnowledgeEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaire_KnowledgeEN.QuestionnaireSetId = objRow[convQuestionnaire_Knowledge.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaire_KnowledgeEN.QuestionnaireSetName = objRow[convQuestionnaire_Knowledge.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaire_KnowledgeEN.QuestionScore = objRow[convQuestionnaire_Knowledge.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire_Knowledge.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire_KnowledgeEN.QuestionNameAdd = objRow[convQuestionnaire_Knowledge.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaire_KnowledgeEN.DefaultValue = objRow[convQuestionnaire_Knowledge.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaire_KnowledgeEN.TextDirectId = objRow[convQuestionnaire_Knowledge.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaire_KnowledgeEN.TextDirectName = objRow[convQuestionnaire_Knowledge.TextDirectName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectName].ToString().Trim(); //文本方向名
objvQuestionnaire_KnowledgeEN.FillInTextWidth = objRow[convQuestionnaire_Knowledge.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaire_KnowledgeEN.MemoTextWidth = objRow[convQuestionnaire_Knowledge.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaire_KnowledgeEN.CodeTab = objRow[convQuestionnaire_Knowledge.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTab].ToString().Trim(); //代码表
objvQuestionnaire_KnowledgeEN.CodeTabCode = objRow[convQuestionnaire_Knowledge.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaire_KnowledgeEN.CodeTabName = objRow[convQuestionnaire_Knowledge.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaire_KnowledgeEN.CodeTabCondition = objRow[convQuestionnaire_Knowledge.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaire_KnowledgeEN.RelaEvent = objRow[convQuestionnaire_Knowledge.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RelaEvent].ToString().Trim(); //相关事件
objvQuestionnaire_KnowledgeEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaire_KnowledgeEN.DefaultSelectItem = objRow[convQuestionnaire_Knowledge.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaire_KnowledgeEN.IsAutoGridTitle = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objvQuestionnaire_KnowledgeEN.FillInTextHeight = objRow[convQuestionnaire_Knowledge.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaire_KnowledgeEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaire_KnowledgeEN.CheckBoxLimitCount = objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaire_KnowledgeEN.RoleId = objRow[convQuestionnaire_Knowledge.RoleId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleId].ToString().Trim(); //角色Id
objvQuestionnaire_KnowledgeEN.RoleName = objRow[convQuestionnaire_Knowledge.RoleName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleName].ToString().Trim(); //角色名
objvQuestionnaire_KnowledgeEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_KnowledgeEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsCast].ToString().Trim()); //是否播放
objvQuestionnaire_KnowledgeEN.LikeCount = objRow[convQuestionnaire_Knowledge.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaire_KnowledgeEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaire_KnowledgeEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaire_KnowledgeEN.UpdDate = objRow[convQuestionnaire_Knowledge.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire_KnowledgeEN.UpdUser = objRow[convQuestionnaire_Knowledge.UpdUser].ToString().Trim(); //修改人
objvQuestionnaire_KnowledgeEN.Memo = objRow[convQuestionnaire_Knowledge.Memo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.Memo].ToString().Trim(); //备注
objvQuestionnaire_KnowledgeEN.KnowledgeNum = objRow[convQuestionnaire_Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
objvQuestionnaire_KnowledgeEN.AnswerNum = objRow[convQuestionnaire_Knowledge.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.AnswerNum].ToString().Trim()); //答案数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_KnowledgeEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_KnowledgeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQuestionnaire_KnowledgeEN> GetSubObjLstCache(clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeCond)
{
 string strCourseId = objvQuestionnaire_KnowledgeCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvQuestionnaire_KnowledgeBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvQuestionnaire_KnowledgeEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionnaire_KnowledgeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionnaire_Knowledge.AttributeName)
{
if (objvQuestionnaire_KnowledgeCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionnaire_KnowledgeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaire_KnowledgeCond[strFldName].ToString());
}
else
{
if (objvQuestionnaire_KnowledgeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaire_KnowledgeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionnaire_KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionnaire_KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionnaire_KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionnaire_KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionnaire_KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionnaire_KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionnaire_KnowledgeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionnaire_KnowledgeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionnaire_KnowledgeCond[strFldName]));
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
public static List<clsvQuestionnaire_KnowledgeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQuestionnaire_KnowledgeEN> arrObjLst = new List<clsvQuestionnaire_KnowledgeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = new clsvQuestionnaire_KnowledgeEN();
try
{
objvQuestionnaire_KnowledgeEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Knowledge.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_KnowledgeEN.QuestionIndex = objRow[convQuestionnaire_Knowledge.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_KnowledgeEN.QuestionName = objRow[convQuestionnaire_Knowledge.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_KnowledgeEN.QuestionContent = objRow[convQuestionnaire_Knowledge.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaire_KnowledgeEN.QuestionMemo = objRow[convQuestionnaire_Knowledge.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaire_KnowledgeEN.QuestionNo = objRow[convQuestionnaire_Knowledge.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_KnowledgeEN.ExamAnswer = objRow[convQuestionnaire_Knowledge.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaire_KnowledgeEN.CourseId = objRow[convQuestionnaire_Knowledge.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_KnowledgeEN.CourseName = objRow[convQuestionnaire_Knowledge.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire_KnowledgeEN.CourseChapterId = objRow[convQuestionnaire_Knowledge.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_KnowledgeEN.CourseChapterName = objRow[convQuestionnaire_Knowledge.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaire_KnowledgeEN.ChapterId = objRow[convQuestionnaire_Knowledge.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_KnowledgeEN.SectionId = objRow[convQuestionnaire_Knowledge.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_KnowledgeEN.ChapterName = objRow[convQuestionnaire_Knowledge.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_KnowledgeEN.SectionName = objRow[convQuestionnaire_Knowledge.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionName].ToString().Trim(); //节名
objvQuestionnaire_KnowledgeEN.ChapterNameSim = objRow[convQuestionnaire_Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_KnowledgeEN.SectionNameSim = objRow[convQuestionnaire_Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_KnowledgeEN.ParentNodeId = objRow[convQuestionnaire_Knowledge.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire_KnowledgeEN.CourseChapterReferred = objRow[convQuestionnaire_Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaire_KnowledgeEN.ParentNodeName = objRow[convQuestionnaire_Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaire_KnowledgeEN.ParentNodeReferred = objRow[convQuestionnaire_Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaire_KnowledgeEN.QuestionTypeId = objRow[convQuestionnaire_Knowledge.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_KnowledgeEN.QuestionTypeName = objRow[convQuestionnaire_Knowledge.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire_KnowledgeEN.ExamGradeId = objRow[convQuestionnaire_Knowledge.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire_KnowledgeEN.ExamGradeName = objRow[convQuestionnaire_Knowledge.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire_KnowledgeEN.AnswerTypeId = objRow[convQuestionnaire_Knowledge.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_KnowledgeEN.AnswerTypeName = objRow[convQuestionnaire_Knowledge.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaire_KnowledgeEN.GridTitle = objRow[convQuestionnaire_Knowledge.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_KnowledgeEN.AnswerModeId = objRow[convQuestionnaire_Knowledge.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_KnowledgeEN.AnswerModeName = objRow[convQuestionnaire_Knowledge.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaire_KnowledgeEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaire_KnowledgeEN.QuestionnaireSetId = objRow[convQuestionnaire_Knowledge.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaire_KnowledgeEN.QuestionnaireSetName = objRow[convQuestionnaire_Knowledge.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaire_KnowledgeEN.QuestionScore = objRow[convQuestionnaire_Knowledge.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire_Knowledge.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire_KnowledgeEN.QuestionNameAdd = objRow[convQuestionnaire_Knowledge.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaire_KnowledgeEN.DefaultValue = objRow[convQuestionnaire_Knowledge.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaire_KnowledgeEN.TextDirectId = objRow[convQuestionnaire_Knowledge.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaire_KnowledgeEN.TextDirectName = objRow[convQuestionnaire_Knowledge.TextDirectName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectName].ToString().Trim(); //文本方向名
objvQuestionnaire_KnowledgeEN.FillInTextWidth = objRow[convQuestionnaire_Knowledge.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaire_KnowledgeEN.MemoTextWidth = objRow[convQuestionnaire_Knowledge.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaire_KnowledgeEN.CodeTab = objRow[convQuestionnaire_Knowledge.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTab].ToString().Trim(); //代码表
objvQuestionnaire_KnowledgeEN.CodeTabCode = objRow[convQuestionnaire_Knowledge.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaire_KnowledgeEN.CodeTabName = objRow[convQuestionnaire_Knowledge.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaire_KnowledgeEN.CodeTabCondition = objRow[convQuestionnaire_Knowledge.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaire_KnowledgeEN.RelaEvent = objRow[convQuestionnaire_Knowledge.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RelaEvent].ToString().Trim(); //相关事件
objvQuestionnaire_KnowledgeEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaire_KnowledgeEN.DefaultSelectItem = objRow[convQuestionnaire_Knowledge.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaire_KnowledgeEN.IsAutoGridTitle = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objvQuestionnaire_KnowledgeEN.FillInTextHeight = objRow[convQuestionnaire_Knowledge.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaire_KnowledgeEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaire_KnowledgeEN.CheckBoxLimitCount = objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaire_KnowledgeEN.RoleId = objRow[convQuestionnaire_Knowledge.RoleId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleId].ToString().Trim(); //角色Id
objvQuestionnaire_KnowledgeEN.RoleName = objRow[convQuestionnaire_Knowledge.RoleName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleName].ToString().Trim(); //角色名
objvQuestionnaire_KnowledgeEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_KnowledgeEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsCast].ToString().Trim()); //是否播放
objvQuestionnaire_KnowledgeEN.LikeCount = objRow[convQuestionnaire_Knowledge.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaire_KnowledgeEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaire_KnowledgeEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaire_KnowledgeEN.UpdDate = objRow[convQuestionnaire_Knowledge.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire_KnowledgeEN.UpdUser = objRow[convQuestionnaire_Knowledge.UpdUser].ToString().Trim(); //修改人
objvQuestionnaire_KnowledgeEN.Memo = objRow[convQuestionnaire_Knowledge.Memo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.Memo].ToString().Trim(); //备注
objvQuestionnaire_KnowledgeEN.KnowledgeNum = objRow[convQuestionnaire_Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
objvQuestionnaire_KnowledgeEN.AnswerNum = objRow[convQuestionnaire_Knowledge.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.AnswerNum].ToString().Trim()); //答案数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_KnowledgeEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_KnowledgeEN);
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
public static List<clsvQuestionnaire_KnowledgeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQuestionnaire_KnowledgeEN> arrObjLst = new List<clsvQuestionnaire_KnowledgeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = new clsvQuestionnaire_KnowledgeEN();
try
{
objvQuestionnaire_KnowledgeEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Knowledge.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_KnowledgeEN.QuestionIndex = objRow[convQuestionnaire_Knowledge.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_KnowledgeEN.QuestionName = objRow[convQuestionnaire_Knowledge.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_KnowledgeEN.QuestionContent = objRow[convQuestionnaire_Knowledge.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaire_KnowledgeEN.QuestionMemo = objRow[convQuestionnaire_Knowledge.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaire_KnowledgeEN.QuestionNo = objRow[convQuestionnaire_Knowledge.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_KnowledgeEN.ExamAnswer = objRow[convQuestionnaire_Knowledge.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaire_KnowledgeEN.CourseId = objRow[convQuestionnaire_Knowledge.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_KnowledgeEN.CourseName = objRow[convQuestionnaire_Knowledge.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire_KnowledgeEN.CourseChapterId = objRow[convQuestionnaire_Knowledge.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_KnowledgeEN.CourseChapterName = objRow[convQuestionnaire_Knowledge.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaire_KnowledgeEN.ChapterId = objRow[convQuestionnaire_Knowledge.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_KnowledgeEN.SectionId = objRow[convQuestionnaire_Knowledge.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_KnowledgeEN.ChapterName = objRow[convQuestionnaire_Knowledge.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_KnowledgeEN.SectionName = objRow[convQuestionnaire_Knowledge.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionName].ToString().Trim(); //节名
objvQuestionnaire_KnowledgeEN.ChapterNameSim = objRow[convQuestionnaire_Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_KnowledgeEN.SectionNameSim = objRow[convQuestionnaire_Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_KnowledgeEN.ParentNodeId = objRow[convQuestionnaire_Knowledge.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire_KnowledgeEN.CourseChapterReferred = objRow[convQuestionnaire_Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaire_KnowledgeEN.ParentNodeName = objRow[convQuestionnaire_Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaire_KnowledgeEN.ParentNodeReferred = objRow[convQuestionnaire_Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaire_KnowledgeEN.QuestionTypeId = objRow[convQuestionnaire_Knowledge.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_KnowledgeEN.QuestionTypeName = objRow[convQuestionnaire_Knowledge.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire_KnowledgeEN.ExamGradeId = objRow[convQuestionnaire_Knowledge.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire_KnowledgeEN.ExamGradeName = objRow[convQuestionnaire_Knowledge.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire_KnowledgeEN.AnswerTypeId = objRow[convQuestionnaire_Knowledge.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_KnowledgeEN.AnswerTypeName = objRow[convQuestionnaire_Knowledge.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaire_KnowledgeEN.GridTitle = objRow[convQuestionnaire_Knowledge.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_KnowledgeEN.AnswerModeId = objRow[convQuestionnaire_Knowledge.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_KnowledgeEN.AnswerModeName = objRow[convQuestionnaire_Knowledge.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaire_KnowledgeEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaire_KnowledgeEN.QuestionnaireSetId = objRow[convQuestionnaire_Knowledge.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaire_KnowledgeEN.QuestionnaireSetName = objRow[convQuestionnaire_Knowledge.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaire_KnowledgeEN.QuestionScore = objRow[convQuestionnaire_Knowledge.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire_Knowledge.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire_KnowledgeEN.QuestionNameAdd = objRow[convQuestionnaire_Knowledge.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaire_KnowledgeEN.DefaultValue = objRow[convQuestionnaire_Knowledge.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaire_KnowledgeEN.TextDirectId = objRow[convQuestionnaire_Knowledge.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaire_KnowledgeEN.TextDirectName = objRow[convQuestionnaire_Knowledge.TextDirectName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectName].ToString().Trim(); //文本方向名
objvQuestionnaire_KnowledgeEN.FillInTextWidth = objRow[convQuestionnaire_Knowledge.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaire_KnowledgeEN.MemoTextWidth = objRow[convQuestionnaire_Knowledge.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaire_KnowledgeEN.CodeTab = objRow[convQuestionnaire_Knowledge.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTab].ToString().Trim(); //代码表
objvQuestionnaire_KnowledgeEN.CodeTabCode = objRow[convQuestionnaire_Knowledge.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaire_KnowledgeEN.CodeTabName = objRow[convQuestionnaire_Knowledge.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaire_KnowledgeEN.CodeTabCondition = objRow[convQuestionnaire_Knowledge.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaire_KnowledgeEN.RelaEvent = objRow[convQuestionnaire_Knowledge.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RelaEvent].ToString().Trim(); //相关事件
objvQuestionnaire_KnowledgeEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaire_KnowledgeEN.DefaultSelectItem = objRow[convQuestionnaire_Knowledge.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaire_KnowledgeEN.IsAutoGridTitle = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objvQuestionnaire_KnowledgeEN.FillInTextHeight = objRow[convQuestionnaire_Knowledge.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaire_KnowledgeEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaire_KnowledgeEN.CheckBoxLimitCount = objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaire_KnowledgeEN.RoleId = objRow[convQuestionnaire_Knowledge.RoleId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleId].ToString().Trim(); //角色Id
objvQuestionnaire_KnowledgeEN.RoleName = objRow[convQuestionnaire_Knowledge.RoleName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleName].ToString().Trim(); //角色名
objvQuestionnaire_KnowledgeEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_KnowledgeEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsCast].ToString().Trim()); //是否播放
objvQuestionnaire_KnowledgeEN.LikeCount = objRow[convQuestionnaire_Knowledge.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaire_KnowledgeEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaire_KnowledgeEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaire_KnowledgeEN.UpdDate = objRow[convQuestionnaire_Knowledge.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire_KnowledgeEN.UpdUser = objRow[convQuestionnaire_Knowledge.UpdUser].ToString().Trim(); //修改人
objvQuestionnaire_KnowledgeEN.Memo = objRow[convQuestionnaire_Knowledge.Memo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.Memo].ToString().Trim(); //备注
objvQuestionnaire_KnowledgeEN.KnowledgeNum = objRow[convQuestionnaire_Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
objvQuestionnaire_KnowledgeEN.AnswerNum = objRow[convQuestionnaire_Knowledge.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.AnswerNum].ToString().Trim()); //答案数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_KnowledgeEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_KnowledgeEN);
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
List<clsvQuestionnaire_KnowledgeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQuestionnaire_KnowledgeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaire_KnowledgeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQuestionnaire_KnowledgeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionnaire_KnowledgeEN> arrObjLst = new List<clsvQuestionnaire_KnowledgeEN>(); 
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
	clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = new clsvQuestionnaire_KnowledgeEN();
try
{
objvQuestionnaire_KnowledgeEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Knowledge.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_KnowledgeEN.QuestionIndex = objRow[convQuestionnaire_Knowledge.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_KnowledgeEN.QuestionName = objRow[convQuestionnaire_Knowledge.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_KnowledgeEN.QuestionContent = objRow[convQuestionnaire_Knowledge.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaire_KnowledgeEN.QuestionMemo = objRow[convQuestionnaire_Knowledge.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaire_KnowledgeEN.QuestionNo = objRow[convQuestionnaire_Knowledge.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_KnowledgeEN.ExamAnswer = objRow[convQuestionnaire_Knowledge.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaire_KnowledgeEN.CourseId = objRow[convQuestionnaire_Knowledge.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_KnowledgeEN.CourseName = objRow[convQuestionnaire_Knowledge.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire_KnowledgeEN.CourseChapterId = objRow[convQuestionnaire_Knowledge.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_KnowledgeEN.CourseChapterName = objRow[convQuestionnaire_Knowledge.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaire_KnowledgeEN.ChapterId = objRow[convQuestionnaire_Knowledge.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_KnowledgeEN.SectionId = objRow[convQuestionnaire_Knowledge.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_KnowledgeEN.ChapterName = objRow[convQuestionnaire_Knowledge.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_KnowledgeEN.SectionName = objRow[convQuestionnaire_Knowledge.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionName].ToString().Trim(); //节名
objvQuestionnaire_KnowledgeEN.ChapterNameSim = objRow[convQuestionnaire_Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_KnowledgeEN.SectionNameSim = objRow[convQuestionnaire_Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_KnowledgeEN.ParentNodeId = objRow[convQuestionnaire_Knowledge.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire_KnowledgeEN.CourseChapterReferred = objRow[convQuestionnaire_Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaire_KnowledgeEN.ParentNodeName = objRow[convQuestionnaire_Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaire_KnowledgeEN.ParentNodeReferred = objRow[convQuestionnaire_Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaire_KnowledgeEN.QuestionTypeId = objRow[convQuestionnaire_Knowledge.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_KnowledgeEN.QuestionTypeName = objRow[convQuestionnaire_Knowledge.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire_KnowledgeEN.ExamGradeId = objRow[convQuestionnaire_Knowledge.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire_KnowledgeEN.ExamGradeName = objRow[convQuestionnaire_Knowledge.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire_KnowledgeEN.AnswerTypeId = objRow[convQuestionnaire_Knowledge.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_KnowledgeEN.AnswerTypeName = objRow[convQuestionnaire_Knowledge.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaire_KnowledgeEN.GridTitle = objRow[convQuestionnaire_Knowledge.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_KnowledgeEN.AnswerModeId = objRow[convQuestionnaire_Knowledge.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_KnowledgeEN.AnswerModeName = objRow[convQuestionnaire_Knowledge.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaire_KnowledgeEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaire_KnowledgeEN.QuestionnaireSetId = objRow[convQuestionnaire_Knowledge.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaire_KnowledgeEN.QuestionnaireSetName = objRow[convQuestionnaire_Knowledge.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaire_KnowledgeEN.QuestionScore = objRow[convQuestionnaire_Knowledge.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire_Knowledge.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire_KnowledgeEN.QuestionNameAdd = objRow[convQuestionnaire_Knowledge.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaire_KnowledgeEN.DefaultValue = objRow[convQuestionnaire_Knowledge.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaire_KnowledgeEN.TextDirectId = objRow[convQuestionnaire_Knowledge.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaire_KnowledgeEN.TextDirectName = objRow[convQuestionnaire_Knowledge.TextDirectName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectName].ToString().Trim(); //文本方向名
objvQuestionnaire_KnowledgeEN.FillInTextWidth = objRow[convQuestionnaire_Knowledge.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaire_KnowledgeEN.MemoTextWidth = objRow[convQuestionnaire_Knowledge.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaire_KnowledgeEN.CodeTab = objRow[convQuestionnaire_Knowledge.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTab].ToString().Trim(); //代码表
objvQuestionnaire_KnowledgeEN.CodeTabCode = objRow[convQuestionnaire_Knowledge.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaire_KnowledgeEN.CodeTabName = objRow[convQuestionnaire_Knowledge.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaire_KnowledgeEN.CodeTabCondition = objRow[convQuestionnaire_Knowledge.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaire_KnowledgeEN.RelaEvent = objRow[convQuestionnaire_Knowledge.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RelaEvent].ToString().Trim(); //相关事件
objvQuestionnaire_KnowledgeEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaire_KnowledgeEN.DefaultSelectItem = objRow[convQuestionnaire_Knowledge.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaire_KnowledgeEN.IsAutoGridTitle = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objvQuestionnaire_KnowledgeEN.FillInTextHeight = objRow[convQuestionnaire_Knowledge.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaire_KnowledgeEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaire_KnowledgeEN.CheckBoxLimitCount = objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaire_KnowledgeEN.RoleId = objRow[convQuestionnaire_Knowledge.RoleId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleId].ToString().Trim(); //角色Id
objvQuestionnaire_KnowledgeEN.RoleName = objRow[convQuestionnaire_Knowledge.RoleName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleName].ToString().Trim(); //角色名
objvQuestionnaire_KnowledgeEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_KnowledgeEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsCast].ToString().Trim()); //是否播放
objvQuestionnaire_KnowledgeEN.LikeCount = objRow[convQuestionnaire_Knowledge.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaire_KnowledgeEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaire_KnowledgeEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaire_KnowledgeEN.UpdDate = objRow[convQuestionnaire_Knowledge.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire_KnowledgeEN.UpdUser = objRow[convQuestionnaire_Knowledge.UpdUser].ToString().Trim(); //修改人
objvQuestionnaire_KnowledgeEN.Memo = objRow[convQuestionnaire_Knowledge.Memo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.Memo].ToString().Trim(); //备注
objvQuestionnaire_KnowledgeEN.KnowledgeNum = objRow[convQuestionnaire_Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
objvQuestionnaire_KnowledgeEN.AnswerNum = objRow[convQuestionnaire_Knowledge.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.AnswerNum].ToString().Trim()); //答案数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_KnowledgeEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_KnowledgeEN);
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
public static List<clsvQuestionnaire_KnowledgeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionnaire_KnowledgeEN> arrObjLst = new List<clsvQuestionnaire_KnowledgeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = new clsvQuestionnaire_KnowledgeEN();
try
{
objvQuestionnaire_KnowledgeEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Knowledge.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_KnowledgeEN.QuestionIndex = objRow[convQuestionnaire_Knowledge.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_KnowledgeEN.QuestionName = objRow[convQuestionnaire_Knowledge.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_KnowledgeEN.QuestionContent = objRow[convQuestionnaire_Knowledge.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaire_KnowledgeEN.QuestionMemo = objRow[convQuestionnaire_Knowledge.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaire_KnowledgeEN.QuestionNo = objRow[convQuestionnaire_Knowledge.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_KnowledgeEN.ExamAnswer = objRow[convQuestionnaire_Knowledge.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaire_KnowledgeEN.CourseId = objRow[convQuestionnaire_Knowledge.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_KnowledgeEN.CourseName = objRow[convQuestionnaire_Knowledge.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire_KnowledgeEN.CourseChapterId = objRow[convQuestionnaire_Knowledge.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_KnowledgeEN.CourseChapterName = objRow[convQuestionnaire_Knowledge.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaire_KnowledgeEN.ChapterId = objRow[convQuestionnaire_Knowledge.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_KnowledgeEN.SectionId = objRow[convQuestionnaire_Knowledge.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_KnowledgeEN.ChapterName = objRow[convQuestionnaire_Knowledge.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_KnowledgeEN.SectionName = objRow[convQuestionnaire_Knowledge.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionName].ToString().Trim(); //节名
objvQuestionnaire_KnowledgeEN.ChapterNameSim = objRow[convQuestionnaire_Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_KnowledgeEN.SectionNameSim = objRow[convQuestionnaire_Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_KnowledgeEN.ParentNodeId = objRow[convQuestionnaire_Knowledge.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire_KnowledgeEN.CourseChapterReferred = objRow[convQuestionnaire_Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaire_KnowledgeEN.ParentNodeName = objRow[convQuestionnaire_Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaire_KnowledgeEN.ParentNodeReferred = objRow[convQuestionnaire_Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaire_KnowledgeEN.QuestionTypeId = objRow[convQuestionnaire_Knowledge.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_KnowledgeEN.QuestionTypeName = objRow[convQuestionnaire_Knowledge.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire_KnowledgeEN.ExamGradeId = objRow[convQuestionnaire_Knowledge.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire_KnowledgeEN.ExamGradeName = objRow[convQuestionnaire_Knowledge.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire_KnowledgeEN.AnswerTypeId = objRow[convQuestionnaire_Knowledge.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_KnowledgeEN.AnswerTypeName = objRow[convQuestionnaire_Knowledge.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaire_KnowledgeEN.GridTitle = objRow[convQuestionnaire_Knowledge.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_KnowledgeEN.AnswerModeId = objRow[convQuestionnaire_Knowledge.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_KnowledgeEN.AnswerModeName = objRow[convQuestionnaire_Knowledge.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaire_KnowledgeEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaire_KnowledgeEN.QuestionnaireSetId = objRow[convQuestionnaire_Knowledge.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaire_KnowledgeEN.QuestionnaireSetName = objRow[convQuestionnaire_Knowledge.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaire_KnowledgeEN.QuestionScore = objRow[convQuestionnaire_Knowledge.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire_Knowledge.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire_KnowledgeEN.QuestionNameAdd = objRow[convQuestionnaire_Knowledge.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaire_KnowledgeEN.DefaultValue = objRow[convQuestionnaire_Knowledge.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaire_KnowledgeEN.TextDirectId = objRow[convQuestionnaire_Knowledge.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaire_KnowledgeEN.TextDirectName = objRow[convQuestionnaire_Knowledge.TextDirectName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectName].ToString().Trim(); //文本方向名
objvQuestionnaire_KnowledgeEN.FillInTextWidth = objRow[convQuestionnaire_Knowledge.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaire_KnowledgeEN.MemoTextWidth = objRow[convQuestionnaire_Knowledge.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaire_KnowledgeEN.CodeTab = objRow[convQuestionnaire_Knowledge.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTab].ToString().Trim(); //代码表
objvQuestionnaire_KnowledgeEN.CodeTabCode = objRow[convQuestionnaire_Knowledge.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaire_KnowledgeEN.CodeTabName = objRow[convQuestionnaire_Knowledge.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaire_KnowledgeEN.CodeTabCondition = objRow[convQuestionnaire_Knowledge.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaire_KnowledgeEN.RelaEvent = objRow[convQuestionnaire_Knowledge.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RelaEvent].ToString().Trim(); //相关事件
objvQuestionnaire_KnowledgeEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaire_KnowledgeEN.DefaultSelectItem = objRow[convQuestionnaire_Knowledge.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaire_KnowledgeEN.IsAutoGridTitle = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objvQuestionnaire_KnowledgeEN.FillInTextHeight = objRow[convQuestionnaire_Knowledge.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaire_KnowledgeEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaire_KnowledgeEN.CheckBoxLimitCount = objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaire_KnowledgeEN.RoleId = objRow[convQuestionnaire_Knowledge.RoleId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleId].ToString().Trim(); //角色Id
objvQuestionnaire_KnowledgeEN.RoleName = objRow[convQuestionnaire_Knowledge.RoleName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleName].ToString().Trim(); //角色名
objvQuestionnaire_KnowledgeEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_KnowledgeEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsCast].ToString().Trim()); //是否播放
objvQuestionnaire_KnowledgeEN.LikeCount = objRow[convQuestionnaire_Knowledge.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaire_KnowledgeEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaire_KnowledgeEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaire_KnowledgeEN.UpdDate = objRow[convQuestionnaire_Knowledge.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire_KnowledgeEN.UpdUser = objRow[convQuestionnaire_Knowledge.UpdUser].ToString().Trim(); //修改人
objvQuestionnaire_KnowledgeEN.Memo = objRow[convQuestionnaire_Knowledge.Memo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.Memo].ToString().Trim(); //备注
objvQuestionnaire_KnowledgeEN.KnowledgeNum = objRow[convQuestionnaire_Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
objvQuestionnaire_KnowledgeEN.AnswerNum = objRow[convQuestionnaire_Knowledge.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.AnswerNum].ToString().Trim()); //答案数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_KnowledgeEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_KnowledgeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQuestionnaire_KnowledgeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQuestionnaire_KnowledgeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionnaire_KnowledgeEN> arrObjLst = new List<clsvQuestionnaire_KnowledgeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = new clsvQuestionnaire_KnowledgeEN();
try
{
objvQuestionnaire_KnowledgeEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Knowledge.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_KnowledgeEN.QuestionIndex = objRow[convQuestionnaire_Knowledge.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_KnowledgeEN.QuestionName = objRow[convQuestionnaire_Knowledge.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_KnowledgeEN.QuestionContent = objRow[convQuestionnaire_Knowledge.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaire_KnowledgeEN.QuestionMemo = objRow[convQuestionnaire_Knowledge.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaire_KnowledgeEN.QuestionNo = objRow[convQuestionnaire_Knowledge.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_KnowledgeEN.ExamAnswer = objRow[convQuestionnaire_Knowledge.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaire_KnowledgeEN.CourseId = objRow[convQuestionnaire_Knowledge.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_KnowledgeEN.CourseName = objRow[convQuestionnaire_Knowledge.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire_KnowledgeEN.CourseChapterId = objRow[convQuestionnaire_Knowledge.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_KnowledgeEN.CourseChapterName = objRow[convQuestionnaire_Knowledge.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaire_KnowledgeEN.ChapterId = objRow[convQuestionnaire_Knowledge.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_KnowledgeEN.SectionId = objRow[convQuestionnaire_Knowledge.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_KnowledgeEN.ChapterName = objRow[convQuestionnaire_Knowledge.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_KnowledgeEN.SectionName = objRow[convQuestionnaire_Knowledge.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionName].ToString().Trim(); //节名
objvQuestionnaire_KnowledgeEN.ChapterNameSim = objRow[convQuestionnaire_Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_KnowledgeEN.SectionNameSim = objRow[convQuestionnaire_Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_KnowledgeEN.ParentNodeId = objRow[convQuestionnaire_Knowledge.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire_KnowledgeEN.CourseChapterReferred = objRow[convQuestionnaire_Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaire_KnowledgeEN.ParentNodeName = objRow[convQuestionnaire_Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaire_KnowledgeEN.ParentNodeReferred = objRow[convQuestionnaire_Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaire_KnowledgeEN.QuestionTypeId = objRow[convQuestionnaire_Knowledge.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_KnowledgeEN.QuestionTypeName = objRow[convQuestionnaire_Knowledge.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire_KnowledgeEN.ExamGradeId = objRow[convQuestionnaire_Knowledge.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire_KnowledgeEN.ExamGradeName = objRow[convQuestionnaire_Knowledge.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire_KnowledgeEN.AnswerTypeId = objRow[convQuestionnaire_Knowledge.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_KnowledgeEN.AnswerTypeName = objRow[convQuestionnaire_Knowledge.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaire_KnowledgeEN.GridTitle = objRow[convQuestionnaire_Knowledge.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_KnowledgeEN.AnswerModeId = objRow[convQuestionnaire_Knowledge.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_KnowledgeEN.AnswerModeName = objRow[convQuestionnaire_Knowledge.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaire_KnowledgeEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaire_KnowledgeEN.QuestionnaireSetId = objRow[convQuestionnaire_Knowledge.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaire_KnowledgeEN.QuestionnaireSetName = objRow[convQuestionnaire_Knowledge.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaire_KnowledgeEN.QuestionScore = objRow[convQuestionnaire_Knowledge.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire_Knowledge.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire_KnowledgeEN.QuestionNameAdd = objRow[convQuestionnaire_Knowledge.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaire_KnowledgeEN.DefaultValue = objRow[convQuestionnaire_Knowledge.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaire_KnowledgeEN.TextDirectId = objRow[convQuestionnaire_Knowledge.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaire_KnowledgeEN.TextDirectName = objRow[convQuestionnaire_Knowledge.TextDirectName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectName].ToString().Trim(); //文本方向名
objvQuestionnaire_KnowledgeEN.FillInTextWidth = objRow[convQuestionnaire_Knowledge.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaire_KnowledgeEN.MemoTextWidth = objRow[convQuestionnaire_Knowledge.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaire_KnowledgeEN.CodeTab = objRow[convQuestionnaire_Knowledge.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTab].ToString().Trim(); //代码表
objvQuestionnaire_KnowledgeEN.CodeTabCode = objRow[convQuestionnaire_Knowledge.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaire_KnowledgeEN.CodeTabName = objRow[convQuestionnaire_Knowledge.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaire_KnowledgeEN.CodeTabCondition = objRow[convQuestionnaire_Knowledge.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaire_KnowledgeEN.RelaEvent = objRow[convQuestionnaire_Knowledge.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RelaEvent].ToString().Trim(); //相关事件
objvQuestionnaire_KnowledgeEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaire_KnowledgeEN.DefaultSelectItem = objRow[convQuestionnaire_Knowledge.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaire_KnowledgeEN.IsAutoGridTitle = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objvQuestionnaire_KnowledgeEN.FillInTextHeight = objRow[convQuestionnaire_Knowledge.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaire_KnowledgeEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaire_KnowledgeEN.CheckBoxLimitCount = objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaire_KnowledgeEN.RoleId = objRow[convQuestionnaire_Knowledge.RoleId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleId].ToString().Trim(); //角色Id
objvQuestionnaire_KnowledgeEN.RoleName = objRow[convQuestionnaire_Knowledge.RoleName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleName].ToString().Trim(); //角色名
objvQuestionnaire_KnowledgeEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_KnowledgeEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsCast].ToString().Trim()); //是否播放
objvQuestionnaire_KnowledgeEN.LikeCount = objRow[convQuestionnaire_Knowledge.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaire_KnowledgeEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaire_KnowledgeEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaire_KnowledgeEN.UpdDate = objRow[convQuestionnaire_Knowledge.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire_KnowledgeEN.UpdUser = objRow[convQuestionnaire_Knowledge.UpdUser].ToString().Trim(); //修改人
objvQuestionnaire_KnowledgeEN.Memo = objRow[convQuestionnaire_Knowledge.Memo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.Memo].ToString().Trim(); //备注
objvQuestionnaire_KnowledgeEN.KnowledgeNum = objRow[convQuestionnaire_Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
objvQuestionnaire_KnowledgeEN.AnswerNum = objRow[convQuestionnaire_Knowledge.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.AnswerNum].ToString().Trim()); //答案数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_KnowledgeEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_KnowledgeEN);
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
public static List<clsvQuestionnaire_KnowledgeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQuestionnaire_KnowledgeEN> arrObjLst = new List<clsvQuestionnaire_KnowledgeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = new clsvQuestionnaire_KnowledgeEN();
try
{
objvQuestionnaire_KnowledgeEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Knowledge.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_KnowledgeEN.QuestionIndex = objRow[convQuestionnaire_Knowledge.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_KnowledgeEN.QuestionName = objRow[convQuestionnaire_Knowledge.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_KnowledgeEN.QuestionContent = objRow[convQuestionnaire_Knowledge.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaire_KnowledgeEN.QuestionMemo = objRow[convQuestionnaire_Knowledge.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaire_KnowledgeEN.QuestionNo = objRow[convQuestionnaire_Knowledge.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_KnowledgeEN.ExamAnswer = objRow[convQuestionnaire_Knowledge.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaire_KnowledgeEN.CourseId = objRow[convQuestionnaire_Knowledge.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_KnowledgeEN.CourseName = objRow[convQuestionnaire_Knowledge.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire_KnowledgeEN.CourseChapterId = objRow[convQuestionnaire_Knowledge.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_KnowledgeEN.CourseChapterName = objRow[convQuestionnaire_Knowledge.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaire_KnowledgeEN.ChapterId = objRow[convQuestionnaire_Knowledge.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_KnowledgeEN.SectionId = objRow[convQuestionnaire_Knowledge.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_KnowledgeEN.ChapterName = objRow[convQuestionnaire_Knowledge.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_KnowledgeEN.SectionName = objRow[convQuestionnaire_Knowledge.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionName].ToString().Trim(); //节名
objvQuestionnaire_KnowledgeEN.ChapterNameSim = objRow[convQuestionnaire_Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_KnowledgeEN.SectionNameSim = objRow[convQuestionnaire_Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_KnowledgeEN.ParentNodeId = objRow[convQuestionnaire_Knowledge.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire_KnowledgeEN.CourseChapterReferred = objRow[convQuestionnaire_Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaire_KnowledgeEN.ParentNodeName = objRow[convQuestionnaire_Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaire_KnowledgeEN.ParentNodeReferred = objRow[convQuestionnaire_Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaire_KnowledgeEN.QuestionTypeId = objRow[convQuestionnaire_Knowledge.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_KnowledgeEN.QuestionTypeName = objRow[convQuestionnaire_Knowledge.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire_KnowledgeEN.ExamGradeId = objRow[convQuestionnaire_Knowledge.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire_KnowledgeEN.ExamGradeName = objRow[convQuestionnaire_Knowledge.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire_KnowledgeEN.AnswerTypeId = objRow[convQuestionnaire_Knowledge.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_KnowledgeEN.AnswerTypeName = objRow[convQuestionnaire_Knowledge.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaire_KnowledgeEN.GridTitle = objRow[convQuestionnaire_Knowledge.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_KnowledgeEN.AnswerModeId = objRow[convQuestionnaire_Knowledge.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_KnowledgeEN.AnswerModeName = objRow[convQuestionnaire_Knowledge.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaire_KnowledgeEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaire_KnowledgeEN.QuestionnaireSetId = objRow[convQuestionnaire_Knowledge.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaire_KnowledgeEN.QuestionnaireSetName = objRow[convQuestionnaire_Knowledge.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaire_KnowledgeEN.QuestionScore = objRow[convQuestionnaire_Knowledge.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire_Knowledge.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire_KnowledgeEN.QuestionNameAdd = objRow[convQuestionnaire_Knowledge.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaire_KnowledgeEN.DefaultValue = objRow[convQuestionnaire_Knowledge.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaire_KnowledgeEN.TextDirectId = objRow[convQuestionnaire_Knowledge.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaire_KnowledgeEN.TextDirectName = objRow[convQuestionnaire_Knowledge.TextDirectName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectName].ToString().Trim(); //文本方向名
objvQuestionnaire_KnowledgeEN.FillInTextWidth = objRow[convQuestionnaire_Knowledge.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaire_KnowledgeEN.MemoTextWidth = objRow[convQuestionnaire_Knowledge.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaire_KnowledgeEN.CodeTab = objRow[convQuestionnaire_Knowledge.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTab].ToString().Trim(); //代码表
objvQuestionnaire_KnowledgeEN.CodeTabCode = objRow[convQuestionnaire_Knowledge.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaire_KnowledgeEN.CodeTabName = objRow[convQuestionnaire_Knowledge.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaire_KnowledgeEN.CodeTabCondition = objRow[convQuestionnaire_Knowledge.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaire_KnowledgeEN.RelaEvent = objRow[convQuestionnaire_Knowledge.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RelaEvent].ToString().Trim(); //相关事件
objvQuestionnaire_KnowledgeEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaire_KnowledgeEN.DefaultSelectItem = objRow[convQuestionnaire_Knowledge.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaire_KnowledgeEN.IsAutoGridTitle = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objvQuestionnaire_KnowledgeEN.FillInTextHeight = objRow[convQuestionnaire_Knowledge.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaire_KnowledgeEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaire_KnowledgeEN.CheckBoxLimitCount = objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaire_KnowledgeEN.RoleId = objRow[convQuestionnaire_Knowledge.RoleId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleId].ToString().Trim(); //角色Id
objvQuestionnaire_KnowledgeEN.RoleName = objRow[convQuestionnaire_Knowledge.RoleName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleName].ToString().Trim(); //角色名
objvQuestionnaire_KnowledgeEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_KnowledgeEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsCast].ToString().Trim()); //是否播放
objvQuestionnaire_KnowledgeEN.LikeCount = objRow[convQuestionnaire_Knowledge.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaire_KnowledgeEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaire_KnowledgeEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaire_KnowledgeEN.UpdDate = objRow[convQuestionnaire_Knowledge.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire_KnowledgeEN.UpdUser = objRow[convQuestionnaire_Knowledge.UpdUser].ToString().Trim(); //修改人
objvQuestionnaire_KnowledgeEN.Memo = objRow[convQuestionnaire_Knowledge.Memo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.Memo].ToString().Trim(); //备注
objvQuestionnaire_KnowledgeEN.KnowledgeNum = objRow[convQuestionnaire_Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
objvQuestionnaire_KnowledgeEN.AnswerNum = objRow[convQuestionnaire_Knowledge.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.AnswerNum].ToString().Trim()); //答案数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_KnowledgeEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_KnowledgeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaire_KnowledgeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQuestionnaire_KnowledgeEN> arrObjLst = new List<clsvQuestionnaire_KnowledgeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = new clsvQuestionnaire_KnowledgeEN();
try
{
objvQuestionnaire_KnowledgeEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Knowledge.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_KnowledgeEN.QuestionIndex = objRow[convQuestionnaire_Knowledge.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_KnowledgeEN.QuestionName = objRow[convQuestionnaire_Knowledge.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_KnowledgeEN.QuestionContent = objRow[convQuestionnaire_Knowledge.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaire_KnowledgeEN.QuestionMemo = objRow[convQuestionnaire_Knowledge.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaire_KnowledgeEN.QuestionNo = objRow[convQuestionnaire_Knowledge.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_KnowledgeEN.ExamAnswer = objRow[convQuestionnaire_Knowledge.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaire_KnowledgeEN.CourseId = objRow[convQuestionnaire_Knowledge.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_KnowledgeEN.CourseName = objRow[convQuestionnaire_Knowledge.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire_KnowledgeEN.CourseChapterId = objRow[convQuestionnaire_Knowledge.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_KnowledgeEN.CourseChapterName = objRow[convQuestionnaire_Knowledge.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaire_KnowledgeEN.ChapterId = objRow[convQuestionnaire_Knowledge.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_KnowledgeEN.SectionId = objRow[convQuestionnaire_Knowledge.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_KnowledgeEN.ChapterName = objRow[convQuestionnaire_Knowledge.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_KnowledgeEN.SectionName = objRow[convQuestionnaire_Knowledge.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionName].ToString().Trim(); //节名
objvQuestionnaire_KnowledgeEN.ChapterNameSim = objRow[convQuestionnaire_Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_KnowledgeEN.SectionNameSim = objRow[convQuestionnaire_Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_KnowledgeEN.ParentNodeId = objRow[convQuestionnaire_Knowledge.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire_KnowledgeEN.CourseChapterReferred = objRow[convQuestionnaire_Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaire_KnowledgeEN.ParentNodeName = objRow[convQuestionnaire_Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaire_KnowledgeEN.ParentNodeReferred = objRow[convQuestionnaire_Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaire_KnowledgeEN.QuestionTypeId = objRow[convQuestionnaire_Knowledge.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_KnowledgeEN.QuestionTypeName = objRow[convQuestionnaire_Knowledge.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire_KnowledgeEN.ExamGradeId = objRow[convQuestionnaire_Knowledge.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire_KnowledgeEN.ExamGradeName = objRow[convQuestionnaire_Knowledge.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire_KnowledgeEN.AnswerTypeId = objRow[convQuestionnaire_Knowledge.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_KnowledgeEN.AnswerTypeName = objRow[convQuestionnaire_Knowledge.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaire_KnowledgeEN.GridTitle = objRow[convQuestionnaire_Knowledge.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_KnowledgeEN.AnswerModeId = objRow[convQuestionnaire_Knowledge.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_KnowledgeEN.AnswerModeName = objRow[convQuestionnaire_Knowledge.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaire_KnowledgeEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaire_KnowledgeEN.QuestionnaireSetId = objRow[convQuestionnaire_Knowledge.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaire_KnowledgeEN.QuestionnaireSetName = objRow[convQuestionnaire_Knowledge.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaire_KnowledgeEN.QuestionScore = objRow[convQuestionnaire_Knowledge.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire_Knowledge.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire_KnowledgeEN.QuestionNameAdd = objRow[convQuestionnaire_Knowledge.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaire_KnowledgeEN.DefaultValue = objRow[convQuestionnaire_Knowledge.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaire_KnowledgeEN.TextDirectId = objRow[convQuestionnaire_Knowledge.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaire_KnowledgeEN.TextDirectName = objRow[convQuestionnaire_Knowledge.TextDirectName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectName].ToString().Trim(); //文本方向名
objvQuestionnaire_KnowledgeEN.FillInTextWidth = objRow[convQuestionnaire_Knowledge.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaire_KnowledgeEN.MemoTextWidth = objRow[convQuestionnaire_Knowledge.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaire_KnowledgeEN.CodeTab = objRow[convQuestionnaire_Knowledge.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTab].ToString().Trim(); //代码表
objvQuestionnaire_KnowledgeEN.CodeTabCode = objRow[convQuestionnaire_Knowledge.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaire_KnowledgeEN.CodeTabName = objRow[convQuestionnaire_Knowledge.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaire_KnowledgeEN.CodeTabCondition = objRow[convQuestionnaire_Knowledge.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaire_KnowledgeEN.RelaEvent = objRow[convQuestionnaire_Knowledge.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RelaEvent].ToString().Trim(); //相关事件
objvQuestionnaire_KnowledgeEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaire_KnowledgeEN.DefaultSelectItem = objRow[convQuestionnaire_Knowledge.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaire_KnowledgeEN.IsAutoGridTitle = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objvQuestionnaire_KnowledgeEN.FillInTextHeight = objRow[convQuestionnaire_Knowledge.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaire_KnowledgeEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaire_KnowledgeEN.CheckBoxLimitCount = objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaire_KnowledgeEN.RoleId = objRow[convQuestionnaire_Knowledge.RoleId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleId].ToString().Trim(); //角色Id
objvQuestionnaire_KnowledgeEN.RoleName = objRow[convQuestionnaire_Knowledge.RoleName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleName].ToString().Trim(); //角色名
objvQuestionnaire_KnowledgeEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_KnowledgeEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsCast].ToString().Trim()); //是否播放
objvQuestionnaire_KnowledgeEN.LikeCount = objRow[convQuestionnaire_Knowledge.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaire_KnowledgeEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaire_KnowledgeEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaire_KnowledgeEN.UpdDate = objRow[convQuestionnaire_Knowledge.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire_KnowledgeEN.UpdUser = objRow[convQuestionnaire_Knowledge.UpdUser].ToString().Trim(); //修改人
objvQuestionnaire_KnowledgeEN.Memo = objRow[convQuestionnaire_Knowledge.Memo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.Memo].ToString().Trim(); //备注
objvQuestionnaire_KnowledgeEN.KnowledgeNum = objRow[convQuestionnaire_Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
objvQuestionnaire_KnowledgeEN.AnswerNum = objRow[convQuestionnaire_Knowledge.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.AnswerNum].ToString().Trim()); //答案数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_KnowledgeEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_KnowledgeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQuestionnaire_Knowledge(ref clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN)
{
bool bolResult = vQuestionnaire_KnowledgeDA.GetvQuestionnaire_Knowledge(ref objvQuestionnaire_KnowledgeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaire_KnowledgeEN GetObjByQuestionId(long lngQuestionId)
{
clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = vQuestionnaire_KnowledgeDA.GetObjByQuestionId(lngQuestionId);
return objvQuestionnaire_KnowledgeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQuestionnaire_KnowledgeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = vQuestionnaire_KnowledgeDA.GetFirstObj(strWhereCond);
 return objvQuestionnaire_KnowledgeEN;
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
public static clsvQuestionnaire_KnowledgeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = vQuestionnaire_KnowledgeDA.GetObjByDataRow(objRow);
 return objvQuestionnaire_KnowledgeEN;
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
public static clsvQuestionnaire_KnowledgeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = vQuestionnaire_KnowledgeDA.GetObjByDataRow(objRow);
 return objvQuestionnaire_KnowledgeEN;
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
 /// <param name = "lngQuestionId">所给的关键字</param>
 /// <param name = "lstvQuestionnaire_KnowledgeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionnaire_KnowledgeEN GetObjByQuestionIdFromList(long lngQuestionId, List<clsvQuestionnaire_KnowledgeEN> lstvQuestionnaire_KnowledgeObjLst)
{
foreach (clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN in lstvQuestionnaire_KnowledgeObjLst)
{
if (objvQuestionnaire_KnowledgeEN.QuestionId == lngQuestionId)
{
return objvQuestionnaire_KnowledgeEN;
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
 long lngQuestionId;
 try
 {
 lngQuestionId = new clsvQuestionnaire_KnowledgeDA().GetFirstID(strWhereCond);
 return lngQuestionId;
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
 arrList = vQuestionnaire_KnowledgeDA.GetID(strWhereCond);
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
bool bolIsExist = vQuestionnaire_KnowledgeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngQuestionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngQuestionId)
{
//检测记录是否存在
bool bolIsExist = vQuestionnaire_KnowledgeDA.IsExist(lngQuestionId);
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
 bolIsExist = clsvQuestionnaire_KnowledgeDA.IsExistTable();
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
 bolIsExist = vQuestionnaire_KnowledgeDA.IsExistTable(strTabName);
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
 /// <param name = "objvQuestionnaire_KnowledgeENS">源对象</param>
 /// <param name = "objvQuestionnaire_KnowledgeENT">目标对象</param>
 public static void CopyTo(clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeENS, clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeENT)
{
try
{
objvQuestionnaire_KnowledgeENT.QuestionId = objvQuestionnaire_KnowledgeENS.QuestionId; //题目Id
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
objvQuestionnaire_KnowledgeENT.ChapterNameSim = objvQuestionnaire_KnowledgeENS.ChapterNameSim; //章名简称
objvQuestionnaire_KnowledgeENT.SectionNameSim = objvQuestionnaire_KnowledgeENS.SectionNameSim; //节名简称
objvQuestionnaire_KnowledgeENT.ParentNodeId = objvQuestionnaire_KnowledgeENS.ParentNodeId; //父节点编号
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
objvQuestionnaire_KnowledgeENT.QuestionNameAdd = objvQuestionnaire_KnowledgeENS.QuestionNameAdd; //题目补充
objvQuestionnaire_KnowledgeENT.DefaultValue = objvQuestionnaire_KnowledgeENS.DefaultValue; //缺省值
objvQuestionnaire_KnowledgeENT.TextDirectId = objvQuestionnaire_KnowledgeENS.TextDirectId; //文本方向ID
objvQuestionnaire_KnowledgeENT.TextDirectName = objvQuestionnaire_KnowledgeENS.TextDirectName; //文本方向名
objvQuestionnaire_KnowledgeENT.FillInTextWidth = objvQuestionnaire_KnowledgeENS.FillInTextWidth; //填空框宽度
objvQuestionnaire_KnowledgeENT.MemoTextWidth = objvQuestionnaire_KnowledgeENS.MemoTextWidth; //备注框宽度
objvQuestionnaire_KnowledgeENT.CodeTab = objvQuestionnaire_KnowledgeENS.CodeTab; //代码表
objvQuestionnaire_KnowledgeENT.CodeTabCode = objvQuestionnaire_KnowledgeENS.CodeTabCode; //CodeTab_Code
objvQuestionnaire_KnowledgeENT.CodeTabName = objvQuestionnaire_KnowledgeENS.CodeTabName; //CodeTab_Name
objvQuestionnaire_KnowledgeENT.CodeTabCondition = objvQuestionnaire_KnowledgeENS.CodeTabCondition; //代码表_条件
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
 /// <param name = "objvQuestionnaire_KnowledgeEN">源简化对象</param>
 public static void SetUpdFlag(clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN)
{
try
{
objvQuestionnaire_KnowledgeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQuestionnaire_KnowledgeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQuestionnaire_Knowledge.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.QuestionId = objvQuestionnaire_KnowledgeEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.QuestionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.QuestionIndex = objvQuestionnaire_KnowledgeEN.QuestionIndex; //题目序号
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.QuestionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.QuestionName = objvQuestionnaire_KnowledgeEN.QuestionName == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.QuestionName; //题目名称
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.QuestionContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.QuestionContent = objvQuestionnaire_KnowledgeEN.QuestionContent == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.QuestionContent; //题目内容
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.QuestionMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.QuestionMemo = objvQuestionnaire_KnowledgeEN.QuestionMemo == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.QuestionMemo; //题目说明
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.QuestionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.QuestionNo = objvQuestionnaire_KnowledgeEN.QuestionNo == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.QuestionNo; //题目编号
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.ExamAnswer, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.ExamAnswer = objvQuestionnaire_KnowledgeEN.ExamAnswer == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.ExamAnswer; //题目答案
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.CourseId = objvQuestionnaire_KnowledgeEN.CourseId == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.CourseName = objvQuestionnaire_KnowledgeEN.CourseName == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.CourseChapterId = objvQuestionnaire_KnowledgeEN.CourseChapterId == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.CourseChapterName = objvQuestionnaire_KnowledgeEN.CourseChapterName == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.ChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.ChapterId = objvQuestionnaire_KnowledgeEN.ChapterId == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.ChapterId; //章Id
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.SectionId = objvQuestionnaire_KnowledgeEN.SectionId == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.SectionId; //节Id
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.ChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.ChapterName = objvQuestionnaire_KnowledgeEN.ChapterName == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.ChapterName; //章名
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.SectionName = objvQuestionnaire_KnowledgeEN.SectionName == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.SectionName; //节名
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.ChapterNameSim = objvQuestionnaire_KnowledgeEN.ChapterNameSim == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.SectionNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.SectionNameSim = objvQuestionnaire_KnowledgeEN.SectionNameSim == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.SectionNameSim; //节名简称
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.ParentNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.ParentNodeId = objvQuestionnaire_KnowledgeEN.ParentNodeId == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.ParentNodeId; //父节点编号
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.CourseChapterReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.CourseChapterReferred = objvQuestionnaire_KnowledgeEN.CourseChapterReferred == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.CourseChapterReferred; //节简称
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.ParentNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.ParentNodeName = objvQuestionnaire_KnowledgeEN.ParentNodeName == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.ParentNodeName; //父节点名称
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.ParentNodeReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.ParentNodeReferred = objvQuestionnaire_KnowledgeEN.ParentNodeReferred == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.ParentNodeReferred; //章简称
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.QuestionTypeId = objvQuestionnaire_KnowledgeEN.QuestionTypeId == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.QuestionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.QuestionTypeName = objvQuestionnaire_KnowledgeEN.QuestionTypeName == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.QuestionTypeName; //题目类型名
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.ExamGradeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.ExamGradeId = objvQuestionnaire_KnowledgeEN.ExamGradeId == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.ExamGradeId; //题库等级ID
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.ExamGradeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.ExamGradeName = objvQuestionnaire_KnowledgeEN.ExamGradeName == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.ExamGradeName; //题库等级名
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.AnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.AnswerTypeId = objvQuestionnaire_KnowledgeEN.AnswerTypeId == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.AnswerTypeId; //答案类型ID
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.AnswerTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.AnswerTypeName = objvQuestionnaire_KnowledgeEN.AnswerTypeName == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.AnswerTypeName; //答案类型名
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.GridTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.GridTitle = objvQuestionnaire_KnowledgeEN.GridTitle == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.GridTitle; //表格标题
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.AnswerModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.AnswerModeId = objvQuestionnaire_KnowledgeEN.AnswerModeId == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.AnswerModeId; //答案模式Id
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.AnswerModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.AnswerModeName = objvQuestionnaire_KnowledgeEN.AnswerModeName == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.AnswerModeName; //答案模式名称
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.IsHaveAdditionalMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.IsHaveAdditionalMemo = objvQuestionnaire_KnowledgeEN.IsHaveAdditionalMemo; //是否有附加说明
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.QuestionnaireSetId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.QuestionnaireSetId = objvQuestionnaire_KnowledgeEN.QuestionnaireSetId == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.QuestionnaireSetId; //问卷集ID
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.QuestionnaireSetName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.QuestionnaireSetName = objvQuestionnaire_KnowledgeEN.QuestionnaireSetName == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.QuestionnaireSetName; //问卷集名
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.QuestionScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.QuestionScore = objvQuestionnaire_KnowledgeEN.QuestionScore; //题目得分
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.QuestionNameAdd, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.QuestionNameAdd = objvQuestionnaire_KnowledgeEN.QuestionNameAdd == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.QuestionNameAdd; //题目补充
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.DefaultValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.DefaultValue = objvQuestionnaire_KnowledgeEN.DefaultValue == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.DefaultValue; //缺省值
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.TextDirectId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.TextDirectId = objvQuestionnaire_KnowledgeEN.TextDirectId == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.TextDirectId; //文本方向ID
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.TextDirectName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.TextDirectName = objvQuestionnaire_KnowledgeEN.TextDirectName == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.TextDirectName; //文本方向名
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.FillInTextWidth, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.FillInTextWidth = objvQuestionnaire_KnowledgeEN.FillInTextWidth; //填空框宽度
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.MemoTextWidth, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.MemoTextWidth = objvQuestionnaire_KnowledgeEN.MemoTextWidth; //备注框宽度
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.CodeTab, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.CodeTab = objvQuestionnaire_KnowledgeEN.CodeTab == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.CodeTab; //代码表
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.CodeTabCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.CodeTabCode = objvQuestionnaire_KnowledgeEN.CodeTabCode == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.CodeTabCode; //CodeTab_Code
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.CodeTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.CodeTabName = objvQuestionnaire_KnowledgeEN.CodeTabName == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.CodeTabName; //CodeTab_Name
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.CodeTabCondition, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.CodeTabCondition = objvQuestionnaire_KnowledgeEN.CodeTabCondition == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.CodeTabCondition; //代码表_条件
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.RelaEvent, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.RelaEvent = objvQuestionnaire_KnowledgeEN.RelaEvent == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.RelaEvent; //相关事件
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.FirstIndent, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.FirstIndent = objvQuestionnaire_KnowledgeEN.FirstIndent; //首行缩进
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.DefaultSelectItem, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.DefaultSelectItem = objvQuestionnaire_KnowledgeEN.DefaultSelectItem == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.DefaultSelectItem; //默认选项
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.IsAutoGridTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.IsAutoGridTitle = objvQuestionnaire_KnowledgeEN.IsAutoGridTitle; //是否自动编表格标题
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.FillInTextHeight, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.FillInTextHeight = objvQuestionnaire_KnowledgeEN.FillInTextHeight; //填空框高度
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.IsMulti4FillInText, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.IsMulti4FillInText = objvQuestionnaire_KnowledgeEN.IsMulti4FillInText; //是否填空框多行
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.CheckBoxLimitCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.CheckBoxLimitCount = objvQuestionnaire_KnowledgeEN.CheckBoxLimitCount; //复选框限制数
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.RoleId = objvQuestionnaire_KnowledgeEN.RoleId == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.RoleId; //角色Id
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.RoleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.RoleName = objvQuestionnaire_KnowledgeEN.RoleName == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.RoleName; //角色名
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.IsShow = objvQuestionnaire_KnowledgeEN.IsShow; //是否启用
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.IsCast, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.IsCast = objvQuestionnaire_KnowledgeEN.IsCast; //是否播放
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.LikeCount = objvQuestionnaire_KnowledgeEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.IsEffective, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.IsEffective = objvQuestionnaire_KnowledgeEN.IsEffective; //是否有效
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.IsCanInPaper, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.IsCanInPaper = objvQuestionnaire_KnowledgeEN.IsCanInPaper; //是否可在Paper
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.UpdDate = objvQuestionnaire_KnowledgeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.UpdUser = objvQuestionnaire_KnowledgeEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.Memo = objvQuestionnaire_KnowledgeEN.Memo == "[null]" ? null :  objvQuestionnaire_KnowledgeEN.Memo; //备注
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.KnowledgeNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.KnowledgeNum = objvQuestionnaire_KnowledgeEN.KnowledgeNum; //知识点数
}
if (arrFldSet.Contains(convQuestionnaire_Knowledge.AnswerNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_KnowledgeEN.AnswerNum = objvQuestionnaire_KnowledgeEN.AnswerNum; //答案数
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
 /// <param name = "objvQuestionnaire_KnowledgeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN)
{
try
{
if (objvQuestionnaire_KnowledgeEN.QuestionName == "[null]") objvQuestionnaire_KnowledgeEN.QuestionName = null; //题目名称
if (objvQuestionnaire_KnowledgeEN.QuestionContent == "[null]") objvQuestionnaire_KnowledgeEN.QuestionContent = null; //题目内容
if (objvQuestionnaire_KnowledgeEN.QuestionMemo == "[null]") objvQuestionnaire_KnowledgeEN.QuestionMemo = null; //题目说明
if (objvQuestionnaire_KnowledgeEN.QuestionNo == "[null]") objvQuestionnaire_KnowledgeEN.QuestionNo = null; //题目编号
if (objvQuestionnaire_KnowledgeEN.ExamAnswer == "[null]") objvQuestionnaire_KnowledgeEN.ExamAnswer = null; //题目答案
if (objvQuestionnaire_KnowledgeEN.CourseId == "[null]") objvQuestionnaire_KnowledgeEN.CourseId = null; //课程Id
if (objvQuestionnaire_KnowledgeEN.CourseName == "[null]") objvQuestionnaire_KnowledgeEN.CourseName = null; //课程名称
if (objvQuestionnaire_KnowledgeEN.CourseChapterId == "[null]") objvQuestionnaire_KnowledgeEN.CourseChapterId = null; //课程章节ID
if (objvQuestionnaire_KnowledgeEN.CourseChapterName == "[null]") objvQuestionnaire_KnowledgeEN.CourseChapterName = null; //课程章节名称
if (objvQuestionnaire_KnowledgeEN.ChapterId == "[null]") objvQuestionnaire_KnowledgeEN.ChapterId = null; //章Id
if (objvQuestionnaire_KnowledgeEN.SectionId == "[null]") objvQuestionnaire_KnowledgeEN.SectionId = null; //节Id
if (objvQuestionnaire_KnowledgeEN.ChapterName == "[null]") objvQuestionnaire_KnowledgeEN.ChapterName = null; //章名
if (objvQuestionnaire_KnowledgeEN.SectionName == "[null]") objvQuestionnaire_KnowledgeEN.SectionName = null; //节名
if (objvQuestionnaire_KnowledgeEN.ChapterNameSim == "[null]") objvQuestionnaire_KnowledgeEN.ChapterNameSim = null; //章名简称
if (objvQuestionnaire_KnowledgeEN.SectionNameSim == "[null]") objvQuestionnaire_KnowledgeEN.SectionNameSim = null; //节名简称
if (objvQuestionnaire_KnowledgeEN.ParentNodeId == "[null]") objvQuestionnaire_KnowledgeEN.ParentNodeId = null; //父节点编号
if (objvQuestionnaire_KnowledgeEN.CourseChapterReferred == "[null]") objvQuestionnaire_KnowledgeEN.CourseChapterReferred = null; //节简称
if (objvQuestionnaire_KnowledgeEN.ParentNodeName == "[null]") objvQuestionnaire_KnowledgeEN.ParentNodeName = null; //父节点名称
if (objvQuestionnaire_KnowledgeEN.ParentNodeReferred == "[null]") objvQuestionnaire_KnowledgeEN.ParentNodeReferred = null; //章简称
if (objvQuestionnaire_KnowledgeEN.QuestionTypeId == "[null]") objvQuestionnaire_KnowledgeEN.QuestionTypeId = null; //题目类型Id
if (objvQuestionnaire_KnowledgeEN.QuestionTypeName == "[null]") objvQuestionnaire_KnowledgeEN.QuestionTypeName = null; //题目类型名
if (objvQuestionnaire_KnowledgeEN.ExamGradeId == "[null]") objvQuestionnaire_KnowledgeEN.ExamGradeId = null; //题库等级ID
if (objvQuestionnaire_KnowledgeEN.ExamGradeName == "[null]") objvQuestionnaire_KnowledgeEN.ExamGradeName = null; //题库等级名
if (objvQuestionnaire_KnowledgeEN.AnswerTypeId == "[null]") objvQuestionnaire_KnowledgeEN.AnswerTypeId = null; //答案类型ID
if (objvQuestionnaire_KnowledgeEN.AnswerTypeName == "[null]") objvQuestionnaire_KnowledgeEN.AnswerTypeName = null; //答案类型名
if (objvQuestionnaire_KnowledgeEN.GridTitle == "[null]") objvQuestionnaire_KnowledgeEN.GridTitle = null; //表格标题
if (objvQuestionnaire_KnowledgeEN.AnswerModeId == "[null]") objvQuestionnaire_KnowledgeEN.AnswerModeId = null; //答案模式Id
if (objvQuestionnaire_KnowledgeEN.AnswerModeName == "[null]") objvQuestionnaire_KnowledgeEN.AnswerModeName = null; //答案模式名称
if (objvQuestionnaire_KnowledgeEN.QuestionnaireSetId == "[null]") objvQuestionnaire_KnowledgeEN.QuestionnaireSetId = null; //问卷集ID
if (objvQuestionnaire_KnowledgeEN.QuestionnaireSetName == "[null]") objvQuestionnaire_KnowledgeEN.QuestionnaireSetName = null; //问卷集名
if (objvQuestionnaire_KnowledgeEN.QuestionNameAdd == "[null]") objvQuestionnaire_KnowledgeEN.QuestionNameAdd = null; //题目补充
if (objvQuestionnaire_KnowledgeEN.DefaultValue == "[null]") objvQuestionnaire_KnowledgeEN.DefaultValue = null; //缺省值
if (objvQuestionnaire_KnowledgeEN.TextDirectId == "[null]") objvQuestionnaire_KnowledgeEN.TextDirectId = null; //文本方向ID
if (objvQuestionnaire_KnowledgeEN.TextDirectName == "[null]") objvQuestionnaire_KnowledgeEN.TextDirectName = null; //文本方向名
if (objvQuestionnaire_KnowledgeEN.CodeTab == "[null]") objvQuestionnaire_KnowledgeEN.CodeTab = null; //代码表
if (objvQuestionnaire_KnowledgeEN.CodeTabCode == "[null]") objvQuestionnaire_KnowledgeEN.CodeTabCode = null; //CodeTab_Code
if (objvQuestionnaire_KnowledgeEN.CodeTabName == "[null]") objvQuestionnaire_KnowledgeEN.CodeTabName = null; //CodeTab_Name
if (objvQuestionnaire_KnowledgeEN.CodeTabCondition == "[null]") objvQuestionnaire_KnowledgeEN.CodeTabCondition = null; //代码表_条件
if (objvQuestionnaire_KnowledgeEN.RelaEvent == "[null]") objvQuestionnaire_KnowledgeEN.RelaEvent = null; //相关事件
if (objvQuestionnaire_KnowledgeEN.DefaultSelectItem == "[null]") objvQuestionnaire_KnowledgeEN.DefaultSelectItem = null; //默认选项
if (objvQuestionnaire_KnowledgeEN.RoleId == "[null]") objvQuestionnaire_KnowledgeEN.RoleId = null; //角色Id
if (objvQuestionnaire_KnowledgeEN.RoleName == "[null]") objvQuestionnaire_KnowledgeEN.RoleName = null; //角色名
if (objvQuestionnaire_KnowledgeEN.Memo == "[null]") objvQuestionnaire_KnowledgeEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN)
{
 vQuestionnaire_KnowledgeDA.CheckProperty4Condition(objvQuestionnaire_KnowledgeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strCourseId"></param>
public static void BindCbo_QuestionId(System.Windows.Forms.ComboBox objComboBox , string strCourseId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQuestionnaire_Knowledge.QuestionId); 
List<clsvQuestionnaire_KnowledgeEN> arrObjLst = clsvQuestionnaire_KnowledgeBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = new clsvQuestionnaire_KnowledgeEN()
{
QuestionId = 0,
QuestionName = "选[v题目表_知识点]..."
};
arrObjLstSel.Insert(0, objvQuestionnaire_KnowledgeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQuestionnaire_Knowledge.QuestionId;
objComboBox.DisplayMember = convQuestionnaire_Knowledge.QuestionName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strCourseId"></param>
public static void BindDdl_QuestionId(System.Web.UI.WebControls.DropDownList objDDL , string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v题目表_知识点]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convQuestionnaire_Knowledge.QuestionId); 
IEnumerable<clsvQuestionnaire_KnowledgeEN> arrObjLst = clsvQuestionnaire_KnowledgeBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
objDDL.DataValueField = convQuestionnaire_Knowledge.QuestionId;
objDDL.DataTextField = convQuestionnaire_Knowledge.QuestionName;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_QuestionIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v题目表_知识点]...","0");
List<clsvQuestionnaire_KnowledgeEN> arrvQuestionnaire_KnowledgeObjLst = GetAllvQuestionnaire_KnowledgeObjLstCache(strCourseId); 
objDDL.DataValueField = convQuestionnaire_Knowledge.QuestionId;
objDDL.DataTextField = convQuestionnaire_Knowledge.QuestionName;
objDDL.DataSource = arrvQuestionnaire_KnowledgeObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsQuestionnaireSetBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireSetBL没有刷新缓存机制(clsQuestionnaireSetBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeBL没有刷新缓存机制(clsQuestionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserRolesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserRolesBL没有刷新缓存机制(clsUserRolesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTextDirectBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTextDirectBL没有刷新缓存机制(clsTextDirectBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by QuestionId");
//if (arrvQuestionnaire_KnowledgeObjLstCache == null)
//{
//arrvQuestionnaire_KnowledgeObjLstCache = vQuestionnaire_KnowledgeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngQuestionId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionnaire_KnowledgeEN GetObjByQuestionIdCache(long lngQuestionId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvQuestionnaire_KnowledgeEN._CurrTabName, strCourseId);
List<clsvQuestionnaire_KnowledgeEN> arrvQuestionnaire_KnowledgeObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionnaire_KnowledgeEN> arrvQuestionnaire_KnowledgeObjLst_Sel =
arrvQuestionnaire_KnowledgeObjLstCache
.Where(x=> x.QuestionId == lngQuestionId 
);
if (arrvQuestionnaire_KnowledgeObjLst_Sel.Count() == 0)
{
   clsvQuestionnaire_KnowledgeEN obj = clsvQuestionnaire_KnowledgeBL.GetObjByQuestionId(lngQuestionId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngQuestionId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvQuestionnaire_KnowledgeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngQuestionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetQuestionNameByQuestionIdCache(long lngQuestionId, string strCourseId)
{
//获取缓存中的对象列表
clsvQuestionnaire_KnowledgeEN objvQuestionnaire_Knowledge = GetObjByQuestionIdCache(lngQuestionId, strCourseId);
if (objvQuestionnaire_Knowledge == null) return "";
return objvQuestionnaire_Knowledge.QuestionName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngQuestionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByQuestionIdCache(long lngQuestionId, string strCourseId)
{
//获取缓存中的对象列表
clsvQuestionnaire_KnowledgeEN objvQuestionnaire_Knowledge = GetObjByQuestionIdCache(lngQuestionId, strCourseId);
if (objvQuestionnaire_Knowledge == null) return "";
return objvQuestionnaire_Knowledge.QuestionName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionnaire_KnowledgeEN> GetAllvQuestionnaire_KnowledgeObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvQuestionnaire_KnowledgeEN> arrvQuestionnaire_KnowledgeObjLstCache = GetObjLstCache(strCourseId); 
return arrvQuestionnaire_KnowledgeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionnaire_KnowledgeEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvQuestionnaire_KnowledgeEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvQuestionnaire_KnowledgeEN> arrvQuestionnaire_KnowledgeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvQuestionnaire_KnowledgeObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvQuestionnaire_KnowledgeEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsvQuestionnaire_KnowledgeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsvQuestionnaire_KnowledgeEN._RefreshTimeLst.Count == 0) return "";
return clsvQuestionnaire_KnowledgeEN._RefreshTimeLst[clsvQuestionnaire_KnowledgeEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-11-09
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngQuestionId, string strCourseId)
{
if (strInFldName != convQuestionnaire_Knowledge.QuestionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQuestionnaire_Knowledge.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQuestionnaire_Knowledge.AttributeName));
throw new Exception(strMsg);
}
var objvQuestionnaire_Knowledge = clsvQuestionnaire_KnowledgeBL.GetObjByQuestionIdCache(lngQuestionId, strCourseId);
if (objvQuestionnaire_Knowledge == null) return "";
return objvQuestionnaire_Knowledge[strOutFldName].ToString();
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
int intRecCount = clsvQuestionnaire_KnowledgeDA.GetRecCount(strTabName);
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
int intRecCount = clsvQuestionnaire_KnowledgeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQuestionnaire_KnowledgeDA.GetRecCount();
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
int intRecCount = clsvQuestionnaire_KnowledgeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeCond)
{
 string strCourseId = objvQuestionnaire_KnowledgeCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvQuestionnaire_KnowledgeBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvQuestionnaire_KnowledgeEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionnaire_KnowledgeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionnaire_Knowledge.AttributeName)
{
if (objvQuestionnaire_KnowledgeCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionnaire_KnowledgeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaire_KnowledgeCond[strFldName].ToString());
}
else
{
if (objvQuestionnaire_KnowledgeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionnaire_KnowledgeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaire_KnowledgeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionnaire_KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionnaire_KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionnaire_KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionnaire_KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionnaire_KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionnaire_KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionnaire_KnowledgeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionnaire_KnowledgeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionnaire_KnowledgeCond[strFldName]));
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
 List<string> arrList = clsvQuestionnaire_KnowledgeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQuestionnaire_KnowledgeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQuestionnaire_KnowledgeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}