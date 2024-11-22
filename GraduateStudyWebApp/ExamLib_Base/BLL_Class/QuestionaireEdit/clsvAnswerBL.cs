
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvAnswerBL
 表名:vAnswer(01120017)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:50
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
public static class  clsvAnswerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngAnswerId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvAnswerEN GetObj(this K_AnswerId_vAnswer myKey)
{
clsvAnswerEN objvAnswerEN = clsvAnswerBL.vAnswerDA.GetObjByAnswerId(myKey.Value);
return objvAnswerEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAnswerEN SetAnswerId(this clsvAnswerEN objvAnswerEN, long lngAnswerId, string strComparisonOp="")
	{
objvAnswerEN.AnswerId = lngAnswerId; //问答ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.AnswerId) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.AnswerId, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.AnswerId] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAnswerEN SetQuestionId(this clsvAnswerEN objvAnswerEN, long? lngQuestionId, string strComparisonOp="")
	{
objvAnswerEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAnswerEN.dicFldComparisonOp.ContainsKey(convAnswer.QuestionId) == false)
{
objvAnswerEN.dicFldComparisonOp.Add(convAnswer.QuestionId, strComparisonOp);
}
else
{
objvAnswerEN.dicFldComparisonOp[convAnswer.QuestionId] = strComparisonOp;
}
}
return objvAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAnswerEN SetQuestionName(this clsvAnswerEN objvAnswerEN, string strQuestionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionName, 500, convAnswer.QuestionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAnswerEN SetQuestionMemo(this clsvAnswerEN objvAnswerEN, string strQuestionMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionMemo, 1000, convAnswer.QuestionMemo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAnswerEN SetQuestionTypeId(this clsvAnswerEN objvAnswerEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convAnswer.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convAnswer.QuestionTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAnswerEN SetQuestionTypeName(this clsvAnswerEN objvAnswerEN, string strQuestionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convAnswer.QuestionTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAnswerEN SetAnswerTypeId(this clsvAnswerEN objvAnswerEN, string strAnswerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convAnswer.AnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convAnswer.AnswerTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAnswerEN SetAnswerTypeName(this clsvAnswerEN objvAnswerEN, string strAnswerTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeName, 50, convAnswer.AnswerTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAnswerEN SetGridTitle(this clsvAnswerEN objvAnswerEN, string strGridTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGridTitle, 30, convAnswer.GridTitle);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAnswerEN SetAnswerModeId(this clsvAnswerEN objvAnswerEN, string strAnswerModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convAnswer.AnswerModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convAnswer.AnswerModeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAnswerEN SetQuestionScore(this clsvAnswerEN objvAnswerEN, float? fltQuestionScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAnswerEN SetAnswerIndex(this clsvAnswerEN objvAnswerEN, int? intAnswerIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAnswerEN SetAnswerOptionId(this clsvAnswerEN objvAnswerEN, string strAnswerOptionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerOptionId, 8, convAnswer.AnswerOptionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerOptionId, 8, convAnswer.AnswerOptionId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAnswerEN SetOptionName(this clsvAnswerEN objvAnswerEN, string strOptionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOptionName, 4000, convAnswer.OptionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAnswerEN SetOptionTitle(this clsvAnswerEN objvAnswerEN, string strOptionTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOptionTitle, 20, convAnswer.OptionTitle);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAnswerEN SetAnswerMultiOptions(this clsvAnswerEN objvAnswerEN, string strAnswerMultiOptions, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerMultiOptions, 300, convAnswer.AnswerMultiOptions);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAnswerEN SetAnswerFillInBlank(this clsvAnswerEN objvAnswerEN, string strAnswerFillInBlank, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerFillInBlank, 1000, convAnswer.AnswerFillInBlank);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAnswerEN SetProvider(this clsvAnswerEN objvAnswerEN, string strProvider, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProvider, 18, convAnswer.Provider);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAnswerEN SetScore(this clsvAnswerEN objvAnswerEN, double? dblScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAnswerEN SetCourseId(this clsvAnswerEN objvAnswerEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convAnswer.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convAnswer.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAnswerEN SetUpdDate(this clsvAnswerEN objvAnswerEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convAnswer.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convAnswer.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAnswerEN SetUpdUser(this clsvAnswerEN objvAnswerEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convAnswer.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convAnswer.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAnswerEN SetMemo(this clsvAnswerEN objvAnswerEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convAnswer.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvAnswerENS">源对象</param>
 /// <param name = "objvAnswerENT">目标对象</param>
 public static void CopyTo(this clsvAnswerEN objvAnswerENS, clsvAnswerEN objvAnswerENT)
{
try
{
objvAnswerENT.AnswerContent = objvAnswerENS.AnswerContent; //答案内容
objvAnswerENT.AnswerId = objvAnswerENS.AnswerId; //问答ID
objvAnswerENT.QuestionId = objvAnswerENS.QuestionId; //题目Id
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
 /// <param name = "objvAnswerENS">源对象</param>
 /// <returns>目标对象=>clsvAnswerEN:objvAnswerENT</returns>
 public static clsvAnswerEN CopyTo(this clsvAnswerEN objvAnswerENS)
{
try
{
 clsvAnswerEN objvAnswerENT = new clsvAnswerEN()
{
AnswerContent = objvAnswerENS.AnswerContent, //答案内容
AnswerId = objvAnswerENS.AnswerId, //问答ID
QuestionId = objvAnswerENS.QuestionId, //题目Id
QuestionName = objvAnswerENS.QuestionName, //题目名称
QuestionMemo = objvAnswerENS.QuestionMemo, //题目说明
QuestionTypeId = objvAnswerENS.QuestionTypeId, //题目类型Id
QuestionTypeName = objvAnswerENS.QuestionTypeName, //题目类型名
AnswerTypeId = objvAnswerENS.AnswerTypeId, //答案类型ID
AnswerTypeName = objvAnswerENS.AnswerTypeName, //答案类型名
GridTitle = objvAnswerENS.GridTitle, //表格标题
AnswerModeId = objvAnswerENS.AnswerModeId, //答案模式Id
QuestionScore = objvAnswerENS.QuestionScore, //题目得分
AnswerIndex = objvAnswerENS.AnswerIndex, //问答序号
AnswerOptionId = objvAnswerENS.AnswerOptionId, //回答选项Id
OptionName = objvAnswerENS.OptionName, //选项名称
OptionTitle = objvAnswerENS.OptionTitle, //选项标题
AnswerMultiOptions = objvAnswerENS.AnswerMultiOptions, //多选项答案
IsAutoCorrect = objvAnswerENS.IsAutoCorrect, //是否支持自动批改
AnswerFillInBlank = objvAnswerENS.AnswerFillInBlank, //填空题答案
AnswerTrueOrFalse = objvAnswerENS.AnswerTrueOrFalse, //判断题答案
Provider = objvAnswerENS.Provider, //提供者
Score = objvAnswerENS.Score, //得分
IsShow = objvAnswerENS.IsShow, //是否启用
CourseId = objvAnswerENS.CourseId, //课程Id
UpdDate = objvAnswerENS.UpdDate, //修改日期
UpdUser = objvAnswerENS.UpdUser, //修改人
Memo = objvAnswerENS.Memo, //备注
};
 return objvAnswerENT;
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
public static void CheckProperty4Condition(this clsvAnswerEN objvAnswerEN)
{
 clsvAnswerBL.vAnswerDA.CheckProperty4Condition(objvAnswerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvAnswerEN objvAnswerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvAnswerCond.IsUpdated(convAnswer.AnswerId) == true)
{
string strComparisonOpAnswerId = objvAnswerCond.dicFldComparisonOp[convAnswer.AnswerId];
strWhereCond += string.Format(" And {0} {2} {1}", convAnswer.AnswerId, objvAnswerCond.AnswerId, strComparisonOpAnswerId);
}
if (objvAnswerCond.IsUpdated(convAnswer.QuestionId) == true)
{
string strComparisonOpQuestionId = objvAnswerCond.dicFldComparisonOp[convAnswer.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", convAnswer.QuestionId, objvAnswerCond.QuestionId, strComparisonOpQuestionId);
}
if (objvAnswerCond.IsUpdated(convAnswer.QuestionName) == true)
{
string strComparisonOpQuestionName = objvAnswerCond.dicFldComparisonOp[convAnswer.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.QuestionName, objvAnswerCond.QuestionName, strComparisonOpQuestionName);
}
if (objvAnswerCond.IsUpdated(convAnswer.QuestionMemo) == true)
{
string strComparisonOpQuestionMemo = objvAnswerCond.dicFldComparisonOp[convAnswer.QuestionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.QuestionMemo, objvAnswerCond.QuestionMemo, strComparisonOpQuestionMemo);
}
if (objvAnswerCond.IsUpdated(convAnswer.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objvAnswerCond.dicFldComparisonOp[convAnswer.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.QuestionTypeId, objvAnswerCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objvAnswerCond.IsUpdated(convAnswer.QuestionTypeName) == true)
{
string strComparisonOpQuestionTypeName = objvAnswerCond.dicFldComparisonOp[convAnswer.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.QuestionTypeName, objvAnswerCond.QuestionTypeName, strComparisonOpQuestionTypeName);
}
if (objvAnswerCond.IsUpdated(convAnswer.AnswerTypeId) == true)
{
string strComparisonOpAnswerTypeId = objvAnswerCond.dicFldComparisonOp[convAnswer.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.AnswerTypeId, objvAnswerCond.AnswerTypeId, strComparisonOpAnswerTypeId);
}
if (objvAnswerCond.IsUpdated(convAnswer.AnswerTypeName) == true)
{
string strComparisonOpAnswerTypeName = objvAnswerCond.dicFldComparisonOp[convAnswer.AnswerTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.AnswerTypeName, objvAnswerCond.AnswerTypeName, strComparisonOpAnswerTypeName);
}
if (objvAnswerCond.IsUpdated(convAnswer.GridTitle) == true)
{
string strComparisonOpGridTitle = objvAnswerCond.dicFldComparisonOp[convAnswer.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.GridTitle, objvAnswerCond.GridTitle, strComparisonOpGridTitle);
}
if (objvAnswerCond.IsUpdated(convAnswer.AnswerModeId) == true)
{
string strComparisonOpAnswerModeId = objvAnswerCond.dicFldComparisonOp[convAnswer.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.AnswerModeId, objvAnswerCond.AnswerModeId, strComparisonOpAnswerModeId);
}
if (objvAnswerCond.IsUpdated(convAnswer.QuestionScore) == true)
{
string strComparisonOpQuestionScore = objvAnswerCond.dicFldComparisonOp[convAnswer.QuestionScore];
strWhereCond += string.Format(" And {0} {2} {1}", convAnswer.QuestionScore, objvAnswerCond.QuestionScore, strComparisonOpQuestionScore);
}
if (objvAnswerCond.IsUpdated(convAnswer.AnswerIndex) == true)
{
string strComparisonOpAnswerIndex = objvAnswerCond.dicFldComparisonOp[convAnswer.AnswerIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convAnswer.AnswerIndex, objvAnswerCond.AnswerIndex, strComparisonOpAnswerIndex);
}
if (objvAnswerCond.IsUpdated(convAnswer.AnswerOptionId) == true)
{
string strComparisonOpAnswerOptionId = objvAnswerCond.dicFldComparisonOp[convAnswer.AnswerOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.AnswerOptionId, objvAnswerCond.AnswerOptionId, strComparisonOpAnswerOptionId);
}
if (objvAnswerCond.IsUpdated(convAnswer.OptionName) == true)
{
string strComparisonOpOptionName = objvAnswerCond.dicFldComparisonOp[convAnswer.OptionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.OptionName, objvAnswerCond.OptionName, strComparisonOpOptionName);
}
if (objvAnswerCond.IsUpdated(convAnswer.OptionTitle) == true)
{
string strComparisonOpOptionTitle = objvAnswerCond.dicFldComparisonOp[convAnswer.OptionTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.OptionTitle, objvAnswerCond.OptionTitle, strComparisonOpOptionTitle);
}
if (objvAnswerCond.IsUpdated(convAnswer.AnswerMultiOptions) == true)
{
string strComparisonOpAnswerMultiOptions = objvAnswerCond.dicFldComparisonOp[convAnswer.AnswerMultiOptions];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.AnswerMultiOptions, objvAnswerCond.AnswerMultiOptions, strComparisonOpAnswerMultiOptions);
}
if (objvAnswerCond.IsUpdated(convAnswer.IsAutoCorrect) == true)
{
if (objvAnswerCond.IsAutoCorrect == true)
{
strWhereCond += string.Format(" And {0} = '1'", convAnswer.IsAutoCorrect);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convAnswer.IsAutoCorrect);
}
}
if (objvAnswerCond.IsUpdated(convAnswer.AnswerFillInBlank) == true)
{
string strComparisonOpAnswerFillInBlank = objvAnswerCond.dicFldComparisonOp[convAnswer.AnswerFillInBlank];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.AnswerFillInBlank, objvAnswerCond.AnswerFillInBlank, strComparisonOpAnswerFillInBlank);
}
if (objvAnswerCond.IsUpdated(convAnswer.AnswerTrueOrFalse) == true)
{
if (objvAnswerCond.AnswerTrueOrFalse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convAnswer.AnswerTrueOrFalse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convAnswer.AnswerTrueOrFalse);
}
}
if (objvAnswerCond.IsUpdated(convAnswer.Provider) == true)
{
string strComparisonOpProvider = objvAnswerCond.dicFldComparisonOp[convAnswer.Provider];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.Provider, objvAnswerCond.Provider, strComparisonOpProvider);
}
if (objvAnswerCond.IsUpdated(convAnswer.Score) == true)
{
string strComparisonOpScore = objvAnswerCond.dicFldComparisonOp[convAnswer.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convAnswer.Score, objvAnswerCond.Score, strComparisonOpScore);
}
if (objvAnswerCond.IsUpdated(convAnswer.IsShow) == true)
{
if (objvAnswerCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convAnswer.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convAnswer.IsShow);
}
}
if (objvAnswerCond.IsUpdated(convAnswer.CourseId) == true)
{
string strComparisonOpCourseId = objvAnswerCond.dicFldComparisonOp[convAnswer.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.CourseId, objvAnswerCond.CourseId, strComparisonOpCourseId);
}
if (objvAnswerCond.IsUpdated(convAnswer.UpdDate) == true)
{
string strComparisonOpUpdDate = objvAnswerCond.dicFldComparisonOp[convAnswer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.UpdDate, objvAnswerCond.UpdDate, strComparisonOpUpdDate);
}
if (objvAnswerCond.IsUpdated(convAnswer.UpdUser) == true)
{
string strComparisonOpUpdUser = objvAnswerCond.dicFldComparisonOp[convAnswer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.UpdUser, objvAnswerCond.UpdUser, strComparisonOpUpdUser);
}
if (objvAnswerCond.IsUpdated(convAnswer.Memo) == true)
{
string strComparisonOpMemo = objvAnswerCond.dicFldComparisonOp[convAnswer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAnswer.Memo, objvAnswerCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vAnswer
{
public virtual bool UpdRelaTabDate(long lngAnswerId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v答案(vAnswer)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvAnswerBL
{
public static RelatedActions_vAnswer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvAnswerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvAnswerDA vAnswerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvAnswerDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvAnswerBL()
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
if (string.IsNullOrEmpty(clsvAnswerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvAnswerEN._ConnectString);
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
public static DataTable GetDataTable_vAnswer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vAnswerDA.GetDataTable_vAnswer(strWhereCond);
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
objDT = vAnswerDA.GetDataTable(strWhereCond);
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
objDT = vAnswerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vAnswerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vAnswerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vAnswerDA.GetDataTable_Top(objTopPara);
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
objDT = vAnswerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vAnswerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vAnswerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrAnswerIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvAnswerEN> GetObjLstByAnswerIdLst(List<long> arrAnswerIdLst)
{
List<clsvAnswerEN> arrObjLst = new List<clsvAnswerEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrAnswerIdLst);
 string strWhereCond = string.Format("AnswerId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAnswerEN objvAnswerEN = new clsvAnswerEN();
try
{
objvAnswerEN.AnswerContent = objRow[convAnswer.AnswerContent] == DBNull.Value ? null : objRow[convAnswer.AnswerContent].ToString().Trim(); //答案内容
objvAnswerEN.AnswerId = Int32.Parse(objRow[convAnswer.AnswerId].ToString().Trim()); //问答ID
objvAnswerEN.QuestionId = objRow[convAnswer.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convAnswer.QuestionId].ToString().Trim()); //题目Id
objvAnswerEN.QuestionName = objRow[convAnswer.QuestionName] == DBNull.Value ? null : objRow[convAnswer.QuestionName].ToString().Trim(); //题目名称
objvAnswerEN.QuestionMemo = objRow[convAnswer.QuestionMemo] == DBNull.Value ? null : objRow[convAnswer.QuestionMemo].ToString().Trim(); //题目说明
objvAnswerEN.QuestionTypeId = objRow[convAnswer.QuestionTypeId] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvAnswerEN.QuestionTypeName = objRow[convAnswer.QuestionTypeName] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeName].ToString().Trim(); //题目类型名
objvAnswerEN.AnswerTypeId = objRow[convAnswer.AnswerTypeId] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvAnswerEN.AnswerTypeName = objRow[convAnswer.AnswerTypeName] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeName].ToString().Trim(); //答案类型名
objvAnswerEN.GridTitle = objRow[convAnswer.GridTitle] == DBNull.Value ? null : objRow[convAnswer.GridTitle].ToString().Trim(); //表格标题
objvAnswerEN.AnswerModeId = objRow[convAnswer.AnswerModeId] == DBNull.Value ? null : objRow[convAnswer.AnswerModeId].ToString().Trim(); //答案模式Id
objvAnswerEN.QuestionScore = objRow[convAnswer.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convAnswer.QuestionScore].ToString().Trim()); //题目得分
objvAnswerEN.AnswerIndex = objRow[convAnswer.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAnswer.AnswerIndex].ToString().Trim()); //问答序号
objvAnswerEN.AnswerOptionId = objRow[convAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[convAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objvAnswerEN.OptionName = objRow[convAnswer.OptionName] == DBNull.Value ? null : objRow[convAnswer.OptionName].ToString().Trim(); //选项名称
objvAnswerEN.OptionTitle = objRow[convAnswer.OptionTitle] == DBNull.Value ? null : objRow[convAnswer.OptionTitle].ToString().Trim(); //选项标题
objvAnswerEN.AnswerMultiOptions = objRow[convAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[convAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvAnswerEN.IsAutoCorrect = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objvAnswerEN.AnswerFillInBlank = objRow[convAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[convAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objvAnswerEN.AnswerTrueOrFalse = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objvAnswerEN.Provider = objRow[convAnswer.Provider] == DBNull.Value ? null : objRow[convAnswer.Provider].ToString().Trim(); //提供者
objvAnswerEN.Score = objRow[convAnswer.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convAnswer.Score].ToString().Trim()); //得分
objvAnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.IsShow].ToString().Trim()); //是否启用
objvAnswerEN.CourseId = objRow[convAnswer.CourseId] == DBNull.Value ? null : objRow[convAnswer.CourseId].ToString().Trim(); //课程Id
objvAnswerEN.UpdDate = objRow[convAnswer.UpdDate].ToString().Trim(); //修改日期
objvAnswerEN.UpdUser = objRow[convAnswer.UpdUser].ToString().Trim(); //修改人
objvAnswerEN.Memo = objRow[convAnswer.Memo] == DBNull.Value ? null : objRow[convAnswer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrAnswerIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvAnswerEN> GetObjLstByAnswerIdLstCache(List<long> arrAnswerIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvAnswerEN._CurrTabName, strCourseId);
List<clsvAnswerEN> arrvAnswerObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvAnswerEN> arrvAnswerObjLst_Sel =
arrvAnswerObjLstCache
.Where(x => arrAnswerIdLst.Contains(x.AnswerId));
return arrvAnswerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvAnswerEN> GetObjLst(string strWhereCond)
{
List<clsvAnswerEN> arrObjLst = new List<clsvAnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAnswerEN objvAnswerEN = new clsvAnswerEN();
try
{
objvAnswerEN.AnswerContent = objRow[convAnswer.AnswerContent] == DBNull.Value ? null : objRow[convAnswer.AnswerContent].ToString().Trim(); //答案内容
objvAnswerEN.AnswerId = Int32.Parse(objRow[convAnswer.AnswerId].ToString().Trim()); //问答ID
objvAnswerEN.QuestionId = objRow[convAnswer.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convAnswer.QuestionId].ToString().Trim()); //题目Id
objvAnswerEN.QuestionName = objRow[convAnswer.QuestionName] == DBNull.Value ? null : objRow[convAnswer.QuestionName].ToString().Trim(); //题目名称
objvAnswerEN.QuestionMemo = objRow[convAnswer.QuestionMemo] == DBNull.Value ? null : objRow[convAnswer.QuestionMemo].ToString().Trim(); //题目说明
objvAnswerEN.QuestionTypeId = objRow[convAnswer.QuestionTypeId] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvAnswerEN.QuestionTypeName = objRow[convAnswer.QuestionTypeName] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeName].ToString().Trim(); //题目类型名
objvAnswerEN.AnswerTypeId = objRow[convAnswer.AnswerTypeId] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvAnswerEN.AnswerTypeName = objRow[convAnswer.AnswerTypeName] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeName].ToString().Trim(); //答案类型名
objvAnswerEN.GridTitle = objRow[convAnswer.GridTitle] == DBNull.Value ? null : objRow[convAnswer.GridTitle].ToString().Trim(); //表格标题
objvAnswerEN.AnswerModeId = objRow[convAnswer.AnswerModeId] == DBNull.Value ? null : objRow[convAnswer.AnswerModeId].ToString().Trim(); //答案模式Id
objvAnswerEN.QuestionScore = objRow[convAnswer.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convAnswer.QuestionScore].ToString().Trim()); //题目得分
objvAnswerEN.AnswerIndex = objRow[convAnswer.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAnswer.AnswerIndex].ToString().Trim()); //问答序号
objvAnswerEN.AnswerOptionId = objRow[convAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[convAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objvAnswerEN.OptionName = objRow[convAnswer.OptionName] == DBNull.Value ? null : objRow[convAnswer.OptionName].ToString().Trim(); //选项名称
objvAnswerEN.OptionTitle = objRow[convAnswer.OptionTitle] == DBNull.Value ? null : objRow[convAnswer.OptionTitle].ToString().Trim(); //选项标题
objvAnswerEN.AnswerMultiOptions = objRow[convAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[convAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvAnswerEN.IsAutoCorrect = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objvAnswerEN.AnswerFillInBlank = objRow[convAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[convAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objvAnswerEN.AnswerTrueOrFalse = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objvAnswerEN.Provider = objRow[convAnswer.Provider] == DBNull.Value ? null : objRow[convAnswer.Provider].ToString().Trim(); //提供者
objvAnswerEN.Score = objRow[convAnswer.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convAnswer.Score].ToString().Trim()); //得分
objvAnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.IsShow].ToString().Trim()); //是否启用
objvAnswerEN.CourseId = objRow[convAnswer.CourseId] == DBNull.Value ? null : objRow[convAnswer.CourseId].ToString().Trim(); //课程Id
objvAnswerEN.UpdDate = objRow[convAnswer.UpdDate].ToString().Trim(); //修改日期
objvAnswerEN.UpdUser = objRow[convAnswer.UpdUser].ToString().Trim(); //修改人
objvAnswerEN.Memo = objRow[convAnswer.Memo] == DBNull.Value ? null : objRow[convAnswer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAnswerEN);
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
public static List<clsvAnswerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvAnswerEN> arrObjLst = new List<clsvAnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAnswerEN objvAnswerEN = new clsvAnswerEN();
try
{
objvAnswerEN.AnswerContent = objRow[convAnswer.AnswerContent] == DBNull.Value ? null : objRow[convAnswer.AnswerContent].ToString().Trim(); //答案内容
objvAnswerEN.AnswerId = Int32.Parse(objRow[convAnswer.AnswerId].ToString().Trim()); //问答ID
objvAnswerEN.QuestionId = objRow[convAnswer.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convAnswer.QuestionId].ToString().Trim()); //题目Id
objvAnswerEN.QuestionName = objRow[convAnswer.QuestionName] == DBNull.Value ? null : objRow[convAnswer.QuestionName].ToString().Trim(); //题目名称
objvAnswerEN.QuestionMemo = objRow[convAnswer.QuestionMemo] == DBNull.Value ? null : objRow[convAnswer.QuestionMemo].ToString().Trim(); //题目说明
objvAnswerEN.QuestionTypeId = objRow[convAnswer.QuestionTypeId] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvAnswerEN.QuestionTypeName = objRow[convAnswer.QuestionTypeName] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeName].ToString().Trim(); //题目类型名
objvAnswerEN.AnswerTypeId = objRow[convAnswer.AnswerTypeId] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvAnswerEN.AnswerTypeName = objRow[convAnswer.AnswerTypeName] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeName].ToString().Trim(); //答案类型名
objvAnswerEN.GridTitle = objRow[convAnswer.GridTitle] == DBNull.Value ? null : objRow[convAnswer.GridTitle].ToString().Trim(); //表格标题
objvAnswerEN.AnswerModeId = objRow[convAnswer.AnswerModeId] == DBNull.Value ? null : objRow[convAnswer.AnswerModeId].ToString().Trim(); //答案模式Id
objvAnswerEN.QuestionScore = objRow[convAnswer.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convAnswer.QuestionScore].ToString().Trim()); //题目得分
objvAnswerEN.AnswerIndex = objRow[convAnswer.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAnswer.AnswerIndex].ToString().Trim()); //问答序号
objvAnswerEN.AnswerOptionId = objRow[convAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[convAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objvAnswerEN.OptionName = objRow[convAnswer.OptionName] == DBNull.Value ? null : objRow[convAnswer.OptionName].ToString().Trim(); //选项名称
objvAnswerEN.OptionTitle = objRow[convAnswer.OptionTitle] == DBNull.Value ? null : objRow[convAnswer.OptionTitle].ToString().Trim(); //选项标题
objvAnswerEN.AnswerMultiOptions = objRow[convAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[convAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvAnswerEN.IsAutoCorrect = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objvAnswerEN.AnswerFillInBlank = objRow[convAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[convAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objvAnswerEN.AnswerTrueOrFalse = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objvAnswerEN.Provider = objRow[convAnswer.Provider] == DBNull.Value ? null : objRow[convAnswer.Provider].ToString().Trim(); //提供者
objvAnswerEN.Score = objRow[convAnswer.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convAnswer.Score].ToString().Trim()); //得分
objvAnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.IsShow].ToString().Trim()); //是否启用
objvAnswerEN.CourseId = objRow[convAnswer.CourseId] == DBNull.Value ? null : objRow[convAnswer.CourseId].ToString().Trim(); //课程Id
objvAnswerEN.UpdDate = objRow[convAnswer.UpdDate].ToString().Trim(); //修改日期
objvAnswerEN.UpdUser = objRow[convAnswer.UpdUser].ToString().Trim(); //修改人
objvAnswerEN.Memo = objRow[convAnswer.Memo] == DBNull.Value ? null : objRow[convAnswer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvAnswerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvAnswerEN> GetSubObjLstCache(clsvAnswerEN objvAnswerCond)
{
 string strCourseId = objvAnswerCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvAnswerBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvAnswerEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvAnswerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convAnswer.AttributeName)
{
if (objvAnswerCond.IsUpdated(strFldName) == false) continue;
if (objvAnswerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvAnswerCond[strFldName].ToString());
}
else
{
if (objvAnswerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvAnswerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvAnswerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvAnswerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvAnswerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvAnswerCond[strFldName]));
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
public static List<clsvAnswerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvAnswerEN> arrObjLst = new List<clsvAnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAnswerEN objvAnswerEN = new clsvAnswerEN();
try
{
objvAnswerEN.AnswerContent = objRow[convAnswer.AnswerContent] == DBNull.Value ? null : objRow[convAnswer.AnswerContent].ToString().Trim(); //答案内容
objvAnswerEN.AnswerId = Int32.Parse(objRow[convAnswer.AnswerId].ToString().Trim()); //问答ID
objvAnswerEN.QuestionId = objRow[convAnswer.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convAnswer.QuestionId].ToString().Trim()); //题目Id
objvAnswerEN.QuestionName = objRow[convAnswer.QuestionName] == DBNull.Value ? null : objRow[convAnswer.QuestionName].ToString().Trim(); //题目名称
objvAnswerEN.QuestionMemo = objRow[convAnswer.QuestionMemo] == DBNull.Value ? null : objRow[convAnswer.QuestionMemo].ToString().Trim(); //题目说明
objvAnswerEN.QuestionTypeId = objRow[convAnswer.QuestionTypeId] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvAnswerEN.QuestionTypeName = objRow[convAnswer.QuestionTypeName] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeName].ToString().Trim(); //题目类型名
objvAnswerEN.AnswerTypeId = objRow[convAnswer.AnswerTypeId] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvAnswerEN.AnswerTypeName = objRow[convAnswer.AnswerTypeName] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeName].ToString().Trim(); //答案类型名
objvAnswerEN.GridTitle = objRow[convAnswer.GridTitle] == DBNull.Value ? null : objRow[convAnswer.GridTitle].ToString().Trim(); //表格标题
objvAnswerEN.AnswerModeId = objRow[convAnswer.AnswerModeId] == DBNull.Value ? null : objRow[convAnswer.AnswerModeId].ToString().Trim(); //答案模式Id
objvAnswerEN.QuestionScore = objRow[convAnswer.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convAnswer.QuestionScore].ToString().Trim()); //题目得分
objvAnswerEN.AnswerIndex = objRow[convAnswer.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAnswer.AnswerIndex].ToString().Trim()); //问答序号
objvAnswerEN.AnswerOptionId = objRow[convAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[convAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objvAnswerEN.OptionName = objRow[convAnswer.OptionName] == DBNull.Value ? null : objRow[convAnswer.OptionName].ToString().Trim(); //选项名称
objvAnswerEN.OptionTitle = objRow[convAnswer.OptionTitle] == DBNull.Value ? null : objRow[convAnswer.OptionTitle].ToString().Trim(); //选项标题
objvAnswerEN.AnswerMultiOptions = objRow[convAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[convAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvAnswerEN.IsAutoCorrect = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objvAnswerEN.AnswerFillInBlank = objRow[convAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[convAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objvAnswerEN.AnswerTrueOrFalse = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objvAnswerEN.Provider = objRow[convAnswer.Provider] == DBNull.Value ? null : objRow[convAnswer.Provider].ToString().Trim(); //提供者
objvAnswerEN.Score = objRow[convAnswer.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convAnswer.Score].ToString().Trim()); //得分
objvAnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.IsShow].ToString().Trim()); //是否启用
objvAnswerEN.CourseId = objRow[convAnswer.CourseId] == DBNull.Value ? null : objRow[convAnswer.CourseId].ToString().Trim(); //课程Id
objvAnswerEN.UpdDate = objRow[convAnswer.UpdDate].ToString().Trim(); //修改日期
objvAnswerEN.UpdUser = objRow[convAnswer.UpdUser].ToString().Trim(); //修改人
objvAnswerEN.Memo = objRow[convAnswer.Memo] == DBNull.Value ? null : objRow[convAnswer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAnswerEN);
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
public static List<clsvAnswerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvAnswerEN> arrObjLst = new List<clsvAnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAnswerEN objvAnswerEN = new clsvAnswerEN();
try
{
objvAnswerEN.AnswerContent = objRow[convAnswer.AnswerContent] == DBNull.Value ? null : objRow[convAnswer.AnswerContent].ToString().Trim(); //答案内容
objvAnswerEN.AnswerId = Int32.Parse(objRow[convAnswer.AnswerId].ToString().Trim()); //问答ID
objvAnswerEN.QuestionId = objRow[convAnswer.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convAnswer.QuestionId].ToString().Trim()); //题目Id
objvAnswerEN.QuestionName = objRow[convAnswer.QuestionName] == DBNull.Value ? null : objRow[convAnswer.QuestionName].ToString().Trim(); //题目名称
objvAnswerEN.QuestionMemo = objRow[convAnswer.QuestionMemo] == DBNull.Value ? null : objRow[convAnswer.QuestionMemo].ToString().Trim(); //题目说明
objvAnswerEN.QuestionTypeId = objRow[convAnswer.QuestionTypeId] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvAnswerEN.QuestionTypeName = objRow[convAnswer.QuestionTypeName] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeName].ToString().Trim(); //题目类型名
objvAnswerEN.AnswerTypeId = objRow[convAnswer.AnswerTypeId] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvAnswerEN.AnswerTypeName = objRow[convAnswer.AnswerTypeName] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeName].ToString().Trim(); //答案类型名
objvAnswerEN.GridTitle = objRow[convAnswer.GridTitle] == DBNull.Value ? null : objRow[convAnswer.GridTitle].ToString().Trim(); //表格标题
objvAnswerEN.AnswerModeId = objRow[convAnswer.AnswerModeId] == DBNull.Value ? null : objRow[convAnswer.AnswerModeId].ToString().Trim(); //答案模式Id
objvAnswerEN.QuestionScore = objRow[convAnswer.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convAnswer.QuestionScore].ToString().Trim()); //题目得分
objvAnswerEN.AnswerIndex = objRow[convAnswer.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAnswer.AnswerIndex].ToString().Trim()); //问答序号
objvAnswerEN.AnswerOptionId = objRow[convAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[convAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objvAnswerEN.OptionName = objRow[convAnswer.OptionName] == DBNull.Value ? null : objRow[convAnswer.OptionName].ToString().Trim(); //选项名称
objvAnswerEN.OptionTitle = objRow[convAnswer.OptionTitle] == DBNull.Value ? null : objRow[convAnswer.OptionTitle].ToString().Trim(); //选项标题
objvAnswerEN.AnswerMultiOptions = objRow[convAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[convAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvAnswerEN.IsAutoCorrect = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objvAnswerEN.AnswerFillInBlank = objRow[convAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[convAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objvAnswerEN.AnswerTrueOrFalse = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objvAnswerEN.Provider = objRow[convAnswer.Provider] == DBNull.Value ? null : objRow[convAnswer.Provider].ToString().Trim(); //提供者
objvAnswerEN.Score = objRow[convAnswer.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convAnswer.Score].ToString().Trim()); //得分
objvAnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.IsShow].ToString().Trim()); //是否启用
objvAnswerEN.CourseId = objRow[convAnswer.CourseId] == DBNull.Value ? null : objRow[convAnswer.CourseId].ToString().Trim(); //课程Id
objvAnswerEN.UpdDate = objRow[convAnswer.UpdDate].ToString().Trim(); //修改日期
objvAnswerEN.UpdUser = objRow[convAnswer.UpdUser].ToString().Trim(); //修改人
objvAnswerEN.Memo = objRow[convAnswer.Memo] == DBNull.Value ? null : objRow[convAnswer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAnswerEN);
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
List<clsvAnswerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvAnswerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvAnswerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvAnswerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvAnswerEN> arrObjLst = new List<clsvAnswerEN>(); 
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
	clsvAnswerEN objvAnswerEN = new clsvAnswerEN();
try
{
objvAnswerEN.AnswerContent = objRow[convAnswer.AnswerContent] == DBNull.Value ? null : objRow[convAnswer.AnswerContent].ToString().Trim(); //答案内容
objvAnswerEN.AnswerId = Int32.Parse(objRow[convAnswer.AnswerId].ToString().Trim()); //问答ID
objvAnswerEN.QuestionId = objRow[convAnswer.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convAnswer.QuestionId].ToString().Trim()); //题目Id
objvAnswerEN.QuestionName = objRow[convAnswer.QuestionName] == DBNull.Value ? null : objRow[convAnswer.QuestionName].ToString().Trim(); //题目名称
objvAnswerEN.QuestionMemo = objRow[convAnswer.QuestionMemo] == DBNull.Value ? null : objRow[convAnswer.QuestionMemo].ToString().Trim(); //题目说明
objvAnswerEN.QuestionTypeId = objRow[convAnswer.QuestionTypeId] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvAnswerEN.QuestionTypeName = objRow[convAnswer.QuestionTypeName] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeName].ToString().Trim(); //题目类型名
objvAnswerEN.AnswerTypeId = objRow[convAnswer.AnswerTypeId] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvAnswerEN.AnswerTypeName = objRow[convAnswer.AnswerTypeName] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeName].ToString().Trim(); //答案类型名
objvAnswerEN.GridTitle = objRow[convAnswer.GridTitle] == DBNull.Value ? null : objRow[convAnswer.GridTitle].ToString().Trim(); //表格标题
objvAnswerEN.AnswerModeId = objRow[convAnswer.AnswerModeId] == DBNull.Value ? null : objRow[convAnswer.AnswerModeId].ToString().Trim(); //答案模式Id
objvAnswerEN.QuestionScore = objRow[convAnswer.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convAnswer.QuestionScore].ToString().Trim()); //题目得分
objvAnswerEN.AnswerIndex = objRow[convAnswer.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAnswer.AnswerIndex].ToString().Trim()); //问答序号
objvAnswerEN.AnswerOptionId = objRow[convAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[convAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objvAnswerEN.OptionName = objRow[convAnswer.OptionName] == DBNull.Value ? null : objRow[convAnswer.OptionName].ToString().Trim(); //选项名称
objvAnswerEN.OptionTitle = objRow[convAnswer.OptionTitle] == DBNull.Value ? null : objRow[convAnswer.OptionTitle].ToString().Trim(); //选项标题
objvAnswerEN.AnswerMultiOptions = objRow[convAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[convAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvAnswerEN.IsAutoCorrect = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objvAnswerEN.AnswerFillInBlank = objRow[convAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[convAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objvAnswerEN.AnswerTrueOrFalse = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objvAnswerEN.Provider = objRow[convAnswer.Provider] == DBNull.Value ? null : objRow[convAnswer.Provider].ToString().Trim(); //提供者
objvAnswerEN.Score = objRow[convAnswer.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convAnswer.Score].ToString().Trim()); //得分
objvAnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.IsShow].ToString().Trim()); //是否启用
objvAnswerEN.CourseId = objRow[convAnswer.CourseId] == DBNull.Value ? null : objRow[convAnswer.CourseId].ToString().Trim(); //课程Id
objvAnswerEN.UpdDate = objRow[convAnswer.UpdDate].ToString().Trim(); //修改日期
objvAnswerEN.UpdUser = objRow[convAnswer.UpdUser].ToString().Trim(); //修改人
objvAnswerEN.Memo = objRow[convAnswer.Memo] == DBNull.Value ? null : objRow[convAnswer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAnswerEN);
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
public static List<clsvAnswerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvAnswerEN> arrObjLst = new List<clsvAnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAnswerEN objvAnswerEN = new clsvAnswerEN();
try
{
objvAnswerEN.AnswerContent = objRow[convAnswer.AnswerContent] == DBNull.Value ? null : objRow[convAnswer.AnswerContent].ToString().Trim(); //答案内容
objvAnswerEN.AnswerId = Int32.Parse(objRow[convAnswer.AnswerId].ToString().Trim()); //问答ID
objvAnswerEN.QuestionId = objRow[convAnswer.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convAnswer.QuestionId].ToString().Trim()); //题目Id
objvAnswerEN.QuestionName = objRow[convAnswer.QuestionName] == DBNull.Value ? null : objRow[convAnswer.QuestionName].ToString().Trim(); //题目名称
objvAnswerEN.QuestionMemo = objRow[convAnswer.QuestionMemo] == DBNull.Value ? null : objRow[convAnswer.QuestionMemo].ToString().Trim(); //题目说明
objvAnswerEN.QuestionTypeId = objRow[convAnswer.QuestionTypeId] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvAnswerEN.QuestionTypeName = objRow[convAnswer.QuestionTypeName] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeName].ToString().Trim(); //题目类型名
objvAnswerEN.AnswerTypeId = objRow[convAnswer.AnswerTypeId] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvAnswerEN.AnswerTypeName = objRow[convAnswer.AnswerTypeName] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeName].ToString().Trim(); //答案类型名
objvAnswerEN.GridTitle = objRow[convAnswer.GridTitle] == DBNull.Value ? null : objRow[convAnswer.GridTitle].ToString().Trim(); //表格标题
objvAnswerEN.AnswerModeId = objRow[convAnswer.AnswerModeId] == DBNull.Value ? null : objRow[convAnswer.AnswerModeId].ToString().Trim(); //答案模式Id
objvAnswerEN.QuestionScore = objRow[convAnswer.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convAnswer.QuestionScore].ToString().Trim()); //题目得分
objvAnswerEN.AnswerIndex = objRow[convAnswer.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAnswer.AnswerIndex].ToString().Trim()); //问答序号
objvAnswerEN.AnswerOptionId = objRow[convAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[convAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objvAnswerEN.OptionName = objRow[convAnswer.OptionName] == DBNull.Value ? null : objRow[convAnswer.OptionName].ToString().Trim(); //选项名称
objvAnswerEN.OptionTitle = objRow[convAnswer.OptionTitle] == DBNull.Value ? null : objRow[convAnswer.OptionTitle].ToString().Trim(); //选项标题
objvAnswerEN.AnswerMultiOptions = objRow[convAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[convAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvAnswerEN.IsAutoCorrect = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objvAnswerEN.AnswerFillInBlank = objRow[convAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[convAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objvAnswerEN.AnswerTrueOrFalse = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objvAnswerEN.Provider = objRow[convAnswer.Provider] == DBNull.Value ? null : objRow[convAnswer.Provider].ToString().Trim(); //提供者
objvAnswerEN.Score = objRow[convAnswer.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convAnswer.Score].ToString().Trim()); //得分
objvAnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.IsShow].ToString().Trim()); //是否启用
objvAnswerEN.CourseId = objRow[convAnswer.CourseId] == DBNull.Value ? null : objRow[convAnswer.CourseId].ToString().Trim(); //课程Id
objvAnswerEN.UpdDate = objRow[convAnswer.UpdDate].ToString().Trim(); //修改日期
objvAnswerEN.UpdUser = objRow[convAnswer.UpdUser].ToString().Trim(); //修改人
objvAnswerEN.Memo = objRow[convAnswer.Memo] == DBNull.Value ? null : objRow[convAnswer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvAnswerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvAnswerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvAnswerEN> arrObjLst = new List<clsvAnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAnswerEN objvAnswerEN = new clsvAnswerEN();
try
{
objvAnswerEN.AnswerContent = objRow[convAnswer.AnswerContent] == DBNull.Value ? null : objRow[convAnswer.AnswerContent].ToString().Trim(); //答案内容
objvAnswerEN.AnswerId = Int32.Parse(objRow[convAnswer.AnswerId].ToString().Trim()); //问答ID
objvAnswerEN.QuestionId = objRow[convAnswer.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convAnswer.QuestionId].ToString().Trim()); //题目Id
objvAnswerEN.QuestionName = objRow[convAnswer.QuestionName] == DBNull.Value ? null : objRow[convAnswer.QuestionName].ToString().Trim(); //题目名称
objvAnswerEN.QuestionMemo = objRow[convAnswer.QuestionMemo] == DBNull.Value ? null : objRow[convAnswer.QuestionMemo].ToString().Trim(); //题目说明
objvAnswerEN.QuestionTypeId = objRow[convAnswer.QuestionTypeId] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvAnswerEN.QuestionTypeName = objRow[convAnswer.QuestionTypeName] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeName].ToString().Trim(); //题目类型名
objvAnswerEN.AnswerTypeId = objRow[convAnswer.AnswerTypeId] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvAnswerEN.AnswerTypeName = objRow[convAnswer.AnswerTypeName] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeName].ToString().Trim(); //答案类型名
objvAnswerEN.GridTitle = objRow[convAnswer.GridTitle] == DBNull.Value ? null : objRow[convAnswer.GridTitle].ToString().Trim(); //表格标题
objvAnswerEN.AnswerModeId = objRow[convAnswer.AnswerModeId] == DBNull.Value ? null : objRow[convAnswer.AnswerModeId].ToString().Trim(); //答案模式Id
objvAnswerEN.QuestionScore = objRow[convAnswer.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convAnswer.QuestionScore].ToString().Trim()); //题目得分
objvAnswerEN.AnswerIndex = objRow[convAnswer.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAnswer.AnswerIndex].ToString().Trim()); //问答序号
objvAnswerEN.AnswerOptionId = objRow[convAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[convAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objvAnswerEN.OptionName = objRow[convAnswer.OptionName] == DBNull.Value ? null : objRow[convAnswer.OptionName].ToString().Trim(); //选项名称
objvAnswerEN.OptionTitle = objRow[convAnswer.OptionTitle] == DBNull.Value ? null : objRow[convAnswer.OptionTitle].ToString().Trim(); //选项标题
objvAnswerEN.AnswerMultiOptions = objRow[convAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[convAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvAnswerEN.IsAutoCorrect = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objvAnswerEN.AnswerFillInBlank = objRow[convAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[convAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objvAnswerEN.AnswerTrueOrFalse = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objvAnswerEN.Provider = objRow[convAnswer.Provider] == DBNull.Value ? null : objRow[convAnswer.Provider].ToString().Trim(); //提供者
objvAnswerEN.Score = objRow[convAnswer.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convAnswer.Score].ToString().Trim()); //得分
objvAnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.IsShow].ToString().Trim()); //是否启用
objvAnswerEN.CourseId = objRow[convAnswer.CourseId] == DBNull.Value ? null : objRow[convAnswer.CourseId].ToString().Trim(); //课程Id
objvAnswerEN.UpdDate = objRow[convAnswer.UpdDate].ToString().Trim(); //修改日期
objvAnswerEN.UpdUser = objRow[convAnswer.UpdUser].ToString().Trim(); //修改人
objvAnswerEN.Memo = objRow[convAnswer.Memo] == DBNull.Value ? null : objRow[convAnswer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAnswerEN);
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
public static List<clsvAnswerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvAnswerEN> arrObjLst = new List<clsvAnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAnswerEN objvAnswerEN = new clsvAnswerEN();
try
{
objvAnswerEN.AnswerContent = objRow[convAnswer.AnswerContent] == DBNull.Value ? null : objRow[convAnswer.AnswerContent].ToString().Trim(); //答案内容
objvAnswerEN.AnswerId = Int32.Parse(objRow[convAnswer.AnswerId].ToString().Trim()); //问答ID
objvAnswerEN.QuestionId = objRow[convAnswer.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convAnswer.QuestionId].ToString().Trim()); //题目Id
objvAnswerEN.QuestionName = objRow[convAnswer.QuestionName] == DBNull.Value ? null : objRow[convAnswer.QuestionName].ToString().Trim(); //题目名称
objvAnswerEN.QuestionMemo = objRow[convAnswer.QuestionMemo] == DBNull.Value ? null : objRow[convAnswer.QuestionMemo].ToString().Trim(); //题目说明
objvAnswerEN.QuestionTypeId = objRow[convAnswer.QuestionTypeId] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvAnswerEN.QuestionTypeName = objRow[convAnswer.QuestionTypeName] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeName].ToString().Trim(); //题目类型名
objvAnswerEN.AnswerTypeId = objRow[convAnswer.AnswerTypeId] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvAnswerEN.AnswerTypeName = objRow[convAnswer.AnswerTypeName] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeName].ToString().Trim(); //答案类型名
objvAnswerEN.GridTitle = objRow[convAnswer.GridTitle] == DBNull.Value ? null : objRow[convAnswer.GridTitle].ToString().Trim(); //表格标题
objvAnswerEN.AnswerModeId = objRow[convAnswer.AnswerModeId] == DBNull.Value ? null : objRow[convAnswer.AnswerModeId].ToString().Trim(); //答案模式Id
objvAnswerEN.QuestionScore = objRow[convAnswer.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convAnswer.QuestionScore].ToString().Trim()); //题目得分
objvAnswerEN.AnswerIndex = objRow[convAnswer.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAnswer.AnswerIndex].ToString().Trim()); //问答序号
objvAnswerEN.AnswerOptionId = objRow[convAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[convAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objvAnswerEN.OptionName = objRow[convAnswer.OptionName] == DBNull.Value ? null : objRow[convAnswer.OptionName].ToString().Trim(); //选项名称
objvAnswerEN.OptionTitle = objRow[convAnswer.OptionTitle] == DBNull.Value ? null : objRow[convAnswer.OptionTitle].ToString().Trim(); //选项标题
objvAnswerEN.AnswerMultiOptions = objRow[convAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[convAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvAnswerEN.IsAutoCorrect = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objvAnswerEN.AnswerFillInBlank = objRow[convAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[convAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objvAnswerEN.AnswerTrueOrFalse = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objvAnswerEN.Provider = objRow[convAnswer.Provider] == DBNull.Value ? null : objRow[convAnswer.Provider].ToString().Trim(); //提供者
objvAnswerEN.Score = objRow[convAnswer.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convAnswer.Score].ToString().Trim()); //得分
objvAnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.IsShow].ToString().Trim()); //是否启用
objvAnswerEN.CourseId = objRow[convAnswer.CourseId] == DBNull.Value ? null : objRow[convAnswer.CourseId].ToString().Trim(); //课程Id
objvAnswerEN.UpdDate = objRow[convAnswer.UpdDate].ToString().Trim(); //修改日期
objvAnswerEN.UpdUser = objRow[convAnswer.UpdUser].ToString().Trim(); //修改人
objvAnswerEN.Memo = objRow[convAnswer.Memo] == DBNull.Value ? null : objRow[convAnswer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvAnswerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvAnswerEN> arrObjLst = new List<clsvAnswerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAnswerEN objvAnswerEN = new clsvAnswerEN();
try
{
objvAnswerEN.AnswerContent = objRow[convAnswer.AnswerContent] == DBNull.Value ? null : objRow[convAnswer.AnswerContent].ToString().Trim(); //答案内容
objvAnswerEN.AnswerId = Int32.Parse(objRow[convAnswer.AnswerId].ToString().Trim()); //问答ID
objvAnswerEN.QuestionId = objRow[convAnswer.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convAnswer.QuestionId].ToString().Trim()); //题目Id
objvAnswerEN.QuestionName = objRow[convAnswer.QuestionName] == DBNull.Value ? null : objRow[convAnswer.QuestionName].ToString().Trim(); //题目名称
objvAnswerEN.QuestionMemo = objRow[convAnswer.QuestionMemo] == DBNull.Value ? null : objRow[convAnswer.QuestionMemo].ToString().Trim(); //题目说明
objvAnswerEN.QuestionTypeId = objRow[convAnswer.QuestionTypeId] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvAnswerEN.QuestionTypeName = objRow[convAnswer.QuestionTypeName] == DBNull.Value ? null : objRow[convAnswer.QuestionTypeName].ToString().Trim(); //题目类型名
objvAnswerEN.AnswerTypeId = objRow[convAnswer.AnswerTypeId] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvAnswerEN.AnswerTypeName = objRow[convAnswer.AnswerTypeName] == DBNull.Value ? null : objRow[convAnswer.AnswerTypeName].ToString().Trim(); //答案类型名
objvAnswerEN.GridTitle = objRow[convAnswer.GridTitle] == DBNull.Value ? null : objRow[convAnswer.GridTitle].ToString().Trim(); //表格标题
objvAnswerEN.AnswerModeId = objRow[convAnswer.AnswerModeId] == DBNull.Value ? null : objRow[convAnswer.AnswerModeId].ToString().Trim(); //答案模式Id
objvAnswerEN.QuestionScore = objRow[convAnswer.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convAnswer.QuestionScore].ToString().Trim()); //题目得分
objvAnswerEN.AnswerIndex = objRow[convAnswer.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAnswer.AnswerIndex].ToString().Trim()); //问答序号
objvAnswerEN.AnswerOptionId = objRow[convAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[convAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objvAnswerEN.OptionName = objRow[convAnswer.OptionName] == DBNull.Value ? null : objRow[convAnswer.OptionName].ToString().Trim(); //选项名称
objvAnswerEN.OptionTitle = objRow[convAnswer.OptionTitle] == DBNull.Value ? null : objRow[convAnswer.OptionTitle].ToString().Trim(); //选项标题
objvAnswerEN.AnswerMultiOptions = objRow[convAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[convAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvAnswerEN.IsAutoCorrect = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objvAnswerEN.AnswerFillInBlank = objRow[convAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[convAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objvAnswerEN.AnswerTrueOrFalse = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objvAnswerEN.Provider = objRow[convAnswer.Provider] == DBNull.Value ? null : objRow[convAnswer.Provider].ToString().Trim(); //提供者
objvAnswerEN.Score = objRow[convAnswer.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convAnswer.Score].ToString().Trim()); //得分
objvAnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convAnswer.IsShow].ToString().Trim()); //是否启用
objvAnswerEN.CourseId = objRow[convAnswer.CourseId] == DBNull.Value ? null : objRow[convAnswer.CourseId].ToString().Trim(); //课程Id
objvAnswerEN.UpdDate = objRow[convAnswer.UpdDate].ToString().Trim(); //修改日期
objvAnswerEN.UpdUser = objRow[convAnswer.UpdUser].ToString().Trim(); //修改人
objvAnswerEN.Memo = objRow[convAnswer.Memo] == DBNull.Value ? null : objRow[convAnswer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAnswerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvAnswerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvAnswer(ref clsvAnswerEN objvAnswerEN)
{
bool bolResult = vAnswerDA.GetvAnswer(ref objvAnswerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngAnswerId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvAnswerEN GetObjByAnswerId(long lngAnswerId)
{
clsvAnswerEN objvAnswerEN = vAnswerDA.GetObjByAnswerId(lngAnswerId);
return objvAnswerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvAnswerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvAnswerEN objvAnswerEN = vAnswerDA.GetFirstObj(strWhereCond);
 return objvAnswerEN;
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
public static clsvAnswerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvAnswerEN objvAnswerEN = vAnswerDA.GetObjByDataRow(objRow);
 return objvAnswerEN;
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
public static clsvAnswerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvAnswerEN objvAnswerEN = vAnswerDA.GetObjByDataRow(objRow);
 return objvAnswerEN;
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
 /// <param name = "lngAnswerId">所给的关键字</param>
 /// <param name = "lstvAnswerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvAnswerEN GetObjByAnswerIdFromList(long lngAnswerId, List<clsvAnswerEN> lstvAnswerObjLst)
{
foreach (clsvAnswerEN objvAnswerEN in lstvAnswerObjLst)
{
if (objvAnswerEN.AnswerId == lngAnswerId)
{
return objvAnswerEN;
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
 long lngAnswerId;
 try
 {
 lngAnswerId = new clsvAnswerDA().GetFirstID(strWhereCond);
 return lngAnswerId;
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
 arrList = vAnswerDA.GetID(strWhereCond);
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
bool bolIsExist = vAnswerDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngAnswerId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngAnswerId)
{
//检测记录是否存在
bool bolIsExist = vAnswerDA.IsExist(lngAnswerId);
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
 bolIsExist = clsvAnswerDA.IsExistTable();
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
 bolIsExist = vAnswerDA.IsExistTable(strTabName);
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
 /// <param name = "objvAnswerENS">源对象</param>
 /// <param name = "objvAnswerENT">目标对象</param>
 public static void CopyTo(clsvAnswerEN objvAnswerENS, clsvAnswerEN objvAnswerENT)
{
try
{
objvAnswerENT.AnswerContent = objvAnswerENS.AnswerContent; //答案内容
objvAnswerENT.AnswerId = objvAnswerENS.AnswerId; //问答ID
objvAnswerENT.QuestionId = objvAnswerENS.QuestionId; //题目Id
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
 /// <param name = "objvAnswerEN">源简化对象</param>
 public static void SetUpdFlag(clsvAnswerEN objvAnswerEN)
{
try
{
objvAnswerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvAnswerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convAnswer.AnswerContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.AnswerContent = objvAnswerEN.AnswerContent == "[null]" ? null :  objvAnswerEN.AnswerContent; //答案内容
}
if (arrFldSet.Contains(convAnswer.AnswerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.AnswerId = objvAnswerEN.AnswerId; //问答ID
}
if (arrFldSet.Contains(convAnswer.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.QuestionId = objvAnswerEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(convAnswer.QuestionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.QuestionName = objvAnswerEN.QuestionName == "[null]" ? null :  objvAnswerEN.QuestionName; //题目名称
}
if (arrFldSet.Contains(convAnswer.QuestionMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.QuestionMemo = objvAnswerEN.QuestionMemo == "[null]" ? null :  objvAnswerEN.QuestionMemo; //题目说明
}
if (arrFldSet.Contains(convAnswer.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.QuestionTypeId = objvAnswerEN.QuestionTypeId == "[null]" ? null :  objvAnswerEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(convAnswer.QuestionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.QuestionTypeName = objvAnswerEN.QuestionTypeName == "[null]" ? null :  objvAnswerEN.QuestionTypeName; //题目类型名
}
if (arrFldSet.Contains(convAnswer.AnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.AnswerTypeId = objvAnswerEN.AnswerTypeId == "[null]" ? null :  objvAnswerEN.AnswerTypeId; //答案类型ID
}
if (arrFldSet.Contains(convAnswer.AnswerTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.AnswerTypeName = objvAnswerEN.AnswerTypeName == "[null]" ? null :  objvAnswerEN.AnswerTypeName; //答案类型名
}
if (arrFldSet.Contains(convAnswer.GridTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.GridTitle = objvAnswerEN.GridTitle == "[null]" ? null :  objvAnswerEN.GridTitle; //表格标题
}
if (arrFldSet.Contains(convAnswer.AnswerModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.AnswerModeId = objvAnswerEN.AnswerModeId == "[null]" ? null :  objvAnswerEN.AnswerModeId; //答案模式Id
}
if (arrFldSet.Contains(convAnswer.QuestionScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.QuestionScore = objvAnswerEN.QuestionScore; //题目得分
}
if (arrFldSet.Contains(convAnswer.AnswerIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.AnswerIndex = objvAnswerEN.AnswerIndex; //问答序号
}
if (arrFldSet.Contains(convAnswer.AnswerOptionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.AnswerOptionId = objvAnswerEN.AnswerOptionId == "[null]" ? null :  objvAnswerEN.AnswerOptionId; //回答选项Id
}
if (arrFldSet.Contains(convAnswer.OptionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.OptionName = objvAnswerEN.OptionName == "[null]" ? null :  objvAnswerEN.OptionName; //选项名称
}
if (arrFldSet.Contains(convAnswer.OptionTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.OptionTitle = objvAnswerEN.OptionTitle == "[null]" ? null :  objvAnswerEN.OptionTitle; //选项标题
}
if (arrFldSet.Contains(convAnswer.AnswerMultiOptions, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.AnswerMultiOptions = objvAnswerEN.AnswerMultiOptions == "[null]" ? null :  objvAnswerEN.AnswerMultiOptions; //多选项答案
}
if (arrFldSet.Contains(convAnswer.IsAutoCorrect, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.IsAutoCorrect = objvAnswerEN.IsAutoCorrect; //是否支持自动批改
}
if (arrFldSet.Contains(convAnswer.AnswerFillInBlank, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.AnswerFillInBlank = objvAnswerEN.AnswerFillInBlank == "[null]" ? null :  objvAnswerEN.AnswerFillInBlank; //填空题答案
}
if (arrFldSet.Contains(convAnswer.AnswerTrueOrFalse, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.AnswerTrueOrFalse = objvAnswerEN.AnswerTrueOrFalse; //判断题答案
}
if (arrFldSet.Contains(convAnswer.Provider, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.Provider = objvAnswerEN.Provider == "[null]" ? null :  objvAnswerEN.Provider; //提供者
}
if (arrFldSet.Contains(convAnswer.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.Score = objvAnswerEN.Score; //得分
}
if (arrFldSet.Contains(convAnswer.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.IsShow = objvAnswerEN.IsShow; //是否启用
}
if (arrFldSet.Contains(convAnswer.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.CourseId = objvAnswerEN.CourseId == "[null]" ? null :  objvAnswerEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convAnswer.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.UpdDate = objvAnswerEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convAnswer.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.UpdUser = objvAnswerEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convAnswer.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvAnswerEN.Memo = objvAnswerEN.Memo == "[null]" ? null :  objvAnswerEN.Memo; //备注
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
 /// <param name = "objvAnswerEN">源简化对象</param>
 public static void AccessFldValueNull(clsvAnswerEN objvAnswerEN)
{
try
{
if (objvAnswerEN.AnswerContent == "[null]") objvAnswerEN.AnswerContent = null; //答案内容
if (objvAnswerEN.QuestionName == "[null]") objvAnswerEN.QuestionName = null; //题目名称
if (objvAnswerEN.QuestionMemo == "[null]") objvAnswerEN.QuestionMemo = null; //题目说明
if (objvAnswerEN.QuestionTypeId == "[null]") objvAnswerEN.QuestionTypeId = null; //题目类型Id
if (objvAnswerEN.QuestionTypeName == "[null]") objvAnswerEN.QuestionTypeName = null; //题目类型名
if (objvAnswerEN.AnswerTypeId == "[null]") objvAnswerEN.AnswerTypeId = null; //答案类型ID
if (objvAnswerEN.AnswerTypeName == "[null]") objvAnswerEN.AnswerTypeName = null; //答案类型名
if (objvAnswerEN.GridTitle == "[null]") objvAnswerEN.GridTitle = null; //表格标题
if (objvAnswerEN.AnswerModeId == "[null]") objvAnswerEN.AnswerModeId = null; //答案模式Id
if (objvAnswerEN.AnswerOptionId == "[null]") objvAnswerEN.AnswerOptionId = null; //回答选项Id
if (objvAnswerEN.OptionName == "[null]") objvAnswerEN.OptionName = null; //选项名称
if (objvAnswerEN.OptionTitle == "[null]") objvAnswerEN.OptionTitle = null; //选项标题
if (objvAnswerEN.AnswerMultiOptions == "[null]") objvAnswerEN.AnswerMultiOptions = null; //多选项答案
if (objvAnswerEN.AnswerFillInBlank == "[null]") objvAnswerEN.AnswerFillInBlank = null; //填空题答案
if (objvAnswerEN.Provider == "[null]") objvAnswerEN.Provider = null; //提供者
if (objvAnswerEN.CourseId == "[null]") objvAnswerEN.CourseId = null; //课程Id
if (objvAnswerEN.Memo == "[null]") objvAnswerEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvAnswerEN objvAnswerEN)
{
 vAnswerDA.CheckProperty4Condition(objvAnswerEN);
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
if (clsAnswerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerBL没有刷新缓存机制(clsAnswerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by AnswerId");
//if (arrvAnswerObjLstCache == null)
//{
//arrvAnswerObjLstCache = vAnswerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngAnswerId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvAnswerEN GetObjByAnswerIdCache(long lngAnswerId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvAnswerEN._CurrTabName, strCourseId);
List<clsvAnswerEN> arrvAnswerObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvAnswerEN> arrvAnswerObjLst_Sel =
arrvAnswerObjLstCache
.Where(x=> x.AnswerId == lngAnswerId 
);
if (arrvAnswerObjLst_Sel.Count() == 0)
{
   clsvAnswerEN obj = clsvAnswerBL.GetObjByAnswerId(lngAnswerId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngAnswerId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvAnswerObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvAnswerEN> GetAllvAnswerObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvAnswerEN> arrvAnswerObjLstCache = GetObjLstCache(strCourseId); 
return arrvAnswerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvAnswerEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvAnswerEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvAnswerEN> arrvAnswerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvAnswerObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvAnswerEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsvAnswerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvAnswerEN._RefreshTimeLst.Count == 0) return "";
return clsvAnswerEN._RefreshTimeLst[clsvAnswerEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, long lngAnswerId, string strCourseId)
{
if (strInFldName != convAnswer.AnswerId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convAnswer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convAnswer.AttributeName));
throw new Exception(strMsg);
}
var objvAnswer = clsvAnswerBL.GetObjByAnswerIdCache(lngAnswerId, strCourseId);
if (objvAnswer == null) return "";
return objvAnswer[strOutFldName].ToString();
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
int intRecCount = clsvAnswerDA.GetRecCount(strTabName);
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
int intRecCount = clsvAnswerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvAnswerDA.GetRecCount();
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
int intRecCount = clsvAnswerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvAnswerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvAnswerEN objvAnswerCond)
{
 string strCourseId = objvAnswerCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvAnswerBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvAnswerEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvAnswerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convAnswer.AttributeName)
{
if (objvAnswerCond.IsUpdated(strFldName) == false) continue;
if (objvAnswerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvAnswerCond[strFldName].ToString());
}
else
{
if (objvAnswerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvAnswerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvAnswerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvAnswerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvAnswerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvAnswerCond[strFldName]));
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
 List<string> arrList = clsvAnswerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vAnswerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vAnswerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}