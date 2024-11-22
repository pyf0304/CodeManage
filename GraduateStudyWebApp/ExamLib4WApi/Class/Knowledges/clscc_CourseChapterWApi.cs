
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseChapterWApi
 表名:cc_CourseChapter(01120060)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:49:26
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
public static class clscc_CourseChapterWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetCourseChapterId(this clscc_CourseChapterEN objcc_CourseChapterEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, concc_CourseChapter.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, concc_CourseChapter.CourseChapterId);
objcc_CourseChapterEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.CourseChapterId) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.CourseChapterId, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.CourseChapterId] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetCourseChapterName(this clscc_CourseChapterEN objcc_CourseChapterEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterName, concc_CourseChapter.CourseChapterName);
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, concc_CourseChapter.CourseChapterName);
objcc_CourseChapterEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.CourseChapterName) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.CourseChapterName, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.CourseChapterName] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetChapterId(this clscc_CourseChapterEN objcc_CourseChapterEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, concc_CourseChapter.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, concc_CourseChapter.ChapterId);
objcc_CourseChapterEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.ChapterId) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.ChapterId, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.ChapterId] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetSectionId(this clscc_CourseChapterEN objcc_CourseChapterEN, string strSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionId, 8, concc_CourseChapter.SectionId);
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, concc_CourseChapter.SectionId);
objcc_CourseChapterEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.SectionId) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.SectionId, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.SectionId] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetChapterName(this clscc_CourseChapterEN objcc_CourseChapterEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, concc_CourseChapter.ChapterName);
objcc_CourseChapterEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.ChapterName) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.ChapterName, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.ChapterName] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetSectionName(this clscc_CourseChapterEN objcc_CourseChapterEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, concc_CourseChapter.SectionName);
objcc_CourseChapterEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.SectionName) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.SectionName, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.SectionName] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetChapterName_Sim(this clscc_CourseChapterEN objcc_CourseChapterEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, concc_CourseChapter.ChapterName_Sim);
objcc_CourseChapterEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.ChapterName_Sim) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.ChapterName_Sim, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.ChapterName_Sim] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetSectionName_Sim(this clscc_CourseChapterEN objcc_CourseChapterEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, concc_CourseChapter.SectionName_Sim);
objcc_CourseChapterEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.SectionName_Sim) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.SectionName_Sim, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.SectionName_Sim] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetChapterContent(this clscc_CourseChapterEN objcc_CourseChapterEN, string strChapterContent, string strComparisonOp="")
	{
objcc_CourseChapterEN.ChapterContent = strChapterContent; //章节内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.ChapterContent) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.ChapterContent, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.ChapterContent] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetCourseId(this clscc_CourseChapterEN objcc_CourseChapterEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, concc_CourseChapter.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_CourseChapter.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_CourseChapter.CourseId);
objcc_CourseChapterEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.CourseId) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.CourseId, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.CourseId] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetParentNodeID(this clscc_CourseChapterEN objcc_CourseChapterEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParentNodeID, concc_CourseChapter.ParentNodeID);
clsCheckSql.CheckFieldLen(strParentNodeID, 8, concc_CourseChapter.ParentNodeID);
objcc_CourseChapterEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.ParentNodeID) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.ParentNodeID, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.ParentNodeID] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetIsOpenToAllStu(this clscc_CourseChapterEN objcc_CourseChapterEN, bool bolIsOpenToAllStu, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsOpenToAllStu, concc_CourseChapter.IsOpenToAllStu);
objcc_CourseChapterEN.IsOpenToAllStu = bolIsOpenToAllStu; //全校师生
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.IsOpenToAllStu) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.IsOpenToAllStu, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.IsOpenToAllStu] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetIsOpenToSchool(this clscc_CourseChapterEN objcc_CourseChapterEN, bool bolIsOpenToSchool, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsOpenToSchool, concc_CourseChapter.IsOpenToSchool);
objcc_CourseChapterEN.IsOpenToSchool = bolIsOpenToSchool; //全校师生公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.IsOpenToSchool) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.IsOpenToSchool, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.IsOpenToSchool] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetIsOpenToSocial(this clscc_CourseChapterEN objcc_CourseChapterEN, bool bolIsOpenToSocial, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsOpenToSocial, concc_CourseChapter.IsOpenToSocial);
objcc_CourseChapterEN.IsOpenToSocial = bolIsOpenToSocial; //社会公众
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.IsOpenToSocial) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.IsOpenToSocial, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.IsOpenToSocial] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetIsMustMenu(this clscc_CourseChapterEN objcc_CourseChapterEN, bool bolIsMustMenu, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsMustMenu, concc_CourseChapter.IsMustMenu);
objcc_CourseChapterEN.IsMustMenu = bolIsMustMenu; //是否必建栏目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.IsMustMenu) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.IsMustMenu, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.IsMustMenu] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetThemeName(this clscc_CourseChapterEN objcc_CourseChapterEN, string strThemeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strThemeName, 200, concc_CourseChapter.ThemeName);
objcc_CourseChapterEN.ThemeName = strThemeName; //主题名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.ThemeName) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.ThemeName, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.ThemeName] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetIsFile(this clscc_CourseChapterEN objcc_CourseChapterEN, bool bolIsFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsFile, concc_CourseChapter.IsFile);
objcc_CourseChapterEN.IsFile = bolIsFile; //项目或文件夹
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.IsFile) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.IsFile, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.IsFile] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetIsUse(this clscc_CourseChapterEN objcc_CourseChapterEN, bool bolIsUse, string strComparisonOp="")
	{
objcc_CourseChapterEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.IsUse) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.IsUse, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.IsUse] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetViewCount(this clscc_CourseChapterEN objcc_CourseChapterEN, int intViewCount, string strComparisonOp="")
	{
objcc_CourseChapterEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.ViewCount) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.ViewCount, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.ViewCount] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetCourseChapterReferred(this clscc_CourseChapterEN objcc_CourseChapterEN, string strCourseChapterReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, concc_CourseChapter.CourseChapterReferred);
objcc_CourseChapterEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.CourseChapterReferred) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.CourseChapterReferred, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.CourseChapterReferred] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetOrderNum(this clscc_CourseChapterEN objcc_CourseChapterEN, int intOrderNum, string strComparisonOp="")
	{
objcc_CourseChapterEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.OrderNum) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.OrderNum, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.OrderNum] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetCreateDate(this clscc_CourseChapterEN objcc_CourseChapterEN, string strCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateDate, 20, concc_CourseChapter.CreateDate);
objcc_CourseChapterEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.CreateDate) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.CreateDate, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.CreateDate] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetEditPeople(this clscc_CourseChapterEN objcc_CourseChapterEN, string strEditPeople, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEditPeople, 50, concc_CourseChapter.EditPeople);
objcc_CourseChapterEN.EditPeople = strEditPeople; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.EditPeople) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.EditPeople, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.EditPeople] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetUpdDate(this clscc_CourseChapterEN objcc_CourseChapterEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_CourseChapter.UpdDate);
objcc_CourseChapterEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.UpdDate) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.UpdDate, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.UpdDate] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseChapterEN SetMemo(this clscc_CourseChapterEN objcc_CourseChapterEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_CourseChapter.Memo);
objcc_CourseChapterEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.Memo) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.Memo, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.Memo] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_CourseChapterEN objcc_CourseChapter_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objcc_CourseChapter_Cond.dicFldComparisonOp[concc_CourseChapter.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.CourseChapterId, objcc_CourseChapter_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objcc_CourseChapter_Cond.dicFldComparisonOp[concc_CourseChapter.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.CourseChapterName, objcc_CourseChapter_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.ChapterId) == true)
{
string strComparisonOp_ChapterId = objcc_CourseChapter_Cond.dicFldComparisonOp[concc_CourseChapter.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.ChapterId, objcc_CourseChapter_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.SectionId) == true)
{
string strComparisonOp_SectionId = objcc_CourseChapter_Cond.dicFldComparisonOp[concc_CourseChapter.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.SectionId, objcc_CourseChapter_Cond.SectionId, strComparisonOp_SectionId);
}
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.ChapterName) == true)
{
string strComparisonOp_ChapterName = objcc_CourseChapter_Cond.dicFldComparisonOp[concc_CourseChapter.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.ChapterName, objcc_CourseChapter_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.SectionName) == true)
{
string strComparisonOp_SectionName = objcc_CourseChapter_Cond.dicFldComparisonOp[concc_CourseChapter.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.SectionName, objcc_CourseChapter_Cond.SectionName, strComparisonOp_SectionName);
}
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objcc_CourseChapter_Cond.dicFldComparisonOp[concc_CourseChapter.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.ChapterName_Sim, objcc_CourseChapter_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objcc_CourseChapter_Cond.dicFldComparisonOp[concc_CourseChapter.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.SectionName_Sim, objcc_CourseChapter_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.CourseId) == true)
{
string strComparisonOp_CourseId = objcc_CourseChapter_Cond.dicFldComparisonOp[concc_CourseChapter.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.CourseId, objcc_CourseChapter_Cond.CourseId, strComparisonOp_CourseId);
}
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objcc_CourseChapter_Cond.dicFldComparisonOp[concc_CourseChapter.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.ParentNodeID, objcc_CourseChapter_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.IsOpenToAllStu) == true)
{
if (objcc_CourseChapter_Cond.IsOpenToAllStu == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseChapter.IsOpenToAllStu);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseChapter.IsOpenToAllStu);
}
}
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.IsOpenToSchool) == true)
{
if (objcc_CourseChapter_Cond.IsOpenToSchool == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseChapter.IsOpenToSchool);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseChapter.IsOpenToSchool);
}
}
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.IsOpenToSocial) == true)
{
if (objcc_CourseChapter_Cond.IsOpenToSocial == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseChapter.IsOpenToSocial);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseChapter.IsOpenToSocial);
}
}
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.IsMustMenu) == true)
{
if (objcc_CourseChapter_Cond.IsMustMenu == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseChapter.IsMustMenu);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseChapter.IsMustMenu);
}
}
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.ThemeName) == true)
{
string strComparisonOp_ThemeName = objcc_CourseChapter_Cond.dicFldComparisonOp[concc_CourseChapter.ThemeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.ThemeName, objcc_CourseChapter_Cond.ThemeName, strComparisonOp_ThemeName);
}
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.IsFile) == true)
{
if (objcc_CourseChapter_Cond.IsFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseChapter.IsFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseChapter.IsFile);
}
}
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.IsUse) == true)
{
if (objcc_CourseChapter_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseChapter.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseChapter.IsUse);
}
}
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.ViewCount) == true)
{
string strComparisonOp_ViewCount = objcc_CourseChapter_Cond.dicFldComparisonOp[concc_CourseChapter.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseChapter.ViewCount, objcc_CourseChapter_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.CourseChapterReferred) == true)
{
string strComparisonOp_CourseChapterReferred = objcc_CourseChapter_Cond.dicFldComparisonOp[concc_CourseChapter.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.CourseChapterReferred, objcc_CourseChapter_Cond.CourseChapterReferred, strComparisonOp_CourseChapterReferred);
}
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.OrderNum) == true)
{
string strComparisonOp_OrderNum = objcc_CourseChapter_Cond.dicFldComparisonOp[concc_CourseChapter.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseChapter.OrderNum, objcc_CourseChapter_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.CreateDate) == true)
{
string strComparisonOp_CreateDate = objcc_CourseChapter_Cond.dicFldComparisonOp[concc_CourseChapter.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.CreateDate, objcc_CourseChapter_Cond.CreateDate, strComparisonOp_CreateDate);
}
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.EditPeople) == true)
{
string strComparisonOp_EditPeople = objcc_CourseChapter_Cond.dicFldComparisonOp[concc_CourseChapter.EditPeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.EditPeople, objcc_CourseChapter_Cond.EditPeople, strComparisonOp_EditPeople);
}
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.UpdDate) == true)
{
string strComparisonOp_UpdDate = objcc_CourseChapter_Cond.dicFldComparisonOp[concc_CourseChapter.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.UpdDate, objcc_CourseChapter_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objcc_CourseChapter_Cond.IsUpdated(concc_CourseChapter.Memo) == true)
{
string strComparisonOp_Memo = objcc_CourseChapter_Cond.dicFldComparisonOp[concc_CourseChapter.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.Memo, objcc_CourseChapter_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseChapterEN objcc_CourseChapterEN)
{
 if (string.IsNullOrEmpty(objcc_CourseChapterEN.CourseChapterId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_CourseChapterEN.sf_UpdFldSetStr = objcc_CourseChapterEN.getsf_UpdFldSetStr();
clscc_CourseChapterWApi.CheckPropertyNew(objcc_CourseChapterEN); 
bool bolResult = clscc_CourseChapterWApi.UpdateRecord(objcc_CourseChapterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseChapterWApi.ReFreshCache(objcc_CourseChapterEN.CourseId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_CourseChapter(课程章节), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_CourseId_CourseChapterName(this clscc_CourseChapterEN objcc_CourseChapterEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_CourseChapterEN == null) return "";
if (objcc_CourseChapterEN.CourseChapterId == null || objcc_CourseChapterEN.CourseChapterId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseChapterEN.CourseId);
 sbCondition.AppendFormat(" and CourseChapterName = '{0}'", objcc_CourseChapterEN.CourseChapterName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CourseChapterId !=  '{0}'", objcc_CourseChapterEN.CourseChapterId);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseChapterEN.CourseId);
 sbCondition.AppendFormat(" and CourseChapterName = '{0}'", objcc_CourseChapterEN.CourseChapterName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_CourseChapterEN objcc_CourseChapterEN)
{
try
{
 if (string.IsNullOrEmpty(objcc_CourseChapterEN.CourseChapterId) == true || clscc_CourseChapterWApi.IsExist(objcc_CourseChapterEN.CourseChapterId) == true)
 {
     objcc_CourseChapterEN.CourseChapterId = clscc_CourseChapterWApi.GetMaxStrId();
 }
clscc_CourseChapterWApi.CheckPropertyNew(objcc_CourseChapterEN); 
bool bolResult = clscc_CourseChapterWApi.AddNewRecord(objcc_CourseChapterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseChapterWApi.ReFreshCache(objcc_CourseChapterEN.CourseId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clscc_CourseChapterEN objcc_CourseChapterEN)
{
try
{
clscc_CourseChapterWApi.CheckPropertyNew(objcc_CourseChapterEN); 
string strCourseChapterId = clscc_CourseChapterWApi.AddNewRecordWithMaxId(objcc_CourseChapterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseChapterWApi.ReFreshCache(objcc_CourseChapterEN.CourseId);
return strCourseChapterId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseChapterEN objcc_CourseChapterEN, string strWhereCond)
{
try
{
clscc_CourseChapterWApi.CheckPropertyNew(objcc_CourseChapterEN); 
bool bolResult = clscc_CourseChapterWApi.UpdateWithCondition(objcc_CourseChapterEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseChapterWApi.ReFreshCache(objcc_CourseChapterEN.CourseId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 课程章节(cc_CourseChapter)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_CourseChapterWApi
{
private static readonly string mstrApiControllerName = "cc_CourseChapterApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clscc_CourseChapterWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[课程章节]...","0");
List<clscc_CourseChapterEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", concc_CourseChapter.CourseChapterId); 
List<clscc_CourseChapterEN> arrObjLst = clscc_CourseChapterWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clscc_CourseChapterEN objcc_CourseChapterEN = new clscc_CourseChapterEN()
{
CourseChapterId = "0",
CourseChapterName = "选[课程章节]..."
};
arrObjLst.Insert(0, objcc_CourseChapterEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = concc_CourseChapter.CourseChapterId;
objComboBox.DisplayMember = concc_CourseChapter.CourseChapterName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_CourseChapterEN objcc_CourseChapterEN)
{
if (!Object.Equals(null, objcc_CourseChapterEN.CourseChapterId) && GetStrLen(objcc_CourseChapterEN.CourseChapterId) > 8)
{
 throw new Exception("字段[课程章节ID]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseChapterEN.CourseChapterName) && GetStrLen(objcc_CourseChapterEN.CourseChapterName) > 100)
{
 throw new Exception("字段[课程章节名称]的长度不能超过100!");
}
if (!Object.Equals(null, objcc_CourseChapterEN.ChapterId) && GetStrLen(objcc_CourseChapterEN.ChapterId) > 8)
{
 throw new Exception("字段[章Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseChapterEN.SectionId) && GetStrLen(objcc_CourseChapterEN.SectionId) > 8)
{
 throw new Exception("字段[节Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseChapterEN.ChapterName) && GetStrLen(objcc_CourseChapterEN.ChapterName) > 100)
{
 throw new Exception("字段[章名]的长度不能超过100!");
}
if (!Object.Equals(null, objcc_CourseChapterEN.SectionName) && GetStrLen(objcc_CourseChapterEN.SectionName) > 100)
{
 throw new Exception("字段[节名]的长度不能超过100!");
}
if (!Object.Equals(null, objcc_CourseChapterEN.ChapterName_Sim) && GetStrLen(objcc_CourseChapterEN.ChapterName_Sim) > 10)
{
 throw new Exception("字段[章名简称]的长度不能超过10!");
}
if (!Object.Equals(null, objcc_CourseChapterEN.SectionName_Sim) && GetStrLen(objcc_CourseChapterEN.SectionName_Sim) > 10)
{
 throw new Exception("字段[节名简称]的长度不能超过10!");
}
if (!Object.Equals(null, objcc_CourseChapterEN.CourseId) && GetStrLen(objcc_CourseChapterEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseChapterEN.ParentNodeID) && GetStrLen(objcc_CourseChapterEN.ParentNodeID) > 8)
{
 throw new Exception("字段[父节点编号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseChapterEN.ThemeName) && GetStrLen(objcc_CourseChapterEN.ThemeName) > 200)
{
 throw new Exception("字段[主题名]的长度不能超过200!");
}
if (!Object.Equals(null, objcc_CourseChapterEN.CourseChapterReferred) && GetStrLen(objcc_CourseChapterEN.CourseChapterReferred) > 10)
{
 throw new Exception("字段[节简称]的长度不能超过10!");
}
if (!Object.Equals(null, objcc_CourseChapterEN.CreateDate) && GetStrLen(objcc_CourseChapterEN.CreateDate) > 20)
{
 throw new Exception("字段[建立日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_CourseChapterEN.EditPeople) && GetStrLen(objcc_CourseChapterEN.EditPeople) > 50)
{
 throw new Exception("字段[修改人]的长度不能超过50!");
}
if (!Object.Equals(null, objcc_CourseChapterEN.UpdDate) && GetStrLen(objcc_CourseChapterEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_CourseChapterEN.Memo) && GetStrLen(objcc_CourseChapterEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objcc_CourseChapterEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseChapterId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseChapterEN GetObjByCourseChapterId(string strCourseChapterId)
{
string strAction = "GetObjByCourseChapterId";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseChapterEN objcc_CourseChapterEN = null;
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
objcc_CourseChapterEN = JsonConvert.DeserializeObject<clscc_CourseChapterEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseChapterEN;
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
public static clscc_CourseChapterEN GetObjByCourseChapterId_WA_Cache(string strCourseChapterId, string strCourseId)
{
string strAction = "GetObjByCourseChapterId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseChapterEN objcc_CourseChapterEN = null;
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
objcc_CourseChapterEN = JsonConvert.DeserializeObject<clscc_CourseChapterEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseChapterEN;
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
public static clscc_CourseChapterEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseChapterEN objcc_CourseChapterEN = null;
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
objcc_CourseChapterEN = JsonConvert.DeserializeObject<clscc_CourseChapterEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseChapterEN;
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
public static clscc_CourseChapterEN GetObjByCourseChapterId_Cache(string strCourseChapterId, string strCourseId)
{
if (string.IsNullOrEmpty(strCourseChapterId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_CourseChapterEN._CurrTabName_S, strCourseId);
List<clscc_CourseChapterEN> arrcc_CourseChapterObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clscc_CourseChapterEN> arrcc_CourseChapterObjLst_Sel =
from objcc_CourseChapterEN in arrcc_CourseChapterObjLst_Cache
where objcc_CourseChapterEN.CourseChapterId == strCourseChapterId
select objcc_CourseChapterEN;
if (arrcc_CourseChapterObjLst_Sel.Count() == 0)
{
   clscc_CourseChapterEN obj = clscc_CourseChapterWApi.GetObjByCourseChapterId(strCourseChapterId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_CourseChapterObjLst_Sel.First();
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
string strKey = string.Format("{0}_{1}", clscc_CourseChapterEN._CurrTabName_S, strCourseId);
List<clscc_CourseChapterEN> arrcc_CourseChapterObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clscc_CourseChapterEN> arrcc_CourseChapterObjLst_Sel1 =
from objcc_CourseChapterEN in arrcc_CourseChapterObjLst_Cache
where objcc_CourseChapterEN.CourseChapterId == strCourseChapterId
select objcc_CourseChapterEN;
List <clscc_CourseChapterEN> arrcc_CourseChapterObjLst_Sel = new List<clscc_CourseChapterEN>();
foreach (clscc_CourseChapterEN obj in arrcc_CourseChapterObjLst_Sel1)
{
arrcc_CourseChapterObjLst_Sel.Add(obj);
}
if (arrcc_CourseChapterObjLst_Sel.Count > 0)
{
return arrcc_CourseChapterObjLst_Sel[0].CourseChapterName;
}
string strErrMsgForGetObjById = string.Format("在cc_CourseChapter对象缓存列表中,找不到记录[CourseChapterId = {0}](函数:{1})", strCourseChapterId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clscc_CourseChapterBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
string strKey = string.Format("{0}_{1}", clscc_CourseChapterEN._CurrTabName_S, strCourseId);
List<clscc_CourseChapterEN> arrcc_CourseChapterObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clscc_CourseChapterEN> arrcc_CourseChapterObjLst_Sel1 =
from objcc_CourseChapterEN in arrcc_CourseChapterObjLst_Cache
where objcc_CourseChapterEN.CourseChapterId == strCourseChapterId
select objcc_CourseChapterEN;
List <clscc_CourseChapterEN> arrcc_CourseChapterObjLst_Sel = new List<clscc_CourseChapterEN>();
foreach (clscc_CourseChapterEN obj in arrcc_CourseChapterObjLst_Sel1)
{
arrcc_CourseChapterObjLst_Sel.Add(obj);
}
if (arrcc_CourseChapterObjLst_Sel.Count > 0)
{
return arrcc_CourseChapterObjLst_Sel[0].CourseChapterName;
}
string strErrMsgForGetObjById = string.Format("在cc_CourseChapter对象缓存列表中,找不到记录的相关名称[CourseChapterId = {0}](函数:{1})", strCourseChapterId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clscc_CourseChapterBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseChapterEN> GetObjLst(string strWhereCond)
{
 List<clscc_CourseChapterEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseChapterEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseChapterEN> GetObjLstByCourseChapterIdLst(List<string> arrCourseChapterId)
{
 List<clscc_CourseChapterEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseChapterEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clscc_CourseChapterEN> GetObjLstByCourseChapterIdLst_Cache(List<string> arrCourseChapterId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_CourseChapterEN._CurrTabName_S, strCourseId);
List<clscc_CourseChapterEN> arrcc_CourseChapterObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clscc_CourseChapterEN> arrcc_CourseChapterObjLst_Sel =
from objcc_CourseChapterEN in arrcc_CourseChapterObjLst_Cache
where arrCourseChapterId.Contains(objcc_CourseChapterEN.CourseChapterId)
select objcc_CourseChapterEN;
return arrcc_CourseChapterObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseChapterEN> GetObjLstByCourseChapterIdLst_WA_Cache(List<string> arrCourseChapterId, string strCourseId)
{
 List<clscc_CourseChapterEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseChapterEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseChapterEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_CourseChapterEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseChapterEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseChapterEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_CourseChapterEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseChapterEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseChapterEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_CourseChapterEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseChapterEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseChapterEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_CourseChapterEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseChapterEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strCourseChapterId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clscc_CourseChapterEN objcc_CourseChapterEN = clscc_CourseChapterWApi.GetObjByCourseChapterId(strCourseChapterId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strCourseChapterId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_CourseChapterWApi.ReFreshCache(objcc_CourseChapterEN.CourseId);
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int Delcc_CourseChapters(List<string> arrCourseChapterId)
{
string strAction = "Delcc_CourseChapters";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCourseChapterId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clscc_CourseChapterEN objcc_CourseChapterEN = clscc_CourseChapterWApi.GetObjByCourseChapterId(arrCourseChapterId[0]);
clscc_CourseChapterWApi.ReFreshCache(objcc_CourseChapterEN.CourseId);
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int Delcc_CourseChaptersByCond(string strWhereCond)
{
string strAction = "Delcc_CourseChaptersByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clscc_CourseChapterEN objcc_CourseChapterEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseChapterEN>(objcc_CourseChapterEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseChapterWApi.ReFreshCache(objcc_CourseChapterEN.CourseId);
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clscc_CourseChapterEN objcc_CourseChapterEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseChapterEN>(objcc_CourseChapterEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseChapterWApi.ReFreshCache(objcc_CourseChapterEN.CourseId);
var strCourseChapterId = (string)jobjReturn["ReturnStr"];
return strCourseChapterId;
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clscc_CourseChapterEN objcc_CourseChapterEN)
{
if (string.IsNullOrEmpty(objcc_CourseChapterEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseChapterEN.CourseChapterId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseChapterEN>(objcc_CourseChapterEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_CourseChapterEN objcc_CourseChapterEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_CourseChapterEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseChapterEN.CourseChapterId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseChapterEN.CourseChapterId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseChapterEN>(objcc_CourseChapterEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objcc_CourseChapterENS">源对象</param>
 /// <param name = "objcc_CourseChapterENT">目标对象</param>
 public static void CopyTo(clscc_CourseChapterEN objcc_CourseChapterENS, clscc_CourseChapterEN objcc_CourseChapterENT)
{
try
{
objcc_CourseChapterENT.CourseChapterId = objcc_CourseChapterENS.CourseChapterId; //课程章节ID
objcc_CourseChapterENT.CourseChapterName = objcc_CourseChapterENS.CourseChapterName; //课程章节名称
objcc_CourseChapterENT.ChapterId = objcc_CourseChapterENS.ChapterId; //章Id
objcc_CourseChapterENT.SectionId = objcc_CourseChapterENS.SectionId; //节Id
objcc_CourseChapterENT.ChapterName = objcc_CourseChapterENS.ChapterName; //章名
objcc_CourseChapterENT.SectionName = objcc_CourseChapterENS.SectionName; //节名
objcc_CourseChapterENT.ChapterName_Sim = objcc_CourseChapterENS.ChapterName_Sim; //章名简称
objcc_CourseChapterENT.SectionName_Sim = objcc_CourseChapterENS.SectionName_Sim; //节名简称
objcc_CourseChapterENT.ChapterContent = objcc_CourseChapterENS.ChapterContent; //章节内容
objcc_CourseChapterENT.CourseId = objcc_CourseChapterENS.CourseId; //课程Id
objcc_CourseChapterENT.ParentNodeID = objcc_CourseChapterENS.ParentNodeID; //父节点编号
objcc_CourseChapterENT.IsOpenToAllStu = objcc_CourseChapterENS.IsOpenToAllStu; //全校师生
objcc_CourseChapterENT.IsOpenToSchool = objcc_CourseChapterENS.IsOpenToSchool; //全校师生公开
objcc_CourseChapterENT.IsOpenToSocial = objcc_CourseChapterENS.IsOpenToSocial; //社会公众
objcc_CourseChapterENT.IsMustMenu = objcc_CourseChapterENS.IsMustMenu; //是否必建栏目
objcc_CourseChapterENT.ThemeName = objcc_CourseChapterENS.ThemeName; //主题名
objcc_CourseChapterENT.IsFile = objcc_CourseChapterENS.IsFile; //项目或文件夹
objcc_CourseChapterENT.IsUse = objcc_CourseChapterENS.IsUse; //是否使用
objcc_CourseChapterENT.ViewCount = objcc_CourseChapterENS.ViewCount; //浏览量
objcc_CourseChapterENT.CourseChapterReferred = objcc_CourseChapterENS.CourseChapterReferred; //节简称
objcc_CourseChapterENT.OrderNum = objcc_CourseChapterENS.OrderNum; //序号
objcc_CourseChapterENT.CreateDate = objcc_CourseChapterENS.CreateDate; //建立日期
objcc_CourseChapterENT.EditPeople = objcc_CourseChapterENS.EditPeople; //修改人
objcc_CourseChapterENT.UpdDate = objcc_CourseChapterENS.UpdDate; //修改日期
objcc_CourseChapterENT.Memo = objcc_CourseChapterENS.Memo; //备注
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
public static DataTable ToDataTable(List<clscc_CourseChapterEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_CourseChapterEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_CourseChapterEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_CourseChapterEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_CourseChapterEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_CourseChapterEN.AttributeName)
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CourseChapterId");
//if (arrcc_CourseChapterObjLst_Cache == null)
//{
//arrcc_CourseChapterObjLst_Cache = await clscc_CourseChapterWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clscc_CourseChapterEN._CurrTabName_S, strCourseId);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strCourseId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clscc_CourseChapterWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clscc_CourseChapterEN._CurrTabName_S, strCourseId);
CacheHelper.Remove(strKey);
clscc_CourseChapterWApi.objCommFun4BL.ReFreshCache(strCourseId);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseChapterEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clscc_CourseChapterEN._CurrTabName_S, strCourseId);
List<clscc_CourseChapterEN> arrcc_CourseChapterObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrcc_CourseChapterObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_CourseChapterEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_CourseChapter.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseChapter.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseChapter.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseChapter.SectionId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseChapter.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseChapter.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseChapter.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseChapter.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseChapter.ChapterContent, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseChapter.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseChapter.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseChapter.IsOpenToAllStu, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_CourseChapter.IsOpenToSchool, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_CourseChapter.IsOpenToSocial, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_CourseChapter.IsMustMenu, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_CourseChapter.ThemeName, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseChapter.IsFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_CourseChapter.IsUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_CourseChapter.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_CourseChapter.CourseChapterReferred, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseChapter.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_CourseChapter.CreateDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseChapter.EditPeople, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseChapter.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseChapter.Memo, Type.GetType("System.String"));
foreach (clscc_CourseChapterEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_CourseChapter.CourseChapterId] = objInFor[concc_CourseChapter.CourseChapterId];
objDR[concc_CourseChapter.CourseChapterName] = objInFor[concc_CourseChapter.CourseChapterName];
objDR[concc_CourseChapter.ChapterId] = objInFor[concc_CourseChapter.ChapterId];
objDR[concc_CourseChapter.SectionId] = objInFor[concc_CourseChapter.SectionId];
objDR[concc_CourseChapter.ChapterName] = objInFor[concc_CourseChapter.ChapterName];
objDR[concc_CourseChapter.SectionName] = objInFor[concc_CourseChapter.SectionName];
objDR[concc_CourseChapter.ChapterName_Sim] = objInFor[concc_CourseChapter.ChapterName_Sim];
objDR[concc_CourseChapter.SectionName_Sim] = objInFor[concc_CourseChapter.SectionName_Sim];
objDR[concc_CourseChapter.ChapterContent] = objInFor[concc_CourseChapter.ChapterContent];
objDR[concc_CourseChapter.CourseId] = objInFor[concc_CourseChapter.CourseId];
objDR[concc_CourseChapter.ParentNodeID] = objInFor[concc_CourseChapter.ParentNodeID];
objDR[concc_CourseChapter.IsOpenToAllStu] = objInFor[concc_CourseChapter.IsOpenToAllStu];
objDR[concc_CourseChapter.IsOpenToSchool] = objInFor[concc_CourseChapter.IsOpenToSchool];
objDR[concc_CourseChapter.IsOpenToSocial] = objInFor[concc_CourseChapter.IsOpenToSocial];
objDR[concc_CourseChapter.IsMustMenu] = objInFor[concc_CourseChapter.IsMustMenu];
objDR[concc_CourseChapter.ThemeName] = objInFor[concc_CourseChapter.ThemeName];
objDR[concc_CourseChapter.IsFile] = objInFor[concc_CourseChapter.IsFile];
objDR[concc_CourseChapter.IsUse] = objInFor[concc_CourseChapter.IsUse];
objDR[concc_CourseChapter.ViewCount] = objInFor[concc_CourseChapter.ViewCount];
objDR[concc_CourseChapter.CourseChapterReferred] = objInFor[concc_CourseChapter.CourseChapterReferred];
objDR[concc_CourseChapter.OrderNum] = objInFor[concc_CourseChapter.OrderNum];
objDR[concc_CourseChapter.CreateDate] = objInFor[concc_CourseChapter.CreateDate];
objDR[concc_CourseChapter.EditPeople] = objInFor[concc_CourseChapter.EditPeople];
objDR[concc_CourseChapter.UpdDate] = objInFor[concc_CourseChapter.UpdDate];
objDR[concc_CourseChapter.Memo] = objInFor[concc_CourseChapter.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 课程章节(cc_CourseChapter)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_CourseChapter : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId)
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseChapterWApi.ReFreshThisCache(strCourseId);
clsvcc_CourseChapterWApi.ReFreshThisCache(strCourseId);
clsvcc_CourseChapter4KnowledgeWApi.ReFreshThisCache(strCourseId);
clsvcc_CourseChapter4ExamLibWApi.ReFreshThisCache(strCourseId);
}
}

}