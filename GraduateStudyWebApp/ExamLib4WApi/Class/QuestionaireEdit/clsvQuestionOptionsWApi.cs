
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionOptionsWApi
 表名:vQuestionOptions(01120189)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:13
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护
 模块英文名:QuestionaireEdit
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
public static class clsvQuestionOptionsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionOptionsEN SetQuestionOptionId(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strQuestionOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionOptionId, 8, convQuestionOptions.QuestionOptionId);
clsCheckSql.CheckFieldForeignKey(strQuestionOptionId, 8, convQuestionOptions.QuestionOptionId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionOptionsEN SetOptionName(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strOptionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOptionName, convQuestionOptions.OptionName);
clsCheckSql.CheckFieldLen(strOptionName, 4000, convQuestionOptions.OptionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionOptionsEN SetQuestionID(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convQuestionOptions.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convQuestionOptions.QuestionID);
objvQuestionOptionsEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionOptionsEN.dicFldComparisonOp.ContainsKey(convQuestionOptions.QuestionID) == false)
{
objvQuestionOptionsEN.dicFldComparisonOp.Add(convQuestionOptions.QuestionID, strComparisonOp);
}
else
{
objvQuestionOptionsEN.dicFldComparisonOp[convQuestionOptions.QuestionID] = strComparisonOp;
}
}
return objvQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionOptionsEN SetQuestionName(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convQuestionOptions.QuestionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionOptionsEN SetQuestionMemo(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strQuestionMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionMemo, 1000, convQuestionOptions.QuestionMemo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionOptionsEN SetCourseId(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convQuestionOptions.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convQuestionOptions.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionOptionsEN SetQuestionTypeId(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convQuestionOptions.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convQuestionOptions.QuestionTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionOptionsEN SetQuestionTypeName(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convQuestionOptions.QuestionTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionOptionsEN SetQuestionTypeId4Course(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strQuestionTypeId4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId4Course, 8, convQuestionOptions.QuestionTypeId4Course);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId4Course, 8, convQuestionOptions.QuestionTypeId4Course);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionOptionsEN SetGridTitle(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strGridTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGridTitle, 30, convQuestionOptions.GridTitle);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionOptionsEN SetQuestionScore(this clsvQuestionOptionsEN objvQuestionOptionsEN, float fltQuestionScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionOptionsEN SetOptionTitle(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strOptionTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOptionTitle, 20, convQuestionOptions.OptionTitle);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionOptionsEN SetOptionContent(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strOptionContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOptionContent, 4000, convQuestionOptions.OptionContent);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionOptionsEN SetScore(this clsvQuestionOptionsEN objvQuestionOptionsEN, double dblScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionOptionsEN SetUpdDate(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQuestionOptions.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQuestionOptions.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionOptionsEN SetUpdUser(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convQuestionOptions.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQuestionOptions.UpdUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionOptionsEN SetMemo(this clsvQuestionOptionsEN objvQuestionOptionsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQuestionOptions.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionOptionsEN objvQuestionOptions_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionOptions_Cond.IsUpdated(convQuestionOptions.QuestionOptionId) == true)
{
string strComparisonOp_QuestionOptionId = objvQuestionOptions_Cond.dicFldComparisonOp[convQuestionOptions.QuestionOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.QuestionOptionId, objvQuestionOptions_Cond.QuestionOptionId, strComparisonOp_QuestionOptionId);
}
if (objvQuestionOptions_Cond.IsUpdated(convQuestionOptions.OptionName) == true)
{
string strComparisonOp_OptionName = objvQuestionOptions_Cond.dicFldComparisonOp[convQuestionOptions.OptionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.OptionName, objvQuestionOptions_Cond.OptionName, strComparisonOp_OptionName);
}
if (objvQuestionOptions_Cond.IsUpdated(convQuestionOptions.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvQuestionOptions_Cond.dicFldComparisonOp[convQuestionOptions.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.QuestionID, objvQuestionOptions_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvQuestionOptions_Cond.IsUpdated(convQuestionOptions.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvQuestionOptions_Cond.dicFldComparisonOp[convQuestionOptions.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.QuestionName, objvQuestionOptions_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvQuestionOptions_Cond.IsUpdated(convQuestionOptions.QuestionMemo) == true)
{
string strComparisonOp_QuestionMemo = objvQuestionOptions_Cond.dicFldComparisonOp[convQuestionOptions.QuestionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.QuestionMemo, objvQuestionOptions_Cond.QuestionMemo, strComparisonOp_QuestionMemo);
}
if (objvQuestionOptions_Cond.IsUpdated(convQuestionOptions.CourseId) == true)
{
string strComparisonOp_CourseId = objvQuestionOptions_Cond.dicFldComparisonOp[convQuestionOptions.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.CourseId, objvQuestionOptions_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvQuestionOptions_Cond.IsUpdated(convQuestionOptions.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvQuestionOptions_Cond.dicFldComparisonOp[convQuestionOptions.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.QuestionTypeId, objvQuestionOptions_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvQuestionOptions_Cond.IsUpdated(convQuestionOptions.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvQuestionOptions_Cond.dicFldComparisonOp[convQuestionOptions.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.QuestionTypeName, objvQuestionOptions_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvQuestionOptions_Cond.IsUpdated(convQuestionOptions.QuestionTypeId4Course) == true)
{
string strComparisonOp_QuestionTypeId4Course = objvQuestionOptions_Cond.dicFldComparisonOp[convQuestionOptions.QuestionTypeId4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.QuestionTypeId4Course, objvQuestionOptions_Cond.QuestionTypeId4Course, strComparisonOp_QuestionTypeId4Course);
}
if (objvQuestionOptions_Cond.IsUpdated(convQuestionOptions.GridTitle) == true)
{
string strComparisonOp_GridTitle = objvQuestionOptions_Cond.dicFldComparisonOp[convQuestionOptions.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.GridTitle, objvQuestionOptions_Cond.GridTitle, strComparisonOp_GridTitle);
}
if (objvQuestionOptions_Cond.IsUpdated(convQuestionOptions.QuestionScore) == true)
{
string strComparisonOp_QuestionScore = objvQuestionOptions_Cond.dicFldComparisonOp[convQuestionOptions.QuestionScore];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionOptions.QuestionScore, objvQuestionOptions_Cond.QuestionScore, strComparisonOp_QuestionScore);
}
if (objvQuestionOptions_Cond.IsUpdated(convQuestionOptions.OptionIndex) == true)
{
string strComparisonOp_OptionIndex = objvQuestionOptions_Cond.dicFldComparisonOp[convQuestionOptions.OptionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionOptions.OptionIndex, objvQuestionOptions_Cond.OptionIndex, strComparisonOp_OptionIndex);
}
if (objvQuestionOptions_Cond.IsUpdated(convQuestionOptions.OptionTitle) == true)
{
string strComparisonOp_OptionTitle = objvQuestionOptions_Cond.dicFldComparisonOp[convQuestionOptions.OptionTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.OptionTitle, objvQuestionOptions_Cond.OptionTitle, strComparisonOp_OptionTitle);
}
if (objvQuestionOptions_Cond.IsUpdated(convQuestionOptions.OptionContent) == true)
{
string strComparisonOp_OptionContent = objvQuestionOptions_Cond.dicFldComparisonOp[convQuestionOptions.OptionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.OptionContent, objvQuestionOptions_Cond.OptionContent, strComparisonOp_OptionContent);
}
if (objvQuestionOptions_Cond.IsUpdated(convQuestionOptions.IsCorrect) == true)
{
if (objvQuestionOptions_Cond.IsCorrect == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionOptions.IsCorrect);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionOptions.IsCorrect);
}
}
if (objvQuestionOptions_Cond.IsUpdated(convQuestionOptions.Score) == true)
{
string strComparisonOp_Score = objvQuestionOptions_Cond.dicFldComparisonOp[convQuestionOptions.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionOptions.Score, objvQuestionOptions_Cond.Score, strComparisonOp_Score);
}
if (objvQuestionOptions_Cond.IsUpdated(convQuestionOptions.IsShow) == true)
{
if (objvQuestionOptions_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionOptions.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionOptions.IsShow);
}
}
if (objvQuestionOptions_Cond.IsUpdated(convQuestionOptions.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvQuestionOptions_Cond.dicFldComparisonOp[convQuestionOptions.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.UpdDate, objvQuestionOptions_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvQuestionOptions_Cond.IsUpdated(convQuestionOptions.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvQuestionOptions_Cond.dicFldComparisonOp[convQuestionOptions.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.UpdUser, objvQuestionOptions_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvQuestionOptions_Cond.IsUpdated(convQuestionOptions.Memo) == true)
{
string strComparisonOp_Memo = objvQuestionOptions_Cond.dicFldComparisonOp[convQuestionOptions.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionOptions.Memo, objvQuestionOptions_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v题目选项(vQuestionOptions)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionOptionsWApi
{
private static readonly string mstrApiControllerName = "vQuestionOptionsApi";

 public clsvQuestionOptionsWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQuestionOptionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionOptionsEN GetObjByQuestionOptionId(string strQuestionOptionId)
{
string strAction = "GetObjByQuestionOptionId";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionOptionsEN objvQuestionOptionsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionOptionId"] = strQuestionOptionId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQuestionOptionsEN = JsonConvert.DeserializeObject<clsvQuestionOptionsEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionOptionsEN;
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
 /// <param name = "strQuestionOptionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionOptionsEN GetObjByQuestionOptionId_WA_Cache(string strQuestionOptionId, string strCourseId)
{
string strAction = "GetObjByQuestionOptionId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionOptionsEN objvQuestionOptionsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionOptionId"] = strQuestionOptionId,
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQuestionOptionsEN = JsonConvert.DeserializeObject<clsvQuestionOptionsEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionOptionsEN;
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
public static clsvQuestionOptionsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionOptionsEN objvQuestionOptionsEN = null;
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
objvQuestionOptionsEN = JsonConvert.DeserializeObject<clsvQuestionOptionsEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionOptionsEN;
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
 /// <param name = "strQuestionOptionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionOptionsEN GetObjByQuestionOptionId_Cache(string strQuestionOptionId, string strCourseId)
{
if (string.IsNullOrEmpty(strQuestionOptionId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvQuestionOptionsEN._CurrTabName_S, strCourseId);
List<clsvQuestionOptionsEN> arrvQuestionOptionsObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvQuestionOptionsEN> arrvQuestionOptionsObjLst_Sel =
from objvQuestionOptionsEN in arrvQuestionOptionsObjLst_Cache
where objvQuestionOptionsEN.QuestionOptionId == strQuestionOptionId
select objvQuestionOptionsEN;
if (arrvQuestionOptionsObjLst_Sel.Count() == 0)
{
   clsvQuestionOptionsEN obj = clsvQuestionOptionsWApi.GetObjByQuestionOptionId(strQuestionOptionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvQuestionOptionsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionOptionsEN> GetObjLst(string strWhereCond)
{
 List<clsvQuestionOptionsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionOptionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionOptionsEN> GetObjLstByQuestionOptionIdLst(List<string> arrQuestionOptionId)
{
 List<clsvQuestionOptionsEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionOptionIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionOptionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionOptionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strQuestionOptionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvQuestionOptionsEN> GetObjLstByQuestionOptionIdLst_Cache(List<string> arrQuestionOptionId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvQuestionOptionsEN._CurrTabName_S, strCourseId);
List<clsvQuestionOptionsEN> arrvQuestionOptionsObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvQuestionOptionsEN> arrvQuestionOptionsObjLst_Sel =
from objvQuestionOptionsEN in arrvQuestionOptionsObjLst_Cache
where arrQuestionOptionId.Contains(objvQuestionOptionsEN.QuestionOptionId)
select objvQuestionOptionsEN;
return arrvQuestionOptionsObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionOptionsEN> GetObjLstByQuestionOptionIdLst_WA_Cache(List<string> arrQuestionOptionId, string strCourseId)
{
 List<clsvQuestionOptionsEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionOptionIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionOptionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionOptionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionOptionsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQuestionOptionsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionOptionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionOptionsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQuestionOptionsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionOptionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionOptionsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQuestionOptionsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionOptionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionOptionsEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvQuestionOptionsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionOptionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strQuestionOptionId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionOptionId"] = strQuestionOptionId
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
 /// <param name = "objvQuestionOptionsENS">源对象</param>
 /// <param name = "objvQuestionOptionsENT">目标对象</param>
 public static void CopyTo(clsvQuestionOptionsEN objvQuestionOptionsENS, clsvQuestionOptionsEN objvQuestionOptionsENT)
{
try
{
objvQuestionOptionsENT.QuestionOptionId = objvQuestionOptionsENS.QuestionOptionId; //题目选项Id
objvQuestionOptionsENT.OptionName = objvQuestionOptionsENS.OptionName; //选项名称
objvQuestionOptionsENT.QuestionID = objvQuestionOptionsENS.QuestionID; //题目ID
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
public static DataTable ToDataTable(List<clsvQuestionOptionsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQuestionOptionsEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQuestionOptionsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQuestionOptionsEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQuestionOptionsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQuestionOptionsEN.AttributeName)
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
if (clsQuestionOptionsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionOptionsWApi没有刷新缓存机制(clsQuestionOptionsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by QuestionOptionId");
//if (arrvQuestionOptionsObjLst_Cache == null)
//{
//arrvQuestionOptionsObjLst_Cache = await clsvQuestionOptionsWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvQuestionOptionsEN._CurrTabName_S, strCourseId);
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
public static List<clsvQuestionOptionsEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvQuestionOptionsEN._CurrTabName_S, strCourseId);
List<clsvQuestionOptionsEN> arrvQuestionOptionsObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvQuestionOptionsObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQuestionOptionsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQuestionOptions.QuestionOptionId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionOptions.OptionName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionOptions.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionOptions.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionOptions.QuestionMemo, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionOptions.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionOptions.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionOptions.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionOptions.QuestionTypeId4Course, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionOptions.GridTitle, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionOptions.QuestionScore, Type.GetType("System.Single"));
objDT.Columns.Add(convQuestionOptions.OptionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionOptions.OptionTitle, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionOptions.OptionContent, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionOptions.IsCorrect, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQuestionOptions.Score, Type.GetType("System.Decimal"));
objDT.Columns.Add(convQuestionOptions.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQuestionOptions.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionOptions.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionOptions.Memo, Type.GetType("System.String"));
foreach (clsvQuestionOptionsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQuestionOptions.QuestionOptionId] = objInFor[convQuestionOptions.QuestionOptionId];
objDR[convQuestionOptions.OptionName] = objInFor[convQuestionOptions.OptionName];
objDR[convQuestionOptions.QuestionID] = objInFor[convQuestionOptions.QuestionID];
objDR[convQuestionOptions.QuestionName] = objInFor[convQuestionOptions.QuestionName];
objDR[convQuestionOptions.QuestionMemo] = objInFor[convQuestionOptions.QuestionMemo];
objDR[convQuestionOptions.CourseId] = objInFor[convQuestionOptions.CourseId];
objDR[convQuestionOptions.QuestionTypeId] = objInFor[convQuestionOptions.QuestionTypeId];
objDR[convQuestionOptions.QuestionTypeName] = objInFor[convQuestionOptions.QuestionTypeName];
objDR[convQuestionOptions.QuestionTypeId4Course] = objInFor[convQuestionOptions.QuestionTypeId4Course];
objDR[convQuestionOptions.GridTitle] = objInFor[convQuestionOptions.GridTitle];
objDR[convQuestionOptions.QuestionScore] = objInFor[convQuestionOptions.QuestionScore];
objDR[convQuestionOptions.OptionIndex] = objInFor[convQuestionOptions.OptionIndex];
objDR[convQuestionOptions.OptionTitle] = objInFor[convQuestionOptions.OptionTitle];
objDR[convQuestionOptions.OptionContent] = objInFor[convQuestionOptions.OptionContent];
objDR[convQuestionOptions.IsCorrect] = objInFor[convQuestionOptions.IsCorrect];
objDR[convQuestionOptions.Score] = objInFor[convQuestionOptions.Score];
objDR[convQuestionOptions.IsShow] = objInFor[convQuestionOptions.IsShow];
objDR[convQuestionOptions.UpdDate] = objInFor[convQuestionOptions.UpdDate];
objDR[convQuestionOptions.UpdUser] = objInFor[convQuestionOptions.UpdUser];
objDR[convQuestionOptions.Memo] = objInFor[convQuestionOptions.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}