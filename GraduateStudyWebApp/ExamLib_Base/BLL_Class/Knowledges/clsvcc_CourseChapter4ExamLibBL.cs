
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseChapter4ExamLibBL
 表名:vcc_CourseChapter4ExamLib(01120159)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:03:53
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
public static class  clsvcc_CourseChapter4ExamLibBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseChapterId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseChapter4ExamLibEN GetObj(this K_CourseChapterId_vcc_CourseChapter4ExamLib myKey)
{
clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = clsvcc_CourseChapter4ExamLibBL.vcc_CourseChapter4ExamLibDA.GetObjByCourseChapterId(myKey.Value);
return objvcc_CourseChapter4ExamLibEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetCourseChapterId(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_CourseChapter4ExamLib.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_CourseChapter4ExamLib.CourseChapterId);
}
objvcc_CourseChapter4ExamLibEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.CourseChapterId) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.CourseChapterId, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.CourseChapterId] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetCourseChapterName(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterName, convcc_CourseChapter4ExamLib.CourseChapterName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_CourseChapter4ExamLib.CourseChapterName);
}
objvcc_CourseChapter4ExamLibEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.CourseChapterName) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.CourseChapterName, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.CourseChapterName] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetChapterId(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterId, 8, convcc_CourseChapter4ExamLib.ChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convcc_CourseChapter4ExamLib.ChapterId);
}
objvcc_CourseChapter4ExamLibEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.ChapterId) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.ChapterId, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ChapterId] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetSectionId(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, convcc_CourseChapter4ExamLib.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convcc_CourseChapter4ExamLib.SectionId);
}
objvcc_CourseChapter4ExamLibEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.SectionId) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.SectionId, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.SectionId] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetChapterName(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_CourseChapter4ExamLib.ChapterName);
}
objvcc_CourseChapter4ExamLibEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.ChapterName) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.ChapterName, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ChapterName] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetSectionName(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_CourseChapter4ExamLib.SectionName);
}
objvcc_CourseChapter4ExamLibEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.SectionName) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.SectionName, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.SectionName] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetChapterNameSim(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, convcc_CourseChapter4ExamLib.ChapterNameSim);
}
objvcc_CourseChapter4ExamLibEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.ChapterNameSim) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.ChapterNameSim, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ChapterNameSim] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetSectionNameSim(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strSectionNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionNameSim, 10, convcc_CourseChapter4ExamLib.SectionNameSim);
}
objvcc_CourseChapter4ExamLibEN.SectionNameSim = strSectionNameSim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.SectionNameSim) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.SectionNameSim, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.SectionNameSim] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetChapterContent(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strChapterContent, string strComparisonOp="")
	{
objvcc_CourseChapter4ExamLibEN.ChapterContent = strChapterContent; //章节内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.ChapterContent) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.ChapterContent, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ChapterContent] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetCourseId(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convcc_CourseChapter4ExamLib.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_CourseChapter4ExamLib.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_CourseChapter4ExamLib.CourseId);
}
objvcc_CourseChapter4ExamLibEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.CourseId) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.CourseId, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.CourseId] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetCourseCode(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convcc_CourseChapter4ExamLib.CourseCode);
}
objvcc_CourseChapter4ExamLibEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.CourseCode) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.CourseCode, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.CourseCode] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetCourseName(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_CourseChapter4ExamLib.CourseName);
}
objvcc_CourseChapter4ExamLibEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.CourseName) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.CourseName, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.CourseName] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetThemeId(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strThemeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strThemeId, 4, convcc_CourseChapter4ExamLib.ThemeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strThemeId, 4, convcc_CourseChapter4ExamLib.ThemeId);
}
objvcc_CourseChapter4ExamLibEN.ThemeId = strThemeId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.ThemeId) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.ThemeId, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ThemeId] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetParentNodeId(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strParentNodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParentNodeId, convcc_CourseChapter4ExamLib.ParentNodeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeId, 8, convcc_CourseChapter4ExamLib.ParentNodeId);
}
objvcc_CourseChapter4ExamLibEN.ParentNodeId = strParentNodeId; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.ParentNodeId) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.ParentNodeId, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ParentNodeId] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetIsOpenToAllStu(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, bool bolIsOpenToAllStu, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsOpenToAllStu, convcc_CourseChapter4ExamLib.IsOpenToAllStu);
objvcc_CourseChapter4ExamLibEN.IsOpenToAllStu = bolIsOpenToAllStu; //全校师生
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.IsOpenToAllStu) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.IsOpenToAllStu, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.IsOpenToAllStu] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetIsOpenToSchool(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, bool bolIsOpenToSchool, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsOpenToSchool, convcc_CourseChapter4ExamLib.IsOpenToSchool);
objvcc_CourseChapter4ExamLibEN.IsOpenToSchool = bolIsOpenToSchool; //全校师生公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.IsOpenToSchool) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.IsOpenToSchool, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.IsOpenToSchool] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetIsOpenToSocial(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, bool bolIsOpenToSocial, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsOpenToSocial, convcc_CourseChapter4ExamLib.IsOpenToSocial);
objvcc_CourseChapter4ExamLibEN.IsOpenToSocial = bolIsOpenToSocial; //社会公众
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.IsOpenToSocial) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.IsOpenToSocial, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.IsOpenToSocial] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetIsMustMenu(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, bool bolIsMustMenu, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsMustMenu, convcc_CourseChapter4ExamLib.IsMustMenu);
objvcc_CourseChapter4ExamLibEN.IsMustMenu = bolIsMustMenu; //是否必建栏目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.IsMustMenu) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.IsMustMenu, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.IsMustMenu] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetThemeName(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strThemeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strThemeName, 200, convcc_CourseChapter4ExamLib.ThemeName);
}
objvcc_CourseChapter4ExamLibEN.ThemeName = strThemeName; //主题名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.ThemeName) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.ThemeName, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ThemeName] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetIsFile(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, bool bolIsFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsFile, convcc_CourseChapter4ExamLib.IsFile);
objvcc_CourseChapter4ExamLibEN.IsFile = bolIsFile; //项目或文件夹
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.IsFile) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.IsFile, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.IsFile] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetIsUse(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, bool bolIsUse, string strComparisonOp="")
	{
objvcc_CourseChapter4ExamLibEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.IsUse) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.IsUse, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.IsUse] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetViewCount(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, int? intViewCount, string strComparisonOp="")
	{
objvcc_CourseChapter4ExamLibEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.ViewCount) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.ViewCount, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ViewCount] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetCourseChapterReferred(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strCourseChapterReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convcc_CourseChapter4ExamLib.CourseChapterReferred);
}
objvcc_CourseChapter4ExamLibEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.CourseChapterReferred) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.CourseChapterReferred, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.CourseChapterReferred] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetOrderNum(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, int? intOrderNum, string strComparisonOp="")
	{
objvcc_CourseChapter4ExamLibEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.OrderNum) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.OrderNum, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.OrderNum] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetCreateDate(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convcc_CourseChapter4ExamLib.CreateDate);
}
objvcc_CourseChapter4ExamLibEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.CreateDate) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.CreateDate, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.CreateDate] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetEditPeople(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strEditPeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEditPeople, 50, convcc_CourseChapter4ExamLib.EditPeople);
}
objvcc_CourseChapter4ExamLibEN.EditPeople = strEditPeople; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.EditPeople) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.EditPeople, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.EditPeople] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetUpdDate(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_CourseChapter4ExamLib.UpdDate);
}
objvcc_CourseChapter4ExamLibEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.UpdDate) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.UpdDate, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.UpdDate] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetMemo(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_CourseChapter4ExamLib.Memo);
}
objvcc_CourseChapter4ExamLibEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.Memo) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.Memo, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.Memo] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetParentNodeName(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strParentNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeName, 100, convcc_CourseChapter4ExamLib.ParentNodeName);
}
objvcc_CourseChapter4ExamLibEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.ParentNodeName) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.ParentNodeName, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ParentNodeName] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetParentNodeReferred(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strParentNodeReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convcc_CourseChapter4ExamLib.ParentNodeReferred);
}
objvcc_CourseChapter4ExamLibEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.ParentNodeReferred) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.ParentNodeReferred, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ParentNodeReferred] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetQuesionnaireNum(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, int? intQuesionnaireNum, string strComparisonOp="")
	{
objvcc_CourseChapter4ExamLibEN.QuesionnaireNum = intQuesionnaireNum; //习题数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.QuesionnaireNum) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.QuesionnaireNum, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.QuesionnaireNum] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibENS">源对象</param>
 /// <param name = "objvcc_CourseChapter4ExamLibENT">目标对象</param>
 public static void CopyTo(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibENS, clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibENT)
{
try
{
objvcc_CourseChapter4ExamLibENT.CourseChapterId = objvcc_CourseChapter4ExamLibENS.CourseChapterId; //课程章节ID
objvcc_CourseChapter4ExamLibENT.CourseChapterName = objvcc_CourseChapter4ExamLibENS.CourseChapterName; //课程章节名称
objvcc_CourseChapter4ExamLibENT.ChapterId = objvcc_CourseChapter4ExamLibENS.ChapterId; //章Id
objvcc_CourseChapter4ExamLibENT.SectionId = objvcc_CourseChapter4ExamLibENS.SectionId; //节Id
objvcc_CourseChapter4ExamLibENT.ChapterName = objvcc_CourseChapter4ExamLibENS.ChapterName; //章名
objvcc_CourseChapter4ExamLibENT.SectionName = objvcc_CourseChapter4ExamLibENS.SectionName; //节名
objvcc_CourseChapter4ExamLibENT.ChapterNameSim = objvcc_CourseChapter4ExamLibENS.ChapterNameSim; //章名简称
objvcc_CourseChapter4ExamLibENT.SectionNameSim = objvcc_CourseChapter4ExamLibENS.SectionNameSim; //节名简称
objvcc_CourseChapter4ExamLibENT.ChapterContent = objvcc_CourseChapter4ExamLibENS.ChapterContent; //章节内容
objvcc_CourseChapter4ExamLibENT.CourseId = objvcc_CourseChapter4ExamLibENS.CourseId; //课程Id
objvcc_CourseChapter4ExamLibENT.CourseCode = objvcc_CourseChapter4ExamLibENS.CourseCode; //课程代码
objvcc_CourseChapter4ExamLibENT.CourseName = objvcc_CourseChapter4ExamLibENS.CourseName; //课程名称
objvcc_CourseChapter4ExamLibENT.ThemeId = objvcc_CourseChapter4ExamLibENS.ThemeId; //主题Id
objvcc_CourseChapter4ExamLibENT.ParentNodeId = objvcc_CourseChapter4ExamLibENS.ParentNodeId; //父节点编号
objvcc_CourseChapter4ExamLibENT.IsOpenToAllStu = objvcc_CourseChapter4ExamLibENS.IsOpenToAllStu; //全校师生
objvcc_CourseChapter4ExamLibENT.IsOpenToSchool = objvcc_CourseChapter4ExamLibENS.IsOpenToSchool; //全校师生公开
objvcc_CourseChapter4ExamLibENT.IsOpenToSocial = objvcc_CourseChapter4ExamLibENS.IsOpenToSocial; //社会公众
objvcc_CourseChapter4ExamLibENT.IsMustMenu = objvcc_CourseChapter4ExamLibENS.IsMustMenu; //是否必建栏目
objvcc_CourseChapter4ExamLibENT.ThemeName = objvcc_CourseChapter4ExamLibENS.ThemeName; //主题名
objvcc_CourseChapter4ExamLibENT.IsFile = objvcc_CourseChapter4ExamLibENS.IsFile; //项目或文件夹
objvcc_CourseChapter4ExamLibENT.IsUse = objvcc_CourseChapter4ExamLibENS.IsUse; //是否使用
objvcc_CourseChapter4ExamLibENT.ViewCount = objvcc_CourseChapter4ExamLibENS.ViewCount; //浏览量
objvcc_CourseChapter4ExamLibENT.CourseChapterReferred = objvcc_CourseChapter4ExamLibENS.CourseChapterReferred; //节简称
objvcc_CourseChapter4ExamLibENT.OrderNum = objvcc_CourseChapter4ExamLibENS.OrderNum; //序号
objvcc_CourseChapter4ExamLibENT.CreateDate = objvcc_CourseChapter4ExamLibENS.CreateDate; //建立日期
objvcc_CourseChapter4ExamLibENT.EditPeople = objvcc_CourseChapter4ExamLibENS.EditPeople; //修改人
objvcc_CourseChapter4ExamLibENT.UpdDate = objvcc_CourseChapter4ExamLibENS.UpdDate; //修改日期
objvcc_CourseChapter4ExamLibENT.Memo = objvcc_CourseChapter4ExamLibENS.Memo; //备注
objvcc_CourseChapter4ExamLibENT.ParentNodeName = objvcc_CourseChapter4ExamLibENS.ParentNodeName; //父节点名称
objvcc_CourseChapter4ExamLibENT.ParentNodeReferred = objvcc_CourseChapter4ExamLibENS.ParentNodeReferred; //章简称
objvcc_CourseChapter4ExamLibENT.QuesionnaireNum = objvcc_CourseChapter4ExamLibENS.QuesionnaireNum; //习题数
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
 /// <param name = "objvcc_CourseChapter4ExamLibENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseChapter4ExamLibEN:objvcc_CourseChapter4ExamLibENT</returns>
 public static clsvcc_CourseChapter4ExamLibEN CopyTo(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibENS)
{
try
{
 clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibENT = new clsvcc_CourseChapter4ExamLibEN()
{
CourseChapterId = objvcc_CourseChapter4ExamLibENS.CourseChapterId, //课程章节ID
CourseChapterName = objvcc_CourseChapter4ExamLibENS.CourseChapterName, //课程章节名称
ChapterId = objvcc_CourseChapter4ExamLibENS.ChapterId, //章Id
SectionId = objvcc_CourseChapter4ExamLibENS.SectionId, //节Id
ChapterName = objvcc_CourseChapter4ExamLibENS.ChapterName, //章名
SectionName = objvcc_CourseChapter4ExamLibENS.SectionName, //节名
ChapterNameSim = objvcc_CourseChapter4ExamLibENS.ChapterNameSim, //章名简称
SectionNameSim = objvcc_CourseChapter4ExamLibENS.SectionNameSim, //节名简称
ChapterContent = objvcc_CourseChapter4ExamLibENS.ChapterContent, //章节内容
CourseId = objvcc_CourseChapter4ExamLibENS.CourseId, //课程Id
CourseCode = objvcc_CourseChapter4ExamLibENS.CourseCode, //课程代码
CourseName = objvcc_CourseChapter4ExamLibENS.CourseName, //课程名称
ThemeId = objvcc_CourseChapter4ExamLibENS.ThemeId, //主题Id
ParentNodeId = objvcc_CourseChapter4ExamLibENS.ParentNodeId, //父节点编号
IsOpenToAllStu = objvcc_CourseChapter4ExamLibENS.IsOpenToAllStu, //全校师生
IsOpenToSchool = objvcc_CourseChapter4ExamLibENS.IsOpenToSchool, //全校师生公开
IsOpenToSocial = objvcc_CourseChapter4ExamLibENS.IsOpenToSocial, //社会公众
IsMustMenu = objvcc_CourseChapter4ExamLibENS.IsMustMenu, //是否必建栏目
ThemeName = objvcc_CourseChapter4ExamLibENS.ThemeName, //主题名
IsFile = objvcc_CourseChapter4ExamLibENS.IsFile, //项目或文件夹
IsUse = objvcc_CourseChapter4ExamLibENS.IsUse, //是否使用
ViewCount = objvcc_CourseChapter4ExamLibENS.ViewCount, //浏览量
CourseChapterReferred = objvcc_CourseChapter4ExamLibENS.CourseChapterReferred, //节简称
OrderNum = objvcc_CourseChapter4ExamLibENS.OrderNum, //序号
CreateDate = objvcc_CourseChapter4ExamLibENS.CreateDate, //建立日期
EditPeople = objvcc_CourseChapter4ExamLibENS.EditPeople, //修改人
UpdDate = objvcc_CourseChapter4ExamLibENS.UpdDate, //修改日期
Memo = objvcc_CourseChapter4ExamLibENS.Memo, //备注
ParentNodeName = objvcc_CourseChapter4ExamLibENS.ParentNodeName, //父节点名称
ParentNodeReferred = objvcc_CourseChapter4ExamLibENS.ParentNodeReferred, //章简称
QuesionnaireNum = objvcc_CourseChapter4ExamLibENS.QuesionnaireNum, //习题数
};
 return objvcc_CourseChapter4ExamLibENT;
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
public static void CheckProperty4Condition(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN)
{
 clsvcc_CourseChapter4ExamLibBL.vcc_CourseChapter4ExamLibDA.CheckProperty4Condition(objvcc_CourseChapter4ExamLibEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.CourseChapterId, objvcc_CourseChapter4ExamLibCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.CourseChapterName, objvcc_CourseChapter4ExamLibCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.ChapterId) == true)
{
string strComparisonOpChapterId = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.ChapterId, objvcc_CourseChapter4ExamLibCond.ChapterId, strComparisonOpChapterId);
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.SectionId) == true)
{
string strComparisonOpSectionId = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.SectionId, objvcc_CourseChapter4ExamLibCond.SectionId, strComparisonOpSectionId);
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.ChapterName) == true)
{
string strComparisonOpChapterName = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.ChapterName, objvcc_CourseChapter4ExamLibCond.ChapterName, strComparisonOpChapterName);
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.SectionName) == true)
{
string strComparisonOpSectionName = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.SectionName, objvcc_CourseChapter4ExamLibCond.SectionName, strComparisonOpSectionName);
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.ChapterNameSim, objvcc_CourseChapter4ExamLibCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.SectionNameSim) == true)
{
string strComparisonOpSectionNameSim = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.SectionNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.SectionNameSim, objvcc_CourseChapter4ExamLibCond.SectionNameSim, strComparisonOpSectionNameSim);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.CourseId, objvcc_CourseChapter4ExamLibCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.CourseCode) == true)
{
string strComparisonOpCourseCode = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.CourseCode, objvcc_CourseChapter4ExamLibCond.CourseCode, strComparisonOpCourseCode);
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.CourseName) == true)
{
string strComparisonOpCourseName = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.CourseName, objvcc_CourseChapter4ExamLibCond.CourseName, strComparisonOpCourseName);
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.ThemeId) == true)
{
string strComparisonOpThemeId = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ThemeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.ThemeId, objvcc_CourseChapter4ExamLibCond.ThemeId, strComparisonOpThemeId);
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.ParentNodeId) == true)
{
string strComparisonOpParentNodeId = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ParentNodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.ParentNodeId, objvcc_CourseChapter4ExamLibCond.ParentNodeId, strComparisonOpParentNodeId);
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.IsOpenToAllStu) == true)
{
if (objvcc_CourseChapter4ExamLibCond.IsOpenToAllStu == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4ExamLib.IsOpenToAllStu);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4ExamLib.IsOpenToAllStu);
}
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.IsOpenToSchool) == true)
{
if (objvcc_CourseChapter4ExamLibCond.IsOpenToSchool == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4ExamLib.IsOpenToSchool);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4ExamLib.IsOpenToSchool);
}
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.IsOpenToSocial) == true)
{
if (objvcc_CourseChapter4ExamLibCond.IsOpenToSocial == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4ExamLib.IsOpenToSocial);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4ExamLib.IsOpenToSocial);
}
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.IsMustMenu) == true)
{
if (objvcc_CourseChapter4ExamLibCond.IsMustMenu == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4ExamLib.IsMustMenu);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4ExamLib.IsMustMenu);
}
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.ThemeName) == true)
{
string strComparisonOpThemeName = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ThemeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.ThemeName, objvcc_CourseChapter4ExamLibCond.ThemeName, strComparisonOpThemeName);
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.IsFile) == true)
{
if (objvcc_CourseChapter4ExamLibCond.IsFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4ExamLib.IsFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4ExamLib.IsFile);
}
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.IsUse) == true)
{
if (objvcc_CourseChapter4ExamLibCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4ExamLib.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4ExamLib.IsUse);
}
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.ViewCount) == true)
{
string strComparisonOpViewCount = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseChapter4ExamLib.ViewCount, objvcc_CourseChapter4ExamLibCond.ViewCount, strComparisonOpViewCount);
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.CourseChapterReferred) == true)
{
string strComparisonOpCourseChapterReferred = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.CourseChapterReferred, objvcc_CourseChapter4ExamLibCond.CourseChapterReferred, strComparisonOpCourseChapterReferred);
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.OrderNum) == true)
{
string strComparisonOpOrderNum = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseChapter4ExamLib.OrderNum, objvcc_CourseChapter4ExamLibCond.OrderNum, strComparisonOpOrderNum);
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.CreateDate) == true)
{
string strComparisonOpCreateDate = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.CreateDate, objvcc_CourseChapter4ExamLibCond.CreateDate, strComparisonOpCreateDate);
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.EditPeople) == true)
{
string strComparisonOpEditPeople = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.EditPeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.EditPeople, objvcc_CourseChapter4ExamLibCond.EditPeople, strComparisonOpEditPeople);
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.UpdDate, objvcc_CourseChapter4ExamLibCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.Memo) == true)
{
string strComparisonOpMemo = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.Memo, objvcc_CourseChapter4ExamLibCond.Memo, strComparisonOpMemo);
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.ParentNodeName) == true)
{
string strComparisonOpParentNodeName = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.ParentNodeName, objvcc_CourseChapter4ExamLibCond.ParentNodeName, strComparisonOpParentNodeName);
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.ParentNodeReferred) == true)
{
string strComparisonOpParentNodeReferred = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.ParentNodeReferred, objvcc_CourseChapter4ExamLibCond.ParentNodeReferred, strComparisonOpParentNodeReferred);
}
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(convcc_CourseChapter4ExamLib.QuesionnaireNum) == true)
{
string strComparisonOpQuesionnaireNum = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.QuesionnaireNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseChapter4ExamLib.QuesionnaireNum, objvcc_CourseChapter4ExamLibCond.QuesionnaireNum, strComparisonOpQuesionnaireNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_CourseChapter4ExamLib
{
public virtual bool UpdRelaTabDate(string strCourseChapterId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v课程章节表4题库(vcc_CourseChapter4ExamLib)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseChapter4ExamLibBL
{
public static RelatedActions_vcc_CourseChapter4ExamLib relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_CourseChapter4ExamLibDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_CourseChapter4ExamLibDA vcc_CourseChapter4ExamLibDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_CourseChapter4ExamLibDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_CourseChapter4ExamLibBL()
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
if (string.IsNullOrEmpty(clsvcc_CourseChapter4ExamLibEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_CourseChapter4ExamLibEN._ConnectString);
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
public static DataTable GetDataTable_vcc_CourseChapter4ExamLib(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_CourseChapter4ExamLibDA.GetDataTable_vcc_CourseChapter4ExamLib(strWhereCond);
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
objDT = vcc_CourseChapter4ExamLibDA.GetDataTable(strWhereCond);
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
objDT = vcc_CourseChapter4ExamLibDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_CourseChapter4ExamLibDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_CourseChapter4ExamLibDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_CourseChapter4ExamLibDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_CourseChapter4ExamLibDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_CourseChapter4ExamLibDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_CourseChapter4ExamLibDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvcc_CourseChapter4ExamLibEN> GetObjLstByCourseChapterIdLst(List<string> arrCourseChapterIdLst)
{
List<clsvcc_CourseChapter4ExamLibEN> arrObjLst = new List<clsvcc_CourseChapter4ExamLibEN>(); 
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
	clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = new clsvcc_CourseChapter4ExamLibEN();
try
{
objvcc_CourseChapter4ExamLibEN.CourseChapterId = objRow[convcc_CourseChapter4ExamLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4ExamLibEN.CourseChapterName = objRow[convcc_CourseChapter4ExamLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4ExamLibEN.ChapterId = objRow[convcc_CourseChapter4ExamLib.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4ExamLibEN.SectionId = objRow[convcc_CourseChapter4ExamLib.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4ExamLibEN.ChapterName = objRow[convcc_CourseChapter4ExamLib.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4ExamLibEN.SectionName = objRow[convcc_CourseChapter4ExamLib.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4ExamLibEN.ChapterNameSim = objRow[convcc_CourseChapter4ExamLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4ExamLibEN.SectionNameSim = objRow[convcc_CourseChapter4ExamLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4ExamLibEN.ChapterContent = objRow[convcc_CourseChapter4ExamLib.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4ExamLibEN.CourseId = objRow[convcc_CourseChapter4ExamLib.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4ExamLibEN.CourseCode = objRow[convcc_CourseChapter4ExamLib.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4ExamLibEN.CourseName = objRow[convcc_CourseChapter4ExamLib.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4ExamLibEN.ThemeId = objRow[convcc_CourseChapter4ExamLib.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4ExamLibEN.ParentNodeId = objRow[convcc_CourseChapter4ExamLib.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4ExamLibEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4ExamLibEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4ExamLibEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4ExamLibEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4ExamLibEN.ThemeName = objRow[convcc_CourseChapter4ExamLib.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4ExamLibEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4ExamLibEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4ExamLibEN.ViewCount = objRow[convcc_CourseChapter4ExamLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4ExamLibEN.CourseChapterReferred = objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4ExamLibEN.OrderNum = objRow[convcc_CourseChapter4ExamLib.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4ExamLibEN.CreateDate = objRow[convcc_CourseChapter4ExamLib.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4ExamLibEN.EditPeople = objRow[convcc_CourseChapter4ExamLib.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4ExamLibEN.UpdDate = objRow[convcc_CourseChapter4ExamLib.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4ExamLibEN.Memo = objRow[convcc_CourseChapter4ExamLib.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4ExamLibEN.ParentNodeName = objRow[convcc_CourseChapter4ExamLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4ExamLibEN.ParentNodeReferred = objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4ExamLibEN.QuesionnaireNum = objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum].ToString().Trim()); //习题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapter4ExamLibEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapter4ExamLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCourseChapterIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_CourseChapter4ExamLibEN> GetObjLstByCourseChapterIdLstCache(List<string> arrCourseChapterIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapter4ExamLibEN._CurrTabName, strCourseId);
List<clsvcc_CourseChapter4ExamLibEN> arrvcc_CourseChapter4ExamLibObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseChapter4ExamLibEN> arrvcc_CourseChapter4ExamLibObjLst_Sel =
arrvcc_CourseChapter4ExamLibObjLstCache
.Where(x => arrCourseChapterIdLst.Contains(x.CourseChapterId));
return arrvcc_CourseChapter4ExamLibObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseChapter4ExamLibEN> GetObjLst(string strWhereCond)
{
List<clsvcc_CourseChapter4ExamLibEN> arrObjLst = new List<clsvcc_CourseChapter4ExamLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = new clsvcc_CourseChapter4ExamLibEN();
try
{
objvcc_CourseChapter4ExamLibEN.CourseChapterId = objRow[convcc_CourseChapter4ExamLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4ExamLibEN.CourseChapterName = objRow[convcc_CourseChapter4ExamLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4ExamLibEN.ChapterId = objRow[convcc_CourseChapter4ExamLib.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4ExamLibEN.SectionId = objRow[convcc_CourseChapter4ExamLib.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4ExamLibEN.ChapterName = objRow[convcc_CourseChapter4ExamLib.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4ExamLibEN.SectionName = objRow[convcc_CourseChapter4ExamLib.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4ExamLibEN.ChapterNameSim = objRow[convcc_CourseChapter4ExamLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4ExamLibEN.SectionNameSim = objRow[convcc_CourseChapter4ExamLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4ExamLibEN.ChapterContent = objRow[convcc_CourseChapter4ExamLib.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4ExamLibEN.CourseId = objRow[convcc_CourseChapter4ExamLib.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4ExamLibEN.CourseCode = objRow[convcc_CourseChapter4ExamLib.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4ExamLibEN.CourseName = objRow[convcc_CourseChapter4ExamLib.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4ExamLibEN.ThemeId = objRow[convcc_CourseChapter4ExamLib.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4ExamLibEN.ParentNodeId = objRow[convcc_CourseChapter4ExamLib.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4ExamLibEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4ExamLibEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4ExamLibEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4ExamLibEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4ExamLibEN.ThemeName = objRow[convcc_CourseChapter4ExamLib.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4ExamLibEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4ExamLibEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4ExamLibEN.ViewCount = objRow[convcc_CourseChapter4ExamLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4ExamLibEN.CourseChapterReferred = objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4ExamLibEN.OrderNum = objRow[convcc_CourseChapter4ExamLib.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4ExamLibEN.CreateDate = objRow[convcc_CourseChapter4ExamLib.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4ExamLibEN.EditPeople = objRow[convcc_CourseChapter4ExamLib.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4ExamLibEN.UpdDate = objRow[convcc_CourseChapter4ExamLib.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4ExamLibEN.Memo = objRow[convcc_CourseChapter4ExamLib.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4ExamLibEN.ParentNodeName = objRow[convcc_CourseChapter4ExamLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4ExamLibEN.ParentNodeReferred = objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4ExamLibEN.QuesionnaireNum = objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum].ToString().Trim()); //习题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapter4ExamLibEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapter4ExamLibEN);
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
public static List<clsvcc_CourseChapter4ExamLibEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseChapter4ExamLibEN> arrObjLst = new List<clsvcc_CourseChapter4ExamLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = new clsvcc_CourseChapter4ExamLibEN();
try
{
objvcc_CourseChapter4ExamLibEN.CourseChapterId = objRow[convcc_CourseChapter4ExamLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4ExamLibEN.CourseChapterName = objRow[convcc_CourseChapter4ExamLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4ExamLibEN.ChapterId = objRow[convcc_CourseChapter4ExamLib.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4ExamLibEN.SectionId = objRow[convcc_CourseChapter4ExamLib.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4ExamLibEN.ChapterName = objRow[convcc_CourseChapter4ExamLib.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4ExamLibEN.SectionName = objRow[convcc_CourseChapter4ExamLib.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4ExamLibEN.ChapterNameSim = objRow[convcc_CourseChapter4ExamLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4ExamLibEN.SectionNameSim = objRow[convcc_CourseChapter4ExamLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4ExamLibEN.ChapterContent = objRow[convcc_CourseChapter4ExamLib.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4ExamLibEN.CourseId = objRow[convcc_CourseChapter4ExamLib.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4ExamLibEN.CourseCode = objRow[convcc_CourseChapter4ExamLib.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4ExamLibEN.CourseName = objRow[convcc_CourseChapter4ExamLib.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4ExamLibEN.ThemeId = objRow[convcc_CourseChapter4ExamLib.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4ExamLibEN.ParentNodeId = objRow[convcc_CourseChapter4ExamLib.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4ExamLibEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4ExamLibEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4ExamLibEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4ExamLibEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4ExamLibEN.ThemeName = objRow[convcc_CourseChapter4ExamLib.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4ExamLibEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4ExamLibEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4ExamLibEN.ViewCount = objRow[convcc_CourseChapter4ExamLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4ExamLibEN.CourseChapterReferred = objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4ExamLibEN.OrderNum = objRow[convcc_CourseChapter4ExamLib.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4ExamLibEN.CreateDate = objRow[convcc_CourseChapter4ExamLib.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4ExamLibEN.EditPeople = objRow[convcc_CourseChapter4ExamLib.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4ExamLibEN.UpdDate = objRow[convcc_CourseChapter4ExamLib.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4ExamLibEN.Memo = objRow[convcc_CourseChapter4ExamLib.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4ExamLibEN.ParentNodeName = objRow[convcc_CourseChapter4ExamLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4ExamLibEN.ParentNodeReferred = objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4ExamLibEN.QuesionnaireNum = objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum].ToString().Trim()); //习题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapter4ExamLibEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapter4ExamLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_CourseChapter4ExamLibEN> GetSubObjLstCache(clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibCond)
{
 string strCourseId = objvcc_CourseChapter4ExamLibCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvcc_CourseChapter4ExamLibBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvcc_CourseChapter4ExamLibEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseChapter4ExamLibEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseChapter4ExamLib.AttributeName)
{
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseChapter4ExamLibCond[strFldName].ToString());
}
else
{
if (objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseChapter4ExamLibCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseChapter4ExamLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseChapter4ExamLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseChapter4ExamLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseChapter4ExamLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseChapter4ExamLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseChapter4ExamLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseChapter4ExamLibCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseChapter4ExamLibCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseChapter4ExamLibCond[strFldName]));
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
public static List<clsvcc_CourseChapter4ExamLibEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_CourseChapter4ExamLibEN> arrObjLst = new List<clsvcc_CourseChapter4ExamLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = new clsvcc_CourseChapter4ExamLibEN();
try
{
objvcc_CourseChapter4ExamLibEN.CourseChapterId = objRow[convcc_CourseChapter4ExamLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4ExamLibEN.CourseChapterName = objRow[convcc_CourseChapter4ExamLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4ExamLibEN.ChapterId = objRow[convcc_CourseChapter4ExamLib.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4ExamLibEN.SectionId = objRow[convcc_CourseChapter4ExamLib.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4ExamLibEN.ChapterName = objRow[convcc_CourseChapter4ExamLib.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4ExamLibEN.SectionName = objRow[convcc_CourseChapter4ExamLib.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4ExamLibEN.ChapterNameSim = objRow[convcc_CourseChapter4ExamLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4ExamLibEN.SectionNameSim = objRow[convcc_CourseChapter4ExamLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4ExamLibEN.ChapterContent = objRow[convcc_CourseChapter4ExamLib.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4ExamLibEN.CourseId = objRow[convcc_CourseChapter4ExamLib.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4ExamLibEN.CourseCode = objRow[convcc_CourseChapter4ExamLib.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4ExamLibEN.CourseName = objRow[convcc_CourseChapter4ExamLib.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4ExamLibEN.ThemeId = objRow[convcc_CourseChapter4ExamLib.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4ExamLibEN.ParentNodeId = objRow[convcc_CourseChapter4ExamLib.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4ExamLibEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4ExamLibEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4ExamLibEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4ExamLibEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4ExamLibEN.ThemeName = objRow[convcc_CourseChapter4ExamLib.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4ExamLibEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4ExamLibEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4ExamLibEN.ViewCount = objRow[convcc_CourseChapter4ExamLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4ExamLibEN.CourseChapterReferred = objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4ExamLibEN.OrderNum = objRow[convcc_CourseChapter4ExamLib.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4ExamLibEN.CreateDate = objRow[convcc_CourseChapter4ExamLib.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4ExamLibEN.EditPeople = objRow[convcc_CourseChapter4ExamLib.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4ExamLibEN.UpdDate = objRow[convcc_CourseChapter4ExamLib.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4ExamLibEN.Memo = objRow[convcc_CourseChapter4ExamLib.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4ExamLibEN.ParentNodeName = objRow[convcc_CourseChapter4ExamLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4ExamLibEN.ParentNodeReferred = objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4ExamLibEN.QuesionnaireNum = objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum].ToString().Trim()); //习题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapter4ExamLibEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapter4ExamLibEN);
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
public static List<clsvcc_CourseChapter4ExamLibEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_CourseChapter4ExamLibEN> arrObjLst = new List<clsvcc_CourseChapter4ExamLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = new clsvcc_CourseChapter4ExamLibEN();
try
{
objvcc_CourseChapter4ExamLibEN.CourseChapterId = objRow[convcc_CourseChapter4ExamLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4ExamLibEN.CourseChapterName = objRow[convcc_CourseChapter4ExamLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4ExamLibEN.ChapterId = objRow[convcc_CourseChapter4ExamLib.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4ExamLibEN.SectionId = objRow[convcc_CourseChapter4ExamLib.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4ExamLibEN.ChapterName = objRow[convcc_CourseChapter4ExamLib.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4ExamLibEN.SectionName = objRow[convcc_CourseChapter4ExamLib.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4ExamLibEN.ChapterNameSim = objRow[convcc_CourseChapter4ExamLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4ExamLibEN.SectionNameSim = objRow[convcc_CourseChapter4ExamLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4ExamLibEN.ChapterContent = objRow[convcc_CourseChapter4ExamLib.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4ExamLibEN.CourseId = objRow[convcc_CourseChapter4ExamLib.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4ExamLibEN.CourseCode = objRow[convcc_CourseChapter4ExamLib.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4ExamLibEN.CourseName = objRow[convcc_CourseChapter4ExamLib.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4ExamLibEN.ThemeId = objRow[convcc_CourseChapter4ExamLib.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4ExamLibEN.ParentNodeId = objRow[convcc_CourseChapter4ExamLib.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4ExamLibEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4ExamLibEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4ExamLibEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4ExamLibEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4ExamLibEN.ThemeName = objRow[convcc_CourseChapter4ExamLib.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4ExamLibEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4ExamLibEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4ExamLibEN.ViewCount = objRow[convcc_CourseChapter4ExamLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4ExamLibEN.CourseChapterReferred = objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4ExamLibEN.OrderNum = objRow[convcc_CourseChapter4ExamLib.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4ExamLibEN.CreateDate = objRow[convcc_CourseChapter4ExamLib.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4ExamLibEN.EditPeople = objRow[convcc_CourseChapter4ExamLib.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4ExamLibEN.UpdDate = objRow[convcc_CourseChapter4ExamLib.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4ExamLibEN.Memo = objRow[convcc_CourseChapter4ExamLib.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4ExamLibEN.ParentNodeName = objRow[convcc_CourseChapter4ExamLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4ExamLibEN.ParentNodeReferred = objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4ExamLibEN.QuesionnaireNum = objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum].ToString().Trim()); //习题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapter4ExamLibEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapter4ExamLibEN);
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
List<clsvcc_CourseChapter4ExamLibEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_CourseChapter4ExamLibEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseChapter4ExamLibEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_CourseChapter4ExamLibEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseChapter4ExamLibEN> arrObjLst = new List<clsvcc_CourseChapter4ExamLibEN>(); 
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
	clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = new clsvcc_CourseChapter4ExamLibEN();
try
{
objvcc_CourseChapter4ExamLibEN.CourseChapterId = objRow[convcc_CourseChapter4ExamLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4ExamLibEN.CourseChapterName = objRow[convcc_CourseChapter4ExamLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4ExamLibEN.ChapterId = objRow[convcc_CourseChapter4ExamLib.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4ExamLibEN.SectionId = objRow[convcc_CourseChapter4ExamLib.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4ExamLibEN.ChapterName = objRow[convcc_CourseChapter4ExamLib.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4ExamLibEN.SectionName = objRow[convcc_CourseChapter4ExamLib.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4ExamLibEN.ChapterNameSim = objRow[convcc_CourseChapter4ExamLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4ExamLibEN.SectionNameSim = objRow[convcc_CourseChapter4ExamLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4ExamLibEN.ChapterContent = objRow[convcc_CourseChapter4ExamLib.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4ExamLibEN.CourseId = objRow[convcc_CourseChapter4ExamLib.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4ExamLibEN.CourseCode = objRow[convcc_CourseChapter4ExamLib.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4ExamLibEN.CourseName = objRow[convcc_CourseChapter4ExamLib.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4ExamLibEN.ThemeId = objRow[convcc_CourseChapter4ExamLib.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4ExamLibEN.ParentNodeId = objRow[convcc_CourseChapter4ExamLib.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4ExamLibEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4ExamLibEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4ExamLibEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4ExamLibEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4ExamLibEN.ThemeName = objRow[convcc_CourseChapter4ExamLib.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4ExamLibEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4ExamLibEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4ExamLibEN.ViewCount = objRow[convcc_CourseChapter4ExamLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4ExamLibEN.CourseChapterReferred = objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4ExamLibEN.OrderNum = objRow[convcc_CourseChapter4ExamLib.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4ExamLibEN.CreateDate = objRow[convcc_CourseChapter4ExamLib.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4ExamLibEN.EditPeople = objRow[convcc_CourseChapter4ExamLib.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4ExamLibEN.UpdDate = objRow[convcc_CourseChapter4ExamLib.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4ExamLibEN.Memo = objRow[convcc_CourseChapter4ExamLib.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4ExamLibEN.ParentNodeName = objRow[convcc_CourseChapter4ExamLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4ExamLibEN.ParentNodeReferred = objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4ExamLibEN.QuesionnaireNum = objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum].ToString().Trim()); //习题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapter4ExamLibEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapter4ExamLibEN);
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
public static List<clsvcc_CourseChapter4ExamLibEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseChapter4ExamLibEN> arrObjLst = new List<clsvcc_CourseChapter4ExamLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = new clsvcc_CourseChapter4ExamLibEN();
try
{
objvcc_CourseChapter4ExamLibEN.CourseChapterId = objRow[convcc_CourseChapter4ExamLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4ExamLibEN.CourseChapterName = objRow[convcc_CourseChapter4ExamLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4ExamLibEN.ChapterId = objRow[convcc_CourseChapter4ExamLib.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4ExamLibEN.SectionId = objRow[convcc_CourseChapter4ExamLib.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4ExamLibEN.ChapterName = objRow[convcc_CourseChapter4ExamLib.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4ExamLibEN.SectionName = objRow[convcc_CourseChapter4ExamLib.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4ExamLibEN.ChapterNameSim = objRow[convcc_CourseChapter4ExamLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4ExamLibEN.SectionNameSim = objRow[convcc_CourseChapter4ExamLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4ExamLibEN.ChapterContent = objRow[convcc_CourseChapter4ExamLib.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4ExamLibEN.CourseId = objRow[convcc_CourseChapter4ExamLib.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4ExamLibEN.CourseCode = objRow[convcc_CourseChapter4ExamLib.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4ExamLibEN.CourseName = objRow[convcc_CourseChapter4ExamLib.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4ExamLibEN.ThemeId = objRow[convcc_CourseChapter4ExamLib.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4ExamLibEN.ParentNodeId = objRow[convcc_CourseChapter4ExamLib.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4ExamLibEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4ExamLibEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4ExamLibEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4ExamLibEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4ExamLibEN.ThemeName = objRow[convcc_CourseChapter4ExamLib.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4ExamLibEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4ExamLibEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4ExamLibEN.ViewCount = objRow[convcc_CourseChapter4ExamLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4ExamLibEN.CourseChapterReferred = objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4ExamLibEN.OrderNum = objRow[convcc_CourseChapter4ExamLib.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4ExamLibEN.CreateDate = objRow[convcc_CourseChapter4ExamLib.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4ExamLibEN.EditPeople = objRow[convcc_CourseChapter4ExamLib.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4ExamLibEN.UpdDate = objRow[convcc_CourseChapter4ExamLib.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4ExamLibEN.Memo = objRow[convcc_CourseChapter4ExamLib.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4ExamLibEN.ParentNodeName = objRow[convcc_CourseChapter4ExamLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4ExamLibEN.ParentNodeReferred = objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4ExamLibEN.QuesionnaireNum = objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum].ToString().Trim()); //习题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapter4ExamLibEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapter4ExamLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_CourseChapter4ExamLibEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_CourseChapter4ExamLibEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseChapter4ExamLibEN> arrObjLst = new List<clsvcc_CourseChapter4ExamLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = new clsvcc_CourseChapter4ExamLibEN();
try
{
objvcc_CourseChapter4ExamLibEN.CourseChapterId = objRow[convcc_CourseChapter4ExamLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4ExamLibEN.CourseChapterName = objRow[convcc_CourseChapter4ExamLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4ExamLibEN.ChapterId = objRow[convcc_CourseChapter4ExamLib.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4ExamLibEN.SectionId = objRow[convcc_CourseChapter4ExamLib.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4ExamLibEN.ChapterName = objRow[convcc_CourseChapter4ExamLib.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4ExamLibEN.SectionName = objRow[convcc_CourseChapter4ExamLib.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4ExamLibEN.ChapterNameSim = objRow[convcc_CourseChapter4ExamLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4ExamLibEN.SectionNameSim = objRow[convcc_CourseChapter4ExamLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4ExamLibEN.ChapterContent = objRow[convcc_CourseChapter4ExamLib.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4ExamLibEN.CourseId = objRow[convcc_CourseChapter4ExamLib.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4ExamLibEN.CourseCode = objRow[convcc_CourseChapter4ExamLib.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4ExamLibEN.CourseName = objRow[convcc_CourseChapter4ExamLib.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4ExamLibEN.ThemeId = objRow[convcc_CourseChapter4ExamLib.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4ExamLibEN.ParentNodeId = objRow[convcc_CourseChapter4ExamLib.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4ExamLibEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4ExamLibEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4ExamLibEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4ExamLibEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4ExamLibEN.ThemeName = objRow[convcc_CourseChapter4ExamLib.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4ExamLibEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4ExamLibEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4ExamLibEN.ViewCount = objRow[convcc_CourseChapter4ExamLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4ExamLibEN.CourseChapterReferred = objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4ExamLibEN.OrderNum = objRow[convcc_CourseChapter4ExamLib.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4ExamLibEN.CreateDate = objRow[convcc_CourseChapter4ExamLib.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4ExamLibEN.EditPeople = objRow[convcc_CourseChapter4ExamLib.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4ExamLibEN.UpdDate = objRow[convcc_CourseChapter4ExamLib.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4ExamLibEN.Memo = objRow[convcc_CourseChapter4ExamLib.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4ExamLibEN.ParentNodeName = objRow[convcc_CourseChapter4ExamLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4ExamLibEN.ParentNodeReferred = objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4ExamLibEN.QuesionnaireNum = objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum].ToString().Trim()); //习题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapter4ExamLibEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapter4ExamLibEN);
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
public static List<clsvcc_CourseChapter4ExamLibEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_CourseChapter4ExamLibEN> arrObjLst = new List<clsvcc_CourseChapter4ExamLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = new clsvcc_CourseChapter4ExamLibEN();
try
{
objvcc_CourseChapter4ExamLibEN.CourseChapterId = objRow[convcc_CourseChapter4ExamLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4ExamLibEN.CourseChapterName = objRow[convcc_CourseChapter4ExamLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4ExamLibEN.ChapterId = objRow[convcc_CourseChapter4ExamLib.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4ExamLibEN.SectionId = objRow[convcc_CourseChapter4ExamLib.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4ExamLibEN.ChapterName = objRow[convcc_CourseChapter4ExamLib.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4ExamLibEN.SectionName = objRow[convcc_CourseChapter4ExamLib.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4ExamLibEN.ChapterNameSim = objRow[convcc_CourseChapter4ExamLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4ExamLibEN.SectionNameSim = objRow[convcc_CourseChapter4ExamLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4ExamLibEN.ChapterContent = objRow[convcc_CourseChapter4ExamLib.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4ExamLibEN.CourseId = objRow[convcc_CourseChapter4ExamLib.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4ExamLibEN.CourseCode = objRow[convcc_CourseChapter4ExamLib.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4ExamLibEN.CourseName = objRow[convcc_CourseChapter4ExamLib.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4ExamLibEN.ThemeId = objRow[convcc_CourseChapter4ExamLib.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4ExamLibEN.ParentNodeId = objRow[convcc_CourseChapter4ExamLib.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4ExamLibEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4ExamLibEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4ExamLibEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4ExamLibEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4ExamLibEN.ThemeName = objRow[convcc_CourseChapter4ExamLib.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4ExamLibEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4ExamLibEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4ExamLibEN.ViewCount = objRow[convcc_CourseChapter4ExamLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4ExamLibEN.CourseChapterReferred = objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4ExamLibEN.OrderNum = objRow[convcc_CourseChapter4ExamLib.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4ExamLibEN.CreateDate = objRow[convcc_CourseChapter4ExamLib.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4ExamLibEN.EditPeople = objRow[convcc_CourseChapter4ExamLib.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4ExamLibEN.UpdDate = objRow[convcc_CourseChapter4ExamLib.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4ExamLibEN.Memo = objRow[convcc_CourseChapter4ExamLib.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4ExamLibEN.ParentNodeName = objRow[convcc_CourseChapter4ExamLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4ExamLibEN.ParentNodeReferred = objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4ExamLibEN.QuesionnaireNum = objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum].ToString().Trim()); //习题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapter4ExamLibEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapter4ExamLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseChapter4ExamLibEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_CourseChapter4ExamLibEN> arrObjLst = new List<clsvcc_CourseChapter4ExamLibEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = new clsvcc_CourseChapter4ExamLibEN();
try
{
objvcc_CourseChapter4ExamLibEN.CourseChapterId = objRow[convcc_CourseChapter4ExamLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapter4ExamLibEN.CourseChapterName = objRow[convcc_CourseChapter4ExamLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapter4ExamLibEN.ChapterId = objRow[convcc_CourseChapter4ExamLib.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapter4ExamLibEN.SectionId = objRow[convcc_CourseChapter4ExamLib.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapter4ExamLibEN.ChapterName = objRow[convcc_CourseChapter4ExamLib.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapter4ExamLibEN.SectionName = objRow[convcc_CourseChapter4ExamLib.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionName].ToString().Trim(); //节名
objvcc_CourseChapter4ExamLibEN.ChapterNameSim = objRow[convcc_CourseChapter4ExamLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapter4ExamLibEN.SectionNameSim = objRow[convcc_CourseChapter4ExamLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapter4ExamLibEN.ChapterContent = objRow[convcc_CourseChapter4ExamLib.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapter4ExamLibEN.CourseId = objRow[convcc_CourseChapter4ExamLib.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapter4ExamLibEN.CourseCode = objRow[convcc_CourseChapter4ExamLib.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapter4ExamLibEN.CourseName = objRow[convcc_CourseChapter4ExamLib.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapter4ExamLibEN.ThemeId = objRow[convcc_CourseChapter4ExamLib.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapter4ExamLibEN.ParentNodeId = objRow[convcc_CourseChapter4ExamLib.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapter4ExamLibEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapter4ExamLibEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapter4ExamLibEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapter4ExamLibEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapter4ExamLibEN.ThemeName = objRow[convcc_CourseChapter4ExamLib.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapter4ExamLibEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapter4ExamLibEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter4ExamLib.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapter4ExamLibEN.ViewCount = objRow[convcc_CourseChapter4ExamLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapter4ExamLibEN.CourseChapterReferred = objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapter4ExamLibEN.OrderNum = objRow[convcc_CourseChapter4ExamLib.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapter4ExamLibEN.CreateDate = objRow[convcc_CourseChapter4ExamLib.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapter4ExamLibEN.EditPeople = objRow[convcc_CourseChapter4ExamLib.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapter4ExamLibEN.UpdDate = objRow[convcc_CourseChapter4ExamLib.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapter4ExamLibEN.Memo = objRow[convcc_CourseChapter4ExamLib.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.Memo].ToString().Trim(); //备注
objvcc_CourseChapter4ExamLibEN.ParentNodeName = objRow[convcc_CourseChapter4ExamLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapter4ExamLibEN.ParentNodeReferred = objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter4ExamLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_CourseChapter4ExamLibEN.QuesionnaireNum = objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter4ExamLib.QuesionnaireNum].ToString().Trim()); //习题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapter4ExamLibEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapter4ExamLibEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_CourseChapter4ExamLib(ref clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN)
{
bool bolResult = vcc_CourseChapter4ExamLibDA.Getvcc_CourseChapter4ExamLib(ref objvcc_CourseChapter4ExamLibEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseChapterId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseChapter4ExamLibEN GetObjByCourseChapterId(string strCourseChapterId)
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
clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = vcc_CourseChapter4ExamLibDA.GetObjByCourseChapterId(strCourseChapterId);
return objvcc_CourseChapter4ExamLibEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_CourseChapter4ExamLibEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = vcc_CourseChapter4ExamLibDA.GetFirstObj(strWhereCond);
 return objvcc_CourseChapter4ExamLibEN;
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
public static clsvcc_CourseChapter4ExamLibEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = vcc_CourseChapter4ExamLibDA.GetObjByDataRow(objRow);
 return objvcc_CourseChapter4ExamLibEN;
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
public static clsvcc_CourseChapter4ExamLibEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = vcc_CourseChapter4ExamLibDA.GetObjByDataRow(objRow);
 return objvcc_CourseChapter4ExamLibEN;
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
 /// <param name = "lstvcc_CourseChapter4ExamLibObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseChapter4ExamLibEN GetObjByCourseChapterIdFromList(string strCourseChapterId, List<clsvcc_CourseChapter4ExamLibEN> lstvcc_CourseChapter4ExamLibObjLst)
{
foreach (clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN in lstvcc_CourseChapter4ExamLibObjLst)
{
if (objvcc_CourseChapter4ExamLibEN.CourseChapterId == strCourseChapterId)
{
return objvcc_CourseChapter4ExamLibEN;
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
 strCourseChapterId = new clsvcc_CourseChapter4ExamLibDA().GetFirstID(strWhereCond);
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
 arrList = vcc_CourseChapter4ExamLibDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_CourseChapter4ExamLibDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vcc_CourseChapter4ExamLibDA.IsExist(strCourseChapterId);
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
 bolIsExist = clsvcc_CourseChapter4ExamLibDA.IsExistTable();
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
 bolIsExist = vcc_CourseChapter4ExamLibDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_CourseChapter4ExamLibENS">源对象</param>
 /// <param name = "objvcc_CourseChapter4ExamLibENT">目标对象</param>
 public static void CopyTo(clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibENS, clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibENT)
{
try
{
objvcc_CourseChapter4ExamLibENT.CourseChapterId = objvcc_CourseChapter4ExamLibENS.CourseChapterId; //课程章节ID
objvcc_CourseChapter4ExamLibENT.CourseChapterName = objvcc_CourseChapter4ExamLibENS.CourseChapterName; //课程章节名称
objvcc_CourseChapter4ExamLibENT.ChapterId = objvcc_CourseChapter4ExamLibENS.ChapterId; //章Id
objvcc_CourseChapter4ExamLibENT.SectionId = objvcc_CourseChapter4ExamLibENS.SectionId; //节Id
objvcc_CourseChapter4ExamLibENT.ChapterName = objvcc_CourseChapter4ExamLibENS.ChapterName; //章名
objvcc_CourseChapter4ExamLibENT.SectionName = objvcc_CourseChapter4ExamLibENS.SectionName; //节名
objvcc_CourseChapter4ExamLibENT.ChapterNameSim = objvcc_CourseChapter4ExamLibENS.ChapterNameSim; //章名简称
objvcc_CourseChapter4ExamLibENT.SectionNameSim = objvcc_CourseChapter4ExamLibENS.SectionNameSim; //节名简称
objvcc_CourseChapter4ExamLibENT.ChapterContent = objvcc_CourseChapter4ExamLibENS.ChapterContent; //章节内容
objvcc_CourseChapter4ExamLibENT.CourseId = objvcc_CourseChapter4ExamLibENS.CourseId; //课程Id
objvcc_CourseChapter4ExamLibENT.CourseCode = objvcc_CourseChapter4ExamLibENS.CourseCode; //课程代码
objvcc_CourseChapter4ExamLibENT.CourseName = objvcc_CourseChapter4ExamLibENS.CourseName; //课程名称
objvcc_CourseChapter4ExamLibENT.ThemeId = objvcc_CourseChapter4ExamLibENS.ThemeId; //主题Id
objvcc_CourseChapter4ExamLibENT.ParentNodeId = objvcc_CourseChapter4ExamLibENS.ParentNodeId; //父节点编号
objvcc_CourseChapter4ExamLibENT.IsOpenToAllStu = objvcc_CourseChapter4ExamLibENS.IsOpenToAllStu; //全校师生
objvcc_CourseChapter4ExamLibENT.IsOpenToSchool = objvcc_CourseChapter4ExamLibENS.IsOpenToSchool; //全校师生公开
objvcc_CourseChapter4ExamLibENT.IsOpenToSocial = objvcc_CourseChapter4ExamLibENS.IsOpenToSocial; //社会公众
objvcc_CourseChapter4ExamLibENT.IsMustMenu = objvcc_CourseChapter4ExamLibENS.IsMustMenu; //是否必建栏目
objvcc_CourseChapter4ExamLibENT.ThemeName = objvcc_CourseChapter4ExamLibENS.ThemeName; //主题名
objvcc_CourseChapter4ExamLibENT.IsFile = objvcc_CourseChapter4ExamLibENS.IsFile; //项目或文件夹
objvcc_CourseChapter4ExamLibENT.IsUse = objvcc_CourseChapter4ExamLibENS.IsUse; //是否使用
objvcc_CourseChapter4ExamLibENT.ViewCount = objvcc_CourseChapter4ExamLibENS.ViewCount; //浏览量
objvcc_CourseChapter4ExamLibENT.CourseChapterReferred = objvcc_CourseChapter4ExamLibENS.CourseChapterReferred; //节简称
objvcc_CourseChapter4ExamLibENT.OrderNum = objvcc_CourseChapter4ExamLibENS.OrderNum; //序号
objvcc_CourseChapter4ExamLibENT.CreateDate = objvcc_CourseChapter4ExamLibENS.CreateDate; //建立日期
objvcc_CourseChapter4ExamLibENT.EditPeople = objvcc_CourseChapter4ExamLibENS.EditPeople; //修改人
objvcc_CourseChapter4ExamLibENT.UpdDate = objvcc_CourseChapter4ExamLibENS.UpdDate; //修改日期
objvcc_CourseChapter4ExamLibENT.Memo = objvcc_CourseChapter4ExamLibENS.Memo; //备注
objvcc_CourseChapter4ExamLibENT.ParentNodeName = objvcc_CourseChapter4ExamLibENS.ParentNodeName; //父节点名称
objvcc_CourseChapter4ExamLibENT.ParentNodeReferred = objvcc_CourseChapter4ExamLibENS.ParentNodeReferred; //章简称
objvcc_CourseChapter4ExamLibENT.QuesionnaireNum = objvcc_CourseChapter4ExamLibENS.QuesionnaireNum; //习题数
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
 /// <param name = "objvcc_CourseChapter4ExamLibEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN)
{
try
{
objvcc_CourseChapter4ExamLibEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_CourseChapter4ExamLibEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.CourseChapterId = objvcc_CourseChapter4ExamLibEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.CourseChapterName = objvcc_CourseChapter4ExamLibEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.ChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.ChapterId = objvcc_CourseChapter4ExamLibEN.ChapterId == "[null]" ? null :  objvcc_CourseChapter4ExamLibEN.ChapterId; //章Id
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.SectionId = objvcc_CourseChapter4ExamLibEN.SectionId == "[null]" ? null :  objvcc_CourseChapter4ExamLibEN.SectionId; //节Id
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.ChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.ChapterName = objvcc_CourseChapter4ExamLibEN.ChapterName == "[null]" ? null :  objvcc_CourseChapter4ExamLibEN.ChapterName; //章名
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.SectionName = objvcc_CourseChapter4ExamLibEN.SectionName == "[null]" ? null :  objvcc_CourseChapter4ExamLibEN.SectionName; //节名
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.ChapterNameSim = objvcc_CourseChapter4ExamLibEN.ChapterNameSim == "[null]" ? null :  objvcc_CourseChapter4ExamLibEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.SectionNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.SectionNameSim = objvcc_CourseChapter4ExamLibEN.SectionNameSim == "[null]" ? null :  objvcc_CourseChapter4ExamLibEN.SectionNameSim; //节名简称
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.ChapterContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.ChapterContent = objvcc_CourseChapter4ExamLibEN.ChapterContent == "[null]" ? null :  objvcc_CourseChapter4ExamLibEN.ChapterContent; //章节内容
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.CourseId = objvcc_CourseChapter4ExamLibEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.CourseCode = objvcc_CourseChapter4ExamLibEN.CourseCode == "[null]" ? null :  objvcc_CourseChapter4ExamLibEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.CourseName = objvcc_CourseChapter4ExamLibEN.CourseName == "[null]" ? null :  objvcc_CourseChapter4ExamLibEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.ThemeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.ThemeId = objvcc_CourseChapter4ExamLibEN.ThemeId == "[null]" ? null :  objvcc_CourseChapter4ExamLibEN.ThemeId; //主题Id
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.ParentNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.ParentNodeId = objvcc_CourseChapter4ExamLibEN.ParentNodeId; //父节点编号
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.IsOpenToAllStu, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.IsOpenToAllStu = objvcc_CourseChapter4ExamLibEN.IsOpenToAllStu; //全校师生
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.IsOpenToSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.IsOpenToSchool = objvcc_CourseChapter4ExamLibEN.IsOpenToSchool; //全校师生公开
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.IsOpenToSocial, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.IsOpenToSocial = objvcc_CourseChapter4ExamLibEN.IsOpenToSocial; //社会公众
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.IsMustMenu, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.IsMustMenu = objvcc_CourseChapter4ExamLibEN.IsMustMenu; //是否必建栏目
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.ThemeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.ThemeName = objvcc_CourseChapter4ExamLibEN.ThemeName == "[null]" ? null :  objvcc_CourseChapter4ExamLibEN.ThemeName; //主题名
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.IsFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.IsFile = objvcc_CourseChapter4ExamLibEN.IsFile; //项目或文件夹
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.IsUse = objvcc_CourseChapter4ExamLibEN.IsUse; //是否使用
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.ViewCount = objvcc_CourseChapter4ExamLibEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.CourseChapterReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.CourseChapterReferred = objvcc_CourseChapter4ExamLibEN.CourseChapterReferred == "[null]" ? null :  objvcc_CourseChapter4ExamLibEN.CourseChapterReferred; //节简称
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.OrderNum = objvcc_CourseChapter4ExamLibEN.OrderNum; //序号
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.CreateDate = objvcc_CourseChapter4ExamLibEN.CreateDate == "[null]" ? null :  objvcc_CourseChapter4ExamLibEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.EditPeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.EditPeople = objvcc_CourseChapter4ExamLibEN.EditPeople == "[null]" ? null :  objvcc_CourseChapter4ExamLibEN.EditPeople; //修改人
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.UpdDate = objvcc_CourseChapter4ExamLibEN.UpdDate == "[null]" ? null :  objvcc_CourseChapter4ExamLibEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.Memo = objvcc_CourseChapter4ExamLibEN.Memo == "[null]" ? null :  objvcc_CourseChapter4ExamLibEN.Memo; //备注
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.ParentNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.ParentNodeName = objvcc_CourseChapter4ExamLibEN.ParentNodeName == "[null]" ? null :  objvcc_CourseChapter4ExamLibEN.ParentNodeName; //父节点名称
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.ParentNodeReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.ParentNodeReferred = objvcc_CourseChapter4ExamLibEN.ParentNodeReferred == "[null]" ? null :  objvcc_CourseChapter4ExamLibEN.ParentNodeReferred; //章简称
}
if (arrFldSet.Contains(convcc_CourseChapter4ExamLib.QuesionnaireNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapter4ExamLibEN.QuesionnaireNum = objvcc_CourseChapter4ExamLibEN.QuesionnaireNum; //习题数
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
 /// <param name = "objvcc_CourseChapter4ExamLibEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN)
{
try
{
if (objvcc_CourseChapter4ExamLibEN.ChapterId == "[null]") objvcc_CourseChapter4ExamLibEN.ChapterId = null; //章Id
if (objvcc_CourseChapter4ExamLibEN.SectionId == "[null]") objvcc_CourseChapter4ExamLibEN.SectionId = null; //节Id
if (objvcc_CourseChapter4ExamLibEN.ChapterName == "[null]") objvcc_CourseChapter4ExamLibEN.ChapterName = null; //章名
if (objvcc_CourseChapter4ExamLibEN.SectionName == "[null]") objvcc_CourseChapter4ExamLibEN.SectionName = null; //节名
if (objvcc_CourseChapter4ExamLibEN.ChapterNameSim == "[null]") objvcc_CourseChapter4ExamLibEN.ChapterNameSim = null; //章名简称
if (objvcc_CourseChapter4ExamLibEN.SectionNameSim == "[null]") objvcc_CourseChapter4ExamLibEN.SectionNameSim = null; //节名简称
if (objvcc_CourseChapter4ExamLibEN.ChapterContent == "[null]") objvcc_CourseChapter4ExamLibEN.ChapterContent = null; //章节内容
if (objvcc_CourseChapter4ExamLibEN.CourseCode == "[null]") objvcc_CourseChapter4ExamLibEN.CourseCode = null; //课程代码
if (objvcc_CourseChapter4ExamLibEN.CourseName == "[null]") objvcc_CourseChapter4ExamLibEN.CourseName = null; //课程名称
if (objvcc_CourseChapter4ExamLibEN.ThemeId == "[null]") objvcc_CourseChapter4ExamLibEN.ThemeId = null; //主题Id
if (objvcc_CourseChapter4ExamLibEN.ThemeName == "[null]") objvcc_CourseChapter4ExamLibEN.ThemeName = null; //主题名
if (objvcc_CourseChapter4ExamLibEN.CourseChapterReferred == "[null]") objvcc_CourseChapter4ExamLibEN.CourseChapterReferred = null; //节简称
if (objvcc_CourseChapter4ExamLibEN.CreateDate == "[null]") objvcc_CourseChapter4ExamLibEN.CreateDate = null; //建立日期
if (objvcc_CourseChapter4ExamLibEN.EditPeople == "[null]") objvcc_CourseChapter4ExamLibEN.EditPeople = null; //修改人
if (objvcc_CourseChapter4ExamLibEN.UpdDate == "[null]") objvcc_CourseChapter4ExamLibEN.UpdDate = null; //修改日期
if (objvcc_CourseChapter4ExamLibEN.Memo == "[null]") objvcc_CourseChapter4ExamLibEN.Memo = null; //备注
if (objvcc_CourseChapter4ExamLibEN.ParentNodeName == "[null]") objvcc_CourseChapter4ExamLibEN.ParentNodeName = null; //父节点名称
if (objvcc_CourseChapter4ExamLibEN.ParentNodeReferred == "[null]") objvcc_CourseChapter4ExamLibEN.ParentNodeReferred = null; //章简称
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
public static void CheckProperty4Condition(clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN)
{
 vcc_CourseChapter4ExamLibDA.CheckProperty4Condition(objvcc_CourseChapter4ExamLibEN);
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
//if (arrvcc_CourseChapter4ExamLibObjLstCache == null)
//{
//arrvcc_CourseChapter4ExamLibObjLstCache = vcc_CourseChapter4ExamLibDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCourseChapterId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseChapter4ExamLibEN GetObjByCourseChapterIdCache(string strCourseChapterId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapter4ExamLibEN._CurrTabName, strCourseId);
List<clsvcc_CourseChapter4ExamLibEN> arrvcc_CourseChapter4ExamLibObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseChapter4ExamLibEN> arrvcc_CourseChapter4ExamLibObjLst_Sel =
arrvcc_CourseChapter4ExamLibObjLstCache
.Where(x=> x.CourseChapterId == strCourseChapterId 
);
if (arrvcc_CourseChapter4ExamLibObjLst_Sel.Count() == 0)
{
   clsvcc_CourseChapter4ExamLibEN obj = clsvcc_CourseChapter4ExamLibBL.GetObjByCourseChapterId(strCourseChapterId);
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
return arrvcc_CourseChapter4ExamLibObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseChapter4ExamLibEN> GetAllvcc_CourseChapter4ExamLibObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvcc_CourseChapter4ExamLibEN> arrvcc_CourseChapter4ExamLibObjLstCache = GetObjLstCache(strCourseId); 
return arrvcc_CourseChapter4ExamLibObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseChapter4ExamLibEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapter4ExamLibEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvcc_CourseChapter4ExamLibEN> arrvcc_CourseChapter4ExamLibObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvcc_CourseChapter4ExamLibObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapter4ExamLibEN._CurrTabName, strCourseId);
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
if (strInFldName != convcc_CourseChapter4ExamLib.CourseChapterId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_CourseChapter4ExamLib.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_CourseChapter4ExamLib.AttributeName));
throw new Exception(strMsg);
}
var objvcc_CourseChapter4ExamLib = clsvcc_CourseChapter4ExamLibBL.GetObjByCourseChapterIdCache(strCourseChapterId, strCourseId);
if (objvcc_CourseChapter4ExamLib == null) return "";
return objvcc_CourseChapter4ExamLib[strOutFldName].ToString();
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
int intRecCount = clsvcc_CourseChapter4ExamLibDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_CourseChapter4ExamLibDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_CourseChapter4ExamLibDA.GetRecCount();
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
int intRecCount = clsvcc_CourseChapter4ExamLibDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibCond)
{
 string strCourseId = objvcc_CourseChapter4ExamLibCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvcc_CourseChapter4ExamLibBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvcc_CourseChapter4ExamLibEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseChapter4ExamLibEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseChapter4ExamLib.AttributeName)
{
if (objvcc_CourseChapter4ExamLibCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseChapter4ExamLibCond[strFldName].ToString());
}
else
{
if (objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseChapter4ExamLibCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseChapter4ExamLibCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseChapter4ExamLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseChapter4ExamLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseChapter4ExamLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseChapter4ExamLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseChapter4ExamLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseChapter4ExamLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseChapter4ExamLibCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseChapter4ExamLibCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseChapter4ExamLibCond[strFldName]));
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
 List<string> arrList = clsvcc_CourseChapter4ExamLibDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseChapter4ExamLibDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseChapter4ExamLibDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}