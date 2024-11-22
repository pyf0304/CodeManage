
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_KnowledgesExamLibRelaBL
 表名:vcc_KnowledgesExamLibRela(01120142)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:06
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
public static class  clsvcc_KnowledgesExamLibRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_KnowledgesExamLibRelaEN GetObj(this K_mId_vcc_KnowledgesExamLibRela myKey)
{
clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = clsvcc_KnowledgesExamLibRelaBL.vcc_KnowledgesExamLibRelaDA.GetObjBymId(myKey.Value);
return objvcc_KnowledgesExamLibRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetQuestionID(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionID, convcc_KnowledgesExamLibRela.QuestionID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convcc_KnowledgesExamLibRela.QuestionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convcc_KnowledgesExamLibRela.QuestionID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetQuestionIndex(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, int? intQuestionIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetQuestionName(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strQuestionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionName, 500, convcc_KnowledgesExamLibRela.QuestionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetQuestionContent(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strQuestionContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, convcc_KnowledgesExamLibRela.QuestionContent);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetChapterNameSim(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, convcc_KnowledgesExamLibRela.ChapterNameSim);
}
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.ChapterNameSim) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.ChapterNameSim, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.ChapterNameSim] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetSectionNameSim(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strSectionNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionNameSim, 10, convcc_KnowledgesExamLibRela.SectionNameSim);
}
objvcc_KnowledgesExamLibRelaEN.SectionNameSim = strSectionNameSim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.SectionNameSim) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.SectionNameSim, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.SectionNameSim] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetCourseId(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_KnowledgesExamLibRela.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_KnowledgesExamLibRela.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetPositiveCorrelation(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, double? dblPositiveCorrelation, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetCourseKnowledgeId(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strCourseKnowledgeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseKnowledgeId, convcc_KnowledgesExamLibRela.CourseKnowledgeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseKnowledgeId, 8, convcc_KnowledgesExamLibRela.CourseKnowledgeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeId, 8, convcc_KnowledgesExamLibRela.CourseKnowledgeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetKnowledgeName(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strKnowledgeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKnowledgeName, convcc_KnowledgesExamLibRela.KnowledgeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeName, 100, convcc_KnowledgesExamLibRela.KnowledgeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetKnowledgeTitle(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strKnowledgeTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeTitle, 100, convcc_KnowledgesExamLibRela.KnowledgeTitle);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetCourseName(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_KnowledgesExamLibRela.CourseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetCourseChapterId(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convcc_KnowledgesExamLibRela.CourseChapterId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_KnowledgesExamLibRela.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_KnowledgesExamLibRela.CourseChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetChapterId(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterId, 8, convcc_KnowledgesExamLibRela.ChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convcc_KnowledgesExamLibRela.ChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetNegativeCorrelation(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, double? dblNegativeCorrelation, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetUpdDate(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_KnowledgesExamLibRela.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_KnowledgesExamLibRela.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetUpdUserId(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_KnowledgesExamLibRela.UpdUserId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetMemo(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_KnowledgesExamLibRela.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetChapterNameSim4Question(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strChapterNameSim4Question, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim4Question, 10, convcc_KnowledgesExamLibRela.ChapterNameSim4Question);
}
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question = strChapterNameSim4Question; //ChapterName_Sim4Question
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.ChapterNameSim4Question) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.ChapterNameSim4Question, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.ChapterNameSim4Question] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_KnowledgesExamLibRelaEN SetSectionNameSim4Question(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN, string strSectionNameSim4Question, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionNameSim4Question, 10, convcc_KnowledgesExamLibRela.SectionNameSim4Question);
}
objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question = strSectionNameSim4Question; //SectionName_Sim4Question
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(convcc_KnowledgesExamLibRela.SectionNameSim4Question) == false)
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(convcc_KnowledgesExamLibRela.SectionNameSim4Question, strComparisonOp);
}
else
{
objvcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[convcc_KnowledgesExamLibRela.SectionNameSim4Question] = strComparisonOp;
}
}
return objvcc_KnowledgesExamLibRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaENS">源对象</param>
 /// <param name = "objvcc_KnowledgesExamLibRelaENT">目标对象</param>
 public static void CopyTo(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaENS, clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaENT)
{
try
{
objvcc_KnowledgesExamLibRelaENT.mId = objvcc_KnowledgesExamLibRelaENS.mId; //mId
objvcc_KnowledgesExamLibRelaENT.QuestionID = objvcc_KnowledgesExamLibRelaENS.QuestionID; //题目ID
objvcc_KnowledgesExamLibRelaENT.QuestionIndex = objvcc_KnowledgesExamLibRelaENS.QuestionIndex; //题目序号
objvcc_KnowledgesExamLibRelaENT.QuestionName = objvcc_KnowledgesExamLibRelaENS.QuestionName; //题目名称
objvcc_KnowledgesExamLibRelaENT.QuestionContent = objvcc_KnowledgesExamLibRelaENS.QuestionContent; //题目内容
objvcc_KnowledgesExamLibRelaENT.ChapterNameSim = objvcc_KnowledgesExamLibRelaENS.ChapterNameSim; //章名简称
objvcc_KnowledgesExamLibRelaENT.SectionNameSim = objvcc_KnowledgesExamLibRelaENS.SectionNameSim; //节名简称
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
objvcc_KnowledgesExamLibRelaENT.ChapterNameSim4Question = objvcc_KnowledgesExamLibRelaENS.ChapterNameSim4Question; //ChapterName_Sim4Question
objvcc_KnowledgesExamLibRelaENT.SectionNameSim4Question = objvcc_KnowledgesExamLibRelaENS.SectionNameSim4Question; //SectionName_Sim4Question
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
 /// <param name = "objvcc_KnowledgesExamLibRelaENS">源对象</param>
 /// <returns>目标对象=>clsvcc_KnowledgesExamLibRelaEN:objvcc_KnowledgesExamLibRelaENT</returns>
 public static clsvcc_KnowledgesExamLibRelaEN CopyTo(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaENS)
{
try
{
 clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaENT = new clsvcc_KnowledgesExamLibRelaEN()
{
mId = objvcc_KnowledgesExamLibRelaENS.mId, //mId
QuestionID = objvcc_KnowledgesExamLibRelaENS.QuestionID, //题目ID
QuestionIndex = objvcc_KnowledgesExamLibRelaENS.QuestionIndex, //题目序号
QuestionName = objvcc_KnowledgesExamLibRelaENS.QuestionName, //题目名称
QuestionContent = objvcc_KnowledgesExamLibRelaENS.QuestionContent, //题目内容
ChapterNameSim = objvcc_KnowledgesExamLibRelaENS.ChapterNameSim, //章名简称
SectionNameSim = objvcc_KnowledgesExamLibRelaENS.SectionNameSim, //节名简称
CourseId = objvcc_KnowledgesExamLibRelaENS.CourseId, //课程Id
PositiveCorrelation = objvcc_KnowledgesExamLibRelaENS.PositiveCorrelation, //正相关度
CourseKnowledgeId = objvcc_KnowledgesExamLibRelaENS.CourseKnowledgeId, //知识点Id
KnowledgeName = objvcc_KnowledgesExamLibRelaENS.KnowledgeName, //知识点名称
KnowledgeTitle = objvcc_KnowledgesExamLibRelaENS.KnowledgeTitle, //知识点标题
KnowledgeContent = objvcc_KnowledgesExamLibRelaENS.KnowledgeContent, //知识点内容
CourseName = objvcc_KnowledgesExamLibRelaENS.CourseName, //课程名称
CourseChapterId = objvcc_KnowledgesExamLibRelaENS.CourseChapterId, //课程章节ID
ChapterId = objvcc_KnowledgesExamLibRelaENS.ChapterId, //章Id
NegativeCorrelation = objvcc_KnowledgesExamLibRelaENS.NegativeCorrelation, //负相关度
UpdDate = objvcc_KnowledgesExamLibRelaENS.UpdDate, //修改日期
UpdUserId = objvcc_KnowledgesExamLibRelaENS.UpdUserId, //修改用户Id
Memo = objvcc_KnowledgesExamLibRelaENS.Memo, //备注
ChapterNameSim4Question = objvcc_KnowledgesExamLibRelaENS.ChapterNameSim4Question, //ChapterName_Sim4Question
SectionNameSim4Question = objvcc_KnowledgesExamLibRelaENS.SectionNameSim4Question, //SectionName_Sim4Question
};
 return objvcc_KnowledgesExamLibRelaENT;
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
public static void CheckProperty4Condition(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN)
{
 clsvcc_KnowledgesExamLibRelaBL.vcc_KnowledgesExamLibRelaDA.CheckProperty4Condition(objvcc_KnowledgesExamLibRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_KnowledgesExamLibRelaCond.IsUpdated(convcc_KnowledgesExamLibRela.mId) == true)
{
string strComparisonOpmId = objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_KnowledgesExamLibRela.mId, objvcc_KnowledgesExamLibRelaCond.mId, strComparisonOpmId);
}
if (objvcc_KnowledgesExamLibRelaCond.IsUpdated(convcc_KnowledgesExamLibRela.QuestionID) == true)
{
string strComparisonOpQuestionID = objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.QuestionID, objvcc_KnowledgesExamLibRelaCond.QuestionID, strComparisonOpQuestionID);
}
if (objvcc_KnowledgesExamLibRelaCond.IsUpdated(convcc_KnowledgesExamLibRela.QuestionIndex) == true)
{
string strComparisonOpQuestionIndex = objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_KnowledgesExamLibRela.QuestionIndex, objvcc_KnowledgesExamLibRelaCond.QuestionIndex, strComparisonOpQuestionIndex);
}
if (objvcc_KnowledgesExamLibRelaCond.IsUpdated(convcc_KnowledgesExamLibRela.QuestionName) == true)
{
string strComparisonOpQuestionName = objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.QuestionName, objvcc_KnowledgesExamLibRelaCond.QuestionName, strComparisonOpQuestionName);
}
if (objvcc_KnowledgesExamLibRelaCond.IsUpdated(convcc_KnowledgesExamLibRela.QuestionContent) == true)
{
string strComparisonOpQuestionContent = objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.QuestionContent, objvcc_KnowledgesExamLibRelaCond.QuestionContent, strComparisonOpQuestionContent);
}
if (objvcc_KnowledgesExamLibRelaCond.IsUpdated(convcc_KnowledgesExamLibRela.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.ChapterNameSim, objvcc_KnowledgesExamLibRelaCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objvcc_KnowledgesExamLibRelaCond.IsUpdated(convcc_KnowledgesExamLibRela.SectionNameSim) == true)
{
string strComparisonOpSectionNameSim = objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.SectionNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.SectionNameSim, objvcc_KnowledgesExamLibRelaCond.SectionNameSim, strComparisonOpSectionNameSim);
}
if (objvcc_KnowledgesExamLibRelaCond.IsUpdated(convcc_KnowledgesExamLibRela.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.CourseId, objvcc_KnowledgesExamLibRelaCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_KnowledgesExamLibRelaCond.IsUpdated(convcc_KnowledgesExamLibRela.PositiveCorrelation) == true)
{
string strComparisonOpPositiveCorrelation = objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.PositiveCorrelation];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_KnowledgesExamLibRela.PositiveCorrelation, objvcc_KnowledgesExamLibRelaCond.PositiveCorrelation, strComparisonOpPositiveCorrelation);
}
if (objvcc_KnowledgesExamLibRelaCond.IsUpdated(convcc_KnowledgesExamLibRela.CourseKnowledgeId) == true)
{
string strComparisonOpCourseKnowledgeId = objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.CourseKnowledgeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.CourseKnowledgeId, objvcc_KnowledgesExamLibRelaCond.CourseKnowledgeId, strComparisonOpCourseKnowledgeId);
}
if (objvcc_KnowledgesExamLibRelaCond.IsUpdated(convcc_KnowledgesExamLibRela.KnowledgeName) == true)
{
string strComparisonOpKnowledgeName = objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.KnowledgeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.KnowledgeName, objvcc_KnowledgesExamLibRelaCond.KnowledgeName, strComparisonOpKnowledgeName);
}
if (objvcc_KnowledgesExamLibRelaCond.IsUpdated(convcc_KnowledgesExamLibRela.KnowledgeTitle) == true)
{
string strComparisonOpKnowledgeTitle = objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.KnowledgeTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.KnowledgeTitle, objvcc_KnowledgesExamLibRelaCond.KnowledgeTitle, strComparisonOpKnowledgeTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvcc_KnowledgesExamLibRelaCond.IsUpdated(convcc_KnowledgesExamLibRela.CourseName) == true)
{
string strComparisonOpCourseName = objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.CourseName, objvcc_KnowledgesExamLibRelaCond.CourseName, strComparisonOpCourseName);
}
if (objvcc_KnowledgesExamLibRelaCond.IsUpdated(convcc_KnowledgesExamLibRela.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.CourseChapterId, objvcc_KnowledgesExamLibRelaCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvcc_KnowledgesExamLibRelaCond.IsUpdated(convcc_KnowledgesExamLibRela.ChapterId) == true)
{
string strComparisonOpChapterId = objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.ChapterId, objvcc_KnowledgesExamLibRelaCond.ChapterId, strComparisonOpChapterId);
}
if (objvcc_KnowledgesExamLibRelaCond.IsUpdated(convcc_KnowledgesExamLibRela.NegativeCorrelation) == true)
{
string strComparisonOpNegativeCorrelation = objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.NegativeCorrelation];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_KnowledgesExamLibRela.NegativeCorrelation, objvcc_KnowledgesExamLibRelaCond.NegativeCorrelation, strComparisonOpNegativeCorrelation);
}
if (objvcc_KnowledgesExamLibRelaCond.IsUpdated(convcc_KnowledgesExamLibRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.UpdDate, objvcc_KnowledgesExamLibRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_KnowledgesExamLibRelaCond.IsUpdated(convcc_KnowledgesExamLibRela.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.UpdUserId, objvcc_KnowledgesExamLibRelaCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvcc_KnowledgesExamLibRelaCond.IsUpdated(convcc_KnowledgesExamLibRela.Memo) == true)
{
string strComparisonOpMemo = objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.Memo, objvcc_KnowledgesExamLibRelaCond.Memo, strComparisonOpMemo);
}
if (objvcc_KnowledgesExamLibRelaCond.IsUpdated(convcc_KnowledgesExamLibRela.ChapterNameSim4Question) == true)
{
string strComparisonOpChapterNameSim4Question = objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.ChapterNameSim4Question];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.ChapterNameSim4Question, objvcc_KnowledgesExamLibRelaCond.ChapterNameSim4Question, strComparisonOpChapterNameSim4Question);
}
if (objvcc_KnowledgesExamLibRelaCond.IsUpdated(convcc_KnowledgesExamLibRela.SectionNameSim4Question) == true)
{
string strComparisonOpSectionNameSim4Question = objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp[convcc_KnowledgesExamLibRela.SectionNameSim4Question];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_KnowledgesExamLibRela.SectionNameSim4Question, objvcc_KnowledgesExamLibRelaCond.SectionNameSim4Question, strComparisonOpSectionNameSim4Question);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_KnowledgesExamLibRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v知识点习题关系(vcc_KnowledgesExamLibRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_KnowledgesExamLibRelaBL
{
public static RelatedActions_vcc_KnowledgesExamLibRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_KnowledgesExamLibRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_KnowledgesExamLibRelaDA vcc_KnowledgesExamLibRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_KnowledgesExamLibRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_KnowledgesExamLibRelaBL()
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
if (string.IsNullOrEmpty(clsvcc_KnowledgesExamLibRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_KnowledgesExamLibRelaEN._ConnectString);
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
public static DataTable GetDataTable_vcc_KnowledgesExamLibRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_KnowledgesExamLibRelaDA.GetDataTable_vcc_KnowledgesExamLibRela(strWhereCond);
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
objDT = vcc_KnowledgesExamLibRelaDA.GetDataTable(strWhereCond);
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
objDT = vcc_KnowledgesExamLibRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_KnowledgesExamLibRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_KnowledgesExamLibRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_KnowledgesExamLibRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_KnowledgesExamLibRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_KnowledgesExamLibRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_KnowledgesExamLibRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvcc_KnowledgesExamLibRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvcc_KnowledgesExamLibRelaEN> arrObjLst = new List<clsvcc_KnowledgesExamLibRelaEN>(); 
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
	clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = new clsvcc_KnowledgesExamLibRelaEN();
try
{
objvcc_KnowledgesExamLibRelaEN.mId = Int32.Parse(objRow[convcc_KnowledgesExamLibRela.mId].ToString().Trim()); //mId
objvcc_KnowledgesExamLibRelaEN.QuestionID = objRow[convcc_KnowledgesExamLibRela.QuestionID].ToString().Trim(); //题目ID
objvcc_KnowledgesExamLibRelaEN.QuestionIndex = objRow[convcc_KnowledgesExamLibRela.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_KnowledgesExamLibRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_KnowledgesExamLibRelaEN.QuestionName = objRow[convcc_KnowledgesExamLibRela.QuestionName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionName].ToString().Trim(); //题目名称
objvcc_KnowledgesExamLibRelaEN.QuestionContent = objRow[convcc_KnowledgesExamLibRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_KnowledgesExamLibRelaEN.SectionNameSim = objRow[convcc_KnowledgesExamLibRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_KnowledgesExamLibRelaEN.CourseId = objRow[convcc_KnowledgesExamLibRela.CourseId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseId].ToString().Trim(); //课程Id
objvcc_KnowledgesExamLibRelaEN.PositiveCorrelation = objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()); //正相关度
objvcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = objRow[convcc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_KnowledgesExamLibRelaEN.KnowledgeName = objRow[convcc_KnowledgesExamLibRela.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle = objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_KnowledgesExamLibRelaEN.KnowledgeContent = objRow[convcc_KnowledgesExamLibRela.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_KnowledgesExamLibRelaEN.CourseName = objRow[convcc_KnowledgesExamLibRela.CourseName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseName].ToString().Trim(); //课程名称
objvcc_KnowledgesExamLibRelaEN.CourseChapterId = objRow[convcc_KnowledgesExamLibRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_KnowledgesExamLibRelaEN.ChapterId = objRow[convcc_KnowledgesExamLibRela.ChapterId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterId].ToString().Trim(); //章Id
objvcc_KnowledgesExamLibRelaEN.NegativeCorrelation = objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()); //负相关度
objvcc_KnowledgesExamLibRelaEN.UpdDate = objRow[convcc_KnowledgesExamLibRela.UpdDate].ToString().Trim(); //修改日期
objvcc_KnowledgesExamLibRelaEN.UpdUserId = objRow[convcc_KnowledgesExamLibRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_KnowledgesExamLibRelaEN.Memo = objRow[convcc_KnowledgesExamLibRela.Memo] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.Memo].ToString().Trim(); //备注
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question].ToString().Trim(); //ChapterName_Sim4Question
objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question = objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question].ToString().Trim(); //SectionName_Sim4Question
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_KnowledgesExamLibRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_KnowledgesExamLibRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_KnowledgesExamLibRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvcc_KnowledgesExamLibRelaEN._CurrTabName, strCourseId);
List<clsvcc_KnowledgesExamLibRelaEN> arrvcc_KnowledgesExamLibRelaObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_KnowledgesExamLibRelaEN> arrvcc_KnowledgesExamLibRelaObjLst_Sel =
arrvcc_KnowledgesExamLibRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvcc_KnowledgesExamLibRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_KnowledgesExamLibRelaEN> GetObjLst(string strWhereCond)
{
List<clsvcc_KnowledgesExamLibRelaEN> arrObjLst = new List<clsvcc_KnowledgesExamLibRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = new clsvcc_KnowledgesExamLibRelaEN();
try
{
objvcc_KnowledgesExamLibRelaEN.mId = Int32.Parse(objRow[convcc_KnowledgesExamLibRela.mId].ToString().Trim()); //mId
objvcc_KnowledgesExamLibRelaEN.QuestionID = objRow[convcc_KnowledgesExamLibRela.QuestionID].ToString().Trim(); //题目ID
objvcc_KnowledgesExamLibRelaEN.QuestionIndex = objRow[convcc_KnowledgesExamLibRela.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_KnowledgesExamLibRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_KnowledgesExamLibRelaEN.QuestionName = objRow[convcc_KnowledgesExamLibRela.QuestionName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionName].ToString().Trim(); //题目名称
objvcc_KnowledgesExamLibRelaEN.QuestionContent = objRow[convcc_KnowledgesExamLibRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_KnowledgesExamLibRelaEN.SectionNameSim = objRow[convcc_KnowledgesExamLibRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_KnowledgesExamLibRelaEN.CourseId = objRow[convcc_KnowledgesExamLibRela.CourseId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseId].ToString().Trim(); //课程Id
objvcc_KnowledgesExamLibRelaEN.PositiveCorrelation = objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()); //正相关度
objvcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = objRow[convcc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_KnowledgesExamLibRelaEN.KnowledgeName = objRow[convcc_KnowledgesExamLibRela.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle = objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_KnowledgesExamLibRelaEN.KnowledgeContent = objRow[convcc_KnowledgesExamLibRela.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_KnowledgesExamLibRelaEN.CourseName = objRow[convcc_KnowledgesExamLibRela.CourseName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseName].ToString().Trim(); //课程名称
objvcc_KnowledgesExamLibRelaEN.CourseChapterId = objRow[convcc_KnowledgesExamLibRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_KnowledgesExamLibRelaEN.ChapterId = objRow[convcc_KnowledgesExamLibRela.ChapterId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterId].ToString().Trim(); //章Id
objvcc_KnowledgesExamLibRelaEN.NegativeCorrelation = objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()); //负相关度
objvcc_KnowledgesExamLibRelaEN.UpdDate = objRow[convcc_KnowledgesExamLibRela.UpdDate].ToString().Trim(); //修改日期
objvcc_KnowledgesExamLibRelaEN.UpdUserId = objRow[convcc_KnowledgesExamLibRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_KnowledgesExamLibRelaEN.Memo = objRow[convcc_KnowledgesExamLibRela.Memo] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.Memo].ToString().Trim(); //备注
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question].ToString().Trim(); //ChapterName_Sim4Question
objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question = objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question].ToString().Trim(); //SectionName_Sim4Question
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_KnowledgesExamLibRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_KnowledgesExamLibRelaEN);
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
public static List<clsvcc_KnowledgesExamLibRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_KnowledgesExamLibRelaEN> arrObjLst = new List<clsvcc_KnowledgesExamLibRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = new clsvcc_KnowledgesExamLibRelaEN();
try
{
objvcc_KnowledgesExamLibRelaEN.mId = Int32.Parse(objRow[convcc_KnowledgesExamLibRela.mId].ToString().Trim()); //mId
objvcc_KnowledgesExamLibRelaEN.QuestionID = objRow[convcc_KnowledgesExamLibRela.QuestionID].ToString().Trim(); //题目ID
objvcc_KnowledgesExamLibRelaEN.QuestionIndex = objRow[convcc_KnowledgesExamLibRela.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_KnowledgesExamLibRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_KnowledgesExamLibRelaEN.QuestionName = objRow[convcc_KnowledgesExamLibRela.QuestionName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionName].ToString().Trim(); //题目名称
objvcc_KnowledgesExamLibRelaEN.QuestionContent = objRow[convcc_KnowledgesExamLibRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_KnowledgesExamLibRelaEN.SectionNameSim = objRow[convcc_KnowledgesExamLibRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_KnowledgesExamLibRelaEN.CourseId = objRow[convcc_KnowledgesExamLibRela.CourseId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseId].ToString().Trim(); //课程Id
objvcc_KnowledgesExamLibRelaEN.PositiveCorrelation = objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()); //正相关度
objvcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = objRow[convcc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_KnowledgesExamLibRelaEN.KnowledgeName = objRow[convcc_KnowledgesExamLibRela.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle = objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_KnowledgesExamLibRelaEN.KnowledgeContent = objRow[convcc_KnowledgesExamLibRela.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_KnowledgesExamLibRelaEN.CourseName = objRow[convcc_KnowledgesExamLibRela.CourseName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseName].ToString().Trim(); //课程名称
objvcc_KnowledgesExamLibRelaEN.CourseChapterId = objRow[convcc_KnowledgesExamLibRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_KnowledgesExamLibRelaEN.ChapterId = objRow[convcc_KnowledgesExamLibRela.ChapterId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterId].ToString().Trim(); //章Id
objvcc_KnowledgesExamLibRelaEN.NegativeCorrelation = objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()); //负相关度
objvcc_KnowledgesExamLibRelaEN.UpdDate = objRow[convcc_KnowledgesExamLibRela.UpdDate].ToString().Trim(); //修改日期
objvcc_KnowledgesExamLibRelaEN.UpdUserId = objRow[convcc_KnowledgesExamLibRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_KnowledgesExamLibRelaEN.Memo = objRow[convcc_KnowledgesExamLibRela.Memo] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.Memo].ToString().Trim(); //备注
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question].ToString().Trim(); //ChapterName_Sim4Question
objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question = objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question].ToString().Trim(); //SectionName_Sim4Question
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_KnowledgesExamLibRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_KnowledgesExamLibRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_KnowledgesExamLibRelaEN> GetSubObjLstCache(clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaCond)
{
 string strCourseId = objvcc_KnowledgesExamLibRelaCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvcc_KnowledgesExamLibRelaBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvcc_KnowledgesExamLibRelaEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_KnowledgesExamLibRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_KnowledgesExamLibRela.AttributeName)
{
if (objvcc_KnowledgesExamLibRelaCond.IsUpdated(strFldName) == false) continue;
if (objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_KnowledgesExamLibRelaCond[strFldName].ToString());
}
else
{
if (objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_KnowledgesExamLibRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_KnowledgesExamLibRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_KnowledgesExamLibRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_KnowledgesExamLibRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_KnowledgesExamLibRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_KnowledgesExamLibRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_KnowledgesExamLibRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_KnowledgesExamLibRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_KnowledgesExamLibRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_KnowledgesExamLibRelaCond[strFldName]));
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
public static List<clsvcc_KnowledgesExamLibRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_KnowledgesExamLibRelaEN> arrObjLst = new List<clsvcc_KnowledgesExamLibRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = new clsvcc_KnowledgesExamLibRelaEN();
try
{
objvcc_KnowledgesExamLibRelaEN.mId = Int32.Parse(objRow[convcc_KnowledgesExamLibRela.mId].ToString().Trim()); //mId
objvcc_KnowledgesExamLibRelaEN.QuestionID = objRow[convcc_KnowledgesExamLibRela.QuestionID].ToString().Trim(); //题目ID
objvcc_KnowledgesExamLibRelaEN.QuestionIndex = objRow[convcc_KnowledgesExamLibRela.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_KnowledgesExamLibRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_KnowledgesExamLibRelaEN.QuestionName = objRow[convcc_KnowledgesExamLibRela.QuestionName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionName].ToString().Trim(); //题目名称
objvcc_KnowledgesExamLibRelaEN.QuestionContent = objRow[convcc_KnowledgesExamLibRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_KnowledgesExamLibRelaEN.SectionNameSim = objRow[convcc_KnowledgesExamLibRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_KnowledgesExamLibRelaEN.CourseId = objRow[convcc_KnowledgesExamLibRela.CourseId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseId].ToString().Trim(); //课程Id
objvcc_KnowledgesExamLibRelaEN.PositiveCorrelation = objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()); //正相关度
objvcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = objRow[convcc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_KnowledgesExamLibRelaEN.KnowledgeName = objRow[convcc_KnowledgesExamLibRela.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle = objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_KnowledgesExamLibRelaEN.KnowledgeContent = objRow[convcc_KnowledgesExamLibRela.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_KnowledgesExamLibRelaEN.CourseName = objRow[convcc_KnowledgesExamLibRela.CourseName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseName].ToString().Trim(); //课程名称
objvcc_KnowledgesExamLibRelaEN.CourseChapterId = objRow[convcc_KnowledgesExamLibRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_KnowledgesExamLibRelaEN.ChapterId = objRow[convcc_KnowledgesExamLibRela.ChapterId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterId].ToString().Trim(); //章Id
objvcc_KnowledgesExamLibRelaEN.NegativeCorrelation = objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()); //负相关度
objvcc_KnowledgesExamLibRelaEN.UpdDate = objRow[convcc_KnowledgesExamLibRela.UpdDate].ToString().Trim(); //修改日期
objvcc_KnowledgesExamLibRelaEN.UpdUserId = objRow[convcc_KnowledgesExamLibRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_KnowledgesExamLibRelaEN.Memo = objRow[convcc_KnowledgesExamLibRela.Memo] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.Memo].ToString().Trim(); //备注
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question].ToString().Trim(); //ChapterName_Sim4Question
objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question = objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question].ToString().Trim(); //SectionName_Sim4Question
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_KnowledgesExamLibRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_KnowledgesExamLibRelaEN);
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
public static List<clsvcc_KnowledgesExamLibRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_KnowledgesExamLibRelaEN> arrObjLst = new List<clsvcc_KnowledgesExamLibRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = new clsvcc_KnowledgesExamLibRelaEN();
try
{
objvcc_KnowledgesExamLibRelaEN.mId = Int32.Parse(objRow[convcc_KnowledgesExamLibRela.mId].ToString().Trim()); //mId
objvcc_KnowledgesExamLibRelaEN.QuestionID = objRow[convcc_KnowledgesExamLibRela.QuestionID].ToString().Trim(); //题目ID
objvcc_KnowledgesExamLibRelaEN.QuestionIndex = objRow[convcc_KnowledgesExamLibRela.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_KnowledgesExamLibRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_KnowledgesExamLibRelaEN.QuestionName = objRow[convcc_KnowledgesExamLibRela.QuestionName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionName].ToString().Trim(); //题目名称
objvcc_KnowledgesExamLibRelaEN.QuestionContent = objRow[convcc_KnowledgesExamLibRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_KnowledgesExamLibRelaEN.SectionNameSim = objRow[convcc_KnowledgesExamLibRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_KnowledgesExamLibRelaEN.CourseId = objRow[convcc_KnowledgesExamLibRela.CourseId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseId].ToString().Trim(); //课程Id
objvcc_KnowledgesExamLibRelaEN.PositiveCorrelation = objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()); //正相关度
objvcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = objRow[convcc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_KnowledgesExamLibRelaEN.KnowledgeName = objRow[convcc_KnowledgesExamLibRela.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle = objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_KnowledgesExamLibRelaEN.KnowledgeContent = objRow[convcc_KnowledgesExamLibRela.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_KnowledgesExamLibRelaEN.CourseName = objRow[convcc_KnowledgesExamLibRela.CourseName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseName].ToString().Trim(); //课程名称
objvcc_KnowledgesExamLibRelaEN.CourseChapterId = objRow[convcc_KnowledgesExamLibRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_KnowledgesExamLibRelaEN.ChapterId = objRow[convcc_KnowledgesExamLibRela.ChapterId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterId].ToString().Trim(); //章Id
objvcc_KnowledgesExamLibRelaEN.NegativeCorrelation = objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()); //负相关度
objvcc_KnowledgesExamLibRelaEN.UpdDate = objRow[convcc_KnowledgesExamLibRela.UpdDate].ToString().Trim(); //修改日期
objvcc_KnowledgesExamLibRelaEN.UpdUserId = objRow[convcc_KnowledgesExamLibRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_KnowledgesExamLibRelaEN.Memo = objRow[convcc_KnowledgesExamLibRela.Memo] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.Memo].ToString().Trim(); //备注
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question].ToString().Trim(); //ChapterName_Sim4Question
objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question = objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question].ToString().Trim(); //SectionName_Sim4Question
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_KnowledgesExamLibRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_KnowledgesExamLibRelaEN);
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
List<clsvcc_KnowledgesExamLibRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_KnowledgesExamLibRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_KnowledgesExamLibRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_KnowledgesExamLibRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_KnowledgesExamLibRelaEN> arrObjLst = new List<clsvcc_KnowledgesExamLibRelaEN>(); 
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
	clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = new clsvcc_KnowledgesExamLibRelaEN();
try
{
objvcc_KnowledgesExamLibRelaEN.mId = Int32.Parse(objRow[convcc_KnowledgesExamLibRela.mId].ToString().Trim()); //mId
objvcc_KnowledgesExamLibRelaEN.QuestionID = objRow[convcc_KnowledgesExamLibRela.QuestionID].ToString().Trim(); //题目ID
objvcc_KnowledgesExamLibRelaEN.QuestionIndex = objRow[convcc_KnowledgesExamLibRela.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_KnowledgesExamLibRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_KnowledgesExamLibRelaEN.QuestionName = objRow[convcc_KnowledgesExamLibRela.QuestionName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionName].ToString().Trim(); //题目名称
objvcc_KnowledgesExamLibRelaEN.QuestionContent = objRow[convcc_KnowledgesExamLibRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_KnowledgesExamLibRelaEN.SectionNameSim = objRow[convcc_KnowledgesExamLibRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_KnowledgesExamLibRelaEN.CourseId = objRow[convcc_KnowledgesExamLibRela.CourseId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseId].ToString().Trim(); //课程Id
objvcc_KnowledgesExamLibRelaEN.PositiveCorrelation = objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()); //正相关度
objvcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = objRow[convcc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_KnowledgesExamLibRelaEN.KnowledgeName = objRow[convcc_KnowledgesExamLibRela.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle = objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_KnowledgesExamLibRelaEN.KnowledgeContent = objRow[convcc_KnowledgesExamLibRela.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_KnowledgesExamLibRelaEN.CourseName = objRow[convcc_KnowledgesExamLibRela.CourseName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseName].ToString().Trim(); //课程名称
objvcc_KnowledgesExamLibRelaEN.CourseChapterId = objRow[convcc_KnowledgesExamLibRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_KnowledgesExamLibRelaEN.ChapterId = objRow[convcc_KnowledgesExamLibRela.ChapterId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterId].ToString().Trim(); //章Id
objvcc_KnowledgesExamLibRelaEN.NegativeCorrelation = objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()); //负相关度
objvcc_KnowledgesExamLibRelaEN.UpdDate = objRow[convcc_KnowledgesExamLibRela.UpdDate].ToString().Trim(); //修改日期
objvcc_KnowledgesExamLibRelaEN.UpdUserId = objRow[convcc_KnowledgesExamLibRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_KnowledgesExamLibRelaEN.Memo = objRow[convcc_KnowledgesExamLibRela.Memo] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.Memo].ToString().Trim(); //备注
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question].ToString().Trim(); //ChapterName_Sim4Question
objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question = objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question].ToString().Trim(); //SectionName_Sim4Question
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_KnowledgesExamLibRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_KnowledgesExamLibRelaEN);
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
public static List<clsvcc_KnowledgesExamLibRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_KnowledgesExamLibRelaEN> arrObjLst = new List<clsvcc_KnowledgesExamLibRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = new clsvcc_KnowledgesExamLibRelaEN();
try
{
objvcc_KnowledgesExamLibRelaEN.mId = Int32.Parse(objRow[convcc_KnowledgesExamLibRela.mId].ToString().Trim()); //mId
objvcc_KnowledgesExamLibRelaEN.QuestionID = objRow[convcc_KnowledgesExamLibRela.QuestionID].ToString().Trim(); //题目ID
objvcc_KnowledgesExamLibRelaEN.QuestionIndex = objRow[convcc_KnowledgesExamLibRela.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_KnowledgesExamLibRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_KnowledgesExamLibRelaEN.QuestionName = objRow[convcc_KnowledgesExamLibRela.QuestionName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionName].ToString().Trim(); //题目名称
objvcc_KnowledgesExamLibRelaEN.QuestionContent = objRow[convcc_KnowledgesExamLibRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_KnowledgesExamLibRelaEN.SectionNameSim = objRow[convcc_KnowledgesExamLibRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_KnowledgesExamLibRelaEN.CourseId = objRow[convcc_KnowledgesExamLibRela.CourseId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseId].ToString().Trim(); //课程Id
objvcc_KnowledgesExamLibRelaEN.PositiveCorrelation = objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()); //正相关度
objvcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = objRow[convcc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_KnowledgesExamLibRelaEN.KnowledgeName = objRow[convcc_KnowledgesExamLibRela.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle = objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_KnowledgesExamLibRelaEN.KnowledgeContent = objRow[convcc_KnowledgesExamLibRela.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_KnowledgesExamLibRelaEN.CourseName = objRow[convcc_KnowledgesExamLibRela.CourseName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseName].ToString().Trim(); //课程名称
objvcc_KnowledgesExamLibRelaEN.CourseChapterId = objRow[convcc_KnowledgesExamLibRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_KnowledgesExamLibRelaEN.ChapterId = objRow[convcc_KnowledgesExamLibRela.ChapterId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterId].ToString().Trim(); //章Id
objvcc_KnowledgesExamLibRelaEN.NegativeCorrelation = objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()); //负相关度
objvcc_KnowledgesExamLibRelaEN.UpdDate = objRow[convcc_KnowledgesExamLibRela.UpdDate].ToString().Trim(); //修改日期
objvcc_KnowledgesExamLibRelaEN.UpdUserId = objRow[convcc_KnowledgesExamLibRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_KnowledgesExamLibRelaEN.Memo = objRow[convcc_KnowledgesExamLibRela.Memo] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.Memo].ToString().Trim(); //备注
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question].ToString().Trim(); //ChapterName_Sim4Question
objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question = objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question].ToString().Trim(); //SectionName_Sim4Question
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_KnowledgesExamLibRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_KnowledgesExamLibRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_KnowledgesExamLibRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_KnowledgesExamLibRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_KnowledgesExamLibRelaEN> arrObjLst = new List<clsvcc_KnowledgesExamLibRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = new clsvcc_KnowledgesExamLibRelaEN();
try
{
objvcc_KnowledgesExamLibRelaEN.mId = Int32.Parse(objRow[convcc_KnowledgesExamLibRela.mId].ToString().Trim()); //mId
objvcc_KnowledgesExamLibRelaEN.QuestionID = objRow[convcc_KnowledgesExamLibRela.QuestionID].ToString().Trim(); //题目ID
objvcc_KnowledgesExamLibRelaEN.QuestionIndex = objRow[convcc_KnowledgesExamLibRela.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_KnowledgesExamLibRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_KnowledgesExamLibRelaEN.QuestionName = objRow[convcc_KnowledgesExamLibRela.QuestionName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionName].ToString().Trim(); //题目名称
objvcc_KnowledgesExamLibRelaEN.QuestionContent = objRow[convcc_KnowledgesExamLibRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_KnowledgesExamLibRelaEN.SectionNameSim = objRow[convcc_KnowledgesExamLibRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_KnowledgesExamLibRelaEN.CourseId = objRow[convcc_KnowledgesExamLibRela.CourseId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseId].ToString().Trim(); //课程Id
objvcc_KnowledgesExamLibRelaEN.PositiveCorrelation = objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()); //正相关度
objvcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = objRow[convcc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_KnowledgesExamLibRelaEN.KnowledgeName = objRow[convcc_KnowledgesExamLibRela.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle = objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_KnowledgesExamLibRelaEN.KnowledgeContent = objRow[convcc_KnowledgesExamLibRela.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_KnowledgesExamLibRelaEN.CourseName = objRow[convcc_KnowledgesExamLibRela.CourseName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseName].ToString().Trim(); //课程名称
objvcc_KnowledgesExamLibRelaEN.CourseChapterId = objRow[convcc_KnowledgesExamLibRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_KnowledgesExamLibRelaEN.ChapterId = objRow[convcc_KnowledgesExamLibRela.ChapterId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterId].ToString().Trim(); //章Id
objvcc_KnowledgesExamLibRelaEN.NegativeCorrelation = objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()); //负相关度
objvcc_KnowledgesExamLibRelaEN.UpdDate = objRow[convcc_KnowledgesExamLibRela.UpdDate].ToString().Trim(); //修改日期
objvcc_KnowledgesExamLibRelaEN.UpdUserId = objRow[convcc_KnowledgesExamLibRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_KnowledgesExamLibRelaEN.Memo = objRow[convcc_KnowledgesExamLibRela.Memo] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.Memo].ToString().Trim(); //备注
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question].ToString().Trim(); //ChapterName_Sim4Question
objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question = objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question].ToString().Trim(); //SectionName_Sim4Question
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_KnowledgesExamLibRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_KnowledgesExamLibRelaEN);
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
public static List<clsvcc_KnowledgesExamLibRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_KnowledgesExamLibRelaEN> arrObjLst = new List<clsvcc_KnowledgesExamLibRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = new clsvcc_KnowledgesExamLibRelaEN();
try
{
objvcc_KnowledgesExamLibRelaEN.mId = Int32.Parse(objRow[convcc_KnowledgesExamLibRela.mId].ToString().Trim()); //mId
objvcc_KnowledgesExamLibRelaEN.QuestionID = objRow[convcc_KnowledgesExamLibRela.QuestionID].ToString().Trim(); //题目ID
objvcc_KnowledgesExamLibRelaEN.QuestionIndex = objRow[convcc_KnowledgesExamLibRela.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_KnowledgesExamLibRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_KnowledgesExamLibRelaEN.QuestionName = objRow[convcc_KnowledgesExamLibRela.QuestionName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionName].ToString().Trim(); //题目名称
objvcc_KnowledgesExamLibRelaEN.QuestionContent = objRow[convcc_KnowledgesExamLibRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_KnowledgesExamLibRelaEN.SectionNameSim = objRow[convcc_KnowledgesExamLibRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_KnowledgesExamLibRelaEN.CourseId = objRow[convcc_KnowledgesExamLibRela.CourseId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseId].ToString().Trim(); //课程Id
objvcc_KnowledgesExamLibRelaEN.PositiveCorrelation = objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()); //正相关度
objvcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = objRow[convcc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_KnowledgesExamLibRelaEN.KnowledgeName = objRow[convcc_KnowledgesExamLibRela.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle = objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_KnowledgesExamLibRelaEN.KnowledgeContent = objRow[convcc_KnowledgesExamLibRela.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_KnowledgesExamLibRelaEN.CourseName = objRow[convcc_KnowledgesExamLibRela.CourseName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseName].ToString().Trim(); //课程名称
objvcc_KnowledgesExamLibRelaEN.CourseChapterId = objRow[convcc_KnowledgesExamLibRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_KnowledgesExamLibRelaEN.ChapterId = objRow[convcc_KnowledgesExamLibRela.ChapterId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterId].ToString().Trim(); //章Id
objvcc_KnowledgesExamLibRelaEN.NegativeCorrelation = objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()); //负相关度
objvcc_KnowledgesExamLibRelaEN.UpdDate = objRow[convcc_KnowledgesExamLibRela.UpdDate].ToString().Trim(); //修改日期
objvcc_KnowledgesExamLibRelaEN.UpdUserId = objRow[convcc_KnowledgesExamLibRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_KnowledgesExamLibRelaEN.Memo = objRow[convcc_KnowledgesExamLibRela.Memo] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.Memo].ToString().Trim(); //备注
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question].ToString().Trim(); //ChapterName_Sim4Question
objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question = objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question].ToString().Trim(); //SectionName_Sim4Question
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_KnowledgesExamLibRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_KnowledgesExamLibRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_KnowledgesExamLibRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_KnowledgesExamLibRelaEN> arrObjLst = new List<clsvcc_KnowledgesExamLibRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = new clsvcc_KnowledgesExamLibRelaEN();
try
{
objvcc_KnowledgesExamLibRelaEN.mId = Int32.Parse(objRow[convcc_KnowledgesExamLibRela.mId].ToString().Trim()); //mId
objvcc_KnowledgesExamLibRelaEN.QuestionID = objRow[convcc_KnowledgesExamLibRela.QuestionID].ToString().Trim(); //题目ID
objvcc_KnowledgesExamLibRelaEN.QuestionIndex = objRow[convcc_KnowledgesExamLibRela.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_KnowledgesExamLibRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_KnowledgesExamLibRelaEN.QuestionName = objRow[convcc_KnowledgesExamLibRela.QuestionName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionName].ToString().Trim(); //题目名称
objvcc_KnowledgesExamLibRelaEN.QuestionContent = objRow[convcc_KnowledgesExamLibRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_KnowledgesExamLibRelaEN.SectionNameSim = objRow[convcc_KnowledgesExamLibRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_KnowledgesExamLibRelaEN.CourseId = objRow[convcc_KnowledgesExamLibRela.CourseId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseId].ToString().Trim(); //课程Id
objvcc_KnowledgesExamLibRelaEN.PositiveCorrelation = objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()); //正相关度
objvcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = objRow[convcc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_KnowledgesExamLibRelaEN.KnowledgeName = objRow[convcc_KnowledgesExamLibRela.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle = objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_KnowledgesExamLibRelaEN.KnowledgeContent = objRow[convcc_KnowledgesExamLibRela.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_KnowledgesExamLibRelaEN.CourseName = objRow[convcc_KnowledgesExamLibRela.CourseName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseName].ToString().Trim(); //课程名称
objvcc_KnowledgesExamLibRelaEN.CourseChapterId = objRow[convcc_KnowledgesExamLibRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_KnowledgesExamLibRelaEN.ChapterId = objRow[convcc_KnowledgesExamLibRela.ChapterId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterId].ToString().Trim(); //章Id
objvcc_KnowledgesExamLibRelaEN.NegativeCorrelation = objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()); //负相关度
objvcc_KnowledgesExamLibRelaEN.UpdDate = objRow[convcc_KnowledgesExamLibRela.UpdDate].ToString().Trim(); //修改日期
objvcc_KnowledgesExamLibRelaEN.UpdUserId = objRow[convcc_KnowledgesExamLibRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_KnowledgesExamLibRelaEN.Memo = objRow[convcc_KnowledgesExamLibRela.Memo] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.Memo].ToString().Trim(); //备注
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question].ToString().Trim(); //ChapterName_Sim4Question
objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question = objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question].ToString().Trim(); //SectionName_Sim4Question
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_KnowledgesExamLibRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_KnowledgesExamLibRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_KnowledgesExamLibRela(ref clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN)
{
bool bolResult = vcc_KnowledgesExamLibRelaDA.Getvcc_KnowledgesExamLibRela(ref objvcc_KnowledgesExamLibRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_KnowledgesExamLibRelaEN GetObjBymId(long lngmId)
{
clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = vcc_KnowledgesExamLibRelaDA.GetObjBymId(lngmId);
return objvcc_KnowledgesExamLibRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_KnowledgesExamLibRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = vcc_KnowledgesExamLibRelaDA.GetFirstObj(strWhereCond);
 return objvcc_KnowledgesExamLibRelaEN;
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
public static clsvcc_KnowledgesExamLibRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = vcc_KnowledgesExamLibRelaDA.GetObjByDataRow(objRow);
 return objvcc_KnowledgesExamLibRelaEN;
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
public static clsvcc_KnowledgesExamLibRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = vcc_KnowledgesExamLibRelaDA.GetObjByDataRow(objRow);
 return objvcc_KnowledgesExamLibRelaEN;
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
 /// <param name = "lstvcc_KnowledgesExamLibRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_KnowledgesExamLibRelaEN GetObjBymIdFromList(long lngmId, List<clsvcc_KnowledgesExamLibRelaEN> lstvcc_KnowledgesExamLibRelaObjLst)
{
foreach (clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN in lstvcc_KnowledgesExamLibRelaObjLst)
{
if (objvcc_KnowledgesExamLibRelaEN.mId == lngmId)
{
return objvcc_KnowledgesExamLibRelaEN;
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
 lngmId = new clsvcc_KnowledgesExamLibRelaDA().GetFirstID(strWhereCond);
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
 arrList = vcc_KnowledgesExamLibRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_KnowledgesExamLibRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vcc_KnowledgesExamLibRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvcc_KnowledgesExamLibRelaDA.IsExistTable();
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
 bolIsExist = vcc_KnowledgesExamLibRelaDA.IsExistTable(strTabName);
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
objvcc_KnowledgesExamLibRelaENT.ChapterNameSim = objvcc_KnowledgesExamLibRelaENS.ChapterNameSim; //章名简称
objvcc_KnowledgesExamLibRelaENT.SectionNameSim = objvcc_KnowledgesExamLibRelaENS.SectionNameSim; //节名简称
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
objvcc_KnowledgesExamLibRelaENT.ChapterNameSim4Question = objvcc_KnowledgesExamLibRelaENS.ChapterNameSim4Question; //ChapterName_Sim4Question
objvcc_KnowledgesExamLibRelaENT.SectionNameSim4Question = objvcc_KnowledgesExamLibRelaENS.SectionNameSim4Question; //SectionName_Sim4Question
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
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN)
{
try
{
objvcc_KnowledgesExamLibRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_KnowledgesExamLibRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_KnowledgesExamLibRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_KnowledgesExamLibRelaEN.mId = objvcc_KnowledgesExamLibRelaEN.mId; //mId
}
if (arrFldSet.Contains(convcc_KnowledgesExamLibRela.QuestionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_KnowledgesExamLibRelaEN.QuestionID = objvcc_KnowledgesExamLibRelaEN.QuestionID; //题目ID
}
if (arrFldSet.Contains(convcc_KnowledgesExamLibRela.QuestionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_KnowledgesExamLibRelaEN.QuestionIndex = objvcc_KnowledgesExamLibRelaEN.QuestionIndex; //题目序号
}
if (arrFldSet.Contains(convcc_KnowledgesExamLibRela.QuestionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_KnowledgesExamLibRelaEN.QuestionName = objvcc_KnowledgesExamLibRelaEN.QuestionName == "[null]" ? null :  objvcc_KnowledgesExamLibRelaEN.QuestionName; //题目名称
}
if (arrFldSet.Contains(convcc_KnowledgesExamLibRela.QuestionContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_KnowledgesExamLibRelaEN.QuestionContent = objvcc_KnowledgesExamLibRelaEN.QuestionContent == "[null]" ? null :  objvcc_KnowledgesExamLibRelaEN.QuestionContent; //题目内容
}
if (arrFldSet.Contains(convcc_KnowledgesExamLibRela.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim = objvcc_KnowledgesExamLibRelaEN.ChapterNameSim == "[null]" ? null :  objvcc_KnowledgesExamLibRelaEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(convcc_KnowledgesExamLibRela.SectionNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_KnowledgesExamLibRelaEN.SectionNameSim = objvcc_KnowledgesExamLibRelaEN.SectionNameSim == "[null]" ? null :  objvcc_KnowledgesExamLibRelaEN.SectionNameSim; //节名简称
}
if (arrFldSet.Contains(convcc_KnowledgesExamLibRela.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_KnowledgesExamLibRelaEN.CourseId = objvcc_KnowledgesExamLibRelaEN.CourseId == "[null]" ? null :  objvcc_KnowledgesExamLibRelaEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_KnowledgesExamLibRela.PositiveCorrelation, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_KnowledgesExamLibRelaEN.PositiveCorrelation = objvcc_KnowledgesExamLibRelaEN.PositiveCorrelation; //正相关度
}
if (arrFldSet.Contains(convcc_KnowledgesExamLibRela.CourseKnowledgeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = objvcc_KnowledgesExamLibRelaEN.CourseKnowledgeId; //知识点Id
}
if (arrFldSet.Contains(convcc_KnowledgesExamLibRela.KnowledgeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_KnowledgesExamLibRelaEN.KnowledgeName = objvcc_KnowledgesExamLibRelaEN.KnowledgeName; //知识点名称
}
if (arrFldSet.Contains(convcc_KnowledgesExamLibRela.KnowledgeTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle = objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle == "[null]" ? null :  objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle; //知识点标题
}
if (arrFldSet.Contains(convcc_KnowledgesExamLibRela.KnowledgeContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_KnowledgesExamLibRelaEN.KnowledgeContent = objvcc_KnowledgesExamLibRelaEN.KnowledgeContent == "[null]" ? null :  objvcc_KnowledgesExamLibRelaEN.KnowledgeContent; //知识点内容
}
if (arrFldSet.Contains(convcc_KnowledgesExamLibRela.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_KnowledgesExamLibRelaEN.CourseName = objvcc_KnowledgesExamLibRelaEN.CourseName == "[null]" ? null :  objvcc_KnowledgesExamLibRelaEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convcc_KnowledgesExamLibRela.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_KnowledgesExamLibRelaEN.CourseChapterId = objvcc_KnowledgesExamLibRelaEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convcc_KnowledgesExamLibRela.ChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_KnowledgesExamLibRelaEN.ChapterId = objvcc_KnowledgesExamLibRelaEN.ChapterId == "[null]" ? null :  objvcc_KnowledgesExamLibRelaEN.ChapterId; //章Id
}
if (arrFldSet.Contains(convcc_KnowledgesExamLibRela.NegativeCorrelation, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_KnowledgesExamLibRelaEN.NegativeCorrelation = objvcc_KnowledgesExamLibRelaEN.NegativeCorrelation; //负相关度
}
if (arrFldSet.Contains(convcc_KnowledgesExamLibRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_KnowledgesExamLibRelaEN.UpdDate = objvcc_KnowledgesExamLibRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_KnowledgesExamLibRela.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_KnowledgesExamLibRelaEN.UpdUserId = objvcc_KnowledgesExamLibRelaEN.UpdUserId == "[null]" ? null :  objvcc_KnowledgesExamLibRelaEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convcc_KnowledgesExamLibRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_KnowledgesExamLibRelaEN.Memo = objvcc_KnowledgesExamLibRelaEN.Memo == "[null]" ? null :  objvcc_KnowledgesExamLibRelaEN.Memo; //备注
}
if (arrFldSet.Contains(convcc_KnowledgesExamLibRela.ChapterNameSim4Question, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question = objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question == "[null]" ? null :  objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question; //ChapterName_Sim4Question
}
if (arrFldSet.Contains(convcc_KnowledgesExamLibRela.SectionNameSim4Question, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question = objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question == "[null]" ? null :  objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question; //SectionName_Sim4Question
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
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN)
{
try
{
if (objvcc_KnowledgesExamLibRelaEN.QuestionName == "[null]") objvcc_KnowledgesExamLibRelaEN.QuestionName = null; //题目名称
if (objvcc_KnowledgesExamLibRelaEN.QuestionContent == "[null]") objvcc_KnowledgesExamLibRelaEN.QuestionContent = null; //题目内容
if (objvcc_KnowledgesExamLibRelaEN.ChapterNameSim == "[null]") objvcc_KnowledgesExamLibRelaEN.ChapterNameSim = null; //章名简称
if (objvcc_KnowledgesExamLibRelaEN.SectionNameSim == "[null]") objvcc_KnowledgesExamLibRelaEN.SectionNameSim = null; //节名简称
if (objvcc_KnowledgesExamLibRelaEN.CourseId == "[null]") objvcc_KnowledgesExamLibRelaEN.CourseId = null; //课程Id
if (objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle == "[null]") objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle = null; //知识点标题
if (objvcc_KnowledgesExamLibRelaEN.KnowledgeContent == "[null]") objvcc_KnowledgesExamLibRelaEN.KnowledgeContent = null; //知识点内容
if (objvcc_KnowledgesExamLibRelaEN.CourseName == "[null]") objvcc_KnowledgesExamLibRelaEN.CourseName = null; //课程名称
if (objvcc_KnowledgesExamLibRelaEN.ChapterId == "[null]") objvcc_KnowledgesExamLibRelaEN.ChapterId = null; //章Id
if (objvcc_KnowledgesExamLibRelaEN.UpdUserId == "[null]") objvcc_KnowledgesExamLibRelaEN.UpdUserId = null; //修改用户Id
if (objvcc_KnowledgesExamLibRelaEN.Memo == "[null]") objvcc_KnowledgesExamLibRelaEN.Memo = null; //备注
if (objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question == "[null]") objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question = null; //ChapterName_Sim4Question
if (objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question == "[null]") objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question = null; //SectionName_Sim4Question
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
public static void CheckProperty4Condition(clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN)
{
 vcc_KnowledgesExamLibRelaDA.CheckProperty4Condition(objvcc_KnowledgesExamLibRelaEN);
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
if (clscc_KnowledgesExamLibRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_KnowledgesExamLibRelaBL没有刷新缓存机制(clscc_KnowledgesExamLibRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvcc_KnowledgesExamLibRelaObjLstCache == null)
//{
//arrvcc_KnowledgesExamLibRelaObjLstCache = vcc_KnowledgesExamLibRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_KnowledgesExamLibRelaEN GetObjBymIdCache(long lngmId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvcc_KnowledgesExamLibRelaEN._CurrTabName, strCourseId);
List<clsvcc_KnowledgesExamLibRelaEN> arrvcc_KnowledgesExamLibRelaObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_KnowledgesExamLibRelaEN> arrvcc_KnowledgesExamLibRelaObjLst_Sel =
arrvcc_KnowledgesExamLibRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvcc_KnowledgesExamLibRelaObjLst_Sel.Count() == 0)
{
   clsvcc_KnowledgesExamLibRelaEN obj = clsvcc_KnowledgesExamLibRelaBL.GetObjBymId(lngmId);
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
return arrvcc_KnowledgesExamLibRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_KnowledgesExamLibRelaEN> GetAllvcc_KnowledgesExamLibRelaObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvcc_KnowledgesExamLibRelaEN> arrvcc_KnowledgesExamLibRelaObjLstCache = GetObjLstCache(strCourseId); 
return arrvcc_KnowledgesExamLibRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_KnowledgesExamLibRelaEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvcc_KnowledgesExamLibRelaEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvcc_KnowledgesExamLibRelaEN> arrvcc_KnowledgesExamLibRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvcc_KnowledgesExamLibRelaObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvcc_KnowledgesExamLibRelaEN._CurrTabName, strCourseId);
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
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strCourseId)
{
if (strInFldName != convcc_KnowledgesExamLibRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_KnowledgesExamLibRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_KnowledgesExamLibRela.AttributeName));
throw new Exception(strMsg);
}
var objvcc_KnowledgesExamLibRela = clsvcc_KnowledgesExamLibRelaBL.GetObjBymIdCache(lngmId, strCourseId);
if (objvcc_KnowledgesExamLibRela == null) return "";
return objvcc_KnowledgesExamLibRela[strOutFldName].ToString();
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
int intRecCount = clsvcc_KnowledgesExamLibRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_KnowledgesExamLibRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_KnowledgesExamLibRelaDA.GetRecCount();
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
int intRecCount = clsvcc_KnowledgesExamLibRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaCond)
{
 string strCourseId = objvcc_KnowledgesExamLibRelaCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvcc_KnowledgesExamLibRelaBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvcc_KnowledgesExamLibRelaEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_KnowledgesExamLibRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_KnowledgesExamLibRela.AttributeName)
{
if (objvcc_KnowledgesExamLibRelaCond.IsUpdated(strFldName) == false) continue;
if (objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_KnowledgesExamLibRelaCond[strFldName].ToString());
}
else
{
if (objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_KnowledgesExamLibRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_KnowledgesExamLibRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_KnowledgesExamLibRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_KnowledgesExamLibRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_KnowledgesExamLibRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_KnowledgesExamLibRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_KnowledgesExamLibRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_KnowledgesExamLibRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_KnowledgesExamLibRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_KnowledgesExamLibRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_KnowledgesExamLibRelaCond[strFldName]));
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
 List<string> arrList = clsvcc_KnowledgesExamLibRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_KnowledgesExamLibRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_KnowledgesExamLibRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}