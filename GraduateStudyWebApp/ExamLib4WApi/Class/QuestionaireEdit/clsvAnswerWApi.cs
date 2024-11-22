
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvAnswerWApi
 表名:vAnswer(01120017)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:49:07
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
public static class clsvAnswerWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetAnswerContent(this clsvAnswerEN objvAnswerEN, string strAnswerContent, string strComparisonOp="")
	{
objvAnswerEN.AnswerContent = strAnswerContent; //答案内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.AnswerContent) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.AnswerContent, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.AnswerContent] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetAnswerID(this clsvAnswerEN objvAnswerEN, long lngAnswerID, string strComparisonOp="")
	{
objvAnswerEN.AnswerID = lngAnswerID; //问答ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.AnswerID) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.AnswerID, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.AnswerID] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetQuestionID(this clsvAnswerEN objvAnswerEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convAnswer.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convAnswer.QuestionID);
objvAnswerEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.QuestionID) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.QuestionID, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.QuestionID] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetQuestionName(this clsvAnswerEN objvAnswerEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convAnswer.QuestionName);
objvAnswerEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.QuestionName) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.QuestionName, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.QuestionName] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetQuestionMemo(this clsvAnswerEN objvAnswerEN, string strQuestionMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionMemo, 1000, convAnswer.QuestionMemo);
objvAnswerEN.QuestionMemo = strQuestionMemo; //题目说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.QuestionMemo) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.QuestionMemo, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.QuestionMemo] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetQuestionTypeId(this clsvAnswerEN objvAnswerEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convAnswer.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convAnswer.QuestionTypeId);
objvAnswerEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.QuestionTypeId) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.QuestionTypeId, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.QuestionTypeId] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetQuestionTypeName(this clsvAnswerEN objvAnswerEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convAnswer.QuestionTypeName);
objvAnswerEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.QuestionTypeName) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.QuestionTypeName, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.QuestionTypeName] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetAnswerTypeId(this clsvAnswerEN objvAnswerEN, string strAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convAnswer.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convAnswer.AnswerTypeId);
objvAnswerEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.AnswerTypeId) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.AnswerTypeId, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.AnswerTypeId] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetAnswerTypeName(this clsvAnswerEN objvAnswerEN, string strAnswerTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeName, 50, convAnswer.AnswerTypeName);
objvAnswerEN.AnswerTypeName = strAnswerTypeName; //答案类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.AnswerTypeName) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.AnswerTypeName, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.AnswerTypeName] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetGridTitle(this clsvAnswerEN objvAnswerEN, string strGridTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGridTitle, 30, convAnswer.GridTitle);
objvAnswerEN.GridTitle = strGridTitle; //表格标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.GridTitle) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.GridTitle, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.GridTitle] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetAnswerModeId(this clsvAnswerEN objvAnswerEN, string strAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convAnswer.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convAnswer.AnswerModeId);
objvAnswerEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.AnswerModeId) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.AnswerModeId, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.AnswerModeId] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetQuestionScore(this clsvAnswerEN objvAnswerEN, float fltQuestionScore, string strComparisonOp="")
	{
objvAnswerEN.QuestionScore = fltQuestionScore; //题目得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.QuestionScore) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.QuestionScore, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.QuestionScore] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetAnswerIndex(this clsvAnswerEN objvAnswerEN, int intAnswerIndex, string strComparisonOp="")
	{
objvAnswerEN.AnswerIndex = intAnswerIndex; //问答序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.AnswerIndex) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.AnswerIndex, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.AnswerIndex] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetAnswerOptionId(this clsvAnswerEN objvAnswerEN, string strAnswerOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerOptionId, 8, convAnswer.AnswerOptionId);
clsCheckSql.CheckFieldForeignKey(strAnswerOptionId, 8, convAnswer.AnswerOptionId);
objvAnswerEN.AnswerOptionId = strAnswerOptionId; //回答选项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.AnswerOptionId) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.AnswerOptionId, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.AnswerOptionId] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetOptionName(this clsvAnswerEN objvAnswerEN, string strOptionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOptionName, 4000, convAnswer.OptionName);
objvAnswerEN.OptionName = strOptionName; //选项名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.OptionName) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.OptionName, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.OptionName] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetOptionTitle(this clsvAnswerEN objvAnswerEN, string strOptionTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOptionTitle, 20, convAnswer.OptionTitle);
objvAnswerEN.OptionTitle = strOptionTitle; //选项标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.OptionTitle) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.OptionTitle, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.OptionTitle] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetAnswerMultiOptions(this clsvAnswerEN objvAnswerEN, string strAnswerMultiOptions, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerMultiOptions, 300, convAnswer.AnswerMultiOptions);
objvAnswerEN.AnswerMultiOptions = strAnswerMultiOptions; //多选项答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.AnswerMultiOptions) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.AnswerMultiOptions, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.AnswerMultiOptions] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetIsAutoCorrect(this clsvAnswerEN objvAnswerEN, bool bolIsAutoCorrect, string strComparisonOp="")
	{
objvAnswerEN.IsAutoCorrect = bolIsAutoCorrect; //是否支持自动批改
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.IsAutoCorrect) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.IsAutoCorrect, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.IsAutoCorrect] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetAnswerFillInBlank(this clsvAnswerEN objvAnswerEN, string strAnswerFillInBlank, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerFillInBlank, 1000, convAnswer.AnswerFillInBlank);
objvAnswerEN.AnswerFillInBlank = strAnswerFillInBlank; //填空题答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.AnswerFillInBlank) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.AnswerFillInBlank, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.AnswerFillInBlank] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetAnswerTrueOrFalse(this clsvAnswerEN objvAnswerEN, bool bolAnswerTrueOrFalse, string strComparisonOp="")
	{
objvAnswerEN.AnswerTrueOrFalse = bolAnswerTrueOrFalse; //判断题答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.AnswerTrueOrFalse) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.AnswerTrueOrFalse, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.AnswerTrueOrFalse] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetProvider(this clsvAnswerEN objvAnswerEN, string strProvider, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProvider, 18, convAnswer.Provider);
objvAnswerEN.Provider = strProvider; //提供者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.Provider) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.Provider, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.Provider] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetScore(this clsvAnswerEN objvAnswerEN, double dblScore, string strComparisonOp="")
	{
objvAnswerEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.Score) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.Score, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.Score] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetIsShow(this clsvAnswerEN objvAnswerEN, bool bolIsShow, string strComparisonOp="")
	{
objvAnswerEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.IsShow) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.IsShow, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.IsShow] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetCourseId(this clsvAnswerEN objvAnswerEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convAnswer.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convAnswer.CourseId);
objvAnswerEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.CourseId) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.CourseId, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.CourseId] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetUpdDate(this clsvAnswerEN objvAnswerEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convAnswer.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convAnswer.UpdDate);
objvAnswerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.UpdDate) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.UpdDate, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.UpdDate] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetUpdUser(this clsvAnswerEN objvAnswerEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convAnswer.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convAnswer.UpdUser);
objvAnswerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.UpdUser) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.UpdUser, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.UpdUser] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAnswerEN SetMemo(this clsvAnswerEN objvAnswerEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convAnswer.Memo);
objvAnswerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.Memo) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.Memo, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.Memo] = strComparisonOp;
}
}
return objvAnswerEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvAnswerEN objvAnswer_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvAnswer_Cond.IsUpdated(convAnswer.AnswerID) == true)
{
string strComparisonOp_AnswerID = objvAnswer_Cond.dicFldComparisonOp[convAnswer.AnswerID];
strWhereCond += string.Format(" And {0} {2} {1}", convAnswer.AnswerID, objvAnswer_Cond.AnswerID, strComparisonOp_AnswerID);
}
if (objvAnswer_Cond.IsUpdated(convAnswer.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvAnswer_Cond.dicFldComparisonOp[convAnswer.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.QuestionID, objvAnswer_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvAnswer_Cond.IsUpdated(convAnswer.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvAnswer_Cond.dicFldComparisonOp[convAnswer.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.QuestionName, objvAnswer_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvAnswer_Cond.IsUpdated(convAnswer.QuestionMemo) == true)
{
string strComparisonOp_QuestionMemo = objvAnswer_Cond.dicFldComparisonOp[convAnswer.QuestionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.QuestionMemo, objvAnswer_Cond.QuestionMemo, strComparisonOp_QuestionMemo);
}
if (objvAnswer_Cond.IsUpdated(convAnswer.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvAnswer_Cond.dicFldComparisonOp[convAnswer.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.QuestionTypeId, objvAnswer_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvAnswer_Cond.IsUpdated(convAnswer.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvAnswer_Cond.dicFldComparisonOp[convAnswer.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.QuestionTypeName, objvAnswer_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvAnswer_Cond.IsUpdated(convAnswer.AnswerTypeId) == true)
{
string strComparisonOp_AnswerTypeId = objvAnswer_Cond.dicFldComparisonOp[convAnswer.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.AnswerTypeId, objvAnswer_Cond.AnswerTypeId, strComparisonOp_AnswerTypeId);
}
if (objvAnswer_Cond.IsUpdated(convAnswer.AnswerTypeName) == true)
{
string strComparisonOp_AnswerTypeName = objvAnswer_Cond.dicFldComparisonOp[convAnswer.AnswerTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.AnswerTypeName, objvAnswer_Cond.AnswerTypeName, strComparisonOp_AnswerTypeName);
}
if (objvAnswer_Cond.IsUpdated(convAnswer.GridTitle) == true)
{
string strComparisonOp_GridTitle = objvAnswer_Cond.dicFldComparisonOp[convAnswer.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.GridTitle, objvAnswer_Cond.GridTitle, strComparisonOp_GridTitle);
}
if (objvAnswer_Cond.IsUpdated(convAnswer.AnswerModeId) == true)
{
string strComparisonOp_AnswerModeId = objvAnswer_Cond.dicFldComparisonOp[convAnswer.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.AnswerModeId, objvAnswer_Cond.AnswerModeId, strComparisonOp_AnswerModeId);
}
if (objvAnswer_Cond.IsUpdated(convAnswer.QuestionScore) == true)
{
string strComparisonOp_QuestionScore = objvAnswer_Cond.dicFldComparisonOp[convAnswer.QuestionScore];
strWhereCond += string.Format(" And {0} {2} {1}", convAnswer.QuestionScore, objvAnswer_Cond.QuestionScore, strComparisonOp_QuestionScore);
}
if (objvAnswer_Cond.IsUpdated(convAnswer.AnswerIndex) == true)
{
string strComparisonOp_AnswerIndex = objvAnswer_Cond.dicFldComparisonOp[convAnswer.AnswerIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convAnswer.AnswerIndex, objvAnswer_Cond.AnswerIndex, strComparisonOp_AnswerIndex);
}
if (objvAnswer_Cond.IsUpdated(convAnswer.AnswerOptionId) == true)
{
string strComparisonOp_AnswerOptionId = objvAnswer_Cond.dicFldComparisonOp[convAnswer.AnswerOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.AnswerOptionId, objvAnswer_Cond.AnswerOptionId, strComparisonOp_AnswerOptionId);
}
if (objvAnswer_Cond.IsUpdated(convAnswer.OptionName) == true)
{
string strComparisonOp_OptionName = objvAnswer_Cond.dicFldComparisonOp[convAnswer.OptionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.OptionName, objvAnswer_Cond.OptionName, strComparisonOp_OptionName);
}
if (objvAnswer_Cond.IsUpdated(convAnswer.OptionTitle) == true)
{
string strComparisonOp_OptionTitle = objvAnswer_Cond.dicFldComparisonOp[convAnswer.OptionTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.OptionTitle, objvAnswer_Cond.OptionTitle, strComparisonOp_OptionTitle);
}
if (objvAnswer_Cond.IsUpdated(convAnswer.AnswerMultiOptions) == true)
{
string strComparisonOp_AnswerMultiOptions = objvAnswer_Cond.dicFldComparisonOp[convAnswer.AnswerMultiOptions];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.AnswerMultiOptions, objvAnswer_Cond.AnswerMultiOptions, strComparisonOp_AnswerMultiOptions);
}
if (objvAnswer_Cond.IsUpdated(convAnswer.IsAutoCorrect) == true)
{
if (objvAnswer_Cond.IsAutoCorrect == true)
{
strWhereCond += string.Format(" And {0} = '1'", convAnswer.IsAutoCorrect);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convAnswer.IsAutoCorrect);
}
}
if (objvAnswer_Cond.IsUpdated(convAnswer.AnswerFillInBlank) == true)
{
string strComparisonOp_AnswerFillInBlank = objvAnswer_Cond.dicFldComparisonOp[convAnswer.AnswerFillInBlank];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.AnswerFillInBlank, objvAnswer_Cond.AnswerFillInBlank, strComparisonOp_AnswerFillInBlank);
}
if (objvAnswer_Cond.IsUpdated(convAnswer.AnswerTrueOrFalse) == true)
{
if (objvAnswer_Cond.AnswerTrueOrFalse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convAnswer.AnswerTrueOrFalse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convAnswer.AnswerTrueOrFalse);
}
}
if (objvAnswer_Cond.IsUpdated(convAnswer.Provider) == true)
{
string strComparisonOp_Provider = objvAnswer_Cond.dicFldComparisonOp[convAnswer.Provider];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.Provider, objvAnswer_Cond.Provider, strComparisonOp_Provider);
}
if (objvAnswer_Cond.IsUpdated(convAnswer.Score) == true)
{
string strComparisonOp_Score = objvAnswer_Cond.dicFldComparisonOp[convAnswer.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convAnswer.Score, objvAnswer_Cond.Score, strComparisonOp_Score);
}
if (objvAnswer_Cond.IsUpdated(convAnswer.IsShow) == true)
{
if (objvAnswer_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convAnswer.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convAnswer.IsShow);
}
}
if (objvAnswer_Cond.IsUpdated(convAnswer.CourseId) == true)
{
string strComparisonOp_CourseId = objvAnswer_Cond.dicFldComparisonOp[convAnswer.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.CourseId, objvAnswer_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvAnswer_Cond.IsUpdated(convAnswer.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvAnswer_Cond.dicFldComparisonOp[convAnswer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.UpdDate, objvAnswer_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvAnswer_Cond.IsUpdated(convAnswer.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvAnswer_Cond.dicFldComparisonOp[convAnswer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.UpdUser, objvAnswer_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvAnswer_Cond.IsUpdated(convAnswer.Memo) == true)
{
string strComparisonOp_Memo = objvAnswer_Cond.dicFldComparisonOp[convAnswer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.Memo, objvAnswer_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v答案(vAnswer)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvAnswerWApi
{
private static readonly string mstrApiControllerName = "vAnswerApi";

 public clsvAnswerWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngAnswerID">表关键字</param>
 /// <returns>表对象</returns>
public static clsvAnswerEN GetObjByAnswerID(long lngAnswerID)
{
string strAction = "GetObjByAnswerID";
string strErrMsg = string.Empty;
string strResult = "";
clsvAnswerEN objvAnswerEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["AnswerID"] = lngAnswerID.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvAnswerEN = JsonConvert.DeserializeObject<clsvAnswerEN>((string)jobjReturn["ReturnObj"]);
return objvAnswerEN;
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
 /// <param name = "lngAnswerID">表关键字</param>
 /// <returns>表对象</returns>
public static clsvAnswerEN GetObjByAnswerID_WA_Cache(long lngAnswerID, string strCourseId)
{
string strAction = "GetObjByAnswerID_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvAnswerEN objvAnswerEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["AnswerID"] = lngAnswerID.ToString(),
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvAnswerEN = JsonConvert.DeserializeObject<clsvAnswerEN>((string)jobjReturn["ReturnObj"]);
return objvAnswerEN;
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
public static clsvAnswerEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvAnswerEN objvAnswerEN = null;
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
objvAnswerEN = JsonConvert.DeserializeObject<clsvAnswerEN>((string)jobjReturn["ReturnObj"]);
return objvAnswerEN;
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
 /// <param name = "lngAnswerID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvAnswerEN GetObjByAnswerID_Cache(long lngAnswerID, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvAnswerEN._CurrTabName_S, strCourseId);
List<clsvAnswerEN> arrvAnswerObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvAnswerEN> arrvAnswerObjLst_Sel =
from objvAnswerEN in arrvAnswerObjLst_Cache
where objvAnswerEN.AnswerID == lngAnswerID
select objvAnswerEN;
if (arrvAnswerObjLst_Sel.Count() == 0)
{
   clsvAnswerEN obj = clsvAnswerWApi.GetObjByAnswerID(lngAnswerID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvAnswerObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvAnswerEN> GetObjLst(string strWhereCond)
{
 List<clsvAnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvAnswerEN> GetObjLstByAnswerIDLst(List<long> arrAnswerID)
{
 List<clsvAnswerEN> arrObjLst = null; 
string strAction = "GetObjLstByAnswerIDLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrAnswerID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvAnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngAnswerID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvAnswerEN> GetObjLstByAnswerIDLst_Cache(List<long> arrAnswerID, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvAnswerEN._CurrTabName_S, strCourseId);
List<clsvAnswerEN> arrvAnswerObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvAnswerEN> arrvAnswerObjLst_Sel =
from objvAnswerEN in arrvAnswerObjLst_Cache
where arrAnswerID.Contains(objvAnswerEN.AnswerID)
select objvAnswerEN;
return arrvAnswerObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvAnswerEN> GetObjLstByAnswerIDLst_WA_Cache(List<long> arrAnswerID, string strCourseId)
{
 List<clsvAnswerEN> arrObjLst = null; 
string strAction = "GetObjLstByAnswerIDLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrAnswerID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvAnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvAnswerEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvAnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvAnswerEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvAnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvAnswerEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvAnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvAnswerEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvAnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngAnswerID)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["AnswerID"] = lngAnswerID.ToString()
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
 /// <param name = "objvAnswerENS">源对象</param>
 /// <param name = "objvAnswerENT">目标对象</param>
 public static void CopyTo(clsvAnswerEN objvAnswerENS, clsvAnswerEN objvAnswerENT)
{
try
{
objvAnswerENT.AnswerContent = objvAnswerENS.AnswerContent; //答案内容
objvAnswerENT.AnswerID = objvAnswerENS.AnswerID; //问答ID
objvAnswerENT.QuestionID = objvAnswerENS.QuestionID; //题目ID
objvAnswerENT.QuestionName = objvAnswerENS.QuestionName; //题目名称
objvAnswerENT.QuestionMemo = objvAnswerENS.QuestionMemo; //题目说明
objvAnswerENT.QuestionTypeId = objvAnswerENS.QuestionTypeId; //题目类型Id
objvAnswerENT.QuestionTypeName = objvAnswerENS.QuestionTypeName; //题目类型名
objvAnswerENT.AnswerTypeId = objvAnswerENS.AnswerTypeId; //答案类型ID
objvAnswerENT.AnswerTypeName = objvAnswerENS.AnswerTypeName; //答案类型名
objvAnswerENT.GridTitle = objvAnswerENS.GridTitle; //表格标题
objvAnswerENT.AnswerModeId = objvAnswerENS.AnswerModeId; //答案模式Id
objvAnswerENT.QuestionScore = objvAnswerENS.QuestionScore; //题目得分
objvAnswerENT.AnswerIndex = objvAnswerENS.AnswerIndex; //问答序号
objvAnswerENT.AnswerOptionId = objvAnswerENS.AnswerOptionId; //回答选项Id
objvAnswerENT.OptionName = objvAnswerENS.OptionName; //选项名称
objvAnswerENT.OptionTitle = objvAnswerENS.OptionTitle; //选项标题
objvAnswerENT.AnswerMultiOptions = objvAnswerENS.AnswerMultiOptions; //多选项答案
objvAnswerENT.IsAutoCorrect = objvAnswerENS.IsAutoCorrect; //是否支持自动批改
objvAnswerENT.AnswerFillInBlank = objvAnswerENS.AnswerFillInBlank; //填空题答案
objvAnswerENT.AnswerTrueOrFalse = objvAnswerENS.AnswerTrueOrFalse; //判断题答案
objvAnswerENT.Provider = objvAnswerENS.Provider; //提供者
objvAnswerENT.Score = objvAnswerENS.Score; //得分
objvAnswerENT.IsShow = objvAnswerENS.IsShow; //是否启用
objvAnswerENT.CourseId = objvAnswerENS.CourseId; //课程Id
objvAnswerENT.UpdDate = objvAnswerENS.UpdDate; //修改日期
objvAnswerENT.UpdUser = objvAnswerENS.UpdUser; //修改人
objvAnswerENT.Memo = objvAnswerENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvAnswerEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvAnswerEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvAnswerEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvAnswerEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvAnswerEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvAnswerEN.AttributeName)
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
if (clsAnswerWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerWApi没有刷新缓存机制(clsAnswerWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
//string strWhereCond = string.Format("1 = 1 order by AnswerID");
//if (arrvAnswerObjLst_Cache == null)
//{
//arrvAnswerObjLst_Cache = await clsvAnswerWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvAnswerEN._CurrTabName_S, strCourseId);
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
public static List<clsvAnswerEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvAnswerEN._CurrTabName_S, strCourseId);
List<clsvAnswerEN> arrvAnswerObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvAnswerObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvAnswerEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convAnswer.AnswerContent, Type.GetType("System.String"));
objDT.Columns.Add(convAnswer.AnswerID, Type.GetType("System.Int64"));
objDT.Columns.Add(convAnswer.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convAnswer.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convAnswer.QuestionMemo, Type.GetType("System.String"));
objDT.Columns.Add(convAnswer.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convAnswer.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convAnswer.AnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convAnswer.AnswerTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convAnswer.GridTitle, Type.GetType("System.String"));
objDT.Columns.Add(convAnswer.AnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(convAnswer.QuestionScore, Type.GetType("System.Single"));
objDT.Columns.Add(convAnswer.AnswerIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convAnswer.AnswerOptionId, Type.GetType("System.String"));
objDT.Columns.Add(convAnswer.OptionName, Type.GetType("System.String"));
objDT.Columns.Add(convAnswer.OptionTitle, Type.GetType("System.String"));
objDT.Columns.Add(convAnswer.AnswerMultiOptions, Type.GetType("System.String"));
objDT.Columns.Add(convAnswer.IsAutoCorrect, Type.GetType("System.Boolean"));
objDT.Columns.Add(convAnswer.AnswerFillInBlank, Type.GetType("System.String"));
objDT.Columns.Add(convAnswer.AnswerTrueOrFalse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convAnswer.Provider, Type.GetType("System.String"));
objDT.Columns.Add(convAnswer.Score, Type.GetType("System.Decimal"));
objDT.Columns.Add(convAnswer.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convAnswer.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convAnswer.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convAnswer.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convAnswer.Memo, Type.GetType("System.String"));
foreach (clsvAnswerEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convAnswer.AnswerContent] = objInFor[convAnswer.AnswerContent];
objDR[convAnswer.AnswerID] = objInFor[convAnswer.AnswerID];
objDR[convAnswer.QuestionID] = objInFor[convAnswer.QuestionID];
objDR[convAnswer.QuestionName] = objInFor[convAnswer.QuestionName];
objDR[convAnswer.QuestionMemo] = objInFor[convAnswer.QuestionMemo];
objDR[convAnswer.QuestionTypeId] = objInFor[convAnswer.QuestionTypeId];
objDR[convAnswer.QuestionTypeName] = objInFor[convAnswer.QuestionTypeName];
objDR[convAnswer.AnswerTypeId] = objInFor[convAnswer.AnswerTypeId];
objDR[convAnswer.AnswerTypeName] = objInFor[convAnswer.AnswerTypeName];
objDR[convAnswer.GridTitle] = objInFor[convAnswer.GridTitle];
objDR[convAnswer.AnswerModeId] = objInFor[convAnswer.AnswerModeId];
objDR[convAnswer.QuestionScore] = objInFor[convAnswer.QuestionScore];
objDR[convAnswer.AnswerIndex] = objInFor[convAnswer.AnswerIndex];
objDR[convAnswer.AnswerOptionId] = objInFor[convAnswer.AnswerOptionId];
objDR[convAnswer.OptionName] = objInFor[convAnswer.OptionName];
objDR[convAnswer.OptionTitle] = objInFor[convAnswer.OptionTitle];
objDR[convAnswer.AnswerMultiOptions] = objInFor[convAnswer.AnswerMultiOptions];
objDR[convAnswer.IsAutoCorrect] = objInFor[convAnswer.IsAutoCorrect];
objDR[convAnswer.AnswerFillInBlank] = objInFor[convAnswer.AnswerFillInBlank];
objDR[convAnswer.AnswerTrueOrFalse] = objInFor[convAnswer.AnswerTrueOrFalse];
objDR[convAnswer.Provider] = objInFor[convAnswer.Provider];
objDR[convAnswer.Score] = objInFor[convAnswer.Score];
objDR[convAnswer.IsShow] = objInFor[convAnswer.IsShow];
objDR[convAnswer.CourseId] = objInFor[convAnswer.CourseId];
objDR[convAnswer.UpdDate] = objInFor[convAnswer.UpdDate];
objDR[convAnswer.UpdUser] = objInFor[convAnswer.UpdUser];
objDR[convAnswer.Memo] = objInFor[convAnswer.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}