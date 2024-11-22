
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseKnowledgesBL
 表名:vcc_CourseKnowledges(01120141)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:04:19
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
public static class  clsvcc_CourseKnowledgesBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseKnowledgesEN GetObj(this K_CourseKnowledgeId_vcc_CourseKnowledges myKey)
{
clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = clsvcc_CourseKnowledgesBL.vcc_CourseKnowledgesDA.GetObjByCourseKnowledgeId(myKey.Value);
return objvcc_CourseKnowledgesEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetCourseKnowledgeId(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strCourseKnowledgeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseKnowledgeId, 8, convcc_CourseKnowledges.CourseKnowledgeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeId, 8, convcc_CourseKnowledges.CourseKnowledgeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetKnowledgeName(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strKnowledgeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKnowledgeName, convcc_CourseKnowledges.KnowledgeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeName, 100, convcc_CourseKnowledges.KnowledgeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetKnowledgeTitle(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strKnowledgeTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeTitle, 100, convcc_CourseKnowledges.KnowledgeTitle);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetCourseId(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_CourseKnowledges.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_CourseKnowledges.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetCourseCode(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convcc_CourseKnowledges.CourseCode);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetCourseName(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_CourseKnowledges.CourseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetCourseChapterId(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convcc_CourseKnowledges.CourseChapterId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_CourseKnowledges.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_CourseKnowledges.CourseChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetUserId(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convcc_CourseKnowledges.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convcc_CourseKnowledges.UserId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetChapterId(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterId, 8, convcc_CourseKnowledges.ChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convcc_CourseKnowledges.ChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetUploadDate(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strUploadDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadDate, 20, convcc_CourseKnowledges.UploadDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetSectionId(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, convcc_CourseKnowledges.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convcc_CourseKnowledges.SectionId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetChapterName(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_CourseKnowledges.ChapterName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetSectionName(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_CourseKnowledges.SectionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetLikeCount(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, long? lngLikeCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetChapterNameSim(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, convcc_CourseKnowledges.ChapterNameSim);
}
objvcc_CourseKnowledgesEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.ChapterNameSim) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.ChapterNameSim, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.ChapterNameSim] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetUpdDate(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_CourseKnowledges.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetSectionNameSim(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strSectionNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionNameSim, 10, convcc_CourseKnowledges.SectionNameSim);
}
objvcc_CourseKnowledgesEN.SectionNameSim = strSectionNameSim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(convcc_CourseKnowledges.SectionNameSim) == false)
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp.Add(convcc_CourseKnowledges.SectionNameSim, strComparisonOp);
}
else
{
objvcc_CourseKnowledgesEN.dicFldComparisonOp[convcc_CourseKnowledges.SectionNameSim] = strComparisonOp;
}
}
return objvcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetMemo(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_CourseKnowledges.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetQuestionNum(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, int? intQuestionNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetOrderNum(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, int? intOrderNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetUpdUser(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_CourseKnowledges.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetKnowledgeTypeId(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strKnowledgeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeTypeId, 4, convcc_CourseKnowledges.KnowledgeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strKnowledgeTypeId, 4, convcc_CourseKnowledges.KnowledgeTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseKnowledgesEN SetKnowledgeTypeName(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN, string strKnowledgeTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeTypeName, 50, convcc_CourseKnowledges.KnowledgeTypeName);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesENS">源对象</param>
 /// <param name = "objvcc_CourseKnowledgesENT">目标对象</param>
 public static void CopyTo(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesENS, clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesENT)
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
objvcc_CourseKnowledgesENT.ChapterNameSim = objvcc_CourseKnowledgesENS.ChapterNameSim; //章名简称
objvcc_CourseKnowledgesENT.UpdDate = objvcc_CourseKnowledgesENS.UpdDate; //修改日期
objvcc_CourseKnowledgesENT.SectionNameSim = objvcc_CourseKnowledgesENS.SectionNameSim; //节名简称
objvcc_CourseKnowledgesENT.Memo = objvcc_CourseKnowledgesENS.Memo; //备注
objvcc_CourseKnowledgesENT.QuestionNum = objvcc_CourseKnowledgesENS.QuestionNum; //题目数
objvcc_CourseKnowledgesENT.OrderNum = objvcc_CourseKnowledgesENS.OrderNum; //序号
objvcc_CourseKnowledgesENT.UpdUser = objvcc_CourseKnowledgesENS.UpdUser; //修改人
objvcc_CourseKnowledgesENT.KnowledgeTypeId = objvcc_CourseKnowledgesENS.KnowledgeTypeId; //知识点类型Id
objvcc_CourseKnowledgesENT.KnowledgeTypeName = objvcc_CourseKnowledgesENS.KnowledgeTypeName; //知识点类型名
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
 /// <param name = "objvcc_CourseKnowledgesENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseKnowledgesEN:objvcc_CourseKnowledgesENT</returns>
 public static clsvcc_CourseKnowledgesEN CopyTo(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesENS)
{
try
{
 clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesENT = new clsvcc_CourseKnowledgesEN()
{
CourseKnowledgeId = objvcc_CourseKnowledgesENS.CourseKnowledgeId, //知识点Id
KnowledgeName = objvcc_CourseKnowledgesENS.KnowledgeName, //知识点名称
KnowledgeTitle = objvcc_CourseKnowledgesENS.KnowledgeTitle, //知识点标题
KnowledgeContent = objvcc_CourseKnowledgesENS.KnowledgeContent, //知识点内容
CourseId = objvcc_CourseKnowledgesENS.CourseId, //课程Id
CourseCode = objvcc_CourseKnowledgesENS.CourseCode, //课程代码
CourseName = objvcc_CourseKnowledgesENS.CourseName, //课程名称
CourseChapterId = objvcc_CourseKnowledgesENS.CourseChapterId, //课程章节ID
UserId = objvcc_CourseKnowledgesENS.UserId, //用户ID
ChapterId = objvcc_CourseKnowledgesENS.ChapterId, //章Id
UploadDate = objvcc_CourseKnowledgesENS.UploadDate, //上传时间
SectionId = objvcc_CourseKnowledgesENS.SectionId, //节Id
IsShow = objvcc_CourseKnowledgesENS.IsShow, //是否启用
ChapterName = objvcc_CourseKnowledgesENS.ChapterName, //章名
IsCast = objvcc_CourseKnowledgesENS.IsCast, //是否播放
SectionName = objvcc_CourseKnowledgesENS.SectionName, //节名
LikeCount = objvcc_CourseKnowledgesENS.LikeCount, //资源喜欢数量
ChapterNameSim = objvcc_CourseKnowledgesENS.ChapterNameSim, //章名简称
UpdDate = objvcc_CourseKnowledgesENS.UpdDate, //修改日期
SectionNameSim = objvcc_CourseKnowledgesENS.SectionNameSim, //节名简称
Memo = objvcc_CourseKnowledgesENS.Memo, //备注
QuestionNum = objvcc_CourseKnowledgesENS.QuestionNum, //题目数
OrderNum = objvcc_CourseKnowledgesENS.OrderNum, //序号
UpdUser = objvcc_CourseKnowledgesENS.UpdUser, //修改人
KnowledgeTypeId = objvcc_CourseKnowledgesENS.KnowledgeTypeId, //知识点类型Id
KnowledgeTypeName = objvcc_CourseKnowledgesENS.KnowledgeTypeName, //知识点类型名
};
 return objvcc_CourseKnowledgesENT;
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
public static void CheckProperty4Condition(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN)
{
 clsvcc_CourseKnowledgesBL.vcc_CourseKnowledgesDA.CheckProperty4Condition(objvcc_CourseKnowledgesEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.CourseKnowledgeId) == true)
{
string strComparisonOpCourseKnowledgeId = objvcc_CourseKnowledgesCond.dicFldComparisonOp[convcc_CourseKnowledges.CourseKnowledgeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.CourseKnowledgeId, objvcc_CourseKnowledgesCond.CourseKnowledgeId, strComparisonOpCourseKnowledgeId);
}
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.KnowledgeName) == true)
{
string strComparisonOpKnowledgeName = objvcc_CourseKnowledgesCond.dicFldComparisonOp[convcc_CourseKnowledges.KnowledgeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.KnowledgeName, objvcc_CourseKnowledgesCond.KnowledgeName, strComparisonOpKnowledgeName);
}
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.KnowledgeTitle) == true)
{
string strComparisonOpKnowledgeTitle = objvcc_CourseKnowledgesCond.dicFldComparisonOp[convcc_CourseKnowledges.KnowledgeTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.KnowledgeTitle, objvcc_CourseKnowledgesCond.KnowledgeTitle, strComparisonOpKnowledgeTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_CourseKnowledgesCond.dicFldComparisonOp[convcc_CourseKnowledges.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.CourseId, objvcc_CourseKnowledgesCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.CourseCode) == true)
{
string strComparisonOpCourseCode = objvcc_CourseKnowledgesCond.dicFldComparisonOp[convcc_CourseKnowledges.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.CourseCode, objvcc_CourseKnowledgesCond.CourseCode, strComparisonOpCourseCode);
}
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.CourseName) == true)
{
string strComparisonOpCourseName = objvcc_CourseKnowledgesCond.dicFldComparisonOp[convcc_CourseKnowledges.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.CourseName, objvcc_CourseKnowledgesCond.CourseName, strComparisonOpCourseName);
}
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvcc_CourseKnowledgesCond.dicFldComparisonOp[convcc_CourseKnowledges.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.CourseChapterId, objvcc_CourseKnowledgesCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.UserId) == true)
{
string strComparisonOpUserId = objvcc_CourseKnowledgesCond.dicFldComparisonOp[convcc_CourseKnowledges.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.UserId, objvcc_CourseKnowledgesCond.UserId, strComparisonOpUserId);
}
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.ChapterId) == true)
{
string strComparisonOpChapterId = objvcc_CourseKnowledgesCond.dicFldComparisonOp[convcc_CourseKnowledges.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.ChapterId, objvcc_CourseKnowledgesCond.ChapterId, strComparisonOpChapterId);
}
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.UploadDate) == true)
{
string strComparisonOpUploadDate = objvcc_CourseKnowledgesCond.dicFldComparisonOp[convcc_CourseKnowledges.UploadDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.UploadDate, objvcc_CourseKnowledgesCond.UploadDate, strComparisonOpUploadDate);
}
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.SectionId) == true)
{
string strComparisonOpSectionId = objvcc_CourseKnowledgesCond.dicFldComparisonOp[convcc_CourseKnowledges.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.SectionId, objvcc_CourseKnowledgesCond.SectionId, strComparisonOpSectionId);
}
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.IsShow) == true)
{
if (objvcc_CourseKnowledgesCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseKnowledges.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseKnowledges.IsShow);
}
}
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.ChapterName) == true)
{
string strComparisonOpChapterName = objvcc_CourseKnowledgesCond.dicFldComparisonOp[convcc_CourseKnowledges.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.ChapterName, objvcc_CourseKnowledgesCond.ChapterName, strComparisonOpChapterName);
}
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.IsCast) == true)
{
if (objvcc_CourseKnowledgesCond.IsCast == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseKnowledges.IsCast);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseKnowledges.IsCast);
}
}
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.SectionName) == true)
{
string strComparisonOpSectionName = objvcc_CourseKnowledgesCond.dicFldComparisonOp[convcc_CourseKnowledges.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.SectionName, objvcc_CourseKnowledgesCond.SectionName, strComparisonOpSectionName);
}
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.LikeCount) == true)
{
string strComparisonOpLikeCount = objvcc_CourseKnowledgesCond.dicFldComparisonOp[convcc_CourseKnowledges.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseKnowledges.LikeCount, objvcc_CourseKnowledgesCond.LikeCount, strComparisonOpLikeCount);
}
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objvcc_CourseKnowledgesCond.dicFldComparisonOp[convcc_CourseKnowledges.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.ChapterNameSim, objvcc_CourseKnowledgesCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_CourseKnowledgesCond.dicFldComparisonOp[convcc_CourseKnowledges.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.UpdDate, objvcc_CourseKnowledgesCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.SectionNameSim) == true)
{
string strComparisonOpSectionNameSim = objvcc_CourseKnowledgesCond.dicFldComparisonOp[convcc_CourseKnowledges.SectionNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.SectionNameSim, objvcc_CourseKnowledgesCond.SectionNameSim, strComparisonOpSectionNameSim);
}
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.Memo) == true)
{
string strComparisonOpMemo = objvcc_CourseKnowledgesCond.dicFldComparisonOp[convcc_CourseKnowledges.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.Memo, objvcc_CourseKnowledgesCond.Memo, strComparisonOpMemo);
}
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.QuestionNum) == true)
{
string strComparisonOpQuestionNum = objvcc_CourseKnowledgesCond.dicFldComparisonOp[convcc_CourseKnowledges.QuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseKnowledges.QuestionNum, objvcc_CourseKnowledgesCond.QuestionNum, strComparisonOpQuestionNum);
}
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.OrderNum) == true)
{
string strComparisonOpOrderNum = objvcc_CourseKnowledgesCond.dicFldComparisonOp[convcc_CourseKnowledges.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseKnowledges.OrderNum, objvcc_CourseKnowledgesCond.OrderNum, strComparisonOpOrderNum);
}
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.UpdUser) == true)
{
string strComparisonOpUpdUser = objvcc_CourseKnowledgesCond.dicFldComparisonOp[convcc_CourseKnowledges.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.UpdUser, objvcc_CourseKnowledgesCond.UpdUser, strComparisonOpUpdUser);
}
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.KnowledgeTypeId) == true)
{
string strComparisonOpKnowledgeTypeId = objvcc_CourseKnowledgesCond.dicFldComparisonOp[convcc_CourseKnowledges.KnowledgeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.KnowledgeTypeId, objvcc_CourseKnowledgesCond.KnowledgeTypeId, strComparisonOpKnowledgeTypeId);
}
if (objvcc_CourseKnowledgesCond.IsUpdated(convcc_CourseKnowledges.KnowledgeTypeName) == true)
{
string strComparisonOpKnowledgeTypeName = objvcc_CourseKnowledgesCond.dicFldComparisonOp[convcc_CourseKnowledges.KnowledgeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseKnowledges.KnowledgeTypeName, objvcc_CourseKnowledgesCond.KnowledgeTypeName, strComparisonOpKnowledgeTypeName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_CourseKnowledges
{
public virtual bool UpdRelaTabDate(string strCourseKnowledgeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v课程知识点(vcc_CourseKnowledges)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseKnowledgesBL
{
public static RelatedActions_vcc_CourseKnowledges relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_CourseKnowledgesDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_CourseKnowledgesDA vcc_CourseKnowledgesDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_CourseKnowledgesDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_CourseKnowledgesBL()
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
if (string.IsNullOrEmpty(clsvcc_CourseKnowledgesEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_CourseKnowledgesEN._ConnectString);
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
public static DataTable GetDataTable_vcc_CourseKnowledges(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_CourseKnowledgesDA.GetDataTable_vcc_CourseKnowledges(strWhereCond);
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
objDT = vcc_CourseKnowledgesDA.GetDataTable(strWhereCond);
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
objDT = vcc_CourseKnowledgesDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_CourseKnowledgesDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_CourseKnowledgesDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_CourseKnowledgesDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_CourseKnowledgesDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_CourseKnowledgesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_CourseKnowledgesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCourseKnowledgeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcc_CourseKnowledgesEN> GetObjLstByCourseKnowledgeIdLst(List<string> arrCourseKnowledgeIdLst)
{
List<clsvcc_CourseKnowledgesEN> arrObjLst = new List<clsvcc_CourseKnowledgesEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCourseKnowledgeIdLst, true);
 string strWhereCond = string.Format("CourseKnowledgeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = new clsvcc_CourseKnowledgesEN();
try
{
objvcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[convcc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_CourseKnowledgesEN.KnowledgeName = objRow[convcc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_CourseKnowledgesEN.KnowledgeTitle = objRow[convcc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_CourseKnowledgesEN.KnowledgeContent = objRow[convcc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_CourseKnowledgesEN.CourseId = objRow[convcc_CourseKnowledges.CourseId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objvcc_CourseKnowledgesEN.CourseCode = objRow[convcc_CourseKnowledges.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseKnowledgesEN.CourseName = objRow[convcc_CourseKnowledges.CourseName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseName].ToString().Trim(); //课程名称
objvcc_CourseKnowledgesEN.CourseChapterId = objRow[convcc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseKnowledgesEN.UserId = objRow[convcc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objvcc_CourseKnowledgesEN.ChapterId = objRow[convcc_CourseKnowledges.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterId].ToString().Trim(); //章Id
objvcc_CourseKnowledgesEN.UploadDate = objRow[convcc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objvcc_CourseKnowledgesEN.SectionId = objRow[convcc_CourseKnowledges.SectionId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionId].ToString().Trim(); //节Id
objvcc_CourseKnowledgesEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objvcc_CourseKnowledgesEN.ChapterName = objRow[convcc_CourseKnowledges.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterName].ToString().Trim(); //章名
objvcc_CourseKnowledgesEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objvcc_CourseKnowledgesEN.SectionName = objRow[convcc_CourseKnowledges.SectionName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionName].ToString().Trim(); //节名
objvcc_CourseKnowledgesEN.LikeCount = objRow[convcc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseKnowledgesEN.ChapterNameSim = objRow[convcc_CourseKnowledges.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseKnowledgesEN.UpdDate = objRow[convcc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseKnowledgesEN.SectionNameSim = objRow[convcc_CourseKnowledges.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseKnowledgesEN.Memo = objRow[convcc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.Memo].ToString().Trim(); //备注
objvcc_CourseKnowledgesEN.QuestionNum = objRow[convcc_CourseKnowledges.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseKnowledgesEN.OrderNum = objRow[convcc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objvcc_CourseKnowledgesEN.UpdUser = objRow[convcc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objvcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[convcc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objvcc_CourseKnowledgesEN.KnowledgeTypeName = objRow[convcc_CourseKnowledges.KnowledgeTypeName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeName].ToString().Trim(); //知识点类型名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseKnowledgesEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseKnowledgesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCourseKnowledgeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_CourseKnowledgesEN> GetObjLstByCourseKnowledgeIdLstCache(List<string> arrCourseKnowledgeIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvcc_CourseKnowledgesEN._CurrTabName, strCourseId);
List<clsvcc_CourseKnowledgesEN> arrvcc_CourseKnowledgesObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseKnowledgesEN> arrvcc_CourseKnowledgesObjLst_Sel =
arrvcc_CourseKnowledgesObjLstCache
.Where(x => arrCourseKnowledgeIdLst.Contains(x.CourseKnowledgeId));
return arrvcc_CourseKnowledgesObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseKnowledgesEN> GetObjLst(string strWhereCond)
{
List<clsvcc_CourseKnowledgesEN> arrObjLst = new List<clsvcc_CourseKnowledgesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = new clsvcc_CourseKnowledgesEN();
try
{
objvcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[convcc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_CourseKnowledgesEN.KnowledgeName = objRow[convcc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_CourseKnowledgesEN.KnowledgeTitle = objRow[convcc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_CourseKnowledgesEN.KnowledgeContent = objRow[convcc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_CourseKnowledgesEN.CourseId = objRow[convcc_CourseKnowledges.CourseId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objvcc_CourseKnowledgesEN.CourseCode = objRow[convcc_CourseKnowledges.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseKnowledgesEN.CourseName = objRow[convcc_CourseKnowledges.CourseName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseName].ToString().Trim(); //课程名称
objvcc_CourseKnowledgesEN.CourseChapterId = objRow[convcc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseKnowledgesEN.UserId = objRow[convcc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objvcc_CourseKnowledgesEN.ChapterId = objRow[convcc_CourseKnowledges.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterId].ToString().Trim(); //章Id
objvcc_CourseKnowledgesEN.UploadDate = objRow[convcc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objvcc_CourseKnowledgesEN.SectionId = objRow[convcc_CourseKnowledges.SectionId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionId].ToString().Trim(); //节Id
objvcc_CourseKnowledgesEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objvcc_CourseKnowledgesEN.ChapterName = objRow[convcc_CourseKnowledges.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterName].ToString().Trim(); //章名
objvcc_CourseKnowledgesEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objvcc_CourseKnowledgesEN.SectionName = objRow[convcc_CourseKnowledges.SectionName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionName].ToString().Trim(); //节名
objvcc_CourseKnowledgesEN.LikeCount = objRow[convcc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseKnowledgesEN.ChapterNameSim = objRow[convcc_CourseKnowledges.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseKnowledgesEN.UpdDate = objRow[convcc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseKnowledgesEN.SectionNameSim = objRow[convcc_CourseKnowledges.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseKnowledgesEN.Memo = objRow[convcc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.Memo].ToString().Trim(); //备注
objvcc_CourseKnowledgesEN.QuestionNum = objRow[convcc_CourseKnowledges.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseKnowledgesEN.OrderNum = objRow[convcc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objvcc_CourseKnowledgesEN.UpdUser = objRow[convcc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objvcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[convcc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objvcc_CourseKnowledgesEN.KnowledgeTypeName = objRow[convcc_CourseKnowledges.KnowledgeTypeName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeName].ToString().Trim(); //知识点类型名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseKnowledgesEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseKnowledgesEN);
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
public static List<clsvcc_CourseKnowledgesEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseKnowledgesEN> arrObjLst = new List<clsvcc_CourseKnowledgesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = new clsvcc_CourseKnowledgesEN();
try
{
objvcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[convcc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_CourseKnowledgesEN.KnowledgeName = objRow[convcc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_CourseKnowledgesEN.KnowledgeTitle = objRow[convcc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_CourseKnowledgesEN.KnowledgeContent = objRow[convcc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_CourseKnowledgesEN.CourseId = objRow[convcc_CourseKnowledges.CourseId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objvcc_CourseKnowledgesEN.CourseCode = objRow[convcc_CourseKnowledges.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseKnowledgesEN.CourseName = objRow[convcc_CourseKnowledges.CourseName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseName].ToString().Trim(); //课程名称
objvcc_CourseKnowledgesEN.CourseChapterId = objRow[convcc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseKnowledgesEN.UserId = objRow[convcc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objvcc_CourseKnowledgesEN.ChapterId = objRow[convcc_CourseKnowledges.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterId].ToString().Trim(); //章Id
objvcc_CourseKnowledgesEN.UploadDate = objRow[convcc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objvcc_CourseKnowledgesEN.SectionId = objRow[convcc_CourseKnowledges.SectionId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionId].ToString().Trim(); //节Id
objvcc_CourseKnowledgesEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objvcc_CourseKnowledgesEN.ChapterName = objRow[convcc_CourseKnowledges.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterName].ToString().Trim(); //章名
objvcc_CourseKnowledgesEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objvcc_CourseKnowledgesEN.SectionName = objRow[convcc_CourseKnowledges.SectionName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionName].ToString().Trim(); //节名
objvcc_CourseKnowledgesEN.LikeCount = objRow[convcc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseKnowledgesEN.ChapterNameSim = objRow[convcc_CourseKnowledges.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseKnowledgesEN.UpdDate = objRow[convcc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseKnowledgesEN.SectionNameSim = objRow[convcc_CourseKnowledges.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseKnowledgesEN.Memo = objRow[convcc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.Memo].ToString().Trim(); //备注
objvcc_CourseKnowledgesEN.QuestionNum = objRow[convcc_CourseKnowledges.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseKnowledgesEN.OrderNum = objRow[convcc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objvcc_CourseKnowledgesEN.UpdUser = objRow[convcc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objvcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[convcc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objvcc_CourseKnowledgesEN.KnowledgeTypeName = objRow[convcc_CourseKnowledges.KnowledgeTypeName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeName].ToString().Trim(); //知识点类型名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseKnowledgesEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseKnowledgesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_CourseKnowledgesEN> GetSubObjLstCache(clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesCond)
{
 string strCourseId = objvcc_CourseKnowledgesCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvcc_CourseKnowledgesBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvcc_CourseKnowledgesEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseKnowledgesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseKnowledges.AttributeName)
{
if (objvcc_CourseKnowledgesCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseKnowledgesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseKnowledgesCond[strFldName].ToString());
}
else
{
if (objvcc_CourseKnowledgesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseKnowledgesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseKnowledgesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseKnowledgesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseKnowledgesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseKnowledgesCond[strFldName]));
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
public static List<clsvcc_CourseKnowledgesEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_CourseKnowledgesEN> arrObjLst = new List<clsvcc_CourseKnowledgesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = new clsvcc_CourseKnowledgesEN();
try
{
objvcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[convcc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_CourseKnowledgesEN.KnowledgeName = objRow[convcc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_CourseKnowledgesEN.KnowledgeTitle = objRow[convcc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_CourseKnowledgesEN.KnowledgeContent = objRow[convcc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_CourseKnowledgesEN.CourseId = objRow[convcc_CourseKnowledges.CourseId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objvcc_CourseKnowledgesEN.CourseCode = objRow[convcc_CourseKnowledges.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseKnowledgesEN.CourseName = objRow[convcc_CourseKnowledges.CourseName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseName].ToString().Trim(); //课程名称
objvcc_CourseKnowledgesEN.CourseChapterId = objRow[convcc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseKnowledgesEN.UserId = objRow[convcc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objvcc_CourseKnowledgesEN.ChapterId = objRow[convcc_CourseKnowledges.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterId].ToString().Trim(); //章Id
objvcc_CourseKnowledgesEN.UploadDate = objRow[convcc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objvcc_CourseKnowledgesEN.SectionId = objRow[convcc_CourseKnowledges.SectionId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionId].ToString().Trim(); //节Id
objvcc_CourseKnowledgesEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objvcc_CourseKnowledgesEN.ChapterName = objRow[convcc_CourseKnowledges.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterName].ToString().Trim(); //章名
objvcc_CourseKnowledgesEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objvcc_CourseKnowledgesEN.SectionName = objRow[convcc_CourseKnowledges.SectionName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionName].ToString().Trim(); //节名
objvcc_CourseKnowledgesEN.LikeCount = objRow[convcc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseKnowledgesEN.ChapterNameSim = objRow[convcc_CourseKnowledges.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseKnowledgesEN.UpdDate = objRow[convcc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseKnowledgesEN.SectionNameSim = objRow[convcc_CourseKnowledges.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseKnowledgesEN.Memo = objRow[convcc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.Memo].ToString().Trim(); //备注
objvcc_CourseKnowledgesEN.QuestionNum = objRow[convcc_CourseKnowledges.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseKnowledgesEN.OrderNum = objRow[convcc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objvcc_CourseKnowledgesEN.UpdUser = objRow[convcc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objvcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[convcc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objvcc_CourseKnowledgesEN.KnowledgeTypeName = objRow[convcc_CourseKnowledges.KnowledgeTypeName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeName].ToString().Trim(); //知识点类型名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseKnowledgesEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseKnowledgesEN);
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
public static List<clsvcc_CourseKnowledgesEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_CourseKnowledgesEN> arrObjLst = new List<clsvcc_CourseKnowledgesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = new clsvcc_CourseKnowledgesEN();
try
{
objvcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[convcc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_CourseKnowledgesEN.KnowledgeName = objRow[convcc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_CourseKnowledgesEN.KnowledgeTitle = objRow[convcc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_CourseKnowledgesEN.KnowledgeContent = objRow[convcc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_CourseKnowledgesEN.CourseId = objRow[convcc_CourseKnowledges.CourseId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objvcc_CourseKnowledgesEN.CourseCode = objRow[convcc_CourseKnowledges.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseKnowledgesEN.CourseName = objRow[convcc_CourseKnowledges.CourseName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseName].ToString().Trim(); //课程名称
objvcc_CourseKnowledgesEN.CourseChapterId = objRow[convcc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseKnowledgesEN.UserId = objRow[convcc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objvcc_CourseKnowledgesEN.ChapterId = objRow[convcc_CourseKnowledges.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterId].ToString().Trim(); //章Id
objvcc_CourseKnowledgesEN.UploadDate = objRow[convcc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objvcc_CourseKnowledgesEN.SectionId = objRow[convcc_CourseKnowledges.SectionId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionId].ToString().Trim(); //节Id
objvcc_CourseKnowledgesEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objvcc_CourseKnowledgesEN.ChapterName = objRow[convcc_CourseKnowledges.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterName].ToString().Trim(); //章名
objvcc_CourseKnowledgesEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objvcc_CourseKnowledgesEN.SectionName = objRow[convcc_CourseKnowledges.SectionName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionName].ToString().Trim(); //节名
objvcc_CourseKnowledgesEN.LikeCount = objRow[convcc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseKnowledgesEN.ChapterNameSim = objRow[convcc_CourseKnowledges.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseKnowledgesEN.UpdDate = objRow[convcc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseKnowledgesEN.SectionNameSim = objRow[convcc_CourseKnowledges.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseKnowledgesEN.Memo = objRow[convcc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.Memo].ToString().Trim(); //备注
objvcc_CourseKnowledgesEN.QuestionNum = objRow[convcc_CourseKnowledges.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseKnowledgesEN.OrderNum = objRow[convcc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objvcc_CourseKnowledgesEN.UpdUser = objRow[convcc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objvcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[convcc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objvcc_CourseKnowledgesEN.KnowledgeTypeName = objRow[convcc_CourseKnowledges.KnowledgeTypeName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeName].ToString().Trim(); //知识点类型名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseKnowledgesEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseKnowledgesEN);
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
List<clsvcc_CourseKnowledgesEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_CourseKnowledgesEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseKnowledgesEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_CourseKnowledgesEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseKnowledgesEN> arrObjLst = new List<clsvcc_CourseKnowledgesEN>(); 
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
	clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = new clsvcc_CourseKnowledgesEN();
try
{
objvcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[convcc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_CourseKnowledgesEN.KnowledgeName = objRow[convcc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_CourseKnowledgesEN.KnowledgeTitle = objRow[convcc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_CourseKnowledgesEN.KnowledgeContent = objRow[convcc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_CourseKnowledgesEN.CourseId = objRow[convcc_CourseKnowledges.CourseId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objvcc_CourseKnowledgesEN.CourseCode = objRow[convcc_CourseKnowledges.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseKnowledgesEN.CourseName = objRow[convcc_CourseKnowledges.CourseName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseName].ToString().Trim(); //课程名称
objvcc_CourseKnowledgesEN.CourseChapterId = objRow[convcc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseKnowledgesEN.UserId = objRow[convcc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objvcc_CourseKnowledgesEN.ChapterId = objRow[convcc_CourseKnowledges.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterId].ToString().Trim(); //章Id
objvcc_CourseKnowledgesEN.UploadDate = objRow[convcc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objvcc_CourseKnowledgesEN.SectionId = objRow[convcc_CourseKnowledges.SectionId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionId].ToString().Trim(); //节Id
objvcc_CourseKnowledgesEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objvcc_CourseKnowledgesEN.ChapterName = objRow[convcc_CourseKnowledges.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterName].ToString().Trim(); //章名
objvcc_CourseKnowledgesEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objvcc_CourseKnowledgesEN.SectionName = objRow[convcc_CourseKnowledges.SectionName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionName].ToString().Trim(); //节名
objvcc_CourseKnowledgesEN.LikeCount = objRow[convcc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseKnowledgesEN.ChapterNameSim = objRow[convcc_CourseKnowledges.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseKnowledgesEN.UpdDate = objRow[convcc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseKnowledgesEN.SectionNameSim = objRow[convcc_CourseKnowledges.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseKnowledgesEN.Memo = objRow[convcc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.Memo].ToString().Trim(); //备注
objvcc_CourseKnowledgesEN.QuestionNum = objRow[convcc_CourseKnowledges.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseKnowledgesEN.OrderNum = objRow[convcc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objvcc_CourseKnowledgesEN.UpdUser = objRow[convcc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objvcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[convcc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objvcc_CourseKnowledgesEN.KnowledgeTypeName = objRow[convcc_CourseKnowledges.KnowledgeTypeName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeName].ToString().Trim(); //知识点类型名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseKnowledgesEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseKnowledgesEN);
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
public static List<clsvcc_CourseKnowledgesEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseKnowledgesEN> arrObjLst = new List<clsvcc_CourseKnowledgesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = new clsvcc_CourseKnowledgesEN();
try
{
objvcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[convcc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_CourseKnowledgesEN.KnowledgeName = objRow[convcc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_CourseKnowledgesEN.KnowledgeTitle = objRow[convcc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_CourseKnowledgesEN.KnowledgeContent = objRow[convcc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_CourseKnowledgesEN.CourseId = objRow[convcc_CourseKnowledges.CourseId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objvcc_CourseKnowledgesEN.CourseCode = objRow[convcc_CourseKnowledges.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseKnowledgesEN.CourseName = objRow[convcc_CourseKnowledges.CourseName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseName].ToString().Trim(); //课程名称
objvcc_CourseKnowledgesEN.CourseChapterId = objRow[convcc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseKnowledgesEN.UserId = objRow[convcc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objvcc_CourseKnowledgesEN.ChapterId = objRow[convcc_CourseKnowledges.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterId].ToString().Trim(); //章Id
objvcc_CourseKnowledgesEN.UploadDate = objRow[convcc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objvcc_CourseKnowledgesEN.SectionId = objRow[convcc_CourseKnowledges.SectionId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionId].ToString().Trim(); //节Id
objvcc_CourseKnowledgesEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objvcc_CourseKnowledgesEN.ChapterName = objRow[convcc_CourseKnowledges.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterName].ToString().Trim(); //章名
objvcc_CourseKnowledgesEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objvcc_CourseKnowledgesEN.SectionName = objRow[convcc_CourseKnowledges.SectionName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionName].ToString().Trim(); //节名
objvcc_CourseKnowledgesEN.LikeCount = objRow[convcc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseKnowledgesEN.ChapterNameSim = objRow[convcc_CourseKnowledges.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseKnowledgesEN.UpdDate = objRow[convcc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseKnowledgesEN.SectionNameSim = objRow[convcc_CourseKnowledges.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseKnowledgesEN.Memo = objRow[convcc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.Memo].ToString().Trim(); //备注
objvcc_CourseKnowledgesEN.QuestionNum = objRow[convcc_CourseKnowledges.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseKnowledgesEN.OrderNum = objRow[convcc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objvcc_CourseKnowledgesEN.UpdUser = objRow[convcc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objvcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[convcc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objvcc_CourseKnowledgesEN.KnowledgeTypeName = objRow[convcc_CourseKnowledges.KnowledgeTypeName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeName].ToString().Trim(); //知识点类型名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseKnowledgesEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseKnowledgesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_CourseKnowledgesEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_CourseKnowledgesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseKnowledgesEN> arrObjLst = new List<clsvcc_CourseKnowledgesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = new clsvcc_CourseKnowledgesEN();
try
{
objvcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[convcc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_CourseKnowledgesEN.KnowledgeName = objRow[convcc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_CourseKnowledgesEN.KnowledgeTitle = objRow[convcc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_CourseKnowledgesEN.KnowledgeContent = objRow[convcc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_CourseKnowledgesEN.CourseId = objRow[convcc_CourseKnowledges.CourseId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objvcc_CourseKnowledgesEN.CourseCode = objRow[convcc_CourseKnowledges.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseKnowledgesEN.CourseName = objRow[convcc_CourseKnowledges.CourseName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseName].ToString().Trim(); //课程名称
objvcc_CourseKnowledgesEN.CourseChapterId = objRow[convcc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseKnowledgesEN.UserId = objRow[convcc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objvcc_CourseKnowledgesEN.ChapterId = objRow[convcc_CourseKnowledges.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterId].ToString().Trim(); //章Id
objvcc_CourseKnowledgesEN.UploadDate = objRow[convcc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objvcc_CourseKnowledgesEN.SectionId = objRow[convcc_CourseKnowledges.SectionId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionId].ToString().Trim(); //节Id
objvcc_CourseKnowledgesEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objvcc_CourseKnowledgesEN.ChapterName = objRow[convcc_CourseKnowledges.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterName].ToString().Trim(); //章名
objvcc_CourseKnowledgesEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objvcc_CourseKnowledgesEN.SectionName = objRow[convcc_CourseKnowledges.SectionName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionName].ToString().Trim(); //节名
objvcc_CourseKnowledgesEN.LikeCount = objRow[convcc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseKnowledgesEN.ChapterNameSim = objRow[convcc_CourseKnowledges.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseKnowledgesEN.UpdDate = objRow[convcc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseKnowledgesEN.SectionNameSim = objRow[convcc_CourseKnowledges.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseKnowledgesEN.Memo = objRow[convcc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.Memo].ToString().Trim(); //备注
objvcc_CourseKnowledgesEN.QuestionNum = objRow[convcc_CourseKnowledges.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseKnowledgesEN.OrderNum = objRow[convcc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objvcc_CourseKnowledgesEN.UpdUser = objRow[convcc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objvcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[convcc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objvcc_CourseKnowledgesEN.KnowledgeTypeName = objRow[convcc_CourseKnowledges.KnowledgeTypeName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeName].ToString().Trim(); //知识点类型名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseKnowledgesEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseKnowledgesEN);
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
public static List<clsvcc_CourseKnowledgesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_CourseKnowledgesEN> arrObjLst = new List<clsvcc_CourseKnowledgesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = new clsvcc_CourseKnowledgesEN();
try
{
objvcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[convcc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_CourseKnowledgesEN.KnowledgeName = objRow[convcc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_CourseKnowledgesEN.KnowledgeTitle = objRow[convcc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_CourseKnowledgesEN.KnowledgeContent = objRow[convcc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_CourseKnowledgesEN.CourseId = objRow[convcc_CourseKnowledges.CourseId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objvcc_CourseKnowledgesEN.CourseCode = objRow[convcc_CourseKnowledges.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseKnowledgesEN.CourseName = objRow[convcc_CourseKnowledges.CourseName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseName].ToString().Trim(); //课程名称
objvcc_CourseKnowledgesEN.CourseChapterId = objRow[convcc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseKnowledgesEN.UserId = objRow[convcc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objvcc_CourseKnowledgesEN.ChapterId = objRow[convcc_CourseKnowledges.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterId].ToString().Trim(); //章Id
objvcc_CourseKnowledgesEN.UploadDate = objRow[convcc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objvcc_CourseKnowledgesEN.SectionId = objRow[convcc_CourseKnowledges.SectionId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionId].ToString().Trim(); //节Id
objvcc_CourseKnowledgesEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objvcc_CourseKnowledgesEN.ChapterName = objRow[convcc_CourseKnowledges.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterName].ToString().Trim(); //章名
objvcc_CourseKnowledgesEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objvcc_CourseKnowledgesEN.SectionName = objRow[convcc_CourseKnowledges.SectionName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionName].ToString().Trim(); //节名
objvcc_CourseKnowledgesEN.LikeCount = objRow[convcc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseKnowledgesEN.ChapterNameSim = objRow[convcc_CourseKnowledges.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseKnowledgesEN.UpdDate = objRow[convcc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseKnowledgesEN.SectionNameSim = objRow[convcc_CourseKnowledges.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseKnowledgesEN.Memo = objRow[convcc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.Memo].ToString().Trim(); //备注
objvcc_CourseKnowledgesEN.QuestionNum = objRow[convcc_CourseKnowledges.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseKnowledgesEN.OrderNum = objRow[convcc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objvcc_CourseKnowledgesEN.UpdUser = objRow[convcc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objvcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[convcc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objvcc_CourseKnowledgesEN.KnowledgeTypeName = objRow[convcc_CourseKnowledges.KnowledgeTypeName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeName].ToString().Trim(); //知识点类型名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseKnowledgesEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseKnowledgesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseKnowledgesEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_CourseKnowledgesEN> arrObjLst = new List<clsvcc_CourseKnowledgesEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = new clsvcc_CourseKnowledgesEN();
try
{
objvcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[convcc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_CourseKnowledgesEN.KnowledgeName = objRow[convcc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_CourseKnowledgesEN.KnowledgeTitle = objRow[convcc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_CourseKnowledgesEN.KnowledgeContent = objRow[convcc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_CourseKnowledgesEN.CourseId = objRow[convcc_CourseKnowledges.CourseId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objvcc_CourseKnowledgesEN.CourseCode = objRow[convcc_CourseKnowledges.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseKnowledgesEN.CourseName = objRow[convcc_CourseKnowledges.CourseName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseName].ToString().Trim(); //课程名称
objvcc_CourseKnowledgesEN.CourseChapterId = objRow[convcc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseKnowledgesEN.UserId = objRow[convcc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objvcc_CourseKnowledgesEN.ChapterId = objRow[convcc_CourseKnowledges.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterId].ToString().Trim(); //章Id
objvcc_CourseKnowledgesEN.UploadDate = objRow[convcc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objvcc_CourseKnowledgesEN.SectionId = objRow[convcc_CourseKnowledges.SectionId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionId].ToString().Trim(); //节Id
objvcc_CourseKnowledgesEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objvcc_CourseKnowledgesEN.ChapterName = objRow[convcc_CourseKnowledges.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterName].ToString().Trim(); //章名
objvcc_CourseKnowledgesEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objvcc_CourseKnowledgesEN.SectionName = objRow[convcc_CourseKnowledges.SectionName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionName].ToString().Trim(); //节名
objvcc_CourseKnowledgesEN.LikeCount = objRow[convcc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseKnowledgesEN.ChapterNameSim = objRow[convcc_CourseKnowledges.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseKnowledgesEN.UpdDate = objRow[convcc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseKnowledgesEN.SectionNameSim = objRow[convcc_CourseKnowledges.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseKnowledgesEN.Memo = objRow[convcc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.Memo].ToString().Trim(); //备注
objvcc_CourseKnowledgesEN.QuestionNum = objRow[convcc_CourseKnowledges.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseKnowledgesEN.OrderNum = objRow[convcc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objvcc_CourseKnowledgesEN.UpdUser = objRow[convcc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objvcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[convcc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objvcc_CourseKnowledgesEN.KnowledgeTypeName = objRow[convcc_CourseKnowledges.KnowledgeTypeName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeName].ToString().Trim(); //知识点类型名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseKnowledgesEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseKnowledgesEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_CourseKnowledges(ref clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN)
{
bool bolResult = vcc_CourseKnowledgesDA.Getvcc_CourseKnowledges(ref objvcc_CourseKnowledgesEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseKnowledgesEN GetObjByCourseKnowledgeId(string strCourseKnowledgeId)
{
if (strCourseKnowledgeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCourseKnowledgeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCourseKnowledgeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCourseKnowledgeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = vcc_CourseKnowledgesDA.GetObjByCourseKnowledgeId(strCourseKnowledgeId);
return objvcc_CourseKnowledgesEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_CourseKnowledgesEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = vcc_CourseKnowledgesDA.GetFirstObj(strWhereCond);
 return objvcc_CourseKnowledgesEN;
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
public static clsvcc_CourseKnowledgesEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = vcc_CourseKnowledgesDA.GetObjByDataRow(objRow);
 return objvcc_CourseKnowledgesEN;
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
public static clsvcc_CourseKnowledgesEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = vcc_CourseKnowledgesDA.GetObjByDataRow(objRow);
 return objvcc_CourseKnowledgesEN;
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
 /// <param name = "strCourseKnowledgeId">所给的关键字</param>
 /// <param name = "lstvcc_CourseKnowledgesObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseKnowledgesEN GetObjByCourseKnowledgeIdFromList(string strCourseKnowledgeId, List<clsvcc_CourseKnowledgesEN> lstvcc_CourseKnowledgesObjLst)
{
foreach (clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN in lstvcc_CourseKnowledgesObjLst)
{
if (objvcc_CourseKnowledgesEN.CourseKnowledgeId == strCourseKnowledgeId)
{
return objvcc_CourseKnowledgesEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxCourseKnowledgeId;
 try
 {
 strMaxCourseKnowledgeId = clsvcc_CourseKnowledgesDA.GetMaxStrId();
 return strMaxCourseKnowledgeId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strCourseKnowledgeId;
 try
 {
 strCourseKnowledgeId = new clsvcc_CourseKnowledgesDA().GetFirstID(strWhereCond);
 return strCourseKnowledgeId;
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
 arrList = vcc_CourseKnowledgesDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_CourseKnowledgesDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCourseKnowledgeId)
{
if (string.IsNullOrEmpty(strCourseKnowledgeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCourseKnowledgeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vcc_CourseKnowledgesDA.IsExist(strCourseKnowledgeId);
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
 bolIsExist = clsvcc_CourseKnowledgesDA.IsExistTable();
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
 bolIsExist = vcc_CourseKnowledgesDA.IsExistTable(strTabName);
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
objvcc_CourseKnowledgesENT.ChapterNameSim = objvcc_CourseKnowledgesENS.ChapterNameSim; //章名简称
objvcc_CourseKnowledgesENT.UpdDate = objvcc_CourseKnowledgesENS.UpdDate; //修改日期
objvcc_CourseKnowledgesENT.SectionNameSim = objvcc_CourseKnowledgesENS.SectionNameSim; //节名简称
objvcc_CourseKnowledgesENT.Memo = objvcc_CourseKnowledgesENS.Memo; //备注
objvcc_CourseKnowledgesENT.QuestionNum = objvcc_CourseKnowledgesENS.QuestionNum; //题目数
objvcc_CourseKnowledgesENT.OrderNum = objvcc_CourseKnowledgesENS.OrderNum; //序号
objvcc_CourseKnowledgesENT.UpdUser = objvcc_CourseKnowledgesENS.UpdUser; //修改人
objvcc_CourseKnowledgesENT.KnowledgeTypeId = objvcc_CourseKnowledgesENS.KnowledgeTypeId; //知识点类型Id
objvcc_CourseKnowledgesENT.KnowledgeTypeName = objvcc_CourseKnowledgesENS.KnowledgeTypeName; //知识点类型名
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
 /// <param name = "objvcc_CourseKnowledgesEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN)
{
try
{
objvcc_CourseKnowledgesEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_CourseKnowledgesEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_CourseKnowledges.CourseKnowledgeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.CourseKnowledgeId = objvcc_CourseKnowledgesEN.CourseKnowledgeId; //知识点Id
}
if (arrFldSet.Contains(convcc_CourseKnowledges.KnowledgeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.KnowledgeName = objvcc_CourseKnowledgesEN.KnowledgeName; //知识点名称
}
if (arrFldSet.Contains(convcc_CourseKnowledges.KnowledgeTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.KnowledgeTitle = objvcc_CourseKnowledgesEN.KnowledgeTitle == "[null]" ? null :  objvcc_CourseKnowledgesEN.KnowledgeTitle; //知识点标题
}
if (arrFldSet.Contains(convcc_CourseKnowledges.KnowledgeContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.KnowledgeContent = objvcc_CourseKnowledgesEN.KnowledgeContent == "[null]" ? null :  objvcc_CourseKnowledgesEN.KnowledgeContent; //知识点内容
}
if (arrFldSet.Contains(convcc_CourseKnowledges.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.CourseId = objvcc_CourseKnowledgesEN.CourseId == "[null]" ? null :  objvcc_CourseKnowledgesEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_CourseKnowledges.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.CourseCode = objvcc_CourseKnowledgesEN.CourseCode == "[null]" ? null :  objvcc_CourseKnowledgesEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convcc_CourseKnowledges.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.CourseName = objvcc_CourseKnowledgesEN.CourseName == "[null]" ? null :  objvcc_CourseKnowledgesEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convcc_CourseKnowledges.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.CourseChapterId = objvcc_CourseKnowledgesEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convcc_CourseKnowledges.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.UserId = objvcc_CourseKnowledgesEN.UserId; //用户ID
}
if (arrFldSet.Contains(convcc_CourseKnowledges.ChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.ChapterId = objvcc_CourseKnowledgesEN.ChapterId == "[null]" ? null :  objvcc_CourseKnowledgesEN.ChapterId; //章Id
}
if (arrFldSet.Contains(convcc_CourseKnowledges.UploadDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.UploadDate = objvcc_CourseKnowledgesEN.UploadDate == "[null]" ? null :  objvcc_CourseKnowledgesEN.UploadDate; //上传时间
}
if (arrFldSet.Contains(convcc_CourseKnowledges.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.SectionId = objvcc_CourseKnowledgesEN.SectionId == "[null]" ? null :  objvcc_CourseKnowledgesEN.SectionId; //节Id
}
if (arrFldSet.Contains(convcc_CourseKnowledges.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.IsShow = objvcc_CourseKnowledgesEN.IsShow; //是否启用
}
if (arrFldSet.Contains(convcc_CourseKnowledges.ChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.ChapterName = objvcc_CourseKnowledgesEN.ChapterName == "[null]" ? null :  objvcc_CourseKnowledgesEN.ChapterName; //章名
}
if (arrFldSet.Contains(convcc_CourseKnowledges.IsCast, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.IsCast = objvcc_CourseKnowledgesEN.IsCast; //是否播放
}
if (arrFldSet.Contains(convcc_CourseKnowledges.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.SectionName = objvcc_CourseKnowledgesEN.SectionName == "[null]" ? null :  objvcc_CourseKnowledgesEN.SectionName; //节名
}
if (arrFldSet.Contains(convcc_CourseKnowledges.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.LikeCount = objvcc_CourseKnowledgesEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(convcc_CourseKnowledges.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.ChapterNameSim = objvcc_CourseKnowledgesEN.ChapterNameSim == "[null]" ? null :  objvcc_CourseKnowledgesEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(convcc_CourseKnowledges.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.UpdDate = objvcc_CourseKnowledgesEN.UpdDate == "[null]" ? null :  objvcc_CourseKnowledgesEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_CourseKnowledges.SectionNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.SectionNameSim = objvcc_CourseKnowledgesEN.SectionNameSim == "[null]" ? null :  objvcc_CourseKnowledgesEN.SectionNameSim; //节名简称
}
if (arrFldSet.Contains(convcc_CourseKnowledges.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.Memo = objvcc_CourseKnowledgesEN.Memo == "[null]" ? null :  objvcc_CourseKnowledgesEN.Memo; //备注
}
if (arrFldSet.Contains(convcc_CourseKnowledges.QuestionNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.QuestionNum = objvcc_CourseKnowledgesEN.QuestionNum; //题目数
}
if (arrFldSet.Contains(convcc_CourseKnowledges.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.OrderNum = objvcc_CourseKnowledgesEN.OrderNum; //序号
}
if (arrFldSet.Contains(convcc_CourseKnowledges.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.UpdUser = objvcc_CourseKnowledgesEN.UpdUser == "[null]" ? null :  objvcc_CourseKnowledgesEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convcc_CourseKnowledges.KnowledgeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.KnowledgeTypeId = objvcc_CourseKnowledgesEN.KnowledgeTypeId == "[null]" ? null :  objvcc_CourseKnowledgesEN.KnowledgeTypeId; //知识点类型Id
}
if (arrFldSet.Contains(convcc_CourseKnowledges.KnowledgeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseKnowledgesEN.KnowledgeTypeName = objvcc_CourseKnowledgesEN.KnowledgeTypeName == "[null]" ? null :  objvcc_CourseKnowledgesEN.KnowledgeTypeName; //知识点类型名
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
 /// <param name = "objvcc_CourseKnowledgesEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN)
{
try
{
if (objvcc_CourseKnowledgesEN.KnowledgeTitle == "[null]") objvcc_CourseKnowledgesEN.KnowledgeTitle = null; //知识点标题
if (objvcc_CourseKnowledgesEN.KnowledgeContent == "[null]") objvcc_CourseKnowledgesEN.KnowledgeContent = null; //知识点内容
if (objvcc_CourseKnowledgesEN.CourseId == "[null]") objvcc_CourseKnowledgesEN.CourseId = null; //课程Id
if (objvcc_CourseKnowledgesEN.CourseCode == "[null]") objvcc_CourseKnowledgesEN.CourseCode = null; //课程代码
if (objvcc_CourseKnowledgesEN.CourseName == "[null]") objvcc_CourseKnowledgesEN.CourseName = null; //课程名称
if (objvcc_CourseKnowledgesEN.ChapterId == "[null]") objvcc_CourseKnowledgesEN.ChapterId = null; //章Id
if (objvcc_CourseKnowledgesEN.UploadDate == "[null]") objvcc_CourseKnowledgesEN.UploadDate = null; //上传时间
if (objvcc_CourseKnowledgesEN.SectionId == "[null]") objvcc_CourseKnowledgesEN.SectionId = null; //节Id
if (objvcc_CourseKnowledgesEN.ChapterName == "[null]") objvcc_CourseKnowledgesEN.ChapterName = null; //章名
if (objvcc_CourseKnowledgesEN.SectionName == "[null]") objvcc_CourseKnowledgesEN.SectionName = null; //节名
if (objvcc_CourseKnowledgesEN.ChapterNameSim == "[null]") objvcc_CourseKnowledgesEN.ChapterNameSim = null; //章名简称
if (objvcc_CourseKnowledgesEN.UpdDate == "[null]") objvcc_CourseKnowledgesEN.UpdDate = null; //修改日期
if (objvcc_CourseKnowledgesEN.SectionNameSim == "[null]") objvcc_CourseKnowledgesEN.SectionNameSim = null; //节名简称
if (objvcc_CourseKnowledgesEN.Memo == "[null]") objvcc_CourseKnowledgesEN.Memo = null; //备注
if (objvcc_CourseKnowledgesEN.UpdUser == "[null]") objvcc_CourseKnowledgesEN.UpdUser = null; //修改人
if (objvcc_CourseKnowledgesEN.KnowledgeTypeId == "[null]") objvcc_CourseKnowledgesEN.KnowledgeTypeId = null; //知识点类型Id
if (objvcc_CourseKnowledgesEN.KnowledgeTypeName == "[null]") objvcc_CourseKnowledgesEN.KnowledgeTypeName = null; //知识点类型名
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
public static void CheckProperty4Condition(clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN)
{
 vcc_CourseKnowledgesDA.CheckProperty4Condition(objvcc_CourseKnowledgesEN);
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
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseKnowledgesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseKnowledgesBL没有刷新缓存机制(clscc_CourseKnowledgesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsKnowledgeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsKnowledgeTypeBL没有刷新缓存机制(clsKnowledgeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by CourseKnowledgeId");
//if (arrvcc_CourseKnowledgesObjLstCache == null)
//{
//arrvcc_CourseKnowledgesObjLstCache = vcc_CourseKnowledgesDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseKnowledgesEN GetObjByCourseKnowledgeIdCache(string strCourseKnowledgeId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseKnowledgesEN._CurrTabName, strCourseId);
List<clsvcc_CourseKnowledgesEN> arrvcc_CourseKnowledgesObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseKnowledgesEN> arrvcc_CourseKnowledgesObjLst_Sel =
arrvcc_CourseKnowledgesObjLstCache
.Where(x=> x.CourseKnowledgeId == strCourseKnowledgeId 
);
if (arrvcc_CourseKnowledgesObjLst_Sel.Count() == 0)
{
   clsvcc_CourseKnowledgesEN obj = clsvcc_CourseKnowledgesBL.GetObjByCourseKnowledgeId(strCourseKnowledgeId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strCourseKnowledgeId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvcc_CourseKnowledgesObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseKnowledgesEN> GetAllvcc_CourseKnowledgesObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvcc_CourseKnowledgesEN> arrvcc_CourseKnowledgesObjLstCache = GetObjLstCache(strCourseId); 
return arrvcc_CourseKnowledgesObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseKnowledgesEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseKnowledgesEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvcc_CourseKnowledgesEN> arrvcc_CourseKnowledgesObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvcc_CourseKnowledgesObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseKnowledgesEN._CurrTabName, strCourseId);
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
public static string Func(string strInFldName, string strOutFldName, string strCourseKnowledgeId, string strCourseId)
{
if (strInFldName != convcc_CourseKnowledges.CourseKnowledgeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_CourseKnowledges.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_CourseKnowledges.AttributeName));
throw new Exception(strMsg);
}
var objvcc_CourseKnowledges = clsvcc_CourseKnowledgesBL.GetObjByCourseKnowledgeIdCache(strCourseKnowledgeId, strCourseId);
if (objvcc_CourseKnowledges == null) return "";
return objvcc_CourseKnowledges[strOutFldName].ToString();
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
int intRecCount = clsvcc_CourseKnowledgesDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_CourseKnowledgesDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_CourseKnowledgesDA.GetRecCount();
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
int intRecCount = clsvcc_CourseKnowledgesDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesCond)
{
 string strCourseId = objvcc_CourseKnowledgesCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvcc_CourseKnowledgesBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvcc_CourseKnowledgesEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseKnowledgesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseKnowledges.AttributeName)
{
if (objvcc_CourseKnowledgesCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseKnowledgesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseKnowledgesCond[strFldName].ToString());
}
else
{
if (objvcc_CourseKnowledgesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseKnowledgesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseKnowledgesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseKnowledgesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseKnowledgesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseKnowledgesCond[strFldName]));
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
 List<string> arrList = clsvcc_CourseKnowledgesDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseKnowledgesDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseKnowledgesDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}