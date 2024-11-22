
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkEduClsRela4AppWApi
 表名:vcc_WorkEduClsRela4App(01120253)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:06
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
public static class clsvcc_WorkEduClsRela4AppWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN SetId_WorkEduClsRela(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, long lngId_WorkEduClsRela, string strComparisonOp="")
	{
objvcc_WorkEduClsRela4AppEN.Id_WorkEduClsRela = lngId_WorkEduClsRela; //作业教学班关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.Id_WorkEduClsRela) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.Id_WorkEduClsRela, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.Id_WorkEduClsRela] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN SetQuestionID(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convcc_WorkEduClsRela4App.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convcc_WorkEduClsRela4App.QuestionID);
objvcc_WorkEduClsRela4AppEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.QuestionID) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.QuestionID, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.QuestionID] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN SetQuestionIndex(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, int intQuestionIndex, string strComparisonOp="")
	{
objvcc_WorkEduClsRela4AppEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.QuestionIndex) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.QuestionIndex, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.QuestionIndex] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN SetQuestionName(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convcc_WorkEduClsRela4App.QuestionName);
objvcc_WorkEduClsRela4AppEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.QuestionName) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.QuestionName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.QuestionName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN SetCourseId(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_WorkEduClsRela4App.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_WorkEduClsRela4App.CourseId);
objvcc_WorkEduClsRela4AppEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.CourseId) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.CourseId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.CourseId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN SetCourseName(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_WorkEduClsRela4App.CourseName);
objvcc_WorkEduClsRela4AppEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.CourseName) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.CourseName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.CourseName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN SetCourseChapterId(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_WorkEduClsRela4App.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_WorkEduClsRela4App.CourseChapterId);
objvcc_WorkEduClsRela4AppEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.CourseChapterId) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.CourseChapterId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.CourseChapterId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN SetChapterName(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_WorkEduClsRela4App.ChapterName);
objvcc_WorkEduClsRela4AppEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.ChapterName) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.ChapterName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.ChapterName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN SetSectionName(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_WorkEduClsRela4App.SectionName);
objvcc_WorkEduClsRela4AppEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.SectionName) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.SectionName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.SectionName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN SetChapterName_Sim(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convcc_WorkEduClsRela4App.ChapterName_Sim);
objvcc_WorkEduClsRela4AppEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.ChapterName_Sim) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.ChapterName_Sim, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.ChapterName_Sim] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN SetSectionName_Sim(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convcc_WorkEduClsRela4App.SectionName_Sim);
objvcc_WorkEduClsRela4AppEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.SectionName_Sim) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.SectionName_Sim, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.SectionName_Sim] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN SetQuestionTypeId(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convcc_WorkEduClsRela4App.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convcc_WorkEduClsRela4App.QuestionTypeId);
objvcc_WorkEduClsRela4AppEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.QuestionTypeId) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.QuestionTypeId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.QuestionTypeId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN SetQuestionTypeName(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convcc_WorkEduClsRela4App.QuestionTypeName);
objvcc_WorkEduClsRela4AppEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.QuestionTypeName) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.QuestionTypeName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.QuestionTypeName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN SetExamGradeName(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, string strExamGradeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamGradeName, 50, convcc_WorkEduClsRela4App.ExamGradeName);
objvcc_WorkEduClsRela4AppEN.ExamGradeName = strExamGradeName; //题库等级名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.ExamGradeName) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.ExamGradeName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.ExamGradeName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN Setid_CurrEduCls(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, convcc_WorkEduClsRela4App.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convcc_WorkEduClsRela4App.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convcc_WorkEduClsRela4App.id_CurrEduCls);
objvcc_WorkEduClsRela4AppEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.id_CurrEduCls) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.id_CurrEduCls, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.id_CurrEduCls] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN SetEduClsName(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convcc_WorkEduClsRela4App.EduClsName);
objvcc_WorkEduClsRela4AppEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.EduClsName) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.EduClsName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.EduClsName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN SetScores(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, double dblScores, string strComparisonOp="")
	{
objvcc_WorkEduClsRela4AppEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.Scores) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.Scores, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.Scores] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN SetTeacherID(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherID, convcc_WorkEduClsRela4App.TeacherID);
clsCheckSql.CheckFieldLen(strTeacherID, 12, convcc_WorkEduClsRela4App.TeacherID);
objvcc_WorkEduClsRela4AppEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.TeacherID) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.TeacherID, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.TeacherID] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN SetIsPublish(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, bool bolIsPublish, string strComparisonOp="")
	{
objvcc_WorkEduClsRela4AppEN.IsPublish = bolIsPublish; //是否发布
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.IsPublish) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.IsPublish, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.IsPublish] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN SetPubDate(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, string strPubDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubDate, 14, convcc_WorkEduClsRela4App.PubDate);
objvcc_WorkEduClsRela4AppEN.PubDate = strPubDate; //发布日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.PubDate) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.PubDate, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.PubDate] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN SetSpecifyCompletionDate(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, string strSpecifyCompletionDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSpecifyCompletionDate, 14, convcc_WorkEduClsRela4App.SpecifyCompletionDate);
objvcc_WorkEduClsRela4AppEN.SpecifyCompletionDate = strSpecifyCompletionDate; //指定完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.SpecifyCompletionDate) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.SpecifyCompletionDate, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.SpecifyCompletionDate] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN SetUpdDate(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_WorkEduClsRela4App.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_WorkEduClsRela4App.UpdDate);
objvcc_WorkEduClsRela4AppEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.UpdDate) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.UpdDate, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.UpdDate] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN SetUpdUserId(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_WorkEduClsRela4App.UpdUserId);
objvcc_WorkEduClsRela4AppEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.UpdUserId) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.UpdUserId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.UpdUserId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRela4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRela4AppEN SetMemo(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_WorkEduClsRela4App.Memo);
objvcc_WorkEduClsRela4AppEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela4App.Memo) == false)
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela4App.Memo, strComparisonOp);
}
else
{
objvcc_WorkEduClsRela4AppEN.dicFldComparisonOp[convcc_WorkEduClsRela4App.Memo] = strComparisonOp;
}
}
return objvcc_WorkEduClsRela4AppEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4App_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.Id_WorkEduClsRela) == true)
{
string strComparisonOp_Id_WorkEduClsRela = objvcc_WorkEduClsRela4App_Cond.dicFldComparisonOp[convcc_WorkEduClsRela4App.Id_WorkEduClsRela];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkEduClsRela4App.Id_WorkEduClsRela, objvcc_WorkEduClsRela4App_Cond.Id_WorkEduClsRela, strComparisonOp_Id_WorkEduClsRela);
}
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvcc_WorkEduClsRela4App_Cond.dicFldComparisonOp[convcc_WorkEduClsRela4App.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela4App.QuestionID, objvcc_WorkEduClsRela4App_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objvcc_WorkEduClsRela4App_Cond.dicFldComparisonOp[convcc_WorkEduClsRela4App.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkEduClsRela4App.QuestionIndex, objvcc_WorkEduClsRela4App_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvcc_WorkEduClsRela4App_Cond.dicFldComparisonOp[convcc_WorkEduClsRela4App.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela4App.QuestionName, objvcc_WorkEduClsRela4App_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_WorkEduClsRela4App_Cond.dicFldComparisonOp[convcc_WorkEduClsRela4App.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela4App.CourseId, objvcc_WorkEduClsRela4App_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_WorkEduClsRela4App_Cond.dicFldComparisonOp[convcc_WorkEduClsRela4App.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela4App.CourseName, objvcc_WorkEduClsRela4App_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvcc_WorkEduClsRela4App_Cond.dicFldComparisonOp[convcc_WorkEduClsRela4App.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela4App.CourseChapterId, objvcc_WorkEduClsRela4App_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvcc_WorkEduClsRela4App_Cond.dicFldComparisonOp[convcc_WorkEduClsRela4App.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela4App.ChapterName, objvcc_WorkEduClsRela4App_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.SectionName) == true)
{
string strComparisonOp_SectionName = objvcc_WorkEduClsRela4App_Cond.dicFldComparisonOp[convcc_WorkEduClsRela4App.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela4App.SectionName, objvcc_WorkEduClsRela4App_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvcc_WorkEduClsRela4App_Cond.dicFldComparisonOp[convcc_WorkEduClsRela4App.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela4App.ChapterName_Sim, objvcc_WorkEduClsRela4App_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvcc_WorkEduClsRela4App_Cond.dicFldComparisonOp[convcc_WorkEduClsRela4App.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela4App.SectionName_Sim, objvcc_WorkEduClsRela4App_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvcc_WorkEduClsRela4App_Cond.dicFldComparisonOp[convcc_WorkEduClsRela4App.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela4App.QuestionTypeId, objvcc_WorkEduClsRela4App_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvcc_WorkEduClsRela4App_Cond.dicFldComparisonOp[convcc_WorkEduClsRela4App.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela4App.QuestionTypeName, objvcc_WorkEduClsRela4App_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.ExamGradeName) == true)
{
string strComparisonOp_ExamGradeName = objvcc_WorkEduClsRela4App_Cond.dicFldComparisonOp[convcc_WorkEduClsRela4App.ExamGradeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela4App.ExamGradeName, objvcc_WorkEduClsRela4App_Cond.ExamGradeName, strComparisonOp_ExamGradeName);
}
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvcc_WorkEduClsRela4App_Cond.dicFldComparisonOp[convcc_WorkEduClsRela4App.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela4App.id_CurrEduCls, objvcc_WorkEduClsRela4App_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvcc_WorkEduClsRela4App_Cond.dicFldComparisonOp[convcc_WorkEduClsRela4App.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela4App.EduClsName, objvcc_WorkEduClsRela4App_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.Scores) == true)
{
string strComparisonOp_Scores = objvcc_WorkEduClsRela4App_Cond.dicFldComparisonOp[convcc_WorkEduClsRela4App.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkEduClsRela4App.Scores, objvcc_WorkEduClsRela4App_Cond.Scores, strComparisonOp_Scores);
}
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvcc_WorkEduClsRela4App_Cond.dicFldComparisonOp[convcc_WorkEduClsRela4App.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela4App.TeacherID, objvcc_WorkEduClsRela4App_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.IsPublish) == true)
{
if (objvcc_WorkEduClsRela4App_Cond.IsPublish == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkEduClsRela4App.IsPublish);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkEduClsRela4App.IsPublish);
}
}
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.PubDate) == true)
{
string strComparisonOp_PubDate = objvcc_WorkEduClsRela4App_Cond.dicFldComparisonOp[convcc_WorkEduClsRela4App.PubDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela4App.PubDate, objvcc_WorkEduClsRela4App_Cond.PubDate, strComparisonOp_PubDate);
}
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.SpecifyCompletionDate) == true)
{
string strComparisonOp_SpecifyCompletionDate = objvcc_WorkEduClsRela4App_Cond.dicFldComparisonOp[convcc_WorkEduClsRela4App.SpecifyCompletionDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela4App.SpecifyCompletionDate, objvcc_WorkEduClsRela4App_Cond.SpecifyCompletionDate, strComparisonOp_SpecifyCompletionDate);
}
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_WorkEduClsRela4App_Cond.dicFldComparisonOp[convcc_WorkEduClsRela4App.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela4App.UpdDate, objvcc_WorkEduClsRela4App_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvcc_WorkEduClsRela4App_Cond.dicFldComparisonOp[convcc_WorkEduClsRela4App.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela4App.UpdUserId, objvcc_WorkEduClsRela4App_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvcc_WorkEduClsRela4App_Cond.IsUpdated(convcc_WorkEduClsRela4App.Memo) == true)
{
string strComparisonOp_Memo = objvcc_WorkEduClsRela4App_Cond.dicFldComparisonOp[convcc_WorkEduClsRela4App.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela4App.Memo, objvcc_WorkEduClsRela4App_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vcc_WorkEduClsRela4App(vcc_WorkEduClsRela4App)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_WorkEduClsRela4AppWApi
{
private static readonly string mstrApiControllerName = "vcc_WorkEduClsRela4AppApi";

 public clsvcc_WorkEduClsRela4AppWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_WorkEduClsRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkEduClsRela4AppEN GetObjById_WorkEduClsRela(long lngId_WorkEduClsRela)
{
string strAction = "GetObjById_WorkEduClsRela";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkEduClsRela"] = lngId_WorkEduClsRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_WorkEduClsRela4AppEN = JsonConvert.DeserializeObject<clsvcc_WorkEduClsRela4AppEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkEduClsRela4AppEN;
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
 /// <param name = "lngId_WorkEduClsRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkEduClsRela4AppEN GetObjById_WorkEduClsRela_WA_Cache(long lngId_WorkEduClsRela)
{
string strAction = "GetObjById_WorkEduClsRela_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkEduClsRela"] = lngId_WorkEduClsRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_WorkEduClsRela4AppEN = JsonConvert.DeserializeObject<clsvcc_WorkEduClsRela4AppEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkEduClsRela4AppEN;
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
public static clsvcc_WorkEduClsRela4AppEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppEN = null;
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
objvcc_WorkEduClsRela4AppEN = JsonConvert.DeserializeObject<clsvcc_WorkEduClsRela4AppEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkEduClsRela4AppEN;
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
 /// <param name = "lngId_WorkEduClsRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkEduClsRela4AppEN GetObjById_WorkEduClsRela_Cache(long lngId_WorkEduClsRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_WorkEduClsRela4AppEN._CurrTabName_S);
List<clsvcc_WorkEduClsRela4AppEN> arrvcc_WorkEduClsRela4AppObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_WorkEduClsRela4AppEN> arrvcc_WorkEduClsRela4AppObjLst_Sel =
from objvcc_WorkEduClsRela4AppEN in arrvcc_WorkEduClsRela4AppObjLst_Cache
where objvcc_WorkEduClsRela4AppEN.Id_WorkEduClsRela == lngId_WorkEduClsRela
select objvcc_WorkEduClsRela4AppEN;
if (arrvcc_WorkEduClsRela4AppObjLst_Sel.Count() == 0)
{
   clsvcc_WorkEduClsRela4AppEN obj = clsvcc_WorkEduClsRela4AppWApi.GetObjById_WorkEduClsRela(lngId_WorkEduClsRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_WorkEduClsRela4AppObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkEduClsRela4AppEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_WorkEduClsRela4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkEduClsRela4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkEduClsRela4AppEN> GetObjLstById_WorkEduClsRelaLst(List<long> arrId_WorkEduClsRela)
{
 List<clsvcc_WorkEduClsRela4AppEN> arrObjLst = null; 
string strAction = "GetObjLstById_WorkEduClsRelaLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WorkEduClsRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkEduClsRela4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngId_WorkEduClsRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_WorkEduClsRela4AppEN> GetObjLstById_WorkEduClsRelaLst_Cache(List<long> arrId_WorkEduClsRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_WorkEduClsRela4AppEN._CurrTabName_S);
List<clsvcc_WorkEduClsRela4AppEN> arrvcc_WorkEduClsRela4AppObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_WorkEduClsRela4AppEN> arrvcc_WorkEduClsRela4AppObjLst_Sel =
from objvcc_WorkEduClsRela4AppEN in arrvcc_WorkEduClsRela4AppObjLst_Cache
where arrId_WorkEduClsRela.Contains(objvcc_WorkEduClsRela4AppEN.Id_WorkEduClsRela)
select objvcc_WorkEduClsRela4AppEN;
return arrvcc_WorkEduClsRela4AppObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkEduClsRela4AppEN> GetObjLstById_WorkEduClsRelaLst_WA_Cache(List<long> arrId_WorkEduClsRela)
{
 List<clsvcc_WorkEduClsRela4AppEN> arrObjLst = null; 
string strAction = "GetObjLstById_WorkEduClsRelaLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WorkEduClsRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkEduClsRela4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkEduClsRela4AppEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_WorkEduClsRela4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkEduClsRela4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkEduClsRela4AppEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_WorkEduClsRela4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkEduClsRela4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkEduClsRela4AppEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkEduClsRela4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkEduClsRela4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkEduClsRela4AppEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkEduClsRela4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkEduClsRela4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngId_WorkEduClsRela)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkEduClsRela"] = lngId_WorkEduClsRela.ToString()
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
 /// <param name = "objvcc_WorkEduClsRela4AppENS">源对象</param>
 /// <param name = "objvcc_WorkEduClsRela4AppENT">目标对象</param>
 public static void CopyTo(clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppENS, clsvcc_WorkEduClsRela4AppEN objvcc_WorkEduClsRela4AppENT)
{
try
{
objvcc_WorkEduClsRela4AppENT.Id_WorkEduClsRela = objvcc_WorkEduClsRela4AppENS.Id_WorkEduClsRela; //作业教学班关系流水号
objvcc_WorkEduClsRela4AppENT.QuestionID = objvcc_WorkEduClsRela4AppENS.QuestionID; //题目ID
objvcc_WorkEduClsRela4AppENT.QuestionIndex = objvcc_WorkEduClsRela4AppENS.QuestionIndex; //题目序号
objvcc_WorkEduClsRela4AppENT.QuestionName = objvcc_WorkEduClsRela4AppENS.QuestionName; //题目名称
objvcc_WorkEduClsRela4AppENT.CourseId = objvcc_WorkEduClsRela4AppENS.CourseId; //课程Id
objvcc_WorkEduClsRela4AppENT.CourseName = objvcc_WorkEduClsRela4AppENS.CourseName; //课程名称
objvcc_WorkEduClsRela4AppENT.CourseChapterId = objvcc_WorkEduClsRela4AppENS.CourseChapterId; //课程章节ID
objvcc_WorkEduClsRela4AppENT.ChapterName = objvcc_WorkEduClsRela4AppENS.ChapterName; //章名
objvcc_WorkEduClsRela4AppENT.SectionName = objvcc_WorkEduClsRela4AppENS.SectionName; //节名
objvcc_WorkEduClsRela4AppENT.ChapterName_Sim = objvcc_WorkEduClsRela4AppENS.ChapterName_Sim; //章名简称
objvcc_WorkEduClsRela4AppENT.SectionName_Sim = objvcc_WorkEduClsRela4AppENS.SectionName_Sim; //节名简称
objvcc_WorkEduClsRela4AppENT.QuestionTypeId = objvcc_WorkEduClsRela4AppENS.QuestionTypeId; //题目类型Id
objvcc_WorkEduClsRela4AppENT.QuestionTypeName = objvcc_WorkEduClsRela4AppENS.QuestionTypeName; //题目类型名
objvcc_WorkEduClsRela4AppENT.ExamGradeName = objvcc_WorkEduClsRela4AppENS.ExamGradeName; //题库等级名
objvcc_WorkEduClsRela4AppENT.id_CurrEduCls = objvcc_WorkEduClsRela4AppENS.id_CurrEduCls; //当前教学班流水号
objvcc_WorkEduClsRela4AppENT.EduClsName = objvcc_WorkEduClsRela4AppENS.EduClsName; //教学班名称
objvcc_WorkEduClsRela4AppENT.Scores = objvcc_WorkEduClsRela4AppENS.Scores; //分值
objvcc_WorkEduClsRela4AppENT.TeacherID = objvcc_WorkEduClsRela4AppENS.TeacherID; //教师工号
objvcc_WorkEduClsRela4AppENT.IsPublish = objvcc_WorkEduClsRela4AppENS.IsPublish; //是否发布
objvcc_WorkEduClsRela4AppENT.PubDate = objvcc_WorkEduClsRela4AppENS.PubDate; //发布日期
objvcc_WorkEduClsRela4AppENT.SpecifyCompletionDate = objvcc_WorkEduClsRela4AppENS.SpecifyCompletionDate; //指定完成日期
objvcc_WorkEduClsRela4AppENT.UpdDate = objvcc_WorkEduClsRela4AppENS.UpdDate; //修改日期
objvcc_WorkEduClsRela4AppENT.UpdUserId = objvcc_WorkEduClsRela4AppENS.UpdUserId; //修改用户Id
objvcc_WorkEduClsRela4AppENT.Memo = objvcc_WorkEduClsRela4AppENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvcc_WorkEduClsRela4AppEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_WorkEduClsRela4AppEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_WorkEduClsRela4AppEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_WorkEduClsRela4AppEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_WorkEduClsRela4AppEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_WorkEduClsRela4AppEN.AttributeName)
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
if (clsCurrEduClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsWApi没有刷新缓存机制(clsCurrEduClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_WorkEduClsRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkEduClsRelaWApi没有刷新缓存机制(clscc_WorkEduClsRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by Id_WorkEduClsRela");
//if (arrvcc_WorkEduClsRela4AppObjLst_Cache == null)
//{
//arrvcc_WorkEduClsRela4AppObjLst_Cache = await clsvcc_WorkEduClsRela4AppWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvcc_WorkEduClsRela4AppEN._CurrTabName_S);
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
public static List<clsvcc_WorkEduClsRela4AppEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcc_WorkEduClsRela4AppEN._CurrTabName_S);
List<clsvcc_WorkEduClsRela4AppEN> arrvcc_WorkEduClsRela4AppObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_WorkEduClsRela4AppObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_WorkEduClsRela4AppEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_WorkEduClsRela4App.Id_WorkEduClsRela, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_WorkEduClsRela4App.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela4App.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkEduClsRela4App.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela4App.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela4App.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela4App.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela4App.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela4App.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela4App.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela4App.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela4App.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela4App.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela4App.ExamGradeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela4App.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela4App.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela4App.Scores, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_WorkEduClsRela4App.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela4App.IsPublish, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkEduClsRela4App.PubDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela4App.SpecifyCompletionDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela4App.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela4App.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela4App.Memo, Type.GetType("System.String"));
foreach (clsvcc_WorkEduClsRela4AppEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_WorkEduClsRela4App.Id_WorkEduClsRela] = objInFor[convcc_WorkEduClsRela4App.Id_WorkEduClsRela];
objDR[convcc_WorkEduClsRela4App.QuestionID] = objInFor[convcc_WorkEduClsRela4App.QuestionID];
objDR[convcc_WorkEduClsRela4App.QuestionIndex] = objInFor[convcc_WorkEduClsRela4App.QuestionIndex];
objDR[convcc_WorkEduClsRela4App.QuestionName] = objInFor[convcc_WorkEduClsRela4App.QuestionName];
objDR[convcc_WorkEduClsRela4App.CourseId] = objInFor[convcc_WorkEduClsRela4App.CourseId];
objDR[convcc_WorkEduClsRela4App.CourseName] = objInFor[convcc_WorkEduClsRela4App.CourseName];
objDR[convcc_WorkEduClsRela4App.CourseChapterId] = objInFor[convcc_WorkEduClsRela4App.CourseChapterId];
objDR[convcc_WorkEduClsRela4App.ChapterName] = objInFor[convcc_WorkEduClsRela4App.ChapterName];
objDR[convcc_WorkEduClsRela4App.SectionName] = objInFor[convcc_WorkEduClsRela4App.SectionName];
objDR[convcc_WorkEduClsRela4App.ChapterName_Sim] = objInFor[convcc_WorkEduClsRela4App.ChapterName_Sim];
objDR[convcc_WorkEduClsRela4App.SectionName_Sim] = objInFor[convcc_WorkEduClsRela4App.SectionName_Sim];
objDR[convcc_WorkEduClsRela4App.QuestionTypeId] = objInFor[convcc_WorkEduClsRela4App.QuestionTypeId];
objDR[convcc_WorkEduClsRela4App.QuestionTypeName] = objInFor[convcc_WorkEduClsRela4App.QuestionTypeName];
objDR[convcc_WorkEduClsRela4App.ExamGradeName] = objInFor[convcc_WorkEduClsRela4App.ExamGradeName];
objDR[convcc_WorkEduClsRela4App.id_CurrEduCls] = objInFor[convcc_WorkEduClsRela4App.id_CurrEduCls];
objDR[convcc_WorkEduClsRela4App.EduClsName] = objInFor[convcc_WorkEduClsRela4App.EduClsName];
objDR[convcc_WorkEduClsRela4App.Scores] = objInFor[convcc_WorkEduClsRela4App.Scores];
objDR[convcc_WorkEduClsRela4App.TeacherID] = objInFor[convcc_WorkEduClsRela4App.TeacherID];
objDR[convcc_WorkEduClsRela4App.IsPublish] = objInFor[convcc_WorkEduClsRela4App.IsPublish];
objDR[convcc_WorkEduClsRela4App.PubDate] = objInFor[convcc_WorkEduClsRela4App.PubDate];
objDR[convcc_WorkEduClsRela4App.SpecifyCompletionDate] = objInFor[convcc_WorkEduClsRela4App.SpecifyCompletionDate];
objDR[convcc_WorkEduClsRela4App.UpdDate] = objInFor[convcc_WorkEduClsRela4App.UpdDate];
objDR[convcc_WorkEduClsRela4App.UpdUserId] = objInFor[convcc_WorkEduClsRela4App.UpdUserId];
objDR[convcc_WorkEduClsRela4App.Memo] = objInFor[convcc_WorkEduClsRela4App.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}