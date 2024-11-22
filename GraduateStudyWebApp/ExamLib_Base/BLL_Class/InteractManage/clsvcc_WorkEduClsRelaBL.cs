
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkEduClsRelaBL
 表名:vcc_WorkEduClsRela(01120197)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:29:52
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
public static class  clsvcc_WorkEduClsRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdWorkEduClsRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkEduClsRelaEN GetObj(this K_IdWorkEduClsRela_vcc_WorkEduClsRela myKey)
{
clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = clsvcc_WorkEduClsRelaBL.vcc_WorkEduClsRelaDA.GetObjByIdWorkEduClsRela(myKey.Value);
return objvcc_WorkEduClsRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetIdWorkEduClsRela(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, long lngIdWorkEduClsRela, string strComparisonOp="")
	{
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela = lngIdWorkEduClsRela; //作业教学班关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.IdWorkEduClsRela) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.IdWorkEduClsRela, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.IdWorkEduClsRela] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetQuestionId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, long? lngQuestionId, string strComparisonOp="")
	{
objvcc_WorkEduClsRelaEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.QuestionId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.QuestionId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetQuestionIndex(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, int? intQuestionIndex, string strComparisonOp="")
	{
objvcc_WorkEduClsRelaEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.QuestionIndex) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.QuestionIndex, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionIndex] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetQuestionName(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strQuestionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionName, 500, convcc_WorkEduClsRela.QuestionName);
}
objvcc_WorkEduClsRelaEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.QuestionName) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.QuestionName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetQuestionContent(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strQuestionContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, convcc_WorkEduClsRela.QuestionContent);
}
objvcc_WorkEduClsRelaEN.QuestionContent = strQuestionContent; //题目内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.QuestionContent) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.QuestionContent, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionContent] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetCourseId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_WorkEduClsRela.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_WorkEduClsRela.CourseId);
}
objvcc_WorkEduClsRelaEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.CourseId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.CourseId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.CourseId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetCourseName(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_WorkEduClsRela.CourseName);
}
objvcc_WorkEduClsRelaEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.CourseName) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.CourseName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.CourseName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetCourseChapterId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_WorkEduClsRela.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_WorkEduClsRela.CourseChapterId);
}
objvcc_WorkEduClsRelaEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.CourseChapterId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.CourseChapterId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.CourseChapterId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetCourseChapterName(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strCourseChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_WorkEduClsRela.CourseChapterName);
}
objvcc_WorkEduClsRelaEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.CourseChapterName) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.CourseChapterName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.CourseChapterName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetChapterName(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_WorkEduClsRela.ChapterName);
}
objvcc_WorkEduClsRelaEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.ChapterName) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.ChapterName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.ChapterName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetSectionName(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_WorkEduClsRela.SectionName);
}
objvcc_WorkEduClsRelaEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.SectionName) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.SectionName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.SectionName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetChapterNameSim(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, convcc_WorkEduClsRela.ChapterNameSim);
}
objvcc_WorkEduClsRelaEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.ChapterNameSim) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.ChapterNameSim, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.ChapterNameSim] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetSectionNameSim(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strSectionNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionNameSim, 10, convcc_WorkEduClsRela.SectionNameSim);
}
objvcc_WorkEduClsRelaEN.SectionNameSim = strSectionNameSim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.SectionNameSim) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.SectionNameSim, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.SectionNameSim] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetParentNodeId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strParentNodeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeId, 8, convcc_WorkEduClsRela.ParentNodeId);
}
objvcc_WorkEduClsRelaEN.ParentNodeId = strParentNodeId; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.ParentNodeId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.ParentNodeId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.ParentNodeId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetCourseChapterReferred(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strCourseChapterReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convcc_WorkEduClsRela.CourseChapterReferred);
}
objvcc_WorkEduClsRelaEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.CourseChapterReferred) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.CourseChapterReferred, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.CourseChapterReferred] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetParentNodeName(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strParentNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeName, 100, convcc_WorkEduClsRela.ParentNodeName);
}
objvcc_WorkEduClsRelaEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.ParentNodeName) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.ParentNodeName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.ParentNodeName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetParentNodeReferred(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strParentNodeReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convcc_WorkEduClsRela.ParentNodeReferred);
}
objvcc_WorkEduClsRelaEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.ParentNodeReferred) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.ParentNodeReferred, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.ParentNodeReferred] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetQuestionTypeId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convcc_WorkEduClsRela.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convcc_WorkEduClsRela.QuestionTypeId);
}
objvcc_WorkEduClsRelaEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.QuestionTypeId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.QuestionTypeId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionTypeId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetQuestionTypeName(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strQuestionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convcc_WorkEduClsRela.QuestionTypeName);
}
objvcc_WorkEduClsRelaEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.QuestionTypeName) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.QuestionTypeName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionTypeName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetExamGradeId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strExamGradeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamGradeId, 2, convcc_WorkEduClsRela.ExamGradeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExamGradeId, 2, convcc_WorkEduClsRela.ExamGradeId);
}
objvcc_WorkEduClsRelaEN.ExamGradeId = strExamGradeId; //题库等级ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.ExamGradeId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.ExamGradeId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.ExamGradeId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetExamGradeName(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strExamGradeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamGradeName, 50, convcc_WorkEduClsRela.ExamGradeName);
}
objvcc_WorkEduClsRelaEN.ExamGradeName = strExamGradeName; //题库等级名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.ExamGradeName) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.ExamGradeName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.ExamGradeName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetAnswerTypeId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strAnswerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convcc_WorkEduClsRela.AnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convcc_WorkEduClsRela.AnswerTypeId);
}
objvcc_WorkEduClsRelaEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.AnswerTypeId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.AnswerTypeId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.AnswerTypeId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetAnswerModeId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strAnswerModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convcc_WorkEduClsRela.AnswerModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convcc_WorkEduClsRela.AnswerModeId);
}
objvcc_WorkEduClsRelaEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.AnswerModeId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.AnswerModeId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.AnswerModeId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetDefaultValue(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strDefaultValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convcc_WorkEduClsRela.DefaultValue);
}
objvcc_WorkEduClsRelaEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.DefaultValue) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.DefaultValue, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.DefaultValue] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetTextDirectId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strTextDirectId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextDirectId, 4, convcc_WorkEduClsRela.TextDirectId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextDirectId, 4, convcc_WorkEduClsRela.TextDirectId);
}
objvcc_WorkEduClsRelaEN.TextDirectId = strTextDirectId; //文本方向ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.TextDirectId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.TextDirectId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.TextDirectId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetRelaEvent(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strRelaEvent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaEvent, 4000, convcc_WorkEduClsRela.RelaEvent);
}
objvcc_WorkEduClsRelaEN.RelaEvent = strRelaEvent; //相关事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.RelaEvent) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.RelaEvent, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.RelaEvent] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetCheckBoxLimitCount(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, int? intCheckBoxLimitCount, string strComparisonOp="")
	{
objvcc_WorkEduClsRelaEN.CheckBoxLimitCount = intCheckBoxLimitCount; //复选框限制数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.CheckBoxLimitCount) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.CheckBoxLimitCount, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.CheckBoxLimitCount] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetAnswerAttLimitSize(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, long? lngAnswerAttLimitSize, string strComparisonOp="")
	{
objvcc_WorkEduClsRelaEN.AnswerAttLimitSize = lngAnswerAttLimitSize; //回答附件限制大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.AnswerAttLimitSize) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.AnswerAttLimitSize, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.AnswerAttLimitSize] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetLimitedResourceType(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strLimitedResourceType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLimitedResourceType, 100, convcc_WorkEduClsRela.LimitedResourceType);
}
objvcc_WorkEduClsRelaEN.LimitedResourceType = strLimitedResourceType; //限制资源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.LimitedResourceType) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.LimitedResourceType, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.LimitedResourceType] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetQuestionTypeId4Course(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strQuestionTypeId4Course, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId4Course, 8, convcc_WorkEduClsRela.QuestionTypeId4Course);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId4Course, 8, convcc_WorkEduClsRela.QuestionTypeId4Course);
}
objvcc_WorkEduClsRelaEN.QuestionTypeId4Course = strQuestionTypeId4Course; //题目类型Id4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.QuestionTypeId4Course) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.QuestionTypeId4Course, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionTypeId4Course] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetQuestionTypeName4Course(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strQuestionTypeName4Course, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName4Course, 30, convcc_WorkEduClsRela.QuestionTypeName4Course);
}
objvcc_WorkEduClsRelaEN.QuestionTypeName4Course = strQuestionTypeName4Course; //题目类型名4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.QuestionTypeName4Course) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.QuestionTypeName4Course, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionTypeName4Course] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetIdCurrEduCls(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, convcc_WorkEduClsRela.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convcc_WorkEduClsRela.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convcc_WorkEduClsRela.IdCurrEduCls);
}
objvcc_WorkEduClsRelaEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.IdCurrEduCls) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.IdCurrEduCls, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.IdCurrEduCls] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetCurrEduClsId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strCurrEduClsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convcc_WorkEduClsRela.CurrEduClsId);
}
objvcc_WorkEduClsRelaEN.CurrEduClsId = strCurrEduClsId; //教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.CurrEduClsId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.CurrEduClsId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.CurrEduClsId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetEduClsName(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strEduClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convcc_WorkEduClsRela.EduClsName);
}
objvcc_WorkEduClsRelaEN.EduClsName = strEduClsName; //教学班名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.EduClsName) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.EduClsName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.EduClsName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetScores(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, double? dblScores, string strComparisonOp="")
	{
objvcc_WorkEduClsRelaEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.Scores) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.Scores, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.Scores] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetTeacherId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherId, convcc_WorkEduClsRela.TeacherId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherId, 12, convcc_WorkEduClsRela.TeacherId);
}
objvcc_WorkEduClsRelaEN.TeacherId = strTeacherId; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.TeacherId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.TeacherId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.TeacherId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetIsPublish(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, bool bolIsPublish, string strComparisonOp="")
	{
objvcc_WorkEduClsRelaEN.IsPublish = bolIsPublish; //是否发布
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.IsPublish) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.IsPublish, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.IsPublish] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetPubDate(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strPubDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubDate, convcc_WorkEduClsRela.PubDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubDate, 14, convcc_WorkEduClsRela.PubDate);
}
objvcc_WorkEduClsRelaEN.PubDate = strPubDate; //发布日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.PubDate) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.PubDate, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.PubDate] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN Setpublisher(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strpublisher, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strpublisher, 20, convcc_WorkEduClsRela.publisher);
}
objvcc_WorkEduClsRelaEN.publisher = strpublisher; //发布者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.publisher) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.publisher, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.publisher] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetSpecifyCompletionDate(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strSpecifyCompletionDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSpecifyCompletionDate, convcc_WorkEduClsRela.SpecifyCompletionDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSpecifyCompletionDate, 14, convcc_WorkEduClsRela.SpecifyCompletionDate);
}
objvcc_WorkEduClsRelaEN.SpecifyCompletionDate = strSpecifyCompletionDate; //指定完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.SpecifyCompletionDate) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.SpecifyCompletionDate, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.SpecifyCompletionDate] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetIsCurrEduCls(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, bool bolIsCurrEduCls, string strComparisonOp="")
	{
objvcc_WorkEduClsRelaEN.IsCurrEduCls = bolIsCurrEduCls; //是否为教学班作业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.IsCurrEduCls) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.IsCurrEduCls, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.IsCurrEduCls] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetIsGroupWork(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, bool bolIsGroupWork, string strComparisonOp="")
	{
objvcc_WorkEduClsRelaEN.IsGroupWork = bolIsGroupWork; //是否为小组作业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.IsGroupWork) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.IsGroupWork, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.IsGroupWork] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetCourseStudentGroupId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, long? lngCourseStudentGroupId, string strComparisonOp="")
	{
objvcc_WorkEduClsRelaEN.CourseStudentGroupId = lngCourseStudentGroupId; //学生分组表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.CourseStudentGroupId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.CourseStudentGroupId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.CourseStudentGroupId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetWorkTypeId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strWorkTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkTypeId, convcc_WorkEduClsRela.WorkTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkTypeId, 2, convcc_WorkEduClsRela.WorkTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWorkTypeId, 2, convcc_WorkEduClsRela.WorkTypeId);
}
objvcc_WorkEduClsRelaEN.WorkTypeId = strWorkTypeId; //作业类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.WorkTypeId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.WorkTypeId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.WorkTypeId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetWorkTypeName(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strWorkTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkTypeName, 30, convcc_WorkEduClsRela.WorkTypeName);
}
objvcc_WorkEduClsRelaEN.WorkTypeName = strWorkTypeName; //作业类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.WorkTypeName) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.WorkTypeName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.WorkTypeName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetUpdDate(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_WorkEduClsRela.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_WorkEduClsRela.UpdDate);
}
objvcc_WorkEduClsRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.UpdDate) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.UpdDate, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.UpdDate] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetUpdUserId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_WorkEduClsRela.UpdUserId);
}
objvcc_WorkEduClsRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.UpdUserId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.UpdUserId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.UpdUserId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetMemo(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_WorkEduClsRela.Memo);
}
objvcc_WorkEduClsRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.Memo) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.Memo, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.Memo] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetStuNum(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, int? intStuNum, string strComparisonOp="")
	{
objvcc_WorkEduClsRelaEN.StuNum = intStuNum; //学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.StuNum) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.StuNum, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.StuNum] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetEduClsStuNum(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, int? intEduClsStuNum, string strComparisonOp="")
	{
objvcc_WorkEduClsRelaEN.EduClsStuNum = intEduClsStuNum; //教学班学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.EduClsStuNum) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.EduClsStuNum, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.EduClsStuNum] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaENS">源对象</param>
 /// <param name = "objvcc_WorkEduClsRelaENT">目标对象</param>
 public static void CopyTo(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaENS, clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaENT)
{
try
{
objvcc_WorkEduClsRelaENT.IdWorkEduClsRela = objvcc_WorkEduClsRelaENS.IdWorkEduClsRela; //作业教学班关系流水号
objvcc_WorkEduClsRelaENT.QuestionId = objvcc_WorkEduClsRelaENS.QuestionId; //题目Id
objvcc_WorkEduClsRelaENT.QuestionIndex = objvcc_WorkEduClsRelaENS.QuestionIndex; //题目序号
objvcc_WorkEduClsRelaENT.QuestionName = objvcc_WorkEduClsRelaENS.QuestionName; //题目名称
objvcc_WorkEduClsRelaENT.QuestionContent = objvcc_WorkEduClsRelaENS.QuestionContent; //题目内容
objvcc_WorkEduClsRelaENT.CourseId = objvcc_WorkEduClsRelaENS.CourseId; //课程Id
objvcc_WorkEduClsRelaENT.CourseName = objvcc_WorkEduClsRelaENS.CourseName; //课程名称
objvcc_WorkEduClsRelaENT.CourseChapterId = objvcc_WorkEduClsRelaENS.CourseChapterId; //课程章节ID
objvcc_WorkEduClsRelaENT.CourseChapterName = objvcc_WorkEduClsRelaENS.CourseChapterName; //课程章节名称
objvcc_WorkEduClsRelaENT.ChapterName = objvcc_WorkEduClsRelaENS.ChapterName; //章名
objvcc_WorkEduClsRelaENT.SectionName = objvcc_WorkEduClsRelaENS.SectionName; //节名
objvcc_WorkEduClsRelaENT.ChapterNameSim = objvcc_WorkEduClsRelaENS.ChapterNameSim; //章名简称
objvcc_WorkEduClsRelaENT.SectionNameSim = objvcc_WorkEduClsRelaENS.SectionNameSim; //节名简称
objvcc_WorkEduClsRelaENT.ParentNodeId = objvcc_WorkEduClsRelaENS.ParentNodeId; //父节点编号
objvcc_WorkEduClsRelaENT.CourseChapterReferred = objvcc_WorkEduClsRelaENS.CourseChapterReferred; //节简称
objvcc_WorkEduClsRelaENT.ParentNodeName = objvcc_WorkEduClsRelaENS.ParentNodeName; //父节点名称
objvcc_WorkEduClsRelaENT.ParentNodeReferred = objvcc_WorkEduClsRelaENS.ParentNodeReferred; //章简称
objvcc_WorkEduClsRelaENT.QuestionTypeId = objvcc_WorkEduClsRelaENS.QuestionTypeId; //题目类型Id
objvcc_WorkEduClsRelaENT.QuestionTypeName = objvcc_WorkEduClsRelaENS.QuestionTypeName; //题目类型名
objvcc_WorkEduClsRelaENT.ExamGradeId = objvcc_WorkEduClsRelaENS.ExamGradeId; //题库等级ID
objvcc_WorkEduClsRelaENT.ExamGradeName = objvcc_WorkEduClsRelaENS.ExamGradeName; //题库等级名
objvcc_WorkEduClsRelaENT.AnswerTypeId = objvcc_WorkEduClsRelaENS.AnswerTypeId; //答案类型ID
objvcc_WorkEduClsRelaENT.AnswerModeId = objvcc_WorkEduClsRelaENS.AnswerModeId; //答案模式Id
objvcc_WorkEduClsRelaENT.DefaultValue = objvcc_WorkEduClsRelaENS.DefaultValue; //缺省值
objvcc_WorkEduClsRelaENT.TextDirectId = objvcc_WorkEduClsRelaENS.TextDirectId; //文本方向ID
objvcc_WorkEduClsRelaENT.RelaEvent = objvcc_WorkEduClsRelaENS.RelaEvent; //相关事件
objvcc_WorkEduClsRelaENT.CheckBoxLimitCount = objvcc_WorkEduClsRelaENS.CheckBoxLimitCount; //复选框限制数
objvcc_WorkEduClsRelaENT.AnswerAttLimitSize = objvcc_WorkEduClsRelaENS.AnswerAttLimitSize; //回答附件限制大小
objvcc_WorkEduClsRelaENT.LimitedResourceType = objvcc_WorkEduClsRelaENS.LimitedResourceType; //限制资源类型
objvcc_WorkEduClsRelaENT.QuestionTypeId4Course = objvcc_WorkEduClsRelaENS.QuestionTypeId4Course; //题目类型Id4课程
objvcc_WorkEduClsRelaENT.QuestionTypeName4Course = objvcc_WorkEduClsRelaENS.QuestionTypeName4Course; //题目类型名4课程
objvcc_WorkEduClsRelaENT.IdCurrEduCls = objvcc_WorkEduClsRelaENS.IdCurrEduCls; //教学班流水号
objvcc_WorkEduClsRelaENT.CurrEduClsId = objvcc_WorkEduClsRelaENS.CurrEduClsId; //教学班Id
objvcc_WorkEduClsRelaENT.EduClsName = objvcc_WorkEduClsRelaENS.EduClsName; //教学班名
objvcc_WorkEduClsRelaENT.Scores = objvcc_WorkEduClsRelaENS.Scores; //分值
objvcc_WorkEduClsRelaENT.TeacherId = objvcc_WorkEduClsRelaENS.TeacherId; //教师工号
objvcc_WorkEduClsRelaENT.IsPublish = objvcc_WorkEduClsRelaENS.IsPublish; //是否发布
objvcc_WorkEduClsRelaENT.PubDate = objvcc_WorkEduClsRelaENS.PubDate; //发布日期
objvcc_WorkEduClsRelaENT.publisher = objvcc_WorkEduClsRelaENS.publisher; //发布者Id
objvcc_WorkEduClsRelaENT.SpecifyCompletionDate = objvcc_WorkEduClsRelaENS.SpecifyCompletionDate; //指定完成日期
objvcc_WorkEduClsRelaENT.IsCurrEduCls = objvcc_WorkEduClsRelaENS.IsCurrEduCls; //是否为教学班作业
objvcc_WorkEduClsRelaENT.IsGroupWork = objvcc_WorkEduClsRelaENS.IsGroupWork; //是否为小组作业
objvcc_WorkEduClsRelaENT.CourseStudentGroupId = objvcc_WorkEduClsRelaENS.CourseStudentGroupId; //学生分组表流水号
objvcc_WorkEduClsRelaENT.WorkTypeId = objvcc_WorkEduClsRelaENS.WorkTypeId; //作业类型Id
objvcc_WorkEduClsRelaENT.WorkTypeName = objvcc_WorkEduClsRelaENS.WorkTypeName; //作业类型名称
objvcc_WorkEduClsRelaENT.UpdDate = objvcc_WorkEduClsRelaENS.UpdDate; //修改日期
objvcc_WorkEduClsRelaENT.UpdUserId = objvcc_WorkEduClsRelaENS.UpdUserId; //修改用户Id
objvcc_WorkEduClsRelaENT.Memo = objvcc_WorkEduClsRelaENS.Memo; //备注
objvcc_WorkEduClsRelaENT.StuNum = objvcc_WorkEduClsRelaENS.StuNum; //学生数
objvcc_WorkEduClsRelaENT.EduClsStuNum = objvcc_WorkEduClsRelaENS.EduClsStuNum; //教学班学生数
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
 /// <param name = "objvcc_WorkEduClsRelaENS">源对象</param>
 /// <returns>目标对象=>clsvcc_WorkEduClsRelaEN:objvcc_WorkEduClsRelaENT</returns>
 public static clsvcc_WorkEduClsRelaEN CopyTo(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaENS)
{
try
{
 clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaENT = new clsvcc_WorkEduClsRelaEN()
{
IdWorkEduClsRela = objvcc_WorkEduClsRelaENS.IdWorkEduClsRela, //作业教学班关系流水号
QuestionId = objvcc_WorkEduClsRelaENS.QuestionId, //题目Id
QuestionIndex = objvcc_WorkEduClsRelaENS.QuestionIndex, //题目序号
QuestionName = objvcc_WorkEduClsRelaENS.QuestionName, //题目名称
QuestionContent = objvcc_WorkEduClsRelaENS.QuestionContent, //题目内容
CourseId = objvcc_WorkEduClsRelaENS.CourseId, //课程Id
CourseName = objvcc_WorkEduClsRelaENS.CourseName, //课程名称
CourseChapterId = objvcc_WorkEduClsRelaENS.CourseChapterId, //课程章节ID
CourseChapterName = objvcc_WorkEduClsRelaENS.CourseChapterName, //课程章节名称
ChapterName = objvcc_WorkEduClsRelaENS.ChapterName, //章名
SectionName = objvcc_WorkEduClsRelaENS.SectionName, //节名
ChapterNameSim = objvcc_WorkEduClsRelaENS.ChapterNameSim, //章名简称
SectionNameSim = objvcc_WorkEduClsRelaENS.SectionNameSim, //节名简称
ParentNodeId = objvcc_WorkEduClsRelaENS.ParentNodeId, //父节点编号
CourseChapterReferred = objvcc_WorkEduClsRelaENS.CourseChapterReferred, //节简称
ParentNodeName = objvcc_WorkEduClsRelaENS.ParentNodeName, //父节点名称
ParentNodeReferred = objvcc_WorkEduClsRelaENS.ParentNodeReferred, //章简称
QuestionTypeId = objvcc_WorkEduClsRelaENS.QuestionTypeId, //题目类型Id
QuestionTypeName = objvcc_WorkEduClsRelaENS.QuestionTypeName, //题目类型名
ExamGradeId = objvcc_WorkEduClsRelaENS.ExamGradeId, //题库等级ID
ExamGradeName = objvcc_WorkEduClsRelaENS.ExamGradeName, //题库等级名
AnswerTypeId = objvcc_WorkEduClsRelaENS.AnswerTypeId, //答案类型ID
AnswerModeId = objvcc_WorkEduClsRelaENS.AnswerModeId, //答案模式Id
DefaultValue = objvcc_WorkEduClsRelaENS.DefaultValue, //缺省值
TextDirectId = objvcc_WorkEduClsRelaENS.TextDirectId, //文本方向ID
RelaEvent = objvcc_WorkEduClsRelaENS.RelaEvent, //相关事件
CheckBoxLimitCount = objvcc_WorkEduClsRelaENS.CheckBoxLimitCount, //复选框限制数
AnswerAttLimitSize = objvcc_WorkEduClsRelaENS.AnswerAttLimitSize, //回答附件限制大小
LimitedResourceType = objvcc_WorkEduClsRelaENS.LimitedResourceType, //限制资源类型
QuestionTypeId4Course = objvcc_WorkEduClsRelaENS.QuestionTypeId4Course, //题目类型Id4课程
QuestionTypeName4Course = objvcc_WorkEduClsRelaENS.QuestionTypeName4Course, //题目类型名4课程
IdCurrEduCls = objvcc_WorkEduClsRelaENS.IdCurrEduCls, //教学班流水号
CurrEduClsId = objvcc_WorkEduClsRelaENS.CurrEduClsId, //教学班Id
EduClsName = objvcc_WorkEduClsRelaENS.EduClsName, //教学班名
Scores = objvcc_WorkEduClsRelaENS.Scores, //分值
TeacherId = objvcc_WorkEduClsRelaENS.TeacherId, //教师工号
IsPublish = objvcc_WorkEduClsRelaENS.IsPublish, //是否发布
PubDate = objvcc_WorkEduClsRelaENS.PubDate, //发布日期
publisher = objvcc_WorkEduClsRelaENS.publisher, //发布者Id
SpecifyCompletionDate = objvcc_WorkEduClsRelaENS.SpecifyCompletionDate, //指定完成日期
IsCurrEduCls = objvcc_WorkEduClsRelaENS.IsCurrEduCls, //是否为教学班作业
IsGroupWork = objvcc_WorkEduClsRelaENS.IsGroupWork, //是否为小组作业
CourseStudentGroupId = objvcc_WorkEduClsRelaENS.CourseStudentGroupId, //学生分组表流水号
WorkTypeId = objvcc_WorkEduClsRelaENS.WorkTypeId, //作业类型Id
WorkTypeName = objvcc_WorkEduClsRelaENS.WorkTypeName, //作业类型名称
UpdDate = objvcc_WorkEduClsRelaENS.UpdDate, //修改日期
UpdUserId = objvcc_WorkEduClsRelaENS.UpdUserId, //修改用户Id
Memo = objvcc_WorkEduClsRelaENS.Memo, //备注
StuNum = objvcc_WorkEduClsRelaENS.StuNum, //学生数
EduClsStuNum = objvcc_WorkEduClsRelaENS.EduClsStuNum, //教学班学生数
};
 return objvcc_WorkEduClsRelaENT;
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
public static void CheckProperty4Condition(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN)
{
 clsvcc_WorkEduClsRelaBL.vcc_WorkEduClsRelaDA.CheckProperty4Condition(objvcc_WorkEduClsRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.IdWorkEduClsRela) == true)
{
string strComparisonOpIdWorkEduClsRela = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.IdWorkEduClsRela];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkEduClsRela.IdWorkEduClsRela, objvcc_WorkEduClsRelaCond.IdWorkEduClsRela, strComparisonOpIdWorkEduClsRela);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.QuestionId) == true)
{
string strComparisonOpQuestionId = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkEduClsRela.QuestionId, objvcc_WorkEduClsRelaCond.QuestionId, strComparisonOpQuestionId);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.QuestionIndex) == true)
{
string strComparisonOpQuestionIndex = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkEduClsRela.QuestionIndex, objvcc_WorkEduClsRelaCond.QuestionIndex, strComparisonOpQuestionIndex);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.QuestionName) == true)
{
string strComparisonOpQuestionName = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.QuestionName, objvcc_WorkEduClsRelaCond.QuestionName, strComparisonOpQuestionName);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.QuestionContent) == true)
{
string strComparisonOpQuestionContent = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.QuestionContent, objvcc_WorkEduClsRelaCond.QuestionContent, strComparisonOpQuestionContent);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.CourseId, objvcc_WorkEduClsRelaCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.CourseName) == true)
{
string strComparisonOpCourseName = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.CourseName, objvcc_WorkEduClsRelaCond.CourseName, strComparisonOpCourseName);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.CourseChapterId, objvcc_WorkEduClsRelaCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.CourseChapterName, objvcc_WorkEduClsRelaCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.ChapterName) == true)
{
string strComparisonOpChapterName = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.ChapterName, objvcc_WorkEduClsRelaCond.ChapterName, strComparisonOpChapterName);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.SectionName) == true)
{
string strComparisonOpSectionName = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.SectionName, objvcc_WorkEduClsRelaCond.SectionName, strComparisonOpSectionName);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.ChapterNameSim, objvcc_WorkEduClsRelaCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.SectionNameSim) == true)
{
string strComparisonOpSectionNameSim = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.SectionNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.SectionNameSim, objvcc_WorkEduClsRelaCond.SectionNameSim, strComparisonOpSectionNameSim);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.ParentNodeId) == true)
{
string strComparisonOpParentNodeId = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.ParentNodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.ParentNodeId, objvcc_WorkEduClsRelaCond.ParentNodeId, strComparisonOpParentNodeId);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.CourseChapterReferred) == true)
{
string strComparisonOpCourseChapterReferred = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.CourseChapterReferred, objvcc_WorkEduClsRelaCond.CourseChapterReferred, strComparisonOpCourseChapterReferred);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.ParentNodeName) == true)
{
string strComparisonOpParentNodeName = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.ParentNodeName, objvcc_WorkEduClsRelaCond.ParentNodeName, strComparisonOpParentNodeName);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.ParentNodeReferred) == true)
{
string strComparisonOpParentNodeReferred = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.ParentNodeReferred, objvcc_WorkEduClsRelaCond.ParentNodeReferred, strComparisonOpParentNodeReferred);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.QuestionTypeId, objvcc_WorkEduClsRelaCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.QuestionTypeName) == true)
{
string strComparisonOpQuestionTypeName = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.QuestionTypeName, objvcc_WorkEduClsRelaCond.QuestionTypeName, strComparisonOpQuestionTypeName);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.ExamGradeId) == true)
{
string strComparisonOpExamGradeId = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.ExamGradeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.ExamGradeId, objvcc_WorkEduClsRelaCond.ExamGradeId, strComparisonOpExamGradeId);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.ExamGradeName) == true)
{
string strComparisonOpExamGradeName = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.ExamGradeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.ExamGradeName, objvcc_WorkEduClsRelaCond.ExamGradeName, strComparisonOpExamGradeName);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.AnswerTypeId) == true)
{
string strComparisonOpAnswerTypeId = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.AnswerTypeId, objvcc_WorkEduClsRelaCond.AnswerTypeId, strComparisonOpAnswerTypeId);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.AnswerModeId) == true)
{
string strComparisonOpAnswerModeId = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.AnswerModeId, objvcc_WorkEduClsRelaCond.AnswerModeId, strComparisonOpAnswerModeId);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.DefaultValue, objvcc_WorkEduClsRelaCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.TextDirectId) == true)
{
string strComparisonOpTextDirectId = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.TextDirectId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.TextDirectId, objvcc_WorkEduClsRelaCond.TextDirectId, strComparisonOpTextDirectId);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.RelaEvent) == true)
{
string strComparisonOpRelaEvent = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.RelaEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.RelaEvent, objvcc_WorkEduClsRelaCond.RelaEvent, strComparisonOpRelaEvent);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.CheckBoxLimitCount) == true)
{
string strComparisonOpCheckBoxLimitCount = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.CheckBoxLimitCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkEduClsRela.CheckBoxLimitCount, objvcc_WorkEduClsRelaCond.CheckBoxLimitCount, strComparisonOpCheckBoxLimitCount);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.AnswerAttLimitSize) == true)
{
string strComparisonOpAnswerAttLimitSize = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.AnswerAttLimitSize];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkEduClsRela.AnswerAttLimitSize, objvcc_WorkEduClsRelaCond.AnswerAttLimitSize, strComparisonOpAnswerAttLimitSize);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.LimitedResourceType) == true)
{
string strComparisonOpLimitedResourceType = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.LimitedResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.LimitedResourceType, objvcc_WorkEduClsRelaCond.LimitedResourceType, strComparisonOpLimitedResourceType);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.QuestionTypeId4Course) == true)
{
string strComparisonOpQuestionTypeId4Course = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionTypeId4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.QuestionTypeId4Course, objvcc_WorkEduClsRelaCond.QuestionTypeId4Course, strComparisonOpQuestionTypeId4Course);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.QuestionTypeName4Course) == true)
{
string strComparisonOpQuestionTypeName4Course = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionTypeName4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.QuestionTypeName4Course, objvcc_WorkEduClsRelaCond.QuestionTypeName4Course, strComparisonOpQuestionTypeName4Course);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.IdCurrEduCls, objvcc_WorkEduClsRelaCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.CurrEduClsId) == true)
{
string strComparisonOpCurrEduClsId = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.CurrEduClsId, objvcc_WorkEduClsRelaCond.CurrEduClsId, strComparisonOpCurrEduClsId);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.EduClsName) == true)
{
string strComparisonOpEduClsName = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.EduClsName, objvcc_WorkEduClsRelaCond.EduClsName, strComparisonOpEduClsName);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.Scores) == true)
{
string strComparisonOpScores = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkEduClsRela.Scores, objvcc_WorkEduClsRelaCond.Scores, strComparisonOpScores);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.TeacherId) == true)
{
string strComparisonOpTeacherId = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.TeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.TeacherId, objvcc_WorkEduClsRelaCond.TeacherId, strComparisonOpTeacherId);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.IsPublish) == true)
{
if (objvcc_WorkEduClsRelaCond.IsPublish == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkEduClsRela.IsPublish);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkEduClsRela.IsPublish);
}
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.PubDate) == true)
{
string strComparisonOpPubDate = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.PubDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.PubDate, objvcc_WorkEduClsRelaCond.PubDate, strComparisonOpPubDate);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.publisher) == true)
{
string strComparisonOppublisher = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.publisher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.publisher, objvcc_WorkEduClsRelaCond.publisher, strComparisonOppublisher);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.SpecifyCompletionDate) == true)
{
string strComparisonOpSpecifyCompletionDate = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.SpecifyCompletionDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.SpecifyCompletionDate, objvcc_WorkEduClsRelaCond.SpecifyCompletionDate, strComparisonOpSpecifyCompletionDate);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.IsCurrEduCls) == true)
{
if (objvcc_WorkEduClsRelaCond.IsCurrEduCls == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkEduClsRela.IsCurrEduCls);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkEduClsRela.IsCurrEduCls);
}
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.IsGroupWork) == true)
{
if (objvcc_WorkEduClsRelaCond.IsGroupWork == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkEduClsRela.IsGroupWork);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkEduClsRela.IsGroupWork);
}
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.CourseStudentGroupId) == true)
{
string strComparisonOpCourseStudentGroupId = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.CourseStudentGroupId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkEduClsRela.CourseStudentGroupId, objvcc_WorkEduClsRelaCond.CourseStudentGroupId, strComparisonOpCourseStudentGroupId);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.WorkTypeId) == true)
{
string strComparisonOpWorkTypeId = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.WorkTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.WorkTypeId, objvcc_WorkEduClsRelaCond.WorkTypeId, strComparisonOpWorkTypeId);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.WorkTypeName) == true)
{
string strComparisonOpWorkTypeName = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.WorkTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.WorkTypeName, objvcc_WorkEduClsRelaCond.WorkTypeName, strComparisonOpWorkTypeName);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.UpdDate, objvcc_WorkEduClsRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.UpdUserId, objvcc_WorkEduClsRelaCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.Memo) == true)
{
string strComparisonOpMemo = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.Memo, objvcc_WorkEduClsRelaCond.Memo, strComparisonOpMemo);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.StuNum) == true)
{
string strComparisonOpStuNum = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.StuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkEduClsRela.StuNum, objvcc_WorkEduClsRelaCond.StuNum, strComparisonOpStuNum);
}
if (objvcc_WorkEduClsRelaCond.IsUpdated(convcc_WorkEduClsRela.EduClsStuNum) == true)
{
string strComparisonOpEduClsStuNum = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[convcc_WorkEduClsRela.EduClsStuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkEduClsRela.EduClsStuNum, objvcc_WorkEduClsRelaCond.EduClsStuNum, strComparisonOpEduClsStuNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_WorkEduClsRela
{
public virtual bool UpdRelaTabDate(long lngIdWorkEduClsRela, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v作业教学班关系表(vcc_WorkEduClsRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_WorkEduClsRelaBL
{
public static RelatedActions_vcc_WorkEduClsRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_WorkEduClsRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_WorkEduClsRelaDA vcc_WorkEduClsRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_WorkEduClsRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_WorkEduClsRelaBL()
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
if (string.IsNullOrEmpty(clsvcc_WorkEduClsRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_WorkEduClsRelaEN._ConnectString);
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
public static DataTable GetDataTable_vcc_WorkEduClsRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_WorkEduClsRelaDA.GetDataTable_vcc_WorkEduClsRela(strWhereCond);
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
objDT = vcc_WorkEduClsRelaDA.GetDataTable(strWhereCond);
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
objDT = vcc_WorkEduClsRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_WorkEduClsRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_WorkEduClsRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_WorkEduClsRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_WorkEduClsRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_WorkEduClsRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_WorkEduClsRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdWorkEduClsRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcc_WorkEduClsRelaEN> GetObjLstByIdWorkEduClsRelaLst(List<long> arrIdWorkEduClsRelaLst)
{
List<clsvcc_WorkEduClsRelaEN> arrObjLst = new List<clsvcc_WorkEduClsRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdWorkEduClsRelaLst);
 string strWhereCond = string.Format("IdWorkEduClsRela in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = new clsvcc_WorkEduClsRelaEN();
try
{
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela = Int32.Parse(objRow[convcc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkEduClsRelaEN.QuestionId = objRow[convcc_WorkEduClsRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkEduClsRelaEN.QuestionIndex = objRow[convcc_WorkEduClsRela.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkEduClsRelaEN.QuestionName = objRow[convcc_WorkEduClsRela.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkEduClsRelaEN.QuestionContent = objRow[convcc_WorkEduClsRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkEduClsRelaEN.CourseId = objRow[convcc_WorkEduClsRela.CourseId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEduClsRelaEN.CourseName = objRow[convcc_WorkEduClsRela.CourseName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEduClsRelaEN.CourseChapterId = objRow[convcc_WorkEduClsRela.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEduClsRelaEN.CourseChapterName = objRow[convcc_WorkEduClsRela.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEduClsRelaEN.ChapterName = objRow[convcc_WorkEduClsRela.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterName].ToString().Trim(); //章名
objvcc_WorkEduClsRelaEN.SectionName = objRow[convcc_WorkEduClsRela.SectionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionName].ToString().Trim(); //节名
objvcc_WorkEduClsRelaEN.ChapterNameSim = objRow[convcc_WorkEduClsRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEduClsRelaEN.SectionNameSim = objRow[convcc_WorkEduClsRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEduClsRelaEN.ParentNodeId = objRow[convcc_WorkEduClsRela.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkEduClsRelaEN.CourseChapterReferred = objRow[convcc_WorkEduClsRela.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEduClsRelaEN.ParentNodeName = objRow[convcc_WorkEduClsRela.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEduClsRelaEN.ParentNodeReferred = objRow[convcc_WorkEduClsRela.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEduClsRelaEN.QuestionTypeId = objRow[convcc_WorkEduClsRela.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkEduClsRelaEN.QuestionTypeName = objRow[convcc_WorkEduClsRela.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkEduClsRelaEN.ExamGradeId = objRow[convcc_WorkEduClsRela.ExamGradeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_WorkEduClsRelaEN.ExamGradeName = objRow[convcc_WorkEduClsRela.ExamGradeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_WorkEduClsRelaEN.AnswerTypeId = objRow[convcc_WorkEduClsRela.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkEduClsRelaEN.AnswerModeId = objRow[convcc_WorkEduClsRela.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkEduClsRelaEN.DefaultValue = objRow[convcc_WorkEduClsRela.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkEduClsRelaEN.TextDirectId = objRow[convcc_WorkEduClsRela.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkEduClsRelaEN.RelaEvent = objRow[convcc_WorkEduClsRela.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkEduClsRelaEN.CheckBoxLimitCount = objRow[convcc_WorkEduClsRela.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkEduClsRelaEN.AnswerAttLimitSize = objRow[convcc_WorkEduClsRela.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEduClsRelaEN.LimitedResourceType = objRow[convcc_WorkEduClsRela.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEduClsRelaEN.QuestionTypeId4Course = objRow[convcc_WorkEduClsRela.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkEduClsRelaEN.QuestionTypeName4Course = objRow[convcc_WorkEduClsRela.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkEduClsRelaEN.IdCurrEduCls = objRow[convcc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkEduClsRelaEN.CurrEduClsId = objRow[convcc_WorkEduClsRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkEduClsRelaEN.EduClsName = objRow[convcc_WorkEduClsRela.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkEduClsRelaEN.Scores = objRow[convcc_WorkEduClsRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkEduClsRela.Scores].ToString().Trim()); //分值
objvcc_WorkEduClsRelaEN.TeacherId = objRow[convcc_WorkEduClsRela.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkEduClsRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkEduClsRelaEN.PubDate = objRow[convcc_WorkEduClsRela.PubDate].ToString().Trim(); //发布日期
objvcc_WorkEduClsRelaEN.publisher = objRow[convcc_WorkEduClsRela.publisher] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.publisher].ToString().Trim(); //发布者Id
objvcc_WorkEduClsRelaEN.SpecifyCompletionDate = objRow[convcc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkEduClsRelaEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkEduClsRelaEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkEduClsRelaEN.CourseStudentGroupId = objRow[convcc_WorkEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkEduClsRelaEN.WorkTypeId = objRow[convcc_WorkEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkEduClsRelaEN.WorkTypeName = objRow[convcc_WorkEduClsRela.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkEduClsRelaEN.UpdDate = objRow[convcc_WorkEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEduClsRelaEN.UpdUserId = objRow[convcc_WorkEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEduClsRelaEN.Memo = objRow[convcc_WorkEduClsRela.Memo] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.Memo].ToString().Trim(); //备注
objvcc_WorkEduClsRelaEN.StuNum = objRow[convcc_WorkEduClsRela.StuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.StuNum].ToString().Trim()); //学生数
objvcc_WorkEduClsRelaEN.EduClsStuNum = objRow[convcc_WorkEduClsRela.EduClsStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.EduClsStuNum].ToString().Trim()); //教学班学生数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkEduClsRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdWorkEduClsRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_WorkEduClsRelaEN> GetObjLstByIdWorkEduClsRelaLstCache(List<long> arrIdWorkEduClsRelaLst)
{
string strKey = string.Format("{0}", clsvcc_WorkEduClsRelaEN._CurrTabName);
List<clsvcc_WorkEduClsRelaEN> arrvcc_WorkEduClsRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_WorkEduClsRelaEN> arrvcc_WorkEduClsRelaObjLst_Sel =
arrvcc_WorkEduClsRelaObjLstCache
.Where(x => arrIdWorkEduClsRelaLst.Contains(x.IdWorkEduClsRela));
return arrvcc_WorkEduClsRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkEduClsRelaEN> GetObjLst(string strWhereCond)
{
List<clsvcc_WorkEduClsRelaEN> arrObjLst = new List<clsvcc_WorkEduClsRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = new clsvcc_WorkEduClsRelaEN();
try
{
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela = Int32.Parse(objRow[convcc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkEduClsRelaEN.QuestionId = objRow[convcc_WorkEduClsRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkEduClsRelaEN.QuestionIndex = objRow[convcc_WorkEduClsRela.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkEduClsRelaEN.QuestionName = objRow[convcc_WorkEduClsRela.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkEduClsRelaEN.QuestionContent = objRow[convcc_WorkEduClsRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkEduClsRelaEN.CourseId = objRow[convcc_WorkEduClsRela.CourseId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEduClsRelaEN.CourseName = objRow[convcc_WorkEduClsRela.CourseName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEduClsRelaEN.CourseChapterId = objRow[convcc_WorkEduClsRela.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEduClsRelaEN.CourseChapterName = objRow[convcc_WorkEduClsRela.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEduClsRelaEN.ChapterName = objRow[convcc_WorkEduClsRela.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterName].ToString().Trim(); //章名
objvcc_WorkEduClsRelaEN.SectionName = objRow[convcc_WorkEduClsRela.SectionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionName].ToString().Trim(); //节名
objvcc_WorkEduClsRelaEN.ChapterNameSim = objRow[convcc_WorkEduClsRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEduClsRelaEN.SectionNameSim = objRow[convcc_WorkEduClsRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEduClsRelaEN.ParentNodeId = objRow[convcc_WorkEduClsRela.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkEduClsRelaEN.CourseChapterReferred = objRow[convcc_WorkEduClsRela.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEduClsRelaEN.ParentNodeName = objRow[convcc_WorkEduClsRela.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEduClsRelaEN.ParentNodeReferred = objRow[convcc_WorkEduClsRela.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEduClsRelaEN.QuestionTypeId = objRow[convcc_WorkEduClsRela.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkEduClsRelaEN.QuestionTypeName = objRow[convcc_WorkEduClsRela.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkEduClsRelaEN.ExamGradeId = objRow[convcc_WorkEduClsRela.ExamGradeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_WorkEduClsRelaEN.ExamGradeName = objRow[convcc_WorkEduClsRela.ExamGradeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_WorkEduClsRelaEN.AnswerTypeId = objRow[convcc_WorkEduClsRela.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkEduClsRelaEN.AnswerModeId = objRow[convcc_WorkEduClsRela.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkEduClsRelaEN.DefaultValue = objRow[convcc_WorkEduClsRela.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkEduClsRelaEN.TextDirectId = objRow[convcc_WorkEduClsRela.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkEduClsRelaEN.RelaEvent = objRow[convcc_WorkEduClsRela.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkEduClsRelaEN.CheckBoxLimitCount = objRow[convcc_WorkEduClsRela.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkEduClsRelaEN.AnswerAttLimitSize = objRow[convcc_WorkEduClsRela.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEduClsRelaEN.LimitedResourceType = objRow[convcc_WorkEduClsRela.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEduClsRelaEN.QuestionTypeId4Course = objRow[convcc_WorkEduClsRela.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkEduClsRelaEN.QuestionTypeName4Course = objRow[convcc_WorkEduClsRela.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkEduClsRelaEN.IdCurrEduCls = objRow[convcc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkEduClsRelaEN.CurrEduClsId = objRow[convcc_WorkEduClsRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkEduClsRelaEN.EduClsName = objRow[convcc_WorkEduClsRela.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkEduClsRelaEN.Scores = objRow[convcc_WorkEduClsRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkEduClsRela.Scores].ToString().Trim()); //分值
objvcc_WorkEduClsRelaEN.TeacherId = objRow[convcc_WorkEduClsRela.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkEduClsRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkEduClsRelaEN.PubDate = objRow[convcc_WorkEduClsRela.PubDate].ToString().Trim(); //发布日期
objvcc_WorkEduClsRelaEN.publisher = objRow[convcc_WorkEduClsRela.publisher] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.publisher].ToString().Trim(); //发布者Id
objvcc_WorkEduClsRelaEN.SpecifyCompletionDate = objRow[convcc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkEduClsRelaEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkEduClsRelaEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkEduClsRelaEN.CourseStudentGroupId = objRow[convcc_WorkEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkEduClsRelaEN.WorkTypeId = objRow[convcc_WorkEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkEduClsRelaEN.WorkTypeName = objRow[convcc_WorkEduClsRela.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkEduClsRelaEN.UpdDate = objRow[convcc_WorkEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEduClsRelaEN.UpdUserId = objRow[convcc_WorkEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEduClsRelaEN.Memo = objRow[convcc_WorkEduClsRela.Memo] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.Memo].ToString().Trim(); //备注
objvcc_WorkEduClsRelaEN.StuNum = objRow[convcc_WorkEduClsRela.StuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.StuNum].ToString().Trim()); //学生数
objvcc_WorkEduClsRelaEN.EduClsStuNum = objRow[convcc_WorkEduClsRela.EduClsStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.EduClsStuNum].ToString().Trim()); //教学班学生数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkEduClsRelaEN);
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
public static List<clsvcc_WorkEduClsRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_WorkEduClsRelaEN> arrObjLst = new List<clsvcc_WorkEduClsRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = new clsvcc_WorkEduClsRelaEN();
try
{
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela = Int32.Parse(objRow[convcc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkEduClsRelaEN.QuestionId = objRow[convcc_WorkEduClsRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkEduClsRelaEN.QuestionIndex = objRow[convcc_WorkEduClsRela.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkEduClsRelaEN.QuestionName = objRow[convcc_WorkEduClsRela.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkEduClsRelaEN.QuestionContent = objRow[convcc_WorkEduClsRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkEduClsRelaEN.CourseId = objRow[convcc_WorkEduClsRela.CourseId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEduClsRelaEN.CourseName = objRow[convcc_WorkEduClsRela.CourseName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEduClsRelaEN.CourseChapterId = objRow[convcc_WorkEduClsRela.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEduClsRelaEN.CourseChapterName = objRow[convcc_WorkEduClsRela.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEduClsRelaEN.ChapterName = objRow[convcc_WorkEduClsRela.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterName].ToString().Trim(); //章名
objvcc_WorkEduClsRelaEN.SectionName = objRow[convcc_WorkEduClsRela.SectionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionName].ToString().Trim(); //节名
objvcc_WorkEduClsRelaEN.ChapterNameSim = objRow[convcc_WorkEduClsRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEduClsRelaEN.SectionNameSim = objRow[convcc_WorkEduClsRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEduClsRelaEN.ParentNodeId = objRow[convcc_WorkEduClsRela.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkEduClsRelaEN.CourseChapterReferred = objRow[convcc_WorkEduClsRela.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEduClsRelaEN.ParentNodeName = objRow[convcc_WorkEduClsRela.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEduClsRelaEN.ParentNodeReferred = objRow[convcc_WorkEduClsRela.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEduClsRelaEN.QuestionTypeId = objRow[convcc_WorkEduClsRela.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkEduClsRelaEN.QuestionTypeName = objRow[convcc_WorkEduClsRela.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkEduClsRelaEN.ExamGradeId = objRow[convcc_WorkEduClsRela.ExamGradeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_WorkEduClsRelaEN.ExamGradeName = objRow[convcc_WorkEduClsRela.ExamGradeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_WorkEduClsRelaEN.AnswerTypeId = objRow[convcc_WorkEduClsRela.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkEduClsRelaEN.AnswerModeId = objRow[convcc_WorkEduClsRela.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkEduClsRelaEN.DefaultValue = objRow[convcc_WorkEduClsRela.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkEduClsRelaEN.TextDirectId = objRow[convcc_WorkEduClsRela.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkEduClsRelaEN.RelaEvent = objRow[convcc_WorkEduClsRela.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkEduClsRelaEN.CheckBoxLimitCount = objRow[convcc_WorkEduClsRela.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkEduClsRelaEN.AnswerAttLimitSize = objRow[convcc_WorkEduClsRela.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEduClsRelaEN.LimitedResourceType = objRow[convcc_WorkEduClsRela.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEduClsRelaEN.QuestionTypeId4Course = objRow[convcc_WorkEduClsRela.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkEduClsRelaEN.QuestionTypeName4Course = objRow[convcc_WorkEduClsRela.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkEduClsRelaEN.IdCurrEduCls = objRow[convcc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkEduClsRelaEN.CurrEduClsId = objRow[convcc_WorkEduClsRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkEduClsRelaEN.EduClsName = objRow[convcc_WorkEduClsRela.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkEduClsRelaEN.Scores = objRow[convcc_WorkEduClsRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkEduClsRela.Scores].ToString().Trim()); //分值
objvcc_WorkEduClsRelaEN.TeacherId = objRow[convcc_WorkEduClsRela.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkEduClsRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkEduClsRelaEN.PubDate = objRow[convcc_WorkEduClsRela.PubDate].ToString().Trim(); //发布日期
objvcc_WorkEduClsRelaEN.publisher = objRow[convcc_WorkEduClsRela.publisher] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.publisher].ToString().Trim(); //发布者Id
objvcc_WorkEduClsRelaEN.SpecifyCompletionDate = objRow[convcc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkEduClsRelaEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkEduClsRelaEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkEduClsRelaEN.CourseStudentGroupId = objRow[convcc_WorkEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkEduClsRelaEN.WorkTypeId = objRow[convcc_WorkEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkEduClsRelaEN.WorkTypeName = objRow[convcc_WorkEduClsRela.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkEduClsRelaEN.UpdDate = objRow[convcc_WorkEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEduClsRelaEN.UpdUserId = objRow[convcc_WorkEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEduClsRelaEN.Memo = objRow[convcc_WorkEduClsRela.Memo] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.Memo].ToString().Trim(); //备注
objvcc_WorkEduClsRelaEN.StuNum = objRow[convcc_WorkEduClsRela.StuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.StuNum].ToString().Trim()); //学生数
objvcc_WorkEduClsRelaEN.EduClsStuNum = objRow[convcc_WorkEduClsRela.EduClsStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.EduClsStuNum].ToString().Trim()); //教学班学生数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkEduClsRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_WorkEduClsRelaEN> GetSubObjLstCache(clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaCond)
{
List<clsvcc_WorkEduClsRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_WorkEduClsRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_WorkEduClsRela.AttributeName)
{
if (objvcc_WorkEduClsRelaCond.IsUpdated(strFldName) == false) continue;
if (objvcc_WorkEduClsRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkEduClsRelaCond[strFldName].ToString());
}
else
{
if (objvcc_WorkEduClsRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkEduClsRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_WorkEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_WorkEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_WorkEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_WorkEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_WorkEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_WorkEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_WorkEduClsRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_WorkEduClsRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_WorkEduClsRelaCond[strFldName]));
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
public static List<clsvcc_WorkEduClsRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_WorkEduClsRelaEN> arrObjLst = new List<clsvcc_WorkEduClsRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = new clsvcc_WorkEduClsRelaEN();
try
{
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela = Int32.Parse(objRow[convcc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkEduClsRelaEN.QuestionId = objRow[convcc_WorkEduClsRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkEduClsRelaEN.QuestionIndex = objRow[convcc_WorkEduClsRela.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkEduClsRelaEN.QuestionName = objRow[convcc_WorkEduClsRela.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkEduClsRelaEN.QuestionContent = objRow[convcc_WorkEduClsRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkEduClsRelaEN.CourseId = objRow[convcc_WorkEduClsRela.CourseId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEduClsRelaEN.CourseName = objRow[convcc_WorkEduClsRela.CourseName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEduClsRelaEN.CourseChapterId = objRow[convcc_WorkEduClsRela.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEduClsRelaEN.CourseChapterName = objRow[convcc_WorkEduClsRela.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEduClsRelaEN.ChapterName = objRow[convcc_WorkEduClsRela.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterName].ToString().Trim(); //章名
objvcc_WorkEduClsRelaEN.SectionName = objRow[convcc_WorkEduClsRela.SectionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionName].ToString().Trim(); //节名
objvcc_WorkEduClsRelaEN.ChapterNameSim = objRow[convcc_WorkEduClsRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEduClsRelaEN.SectionNameSim = objRow[convcc_WorkEduClsRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEduClsRelaEN.ParentNodeId = objRow[convcc_WorkEduClsRela.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkEduClsRelaEN.CourseChapterReferred = objRow[convcc_WorkEduClsRela.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEduClsRelaEN.ParentNodeName = objRow[convcc_WorkEduClsRela.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEduClsRelaEN.ParentNodeReferred = objRow[convcc_WorkEduClsRela.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEduClsRelaEN.QuestionTypeId = objRow[convcc_WorkEduClsRela.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkEduClsRelaEN.QuestionTypeName = objRow[convcc_WorkEduClsRela.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkEduClsRelaEN.ExamGradeId = objRow[convcc_WorkEduClsRela.ExamGradeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_WorkEduClsRelaEN.ExamGradeName = objRow[convcc_WorkEduClsRela.ExamGradeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_WorkEduClsRelaEN.AnswerTypeId = objRow[convcc_WorkEduClsRela.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkEduClsRelaEN.AnswerModeId = objRow[convcc_WorkEduClsRela.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkEduClsRelaEN.DefaultValue = objRow[convcc_WorkEduClsRela.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkEduClsRelaEN.TextDirectId = objRow[convcc_WorkEduClsRela.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkEduClsRelaEN.RelaEvent = objRow[convcc_WorkEduClsRela.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkEduClsRelaEN.CheckBoxLimitCount = objRow[convcc_WorkEduClsRela.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkEduClsRelaEN.AnswerAttLimitSize = objRow[convcc_WorkEduClsRela.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEduClsRelaEN.LimitedResourceType = objRow[convcc_WorkEduClsRela.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEduClsRelaEN.QuestionTypeId4Course = objRow[convcc_WorkEduClsRela.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkEduClsRelaEN.QuestionTypeName4Course = objRow[convcc_WorkEduClsRela.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkEduClsRelaEN.IdCurrEduCls = objRow[convcc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkEduClsRelaEN.CurrEduClsId = objRow[convcc_WorkEduClsRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkEduClsRelaEN.EduClsName = objRow[convcc_WorkEduClsRela.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkEduClsRelaEN.Scores = objRow[convcc_WorkEduClsRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkEduClsRela.Scores].ToString().Trim()); //分值
objvcc_WorkEduClsRelaEN.TeacherId = objRow[convcc_WorkEduClsRela.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkEduClsRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkEduClsRelaEN.PubDate = objRow[convcc_WorkEduClsRela.PubDate].ToString().Trim(); //发布日期
objvcc_WorkEduClsRelaEN.publisher = objRow[convcc_WorkEduClsRela.publisher] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.publisher].ToString().Trim(); //发布者Id
objvcc_WorkEduClsRelaEN.SpecifyCompletionDate = objRow[convcc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkEduClsRelaEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkEduClsRelaEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkEduClsRelaEN.CourseStudentGroupId = objRow[convcc_WorkEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkEduClsRelaEN.WorkTypeId = objRow[convcc_WorkEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkEduClsRelaEN.WorkTypeName = objRow[convcc_WorkEduClsRela.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkEduClsRelaEN.UpdDate = objRow[convcc_WorkEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEduClsRelaEN.UpdUserId = objRow[convcc_WorkEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEduClsRelaEN.Memo = objRow[convcc_WorkEduClsRela.Memo] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.Memo].ToString().Trim(); //备注
objvcc_WorkEduClsRelaEN.StuNum = objRow[convcc_WorkEduClsRela.StuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.StuNum].ToString().Trim()); //学生数
objvcc_WorkEduClsRelaEN.EduClsStuNum = objRow[convcc_WorkEduClsRela.EduClsStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.EduClsStuNum].ToString().Trim()); //教学班学生数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkEduClsRelaEN);
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
public static List<clsvcc_WorkEduClsRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_WorkEduClsRelaEN> arrObjLst = new List<clsvcc_WorkEduClsRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = new clsvcc_WorkEduClsRelaEN();
try
{
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela = Int32.Parse(objRow[convcc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkEduClsRelaEN.QuestionId = objRow[convcc_WorkEduClsRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkEduClsRelaEN.QuestionIndex = objRow[convcc_WorkEduClsRela.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkEduClsRelaEN.QuestionName = objRow[convcc_WorkEduClsRela.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkEduClsRelaEN.QuestionContent = objRow[convcc_WorkEduClsRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkEduClsRelaEN.CourseId = objRow[convcc_WorkEduClsRela.CourseId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEduClsRelaEN.CourseName = objRow[convcc_WorkEduClsRela.CourseName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEduClsRelaEN.CourseChapterId = objRow[convcc_WorkEduClsRela.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEduClsRelaEN.CourseChapterName = objRow[convcc_WorkEduClsRela.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEduClsRelaEN.ChapterName = objRow[convcc_WorkEduClsRela.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterName].ToString().Trim(); //章名
objvcc_WorkEduClsRelaEN.SectionName = objRow[convcc_WorkEduClsRela.SectionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionName].ToString().Trim(); //节名
objvcc_WorkEduClsRelaEN.ChapterNameSim = objRow[convcc_WorkEduClsRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEduClsRelaEN.SectionNameSim = objRow[convcc_WorkEduClsRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEduClsRelaEN.ParentNodeId = objRow[convcc_WorkEduClsRela.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkEduClsRelaEN.CourseChapterReferred = objRow[convcc_WorkEduClsRela.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEduClsRelaEN.ParentNodeName = objRow[convcc_WorkEduClsRela.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEduClsRelaEN.ParentNodeReferred = objRow[convcc_WorkEduClsRela.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEduClsRelaEN.QuestionTypeId = objRow[convcc_WorkEduClsRela.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkEduClsRelaEN.QuestionTypeName = objRow[convcc_WorkEduClsRela.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkEduClsRelaEN.ExamGradeId = objRow[convcc_WorkEduClsRela.ExamGradeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_WorkEduClsRelaEN.ExamGradeName = objRow[convcc_WorkEduClsRela.ExamGradeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_WorkEduClsRelaEN.AnswerTypeId = objRow[convcc_WorkEduClsRela.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkEduClsRelaEN.AnswerModeId = objRow[convcc_WorkEduClsRela.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkEduClsRelaEN.DefaultValue = objRow[convcc_WorkEduClsRela.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkEduClsRelaEN.TextDirectId = objRow[convcc_WorkEduClsRela.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkEduClsRelaEN.RelaEvent = objRow[convcc_WorkEduClsRela.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkEduClsRelaEN.CheckBoxLimitCount = objRow[convcc_WorkEduClsRela.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkEduClsRelaEN.AnswerAttLimitSize = objRow[convcc_WorkEduClsRela.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEduClsRelaEN.LimitedResourceType = objRow[convcc_WorkEduClsRela.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEduClsRelaEN.QuestionTypeId4Course = objRow[convcc_WorkEduClsRela.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkEduClsRelaEN.QuestionTypeName4Course = objRow[convcc_WorkEduClsRela.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkEduClsRelaEN.IdCurrEduCls = objRow[convcc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkEduClsRelaEN.CurrEduClsId = objRow[convcc_WorkEduClsRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkEduClsRelaEN.EduClsName = objRow[convcc_WorkEduClsRela.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkEduClsRelaEN.Scores = objRow[convcc_WorkEduClsRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkEduClsRela.Scores].ToString().Trim()); //分值
objvcc_WorkEduClsRelaEN.TeacherId = objRow[convcc_WorkEduClsRela.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkEduClsRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkEduClsRelaEN.PubDate = objRow[convcc_WorkEduClsRela.PubDate].ToString().Trim(); //发布日期
objvcc_WorkEduClsRelaEN.publisher = objRow[convcc_WorkEduClsRela.publisher] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.publisher].ToString().Trim(); //发布者Id
objvcc_WorkEduClsRelaEN.SpecifyCompletionDate = objRow[convcc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkEduClsRelaEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkEduClsRelaEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkEduClsRelaEN.CourseStudentGroupId = objRow[convcc_WorkEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkEduClsRelaEN.WorkTypeId = objRow[convcc_WorkEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkEduClsRelaEN.WorkTypeName = objRow[convcc_WorkEduClsRela.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkEduClsRelaEN.UpdDate = objRow[convcc_WorkEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEduClsRelaEN.UpdUserId = objRow[convcc_WorkEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEduClsRelaEN.Memo = objRow[convcc_WorkEduClsRela.Memo] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.Memo].ToString().Trim(); //备注
objvcc_WorkEduClsRelaEN.StuNum = objRow[convcc_WorkEduClsRela.StuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.StuNum].ToString().Trim()); //学生数
objvcc_WorkEduClsRelaEN.EduClsStuNum = objRow[convcc_WorkEduClsRela.EduClsStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.EduClsStuNum].ToString().Trim()); //教学班学生数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkEduClsRelaEN);
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
List<clsvcc_WorkEduClsRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_WorkEduClsRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkEduClsRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_WorkEduClsRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_WorkEduClsRelaEN> arrObjLst = new List<clsvcc_WorkEduClsRelaEN>(); 
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
	clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = new clsvcc_WorkEduClsRelaEN();
try
{
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela = Int32.Parse(objRow[convcc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkEduClsRelaEN.QuestionId = objRow[convcc_WorkEduClsRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkEduClsRelaEN.QuestionIndex = objRow[convcc_WorkEduClsRela.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkEduClsRelaEN.QuestionName = objRow[convcc_WorkEduClsRela.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkEduClsRelaEN.QuestionContent = objRow[convcc_WorkEduClsRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkEduClsRelaEN.CourseId = objRow[convcc_WorkEduClsRela.CourseId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEduClsRelaEN.CourseName = objRow[convcc_WorkEduClsRela.CourseName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEduClsRelaEN.CourseChapterId = objRow[convcc_WorkEduClsRela.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEduClsRelaEN.CourseChapterName = objRow[convcc_WorkEduClsRela.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEduClsRelaEN.ChapterName = objRow[convcc_WorkEduClsRela.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterName].ToString().Trim(); //章名
objvcc_WorkEduClsRelaEN.SectionName = objRow[convcc_WorkEduClsRela.SectionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionName].ToString().Trim(); //节名
objvcc_WorkEduClsRelaEN.ChapterNameSim = objRow[convcc_WorkEduClsRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEduClsRelaEN.SectionNameSim = objRow[convcc_WorkEduClsRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEduClsRelaEN.ParentNodeId = objRow[convcc_WorkEduClsRela.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkEduClsRelaEN.CourseChapterReferred = objRow[convcc_WorkEduClsRela.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEduClsRelaEN.ParentNodeName = objRow[convcc_WorkEduClsRela.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEduClsRelaEN.ParentNodeReferred = objRow[convcc_WorkEduClsRela.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEduClsRelaEN.QuestionTypeId = objRow[convcc_WorkEduClsRela.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkEduClsRelaEN.QuestionTypeName = objRow[convcc_WorkEduClsRela.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkEduClsRelaEN.ExamGradeId = objRow[convcc_WorkEduClsRela.ExamGradeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_WorkEduClsRelaEN.ExamGradeName = objRow[convcc_WorkEduClsRela.ExamGradeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_WorkEduClsRelaEN.AnswerTypeId = objRow[convcc_WorkEduClsRela.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkEduClsRelaEN.AnswerModeId = objRow[convcc_WorkEduClsRela.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkEduClsRelaEN.DefaultValue = objRow[convcc_WorkEduClsRela.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkEduClsRelaEN.TextDirectId = objRow[convcc_WorkEduClsRela.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkEduClsRelaEN.RelaEvent = objRow[convcc_WorkEduClsRela.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkEduClsRelaEN.CheckBoxLimitCount = objRow[convcc_WorkEduClsRela.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkEduClsRelaEN.AnswerAttLimitSize = objRow[convcc_WorkEduClsRela.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEduClsRelaEN.LimitedResourceType = objRow[convcc_WorkEduClsRela.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEduClsRelaEN.QuestionTypeId4Course = objRow[convcc_WorkEduClsRela.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkEduClsRelaEN.QuestionTypeName4Course = objRow[convcc_WorkEduClsRela.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkEduClsRelaEN.IdCurrEduCls = objRow[convcc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkEduClsRelaEN.CurrEduClsId = objRow[convcc_WorkEduClsRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkEduClsRelaEN.EduClsName = objRow[convcc_WorkEduClsRela.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkEduClsRelaEN.Scores = objRow[convcc_WorkEduClsRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkEduClsRela.Scores].ToString().Trim()); //分值
objvcc_WorkEduClsRelaEN.TeacherId = objRow[convcc_WorkEduClsRela.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkEduClsRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkEduClsRelaEN.PubDate = objRow[convcc_WorkEduClsRela.PubDate].ToString().Trim(); //发布日期
objvcc_WorkEduClsRelaEN.publisher = objRow[convcc_WorkEduClsRela.publisher] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.publisher].ToString().Trim(); //发布者Id
objvcc_WorkEduClsRelaEN.SpecifyCompletionDate = objRow[convcc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkEduClsRelaEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkEduClsRelaEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkEduClsRelaEN.CourseStudentGroupId = objRow[convcc_WorkEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkEduClsRelaEN.WorkTypeId = objRow[convcc_WorkEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkEduClsRelaEN.WorkTypeName = objRow[convcc_WorkEduClsRela.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkEduClsRelaEN.UpdDate = objRow[convcc_WorkEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEduClsRelaEN.UpdUserId = objRow[convcc_WorkEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEduClsRelaEN.Memo = objRow[convcc_WorkEduClsRela.Memo] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.Memo].ToString().Trim(); //备注
objvcc_WorkEduClsRelaEN.StuNum = objRow[convcc_WorkEduClsRela.StuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.StuNum].ToString().Trim()); //学生数
objvcc_WorkEduClsRelaEN.EduClsStuNum = objRow[convcc_WorkEduClsRela.EduClsStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.EduClsStuNum].ToString().Trim()); //教学班学生数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkEduClsRelaEN);
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
public static List<clsvcc_WorkEduClsRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_WorkEduClsRelaEN> arrObjLst = new List<clsvcc_WorkEduClsRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = new clsvcc_WorkEduClsRelaEN();
try
{
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela = Int32.Parse(objRow[convcc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkEduClsRelaEN.QuestionId = objRow[convcc_WorkEduClsRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkEduClsRelaEN.QuestionIndex = objRow[convcc_WorkEduClsRela.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkEduClsRelaEN.QuestionName = objRow[convcc_WorkEduClsRela.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkEduClsRelaEN.QuestionContent = objRow[convcc_WorkEduClsRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkEduClsRelaEN.CourseId = objRow[convcc_WorkEduClsRela.CourseId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEduClsRelaEN.CourseName = objRow[convcc_WorkEduClsRela.CourseName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEduClsRelaEN.CourseChapterId = objRow[convcc_WorkEduClsRela.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEduClsRelaEN.CourseChapterName = objRow[convcc_WorkEduClsRela.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEduClsRelaEN.ChapterName = objRow[convcc_WorkEduClsRela.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterName].ToString().Trim(); //章名
objvcc_WorkEduClsRelaEN.SectionName = objRow[convcc_WorkEduClsRela.SectionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionName].ToString().Trim(); //节名
objvcc_WorkEduClsRelaEN.ChapterNameSim = objRow[convcc_WorkEduClsRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEduClsRelaEN.SectionNameSim = objRow[convcc_WorkEduClsRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEduClsRelaEN.ParentNodeId = objRow[convcc_WorkEduClsRela.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkEduClsRelaEN.CourseChapterReferred = objRow[convcc_WorkEduClsRela.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEduClsRelaEN.ParentNodeName = objRow[convcc_WorkEduClsRela.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEduClsRelaEN.ParentNodeReferred = objRow[convcc_WorkEduClsRela.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEduClsRelaEN.QuestionTypeId = objRow[convcc_WorkEduClsRela.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkEduClsRelaEN.QuestionTypeName = objRow[convcc_WorkEduClsRela.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkEduClsRelaEN.ExamGradeId = objRow[convcc_WorkEduClsRela.ExamGradeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_WorkEduClsRelaEN.ExamGradeName = objRow[convcc_WorkEduClsRela.ExamGradeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_WorkEduClsRelaEN.AnswerTypeId = objRow[convcc_WorkEduClsRela.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkEduClsRelaEN.AnswerModeId = objRow[convcc_WorkEduClsRela.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkEduClsRelaEN.DefaultValue = objRow[convcc_WorkEduClsRela.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkEduClsRelaEN.TextDirectId = objRow[convcc_WorkEduClsRela.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkEduClsRelaEN.RelaEvent = objRow[convcc_WorkEduClsRela.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkEduClsRelaEN.CheckBoxLimitCount = objRow[convcc_WorkEduClsRela.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkEduClsRelaEN.AnswerAttLimitSize = objRow[convcc_WorkEduClsRela.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEduClsRelaEN.LimitedResourceType = objRow[convcc_WorkEduClsRela.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEduClsRelaEN.QuestionTypeId4Course = objRow[convcc_WorkEduClsRela.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkEduClsRelaEN.QuestionTypeName4Course = objRow[convcc_WorkEduClsRela.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkEduClsRelaEN.IdCurrEduCls = objRow[convcc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkEduClsRelaEN.CurrEduClsId = objRow[convcc_WorkEduClsRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkEduClsRelaEN.EduClsName = objRow[convcc_WorkEduClsRela.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkEduClsRelaEN.Scores = objRow[convcc_WorkEduClsRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkEduClsRela.Scores].ToString().Trim()); //分值
objvcc_WorkEduClsRelaEN.TeacherId = objRow[convcc_WorkEduClsRela.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkEduClsRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkEduClsRelaEN.PubDate = objRow[convcc_WorkEduClsRela.PubDate].ToString().Trim(); //发布日期
objvcc_WorkEduClsRelaEN.publisher = objRow[convcc_WorkEduClsRela.publisher] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.publisher].ToString().Trim(); //发布者Id
objvcc_WorkEduClsRelaEN.SpecifyCompletionDate = objRow[convcc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkEduClsRelaEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkEduClsRelaEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkEduClsRelaEN.CourseStudentGroupId = objRow[convcc_WorkEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkEduClsRelaEN.WorkTypeId = objRow[convcc_WorkEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkEduClsRelaEN.WorkTypeName = objRow[convcc_WorkEduClsRela.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkEduClsRelaEN.UpdDate = objRow[convcc_WorkEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEduClsRelaEN.UpdUserId = objRow[convcc_WorkEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEduClsRelaEN.Memo = objRow[convcc_WorkEduClsRela.Memo] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.Memo].ToString().Trim(); //备注
objvcc_WorkEduClsRelaEN.StuNum = objRow[convcc_WorkEduClsRela.StuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.StuNum].ToString().Trim()); //学生数
objvcc_WorkEduClsRelaEN.EduClsStuNum = objRow[convcc_WorkEduClsRela.EduClsStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.EduClsStuNum].ToString().Trim()); //教学班学生数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkEduClsRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_WorkEduClsRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_WorkEduClsRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_WorkEduClsRelaEN> arrObjLst = new List<clsvcc_WorkEduClsRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = new clsvcc_WorkEduClsRelaEN();
try
{
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela = Int32.Parse(objRow[convcc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkEduClsRelaEN.QuestionId = objRow[convcc_WorkEduClsRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkEduClsRelaEN.QuestionIndex = objRow[convcc_WorkEduClsRela.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkEduClsRelaEN.QuestionName = objRow[convcc_WorkEduClsRela.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkEduClsRelaEN.QuestionContent = objRow[convcc_WorkEduClsRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkEduClsRelaEN.CourseId = objRow[convcc_WorkEduClsRela.CourseId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEduClsRelaEN.CourseName = objRow[convcc_WorkEduClsRela.CourseName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEduClsRelaEN.CourseChapterId = objRow[convcc_WorkEduClsRela.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEduClsRelaEN.CourseChapterName = objRow[convcc_WorkEduClsRela.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEduClsRelaEN.ChapterName = objRow[convcc_WorkEduClsRela.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterName].ToString().Trim(); //章名
objvcc_WorkEduClsRelaEN.SectionName = objRow[convcc_WorkEduClsRela.SectionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionName].ToString().Trim(); //节名
objvcc_WorkEduClsRelaEN.ChapterNameSim = objRow[convcc_WorkEduClsRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEduClsRelaEN.SectionNameSim = objRow[convcc_WorkEduClsRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEduClsRelaEN.ParentNodeId = objRow[convcc_WorkEduClsRela.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkEduClsRelaEN.CourseChapterReferred = objRow[convcc_WorkEduClsRela.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEduClsRelaEN.ParentNodeName = objRow[convcc_WorkEduClsRela.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEduClsRelaEN.ParentNodeReferred = objRow[convcc_WorkEduClsRela.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEduClsRelaEN.QuestionTypeId = objRow[convcc_WorkEduClsRela.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkEduClsRelaEN.QuestionTypeName = objRow[convcc_WorkEduClsRela.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkEduClsRelaEN.ExamGradeId = objRow[convcc_WorkEduClsRela.ExamGradeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_WorkEduClsRelaEN.ExamGradeName = objRow[convcc_WorkEduClsRela.ExamGradeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_WorkEduClsRelaEN.AnswerTypeId = objRow[convcc_WorkEduClsRela.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkEduClsRelaEN.AnswerModeId = objRow[convcc_WorkEduClsRela.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkEduClsRelaEN.DefaultValue = objRow[convcc_WorkEduClsRela.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkEduClsRelaEN.TextDirectId = objRow[convcc_WorkEduClsRela.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkEduClsRelaEN.RelaEvent = objRow[convcc_WorkEduClsRela.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkEduClsRelaEN.CheckBoxLimitCount = objRow[convcc_WorkEduClsRela.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkEduClsRelaEN.AnswerAttLimitSize = objRow[convcc_WorkEduClsRela.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEduClsRelaEN.LimitedResourceType = objRow[convcc_WorkEduClsRela.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEduClsRelaEN.QuestionTypeId4Course = objRow[convcc_WorkEduClsRela.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkEduClsRelaEN.QuestionTypeName4Course = objRow[convcc_WorkEduClsRela.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkEduClsRelaEN.IdCurrEduCls = objRow[convcc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkEduClsRelaEN.CurrEduClsId = objRow[convcc_WorkEduClsRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkEduClsRelaEN.EduClsName = objRow[convcc_WorkEduClsRela.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkEduClsRelaEN.Scores = objRow[convcc_WorkEduClsRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkEduClsRela.Scores].ToString().Trim()); //分值
objvcc_WorkEduClsRelaEN.TeacherId = objRow[convcc_WorkEduClsRela.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkEduClsRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkEduClsRelaEN.PubDate = objRow[convcc_WorkEduClsRela.PubDate].ToString().Trim(); //发布日期
objvcc_WorkEduClsRelaEN.publisher = objRow[convcc_WorkEduClsRela.publisher] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.publisher].ToString().Trim(); //发布者Id
objvcc_WorkEduClsRelaEN.SpecifyCompletionDate = objRow[convcc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkEduClsRelaEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkEduClsRelaEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkEduClsRelaEN.CourseStudentGroupId = objRow[convcc_WorkEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkEduClsRelaEN.WorkTypeId = objRow[convcc_WorkEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkEduClsRelaEN.WorkTypeName = objRow[convcc_WorkEduClsRela.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkEduClsRelaEN.UpdDate = objRow[convcc_WorkEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEduClsRelaEN.UpdUserId = objRow[convcc_WorkEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEduClsRelaEN.Memo = objRow[convcc_WorkEduClsRela.Memo] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.Memo].ToString().Trim(); //备注
objvcc_WorkEduClsRelaEN.StuNum = objRow[convcc_WorkEduClsRela.StuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.StuNum].ToString().Trim()); //学生数
objvcc_WorkEduClsRelaEN.EduClsStuNum = objRow[convcc_WorkEduClsRela.EduClsStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.EduClsStuNum].ToString().Trim()); //教学班学生数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkEduClsRelaEN);
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
public static List<clsvcc_WorkEduClsRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_WorkEduClsRelaEN> arrObjLst = new List<clsvcc_WorkEduClsRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = new clsvcc_WorkEduClsRelaEN();
try
{
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela = Int32.Parse(objRow[convcc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkEduClsRelaEN.QuestionId = objRow[convcc_WorkEduClsRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkEduClsRelaEN.QuestionIndex = objRow[convcc_WorkEduClsRela.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkEduClsRelaEN.QuestionName = objRow[convcc_WorkEduClsRela.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkEduClsRelaEN.QuestionContent = objRow[convcc_WorkEduClsRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkEduClsRelaEN.CourseId = objRow[convcc_WorkEduClsRela.CourseId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEduClsRelaEN.CourseName = objRow[convcc_WorkEduClsRela.CourseName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEduClsRelaEN.CourseChapterId = objRow[convcc_WorkEduClsRela.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEduClsRelaEN.CourseChapterName = objRow[convcc_WorkEduClsRela.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEduClsRelaEN.ChapterName = objRow[convcc_WorkEduClsRela.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterName].ToString().Trim(); //章名
objvcc_WorkEduClsRelaEN.SectionName = objRow[convcc_WorkEduClsRela.SectionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionName].ToString().Trim(); //节名
objvcc_WorkEduClsRelaEN.ChapterNameSim = objRow[convcc_WorkEduClsRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEduClsRelaEN.SectionNameSim = objRow[convcc_WorkEduClsRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEduClsRelaEN.ParentNodeId = objRow[convcc_WorkEduClsRela.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkEduClsRelaEN.CourseChapterReferred = objRow[convcc_WorkEduClsRela.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEduClsRelaEN.ParentNodeName = objRow[convcc_WorkEduClsRela.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEduClsRelaEN.ParentNodeReferred = objRow[convcc_WorkEduClsRela.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEduClsRelaEN.QuestionTypeId = objRow[convcc_WorkEduClsRela.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkEduClsRelaEN.QuestionTypeName = objRow[convcc_WorkEduClsRela.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkEduClsRelaEN.ExamGradeId = objRow[convcc_WorkEduClsRela.ExamGradeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_WorkEduClsRelaEN.ExamGradeName = objRow[convcc_WorkEduClsRela.ExamGradeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_WorkEduClsRelaEN.AnswerTypeId = objRow[convcc_WorkEduClsRela.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkEduClsRelaEN.AnswerModeId = objRow[convcc_WorkEduClsRela.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkEduClsRelaEN.DefaultValue = objRow[convcc_WorkEduClsRela.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkEduClsRelaEN.TextDirectId = objRow[convcc_WorkEduClsRela.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkEduClsRelaEN.RelaEvent = objRow[convcc_WorkEduClsRela.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkEduClsRelaEN.CheckBoxLimitCount = objRow[convcc_WorkEduClsRela.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkEduClsRelaEN.AnswerAttLimitSize = objRow[convcc_WorkEduClsRela.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEduClsRelaEN.LimitedResourceType = objRow[convcc_WorkEduClsRela.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEduClsRelaEN.QuestionTypeId4Course = objRow[convcc_WorkEduClsRela.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkEduClsRelaEN.QuestionTypeName4Course = objRow[convcc_WorkEduClsRela.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkEduClsRelaEN.IdCurrEduCls = objRow[convcc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkEduClsRelaEN.CurrEduClsId = objRow[convcc_WorkEduClsRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkEduClsRelaEN.EduClsName = objRow[convcc_WorkEduClsRela.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkEduClsRelaEN.Scores = objRow[convcc_WorkEduClsRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkEduClsRela.Scores].ToString().Trim()); //分值
objvcc_WorkEduClsRelaEN.TeacherId = objRow[convcc_WorkEduClsRela.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkEduClsRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkEduClsRelaEN.PubDate = objRow[convcc_WorkEduClsRela.PubDate].ToString().Trim(); //发布日期
objvcc_WorkEduClsRelaEN.publisher = objRow[convcc_WorkEduClsRela.publisher] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.publisher].ToString().Trim(); //发布者Id
objvcc_WorkEduClsRelaEN.SpecifyCompletionDate = objRow[convcc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkEduClsRelaEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkEduClsRelaEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkEduClsRelaEN.CourseStudentGroupId = objRow[convcc_WorkEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkEduClsRelaEN.WorkTypeId = objRow[convcc_WorkEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkEduClsRelaEN.WorkTypeName = objRow[convcc_WorkEduClsRela.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkEduClsRelaEN.UpdDate = objRow[convcc_WorkEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEduClsRelaEN.UpdUserId = objRow[convcc_WorkEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEduClsRelaEN.Memo = objRow[convcc_WorkEduClsRela.Memo] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.Memo].ToString().Trim(); //备注
objvcc_WorkEduClsRelaEN.StuNum = objRow[convcc_WorkEduClsRela.StuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.StuNum].ToString().Trim()); //学生数
objvcc_WorkEduClsRelaEN.EduClsStuNum = objRow[convcc_WorkEduClsRela.EduClsStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.EduClsStuNum].ToString().Trim()); //教学班学生数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkEduClsRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkEduClsRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_WorkEduClsRelaEN> arrObjLst = new List<clsvcc_WorkEduClsRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = new clsvcc_WorkEduClsRelaEN();
try
{
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela = Int32.Parse(objRow[convcc_WorkEduClsRela.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkEduClsRelaEN.QuestionId = objRow[convcc_WorkEduClsRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkEduClsRelaEN.QuestionIndex = objRow[convcc_WorkEduClsRela.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkEduClsRelaEN.QuestionName = objRow[convcc_WorkEduClsRela.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkEduClsRelaEN.QuestionContent = objRow[convcc_WorkEduClsRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkEduClsRelaEN.CourseId = objRow[convcc_WorkEduClsRela.CourseId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseId].ToString().Trim(); //课程Id
objvcc_WorkEduClsRelaEN.CourseName = objRow[convcc_WorkEduClsRela.CourseName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseName].ToString().Trim(); //课程名称
objvcc_WorkEduClsRelaEN.CourseChapterId = objRow[convcc_WorkEduClsRela.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkEduClsRelaEN.CourseChapterName = objRow[convcc_WorkEduClsRela.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkEduClsRelaEN.ChapterName = objRow[convcc_WorkEduClsRela.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterName].ToString().Trim(); //章名
objvcc_WorkEduClsRelaEN.SectionName = objRow[convcc_WorkEduClsRela.SectionName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionName].ToString().Trim(); //节名
objvcc_WorkEduClsRelaEN.ChapterNameSim = objRow[convcc_WorkEduClsRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkEduClsRelaEN.SectionNameSim = objRow[convcc_WorkEduClsRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkEduClsRelaEN.ParentNodeId = objRow[convcc_WorkEduClsRela.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkEduClsRelaEN.CourseChapterReferred = objRow[convcc_WorkEduClsRela.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkEduClsRelaEN.ParentNodeName = objRow[convcc_WorkEduClsRela.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkEduClsRelaEN.ParentNodeReferred = objRow[convcc_WorkEduClsRela.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkEduClsRelaEN.QuestionTypeId = objRow[convcc_WorkEduClsRela.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkEduClsRelaEN.QuestionTypeName = objRow[convcc_WorkEduClsRela.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkEduClsRelaEN.ExamGradeId = objRow[convcc_WorkEduClsRela.ExamGradeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_WorkEduClsRelaEN.ExamGradeName = objRow[convcc_WorkEduClsRela.ExamGradeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_WorkEduClsRelaEN.AnswerTypeId = objRow[convcc_WorkEduClsRela.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkEduClsRelaEN.AnswerModeId = objRow[convcc_WorkEduClsRela.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkEduClsRelaEN.DefaultValue = objRow[convcc_WorkEduClsRela.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkEduClsRelaEN.TextDirectId = objRow[convcc_WorkEduClsRela.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkEduClsRelaEN.RelaEvent = objRow[convcc_WorkEduClsRela.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkEduClsRelaEN.CheckBoxLimitCount = objRow[convcc_WorkEduClsRela.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkEduClsRelaEN.AnswerAttLimitSize = objRow[convcc_WorkEduClsRela.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkEduClsRelaEN.LimitedResourceType = objRow[convcc_WorkEduClsRela.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkEduClsRelaEN.QuestionTypeId4Course = objRow[convcc_WorkEduClsRela.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkEduClsRelaEN.QuestionTypeName4Course = objRow[convcc_WorkEduClsRela.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkEduClsRelaEN.IdCurrEduCls = objRow[convcc_WorkEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkEduClsRelaEN.CurrEduClsId = objRow[convcc_WorkEduClsRela.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkEduClsRelaEN.EduClsName = objRow[convcc_WorkEduClsRela.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkEduClsRelaEN.Scores = objRow[convcc_WorkEduClsRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkEduClsRela.Scores].ToString().Trim()); //分值
objvcc_WorkEduClsRelaEN.TeacherId = objRow[convcc_WorkEduClsRela.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkEduClsRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkEduClsRelaEN.PubDate = objRow[convcc_WorkEduClsRela.PubDate].ToString().Trim(); //发布日期
objvcc_WorkEduClsRelaEN.publisher = objRow[convcc_WorkEduClsRela.publisher] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.publisher].ToString().Trim(); //发布者Id
objvcc_WorkEduClsRelaEN.SpecifyCompletionDate = objRow[convcc_WorkEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkEduClsRelaEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkEduClsRelaEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkEduClsRelaEN.CourseStudentGroupId = objRow[convcc_WorkEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkEduClsRelaEN.WorkTypeId = objRow[convcc_WorkEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkEduClsRelaEN.WorkTypeName = objRow[convcc_WorkEduClsRela.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkEduClsRelaEN.UpdDate = objRow[convcc_WorkEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkEduClsRelaEN.UpdUserId = objRow[convcc_WorkEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkEduClsRelaEN.Memo = objRow[convcc_WorkEduClsRela.Memo] == DBNull.Value ? null : objRow[convcc_WorkEduClsRela.Memo].ToString().Trim(); //备注
objvcc_WorkEduClsRelaEN.StuNum = objRow[convcc_WorkEduClsRela.StuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.StuNum].ToString().Trim()); //学生数
objvcc_WorkEduClsRelaEN.EduClsStuNum = objRow[convcc_WorkEduClsRela.EduClsStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkEduClsRela.EduClsStuNum].ToString().Trim()); //教学班学生数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkEduClsRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_WorkEduClsRela(ref clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN)
{
bool bolResult = vcc_WorkEduClsRelaDA.Getvcc_WorkEduClsRela(ref objvcc_WorkEduClsRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdWorkEduClsRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkEduClsRelaEN GetObjByIdWorkEduClsRela(long lngIdWorkEduClsRela)
{
clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = vcc_WorkEduClsRelaDA.GetObjByIdWorkEduClsRela(lngIdWorkEduClsRela);
return objvcc_WorkEduClsRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_WorkEduClsRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = vcc_WorkEduClsRelaDA.GetFirstObj(strWhereCond);
 return objvcc_WorkEduClsRelaEN;
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
public static clsvcc_WorkEduClsRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = vcc_WorkEduClsRelaDA.GetObjByDataRow(objRow);
 return objvcc_WorkEduClsRelaEN;
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
public static clsvcc_WorkEduClsRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = vcc_WorkEduClsRelaDA.GetObjByDataRow(objRow);
 return objvcc_WorkEduClsRelaEN;
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
 /// <param name = "lngIdWorkEduClsRela">所给的关键字</param>
 /// <param name = "lstvcc_WorkEduClsRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkEduClsRelaEN GetObjByIdWorkEduClsRelaFromList(long lngIdWorkEduClsRela, List<clsvcc_WorkEduClsRelaEN> lstvcc_WorkEduClsRelaObjLst)
{
foreach (clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN in lstvcc_WorkEduClsRelaObjLst)
{
if (objvcc_WorkEduClsRelaEN.IdWorkEduClsRela == lngIdWorkEduClsRela)
{
return objvcc_WorkEduClsRelaEN;
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
 long lngIdWorkEduClsRela;
 try
 {
 lngIdWorkEduClsRela = new clsvcc_WorkEduClsRelaDA().GetFirstID(strWhereCond);
 return lngIdWorkEduClsRela;
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
 arrList = vcc_WorkEduClsRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_WorkEduClsRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdWorkEduClsRela">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdWorkEduClsRela)
{
//检测记录是否存在
bool bolIsExist = vcc_WorkEduClsRelaDA.IsExist(lngIdWorkEduClsRela);
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
 bolIsExist = clsvcc_WorkEduClsRelaDA.IsExistTable();
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
 bolIsExist = vcc_WorkEduClsRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_WorkEduClsRelaENS">源对象</param>
 /// <param name = "objvcc_WorkEduClsRelaENT">目标对象</param>
 public static void CopyTo(clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaENS, clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaENT)
{
try
{
objvcc_WorkEduClsRelaENT.IdWorkEduClsRela = objvcc_WorkEduClsRelaENS.IdWorkEduClsRela; //作业教学班关系流水号
objvcc_WorkEduClsRelaENT.QuestionId = objvcc_WorkEduClsRelaENS.QuestionId; //题目Id
objvcc_WorkEduClsRelaENT.QuestionIndex = objvcc_WorkEduClsRelaENS.QuestionIndex; //题目序号
objvcc_WorkEduClsRelaENT.QuestionName = objvcc_WorkEduClsRelaENS.QuestionName; //题目名称
objvcc_WorkEduClsRelaENT.QuestionContent = objvcc_WorkEduClsRelaENS.QuestionContent; //题目内容
objvcc_WorkEduClsRelaENT.CourseId = objvcc_WorkEduClsRelaENS.CourseId; //课程Id
objvcc_WorkEduClsRelaENT.CourseName = objvcc_WorkEduClsRelaENS.CourseName; //课程名称
objvcc_WorkEduClsRelaENT.CourseChapterId = objvcc_WorkEduClsRelaENS.CourseChapterId; //课程章节ID
objvcc_WorkEduClsRelaENT.CourseChapterName = objvcc_WorkEduClsRelaENS.CourseChapterName; //课程章节名称
objvcc_WorkEduClsRelaENT.ChapterName = objvcc_WorkEduClsRelaENS.ChapterName; //章名
objvcc_WorkEduClsRelaENT.SectionName = objvcc_WorkEduClsRelaENS.SectionName; //节名
objvcc_WorkEduClsRelaENT.ChapterNameSim = objvcc_WorkEduClsRelaENS.ChapterNameSim; //章名简称
objvcc_WorkEduClsRelaENT.SectionNameSim = objvcc_WorkEduClsRelaENS.SectionNameSim; //节名简称
objvcc_WorkEduClsRelaENT.ParentNodeId = objvcc_WorkEduClsRelaENS.ParentNodeId; //父节点编号
objvcc_WorkEduClsRelaENT.CourseChapterReferred = objvcc_WorkEduClsRelaENS.CourseChapterReferred; //节简称
objvcc_WorkEduClsRelaENT.ParentNodeName = objvcc_WorkEduClsRelaENS.ParentNodeName; //父节点名称
objvcc_WorkEduClsRelaENT.ParentNodeReferred = objvcc_WorkEduClsRelaENS.ParentNodeReferred; //章简称
objvcc_WorkEduClsRelaENT.QuestionTypeId = objvcc_WorkEduClsRelaENS.QuestionTypeId; //题目类型Id
objvcc_WorkEduClsRelaENT.QuestionTypeName = objvcc_WorkEduClsRelaENS.QuestionTypeName; //题目类型名
objvcc_WorkEduClsRelaENT.ExamGradeId = objvcc_WorkEduClsRelaENS.ExamGradeId; //题库等级ID
objvcc_WorkEduClsRelaENT.ExamGradeName = objvcc_WorkEduClsRelaENS.ExamGradeName; //题库等级名
objvcc_WorkEduClsRelaENT.AnswerTypeId = objvcc_WorkEduClsRelaENS.AnswerTypeId; //答案类型ID
objvcc_WorkEduClsRelaENT.AnswerModeId = objvcc_WorkEduClsRelaENS.AnswerModeId; //答案模式Id
objvcc_WorkEduClsRelaENT.DefaultValue = objvcc_WorkEduClsRelaENS.DefaultValue; //缺省值
objvcc_WorkEduClsRelaENT.TextDirectId = objvcc_WorkEduClsRelaENS.TextDirectId; //文本方向ID
objvcc_WorkEduClsRelaENT.RelaEvent = objvcc_WorkEduClsRelaENS.RelaEvent; //相关事件
objvcc_WorkEduClsRelaENT.CheckBoxLimitCount = objvcc_WorkEduClsRelaENS.CheckBoxLimitCount; //复选框限制数
objvcc_WorkEduClsRelaENT.AnswerAttLimitSize = objvcc_WorkEduClsRelaENS.AnswerAttLimitSize; //回答附件限制大小
objvcc_WorkEduClsRelaENT.LimitedResourceType = objvcc_WorkEduClsRelaENS.LimitedResourceType; //限制资源类型
objvcc_WorkEduClsRelaENT.QuestionTypeId4Course = objvcc_WorkEduClsRelaENS.QuestionTypeId4Course; //题目类型Id4课程
objvcc_WorkEduClsRelaENT.QuestionTypeName4Course = objvcc_WorkEduClsRelaENS.QuestionTypeName4Course; //题目类型名4课程
objvcc_WorkEduClsRelaENT.IdCurrEduCls = objvcc_WorkEduClsRelaENS.IdCurrEduCls; //教学班流水号
objvcc_WorkEduClsRelaENT.CurrEduClsId = objvcc_WorkEduClsRelaENS.CurrEduClsId; //教学班Id
objvcc_WorkEduClsRelaENT.EduClsName = objvcc_WorkEduClsRelaENS.EduClsName; //教学班名
objvcc_WorkEduClsRelaENT.Scores = objvcc_WorkEduClsRelaENS.Scores; //分值
objvcc_WorkEduClsRelaENT.TeacherId = objvcc_WorkEduClsRelaENS.TeacherId; //教师工号
objvcc_WorkEduClsRelaENT.IsPublish = objvcc_WorkEduClsRelaENS.IsPublish; //是否发布
objvcc_WorkEduClsRelaENT.PubDate = objvcc_WorkEduClsRelaENS.PubDate; //发布日期
objvcc_WorkEduClsRelaENT.publisher = objvcc_WorkEduClsRelaENS.publisher; //发布者Id
objvcc_WorkEduClsRelaENT.SpecifyCompletionDate = objvcc_WorkEduClsRelaENS.SpecifyCompletionDate; //指定完成日期
objvcc_WorkEduClsRelaENT.IsCurrEduCls = objvcc_WorkEduClsRelaENS.IsCurrEduCls; //是否为教学班作业
objvcc_WorkEduClsRelaENT.IsGroupWork = objvcc_WorkEduClsRelaENS.IsGroupWork; //是否为小组作业
objvcc_WorkEduClsRelaENT.CourseStudentGroupId = objvcc_WorkEduClsRelaENS.CourseStudentGroupId; //学生分组表流水号
objvcc_WorkEduClsRelaENT.WorkTypeId = objvcc_WorkEduClsRelaENS.WorkTypeId; //作业类型Id
objvcc_WorkEduClsRelaENT.WorkTypeName = objvcc_WorkEduClsRelaENS.WorkTypeName; //作业类型名称
objvcc_WorkEduClsRelaENT.UpdDate = objvcc_WorkEduClsRelaENS.UpdDate; //修改日期
objvcc_WorkEduClsRelaENT.UpdUserId = objvcc_WorkEduClsRelaENS.UpdUserId; //修改用户Id
objvcc_WorkEduClsRelaENT.Memo = objvcc_WorkEduClsRelaENS.Memo; //备注
objvcc_WorkEduClsRelaENT.StuNum = objvcc_WorkEduClsRelaENS.StuNum; //学生数
objvcc_WorkEduClsRelaENT.EduClsStuNum = objvcc_WorkEduClsRelaENS.EduClsStuNum; //教学班学生数
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
 /// <param name = "objvcc_WorkEduClsRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN)
{
try
{
objvcc_WorkEduClsRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_WorkEduClsRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_WorkEduClsRela.IdWorkEduClsRela, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.IdWorkEduClsRela = objvcc_WorkEduClsRelaEN.IdWorkEduClsRela; //作业教学班关系流水号
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.QuestionId = objvcc_WorkEduClsRelaEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.QuestionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.QuestionIndex = objvcc_WorkEduClsRelaEN.QuestionIndex; //题目序号
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.QuestionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.QuestionName = objvcc_WorkEduClsRelaEN.QuestionName == "[null]" ? null :  objvcc_WorkEduClsRelaEN.QuestionName; //题目名称
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.QuestionContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.QuestionContent = objvcc_WorkEduClsRelaEN.QuestionContent == "[null]" ? null :  objvcc_WorkEduClsRelaEN.QuestionContent; //题目内容
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.CourseId = objvcc_WorkEduClsRelaEN.CourseId == "[null]" ? null :  objvcc_WorkEduClsRelaEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.CourseName = objvcc_WorkEduClsRelaEN.CourseName == "[null]" ? null :  objvcc_WorkEduClsRelaEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.CourseChapterId = objvcc_WorkEduClsRelaEN.CourseChapterId == "[null]" ? null :  objvcc_WorkEduClsRelaEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.CourseChapterName = objvcc_WorkEduClsRelaEN.CourseChapterName == "[null]" ? null :  objvcc_WorkEduClsRelaEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.ChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.ChapterName = objvcc_WorkEduClsRelaEN.ChapterName == "[null]" ? null :  objvcc_WorkEduClsRelaEN.ChapterName; //章名
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.SectionName = objvcc_WorkEduClsRelaEN.SectionName == "[null]" ? null :  objvcc_WorkEduClsRelaEN.SectionName; //节名
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.ChapterNameSim = objvcc_WorkEduClsRelaEN.ChapterNameSim == "[null]" ? null :  objvcc_WorkEduClsRelaEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.SectionNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.SectionNameSim = objvcc_WorkEduClsRelaEN.SectionNameSim == "[null]" ? null :  objvcc_WorkEduClsRelaEN.SectionNameSim; //节名简称
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.ParentNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.ParentNodeId = objvcc_WorkEduClsRelaEN.ParentNodeId == "[null]" ? null :  objvcc_WorkEduClsRelaEN.ParentNodeId; //父节点编号
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.CourseChapterReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.CourseChapterReferred = objvcc_WorkEduClsRelaEN.CourseChapterReferred == "[null]" ? null :  objvcc_WorkEduClsRelaEN.CourseChapterReferred; //节简称
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.ParentNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.ParentNodeName = objvcc_WorkEduClsRelaEN.ParentNodeName == "[null]" ? null :  objvcc_WorkEduClsRelaEN.ParentNodeName; //父节点名称
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.ParentNodeReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.ParentNodeReferred = objvcc_WorkEduClsRelaEN.ParentNodeReferred == "[null]" ? null :  objvcc_WorkEduClsRelaEN.ParentNodeReferred; //章简称
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.QuestionTypeId = objvcc_WorkEduClsRelaEN.QuestionTypeId == "[null]" ? null :  objvcc_WorkEduClsRelaEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.QuestionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.QuestionTypeName = objvcc_WorkEduClsRelaEN.QuestionTypeName == "[null]" ? null :  objvcc_WorkEduClsRelaEN.QuestionTypeName; //题目类型名
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.ExamGradeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.ExamGradeId = objvcc_WorkEduClsRelaEN.ExamGradeId == "[null]" ? null :  objvcc_WorkEduClsRelaEN.ExamGradeId; //题库等级ID
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.ExamGradeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.ExamGradeName = objvcc_WorkEduClsRelaEN.ExamGradeName == "[null]" ? null :  objvcc_WorkEduClsRelaEN.ExamGradeName; //题库等级名
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.AnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.AnswerTypeId = objvcc_WorkEduClsRelaEN.AnswerTypeId == "[null]" ? null :  objvcc_WorkEduClsRelaEN.AnswerTypeId; //答案类型ID
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.AnswerModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.AnswerModeId = objvcc_WorkEduClsRelaEN.AnswerModeId == "[null]" ? null :  objvcc_WorkEduClsRelaEN.AnswerModeId; //答案模式Id
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.DefaultValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.DefaultValue = objvcc_WorkEduClsRelaEN.DefaultValue == "[null]" ? null :  objvcc_WorkEduClsRelaEN.DefaultValue; //缺省值
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.TextDirectId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.TextDirectId = objvcc_WorkEduClsRelaEN.TextDirectId == "[null]" ? null :  objvcc_WorkEduClsRelaEN.TextDirectId; //文本方向ID
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.RelaEvent, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.RelaEvent = objvcc_WorkEduClsRelaEN.RelaEvent == "[null]" ? null :  objvcc_WorkEduClsRelaEN.RelaEvent; //相关事件
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.CheckBoxLimitCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.CheckBoxLimitCount = objvcc_WorkEduClsRelaEN.CheckBoxLimitCount; //复选框限制数
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.AnswerAttLimitSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.AnswerAttLimitSize = objvcc_WorkEduClsRelaEN.AnswerAttLimitSize; //回答附件限制大小
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.LimitedResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.LimitedResourceType = objvcc_WorkEduClsRelaEN.LimitedResourceType == "[null]" ? null :  objvcc_WorkEduClsRelaEN.LimitedResourceType; //限制资源类型
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.QuestionTypeId4Course, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.QuestionTypeId4Course = objvcc_WorkEduClsRelaEN.QuestionTypeId4Course == "[null]" ? null :  objvcc_WorkEduClsRelaEN.QuestionTypeId4Course; //题目类型Id4课程
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.QuestionTypeName4Course, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.QuestionTypeName4Course = objvcc_WorkEduClsRelaEN.QuestionTypeName4Course == "[null]" ? null :  objvcc_WorkEduClsRelaEN.QuestionTypeName4Course; //题目类型名4课程
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.IdCurrEduCls = objvcc_WorkEduClsRelaEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.CurrEduClsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.CurrEduClsId = objvcc_WorkEduClsRelaEN.CurrEduClsId == "[null]" ? null :  objvcc_WorkEduClsRelaEN.CurrEduClsId; //教学班Id
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.EduClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.EduClsName = objvcc_WorkEduClsRelaEN.EduClsName == "[null]" ? null :  objvcc_WorkEduClsRelaEN.EduClsName; //教学班名
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.Scores, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.Scores = objvcc_WorkEduClsRelaEN.Scores; //分值
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.TeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.TeacherId = objvcc_WorkEduClsRelaEN.TeacherId; //教师工号
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.IsPublish, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.IsPublish = objvcc_WorkEduClsRelaEN.IsPublish; //是否发布
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.PubDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.PubDate = objvcc_WorkEduClsRelaEN.PubDate; //发布日期
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.publisher, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.publisher = objvcc_WorkEduClsRelaEN.publisher == "[null]" ? null :  objvcc_WorkEduClsRelaEN.publisher; //发布者Id
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.SpecifyCompletionDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.SpecifyCompletionDate = objvcc_WorkEduClsRelaEN.SpecifyCompletionDate; //指定完成日期
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.IsCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.IsCurrEduCls = objvcc_WorkEduClsRelaEN.IsCurrEduCls; //是否为教学班作业
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.IsGroupWork, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.IsGroupWork = objvcc_WorkEduClsRelaEN.IsGroupWork; //是否为小组作业
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.CourseStudentGroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.CourseStudentGroupId = objvcc_WorkEduClsRelaEN.CourseStudentGroupId; //学生分组表流水号
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.WorkTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.WorkTypeId = objvcc_WorkEduClsRelaEN.WorkTypeId; //作业类型Id
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.WorkTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.WorkTypeName = objvcc_WorkEduClsRelaEN.WorkTypeName == "[null]" ? null :  objvcc_WorkEduClsRelaEN.WorkTypeName; //作业类型名称
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.UpdDate = objvcc_WorkEduClsRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.UpdUserId = objvcc_WorkEduClsRelaEN.UpdUserId == "[null]" ? null :  objvcc_WorkEduClsRelaEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.Memo = objvcc_WorkEduClsRelaEN.Memo == "[null]" ? null :  objvcc_WorkEduClsRelaEN.Memo; //备注
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.StuNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.StuNum = objvcc_WorkEduClsRelaEN.StuNum; //学生数
}
if (arrFldSet.Contains(convcc_WorkEduClsRela.EduClsStuNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkEduClsRelaEN.EduClsStuNum = objvcc_WorkEduClsRelaEN.EduClsStuNum; //教学班学生数
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
 /// <param name = "objvcc_WorkEduClsRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN)
{
try
{
if (objvcc_WorkEduClsRelaEN.QuestionName == "[null]") objvcc_WorkEduClsRelaEN.QuestionName = null; //题目名称
if (objvcc_WorkEduClsRelaEN.QuestionContent == "[null]") objvcc_WorkEduClsRelaEN.QuestionContent = null; //题目内容
if (objvcc_WorkEduClsRelaEN.CourseId == "[null]") objvcc_WorkEduClsRelaEN.CourseId = null; //课程Id
if (objvcc_WorkEduClsRelaEN.CourseName == "[null]") objvcc_WorkEduClsRelaEN.CourseName = null; //课程名称
if (objvcc_WorkEduClsRelaEN.CourseChapterId == "[null]") objvcc_WorkEduClsRelaEN.CourseChapterId = null; //课程章节ID
if (objvcc_WorkEduClsRelaEN.CourseChapterName == "[null]") objvcc_WorkEduClsRelaEN.CourseChapterName = null; //课程章节名称
if (objvcc_WorkEduClsRelaEN.ChapterName == "[null]") objvcc_WorkEduClsRelaEN.ChapterName = null; //章名
if (objvcc_WorkEduClsRelaEN.SectionName == "[null]") objvcc_WorkEduClsRelaEN.SectionName = null; //节名
if (objvcc_WorkEduClsRelaEN.ChapterNameSim == "[null]") objvcc_WorkEduClsRelaEN.ChapterNameSim = null; //章名简称
if (objvcc_WorkEduClsRelaEN.SectionNameSim == "[null]") objvcc_WorkEduClsRelaEN.SectionNameSim = null; //节名简称
if (objvcc_WorkEduClsRelaEN.ParentNodeId == "[null]") objvcc_WorkEduClsRelaEN.ParentNodeId = null; //父节点编号
if (objvcc_WorkEduClsRelaEN.CourseChapterReferred == "[null]") objvcc_WorkEduClsRelaEN.CourseChapterReferred = null; //节简称
if (objvcc_WorkEduClsRelaEN.ParentNodeName == "[null]") objvcc_WorkEduClsRelaEN.ParentNodeName = null; //父节点名称
if (objvcc_WorkEduClsRelaEN.ParentNodeReferred == "[null]") objvcc_WorkEduClsRelaEN.ParentNodeReferred = null; //章简称
if (objvcc_WorkEduClsRelaEN.QuestionTypeId == "[null]") objvcc_WorkEduClsRelaEN.QuestionTypeId = null; //题目类型Id
if (objvcc_WorkEduClsRelaEN.QuestionTypeName == "[null]") objvcc_WorkEduClsRelaEN.QuestionTypeName = null; //题目类型名
if (objvcc_WorkEduClsRelaEN.ExamGradeId == "[null]") objvcc_WorkEduClsRelaEN.ExamGradeId = null; //题库等级ID
if (objvcc_WorkEduClsRelaEN.ExamGradeName == "[null]") objvcc_WorkEduClsRelaEN.ExamGradeName = null; //题库等级名
if (objvcc_WorkEduClsRelaEN.AnswerTypeId == "[null]") objvcc_WorkEduClsRelaEN.AnswerTypeId = null; //答案类型ID
if (objvcc_WorkEduClsRelaEN.AnswerModeId == "[null]") objvcc_WorkEduClsRelaEN.AnswerModeId = null; //答案模式Id
if (objvcc_WorkEduClsRelaEN.DefaultValue == "[null]") objvcc_WorkEduClsRelaEN.DefaultValue = null; //缺省值
if (objvcc_WorkEduClsRelaEN.TextDirectId == "[null]") objvcc_WorkEduClsRelaEN.TextDirectId = null; //文本方向ID
if (objvcc_WorkEduClsRelaEN.RelaEvent == "[null]") objvcc_WorkEduClsRelaEN.RelaEvent = null; //相关事件
if (objvcc_WorkEduClsRelaEN.LimitedResourceType == "[null]") objvcc_WorkEduClsRelaEN.LimitedResourceType = null; //限制资源类型
if (objvcc_WorkEduClsRelaEN.QuestionTypeId4Course == "[null]") objvcc_WorkEduClsRelaEN.QuestionTypeId4Course = null; //题目类型Id4课程
if (objvcc_WorkEduClsRelaEN.QuestionTypeName4Course == "[null]") objvcc_WorkEduClsRelaEN.QuestionTypeName4Course = null; //题目类型名4课程
if (objvcc_WorkEduClsRelaEN.CurrEduClsId == "[null]") objvcc_WorkEduClsRelaEN.CurrEduClsId = null; //教学班Id
if (objvcc_WorkEduClsRelaEN.EduClsName == "[null]") objvcc_WorkEduClsRelaEN.EduClsName = null; //教学班名
if (objvcc_WorkEduClsRelaEN.publisher == "[null]") objvcc_WorkEduClsRelaEN.publisher = null; //发布者Id
if (objvcc_WorkEduClsRelaEN.WorkTypeName == "[null]") objvcc_WorkEduClsRelaEN.WorkTypeName = null; //作业类型名称
if (objvcc_WorkEduClsRelaEN.UpdUserId == "[null]") objvcc_WorkEduClsRelaEN.UpdUserId = null; //修改用户Id
if (objvcc_WorkEduClsRelaEN.Memo == "[null]") objvcc_WorkEduClsRelaEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN)
{
 vcc_WorkEduClsRelaDA.CheckProperty4Condition(objvcc_WorkEduClsRelaEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


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
if (clsCurrEduClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsBL没有刷新缓存机制(clsCurrEduClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_WorkEduClsRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkEduClsRelaBL没有刷新缓存机制(clscc_WorkEduClsRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsWorkTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsWorkTypeBL没有刷新缓存机制(clsWorkTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
//string strWhereCond = string.Format("1 = 1 order by IdWorkEduClsRela");
//if (arrvcc_WorkEduClsRelaObjLstCache == null)
//{
//arrvcc_WorkEduClsRelaObjLstCache = vcc_WorkEduClsRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdWorkEduClsRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkEduClsRelaEN GetObjByIdWorkEduClsRelaCache(long lngIdWorkEduClsRela)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvcc_WorkEduClsRelaEN._CurrTabName);
List<clsvcc_WorkEduClsRelaEN> arrvcc_WorkEduClsRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_WorkEduClsRelaEN> arrvcc_WorkEduClsRelaObjLst_Sel =
arrvcc_WorkEduClsRelaObjLstCache
.Where(x=> x.IdWorkEduClsRela == lngIdWorkEduClsRela 
);
if (arrvcc_WorkEduClsRelaObjLst_Sel.Count() == 0)
{
   clsvcc_WorkEduClsRelaEN obj = clsvcc_WorkEduClsRelaBL.GetObjByIdWorkEduClsRela(lngIdWorkEduClsRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvcc_WorkEduClsRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_WorkEduClsRelaEN> GetAllvcc_WorkEduClsRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvcc_WorkEduClsRelaEN> arrvcc_WorkEduClsRelaObjLstCache = GetObjLstCache(); 
return arrvcc_WorkEduClsRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_WorkEduClsRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvcc_WorkEduClsRelaEN._CurrTabName);
List<clsvcc_WorkEduClsRelaEN> arrvcc_WorkEduClsRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_WorkEduClsRelaObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvcc_WorkEduClsRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvcc_WorkEduClsRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvcc_WorkEduClsRelaEN._RefreshTimeLst.Count == 0) return "";
return clsvcc_WorkEduClsRelaEN._RefreshTimeLst[clsvcc_WorkEduClsRelaEN._RefreshTimeLst.Count - 1];
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngIdWorkEduClsRela)
{
if (strInFldName != convcc_WorkEduClsRela.IdWorkEduClsRela)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_WorkEduClsRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_WorkEduClsRela.AttributeName));
throw new Exception(strMsg);
}
var objvcc_WorkEduClsRela = clsvcc_WorkEduClsRelaBL.GetObjByIdWorkEduClsRelaCache(lngIdWorkEduClsRela);
if (objvcc_WorkEduClsRela == null) return "";
return objvcc_WorkEduClsRela[strOutFldName].ToString();
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
int intRecCount = clsvcc_WorkEduClsRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_WorkEduClsRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_WorkEduClsRelaDA.GetRecCount();
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
int intRecCount = clsvcc_WorkEduClsRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaCond)
{
List<clsvcc_WorkEduClsRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_WorkEduClsRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_WorkEduClsRela.AttributeName)
{
if (objvcc_WorkEduClsRelaCond.IsUpdated(strFldName) == false) continue;
if (objvcc_WorkEduClsRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkEduClsRelaCond[strFldName].ToString());
}
else
{
if (objvcc_WorkEduClsRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_WorkEduClsRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkEduClsRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_WorkEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_WorkEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_WorkEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_WorkEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_WorkEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_WorkEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_WorkEduClsRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_WorkEduClsRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_WorkEduClsRelaCond[strFldName]));
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
 List<string> arrList = clsvcc_WorkEduClsRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_WorkEduClsRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_WorkEduClsRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}