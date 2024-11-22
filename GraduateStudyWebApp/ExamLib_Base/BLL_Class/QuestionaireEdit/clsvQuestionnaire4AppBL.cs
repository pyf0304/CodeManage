
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaire4AppBL
 表名:vQuestionnaire4App(01120221)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:29:44
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
public static class  clsvQuestionnaire4AppBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaire4AppEN GetObj(this K_QuestionId_vQuestionnaire4App myKey)
{
clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = clsvQuestionnaire4AppBL.vQuestionnaire4AppDA.GetObjByQuestionId(myKey.Value);
return objvQuestionnaire4AppEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetQuestionId(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, long lngQuestionId, string strComparisonOp="")
	{
objvQuestionnaire4AppEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.QuestionId) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.QuestionId, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.QuestionId] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetQuestionIndex(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, int? intQuestionIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetQuestionName(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strQuestionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionName, 500, convQuestionnaire4App.QuestionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetQuestionNo(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strQuestionNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, convQuestionnaire4App.QuestionNo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetCourseId(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convQuestionnaire4App.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convQuestionnaire4App.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetCourseCode(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convQuestionnaire4App.CourseCode);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetCourseName(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convQuestionnaire4App.CourseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetCourseChapterId(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convQuestionnaire4App.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convQuestionnaire4App.CourseChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetChapterId(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterId, 8, convQuestionnaire4App.ChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convQuestionnaire4App.ChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetSectionId(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, convQuestionnaire4App.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convQuestionnaire4App.SectionId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetChapterName(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterName, 100, convQuestionnaire4App.ChapterName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetSectionName(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convQuestionnaire4App.SectionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetChapterNameSim(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, convQuestionnaire4App.ChapterNameSim);
}
objvQuestionnaire4AppEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.ChapterNameSim) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.ChapterNameSim, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.ChapterNameSim] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetSectionNameSim(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strSectionNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionNameSim, 10, convQuestionnaire4App.SectionNameSim);
}
objvQuestionnaire4AppEN.SectionNameSim = strSectionNameSim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.SectionNameSim) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.SectionNameSim, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.SectionNameSim] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetParentNodeId(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strParentNodeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeId, 8, convQuestionnaire4App.ParentNodeId);
}
objvQuestionnaire4AppEN.ParentNodeId = strParentNodeId; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4AppEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App.ParentNodeId) == false)
{
objvQuestionnaire4AppEN.dicFldComparisonOp.Add(convQuestionnaire4App.ParentNodeId, strComparisonOp);
}
else
{
objvQuestionnaire4AppEN.dicFldComparisonOp[convQuestionnaire4App.ParentNodeId] = strComparisonOp;
}
}
return objvQuestionnaire4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetQuestionTypeId(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convQuestionnaire4App.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convQuestionnaire4App.QuestionTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetQuestionTypeName(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strQuestionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convQuestionnaire4App.QuestionTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetExamGradeId(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strExamGradeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamGradeId, 2, convQuestionnaire4App.ExamGradeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExamGradeId, 2, convQuestionnaire4App.ExamGradeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetExamGradeName(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strExamGradeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamGradeName, 50, convQuestionnaire4App.ExamGradeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetAnswerTypeId(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strAnswerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convQuestionnaire4App.AnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convQuestionnaire4App.AnswerTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetQuestionScore(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, float? fltQuestionScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetUpdDate(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQuestionnaire4App.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQuestionnaire4App.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetOptionNum(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, int? intOptionNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4AppEN SetChapterOrderNum(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN, int? intChapterOrderNum, string strComparisonOp="")
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppENS">源对象</param>
 /// <param name = "objvQuestionnaire4AppENT">目标对象</param>
 public static void CopyTo(this clsvQuestionnaire4AppEN objvQuestionnaire4AppENS, clsvQuestionnaire4AppEN objvQuestionnaire4AppENT)
{
try
{
objvQuestionnaire4AppENT.QuestionId = objvQuestionnaire4AppENS.QuestionId; //题目Id
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
objvQuestionnaire4AppENT.ChapterNameSim = objvQuestionnaire4AppENS.ChapterNameSim; //章名简称
objvQuestionnaire4AppENT.SectionNameSim = objvQuestionnaire4AppENS.SectionNameSim; //节名简称
objvQuestionnaire4AppENT.ParentNodeId = objvQuestionnaire4AppENS.ParentNodeId; //父节点编号
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
 /// <param name = "objvQuestionnaire4AppENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionnaire4AppEN:objvQuestionnaire4AppENT</returns>
 public static clsvQuestionnaire4AppEN CopyTo(this clsvQuestionnaire4AppEN objvQuestionnaire4AppENS)
{
try
{
 clsvQuestionnaire4AppEN objvQuestionnaire4AppENT = new clsvQuestionnaire4AppEN()
{
QuestionId = objvQuestionnaire4AppENS.QuestionId, //题目Id
QuestionIndex = objvQuestionnaire4AppENS.QuestionIndex, //题目序号
QuestionName = objvQuestionnaire4AppENS.QuestionName, //题目名称
QuestionNo = objvQuestionnaire4AppENS.QuestionNo, //题目编号
CourseId = objvQuestionnaire4AppENS.CourseId, //课程Id
CourseCode = objvQuestionnaire4AppENS.CourseCode, //课程代码
CourseName = objvQuestionnaire4AppENS.CourseName, //课程名称
CourseChapterId = objvQuestionnaire4AppENS.CourseChapterId, //课程章节ID
ChapterId = objvQuestionnaire4AppENS.ChapterId, //章Id
SectionId = objvQuestionnaire4AppENS.SectionId, //节Id
ChapterName = objvQuestionnaire4AppENS.ChapterName, //章名
SectionName = objvQuestionnaire4AppENS.SectionName, //节名
ChapterNameSim = objvQuestionnaire4AppENS.ChapterNameSim, //章名简称
SectionNameSim = objvQuestionnaire4AppENS.SectionNameSim, //节名简称
ParentNodeId = objvQuestionnaire4AppENS.ParentNodeId, //父节点编号
QuestionTypeId = objvQuestionnaire4AppENS.QuestionTypeId, //题目类型Id
QuestionTypeName = objvQuestionnaire4AppENS.QuestionTypeName, //题目类型名
ExamGradeId = objvQuestionnaire4AppENS.ExamGradeId, //题库等级ID
ExamGradeName = objvQuestionnaire4AppENS.ExamGradeName, //题库等级名
AnswerTypeId = objvQuestionnaire4AppENS.AnswerTypeId, //答案类型ID
QuestionScore = objvQuestionnaire4AppENS.QuestionScore, //题目得分
UpdDate = objvQuestionnaire4AppENS.UpdDate, //修改日期
OptionNum = objvQuestionnaire4AppENS.OptionNum, //选项数
ChapterOrderNum = objvQuestionnaire4AppENS.ChapterOrderNum, //章排序号
};
 return objvQuestionnaire4AppENT;
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
public static void CheckProperty4Condition(this clsvQuestionnaire4AppEN objvQuestionnaire4AppEN)
{
 clsvQuestionnaire4AppBL.vQuestionnaire4AppDA.CheckProperty4Condition(objvQuestionnaire4AppEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionnaire4AppEN objvQuestionnaire4AppCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.QuestionId) == true)
{
string strComparisonOpQuestionId = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire4App.QuestionId, objvQuestionnaire4AppCond.QuestionId, strComparisonOpQuestionId);
}
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.QuestionIndex) == true)
{
string strComparisonOpQuestionIndex = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire4App.QuestionIndex, objvQuestionnaire4AppCond.QuestionIndex, strComparisonOpQuestionIndex);
}
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.QuestionName) == true)
{
string strComparisonOpQuestionName = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.QuestionName, objvQuestionnaire4AppCond.QuestionName, strComparisonOpQuestionName);
}
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.QuestionNo) == true)
{
string strComparisonOpQuestionNo = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.QuestionNo, objvQuestionnaire4AppCond.QuestionNo, strComparisonOpQuestionNo);
}
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.CourseId) == true)
{
string strComparisonOpCourseId = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.CourseId, objvQuestionnaire4AppCond.CourseId, strComparisonOpCourseId);
}
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.CourseCode) == true)
{
string strComparisonOpCourseCode = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.CourseCode, objvQuestionnaire4AppCond.CourseCode, strComparisonOpCourseCode);
}
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.CourseName) == true)
{
string strComparisonOpCourseName = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.CourseName, objvQuestionnaire4AppCond.CourseName, strComparisonOpCourseName);
}
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.CourseChapterId, objvQuestionnaire4AppCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.ChapterId) == true)
{
string strComparisonOpChapterId = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.ChapterId, objvQuestionnaire4AppCond.ChapterId, strComparisonOpChapterId);
}
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.SectionId) == true)
{
string strComparisonOpSectionId = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.SectionId, objvQuestionnaire4AppCond.SectionId, strComparisonOpSectionId);
}
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.ChapterName) == true)
{
string strComparisonOpChapterName = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.ChapterName, objvQuestionnaire4AppCond.ChapterName, strComparisonOpChapterName);
}
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.SectionName) == true)
{
string strComparisonOpSectionName = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.SectionName, objvQuestionnaire4AppCond.SectionName, strComparisonOpSectionName);
}
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.ChapterNameSim, objvQuestionnaire4AppCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.SectionNameSim) == true)
{
string strComparisonOpSectionNameSim = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.SectionNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.SectionNameSim, objvQuestionnaire4AppCond.SectionNameSim, strComparisonOpSectionNameSim);
}
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.ParentNodeId) == true)
{
string strComparisonOpParentNodeId = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.ParentNodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.ParentNodeId, objvQuestionnaire4AppCond.ParentNodeId, strComparisonOpParentNodeId);
}
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.QuestionTypeId, objvQuestionnaire4AppCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.QuestionTypeName) == true)
{
string strComparisonOpQuestionTypeName = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.QuestionTypeName, objvQuestionnaire4AppCond.QuestionTypeName, strComparisonOpQuestionTypeName);
}
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.ExamGradeId) == true)
{
string strComparisonOpExamGradeId = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.ExamGradeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.ExamGradeId, objvQuestionnaire4AppCond.ExamGradeId, strComparisonOpExamGradeId);
}
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.ExamGradeName) == true)
{
string strComparisonOpExamGradeName = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.ExamGradeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.ExamGradeName, objvQuestionnaire4AppCond.ExamGradeName, strComparisonOpExamGradeName);
}
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.AnswerTypeId) == true)
{
string strComparisonOpAnswerTypeId = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.AnswerTypeId, objvQuestionnaire4AppCond.AnswerTypeId, strComparisonOpAnswerTypeId);
}
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.QuestionScore) == true)
{
string strComparisonOpQuestionScore = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.QuestionScore];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire4App.QuestionScore, objvQuestionnaire4AppCond.QuestionScore, strComparisonOpQuestionScore);
}
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App.UpdDate, objvQuestionnaire4AppCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.OptionNum) == true)
{
string strComparisonOpOptionNum = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.OptionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire4App.OptionNum, objvQuestionnaire4AppCond.OptionNum, strComparisonOpOptionNum);
}
if (objvQuestionnaire4AppCond.IsUpdated(convQuestionnaire4App.ChapterOrderNum) == true)
{
string strComparisonOpChapterOrderNum = objvQuestionnaire4AppCond.dicFldComparisonOp[convQuestionnaire4App.ChapterOrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire4App.ChapterOrderNum, objvQuestionnaire4AppCond.ChapterOrderNum, strComparisonOpChapterOrderNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQuestionnaire4App
{
public virtual bool UpdRelaTabDate(long lngQuestionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v题目表4App(vQuestionnaire4App)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionnaire4AppBL
{
public static RelatedActions_vQuestionnaire4App relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQuestionnaire4AppDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQuestionnaire4AppDA vQuestionnaire4AppDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQuestionnaire4AppDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQuestionnaire4AppBL()
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
if (string.IsNullOrEmpty(clsvQuestionnaire4AppEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQuestionnaire4AppEN._ConnectString);
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
public static DataTable GetDataTable_vQuestionnaire4App(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQuestionnaire4AppDA.GetDataTable_vQuestionnaire4App(strWhereCond);
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
objDT = vQuestionnaire4AppDA.GetDataTable(strWhereCond);
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
objDT = vQuestionnaire4AppDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQuestionnaire4AppDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQuestionnaire4AppDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQuestionnaire4AppDA.GetDataTable_Top(objTopPara);
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
objDT = vQuestionnaire4AppDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQuestionnaire4AppDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQuestionnaire4AppDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvQuestionnaire4AppEN> GetObjLstByQuestionIdLst(List<long> arrQuestionIdLst)
{
List<clsvQuestionnaire4AppEN> arrObjLst = new List<clsvQuestionnaire4AppEN>(); 
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
	clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = new clsvQuestionnaire4AppEN();
try
{
objvQuestionnaire4AppEN.QuestionId = Int32.Parse(objRow[convQuestionnaire4App.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4AppEN.QuestionIndex = objRow[convQuestionnaire4App.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4AppEN.QuestionName = objRow[convQuestionnaire4App.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4AppEN.QuestionNo = objRow[convQuestionnaire4App.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4AppEN.CourseId = objRow[convQuestionnaire4App.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4AppEN.CourseCode = objRow[convQuestionnaire4App.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaire4AppEN.CourseName = objRow[convQuestionnaire4App.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire4AppEN.CourseChapterId = objRow[convQuestionnaire4App.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4AppEN.ChapterId = objRow[convQuestionnaire4App.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4AppEN.SectionId = objRow[convQuestionnaire4App.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionId].ToString().Trim(); //节Id
objvQuestionnaire4AppEN.ChapterName = objRow[convQuestionnaire4App.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4AppEN.SectionName = objRow[convQuestionnaire4App.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionName].ToString().Trim(); //节名
objvQuestionnaire4AppEN.ChapterNameSim = objRow[convQuestionnaire4App.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4AppEN.SectionNameSim = objRow[convQuestionnaire4App.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire4AppEN.ParentNodeId = objRow[convQuestionnaire4App.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire4AppEN.QuestionTypeId = objRow[convQuestionnaire4App.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire4AppEN.QuestionTypeName = objRow[convQuestionnaire4App.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire4AppEN.ExamGradeId = objRow[convQuestionnaire4App.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire4AppEN.ExamGradeName = objRow[convQuestionnaire4App.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire4AppEN.AnswerTypeId = objRow[convQuestionnaire4App.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire4AppEN.QuestionScore = objRow[convQuestionnaire4App.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire4App.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire4AppEN.UpdDate = objRow[convQuestionnaire4App.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire4AppEN.OptionNum = objRow[convQuestionnaire4App.OptionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.OptionNum].ToString().Trim()); //选项数
objvQuestionnaire4AppEN.ChapterOrderNum = objRow[convQuestionnaire4App.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.ChapterOrderNum].ToString().Trim()); //章排序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire4AppEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrQuestionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQuestionnaire4AppEN> GetObjLstByQuestionIdLstCache(List<long> arrQuestionIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvQuestionnaire4AppEN._CurrTabName, strCourseId);
List<clsvQuestionnaire4AppEN> arrvQuestionnaire4AppObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionnaire4AppEN> arrvQuestionnaire4AppObjLst_Sel =
arrvQuestionnaire4AppObjLstCache
.Where(x => arrQuestionIdLst.Contains(x.QuestionId));
return arrvQuestionnaire4AppObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaire4AppEN> GetObjLst(string strWhereCond)
{
List<clsvQuestionnaire4AppEN> arrObjLst = new List<clsvQuestionnaire4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = new clsvQuestionnaire4AppEN();
try
{
objvQuestionnaire4AppEN.QuestionId = Int32.Parse(objRow[convQuestionnaire4App.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4AppEN.QuestionIndex = objRow[convQuestionnaire4App.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4AppEN.QuestionName = objRow[convQuestionnaire4App.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4AppEN.QuestionNo = objRow[convQuestionnaire4App.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4AppEN.CourseId = objRow[convQuestionnaire4App.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4AppEN.CourseCode = objRow[convQuestionnaire4App.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaire4AppEN.CourseName = objRow[convQuestionnaire4App.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire4AppEN.CourseChapterId = objRow[convQuestionnaire4App.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4AppEN.ChapterId = objRow[convQuestionnaire4App.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4AppEN.SectionId = objRow[convQuestionnaire4App.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionId].ToString().Trim(); //节Id
objvQuestionnaire4AppEN.ChapterName = objRow[convQuestionnaire4App.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4AppEN.SectionName = objRow[convQuestionnaire4App.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionName].ToString().Trim(); //节名
objvQuestionnaire4AppEN.ChapterNameSim = objRow[convQuestionnaire4App.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4AppEN.SectionNameSim = objRow[convQuestionnaire4App.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire4AppEN.ParentNodeId = objRow[convQuestionnaire4App.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire4AppEN.QuestionTypeId = objRow[convQuestionnaire4App.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire4AppEN.QuestionTypeName = objRow[convQuestionnaire4App.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire4AppEN.ExamGradeId = objRow[convQuestionnaire4App.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire4AppEN.ExamGradeName = objRow[convQuestionnaire4App.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire4AppEN.AnswerTypeId = objRow[convQuestionnaire4App.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire4AppEN.QuestionScore = objRow[convQuestionnaire4App.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire4App.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire4AppEN.UpdDate = objRow[convQuestionnaire4App.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire4AppEN.OptionNum = objRow[convQuestionnaire4App.OptionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.OptionNum].ToString().Trim()); //选项数
objvQuestionnaire4AppEN.ChapterOrderNum = objRow[convQuestionnaire4App.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.ChapterOrderNum].ToString().Trim()); //章排序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire4AppEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire4AppEN);
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
public static List<clsvQuestionnaire4AppEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionnaire4AppEN> arrObjLst = new List<clsvQuestionnaire4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = new clsvQuestionnaire4AppEN();
try
{
objvQuestionnaire4AppEN.QuestionId = Int32.Parse(objRow[convQuestionnaire4App.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4AppEN.QuestionIndex = objRow[convQuestionnaire4App.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4AppEN.QuestionName = objRow[convQuestionnaire4App.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4AppEN.QuestionNo = objRow[convQuestionnaire4App.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4AppEN.CourseId = objRow[convQuestionnaire4App.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4AppEN.CourseCode = objRow[convQuestionnaire4App.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaire4AppEN.CourseName = objRow[convQuestionnaire4App.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire4AppEN.CourseChapterId = objRow[convQuestionnaire4App.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4AppEN.ChapterId = objRow[convQuestionnaire4App.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4AppEN.SectionId = objRow[convQuestionnaire4App.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionId].ToString().Trim(); //节Id
objvQuestionnaire4AppEN.ChapterName = objRow[convQuestionnaire4App.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4AppEN.SectionName = objRow[convQuestionnaire4App.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionName].ToString().Trim(); //节名
objvQuestionnaire4AppEN.ChapterNameSim = objRow[convQuestionnaire4App.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4AppEN.SectionNameSim = objRow[convQuestionnaire4App.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire4AppEN.ParentNodeId = objRow[convQuestionnaire4App.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire4AppEN.QuestionTypeId = objRow[convQuestionnaire4App.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire4AppEN.QuestionTypeName = objRow[convQuestionnaire4App.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire4AppEN.ExamGradeId = objRow[convQuestionnaire4App.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire4AppEN.ExamGradeName = objRow[convQuestionnaire4App.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire4AppEN.AnswerTypeId = objRow[convQuestionnaire4App.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire4AppEN.QuestionScore = objRow[convQuestionnaire4App.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire4App.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire4AppEN.UpdDate = objRow[convQuestionnaire4App.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire4AppEN.OptionNum = objRow[convQuestionnaire4App.OptionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.OptionNum].ToString().Trim()); //选项数
objvQuestionnaire4AppEN.ChapterOrderNum = objRow[convQuestionnaire4App.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.ChapterOrderNum].ToString().Trim()); //章排序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire4AppEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQuestionnaire4AppEN> GetSubObjLstCache(clsvQuestionnaire4AppEN objvQuestionnaire4AppCond)
{
 string strCourseId = objvQuestionnaire4AppCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvQuestionnaire4AppBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvQuestionnaire4AppEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionnaire4AppEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionnaire4App.AttributeName)
{
if (objvQuestionnaire4AppCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionnaire4AppCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaire4AppCond[strFldName].ToString());
}
else
{
if (objvQuestionnaire4AppCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionnaire4AppCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaire4AppCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionnaire4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionnaire4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionnaire4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionnaire4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionnaire4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionnaire4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionnaire4AppCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionnaire4AppCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionnaire4AppCond[strFldName]));
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
public static List<clsvQuestionnaire4AppEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQuestionnaire4AppEN> arrObjLst = new List<clsvQuestionnaire4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = new clsvQuestionnaire4AppEN();
try
{
objvQuestionnaire4AppEN.QuestionId = Int32.Parse(objRow[convQuestionnaire4App.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4AppEN.QuestionIndex = objRow[convQuestionnaire4App.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4AppEN.QuestionName = objRow[convQuestionnaire4App.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4AppEN.QuestionNo = objRow[convQuestionnaire4App.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4AppEN.CourseId = objRow[convQuestionnaire4App.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4AppEN.CourseCode = objRow[convQuestionnaire4App.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaire4AppEN.CourseName = objRow[convQuestionnaire4App.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire4AppEN.CourseChapterId = objRow[convQuestionnaire4App.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4AppEN.ChapterId = objRow[convQuestionnaire4App.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4AppEN.SectionId = objRow[convQuestionnaire4App.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionId].ToString().Trim(); //节Id
objvQuestionnaire4AppEN.ChapterName = objRow[convQuestionnaire4App.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4AppEN.SectionName = objRow[convQuestionnaire4App.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionName].ToString().Trim(); //节名
objvQuestionnaire4AppEN.ChapterNameSim = objRow[convQuestionnaire4App.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4AppEN.SectionNameSim = objRow[convQuestionnaire4App.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire4AppEN.ParentNodeId = objRow[convQuestionnaire4App.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire4AppEN.QuestionTypeId = objRow[convQuestionnaire4App.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire4AppEN.QuestionTypeName = objRow[convQuestionnaire4App.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire4AppEN.ExamGradeId = objRow[convQuestionnaire4App.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire4AppEN.ExamGradeName = objRow[convQuestionnaire4App.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire4AppEN.AnswerTypeId = objRow[convQuestionnaire4App.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire4AppEN.QuestionScore = objRow[convQuestionnaire4App.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire4App.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire4AppEN.UpdDate = objRow[convQuestionnaire4App.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire4AppEN.OptionNum = objRow[convQuestionnaire4App.OptionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.OptionNum].ToString().Trim()); //选项数
objvQuestionnaire4AppEN.ChapterOrderNum = objRow[convQuestionnaire4App.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.ChapterOrderNum].ToString().Trim()); //章排序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire4AppEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire4AppEN);
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
public static List<clsvQuestionnaire4AppEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQuestionnaire4AppEN> arrObjLst = new List<clsvQuestionnaire4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = new clsvQuestionnaire4AppEN();
try
{
objvQuestionnaire4AppEN.QuestionId = Int32.Parse(objRow[convQuestionnaire4App.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4AppEN.QuestionIndex = objRow[convQuestionnaire4App.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4AppEN.QuestionName = objRow[convQuestionnaire4App.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4AppEN.QuestionNo = objRow[convQuestionnaire4App.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4AppEN.CourseId = objRow[convQuestionnaire4App.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4AppEN.CourseCode = objRow[convQuestionnaire4App.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaire4AppEN.CourseName = objRow[convQuestionnaire4App.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire4AppEN.CourseChapterId = objRow[convQuestionnaire4App.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4AppEN.ChapterId = objRow[convQuestionnaire4App.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4AppEN.SectionId = objRow[convQuestionnaire4App.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionId].ToString().Trim(); //节Id
objvQuestionnaire4AppEN.ChapterName = objRow[convQuestionnaire4App.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4AppEN.SectionName = objRow[convQuestionnaire4App.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionName].ToString().Trim(); //节名
objvQuestionnaire4AppEN.ChapterNameSim = objRow[convQuestionnaire4App.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4AppEN.SectionNameSim = objRow[convQuestionnaire4App.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire4AppEN.ParentNodeId = objRow[convQuestionnaire4App.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire4AppEN.QuestionTypeId = objRow[convQuestionnaire4App.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire4AppEN.QuestionTypeName = objRow[convQuestionnaire4App.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire4AppEN.ExamGradeId = objRow[convQuestionnaire4App.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire4AppEN.ExamGradeName = objRow[convQuestionnaire4App.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire4AppEN.AnswerTypeId = objRow[convQuestionnaire4App.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire4AppEN.QuestionScore = objRow[convQuestionnaire4App.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire4App.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire4AppEN.UpdDate = objRow[convQuestionnaire4App.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire4AppEN.OptionNum = objRow[convQuestionnaire4App.OptionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.OptionNum].ToString().Trim()); //选项数
objvQuestionnaire4AppEN.ChapterOrderNum = objRow[convQuestionnaire4App.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.ChapterOrderNum].ToString().Trim()); //章排序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire4AppEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire4AppEN);
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
List<clsvQuestionnaire4AppEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQuestionnaire4AppEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaire4AppEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQuestionnaire4AppEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionnaire4AppEN> arrObjLst = new List<clsvQuestionnaire4AppEN>(); 
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
	clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = new clsvQuestionnaire4AppEN();
try
{
objvQuestionnaire4AppEN.QuestionId = Int32.Parse(objRow[convQuestionnaire4App.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4AppEN.QuestionIndex = objRow[convQuestionnaire4App.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4AppEN.QuestionName = objRow[convQuestionnaire4App.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4AppEN.QuestionNo = objRow[convQuestionnaire4App.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4AppEN.CourseId = objRow[convQuestionnaire4App.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4AppEN.CourseCode = objRow[convQuestionnaire4App.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaire4AppEN.CourseName = objRow[convQuestionnaire4App.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire4AppEN.CourseChapterId = objRow[convQuestionnaire4App.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4AppEN.ChapterId = objRow[convQuestionnaire4App.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4AppEN.SectionId = objRow[convQuestionnaire4App.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionId].ToString().Trim(); //节Id
objvQuestionnaire4AppEN.ChapterName = objRow[convQuestionnaire4App.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4AppEN.SectionName = objRow[convQuestionnaire4App.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionName].ToString().Trim(); //节名
objvQuestionnaire4AppEN.ChapterNameSim = objRow[convQuestionnaire4App.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4AppEN.SectionNameSim = objRow[convQuestionnaire4App.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire4AppEN.ParentNodeId = objRow[convQuestionnaire4App.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire4AppEN.QuestionTypeId = objRow[convQuestionnaire4App.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire4AppEN.QuestionTypeName = objRow[convQuestionnaire4App.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire4AppEN.ExamGradeId = objRow[convQuestionnaire4App.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire4AppEN.ExamGradeName = objRow[convQuestionnaire4App.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire4AppEN.AnswerTypeId = objRow[convQuestionnaire4App.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire4AppEN.QuestionScore = objRow[convQuestionnaire4App.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire4App.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire4AppEN.UpdDate = objRow[convQuestionnaire4App.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire4AppEN.OptionNum = objRow[convQuestionnaire4App.OptionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.OptionNum].ToString().Trim()); //选项数
objvQuestionnaire4AppEN.ChapterOrderNum = objRow[convQuestionnaire4App.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.ChapterOrderNum].ToString().Trim()); //章排序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire4AppEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire4AppEN);
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
public static List<clsvQuestionnaire4AppEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionnaire4AppEN> arrObjLst = new List<clsvQuestionnaire4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = new clsvQuestionnaire4AppEN();
try
{
objvQuestionnaire4AppEN.QuestionId = Int32.Parse(objRow[convQuestionnaire4App.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4AppEN.QuestionIndex = objRow[convQuestionnaire4App.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4AppEN.QuestionName = objRow[convQuestionnaire4App.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4AppEN.QuestionNo = objRow[convQuestionnaire4App.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4AppEN.CourseId = objRow[convQuestionnaire4App.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4AppEN.CourseCode = objRow[convQuestionnaire4App.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaire4AppEN.CourseName = objRow[convQuestionnaire4App.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire4AppEN.CourseChapterId = objRow[convQuestionnaire4App.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4AppEN.ChapterId = objRow[convQuestionnaire4App.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4AppEN.SectionId = objRow[convQuestionnaire4App.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionId].ToString().Trim(); //节Id
objvQuestionnaire4AppEN.ChapterName = objRow[convQuestionnaire4App.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4AppEN.SectionName = objRow[convQuestionnaire4App.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionName].ToString().Trim(); //节名
objvQuestionnaire4AppEN.ChapterNameSim = objRow[convQuestionnaire4App.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4AppEN.SectionNameSim = objRow[convQuestionnaire4App.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire4AppEN.ParentNodeId = objRow[convQuestionnaire4App.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire4AppEN.QuestionTypeId = objRow[convQuestionnaire4App.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire4AppEN.QuestionTypeName = objRow[convQuestionnaire4App.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire4AppEN.ExamGradeId = objRow[convQuestionnaire4App.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire4AppEN.ExamGradeName = objRow[convQuestionnaire4App.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire4AppEN.AnswerTypeId = objRow[convQuestionnaire4App.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire4AppEN.QuestionScore = objRow[convQuestionnaire4App.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire4App.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire4AppEN.UpdDate = objRow[convQuestionnaire4App.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire4AppEN.OptionNum = objRow[convQuestionnaire4App.OptionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.OptionNum].ToString().Trim()); //选项数
objvQuestionnaire4AppEN.ChapterOrderNum = objRow[convQuestionnaire4App.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.ChapterOrderNum].ToString().Trim()); //章排序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire4AppEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQuestionnaire4AppEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQuestionnaire4AppEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionnaire4AppEN> arrObjLst = new List<clsvQuestionnaire4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = new clsvQuestionnaire4AppEN();
try
{
objvQuestionnaire4AppEN.QuestionId = Int32.Parse(objRow[convQuestionnaire4App.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4AppEN.QuestionIndex = objRow[convQuestionnaire4App.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4AppEN.QuestionName = objRow[convQuestionnaire4App.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4AppEN.QuestionNo = objRow[convQuestionnaire4App.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4AppEN.CourseId = objRow[convQuestionnaire4App.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4AppEN.CourseCode = objRow[convQuestionnaire4App.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaire4AppEN.CourseName = objRow[convQuestionnaire4App.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire4AppEN.CourseChapterId = objRow[convQuestionnaire4App.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4AppEN.ChapterId = objRow[convQuestionnaire4App.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4AppEN.SectionId = objRow[convQuestionnaire4App.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionId].ToString().Trim(); //节Id
objvQuestionnaire4AppEN.ChapterName = objRow[convQuestionnaire4App.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4AppEN.SectionName = objRow[convQuestionnaire4App.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionName].ToString().Trim(); //节名
objvQuestionnaire4AppEN.ChapterNameSim = objRow[convQuestionnaire4App.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4AppEN.SectionNameSim = objRow[convQuestionnaire4App.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire4AppEN.ParentNodeId = objRow[convQuestionnaire4App.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire4AppEN.QuestionTypeId = objRow[convQuestionnaire4App.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire4AppEN.QuestionTypeName = objRow[convQuestionnaire4App.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire4AppEN.ExamGradeId = objRow[convQuestionnaire4App.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire4AppEN.ExamGradeName = objRow[convQuestionnaire4App.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire4AppEN.AnswerTypeId = objRow[convQuestionnaire4App.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire4AppEN.QuestionScore = objRow[convQuestionnaire4App.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire4App.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire4AppEN.UpdDate = objRow[convQuestionnaire4App.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire4AppEN.OptionNum = objRow[convQuestionnaire4App.OptionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.OptionNum].ToString().Trim()); //选项数
objvQuestionnaire4AppEN.ChapterOrderNum = objRow[convQuestionnaire4App.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.ChapterOrderNum].ToString().Trim()); //章排序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire4AppEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire4AppEN);
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
public static List<clsvQuestionnaire4AppEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQuestionnaire4AppEN> arrObjLst = new List<clsvQuestionnaire4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = new clsvQuestionnaire4AppEN();
try
{
objvQuestionnaire4AppEN.QuestionId = Int32.Parse(objRow[convQuestionnaire4App.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4AppEN.QuestionIndex = objRow[convQuestionnaire4App.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4AppEN.QuestionName = objRow[convQuestionnaire4App.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4AppEN.QuestionNo = objRow[convQuestionnaire4App.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4AppEN.CourseId = objRow[convQuestionnaire4App.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4AppEN.CourseCode = objRow[convQuestionnaire4App.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaire4AppEN.CourseName = objRow[convQuestionnaire4App.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire4AppEN.CourseChapterId = objRow[convQuestionnaire4App.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4AppEN.ChapterId = objRow[convQuestionnaire4App.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4AppEN.SectionId = objRow[convQuestionnaire4App.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionId].ToString().Trim(); //节Id
objvQuestionnaire4AppEN.ChapterName = objRow[convQuestionnaire4App.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4AppEN.SectionName = objRow[convQuestionnaire4App.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionName].ToString().Trim(); //节名
objvQuestionnaire4AppEN.ChapterNameSim = objRow[convQuestionnaire4App.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4AppEN.SectionNameSim = objRow[convQuestionnaire4App.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire4AppEN.ParentNodeId = objRow[convQuestionnaire4App.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire4AppEN.QuestionTypeId = objRow[convQuestionnaire4App.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire4AppEN.QuestionTypeName = objRow[convQuestionnaire4App.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire4AppEN.ExamGradeId = objRow[convQuestionnaire4App.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire4AppEN.ExamGradeName = objRow[convQuestionnaire4App.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire4AppEN.AnswerTypeId = objRow[convQuestionnaire4App.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire4AppEN.QuestionScore = objRow[convQuestionnaire4App.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire4App.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire4AppEN.UpdDate = objRow[convQuestionnaire4App.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire4AppEN.OptionNum = objRow[convQuestionnaire4App.OptionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.OptionNum].ToString().Trim()); //选项数
objvQuestionnaire4AppEN.ChapterOrderNum = objRow[convQuestionnaire4App.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.ChapterOrderNum].ToString().Trim()); //章排序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire4AppEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaire4AppEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQuestionnaire4AppEN> arrObjLst = new List<clsvQuestionnaire4AppEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = new clsvQuestionnaire4AppEN();
try
{
objvQuestionnaire4AppEN.QuestionId = Int32.Parse(objRow[convQuestionnaire4App.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4AppEN.QuestionIndex = objRow[convQuestionnaire4App.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4AppEN.QuestionName = objRow[convQuestionnaire4App.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4AppEN.QuestionNo = objRow[convQuestionnaire4App.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4AppEN.CourseId = objRow[convQuestionnaire4App.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4AppEN.CourseCode = objRow[convQuestionnaire4App.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaire4AppEN.CourseName = objRow[convQuestionnaire4App.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire4AppEN.CourseChapterId = objRow[convQuestionnaire4App.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4AppEN.ChapterId = objRow[convQuestionnaire4App.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4AppEN.SectionId = objRow[convQuestionnaire4App.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionId].ToString().Trim(); //节Id
objvQuestionnaire4AppEN.ChapterName = objRow[convQuestionnaire4App.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4AppEN.SectionName = objRow[convQuestionnaire4App.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionName].ToString().Trim(); //节名
objvQuestionnaire4AppEN.ChapterNameSim = objRow[convQuestionnaire4App.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4AppEN.SectionNameSim = objRow[convQuestionnaire4App.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire4AppEN.ParentNodeId = objRow[convQuestionnaire4App.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire4AppEN.QuestionTypeId = objRow[convQuestionnaire4App.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire4AppEN.QuestionTypeName = objRow[convQuestionnaire4App.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire4AppEN.ExamGradeId = objRow[convQuestionnaire4App.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire4AppEN.ExamGradeName = objRow[convQuestionnaire4App.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire4App.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire4AppEN.AnswerTypeId = objRow[convQuestionnaire4App.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire4App.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire4AppEN.QuestionScore = objRow[convQuestionnaire4App.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire4App.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire4AppEN.UpdDate = objRow[convQuestionnaire4App.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire4AppEN.OptionNum = objRow[convQuestionnaire4App.OptionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.OptionNum].ToString().Trim()); //选项数
objvQuestionnaire4AppEN.ChapterOrderNum = objRow[convQuestionnaire4App.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App.ChapterOrderNum].ToString().Trim()); //章排序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire4AppEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire4AppEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQuestionnaire4App(ref clsvQuestionnaire4AppEN objvQuestionnaire4AppEN)
{
bool bolResult = vQuestionnaire4AppDA.GetvQuestionnaire4App(ref objvQuestionnaire4AppEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaire4AppEN GetObjByQuestionId(long lngQuestionId)
{
clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = vQuestionnaire4AppDA.GetObjByQuestionId(lngQuestionId);
return objvQuestionnaire4AppEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQuestionnaire4AppEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = vQuestionnaire4AppDA.GetFirstObj(strWhereCond);
 return objvQuestionnaire4AppEN;
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
public static clsvQuestionnaire4AppEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = vQuestionnaire4AppDA.GetObjByDataRow(objRow);
 return objvQuestionnaire4AppEN;
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
public static clsvQuestionnaire4AppEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = vQuestionnaire4AppDA.GetObjByDataRow(objRow);
 return objvQuestionnaire4AppEN;
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
 /// <param name = "lstvQuestionnaire4AppObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionnaire4AppEN GetObjByQuestionIdFromList(long lngQuestionId, List<clsvQuestionnaire4AppEN> lstvQuestionnaire4AppObjLst)
{
foreach (clsvQuestionnaire4AppEN objvQuestionnaire4AppEN in lstvQuestionnaire4AppObjLst)
{
if (objvQuestionnaire4AppEN.QuestionId == lngQuestionId)
{
return objvQuestionnaire4AppEN;
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
 lngQuestionId = new clsvQuestionnaire4AppDA().GetFirstID(strWhereCond);
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
 arrList = vQuestionnaire4AppDA.GetID(strWhereCond);
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
bool bolIsExist = vQuestionnaire4AppDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vQuestionnaire4AppDA.IsExist(lngQuestionId);
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
 bolIsExist = clsvQuestionnaire4AppDA.IsExistTable();
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
 bolIsExist = vQuestionnaire4AppDA.IsExistTable(strTabName);
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
 /// <param name = "objvQuestionnaire4AppENS">源对象</param>
 /// <param name = "objvQuestionnaire4AppENT">目标对象</param>
 public static void CopyTo(clsvQuestionnaire4AppEN objvQuestionnaire4AppENS, clsvQuestionnaire4AppEN objvQuestionnaire4AppENT)
{
try
{
objvQuestionnaire4AppENT.QuestionId = objvQuestionnaire4AppENS.QuestionId; //题目Id
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
objvQuestionnaire4AppENT.ChapterNameSim = objvQuestionnaire4AppENS.ChapterNameSim; //章名简称
objvQuestionnaire4AppENT.SectionNameSim = objvQuestionnaire4AppENS.SectionNameSim; //节名简称
objvQuestionnaire4AppENT.ParentNodeId = objvQuestionnaire4AppENS.ParentNodeId; //父节点编号
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
 /// <param name = "objvQuestionnaire4AppEN">源简化对象</param>
 public static void SetUpdFlag(clsvQuestionnaire4AppEN objvQuestionnaire4AppEN)
{
try
{
objvQuestionnaire4AppEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQuestionnaire4AppEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQuestionnaire4App.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.QuestionId = objvQuestionnaire4AppEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(convQuestionnaire4App.QuestionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.QuestionIndex = objvQuestionnaire4AppEN.QuestionIndex; //题目序号
}
if (arrFldSet.Contains(convQuestionnaire4App.QuestionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.QuestionName = objvQuestionnaire4AppEN.QuestionName == "[null]" ? null :  objvQuestionnaire4AppEN.QuestionName; //题目名称
}
if (arrFldSet.Contains(convQuestionnaire4App.QuestionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.QuestionNo = objvQuestionnaire4AppEN.QuestionNo == "[null]" ? null :  objvQuestionnaire4AppEN.QuestionNo; //题目编号
}
if (arrFldSet.Contains(convQuestionnaire4App.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.CourseId = objvQuestionnaire4AppEN.CourseId == "[null]" ? null :  objvQuestionnaire4AppEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convQuestionnaire4App.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.CourseCode = objvQuestionnaire4AppEN.CourseCode == "[null]" ? null :  objvQuestionnaire4AppEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convQuestionnaire4App.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.CourseName = objvQuestionnaire4AppEN.CourseName == "[null]" ? null :  objvQuestionnaire4AppEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convQuestionnaire4App.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.CourseChapterId = objvQuestionnaire4AppEN.CourseChapterId == "[null]" ? null :  objvQuestionnaire4AppEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convQuestionnaire4App.ChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.ChapterId = objvQuestionnaire4AppEN.ChapterId == "[null]" ? null :  objvQuestionnaire4AppEN.ChapterId; //章Id
}
if (arrFldSet.Contains(convQuestionnaire4App.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.SectionId = objvQuestionnaire4AppEN.SectionId == "[null]" ? null :  objvQuestionnaire4AppEN.SectionId; //节Id
}
if (arrFldSet.Contains(convQuestionnaire4App.ChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.ChapterName = objvQuestionnaire4AppEN.ChapterName == "[null]" ? null :  objvQuestionnaire4AppEN.ChapterName; //章名
}
if (arrFldSet.Contains(convQuestionnaire4App.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.SectionName = objvQuestionnaire4AppEN.SectionName == "[null]" ? null :  objvQuestionnaire4AppEN.SectionName; //节名
}
if (arrFldSet.Contains(convQuestionnaire4App.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.ChapterNameSim = objvQuestionnaire4AppEN.ChapterNameSim == "[null]" ? null :  objvQuestionnaire4AppEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(convQuestionnaire4App.SectionNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.SectionNameSim = objvQuestionnaire4AppEN.SectionNameSim == "[null]" ? null :  objvQuestionnaire4AppEN.SectionNameSim; //节名简称
}
if (arrFldSet.Contains(convQuestionnaire4App.ParentNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.ParentNodeId = objvQuestionnaire4AppEN.ParentNodeId == "[null]" ? null :  objvQuestionnaire4AppEN.ParentNodeId; //父节点编号
}
if (arrFldSet.Contains(convQuestionnaire4App.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.QuestionTypeId = objvQuestionnaire4AppEN.QuestionTypeId == "[null]" ? null :  objvQuestionnaire4AppEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(convQuestionnaire4App.QuestionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.QuestionTypeName = objvQuestionnaire4AppEN.QuestionTypeName == "[null]" ? null :  objvQuestionnaire4AppEN.QuestionTypeName; //题目类型名
}
if (arrFldSet.Contains(convQuestionnaire4App.ExamGradeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.ExamGradeId = objvQuestionnaire4AppEN.ExamGradeId == "[null]" ? null :  objvQuestionnaire4AppEN.ExamGradeId; //题库等级ID
}
if (arrFldSet.Contains(convQuestionnaire4App.ExamGradeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.ExamGradeName = objvQuestionnaire4AppEN.ExamGradeName == "[null]" ? null :  objvQuestionnaire4AppEN.ExamGradeName; //题库等级名
}
if (arrFldSet.Contains(convQuestionnaire4App.AnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.AnswerTypeId = objvQuestionnaire4AppEN.AnswerTypeId == "[null]" ? null :  objvQuestionnaire4AppEN.AnswerTypeId; //答案类型ID
}
if (arrFldSet.Contains(convQuestionnaire4App.QuestionScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.QuestionScore = objvQuestionnaire4AppEN.QuestionScore; //题目得分
}
if (arrFldSet.Contains(convQuestionnaire4App.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.UpdDate = objvQuestionnaire4AppEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQuestionnaire4App.OptionNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.OptionNum = objvQuestionnaire4AppEN.OptionNum; //选项数
}
if (arrFldSet.Contains(convQuestionnaire4App.ChapterOrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4AppEN.ChapterOrderNum = objvQuestionnaire4AppEN.ChapterOrderNum; //章排序号
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
 /// <param name = "objvQuestionnaire4AppEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQuestionnaire4AppEN objvQuestionnaire4AppEN)
{
try
{
if (objvQuestionnaire4AppEN.QuestionName == "[null]") objvQuestionnaire4AppEN.QuestionName = null; //题目名称
if (objvQuestionnaire4AppEN.QuestionNo == "[null]") objvQuestionnaire4AppEN.QuestionNo = null; //题目编号
if (objvQuestionnaire4AppEN.CourseId == "[null]") objvQuestionnaire4AppEN.CourseId = null; //课程Id
if (objvQuestionnaire4AppEN.CourseCode == "[null]") objvQuestionnaire4AppEN.CourseCode = null; //课程代码
if (objvQuestionnaire4AppEN.CourseName == "[null]") objvQuestionnaire4AppEN.CourseName = null; //课程名称
if (objvQuestionnaire4AppEN.CourseChapterId == "[null]") objvQuestionnaire4AppEN.CourseChapterId = null; //课程章节ID
if (objvQuestionnaire4AppEN.ChapterId == "[null]") objvQuestionnaire4AppEN.ChapterId = null; //章Id
if (objvQuestionnaire4AppEN.SectionId == "[null]") objvQuestionnaire4AppEN.SectionId = null; //节Id
if (objvQuestionnaire4AppEN.ChapterName == "[null]") objvQuestionnaire4AppEN.ChapterName = null; //章名
if (objvQuestionnaire4AppEN.SectionName == "[null]") objvQuestionnaire4AppEN.SectionName = null; //节名
if (objvQuestionnaire4AppEN.ChapterNameSim == "[null]") objvQuestionnaire4AppEN.ChapterNameSim = null; //章名简称
if (objvQuestionnaire4AppEN.SectionNameSim == "[null]") objvQuestionnaire4AppEN.SectionNameSim = null; //节名简称
if (objvQuestionnaire4AppEN.ParentNodeId == "[null]") objvQuestionnaire4AppEN.ParentNodeId = null; //父节点编号
if (objvQuestionnaire4AppEN.QuestionTypeId == "[null]") objvQuestionnaire4AppEN.QuestionTypeId = null; //题目类型Id
if (objvQuestionnaire4AppEN.QuestionTypeName == "[null]") objvQuestionnaire4AppEN.QuestionTypeName = null; //题目类型名
if (objvQuestionnaire4AppEN.ExamGradeId == "[null]") objvQuestionnaire4AppEN.ExamGradeId = null; //题库等级ID
if (objvQuestionnaire4AppEN.ExamGradeName == "[null]") objvQuestionnaire4AppEN.ExamGradeName = null; //题库等级名
if (objvQuestionnaire4AppEN.AnswerTypeId == "[null]") objvQuestionnaire4AppEN.AnswerTypeId = null; //答案类型ID
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
public static void CheckProperty4Condition(clsvQuestionnaire4AppEN objvQuestionnaire4AppEN)
{
 vQuestionnaire4AppDA.CheckProperty4Condition(objvQuestionnaire4AppEN);
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
string strCondition = string.Format("1 =1 Order By {0}", convQuestionnaire4App.QuestionId); 
List<clsvQuestionnaire4AppEN> arrObjLst = clsvQuestionnaire4AppBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQuestionnaire4AppEN objvQuestionnaire4AppEN = new clsvQuestionnaire4AppEN()
{
QuestionId = 0,
QuestionName = "选[v题目表4App]..."
};
arrObjLstSel.Insert(0, objvQuestionnaire4AppEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQuestionnaire4App.QuestionId;
objComboBox.DisplayMember = convQuestionnaire4App.QuestionName;
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v题目表4App]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convQuestionnaire4App.QuestionId); 
IEnumerable<clsvQuestionnaire4AppEN> arrObjLst = clsvQuestionnaire4AppBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
objDDL.DataValueField = convQuestionnaire4App.QuestionId;
objDDL.DataTextField = convQuestionnaire4App.QuestionName;
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v题目表4App]...","0");
List<clsvQuestionnaire4AppEN> arrvQuestionnaire4AppObjLst = GetAllvQuestionnaire4AppObjLstCache(strCourseId); 
objDDL.DataValueField = convQuestionnaire4App.QuestionId;
objDDL.DataTextField = convQuestionnaire4App.QuestionName;
objDDL.DataSource = arrvQuestionnaire4AppObjLst;
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
//if (arrvQuestionnaire4AppObjLstCache == null)
//{
//arrvQuestionnaire4AppObjLstCache = vQuestionnaire4AppDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngQuestionId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionnaire4AppEN GetObjByQuestionIdCache(long lngQuestionId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvQuestionnaire4AppEN._CurrTabName, strCourseId);
List<clsvQuestionnaire4AppEN> arrvQuestionnaire4AppObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionnaire4AppEN> arrvQuestionnaire4AppObjLst_Sel =
arrvQuestionnaire4AppObjLstCache
.Where(x=> x.QuestionId == lngQuestionId 
);
if (arrvQuestionnaire4AppObjLst_Sel.Count() == 0)
{
   clsvQuestionnaire4AppEN obj = clsvQuestionnaire4AppBL.GetObjByQuestionId(lngQuestionId);
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
return arrvQuestionnaire4AppObjLst_Sel.First();
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
clsvQuestionnaire4AppEN objvQuestionnaire4App = GetObjByQuestionIdCache(lngQuestionId, strCourseId);
if (objvQuestionnaire4App == null) return "";
return objvQuestionnaire4App.QuestionName;
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
clsvQuestionnaire4AppEN objvQuestionnaire4App = GetObjByQuestionIdCache(lngQuestionId, strCourseId);
if (objvQuestionnaire4App == null) return "";
return objvQuestionnaire4App.QuestionName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionnaire4AppEN> GetAllvQuestionnaire4AppObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvQuestionnaire4AppEN> arrvQuestionnaire4AppObjLstCache = GetObjLstCache(strCourseId); 
return arrvQuestionnaire4AppObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionnaire4AppEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvQuestionnaire4AppEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvQuestionnaire4AppEN> arrvQuestionnaire4AppObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvQuestionnaire4AppObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvQuestionnaire4AppEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsvQuestionnaire4AppEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvQuestionnaire4AppEN._RefreshTimeLst.Count == 0) return "";
return clsvQuestionnaire4AppEN._RefreshTimeLst[clsvQuestionnaire4AppEN._RefreshTimeLst.Count - 1];
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
if (strInFldName != convQuestionnaire4App.QuestionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQuestionnaire4App.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQuestionnaire4App.AttributeName));
throw new Exception(strMsg);
}
var objvQuestionnaire4App = clsvQuestionnaire4AppBL.GetObjByQuestionIdCache(lngQuestionId, strCourseId);
if (objvQuestionnaire4App == null) return "";
return objvQuestionnaire4App[strOutFldName].ToString();
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
int intRecCount = clsvQuestionnaire4AppDA.GetRecCount(strTabName);
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
int intRecCount = clsvQuestionnaire4AppDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQuestionnaire4AppDA.GetRecCount();
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
int intRecCount = clsvQuestionnaire4AppDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQuestionnaire4AppCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQuestionnaire4AppEN objvQuestionnaire4AppCond)
{
 string strCourseId = objvQuestionnaire4AppCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvQuestionnaire4AppBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvQuestionnaire4AppEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionnaire4AppEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionnaire4App.AttributeName)
{
if (objvQuestionnaire4AppCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionnaire4AppCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaire4AppCond[strFldName].ToString());
}
else
{
if (objvQuestionnaire4AppCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionnaire4AppCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaire4AppCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionnaire4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionnaire4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionnaire4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionnaire4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionnaire4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionnaire4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionnaire4AppCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionnaire4AppCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionnaire4AppCond[strFldName]));
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
 List<string> arrList = clsvQuestionnaire4AppDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQuestionnaire4AppDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQuestionnaire4AppDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}