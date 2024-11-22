
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseChapter4KnowledgeBL
 表名:vcc_CourseChapter4Knowledge(01120158)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:03:40
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
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
public static class  clsvcc_CourseChapter4KnowledgeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseChapterId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseChapter4KnowledgeEN GetObj(this K_CourseChapterId_vcc_CourseChapter4Knowledge myKey)
{
clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = clsvcc_CourseChapter4KnowledgeBL.vcc_CourseChapter4KnowledgeDA.GetObjByCourseChapterId(myKey.Value);
return objvcc_CourseChapter4KnowledgeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetCourseChapterId(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_CourseChapter4Knowledge.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_CourseChapter4Knowledge.CourseChapterId);
}
objvcc_CourseChapter4KnowledgeEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.CourseChapterId) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.CourseChapterId, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.CourseChapterId] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetCourseChapterName(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterName, convcc_CourseChapter4Knowledge.CourseChapterName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_CourseChapter4Knowledge.CourseChapterName);
}
objvcc_CourseChapter4KnowledgeEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.CourseChapterName) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.CourseChapterName, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.CourseChapterName] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetChapterId(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterId, 8, convcc_CourseChapter4Knowledge.ChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convcc_CourseChapter4Knowledge.ChapterId);
}
objvcc_CourseChapter4KnowledgeEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.ChapterId) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.ChapterId, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ChapterId] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetSectionId(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, convcc_CourseChapter4Knowledge.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convcc_CourseChapter4Knowledge.SectionId);
}
objvcc_CourseChapter4KnowledgeEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.SectionId) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.SectionId, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.SectionId] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetChapterName(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_CourseChapter4Knowledge.ChapterName);
}
objvcc_CourseChapter4KnowledgeEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.ChapterName) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.ChapterName, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ChapterName] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetSectionName(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_CourseChapter4Knowledge.SectionName);
}
objvcc_CourseChapter4KnowledgeEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.SectionName) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.SectionName, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.SectionName] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetChapterNameSim(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, convcc_CourseChapter4Knowledge.ChapterNameSim);
}
objvcc_CourseChapter4KnowledgeEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.ChapterNameSim) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.ChapterNameSim, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ChapterNameSim] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetSectionNameSim(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strSectionNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionNameSim, 10, convcc_CourseChapter4Knowledge.SectionNameSim);
}
objvcc_CourseChapter4KnowledgeEN.SectionNameSim = strSectionNameSim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.SectionNameSim) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.SectionNameSim, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.SectionNameSim] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetChapterContent(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strChapterContent, string strComparisonOp="")
	{
objvcc_CourseChapter4KnowledgeEN.ChapterContent = strChapterContent; //章节内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.ChapterContent) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.ChapterContent, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ChapterContent] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetCourseId(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convcc_CourseChapter4Knowledge.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_CourseChapter4Knowledge.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_CourseChapter4Knowledge.CourseId);
}
objvcc_CourseChapter4KnowledgeEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.CourseId) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.CourseId, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.CourseId] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetCourseCode(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convcc_CourseChapter4Knowledge.CourseCode);
}
objvcc_CourseChapter4KnowledgeEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.CourseCode) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.CourseCode, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.CourseCode] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetCourseName(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_CourseChapter4Knowledge.CourseName);
}
objvcc_CourseChapter4KnowledgeEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.CourseName) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.CourseName, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.CourseName] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetThemeId(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strThemeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strThemeId, 4, convcc_CourseChapter4Knowledge.ThemeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strThemeId, 4, convcc_CourseChapter4Knowledge.ThemeId);
}
objvcc_CourseChapter4KnowledgeEN.ThemeId = strThemeId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.ThemeId) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.ThemeId, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ThemeId] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetParentNodeId(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strParentNodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParentNodeId, convcc_CourseChapter4Knowledge.ParentNodeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeId, 8, convcc_CourseChapter4Knowledge.ParentNodeId);
}
objvcc_CourseChapter4KnowledgeEN.ParentNodeId = strParentNodeId; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.ParentNodeId) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.ParentNodeId, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ParentNodeId] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetIsOpenToAllStu(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, bool bolIsOpenToAllStu, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsOpenToAllStu, convcc_CourseChapter4Knowledge.IsOpenToAllStu);
objvcc_CourseChapter4KnowledgeEN.IsOpenToAllStu = bolIsOpenToAllStu; //全校师生
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.IsOpenToAllStu) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.IsOpenToAllStu, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.IsOpenToAllStu] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetIsOpenToSchool(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, bool bolIsOpenToSchool, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsOpenToSchool, convcc_CourseChapter4Knowledge.IsOpenToSchool);
objvcc_CourseChapter4KnowledgeEN.IsOpenToSchool = bolIsOpenToSchool; //全校师生公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.IsOpenToSchool) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.IsOpenToSchool, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.IsOpenToSchool] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetIsOpenToSocial(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, bool bolIsOpenToSocial, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsOpenToSocial, convcc_CourseChapter4Knowledge.IsOpenToSocial);
objvcc_CourseChapter4KnowledgeEN.IsOpenToSocial = bolIsOpenToSocial; //社会公众
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.IsOpenToSocial) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.IsOpenToSocial, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.IsOpenToSocial] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetIsMustMenu(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, bool bolIsMustMenu, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsMustMenu, convcc_CourseChapter4Knowledge.IsMustMenu);
objvcc_CourseChapter4KnowledgeEN.IsMustMenu = bolIsMustMenu; //是否必建栏目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.IsMustMenu) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.IsMustMenu, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.IsMustMenu] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetThemeName(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strThemeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strThemeName, 200, convcc_CourseChapter4Knowledge.ThemeName);
}
objvcc_CourseChapter4KnowledgeEN.ThemeName = strThemeName; //主题名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.ThemeName) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.ThemeName, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ThemeName] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetIsFile(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, bool bolIsFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsFile, convcc_CourseChapter4Knowledge.IsFile);
objvcc_CourseChapter4KnowledgeEN.IsFile = bolIsFile; //项目或文件夹
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.IsFile) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.IsFile, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.IsFile] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetIsUse(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, bool bolIsUse, string strComparisonOp="")
	{
objvcc_CourseChapter4KnowledgeEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.IsUse) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.IsUse, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.IsUse] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetViewCount(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, int? intViewCount, string strComparisonOp="")
	{
objvcc_CourseChapter4KnowledgeEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.ViewCount) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.ViewCount, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ViewCount] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetCourseChapterReferred(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strCourseChapterReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convcc_CourseChapter4Knowledge.CourseChapterReferred);
}
objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.CourseChapterReferred) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.CourseChapterReferred, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.CourseChapterReferred] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetOrderNum(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, int? intOrderNum, string strComparisonOp="")
	{
objvcc_CourseChapter4KnowledgeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.OrderNum) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.OrderNum, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.OrderNum] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetCreateDate(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convcc_CourseChapter4Knowledge.CreateDate);
}
objvcc_CourseChapter4KnowledgeEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.CreateDate) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.CreateDate, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.CreateDate] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetEditPeople(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strEditPeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEditPeople, 50, convcc_CourseChapter4Knowledge.EditPeople);
}
objvcc_CourseChapter4KnowledgeEN.EditPeople = strEditPeople; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.EditPeople) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.EditPeople, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.EditPeople] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetUpdDate(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_CourseChapter4Knowledge.UpdDate);
}
objvcc_CourseChapter4KnowledgeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.UpdDate) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.UpdDate, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.UpdDate] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetMemo(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_CourseChapter4Knowledge.Memo);
}
objvcc_CourseChapter4KnowledgeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.Memo) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.Memo, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.Memo] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetParentNodeName(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strParentNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeName, 100, convcc_CourseChapter4Knowledge.ParentNodeName);
}
objvcc_CourseChapter4KnowledgeEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.ParentNodeName) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.ParentNodeName, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ParentNodeName] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetParentNodeReferred(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strParentNodeReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convcc_CourseChapter4Knowledge.ParentNodeReferred);
}
objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.ParentNodeReferred) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.ParentNodeReferred, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ParentNodeReferred] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetKnowledgeNum(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, int? intKnowledgeNum, string strComparisonOp="")
	{
objvcc_CourseChapter4KnowledgeEN.KnowledgeNum = intKnowledgeNum; //知识点数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.KnowledgeNum) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.KnowledgeNum, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.KnowledgeNum] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeENS">源对象</param>
 /// <param name = "objvcc_CourseChapter4KnowledgeENT">目标对象</param>
 public static void CopyTo(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeENS, clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeENT)
{
try
{
objvcc_CourseChapter4KnowledgeENT.CourseChapterId = objvcc_CourseChapter4KnowledgeENS.CourseChapterId; //课程章节ID
objvcc_CourseChapter4KnowledgeENT.CourseChapterName = objvcc_CourseChapter4KnowledgeENS.CourseChapterName; //课程章节名称
objvcc_CourseChapter4KnowledgeENT.ChapterId = objvcc_CourseChapter4KnowledgeENS.ChapterId; //章Id
objvcc_CourseChapter4KnowledgeENT.SectionId = objvcc_CourseChapter4KnowledgeENS.SectionId; //节Id
objvcc_CourseChapter4KnowledgeENT.ChapterName = objvcc_CourseChapter4KnowledgeENS.ChapterName; //章名
objvcc_CourseChapter4KnowledgeENT.SectionName = objvcc_CourseChapter4KnowledgeENS.SectionName; //节名
objvcc_CourseChapter4KnowledgeENT.ChapterNameSim = objvcc_CourseChapter4KnowledgeENS.ChapterNameSim; //章名简称
objvcc_CourseChapter4KnowledgeENT.SectionNameSim = objvcc_CourseChapter4KnowledgeENS.SectionNameSim; //节名简称
objvcc_CourseChapter4KnowledgeENT.ChapterContent = objvcc_CourseChapter4KnowledgeENS.ChapterContent; //章节内容
objvcc_CourseChapter4KnowledgeENT.CourseId = objvcc_CourseChapter4KnowledgeENS.CourseId; //课程Id
objvcc_CourseChapter4KnowledgeENT.CourseCode = objvcc_CourseChapter4KnowledgeENS.CourseCode; //课程代码
objvcc_CourseChapter4KnowledgeENT.CourseName = objvcc_CourseChapter4KnowledgeENS.CourseName; //课程名称
objvcc_CourseChapter4KnowledgeENT.ThemeId = objvcc_CourseChapter4KnowledgeENS.ThemeId; //主题Id
objvcc_CourseChapter4KnowledgeENT.ParentNodeId = objvcc_CourseChapter4KnowledgeENS.ParentNodeId; //父节点编号
objvcc_CourseChapter4KnowledgeENT.IsOpenToAllStu = objvcc_CourseChapter4KnowledgeENS.IsOpenToAllStu; //全校师生
objvcc_CourseChapter4KnowledgeENT.IsOpenToSchool = objvcc_CourseChapter4KnowledgeENS.IsOpenToSchool; //全校师生公开
objvcc_CourseChapter4KnowledgeENT.IsOpenToSocial = objvcc_CourseChapter4KnowledgeENS.IsOpenToSocial; //社会公众
objvcc_CourseChapter4KnowledgeENT.IsMustMenu = objvcc_CourseChapter4KnowledgeENS.IsMustMenu; //是否必建栏目
objvcc_CourseChapter4KnowledgeENT.ThemeName = objvcc_CourseChapter4KnowledgeENS.ThemeName; //主题名
objvcc_CourseChapter4KnowledgeENT.IsFile = objvcc_CourseChapter4KnowledgeENS.IsFile; //项目或文件夹
objvcc_CourseChapter4KnowledgeENT.IsUse = objvcc_CourseChapter4KnowledgeENS.IsUse; //是否使用
objvcc_CourseChapter4KnowledgeENT.ViewCount = objvcc_CourseChapter4KnowledgeENS.ViewCount; //浏览量
objvcc_CourseChapter4KnowledgeENT.CourseChapterReferred = objvcc_CourseChapter4KnowledgeENS.CourseChapterReferred; //节简称
objvcc_CourseChapter4KnowledgeENT.OrderNum = objvcc_CourseChapter4KnowledgeENS.OrderNum; //序号
objvcc_CourseChapter4KnowledgeENT.CreateDate = objvcc_CourseChapter4KnowledgeENS.CreateDate; //建立日期
objvcc_CourseChapter4KnowledgeENT.EditPeople = objvcc_CourseChapter4KnowledgeENS.EditPeople; //修改人
objvcc_CourseChapter4KnowledgeENT.UpdDate = objvcc_CourseChapter4KnowledgeENS.UpdDate; //修改日期
objvcc_CourseChapter4KnowledgeENT.Memo = objvcc_CourseChapter4KnowledgeENS.Memo; //备注
objvcc_CourseChapter4KnowledgeENT.ParentNodeName = objvcc_CourseChapter4KnowledgeENS.ParentNodeName; //父节点名称
objvcc_CourseChapter4KnowledgeENT.ParentNodeReferred = objvcc_CourseChapter4KnowledgeENS.ParentNodeReferred; //章简称
objvcc_CourseChapter4KnowledgeENT.KnowledgeNum = objvcc_CourseChapter4KnowledgeENS.KnowledgeNum; //知识点数
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
 /// <param name = "objvcc_CourseChapter4KnowledgeENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseChapter4KnowledgeEN:objvcc_CourseChapter4KnowledgeENT</returns>
 public static clsvcc_CourseChapter4KnowledgeEN CopyTo(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeENS)
{
try
{
 clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeENT = new clsvcc_CourseChapter4KnowledgeEN()
{
CourseChapterId = objvcc_CourseChapter4KnowledgeENS.CourseChapterId, //课程章节ID
CourseChapterName = objvcc_CourseChapter4KnowledgeENS.CourseChapterName, //课程章节名称
ChapterId = objvcc_CourseChapter4KnowledgeENS.ChapterId, //章Id
SectionId = objvcc_CourseChapter4KnowledgeENS.SectionId, //节Id
ChapterName = objvcc_CourseChapter4KnowledgeENS.ChapterName, //章名
SectionName = objvcc_CourseChapter4KnowledgeENS.SectionName, //节名
ChapterNameSim = objvcc_CourseChapter4KnowledgeENS.ChapterNameSim, //章名简称
SectionNameSim = objvcc_CourseChapter4KnowledgeENS.SectionNameSim, //节名简称
ChapterContent = objvcc_CourseChapter4KnowledgeENS.ChapterContent, //章节内容
CourseId = objvcc_CourseChapter4KnowledgeENS.CourseId, //课程Id
CourseCode = objvcc_CourseChapter4KnowledgeENS.CourseCode, //课程代码
CourseName = objvcc_CourseChapter4KnowledgeENS.CourseName, //课程名称
ThemeId = objvcc_CourseChapter4KnowledgeENS.ThemeId, //主题Id
ParentNodeId = objvcc_CourseChapter4KnowledgeENS.ParentNodeId, //父节点编号
IsOpenToAllStu = objvcc_CourseChapter4KnowledgeENS.IsOpenToAllStu, //全校师生
IsOpenToSchool = objvcc_CourseChapter4KnowledgeENS.IsOpenToSchool, //全校师生公开
IsOpenToSocial = objvcc_CourseChapter4KnowledgeENS.IsOpenToSocial, //社会公众
IsMustMenu = objvcc_CourseChapter4KnowledgeENS.IsMustMenu, //是否必建栏目
ThemeName = objvcc_CourseChapter4KnowledgeENS.ThemeName, //主题名
IsFile = objvcc_CourseChapter4KnowledgeENS.IsFile, //项目或文件夹
IsUse = objvcc_CourseChapter4KnowledgeENS.IsUse, //是否使用
ViewCount = objvcc_CourseChapter4KnowledgeENS.ViewCount, //浏览量
CourseChapterReferred = objvcc_CourseChapter4KnowledgeENS.CourseChapterReferred, //节简称
OrderNum = objvcc_CourseChapter4KnowledgeENS.OrderNum, //序号
CreateDate = objvcc_CourseChapter4KnowledgeENS.CreateDate, //建立日期
EditPeople = objvcc_CourseChapter4KnowledgeENS.EditPeople, //修改人
UpdDate = objvcc_CourseChapter4KnowledgeENS.UpdDate, //修改日期
Memo = objvcc_CourseChapter4KnowledgeENS.Memo, //备注
ParentNodeName = objvcc_CourseChapter4KnowledgeENS.ParentNodeName, //父节点名称
ParentNodeReferred = objvcc_CourseChapter4KnowledgeENS.ParentNodeReferred, //章简称
KnowledgeNum = objvcc_CourseChapter4KnowledgeENS.KnowledgeNum, //知识点数
};
 return objvcc_CourseChapter4KnowledgeENT;
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
public static void CheckProperty4Condition(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN)
{
 clsvcc_CourseChapter4KnowledgeBL.vcc_CourseChapter4KnowledgeDA.CheckProperty4Condition(objvcc_CourseChapter4KnowledgeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.CourseChapterId, objvcc_CourseChapter4KnowledgeCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.CourseChapterName, objvcc_CourseChapter4KnowledgeCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.ChapterId) == true)
{
string strComparisonOpChapterId = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.ChapterId, objvcc_CourseChapter4KnowledgeCond.ChapterId, strComparisonOpChapterId);
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.SectionId) == true)
{
string strComparisonOpSectionId = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.SectionId, objvcc_CourseChapter4KnowledgeCond.SectionId, strComparisonOpSectionId);
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.ChapterName) == true)
{
string strComparisonOpChapterName = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.ChapterName, objvcc_CourseChapter4KnowledgeCond.ChapterName, strComparisonOpChapterName);
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.SectionName) == true)
{
string strComparisonOpSectionName = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.SectionName, objvcc_CourseChapter4KnowledgeCond.SectionName, strComparisonOpSectionName);
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.ChapterNameSim, objvcc_CourseChapter4KnowledgeCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.SectionNameSim) == true)
{
string strComparisonOpSectionNameSim = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.SectionNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.SectionNameSim, objvcc_CourseChapter4KnowledgeCond.SectionNameSim, strComparisonOpSectionNameSim);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.CourseId, objvcc_CourseChapter4KnowledgeCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.CourseCode) == true)
{
string strComparisonOpCourseCode = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.CourseCode, objvcc_CourseChapter4KnowledgeCond.CourseCode, strComparisonOpCourseCode);
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.CourseName) == true)
{
string strComparisonOpCourseName = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.CourseName, objvcc_CourseChapter4KnowledgeCond.CourseName, strComparisonOpCourseName);
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.ThemeId) == true)
{
string strComparisonOpThemeId = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ThemeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.ThemeId, objvcc_CourseChapter4KnowledgeCond.ThemeId, strComparisonOpThemeId);
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.ParentNodeId) == true)
{
string strComparisonOpParentNodeId = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ParentNodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.ParentNodeId, objvcc_CourseChapter4KnowledgeCond.ParentNodeId, strComparisonOpParentNodeId);
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.IsOpenToAllStu) == true)
{
if (objvcc_CourseChapter4KnowledgeCond.IsOpenToAllStu == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4Knowledge.IsOpenToAllStu);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4Knowledge.IsOpenToAllStu);
}
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.IsOpenToSchool) == true)
{
if (objvcc_CourseChapter4KnowledgeCond.IsOpenToSchool == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4Knowledge.IsOpenToSchool);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4Knowledge.IsOpenToSchool);
}
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.IsOpenToSocial) == true)
{
if (objvcc_CourseChapter4KnowledgeCond.IsOpenToSocial == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4Knowledge.IsOpenToSocial);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4Knowledge.IsOpenToSocial);
}
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.IsMustMenu) == true)
{
if (objvcc_CourseChapter4KnowledgeCond.IsMustMenu == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4Knowledge.IsMustMenu);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4Knowledge.IsMustMenu);
}
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.ThemeName) == true)
{
string strComparisonOpThemeName = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ThemeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.ThemeName, objvcc_CourseChapter4KnowledgeCond.ThemeName, strComparisonOpThemeName);
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.IsFile) == true)
{
if (objvcc_CourseChapter4KnowledgeCond.IsFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4Knowledge.IsFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4Knowledge.IsFile);
}
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.IsUse) == true)
{
if (objvcc_CourseChapter4KnowledgeCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4Knowledge.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4Knowledge.IsUse);
}
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.ViewCount) == true)
{
string strComparisonOpViewCount = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseChapter4Knowledge.ViewCount, objvcc_CourseChapter4KnowledgeCond.ViewCount, strComparisonOpViewCount);
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.CourseChapterReferred) == true)
{
string strComparisonOpCourseChapterReferred = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.CourseChapterReferred, objvcc_CourseChapter4KnowledgeCond.CourseChapterReferred, strComparisonOpCourseChapterReferred);
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.OrderNum) == true)
{
string strComparisonOpOrderNum = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseChapter4Knowledge.OrderNum, objvcc_CourseChapter4KnowledgeCond.OrderNum, strComparisonOpOrderNum);
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.CreateDate) == true)
{
string strComparisonOpCreateDate = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.CreateDate, objvcc_CourseChapter4KnowledgeCond.CreateDate, strComparisonOpCreateDate);
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.EditPeople) == true)
{
string strComparisonOpEditPeople = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.EditPeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.EditPeople, objvcc_CourseChapter4KnowledgeCond.EditPeople, strComparisonOpEditPeople);
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.UpdDate, objvcc_CourseChapter4KnowledgeCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.Memo) == true)
{
string strComparisonOpMemo = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.Memo, objvcc_CourseChapter4KnowledgeCond.Memo, strComparisonOpMemo);
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.ParentNodeName) == true)
{
string strComparisonOpParentNodeName = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.ParentNodeName, objvcc_CourseChapter4KnowledgeCond.ParentNodeName, strComparisonOpParentNodeName);
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.ParentNodeReferred) == true)
{
string strComparisonOpParentNodeReferred = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.ParentNodeReferred, objvcc_CourseChapter4KnowledgeCond.ParentNodeReferred, strComparisonOpParentNodeReferred);
}
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(convcc_CourseChapter4Knowledge.KnowledgeNum) == true)
{
string strComparisonOpKnowledgeNum = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.KnowledgeNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseChapter4Knowledge.KnowledgeNum, objvcc_CourseChapter4KnowledgeCond.KnowledgeNum, strComparisonOpKnowledgeNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_CourseChapter4Knowledge
{
public virtual bool UpdRelaTabDate(string strCourseChapterId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v课程章节表4知识点(vcc_CourseChapter4Knowledge)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseChapter4KnowledgeBL
{
public static RelatedActions_vcc_CourseChapter4Knowledge relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_CourseChapter4KnowledgeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_CourseChapter4KnowledgeDA vcc_CourseChapter4KnowledgeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_CourseChapter4KnowledgeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_CourseChapter4KnowledgeBL()
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
if (string.IsNullOrEmpty(clsvcc_CourseChapter4KnowledgeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_CourseChapter4KnowledgeEN._ConnectString);
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
public static DataTable GetDataTable_vcc_CourseChapter4Knowledge(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_CourseChapter4KnowledgeDA.GetDataTable_vcc_CourseChapter4Knowledge(strWhereCond);
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
objDT = vcc_CourseChapter4KnowledgeDA.GetDataTable(strWhereCond);
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
objDT = vcc_CourseChapter4KnowledgeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_CourseChapter4KnowledgeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_CourseChapter4KnowledgeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_CourseChapter4KnowledgeDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_CourseChapter4KnowledgeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_CourseChapter4KnowledgeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_CourseChapter4KnowledgeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCourseChapterIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcc_CourseChapter4KnowledgeEN> GetObjLstByCourseChapterIdLst(List<string> arrCourseChapterIdLst)
{
List<clsvcc_CourseChapter4KnowledgeEN> arrObjLst = new List<clsvcc_CourseChapter4KnowledgeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCourseChapterIdLst, true);
 string strWhereCond = string.Format("CourseChapterId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = new clsvcc_CourseChapter4KnowledgeEN();
try
{
objvcc_CourseChapter4KnowledgeEN.CourseChapterId = objRow[convcc_CourseChapter4Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4KnowledgeEN.CourseChapterName = objRow[convcc_CourseChapter4Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4KnowledgeEN.ChapterId = objRow[convcc_CourseChapter4Knowledge.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4KnowledgeEN.SectionId = objRow[convcc_CourseChapter4Knowledge.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4KnowledgeEN.ChapterName = objRow[convcc_CourseChapter4Knowledge.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4KnowledgeEN.SectionName = objRow[convcc_CourseChapter4Knowledge.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4KnowledgeEN.ChapterNameSim = objRow[convcc_CourseChapter4Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4KnowledgeEN.SectionNameSim = objRow[convcc_CourseChapter4Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4KnowledgeEN.ChapterContent = objRow[convcc_CourseChapter4Knowledge.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4KnowledgeEN.CourseId = objRow[convcc_CourseChapter4Knowledge.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4KnowledgeEN.CourseCode = objRow[convcc_CourseChapter4Knowledge.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4KnowledgeEN.CourseName = objRow[convcc_CourseChapter4Knowledge.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4KnowledgeEN.ThemeId = objRow[convcc_CourseChapter4Knowledge.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4KnowledgeEN.ParentNodeId = objRow[convcc_CourseChapter4Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4KnowledgeEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4KnowledgeEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4KnowledgeEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4KnowledgeEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4KnowledgeEN.ThemeName = objRow[convcc_CourseChapter4Knowledge.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4KnowledgeEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4KnowledgeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4KnowledgeEN.ViewCount = objRow[convcc_CourseChapter4Knowledge.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred = objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4KnowledgeEN.OrderNum = objRow[convcc_CourseChapter4Knowledge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4KnowledgeEN.CreateDate = objRow[convcc_CourseChapter4Knowledge.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4KnowledgeEN.EditPeople = objRow[convcc_CourseChapter4Knowledge.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4KnowledgeEN.UpdDate = objRow[convcc_CourseChapter4Knowledge.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4KnowledgeEN.Memo = objRow[convcc_CourseChapter4Knowledge.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4KnowledgeEN.ParentNodeName = objRow[convcc_CourseChapter4Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred = objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4KnowledgeEN.KnowledgeNum = objRow[convcc_CourseChapter4Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapter4KnowledgeEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapter4KnowledgeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCourseChapterIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_CourseChapter4KnowledgeEN> GetObjLstByCourseChapterIdLstCache(List<string> arrCourseChapterIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapter4KnowledgeEN._CurrTabName, strCourseId);
List<clsvcc_CourseChapter4KnowledgeEN> arrvcc_CourseChapter4KnowledgeObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseChapter4KnowledgeEN> arrvcc_CourseChapter4KnowledgeObjLst_Sel =
arrvcc_CourseChapter4KnowledgeObjLstCache
.Where(x => arrCourseChapterIdLst.Contains(x.CourseChapterId));
return arrvcc_CourseChapter4KnowledgeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseChapter4KnowledgeEN> GetObjLst(string strWhereCond)
{
List<clsvcc_CourseChapter4KnowledgeEN> arrObjLst = new List<clsvcc_CourseChapter4KnowledgeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = new clsvcc_CourseChapter4KnowledgeEN();
try
{
objvcc_CourseChapter4KnowledgeEN.CourseChapterId = objRow[convcc_CourseChapter4Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4KnowledgeEN.CourseChapterName = objRow[convcc_CourseChapter4Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4KnowledgeEN.ChapterId = objRow[convcc_CourseChapter4Knowledge.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4KnowledgeEN.SectionId = objRow[convcc_CourseChapter4Knowledge.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4KnowledgeEN.ChapterName = objRow[convcc_CourseChapter4Knowledge.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4KnowledgeEN.SectionName = objRow[convcc_CourseChapter4Knowledge.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4KnowledgeEN.ChapterNameSim = objRow[convcc_CourseChapter4Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4KnowledgeEN.SectionNameSim = objRow[convcc_CourseChapter4Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4KnowledgeEN.ChapterContent = objRow[convcc_CourseChapter4Knowledge.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4KnowledgeEN.CourseId = objRow[convcc_CourseChapter4Knowledge.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4KnowledgeEN.CourseCode = objRow[convcc_CourseChapter4Knowledge.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4KnowledgeEN.CourseName = objRow[convcc_CourseChapter4Knowledge.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4KnowledgeEN.ThemeId = objRow[convcc_CourseChapter4Knowledge.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4KnowledgeEN.ParentNodeId = objRow[convcc_CourseChapter4Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4KnowledgeEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4KnowledgeEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4KnowledgeEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4KnowledgeEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4KnowledgeEN.ThemeName = objRow[convcc_CourseChapter4Knowledge.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4KnowledgeEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4KnowledgeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4KnowledgeEN.ViewCount = objRow[convcc_CourseChapter4Knowledge.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred = objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4KnowledgeEN.OrderNum = objRow[convcc_CourseChapter4Knowledge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4KnowledgeEN.CreateDate = objRow[convcc_CourseChapter4Knowledge.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4KnowledgeEN.EditPeople = objRow[convcc_CourseChapter4Knowledge.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4KnowledgeEN.UpdDate = objRow[convcc_CourseChapter4Knowledge.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4KnowledgeEN.Memo = objRow[convcc_CourseChapter4Knowledge.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4KnowledgeEN.ParentNodeName = objRow[convcc_CourseChapter4Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred = objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4KnowledgeEN.KnowledgeNum = objRow[convcc_CourseChapter4Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapter4KnowledgeEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapter4KnowledgeEN);
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
public static List<clsvcc_CourseChapter4KnowledgeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseChapter4KnowledgeEN> arrObjLst = new List<clsvcc_CourseChapter4KnowledgeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = new clsvcc_CourseChapter4KnowledgeEN();
try
{
objvcc_CourseChapter4KnowledgeEN.CourseChapterId = objRow[convcc_CourseChapter4Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4KnowledgeEN.CourseChapterName = objRow[convcc_CourseChapter4Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4KnowledgeEN.ChapterId = objRow[convcc_CourseChapter4Knowledge.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4KnowledgeEN.SectionId = objRow[convcc_CourseChapter4Knowledge.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4KnowledgeEN.ChapterName = objRow[convcc_CourseChapter4Knowledge.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4KnowledgeEN.SectionName = objRow[convcc_CourseChapter4Knowledge.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4KnowledgeEN.ChapterNameSim = objRow[convcc_CourseChapter4Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4KnowledgeEN.SectionNameSim = objRow[convcc_CourseChapter4Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4KnowledgeEN.ChapterContent = objRow[convcc_CourseChapter4Knowledge.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4KnowledgeEN.CourseId = objRow[convcc_CourseChapter4Knowledge.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4KnowledgeEN.CourseCode = objRow[convcc_CourseChapter4Knowledge.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4KnowledgeEN.CourseName = objRow[convcc_CourseChapter4Knowledge.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4KnowledgeEN.ThemeId = objRow[convcc_CourseChapter4Knowledge.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4KnowledgeEN.ParentNodeId = objRow[convcc_CourseChapter4Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4KnowledgeEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4KnowledgeEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4KnowledgeEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4KnowledgeEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4KnowledgeEN.ThemeName = objRow[convcc_CourseChapter4Knowledge.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4KnowledgeEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4KnowledgeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4KnowledgeEN.ViewCount = objRow[convcc_CourseChapter4Knowledge.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred = objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4KnowledgeEN.OrderNum = objRow[convcc_CourseChapter4Knowledge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4KnowledgeEN.CreateDate = objRow[convcc_CourseChapter4Knowledge.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4KnowledgeEN.EditPeople = objRow[convcc_CourseChapter4Knowledge.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4KnowledgeEN.UpdDate = objRow[convcc_CourseChapter4Knowledge.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4KnowledgeEN.Memo = objRow[convcc_CourseChapter4Knowledge.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4KnowledgeEN.ParentNodeName = objRow[convcc_CourseChapter4Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred = objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4KnowledgeEN.KnowledgeNum = objRow[convcc_CourseChapter4Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapter4KnowledgeEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapter4KnowledgeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_CourseChapter4KnowledgeEN> GetSubObjLstCache(clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeCond)
{
 string strCourseId = objvcc_CourseChapter4KnowledgeCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvcc_CourseChapter4KnowledgeBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvcc_CourseChapter4KnowledgeEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseChapter4KnowledgeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseChapter4Knowledge.AttributeName)
{
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseChapter4KnowledgeCond[strFldName].ToString());
}
else
{
if (objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseChapter4KnowledgeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseChapter4KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseChapter4KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseChapter4KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseChapter4KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseChapter4KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseChapter4KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseChapter4KnowledgeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseChapter4KnowledgeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseChapter4KnowledgeCond[strFldName]));
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
public static List<clsvcc_CourseChapter4KnowledgeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_CourseChapter4KnowledgeEN> arrObjLst = new List<clsvcc_CourseChapter4KnowledgeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = new clsvcc_CourseChapter4KnowledgeEN();
try
{
objvcc_CourseChapter4KnowledgeEN.CourseChapterId = objRow[convcc_CourseChapter4Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4KnowledgeEN.CourseChapterName = objRow[convcc_CourseChapter4Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4KnowledgeEN.ChapterId = objRow[convcc_CourseChapter4Knowledge.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4KnowledgeEN.SectionId = objRow[convcc_CourseChapter4Knowledge.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4KnowledgeEN.ChapterName = objRow[convcc_CourseChapter4Knowledge.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4KnowledgeEN.SectionName = objRow[convcc_CourseChapter4Knowledge.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4KnowledgeEN.ChapterNameSim = objRow[convcc_CourseChapter4Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4KnowledgeEN.SectionNameSim = objRow[convcc_CourseChapter4Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4KnowledgeEN.ChapterContent = objRow[convcc_CourseChapter4Knowledge.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4KnowledgeEN.CourseId = objRow[convcc_CourseChapter4Knowledge.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4KnowledgeEN.CourseCode = objRow[convcc_CourseChapter4Knowledge.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4KnowledgeEN.CourseName = objRow[convcc_CourseChapter4Knowledge.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4KnowledgeEN.ThemeId = objRow[convcc_CourseChapter4Knowledge.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4KnowledgeEN.ParentNodeId = objRow[convcc_CourseChapter4Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4KnowledgeEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4KnowledgeEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4KnowledgeEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4KnowledgeEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4KnowledgeEN.ThemeName = objRow[convcc_CourseChapter4Knowledge.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4KnowledgeEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4KnowledgeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4KnowledgeEN.ViewCount = objRow[convcc_CourseChapter4Knowledge.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred = objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4KnowledgeEN.OrderNum = objRow[convcc_CourseChapter4Knowledge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4KnowledgeEN.CreateDate = objRow[convcc_CourseChapter4Knowledge.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4KnowledgeEN.EditPeople = objRow[convcc_CourseChapter4Knowledge.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4KnowledgeEN.UpdDate = objRow[convcc_CourseChapter4Knowledge.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4KnowledgeEN.Memo = objRow[convcc_CourseChapter4Knowledge.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4KnowledgeEN.ParentNodeName = objRow[convcc_CourseChapter4Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred = objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4KnowledgeEN.KnowledgeNum = objRow[convcc_CourseChapter4Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapter4KnowledgeEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapter4KnowledgeEN);
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
public static List<clsvcc_CourseChapter4KnowledgeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_CourseChapter4KnowledgeEN> arrObjLst = new List<clsvcc_CourseChapter4KnowledgeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = new clsvcc_CourseChapter4KnowledgeEN();
try
{
objvcc_CourseChapter4KnowledgeEN.CourseChapterId = objRow[convcc_CourseChapter4Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4KnowledgeEN.CourseChapterName = objRow[convcc_CourseChapter4Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4KnowledgeEN.ChapterId = objRow[convcc_CourseChapter4Knowledge.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4KnowledgeEN.SectionId = objRow[convcc_CourseChapter4Knowledge.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4KnowledgeEN.ChapterName = objRow[convcc_CourseChapter4Knowledge.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4KnowledgeEN.SectionName = objRow[convcc_CourseChapter4Knowledge.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4KnowledgeEN.ChapterNameSim = objRow[convcc_CourseChapter4Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4KnowledgeEN.SectionNameSim = objRow[convcc_CourseChapter4Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4KnowledgeEN.ChapterContent = objRow[convcc_CourseChapter4Knowledge.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4KnowledgeEN.CourseId = objRow[convcc_CourseChapter4Knowledge.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4KnowledgeEN.CourseCode = objRow[convcc_CourseChapter4Knowledge.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4KnowledgeEN.CourseName = objRow[convcc_CourseChapter4Knowledge.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4KnowledgeEN.ThemeId = objRow[convcc_CourseChapter4Knowledge.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4KnowledgeEN.ParentNodeId = objRow[convcc_CourseChapter4Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4KnowledgeEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4KnowledgeEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4KnowledgeEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4KnowledgeEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4KnowledgeEN.ThemeName = objRow[convcc_CourseChapter4Knowledge.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4KnowledgeEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4KnowledgeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4KnowledgeEN.ViewCount = objRow[convcc_CourseChapter4Knowledge.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred = objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4KnowledgeEN.OrderNum = objRow[convcc_CourseChapter4Knowledge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4KnowledgeEN.CreateDate = objRow[convcc_CourseChapter4Knowledge.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4KnowledgeEN.EditPeople = objRow[convcc_CourseChapter4Knowledge.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4KnowledgeEN.UpdDate = objRow[convcc_CourseChapter4Knowledge.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4KnowledgeEN.Memo = objRow[convcc_CourseChapter4Knowledge.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4KnowledgeEN.ParentNodeName = objRow[convcc_CourseChapter4Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred = objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4KnowledgeEN.KnowledgeNum = objRow[convcc_CourseChapter4Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapter4KnowledgeEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapter4KnowledgeEN);
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
List<clsvcc_CourseChapter4KnowledgeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_CourseChapter4KnowledgeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseChapter4KnowledgeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_CourseChapter4KnowledgeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseChapter4KnowledgeEN> arrObjLst = new List<clsvcc_CourseChapter4KnowledgeEN>(); 
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
	clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = new clsvcc_CourseChapter4KnowledgeEN();
try
{
objvcc_CourseChapter4KnowledgeEN.CourseChapterId = objRow[convcc_CourseChapter4Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4KnowledgeEN.CourseChapterName = objRow[convcc_CourseChapter4Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4KnowledgeEN.ChapterId = objRow[convcc_CourseChapter4Knowledge.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4KnowledgeEN.SectionId = objRow[convcc_CourseChapter4Knowledge.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4KnowledgeEN.ChapterName = objRow[convcc_CourseChapter4Knowledge.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4KnowledgeEN.SectionName = objRow[convcc_CourseChapter4Knowledge.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4KnowledgeEN.ChapterNameSim = objRow[convcc_CourseChapter4Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4KnowledgeEN.SectionNameSim = objRow[convcc_CourseChapter4Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4KnowledgeEN.ChapterContent = objRow[convcc_CourseChapter4Knowledge.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4KnowledgeEN.CourseId = objRow[convcc_CourseChapter4Knowledge.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4KnowledgeEN.CourseCode = objRow[convcc_CourseChapter4Knowledge.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4KnowledgeEN.CourseName = objRow[convcc_CourseChapter4Knowledge.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4KnowledgeEN.ThemeId = objRow[convcc_CourseChapter4Knowledge.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4KnowledgeEN.ParentNodeId = objRow[convcc_CourseChapter4Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4KnowledgeEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4KnowledgeEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4KnowledgeEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4KnowledgeEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4KnowledgeEN.ThemeName = objRow[convcc_CourseChapter4Knowledge.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4KnowledgeEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4KnowledgeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4KnowledgeEN.ViewCount = objRow[convcc_CourseChapter4Knowledge.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred = objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4KnowledgeEN.OrderNum = objRow[convcc_CourseChapter4Knowledge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4KnowledgeEN.CreateDate = objRow[convcc_CourseChapter4Knowledge.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4KnowledgeEN.EditPeople = objRow[convcc_CourseChapter4Knowledge.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4KnowledgeEN.UpdDate = objRow[convcc_CourseChapter4Knowledge.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4KnowledgeEN.Memo = objRow[convcc_CourseChapter4Knowledge.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4KnowledgeEN.ParentNodeName = objRow[convcc_CourseChapter4Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred = objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4KnowledgeEN.KnowledgeNum = objRow[convcc_CourseChapter4Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapter4KnowledgeEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapter4KnowledgeEN);
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
public static List<clsvcc_CourseChapter4KnowledgeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseChapter4KnowledgeEN> arrObjLst = new List<clsvcc_CourseChapter4KnowledgeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = new clsvcc_CourseChapter4KnowledgeEN();
try
{
objvcc_CourseChapter4KnowledgeEN.CourseChapterId = objRow[convcc_CourseChapter4Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4KnowledgeEN.CourseChapterName = objRow[convcc_CourseChapter4Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4KnowledgeEN.ChapterId = objRow[convcc_CourseChapter4Knowledge.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4KnowledgeEN.SectionId = objRow[convcc_CourseChapter4Knowledge.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4KnowledgeEN.ChapterName = objRow[convcc_CourseChapter4Knowledge.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4KnowledgeEN.SectionName = objRow[convcc_CourseChapter4Knowledge.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4KnowledgeEN.ChapterNameSim = objRow[convcc_CourseChapter4Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4KnowledgeEN.SectionNameSim = objRow[convcc_CourseChapter4Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4KnowledgeEN.ChapterContent = objRow[convcc_CourseChapter4Knowledge.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4KnowledgeEN.CourseId = objRow[convcc_CourseChapter4Knowledge.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4KnowledgeEN.CourseCode = objRow[convcc_CourseChapter4Knowledge.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4KnowledgeEN.CourseName = objRow[convcc_CourseChapter4Knowledge.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4KnowledgeEN.ThemeId = objRow[convcc_CourseChapter4Knowledge.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4KnowledgeEN.ParentNodeId = objRow[convcc_CourseChapter4Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4KnowledgeEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4KnowledgeEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4KnowledgeEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4KnowledgeEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4KnowledgeEN.ThemeName = objRow[convcc_CourseChapter4Knowledge.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4KnowledgeEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4KnowledgeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4KnowledgeEN.ViewCount = objRow[convcc_CourseChapter4Knowledge.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred = objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4KnowledgeEN.OrderNum = objRow[convcc_CourseChapter4Knowledge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4KnowledgeEN.CreateDate = objRow[convcc_CourseChapter4Knowledge.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4KnowledgeEN.EditPeople = objRow[convcc_CourseChapter4Knowledge.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4KnowledgeEN.UpdDate = objRow[convcc_CourseChapter4Knowledge.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4KnowledgeEN.Memo = objRow[convcc_CourseChapter4Knowledge.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4KnowledgeEN.ParentNodeName = objRow[convcc_CourseChapter4Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred = objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4KnowledgeEN.KnowledgeNum = objRow[convcc_CourseChapter4Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapter4KnowledgeEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapter4KnowledgeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_CourseChapter4KnowledgeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_CourseChapter4KnowledgeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseChapter4KnowledgeEN> arrObjLst = new List<clsvcc_CourseChapter4KnowledgeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = new clsvcc_CourseChapter4KnowledgeEN();
try
{
objvcc_CourseChapter4KnowledgeEN.CourseChapterId = objRow[convcc_CourseChapter4Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4KnowledgeEN.CourseChapterName = objRow[convcc_CourseChapter4Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4KnowledgeEN.ChapterId = objRow[convcc_CourseChapter4Knowledge.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4KnowledgeEN.SectionId = objRow[convcc_CourseChapter4Knowledge.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4KnowledgeEN.ChapterName = objRow[convcc_CourseChapter4Knowledge.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4KnowledgeEN.SectionName = objRow[convcc_CourseChapter4Knowledge.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4KnowledgeEN.ChapterNameSim = objRow[convcc_CourseChapter4Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4KnowledgeEN.SectionNameSim = objRow[convcc_CourseChapter4Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4KnowledgeEN.ChapterContent = objRow[convcc_CourseChapter4Knowledge.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4KnowledgeEN.CourseId = objRow[convcc_CourseChapter4Knowledge.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4KnowledgeEN.CourseCode = objRow[convcc_CourseChapter4Knowledge.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4KnowledgeEN.CourseName = objRow[convcc_CourseChapter4Knowledge.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4KnowledgeEN.ThemeId = objRow[convcc_CourseChapter4Knowledge.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4KnowledgeEN.ParentNodeId = objRow[convcc_CourseChapter4Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4KnowledgeEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4KnowledgeEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4KnowledgeEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4KnowledgeEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4KnowledgeEN.ThemeName = objRow[convcc_CourseChapter4Knowledge.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4KnowledgeEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4KnowledgeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4KnowledgeEN.ViewCount = objRow[convcc_CourseChapter4Knowledge.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred = objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4KnowledgeEN.OrderNum = objRow[convcc_CourseChapter4Knowledge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4KnowledgeEN.CreateDate = objRow[convcc_CourseChapter4Knowledge.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4KnowledgeEN.EditPeople = objRow[convcc_CourseChapter4Knowledge.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4KnowledgeEN.UpdDate = objRow[convcc_CourseChapter4Knowledge.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4KnowledgeEN.Memo = objRow[convcc_CourseChapter4Knowledge.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4KnowledgeEN.ParentNodeName = objRow[convcc_CourseChapter4Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred = objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4KnowledgeEN.KnowledgeNum = objRow[convcc_CourseChapter4Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapter4KnowledgeEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapter4KnowledgeEN);
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
public static List<clsvcc_CourseChapter4KnowledgeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_CourseChapter4KnowledgeEN> arrObjLst = new List<clsvcc_CourseChapter4KnowledgeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = new clsvcc_CourseChapter4KnowledgeEN();
try
{
objvcc_CourseChapter4KnowledgeEN.CourseChapterId = objRow[convcc_CourseChapter4Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4KnowledgeEN.CourseChapterName = objRow[convcc_CourseChapter4Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4KnowledgeEN.ChapterId = objRow[convcc_CourseChapter4Knowledge.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4KnowledgeEN.SectionId = objRow[convcc_CourseChapter4Knowledge.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4KnowledgeEN.ChapterName = objRow[convcc_CourseChapter4Knowledge.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4KnowledgeEN.SectionName = objRow[convcc_CourseChapter4Knowledge.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4KnowledgeEN.ChapterNameSim = objRow[convcc_CourseChapter4Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4KnowledgeEN.SectionNameSim = objRow[convcc_CourseChapter4Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4KnowledgeEN.ChapterContent = objRow[convcc_CourseChapter4Knowledge.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4KnowledgeEN.CourseId = objRow[convcc_CourseChapter4Knowledge.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4KnowledgeEN.CourseCode = objRow[convcc_CourseChapter4Knowledge.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4KnowledgeEN.CourseName = objRow[convcc_CourseChapter4Knowledge.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4KnowledgeEN.ThemeId = objRow[convcc_CourseChapter4Knowledge.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4KnowledgeEN.ParentNodeId = objRow[convcc_CourseChapter4Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4KnowledgeEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4KnowledgeEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4KnowledgeEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4KnowledgeEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4KnowledgeEN.ThemeName = objRow[convcc_CourseChapter4Knowledge.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4KnowledgeEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4KnowledgeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4KnowledgeEN.ViewCount = objRow[convcc_CourseChapter4Knowledge.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred = objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4KnowledgeEN.OrderNum = objRow[convcc_CourseChapter4Knowledge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4KnowledgeEN.CreateDate = objRow[convcc_CourseChapter4Knowledge.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4KnowledgeEN.EditPeople = objRow[convcc_CourseChapter4Knowledge.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4KnowledgeEN.UpdDate = objRow[convcc_CourseChapter4Knowledge.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4KnowledgeEN.Memo = objRow[convcc_CourseChapter4Knowledge.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4KnowledgeEN.ParentNodeName = objRow[convcc_CourseChapter4Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred = objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4KnowledgeEN.KnowledgeNum = objRow[convcc_CourseChapter4Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapter4KnowledgeEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapter4KnowledgeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseChapter4KnowledgeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_CourseChapter4KnowledgeEN> arrObjLst = new List<clsvcc_CourseChapter4KnowledgeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = new clsvcc_CourseChapter4KnowledgeEN();
try
{
objvcc_CourseChapter4KnowledgeEN.CourseChapterId = objRow[convcc_CourseChapter4Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4KnowledgeEN.CourseChapterName = objRow[convcc_CourseChapter4Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4KnowledgeEN.ChapterId = objRow[convcc_CourseChapter4Knowledge.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4KnowledgeEN.SectionId = objRow[convcc_CourseChapter4Knowledge.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4KnowledgeEN.ChapterName = objRow[convcc_CourseChapter4Knowledge.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4KnowledgeEN.SectionName = objRow[convcc_CourseChapter4Knowledge.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4KnowledgeEN.ChapterNameSim = objRow[convcc_CourseChapter4Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4KnowledgeEN.SectionNameSim = objRow[convcc_CourseChapter4Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4KnowledgeEN.ChapterContent = objRow[convcc_CourseChapter4Knowledge.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4KnowledgeEN.CourseId = objRow[convcc_CourseChapter4Knowledge.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4KnowledgeEN.CourseCode = objRow[convcc_CourseChapter4Knowledge.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4KnowledgeEN.CourseName = objRow[convcc_CourseChapter4Knowledge.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4KnowledgeEN.ThemeId = objRow[convcc_CourseChapter4Knowledge.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4KnowledgeEN.ParentNodeId = objRow[convcc_CourseChapter4Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4KnowledgeEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4KnowledgeEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4KnowledgeEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4KnowledgeEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4KnowledgeEN.ThemeName = objRow[convcc_CourseChapter4Knowledge.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4KnowledgeEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4KnowledgeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4Knowledge.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4KnowledgeEN.ViewCount = objRow[convcc_CourseChapter4Knowledge.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred = objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4KnowledgeEN.OrderNum = objRow[convcc_CourseChapter4Knowledge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4KnowledgeEN.CreateDate = objRow[convcc_CourseChapter4Knowledge.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4KnowledgeEN.EditPeople = objRow[convcc_CourseChapter4Knowledge.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4KnowledgeEN.UpdDate = objRow[convcc_CourseChapter4Knowledge.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4KnowledgeEN.Memo = objRow[convcc_CourseChapter4Knowledge.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4KnowledgeEN.ParentNodeName = objRow[convcc_CourseChapter4Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred = objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4KnowledgeEN.KnowledgeNum = objRow[convcc_CourseChapter4Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapter4KnowledgeEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapter4KnowledgeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_CourseChapter4Knowledge(ref clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN)
{
bool bolResult = vcc_CourseChapter4KnowledgeDA.Getvcc_CourseChapter4Knowledge(ref objvcc_CourseChapter4KnowledgeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseChapterId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseChapter4KnowledgeEN GetObjByCourseChapterId(string strCourseChapterId)
{
if (strCourseChapterId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCourseChapterId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCourseChapterId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCourseChapterId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = vcc_CourseChapter4KnowledgeDA.GetObjByCourseChapterId(strCourseChapterId);
return objvcc_CourseChapter4KnowledgeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_CourseChapter4KnowledgeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = vcc_CourseChapter4KnowledgeDA.GetFirstObj(strWhereCond);
 return objvcc_CourseChapter4KnowledgeEN;
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
public static clsvcc_CourseChapter4KnowledgeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = vcc_CourseChapter4KnowledgeDA.GetObjByDataRow(objRow);
 return objvcc_CourseChapter4KnowledgeEN;
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
public static clsvcc_CourseChapter4KnowledgeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = vcc_CourseChapter4KnowledgeDA.GetObjByDataRow(objRow);
 return objvcc_CourseChapter4KnowledgeEN;
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
 /// <param name = "strCourseChapterId">所给的关键字</param>
 /// <param name = "lstvcc_CourseChapter4KnowledgeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseChapter4KnowledgeEN GetObjByCourseChapterIdFromList(string strCourseChapterId, List<clsvcc_CourseChapter4KnowledgeEN> lstvcc_CourseChapter4KnowledgeObjLst)
{
foreach (clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN in lstvcc_CourseChapter4KnowledgeObjLst)
{
if (objvcc_CourseChapter4KnowledgeEN.CourseChapterId == strCourseChapterId)
{
return objvcc_CourseChapter4KnowledgeEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strCourseChapterId;
 try
 {
 strCourseChapterId = new clsvcc_CourseChapter4KnowledgeDA().GetFirstID(strWhereCond);
 return strCourseChapterId;
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
 arrList = vcc_CourseChapter4KnowledgeDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_CourseChapter4KnowledgeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCourseChapterId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCourseChapterId)
{
if (string.IsNullOrEmpty(strCourseChapterId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCourseChapterId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vcc_CourseChapter4KnowledgeDA.IsExist(strCourseChapterId);
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
 bolIsExist = clsvcc_CourseChapter4KnowledgeDA.IsExistTable();
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
 bolIsExist = vcc_CourseChapter4KnowledgeDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_CourseChapter4KnowledgeENS">源对象</param>
 /// <param name = "objvcc_CourseChapter4KnowledgeENT">目标对象</param>
 public static void CopyTo(clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeENS, clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeENT)
{
try
{
objvcc_CourseChapter4KnowledgeENT.CourseChapterId = objvcc_CourseChapter4KnowledgeENS.CourseChapterId; //课程章节ID
objvcc_CourseChapter4KnowledgeENT.CourseChapterName = objvcc_CourseChapter4KnowledgeENS.CourseChapterName; //课程章节名称
objvcc_CourseChapter4KnowledgeENT.ChapterId = objvcc_CourseChapter4KnowledgeENS.ChapterId; //章Id
objvcc_CourseChapter4KnowledgeENT.SectionId = objvcc_CourseChapter4KnowledgeENS.SectionId; //节Id
objvcc_CourseChapter4KnowledgeENT.ChapterName = objvcc_CourseChapter4KnowledgeENS.ChapterName; //章名
objvcc_CourseChapter4KnowledgeENT.SectionName = objvcc_CourseChapter4KnowledgeENS.SectionName; //节名
objvcc_CourseChapter4KnowledgeENT.ChapterNameSim = objvcc_CourseChapter4KnowledgeENS.ChapterNameSim; //章名简称
objvcc_CourseChapter4KnowledgeENT.SectionNameSim = objvcc_CourseChapter4KnowledgeENS.SectionNameSim; //节名简称
objvcc_CourseChapter4KnowledgeENT.ChapterContent = objvcc_CourseChapter4KnowledgeENS.ChapterContent; //章节内容
objvcc_CourseChapter4KnowledgeENT.CourseId = objvcc_CourseChapter4KnowledgeENS.CourseId; //课程Id
objvcc_CourseChapter4KnowledgeENT.CourseCode = objvcc_CourseChapter4KnowledgeENS.CourseCode; //课程代码
objvcc_CourseChapter4KnowledgeENT.CourseName = objvcc_CourseChapter4KnowledgeENS.CourseName; //课程名称
objvcc_CourseChapter4KnowledgeENT.ThemeId = objvcc_CourseChapter4KnowledgeENS.ThemeId; //主题Id
objvcc_CourseChapter4KnowledgeENT.ParentNodeId = objvcc_CourseChapter4KnowledgeENS.ParentNodeId; //父节点编号
objvcc_CourseChapter4KnowledgeENT.IsOpenToAllStu = objvcc_CourseChapter4KnowledgeENS.IsOpenToAllStu; //全校师生
objvcc_CourseChapter4KnowledgeENT.IsOpenToSchool = objvcc_CourseChapter4KnowledgeENS.IsOpenToSchool; //全校师生公开
objvcc_CourseChapter4KnowledgeENT.IsOpenToSocial = objvcc_CourseChapter4KnowledgeENS.IsOpenToSocial; //社会公众
objvcc_CourseChapter4KnowledgeENT.IsMustMenu = objvcc_CourseChapter4KnowledgeENS.IsMustMenu; //是否必建栏目
objvcc_CourseChapter4KnowledgeENT.ThemeName = objvcc_CourseChapter4KnowledgeENS.ThemeName; //主题名
objvcc_CourseChapter4KnowledgeENT.IsFile = objvcc_CourseChapter4KnowledgeENS.IsFile; //项目或文件夹
objvcc_CourseChapter4KnowledgeENT.IsUse = objvcc_CourseChapter4KnowledgeENS.IsUse; //是否使用
objvcc_CourseChapter4KnowledgeENT.ViewCount = objvcc_CourseChapter4KnowledgeENS.ViewCount; //浏览量
objvcc_CourseChapter4KnowledgeENT.CourseChapterReferred = objvcc_CourseChapter4KnowledgeENS.CourseChapterReferred; //节简称
objvcc_CourseChapter4KnowledgeENT.OrderNum = objvcc_CourseChapter4KnowledgeENS.OrderNum; //序号
objvcc_CourseChapter4KnowledgeENT.CreateDate = objvcc_CourseChapter4KnowledgeENS.CreateDate; //建立日期
objvcc_CourseChapter4KnowledgeENT.EditPeople = objvcc_CourseChapter4KnowledgeENS.EditPeople; //修改人
objvcc_CourseChapter4KnowledgeENT.UpdDate = objvcc_CourseChapter4KnowledgeENS.UpdDate; //修改日期
objvcc_CourseChapter4KnowledgeENT.Memo = objvcc_CourseChapter4KnowledgeENS.Memo; //备注
objvcc_CourseChapter4KnowledgeENT.ParentNodeName = objvcc_CourseChapter4KnowledgeENS.ParentNodeName; //父节点名称
objvcc_CourseChapter4KnowledgeENT.ParentNodeReferred = objvcc_CourseChapter4KnowledgeENS.ParentNodeReferred; //章简称
objvcc_CourseChapter4KnowledgeENT.KnowledgeNum = objvcc_CourseChapter4KnowledgeENS.KnowledgeNum; //知识点数
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
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN)
{
try
{
objvcc_CourseChapter4KnowledgeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_CourseChapter4KnowledgeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.CourseChapterId = objvcc_CourseChapter4KnowledgeEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.CourseChapterName = objvcc_CourseChapter4KnowledgeEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.ChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.ChapterId = objvcc_CourseChapter4KnowledgeEN.ChapterId == "[null]" ? null :  objvcc_CourseChapter4KnowledgeEN.ChapterId; //章Id
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.SectionId = objvcc_CourseChapter4KnowledgeEN.SectionId == "[null]" ? null :  objvcc_CourseChapter4KnowledgeEN.SectionId; //节Id
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.ChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.ChapterName = objvcc_CourseChapter4KnowledgeEN.ChapterName == "[null]" ? null :  objvcc_CourseChapter4KnowledgeEN.ChapterName; //章名
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.SectionName = objvcc_CourseChapter4KnowledgeEN.SectionName == "[null]" ? null :  objvcc_CourseChapter4KnowledgeEN.SectionName; //节名
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.ChapterNameSim = objvcc_CourseChapter4KnowledgeEN.ChapterNameSim == "[null]" ? null :  objvcc_CourseChapter4KnowledgeEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.SectionNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.SectionNameSim = objvcc_CourseChapter4KnowledgeEN.SectionNameSim == "[null]" ? null :  objvcc_CourseChapter4KnowledgeEN.SectionNameSim; //节名简称
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.ChapterContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.ChapterContent = objvcc_CourseChapter4KnowledgeEN.ChapterContent == "[null]" ? null :  objvcc_CourseChapter4KnowledgeEN.ChapterContent; //章节内容
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.CourseId = objvcc_CourseChapter4KnowledgeEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.CourseCode = objvcc_CourseChapter4KnowledgeEN.CourseCode == "[null]" ? null :  objvcc_CourseChapter4KnowledgeEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.CourseName = objvcc_CourseChapter4KnowledgeEN.CourseName == "[null]" ? null :  objvcc_CourseChapter4KnowledgeEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.ThemeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.ThemeId = objvcc_CourseChapter4KnowledgeEN.ThemeId == "[null]" ? null :  objvcc_CourseChapter4KnowledgeEN.ThemeId; //主题Id
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.ParentNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.ParentNodeId = objvcc_CourseChapter4KnowledgeEN.ParentNodeId; //父节点编号
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.IsOpenToAllStu, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.IsOpenToAllStu = objvcc_CourseChapter4KnowledgeEN.IsOpenToAllStu; //全校师生
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.IsOpenToSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.IsOpenToSchool = objvcc_CourseChapter4KnowledgeEN.IsOpenToSchool; //全校师生公开
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.IsOpenToSocial, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.IsOpenToSocial = objvcc_CourseChapter4KnowledgeEN.IsOpenToSocial; //社会公众
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.IsMustMenu, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.IsMustMenu = objvcc_CourseChapter4KnowledgeEN.IsMustMenu; //是否必建栏目
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.ThemeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.ThemeName = objvcc_CourseChapter4KnowledgeEN.ThemeName == "[null]" ? null :  objvcc_CourseChapter4KnowledgeEN.ThemeName; //主题名
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.IsFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.IsFile = objvcc_CourseChapter4KnowledgeEN.IsFile; //项目或文件夹
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.IsUse = objvcc_CourseChapter4KnowledgeEN.IsUse; //是否使用
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.ViewCount = objvcc_CourseChapter4KnowledgeEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.CourseChapterReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred = objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred == "[null]" ? null :  objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred; //节简称
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.OrderNum = objvcc_CourseChapter4KnowledgeEN.OrderNum; //序号
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.CreateDate = objvcc_CourseChapter4KnowledgeEN.CreateDate == "[null]" ? null :  objvcc_CourseChapter4KnowledgeEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.EditPeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.EditPeople = objvcc_CourseChapter4KnowledgeEN.EditPeople == "[null]" ? null :  objvcc_CourseChapter4KnowledgeEN.EditPeople; //修改人
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.UpdDate = objvcc_CourseChapter4KnowledgeEN.UpdDate == "[null]" ? null :  objvcc_CourseChapter4KnowledgeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.Memo = objvcc_CourseChapter4KnowledgeEN.Memo == "[null]" ? null :  objvcc_CourseChapter4KnowledgeEN.Memo; //备注
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.ParentNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.ParentNodeName = objvcc_CourseChapter4KnowledgeEN.ParentNodeName == "[null]" ? null :  objvcc_CourseChapter4KnowledgeEN.ParentNodeName; //父节点名称
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.ParentNodeReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred = objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred == "[null]" ? null :  objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred; //章简称
}
if (arrFldSet.Contains(convcc_CourseChapter4Knowledge.KnowledgeNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4KnowledgeEN.KnowledgeNum = objvcc_CourseChapter4KnowledgeEN.KnowledgeNum; //知识点数
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
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN)
{
try
{
if (objvcc_CourseChapter4KnowledgeEN.ChapterId == "[null]") objvcc_CourseChapter4KnowledgeEN.ChapterId = null; //章Id
if (objvcc_CourseChapter4KnowledgeEN.SectionId == "[null]") objvcc_CourseChapter4KnowledgeEN.SectionId = null; //节Id
if (objvcc_CourseChapter4KnowledgeEN.ChapterName == "[null]") objvcc_CourseChapter4KnowledgeEN.ChapterName = null; //章名
if (objvcc_CourseChapter4KnowledgeEN.SectionName == "[null]") objvcc_CourseChapter4KnowledgeEN.SectionName = null; //节名
if (objvcc_CourseChapter4KnowledgeEN.ChapterNameSim == "[null]") objvcc_CourseChapter4KnowledgeEN.ChapterNameSim = null; //章名简称
if (objvcc_CourseChapter4KnowledgeEN.SectionNameSim == "[null]") objvcc_CourseChapter4KnowledgeEN.SectionNameSim = null; //节名简称
if (objvcc_CourseChapter4KnowledgeEN.ChapterContent == "[null]") objvcc_CourseChapter4KnowledgeEN.ChapterContent = null; //章节内容
if (objvcc_CourseChapter4KnowledgeEN.CourseCode == "[null]") objvcc_CourseChapter4KnowledgeEN.CourseCode = null; //课程代码
if (objvcc_CourseChapter4KnowledgeEN.CourseName == "[null]") objvcc_CourseChapter4KnowledgeEN.CourseName = null; //课程名称
if (objvcc_CourseChapter4KnowledgeEN.ThemeId == "[null]") objvcc_CourseChapter4KnowledgeEN.ThemeId = null; //主题Id
if (objvcc_CourseChapter4KnowledgeEN.ThemeName == "[null]") objvcc_CourseChapter4KnowledgeEN.ThemeName = null; //主题名
if (objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred == "[null]") objvcc_CourseChapter4KnowledgeEN.CourseChapterReferred = null; //节简称
if (objvcc_CourseChapter4KnowledgeEN.CreateDate == "[null]") objvcc_CourseChapter4KnowledgeEN.CreateDate = null; //建立日期
if (objvcc_CourseChapter4KnowledgeEN.EditPeople == "[null]") objvcc_CourseChapter4KnowledgeEN.EditPeople = null; //修改人
if (objvcc_CourseChapter4KnowledgeEN.UpdDate == "[null]") objvcc_CourseChapter4KnowledgeEN.UpdDate = null; //修改日期
if (objvcc_CourseChapter4KnowledgeEN.Memo == "[null]") objvcc_CourseChapter4KnowledgeEN.Memo = null; //备注
if (objvcc_CourseChapter4KnowledgeEN.ParentNodeName == "[null]") objvcc_CourseChapter4KnowledgeEN.ParentNodeName = null; //父节点名称
if (objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred == "[null]") objvcc_CourseChapter4KnowledgeEN.ParentNodeReferred = null; //章简称
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
public static void CheckProperty4Condition(clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN)
{
 vcc_CourseChapter4KnowledgeDA.CheckProperty4Condition(objvcc_CourseChapter4KnowledgeEN);
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
if (clscc_CourseChapterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterBL没有刷新缓存机制(clscc_CourseChapterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by CourseChapterId");
//if (arrvcc_CourseChapter4KnowledgeObjLstCache == null)
//{
//arrvcc_CourseChapter4KnowledgeObjLstCache = vcc_CourseChapter4KnowledgeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCourseChapterId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseChapter4KnowledgeEN GetObjByCourseChapterIdCache(string strCourseChapterId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapter4KnowledgeEN._CurrTabName, strCourseId);
List<clsvcc_CourseChapter4KnowledgeEN> arrvcc_CourseChapter4KnowledgeObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseChapter4KnowledgeEN> arrvcc_CourseChapter4KnowledgeObjLst_Sel =
arrvcc_CourseChapter4KnowledgeObjLstCache
.Where(x=> x.CourseChapterId == strCourseChapterId 
);
if (arrvcc_CourseChapter4KnowledgeObjLst_Sel.Count() == 0)
{
   clsvcc_CourseChapter4KnowledgeEN obj = clsvcc_CourseChapter4KnowledgeBL.GetObjByCourseChapterId(strCourseChapterId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strCourseChapterId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvcc_CourseChapter4KnowledgeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseChapter4KnowledgeEN> GetAllvcc_CourseChapter4KnowledgeObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvcc_CourseChapter4KnowledgeEN> arrvcc_CourseChapter4KnowledgeObjLstCache = GetObjLstCache(strCourseId); 
return arrvcc_CourseChapter4KnowledgeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseChapter4KnowledgeEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapter4KnowledgeEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvcc_CourseChapter4KnowledgeEN> arrvcc_CourseChapter4KnowledgeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvcc_CourseChapter4KnowledgeObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapter4KnowledgeEN._CurrTabName, strCourseId);
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-02-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strCourseChapterId, string strCourseId)
{
if (strInFldName != convcc_CourseChapter4Knowledge.CourseChapterId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_CourseChapter4Knowledge.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_CourseChapter4Knowledge.AttributeName));
throw new Exception(strMsg);
}
var objvcc_CourseChapter4Knowledge = clsvcc_CourseChapter4KnowledgeBL.GetObjByCourseChapterIdCache(strCourseChapterId, strCourseId);
if (objvcc_CourseChapter4Knowledge == null) return "";
return objvcc_CourseChapter4Knowledge[strOutFldName].ToString();
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
int intRecCount = clsvcc_CourseChapter4KnowledgeDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_CourseChapter4KnowledgeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_CourseChapter4KnowledgeDA.GetRecCount();
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
int intRecCount = clsvcc_CourseChapter4KnowledgeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeCond)
{
 string strCourseId = objvcc_CourseChapter4KnowledgeCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvcc_CourseChapter4KnowledgeBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvcc_CourseChapter4KnowledgeEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseChapter4KnowledgeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseChapter4Knowledge.AttributeName)
{
if (objvcc_CourseChapter4KnowledgeCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseChapter4KnowledgeCond[strFldName].ToString());
}
else
{
if (objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseChapter4KnowledgeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseChapter4KnowledgeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseChapter4KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseChapter4KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseChapter4KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseChapter4KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseChapter4KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseChapter4KnowledgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseChapter4KnowledgeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseChapter4KnowledgeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseChapter4KnowledgeCond[strFldName]));
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
 List<string> arrList = clsvcc_CourseChapter4KnowledgeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseChapter4KnowledgeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseChapter4KnowledgeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}