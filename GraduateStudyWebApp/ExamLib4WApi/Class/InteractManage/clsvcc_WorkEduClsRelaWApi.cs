
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkEduClsRelaWApi
 表名:vcc_WorkEduClsRela(01120197)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:44
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
public static class clsvcc_WorkEduClsRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetId_WorkEduClsRela(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, long lngId_WorkEduClsRela, string strComparisonOp="")
	{
objvcc_WorkEduClsRelaEN.Id_WorkEduClsRela = lngId_WorkEduClsRela; //作业教学班关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.Id_WorkEduClsRela) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.Id_WorkEduClsRela, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.Id_WorkEduClsRela] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetQuestionID(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convcc_WorkEduClsRela.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convcc_WorkEduClsRela.QuestionID);
objvcc_WorkEduClsRelaEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.QuestionID) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.QuestionID, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionID] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetQuestionIndex(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, int intQuestionIndex, string strComparisonOp="")
	{
objvcc_WorkEduClsRelaEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.QuestionIndex) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.QuestionIndex, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionIndex] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetQuestionName(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convcc_WorkEduClsRela.QuestionName);
objvcc_WorkEduClsRelaEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.QuestionName) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.QuestionName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetQuestionContent(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strQuestionContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, convcc_WorkEduClsRela.QuestionContent);
objvcc_WorkEduClsRelaEN.QuestionContent = strQuestionContent; //题目内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.QuestionContent) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.QuestionContent, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionContent] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetCourseId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_WorkEduClsRela.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_WorkEduClsRela.CourseId);
objvcc_WorkEduClsRelaEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.CourseId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.CourseId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.CourseId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetCourseName(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_WorkEduClsRela.CourseName);
objvcc_WorkEduClsRelaEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.CourseName) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.CourseName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.CourseName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetCourseChapterId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_WorkEduClsRela.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_WorkEduClsRela.CourseChapterId);
objvcc_WorkEduClsRelaEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.CourseChapterId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.CourseChapterId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.CourseChapterId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetCourseChapterName(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_WorkEduClsRela.CourseChapterName);
objvcc_WorkEduClsRelaEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.CourseChapterName) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.CourseChapterName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.CourseChapterName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetChapterName(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_WorkEduClsRela.ChapterName);
objvcc_WorkEduClsRelaEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.ChapterName) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.ChapterName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.ChapterName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetSectionName(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_WorkEduClsRela.SectionName);
objvcc_WorkEduClsRelaEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.SectionName) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.SectionName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.SectionName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetChapterName_Sim(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convcc_WorkEduClsRela.ChapterName_Sim);
objvcc_WorkEduClsRelaEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.ChapterName_Sim) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.ChapterName_Sim, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.ChapterName_Sim] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetSectionName_Sim(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convcc_WorkEduClsRela.SectionName_Sim);
objvcc_WorkEduClsRelaEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.SectionName_Sim) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.SectionName_Sim, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.SectionName_Sim] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetParentNodeID(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convcc_WorkEduClsRela.ParentNodeID);
objvcc_WorkEduClsRelaEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.ParentNodeID) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.ParentNodeID, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.ParentNodeID] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetCourseChapterReferred(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strCourseChapterReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convcc_WorkEduClsRela.CourseChapterReferred);
objvcc_WorkEduClsRelaEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.CourseChapterReferred) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.CourseChapterReferred, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.CourseChapterReferred] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetParentNodeName(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convcc_WorkEduClsRela.ParentNodeName);
objvcc_WorkEduClsRelaEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.ParentNodeName) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.ParentNodeName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.ParentNodeName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetParentNodeReferred(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strParentNodeReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convcc_WorkEduClsRela.ParentNodeReferred);
objvcc_WorkEduClsRelaEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.ParentNodeReferred) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.ParentNodeReferred, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.ParentNodeReferred] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetQuestionTypeId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convcc_WorkEduClsRela.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convcc_WorkEduClsRela.QuestionTypeId);
objvcc_WorkEduClsRelaEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.QuestionTypeId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.QuestionTypeId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionTypeId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetQuestionTypeName(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convcc_WorkEduClsRela.QuestionTypeName);
objvcc_WorkEduClsRelaEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.QuestionTypeName) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.QuestionTypeName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionTypeName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetExamGradeId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strExamGradeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamGradeId, 2, convcc_WorkEduClsRela.ExamGradeId);
clsCheckSql.CheckFieldForeignKey(strExamGradeId, 2, convcc_WorkEduClsRela.ExamGradeId);
objvcc_WorkEduClsRelaEN.ExamGradeId = strExamGradeId; //题库等级ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.ExamGradeId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.ExamGradeId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.ExamGradeId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetExamGradeName(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strExamGradeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamGradeName, 50, convcc_WorkEduClsRela.ExamGradeName);
objvcc_WorkEduClsRelaEN.ExamGradeName = strExamGradeName; //题库等级名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.ExamGradeName) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.ExamGradeName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.ExamGradeName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetAnswerTypeId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convcc_WorkEduClsRela.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convcc_WorkEduClsRela.AnswerTypeId);
objvcc_WorkEduClsRelaEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.AnswerTypeId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.AnswerTypeId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.AnswerTypeId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetAnswerModeId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convcc_WorkEduClsRela.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convcc_WorkEduClsRela.AnswerModeId);
objvcc_WorkEduClsRelaEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.AnswerModeId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.AnswerModeId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.AnswerModeId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetDefaultValue(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convcc_WorkEduClsRela.DefaultValue);
objvcc_WorkEduClsRelaEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.DefaultValue) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.DefaultValue, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.DefaultValue] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetTextDirectId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strTextDirectId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTextDirectId, 4, convcc_WorkEduClsRela.TextDirectId);
clsCheckSql.CheckFieldForeignKey(strTextDirectId, 4, convcc_WorkEduClsRela.TextDirectId);
objvcc_WorkEduClsRelaEN.TextDirectId = strTextDirectId; //文本方向ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.TextDirectId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.TextDirectId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.TextDirectId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetRelaEvent(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strRelaEvent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaEvent, 4000, convcc_WorkEduClsRela.RelaEvent);
objvcc_WorkEduClsRelaEN.RelaEvent = strRelaEvent; //相关事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.RelaEvent) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.RelaEvent, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.RelaEvent] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetCheckBoxLimitCount(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, int intCheckBoxLimitCount, string strComparisonOp="")
	{
objvcc_WorkEduClsRelaEN.CheckBoxLimitCount = intCheckBoxLimitCount; //复选框限制数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.CheckBoxLimitCount) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.CheckBoxLimitCount, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.CheckBoxLimitCount] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetAnswerAttLimitSize(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, long lngAnswerAttLimitSize, string strComparisonOp="")
	{
objvcc_WorkEduClsRelaEN.AnswerAttLimitSize = lngAnswerAttLimitSize; //回答附件限制大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.AnswerAttLimitSize) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.AnswerAttLimitSize, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.AnswerAttLimitSize] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetLimitedResourceType(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strLimitedResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLimitedResourceType, 100, convcc_WorkEduClsRela.LimitedResourceType);
objvcc_WorkEduClsRelaEN.LimitedResourceType = strLimitedResourceType; //限制资源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.LimitedResourceType) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.LimitedResourceType, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.LimitedResourceType] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetQuestionTypeId4Course(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strQuestionTypeId4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId4Course, 8, convcc_WorkEduClsRela.QuestionTypeId4Course);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId4Course, 8, convcc_WorkEduClsRela.QuestionTypeId4Course);
objvcc_WorkEduClsRelaEN.QuestionTypeId4Course = strQuestionTypeId4Course; //题目类型Id4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.QuestionTypeId4Course) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.QuestionTypeId4Course, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionTypeId4Course] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetQuestionTypeName4Course(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strQuestionTypeName4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName4Course, 30, convcc_WorkEduClsRela.QuestionTypeName4Course);
objvcc_WorkEduClsRelaEN.QuestionTypeName4Course = strQuestionTypeName4Course; //题目类型名4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.QuestionTypeName4Course) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.QuestionTypeName4Course, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionTypeName4Course] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN Setid_CurrEduCls(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, convcc_WorkEduClsRela.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convcc_WorkEduClsRela.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convcc_WorkEduClsRela.id_CurrEduCls);
objvcc_WorkEduClsRelaEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.id_CurrEduCls) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.id_CurrEduCls, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.id_CurrEduCls] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetCurrEduClsId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convcc_WorkEduClsRela.CurrEduClsId);
objvcc_WorkEduClsRelaEN.CurrEduClsId = strCurrEduClsId; //当前教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.CurrEduClsId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.CurrEduClsId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.CurrEduClsId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetEduClsName(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convcc_WorkEduClsRela.EduClsName);
objvcc_WorkEduClsRelaEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.EduClsName) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.EduClsName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.EduClsName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetScores(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, double dblScores, string strComparisonOp="")
	{
objvcc_WorkEduClsRelaEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.Scores) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.Scores, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.Scores] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetTeacherID(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherID, convcc_WorkEduClsRela.TeacherID);
clsCheckSql.CheckFieldLen(strTeacherID, 12, convcc_WorkEduClsRela.TeacherID);
objvcc_WorkEduClsRelaEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.TeacherID) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.TeacherID, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.TeacherID] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetIsPublish(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, bool bolIsPublish, string strComparisonOp="")
	{
objvcc_WorkEduClsRelaEN.IsPublish = bolIsPublish; //是否发布
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.IsPublish) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.IsPublish, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.IsPublish] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetPubDate(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strPubDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubDate, convcc_WorkEduClsRela.PubDate);
clsCheckSql.CheckFieldLen(strPubDate, 14, convcc_WorkEduClsRela.PubDate);
objvcc_WorkEduClsRelaEN.PubDate = strPubDate; //发布日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.PubDate) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.PubDate, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.PubDate] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN Setpublisher(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strpublisher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strpublisher, 20, convcc_WorkEduClsRela.publisher);
objvcc_WorkEduClsRelaEN.publisher = strpublisher; //发布者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.publisher) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.publisher, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.publisher] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetSpecifyCompletionDate(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strSpecifyCompletionDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSpecifyCompletionDate, convcc_WorkEduClsRela.SpecifyCompletionDate);
clsCheckSql.CheckFieldLen(strSpecifyCompletionDate, 14, convcc_WorkEduClsRela.SpecifyCompletionDate);
objvcc_WorkEduClsRelaEN.SpecifyCompletionDate = strSpecifyCompletionDate; //指定完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.SpecifyCompletionDate) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.SpecifyCompletionDate, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.SpecifyCompletionDate] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetIsCurrEduCls(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, bool bolIsCurrEduCls, string strComparisonOp="")
	{
objvcc_WorkEduClsRelaEN.IsCurrEduCls = bolIsCurrEduCls; //是否为教学班作业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.IsCurrEduCls) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.IsCurrEduCls, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.IsCurrEduCls] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetIsGroupWork(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, bool bolIsGroupWork, string strComparisonOp="")
	{
objvcc_WorkEduClsRelaEN.IsGroupWork = bolIsGroupWork; //是否为小组作业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.IsGroupWork) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.IsGroupWork, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.IsGroupWork] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetCourseStudentGroupId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, long lngCourseStudentGroupId, string strComparisonOp="")
	{
objvcc_WorkEduClsRelaEN.CourseStudentGroupId = lngCourseStudentGroupId; //学生分组表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.CourseStudentGroupId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.CourseStudentGroupId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.CourseStudentGroupId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetWorkTypeId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strWorkTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkTypeId, convcc_WorkEduClsRela.WorkTypeId);
clsCheckSql.CheckFieldLen(strWorkTypeId, 2, convcc_WorkEduClsRela.WorkTypeId);
clsCheckSql.CheckFieldForeignKey(strWorkTypeId, 2, convcc_WorkEduClsRela.WorkTypeId);
objvcc_WorkEduClsRelaEN.WorkTypeId = strWorkTypeId; //作业类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.WorkTypeId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.WorkTypeId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.WorkTypeId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetWorkTypeName(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strWorkTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWorkTypeName, 30, convcc_WorkEduClsRela.WorkTypeName);
objvcc_WorkEduClsRelaEN.WorkTypeName = strWorkTypeName; //作业类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.WorkTypeName) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.WorkTypeName, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.WorkTypeName] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetUpdDate(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_WorkEduClsRela.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_WorkEduClsRela.UpdDate);
objvcc_WorkEduClsRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.UpdDate) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.UpdDate, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.UpdDate] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetUpdUserId(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_WorkEduClsRela.UpdUserId);
objvcc_WorkEduClsRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.UpdUserId) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.UpdUserId, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.UpdUserId] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetMemo(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_WorkEduClsRela.Memo);
objvcc_WorkEduClsRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.Memo) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.Memo, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.Memo] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetStuNum(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, int intStuNum, string strComparisonOp="")
	{
objvcc_WorkEduClsRelaEN.StuNum = intStuNum; //学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.StuNum) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.StuNum, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.StuNum] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkEduClsRelaEN SetEduClsStuNum(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN, int intEduClsStuNum, string strComparisonOp="")
	{
objvcc_WorkEduClsRelaEN.EduClsStuNum = intEduClsStuNum; //教学班学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkEduClsRelaEN.dicFldComparisonOp.ContainsKey(convcc_WorkEduClsRela.EduClsStuNum) == false)
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp.Add(convcc_WorkEduClsRela.EduClsStuNum, strComparisonOp);
}
else
{
objvcc_WorkEduClsRelaEN.dicFldComparisonOp[convcc_WorkEduClsRela.EduClsStuNum] = strComparisonOp;
}
}
return objvcc_WorkEduClsRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRela_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.Id_WorkEduClsRela) == true)
{
string strComparisonOp_Id_WorkEduClsRela = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.Id_WorkEduClsRela];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkEduClsRela.Id_WorkEduClsRela, objvcc_WorkEduClsRela_Cond.Id_WorkEduClsRela, strComparisonOp_Id_WorkEduClsRela);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.QuestionID, objvcc_WorkEduClsRela_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkEduClsRela.QuestionIndex, objvcc_WorkEduClsRela_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.QuestionName, objvcc_WorkEduClsRela_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.QuestionContent) == true)
{
string strComparisonOp_QuestionContent = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.QuestionContent, objvcc_WorkEduClsRela_Cond.QuestionContent, strComparisonOp_QuestionContent);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.CourseId, objvcc_WorkEduClsRela_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.CourseName, objvcc_WorkEduClsRela_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.CourseChapterId, objvcc_WorkEduClsRela_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.CourseChapterName, objvcc_WorkEduClsRela_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.ChapterName, objvcc_WorkEduClsRela_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.SectionName) == true)
{
string strComparisonOp_SectionName = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.SectionName, objvcc_WorkEduClsRela_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.ChapterName_Sim, objvcc_WorkEduClsRela_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.SectionName_Sim, objvcc_WorkEduClsRela_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.ParentNodeID, objvcc_WorkEduClsRela_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.CourseChapterReferred) == true)
{
string strComparisonOp_CourseChapterReferred = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.CourseChapterReferred, objvcc_WorkEduClsRela_Cond.CourseChapterReferred, strComparisonOp_CourseChapterReferred);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.ParentNodeName, objvcc_WorkEduClsRela_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.ParentNodeReferred) == true)
{
string strComparisonOp_ParentNodeReferred = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.ParentNodeReferred, objvcc_WorkEduClsRela_Cond.ParentNodeReferred, strComparisonOp_ParentNodeReferred);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.QuestionTypeId, objvcc_WorkEduClsRela_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.QuestionTypeName, objvcc_WorkEduClsRela_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.ExamGradeId) == true)
{
string strComparisonOp_ExamGradeId = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.ExamGradeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.ExamGradeId, objvcc_WorkEduClsRela_Cond.ExamGradeId, strComparisonOp_ExamGradeId);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.ExamGradeName) == true)
{
string strComparisonOp_ExamGradeName = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.ExamGradeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.ExamGradeName, objvcc_WorkEduClsRela_Cond.ExamGradeName, strComparisonOp_ExamGradeName);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.AnswerTypeId) == true)
{
string strComparisonOp_AnswerTypeId = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.AnswerTypeId, objvcc_WorkEduClsRela_Cond.AnswerTypeId, strComparisonOp_AnswerTypeId);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.AnswerModeId) == true)
{
string strComparisonOp_AnswerModeId = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.AnswerModeId, objvcc_WorkEduClsRela_Cond.AnswerModeId, strComparisonOp_AnswerModeId);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.DefaultValue) == true)
{
string strComparisonOp_DefaultValue = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.DefaultValue, objvcc_WorkEduClsRela_Cond.DefaultValue, strComparisonOp_DefaultValue);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.TextDirectId) == true)
{
string strComparisonOp_TextDirectId = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.TextDirectId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.TextDirectId, objvcc_WorkEduClsRela_Cond.TextDirectId, strComparisonOp_TextDirectId);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.RelaEvent) == true)
{
string strComparisonOp_RelaEvent = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.RelaEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.RelaEvent, objvcc_WorkEduClsRela_Cond.RelaEvent, strComparisonOp_RelaEvent);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.CheckBoxLimitCount) == true)
{
string strComparisonOp_CheckBoxLimitCount = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.CheckBoxLimitCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkEduClsRela.CheckBoxLimitCount, objvcc_WorkEduClsRela_Cond.CheckBoxLimitCount, strComparisonOp_CheckBoxLimitCount);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.AnswerAttLimitSize) == true)
{
string strComparisonOp_AnswerAttLimitSize = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.AnswerAttLimitSize];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkEduClsRela.AnswerAttLimitSize, objvcc_WorkEduClsRela_Cond.AnswerAttLimitSize, strComparisonOp_AnswerAttLimitSize);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.LimitedResourceType) == true)
{
string strComparisonOp_LimitedResourceType = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.LimitedResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.LimitedResourceType, objvcc_WorkEduClsRela_Cond.LimitedResourceType, strComparisonOp_LimitedResourceType);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.QuestionTypeId4Course) == true)
{
string strComparisonOp_QuestionTypeId4Course = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionTypeId4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.QuestionTypeId4Course, objvcc_WorkEduClsRela_Cond.QuestionTypeId4Course, strComparisonOp_QuestionTypeId4Course);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.QuestionTypeName4Course) == true)
{
string strComparisonOp_QuestionTypeName4Course = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.QuestionTypeName4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.QuestionTypeName4Course, objvcc_WorkEduClsRela_Cond.QuestionTypeName4Course, strComparisonOp_QuestionTypeName4Course);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.id_CurrEduCls, objvcc_WorkEduClsRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.CurrEduClsId) == true)
{
string strComparisonOp_CurrEduClsId = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.CurrEduClsId, objvcc_WorkEduClsRela_Cond.CurrEduClsId, strComparisonOp_CurrEduClsId);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.EduClsName, objvcc_WorkEduClsRela_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.Scores) == true)
{
string strComparisonOp_Scores = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkEduClsRela.Scores, objvcc_WorkEduClsRela_Cond.Scores, strComparisonOp_Scores);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.TeacherID, objvcc_WorkEduClsRela_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.IsPublish) == true)
{
if (objvcc_WorkEduClsRela_Cond.IsPublish == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkEduClsRela.IsPublish);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkEduClsRela.IsPublish);
}
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.PubDate) == true)
{
string strComparisonOp_PubDate = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.PubDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.PubDate, objvcc_WorkEduClsRela_Cond.PubDate, strComparisonOp_PubDate);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.publisher) == true)
{
string strComparisonOp_publisher = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.publisher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.publisher, objvcc_WorkEduClsRela_Cond.publisher, strComparisonOp_publisher);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.SpecifyCompletionDate) == true)
{
string strComparisonOp_SpecifyCompletionDate = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.SpecifyCompletionDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.SpecifyCompletionDate, objvcc_WorkEduClsRela_Cond.SpecifyCompletionDate, strComparisonOp_SpecifyCompletionDate);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.IsCurrEduCls) == true)
{
if (objvcc_WorkEduClsRela_Cond.IsCurrEduCls == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkEduClsRela.IsCurrEduCls);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkEduClsRela.IsCurrEduCls);
}
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.IsGroupWork) == true)
{
if (objvcc_WorkEduClsRela_Cond.IsGroupWork == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkEduClsRela.IsGroupWork);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkEduClsRela.IsGroupWork);
}
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.CourseStudentGroupId) == true)
{
string strComparisonOp_CourseStudentGroupId = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.CourseStudentGroupId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkEduClsRela.CourseStudentGroupId, objvcc_WorkEduClsRela_Cond.CourseStudentGroupId, strComparisonOp_CourseStudentGroupId);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.WorkTypeId) == true)
{
string strComparisonOp_WorkTypeId = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.WorkTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.WorkTypeId, objvcc_WorkEduClsRela_Cond.WorkTypeId, strComparisonOp_WorkTypeId);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.WorkTypeName) == true)
{
string strComparisonOp_WorkTypeName = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.WorkTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.WorkTypeName, objvcc_WorkEduClsRela_Cond.WorkTypeName, strComparisonOp_WorkTypeName);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.UpdDate, objvcc_WorkEduClsRela_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.UpdUserId, objvcc_WorkEduClsRela_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.Memo) == true)
{
string strComparisonOp_Memo = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkEduClsRela.Memo, objvcc_WorkEduClsRela_Cond.Memo, strComparisonOp_Memo);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.StuNum) == true)
{
string strComparisonOp_StuNum = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.StuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkEduClsRela.StuNum, objvcc_WorkEduClsRela_Cond.StuNum, strComparisonOp_StuNum);
}
if (objvcc_WorkEduClsRela_Cond.IsUpdated(convcc_WorkEduClsRela.EduClsStuNum) == true)
{
string strComparisonOp_EduClsStuNum = objvcc_WorkEduClsRela_Cond.dicFldComparisonOp[convcc_WorkEduClsRela.EduClsStuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkEduClsRela.EduClsStuNum, objvcc_WorkEduClsRela_Cond.EduClsStuNum, strComparisonOp_EduClsStuNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v作业教学班关系表(vcc_WorkEduClsRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_WorkEduClsRelaWApi
{
private static readonly string mstrApiControllerName = "vcc_WorkEduClsRelaApi";

 public clsvcc_WorkEduClsRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_WorkEduClsRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkEduClsRelaEN GetObjById_WorkEduClsRela(long lngId_WorkEduClsRela)
{
string strAction = "GetObjById_WorkEduClsRela";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = null;
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
objvcc_WorkEduClsRelaEN = JsonConvert.DeserializeObject<clsvcc_WorkEduClsRelaEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkEduClsRelaEN;
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
public static clsvcc_WorkEduClsRelaEN GetObjById_WorkEduClsRela_WA_Cache(long lngId_WorkEduClsRela)
{
string strAction = "GetObjById_WorkEduClsRela_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = null;
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
objvcc_WorkEduClsRelaEN = JsonConvert.DeserializeObject<clsvcc_WorkEduClsRelaEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkEduClsRelaEN;
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
public static clsvcc_WorkEduClsRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = null;
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
objvcc_WorkEduClsRelaEN = JsonConvert.DeserializeObject<clsvcc_WorkEduClsRelaEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkEduClsRelaEN;
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
public static clsvcc_WorkEduClsRelaEN GetObjById_WorkEduClsRela_Cache(long lngId_WorkEduClsRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_WorkEduClsRelaEN._CurrTabName_S);
List<clsvcc_WorkEduClsRelaEN> arrvcc_WorkEduClsRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_WorkEduClsRelaEN> arrvcc_WorkEduClsRelaObjLst_Sel =
from objvcc_WorkEduClsRelaEN in arrvcc_WorkEduClsRelaObjLst_Cache
where objvcc_WorkEduClsRelaEN.Id_WorkEduClsRela == lngId_WorkEduClsRela
select objvcc_WorkEduClsRelaEN;
if (arrvcc_WorkEduClsRelaObjLst_Sel.Count() == 0)
{
   clsvcc_WorkEduClsRelaEN obj = clsvcc_WorkEduClsRelaWApi.GetObjById_WorkEduClsRela(lngId_WorkEduClsRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_WorkEduClsRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkEduClsRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_WorkEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkEduClsRelaEN> GetObjLstById_WorkEduClsRelaLst(List<long> arrId_WorkEduClsRela)
{
 List<clsvcc_WorkEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvcc_WorkEduClsRelaEN> GetObjLstById_WorkEduClsRelaLst_Cache(List<long> arrId_WorkEduClsRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_WorkEduClsRelaEN._CurrTabName_S);
List<clsvcc_WorkEduClsRelaEN> arrvcc_WorkEduClsRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_WorkEduClsRelaEN> arrvcc_WorkEduClsRelaObjLst_Sel =
from objvcc_WorkEduClsRelaEN in arrvcc_WorkEduClsRelaObjLst_Cache
where arrId_WorkEduClsRela.Contains(objvcc_WorkEduClsRelaEN.Id_WorkEduClsRela)
select objvcc_WorkEduClsRelaEN;
return arrvcc_WorkEduClsRelaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkEduClsRelaEN> GetObjLstById_WorkEduClsRelaLst_WA_Cache(List<long> arrId_WorkEduClsRela)
{
 List<clsvcc_WorkEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkEduClsRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_WorkEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkEduClsRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_WorkEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkEduClsRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkEduClsRelaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkEduClsRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkEduClsRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvcc_WorkEduClsRelaENS">源对象</param>
 /// <param name = "objvcc_WorkEduClsRelaENT">目标对象</param>
 public static void CopyTo(clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaENS, clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaENT)
{
try
{
objvcc_WorkEduClsRelaENT.Id_WorkEduClsRela = objvcc_WorkEduClsRelaENS.Id_WorkEduClsRela; //作业教学班关系流水号
objvcc_WorkEduClsRelaENT.QuestionID = objvcc_WorkEduClsRelaENS.QuestionID; //题目ID
objvcc_WorkEduClsRelaENT.QuestionIndex = objvcc_WorkEduClsRelaENS.QuestionIndex; //题目序号
objvcc_WorkEduClsRelaENT.QuestionName = objvcc_WorkEduClsRelaENS.QuestionName; //题目名称
objvcc_WorkEduClsRelaENT.QuestionContent = objvcc_WorkEduClsRelaENS.QuestionContent; //题目内容
objvcc_WorkEduClsRelaENT.CourseId = objvcc_WorkEduClsRelaENS.CourseId; //课程Id
objvcc_WorkEduClsRelaENT.CourseName = objvcc_WorkEduClsRelaENS.CourseName; //课程名称
objvcc_WorkEduClsRelaENT.CourseChapterId = objvcc_WorkEduClsRelaENS.CourseChapterId; //课程章节ID
objvcc_WorkEduClsRelaENT.CourseChapterName = objvcc_WorkEduClsRelaENS.CourseChapterName; //课程章节名称
objvcc_WorkEduClsRelaENT.ChapterName = objvcc_WorkEduClsRelaENS.ChapterName; //章名
objvcc_WorkEduClsRelaENT.SectionName = objvcc_WorkEduClsRelaENS.SectionName; //节名
objvcc_WorkEduClsRelaENT.ChapterName_Sim = objvcc_WorkEduClsRelaENS.ChapterName_Sim; //章名简称
objvcc_WorkEduClsRelaENT.SectionName_Sim = objvcc_WorkEduClsRelaENS.SectionName_Sim; //节名简称
objvcc_WorkEduClsRelaENT.ParentNodeID = objvcc_WorkEduClsRelaENS.ParentNodeID; //父节点编号
objvcc_WorkEduClsRelaENT.CourseChapterReferred = objvcc_WorkEduClsRelaENS.CourseChapterReferred; //节简称
objvcc_WorkEduClsRelaENT.ParentNodeName = objvcc_WorkEduClsRelaENS.ParentNodeName; //父节点名称
objvcc_WorkEduClsRelaENT.ParentNodeReferred = objvcc_WorkEduClsRelaENS.ParentNodeReferred; //章简称
objvcc_WorkEduClsRelaENT.QuestionTypeId = objvcc_WorkEduClsRelaENS.QuestionTypeId; //题目类型Id
objvcc_WorkEduClsRelaENT.QuestionTypeName = objvcc_WorkEduClsRelaENS.QuestionTypeName; //题目类型名
objvcc_WorkEduClsRelaENT.ExamGradeId = objvcc_WorkEduClsRelaENS.ExamGradeId; //题库等级ID
objvcc_WorkEduClsRelaENT.ExamGradeName = objvcc_WorkEduClsRelaENS.ExamGradeName; //题库等级名
objvcc_WorkEduClsRelaENT.AnswerTypeId = objvcc_WorkEduClsRelaENS.AnswerTypeId; //答案类型ID
objvcc_WorkEduClsRelaENT.AnswerModeId = objvcc_WorkEduClsRelaENS.AnswerModeId; //答案模式Id
objvcc_WorkEduClsRelaENT.DefaultValue = objvcc_WorkEduClsRelaENS.DefaultValue; //缺省值
objvcc_WorkEduClsRelaENT.TextDirectId = objvcc_WorkEduClsRelaENS.TextDirectId; //文本方向ID
objvcc_WorkEduClsRelaENT.RelaEvent = objvcc_WorkEduClsRelaENS.RelaEvent; //相关事件
objvcc_WorkEduClsRelaENT.CheckBoxLimitCount = objvcc_WorkEduClsRelaENS.CheckBoxLimitCount; //复选框限制数
objvcc_WorkEduClsRelaENT.AnswerAttLimitSize = objvcc_WorkEduClsRelaENS.AnswerAttLimitSize; //回答附件限制大小
objvcc_WorkEduClsRelaENT.LimitedResourceType = objvcc_WorkEduClsRelaENS.LimitedResourceType; //限制资源类型
objvcc_WorkEduClsRelaENT.QuestionTypeId4Course = objvcc_WorkEduClsRelaENS.QuestionTypeId4Course; //题目类型Id4课程
objvcc_WorkEduClsRelaENT.QuestionTypeName4Course = objvcc_WorkEduClsRelaENS.QuestionTypeName4Course; //题目类型名4课程
objvcc_WorkEduClsRelaENT.id_CurrEduCls = objvcc_WorkEduClsRelaENS.id_CurrEduCls; //当前教学班流水号
objvcc_WorkEduClsRelaENT.CurrEduClsId = objvcc_WorkEduClsRelaENS.CurrEduClsId; //当前教学班Id
objvcc_WorkEduClsRelaENT.EduClsName = objvcc_WorkEduClsRelaENS.EduClsName; //教学班名称
objvcc_WorkEduClsRelaENT.Scores = objvcc_WorkEduClsRelaENS.Scores; //分值
objvcc_WorkEduClsRelaENT.TeacherID = objvcc_WorkEduClsRelaENS.TeacherID; //教师工号
objvcc_WorkEduClsRelaENT.IsPublish = objvcc_WorkEduClsRelaENS.IsPublish; //是否发布
objvcc_WorkEduClsRelaENT.PubDate = objvcc_WorkEduClsRelaENS.PubDate; //发布日期
objvcc_WorkEduClsRelaENT.publisher = objvcc_WorkEduClsRelaENS.publisher; //发布者Id
objvcc_WorkEduClsRelaENT.SpecifyCompletionDate = objvcc_WorkEduClsRelaENS.SpecifyCompletionDate; //指定完成日期
objvcc_WorkEduClsRelaENT.IsCurrEduCls = objvcc_WorkEduClsRelaENS.IsCurrEduCls; //是否为教学班作业
objvcc_WorkEduClsRelaENT.IsGroupWork = objvcc_WorkEduClsRelaENS.IsGroupWork; //是否为小组作业
objvcc_WorkEduClsRelaENT.CourseStudentGroupId = objvcc_WorkEduClsRelaENS.CourseStudentGroupId; //学生分组表流水号
objvcc_WorkEduClsRelaENT.WorkTypeId = objvcc_WorkEduClsRelaENS.WorkTypeId; //作业类型Id
objvcc_WorkEduClsRelaENT.WorkTypeName = objvcc_WorkEduClsRelaENS.WorkTypeName; //作业类型名称
objvcc_WorkEduClsRelaENT.UpdDate = objvcc_WorkEduClsRelaENS.UpdDate; //修改日期
objvcc_WorkEduClsRelaENT.UpdUserId = objvcc_WorkEduClsRelaENS.UpdUserId; //修改用户Id
objvcc_WorkEduClsRelaENT.Memo = objvcc_WorkEduClsRelaENS.Memo; //备注
objvcc_WorkEduClsRelaENT.StuNum = objvcc_WorkEduClsRelaENS.StuNum; //学生数
objvcc_WorkEduClsRelaENT.EduClsStuNum = objvcc_WorkEduClsRelaENS.EduClsStuNum; //教学班学生数
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
public static DataTable ToDataTable(List<clsvcc_WorkEduClsRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_WorkEduClsRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_WorkEduClsRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_WorkEduClsRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_WorkEduClsRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_WorkEduClsRelaEN.AttributeName)
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
if (clsWorkTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsWorkTypeWApi没有刷新缓存机制(clsWorkTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvcc_WorkEduClsRelaObjLst_Cache == null)
//{
//arrvcc_WorkEduClsRelaObjLst_Cache = await clsvcc_WorkEduClsRelaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvcc_WorkEduClsRelaEN._CurrTabName_S);
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
public static List<clsvcc_WorkEduClsRelaEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcc_WorkEduClsRelaEN._CurrTabName_S);
List<clsvcc_WorkEduClsRelaEN> arrvcc_WorkEduClsRelaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_WorkEduClsRelaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_WorkEduClsRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_WorkEduClsRela.Id_WorkEduClsRela, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_WorkEduClsRela.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkEduClsRela.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.QuestionContent, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.CourseChapterReferred, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.ParentNodeReferred, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.ExamGradeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.ExamGradeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.AnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.AnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.TextDirectId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.RelaEvent, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.CheckBoxLimitCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkEduClsRela.AnswerAttLimitSize, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_WorkEduClsRela.LimitedResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.QuestionTypeId4Course, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.QuestionTypeName4Course, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.CurrEduClsId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.Scores, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_WorkEduClsRela.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.IsPublish, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkEduClsRela.PubDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.publisher, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.SpecifyCompletionDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.IsCurrEduCls, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkEduClsRela.IsGroupWork, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkEduClsRela.CourseStudentGroupId, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_WorkEduClsRela.WorkTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.WorkTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkEduClsRela.StuNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkEduClsRela.EduClsStuNum, Type.GetType("System.Int32"));
foreach (clsvcc_WorkEduClsRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_WorkEduClsRela.Id_WorkEduClsRela] = objInFor[convcc_WorkEduClsRela.Id_WorkEduClsRela];
objDR[convcc_WorkEduClsRela.QuestionID] = objInFor[convcc_WorkEduClsRela.QuestionID];
objDR[convcc_WorkEduClsRela.QuestionIndex] = objInFor[convcc_WorkEduClsRela.QuestionIndex];
objDR[convcc_WorkEduClsRela.QuestionName] = objInFor[convcc_WorkEduClsRela.QuestionName];
objDR[convcc_WorkEduClsRela.QuestionContent] = objInFor[convcc_WorkEduClsRela.QuestionContent];
objDR[convcc_WorkEduClsRela.CourseId] = objInFor[convcc_WorkEduClsRela.CourseId];
objDR[convcc_WorkEduClsRela.CourseName] = objInFor[convcc_WorkEduClsRela.CourseName];
objDR[convcc_WorkEduClsRela.CourseChapterId] = objInFor[convcc_WorkEduClsRela.CourseChapterId];
objDR[convcc_WorkEduClsRela.CourseChapterName] = objInFor[convcc_WorkEduClsRela.CourseChapterName];
objDR[convcc_WorkEduClsRela.ChapterName] = objInFor[convcc_WorkEduClsRela.ChapterName];
objDR[convcc_WorkEduClsRela.SectionName] = objInFor[convcc_WorkEduClsRela.SectionName];
objDR[convcc_WorkEduClsRela.ChapterName_Sim] = objInFor[convcc_WorkEduClsRela.ChapterName_Sim];
objDR[convcc_WorkEduClsRela.SectionName_Sim] = objInFor[convcc_WorkEduClsRela.SectionName_Sim];
objDR[convcc_WorkEduClsRela.ParentNodeID] = objInFor[convcc_WorkEduClsRela.ParentNodeID];
objDR[convcc_WorkEduClsRela.CourseChapterReferred] = objInFor[convcc_WorkEduClsRela.CourseChapterReferred];
objDR[convcc_WorkEduClsRela.ParentNodeName] = objInFor[convcc_WorkEduClsRela.ParentNodeName];
objDR[convcc_WorkEduClsRela.ParentNodeReferred] = objInFor[convcc_WorkEduClsRela.ParentNodeReferred];
objDR[convcc_WorkEduClsRela.QuestionTypeId] = objInFor[convcc_WorkEduClsRela.QuestionTypeId];
objDR[convcc_WorkEduClsRela.QuestionTypeName] = objInFor[convcc_WorkEduClsRela.QuestionTypeName];
objDR[convcc_WorkEduClsRela.ExamGradeId] = objInFor[convcc_WorkEduClsRela.ExamGradeId];
objDR[convcc_WorkEduClsRela.ExamGradeName] = objInFor[convcc_WorkEduClsRela.ExamGradeName];
objDR[convcc_WorkEduClsRela.AnswerTypeId] = objInFor[convcc_WorkEduClsRela.AnswerTypeId];
objDR[convcc_WorkEduClsRela.AnswerModeId] = objInFor[convcc_WorkEduClsRela.AnswerModeId];
objDR[convcc_WorkEduClsRela.DefaultValue] = objInFor[convcc_WorkEduClsRela.DefaultValue];
objDR[convcc_WorkEduClsRela.TextDirectId] = objInFor[convcc_WorkEduClsRela.TextDirectId];
objDR[convcc_WorkEduClsRela.RelaEvent] = objInFor[convcc_WorkEduClsRela.RelaEvent];
objDR[convcc_WorkEduClsRela.CheckBoxLimitCount] = objInFor[convcc_WorkEduClsRela.CheckBoxLimitCount];
objDR[convcc_WorkEduClsRela.AnswerAttLimitSize] = objInFor[convcc_WorkEduClsRela.AnswerAttLimitSize];
objDR[convcc_WorkEduClsRela.LimitedResourceType] = objInFor[convcc_WorkEduClsRela.LimitedResourceType];
objDR[convcc_WorkEduClsRela.QuestionTypeId4Course] = objInFor[convcc_WorkEduClsRela.QuestionTypeId4Course];
objDR[convcc_WorkEduClsRela.QuestionTypeName4Course] = objInFor[convcc_WorkEduClsRela.QuestionTypeName4Course];
objDR[convcc_WorkEduClsRela.id_CurrEduCls] = objInFor[convcc_WorkEduClsRela.id_CurrEduCls];
objDR[convcc_WorkEduClsRela.CurrEduClsId] = objInFor[convcc_WorkEduClsRela.CurrEduClsId];
objDR[convcc_WorkEduClsRela.EduClsName] = objInFor[convcc_WorkEduClsRela.EduClsName];
objDR[convcc_WorkEduClsRela.Scores] = objInFor[convcc_WorkEduClsRela.Scores];
objDR[convcc_WorkEduClsRela.TeacherID] = objInFor[convcc_WorkEduClsRela.TeacherID];
objDR[convcc_WorkEduClsRela.IsPublish] = objInFor[convcc_WorkEduClsRela.IsPublish];
objDR[convcc_WorkEduClsRela.PubDate] = objInFor[convcc_WorkEduClsRela.PubDate];
objDR[convcc_WorkEduClsRela.publisher] = objInFor[convcc_WorkEduClsRela.publisher];
objDR[convcc_WorkEduClsRela.SpecifyCompletionDate] = objInFor[convcc_WorkEduClsRela.SpecifyCompletionDate];
objDR[convcc_WorkEduClsRela.IsCurrEduCls] = objInFor[convcc_WorkEduClsRela.IsCurrEduCls];
objDR[convcc_WorkEduClsRela.IsGroupWork] = objInFor[convcc_WorkEduClsRela.IsGroupWork];
objDR[convcc_WorkEduClsRela.CourseStudentGroupId] = objInFor[convcc_WorkEduClsRela.CourseStudentGroupId];
objDR[convcc_WorkEduClsRela.WorkTypeId] = objInFor[convcc_WorkEduClsRela.WorkTypeId];
objDR[convcc_WorkEduClsRela.WorkTypeName] = objInFor[convcc_WorkEduClsRela.WorkTypeName];
objDR[convcc_WorkEduClsRela.UpdDate] = objInFor[convcc_WorkEduClsRela.UpdDate];
objDR[convcc_WorkEduClsRela.UpdUserId] = objInFor[convcc_WorkEduClsRela.UpdUserId];
objDR[convcc_WorkEduClsRela.Memo] = objInFor[convcc_WorkEduClsRela.Memo];
objDR[convcc_WorkEduClsRela.StuNum] = objInFor[convcc_WorkEduClsRela.StuNum];
objDR[convcc_WorkEduClsRela.EduClsStuNum] = objInFor[convcc_WorkEduClsRela.EduClsStuNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}