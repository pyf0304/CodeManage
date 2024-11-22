
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseChapter4ExamLibWApi
 表名:vcc_CourseChapter4ExamLib(01120159)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:52
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
public static class clsvcc_CourseChapter4ExamLibWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetCourseChapterId(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_CourseChapter4ExamLib.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_CourseChapter4ExamLib.CourseChapterId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetCourseChapterName(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterName, convcc_CourseChapter4ExamLib.CourseChapterName);
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_CourseChapter4ExamLib.CourseChapterName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetChapterId(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, convcc_CourseChapter4ExamLib.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convcc_CourseChapter4ExamLib.ChapterId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetSectionId(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionId, 8, convcc_CourseChapter4ExamLib.SectionId);
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convcc_CourseChapter4ExamLib.SectionId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetChapterName(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_CourseChapter4ExamLib.ChapterName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetSectionName(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_CourseChapter4ExamLib.SectionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetChapterName_Sim(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convcc_CourseChapter4ExamLib.ChapterName_Sim);
objvcc_CourseChapter4ExamLibEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.ChapterName_Sim) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.ChapterName_Sim, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ChapterName_Sim] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetSectionName_Sim(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convcc_CourseChapter4ExamLib.SectionName_Sim);
objvcc_CourseChapter4ExamLibEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.SectionName_Sim) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.SectionName_Sim, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.SectionName_Sim] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetCourseId(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convcc_CourseChapter4ExamLib.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_CourseChapter4ExamLib.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_CourseChapter4ExamLib.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetCourseCode(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convcc_CourseChapter4ExamLib.CourseCode);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetCourseName(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_CourseChapter4ExamLib.CourseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetThemeId(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strThemeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strThemeId, 4, convcc_CourseChapter4ExamLib.ThemeId);
clsCheckSql.CheckFieldForeignKey(strThemeId, 4, convcc_CourseChapter4ExamLib.ThemeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetParentNodeID(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParentNodeID, convcc_CourseChapter4ExamLib.ParentNodeID);
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convcc_CourseChapter4ExamLib.ParentNodeID);
objvcc_CourseChapter4ExamLibEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter4ExamLib.ParentNodeID) == false)
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp.Add(convcc_CourseChapter4ExamLib.ParentNodeID, strComparisonOp);
}
else
{
objvcc_CourseChapter4ExamLibEN.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ParentNodeID] = strComparisonOp;
}
}
return objvcc_CourseChapter4ExamLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetThemeName(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strThemeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strThemeName, 200, convcc_CourseChapter4ExamLib.ThemeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetViewCount(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, int intViewCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetCourseChapterReferred(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strCourseChapterReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convcc_CourseChapter4ExamLib.CourseChapterReferred);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetOrderNum(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, int intOrderNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetCreateDate(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convcc_CourseChapter4ExamLib.CreateDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetEditPeople(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strEditPeople, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEditPeople, 50, convcc_CourseChapter4ExamLib.EditPeople);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetUpdDate(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_CourseChapter4ExamLib.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetMemo(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_CourseChapter4ExamLib.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetParentNodeName(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convcc_CourseChapter4ExamLib.ParentNodeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetParentNodeReferred(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, string strParentNodeReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convcc_CourseChapter4ExamLib.ParentNodeReferred);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4ExamLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapter4ExamLibEN SetQuesionnaireNum(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN, int intQuesionnaireNum, string strComparisonOp="")
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLib_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.CourseChapterId, objvcc_CourseChapter4ExamLib_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.CourseChapterName, objvcc_CourseChapter4ExamLib_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.ChapterId) == true)
{
string strComparisonOp_ChapterId = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.ChapterId, objvcc_CourseChapter4ExamLib_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.SectionId) == true)
{
string strComparisonOp_SectionId = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.SectionId, objvcc_CourseChapter4ExamLib_Cond.SectionId, strComparisonOp_SectionId);
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.ChapterName, objvcc_CourseChapter4ExamLib_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.SectionName) == true)
{
string strComparisonOp_SectionName = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.SectionName, objvcc_CourseChapter4ExamLib_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.ChapterName_Sim, objvcc_CourseChapter4ExamLib_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.SectionName_Sim, objvcc_CourseChapter4ExamLib_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.CourseId, objvcc_CourseChapter4ExamLib_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.CourseCode, objvcc_CourseChapter4ExamLib_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.CourseName, objvcc_CourseChapter4ExamLib_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.ThemeId) == true)
{
string strComparisonOp_ThemeId = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ThemeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.ThemeId, objvcc_CourseChapter4ExamLib_Cond.ThemeId, strComparisonOp_ThemeId);
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.ParentNodeID, objvcc_CourseChapter4ExamLib_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.IsOpenToAllStu) == true)
{
if (objvcc_CourseChapter4ExamLib_Cond.IsOpenToAllStu == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4ExamLib.IsOpenToAllStu);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4ExamLib.IsOpenToAllStu);
}
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.IsOpenToSchool) == true)
{
if (objvcc_CourseChapter4ExamLib_Cond.IsOpenToSchool == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4ExamLib.IsOpenToSchool);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4ExamLib.IsOpenToSchool);
}
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.IsOpenToSocial) == true)
{
if (objvcc_CourseChapter4ExamLib_Cond.IsOpenToSocial == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4ExamLib.IsOpenToSocial);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4ExamLib.IsOpenToSocial);
}
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.IsMustMenu) == true)
{
if (objvcc_CourseChapter4ExamLib_Cond.IsMustMenu == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4ExamLib.IsMustMenu);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4ExamLib.IsMustMenu);
}
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.ThemeName) == true)
{
string strComparisonOp_ThemeName = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ThemeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.ThemeName, objvcc_CourseChapter4ExamLib_Cond.ThemeName, strComparisonOp_ThemeName);
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.IsFile) == true)
{
if (objvcc_CourseChapter4ExamLib_Cond.IsFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4ExamLib.IsFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4ExamLib.IsFile);
}
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.IsUse) == true)
{
if (objvcc_CourseChapter4ExamLib_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter4ExamLib.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter4ExamLib.IsUse);
}
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseChapter4ExamLib.ViewCount, objvcc_CourseChapter4ExamLib_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.CourseChapterReferred) == true)
{
string strComparisonOp_CourseChapterReferred = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.CourseChapterReferred, objvcc_CourseChapter4ExamLib_Cond.CourseChapterReferred, strComparisonOp_CourseChapterReferred);
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseChapter4ExamLib.OrderNum, objvcc_CourseChapter4ExamLib_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.CreateDate) == true)
{
string strComparisonOp_CreateDate = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.CreateDate, objvcc_CourseChapter4ExamLib_Cond.CreateDate, strComparisonOp_CreateDate);
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.EditPeople) == true)
{
string strComparisonOp_EditPeople = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.EditPeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.EditPeople, objvcc_CourseChapter4ExamLib_Cond.EditPeople, strComparisonOp_EditPeople);
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.UpdDate, objvcc_CourseChapter4ExamLib_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.Memo) == true)
{
string strComparisonOp_Memo = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.Memo, objvcc_CourseChapter4ExamLib_Cond.Memo, strComparisonOp_Memo);
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.ParentNodeName, objvcc_CourseChapter4ExamLib_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.ParentNodeReferred) == true)
{
string strComparisonOp_ParentNodeReferred = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter4ExamLib.ParentNodeReferred, objvcc_CourseChapter4ExamLib_Cond.ParentNodeReferred, strComparisonOp_ParentNodeReferred);
}
if (objvcc_CourseChapter4ExamLib_Cond.IsUpdated(convcc_CourseChapter4ExamLib.QuesionnaireNum) == true)
{
string strComparisonOp_QuesionnaireNum = objvcc_CourseChapter4ExamLib_Cond.dicFldComparisonOp[convcc_CourseChapter4ExamLib.QuesionnaireNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseChapter4ExamLib.QuesionnaireNum, objvcc_CourseChapter4ExamLib_Cond.QuesionnaireNum, strComparisonOp_QuesionnaireNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课程章节表4题库(vcc_CourseChapter4ExamLib)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseChapter4ExamLibWApi
{
private static readonly string mstrApiControllerName = "vcc_CourseChapter4ExamLibApi";

 public clsvcc_CourseChapter4ExamLibWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseChapterId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseChapter4ExamLibEN GetObjByCourseChapterId(string strCourseChapterId)
{
string strAction = "GetObjByCourseChapterId";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = null;
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
objvcc_CourseChapter4ExamLibEN = JsonConvert.DeserializeObject<clsvcc_CourseChapter4ExamLibEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseChapter4ExamLibEN;
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
public static clsvcc_CourseChapter4ExamLibEN GetObjByCourseChapterId_WA_Cache(string strCourseChapterId, string strCourseId)
{
string strAction = "GetObjByCourseChapterId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = null;
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
objvcc_CourseChapter4ExamLibEN = JsonConvert.DeserializeObject<clsvcc_CourseChapter4ExamLibEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseChapter4ExamLibEN;
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
public static clsvcc_CourseChapter4ExamLibEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseChapter4ExamLibEN objvcc_CourseChapter4ExamLibEN = null;
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
objvcc_CourseChapter4ExamLibEN = JsonConvert.DeserializeObject<clsvcc_CourseChapter4ExamLibEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseChapter4ExamLibEN;
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
public static clsvcc_CourseChapter4ExamLibEN GetObjByCourseChapterId_Cache(string strCourseChapterId, string strCourseId)
{
if (string.IsNullOrEmpty(strCourseChapterId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapter4ExamLibEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseChapter4ExamLibEN> arrvcc_CourseChapter4ExamLibObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_CourseChapter4ExamLibEN> arrvcc_CourseChapter4ExamLibObjLst_Sel =
from objvcc_CourseChapter4ExamLibEN in arrvcc_CourseChapter4ExamLibObjLst_Cache
where objvcc_CourseChapter4ExamLibEN.CourseChapterId == strCourseChapterId
select objvcc_CourseChapter4ExamLibEN;
if (arrvcc_CourseChapter4ExamLibObjLst_Sel.Count() == 0)
{
   clsvcc_CourseChapter4ExamLibEN obj = clsvcc_CourseChapter4ExamLibWApi.GetObjByCourseChapterId(strCourseChapterId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_CourseChapter4ExamLibObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseChapter4ExamLibEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_CourseChapter4ExamLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseChapter4ExamLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseChapter4ExamLibEN> GetObjLstByCourseChapterIdLst(List<string> arrCourseChapterId)
{
 List<clsvcc_CourseChapter4ExamLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseChapter4ExamLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvcc_CourseChapter4ExamLibEN> GetObjLstByCourseChapterIdLst_Cache(List<string> arrCourseChapterId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapter4ExamLibEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseChapter4ExamLibEN> arrvcc_CourseChapter4ExamLibObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_CourseChapter4ExamLibEN> arrvcc_CourseChapter4ExamLibObjLst_Sel =
from objvcc_CourseChapter4ExamLibEN in arrvcc_CourseChapter4ExamLibObjLst_Cache
where arrCourseChapterId.Contains(objvcc_CourseChapter4ExamLibEN.CourseChapterId)
select objvcc_CourseChapter4ExamLibEN;
return arrvcc_CourseChapter4ExamLibObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseChapter4ExamLibEN> GetObjLstByCourseChapterIdLst_WA_Cache(List<string> arrCourseChapterId, string strCourseId)
{
 List<clsvcc_CourseChapter4ExamLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseChapter4ExamLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseChapter4ExamLibEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_CourseChapter4ExamLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseChapter4ExamLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseChapter4ExamLibEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_CourseChapter4ExamLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseChapter4ExamLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseChapter4ExamLibEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseChapter4ExamLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseChapter4ExamLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseChapter4ExamLibEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseChapter4ExamLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseChapter4ExamLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
objvcc_CourseChapter4ExamLibENT.ChapterName_Sim = objvcc_CourseChapter4ExamLibENS.ChapterName_Sim; //章名简称
objvcc_CourseChapter4ExamLibENT.SectionName_Sim = objvcc_CourseChapter4ExamLibENS.SectionName_Sim; //节名简称
objvcc_CourseChapter4ExamLibENT.ChapterContent = objvcc_CourseChapter4ExamLibENS.ChapterContent; //章节内容
objvcc_CourseChapter4ExamLibENT.CourseId = objvcc_CourseChapter4ExamLibENS.CourseId; //课程Id
objvcc_CourseChapter4ExamLibENT.CourseCode = objvcc_CourseChapter4ExamLibENS.CourseCode; //课程代码
objvcc_CourseChapter4ExamLibENT.CourseName = objvcc_CourseChapter4ExamLibENS.CourseName; //课程名称
objvcc_CourseChapter4ExamLibENT.ThemeId = objvcc_CourseChapter4ExamLibENS.ThemeId; //主题Id
objvcc_CourseChapter4ExamLibENT.ParentNodeID = objvcc_CourseChapter4ExamLibENS.ParentNodeID; //父节点编号
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
public static DataTable ToDataTable(List<clsvcc_CourseChapter4ExamLibEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_CourseChapter4ExamLibEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_CourseChapter4ExamLibEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_CourseChapter4ExamLibEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_CourseChapter4ExamLibEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_CourseChapter4ExamLibEN.AttributeName)
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
//if (arrvcc_CourseChapter4ExamLibObjLst_Cache == null)
//{
//arrvcc_CourseChapter4ExamLibObjLst_Cache = await clsvcc_CourseChapter4ExamLibWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapter4ExamLibEN._CurrTabName_S, strCourseId);
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
public static List<clsvcc_CourseChapter4ExamLibEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapter4ExamLibEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseChapter4ExamLibEN> arrvcc_CourseChapter4ExamLibObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvcc_CourseChapter4ExamLibObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_CourseChapter4ExamLibEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_CourseChapter4ExamLib.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.SectionId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.ChapterContent, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.ThemeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.IsOpenToAllStu, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.IsOpenToSchool, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.IsOpenToSocial, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.IsMustMenu, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.ThemeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.IsFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.IsUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.CourseChapterReferred, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.CreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.EditPeople, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.ParentNodeReferred, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter4ExamLib.QuesionnaireNum, Type.GetType("System.Int32"));
foreach (clsvcc_CourseChapter4ExamLibEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_CourseChapter4ExamLib.CourseChapterId] = objInFor[convcc_CourseChapter4ExamLib.CourseChapterId];
objDR[convcc_CourseChapter4ExamLib.CourseChapterName] = objInFor[convcc_CourseChapter4ExamLib.CourseChapterName];
objDR[convcc_CourseChapter4ExamLib.ChapterId] = objInFor[convcc_CourseChapter4ExamLib.ChapterId];
objDR[convcc_CourseChapter4ExamLib.SectionId] = objInFor[convcc_CourseChapter4ExamLib.SectionId];
objDR[convcc_CourseChapter4ExamLib.ChapterName] = objInFor[convcc_CourseChapter4ExamLib.ChapterName];
objDR[convcc_CourseChapter4ExamLib.SectionName] = objInFor[convcc_CourseChapter4ExamLib.SectionName];
objDR[convcc_CourseChapter4ExamLib.ChapterName_Sim] = objInFor[convcc_CourseChapter4ExamLib.ChapterName_Sim];
objDR[convcc_CourseChapter4ExamLib.SectionName_Sim] = objInFor[convcc_CourseChapter4ExamLib.SectionName_Sim];
objDR[convcc_CourseChapter4ExamLib.ChapterContent] = objInFor[convcc_CourseChapter4ExamLib.ChapterContent];
objDR[convcc_CourseChapter4ExamLib.CourseId] = objInFor[convcc_CourseChapter4ExamLib.CourseId];
objDR[convcc_CourseChapter4ExamLib.CourseCode] = objInFor[convcc_CourseChapter4ExamLib.CourseCode];
objDR[convcc_CourseChapter4ExamLib.CourseName] = objInFor[convcc_CourseChapter4ExamLib.CourseName];
objDR[convcc_CourseChapter4ExamLib.ThemeId] = objInFor[convcc_CourseChapter4ExamLib.ThemeId];
objDR[convcc_CourseChapter4ExamLib.ParentNodeID] = objInFor[convcc_CourseChapter4ExamLib.ParentNodeID];
objDR[convcc_CourseChapter4ExamLib.IsOpenToAllStu] = objInFor[convcc_CourseChapter4ExamLib.IsOpenToAllStu];
objDR[convcc_CourseChapter4ExamLib.IsOpenToSchool] = objInFor[convcc_CourseChapter4ExamLib.IsOpenToSchool];
objDR[convcc_CourseChapter4ExamLib.IsOpenToSocial] = objInFor[convcc_CourseChapter4ExamLib.IsOpenToSocial];
objDR[convcc_CourseChapter4ExamLib.IsMustMenu] = objInFor[convcc_CourseChapter4ExamLib.IsMustMenu];
objDR[convcc_CourseChapter4ExamLib.ThemeName] = objInFor[convcc_CourseChapter4ExamLib.ThemeName];
objDR[convcc_CourseChapter4ExamLib.IsFile] = objInFor[convcc_CourseChapter4ExamLib.IsFile];
objDR[convcc_CourseChapter4ExamLib.IsUse] = objInFor[convcc_CourseChapter4ExamLib.IsUse];
objDR[convcc_CourseChapter4ExamLib.ViewCount] = objInFor[convcc_CourseChapter4ExamLib.ViewCount];
objDR[convcc_CourseChapter4ExamLib.CourseChapterReferred] = objInFor[convcc_CourseChapter4ExamLib.CourseChapterReferred];
objDR[convcc_CourseChapter4ExamLib.OrderNum] = objInFor[convcc_CourseChapter4ExamLib.OrderNum];
objDR[convcc_CourseChapter4ExamLib.CreateDate] = objInFor[convcc_CourseChapter4ExamLib.CreateDate];
objDR[convcc_CourseChapter4ExamLib.EditPeople] = objInFor[convcc_CourseChapter4ExamLib.EditPeople];
objDR[convcc_CourseChapter4ExamLib.UpdDate] = objInFor[convcc_CourseChapter4ExamLib.UpdDate];
objDR[convcc_CourseChapter4ExamLib.Memo] = objInFor[convcc_CourseChapter4ExamLib.Memo];
objDR[convcc_CourseChapter4ExamLib.ParentNodeName] = objInFor[convcc_CourseChapter4ExamLib.ParentNodeName];
objDR[convcc_CourseChapter4ExamLib.ParentNodeReferred] = objInFor[convcc_CourseChapter4ExamLib.ParentNodeReferred];
objDR[convcc_CourseChapter4ExamLib.QuesionnaireNum] = objInFor[convcc_CourseChapter4ExamLib.QuesionnaireNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}