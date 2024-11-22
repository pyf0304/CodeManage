
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseChapterWApi
 表名:vcc_CourseChapter(01120061)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:02
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
public static class clsvcc_CourseChapterWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapterEN SetCourseChapterId(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_CourseChapter.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_CourseChapter.CourseChapterId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapterEN SetCourseChapterName(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterName, convcc_CourseChapter.CourseChapterName);
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_CourseChapter.CourseChapterName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapterEN SetChapterId(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, convcc_CourseChapter.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convcc_CourseChapter.ChapterId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapterEN SetSectionId(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionId, 8, convcc_CourseChapter.SectionId);
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convcc_CourseChapter.SectionId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapterEN SetChapterName(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_CourseChapter.ChapterName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapterEN SetSectionName(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_CourseChapter.SectionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapterEN SetChapterName_Sim(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convcc_CourseChapter.ChapterName_Sim);
objvcc_CourseChapterEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.ChapterName_Sim) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.ChapterName_Sim, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.ChapterName_Sim] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapterEN SetSectionName_Sim(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convcc_CourseChapter.SectionName_Sim);
objvcc_CourseChapterEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.SectionName_Sim) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.SectionName_Sim, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.SectionName_Sim] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapterEN SetCourseId(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_CourseChapter.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_CourseChapter.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapterEN SetCourseCode(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convcc_CourseChapter.CourseCode);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapterEN SetCourseName(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_CourseChapter.CourseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapterEN SetThemeId(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strThemeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strThemeId, 4, convcc_CourseChapter.ThemeId);
clsCheckSql.CheckFieldForeignKey(strThemeId, 4, convcc_CourseChapter.ThemeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapterEN SetParentNodeID(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convcc_CourseChapter.ParentNodeID);
objvcc_CourseChapterEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(convcc_CourseChapter.ParentNodeID) == false)
{
objvcc_CourseChapterEN.dicFldComparisonOp.Add(convcc_CourseChapter.ParentNodeID, strComparisonOp);
}
else
{
objvcc_CourseChapterEN.dicFldComparisonOp[convcc_CourseChapter.ParentNodeID] = strComparisonOp;
}
}
return objvcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapterEN SetThemeName(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strThemeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strThemeName, 200, convcc_CourseChapter.ThemeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapterEN SetViewCount(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, int intViewCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapterEN SetCourseChapterReferred(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strCourseChapterReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convcc_CourseChapter.CourseChapterReferred);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapterEN SetOrderNum(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, int intOrderNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapterEN SetCreateDate(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convcc_CourseChapter.CreateDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapterEN SetEditPeople(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strEditPeople, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEditPeople, 50, convcc_CourseChapter.EditPeople);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapterEN SetUpdDate(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_CourseChapter.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapterEN SetMemo(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_CourseChapter.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapterEN SetParentNodeName(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convcc_CourseChapter.ParentNodeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseChapterEN SetParentNodeReferred(this clsvcc_CourseChapterEN objvcc_CourseChapterEN, string strParentNodeReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convcc_CourseChapter.ParentNodeReferred);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseChapterEN objvcc_CourseChapter_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvcc_CourseChapter_Cond.dicFldComparisonOp[convcc_CourseChapter.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.CourseChapterId, objvcc_CourseChapter_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvcc_CourseChapter_Cond.dicFldComparisonOp[convcc_CourseChapter.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.CourseChapterName, objvcc_CourseChapter_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.ChapterId) == true)
{
string strComparisonOp_ChapterId = objvcc_CourseChapter_Cond.dicFldComparisonOp[convcc_CourseChapter.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.ChapterId, objvcc_CourseChapter_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.SectionId) == true)
{
string strComparisonOp_SectionId = objvcc_CourseChapter_Cond.dicFldComparisonOp[convcc_CourseChapter.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.SectionId, objvcc_CourseChapter_Cond.SectionId, strComparisonOp_SectionId);
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvcc_CourseChapter_Cond.dicFldComparisonOp[convcc_CourseChapter.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.ChapterName, objvcc_CourseChapter_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.SectionName) == true)
{
string strComparisonOp_SectionName = objvcc_CourseChapter_Cond.dicFldComparisonOp[convcc_CourseChapter.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.SectionName, objvcc_CourseChapter_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvcc_CourseChapter_Cond.dicFldComparisonOp[convcc_CourseChapter.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.ChapterName_Sim, objvcc_CourseChapter_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvcc_CourseChapter_Cond.dicFldComparisonOp[convcc_CourseChapter.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.SectionName_Sim, objvcc_CourseChapter_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_CourseChapter_Cond.dicFldComparisonOp[convcc_CourseChapter.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.CourseId, objvcc_CourseChapter_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvcc_CourseChapter_Cond.dicFldComparisonOp[convcc_CourseChapter.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.CourseCode, objvcc_CourseChapter_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_CourseChapter_Cond.dicFldComparisonOp[convcc_CourseChapter.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.CourseName, objvcc_CourseChapter_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.ThemeId) == true)
{
string strComparisonOp_ThemeId = objvcc_CourseChapter_Cond.dicFldComparisonOp[convcc_CourseChapter.ThemeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.ThemeId, objvcc_CourseChapter_Cond.ThemeId, strComparisonOp_ThemeId);
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvcc_CourseChapter_Cond.dicFldComparisonOp[convcc_CourseChapter.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.ParentNodeID, objvcc_CourseChapter_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.IsOpenToAllStu) == true)
{
if (objvcc_CourseChapter_Cond.IsOpenToAllStu == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter.IsOpenToAllStu);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter.IsOpenToAllStu);
}
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.IsOpenToSchool) == true)
{
if (objvcc_CourseChapter_Cond.IsOpenToSchool == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter.IsOpenToSchool);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter.IsOpenToSchool);
}
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.IsOpenToSocial) == true)
{
if (objvcc_CourseChapter_Cond.IsOpenToSocial == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter.IsOpenToSocial);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter.IsOpenToSocial);
}
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.IsMustMenu) == true)
{
if (objvcc_CourseChapter_Cond.IsMustMenu == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter.IsMustMenu);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter.IsMustMenu);
}
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.ThemeName) == true)
{
string strComparisonOp_ThemeName = objvcc_CourseChapter_Cond.dicFldComparisonOp[convcc_CourseChapter.ThemeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.ThemeName, objvcc_CourseChapter_Cond.ThemeName, strComparisonOp_ThemeName);
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.IsFile) == true)
{
if (objvcc_CourseChapter_Cond.IsFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter.IsFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter.IsFile);
}
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.IsUse) == true)
{
if (objvcc_CourseChapter_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseChapter.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseChapter.IsUse);
}
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvcc_CourseChapter_Cond.dicFldComparisonOp[convcc_CourseChapter.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseChapter.ViewCount, objvcc_CourseChapter_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.CourseChapterReferred) == true)
{
string strComparisonOp_CourseChapterReferred = objvcc_CourseChapter_Cond.dicFldComparisonOp[convcc_CourseChapter.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.CourseChapterReferred, objvcc_CourseChapter_Cond.CourseChapterReferred, strComparisonOp_CourseChapterReferred);
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvcc_CourseChapter_Cond.dicFldComparisonOp[convcc_CourseChapter.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseChapter.OrderNum, objvcc_CourseChapter_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.CreateDate) == true)
{
string strComparisonOp_CreateDate = objvcc_CourseChapter_Cond.dicFldComparisonOp[convcc_CourseChapter.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.CreateDate, objvcc_CourseChapter_Cond.CreateDate, strComparisonOp_CreateDate);
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.EditPeople) == true)
{
string strComparisonOp_EditPeople = objvcc_CourseChapter_Cond.dicFldComparisonOp[convcc_CourseChapter.EditPeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.EditPeople, objvcc_CourseChapter_Cond.EditPeople, strComparisonOp_EditPeople);
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_CourseChapter_Cond.dicFldComparisonOp[convcc_CourseChapter.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.UpdDate, objvcc_CourseChapter_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.Memo) == true)
{
string strComparisonOp_Memo = objvcc_CourseChapter_Cond.dicFldComparisonOp[convcc_CourseChapter.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.Memo, objvcc_CourseChapter_Cond.Memo, strComparisonOp_Memo);
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvcc_CourseChapter_Cond.dicFldComparisonOp[convcc_CourseChapter.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.ParentNodeName, objvcc_CourseChapter_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvcc_CourseChapter_Cond.IsUpdated(convcc_CourseChapter.ParentNodeReferred) == true)
{
string strComparisonOp_ParentNodeReferred = objvcc_CourseChapter_Cond.dicFldComparisonOp[convcc_CourseChapter.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseChapter.ParentNodeReferred, objvcc_CourseChapter_Cond.ParentNodeReferred, strComparisonOp_ParentNodeReferred);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课程章节(vcc_CourseChapter)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseChapterWApi
{
private static readonly string mstrApiControllerName = "vcc_CourseChapterApi";

 public clsvcc_CourseChapterWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_CourseChapterId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v课程章节]...","0");
List<clsvcc_CourseChapterEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="CourseChapterId";
objDDL.DataTextField="CourseChapterName";
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
public static void BindCbo_CourseChapterId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convcc_CourseChapter.CourseChapterId); 
List<clsvcc_CourseChapterEN> arrObjLst = clsvcc_CourseChapterWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvcc_CourseChapterEN objvcc_CourseChapterEN = new clsvcc_CourseChapterEN()
{
CourseChapterId = "0",
CourseChapterName = "选[v课程章节]..."
};
arrObjLst.Insert(0, objvcc_CourseChapterEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convcc_CourseChapter.CourseChapterId;
objComboBox.DisplayMember = convcc_CourseChapter.CourseChapterName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseChapterId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseChapterEN GetObjByCourseChapterId(string strCourseChapterId)
{
string strAction = "GetObjByCourseChapterId";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseChapterEN objvcc_CourseChapterEN = null;
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
objvcc_CourseChapterEN = JsonConvert.DeserializeObject<clsvcc_CourseChapterEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseChapterEN;
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
public static clsvcc_CourseChapterEN GetObjByCourseChapterId_WA_Cache(string strCourseChapterId, string strCourseId)
{
string strAction = "GetObjByCourseChapterId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseChapterEN objvcc_CourseChapterEN = null;
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
objvcc_CourseChapterEN = JsonConvert.DeserializeObject<clsvcc_CourseChapterEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseChapterEN;
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
public static clsvcc_CourseChapterEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseChapterEN objvcc_CourseChapterEN = null;
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
objvcc_CourseChapterEN = JsonConvert.DeserializeObject<clsvcc_CourseChapterEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseChapterEN;
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
public static clsvcc_CourseChapterEN GetObjByCourseChapterId_Cache(string strCourseChapterId, string strCourseId)
{
if (string.IsNullOrEmpty(strCourseChapterId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapterEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseChapterEN> arrvcc_CourseChapterObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_CourseChapterEN> arrvcc_CourseChapterObjLst_Sel =
from objvcc_CourseChapterEN in arrvcc_CourseChapterObjLst_Cache
where objvcc_CourseChapterEN.CourseChapterId == strCourseChapterId
select objvcc_CourseChapterEN;
if (arrvcc_CourseChapterObjLst_Sel.Count() == 0)
{
   clsvcc_CourseChapterEN obj = clsvcc_CourseChapterWApi.GetObjByCourseChapterId(strCourseChapterId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_CourseChapterObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strCourseChapterId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCourseChapterNameByCourseChapterId_Cache(string strCourseChapterId, string strCourseId)
{
if (string.IsNullOrEmpty(strCourseChapterId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapterEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseChapterEN> arrvcc_CourseChapterObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_CourseChapterEN> arrvcc_CourseChapterObjLst_Sel1 =
from objvcc_CourseChapterEN in arrvcc_CourseChapterObjLst_Cache
where objvcc_CourseChapterEN.CourseChapterId == strCourseChapterId
select objvcc_CourseChapterEN;
List <clsvcc_CourseChapterEN> arrvcc_CourseChapterObjLst_Sel = new List<clsvcc_CourseChapterEN>();
foreach (clsvcc_CourseChapterEN obj in arrvcc_CourseChapterObjLst_Sel1)
{
arrvcc_CourseChapterObjLst_Sel.Add(obj);
}
if (arrvcc_CourseChapterObjLst_Sel.Count > 0)
{
return arrvcc_CourseChapterObjLst_Sel[0].CourseChapterName;
}
string strErrMsgForGetObjById = string.Format("在vcc_CourseChapter对象缓存列表中,找不到记录[CourseChapterId = {0}](函数:{1})", strCourseChapterId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvcc_CourseChapterBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strCourseChapterId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCourseChapterId_Cache(string strCourseChapterId, string strCourseId)
{
if (string.IsNullOrEmpty(strCourseChapterId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapterEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseChapterEN> arrvcc_CourseChapterObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_CourseChapterEN> arrvcc_CourseChapterObjLst_Sel1 =
from objvcc_CourseChapterEN in arrvcc_CourseChapterObjLst_Cache
where objvcc_CourseChapterEN.CourseChapterId == strCourseChapterId
select objvcc_CourseChapterEN;
List <clsvcc_CourseChapterEN> arrvcc_CourseChapterObjLst_Sel = new List<clsvcc_CourseChapterEN>();
foreach (clsvcc_CourseChapterEN obj in arrvcc_CourseChapterObjLst_Sel1)
{
arrvcc_CourseChapterObjLst_Sel.Add(obj);
}
if (arrvcc_CourseChapterObjLst_Sel.Count > 0)
{
return arrvcc_CourseChapterObjLst_Sel[0].CourseChapterName;
}
string strErrMsgForGetObjById = string.Format("在vcc_CourseChapter对象缓存列表中,找不到记录的相关名称[CourseChapterId = {0}](函数:{1})", strCourseChapterId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvcc_CourseChapterBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseChapterEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_CourseChapterEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseChapterEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseChapterEN> GetObjLstByCourseChapterIdLst(List<string> arrCourseChapterId)
{
 List<clsvcc_CourseChapterEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseChapterEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvcc_CourseChapterEN> GetObjLstByCourseChapterIdLst_Cache(List<string> arrCourseChapterId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapterEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseChapterEN> arrvcc_CourseChapterObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_CourseChapterEN> arrvcc_CourseChapterObjLst_Sel =
from objvcc_CourseChapterEN in arrvcc_CourseChapterObjLst_Cache
where arrCourseChapterId.Contains(objvcc_CourseChapterEN.CourseChapterId)
select objvcc_CourseChapterEN;
return arrvcc_CourseChapterObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseChapterEN> GetObjLstByCourseChapterIdLst_WA_Cache(List<string> arrCourseChapterId, string strCourseId)
{
 List<clsvcc_CourseChapterEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseChapterEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseChapterEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_CourseChapterEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseChapterEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseChapterEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_CourseChapterEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseChapterEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseChapterEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseChapterEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseChapterEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseChapterEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseChapterEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseChapterEN>>((string)jobjReturn["ReturnObjLst"]);
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
objvcc_CourseChapterENT.ChapterName_Sim = objvcc_CourseChapterENS.ChapterName_Sim; //章名简称
objvcc_CourseChapterENT.SectionName_Sim = objvcc_CourseChapterENS.SectionName_Sim; //节名简称
objvcc_CourseChapterENT.ChapterContent = objvcc_CourseChapterENS.ChapterContent; //章节内容
objvcc_CourseChapterENT.CourseId = objvcc_CourseChapterENS.CourseId; //课程Id
objvcc_CourseChapterENT.CourseCode = objvcc_CourseChapterENS.CourseCode; //课程代码
objvcc_CourseChapterENT.CourseName = objvcc_CourseChapterENS.CourseName; //课程名称
objvcc_CourseChapterENT.ThemeId = objvcc_CourseChapterENS.ThemeId; //主题Id
objvcc_CourseChapterENT.ParentNodeID = objvcc_CourseChapterENS.ParentNodeID; //父节点编号
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
public static DataTable ToDataTable(List<clsvcc_CourseChapterEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_CourseChapterEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_CourseChapterEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_CourseChapterEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_CourseChapterEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_CourseChapterEN.AttributeName)
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
//if (arrvcc_CourseChapterObjLst_Cache == null)
//{
//arrvcc_CourseChapterObjLst_Cache = await clsvcc_CourseChapterWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapterEN._CurrTabName_S, strCourseId);
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
public static List<clsvcc_CourseChapterEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_CourseChapterEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseChapterEN> arrvcc_CourseChapterObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvcc_CourseChapterObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_CourseChapterEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_CourseChapter.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter.SectionId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter.ChapterContent, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter.ThemeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter.IsOpenToAllStu, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseChapter.IsOpenToSchool, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseChapter.IsOpenToSocial, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseChapter.IsMustMenu, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseChapter.ThemeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter.IsFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseChapter.IsUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseChapter.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseChapter.CourseChapterReferred, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseChapter.CreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter.EditPeople, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseChapter.ParentNodeReferred, Type.GetType("System.String"));
foreach (clsvcc_CourseChapterEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_CourseChapter.CourseChapterId] = objInFor[convcc_CourseChapter.CourseChapterId];
objDR[convcc_CourseChapter.CourseChapterName] = objInFor[convcc_CourseChapter.CourseChapterName];
objDR[convcc_CourseChapter.ChapterId] = objInFor[convcc_CourseChapter.ChapterId];
objDR[convcc_CourseChapter.SectionId] = objInFor[convcc_CourseChapter.SectionId];
objDR[convcc_CourseChapter.ChapterName] = objInFor[convcc_CourseChapter.ChapterName];
objDR[convcc_CourseChapter.SectionName] = objInFor[convcc_CourseChapter.SectionName];
objDR[convcc_CourseChapter.ChapterName_Sim] = objInFor[convcc_CourseChapter.ChapterName_Sim];
objDR[convcc_CourseChapter.SectionName_Sim] = objInFor[convcc_CourseChapter.SectionName_Sim];
objDR[convcc_CourseChapter.ChapterContent] = objInFor[convcc_CourseChapter.ChapterContent];
objDR[convcc_CourseChapter.CourseId] = objInFor[convcc_CourseChapter.CourseId];
objDR[convcc_CourseChapter.CourseCode] = objInFor[convcc_CourseChapter.CourseCode];
objDR[convcc_CourseChapter.CourseName] = objInFor[convcc_CourseChapter.CourseName];
objDR[convcc_CourseChapter.ThemeId] = objInFor[convcc_CourseChapter.ThemeId];
objDR[convcc_CourseChapter.ParentNodeID] = objInFor[convcc_CourseChapter.ParentNodeID];
objDR[convcc_CourseChapter.IsOpenToAllStu] = objInFor[convcc_CourseChapter.IsOpenToAllStu];
objDR[convcc_CourseChapter.IsOpenToSchool] = objInFor[convcc_CourseChapter.IsOpenToSchool];
objDR[convcc_CourseChapter.IsOpenToSocial] = objInFor[convcc_CourseChapter.IsOpenToSocial];
objDR[convcc_CourseChapter.IsMustMenu] = objInFor[convcc_CourseChapter.IsMustMenu];
objDR[convcc_CourseChapter.ThemeName] = objInFor[convcc_CourseChapter.ThemeName];
objDR[convcc_CourseChapter.IsFile] = objInFor[convcc_CourseChapter.IsFile];
objDR[convcc_CourseChapter.IsUse] = objInFor[convcc_CourseChapter.IsUse];
objDR[convcc_CourseChapter.ViewCount] = objInFor[convcc_CourseChapter.ViewCount];
objDR[convcc_CourseChapter.CourseChapterReferred] = objInFor[convcc_CourseChapter.CourseChapterReferred];
objDR[convcc_CourseChapter.OrderNum] = objInFor[convcc_CourseChapter.OrderNum];
objDR[convcc_CourseChapter.CreateDate] = objInFor[convcc_CourseChapter.CreateDate];
objDR[convcc_CourseChapter.EditPeople] = objInFor[convcc_CourseChapter.EditPeople];
objDR[convcc_CourseChapter.UpdDate] = objInFor[convcc_CourseChapter.UpdDate];
objDR[convcc_CourseChapter.Memo] = objInFor[convcc_CourseChapter.Memo];
objDR[convcc_CourseChapter.ParentNodeName] = objInFor[convcc_CourseChapter.ParentNodeName];
objDR[convcc_CourseChapter.ParentNodeReferred] = objInFor[convcc_CourseChapter.ParentNodeReferred];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}