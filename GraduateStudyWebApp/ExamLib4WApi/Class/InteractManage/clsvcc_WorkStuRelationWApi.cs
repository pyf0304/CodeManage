
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkStuRelationWApi
 表名:vcc_WorkStuRelation(01120198)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:38
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
public static class clsvcc_WorkStuRelationWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetId_WorkStuRelation(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, long lngId_WorkStuRelation, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.Id_WorkStuRelation = lngId_WorkStuRelation; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.Id_WorkStuRelation) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.Id_WorkStuRelation, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.Id_WorkStuRelation] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN Setid_CurrEduCls(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, convcc_WorkStuRelation.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convcc_WorkStuRelation.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convcc_WorkStuRelation.id_CurrEduCls);
objvcc_WorkStuRelationEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.id_CurrEduCls) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.id_CurrEduCls, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.id_CurrEduCls] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetId_WorkEduClsRela(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, long lngId_WorkEduClsRela, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.Id_WorkEduClsRela = lngId_WorkEduClsRela; //作业教学班关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.Id_WorkEduClsRela) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.Id_WorkEduClsRela, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.Id_WorkEduClsRela] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetQuestionID(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convcc_WorkStuRelation.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convcc_WorkStuRelation.QuestionID);
objvcc_WorkStuRelationEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.QuestionID) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.QuestionID, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.QuestionID] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetQuestionIndex(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, int intQuestionIndex, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.QuestionIndex) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.QuestionIndex, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.QuestionIndex] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetQuestionName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convcc_WorkStuRelation.QuestionName);
objvcc_WorkStuRelationEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.QuestionName) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.QuestionName, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.QuestionName] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetQuestionContent(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strQuestionContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, convcc_WorkStuRelation.QuestionContent);
objvcc_WorkStuRelationEN.QuestionContent = strQuestionContent; //题目内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.QuestionContent) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.QuestionContent, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.QuestionContent] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetCourseId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_WorkStuRelation.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_WorkStuRelation.CourseId);
objvcc_WorkStuRelationEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.CourseId) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.CourseId, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.CourseId] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetCourseName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_WorkStuRelation.CourseName);
objvcc_WorkStuRelationEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.CourseName) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.CourseName, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.CourseName] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetCourseChapterId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_WorkStuRelation.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_WorkStuRelation.CourseChapterId);
objvcc_WorkStuRelationEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.CourseChapterId) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.CourseChapterId, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.CourseChapterId] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetCourseChapterName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_WorkStuRelation.CourseChapterName);
objvcc_WorkStuRelationEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.CourseChapterName) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.CourseChapterName, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.CourseChapterName] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetChapterName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_WorkStuRelation.ChapterName);
objvcc_WorkStuRelationEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.ChapterName) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.ChapterName, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.ChapterName] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetSectionName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_WorkStuRelation.SectionName);
objvcc_WorkStuRelationEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.SectionName) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.SectionName, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.SectionName] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetChapterName_Sim(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convcc_WorkStuRelation.ChapterName_Sim);
objvcc_WorkStuRelationEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.ChapterName_Sim) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.ChapterName_Sim, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.ChapterName_Sim] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetSectionName_Sim(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convcc_WorkStuRelation.SectionName_Sim);
objvcc_WorkStuRelationEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.SectionName_Sim) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.SectionName_Sim, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.SectionName_Sim] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetParentNodeID(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convcc_WorkStuRelation.ParentNodeID);
objvcc_WorkStuRelationEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.ParentNodeID) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.ParentNodeID, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.ParentNodeID] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetCourseChapterReferred(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strCourseChapterReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convcc_WorkStuRelation.CourseChapterReferred);
objvcc_WorkStuRelationEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.CourseChapterReferred) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.CourseChapterReferred, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.CourseChapterReferred] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetParentNodeName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convcc_WorkStuRelation.ParentNodeName);
objvcc_WorkStuRelationEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.ParentNodeName) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.ParentNodeName, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.ParentNodeName] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetParentNodeReferred(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strParentNodeReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convcc_WorkStuRelation.ParentNodeReferred);
objvcc_WorkStuRelationEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.ParentNodeReferred) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.ParentNodeReferred, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.ParentNodeReferred] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetQuestionTypeId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convcc_WorkStuRelation.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convcc_WorkStuRelation.QuestionTypeId);
objvcc_WorkStuRelationEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.QuestionTypeId) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.QuestionTypeId, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.QuestionTypeId] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetQuestionTypeName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convcc_WorkStuRelation.QuestionTypeName);
objvcc_WorkStuRelationEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.QuestionTypeName) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.QuestionTypeName, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.QuestionTypeName] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetAnswerTypeId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convcc_WorkStuRelation.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convcc_WorkStuRelation.AnswerTypeId);
objvcc_WorkStuRelationEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.AnswerTypeId) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.AnswerTypeId, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.AnswerTypeId] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetDefaultValue(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convcc_WorkStuRelation.DefaultValue);
objvcc_WorkStuRelationEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.DefaultValue) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.DefaultValue, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.DefaultValue] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetTextDirectId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strTextDirectId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTextDirectId, 4, convcc_WorkStuRelation.TextDirectId);
clsCheckSql.CheckFieldForeignKey(strTextDirectId, 4, convcc_WorkStuRelation.TextDirectId);
objvcc_WorkStuRelationEN.TextDirectId = strTextDirectId; //文本方向ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.TextDirectId) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.TextDirectId, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.TextDirectId] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetRelaEvent(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strRelaEvent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaEvent, 4000, convcc_WorkStuRelation.RelaEvent);
objvcc_WorkStuRelationEN.RelaEvent = strRelaEvent; //相关事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.RelaEvent) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.RelaEvent, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.RelaEvent] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetCheckBoxLimitCount(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, int intCheckBoxLimitCount, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.CheckBoxLimitCount = intCheckBoxLimitCount; //复选框限制数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.CheckBoxLimitCount) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.CheckBoxLimitCount, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.CheckBoxLimitCount] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetAnswerAttLimitSize(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, long lngAnswerAttLimitSize, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.AnswerAttLimitSize = lngAnswerAttLimitSize; //回答附件限制大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.AnswerAttLimitSize) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.AnswerAttLimitSize, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.AnswerAttLimitSize] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetLimitedResourceType(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strLimitedResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLimitedResourceType, 100, convcc_WorkStuRelation.LimitedResourceType);
objvcc_WorkStuRelationEN.LimitedResourceType = strLimitedResourceType; //限制资源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.LimitedResourceType) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.LimitedResourceType, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.LimitedResourceType] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetQuestionTypeId4Course(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strQuestionTypeId4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId4Course, 8, convcc_WorkStuRelation.QuestionTypeId4Course);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId4Course, 8, convcc_WorkStuRelation.QuestionTypeId4Course);
objvcc_WorkStuRelationEN.QuestionTypeId4Course = strQuestionTypeId4Course; //题目类型Id4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.QuestionTypeId4Course) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.QuestionTypeId4Course, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.QuestionTypeId4Course] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetQuestionTypeName4Course(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strQuestionTypeName4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName4Course, 30, convcc_WorkStuRelation.QuestionTypeName4Course);
objvcc_WorkStuRelationEN.QuestionTypeName4Course = strQuestionTypeName4Course; //题目类型名4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.QuestionTypeName4Course) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.QuestionTypeName4Course, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.QuestionTypeName4Course] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetCurrEduClsId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convcc_WorkStuRelation.CurrEduClsId);
objvcc_WorkStuRelationEN.CurrEduClsId = strCurrEduClsId; //当前教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.CurrEduClsId) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.CurrEduClsId, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.CurrEduClsId] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetEduClsName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convcc_WorkStuRelation.EduClsName);
objvcc_WorkStuRelationEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.EduClsName) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.EduClsName, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.EduClsName] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetTeacherID(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherID, 12, convcc_WorkStuRelation.TeacherID);
objvcc_WorkStuRelationEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.TeacherID) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.TeacherID, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.TeacherID] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetPubDate(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strPubDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubDate, 14, convcc_WorkStuRelation.PubDate);
objvcc_WorkStuRelationEN.PubDate = strPubDate; //发布日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.PubDate) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.PubDate, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.PubDate] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetIsCurrEduCls(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, bool bolIsCurrEduCls, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.IsCurrEduCls = bolIsCurrEduCls; //是否为教学班作业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.IsCurrEduCls) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.IsCurrEduCls, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.IsCurrEduCls] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetIsGroupWork(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, bool bolIsGroupWork, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.IsGroupWork = bolIsGroupWork; //是否为小组作业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.IsGroupWork) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.IsGroupWork, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.IsGroupWork] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetCourseStudentGroupId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, long lngCourseStudentGroupId, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.CourseStudentGroupId = lngCourseStudentGroupId; //学生分组表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.CourseStudentGroupId) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.CourseStudentGroupId, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.CourseStudentGroupId] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetWorkTypeName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strWorkTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWorkTypeName, 30, convcc_WorkStuRelation.WorkTypeName);
objvcc_WorkStuRelationEN.WorkTypeName = strWorkTypeName; //作业类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.WorkTypeName) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.WorkTypeName, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.WorkTypeName] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetScores(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, double dblScores, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.Scores) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.Scores, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.Scores] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetSpecifyCompletionDate(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strSpecifyCompletionDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSpecifyCompletionDate, convcc_WorkStuRelation.SpecifyCompletionDate);
clsCheckSql.CheckFieldLen(strSpecifyCompletionDate, 14, convcc_WorkStuRelation.SpecifyCompletionDate);
objvcc_WorkStuRelationEN.SpecifyCompletionDate = strSpecifyCompletionDate; //指定完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.SpecifyCompletionDate) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.SpecifyCompletionDate, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.SpecifyCompletionDate] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN Setid_StudentInfo(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudentInfo, convcc_WorkStuRelation.id_StudentInfo);
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convcc_WorkStuRelation.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convcc_WorkStuRelation.id_StudentInfo);
objvcc_WorkStuRelationEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.id_StudentInfo) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.id_StudentInfo, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.id_StudentInfo] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetStuID(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convcc_WorkStuRelation.StuID);
objvcc_WorkStuRelationEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.StuID) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.StuID, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.StuID] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetStuName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convcc_WorkStuRelation.StuName);
objvcc_WorkStuRelationEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.StuName) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.StuName, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.StuName] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN Setid_XzCollege(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convcc_WorkStuRelation.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convcc_WorkStuRelation.id_XzCollege);
objvcc_WorkStuRelationEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.id_XzCollege) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.id_XzCollege, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.id_XzCollege] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetCollegeName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_WorkStuRelation.CollegeName);
objvcc_WorkStuRelationEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.CollegeName) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.CollegeName, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.CollegeName] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetCollegeNameA(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_WorkStuRelation.CollegeNameA);
objvcc_WorkStuRelationEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.CollegeNameA) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.CollegeNameA, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.CollegeNameA] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN Setid_XzMajor(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convcc_WorkStuRelation.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convcc_WorkStuRelation.id_XzMajor);
objvcc_WorkStuRelationEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.id_XzMajor) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.id_XzMajor, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.id_XzMajor] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetMajorID(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convcc_WorkStuRelation.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convcc_WorkStuRelation.MajorID);
objvcc_WorkStuRelationEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.MajorID) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.MajorID, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.MajorID] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetMajorName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convcc_WorkStuRelation.MajorName);
objvcc_WorkStuRelationEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.MajorName) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.MajorName, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.MajorName] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN Setid_GradeBase(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convcc_WorkStuRelation.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convcc_WorkStuRelation.id_GradeBase);
objvcc_WorkStuRelationEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.id_GradeBase) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.id_GradeBase, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.id_GradeBase] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetGradeBaseName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convcc_WorkStuRelation.GradeBaseName);
objvcc_WorkStuRelationEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.GradeBaseName) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.GradeBaseName, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.GradeBaseName] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetAdminClsName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strAdminClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convcc_WorkStuRelation.AdminClsName);
objvcc_WorkStuRelationEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.AdminClsName) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.AdminClsName, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.AdminClsName] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetAdminClsId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strAdminClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convcc_WorkStuRelation.AdminClsId);
objvcc_WorkStuRelationEN.AdminClsId = strAdminClsId; //行政班代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.AdminClsId) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.AdminClsId, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.AdminClsId] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetAnswerModeId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convcc_WorkStuRelation.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convcc_WorkStuRelation.AnswerModeId);
objvcc_WorkStuRelationEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.AnswerModeId) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.AnswerModeId, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.AnswerModeId] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetAnswerOptionId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strAnswerOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerOptionId, 8, convcc_WorkStuRelation.AnswerOptionId);
clsCheckSql.CheckFieldForeignKey(strAnswerOptionId, 8, convcc_WorkStuRelation.AnswerOptionId);
objvcc_WorkStuRelationEN.AnswerOptionId = strAnswerOptionId; //回答选项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.AnswerOptionId) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.AnswerOptionId, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.AnswerOptionId] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetAnswerMultiOptions(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strAnswerMultiOptions, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerMultiOptions, 300, convcc_WorkStuRelation.AnswerMultiOptions);
objvcc_WorkStuRelationEN.AnswerMultiOptions = strAnswerMultiOptions; //多选项答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.AnswerMultiOptions) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.AnswerMultiOptions, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.AnswerMultiOptions] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetAnswerBoolResult(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, bool bolAnswerBoolResult, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.AnswerBoolResult = bolAnswerBoolResult; //答案布尔结果
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.AnswerBoolResult) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.AnswerBoolResult, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.AnswerBoolResult] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetStuAnswerText(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strStuAnswerText, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.StuAnswerText = strStuAnswerText; //学生回答文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.StuAnswerText) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.StuAnswerText, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.StuAnswerText] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetIsPublish(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, bool bolIsPublish, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.IsPublish = bolIsPublish; //是否发布
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.IsPublish) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.IsPublish, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.IsPublish] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetIsLook(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, bool bolIsLook, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.IsLook = bolIsLook; //是否查看
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.IsLook) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.IsLook, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.IsLook] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetIsSave(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, bool bolIsSave, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.IsSave = bolIsSave; //是否保存
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.IsSave) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.IsSave, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.IsSave] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetIsSubmit(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.IsSubmit) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.IsSubmit, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.IsSubmit] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetApplySendBackDate(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strApplySendBackDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplySendBackDate, 14, convcc_WorkStuRelation.ApplySendBackDate);
objvcc_WorkStuRelationEN.ApplySendBackDate = strApplySendBackDate; //申请退回日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.ApplySendBackDate) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.ApplySendBackDate, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.ApplySendBackDate] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetIsApplySendBack(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, bool bolIsApplySendBack, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.IsApplySendBack = bolIsApplySendBack; //是否申请退回
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.IsApplySendBack) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.IsApplySendBack, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.IsApplySendBack] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetRealFinishDate(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strRealFinishDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRealFinishDate, 14, convcc_WorkStuRelation.RealFinishDate);
objvcc_WorkStuRelationEN.RealFinishDate = strRealFinishDate; //实际完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.RealFinishDate) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.RealFinishDate, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.RealFinishDate] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetOperateTime(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strOperateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOperateTime, 14, convcc_WorkStuRelation.OperateTime);
objvcc_WorkStuRelationEN.OperateTime = strOperateTime; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.OperateTime) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.OperateTime, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.OperateTime] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetScore(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, double dblScore, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.Score) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.Score, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.Score] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetComment(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strComment, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.Comment = strComment; //批注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.Comment) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.Comment, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.Comment] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetIsMarking(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, bool bolIsMarking, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.IsMarking = bolIsMarking; //是否批阅
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.IsMarking) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.IsMarking, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.IsMarking] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetMarkerId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strMarkerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkerId, 20, convcc_WorkStuRelation.MarkerId);
objvcc_WorkStuRelationEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.MarkerId) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.MarkerId, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.MarkerId] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetMarkDate(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strMarkDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkDate, 14, convcc_WorkStuRelation.MarkDate);
objvcc_WorkStuRelationEN.MarkDate = strMarkDate; //打分日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.MarkDate) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.MarkDate, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.MarkDate] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetIsSendBack(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, bool bolIsSendBack, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.IsSendBack = bolIsSendBack; //是否退回
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.IsSendBack) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.IsSendBack, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.IsSendBack] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetIsInErrorQuestion(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, bool bolIsInErrorQuestion, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.IsInErrorQuestion = bolIsInErrorQuestion; //是否进入错题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.IsInErrorQuestion) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.IsInErrorQuestion, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.IsInErrorQuestion] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetWorkTypeId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strWorkTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWorkTypeId, 2, convcc_WorkStuRelation.WorkTypeId);
clsCheckSql.CheckFieldForeignKey(strWorkTypeId, 2, convcc_WorkStuRelation.WorkTypeId);
objvcc_WorkStuRelationEN.WorkTypeId = strWorkTypeId; //作业类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.WorkTypeId) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.WorkTypeId, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.WorkTypeId] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetAnswerIP(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strAnswerIP, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerIP, 30, convcc_WorkStuRelation.AnswerIP);
objvcc_WorkStuRelationEN.AnswerIP = strAnswerIP; //回答IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.AnswerIP) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.AnswerIP, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.AnswerIP] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetAnswerDate(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strAnswerDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, convcc_WorkStuRelation.AnswerDate);
objvcc_WorkStuRelationEN.AnswerDate = strAnswerDate; //回答日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.AnswerDate) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.AnswerDate, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.AnswerDate] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetAnswerTime(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strAnswerTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, convcc_WorkStuRelation.AnswerTime);
objvcc_WorkStuRelationEN.AnswerTime = strAnswerTime; //回答时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.AnswerTime) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.AnswerTime, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.AnswerTime] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetCourseExamPaperId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convcc_WorkStuRelation.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convcc_WorkStuRelation.CourseExamPaperId);
objvcc_WorkStuRelationEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.CourseExamPaperId) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.CourseExamPaperId, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.CourseExamPaperId] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetIsRight(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, bool bolIsRight, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.IsRight) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.IsRight, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.IsRight] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetIsAccessKnowledge(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, bool bolIsAccessKnowledge, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.IsAccessKnowledge = bolIsAccessKnowledge; //是否处理知识点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.IsAccessKnowledge) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.IsAccessKnowledge, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.IsAccessKnowledge] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetIsNotProcessTimeout(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, bool bolIsNotProcessTimeout, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.IsNotProcessTimeout = bolIsNotProcessTimeout; //是否不处理超时
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.IsNotProcessTimeout) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.IsNotProcessTimeout, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.IsNotProcessTimeout] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetSchoolYear(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convcc_WorkStuRelation.SchoolYear);
objvcc_WorkStuRelationEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.SchoolYear) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.SchoolYear, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.SchoolYear] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetSchoolTerm(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convcc_WorkStuRelation.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convcc_WorkStuRelation.SchoolTerm);
objvcc_WorkStuRelationEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.SchoolTerm) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.SchoolTerm, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.SchoolTerm] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetErrMsg(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 200, convcc_WorkStuRelation.ErrMsg);
objvcc_WorkStuRelationEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.ErrMsg) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.ErrMsg, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.ErrMsg] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetUpdDate(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_WorkStuRelation.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_WorkStuRelation.UpdDate);
objvcc_WorkStuRelationEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.UpdDate) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.UpdDate, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.UpdDate] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetUpdUserId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_WorkStuRelation.UpdUserId);
objvcc_WorkStuRelationEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.UpdUserId) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.UpdUserId, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.UpdUserId] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetMemo(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_WorkStuRelation.Memo);
objvcc_WorkStuRelationEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.Memo) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.Memo, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.Memo] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelation_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.Id_WorkStuRelation) == true)
{
string strComparisonOp_Id_WorkStuRelation = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.Id_WorkStuRelation];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation.Id_WorkStuRelation, objvcc_WorkStuRelation_Cond.Id_WorkStuRelation, strComparisonOp_Id_WorkStuRelation);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.id_CurrEduCls, objvcc_WorkStuRelation_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.Id_WorkEduClsRela) == true)
{
string strComparisonOp_Id_WorkEduClsRela = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.Id_WorkEduClsRela];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation.Id_WorkEduClsRela, objvcc_WorkStuRelation_Cond.Id_WorkEduClsRela, strComparisonOp_Id_WorkEduClsRela);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.QuestionID, objvcc_WorkStuRelation_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation.QuestionIndex, objvcc_WorkStuRelation_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.QuestionName, objvcc_WorkStuRelation_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.QuestionContent) == true)
{
string strComparisonOp_QuestionContent = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.QuestionContent, objvcc_WorkStuRelation_Cond.QuestionContent, strComparisonOp_QuestionContent);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.CourseId, objvcc_WorkStuRelation_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.CourseName, objvcc_WorkStuRelation_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.CourseChapterId, objvcc_WorkStuRelation_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.CourseChapterName, objvcc_WorkStuRelation_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.ChapterName, objvcc_WorkStuRelation_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.SectionName) == true)
{
string strComparisonOp_SectionName = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.SectionName, objvcc_WorkStuRelation_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.ChapterName_Sim, objvcc_WorkStuRelation_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.SectionName_Sim, objvcc_WorkStuRelation_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.ParentNodeID, objvcc_WorkStuRelation_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.CourseChapterReferred) == true)
{
string strComparisonOp_CourseChapterReferred = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.CourseChapterReferred, objvcc_WorkStuRelation_Cond.CourseChapterReferred, strComparisonOp_CourseChapterReferred);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.ParentNodeName, objvcc_WorkStuRelation_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.ParentNodeReferred) == true)
{
string strComparisonOp_ParentNodeReferred = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.ParentNodeReferred, objvcc_WorkStuRelation_Cond.ParentNodeReferred, strComparisonOp_ParentNodeReferred);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.QuestionTypeId, objvcc_WorkStuRelation_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.QuestionTypeName, objvcc_WorkStuRelation_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.AnswerTypeId) == true)
{
string strComparisonOp_AnswerTypeId = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.AnswerTypeId, objvcc_WorkStuRelation_Cond.AnswerTypeId, strComparisonOp_AnswerTypeId);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.DefaultValue) == true)
{
string strComparisonOp_DefaultValue = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.DefaultValue, objvcc_WorkStuRelation_Cond.DefaultValue, strComparisonOp_DefaultValue);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.TextDirectId) == true)
{
string strComparisonOp_TextDirectId = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.TextDirectId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.TextDirectId, objvcc_WorkStuRelation_Cond.TextDirectId, strComparisonOp_TextDirectId);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.RelaEvent) == true)
{
string strComparisonOp_RelaEvent = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.RelaEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.RelaEvent, objvcc_WorkStuRelation_Cond.RelaEvent, strComparisonOp_RelaEvent);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.CheckBoxLimitCount) == true)
{
string strComparisonOp_CheckBoxLimitCount = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.CheckBoxLimitCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation.CheckBoxLimitCount, objvcc_WorkStuRelation_Cond.CheckBoxLimitCount, strComparisonOp_CheckBoxLimitCount);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.AnswerAttLimitSize) == true)
{
string strComparisonOp_AnswerAttLimitSize = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.AnswerAttLimitSize];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation.AnswerAttLimitSize, objvcc_WorkStuRelation_Cond.AnswerAttLimitSize, strComparisonOp_AnswerAttLimitSize);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.LimitedResourceType) == true)
{
string strComparisonOp_LimitedResourceType = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.LimitedResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.LimitedResourceType, objvcc_WorkStuRelation_Cond.LimitedResourceType, strComparisonOp_LimitedResourceType);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.QuestionTypeId4Course) == true)
{
string strComparisonOp_QuestionTypeId4Course = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.QuestionTypeId4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.QuestionTypeId4Course, objvcc_WorkStuRelation_Cond.QuestionTypeId4Course, strComparisonOp_QuestionTypeId4Course);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.QuestionTypeName4Course) == true)
{
string strComparisonOp_QuestionTypeName4Course = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.QuestionTypeName4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.QuestionTypeName4Course, objvcc_WorkStuRelation_Cond.QuestionTypeName4Course, strComparisonOp_QuestionTypeName4Course);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.CurrEduClsId) == true)
{
string strComparisonOp_CurrEduClsId = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.CurrEduClsId, objvcc_WorkStuRelation_Cond.CurrEduClsId, strComparisonOp_CurrEduClsId);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.EduClsName, objvcc_WorkStuRelation_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.TeacherID, objvcc_WorkStuRelation_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.PubDate) == true)
{
string strComparisonOp_PubDate = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.PubDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.PubDate, objvcc_WorkStuRelation_Cond.PubDate, strComparisonOp_PubDate);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.IsCurrEduCls) == true)
{
if (objvcc_WorkStuRelation_Cond.IsCurrEduCls == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsCurrEduCls);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsCurrEduCls);
}
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.IsGroupWork) == true)
{
if (objvcc_WorkStuRelation_Cond.IsGroupWork == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsGroupWork);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsGroupWork);
}
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.CourseStudentGroupId) == true)
{
string strComparisonOp_CourseStudentGroupId = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.CourseStudentGroupId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation.CourseStudentGroupId, objvcc_WorkStuRelation_Cond.CourseStudentGroupId, strComparisonOp_CourseStudentGroupId);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.WorkTypeName) == true)
{
string strComparisonOp_WorkTypeName = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.WorkTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.WorkTypeName, objvcc_WorkStuRelation_Cond.WorkTypeName, strComparisonOp_WorkTypeName);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.Scores) == true)
{
string strComparisonOp_Scores = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation.Scores, objvcc_WorkStuRelation_Cond.Scores, strComparisonOp_Scores);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.SpecifyCompletionDate) == true)
{
string strComparisonOp_SpecifyCompletionDate = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.SpecifyCompletionDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.SpecifyCompletionDate, objvcc_WorkStuRelation_Cond.SpecifyCompletionDate, strComparisonOp_SpecifyCompletionDate);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.id_StudentInfo, objvcc_WorkStuRelation_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.StuID) == true)
{
string strComparisonOp_StuID = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.StuID, objvcc_WorkStuRelation_Cond.StuID, strComparisonOp_StuID);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.StuName) == true)
{
string strComparisonOp_StuName = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.StuName, objvcc_WorkStuRelation_Cond.StuName, strComparisonOp_StuName);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.id_XzCollege, objvcc_WorkStuRelation_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.CollegeName, objvcc_WorkStuRelation_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.CollegeNameA, objvcc_WorkStuRelation_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.id_XzMajor, objvcc_WorkStuRelation_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.MajorID) == true)
{
string strComparisonOp_MajorID = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.MajorID, objvcc_WorkStuRelation_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.MajorName) == true)
{
string strComparisonOp_MajorName = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.MajorName, objvcc_WorkStuRelation_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.id_GradeBase, objvcc_WorkStuRelation_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.GradeBaseName, objvcc_WorkStuRelation_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.AdminClsName) == true)
{
string strComparisonOp_AdminClsName = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.AdminClsName, objvcc_WorkStuRelation_Cond.AdminClsName, strComparisonOp_AdminClsName);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.AdminClsId) == true)
{
string strComparisonOp_AdminClsId = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.AdminClsId, objvcc_WorkStuRelation_Cond.AdminClsId, strComparisonOp_AdminClsId);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.AnswerModeId) == true)
{
string strComparisonOp_AnswerModeId = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.AnswerModeId, objvcc_WorkStuRelation_Cond.AnswerModeId, strComparisonOp_AnswerModeId);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.AnswerOptionId) == true)
{
string strComparisonOp_AnswerOptionId = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.AnswerOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.AnswerOptionId, objvcc_WorkStuRelation_Cond.AnswerOptionId, strComparisonOp_AnswerOptionId);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.AnswerMultiOptions) == true)
{
string strComparisonOp_AnswerMultiOptions = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.AnswerMultiOptions];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.AnswerMultiOptions, objvcc_WorkStuRelation_Cond.AnswerMultiOptions, strComparisonOp_AnswerMultiOptions);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.AnswerBoolResult) == true)
{
if (objvcc_WorkStuRelation_Cond.AnswerBoolResult == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.AnswerBoolResult);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.AnswerBoolResult);
}
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.IsPublish) == true)
{
if (objvcc_WorkStuRelation_Cond.IsPublish == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsPublish);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsPublish);
}
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.IsLook) == true)
{
if (objvcc_WorkStuRelation_Cond.IsLook == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsLook);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsLook);
}
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.IsSave) == true)
{
if (objvcc_WorkStuRelation_Cond.IsSave == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsSave);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsSave);
}
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.IsSubmit) == true)
{
if (objvcc_WorkStuRelation_Cond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsSubmit);
}
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.ApplySendBackDate) == true)
{
string strComparisonOp_ApplySendBackDate = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.ApplySendBackDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.ApplySendBackDate, objvcc_WorkStuRelation_Cond.ApplySendBackDate, strComparisonOp_ApplySendBackDate);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.IsApplySendBack) == true)
{
if (objvcc_WorkStuRelation_Cond.IsApplySendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsApplySendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsApplySendBack);
}
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.RealFinishDate) == true)
{
string strComparisonOp_RealFinishDate = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.RealFinishDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.RealFinishDate, objvcc_WorkStuRelation_Cond.RealFinishDate, strComparisonOp_RealFinishDate);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.OperateTime) == true)
{
string strComparisonOp_OperateTime = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.OperateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.OperateTime, objvcc_WorkStuRelation_Cond.OperateTime, strComparisonOp_OperateTime);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.Score) == true)
{
string strComparisonOp_Score = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation.Score, objvcc_WorkStuRelation_Cond.Score, strComparisonOp_Score);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.IsMarking) == true)
{
if (objvcc_WorkStuRelation_Cond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsMarking);
}
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.MarkerId) == true)
{
string strComparisonOp_MarkerId = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.MarkerId, objvcc_WorkStuRelation_Cond.MarkerId, strComparisonOp_MarkerId);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.MarkDate) == true)
{
string strComparisonOp_MarkDate = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.MarkDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.MarkDate, objvcc_WorkStuRelation_Cond.MarkDate, strComparisonOp_MarkDate);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.IsSendBack) == true)
{
if (objvcc_WorkStuRelation_Cond.IsSendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsSendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsSendBack);
}
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.IsInErrorQuestion) == true)
{
if (objvcc_WorkStuRelation_Cond.IsInErrorQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsInErrorQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsInErrorQuestion);
}
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.WorkTypeId) == true)
{
string strComparisonOp_WorkTypeId = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.WorkTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.WorkTypeId, objvcc_WorkStuRelation_Cond.WorkTypeId, strComparisonOp_WorkTypeId);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.AnswerIP) == true)
{
string strComparisonOp_AnswerIP = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.AnswerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.AnswerIP, objvcc_WorkStuRelation_Cond.AnswerIP, strComparisonOp_AnswerIP);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.AnswerDate) == true)
{
string strComparisonOp_AnswerDate = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.AnswerDate, objvcc_WorkStuRelation_Cond.AnswerDate, strComparisonOp_AnswerDate);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.AnswerTime) == true)
{
string strComparisonOp_AnswerTime = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.AnswerTime, objvcc_WorkStuRelation_Cond.AnswerTime, strComparisonOp_AnswerTime);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.CourseExamPaperId, objvcc_WorkStuRelation_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.IsRight) == true)
{
if (objvcc_WorkStuRelation_Cond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsRight);
}
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.IsAccessKnowledge) == true)
{
if (objvcc_WorkStuRelation_Cond.IsAccessKnowledge == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsAccessKnowledge);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsAccessKnowledge);
}
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.IsNotProcessTimeout) == true)
{
if (objvcc_WorkStuRelation_Cond.IsNotProcessTimeout == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsNotProcessTimeout);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsNotProcessTimeout);
}
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.SchoolYear, objvcc_WorkStuRelation_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.SchoolTerm, objvcc_WorkStuRelation_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.ErrMsg) == true)
{
string strComparisonOp_ErrMsg = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.ErrMsg, objvcc_WorkStuRelation_Cond.ErrMsg, strComparisonOp_ErrMsg);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.UpdDate, objvcc_WorkStuRelation_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.UpdUserId, objvcc_WorkStuRelation_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvcc_WorkStuRelation_Cond.IsUpdated(convcc_WorkStuRelation.Memo) == true)
{
string strComparisonOp_Memo = objvcc_WorkStuRelation_Cond.dicFldComparisonOp[convcc_WorkStuRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.Memo, objvcc_WorkStuRelation_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v作业与学生关系表(vcc_WorkStuRelation)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_WorkStuRelationWApi
{
private static readonly string mstrApiControllerName = "vcc_WorkStuRelationApi";

 public clsvcc_WorkStuRelationWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_WorkStuRelation">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkStuRelationEN GetObjById_WorkStuRelation(long lngId_WorkStuRelation)
{
string strAction = "GetObjById_WorkStuRelation";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkStuRelation"] = lngId_WorkStuRelation.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_WorkStuRelationEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelationEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelationEN;
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
 /// <param name = "lngId_WorkStuRelation">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkStuRelationEN GetObjById_WorkStuRelation_WA_Cache(long lngId_WorkStuRelation)
{
string strAction = "GetObjById_WorkStuRelation_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkStuRelation"] = lngId_WorkStuRelation.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_WorkStuRelationEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelationEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelationEN;
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
public static clsvcc_WorkStuRelationEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = null;
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
objvcc_WorkStuRelationEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelationEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelationEN;
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
 /// <param name = "lngId_WorkStuRelation">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkStuRelationEN GetObjById_WorkStuRelation_Cache(long lngId_WorkStuRelation)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_WorkStuRelationEN._CurrTabName_S);
List<clsvcc_WorkStuRelationEN> arrvcc_WorkStuRelationObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_WorkStuRelationEN> arrvcc_WorkStuRelationObjLst_Sel =
from objvcc_WorkStuRelationEN in arrvcc_WorkStuRelationObjLst_Cache
where objvcc_WorkStuRelationEN.Id_WorkStuRelation == lngId_WorkStuRelation
select objvcc_WorkStuRelationEN;
if (arrvcc_WorkStuRelationObjLst_Sel.Count() == 0)
{
   clsvcc_WorkStuRelationEN obj = clsvcc_WorkStuRelationWApi.GetObjById_WorkStuRelation(lngId_WorkStuRelation);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_WorkStuRelationObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelationEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_WorkStuRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelationEN> GetObjLstById_WorkStuRelationLst(List<long> arrId_WorkStuRelation)
{
 List<clsvcc_WorkStuRelationEN> arrObjLst = null; 
string strAction = "GetObjLstById_WorkStuRelationLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WorkStuRelation);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngId_WorkStuRelation">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_WorkStuRelationEN> GetObjLstById_WorkStuRelationLst_Cache(List<long> arrId_WorkStuRelation)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_WorkStuRelationEN._CurrTabName_S);
List<clsvcc_WorkStuRelationEN> arrvcc_WorkStuRelationObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_WorkStuRelationEN> arrvcc_WorkStuRelationObjLst_Sel =
from objvcc_WorkStuRelationEN in arrvcc_WorkStuRelationObjLst_Cache
where arrId_WorkStuRelation.Contains(objvcc_WorkStuRelationEN.Id_WorkStuRelation)
select objvcc_WorkStuRelationEN;
return arrvcc_WorkStuRelationObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelationEN> GetObjLstById_WorkStuRelationLst_WA_Cache(List<long> arrId_WorkStuRelation)
{
 List<clsvcc_WorkStuRelationEN> arrObjLst = null; 
string strAction = "GetObjLstById_WorkStuRelationLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WorkStuRelation);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelationEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_WorkStuRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelationEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_WorkStuRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkStuRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelationEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkStuRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngId_WorkStuRelation)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkStuRelation"] = lngId_WorkStuRelation.ToString()
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
 /// <param name = "objvcc_WorkStuRelationENS">源对象</param>
 /// <param name = "objvcc_WorkStuRelationENT">目标对象</param>
 public static void CopyTo(clsvcc_WorkStuRelationEN objvcc_WorkStuRelationENS, clsvcc_WorkStuRelationEN objvcc_WorkStuRelationENT)
{
try
{
objvcc_WorkStuRelationENT.Id_WorkStuRelation = objvcc_WorkStuRelationENS.Id_WorkStuRelation; //流水号
objvcc_WorkStuRelationENT.id_CurrEduCls = objvcc_WorkStuRelationENS.id_CurrEduCls; //当前教学班流水号
objvcc_WorkStuRelationENT.Id_WorkEduClsRela = objvcc_WorkStuRelationENS.Id_WorkEduClsRela; //作业教学班关系流水号
objvcc_WorkStuRelationENT.QuestionID = objvcc_WorkStuRelationENS.QuestionID; //题目ID
objvcc_WorkStuRelationENT.QuestionIndex = objvcc_WorkStuRelationENS.QuestionIndex; //题目序号
objvcc_WorkStuRelationENT.QuestionName = objvcc_WorkStuRelationENS.QuestionName; //题目名称
objvcc_WorkStuRelationENT.QuestionContent = objvcc_WorkStuRelationENS.QuestionContent; //题目内容
objvcc_WorkStuRelationENT.CourseId = objvcc_WorkStuRelationENS.CourseId; //课程Id
objvcc_WorkStuRelationENT.CourseName = objvcc_WorkStuRelationENS.CourseName; //课程名称
objvcc_WorkStuRelationENT.CourseChapterId = objvcc_WorkStuRelationENS.CourseChapterId; //课程章节ID
objvcc_WorkStuRelationENT.CourseChapterName = objvcc_WorkStuRelationENS.CourseChapterName; //课程章节名称
objvcc_WorkStuRelationENT.ChapterName = objvcc_WorkStuRelationENS.ChapterName; //章名
objvcc_WorkStuRelationENT.SectionName = objvcc_WorkStuRelationENS.SectionName; //节名
objvcc_WorkStuRelationENT.ChapterName_Sim = objvcc_WorkStuRelationENS.ChapterName_Sim; //章名简称
objvcc_WorkStuRelationENT.SectionName_Sim = objvcc_WorkStuRelationENS.SectionName_Sim; //节名简称
objvcc_WorkStuRelationENT.ParentNodeID = objvcc_WorkStuRelationENS.ParentNodeID; //父节点编号
objvcc_WorkStuRelationENT.CourseChapterReferred = objvcc_WorkStuRelationENS.CourseChapterReferred; //节简称
objvcc_WorkStuRelationENT.ParentNodeName = objvcc_WorkStuRelationENS.ParentNodeName; //父节点名称
objvcc_WorkStuRelationENT.ParentNodeReferred = objvcc_WorkStuRelationENS.ParentNodeReferred; //章简称
objvcc_WorkStuRelationENT.QuestionTypeId = objvcc_WorkStuRelationENS.QuestionTypeId; //题目类型Id
objvcc_WorkStuRelationENT.QuestionTypeName = objvcc_WorkStuRelationENS.QuestionTypeName; //题目类型名
objvcc_WorkStuRelationENT.AnswerTypeId = objvcc_WorkStuRelationENS.AnswerTypeId; //答案类型ID
objvcc_WorkStuRelationENT.DefaultValue = objvcc_WorkStuRelationENS.DefaultValue; //缺省值
objvcc_WorkStuRelationENT.TextDirectId = objvcc_WorkStuRelationENS.TextDirectId; //文本方向ID
objvcc_WorkStuRelationENT.RelaEvent = objvcc_WorkStuRelationENS.RelaEvent; //相关事件
objvcc_WorkStuRelationENT.CheckBoxLimitCount = objvcc_WorkStuRelationENS.CheckBoxLimitCount; //复选框限制数
objvcc_WorkStuRelationENT.AnswerAttLimitSize = objvcc_WorkStuRelationENS.AnswerAttLimitSize; //回答附件限制大小
objvcc_WorkStuRelationENT.LimitedResourceType = objvcc_WorkStuRelationENS.LimitedResourceType; //限制资源类型
objvcc_WorkStuRelationENT.QuestionTypeId4Course = objvcc_WorkStuRelationENS.QuestionTypeId4Course; //题目类型Id4课程
objvcc_WorkStuRelationENT.QuestionTypeName4Course = objvcc_WorkStuRelationENS.QuestionTypeName4Course; //题目类型名4课程
objvcc_WorkStuRelationENT.CurrEduClsId = objvcc_WorkStuRelationENS.CurrEduClsId; //当前教学班Id
objvcc_WorkStuRelationENT.EduClsName = objvcc_WorkStuRelationENS.EduClsName; //教学班名称
objvcc_WorkStuRelationENT.TeacherID = objvcc_WorkStuRelationENS.TeacherID; //教师工号
objvcc_WorkStuRelationENT.PubDate = objvcc_WorkStuRelationENS.PubDate; //发布日期
objvcc_WorkStuRelationENT.IsCurrEduCls = objvcc_WorkStuRelationENS.IsCurrEduCls; //是否为教学班作业
objvcc_WorkStuRelationENT.IsGroupWork = objvcc_WorkStuRelationENS.IsGroupWork; //是否为小组作业
objvcc_WorkStuRelationENT.CourseStudentGroupId = objvcc_WorkStuRelationENS.CourseStudentGroupId; //学生分组表流水号
objvcc_WorkStuRelationENT.WorkTypeName = objvcc_WorkStuRelationENS.WorkTypeName; //作业类型名称
objvcc_WorkStuRelationENT.Scores = objvcc_WorkStuRelationENS.Scores; //分值
objvcc_WorkStuRelationENT.SpecifyCompletionDate = objvcc_WorkStuRelationENS.SpecifyCompletionDate; //指定完成日期
objvcc_WorkStuRelationENT.id_StudentInfo = objvcc_WorkStuRelationENS.id_StudentInfo; //学生流水号
objvcc_WorkStuRelationENT.StuID = objvcc_WorkStuRelationENS.StuID; //学号
objvcc_WorkStuRelationENT.StuName = objvcc_WorkStuRelationENS.StuName; //姓名
objvcc_WorkStuRelationENT.id_XzCollege = objvcc_WorkStuRelationENS.id_XzCollege; //学院流水号
objvcc_WorkStuRelationENT.CollegeName = objvcc_WorkStuRelationENS.CollegeName; //学院名称
objvcc_WorkStuRelationENT.CollegeNameA = objvcc_WorkStuRelationENS.CollegeNameA; //学院名称简写
objvcc_WorkStuRelationENT.id_XzMajor = objvcc_WorkStuRelationENS.id_XzMajor; //专业流水号
objvcc_WorkStuRelationENT.MajorID = objvcc_WorkStuRelationENS.MajorID; //专业ID
objvcc_WorkStuRelationENT.MajorName = objvcc_WorkStuRelationENS.MajorName; //专业名称
objvcc_WorkStuRelationENT.id_GradeBase = objvcc_WorkStuRelationENS.id_GradeBase; //年级流水号
objvcc_WorkStuRelationENT.GradeBaseName = objvcc_WorkStuRelationENS.GradeBaseName; //年级名称
objvcc_WorkStuRelationENT.AdminClsName = objvcc_WorkStuRelationENS.AdminClsName; //行政班名称
objvcc_WorkStuRelationENT.AdminClsId = objvcc_WorkStuRelationENS.AdminClsId; //行政班代号
objvcc_WorkStuRelationENT.AnswerModeId = objvcc_WorkStuRelationENS.AnswerModeId; //答案模式Id
objvcc_WorkStuRelationENT.AnswerOptionId = objvcc_WorkStuRelationENS.AnswerOptionId; //回答选项Id
objvcc_WorkStuRelationENT.AnswerMultiOptions = objvcc_WorkStuRelationENS.AnswerMultiOptions; //多选项答案
objvcc_WorkStuRelationENT.AnswerBoolResult = objvcc_WorkStuRelationENS.AnswerBoolResult; //答案布尔结果
objvcc_WorkStuRelationENT.StuAnswerText = objvcc_WorkStuRelationENS.StuAnswerText; //学生回答文本
objvcc_WorkStuRelationENT.IsPublish = objvcc_WorkStuRelationENS.IsPublish; //是否发布
objvcc_WorkStuRelationENT.IsLook = objvcc_WorkStuRelationENS.IsLook; //是否查看
objvcc_WorkStuRelationENT.IsSave = objvcc_WorkStuRelationENS.IsSave; //是否保存
objvcc_WorkStuRelationENT.IsSubmit = objvcc_WorkStuRelationENS.IsSubmit; //是否提交
objvcc_WorkStuRelationENT.ApplySendBackDate = objvcc_WorkStuRelationENS.ApplySendBackDate; //申请退回日期
objvcc_WorkStuRelationENT.IsApplySendBack = objvcc_WorkStuRelationENS.IsApplySendBack; //是否申请退回
objvcc_WorkStuRelationENT.RealFinishDate = objvcc_WorkStuRelationENS.RealFinishDate; //实际完成日期
objvcc_WorkStuRelationENT.OperateTime = objvcc_WorkStuRelationENS.OperateTime; //操作时间
objvcc_WorkStuRelationENT.Score = objvcc_WorkStuRelationENS.Score; //得分
objvcc_WorkStuRelationENT.Comment = objvcc_WorkStuRelationENS.Comment; //批注
objvcc_WorkStuRelationENT.IsMarking = objvcc_WorkStuRelationENS.IsMarking; //是否批阅
objvcc_WorkStuRelationENT.MarkerId = objvcc_WorkStuRelationENS.MarkerId; //打分者
objvcc_WorkStuRelationENT.MarkDate = objvcc_WorkStuRelationENS.MarkDate; //打分日期
objvcc_WorkStuRelationENT.IsSendBack = objvcc_WorkStuRelationENS.IsSendBack; //是否退回
objvcc_WorkStuRelationENT.IsInErrorQuestion = objvcc_WorkStuRelationENS.IsInErrorQuestion; //是否进入错题
objvcc_WorkStuRelationENT.WorkTypeId = objvcc_WorkStuRelationENS.WorkTypeId; //作业类型Id
objvcc_WorkStuRelationENT.AnswerIP = objvcc_WorkStuRelationENS.AnswerIP; //回答IP
objvcc_WorkStuRelationENT.AnswerDate = objvcc_WorkStuRelationENS.AnswerDate; //回答日期
objvcc_WorkStuRelationENT.AnswerTime = objvcc_WorkStuRelationENS.AnswerTime; //回答时间
objvcc_WorkStuRelationENT.CourseExamPaperId = objvcc_WorkStuRelationENS.CourseExamPaperId; //考卷流水号
objvcc_WorkStuRelationENT.IsRight = objvcc_WorkStuRelationENS.IsRight; //是否正确
objvcc_WorkStuRelationENT.IsAccessKnowledge = objvcc_WorkStuRelationENS.IsAccessKnowledge; //是否处理知识点
objvcc_WorkStuRelationENT.IsNotProcessTimeout = objvcc_WorkStuRelationENS.IsNotProcessTimeout; //是否不处理超时
objvcc_WorkStuRelationENT.SchoolYear = objvcc_WorkStuRelationENS.SchoolYear; //学年
objvcc_WorkStuRelationENT.SchoolTerm = objvcc_WorkStuRelationENS.SchoolTerm; //学期
objvcc_WorkStuRelationENT.ErrMsg = objvcc_WorkStuRelationENS.ErrMsg; //错误信息
objvcc_WorkStuRelationENT.UpdDate = objvcc_WorkStuRelationENS.UpdDate; //修改日期
objvcc_WorkStuRelationENT.UpdUserId = objvcc_WorkStuRelationENS.UpdUserId; //修改用户Id
objvcc_WorkStuRelationENT.Memo = objvcc_WorkStuRelationENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvcc_WorkStuRelationEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_WorkStuRelationEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_WorkStuRelationEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_WorkStuRelationEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_WorkStuRelationEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_WorkStuRelationEN.AttributeName)
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
if (clscc_WorkStuRelationWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkStuRelationWApi没有刷新缓存机制(clscc_WorkStuRelationWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzUniZoneWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneWApi没有刷新缓存机制(clsXzUniZoneWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexWApi没有刷新缓存机制(clsSexWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicWApi没有刷新缓存机制(clsRsEthnicWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsWApi没有刷新缓存机制(clsRsPoliticsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoWApi没有刷新缓存机制(clsStudentInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStuTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStuTypeWApi没有刷新缓存机制(clsRsStuTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
if (clsXzAdminClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsWApi没有刷新缓存机制(clsXzAdminClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeWApi没有刷新缓存机制(clsXzAdminClsTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by Id_WorkStuRelation");
//if (arrvcc_WorkStuRelationObjLst_Cache == null)
//{
//arrvcc_WorkStuRelationObjLst_Cache = await clsvcc_WorkStuRelationWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvcc_WorkStuRelationEN._CurrTabName_S);
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
public static List<clsvcc_WorkStuRelationEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcc_WorkStuRelationEN._CurrTabName_S);
List<clsvcc_WorkStuRelationEN> arrvcc_WorkStuRelationObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_WorkStuRelationObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_WorkStuRelationEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_WorkStuRelation.Id_WorkStuRelation, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_WorkStuRelation.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.Id_WorkEduClsRela, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_WorkStuRelation.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkStuRelation.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.QuestionContent, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.CourseChapterReferred, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.ParentNodeReferred, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.AnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.TextDirectId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.RelaEvent, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.CheckBoxLimitCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_WorkStuRelation.AnswerAttLimitSize, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_WorkStuRelation.LimitedResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.QuestionTypeId4Course, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.QuestionTypeName4Course, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.CurrEduClsId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.PubDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.IsCurrEduCls, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkStuRelation.IsGroupWork, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkStuRelation.CourseStudentGroupId, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_WorkStuRelation.WorkTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.Scores, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_WorkStuRelation.SpecifyCompletionDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.AdminClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.AdminClsId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.AnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.AnswerOptionId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.AnswerMultiOptions, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.AnswerBoolResult, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkStuRelation.StuAnswerText, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.IsPublish, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkStuRelation.IsLook, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkStuRelation.IsSave, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkStuRelation.IsSubmit, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkStuRelation.ApplySendBackDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.IsApplySendBack, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkStuRelation.RealFinishDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.OperateTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.Score, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_WorkStuRelation.Comment, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.IsMarking, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkStuRelation.MarkerId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.MarkDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.IsSendBack, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkStuRelation.IsInErrorQuestion, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkStuRelation.WorkTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.AnswerIP, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.AnswerDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.AnswerTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.IsRight, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkStuRelation.IsAccessKnowledge, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkStuRelation.IsNotProcessTimeout, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_WorkStuRelation.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelation.Memo, Type.GetType("System.String"));
foreach (clsvcc_WorkStuRelationEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_WorkStuRelation.Id_WorkStuRelation] = objInFor[convcc_WorkStuRelation.Id_WorkStuRelation];
objDR[convcc_WorkStuRelation.id_CurrEduCls] = objInFor[convcc_WorkStuRelation.id_CurrEduCls];
objDR[convcc_WorkStuRelation.Id_WorkEduClsRela] = objInFor[convcc_WorkStuRelation.Id_WorkEduClsRela];
objDR[convcc_WorkStuRelation.QuestionID] = objInFor[convcc_WorkStuRelation.QuestionID];
objDR[convcc_WorkStuRelation.QuestionIndex] = objInFor[convcc_WorkStuRelation.QuestionIndex];
objDR[convcc_WorkStuRelation.QuestionName] = objInFor[convcc_WorkStuRelation.QuestionName];
objDR[convcc_WorkStuRelation.QuestionContent] = objInFor[convcc_WorkStuRelation.QuestionContent];
objDR[convcc_WorkStuRelation.CourseId] = objInFor[convcc_WorkStuRelation.CourseId];
objDR[convcc_WorkStuRelation.CourseName] = objInFor[convcc_WorkStuRelation.CourseName];
objDR[convcc_WorkStuRelation.CourseChapterId] = objInFor[convcc_WorkStuRelation.CourseChapterId];
objDR[convcc_WorkStuRelation.CourseChapterName] = objInFor[convcc_WorkStuRelation.CourseChapterName];
objDR[convcc_WorkStuRelation.ChapterName] = objInFor[convcc_WorkStuRelation.ChapterName];
objDR[convcc_WorkStuRelation.SectionName] = objInFor[convcc_WorkStuRelation.SectionName];
objDR[convcc_WorkStuRelation.ChapterName_Sim] = objInFor[convcc_WorkStuRelation.ChapterName_Sim];
objDR[convcc_WorkStuRelation.SectionName_Sim] = objInFor[convcc_WorkStuRelation.SectionName_Sim];
objDR[convcc_WorkStuRelation.ParentNodeID] = objInFor[convcc_WorkStuRelation.ParentNodeID];
objDR[convcc_WorkStuRelation.CourseChapterReferred] = objInFor[convcc_WorkStuRelation.CourseChapterReferred];
objDR[convcc_WorkStuRelation.ParentNodeName] = objInFor[convcc_WorkStuRelation.ParentNodeName];
objDR[convcc_WorkStuRelation.ParentNodeReferred] = objInFor[convcc_WorkStuRelation.ParentNodeReferred];
objDR[convcc_WorkStuRelation.QuestionTypeId] = objInFor[convcc_WorkStuRelation.QuestionTypeId];
objDR[convcc_WorkStuRelation.QuestionTypeName] = objInFor[convcc_WorkStuRelation.QuestionTypeName];
objDR[convcc_WorkStuRelation.AnswerTypeId] = objInFor[convcc_WorkStuRelation.AnswerTypeId];
objDR[convcc_WorkStuRelation.DefaultValue] = objInFor[convcc_WorkStuRelation.DefaultValue];
objDR[convcc_WorkStuRelation.TextDirectId] = objInFor[convcc_WorkStuRelation.TextDirectId];
objDR[convcc_WorkStuRelation.RelaEvent] = objInFor[convcc_WorkStuRelation.RelaEvent];
objDR[convcc_WorkStuRelation.CheckBoxLimitCount] = objInFor[convcc_WorkStuRelation.CheckBoxLimitCount];
objDR[convcc_WorkStuRelation.AnswerAttLimitSize] = objInFor[convcc_WorkStuRelation.AnswerAttLimitSize];
objDR[convcc_WorkStuRelation.LimitedResourceType] = objInFor[convcc_WorkStuRelation.LimitedResourceType];
objDR[convcc_WorkStuRelation.QuestionTypeId4Course] = objInFor[convcc_WorkStuRelation.QuestionTypeId4Course];
objDR[convcc_WorkStuRelation.QuestionTypeName4Course] = objInFor[convcc_WorkStuRelation.QuestionTypeName4Course];
objDR[convcc_WorkStuRelation.CurrEduClsId] = objInFor[convcc_WorkStuRelation.CurrEduClsId];
objDR[convcc_WorkStuRelation.EduClsName] = objInFor[convcc_WorkStuRelation.EduClsName];
objDR[convcc_WorkStuRelation.TeacherID] = objInFor[convcc_WorkStuRelation.TeacherID];
objDR[convcc_WorkStuRelation.PubDate] = objInFor[convcc_WorkStuRelation.PubDate];
objDR[convcc_WorkStuRelation.IsCurrEduCls] = objInFor[convcc_WorkStuRelation.IsCurrEduCls];
objDR[convcc_WorkStuRelation.IsGroupWork] = objInFor[convcc_WorkStuRelation.IsGroupWork];
objDR[convcc_WorkStuRelation.CourseStudentGroupId] = objInFor[convcc_WorkStuRelation.CourseStudentGroupId];
objDR[convcc_WorkStuRelation.WorkTypeName] = objInFor[convcc_WorkStuRelation.WorkTypeName];
objDR[convcc_WorkStuRelation.Scores] = objInFor[convcc_WorkStuRelation.Scores];
objDR[convcc_WorkStuRelation.SpecifyCompletionDate] = objInFor[convcc_WorkStuRelation.SpecifyCompletionDate];
objDR[convcc_WorkStuRelation.id_StudentInfo] = objInFor[convcc_WorkStuRelation.id_StudentInfo];
objDR[convcc_WorkStuRelation.StuID] = objInFor[convcc_WorkStuRelation.StuID];
objDR[convcc_WorkStuRelation.StuName] = objInFor[convcc_WorkStuRelation.StuName];
objDR[convcc_WorkStuRelation.id_XzCollege] = objInFor[convcc_WorkStuRelation.id_XzCollege];
objDR[convcc_WorkStuRelation.CollegeName] = objInFor[convcc_WorkStuRelation.CollegeName];
objDR[convcc_WorkStuRelation.CollegeNameA] = objInFor[convcc_WorkStuRelation.CollegeNameA];
objDR[convcc_WorkStuRelation.id_XzMajor] = objInFor[convcc_WorkStuRelation.id_XzMajor];
objDR[convcc_WorkStuRelation.MajorID] = objInFor[convcc_WorkStuRelation.MajorID];
objDR[convcc_WorkStuRelation.MajorName] = objInFor[convcc_WorkStuRelation.MajorName];
objDR[convcc_WorkStuRelation.id_GradeBase] = objInFor[convcc_WorkStuRelation.id_GradeBase];
objDR[convcc_WorkStuRelation.GradeBaseName] = objInFor[convcc_WorkStuRelation.GradeBaseName];
objDR[convcc_WorkStuRelation.AdminClsName] = objInFor[convcc_WorkStuRelation.AdminClsName];
objDR[convcc_WorkStuRelation.AdminClsId] = objInFor[convcc_WorkStuRelation.AdminClsId];
objDR[convcc_WorkStuRelation.AnswerModeId] = objInFor[convcc_WorkStuRelation.AnswerModeId];
objDR[convcc_WorkStuRelation.AnswerOptionId] = objInFor[convcc_WorkStuRelation.AnswerOptionId];
objDR[convcc_WorkStuRelation.AnswerMultiOptions] = objInFor[convcc_WorkStuRelation.AnswerMultiOptions];
objDR[convcc_WorkStuRelation.AnswerBoolResult] = objInFor[convcc_WorkStuRelation.AnswerBoolResult];
objDR[convcc_WorkStuRelation.StuAnswerText] = objInFor[convcc_WorkStuRelation.StuAnswerText];
objDR[convcc_WorkStuRelation.IsPublish] = objInFor[convcc_WorkStuRelation.IsPublish];
objDR[convcc_WorkStuRelation.IsLook] = objInFor[convcc_WorkStuRelation.IsLook];
objDR[convcc_WorkStuRelation.IsSave] = objInFor[convcc_WorkStuRelation.IsSave];
objDR[convcc_WorkStuRelation.IsSubmit] = objInFor[convcc_WorkStuRelation.IsSubmit];
objDR[convcc_WorkStuRelation.ApplySendBackDate] = objInFor[convcc_WorkStuRelation.ApplySendBackDate];
objDR[convcc_WorkStuRelation.IsApplySendBack] = objInFor[convcc_WorkStuRelation.IsApplySendBack];
objDR[convcc_WorkStuRelation.RealFinishDate] = objInFor[convcc_WorkStuRelation.RealFinishDate];
objDR[convcc_WorkStuRelation.OperateTime] = objInFor[convcc_WorkStuRelation.OperateTime];
objDR[convcc_WorkStuRelation.Score] = objInFor[convcc_WorkStuRelation.Score];
objDR[convcc_WorkStuRelation.Comment] = objInFor[convcc_WorkStuRelation.Comment];
objDR[convcc_WorkStuRelation.IsMarking] = objInFor[convcc_WorkStuRelation.IsMarking];
objDR[convcc_WorkStuRelation.MarkerId] = objInFor[convcc_WorkStuRelation.MarkerId];
objDR[convcc_WorkStuRelation.MarkDate] = objInFor[convcc_WorkStuRelation.MarkDate];
objDR[convcc_WorkStuRelation.IsSendBack] = objInFor[convcc_WorkStuRelation.IsSendBack];
objDR[convcc_WorkStuRelation.IsInErrorQuestion] = objInFor[convcc_WorkStuRelation.IsInErrorQuestion];
objDR[convcc_WorkStuRelation.WorkTypeId] = objInFor[convcc_WorkStuRelation.WorkTypeId];
objDR[convcc_WorkStuRelation.AnswerIP] = objInFor[convcc_WorkStuRelation.AnswerIP];
objDR[convcc_WorkStuRelation.AnswerDate] = objInFor[convcc_WorkStuRelation.AnswerDate];
objDR[convcc_WorkStuRelation.AnswerTime] = objInFor[convcc_WorkStuRelation.AnswerTime];
objDR[convcc_WorkStuRelation.CourseExamPaperId] = objInFor[convcc_WorkStuRelation.CourseExamPaperId];
objDR[convcc_WorkStuRelation.IsRight] = objInFor[convcc_WorkStuRelation.IsRight];
objDR[convcc_WorkStuRelation.IsAccessKnowledge] = objInFor[convcc_WorkStuRelation.IsAccessKnowledge];
objDR[convcc_WorkStuRelation.IsNotProcessTimeout] = objInFor[convcc_WorkStuRelation.IsNotProcessTimeout];
objDR[convcc_WorkStuRelation.SchoolYear] = objInFor[convcc_WorkStuRelation.SchoolYear];
objDR[convcc_WorkStuRelation.SchoolTerm] = objInFor[convcc_WorkStuRelation.SchoolTerm];
objDR[convcc_WorkStuRelation.ErrMsg] = objInFor[convcc_WorkStuRelation.ErrMsg];
objDR[convcc_WorkStuRelation.UpdDate] = objInFor[convcc_WorkStuRelation.UpdDate];
objDR[convcc_WorkStuRelation.UpdUserId] = objInFor[convcc_WorkStuRelation.UpdUserId];
objDR[convcc_WorkStuRelation.Memo] = objInFor[convcc_WorkStuRelation.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}