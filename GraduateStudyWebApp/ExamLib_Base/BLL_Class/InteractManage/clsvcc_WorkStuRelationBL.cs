
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkStuRelationBL
 表名:vcc_WorkStuRelation(01120198)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
public static class  clsvcc_WorkStuRelationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdWorkStuRelation">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkStuRelationEN GetObj(this K_IdWorkStuRelation_vcc_WorkStuRelation myKey)
{
clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = clsvcc_WorkStuRelationBL.vcc_WorkStuRelationDA.GetObjByIdWorkStuRelation(myKey.Value);
return objvcc_WorkStuRelationEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetIdWorkStuRelation(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, long lngIdWorkStuRelation, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.IdWorkStuRelation = lngIdWorkStuRelation; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.IdWorkStuRelation) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.IdWorkStuRelation, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.IdWorkStuRelation] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetIdCurrEduCls(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, convcc_WorkStuRelation.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convcc_WorkStuRelation.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convcc_WorkStuRelation.IdCurrEduCls);
}
objvcc_WorkStuRelationEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.IdCurrEduCls) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.IdCurrEduCls, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.IdCurrEduCls] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetIdWorkEduClsRela(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, long? lngIdWorkEduClsRela, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.IdWorkEduClsRela = lngIdWorkEduClsRela; //作业教学班关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.IdWorkEduClsRela) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.IdWorkEduClsRela, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.IdWorkEduClsRela] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetQuestionId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, long? lngQuestionId, string strComparisonOp="")
	{
objvcc_WorkStuRelationEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.QuestionId) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.QuestionId, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.QuestionId] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetQuestionIndex(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, int? intQuestionIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetQuestionName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strQuestionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionName, 500, convcc_WorkStuRelation.QuestionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetQuestionContent(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strQuestionContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, convcc_WorkStuRelation.QuestionContent);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetCourseId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_WorkStuRelation.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_WorkStuRelation.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetCourseName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_WorkStuRelation.CourseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetCourseChapterId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_WorkStuRelation.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_WorkStuRelation.CourseChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetCourseChapterName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strCourseChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_WorkStuRelation.CourseChapterName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetChapterName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_WorkStuRelation.ChapterName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetSectionName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_WorkStuRelation.SectionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetChapterNameSim(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, convcc_WorkStuRelation.ChapterNameSim);
}
objvcc_WorkStuRelationEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.ChapterNameSim) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.ChapterNameSim, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.ChapterNameSim] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetSectionNameSim(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strSectionNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionNameSim, 10, convcc_WorkStuRelation.SectionNameSim);
}
objvcc_WorkStuRelationEN.SectionNameSim = strSectionNameSim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.SectionNameSim) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.SectionNameSim, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.SectionNameSim] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetParentNodeId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strParentNodeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeId, 8, convcc_WorkStuRelation.ParentNodeId);
}
objvcc_WorkStuRelationEN.ParentNodeId = strParentNodeId; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.ParentNodeId) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.ParentNodeId, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.ParentNodeId] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetCourseChapterReferred(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strCourseChapterReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convcc_WorkStuRelation.CourseChapterReferred);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetParentNodeName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strParentNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeName, 100, convcc_WorkStuRelation.ParentNodeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetParentNodeReferred(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strParentNodeReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convcc_WorkStuRelation.ParentNodeReferred);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetQuestionTypeId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convcc_WorkStuRelation.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convcc_WorkStuRelation.QuestionTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetQuestionTypeName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strQuestionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convcc_WorkStuRelation.QuestionTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetAnswerTypeId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strAnswerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convcc_WorkStuRelation.AnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convcc_WorkStuRelation.AnswerTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetDefaultValue(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strDefaultValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convcc_WorkStuRelation.DefaultValue);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetTextDirectId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strTextDirectId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextDirectId, 4, convcc_WorkStuRelation.TextDirectId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextDirectId, 4, convcc_WorkStuRelation.TextDirectId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetRelaEvent(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strRelaEvent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaEvent, 4000, convcc_WorkStuRelation.RelaEvent);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetCheckBoxLimitCount(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, int? intCheckBoxLimitCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetAnswerAttLimitSize(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, long? lngAnswerAttLimitSize, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetLimitedResourceType(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strLimitedResourceType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLimitedResourceType, 100, convcc_WorkStuRelation.LimitedResourceType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetQuestionTypeId4Course(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strQuestionTypeId4Course, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId4Course, 8, convcc_WorkStuRelation.QuestionTypeId4Course);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId4Course, 8, convcc_WorkStuRelation.QuestionTypeId4Course);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetQuestionTypeName4Course(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strQuestionTypeName4Course, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName4Course, 30, convcc_WorkStuRelation.QuestionTypeName4Course);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetCurrEduClsId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strCurrEduClsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convcc_WorkStuRelation.CurrEduClsId);
}
objvcc_WorkStuRelationEN.CurrEduClsId = strCurrEduClsId; //教学班Id
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetEduClsName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strEduClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convcc_WorkStuRelation.EduClsName);
}
objvcc_WorkStuRelationEN.EduClsName = strEduClsName; //教学班名
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetTeacherId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strTeacherId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherId, 12, convcc_WorkStuRelation.TeacherId);
}
objvcc_WorkStuRelationEN.TeacherId = strTeacherId; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.TeacherId) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.TeacherId, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.TeacherId] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetPubDate(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strPubDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubDate, 14, convcc_WorkStuRelation.PubDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetCourseStudentGroupId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, long? lngCourseStudentGroupId, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetWorkTypeName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strWorkTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkTypeName, 30, convcc_WorkStuRelation.WorkTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetScores(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, double? dblScores, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetSpecifyCompletionDate(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strSpecifyCompletionDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSpecifyCompletionDate, convcc_WorkStuRelation.SpecifyCompletionDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSpecifyCompletionDate, 14, convcc_WorkStuRelation.SpecifyCompletionDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetIdStudentInfo(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strIdStudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudentInfo, convcc_WorkStuRelation.IdStudentInfo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudentInfo, 8, convcc_WorkStuRelation.IdStudentInfo);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudentInfo, 8, convcc_WorkStuRelation.IdStudentInfo);
}
objvcc_WorkStuRelationEN.IdStudentInfo = strIdStudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.IdStudentInfo) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.IdStudentInfo, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.IdStudentInfo] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetStuId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strStuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuId, 20, convcc_WorkStuRelation.StuId);
}
objvcc_WorkStuRelationEN.StuId = strStuId; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.StuId) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.StuId, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.StuId] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetStuName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strStuName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuName, 50, convcc_WorkStuRelation.StuName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetIdXzCollege(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convcc_WorkStuRelation.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convcc_WorkStuRelation.IdXzCollege);
}
objvcc_WorkStuRelationEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.IdXzCollege) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.IdXzCollege, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.IdXzCollege] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetCollegeName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_WorkStuRelation.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetCollegeNameA(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_WorkStuRelation.CollegeNameA);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetIdXzMajor(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convcc_WorkStuRelation.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convcc_WorkStuRelation.IdXzMajor);
}
objvcc_WorkStuRelationEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.IdXzMajor) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.IdXzMajor, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.IdXzMajor] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetMajorId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strMajorId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorId, 4, convcc_WorkStuRelation.MajorId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorId, 4, convcc_WorkStuRelation.MajorId);
}
objvcc_WorkStuRelationEN.MajorId = strMajorId; //专业Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.MajorId) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.MajorId, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.MajorId] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetMajorName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convcc_WorkStuRelation.MajorName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetIdGradeBase(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convcc_WorkStuRelation.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convcc_WorkStuRelation.IdGradeBase);
}
objvcc_WorkStuRelationEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelation.IdGradeBase) == false)
{
objvcc_WorkStuRelationEN.dicFldComparisonOp.Add(convcc_WorkStuRelation.IdGradeBase, strComparisonOp);
}
else
{
objvcc_WorkStuRelationEN.dicFldComparisonOp[convcc_WorkStuRelation.IdGradeBase] = strComparisonOp;
}
}
return objvcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetGradeBaseName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strGradeBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convcc_WorkStuRelation.GradeBaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetAdminClsName(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strAdminClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convcc_WorkStuRelation.AdminClsName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetAdminClsId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strAdminClsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convcc_WorkStuRelation.AdminClsId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetAnswerModeId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strAnswerModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convcc_WorkStuRelation.AnswerModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convcc_WorkStuRelation.AnswerModeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetAnswerOptionId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strAnswerOptionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerOptionId, 8, convcc_WorkStuRelation.AnswerOptionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerOptionId, 8, convcc_WorkStuRelation.AnswerOptionId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetAnswerMultiOptions(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strAnswerMultiOptions, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerMultiOptions, 300, convcc_WorkStuRelation.AnswerMultiOptions);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetApplySendBackDate(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strApplySendBackDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplySendBackDate, 14, convcc_WorkStuRelation.ApplySendBackDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetRealFinishDate(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strRealFinishDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRealFinishDate, 14, convcc_WorkStuRelation.RealFinishDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetOperateTime(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strOperateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperateTime, 14, convcc_WorkStuRelation.OperateTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetScore(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, double? dblScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetMarkerId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strMarkerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkerId, 20, convcc_WorkStuRelation.MarkerId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetMarkDate(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strMarkDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkDate, 14, convcc_WorkStuRelation.MarkDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetWorkTypeId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strWorkTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkTypeId, 2, convcc_WorkStuRelation.WorkTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWorkTypeId, 2, convcc_WorkStuRelation.WorkTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetAnswerIP(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strAnswerIP, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerIP, 30, convcc_WorkStuRelation.AnswerIP);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetAnswerDate(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strAnswerDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, convcc_WorkStuRelation.AnswerDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetAnswerTime(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strAnswerTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, convcc_WorkStuRelation.AnswerTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetCourseExamPaperId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strCourseExamPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convcc_WorkStuRelation.CourseExamPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convcc_WorkStuRelation.CourseExamPaperId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetSchoolYear(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convcc_WorkStuRelation.SchoolYear);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetSchoolTerm(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convcc_WorkStuRelation.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convcc_WorkStuRelation.SchoolTerm);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetErrMsg(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 200, convcc_WorkStuRelation.ErrMsg);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetUpdDate(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_WorkStuRelation.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_WorkStuRelation.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetUpdUserId(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_WorkStuRelation.UpdUserId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationEN SetMemo(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_WorkStuRelation.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationENS">源对象</param>
 /// <param name = "objvcc_WorkStuRelationENT">目标对象</param>
 public static void CopyTo(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationENS, clsvcc_WorkStuRelationEN objvcc_WorkStuRelationENT)
{
try
{
objvcc_WorkStuRelationENT.IdWorkStuRelation = objvcc_WorkStuRelationENS.IdWorkStuRelation; //流水号
objvcc_WorkStuRelationENT.IdCurrEduCls = objvcc_WorkStuRelationENS.IdCurrEduCls; //教学班流水号
objvcc_WorkStuRelationENT.IdWorkEduClsRela = objvcc_WorkStuRelationENS.IdWorkEduClsRela; //作业教学班关系流水号
objvcc_WorkStuRelationENT.QuestionId = objvcc_WorkStuRelationENS.QuestionId; //题目Id
objvcc_WorkStuRelationENT.QuestionIndex = objvcc_WorkStuRelationENS.QuestionIndex; //题目序号
objvcc_WorkStuRelationENT.QuestionName = objvcc_WorkStuRelationENS.QuestionName; //题目名称
objvcc_WorkStuRelationENT.QuestionContent = objvcc_WorkStuRelationENS.QuestionContent; //题目内容
objvcc_WorkStuRelationENT.CourseId = objvcc_WorkStuRelationENS.CourseId; //课程Id
objvcc_WorkStuRelationENT.CourseName = objvcc_WorkStuRelationENS.CourseName; //课程名称
objvcc_WorkStuRelationENT.CourseChapterId = objvcc_WorkStuRelationENS.CourseChapterId; //课程章节ID
objvcc_WorkStuRelationENT.CourseChapterName = objvcc_WorkStuRelationENS.CourseChapterName; //课程章节名称
objvcc_WorkStuRelationENT.ChapterName = objvcc_WorkStuRelationENS.ChapterName; //章名
objvcc_WorkStuRelationENT.SectionName = objvcc_WorkStuRelationENS.SectionName; //节名
objvcc_WorkStuRelationENT.ChapterNameSim = objvcc_WorkStuRelationENS.ChapterNameSim; //章名简称
objvcc_WorkStuRelationENT.SectionNameSim = objvcc_WorkStuRelationENS.SectionNameSim; //节名简称
objvcc_WorkStuRelationENT.ParentNodeId = objvcc_WorkStuRelationENS.ParentNodeId; //父节点编号
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
objvcc_WorkStuRelationENT.CurrEduClsId = objvcc_WorkStuRelationENS.CurrEduClsId; //教学班Id
objvcc_WorkStuRelationENT.EduClsName = objvcc_WorkStuRelationENS.EduClsName; //教学班名
objvcc_WorkStuRelationENT.TeacherId = objvcc_WorkStuRelationENS.TeacherId; //教师工号
objvcc_WorkStuRelationENT.PubDate = objvcc_WorkStuRelationENS.PubDate; //发布日期
objvcc_WorkStuRelationENT.IsCurrEduCls = objvcc_WorkStuRelationENS.IsCurrEduCls; //是否为教学班作业
objvcc_WorkStuRelationENT.IsGroupWork = objvcc_WorkStuRelationENS.IsGroupWork; //是否为小组作业
objvcc_WorkStuRelationENT.CourseStudentGroupId = objvcc_WorkStuRelationENS.CourseStudentGroupId; //学生分组表流水号
objvcc_WorkStuRelationENT.WorkTypeName = objvcc_WorkStuRelationENS.WorkTypeName; //作业类型名称
objvcc_WorkStuRelationENT.Scores = objvcc_WorkStuRelationENS.Scores; //分值
objvcc_WorkStuRelationENT.SpecifyCompletionDate = objvcc_WorkStuRelationENS.SpecifyCompletionDate; //指定完成日期
objvcc_WorkStuRelationENT.IdStudentInfo = objvcc_WorkStuRelationENS.IdStudentInfo; //学生流水号
objvcc_WorkStuRelationENT.StuId = objvcc_WorkStuRelationENS.StuId; //学号
objvcc_WorkStuRelationENT.StuName = objvcc_WorkStuRelationENS.StuName; //姓名
objvcc_WorkStuRelationENT.IdXzCollege = objvcc_WorkStuRelationENS.IdXzCollege; //学院流水号
objvcc_WorkStuRelationENT.CollegeName = objvcc_WorkStuRelationENS.CollegeName; //学院名称
objvcc_WorkStuRelationENT.CollegeNameA = objvcc_WorkStuRelationENS.CollegeNameA; //学院名称简写
objvcc_WorkStuRelationENT.IdXzMajor = objvcc_WorkStuRelationENS.IdXzMajor; //专业流水号
objvcc_WorkStuRelationENT.MajorId = objvcc_WorkStuRelationENS.MajorId; //专业Id
objvcc_WorkStuRelationENT.MajorName = objvcc_WorkStuRelationENS.MajorName; //专业名称
objvcc_WorkStuRelationENT.IdGradeBase = objvcc_WorkStuRelationENS.IdGradeBase; //年级流水号
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
 /// <param name = "objvcc_WorkStuRelationENS">源对象</param>
 /// <returns>目标对象=>clsvcc_WorkStuRelationEN:objvcc_WorkStuRelationENT</returns>
 public static clsvcc_WorkStuRelationEN CopyTo(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationENS)
{
try
{
 clsvcc_WorkStuRelationEN objvcc_WorkStuRelationENT = new clsvcc_WorkStuRelationEN()
{
IdWorkStuRelation = objvcc_WorkStuRelationENS.IdWorkStuRelation, //流水号
IdCurrEduCls = objvcc_WorkStuRelationENS.IdCurrEduCls, //教学班流水号
IdWorkEduClsRela = objvcc_WorkStuRelationENS.IdWorkEduClsRela, //作业教学班关系流水号
QuestionId = objvcc_WorkStuRelationENS.QuestionId, //题目Id
QuestionIndex = objvcc_WorkStuRelationENS.QuestionIndex, //题目序号
QuestionName = objvcc_WorkStuRelationENS.QuestionName, //题目名称
QuestionContent = objvcc_WorkStuRelationENS.QuestionContent, //题目内容
CourseId = objvcc_WorkStuRelationENS.CourseId, //课程Id
CourseName = objvcc_WorkStuRelationENS.CourseName, //课程名称
CourseChapterId = objvcc_WorkStuRelationENS.CourseChapterId, //课程章节ID
CourseChapterName = objvcc_WorkStuRelationENS.CourseChapterName, //课程章节名称
ChapterName = objvcc_WorkStuRelationENS.ChapterName, //章名
SectionName = objvcc_WorkStuRelationENS.SectionName, //节名
ChapterNameSim = objvcc_WorkStuRelationENS.ChapterNameSim, //章名简称
SectionNameSim = objvcc_WorkStuRelationENS.SectionNameSim, //节名简称
ParentNodeId = objvcc_WorkStuRelationENS.ParentNodeId, //父节点编号
CourseChapterReferred = objvcc_WorkStuRelationENS.CourseChapterReferred, //节简称
ParentNodeName = objvcc_WorkStuRelationENS.ParentNodeName, //父节点名称
ParentNodeReferred = objvcc_WorkStuRelationENS.ParentNodeReferred, //章简称
QuestionTypeId = objvcc_WorkStuRelationENS.QuestionTypeId, //题目类型Id
QuestionTypeName = objvcc_WorkStuRelationENS.QuestionTypeName, //题目类型名
AnswerTypeId = objvcc_WorkStuRelationENS.AnswerTypeId, //答案类型ID
DefaultValue = objvcc_WorkStuRelationENS.DefaultValue, //缺省值
TextDirectId = objvcc_WorkStuRelationENS.TextDirectId, //文本方向ID
RelaEvent = objvcc_WorkStuRelationENS.RelaEvent, //相关事件
CheckBoxLimitCount = objvcc_WorkStuRelationENS.CheckBoxLimitCount, //复选框限制数
AnswerAttLimitSize = objvcc_WorkStuRelationENS.AnswerAttLimitSize, //回答附件限制大小
LimitedResourceType = objvcc_WorkStuRelationENS.LimitedResourceType, //限制资源类型
QuestionTypeId4Course = objvcc_WorkStuRelationENS.QuestionTypeId4Course, //题目类型Id4课程
QuestionTypeName4Course = objvcc_WorkStuRelationENS.QuestionTypeName4Course, //题目类型名4课程
CurrEduClsId = objvcc_WorkStuRelationENS.CurrEduClsId, //教学班Id
EduClsName = objvcc_WorkStuRelationENS.EduClsName, //教学班名
TeacherId = objvcc_WorkStuRelationENS.TeacherId, //教师工号
PubDate = objvcc_WorkStuRelationENS.PubDate, //发布日期
IsCurrEduCls = objvcc_WorkStuRelationENS.IsCurrEduCls, //是否为教学班作业
IsGroupWork = objvcc_WorkStuRelationENS.IsGroupWork, //是否为小组作业
CourseStudentGroupId = objvcc_WorkStuRelationENS.CourseStudentGroupId, //学生分组表流水号
WorkTypeName = objvcc_WorkStuRelationENS.WorkTypeName, //作业类型名称
Scores = objvcc_WorkStuRelationENS.Scores, //分值
SpecifyCompletionDate = objvcc_WorkStuRelationENS.SpecifyCompletionDate, //指定完成日期
IdStudentInfo = objvcc_WorkStuRelationENS.IdStudentInfo, //学生流水号
StuId = objvcc_WorkStuRelationENS.StuId, //学号
StuName = objvcc_WorkStuRelationENS.StuName, //姓名
IdXzCollege = objvcc_WorkStuRelationENS.IdXzCollege, //学院流水号
CollegeName = objvcc_WorkStuRelationENS.CollegeName, //学院名称
CollegeNameA = objvcc_WorkStuRelationENS.CollegeNameA, //学院名称简写
IdXzMajor = objvcc_WorkStuRelationENS.IdXzMajor, //专业流水号
MajorId = objvcc_WorkStuRelationENS.MajorId, //专业Id
MajorName = objvcc_WorkStuRelationENS.MajorName, //专业名称
IdGradeBase = objvcc_WorkStuRelationENS.IdGradeBase, //年级流水号
GradeBaseName = objvcc_WorkStuRelationENS.GradeBaseName, //年级名称
AdminClsName = objvcc_WorkStuRelationENS.AdminClsName, //行政班名称
AdminClsId = objvcc_WorkStuRelationENS.AdminClsId, //行政班代号
AnswerModeId = objvcc_WorkStuRelationENS.AnswerModeId, //答案模式Id
AnswerOptionId = objvcc_WorkStuRelationENS.AnswerOptionId, //回答选项Id
AnswerMultiOptions = objvcc_WorkStuRelationENS.AnswerMultiOptions, //多选项答案
AnswerBoolResult = objvcc_WorkStuRelationENS.AnswerBoolResult, //答案布尔结果
StuAnswerText = objvcc_WorkStuRelationENS.StuAnswerText, //学生回答文本
IsPublish = objvcc_WorkStuRelationENS.IsPublish, //是否发布
IsLook = objvcc_WorkStuRelationENS.IsLook, //是否查看
IsSave = objvcc_WorkStuRelationENS.IsSave, //是否保存
IsSubmit = objvcc_WorkStuRelationENS.IsSubmit, //是否提交
ApplySendBackDate = objvcc_WorkStuRelationENS.ApplySendBackDate, //申请退回日期
IsApplySendBack = objvcc_WorkStuRelationENS.IsApplySendBack, //是否申请退回
RealFinishDate = objvcc_WorkStuRelationENS.RealFinishDate, //实际完成日期
OperateTime = objvcc_WorkStuRelationENS.OperateTime, //操作时间
Score = objvcc_WorkStuRelationENS.Score, //得分
Comment = objvcc_WorkStuRelationENS.Comment, //批注
IsMarking = objvcc_WorkStuRelationENS.IsMarking, //是否批阅
MarkerId = objvcc_WorkStuRelationENS.MarkerId, //打分者
MarkDate = objvcc_WorkStuRelationENS.MarkDate, //打分日期
IsSendBack = objvcc_WorkStuRelationENS.IsSendBack, //是否退回
IsInErrorQuestion = objvcc_WorkStuRelationENS.IsInErrorQuestion, //是否进入错题
WorkTypeId = objvcc_WorkStuRelationENS.WorkTypeId, //作业类型Id
AnswerIP = objvcc_WorkStuRelationENS.AnswerIP, //回答IP
AnswerDate = objvcc_WorkStuRelationENS.AnswerDate, //回答日期
AnswerTime = objvcc_WorkStuRelationENS.AnswerTime, //回答时间
CourseExamPaperId = objvcc_WorkStuRelationENS.CourseExamPaperId, //考卷流水号
IsRight = objvcc_WorkStuRelationENS.IsRight, //是否正确
IsAccessKnowledge = objvcc_WorkStuRelationENS.IsAccessKnowledge, //是否处理知识点
IsNotProcessTimeout = objvcc_WorkStuRelationENS.IsNotProcessTimeout, //是否不处理超时
SchoolYear = objvcc_WorkStuRelationENS.SchoolYear, //学年
SchoolTerm = objvcc_WorkStuRelationENS.SchoolTerm, //学期
ErrMsg = objvcc_WorkStuRelationENS.ErrMsg, //错误信息
UpdDate = objvcc_WorkStuRelationENS.UpdDate, //修改日期
UpdUserId = objvcc_WorkStuRelationENS.UpdUserId, //修改用户Id
Memo = objvcc_WorkStuRelationENS.Memo, //备注
};
 return objvcc_WorkStuRelationENT;
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
public static void CheckProperty4Condition(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN)
{
 clsvcc_WorkStuRelationBL.vcc_WorkStuRelationDA.CheckProperty4Condition(objvcc_WorkStuRelationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.IdWorkStuRelation) == true)
{
string strComparisonOpIdWorkStuRelation = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.IdWorkStuRelation];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation.IdWorkStuRelation, objvcc_WorkStuRelationCond.IdWorkStuRelation, strComparisonOpIdWorkStuRelation);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.IdCurrEduCls, objvcc_WorkStuRelationCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.IdWorkEduClsRela) == true)
{
string strComparisonOpIdWorkEduClsRela = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.IdWorkEduClsRela];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation.IdWorkEduClsRela, objvcc_WorkStuRelationCond.IdWorkEduClsRela, strComparisonOpIdWorkEduClsRela);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.QuestionId) == true)
{
string strComparisonOpQuestionId = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation.QuestionId, objvcc_WorkStuRelationCond.QuestionId, strComparisonOpQuestionId);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.QuestionIndex) == true)
{
string strComparisonOpQuestionIndex = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation.QuestionIndex, objvcc_WorkStuRelationCond.QuestionIndex, strComparisonOpQuestionIndex);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.QuestionName) == true)
{
string strComparisonOpQuestionName = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.QuestionName, objvcc_WorkStuRelationCond.QuestionName, strComparisonOpQuestionName);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.QuestionContent) == true)
{
string strComparisonOpQuestionContent = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.QuestionContent, objvcc_WorkStuRelationCond.QuestionContent, strComparisonOpQuestionContent);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.CourseId, objvcc_WorkStuRelationCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.CourseName) == true)
{
string strComparisonOpCourseName = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.CourseName, objvcc_WorkStuRelationCond.CourseName, strComparisonOpCourseName);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.CourseChapterId, objvcc_WorkStuRelationCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.CourseChapterName, objvcc_WorkStuRelationCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.ChapterName) == true)
{
string strComparisonOpChapterName = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.ChapterName, objvcc_WorkStuRelationCond.ChapterName, strComparisonOpChapterName);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.SectionName) == true)
{
string strComparisonOpSectionName = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.SectionName, objvcc_WorkStuRelationCond.SectionName, strComparisonOpSectionName);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.ChapterNameSim, objvcc_WorkStuRelationCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.SectionNameSim) == true)
{
string strComparisonOpSectionNameSim = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.SectionNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.SectionNameSim, objvcc_WorkStuRelationCond.SectionNameSim, strComparisonOpSectionNameSim);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.ParentNodeId) == true)
{
string strComparisonOpParentNodeId = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.ParentNodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.ParentNodeId, objvcc_WorkStuRelationCond.ParentNodeId, strComparisonOpParentNodeId);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.CourseChapterReferred) == true)
{
string strComparisonOpCourseChapterReferred = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.CourseChapterReferred, objvcc_WorkStuRelationCond.CourseChapterReferred, strComparisonOpCourseChapterReferred);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.ParentNodeName) == true)
{
string strComparisonOpParentNodeName = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.ParentNodeName, objvcc_WorkStuRelationCond.ParentNodeName, strComparisonOpParentNodeName);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.ParentNodeReferred) == true)
{
string strComparisonOpParentNodeReferred = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.ParentNodeReferred, objvcc_WorkStuRelationCond.ParentNodeReferred, strComparisonOpParentNodeReferred);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.QuestionTypeId, objvcc_WorkStuRelationCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.QuestionTypeName) == true)
{
string strComparisonOpQuestionTypeName = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.QuestionTypeName, objvcc_WorkStuRelationCond.QuestionTypeName, strComparisonOpQuestionTypeName);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.AnswerTypeId) == true)
{
string strComparisonOpAnswerTypeId = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.AnswerTypeId, objvcc_WorkStuRelationCond.AnswerTypeId, strComparisonOpAnswerTypeId);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.DefaultValue, objvcc_WorkStuRelationCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.TextDirectId) == true)
{
string strComparisonOpTextDirectId = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.TextDirectId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.TextDirectId, objvcc_WorkStuRelationCond.TextDirectId, strComparisonOpTextDirectId);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.RelaEvent) == true)
{
string strComparisonOpRelaEvent = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.RelaEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.RelaEvent, objvcc_WorkStuRelationCond.RelaEvent, strComparisonOpRelaEvent);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.CheckBoxLimitCount) == true)
{
string strComparisonOpCheckBoxLimitCount = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.CheckBoxLimitCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation.CheckBoxLimitCount, objvcc_WorkStuRelationCond.CheckBoxLimitCount, strComparisonOpCheckBoxLimitCount);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.AnswerAttLimitSize) == true)
{
string strComparisonOpAnswerAttLimitSize = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.AnswerAttLimitSize];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation.AnswerAttLimitSize, objvcc_WorkStuRelationCond.AnswerAttLimitSize, strComparisonOpAnswerAttLimitSize);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.LimitedResourceType) == true)
{
string strComparisonOpLimitedResourceType = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.LimitedResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.LimitedResourceType, objvcc_WorkStuRelationCond.LimitedResourceType, strComparisonOpLimitedResourceType);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.QuestionTypeId4Course) == true)
{
string strComparisonOpQuestionTypeId4Course = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.QuestionTypeId4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.QuestionTypeId4Course, objvcc_WorkStuRelationCond.QuestionTypeId4Course, strComparisonOpQuestionTypeId4Course);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.QuestionTypeName4Course) == true)
{
string strComparisonOpQuestionTypeName4Course = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.QuestionTypeName4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.QuestionTypeName4Course, objvcc_WorkStuRelationCond.QuestionTypeName4Course, strComparisonOpQuestionTypeName4Course);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.CurrEduClsId) == true)
{
string strComparisonOpCurrEduClsId = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.CurrEduClsId, objvcc_WorkStuRelationCond.CurrEduClsId, strComparisonOpCurrEduClsId);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.EduClsName) == true)
{
string strComparisonOpEduClsName = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.EduClsName, objvcc_WorkStuRelationCond.EduClsName, strComparisonOpEduClsName);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.TeacherId) == true)
{
string strComparisonOpTeacherId = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.TeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.TeacherId, objvcc_WorkStuRelationCond.TeacherId, strComparisonOpTeacherId);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.PubDate) == true)
{
string strComparisonOpPubDate = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.PubDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.PubDate, objvcc_WorkStuRelationCond.PubDate, strComparisonOpPubDate);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.IsCurrEduCls) == true)
{
if (objvcc_WorkStuRelationCond.IsCurrEduCls == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsCurrEduCls);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsCurrEduCls);
}
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.IsGroupWork) == true)
{
if (objvcc_WorkStuRelationCond.IsGroupWork == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsGroupWork);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsGroupWork);
}
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.CourseStudentGroupId) == true)
{
string strComparisonOpCourseStudentGroupId = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.CourseStudentGroupId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation.CourseStudentGroupId, objvcc_WorkStuRelationCond.CourseStudentGroupId, strComparisonOpCourseStudentGroupId);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.WorkTypeName) == true)
{
string strComparisonOpWorkTypeName = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.WorkTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.WorkTypeName, objvcc_WorkStuRelationCond.WorkTypeName, strComparisonOpWorkTypeName);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.Scores) == true)
{
string strComparisonOpScores = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation.Scores, objvcc_WorkStuRelationCond.Scores, strComparisonOpScores);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.SpecifyCompletionDate) == true)
{
string strComparisonOpSpecifyCompletionDate = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.SpecifyCompletionDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.SpecifyCompletionDate, objvcc_WorkStuRelationCond.SpecifyCompletionDate, strComparisonOpSpecifyCompletionDate);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.IdStudentInfo) == true)
{
string strComparisonOpIdStudentInfo = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.IdStudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.IdStudentInfo, objvcc_WorkStuRelationCond.IdStudentInfo, strComparisonOpIdStudentInfo);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.StuId) == true)
{
string strComparisonOpStuId = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.StuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.StuId, objvcc_WorkStuRelationCond.StuId, strComparisonOpStuId);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.StuName) == true)
{
string strComparisonOpStuName = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.StuName, objvcc_WorkStuRelationCond.StuName, strComparisonOpStuName);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.IdXzCollege, objvcc_WorkStuRelationCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.CollegeName) == true)
{
string strComparisonOpCollegeName = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.CollegeName, objvcc_WorkStuRelationCond.CollegeName, strComparisonOpCollegeName);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.CollegeNameA, objvcc_WorkStuRelationCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.IdXzMajor, objvcc_WorkStuRelationCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.MajorId) == true)
{
string strComparisonOpMajorId = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.MajorId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.MajorId, objvcc_WorkStuRelationCond.MajorId, strComparisonOpMajorId);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.MajorName) == true)
{
string strComparisonOpMajorName = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.MajorName, objvcc_WorkStuRelationCond.MajorName, strComparisonOpMajorName);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.IdGradeBase, objvcc_WorkStuRelationCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.GradeBaseName, objvcc_WorkStuRelationCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.AdminClsName) == true)
{
string strComparisonOpAdminClsName = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.AdminClsName, objvcc_WorkStuRelationCond.AdminClsName, strComparisonOpAdminClsName);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.AdminClsId) == true)
{
string strComparisonOpAdminClsId = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.AdminClsId, objvcc_WorkStuRelationCond.AdminClsId, strComparisonOpAdminClsId);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.AnswerModeId) == true)
{
string strComparisonOpAnswerModeId = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.AnswerModeId, objvcc_WorkStuRelationCond.AnswerModeId, strComparisonOpAnswerModeId);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.AnswerOptionId) == true)
{
string strComparisonOpAnswerOptionId = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.AnswerOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.AnswerOptionId, objvcc_WorkStuRelationCond.AnswerOptionId, strComparisonOpAnswerOptionId);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.AnswerMultiOptions) == true)
{
string strComparisonOpAnswerMultiOptions = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.AnswerMultiOptions];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.AnswerMultiOptions, objvcc_WorkStuRelationCond.AnswerMultiOptions, strComparisonOpAnswerMultiOptions);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.AnswerBoolResult) == true)
{
if (objvcc_WorkStuRelationCond.AnswerBoolResult == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.AnswerBoolResult);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.AnswerBoolResult);
}
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.IsPublish) == true)
{
if (objvcc_WorkStuRelationCond.IsPublish == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsPublish);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsPublish);
}
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.IsLook) == true)
{
if (objvcc_WorkStuRelationCond.IsLook == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsLook);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsLook);
}
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.IsSave) == true)
{
if (objvcc_WorkStuRelationCond.IsSave == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsSave);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsSave);
}
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.IsSubmit) == true)
{
if (objvcc_WorkStuRelationCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsSubmit);
}
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.ApplySendBackDate) == true)
{
string strComparisonOpApplySendBackDate = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.ApplySendBackDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.ApplySendBackDate, objvcc_WorkStuRelationCond.ApplySendBackDate, strComparisonOpApplySendBackDate);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.IsApplySendBack) == true)
{
if (objvcc_WorkStuRelationCond.IsApplySendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsApplySendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsApplySendBack);
}
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.RealFinishDate) == true)
{
string strComparisonOpRealFinishDate = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.RealFinishDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.RealFinishDate, objvcc_WorkStuRelationCond.RealFinishDate, strComparisonOpRealFinishDate);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.OperateTime) == true)
{
string strComparisonOpOperateTime = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.OperateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.OperateTime, objvcc_WorkStuRelationCond.OperateTime, strComparisonOpOperateTime);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.Score) == true)
{
string strComparisonOpScore = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelation.Score, objvcc_WorkStuRelationCond.Score, strComparisonOpScore);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.IsMarking) == true)
{
if (objvcc_WorkStuRelationCond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsMarking);
}
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.MarkerId) == true)
{
string strComparisonOpMarkerId = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.MarkerId, objvcc_WorkStuRelationCond.MarkerId, strComparisonOpMarkerId);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.MarkDate) == true)
{
string strComparisonOpMarkDate = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.MarkDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.MarkDate, objvcc_WorkStuRelationCond.MarkDate, strComparisonOpMarkDate);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.IsSendBack) == true)
{
if (objvcc_WorkStuRelationCond.IsSendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsSendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsSendBack);
}
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.IsInErrorQuestion) == true)
{
if (objvcc_WorkStuRelationCond.IsInErrorQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsInErrorQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsInErrorQuestion);
}
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.WorkTypeId) == true)
{
string strComparisonOpWorkTypeId = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.WorkTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.WorkTypeId, objvcc_WorkStuRelationCond.WorkTypeId, strComparisonOpWorkTypeId);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.AnswerIP) == true)
{
string strComparisonOpAnswerIP = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.AnswerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.AnswerIP, objvcc_WorkStuRelationCond.AnswerIP, strComparisonOpAnswerIP);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.AnswerDate) == true)
{
string strComparisonOpAnswerDate = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.AnswerDate, objvcc_WorkStuRelationCond.AnswerDate, strComparisonOpAnswerDate);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.AnswerTime) == true)
{
string strComparisonOpAnswerTime = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.AnswerTime, objvcc_WorkStuRelationCond.AnswerTime, strComparisonOpAnswerTime);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.CourseExamPaperId) == true)
{
string strComparisonOpCourseExamPaperId = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.CourseExamPaperId, objvcc_WorkStuRelationCond.CourseExamPaperId, strComparisonOpCourseExamPaperId);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.IsRight) == true)
{
if (objvcc_WorkStuRelationCond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsRight);
}
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.IsAccessKnowledge) == true)
{
if (objvcc_WorkStuRelationCond.IsAccessKnowledge == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsAccessKnowledge);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsAccessKnowledge);
}
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.IsNotProcessTimeout) == true)
{
if (objvcc_WorkStuRelationCond.IsNotProcessTimeout == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_WorkStuRelation.IsNotProcessTimeout);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_WorkStuRelation.IsNotProcessTimeout);
}
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.SchoolYear, objvcc_WorkStuRelationCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.SchoolTerm, objvcc_WorkStuRelationCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.ErrMsg) == true)
{
string strComparisonOpErrMsg = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.ErrMsg, objvcc_WorkStuRelationCond.ErrMsg, strComparisonOpErrMsg);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.UpdDate, objvcc_WorkStuRelationCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.UpdUserId, objvcc_WorkStuRelationCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvcc_WorkStuRelationCond.IsUpdated(convcc_WorkStuRelation.Memo) == true)
{
string strComparisonOpMemo = objvcc_WorkStuRelationCond.dicFldComparisonOp[convcc_WorkStuRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelation.Memo, objvcc_WorkStuRelationCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_WorkStuRelation
{
public virtual bool UpdRelaTabDate(long lngIdWorkStuRelation, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v作业与学生关系表(vcc_WorkStuRelation)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_WorkStuRelationBL
{
public static RelatedActions_vcc_WorkStuRelation relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_WorkStuRelationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_WorkStuRelationDA vcc_WorkStuRelationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_WorkStuRelationDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_WorkStuRelationBL()
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
if (string.IsNullOrEmpty(clsvcc_WorkStuRelationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_WorkStuRelationEN._ConnectString);
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
public static DataTable GetDataTable_vcc_WorkStuRelation(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_WorkStuRelationDA.GetDataTable_vcc_WorkStuRelation(strWhereCond);
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
objDT = vcc_WorkStuRelationDA.GetDataTable(strWhereCond);
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
objDT = vcc_WorkStuRelationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_WorkStuRelationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_WorkStuRelationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_WorkStuRelationDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_WorkStuRelationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_WorkStuRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_WorkStuRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdWorkStuRelationLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcc_WorkStuRelationEN> GetObjLstByIdWorkStuRelationLst(List<long> arrIdWorkStuRelationLst)
{
List<clsvcc_WorkStuRelationEN> arrObjLst = new List<clsvcc_WorkStuRelationEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdWorkStuRelationLst);
 string strWhereCond = string.Format("IdWorkStuRelation in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = new clsvcc_WorkStuRelationEN();
try
{
objvcc_WorkStuRelationEN.IdWorkStuRelation = Int32.Parse(objRow[convcc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objvcc_WorkStuRelationEN.IdCurrEduCls = objRow[convcc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationEN.IdWorkEduClsRela = objRow[convcc_WorkStuRelation.IdWorkEduClsRela] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkStuRelationEN.QuestionId = objRow[convcc_WorkStuRelation.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkStuRelationEN.QuestionIndex = objRow[convcc_WorkStuRelation.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelationEN.QuestionName = objRow[convcc_WorkStuRelation.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelationEN.QuestionContent = objRow[convcc_WorkStuRelation.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelationEN.CourseId = objRow[convcc_WorkStuRelation.CourseId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelationEN.CourseName = objRow[convcc_WorkStuRelation.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelationEN.CourseChapterId = objRow[convcc_WorkStuRelation.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelationEN.CourseChapterName = objRow[convcc_WorkStuRelation.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelationEN.ChapterName = objRow[convcc_WorkStuRelation.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelationEN.SectionName = objRow[convcc_WorkStuRelation.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelationEN.ChapterNameSim = objRow[convcc_WorkStuRelation.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelationEN.SectionNameSim = objRow[convcc_WorkStuRelation.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelationEN.ParentNodeId = objRow[convcc_WorkStuRelation.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkStuRelationEN.CourseChapterReferred = objRow[convcc_WorkStuRelation.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelationEN.ParentNodeName = objRow[convcc_WorkStuRelation.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelationEN.ParentNodeReferred = objRow[convcc_WorkStuRelation.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelationEN.QuestionTypeId = objRow[convcc_WorkStuRelation.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationEN.QuestionTypeName = objRow[convcc_WorkStuRelation.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkStuRelationEN.AnswerTypeId = objRow[convcc_WorkStuRelation.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkStuRelationEN.DefaultValue = objRow[convcc_WorkStuRelation.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkStuRelationEN.TextDirectId = objRow[convcc_WorkStuRelation.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkStuRelationEN.RelaEvent = objRow[convcc_WorkStuRelation.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkStuRelationEN.CheckBoxLimitCount = objRow[convcc_WorkStuRelation.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkStuRelationEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelationEN.LimitedResourceType = objRow[convcc_WorkStuRelation.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkStuRelationEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelation.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationEN.QuestionTypeName4Course = objRow[convcc_WorkStuRelation.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkStuRelationEN.CurrEduClsId = objRow[convcc_WorkStuRelation.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkStuRelationEN.EduClsName = objRow[convcc_WorkStuRelation.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkStuRelationEN.TeacherId = objRow[convcc_WorkStuRelation.TeacherId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkStuRelationEN.PubDate = objRow[convcc_WorkStuRelation.PubDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.PubDate].ToString().Trim(); //发布日期
objvcc_WorkStuRelationEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkStuRelationEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkStuRelationEN.CourseStudentGroupId = objRow[convcc_WorkStuRelation.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkStuRelationEN.WorkTypeName = objRow[convcc_WorkStuRelation.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkStuRelationEN.Scores = objRow[convcc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkStuRelation.Scores].ToString().Trim()); //分值
objvcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[convcc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkStuRelationEN.IdStudentInfo = objRow[convcc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationEN.StuId = objRow[convcc_WorkStuRelation.StuId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuId].ToString().Trim(); //学号
objvcc_WorkStuRelationEN.StuName = objRow[convcc_WorkStuRelation.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelationEN.IdXzCollege = objRow[convcc_WorkStuRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelationEN.CollegeName = objRow[convcc_WorkStuRelation.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelationEN.CollegeNameA = objRow[convcc_WorkStuRelation.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelationEN.IdXzMajor = objRow[convcc_WorkStuRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelationEN.MajorId = objRow[convcc_WorkStuRelation.MajorId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorId].ToString().Trim(); //专业Id
objvcc_WorkStuRelationEN.MajorName = objRow[convcc_WorkStuRelation.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelationEN.IdGradeBase = objRow[convcc_WorkStuRelation.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelationEN.GradeBaseName = objRow[convcc_WorkStuRelation.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelationEN.AdminClsName = objRow[convcc_WorkStuRelation.AdminClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsName].ToString().Trim(); //行政班名称
objvcc_WorkStuRelationEN.AdminClsId = objRow[convcc_WorkStuRelation.AdminClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsId].ToString().Trim(); //行政班代号
objvcc_WorkStuRelationEN.AnswerModeId = objRow[convcc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkStuRelationEN.AnswerOptionId = objRow[convcc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_WorkStuRelationEN.AnswerMultiOptions = objRow[convcc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_WorkStuRelationEN.AnswerBoolResult = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objvcc_WorkStuRelationEN.StuAnswerText = objRow[convcc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_WorkStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objvcc_WorkStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objvcc_WorkStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objvcc_WorkStuRelationEN.ApplySendBackDate = objRow[convcc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objvcc_WorkStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objvcc_WorkStuRelationEN.RealFinishDate = objRow[convcc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_WorkStuRelationEN.OperateTime = objRow[convcc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objvcc_WorkStuRelationEN.Score = objRow[convcc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkStuRelation.Score].ToString().Trim()); //得分
objvcc_WorkStuRelationEN.Comment = objRow[convcc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Comment].ToString().Trim(); //批注
objvcc_WorkStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objvcc_WorkStuRelationEN.MarkerId = objRow[convcc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objvcc_WorkStuRelationEN.MarkDate = objRow[convcc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objvcc_WorkStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objvcc_WorkStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_WorkStuRelationEN.WorkTypeId = objRow[convcc_WorkStuRelation.WorkTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkStuRelationEN.AnswerIP = objRow[convcc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objvcc_WorkStuRelationEN.AnswerDate = objRow[convcc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objvcc_WorkStuRelationEN.AnswerTime = objRow[convcc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objvcc_WorkStuRelationEN.CourseExamPaperId = objRow[convcc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_WorkStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objvcc_WorkStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvcc_WorkStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_WorkStuRelationEN.SchoolYear = objRow[convcc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objvcc_WorkStuRelationEN.SchoolTerm = objRow[convcc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objvcc_WorkStuRelationEN.ErrMsg = objRow[convcc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objvcc_WorkStuRelationEN.UpdDate = objRow[convcc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelationEN.UpdUserId = objRow[convcc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkStuRelationEN.Memo = objRow[convcc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelationEN.IdWorkStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdWorkStuRelationLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_WorkStuRelationEN> GetObjLstByIdWorkStuRelationLstCache(List<long> arrIdWorkStuRelationLst)
{
string strKey = string.Format("{0}", clsvcc_WorkStuRelationEN._CurrTabName);
List<clsvcc_WorkStuRelationEN> arrvcc_WorkStuRelationObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_WorkStuRelationEN> arrvcc_WorkStuRelationObjLst_Sel =
arrvcc_WorkStuRelationObjLstCache
.Where(x => arrIdWorkStuRelationLst.Contains(x.IdWorkStuRelation));
return arrvcc_WorkStuRelationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelationEN> GetObjLst(string strWhereCond)
{
List<clsvcc_WorkStuRelationEN> arrObjLst = new List<clsvcc_WorkStuRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = new clsvcc_WorkStuRelationEN();
try
{
objvcc_WorkStuRelationEN.IdWorkStuRelation = Int32.Parse(objRow[convcc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objvcc_WorkStuRelationEN.IdCurrEduCls = objRow[convcc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationEN.IdWorkEduClsRela = objRow[convcc_WorkStuRelation.IdWorkEduClsRela] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkStuRelationEN.QuestionId = objRow[convcc_WorkStuRelation.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkStuRelationEN.QuestionIndex = objRow[convcc_WorkStuRelation.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelationEN.QuestionName = objRow[convcc_WorkStuRelation.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelationEN.QuestionContent = objRow[convcc_WorkStuRelation.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelationEN.CourseId = objRow[convcc_WorkStuRelation.CourseId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelationEN.CourseName = objRow[convcc_WorkStuRelation.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelationEN.CourseChapterId = objRow[convcc_WorkStuRelation.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelationEN.CourseChapterName = objRow[convcc_WorkStuRelation.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelationEN.ChapterName = objRow[convcc_WorkStuRelation.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelationEN.SectionName = objRow[convcc_WorkStuRelation.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelationEN.ChapterNameSim = objRow[convcc_WorkStuRelation.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelationEN.SectionNameSim = objRow[convcc_WorkStuRelation.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelationEN.ParentNodeId = objRow[convcc_WorkStuRelation.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkStuRelationEN.CourseChapterReferred = objRow[convcc_WorkStuRelation.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelationEN.ParentNodeName = objRow[convcc_WorkStuRelation.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelationEN.ParentNodeReferred = objRow[convcc_WorkStuRelation.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelationEN.QuestionTypeId = objRow[convcc_WorkStuRelation.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationEN.QuestionTypeName = objRow[convcc_WorkStuRelation.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkStuRelationEN.AnswerTypeId = objRow[convcc_WorkStuRelation.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkStuRelationEN.DefaultValue = objRow[convcc_WorkStuRelation.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkStuRelationEN.TextDirectId = objRow[convcc_WorkStuRelation.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkStuRelationEN.RelaEvent = objRow[convcc_WorkStuRelation.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkStuRelationEN.CheckBoxLimitCount = objRow[convcc_WorkStuRelation.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkStuRelationEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelationEN.LimitedResourceType = objRow[convcc_WorkStuRelation.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkStuRelationEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelation.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationEN.QuestionTypeName4Course = objRow[convcc_WorkStuRelation.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkStuRelationEN.CurrEduClsId = objRow[convcc_WorkStuRelation.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkStuRelationEN.EduClsName = objRow[convcc_WorkStuRelation.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkStuRelationEN.TeacherId = objRow[convcc_WorkStuRelation.TeacherId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkStuRelationEN.PubDate = objRow[convcc_WorkStuRelation.PubDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.PubDate].ToString().Trim(); //发布日期
objvcc_WorkStuRelationEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkStuRelationEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkStuRelationEN.CourseStudentGroupId = objRow[convcc_WorkStuRelation.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkStuRelationEN.WorkTypeName = objRow[convcc_WorkStuRelation.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkStuRelationEN.Scores = objRow[convcc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkStuRelation.Scores].ToString().Trim()); //分值
objvcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[convcc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkStuRelationEN.IdStudentInfo = objRow[convcc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationEN.StuId = objRow[convcc_WorkStuRelation.StuId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuId].ToString().Trim(); //学号
objvcc_WorkStuRelationEN.StuName = objRow[convcc_WorkStuRelation.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelationEN.IdXzCollege = objRow[convcc_WorkStuRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelationEN.CollegeName = objRow[convcc_WorkStuRelation.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelationEN.CollegeNameA = objRow[convcc_WorkStuRelation.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelationEN.IdXzMajor = objRow[convcc_WorkStuRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelationEN.MajorId = objRow[convcc_WorkStuRelation.MajorId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorId].ToString().Trim(); //专业Id
objvcc_WorkStuRelationEN.MajorName = objRow[convcc_WorkStuRelation.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelationEN.IdGradeBase = objRow[convcc_WorkStuRelation.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelationEN.GradeBaseName = objRow[convcc_WorkStuRelation.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelationEN.AdminClsName = objRow[convcc_WorkStuRelation.AdminClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsName].ToString().Trim(); //行政班名称
objvcc_WorkStuRelationEN.AdminClsId = objRow[convcc_WorkStuRelation.AdminClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsId].ToString().Trim(); //行政班代号
objvcc_WorkStuRelationEN.AnswerModeId = objRow[convcc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkStuRelationEN.AnswerOptionId = objRow[convcc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_WorkStuRelationEN.AnswerMultiOptions = objRow[convcc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_WorkStuRelationEN.AnswerBoolResult = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objvcc_WorkStuRelationEN.StuAnswerText = objRow[convcc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_WorkStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objvcc_WorkStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objvcc_WorkStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objvcc_WorkStuRelationEN.ApplySendBackDate = objRow[convcc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objvcc_WorkStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objvcc_WorkStuRelationEN.RealFinishDate = objRow[convcc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_WorkStuRelationEN.OperateTime = objRow[convcc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objvcc_WorkStuRelationEN.Score = objRow[convcc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkStuRelation.Score].ToString().Trim()); //得分
objvcc_WorkStuRelationEN.Comment = objRow[convcc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Comment].ToString().Trim(); //批注
objvcc_WorkStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objvcc_WorkStuRelationEN.MarkerId = objRow[convcc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objvcc_WorkStuRelationEN.MarkDate = objRow[convcc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objvcc_WorkStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objvcc_WorkStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_WorkStuRelationEN.WorkTypeId = objRow[convcc_WorkStuRelation.WorkTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkStuRelationEN.AnswerIP = objRow[convcc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objvcc_WorkStuRelationEN.AnswerDate = objRow[convcc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objvcc_WorkStuRelationEN.AnswerTime = objRow[convcc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objvcc_WorkStuRelationEN.CourseExamPaperId = objRow[convcc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_WorkStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objvcc_WorkStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvcc_WorkStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_WorkStuRelationEN.SchoolYear = objRow[convcc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objvcc_WorkStuRelationEN.SchoolTerm = objRow[convcc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objvcc_WorkStuRelationEN.ErrMsg = objRow[convcc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objvcc_WorkStuRelationEN.UpdDate = objRow[convcc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelationEN.UpdUserId = objRow[convcc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkStuRelationEN.Memo = objRow[convcc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelationEN.IdWorkStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelationEN);
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
public static List<clsvcc_WorkStuRelationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_WorkStuRelationEN> arrObjLst = new List<clsvcc_WorkStuRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = new clsvcc_WorkStuRelationEN();
try
{
objvcc_WorkStuRelationEN.IdWorkStuRelation = Int32.Parse(objRow[convcc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objvcc_WorkStuRelationEN.IdCurrEduCls = objRow[convcc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationEN.IdWorkEduClsRela = objRow[convcc_WorkStuRelation.IdWorkEduClsRela] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkStuRelationEN.QuestionId = objRow[convcc_WorkStuRelation.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkStuRelationEN.QuestionIndex = objRow[convcc_WorkStuRelation.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelationEN.QuestionName = objRow[convcc_WorkStuRelation.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelationEN.QuestionContent = objRow[convcc_WorkStuRelation.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelationEN.CourseId = objRow[convcc_WorkStuRelation.CourseId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelationEN.CourseName = objRow[convcc_WorkStuRelation.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelationEN.CourseChapterId = objRow[convcc_WorkStuRelation.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelationEN.CourseChapterName = objRow[convcc_WorkStuRelation.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelationEN.ChapterName = objRow[convcc_WorkStuRelation.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelationEN.SectionName = objRow[convcc_WorkStuRelation.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelationEN.ChapterNameSim = objRow[convcc_WorkStuRelation.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelationEN.SectionNameSim = objRow[convcc_WorkStuRelation.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelationEN.ParentNodeId = objRow[convcc_WorkStuRelation.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkStuRelationEN.CourseChapterReferred = objRow[convcc_WorkStuRelation.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelationEN.ParentNodeName = objRow[convcc_WorkStuRelation.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelationEN.ParentNodeReferred = objRow[convcc_WorkStuRelation.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelationEN.QuestionTypeId = objRow[convcc_WorkStuRelation.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationEN.QuestionTypeName = objRow[convcc_WorkStuRelation.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkStuRelationEN.AnswerTypeId = objRow[convcc_WorkStuRelation.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkStuRelationEN.DefaultValue = objRow[convcc_WorkStuRelation.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkStuRelationEN.TextDirectId = objRow[convcc_WorkStuRelation.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkStuRelationEN.RelaEvent = objRow[convcc_WorkStuRelation.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkStuRelationEN.CheckBoxLimitCount = objRow[convcc_WorkStuRelation.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkStuRelationEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelationEN.LimitedResourceType = objRow[convcc_WorkStuRelation.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkStuRelationEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelation.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationEN.QuestionTypeName4Course = objRow[convcc_WorkStuRelation.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkStuRelationEN.CurrEduClsId = objRow[convcc_WorkStuRelation.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkStuRelationEN.EduClsName = objRow[convcc_WorkStuRelation.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkStuRelationEN.TeacherId = objRow[convcc_WorkStuRelation.TeacherId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkStuRelationEN.PubDate = objRow[convcc_WorkStuRelation.PubDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.PubDate].ToString().Trim(); //发布日期
objvcc_WorkStuRelationEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkStuRelationEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkStuRelationEN.CourseStudentGroupId = objRow[convcc_WorkStuRelation.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkStuRelationEN.WorkTypeName = objRow[convcc_WorkStuRelation.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkStuRelationEN.Scores = objRow[convcc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkStuRelation.Scores].ToString().Trim()); //分值
objvcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[convcc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkStuRelationEN.IdStudentInfo = objRow[convcc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationEN.StuId = objRow[convcc_WorkStuRelation.StuId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuId].ToString().Trim(); //学号
objvcc_WorkStuRelationEN.StuName = objRow[convcc_WorkStuRelation.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelationEN.IdXzCollege = objRow[convcc_WorkStuRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelationEN.CollegeName = objRow[convcc_WorkStuRelation.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelationEN.CollegeNameA = objRow[convcc_WorkStuRelation.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelationEN.IdXzMajor = objRow[convcc_WorkStuRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelationEN.MajorId = objRow[convcc_WorkStuRelation.MajorId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorId].ToString().Trim(); //专业Id
objvcc_WorkStuRelationEN.MajorName = objRow[convcc_WorkStuRelation.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelationEN.IdGradeBase = objRow[convcc_WorkStuRelation.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelationEN.GradeBaseName = objRow[convcc_WorkStuRelation.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelationEN.AdminClsName = objRow[convcc_WorkStuRelation.AdminClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsName].ToString().Trim(); //行政班名称
objvcc_WorkStuRelationEN.AdminClsId = objRow[convcc_WorkStuRelation.AdminClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsId].ToString().Trim(); //行政班代号
objvcc_WorkStuRelationEN.AnswerModeId = objRow[convcc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkStuRelationEN.AnswerOptionId = objRow[convcc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_WorkStuRelationEN.AnswerMultiOptions = objRow[convcc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_WorkStuRelationEN.AnswerBoolResult = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objvcc_WorkStuRelationEN.StuAnswerText = objRow[convcc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_WorkStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objvcc_WorkStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objvcc_WorkStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objvcc_WorkStuRelationEN.ApplySendBackDate = objRow[convcc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objvcc_WorkStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objvcc_WorkStuRelationEN.RealFinishDate = objRow[convcc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_WorkStuRelationEN.OperateTime = objRow[convcc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objvcc_WorkStuRelationEN.Score = objRow[convcc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkStuRelation.Score].ToString().Trim()); //得分
objvcc_WorkStuRelationEN.Comment = objRow[convcc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Comment].ToString().Trim(); //批注
objvcc_WorkStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objvcc_WorkStuRelationEN.MarkerId = objRow[convcc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objvcc_WorkStuRelationEN.MarkDate = objRow[convcc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objvcc_WorkStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objvcc_WorkStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_WorkStuRelationEN.WorkTypeId = objRow[convcc_WorkStuRelation.WorkTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkStuRelationEN.AnswerIP = objRow[convcc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objvcc_WorkStuRelationEN.AnswerDate = objRow[convcc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objvcc_WorkStuRelationEN.AnswerTime = objRow[convcc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objvcc_WorkStuRelationEN.CourseExamPaperId = objRow[convcc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_WorkStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objvcc_WorkStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvcc_WorkStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_WorkStuRelationEN.SchoolYear = objRow[convcc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objvcc_WorkStuRelationEN.SchoolTerm = objRow[convcc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objvcc_WorkStuRelationEN.ErrMsg = objRow[convcc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objvcc_WorkStuRelationEN.UpdDate = objRow[convcc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelationEN.UpdUserId = objRow[convcc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkStuRelationEN.Memo = objRow[convcc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelationEN.IdWorkStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_WorkStuRelationEN> GetSubObjLstCache(clsvcc_WorkStuRelationEN objvcc_WorkStuRelationCond)
{
List<clsvcc_WorkStuRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_WorkStuRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_WorkStuRelation.AttributeName)
{
if (objvcc_WorkStuRelationCond.IsUpdated(strFldName) == false) continue;
if (objvcc_WorkStuRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkStuRelationCond[strFldName].ToString());
}
else
{
if (objvcc_WorkStuRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_WorkStuRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkStuRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_WorkStuRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_WorkStuRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_WorkStuRelationCond[strFldName]));
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
public static List<clsvcc_WorkStuRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_WorkStuRelationEN> arrObjLst = new List<clsvcc_WorkStuRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = new clsvcc_WorkStuRelationEN();
try
{
objvcc_WorkStuRelationEN.IdWorkStuRelation = Int32.Parse(objRow[convcc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objvcc_WorkStuRelationEN.IdCurrEduCls = objRow[convcc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationEN.IdWorkEduClsRela = objRow[convcc_WorkStuRelation.IdWorkEduClsRela] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkStuRelationEN.QuestionId = objRow[convcc_WorkStuRelation.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkStuRelationEN.QuestionIndex = objRow[convcc_WorkStuRelation.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelationEN.QuestionName = objRow[convcc_WorkStuRelation.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelationEN.QuestionContent = objRow[convcc_WorkStuRelation.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelationEN.CourseId = objRow[convcc_WorkStuRelation.CourseId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelationEN.CourseName = objRow[convcc_WorkStuRelation.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelationEN.CourseChapterId = objRow[convcc_WorkStuRelation.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelationEN.CourseChapterName = objRow[convcc_WorkStuRelation.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelationEN.ChapterName = objRow[convcc_WorkStuRelation.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelationEN.SectionName = objRow[convcc_WorkStuRelation.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelationEN.ChapterNameSim = objRow[convcc_WorkStuRelation.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelationEN.SectionNameSim = objRow[convcc_WorkStuRelation.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelationEN.ParentNodeId = objRow[convcc_WorkStuRelation.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkStuRelationEN.CourseChapterReferred = objRow[convcc_WorkStuRelation.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelationEN.ParentNodeName = objRow[convcc_WorkStuRelation.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelationEN.ParentNodeReferred = objRow[convcc_WorkStuRelation.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelationEN.QuestionTypeId = objRow[convcc_WorkStuRelation.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationEN.QuestionTypeName = objRow[convcc_WorkStuRelation.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkStuRelationEN.AnswerTypeId = objRow[convcc_WorkStuRelation.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkStuRelationEN.DefaultValue = objRow[convcc_WorkStuRelation.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkStuRelationEN.TextDirectId = objRow[convcc_WorkStuRelation.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkStuRelationEN.RelaEvent = objRow[convcc_WorkStuRelation.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkStuRelationEN.CheckBoxLimitCount = objRow[convcc_WorkStuRelation.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkStuRelationEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelationEN.LimitedResourceType = objRow[convcc_WorkStuRelation.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkStuRelationEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelation.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationEN.QuestionTypeName4Course = objRow[convcc_WorkStuRelation.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkStuRelationEN.CurrEduClsId = objRow[convcc_WorkStuRelation.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkStuRelationEN.EduClsName = objRow[convcc_WorkStuRelation.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkStuRelationEN.TeacherId = objRow[convcc_WorkStuRelation.TeacherId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkStuRelationEN.PubDate = objRow[convcc_WorkStuRelation.PubDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.PubDate].ToString().Trim(); //发布日期
objvcc_WorkStuRelationEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkStuRelationEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkStuRelationEN.CourseStudentGroupId = objRow[convcc_WorkStuRelation.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkStuRelationEN.WorkTypeName = objRow[convcc_WorkStuRelation.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkStuRelationEN.Scores = objRow[convcc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkStuRelation.Scores].ToString().Trim()); //分值
objvcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[convcc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkStuRelationEN.IdStudentInfo = objRow[convcc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationEN.StuId = objRow[convcc_WorkStuRelation.StuId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuId].ToString().Trim(); //学号
objvcc_WorkStuRelationEN.StuName = objRow[convcc_WorkStuRelation.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelationEN.IdXzCollege = objRow[convcc_WorkStuRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelationEN.CollegeName = objRow[convcc_WorkStuRelation.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelationEN.CollegeNameA = objRow[convcc_WorkStuRelation.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelationEN.IdXzMajor = objRow[convcc_WorkStuRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelationEN.MajorId = objRow[convcc_WorkStuRelation.MajorId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorId].ToString().Trim(); //专业Id
objvcc_WorkStuRelationEN.MajorName = objRow[convcc_WorkStuRelation.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelationEN.IdGradeBase = objRow[convcc_WorkStuRelation.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelationEN.GradeBaseName = objRow[convcc_WorkStuRelation.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelationEN.AdminClsName = objRow[convcc_WorkStuRelation.AdminClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsName].ToString().Trim(); //行政班名称
objvcc_WorkStuRelationEN.AdminClsId = objRow[convcc_WorkStuRelation.AdminClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsId].ToString().Trim(); //行政班代号
objvcc_WorkStuRelationEN.AnswerModeId = objRow[convcc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkStuRelationEN.AnswerOptionId = objRow[convcc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_WorkStuRelationEN.AnswerMultiOptions = objRow[convcc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_WorkStuRelationEN.AnswerBoolResult = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objvcc_WorkStuRelationEN.StuAnswerText = objRow[convcc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_WorkStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objvcc_WorkStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objvcc_WorkStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objvcc_WorkStuRelationEN.ApplySendBackDate = objRow[convcc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objvcc_WorkStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objvcc_WorkStuRelationEN.RealFinishDate = objRow[convcc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_WorkStuRelationEN.OperateTime = objRow[convcc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objvcc_WorkStuRelationEN.Score = objRow[convcc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkStuRelation.Score].ToString().Trim()); //得分
objvcc_WorkStuRelationEN.Comment = objRow[convcc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Comment].ToString().Trim(); //批注
objvcc_WorkStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objvcc_WorkStuRelationEN.MarkerId = objRow[convcc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objvcc_WorkStuRelationEN.MarkDate = objRow[convcc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objvcc_WorkStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objvcc_WorkStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_WorkStuRelationEN.WorkTypeId = objRow[convcc_WorkStuRelation.WorkTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkStuRelationEN.AnswerIP = objRow[convcc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objvcc_WorkStuRelationEN.AnswerDate = objRow[convcc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objvcc_WorkStuRelationEN.AnswerTime = objRow[convcc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objvcc_WorkStuRelationEN.CourseExamPaperId = objRow[convcc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_WorkStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objvcc_WorkStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvcc_WorkStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_WorkStuRelationEN.SchoolYear = objRow[convcc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objvcc_WorkStuRelationEN.SchoolTerm = objRow[convcc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objvcc_WorkStuRelationEN.ErrMsg = objRow[convcc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objvcc_WorkStuRelationEN.UpdDate = objRow[convcc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelationEN.UpdUserId = objRow[convcc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkStuRelationEN.Memo = objRow[convcc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelationEN.IdWorkStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelationEN);
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
public static List<clsvcc_WorkStuRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_WorkStuRelationEN> arrObjLst = new List<clsvcc_WorkStuRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = new clsvcc_WorkStuRelationEN();
try
{
objvcc_WorkStuRelationEN.IdWorkStuRelation = Int32.Parse(objRow[convcc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objvcc_WorkStuRelationEN.IdCurrEduCls = objRow[convcc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationEN.IdWorkEduClsRela = objRow[convcc_WorkStuRelation.IdWorkEduClsRela] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkStuRelationEN.QuestionId = objRow[convcc_WorkStuRelation.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkStuRelationEN.QuestionIndex = objRow[convcc_WorkStuRelation.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelationEN.QuestionName = objRow[convcc_WorkStuRelation.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelationEN.QuestionContent = objRow[convcc_WorkStuRelation.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelationEN.CourseId = objRow[convcc_WorkStuRelation.CourseId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelationEN.CourseName = objRow[convcc_WorkStuRelation.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelationEN.CourseChapterId = objRow[convcc_WorkStuRelation.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelationEN.CourseChapterName = objRow[convcc_WorkStuRelation.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelationEN.ChapterName = objRow[convcc_WorkStuRelation.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelationEN.SectionName = objRow[convcc_WorkStuRelation.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelationEN.ChapterNameSim = objRow[convcc_WorkStuRelation.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelationEN.SectionNameSim = objRow[convcc_WorkStuRelation.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelationEN.ParentNodeId = objRow[convcc_WorkStuRelation.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkStuRelationEN.CourseChapterReferred = objRow[convcc_WorkStuRelation.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelationEN.ParentNodeName = objRow[convcc_WorkStuRelation.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelationEN.ParentNodeReferred = objRow[convcc_WorkStuRelation.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelationEN.QuestionTypeId = objRow[convcc_WorkStuRelation.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationEN.QuestionTypeName = objRow[convcc_WorkStuRelation.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkStuRelationEN.AnswerTypeId = objRow[convcc_WorkStuRelation.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkStuRelationEN.DefaultValue = objRow[convcc_WorkStuRelation.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkStuRelationEN.TextDirectId = objRow[convcc_WorkStuRelation.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkStuRelationEN.RelaEvent = objRow[convcc_WorkStuRelation.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkStuRelationEN.CheckBoxLimitCount = objRow[convcc_WorkStuRelation.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkStuRelationEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelationEN.LimitedResourceType = objRow[convcc_WorkStuRelation.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkStuRelationEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelation.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationEN.QuestionTypeName4Course = objRow[convcc_WorkStuRelation.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkStuRelationEN.CurrEduClsId = objRow[convcc_WorkStuRelation.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkStuRelationEN.EduClsName = objRow[convcc_WorkStuRelation.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkStuRelationEN.TeacherId = objRow[convcc_WorkStuRelation.TeacherId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkStuRelationEN.PubDate = objRow[convcc_WorkStuRelation.PubDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.PubDate].ToString().Trim(); //发布日期
objvcc_WorkStuRelationEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkStuRelationEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkStuRelationEN.CourseStudentGroupId = objRow[convcc_WorkStuRelation.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkStuRelationEN.WorkTypeName = objRow[convcc_WorkStuRelation.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkStuRelationEN.Scores = objRow[convcc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkStuRelation.Scores].ToString().Trim()); //分值
objvcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[convcc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkStuRelationEN.IdStudentInfo = objRow[convcc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationEN.StuId = objRow[convcc_WorkStuRelation.StuId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuId].ToString().Trim(); //学号
objvcc_WorkStuRelationEN.StuName = objRow[convcc_WorkStuRelation.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelationEN.IdXzCollege = objRow[convcc_WorkStuRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelationEN.CollegeName = objRow[convcc_WorkStuRelation.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelationEN.CollegeNameA = objRow[convcc_WorkStuRelation.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelationEN.IdXzMajor = objRow[convcc_WorkStuRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelationEN.MajorId = objRow[convcc_WorkStuRelation.MajorId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorId].ToString().Trim(); //专业Id
objvcc_WorkStuRelationEN.MajorName = objRow[convcc_WorkStuRelation.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelationEN.IdGradeBase = objRow[convcc_WorkStuRelation.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelationEN.GradeBaseName = objRow[convcc_WorkStuRelation.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelationEN.AdminClsName = objRow[convcc_WorkStuRelation.AdminClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsName].ToString().Trim(); //行政班名称
objvcc_WorkStuRelationEN.AdminClsId = objRow[convcc_WorkStuRelation.AdminClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsId].ToString().Trim(); //行政班代号
objvcc_WorkStuRelationEN.AnswerModeId = objRow[convcc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkStuRelationEN.AnswerOptionId = objRow[convcc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_WorkStuRelationEN.AnswerMultiOptions = objRow[convcc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_WorkStuRelationEN.AnswerBoolResult = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objvcc_WorkStuRelationEN.StuAnswerText = objRow[convcc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_WorkStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objvcc_WorkStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objvcc_WorkStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objvcc_WorkStuRelationEN.ApplySendBackDate = objRow[convcc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objvcc_WorkStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objvcc_WorkStuRelationEN.RealFinishDate = objRow[convcc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_WorkStuRelationEN.OperateTime = objRow[convcc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objvcc_WorkStuRelationEN.Score = objRow[convcc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkStuRelation.Score].ToString().Trim()); //得分
objvcc_WorkStuRelationEN.Comment = objRow[convcc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Comment].ToString().Trim(); //批注
objvcc_WorkStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objvcc_WorkStuRelationEN.MarkerId = objRow[convcc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objvcc_WorkStuRelationEN.MarkDate = objRow[convcc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objvcc_WorkStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objvcc_WorkStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_WorkStuRelationEN.WorkTypeId = objRow[convcc_WorkStuRelation.WorkTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkStuRelationEN.AnswerIP = objRow[convcc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objvcc_WorkStuRelationEN.AnswerDate = objRow[convcc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objvcc_WorkStuRelationEN.AnswerTime = objRow[convcc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objvcc_WorkStuRelationEN.CourseExamPaperId = objRow[convcc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_WorkStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objvcc_WorkStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvcc_WorkStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_WorkStuRelationEN.SchoolYear = objRow[convcc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objvcc_WorkStuRelationEN.SchoolTerm = objRow[convcc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objvcc_WorkStuRelationEN.ErrMsg = objRow[convcc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objvcc_WorkStuRelationEN.UpdDate = objRow[convcc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelationEN.UpdUserId = objRow[convcc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkStuRelationEN.Memo = objRow[convcc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelationEN.IdWorkStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelationEN);
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
List<clsvcc_WorkStuRelationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_WorkStuRelationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_WorkStuRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_WorkStuRelationEN> arrObjLst = new List<clsvcc_WorkStuRelationEN>(); 
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
	clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = new clsvcc_WorkStuRelationEN();
try
{
objvcc_WorkStuRelationEN.IdWorkStuRelation = Int32.Parse(objRow[convcc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objvcc_WorkStuRelationEN.IdCurrEduCls = objRow[convcc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationEN.IdWorkEduClsRela = objRow[convcc_WorkStuRelation.IdWorkEduClsRela] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkStuRelationEN.QuestionId = objRow[convcc_WorkStuRelation.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkStuRelationEN.QuestionIndex = objRow[convcc_WorkStuRelation.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelationEN.QuestionName = objRow[convcc_WorkStuRelation.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelationEN.QuestionContent = objRow[convcc_WorkStuRelation.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelationEN.CourseId = objRow[convcc_WorkStuRelation.CourseId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelationEN.CourseName = objRow[convcc_WorkStuRelation.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelationEN.CourseChapterId = objRow[convcc_WorkStuRelation.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelationEN.CourseChapterName = objRow[convcc_WorkStuRelation.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelationEN.ChapterName = objRow[convcc_WorkStuRelation.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelationEN.SectionName = objRow[convcc_WorkStuRelation.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelationEN.ChapterNameSim = objRow[convcc_WorkStuRelation.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelationEN.SectionNameSim = objRow[convcc_WorkStuRelation.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelationEN.ParentNodeId = objRow[convcc_WorkStuRelation.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkStuRelationEN.CourseChapterReferred = objRow[convcc_WorkStuRelation.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelationEN.ParentNodeName = objRow[convcc_WorkStuRelation.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelationEN.ParentNodeReferred = objRow[convcc_WorkStuRelation.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelationEN.QuestionTypeId = objRow[convcc_WorkStuRelation.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationEN.QuestionTypeName = objRow[convcc_WorkStuRelation.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkStuRelationEN.AnswerTypeId = objRow[convcc_WorkStuRelation.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkStuRelationEN.DefaultValue = objRow[convcc_WorkStuRelation.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkStuRelationEN.TextDirectId = objRow[convcc_WorkStuRelation.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkStuRelationEN.RelaEvent = objRow[convcc_WorkStuRelation.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkStuRelationEN.CheckBoxLimitCount = objRow[convcc_WorkStuRelation.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkStuRelationEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelationEN.LimitedResourceType = objRow[convcc_WorkStuRelation.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkStuRelationEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelation.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationEN.QuestionTypeName4Course = objRow[convcc_WorkStuRelation.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkStuRelationEN.CurrEduClsId = objRow[convcc_WorkStuRelation.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkStuRelationEN.EduClsName = objRow[convcc_WorkStuRelation.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkStuRelationEN.TeacherId = objRow[convcc_WorkStuRelation.TeacherId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkStuRelationEN.PubDate = objRow[convcc_WorkStuRelation.PubDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.PubDate].ToString().Trim(); //发布日期
objvcc_WorkStuRelationEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkStuRelationEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkStuRelationEN.CourseStudentGroupId = objRow[convcc_WorkStuRelation.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkStuRelationEN.WorkTypeName = objRow[convcc_WorkStuRelation.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkStuRelationEN.Scores = objRow[convcc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkStuRelation.Scores].ToString().Trim()); //分值
objvcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[convcc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkStuRelationEN.IdStudentInfo = objRow[convcc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationEN.StuId = objRow[convcc_WorkStuRelation.StuId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuId].ToString().Trim(); //学号
objvcc_WorkStuRelationEN.StuName = objRow[convcc_WorkStuRelation.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelationEN.IdXzCollege = objRow[convcc_WorkStuRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelationEN.CollegeName = objRow[convcc_WorkStuRelation.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelationEN.CollegeNameA = objRow[convcc_WorkStuRelation.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelationEN.IdXzMajor = objRow[convcc_WorkStuRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelationEN.MajorId = objRow[convcc_WorkStuRelation.MajorId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorId].ToString().Trim(); //专业Id
objvcc_WorkStuRelationEN.MajorName = objRow[convcc_WorkStuRelation.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelationEN.IdGradeBase = objRow[convcc_WorkStuRelation.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelationEN.GradeBaseName = objRow[convcc_WorkStuRelation.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelationEN.AdminClsName = objRow[convcc_WorkStuRelation.AdminClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsName].ToString().Trim(); //行政班名称
objvcc_WorkStuRelationEN.AdminClsId = objRow[convcc_WorkStuRelation.AdminClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsId].ToString().Trim(); //行政班代号
objvcc_WorkStuRelationEN.AnswerModeId = objRow[convcc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkStuRelationEN.AnswerOptionId = objRow[convcc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_WorkStuRelationEN.AnswerMultiOptions = objRow[convcc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_WorkStuRelationEN.AnswerBoolResult = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objvcc_WorkStuRelationEN.StuAnswerText = objRow[convcc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_WorkStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objvcc_WorkStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objvcc_WorkStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objvcc_WorkStuRelationEN.ApplySendBackDate = objRow[convcc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objvcc_WorkStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objvcc_WorkStuRelationEN.RealFinishDate = objRow[convcc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_WorkStuRelationEN.OperateTime = objRow[convcc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objvcc_WorkStuRelationEN.Score = objRow[convcc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkStuRelation.Score].ToString().Trim()); //得分
objvcc_WorkStuRelationEN.Comment = objRow[convcc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Comment].ToString().Trim(); //批注
objvcc_WorkStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objvcc_WorkStuRelationEN.MarkerId = objRow[convcc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objvcc_WorkStuRelationEN.MarkDate = objRow[convcc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objvcc_WorkStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objvcc_WorkStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_WorkStuRelationEN.WorkTypeId = objRow[convcc_WorkStuRelation.WorkTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkStuRelationEN.AnswerIP = objRow[convcc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objvcc_WorkStuRelationEN.AnswerDate = objRow[convcc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objvcc_WorkStuRelationEN.AnswerTime = objRow[convcc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objvcc_WorkStuRelationEN.CourseExamPaperId = objRow[convcc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_WorkStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objvcc_WorkStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvcc_WorkStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_WorkStuRelationEN.SchoolYear = objRow[convcc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objvcc_WorkStuRelationEN.SchoolTerm = objRow[convcc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objvcc_WorkStuRelationEN.ErrMsg = objRow[convcc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objvcc_WorkStuRelationEN.UpdDate = objRow[convcc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelationEN.UpdUserId = objRow[convcc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkStuRelationEN.Memo = objRow[convcc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelationEN.IdWorkStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelationEN);
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
public static List<clsvcc_WorkStuRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_WorkStuRelationEN> arrObjLst = new List<clsvcc_WorkStuRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = new clsvcc_WorkStuRelationEN();
try
{
objvcc_WorkStuRelationEN.IdWorkStuRelation = Int32.Parse(objRow[convcc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objvcc_WorkStuRelationEN.IdCurrEduCls = objRow[convcc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationEN.IdWorkEduClsRela = objRow[convcc_WorkStuRelation.IdWorkEduClsRela] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkStuRelationEN.QuestionId = objRow[convcc_WorkStuRelation.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkStuRelationEN.QuestionIndex = objRow[convcc_WorkStuRelation.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelationEN.QuestionName = objRow[convcc_WorkStuRelation.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelationEN.QuestionContent = objRow[convcc_WorkStuRelation.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelationEN.CourseId = objRow[convcc_WorkStuRelation.CourseId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelationEN.CourseName = objRow[convcc_WorkStuRelation.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelationEN.CourseChapterId = objRow[convcc_WorkStuRelation.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelationEN.CourseChapterName = objRow[convcc_WorkStuRelation.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelationEN.ChapterName = objRow[convcc_WorkStuRelation.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelationEN.SectionName = objRow[convcc_WorkStuRelation.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelationEN.ChapterNameSim = objRow[convcc_WorkStuRelation.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelationEN.SectionNameSim = objRow[convcc_WorkStuRelation.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelationEN.ParentNodeId = objRow[convcc_WorkStuRelation.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkStuRelationEN.CourseChapterReferred = objRow[convcc_WorkStuRelation.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelationEN.ParentNodeName = objRow[convcc_WorkStuRelation.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelationEN.ParentNodeReferred = objRow[convcc_WorkStuRelation.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelationEN.QuestionTypeId = objRow[convcc_WorkStuRelation.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationEN.QuestionTypeName = objRow[convcc_WorkStuRelation.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkStuRelationEN.AnswerTypeId = objRow[convcc_WorkStuRelation.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkStuRelationEN.DefaultValue = objRow[convcc_WorkStuRelation.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkStuRelationEN.TextDirectId = objRow[convcc_WorkStuRelation.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkStuRelationEN.RelaEvent = objRow[convcc_WorkStuRelation.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkStuRelationEN.CheckBoxLimitCount = objRow[convcc_WorkStuRelation.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkStuRelationEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelationEN.LimitedResourceType = objRow[convcc_WorkStuRelation.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkStuRelationEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelation.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationEN.QuestionTypeName4Course = objRow[convcc_WorkStuRelation.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkStuRelationEN.CurrEduClsId = objRow[convcc_WorkStuRelation.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkStuRelationEN.EduClsName = objRow[convcc_WorkStuRelation.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkStuRelationEN.TeacherId = objRow[convcc_WorkStuRelation.TeacherId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkStuRelationEN.PubDate = objRow[convcc_WorkStuRelation.PubDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.PubDate].ToString().Trim(); //发布日期
objvcc_WorkStuRelationEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkStuRelationEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkStuRelationEN.CourseStudentGroupId = objRow[convcc_WorkStuRelation.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkStuRelationEN.WorkTypeName = objRow[convcc_WorkStuRelation.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkStuRelationEN.Scores = objRow[convcc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkStuRelation.Scores].ToString().Trim()); //分值
objvcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[convcc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkStuRelationEN.IdStudentInfo = objRow[convcc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationEN.StuId = objRow[convcc_WorkStuRelation.StuId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuId].ToString().Trim(); //学号
objvcc_WorkStuRelationEN.StuName = objRow[convcc_WorkStuRelation.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelationEN.IdXzCollege = objRow[convcc_WorkStuRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelationEN.CollegeName = objRow[convcc_WorkStuRelation.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelationEN.CollegeNameA = objRow[convcc_WorkStuRelation.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelationEN.IdXzMajor = objRow[convcc_WorkStuRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelationEN.MajorId = objRow[convcc_WorkStuRelation.MajorId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorId].ToString().Trim(); //专业Id
objvcc_WorkStuRelationEN.MajorName = objRow[convcc_WorkStuRelation.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelationEN.IdGradeBase = objRow[convcc_WorkStuRelation.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelationEN.GradeBaseName = objRow[convcc_WorkStuRelation.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelationEN.AdminClsName = objRow[convcc_WorkStuRelation.AdminClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsName].ToString().Trim(); //行政班名称
objvcc_WorkStuRelationEN.AdminClsId = objRow[convcc_WorkStuRelation.AdminClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsId].ToString().Trim(); //行政班代号
objvcc_WorkStuRelationEN.AnswerModeId = objRow[convcc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkStuRelationEN.AnswerOptionId = objRow[convcc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_WorkStuRelationEN.AnswerMultiOptions = objRow[convcc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_WorkStuRelationEN.AnswerBoolResult = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objvcc_WorkStuRelationEN.StuAnswerText = objRow[convcc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_WorkStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objvcc_WorkStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objvcc_WorkStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objvcc_WorkStuRelationEN.ApplySendBackDate = objRow[convcc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objvcc_WorkStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objvcc_WorkStuRelationEN.RealFinishDate = objRow[convcc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_WorkStuRelationEN.OperateTime = objRow[convcc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objvcc_WorkStuRelationEN.Score = objRow[convcc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkStuRelation.Score].ToString().Trim()); //得分
objvcc_WorkStuRelationEN.Comment = objRow[convcc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Comment].ToString().Trim(); //批注
objvcc_WorkStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objvcc_WorkStuRelationEN.MarkerId = objRow[convcc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objvcc_WorkStuRelationEN.MarkDate = objRow[convcc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objvcc_WorkStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objvcc_WorkStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_WorkStuRelationEN.WorkTypeId = objRow[convcc_WorkStuRelation.WorkTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkStuRelationEN.AnswerIP = objRow[convcc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objvcc_WorkStuRelationEN.AnswerDate = objRow[convcc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objvcc_WorkStuRelationEN.AnswerTime = objRow[convcc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objvcc_WorkStuRelationEN.CourseExamPaperId = objRow[convcc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_WorkStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objvcc_WorkStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvcc_WorkStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_WorkStuRelationEN.SchoolYear = objRow[convcc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objvcc_WorkStuRelationEN.SchoolTerm = objRow[convcc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objvcc_WorkStuRelationEN.ErrMsg = objRow[convcc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objvcc_WorkStuRelationEN.UpdDate = objRow[convcc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelationEN.UpdUserId = objRow[convcc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkStuRelationEN.Memo = objRow[convcc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelationEN.IdWorkStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_WorkStuRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_WorkStuRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_WorkStuRelationEN> arrObjLst = new List<clsvcc_WorkStuRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = new clsvcc_WorkStuRelationEN();
try
{
objvcc_WorkStuRelationEN.IdWorkStuRelation = Int32.Parse(objRow[convcc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objvcc_WorkStuRelationEN.IdCurrEduCls = objRow[convcc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationEN.IdWorkEduClsRela = objRow[convcc_WorkStuRelation.IdWorkEduClsRela] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkStuRelationEN.QuestionId = objRow[convcc_WorkStuRelation.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkStuRelationEN.QuestionIndex = objRow[convcc_WorkStuRelation.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelationEN.QuestionName = objRow[convcc_WorkStuRelation.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelationEN.QuestionContent = objRow[convcc_WorkStuRelation.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelationEN.CourseId = objRow[convcc_WorkStuRelation.CourseId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelationEN.CourseName = objRow[convcc_WorkStuRelation.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelationEN.CourseChapterId = objRow[convcc_WorkStuRelation.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelationEN.CourseChapterName = objRow[convcc_WorkStuRelation.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelationEN.ChapterName = objRow[convcc_WorkStuRelation.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelationEN.SectionName = objRow[convcc_WorkStuRelation.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelationEN.ChapterNameSim = objRow[convcc_WorkStuRelation.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelationEN.SectionNameSim = objRow[convcc_WorkStuRelation.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelationEN.ParentNodeId = objRow[convcc_WorkStuRelation.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkStuRelationEN.CourseChapterReferred = objRow[convcc_WorkStuRelation.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelationEN.ParentNodeName = objRow[convcc_WorkStuRelation.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelationEN.ParentNodeReferred = objRow[convcc_WorkStuRelation.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelationEN.QuestionTypeId = objRow[convcc_WorkStuRelation.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationEN.QuestionTypeName = objRow[convcc_WorkStuRelation.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkStuRelationEN.AnswerTypeId = objRow[convcc_WorkStuRelation.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkStuRelationEN.DefaultValue = objRow[convcc_WorkStuRelation.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkStuRelationEN.TextDirectId = objRow[convcc_WorkStuRelation.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkStuRelationEN.RelaEvent = objRow[convcc_WorkStuRelation.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkStuRelationEN.CheckBoxLimitCount = objRow[convcc_WorkStuRelation.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkStuRelationEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelationEN.LimitedResourceType = objRow[convcc_WorkStuRelation.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkStuRelationEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelation.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationEN.QuestionTypeName4Course = objRow[convcc_WorkStuRelation.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkStuRelationEN.CurrEduClsId = objRow[convcc_WorkStuRelation.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkStuRelationEN.EduClsName = objRow[convcc_WorkStuRelation.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkStuRelationEN.TeacherId = objRow[convcc_WorkStuRelation.TeacherId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkStuRelationEN.PubDate = objRow[convcc_WorkStuRelation.PubDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.PubDate].ToString().Trim(); //发布日期
objvcc_WorkStuRelationEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkStuRelationEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkStuRelationEN.CourseStudentGroupId = objRow[convcc_WorkStuRelation.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkStuRelationEN.WorkTypeName = objRow[convcc_WorkStuRelation.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkStuRelationEN.Scores = objRow[convcc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkStuRelation.Scores].ToString().Trim()); //分值
objvcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[convcc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkStuRelationEN.IdStudentInfo = objRow[convcc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationEN.StuId = objRow[convcc_WorkStuRelation.StuId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuId].ToString().Trim(); //学号
objvcc_WorkStuRelationEN.StuName = objRow[convcc_WorkStuRelation.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelationEN.IdXzCollege = objRow[convcc_WorkStuRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelationEN.CollegeName = objRow[convcc_WorkStuRelation.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelationEN.CollegeNameA = objRow[convcc_WorkStuRelation.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelationEN.IdXzMajor = objRow[convcc_WorkStuRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelationEN.MajorId = objRow[convcc_WorkStuRelation.MajorId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorId].ToString().Trim(); //专业Id
objvcc_WorkStuRelationEN.MajorName = objRow[convcc_WorkStuRelation.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelationEN.IdGradeBase = objRow[convcc_WorkStuRelation.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelationEN.GradeBaseName = objRow[convcc_WorkStuRelation.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelationEN.AdminClsName = objRow[convcc_WorkStuRelation.AdminClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsName].ToString().Trim(); //行政班名称
objvcc_WorkStuRelationEN.AdminClsId = objRow[convcc_WorkStuRelation.AdminClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsId].ToString().Trim(); //行政班代号
objvcc_WorkStuRelationEN.AnswerModeId = objRow[convcc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkStuRelationEN.AnswerOptionId = objRow[convcc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_WorkStuRelationEN.AnswerMultiOptions = objRow[convcc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_WorkStuRelationEN.AnswerBoolResult = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objvcc_WorkStuRelationEN.StuAnswerText = objRow[convcc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_WorkStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objvcc_WorkStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objvcc_WorkStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objvcc_WorkStuRelationEN.ApplySendBackDate = objRow[convcc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objvcc_WorkStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objvcc_WorkStuRelationEN.RealFinishDate = objRow[convcc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_WorkStuRelationEN.OperateTime = objRow[convcc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objvcc_WorkStuRelationEN.Score = objRow[convcc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkStuRelation.Score].ToString().Trim()); //得分
objvcc_WorkStuRelationEN.Comment = objRow[convcc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Comment].ToString().Trim(); //批注
objvcc_WorkStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objvcc_WorkStuRelationEN.MarkerId = objRow[convcc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objvcc_WorkStuRelationEN.MarkDate = objRow[convcc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objvcc_WorkStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objvcc_WorkStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_WorkStuRelationEN.WorkTypeId = objRow[convcc_WorkStuRelation.WorkTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkStuRelationEN.AnswerIP = objRow[convcc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objvcc_WorkStuRelationEN.AnswerDate = objRow[convcc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objvcc_WorkStuRelationEN.AnswerTime = objRow[convcc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objvcc_WorkStuRelationEN.CourseExamPaperId = objRow[convcc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_WorkStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objvcc_WorkStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvcc_WorkStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_WorkStuRelationEN.SchoolYear = objRow[convcc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objvcc_WorkStuRelationEN.SchoolTerm = objRow[convcc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objvcc_WorkStuRelationEN.ErrMsg = objRow[convcc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objvcc_WorkStuRelationEN.UpdDate = objRow[convcc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelationEN.UpdUserId = objRow[convcc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkStuRelationEN.Memo = objRow[convcc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelationEN.IdWorkStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelationEN);
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
public static List<clsvcc_WorkStuRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_WorkStuRelationEN> arrObjLst = new List<clsvcc_WorkStuRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = new clsvcc_WorkStuRelationEN();
try
{
objvcc_WorkStuRelationEN.IdWorkStuRelation = Int32.Parse(objRow[convcc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objvcc_WorkStuRelationEN.IdCurrEduCls = objRow[convcc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationEN.IdWorkEduClsRela = objRow[convcc_WorkStuRelation.IdWorkEduClsRela] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkStuRelationEN.QuestionId = objRow[convcc_WorkStuRelation.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkStuRelationEN.QuestionIndex = objRow[convcc_WorkStuRelation.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelationEN.QuestionName = objRow[convcc_WorkStuRelation.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelationEN.QuestionContent = objRow[convcc_WorkStuRelation.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelationEN.CourseId = objRow[convcc_WorkStuRelation.CourseId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelationEN.CourseName = objRow[convcc_WorkStuRelation.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelationEN.CourseChapterId = objRow[convcc_WorkStuRelation.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelationEN.CourseChapterName = objRow[convcc_WorkStuRelation.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelationEN.ChapterName = objRow[convcc_WorkStuRelation.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelationEN.SectionName = objRow[convcc_WorkStuRelation.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelationEN.ChapterNameSim = objRow[convcc_WorkStuRelation.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelationEN.SectionNameSim = objRow[convcc_WorkStuRelation.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelationEN.ParentNodeId = objRow[convcc_WorkStuRelation.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkStuRelationEN.CourseChapterReferred = objRow[convcc_WorkStuRelation.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelationEN.ParentNodeName = objRow[convcc_WorkStuRelation.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelationEN.ParentNodeReferred = objRow[convcc_WorkStuRelation.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelationEN.QuestionTypeId = objRow[convcc_WorkStuRelation.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationEN.QuestionTypeName = objRow[convcc_WorkStuRelation.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkStuRelationEN.AnswerTypeId = objRow[convcc_WorkStuRelation.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkStuRelationEN.DefaultValue = objRow[convcc_WorkStuRelation.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkStuRelationEN.TextDirectId = objRow[convcc_WorkStuRelation.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkStuRelationEN.RelaEvent = objRow[convcc_WorkStuRelation.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkStuRelationEN.CheckBoxLimitCount = objRow[convcc_WorkStuRelation.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkStuRelationEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelationEN.LimitedResourceType = objRow[convcc_WorkStuRelation.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkStuRelationEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelation.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationEN.QuestionTypeName4Course = objRow[convcc_WorkStuRelation.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkStuRelationEN.CurrEduClsId = objRow[convcc_WorkStuRelation.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkStuRelationEN.EduClsName = objRow[convcc_WorkStuRelation.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkStuRelationEN.TeacherId = objRow[convcc_WorkStuRelation.TeacherId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkStuRelationEN.PubDate = objRow[convcc_WorkStuRelation.PubDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.PubDate].ToString().Trim(); //发布日期
objvcc_WorkStuRelationEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkStuRelationEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkStuRelationEN.CourseStudentGroupId = objRow[convcc_WorkStuRelation.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkStuRelationEN.WorkTypeName = objRow[convcc_WorkStuRelation.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkStuRelationEN.Scores = objRow[convcc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkStuRelation.Scores].ToString().Trim()); //分值
objvcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[convcc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkStuRelationEN.IdStudentInfo = objRow[convcc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationEN.StuId = objRow[convcc_WorkStuRelation.StuId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuId].ToString().Trim(); //学号
objvcc_WorkStuRelationEN.StuName = objRow[convcc_WorkStuRelation.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelationEN.IdXzCollege = objRow[convcc_WorkStuRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelationEN.CollegeName = objRow[convcc_WorkStuRelation.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelationEN.CollegeNameA = objRow[convcc_WorkStuRelation.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelationEN.IdXzMajor = objRow[convcc_WorkStuRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelationEN.MajorId = objRow[convcc_WorkStuRelation.MajorId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorId].ToString().Trim(); //专业Id
objvcc_WorkStuRelationEN.MajorName = objRow[convcc_WorkStuRelation.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelationEN.IdGradeBase = objRow[convcc_WorkStuRelation.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelationEN.GradeBaseName = objRow[convcc_WorkStuRelation.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelationEN.AdminClsName = objRow[convcc_WorkStuRelation.AdminClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsName].ToString().Trim(); //行政班名称
objvcc_WorkStuRelationEN.AdminClsId = objRow[convcc_WorkStuRelation.AdminClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsId].ToString().Trim(); //行政班代号
objvcc_WorkStuRelationEN.AnswerModeId = objRow[convcc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkStuRelationEN.AnswerOptionId = objRow[convcc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_WorkStuRelationEN.AnswerMultiOptions = objRow[convcc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_WorkStuRelationEN.AnswerBoolResult = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objvcc_WorkStuRelationEN.StuAnswerText = objRow[convcc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_WorkStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objvcc_WorkStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objvcc_WorkStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objvcc_WorkStuRelationEN.ApplySendBackDate = objRow[convcc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objvcc_WorkStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objvcc_WorkStuRelationEN.RealFinishDate = objRow[convcc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_WorkStuRelationEN.OperateTime = objRow[convcc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objvcc_WorkStuRelationEN.Score = objRow[convcc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkStuRelation.Score].ToString().Trim()); //得分
objvcc_WorkStuRelationEN.Comment = objRow[convcc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Comment].ToString().Trim(); //批注
objvcc_WorkStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objvcc_WorkStuRelationEN.MarkerId = objRow[convcc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objvcc_WorkStuRelationEN.MarkDate = objRow[convcc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objvcc_WorkStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objvcc_WorkStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_WorkStuRelationEN.WorkTypeId = objRow[convcc_WorkStuRelation.WorkTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkStuRelationEN.AnswerIP = objRow[convcc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objvcc_WorkStuRelationEN.AnswerDate = objRow[convcc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objvcc_WorkStuRelationEN.AnswerTime = objRow[convcc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objvcc_WorkStuRelationEN.CourseExamPaperId = objRow[convcc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_WorkStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objvcc_WorkStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvcc_WorkStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_WorkStuRelationEN.SchoolYear = objRow[convcc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objvcc_WorkStuRelationEN.SchoolTerm = objRow[convcc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objvcc_WorkStuRelationEN.ErrMsg = objRow[convcc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objvcc_WorkStuRelationEN.UpdDate = objRow[convcc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelationEN.UpdUserId = objRow[convcc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkStuRelationEN.Memo = objRow[convcc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelationEN.IdWorkStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_WorkStuRelationEN> arrObjLst = new List<clsvcc_WorkStuRelationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = new clsvcc_WorkStuRelationEN();
try
{
objvcc_WorkStuRelationEN.IdWorkStuRelation = Int32.Parse(objRow[convcc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objvcc_WorkStuRelationEN.IdCurrEduCls = objRow[convcc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationEN.IdWorkEduClsRela = objRow[convcc_WorkStuRelation.IdWorkEduClsRela] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.IdWorkEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_WorkStuRelationEN.QuestionId = objRow[convcc_WorkStuRelation.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objvcc_WorkStuRelationEN.QuestionIndex = objRow[convcc_WorkStuRelation.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelationEN.QuestionName = objRow[convcc_WorkStuRelation.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelationEN.QuestionContent = objRow[convcc_WorkStuRelation.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelationEN.CourseId = objRow[convcc_WorkStuRelation.CourseId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelationEN.CourseName = objRow[convcc_WorkStuRelation.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelationEN.CourseChapterId = objRow[convcc_WorkStuRelation.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelationEN.CourseChapterName = objRow[convcc_WorkStuRelation.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelationEN.ChapterName = objRow[convcc_WorkStuRelation.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelationEN.SectionName = objRow[convcc_WorkStuRelation.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelationEN.ChapterNameSim = objRow[convcc_WorkStuRelation.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelationEN.SectionNameSim = objRow[convcc_WorkStuRelation.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelationEN.ParentNodeId = objRow[convcc_WorkStuRelation.ParentNodeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_WorkStuRelationEN.CourseChapterReferred = objRow[convcc_WorkStuRelation.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelationEN.ParentNodeName = objRow[convcc_WorkStuRelation.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelationEN.ParentNodeReferred = objRow[convcc_WorkStuRelation.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelationEN.QuestionTypeId = objRow[convcc_WorkStuRelation.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationEN.QuestionTypeName = objRow[convcc_WorkStuRelation.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_WorkStuRelationEN.AnswerTypeId = objRow[convcc_WorkStuRelation.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_WorkStuRelationEN.DefaultValue = objRow[convcc_WorkStuRelation.DefaultValue] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.DefaultValue].ToString().Trim(); //缺省值
objvcc_WorkStuRelationEN.TextDirectId = objRow[convcc_WorkStuRelation.TextDirectId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_WorkStuRelationEN.RelaEvent = objRow[convcc_WorkStuRelation.RelaEvent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RelaEvent].ToString().Trim(); //相关事件
objvcc_WorkStuRelationEN.CheckBoxLimitCount = objRow[convcc_WorkStuRelation.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_WorkStuRelationEN.AnswerAttLimitSize = objRow[convcc_WorkStuRelation.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvcc_WorkStuRelationEN.LimitedResourceType = objRow[convcc_WorkStuRelation.LimitedResourceType] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.LimitedResourceType].ToString().Trim(); //限制资源类型
objvcc_WorkStuRelationEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelation.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationEN.QuestionTypeName4Course = objRow[convcc_WorkStuRelation.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvcc_WorkStuRelationEN.CurrEduClsId = objRow[convcc_WorkStuRelation.CurrEduClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CurrEduClsId].ToString().Trim(); //教学班Id
objvcc_WorkStuRelationEN.EduClsName = objRow[convcc_WorkStuRelation.EduClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.EduClsName].ToString().Trim(); //教学班名
objvcc_WorkStuRelationEN.TeacherId = objRow[convcc_WorkStuRelation.TeacherId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.TeacherId].ToString().Trim(); //教师工号
objvcc_WorkStuRelationEN.PubDate = objRow[convcc_WorkStuRelation.PubDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.PubDate].ToString().Trim(); //发布日期
objvcc_WorkStuRelationEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_WorkStuRelationEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsGroupWork].ToString().Trim()); //是否为小组作业
objvcc_WorkStuRelationEN.CourseStudentGroupId = objRow[convcc_WorkStuRelation.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objvcc_WorkStuRelationEN.WorkTypeName = objRow[convcc_WorkStuRelation.WorkTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_WorkStuRelationEN.Scores = objRow[convcc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkStuRelation.Scores].ToString().Trim()); //分值
objvcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[convcc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_WorkStuRelationEN.IdStudentInfo = objRow[convcc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationEN.StuId = objRow[convcc_WorkStuRelation.StuId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuId].ToString().Trim(); //学号
objvcc_WorkStuRelationEN.StuName = objRow[convcc_WorkStuRelation.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelationEN.IdXzCollege = objRow[convcc_WorkStuRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelationEN.CollegeName = objRow[convcc_WorkStuRelation.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelationEN.CollegeNameA = objRow[convcc_WorkStuRelation.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelationEN.IdXzMajor = objRow[convcc_WorkStuRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelationEN.MajorId = objRow[convcc_WorkStuRelation.MajorId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorId].ToString().Trim(); //专业Id
objvcc_WorkStuRelationEN.MajorName = objRow[convcc_WorkStuRelation.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelationEN.IdGradeBase = objRow[convcc_WorkStuRelation.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelationEN.GradeBaseName = objRow[convcc_WorkStuRelation.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelationEN.AdminClsName = objRow[convcc_WorkStuRelation.AdminClsName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsName].ToString().Trim(); //行政班名称
objvcc_WorkStuRelationEN.AdminClsId = objRow[convcc_WorkStuRelation.AdminClsId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AdminClsId].ToString().Trim(); //行政班代号
objvcc_WorkStuRelationEN.AnswerModeId = objRow[convcc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_WorkStuRelationEN.AnswerOptionId = objRow[convcc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_WorkStuRelationEN.AnswerMultiOptions = objRow[convcc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_WorkStuRelationEN.AnswerBoolResult = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objvcc_WorkStuRelationEN.StuAnswerText = objRow[convcc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_WorkStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objvcc_WorkStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objvcc_WorkStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objvcc_WorkStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objvcc_WorkStuRelationEN.ApplySendBackDate = objRow[convcc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objvcc_WorkStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objvcc_WorkStuRelationEN.RealFinishDate = objRow[convcc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_WorkStuRelationEN.OperateTime = objRow[convcc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objvcc_WorkStuRelationEN.Score = objRow[convcc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_WorkStuRelation.Score].ToString().Trim()); //得分
objvcc_WorkStuRelationEN.Comment = objRow[convcc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Comment].ToString().Trim(); //批注
objvcc_WorkStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objvcc_WorkStuRelationEN.MarkerId = objRow[convcc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objvcc_WorkStuRelationEN.MarkDate = objRow[convcc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objvcc_WorkStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objvcc_WorkStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_WorkStuRelationEN.WorkTypeId = objRow[convcc_WorkStuRelation.WorkTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_WorkStuRelationEN.AnswerIP = objRow[convcc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objvcc_WorkStuRelationEN.AnswerDate = objRow[convcc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objvcc_WorkStuRelationEN.AnswerTime = objRow[convcc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objvcc_WorkStuRelationEN.CourseExamPaperId = objRow[convcc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_WorkStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objvcc_WorkStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvcc_WorkStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_WorkStuRelationEN.SchoolYear = objRow[convcc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objvcc_WorkStuRelationEN.SchoolTerm = objRow[convcc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objvcc_WorkStuRelationEN.ErrMsg = objRow[convcc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objvcc_WorkStuRelationEN.UpdDate = objRow[convcc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelationEN.UpdUserId = objRow[convcc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_WorkStuRelationEN.Memo = objRow[convcc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelationEN.IdWorkStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_WorkStuRelation(ref clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN)
{
bool bolResult = vcc_WorkStuRelationDA.Getvcc_WorkStuRelation(ref objvcc_WorkStuRelationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdWorkStuRelation">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkStuRelationEN GetObjByIdWorkStuRelation(long lngIdWorkStuRelation)
{
clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = vcc_WorkStuRelationDA.GetObjByIdWorkStuRelation(lngIdWorkStuRelation);
return objvcc_WorkStuRelationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_WorkStuRelationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = vcc_WorkStuRelationDA.GetFirstObj(strWhereCond);
 return objvcc_WorkStuRelationEN;
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
public static clsvcc_WorkStuRelationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = vcc_WorkStuRelationDA.GetObjByDataRow(objRow);
 return objvcc_WorkStuRelationEN;
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
public static clsvcc_WorkStuRelationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = vcc_WorkStuRelationDA.GetObjByDataRow(objRow);
 return objvcc_WorkStuRelationEN;
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
 /// <param name = "lngIdWorkStuRelation">所给的关键字</param>
 /// <param name = "lstvcc_WorkStuRelationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkStuRelationEN GetObjByIdWorkStuRelationFromList(long lngIdWorkStuRelation, List<clsvcc_WorkStuRelationEN> lstvcc_WorkStuRelationObjLst)
{
foreach (clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN in lstvcc_WorkStuRelationObjLst)
{
if (objvcc_WorkStuRelationEN.IdWorkStuRelation == lngIdWorkStuRelation)
{
return objvcc_WorkStuRelationEN;
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
 long lngIdWorkStuRelation;
 try
 {
 lngIdWorkStuRelation = new clsvcc_WorkStuRelationDA().GetFirstID(strWhereCond);
 return lngIdWorkStuRelation;
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
 arrList = vcc_WorkStuRelationDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_WorkStuRelationDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdWorkStuRelation">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdWorkStuRelation)
{
//检测记录是否存在
bool bolIsExist = vcc_WorkStuRelationDA.IsExist(lngIdWorkStuRelation);
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
 bolIsExist = clsvcc_WorkStuRelationDA.IsExistTable();
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
 bolIsExist = vcc_WorkStuRelationDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_WorkStuRelationENS">源对象</param>
 /// <param name = "objvcc_WorkStuRelationENT">目标对象</param>
 public static void CopyTo(clsvcc_WorkStuRelationEN objvcc_WorkStuRelationENS, clsvcc_WorkStuRelationEN objvcc_WorkStuRelationENT)
{
try
{
objvcc_WorkStuRelationENT.IdWorkStuRelation = objvcc_WorkStuRelationENS.IdWorkStuRelation; //流水号
objvcc_WorkStuRelationENT.IdCurrEduCls = objvcc_WorkStuRelationENS.IdCurrEduCls; //教学班流水号
objvcc_WorkStuRelationENT.IdWorkEduClsRela = objvcc_WorkStuRelationENS.IdWorkEduClsRela; //作业教学班关系流水号
objvcc_WorkStuRelationENT.QuestionId = objvcc_WorkStuRelationENS.QuestionId; //题目Id
objvcc_WorkStuRelationENT.QuestionIndex = objvcc_WorkStuRelationENS.QuestionIndex; //题目序号
objvcc_WorkStuRelationENT.QuestionName = objvcc_WorkStuRelationENS.QuestionName; //题目名称
objvcc_WorkStuRelationENT.QuestionContent = objvcc_WorkStuRelationENS.QuestionContent; //题目内容
objvcc_WorkStuRelationENT.CourseId = objvcc_WorkStuRelationENS.CourseId; //课程Id
objvcc_WorkStuRelationENT.CourseName = objvcc_WorkStuRelationENS.CourseName; //课程名称
objvcc_WorkStuRelationENT.CourseChapterId = objvcc_WorkStuRelationENS.CourseChapterId; //课程章节ID
objvcc_WorkStuRelationENT.CourseChapterName = objvcc_WorkStuRelationENS.CourseChapterName; //课程章节名称
objvcc_WorkStuRelationENT.ChapterName = objvcc_WorkStuRelationENS.ChapterName; //章名
objvcc_WorkStuRelationENT.SectionName = objvcc_WorkStuRelationENS.SectionName; //节名
objvcc_WorkStuRelationENT.ChapterNameSim = objvcc_WorkStuRelationENS.ChapterNameSim; //章名简称
objvcc_WorkStuRelationENT.SectionNameSim = objvcc_WorkStuRelationENS.SectionNameSim; //节名简称
objvcc_WorkStuRelationENT.ParentNodeId = objvcc_WorkStuRelationENS.ParentNodeId; //父节点编号
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
objvcc_WorkStuRelationENT.CurrEduClsId = objvcc_WorkStuRelationENS.CurrEduClsId; //教学班Id
objvcc_WorkStuRelationENT.EduClsName = objvcc_WorkStuRelationENS.EduClsName; //教学班名
objvcc_WorkStuRelationENT.TeacherId = objvcc_WorkStuRelationENS.TeacherId; //教师工号
objvcc_WorkStuRelationENT.PubDate = objvcc_WorkStuRelationENS.PubDate; //发布日期
objvcc_WorkStuRelationENT.IsCurrEduCls = objvcc_WorkStuRelationENS.IsCurrEduCls; //是否为教学班作业
objvcc_WorkStuRelationENT.IsGroupWork = objvcc_WorkStuRelationENS.IsGroupWork; //是否为小组作业
objvcc_WorkStuRelationENT.CourseStudentGroupId = objvcc_WorkStuRelationENS.CourseStudentGroupId; //学生分组表流水号
objvcc_WorkStuRelationENT.WorkTypeName = objvcc_WorkStuRelationENS.WorkTypeName; //作业类型名称
objvcc_WorkStuRelationENT.Scores = objvcc_WorkStuRelationENS.Scores; //分值
objvcc_WorkStuRelationENT.SpecifyCompletionDate = objvcc_WorkStuRelationENS.SpecifyCompletionDate; //指定完成日期
objvcc_WorkStuRelationENT.IdStudentInfo = objvcc_WorkStuRelationENS.IdStudentInfo; //学生流水号
objvcc_WorkStuRelationENT.StuId = objvcc_WorkStuRelationENS.StuId; //学号
objvcc_WorkStuRelationENT.StuName = objvcc_WorkStuRelationENS.StuName; //姓名
objvcc_WorkStuRelationENT.IdXzCollege = objvcc_WorkStuRelationENS.IdXzCollege; //学院流水号
objvcc_WorkStuRelationENT.CollegeName = objvcc_WorkStuRelationENS.CollegeName; //学院名称
objvcc_WorkStuRelationENT.CollegeNameA = objvcc_WorkStuRelationENS.CollegeNameA; //学院名称简写
objvcc_WorkStuRelationENT.IdXzMajor = objvcc_WorkStuRelationENS.IdXzMajor; //专业流水号
objvcc_WorkStuRelationENT.MajorId = objvcc_WorkStuRelationENS.MajorId; //专业Id
objvcc_WorkStuRelationENT.MajorName = objvcc_WorkStuRelationENS.MajorName; //专业名称
objvcc_WorkStuRelationENT.IdGradeBase = objvcc_WorkStuRelationENS.IdGradeBase; //年级流水号
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
 /// <param name = "objvcc_WorkStuRelationEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN)
{
try
{
objvcc_WorkStuRelationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_WorkStuRelationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_WorkStuRelation.IdWorkStuRelation, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.IdWorkStuRelation = objvcc_WorkStuRelationEN.IdWorkStuRelation; //流水号
}
if (arrFldSet.Contains(convcc_WorkStuRelation.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.IdCurrEduCls = objvcc_WorkStuRelationEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convcc_WorkStuRelation.IdWorkEduClsRela, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.IdWorkEduClsRela = objvcc_WorkStuRelationEN.IdWorkEduClsRela; //作业教学班关系流水号
}
if (arrFldSet.Contains(convcc_WorkStuRelation.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.QuestionId = objvcc_WorkStuRelationEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(convcc_WorkStuRelation.QuestionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.QuestionIndex = objvcc_WorkStuRelationEN.QuestionIndex; //题目序号
}
if (arrFldSet.Contains(convcc_WorkStuRelation.QuestionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.QuestionName = objvcc_WorkStuRelationEN.QuestionName == "[null]" ? null :  objvcc_WorkStuRelationEN.QuestionName; //题目名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation.QuestionContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.QuestionContent = objvcc_WorkStuRelationEN.QuestionContent == "[null]" ? null :  objvcc_WorkStuRelationEN.QuestionContent; //题目内容
}
if (arrFldSet.Contains(convcc_WorkStuRelation.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.CourseId = objvcc_WorkStuRelationEN.CourseId == "[null]" ? null :  objvcc_WorkStuRelationEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_WorkStuRelation.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.CourseName = objvcc_WorkStuRelationEN.CourseName == "[null]" ? null :  objvcc_WorkStuRelationEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.CourseChapterId = objvcc_WorkStuRelationEN.CourseChapterId == "[null]" ? null :  objvcc_WorkStuRelationEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convcc_WorkStuRelation.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.CourseChapterName = objvcc_WorkStuRelationEN.CourseChapterName == "[null]" ? null :  objvcc_WorkStuRelationEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation.ChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.ChapterName = objvcc_WorkStuRelationEN.ChapterName == "[null]" ? null :  objvcc_WorkStuRelationEN.ChapterName; //章名
}
if (arrFldSet.Contains(convcc_WorkStuRelation.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.SectionName = objvcc_WorkStuRelationEN.SectionName == "[null]" ? null :  objvcc_WorkStuRelationEN.SectionName; //节名
}
if (arrFldSet.Contains(convcc_WorkStuRelation.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.ChapterNameSim = objvcc_WorkStuRelationEN.ChapterNameSim == "[null]" ? null :  objvcc_WorkStuRelationEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(convcc_WorkStuRelation.SectionNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.SectionNameSim = objvcc_WorkStuRelationEN.SectionNameSim == "[null]" ? null :  objvcc_WorkStuRelationEN.SectionNameSim; //节名简称
}
if (arrFldSet.Contains(convcc_WorkStuRelation.ParentNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.ParentNodeId = objvcc_WorkStuRelationEN.ParentNodeId == "[null]" ? null :  objvcc_WorkStuRelationEN.ParentNodeId; //父节点编号
}
if (arrFldSet.Contains(convcc_WorkStuRelation.CourseChapterReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.CourseChapterReferred = objvcc_WorkStuRelationEN.CourseChapterReferred == "[null]" ? null :  objvcc_WorkStuRelationEN.CourseChapterReferred; //节简称
}
if (arrFldSet.Contains(convcc_WorkStuRelation.ParentNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.ParentNodeName = objvcc_WorkStuRelationEN.ParentNodeName == "[null]" ? null :  objvcc_WorkStuRelationEN.ParentNodeName; //父节点名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation.ParentNodeReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.ParentNodeReferred = objvcc_WorkStuRelationEN.ParentNodeReferred == "[null]" ? null :  objvcc_WorkStuRelationEN.ParentNodeReferred; //章简称
}
if (arrFldSet.Contains(convcc_WorkStuRelation.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.QuestionTypeId = objvcc_WorkStuRelationEN.QuestionTypeId == "[null]" ? null :  objvcc_WorkStuRelationEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(convcc_WorkStuRelation.QuestionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.QuestionTypeName = objvcc_WorkStuRelationEN.QuestionTypeName == "[null]" ? null :  objvcc_WorkStuRelationEN.QuestionTypeName; //题目类型名
}
if (arrFldSet.Contains(convcc_WorkStuRelation.AnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.AnswerTypeId = objvcc_WorkStuRelationEN.AnswerTypeId == "[null]" ? null :  objvcc_WorkStuRelationEN.AnswerTypeId; //答案类型ID
}
if (arrFldSet.Contains(convcc_WorkStuRelation.DefaultValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.DefaultValue = objvcc_WorkStuRelationEN.DefaultValue == "[null]" ? null :  objvcc_WorkStuRelationEN.DefaultValue; //缺省值
}
if (arrFldSet.Contains(convcc_WorkStuRelation.TextDirectId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.TextDirectId = objvcc_WorkStuRelationEN.TextDirectId == "[null]" ? null :  objvcc_WorkStuRelationEN.TextDirectId; //文本方向ID
}
if (arrFldSet.Contains(convcc_WorkStuRelation.RelaEvent, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.RelaEvent = objvcc_WorkStuRelationEN.RelaEvent == "[null]" ? null :  objvcc_WorkStuRelationEN.RelaEvent; //相关事件
}
if (arrFldSet.Contains(convcc_WorkStuRelation.CheckBoxLimitCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.CheckBoxLimitCount = objvcc_WorkStuRelationEN.CheckBoxLimitCount; //复选框限制数
}
if (arrFldSet.Contains(convcc_WorkStuRelation.AnswerAttLimitSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.AnswerAttLimitSize = objvcc_WorkStuRelationEN.AnswerAttLimitSize; //回答附件限制大小
}
if (arrFldSet.Contains(convcc_WorkStuRelation.LimitedResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.LimitedResourceType = objvcc_WorkStuRelationEN.LimitedResourceType == "[null]" ? null :  objvcc_WorkStuRelationEN.LimitedResourceType; //限制资源类型
}
if (arrFldSet.Contains(convcc_WorkStuRelation.QuestionTypeId4Course, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.QuestionTypeId4Course = objvcc_WorkStuRelationEN.QuestionTypeId4Course == "[null]" ? null :  objvcc_WorkStuRelationEN.QuestionTypeId4Course; //题目类型Id4课程
}
if (arrFldSet.Contains(convcc_WorkStuRelation.QuestionTypeName4Course, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.QuestionTypeName4Course = objvcc_WorkStuRelationEN.QuestionTypeName4Course == "[null]" ? null :  objvcc_WorkStuRelationEN.QuestionTypeName4Course; //题目类型名4课程
}
if (arrFldSet.Contains(convcc_WorkStuRelation.CurrEduClsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.CurrEduClsId = objvcc_WorkStuRelationEN.CurrEduClsId == "[null]" ? null :  objvcc_WorkStuRelationEN.CurrEduClsId; //教学班Id
}
if (arrFldSet.Contains(convcc_WorkStuRelation.EduClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.EduClsName = objvcc_WorkStuRelationEN.EduClsName == "[null]" ? null :  objvcc_WorkStuRelationEN.EduClsName; //教学班名
}
if (arrFldSet.Contains(convcc_WorkStuRelation.TeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.TeacherId = objvcc_WorkStuRelationEN.TeacherId == "[null]" ? null :  objvcc_WorkStuRelationEN.TeacherId; //教师工号
}
if (arrFldSet.Contains(convcc_WorkStuRelation.PubDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.PubDate = objvcc_WorkStuRelationEN.PubDate == "[null]" ? null :  objvcc_WorkStuRelationEN.PubDate; //发布日期
}
if (arrFldSet.Contains(convcc_WorkStuRelation.IsCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.IsCurrEduCls = objvcc_WorkStuRelationEN.IsCurrEduCls; //是否为教学班作业
}
if (arrFldSet.Contains(convcc_WorkStuRelation.IsGroupWork, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.IsGroupWork = objvcc_WorkStuRelationEN.IsGroupWork; //是否为小组作业
}
if (arrFldSet.Contains(convcc_WorkStuRelation.CourseStudentGroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.CourseStudentGroupId = objvcc_WorkStuRelationEN.CourseStudentGroupId; //学生分组表流水号
}
if (arrFldSet.Contains(convcc_WorkStuRelation.WorkTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.WorkTypeName = objvcc_WorkStuRelationEN.WorkTypeName == "[null]" ? null :  objvcc_WorkStuRelationEN.WorkTypeName; //作业类型名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation.Scores, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.Scores = objvcc_WorkStuRelationEN.Scores; //分值
}
if (arrFldSet.Contains(convcc_WorkStuRelation.SpecifyCompletionDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.SpecifyCompletionDate = objvcc_WorkStuRelationEN.SpecifyCompletionDate; //指定完成日期
}
if (arrFldSet.Contains(convcc_WorkStuRelation.IdStudentInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.IdStudentInfo = objvcc_WorkStuRelationEN.IdStudentInfo; //学生流水号
}
if (arrFldSet.Contains(convcc_WorkStuRelation.StuId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.StuId = objvcc_WorkStuRelationEN.StuId == "[null]" ? null :  objvcc_WorkStuRelationEN.StuId; //学号
}
if (arrFldSet.Contains(convcc_WorkStuRelation.StuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.StuName = objvcc_WorkStuRelationEN.StuName == "[null]" ? null :  objvcc_WorkStuRelationEN.StuName; //姓名
}
if (arrFldSet.Contains(convcc_WorkStuRelation.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.IdXzCollege = objvcc_WorkStuRelationEN.IdXzCollege == "[null]" ? null :  objvcc_WorkStuRelationEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convcc_WorkStuRelation.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.CollegeName = objvcc_WorkStuRelationEN.CollegeName == "[null]" ? null :  objvcc_WorkStuRelationEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.CollegeNameA = objvcc_WorkStuRelationEN.CollegeNameA == "[null]" ? null :  objvcc_WorkStuRelationEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convcc_WorkStuRelation.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.IdXzMajor = objvcc_WorkStuRelationEN.IdXzMajor == "[null]" ? null :  objvcc_WorkStuRelationEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convcc_WorkStuRelation.MajorId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.MajorId = objvcc_WorkStuRelationEN.MajorId == "[null]" ? null :  objvcc_WorkStuRelationEN.MajorId; //专业Id
}
if (arrFldSet.Contains(convcc_WorkStuRelation.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.MajorName = objvcc_WorkStuRelationEN.MajorName == "[null]" ? null :  objvcc_WorkStuRelationEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.IdGradeBase = objvcc_WorkStuRelationEN.IdGradeBase == "[null]" ? null :  objvcc_WorkStuRelationEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(convcc_WorkStuRelation.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.GradeBaseName = objvcc_WorkStuRelationEN.GradeBaseName == "[null]" ? null :  objvcc_WorkStuRelationEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation.AdminClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.AdminClsName = objvcc_WorkStuRelationEN.AdminClsName == "[null]" ? null :  objvcc_WorkStuRelationEN.AdminClsName; //行政班名称
}
if (arrFldSet.Contains(convcc_WorkStuRelation.AdminClsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.AdminClsId = objvcc_WorkStuRelationEN.AdminClsId == "[null]" ? null :  objvcc_WorkStuRelationEN.AdminClsId; //行政班代号
}
if (arrFldSet.Contains(convcc_WorkStuRelation.AnswerModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.AnswerModeId = objvcc_WorkStuRelationEN.AnswerModeId == "[null]" ? null :  objvcc_WorkStuRelationEN.AnswerModeId; //答案模式Id
}
if (arrFldSet.Contains(convcc_WorkStuRelation.AnswerOptionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.AnswerOptionId = objvcc_WorkStuRelationEN.AnswerOptionId == "[null]" ? null :  objvcc_WorkStuRelationEN.AnswerOptionId; //回答选项Id
}
if (arrFldSet.Contains(convcc_WorkStuRelation.AnswerMultiOptions, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.AnswerMultiOptions = objvcc_WorkStuRelationEN.AnswerMultiOptions == "[null]" ? null :  objvcc_WorkStuRelationEN.AnswerMultiOptions; //多选项答案
}
if (arrFldSet.Contains(convcc_WorkStuRelation.AnswerBoolResult, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.AnswerBoolResult = objvcc_WorkStuRelationEN.AnswerBoolResult; //答案布尔结果
}
if (arrFldSet.Contains(convcc_WorkStuRelation.StuAnswerText, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.StuAnswerText = objvcc_WorkStuRelationEN.StuAnswerText == "[null]" ? null :  objvcc_WorkStuRelationEN.StuAnswerText; //学生回答文本
}
if (arrFldSet.Contains(convcc_WorkStuRelation.IsPublish, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.IsPublish = objvcc_WorkStuRelationEN.IsPublish; //是否发布
}
if (arrFldSet.Contains(convcc_WorkStuRelation.IsLook, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.IsLook = objvcc_WorkStuRelationEN.IsLook; //是否查看
}
if (arrFldSet.Contains(convcc_WorkStuRelation.IsSave, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.IsSave = objvcc_WorkStuRelationEN.IsSave; //是否保存
}
if (arrFldSet.Contains(convcc_WorkStuRelation.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.IsSubmit = objvcc_WorkStuRelationEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convcc_WorkStuRelation.ApplySendBackDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.ApplySendBackDate = objvcc_WorkStuRelationEN.ApplySendBackDate == "[null]" ? null :  objvcc_WorkStuRelationEN.ApplySendBackDate; //申请退回日期
}
if (arrFldSet.Contains(convcc_WorkStuRelation.IsApplySendBack, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.IsApplySendBack = objvcc_WorkStuRelationEN.IsApplySendBack; //是否申请退回
}
if (arrFldSet.Contains(convcc_WorkStuRelation.RealFinishDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.RealFinishDate = objvcc_WorkStuRelationEN.RealFinishDate == "[null]" ? null :  objvcc_WorkStuRelationEN.RealFinishDate; //实际完成日期
}
if (arrFldSet.Contains(convcc_WorkStuRelation.OperateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.OperateTime = objvcc_WorkStuRelationEN.OperateTime == "[null]" ? null :  objvcc_WorkStuRelationEN.OperateTime; //操作时间
}
if (arrFldSet.Contains(convcc_WorkStuRelation.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.Score = objvcc_WorkStuRelationEN.Score; //得分
}
if (arrFldSet.Contains(convcc_WorkStuRelation.Comment, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.Comment = objvcc_WorkStuRelationEN.Comment == "[null]" ? null :  objvcc_WorkStuRelationEN.Comment; //批注
}
if (arrFldSet.Contains(convcc_WorkStuRelation.IsMarking, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.IsMarking = objvcc_WorkStuRelationEN.IsMarking; //是否批阅
}
if (arrFldSet.Contains(convcc_WorkStuRelation.MarkerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.MarkerId = objvcc_WorkStuRelationEN.MarkerId == "[null]" ? null :  objvcc_WorkStuRelationEN.MarkerId; //打分者
}
if (arrFldSet.Contains(convcc_WorkStuRelation.MarkDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.MarkDate = objvcc_WorkStuRelationEN.MarkDate == "[null]" ? null :  objvcc_WorkStuRelationEN.MarkDate; //打分日期
}
if (arrFldSet.Contains(convcc_WorkStuRelation.IsSendBack, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.IsSendBack = objvcc_WorkStuRelationEN.IsSendBack; //是否退回
}
if (arrFldSet.Contains(convcc_WorkStuRelation.IsInErrorQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.IsInErrorQuestion = objvcc_WorkStuRelationEN.IsInErrorQuestion; //是否进入错题
}
if (arrFldSet.Contains(convcc_WorkStuRelation.WorkTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.WorkTypeId = objvcc_WorkStuRelationEN.WorkTypeId == "[null]" ? null :  objvcc_WorkStuRelationEN.WorkTypeId; //作业类型Id
}
if (arrFldSet.Contains(convcc_WorkStuRelation.AnswerIP, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.AnswerIP = objvcc_WorkStuRelationEN.AnswerIP == "[null]" ? null :  objvcc_WorkStuRelationEN.AnswerIP; //回答IP
}
if (arrFldSet.Contains(convcc_WorkStuRelation.AnswerDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.AnswerDate = objvcc_WorkStuRelationEN.AnswerDate == "[null]" ? null :  objvcc_WorkStuRelationEN.AnswerDate; //回答日期
}
if (arrFldSet.Contains(convcc_WorkStuRelation.AnswerTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.AnswerTime = objvcc_WorkStuRelationEN.AnswerTime == "[null]" ? null :  objvcc_WorkStuRelationEN.AnswerTime; //回答时间
}
if (arrFldSet.Contains(convcc_WorkStuRelation.CourseExamPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.CourseExamPaperId = objvcc_WorkStuRelationEN.CourseExamPaperId == "[null]" ? null :  objvcc_WorkStuRelationEN.CourseExamPaperId; //考卷流水号
}
if (arrFldSet.Contains(convcc_WorkStuRelation.IsRight, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.IsRight = objvcc_WorkStuRelationEN.IsRight; //是否正确
}
if (arrFldSet.Contains(convcc_WorkStuRelation.IsAccessKnowledge, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.IsAccessKnowledge = objvcc_WorkStuRelationEN.IsAccessKnowledge; //是否处理知识点
}
if (arrFldSet.Contains(convcc_WorkStuRelation.IsNotProcessTimeout, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.IsNotProcessTimeout = objvcc_WorkStuRelationEN.IsNotProcessTimeout; //是否不处理超时
}
if (arrFldSet.Contains(convcc_WorkStuRelation.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.SchoolYear = objvcc_WorkStuRelationEN.SchoolYear == "[null]" ? null :  objvcc_WorkStuRelationEN.SchoolYear; //学年
}
if (arrFldSet.Contains(convcc_WorkStuRelation.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.SchoolTerm = objvcc_WorkStuRelationEN.SchoolTerm == "[null]" ? null :  objvcc_WorkStuRelationEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(convcc_WorkStuRelation.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.ErrMsg = objvcc_WorkStuRelationEN.ErrMsg == "[null]" ? null :  objvcc_WorkStuRelationEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(convcc_WorkStuRelation.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.UpdDate = objvcc_WorkStuRelationEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_WorkStuRelation.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.UpdUserId = objvcc_WorkStuRelationEN.UpdUserId == "[null]" ? null :  objvcc_WorkStuRelationEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convcc_WorkStuRelation.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationEN.Memo = objvcc_WorkStuRelationEN.Memo == "[null]" ? null :  objvcc_WorkStuRelationEN.Memo; //备注
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
 /// <param name = "objvcc_WorkStuRelationEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN)
{
try
{
if (objvcc_WorkStuRelationEN.QuestionName == "[null]") objvcc_WorkStuRelationEN.QuestionName = null; //题目名称
if (objvcc_WorkStuRelationEN.QuestionContent == "[null]") objvcc_WorkStuRelationEN.QuestionContent = null; //题目内容
if (objvcc_WorkStuRelationEN.CourseId == "[null]") objvcc_WorkStuRelationEN.CourseId = null; //课程Id
if (objvcc_WorkStuRelationEN.CourseName == "[null]") objvcc_WorkStuRelationEN.CourseName = null; //课程名称
if (objvcc_WorkStuRelationEN.CourseChapterId == "[null]") objvcc_WorkStuRelationEN.CourseChapterId = null; //课程章节ID
if (objvcc_WorkStuRelationEN.CourseChapterName == "[null]") objvcc_WorkStuRelationEN.CourseChapterName = null; //课程章节名称
if (objvcc_WorkStuRelationEN.ChapterName == "[null]") objvcc_WorkStuRelationEN.ChapterName = null; //章名
if (objvcc_WorkStuRelationEN.SectionName == "[null]") objvcc_WorkStuRelationEN.SectionName = null; //节名
if (objvcc_WorkStuRelationEN.ChapterNameSim == "[null]") objvcc_WorkStuRelationEN.ChapterNameSim = null; //章名简称
if (objvcc_WorkStuRelationEN.SectionNameSim == "[null]") objvcc_WorkStuRelationEN.SectionNameSim = null; //节名简称
if (objvcc_WorkStuRelationEN.ParentNodeId == "[null]") objvcc_WorkStuRelationEN.ParentNodeId = null; //父节点编号
if (objvcc_WorkStuRelationEN.CourseChapterReferred == "[null]") objvcc_WorkStuRelationEN.CourseChapterReferred = null; //节简称
if (objvcc_WorkStuRelationEN.ParentNodeName == "[null]") objvcc_WorkStuRelationEN.ParentNodeName = null; //父节点名称
if (objvcc_WorkStuRelationEN.ParentNodeReferred == "[null]") objvcc_WorkStuRelationEN.ParentNodeReferred = null; //章简称
if (objvcc_WorkStuRelationEN.QuestionTypeId == "[null]") objvcc_WorkStuRelationEN.QuestionTypeId = null; //题目类型Id
if (objvcc_WorkStuRelationEN.QuestionTypeName == "[null]") objvcc_WorkStuRelationEN.QuestionTypeName = null; //题目类型名
if (objvcc_WorkStuRelationEN.AnswerTypeId == "[null]") objvcc_WorkStuRelationEN.AnswerTypeId = null; //答案类型ID
if (objvcc_WorkStuRelationEN.DefaultValue == "[null]") objvcc_WorkStuRelationEN.DefaultValue = null; //缺省值
if (objvcc_WorkStuRelationEN.TextDirectId == "[null]") objvcc_WorkStuRelationEN.TextDirectId = null; //文本方向ID
if (objvcc_WorkStuRelationEN.RelaEvent == "[null]") objvcc_WorkStuRelationEN.RelaEvent = null; //相关事件
if (objvcc_WorkStuRelationEN.LimitedResourceType == "[null]") objvcc_WorkStuRelationEN.LimitedResourceType = null; //限制资源类型
if (objvcc_WorkStuRelationEN.QuestionTypeId4Course == "[null]") objvcc_WorkStuRelationEN.QuestionTypeId4Course = null; //题目类型Id4课程
if (objvcc_WorkStuRelationEN.QuestionTypeName4Course == "[null]") objvcc_WorkStuRelationEN.QuestionTypeName4Course = null; //题目类型名4课程
if (objvcc_WorkStuRelationEN.CurrEduClsId == "[null]") objvcc_WorkStuRelationEN.CurrEduClsId = null; //教学班Id
if (objvcc_WorkStuRelationEN.EduClsName == "[null]") objvcc_WorkStuRelationEN.EduClsName = null; //教学班名
if (objvcc_WorkStuRelationEN.TeacherId == "[null]") objvcc_WorkStuRelationEN.TeacherId = null; //教师工号
if (objvcc_WorkStuRelationEN.PubDate == "[null]") objvcc_WorkStuRelationEN.PubDate = null; //发布日期
if (objvcc_WorkStuRelationEN.WorkTypeName == "[null]") objvcc_WorkStuRelationEN.WorkTypeName = null; //作业类型名称
if (objvcc_WorkStuRelationEN.StuId == "[null]") objvcc_WorkStuRelationEN.StuId = null; //学号
if (objvcc_WorkStuRelationEN.StuName == "[null]") objvcc_WorkStuRelationEN.StuName = null; //姓名
if (objvcc_WorkStuRelationEN.IdXzCollege == "[null]") objvcc_WorkStuRelationEN.IdXzCollege = null; //学院流水号
if (objvcc_WorkStuRelationEN.CollegeName == "[null]") objvcc_WorkStuRelationEN.CollegeName = null; //学院名称
if (objvcc_WorkStuRelationEN.CollegeNameA == "[null]") objvcc_WorkStuRelationEN.CollegeNameA = null; //学院名称简写
if (objvcc_WorkStuRelationEN.IdXzMajor == "[null]") objvcc_WorkStuRelationEN.IdXzMajor = null; //专业流水号
if (objvcc_WorkStuRelationEN.MajorId == "[null]") objvcc_WorkStuRelationEN.MajorId = null; //专业Id
if (objvcc_WorkStuRelationEN.MajorName == "[null]") objvcc_WorkStuRelationEN.MajorName = null; //专业名称
if (objvcc_WorkStuRelationEN.IdGradeBase == "[null]") objvcc_WorkStuRelationEN.IdGradeBase = null; //年级流水号
if (objvcc_WorkStuRelationEN.GradeBaseName == "[null]") objvcc_WorkStuRelationEN.GradeBaseName = null; //年级名称
if (objvcc_WorkStuRelationEN.AdminClsName == "[null]") objvcc_WorkStuRelationEN.AdminClsName = null; //行政班名称
if (objvcc_WorkStuRelationEN.AdminClsId == "[null]") objvcc_WorkStuRelationEN.AdminClsId = null; //行政班代号
if (objvcc_WorkStuRelationEN.AnswerModeId == "[null]") objvcc_WorkStuRelationEN.AnswerModeId = null; //答案模式Id
if (objvcc_WorkStuRelationEN.AnswerOptionId == "[null]") objvcc_WorkStuRelationEN.AnswerOptionId = null; //回答选项Id
if (objvcc_WorkStuRelationEN.AnswerMultiOptions == "[null]") objvcc_WorkStuRelationEN.AnswerMultiOptions = null; //多选项答案
if (objvcc_WorkStuRelationEN.StuAnswerText == "[null]") objvcc_WorkStuRelationEN.StuAnswerText = null; //学生回答文本
if (objvcc_WorkStuRelationEN.ApplySendBackDate == "[null]") objvcc_WorkStuRelationEN.ApplySendBackDate = null; //申请退回日期
if (objvcc_WorkStuRelationEN.RealFinishDate == "[null]") objvcc_WorkStuRelationEN.RealFinishDate = null; //实际完成日期
if (objvcc_WorkStuRelationEN.OperateTime == "[null]") objvcc_WorkStuRelationEN.OperateTime = null; //操作时间
if (objvcc_WorkStuRelationEN.Comment == "[null]") objvcc_WorkStuRelationEN.Comment = null; //批注
if (objvcc_WorkStuRelationEN.MarkerId == "[null]") objvcc_WorkStuRelationEN.MarkerId = null; //打分者
if (objvcc_WorkStuRelationEN.MarkDate == "[null]") objvcc_WorkStuRelationEN.MarkDate = null; //打分日期
if (objvcc_WorkStuRelationEN.WorkTypeId == "[null]") objvcc_WorkStuRelationEN.WorkTypeId = null; //作业类型Id
if (objvcc_WorkStuRelationEN.AnswerIP == "[null]") objvcc_WorkStuRelationEN.AnswerIP = null; //回答IP
if (objvcc_WorkStuRelationEN.AnswerDate == "[null]") objvcc_WorkStuRelationEN.AnswerDate = null; //回答日期
if (objvcc_WorkStuRelationEN.AnswerTime == "[null]") objvcc_WorkStuRelationEN.AnswerTime = null; //回答时间
if (objvcc_WorkStuRelationEN.CourseExamPaperId == "[null]") objvcc_WorkStuRelationEN.CourseExamPaperId = null; //考卷流水号
if (objvcc_WorkStuRelationEN.SchoolYear == "[null]") objvcc_WorkStuRelationEN.SchoolYear = null; //学年
if (objvcc_WorkStuRelationEN.SchoolTerm == "[null]") objvcc_WorkStuRelationEN.SchoolTerm = null; //学期
if (objvcc_WorkStuRelationEN.ErrMsg == "[null]") objvcc_WorkStuRelationEN.ErrMsg = null; //错误信息
if (objvcc_WorkStuRelationEN.UpdUserId == "[null]") objvcc_WorkStuRelationEN.UpdUserId = null; //修改用户Id
if (objvcc_WorkStuRelationEN.Memo == "[null]") objvcc_WorkStuRelationEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN)
{
 vcc_WorkStuRelationDA.CheckProperty4Condition(objvcc_WorkStuRelationEN);
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
if (clscc_WorkStuRelationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkStuRelationBL没有刷新缓存机制(clscc_WorkStuRelationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzUniZoneBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneBL没有刷新缓存机制(clsXzUniZoneBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexBL没有刷新缓存机制(clsSexBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicBL没有刷新缓存机制(clsRsEthnicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsBL没有刷新缓存机制(clsRsPoliticsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoBL没有刷新缓存机制(clsStudentInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStuTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStuTypeBL没有刷新缓存机制(clsRsStuTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCurrEduClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsBL没有刷新缓存机制(clsCurrEduClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_WorkEduClsRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkEduClsRelaBL没有刷新缓存机制(clscc_WorkEduClsRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsWorkTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsWorkTypeBL没有刷新缓存机制(clsWorkTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsBL没有刷新缓存机制(clsXzAdminClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeBL没有刷新缓存机制(clsXzAdminClsTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by IdWorkStuRelation");
//if (arrvcc_WorkStuRelationObjLstCache == null)
//{
//arrvcc_WorkStuRelationObjLstCache = vcc_WorkStuRelationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdWorkStuRelation">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkStuRelationEN GetObjByIdWorkStuRelationCache(long lngIdWorkStuRelation)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvcc_WorkStuRelationEN._CurrTabName);
List<clsvcc_WorkStuRelationEN> arrvcc_WorkStuRelationObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_WorkStuRelationEN> arrvcc_WorkStuRelationObjLst_Sel =
arrvcc_WorkStuRelationObjLstCache
.Where(x=> x.IdWorkStuRelation == lngIdWorkStuRelation 
);
if (arrvcc_WorkStuRelationObjLst_Sel.Count() == 0)
{
   clsvcc_WorkStuRelationEN obj = clsvcc_WorkStuRelationBL.GetObjByIdWorkStuRelation(lngIdWorkStuRelation);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvcc_WorkStuRelationObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_WorkStuRelationEN> GetAllvcc_WorkStuRelationObjLstCache()
{
//获取缓存中的对象列表
List<clsvcc_WorkStuRelationEN> arrvcc_WorkStuRelationObjLstCache = GetObjLstCache(); 
return arrvcc_WorkStuRelationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_WorkStuRelationEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvcc_WorkStuRelationEN._CurrTabName);
List<clsvcc_WorkStuRelationEN> arrvcc_WorkStuRelationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_WorkStuRelationObjLstCache;
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
string strKey = string.Format("{0}", clsvcc_WorkStuRelationEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvcc_WorkStuRelationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvcc_WorkStuRelationEN._RefreshTimeLst.Count == 0) return "";
return clsvcc_WorkStuRelationEN._RefreshTimeLst[clsvcc_WorkStuRelationEN._RefreshTimeLst.Count - 1];
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngIdWorkStuRelation)
{
if (strInFldName != convcc_WorkStuRelation.IdWorkStuRelation)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_WorkStuRelation.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_WorkStuRelation.AttributeName));
throw new Exception(strMsg);
}
var objvcc_WorkStuRelation = clsvcc_WorkStuRelationBL.GetObjByIdWorkStuRelationCache(lngIdWorkStuRelation);
if (objvcc_WorkStuRelation == null) return "";
return objvcc_WorkStuRelation[strOutFldName].ToString();
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
int intRecCount = clsvcc_WorkStuRelationDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_WorkStuRelationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_WorkStuRelationDA.GetRecCount();
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
int intRecCount = clsvcc_WorkStuRelationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_WorkStuRelationEN objvcc_WorkStuRelationCond)
{
List<clsvcc_WorkStuRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_WorkStuRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_WorkStuRelation.AttributeName)
{
if (objvcc_WorkStuRelationCond.IsUpdated(strFldName) == false) continue;
if (objvcc_WorkStuRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkStuRelationCond[strFldName].ToString());
}
else
{
if (objvcc_WorkStuRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_WorkStuRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkStuRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_WorkStuRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_WorkStuRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_WorkStuRelationCond[strFldName]));
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
 List<string> arrList = clsvcc_WorkStuRelationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_WorkStuRelationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_WorkStuRelationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}