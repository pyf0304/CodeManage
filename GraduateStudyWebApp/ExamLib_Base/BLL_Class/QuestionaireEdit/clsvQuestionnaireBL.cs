
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaireBL
 表名:vQuestionnaire(01120019)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:31:05
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
public static class  clsvQuestionnaireBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaireEN GetObj(this K_QuestionId_vQuestionnaire myKey)
{
clsvQuestionnaireEN objvQuestionnaireEN = clsvQuestionnaireBL.vQuestionnaireDA.GetObjByQuestionId(myKey.Value);
return objvQuestionnaireEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionId(this clsvQuestionnaireEN objvQuestionnaireEN, long lngQuestionId, string strComparisonOp="")
	{
objvQuestionnaireEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.QuestionId) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.QuestionId, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.QuestionId] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionIndex(this clsvQuestionnaireEN objvQuestionnaireEN, int? intQuestionIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionName(this clsvQuestionnaireEN objvQuestionnaireEN, string strQuestionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionName, 500, convQuestionnaire.QuestionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionContent(this clsvQuestionnaireEN objvQuestionnaireEN, string strQuestionContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, convQuestionnaire.QuestionContent);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionMemo(this clsvQuestionnaireEN objvQuestionnaireEN, string strQuestionMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionMemo, 1000, convQuestionnaire.QuestionMemo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionNo(this clsvQuestionnaireEN objvQuestionnaireEN, string strQuestionNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, convQuestionnaire.QuestionNo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetParentQuestionId(this clsvQuestionnaireEN objvQuestionnaireEN, string strParentQuestionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentQuestionId, 8, convQuestionnaire.ParentQuestionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParentQuestionId, 8, convQuestionnaire.ParentQuestionId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetExamAnswer(this clsvQuestionnaireEN objvQuestionnaireEN, string strExamAnswer, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamAnswer, 8000, convQuestionnaire.ExamAnswer);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetCourseId(this clsvQuestionnaireEN objvQuestionnaireEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convQuestionnaire.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convQuestionnaire.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetCourseCode(this clsvQuestionnaireEN objvQuestionnaireEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convQuestionnaire.CourseCode);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetCourseName(this clsvQuestionnaireEN objvQuestionnaireEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convQuestionnaire.CourseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetLevelNo(this clsvQuestionnaireEN objvQuestionnaireEN, int? intLevelNo, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetCourseChapterId(this clsvQuestionnaireEN objvQuestionnaireEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convQuestionnaire.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convQuestionnaire.CourseChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetCourseChapterName(this clsvQuestionnaireEN objvQuestionnaireEN, string strCourseChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convQuestionnaire.CourseChapterName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetChapterId(this clsvQuestionnaireEN objvQuestionnaireEN, string strChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterId, 8, convQuestionnaire.ChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convQuestionnaire.ChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetSectionId(this clsvQuestionnaireEN objvQuestionnaireEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, convQuestionnaire.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convQuestionnaire.SectionId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetChapterName(this clsvQuestionnaireEN objvQuestionnaireEN, string strChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterName, 100, convQuestionnaire.ChapterName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetSectionName(this clsvQuestionnaireEN objvQuestionnaireEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convQuestionnaire.SectionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetChapterNameSim(this clsvQuestionnaireEN objvQuestionnaireEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, convQuestionnaire.ChapterNameSim);
}
objvQuestionnaireEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.ChapterNameSim) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.ChapterNameSim, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.ChapterNameSim] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetSectionNameSim(this clsvQuestionnaireEN objvQuestionnaireEN, string strSectionNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionNameSim, 10, convQuestionnaire.SectionNameSim);
}
objvQuestionnaireEN.SectionNameSim = strSectionNameSim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.SectionNameSim) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.SectionNameSim, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.SectionNameSim] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetParentNodeId(this clsvQuestionnaireEN objvQuestionnaireEN, string strParentNodeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeId, 8, convQuestionnaire.ParentNodeId);
}
objvQuestionnaireEN.ParentNodeId = strParentNodeId; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.ParentNodeId) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.ParentNodeId, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.ParentNodeId] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetCourseChapterReferred(this clsvQuestionnaireEN objvQuestionnaireEN, string strCourseChapterReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convQuestionnaire.CourseChapterReferred);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetParentNodeName(this clsvQuestionnaireEN objvQuestionnaireEN, string strParentNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeName, 100, convQuestionnaire.ParentNodeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetParentNodeReferred(this clsvQuestionnaireEN objvQuestionnaireEN, string strParentNodeReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convQuestionnaire.ParentNodeReferred);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionTypeId(this clsvQuestionnaireEN objvQuestionnaireEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convQuestionnaire.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convQuestionnaire.QuestionTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionTypeName(this clsvQuestionnaireEN objvQuestionnaireEN, string strQuestionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convQuestionnaire.QuestionTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionTypeId4Course(this clsvQuestionnaireEN objvQuestionnaireEN, string strQuestionTypeId4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeId4Course, convQuestionnaire.QuestionTypeId4Course);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId4Course, 8, convQuestionnaire.QuestionTypeId4Course);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId4Course, 8, convQuestionnaire.QuestionTypeId4Course);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionTypeName4Course(this clsvQuestionnaireEN objvQuestionnaireEN, string strQuestionTypeName4Course, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName4Course, 30, convQuestionnaire.QuestionTypeName4Course);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetAnswerTypeId(this clsvQuestionnaireEN objvQuestionnaireEN, string strAnswerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convQuestionnaire.AnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convQuestionnaire.AnswerTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetAnswerTypeName(this clsvQuestionnaireEN objvQuestionnaireEN, string strAnswerTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeName, 50, convQuestionnaire.AnswerTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetGridTitle(this clsvQuestionnaireEN objvQuestionnaireEN, string strGridTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGridTitle, 30, convQuestionnaire.GridTitle);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetAnswerModeId(this clsvQuestionnaireEN objvQuestionnaireEN, string strAnswerModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convQuestionnaire.AnswerModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convQuestionnaire.AnswerModeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetAnswerModeName(this clsvQuestionnaireEN objvQuestionnaireEN, string strAnswerModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeName, 30, convQuestionnaire.AnswerModeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionScore(this clsvQuestionnaireEN objvQuestionnaireEN, float? fltQuestionScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetDefaultValue(this clsvQuestionnaireEN objvQuestionnaireEN, string strDefaultValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convQuestionnaire.DefaultValue);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetDefaultSelectItem(this clsvQuestionnaireEN objvQuestionnaireEN, string strDefaultSelectItem, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultSelectItem, 20, convQuestionnaire.DefaultSelectItem);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetLikeCount(this clsvQuestionnaireEN objvQuestionnaireEN, long? lngLikeCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetAnswerAttLimitSize(this clsvQuestionnaireEN objvQuestionnaireEN, long? lngAnswerAttLimitSize, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetLimitedResourceType(this clsvQuestionnaireEN objvQuestionnaireEN, string strLimitedResourceType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLimitedResourceType, 100, convQuestionnaire.LimitedResourceType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetExamGradeId(this clsvQuestionnaireEN objvQuestionnaireEN, string strExamGradeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamGradeId, 2, convQuestionnaire.ExamGradeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExamGradeId, 2, convQuestionnaire.ExamGradeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetExamGradeName(this clsvQuestionnaireEN objvQuestionnaireEN, string strExamGradeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamGradeName, 50, convQuestionnaire.ExamGradeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetTextDirectId(this clsvQuestionnaireEN objvQuestionnaireEN, string strTextDirectId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextDirectId, 4, convQuestionnaire.TextDirectId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextDirectId, 4, convQuestionnaire.TextDirectId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetUpdDate(this clsvQuestionnaireEN objvQuestionnaireEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQuestionnaire.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQuestionnaire.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetUpdUser(this clsvQuestionnaireEN objvQuestionnaireEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convQuestionnaire.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQuestionnaire.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetMemo(this clsvQuestionnaireEN objvQuestionnaireEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQuestionnaire.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetCodeTab(this clsvQuestionnaireEN objvQuestionnaireEN, string strCodeTab, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTab, 50, convQuestionnaire.CodeTab);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetCodeTabCode(this clsvQuestionnaireEN objvQuestionnaireEN, string strCodeTabCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabCode, 50, convQuestionnaire.CodeTabCode);
}
objvQuestionnaireEN.CodeTabCode = strCodeTabCode; //CodeTab_Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.CodeTabCode) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.CodeTabCode, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.CodeTabCode] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetCodeTabCondition(this clsvQuestionnaireEN objvQuestionnaireEN, string strCodeTabCondition, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabCondition, 200, convQuestionnaire.CodeTabCondition);
}
objvQuestionnaireEN.CodeTabCondition = strCodeTabCondition; //代码表_条件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.CodeTabCondition) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.CodeTabCondition, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.CodeTabCondition] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetCodeTabName(this clsvQuestionnaireEN objvQuestionnaireEN, string strCodeTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabName, 50, convQuestionnaire.CodeTabName);
}
objvQuestionnaireEN.CodeTabName = strCodeTabName; //CodeTab_Name
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.CodeTabName) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.CodeTabName, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.CodeTabName] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetCourseIdChapter(this clsvQuestionnaireEN objvQuestionnaireEN, string strCourseIdChapter, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseIdChapter, 8, convQuestionnaire.CourseIdChapter);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseIdChapter, 8, convQuestionnaire.CourseIdChapter);
}
objvQuestionnaireEN.CourseIdChapter = strCourseIdChapter; //CourseId_Chapter
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.CourseIdChapter) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.CourseIdChapter, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.CourseIdChapter] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetOptionNum(this clsvQuestionnaireEN objvQuestionnaireEN, int? intOptionNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetChapterOrderNum(this clsvQuestionnaireEN objvQuestionnaireEN, int? intChapterOrderNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionNameAdd(this clsvQuestionnaireEN objvQuestionnaireEN, string strQuestionNameAdd, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionNameAdd, 500, convQuestionnaire.QuestionNameAdd);
}
objvQuestionnaireEN.QuestionNameAdd = strQuestionNameAdd; //题目补充
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireEN.dicFldComparisonOp.ContainsKey(convQuestionnaire.QuestionNameAdd) == false)
{
objvQuestionnaireEN.dicFldComparisonOp.Add(convQuestionnaire.QuestionNameAdd, strComparisonOp);
}
else
{
objvQuestionnaireEN.dicFldComparisonOp[convQuestionnaire.QuestionNameAdd] = strComparisonOp;
}
}
return objvQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetDifficultyLevelId(this clsvQuestionnaireEN objvQuestionnaireEN, string strDifficultyLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDifficultyLevelId, 2, convQuestionnaire.DifficultyLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDifficultyLevelId, 2, convQuestionnaire.DifficultyLevelId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetFillInTextHeight(this clsvQuestionnaireEN objvQuestionnaireEN, int? intFillInTextHeight, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetFillInTextWidth(this clsvQuestionnaireEN objvQuestionnaireEN, int? intFillInTextWidth, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetKnowledgeGraphId(this clsvQuestionnaireEN objvQuestionnaireEN, string strKnowledgeGraphId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeGraphId, 10, convQuestionnaire.KnowledgeGraphId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strKnowledgeGraphId, 10, convQuestionnaire.KnowledgeGraphId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetMemoTextWidth(this clsvQuestionnaireEN objvQuestionnaireEN, int? intMemoTextWidth, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetQuestionCode(this clsvQuestionnaireEN objvQuestionnaireEN, string strQuestionCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionCode, 8000, convQuestionnaire.QuestionCode);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetSectionTypeId(this clsvQuestionnaireEN objvQuestionnaireEN, string strSectionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionTypeId, 8, convQuestionnaire.SectionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionTypeId, 8, convQuestionnaire.SectionTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetCheckBoxLimitCount(this clsvQuestionnaireEN objvQuestionnaireEN, int? intCheckBoxLimitCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireEN SetRelaEvent(this clsvQuestionnaireEN objvQuestionnaireEN, string strRelaEvent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaEvent, 4000, convQuestionnaire.RelaEvent);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQuestionnaireENS">源对象</param>
 /// <param name = "objvQuestionnaireENT">目标对象</param>
 public static void CopyTo(this clsvQuestionnaireEN objvQuestionnaireENS, clsvQuestionnaireEN objvQuestionnaireENT)
{
try
{
objvQuestionnaireENT.QuestionId = objvQuestionnaireENS.QuestionId; //题目Id
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
objvQuestionnaireENT.ChapterNameSim = objvQuestionnaireENS.ChapterNameSim; //章名简称
objvQuestionnaireENT.SectionNameSim = objvQuestionnaireENS.SectionNameSim; //节名简称
objvQuestionnaireENT.ParentNodeId = objvQuestionnaireENS.ParentNodeId; //父节点编号
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
objvQuestionnaireENT.CodeTabCode = objvQuestionnaireENS.CodeTabCode; //CodeTab_Code
objvQuestionnaireENT.CodeTabCondition = objvQuestionnaireENS.CodeTabCondition; //代码表_条件
objvQuestionnaireENT.CodeTabName = objvQuestionnaireENS.CodeTabName; //CodeTab_Name
objvQuestionnaireENT.CourseIdChapter = objvQuestionnaireENS.CourseIdChapter; //CourseId_Chapter
objvQuestionnaireENT.OptionNum = objvQuestionnaireENS.OptionNum; //选项数
objvQuestionnaireENT.ChapterOrderNum = objvQuestionnaireENS.ChapterOrderNum; //章排序号
objvQuestionnaireENT.QuestionNameAdd = objvQuestionnaireENS.QuestionNameAdd; //题目补充
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
 /// <param name = "objvQuestionnaireENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionnaireEN:objvQuestionnaireENT</returns>
 public static clsvQuestionnaireEN CopyTo(this clsvQuestionnaireEN objvQuestionnaireENS)
{
try
{
 clsvQuestionnaireEN objvQuestionnaireENT = new clsvQuestionnaireEN()
{
QuestionId = objvQuestionnaireENS.QuestionId, //题目Id
QuestionIndex = objvQuestionnaireENS.QuestionIndex, //题目序号
QuestionName = objvQuestionnaireENS.QuestionName, //题目名称
QuestionContent = objvQuestionnaireENS.QuestionContent, //题目内容
QuestionMemo = objvQuestionnaireENS.QuestionMemo, //题目说明
QuestionNo = objvQuestionnaireENS.QuestionNo, //题目编号
ParentQuestionId = objvQuestionnaireENS.ParentQuestionId, //父题目Id
ExamAnswer = objvQuestionnaireENS.ExamAnswer, //题目答案
CourseId = objvQuestionnaireENS.CourseId, //课程Id
CourseCode = objvQuestionnaireENS.CourseCode, //课程代码
CourseName = objvQuestionnaireENS.CourseName, //课程名称
LevelNo = objvQuestionnaireENS.LevelNo, //学习关号2
CourseChapterId = objvQuestionnaireENS.CourseChapterId, //课程章节ID
CourseChapterName = objvQuestionnaireENS.CourseChapterName, //课程章节名称
ChapterId = objvQuestionnaireENS.ChapterId, //章Id
SectionId = objvQuestionnaireENS.SectionId, //节Id
ChapterName = objvQuestionnaireENS.ChapterName, //章名
SectionName = objvQuestionnaireENS.SectionName, //节名
ChapterNameSim = objvQuestionnaireENS.ChapterNameSim, //章名简称
SectionNameSim = objvQuestionnaireENS.SectionNameSim, //节名简称
ParentNodeId = objvQuestionnaireENS.ParentNodeId, //父节点编号
CourseChapterReferred = objvQuestionnaireENS.CourseChapterReferred, //节简称
ParentNodeName = objvQuestionnaireENS.ParentNodeName, //父节点名称
ParentNodeReferred = objvQuestionnaireENS.ParentNodeReferred, //章简称
QuestionTypeId = objvQuestionnaireENS.QuestionTypeId, //题目类型Id
QuestionTypeName = objvQuestionnaireENS.QuestionTypeName, //题目类型名
QuestionTypeId4Course = objvQuestionnaireENS.QuestionTypeId4Course, //题目类型Id4课程
QuestionTypeName4Course = objvQuestionnaireENS.QuestionTypeName4Course, //题目类型名4课程
AnswerTypeId = objvQuestionnaireENS.AnswerTypeId, //答案类型ID
AnswerTypeName = objvQuestionnaireENS.AnswerTypeName, //答案类型名
GridTitle = objvQuestionnaireENS.GridTitle, //表格标题
AnswerModeId = objvQuestionnaireENS.AnswerModeId, //答案模式Id
AnswerModeName = objvQuestionnaireENS.AnswerModeName, //答案模式名称
QuestionScore = objvQuestionnaireENS.QuestionScore, //题目得分
DefaultValue = objvQuestionnaireENS.DefaultValue, //缺省值
DefaultSelectItem = objvQuestionnaireENS.DefaultSelectItem, //默认选项
IsShow = objvQuestionnaireENS.IsShow, //是否启用
IsCast = objvQuestionnaireENS.IsCast, //是否播放
LikeCount = objvQuestionnaireENS.LikeCount, //资源喜欢数量
AnswerAttLimitSize = objvQuestionnaireENS.AnswerAttLimitSize, //回答附件限制大小
LimitedResourceType = objvQuestionnaireENS.LimitedResourceType, //限制资源类型
IsEffective = objvQuestionnaireENS.IsEffective, //是否有效
IsCanInPaper = objvQuestionnaireENS.IsCanInPaper, //是否可在Paper
ExamGradeId = objvQuestionnaireENS.ExamGradeId, //题库等级ID
ExamGradeName = objvQuestionnaireENS.ExamGradeName, //题库等级名
TextDirectId = objvQuestionnaireENS.TextDirectId, //文本方向ID
UpdDate = objvQuestionnaireENS.UpdDate, //修改日期
UpdUser = objvQuestionnaireENS.UpdUser, //修改人
Memo = objvQuestionnaireENS.Memo, //备注
FirstIndent = objvQuestionnaireENS.FirstIndent, //首行缩进
CodeTab = objvQuestionnaireENS.CodeTab, //代码表
CodeTabCode = objvQuestionnaireENS.CodeTabCode, //CodeTab_Code
CodeTabCondition = objvQuestionnaireENS.CodeTabCondition, //代码表_条件
CodeTabName = objvQuestionnaireENS.CodeTabName, //CodeTab_Name
CourseIdChapter = objvQuestionnaireENS.CourseIdChapter, //CourseId_Chapter
OptionNum = objvQuestionnaireENS.OptionNum, //选项数
ChapterOrderNum = objvQuestionnaireENS.ChapterOrderNum, //章排序号
QuestionNameAdd = objvQuestionnaireENS.QuestionNameAdd, //题目补充
DifficultyLevelId = objvQuestionnaireENS.DifficultyLevelId, //难度等级Id
FillInTextHeight = objvQuestionnaireENS.FillInTextHeight, //填空框高度
FillInTextWidth = objvQuestionnaireENS.FillInTextWidth, //填空框宽度
IsHaveAdditionalMemo = objvQuestionnaireENS.IsHaveAdditionalMemo, //是否有附加说明
IsJs = objvQuestionnaireENS.IsJs, //是否是JS
IsMulti4FillInText = objvQuestionnaireENS.IsMulti4FillInText, //是否填空框多行
KnowledgeGraphId = objvQuestionnaireENS.KnowledgeGraphId, //知识点图Id
MemoTextWidth = objvQuestionnaireENS.MemoTextWidth, //备注框宽度
QuestionCode = objvQuestionnaireENS.QuestionCode, //html代码
SectionTypeId = objvQuestionnaireENS.SectionTypeId, //节点类型Id
CheckBoxLimitCount = objvQuestionnaireENS.CheckBoxLimitCount, //复选框限制数
RelaEvent = objvQuestionnaireENS.RelaEvent, //相关事件
};
 return objvQuestionnaireENT;
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
public static void CheckProperty4Condition(this clsvQuestionnaireEN objvQuestionnaireEN)
{
 clsvQuestionnaireBL.vQuestionnaireDA.CheckProperty4Condition(objvQuestionnaireEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionnaireEN objvQuestionnaireCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.QuestionId) == true)
{
string strComparisonOpQuestionId = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire.QuestionId, objvQuestionnaireCond.QuestionId, strComparisonOpQuestionId);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.QuestionIndex) == true)
{
string strComparisonOpQuestionIndex = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire.QuestionIndex, objvQuestionnaireCond.QuestionIndex, strComparisonOpQuestionIndex);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.QuestionName) == true)
{
string strComparisonOpQuestionName = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.QuestionName, objvQuestionnaireCond.QuestionName, strComparisonOpQuestionName);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.QuestionContent) == true)
{
string strComparisonOpQuestionContent = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.QuestionContent, objvQuestionnaireCond.QuestionContent, strComparisonOpQuestionContent);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.QuestionMemo) == true)
{
string strComparisonOpQuestionMemo = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.QuestionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.QuestionMemo, objvQuestionnaireCond.QuestionMemo, strComparisonOpQuestionMemo);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.QuestionNo) == true)
{
string strComparisonOpQuestionNo = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.QuestionNo, objvQuestionnaireCond.QuestionNo, strComparisonOpQuestionNo);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.ParentQuestionId) == true)
{
string strComparisonOpParentQuestionId = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.ParentQuestionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.ParentQuestionId, objvQuestionnaireCond.ParentQuestionId, strComparisonOpParentQuestionId);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.ExamAnswer) == true)
{
string strComparisonOpExamAnswer = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.ExamAnswer];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.ExamAnswer, objvQuestionnaireCond.ExamAnswer, strComparisonOpExamAnswer);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.CourseId) == true)
{
string strComparisonOpCourseId = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.CourseId, objvQuestionnaireCond.CourseId, strComparisonOpCourseId);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.CourseCode) == true)
{
string strComparisonOpCourseCode = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.CourseCode, objvQuestionnaireCond.CourseCode, strComparisonOpCourseCode);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.CourseName) == true)
{
string strComparisonOpCourseName = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.CourseName, objvQuestionnaireCond.CourseName, strComparisonOpCourseName);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.LevelNo) == true)
{
string strComparisonOpLevelNo = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.LevelNo];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire.LevelNo, objvQuestionnaireCond.LevelNo, strComparisonOpLevelNo);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.CourseChapterId, objvQuestionnaireCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.CourseChapterName, objvQuestionnaireCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.ChapterId) == true)
{
string strComparisonOpChapterId = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.ChapterId, objvQuestionnaireCond.ChapterId, strComparisonOpChapterId);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.SectionId) == true)
{
string strComparisonOpSectionId = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.SectionId, objvQuestionnaireCond.SectionId, strComparisonOpSectionId);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.ChapterName) == true)
{
string strComparisonOpChapterName = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.ChapterName, objvQuestionnaireCond.ChapterName, strComparisonOpChapterName);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.SectionName) == true)
{
string strComparisonOpSectionName = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.SectionName, objvQuestionnaireCond.SectionName, strComparisonOpSectionName);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.ChapterNameSim, objvQuestionnaireCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.SectionNameSim) == true)
{
string strComparisonOpSectionNameSim = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.SectionNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.SectionNameSim, objvQuestionnaireCond.SectionNameSim, strComparisonOpSectionNameSim);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.ParentNodeId) == true)
{
string strComparisonOpParentNodeId = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.ParentNodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.ParentNodeId, objvQuestionnaireCond.ParentNodeId, strComparisonOpParentNodeId);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.CourseChapterReferred) == true)
{
string strComparisonOpCourseChapterReferred = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.CourseChapterReferred, objvQuestionnaireCond.CourseChapterReferred, strComparisonOpCourseChapterReferred);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.ParentNodeName) == true)
{
string strComparisonOpParentNodeName = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.ParentNodeName, objvQuestionnaireCond.ParentNodeName, strComparisonOpParentNodeName);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.ParentNodeReferred) == true)
{
string strComparisonOpParentNodeReferred = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.ParentNodeReferred, objvQuestionnaireCond.ParentNodeReferred, strComparisonOpParentNodeReferred);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.QuestionTypeId, objvQuestionnaireCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.QuestionTypeName) == true)
{
string strComparisonOpQuestionTypeName = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.QuestionTypeName, objvQuestionnaireCond.QuestionTypeName, strComparisonOpQuestionTypeName);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.QuestionTypeId4Course) == true)
{
string strComparisonOpQuestionTypeId4Course = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.QuestionTypeId4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.QuestionTypeId4Course, objvQuestionnaireCond.QuestionTypeId4Course, strComparisonOpQuestionTypeId4Course);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.QuestionTypeName4Course) == true)
{
string strComparisonOpQuestionTypeName4Course = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.QuestionTypeName4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.QuestionTypeName4Course, objvQuestionnaireCond.QuestionTypeName4Course, strComparisonOpQuestionTypeName4Course);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.AnswerTypeId) == true)
{
string strComparisonOpAnswerTypeId = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.AnswerTypeId, objvQuestionnaireCond.AnswerTypeId, strComparisonOpAnswerTypeId);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.AnswerTypeName) == true)
{
string strComparisonOpAnswerTypeName = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.AnswerTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.AnswerTypeName, objvQuestionnaireCond.AnswerTypeName, strComparisonOpAnswerTypeName);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.GridTitle) == true)
{
string strComparisonOpGridTitle = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.GridTitle, objvQuestionnaireCond.GridTitle, strComparisonOpGridTitle);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.AnswerModeId) == true)
{
string strComparisonOpAnswerModeId = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.AnswerModeId, objvQuestionnaireCond.AnswerModeId, strComparisonOpAnswerModeId);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.AnswerModeName) == true)
{
string strComparisonOpAnswerModeName = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.AnswerModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.AnswerModeName, objvQuestionnaireCond.AnswerModeName, strComparisonOpAnswerModeName);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.QuestionScore) == true)
{
string strComparisonOpQuestionScore = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.QuestionScore];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire.QuestionScore, objvQuestionnaireCond.QuestionScore, strComparisonOpQuestionScore);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.DefaultValue, objvQuestionnaireCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.DefaultSelectItem) == true)
{
string strComparisonOpDefaultSelectItem = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.DefaultSelectItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.DefaultSelectItem, objvQuestionnaireCond.DefaultSelectItem, strComparisonOpDefaultSelectItem);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.IsShow) == true)
{
if (objvQuestionnaireCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire.IsShow);
}
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.IsCast) == true)
{
if (objvQuestionnaireCond.IsCast == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire.IsCast);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire.IsCast);
}
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.LikeCount) == true)
{
string strComparisonOpLikeCount = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire.LikeCount, objvQuestionnaireCond.LikeCount, strComparisonOpLikeCount);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.AnswerAttLimitSize) == true)
{
string strComparisonOpAnswerAttLimitSize = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.AnswerAttLimitSize];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire.AnswerAttLimitSize, objvQuestionnaireCond.AnswerAttLimitSize, strComparisonOpAnswerAttLimitSize);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.LimitedResourceType) == true)
{
string strComparisonOpLimitedResourceType = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.LimitedResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.LimitedResourceType, objvQuestionnaireCond.LimitedResourceType, strComparisonOpLimitedResourceType);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.IsEffective) == true)
{
if (objvQuestionnaireCond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire.IsEffective);
}
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.IsCanInPaper) == true)
{
if (objvQuestionnaireCond.IsCanInPaper == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire.IsCanInPaper);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire.IsCanInPaper);
}
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.ExamGradeId) == true)
{
string strComparisonOpExamGradeId = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.ExamGradeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.ExamGradeId, objvQuestionnaireCond.ExamGradeId, strComparisonOpExamGradeId);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.ExamGradeName) == true)
{
string strComparisonOpExamGradeName = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.ExamGradeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.ExamGradeName, objvQuestionnaireCond.ExamGradeName, strComparisonOpExamGradeName);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.TextDirectId) == true)
{
string strComparisonOpTextDirectId = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.TextDirectId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.TextDirectId, objvQuestionnaireCond.TextDirectId, strComparisonOpTextDirectId);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.UpdDate, objvQuestionnaireCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.UpdUser) == true)
{
string strComparisonOpUpdUser = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.UpdUser, objvQuestionnaireCond.UpdUser, strComparisonOpUpdUser);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.Memo) == true)
{
string strComparisonOpMemo = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.Memo, objvQuestionnaireCond.Memo, strComparisonOpMemo);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.FirstIndent) == true)
{
if (objvQuestionnaireCond.FirstIndent == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire.FirstIndent);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire.FirstIndent);
}
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.CodeTab) == true)
{
string strComparisonOpCodeTab = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.CodeTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.CodeTab, objvQuestionnaireCond.CodeTab, strComparisonOpCodeTab);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.CodeTabCode) == true)
{
string strComparisonOpCodeTabCode = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.CodeTabCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.CodeTabCode, objvQuestionnaireCond.CodeTabCode, strComparisonOpCodeTabCode);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.CodeTabCondition) == true)
{
string strComparisonOpCodeTabCondition = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.CodeTabCondition];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.CodeTabCondition, objvQuestionnaireCond.CodeTabCondition, strComparisonOpCodeTabCondition);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.CodeTabName) == true)
{
string strComparisonOpCodeTabName = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.CodeTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.CodeTabName, objvQuestionnaireCond.CodeTabName, strComparisonOpCodeTabName);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.CourseIdChapter) == true)
{
string strComparisonOpCourseIdChapter = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.CourseIdChapter];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.CourseIdChapter, objvQuestionnaireCond.CourseIdChapter, strComparisonOpCourseIdChapter);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.OptionNum) == true)
{
string strComparisonOpOptionNum = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.OptionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire.OptionNum, objvQuestionnaireCond.OptionNum, strComparisonOpOptionNum);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.ChapterOrderNum) == true)
{
string strComparisonOpChapterOrderNum = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.ChapterOrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire.ChapterOrderNum, objvQuestionnaireCond.ChapterOrderNum, strComparisonOpChapterOrderNum);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.QuestionNameAdd) == true)
{
string strComparisonOpQuestionNameAdd = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.QuestionNameAdd];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.QuestionNameAdd, objvQuestionnaireCond.QuestionNameAdd, strComparisonOpQuestionNameAdd);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.DifficultyLevelId) == true)
{
string strComparisonOpDifficultyLevelId = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.DifficultyLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.DifficultyLevelId, objvQuestionnaireCond.DifficultyLevelId, strComparisonOpDifficultyLevelId);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.FillInTextHeight) == true)
{
string strComparisonOpFillInTextHeight = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.FillInTextHeight];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire.FillInTextHeight, objvQuestionnaireCond.FillInTextHeight, strComparisonOpFillInTextHeight);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.FillInTextWidth) == true)
{
string strComparisonOpFillInTextWidth = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.FillInTextWidth];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire.FillInTextWidth, objvQuestionnaireCond.FillInTextWidth, strComparisonOpFillInTextWidth);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.IsHaveAdditionalMemo) == true)
{
if (objvQuestionnaireCond.IsHaveAdditionalMemo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire.IsHaveAdditionalMemo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire.IsHaveAdditionalMemo);
}
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.IsJs) == true)
{
if (objvQuestionnaireCond.IsJs == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire.IsJs);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire.IsJs);
}
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.IsMulti4FillInText) == true)
{
if (objvQuestionnaireCond.IsMulti4FillInText == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire.IsMulti4FillInText);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire.IsMulti4FillInText);
}
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.KnowledgeGraphId) == true)
{
string strComparisonOpKnowledgeGraphId = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.KnowledgeGraphId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.KnowledgeGraphId, objvQuestionnaireCond.KnowledgeGraphId, strComparisonOpKnowledgeGraphId);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.MemoTextWidth) == true)
{
string strComparisonOpMemoTextWidth = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.MemoTextWidth];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire.MemoTextWidth, objvQuestionnaireCond.MemoTextWidth, strComparisonOpMemoTextWidth);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.QuestionCode) == true)
{
string strComparisonOpQuestionCode = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.QuestionCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.QuestionCode, objvQuestionnaireCond.QuestionCode, strComparisonOpQuestionCode);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.SectionTypeId) == true)
{
string strComparisonOpSectionTypeId = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.SectionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.SectionTypeId, objvQuestionnaireCond.SectionTypeId, strComparisonOpSectionTypeId);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.CheckBoxLimitCount) == true)
{
string strComparisonOpCheckBoxLimitCount = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.CheckBoxLimitCount];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire.CheckBoxLimitCount, objvQuestionnaireCond.CheckBoxLimitCount, strComparisonOpCheckBoxLimitCount);
}
if (objvQuestionnaireCond.IsUpdated(convQuestionnaire.RelaEvent) == true)
{
string strComparisonOpRelaEvent = objvQuestionnaireCond.dicFldComparisonOp[convQuestionnaire.RelaEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire.RelaEvent, objvQuestionnaireCond.RelaEvent, strComparisonOpRelaEvent);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQuestionnaire
{
public virtual bool UpdRelaTabDate(long lngQuestionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v题目(vQuestionnaire)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionnaireBL
{
public static RelatedActions_vQuestionnaire relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQuestionnaireDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQuestionnaireDA vQuestionnaireDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQuestionnaireDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQuestionnaireBL()
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
if (string.IsNullOrEmpty(clsvQuestionnaireEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQuestionnaireEN._ConnectString);
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
public static DataTable GetDataTable_vQuestionnaire(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQuestionnaireDA.GetDataTable_vQuestionnaire(strWhereCond);
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
objDT = vQuestionnaireDA.GetDataTable(strWhereCond);
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
objDT = vQuestionnaireDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQuestionnaireDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQuestionnaireDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQuestionnaireDA.GetDataTable_Top(objTopPara);
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
objDT = vQuestionnaireDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQuestionnaireDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQuestionnaireDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvQuestionnaireEN> GetObjLstByQuestionIdLst(List<long> arrQuestionIdLst)
{
List<clsvQuestionnaireEN> arrObjLst = new List<clsvQuestionnaireEN>(); 
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
	clsvQuestionnaireEN objvQuestionnaireEN = new clsvQuestionnaireEN();
try
{
objvQuestionnaireEN.QuestionId = Int32.Parse(objRow[convQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaireEN.QuestionIndex = objRow[convQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaireEN.QuestionName = objRow[convQuestionnaire.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaireEN.QuestionContent = objRow[convQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaireEN.QuestionMemo = objRow[convQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaireEN.QuestionNo = objRow[convQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaireEN.ParentQuestionId = objRow[convQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaireEN.ExamAnswer = objRow[convQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaireEN.CourseId = objRow[convQuestionnaire.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireEN.CourseCode = objRow[convQuestionnaire.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaireEN.CourseName = objRow[convQuestionnaire.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseName].ToString().Trim(); //课程名称
objvQuestionnaireEN.LevelNo = objRow[convQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objvQuestionnaireEN.CourseChapterId = objRow[convQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaireEN.CourseChapterName = objRow[convQuestionnaire.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaireEN.ChapterId = objRow[convQuestionnaire.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterId].ToString().Trim(); //章Id
objvQuestionnaireEN.SectionId = objRow[convQuestionnaire.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionId].ToString().Trim(); //节Id
objvQuestionnaireEN.ChapterName = objRow[convQuestionnaire.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterName].ToString().Trim(); //章名
objvQuestionnaireEN.SectionName = objRow[convQuestionnaire.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire.SectionName].ToString().Trim(); //节名
objvQuestionnaireEN.ChapterNameSim = objRow[convQuestionnaire.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaireEN.SectionNameSim = objRow[convQuestionnaire.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaireEN.ParentNodeId = objRow[convQuestionnaire.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaireEN.CourseChapterReferred = objRow[convQuestionnaire.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaireEN.ParentNodeName = objRow[convQuestionnaire.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaireEN.ParentNodeReferred = objRow[convQuestionnaire.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaireEN.QuestionTypeId = objRow[convQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireEN.QuestionTypeName = objRow[convQuestionnaire.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireEN.QuestionTypeId4Course = objRow[convQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaireEN.QuestionTypeName4Course = objRow[convQuestionnaire.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionnaireEN.AnswerTypeId = objRow[convQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaireEN.AnswerTypeName = objRow[convQuestionnaire.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaireEN.GridTitle = objRow[convQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaireEN.AnswerModeId = objRow[convQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaireEN.AnswerModeName = objRow[convQuestionnaire.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaireEN.QuestionScore = objRow[convQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaireEN.DefaultValue = objRow[convQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaireEN.DefaultSelectItem = objRow[convQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaireEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsShow].ToString().Trim()); //是否启用
objvQuestionnaireEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsCast].ToString().Trim()); //是否播放
objvQuestionnaireEN.LikeCount = objRow[convQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaireEN.AnswerAttLimitSize = objRow[convQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvQuestionnaireEN.LimitedResourceType = objRow[convQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[convQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objvQuestionnaireEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaireEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaireEN.ExamGradeId = objRow[convQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaireEN.ExamGradeName = objRow[convQuestionnaire.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaireEN.TextDirectId = objRow[convQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaireEN.UpdDate = objRow[convQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaireEN.UpdUser = objRow[convQuestionnaire.UpdUser].ToString().Trim(); //修改人
objvQuestionnaireEN.Memo = objRow[convQuestionnaire.Memo] == DBNull.Value ? null : objRow[convQuestionnaire.Memo].ToString().Trim(); //备注
objvQuestionnaireEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaireEN.CodeTab = objRow[convQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTab].ToString().Trim(); //代码表
objvQuestionnaireEN.CodeTabCode = objRow[convQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaireEN.CodeTabCondition = objRow[convQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaireEN.CodeTabName = objRow[convQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaireEN.CourseIdChapter = objRow[convQuestionnaire.CourseIdChapter] == DBNull.Value ? null : objRow[convQuestionnaire.CourseIdChapter].ToString().Trim(); //CourseId_Chapter
objvQuestionnaireEN.OptionNum = objRow[convQuestionnaire.OptionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.OptionNum].ToString().Trim()); //选项数
objvQuestionnaireEN.ChapterOrderNum = objRow[convQuestionnaire.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaireEN.QuestionNameAdd = objRow[convQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaireEN.DifficultyLevelId = objRow[convQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objvQuestionnaireEN.FillInTextHeight = objRow[convQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaireEN.FillInTextWidth = objRow[convQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaireEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaireEN.IsJs = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objvQuestionnaireEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaireEN.KnowledgeGraphId = objRow[convQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[convQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvQuestionnaireEN.MemoTextWidth = objRow[convQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaireEN.QuestionCode = objRow[convQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objvQuestionnaireEN.SectionTypeId = objRow[convQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objvQuestionnaireEN.CheckBoxLimitCount = objRow[convQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaireEN.RelaEvent = objRow[convQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrQuestionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQuestionnaireEN> GetObjLstByQuestionIdLstCache(List<long> arrQuestionIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvQuestionnaireEN._CurrTabName, strCourseId);
List<clsvQuestionnaireEN> arrvQuestionnaireObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionnaireEN> arrvQuestionnaireObjLst_Sel =
arrvQuestionnaireObjLstCache
.Where(x => arrQuestionIdLst.Contains(x.QuestionId));
return arrvQuestionnaireObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaireEN> GetObjLst(string strWhereCond)
{
List<clsvQuestionnaireEN> arrObjLst = new List<clsvQuestionnaireEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireEN objvQuestionnaireEN = new clsvQuestionnaireEN();
try
{
objvQuestionnaireEN.QuestionId = Int32.Parse(objRow[convQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaireEN.QuestionIndex = objRow[convQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaireEN.QuestionName = objRow[convQuestionnaire.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaireEN.QuestionContent = objRow[convQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaireEN.QuestionMemo = objRow[convQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaireEN.QuestionNo = objRow[convQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaireEN.ParentQuestionId = objRow[convQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaireEN.ExamAnswer = objRow[convQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaireEN.CourseId = objRow[convQuestionnaire.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireEN.CourseCode = objRow[convQuestionnaire.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaireEN.CourseName = objRow[convQuestionnaire.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseName].ToString().Trim(); //课程名称
objvQuestionnaireEN.LevelNo = objRow[convQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objvQuestionnaireEN.CourseChapterId = objRow[convQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaireEN.CourseChapterName = objRow[convQuestionnaire.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaireEN.ChapterId = objRow[convQuestionnaire.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterId].ToString().Trim(); //章Id
objvQuestionnaireEN.SectionId = objRow[convQuestionnaire.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionId].ToString().Trim(); //节Id
objvQuestionnaireEN.ChapterName = objRow[convQuestionnaire.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterName].ToString().Trim(); //章名
objvQuestionnaireEN.SectionName = objRow[convQuestionnaire.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire.SectionName].ToString().Trim(); //节名
objvQuestionnaireEN.ChapterNameSim = objRow[convQuestionnaire.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaireEN.SectionNameSim = objRow[convQuestionnaire.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaireEN.ParentNodeId = objRow[convQuestionnaire.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaireEN.CourseChapterReferred = objRow[convQuestionnaire.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaireEN.ParentNodeName = objRow[convQuestionnaire.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaireEN.ParentNodeReferred = objRow[convQuestionnaire.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaireEN.QuestionTypeId = objRow[convQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireEN.QuestionTypeName = objRow[convQuestionnaire.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireEN.QuestionTypeId4Course = objRow[convQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaireEN.QuestionTypeName4Course = objRow[convQuestionnaire.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionnaireEN.AnswerTypeId = objRow[convQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaireEN.AnswerTypeName = objRow[convQuestionnaire.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaireEN.GridTitle = objRow[convQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaireEN.AnswerModeId = objRow[convQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaireEN.AnswerModeName = objRow[convQuestionnaire.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaireEN.QuestionScore = objRow[convQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaireEN.DefaultValue = objRow[convQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaireEN.DefaultSelectItem = objRow[convQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaireEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsShow].ToString().Trim()); //是否启用
objvQuestionnaireEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsCast].ToString().Trim()); //是否播放
objvQuestionnaireEN.LikeCount = objRow[convQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaireEN.AnswerAttLimitSize = objRow[convQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvQuestionnaireEN.LimitedResourceType = objRow[convQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[convQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objvQuestionnaireEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaireEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaireEN.ExamGradeId = objRow[convQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaireEN.ExamGradeName = objRow[convQuestionnaire.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaireEN.TextDirectId = objRow[convQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaireEN.UpdDate = objRow[convQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaireEN.UpdUser = objRow[convQuestionnaire.UpdUser].ToString().Trim(); //修改人
objvQuestionnaireEN.Memo = objRow[convQuestionnaire.Memo] == DBNull.Value ? null : objRow[convQuestionnaire.Memo].ToString().Trim(); //备注
objvQuestionnaireEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaireEN.CodeTab = objRow[convQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTab].ToString().Trim(); //代码表
objvQuestionnaireEN.CodeTabCode = objRow[convQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaireEN.CodeTabCondition = objRow[convQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaireEN.CodeTabName = objRow[convQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaireEN.CourseIdChapter = objRow[convQuestionnaire.CourseIdChapter] == DBNull.Value ? null : objRow[convQuestionnaire.CourseIdChapter].ToString().Trim(); //CourseId_Chapter
objvQuestionnaireEN.OptionNum = objRow[convQuestionnaire.OptionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.OptionNum].ToString().Trim()); //选项数
objvQuestionnaireEN.ChapterOrderNum = objRow[convQuestionnaire.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaireEN.QuestionNameAdd = objRow[convQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaireEN.DifficultyLevelId = objRow[convQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objvQuestionnaireEN.FillInTextHeight = objRow[convQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaireEN.FillInTextWidth = objRow[convQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaireEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaireEN.IsJs = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objvQuestionnaireEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaireEN.KnowledgeGraphId = objRow[convQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[convQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvQuestionnaireEN.MemoTextWidth = objRow[convQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaireEN.QuestionCode = objRow[convQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objvQuestionnaireEN.SectionTypeId = objRow[convQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objvQuestionnaireEN.CheckBoxLimitCount = objRow[convQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaireEN.RelaEvent = objRow[convQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireEN);
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
public static List<clsvQuestionnaireEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionnaireEN> arrObjLst = new List<clsvQuestionnaireEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireEN objvQuestionnaireEN = new clsvQuestionnaireEN();
try
{
objvQuestionnaireEN.QuestionId = Int32.Parse(objRow[convQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaireEN.QuestionIndex = objRow[convQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaireEN.QuestionName = objRow[convQuestionnaire.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaireEN.QuestionContent = objRow[convQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaireEN.QuestionMemo = objRow[convQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaireEN.QuestionNo = objRow[convQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaireEN.ParentQuestionId = objRow[convQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaireEN.ExamAnswer = objRow[convQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaireEN.CourseId = objRow[convQuestionnaire.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireEN.CourseCode = objRow[convQuestionnaire.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaireEN.CourseName = objRow[convQuestionnaire.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseName].ToString().Trim(); //课程名称
objvQuestionnaireEN.LevelNo = objRow[convQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objvQuestionnaireEN.CourseChapterId = objRow[convQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaireEN.CourseChapterName = objRow[convQuestionnaire.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaireEN.ChapterId = objRow[convQuestionnaire.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterId].ToString().Trim(); //章Id
objvQuestionnaireEN.SectionId = objRow[convQuestionnaire.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionId].ToString().Trim(); //节Id
objvQuestionnaireEN.ChapterName = objRow[convQuestionnaire.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterName].ToString().Trim(); //章名
objvQuestionnaireEN.SectionName = objRow[convQuestionnaire.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire.SectionName].ToString().Trim(); //节名
objvQuestionnaireEN.ChapterNameSim = objRow[convQuestionnaire.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaireEN.SectionNameSim = objRow[convQuestionnaire.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaireEN.ParentNodeId = objRow[convQuestionnaire.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaireEN.CourseChapterReferred = objRow[convQuestionnaire.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaireEN.ParentNodeName = objRow[convQuestionnaire.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaireEN.ParentNodeReferred = objRow[convQuestionnaire.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaireEN.QuestionTypeId = objRow[convQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireEN.QuestionTypeName = objRow[convQuestionnaire.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireEN.QuestionTypeId4Course = objRow[convQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaireEN.QuestionTypeName4Course = objRow[convQuestionnaire.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionnaireEN.AnswerTypeId = objRow[convQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaireEN.AnswerTypeName = objRow[convQuestionnaire.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaireEN.GridTitle = objRow[convQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaireEN.AnswerModeId = objRow[convQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaireEN.AnswerModeName = objRow[convQuestionnaire.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaireEN.QuestionScore = objRow[convQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaireEN.DefaultValue = objRow[convQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaireEN.DefaultSelectItem = objRow[convQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaireEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsShow].ToString().Trim()); //是否启用
objvQuestionnaireEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsCast].ToString().Trim()); //是否播放
objvQuestionnaireEN.LikeCount = objRow[convQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaireEN.AnswerAttLimitSize = objRow[convQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvQuestionnaireEN.LimitedResourceType = objRow[convQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[convQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objvQuestionnaireEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaireEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaireEN.ExamGradeId = objRow[convQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaireEN.ExamGradeName = objRow[convQuestionnaire.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaireEN.TextDirectId = objRow[convQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaireEN.UpdDate = objRow[convQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaireEN.UpdUser = objRow[convQuestionnaire.UpdUser].ToString().Trim(); //修改人
objvQuestionnaireEN.Memo = objRow[convQuestionnaire.Memo] == DBNull.Value ? null : objRow[convQuestionnaire.Memo].ToString().Trim(); //备注
objvQuestionnaireEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaireEN.CodeTab = objRow[convQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTab].ToString().Trim(); //代码表
objvQuestionnaireEN.CodeTabCode = objRow[convQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaireEN.CodeTabCondition = objRow[convQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaireEN.CodeTabName = objRow[convQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaireEN.CourseIdChapter = objRow[convQuestionnaire.CourseIdChapter] == DBNull.Value ? null : objRow[convQuestionnaire.CourseIdChapter].ToString().Trim(); //CourseId_Chapter
objvQuestionnaireEN.OptionNum = objRow[convQuestionnaire.OptionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.OptionNum].ToString().Trim()); //选项数
objvQuestionnaireEN.ChapterOrderNum = objRow[convQuestionnaire.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaireEN.QuestionNameAdd = objRow[convQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaireEN.DifficultyLevelId = objRow[convQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objvQuestionnaireEN.FillInTextHeight = objRow[convQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaireEN.FillInTextWidth = objRow[convQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaireEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaireEN.IsJs = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objvQuestionnaireEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaireEN.KnowledgeGraphId = objRow[convQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[convQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvQuestionnaireEN.MemoTextWidth = objRow[convQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaireEN.QuestionCode = objRow[convQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objvQuestionnaireEN.SectionTypeId = objRow[convQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objvQuestionnaireEN.CheckBoxLimitCount = objRow[convQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaireEN.RelaEvent = objRow[convQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQuestionnaireCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQuestionnaireEN> GetSubObjLstCache(clsvQuestionnaireEN objvQuestionnaireCond)
{
 string strCourseId = objvQuestionnaireCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvQuestionnaireBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvQuestionnaireEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionnaireEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionnaire.AttributeName)
{
if (objvQuestionnaireCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionnaireCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaireCond[strFldName].ToString());
}
else
{
if (objvQuestionnaireCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionnaireCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaireCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionnaireCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionnaireCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionnaireCond[strFldName]));
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
public static List<clsvQuestionnaireEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQuestionnaireEN> arrObjLst = new List<clsvQuestionnaireEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireEN objvQuestionnaireEN = new clsvQuestionnaireEN();
try
{
objvQuestionnaireEN.QuestionId = Int32.Parse(objRow[convQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaireEN.QuestionIndex = objRow[convQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaireEN.QuestionName = objRow[convQuestionnaire.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaireEN.QuestionContent = objRow[convQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaireEN.QuestionMemo = objRow[convQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaireEN.QuestionNo = objRow[convQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaireEN.ParentQuestionId = objRow[convQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaireEN.ExamAnswer = objRow[convQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaireEN.CourseId = objRow[convQuestionnaire.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireEN.CourseCode = objRow[convQuestionnaire.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaireEN.CourseName = objRow[convQuestionnaire.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseName].ToString().Trim(); //课程名称
objvQuestionnaireEN.LevelNo = objRow[convQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objvQuestionnaireEN.CourseChapterId = objRow[convQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaireEN.CourseChapterName = objRow[convQuestionnaire.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaireEN.ChapterId = objRow[convQuestionnaire.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterId].ToString().Trim(); //章Id
objvQuestionnaireEN.SectionId = objRow[convQuestionnaire.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionId].ToString().Trim(); //节Id
objvQuestionnaireEN.ChapterName = objRow[convQuestionnaire.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterName].ToString().Trim(); //章名
objvQuestionnaireEN.SectionName = objRow[convQuestionnaire.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire.SectionName].ToString().Trim(); //节名
objvQuestionnaireEN.ChapterNameSim = objRow[convQuestionnaire.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaireEN.SectionNameSim = objRow[convQuestionnaire.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaireEN.ParentNodeId = objRow[convQuestionnaire.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaireEN.CourseChapterReferred = objRow[convQuestionnaire.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaireEN.ParentNodeName = objRow[convQuestionnaire.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaireEN.ParentNodeReferred = objRow[convQuestionnaire.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaireEN.QuestionTypeId = objRow[convQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireEN.QuestionTypeName = objRow[convQuestionnaire.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireEN.QuestionTypeId4Course = objRow[convQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaireEN.QuestionTypeName4Course = objRow[convQuestionnaire.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionnaireEN.AnswerTypeId = objRow[convQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaireEN.AnswerTypeName = objRow[convQuestionnaire.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaireEN.GridTitle = objRow[convQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaireEN.AnswerModeId = objRow[convQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaireEN.AnswerModeName = objRow[convQuestionnaire.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaireEN.QuestionScore = objRow[convQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaireEN.DefaultValue = objRow[convQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaireEN.DefaultSelectItem = objRow[convQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaireEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsShow].ToString().Trim()); //是否启用
objvQuestionnaireEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsCast].ToString().Trim()); //是否播放
objvQuestionnaireEN.LikeCount = objRow[convQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaireEN.AnswerAttLimitSize = objRow[convQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvQuestionnaireEN.LimitedResourceType = objRow[convQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[convQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objvQuestionnaireEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaireEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaireEN.ExamGradeId = objRow[convQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaireEN.ExamGradeName = objRow[convQuestionnaire.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaireEN.TextDirectId = objRow[convQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaireEN.UpdDate = objRow[convQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaireEN.UpdUser = objRow[convQuestionnaire.UpdUser].ToString().Trim(); //修改人
objvQuestionnaireEN.Memo = objRow[convQuestionnaire.Memo] == DBNull.Value ? null : objRow[convQuestionnaire.Memo].ToString().Trim(); //备注
objvQuestionnaireEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaireEN.CodeTab = objRow[convQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTab].ToString().Trim(); //代码表
objvQuestionnaireEN.CodeTabCode = objRow[convQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaireEN.CodeTabCondition = objRow[convQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaireEN.CodeTabName = objRow[convQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaireEN.CourseIdChapter = objRow[convQuestionnaire.CourseIdChapter] == DBNull.Value ? null : objRow[convQuestionnaire.CourseIdChapter].ToString().Trim(); //CourseId_Chapter
objvQuestionnaireEN.OptionNum = objRow[convQuestionnaire.OptionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.OptionNum].ToString().Trim()); //选项数
objvQuestionnaireEN.ChapterOrderNum = objRow[convQuestionnaire.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaireEN.QuestionNameAdd = objRow[convQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaireEN.DifficultyLevelId = objRow[convQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objvQuestionnaireEN.FillInTextHeight = objRow[convQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaireEN.FillInTextWidth = objRow[convQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaireEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaireEN.IsJs = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objvQuestionnaireEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaireEN.KnowledgeGraphId = objRow[convQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[convQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvQuestionnaireEN.MemoTextWidth = objRow[convQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaireEN.QuestionCode = objRow[convQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objvQuestionnaireEN.SectionTypeId = objRow[convQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objvQuestionnaireEN.CheckBoxLimitCount = objRow[convQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaireEN.RelaEvent = objRow[convQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireEN);
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
public static List<clsvQuestionnaireEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQuestionnaireEN> arrObjLst = new List<clsvQuestionnaireEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireEN objvQuestionnaireEN = new clsvQuestionnaireEN();
try
{
objvQuestionnaireEN.QuestionId = Int32.Parse(objRow[convQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaireEN.QuestionIndex = objRow[convQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaireEN.QuestionName = objRow[convQuestionnaire.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaireEN.QuestionContent = objRow[convQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaireEN.QuestionMemo = objRow[convQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaireEN.QuestionNo = objRow[convQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaireEN.ParentQuestionId = objRow[convQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaireEN.ExamAnswer = objRow[convQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaireEN.CourseId = objRow[convQuestionnaire.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireEN.CourseCode = objRow[convQuestionnaire.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaireEN.CourseName = objRow[convQuestionnaire.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseName].ToString().Trim(); //课程名称
objvQuestionnaireEN.LevelNo = objRow[convQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objvQuestionnaireEN.CourseChapterId = objRow[convQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaireEN.CourseChapterName = objRow[convQuestionnaire.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaireEN.ChapterId = objRow[convQuestionnaire.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterId].ToString().Trim(); //章Id
objvQuestionnaireEN.SectionId = objRow[convQuestionnaire.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionId].ToString().Trim(); //节Id
objvQuestionnaireEN.ChapterName = objRow[convQuestionnaire.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterName].ToString().Trim(); //章名
objvQuestionnaireEN.SectionName = objRow[convQuestionnaire.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire.SectionName].ToString().Trim(); //节名
objvQuestionnaireEN.ChapterNameSim = objRow[convQuestionnaire.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaireEN.SectionNameSim = objRow[convQuestionnaire.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaireEN.ParentNodeId = objRow[convQuestionnaire.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaireEN.CourseChapterReferred = objRow[convQuestionnaire.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaireEN.ParentNodeName = objRow[convQuestionnaire.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaireEN.ParentNodeReferred = objRow[convQuestionnaire.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaireEN.QuestionTypeId = objRow[convQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireEN.QuestionTypeName = objRow[convQuestionnaire.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireEN.QuestionTypeId4Course = objRow[convQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaireEN.QuestionTypeName4Course = objRow[convQuestionnaire.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionnaireEN.AnswerTypeId = objRow[convQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaireEN.AnswerTypeName = objRow[convQuestionnaire.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaireEN.GridTitle = objRow[convQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaireEN.AnswerModeId = objRow[convQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaireEN.AnswerModeName = objRow[convQuestionnaire.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaireEN.QuestionScore = objRow[convQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaireEN.DefaultValue = objRow[convQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaireEN.DefaultSelectItem = objRow[convQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaireEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsShow].ToString().Trim()); //是否启用
objvQuestionnaireEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsCast].ToString().Trim()); //是否播放
objvQuestionnaireEN.LikeCount = objRow[convQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaireEN.AnswerAttLimitSize = objRow[convQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvQuestionnaireEN.LimitedResourceType = objRow[convQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[convQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objvQuestionnaireEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaireEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaireEN.ExamGradeId = objRow[convQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaireEN.ExamGradeName = objRow[convQuestionnaire.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaireEN.TextDirectId = objRow[convQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaireEN.UpdDate = objRow[convQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaireEN.UpdUser = objRow[convQuestionnaire.UpdUser].ToString().Trim(); //修改人
objvQuestionnaireEN.Memo = objRow[convQuestionnaire.Memo] == DBNull.Value ? null : objRow[convQuestionnaire.Memo].ToString().Trim(); //备注
objvQuestionnaireEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaireEN.CodeTab = objRow[convQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTab].ToString().Trim(); //代码表
objvQuestionnaireEN.CodeTabCode = objRow[convQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaireEN.CodeTabCondition = objRow[convQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaireEN.CodeTabName = objRow[convQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaireEN.CourseIdChapter = objRow[convQuestionnaire.CourseIdChapter] == DBNull.Value ? null : objRow[convQuestionnaire.CourseIdChapter].ToString().Trim(); //CourseId_Chapter
objvQuestionnaireEN.OptionNum = objRow[convQuestionnaire.OptionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.OptionNum].ToString().Trim()); //选项数
objvQuestionnaireEN.ChapterOrderNum = objRow[convQuestionnaire.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaireEN.QuestionNameAdd = objRow[convQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaireEN.DifficultyLevelId = objRow[convQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objvQuestionnaireEN.FillInTextHeight = objRow[convQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaireEN.FillInTextWidth = objRow[convQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaireEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaireEN.IsJs = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objvQuestionnaireEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaireEN.KnowledgeGraphId = objRow[convQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[convQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvQuestionnaireEN.MemoTextWidth = objRow[convQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaireEN.QuestionCode = objRow[convQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objvQuestionnaireEN.SectionTypeId = objRow[convQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objvQuestionnaireEN.CheckBoxLimitCount = objRow[convQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaireEN.RelaEvent = objRow[convQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireEN);
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
List<clsvQuestionnaireEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQuestionnaireEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaireEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQuestionnaireEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionnaireEN> arrObjLst = new List<clsvQuestionnaireEN>(); 
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
	clsvQuestionnaireEN objvQuestionnaireEN = new clsvQuestionnaireEN();
try
{
objvQuestionnaireEN.QuestionId = Int32.Parse(objRow[convQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaireEN.QuestionIndex = objRow[convQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaireEN.QuestionName = objRow[convQuestionnaire.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaireEN.QuestionContent = objRow[convQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaireEN.QuestionMemo = objRow[convQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaireEN.QuestionNo = objRow[convQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaireEN.ParentQuestionId = objRow[convQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaireEN.ExamAnswer = objRow[convQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaireEN.CourseId = objRow[convQuestionnaire.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireEN.CourseCode = objRow[convQuestionnaire.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaireEN.CourseName = objRow[convQuestionnaire.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseName].ToString().Trim(); //课程名称
objvQuestionnaireEN.LevelNo = objRow[convQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objvQuestionnaireEN.CourseChapterId = objRow[convQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaireEN.CourseChapterName = objRow[convQuestionnaire.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaireEN.ChapterId = objRow[convQuestionnaire.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterId].ToString().Trim(); //章Id
objvQuestionnaireEN.SectionId = objRow[convQuestionnaire.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionId].ToString().Trim(); //节Id
objvQuestionnaireEN.ChapterName = objRow[convQuestionnaire.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterName].ToString().Trim(); //章名
objvQuestionnaireEN.SectionName = objRow[convQuestionnaire.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire.SectionName].ToString().Trim(); //节名
objvQuestionnaireEN.ChapterNameSim = objRow[convQuestionnaire.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaireEN.SectionNameSim = objRow[convQuestionnaire.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaireEN.ParentNodeId = objRow[convQuestionnaire.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaireEN.CourseChapterReferred = objRow[convQuestionnaire.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaireEN.ParentNodeName = objRow[convQuestionnaire.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaireEN.ParentNodeReferred = objRow[convQuestionnaire.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaireEN.QuestionTypeId = objRow[convQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireEN.QuestionTypeName = objRow[convQuestionnaire.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireEN.QuestionTypeId4Course = objRow[convQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaireEN.QuestionTypeName4Course = objRow[convQuestionnaire.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionnaireEN.AnswerTypeId = objRow[convQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaireEN.AnswerTypeName = objRow[convQuestionnaire.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaireEN.GridTitle = objRow[convQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaireEN.AnswerModeId = objRow[convQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaireEN.AnswerModeName = objRow[convQuestionnaire.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaireEN.QuestionScore = objRow[convQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaireEN.DefaultValue = objRow[convQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaireEN.DefaultSelectItem = objRow[convQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaireEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsShow].ToString().Trim()); //是否启用
objvQuestionnaireEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsCast].ToString().Trim()); //是否播放
objvQuestionnaireEN.LikeCount = objRow[convQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaireEN.AnswerAttLimitSize = objRow[convQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvQuestionnaireEN.LimitedResourceType = objRow[convQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[convQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objvQuestionnaireEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaireEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaireEN.ExamGradeId = objRow[convQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaireEN.ExamGradeName = objRow[convQuestionnaire.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaireEN.TextDirectId = objRow[convQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaireEN.UpdDate = objRow[convQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaireEN.UpdUser = objRow[convQuestionnaire.UpdUser].ToString().Trim(); //修改人
objvQuestionnaireEN.Memo = objRow[convQuestionnaire.Memo] == DBNull.Value ? null : objRow[convQuestionnaire.Memo].ToString().Trim(); //备注
objvQuestionnaireEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaireEN.CodeTab = objRow[convQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTab].ToString().Trim(); //代码表
objvQuestionnaireEN.CodeTabCode = objRow[convQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaireEN.CodeTabCondition = objRow[convQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaireEN.CodeTabName = objRow[convQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaireEN.CourseIdChapter = objRow[convQuestionnaire.CourseIdChapter] == DBNull.Value ? null : objRow[convQuestionnaire.CourseIdChapter].ToString().Trim(); //CourseId_Chapter
objvQuestionnaireEN.OptionNum = objRow[convQuestionnaire.OptionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.OptionNum].ToString().Trim()); //选项数
objvQuestionnaireEN.ChapterOrderNum = objRow[convQuestionnaire.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaireEN.QuestionNameAdd = objRow[convQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaireEN.DifficultyLevelId = objRow[convQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objvQuestionnaireEN.FillInTextHeight = objRow[convQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaireEN.FillInTextWidth = objRow[convQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaireEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaireEN.IsJs = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objvQuestionnaireEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaireEN.KnowledgeGraphId = objRow[convQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[convQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvQuestionnaireEN.MemoTextWidth = objRow[convQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaireEN.QuestionCode = objRow[convQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objvQuestionnaireEN.SectionTypeId = objRow[convQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objvQuestionnaireEN.CheckBoxLimitCount = objRow[convQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaireEN.RelaEvent = objRow[convQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireEN);
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
public static List<clsvQuestionnaireEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionnaireEN> arrObjLst = new List<clsvQuestionnaireEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireEN objvQuestionnaireEN = new clsvQuestionnaireEN();
try
{
objvQuestionnaireEN.QuestionId = Int32.Parse(objRow[convQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaireEN.QuestionIndex = objRow[convQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaireEN.QuestionName = objRow[convQuestionnaire.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaireEN.QuestionContent = objRow[convQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaireEN.QuestionMemo = objRow[convQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaireEN.QuestionNo = objRow[convQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaireEN.ParentQuestionId = objRow[convQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaireEN.ExamAnswer = objRow[convQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaireEN.CourseId = objRow[convQuestionnaire.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireEN.CourseCode = objRow[convQuestionnaire.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaireEN.CourseName = objRow[convQuestionnaire.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseName].ToString().Trim(); //课程名称
objvQuestionnaireEN.LevelNo = objRow[convQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objvQuestionnaireEN.CourseChapterId = objRow[convQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaireEN.CourseChapterName = objRow[convQuestionnaire.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaireEN.ChapterId = objRow[convQuestionnaire.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterId].ToString().Trim(); //章Id
objvQuestionnaireEN.SectionId = objRow[convQuestionnaire.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionId].ToString().Trim(); //节Id
objvQuestionnaireEN.ChapterName = objRow[convQuestionnaire.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterName].ToString().Trim(); //章名
objvQuestionnaireEN.SectionName = objRow[convQuestionnaire.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire.SectionName].ToString().Trim(); //节名
objvQuestionnaireEN.ChapterNameSim = objRow[convQuestionnaire.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaireEN.SectionNameSim = objRow[convQuestionnaire.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaireEN.ParentNodeId = objRow[convQuestionnaire.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaireEN.CourseChapterReferred = objRow[convQuestionnaire.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaireEN.ParentNodeName = objRow[convQuestionnaire.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaireEN.ParentNodeReferred = objRow[convQuestionnaire.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaireEN.QuestionTypeId = objRow[convQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireEN.QuestionTypeName = objRow[convQuestionnaire.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireEN.QuestionTypeId4Course = objRow[convQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaireEN.QuestionTypeName4Course = objRow[convQuestionnaire.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionnaireEN.AnswerTypeId = objRow[convQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaireEN.AnswerTypeName = objRow[convQuestionnaire.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaireEN.GridTitle = objRow[convQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaireEN.AnswerModeId = objRow[convQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaireEN.AnswerModeName = objRow[convQuestionnaire.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaireEN.QuestionScore = objRow[convQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaireEN.DefaultValue = objRow[convQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaireEN.DefaultSelectItem = objRow[convQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaireEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsShow].ToString().Trim()); //是否启用
objvQuestionnaireEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsCast].ToString().Trim()); //是否播放
objvQuestionnaireEN.LikeCount = objRow[convQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaireEN.AnswerAttLimitSize = objRow[convQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvQuestionnaireEN.LimitedResourceType = objRow[convQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[convQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objvQuestionnaireEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaireEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaireEN.ExamGradeId = objRow[convQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaireEN.ExamGradeName = objRow[convQuestionnaire.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaireEN.TextDirectId = objRow[convQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaireEN.UpdDate = objRow[convQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaireEN.UpdUser = objRow[convQuestionnaire.UpdUser].ToString().Trim(); //修改人
objvQuestionnaireEN.Memo = objRow[convQuestionnaire.Memo] == DBNull.Value ? null : objRow[convQuestionnaire.Memo].ToString().Trim(); //备注
objvQuestionnaireEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaireEN.CodeTab = objRow[convQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTab].ToString().Trim(); //代码表
objvQuestionnaireEN.CodeTabCode = objRow[convQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaireEN.CodeTabCondition = objRow[convQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaireEN.CodeTabName = objRow[convQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaireEN.CourseIdChapter = objRow[convQuestionnaire.CourseIdChapter] == DBNull.Value ? null : objRow[convQuestionnaire.CourseIdChapter].ToString().Trim(); //CourseId_Chapter
objvQuestionnaireEN.OptionNum = objRow[convQuestionnaire.OptionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.OptionNum].ToString().Trim()); //选项数
objvQuestionnaireEN.ChapterOrderNum = objRow[convQuestionnaire.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaireEN.QuestionNameAdd = objRow[convQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaireEN.DifficultyLevelId = objRow[convQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objvQuestionnaireEN.FillInTextHeight = objRow[convQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaireEN.FillInTextWidth = objRow[convQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaireEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaireEN.IsJs = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objvQuestionnaireEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaireEN.KnowledgeGraphId = objRow[convQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[convQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvQuestionnaireEN.MemoTextWidth = objRow[convQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaireEN.QuestionCode = objRow[convQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objvQuestionnaireEN.SectionTypeId = objRow[convQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objvQuestionnaireEN.CheckBoxLimitCount = objRow[convQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaireEN.RelaEvent = objRow[convQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQuestionnaireEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQuestionnaireEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionnaireEN> arrObjLst = new List<clsvQuestionnaireEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireEN objvQuestionnaireEN = new clsvQuestionnaireEN();
try
{
objvQuestionnaireEN.QuestionId = Int32.Parse(objRow[convQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaireEN.QuestionIndex = objRow[convQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaireEN.QuestionName = objRow[convQuestionnaire.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaireEN.QuestionContent = objRow[convQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaireEN.QuestionMemo = objRow[convQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaireEN.QuestionNo = objRow[convQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaireEN.ParentQuestionId = objRow[convQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaireEN.ExamAnswer = objRow[convQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaireEN.CourseId = objRow[convQuestionnaire.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireEN.CourseCode = objRow[convQuestionnaire.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaireEN.CourseName = objRow[convQuestionnaire.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseName].ToString().Trim(); //课程名称
objvQuestionnaireEN.LevelNo = objRow[convQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objvQuestionnaireEN.CourseChapterId = objRow[convQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaireEN.CourseChapterName = objRow[convQuestionnaire.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaireEN.ChapterId = objRow[convQuestionnaire.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterId].ToString().Trim(); //章Id
objvQuestionnaireEN.SectionId = objRow[convQuestionnaire.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionId].ToString().Trim(); //节Id
objvQuestionnaireEN.ChapterName = objRow[convQuestionnaire.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterName].ToString().Trim(); //章名
objvQuestionnaireEN.SectionName = objRow[convQuestionnaire.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire.SectionName].ToString().Trim(); //节名
objvQuestionnaireEN.ChapterNameSim = objRow[convQuestionnaire.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaireEN.SectionNameSim = objRow[convQuestionnaire.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaireEN.ParentNodeId = objRow[convQuestionnaire.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaireEN.CourseChapterReferred = objRow[convQuestionnaire.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaireEN.ParentNodeName = objRow[convQuestionnaire.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaireEN.ParentNodeReferred = objRow[convQuestionnaire.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaireEN.QuestionTypeId = objRow[convQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireEN.QuestionTypeName = objRow[convQuestionnaire.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireEN.QuestionTypeId4Course = objRow[convQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaireEN.QuestionTypeName4Course = objRow[convQuestionnaire.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionnaireEN.AnswerTypeId = objRow[convQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaireEN.AnswerTypeName = objRow[convQuestionnaire.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaireEN.GridTitle = objRow[convQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaireEN.AnswerModeId = objRow[convQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaireEN.AnswerModeName = objRow[convQuestionnaire.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaireEN.QuestionScore = objRow[convQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaireEN.DefaultValue = objRow[convQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaireEN.DefaultSelectItem = objRow[convQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaireEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsShow].ToString().Trim()); //是否启用
objvQuestionnaireEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsCast].ToString().Trim()); //是否播放
objvQuestionnaireEN.LikeCount = objRow[convQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaireEN.AnswerAttLimitSize = objRow[convQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvQuestionnaireEN.LimitedResourceType = objRow[convQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[convQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objvQuestionnaireEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaireEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaireEN.ExamGradeId = objRow[convQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaireEN.ExamGradeName = objRow[convQuestionnaire.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaireEN.TextDirectId = objRow[convQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaireEN.UpdDate = objRow[convQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaireEN.UpdUser = objRow[convQuestionnaire.UpdUser].ToString().Trim(); //修改人
objvQuestionnaireEN.Memo = objRow[convQuestionnaire.Memo] == DBNull.Value ? null : objRow[convQuestionnaire.Memo].ToString().Trim(); //备注
objvQuestionnaireEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaireEN.CodeTab = objRow[convQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTab].ToString().Trim(); //代码表
objvQuestionnaireEN.CodeTabCode = objRow[convQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaireEN.CodeTabCondition = objRow[convQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaireEN.CodeTabName = objRow[convQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaireEN.CourseIdChapter = objRow[convQuestionnaire.CourseIdChapter] == DBNull.Value ? null : objRow[convQuestionnaire.CourseIdChapter].ToString().Trim(); //CourseId_Chapter
objvQuestionnaireEN.OptionNum = objRow[convQuestionnaire.OptionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.OptionNum].ToString().Trim()); //选项数
objvQuestionnaireEN.ChapterOrderNum = objRow[convQuestionnaire.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaireEN.QuestionNameAdd = objRow[convQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaireEN.DifficultyLevelId = objRow[convQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objvQuestionnaireEN.FillInTextHeight = objRow[convQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaireEN.FillInTextWidth = objRow[convQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaireEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaireEN.IsJs = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objvQuestionnaireEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaireEN.KnowledgeGraphId = objRow[convQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[convQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvQuestionnaireEN.MemoTextWidth = objRow[convQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaireEN.QuestionCode = objRow[convQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objvQuestionnaireEN.SectionTypeId = objRow[convQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objvQuestionnaireEN.CheckBoxLimitCount = objRow[convQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaireEN.RelaEvent = objRow[convQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireEN);
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
public static List<clsvQuestionnaireEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQuestionnaireEN> arrObjLst = new List<clsvQuestionnaireEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireEN objvQuestionnaireEN = new clsvQuestionnaireEN();
try
{
objvQuestionnaireEN.QuestionId = Int32.Parse(objRow[convQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaireEN.QuestionIndex = objRow[convQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaireEN.QuestionName = objRow[convQuestionnaire.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaireEN.QuestionContent = objRow[convQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaireEN.QuestionMemo = objRow[convQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaireEN.QuestionNo = objRow[convQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaireEN.ParentQuestionId = objRow[convQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaireEN.ExamAnswer = objRow[convQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaireEN.CourseId = objRow[convQuestionnaire.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireEN.CourseCode = objRow[convQuestionnaire.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaireEN.CourseName = objRow[convQuestionnaire.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseName].ToString().Trim(); //课程名称
objvQuestionnaireEN.LevelNo = objRow[convQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objvQuestionnaireEN.CourseChapterId = objRow[convQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaireEN.CourseChapterName = objRow[convQuestionnaire.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaireEN.ChapterId = objRow[convQuestionnaire.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterId].ToString().Trim(); //章Id
objvQuestionnaireEN.SectionId = objRow[convQuestionnaire.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionId].ToString().Trim(); //节Id
objvQuestionnaireEN.ChapterName = objRow[convQuestionnaire.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterName].ToString().Trim(); //章名
objvQuestionnaireEN.SectionName = objRow[convQuestionnaire.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire.SectionName].ToString().Trim(); //节名
objvQuestionnaireEN.ChapterNameSim = objRow[convQuestionnaire.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaireEN.SectionNameSim = objRow[convQuestionnaire.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaireEN.ParentNodeId = objRow[convQuestionnaire.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaireEN.CourseChapterReferred = objRow[convQuestionnaire.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaireEN.ParentNodeName = objRow[convQuestionnaire.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaireEN.ParentNodeReferred = objRow[convQuestionnaire.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaireEN.QuestionTypeId = objRow[convQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireEN.QuestionTypeName = objRow[convQuestionnaire.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireEN.QuestionTypeId4Course = objRow[convQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaireEN.QuestionTypeName4Course = objRow[convQuestionnaire.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionnaireEN.AnswerTypeId = objRow[convQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaireEN.AnswerTypeName = objRow[convQuestionnaire.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaireEN.GridTitle = objRow[convQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaireEN.AnswerModeId = objRow[convQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaireEN.AnswerModeName = objRow[convQuestionnaire.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaireEN.QuestionScore = objRow[convQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaireEN.DefaultValue = objRow[convQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaireEN.DefaultSelectItem = objRow[convQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaireEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsShow].ToString().Trim()); //是否启用
objvQuestionnaireEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsCast].ToString().Trim()); //是否播放
objvQuestionnaireEN.LikeCount = objRow[convQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaireEN.AnswerAttLimitSize = objRow[convQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvQuestionnaireEN.LimitedResourceType = objRow[convQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[convQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objvQuestionnaireEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaireEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaireEN.ExamGradeId = objRow[convQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaireEN.ExamGradeName = objRow[convQuestionnaire.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaireEN.TextDirectId = objRow[convQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaireEN.UpdDate = objRow[convQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaireEN.UpdUser = objRow[convQuestionnaire.UpdUser].ToString().Trim(); //修改人
objvQuestionnaireEN.Memo = objRow[convQuestionnaire.Memo] == DBNull.Value ? null : objRow[convQuestionnaire.Memo].ToString().Trim(); //备注
objvQuestionnaireEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaireEN.CodeTab = objRow[convQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTab].ToString().Trim(); //代码表
objvQuestionnaireEN.CodeTabCode = objRow[convQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaireEN.CodeTabCondition = objRow[convQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaireEN.CodeTabName = objRow[convQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaireEN.CourseIdChapter = objRow[convQuestionnaire.CourseIdChapter] == DBNull.Value ? null : objRow[convQuestionnaire.CourseIdChapter].ToString().Trim(); //CourseId_Chapter
objvQuestionnaireEN.OptionNum = objRow[convQuestionnaire.OptionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.OptionNum].ToString().Trim()); //选项数
objvQuestionnaireEN.ChapterOrderNum = objRow[convQuestionnaire.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaireEN.QuestionNameAdd = objRow[convQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaireEN.DifficultyLevelId = objRow[convQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objvQuestionnaireEN.FillInTextHeight = objRow[convQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaireEN.FillInTextWidth = objRow[convQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaireEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaireEN.IsJs = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objvQuestionnaireEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaireEN.KnowledgeGraphId = objRow[convQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[convQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvQuestionnaireEN.MemoTextWidth = objRow[convQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaireEN.QuestionCode = objRow[convQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objvQuestionnaireEN.SectionTypeId = objRow[convQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objvQuestionnaireEN.CheckBoxLimitCount = objRow[convQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaireEN.RelaEvent = objRow[convQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaireEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQuestionnaireEN> arrObjLst = new List<clsvQuestionnaireEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireEN objvQuestionnaireEN = new clsvQuestionnaireEN();
try
{
objvQuestionnaireEN.QuestionId = Int32.Parse(objRow[convQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaireEN.QuestionIndex = objRow[convQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaireEN.QuestionName = objRow[convQuestionnaire.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaireEN.QuestionContent = objRow[convQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaireEN.QuestionMemo = objRow[convQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaireEN.QuestionNo = objRow[convQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaireEN.ParentQuestionId = objRow[convQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaireEN.ExamAnswer = objRow[convQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaireEN.CourseId = objRow[convQuestionnaire.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireEN.CourseCode = objRow[convQuestionnaire.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaireEN.CourseName = objRow[convQuestionnaire.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseName].ToString().Trim(); //课程名称
objvQuestionnaireEN.LevelNo = objRow[convQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objvQuestionnaireEN.CourseChapterId = objRow[convQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaireEN.CourseChapterName = objRow[convQuestionnaire.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaireEN.ChapterId = objRow[convQuestionnaire.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterId].ToString().Trim(); //章Id
objvQuestionnaireEN.SectionId = objRow[convQuestionnaire.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionId].ToString().Trim(); //节Id
objvQuestionnaireEN.ChapterName = objRow[convQuestionnaire.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterName].ToString().Trim(); //章名
objvQuestionnaireEN.SectionName = objRow[convQuestionnaire.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire.SectionName].ToString().Trim(); //节名
objvQuestionnaireEN.ChapterNameSim = objRow[convQuestionnaire.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaireEN.SectionNameSim = objRow[convQuestionnaire.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaireEN.ParentNodeId = objRow[convQuestionnaire.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaireEN.CourseChapterReferred = objRow[convQuestionnaire.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaireEN.ParentNodeName = objRow[convQuestionnaire.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaireEN.ParentNodeReferred = objRow[convQuestionnaire.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaireEN.QuestionTypeId = objRow[convQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireEN.QuestionTypeName = objRow[convQuestionnaire.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireEN.QuestionTypeId4Course = objRow[convQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaireEN.QuestionTypeName4Course = objRow[convQuestionnaire.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionnaireEN.AnswerTypeId = objRow[convQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaireEN.AnswerTypeName = objRow[convQuestionnaire.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaireEN.GridTitle = objRow[convQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaireEN.AnswerModeId = objRow[convQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaireEN.AnswerModeName = objRow[convQuestionnaire.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaireEN.QuestionScore = objRow[convQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaireEN.DefaultValue = objRow[convQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaireEN.DefaultSelectItem = objRow[convQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaireEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsShow].ToString().Trim()); //是否启用
objvQuestionnaireEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsCast].ToString().Trim()); //是否播放
objvQuestionnaireEN.LikeCount = objRow[convQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaireEN.AnswerAttLimitSize = objRow[convQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvQuestionnaireEN.LimitedResourceType = objRow[convQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[convQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objvQuestionnaireEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaireEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaireEN.ExamGradeId = objRow[convQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaireEN.ExamGradeName = objRow[convQuestionnaire.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaireEN.TextDirectId = objRow[convQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaireEN.UpdDate = objRow[convQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaireEN.UpdUser = objRow[convQuestionnaire.UpdUser].ToString().Trim(); //修改人
objvQuestionnaireEN.Memo = objRow[convQuestionnaire.Memo] == DBNull.Value ? null : objRow[convQuestionnaire.Memo].ToString().Trim(); //备注
objvQuestionnaireEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaireEN.CodeTab = objRow[convQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTab].ToString().Trim(); //代码表
objvQuestionnaireEN.CodeTabCode = objRow[convQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaireEN.CodeTabCondition = objRow[convQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaireEN.CodeTabName = objRow[convQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaireEN.CourseIdChapter = objRow[convQuestionnaire.CourseIdChapter] == DBNull.Value ? null : objRow[convQuestionnaire.CourseIdChapter].ToString().Trim(); //CourseId_Chapter
objvQuestionnaireEN.OptionNum = objRow[convQuestionnaire.OptionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.OptionNum].ToString().Trim()); //选项数
objvQuestionnaireEN.ChapterOrderNum = objRow[convQuestionnaire.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaireEN.QuestionNameAdd = objRow[convQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaireEN.DifficultyLevelId = objRow[convQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objvQuestionnaireEN.FillInTextHeight = objRow[convQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaireEN.FillInTextWidth = objRow[convQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaireEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaireEN.IsJs = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objvQuestionnaireEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaireEN.KnowledgeGraphId = objRow[convQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[convQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvQuestionnaireEN.MemoTextWidth = objRow[convQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaireEN.QuestionCode = objRow[convQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objvQuestionnaireEN.SectionTypeId = objRow[convQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objvQuestionnaireEN.CheckBoxLimitCount = objRow[convQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaireEN.RelaEvent = objRow[convQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQuestionnaire(ref clsvQuestionnaireEN objvQuestionnaireEN)
{
bool bolResult = vQuestionnaireDA.GetvQuestionnaire(ref objvQuestionnaireEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaireEN GetObjByQuestionId(long lngQuestionId)
{
clsvQuestionnaireEN objvQuestionnaireEN = vQuestionnaireDA.GetObjByQuestionId(lngQuestionId);
return objvQuestionnaireEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQuestionnaireEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQuestionnaireEN objvQuestionnaireEN = vQuestionnaireDA.GetFirstObj(strWhereCond);
 return objvQuestionnaireEN;
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
public static clsvQuestionnaireEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQuestionnaireEN objvQuestionnaireEN = vQuestionnaireDA.GetObjByDataRow(objRow);
 return objvQuestionnaireEN;
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
public static clsvQuestionnaireEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQuestionnaireEN objvQuestionnaireEN = vQuestionnaireDA.GetObjByDataRow(objRow);
 return objvQuestionnaireEN;
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
 /// <param name = "lstvQuestionnaireObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionnaireEN GetObjByQuestionIdFromList(long lngQuestionId, List<clsvQuestionnaireEN> lstvQuestionnaireObjLst)
{
foreach (clsvQuestionnaireEN objvQuestionnaireEN in lstvQuestionnaireObjLst)
{
if (objvQuestionnaireEN.QuestionId == lngQuestionId)
{
return objvQuestionnaireEN;
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
 lngQuestionId = new clsvQuestionnaireDA().GetFirstID(strWhereCond);
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
 arrList = vQuestionnaireDA.GetID(strWhereCond);
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
bool bolIsExist = vQuestionnaireDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vQuestionnaireDA.IsExist(lngQuestionId);
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
 bolIsExist = clsvQuestionnaireDA.IsExistTable();
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
 bolIsExist = vQuestionnaireDA.IsExistTable(strTabName);
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
 /// <param name = "objvQuestionnaireENS">源对象</param>
 /// <param name = "objvQuestionnaireENT">目标对象</param>
 public static void CopyTo(clsvQuestionnaireEN objvQuestionnaireENS, clsvQuestionnaireEN objvQuestionnaireENT)
{
try
{
objvQuestionnaireENT.QuestionId = objvQuestionnaireENS.QuestionId; //题目Id
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
objvQuestionnaireENT.ChapterNameSim = objvQuestionnaireENS.ChapterNameSim; //章名简称
objvQuestionnaireENT.SectionNameSim = objvQuestionnaireENS.SectionNameSim; //节名简称
objvQuestionnaireENT.ParentNodeId = objvQuestionnaireENS.ParentNodeId; //父节点编号
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
objvQuestionnaireENT.CodeTabCode = objvQuestionnaireENS.CodeTabCode; //CodeTab_Code
objvQuestionnaireENT.CodeTabCondition = objvQuestionnaireENS.CodeTabCondition; //代码表_条件
objvQuestionnaireENT.CodeTabName = objvQuestionnaireENS.CodeTabName; //CodeTab_Name
objvQuestionnaireENT.CourseIdChapter = objvQuestionnaireENS.CourseIdChapter; //CourseId_Chapter
objvQuestionnaireENT.OptionNum = objvQuestionnaireENS.OptionNum; //选项数
objvQuestionnaireENT.ChapterOrderNum = objvQuestionnaireENS.ChapterOrderNum; //章排序号
objvQuestionnaireENT.QuestionNameAdd = objvQuestionnaireENS.QuestionNameAdd; //题目补充
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
 /// <param name = "objvQuestionnaireEN">源简化对象</param>
 public static void SetUpdFlag(clsvQuestionnaireEN objvQuestionnaireEN)
{
try
{
objvQuestionnaireEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQuestionnaireEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQuestionnaire.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.QuestionId = objvQuestionnaireEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(convQuestionnaire.QuestionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.QuestionIndex = objvQuestionnaireEN.QuestionIndex; //题目序号
}
if (arrFldSet.Contains(convQuestionnaire.QuestionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.QuestionName = objvQuestionnaireEN.QuestionName == "[null]" ? null :  objvQuestionnaireEN.QuestionName; //题目名称
}
if (arrFldSet.Contains(convQuestionnaire.QuestionContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.QuestionContent = objvQuestionnaireEN.QuestionContent == "[null]" ? null :  objvQuestionnaireEN.QuestionContent; //题目内容
}
if (arrFldSet.Contains(convQuestionnaire.QuestionMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.QuestionMemo = objvQuestionnaireEN.QuestionMemo == "[null]" ? null :  objvQuestionnaireEN.QuestionMemo; //题目说明
}
if (arrFldSet.Contains(convQuestionnaire.QuestionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.QuestionNo = objvQuestionnaireEN.QuestionNo == "[null]" ? null :  objvQuestionnaireEN.QuestionNo; //题目编号
}
if (arrFldSet.Contains(convQuestionnaire.ParentQuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.ParentQuestionId = objvQuestionnaireEN.ParentQuestionId == "[null]" ? null :  objvQuestionnaireEN.ParentQuestionId; //父题目Id
}
if (arrFldSet.Contains(convQuestionnaire.ExamAnswer, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.ExamAnswer = objvQuestionnaireEN.ExamAnswer == "[null]" ? null :  objvQuestionnaireEN.ExamAnswer; //题目答案
}
if (arrFldSet.Contains(convQuestionnaire.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.CourseId = objvQuestionnaireEN.CourseId == "[null]" ? null :  objvQuestionnaireEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convQuestionnaire.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.CourseCode = objvQuestionnaireEN.CourseCode == "[null]" ? null :  objvQuestionnaireEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convQuestionnaire.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.CourseName = objvQuestionnaireEN.CourseName == "[null]" ? null :  objvQuestionnaireEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convQuestionnaire.LevelNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.LevelNo = objvQuestionnaireEN.LevelNo; //学习关号2
}
if (arrFldSet.Contains(convQuestionnaire.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.CourseChapterId = objvQuestionnaireEN.CourseChapterId == "[null]" ? null :  objvQuestionnaireEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convQuestionnaire.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.CourseChapterName = objvQuestionnaireEN.CourseChapterName == "[null]" ? null :  objvQuestionnaireEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convQuestionnaire.ChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.ChapterId = objvQuestionnaireEN.ChapterId == "[null]" ? null :  objvQuestionnaireEN.ChapterId; //章Id
}
if (arrFldSet.Contains(convQuestionnaire.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.SectionId = objvQuestionnaireEN.SectionId == "[null]" ? null :  objvQuestionnaireEN.SectionId; //节Id
}
if (arrFldSet.Contains(convQuestionnaire.ChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.ChapterName = objvQuestionnaireEN.ChapterName == "[null]" ? null :  objvQuestionnaireEN.ChapterName; //章名
}
if (arrFldSet.Contains(convQuestionnaire.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.SectionName = objvQuestionnaireEN.SectionName == "[null]" ? null :  objvQuestionnaireEN.SectionName; //节名
}
if (arrFldSet.Contains(convQuestionnaire.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.ChapterNameSim = objvQuestionnaireEN.ChapterNameSim == "[null]" ? null :  objvQuestionnaireEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(convQuestionnaire.SectionNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.SectionNameSim = objvQuestionnaireEN.SectionNameSim == "[null]" ? null :  objvQuestionnaireEN.SectionNameSim; //节名简称
}
if (arrFldSet.Contains(convQuestionnaire.ParentNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.ParentNodeId = objvQuestionnaireEN.ParentNodeId == "[null]" ? null :  objvQuestionnaireEN.ParentNodeId; //父节点编号
}
if (arrFldSet.Contains(convQuestionnaire.CourseChapterReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.CourseChapterReferred = objvQuestionnaireEN.CourseChapterReferred == "[null]" ? null :  objvQuestionnaireEN.CourseChapterReferred; //节简称
}
if (arrFldSet.Contains(convQuestionnaire.ParentNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.ParentNodeName = objvQuestionnaireEN.ParentNodeName == "[null]" ? null :  objvQuestionnaireEN.ParentNodeName; //父节点名称
}
if (arrFldSet.Contains(convQuestionnaire.ParentNodeReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.ParentNodeReferred = objvQuestionnaireEN.ParentNodeReferred == "[null]" ? null :  objvQuestionnaireEN.ParentNodeReferred; //章简称
}
if (arrFldSet.Contains(convQuestionnaire.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.QuestionTypeId = objvQuestionnaireEN.QuestionTypeId == "[null]" ? null :  objvQuestionnaireEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(convQuestionnaire.QuestionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.QuestionTypeName = objvQuestionnaireEN.QuestionTypeName == "[null]" ? null :  objvQuestionnaireEN.QuestionTypeName; //题目类型名
}
if (arrFldSet.Contains(convQuestionnaire.QuestionTypeId4Course, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.QuestionTypeId4Course = objvQuestionnaireEN.QuestionTypeId4Course; //题目类型Id4课程
}
if (arrFldSet.Contains(convQuestionnaire.QuestionTypeName4Course, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.QuestionTypeName4Course = objvQuestionnaireEN.QuestionTypeName4Course == "[null]" ? null :  objvQuestionnaireEN.QuestionTypeName4Course; //题目类型名4课程
}
if (arrFldSet.Contains(convQuestionnaire.AnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.AnswerTypeId = objvQuestionnaireEN.AnswerTypeId == "[null]" ? null :  objvQuestionnaireEN.AnswerTypeId; //答案类型ID
}
if (arrFldSet.Contains(convQuestionnaire.AnswerTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.AnswerTypeName = objvQuestionnaireEN.AnswerTypeName == "[null]" ? null :  objvQuestionnaireEN.AnswerTypeName; //答案类型名
}
if (arrFldSet.Contains(convQuestionnaire.GridTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.GridTitle = objvQuestionnaireEN.GridTitle == "[null]" ? null :  objvQuestionnaireEN.GridTitle; //表格标题
}
if (arrFldSet.Contains(convQuestionnaire.AnswerModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.AnswerModeId = objvQuestionnaireEN.AnswerModeId == "[null]" ? null :  objvQuestionnaireEN.AnswerModeId; //答案模式Id
}
if (arrFldSet.Contains(convQuestionnaire.AnswerModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.AnswerModeName = objvQuestionnaireEN.AnswerModeName == "[null]" ? null :  objvQuestionnaireEN.AnswerModeName; //答案模式名称
}
if (arrFldSet.Contains(convQuestionnaire.QuestionScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.QuestionScore = objvQuestionnaireEN.QuestionScore; //题目得分
}
if (arrFldSet.Contains(convQuestionnaire.DefaultValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.DefaultValue = objvQuestionnaireEN.DefaultValue == "[null]" ? null :  objvQuestionnaireEN.DefaultValue; //缺省值
}
if (arrFldSet.Contains(convQuestionnaire.DefaultSelectItem, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.DefaultSelectItem = objvQuestionnaireEN.DefaultSelectItem == "[null]" ? null :  objvQuestionnaireEN.DefaultSelectItem; //默认选项
}
if (arrFldSet.Contains(convQuestionnaire.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.IsShow = objvQuestionnaireEN.IsShow; //是否启用
}
if (arrFldSet.Contains(convQuestionnaire.IsCast, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.IsCast = objvQuestionnaireEN.IsCast; //是否播放
}
if (arrFldSet.Contains(convQuestionnaire.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.LikeCount = objvQuestionnaireEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(convQuestionnaire.AnswerAttLimitSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.AnswerAttLimitSize = objvQuestionnaireEN.AnswerAttLimitSize; //回答附件限制大小
}
if (arrFldSet.Contains(convQuestionnaire.LimitedResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.LimitedResourceType = objvQuestionnaireEN.LimitedResourceType == "[null]" ? null :  objvQuestionnaireEN.LimitedResourceType; //限制资源类型
}
if (arrFldSet.Contains(convQuestionnaire.IsEffective, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.IsEffective = objvQuestionnaireEN.IsEffective; //是否有效
}
if (arrFldSet.Contains(convQuestionnaire.IsCanInPaper, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.IsCanInPaper = objvQuestionnaireEN.IsCanInPaper; //是否可在Paper
}
if (arrFldSet.Contains(convQuestionnaire.ExamGradeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.ExamGradeId = objvQuestionnaireEN.ExamGradeId == "[null]" ? null :  objvQuestionnaireEN.ExamGradeId; //题库等级ID
}
if (arrFldSet.Contains(convQuestionnaire.ExamGradeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.ExamGradeName = objvQuestionnaireEN.ExamGradeName == "[null]" ? null :  objvQuestionnaireEN.ExamGradeName; //题库等级名
}
if (arrFldSet.Contains(convQuestionnaire.TextDirectId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.TextDirectId = objvQuestionnaireEN.TextDirectId == "[null]" ? null :  objvQuestionnaireEN.TextDirectId; //文本方向ID
}
if (arrFldSet.Contains(convQuestionnaire.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.UpdDate = objvQuestionnaireEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQuestionnaire.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.UpdUser = objvQuestionnaireEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convQuestionnaire.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.Memo = objvQuestionnaireEN.Memo == "[null]" ? null :  objvQuestionnaireEN.Memo; //备注
}
if (arrFldSet.Contains(convQuestionnaire.FirstIndent, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.FirstIndent = objvQuestionnaireEN.FirstIndent; //首行缩进
}
if (arrFldSet.Contains(convQuestionnaire.CodeTab, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.CodeTab = objvQuestionnaireEN.CodeTab == "[null]" ? null :  objvQuestionnaireEN.CodeTab; //代码表
}
if (arrFldSet.Contains(convQuestionnaire.CodeTabCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.CodeTabCode = objvQuestionnaireEN.CodeTabCode == "[null]" ? null :  objvQuestionnaireEN.CodeTabCode; //CodeTab_Code
}
if (arrFldSet.Contains(convQuestionnaire.CodeTabCondition, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.CodeTabCondition = objvQuestionnaireEN.CodeTabCondition == "[null]" ? null :  objvQuestionnaireEN.CodeTabCondition; //代码表_条件
}
if (arrFldSet.Contains(convQuestionnaire.CodeTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.CodeTabName = objvQuestionnaireEN.CodeTabName == "[null]" ? null :  objvQuestionnaireEN.CodeTabName; //CodeTab_Name
}
if (arrFldSet.Contains(convQuestionnaire.CourseIdChapter, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.CourseIdChapter = objvQuestionnaireEN.CourseIdChapter == "[null]" ? null :  objvQuestionnaireEN.CourseIdChapter; //CourseId_Chapter
}
if (arrFldSet.Contains(convQuestionnaire.OptionNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.OptionNum = objvQuestionnaireEN.OptionNum; //选项数
}
if (arrFldSet.Contains(convQuestionnaire.ChapterOrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.ChapterOrderNum = objvQuestionnaireEN.ChapterOrderNum; //章排序号
}
if (arrFldSet.Contains(convQuestionnaire.QuestionNameAdd, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.QuestionNameAdd = objvQuestionnaireEN.QuestionNameAdd == "[null]" ? null :  objvQuestionnaireEN.QuestionNameAdd; //题目补充
}
if (arrFldSet.Contains(convQuestionnaire.DifficultyLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.DifficultyLevelId = objvQuestionnaireEN.DifficultyLevelId == "[null]" ? null :  objvQuestionnaireEN.DifficultyLevelId; //难度等级Id
}
if (arrFldSet.Contains(convQuestionnaire.FillInTextHeight, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.FillInTextHeight = objvQuestionnaireEN.FillInTextHeight; //填空框高度
}
if (arrFldSet.Contains(convQuestionnaire.FillInTextWidth, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.FillInTextWidth = objvQuestionnaireEN.FillInTextWidth; //填空框宽度
}
if (arrFldSet.Contains(convQuestionnaire.IsHaveAdditionalMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.IsHaveAdditionalMemo = objvQuestionnaireEN.IsHaveAdditionalMemo; //是否有附加说明
}
if (arrFldSet.Contains(convQuestionnaire.IsJs, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.IsJs = objvQuestionnaireEN.IsJs; //是否是JS
}
if (arrFldSet.Contains(convQuestionnaire.IsMulti4FillInText, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.IsMulti4FillInText = objvQuestionnaireEN.IsMulti4FillInText; //是否填空框多行
}
if (arrFldSet.Contains(convQuestionnaire.KnowledgeGraphId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.KnowledgeGraphId = objvQuestionnaireEN.KnowledgeGraphId == "[null]" ? null :  objvQuestionnaireEN.KnowledgeGraphId; //知识点图Id
}
if (arrFldSet.Contains(convQuestionnaire.MemoTextWidth, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.MemoTextWidth = objvQuestionnaireEN.MemoTextWidth; //备注框宽度
}
if (arrFldSet.Contains(convQuestionnaire.QuestionCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.QuestionCode = objvQuestionnaireEN.QuestionCode == "[null]" ? null :  objvQuestionnaireEN.QuestionCode; //html代码
}
if (arrFldSet.Contains(convQuestionnaire.SectionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.SectionTypeId = objvQuestionnaireEN.SectionTypeId == "[null]" ? null :  objvQuestionnaireEN.SectionTypeId; //节点类型Id
}
if (arrFldSet.Contains(convQuestionnaire.CheckBoxLimitCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.CheckBoxLimitCount = objvQuestionnaireEN.CheckBoxLimitCount; //复选框限制数
}
if (arrFldSet.Contains(convQuestionnaire.RelaEvent, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireEN.RelaEvent = objvQuestionnaireEN.RelaEvent == "[null]" ? null :  objvQuestionnaireEN.RelaEvent; //相关事件
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
 /// <param name = "objvQuestionnaireEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQuestionnaireEN objvQuestionnaireEN)
{
try
{
if (objvQuestionnaireEN.QuestionName == "[null]") objvQuestionnaireEN.QuestionName = null; //题目名称
if (objvQuestionnaireEN.QuestionContent == "[null]") objvQuestionnaireEN.QuestionContent = null; //题目内容
if (objvQuestionnaireEN.QuestionMemo == "[null]") objvQuestionnaireEN.QuestionMemo = null; //题目说明
if (objvQuestionnaireEN.QuestionNo == "[null]") objvQuestionnaireEN.QuestionNo = null; //题目编号
if (objvQuestionnaireEN.ParentQuestionId == "[null]") objvQuestionnaireEN.ParentQuestionId = null; //父题目Id
if (objvQuestionnaireEN.ExamAnswer == "[null]") objvQuestionnaireEN.ExamAnswer = null; //题目答案
if (objvQuestionnaireEN.CourseId == "[null]") objvQuestionnaireEN.CourseId = null; //课程Id
if (objvQuestionnaireEN.CourseCode == "[null]") objvQuestionnaireEN.CourseCode = null; //课程代码
if (objvQuestionnaireEN.CourseName == "[null]") objvQuestionnaireEN.CourseName = null; //课程名称
if (objvQuestionnaireEN.CourseChapterId == "[null]") objvQuestionnaireEN.CourseChapterId = null; //课程章节ID
if (objvQuestionnaireEN.CourseChapterName == "[null]") objvQuestionnaireEN.CourseChapterName = null; //课程章节名称
if (objvQuestionnaireEN.ChapterId == "[null]") objvQuestionnaireEN.ChapterId = null; //章Id
if (objvQuestionnaireEN.SectionId == "[null]") objvQuestionnaireEN.SectionId = null; //节Id
if (objvQuestionnaireEN.ChapterName == "[null]") objvQuestionnaireEN.ChapterName = null; //章名
if (objvQuestionnaireEN.SectionName == "[null]") objvQuestionnaireEN.SectionName = null; //节名
if (objvQuestionnaireEN.ChapterNameSim == "[null]") objvQuestionnaireEN.ChapterNameSim = null; //章名简称
if (objvQuestionnaireEN.SectionNameSim == "[null]") objvQuestionnaireEN.SectionNameSim = null; //节名简称
if (objvQuestionnaireEN.ParentNodeId == "[null]") objvQuestionnaireEN.ParentNodeId = null; //父节点编号
if (objvQuestionnaireEN.CourseChapterReferred == "[null]") objvQuestionnaireEN.CourseChapterReferred = null; //节简称
if (objvQuestionnaireEN.ParentNodeName == "[null]") objvQuestionnaireEN.ParentNodeName = null; //父节点名称
if (objvQuestionnaireEN.ParentNodeReferred == "[null]") objvQuestionnaireEN.ParentNodeReferred = null; //章简称
if (objvQuestionnaireEN.QuestionTypeId == "[null]") objvQuestionnaireEN.QuestionTypeId = null; //题目类型Id
if (objvQuestionnaireEN.QuestionTypeName == "[null]") objvQuestionnaireEN.QuestionTypeName = null; //题目类型名
if (objvQuestionnaireEN.QuestionTypeName4Course == "[null]") objvQuestionnaireEN.QuestionTypeName4Course = null; //题目类型名4课程
if (objvQuestionnaireEN.AnswerTypeId == "[null]") objvQuestionnaireEN.AnswerTypeId = null; //答案类型ID
if (objvQuestionnaireEN.AnswerTypeName == "[null]") objvQuestionnaireEN.AnswerTypeName = null; //答案类型名
if (objvQuestionnaireEN.GridTitle == "[null]") objvQuestionnaireEN.GridTitle = null; //表格标题
if (objvQuestionnaireEN.AnswerModeId == "[null]") objvQuestionnaireEN.AnswerModeId = null; //答案模式Id
if (objvQuestionnaireEN.AnswerModeName == "[null]") objvQuestionnaireEN.AnswerModeName = null; //答案模式名称
if (objvQuestionnaireEN.DefaultValue == "[null]") objvQuestionnaireEN.DefaultValue = null; //缺省值
if (objvQuestionnaireEN.DefaultSelectItem == "[null]") objvQuestionnaireEN.DefaultSelectItem = null; //默认选项
if (objvQuestionnaireEN.LimitedResourceType == "[null]") objvQuestionnaireEN.LimitedResourceType = null; //限制资源类型
if (objvQuestionnaireEN.ExamGradeId == "[null]") objvQuestionnaireEN.ExamGradeId = null; //题库等级ID
if (objvQuestionnaireEN.ExamGradeName == "[null]") objvQuestionnaireEN.ExamGradeName = null; //题库等级名
if (objvQuestionnaireEN.TextDirectId == "[null]") objvQuestionnaireEN.TextDirectId = null; //文本方向ID
if (objvQuestionnaireEN.Memo == "[null]") objvQuestionnaireEN.Memo = null; //备注
if (objvQuestionnaireEN.CodeTab == "[null]") objvQuestionnaireEN.CodeTab = null; //代码表
if (objvQuestionnaireEN.CodeTabCode == "[null]") objvQuestionnaireEN.CodeTabCode = null; //CodeTab_Code
if (objvQuestionnaireEN.CodeTabCondition == "[null]") objvQuestionnaireEN.CodeTabCondition = null; //代码表_条件
if (objvQuestionnaireEN.CodeTabName == "[null]") objvQuestionnaireEN.CodeTabName = null; //CodeTab_Name
if (objvQuestionnaireEN.CourseIdChapter == "[null]") objvQuestionnaireEN.CourseIdChapter = null; //CourseId_Chapter
if (objvQuestionnaireEN.QuestionNameAdd == "[null]") objvQuestionnaireEN.QuestionNameAdd = null; //题目补充
if (objvQuestionnaireEN.DifficultyLevelId == "[null]") objvQuestionnaireEN.DifficultyLevelId = null; //难度等级Id
if (objvQuestionnaireEN.KnowledgeGraphId == "[null]") objvQuestionnaireEN.KnowledgeGraphId = null; //知识点图Id
if (objvQuestionnaireEN.QuestionCode == "[null]") objvQuestionnaireEN.QuestionCode = null; //html代码
if (objvQuestionnaireEN.SectionTypeId == "[null]") objvQuestionnaireEN.SectionTypeId = null; //节点类型Id
if (objvQuestionnaireEN.RelaEvent == "[null]") objvQuestionnaireEN.RelaEvent = null; //相关事件
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
public static void CheckProperty4Condition(clsvQuestionnaireEN objvQuestionnaireEN)
{
 vQuestionnaireDA.CheckProperty4Condition(objvQuestionnaireEN);
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
string strCondition = string.Format("1 =1 Order By {0}", convQuestionnaire.QuestionId); 
List<clsvQuestionnaireEN> arrObjLst = clsvQuestionnaireBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQuestionnaireEN objvQuestionnaireEN = new clsvQuestionnaireEN()
{
QuestionId = 0,
QuestionName = "选[v题目]..."
};
arrObjLstSel.Insert(0, objvQuestionnaireEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQuestionnaire.QuestionId;
objComboBox.DisplayMember = convQuestionnaire.QuestionName;
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v题目]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convQuestionnaire.QuestionId); 
IEnumerable<clsvQuestionnaireEN> arrObjLst = clsvQuestionnaireBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
objDDL.DataValueField = convQuestionnaire.QuestionId;
objDDL.DataTextField = convQuestionnaire.QuestionName;
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v题目]...","0");
List<clsvQuestionnaireEN> arrvQuestionnaireObjLst = GetAllvQuestionnaireObjLstCache(strCourseId); 
objDDL.DataValueField = convQuestionnaire.QuestionId;
objDDL.DataTextField = convQuestionnaire.QuestionName;
objDDL.DataSource = arrvQuestionnaireObjLst;
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
//string strWhereCond = string.Format("1 = 1 order by QuestionId");
//if (arrvQuestionnaireObjLstCache == null)
//{
//arrvQuestionnaireObjLstCache = vQuestionnaireDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngQuestionId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionnaireEN GetObjByQuestionIdCache(long lngQuestionId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvQuestionnaireEN._CurrTabName, strCourseId);
List<clsvQuestionnaireEN> arrvQuestionnaireObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionnaireEN> arrvQuestionnaireObjLst_Sel =
arrvQuestionnaireObjLstCache
.Where(x=> x.QuestionId == lngQuestionId 
);
if (arrvQuestionnaireObjLst_Sel.Count() == 0)
{
   clsvQuestionnaireEN obj = clsvQuestionnaireBL.GetObjByQuestionId(lngQuestionId);
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
return arrvQuestionnaireObjLst_Sel.First();
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
clsvQuestionnaireEN objvQuestionnaire = GetObjByQuestionIdCache(lngQuestionId, strCourseId);
if (objvQuestionnaire == null) return "";
return objvQuestionnaire.QuestionName;
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
clsvQuestionnaireEN objvQuestionnaire = GetObjByQuestionIdCache(lngQuestionId, strCourseId);
if (objvQuestionnaire == null) return "";
return objvQuestionnaire.QuestionName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionnaireEN> GetAllvQuestionnaireObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvQuestionnaireEN> arrvQuestionnaireObjLstCache = GetObjLstCache(strCourseId); 
return arrvQuestionnaireObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionnaireEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvQuestionnaireEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvQuestionnaireEN> arrvQuestionnaireObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvQuestionnaireObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvQuestionnaireEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsvQuestionnaireEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvQuestionnaireEN._RefreshTimeLst.Count == 0) return "";
return clsvQuestionnaireEN._RefreshTimeLst[clsvQuestionnaireEN._RefreshTimeLst.Count - 1];
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
if (strInFldName != convQuestionnaire.QuestionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQuestionnaire.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQuestionnaire.AttributeName));
throw new Exception(strMsg);
}
var objvQuestionnaire = clsvQuestionnaireBL.GetObjByQuestionIdCache(lngQuestionId, strCourseId);
if (objvQuestionnaire == null) return "";
return objvQuestionnaire[strOutFldName].ToString();
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
int intRecCount = clsvQuestionnaireDA.GetRecCount(strTabName);
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
int intRecCount = clsvQuestionnaireDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQuestionnaireDA.GetRecCount();
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
int intRecCount = clsvQuestionnaireDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQuestionnaireCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQuestionnaireEN objvQuestionnaireCond)
{
 string strCourseId = objvQuestionnaireCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvQuestionnaireBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvQuestionnaireEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionnaireEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionnaire.AttributeName)
{
if (objvQuestionnaireCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionnaireCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaireCond[strFldName].ToString());
}
else
{
if (objvQuestionnaireCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionnaireCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaireCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionnaireCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionnaireCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionnaireCond[strFldName]));
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
 List<string> arrList = clsvQuestionnaireDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQuestionnaireDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQuestionnaireDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}