
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_Answer4WorkBL
 表名:vcc_Answer4Work(01120193)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:03:56
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
public static class  clsvcc_Answer4WorkBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdAnswer4Work">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_Answer4WorkEN GetObj(this K_IdAnswer4Work_vcc_Answer4Work myKey)
{
clsvcc_Answer4WorkEN objvcc_Answer4WorkEN = clsvcc_Answer4WorkBL.vcc_Answer4WorkDA.GetObjByIdAnswer4Work(myKey.Value);
return objvcc_Answer4WorkEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetIdAnswer4Work(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strIdAnswer4Work, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAnswer4Work, 8, convcc_Answer4Work.IdAnswer4Work);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAnswer4Work, 8, convcc_Answer4Work.IdAnswer4Work);
}
objvcc_Answer4WorkEN.IdAnswer4Work = strIdAnswer4Work; //作业答案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_Answer4WorkEN.dicFldComparisonOp.ContainsKey(convcc_Answer4Work.IdAnswer4Work) == false)
{
objvcc_Answer4WorkEN.dicFldComparisonOp.Add(convcc_Answer4Work.IdAnswer4Work, strComparisonOp);
}
else
{
objvcc_Answer4WorkEN.dicFldComparisonOp[convcc_Answer4Work.IdAnswer4Work] = strComparisonOp;
}
}
return objvcc_Answer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetIdWork(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strIdWork, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdWork, convcc_Answer4Work.IdWork);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdWork, 8, convcc_Answer4Work.IdWork);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdWork, 8, convcc_Answer4Work.IdWork);
}
objvcc_Answer4WorkEN.IdWork = strIdWork; //作业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_Answer4WorkEN.dicFldComparisonOp.ContainsKey(convcc_Answer4Work.IdWork) == false)
{
objvcc_Answer4WorkEN.dicFldComparisonOp.Add(convcc_Answer4Work.IdWork, strComparisonOp);
}
else
{
objvcc_Answer4WorkEN.dicFldComparisonOp[convcc_Answer4Work.IdWork] = strComparisonOp;
}
}
return objvcc_Answer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetWorkIndex(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, int? intWorkIndex, string strComparisonOp="")
	{
objvcc_Answer4WorkEN.WorkIndex = intWorkIndex; //作业序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_Answer4WorkEN.dicFldComparisonOp.ContainsKey(convcc_Answer4Work.WorkIndex) == false)
{
objvcc_Answer4WorkEN.dicFldComparisonOp.Add(convcc_Answer4Work.WorkIndex, strComparisonOp);
}
else
{
objvcc_Answer4WorkEN.dicFldComparisonOp[convcc_Answer4Work.WorkIndex] = strComparisonOp;
}
}
return objvcc_Answer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetWorkName(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strWorkName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkName, convcc_Answer4Work.WorkName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkName, 5000, convcc_Answer4Work.WorkName);
}
objvcc_Answer4WorkEN.WorkName = strWorkName; //作业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_Answer4WorkEN.dicFldComparisonOp.ContainsKey(convcc_Answer4Work.WorkName) == false)
{
objvcc_Answer4WorkEN.dicFldComparisonOp.Add(convcc_Answer4Work.WorkName, strComparisonOp);
}
else
{
objvcc_Answer4WorkEN.dicFldComparisonOp[convcc_Answer4Work.WorkName] = strComparisonOp;
}
}
return objvcc_Answer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetWorkDesc(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strWorkDesc, string strComparisonOp="")
	{
objvcc_Answer4WorkEN.WorkDesc = strWorkDesc; //作业说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_Answer4WorkEN.dicFldComparisonOp.ContainsKey(convcc_Answer4Work.WorkDesc) == false)
{
objvcc_Answer4WorkEN.dicFldComparisonOp.Add(convcc_Answer4Work.WorkDesc, strComparisonOp);
}
else
{
objvcc_Answer4WorkEN.dicFldComparisonOp[convcc_Answer4Work.WorkDesc] = strComparisonOp;
}
}
return objvcc_Answer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetCourseId(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_Answer4Work.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_Answer4Work.CourseId);
}
objvcc_Answer4WorkEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_Answer4WorkEN.dicFldComparisonOp.ContainsKey(convcc_Answer4Work.CourseId) == false)
{
objvcc_Answer4WorkEN.dicFldComparisonOp.Add(convcc_Answer4Work.CourseId, strComparisonOp);
}
else
{
objvcc_Answer4WorkEN.dicFldComparisonOp[convcc_Answer4Work.CourseId] = strComparisonOp;
}
}
return objvcc_Answer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetCourseName(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_Answer4Work.CourseName);
}
objvcc_Answer4WorkEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_Answer4WorkEN.dicFldComparisonOp.ContainsKey(convcc_Answer4Work.CourseName) == false)
{
objvcc_Answer4WorkEN.dicFldComparisonOp.Add(convcc_Answer4Work.CourseName, strComparisonOp);
}
else
{
objvcc_Answer4WorkEN.dicFldComparisonOp[convcc_Answer4Work.CourseName] = strComparisonOp;
}
}
return objvcc_Answer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetCourseChapterId(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convcc_Answer4Work.CourseChapterId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_Answer4Work.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_Answer4Work.CourseChapterId);
}
objvcc_Answer4WorkEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_Answer4WorkEN.dicFldComparisonOp.ContainsKey(convcc_Answer4Work.CourseChapterId) == false)
{
objvcc_Answer4WorkEN.dicFldComparisonOp.Add(convcc_Answer4Work.CourseChapterId, strComparisonOp);
}
else
{
objvcc_Answer4WorkEN.dicFldComparisonOp[convcc_Answer4Work.CourseChapterId] = strComparisonOp;
}
}
return objvcc_Answer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetCourseChapterName(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterName, convcc_Answer4Work.CourseChapterName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_Answer4Work.CourseChapterName);
}
objvcc_Answer4WorkEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_Answer4WorkEN.dicFldComparisonOp.ContainsKey(convcc_Answer4Work.CourseChapterName) == false)
{
objvcc_Answer4WorkEN.dicFldComparisonOp.Add(convcc_Answer4Work.CourseChapterName, strComparisonOp);
}
else
{
objvcc_Answer4WorkEN.dicFldComparisonOp[convcc_Answer4Work.CourseChapterName] = strComparisonOp;
}
}
return objvcc_Answer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetParentNodeId(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strParentNodeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeId, 8, convcc_Answer4Work.ParentNodeId);
}
objvcc_Answer4WorkEN.ParentNodeId = strParentNodeId; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_Answer4WorkEN.dicFldComparisonOp.ContainsKey(convcc_Answer4Work.ParentNodeId) == false)
{
objvcc_Answer4WorkEN.dicFldComparisonOp.Add(convcc_Answer4Work.ParentNodeId, strComparisonOp);
}
else
{
objvcc_Answer4WorkEN.dicFldComparisonOp[convcc_Answer4Work.ParentNodeId] = strComparisonOp;
}
}
return objvcc_Answer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetParentNodeName(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strParentNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeName, 100, convcc_Answer4Work.ParentNodeName);
}
objvcc_Answer4WorkEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_Answer4WorkEN.dicFldComparisonOp.ContainsKey(convcc_Answer4Work.ParentNodeName) == false)
{
objvcc_Answer4WorkEN.dicFldComparisonOp.Add(convcc_Answer4Work.ParentNodeName, strComparisonOp);
}
else
{
objvcc_Answer4WorkEN.dicFldComparisonOp[convcc_Answer4Work.ParentNodeName] = strComparisonOp;
}
}
return objvcc_Answer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetAnswerIndex(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, int? intAnswerIndex, string strComparisonOp="")
	{
objvcc_Answer4WorkEN.AnswerIndex = intAnswerIndex; //问答序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_Answer4WorkEN.dicFldComparisonOp.ContainsKey(convcc_Answer4Work.AnswerIndex) == false)
{
objvcc_Answer4WorkEN.dicFldComparisonOp.Add(convcc_Answer4Work.AnswerIndex, strComparisonOp);
}
else
{
objvcc_Answer4WorkEN.dicFldComparisonOp[convcc_Answer4Work.AnswerIndex] = strComparisonOp;
}
}
return objvcc_Answer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetAnswerName(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strAnswerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerName, 100, convcc_Answer4Work.AnswerName);
}
objvcc_Answer4WorkEN.AnswerName = strAnswerName; //问答名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_Answer4WorkEN.dicFldComparisonOp.ContainsKey(convcc_Answer4Work.AnswerName) == false)
{
objvcc_Answer4WorkEN.dicFldComparisonOp.Add(convcc_Answer4Work.AnswerName, strComparisonOp);
}
else
{
objvcc_Answer4WorkEN.dicFldComparisonOp[convcc_Answer4Work.AnswerName] = strComparisonOp;
}
}
return objvcc_Answer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetAnswerContent(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strAnswerContent, string strComparisonOp="")
	{
objvcc_Answer4WorkEN.AnswerContent = strAnswerContent; //答案内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_Answer4WorkEN.dicFldComparisonOp.ContainsKey(convcc_Answer4Work.AnswerContent) == false)
{
objvcc_Answer4WorkEN.dicFldComparisonOp.Add(convcc_Answer4Work.AnswerContent, strComparisonOp);
}
else
{
objvcc_Answer4WorkEN.dicFldComparisonOp[convcc_Answer4Work.AnswerContent] = strComparisonOp;
}
}
return objvcc_Answer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetQuestionResolve(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strQuestionResolve, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionResolve, 8000, convcc_Answer4Work.QuestionResolve);
}
objvcc_Answer4WorkEN.QuestionResolve = strQuestionResolve; //题目解析
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_Answer4WorkEN.dicFldComparisonOp.ContainsKey(convcc_Answer4Work.QuestionResolve) == false)
{
objvcc_Answer4WorkEN.dicFldComparisonOp.Add(convcc_Answer4Work.QuestionResolve, strComparisonOp);
}
else
{
objvcc_Answer4WorkEN.dicFldComparisonOp[convcc_Answer4Work.QuestionResolve] = strComparisonOp;
}
}
return objvcc_Answer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetIsCorrect(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, bool bolIsCorrect, string strComparisonOp="")
	{
objvcc_Answer4WorkEN.IsCorrect = bolIsCorrect; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_Answer4WorkEN.dicFldComparisonOp.ContainsKey(convcc_Answer4Work.IsCorrect) == false)
{
objvcc_Answer4WorkEN.dicFldComparisonOp.Add(convcc_Answer4Work.IsCorrect, strComparisonOp);
}
else
{
objvcc_Answer4WorkEN.dicFldComparisonOp[convcc_Answer4Work.IsCorrect] = strComparisonOp;
}
}
return objvcc_Answer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetIsShow(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, bool bolIsShow, string strComparisonOp="")
	{
objvcc_Answer4WorkEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_Answer4WorkEN.dicFldComparisonOp.ContainsKey(convcc_Answer4Work.IsShow) == false)
{
objvcc_Answer4WorkEN.dicFldComparisonOp.Add(convcc_Answer4Work.IsShow, strComparisonOp);
}
else
{
objvcc_Answer4WorkEN.dicFldComparisonOp[convcc_Answer4Work.IsShow] = strComparisonOp;
}
}
return objvcc_Answer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetUpdDate(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_Answer4Work.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_Answer4Work.UpdDate);
}
objvcc_Answer4WorkEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_Answer4WorkEN.dicFldComparisonOp.ContainsKey(convcc_Answer4Work.UpdDate) == false)
{
objvcc_Answer4WorkEN.dicFldComparisonOp.Add(convcc_Answer4Work.UpdDate, strComparisonOp);
}
else
{
objvcc_Answer4WorkEN.dicFldComparisonOp[convcc_Answer4Work.UpdDate] = strComparisonOp;
}
}
return objvcc_Answer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetUpdUser(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convcc_Answer4Work.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_Answer4Work.UpdUser);
}
objvcc_Answer4WorkEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_Answer4WorkEN.dicFldComparisonOp.ContainsKey(convcc_Answer4Work.UpdUser) == false)
{
objvcc_Answer4WorkEN.dicFldComparisonOp.Add(convcc_Answer4Work.UpdUser, strComparisonOp);
}
else
{
objvcc_Answer4WorkEN.dicFldComparisonOp[convcc_Answer4Work.UpdUser] = strComparisonOp;
}
}
return objvcc_Answer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetMemo(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_Answer4Work.Memo);
}
objvcc_Answer4WorkEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_Answer4WorkEN.dicFldComparisonOp.ContainsKey(convcc_Answer4Work.Memo) == false)
{
objvcc_Answer4WorkEN.dicFldComparisonOp.Add(convcc_Answer4Work.Memo, strComparisonOp);
}
else
{
objvcc_Answer4WorkEN.dicFldComparisonOp[convcc_Answer4Work.Memo] = strComparisonOp;
}
}
return objvcc_Answer4WorkEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkENS">源对象</param>
 /// <param name = "objvcc_Answer4WorkENT">目标对象</param>
 public static void CopyTo(this clsvcc_Answer4WorkEN objvcc_Answer4WorkENS, clsvcc_Answer4WorkEN objvcc_Answer4WorkENT)
{
try
{
objvcc_Answer4WorkENT.IdAnswer4Work = objvcc_Answer4WorkENS.IdAnswer4Work; //作业答案流水号
objvcc_Answer4WorkENT.IdWork = objvcc_Answer4WorkENS.IdWork; //作业流水号
objvcc_Answer4WorkENT.WorkIndex = objvcc_Answer4WorkENS.WorkIndex; //作业序号
objvcc_Answer4WorkENT.WorkName = objvcc_Answer4WorkENS.WorkName; //作业名称
objvcc_Answer4WorkENT.WorkDesc = objvcc_Answer4WorkENS.WorkDesc; //作业说明
objvcc_Answer4WorkENT.CourseId = objvcc_Answer4WorkENS.CourseId; //课程Id
objvcc_Answer4WorkENT.CourseName = objvcc_Answer4WorkENS.CourseName; //课程名称
objvcc_Answer4WorkENT.CourseChapterId = objvcc_Answer4WorkENS.CourseChapterId; //课程章节ID
objvcc_Answer4WorkENT.CourseChapterName = objvcc_Answer4WorkENS.CourseChapterName; //课程章节名称
objvcc_Answer4WorkENT.ParentNodeId = objvcc_Answer4WorkENS.ParentNodeId; //父节点编号
objvcc_Answer4WorkENT.ParentNodeName = objvcc_Answer4WorkENS.ParentNodeName; //父节点名称
objvcc_Answer4WorkENT.AnswerIndex = objvcc_Answer4WorkENS.AnswerIndex; //问答序号
objvcc_Answer4WorkENT.AnswerName = objvcc_Answer4WorkENS.AnswerName; //问答名称
objvcc_Answer4WorkENT.AnswerContent = objvcc_Answer4WorkENS.AnswerContent; //答案内容
objvcc_Answer4WorkENT.QuestionResolve = objvcc_Answer4WorkENS.QuestionResolve; //题目解析
objvcc_Answer4WorkENT.IsCorrect = objvcc_Answer4WorkENS.IsCorrect; //是否正确
objvcc_Answer4WorkENT.IsShow = objvcc_Answer4WorkENS.IsShow; //是否启用
objvcc_Answer4WorkENT.UpdDate = objvcc_Answer4WorkENS.UpdDate; //修改日期
objvcc_Answer4WorkENT.UpdUser = objvcc_Answer4WorkENS.UpdUser; //修改人
objvcc_Answer4WorkENT.Memo = objvcc_Answer4WorkENS.Memo; //备注
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
 /// <param name = "objvcc_Answer4WorkENS">源对象</param>
 /// <returns>目标对象=>clsvcc_Answer4WorkEN:objvcc_Answer4WorkENT</returns>
 public static clsvcc_Answer4WorkEN CopyTo(this clsvcc_Answer4WorkEN objvcc_Answer4WorkENS)
{
try
{
 clsvcc_Answer4WorkEN objvcc_Answer4WorkENT = new clsvcc_Answer4WorkEN()
{
IdAnswer4Work = objvcc_Answer4WorkENS.IdAnswer4Work, //作业答案流水号
IdWork = objvcc_Answer4WorkENS.IdWork, //作业流水号
WorkIndex = objvcc_Answer4WorkENS.WorkIndex, //作业序号
WorkName = objvcc_Answer4WorkENS.WorkName, //作业名称
WorkDesc = objvcc_Answer4WorkENS.WorkDesc, //作业说明
CourseId = objvcc_Answer4WorkENS.CourseId, //课程Id
CourseName = objvcc_Answer4WorkENS.CourseName, //课程名称
CourseChapterId = objvcc_Answer4WorkENS.CourseChapterId, //课程章节ID
CourseChapterName = objvcc_Answer4WorkENS.CourseChapterName, //课程章节名称
ParentNodeId = objvcc_Answer4WorkENS.ParentNodeId, //父节点编号
ParentNodeName = objvcc_Answer4WorkENS.ParentNodeName, //父节点名称
AnswerIndex = objvcc_Answer4WorkENS.AnswerIndex, //问答序号
AnswerName = objvcc_Answer4WorkENS.AnswerName, //问答名称
AnswerContent = objvcc_Answer4WorkENS.AnswerContent, //答案内容
QuestionResolve = objvcc_Answer4WorkENS.QuestionResolve, //题目解析
IsCorrect = objvcc_Answer4WorkENS.IsCorrect, //是否正确
IsShow = objvcc_Answer4WorkENS.IsShow, //是否启用
UpdDate = objvcc_Answer4WorkENS.UpdDate, //修改日期
UpdUser = objvcc_Answer4WorkENS.UpdUser, //修改人
Memo = objvcc_Answer4WorkENS.Memo, //备注
};
 return objvcc_Answer4WorkENT;
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
public static void CheckProperty4Condition(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN)
{
 clsvcc_Answer4WorkBL.vcc_Answer4WorkDA.CheckProperty4Condition(objvcc_Answer4WorkEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_Answer4WorkEN objvcc_Answer4WorkCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_Answer4WorkCond.IsUpdated(convcc_Answer4Work.IdAnswer4Work) == true)
{
string strComparisonOpIdAnswer4Work = objvcc_Answer4WorkCond.dicFldComparisonOp[convcc_Answer4Work.IdAnswer4Work];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.IdAnswer4Work, objvcc_Answer4WorkCond.IdAnswer4Work, strComparisonOpIdAnswer4Work);
}
if (objvcc_Answer4WorkCond.IsUpdated(convcc_Answer4Work.IdWork) == true)
{
string strComparisonOpIdWork = objvcc_Answer4WorkCond.dicFldComparisonOp[convcc_Answer4Work.IdWork];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.IdWork, objvcc_Answer4WorkCond.IdWork, strComparisonOpIdWork);
}
if (objvcc_Answer4WorkCond.IsUpdated(convcc_Answer4Work.WorkIndex) == true)
{
string strComparisonOpWorkIndex = objvcc_Answer4WorkCond.dicFldComparisonOp[convcc_Answer4Work.WorkIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Answer4Work.WorkIndex, objvcc_Answer4WorkCond.WorkIndex, strComparisonOpWorkIndex);
}
if (objvcc_Answer4WorkCond.IsUpdated(convcc_Answer4Work.WorkName) == true)
{
string strComparisonOpWorkName = objvcc_Answer4WorkCond.dicFldComparisonOp[convcc_Answer4Work.WorkName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.WorkName, objvcc_Answer4WorkCond.WorkName, strComparisonOpWorkName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvcc_Answer4WorkCond.IsUpdated(convcc_Answer4Work.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_Answer4WorkCond.dicFldComparisonOp[convcc_Answer4Work.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.CourseId, objvcc_Answer4WorkCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_Answer4WorkCond.IsUpdated(convcc_Answer4Work.CourseName) == true)
{
string strComparisonOpCourseName = objvcc_Answer4WorkCond.dicFldComparisonOp[convcc_Answer4Work.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.CourseName, objvcc_Answer4WorkCond.CourseName, strComparisonOpCourseName);
}
if (objvcc_Answer4WorkCond.IsUpdated(convcc_Answer4Work.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvcc_Answer4WorkCond.dicFldComparisonOp[convcc_Answer4Work.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.CourseChapterId, objvcc_Answer4WorkCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvcc_Answer4WorkCond.IsUpdated(convcc_Answer4Work.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvcc_Answer4WorkCond.dicFldComparisonOp[convcc_Answer4Work.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.CourseChapterName, objvcc_Answer4WorkCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvcc_Answer4WorkCond.IsUpdated(convcc_Answer4Work.ParentNodeId) == true)
{
string strComparisonOpParentNodeId = objvcc_Answer4WorkCond.dicFldComparisonOp[convcc_Answer4Work.ParentNodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.ParentNodeId, objvcc_Answer4WorkCond.ParentNodeId, strComparisonOpParentNodeId);
}
if (objvcc_Answer4WorkCond.IsUpdated(convcc_Answer4Work.ParentNodeName) == true)
{
string strComparisonOpParentNodeName = objvcc_Answer4WorkCond.dicFldComparisonOp[convcc_Answer4Work.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.ParentNodeName, objvcc_Answer4WorkCond.ParentNodeName, strComparisonOpParentNodeName);
}
if (objvcc_Answer4WorkCond.IsUpdated(convcc_Answer4Work.AnswerIndex) == true)
{
string strComparisonOpAnswerIndex = objvcc_Answer4WorkCond.dicFldComparisonOp[convcc_Answer4Work.AnswerIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Answer4Work.AnswerIndex, objvcc_Answer4WorkCond.AnswerIndex, strComparisonOpAnswerIndex);
}
if (objvcc_Answer4WorkCond.IsUpdated(convcc_Answer4Work.AnswerName) == true)
{
string strComparisonOpAnswerName = objvcc_Answer4WorkCond.dicFldComparisonOp[convcc_Answer4Work.AnswerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.AnswerName, objvcc_Answer4WorkCond.AnswerName, strComparisonOpAnswerName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvcc_Answer4WorkCond.IsUpdated(convcc_Answer4Work.QuestionResolve) == true)
{
string strComparisonOpQuestionResolve = objvcc_Answer4WorkCond.dicFldComparisonOp[convcc_Answer4Work.QuestionResolve];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.QuestionResolve, objvcc_Answer4WorkCond.QuestionResolve, strComparisonOpQuestionResolve);
}
if (objvcc_Answer4WorkCond.IsUpdated(convcc_Answer4Work.IsCorrect) == true)
{
if (objvcc_Answer4WorkCond.IsCorrect == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_Answer4Work.IsCorrect);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_Answer4Work.IsCorrect);
}
}
if (objvcc_Answer4WorkCond.IsUpdated(convcc_Answer4Work.IsShow) == true)
{
if (objvcc_Answer4WorkCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_Answer4Work.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_Answer4Work.IsShow);
}
}
if (objvcc_Answer4WorkCond.IsUpdated(convcc_Answer4Work.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_Answer4WorkCond.dicFldComparisonOp[convcc_Answer4Work.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.UpdDate, objvcc_Answer4WorkCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_Answer4WorkCond.IsUpdated(convcc_Answer4Work.UpdUser) == true)
{
string strComparisonOpUpdUser = objvcc_Answer4WorkCond.dicFldComparisonOp[convcc_Answer4Work.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.UpdUser, objvcc_Answer4WorkCond.UpdUser, strComparisonOpUpdUser);
}
if (objvcc_Answer4WorkCond.IsUpdated(convcc_Answer4Work.Memo) == true)
{
string strComparisonOpMemo = objvcc_Answer4WorkCond.dicFldComparisonOp[convcc_Answer4Work.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.Memo, objvcc_Answer4WorkCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_Answer4Work
{
public virtual bool UpdRelaTabDate(string strIdAnswer4Work, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v作业答案(vcc_Answer4Work)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_Answer4WorkBL
{
public static RelatedActions_vcc_Answer4Work relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_Answer4WorkDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_Answer4WorkDA vcc_Answer4WorkDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_Answer4WorkDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_Answer4WorkBL()
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
if (string.IsNullOrEmpty(clsvcc_Answer4WorkEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_Answer4WorkEN._ConnectString);
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
public static DataTable GetDataTable_vcc_Answer4Work(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_Answer4WorkDA.GetDataTable_vcc_Answer4Work(strWhereCond);
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
objDT = vcc_Answer4WorkDA.GetDataTable(strWhereCond);
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
objDT = vcc_Answer4WorkDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_Answer4WorkDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_Answer4WorkDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_Answer4WorkDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_Answer4WorkDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_Answer4WorkDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_Answer4WorkDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdAnswer4WorkLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcc_Answer4WorkEN> GetObjLstByIdAnswer4WorkLst(List<string> arrIdAnswer4WorkLst)
{
List<clsvcc_Answer4WorkEN> arrObjLst = new List<clsvcc_Answer4WorkEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdAnswer4WorkLst, true);
 string strWhereCond = string.Format("IdAnswer4Work in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_Answer4WorkEN objvcc_Answer4WorkEN = new clsvcc_Answer4WorkEN();
try
{
objvcc_Answer4WorkEN.IdAnswer4Work = objRow[convcc_Answer4Work.IdAnswer4Work].ToString().Trim(); //作业答案流水号
objvcc_Answer4WorkEN.IdWork = objRow[convcc_Answer4Work.IdWork].ToString().Trim(); //作业流水号
objvcc_Answer4WorkEN.WorkIndex = objRow[convcc_Answer4Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Answer4Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_Answer4WorkEN.WorkName = objRow[convcc_Answer4Work.WorkName].ToString().Trim(); //作业名称
objvcc_Answer4WorkEN.WorkDesc = objRow[convcc_Answer4Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Answer4Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_Answer4WorkEN.CourseId = objRow[convcc_Answer4Work.CourseId] == DBNull.Value ? null : objRow[convcc_Answer4Work.CourseId].ToString().Trim(); //课程Id
objvcc_Answer4WorkEN.CourseName = objRow[convcc_Answer4Work.CourseName] == DBNull.Value ? null : objRow[convcc_Answer4Work.CourseName].ToString().Trim(); //课程名称
objvcc_Answer4WorkEN.CourseChapterId = objRow[convcc_Answer4Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_Answer4WorkEN.CourseChapterName = objRow[convcc_Answer4Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_Answer4WorkEN.ParentNodeId = objRow[convcc_Answer4Work.ParentNodeId] == DBNull.Value ? null : objRow[convcc_Answer4Work.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_Answer4WorkEN.ParentNodeName = objRow[convcc_Answer4Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Answer4Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_Answer4WorkEN.AnswerIndex = objRow[convcc_Answer4Work.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Answer4Work.AnswerIndex].ToString().Trim()); //问答序号
objvcc_Answer4WorkEN.AnswerName = objRow[convcc_Answer4Work.AnswerName] == DBNull.Value ? null : objRow[convcc_Answer4Work.AnswerName].ToString().Trim(); //问答名称
objvcc_Answer4WorkEN.AnswerContent = objRow[convcc_Answer4Work.AnswerContent] == DBNull.Value ? null : objRow[convcc_Answer4Work.AnswerContent].ToString().Trim(); //答案内容
objvcc_Answer4WorkEN.QuestionResolve = objRow[convcc_Answer4Work.QuestionResolve] == DBNull.Value ? null : objRow[convcc_Answer4Work.QuestionResolve].ToString().Trim(); //题目解析
objvcc_Answer4WorkEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[convcc_Answer4Work.IsCorrect].ToString().Trim()); //是否正确
objvcc_Answer4WorkEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_Answer4Work.IsShow].ToString().Trim()); //是否启用
objvcc_Answer4WorkEN.UpdDate = objRow[convcc_Answer4Work.UpdDate].ToString().Trim(); //修改日期
objvcc_Answer4WorkEN.UpdUser = objRow[convcc_Answer4Work.UpdUser].ToString().Trim(); //修改人
objvcc_Answer4WorkEN.Memo = objRow[convcc_Answer4Work.Memo] == DBNull.Value ? null : objRow[convcc_Answer4Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_Answer4WorkEN.IdAnswer4Work, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_Answer4WorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdAnswer4WorkLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_Answer4WorkEN> GetObjLstByIdAnswer4WorkLstCache(List<string> arrIdAnswer4WorkLst)
{
string strKey = string.Format("{0}", clsvcc_Answer4WorkEN._CurrTabName);
List<clsvcc_Answer4WorkEN> arrvcc_Answer4WorkObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_Answer4WorkEN> arrvcc_Answer4WorkObjLst_Sel =
arrvcc_Answer4WorkObjLstCache
.Where(x => arrIdAnswer4WorkLst.Contains(x.IdAnswer4Work));
return arrvcc_Answer4WorkObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_Answer4WorkEN> GetObjLst(string strWhereCond)
{
List<clsvcc_Answer4WorkEN> arrObjLst = new List<clsvcc_Answer4WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_Answer4WorkEN objvcc_Answer4WorkEN = new clsvcc_Answer4WorkEN();
try
{
objvcc_Answer4WorkEN.IdAnswer4Work = objRow[convcc_Answer4Work.IdAnswer4Work].ToString().Trim(); //作业答案流水号
objvcc_Answer4WorkEN.IdWork = objRow[convcc_Answer4Work.IdWork].ToString().Trim(); //作业流水号
objvcc_Answer4WorkEN.WorkIndex = objRow[convcc_Answer4Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Answer4Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_Answer4WorkEN.WorkName = objRow[convcc_Answer4Work.WorkName].ToString().Trim(); //作业名称
objvcc_Answer4WorkEN.WorkDesc = objRow[convcc_Answer4Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Answer4Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_Answer4WorkEN.CourseId = objRow[convcc_Answer4Work.CourseId] == DBNull.Value ? null : objRow[convcc_Answer4Work.CourseId].ToString().Trim(); //课程Id
objvcc_Answer4WorkEN.CourseName = objRow[convcc_Answer4Work.CourseName] == DBNull.Value ? null : objRow[convcc_Answer4Work.CourseName].ToString().Trim(); //课程名称
objvcc_Answer4WorkEN.CourseChapterId = objRow[convcc_Answer4Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_Answer4WorkEN.CourseChapterName = objRow[convcc_Answer4Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_Answer4WorkEN.ParentNodeId = objRow[convcc_Answer4Work.ParentNodeId] == DBNull.Value ? null : objRow[convcc_Answer4Work.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_Answer4WorkEN.ParentNodeName = objRow[convcc_Answer4Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Answer4Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_Answer4WorkEN.AnswerIndex = objRow[convcc_Answer4Work.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Answer4Work.AnswerIndex].ToString().Trim()); //问答序号
objvcc_Answer4WorkEN.AnswerName = objRow[convcc_Answer4Work.AnswerName] == DBNull.Value ? null : objRow[convcc_Answer4Work.AnswerName].ToString().Trim(); //问答名称
objvcc_Answer4WorkEN.AnswerContent = objRow[convcc_Answer4Work.AnswerContent] == DBNull.Value ? null : objRow[convcc_Answer4Work.AnswerContent].ToString().Trim(); //答案内容
objvcc_Answer4WorkEN.QuestionResolve = objRow[convcc_Answer4Work.QuestionResolve] == DBNull.Value ? null : objRow[convcc_Answer4Work.QuestionResolve].ToString().Trim(); //题目解析
objvcc_Answer4WorkEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[convcc_Answer4Work.IsCorrect].ToString().Trim()); //是否正确
objvcc_Answer4WorkEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_Answer4Work.IsShow].ToString().Trim()); //是否启用
objvcc_Answer4WorkEN.UpdDate = objRow[convcc_Answer4Work.UpdDate].ToString().Trim(); //修改日期
objvcc_Answer4WorkEN.UpdUser = objRow[convcc_Answer4Work.UpdUser].ToString().Trim(); //修改人
objvcc_Answer4WorkEN.Memo = objRow[convcc_Answer4Work.Memo] == DBNull.Value ? null : objRow[convcc_Answer4Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_Answer4WorkEN.IdAnswer4Work, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_Answer4WorkEN);
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
public static List<clsvcc_Answer4WorkEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_Answer4WorkEN> arrObjLst = new List<clsvcc_Answer4WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_Answer4WorkEN objvcc_Answer4WorkEN = new clsvcc_Answer4WorkEN();
try
{
objvcc_Answer4WorkEN.IdAnswer4Work = objRow[convcc_Answer4Work.IdAnswer4Work].ToString().Trim(); //作业答案流水号
objvcc_Answer4WorkEN.IdWork = objRow[convcc_Answer4Work.IdWork].ToString().Trim(); //作业流水号
objvcc_Answer4WorkEN.WorkIndex = objRow[convcc_Answer4Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Answer4Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_Answer4WorkEN.WorkName = objRow[convcc_Answer4Work.WorkName].ToString().Trim(); //作业名称
objvcc_Answer4WorkEN.WorkDesc = objRow[convcc_Answer4Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Answer4Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_Answer4WorkEN.CourseId = objRow[convcc_Answer4Work.CourseId] == DBNull.Value ? null : objRow[convcc_Answer4Work.CourseId].ToString().Trim(); //课程Id
objvcc_Answer4WorkEN.CourseName = objRow[convcc_Answer4Work.CourseName] == DBNull.Value ? null : objRow[convcc_Answer4Work.CourseName].ToString().Trim(); //课程名称
objvcc_Answer4WorkEN.CourseChapterId = objRow[convcc_Answer4Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_Answer4WorkEN.CourseChapterName = objRow[convcc_Answer4Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_Answer4WorkEN.ParentNodeId = objRow[convcc_Answer4Work.ParentNodeId] == DBNull.Value ? null : objRow[convcc_Answer4Work.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_Answer4WorkEN.ParentNodeName = objRow[convcc_Answer4Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Answer4Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_Answer4WorkEN.AnswerIndex = objRow[convcc_Answer4Work.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Answer4Work.AnswerIndex].ToString().Trim()); //问答序号
objvcc_Answer4WorkEN.AnswerName = objRow[convcc_Answer4Work.AnswerName] == DBNull.Value ? null : objRow[convcc_Answer4Work.AnswerName].ToString().Trim(); //问答名称
objvcc_Answer4WorkEN.AnswerContent = objRow[convcc_Answer4Work.AnswerContent] == DBNull.Value ? null : objRow[convcc_Answer4Work.AnswerContent].ToString().Trim(); //答案内容
objvcc_Answer4WorkEN.QuestionResolve = objRow[convcc_Answer4Work.QuestionResolve] == DBNull.Value ? null : objRow[convcc_Answer4Work.QuestionResolve].ToString().Trim(); //题目解析
objvcc_Answer4WorkEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[convcc_Answer4Work.IsCorrect].ToString().Trim()); //是否正确
objvcc_Answer4WorkEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_Answer4Work.IsShow].ToString().Trim()); //是否启用
objvcc_Answer4WorkEN.UpdDate = objRow[convcc_Answer4Work.UpdDate].ToString().Trim(); //修改日期
objvcc_Answer4WorkEN.UpdUser = objRow[convcc_Answer4Work.UpdUser].ToString().Trim(); //修改人
objvcc_Answer4WorkEN.Memo = objRow[convcc_Answer4Work.Memo] == DBNull.Value ? null : objRow[convcc_Answer4Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_Answer4WorkEN.IdAnswer4Work, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_Answer4WorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_Answer4WorkEN> GetSubObjLstCache(clsvcc_Answer4WorkEN objvcc_Answer4WorkCond)
{
List<clsvcc_Answer4WorkEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_Answer4WorkEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_Answer4Work.AttributeName)
{
if (objvcc_Answer4WorkCond.IsUpdated(strFldName) == false) continue;
if (objvcc_Answer4WorkCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_Answer4WorkCond[strFldName].ToString());
}
else
{
if (objvcc_Answer4WorkCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_Answer4WorkCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_Answer4WorkCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_Answer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_Answer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_Answer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_Answer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_Answer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_Answer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_Answer4WorkCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_Answer4WorkCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_Answer4WorkCond[strFldName]));
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
public static List<clsvcc_Answer4WorkEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_Answer4WorkEN> arrObjLst = new List<clsvcc_Answer4WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_Answer4WorkEN objvcc_Answer4WorkEN = new clsvcc_Answer4WorkEN();
try
{
objvcc_Answer4WorkEN.IdAnswer4Work = objRow[convcc_Answer4Work.IdAnswer4Work].ToString().Trim(); //作业答案流水号
objvcc_Answer4WorkEN.IdWork = objRow[convcc_Answer4Work.IdWork].ToString().Trim(); //作业流水号
objvcc_Answer4WorkEN.WorkIndex = objRow[convcc_Answer4Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Answer4Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_Answer4WorkEN.WorkName = objRow[convcc_Answer4Work.WorkName].ToString().Trim(); //作业名称
objvcc_Answer4WorkEN.WorkDesc = objRow[convcc_Answer4Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Answer4Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_Answer4WorkEN.CourseId = objRow[convcc_Answer4Work.CourseId] == DBNull.Value ? null : objRow[convcc_Answer4Work.CourseId].ToString().Trim(); //课程Id
objvcc_Answer4WorkEN.CourseName = objRow[convcc_Answer4Work.CourseName] == DBNull.Value ? null : objRow[convcc_Answer4Work.CourseName].ToString().Trim(); //课程名称
objvcc_Answer4WorkEN.CourseChapterId = objRow[convcc_Answer4Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_Answer4WorkEN.CourseChapterName = objRow[convcc_Answer4Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_Answer4WorkEN.ParentNodeId = objRow[convcc_Answer4Work.ParentNodeId] == DBNull.Value ? null : objRow[convcc_Answer4Work.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_Answer4WorkEN.ParentNodeName = objRow[convcc_Answer4Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Answer4Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_Answer4WorkEN.AnswerIndex = objRow[convcc_Answer4Work.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Answer4Work.AnswerIndex].ToString().Trim()); //问答序号
objvcc_Answer4WorkEN.AnswerName = objRow[convcc_Answer4Work.AnswerName] == DBNull.Value ? null : objRow[convcc_Answer4Work.AnswerName].ToString().Trim(); //问答名称
objvcc_Answer4WorkEN.AnswerContent = objRow[convcc_Answer4Work.AnswerContent] == DBNull.Value ? null : objRow[convcc_Answer4Work.AnswerContent].ToString().Trim(); //答案内容
objvcc_Answer4WorkEN.QuestionResolve = objRow[convcc_Answer4Work.QuestionResolve] == DBNull.Value ? null : objRow[convcc_Answer4Work.QuestionResolve].ToString().Trim(); //题目解析
objvcc_Answer4WorkEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[convcc_Answer4Work.IsCorrect].ToString().Trim()); //是否正确
objvcc_Answer4WorkEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_Answer4Work.IsShow].ToString().Trim()); //是否启用
objvcc_Answer4WorkEN.UpdDate = objRow[convcc_Answer4Work.UpdDate].ToString().Trim(); //修改日期
objvcc_Answer4WorkEN.UpdUser = objRow[convcc_Answer4Work.UpdUser].ToString().Trim(); //修改人
objvcc_Answer4WorkEN.Memo = objRow[convcc_Answer4Work.Memo] == DBNull.Value ? null : objRow[convcc_Answer4Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_Answer4WorkEN.IdAnswer4Work, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_Answer4WorkEN);
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
public static List<clsvcc_Answer4WorkEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_Answer4WorkEN> arrObjLst = new List<clsvcc_Answer4WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_Answer4WorkEN objvcc_Answer4WorkEN = new clsvcc_Answer4WorkEN();
try
{
objvcc_Answer4WorkEN.IdAnswer4Work = objRow[convcc_Answer4Work.IdAnswer4Work].ToString().Trim(); //作业答案流水号
objvcc_Answer4WorkEN.IdWork = objRow[convcc_Answer4Work.IdWork].ToString().Trim(); //作业流水号
objvcc_Answer4WorkEN.WorkIndex = objRow[convcc_Answer4Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Answer4Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_Answer4WorkEN.WorkName = objRow[convcc_Answer4Work.WorkName].ToString().Trim(); //作业名称
objvcc_Answer4WorkEN.WorkDesc = objRow[convcc_Answer4Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Answer4Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_Answer4WorkEN.CourseId = objRow[convcc_Answer4Work.CourseId] == DBNull.Value ? null : objRow[convcc_Answer4Work.CourseId].ToString().Trim(); //课程Id
objvcc_Answer4WorkEN.CourseName = objRow[convcc_Answer4Work.CourseName] == DBNull.Value ? null : objRow[convcc_Answer4Work.CourseName].ToString().Trim(); //课程名称
objvcc_Answer4WorkEN.CourseChapterId = objRow[convcc_Answer4Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_Answer4WorkEN.CourseChapterName = objRow[convcc_Answer4Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_Answer4WorkEN.ParentNodeId = objRow[convcc_Answer4Work.ParentNodeId] == DBNull.Value ? null : objRow[convcc_Answer4Work.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_Answer4WorkEN.ParentNodeName = objRow[convcc_Answer4Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Answer4Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_Answer4WorkEN.AnswerIndex = objRow[convcc_Answer4Work.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Answer4Work.AnswerIndex].ToString().Trim()); //问答序号
objvcc_Answer4WorkEN.AnswerName = objRow[convcc_Answer4Work.AnswerName] == DBNull.Value ? null : objRow[convcc_Answer4Work.AnswerName].ToString().Trim(); //问答名称
objvcc_Answer4WorkEN.AnswerContent = objRow[convcc_Answer4Work.AnswerContent] == DBNull.Value ? null : objRow[convcc_Answer4Work.AnswerContent].ToString().Trim(); //答案内容
objvcc_Answer4WorkEN.QuestionResolve = objRow[convcc_Answer4Work.QuestionResolve] == DBNull.Value ? null : objRow[convcc_Answer4Work.QuestionResolve].ToString().Trim(); //题目解析
objvcc_Answer4WorkEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[convcc_Answer4Work.IsCorrect].ToString().Trim()); //是否正确
objvcc_Answer4WorkEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_Answer4Work.IsShow].ToString().Trim()); //是否启用
objvcc_Answer4WorkEN.UpdDate = objRow[convcc_Answer4Work.UpdDate].ToString().Trim(); //修改日期
objvcc_Answer4WorkEN.UpdUser = objRow[convcc_Answer4Work.UpdUser].ToString().Trim(); //修改人
objvcc_Answer4WorkEN.Memo = objRow[convcc_Answer4Work.Memo] == DBNull.Value ? null : objRow[convcc_Answer4Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_Answer4WorkEN.IdAnswer4Work, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_Answer4WorkEN);
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
List<clsvcc_Answer4WorkEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_Answer4WorkEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_Answer4WorkEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_Answer4WorkEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_Answer4WorkEN> arrObjLst = new List<clsvcc_Answer4WorkEN>(); 
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
	clsvcc_Answer4WorkEN objvcc_Answer4WorkEN = new clsvcc_Answer4WorkEN();
try
{
objvcc_Answer4WorkEN.IdAnswer4Work = objRow[convcc_Answer4Work.IdAnswer4Work].ToString().Trim(); //作业答案流水号
objvcc_Answer4WorkEN.IdWork = objRow[convcc_Answer4Work.IdWork].ToString().Trim(); //作业流水号
objvcc_Answer4WorkEN.WorkIndex = objRow[convcc_Answer4Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Answer4Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_Answer4WorkEN.WorkName = objRow[convcc_Answer4Work.WorkName].ToString().Trim(); //作业名称
objvcc_Answer4WorkEN.WorkDesc = objRow[convcc_Answer4Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Answer4Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_Answer4WorkEN.CourseId = objRow[convcc_Answer4Work.CourseId] == DBNull.Value ? null : objRow[convcc_Answer4Work.CourseId].ToString().Trim(); //课程Id
objvcc_Answer4WorkEN.CourseName = objRow[convcc_Answer4Work.CourseName] == DBNull.Value ? null : objRow[convcc_Answer4Work.CourseName].ToString().Trim(); //课程名称
objvcc_Answer4WorkEN.CourseChapterId = objRow[convcc_Answer4Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_Answer4WorkEN.CourseChapterName = objRow[convcc_Answer4Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_Answer4WorkEN.ParentNodeId = objRow[convcc_Answer4Work.ParentNodeId] == DBNull.Value ? null : objRow[convcc_Answer4Work.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_Answer4WorkEN.ParentNodeName = objRow[convcc_Answer4Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Answer4Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_Answer4WorkEN.AnswerIndex = objRow[convcc_Answer4Work.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Answer4Work.AnswerIndex].ToString().Trim()); //问答序号
objvcc_Answer4WorkEN.AnswerName = objRow[convcc_Answer4Work.AnswerName] == DBNull.Value ? null : objRow[convcc_Answer4Work.AnswerName].ToString().Trim(); //问答名称
objvcc_Answer4WorkEN.AnswerContent = objRow[convcc_Answer4Work.AnswerContent] == DBNull.Value ? null : objRow[convcc_Answer4Work.AnswerContent].ToString().Trim(); //答案内容
objvcc_Answer4WorkEN.QuestionResolve = objRow[convcc_Answer4Work.QuestionResolve] == DBNull.Value ? null : objRow[convcc_Answer4Work.QuestionResolve].ToString().Trim(); //题目解析
objvcc_Answer4WorkEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[convcc_Answer4Work.IsCorrect].ToString().Trim()); //是否正确
objvcc_Answer4WorkEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_Answer4Work.IsShow].ToString().Trim()); //是否启用
objvcc_Answer4WorkEN.UpdDate = objRow[convcc_Answer4Work.UpdDate].ToString().Trim(); //修改日期
objvcc_Answer4WorkEN.UpdUser = objRow[convcc_Answer4Work.UpdUser].ToString().Trim(); //修改人
objvcc_Answer4WorkEN.Memo = objRow[convcc_Answer4Work.Memo] == DBNull.Value ? null : objRow[convcc_Answer4Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_Answer4WorkEN.IdAnswer4Work, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_Answer4WorkEN);
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
public static List<clsvcc_Answer4WorkEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_Answer4WorkEN> arrObjLst = new List<clsvcc_Answer4WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_Answer4WorkEN objvcc_Answer4WorkEN = new clsvcc_Answer4WorkEN();
try
{
objvcc_Answer4WorkEN.IdAnswer4Work = objRow[convcc_Answer4Work.IdAnswer4Work].ToString().Trim(); //作业答案流水号
objvcc_Answer4WorkEN.IdWork = objRow[convcc_Answer4Work.IdWork].ToString().Trim(); //作业流水号
objvcc_Answer4WorkEN.WorkIndex = objRow[convcc_Answer4Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Answer4Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_Answer4WorkEN.WorkName = objRow[convcc_Answer4Work.WorkName].ToString().Trim(); //作业名称
objvcc_Answer4WorkEN.WorkDesc = objRow[convcc_Answer4Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Answer4Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_Answer4WorkEN.CourseId = objRow[convcc_Answer4Work.CourseId] == DBNull.Value ? null : objRow[convcc_Answer4Work.CourseId].ToString().Trim(); //课程Id
objvcc_Answer4WorkEN.CourseName = objRow[convcc_Answer4Work.CourseName] == DBNull.Value ? null : objRow[convcc_Answer4Work.CourseName].ToString().Trim(); //课程名称
objvcc_Answer4WorkEN.CourseChapterId = objRow[convcc_Answer4Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_Answer4WorkEN.CourseChapterName = objRow[convcc_Answer4Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_Answer4WorkEN.ParentNodeId = objRow[convcc_Answer4Work.ParentNodeId] == DBNull.Value ? null : objRow[convcc_Answer4Work.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_Answer4WorkEN.ParentNodeName = objRow[convcc_Answer4Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Answer4Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_Answer4WorkEN.AnswerIndex = objRow[convcc_Answer4Work.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Answer4Work.AnswerIndex].ToString().Trim()); //问答序号
objvcc_Answer4WorkEN.AnswerName = objRow[convcc_Answer4Work.AnswerName] == DBNull.Value ? null : objRow[convcc_Answer4Work.AnswerName].ToString().Trim(); //问答名称
objvcc_Answer4WorkEN.AnswerContent = objRow[convcc_Answer4Work.AnswerContent] == DBNull.Value ? null : objRow[convcc_Answer4Work.AnswerContent].ToString().Trim(); //答案内容
objvcc_Answer4WorkEN.QuestionResolve = objRow[convcc_Answer4Work.QuestionResolve] == DBNull.Value ? null : objRow[convcc_Answer4Work.QuestionResolve].ToString().Trim(); //题目解析
objvcc_Answer4WorkEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[convcc_Answer4Work.IsCorrect].ToString().Trim()); //是否正确
objvcc_Answer4WorkEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_Answer4Work.IsShow].ToString().Trim()); //是否启用
objvcc_Answer4WorkEN.UpdDate = objRow[convcc_Answer4Work.UpdDate].ToString().Trim(); //修改日期
objvcc_Answer4WorkEN.UpdUser = objRow[convcc_Answer4Work.UpdUser].ToString().Trim(); //修改人
objvcc_Answer4WorkEN.Memo = objRow[convcc_Answer4Work.Memo] == DBNull.Value ? null : objRow[convcc_Answer4Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_Answer4WorkEN.IdAnswer4Work, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_Answer4WorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_Answer4WorkEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_Answer4WorkEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_Answer4WorkEN> arrObjLst = new List<clsvcc_Answer4WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_Answer4WorkEN objvcc_Answer4WorkEN = new clsvcc_Answer4WorkEN();
try
{
objvcc_Answer4WorkEN.IdAnswer4Work = objRow[convcc_Answer4Work.IdAnswer4Work].ToString().Trim(); //作业答案流水号
objvcc_Answer4WorkEN.IdWork = objRow[convcc_Answer4Work.IdWork].ToString().Trim(); //作业流水号
objvcc_Answer4WorkEN.WorkIndex = objRow[convcc_Answer4Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Answer4Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_Answer4WorkEN.WorkName = objRow[convcc_Answer4Work.WorkName].ToString().Trim(); //作业名称
objvcc_Answer4WorkEN.WorkDesc = objRow[convcc_Answer4Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Answer4Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_Answer4WorkEN.CourseId = objRow[convcc_Answer4Work.CourseId] == DBNull.Value ? null : objRow[convcc_Answer4Work.CourseId].ToString().Trim(); //课程Id
objvcc_Answer4WorkEN.CourseName = objRow[convcc_Answer4Work.CourseName] == DBNull.Value ? null : objRow[convcc_Answer4Work.CourseName].ToString().Trim(); //课程名称
objvcc_Answer4WorkEN.CourseChapterId = objRow[convcc_Answer4Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_Answer4WorkEN.CourseChapterName = objRow[convcc_Answer4Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_Answer4WorkEN.ParentNodeId = objRow[convcc_Answer4Work.ParentNodeId] == DBNull.Value ? null : objRow[convcc_Answer4Work.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_Answer4WorkEN.ParentNodeName = objRow[convcc_Answer4Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Answer4Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_Answer4WorkEN.AnswerIndex = objRow[convcc_Answer4Work.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Answer4Work.AnswerIndex].ToString().Trim()); //问答序号
objvcc_Answer4WorkEN.AnswerName = objRow[convcc_Answer4Work.AnswerName] == DBNull.Value ? null : objRow[convcc_Answer4Work.AnswerName].ToString().Trim(); //问答名称
objvcc_Answer4WorkEN.AnswerContent = objRow[convcc_Answer4Work.AnswerContent] == DBNull.Value ? null : objRow[convcc_Answer4Work.AnswerContent].ToString().Trim(); //答案内容
objvcc_Answer4WorkEN.QuestionResolve = objRow[convcc_Answer4Work.QuestionResolve] == DBNull.Value ? null : objRow[convcc_Answer4Work.QuestionResolve].ToString().Trim(); //题目解析
objvcc_Answer4WorkEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[convcc_Answer4Work.IsCorrect].ToString().Trim()); //是否正确
objvcc_Answer4WorkEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_Answer4Work.IsShow].ToString().Trim()); //是否启用
objvcc_Answer4WorkEN.UpdDate = objRow[convcc_Answer4Work.UpdDate].ToString().Trim(); //修改日期
objvcc_Answer4WorkEN.UpdUser = objRow[convcc_Answer4Work.UpdUser].ToString().Trim(); //修改人
objvcc_Answer4WorkEN.Memo = objRow[convcc_Answer4Work.Memo] == DBNull.Value ? null : objRow[convcc_Answer4Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_Answer4WorkEN.IdAnswer4Work, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_Answer4WorkEN);
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
public static List<clsvcc_Answer4WorkEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_Answer4WorkEN> arrObjLst = new List<clsvcc_Answer4WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_Answer4WorkEN objvcc_Answer4WorkEN = new clsvcc_Answer4WorkEN();
try
{
objvcc_Answer4WorkEN.IdAnswer4Work = objRow[convcc_Answer4Work.IdAnswer4Work].ToString().Trim(); //作业答案流水号
objvcc_Answer4WorkEN.IdWork = objRow[convcc_Answer4Work.IdWork].ToString().Trim(); //作业流水号
objvcc_Answer4WorkEN.WorkIndex = objRow[convcc_Answer4Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Answer4Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_Answer4WorkEN.WorkName = objRow[convcc_Answer4Work.WorkName].ToString().Trim(); //作业名称
objvcc_Answer4WorkEN.WorkDesc = objRow[convcc_Answer4Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Answer4Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_Answer4WorkEN.CourseId = objRow[convcc_Answer4Work.CourseId] == DBNull.Value ? null : objRow[convcc_Answer4Work.CourseId].ToString().Trim(); //课程Id
objvcc_Answer4WorkEN.CourseName = objRow[convcc_Answer4Work.CourseName] == DBNull.Value ? null : objRow[convcc_Answer4Work.CourseName].ToString().Trim(); //课程名称
objvcc_Answer4WorkEN.CourseChapterId = objRow[convcc_Answer4Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_Answer4WorkEN.CourseChapterName = objRow[convcc_Answer4Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_Answer4WorkEN.ParentNodeId = objRow[convcc_Answer4Work.ParentNodeId] == DBNull.Value ? null : objRow[convcc_Answer4Work.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_Answer4WorkEN.ParentNodeName = objRow[convcc_Answer4Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Answer4Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_Answer4WorkEN.AnswerIndex = objRow[convcc_Answer4Work.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Answer4Work.AnswerIndex].ToString().Trim()); //问答序号
objvcc_Answer4WorkEN.AnswerName = objRow[convcc_Answer4Work.AnswerName] == DBNull.Value ? null : objRow[convcc_Answer4Work.AnswerName].ToString().Trim(); //问答名称
objvcc_Answer4WorkEN.AnswerContent = objRow[convcc_Answer4Work.AnswerContent] == DBNull.Value ? null : objRow[convcc_Answer4Work.AnswerContent].ToString().Trim(); //答案内容
objvcc_Answer4WorkEN.QuestionResolve = objRow[convcc_Answer4Work.QuestionResolve] == DBNull.Value ? null : objRow[convcc_Answer4Work.QuestionResolve].ToString().Trim(); //题目解析
objvcc_Answer4WorkEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[convcc_Answer4Work.IsCorrect].ToString().Trim()); //是否正确
objvcc_Answer4WorkEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_Answer4Work.IsShow].ToString().Trim()); //是否启用
objvcc_Answer4WorkEN.UpdDate = objRow[convcc_Answer4Work.UpdDate].ToString().Trim(); //修改日期
objvcc_Answer4WorkEN.UpdUser = objRow[convcc_Answer4Work.UpdUser].ToString().Trim(); //修改人
objvcc_Answer4WorkEN.Memo = objRow[convcc_Answer4Work.Memo] == DBNull.Value ? null : objRow[convcc_Answer4Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_Answer4WorkEN.IdAnswer4Work, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_Answer4WorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_Answer4WorkEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_Answer4WorkEN> arrObjLst = new List<clsvcc_Answer4WorkEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_Answer4WorkEN objvcc_Answer4WorkEN = new clsvcc_Answer4WorkEN();
try
{
objvcc_Answer4WorkEN.IdAnswer4Work = objRow[convcc_Answer4Work.IdAnswer4Work].ToString().Trim(); //作业答案流水号
objvcc_Answer4WorkEN.IdWork = objRow[convcc_Answer4Work.IdWork].ToString().Trim(); //作业流水号
objvcc_Answer4WorkEN.WorkIndex = objRow[convcc_Answer4Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Answer4Work.WorkIndex].ToString().Trim()); //作业序号
objvcc_Answer4WorkEN.WorkName = objRow[convcc_Answer4Work.WorkName].ToString().Trim(); //作业名称
objvcc_Answer4WorkEN.WorkDesc = objRow[convcc_Answer4Work.WorkDesc] == DBNull.Value ? null : objRow[convcc_Answer4Work.WorkDesc].ToString().Trim(); //作业说明
objvcc_Answer4WorkEN.CourseId = objRow[convcc_Answer4Work.CourseId] == DBNull.Value ? null : objRow[convcc_Answer4Work.CourseId].ToString().Trim(); //课程Id
objvcc_Answer4WorkEN.CourseName = objRow[convcc_Answer4Work.CourseName] == DBNull.Value ? null : objRow[convcc_Answer4Work.CourseName].ToString().Trim(); //课程名称
objvcc_Answer4WorkEN.CourseChapterId = objRow[convcc_Answer4Work.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_Answer4WorkEN.CourseChapterName = objRow[convcc_Answer4Work.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_Answer4WorkEN.ParentNodeId = objRow[convcc_Answer4Work.ParentNodeId] == DBNull.Value ? null : objRow[convcc_Answer4Work.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_Answer4WorkEN.ParentNodeName = objRow[convcc_Answer4Work.ParentNodeName] == DBNull.Value ? null : objRow[convcc_Answer4Work.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_Answer4WorkEN.AnswerIndex = objRow[convcc_Answer4Work.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Answer4Work.AnswerIndex].ToString().Trim()); //问答序号
objvcc_Answer4WorkEN.AnswerName = objRow[convcc_Answer4Work.AnswerName] == DBNull.Value ? null : objRow[convcc_Answer4Work.AnswerName].ToString().Trim(); //问答名称
objvcc_Answer4WorkEN.AnswerContent = objRow[convcc_Answer4Work.AnswerContent] == DBNull.Value ? null : objRow[convcc_Answer4Work.AnswerContent].ToString().Trim(); //答案内容
objvcc_Answer4WorkEN.QuestionResolve = objRow[convcc_Answer4Work.QuestionResolve] == DBNull.Value ? null : objRow[convcc_Answer4Work.QuestionResolve].ToString().Trim(); //题目解析
objvcc_Answer4WorkEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[convcc_Answer4Work.IsCorrect].ToString().Trim()); //是否正确
objvcc_Answer4WorkEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_Answer4Work.IsShow].ToString().Trim()); //是否启用
objvcc_Answer4WorkEN.UpdDate = objRow[convcc_Answer4Work.UpdDate].ToString().Trim(); //修改日期
objvcc_Answer4WorkEN.UpdUser = objRow[convcc_Answer4Work.UpdUser].ToString().Trim(); //修改人
objvcc_Answer4WorkEN.Memo = objRow[convcc_Answer4Work.Memo] == DBNull.Value ? null : objRow[convcc_Answer4Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_Answer4WorkEN.IdAnswer4Work, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_Answer4WorkEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_Answer4Work(ref clsvcc_Answer4WorkEN objvcc_Answer4WorkEN)
{
bool bolResult = vcc_Answer4WorkDA.Getvcc_Answer4Work(ref objvcc_Answer4WorkEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdAnswer4Work">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_Answer4WorkEN GetObjByIdAnswer4Work(string strIdAnswer4Work)
{
if (strIdAnswer4Work.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdAnswer4Work]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdAnswer4Work) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdAnswer4Work]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvcc_Answer4WorkEN objvcc_Answer4WorkEN = vcc_Answer4WorkDA.GetObjByIdAnswer4Work(strIdAnswer4Work);
return objvcc_Answer4WorkEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_Answer4WorkEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_Answer4WorkEN objvcc_Answer4WorkEN = vcc_Answer4WorkDA.GetFirstObj(strWhereCond);
 return objvcc_Answer4WorkEN;
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
public static clsvcc_Answer4WorkEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_Answer4WorkEN objvcc_Answer4WorkEN = vcc_Answer4WorkDA.GetObjByDataRow(objRow);
 return objvcc_Answer4WorkEN;
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
public static clsvcc_Answer4WorkEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_Answer4WorkEN objvcc_Answer4WorkEN = vcc_Answer4WorkDA.GetObjByDataRow(objRow);
 return objvcc_Answer4WorkEN;
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
 /// <param name = "strIdAnswer4Work">所给的关键字</param>
 /// <param name = "lstvcc_Answer4WorkObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_Answer4WorkEN GetObjByIdAnswer4WorkFromList(string strIdAnswer4Work, List<clsvcc_Answer4WorkEN> lstvcc_Answer4WorkObjLst)
{
foreach (clsvcc_Answer4WorkEN objvcc_Answer4WorkEN in lstvcc_Answer4WorkObjLst)
{
if (objvcc_Answer4WorkEN.IdAnswer4Work == strIdAnswer4Work)
{
return objvcc_Answer4WorkEN;
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
 string strIdAnswer4Work;
 try
 {
 strIdAnswer4Work = new clsvcc_Answer4WorkDA().GetFirstID(strWhereCond);
 return strIdAnswer4Work;
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
 arrList = vcc_Answer4WorkDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_Answer4WorkDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdAnswer4Work">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdAnswer4Work)
{
if (string.IsNullOrEmpty(strIdAnswer4Work) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdAnswer4Work]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vcc_Answer4WorkDA.IsExist(strIdAnswer4Work);
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
 bolIsExist = clsvcc_Answer4WorkDA.IsExistTable();
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
 bolIsExist = vcc_Answer4WorkDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_Answer4WorkENS">源对象</param>
 /// <param name = "objvcc_Answer4WorkENT">目标对象</param>
 public static void CopyTo(clsvcc_Answer4WorkEN objvcc_Answer4WorkENS, clsvcc_Answer4WorkEN objvcc_Answer4WorkENT)
{
try
{
objvcc_Answer4WorkENT.IdAnswer4Work = objvcc_Answer4WorkENS.IdAnswer4Work; //作业答案流水号
objvcc_Answer4WorkENT.IdWork = objvcc_Answer4WorkENS.IdWork; //作业流水号
objvcc_Answer4WorkENT.WorkIndex = objvcc_Answer4WorkENS.WorkIndex; //作业序号
objvcc_Answer4WorkENT.WorkName = objvcc_Answer4WorkENS.WorkName; //作业名称
objvcc_Answer4WorkENT.WorkDesc = objvcc_Answer4WorkENS.WorkDesc; //作业说明
objvcc_Answer4WorkENT.CourseId = objvcc_Answer4WorkENS.CourseId; //课程Id
objvcc_Answer4WorkENT.CourseName = objvcc_Answer4WorkENS.CourseName; //课程名称
objvcc_Answer4WorkENT.CourseChapterId = objvcc_Answer4WorkENS.CourseChapterId; //课程章节ID
objvcc_Answer4WorkENT.CourseChapterName = objvcc_Answer4WorkENS.CourseChapterName; //课程章节名称
objvcc_Answer4WorkENT.ParentNodeId = objvcc_Answer4WorkENS.ParentNodeId; //父节点编号
objvcc_Answer4WorkENT.ParentNodeName = objvcc_Answer4WorkENS.ParentNodeName; //父节点名称
objvcc_Answer4WorkENT.AnswerIndex = objvcc_Answer4WorkENS.AnswerIndex; //问答序号
objvcc_Answer4WorkENT.AnswerName = objvcc_Answer4WorkENS.AnswerName; //问答名称
objvcc_Answer4WorkENT.AnswerContent = objvcc_Answer4WorkENS.AnswerContent; //答案内容
objvcc_Answer4WorkENT.QuestionResolve = objvcc_Answer4WorkENS.QuestionResolve; //题目解析
objvcc_Answer4WorkENT.IsCorrect = objvcc_Answer4WorkENS.IsCorrect; //是否正确
objvcc_Answer4WorkENT.IsShow = objvcc_Answer4WorkENS.IsShow; //是否启用
objvcc_Answer4WorkENT.UpdDate = objvcc_Answer4WorkENS.UpdDate; //修改日期
objvcc_Answer4WorkENT.UpdUser = objvcc_Answer4WorkENS.UpdUser; //修改人
objvcc_Answer4WorkENT.Memo = objvcc_Answer4WorkENS.Memo; //备注
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
 /// <param name = "objvcc_Answer4WorkEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_Answer4WorkEN objvcc_Answer4WorkEN)
{
try
{
objvcc_Answer4WorkEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_Answer4WorkEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_Answer4Work.IdAnswer4Work, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_Answer4WorkEN.IdAnswer4Work = objvcc_Answer4WorkEN.IdAnswer4Work; //作业答案流水号
}
if (arrFldSet.Contains(convcc_Answer4Work.IdWork, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_Answer4WorkEN.IdWork = objvcc_Answer4WorkEN.IdWork; //作业流水号
}
if (arrFldSet.Contains(convcc_Answer4Work.WorkIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_Answer4WorkEN.WorkIndex = objvcc_Answer4WorkEN.WorkIndex; //作业序号
}
if (arrFldSet.Contains(convcc_Answer4Work.WorkName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_Answer4WorkEN.WorkName = objvcc_Answer4WorkEN.WorkName; //作业名称
}
if (arrFldSet.Contains(convcc_Answer4Work.WorkDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_Answer4WorkEN.WorkDesc = objvcc_Answer4WorkEN.WorkDesc == "[null]" ? null :  objvcc_Answer4WorkEN.WorkDesc; //作业说明
}
if (arrFldSet.Contains(convcc_Answer4Work.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_Answer4WorkEN.CourseId = objvcc_Answer4WorkEN.CourseId == "[null]" ? null :  objvcc_Answer4WorkEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_Answer4Work.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_Answer4WorkEN.CourseName = objvcc_Answer4WorkEN.CourseName == "[null]" ? null :  objvcc_Answer4WorkEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convcc_Answer4Work.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_Answer4WorkEN.CourseChapterId = objvcc_Answer4WorkEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convcc_Answer4Work.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_Answer4WorkEN.CourseChapterName = objvcc_Answer4WorkEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convcc_Answer4Work.ParentNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_Answer4WorkEN.ParentNodeId = objvcc_Answer4WorkEN.ParentNodeId == "[null]" ? null :  objvcc_Answer4WorkEN.ParentNodeId; //父节点编号
}
if (arrFldSet.Contains(convcc_Answer4Work.ParentNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_Answer4WorkEN.ParentNodeName = objvcc_Answer4WorkEN.ParentNodeName == "[null]" ? null :  objvcc_Answer4WorkEN.ParentNodeName; //父节点名称
}
if (arrFldSet.Contains(convcc_Answer4Work.AnswerIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_Answer4WorkEN.AnswerIndex = objvcc_Answer4WorkEN.AnswerIndex; //问答序号
}
if (arrFldSet.Contains(convcc_Answer4Work.AnswerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_Answer4WorkEN.AnswerName = objvcc_Answer4WorkEN.AnswerName == "[null]" ? null :  objvcc_Answer4WorkEN.AnswerName; //问答名称
}
if (arrFldSet.Contains(convcc_Answer4Work.AnswerContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_Answer4WorkEN.AnswerContent = objvcc_Answer4WorkEN.AnswerContent == "[null]" ? null :  objvcc_Answer4WorkEN.AnswerContent; //答案内容
}
if (arrFldSet.Contains(convcc_Answer4Work.QuestionResolve, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_Answer4WorkEN.QuestionResolve = objvcc_Answer4WorkEN.QuestionResolve == "[null]" ? null :  objvcc_Answer4WorkEN.QuestionResolve; //题目解析
}
if (arrFldSet.Contains(convcc_Answer4Work.IsCorrect, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_Answer4WorkEN.IsCorrect = objvcc_Answer4WorkEN.IsCorrect; //是否正确
}
if (arrFldSet.Contains(convcc_Answer4Work.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_Answer4WorkEN.IsShow = objvcc_Answer4WorkEN.IsShow; //是否启用
}
if (arrFldSet.Contains(convcc_Answer4Work.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_Answer4WorkEN.UpdDate = objvcc_Answer4WorkEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_Answer4Work.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_Answer4WorkEN.UpdUser = objvcc_Answer4WorkEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convcc_Answer4Work.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_Answer4WorkEN.Memo = objvcc_Answer4WorkEN.Memo == "[null]" ? null :  objvcc_Answer4WorkEN.Memo; //备注
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
 /// <param name = "objvcc_Answer4WorkEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_Answer4WorkEN objvcc_Answer4WorkEN)
{
try
{
if (objvcc_Answer4WorkEN.WorkDesc == "[null]") objvcc_Answer4WorkEN.WorkDesc = null; //作业说明
if (objvcc_Answer4WorkEN.CourseId == "[null]") objvcc_Answer4WorkEN.CourseId = null; //课程Id
if (objvcc_Answer4WorkEN.CourseName == "[null]") objvcc_Answer4WorkEN.CourseName = null; //课程名称
if (objvcc_Answer4WorkEN.ParentNodeId == "[null]") objvcc_Answer4WorkEN.ParentNodeId = null; //父节点编号
if (objvcc_Answer4WorkEN.ParentNodeName == "[null]") objvcc_Answer4WorkEN.ParentNodeName = null; //父节点名称
if (objvcc_Answer4WorkEN.AnswerName == "[null]") objvcc_Answer4WorkEN.AnswerName = null; //问答名称
if (objvcc_Answer4WorkEN.AnswerContent == "[null]") objvcc_Answer4WorkEN.AnswerContent = null; //答案内容
if (objvcc_Answer4WorkEN.QuestionResolve == "[null]") objvcc_Answer4WorkEN.QuestionResolve = null; //题目解析
if (objvcc_Answer4WorkEN.Memo == "[null]") objvcc_Answer4WorkEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvcc_Answer4WorkEN objvcc_Answer4WorkEN)
{
 vcc_Answer4WorkDA.CheckProperty4Condition(objvcc_Answer4WorkEN);
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
if (clscc_Answer4WorkBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_Answer4WorkBL没有刷新缓存机制(clscc_Answer4WorkBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_WorkBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkBL没有刷新缓存机制(clscc_WorkBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by IdAnswer4Work");
//if (arrvcc_Answer4WorkObjLstCache == null)
//{
//arrvcc_Answer4WorkObjLstCache = vcc_Answer4WorkDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdAnswer4Work">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_Answer4WorkEN GetObjByIdAnswer4WorkCache(string strIdAnswer4Work)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvcc_Answer4WorkEN._CurrTabName);
List<clsvcc_Answer4WorkEN> arrvcc_Answer4WorkObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_Answer4WorkEN> arrvcc_Answer4WorkObjLst_Sel =
arrvcc_Answer4WorkObjLstCache
.Where(x=> x.IdAnswer4Work == strIdAnswer4Work 
);
if (arrvcc_Answer4WorkObjLst_Sel.Count() == 0)
{
   clsvcc_Answer4WorkEN obj = clsvcc_Answer4WorkBL.GetObjByIdAnswer4Work(strIdAnswer4Work);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvcc_Answer4WorkObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_Answer4WorkEN> GetAllvcc_Answer4WorkObjLstCache()
{
//获取缓存中的对象列表
List<clsvcc_Answer4WorkEN> arrvcc_Answer4WorkObjLstCache = GetObjLstCache(); 
return arrvcc_Answer4WorkObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_Answer4WorkEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvcc_Answer4WorkEN._CurrTabName);
List<clsvcc_Answer4WorkEN> arrvcc_Answer4WorkObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_Answer4WorkObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvcc_Answer4WorkEN._CurrTabName);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdAnswer4Work)
{
if (strInFldName != convcc_Answer4Work.IdAnswer4Work)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_Answer4Work.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_Answer4Work.AttributeName));
throw new Exception(strMsg);
}
var objvcc_Answer4Work = clsvcc_Answer4WorkBL.GetObjByIdAnswer4WorkCache(strIdAnswer4Work);
if (objvcc_Answer4Work == null) return "";
return objvcc_Answer4Work[strOutFldName].ToString();
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
int intRecCount = clsvcc_Answer4WorkDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_Answer4WorkDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_Answer4WorkDA.GetRecCount();
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
int intRecCount = clsvcc_Answer4WorkDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_Answer4WorkEN objvcc_Answer4WorkCond)
{
List<clsvcc_Answer4WorkEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_Answer4WorkEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_Answer4Work.AttributeName)
{
if (objvcc_Answer4WorkCond.IsUpdated(strFldName) == false) continue;
if (objvcc_Answer4WorkCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_Answer4WorkCond[strFldName].ToString());
}
else
{
if (objvcc_Answer4WorkCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_Answer4WorkCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_Answer4WorkCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_Answer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_Answer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_Answer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_Answer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_Answer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_Answer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_Answer4WorkCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_Answer4WorkCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_Answer4WorkCond[strFldName]));
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
 List<string> arrList = clsvcc_Answer4WorkDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_Answer4WorkDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_Answer4WorkDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}