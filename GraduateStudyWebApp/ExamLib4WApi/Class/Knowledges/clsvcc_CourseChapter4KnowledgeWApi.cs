
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseChapter4KnowledgeWApi
 表名:vcc_CourseChapter4Knowledge(01120158)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:51
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关
 模块英文名:Knowledges
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
public static class clsvcc_CourseChapter4KnowledgeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetCourseChapterId(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_CourseChapter4Knowledge.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_CourseChapter4Knowledge.CourseChapterId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetCourseChapterName(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterName, convcc_CourseChapter4Knowledge.CourseChapterName);
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_CourseChapter4Knowledge.CourseChapterName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetChapterId(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, convcc_CourseChapter4Knowledge.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convcc_CourseChapter4Knowledge.ChapterId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetSectionId(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionId, 8, convcc_CourseChapter4Knowledge.SectionId);
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convcc_CourseChapter4Knowledge.SectionId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetChapterName(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_CourseChapter4Knowledge.ChapterName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetSectionName(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_CourseChapter4Knowledge.SectionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetChapterName_Sim(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convcc_CourseChapter4Knowledge.ChapterName_Sim);
objvcc_CourseChapter4KnowledgeEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.ChapterName_Sim) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.ChapterName_Sim, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ChapterName_Sim] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetSectionName_Sim(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convcc_CourseChapter4Knowledge.SectionName_Sim);
objvcc_CourseChapter4KnowledgeEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.SectionName_Sim) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.SectionName_Sim, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.SectionName_Sim] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetCourseId(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convcc_CourseChapter4Knowledge.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_CourseChapter4Knowledge.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_CourseChapter4Knowledge.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetCourseCode(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convcc_CourseChapter4Knowledge.CourseCode);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetCourseName(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_CourseChapter4Knowledge.CourseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetThemeId(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strThemeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strThemeId, 4, convcc_CourseChapter4Knowledge.ThemeId);
clsCheckSql.CheckFieldForeignKey(strThemeId, 4, convcc_CourseChapter4Knowledge.ThemeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetParentNodeID(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParentNodeID, convcc_CourseChapter4Knowledge.ParentNodeID);
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convcc_CourseChapter4Knowledge.ParentNodeID);
objvcc_CourseChapter4KnowledgeEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4Knowledge.ParentNodeID) == false)
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp.Add(convcc_CourseChapter4Knowledge.ParentNodeID, strComparisonOp);
}
else
{
objvcc_CourseChapter4KnowledgeEN.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ParentNodeID] = strComparisonOp;
}
}
return objvcc_CourseChapter4KnowledgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetThemeName(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strThemeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strThemeName, 200, convcc_CourseChapter4Knowledge.ThemeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetViewCount(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, int intViewCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetCourseChapterReferred(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strCourseChapterReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convcc_CourseChapter4Knowledge.CourseChapterReferred);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetOrderNum(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, int intOrderNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetCreateDate(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convcc_CourseChapter4Knowledge.CreateDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetEditPeople(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strEditPeople, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEditPeople, 50, convcc_CourseChapter4Knowledge.EditPeople);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetUpdDate(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_CourseChapter4Knowledge.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetMemo(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_CourseChapter4Knowledge.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetParentNodeName(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convcc_CourseChapter4Knowledge.ParentNodeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetParentNodeReferred(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, string strParentNodeReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convcc_CourseChapter4Knowledge.ParentNodeReferred);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4KnowledgeEN SetKnowledgeNum(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN, int intKnowledgeNum, string strComparisonOp="")
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4Knowledge_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.CourseChapterId, objvcc_CourseChapter4Knowledge_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.CourseChapterName, objvcc_CourseChapter4Knowledge_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.ChapterId) == true)
{
string strComparisonOp_ChapterId = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.ChapterId, objvcc_CourseChapter4Knowledge_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.SectionId) == true)
{
string strComparisonOp_SectionId = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.SectionId, objvcc_CourseChapter4Knowledge_Cond.SectionId, strComparisonOp_SectionId);
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.ChapterName, objvcc_CourseChapter4Knowledge_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.SectionName) == true)
{
string strComparisonOp_SectionName = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.SectionName, objvcc_CourseChapter4Knowledge_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.ChapterName_Sim, objvcc_CourseChapter4Knowledge_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.SectionName_Sim, objvcc_CourseChapter4Knowledge_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.CourseId, objvcc_CourseChapter4Knowledge_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.CourseCode, objvcc_CourseChapter4Knowledge_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.CourseName, objvcc_CourseChapter4Knowledge_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.ThemeId) == true)
{
string strComparisonOp_ThemeId = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ThemeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.ThemeId, objvcc_CourseChapter4Knowledge_Cond.ThemeId, strComparisonOp_ThemeId);
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.ParentNodeID, objvcc_CourseChapter4Knowledge_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.IsOpenToAllStu) == true)
{
if (objvcc_CourseChapter4Knowledge_Cond.IsOpenToAllStu == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4Knowledge.IsOpenToAllStu);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4Knowledge.IsOpenToAllStu);
}
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.IsOpenToSchool) == true)
{
if (objvcc_CourseChapter4Knowledge_Cond.IsOpenToSchool == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4Knowledge.IsOpenToSchool);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4Knowledge.IsOpenToSchool);
}
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.IsOpenToSocial) == true)
{
if (objvcc_CourseChapter4Knowledge_Cond.IsOpenToSocial == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4Knowledge.IsOpenToSocial);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4Knowledge.IsOpenToSocial);
}
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.IsMustMenu) == true)
{
if (objvcc_CourseChapter4Knowledge_Cond.IsMustMenu == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4Knowledge.IsMustMenu);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4Knowledge.IsMustMenu);
}
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.ThemeName) == true)
{
string strComparisonOp_ThemeName = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ThemeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.ThemeName, objvcc_CourseChapter4Knowledge_Cond.ThemeName, strComparisonOp_ThemeName);
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.IsFile) == true)
{
if (objvcc_CourseChapter4Knowledge_Cond.IsFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4Knowledge.IsFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4Knowledge.IsFile);
}
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.IsUse) == true)
{
if (objvcc_CourseChapter4Knowledge_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4Knowledge.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4Knowledge.IsUse);
}
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseChapter4Knowledge.ViewCount, objvcc_CourseChapter4Knowledge_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.CourseChapterReferred) == true)
{
string strComparisonOp_CourseChapterReferred = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.CourseChapterReferred, objvcc_CourseChapter4Knowledge_Cond.CourseChapterReferred, strComparisonOp_CourseChapterReferred);
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseChapter4Knowledge.OrderNum, objvcc_CourseChapter4Knowledge_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.CreateDate) == true)
{
string strComparisonOp_CreateDate = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.CreateDate, objvcc_CourseChapter4Knowledge_Cond.CreateDate, strComparisonOp_CreateDate);
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.EditPeople) == true)
{
string strComparisonOp_EditPeople = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.EditPeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.EditPeople, objvcc_CourseChapter4Knowledge_Cond.EditPeople, strComparisonOp_EditPeople);
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.UpdDate, objvcc_CourseChapter4Knowledge_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.Memo) == true)
{
string strComparisonOp_Memo = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.Memo, objvcc_CourseChapter4Knowledge_Cond.Memo, strComparisonOp_Memo);
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.ParentNodeName, objvcc_CourseChapter4Knowledge_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.ParentNodeReferred) == true)
{
string strComparisonOp_ParentNodeReferred = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4Knowledge.ParentNodeReferred, objvcc_CourseChapter4Knowledge_Cond.ParentNodeReferred, strComparisonOp_ParentNodeReferred);
}
if (objvcc_CourseChapter4Knowledge_Cond.IsUpdated(convcc_CourseChapter4Knowledge.KnowledgeNum) == true)
{
string strComparisonOp_KnowledgeNum = objvcc_CourseChapter4Knowledge_Cond.dicFldComparisonOp[convcc_CourseChapter4Knowledge.KnowledgeNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseChapter4Knowledge.KnowledgeNum, objvcc_CourseChapter4Knowledge_Cond.KnowledgeNum, strComparisonOp_KnowledgeNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课程章节表4知识点(vcc_CourseChapter4Knowledge)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseChapter4KnowledgeWApi
{
private static readonly string mstrApiControllerName = "vcc_CourseChapter4KnowledgeApi";

 public clsvcc_CourseChapter4KnowledgeWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseChapterId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseChapter4KnowledgeEN GetObjByCourseChapterId(string strCourseChapterId)
{
string strAction = "GetObjByCourseChapterId";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseChapterId"] = strCourseChapterId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_CourseChapter4KnowledgeEN = JsonConvert.DeserializeObject<clsvcc_CourseChapter4KnowledgeEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseChapter4KnowledgeEN;
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
 /// <param name = "strCourseChapterId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseChapter4KnowledgeEN GetObjByCourseChapterId_WA_Cache(string strCourseChapterId, string strCourseId)
{
string strAction = "GetObjByCourseChapterId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseChapterId"] = strCourseChapterId,
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_CourseChapter4KnowledgeEN = JsonConvert.DeserializeObject<clsvcc_CourseChapter4KnowledgeEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseChapter4KnowledgeEN;
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
public static clsvcc_CourseChapter4KnowledgeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = null;
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
objvcc_CourseChapter4KnowledgeEN = JsonConvert.DeserializeObject<clsvcc_CourseChapter4KnowledgeEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseChapter4KnowledgeEN;
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
 /// <param name = "strCourseChapterId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseChapter4KnowledgeEN GetObjByCourseChapterId_Cache(string strCourseChapterId, string strCourseId)
{
if (string.IsNullOrEmpty(strCourseChapterId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapter4KnowledgeEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseChapter4KnowledgeEN> arrvcc_CourseChapter4KnowledgeObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_CourseChapter4KnowledgeEN> arrvcc_CourseChapter4KnowledgeObjLst_Sel =
from objvcc_CourseChapter4KnowledgeEN in arrvcc_CourseChapter4KnowledgeObjLst_Cache
where objvcc_CourseChapter4KnowledgeEN.CourseChapterId == strCourseChapterId
select objvcc_CourseChapter4KnowledgeEN;
if (arrvcc_CourseChapter4KnowledgeObjLst_Sel.Count() == 0)
{
   clsvcc_CourseChapter4KnowledgeEN obj = clsvcc_CourseChapter4KnowledgeWApi.GetObjByCourseChapterId(strCourseChapterId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_CourseChapter4KnowledgeObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseChapter4KnowledgeEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_CourseChapter4KnowledgeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseChapter4KnowledgeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseChapter4KnowledgeEN> GetObjLstByCourseChapterIdLst(List<string> arrCourseChapterId)
{
 List<clsvcc_CourseChapter4KnowledgeEN> arrObjLst = null; 
string strAction = "GetObjLstByCourseChapterIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCourseChapterId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseChapter4KnowledgeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strCourseChapterId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_CourseChapter4KnowledgeEN> GetObjLstByCourseChapterIdLst_Cache(List<string> arrCourseChapterId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapter4KnowledgeEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseChapter4KnowledgeEN> arrvcc_CourseChapter4KnowledgeObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_CourseChapter4KnowledgeEN> arrvcc_CourseChapter4KnowledgeObjLst_Sel =
from objvcc_CourseChapter4KnowledgeEN in arrvcc_CourseChapter4KnowledgeObjLst_Cache
where arrCourseChapterId.Contains(objvcc_CourseChapter4KnowledgeEN.CourseChapterId)
select objvcc_CourseChapter4KnowledgeEN;
return arrvcc_CourseChapter4KnowledgeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseChapter4KnowledgeEN> GetObjLstByCourseChapterIdLst_WA_Cache(List<string> arrCourseChapterId, string strCourseId)
{
 List<clsvcc_CourseChapter4KnowledgeEN> arrObjLst = null; 
string strAction = "GetObjLstByCourseChapterIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCourseChapterId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseChapter4KnowledgeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseChapter4KnowledgeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_CourseChapter4KnowledgeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseChapter4KnowledgeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseChapter4KnowledgeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_CourseChapter4KnowledgeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseChapter4KnowledgeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseChapter4KnowledgeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseChapter4KnowledgeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseChapter4KnowledgeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseChapter4KnowledgeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseChapter4KnowledgeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseChapter4KnowledgeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strCourseChapterId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseChapterId"] = strCourseChapterId
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
objvcc_CourseChapter4KnowledgeENT.ChapterName_Sim = objvcc_CourseChapter4KnowledgeENS.ChapterName_Sim; //章名简称
objvcc_CourseChapter4KnowledgeENT.SectionName_Sim = objvcc_CourseChapter4KnowledgeENS.SectionName_Sim; //节名简称
objvcc_CourseChapter4KnowledgeENT.ChapterContent = objvcc_CourseChapter4KnowledgeENS.ChapterContent; //章节内容
objvcc_CourseChapter4KnowledgeENT.CourseId = objvcc_CourseChapter4KnowledgeENS.CourseId; //课程Id
objvcc_CourseChapter4KnowledgeENT.CourseCode = objvcc_CourseChapter4KnowledgeENS.CourseCode; //课程代码
objvcc_CourseChapter4KnowledgeENT.CourseName = objvcc_CourseChapter4KnowledgeENS.CourseName; //课程名称
objvcc_CourseChapter4KnowledgeENT.ThemeId = objvcc_CourseChapter4KnowledgeENS.ThemeId; //主题Id
objvcc_CourseChapter4KnowledgeENT.ParentNodeID = objvcc_CourseChapter4KnowledgeENS.ParentNodeID; //父节点编号
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
public static DataTable ToDataTable(List<clsvcc_CourseChapter4KnowledgeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_CourseChapter4KnowledgeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_CourseChapter4KnowledgeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_CourseChapter4KnowledgeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_CourseChapter4KnowledgeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_CourseChapter4KnowledgeEN.AttributeName)
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
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by CourseChapterId");
//if (arrvcc_CourseChapter4KnowledgeObjLst_Cache == null)
//{
//arrvcc_CourseChapter4KnowledgeObjLst_Cache = await clsvcc_CourseChapter4KnowledgeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapter4KnowledgeEN._CurrTabName_S, strCourseId);
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
public static List<clsvcc_CourseChapter4KnowledgeEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapter4KnowledgeEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseChapter4KnowledgeEN> arrvcc_CourseChapter4KnowledgeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvcc_CourseChapter4KnowledgeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_CourseChapter4KnowledgeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_CourseChapter4Knowledge.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.SectionId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.ChapterContent, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.ThemeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.IsOpenToAllStu, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.IsOpenToSchool, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.IsOpenToSocial, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.IsMustMenu, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.ThemeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.IsFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.IsUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.CourseChapterReferred, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.CreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.EditPeople, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.ParentNodeReferred, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4Knowledge.KnowledgeNum, Type.GetType("System.Int32"));
foreach (clsvcc_CourseChapter4KnowledgeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_CourseChapter4Knowledge.CourseChapterId] = objInFor[convcc_CourseChapter4Knowledge.CourseChapterId];
objDR[convcc_CourseChapter4Knowledge.CourseChapterName] = objInFor[convcc_CourseChapter4Knowledge.CourseChapterName];
objDR[convcc_CourseChapter4Knowledge.ChapterId] = objInFor[convcc_CourseChapter4Knowledge.ChapterId];
objDR[convcc_CourseChapter4Knowledge.SectionId] = objInFor[convcc_CourseChapter4Knowledge.SectionId];
objDR[convcc_CourseChapter4Knowledge.ChapterName] = objInFor[convcc_CourseChapter4Knowledge.ChapterName];
objDR[convcc_CourseChapter4Knowledge.SectionName] = objInFor[convcc_CourseChapter4Knowledge.SectionName];
objDR[convcc_CourseChapter4Knowledge.ChapterName_Sim] = objInFor[convcc_CourseChapter4Knowledge.ChapterName_Sim];
objDR[convcc_CourseChapter4Knowledge.SectionName_Sim] = objInFor[convcc_CourseChapter4Knowledge.SectionName_Sim];
objDR[convcc_CourseChapter4Knowledge.ChapterContent] = objInFor[convcc_CourseChapter4Knowledge.ChapterContent];
objDR[convcc_CourseChapter4Knowledge.CourseId] = objInFor[convcc_CourseChapter4Knowledge.CourseId];
objDR[convcc_CourseChapter4Knowledge.CourseCode] = objInFor[convcc_CourseChapter4Knowledge.CourseCode];
objDR[convcc_CourseChapter4Knowledge.CourseName] = objInFor[convcc_CourseChapter4Knowledge.CourseName];
objDR[convcc_CourseChapter4Knowledge.ThemeId] = objInFor[convcc_CourseChapter4Knowledge.ThemeId];
objDR[convcc_CourseChapter4Knowledge.ParentNodeID] = objInFor[convcc_CourseChapter4Knowledge.ParentNodeID];
objDR[convcc_CourseChapter4Knowledge.IsOpenToAllStu] = objInFor[convcc_CourseChapter4Knowledge.IsOpenToAllStu];
objDR[convcc_CourseChapter4Knowledge.IsOpenToSchool] = objInFor[convcc_CourseChapter4Knowledge.IsOpenToSchool];
objDR[convcc_CourseChapter4Knowledge.IsOpenToSocial] = objInFor[convcc_CourseChapter4Knowledge.IsOpenToSocial];
objDR[convcc_CourseChapter4Knowledge.IsMustMenu] = objInFor[convcc_CourseChapter4Knowledge.IsMustMenu];
objDR[convcc_CourseChapter4Knowledge.ThemeName] = objInFor[convcc_CourseChapter4Knowledge.ThemeName];
objDR[convcc_CourseChapter4Knowledge.IsFile] = objInFor[convcc_CourseChapter4Knowledge.IsFile];
objDR[convcc_CourseChapter4Knowledge.IsUse] = objInFor[convcc_CourseChapter4Knowledge.IsUse];
objDR[convcc_CourseChapter4Knowledge.ViewCount] = objInFor[convcc_CourseChapter4Knowledge.ViewCount];
objDR[convcc_CourseChapter4Knowledge.CourseChapterReferred] = objInFor[convcc_CourseChapter4Knowledge.CourseChapterReferred];
objDR[convcc_CourseChapter4Knowledge.OrderNum] = objInFor[convcc_CourseChapter4Knowledge.OrderNum];
objDR[convcc_CourseChapter4Knowledge.CreateDate] = objInFor[convcc_CourseChapter4Knowledge.CreateDate];
objDR[convcc_CourseChapter4Knowledge.EditPeople] = objInFor[convcc_CourseChapter4Knowledge.EditPeople];
objDR[convcc_CourseChapter4Knowledge.UpdDate] = objInFor[convcc_CourseChapter4Knowledge.UpdDate];
objDR[convcc_CourseChapter4Knowledge.Memo] = objInFor[convcc_CourseChapter4Knowledge.Memo];
objDR[convcc_CourseChapter4Knowledge.ParentNodeName] = objInFor[convcc_CourseChapter4Knowledge.ParentNodeName];
objDR[convcc_CourseChapter4Knowledge.ParentNodeReferred] = objInFor[convcc_CourseChapter4Knowledge.ParentNodeReferred];
objDR[convcc_CourseChapter4Knowledge.KnowledgeNum] = objInFor[convcc_CourseChapter4Knowledge.KnowledgeNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}