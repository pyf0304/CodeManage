
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaire4AppWApi
 表名:vQuestionnaire4App(01120221)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:05
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
public static class clsvQuestionnaire4AppWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetQuestionID(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convQuestionnaire4App.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convQuestionnaire4App.QuestionID);
objvQuestionnaire4AppEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.QuestionID) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.QuestionID, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.QuestionID] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetQuestionIndex(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, int intQuestionIndex, string strComparisonOp="")
	{
objvQuestionnaire4AppEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.QuestionIndex) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.QuestionIndex, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.QuestionIndex] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetQuestionName(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convQuestionnaire4App.QuestionName);
objvQuestionnaire4AppEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.QuestionName) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.QuestionName, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.QuestionName] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetQuestionNo(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strQuestionNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, convQuestionnaire4App.QuestionNo);
objvQuestionnaire4AppEN.QuestionNo = strQuestionNo; //题目编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.QuestionNo) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.QuestionNo, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.QuestionNo] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetCourseId(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convQuestionnaire4App.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convQuestionnaire4App.CourseId);
objvQuestionnaire4AppEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.CourseId) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.CourseId, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.CourseId] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetCourseCode(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convQuestionnaire4App.CourseCode);
objvQuestionnaire4AppEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.CourseCode) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.CourseCode, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.CourseCode] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetCourseName(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convQuestionnaire4App.CourseName);
objvQuestionnaire4AppEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.CourseName) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.CourseName, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.CourseName] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetCourseChapterId(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convQuestionnaire4App.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convQuestionnaire4App.CourseChapterId);
objvQuestionnaire4AppEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.CourseChapterId) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.CourseChapterId, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.CourseChapterId] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetChapterId(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, convQuestionnaire4App.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convQuestionnaire4App.ChapterId);
objvQuestionnaire4AppEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.ChapterId) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.ChapterId, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.ChapterId] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetSectionId(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionId, 8, convQuestionnaire4App.SectionId);
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convQuestionnaire4App.SectionId);
objvQuestionnaire4AppEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.SectionId) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.SectionId, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.SectionId] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetChapterName(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convQuestionnaire4App.ChapterName);
objvQuestionnaire4AppEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.ChapterName) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.ChapterName, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.ChapterName] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetSectionName(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convQuestionnaire4App.SectionName);
objvQuestionnaire4AppEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.SectionName) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.SectionName, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.SectionName] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetChapterName_Sim(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convQuestionnaire4App.ChapterName_Sim);
objvQuestionnaire4AppEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.ChapterName_Sim) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.ChapterName_Sim, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.ChapterName_Sim] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetSectionName_Sim(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convQuestionnaire4App.SectionName_Sim);
objvQuestionnaire4AppEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.SectionName_Sim) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.SectionName_Sim, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.SectionName_Sim] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetParentNodeID(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convQuestionnaire4App.ParentNodeID);
objvQuestionnaire4AppEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.ParentNodeID) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.ParentNodeID, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.ParentNodeID] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetQuestionTypeId(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convQuestionnaire4App.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convQuestionnaire4App.QuestionTypeId);
objvQuestionnaire4AppEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.QuestionTypeId) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.QuestionTypeId, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.QuestionTypeId] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetQuestionTypeName(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convQuestionnaire4App.QuestionTypeName);
objvQuestionnaire4AppEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.QuestionTypeName) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.QuestionTypeName, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.QuestionTypeName] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetExamGradeId(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strExamGradeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamGradeId, 2, convQuestionnaire4App.ExamGradeId);
clsCheckSql.CheckFieldForeignKey(strExamGradeId, 2, convQuestionnaire4App.ExamGradeId);
objvQuestionnaire4AppEN.ExamGradeId = strExamGradeId; //题库等级ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.ExamGradeId) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.ExamGradeId, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.ExamGradeId] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetExamGradeName(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strExamGradeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamGradeName, 50, convQuestionnaire4App.ExamGradeName);
objvQuestionnaire4AppEN.ExamGradeName = strExamGradeName; //题库等级名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.ExamGradeName) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.ExamGradeName, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.ExamGradeName] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetAnswerTypeId(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convQuestionnaire4App.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convQuestionnaire4App.AnswerTypeId);
objvQuestionnaire4AppEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.AnswerTypeId) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.AnswerTypeId, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.AnswerTypeId] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetQuestionScore(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, float fltQuestionScore, string strComparisonOp="")
	{
objvQuestionnaire4AppEN.QuestionScore = fltQuestionScore; //题目得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.QuestionScore) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.QuestionScore, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.QuestionScore] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetUpdDate(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQuestionnaire4App.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQuestionnaire4App.UpdDate);
objvQuestionnaire4AppEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.UpdDate) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.UpdDate, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.UpdDate] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetOptionNum(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, int intOptionNum, string strComparisonOp="")
	{
objvQuestionnaire4AppEN.OptionNum = intOptionNum; //选项数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.OptionNum) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.OptionNum, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.OptionNum] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetChapterOrderNum(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, int intChapterOrderNum, string strComparisonOp="")
	{
objvQuestionnaire4AppEN.ChapterOrderNum = intChapterOrderNum; //章排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.ChapterOrderNum) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.ChapterOrderNum, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.ChapterOrderNum] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionnaire4AppEN objvQuestionnaire4App_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.QuestionID, objvQuestionnaire4App_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire4App.QuestionIndex, objvQuestionnaire4App_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.QuestionName, objvQuestionnaire4App_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.QuestionNo) == true)
{
string strComparisonOp_QuestionNo = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.QuestionNo, objvQuestionnaire4App_Cond.QuestionNo, strComparisonOp_QuestionNo);
}
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.CourseId) == true)
{
string strComparisonOp_CourseId = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.CourseId, objvQuestionnaire4App_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.CourseCode, objvQuestionnaire4App_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.CourseName) == true)
{
string strComparisonOp_CourseName = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.CourseName, objvQuestionnaire4App_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.CourseChapterId, objvQuestionnaire4App_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.ChapterId) == true)
{
string strComparisonOp_ChapterId = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.ChapterId, objvQuestionnaire4App_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.SectionId) == true)
{
string strComparisonOp_SectionId = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.SectionId, objvQuestionnaire4App_Cond.SectionId, strComparisonOp_SectionId);
}
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.ChapterName, objvQuestionnaire4App_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.SectionName) == true)
{
string strComparisonOp_SectionName = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.SectionName, objvQuestionnaire4App_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.ChapterName_Sim, objvQuestionnaire4App_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.SectionName_Sim, objvQuestionnaire4App_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.ParentNodeID, objvQuestionnaire4App_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.QuestionTypeId, objvQuestionnaire4App_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.QuestionTypeName, objvQuestionnaire4App_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.ExamGradeId) == true)
{
string strComparisonOp_ExamGradeId = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.ExamGradeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.ExamGradeId, objvQuestionnaire4App_Cond.ExamGradeId, strComparisonOp_ExamGradeId);
}
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.ExamGradeName) == true)
{
string strComparisonOp_ExamGradeName = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.ExamGradeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.ExamGradeName, objvQuestionnaire4App_Cond.ExamGradeName, strComparisonOp_ExamGradeName);
}
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.AnswerTypeId) == true)
{
string strComparisonOp_AnswerTypeId = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.AnswerTypeId, objvQuestionnaire4App_Cond.AnswerTypeId, strComparisonOp_AnswerTypeId);
}
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.QuestionScore) == true)
{
string strComparisonOp_QuestionScore = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.QuestionScore];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire4App.QuestionScore, objvQuestionnaire4App_Cond.QuestionScore, strComparisonOp_QuestionScore);
}
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.UpdDate, objvQuestionnaire4App_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.OptionNum) == true)
{
string strComparisonOp_OptionNum = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.OptionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire4App.OptionNum, objvQuestionnaire4App_Cond.OptionNum, strComparisonOp_OptionNum);
}
if (objvQuestionnaire4App_Cond.IsUpdated(convQuestionnaire4App.ChapterOrderNum) == true)
{
string strComparisonOp_ChapterOrderNum = objvQuestionnaire4App_Cond.dicFldComparisonOp[convQuestionnaire4App.ChapterOrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire4App.ChapterOrderNum, objvQuestionnaire4App_Cond.ChapterOrderNum, strComparisonOp_ChapterOrderNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v题目表4App(vQuestionnaire4App)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionnaire4AppWApi
{
private static readonly string mstrApiControllerName = "vQuestionnaire4AppApi";

 public clsvQuestionnaire4AppWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v题目表4App]...","0");
List<clsvQuestionnaire4AppEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", convQuestionnaire4App.QuestionID); 
List<clsvQuestionnaire4AppEN> arrObjLst = clsvQuestionnaire4AppWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = new clsvQuestionnaire4AppEN()
{
QuestionID = "0",
QuestionName = "选[v题目表4App]..."
};
arrObjLst.Insert(0, objvQuestionnaire4AppEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQuestionnaire4App.QuestionID;
objComboBox.DisplayMember = convQuestionnaire4App.QuestionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQuestionID">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaire4AppEN GetObjByQuestionID(string strQuestionID)
{
string strAction = "GetObjByQuestionID";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = null;
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
objvQuestionnaire4AppEN = JsonConvert.DeserializeObject<clsvQuestionnaire4AppEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionnaire4AppEN;
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
public static clsvQuestionnaire4AppEN GetObjByQuestionID_WA_Cache(string strQuestionID, string strCourseId)
{
string strAction = "GetObjByQuestionID_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = null;
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
objvQuestionnaire4AppEN = JsonConvert.DeserializeObject<clsvQuestionnaire4AppEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionnaire4AppEN;
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
public static clsvQuestionnaire4AppEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = null;
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
objvQuestionnaire4AppEN = JsonConvert.DeserializeObject<clsvQuestionnaire4AppEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionnaire4AppEN;
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
public static clsvQuestionnaire4AppEN GetObjByQuestionID_Cache(string strQuestionID, string strCourseId)
{
if (string.IsNullOrEmpty(strQuestionID) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvQuestionnaire4AppEN._CurrTabName_S, strCourseId);
List<clsvQuestionnaire4AppEN> arrvQuestionnaire4AppObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvQuestionnaire4AppEN> arrvQuestionnaire4AppObjLst_Sel =
from objvQuestionnaire4AppEN in arrvQuestionnaire4AppObjLst_Cache
where objvQuestionnaire4AppEN.QuestionID == strQuestionID
select objvQuestionnaire4AppEN;
if (arrvQuestionnaire4AppObjLst_Sel.Count() == 0)
{
   clsvQuestionnaire4AppEN obj = clsvQuestionnaire4AppWApi.GetObjByQuestionID(strQuestionID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvQuestionnaire4AppObjLst_Sel.First();
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
string strKey = string.Format("{0}_{1}", clsvQuestionnaire4AppEN._CurrTabName_S, strCourseId);
List<clsvQuestionnaire4AppEN> arrvQuestionnaire4AppObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvQuestionnaire4AppEN> arrvQuestionnaire4AppObjLst_Sel1 =
from objvQuestionnaire4AppEN in arrvQuestionnaire4AppObjLst_Cache
where objvQuestionnaire4AppEN.QuestionID == strQuestionID
select objvQuestionnaire4AppEN;
List <clsvQuestionnaire4AppEN> arrvQuestionnaire4AppObjLst_Sel = new List<clsvQuestionnaire4AppEN>();
foreach (clsvQuestionnaire4AppEN obj in arrvQuestionnaire4AppObjLst_Sel1)
{
arrvQuestionnaire4AppObjLst_Sel.Add(obj);
}
if (arrvQuestionnaire4AppObjLst_Sel.Count > 0)
{
return arrvQuestionnaire4AppObjLst_Sel[0].QuestionName;
}
string strErrMsgForGetObjById = string.Format("在vQuestionnaire4App对象缓存列表中,找不到记录[QuestionID = {0}](函数:{1})", strQuestionID, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvQuestionnaire4AppBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
string strKey = string.Format("{0}_{1}", clsvQuestionnaire4AppEN._CurrTabName_S, strCourseId);
List<clsvQuestionnaire4AppEN> arrvQuestionnaire4AppObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvQuestionnaire4AppEN> arrvQuestionnaire4AppObjLst_Sel1 =
from objvQuestionnaire4AppEN in arrvQuestionnaire4AppObjLst_Cache
where objvQuestionnaire4AppEN.QuestionID == strQuestionID
select objvQuestionnaire4AppEN;
List <clsvQuestionnaire4AppEN> arrvQuestionnaire4AppObjLst_Sel = new List<clsvQuestionnaire4AppEN>();
foreach (clsvQuestionnaire4AppEN obj in arrvQuestionnaire4AppObjLst_Sel1)
{
arrvQuestionnaire4AppObjLst_Sel.Add(obj);
}
if (arrvQuestionnaire4AppObjLst_Sel.Count > 0)
{
return arrvQuestionnaire4AppObjLst_Sel[0].QuestionName;
}
string strErrMsgForGetObjById = string.Format("在vQuestionnaire4App对象缓存列表中,找不到记录的相关名称[QuestionID = {0}](函数:{1})", strQuestionID, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvQuestionnaire4AppBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaire4AppEN> GetObjLst(string strWhereCond)
{
 List<clsvQuestionnaire4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaire4AppEN> GetObjLstByQuestionIDLst(List<string> arrQuestionID)
{
 List<clsvQuestionnaire4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvQuestionnaire4AppEN> GetObjLstByQuestionIDLst_Cache(List<string> arrQuestionID, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvQuestionnaire4AppEN._CurrTabName_S, strCourseId);
List<clsvQuestionnaire4AppEN> arrvQuestionnaire4AppObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvQuestionnaire4AppEN> arrvQuestionnaire4AppObjLst_Sel =
from objvQuestionnaire4AppEN in arrvQuestionnaire4AppObjLst_Cache
where arrQuestionID.Contains(objvQuestionnaire4AppEN.QuestionID)
select objvQuestionnaire4AppEN;
return arrvQuestionnaire4AppObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaire4AppEN> GetObjLstByQuestionIDLst_WA_Cache(List<string> arrQuestionID, string strCourseId)
{
 List<clsvQuestionnaire4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaire4AppEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQuestionnaire4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaire4AppEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQuestionnaire4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaire4AppEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQuestionnaire4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaire4AppEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvQuestionnaire4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvQuestionnaire4AppENS">源对象</param>
 /// <param name = "objvQuestionnaire4AppENT">目标对象</param>
 public static void CopyTo(clsvQuestionnaire4AppEN objvQuestionnaire4AppENS, clsvQuestionnaire4AppEN objvQuestionnaire4AppENT)
{
try
{
objvQuestionnaire4AppENT.QuestionID = objvQuestionnaire4AppENS.QuestionID; //题目ID
objvQuestionnaire4AppENT.QuestionIndex = objvQuestionnaire4AppENS.QuestionIndex; //题目序号
objvQuestionnaire4AppENT.QuestionName = objvQuestionnaire4AppENS.QuestionName; //题目名称
objvQuestionnaire4AppENT.QuestionNo = objvQuestionnaire4AppENS.QuestionNo; //题目编号
objvQuestionnaire4AppENT.CourseId = objvQuestionnaire4AppENS.CourseId; //课程Id
objvQuestionnaire4AppENT.CourseCode = objvQuestionnaire4AppENS.CourseCode; //课程代码
objvQuestionnaire4AppENT.CourseName = objvQuestionnaire4AppENS.CourseName; //课程名称
objvQuestionnaire4AppENT.CourseChapterId = objvQuestionnaire4AppENS.CourseChapterId; //课程章节ID
objvQuestionnaire4AppENT.ChapterId = objvQuestionnaire4AppENS.ChapterId; //章Id
objvQuestionnaire4AppENT.SectionId = objvQuestionnaire4AppENS.SectionId; //节Id
objvQuestionnaire4AppENT.ChapterName = objvQuestionnaire4AppENS.ChapterName; //章名
objvQuestionnaire4AppENT.SectionName = objvQuestionnaire4AppENS.SectionName; //节名
objvQuestionnaire4AppENT.ChapterName_Sim = objvQuestionnaire4AppENS.ChapterName_Sim; //章名简称
objvQuestionnaire4AppENT.SectionName_Sim = objvQuestionnaire4AppENS.SectionName_Sim; //节名简称
objvQuestionnaire4AppENT.ParentNodeID = objvQuestionnaire4AppENS.ParentNodeID; //父节点编号
objvQuestionnaire4AppENT.QuestionTypeId = objvQuestionnaire4AppENS.QuestionTypeId; //题目类型Id
objvQuestionnaire4AppENT.QuestionTypeName = objvQuestionnaire4AppENS.QuestionTypeName; //题目类型名
objvQuestionnaire4AppENT.ExamGradeId = objvQuestionnaire4AppENS.ExamGradeId; //题库等级ID
objvQuestionnaire4AppENT.ExamGradeName = objvQuestionnaire4AppENS.ExamGradeName; //题库等级名
objvQuestionnaire4AppENT.AnswerTypeId = objvQuestionnaire4AppENS.AnswerTypeId; //答案类型ID
objvQuestionnaire4AppENT.QuestionScore = objvQuestionnaire4AppENS.QuestionScore; //题目得分
objvQuestionnaire4AppENT.UpdDate = objvQuestionnaire4AppENS.UpdDate; //修改日期
objvQuestionnaire4AppENT.OptionNum = objvQuestionnaire4AppENS.OptionNum; //选项数
objvQuestionnaire4AppENT.ChapterOrderNum = objvQuestionnaire4AppENS.ChapterOrderNum; //章排序号
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
public static DataTable ToDataTable(List<clsvQuestionnaire4AppEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQuestionnaire4AppEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQuestionnaire4AppEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQuestionnaire4AppEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQuestionnaire4AppEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQuestionnaire4AppEN.AttributeName)
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
//if (arrvQuestionnaire4AppObjLst_Cache == null)
//{
//arrvQuestionnaire4AppObjLst_Cache = await clsvQuestionnaire4AppWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvQuestionnaire4AppEN._CurrTabName_S, strCourseId);
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
public static List<clsvQuestionnaire4AppEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvQuestionnaire4AppEN._CurrTabName_S, strCourseId);
List<clsvQuestionnaire4AppEN> arrvQuestionnaire4AppObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvQuestionnaire4AppObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQuestionnaire4AppEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQuestionnaire4App.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionnaire4App.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App.QuestionNo, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App.SectionId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App.ExamGradeId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App.ExamGradeName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App.AnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App.QuestionScore, Type.GetType("System.Single"));
objDT.Columns.Add(convQuestionnaire4App.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App.OptionNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionnaire4App.ChapterOrderNum, Type.GetType("System.Int32"));
foreach (clsvQuestionnaire4AppEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQuestionnaire4App.QuestionID] = objInFor[convQuestionnaire4App.QuestionID];
objDR[convQuestionnaire4App.QuestionIndex] = objInFor[convQuestionnaire4App.QuestionIndex];
objDR[convQuestionnaire4App.QuestionName] = objInFor[convQuestionnaire4App.QuestionName];
objDR[convQuestionnaire4App.QuestionNo] = objInFor[convQuestionnaire4App.QuestionNo];
objDR[convQuestionnaire4App.CourseId] = objInFor[convQuestionnaire4App.CourseId];
objDR[convQuestionnaire4App.CourseCode] = objInFor[convQuestionnaire4App.CourseCode];
objDR[convQuestionnaire4App.CourseName] = objInFor[convQuestionnaire4App.CourseName];
objDR[convQuestionnaire4App.CourseChapterId] = objInFor[convQuestionnaire4App.CourseChapterId];
objDR[convQuestionnaire4App.ChapterId] = objInFor[convQuestionnaire4App.ChapterId];
objDR[convQuestionnaire4App.SectionId] = objInFor[convQuestionnaire4App.SectionId];
objDR[convQuestionnaire4App.ChapterName] = objInFor[convQuestionnaire4App.ChapterName];
objDR[convQuestionnaire4App.SectionName] = objInFor[convQuestionnaire4App.SectionName];
objDR[convQuestionnaire4App.ChapterName_Sim] = objInFor[convQuestionnaire4App.ChapterName_Sim];
objDR[convQuestionnaire4App.SectionName_Sim] = objInFor[convQuestionnaire4App.SectionName_Sim];
objDR[convQuestionnaire4App.ParentNodeID] = objInFor[convQuestionnaire4App.ParentNodeID];
objDR[convQuestionnaire4App.QuestionTypeId] = objInFor[convQuestionnaire4App.QuestionTypeId];
objDR[convQuestionnaire4App.QuestionTypeName] = objInFor[convQuestionnaire4App.QuestionTypeName];
objDR[convQuestionnaire4App.ExamGradeId] = objInFor[convQuestionnaire4App.ExamGradeId];
objDR[convQuestionnaire4App.ExamGradeName] = objInFor[convQuestionnaire4App.ExamGradeName];
objDR[convQuestionnaire4App.AnswerTypeId] = objInFor[convQuestionnaire4App.AnswerTypeId];
objDR[convQuestionnaire4App.QuestionScore] = objInFor[convQuestionnaire4App.QuestionScore];
objDR[convQuestionnaire4App.UpdDate] = objInFor[convQuestionnaire4App.UpdDate];
objDR[convQuestionnaire4App.OptionNum] = objInFor[convQuestionnaire4App.OptionNum];
objDR[convQuestionnaire4App.ChapterOrderNum] = objInFor[convQuestionnaire4App.ChapterOrderNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}