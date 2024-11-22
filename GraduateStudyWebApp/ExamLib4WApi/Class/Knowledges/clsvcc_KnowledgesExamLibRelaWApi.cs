
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_KnowledgesExamLibRelaWApi
 表名:vcc_KnowledgesExamLibRela(01120142)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:13
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
public static class clsvcc_KnowledgesExamLibRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetmId(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, long lngmId, string strComparisonOp="")
	{
objvcc_KnowledgesExamLibRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.mId) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.mId, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.mId] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetQuestionID(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionID, convcc_KnowledgesExamLibRela.QuestionID);
clsCheckSql.CheckFieldLen(strQuestionID, 8, convcc_KnowledgesExamLibRela.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convcc_KnowledgesExamLibRela.QuestionID);
objvcc_KnowledgesExamLibRelaEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.QuestionID) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.QuestionID, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.QuestionID] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetQuestionIndex(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, int intQuestionIndex, string strComparisonOp="")
	{
objvcc_KnowledgesExamLibRelaEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.QuestionIndex) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.QuestionIndex, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.QuestionIndex] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetQuestionName(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convcc_KnowledgesExamLibRela.QuestionName);
objvcc_KnowledgesExamLibRelaEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.QuestionName) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.QuestionName, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.QuestionName] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetQuestionContent(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strQuestionContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, convcc_KnowledgesExamLibRela.QuestionContent);
objvcc_KnowledgesExamLibRelaEN.QuestionContent = strQuestionContent; //题目内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.QuestionContent) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.QuestionContent, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.QuestionContent] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetChapterName_Sim(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convcc_KnowledgesExamLibRela.ChapterName_Sim);
objvcc_KnowledgesExamLibRelaEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.ChapterName_Sim) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.ChapterName_Sim, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.ChapterName_Sim] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetSectionName_Sim(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convcc_KnowledgesExamLibRela.SectionName_Sim);
objvcc_KnowledgesExamLibRelaEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.SectionName_Sim) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.SectionName_Sim, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.SectionName_Sim] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetCourseId(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_KnowledgesExamLibRela.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_KnowledgesExamLibRela.CourseId);
objvcc_KnowledgesExamLibRelaEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.CourseId) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.CourseId, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.CourseId] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetPositiveCorrelation(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, double dblPositiveCorrelation, string strComparisonOp="")
	{
objvcc_KnowledgesExamLibRelaEN.PositiveCorrelation = dblPositiveCorrelation; //正相关度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.PositiveCorrelation) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.PositiveCorrelation, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.PositiveCorrelation] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetCourseKnowledgeId(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strCourseKnowledgeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseKnowledgeId, convcc_KnowledgesExamLibRela.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(strCourseKnowledgeId, 8, convcc_KnowledgesExamLibRela.CourseKnowledgeId);
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeId, 8, convcc_KnowledgesExamLibRela.CourseKnowledgeId);
objvcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = strCourseKnowledgeId; //知识点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.CourseKnowledgeId) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.CourseKnowledgeId, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.CourseKnowledgeId] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetKnowledgeName(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strKnowledgeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKnowledgeName, convcc_KnowledgesExamLibRela.KnowledgeName);
clsCheckSql.CheckFieldLen(strKnowledgeName, 100, convcc_KnowledgesExamLibRela.KnowledgeName);
objvcc_KnowledgesExamLibRelaEN.KnowledgeName = strKnowledgeName; //知识点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.KnowledgeName) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.KnowledgeName, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.KnowledgeName] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetKnowledgeTitle(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strKnowledgeTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKnowledgeTitle, 100, convcc_KnowledgesExamLibRela.KnowledgeTitle);
objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle = strKnowledgeTitle; //知识点标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.KnowledgeTitle) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.KnowledgeTitle, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.KnowledgeTitle] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetKnowledgeContent(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strKnowledgeContent, string strComparisonOp="")
	{
objvcc_KnowledgesExamLibRelaEN.KnowledgeContent = strKnowledgeContent; //知识点内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.KnowledgeContent) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.KnowledgeContent, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.KnowledgeContent] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetCourseName(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_KnowledgesExamLibRela.CourseName);
objvcc_KnowledgesExamLibRelaEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.CourseName) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.CourseName, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.CourseName] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetCourseChapterId(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convcc_KnowledgesExamLibRela.CourseChapterId);
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_KnowledgesExamLibRela.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_KnowledgesExamLibRela.CourseChapterId);
objvcc_KnowledgesExamLibRelaEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.CourseChapterId) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.CourseChapterId, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.CourseChapterId] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetChapterId(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, convcc_KnowledgesExamLibRela.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convcc_KnowledgesExamLibRela.ChapterId);
objvcc_KnowledgesExamLibRelaEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.ChapterId) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.ChapterId, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.ChapterId] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetNegativeCorrelation(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, double dblNegativeCorrelation, string strComparisonOp="")
	{
objvcc_KnowledgesExamLibRelaEN.NegativeCorrelation = dblNegativeCorrelation; //负相关度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.NegativeCorrelation) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.NegativeCorrelation, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.NegativeCorrelation] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetUpdDate(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_KnowledgesExamLibRela.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_KnowledgesExamLibRela.UpdDate);
objvcc_KnowledgesExamLibRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.UpdDate) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.UpdDate, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.UpdDate] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetUpdUserId(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_KnowledgesExamLibRela.UpdUserId);
objvcc_KnowledgesExamLibRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.UpdUserId) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.UpdUserId, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.UpdUserId] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetMemo(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_KnowledgesExamLibRela.Memo);
objvcc_KnowledgesExamLibRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.Memo) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.Memo, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.Memo] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetChapterName_Sim4Question(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strChapterName_Sim4Question, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim4Question, 10, convcc_KnowledgesExamLibRela.ChapterName_Sim4Question);
objvcc_KnowledgesExamLibRelaEN.ChapterName_Sim4Question = strChapterName_Sim4Question; //ChapterName_Sim4Question
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.ChapterName_Sim4Question) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.ChapterName_Sim4Question, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.ChapterName_Sim4Question] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetSectionName_Sim4Question(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strSectionName_Sim4Question, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim4Question, 10, convcc_KnowledgesExamLibRela.SectionName_Sim4Question);
objvcc_KnowledgesExamLibRelaEN.SectionName_Sim4Question = strSectionName_Sim4Question; //SectionName_Sim4Question
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.SectionName_Sim4Question) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.SectionName_Sim4Question, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.SectionName_Sim4Question] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRela_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_KnowledgesExamLibRela_Cond.IsUpdated(convcc_KnowledgesExamLibRela.mId) == true)
{
string strComparisonOp_mId = objvcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_KnowledgesExamLibRela.mId, objvcc_KnowledgesExamLibRela_Cond.mId, strComparisonOp_mId);
}
if (objvcc_KnowledgesExamLibRela_Cond.IsUpdated(convcc_KnowledgesExamLibRela.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.QuestionID, objvcc_KnowledgesExamLibRela_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvcc_KnowledgesExamLibRela_Cond.IsUpdated(convcc_KnowledgesExamLibRela.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objvcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_KnowledgesExamLibRela.QuestionIndex, objvcc_KnowledgesExamLibRela_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objvcc_KnowledgesExamLibRela_Cond.IsUpdated(convcc_KnowledgesExamLibRela.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.QuestionName, objvcc_KnowledgesExamLibRela_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvcc_KnowledgesExamLibRela_Cond.IsUpdated(convcc_KnowledgesExamLibRela.QuestionContent) == true)
{
string strComparisonOp_QuestionContent = objvcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.QuestionContent, objvcc_KnowledgesExamLibRela_Cond.QuestionContent, strComparisonOp_QuestionContent);
}
if (objvcc_KnowledgesExamLibRela_Cond.IsUpdated(convcc_KnowledgesExamLibRela.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.ChapterName_Sim, objvcc_KnowledgesExamLibRela_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvcc_KnowledgesExamLibRela_Cond.IsUpdated(convcc_KnowledgesExamLibRela.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.SectionName_Sim, objvcc_KnowledgesExamLibRela_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvcc_KnowledgesExamLibRela_Cond.IsUpdated(convcc_KnowledgesExamLibRela.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.CourseId, objvcc_KnowledgesExamLibRela_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_KnowledgesExamLibRela_Cond.IsUpdated(convcc_KnowledgesExamLibRela.PositiveCorrelation) == true)
{
string strComparisonOp_PositiveCorrelation = objvcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.PositiveCorrelation];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_KnowledgesExamLibRela.PositiveCorrelation, objvcc_KnowledgesExamLibRela_Cond.PositiveCorrelation, strComparisonOp_PositiveCorrelation);
}
if (objvcc_KnowledgesExamLibRela_Cond.IsUpdated(convcc_KnowledgesExamLibRela.CourseKnowledgeId) == true)
{
string strComparisonOp_CourseKnowledgeId = objvcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.CourseKnowledgeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.CourseKnowledgeId, objvcc_KnowledgesExamLibRela_Cond.CourseKnowledgeId, strComparisonOp_CourseKnowledgeId);
}
if (objvcc_KnowledgesExamLibRela_Cond.IsUpdated(convcc_KnowledgesExamLibRela.KnowledgeName) == true)
{
string strComparisonOp_KnowledgeName = objvcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.KnowledgeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.KnowledgeName, objvcc_KnowledgesExamLibRela_Cond.KnowledgeName, strComparisonOp_KnowledgeName);
}
if (objvcc_KnowledgesExamLibRela_Cond.IsUpdated(convcc_KnowledgesExamLibRela.KnowledgeTitle) == true)
{
string strComparisonOp_KnowledgeTitle = objvcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.KnowledgeTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.KnowledgeTitle, objvcc_KnowledgesExamLibRela_Cond.KnowledgeTitle, strComparisonOp_KnowledgeTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvcc_KnowledgesExamLibRela_Cond.IsUpdated(convcc_KnowledgesExamLibRela.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.CourseName, objvcc_KnowledgesExamLibRela_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_KnowledgesExamLibRela_Cond.IsUpdated(convcc_KnowledgesExamLibRela.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.CourseChapterId, objvcc_KnowledgesExamLibRela_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvcc_KnowledgesExamLibRela_Cond.IsUpdated(convcc_KnowledgesExamLibRela.ChapterId) == true)
{
string strComparisonOp_ChapterId = objvcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.ChapterId, objvcc_KnowledgesExamLibRela_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objvcc_KnowledgesExamLibRela_Cond.IsUpdated(convcc_KnowledgesExamLibRela.NegativeCorrelation) == true)
{
string strComparisonOp_NegativeCorrelation = objvcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.NegativeCorrelation];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_KnowledgesExamLibRela.NegativeCorrelation, objvcc_KnowledgesExamLibRela_Cond.NegativeCorrelation, strComparisonOp_NegativeCorrelation);
}
if (objvcc_KnowledgesExamLibRela_Cond.IsUpdated(convcc_KnowledgesExamLibRela.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.UpdDate, objvcc_KnowledgesExamLibRela_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_KnowledgesExamLibRela_Cond.IsUpdated(convcc_KnowledgesExamLibRela.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.UpdUserId, objvcc_KnowledgesExamLibRela_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvcc_KnowledgesExamLibRela_Cond.IsUpdated(convcc_KnowledgesExamLibRela.Memo) == true)
{
string strComparisonOp_Memo = objvcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.Memo, objvcc_KnowledgesExamLibRela_Cond.Memo, strComparisonOp_Memo);
}
if (objvcc_KnowledgesExamLibRela_Cond.IsUpdated(convcc_KnowledgesExamLibRela.ChapterName_Sim4Question) == true)
{
string strComparisonOp_ChapterName_Sim4Question = objvcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.ChapterName_Sim4Question];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.ChapterName_Sim4Question, objvcc_KnowledgesExamLibRela_Cond.ChapterName_Sim4Question, strComparisonOp_ChapterName_Sim4Question);
}
if (objvcc_KnowledgesExamLibRela_Cond.IsUpdated(convcc_KnowledgesExamLibRela.SectionName_Sim4Question) == true)
{
string strComparisonOp_SectionName_Sim4Question = objvcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.SectionName_Sim4Question];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.SectionName_Sim4Question, objvcc_KnowledgesExamLibRela_Cond.SectionName_Sim4Question, strComparisonOp_SectionName_Sim4Question);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v知识点习题关系(vcc_KnowledgesExamLibRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_KnowledgesExamLibRelaWApi
{
private static readonly string mstrApiControllerName = "vcc_KnowledgesExamLibRelaApi";

 public clsvcc_KnowledgesExamLibRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_KnowledgesExamLibRelaEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = null;
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
objvcc_KnowledgesExamLibRelaEN = JsonConvert.DeserializeObject<clsvcc_KnowledgesExamLibRelaEN>((string)jobjReturn["ReturnObj"]);
return objvcc_KnowledgesExamLibRelaEN;
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
public static clsvcc_KnowledgesExamLibRelaEN GetObjBymId_WA_Cache(long lngmId, string strCourseId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = null;
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
objvcc_KnowledgesExamLibRelaEN = JsonConvert.DeserializeObject<clsvcc_KnowledgesExamLibRelaEN>((string)jobjReturn["ReturnObj"]);
return objvcc_KnowledgesExamLibRelaEN;
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
public static clsvcc_KnowledgesExamLibRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = null;
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
objvcc_KnowledgesExamLibRelaEN = JsonConvert.DeserializeObject<clsvcc_KnowledgesExamLibRelaEN>((string)jobjReturn["ReturnObj"]);
return objvcc_KnowledgesExamLibRelaEN;
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
public static clsvcc_KnowledgesExamLibRelaEN GetObjBymId_Cache(long lngmId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_KnowledgesExamLibRelaEN._CurrTabName_S, strCourseId);
List<clsvcc_KnowledgesExamLibRelaEN> arrvcc_KnowledgesExamLibRelaObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_KnowledgesExamLibRelaEN> arrvcc_KnowledgesExamLibRelaObjLst_Sel =
from objvcc_KnowledgesExamLibRelaEN in arrvcc_KnowledgesExamLibRelaObjLst_Cache
where objvcc_KnowledgesExamLibRelaEN.mId == lngmId
select objvcc_KnowledgesExamLibRelaEN;
if (arrvcc_KnowledgesExamLibRelaObjLst_Sel.Count() == 0)
{
   clsvcc_KnowledgesExamLibRelaEN obj = clsvcc_KnowledgesExamLibRelaWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_KnowledgesExamLibRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_KnowledgesExamLibRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_KnowledgesExamLibRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_KnowledgesExamLibRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_KnowledgesExamLibRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvcc_KnowledgesExamLibRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_KnowledgesExamLibRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvcc_KnowledgesExamLibRelaEN> GetObjLstByMIdLst_Cache(List<long> arrMId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_KnowledgesExamLibRelaEN._CurrTabName_S, strCourseId);
List<clsvcc_KnowledgesExamLibRelaEN> arrvcc_KnowledgesExamLibRelaObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_KnowledgesExamLibRelaEN> arrvcc_KnowledgesExamLibRelaObjLst_Sel =
from objvcc_KnowledgesExamLibRelaEN in arrvcc_KnowledgesExamLibRelaObjLst_Cache
where arrMId.Contains(objvcc_KnowledgesExamLibRelaEN.mId)
select objvcc_KnowledgesExamLibRelaEN;
return arrvcc_KnowledgesExamLibRelaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_KnowledgesExamLibRelaEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId, string strCourseId)
{
 List<clsvcc_KnowledgesExamLibRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_KnowledgesExamLibRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_KnowledgesExamLibRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_KnowledgesExamLibRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_KnowledgesExamLibRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_KnowledgesExamLibRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_KnowledgesExamLibRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_KnowledgesExamLibRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_KnowledgesExamLibRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_KnowledgesExamLibRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_KnowledgesExamLibRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_KnowledgesExamLibRelaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_KnowledgesExamLibRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_KnowledgesExamLibRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvcc_KnowledgesExamLibRelaENS">源对象</param>
 /// <param name = "objvcc_KnowledgesExamLibRelaENT">目标对象</param>
 public static void CopyTo(clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaENS, clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaENT)
{
try
{
objvcc_KnowledgesExamLibRelaENT.mId = objvcc_KnowledgesExamLibRelaENS.mId; //mId
objvcc_KnowledgesExamLibRelaENT.QuestionID = objvcc_KnowledgesExamLibRelaENS.QuestionID; //题目ID
objvcc_KnowledgesExamLibRelaENT.QuestionIndex = objvcc_KnowledgesExamLibRelaENS.QuestionIndex; //题目序号
objvcc_KnowledgesExamLibRelaENT.QuestionName = objvcc_KnowledgesExamLibRelaENS.QuestionName; //题目名称
objvcc_KnowledgesExamLibRelaENT.QuestionContent = objvcc_KnowledgesExamLibRelaENS.QuestionContent; //题目内容
objvcc_KnowledgesExamLibRelaENT.ChapterName_Sim = objvcc_KnowledgesExamLibRelaENS.ChapterName_Sim; //章名简称
objvcc_KnowledgesExamLibRelaENT.SectionName_Sim = objvcc_KnowledgesExamLibRelaENS.SectionName_Sim; //节名简称
objvcc_KnowledgesExamLibRelaENT.CourseId = objvcc_KnowledgesExamLibRelaENS.CourseId; //课程Id
objvcc_KnowledgesExamLibRelaENT.PositiveCorrelation = objvcc_KnowledgesExamLibRelaENS.PositiveCorrelation; //正相关度
objvcc_KnowledgesExamLibRelaENT.CourseKnowledgeId = objvcc_KnowledgesExamLibRelaENS.CourseKnowledgeId; //知识点Id
objvcc_KnowledgesExamLibRelaENT.KnowledgeName = objvcc_KnowledgesExamLibRelaENS.KnowledgeName; //知识点名称
objvcc_KnowledgesExamLibRelaENT.KnowledgeTitle = objvcc_KnowledgesExamLibRelaENS.KnowledgeTitle; //知识点标题
objvcc_KnowledgesExamLibRelaENT.KnowledgeContent = objvcc_KnowledgesExamLibRelaENS.KnowledgeContent; //知识点内容
objvcc_KnowledgesExamLibRelaENT.CourseName = objvcc_KnowledgesExamLibRelaENS.CourseName; //课程名称
objvcc_KnowledgesExamLibRelaENT.CourseChapterId = objvcc_KnowledgesExamLibRelaENS.CourseChapterId; //课程章节ID
objvcc_KnowledgesExamLibRelaENT.ChapterId = objvcc_KnowledgesExamLibRelaENS.ChapterId; //章Id
objvcc_KnowledgesExamLibRelaENT.NegativeCorrelation = objvcc_KnowledgesExamLibRelaENS.NegativeCorrelation; //负相关度
objvcc_KnowledgesExamLibRelaENT.UpdDate = objvcc_KnowledgesExamLibRelaENS.UpdDate; //修改日期
objvcc_KnowledgesExamLibRelaENT.UpdUserId = objvcc_KnowledgesExamLibRelaENS.UpdUserId; //修改用户Id
objvcc_KnowledgesExamLibRelaENT.Memo = objvcc_KnowledgesExamLibRelaENS.Memo; //备注
objvcc_KnowledgesExamLibRelaENT.ChapterName_Sim4Question = objvcc_KnowledgesExamLibRelaENS.ChapterName_Sim4Question; //ChapterName_Sim4Question
objvcc_KnowledgesExamLibRelaENT.SectionName_Sim4Question = objvcc_KnowledgesExamLibRelaENS.SectionName_Sim4Question; //SectionName_Sim4Question
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
public static DataTable ToDataTable(List<clsvcc_KnowledgesExamLibRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_KnowledgesExamLibRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_KnowledgesExamLibRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_KnowledgesExamLibRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_KnowledgesExamLibRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_KnowledgesExamLibRelaEN.AttributeName)
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
if (clscc_KnowledgesExamLibRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_KnowledgesExamLibRelaWApi没有刷新缓存机制(clscc_KnowledgesExamLibRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvcc_KnowledgesExamLibRelaObjLst_Cache == null)
//{
//arrvcc_KnowledgesExamLibRelaObjLst_Cache = await clsvcc_KnowledgesExamLibRelaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvcc_KnowledgesExamLibRelaEN._CurrTabName_S, strCourseId);
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
public static List<clsvcc_KnowledgesExamLibRelaEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_KnowledgesExamLibRelaEN._CurrTabName_S, strCourseId);
List<clsvcc_KnowledgesExamLibRelaEN> arrvcc_KnowledgesExamLibRelaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvcc_KnowledgesExamLibRelaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_KnowledgesExamLibRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_KnowledgesExamLibRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_KnowledgesExamLibRela.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_KnowledgesExamLibRela.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_KnowledgesExamLibRela.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_KnowledgesExamLibRela.QuestionContent, Type.GetType("System.String"));
objDT.Columns.Add(convcc_KnowledgesExamLibRela.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_KnowledgesExamLibRela.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_KnowledgesExamLibRela.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_KnowledgesExamLibRela.PositiveCorrelation, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_KnowledgesExamLibRela.CourseKnowledgeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_KnowledgesExamLibRela.KnowledgeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_KnowledgesExamLibRela.KnowledgeTitle, Type.GetType("System.String"));
objDT.Columns.Add(convcc_KnowledgesExamLibRela.KnowledgeContent, Type.GetType("System.String"));
objDT.Columns.Add(convcc_KnowledgesExamLibRela.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_KnowledgesExamLibRela.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_KnowledgesExamLibRela.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_KnowledgesExamLibRela.NegativeCorrelation, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_KnowledgesExamLibRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_KnowledgesExamLibRela.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_KnowledgesExamLibRela.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_KnowledgesExamLibRela.ChapterName_Sim4Question, Type.GetType("System.String"));
objDT.Columns.Add(convcc_KnowledgesExamLibRela.SectionName_Sim4Question, Type.GetType("System.String"));
foreach (clsvcc_KnowledgesExamLibRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_KnowledgesExamLibRela.mId] = objInFor[convcc_KnowledgesExamLibRela.mId];
objDR[convcc_KnowledgesExamLibRela.QuestionID] = objInFor[convcc_KnowledgesExamLibRela.QuestionID];
objDR[convcc_KnowledgesExamLibRela.QuestionIndex] = objInFor[convcc_KnowledgesExamLibRela.QuestionIndex];
objDR[convcc_KnowledgesExamLibRela.QuestionName] = objInFor[convcc_KnowledgesExamLibRela.QuestionName];
objDR[convcc_KnowledgesExamLibRela.QuestionContent] = objInFor[convcc_KnowledgesExamLibRela.QuestionContent];
objDR[convcc_KnowledgesExamLibRela.ChapterName_Sim] = objInFor[convcc_KnowledgesExamLibRela.ChapterName_Sim];
objDR[convcc_KnowledgesExamLibRela.SectionName_Sim] = objInFor[convcc_KnowledgesExamLibRela.SectionName_Sim];
objDR[convcc_KnowledgesExamLibRela.CourseId] = objInFor[convcc_KnowledgesExamLibRela.CourseId];
objDR[convcc_KnowledgesExamLibRela.PositiveCorrelation] = objInFor[convcc_KnowledgesExamLibRela.PositiveCorrelation];
objDR[convcc_KnowledgesExamLibRela.CourseKnowledgeId] = objInFor[convcc_KnowledgesExamLibRela.CourseKnowledgeId];
objDR[convcc_KnowledgesExamLibRela.KnowledgeName] = objInFor[convcc_KnowledgesExamLibRela.KnowledgeName];
objDR[convcc_KnowledgesExamLibRela.KnowledgeTitle] = objInFor[convcc_KnowledgesExamLibRela.KnowledgeTitle];
objDR[convcc_KnowledgesExamLibRela.KnowledgeContent] = objInFor[convcc_KnowledgesExamLibRela.KnowledgeContent];
objDR[convcc_KnowledgesExamLibRela.CourseName] = objInFor[convcc_KnowledgesExamLibRela.CourseName];
objDR[convcc_KnowledgesExamLibRela.CourseChapterId] = objInFor[convcc_KnowledgesExamLibRela.CourseChapterId];
objDR[convcc_KnowledgesExamLibRela.ChapterId] = objInFor[convcc_KnowledgesExamLibRela.ChapterId];
objDR[convcc_KnowledgesExamLibRela.NegativeCorrelation] = objInFor[convcc_KnowledgesExamLibRela.NegativeCorrelation];
objDR[convcc_KnowledgesExamLibRela.UpdDate] = objInFor[convcc_KnowledgesExamLibRela.UpdDate];
objDR[convcc_KnowledgesExamLibRela.UpdUserId] = objInFor[convcc_KnowledgesExamLibRela.UpdUserId];
objDR[convcc_KnowledgesExamLibRela.Memo] = objInFor[convcc_KnowledgesExamLibRela.Memo];
objDR[convcc_KnowledgesExamLibRela.ChapterName_Sim4Question] = objInFor[convcc_KnowledgesExamLibRela.ChapterName_Sim4Question];
objDR[convcc_KnowledgesExamLibRela.SectionName_Sim4Question] = objInFor[convcc_KnowledgesExamLibRela.SectionName_Sim4Question];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}