
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseChapterBL
 表名:vcc_CourseChapter(01120061)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:03:32
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
public static class  clsvcc_CourseChapterBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseChapterId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseChapterEN GetObj(this K_CourseChapterId_vcc_CourseChapter myKey)
{
clsvcc_CourseChapterEN objvcc_CourseChapterEN = clsvcc_CourseChapterBL.vcc_CourseChapterDA.GetObjByCourseChapterId(myKey.Value);
return objvcc_CourseChapterEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetCourseChapterId(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_CourseChapter.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_CourseChapter.CourseChapterId);
}
objvcc_CourseChapterEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.CourseChapterId) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.CourseChapterId, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.CourseChapterId] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetCourseChapterName(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterName, convcc_CourseChapter.CourseChapterName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_CourseChapter.CourseChapterName);
}
objvcc_CourseChapterEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.CourseChapterName) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.CourseChapterName, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.CourseChapterName] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetChapterId(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterId, 8, convcc_CourseChapter.ChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convcc_CourseChapter.ChapterId);
}
objvcc_CourseChapterEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.ChapterId) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.ChapterId, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.ChapterId] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetSectionId(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, convcc_CourseChapter.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convcc_CourseChapter.SectionId);
}
objvcc_CourseChapterEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.SectionId) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.SectionId, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.SectionId] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetChapterName(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_CourseChapter.ChapterName);
}
objvcc_CourseChapterEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.ChapterName) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.ChapterName, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.ChapterName] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetSectionName(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_CourseChapter.SectionName);
}
objvcc_CourseChapterEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.SectionName) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.SectionName, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.SectionName] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetChapterNameSim(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, convcc_CourseChapter.ChapterNameSim);
}
objvcc_CourseChapterEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.ChapterNameSim) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.ChapterNameSim, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.ChapterNameSim] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetSectionNameSim(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strSectionNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionNameSim, 10, convcc_CourseChapter.SectionNameSim);
}
objvcc_CourseChapterEN.SectionNameSim = strSectionNameSim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.SectionNameSim) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.SectionNameSim, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.SectionNameSim] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetChapterContent(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strChapterContent, string strComparisonOp="")
	{
objvcc_CourseChapterEN.ChapterContent = strChapterContent; //章节内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.ChapterContent) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.ChapterContent, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.ChapterContent] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetCourseId(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_CourseChapter.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_CourseChapter.CourseId);
}
objvcc_CourseChapterEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.CourseId) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.CourseId, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.CourseId] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetCourseCode(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convcc_CourseChapter.CourseCode);
}
objvcc_CourseChapterEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.CourseCode) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.CourseCode, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.CourseCode] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetCourseName(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_CourseChapter.CourseName);
}
objvcc_CourseChapterEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.CourseName) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.CourseName, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.CourseName] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetThemeId(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strThemeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strThemeId, 4, convcc_CourseChapter.ThemeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strThemeId, 4, convcc_CourseChapter.ThemeId);
}
objvcc_CourseChapterEN.ThemeId = strThemeId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.ThemeId) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.ThemeId, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.ThemeId] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetParentNodeId(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strParentNodeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeId, 8, convcc_CourseChapter.ParentNodeId);
}
objvcc_CourseChapterEN.ParentNodeId = strParentNodeId; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.ParentNodeId) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.ParentNodeId, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.ParentNodeId] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetIsOpenToAllStu(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, bool bolIsOpenToAllStu, string strComparisonOp="")
	{
objvcc_CourseChapterEN.IsOpenToAllStu = bolIsOpenToAllStu; //全校师生
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.IsOpenToAllStu) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.IsOpenToAllStu, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.IsOpenToAllStu] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetIsOpenToSchool(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, bool bolIsOpenToSchool, string strComparisonOp="")
	{
objvcc_CourseChapterEN.IsOpenToSchool = bolIsOpenToSchool; //全校师生公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.IsOpenToSchool) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.IsOpenToSchool, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.IsOpenToSchool] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetIsOpenToSocial(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, bool bolIsOpenToSocial, string strComparisonOp="")
	{
objvcc_CourseChapterEN.IsOpenToSocial = bolIsOpenToSocial; //社会公众
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.IsOpenToSocial) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.IsOpenToSocial, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.IsOpenToSocial] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetIsMustMenu(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, bool bolIsMustMenu, string strComparisonOp="")
	{
objvcc_CourseChapterEN.IsMustMenu = bolIsMustMenu; //是否必建栏目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.IsMustMenu) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.IsMustMenu, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.IsMustMenu] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetThemeName(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strThemeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strThemeName, 200, convcc_CourseChapter.ThemeName);
}
objvcc_CourseChapterEN.ThemeName = strThemeName; //主题名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.ThemeName) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.ThemeName, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.ThemeName] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetIsFile(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, bool bolIsFile, string strComparisonOp="")
	{
objvcc_CourseChapterEN.IsFile = bolIsFile; //项目或文件夹
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.IsFile) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.IsFile, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.IsFile] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetIsUse(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, bool bolIsUse, string strComparisonOp="")
	{
objvcc_CourseChapterEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.IsUse) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.IsUse, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.IsUse] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetViewCount(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, int? intViewCount, string strComparisonOp="")
	{
objvcc_CourseChapterEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.ViewCount) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.ViewCount, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.ViewCount] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetCourseChapterReferred(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strCourseChapterReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convcc_CourseChapter.CourseChapterReferred);
}
objvcc_CourseChapterEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.CourseChapterReferred) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.CourseChapterReferred, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.CourseChapterReferred] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetOrderNum(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, int? intOrderNum, string strComparisonOp="")
	{
objvcc_CourseChapterEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.OrderNum) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.OrderNum, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.OrderNum] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetCreateDate(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convcc_CourseChapter.CreateDate);
}
objvcc_CourseChapterEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.CreateDate) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.CreateDate, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.CreateDate] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetEditPeople(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strEditPeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEditPeople, 50, convcc_CourseChapter.EditPeople);
}
objvcc_CourseChapterEN.EditPeople = strEditPeople; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.EditPeople) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.EditPeople, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.EditPeople] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetUpdDate(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_CourseChapter.UpdDate);
}
objvcc_CourseChapterEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.UpdDate) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.UpdDate, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.UpdDate] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetMemo(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_CourseChapter.Memo);
}
objvcc_CourseChapterEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.Memo) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.Memo, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.Memo] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetParentNodeName(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strParentNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeName, 100, convcc_CourseChapter.ParentNodeName);
}
objvcc_CourseChapterEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.ParentNodeName) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.ParentNodeName, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.ParentNodeName] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseChapterEN SetParentNodeReferred(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strParentNodeReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convcc_CourseChapter.ParentNodeReferred);
}
objvcc_CourseChapterEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.ParentNodeReferred) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.ParentNodeReferred, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.ParentNodeReferred] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_CourseChapterENS">源对象</param>
 /// <param name = "objvcc_CourseChapterENT">目标对象</param>
 public static void CopyTo(this clsvcc_CourseChapterEN objvcc_CourseChapterENS, clsvcc_CourseChapterEN objvcc_CourseChapterENT)
{
try
{
objvcc_CourseChapterENT.CourseChapterId = objvcc_CourseChapterENS.CourseChapterId; //课程章节ID
objvcc_CourseChapterENT.CourseChapterName = objvcc_CourseChapterENS.CourseChapterName; //课程章节名称
objvcc_CourseChapterENT.ChapterId = objvcc_CourseChapterENS.ChapterId; //章Id
objvcc_CourseChapterENT.SectionId = objvcc_CourseChapterENS.SectionId; //节Id
objvcc_CourseChapterENT.ChapterName = objvcc_CourseChapterENS.ChapterName; //章名
objvcc_CourseChapterENT.SectionName = objvcc_CourseChapterENS.SectionName; //节名
objvcc_CourseChapterENT.ChapterNameSim = objvcc_CourseChapterENS.ChapterNameSim; //章名简称
objvcc_CourseChapterENT.SectionNameSim = objvcc_CourseChapterENS.SectionNameSim; //节名简称
objvcc_CourseChapterENT.ChapterContent = objvcc_CourseChapterENS.ChapterContent; //章节内容
objvcc_CourseChapterENT.CourseId = objvcc_CourseChapterENS.CourseId; //课程Id
objvcc_CourseChapterENT.CourseCode = objvcc_CourseChapterENS.CourseCode; //课程代码
objvcc_CourseChapterENT.CourseName = objvcc_CourseChapterENS.CourseName; //课程名称
objvcc_CourseChapterENT.ThemeId = objvcc_CourseChapterENS.ThemeId; //主题Id
objvcc_CourseChapterENT.ParentNodeId = objvcc_CourseChapterENS.ParentNodeId; //父节点编号
objvcc_CourseChapterENT.IsOpenToAllStu = objvcc_CourseChapterENS.IsOpenToAllStu; //全校师生
objvcc_CourseChapterENT.IsOpenToSchool = objvcc_CourseChapterENS.IsOpenToSchool; //全校师生公开
objvcc_CourseChapterENT.IsOpenToSocial = objvcc_CourseChapterENS.IsOpenToSocial; //社会公众
objvcc_CourseChapterENT.IsMustMenu = objvcc_CourseChapterENS.IsMustMenu; //是否必建栏目
objvcc_CourseChapterENT.ThemeName = objvcc_CourseChapterENS.ThemeName; //主题名
objvcc_CourseChapterENT.IsFile = objvcc_CourseChapterENS.IsFile; //项目或文件夹
objvcc_CourseChapterENT.IsUse = objvcc_CourseChapterENS.IsUse; //是否使用
objvcc_CourseChapterENT.ViewCount = objvcc_CourseChapterENS.ViewCount; //浏览量
objvcc_CourseChapterENT.CourseChapterReferred = objvcc_CourseChapterENS.CourseChapterReferred; //节简称
objvcc_CourseChapterENT.OrderNum = objvcc_CourseChapterENS.OrderNum; //序号
objvcc_CourseChapterENT.CreateDate = objvcc_CourseChapterENS.CreateDate; //建立日期
objvcc_CourseChapterENT.EditPeople = objvcc_CourseChapterENS.EditPeople; //修改人
objvcc_CourseChapterENT.UpdDate = objvcc_CourseChapterENS.UpdDate; //修改日期
objvcc_CourseChapterENT.Memo = objvcc_CourseChapterENS.Memo; //备注
objvcc_CourseChapterENT.ParentNodeName = objvcc_CourseChapterENS.ParentNodeName; //父节点名称
objvcc_CourseChapterENT.ParentNodeReferred = objvcc_CourseChapterENS.ParentNodeReferred; //章简称
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
 /// <param name = "objvcc_CourseChapterENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseChapterEN:objvcc_CourseChapterENT</returns>
 public static clsvcc_CourseChapterEN CopyTo(this clsvcc_CourseChapterEN objvcc_CourseChapterENS)
{
try
{
 clsvcc_CourseChapterEN objvcc_CourseChapterENT = new clsvcc_CourseChapterEN()
{
CourseChapterId = objvcc_CourseChapterENS.CourseChapterId, //课程章节ID
CourseChapterName = objvcc_CourseChapterENS.CourseChapterName, //课程章节名称
ChapterId = objvcc_CourseChapterENS.ChapterId, //章Id
SectionId = objvcc_CourseChapterENS.SectionId, //节Id
ChapterName = objvcc_CourseChapterENS.ChapterName, //章名
SectionName = objvcc_CourseChapterENS.SectionName, //节名
ChapterNameSim = objvcc_CourseChapterENS.ChapterNameSim, //章名简称
SectionNameSim = objvcc_CourseChapterENS.SectionNameSim, //节名简称
ChapterContent = objvcc_CourseChapterENS.ChapterContent, //章节内容
CourseId = objvcc_CourseChapterENS.CourseId, //课程Id
CourseCode = objvcc_CourseChapterENS.CourseCode, //课程代码
CourseName = objvcc_CourseChapterENS.CourseName, //课程名称
ThemeId = objvcc_CourseChapterENS.ThemeId, //主题Id
ParentNodeId = objvcc_CourseChapterENS.ParentNodeId, //父节点编号
IsOpenToAllStu = objvcc_CourseChapterENS.IsOpenToAllStu, //全校师生
IsOpenToSchool = objvcc_CourseChapterENS.IsOpenToSchool, //全校师生公开
IsOpenToSocial = objvcc_CourseChapterENS.IsOpenToSocial, //社会公众
IsMustMenu = objvcc_CourseChapterENS.IsMustMenu, //是否必建栏目
ThemeName = objvcc_CourseChapterENS.ThemeName, //主题名
IsFile = objvcc_CourseChapterENS.IsFile, //项目或文件夹
IsUse = objvcc_CourseChapterENS.IsUse, //是否使用
ViewCount = objvcc_CourseChapterENS.ViewCount, //浏览量
CourseChapterReferred = objvcc_CourseChapterENS.CourseChapterReferred, //节简称
OrderNum = objvcc_CourseChapterENS.OrderNum, //序号
CreateDate = objvcc_CourseChapterENS.CreateDate, //建立日期
EditPeople = objvcc_CourseChapterENS.EditPeople, //修改人
UpdDate = objvcc_CourseChapterENS.UpdDate, //修改日期
Memo = objvcc_CourseChapterENS.Memo, //备注
ParentNodeName = objvcc_CourseChapterENS.ParentNodeName, //父节点名称
ParentNodeReferred = objvcc_CourseChapterENS.ParentNodeReferred, //章简称
};
 return objvcc_CourseChapterENT;
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
public static void CheckProperty4Condition(this clsvcc_CourseChapterEN objvcc_CourseChapterEN)
{
 clsvcc_CourseChapterBL.vcc_CourseChapterDA.CheckProperty4Condition(objvcc_CourseChapterEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseChapterEN objvcc_CourseChapterCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvcc_CourseChapterCond.dicFldComparisonOp[convcc_CourseChapter.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.CourseChapterId, objvcc_CourseChapterCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvcc_CourseChapterCond.dicFldComparisonOp[convcc_CourseChapter.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.CourseChapterName, objvcc_CourseChapterCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.ChapterId) == true)
{
string strComparisonOpChapterId = objvcc_CourseChapterCond.dicFldComparisonOp[convcc_CourseChapter.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.ChapterId, objvcc_CourseChapterCond.ChapterId, strComparisonOpChapterId);
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.SectionId) == true)
{
string strComparisonOpSectionId = objvcc_CourseChapterCond.dicFldComparisonOp[convcc_CourseChapter.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.SectionId, objvcc_CourseChapterCond.SectionId, strComparisonOpSectionId);
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.ChapterName) == true)
{
string strComparisonOpChapterName = objvcc_CourseChapterCond.dicFldComparisonOp[convcc_CourseChapter.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.ChapterName, objvcc_CourseChapterCond.ChapterName, strComparisonOpChapterName);
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.SectionName) == true)
{
string strComparisonOpSectionName = objvcc_CourseChapterCond.dicFldComparisonOp[convcc_CourseChapter.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.SectionName, objvcc_CourseChapterCond.SectionName, strComparisonOpSectionName);
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objvcc_CourseChapterCond.dicFldComparisonOp[convcc_CourseChapter.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.ChapterNameSim, objvcc_CourseChapterCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.SectionNameSim) == true)
{
string strComparisonOpSectionNameSim = objvcc_CourseChapterCond.dicFldComparisonOp[convcc_CourseChapter.SectionNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.SectionNameSim, objvcc_CourseChapterCond.SectionNameSim, strComparisonOpSectionNameSim);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_CourseChapterCond.dicFldComparisonOp[convcc_CourseChapter.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.CourseId, objvcc_CourseChapterCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.CourseCode) == true)
{
string strComparisonOpCourseCode = objvcc_CourseChapterCond.dicFldComparisonOp[convcc_CourseChapter.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.CourseCode, objvcc_CourseChapterCond.CourseCode, strComparisonOpCourseCode);
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.CourseName) == true)
{
string strComparisonOpCourseName = objvcc_CourseChapterCond.dicFldComparisonOp[convcc_CourseChapter.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.CourseName, objvcc_CourseChapterCond.CourseName, strComparisonOpCourseName);
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.ThemeId) == true)
{
string strComparisonOpThemeId = objvcc_CourseChapterCond.dicFldComparisonOp[convcc_CourseChapter.ThemeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.ThemeId, objvcc_CourseChapterCond.ThemeId, strComparisonOpThemeId);
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.ParentNodeId) == true)
{
string strComparisonOpParentNodeId = objvcc_CourseChapterCond.dicFldComparisonOp[convcc_CourseChapter.ParentNodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.ParentNodeId, objvcc_CourseChapterCond.ParentNodeId, strComparisonOpParentNodeId);
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.IsOpenToAllStu) == true)
{
if (objvcc_CourseChapterCond.IsOpenToAllStu == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter.IsOpenToAllStu);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter.IsOpenToAllStu);
}
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.IsOpenToSchool) == true)
{
if (objvcc_CourseChapterCond.IsOpenToSchool == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter.IsOpenToSchool);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter.IsOpenToSchool);
}
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.IsOpenToSocial) == true)
{
if (objvcc_CourseChapterCond.IsOpenToSocial == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter.IsOpenToSocial);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter.IsOpenToSocial);
}
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.IsMustMenu) == true)
{
if (objvcc_CourseChapterCond.IsMustMenu == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter.IsMustMenu);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter.IsMustMenu);
}
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.ThemeName) == true)
{
string strComparisonOpThemeName = objvcc_CourseChapterCond.dicFldComparisonOp[convcc_CourseChapter.ThemeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.ThemeName, objvcc_CourseChapterCond.ThemeName, strComparisonOpThemeName);
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.IsFile) == true)
{
if (objvcc_CourseChapterCond.IsFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter.IsFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter.IsFile);
}
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.IsUse) == true)
{
if (objvcc_CourseChapterCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter.IsUse);
}
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.ViewCount) == true)
{
string strComparisonOpViewCount = objvcc_CourseChapterCond.dicFldComparisonOp[convcc_CourseChapter.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseChapter.ViewCount, objvcc_CourseChapterCond.ViewCount, strComparisonOpViewCount);
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.CourseChapterReferred) == true)
{
string strComparisonOpCourseChapterReferred = objvcc_CourseChapterCond.dicFldComparisonOp[convcc_CourseChapter.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.CourseChapterReferred, objvcc_CourseChapterCond.CourseChapterReferred, strComparisonOpCourseChapterReferred);
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.OrderNum) == true)
{
string strComparisonOpOrderNum = objvcc_CourseChapterCond.dicFldComparisonOp[convcc_CourseChapter.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseChapter.OrderNum, objvcc_CourseChapterCond.OrderNum, strComparisonOpOrderNum);
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.CreateDate) == true)
{
string strComparisonOpCreateDate = objvcc_CourseChapterCond.dicFldComparisonOp[convcc_CourseChapter.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.CreateDate, objvcc_CourseChapterCond.CreateDate, strComparisonOpCreateDate);
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.EditPeople) == true)
{
string strComparisonOpEditPeople = objvcc_CourseChapterCond.dicFldComparisonOp[convcc_CourseChapter.EditPeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.EditPeople, objvcc_CourseChapterCond.EditPeople, strComparisonOpEditPeople);
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_CourseChapterCond.dicFldComparisonOp[convcc_CourseChapter.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.UpdDate, objvcc_CourseChapterCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.Memo) == true)
{
string strComparisonOpMemo = objvcc_CourseChapterCond.dicFldComparisonOp[convcc_CourseChapter.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.Memo, objvcc_CourseChapterCond.Memo, strComparisonOpMemo);
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.ParentNodeName) == true)
{
string strComparisonOpParentNodeName = objvcc_CourseChapterCond.dicFldComparisonOp[convcc_CourseChapter.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.ParentNodeName, objvcc_CourseChapterCond.ParentNodeName, strComparisonOpParentNodeName);
}
if (objvcc_CourseChapterCond.IsUpdated(convcc_CourseChapter.ParentNodeReferred) == true)
{
string strComparisonOpParentNodeReferred = objvcc_CourseChapterCond.dicFldComparisonOp[convcc_CourseChapter.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.ParentNodeReferred, objvcc_CourseChapterCond.ParentNodeReferred, strComparisonOpParentNodeReferred);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_CourseChapter
{
public virtual bool UpdRelaTabDate(string strCourseChapterId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v课程章节(vcc_CourseChapter)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseChapterBL
{
public static RelatedActions_vcc_CourseChapter relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_CourseChapterDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_CourseChapterDA vcc_CourseChapterDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_CourseChapterDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_CourseChapterBL()
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
if (string.IsNullOrEmpty(clsvcc_CourseChapterEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_CourseChapterEN._ConnectString);
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
public static DataTable GetDataTable_vcc_CourseChapter(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_CourseChapterDA.GetDataTable_vcc_CourseChapter(strWhereCond);
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
objDT = vcc_CourseChapterDA.GetDataTable(strWhereCond);
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
objDT = vcc_CourseChapterDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_CourseChapterDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_CourseChapterDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_CourseChapterDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_CourseChapterDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_CourseChapterDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_CourseChapterDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvcc_CourseChapterEN> GetObjLstByCourseChapterIdLst(List<string> arrCourseChapterIdLst)
{
List<clsvcc_CourseChapterEN> arrObjLst = new List<clsvcc_CourseChapterEN>(); 
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
	clsvcc_CourseChapterEN objvcc_CourseChapterEN = new clsvcc_CourseChapterEN();
try
{
objvcc_CourseChapterEN.CourseChapterId = objRow[convcc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapterEN.CourseChapterName = objRow[convcc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapterEN.ChapterId = objRow[convcc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapterEN.SectionId = objRow[convcc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapterEN.ChapterName = objRow[convcc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapterEN.SectionName = objRow[convcc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionName].ToString().Trim(); //节名
objvcc_CourseChapterEN.ChapterNameSim = objRow[convcc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapterEN.SectionNameSim = objRow[convcc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapterEN.ChapterContent = objRow[convcc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapterEN.CourseId = objRow[convcc_CourseChapter.CourseId] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapterEN.CourseCode = objRow[convcc_CourseChapter.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapterEN.CourseName = objRow[convcc_CourseChapter.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapterEN.ThemeId = objRow[convcc_CourseChapter.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapterEN.ParentNodeId = objRow[convcc_CourseChapter.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapterEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapterEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapterEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapterEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapterEN.ThemeName = objRow[convcc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapterEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapterEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapterEN.ViewCount = objRow[convcc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapterEN.CourseChapterReferred = objRow[convcc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapterEN.OrderNum = objRow[convcc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapterEN.CreateDate = objRow[convcc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapterEN.EditPeople = objRow[convcc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapterEN.UpdDate = objRow[convcc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapterEN.Memo = objRow[convcc_CourseChapter.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter.Memo].ToString().Trim(); //备注
objvcc_CourseChapterEN.ParentNodeName = objRow[convcc_CourseChapter.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapterEN.ParentNodeReferred = objRow[convcc_CourseChapter.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeReferred].ToString().Trim(); //章简称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapterEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapterEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCourseChapterIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_CourseChapterEN> GetObjLstByCourseChapterIdLstCache(List<string> arrCourseChapterIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapterEN._CurrTabName, strCourseId);
List<clsvcc_CourseChapterEN> arrvcc_CourseChapterObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseChapterEN> arrvcc_CourseChapterObjLst_Sel =
arrvcc_CourseChapterObjLstCache
.Where(x => arrCourseChapterIdLst.Contains(x.CourseChapterId));
return arrvcc_CourseChapterObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseChapterEN> GetObjLst(string strWhereCond)
{
List<clsvcc_CourseChapterEN> arrObjLst = new List<clsvcc_CourseChapterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapterEN objvcc_CourseChapterEN = new clsvcc_CourseChapterEN();
try
{
objvcc_CourseChapterEN.CourseChapterId = objRow[convcc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapterEN.CourseChapterName = objRow[convcc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapterEN.ChapterId = objRow[convcc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapterEN.SectionId = objRow[convcc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapterEN.ChapterName = objRow[convcc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapterEN.SectionName = objRow[convcc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionName].ToString().Trim(); //节名
objvcc_CourseChapterEN.ChapterNameSim = objRow[convcc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapterEN.SectionNameSim = objRow[convcc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapterEN.ChapterContent = objRow[convcc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapterEN.CourseId = objRow[convcc_CourseChapter.CourseId] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapterEN.CourseCode = objRow[convcc_CourseChapter.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapterEN.CourseName = objRow[convcc_CourseChapter.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapterEN.ThemeId = objRow[convcc_CourseChapter.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapterEN.ParentNodeId = objRow[convcc_CourseChapter.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapterEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapterEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapterEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapterEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapterEN.ThemeName = objRow[convcc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapterEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapterEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapterEN.ViewCount = objRow[convcc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapterEN.CourseChapterReferred = objRow[convcc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapterEN.OrderNum = objRow[convcc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapterEN.CreateDate = objRow[convcc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapterEN.EditPeople = objRow[convcc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapterEN.UpdDate = objRow[convcc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapterEN.Memo = objRow[convcc_CourseChapter.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter.Memo].ToString().Trim(); //备注
objvcc_CourseChapterEN.ParentNodeName = objRow[convcc_CourseChapter.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapterEN.ParentNodeReferred = objRow[convcc_CourseChapter.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeReferred].ToString().Trim(); //章简称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapterEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapterEN);
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
public static List<clsvcc_CourseChapterEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseChapterEN> arrObjLst = new List<clsvcc_CourseChapterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapterEN objvcc_CourseChapterEN = new clsvcc_CourseChapterEN();
try
{
objvcc_CourseChapterEN.CourseChapterId = objRow[convcc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapterEN.CourseChapterName = objRow[convcc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapterEN.ChapterId = objRow[convcc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapterEN.SectionId = objRow[convcc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapterEN.ChapterName = objRow[convcc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapterEN.SectionName = objRow[convcc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionName].ToString().Trim(); //节名
objvcc_CourseChapterEN.ChapterNameSim = objRow[convcc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapterEN.SectionNameSim = objRow[convcc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapterEN.ChapterContent = objRow[convcc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapterEN.CourseId = objRow[convcc_CourseChapter.CourseId] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapterEN.CourseCode = objRow[convcc_CourseChapter.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapterEN.CourseName = objRow[convcc_CourseChapter.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapterEN.ThemeId = objRow[convcc_CourseChapter.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapterEN.ParentNodeId = objRow[convcc_CourseChapter.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapterEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapterEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapterEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapterEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapterEN.ThemeName = objRow[convcc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapterEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapterEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapterEN.ViewCount = objRow[convcc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapterEN.CourseChapterReferred = objRow[convcc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapterEN.OrderNum = objRow[convcc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapterEN.CreateDate = objRow[convcc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapterEN.EditPeople = objRow[convcc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapterEN.UpdDate = objRow[convcc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapterEN.Memo = objRow[convcc_CourseChapter.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter.Memo].ToString().Trim(); //备注
objvcc_CourseChapterEN.ParentNodeName = objRow[convcc_CourseChapter.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapterEN.ParentNodeReferred = objRow[convcc_CourseChapter.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeReferred].ToString().Trim(); //章简称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapterEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapterEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_CourseChapterCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_CourseChapterEN> GetSubObjLstCache(clsvcc_CourseChapterEN objvcc_CourseChapterCond)
{
 string strCourseId = objvcc_CourseChapterCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvcc_CourseChapterBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvcc_CourseChapterEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseChapterEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseChapter.AttributeName)
{
if (objvcc_CourseChapterCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseChapterCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseChapterCond[strFldName].ToString());
}
else
{
if (objvcc_CourseChapterCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseChapterCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseChapterCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseChapterCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseChapterCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseChapterCond[strFldName]));
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
public static List<clsvcc_CourseChapterEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_CourseChapterEN> arrObjLst = new List<clsvcc_CourseChapterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapterEN objvcc_CourseChapterEN = new clsvcc_CourseChapterEN();
try
{
objvcc_CourseChapterEN.CourseChapterId = objRow[convcc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapterEN.CourseChapterName = objRow[convcc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapterEN.ChapterId = objRow[convcc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapterEN.SectionId = objRow[convcc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapterEN.ChapterName = objRow[convcc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapterEN.SectionName = objRow[convcc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionName].ToString().Trim(); //节名
objvcc_CourseChapterEN.ChapterNameSim = objRow[convcc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapterEN.SectionNameSim = objRow[convcc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapterEN.ChapterContent = objRow[convcc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapterEN.CourseId = objRow[convcc_CourseChapter.CourseId] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapterEN.CourseCode = objRow[convcc_CourseChapter.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapterEN.CourseName = objRow[convcc_CourseChapter.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapterEN.ThemeId = objRow[convcc_CourseChapter.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapterEN.ParentNodeId = objRow[convcc_CourseChapter.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapterEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapterEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapterEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapterEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapterEN.ThemeName = objRow[convcc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapterEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapterEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapterEN.ViewCount = objRow[convcc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapterEN.CourseChapterReferred = objRow[convcc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapterEN.OrderNum = objRow[convcc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapterEN.CreateDate = objRow[convcc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapterEN.EditPeople = objRow[convcc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapterEN.UpdDate = objRow[convcc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapterEN.Memo = objRow[convcc_CourseChapter.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter.Memo].ToString().Trim(); //备注
objvcc_CourseChapterEN.ParentNodeName = objRow[convcc_CourseChapter.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapterEN.ParentNodeReferred = objRow[convcc_CourseChapter.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeReferred].ToString().Trim(); //章简称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapterEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapterEN);
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
public static List<clsvcc_CourseChapterEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_CourseChapterEN> arrObjLst = new List<clsvcc_CourseChapterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapterEN objvcc_CourseChapterEN = new clsvcc_CourseChapterEN();
try
{
objvcc_CourseChapterEN.CourseChapterId = objRow[convcc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapterEN.CourseChapterName = objRow[convcc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapterEN.ChapterId = objRow[convcc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapterEN.SectionId = objRow[convcc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapterEN.ChapterName = objRow[convcc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapterEN.SectionName = objRow[convcc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionName].ToString().Trim(); //节名
objvcc_CourseChapterEN.ChapterNameSim = objRow[convcc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapterEN.SectionNameSim = objRow[convcc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapterEN.ChapterContent = objRow[convcc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapterEN.CourseId = objRow[convcc_CourseChapter.CourseId] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapterEN.CourseCode = objRow[convcc_CourseChapter.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapterEN.CourseName = objRow[convcc_CourseChapter.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapterEN.ThemeId = objRow[convcc_CourseChapter.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapterEN.ParentNodeId = objRow[convcc_CourseChapter.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapterEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapterEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapterEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapterEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapterEN.ThemeName = objRow[convcc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapterEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapterEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapterEN.ViewCount = objRow[convcc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapterEN.CourseChapterReferred = objRow[convcc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapterEN.OrderNum = objRow[convcc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapterEN.CreateDate = objRow[convcc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapterEN.EditPeople = objRow[convcc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapterEN.UpdDate = objRow[convcc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapterEN.Memo = objRow[convcc_CourseChapter.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter.Memo].ToString().Trim(); //备注
objvcc_CourseChapterEN.ParentNodeName = objRow[convcc_CourseChapter.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapterEN.ParentNodeReferred = objRow[convcc_CourseChapter.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeReferred].ToString().Trim(); //章简称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapterEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapterEN);
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
List<clsvcc_CourseChapterEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_CourseChapterEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseChapterEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_CourseChapterEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseChapterEN> arrObjLst = new List<clsvcc_CourseChapterEN>(); 
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
	clsvcc_CourseChapterEN objvcc_CourseChapterEN = new clsvcc_CourseChapterEN();
try
{
objvcc_CourseChapterEN.CourseChapterId = objRow[convcc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapterEN.CourseChapterName = objRow[convcc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapterEN.ChapterId = objRow[convcc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapterEN.SectionId = objRow[convcc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapterEN.ChapterName = objRow[convcc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapterEN.SectionName = objRow[convcc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionName].ToString().Trim(); //节名
objvcc_CourseChapterEN.ChapterNameSim = objRow[convcc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapterEN.SectionNameSim = objRow[convcc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapterEN.ChapterContent = objRow[convcc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapterEN.CourseId = objRow[convcc_CourseChapter.CourseId] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapterEN.CourseCode = objRow[convcc_CourseChapter.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapterEN.CourseName = objRow[convcc_CourseChapter.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapterEN.ThemeId = objRow[convcc_CourseChapter.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapterEN.ParentNodeId = objRow[convcc_CourseChapter.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapterEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapterEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapterEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapterEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapterEN.ThemeName = objRow[convcc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapterEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapterEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapterEN.ViewCount = objRow[convcc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapterEN.CourseChapterReferred = objRow[convcc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapterEN.OrderNum = objRow[convcc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapterEN.CreateDate = objRow[convcc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapterEN.EditPeople = objRow[convcc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapterEN.UpdDate = objRow[convcc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapterEN.Memo = objRow[convcc_CourseChapter.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter.Memo].ToString().Trim(); //备注
objvcc_CourseChapterEN.ParentNodeName = objRow[convcc_CourseChapter.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapterEN.ParentNodeReferred = objRow[convcc_CourseChapter.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeReferred].ToString().Trim(); //章简称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapterEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapterEN);
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
public static List<clsvcc_CourseChapterEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseChapterEN> arrObjLst = new List<clsvcc_CourseChapterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapterEN objvcc_CourseChapterEN = new clsvcc_CourseChapterEN();
try
{
objvcc_CourseChapterEN.CourseChapterId = objRow[convcc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapterEN.CourseChapterName = objRow[convcc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapterEN.ChapterId = objRow[convcc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapterEN.SectionId = objRow[convcc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapterEN.ChapterName = objRow[convcc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapterEN.SectionName = objRow[convcc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionName].ToString().Trim(); //节名
objvcc_CourseChapterEN.ChapterNameSim = objRow[convcc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapterEN.SectionNameSim = objRow[convcc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapterEN.ChapterContent = objRow[convcc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapterEN.CourseId = objRow[convcc_CourseChapter.CourseId] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapterEN.CourseCode = objRow[convcc_CourseChapter.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapterEN.CourseName = objRow[convcc_CourseChapter.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapterEN.ThemeId = objRow[convcc_CourseChapter.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapterEN.ParentNodeId = objRow[convcc_CourseChapter.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapterEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapterEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapterEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapterEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapterEN.ThemeName = objRow[convcc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapterEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapterEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapterEN.ViewCount = objRow[convcc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapterEN.CourseChapterReferred = objRow[convcc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapterEN.OrderNum = objRow[convcc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapterEN.CreateDate = objRow[convcc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapterEN.EditPeople = objRow[convcc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapterEN.UpdDate = objRow[convcc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapterEN.Memo = objRow[convcc_CourseChapter.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter.Memo].ToString().Trim(); //备注
objvcc_CourseChapterEN.ParentNodeName = objRow[convcc_CourseChapter.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapterEN.ParentNodeReferred = objRow[convcc_CourseChapter.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeReferred].ToString().Trim(); //章简称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapterEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapterEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_CourseChapterEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_CourseChapterEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseChapterEN> arrObjLst = new List<clsvcc_CourseChapterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapterEN objvcc_CourseChapterEN = new clsvcc_CourseChapterEN();
try
{
objvcc_CourseChapterEN.CourseChapterId = objRow[convcc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapterEN.CourseChapterName = objRow[convcc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapterEN.ChapterId = objRow[convcc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapterEN.SectionId = objRow[convcc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapterEN.ChapterName = objRow[convcc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapterEN.SectionName = objRow[convcc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionName].ToString().Trim(); //节名
objvcc_CourseChapterEN.ChapterNameSim = objRow[convcc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapterEN.SectionNameSim = objRow[convcc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapterEN.ChapterContent = objRow[convcc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapterEN.CourseId = objRow[convcc_CourseChapter.CourseId] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapterEN.CourseCode = objRow[convcc_CourseChapter.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapterEN.CourseName = objRow[convcc_CourseChapter.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapterEN.ThemeId = objRow[convcc_CourseChapter.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapterEN.ParentNodeId = objRow[convcc_CourseChapter.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapterEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapterEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapterEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapterEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapterEN.ThemeName = objRow[convcc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapterEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapterEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapterEN.ViewCount = objRow[convcc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapterEN.CourseChapterReferred = objRow[convcc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapterEN.OrderNum = objRow[convcc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapterEN.CreateDate = objRow[convcc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapterEN.EditPeople = objRow[convcc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapterEN.UpdDate = objRow[convcc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapterEN.Memo = objRow[convcc_CourseChapter.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter.Memo].ToString().Trim(); //备注
objvcc_CourseChapterEN.ParentNodeName = objRow[convcc_CourseChapter.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapterEN.ParentNodeReferred = objRow[convcc_CourseChapter.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeReferred].ToString().Trim(); //章简称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapterEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapterEN);
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
public static List<clsvcc_CourseChapterEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_CourseChapterEN> arrObjLst = new List<clsvcc_CourseChapterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapterEN objvcc_CourseChapterEN = new clsvcc_CourseChapterEN();
try
{
objvcc_CourseChapterEN.CourseChapterId = objRow[convcc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapterEN.CourseChapterName = objRow[convcc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapterEN.ChapterId = objRow[convcc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapterEN.SectionId = objRow[convcc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapterEN.ChapterName = objRow[convcc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapterEN.SectionName = objRow[convcc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionName].ToString().Trim(); //节名
objvcc_CourseChapterEN.ChapterNameSim = objRow[convcc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapterEN.SectionNameSim = objRow[convcc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapterEN.ChapterContent = objRow[convcc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapterEN.CourseId = objRow[convcc_CourseChapter.CourseId] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapterEN.CourseCode = objRow[convcc_CourseChapter.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapterEN.CourseName = objRow[convcc_CourseChapter.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapterEN.ThemeId = objRow[convcc_CourseChapter.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapterEN.ParentNodeId = objRow[convcc_CourseChapter.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapterEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapterEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapterEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapterEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapterEN.ThemeName = objRow[convcc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapterEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapterEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapterEN.ViewCount = objRow[convcc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapterEN.CourseChapterReferred = objRow[convcc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapterEN.OrderNum = objRow[convcc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapterEN.CreateDate = objRow[convcc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapterEN.EditPeople = objRow[convcc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapterEN.UpdDate = objRow[convcc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapterEN.Memo = objRow[convcc_CourseChapter.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter.Memo].ToString().Trim(); //备注
objvcc_CourseChapterEN.ParentNodeName = objRow[convcc_CourseChapter.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapterEN.ParentNodeReferred = objRow[convcc_CourseChapter.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeReferred].ToString().Trim(); //章简称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapterEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapterEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseChapterEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_CourseChapterEN> arrObjLst = new List<clsvcc_CourseChapterEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseChapterEN objvcc_CourseChapterEN = new clsvcc_CourseChapterEN();
try
{
objvcc_CourseChapterEN.CourseChapterId = objRow[convcc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseChapterEN.CourseChapterName = objRow[convcc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseChapterEN.ChapterId = objRow[convcc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objvcc_CourseChapterEN.SectionId = objRow[convcc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionId].ToString().Trim(); //节Id
objvcc_CourseChapterEN.ChapterName = objRow[convcc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterName].ToString().Trim(); //章名
objvcc_CourseChapterEN.SectionName = objRow[convcc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionName].ToString().Trim(); //节名
objvcc_CourseChapterEN.ChapterNameSim = objRow[convcc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseChapterEN.SectionNameSim = objRow[convcc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseChapterEN.ChapterContent = objRow[convcc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[convcc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objvcc_CourseChapterEN.CourseId = objRow[convcc_CourseChapter.CourseId] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objvcc_CourseChapterEN.CourseCode = objRow[convcc_CourseChapter.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseChapterEN.CourseName = objRow[convcc_CourseChapter.CourseName] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseName].ToString().Trim(); //课程名称
objvcc_CourseChapterEN.ThemeId = objRow[convcc_CourseChapter.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseChapterEN.ParentNodeId = objRow[convcc_CourseChapter.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseChapterEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseChapterEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseChapterEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseChapterEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objvcc_CourseChapterEN.ThemeName = objRow[convcc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objvcc_CourseChapterEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objvcc_CourseChapterEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objvcc_CourseChapterEN.ViewCount = objRow[convcc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseChapterEN.CourseChapterReferred = objRow[convcc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_CourseChapterEN.OrderNum = objRow[convcc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseChapter.OrderNum].ToString().Trim()); //序号
objvcc_CourseChapterEN.CreateDate = objRow[convcc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseChapterEN.EditPeople = objRow[convcc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[convcc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objvcc_CourseChapterEN.UpdDate = objRow[convcc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseChapterEN.Memo = objRow[convcc_CourseChapter.Memo] == DBNull.Value ? null : objRow[convcc_CourseChapter.Memo].ToString().Trim(); //备注
objvcc_CourseChapterEN.ParentNodeName = objRow[convcc_CourseChapter.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseChapterEN.ParentNodeReferred = objRow[convcc_CourseChapter.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_CourseChapter.ParentNodeReferred].ToString().Trim(); //章简称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseChapterEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseChapterEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_CourseChapter(ref clsvcc_CourseChapterEN objvcc_CourseChapterEN)
{
bool bolResult = vcc_CourseChapterDA.Getvcc_CourseChapter(ref objvcc_CourseChapterEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseChapterId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseChapterEN GetObjByCourseChapterId(string strCourseChapterId)
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
clsvcc_CourseChapterEN objvcc_CourseChapterEN = vcc_CourseChapterDA.GetObjByCourseChapterId(strCourseChapterId);
return objvcc_CourseChapterEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_CourseChapterEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_CourseChapterEN objvcc_CourseChapterEN = vcc_CourseChapterDA.GetFirstObj(strWhereCond);
 return objvcc_CourseChapterEN;
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
public static clsvcc_CourseChapterEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_CourseChapterEN objvcc_CourseChapterEN = vcc_CourseChapterDA.GetObjByDataRow(objRow);
 return objvcc_CourseChapterEN;
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
public static clsvcc_CourseChapterEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_CourseChapterEN objvcc_CourseChapterEN = vcc_CourseChapterDA.GetObjByDataRow(objRow);
 return objvcc_CourseChapterEN;
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
 /// <param name = "lstvcc_CourseChapterObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseChapterEN GetObjByCourseChapterIdFromList(string strCourseChapterId, List<clsvcc_CourseChapterEN> lstvcc_CourseChapterObjLst)
{
foreach (clsvcc_CourseChapterEN objvcc_CourseChapterEN in lstvcc_CourseChapterObjLst)
{
if (objvcc_CourseChapterEN.CourseChapterId == strCourseChapterId)
{
return objvcc_CourseChapterEN;
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
 strCourseChapterId = new clsvcc_CourseChapterDA().GetFirstID(strWhereCond);
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
 arrList = vcc_CourseChapterDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_CourseChapterDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vcc_CourseChapterDA.IsExist(strCourseChapterId);
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
 bolIsExist = clsvcc_CourseChapterDA.IsExistTable();
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
 bolIsExist = vcc_CourseChapterDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_CourseChapterENS">源对象</param>
 /// <param name = "objvcc_CourseChapterENT">目标对象</param>
 public static void CopyTo(clsvcc_CourseChapterEN objvcc_CourseChapterENS, clsvcc_CourseChapterEN objvcc_CourseChapterENT)
{
try
{
objvcc_CourseChapterENT.CourseChapterId = objvcc_CourseChapterENS.CourseChapterId; //课程章节ID
objvcc_CourseChapterENT.CourseChapterName = objvcc_CourseChapterENS.CourseChapterName; //课程章节名称
objvcc_CourseChapterENT.ChapterId = objvcc_CourseChapterENS.ChapterId; //章Id
objvcc_CourseChapterENT.SectionId = objvcc_CourseChapterENS.SectionId; //节Id
objvcc_CourseChapterENT.ChapterName = objvcc_CourseChapterENS.ChapterName; //章名
objvcc_CourseChapterENT.SectionName = objvcc_CourseChapterENS.SectionName; //节名
objvcc_CourseChapterENT.ChapterNameSim = objvcc_CourseChapterENS.ChapterNameSim; //章名简称
objvcc_CourseChapterENT.SectionNameSim = objvcc_CourseChapterENS.SectionNameSim; //节名简称
objvcc_CourseChapterENT.ChapterContent = objvcc_CourseChapterENS.ChapterContent; //章节内容
objvcc_CourseChapterENT.CourseId = objvcc_CourseChapterENS.CourseId; //课程Id
objvcc_CourseChapterENT.CourseCode = objvcc_CourseChapterENS.CourseCode; //课程代码
objvcc_CourseChapterENT.CourseName = objvcc_CourseChapterENS.CourseName; //课程名称
objvcc_CourseChapterENT.ThemeId = objvcc_CourseChapterENS.ThemeId; //主题Id
objvcc_CourseChapterENT.ParentNodeId = objvcc_CourseChapterENS.ParentNodeId; //父节点编号
objvcc_CourseChapterENT.IsOpenToAllStu = objvcc_CourseChapterENS.IsOpenToAllStu; //全校师生
objvcc_CourseChapterENT.IsOpenToSchool = objvcc_CourseChapterENS.IsOpenToSchool; //全校师生公开
objvcc_CourseChapterENT.IsOpenToSocial = objvcc_CourseChapterENS.IsOpenToSocial; //社会公众
objvcc_CourseChapterENT.IsMustMenu = objvcc_CourseChapterENS.IsMustMenu; //是否必建栏目
objvcc_CourseChapterENT.ThemeName = objvcc_CourseChapterENS.ThemeName; //主题名
objvcc_CourseChapterENT.IsFile = objvcc_CourseChapterENS.IsFile; //项目或文件夹
objvcc_CourseChapterENT.IsUse = objvcc_CourseChapterENS.IsUse; //是否使用
objvcc_CourseChapterENT.ViewCount = objvcc_CourseChapterENS.ViewCount; //浏览量
objvcc_CourseChapterENT.CourseChapterReferred = objvcc_CourseChapterENS.CourseChapterReferred; //节简称
objvcc_CourseChapterENT.OrderNum = objvcc_CourseChapterENS.OrderNum; //序号
objvcc_CourseChapterENT.CreateDate = objvcc_CourseChapterENS.CreateDate; //建立日期
objvcc_CourseChapterENT.EditPeople = objvcc_CourseChapterENS.EditPeople; //修改人
objvcc_CourseChapterENT.UpdDate = objvcc_CourseChapterENS.UpdDate; //修改日期
objvcc_CourseChapterENT.Memo = objvcc_CourseChapterENS.Memo; //备注
objvcc_CourseChapterENT.ParentNodeName = objvcc_CourseChapterENS.ParentNodeName; //父节点名称
objvcc_CourseChapterENT.ParentNodeReferred = objvcc_CourseChapterENS.ParentNodeReferred; //章简称
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
 /// <param name = "objvcc_CourseChapterEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_CourseChapterEN objvcc_CourseChapterEN)
{
try
{
objvcc_CourseChapterEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_CourseChapterEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_CourseChapter.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.CourseChapterId = objvcc_CourseChapterEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convcc_CourseChapter.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.CourseChapterName = objvcc_CourseChapterEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convcc_CourseChapter.ChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.ChapterId = objvcc_CourseChapterEN.ChapterId == "[null]" ? null :  objvcc_CourseChapterEN.ChapterId; //章Id
}
if (arrFldSet.Contains(convcc_CourseChapter.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.SectionId = objvcc_CourseChapterEN.SectionId == "[null]" ? null :  objvcc_CourseChapterEN.SectionId; //节Id
}
if (arrFldSet.Contains(convcc_CourseChapter.ChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.ChapterName = objvcc_CourseChapterEN.ChapterName == "[null]" ? null :  objvcc_CourseChapterEN.ChapterName; //章名
}
if (arrFldSet.Contains(convcc_CourseChapter.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.SectionName = objvcc_CourseChapterEN.SectionName == "[null]" ? null :  objvcc_CourseChapterEN.SectionName; //节名
}
if (arrFldSet.Contains(convcc_CourseChapter.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.ChapterNameSim = objvcc_CourseChapterEN.ChapterNameSim == "[null]" ? null :  objvcc_CourseChapterEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(convcc_CourseChapter.SectionNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.SectionNameSim = objvcc_CourseChapterEN.SectionNameSim == "[null]" ? null :  objvcc_CourseChapterEN.SectionNameSim; //节名简称
}
if (arrFldSet.Contains(convcc_CourseChapter.ChapterContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.ChapterContent = objvcc_CourseChapterEN.ChapterContent == "[null]" ? null :  objvcc_CourseChapterEN.ChapterContent; //章节内容
}
if (arrFldSet.Contains(convcc_CourseChapter.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.CourseId = objvcc_CourseChapterEN.CourseId == "[null]" ? null :  objvcc_CourseChapterEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_CourseChapter.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.CourseCode = objvcc_CourseChapterEN.CourseCode == "[null]" ? null :  objvcc_CourseChapterEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convcc_CourseChapter.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.CourseName = objvcc_CourseChapterEN.CourseName == "[null]" ? null :  objvcc_CourseChapterEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convcc_CourseChapter.ThemeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.ThemeId = objvcc_CourseChapterEN.ThemeId == "[null]" ? null :  objvcc_CourseChapterEN.ThemeId; //主题Id
}
if (arrFldSet.Contains(convcc_CourseChapter.ParentNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.ParentNodeId = objvcc_CourseChapterEN.ParentNodeId == "[null]" ? null :  objvcc_CourseChapterEN.ParentNodeId; //父节点编号
}
if (arrFldSet.Contains(convcc_CourseChapter.IsOpenToAllStu, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.IsOpenToAllStu = objvcc_CourseChapterEN.IsOpenToAllStu; //全校师生
}
if (arrFldSet.Contains(convcc_CourseChapter.IsOpenToSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.IsOpenToSchool = objvcc_CourseChapterEN.IsOpenToSchool; //全校师生公开
}
if (arrFldSet.Contains(convcc_CourseChapter.IsOpenToSocial, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.IsOpenToSocial = objvcc_CourseChapterEN.IsOpenToSocial; //社会公众
}
if (arrFldSet.Contains(convcc_CourseChapter.IsMustMenu, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.IsMustMenu = objvcc_CourseChapterEN.IsMustMenu; //是否必建栏目
}
if (arrFldSet.Contains(convcc_CourseChapter.ThemeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.ThemeName = objvcc_CourseChapterEN.ThemeName == "[null]" ? null :  objvcc_CourseChapterEN.ThemeName; //主题名
}
if (arrFldSet.Contains(convcc_CourseChapter.IsFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.IsFile = objvcc_CourseChapterEN.IsFile; //项目或文件夹
}
if (arrFldSet.Contains(convcc_CourseChapter.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.IsUse = objvcc_CourseChapterEN.IsUse; //是否使用
}
if (arrFldSet.Contains(convcc_CourseChapter.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.ViewCount = objvcc_CourseChapterEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convcc_CourseChapter.CourseChapterReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.CourseChapterReferred = objvcc_CourseChapterEN.CourseChapterReferred == "[null]" ? null :  objvcc_CourseChapterEN.CourseChapterReferred; //节简称
}
if (arrFldSet.Contains(convcc_CourseChapter.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.OrderNum = objvcc_CourseChapterEN.OrderNum; //序号
}
if (arrFldSet.Contains(convcc_CourseChapter.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.CreateDate = objvcc_CourseChapterEN.CreateDate == "[null]" ? null :  objvcc_CourseChapterEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convcc_CourseChapter.EditPeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.EditPeople = objvcc_CourseChapterEN.EditPeople == "[null]" ? null :  objvcc_CourseChapterEN.EditPeople; //修改人
}
if (arrFldSet.Contains(convcc_CourseChapter.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.UpdDate = objvcc_CourseChapterEN.UpdDate == "[null]" ? null :  objvcc_CourseChapterEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_CourseChapter.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.Memo = objvcc_CourseChapterEN.Memo == "[null]" ? null :  objvcc_CourseChapterEN.Memo; //备注
}
if (arrFldSet.Contains(convcc_CourseChapter.ParentNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.ParentNodeName = objvcc_CourseChapterEN.ParentNodeName == "[null]" ? null :  objvcc_CourseChapterEN.ParentNodeName; //父节点名称
}
if (arrFldSet.Contains(convcc_CourseChapter.ParentNodeReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseChapterEN.ParentNodeReferred = objvcc_CourseChapterEN.ParentNodeReferred == "[null]" ? null :  objvcc_CourseChapterEN.ParentNodeReferred; //章简称
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
 /// <param name = "objvcc_CourseChapterEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_CourseChapterEN objvcc_CourseChapterEN)
{
try
{
if (objvcc_CourseChapterEN.ChapterId == "[null]") objvcc_CourseChapterEN.ChapterId = null; //章Id
if (objvcc_CourseChapterEN.SectionId == "[null]") objvcc_CourseChapterEN.SectionId = null; //节Id
if (objvcc_CourseChapterEN.ChapterName == "[null]") objvcc_CourseChapterEN.ChapterName = null; //章名
if (objvcc_CourseChapterEN.SectionName == "[null]") objvcc_CourseChapterEN.SectionName = null; //节名
if (objvcc_CourseChapterEN.ChapterNameSim == "[null]") objvcc_CourseChapterEN.ChapterNameSim = null; //章名简称
if (objvcc_CourseChapterEN.SectionNameSim == "[null]") objvcc_CourseChapterEN.SectionNameSim = null; //节名简称
if (objvcc_CourseChapterEN.ChapterContent == "[null]") objvcc_CourseChapterEN.ChapterContent = null; //章节内容
if (objvcc_CourseChapterEN.CourseId == "[null]") objvcc_CourseChapterEN.CourseId = null; //课程Id
if (objvcc_CourseChapterEN.CourseCode == "[null]") objvcc_CourseChapterEN.CourseCode = null; //课程代码
if (objvcc_CourseChapterEN.CourseName == "[null]") objvcc_CourseChapterEN.CourseName = null; //课程名称
if (objvcc_CourseChapterEN.ThemeId == "[null]") objvcc_CourseChapterEN.ThemeId = null; //主题Id
if (objvcc_CourseChapterEN.ParentNodeId == "[null]") objvcc_CourseChapterEN.ParentNodeId = null; //父节点编号
if (objvcc_CourseChapterEN.ThemeName == "[null]") objvcc_CourseChapterEN.ThemeName = null; //主题名
if (objvcc_CourseChapterEN.CourseChapterReferred == "[null]") objvcc_CourseChapterEN.CourseChapterReferred = null; //节简称
if (objvcc_CourseChapterEN.CreateDate == "[null]") objvcc_CourseChapterEN.CreateDate = null; //建立日期
if (objvcc_CourseChapterEN.EditPeople == "[null]") objvcc_CourseChapterEN.EditPeople = null; //修改人
if (objvcc_CourseChapterEN.UpdDate == "[null]") objvcc_CourseChapterEN.UpdDate = null; //修改日期
if (objvcc_CourseChapterEN.Memo == "[null]") objvcc_CourseChapterEN.Memo = null; //备注
if (objvcc_CourseChapterEN.ParentNodeName == "[null]") objvcc_CourseChapterEN.ParentNodeName = null; //父节点名称
if (objvcc_CourseChapterEN.ParentNodeReferred == "[null]") objvcc_CourseChapterEN.ParentNodeReferred = null; //章简称
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
public static void CheckProperty4Condition(clsvcc_CourseChapterEN objvcc_CourseChapterEN)
{
 vcc_CourseChapterDA.CheckProperty4Condition(objvcc_CourseChapterEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strCourseId"></param>
public static void BindCbo_CourseChapterId(System.Windows.Forms.ComboBox objComboBox , string strCourseId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convcc_CourseChapter.CourseChapterId); 
List<clsvcc_CourseChapterEN> arrObjLst = clsvcc_CourseChapterBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvcc_CourseChapterEN objvcc_CourseChapterEN = new clsvcc_CourseChapterEN()
{
CourseChapterId = "0",
CourseChapterName = "选[v课程章节]..."
};
arrObjLstSel.Insert(0, objvcc_CourseChapterEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convcc_CourseChapter.CourseChapterId;
objComboBox.DisplayMember = convcc_CourseChapter.CourseChapterName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strCourseId"></param>
public static void BindDdl_CourseChapterId(System.Web.UI.WebControls.DropDownList objDDL , string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v课程章节]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convcc_CourseChapter.CourseChapterId); 
IEnumerable<clsvcc_CourseChapterEN> arrObjLst = clsvcc_CourseChapterBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
objDDL.DataValueField = convcc_CourseChapter.CourseChapterId;
objDDL.DataTextField = convcc_CourseChapter.CourseChapterName;
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
public static void BindDdl_CourseChapterIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v课程章节]...","0");
List<clsvcc_CourseChapterEN> arrvcc_CourseChapterObjLst = GetAllvcc_CourseChapterObjLstCache(strCourseId); 
objDDL.DataValueField = convcc_CourseChapter.CourseChapterId;
objDDL.DataTextField = convcc_CourseChapter.CourseChapterName;
objDDL.DataSource = arrvcc_CourseChapterObjLst;
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
//if (arrvcc_CourseChapterObjLstCache == null)
//{
//arrvcc_CourseChapterObjLstCache = vcc_CourseChapterDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCourseChapterId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseChapterEN GetObjByCourseChapterIdCache(string strCourseChapterId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapterEN._CurrTabName, strCourseId);
List<clsvcc_CourseChapterEN> arrvcc_CourseChapterObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseChapterEN> arrvcc_CourseChapterObjLst_Sel =
arrvcc_CourseChapterObjLstCache
.Where(x=> x.CourseChapterId == strCourseChapterId 
);
if (arrvcc_CourseChapterObjLst_Sel.Count() == 0)
{
   clsvcc_CourseChapterEN obj = clsvcc_CourseChapterBL.GetObjByCourseChapterId(strCourseChapterId);
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
return arrvcc_CourseChapterObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCourseChapterId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCourseChapterNameByCourseChapterIdCache(string strCourseChapterId, string strCourseId)
{
if (string.IsNullOrEmpty(strCourseChapterId) == true) return "";
//获取缓存中的对象列表
clsvcc_CourseChapterEN objvcc_CourseChapter = GetObjByCourseChapterIdCache(strCourseChapterId, strCourseId);
if (objvcc_CourseChapter == null) return "";
return objvcc_CourseChapter.CourseChapterName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCourseChapterId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCourseChapterIdCache(string strCourseChapterId, string strCourseId)
{
if (string.IsNullOrEmpty(strCourseChapterId) == true) return "";
//获取缓存中的对象列表
clsvcc_CourseChapterEN objvcc_CourseChapter = GetObjByCourseChapterIdCache(strCourseChapterId, strCourseId);
if (objvcc_CourseChapter == null) return "";
return objvcc_CourseChapter.CourseChapterName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseChapterEN> GetAllvcc_CourseChapterObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvcc_CourseChapterEN> arrvcc_CourseChapterObjLstCache = GetObjLstCache(strCourseId); 
return arrvcc_CourseChapterObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseChapterEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapterEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvcc_CourseChapterEN> arrvcc_CourseChapterObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvcc_CourseChapterObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapterEN._CurrTabName, strCourseId);
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
if (strInFldName != convcc_CourseChapter.CourseChapterId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_CourseChapter.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_CourseChapter.AttributeName));
throw new Exception(strMsg);
}
var objvcc_CourseChapter = clsvcc_CourseChapterBL.GetObjByCourseChapterIdCache(strCourseChapterId, strCourseId);
if (objvcc_CourseChapter == null) return "";
return objvcc_CourseChapter[strOutFldName].ToString();
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
int intRecCount = clsvcc_CourseChapterDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_CourseChapterDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_CourseChapterDA.GetRecCount();
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
int intRecCount = clsvcc_CourseChapterDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_CourseChapterCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_CourseChapterEN objvcc_CourseChapterCond)
{
 string strCourseId = objvcc_CourseChapterCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvcc_CourseChapterBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvcc_CourseChapterEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseChapterEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseChapter.AttributeName)
{
if (objvcc_CourseChapterCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseChapterCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseChapterCond[strFldName].ToString());
}
else
{
if (objvcc_CourseChapterCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseChapterCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseChapterCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseChapterCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseChapterCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseChapterCond[strFldName]));
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
 List<string> arrList = clsvcc_CourseChapterDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseChapterDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseChapterDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}