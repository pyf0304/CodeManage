
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserAnswerResultBL
 表名:vUserAnswerResult(01120022)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:26
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷结果(QuestionnaireResult)
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
public static class  clsvUserAnswerResultBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngMinId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserAnswerResultEN GetObj(this K_MinId_vUserAnswerResult myKey)
{
clsvUserAnswerResultEN objvUserAnswerResultEN = clsvUserAnswerResultBL.vUserAnswerResultDA.GetObjByMinId(myKey.Value);
return objvUserAnswerResultEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetMinId(this clsvUserAnswerResultEN objvUserAnswerResultEN, long lngMinId, string strComparisonOp="")
	{
objvUserAnswerResultEN.MinId = lngMinId; //MinId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.MinId) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.MinId, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.MinId] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetQuestionId(this clsvUserAnswerResultEN objvUserAnswerResultEN, long? lngQuestionId, string strComparisonOp="")
	{
objvUserAnswerResultEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.QuestionId) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.QuestionId, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.QuestionId] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetQuestionIndex(this clsvUserAnswerResultEN objvUserAnswerResultEN, int? intQuestionIndex, string strComparisonOp="")
	{
objvUserAnswerResultEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.QuestionIndex) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.QuestionIndex, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.QuestionIndex] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetQuestionName(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strQuestionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionName, 500, convUserAnswerResult.QuestionName);
}
objvUserAnswerResultEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.QuestionName) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.QuestionName, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.QuestionName] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetQuestionNo(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strQuestionNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, convUserAnswerResult.QuestionNo);
}
objvUserAnswerResultEN.QuestionNo = strQuestionNo; //题目编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.QuestionNo) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.QuestionNo, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.QuestionNo] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetQuestionTypeId(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convUserAnswerResult.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convUserAnswerResult.QuestionTypeId);
}
objvUserAnswerResultEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.QuestionTypeId) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.QuestionTypeId, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.QuestionTypeId] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetQuestionTypeName(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strQuestionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convUserAnswerResult.QuestionTypeName);
}
objvUserAnswerResultEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.QuestionTypeName) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.QuestionTypeName, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.QuestionTypeName] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetAnswerTypeId(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strAnswerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convUserAnswerResult.AnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convUserAnswerResult.AnswerTypeId);
}
objvUserAnswerResultEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.AnswerTypeId) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.AnswerTypeId, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.AnswerTypeId] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetAnswerTypeName(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strAnswerTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeName, 50, convUserAnswerResult.AnswerTypeName);
}
objvUserAnswerResultEN.AnswerTypeName = strAnswerTypeName; //答案类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.AnswerTypeName) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.AnswerTypeName, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.AnswerTypeName] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetGridTitle(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strGridTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGridTitle, 30, convUserAnswerResult.GridTitle);
}
objvUserAnswerResultEN.GridTitle = strGridTitle; //表格标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.GridTitle) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.GridTitle, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.GridTitle] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetAnswerModeId(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strAnswerModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convUserAnswerResult.AnswerModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convUserAnswerResult.AnswerModeId);
}
objvUserAnswerResultEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.AnswerModeId) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.AnswerModeId, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.AnswerModeId] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetQuestionScore(this clsvUserAnswerResultEN objvUserAnswerResultEN, float? fltQuestionScore, string strComparisonOp="")
	{
objvUserAnswerResultEN.QuestionScore = fltQuestionScore; //题目得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.QuestionScore) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.QuestionScore, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.QuestionScore] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetQuestionnaireSetId(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strQuestionnaireSetId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionnaireSetId, 4, convUserAnswerResult.QuestionnaireSetId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionnaireSetId, 4, convUserAnswerResult.QuestionnaireSetId);
}
objvUserAnswerResultEN.QuestionnaireSetId = strQuestionnaireSetId; //问卷集ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.QuestionnaireSetId) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.QuestionnaireSetId, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.QuestionnaireSetId] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetCourseId(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convUserAnswerResult.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convUserAnswerResult.CourseId);
}
objvUserAnswerResultEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.CourseId) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.CourseId, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.CourseId] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetCourseName(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convUserAnswerResult.CourseName);
}
objvUserAnswerResultEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.CourseName) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.CourseName, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.CourseName] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetCourseExamPaperId(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strCourseExamPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convUserAnswerResult.CourseExamPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convUserAnswerResult.CourseExamPaperId);
}
objvUserAnswerResultEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.CourseExamPaperId) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.CourseExamPaperId, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.CourseExamPaperId] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetAnswerOptionId(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strAnswerOptionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerOptionId, 8, convUserAnswerResult.AnswerOptionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerOptionId, 8, convUserAnswerResult.AnswerOptionId);
}
objvUserAnswerResultEN.AnswerOptionId = strAnswerOptionId; //回答选项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.AnswerOptionId) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.AnswerOptionId, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.AnswerOptionId] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetOptionName(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strOptionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOptionName, 4000, convUserAnswerResult.OptionName);
}
objvUserAnswerResultEN.OptionName = strOptionName; //选项名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.OptionName) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.OptionName, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.OptionName] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetOptionIndex(this clsvUserAnswerResultEN objvUserAnswerResultEN, int? intOptionIndex, string strComparisonOp="")
	{
objvUserAnswerResultEN.OptionIndex = intOptionIndex; //选项序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.OptionIndex) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.OptionIndex, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.OptionIndex] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetOptionTitle(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strOptionTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOptionTitle, 20, convUserAnswerResult.OptionTitle);
}
objvUserAnswerResultEN.OptionTitle = strOptionTitle; //选项标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.OptionTitle) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.OptionTitle, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.OptionTitle] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetBatchId(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strBatchId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBatchId, 4, convUserAnswerResult.BatchId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strBatchId, 4, convUserAnswerResult.BatchId);
}
objvUserAnswerResultEN.BatchId = strBatchId; //批次ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.BatchId) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.BatchId, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.BatchId] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetUserId(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convUserAnswerResult.UserId);
}
objvUserAnswerResultEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.UserId) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.UserId, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.UserId] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetUserName(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convUserAnswerResult.UserName);
}
objvUserAnswerResultEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.UserName) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.UserName, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.UserName] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetAnswerText(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strAnswerText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerText, 8000, convUserAnswerResult.AnswerText);
}
objvUserAnswerResultEN.AnswerText = strAnswerText; //回答文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.AnswerText) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.AnswerText, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.AnswerText] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetAnswerDate(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strAnswerDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, convUserAnswerResult.AnswerDate);
}
objvUserAnswerResultEN.AnswerDate = strAnswerDate; //回答日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.AnswerDate) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.AnswerDate, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.AnswerDate] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetAnswerTime(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strAnswerTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, convUserAnswerResult.AnswerTime);
}
objvUserAnswerResultEN.AnswerTime = strAnswerTime; //回答时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.AnswerTime) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.AnswerTime, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.AnswerTime] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetAnswerIP(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strAnswerIP, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerIP, 30, convUserAnswerResult.AnswerIP);
}
objvUserAnswerResultEN.AnswerIP = strAnswerIP; //回答IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.AnswerIP) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.AnswerIP, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.AnswerIP] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetIsAccess(this clsvUserAnswerResultEN objvUserAnswerResultEN, bool bolIsAccess, string strComparisonOp="")
	{
objvUserAnswerResultEN.IsAccess = bolIsAccess; //IsAccess
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.IsAccess) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.IsAccess, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.IsAccess] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetIsAccessC(this clsvUserAnswerResultEN objvUserAnswerResultEN, bool bolIsAccessC, string strComparisonOp="")
	{
objvUserAnswerResultEN.IsAccessC = bolIsAccessC; //IsAccessC
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.IsAccessC) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.IsAccessC, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.IsAccessC] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetIdSchool(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strIdSchool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchool, 4, convUserAnswerResult.IdSchool);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, convUserAnswerResult.IdSchool);
}
objvUserAnswerResultEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.IdSchool) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.IdSchool, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.IdSchool] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetSchool(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strSchool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchool, 50, convUserAnswerResult.School);
}
objvUserAnswerResultEN.School = strSchool; //School
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.School) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.School, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.School] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetAnswerMode(this clsvUserAnswerResultEN objvUserAnswerResultEN, int? intAnswerMode, string strComparisonOp="")
	{
objvUserAnswerResultEN.AnswerMode = intAnswerMode; //AnswerMode
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.AnswerMode) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.AnswerMode, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.AnswerMode] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetIsMarking(this clsvUserAnswerResultEN objvUserAnswerResultEN, bool bolIsMarking, string strComparisonOp="")
	{
objvUserAnswerResultEN.IsMarking = bolIsMarking; //是否批阅
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.IsMarking) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.IsMarking, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.IsMarking] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetIsRight(this clsvUserAnswerResultEN objvUserAnswerResultEN, bool bolIsRight, string strComparisonOp="")
	{
objvUserAnswerResultEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.IsRight) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.IsRight, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.IsRight] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetScore(this clsvUserAnswerResultEN objvUserAnswerResultEN, double? dblScore, string strComparisonOp="")
	{
objvUserAnswerResultEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.Score) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.Score, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.Score] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetMarkTime(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strMarkTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkTime, 14, convUserAnswerResult.MarkTime);
}
objvUserAnswerResultEN.MarkTime = strMarkTime; //批改时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.MarkTime) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.MarkTime, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.MarkTime] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetMarkerId(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strMarkerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkerId, 20, convUserAnswerResult.MarkerId);
}
objvUserAnswerResultEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.MarkerId) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.MarkerId, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.MarkerId] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetComment(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strComment, string strComparisonOp="")
	{
objvUserAnswerResultEN.Comment = strComment; //批注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.Comment) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.Comment, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.Comment] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetIsAccessKnowledge(this clsvUserAnswerResultEN objvUserAnswerResultEN, bool bolIsAccessKnowledge, string strComparisonOp="")
	{
objvUserAnswerResultEN.IsAccessKnowledge = bolIsAccessKnowledge; //是否处理知识点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.IsAccessKnowledge) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.IsAccessKnowledge, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.IsAccessKnowledge] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetUpdDate(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convUserAnswerResult.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convUserAnswerResult.UpdDate);
}
objvUserAnswerResultEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.UpdDate) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.UpdDate, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.UpdDate] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetUpdUser(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convUserAnswerResult.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convUserAnswerResult.UpdUser);
}
objvUserAnswerResultEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.UpdUser) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.UpdUser, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.UpdUser] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResultEN SetMemo(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convUserAnswerResult.Memo);
}
objvUserAnswerResultEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.Memo) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.Memo, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.Memo] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvUserAnswerResultENS">源对象</param>
 /// <param name = "objvUserAnswerResultENT">目标对象</param>
 public static void CopyTo(this clsvUserAnswerResultEN objvUserAnswerResultENS, clsvUserAnswerResultEN objvUserAnswerResultENT)
{
try
{
objvUserAnswerResultENT.MinId = objvUserAnswerResultENS.MinId; //MinId
objvUserAnswerResultENT.QuestionId = objvUserAnswerResultENS.QuestionId; //题目Id
objvUserAnswerResultENT.QuestionIndex = objvUserAnswerResultENS.QuestionIndex; //题目序号
objvUserAnswerResultENT.QuestionName = objvUserAnswerResultENS.QuestionName; //题目名称
objvUserAnswerResultENT.QuestionNo = objvUserAnswerResultENS.QuestionNo; //题目编号
objvUserAnswerResultENT.QuestionTypeId = objvUserAnswerResultENS.QuestionTypeId; //题目类型Id
objvUserAnswerResultENT.QuestionTypeName = objvUserAnswerResultENS.QuestionTypeName; //题目类型名
objvUserAnswerResultENT.AnswerTypeId = objvUserAnswerResultENS.AnswerTypeId; //答案类型ID
objvUserAnswerResultENT.AnswerTypeName = objvUserAnswerResultENS.AnswerTypeName; //答案类型名
objvUserAnswerResultENT.GridTitle = objvUserAnswerResultENS.GridTitle; //表格标题
objvUserAnswerResultENT.AnswerModeId = objvUserAnswerResultENS.AnswerModeId; //答案模式Id
objvUserAnswerResultENT.QuestionScore = objvUserAnswerResultENS.QuestionScore; //题目得分
objvUserAnswerResultENT.QuestionnaireSetId = objvUserAnswerResultENS.QuestionnaireSetId; //问卷集ID
objvUserAnswerResultENT.CourseId = objvUserAnswerResultENS.CourseId; //课程Id
objvUserAnswerResultENT.CourseName = objvUserAnswerResultENS.CourseName; //课程名称
objvUserAnswerResultENT.CourseExamPaperId = objvUserAnswerResultENS.CourseExamPaperId; //考卷流水号
objvUserAnswerResultENT.AnswerOptionId = objvUserAnswerResultENS.AnswerOptionId; //回答选项Id
objvUserAnswerResultENT.OptionName = objvUserAnswerResultENS.OptionName; //选项名称
objvUserAnswerResultENT.OptionIndex = objvUserAnswerResultENS.OptionIndex; //选项序号
objvUserAnswerResultENT.OptionTitle = objvUserAnswerResultENS.OptionTitle; //选项标题
objvUserAnswerResultENT.BatchId = objvUserAnswerResultENS.BatchId; //批次ID
objvUserAnswerResultENT.UserId = objvUserAnswerResultENS.UserId; //用户ID
objvUserAnswerResultENT.UserName = objvUserAnswerResultENS.UserName; //用户名
objvUserAnswerResultENT.AnswerText = objvUserAnswerResultENS.AnswerText; //回答文本
objvUserAnswerResultENT.AnswerDate = objvUserAnswerResultENS.AnswerDate; //回答日期
objvUserAnswerResultENT.AnswerTime = objvUserAnswerResultENS.AnswerTime; //回答时间
objvUserAnswerResultENT.AnswerIP = objvUserAnswerResultENS.AnswerIP; //回答IP
objvUserAnswerResultENT.IsAccess = objvUserAnswerResultENS.IsAccess; //IsAccess
objvUserAnswerResultENT.IsAccessC = objvUserAnswerResultENS.IsAccessC; //IsAccessC
objvUserAnswerResultENT.IdSchool = objvUserAnswerResultENS.IdSchool; //学校流水号
objvUserAnswerResultENT.School = objvUserAnswerResultENS.School; //School
objvUserAnswerResultENT.AnswerMode = objvUserAnswerResultENS.AnswerMode; //AnswerMode
objvUserAnswerResultENT.IsMarking = objvUserAnswerResultENS.IsMarking; //是否批阅
objvUserAnswerResultENT.IsRight = objvUserAnswerResultENS.IsRight; //是否正确
objvUserAnswerResultENT.Score = objvUserAnswerResultENS.Score; //得分
objvUserAnswerResultENT.MarkTime = objvUserAnswerResultENS.MarkTime; //批改时间
objvUserAnswerResultENT.MarkerId = objvUserAnswerResultENS.MarkerId; //打分者
objvUserAnswerResultENT.Comment = objvUserAnswerResultENS.Comment; //批注
objvUserAnswerResultENT.IsAccessKnowledge = objvUserAnswerResultENS.IsAccessKnowledge; //是否处理知识点
objvUserAnswerResultENT.UpdDate = objvUserAnswerResultENS.UpdDate; //修改日期
objvUserAnswerResultENT.UpdUser = objvUserAnswerResultENS.UpdUser; //修改人
objvUserAnswerResultENT.Memo = objvUserAnswerResultENS.Memo; //备注
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
 /// <param name = "objvUserAnswerResultENS">源对象</param>
 /// <returns>目标对象=>clsvUserAnswerResultEN:objvUserAnswerResultENT</returns>
 public static clsvUserAnswerResultEN CopyTo(this clsvUserAnswerResultEN objvUserAnswerResultENS)
{
try
{
 clsvUserAnswerResultEN objvUserAnswerResultENT = new clsvUserAnswerResultEN()
{
MinId = objvUserAnswerResultENS.MinId, //MinId
QuestionId = objvUserAnswerResultENS.QuestionId, //题目Id
QuestionIndex = objvUserAnswerResultENS.QuestionIndex, //题目序号
QuestionName = objvUserAnswerResultENS.QuestionName, //题目名称
QuestionNo = objvUserAnswerResultENS.QuestionNo, //题目编号
QuestionTypeId = objvUserAnswerResultENS.QuestionTypeId, //题目类型Id
QuestionTypeName = objvUserAnswerResultENS.QuestionTypeName, //题目类型名
AnswerTypeId = objvUserAnswerResultENS.AnswerTypeId, //答案类型ID
AnswerTypeName = objvUserAnswerResultENS.AnswerTypeName, //答案类型名
GridTitle = objvUserAnswerResultENS.GridTitle, //表格标题
AnswerModeId = objvUserAnswerResultENS.AnswerModeId, //答案模式Id
QuestionScore = objvUserAnswerResultENS.QuestionScore, //题目得分
QuestionnaireSetId = objvUserAnswerResultENS.QuestionnaireSetId, //问卷集ID
CourseId = objvUserAnswerResultENS.CourseId, //课程Id
CourseName = objvUserAnswerResultENS.CourseName, //课程名称
CourseExamPaperId = objvUserAnswerResultENS.CourseExamPaperId, //考卷流水号
AnswerOptionId = objvUserAnswerResultENS.AnswerOptionId, //回答选项Id
OptionName = objvUserAnswerResultENS.OptionName, //选项名称
OptionIndex = objvUserAnswerResultENS.OptionIndex, //选项序号
OptionTitle = objvUserAnswerResultENS.OptionTitle, //选项标题
BatchId = objvUserAnswerResultENS.BatchId, //批次ID
UserId = objvUserAnswerResultENS.UserId, //用户ID
UserName = objvUserAnswerResultENS.UserName, //用户名
AnswerText = objvUserAnswerResultENS.AnswerText, //回答文本
AnswerDate = objvUserAnswerResultENS.AnswerDate, //回答日期
AnswerTime = objvUserAnswerResultENS.AnswerTime, //回答时间
AnswerIP = objvUserAnswerResultENS.AnswerIP, //回答IP
IsAccess = objvUserAnswerResultENS.IsAccess, //IsAccess
IsAccessC = objvUserAnswerResultENS.IsAccessC, //IsAccessC
IdSchool = objvUserAnswerResultENS.IdSchool, //学校流水号
School = objvUserAnswerResultENS.School, //School
AnswerMode = objvUserAnswerResultENS.AnswerMode, //AnswerMode
IsMarking = objvUserAnswerResultENS.IsMarking, //是否批阅
IsRight = objvUserAnswerResultENS.IsRight, //是否正确
Score = objvUserAnswerResultENS.Score, //得分
MarkTime = objvUserAnswerResultENS.MarkTime, //批改时间
MarkerId = objvUserAnswerResultENS.MarkerId, //打分者
Comment = objvUserAnswerResultENS.Comment, //批注
IsAccessKnowledge = objvUserAnswerResultENS.IsAccessKnowledge, //是否处理知识点
UpdDate = objvUserAnswerResultENS.UpdDate, //修改日期
UpdUser = objvUserAnswerResultENS.UpdUser, //修改人
Memo = objvUserAnswerResultENS.Memo, //备注
};
 return objvUserAnswerResultENT;
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
public static void CheckProperty4Condition(this clsvUserAnswerResultEN objvUserAnswerResultEN)
{
 clsvUserAnswerResultBL.vUserAnswerResultDA.CheckProperty4Condition(objvUserAnswerResultEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvUserAnswerResultEN objvUserAnswerResultCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.MinId) == true)
{
string strComparisonOpMinId = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.MinId];
strWhereCond += string.Format(" And {0} {2} {1}", convUserAnswerResult.MinId, objvUserAnswerResultCond.MinId, strComparisonOpMinId);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.QuestionId) == true)
{
string strComparisonOpQuestionId = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", convUserAnswerResult.QuestionId, objvUserAnswerResultCond.QuestionId, strComparisonOpQuestionId);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.QuestionIndex) == true)
{
string strComparisonOpQuestionIndex = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convUserAnswerResult.QuestionIndex, objvUserAnswerResultCond.QuestionIndex, strComparisonOpQuestionIndex);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.QuestionName) == true)
{
string strComparisonOpQuestionName = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.QuestionName, objvUserAnswerResultCond.QuestionName, strComparisonOpQuestionName);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.QuestionNo) == true)
{
string strComparisonOpQuestionNo = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.QuestionNo, objvUserAnswerResultCond.QuestionNo, strComparisonOpQuestionNo);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.QuestionTypeId, objvUserAnswerResultCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.QuestionTypeName) == true)
{
string strComparisonOpQuestionTypeName = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.QuestionTypeName, objvUserAnswerResultCond.QuestionTypeName, strComparisonOpQuestionTypeName);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.AnswerTypeId) == true)
{
string strComparisonOpAnswerTypeId = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.AnswerTypeId, objvUserAnswerResultCond.AnswerTypeId, strComparisonOpAnswerTypeId);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.AnswerTypeName) == true)
{
string strComparisonOpAnswerTypeName = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.AnswerTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.AnswerTypeName, objvUserAnswerResultCond.AnswerTypeName, strComparisonOpAnswerTypeName);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.GridTitle) == true)
{
string strComparisonOpGridTitle = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.GridTitle, objvUserAnswerResultCond.GridTitle, strComparisonOpGridTitle);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.AnswerModeId) == true)
{
string strComparisonOpAnswerModeId = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.AnswerModeId, objvUserAnswerResultCond.AnswerModeId, strComparisonOpAnswerModeId);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.QuestionScore) == true)
{
string strComparisonOpQuestionScore = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.QuestionScore];
strWhereCond += string.Format(" And {0} {2} {1}", convUserAnswerResult.QuestionScore, objvUserAnswerResultCond.QuestionScore, strComparisonOpQuestionScore);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.QuestionnaireSetId) == true)
{
string strComparisonOpQuestionnaireSetId = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.QuestionnaireSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.QuestionnaireSetId, objvUserAnswerResultCond.QuestionnaireSetId, strComparisonOpQuestionnaireSetId);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.CourseId) == true)
{
string strComparisonOpCourseId = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.CourseId, objvUserAnswerResultCond.CourseId, strComparisonOpCourseId);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.CourseName) == true)
{
string strComparisonOpCourseName = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.CourseName, objvUserAnswerResultCond.CourseName, strComparisonOpCourseName);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.CourseExamPaperId) == true)
{
string strComparisonOpCourseExamPaperId = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.CourseExamPaperId, objvUserAnswerResultCond.CourseExamPaperId, strComparisonOpCourseExamPaperId);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.AnswerOptionId) == true)
{
string strComparisonOpAnswerOptionId = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.AnswerOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.AnswerOptionId, objvUserAnswerResultCond.AnswerOptionId, strComparisonOpAnswerOptionId);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.OptionName) == true)
{
string strComparisonOpOptionName = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.OptionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.OptionName, objvUserAnswerResultCond.OptionName, strComparisonOpOptionName);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.OptionIndex) == true)
{
string strComparisonOpOptionIndex = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.OptionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convUserAnswerResult.OptionIndex, objvUserAnswerResultCond.OptionIndex, strComparisonOpOptionIndex);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.OptionTitle) == true)
{
string strComparisonOpOptionTitle = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.OptionTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.OptionTitle, objvUserAnswerResultCond.OptionTitle, strComparisonOpOptionTitle);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.BatchId) == true)
{
string strComparisonOpBatchId = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.BatchId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.BatchId, objvUserAnswerResultCond.BatchId, strComparisonOpBatchId);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.UserId) == true)
{
string strComparisonOpUserId = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.UserId, objvUserAnswerResultCond.UserId, strComparisonOpUserId);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.UserName) == true)
{
string strComparisonOpUserName = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.UserName, objvUserAnswerResultCond.UserName, strComparisonOpUserName);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.AnswerText) == true)
{
string strComparisonOpAnswerText = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.AnswerText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.AnswerText, objvUserAnswerResultCond.AnswerText, strComparisonOpAnswerText);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.AnswerDate) == true)
{
string strComparisonOpAnswerDate = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.AnswerDate, objvUserAnswerResultCond.AnswerDate, strComparisonOpAnswerDate);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.AnswerTime) == true)
{
string strComparisonOpAnswerTime = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.AnswerTime, objvUserAnswerResultCond.AnswerTime, strComparisonOpAnswerTime);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.AnswerIP) == true)
{
string strComparisonOpAnswerIP = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.AnswerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.AnswerIP, objvUserAnswerResultCond.AnswerIP, strComparisonOpAnswerIP);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.IsAccess) == true)
{
if (objvUserAnswerResultCond.IsAccess == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserAnswerResult.IsAccess);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserAnswerResult.IsAccess);
}
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.IsAccessC) == true)
{
if (objvUserAnswerResultCond.IsAccessC == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserAnswerResult.IsAccessC);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserAnswerResult.IsAccessC);
}
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.IdSchool) == true)
{
string strComparisonOpIdSchool = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.IdSchool, objvUserAnswerResultCond.IdSchool, strComparisonOpIdSchool);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.School) == true)
{
string strComparisonOpSchool = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.School];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.School, objvUserAnswerResultCond.School, strComparisonOpSchool);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.AnswerMode) == true)
{
string strComparisonOpAnswerMode = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.AnswerMode];
strWhereCond += string.Format(" And {0} {2} {1}", convUserAnswerResult.AnswerMode, objvUserAnswerResultCond.AnswerMode, strComparisonOpAnswerMode);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.IsMarking) == true)
{
if (objvUserAnswerResultCond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserAnswerResult.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserAnswerResult.IsMarking);
}
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.IsRight) == true)
{
if (objvUserAnswerResultCond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserAnswerResult.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserAnswerResult.IsRight);
}
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.Score) == true)
{
string strComparisonOpScore = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convUserAnswerResult.Score, objvUserAnswerResultCond.Score, strComparisonOpScore);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.MarkTime) == true)
{
string strComparisonOpMarkTime = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.MarkTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.MarkTime, objvUserAnswerResultCond.MarkTime, strComparisonOpMarkTime);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.MarkerId) == true)
{
string strComparisonOpMarkerId = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.MarkerId, objvUserAnswerResultCond.MarkerId, strComparisonOpMarkerId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.IsAccessKnowledge) == true)
{
if (objvUserAnswerResultCond.IsAccessKnowledge == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserAnswerResult.IsAccessKnowledge);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserAnswerResult.IsAccessKnowledge);
}
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.UpdDate) == true)
{
string strComparisonOpUpdDate = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.UpdDate, objvUserAnswerResultCond.UpdDate, strComparisonOpUpdDate);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.UpdUser) == true)
{
string strComparisonOpUpdUser = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.UpdUser, objvUserAnswerResultCond.UpdUser, strComparisonOpUpdUser);
}
if (objvUserAnswerResultCond.IsUpdated(convUserAnswerResult.Memo) == true)
{
string strComparisonOpMemo = objvUserAnswerResultCond.dicFldComparisonOp[convUserAnswerResult.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.Memo, objvUserAnswerResultCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vUserAnswerResult
{
public virtual bool UpdRelaTabDate(long lngMinId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v用户答题结果(vUserAnswerResult)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvUserAnswerResultBL
{
public static RelatedActions_vUserAnswerResult relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvUserAnswerResultDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvUserAnswerResultDA vUserAnswerResultDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvUserAnswerResultDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvUserAnswerResultBL()
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
if (string.IsNullOrEmpty(clsvUserAnswerResultEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvUserAnswerResultEN._ConnectString);
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
public static DataTable GetDataTable_vUserAnswerResult(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vUserAnswerResultDA.GetDataTable_vUserAnswerResult(strWhereCond);
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
objDT = vUserAnswerResultDA.GetDataTable(strWhereCond);
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
objDT = vUserAnswerResultDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vUserAnswerResultDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vUserAnswerResultDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vUserAnswerResultDA.GetDataTable_Top(objTopPara);
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
objDT = vUserAnswerResultDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vUserAnswerResultDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vUserAnswerResultDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMinIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvUserAnswerResultEN> GetObjLstByMinIdLst(List<long> arrMinIdLst)
{
List<clsvUserAnswerResultEN> arrObjLst = new List<clsvUserAnswerResultEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMinIdLst);
 string strWhereCond = string.Format("MinId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserAnswerResultEN objvUserAnswerResultEN = new clsvUserAnswerResultEN();
try
{
objvUserAnswerResultEN.MinId = Int32.Parse(objRow[convUserAnswerResult.MinId].ToString().Trim()); //MinId
objvUserAnswerResultEN.QuestionId = objRow[convUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResultEN.QuestionIndex = objRow[convUserAnswerResult.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.QuestionIndex].ToString().Trim()); //题目序号
objvUserAnswerResultEN.QuestionName = objRow[convUserAnswerResult.QuestionName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionName].ToString().Trim(); //题目名称
objvUserAnswerResultEN.QuestionNo = objRow[convUserAnswerResult.QuestionNo] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionNo].ToString().Trim(); //题目编号
objvUserAnswerResultEN.QuestionTypeId = objRow[convUserAnswerResult.QuestionTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeId].ToString().Trim(); //题目类型Id
objvUserAnswerResultEN.QuestionTypeName = objRow[convUserAnswerResult.QuestionTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeName].ToString().Trim(); //题目类型名
objvUserAnswerResultEN.AnswerTypeId = objRow[convUserAnswerResult.AnswerTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeId].ToString().Trim(); //答案类型ID
objvUserAnswerResultEN.AnswerTypeName = objRow[convUserAnswerResult.AnswerTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeName].ToString().Trim(); //答案类型名
objvUserAnswerResultEN.GridTitle = objRow[convUserAnswerResult.GridTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.GridTitle].ToString().Trim(); //表格标题
objvUserAnswerResultEN.AnswerModeId = objRow[convUserAnswerResult.AnswerModeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerModeId].ToString().Trim(); //答案模式Id
objvUserAnswerResultEN.QuestionScore = objRow[convUserAnswerResult.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convUserAnswerResult.QuestionScore].ToString().Trim()); //题目得分
objvUserAnswerResultEN.QuestionnaireSetId = objRow[convUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResultEN.CourseId = objRow[convUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objvUserAnswerResultEN.CourseName = objRow[convUserAnswerResult.CourseName] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseName].ToString().Trim(); //课程名称
objvUserAnswerResultEN.CourseExamPaperId = objRow[convUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvUserAnswerResultEN.AnswerOptionId = objRow[convUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objvUserAnswerResultEN.OptionName = objRow[convUserAnswerResult.OptionName] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionName].ToString().Trim(); //选项名称
objvUserAnswerResultEN.OptionIndex = objRow[convUserAnswerResult.OptionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.OptionIndex].ToString().Trim()); //选项序号
objvUserAnswerResultEN.OptionTitle = objRow[convUserAnswerResult.OptionTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionTitle].ToString().Trim(); //选项标题
objvUserAnswerResultEN.BatchId = objRow[convUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[convUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objvUserAnswerResultEN.UserId = objRow[convUserAnswerResult.UserId] == DBNull.Value ? null : objRow[convUserAnswerResult.UserId].ToString().Trim(); //用户ID
objvUserAnswerResultEN.UserName = objRow[convUserAnswerResult.UserName] == DBNull.Value ? null : objRow[convUserAnswerResult.UserName].ToString().Trim(); //用户名
objvUserAnswerResultEN.AnswerText = objRow[convUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objvUserAnswerResultEN.AnswerDate = objRow[convUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objvUserAnswerResultEN.AnswerTime = objRow[convUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objvUserAnswerResultEN.AnswerIP = objRow[convUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objvUserAnswerResultEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objvUserAnswerResultEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objvUserAnswerResultEN.IdSchool = objRow[convUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[convUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objvUserAnswerResultEN.School = objRow[convUserAnswerResult.School] == DBNull.Value ? null : objRow[convUserAnswerResult.School].ToString().Trim(); //School
objvUserAnswerResultEN.AnswerMode = objRow[convUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objvUserAnswerResultEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objvUserAnswerResultEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objvUserAnswerResultEN.Score = objRow[convUserAnswerResult.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convUserAnswerResult.Score].ToString().Trim()); //得分
objvUserAnswerResultEN.MarkTime = objRow[convUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objvUserAnswerResultEN.MarkerId = objRow[convUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objvUserAnswerResultEN.Comment = objRow[convUserAnswerResult.Comment] == DBNull.Value ? null : objRow[convUserAnswerResult.Comment].ToString().Trim(); //批注
objvUserAnswerResultEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvUserAnswerResultEN.UpdDate = objRow[convUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objvUserAnswerResultEN.UpdUser = objRow[convUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objvUserAnswerResultEN.Memo = objRow[convUserAnswerResult.Memo] == DBNull.Value ? null : objRow[convUserAnswerResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserAnswerResultEN.MinId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserAnswerResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMinIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvUserAnswerResultEN> GetObjLstByMinIdLstCache(List<long> arrMinIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvUserAnswerResultEN._CurrTabName, strCourseId);
List<clsvUserAnswerResultEN> arrvUserAnswerResultObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvUserAnswerResultEN> arrvUserAnswerResultObjLst_Sel =
arrvUserAnswerResultObjLstCache
.Where(x => arrMinIdLst.Contains(x.MinId));
return arrvUserAnswerResultObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserAnswerResultEN> GetObjLst(string strWhereCond)
{
List<clsvUserAnswerResultEN> arrObjLst = new List<clsvUserAnswerResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserAnswerResultEN objvUserAnswerResultEN = new clsvUserAnswerResultEN();
try
{
objvUserAnswerResultEN.MinId = Int32.Parse(objRow[convUserAnswerResult.MinId].ToString().Trim()); //MinId
objvUserAnswerResultEN.QuestionId = objRow[convUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResultEN.QuestionIndex = objRow[convUserAnswerResult.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.QuestionIndex].ToString().Trim()); //题目序号
objvUserAnswerResultEN.QuestionName = objRow[convUserAnswerResult.QuestionName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionName].ToString().Trim(); //题目名称
objvUserAnswerResultEN.QuestionNo = objRow[convUserAnswerResult.QuestionNo] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionNo].ToString().Trim(); //题目编号
objvUserAnswerResultEN.QuestionTypeId = objRow[convUserAnswerResult.QuestionTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeId].ToString().Trim(); //题目类型Id
objvUserAnswerResultEN.QuestionTypeName = objRow[convUserAnswerResult.QuestionTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeName].ToString().Trim(); //题目类型名
objvUserAnswerResultEN.AnswerTypeId = objRow[convUserAnswerResult.AnswerTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeId].ToString().Trim(); //答案类型ID
objvUserAnswerResultEN.AnswerTypeName = objRow[convUserAnswerResult.AnswerTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeName].ToString().Trim(); //答案类型名
objvUserAnswerResultEN.GridTitle = objRow[convUserAnswerResult.GridTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.GridTitle].ToString().Trim(); //表格标题
objvUserAnswerResultEN.AnswerModeId = objRow[convUserAnswerResult.AnswerModeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerModeId].ToString().Trim(); //答案模式Id
objvUserAnswerResultEN.QuestionScore = objRow[convUserAnswerResult.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convUserAnswerResult.QuestionScore].ToString().Trim()); //题目得分
objvUserAnswerResultEN.QuestionnaireSetId = objRow[convUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResultEN.CourseId = objRow[convUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objvUserAnswerResultEN.CourseName = objRow[convUserAnswerResult.CourseName] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseName].ToString().Trim(); //课程名称
objvUserAnswerResultEN.CourseExamPaperId = objRow[convUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvUserAnswerResultEN.AnswerOptionId = objRow[convUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objvUserAnswerResultEN.OptionName = objRow[convUserAnswerResult.OptionName] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionName].ToString().Trim(); //选项名称
objvUserAnswerResultEN.OptionIndex = objRow[convUserAnswerResult.OptionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.OptionIndex].ToString().Trim()); //选项序号
objvUserAnswerResultEN.OptionTitle = objRow[convUserAnswerResult.OptionTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionTitle].ToString().Trim(); //选项标题
objvUserAnswerResultEN.BatchId = objRow[convUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[convUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objvUserAnswerResultEN.UserId = objRow[convUserAnswerResult.UserId] == DBNull.Value ? null : objRow[convUserAnswerResult.UserId].ToString().Trim(); //用户ID
objvUserAnswerResultEN.UserName = objRow[convUserAnswerResult.UserName] == DBNull.Value ? null : objRow[convUserAnswerResult.UserName].ToString().Trim(); //用户名
objvUserAnswerResultEN.AnswerText = objRow[convUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objvUserAnswerResultEN.AnswerDate = objRow[convUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objvUserAnswerResultEN.AnswerTime = objRow[convUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objvUserAnswerResultEN.AnswerIP = objRow[convUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objvUserAnswerResultEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objvUserAnswerResultEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objvUserAnswerResultEN.IdSchool = objRow[convUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[convUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objvUserAnswerResultEN.School = objRow[convUserAnswerResult.School] == DBNull.Value ? null : objRow[convUserAnswerResult.School].ToString().Trim(); //School
objvUserAnswerResultEN.AnswerMode = objRow[convUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objvUserAnswerResultEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objvUserAnswerResultEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objvUserAnswerResultEN.Score = objRow[convUserAnswerResult.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convUserAnswerResult.Score].ToString().Trim()); //得分
objvUserAnswerResultEN.MarkTime = objRow[convUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objvUserAnswerResultEN.MarkerId = objRow[convUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objvUserAnswerResultEN.Comment = objRow[convUserAnswerResult.Comment] == DBNull.Value ? null : objRow[convUserAnswerResult.Comment].ToString().Trim(); //批注
objvUserAnswerResultEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvUserAnswerResultEN.UpdDate = objRow[convUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objvUserAnswerResultEN.UpdUser = objRow[convUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objvUserAnswerResultEN.Memo = objRow[convUserAnswerResult.Memo] == DBNull.Value ? null : objRow[convUserAnswerResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserAnswerResultEN.MinId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserAnswerResultEN);
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
public static List<clsvUserAnswerResultEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvUserAnswerResultEN> arrObjLst = new List<clsvUserAnswerResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserAnswerResultEN objvUserAnswerResultEN = new clsvUserAnswerResultEN();
try
{
objvUserAnswerResultEN.MinId = Int32.Parse(objRow[convUserAnswerResult.MinId].ToString().Trim()); //MinId
objvUserAnswerResultEN.QuestionId = objRow[convUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResultEN.QuestionIndex = objRow[convUserAnswerResult.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.QuestionIndex].ToString().Trim()); //题目序号
objvUserAnswerResultEN.QuestionName = objRow[convUserAnswerResult.QuestionName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionName].ToString().Trim(); //题目名称
objvUserAnswerResultEN.QuestionNo = objRow[convUserAnswerResult.QuestionNo] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionNo].ToString().Trim(); //题目编号
objvUserAnswerResultEN.QuestionTypeId = objRow[convUserAnswerResult.QuestionTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeId].ToString().Trim(); //题目类型Id
objvUserAnswerResultEN.QuestionTypeName = objRow[convUserAnswerResult.QuestionTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeName].ToString().Trim(); //题目类型名
objvUserAnswerResultEN.AnswerTypeId = objRow[convUserAnswerResult.AnswerTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeId].ToString().Trim(); //答案类型ID
objvUserAnswerResultEN.AnswerTypeName = objRow[convUserAnswerResult.AnswerTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeName].ToString().Trim(); //答案类型名
objvUserAnswerResultEN.GridTitle = objRow[convUserAnswerResult.GridTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.GridTitle].ToString().Trim(); //表格标题
objvUserAnswerResultEN.AnswerModeId = objRow[convUserAnswerResult.AnswerModeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerModeId].ToString().Trim(); //答案模式Id
objvUserAnswerResultEN.QuestionScore = objRow[convUserAnswerResult.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convUserAnswerResult.QuestionScore].ToString().Trim()); //题目得分
objvUserAnswerResultEN.QuestionnaireSetId = objRow[convUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResultEN.CourseId = objRow[convUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objvUserAnswerResultEN.CourseName = objRow[convUserAnswerResult.CourseName] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseName].ToString().Trim(); //课程名称
objvUserAnswerResultEN.CourseExamPaperId = objRow[convUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvUserAnswerResultEN.AnswerOptionId = objRow[convUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objvUserAnswerResultEN.OptionName = objRow[convUserAnswerResult.OptionName] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionName].ToString().Trim(); //选项名称
objvUserAnswerResultEN.OptionIndex = objRow[convUserAnswerResult.OptionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.OptionIndex].ToString().Trim()); //选项序号
objvUserAnswerResultEN.OptionTitle = objRow[convUserAnswerResult.OptionTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionTitle].ToString().Trim(); //选项标题
objvUserAnswerResultEN.BatchId = objRow[convUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[convUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objvUserAnswerResultEN.UserId = objRow[convUserAnswerResult.UserId] == DBNull.Value ? null : objRow[convUserAnswerResult.UserId].ToString().Trim(); //用户ID
objvUserAnswerResultEN.UserName = objRow[convUserAnswerResult.UserName] == DBNull.Value ? null : objRow[convUserAnswerResult.UserName].ToString().Trim(); //用户名
objvUserAnswerResultEN.AnswerText = objRow[convUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objvUserAnswerResultEN.AnswerDate = objRow[convUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objvUserAnswerResultEN.AnswerTime = objRow[convUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objvUserAnswerResultEN.AnswerIP = objRow[convUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objvUserAnswerResultEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objvUserAnswerResultEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objvUserAnswerResultEN.IdSchool = objRow[convUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[convUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objvUserAnswerResultEN.School = objRow[convUserAnswerResult.School] == DBNull.Value ? null : objRow[convUserAnswerResult.School].ToString().Trim(); //School
objvUserAnswerResultEN.AnswerMode = objRow[convUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objvUserAnswerResultEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objvUserAnswerResultEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objvUserAnswerResultEN.Score = objRow[convUserAnswerResult.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convUserAnswerResult.Score].ToString().Trim()); //得分
objvUserAnswerResultEN.MarkTime = objRow[convUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objvUserAnswerResultEN.MarkerId = objRow[convUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objvUserAnswerResultEN.Comment = objRow[convUserAnswerResult.Comment] == DBNull.Value ? null : objRow[convUserAnswerResult.Comment].ToString().Trim(); //批注
objvUserAnswerResultEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvUserAnswerResultEN.UpdDate = objRow[convUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objvUserAnswerResultEN.UpdUser = objRow[convUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objvUserAnswerResultEN.Memo = objRow[convUserAnswerResult.Memo] == DBNull.Value ? null : objRow[convUserAnswerResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserAnswerResultEN.MinId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserAnswerResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvUserAnswerResultCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvUserAnswerResultEN> GetSubObjLstCache(clsvUserAnswerResultEN objvUserAnswerResultCond)
{
 string strCourseId = objvUserAnswerResultCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvUserAnswerResultBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvUserAnswerResultEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvUserAnswerResultEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convUserAnswerResult.AttributeName)
{
if (objvUserAnswerResultCond.IsUpdated(strFldName) == false) continue;
if (objvUserAnswerResultCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserAnswerResultCond[strFldName].ToString());
}
else
{
if (objvUserAnswerResultCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUserAnswerResultCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserAnswerResultCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUserAnswerResultCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUserAnswerResultCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUserAnswerResultCond[strFldName]));
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
public static List<clsvUserAnswerResultEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvUserAnswerResultEN> arrObjLst = new List<clsvUserAnswerResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserAnswerResultEN objvUserAnswerResultEN = new clsvUserAnswerResultEN();
try
{
objvUserAnswerResultEN.MinId = Int32.Parse(objRow[convUserAnswerResult.MinId].ToString().Trim()); //MinId
objvUserAnswerResultEN.QuestionId = objRow[convUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResultEN.QuestionIndex = objRow[convUserAnswerResult.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.QuestionIndex].ToString().Trim()); //题目序号
objvUserAnswerResultEN.QuestionName = objRow[convUserAnswerResult.QuestionName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionName].ToString().Trim(); //题目名称
objvUserAnswerResultEN.QuestionNo = objRow[convUserAnswerResult.QuestionNo] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionNo].ToString().Trim(); //题目编号
objvUserAnswerResultEN.QuestionTypeId = objRow[convUserAnswerResult.QuestionTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeId].ToString().Trim(); //题目类型Id
objvUserAnswerResultEN.QuestionTypeName = objRow[convUserAnswerResult.QuestionTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeName].ToString().Trim(); //题目类型名
objvUserAnswerResultEN.AnswerTypeId = objRow[convUserAnswerResult.AnswerTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeId].ToString().Trim(); //答案类型ID
objvUserAnswerResultEN.AnswerTypeName = objRow[convUserAnswerResult.AnswerTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeName].ToString().Trim(); //答案类型名
objvUserAnswerResultEN.GridTitle = objRow[convUserAnswerResult.GridTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.GridTitle].ToString().Trim(); //表格标题
objvUserAnswerResultEN.AnswerModeId = objRow[convUserAnswerResult.AnswerModeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerModeId].ToString().Trim(); //答案模式Id
objvUserAnswerResultEN.QuestionScore = objRow[convUserAnswerResult.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convUserAnswerResult.QuestionScore].ToString().Trim()); //题目得分
objvUserAnswerResultEN.QuestionnaireSetId = objRow[convUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResultEN.CourseId = objRow[convUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objvUserAnswerResultEN.CourseName = objRow[convUserAnswerResult.CourseName] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseName].ToString().Trim(); //课程名称
objvUserAnswerResultEN.CourseExamPaperId = objRow[convUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvUserAnswerResultEN.AnswerOptionId = objRow[convUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objvUserAnswerResultEN.OptionName = objRow[convUserAnswerResult.OptionName] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionName].ToString().Trim(); //选项名称
objvUserAnswerResultEN.OptionIndex = objRow[convUserAnswerResult.OptionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.OptionIndex].ToString().Trim()); //选项序号
objvUserAnswerResultEN.OptionTitle = objRow[convUserAnswerResult.OptionTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionTitle].ToString().Trim(); //选项标题
objvUserAnswerResultEN.BatchId = objRow[convUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[convUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objvUserAnswerResultEN.UserId = objRow[convUserAnswerResult.UserId] == DBNull.Value ? null : objRow[convUserAnswerResult.UserId].ToString().Trim(); //用户ID
objvUserAnswerResultEN.UserName = objRow[convUserAnswerResult.UserName] == DBNull.Value ? null : objRow[convUserAnswerResult.UserName].ToString().Trim(); //用户名
objvUserAnswerResultEN.AnswerText = objRow[convUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objvUserAnswerResultEN.AnswerDate = objRow[convUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objvUserAnswerResultEN.AnswerTime = objRow[convUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objvUserAnswerResultEN.AnswerIP = objRow[convUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objvUserAnswerResultEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objvUserAnswerResultEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objvUserAnswerResultEN.IdSchool = objRow[convUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[convUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objvUserAnswerResultEN.School = objRow[convUserAnswerResult.School] == DBNull.Value ? null : objRow[convUserAnswerResult.School].ToString().Trim(); //School
objvUserAnswerResultEN.AnswerMode = objRow[convUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objvUserAnswerResultEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objvUserAnswerResultEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objvUserAnswerResultEN.Score = objRow[convUserAnswerResult.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convUserAnswerResult.Score].ToString().Trim()); //得分
objvUserAnswerResultEN.MarkTime = objRow[convUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objvUserAnswerResultEN.MarkerId = objRow[convUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objvUserAnswerResultEN.Comment = objRow[convUserAnswerResult.Comment] == DBNull.Value ? null : objRow[convUserAnswerResult.Comment].ToString().Trim(); //批注
objvUserAnswerResultEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvUserAnswerResultEN.UpdDate = objRow[convUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objvUserAnswerResultEN.UpdUser = objRow[convUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objvUserAnswerResultEN.Memo = objRow[convUserAnswerResult.Memo] == DBNull.Value ? null : objRow[convUserAnswerResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserAnswerResultEN.MinId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserAnswerResultEN);
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
public static List<clsvUserAnswerResultEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvUserAnswerResultEN> arrObjLst = new List<clsvUserAnswerResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserAnswerResultEN objvUserAnswerResultEN = new clsvUserAnswerResultEN();
try
{
objvUserAnswerResultEN.MinId = Int32.Parse(objRow[convUserAnswerResult.MinId].ToString().Trim()); //MinId
objvUserAnswerResultEN.QuestionId = objRow[convUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResultEN.QuestionIndex = objRow[convUserAnswerResult.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.QuestionIndex].ToString().Trim()); //题目序号
objvUserAnswerResultEN.QuestionName = objRow[convUserAnswerResult.QuestionName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionName].ToString().Trim(); //题目名称
objvUserAnswerResultEN.QuestionNo = objRow[convUserAnswerResult.QuestionNo] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionNo].ToString().Trim(); //题目编号
objvUserAnswerResultEN.QuestionTypeId = objRow[convUserAnswerResult.QuestionTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeId].ToString().Trim(); //题目类型Id
objvUserAnswerResultEN.QuestionTypeName = objRow[convUserAnswerResult.QuestionTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeName].ToString().Trim(); //题目类型名
objvUserAnswerResultEN.AnswerTypeId = objRow[convUserAnswerResult.AnswerTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeId].ToString().Trim(); //答案类型ID
objvUserAnswerResultEN.AnswerTypeName = objRow[convUserAnswerResult.AnswerTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeName].ToString().Trim(); //答案类型名
objvUserAnswerResultEN.GridTitle = objRow[convUserAnswerResult.GridTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.GridTitle].ToString().Trim(); //表格标题
objvUserAnswerResultEN.AnswerModeId = objRow[convUserAnswerResult.AnswerModeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerModeId].ToString().Trim(); //答案模式Id
objvUserAnswerResultEN.QuestionScore = objRow[convUserAnswerResult.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convUserAnswerResult.QuestionScore].ToString().Trim()); //题目得分
objvUserAnswerResultEN.QuestionnaireSetId = objRow[convUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResultEN.CourseId = objRow[convUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objvUserAnswerResultEN.CourseName = objRow[convUserAnswerResult.CourseName] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseName].ToString().Trim(); //课程名称
objvUserAnswerResultEN.CourseExamPaperId = objRow[convUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvUserAnswerResultEN.AnswerOptionId = objRow[convUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objvUserAnswerResultEN.OptionName = objRow[convUserAnswerResult.OptionName] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionName].ToString().Trim(); //选项名称
objvUserAnswerResultEN.OptionIndex = objRow[convUserAnswerResult.OptionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.OptionIndex].ToString().Trim()); //选项序号
objvUserAnswerResultEN.OptionTitle = objRow[convUserAnswerResult.OptionTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionTitle].ToString().Trim(); //选项标题
objvUserAnswerResultEN.BatchId = objRow[convUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[convUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objvUserAnswerResultEN.UserId = objRow[convUserAnswerResult.UserId] == DBNull.Value ? null : objRow[convUserAnswerResult.UserId].ToString().Trim(); //用户ID
objvUserAnswerResultEN.UserName = objRow[convUserAnswerResult.UserName] == DBNull.Value ? null : objRow[convUserAnswerResult.UserName].ToString().Trim(); //用户名
objvUserAnswerResultEN.AnswerText = objRow[convUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objvUserAnswerResultEN.AnswerDate = objRow[convUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objvUserAnswerResultEN.AnswerTime = objRow[convUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objvUserAnswerResultEN.AnswerIP = objRow[convUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objvUserAnswerResultEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objvUserAnswerResultEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objvUserAnswerResultEN.IdSchool = objRow[convUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[convUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objvUserAnswerResultEN.School = objRow[convUserAnswerResult.School] == DBNull.Value ? null : objRow[convUserAnswerResult.School].ToString().Trim(); //School
objvUserAnswerResultEN.AnswerMode = objRow[convUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objvUserAnswerResultEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objvUserAnswerResultEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objvUserAnswerResultEN.Score = objRow[convUserAnswerResult.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convUserAnswerResult.Score].ToString().Trim()); //得分
objvUserAnswerResultEN.MarkTime = objRow[convUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objvUserAnswerResultEN.MarkerId = objRow[convUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objvUserAnswerResultEN.Comment = objRow[convUserAnswerResult.Comment] == DBNull.Value ? null : objRow[convUserAnswerResult.Comment].ToString().Trim(); //批注
objvUserAnswerResultEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvUserAnswerResultEN.UpdDate = objRow[convUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objvUserAnswerResultEN.UpdUser = objRow[convUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objvUserAnswerResultEN.Memo = objRow[convUserAnswerResult.Memo] == DBNull.Value ? null : objRow[convUserAnswerResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserAnswerResultEN.MinId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserAnswerResultEN);
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
List<clsvUserAnswerResultEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvUserAnswerResultEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserAnswerResultEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvUserAnswerResultEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvUserAnswerResultEN> arrObjLst = new List<clsvUserAnswerResultEN>(); 
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
	clsvUserAnswerResultEN objvUserAnswerResultEN = new clsvUserAnswerResultEN();
try
{
objvUserAnswerResultEN.MinId = Int32.Parse(objRow[convUserAnswerResult.MinId].ToString().Trim()); //MinId
objvUserAnswerResultEN.QuestionId = objRow[convUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResultEN.QuestionIndex = objRow[convUserAnswerResult.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.QuestionIndex].ToString().Trim()); //题目序号
objvUserAnswerResultEN.QuestionName = objRow[convUserAnswerResult.QuestionName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionName].ToString().Trim(); //题目名称
objvUserAnswerResultEN.QuestionNo = objRow[convUserAnswerResult.QuestionNo] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionNo].ToString().Trim(); //题目编号
objvUserAnswerResultEN.QuestionTypeId = objRow[convUserAnswerResult.QuestionTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeId].ToString().Trim(); //题目类型Id
objvUserAnswerResultEN.QuestionTypeName = objRow[convUserAnswerResult.QuestionTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeName].ToString().Trim(); //题目类型名
objvUserAnswerResultEN.AnswerTypeId = objRow[convUserAnswerResult.AnswerTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeId].ToString().Trim(); //答案类型ID
objvUserAnswerResultEN.AnswerTypeName = objRow[convUserAnswerResult.AnswerTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeName].ToString().Trim(); //答案类型名
objvUserAnswerResultEN.GridTitle = objRow[convUserAnswerResult.GridTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.GridTitle].ToString().Trim(); //表格标题
objvUserAnswerResultEN.AnswerModeId = objRow[convUserAnswerResult.AnswerModeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerModeId].ToString().Trim(); //答案模式Id
objvUserAnswerResultEN.QuestionScore = objRow[convUserAnswerResult.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convUserAnswerResult.QuestionScore].ToString().Trim()); //题目得分
objvUserAnswerResultEN.QuestionnaireSetId = objRow[convUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResultEN.CourseId = objRow[convUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objvUserAnswerResultEN.CourseName = objRow[convUserAnswerResult.CourseName] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseName].ToString().Trim(); //课程名称
objvUserAnswerResultEN.CourseExamPaperId = objRow[convUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvUserAnswerResultEN.AnswerOptionId = objRow[convUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objvUserAnswerResultEN.OptionName = objRow[convUserAnswerResult.OptionName] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionName].ToString().Trim(); //选项名称
objvUserAnswerResultEN.OptionIndex = objRow[convUserAnswerResult.OptionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.OptionIndex].ToString().Trim()); //选项序号
objvUserAnswerResultEN.OptionTitle = objRow[convUserAnswerResult.OptionTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionTitle].ToString().Trim(); //选项标题
objvUserAnswerResultEN.BatchId = objRow[convUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[convUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objvUserAnswerResultEN.UserId = objRow[convUserAnswerResult.UserId] == DBNull.Value ? null : objRow[convUserAnswerResult.UserId].ToString().Trim(); //用户ID
objvUserAnswerResultEN.UserName = objRow[convUserAnswerResult.UserName] == DBNull.Value ? null : objRow[convUserAnswerResult.UserName].ToString().Trim(); //用户名
objvUserAnswerResultEN.AnswerText = objRow[convUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objvUserAnswerResultEN.AnswerDate = objRow[convUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objvUserAnswerResultEN.AnswerTime = objRow[convUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objvUserAnswerResultEN.AnswerIP = objRow[convUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objvUserAnswerResultEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objvUserAnswerResultEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objvUserAnswerResultEN.IdSchool = objRow[convUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[convUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objvUserAnswerResultEN.School = objRow[convUserAnswerResult.School] == DBNull.Value ? null : objRow[convUserAnswerResult.School].ToString().Trim(); //School
objvUserAnswerResultEN.AnswerMode = objRow[convUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objvUserAnswerResultEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objvUserAnswerResultEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objvUserAnswerResultEN.Score = objRow[convUserAnswerResult.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convUserAnswerResult.Score].ToString().Trim()); //得分
objvUserAnswerResultEN.MarkTime = objRow[convUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objvUserAnswerResultEN.MarkerId = objRow[convUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objvUserAnswerResultEN.Comment = objRow[convUserAnswerResult.Comment] == DBNull.Value ? null : objRow[convUserAnswerResult.Comment].ToString().Trim(); //批注
objvUserAnswerResultEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvUserAnswerResultEN.UpdDate = objRow[convUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objvUserAnswerResultEN.UpdUser = objRow[convUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objvUserAnswerResultEN.Memo = objRow[convUserAnswerResult.Memo] == DBNull.Value ? null : objRow[convUserAnswerResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserAnswerResultEN.MinId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserAnswerResultEN);
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
public static List<clsvUserAnswerResultEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvUserAnswerResultEN> arrObjLst = new List<clsvUserAnswerResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserAnswerResultEN objvUserAnswerResultEN = new clsvUserAnswerResultEN();
try
{
objvUserAnswerResultEN.MinId = Int32.Parse(objRow[convUserAnswerResult.MinId].ToString().Trim()); //MinId
objvUserAnswerResultEN.QuestionId = objRow[convUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResultEN.QuestionIndex = objRow[convUserAnswerResult.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.QuestionIndex].ToString().Trim()); //题目序号
objvUserAnswerResultEN.QuestionName = objRow[convUserAnswerResult.QuestionName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionName].ToString().Trim(); //题目名称
objvUserAnswerResultEN.QuestionNo = objRow[convUserAnswerResult.QuestionNo] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionNo].ToString().Trim(); //题目编号
objvUserAnswerResultEN.QuestionTypeId = objRow[convUserAnswerResult.QuestionTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeId].ToString().Trim(); //题目类型Id
objvUserAnswerResultEN.QuestionTypeName = objRow[convUserAnswerResult.QuestionTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeName].ToString().Trim(); //题目类型名
objvUserAnswerResultEN.AnswerTypeId = objRow[convUserAnswerResult.AnswerTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeId].ToString().Trim(); //答案类型ID
objvUserAnswerResultEN.AnswerTypeName = objRow[convUserAnswerResult.AnswerTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeName].ToString().Trim(); //答案类型名
objvUserAnswerResultEN.GridTitle = objRow[convUserAnswerResult.GridTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.GridTitle].ToString().Trim(); //表格标题
objvUserAnswerResultEN.AnswerModeId = objRow[convUserAnswerResult.AnswerModeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerModeId].ToString().Trim(); //答案模式Id
objvUserAnswerResultEN.QuestionScore = objRow[convUserAnswerResult.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convUserAnswerResult.QuestionScore].ToString().Trim()); //题目得分
objvUserAnswerResultEN.QuestionnaireSetId = objRow[convUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResultEN.CourseId = objRow[convUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objvUserAnswerResultEN.CourseName = objRow[convUserAnswerResult.CourseName] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseName].ToString().Trim(); //课程名称
objvUserAnswerResultEN.CourseExamPaperId = objRow[convUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvUserAnswerResultEN.AnswerOptionId = objRow[convUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objvUserAnswerResultEN.OptionName = objRow[convUserAnswerResult.OptionName] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionName].ToString().Trim(); //选项名称
objvUserAnswerResultEN.OptionIndex = objRow[convUserAnswerResult.OptionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.OptionIndex].ToString().Trim()); //选项序号
objvUserAnswerResultEN.OptionTitle = objRow[convUserAnswerResult.OptionTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionTitle].ToString().Trim(); //选项标题
objvUserAnswerResultEN.BatchId = objRow[convUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[convUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objvUserAnswerResultEN.UserId = objRow[convUserAnswerResult.UserId] == DBNull.Value ? null : objRow[convUserAnswerResult.UserId].ToString().Trim(); //用户ID
objvUserAnswerResultEN.UserName = objRow[convUserAnswerResult.UserName] == DBNull.Value ? null : objRow[convUserAnswerResult.UserName].ToString().Trim(); //用户名
objvUserAnswerResultEN.AnswerText = objRow[convUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objvUserAnswerResultEN.AnswerDate = objRow[convUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objvUserAnswerResultEN.AnswerTime = objRow[convUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objvUserAnswerResultEN.AnswerIP = objRow[convUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objvUserAnswerResultEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objvUserAnswerResultEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objvUserAnswerResultEN.IdSchool = objRow[convUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[convUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objvUserAnswerResultEN.School = objRow[convUserAnswerResult.School] == DBNull.Value ? null : objRow[convUserAnswerResult.School].ToString().Trim(); //School
objvUserAnswerResultEN.AnswerMode = objRow[convUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objvUserAnswerResultEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objvUserAnswerResultEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objvUserAnswerResultEN.Score = objRow[convUserAnswerResult.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convUserAnswerResult.Score].ToString().Trim()); //得分
objvUserAnswerResultEN.MarkTime = objRow[convUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objvUserAnswerResultEN.MarkerId = objRow[convUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objvUserAnswerResultEN.Comment = objRow[convUserAnswerResult.Comment] == DBNull.Value ? null : objRow[convUserAnswerResult.Comment].ToString().Trim(); //批注
objvUserAnswerResultEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvUserAnswerResultEN.UpdDate = objRow[convUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objvUserAnswerResultEN.UpdUser = objRow[convUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objvUserAnswerResultEN.Memo = objRow[convUserAnswerResult.Memo] == DBNull.Value ? null : objRow[convUserAnswerResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserAnswerResultEN.MinId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserAnswerResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvUserAnswerResultEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvUserAnswerResultEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvUserAnswerResultEN> arrObjLst = new List<clsvUserAnswerResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserAnswerResultEN objvUserAnswerResultEN = new clsvUserAnswerResultEN();
try
{
objvUserAnswerResultEN.MinId = Int32.Parse(objRow[convUserAnswerResult.MinId].ToString().Trim()); //MinId
objvUserAnswerResultEN.QuestionId = objRow[convUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResultEN.QuestionIndex = objRow[convUserAnswerResult.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.QuestionIndex].ToString().Trim()); //题目序号
objvUserAnswerResultEN.QuestionName = objRow[convUserAnswerResult.QuestionName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionName].ToString().Trim(); //题目名称
objvUserAnswerResultEN.QuestionNo = objRow[convUserAnswerResult.QuestionNo] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionNo].ToString().Trim(); //题目编号
objvUserAnswerResultEN.QuestionTypeId = objRow[convUserAnswerResult.QuestionTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeId].ToString().Trim(); //题目类型Id
objvUserAnswerResultEN.QuestionTypeName = objRow[convUserAnswerResult.QuestionTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeName].ToString().Trim(); //题目类型名
objvUserAnswerResultEN.AnswerTypeId = objRow[convUserAnswerResult.AnswerTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeId].ToString().Trim(); //答案类型ID
objvUserAnswerResultEN.AnswerTypeName = objRow[convUserAnswerResult.AnswerTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeName].ToString().Trim(); //答案类型名
objvUserAnswerResultEN.GridTitle = objRow[convUserAnswerResult.GridTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.GridTitle].ToString().Trim(); //表格标题
objvUserAnswerResultEN.AnswerModeId = objRow[convUserAnswerResult.AnswerModeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerModeId].ToString().Trim(); //答案模式Id
objvUserAnswerResultEN.QuestionScore = objRow[convUserAnswerResult.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convUserAnswerResult.QuestionScore].ToString().Trim()); //题目得分
objvUserAnswerResultEN.QuestionnaireSetId = objRow[convUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResultEN.CourseId = objRow[convUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objvUserAnswerResultEN.CourseName = objRow[convUserAnswerResult.CourseName] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseName].ToString().Trim(); //课程名称
objvUserAnswerResultEN.CourseExamPaperId = objRow[convUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvUserAnswerResultEN.AnswerOptionId = objRow[convUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objvUserAnswerResultEN.OptionName = objRow[convUserAnswerResult.OptionName] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionName].ToString().Trim(); //选项名称
objvUserAnswerResultEN.OptionIndex = objRow[convUserAnswerResult.OptionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.OptionIndex].ToString().Trim()); //选项序号
objvUserAnswerResultEN.OptionTitle = objRow[convUserAnswerResult.OptionTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionTitle].ToString().Trim(); //选项标题
objvUserAnswerResultEN.BatchId = objRow[convUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[convUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objvUserAnswerResultEN.UserId = objRow[convUserAnswerResult.UserId] == DBNull.Value ? null : objRow[convUserAnswerResult.UserId].ToString().Trim(); //用户ID
objvUserAnswerResultEN.UserName = objRow[convUserAnswerResult.UserName] == DBNull.Value ? null : objRow[convUserAnswerResult.UserName].ToString().Trim(); //用户名
objvUserAnswerResultEN.AnswerText = objRow[convUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objvUserAnswerResultEN.AnswerDate = objRow[convUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objvUserAnswerResultEN.AnswerTime = objRow[convUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objvUserAnswerResultEN.AnswerIP = objRow[convUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objvUserAnswerResultEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objvUserAnswerResultEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objvUserAnswerResultEN.IdSchool = objRow[convUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[convUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objvUserAnswerResultEN.School = objRow[convUserAnswerResult.School] == DBNull.Value ? null : objRow[convUserAnswerResult.School].ToString().Trim(); //School
objvUserAnswerResultEN.AnswerMode = objRow[convUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objvUserAnswerResultEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objvUserAnswerResultEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objvUserAnswerResultEN.Score = objRow[convUserAnswerResult.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convUserAnswerResult.Score].ToString().Trim()); //得分
objvUserAnswerResultEN.MarkTime = objRow[convUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objvUserAnswerResultEN.MarkerId = objRow[convUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objvUserAnswerResultEN.Comment = objRow[convUserAnswerResult.Comment] == DBNull.Value ? null : objRow[convUserAnswerResult.Comment].ToString().Trim(); //批注
objvUserAnswerResultEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvUserAnswerResultEN.UpdDate = objRow[convUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objvUserAnswerResultEN.UpdUser = objRow[convUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objvUserAnswerResultEN.Memo = objRow[convUserAnswerResult.Memo] == DBNull.Value ? null : objRow[convUserAnswerResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserAnswerResultEN.MinId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserAnswerResultEN);
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
public static List<clsvUserAnswerResultEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvUserAnswerResultEN> arrObjLst = new List<clsvUserAnswerResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserAnswerResultEN objvUserAnswerResultEN = new clsvUserAnswerResultEN();
try
{
objvUserAnswerResultEN.MinId = Int32.Parse(objRow[convUserAnswerResult.MinId].ToString().Trim()); //MinId
objvUserAnswerResultEN.QuestionId = objRow[convUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResultEN.QuestionIndex = objRow[convUserAnswerResult.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.QuestionIndex].ToString().Trim()); //题目序号
objvUserAnswerResultEN.QuestionName = objRow[convUserAnswerResult.QuestionName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionName].ToString().Trim(); //题目名称
objvUserAnswerResultEN.QuestionNo = objRow[convUserAnswerResult.QuestionNo] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionNo].ToString().Trim(); //题目编号
objvUserAnswerResultEN.QuestionTypeId = objRow[convUserAnswerResult.QuestionTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeId].ToString().Trim(); //题目类型Id
objvUserAnswerResultEN.QuestionTypeName = objRow[convUserAnswerResult.QuestionTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeName].ToString().Trim(); //题目类型名
objvUserAnswerResultEN.AnswerTypeId = objRow[convUserAnswerResult.AnswerTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeId].ToString().Trim(); //答案类型ID
objvUserAnswerResultEN.AnswerTypeName = objRow[convUserAnswerResult.AnswerTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeName].ToString().Trim(); //答案类型名
objvUserAnswerResultEN.GridTitle = objRow[convUserAnswerResult.GridTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.GridTitle].ToString().Trim(); //表格标题
objvUserAnswerResultEN.AnswerModeId = objRow[convUserAnswerResult.AnswerModeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerModeId].ToString().Trim(); //答案模式Id
objvUserAnswerResultEN.QuestionScore = objRow[convUserAnswerResult.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convUserAnswerResult.QuestionScore].ToString().Trim()); //题目得分
objvUserAnswerResultEN.QuestionnaireSetId = objRow[convUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResultEN.CourseId = objRow[convUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objvUserAnswerResultEN.CourseName = objRow[convUserAnswerResult.CourseName] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseName].ToString().Trim(); //课程名称
objvUserAnswerResultEN.CourseExamPaperId = objRow[convUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvUserAnswerResultEN.AnswerOptionId = objRow[convUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objvUserAnswerResultEN.OptionName = objRow[convUserAnswerResult.OptionName] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionName].ToString().Trim(); //选项名称
objvUserAnswerResultEN.OptionIndex = objRow[convUserAnswerResult.OptionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.OptionIndex].ToString().Trim()); //选项序号
objvUserAnswerResultEN.OptionTitle = objRow[convUserAnswerResult.OptionTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionTitle].ToString().Trim(); //选项标题
objvUserAnswerResultEN.BatchId = objRow[convUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[convUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objvUserAnswerResultEN.UserId = objRow[convUserAnswerResult.UserId] == DBNull.Value ? null : objRow[convUserAnswerResult.UserId].ToString().Trim(); //用户ID
objvUserAnswerResultEN.UserName = objRow[convUserAnswerResult.UserName] == DBNull.Value ? null : objRow[convUserAnswerResult.UserName].ToString().Trim(); //用户名
objvUserAnswerResultEN.AnswerText = objRow[convUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objvUserAnswerResultEN.AnswerDate = objRow[convUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objvUserAnswerResultEN.AnswerTime = objRow[convUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objvUserAnswerResultEN.AnswerIP = objRow[convUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objvUserAnswerResultEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objvUserAnswerResultEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objvUserAnswerResultEN.IdSchool = objRow[convUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[convUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objvUserAnswerResultEN.School = objRow[convUserAnswerResult.School] == DBNull.Value ? null : objRow[convUserAnswerResult.School].ToString().Trim(); //School
objvUserAnswerResultEN.AnswerMode = objRow[convUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objvUserAnswerResultEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objvUserAnswerResultEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objvUserAnswerResultEN.Score = objRow[convUserAnswerResult.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convUserAnswerResult.Score].ToString().Trim()); //得分
objvUserAnswerResultEN.MarkTime = objRow[convUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objvUserAnswerResultEN.MarkerId = objRow[convUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objvUserAnswerResultEN.Comment = objRow[convUserAnswerResult.Comment] == DBNull.Value ? null : objRow[convUserAnswerResult.Comment].ToString().Trim(); //批注
objvUserAnswerResultEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvUserAnswerResultEN.UpdDate = objRow[convUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objvUserAnswerResultEN.UpdUser = objRow[convUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objvUserAnswerResultEN.Memo = objRow[convUserAnswerResult.Memo] == DBNull.Value ? null : objRow[convUserAnswerResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserAnswerResultEN.MinId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserAnswerResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserAnswerResultEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvUserAnswerResultEN> arrObjLst = new List<clsvUserAnswerResultEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserAnswerResultEN objvUserAnswerResultEN = new clsvUserAnswerResultEN();
try
{
objvUserAnswerResultEN.MinId = Int32.Parse(objRow[convUserAnswerResult.MinId].ToString().Trim()); //MinId
objvUserAnswerResultEN.QuestionId = objRow[convUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResultEN.QuestionIndex = objRow[convUserAnswerResult.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.QuestionIndex].ToString().Trim()); //题目序号
objvUserAnswerResultEN.QuestionName = objRow[convUserAnswerResult.QuestionName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionName].ToString().Trim(); //题目名称
objvUserAnswerResultEN.QuestionNo = objRow[convUserAnswerResult.QuestionNo] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionNo].ToString().Trim(); //题目编号
objvUserAnswerResultEN.QuestionTypeId = objRow[convUserAnswerResult.QuestionTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeId].ToString().Trim(); //题目类型Id
objvUserAnswerResultEN.QuestionTypeName = objRow[convUserAnswerResult.QuestionTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeName].ToString().Trim(); //题目类型名
objvUserAnswerResultEN.AnswerTypeId = objRow[convUserAnswerResult.AnswerTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeId].ToString().Trim(); //答案类型ID
objvUserAnswerResultEN.AnswerTypeName = objRow[convUserAnswerResult.AnswerTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeName].ToString().Trim(); //答案类型名
objvUserAnswerResultEN.GridTitle = objRow[convUserAnswerResult.GridTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.GridTitle].ToString().Trim(); //表格标题
objvUserAnswerResultEN.AnswerModeId = objRow[convUserAnswerResult.AnswerModeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerModeId].ToString().Trim(); //答案模式Id
objvUserAnswerResultEN.QuestionScore = objRow[convUserAnswerResult.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convUserAnswerResult.QuestionScore].ToString().Trim()); //题目得分
objvUserAnswerResultEN.QuestionnaireSetId = objRow[convUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResultEN.CourseId = objRow[convUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objvUserAnswerResultEN.CourseName = objRow[convUserAnswerResult.CourseName] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseName].ToString().Trim(); //课程名称
objvUserAnswerResultEN.CourseExamPaperId = objRow[convUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvUserAnswerResultEN.AnswerOptionId = objRow[convUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objvUserAnswerResultEN.OptionName = objRow[convUserAnswerResult.OptionName] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionName].ToString().Trim(); //选项名称
objvUserAnswerResultEN.OptionIndex = objRow[convUserAnswerResult.OptionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.OptionIndex].ToString().Trim()); //选项序号
objvUserAnswerResultEN.OptionTitle = objRow[convUserAnswerResult.OptionTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionTitle].ToString().Trim(); //选项标题
objvUserAnswerResultEN.BatchId = objRow[convUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[convUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objvUserAnswerResultEN.UserId = objRow[convUserAnswerResult.UserId] == DBNull.Value ? null : objRow[convUserAnswerResult.UserId].ToString().Trim(); //用户ID
objvUserAnswerResultEN.UserName = objRow[convUserAnswerResult.UserName] == DBNull.Value ? null : objRow[convUserAnswerResult.UserName].ToString().Trim(); //用户名
objvUserAnswerResultEN.AnswerText = objRow[convUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objvUserAnswerResultEN.AnswerDate = objRow[convUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objvUserAnswerResultEN.AnswerTime = objRow[convUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objvUserAnswerResultEN.AnswerIP = objRow[convUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objvUserAnswerResultEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objvUserAnswerResultEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objvUserAnswerResultEN.IdSchool = objRow[convUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[convUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objvUserAnswerResultEN.School = objRow[convUserAnswerResult.School] == DBNull.Value ? null : objRow[convUserAnswerResult.School].ToString().Trim(); //School
objvUserAnswerResultEN.AnswerMode = objRow[convUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objvUserAnswerResultEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objvUserAnswerResultEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objvUserAnswerResultEN.Score = objRow[convUserAnswerResult.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convUserAnswerResult.Score].ToString().Trim()); //得分
objvUserAnswerResultEN.MarkTime = objRow[convUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objvUserAnswerResultEN.MarkerId = objRow[convUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objvUserAnswerResultEN.Comment = objRow[convUserAnswerResult.Comment] == DBNull.Value ? null : objRow[convUserAnswerResult.Comment].ToString().Trim(); //批注
objvUserAnswerResultEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvUserAnswerResultEN.UpdDate = objRow[convUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objvUserAnswerResultEN.UpdUser = objRow[convUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objvUserAnswerResultEN.Memo = objRow[convUserAnswerResult.Memo] == DBNull.Value ? null : objRow[convUserAnswerResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserAnswerResultEN.MinId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserAnswerResultEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvUserAnswerResult(ref clsvUserAnswerResultEN objvUserAnswerResultEN)
{
bool bolResult = vUserAnswerResultDA.GetvUserAnswerResult(ref objvUserAnswerResultEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngMinId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserAnswerResultEN GetObjByMinId(long lngMinId)
{
clsvUserAnswerResultEN objvUserAnswerResultEN = vUserAnswerResultDA.GetObjByMinId(lngMinId);
return objvUserAnswerResultEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvUserAnswerResultEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvUserAnswerResultEN objvUserAnswerResultEN = vUserAnswerResultDA.GetFirstObj(strWhereCond);
 return objvUserAnswerResultEN;
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
public static clsvUserAnswerResultEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvUserAnswerResultEN objvUserAnswerResultEN = vUserAnswerResultDA.GetObjByDataRow(objRow);
 return objvUserAnswerResultEN;
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
public static clsvUserAnswerResultEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvUserAnswerResultEN objvUserAnswerResultEN = vUserAnswerResultDA.GetObjByDataRow(objRow);
 return objvUserAnswerResultEN;
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
 /// <param name = "lngMinId">所给的关键字</param>
 /// <param name = "lstvUserAnswerResultObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUserAnswerResultEN GetObjByMinIdFromList(long lngMinId, List<clsvUserAnswerResultEN> lstvUserAnswerResultObjLst)
{
foreach (clsvUserAnswerResultEN objvUserAnswerResultEN in lstvUserAnswerResultObjLst)
{
if (objvUserAnswerResultEN.MinId == lngMinId)
{
return objvUserAnswerResultEN;
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
 long lngMinId;
 try
 {
 lngMinId = new clsvUserAnswerResultDA().GetFirstID(strWhereCond);
 return lngMinId;
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
 arrList = vUserAnswerResultDA.GetID(strWhereCond);
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
bool bolIsExist = vUserAnswerResultDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngMinId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngMinId)
{
//检测记录是否存在
bool bolIsExist = vUserAnswerResultDA.IsExist(lngMinId);
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
 bolIsExist = clsvUserAnswerResultDA.IsExistTable();
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
 bolIsExist = vUserAnswerResultDA.IsExistTable(strTabName);
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
 /// <param name = "objvUserAnswerResultENS">源对象</param>
 /// <param name = "objvUserAnswerResultENT">目标对象</param>
 public static void CopyTo(clsvUserAnswerResultEN objvUserAnswerResultENS, clsvUserAnswerResultEN objvUserAnswerResultENT)
{
try
{
objvUserAnswerResultENT.MinId = objvUserAnswerResultENS.MinId; //MinId
objvUserAnswerResultENT.QuestionId = objvUserAnswerResultENS.QuestionId; //题目Id
objvUserAnswerResultENT.QuestionIndex = objvUserAnswerResultENS.QuestionIndex; //题目序号
objvUserAnswerResultENT.QuestionName = objvUserAnswerResultENS.QuestionName; //题目名称
objvUserAnswerResultENT.QuestionNo = objvUserAnswerResultENS.QuestionNo; //题目编号
objvUserAnswerResultENT.QuestionTypeId = objvUserAnswerResultENS.QuestionTypeId; //题目类型Id
objvUserAnswerResultENT.QuestionTypeName = objvUserAnswerResultENS.QuestionTypeName; //题目类型名
objvUserAnswerResultENT.AnswerTypeId = objvUserAnswerResultENS.AnswerTypeId; //答案类型ID
objvUserAnswerResultENT.AnswerTypeName = objvUserAnswerResultENS.AnswerTypeName; //答案类型名
objvUserAnswerResultENT.GridTitle = objvUserAnswerResultENS.GridTitle; //表格标题
objvUserAnswerResultENT.AnswerModeId = objvUserAnswerResultENS.AnswerModeId; //答案模式Id
objvUserAnswerResultENT.QuestionScore = objvUserAnswerResultENS.QuestionScore; //题目得分
objvUserAnswerResultENT.QuestionnaireSetId = objvUserAnswerResultENS.QuestionnaireSetId; //问卷集ID
objvUserAnswerResultENT.CourseId = objvUserAnswerResultENS.CourseId; //课程Id
objvUserAnswerResultENT.CourseName = objvUserAnswerResultENS.CourseName; //课程名称
objvUserAnswerResultENT.CourseExamPaperId = objvUserAnswerResultENS.CourseExamPaperId; //考卷流水号
objvUserAnswerResultENT.AnswerOptionId = objvUserAnswerResultENS.AnswerOptionId; //回答选项Id
objvUserAnswerResultENT.OptionName = objvUserAnswerResultENS.OptionName; //选项名称
objvUserAnswerResultENT.OptionIndex = objvUserAnswerResultENS.OptionIndex; //选项序号
objvUserAnswerResultENT.OptionTitle = objvUserAnswerResultENS.OptionTitle; //选项标题
objvUserAnswerResultENT.BatchId = objvUserAnswerResultENS.BatchId; //批次ID
objvUserAnswerResultENT.UserId = objvUserAnswerResultENS.UserId; //用户ID
objvUserAnswerResultENT.UserName = objvUserAnswerResultENS.UserName; //用户名
objvUserAnswerResultENT.AnswerText = objvUserAnswerResultENS.AnswerText; //回答文本
objvUserAnswerResultENT.AnswerDate = objvUserAnswerResultENS.AnswerDate; //回答日期
objvUserAnswerResultENT.AnswerTime = objvUserAnswerResultENS.AnswerTime; //回答时间
objvUserAnswerResultENT.AnswerIP = objvUserAnswerResultENS.AnswerIP; //回答IP
objvUserAnswerResultENT.IsAccess = objvUserAnswerResultENS.IsAccess; //IsAccess
objvUserAnswerResultENT.IsAccessC = objvUserAnswerResultENS.IsAccessC; //IsAccessC
objvUserAnswerResultENT.IdSchool = objvUserAnswerResultENS.IdSchool; //学校流水号
objvUserAnswerResultENT.School = objvUserAnswerResultENS.School; //School
objvUserAnswerResultENT.AnswerMode = objvUserAnswerResultENS.AnswerMode; //AnswerMode
objvUserAnswerResultENT.IsMarking = objvUserAnswerResultENS.IsMarking; //是否批阅
objvUserAnswerResultENT.IsRight = objvUserAnswerResultENS.IsRight; //是否正确
objvUserAnswerResultENT.Score = objvUserAnswerResultENS.Score; //得分
objvUserAnswerResultENT.MarkTime = objvUserAnswerResultENS.MarkTime; //批改时间
objvUserAnswerResultENT.MarkerId = objvUserAnswerResultENS.MarkerId; //打分者
objvUserAnswerResultENT.Comment = objvUserAnswerResultENS.Comment; //批注
objvUserAnswerResultENT.IsAccessKnowledge = objvUserAnswerResultENS.IsAccessKnowledge; //是否处理知识点
objvUserAnswerResultENT.UpdDate = objvUserAnswerResultENS.UpdDate; //修改日期
objvUserAnswerResultENT.UpdUser = objvUserAnswerResultENS.UpdUser; //修改人
objvUserAnswerResultENT.Memo = objvUserAnswerResultENS.Memo; //备注
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
 /// <param name = "objvUserAnswerResultEN">源简化对象</param>
 public static void SetUpdFlag(clsvUserAnswerResultEN objvUserAnswerResultEN)
{
try
{
objvUserAnswerResultEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvUserAnswerResultEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convUserAnswerResult.MinId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.MinId = objvUserAnswerResultEN.MinId; //MinId
}
if (arrFldSet.Contains(convUserAnswerResult.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.QuestionId = objvUserAnswerResultEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(convUserAnswerResult.QuestionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.QuestionIndex = objvUserAnswerResultEN.QuestionIndex; //题目序号
}
if (arrFldSet.Contains(convUserAnswerResult.QuestionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.QuestionName = objvUserAnswerResultEN.QuestionName == "[null]" ? null :  objvUserAnswerResultEN.QuestionName; //题目名称
}
if (arrFldSet.Contains(convUserAnswerResult.QuestionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.QuestionNo = objvUserAnswerResultEN.QuestionNo == "[null]" ? null :  objvUserAnswerResultEN.QuestionNo; //题目编号
}
if (arrFldSet.Contains(convUserAnswerResult.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.QuestionTypeId = objvUserAnswerResultEN.QuestionTypeId == "[null]" ? null :  objvUserAnswerResultEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(convUserAnswerResult.QuestionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.QuestionTypeName = objvUserAnswerResultEN.QuestionTypeName == "[null]" ? null :  objvUserAnswerResultEN.QuestionTypeName; //题目类型名
}
if (arrFldSet.Contains(convUserAnswerResult.AnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.AnswerTypeId = objvUserAnswerResultEN.AnswerTypeId == "[null]" ? null :  objvUserAnswerResultEN.AnswerTypeId; //答案类型ID
}
if (arrFldSet.Contains(convUserAnswerResult.AnswerTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.AnswerTypeName = objvUserAnswerResultEN.AnswerTypeName == "[null]" ? null :  objvUserAnswerResultEN.AnswerTypeName; //答案类型名
}
if (arrFldSet.Contains(convUserAnswerResult.GridTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.GridTitle = objvUserAnswerResultEN.GridTitle == "[null]" ? null :  objvUserAnswerResultEN.GridTitle; //表格标题
}
if (arrFldSet.Contains(convUserAnswerResult.AnswerModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.AnswerModeId = objvUserAnswerResultEN.AnswerModeId == "[null]" ? null :  objvUserAnswerResultEN.AnswerModeId; //答案模式Id
}
if (arrFldSet.Contains(convUserAnswerResult.QuestionScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.QuestionScore = objvUserAnswerResultEN.QuestionScore; //题目得分
}
if (arrFldSet.Contains(convUserAnswerResult.QuestionnaireSetId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.QuestionnaireSetId = objvUserAnswerResultEN.QuestionnaireSetId == "[null]" ? null :  objvUserAnswerResultEN.QuestionnaireSetId; //问卷集ID
}
if (arrFldSet.Contains(convUserAnswerResult.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.CourseId = objvUserAnswerResultEN.CourseId == "[null]" ? null :  objvUserAnswerResultEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convUserAnswerResult.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.CourseName = objvUserAnswerResultEN.CourseName == "[null]" ? null :  objvUserAnswerResultEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convUserAnswerResult.CourseExamPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.CourseExamPaperId = objvUserAnswerResultEN.CourseExamPaperId == "[null]" ? null :  objvUserAnswerResultEN.CourseExamPaperId; //考卷流水号
}
if (arrFldSet.Contains(convUserAnswerResult.AnswerOptionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.AnswerOptionId = objvUserAnswerResultEN.AnswerOptionId == "[null]" ? null :  objvUserAnswerResultEN.AnswerOptionId; //回答选项Id
}
if (arrFldSet.Contains(convUserAnswerResult.OptionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.OptionName = objvUserAnswerResultEN.OptionName == "[null]" ? null :  objvUserAnswerResultEN.OptionName; //选项名称
}
if (arrFldSet.Contains(convUserAnswerResult.OptionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.OptionIndex = objvUserAnswerResultEN.OptionIndex; //选项序号
}
if (arrFldSet.Contains(convUserAnswerResult.OptionTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.OptionTitle = objvUserAnswerResultEN.OptionTitle == "[null]" ? null :  objvUserAnswerResultEN.OptionTitle; //选项标题
}
if (arrFldSet.Contains(convUserAnswerResult.BatchId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.BatchId = objvUserAnswerResultEN.BatchId == "[null]" ? null :  objvUserAnswerResultEN.BatchId; //批次ID
}
if (arrFldSet.Contains(convUserAnswerResult.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.UserId = objvUserAnswerResultEN.UserId == "[null]" ? null :  objvUserAnswerResultEN.UserId; //用户ID
}
if (arrFldSet.Contains(convUserAnswerResult.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.UserName = objvUserAnswerResultEN.UserName == "[null]" ? null :  objvUserAnswerResultEN.UserName; //用户名
}
if (arrFldSet.Contains(convUserAnswerResult.AnswerText, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.AnswerText = objvUserAnswerResultEN.AnswerText == "[null]" ? null :  objvUserAnswerResultEN.AnswerText; //回答文本
}
if (arrFldSet.Contains(convUserAnswerResult.AnswerDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.AnswerDate = objvUserAnswerResultEN.AnswerDate == "[null]" ? null :  objvUserAnswerResultEN.AnswerDate; //回答日期
}
if (arrFldSet.Contains(convUserAnswerResult.AnswerTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.AnswerTime = objvUserAnswerResultEN.AnswerTime == "[null]" ? null :  objvUserAnswerResultEN.AnswerTime; //回答时间
}
if (arrFldSet.Contains(convUserAnswerResult.AnswerIP, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.AnswerIP = objvUserAnswerResultEN.AnswerIP == "[null]" ? null :  objvUserAnswerResultEN.AnswerIP; //回答IP
}
if (arrFldSet.Contains(convUserAnswerResult.IsAccess, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.IsAccess = objvUserAnswerResultEN.IsAccess; //IsAccess
}
if (arrFldSet.Contains(convUserAnswerResult.IsAccessC, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.IsAccessC = objvUserAnswerResultEN.IsAccessC; //IsAccessC
}
if (arrFldSet.Contains(convUserAnswerResult.IdSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.IdSchool = objvUserAnswerResultEN.IdSchool == "[null]" ? null :  objvUserAnswerResultEN.IdSchool; //学校流水号
}
if (arrFldSet.Contains(convUserAnswerResult.School, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.School = objvUserAnswerResultEN.School == "[null]" ? null :  objvUserAnswerResultEN.School; //School
}
if (arrFldSet.Contains(convUserAnswerResult.AnswerMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.AnswerMode = objvUserAnswerResultEN.AnswerMode; //AnswerMode
}
if (arrFldSet.Contains(convUserAnswerResult.IsMarking, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.IsMarking = objvUserAnswerResultEN.IsMarking; //是否批阅
}
if (arrFldSet.Contains(convUserAnswerResult.IsRight, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.IsRight = objvUserAnswerResultEN.IsRight; //是否正确
}
if (arrFldSet.Contains(convUserAnswerResult.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.Score = objvUserAnswerResultEN.Score; //得分
}
if (arrFldSet.Contains(convUserAnswerResult.MarkTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.MarkTime = objvUserAnswerResultEN.MarkTime == "[null]" ? null :  objvUserAnswerResultEN.MarkTime; //批改时间
}
if (arrFldSet.Contains(convUserAnswerResult.MarkerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.MarkerId = objvUserAnswerResultEN.MarkerId == "[null]" ? null :  objvUserAnswerResultEN.MarkerId; //打分者
}
if (arrFldSet.Contains(convUserAnswerResult.Comment, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.Comment = objvUserAnswerResultEN.Comment == "[null]" ? null :  objvUserAnswerResultEN.Comment; //批注
}
if (arrFldSet.Contains(convUserAnswerResult.IsAccessKnowledge, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.IsAccessKnowledge = objvUserAnswerResultEN.IsAccessKnowledge; //是否处理知识点
}
if (arrFldSet.Contains(convUserAnswerResult.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.UpdDate = objvUserAnswerResultEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convUserAnswerResult.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.UpdUser = objvUserAnswerResultEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convUserAnswerResult.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResultEN.Memo = objvUserAnswerResultEN.Memo == "[null]" ? null :  objvUserAnswerResultEN.Memo; //备注
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
 /// <param name = "objvUserAnswerResultEN">源简化对象</param>
 public static void AccessFldValueNull(clsvUserAnswerResultEN objvUserAnswerResultEN)
{
try
{
if (objvUserAnswerResultEN.QuestionName == "[null]") objvUserAnswerResultEN.QuestionName = null; //题目名称
if (objvUserAnswerResultEN.QuestionNo == "[null]") objvUserAnswerResultEN.QuestionNo = null; //题目编号
if (objvUserAnswerResultEN.QuestionTypeId == "[null]") objvUserAnswerResultEN.QuestionTypeId = null; //题目类型Id
if (objvUserAnswerResultEN.QuestionTypeName == "[null]") objvUserAnswerResultEN.QuestionTypeName = null; //题目类型名
if (objvUserAnswerResultEN.AnswerTypeId == "[null]") objvUserAnswerResultEN.AnswerTypeId = null; //答案类型ID
if (objvUserAnswerResultEN.AnswerTypeName == "[null]") objvUserAnswerResultEN.AnswerTypeName = null; //答案类型名
if (objvUserAnswerResultEN.GridTitle == "[null]") objvUserAnswerResultEN.GridTitle = null; //表格标题
if (objvUserAnswerResultEN.AnswerModeId == "[null]") objvUserAnswerResultEN.AnswerModeId = null; //答案模式Id
if (objvUserAnswerResultEN.QuestionnaireSetId == "[null]") objvUserAnswerResultEN.QuestionnaireSetId = null; //问卷集ID
if (objvUserAnswerResultEN.CourseId == "[null]") objvUserAnswerResultEN.CourseId = null; //课程Id
if (objvUserAnswerResultEN.CourseName == "[null]") objvUserAnswerResultEN.CourseName = null; //课程名称
if (objvUserAnswerResultEN.CourseExamPaperId == "[null]") objvUserAnswerResultEN.CourseExamPaperId = null; //考卷流水号
if (objvUserAnswerResultEN.AnswerOptionId == "[null]") objvUserAnswerResultEN.AnswerOptionId = null; //回答选项Id
if (objvUserAnswerResultEN.OptionName == "[null]") objvUserAnswerResultEN.OptionName = null; //选项名称
if (objvUserAnswerResultEN.OptionTitle == "[null]") objvUserAnswerResultEN.OptionTitle = null; //选项标题
if (objvUserAnswerResultEN.BatchId == "[null]") objvUserAnswerResultEN.BatchId = null; //批次ID
if (objvUserAnswerResultEN.UserId == "[null]") objvUserAnswerResultEN.UserId = null; //用户ID
if (objvUserAnswerResultEN.UserName == "[null]") objvUserAnswerResultEN.UserName = null; //用户名
if (objvUserAnswerResultEN.AnswerText == "[null]") objvUserAnswerResultEN.AnswerText = null; //回答文本
if (objvUserAnswerResultEN.AnswerDate == "[null]") objvUserAnswerResultEN.AnswerDate = null; //回答日期
if (objvUserAnswerResultEN.AnswerTime == "[null]") objvUserAnswerResultEN.AnswerTime = null; //回答时间
if (objvUserAnswerResultEN.AnswerIP == "[null]") objvUserAnswerResultEN.AnswerIP = null; //回答IP
if (objvUserAnswerResultEN.IdSchool == "[null]") objvUserAnswerResultEN.IdSchool = null; //学校流水号
if (objvUserAnswerResultEN.School == "[null]") objvUserAnswerResultEN.School = null; //School
if (objvUserAnswerResultEN.MarkTime == "[null]") objvUserAnswerResultEN.MarkTime = null; //批改时间
if (objvUserAnswerResultEN.MarkerId == "[null]") objvUserAnswerResultEN.MarkerId = null; //打分者
if (objvUserAnswerResultEN.Comment == "[null]") objvUserAnswerResultEN.Comment = null; //批注
if (objvUserAnswerResultEN.Memo == "[null]") objvUserAnswerResultEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvUserAnswerResultEN objvUserAnswerResultEN)
{
 vUserAnswerResultDA.CheckProperty4Condition(objvUserAnswerResultEN);
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
if (clsUserAnswerResultBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserAnswerResultBL没有刷新缓存机制(clsUserAnswerResultBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionOptionsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionOptionsBL没有刷新缓存机制(clsQuestionOptionsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by MinId");
//if (arrvUserAnswerResultObjLstCache == null)
//{
//arrvUserAnswerResultObjLstCache = vUserAnswerResultDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngMinId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUserAnswerResultEN GetObjByMinIdCache(long lngMinId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvUserAnswerResultEN._CurrTabName, strCourseId);
List<clsvUserAnswerResultEN> arrvUserAnswerResultObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvUserAnswerResultEN> arrvUserAnswerResultObjLst_Sel =
arrvUserAnswerResultObjLstCache
.Where(x=> x.MinId == lngMinId 
);
if (arrvUserAnswerResultObjLst_Sel.Count() == 0)
{
   clsvUserAnswerResultEN obj = clsvUserAnswerResultBL.GetObjByMinId(lngMinId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngMinId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvUserAnswerResultObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUserAnswerResultEN> GetAllvUserAnswerResultObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvUserAnswerResultEN> arrvUserAnswerResultObjLstCache = GetObjLstCache(strCourseId); 
return arrvUserAnswerResultObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUserAnswerResultEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvUserAnswerResultEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvUserAnswerResultEN> arrvUserAnswerResultObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvUserAnswerResultObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvUserAnswerResultEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsvUserAnswerResultEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvUserAnswerResultEN._RefreshTimeLst.Count == 0) return "";
return clsvUserAnswerResultEN._RefreshTimeLst[clsvUserAnswerResultEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, long lngMinId, string strCourseId)
{
if (strInFldName != convUserAnswerResult.MinId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convUserAnswerResult.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convUserAnswerResult.AttributeName));
throw new Exception(strMsg);
}
var objvUserAnswerResult = clsvUserAnswerResultBL.GetObjByMinIdCache(lngMinId, strCourseId);
if (objvUserAnswerResult == null) return "";
return objvUserAnswerResult[strOutFldName].ToString();
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
int intRecCount = clsvUserAnswerResultDA.GetRecCount(strTabName);
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
int intRecCount = clsvUserAnswerResultDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvUserAnswerResultDA.GetRecCount();
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
int intRecCount = clsvUserAnswerResultDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvUserAnswerResultCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvUserAnswerResultEN objvUserAnswerResultCond)
{
 string strCourseId = objvUserAnswerResultCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvUserAnswerResultBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvUserAnswerResultEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvUserAnswerResultEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convUserAnswerResult.AttributeName)
{
if (objvUserAnswerResultCond.IsUpdated(strFldName) == false) continue;
if (objvUserAnswerResultCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserAnswerResultCond[strFldName].ToString());
}
else
{
if (objvUserAnswerResultCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUserAnswerResultCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserAnswerResultCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUserAnswerResultCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUserAnswerResultCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUserAnswerResultCond[strFldName]));
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
 List<string> arrList = clsvUserAnswerResultDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vUserAnswerResultDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vUserAnswerResultDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}