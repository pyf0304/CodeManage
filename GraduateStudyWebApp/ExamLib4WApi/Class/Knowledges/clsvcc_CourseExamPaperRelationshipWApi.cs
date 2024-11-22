
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseExamPaperRelationshipWApi
 表名:vcc_CourseExamPaperRelationship(01120075)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:40:37
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
public static class clsvcc_CourseExamPaperRelationshipWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetCourseExamPaperId(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convcc_CourseExamPaperRelationship.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convcc_CourseExamPaperRelationship.CourseExamPaperId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetExamPaperName(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strExamPaperName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, convcc_CourseExamPaperRelationship.ExamPaperName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetCourseId(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_CourseExamPaperRelationship.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_CourseExamPaperRelationship.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetCourseName(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_CourseExamPaperRelationship.CourseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetQuestionID(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convcc_CourseExamPaperRelationship.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convcc_CourseExamPaperRelationship.QuestionID);
objvcc_CourseExamPaperRelationshipEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.QuestionID) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.QuestionID, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionID] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetQuestionIndex(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, int intQuestionIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetQuestionName(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convcc_CourseExamPaperRelationship.QuestionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetQuestionContent(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strQuestionContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, convcc_CourseExamPaperRelationship.QuestionContent);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetExamAnswer(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strExamAnswer, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamAnswer, 8000, convcc_CourseExamPaperRelationship.ExamAnswer);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetCourseChapterId(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_CourseExamPaperRelationship.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_CourseExamPaperRelationship.CourseChapterId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetCourseChapterName(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_CourseExamPaperRelationship.CourseChapterName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetParentNodeID(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convcc_CourseExamPaperRelationship.ParentNodeID);
objvcc_CourseExamPaperRelationshipEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.ParentNodeID) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.ParentNodeID, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.ParentNodeID] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetParentNodeName(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convcc_CourseExamPaperRelationship.ParentNodeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetQuestionTypeId(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convcc_CourseExamPaperRelationship.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convcc_CourseExamPaperRelationship.QuestionTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetQuestionTypeName(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convcc_CourseExamPaperRelationship.QuestionTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetExamGradeId(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strExamGradeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamGradeId, 2, convcc_CourseExamPaperRelationship.ExamGradeId);
clsCheckSql.CheckFieldForeignKey(strExamGradeId, 2, convcc_CourseExamPaperRelationship.ExamGradeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetExamGradeName(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strExamGradeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamGradeName, 50, convcc_CourseExamPaperRelationship.ExamGradeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetAnswerTypeId(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convcc_CourseExamPaperRelationship.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convcc_CourseExamPaperRelationship.AnswerTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetAnswerModeId(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convcc_CourseExamPaperRelationship.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convcc_CourseExamPaperRelationship.AnswerModeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetQuestionScore(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, float fltQuestionScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetQuestionName_Add(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strQuestionName_Add, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName_Add, 500, convcc_CourseExamPaperRelationship.QuestionName_Add);
objvcc_CourseExamPaperRelationshipEN.QuestionName_Add = strQuestionName_Add; //题目补充
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.QuestionName_Add) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.QuestionName_Add, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionName_Add] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetDefaultValue(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convcc_CourseExamPaperRelationship.DefaultValue);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetTextDirectId(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strTextDirectId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTextDirectId, 4, convcc_CourseExamPaperRelationship.TextDirectId);
clsCheckSql.CheckFieldForeignKey(strTextDirectId, 4, convcc_CourseExamPaperRelationship.TextDirectId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetFillInTextWidth(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, int intFillInTextWidth, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetMemoTextWidth(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, int intMemoTextWidth, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetCodeTab(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strCodeTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTab, 50, convcc_CourseExamPaperRelationship.CodeTab);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetCodeTab_Code(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strCodeTab_Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTab_Code, 50, convcc_CourseExamPaperRelationship.CodeTab_Code);
objvcc_CourseExamPaperRelationshipEN.CodeTab_Code = strCodeTab_Code; //CodeTab_Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.CodeTab_Code) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.CodeTab_Code, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CodeTab_Code] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetCodeTab_Name(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strCodeTab_Name, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTab_Name, 50, convcc_CourseExamPaperRelationship.CodeTab_Name);
objvcc_CourseExamPaperRelationshipEN.CodeTab_Name = strCodeTab_Name; //CodeTab_Name
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.CodeTab_Name) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.CodeTab_Name, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CodeTab_Name] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetCodeTab_Condition(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strCodeTab_Condition, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTab_Condition, 200, convcc_CourseExamPaperRelationship.CodeTab_Condition);
objvcc_CourseExamPaperRelationshipEN.CodeTab_Condition = strCodeTab_Condition; //代码表_条件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaperRelationship.CodeTab_Condition) == false)
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp.Add(convcc_CourseExamPaperRelationship.CodeTab_Condition, strComparisonOp);
}
else
{
objvcc_CourseExamPaperRelationshipEN.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CodeTab_Condition] = strComparisonOp;
}
}
return objvcc_CourseExamPaperRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetRelaEvent(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strRelaEvent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaEvent, 4000, convcc_CourseExamPaperRelationship.RelaEvent);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetDefaultSelectItem(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strDefaultSelectItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultSelectItem, 20, convcc_CourseExamPaperRelationship.DefaultSelectItem);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetFillInTextHeight(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, int intFillInTextHeight, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetCheckBoxLimitCount(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, int intCheckBoxLimitCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetUserId(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convcc_CourseExamPaperRelationship.UserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetStartTime(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, double dblStartTime, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetPapersBigTopicId(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strPapersBigTopicId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPapersBigTopicId, 8, convcc_CourseExamPaperRelationship.PapersBigTopicId);
clsCheckSql.CheckFieldForeignKey(strPapersBigTopicId, 8, convcc_CourseExamPaperRelationship.PapersBigTopicId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetPapersBigTopicName(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strPapersBigTopicName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPapersBigTopicName, 50, convcc_CourseExamPaperRelationship.PapersBigTopicName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetTopicDescription(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strTopicDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTopicDescription, 100, convcc_CourseExamPaperRelationship.TopicDescription);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetTopicScores(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, int intTopicScores, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetTopicOrderNum(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, int intTopicOrderNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetOrderNum(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, int intOrderNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetUpdDate(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_CourseExamPaperRelationship.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperRelationshipEN SetUpdUser(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_CourseExamPaperRelationship.UpdUser);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationship_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.mId) == true)
{
string strComparisonOp_mId = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship.mId, objvcc_CourseExamPaperRelationship_Cond.mId, strComparisonOp_mId);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.CourseExamPaperId, objvcc_CourseExamPaperRelationship_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.ExamPaperName) == true)
{
string strComparisonOp_ExamPaperName = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.ExamPaperName, objvcc_CourseExamPaperRelationship_Cond.ExamPaperName, strComparisonOp_ExamPaperName);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.CourseId, objvcc_CourseExamPaperRelationship_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.CourseName, objvcc_CourseExamPaperRelationship_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.QuestionID, objvcc_CourseExamPaperRelationship_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship.QuestionIndex, objvcc_CourseExamPaperRelationship_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.QuestionName, objvcc_CourseExamPaperRelationship_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.QuestionContent) == true)
{
string strComparisonOp_QuestionContent = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.QuestionContent, objvcc_CourseExamPaperRelationship_Cond.QuestionContent, strComparisonOp_QuestionContent);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.ExamAnswer) == true)
{
string strComparisonOp_ExamAnswer = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.ExamAnswer];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.ExamAnswer, objvcc_CourseExamPaperRelationship_Cond.ExamAnswer, strComparisonOp_ExamAnswer);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.CourseChapterId, objvcc_CourseExamPaperRelationship_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.CourseChapterName, objvcc_CourseExamPaperRelationship_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.ParentNodeID, objvcc_CourseExamPaperRelationship_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.ParentNodeName, objvcc_CourseExamPaperRelationship_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.QuestionTypeId, objvcc_CourseExamPaperRelationship_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.QuestionTypeName, objvcc_CourseExamPaperRelationship_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.ExamGradeId) == true)
{
string strComparisonOp_ExamGradeId = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.ExamGradeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.ExamGradeId, objvcc_CourseExamPaperRelationship_Cond.ExamGradeId, strComparisonOp_ExamGradeId);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.ExamGradeName) == true)
{
string strComparisonOp_ExamGradeName = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.ExamGradeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.ExamGradeName, objvcc_CourseExamPaperRelationship_Cond.ExamGradeName, strComparisonOp_ExamGradeName);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.AnswerTypeId) == true)
{
string strComparisonOp_AnswerTypeId = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.AnswerTypeId, objvcc_CourseExamPaperRelationship_Cond.AnswerTypeId, strComparisonOp_AnswerTypeId);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.AnswerModeId) == true)
{
string strComparisonOp_AnswerModeId = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.AnswerModeId, objvcc_CourseExamPaperRelationship_Cond.AnswerModeId, strComparisonOp_AnswerModeId);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo) == true)
{
if (objvcc_CourseExamPaperRelationship_Cond.IsHaveAdditionalMemo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo);
}
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.QuestionScore) == true)
{
string strComparisonOp_QuestionScore = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionScore];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship.QuestionScore, objvcc_CourseExamPaperRelationship_Cond.QuestionScore, strComparisonOp_QuestionScore);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.QuestionName_Add) == true)
{
string strComparisonOp_QuestionName_Add = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.QuestionName_Add];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.QuestionName_Add, objvcc_CourseExamPaperRelationship_Cond.QuestionName_Add, strComparisonOp_QuestionName_Add);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.DefaultValue) == true)
{
string strComparisonOp_DefaultValue = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.DefaultValue, objvcc_CourseExamPaperRelationship_Cond.DefaultValue, strComparisonOp_DefaultValue);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.TextDirectId) == true)
{
string strComparisonOp_TextDirectId = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.TextDirectId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.TextDirectId, objvcc_CourseExamPaperRelationship_Cond.TextDirectId, strComparisonOp_TextDirectId);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.FillInTextWidth) == true)
{
string strComparisonOp_FillInTextWidth = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.FillInTextWidth];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship.FillInTextWidth, objvcc_CourseExamPaperRelationship_Cond.FillInTextWidth, strComparisonOp_FillInTextWidth);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.MemoTextWidth) == true)
{
string strComparisonOp_MemoTextWidth = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.MemoTextWidth];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship.MemoTextWidth, objvcc_CourseExamPaperRelationship_Cond.MemoTextWidth, strComparisonOp_MemoTextWidth);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.CodeTab) == true)
{
string strComparisonOp_CodeTab = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CodeTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.CodeTab, objvcc_CourseExamPaperRelationship_Cond.CodeTab, strComparisonOp_CodeTab);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.CodeTab_Code) == true)
{
string strComparisonOp_CodeTab_Code = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CodeTab_Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.CodeTab_Code, objvcc_CourseExamPaperRelationship_Cond.CodeTab_Code, strComparisonOp_CodeTab_Code);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.CodeTab_Name) == true)
{
string strComparisonOp_CodeTab_Name = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CodeTab_Name];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.CodeTab_Name, objvcc_CourseExamPaperRelationship_Cond.CodeTab_Name, strComparisonOp_CodeTab_Name);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.CodeTab_Condition) == true)
{
string strComparisonOp_CodeTab_Condition = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CodeTab_Condition];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.CodeTab_Condition, objvcc_CourseExamPaperRelationship_Cond.CodeTab_Condition, strComparisonOp_CodeTab_Condition);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.RelaEvent) == true)
{
string strComparisonOp_RelaEvent = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.RelaEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.RelaEvent, objvcc_CourseExamPaperRelationship_Cond.RelaEvent, strComparisonOp_RelaEvent);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.FirstIndent) == true)
{
if (objvcc_CourseExamPaperRelationship_Cond.FirstIndent == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseExamPaperRelationship.FirstIndent);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseExamPaperRelationship.FirstIndent);
}
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.DefaultSelectItem) == true)
{
string strComparisonOp_DefaultSelectItem = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.DefaultSelectItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.DefaultSelectItem, objvcc_CourseExamPaperRelationship_Cond.DefaultSelectItem, strComparisonOp_DefaultSelectItem);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.FillInTextHeight) == true)
{
string strComparisonOp_FillInTextHeight = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.FillInTextHeight];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship.FillInTextHeight, objvcc_CourseExamPaperRelationship_Cond.FillInTextHeight, strComparisonOp_FillInTextHeight);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.IsMulti4FillInText) == true)
{
if (objvcc_CourseExamPaperRelationship_Cond.IsMulti4FillInText == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseExamPaperRelationship.IsMulti4FillInText);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseExamPaperRelationship.IsMulti4FillInText);
}
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.CheckBoxLimitCount) == true)
{
string strComparisonOp_CheckBoxLimitCount = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.CheckBoxLimitCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship.CheckBoxLimitCount, objvcc_CourseExamPaperRelationship_Cond.CheckBoxLimitCount, strComparisonOp_CheckBoxLimitCount);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.IsEffective) == true)
{
if (objvcc_CourseExamPaperRelationship_Cond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseExamPaperRelationship.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseExamPaperRelationship.IsEffective);
}
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.UserId) == true)
{
string strComparisonOp_UserId = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.UserId, objvcc_CourseExamPaperRelationship_Cond.UserId, strComparisonOp_UserId);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.StartTime) == true)
{
string strComparisonOp_StartTime = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.StartTime];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship.StartTime, objvcc_CourseExamPaperRelationship_Cond.StartTime, strComparisonOp_StartTime);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.PapersBigTopicId) == true)
{
string strComparisonOp_PapersBigTopicId = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.PapersBigTopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.PapersBigTopicId, objvcc_CourseExamPaperRelationship_Cond.PapersBigTopicId, strComparisonOp_PapersBigTopicId);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.PapersBigTopicName) == true)
{
string strComparisonOp_PapersBigTopicName = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.PapersBigTopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.PapersBigTopicName, objvcc_CourseExamPaperRelationship_Cond.PapersBigTopicName, strComparisonOp_PapersBigTopicName);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.TopicDescription) == true)
{
string strComparisonOp_TopicDescription = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.TopicDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.TopicDescription, objvcc_CourseExamPaperRelationship_Cond.TopicDescription, strComparisonOp_TopicDescription);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.TopicScores) == true)
{
string strComparisonOp_TopicScores = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.TopicScores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship.TopicScores, objvcc_CourseExamPaperRelationship_Cond.TopicScores, strComparisonOp_TopicScores);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.TopicOrderNum) == true)
{
string strComparisonOp_TopicOrderNum = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.TopicOrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship.TopicOrderNum, objvcc_CourseExamPaperRelationship_Cond.TopicOrderNum, strComparisonOp_TopicOrderNum);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaperRelationship.OrderNum, objvcc_CourseExamPaperRelationship_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.UpdDate, objvcc_CourseExamPaperRelationship_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_CourseExamPaperRelationship_Cond.IsUpdated(convcc_CourseExamPaperRelationship.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvcc_CourseExamPaperRelationship_Cond.dicFldComparisonOp[convcc_CourseExamPaperRelationship.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaperRelationship.UpdUser, objvcc_CourseExamPaperRelationship_Cond.UpdUser, strComparisonOp_UpdUser);
}
 return strWhereCond;
}
}
 /// <summary>
 /// 题目与试卷关系(vcc_CourseExamPaperRelationship)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseExamPaperRelationshipWApi
{
private static readonly string mstrApiControllerName = "vcc_CourseExamPaperRelationshipApi";

 public clsvcc_CourseExamPaperRelationshipWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseExamPaperRelationshipEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_CourseExamPaperRelationshipEN = JsonConvert.DeserializeObject<clsvcc_CourseExamPaperRelationshipEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseExamPaperRelationshipEN;
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
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseExamPaperRelationshipEN GetObjBymId_WA_Cache(long lngmId, string strCourseId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString(),
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_CourseExamPaperRelationshipEN = JsonConvert.DeserializeObject<clsvcc_CourseExamPaperRelationshipEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseExamPaperRelationshipEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvcc_CourseExamPaperRelationshipEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = null;
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
objvcc_CourseExamPaperRelationshipEN = JsonConvert.DeserializeObject<clsvcc_CourseExamPaperRelationshipEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseExamPaperRelationshipEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseExamPaperRelationshipEN GetObjBymId_Cache(long lngmId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperRelationshipEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseExamPaperRelationshipEN> arrvcc_CourseExamPaperRelationshipObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_CourseExamPaperRelationshipEN> arrvcc_CourseExamPaperRelationshipObjLst_Sel =
from objvcc_CourseExamPaperRelationshipEN in arrvcc_CourseExamPaperRelationshipObjLst_Cache
where objvcc_CourseExamPaperRelationshipEN.mId == lngmId
select objvcc_CourseExamPaperRelationshipEN;
if (arrvcc_CourseExamPaperRelationshipObjLst_Sel.Count() == 0)
{
   clsvcc_CourseExamPaperRelationshipEN obj = clsvcc_CourseExamPaperRelationshipWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_CourseExamPaperRelationshipObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseExamPaperRelationshipEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_CourseExamPaperRelationshipEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExamPaperRelationshipEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseExamPaperRelationshipEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvcc_CourseExamPaperRelationshipEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExamPaperRelationshipEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_CourseExamPaperRelationshipEN> GetObjLstByMIdLst_Cache(List<long> arrMId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperRelationshipEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseExamPaperRelationshipEN> arrvcc_CourseExamPaperRelationshipObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_CourseExamPaperRelationshipEN> arrvcc_CourseExamPaperRelationshipObjLst_Sel =
from objvcc_CourseExamPaperRelationshipEN in arrvcc_CourseExamPaperRelationshipObjLst_Cache
where arrMId.Contains(objvcc_CourseExamPaperRelationshipEN.mId)
select objvcc_CourseExamPaperRelationshipEN;
return arrvcc_CourseExamPaperRelationshipObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseExamPaperRelationshipEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId, string strCourseId)
{
 List<clsvcc_CourseExamPaperRelationshipEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExamPaperRelationshipEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseExamPaperRelationshipEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_CourseExamPaperRelationshipEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExamPaperRelationshipEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseExamPaperRelationshipEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_CourseExamPaperRelationshipEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExamPaperRelationshipEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseExamPaperRelationshipEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseExamPaperRelationshipEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExamPaperRelationshipEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseExamPaperRelationshipEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseExamPaperRelationshipEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExamPaperRelationshipEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
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
objvcc_CourseExamPaperRelationshipENT.QuestionID = objvcc_CourseExamPaperRelationshipENS.QuestionID; //题目ID
objvcc_CourseExamPaperRelationshipENT.QuestionIndex = objvcc_CourseExamPaperRelationshipENS.QuestionIndex; //题目序号
objvcc_CourseExamPaperRelationshipENT.QuestionName = objvcc_CourseExamPaperRelationshipENS.QuestionName; //题目名称
objvcc_CourseExamPaperRelationshipENT.QuestionContent = objvcc_CourseExamPaperRelationshipENS.QuestionContent; //题目内容
objvcc_CourseExamPaperRelationshipENT.ExamAnswer = objvcc_CourseExamPaperRelationshipENS.ExamAnswer; //题目答案
objvcc_CourseExamPaperRelationshipENT.CourseChapterId = objvcc_CourseExamPaperRelationshipENS.CourseChapterId; //课程章节ID
objvcc_CourseExamPaperRelationshipENT.CourseChapterName = objvcc_CourseExamPaperRelationshipENS.CourseChapterName; //课程章节名称
objvcc_CourseExamPaperRelationshipENT.ParentNodeID = objvcc_CourseExamPaperRelationshipENS.ParentNodeID; //父节点编号
objvcc_CourseExamPaperRelationshipENT.ParentNodeName = objvcc_CourseExamPaperRelationshipENS.ParentNodeName; //父节点名称
objvcc_CourseExamPaperRelationshipENT.QuestionTypeId = objvcc_CourseExamPaperRelationshipENS.QuestionTypeId; //题目类型Id
objvcc_CourseExamPaperRelationshipENT.QuestionTypeName = objvcc_CourseExamPaperRelationshipENS.QuestionTypeName; //题目类型名
objvcc_CourseExamPaperRelationshipENT.ExamGradeId = objvcc_CourseExamPaperRelationshipENS.ExamGradeId; //题库等级ID
objvcc_CourseExamPaperRelationshipENT.ExamGradeName = objvcc_CourseExamPaperRelationshipENS.ExamGradeName; //题库等级名
objvcc_CourseExamPaperRelationshipENT.AnswerTypeId = objvcc_CourseExamPaperRelationshipENS.AnswerTypeId; //答案类型ID
objvcc_CourseExamPaperRelationshipENT.AnswerModeId = objvcc_CourseExamPaperRelationshipENS.AnswerModeId; //答案模式Id
objvcc_CourseExamPaperRelationshipENT.IsHaveAdditionalMemo = objvcc_CourseExamPaperRelationshipENS.IsHaveAdditionalMemo; //是否有附加说明
objvcc_CourseExamPaperRelationshipENT.QuestionScore = objvcc_CourseExamPaperRelationshipENS.QuestionScore; //题目得分
objvcc_CourseExamPaperRelationshipENT.QuestionName_Add = objvcc_CourseExamPaperRelationshipENS.QuestionName_Add; //题目补充
objvcc_CourseExamPaperRelationshipENT.DefaultValue = objvcc_CourseExamPaperRelationshipENS.DefaultValue; //缺省值
objvcc_CourseExamPaperRelationshipENT.TextDirectId = objvcc_CourseExamPaperRelationshipENS.TextDirectId; //文本方向ID
objvcc_CourseExamPaperRelationshipENT.FillInTextWidth = objvcc_CourseExamPaperRelationshipENS.FillInTextWidth; //填空框宽度
objvcc_CourseExamPaperRelationshipENT.MemoTextWidth = objvcc_CourseExamPaperRelationshipENS.MemoTextWidth; //备注框宽度
objvcc_CourseExamPaperRelationshipENT.CodeTab = objvcc_CourseExamPaperRelationshipENS.CodeTab; //代码表
objvcc_CourseExamPaperRelationshipENT.CodeTab_Code = objvcc_CourseExamPaperRelationshipENS.CodeTab_Code; //CodeTab_Code
objvcc_CourseExamPaperRelationshipENT.CodeTab_Name = objvcc_CourseExamPaperRelationshipENS.CodeTab_Name; //CodeTab_Name
objvcc_CourseExamPaperRelationshipENT.CodeTab_Condition = objvcc_CourseExamPaperRelationshipENS.CodeTab_Condition; //代码表_条件
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
public static DataTable ToDataTable(List<clsvcc_CourseExamPaperRelationshipEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_CourseExamPaperRelationshipEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_CourseExamPaperRelationshipEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_CourseExamPaperRelationshipEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_CourseExamPaperRelationshipEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_CourseExamPaperRelationshipEN.AttributeName)
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
if (clscc_CourseExamPaperWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperWApi没有刷新缓存机制(clscc_CourseExamPaperWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseExamPaperRelationshipWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperRelationshipWApi没有刷新缓存机制(clscc_CourseExamPaperRelationshipWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_PapersBigTopicWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PapersBigTopicWApi没有刷新缓存机制(clscc_PapersBigTopicWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionnaireWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireWApi没有刷新缓存机制(clsQuestionnaireWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerModeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerModeWApi没有刷新缓存机制(clsAnswerModeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerTypeWApi没有刷新缓存机制(clsAnswerTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeWApi没有刷新缓存机制(clsQuestionTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamGradeWApi没有刷新缓存机制(clscc_ExamGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionType4CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionType4CourseWApi没有刷新缓存机制(clsQuestionType4CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvcc_CourseExamPaperRelationshipObjLst_Cache == null)
//{
//arrvcc_CourseExamPaperRelationshipObjLst_Cache = await clsvcc_CourseExamPaperRelationshipWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperRelationshipEN._CurrTabName_S, strCourseId);
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
public static List<clsvcc_CourseExamPaperRelationshipEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperRelationshipEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseExamPaperRelationshipEN> arrvcc_CourseExamPaperRelationshipObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvcc_CourseExamPaperRelationshipObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_CourseExamPaperRelationshipEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_CourseExamPaperRelationship.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.ExamPaperName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.QuestionContent, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.ExamAnswer, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.ExamGradeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.ExamGradeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.AnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.AnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.QuestionScore, Type.GetType("System.Single"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.QuestionName_Add, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.TextDirectId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.FillInTextWidth, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.MemoTextWidth, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.CodeTab, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.CodeTab_Code, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.CodeTab_Name, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.CodeTab_Condition, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.RelaEvent, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.FirstIndent, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.DefaultSelectItem, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.FillInTextHeight, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.IsMulti4FillInText, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.CheckBoxLimitCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.IsEffective, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.StartTime, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.PapersBigTopicId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.PapersBigTopicName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.TopicDescription, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.TopicScores, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.TopicOrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaperRelationship.UpdUser, Type.GetType("System.String"));
foreach (clsvcc_CourseExamPaperRelationshipEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_CourseExamPaperRelationship.mId] = objInFor[convcc_CourseExamPaperRelationship.mId];
objDR[convcc_CourseExamPaperRelationship.CourseExamPaperId] = objInFor[convcc_CourseExamPaperRelationship.CourseExamPaperId];
objDR[convcc_CourseExamPaperRelationship.ExamPaperName] = objInFor[convcc_CourseExamPaperRelationship.ExamPaperName];
objDR[convcc_CourseExamPaperRelationship.CourseId] = objInFor[convcc_CourseExamPaperRelationship.CourseId];
objDR[convcc_CourseExamPaperRelationship.CourseName] = objInFor[convcc_CourseExamPaperRelationship.CourseName];
objDR[convcc_CourseExamPaperRelationship.QuestionID] = objInFor[convcc_CourseExamPaperRelationship.QuestionID];
objDR[convcc_CourseExamPaperRelationship.QuestionIndex] = objInFor[convcc_CourseExamPaperRelationship.QuestionIndex];
objDR[convcc_CourseExamPaperRelationship.QuestionName] = objInFor[convcc_CourseExamPaperRelationship.QuestionName];
objDR[convcc_CourseExamPaperRelationship.QuestionContent] = objInFor[convcc_CourseExamPaperRelationship.QuestionContent];
objDR[convcc_CourseExamPaperRelationship.ExamAnswer] = objInFor[convcc_CourseExamPaperRelationship.ExamAnswer];
objDR[convcc_CourseExamPaperRelationship.CourseChapterId] = objInFor[convcc_CourseExamPaperRelationship.CourseChapterId];
objDR[convcc_CourseExamPaperRelationship.CourseChapterName] = objInFor[convcc_CourseExamPaperRelationship.CourseChapterName];
objDR[convcc_CourseExamPaperRelationship.ParentNodeID] = objInFor[convcc_CourseExamPaperRelationship.ParentNodeID];
objDR[convcc_CourseExamPaperRelationship.ParentNodeName] = objInFor[convcc_CourseExamPaperRelationship.ParentNodeName];
objDR[convcc_CourseExamPaperRelationship.QuestionTypeId] = objInFor[convcc_CourseExamPaperRelationship.QuestionTypeId];
objDR[convcc_CourseExamPaperRelationship.QuestionTypeName] = objInFor[convcc_CourseExamPaperRelationship.QuestionTypeName];
objDR[convcc_CourseExamPaperRelationship.ExamGradeId] = objInFor[convcc_CourseExamPaperRelationship.ExamGradeId];
objDR[convcc_CourseExamPaperRelationship.ExamGradeName] = objInFor[convcc_CourseExamPaperRelationship.ExamGradeName];
objDR[convcc_CourseExamPaperRelationship.AnswerTypeId] = objInFor[convcc_CourseExamPaperRelationship.AnswerTypeId];
objDR[convcc_CourseExamPaperRelationship.AnswerModeId] = objInFor[convcc_CourseExamPaperRelationship.AnswerModeId];
objDR[convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo] = objInFor[convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo];
objDR[convcc_CourseExamPaperRelationship.QuestionScore] = objInFor[convcc_CourseExamPaperRelationship.QuestionScore];
objDR[convcc_CourseExamPaperRelationship.QuestionName_Add] = objInFor[convcc_CourseExamPaperRelationship.QuestionName_Add];
objDR[convcc_CourseExamPaperRelationship.DefaultValue] = objInFor[convcc_CourseExamPaperRelationship.DefaultValue];
objDR[convcc_CourseExamPaperRelationship.TextDirectId] = objInFor[convcc_CourseExamPaperRelationship.TextDirectId];
objDR[convcc_CourseExamPaperRelationship.FillInTextWidth] = objInFor[convcc_CourseExamPaperRelationship.FillInTextWidth];
objDR[convcc_CourseExamPaperRelationship.MemoTextWidth] = objInFor[convcc_CourseExamPaperRelationship.MemoTextWidth];
objDR[convcc_CourseExamPaperRelationship.CodeTab] = objInFor[convcc_CourseExamPaperRelationship.CodeTab];
objDR[convcc_CourseExamPaperRelationship.CodeTab_Code] = objInFor[convcc_CourseExamPaperRelationship.CodeTab_Code];
objDR[convcc_CourseExamPaperRelationship.CodeTab_Name] = objInFor[convcc_CourseExamPaperRelationship.CodeTab_Name];
objDR[convcc_CourseExamPaperRelationship.CodeTab_Condition] = objInFor[convcc_CourseExamPaperRelationship.CodeTab_Condition];
objDR[convcc_CourseExamPaperRelationship.RelaEvent] = objInFor[convcc_CourseExamPaperRelationship.RelaEvent];
objDR[convcc_CourseExamPaperRelationship.FirstIndent] = objInFor[convcc_CourseExamPaperRelationship.FirstIndent];
objDR[convcc_CourseExamPaperRelationship.DefaultSelectItem] = objInFor[convcc_CourseExamPaperRelationship.DefaultSelectItem];
objDR[convcc_CourseExamPaperRelationship.FillInTextHeight] = objInFor[convcc_CourseExamPaperRelationship.FillInTextHeight];
objDR[convcc_CourseExamPaperRelationship.IsMulti4FillInText] = objInFor[convcc_CourseExamPaperRelationship.IsMulti4FillInText];
objDR[convcc_CourseExamPaperRelationship.CheckBoxLimitCount] = objInFor[convcc_CourseExamPaperRelationship.CheckBoxLimitCount];
objDR[convcc_CourseExamPaperRelationship.IsEffective] = objInFor[convcc_CourseExamPaperRelationship.IsEffective];
objDR[convcc_CourseExamPaperRelationship.UserId] = objInFor[convcc_CourseExamPaperRelationship.UserId];
objDR[convcc_CourseExamPaperRelationship.StartTime] = objInFor[convcc_CourseExamPaperRelationship.StartTime];
objDR[convcc_CourseExamPaperRelationship.PapersBigTopicId] = objInFor[convcc_CourseExamPaperRelationship.PapersBigTopicId];
objDR[convcc_CourseExamPaperRelationship.PapersBigTopicName] = objInFor[convcc_CourseExamPaperRelationship.PapersBigTopicName];
objDR[convcc_CourseExamPaperRelationship.TopicDescription] = objInFor[convcc_CourseExamPaperRelationship.TopicDescription];
objDR[convcc_CourseExamPaperRelationship.TopicScores] = objInFor[convcc_CourseExamPaperRelationship.TopicScores];
objDR[convcc_CourseExamPaperRelationship.TopicOrderNum] = objInFor[convcc_CourseExamPaperRelationship.TopicOrderNum];
objDR[convcc_CourseExamPaperRelationship.OrderNum] = objInFor[convcc_CourseExamPaperRelationship.OrderNum];
objDR[convcc_CourseExamPaperRelationship.UpdDate] = objInFor[convcc_CourseExamPaperRelationship.UpdDate];
objDR[convcc_CourseExamPaperRelationship.UpdUser] = objInFor[convcc_CourseExamPaperRelationship.UpdUser];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}