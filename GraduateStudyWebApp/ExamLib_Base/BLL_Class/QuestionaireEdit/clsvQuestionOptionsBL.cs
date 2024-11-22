
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionOptionsBL
 表名:vQuestionOptions(01120189)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:32
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
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
public static class  clsvQuestionOptionsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strQuestionOptionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionOptionsEN GetObj(this K_QuestionOptionId_vQuestionOptions myKey)
{
clsvQuestionOptionsEN objvQuestionOptionsEN = clsvQuestionOptionsBL.vQuestionOptionsDA.GetObjByQuestionOptionId(myKey.Value);
return objvQuestionOptionsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionOptionsEN SetQuestionOptionId(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strQuestionOptionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionOptionId, 8, convQuestionOptions.QuestionOptionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionOptionId, 8, convQuestionOptions.QuestionOptionId);
}
objvQuestionOptionsEN.QuestionOptionId = strQuestionOptionId; //题目选项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionOptionsEN.dicFldComparisonOp.ContainsKey(convQuestionOptions.QuestionOptionId) == false)
{
objvQuestionOptionsEN.dicFldComparisonOp.Add(convQuestionOptions.QuestionOptionId, strComparisonOp);
}
else
{
objvQuestionOptionsEN.dicFldComparisonOp[convQuestionOptions.QuestionOptionId] = strComparisonOp;
}
}
return objvQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionOptionsEN SetOptionName(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strOptionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOptionName, convQuestionOptions.OptionName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOptionName, 4000, convQuestionOptions.OptionName);
}
objvQuestionOptionsEN.OptionName = strOptionName; //选项名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionOptionsEN.dicFldComparisonOp.ContainsKey(convQuestionOptions.OptionName) == false)
{
objvQuestionOptionsEN.dicFldComparisonOp.Add(convQuestionOptions.OptionName, strComparisonOp);
}
else
{
objvQuestionOptionsEN.dicFldComparisonOp[convQuestionOptions.OptionName] = strComparisonOp;
}
}
return objvQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionOptionsEN SetQuestionId(this clsvQuestionOptionsEN objvQuestionOptionsEN, long? lngQuestionId, string strComparisonOp="")
	{
objvQuestionOptionsEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionOptionsEN.dicFldComparisonOp.ContainsKey(convQuestionOptions.QuestionId) == false)
{
objvQuestionOptionsEN.dicFldComparisonOp.Add(convQuestionOptions.QuestionId, strComparisonOp);
}
else
{
objvQuestionOptionsEN.dicFldComparisonOp[convQuestionOptions.QuestionId] = strComparisonOp;
}
}
return objvQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionOptionsEN SetQuestionName(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strQuestionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionName, 500, convQuestionOptions.QuestionName);
}
objvQuestionOptionsEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionOptionsEN.dicFldComparisonOp.ContainsKey(convQuestionOptions.QuestionName) == false)
{
objvQuestionOptionsEN.dicFldComparisonOp.Add(convQuestionOptions.QuestionName, strComparisonOp);
}
else
{
objvQuestionOptionsEN.dicFldComparisonOp[convQuestionOptions.QuestionName] = strComparisonOp;
}
}
return objvQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionOptionsEN SetQuestionMemo(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strQuestionMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionMemo, 1000, convQuestionOptions.QuestionMemo);
}
objvQuestionOptionsEN.QuestionMemo = strQuestionMemo; //题目说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionOptionsEN.dicFldComparisonOp.ContainsKey(convQuestionOptions.QuestionMemo) == false)
{
objvQuestionOptionsEN.dicFldComparisonOp.Add(convQuestionOptions.QuestionMemo, strComparisonOp);
}
else
{
objvQuestionOptionsEN.dicFldComparisonOp[convQuestionOptions.QuestionMemo] = strComparisonOp;
}
}
return objvQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionOptionsEN SetCourseId(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convQuestionOptions.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convQuestionOptions.CourseId);
}
objvQuestionOptionsEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionOptionsEN.dicFldComparisonOp.ContainsKey(convQuestionOptions.CourseId) == false)
{
objvQuestionOptionsEN.dicFldComparisonOp.Add(convQuestionOptions.CourseId, strComparisonOp);
}
else
{
objvQuestionOptionsEN.dicFldComparisonOp[convQuestionOptions.CourseId] = strComparisonOp;
}
}
return objvQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionOptionsEN SetQuestionTypeId(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convQuestionOptions.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convQuestionOptions.QuestionTypeId);
}
objvQuestionOptionsEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionOptionsEN.dicFldComparisonOp.ContainsKey(convQuestionOptions.QuestionTypeId) == false)
{
objvQuestionOptionsEN.dicFldComparisonOp.Add(convQuestionOptions.QuestionTypeId, strComparisonOp);
}
else
{
objvQuestionOptionsEN.dicFldComparisonOp[convQuestionOptions.QuestionTypeId] = strComparisonOp;
}
}
return objvQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionOptionsEN SetQuestionTypeName(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strQuestionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convQuestionOptions.QuestionTypeName);
}
objvQuestionOptionsEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionOptionsEN.dicFldComparisonOp.ContainsKey(convQuestionOptions.QuestionTypeName) == false)
{
objvQuestionOptionsEN.dicFldComparisonOp.Add(convQuestionOptions.QuestionTypeName, strComparisonOp);
}
else
{
objvQuestionOptionsEN.dicFldComparisonOp[convQuestionOptions.QuestionTypeName] = strComparisonOp;
}
}
return objvQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionOptionsEN SetQuestionTypeId4Course(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strQuestionTypeId4Course, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId4Course, 8, convQuestionOptions.QuestionTypeId4Course);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId4Course, 8, convQuestionOptions.QuestionTypeId4Course);
}
objvQuestionOptionsEN.QuestionTypeId4Course = strQuestionTypeId4Course; //题目类型Id4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionOptionsEN.dicFldComparisonOp.ContainsKey(convQuestionOptions.QuestionTypeId4Course) == false)
{
objvQuestionOptionsEN.dicFldComparisonOp.Add(convQuestionOptions.QuestionTypeId4Course, strComparisonOp);
}
else
{
objvQuestionOptionsEN.dicFldComparisonOp[convQuestionOptions.QuestionTypeId4Course] = strComparisonOp;
}
}
return objvQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionOptionsEN SetGridTitle(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strGridTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGridTitle, 30, convQuestionOptions.GridTitle);
}
objvQuestionOptionsEN.GridTitle = strGridTitle; //表格标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionOptionsEN.dicFldComparisonOp.ContainsKey(convQuestionOptions.GridTitle) == false)
{
objvQuestionOptionsEN.dicFldComparisonOp.Add(convQuestionOptions.GridTitle, strComparisonOp);
}
else
{
objvQuestionOptionsEN.dicFldComparisonOp[convQuestionOptions.GridTitle] = strComparisonOp;
}
}
return objvQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionOptionsEN SetQuestionScore(this clsvQuestionOptionsEN objvQuestionOptionsEN, float? fltQuestionScore, string strComparisonOp="")
	{
objvQuestionOptionsEN.QuestionScore = fltQuestionScore; //题目得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionOptionsEN.dicFldComparisonOp.ContainsKey(convQuestionOptions.QuestionScore) == false)
{
objvQuestionOptionsEN.dicFldComparisonOp.Add(convQuestionOptions.QuestionScore, strComparisonOp);
}
else
{
objvQuestionOptionsEN.dicFldComparisonOp[convQuestionOptions.QuestionScore] = strComparisonOp;
}
}
return objvQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionOptionsEN SetOptionIndex(this clsvQuestionOptionsEN objvQuestionOptionsEN, int intOptionIndex, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOptionIndex, convQuestionOptions.OptionIndex);
objvQuestionOptionsEN.OptionIndex = intOptionIndex; //选项序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionOptionsEN.dicFldComparisonOp.ContainsKey(convQuestionOptions.OptionIndex) == false)
{
objvQuestionOptionsEN.dicFldComparisonOp.Add(convQuestionOptions.OptionIndex, strComparisonOp);
}
else
{
objvQuestionOptionsEN.dicFldComparisonOp[convQuestionOptions.OptionIndex] = strComparisonOp;
}
}
return objvQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionOptionsEN SetOptionTitle(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strOptionTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOptionTitle, 20, convQuestionOptions.OptionTitle);
}
objvQuestionOptionsEN.OptionTitle = strOptionTitle; //选项标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionOptionsEN.dicFldComparisonOp.ContainsKey(convQuestionOptions.OptionTitle) == false)
{
objvQuestionOptionsEN.dicFldComparisonOp.Add(convQuestionOptions.OptionTitle, strComparisonOp);
}
else
{
objvQuestionOptionsEN.dicFldComparisonOp[convQuestionOptions.OptionTitle] = strComparisonOp;
}
}
return objvQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionOptionsEN SetOptionContent(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strOptionContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOptionContent, 4000, convQuestionOptions.OptionContent);
}
objvQuestionOptionsEN.OptionContent = strOptionContent; //选项内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionOptionsEN.dicFldComparisonOp.ContainsKey(convQuestionOptions.OptionContent) == false)
{
objvQuestionOptionsEN.dicFldComparisonOp.Add(convQuestionOptions.OptionContent, strComparisonOp);
}
else
{
objvQuestionOptionsEN.dicFldComparisonOp[convQuestionOptions.OptionContent] = strComparisonOp;
}
}
return objvQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionOptionsEN SetIsCorrect(this clsvQuestionOptionsEN objvQuestionOptionsEN, bool bolIsCorrect, string strComparisonOp="")
	{
objvQuestionOptionsEN.IsCorrect = bolIsCorrect; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionOptionsEN.dicFldComparisonOp.ContainsKey(convQuestionOptions.IsCorrect) == false)
{
objvQuestionOptionsEN.dicFldComparisonOp.Add(convQuestionOptions.IsCorrect, strComparisonOp);
}
else
{
objvQuestionOptionsEN.dicFldComparisonOp[convQuestionOptions.IsCorrect] = strComparisonOp;
}
}
return objvQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionOptionsEN SetScore(this clsvQuestionOptionsEN objvQuestionOptionsEN, double? dblScore, string strComparisonOp="")
	{
objvQuestionOptionsEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionOptionsEN.dicFldComparisonOp.ContainsKey(convQuestionOptions.Score) == false)
{
objvQuestionOptionsEN.dicFldComparisonOp.Add(convQuestionOptions.Score, strComparisonOp);
}
else
{
objvQuestionOptionsEN.dicFldComparisonOp[convQuestionOptions.Score] = strComparisonOp;
}
}
return objvQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionOptionsEN SetIsShow(this clsvQuestionOptionsEN objvQuestionOptionsEN, bool bolIsShow, string strComparisonOp="")
	{
objvQuestionOptionsEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionOptionsEN.dicFldComparisonOp.ContainsKey(convQuestionOptions.IsShow) == false)
{
objvQuestionOptionsEN.dicFldComparisonOp.Add(convQuestionOptions.IsShow, strComparisonOp);
}
else
{
objvQuestionOptionsEN.dicFldComparisonOp[convQuestionOptions.IsShow] = strComparisonOp;
}
}
return objvQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionOptionsEN SetUpdDate(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQuestionOptions.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQuestionOptions.UpdDate);
}
objvQuestionOptionsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionOptionsEN.dicFldComparisonOp.ContainsKey(convQuestionOptions.UpdDate) == false)
{
objvQuestionOptionsEN.dicFldComparisonOp.Add(convQuestionOptions.UpdDate, strComparisonOp);
}
else
{
objvQuestionOptionsEN.dicFldComparisonOp[convQuestionOptions.UpdDate] = strComparisonOp;
}
}
return objvQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionOptionsEN SetUpdUser(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convQuestionOptions.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQuestionOptions.UpdUser);
}
objvQuestionOptionsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionOptionsEN.dicFldComparisonOp.ContainsKey(convQuestionOptions.UpdUser) == false)
{
objvQuestionOptionsEN.dicFldComparisonOp.Add(convQuestionOptions.UpdUser, strComparisonOp);
}
else
{
objvQuestionOptionsEN.dicFldComparisonOp[convQuestionOptions.UpdUser] = strComparisonOp;
}
}
return objvQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionOptionsEN SetMemo(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQuestionOptions.Memo);
}
objvQuestionOptionsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionOptionsEN.dicFldComparisonOp.ContainsKey(convQuestionOptions.Memo) == false)
{
objvQuestionOptionsEN.dicFldComparisonOp.Add(convQuestionOptions.Memo, strComparisonOp);
}
else
{
objvQuestionOptionsEN.dicFldComparisonOp[convQuestionOptions.Memo] = strComparisonOp;
}
}
return objvQuestionOptionsEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQuestionOptionsENS">源对象</param>
 /// <param name = "objvQuestionOptionsENT">目标对象</param>
 public static void CopyTo(this clsvQuestionOptionsEN objvQuestionOptionsENS, clsvQuestionOptionsEN objvQuestionOptionsENT)
{
try
{
objvQuestionOptionsENT.QuestionOptionId = objvQuestionOptionsENS.QuestionOptionId; //题目选项Id
objvQuestionOptionsENT.OptionName = objvQuestionOptionsENS.OptionName; //选项名称
objvQuestionOptionsENT.QuestionId = objvQuestionOptionsENS.QuestionId; //题目Id
objvQuestionOptionsENT.QuestionName = objvQuestionOptionsENS.QuestionName; //题目名称
objvQuestionOptionsENT.QuestionMemo = objvQuestionOptionsENS.QuestionMemo; //题目说明
objvQuestionOptionsENT.CourseId = objvQuestionOptionsENS.CourseId; //课程Id
objvQuestionOptionsENT.QuestionTypeId = objvQuestionOptionsENS.QuestionTypeId; //题目类型Id
objvQuestionOptionsENT.QuestionTypeName = objvQuestionOptionsENS.QuestionTypeName; //题目类型名
objvQuestionOptionsENT.QuestionTypeId4Course = objvQuestionOptionsENS.QuestionTypeId4Course; //题目类型Id4课程
objvQuestionOptionsENT.GridTitle = objvQuestionOptionsENS.GridTitle; //表格标题
objvQuestionOptionsENT.QuestionScore = objvQuestionOptionsENS.QuestionScore; //题目得分
objvQuestionOptionsENT.OptionIndex = objvQuestionOptionsENS.OptionIndex; //选项序号
objvQuestionOptionsENT.OptionTitle = objvQuestionOptionsENS.OptionTitle; //选项标题
objvQuestionOptionsENT.OptionContent = objvQuestionOptionsENS.OptionContent; //选项内容
objvQuestionOptionsENT.IsCorrect = objvQuestionOptionsENS.IsCorrect; //是否正确
objvQuestionOptionsENT.Score = objvQuestionOptionsENS.Score; //得分
objvQuestionOptionsENT.IsShow = objvQuestionOptionsENS.IsShow; //是否启用
objvQuestionOptionsENT.UpdDate = objvQuestionOptionsENS.UpdDate; //修改日期
objvQuestionOptionsENT.UpdUser = objvQuestionOptionsENS.UpdUser; //修改人
objvQuestionOptionsENT.Memo = objvQuestionOptionsENS.Memo; //备注
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
 /// <param name = "objvQuestionOptionsENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionOptionsEN:objvQuestionOptionsENT</returns>
 public static clsvQuestionOptionsEN CopyTo(this clsvQuestionOptionsEN objvQuestionOptionsENS)
{
try
{
 clsvQuestionOptionsEN objvQuestionOptionsENT = new clsvQuestionOptionsEN()
{
QuestionOptionId = objvQuestionOptionsENS.QuestionOptionId, //题目选项Id
OptionName = objvQuestionOptionsENS.OptionName, //选项名称
QuestionId = objvQuestionOptionsENS.QuestionId, //题目Id
QuestionName = objvQuestionOptionsENS.QuestionName, //题目名称
QuestionMemo = objvQuestionOptionsENS.QuestionMemo, //题目说明
CourseId = objvQuestionOptionsENS.CourseId, //课程Id
QuestionTypeId = objvQuestionOptionsENS.QuestionTypeId, //题目类型Id
QuestionTypeName = objvQuestionOptionsENS.QuestionTypeName, //题目类型名
QuestionTypeId4Course = objvQuestionOptionsENS.QuestionTypeId4Course, //题目类型Id4课程
GridTitle = objvQuestionOptionsENS.GridTitle, //表格标题
QuestionScore = objvQuestionOptionsENS.QuestionScore, //题目得分
OptionIndex = objvQuestionOptionsENS.OptionIndex, //选项序号
OptionTitle = objvQuestionOptionsENS.OptionTitle, //选项标题
OptionContent = objvQuestionOptionsENS.OptionContent, //选项内容
IsCorrect = objvQuestionOptionsENS.IsCorrect, //是否正确
Score = objvQuestionOptionsENS.Score, //得分
IsShow = objvQuestionOptionsENS.IsShow, //是否启用
UpdDate = objvQuestionOptionsENS.UpdDate, //修改日期
UpdUser = objvQuestionOptionsENS.UpdUser, //修改人
Memo = objvQuestionOptionsENS.Memo, //备注
};
 return objvQuestionOptionsENT;
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
public static void CheckProperty4Condition(this clsvQuestionOptionsEN objvQuestionOptionsEN)
{
 clsvQuestionOptionsBL.vQuestionOptionsDA.CheckProperty4Condition(objvQuestionOptionsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionOptionsEN objvQuestionOptionsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionOptionsCond.IsUpdated(convQuestionOptions.QuestionOptionId) == true)
{
string strComparisonOpQuestionOptionId = objvQuestionOptionsCond.dicFldComparisonOp[convQuestionOptions.QuestionOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.QuestionOptionId, objvQuestionOptionsCond.QuestionOptionId, strComparisonOpQuestionOptionId);
}
if (objvQuestionOptionsCond.IsUpdated(convQuestionOptions.OptionName) == true)
{
string strComparisonOpOptionName = objvQuestionOptionsCond.dicFldComparisonOp[convQuestionOptions.OptionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.OptionName, objvQuestionOptionsCond.OptionName, strComparisonOpOptionName);
}
if (objvQuestionOptionsCond.IsUpdated(convQuestionOptions.QuestionId) == true)
{
string strComparisonOpQuestionId = objvQuestionOptionsCond.dicFldComparisonOp[convQuestionOptions.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionOptions.QuestionId, objvQuestionOptionsCond.QuestionId, strComparisonOpQuestionId);
}
if (objvQuestionOptionsCond.IsUpdated(convQuestionOptions.QuestionName) == true)
{
string strComparisonOpQuestionName = objvQuestionOptionsCond.dicFldComparisonOp[convQuestionOptions.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.QuestionName, objvQuestionOptionsCond.QuestionName, strComparisonOpQuestionName);
}
if (objvQuestionOptionsCond.IsUpdated(convQuestionOptions.QuestionMemo) == true)
{
string strComparisonOpQuestionMemo = objvQuestionOptionsCond.dicFldComparisonOp[convQuestionOptions.QuestionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.QuestionMemo, objvQuestionOptionsCond.QuestionMemo, strComparisonOpQuestionMemo);
}
if (objvQuestionOptionsCond.IsUpdated(convQuestionOptions.CourseId) == true)
{
string strComparisonOpCourseId = objvQuestionOptionsCond.dicFldComparisonOp[convQuestionOptions.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.CourseId, objvQuestionOptionsCond.CourseId, strComparisonOpCourseId);
}
if (objvQuestionOptionsCond.IsUpdated(convQuestionOptions.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objvQuestionOptionsCond.dicFldComparisonOp[convQuestionOptions.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.QuestionTypeId, objvQuestionOptionsCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objvQuestionOptionsCond.IsUpdated(convQuestionOptions.QuestionTypeName) == true)
{
string strComparisonOpQuestionTypeName = objvQuestionOptionsCond.dicFldComparisonOp[convQuestionOptions.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.QuestionTypeName, objvQuestionOptionsCond.QuestionTypeName, strComparisonOpQuestionTypeName);
}
if (objvQuestionOptionsCond.IsUpdated(convQuestionOptions.QuestionTypeId4Course) == true)
{
string strComparisonOpQuestionTypeId4Course = objvQuestionOptionsCond.dicFldComparisonOp[convQuestionOptions.QuestionTypeId4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.QuestionTypeId4Course, objvQuestionOptionsCond.QuestionTypeId4Course, strComparisonOpQuestionTypeId4Course);
}
if (objvQuestionOptionsCond.IsUpdated(convQuestionOptions.GridTitle) == true)
{
string strComparisonOpGridTitle = objvQuestionOptionsCond.dicFldComparisonOp[convQuestionOptions.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.GridTitle, objvQuestionOptionsCond.GridTitle, strComparisonOpGridTitle);
}
if (objvQuestionOptionsCond.IsUpdated(convQuestionOptions.QuestionScore) == true)
{
string strComparisonOpQuestionScore = objvQuestionOptionsCond.dicFldComparisonOp[convQuestionOptions.QuestionScore];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionOptions.QuestionScore, objvQuestionOptionsCond.QuestionScore, strComparisonOpQuestionScore);
}
if (objvQuestionOptionsCond.IsUpdated(convQuestionOptions.OptionIndex) == true)
{
string strComparisonOpOptionIndex = objvQuestionOptionsCond.dicFldComparisonOp[convQuestionOptions.OptionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionOptions.OptionIndex, objvQuestionOptionsCond.OptionIndex, strComparisonOpOptionIndex);
}
if (objvQuestionOptionsCond.IsUpdated(convQuestionOptions.OptionTitle) == true)
{
string strComparisonOpOptionTitle = objvQuestionOptionsCond.dicFldComparisonOp[convQuestionOptions.OptionTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.OptionTitle, objvQuestionOptionsCond.OptionTitle, strComparisonOpOptionTitle);
}
if (objvQuestionOptionsCond.IsUpdated(convQuestionOptions.OptionContent) == true)
{
string strComparisonOpOptionContent = objvQuestionOptionsCond.dicFldComparisonOp[convQuestionOptions.OptionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.OptionContent, objvQuestionOptionsCond.OptionContent, strComparisonOpOptionContent);
}
if (objvQuestionOptionsCond.IsUpdated(convQuestionOptions.IsCorrect) == true)
{
if (objvQuestionOptionsCond.IsCorrect == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionOptions.IsCorrect);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionOptions.IsCorrect);
}
}
if (objvQuestionOptionsCond.IsUpdated(convQuestionOptions.Score) == true)
{
string strComparisonOpScore = objvQuestionOptionsCond.dicFldComparisonOp[convQuestionOptions.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionOptions.Score, objvQuestionOptionsCond.Score, strComparisonOpScore);
}
if (objvQuestionOptionsCond.IsUpdated(convQuestionOptions.IsShow) == true)
{
if (objvQuestionOptionsCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionOptions.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionOptions.IsShow);
}
}
if (objvQuestionOptionsCond.IsUpdated(convQuestionOptions.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQuestionOptionsCond.dicFldComparisonOp[convQuestionOptions.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.UpdDate, objvQuestionOptionsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQuestionOptionsCond.IsUpdated(convQuestionOptions.UpdUser) == true)
{
string strComparisonOpUpdUser = objvQuestionOptionsCond.dicFldComparisonOp[convQuestionOptions.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.UpdUser, objvQuestionOptionsCond.UpdUser, strComparisonOpUpdUser);
}
if (objvQuestionOptionsCond.IsUpdated(convQuestionOptions.Memo) == true)
{
string strComparisonOpMemo = objvQuestionOptionsCond.dicFldComparisonOp[convQuestionOptions.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.Memo, objvQuestionOptionsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQuestionOptions
{
public virtual bool UpdRelaTabDate(string strQuestionOptionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v题目选项(vQuestionOptions)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionOptionsBL
{
public static RelatedActions_vQuestionOptions relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQuestionOptionsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQuestionOptionsDA vQuestionOptionsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQuestionOptionsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQuestionOptionsBL()
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
if (string.IsNullOrEmpty(clsvQuestionOptionsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQuestionOptionsEN._ConnectString);
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
public static DataTable GetDataTable_vQuestionOptions(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQuestionOptionsDA.GetDataTable_vQuestionOptions(strWhereCond);
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
objDT = vQuestionOptionsDA.GetDataTable(strWhereCond);
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
objDT = vQuestionOptionsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQuestionOptionsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQuestionOptionsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQuestionOptionsDA.GetDataTable_Top(objTopPara);
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
objDT = vQuestionOptionsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQuestionOptionsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQuestionOptionsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrQuestionOptionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQuestionOptionsEN> GetObjLstByQuestionOptionIdLst(List<string> arrQuestionOptionIdLst)
{
List<clsvQuestionOptionsEN> arrObjLst = new List<clsvQuestionOptionsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrQuestionOptionIdLst, true);
 string strWhereCond = string.Format("QuestionOptionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionOptionsEN objvQuestionOptionsEN = new clsvQuestionOptionsEN();
try
{
objvQuestionOptionsEN.QuestionOptionId = objRow[convQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objvQuestionOptionsEN.OptionName = objRow[convQuestionOptions.OptionName].ToString().Trim(); //选项名称
objvQuestionOptionsEN.QuestionId = objRow[convQuestionOptions.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objvQuestionOptionsEN.QuestionName = objRow[convQuestionOptions.QuestionName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionName].ToString().Trim(); //题目名称
objvQuestionOptionsEN.QuestionMemo = objRow[convQuestionOptions.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionOptionsEN.CourseId = objRow[convQuestionOptions.CourseId] == DBNull.Value ? null : objRow[convQuestionOptions.CourseId].ToString().Trim(); //课程Id
objvQuestionOptionsEN.QuestionTypeId = objRow[convQuestionOptions.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionOptionsEN.QuestionTypeName = objRow[convQuestionOptions.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionOptionsEN.QuestionTypeId4Course = objRow[convQuestionOptions.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionOptionsEN.GridTitle = objRow[convQuestionOptions.GridTitle] == DBNull.Value ? null : objRow[convQuestionOptions.GridTitle].ToString().Trim(); //表格标题
objvQuestionOptionsEN.QuestionScore = objRow[convQuestionOptions.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionOptions.QuestionScore].ToString().Trim()); //题目得分
objvQuestionOptionsEN.OptionIndex = Int32.Parse(objRow[convQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objvQuestionOptionsEN.OptionTitle = objRow[convQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[convQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objvQuestionOptionsEN.OptionContent = objRow[convQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[convQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objvQuestionOptionsEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[convQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objvQuestionOptionsEN.Score = objRow[convQuestionOptions.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convQuestionOptions.Score].ToString().Trim()); //得分
objvQuestionOptionsEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionOptions.IsShow].ToString().Trim()); //是否启用
objvQuestionOptionsEN.UpdDate = objRow[convQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objvQuestionOptionsEN.UpdUser = objRow[convQuestionOptions.UpdUser].ToString().Trim(); //修改人
objvQuestionOptionsEN.Memo = objRow[convQuestionOptions.Memo] == DBNull.Value ? null : objRow[convQuestionOptions.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionOptionsEN.QuestionOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionOptionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrQuestionOptionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQuestionOptionsEN> GetObjLstByQuestionOptionIdLstCache(List<string> arrQuestionOptionIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvQuestionOptionsEN._CurrTabName, strCourseId);
List<clsvQuestionOptionsEN> arrvQuestionOptionsObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionOptionsEN> arrvQuestionOptionsObjLst_Sel =
arrvQuestionOptionsObjLstCache
.Where(x => arrQuestionOptionIdLst.Contains(x.QuestionOptionId));
return arrvQuestionOptionsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionOptionsEN> GetObjLst(string strWhereCond)
{
List<clsvQuestionOptionsEN> arrObjLst = new List<clsvQuestionOptionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionOptionsEN objvQuestionOptionsEN = new clsvQuestionOptionsEN();
try
{
objvQuestionOptionsEN.QuestionOptionId = objRow[convQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objvQuestionOptionsEN.OptionName = objRow[convQuestionOptions.OptionName].ToString().Trim(); //选项名称
objvQuestionOptionsEN.QuestionId = objRow[convQuestionOptions.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objvQuestionOptionsEN.QuestionName = objRow[convQuestionOptions.QuestionName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionName].ToString().Trim(); //题目名称
objvQuestionOptionsEN.QuestionMemo = objRow[convQuestionOptions.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionOptionsEN.CourseId = objRow[convQuestionOptions.CourseId] == DBNull.Value ? null : objRow[convQuestionOptions.CourseId].ToString().Trim(); //课程Id
objvQuestionOptionsEN.QuestionTypeId = objRow[convQuestionOptions.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionOptionsEN.QuestionTypeName = objRow[convQuestionOptions.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionOptionsEN.QuestionTypeId4Course = objRow[convQuestionOptions.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionOptionsEN.GridTitle = objRow[convQuestionOptions.GridTitle] == DBNull.Value ? null : objRow[convQuestionOptions.GridTitle].ToString().Trim(); //表格标题
objvQuestionOptionsEN.QuestionScore = objRow[convQuestionOptions.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionOptions.QuestionScore].ToString().Trim()); //题目得分
objvQuestionOptionsEN.OptionIndex = Int32.Parse(objRow[convQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objvQuestionOptionsEN.OptionTitle = objRow[convQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[convQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objvQuestionOptionsEN.OptionContent = objRow[convQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[convQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objvQuestionOptionsEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[convQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objvQuestionOptionsEN.Score = objRow[convQuestionOptions.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convQuestionOptions.Score].ToString().Trim()); //得分
objvQuestionOptionsEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionOptions.IsShow].ToString().Trim()); //是否启用
objvQuestionOptionsEN.UpdDate = objRow[convQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objvQuestionOptionsEN.UpdUser = objRow[convQuestionOptions.UpdUser].ToString().Trim(); //修改人
objvQuestionOptionsEN.Memo = objRow[convQuestionOptions.Memo] == DBNull.Value ? null : objRow[convQuestionOptions.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionOptionsEN.QuestionOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionOptionsEN);
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
public static List<clsvQuestionOptionsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionOptionsEN> arrObjLst = new List<clsvQuestionOptionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionOptionsEN objvQuestionOptionsEN = new clsvQuestionOptionsEN();
try
{
objvQuestionOptionsEN.QuestionOptionId = objRow[convQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objvQuestionOptionsEN.OptionName = objRow[convQuestionOptions.OptionName].ToString().Trim(); //选项名称
objvQuestionOptionsEN.QuestionId = objRow[convQuestionOptions.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objvQuestionOptionsEN.QuestionName = objRow[convQuestionOptions.QuestionName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionName].ToString().Trim(); //题目名称
objvQuestionOptionsEN.QuestionMemo = objRow[convQuestionOptions.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionOptionsEN.CourseId = objRow[convQuestionOptions.CourseId] == DBNull.Value ? null : objRow[convQuestionOptions.CourseId].ToString().Trim(); //课程Id
objvQuestionOptionsEN.QuestionTypeId = objRow[convQuestionOptions.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionOptionsEN.QuestionTypeName = objRow[convQuestionOptions.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionOptionsEN.QuestionTypeId4Course = objRow[convQuestionOptions.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionOptionsEN.GridTitle = objRow[convQuestionOptions.GridTitle] == DBNull.Value ? null : objRow[convQuestionOptions.GridTitle].ToString().Trim(); //表格标题
objvQuestionOptionsEN.QuestionScore = objRow[convQuestionOptions.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionOptions.QuestionScore].ToString().Trim()); //题目得分
objvQuestionOptionsEN.OptionIndex = Int32.Parse(objRow[convQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objvQuestionOptionsEN.OptionTitle = objRow[convQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[convQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objvQuestionOptionsEN.OptionContent = objRow[convQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[convQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objvQuestionOptionsEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[convQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objvQuestionOptionsEN.Score = objRow[convQuestionOptions.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convQuestionOptions.Score].ToString().Trim()); //得分
objvQuestionOptionsEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionOptions.IsShow].ToString().Trim()); //是否启用
objvQuestionOptionsEN.UpdDate = objRow[convQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objvQuestionOptionsEN.UpdUser = objRow[convQuestionOptions.UpdUser].ToString().Trim(); //修改人
objvQuestionOptionsEN.Memo = objRow[convQuestionOptions.Memo] == DBNull.Value ? null : objRow[convQuestionOptions.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionOptionsEN.QuestionOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionOptionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQuestionOptionsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQuestionOptionsEN> GetSubObjLstCache(clsvQuestionOptionsEN objvQuestionOptionsCond)
{
 string strCourseId = objvQuestionOptionsCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvQuestionOptionsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvQuestionOptionsEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionOptionsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionOptions.AttributeName)
{
if (objvQuestionOptionsCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionOptionsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionOptionsCond[strFldName].ToString());
}
else
{
if (objvQuestionOptionsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionOptionsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionOptionsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionOptionsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionOptionsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionOptionsCond[strFldName]));
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
public static List<clsvQuestionOptionsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQuestionOptionsEN> arrObjLst = new List<clsvQuestionOptionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionOptionsEN objvQuestionOptionsEN = new clsvQuestionOptionsEN();
try
{
objvQuestionOptionsEN.QuestionOptionId = objRow[convQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objvQuestionOptionsEN.OptionName = objRow[convQuestionOptions.OptionName].ToString().Trim(); //选项名称
objvQuestionOptionsEN.QuestionId = objRow[convQuestionOptions.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objvQuestionOptionsEN.QuestionName = objRow[convQuestionOptions.QuestionName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionName].ToString().Trim(); //题目名称
objvQuestionOptionsEN.QuestionMemo = objRow[convQuestionOptions.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionOptionsEN.CourseId = objRow[convQuestionOptions.CourseId] == DBNull.Value ? null : objRow[convQuestionOptions.CourseId].ToString().Trim(); //课程Id
objvQuestionOptionsEN.QuestionTypeId = objRow[convQuestionOptions.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionOptionsEN.QuestionTypeName = objRow[convQuestionOptions.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionOptionsEN.QuestionTypeId4Course = objRow[convQuestionOptions.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionOptionsEN.GridTitle = objRow[convQuestionOptions.GridTitle] == DBNull.Value ? null : objRow[convQuestionOptions.GridTitle].ToString().Trim(); //表格标题
objvQuestionOptionsEN.QuestionScore = objRow[convQuestionOptions.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionOptions.QuestionScore].ToString().Trim()); //题目得分
objvQuestionOptionsEN.OptionIndex = Int32.Parse(objRow[convQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objvQuestionOptionsEN.OptionTitle = objRow[convQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[convQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objvQuestionOptionsEN.OptionContent = objRow[convQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[convQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objvQuestionOptionsEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[convQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objvQuestionOptionsEN.Score = objRow[convQuestionOptions.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convQuestionOptions.Score].ToString().Trim()); //得分
objvQuestionOptionsEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionOptions.IsShow].ToString().Trim()); //是否启用
objvQuestionOptionsEN.UpdDate = objRow[convQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objvQuestionOptionsEN.UpdUser = objRow[convQuestionOptions.UpdUser].ToString().Trim(); //修改人
objvQuestionOptionsEN.Memo = objRow[convQuestionOptions.Memo] == DBNull.Value ? null : objRow[convQuestionOptions.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionOptionsEN.QuestionOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionOptionsEN);
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
public static List<clsvQuestionOptionsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQuestionOptionsEN> arrObjLst = new List<clsvQuestionOptionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionOptionsEN objvQuestionOptionsEN = new clsvQuestionOptionsEN();
try
{
objvQuestionOptionsEN.QuestionOptionId = objRow[convQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objvQuestionOptionsEN.OptionName = objRow[convQuestionOptions.OptionName].ToString().Trim(); //选项名称
objvQuestionOptionsEN.QuestionId = objRow[convQuestionOptions.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objvQuestionOptionsEN.QuestionName = objRow[convQuestionOptions.QuestionName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionName].ToString().Trim(); //题目名称
objvQuestionOptionsEN.QuestionMemo = objRow[convQuestionOptions.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionOptionsEN.CourseId = objRow[convQuestionOptions.CourseId] == DBNull.Value ? null : objRow[convQuestionOptions.CourseId].ToString().Trim(); //课程Id
objvQuestionOptionsEN.QuestionTypeId = objRow[convQuestionOptions.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionOptionsEN.QuestionTypeName = objRow[convQuestionOptions.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionOptionsEN.QuestionTypeId4Course = objRow[convQuestionOptions.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionOptionsEN.GridTitle = objRow[convQuestionOptions.GridTitle] == DBNull.Value ? null : objRow[convQuestionOptions.GridTitle].ToString().Trim(); //表格标题
objvQuestionOptionsEN.QuestionScore = objRow[convQuestionOptions.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionOptions.QuestionScore].ToString().Trim()); //题目得分
objvQuestionOptionsEN.OptionIndex = Int32.Parse(objRow[convQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objvQuestionOptionsEN.OptionTitle = objRow[convQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[convQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objvQuestionOptionsEN.OptionContent = objRow[convQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[convQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objvQuestionOptionsEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[convQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objvQuestionOptionsEN.Score = objRow[convQuestionOptions.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convQuestionOptions.Score].ToString().Trim()); //得分
objvQuestionOptionsEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionOptions.IsShow].ToString().Trim()); //是否启用
objvQuestionOptionsEN.UpdDate = objRow[convQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objvQuestionOptionsEN.UpdUser = objRow[convQuestionOptions.UpdUser].ToString().Trim(); //修改人
objvQuestionOptionsEN.Memo = objRow[convQuestionOptions.Memo] == DBNull.Value ? null : objRow[convQuestionOptions.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionOptionsEN.QuestionOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionOptionsEN);
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
List<clsvQuestionOptionsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQuestionOptionsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionOptionsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQuestionOptionsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionOptionsEN> arrObjLst = new List<clsvQuestionOptionsEN>(); 
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
	clsvQuestionOptionsEN objvQuestionOptionsEN = new clsvQuestionOptionsEN();
try
{
objvQuestionOptionsEN.QuestionOptionId = objRow[convQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objvQuestionOptionsEN.OptionName = objRow[convQuestionOptions.OptionName].ToString().Trim(); //选项名称
objvQuestionOptionsEN.QuestionId = objRow[convQuestionOptions.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objvQuestionOptionsEN.QuestionName = objRow[convQuestionOptions.QuestionName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionName].ToString().Trim(); //题目名称
objvQuestionOptionsEN.QuestionMemo = objRow[convQuestionOptions.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionOptionsEN.CourseId = objRow[convQuestionOptions.CourseId] == DBNull.Value ? null : objRow[convQuestionOptions.CourseId].ToString().Trim(); //课程Id
objvQuestionOptionsEN.QuestionTypeId = objRow[convQuestionOptions.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionOptionsEN.QuestionTypeName = objRow[convQuestionOptions.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionOptionsEN.QuestionTypeId4Course = objRow[convQuestionOptions.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionOptionsEN.GridTitle = objRow[convQuestionOptions.GridTitle] == DBNull.Value ? null : objRow[convQuestionOptions.GridTitle].ToString().Trim(); //表格标题
objvQuestionOptionsEN.QuestionScore = objRow[convQuestionOptions.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionOptions.QuestionScore].ToString().Trim()); //题目得分
objvQuestionOptionsEN.OptionIndex = Int32.Parse(objRow[convQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objvQuestionOptionsEN.OptionTitle = objRow[convQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[convQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objvQuestionOptionsEN.OptionContent = objRow[convQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[convQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objvQuestionOptionsEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[convQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objvQuestionOptionsEN.Score = objRow[convQuestionOptions.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convQuestionOptions.Score].ToString().Trim()); //得分
objvQuestionOptionsEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionOptions.IsShow].ToString().Trim()); //是否启用
objvQuestionOptionsEN.UpdDate = objRow[convQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objvQuestionOptionsEN.UpdUser = objRow[convQuestionOptions.UpdUser].ToString().Trim(); //修改人
objvQuestionOptionsEN.Memo = objRow[convQuestionOptions.Memo] == DBNull.Value ? null : objRow[convQuestionOptions.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionOptionsEN.QuestionOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionOptionsEN);
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
public static List<clsvQuestionOptionsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionOptionsEN> arrObjLst = new List<clsvQuestionOptionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionOptionsEN objvQuestionOptionsEN = new clsvQuestionOptionsEN();
try
{
objvQuestionOptionsEN.QuestionOptionId = objRow[convQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objvQuestionOptionsEN.OptionName = objRow[convQuestionOptions.OptionName].ToString().Trim(); //选项名称
objvQuestionOptionsEN.QuestionId = objRow[convQuestionOptions.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objvQuestionOptionsEN.QuestionName = objRow[convQuestionOptions.QuestionName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionName].ToString().Trim(); //题目名称
objvQuestionOptionsEN.QuestionMemo = objRow[convQuestionOptions.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionOptionsEN.CourseId = objRow[convQuestionOptions.CourseId] == DBNull.Value ? null : objRow[convQuestionOptions.CourseId].ToString().Trim(); //课程Id
objvQuestionOptionsEN.QuestionTypeId = objRow[convQuestionOptions.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionOptionsEN.QuestionTypeName = objRow[convQuestionOptions.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionOptionsEN.QuestionTypeId4Course = objRow[convQuestionOptions.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionOptionsEN.GridTitle = objRow[convQuestionOptions.GridTitle] == DBNull.Value ? null : objRow[convQuestionOptions.GridTitle].ToString().Trim(); //表格标题
objvQuestionOptionsEN.QuestionScore = objRow[convQuestionOptions.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionOptions.QuestionScore].ToString().Trim()); //题目得分
objvQuestionOptionsEN.OptionIndex = Int32.Parse(objRow[convQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objvQuestionOptionsEN.OptionTitle = objRow[convQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[convQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objvQuestionOptionsEN.OptionContent = objRow[convQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[convQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objvQuestionOptionsEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[convQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objvQuestionOptionsEN.Score = objRow[convQuestionOptions.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convQuestionOptions.Score].ToString().Trim()); //得分
objvQuestionOptionsEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionOptions.IsShow].ToString().Trim()); //是否启用
objvQuestionOptionsEN.UpdDate = objRow[convQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objvQuestionOptionsEN.UpdUser = objRow[convQuestionOptions.UpdUser].ToString().Trim(); //修改人
objvQuestionOptionsEN.Memo = objRow[convQuestionOptions.Memo] == DBNull.Value ? null : objRow[convQuestionOptions.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionOptionsEN.QuestionOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionOptionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQuestionOptionsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQuestionOptionsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionOptionsEN> arrObjLst = new List<clsvQuestionOptionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionOptionsEN objvQuestionOptionsEN = new clsvQuestionOptionsEN();
try
{
objvQuestionOptionsEN.QuestionOptionId = objRow[convQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objvQuestionOptionsEN.OptionName = objRow[convQuestionOptions.OptionName].ToString().Trim(); //选项名称
objvQuestionOptionsEN.QuestionId = objRow[convQuestionOptions.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objvQuestionOptionsEN.QuestionName = objRow[convQuestionOptions.QuestionName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionName].ToString().Trim(); //题目名称
objvQuestionOptionsEN.QuestionMemo = objRow[convQuestionOptions.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionOptionsEN.CourseId = objRow[convQuestionOptions.CourseId] == DBNull.Value ? null : objRow[convQuestionOptions.CourseId].ToString().Trim(); //课程Id
objvQuestionOptionsEN.QuestionTypeId = objRow[convQuestionOptions.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionOptionsEN.QuestionTypeName = objRow[convQuestionOptions.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionOptionsEN.QuestionTypeId4Course = objRow[convQuestionOptions.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionOptionsEN.GridTitle = objRow[convQuestionOptions.GridTitle] == DBNull.Value ? null : objRow[convQuestionOptions.GridTitle].ToString().Trim(); //表格标题
objvQuestionOptionsEN.QuestionScore = objRow[convQuestionOptions.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionOptions.QuestionScore].ToString().Trim()); //题目得分
objvQuestionOptionsEN.OptionIndex = Int32.Parse(objRow[convQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objvQuestionOptionsEN.OptionTitle = objRow[convQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[convQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objvQuestionOptionsEN.OptionContent = objRow[convQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[convQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objvQuestionOptionsEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[convQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objvQuestionOptionsEN.Score = objRow[convQuestionOptions.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convQuestionOptions.Score].ToString().Trim()); //得分
objvQuestionOptionsEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionOptions.IsShow].ToString().Trim()); //是否启用
objvQuestionOptionsEN.UpdDate = objRow[convQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objvQuestionOptionsEN.UpdUser = objRow[convQuestionOptions.UpdUser].ToString().Trim(); //修改人
objvQuestionOptionsEN.Memo = objRow[convQuestionOptions.Memo] == DBNull.Value ? null : objRow[convQuestionOptions.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionOptionsEN.QuestionOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionOptionsEN);
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
public static List<clsvQuestionOptionsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQuestionOptionsEN> arrObjLst = new List<clsvQuestionOptionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionOptionsEN objvQuestionOptionsEN = new clsvQuestionOptionsEN();
try
{
objvQuestionOptionsEN.QuestionOptionId = objRow[convQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objvQuestionOptionsEN.OptionName = objRow[convQuestionOptions.OptionName].ToString().Trim(); //选项名称
objvQuestionOptionsEN.QuestionId = objRow[convQuestionOptions.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objvQuestionOptionsEN.QuestionName = objRow[convQuestionOptions.QuestionName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionName].ToString().Trim(); //题目名称
objvQuestionOptionsEN.QuestionMemo = objRow[convQuestionOptions.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionOptionsEN.CourseId = objRow[convQuestionOptions.CourseId] == DBNull.Value ? null : objRow[convQuestionOptions.CourseId].ToString().Trim(); //课程Id
objvQuestionOptionsEN.QuestionTypeId = objRow[convQuestionOptions.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionOptionsEN.QuestionTypeName = objRow[convQuestionOptions.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionOptionsEN.QuestionTypeId4Course = objRow[convQuestionOptions.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionOptionsEN.GridTitle = objRow[convQuestionOptions.GridTitle] == DBNull.Value ? null : objRow[convQuestionOptions.GridTitle].ToString().Trim(); //表格标题
objvQuestionOptionsEN.QuestionScore = objRow[convQuestionOptions.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionOptions.QuestionScore].ToString().Trim()); //题目得分
objvQuestionOptionsEN.OptionIndex = Int32.Parse(objRow[convQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objvQuestionOptionsEN.OptionTitle = objRow[convQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[convQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objvQuestionOptionsEN.OptionContent = objRow[convQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[convQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objvQuestionOptionsEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[convQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objvQuestionOptionsEN.Score = objRow[convQuestionOptions.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convQuestionOptions.Score].ToString().Trim()); //得分
objvQuestionOptionsEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionOptions.IsShow].ToString().Trim()); //是否启用
objvQuestionOptionsEN.UpdDate = objRow[convQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objvQuestionOptionsEN.UpdUser = objRow[convQuestionOptions.UpdUser].ToString().Trim(); //修改人
objvQuestionOptionsEN.Memo = objRow[convQuestionOptions.Memo] == DBNull.Value ? null : objRow[convQuestionOptions.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionOptionsEN.QuestionOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionOptionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionOptionsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQuestionOptionsEN> arrObjLst = new List<clsvQuestionOptionsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionOptionsEN objvQuestionOptionsEN = new clsvQuestionOptionsEN();
try
{
objvQuestionOptionsEN.QuestionOptionId = objRow[convQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objvQuestionOptionsEN.OptionName = objRow[convQuestionOptions.OptionName].ToString().Trim(); //选项名称
objvQuestionOptionsEN.QuestionId = objRow[convQuestionOptions.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objvQuestionOptionsEN.QuestionName = objRow[convQuestionOptions.QuestionName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionName].ToString().Trim(); //题目名称
objvQuestionOptionsEN.QuestionMemo = objRow[convQuestionOptions.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionOptionsEN.CourseId = objRow[convQuestionOptions.CourseId] == DBNull.Value ? null : objRow[convQuestionOptions.CourseId].ToString().Trim(); //课程Id
objvQuestionOptionsEN.QuestionTypeId = objRow[convQuestionOptions.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionOptionsEN.QuestionTypeName = objRow[convQuestionOptions.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionOptionsEN.QuestionTypeId4Course = objRow[convQuestionOptions.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionOptionsEN.GridTitle = objRow[convQuestionOptions.GridTitle] == DBNull.Value ? null : objRow[convQuestionOptions.GridTitle].ToString().Trim(); //表格标题
objvQuestionOptionsEN.QuestionScore = objRow[convQuestionOptions.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionOptions.QuestionScore].ToString().Trim()); //题目得分
objvQuestionOptionsEN.OptionIndex = Int32.Parse(objRow[convQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objvQuestionOptionsEN.OptionTitle = objRow[convQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[convQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objvQuestionOptionsEN.OptionContent = objRow[convQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[convQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objvQuestionOptionsEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[convQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objvQuestionOptionsEN.Score = objRow[convQuestionOptions.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convQuestionOptions.Score].ToString().Trim()); //得分
objvQuestionOptionsEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionOptions.IsShow].ToString().Trim()); //是否启用
objvQuestionOptionsEN.UpdDate = objRow[convQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objvQuestionOptionsEN.UpdUser = objRow[convQuestionOptions.UpdUser].ToString().Trim(); //修改人
objvQuestionOptionsEN.Memo = objRow[convQuestionOptions.Memo] == DBNull.Value ? null : objRow[convQuestionOptions.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionOptionsEN.QuestionOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionOptionsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQuestionOptions(ref clsvQuestionOptionsEN objvQuestionOptionsEN)
{
bool bolResult = vQuestionOptionsDA.GetvQuestionOptions(ref objvQuestionOptionsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strQuestionOptionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionOptionsEN GetObjByQuestionOptionId(string strQuestionOptionId)
{
if (strQuestionOptionId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strQuestionOptionId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strQuestionOptionId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strQuestionOptionId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvQuestionOptionsEN objvQuestionOptionsEN = vQuestionOptionsDA.GetObjByQuestionOptionId(strQuestionOptionId);
return objvQuestionOptionsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQuestionOptionsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQuestionOptionsEN objvQuestionOptionsEN = vQuestionOptionsDA.GetFirstObj(strWhereCond);
 return objvQuestionOptionsEN;
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
public static clsvQuestionOptionsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQuestionOptionsEN objvQuestionOptionsEN = vQuestionOptionsDA.GetObjByDataRow(objRow);
 return objvQuestionOptionsEN;
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
public static clsvQuestionOptionsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQuestionOptionsEN objvQuestionOptionsEN = vQuestionOptionsDA.GetObjByDataRow(objRow);
 return objvQuestionOptionsEN;
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
 /// <param name = "strQuestionOptionId">所给的关键字</param>
 /// <param name = "lstvQuestionOptionsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionOptionsEN GetObjByQuestionOptionIdFromList(string strQuestionOptionId, List<clsvQuestionOptionsEN> lstvQuestionOptionsObjLst)
{
foreach (clsvQuestionOptionsEN objvQuestionOptionsEN in lstvQuestionOptionsObjLst)
{
if (objvQuestionOptionsEN.QuestionOptionId == strQuestionOptionId)
{
return objvQuestionOptionsEN;
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
 string strQuestionOptionId;
 try
 {
 strQuestionOptionId = new clsvQuestionOptionsDA().GetFirstID(strWhereCond);
 return strQuestionOptionId;
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
 arrList = vQuestionOptionsDA.GetID(strWhereCond);
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
bool bolIsExist = vQuestionOptionsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strQuestionOptionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strQuestionOptionId)
{
if (string.IsNullOrEmpty(strQuestionOptionId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strQuestionOptionId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vQuestionOptionsDA.IsExist(strQuestionOptionId);
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
 bolIsExist = clsvQuestionOptionsDA.IsExistTable();
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
 bolIsExist = vQuestionOptionsDA.IsExistTable(strTabName);
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
 /// <param name = "objvQuestionOptionsENS">源对象</param>
 /// <param name = "objvQuestionOptionsENT">目标对象</param>
 public static void CopyTo(clsvQuestionOptionsEN objvQuestionOptionsENS, clsvQuestionOptionsEN objvQuestionOptionsENT)
{
try
{
objvQuestionOptionsENT.QuestionOptionId = objvQuestionOptionsENS.QuestionOptionId; //题目选项Id
objvQuestionOptionsENT.OptionName = objvQuestionOptionsENS.OptionName; //选项名称
objvQuestionOptionsENT.QuestionId = objvQuestionOptionsENS.QuestionId; //题目Id
objvQuestionOptionsENT.QuestionName = objvQuestionOptionsENS.QuestionName; //题目名称
objvQuestionOptionsENT.QuestionMemo = objvQuestionOptionsENS.QuestionMemo; //题目说明
objvQuestionOptionsENT.CourseId = objvQuestionOptionsENS.CourseId; //课程Id
objvQuestionOptionsENT.QuestionTypeId = objvQuestionOptionsENS.QuestionTypeId; //题目类型Id
objvQuestionOptionsENT.QuestionTypeName = objvQuestionOptionsENS.QuestionTypeName; //题目类型名
objvQuestionOptionsENT.QuestionTypeId4Course = objvQuestionOptionsENS.QuestionTypeId4Course; //题目类型Id4课程
objvQuestionOptionsENT.GridTitle = objvQuestionOptionsENS.GridTitle; //表格标题
objvQuestionOptionsENT.QuestionScore = objvQuestionOptionsENS.QuestionScore; //题目得分
objvQuestionOptionsENT.OptionIndex = objvQuestionOptionsENS.OptionIndex; //选项序号
objvQuestionOptionsENT.OptionTitle = objvQuestionOptionsENS.OptionTitle; //选项标题
objvQuestionOptionsENT.OptionContent = objvQuestionOptionsENS.OptionContent; //选项内容
objvQuestionOptionsENT.IsCorrect = objvQuestionOptionsENS.IsCorrect; //是否正确
objvQuestionOptionsENT.Score = objvQuestionOptionsENS.Score; //得分
objvQuestionOptionsENT.IsShow = objvQuestionOptionsENS.IsShow; //是否启用
objvQuestionOptionsENT.UpdDate = objvQuestionOptionsENS.UpdDate; //修改日期
objvQuestionOptionsENT.UpdUser = objvQuestionOptionsENS.UpdUser; //修改人
objvQuestionOptionsENT.Memo = objvQuestionOptionsENS.Memo; //备注
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
 /// <param name = "objvQuestionOptionsEN">源简化对象</param>
 public static void SetUpdFlag(clsvQuestionOptionsEN objvQuestionOptionsEN)
{
try
{
objvQuestionOptionsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQuestionOptionsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQuestionOptions.QuestionOptionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionOptionsEN.QuestionOptionId = objvQuestionOptionsEN.QuestionOptionId; //题目选项Id
}
if (arrFldSet.Contains(convQuestionOptions.OptionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionOptionsEN.OptionName = objvQuestionOptionsEN.OptionName; //选项名称
}
if (arrFldSet.Contains(convQuestionOptions.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionOptionsEN.QuestionId = objvQuestionOptionsEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(convQuestionOptions.QuestionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionOptionsEN.QuestionName = objvQuestionOptionsEN.QuestionName == "[null]" ? null :  objvQuestionOptionsEN.QuestionName; //题目名称
}
if (arrFldSet.Contains(convQuestionOptions.QuestionMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionOptionsEN.QuestionMemo = objvQuestionOptionsEN.QuestionMemo == "[null]" ? null :  objvQuestionOptionsEN.QuestionMemo; //题目说明
}
if (arrFldSet.Contains(convQuestionOptions.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionOptionsEN.CourseId = objvQuestionOptionsEN.CourseId == "[null]" ? null :  objvQuestionOptionsEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convQuestionOptions.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionOptionsEN.QuestionTypeId = objvQuestionOptionsEN.QuestionTypeId == "[null]" ? null :  objvQuestionOptionsEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(convQuestionOptions.QuestionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionOptionsEN.QuestionTypeName = objvQuestionOptionsEN.QuestionTypeName == "[null]" ? null :  objvQuestionOptionsEN.QuestionTypeName; //题目类型名
}
if (arrFldSet.Contains(convQuestionOptions.QuestionTypeId4Course, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionOptionsEN.QuestionTypeId4Course = objvQuestionOptionsEN.QuestionTypeId4Course == "[null]" ? null :  objvQuestionOptionsEN.QuestionTypeId4Course; //题目类型Id4课程
}
if (arrFldSet.Contains(convQuestionOptions.GridTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionOptionsEN.GridTitle = objvQuestionOptionsEN.GridTitle == "[null]" ? null :  objvQuestionOptionsEN.GridTitle; //表格标题
}
if (arrFldSet.Contains(convQuestionOptions.QuestionScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionOptionsEN.QuestionScore = objvQuestionOptionsEN.QuestionScore; //题目得分
}
if (arrFldSet.Contains(convQuestionOptions.OptionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionOptionsEN.OptionIndex = objvQuestionOptionsEN.OptionIndex; //选项序号
}
if (arrFldSet.Contains(convQuestionOptions.OptionTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionOptionsEN.OptionTitle = objvQuestionOptionsEN.OptionTitle == "[null]" ? null :  objvQuestionOptionsEN.OptionTitle; //选项标题
}
if (arrFldSet.Contains(convQuestionOptions.OptionContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionOptionsEN.OptionContent = objvQuestionOptionsEN.OptionContent == "[null]" ? null :  objvQuestionOptionsEN.OptionContent; //选项内容
}
if (arrFldSet.Contains(convQuestionOptions.IsCorrect, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionOptionsEN.IsCorrect = objvQuestionOptionsEN.IsCorrect; //是否正确
}
if (arrFldSet.Contains(convQuestionOptions.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionOptionsEN.Score = objvQuestionOptionsEN.Score; //得分
}
if (arrFldSet.Contains(convQuestionOptions.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionOptionsEN.IsShow = objvQuestionOptionsEN.IsShow; //是否启用
}
if (arrFldSet.Contains(convQuestionOptions.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionOptionsEN.UpdDate = objvQuestionOptionsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQuestionOptions.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionOptionsEN.UpdUser = objvQuestionOptionsEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convQuestionOptions.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionOptionsEN.Memo = objvQuestionOptionsEN.Memo == "[null]" ? null :  objvQuestionOptionsEN.Memo; //备注
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
 /// <param name = "objvQuestionOptionsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQuestionOptionsEN objvQuestionOptionsEN)
{
try
{
if (objvQuestionOptionsEN.QuestionName == "[null]") objvQuestionOptionsEN.QuestionName = null; //题目名称
if (objvQuestionOptionsEN.QuestionMemo == "[null]") objvQuestionOptionsEN.QuestionMemo = null; //题目说明
if (objvQuestionOptionsEN.CourseId == "[null]") objvQuestionOptionsEN.CourseId = null; //课程Id
if (objvQuestionOptionsEN.QuestionTypeId == "[null]") objvQuestionOptionsEN.QuestionTypeId = null; //题目类型Id
if (objvQuestionOptionsEN.QuestionTypeName == "[null]") objvQuestionOptionsEN.QuestionTypeName = null; //题目类型名
if (objvQuestionOptionsEN.QuestionTypeId4Course == "[null]") objvQuestionOptionsEN.QuestionTypeId4Course = null; //题目类型Id4课程
if (objvQuestionOptionsEN.GridTitle == "[null]") objvQuestionOptionsEN.GridTitle = null; //表格标题
if (objvQuestionOptionsEN.OptionTitle == "[null]") objvQuestionOptionsEN.OptionTitle = null; //选项标题
if (objvQuestionOptionsEN.OptionContent == "[null]") objvQuestionOptionsEN.OptionContent = null; //选项内容
if (objvQuestionOptionsEN.Memo == "[null]") objvQuestionOptionsEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQuestionOptionsEN objvQuestionOptionsEN)
{
 vQuestionOptionsDA.CheckProperty4Condition(objvQuestionOptionsEN);
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
//string strWhereCond = string.Format("1 = 1 order by QuestionOptionId");
//if (arrvQuestionOptionsObjLstCache == null)
//{
//arrvQuestionOptionsObjLstCache = vQuestionOptionsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strQuestionOptionId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionOptionsEN GetObjByQuestionOptionIdCache(string strQuestionOptionId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvQuestionOptionsEN._CurrTabName, strCourseId);
List<clsvQuestionOptionsEN> arrvQuestionOptionsObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionOptionsEN> arrvQuestionOptionsObjLst_Sel =
arrvQuestionOptionsObjLstCache
.Where(x=> x.QuestionOptionId == strQuestionOptionId 
);
if (arrvQuestionOptionsObjLst_Sel.Count() == 0)
{
   clsvQuestionOptionsEN obj = clsvQuestionOptionsBL.GetObjByQuestionOptionId(strQuestionOptionId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strQuestionOptionId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvQuestionOptionsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionOptionsEN> GetAllvQuestionOptionsObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvQuestionOptionsEN> arrvQuestionOptionsObjLstCache = GetObjLstCache(strCourseId); 
return arrvQuestionOptionsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionOptionsEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvQuestionOptionsEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvQuestionOptionsEN> arrvQuestionOptionsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvQuestionOptionsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvQuestionOptionsEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsvQuestionOptionsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvQuestionOptionsEN._RefreshTimeLst.Count == 0) return "";
return clsvQuestionOptionsEN._RefreshTimeLst[clsvQuestionOptionsEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, string strQuestionOptionId, string strCourseId)
{
if (strInFldName != convQuestionOptions.QuestionOptionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQuestionOptions.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQuestionOptions.AttributeName));
throw new Exception(strMsg);
}
var objvQuestionOptions = clsvQuestionOptionsBL.GetObjByQuestionOptionIdCache(strQuestionOptionId, strCourseId);
if (objvQuestionOptions == null) return "";
return objvQuestionOptions[strOutFldName].ToString();
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
int intRecCount = clsvQuestionOptionsDA.GetRecCount(strTabName);
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
int intRecCount = clsvQuestionOptionsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQuestionOptionsDA.GetRecCount();
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
int intRecCount = clsvQuestionOptionsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQuestionOptionsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQuestionOptionsEN objvQuestionOptionsCond)
{
 string strCourseId = objvQuestionOptionsCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvQuestionOptionsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvQuestionOptionsEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionOptionsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionOptions.AttributeName)
{
if (objvQuestionOptionsCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionOptionsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionOptionsCond[strFldName].ToString());
}
else
{
if (objvQuestionOptionsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionOptionsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionOptionsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionOptionsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionOptionsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionOptionsCond[strFldName]));
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
 List<string> arrList = clsvQuestionOptionsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQuestionOptionsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQuestionOptionsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}