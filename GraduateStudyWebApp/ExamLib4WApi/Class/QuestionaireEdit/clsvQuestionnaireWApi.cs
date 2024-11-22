
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaireWApi
 表名:vQuestionnaire(01120019)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:07
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
public static class clsvQuestionnaireWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionID(this clsvQuestionnaireEN objvQuestionnaireEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convQuestionnaire.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convQuestionnaire.QuestionID);
objvQuestionnaireEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.QuestionID) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.QuestionID, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.QuestionID] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionIndex(this clsvQuestionnaireEN objvQuestionnaireEN, int intQuestionIndex, string strComparisonOp="")
	{
objvQuestionnaireEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.QuestionIndex) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.QuestionIndex, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.QuestionIndex] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionName(this clsvQuestionnaireEN objvQuestionnaireEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convQuestionnaire.QuestionName);
objvQuestionnaireEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.QuestionName) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.QuestionName, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.QuestionName] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionContent(this clsvQuestionnaireEN objvQuestionnaireEN, string strQuestionContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, convQuestionnaire.QuestionContent);
objvQuestionnaireEN.QuestionContent = strQuestionContent; //题目内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.QuestionContent) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.QuestionContent, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.QuestionContent] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionMemo(this clsvQuestionnaireEN objvQuestionnaireEN, string strQuestionMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionMemo, 1000, convQuestionnaire.QuestionMemo);
objvQuestionnaireEN.QuestionMemo = strQuestionMemo; //题目说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.QuestionMemo) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.QuestionMemo, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.QuestionMemo] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionNo(this clsvQuestionnaireEN objvQuestionnaireEN, string strQuestionNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, convQuestionnaire.QuestionNo);
objvQuestionnaireEN.QuestionNo = strQuestionNo; //题目编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.QuestionNo) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.QuestionNo, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.QuestionNo] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetParentQuestionId(this clsvQuestionnaireEN objvQuestionnaireEN, string strParentQuestionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentQuestionId, 8, convQuestionnaire.ParentQuestionId);
clsCheckSql.CheckFieldForeignKey(strParentQuestionId, 8, convQuestionnaire.ParentQuestionId);
objvQuestionnaireEN.ParentQuestionId = strParentQuestionId; //父题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.ParentQuestionId) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.ParentQuestionId, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.ParentQuestionId] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetExamAnswer(this clsvQuestionnaireEN objvQuestionnaireEN, string strExamAnswer, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamAnswer, 8000, convQuestionnaire.ExamAnswer);
objvQuestionnaireEN.ExamAnswer = strExamAnswer; //题目答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.ExamAnswer) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.ExamAnswer, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.ExamAnswer] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetCourseId(this clsvQuestionnaireEN objvQuestionnaireEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convQuestionnaire.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convQuestionnaire.CourseId);
objvQuestionnaireEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.CourseId) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.CourseId, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.CourseId] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetCourseCode(this clsvQuestionnaireEN objvQuestionnaireEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convQuestionnaire.CourseCode);
objvQuestionnaireEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.CourseCode) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.CourseCode, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.CourseCode] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetCourseName(this clsvQuestionnaireEN objvQuestionnaireEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convQuestionnaire.CourseName);
objvQuestionnaireEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.CourseName) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.CourseName, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.CourseName] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetLevelNo(this clsvQuestionnaireEN objvQuestionnaireEN, int intLevelNo, string strComparisonOp="")
	{
objvQuestionnaireEN.LevelNo = intLevelNo; //学习关号2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.LevelNo) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.LevelNo, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.LevelNo] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetCourseChapterId(this clsvQuestionnaireEN objvQuestionnaireEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convQuestionnaire.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convQuestionnaire.CourseChapterId);
objvQuestionnaireEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.CourseChapterId) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.CourseChapterId, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.CourseChapterId] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetCourseChapterName(this clsvQuestionnaireEN objvQuestionnaireEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convQuestionnaire.CourseChapterName);
objvQuestionnaireEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.CourseChapterName) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.CourseChapterName, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.CourseChapterName] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetChapterId(this clsvQuestionnaireEN objvQuestionnaireEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, convQuestionnaire.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convQuestionnaire.ChapterId);
objvQuestionnaireEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.ChapterId) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.ChapterId, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.ChapterId] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetSectionId(this clsvQuestionnaireEN objvQuestionnaireEN, string strSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionId, 8, convQuestionnaire.SectionId);
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convQuestionnaire.SectionId);
objvQuestionnaireEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.SectionId) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.SectionId, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.SectionId] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetChapterName(this clsvQuestionnaireEN objvQuestionnaireEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convQuestionnaire.ChapterName);
objvQuestionnaireEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.ChapterName) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.ChapterName, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.ChapterName] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetSectionName(this clsvQuestionnaireEN objvQuestionnaireEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convQuestionnaire.SectionName);
objvQuestionnaireEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.SectionName) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.SectionName, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.SectionName] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetChapterName_Sim(this clsvQuestionnaireEN objvQuestionnaireEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convQuestionnaire.ChapterName_Sim);
objvQuestionnaireEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.ChapterName_Sim) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.ChapterName_Sim, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.ChapterName_Sim] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetSectionName_Sim(this clsvQuestionnaireEN objvQuestionnaireEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convQuestionnaire.SectionName_Sim);
objvQuestionnaireEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.SectionName_Sim) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.SectionName_Sim, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.SectionName_Sim] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetParentNodeID(this clsvQuestionnaireEN objvQuestionnaireEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convQuestionnaire.ParentNodeID);
objvQuestionnaireEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.ParentNodeID) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.ParentNodeID, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.ParentNodeID] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetCourseChapterReferred(this clsvQuestionnaireEN objvQuestionnaireEN, string strCourseChapterReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convQuestionnaire.CourseChapterReferred);
objvQuestionnaireEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.CourseChapterReferred) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.CourseChapterReferred, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.CourseChapterReferred] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetParentNodeName(this clsvQuestionnaireEN objvQuestionnaireEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convQuestionnaire.ParentNodeName);
objvQuestionnaireEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.ParentNodeName) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.ParentNodeName, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.ParentNodeName] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetParentNodeReferred(this clsvQuestionnaireEN objvQuestionnaireEN, string strParentNodeReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convQuestionnaire.ParentNodeReferred);
objvQuestionnaireEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.ParentNodeReferred) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.ParentNodeReferred, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.ParentNodeReferred] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionTypeId(this clsvQuestionnaireEN objvQuestionnaireEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convQuestionnaire.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convQuestionnaire.QuestionTypeId);
objvQuestionnaireEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.QuestionTypeId) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.QuestionTypeId, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.QuestionTypeId] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionTypeName(this clsvQuestionnaireEN objvQuestionnaireEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convQuestionnaire.QuestionTypeName);
objvQuestionnaireEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.QuestionTypeName) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.QuestionTypeName, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.QuestionTypeName] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionTypeId4Course(this clsvQuestionnaireEN objvQuestionnaireEN, string strQuestionTypeId4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeId4Course, convQuestionnaire.QuestionTypeId4Course);
clsCheckSql.CheckFieldLen(strQuestionTypeId4Course, 8, convQuestionnaire.QuestionTypeId4Course);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId4Course, 8, convQuestionnaire.QuestionTypeId4Course);
objvQuestionnaireEN.QuestionTypeId4Course = strQuestionTypeId4Course; //题目类型Id4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.QuestionTypeId4Course) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.QuestionTypeId4Course, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.QuestionTypeId4Course] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionTypeName4Course(this clsvQuestionnaireEN objvQuestionnaireEN, string strQuestionTypeName4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName4Course, 30, convQuestionnaire.QuestionTypeName4Course);
objvQuestionnaireEN.QuestionTypeName4Course = strQuestionTypeName4Course; //题目类型名4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.QuestionTypeName4Course) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.QuestionTypeName4Course, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.QuestionTypeName4Course] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetAnswerTypeId(this clsvQuestionnaireEN objvQuestionnaireEN, string strAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convQuestionnaire.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convQuestionnaire.AnswerTypeId);
objvQuestionnaireEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.AnswerTypeId) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.AnswerTypeId, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.AnswerTypeId] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetAnswerTypeName(this clsvQuestionnaireEN objvQuestionnaireEN, string strAnswerTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeName, 50, convQuestionnaire.AnswerTypeName);
objvQuestionnaireEN.AnswerTypeName = strAnswerTypeName; //答案类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.AnswerTypeName) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.AnswerTypeName, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.AnswerTypeName] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetGridTitle(this clsvQuestionnaireEN objvQuestionnaireEN, string strGridTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGridTitle, 30, convQuestionnaire.GridTitle);
objvQuestionnaireEN.GridTitle = strGridTitle; //表格标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.GridTitle) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.GridTitle, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.GridTitle] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetAnswerModeId(this clsvQuestionnaireEN objvQuestionnaireEN, string strAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convQuestionnaire.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convQuestionnaire.AnswerModeId);
objvQuestionnaireEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.AnswerModeId) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.AnswerModeId, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.AnswerModeId] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetAnswerModeName(this clsvQuestionnaireEN objvQuestionnaireEN, string strAnswerModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeName, 30, convQuestionnaire.AnswerModeName);
objvQuestionnaireEN.AnswerModeName = strAnswerModeName; //答案模式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.AnswerModeName) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.AnswerModeName, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.AnswerModeName] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionScore(this clsvQuestionnaireEN objvQuestionnaireEN, float fltQuestionScore, string strComparisonOp="")
	{
objvQuestionnaireEN.QuestionScore = fltQuestionScore; //题目得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.QuestionScore) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.QuestionScore, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.QuestionScore] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetDefaultValue(this clsvQuestionnaireEN objvQuestionnaireEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convQuestionnaire.DefaultValue);
objvQuestionnaireEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.DefaultValue) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.DefaultValue, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.DefaultValue] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetDefaultSelectItem(this clsvQuestionnaireEN objvQuestionnaireEN, string strDefaultSelectItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultSelectItem, 20, convQuestionnaire.DefaultSelectItem);
objvQuestionnaireEN.DefaultSelectItem = strDefaultSelectItem; //默认选项
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.DefaultSelectItem) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.DefaultSelectItem, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.DefaultSelectItem] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetIsShow(this clsvQuestionnaireEN objvQuestionnaireEN, bool bolIsShow, string strComparisonOp="")
	{
objvQuestionnaireEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.IsShow) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.IsShow, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.IsShow] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetIsCast(this clsvQuestionnaireEN objvQuestionnaireEN, bool bolIsCast, string strComparisonOp="")
	{
objvQuestionnaireEN.IsCast = bolIsCast; //是否播放
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.IsCast) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.IsCast, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.IsCast] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetLikeCount(this clsvQuestionnaireEN objvQuestionnaireEN, long lngLikeCount, string strComparisonOp="")
	{
objvQuestionnaireEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.LikeCount) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.LikeCount, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.LikeCount] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetAnswerAttLimitSize(this clsvQuestionnaireEN objvQuestionnaireEN, long lngAnswerAttLimitSize, string strComparisonOp="")
	{
objvQuestionnaireEN.AnswerAttLimitSize = lngAnswerAttLimitSize; //回答附件限制大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.AnswerAttLimitSize) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.AnswerAttLimitSize, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.AnswerAttLimitSize] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetLimitedResourceType(this clsvQuestionnaireEN objvQuestionnaireEN, string strLimitedResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLimitedResourceType, 100, convQuestionnaire.LimitedResourceType);
objvQuestionnaireEN.LimitedResourceType = strLimitedResourceType; //限制资源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.LimitedResourceType) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.LimitedResourceType, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.LimitedResourceType] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetIsEffective(this clsvQuestionnaireEN objvQuestionnaireEN, bool bolIsEffective, string strComparisonOp="")
	{
objvQuestionnaireEN.IsEffective = bolIsEffective; //是否有效
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.IsEffective) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.IsEffective, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.IsEffective] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetIsCanInPaper(this clsvQuestionnaireEN objvQuestionnaireEN, bool bolIsCanInPaper, string strComparisonOp="")
	{
objvQuestionnaireEN.IsCanInPaper = bolIsCanInPaper; //是否可在Paper
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.IsCanInPaper) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.IsCanInPaper, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.IsCanInPaper] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetExamGradeId(this clsvQuestionnaireEN objvQuestionnaireEN, string strExamGradeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamGradeId, 2, convQuestionnaire.ExamGradeId);
clsCheckSql.CheckFieldForeignKey(strExamGradeId, 2, convQuestionnaire.ExamGradeId);
objvQuestionnaireEN.ExamGradeId = strExamGradeId; //题库等级ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.ExamGradeId) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.ExamGradeId, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.ExamGradeId] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetExamGradeName(this clsvQuestionnaireEN objvQuestionnaireEN, string strExamGradeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamGradeName, 50, convQuestionnaire.ExamGradeName);
objvQuestionnaireEN.ExamGradeName = strExamGradeName; //题库等级名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.ExamGradeName) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.ExamGradeName, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.ExamGradeName] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetTextDirectId(this clsvQuestionnaireEN objvQuestionnaireEN, string strTextDirectId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTextDirectId, 4, convQuestionnaire.TextDirectId);
clsCheckSql.CheckFieldForeignKey(strTextDirectId, 4, convQuestionnaire.TextDirectId);
objvQuestionnaireEN.TextDirectId = strTextDirectId; //文本方向ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.TextDirectId) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.TextDirectId, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.TextDirectId] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetUpdDate(this clsvQuestionnaireEN objvQuestionnaireEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQuestionnaire.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQuestionnaire.UpdDate);
objvQuestionnaireEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.UpdDate) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.UpdDate, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.UpdDate] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetUpdUser(this clsvQuestionnaireEN objvQuestionnaireEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convQuestionnaire.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQuestionnaire.UpdUser);
objvQuestionnaireEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.UpdUser) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.UpdUser, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.UpdUser] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetMemo(this clsvQuestionnaireEN objvQuestionnaireEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQuestionnaire.Memo);
objvQuestionnaireEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.Memo) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.Memo, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.Memo] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetFirstIndent(this clsvQuestionnaireEN objvQuestionnaireEN, bool bolFirstIndent, string strComparisonOp="")
	{
objvQuestionnaireEN.FirstIndent = bolFirstIndent; //首行缩进
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.FirstIndent) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.FirstIndent, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.FirstIndent] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetCodeTab(this clsvQuestionnaireEN objvQuestionnaireEN, string strCodeTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTab, 50, convQuestionnaire.CodeTab);
objvQuestionnaireEN.CodeTab = strCodeTab; //代码表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.CodeTab) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.CodeTab, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.CodeTab] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetCodeTab_Code(this clsvQuestionnaireEN objvQuestionnaireEN, string strCodeTab_Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTab_Code, 50, convQuestionnaire.CodeTab_Code);
objvQuestionnaireEN.CodeTab_Code = strCodeTab_Code; //CodeTab_Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.CodeTab_Code) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.CodeTab_Code, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.CodeTab_Code] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetCodeTab_Condition(this clsvQuestionnaireEN objvQuestionnaireEN, string strCodeTab_Condition, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTab_Condition, 200, convQuestionnaire.CodeTab_Condition);
objvQuestionnaireEN.CodeTab_Condition = strCodeTab_Condition; //代码表_条件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.CodeTab_Condition) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.CodeTab_Condition, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.CodeTab_Condition] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetCodeTab_Name(this clsvQuestionnaireEN objvQuestionnaireEN, string strCodeTab_Name, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTab_Name, 50, convQuestionnaire.CodeTab_Name);
objvQuestionnaireEN.CodeTab_Name = strCodeTab_Name; //CodeTab_Name
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.CodeTab_Name) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.CodeTab_Name, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.CodeTab_Name] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetCourseId_Chapter(this clsvQuestionnaireEN objvQuestionnaireEN, string strCourseId_Chapter, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId_Chapter, 8, convQuestionnaire.CourseId_Chapter);
clsCheckSql.CheckFieldForeignKey(strCourseId_Chapter, 8, convQuestionnaire.CourseId_Chapter);
objvQuestionnaireEN.CourseId_Chapter = strCourseId_Chapter; //CourseId_Chapter
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.CourseId_Chapter) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.CourseId_Chapter, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.CourseId_Chapter] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetOptionNum(this clsvQuestionnaireEN objvQuestionnaireEN, int intOptionNum, string strComparisonOp="")
	{
objvQuestionnaireEN.OptionNum = intOptionNum; //选项数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.OptionNum) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.OptionNum, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.OptionNum] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetChapterOrderNum(this clsvQuestionnaireEN objvQuestionnaireEN, int intChapterOrderNum, string strComparisonOp="")
	{
objvQuestionnaireEN.ChapterOrderNum = intChapterOrderNum; //章排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.ChapterOrderNum) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.ChapterOrderNum, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.ChapterOrderNum] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionName_Add(this clsvQuestionnaireEN objvQuestionnaireEN, string strQuestionName_Add, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName_Add, 500, convQuestionnaire.QuestionName_Add);
objvQuestionnaireEN.QuestionName_Add = strQuestionName_Add; //题目补充
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.QuestionName_Add) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.QuestionName_Add, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.QuestionName_Add] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetDifficultyLevelId(this clsvQuestionnaireEN objvQuestionnaireEN, string strDifficultyLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDifficultyLevelId, 2, convQuestionnaire.DifficultyLevelId);
clsCheckSql.CheckFieldForeignKey(strDifficultyLevelId, 2, convQuestionnaire.DifficultyLevelId);
objvQuestionnaireEN.DifficultyLevelId = strDifficultyLevelId; //难度等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.DifficultyLevelId) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.DifficultyLevelId, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.DifficultyLevelId] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetFillInTextHeight(this clsvQuestionnaireEN objvQuestionnaireEN, int intFillInTextHeight, string strComparisonOp="")
	{
objvQuestionnaireEN.FillInTextHeight = intFillInTextHeight; //填空框高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.FillInTextHeight) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.FillInTextHeight, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.FillInTextHeight] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetFillInTextWidth(this clsvQuestionnaireEN objvQuestionnaireEN, int intFillInTextWidth, string strComparisonOp="")
	{
objvQuestionnaireEN.FillInTextWidth = intFillInTextWidth; //填空框宽度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.FillInTextWidth) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.FillInTextWidth, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.FillInTextWidth] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetIsHaveAdditionalMemo(this clsvQuestionnaireEN objvQuestionnaireEN, bool bolIsHaveAdditionalMemo, string strComparisonOp="")
	{
objvQuestionnaireEN.IsHaveAdditionalMemo = bolIsHaveAdditionalMemo; //是否有附加说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.IsHaveAdditionalMemo) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.IsHaveAdditionalMemo, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.IsHaveAdditionalMemo] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetIsJs(this clsvQuestionnaireEN objvQuestionnaireEN, bool bolIsJs, string strComparisonOp="")
	{
objvQuestionnaireEN.IsJs = bolIsJs; //是否是JS
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.IsJs) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.IsJs, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.IsJs] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetIsMulti4FillInText(this clsvQuestionnaireEN objvQuestionnaireEN, bool bolIsMulti4FillInText, string strComparisonOp="")
	{
objvQuestionnaireEN.IsMulti4FillInText = bolIsMulti4FillInText; //是否填空框多行
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.IsMulti4FillInText) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.IsMulti4FillInText, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.IsMulti4FillInText] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetKnowledgeGraphId(this clsvQuestionnaireEN objvQuestionnaireEN, string strKnowledgeGraphId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKnowledgeGraphId, 10, convQuestionnaire.KnowledgeGraphId);
clsCheckSql.CheckFieldForeignKey(strKnowledgeGraphId, 10, convQuestionnaire.KnowledgeGraphId);
objvQuestionnaireEN.KnowledgeGraphId = strKnowledgeGraphId; //知识点图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.KnowledgeGraphId) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.KnowledgeGraphId, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.KnowledgeGraphId] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetMemoTextWidth(this clsvQuestionnaireEN objvQuestionnaireEN, int intMemoTextWidth, string strComparisonOp="")
	{
objvQuestionnaireEN.MemoTextWidth = intMemoTextWidth; //备注框宽度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.MemoTextWidth) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.MemoTextWidth, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.MemoTextWidth] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionCode(this clsvQuestionnaireEN objvQuestionnaireEN, string strQuestionCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionCode, 8000, convQuestionnaire.QuestionCode);
objvQuestionnaireEN.QuestionCode = strQuestionCode; //html代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.QuestionCode) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.QuestionCode, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.QuestionCode] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetSectionTypeId(this clsvQuestionnaireEN objvQuestionnaireEN, string strSectionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionTypeId, 8, convQuestionnaire.SectionTypeId);
clsCheckSql.CheckFieldForeignKey(strSectionTypeId, 8, convQuestionnaire.SectionTypeId);
objvQuestionnaireEN.SectionTypeId = strSectionTypeId; //节点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.SectionTypeId) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.SectionTypeId, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.SectionTypeId] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetCheckBoxLimitCount(this clsvQuestionnaireEN objvQuestionnaireEN, int intCheckBoxLimitCount, string strComparisonOp="")
	{
objvQuestionnaireEN.CheckBoxLimitCount = intCheckBoxLimitCount; //复选框限制数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.CheckBoxLimitCount) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.CheckBoxLimitCount, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.CheckBoxLimitCount] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireEN SetRelaEvent(this clsvQuestionnaireEN objvQuestionnaireEN, string strRelaEvent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaEvent, 4000, convQuestionnaire.RelaEvent);
objvQuestionnaireEN.RelaEvent = strRelaEvent; //相关事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.RelaEvent) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.RelaEvent, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.RelaEvent] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionnaireEN objvQuestionnaire_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.QuestionID, objvQuestionnaire_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire.QuestionIndex, objvQuestionnaire_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.QuestionName, objvQuestionnaire_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.QuestionContent) == true)
{
string strComparisonOp_QuestionContent = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.QuestionContent, objvQuestionnaire_Cond.QuestionContent, strComparisonOp_QuestionContent);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.QuestionMemo) == true)
{
string strComparisonOp_QuestionMemo = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.QuestionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.QuestionMemo, objvQuestionnaire_Cond.QuestionMemo, strComparisonOp_QuestionMemo);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.QuestionNo) == true)
{
string strComparisonOp_QuestionNo = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.QuestionNo, objvQuestionnaire_Cond.QuestionNo, strComparisonOp_QuestionNo);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.ParentQuestionId) == true)
{
string strComparisonOp_ParentQuestionId = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.ParentQuestionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.ParentQuestionId, objvQuestionnaire_Cond.ParentQuestionId, strComparisonOp_ParentQuestionId);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.ExamAnswer) == true)
{
string strComparisonOp_ExamAnswer = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.ExamAnswer];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.ExamAnswer, objvQuestionnaire_Cond.ExamAnswer, strComparisonOp_ExamAnswer);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.CourseId) == true)
{
string strComparisonOp_CourseId = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.CourseId, objvQuestionnaire_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.CourseCode, objvQuestionnaire_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.CourseName) == true)
{
string strComparisonOp_CourseName = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.CourseName, objvQuestionnaire_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.LevelNo) == true)
{
string strComparisonOp_LevelNo = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.LevelNo];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire.LevelNo, objvQuestionnaire_Cond.LevelNo, strComparisonOp_LevelNo);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.CourseChapterId, objvQuestionnaire_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.CourseChapterName, objvQuestionnaire_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.ChapterId) == true)
{
string strComparisonOp_ChapterId = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.ChapterId, objvQuestionnaire_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.SectionId) == true)
{
string strComparisonOp_SectionId = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.SectionId, objvQuestionnaire_Cond.SectionId, strComparisonOp_SectionId);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.ChapterName, objvQuestionnaire_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.SectionName) == true)
{
string strComparisonOp_SectionName = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.SectionName, objvQuestionnaire_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.ChapterName_Sim, objvQuestionnaire_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.SectionName_Sim, objvQuestionnaire_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.ParentNodeID, objvQuestionnaire_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.CourseChapterReferred) == true)
{
string strComparisonOp_CourseChapterReferred = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.CourseChapterReferred, objvQuestionnaire_Cond.CourseChapterReferred, strComparisonOp_CourseChapterReferred);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.ParentNodeName, objvQuestionnaire_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.ParentNodeReferred) == true)
{
string strComparisonOp_ParentNodeReferred = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.ParentNodeReferred, objvQuestionnaire_Cond.ParentNodeReferred, strComparisonOp_ParentNodeReferred);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.QuestionTypeId, objvQuestionnaire_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.QuestionTypeName, objvQuestionnaire_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.QuestionTypeId4Course) == true)
{
string strComparisonOp_QuestionTypeId4Course = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.QuestionTypeId4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.QuestionTypeId4Course, objvQuestionnaire_Cond.QuestionTypeId4Course, strComparisonOp_QuestionTypeId4Course);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.QuestionTypeName4Course) == true)
{
string strComparisonOp_QuestionTypeName4Course = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.QuestionTypeName4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.QuestionTypeName4Course, objvQuestionnaire_Cond.QuestionTypeName4Course, strComparisonOp_QuestionTypeName4Course);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.AnswerTypeId) == true)
{
string strComparisonOp_AnswerTypeId = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.AnswerTypeId, objvQuestionnaire_Cond.AnswerTypeId, strComparisonOp_AnswerTypeId);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.AnswerTypeName) == true)
{
string strComparisonOp_AnswerTypeName = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.AnswerTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.AnswerTypeName, objvQuestionnaire_Cond.AnswerTypeName, strComparisonOp_AnswerTypeName);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.GridTitle) == true)
{
string strComparisonOp_GridTitle = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.GridTitle, objvQuestionnaire_Cond.GridTitle, strComparisonOp_GridTitle);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.AnswerModeId) == true)
{
string strComparisonOp_AnswerModeId = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.AnswerModeId, objvQuestionnaire_Cond.AnswerModeId, strComparisonOp_AnswerModeId);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.AnswerModeName) == true)
{
string strComparisonOp_AnswerModeName = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.AnswerModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.AnswerModeName, objvQuestionnaire_Cond.AnswerModeName, strComparisonOp_AnswerModeName);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.QuestionScore) == true)
{
string strComparisonOp_QuestionScore = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.QuestionScore];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire.QuestionScore, objvQuestionnaire_Cond.QuestionScore, strComparisonOp_QuestionScore);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.DefaultValue) == true)
{
string strComparisonOp_DefaultValue = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.DefaultValue, objvQuestionnaire_Cond.DefaultValue, strComparisonOp_DefaultValue);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.DefaultSelectItem) == true)
{
string strComparisonOp_DefaultSelectItem = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.DefaultSelectItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.DefaultSelectItem, objvQuestionnaire_Cond.DefaultSelectItem, strComparisonOp_DefaultSelectItem);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.IsShow) == true)
{
if (objvQuestionnaire_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire.IsShow);
}
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.IsCast) == true)
{
if (objvQuestionnaire_Cond.IsCast == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire.IsCast);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire.IsCast);
}
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire.LikeCount, objvQuestionnaire_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.AnswerAttLimitSize) == true)
{
string strComparisonOp_AnswerAttLimitSize = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.AnswerAttLimitSize];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire.AnswerAttLimitSize, objvQuestionnaire_Cond.AnswerAttLimitSize, strComparisonOp_AnswerAttLimitSize);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.LimitedResourceType) == true)
{
string strComparisonOp_LimitedResourceType = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.LimitedResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.LimitedResourceType, objvQuestionnaire_Cond.LimitedResourceType, strComparisonOp_LimitedResourceType);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.IsEffective) == true)
{
if (objvQuestionnaire_Cond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire.IsEffective);
}
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.IsCanInPaper) == true)
{
if (objvQuestionnaire_Cond.IsCanInPaper == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire.IsCanInPaper);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire.IsCanInPaper);
}
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.ExamGradeId) == true)
{
string strComparisonOp_ExamGradeId = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.ExamGradeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.ExamGradeId, objvQuestionnaire_Cond.ExamGradeId, strComparisonOp_ExamGradeId);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.ExamGradeName) == true)
{
string strComparisonOp_ExamGradeName = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.ExamGradeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.ExamGradeName, objvQuestionnaire_Cond.ExamGradeName, strComparisonOp_ExamGradeName);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.TextDirectId) == true)
{
string strComparisonOp_TextDirectId = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.TextDirectId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.TextDirectId, objvQuestionnaire_Cond.TextDirectId, strComparisonOp_TextDirectId);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.UpdDate, objvQuestionnaire_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.UpdUser, objvQuestionnaire_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.Memo) == true)
{
string strComparisonOp_Memo = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.Memo, objvQuestionnaire_Cond.Memo, strComparisonOp_Memo);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.FirstIndent) == true)
{
if (objvQuestionnaire_Cond.FirstIndent == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire.FirstIndent);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire.FirstIndent);
}
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.CodeTab) == true)
{
string strComparisonOp_CodeTab = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.CodeTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.CodeTab, objvQuestionnaire_Cond.CodeTab, strComparisonOp_CodeTab);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.CodeTab_Code) == true)
{
string strComparisonOp_CodeTab_Code = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.CodeTab_Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.CodeTab_Code, objvQuestionnaire_Cond.CodeTab_Code, strComparisonOp_CodeTab_Code);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.CodeTab_Condition) == true)
{
string strComparisonOp_CodeTab_Condition = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.CodeTab_Condition];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.CodeTab_Condition, objvQuestionnaire_Cond.CodeTab_Condition, strComparisonOp_CodeTab_Condition);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.CodeTab_Name) == true)
{
string strComparisonOp_CodeTab_Name = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.CodeTab_Name];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.CodeTab_Name, objvQuestionnaire_Cond.CodeTab_Name, strComparisonOp_CodeTab_Name);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.CourseId_Chapter) == true)
{
string strComparisonOp_CourseId_Chapter = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.CourseId_Chapter];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.CourseId_Chapter, objvQuestionnaire_Cond.CourseId_Chapter, strComparisonOp_CourseId_Chapter);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.OptionNum) == true)
{
string strComparisonOp_OptionNum = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.OptionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire.OptionNum, objvQuestionnaire_Cond.OptionNum, strComparisonOp_OptionNum);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.ChapterOrderNum) == true)
{
string strComparisonOp_ChapterOrderNum = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.ChapterOrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire.ChapterOrderNum, objvQuestionnaire_Cond.ChapterOrderNum, strComparisonOp_ChapterOrderNum);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.QuestionName_Add) == true)
{
string strComparisonOp_QuestionName_Add = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.QuestionName_Add];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.QuestionName_Add, objvQuestionnaire_Cond.QuestionName_Add, strComparisonOp_QuestionName_Add);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.DifficultyLevelId) == true)
{
string strComparisonOp_DifficultyLevelId = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.DifficultyLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.DifficultyLevelId, objvQuestionnaire_Cond.DifficultyLevelId, strComparisonOp_DifficultyLevelId);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.FillInTextHeight) == true)
{
string strComparisonOp_FillInTextHeight = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.FillInTextHeight];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire.FillInTextHeight, objvQuestionnaire_Cond.FillInTextHeight, strComparisonOp_FillInTextHeight);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.FillInTextWidth) == true)
{
string strComparisonOp_FillInTextWidth = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.FillInTextWidth];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire.FillInTextWidth, objvQuestionnaire_Cond.FillInTextWidth, strComparisonOp_FillInTextWidth);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.IsHaveAdditionalMemo) == true)
{
if (objvQuestionnaire_Cond.IsHaveAdditionalMemo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire.IsHaveAdditionalMemo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire.IsHaveAdditionalMemo);
}
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.IsJs) == true)
{
if (objvQuestionnaire_Cond.IsJs == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire.IsJs);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire.IsJs);
}
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.IsMulti4FillInText) == true)
{
if (objvQuestionnaire_Cond.IsMulti4FillInText == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire.IsMulti4FillInText);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire.IsMulti4FillInText);
}
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.KnowledgeGraphId) == true)
{
string strComparisonOp_KnowledgeGraphId = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.KnowledgeGraphId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.KnowledgeGraphId, objvQuestionnaire_Cond.KnowledgeGraphId, strComparisonOp_KnowledgeGraphId);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.MemoTextWidth) == true)
{
string strComparisonOp_MemoTextWidth = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.MemoTextWidth];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire.MemoTextWidth, objvQuestionnaire_Cond.MemoTextWidth, strComparisonOp_MemoTextWidth);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.QuestionCode) == true)
{
string strComparisonOp_QuestionCode = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.QuestionCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.QuestionCode, objvQuestionnaire_Cond.QuestionCode, strComparisonOp_QuestionCode);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.SectionTypeId) == true)
{
string strComparisonOp_SectionTypeId = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.SectionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.SectionTypeId, objvQuestionnaire_Cond.SectionTypeId, strComparisonOp_SectionTypeId);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.CheckBoxLimitCount) == true)
{
string strComparisonOp_CheckBoxLimitCount = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.CheckBoxLimitCount];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire.CheckBoxLimitCount, objvQuestionnaire_Cond.CheckBoxLimitCount, strComparisonOp_CheckBoxLimitCount);
}
if (objvQuestionnaire_Cond.IsUpdated(convQuestionnaire.RelaEvent) == true)
{
string strComparisonOp_RelaEvent = objvQuestionnaire_Cond.dicFldComparisonOp[convQuestionnaire.RelaEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.RelaEvent, objvQuestionnaire_Cond.RelaEvent, strComparisonOp_RelaEvent);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v题目(vQuestionnaire)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionnaireWApi
{
private static readonly string mstrApiControllerName = "vQuestionnaireApi";

 public clsvQuestionnaireWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v题目]...","0");
List<clsvQuestionnaireEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", convQuestionnaire.QuestionID); 
List<clsvQuestionnaireEN> arrObjLst = clsvQuestionnaireWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQuestionnaireEN objvQuestionnaireEN = new clsvQuestionnaireEN()
{
QuestionID = "0",
QuestionName = "选[v题目]..."
};
arrObjLst.Insert(0, objvQuestionnaireEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQuestionnaire.QuestionID;
objComboBox.DisplayMember = convQuestionnaire.QuestionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQuestionID">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaireEN GetObjByQuestionID(string strQuestionID)
{
string strAction = "GetObjByQuestionID";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionnaireEN objvQuestionnaireEN = null;
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
objvQuestionnaireEN = JsonConvert.DeserializeObject<clsvQuestionnaireEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionnaireEN;
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
public static clsvQuestionnaireEN GetObjByQuestionID_WA_Cache(string strQuestionID, string strCourseId)
{
string strAction = "GetObjByQuestionID_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionnaireEN objvQuestionnaireEN = null;
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
objvQuestionnaireEN = JsonConvert.DeserializeObject<clsvQuestionnaireEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionnaireEN;
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
public static clsvQuestionnaireEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionnaireEN objvQuestionnaireEN = null;
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
objvQuestionnaireEN = JsonConvert.DeserializeObject<clsvQuestionnaireEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionnaireEN;
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
public static clsvQuestionnaireEN GetObjByQuestionID_Cache(string strQuestionID, string strCourseId)
{
if (string.IsNullOrEmpty(strQuestionID) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvQuestionnaireEN._CurrTabName_S, strCourseId);
List<clsvQuestionnaireEN> arrvQuestionnaireObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvQuestionnaireEN> arrvQuestionnaireObjLst_Sel =
from objvQuestionnaireEN in arrvQuestionnaireObjLst_Cache
where objvQuestionnaireEN.QuestionID == strQuestionID
select objvQuestionnaireEN;
if (arrvQuestionnaireObjLst_Sel.Count() == 0)
{
   clsvQuestionnaireEN obj = clsvQuestionnaireWApi.GetObjByQuestionID(strQuestionID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvQuestionnaireObjLst_Sel.First();
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
string strKey = string.Format("{0}_{1}", clsvQuestionnaireEN._CurrTabName_S, strCourseId);
List<clsvQuestionnaireEN> arrvQuestionnaireObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvQuestionnaireEN> arrvQuestionnaireObjLst_Sel1 =
from objvQuestionnaireEN in arrvQuestionnaireObjLst_Cache
where objvQuestionnaireEN.QuestionID == strQuestionID
select objvQuestionnaireEN;
List <clsvQuestionnaireEN> arrvQuestionnaireObjLst_Sel = new List<clsvQuestionnaireEN>();
foreach (clsvQuestionnaireEN obj in arrvQuestionnaireObjLst_Sel1)
{
arrvQuestionnaireObjLst_Sel.Add(obj);
}
if (arrvQuestionnaireObjLst_Sel.Count > 0)
{
return arrvQuestionnaireObjLst_Sel[0].QuestionName;
}
string strErrMsgForGetObjById = string.Format("在vQuestionnaire对象缓存列表中,找不到记录[QuestionID = {0}](函数:{1})", strQuestionID, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvQuestionnaireBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
string strKey = string.Format("{0}_{1}", clsvQuestionnaireEN._CurrTabName_S, strCourseId);
List<clsvQuestionnaireEN> arrvQuestionnaireObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvQuestionnaireEN> arrvQuestionnaireObjLst_Sel1 =
from objvQuestionnaireEN in arrvQuestionnaireObjLst_Cache
where objvQuestionnaireEN.QuestionID == strQuestionID
select objvQuestionnaireEN;
List <clsvQuestionnaireEN> arrvQuestionnaireObjLst_Sel = new List<clsvQuestionnaireEN>();
foreach (clsvQuestionnaireEN obj in arrvQuestionnaireObjLst_Sel1)
{
arrvQuestionnaireObjLst_Sel.Add(obj);
}
if (arrvQuestionnaireObjLst_Sel.Count > 0)
{
return arrvQuestionnaireObjLst_Sel[0].QuestionName;
}
string strErrMsgForGetObjById = string.Format("在vQuestionnaire对象缓存列表中,找不到记录的相关名称[QuestionID = {0}](函数:{1})", strQuestionID, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvQuestionnaireBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaireEN> GetObjLst(string strWhereCond)
{
 List<clsvQuestionnaireEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaireEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaireEN> GetObjLstByQuestionIDLst(List<string> arrQuestionID)
{
 List<clsvQuestionnaireEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaireEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvQuestionnaireEN> GetObjLstByQuestionIDLst_Cache(List<string> arrQuestionID, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvQuestionnaireEN._CurrTabName_S, strCourseId);
List<clsvQuestionnaireEN> arrvQuestionnaireObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvQuestionnaireEN> arrvQuestionnaireObjLst_Sel =
from objvQuestionnaireEN in arrvQuestionnaireObjLst_Cache
where arrQuestionID.Contains(objvQuestionnaireEN.QuestionID)
select objvQuestionnaireEN;
return arrvQuestionnaireObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaireEN> GetObjLstByQuestionIDLst_WA_Cache(List<string> arrQuestionID, string strCourseId)
{
 List<clsvQuestionnaireEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaireEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaireEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQuestionnaireEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaireEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaireEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQuestionnaireEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaireEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaireEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQuestionnaireEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaireEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaireEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvQuestionnaireEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaireEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvQuestionnaireENS">源对象</param>
 /// <param name = "objvQuestionnaireENT">目标对象</param>
 public static void CopyTo(clsvQuestionnaireEN objvQuestionnaireENS, clsvQuestionnaireEN objvQuestionnaireENT)
{
try
{
objvQuestionnaireENT.QuestionID = objvQuestionnaireENS.QuestionID; //题目ID
objvQuestionnaireENT.QuestionIndex = objvQuestionnaireENS.QuestionIndex; //题目序号
objvQuestionnaireENT.QuestionName = objvQuestionnaireENS.QuestionName; //题目名称
objvQuestionnaireENT.QuestionContent = objvQuestionnaireENS.QuestionContent; //题目内容
objvQuestionnaireENT.QuestionMemo = objvQuestionnaireENS.QuestionMemo; //题目说明
objvQuestionnaireENT.QuestionNo = objvQuestionnaireENS.QuestionNo; //题目编号
objvQuestionnaireENT.ParentQuestionId = objvQuestionnaireENS.ParentQuestionId; //父题目Id
objvQuestionnaireENT.ExamAnswer = objvQuestionnaireENS.ExamAnswer; //题目答案
objvQuestionnaireENT.CourseId = objvQuestionnaireENS.CourseId; //课程Id
objvQuestionnaireENT.CourseCode = objvQuestionnaireENS.CourseCode; //课程代码
objvQuestionnaireENT.CourseName = objvQuestionnaireENS.CourseName; //课程名称
objvQuestionnaireENT.LevelNo = objvQuestionnaireENS.LevelNo; //学习关号2
objvQuestionnaireENT.CourseChapterId = objvQuestionnaireENS.CourseChapterId; //课程章节ID
objvQuestionnaireENT.CourseChapterName = objvQuestionnaireENS.CourseChapterName; //课程章节名称
objvQuestionnaireENT.ChapterId = objvQuestionnaireENS.ChapterId; //章Id
objvQuestionnaireENT.SectionId = objvQuestionnaireENS.SectionId; //节Id
objvQuestionnaireENT.ChapterName = objvQuestionnaireENS.ChapterName; //章名
objvQuestionnaireENT.SectionName = objvQuestionnaireENS.SectionName; //节名
objvQuestionnaireENT.ChapterName_Sim = objvQuestionnaireENS.ChapterName_Sim; //章名简称
objvQuestionnaireENT.SectionName_Sim = objvQuestionnaireENS.SectionName_Sim; //节名简称
objvQuestionnaireENT.ParentNodeID = objvQuestionnaireENS.ParentNodeID; //父节点编号
objvQuestionnaireENT.CourseChapterReferred = objvQuestionnaireENS.CourseChapterReferred; //节简称
objvQuestionnaireENT.ParentNodeName = objvQuestionnaireENS.ParentNodeName; //父节点名称
objvQuestionnaireENT.ParentNodeReferred = objvQuestionnaireENS.ParentNodeReferred; //章简称
objvQuestionnaireENT.QuestionTypeId = objvQuestionnaireENS.QuestionTypeId; //题目类型Id
objvQuestionnaireENT.QuestionTypeName = objvQuestionnaireENS.QuestionTypeName; //题目类型名
objvQuestionnaireENT.QuestionTypeId4Course = objvQuestionnaireENS.QuestionTypeId4Course; //题目类型Id4课程
objvQuestionnaireENT.QuestionTypeName4Course = objvQuestionnaireENS.QuestionTypeName4Course; //题目类型名4课程
objvQuestionnaireENT.AnswerTypeId = objvQuestionnaireENS.AnswerTypeId; //答案类型ID
objvQuestionnaireENT.AnswerTypeName = objvQuestionnaireENS.AnswerTypeName; //答案类型名
objvQuestionnaireENT.GridTitle = objvQuestionnaireENS.GridTitle; //表格标题
objvQuestionnaireENT.AnswerModeId = objvQuestionnaireENS.AnswerModeId; //答案模式Id
objvQuestionnaireENT.AnswerModeName = objvQuestionnaireENS.AnswerModeName; //答案模式名称
objvQuestionnaireENT.QuestionScore = objvQuestionnaireENS.QuestionScore; //题目得分
objvQuestionnaireENT.DefaultValue = objvQuestionnaireENS.DefaultValue; //缺省值
objvQuestionnaireENT.DefaultSelectItem = objvQuestionnaireENS.DefaultSelectItem; //默认选项
objvQuestionnaireENT.IsShow = objvQuestionnaireENS.IsShow; //是否启用
objvQuestionnaireENT.IsCast = objvQuestionnaireENS.IsCast; //是否播放
objvQuestionnaireENT.LikeCount = objvQuestionnaireENS.LikeCount; //资源喜欢数量
objvQuestionnaireENT.AnswerAttLimitSize = objvQuestionnaireENS.AnswerAttLimitSize; //回答附件限制大小
objvQuestionnaireENT.LimitedResourceType = objvQuestionnaireENS.LimitedResourceType; //限制资源类型
objvQuestionnaireENT.IsEffective = objvQuestionnaireENS.IsEffective; //是否有效
objvQuestionnaireENT.IsCanInPaper = objvQuestionnaireENS.IsCanInPaper; //是否可在Paper
objvQuestionnaireENT.ExamGradeId = objvQuestionnaireENS.ExamGradeId; //题库等级ID
objvQuestionnaireENT.ExamGradeName = objvQuestionnaireENS.ExamGradeName; //题库等级名
objvQuestionnaireENT.TextDirectId = objvQuestionnaireENS.TextDirectId; //文本方向ID
objvQuestionnaireENT.UpdDate = objvQuestionnaireENS.UpdDate; //修改日期
objvQuestionnaireENT.UpdUser = objvQuestionnaireENS.UpdUser; //修改人
objvQuestionnaireENT.Memo = objvQuestionnaireENS.Memo; //备注
objvQuestionnaireENT.FirstIndent = objvQuestionnaireENS.FirstIndent; //首行缩进
objvQuestionnaireENT.CodeTab = objvQuestionnaireENS.CodeTab; //代码表
objvQuestionnaireENT.CodeTab_Code = objvQuestionnaireENS.CodeTab_Code; //CodeTab_Code
objvQuestionnaireENT.CodeTab_Condition = objvQuestionnaireENS.CodeTab_Condition; //代码表_条件
objvQuestionnaireENT.CodeTab_Name = objvQuestionnaireENS.CodeTab_Name; //CodeTab_Name
objvQuestionnaireENT.CourseId_Chapter = objvQuestionnaireENS.CourseId_Chapter; //CourseId_Chapter
objvQuestionnaireENT.OptionNum = objvQuestionnaireENS.OptionNum; //选项数
objvQuestionnaireENT.ChapterOrderNum = objvQuestionnaireENS.ChapterOrderNum; //章排序号
objvQuestionnaireENT.QuestionName_Add = objvQuestionnaireENS.QuestionName_Add; //题目补充
objvQuestionnaireENT.DifficultyLevelId = objvQuestionnaireENS.DifficultyLevelId; //难度等级Id
objvQuestionnaireENT.FillInTextHeight = objvQuestionnaireENS.FillInTextHeight; //填空框高度
objvQuestionnaireENT.FillInTextWidth = objvQuestionnaireENS.FillInTextWidth; //填空框宽度
objvQuestionnaireENT.IsHaveAdditionalMemo = objvQuestionnaireENS.IsHaveAdditionalMemo; //是否有附加说明
objvQuestionnaireENT.IsJs = objvQuestionnaireENS.IsJs; //是否是JS
objvQuestionnaireENT.IsMulti4FillInText = objvQuestionnaireENS.IsMulti4FillInText; //是否填空框多行
objvQuestionnaireENT.KnowledgeGraphId = objvQuestionnaireENS.KnowledgeGraphId; //知识点图Id
objvQuestionnaireENT.MemoTextWidth = objvQuestionnaireENS.MemoTextWidth; //备注框宽度
objvQuestionnaireENT.QuestionCode = objvQuestionnaireENS.QuestionCode; //html代码
objvQuestionnaireENT.SectionTypeId = objvQuestionnaireENS.SectionTypeId; //节点类型Id
objvQuestionnaireENT.CheckBoxLimitCount = objvQuestionnaireENS.CheckBoxLimitCount; //复选框限制数
objvQuestionnaireENT.RelaEvent = objvQuestionnaireENS.RelaEvent; //相关事件
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
public static DataTable ToDataTable(List<clsvQuestionnaireEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQuestionnaireEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQuestionnaireEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQuestionnaireEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQuestionnaireEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQuestionnaireEN.AttributeName)
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
//string strWhereCond = string.Format("1 = 1 order by QuestionID");
//if (arrvQuestionnaireObjLst_Cache == null)
//{
//arrvQuestionnaireObjLst_Cache = await clsvQuestionnaireWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvQuestionnaireEN._CurrTabName_S, strCourseId);
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
public static List<clsvQuestionnaireEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvQuestionnaireEN._CurrTabName_S, strCourseId);
List<clsvQuestionnaireEN> arrvQuestionnaireObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvQuestionnaireObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQuestionnaireEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQuestionnaire.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionnaire.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.QuestionContent, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.QuestionMemo, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.QuestionNo, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.ParentQuestionId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.ExamAnswer, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.LevelNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionnaire.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.SectionId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.CourseChapterReferred, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.ParentNodeReferred, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.QuestionTypeId4Course, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.QuestionTypeName4Course, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.AnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.AnswerTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.GridTitle, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.AnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.AnswerModeName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.QuestionScore, Type.GetType("System.Single"));
objDT.Columns.Add(convQuestionnaire.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.DefaultSelectItem, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQuestionnaire.IsCast, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQuestionnaire.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convQuestionnaire.AnswerAttLimitSize, Type.GetType("System.Int64"));
objDT.Columns.Add(convQuestionnaire.LimitedResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.IsEffective, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQuestionnaire.IsCanInPaper, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQuestionnaire.ExamGradeId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.ExamGradeName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.TextDirectId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.FirstIndent, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQuestionnaire.CodeTab, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.CodeTab_Code, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.CodeTab_Condition, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.CodeTab_Name, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.CourseId_Chapter, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.OptionNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionnaire.ChapterOrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionnaire.QuestionName_Add, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.DifficultyLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.FillInTextHeight, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionnaire.FillInTextWidth, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionnaire.IsHaveAdditionalMemo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQuestionnaire.IsJs, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQuestionnaire.IsMulti4FillInText, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQuestionnaire.KnowledgeGraphId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.MemoTextWidth, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionnaire.QuestionCode, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.SectionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire.CheckBoxLimitCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionnaire.RelaEvent, Type.GetType("System.String"));
foreach (clsvQuestionnaireEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQuestionnaire.QuestionID] = objInFor[convQuestionnaire.QuestionID];
objDR[convQuestionnaire.QuestionIndex] = objInFor[convQuestionnaire.QuestionIndex];
objDR[convQuestionnaire.QuestionName] = objInFor[convQuestionnaire.QuestionName];
objDR[convQuestionnaire.QuestionContent] = objInFor[convQuestionnaire.QuestionContent];
objDR[convQuestionnaire.QuestionMemo] = objInFor[convQuestionnaire.QuestionMemo];
objDR[convQuestionnaire.QuestionNo] = objInFor[convQuestionnaire.QuestionNo];
objDR[convQuestionnaire.ParentQuestionId] = objInFor[convQuestionnaire.ParentQuestionId];
objDR[convQuestionnaire.ExamAnswer] = objInFor[convQuestionnaire.ExamAnswer];
objDR[convQuestionnaire.CourseId] = objInFor[convQuestionnaire.CourseId];
objDR[convQuestionnaire.CourseCode] = objInFor[convQuestionnaire.CourseCode];
objDR[convQuestionnaire.CourseName] = objInFor[convQuestionnaire.CourseName];
objDR[convQuestionnaire.LevelNo] = objInFor[convQuestionnaire.LevelNo];
objDR[convQuestionnaire.CourseChapterId] = objInFor[convQuestionnaire.CourseChapterId];
objDR[convQuestionnaire.CourseChapterName] = objInFor[convQuestionnaire.CourseChapterName];
objDR[convQuestionnaire.ChapterId] = objInFor[convQuestionnaire.ChapterId];
objDR[convQuestionnaire.SectionId] = objInFor[convQuestionnaire.SectionId];
objDR[convQuestionnaire.ChapterName] = objInFor[convQuestionnaire.ChapterName];
objDR[convQuestionnaire.SectionName] = objInFor[convQuestionnaire.SectionName];
objDR[convQuestionnaire.ChapterName_Sim] = objInFor[convQuestionnaire.ChapterName_Sim];
objDR[convQuestionnaire.SectionName_Sim] = objInFor[convQuestionnaire.SectionName_Sim];
objDR[convQuestionnaire.ParentNodeID] = objInFor[convQuestionnaire.ParentNodeID];
objDR[convQuestionnaire.CourseChapterReferred] = objInFor[convQuestionnaire.CourseChapterReferred];
objDR[convQuestionnaire.ParentNodeName] = objInFor[convQuestionnaire.ParentNodeName];
objDR[convQuestionnaire.ParentNodeReferred] = objInFor[convQuestionnaire.ParentNodeReferred];
objDR[convQuestionnaire.QuestionTypeId] = objInFor[convQuestionnaire.QuestionTypeId];
objDR[convQuestionnaire.QuestionTypeName] = objInFor[convQuestionnaire.QuestionTypeName];
objDR[convQuestionnaire.QuestionTypeId4Course] = objInFor[convQuestionnaire.QuestionTypeId4Course];
objDR[convQuestionnaire.QuestionTypeName4Course] = objInFor[convQuestionnaire.QuestionTypeName4Course];
objDR[convQuestionnaire.AnswerTypeId] = objInFor[convQuestionnaire.AnswerTypeId];
objDR[convQuestionnaire.AnswerTypeName] = objInFor[convQuestionnaire.AnswerTypeName];
objDR[convQuestionnaire.GridTitle] = objInFor[convQuestionnaire.GridTitle];
objDR[convQuestionnaire.AnswerModeId] = objInFor[convQuestionnaire.AnswerModeId];
objDR[convQuestionnaire.AnswerModeName] = objInFor[convQuestionnaire.AnswerModeName];
objDR[convQuestionnaire.QuestionScore] = objInFor[convQuestionnaire.QuestionScore];
objDR[convQuestionnaire.DefaultValue] = objInFor[convQuestionnaire.DefaultValue];
objDR[convQuestionnaire.DefaultSelectItem] = objInFor[convQuestionnaire.DefaultSelectItem];
objDR[convQuestionnaire.IsShow] = objInFor[convQuestionnaire.IsShow];
objDR[convQuestionnaire.IsCast] = objInFor[convQuestionnaire.IsCast];
objDR[convQuestionnaire.LikeCount] = objInFor[convQuestionnaire.LikeCount];
objDR[convQuestionnaire.AnswerAttLimitSize] = objInFor[convQuestionnaire.AnswerAttLimitSize];
objDR[convQuestionnaire.LimitedResourceType] = objInFor[convQuestionnaire.LimitedResourceType];
objDR[convQuestionnaire.IsEffective] = objInFor[convQuestionnaire.IsEffective];
objDR[convQuestionnaire.IsCanInPaper] = objInFor[convQuestionnaire.IsCanInPaper];
objDR[convQuestionnaire.ExamGradeId] = objInFor[convQuestionnaire.ExamGradeId];
objDR[convQuestionnaire.ExamGradeName] = objInFor[convQuestionnaire.ExamGradeName];
objDR[convQuestionnaire.TextDirectId] = objInFor[convQuestionnaire.TextDirectId];
objDR[convQuestionnaire.UpdDate] = objInFor[convQuestionnaire.UpdDate];
objDR[convQuestionnaire.UpdUser] = objInFor[convQuestionnaire.UpdUser];
objDR[convQuestionnaire.Memo] = objInFor[convQuestionnaire.Memo];
objDR[convQuestionnaire.FirstIndent] = objInFor[convQuestionnaire.FirstIndent];
objDR[convQuestionnaire.CodeTab] = objInFor[convQuestionnaire.CodeTab];
objDR[convQuestionnaire.CodeTab_Code] = objInFor[convQuestionnaire.CodeTab_Code];
objDR[convQuestionnaire.CodeTab_Condition] = objInFor[convQuestionnaire.CodeTab_Condition];
objDR[convQuestionnaire.CodeTab_Name] = objInFor[convQuestionnaire.CodeTab_Name];
objDR[convQuestionnaire.CourseId_Chapter] = objInFor[convQuestionnaire.CourseId_Chapter];
objDR[convQuestionnaire.OptionNum] = objInFor[convQuestionnaire.OptionNum];
objDR[convQuestionnaire.ChapterOrderNum] = objInFor[convQuestionnaire.ChapterOrderNum];
objDR[convQuestionnaire.QuestionName_Add] = objInFor[convQuestionnaire.QuestionName_Add];
objDR[convQuestionnaire.DifficultyLevelId] = objInFor[convQuestionnaire.DifficultyLevelId];
objDR[convQuestionnaire.FillInTextHeight] = objInFor[convQuestionnaire.FillInTextHeight];
objDR[convQuestionnaire.FillInTextWidth] = objInFor[convQuestionnaire.FillInTextWidth];
objDR[convQuestionnaire.IsHaveAdditionalMemo] = objInFor[convQuestionnaire.IsHaveAdditionalMemo];
objDR[convQuestionnaire.IsJs] = objInFor[convQuestionnaire.IsJs];
objDR[convQuestionnaire.IsMulti4FillInText] = objInFor[convQuestionnaire.IsMulti4FillInText];
objDR[convQuestionnaire.KnowledgeGraphId] = objInFor[convQuestionnaire.KnowledgeGraphId];
objDR[convQuestionnaire.MemoTextWidth] = objInFor[convQuestionnaire.MemoTextWidth];
objDR[convQuestionnaire.QuestionCode] = objInFor[convQuestionnaire.QuestionCode];
objDR[convQuestionnaire.SectionTypeId] = objInFor[convQuestionnaire.SectionTypeId];
objDR[convQuestionnaire.CheckBoxLimitCount] = objInFor[convQuestionnaire.CheckBoxLimitCount];
objDR[convQuestionnaire.RelaEvent] = objInFor[convQuestionnaire.RelaEvent];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}