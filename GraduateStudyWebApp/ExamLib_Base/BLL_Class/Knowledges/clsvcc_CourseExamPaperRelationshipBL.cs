
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseExamPaperRelationshipBL
 表名:vcc_CourseExamPaperRelationship(01120075)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:29:25
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
public static class  clsvcc_CourseExamPaperRelationshipBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseExamPaperRelationshipEN GetObj(this K_mId_vcc_CourseExamPaperRelationship myKey)
{
clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = clsvcc_CourseExamPaperRelationshipBL.vcc_CourseExamPaperRelationshipDA.GetObjBymId(myKey.Value);
return objvcc_CourseExamPaperRelationshipEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetmId(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, long lngmId, string strComparisonOp="")
	{
objvcc_CourseExamPaperRelationshipEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.mId) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.mId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.mId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetCourseExamPaperId(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strCourseExamPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convcc_CourseExamPaperRelationship.CourseExamPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convcc_CourseExamPaperRelationship.CourseExamPaperId);
}
objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.CourseExamPaperId) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.CourseExamPaperId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CourseExamPaperId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetExamPaperName(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strExamPaperName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, convcc_CourseExamPaperRelationship.ExamPaperName);
}
objvcc_CourseExamPaperRelationshipEN.ExamPaperName = strExamPaperName; //考卷名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.ExamPaperName) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.ExamPaperName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.ExamPaperName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetCourseId(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_CourseExamPaperRelationship.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_CourseExamPaperRelationship.CourseId);
}
objvcc_CourseExamPaperRelationshipEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.CourseId) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.CourseId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CourseId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetCourseName(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_CourseExamPaperRelationship.CourseName);
}
objvcc_CourseExamPaperRelationshipEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.CourseName) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.CourseName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CourseName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetQuestionId(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, long? lngQuestionId, string strComparisonOp="")
	{
objvcc_CourseExamPaperRelationshipEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.QuestionId) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.QuestionId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetQuestionIndex(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, int? intQuestionIndex, string strComparisonOp="")
	{
objvcc_CourseExamPaperRelationshipEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.QuestionIndex) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.QuestionIndex, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionIndex] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetQuestionName(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strQuestionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionName, 500, convcc_CourseExamPaperRelationship.QuestionName);
}
objvcc_CourseExamPaperRelationshipEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.QuestionName) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.QuestionName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetQuestionContent(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strQuestionContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, convcc_CourseExamPaperRelationship.QuestionContent);
}
objvcc_CourseExamPaperRelationshipEN.QuestionContent = strQuestionContent; //题目内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.QuestionContent) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.QuestionContent, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionContent] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetExamAnswer(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strExamAnswer, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamAnswer, 8000, convcc_CourseExamPaperRelationship.ExamAnswer);
}
objvcc_CourseExamPaperRelationshipEN.ExamAnswer = strExamAnswer; //题目答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.ExamAnswer) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.ExamAnswer, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.ExamAnswer] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetCourseChapterId(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_CourseExamPaperRelationship.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_CourseExamPaperRelationship.CourseChapterId);
}
objvcc_CourseExamPaperRelationshipEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.CourseChapterId) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.CourseChapterId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CourseChapterId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetCourseChapterName(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strCourseChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_CourseExamPaperRelationship.CourseChapterName);
}
objvcc_CourseExamPaperRelationshipEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.CourseChapterName) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.CourseChapterName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CourseChapterName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetParentNodeId(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strParentNodeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeId, 8, convcc_CourseExamPaperRelationship.ParentNodeId);
}
objvcc_CourseExamPaperRelationshipEN.ParentNodeId = strParentNodeId; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.ParentNodeId) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.ParentNodeId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.ParentNodeId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetParentNodeName(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strParentNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeName, 100, convcc_CourseExamPaperRelationship.ParentNodeName);
}
objvcc_CourseExamPaperRelationshipEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.ParentNodeName) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.ParentNodeName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.ParentNodeName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetQuestionTypeId(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convcc_CourseExamPaperRelationship.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convcc_CourseExamPaperRelationship.QuestionTypeId);
}
objvcc_CourseExamPaperRelationshipEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.QuestionTypeId) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.QuestionTypeId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionTypeId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetQuestionTypeName(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strQuestionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convcc_CourseExamPaperRelationship.QuestionTypeName);
}
objvcc_CourseExamPaperRelationshipEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.QuestionTypeName) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.QuestionTypeName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionTypeName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetExamGradeId(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strExamGradeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamGradeId, 2, convcc_CourseExamPaperRelationship.ExamGradeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExamGradeId, 2, convcc_CourseExamPaperRelationship.ExamGradeId);
}
objvcc_CourseExamPaperRelationshipEN.ExamGradeId = strExamGradeId; //题库等级ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.ExamGradeId) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.ExamGradeId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.ExamGradeId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetExamGradeName(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strExamGradeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamGradeName, 50, convcc_CourseExamPaperRelationship.ExamGradeName);
}
objvcc_CourseExamPaperRelationshipEN.ExamGradeName = strExamGradeName; //题库等级名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.ExamGradeName) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.ExamGradeName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.ExamGradeName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetAnswerTypeId(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strAnswerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convcc_CourseExamPaperRelationship.AnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convcc_CourseExamPaperRelationship.AnswerTypeId);
}
objvcc_CourseExamPaperRelationshipEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.AnswerTypeId) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.AnswerTypeId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.AnswerTypeId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetAnswerModeId(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strAnswerModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convcc_CourseExamPaperRelationship.AnswerModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convcc_CourseExamPaperRelationship.AnswerModeId);
}
objvcc_CourseExamPaperRelationshipEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.AnswerModeId) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.AnswerModeId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.AnswerModeId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetIsHaveAdditionalMemo(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, bool bolIsHaveAdditionalMemo, string strComparisonOp="")
	{
objvcc_CourseExamPaperRelationshipEN.IsHaveAdditionalMemo = bolIsHaveAdditionalMemo; //是否有附加说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetQuestionScore(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, float? fltQuestionScore, string strComparisonOp="")
	{
objvcc_CourseExamPaperRelationshipEN.QuestionScore = fltQuestionScore; //题目得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.QuestionScore) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.QuestionScore, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionScore] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetQuestionNameAdd(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strQuestionNameAdd, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionNameAdd, 500, convcc_CourseExamPaperRelationship.QuestionNameAdd);
}
objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd = strQuestionNameAdd; //题目补充
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.QuestionNameAdd) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.QuestionNameAdd, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionNameAdd] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetDefaultValue(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strDefaultValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convcc_CourseExamPaperRelationship.DefaultValue);
}
objvcc_CourseExamPaperRelationshipEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.DefaultValue) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.DefaultValue, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.DefaultValue] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetTextDirectId(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strTextDirectId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextDirectId, 4, convcc_CourseExamPaperRelationship.TextDirectId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextDirectId, 4, convcc_CourseExamPaperRelationship.TextDirectId);
}
objvcc_CourseExamPaperRelationshipEN.TextDirectId = strTextDirectId; //文本方向ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.TextDirectId) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.TextDirectId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.TextDirectId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetFillInTextWidth(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, int? intFillInTextWidth, string strComparisonOp="")
	{
objvcc_CourseExamPaperRelationshipEN.FillInTextWidth = intFillInTextWidth; //填空框宽度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.FillInTextWidth) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.FillInTextWidth, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.FillInTextWidth] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetMemoTextWidth(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, int? intMemoTextWidth, string strComparisonOp="")
	{
objvcc_CourseExamPaperRelationshipEN.MemoTextWidth = intMemoTextWidth; //备注框宽度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.MemoTextWidth) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.MemoTextWidth, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.MemoTextWidth] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetCodeTab(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strCodeTab, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTab, 50, convcc_CourseExamPaperRelationship.CodeTab);
}
objvcc_CourseExamPaperRelationshipEN.CodeTab = strCodeTab; //代码表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.CodeTab) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.CodeTab, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CodeTab] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetCodeTabCode(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strCodeTabCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabCode, 50, convcc_CourseExamPaperRelationship.CodeTabCode);
}
objvcc_CourseExamPaperRelationshipEN.CodeTabCode = strCodeTabCode; //CodeTab_Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.CodeTabCode) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.CodeTabCode, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CodeTabCode] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetCodeTabName(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strCodeTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabName, 50, convcc_CourseExamPaperRelationship.CodeTabName);
}
objvcc_CourseExamPaperRelationshipEN.CodeTabName = strCodeTabName; //CodeTab_Name
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.CodeTabName) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.CodeTabName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CodeTabName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetCodeTabCondition(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strCodeTabCondition, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabCondition, 200, convcc_CourseExamPaperRelationship.CodeTabCondition);
}
objvcc_CourseExamPaperRelationshipEN.CodeTabCondition = strCodeTabCondition; //代码表_条件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.CodeTabCondition) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.CodeTabCondition, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CodeTabCondition] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetRelaEvent(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strRelaEvent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaEvent, 4000, convcc_CourseExamPaperRelationship.RelaEvent);
}
objvcc_CourseExamPaperRelationshipEN.RelaEvent = strRelaEvent; //相关事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.RelaEvent) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.RelaEvent, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.RelaEvent] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetFirstIndent(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, bool bolFirstIndent, string strComparisonOp="")
	{
objvcc_CourseExamPaperRelationshipEN.FirstIndent = bolFirstIndent; //首行缩进
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.FirstIndent) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.FirstIndent, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.FirstIndent] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetDefaultSelectItem(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strDefaultSelectItem, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultSelectItem, 20, convcc_CourseExamPaperRelationship.DefaultSelectItem);
}
objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem = strDefaultSelectItem; //默认选项
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.DefaultSelectItem) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.DefaultSelectItem, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.DefaultSelectItem] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetFillInTextHeight(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, int? intFillInTextHeight, string strComparisonOp="")
	{
objvcc_CourseExamPaperRelationshipEN.FillInTextHeight = intFillInTextHeight; //填空框高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.FillInTextHeight) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.FillInTextHeight, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.FillInTextHeight] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetIsMulti4FillInText(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, bool bolIsMulti4FillInText, string strComparisonOp="")
	{
objvcc_CourseExamPaperRelationshipEN.IsMulti4FillInText = bolIsMulti4FillInText; //是否填空框多行
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.IsMulti4FillInText) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.IsMulti4FillInText, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.IsMulti4FillInText] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetCheckBoxLimitCount(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, int? intCheckBoxLimitCount, string strComparisonOp="")
	{
objvcc_CourseExamPaperRelationshipEN.CheckBoxLimitCount = intCheckBoxLimitCount; //复选框限制数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.CheckBoxLimitCount) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.CheckBoxLimitCount, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CheckBoxLimitCount] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetIsEffective(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, bool bolIsEffective, string strComparisonOp="")
	{
objvcc_CourseExamPaperRelationshipEN.IsEffective = bolIsEffective; //是否有效
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.IsEffective) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.IsEffective, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.IsEffective] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetUserId(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convcc_CourseExamPaperRelationship.UserId);
}
objvcc_CourseExamPaperRelationshipEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.UserId) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.UserId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.UserId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetStartTime(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, double? dblStartTime, string strComparisonOp="")
	{
objvcc_CourseExamPaperRelationshipEN.StartTime = dblStartTime; //开始时间(s)
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.StartTime) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.StartTime, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.StartTime] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetPapersBigTopicId(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strPapersBigTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPapersBigTopicId, 8, convcc_CourseExamPaperRelationship.PapersBigTopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPapersBigTopicId, 8, convcc_CourseExamPaperRelationship.PapersBigTopicId);
}
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId = strPapersBigTopicId; //试卷大题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.PapersBigTopicId) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.PapersBigTopicId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.PapersBigTopicId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetPapersBigTopicName(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strPapersBigTopicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPapersBigTopicName, 50, convcc_CourseExamPaperRelationship.PapersBigTopicName);
}
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName = strPapersBigTopicName; //试卷大题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.PapersBigTopicName) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.PapersBigTopicName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.PapersBigTopicName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetTopicDescription(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strTopicDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicDescription, 100, convcc_CourseExamPaperRelationship.TopicDescription);
}
objvcc_CourseExamPaperRelationshipEN.TopicDescription = strTopicDescription; //标题描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.TopicDescription) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.TopicDescription, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.TopicDescription] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetTopicScores(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, int? intTopicScores, string strComparisonOp="")
	{
objvcc_CourseExamPaperRelationshipEN.TopicScores = intTopicScores; //大题得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.TopicScores) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.TopicScores, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.TopicScores] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetTopicOrderNum(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, int? intTopicOrderNum, string strComparisonOp="")
	{
objvcc_CourseExamPaperRelationshipEN.TopicOrderNum = intTopicOrderNum; //TopicOrderNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.TopicOrderNum) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.TopicOrderNum, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.TopicOrderNum] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetOrderNum(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, int? intOrderNum, string strComparisonOp="")
	{
objvcc_CourseExamPaperRelationshipEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.OrderNum) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.OrderNum, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.OrderNum] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetUpdDate(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_CourseExamPaperRelationship.UpdDate);
}
objvcc_CourseExamPaperRelationshipEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.UpdDate) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.UpdDate, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.UpdDate] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetUpdUser(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_CourseExamPaperRelationship.UpdUser);
}
objvcc_CourseExamPaperRelationshipEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.UpdUser) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.UpdUser, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.UpdUser] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipENS">源对象</param>
 /// <param name = "objvcc_CourseExamPaperRelationshipENT">目标对象</param>
 public static void CopyTo(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipENS, clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipENT)
{
try
{
objvcc_CourseExamPaperRelationshipENT.mId = objvcc_CourseExamPaperRelationshipENS.mId; //mId
objvcc_CourseExamPaperRelationshipENT.CourseExamPaperId = objvcc_CourseExamPaperRelationshipENS.CourseExamPaperId; //考卷流水号
objvcc_CourseExamPaperRelationshipENT.ExamPaperName = objvcc_CourseExamPaperRelationshipENS.ExamPaperName; //考卷名称
objvcc_CourseExamPaperRelationshipENT.CourseId = objvcc_CourseExamPaperRelationshipENS.CourseId; //课程Id
objvcc_CourseExamPaperRelationshipENT.CourseName = objvcc_CourseExamPaperRelationshipENS.CourseName; //课程名称
objvcc_CourseExamPaperRelationshipENT.QuestionId = objvcc_CourseExamPaperRelationshipENS.QuestionId; //题目Id
objvcc_CourseExamPaperRelationshipENT.QuestionIndex = objvcc_CourseExamPaperRelationshipENS.QuestionIndex; //题目序号
objvcc_CourseExamPaperRelationshipENT.QuestionName = objvcc_CourseExamPaperRelationshipENS.QuestionName; //题目名称
objvcc_CourseExamPaperRelationshipENT.QuestionContent = objvcc_CourseExamPaperRelationshipENS.QuestionContent; //题目内容
objvcc_CourseExamPaperRelationshipENT.ExamAnswer = objvcc_CourseExamPaperRelationshipENS.ExamAnswer; //题目答案
objvcc_CourseExamPaperRelationshipENT.CourseChapterId = objvcc_CourseExamPaperRelationshipENS.CourseChapterId; //课程章节ID
objvcc_CourseExamPaperRelationshipENT.CourseChapterName = objvcc_CourseExamPaperRelationshipENS.CourseChapterName; //课程章节名称
objvcc_CourseExamPaperRelationshipENT.ParentNodeId = objvcc_CourseExamPaperRelationshipENS.ParentNodeId; //父节点编号
objvcc_CourseExamPaperRelationshipENT.ParentNodeName = objvcc_CourseExamPaperRelationshipENS.ParentNodeName; //父节点名称
objvcc_CourseExamPaperRelationshipENT.QuestionTypeId = objvcc_CourseExamPaperRelationshipENS.QuestionTypeId; //题目类型Id
objvcc_CourseExamPaperRelationshipENT.QuestionTypeName = objvcc_CourseExamPaperRelationshipENS.QuestionTypeName; //题目类型名
objvcc_CourseExamPaperRelationshipENT.ExamGradeId = objvcc_CourseExamPaperRelationshipENS.ExamGradeId; //题库等级ID
objvcc_CourseExamPaperRelationshipENT.ExamGradeName = objvcc_CourseExamPaperRelationshipENS.ExamGradeName; //题库等级名
objvcc_CourseExamPaperRelationshipENT.AnswerTypeId = objvcc_CourseExamPaperRelationshipENS.AnswerTypeId; //答案类型ID
objvcc_CourseExamPaperRelationshipENT.AnswerModeId = objvcc_CourseExamPaperRelationshipENS.AnswerModeId; //答案模式Id
objvcc_CourseExamPaperRelationshipENT.IsHaveAdditionalMemo = objvcc_CourseExamPaperRelationshipENS.IsHaveAdditionalMemo; //是否有附加说明
objvcc_CourseExamPaperRelationshipENT.QuestionScore = objvcc_CourseExamPaperRelationshipENS.QuestionScore; //题目得分
objvcc_CourseExamPaperRelationshipENT.QuestionNameAdd = objvcc_CourseExamPaperRelationshipENS.QuestionNameAdd; //题目补充
objvcc_CourseExamPaperRelationshipENT.DefaultValue = objvcc_CourseExamPaperRelationshipENS.DefaultValue; //缺省值
objvcc_CourseExamPaperRelationshipENT.TextDirectId = objvcc_CourseExamPaperRelationshipENS.TextDirectId; //文本方向ID
objvcc_CourseExamPaperRelationshipENT.FillInTextWidth = objvcc_CourseExamPaperRelationshipENS.FillInTextWidth; //填空框宽度
objvcc_CourseExamPaperRelationshipENT.MemoTextWidth = objvcc_CourseExamPaperRelationshipENS.MemoTextWidth; //备注框宽度
objvcc_CourseExamPaperRelationshipENT.CodeTab = objvcc_CourseExamPaperRelationshipENS.CodeTab; //代码表
objvcc_CourseExamPaperRelationshipENT.CodeTabCode = objvcc_CourseExamPaperRelationshipENS.CodeTabCode; //CodeTab_Code
objvcc_CourseExamPaperRelationshipENT.CodeTabName = objvcc_CourseExamPaperRelationshipENS.CodeTabName; //CodeTab_Name
objvcc_CourseExamPaperRelationshipENT.CodeTabCondition = objvcc_CourseExamPaperRelationshipENS.CodeTabCondition; //代码表_条件
objvcc_CourseExamPaperRelationshipENT.RelaEvent = objvcc_CourseExamPaperRelationshipENS.RelaEvent; //相关事件
objvcc_CourseExamPaperRelationshipENT.FirstIndent = objvcc_CourseExamPaperRelationshipENS.FirstIndent; //首行缩进
objvcc_CourseExamPaperRelationshipENT.DefaultSelectItem = objvcc_CourseExamPaperRelationshipENS.DefaultSelectItem; //默认选项
objvcc_CourseExamPaperRelationshipENT.FillInTextHeight = objvcc_CourseExamPaperRelationshipENS.FillInTextHeight; //填空框高度
objvcc_CourseExamPaperRelationshipENT.IsMulti4FillInText = objvcc_CourseExamPaperRelationshipENS.IsMulti4FillInText; //是否填空框多行
objvcc_CourseExamPaperRelationshipENT.CheckBoxLimitCount = objvcc_CourseExamPaperRelationshipENS.CheckBoxLimitCount; //复选框限制数
objvcc_CourseExamPaperRelationshipENT.IsEffective = objvcc_CourseExamPaperRelationshipENS.IsEffective; //是否有效
objvcc_CourseExamPaperRelationshipENT.UserId = objvcc_CourseExamPaperRelationshipENS.UserId; //用户ID
objvcc_CourseExamPaperRelationshipENT.StartTime = objvcc_CourseExamPaperRelationshipENS.StartTime; //开始时间(s)
objvcc_CourseExamPaperRelationshipENT.PapersBigTopicId = objvcc_CourseExamPaperRelationshipENS.PapersBigTopicId; //试卷大题目Id
objvcc_CourseExamPaperRelationshipENT.PapersBigTopicName = objvcc_CourseExamPaperRelationshipENS.PapersBigTopicName; //试卷大题目名称
objvcc_CourseExamPaperRelationshipENT.TopicDescription = objvcc_CourseExamPaperRelationshipENS.TopicDescription; //标题描述
objvcc_CourseExamPaperRelationshipENT.TopicScores = objvcc_CourseExamPaperRelationshipENS.TopicScores; //大题得分
objvcc_CourseExamPaperRelationshipENT.TopicOrderNum = objvcc_CourseExamPaperRelationshipENS.TopicOrderNum; //TopicOrderNum
objvcc_CourseExamPaperRelationshipENT.OrderNum = objvcc_CourseExamPaperRelationshipENS.OrderNum; //序号
objvcc_CourseExamPaperRelationshipENT.UpdDate = objvcc_CourseExamPaperRelationshipENS.UpdDate; //修改日期
objvcc_CourseExamPaperRelationshipENT.UpdUser = objvcc_CourseExamPaperRelationshipENS.UpdUser; //修改人
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
 /// <param name = "objvcc_CourseExamPaperRelationshipENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseExamPaperRelationshipEN:objvcc_CourseExamPaperRelationshipENT</returns>
 public static clsvcc_CourseExamPaperRelationshipEN CopyTo(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipENS)
{
try
{
 clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipENT = new clsvcc_CourseExamPaperRelationshipEN()
{
mId = objvcc_CourseExamPaperRelationshipENS.mId, //mId
CourseExamPaperId = objvcc_CourseExamPaperRelationshipENS.CourseExamPaperId, //考卷流水号
ExamPaperName = objvcc_CourseExamPaperRelationshipENS.ExamPaperName, //考卷名称
CourseId = objvcc_CourseExamPaperRelationshipENS.CourseId, //课程Id
CourseName = objvcc_CourseExamPaperRelationshipENS.CourseName, //课程名称
QuestionId = objvcc_CourseExamPaperRelationshipENS.QuestionId, //题目Id
QuestionIndex = objvcc_CourseExamPaperRelationshipENS.QuestionIndex, //题目序号
QuestionName = objvcc_CourseExamPaperRelationshipENS.QuestionName, //题目名称
QuestionContent = objvcc_CourseExamPaperRelationshipENS.QuestionContent, //题目内容
ExamAnswer = objvcc_CourseExamPaperRelationshipENS.ExamAnswer, //题目答案
CourseChapterId = objvcc_CourseExamPaperRelationshipENS.CourseChapterId, //课程章节ID
CourseChapterName = objvcc_CourseExamPaperRelationshipENS.CourseChapterName, //课程章节名称
ParentNodeId = objvcc_CourseExamPaperRelationshipENS.ParentNodeId, //父节点编号
ParentNodeName = objvcc_CourseExamPaperRelationshipENS.ParentNodeName, //父节点名称
QuestionTypeId = objvcc_CourseExamPaperRelationshipENS.QuestionTypeId, //题目类型Id
QuestionTypeName = objvcc_CourseExamPaperRelationshipENS.QuestionTypeName, //题目类型名
ExamGradeId = objvcc_CourseExamPaperRelationshipENS.ExamGradeId, //题库等级ID
ExamGradeName = objvcc_CourseExamPaperRelationshipENS.ExamGradeName, //题库等级名
AnswerTypeId = objvcc_CourseExamPaperRelationshipENS.AnswerTypeId, //答案类型ID
AnswerModeId = objvcc_CourseExamPaperRelationshipENS.AnswerModeId, //答案模式Id
IsHaveAdditionalMemo = objvcc_CourseExamPaperRelationshipENS.IsHaveAdditionalMemo, //是否有附加说明
QuestionScore = objvcc_CourseExamPaperRelationshipENS.QuestionScore, //题目得分
QuestionNameAdd = objvcc_CourseExamPaperRelationshipENS.QuestionNameAdd, //题目补充
DefaultValue = objvcc_CourseExamPaperRelationshipENS.DefaultValue, //缺省值
TextDirectId = objvcc_CourseExamPaperRelationshipENS.TextDirectId, //文本方向ID
FillInTextWidth = objvcc_CourseExamPaperRelationshipENS.FillInTextWidth, //填空框宽度
MemoTextWidth = objvcc_CourseExamPaperRelationshipENS.MemoTextWidth, //备注框宽度
CodeTab = objvcc_CourseExamPaperRelationshipENS.CodeTab, //代码表
CodeTabCode = objvcc_CourseExamPaperRelationshipENS.CodeTabCode, //CodeTab_Code
CodeTabName = objvcc_CourseExamPaperRelationshipENS.CodeTabName, //CodeTab_Name
CodeTabCondition = objvcc_CourseExamPaperRelationshipENS.CodeTabCondition, //代码表_条件
RelaEvent = objvcc_CourseExamPaperRelationshipENS.RelaEvent, //相关事件
FirstIndent = objvcc_CourseExamPaperRelationshipENS.FirstIndent, //首行缩进
DefaultSelectItem = objvcc_CourseExamPaperRelationshipENS.DefaultSelectItem, //默认选项
FillInTextHeight = objvcc_CourseExamPaperRelationshipENS.FillInTextHeight, //填空框高度
IsMulti4FillInText = objvcc_CourseExamPaperRelationshipENS.IsMulti4FillInText, //是否填空框多行
CheckBoxLimitCount = objvcc_CourseExamPaperRelationshipENS.CheckBoxLimitCount, //复选框限制数
IsEffective = objvcc_CourseExamPaperRelationshipENS.IsEffective, //是否有效
UserId = objvcc_CourseExamPaperRelationshipENS.UserId, //用户ID
StartTime = objvcc_CourseExamPaperRelationshipENS.StartTime, //开始时间(s)
PapersBigTopicId = objvcc_CourseExamPaperRelationshipENS.PapersBigTopicId, //试卷大题目Id
PapersBigTopicName = objvcc_CourseExamPaperRelationshipENS.PapersBigTopicName, //试卷大题目名称
TopicDescription = objvcc_CourseExamPaperRelationshipENS.TopicDescription, //标题描述
TopicScores = objvcc_CourseExamPaperRelationshipENS.TopicScores, //大题得分
TopicOrderNum = objvcc_CourseExamPaperRelationshipENS.TopicOrderNum, //TopicOrderNum
OrderNum = objvcc_CourseExamPaperRelationshipENS.OrderNum, //序号
UpdDate = objvcc_CourseExamPaperRelationshipENS.UpdDate, //修改日期
UpdUser = objvcc_CourseExamPaperRelationshipENS.UpdUser, //修改人
};
 return objvcc_CourseExamPaperRelationshipENT;
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
public static void CheckProperty4Condition(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN)
{
 clsvcc_CourseExamPaperRelationshipBL.vcc_CourseExamPaperRelationshipDA.CheckProperty4Condition(objvcc_CourseExamPaperRelationshipEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.mId) == true)
{
string strComparisonOpmId = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship.mId, objvcc_CourseExamPaperRelationshipCond.mId, strComparisonOpmId);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.CourseExamPaperId) == true)
{
string strComparisonOpCourseExamPaperId = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.CourseExamPaperId, objvcc_CourseExamPaperRelationshipCond.CourseExamPaperId, strComparisonOpCourseExamPaperId);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.ExamPaperName) == true)
{
string strComparisonOpExamPaperName = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.ExamPaperName, objvcc_CourseExamPaperRelationshipCond.ExamPaperName, strComparisonOpExamPaperName);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.CourseId, objvcc_CourseExamPaperRelationshipCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.CourseName) == true)
{
string strComparisonOpCourseName = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.CourseName, objvcc_CourseExamPaperRelationshipCond.CourseName, strComparisonOpCourseName);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.QuestionId) == true)
{
string strComparisonOpQuestionId = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship.QuestionId, objvcc_CourseExamPaperRelationshipCond.QuestionId, strComparisonOpQuestionId);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.QuestionIndex) == true)
{
string strComparisonOpQuestionIndex = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship.QuestionIndex, objvcc_CourseExamPaperRelationshipCond.QuestionIndex, strComparisonOpQuestionIndex);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.QuestionName) == true)
{
string strComparisonOpQuestionName = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.QuestionName, objvcc_CourseExamPaperRelationshipCond.QuestionName, strComparisonOpQuestionName);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.QuestionContent) == true)
{
string strComparisonOpQuestionContent = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.QuestionContent, objvcc_CourseExamPaperRelationshipCond.QuestionContent, strComparisonOpQuestionContent);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.ExamAnswer) == true)
{
string strComparisonOpExamAnswer = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.ExamAnswer];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.ExamAnswer, objvcc_CourseExamPaperRelationshipCond.ExamAnswer, strComparisonOpExamAnswer);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.CourseChapterId, objvcc_CourseExamPaperRelationshipCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.CourseChapterName, objvcc_CourseExamPaperRelationshipCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.ParentNodeId) == true)
{
string strComparisonOpParentNodeId = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.ParentNodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.ParentNodeId, objvcc_CourseExamPaperRelationshipCond.ParentNodeId, strComparisonOpParentNodeId);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.ParentNodeName) == true)
{
string strComparisonOpParentNodeName = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.ParentNodeName, objvcc_CourseExamPaperRelationshipCond.ParentNodeName, strComparisonOpParentNodeName);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.QuestionTypeId, objvcc_CourseExamPaperRelationshipCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.QuestionTypeName) == true)
{
string strComparisonOpQuestionTypeName = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.QuestionTypeName, objvcc_CourseExamPaperRelationshipCond.QuestionTypeName, strComparisonOpQuestionTypeName);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.ExamGradeId) == true)
{
string strComparisonOpExamGradeId = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.ExamGradeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.ExamGradeId, objvcc_CourseExamPaperRelationshipCond.ExamGradeId, strComparisonOpExamGradeId);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.ExamGradeName) == true)
{
string strComparisonOpExamGradeName = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.ExamGradeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.ExamGradeName, objvcc_CourseExamPaperRelationshipCond.ExamGradeName, strComparisonOpExamGradeName);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.AnswerTypeId) == true)
{
string strComparisonOpAnswerTypeId = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.AnswerTypeId, objvcc_CourseExamPaperRelationshipCond.AnswerTypeId, strComparisonOpAnswerTypeId);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.AnswerModeId) == true)
{
string strComparisonOpAnswerModeId = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.AnswerModeId, objvcc_CourseExamPaperRelationshipCond.AnswerModeId, strComparisonOpAnswerModeId);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo) == true)
{
if (objvcc_CourseExamPaperRelationshipCond.IsHaveAdditionalMemo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo);
}
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.QuestionScore) == true)
{
string strComparisonOpQuestionScore = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionScore];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship.QuestionScore, objvcc_CourseExamPaperRelationshipCond.QuestionScore, strComparisonOpQuestionScore);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.QuestionNameAdd) == true)
{
string strComparisonOpQuestionNameAdd = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionNameAdd];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.QuestionNameAdd, objvcc_CourseExamPaperRelationshipCond.QuestionNameAdd, strComparisonOpQuestionNameAdd);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.DefaultValue, objvcc_CourseExamPaperRelationshipCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.TextDirectId) == true)
{
string strComparisonOpTextDirectId = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.TextDirectId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.TextDirectId, objvcc_CourseExamPaperRelationshipCond.TextDirectId, strComparisonOpTextDirectId);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.FillInTextWidth) == true)
{
string strComparisonOpFillInTextWidth = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.FillInTextWidth];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship.FillInTextWidth, objvcc_CourseExamPaperRelationshipCond.FillInTextWidth, strComparisonOpFillInTextWidth);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.MemoTextWidth) == true)
{
string strComparisonOpMemoTextWidth = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.MemoTextWidth];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship.MemoTextWidth, objvcc_CourseExamPaperRelationshipCond.MemoTextWidth, strComparisonOpMemoTextWidth);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.CodeTab) == true)
{
string strComparisonOpCodeTab = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CodeTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.CodeTab, objvcc_CourseExamPaperRelationshipCond.CodeTab, strComparisonOpCodeTab);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.CodeTabCode) == true)
{
string strComparisonOpCodeTabCode = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CodeTabCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.CodeTabCode, objvcc_CourseExamPaperRelationshipCond.CodeTabCode, strComparisonOpCodeTabCode);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.CodeTabName) == true)
{
string strComparisonOpCodeTabName = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CodeTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.CodeTabName, objvcc_CourseExamPaperRelationshipCond.CodeTabName, strComparisonOpCodeTabName);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.CodeTabCondition) == true)
{
string strComparisonOpCodeTabCondition = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CodeTabCondition];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.CodeTabCondition, objvcc_CourseExamPaperRelationshipCond.CodeTabCondition, strComparisonOpCodeTabCondition);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.RelaEvent) == true)
{
string strComparisonOpRelaEvent = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.RelaEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.RelaEvent, objvcc_CourseExamPaperRelationshipCond.RelaEvent, strComparisonOpRelaEvent);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.FirstIndent) == true)
{
if (objvcc_CourseExamPaperRelationshipCond.FirstIndent == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseExamPaperRelationship.FirstIndent);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseExamPaperRelationship.FirstIndent);
}
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.DefaultSelectItem) == true)
{
string strComparisonOpDefaultSelectItem = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.DefaultSelectItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.DefaultSelectItem, objvcc_CourseExamPaperRelationshipCond.DefaultSelectItem, strComparisonOpDefaultSelectItem);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.FillInTextHeight) == true)
{
string strComparisonOpFillInTextHeight = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.FillInTextHeight];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship.FillInTextHeight, objvcc_CourseExamPaperRelationshipCond.FillInTextHeight, strComparisonOpFillInTextHeight);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.IsMulti4FillInText) == true)
{
if (objvcc_CourseExamPaperRelationshipCond.IsMulti4FillInText == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseExamPaperRelationship.IsMulti4FillInText);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseExamPaperRelationship.IsMulti4FillInText);
}
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.CheckBoxLimitCount) == true)
{
string strComparisonOpCheckBoxLimitCount = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CheckBoxLimitCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship.CheckBoxLimitCount, objvcc_CourseExamPaperRelationshipCond.CheckBoxLimitCount, strComparisonOpCheckBoxLimitCount);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.IsEffective) == true)
{
if (objvcc_CourseExamPaperRelationshipCond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseExamPaperRelationship.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseExamPaperRelationship.IsEffective);
}
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.UserId) == true)
{
string strComparisonOpUserId = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.UserId, objvcc_CourseExamPaperRelationshipCond.UserId, strComparisonOpUserId);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.StartTime) == true)
{
string strComparisonOpStartTime = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.StartTime];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship.StartTime, objvcc_CourseExamPaperRelationshipCond.StartTime, strComparisonOpStartTime);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.PapersBigTopicId) == true)
{
string strComparisonOpPapersBigTopicId = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.PapersBigTopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.PapersBigTopicId, objvcc_CourseExamPaperRelationshipCond.PapersBigTopicId, strComparisonOpPapersBigTopicId);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.PapersBigTopicName) == true)
{
string strComparisonOpPapersBigTopicName = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.PapersBigTopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.PapersBigTopicName, objvcc_CourseExamPaperRelationshipCond.PapersBigTopicName, strComparisonOpPapersBigTopicName);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.TopicDescription) == true)
{
string strComparisonOpTopicDescription = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.TopicDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.TopicDescription, objvcc_CourseExamPaperRelationshipCond.TopicDescription, strComparisonOpTopicDescription);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.TopicScores) == true)
{
string strComparisonOpTopicScores = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.TopicScores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship.TopicScores, objvcc_CourseExamPaperRelationshipCond.TopicScores, strComparisonOpTopicScores);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.TopicOrderNum) == true)
{
string strComparisonOpTopicOrderNum = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.TopicOrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship.TopicOrderNum, objvcc_CourseExamPaperRelationshipCond.TopicOrderNum, strComparisonOpTopicOrderNum);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.OrderNum) == true)
{
string strComparisonOpOrderNum = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship.OrderNum, objvcc_CourseExamPaperRelationshipCond.OrderNum, strComparisonOpOrderNum);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.UpdDate, objvcc_CourseExamPaperRelationshipCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(convcc_CourseExamPaperRelationship.UpdUser) == true)
{
string strComparisonOpUpdUser = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.UpdUser, objvcc_CourseExamPaperRelationshipCond.UpdUser, strComparisonOpUpdUser);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_CourseExamPaperRelationship
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 题目与试卷关系(vcc_CourseExamPaperRelationship)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseExamPaperRelationshipBL
{
public static RelatedActions_vcc_CourseExamPaperRelationship relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_CourseExamPaperRelationshipDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_CourseExamPaperRelationshipDA vcc_CourseExamPaperRelationshipDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_CourseExamPaperRelationshipDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_CourseExamPaperRelationshipBL()
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
if (string.IsNullOrEmpty(clsvcc_CourseExamPaperRelationshipEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_CourseExamPaperRelationshipEN._ConnectString);
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
public static DataTable GetDataTable_vcc_CourseExamPaperRelationship(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_CourseExamPaperRelationshipDA.GetDataTable_vcc_CourseExamPaperRelationship(strWhereCond);
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
objDT = vcc_CourseExamPaperRelationshipDA.GetDataTable(strWhereCond);
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
objDT = vcc_CourseExamPaperRelationshipDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_CourseExamPaperRelationshipDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_CourseExamPaperRelationshipDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_CourseExamPaperRelationshipDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_CourseExamPaperRelationshipDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_CourseExamPaperRelationshipDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_CourseExamPaperRelationshipDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcc_CourseExamPaperRelationshipEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvcc_CourseExamPaperRelationshipEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationshipEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = new clsvcc_CourseExamPaperRelationshipEN();
try
{
objvcc_CourseExamPaperRelationshipEN.mId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationshipEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationshipEN.CourseId = objRow[convcc_CourseExamPaperRelationship.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationshipEN.CourseName = objRow[convcc_CourseExamPaperRelationship.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationshipEN.QuestionId = objRow[convcc_CourseExamPaperRelationship.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationshipEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationshipEN.QuestionName = objRow[convcc_CourseExamPaperRelationship.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationshipEN.QuestionContent = objRow[convcc_CourseExamPaperRelationship.QuestionContent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionContent].ToString().Trim(); //题目内容
objvcc_CourseExamPaperRelationshipEN.ExamAnswer = objRow[convcc_CourseExamPaperRelationship.ExamAnswer] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamAnswer].ToString().Trim(); //题目答案
objvcc_CourseExamPaperRelationshipEN.CourseChapterId = objRow[convcc_CourseExamPaperRelationship.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperRelationshipEN.CourseChapterName = objRow[convcc_CourseExamPaperRelationship.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperRelationshipEN.ParentNodeId = objRow[convcc_CourseExamPaperRelationship.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseExamPaperRelationshipEN.ParentNodeName = objRow[convcc_CourseExamPaperRelationship.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseExamPaperRelationshipEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationshipEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationshipEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationshipEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationshipEN.AnswerTypeId = objRow[convcc_CourseExamPaperRelationship.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_CourseExamPaperRelationshipEN.AnswerModeId = objRow[convcc_CourseExamPaperRelationship.AnswerModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_CourseExamPaperRelationshipEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvcc_CourseExamPaperRelationshipEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convcc_CourseExamPaperRelationship.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd = objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd].ToString().Trim(); //题目补充
objvcc_CourseExamPaperRelationshipEN.DefaultValue = objRow[convcc_CourseExamPaperRelationship.DefaultValue] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultValue].ToString().Trim(); //缺省值
objvcc_CourseExamPaperRelationshipEN.TextDirectId = objRow[convcc_CourseExamPaperRelationship.TextDirectId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_CourseExamPaperRelationshipEN.FillInTextWidth = objRow[convcc_CourseExamPaperRelationship.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.FillInTextWidth].ToString().Trim()); //填空框宽度
objvcc_CourseExamPaperRelationshipEN.MemoTextWidth = objRow[convcc_CourseExamPaperRelationship.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.MemoTextWidth].ToString().Trim()); //备注框宽度
objvcc_CourseExamPaperRelationshipEN.CodeTab = objRow[convcc_CourseExamPaperRelationship.CodeTab] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTab].ToString().Trim(); //代码表
objvcc_CourseExamPaperRelationshipEN.CodeTabCode = objRow[convcc_CourseExamPaperRelationship.CodeTabCode] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvcc_CourseExamPaperRelationshipEN.CodeTabName = objRow[convcc_CourseExamPaperRelationship.CodeTabName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabName].ToString().Trim(); //CodeTab_Name
objvcc_CourseExamPaperRelationshipEN.CodeTabCondition = objRow[convcc_CourseExamPaperRelationship.CodeTabCondition] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCondition].ToString().Trim(); //代码表_条件
objvcc_CourseExamPaperRelationshipEN.RelaEvent = objRow[convcc_CourseExamPaperRelationship.RelaEvent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.RelaEvent].ToString().Trim(); //相关事件
objvcc_CourseExamPaperRelationshipEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.FirstIndent].ToString().Trim()); //首行缩进
objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem = objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem].ToString().Trim(); //默认选项
objvcc_CourseExamPaperRelationshipEN.FillInTextHeight = objRow[convcc_CourseExamPaperRelationship.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.FillInTextHeight].ToString().Trim()); //填空框高度
objvcc_CourseExamPaperRelationshipEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvcc_CourseExamPaperRelationshipEN.CheckBoxLimitCount = objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_CourseExamPaperRelationshipEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationshipEN.UserId = objRow[convcc_CourseExamPaperRelationship.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationshipEN.StartTime = objRow[convcc_CourseExamPaperRelationship.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaperRelationship.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationshipEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationshipEN.TopicScores = objRow[convcc_CourseExamPaperRelationship.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationshipEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship.TopicOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationshipEN.OrderNum = objRow[convcc_CourseExamPaperRelationship.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationshipEN.UpdDate = objRow[convcc_CourseExamPaperRelationship.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationshipEN.UpdUser = objRow[convcc_CourseExamPaperRelationship.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperRelationshipEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperRelationshipEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_CourseExamPaperRelationshipEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperRelationshipEN._CurrTabName, strCourseId);
List<clsvcc_CourseExamPaperRelationshipEN> arrvcc_CourseExamPaperRelationshipObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseExamPaperRelationshipEN> arrvcc_CourseExamPaperRelationshipObjLst_Sel =
arrvcc_CourseExamPaperRelationshipObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvcc_CourseExamPaperRelationshipObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseExamPaperRelationshipEN> GetObjLst(string strWhereCond)
{
List<clsvcc_CourseExamPaperRelationshipEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationshipEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = new clsvcc_CourseExamPaperRelationshipEN();
try
{
objvcc_CourseExamPaperRelationshipEN.mId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationshipEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationshipEN.CourseId = objRow[convcc_CourseExamPaperRelationship.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationshipEN.CourseName = objRow[convcc_CourseExamPaperRelationship.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationshipEN.QuestionId = objRow[convcc_CourseExamPaperRelationship.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationshipEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationshipEN.QuestionName = objRow[convcc_CourseExamPaperRelationship.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationshipEN.QuestionContent = objRow[convcc_CourseExamPaperRelationship.QuestionContent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionContent].ToString().Trim(); //题目内容
objvcc_CourseExamPaperRelationshipEN.ExamAnswer = objRow[convcc_CourseExamPaperRelationship.ExamAnswer] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamAnswer].ToString().Trim(); //题目答案
objvcc_CourseExamPaperRelationshipEN.CourseChapterId = objRow[convcc_CourseExamPaperRelationship.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperRelationshipEN.CourseChapterName = objRow[convcc_CourseExamPaperRelationship.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperRelationshipEN.ParentNodeId = objRow[convcc_CourseExamPaperRelationship.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseExamPaperRelationshipEN.ParentNodeName = objRow[convcc_CourseExamPaperRelationship.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseExamPaperRelationshipEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationshipEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationshipEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationshipEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationshipEN.AnswerTypeId = objRow[convcc_CourseExamPaperRelationship.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_CourseExamPaperRelationshipEN.AnswerModeId = objRow[convcc_CourseExamPaperRelationship.AnswerModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_CourseExamPaperRelationshipEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvcc_CourseExamPaperRelationshipEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convcc_CourseExamPaperRelationship.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd = objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd].ToString().Trim(); //题目补充
objvcc_CourseExamPaperRelationshipEN.DefaultValue = objRow[convcc_CourseExamPaperRelationship.DefaultValue] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultValue].ToString().Trim(); //缺省值
objvcc_CourseExamPaperRelationshipEN.TextDirectId = objRow[convcc_CourseExamPaperRelationship.TextDirectId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_CourseExamPaperRelationshipEN.FillInTextWidth = objRow[convcc_CourseExamPaperRelationship.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.FillInTextWidth].ToString().Trim()); //填空框宽度
objvcc_CourseExamPaperRelationshipEN.MemoTextWidth = objRow[convcc_CourseExamPaperRelationship.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.MemoTextWidth].ToString().Trim()); //备注框宽度
objvcc_CourseExamPaperRelationshipEN.CodeTab = objRow[convcc_CourseExamPaperRelationship.CodeTab] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTab].ToString().Trim(); //代码表
objvcc_CourseExamPaperRelationshipEN.CodeTabCode = objRow[convcc_CourseExamPaperRelationship.CodeTabCode] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvcc_CourseExamPaperRelationshipEN.CodeTabName = objRow[convcc_CourseExamPaperRelationship.CodeTabName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabName].ToString().Trim(); //CodeTab_Name
objvcc_CourseExamPaperRelationshipEN.CodeTabCondition = objRow[convcc_CourseExamPaperRelationship.CodeTabCondition] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCondition].ToString().Trim(); //代码表_条件
objvcc_CourseExamPaperRelationshipEN.RelaEvent = objRow[convcc_CourseExamPaperRelationship.RelaEvent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.RelaEvent].ToString().Trim(); //相关事件
objvcc_CourseExamPaperRelationshipEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.FirstIndent].ToString().Trim()); //首行缩进
objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem = objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem].ToString().Trim(); //默认选项
objvcc_CourseExamPaperRelationshipEN.FillInTextHeight = objRow[convcc_CourseExamPaperRelationship.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.FillInTextHeight].ToString().Trim()); //填空框高度
objvcc_CourseExamPaperRelationshipEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvcc_CourseExamPaperRelationshipEN.CheckBoxLimitCount = objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_CourseExamPaperRelationshipEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationshipEN.UserId = objRow[convcc_CourseExamPaperRelationship.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationshipEN.StartTime = objRow[convcc_CourseExamPaperRelationship.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaperRelationship.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationshipEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationshipEN.TopicScores = objRow[convcc_CourseExamPaperRelationship.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationshipEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship.TopicOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationshipEN.OrderNum = objRow[convcc_CourseExamPaperRelationship.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationshipEN.UpdDate = objRow[convcc_CourseExamPaperRelationship.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationshipEN.UpdUser = objRow[convcc_CourseExamPaperRelationship.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperRelationshipEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperRelationshipEN);
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
public static List<clsvcc_CourseExamPaperRelationshipEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseExamPaperRelationshipEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationshipEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = new clsvcc_CourseExamPaperRelationshipEN();
try
{
objvcc_CourseExamPaperRelationshipEN.mId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationshipEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationshipEN.CourseId = objRow[convcc_CourseExamPaperRelationship.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationshipEN.CourseName = objRow[convcc_CourseExamPaperRelationship.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationshipEN.QuestionId = objRow[convcc_CourseExamPaperRelationship.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationshipEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationshipEN.QuestionName = objRow[convcc_CourseExamPaperRelationship.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationshipEN.QuestionContent = objRow[convcc_CourseExamPaperRelationship.QuestionContent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionContent].ToString().Trim(); //题目内容
objvcc_CourseExamPaperRelationshipEN.ExamAnswer = objRow[convcc_CourseExamPaperRelationship.ExamAnswer] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamAnswer].ToString().Trim(); //题目答案
objvcc_CourseExamPaperRelationshipEN.CourseChapterId = objRow[convcc_CourseExamPaperRelationship.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperRelationshipEN.CourseChapterName = objRow[convcc_CourseExamPaperRelationship.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperRelationshipEN.ParentNodeId = objRow[convcc_CourseExamPaperRelationship.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseExamPaperRelationshipEN.ParentNodeName = objRow[convcc_CourseExamPaperRelationship.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseExamPaperRelationshipEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationshipEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationshipEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationshipEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationshipEN.AnswerTypeId = objRow[convcc_CourseExamPaperRelationship.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_CourseExamPaperRelationshipEN.AnswerModeId = objRow[convcc_CourseExamPaperRelationship.AnswerModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_CourseExamPaperRelationshipEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvcc_CourseExamPaperRelationshipEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convcc_CourseExamPaperRelationship.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd = objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd].ToString().Trim(); //题目补充
objvcc_CourseExamPaperRelationshipEN.DefaultValue = objRow[convcc_CourseExamPaperRelationship.DefaultValue] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultValue].ToString().Trim(); //缺省值
objvcc_CourseExamPaperRelationshipEN.TextDirectId = objRow[convcc_CourseExamPaperRelationship.TextDirectId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_CourseExamPaperRelationshipEN.FillInTextWidth = objRow[convcc_CourseExamPaperRelationship.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.FillInTextWidth].ToString().Trim()); //填空框宽度
objvcc_CourseExamPaperRelationshipEN.MemoTextWidth = objRow[convcc_CourseExamPaperRelationship.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.MemoTextWidth].ToString().Trim()); //备注框宽度
objvcc_CourseExamPaperRelationshipEN.CodeTab = objRow[convcc_CourseExamPaperRelationship.CodeTab] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTab].ToString().Trim(); //代码表
objvcc_CourseExamPaperRelationshipEN.CodeTabCode = objRow[convcc_CourseExamPaperRelationship.CodeTabCode] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvcc_CourseExamPaperRelationshipEN.CodeTabName = objRow[convcc_CourseExamPaperRelationship.CodeTabName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabName].ToString().Trim(); //CodeTab_Name
objvcc_CourseExamPaperRelationshipEN.CodeTabCondition = objRow[convcc_CourseExamPaperRelationship.CodeTabCondition] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCondition].ToString().Trim(); //代码表_条件
objvcc_CourseExamPaperRelationshipEN.RelaEvent = objRow[convcc_CourseExamPaperRelationship.RelaEvent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.RelaEvent].ToString().Trim(); //相关事件
objvcc_CourseExamPaperRelationshipEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.FirstIndent].ToString().Trim()); //首行缩进
objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem = objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem].ToString().Trim(); //默认选项
objvcc_CourseExamPaperRelationshipEN.FillInTextHeight = objRow[convcc_CourseExamPaperRelationship.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.FillInTextHeight].ToString().Trim()); //填空框高度
objvcc_CourseExamPaperRelationshipEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvcc_CourseExamPaperRelationshipEN.CheckBoxLimitCount = objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_CourseExamPaperRelationshipEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationshipEN.UserId = objRow[convcc_CourseExamPaperRelationship.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationshipEN.StartTime = objRow[convcc_CourseExamPaperRelationship.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaperRelationship.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationshipEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationshipEN.TopicScores = objRow[convcc_CourseExamPaperRelationship.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationshipEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship.TopicOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationshipEN.OrderNum = objRow[convcc_CourseExamPaperRelationship.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationshipEN.UpdDate = objRow[convcc_CourseExamPaperRelationship.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationshipEN.UpdUser = objRow[convcc_CourseExamPaperRelationship.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperRelationshipEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperRelationshipEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_CourseExamPaperRelationshipEN> GetSubObjLstCache(clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipCond)
{
 string strCourseId = objvcc_CourseExamPaperRelationshipCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvcc_CourseExamPaperRelationshipBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvcc_CourseExamPaperRelationshipEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseExamPaperRelationshipEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseExamPaperRelationship.AttributeName)
{
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseExamPaperRelationshipCond[strFldName].ToString());
}
else
{
if (objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseExamPaperRelationshipCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseExamPaperRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseExamPaperRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseExamPaperRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseExamPaperRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseExamPaperRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseExamPaperRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseExamPaperRelationshipCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseExamPaperRelationshipCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseExamPaperRelationshipCond[strFldName]));
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
public static List<clsvcc_CourseExamPaperRelationshipEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_CourseExamPaperRelationshipEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationshipEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = new clsvcc_CourseExamPaperRelationshipEN();
try
{
objvcc_CourseExamPaperRelationshipEN.mId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationshipEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationshipEN.CourseId = objRow[convcc_CourseExamPaperRelationship.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationshipEN.CourseName = objRow[convcc_CourseExamPaperRelationship.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationshipEN.QuestionId = objRow[convcc_CourseExamPaperRelationship.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationshipEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationshipEN.QuestionName = objRow[convcc_CourseExamPaperRelationship.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationshipEN.QuestionContent = objRow[convcc_CourseExamPaperRelationship.QuestionContent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionContent].ToString().Trim(); //题目内容
objvcc_CourseExamPaperRelationshipEN.ExamAnswer = objRow[convcc_CourseExamPaperRelationship.ExamAnswer] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamAnswer].ToString().Trim(); //题目答案
objvcc_CourseExamPaperRelationshipEN.CourseChapterId = objRow[convcc_CourseExamPaperRelationship.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperRelationshipEN.CourseChapterName = objRow[convcc_CourseExamPaperRelationship.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperRelationshipEN.ParentNodeId = objRow[convcc_CourseExamPaperRelationship.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseExamPaperRelationshipEN.ParentNodeName = objRow[convcc_CourseExamPaperRelationship.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseExamPaperRelationshipEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationshipEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationshipEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationshipEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationshipEN.AnswerTypeId = objRow[convcc_CourseExamPaperRelationship.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_CourseExamPaperRelationshipEN.AnswerModeId = objRow[convcc_CourseExamPaperRelationship.AnswerModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_CourseExamPaperRelationshipEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvcc_CourseExamPaperRelationshipEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convcc_CourseExamPaperRelationship.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd = objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd].ToString().Trim(); //题目补充
objvcc_CourseExamPaperRelationshipEN.DefaultValue = objRow[convcc_CourseExamPaperRelationship.DefaultValue] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultValue].ToString().Trim(); //缺省值
objvcc_CourseExamPaperRelationshipEN.TextDirectId = objRow[convcc_CourseExamPaperRelationship.TextDirectId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_CourseExamPaperRelationshipEN.FillInTextWidth = objRow[convcc_CourseExamPaperRelationship.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.FillInTextWidth].ToString().Trim()); //填空框宽度
objvcc_CourseExamPaperRelationshipEN.MemoTextWidth = objRow[convcc_CourseExamPaperRelationship.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.MemoTextWidth].ToString().Trim()); //备注框宽度
objvcc_CourseExamPaperRelationshipEN.CodeTab = objRow[convcc_CourseExamPaperRelationship.CodeTab] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTab].ToString().Trim(); //代码表
objvcc_CourseExamPaperRelationshipEN.CodeTabCode = objRow[convcc_CourseExamPaperRelationship.CodeTabCode] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvcc_CourseExamPaperRelationshipEN.CodeTabName = objRow[convcc_CourseExamPaperRelationship.CodeTabName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabName].ToString().Trim(); //CodeTab_Name
objvcc_CourseExamPaperRelationshipEN.CodeTabCondition = objRow[convcc_CourseExamPaperRelationship.CodeTabCondition] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCondition].ToString().Trim(); //代码表_条件
objvcc_CourseExamPaperRelationshipEN.RelaEvent = objRow[convcc_CourseExamPaperRelationship.RelaEvent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.RelaEvent].ToString().Trim(); //相关事件
objvcc_CourseExamPaperRelationshipEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.FirstIndent].ToString().Trim()); //首行缩进
objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem = objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem].ToString().Trim(); //默认选项
objvcc_CourseExamPaperRelationshipEN.FillInTextHeight = objRow[convcc_CourseExamPaperRelationship.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.FillInTextHeight].ToString().Trim()); //填空框高度
objvcc_CourseExamPaperRelationshipEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvcc_CourseExamPaperRelationshipEN.CheckBoxLimitCount = objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_CourseExamPaperRelationshipEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationshipEN.UserId = objRow[convcc_CourseExamPaperRelationship.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationshipEN.StartTime = objRow[convcc_CourseExamPaperRelationship.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaperRelationship.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationshipEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationshipEN.TopicScores = objRow[convcc_CourseExamPaperRelationship.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationshipEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship.TopicOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationshipEN.OrderNum = objRow[convcc_CourseExamPaperRelationship.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationshipEN.UpdDate = objRow[convcc_CourseExamPaperRelationship.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationshipEN.UpdUser = objRow[convcc_CourseExamPaperRelationship.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperRelationshipEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperRelationshipEN);
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
public static List<clsvcc_CourseExamPaperRelationshipEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_CourseExamPaperRelationshipEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationshipEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = new clsvcc_CourseExamPaperRelationshipEN();
try
{
objvcc_CourseExamPaperRelationshipEN.mId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationshipEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationshipEN.CourseId = objRow[convcc_CourseExamPaperRelationship.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationshipEN.CourseName = objRow[convcc_CourseExamPaperRelationship.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationshipEN.QuestionId = objRow[convcc_CourseExamPaperRelationship.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationshipEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationshipEN.QuestionName = objRow[convcc_CourseExamPaperRelationship.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationshipEN.QuestionContent = objRow[convcc_CourseExamPaperRelationship.QuestionContent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionContent].ToString().Trim(); //题目内容
objvcc_CourseExamPaperRelationshipEN.ExamAnswer = objRow[convcc_CourseExamPaperRelationship.ExamAnswer] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamAnswer].ToString().Trim(); //题目答案
objvcc_CourseExamPaperRelationshipEN.CourseChapterId = objRow[convcc_CourseExamPaperRelationship.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperRelationshipEN.CourseChapterName = objRow[convcc_CourseExamPaperRelationship.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperRelationshipEN.ParentNodeId = objRow[convcc_CourseExamPaperRelationship.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseExamPaperRelationshipEN.ParentNodeName = objRow[convcc_CourseExamPaperRelationship.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseExamPaperRelationshipEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationshipEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationshipEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationshipEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationshipEN.AnswerTypeId = objRow[convcc_CourseExamPaperRelationship.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_CourseExamPaperRelationshipEN.AnswerModeId = objRow[convcc_CourseExamPaperRelationship.AnswerModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_CourseExamPaperRelationshipEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvcc_CourseExamPaperRelationshipEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convcc_CourseExamPaperRelationship.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd = objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd].ToString().Trim(); //题目补充
objvcc_CourseExamPaperRelationshipEN.DefaultValue = objRow[convcc_CourseExamPaperRelationship.DefaultValue] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultValue].ToString().Trim(); //缺省值
objvcc_CourseExamPaperRelationshipEN.TextDirectId = objRow[convcc_CourseExamPaperRelationship.TextDirectId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_CourseExamPaperRelationshipEN.FillInTextWidth = objRow[convcc_CourseExamPaperRelationship.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.FillInTextWidth].ToString().Trim()); //填空框宽度
objvcc_CourseExamPaperRelationshipEN.MemoTextWidth = objRow[convcc_CourseExamPaperRelationship.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.MemoTextWidth].ToString().Trim()); //备注框宽度
objvcc_CourseExamPaperRelationshipEN.CodeTab = objRow[convcc_CourseExamPaperRelationship.CodeTab] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTab].ToString().Trim(); //代码表
objvcc_CourseExamPaperRelationshipEN.CodeTabCode = objRow[convcc_CourseExamPaperRelationship.CodeTabCode] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvcc_CourseExamPaperRelationshipEN.CodeTabName = objRow[convcc_CourseExamPaperRelationship.CodeTabName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabName].ToString().Trim(); //CodeTab_Name
objvcc_CourseExamPaperRelationshipEN.CodeTabCondition = objRow[convcc_CourseExamPaperRelationship.CodeTabCondition] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCondition].ToString().Trim(); //代码表_条件
objvcc_CourseExamPaperRelationshipEN.RelaEvent = objRow[convcc_CourseExamPaperRelationship.RelaEvent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.RelaEvent].ToString().Trim(); //相关事件
objvcc_CourseExamPaperRelationshipEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.FirstIndent].ToString().Trim()); //首行缩进
objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem = objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem].ToString().Trim(); //默认选项
objvcc_CourseExamPaperRelationshipEN.FillInTextHeight = objRow[convcc_CourseExamPaperRelationship.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.FillInTextHeight].ToString().Trim()); //填空框高度
objvcc_CourseExamPaperRelationshipEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvcc_CourseExamPaperRelationshipEN.CheckBoxLimitCount = objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_CourseExamPaperRelationshipEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationshipEN.UserId = objRow[convcc_CourseExamPaperRelationship.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationshipEN.StartTime = objRow[convcc_CourseExamPaperRelationship.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaperRelationship.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationshipEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationshipEN.TopicScores = objRow[convcc_CourseExamPaperRelationship.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationshipEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship.TopicOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationshipEN.OrderNum = objRow[convcc_CourseExamPaperRelationship.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationshipEN.UpdDate = objRow[convcc_CourseExamPaperRelationship.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationshipEN.UpdUser = objRow[convcc_CourseExamPaperRelationship.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperRelationshipEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperRelationshipEN);
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
List<clsvcc_CourseExamPaperRelationshipEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_CourseExamPaperRelationshipEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseExamPaperRelationshipEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_CourseExamPaperRelationshipEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseExamPaperRelationshipEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationshipEN>(); 
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
	clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = new clsvcc_CourseExamPaperRelationshipEN();
try
{
objvcc_CourseExamPaperRelationshipEN.mId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationshipEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationshipEN.CourseId = objRow[convcc_CourseExamPaperRelationship.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationshipEN.CourseName = objRow[convcc_CourseExamPaperRelationship.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationshipEN.QuestionId = objRow[convcc_CourseExamPaperRelationship.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationshipEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationshipEN.QuestionName = objRow[convcc_CourseExamPaperRelationship.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationshipEN.QuestionContent = objRow[convcc_CourseExamPaperRelationship.QuestionContent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionContent].ToString().Trim(); //题目内容
objvcc_CourseExamPaperRelationshipEN.ExamAnswer = objRow[convcc_CourseExamPaperRelationship.ExamAnswer] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamAnswer].ToString().Trim(); //题目答案
objvcc_CourseExamPaperRelationshipEN.CourseChapterId = objRow[convcc_CourseExamPaperRelationship.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperRelationshipEN.CourseChapterName = objRow[convcc_CourseExamPaperRelationship.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperRelationshipEN.ParentNodeId = objRow[convcc_CourseExamPaperRelationship.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseExamPaperRelationshipEN.ParentNodeName = objRow[convcc_CourseExamPaperRelationship.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseExamPaperRelationshipEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationshipEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationshipEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationshipEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationshipEN.AnswerTypeId = objRow[convcc_CourseExamPaperRelationship.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_CourseExamPaperRelationshipEN.AnswerModeId = objRow[convcc_CourseExamPaperRelationship.AnswerModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_CourseExamPaperRelationshipEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvcc_CourseExamPaperRelationshipEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convcc_CourseExamPaperRelationship.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd = objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd].ToString().Trim(); //题目补充
objvcc_CourseExamPaperRelationshipEN.DefaultValue = objRow[convcc_CourseExamPaperRelationship.DefaultValue] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultValue].ToString().Trim(); //缺省值
objvcc_CourseExamPaperRelationshipEN.TextDirectId = objRow[convcc_CourseExamPaperRelationship.TextDirectId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_CourseExamPaperRelationshipEN.FillInTextWidth = objRow[convcc_CourseExamPaperRelationship.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.FillInTextWidth].ToString().Trim()); //填空框宽度
objvcc_CourseExamPaperRelationshipEN.MemoTextWidth = objRow[convcc_CourseExamPaperRelationship.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.MemoTextWidth].ToString().Trim()); //备注框宽度
objvcc_CourseExamPaperRelationshipEN.CodeTab = objRow[convcc_CourseExamPaperRelationship.CodeTab] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTab].ToString().Trim(); //代码表
objvcc_CourseExamPaperRelationshipEN.CodeTabCode = objRow[convcc_CourseExamPaperRelationship.CodeTabCode] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvcc_CourseExamPaperRelationshipEN.CodeTabName = objRow[convcc_CourseExamPaperRelationship.CodeTabName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabName].ToString().Trim(); //CodeTab_Name
objvcc_CourseExamPaperRelationshipEN.CodeTabCondition = objRow[convcc_CourseExamPaperRelationship.CodeTabCondition] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCondition].ToString().Trim(); //代码表_条件
objvcc_CourseExamPaperRelationshipEN.RelaEvent = objRow[convcc_CourseExamPaperRelationship.RelaEvent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.RelaEvent].ToString().Trim(); //相关事件
objvcc_CourseExamPaperRelationshipEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.FirstIndent].ToString().Trim()); //首行缩进
objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem = objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem].ToString().Trim(); //默认选项
objvcc_CourseExamPaperRelationshipEN.FillInTextHeight = objRow[convcc_CourseExamPaperRelationship.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.FillInTextHeight].ToString().Trim()); //填空框高度
objvcc_CourseExamPaperRelationshipEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvcc_CourseExamPaperRelationshipEN.CheckBoxLimitCount = objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_CourseExamPaperRelationshipEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationshipEN.UserId = objRow[convcc_CourseExamPaperRelationship.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationshipEN.StartTime = objRow[convcc_CourseExamPaperRelationship.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaperRelationship.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationshipEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationshipEN.TopicScores = objRow[convcc_CourseExamPaperRelationship.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationshipEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship.TopicOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationshipEN.OrderNum = objRow[convcc_CourseExamPaperRelationship.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationshipEN.UpdDate = objRow[convcc_CourseExamPaperRelationship.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationshipEN.UpdUser = objRow[convcc_CourseExamPaperRelationship.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperRelationshipEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperRelationshipEN);
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
public static List<clsvcc_CourseExamPaperRelationshipEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseExamPaperRelationshipEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationshipEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = new clsvcc_CourseExamPaperRelationshipEN();
try
{
objvcc_CourseExamPaperRelationshipEN.mId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationshipEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationshipEN.CourseId = objRow[convcc_CourseExamPaperRelationship.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationshipEN.CourseName = objRow[convcc_CourseExamPaperRelationship.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationshipEN.QuestionId = objRow[convcc_CourseExamPaperRelationship.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationshipEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationshipEN.QuestionName = objRow[convcc_CourseExamPaperRelationship.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationshipEN.QuestionContent = objRow[convcc_CourseExamPaperRelationship.QuestionContent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionContent].ToString().Trim(); //题目内容
objvcc_CourseExamPaperRelationshipEN.ExamAnswer = objRow[convcc_CourseExamPaperRelationship.ExamAnswer] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamAnswer].ToString().Trim(); //题目答案
objvcc_CourseExamPaperRelationshipEN.CourseChapterId = objRow[convcc_CourseExamPaperRelationship.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperRelationshipEN.CourseChapterName = objRow[convcc_CourseExamPaperRelationship.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperRelationshipEN.ParentNodeId = objRow[convcc_CourseExamPaperRelationship.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseExamPaperRelationshipEN.ParentNodeName = objRow[convcc_CourseExamPaperRelationship.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseExamPaperRelationshipEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationshipEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationshipEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationshipEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationshipEN.AnswerTypeId = objRow[convcc_CourseExamPaperRelationship.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_CourseExamPaperRelationshipEN.AnswerModeId = objRow[convcc_CourseExamPaperRelationship.AnswerModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_CourseExamPaperRelationshipEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvcc_CourseExamPaperRelationshipEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convcc_CourseExamPaperRelationship.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd = objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd].ToString().Trim(); //题目补充
objvcc_CourseExamPaperRelationshipEN.DefaultValue = objRow[convcc_CourseExamPaperRelationship.DefaultValue] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultValue].ToString().Trim(); //缺省值
objvcc_CourseExamPaperRelationshipEN.TextDirectId = objRow[convcc_CourseExamPaperRelationship.TextDirectId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_CourseExamPaperRelationshipEN.FillInTextWidth = objRow[convcc_CourseExamPaperRelationship.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.FillInTextWidth].ToString().Trim()); //填空框宽度
objvcc_CourseExamPaperRelationshipEN.MemoTextWidth = objRow[convcc_CourseExamPaperRelationship.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.MemoTextWidth].ToString().Trim()); //备注框宽度
objvcc_CourseExamPaperRelationshipEN.CodeTab = objRow[convcc_CourseExamPaperRelationship.CodeTab] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTab].ToString().Trim(); //代码表
objvcc_CourseExamPaperRelationshipEN.CodeTabCode = objRow[convcc_CourseExamPaperRelationship.CodeTabCode] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvcc_CourseExamPaperRelationshipEN.CodeTabName = objRow[convcc_CourseExamPaperRelationship.CodeTabName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabName].ToString().Trim(); //CodeTab_Name
objvcc_CourseExamPaperRelationshipEN.CodeTabCondition = objRow[convcc_CourseExamPaperRelationship.CodeTabCondition] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCondition].ToString().Trim(); //代码表_条件
objvcc_CourseExamPaperRelationshipEN.RelaEvent = objRow[convcc_CourseExamPaperRelationship.RelaEvent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.RelaEvent].ToString().Trim(); //相关事件
objvcc_CourseExamPaperRelationshipEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.FirstIndent].ToString().Trim()); //首行缩进
objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem = objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem].ToString().Trim(); //默认选项
objvcc_CourseExamPaperRelationshipEN.FillInTextHeight = objRow[convcc_CourseExamPaperRelationship.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.FillInTextHeight].ToString().Trim()); //填空框高度
objvcc_CourseExamPaperRelationshipEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvcc_CourseExamPaperRelationshipEN.CheckBoxLimitCount = objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_CourseExamPaperRelationshipEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationshipEN.UserId = objRow[convcc_CourseExamPaperRelationship.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationshipEN.StartTime = objRow[convcc_CourseExamPaperRelationship.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaperRelationship.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationshipEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationshipEN.TopicScores = objRow[convcc_CourseExamPaperRelationship.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationshipEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship.TopicOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationshipEN.OrderNum = objRow[convcc_CourseExamPaperRelationship.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationshipEN.UpdDate = objRow[convcc_CourseExamPaperRelationship.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationshipEN.UpdUser = objRow[convcc_CourseExamPaperRelationship.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperRelationshipEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperRelationshipEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_CourseExamPaperRelationshipEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_CourseExamPaperRelationshipEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseExamPaperRelationshipEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationshipEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = new clsvcc_CourseExamPaperRelationshipEN();
try
{
objvcc_CourseExamPaperRelationshipEN.mId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationshipEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationshipEN.CourseId = objRow[convcc_CourseExamPaperRelationship.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationshipEN.CourseName = objRow[convcc_CourseExamPaperRelationship.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationshipEN.QuestionId = objRow[convcc_CourseExamPaperRelationship.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationshipEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationshipEN.QuestionName = objRow[convcc_CourseExamPaperRelationship.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationshipEN.QuestionContent = objRow[convcc_CourseExamPaperRelationship.QuestionContent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionContent].ToString().Trim(); //题目内容
objvcc_CourseExamPaperRelationshipEN.ExamAnswer = objRow[convcc_CourseExamPaperRelationship.ExamAnswer] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamAnswer].ToString().Trim(); //题目答案
objvcc_CourseExamPaperRelationshipEN.CourseChapterId = objRow[convcc_CourseExamPaperRelationship.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperRelationshipEN.CourseChapterName = objRow[convcc_CourseExamPaperRelationship.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperRelationshipEN.ParentNodeId = objRow[convcc_CourseExamPaperRelationship.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseExamPaperRelationshipEN.ParentNodeName = objRow[convcc_CourseExamPaperRelationship.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseExamPaperRelationshipEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationshipEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationshipEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationshipEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationshipEN.AnswerTypeId = objRow[convcc_CourseExamPaperRelationship.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_CourseExamPaperRelationshipEN.AnswerModeId = objRow[convcc_CourseExamPaperRelationship.AnswerModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_CourseExamPaperRelationshipEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvcc_CourseExamPaperRelationshipEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convcc_CourseExamPaperRelationship.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd = objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd].ToString().Trim(); //题目补充
objvcc_CourseExamPaperRelationshipEN.DefaultValue = objRow[convcc_CourseExamPaperRelationship.DefaultValue] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultValue].ToString().Trim(); //缺省值
objvcc_CourseExamPaperRelationshipEN.TextDirectId = objRow[convcc_CourseExamPaperRelationship.TextDirectId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_CourseExamPaperRelationshipEN.FillInTextWidth = objRow[convcc_CourseExamPaperRelationship.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.FillInTextWidth].ToString().Trim()); //填空框宽度
objvcc_CourseExamPaperRelationshipEN.MemoTextWidth = objRow[convcc_CourseExamPaperRelationship.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.MemoTextWidth].ToString().Trim()); //备注框宽度
objvcc_CourseExamPaperRelationshipEN.CodeTab = objRow[convcc_CourseExamPaperRelationship.CodeTab] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTab].ToString().Trim(); //代码表
objvcc_CourseExamPaperRelationshipEN.CodeTabCode = objRow[convcc_CourseExamPaperRelationship.CodeTabCode] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvcc_CourseExamPaperRelationshipEN.CodeTabName = objRow[convcc_CourseExamPaperRelationship.CodeTabName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabName].ToString().Trim(); //CodeTab_Name
objvcc_CourseExamPaperRelationshipEN.CodeTabCondition = objRow[convcc_CourseExamPaperRelationship.CodeTabCondition] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCondition].ToString().Trim(); //代码表_条件
objvcc_CourseExamPaperRelationshipEN.RelaEvent = objRow[convcc_CourseExamPaperRelationship.RelaEvent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.RelaEvent].ToString().Trim(); //相关事件
objvcc_CourseExamPaperRelationshipEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.FirstIndent].ToString().Trim()); //首行缩进
objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem = objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem].ToString().Trim(); //默认选项
objvcc_CourseExamPaperRelationshipEN.FillInTextHeight = objRow[convcc_CourseExamPaperRelationship.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.FillInTextHeight].ToString().Trim()); //填空框高度
objvcc_CourseExamPaperRelationshipEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvcc_CourseExamPaperRelationshipEN.CheckBoxLimitCount = objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_CourseExamPaperRelationshipEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationshipEN.UserId = objRow[convcc_CourseExamPaperRelationship.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationshipEN.StartTime = objRow[convcc_CourseExamPaperRelationship.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaperRelationship.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationshipEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationshipEN.TopicScores = objRow[convcc_CourseExamPaperRelationship.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationshipEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship.TopicOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationshipEN.OrderNum = objRow[convcc_CourseExamPaperRelationship.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationshipEN.UpdDate = objRow[convcc_CourseExamPaperRelationship.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationshipEN.UpdUser = objRow[convcc_CourseExamPaperRelationship.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperRelationshipEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperRelationshipEN);
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
public static List<clsvcc_CourseExamPaperRelationshipEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_CourseExamPaperRelationshipEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationshipEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = new clsvcc_CourseExamPaperRelationshipEN();
try
{
objvcc_CourseExamPaperRelationshipEN.mId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationshipEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationshipEN.CourseId = objRow[convcc_CourseExamPaperRelationship.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationshipEN.CourseName = objRow[convcc_CourseExamPaperRelationship.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationshipEN.QuestionId = objRow[convcc_CourseExamPaperRelationship.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationshipEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationshipEN.QuestionName = objRow[convcc_CourseExamPaperRelationship.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationshipEN.QuestionContent = objRow[convcc_CourseExamPaperRelationship.QuestionContent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionContent].ToString().Trim(); //题目内容
objvcc_CourseExamPaperRelationshipEN.ExamAnswer = objRow[convcc_CourseExamPaperRelationship.ExamAnswer] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamAnswer].ToString().Trim(); //题目答案
objvcc_CourseExamPaperRelationshipEN.CourseChapterId = objRow[convcc_CourseExamPaperRelationship.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperRelationshipEN.CourseChapterName = objRow[convcc_CourseExamPaperRelationship.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperRelationshipEN.ParentNodeId = objRow[convcc_CourseExamPaperRelationship.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseExamPaperRelationshipEN.ParentNodeName = objRow[convcc_CourseExamPaperRelationship.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseExamPaperRelationshipEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationshipEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationshipEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationshipEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationshipEN.AnswerTypeId = objRow[convcc_CourseExamPaperRelationship.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_CourseExamPaperRelationshipEN.AnswerModeId = objRow[convcc_CourseExamPaperRelationship.AnswerModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_CourseExamPaperRelationshipEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvcc_CourseExamPaperRelationshipEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convcc_CourseExamPaperRelationship.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd = objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd].ToString().Trim(); //题目补充
objvcc_CourseExamPaperRelationshipEN.DefaultValue = objRow[convcc_CourseExamPaperRelationship.DefaultValue] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultValue].ToString().Trim(); //缺省值
objvcc_CourseExamPaperRelationshipEN.TextDirectId = objRow[convcc_CourseExamPaperRelationship.TextDirectId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_CourseExamPaperRelationshipEN.FillInTextWidth = objRow[convcc_CourseExamPaperRelationship.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.FillInTextWidth].ToString().Trim()); //填空框宽度
objvcc_CourseExamPaperRelationshipEN.MemoTextWidth = objRow[convcc_CourseExamPaperRelationship.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.MemoTextWidth].ToString().Trim()); //备注框宽度
objvcc_CourseExamPaperRelationshipEN.CodeTab = objRow[convcc_CourseExamPaperRelationship.CodeTab] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTab].ToString().Trim(); //代码表
objvcc_CourseExamPaperRelationshipEN.CodeTabCode = objRow[convcc_CourseExamPaperRelationship.CodeTabCode] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvcc_CourseExamPaperRelationshipEN.CodeTabName = objRow[convcc_CourseExamPaperRelationship.CodeTabName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabName].ToString().Trim(); //CodeTab_Name
objvcc_CourseExamPaperRelationshipEN.CodeTabCondition = objRow[convcc_CourseExamPaperRelationship.CodeTabCondition] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCondition].ToString().Trim(); //代码表_条件
objvcc_CourseExamPaperRelationshipEN.RelaEvent = objRow[convcc_CourseExamPaperRelationship.RelaEvent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.RelaEvent].ToString().Trim(); //相关事件
objvcc_CourseExamPaperRelationshipEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.FirstIndent].ToString().Trim()); //首行缩进
objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem = objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem].ToString().Trim(); //默认选项
objvcc_CourseExamPaperRelationshipEN.FillInTextHeight = objRow[convcc_CourseExamPaperRelationship.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.FillInTextHeight].ToString().Trim()); //填空框高度
objvcc_CourseExamPaperRelationshipEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvcc_CourseExamPaperRelationshipEN.CheckBoxLimitCount = objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_CourseExamPaperRelationshipEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationshipEN.UserId = objRow[convcc_CourseExamPaperRelationship.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationshipEN.StartTime = objRow[convcc_CourseExamPaperRelationship.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaperRelationship.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationshipEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationshipEN.TopicScores = objRow[convcc_CourseExamPaperRelationship.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationshipEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship.TopicOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationshipEN.OrderNum = objRow[convcc_CourseExamPaperRelationship.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationshipEN.UpdDate = objRow[convcc_CourseExamPaperRelationship.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationshipEN.UpdUser = objRow[convcc_CourseExamPaperRelationship.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperRelationshipEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperRelationshipEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseExamPaperRelationshipEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_CourseExamPaperRelationshipEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationshipEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = new clsvcc_CourseExamPaperRelationshipEN();
try
{
objvcc_CourseExamPaperRelationshipEN.mId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationshipEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationshipEN.CourseId = objRow[convcc_CourseExamPaperRelationship.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationshipEN.CourseName = objRow[convcc_CourseExamPaperRelationship.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationshipEN.QuestionId = objRow[convcc_CourseExamPaperRelationship.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationshipEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationshipEN.QuestionName = objRow[convcc_CourseExamPaperRelationship.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationshipEN.QuestionContent = objRow[convcc_CourseExamPaperRelationship.QuestionContent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionContent].ToString().Trim(); //题目内容
objvcc_CourseExamPaperRelationshipEN.ExamAnswer = objRow[convcc_CourseExamPaperRelationship.ExamAnswer] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamAnswer].ToString().Trim(); //题目答案
objvcc_CourseExamPaperRelationshipEN.CourseChapterId = objRow[convcc_CourseExamPaperRelationship.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperRelationshipEN.CourseChapterName = objRow[convcc_CourseExamPaperRelationship.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperRelationshipEN.ParentNodeId = objRow[convcc_CourseExamPaperRelationship.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseExamPaperRelationshipEN.ParentNodeName = objRow[convcc_CourseExamPaperRelationship.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseExamPaperRelationshipEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationshipEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationshipEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationshipEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationshipEN.AnswerTypeId = objRow[convcc_CourseExamPaperRelationship.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_CourseExamPaperRelationshipEN.AnswerModeId = objRow[convcc_CourseExamPaperRelationship.AnswerModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_CourseExamPaperRelationshipEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvcc_CourseExamPaperRelationshipEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convcc_CourseExamPaperRelationship.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd = objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd].ToString().Trim(); //题目补充
objvcc_CourseExamPaperRelationshipEN.DefaultValue = objRow[convcc_CourseExamPaperRelationship.DefaultValue] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultValue].ToString().Trim(); //缺省值
objvcc_CourseExamPaperRelationshipEN.TextDirectId = objRow[convcc_CourseExamPaperRelationship.TextDirectId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_CourseExamPaperRelationshipEN.FillInTextWidth = objRow[convcc_CourseExamPaperRelationship.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.FillInTextWidth].ToString().Trim()); //填空框宽度
objvcc_CourseExamPaperRelationshipEN.MemoTextWidth = objRow[convcc_CourseExamPaperRelationship.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.MemoTextWidth].ToString().Trim()); //备注框宽度
objvcc_CourseExamPaperRelationshipEN.CodeTab = objRow[convcc_CourseExamPaperRelationship.CodeTab] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTab].ToString().Trim(); //代码表
objvcc_CourseExamPaperRelationshipEN.CodeTabCode = objRow[convcc_CourseExamPaperRelationship.CodeTabCode] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvcc_CourseExamPaperRelationshipEN.CodeTabName = objRow[convcc_CourseExamPaperRelationship.CodeTabName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabName].ToString().Trim(); //CodeTab_Name
objvcc_CourseExamPaperRelationshipEN.CodeTabCondition = objRow[convcc_CourseExamPaperRelationship.CodeTabCondition] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCondition].ToString().Trim(); //代码表_条件
objvcc_CourseExamPaperRelationshipEN.RelaEvent = objRow[convcc_CourseExamPaperRelationship.RelaEvent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.RelaEvent].ToString().Trim(); //相关事件
objvcc_CourseExamPaperRelationshipEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.FirstIndent].ToString().Trim()); //首行缩进
objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem = objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem].ToString().Trim(); //默认选项
objvcc_CourseExamPaperRelationshipEN.FillInTextHeight = objRow[convcc_CourseExamPaperRelationship.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.FillInTextHeight].ToString().Trim()); //填空框高度
objvcc_CourseExamPaperRelationshipEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvcc_CourseExamPaperRelationshipEN.CheckBoxLimitCount = objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_CourseExamPaperRelationshipEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationshipEN.UserId = objRow[convcc_CourseExamPaperRelationship.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationshipEN.StartTime = objRow[convcc_CourseExamPaperRelationship.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaperRelationship.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationshipEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationshipEN.TopicScores = objRow[convcc_CourseExamPaperRelationship.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationshipEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship.TopicOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationshipEN.OrderNum = objRow[convcc_CourseExamPaperRelationship.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationshipEN.UpdDate = objRow[convcc_CourseExamPaperRelationship.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationshipEN.UpdUser = objRow[convcc_CourseExamPaperRelationship.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperRelationshipEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperRelationshipEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_CourseExamPaperRelationship(ref clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN)
{
bool bolResult = vcc_CourseExamPaperRelationshipDA.Getvcc_CourseExamPaperRelationship(ref objvcc_CourseExamPaperRelationshipEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseExamPaperRelationshipEN GetObjBymId(long lngmId)
{
clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = vcc_CourseExamPaperRelationshipDA.GetObjBymId(lngmId);
return objvcc_CourseExamPaperRelationshipEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_CourseExamPaperRelationshipEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = vcc_CourseExamPaperRelationshipDA.GetFirstObj(strWhereCond);
 return objvcc_CourseExamPaperRelationshipEN;
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
public static clsvcc_CourseExamPaperRelationshipEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = vcc_CourseExamPaperRelationshipDA.GetObjByDataRow(objRow);
 return objvcc_CourseExamPaperRelationshipEN;
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
public static clsvcc_CourseExamPaperRelationshipEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = vcc_CourseExamPaperRelationshipDA.GetObjByDataRow(objRow);
 return objvcc_CourseExamPaperRelationshipEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvcc_CourseExamPaperRelationshipObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseExamPaperRelationshipEN GetObjBymIdFromList(long lngmId, List<clsvcc_CourseExamPaperRelationshipEN> lstvcc_CourseExamPaperRelationshipObjLst)
{
foreach (clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN in lstvcc_CourseExamPaperRelationshipObjLst)
{
if (objvcc_CourseExamPaperRelationshipEN.mId == lngmId)
{
return objvcc_CourseExamPaperRelationshipEN;
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
 long lngmId;
 try
 {
 lngmId = new clsvcc_CourseExamPaperRelationshipDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vcc_CourseExamPaperRelationshipDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_CourseExamPaperRelationshipDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vcc_CourseExamPaperRelationshipDA.IsExist(lngmId);
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
 bolIsExist = clsvcc_CourseExamPaperRelationshipDA.IsExistTable();
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
 bolIsExist = vcc_CourseExamPaperRelationshipDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_CourseExamPaperRelationshipENS">源对象</param>
 /// <param name = "objvcc_CourseExamPaperRelationshipENT">目标对象</param>
 public static void CopyTo(clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipENS, clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipENT)
{
try
{
objvcc_CourseExamPaperRelationshipENT.mId = objvcc_CourseExamPaperRelationshipENS.mId; //mId
objvcc_CourseExamPaperRelationshipENT.CourseExamPaperId = objvcc_CourseExamPaperRelationshipENS.CourseExamPaperId; //考卷流水号
objvcc_CourseExamPaperRelationshipENT.ExamPaperName = objvcc_CourseExamPaperRelationshipENS.ExamPaperName; //考卷名称
objvcc_CourseExamPaperRelationshipENT.CourseId = objvcc_CourseExamPaperRelationshipENS.CourseId; //课程Id
objvcc_CourseExamPaperRelationshipENT.CourseName = objvcc_CourseExamPaperRelationshipENS.CourseName; //课程名称
objvcc_CourseExamPaperRelationshipENT.QuestionId = objvcc_CourseExamPaperRelationshipENS.QuestionId; //题目Id
objvcc_CourseExamPaperRelationshipENT.QuestionIndex = objvcc_CourseExamPaperRelationshipENS.QuestionIndex; //题目序号
objvcc_CourseExamPaperRelationshipENT.QuestionName = objvcc_CourseExamPaperRelationshipENS.QuestionName; //题目名称
objvcc_CourseExamPaperRelationshipENT.QuestionContent = objvcc_CourseExamPaperRelationshipENS.QuestionContent; //题目内容
objvcc_CourseExamPaperRelationshipENT.ExamAnswer = objvcc_CourseExamPaperRelationshipENS.ExamAnswer; //题目答案
objvcc_CourseExamPaperRelationshipENT.CourseChapterId = objvcc_CourseExamPaperRelationshipENS.CourseChapterId; //课程章节ID
objvcc_CourseExamPaperRelationshipENT.CourseChapterName = objvcc_CourseExamPaperRelationshipENS.CourseChapterName; //课程章节名称
objvcc_CourseExamPaperRelationshipENT.ParentNodeId = objvcc_CourseExamPaperRelationshipENS.ParentNodeId; //父节点编号
objvcc_CourseExamPaperRelationshipENT.ParentNodeName = objvcc_CourseExamPaperRelationshipENS.ParentNodeName; //父节点名称
objvcc_CourseExamPaperRelationshipENT.QuestionTypeId = objvcc_CourseExamPaperRelationshipENS.QuestionTypeId; //题目类型Id
objvcc_CourseExamPaperRelationshipENT.QuestionTypeName = objvcc_CourseExamPaperRelationshipENS.QuestionTypeName; //题目类型名
objvcc_CourseExamPaperRelationshipENT.ExamGradeId = objvcc_CourseExamPaperRelationshipENS.ExamGradeId; //题库等级ID
objvcc_CourseExamPaperRelationshipENT.ExamGradeName = objvcc_CourseExamPaperRelationshipENS.ExamGradeName; //题库等级名
objvcc_CourseExamPaperRelationshipENT.AnswerTypeId = objvcc_CourseExamPaperRelationshipENS.AnswerTypeId; //答案类型ID
objvcc_CourseExamPaperRelationshipENT.AnswerModeId = objvcc_CourseExamPaperRelationshipENS.AnswerModeId; //答案模式Id
objvcc_CourseExamPaperRelationshipENT.IsHaveAdditionalMemo = objvcc_CourseExamPaperRelationshipENS.IsHaveAdditionalMemo; //是否有附加说明
objvcc_CourseExamPaperRelationshipENT.QuestionScore = objvcc_CourseExamPaperRelationshipENS.QuestionScore; //题目得分
objvcc_CourseExamPaperRelationshipENT.QuestionNameAdd = objvcc_CourseExamPaperRelationshipENS.QuestionNameAdd; //题目补充
objvcc_CourseExamPaperRelationshipENT.DefaultValue = objvcc_CourseExamPaperRelationshipENS.DefaultValue; //缺省值
objvcc_CourseExamPaperRelationshipENT.TextDirectId = objvcc_CourseExamPaperRelationshipENS.TextDirectId; //文本方向ID
objvcc_CourseExamPaperRelationshipENT.FillInTextWidth = objvcc_CourseExamPaperRelationshipENS.FillInTextWidth; //填空框宽度
objvcc_CourseExamPaperRelationshipENT.MemoTextWidth = objvcc_CourseExamPaperRelationshipENS.MemoTextWidth; //备注框宽度
objvcc_CourseExamPaperRelationshipENT.CodeTab = objvcc_CourseExamPaperRelationshipENS.CodeTab; //代码表
objvcc_CourseExamPaperRelationshipENT.CodeTabCode = objvcc_CourseExamPaperRelationshipENS.CodeTabCode; //CodeTab_Code
objvcc_CourseExamPaperRelationshipENT.CodeTabName = objvcc_CourseExamPaperRelationshipENS.CodeTabName; //CodeTab_Name
objvcc_CourseExamPaperRelationshipENT.CodeTabCondition = objvcc_CourseExamPaperRelationshipENS.CodeTabCondition; //代码表_条件
objvcc_CourseExamPaperRelationshipENT.RelaEvent = objvcc_CourseExamPaperRelationshipENS.RelaEvent; //相关事件
objvcc_CourseExamPaperRelationshipENT.FirstIndent = objvcc_CourseExamPaperRelationshipENS.FirstIndent; //首行缩进
objvcc_CourseExamPaperRelationshipENT.DefaultSelectItem = objvcc_CourseExamPaperRelationshipENS.DefaultSelectItem; //默认选项
objvcc_CourseExamPaperRelationshipENT.FillInTextHeight = objvcc_CourseExamPaperRelationshipENS.FillInTextHeight; //填空框高度
objvcc_CourseExamPaperRelationshipENT.IsMulti4FillInText = objvcc_CourseExamPaperRelationshipENS.IsMulti4FillInText; //是否填空框多行
objvcc_CourseExamPaperRelationshipENT.CheckBoxLimitCount = objvcc_CourseExamPaperRelationshipENS.CheckBoxLimitCount; //复选框限制数
objvcc_CourseExamPaperRelationshipENT.IsEffective = objvcc_CourseExamPaperRelationshipENS.IsEffective; //是否有效
objvcc_CourseExamPaperRelationshipENT.UserId = objvcc_CourseExamPaperRelationshipENS.UserId; //用户ID
objvcc_CourseExamPaperRelationshipENT.StartTime = objvcc_CourseExamPaperRelationshipENS.StartTime; //开始时间(s)
objvcc_CourseExamPaperRelationshipENT.PapersBigTopicId = objvcc_CourseExamPaperRelationshipENS.PapersBigTopicId; //试卷大题目Id
objvcc_CourseExamPaperRelationshipENT.PapersBigTopicName = objvcc_CourseExamPaperRelationshipENS.PapersBigTopicName; //试卷大题目名称
objvcc_CourseExamPaperRelationshipENT.TopicDescription = objvcc_CourseExamPaperRelationshipENS.TopicDescription; //标题描述
objvcc_CourseExamPaperRelationshipENT.TopicScores = objvcc_CourseExamPaperRelationshipENS.TopicScores; //大题得分
objvcc_CourseExamPaperRelationshipENT.TopicOrderNum = objvcc_CourseExamPaperRelationshipENS.TopicOrderNum; //TopicOrderNum
objvcc_CourseExamPaperRelationshipENT.OrderNum = objvcc_CourseExamPaperRelationshipENS.OrderNum; //序号
objvcc_CourseExamPaperRelationshipENT.UpdDate = objvcc_CourseExamPaperRelationshipENS.UpdDate; //修改日期
objvcc_CourseExamPaperRelationshipENT.UpdUser = objvcc_CourseExamPaperRelationshipENS.UpdUser; //修改人
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
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN)
{
try
{
objvcc_CourseExamPaperRelationshipEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_CourseExamPaperRelationshipEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.mId = objvcc_CourseExamPaperRelationshipEN.mId; //mId
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.CourseExamPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId = objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId; //考卷流水号
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.ExamPaperName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.ExamPaperName = objvcc_CourseExamPaperRelationshipEN.ExamPaperName == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.ExamPaperName; //考卷名称
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.CourseId = objvcc_CourseExamPaperRelationshipEN.CourseId == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.CourseName = objvcc_CourseExamPaperRelationshipEN.CourseName == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.QuestionId = objvcc_CourseExamPaperRelationshipEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.QuestionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.QuestionIndex = objvcc_CourseExamPaperRelationshipEN.QuestionIndex; //题目序号
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.QuestionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.QuestionName = objvcc_CourseExamPaperRelationshipEN.QuestionName == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.QuestionName; //题目名称
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.QuestionContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.QuestionContent = objvcc_CourseExamPaperRelationshipEN.QuestionContent == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.QuestionContent; //题目内容
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.ExamAnswer, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.ExamAnswer = objvcc_CourseExamPaperRelationshipEN.ExamAnswer == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.ExamAnswer; //题目答案
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.CourseChapterId = objvcc_CourseExamPaperRelationshipEN.CourseChapterId == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.CourseChapterName = objvcc_CourseExamPaperRelationshipEN.CourseChapterName == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.ParentNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.ParentNodeId = objvcc_CourseExamPaperRelationshipEN.ParentNodeId == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.ParentNodeId; //父节点编号
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.ParentNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.ParentNodeName = objvcc_CourseExamPaperRelationshipEN.ParentNodeName == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.ParentNodeName; //父节点名称
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.QuestionTypeId = objvcc_CourseExamPaperRelationshipEN.QuestionTypeId == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.QuestionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.QuestionTypeName = objvcc_CourseExamPaperRelationshipEN.QuestionTypeName == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.QuestionTypeName; //题目类型名
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.ExamGradeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.ExamGradeId = objvcc_CourseExamPaperRelationshipEN.ExamGradeId == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.ExamGradeId; //题库等级ID
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.ExamGradeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.ExamGradeName = objvcc_CourseExamPaperRelationshipEN.ExamGradeName == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.ExamGradeName; //题库等级名
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.AnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.AnswerTypeId = objvcc_CourseExamPaperRelationshipEN.AnswerTypeId == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.AnswerTypeId; //答案类型ID
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.AnswerModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.AnswerModeId = objvcc_CourseExamPaperRelationshipEN.AnswerModeId == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.AnswerModeId; //答案模式Id
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.IsHaveAdditionalMemo = objvcc_CourseExamPaperRelationshipEN.IsHaveAdditionalMemo; //是否有附加说明
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.QuestionScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.QuestionScore = objvcc_CourseExamPaperRelationshipEN.QuestionScore; //题目得分
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.QuestionNameAdd, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd = objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd; //题目补充
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.DefaultValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.DefaultValue = objvcc_CourseExamPaperRelationshipEN.DefaultValue == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.DefaultValue; //缺省值
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.TextDirectId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.TextDirectId = objvcc_CourseExamPaperRelationshipEN.TextDirectId == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.TextDirectId; //文本方向ID
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.FillInTextWidth, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.FillInTextWidth = objvcc_CourseExamPaperRelationshipEN.FillInTextWidth; //填空框宽度
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.MemoTextWidth, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.MemoTextWidth = objvcc_CourseExamPaperRelationshipEN.MemoTextWidth; //备注框宽度
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.CodeTab, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.CodeTab = objvcc_CourseExamPaperRelationshipEN.CodeTab == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.CodeTab; //代码表
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.CodeTabCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.CodeTabCode = objvcc_CourseExamPaperRelationshipEN.CodeTabCode == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.CodeTabCode; //CodeTab_Code
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.CodeTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.CodeTabName = objvcc_CourseExamPaperRelationshipEN.CodeTabName == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.CodeTabName; //CodeTab_Name
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.CodeTabCondition, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.CodeTabCondition = objvcc_CourseExamPaperRelationshipEN.CodeTabCondition == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.CodeTabCondition; //代码表_条件
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.RelaEvent, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.RelaEvent = objvcc_CourseExamPaperRelationshipEN.RelaEvent == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.RelaEvent; //相关事件
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.FirstIndent, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.FirstIndent = objvcc_CourseExamPaperRelationshipEN.FirstIndent; //首行缩进
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.DefaultSelectItem, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem = objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem; //默认选项
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.FillInTextHeight, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.FillInTextHeight = objvcc_CourseExamPaperRelationshipEN.FillInTextHeight; //填空框高度
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.IsMulti4FillInText, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.IsMulti4FillInText = objvcc_CourseExamPaperRelationshipEN.IsMulti4FillInText; //是否填空框多行
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.CheckBoxLimitCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.CheckBoxLimitCount = objvcc_CourseExamPaperRelationshipEN.CheckBoxLimitCount; //复选框限制数
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.IsEffective, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.IsEffective = objvcc_CourseExamPaperRelationshipEN.IsEffective; //是否有效
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.UserId = objvcc_CourseExamPaperRelationshipEN.UserId == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.UserId; //用户ID
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.StartTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.StartTime = objvcc_CourseExamPaperRelationshipEN.StartTime; //开始时间(s)
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.PapersBigTopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId = objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId; //试卷大题目Id
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.PapersBigTopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName = objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName; //试卷大题目名称
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.TopicDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.TopicDescription = objvcc_CourseExamPaperRelationshipEN.TopicDescription == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.TopicDescription; //标题描述
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.TopicScores, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.TopicScores = objvcc_CourseExamPaperRelationshipEN.TopicScores; //大题得分
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.TopicOrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.TopicOrderNum = objvcc_CourseExamPaperRelationshipEN.TopicOrderNum; //TopicOrderNum
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.OrderNum = objvcc_CourseExamPaperRelationshipEN.OrderNum; //序号
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.UpdDate = objvcc_CourseExamPaperRelationshipEN.UpdDate == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_CourseExamPaperRelationship.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperRelationshipEN.UpdUser = objvcc_CourseExamPaperRelationshipEN.UpdUser == "[null]" ? null :  objvcc_CourseExamPaperRelationshipEN.UpdUser; //修改人
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
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN)
{
try
{
if (objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId == "[null]") objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId = null; //考卷流水号
if (objvcc_CourseExamPaperRelationshipEN.ExamPaperName == "[null]") objvcc_CourseExamPaperRelationshipEN.ExamPaperName = null; //考卷名称
if (objvcc_CourseExamPaperRelationshipEN.CourseId == "[null]") objvcc_CourseExamPaperRelationshipEN.CourseId = null; //课程Id
if (objvcc_CourseExamPaperRelationshipEN.CourseName == "[null]") objvcc_CourseExamPaperRelationshipEN.CourseName = null; //课程名称
if (objvcc_CourseExamPaperRelationshipEN.QuestionName == "[null]") objvcc_CourseExamPaperRelationshipEN.QuestionName = null; //题目名称
if (objvcc_CourseExamPaperRelationshipEN.QuestionContent == "[null]") objvcc_CourseExamPaperRelationshipEN.QuestionContent = null; //题目内容
if (objvcc_CourseExamPaperRelationshipEN.ExamAnswer == "[null]") objvcc_CourseExamPaperRelationshipEN.ExamAnswer = null; //题目答案
if (objvcc_CourseExamPaperRelationshipEN.CourseChapterId == "[null]") objvcc_CourseExamPaperRelationshipEN.CourseChapterId = null; //课程章节ID
if (objvcc_CourseExamPaperRelationshipEN.CourseChapterName == "[null]") objvcc_CourseExamPaperRelationshipEN.CourseChapterName = null; //课程章节名称
if (objvcc_CourseExamPaperRelationshipEN.ParentNodeId == "[null]") objvcc_CourseExamPaperRelationshipEN.ParentNodeId = null; //父节点编号
if (objvcc_CourseExamPaperRelationshipEN.ParentNodeName == "[null]") objvcc_CourseExamPaperRelationshipEN.ParentNodeName = null; //父节点名称
if (objvcc_CourseExamPaperRelationshipEN.QuestionTypeId == "[null]") objvcc_CourseExamPaperRelationshipEN.QuestionTypeId = null; //题目类型Id
if (objvcc_CourseExamPaperRelationshipEN.QuestionTypeName == "[null]") objvcc_CourseExamPaperRelationshipEN.QuestionTypeName = null; //题目类型名
if (objvcc_CourseExamPaperRelationshipEN.ExamGradeId == "[null]") objvcc_CourseExamPaperRelationshipEN.ExamGradeId = null; //题库等级ID
if (objvcc_CourseExamPaperRelationshipEN.ExamGradeName == "[null]") objvcc_CourseExamPaperRelationshipEN.ExamGradeName = null; //题库等级名
if (objvcc_CourseExamPaperRelationshipEN.AnswerTypeId == "[null]") objvcc_CourseExamPaperRelationshipEN.AnswerTypeId = null; //答案类型ID
if (objvcc_CourseExamPaperRelationshipEN.AnswerModeId == "[null]") objvcc_CourseExamPaperRelationshipEN.AnswerModeId = null; //答案模式Id
if (objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd == "[null]") objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd = null; //题目补充
if (objvcc_CourseExamPaperRelationshipEN.DefaultValue == "[null]") objvcc_CourseExamPaperRelationshipEN.DefaultValue = null; //缺省值
if (objvcc_CourseExamPaperRelationshipEN.TextDirectId == "[null]") objvcc_CourseExamPaperRelationshipEN.TextDirectId = null; //文本方向ID
if (objvcc_CourseExamPaperRelationshipEN.CodeTab == "[null]") objvcc_CourseExamPaperRelationshipEN.CodeTab = null; //代码表
if (objvcc_CourseExamPaperRelationshipEN.CodeTabCode == "[null]") objvcc_CourseExamPaperRelationshipEN.CodeTabCode = null; //CodeTab_Code
if (objvcc_CourseExamPaperRelationshipEN.CodeTabName == "[null]") objvcc_CourseExamPaperRelationshipEN.CodeTabName = null; //CodeTab_Name
if (objvcc_CourseExamPaperRelationshipEN.CodeTabCondition == "[null]") objvcc_CourseExamPaperRelationshipEN.CodeTabCondition = null; //代码表_条件
if (objvcc_CourseExamPaperRelationshipEN.RelaEvent == "[null]") objvcc_CourseExamPaperRelationshipEN.RelaEvent = null; //相关事件
if (objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem == "[null]") objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem = null; //默认选项
if (objvcc_CourseExamPaperRelationshipEN.UserId == "[null]") objvcc_CourseExamPaperRelationshipEN.UserId = null; //用户ID
if (objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId == "[null]") objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId = null; //试卷大题目Id
if (objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName == "[null]") objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName = null; //试卷大题目名称
if (objvcc_CourseExamPaperRelationshipEN.TopicDescription == "[null]") objvcc_CourseExamPaperRelationshipEN.TopicDescription = null; //标题描述
if (objvcc_CourseExamPaperRelationshipEN.UpdDate == "[null]") objvcc_CourseExamPaperRelationshipEN.UpdDate = null; //修改日期
if (objvcc_CourseExamPaperRelationshipEN.UpdUser == "[null]") objvcc_CourseExamPaperRelationshipEN.UpdUser = null; //修改人
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
public static void CheckProperty4Condition(clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN)
{
 vcc_CourseExamPaperRelationshipDA.CheckProperty4Condition(objvcc_CourseExamPaperRelationshipEN);
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
if (clscc_CourseExamPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperBL没有刷新缓存机制(clscc_CourseExamPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseExamPaperRelationshipBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperRelationshipBL没有刷新缓存机制(clscc_CourseExamPaperRelationshipBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_PapersBigTopicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PapersBigTopicBL没有刷新缓存机制(clscc_PapersBigTopicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvcc_CourseExamPaperRelationshipObjLstCache == null)
//{
//arrvcc_CourseExamPaperRelationshipObjLstCache = vcc_CourseExamPaperRelationshipDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseExamPaperRelationshipEN GetObjBymIdCache(long lngmId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperRelationshipEN._CurrTabName, strCourseId);
List<clsvcc_CourseExamPaperRelationshipEN> arrvcc_CourseExamPaperRelationshipObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseExamPaperRelationshipEN> arrvcc_CourseExamPaperRelationshipObjLst_Sel =
arrvcc_CourseExamPaperRelationshipObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvcc_CourseExamPaperRelationshipObjLst_Sel.Count() == 0)
{
   clsvcc_CourseExamPaperRelationshipEN obj = clsvcc_CourseExamPaperRelationshipBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvcc_CourseExamPaperRelationshipObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseExamPaperRelationshipEN> GetAllvcc_CourseExamPaperRelationshipObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvcc_CourseExamPaperRelationshipEN> arrvcc_CourseExamPaperRelationshipObjLstCache = GetObjLstCache(strCourseId); 
return arrvcc_CourseExamPaperRelationshipObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseExamPaperRelationshipEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperRelationshipEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvcc_CourseExamPaperRelationshipEN> arrvcc_CourseExamPaperRelationshipObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvcc_CourseExamPaperRelationshipObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperRelationshipEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsvcc_CourseExamPaperRelationshipEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvcc_CourseExamPaperRelationshipEN._RefreshTimeLst.Count == 0) return "";
return clsvcc_CourseExamPaperRelationshipEN._RefreshTimeLst[clsvcc_CourseExamPaperRelationshipEN._RefreshTimeLst.Count - 1];
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
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strCourseId)
{
if (strInFldName != convcc_CourseExamPaperRelationship.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_CourseExamPaperRelationship.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_CourseExamPaperRelationship.AttributeName));
throw new Exception(strMsg);
}
var objvcc_CourseExamPaperRelationship = clsvcc_CourseExamPaperRelationshipBL.GetObjBymIdCache(lngmId, strCourseId);
if (objvcc_CourseExamPaperRelationship == null) return "";
return objvcc_CourseExamPaperRelationship[strOutFldName].ToString();
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
int intRecCount = clsvcc_CourseExamPaperRelationshipDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_CourseExamPaperRelationshipDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_CourseExamPaperRelationshipDA.GetRecCount();
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
int intRecCount = clsvcc_CourseExamPaperRelationshipDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipCond)
{
 string strCourseId = objvcc_CourseExamPaperRelationshipCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvcc_CourseExamPaperRelationshipBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvcc_CourseExamPaperRelationshipEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseExamPaperRelationshipEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseExamPaperRelationship.AttributeName)
{
if (objvcc_CourseExamPaperRelationshipCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseExamPaperRelationshipCond[strFldName].ToString());
}
else
{
if (objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseExamPaperRelationshipCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseExamPaperRelationshipCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseExamPaperRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseExamPaperRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseExamPaperRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseExamPaperRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseExamPaperRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseExamPaperRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseExamPaperRelationshipCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseExamPaperRelationshipCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseExamPaperRelationshipCond[strFldName]));
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
 List<string> arrList = clsvcc_CourseExamPaperRelationshipDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseExamPaperRelationshipDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseExamPaperRelationshipDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}