
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_Answer4WorkWApi
 表名:vcc_Answer4Work(01120193)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:56
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理
 模块英文名:InteractManage
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
public static class clsvcc_Answer4WorkWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetId_Answer4Work(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strId_Answer4Work, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_Answer4Work, 8, convcc_Answer4Work.Id_Answer4Work);
clsCheckSql.CheckFieldForeignKey(strId_Answer4Work, 8, convcc_Answer4Work.Id_Answer4Work);
objvcc_Answer4WorkEN.Id_Answer4Work = strId_Answer4Work; //作业答案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_Answer4WorkEN.dicFldComparisonOp.ContainsKey(convcc_Answer4Work.Id_Answer4Work) == false)
{
objvcc_Answer4WorkEN.dicFldComparisonOp.Add(convcc_Answer4Work.Id_Answer4Work, strComparisonOp);
}
else
{
objvcc_Answer4WorkEN.dicFldComparisonOp[convcc_Answer4Work.Id_Answer4Work] = strComparisonOp;
}
}
return objvcc_Answer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetId_Work(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strId_Work, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strId_Work, convcc_Answer4Work.Id_Work);
clsCheckSql.CheckFieldLen(strId_Work, 8, convcc_Answer4Work.Id_Work);
clsCheckSql.CheckFieldForeignKey(strId_Work, 8, convcc_Answer4Work.Id_Work);
objvcc_Answer4WorkEN.Id_Work = strId_Work; //作业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_Answer4WorkEN.dicFldComparisonOp.ContainsKey(convcc_Answer4Work.Id_Work) == false)
{
objvcc_Answer4WorkEN.dicFldComparisonOp.Add(convcc_Answer4Work.Id_Work, strComparisonOp);
}
else
{
objvcc_Answer4WorkEN.dicFldComparisonOp[convcc_Answer4Work.Id_Work] = strComparisonOp;
}
}
return objvcc_Answer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetWorkIndex(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, int intWorkIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetWorkName(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strWorkName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkName, convcc_Answer4Work.WorkName);
clsCheckSql.CheckFieldLen(strWorkName, 5000, convcc_Answer4Work.WorkName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetCourseId(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_Answer4Work.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_Answer4Work.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetCourseName(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_Answer4Work.CourseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetCourseChapterId(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convcc_Answer4Work.CourseChapterId);
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_Answer4Work.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_Answer4Work.CourseChapterId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetCourseChapterName(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterName, convcc_Answer4Work.CourseChapterName);
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_Answer4Work.CourseChapterName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetParentNodeID(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convcc_Answer4Work.ParentNodeID);
objvcc_Answer4WorkEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_Answer4WorkEN.dicFldComparisonOp.ContainsKey(convcc_Answer4Work.ParentNodeID) == false)
{
objvcc_Answer4WorkEN.dicFldComparisonOp.Add(convcc_Answer4Work.ParentNodeID, strComparisonOp);
}
else
{
objvcc_Answer4WorkEN.dicFldComparisonOp[convcc_Answer4Work.ParentNodeID] = strComparisonOp;
}
}
return objvcc_Answer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetParentNodeName(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convcc_Answer4Work.ParentNodeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetAnswerIndex(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, int intAnswerIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetAnswerName(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strAnswerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerName, 100, convcc_Answer4Work.AnswerName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetQuestionResolve(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strQuestionResolve, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionResolve, 8000, convcc_Answer4Work.QuestionResolve);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetUpdDate(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_Answer4Work.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_Answer4Work.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetUpdUser(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convcc_Answer4Work.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_Answer4Work.UpdUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_Answer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_Answer4WorkEN SetMemo(this clsvcc_Answer4WorkEN objvcc_Answer4WorkEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_Answer4Work.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_Answer4WorkEN objvcc_Answer4Work_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_Answer4Work_Cond.IsUpdated(convcc_Answer4Work.Id_Answer4Work) == true)
{
string strComparisonOp_Id_Answer4Work = objvcc_Answer4Work_Cond.dicFldComparisonOp[convcc_Answer4Work.Id_Answer4Work];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.Id_Answer4Work, objvcc_Answer4Work_Cond.Id_Answer4Work, strComparisonOp_Id_Answer4Work);
}
if (objvcc_Answer4Work_Cond.IsUpdated(convcc_Answer4Work.Id_Work) == true)
{
string strComparisonOp_Id_Work = objvcc_Answer4Work_Cond.dicFldComparisonOp[convcc_Answer4Work.Id_Work];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.Id_Work, objvcc_Answer4Work_Cond.Id_Work, strComparisonOp_Id_Work);
}
if (objvcc_Answer4Work_Cond.IsUpdated(convcc_Answer4Work.WorkIndex) == true)
{
string strComparisonOp_WorkIndex = objvcc_Answer4Work_Cond.dicFldComparisonOp[convcc_Answer4Work.WorkIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Answer4Work.WorkIndex, objvcc_Answer4Work_Cond.WorkIndex, strComparisonOp_WorkIndex);
}
if (objvcc_Answer4Work_Cond.IsUpdated(convcc_Answer4Work.WorkName) == true)
{
string strComparisonOp_WorkName = objvcc_Answer4Work_Cond.dicFldComparisonOp[convcc_Answer4Work.WorkName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.WorkName, objvcc_Answer4Work_Cond.WorkName, strComparisonOp_WorkName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvcc_Answer4Work_Cond.IsUpdated(convcc_Answer4Work.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_Answer4Work_Cond.dicFldComparisonOp[convcc_Answer4Work.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.CourseId, objvcc_Answer4Work_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_Answer4Work_Cond.IsUpdated(convcc_Answer4Work.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_Answer4Work_Cond.dicFldComparisonOp[convcc_Answer4Work.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.CourseName, objvcc_Answer4Work_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_Answer4Work_Cond.IsUpdated(convcc_Answer4Work.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvcc_Answer4Work_Cond.dicFldComparisonOp[convcc_Answer4Work.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.CourseChapterId, objvcc_Answer4Work_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvcc_Answer4Work_Cond.IsUpdated(convcc_Answer4Work.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvcc_Answer4Work_Cond.dicFldComparisonOp[convcc_Answer4Work.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.CourseChapterName, objvcc_Answer4Work_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvcc_Answer4Work_Cond.IsUpdated(convcc_Answer4Work.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvcc_Answer4Work_Cond.dicFldComparisonOp[convcc_Answer4Work.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.ParentNodeID, objvcc_Answer4Work_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvcc_Answer4Work_Cond.IsUpdated(convcc_Answer4Work.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvcc_Answer4Work_Cond.dicFldComparisonOp[convcc_Answer4Work.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.ParentNodeName, objvcc_Answer4Work_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvcc_Answer4Work_Cond.IsUpdated(convcc_Answer4Work.AnswerIndex) == true)
{
string strComparisonOp_AnswerIndex = objvcc_Answer4Work_Cond.dicFldComparisonOp[convcc_Answer4Work.AnswerIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Answer4Work.AnswerIndex, objvcc_Answer4Work_Cond.AnswerIndex, strComparisonOp_AnswerIndex);
}
if (objvcc_Answer4Work_Cond.IsUpdated(convcc_Answer4Work.AnswerName) == true)
{
string strComparisonOp_AnswerName = objvcc_Answer4Work_Cond.dicFldComparisonOp[convcc_Answer4Work.AnswerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.AnswerName, objvcc_Answer4Work_Cond.AnswerName, strComparisonOp_AnswerName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvcc_Answer4Work_Cond.IsUpdated(convcc_Answer4Work.QuestionResolve) == true)
{
string strComparisonOp_QuestionResolve = objvcc_Answer4Work_Cond.dicFldComparisonOp[convcc_Answer4Work.QuestionResolve];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.QuestionResolve, objvcc_Answer4Work_Cond.QuestionResolve, strComparisonOp_QuestionResolve);
}
if (objvcc_Answer4Work_Cond.IsUpdated(convcc_Answer4Work.IsCorrect) == true)
{
if (objvcc_Answer4Work_Cond.IsCorrect == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_Answer4Work.IsCorrect);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_Answer4Work.IsCorrect);
}
}
if (objvcc_Answer4Work_Cond.IsUpdated(convcc_Answer4Work.IsShow) == true)
{
if (objvcc_Answer4Work_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_Answer4Work.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_Answer4Work.IsShow);
}
}
if (objvcc_Answer4Work_Cond.IsUpdated(convcc_Answer4Work.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_Answer4Work_Cond.dicFldComparisonOp[convcc_Answer4Work.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.UpdDate, objvcc_Answer4Work_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_Answer4Work_Cond.IsUpdated(convcc_Answer4Work.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvcc_Answer4Work_Cond.dicFldComparisonOp[convcc_Answer4Work.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.UpdUser, objvcc_Answer4Work_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvcc_Answer4Work_Cond.IsUpdated(convcc_Answer4Work.Memo) == true)
{
string strComparisonOp_Memo = objvcc_Answer4Work_Cond.dicFldComparisonOp[convcc_Answer4Work.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Answer4Work.Memo, objvcc_Answer4Work_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v作业答案(vcc_Answer4Work)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_Answer4WorkWApi
{
private static readonly string mstrApiControllerName = "vcc_Answer4WorkApi";

 public clsvcc_Answer4WorkWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_Answer4Work">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_Answer4WorkEN GetObjById_Answer4Work(string strId_Answer4Work)
{
string strAction = "GetObjById_Answer4Work";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_Answer4WorkEN objvcc_Answer4WorkEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_Answer4Work"] = strId_Answer4Work
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_Answer4WorkEN = JsonConvert.DeserializeObject<clsvcc_Answer4WorkEN>((string)jobjReturn["ReturnObj"]);
return objvcc_Answer4WorkEN;
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
 /// <param name = "strId_Answer4Work">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_Answer4WorkEN GetObjById_Answer4Work_WA_Cache(string strId_Answer4Work)
{
string strAction = "GetObjById_Answer4Work_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_Answer4WorkEN objvcc_Answer4WorkEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_Answer4Work"] = strId_Answer4Work
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_Answer4WorkEN = JsonConvert.DeserializeObject<clsvcc_Answer4WorkEN>((string)jobjReturn["ReturnObj"]);
return objvcc_Answer4WorkEN;
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
public static clsvcc_Answer4WorkEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_Answer4WorkEN objvcc_Answer4WorkEN = null;
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
objvcc_Answer4WorkEN = JsonConvert.DeserializeObject<clsvcc_Answer4WorkEN>((string)jobjReturn["ReturnObj"]);
return objvcc_Answer4WorkEN;
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
 /// <param name = "strId_Answer4Work">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_Answer4WorkEN GetObjById_Answer4Work_Cache(string strId_Answer4Work)
{
if (string.IsNullOrEmpty(strId_Answer4Work) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_Answer4WorkEN._CurrTabName_S);
List<clsvcc_Answer4WorkEN> arrvcc_Answer4WorkObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_Answer4WorkEN> arrvcc_Answer4WorkObjLst_Sel =
from objvcc_Answer4WorkEN in arrvcc_Answer4WorkObjLst_Cache
where objvcc_Answer4WorkEN.Id_Answer4Work == strId_Answer4Work
select objvcc_Answer4WorkEN;
if (arrvcc_Answer4WorkObjLst_Sel.Count() == 0)
{
   clsvcc_Answer4WorkEN obj = clsvcc_Answer4WorkWApi.GetObjById_Answer4Work(strId_Answer4Work);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_Answer4WorkObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_Answer4WorkEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_Answer4WorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_Answer4WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_Answer4WorkEN> GetObjLstById_Answer4WorkLst(List<string> arrId_Answer4Work)
{
 List<clsvcc_Answer4WorkEN> arrObjLst = null; 
string strAction = "GetObjLstById_Answer4WorkLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_Answer4Work);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_Answer4WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strId_Answer4Work">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_Answer4WorkEN> GetObjLstById_Answer4WorkLst_Cache(List<string> arrId_Answer4Work)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_Answer4WorkEN._CurrTabName_S);
List<clsvcc_Answer4WorkEN> arrvcc_Answer4WorkObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_Answer4WorkEN> arrvcc_Answer4WorkObjLst_Sel =
from objvcc_Answer4WorkEN in arrvcc_Answer4WorkObjLst_Cache
where arrId_Answer4Work.Contains(objvcc_Answer4WorkEN.Id_Answer4Work)
select objvcc_Answer4WorkEN;
return arrvcc_Answer4WorkObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_Answer4WorkEN> GetObjLstById_Answer4WorkLst_WA_Cache(List<string> arrId_Answer4Work)
{
 List<clsvcc_Answer4WorkEN> arrObjLst = null; 
string strAction = "GetObjLstById_Answer4WorkLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_Answer4Work);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_Answer4WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_Answer4WorkEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_Answer4WorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_Answer4WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_Answer4WorkEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_Answer4WorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_Answer4WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_Answer4WorkEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_Answer4WorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_Answer4WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_Answer4WorkEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_Answer4WorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_Answer4WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strId_Answer4Work)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_Answer4Work"] = strId_Answer4Work
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
 /// <param name = "objvcc_Answer4WorkENS">源对象</param>
 /// <param name = "objvcc_Answer4WorkENT">目标对象</param>
 public static void CopyTo(clsvcc_Answer4WorkEN objvcc_Answer4WorkENS, clsvcc_Answer4WorkEN objvcc_Answer4WorkENT)
{
try
{
objvcc_Answer4WorkENT.Id_Answer4Work = objvcc_Answer4WorkENS.Id_Answer4Work; //作业答案流水号
objvcc_Answer4WorkENT.Id_Work = objvcc_Answer4WorkENS.Id_Work; //作业流水号
objvcc_Answer4WorkENT.WorkIndex = objvcc_Answer4WorkENS.WorkIndex; //作业序号
objvcc_Answer4WorkENT.WorkName = objvcc_Answer4WorkENS.WorkName; //作业名称
objvcc_Answer4WorkENT.WorkDesc = objvcc_Answer4WorkENS.WorkDesc; //作业说明
objvcc_Answer4WorkENT.CourseId = objvcc_Answer4WorkENS.CourseId; //课程Id
objvcc_Answer4WorkENT.CourseName = objvcc_Answer4WorkENS.CourseName; //课程名称
objvcc_Answer4WorkENT.CourseChapterId = objvcc_Answer4WorkENS.CourseChapterId; //课程章节ID
objvcc_Answer4WorkENT.CourseChapterName = objvcc_Answer4WorkENS.CourseChapterName; //课程章节名称
objvcc_Answer4WorkENT.ParentNodeID = objvcc_Answer4WorkENS.ParentNodeID; //父节点编号
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
public static DataTable ToDataTable(List<clsvcc_Answer4WorkEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_Answer4WorkEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_Answer4WorkEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_Answer4WorkEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_Answer4WorkEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_Answer4WorkEN.AttributeName)
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
if (clscc_Answer4WorkWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_Answer4WorkWApi没有刷新缓存机制(clscc_Answer4WorkWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_WorkWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkWApi没有刷新缓存机制(clscc_WorkWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by Id_Answer4Work");
//if (arrvcc_Answer4WorkObjLst_Cache == null)
//{
//arrvcc_Answer4WorkObjLst_Cache = await clsvcc_Answer4WorkWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvcc_Answer4WorkEN._CurrTabName_S);
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
public static List<clsvcc_Answer4WorkEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcc_Answer4WorkEN._CurrTabName_S);
List<clsvcc_Answer4WorkEN> arrvcc_Answer4WorkObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_Answer4WorkObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_Answer4WorkEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_Answer4Work.Id_Answer4Work, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Answer4Work.Id_Work, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Answer4Work.WorkIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_Answer4Work.WorkName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Answer4Work.WorkDesc, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Answer4Work.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Answer4Work.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Answer4Work.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Answer4Work.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Answer4Work.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Answer4Work.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Answer4Work.AnswerIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_Answer4Work.AnswerName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Answer4Work.AnswerContent, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Answer4Work.QuestionResolve, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Answer4Work.IsCorrect, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_Answer4Work.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_Answer4Work.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Answer4Work.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Answer4Work.Memo, Type.GetType("System.String"));
foreach (clsvcc_Answer4WorkEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_Answer4Work.Id_Answer4Work] = objInFor[convcc_Answer4Work.Id_Answer4Work];
objDR[convcc_Answer4Work.Id_Work] = objInFor[convcc_Answer4Work.Id_Work];
objDR[convcc_Answer4Work.WorkIndex] = objInFor[convcc_Answer4Work.WorkIndex];
objDR[convcc_Answer4Work.WorkName] = objInFor[convcc_Answer4Work.WorkName];
objDR[convcc_Answer4Work.WorkDesc] = objInFor[convcc_Answer4Work.WorkDesc];
objDR[convcc_Answer4Work.CourseId] = objInFor[convcc_Answer4Work.CourseId];
objDR[convcc_Answer4Work.CourseName] = objInFor[convcc_Answer4Work.CourseName];
objDR[convcc_Answer4Work.CourseChapterId] = objInFor[convcc_Answer4Work.CourseChapterId];
objDR[convcc_Answer4Work.CourseChapterName] = objInFor[convcc_Answer4Work.CourseChapterName];
objDR[convcc_Answer4Work.ParentNodeID] = objInFor[convcc_Answer4Work.ParentNodeID];
objDR[convcc_Answer4Work.ParentNodeName] = objInFor[convcc_Answer4Work.ParentNodeName];
objDR[convcc_Answer4Work.AnswerIndex] = objInFor[convcc_Answer4Work.AnswerIndex];
objDR[convcc_Answer4Work.AnswerName] = objInFor[convcc_Answer4Work.AnswerName];
objDR[convcc_Answer4Work.AnswerContent] = objInFor[convcc_Answer4Work.AnswerContent];
objDR[convcc_Answer4Work.QuestionResolve] = objInFor[convcc_Answer4Work.QuestionResolve];
objDR[convcc_Answer4Work.IsCorrect] = objInFor[convcc_Answer4Work.IsCorrect];
objDR[convcc_Answer4Work.IsShow] = objInFor[convcc_Answer4Work.IsShow];
objDR[convcc_Answer4Work.UpdDate] = objInFor[convcc_Answer4Work.UpdDate];
objDR[convcc_Answer4Work.UpdUser] = objInFor[convcc_Answer4Work.UpdUser];
objDR[convcc_Answer4Work.Memo] = objInFor[convcc_Answer4Work.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}