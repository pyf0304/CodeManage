
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseKnowledgesWApi
 表名:vcc_CourseKnowledges(01120141)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:19
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
public static class clsvcc_CourseKnowledgesWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetCourseKnowledgeId(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strCourseKnowledgeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseKnowledgeId, 8, convcc_CourseKnowledges.CourseKnowledgeId);
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeId, 8, convcc_CourseKnowledges.CourseKnowledgeId);
objvcc_CourseKnowledgesEN.CourseKnowledgeId = strCourseKnowledgeId; //知识点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.CourseKnowledgeId) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.CourseKnowledgeId, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.CourseKnowledgeId] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetKnowledgeName(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strKnowledgeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKnowledgeName, convcc_CourseKnowledges.KnowledgeName);
clsCheckSql.CheckFieldLen(strKnowledgeName, 100, convcc_CourseKnowledges.KnowledgeName);
objvcc_CourseKnowledgesEN.KnowledgeName = strKnowledgeName; //知识点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.KnowledgeName) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.KnowledgeName, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.KnowledgeName] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetKnowledgeTitle(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strKnowledgeTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKnowledgeTitle, 100, convcc_CourseKnowledges.KnowledgeTitle);
objvcc_CourseKnowledgesEN.KnowledgeTitle = strKnowledgeTitle; //知识点标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.KnowledgeTitle) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.KnowledgeTitle, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.KnowledgeTitle] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetKnowledgeContent(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strKnowledgeContent, string strComparisonOp="")
	{
objvcc_CourseKnowledgesEN.KnowledgeContent = strKnowledgeContent; //知识点内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.KnowledgeContent) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.KnowledgeContent, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.KnowledgeContent] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetCourseId(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_CourseKnowledges.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_CourseKnowledges.CourseId);
objvcc_CourseKnowledgesEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.CourseId) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.CourseId, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.CourseId] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetCourseCode(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convcc_CourseKnowledges.CourseCode);
objvcc_CourseKnowledgesEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.CourseCode) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.CourseCode, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.CourseCode] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetCourseName(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_CourseKnowledges.CourseName);
objvcc_CourseKnowledgesEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.CourseName) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.CourseName, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.CourseName] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetCourseChapterId(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convcc_CourseKnowledges.CourseChapterId);
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_CourseKnowledges.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_CourseKnowledges.CourseChapterId);
objvcc_CourseKnowledgesEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.CourseChapterId) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.CourseChapterId, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.CourseChapterId] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetUserId(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convcc_CourseKnowledges.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, convcc_CourseKnowledges.UserId);
objvcc_CourseKnowledgesEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.UserId) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.UserId, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.UserId] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetChapterId(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, convcc_CourseKnowledges.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convcc_CourseKnowledges.ChapterId);
objvcc_CourseKnowledgesEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.ChapterId) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.ChapterId, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.ChapterId] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetUploadDate(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strUploadDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUploadDate, 20, convcc_CourseKnowledges.UploadDate);
objvcc_CourseKnowledgesEN.UploadDate = strUploadDate; //上传时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.UploadDate) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.UploadDate, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.UploadDate] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetSectionId(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionId, 8, convcc_CourseKnowledges.SectionId);
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convcc_CourseKnowledges.SectionId);
objvcc_CourseKnowledgesEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.SectionId) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.SectionId, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.SectionId] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetIsShow(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, bool bolIsShow, string strComparisonOp="")
	{
objvcc_CourseKnowledgesEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.IsShow) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.IsShow, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.IsShow] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetChapterName(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_CourseKnowledges.ChapterName);
objvcc_CourseKnowledgesEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.ChapterName) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.ChapterName, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.ChapterName] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetIsCast(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, bool bolIsCast, string strComparisonOp="")
	{
objvcc_CourseKnowledgesEN.IsCast = bolIsCast; //是否播放
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.IsCast) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.IsCast, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.IsCast] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetSectionName(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_CourseKnowledges.SectionName);
objvcc_CourseKnowledgesEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.SectionName) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.SectionName, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.SectionName] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetLikeCount(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, long lngLikeCount, string strComparisonOp="")
	{
objvcc_CourseKnowledgesEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.LikeCount) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.LikeCount, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.LikeCount] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetChapterName_Sim(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convcc_CourseKnowledges.ChapterName_Sim);
objvcc_CourseKnowledgesEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.ChapterName_Sim) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.ChapterName_Sim, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.ChapterName_Sim] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetUpdDate(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_CourseKnowledges.UpdDate);
objvcc_CourseKnowledgesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.UpdDate) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.UpdDate, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.UpdDate] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetSectionName_Sim(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convcc_CourseKnowledges.SectionName_Sim);
objvcc_CourseKnowledgesEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.SectionName_Sim) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.SectionName_Sim, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.SectionName_Sim] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetMemo(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_CourseKnowledges.Memo);
objvcc_CourseKnowledgesEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.Memo) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.Memo, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.Memo] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetQuestionNum(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, int intQuestionNum, string strComparisonOp="")
	{
objvcc_CourseKnowledgesEN.QuestionNum = intQuestionNum; //题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.QuestionNum) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.QuestionNum, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.QuestionNum] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetOrderNum(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, int intOrderNum, string strComparisonOp="")
	{
objvcc_CourseKnowledgesEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.OrderNum) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.OrderNum, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.OrderNum] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetUpdUser(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_CourseKnowledges.UpdUser);
objvcc_CourseKnowledgesEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.UpdUser) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.UpdUser, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.UpdUser] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetKnowledgeTypeId(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strKnowledgeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKnowledgeTypeId, 4, convcc_CourseKnowledges.KnowledgeTypeId);
clsCheckSql.CheckFieldForeignKey(strKnowledgeTypeId, 4, convcc_CourseKnowledges.KnowledgeTypeId);
objvcc_CourseKnowledgesEN.KnowledgeTypeId = strKnowledgeTypeId; //知识点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.KnowledgeTypeId) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.KnowledgeTypeId, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.KnowledgeTypeId] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetKnowledgeTypeName(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strKnowledgeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKnowledgeTypeName, 50, convcc_CourseKnowledges.KnowledgeTypeName);
objvcc_CourseKnowledgesEN.KnowledgeTypeName = strKnowledgeTypeName; //知识点类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.KnowledgeTypeName) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.KnowledgeTypeName, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.KnowledgeTypeName] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledges_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.CourseKnowledgeId) == true)
{
string strComparisonOp_CourseKnowledgeId = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[convcc_CourseKnowledges.CourseKnowledgeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.CourseKnowledgeId, objvcc_CourseKnowledges_Cond.CourseKnowledgeId, strComparisonOp_CourseKnowledgeId);
}
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.KnowledgeName) == true)
{
string strComparisonOp_KnowledgeName = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[convcc_CourseKnowledges.KnowledgeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.KnowledgeName, objvcc_CourseKnowledges_Cond.KnowledgeName, strComparisonOp_KnowledgeName);
}
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.KnowledgeTitle) == true)
{
string strComparisonOp_KnowledgeTitle = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[convcc_CourseKnowledges.KnowledgeTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.KnowledgeTitle, objvcc_CourseKnowledges_Cond.KnowledgeTitle, strComparisonOp_KnowledgeTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[convcc_CourseKnowledges.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.CourseId, objvcc_CourseKnowledges_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[convcc_CourseKnowledges.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.CourseCode, objvcc_CourseKnowledges_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[convcc_CourseKnowledges.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.CourseName, objvcc_CourseKnowledges_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[convcc_CourseKnowledges.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.CourseChapterId, objvcc_CourseKnowledges_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.UserId) == true)
{
string strComparisonOp_UserId = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[convcc_CourseKnowledges.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.UserId, objvcc_CourseKnowledges_Cond.UserId, strComparisonOp_UserId);
}
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.ChapterId) == true)
{
string strComparisonOp_ChapterId = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[convcc_CourseKnowledges.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.ChapterId, objvcc_CourseKnowledges_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.UploadDate) == true)
{
string strComparisonOp_UploadDate = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[convcc_CourseKnowledges.UploadDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.UploadDate, objvcc_CourseKnowledges_Cond.UploadDate, strComparisonOp_UploadDate);
}
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.SectionId) == true)
{
string strComparisonOp_SectionId = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[convcc_CourseKnowledges.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.SectionId, objvcc_CourseKnowledges_Cond.SectionId, strComparisonOp_SectionId);
}
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.IsShow) == true)
{
if (objvcc_CourseKnowledges_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseKnowledges.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseKnowledges.IsShow);
}
}
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[convcc_CourseKnowledges.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.ChapterName, objvcc_CourseKnowledges_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.IsCast) == true)
{
if (objvcc_CourseKnowledges_Cond.IsCast == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseKnowledges.IsCast);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseKnowledges.IsCast);
}
}
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.SectionName) == true)
{
string strComparisonOp_SectionName = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[convcc_CourseKnowledges.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.SectionName, objvcc_CourseKnowledges_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[convcc_CourseKnowledges.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseKnowledges.LikeCount, objvcc_CourseKnowledges_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[convcc_CourseKnowledges.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.ChapterName_Sim, objvcc_CourseKnowledges_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[convcc_CourseKnowledges.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.UpdDate, objvcc_CourseKnowledges_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[convcc_CourseKnowledges.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.SectionName_Sim, objvcc_CourseKnowledges_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.Memo) == true)
{
string strComparisonOp_Memo = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[convcc_CourseKnowledges.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.Memo, objvcc_CourseKnowledges_Cond.Memo, strComparisonOp_Memo);
}
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.QuestionNum) == true)
{
string strComparisonOp_QuestionNum = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[convcc_CourseKnowledges.QuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseKnowledges.QuestionNum, objvcc_CourseKnowledges_Cond.QuestionNum, strComparisonOp_QuestionNum);
}
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[convcc_CourseKnowledges.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseKnowledges.OrderNum, objvcc_CourseKnowledges_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[convcc_CourseKnowledges.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.UpdUser, objvcc_CourseKnowledges_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.KnowledgeTypeId) == true)
{
string strComparisonOp_KnowledgeTypeId = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[convcc_CourseKnowledges.KnowledgeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.KnowledgeTypeId, objvcc_CourseKnowledges_Cond.KnowledgeTypeId, strComparisonOp_KnowledgeTypeId);
}
if (objvcc_CourseKnowledges_Cond.IsUpdated(convcc_CourseKnowledges.KnowledgeTypeName) == true)
{
string strComparisonOp_KnowledgeTypeName = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[convcc_CourseKnowledges.KnowledgeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.KnowledgeTypeName, objvcc_CourseKnowledges_Cond.KnowledgeTypeName, strComparisonOp_KnowledgeTypeName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课程知识点(vcc_CourseKnowledges)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseKnowledgesWApi
{
private static readonly string mstrApiControllerName = "vcc_CourseKnowledgesApi";

 public clsvcc_CourseKnowledgesWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseKnowledgesEN GetObjByCourseKnowledgeId(string strCourseKnowledgeId)
{
string strAction = "GetObjByCourseKnowledgeId";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseKnowledgeId"] = strCourseKnowledgeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_CourseKnowledgesEN = JsonConvert.DeserializeObject<clsvcc_CourseKnowledgesEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseKnowledgesEN;
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
 /// <param name = "strCourseKnowledgeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseKnowledgesEN GetObjByCourseKnowledgeId_WA_Cache(string strCourseKnowledgeId, string strCourseId)
{
string strAction = "GetObjByCourseKnowledgeId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseKnowledgeId"] = strCourseKnowledgeId,
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_CourseKnowledgesEN = JsonConvert.DeserializeObject<clsvcc_CourseKnowledgesEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseKnowledgesEN;
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
public static clsvcc_CourseKnowledgesEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = null;
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
objvcc_CourseKnowledgesEN = JsonConvert.DeserializeObject<clsvcc_CourseKnowledgesEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseKnowledgesEN;
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
 /// <param name = "strCourseKnowledgeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseKnowledgesEN GetObjByCourseKnowledgeId_Cache(string strCourseKnowledgeId, string strCourseId)
{
if (string.IsNullOrEmpty(strCourseKnowledgeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_CourseKnowledgesEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseKnowledgesEN> arrvcc_CourseKnowledgesObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_CourseKnowledgesEN> arrvcc_CourseKnowledgesObjLst_Sel =
from objvcc_CourseKnowledgesEN in arrvcc_CourseKnowledgesObjLst_Cache
where objvcc_CourseKnowledgesEN.CourseKnowledgeId == strCourseKnowledgeId
select objvcc_CourseKnowledgesEN;
if (arrvcc_CourseKnowledgesObjLst_Sel.Count() == 0)
{
   clsvcc_CourseKnowledgesEN obj = clsvcc_CourseKnowledgesWApi.GetObjByCourseKnowledgeId(strCourseKnowledgeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_CourseKnowledgesObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseKnowledgesEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_CourseKnowledgesEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseKnowledgesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseKnowledgesEN> GetObjLstByCourseKnowledgeIdLst(List<string> arrCourseKnowledgeId)
{
 List<clsvcc_CourseKnowledgesEN> arrObjLst = null; 
string strAction = "GetObjLstByCourseKnowledgeIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCourseKnowledgeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseKnowledgesEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strCourseKnowledgeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_CourseKnowledgesEN> GetObjLstByCourseKnowledgeIdLst_Cache(List<string> arrCourseKnowledgeId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_CourseKnowledgesEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseKnowledgesEN> arrvcc_CourseKnowledgesObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_CourseKnowledgesEN> arrvcc_CourseKnowledgesObjLst_Sel =
from objvcc_CourseKnowledgesEN in arrvcc_CourseKnowledgesObjLst_Cache
where arrCourseKnowledgeId.Contains(objvcc_CourseKnowledgesEN.CourseKnowledgeId)
select objvcc_CourseKnowledgesEN;
return arrvcc_CourseKnowledgesObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseKnowledgesEN> GetObjLstByCourseKnowledgeIdLst_WA_Cache(List<string> arrCourseKnowledgeId, string strCourseId)
{
 List<clsvcc_CourseKnowledgesEN> arrObjLst = null; 
string strAction = "GetObjLstByCourseKnowledgeIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCourseKnowledgeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseKnowledgesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseKnowledgesEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_CourseKnowledgesEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseKnowledgesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseKnowledgesEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_CourseKnowledgesEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseKnowledgesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseKnowledgesEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseKnowledgesEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseKnowledgesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseKnowledgesEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseKnowledgesEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseKnowledgesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strCourseKnowledgeId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseKnowledgeId"] = strCourseKnowledgeId
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
 /// <param name = "objvcc_CourseKnowledgesENS">源对象</param>
 /// <param name = "objvcc_CourseKnowledgesENT">目标对象</param>
 public static void CopyTo(clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesENS, clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesENT)
{
try
{
objvcc_CourseKnowledgesENT.CourseKnowledgeId = objvcc_CourseKnowledgesENS.CourseKnowledgeId; //知识点Id
objvcc_CourseKnowledgesENT.KnowledgeName = objvcc_CourseKnowledgesENS.KnowledgeName; //知识点名称
objvcc_CourseKnowledgesENT.KnowledgeTitle = objvcc_CourseKnowledgesENS.KnowledgeTitle; //知识点标题
objvcc_CourseKnowledgesENT.KnowledgeContent = objvcc_CourseKnowledgesENS.KnowledgeContent; //知识点内容
objvcc_CourseKnowledgesENT.CourseId = objvcc_CourseKnowledgesENS.CourseId; //课程Id
objvcc_CourseKnowledgesENT.CourseCode = objvcc_CourseKnowledgesENS.CourseCode; //课程代码
objvcc_CourseKnowledgesENT.CourseName = objvcc_CourseKnowledgesENS.CourseName; //课程名称
objvcc_CourseKnowledgesENT.CourseChapterId = objvcc_CourseKnowledgesENS.CourseChapterId; //课程章节ID
objvcc_CourseKnowledgesENT.UserId = objvcc_CourseKnowledgesENS.UserId; //用户ID
objvcc_CourseKnowledgesENT.ChapterId = objvcc_CourseKnowledgesENS.ChapterId; //章Id
objvcc_CourseKnowledgesENT.UploadDate = objvcc_CourseKnowledgesENS.UploadDate; //上传时间
objvcc_CourseKnowledgesENT.SectionId = objvcc_CourseKnowledgesENS.SectionId; //节Id
objvcc_CourseKnowledgesENT.IsShow = objvcc_CourseKnowledgesENS.IsShow; //是否启用
objvcc_CourseKnowledgesENT.ChapterName = objvcc_CourseKnowledgesENS.ChapterName; //章名
objvcc_CourseKnowledgesENT.IsCast = objvcc_CourseKnowledgesENS.IsCast; //是否播放
objvcc_CourseKnowledgesENT.SectionName = objvcc_CourseKnowledgesENS.SectionName; //节名
objvcc_CourseKnowledgesENT.LikeCount = objvcc_CourseKnowledgesENS.LikeCount; //资源喜欢数量
objvcc_CourseKnowledgesENT.ChapterName_Sim = objvcc_CourseKnowledgesENS.ChapterName_Sim; //章名简称
objvcc_CourseKnowledgesENT.UpdDate = objvcc_CourseKnowledgesENS.UpdDate; //修改日期
objvcc_CourseKnowledgesENT.SectionName_Sim = objvcc_CourseKnowledgesENS.SectionName_Sim; //节名简称
objvcc_CourseKnowledgesENT.Memo = objvcc_CourseKnowledgesENS.Memo; //备注
objvcc_CourseKnowledgesENT.QuestionNum = objvcc_CourseKnowledgesENS.QuestionNum; //题目数
objvcc_CourseKnowledgesENT.OrderNum = objvcc_CourseKnowledgesENS.OrderNum; //序号
objvcc_CourseKnowledgesENT.UpdUser = objvcc_CourseKnowledgesENS.UpdUser; //修改人
objvcc_CourseKnowledgesENT.KnowledgeTypeId = objvcc_CourseKnowledgesENS.KnowledgeTypeId; //知识点类型Id
objvcc_CourseKnowledgesENT.KnowledgeTypeName = objvcc_CourseKnowledgesENS.KnowledgeTypeName; //知识点类型名
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
public static DataTable ToDataTable(List<clsvcc_CourseKnowledgesEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_CourseKnowledgesEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_CourseKnowledgesEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_CourseKnowledgesEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_CourseKnowledgesEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_CourseKnowledgesEN.AttributeName)
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
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseKnowledgesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseKnowledgesWApi没有刷新缓存机制(clscc_CourseKnowledgesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsKnowledgeTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsKnowledgeTypeWApi没有刷新缓存机制(clsKnowledgeTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by CourseKnowledgeId");
//if (arrvcc_CourseKnowledgesObjLst_Cache == null)
//{
//arrvcc_CourseKnowledgesObjLst_Cache = await clsvcc_CourseKnowledgesWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseKnowledgesEN._CurrTabName_S, strCourseId);
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
public static List<clsvcc_CourseKnowledgesEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_CourseKnowledgesEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseKnowledgesEN> arrvcc_CourseKnowledgesObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvcc_CourseKnowledgesObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_CourseKnowledgesEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_CourseKnowledges.CourseKnowledgeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseKnowledges.KnowledgeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseKnowledges.KnowledgeTitle, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseKnowledges.KnowledgeContent, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseKnowledges.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseKnowledges.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseKnowledges.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseKnowledges.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseKnowledges.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseKnowledges.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseKnowledges.UploadDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseKnowledges.SectionId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseKnowledges.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseKnowledges.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseKnowledges.IsCast, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseKnowledges.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseKnowledges.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_CourseKnowledges.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseKnowledges.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseKnowledges.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseKnowledges.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseKnowledges.QuestionNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseKnowledges.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseKnowledges.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseKnowledges.KnowledgeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseKnowledges.KnowledgeTypeName, Type.GetType("System.String"));
foreach (clsvcc_CourseKnowledgesEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_CourseKnowledges.CourseKnowledgeId] = objInFor[convcc_CourseKnowledges.CourseKnowledgeId];
objDR[convcc_CourseKnowledges.KnowledgeName] = objInFor[convcc_CourseKnowledges.KnowledgeName];
objDR[convcc_CourseKnowledges.KnowledgeTitle] = objInFor[convcc_CourseKnowledges.KnowledgeTitle];
objDR[convcc_CourseKnowledges.KnowledgeContent] = objInFor[convcc_CourseKnowledges.KnowledgeContent];
objDR[convcc_CourseKnowledges.CourseId] = objInFor[convcc_CourseKnowledges.CourseId];
objDR[convcc_CourseKnowledges.CourseCode] = objInFor[convcc_CourseKnowledges.CourseCode];
objDR[convcc_CourseKnowledges.CourseName] = objInFor[convcc_CourseKnowledges.CourseName];
objDR[convcc_CourseKnowledges.CourseChapterId] = objInFor[convcc_CourseKnowledges.CourseChapterId];
objDR[convcc_CourseKnowledges.UserId] = objInFor[convcc_CourseKnowledges.UserId];
objDR[convcc_CourseKnowledges.ChapterId] = objInFor[convcc_CourseKnowledges.ChapterId];
objDR[convcc_CourseKnowledges.UploadDate] = objInFor[convcc_CourseKnowledges.UploadDate];
objDR[convcc_CourseKnowledges.SectionId] = objInFor[convcc_CourseKnowledges.SectionId];
objDR[convcc_CourseKnowledges.IsShow] = objInFor[convcc_CourseKnowledges.IsShow];
objDR[convcc_CourseKnowledges.ChapterName] = objInFor[convcc_CourseKnowledges.ChapterName];
objDR[convcc_CourseKnowledges.IsCast] = objInFor[convcc_CourseKnowledges.IsCast];
objDR[convcc_CourseKnowledges.SectionName] = objInFor[convcc_CourseKnowledges.SectionName];
objDR[convcc_CourseKnowledges.LikeCount] = objInFor[convcc_CourseKnowledges.LikeCount];
objDR[convcc_CourseKnowledges.ChapterName_Sim] = objInFor[convcc_CourseKnowledges.ChapterName_Sim];
objDR[convcc_CourseKnowledges.UpdDate] = objInFor[convcc_CourseKnowledges.UpdDate];
objDR[convcc_CourseKnowledges.SectionName_Sim] = objInFor[convcc_CourseKnowledges.SectionName_Sim];
objDR[convcc_CourseKnowledges.Memo] = objInFor[convcc_CourseKnowledges.Memo];
objDR[convcc_CourseKnowledges.QuestionNum] = objInFor[convcc_CourseKnowledges.QuestionNum];
objDR[convcc_CourseKnowledges.OrderNum] = objInFor[convcc_CourseKnowledges.OrderNum];
objDR[convcc_CourseKnowledges.UpdUser] = objInFor[convcc_CourseKnowledges.UpdUser];
objDR[convcc_CourseKnowledges.KnowledgeTypeId] = objInFor[convcc_CourseKnowledges.KnowledgeTypeId];
objDR[convcc_CourseKnowledges.KnowledgeTypeName] = objInFor[convcc_CourseKnowledges.KnowledgeTypeName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}