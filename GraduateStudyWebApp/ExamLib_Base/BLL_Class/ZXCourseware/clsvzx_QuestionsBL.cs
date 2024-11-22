
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_QuestionsBL
 表名:vzx_Questions(01120851)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:01
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
public static class  clsvzx_QuestionsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxQuestionsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_QuestionsEN GetObj(this K_zxQuestionsId_vzx_Questions myKey)
{
clsvzx_QuestionsEN objvzx_QuestionsEN = clsvzx_QuestionsBL.vzx_QuestionsDA.GetObjByzxQuestionsId(myKey.Value);
return objvzx_QuestionsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetzxQuestionsId(this clsvzx_QuestionsEN objvzx_QuestionsEN, string strzxQuestionsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxQuestionsId, 8, convzx_Questions.zxQuestionsId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxQuestionsId, 8, convzx_Questions.zxQuestionsId);
}
objvzx_QuestionsEN.zxQuestionsId = strzxQuestionsId; //提问Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.zxQuestionsId) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.zxQuestionsId, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.zxQuestionsId] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetUserName(this clsvzx_QuestionsEN objvzx_QuestionsEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convzx_Questions.UserName);
}
objvzx_QuestionsEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.UserName) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.UserName, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.UserName] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetQuestionsTypeName(this clsvzx_QuestionsEN objvzx_QuestionsEN, string strQuestionsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsTypeName, 50, convzx_Questions.QuestionsTypeName);
}
objvzx_QuestionsEN.QuestionsTypeName = strQuestionsTypeName; //问题类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.QuestionsTypeName) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.QuestionsTypeName, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.QuestionsTypeName] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetTextTitle(this clsvzx_QuestionsEN objvzx_QuestionsEN, string strTextTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextTitle, 500, convzx_Questions.TextTitle);
}
objvzx_QuestionsEN.TextTitle = strTextTitle; //TextTitle
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.TextTitle) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.TextTitle, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.TextTitle] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetIdCurrEduCls(this clsvzx_QuestionsEN objvzx_QuestionsEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convzx_Questions.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convzx_Questions.IdCurrEduCls);
}
objvzx_QuestionsEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.IdCurrEduCls) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.IdCurrEduCls, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.IdCurrEduCls] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetIsSubmit(this clsvzx_QuestionsEN objvzx_QuestionsEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvzx_QuestionsEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.IsSubmit) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.IsSubmit, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.IsSubmit] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetTextId(this clsvzx_QuestionsEN objvzx_QuestionsEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, convzx_Questions.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, convzx_Questions.TextId);
}
objvzx_QuestionsEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.TextId) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.TextId, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.TextId] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetQuestionsContent(this clsvzx_QuestionsEN objvzx_QuestionsEN, string strQuestionsContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsContent, 1000, convzx_Questions.QuestionsContent);
}
objvzx_QuestionsEN.QuestionsContent = strQuestionsContent; //提问内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.QuestionsContent) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.QuestionsContent, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.QuestionsContent] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetPdfPageNum(this clsvzx_QuestionsEN objvzx_QuestionsEN, int? intPdfPageNum, string strComparisonOp="")
	{
objvzx_QuestionsEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.PdfPageNum) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.PdfPageNum, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.PdfPageNum] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetPdfContent(this clsvzx_QuestionsEN objvzx_QuestionsEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convzx_Questions.PdfContent);
}
objvzx_QuestionsEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.PdfContent) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.PdfContent, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.PdfContent] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetIsDelete(this clsvzx_QuestionsEN objvzx_QuestionsEN, bool bolIsDelete, string strComparisonOp="")
	{
objvzx_QuestionsEN.IsDelete = bolIsDelete; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.IsDelete) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.IsDelete, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.IsDelete] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetIsPublic(this clsvzx_QuestionsEN objvzx_QuestionsEN, bool bolIsPublic, string strComparisonOp="")
	{
objvzx_QuestionsEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.IsPublic) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.IsPublic, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.IsPublic] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetIsEnd(this clsvzx_QuestionsEN objvzx_QuestionsEN, bool bolIsEnd, string strComparisonOp="")
	{
objvzx_QuestionsEN.IsEnd = bolIsEnd; //是否结束
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.IsEnd) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.IsEnd, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.IsEnd] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetVoteCount(this clsvzx_QuestionsEN objvzx_QuestionsEN, int? intVoteCount, string strComparisonOp="")
	{
objvzx_QuestionsEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.VoteCount) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.VoteCount, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.VoteCount] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetAnswerCount(this clsvzx_QuestionsEN objvzx_QuestionsEN, int? intAnswerCount, string strComparisonOp="")
	{
objvzx_QuestionsEN.AnswerCount = intAnswerCount; //回答计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.AnswerCount) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.AnswerCount, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.AnswerCount] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetOrderNum(this clsvzx_QuestionsEN objvzx_QuestionsEN, int? intOrderNum, string strComparisonOp="")
	{
objvzx_QuestionsEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.OrderNum) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.OrderNum, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.OrderNum] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetPdfPageTop(this clsvzx_QuestionsEN objvzx_QuestionsEN, int? intPdfPageTop, string strComparisonOp="")
	{
objvzx_QuestionsEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.PdfPageTop) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.PdfPageTop, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.PdfPageTop] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetPdfPageNumIn(this clsvzx_QuestionsEN objvzx_QuestionsEN, string strPdfPageNumIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, convzx_Questions.PdfPageNumIn);
}
objvzx_QuestionsEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.PdfPageNumIn) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.PdfPageNumIn, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.PdfPageNumIn] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetPdfDivTop(this clsvzx_QuestionsEN objvzx_QuestionsEN, string strPdfDivTop, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, convzx_Questions.PdfDivTop);
}
objvzx_QuestionsEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.PdfDivTop) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.PdfDivTop, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.PdfDivTop] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetPdfDivLet(this clsvzx_QuestionsEN objvzx_QuestionsEN, string strPdfDivLet, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, convzx_Questions.PdfDivLet);
}
objvzx_QuestionsEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.PdfDivLet) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.PdfDivLet, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.PdfDivLet] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetPdfZoom(this clsvzx_QuestionsEN objvzx_QuestionsEN, string strPdfZoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, convzx_Questions.PdfZoom);
}
objvzx_QuestionsEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.PdfZoom) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.PdfZoom, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.PdfZoom] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetUpdUser(this clsvzx_QuestionsEN objvzx_QuestionsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_Questions.UpdUser);
}
objvzx_QuestionsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.UpdUser) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.UpdUser, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.UpdUser] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetUpdDate(this clsvzx_QuestionsEN objvzx_QuestionsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_Questions.UpdDate);
}
objvzx_QuestionsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.UpdDate) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.UpdDate, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.UpdDate] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetMemo(this clsvzx_QuestionsEN objvzx_QuestionsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_Questions.Memo);
}
objvzx_QuestionsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.Memo) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.Memo, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.Memo] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetDiscussCount(this clsvzx_QuestionsEN objvzx_QuestionsEN, int? intDiscussCount, string strComparisonOp="")
	{
objvzx_QuestionsEN.DiscussCount = intDiscussCount; //DiscussCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.DiscussCount) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.DiscussCount, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.DiscussCount] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetGroupDiscussCount(this clsvzx_QuestionsEN objvzx_QuestionsEN, int? intGroupDiscussCount, string strComparisonOp="")
	{
objvzx_QuestionsEN.GroupDiscussCount = intGroupDiscussCount; //GroupDiscussCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.GroupDiscussCount) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.GroupDiscussCount, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.GroupDiscussCount] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetZxqaPaperId(this clsvzx_QuestionsEN objvzx_QuestionsEN, string strZxqaPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strZxqaPaperId, convzx_Questions.ZxqaPaperId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strZxqaPaperId, 8, convzx_Questions.ZxqaPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strZxqaPaperId, 8, convzx_Questions.ZxqaPaperId);
}
objvzx_QuestionsEN.ZxqaPaperId = strZxqaPaperId; //论文答疑Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.ZxqaPaperId) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.ZxqaPaperId, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.ZxqaPaperId] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetzxQuestionsTypeId(this clsvzx_QuestionsEN objvzx_QuestionsEN, string strzxQuestionsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxQuestionsTypeId, convzx_Questions.zxQuestionsTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxQuestionsTypeId, 2, convzx_Questions.zxQuestionsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxQuestionsTypeId, 2, convzx_Questions.zxQuestionsTypeId);
}
objvzx_QuestionsEN.zxQuestionsTypeId = strzxQuestionsTypeId; //问题类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.zxQuestionsTypeId) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.zxQuestionsTypeId, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.zxQuestionsTypeId] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetRecommendAnswerCount(this clsvzx_QuestionsEN objvzx_QuestionsEN, int? intRecommendAnswerCount, string strComparisonOp="")
	{
objvzx_QuestionsEN.RecommendAnswerCount = intRecommendAnswerCount; //RecommendAnswerCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.RecommendAnswerCount) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.RecommendAnswerCount, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.RecommendAnswerCount] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetUserId(this clsvzx_QuestionsEN objvzx_QuestionsEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convzx_Questions.UserId);
}
objvzx_QuestionsEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.UserId) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.UserId, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.UserId] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_QuestionsEN SetIdXzMajor(this clsvzx_QuestionsEN objvzx_QuestionsEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convzx_Questions.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convzx_Questions.IdXzMajor);
}
objvzx_QuestionsEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_QuestionsEN.dicFldComparisonOp.ContainsKey(convzx_Questions.IdXzMajor) == false)
{
objvzx_QuestionsEN.dicFldComparisonOp.Add(convzx_Questions.IdXzMajor, strComparisonOp);
}
else
{
objvzx_QuestionsEN.dicFldComparisonOp[convzx_Questions.IdXzMajor] = strComparisonOp;
}
}
return objvzx_QuestionsEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_QuestionsENS">源对象</param>
 /// <param name = "objvzx_QuestionsENT">目标对象</param>
 public static void CopyTo(this clsvzx_QuestionsEN objvzx_QuestionsENS, clsvzx_QuestionsEN objvzx_QuestionsENT)
{
try
{
objvzx_QuestionsENT.zxQuestionsId = objvzx_QuestionsENS.zxQuestionsId; //提问Id
objvzx_QuestionsENT.UserName = objvzx_QuestionsENS.UserName; //用户名
objvzx_QuestionsENT.QuestionsTypeName = objvzx_QuestionsENS.QuestionsTypeName; //问题类型名称
objvzx_QuestionsENT.TextTitle = objvzx_QuestionsENS.TextTitle; //TextTitle
objvzx_QuestionsENT.IdCurrEduCls = objvzx_QuestionsENS.IdCurrEduCls; //教学班流水号
objvzx_QuestionsENT.IsSubmit = objvzx_QuestionsENS.IsSubmit; //是否提交
objvzx_QuestionsENT.TextId = objvzx_QuestionsENS.TextId; //课件Id
objvzx_QuestionsENT.QuestionsContent = objvzx_QuestionsENS.QuestionsContent; //提问内容
objvzx_QuestionsENT.PdfPageNum = objvzx_QuestionsENS.PdfPageNum; //Pdf页码
objvzx_QuestionsENT.PdfContent = objvzx_QuestionsENS.PdfContent; //Pdf内容
objvzx_QuestionsENT.IsDelete = objvzx_QuestionsENS.IsDelete; //是否删除
objvzx_QuestionsENT.IsPublic = objvzx_QuestionsENS.IsPublic; //是否公开
objvzx_QuestionsENT.IsEnd = objvzx_QuestionsENS.IsEnd; //是否结束
objvzx_QuestionsENT.VoteCount = objvzx_QuestionsENS.VoteCount; //点赞计数
objvzx_QuestionsENT.AnswerCount = objvzx_QuestionsENS.AnswerCount; //回答计数
objvzx_QuestionsENT.OrderNum = objvzx_QuestionsENS.OrderNum; //序号
objvzx_QuestionsENT.PdfPageTop = objvzx_QuestionsENS.PdfPageTop; //pdf页面顶部位置
objvzx_QuestionsENT.PdfPageNumIn = objvzx_QuestionsENS.PdfPageNumIn; //PdfPageNumIn
objvzx_QuestionsENT.PdfDivTop = objvzx_QuestionsENS.PdfDivTop; //PdfDivTop
objvzx_QuestionsENT.PdfDivLet = objvzx_QuestionsENS.PdfDivLet; //PdfDivLet
objvzx_QuestionsENT.PdfZoom = objvzx_QuestionsENS.PdfZoom; //PdfZoom
objvzx_QuestionsENT.UpdUser = objvzx_QuestionsENS.UpdUser; //修改人
objvzx_QuestionsENT.UpdDate = objvzx_QuestionsENS.UpdDate; //修改日期
objvzx_QuestionsENT.Memo = objvzx_QuestionsENS.Memo; //备注
objvzx_QuestionsENT.DiscussCount = objvzx_QuestionsENS.DiscussCount; //DiscussCount
objvzx_QuestionsENT.GroupDiscussCount = objvzx_QuestionsENS.GroupDiscussCount; //GroupDiscussCount
objvzx_QuestionsENT.ZxqaPaperId = objvzx_QuestionsENS.ZxqaPaperId; //论文答疑Id
objvzx_QuestionsENT.zxQuestionsTypeId = objvzx_QuestionsENS.zxQuestionsTypeId; //问题类型Id
objvzx_QuestionsENT.RecommendAnswerCount = objvzx_QuestionsENS.RecommendAnswerCount; //RecommendAnswerCount
objvzx_QuestionsENT.UserId = objvzx_QuestionsENS.UserId; //用户ID
objvzx_QuestionsENT.IdXzMajor = objvzx_QuestionsENS.IdXzMajor; //专业流水号
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
 /// <param name = "objvzx_QuestionsENS">源对象</param>
 /// <returns>目标对象=>clsvzx_QuestionsEN:objvzx_QuestionsENT</returns>
 public static clsvzx_QuestionsEN CopyTo(this clsvzx_QuestionsEN objvzx_QuestionsENS)
{
try
{
 clsvzx_QuestionsEN objvzx_QuestionsENT = new clsvzx_QuestionsEN()
{
zxQuestionsId = objvzx_QuestionsENS.zxQuestionsId, //提问Id
UserName = objvzx_QuestionsENS.UserName, //用户名
QuestionsTypeName = objvzx_QuestionsENS.QuestionsTypeName, //问题类型名称
TextTitle = objvzx_QuestionsENS.TextTitle, //TextTitle
IdCurrEduCls = objvzx_QuestionsENS.IdCurrEduCls, //教学班流水号
IsSubmit = objvzx_QuestionsENS.IsSubmit, //是否提交
TextId = objvzx_QuestionsENS.TextId, //课件Id
QuestionsContent = objvzx_QuestionsENS.QuestionsContent, //提问内容
PdfPageNum = objvzx_QuestionsENS.PdfPageNum, //Pdf页码
PdfContent = objvzx_QuestionsENS.PdfContent, //Pdf内容
IsDelete = objvzx_QuestionsENS.IsDelete, //是否删除
IsPublic = objvzx_QuestionsENS.IsPublic, //是否公开
IsEnd = objvzx_QuestionsENS.IsEnd, //是否结束
VoteCount = objvzx_QuestionsENS.VoteCount, //点赞计数
AnswerCount = objvzx_QuestionsENS.AnswerCount, //回答计数
OrderNum = objvzx_QuestionsENS.OrderNum, //序号
PdfPageTop = objvzx_QuestionsENS.PdfPageTop, //pdf页面顶部位置
PdfPageNumIn = objvzx_QuestionsENS.PdfPageNumIn, //PdfPageNumIn
PdfDivTop = objvzx_QuestionsENS.PdfDivTop, //PdfDivTop
PdfDivLet = objvzx_QuestionsENS.PdfDivLet, //PdfDivLet
PdfZoom = objvzx_QuestionsENS.PdfZoom, //PdfZoom
UpdUser = objvzx_QuestionsENS.UpdUser, //修改人
UpdDate = objvzx_QuestionsENS.UpdDate, //修改日期
Memo = objvzx_QuestionsENS.Memo, //备注
DiscussCount = objvzx_QuestionsENS.DiscussCount, //DiscussCount
GroupDiscussCount = objvzx_QuestionsENS.GroupDiscussCount, //GroupDiscussCount
ZxqaPaperId = objvzx_QuestionsENS.ZxqaPaperId, //论文答疑Id
zxQuestionsTypeId = objvzx_QuestionsENS.zxQuestionsTypeId, //问题类型Id
RecommendAnswerCount = objvzx_QuestionsENS.RecommendAnswerCount, //RecommendAnswerCount
UserId = objvzx_QuestionsENS.UserId, //用户ID
IdXzMajor = objvzx_QuestionsENS.IdXzMajor, //专业流水号
};
 return objvzx_QuestionsENT;
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
public static void CheckProperty4Condition(this clsvzx_QuestionsEN objvzx_QuestionsEN)
{
 clsvzx_QuestionsBL.vzx_QuestionsDA.CheckProperty4Condition(objvzx_QuestionsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_QuestionsEN objvzx_QuestionsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.zxQuestionsId) == true)
{
string strComparisonOpzxQuestionsId = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.zxQuestionsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Questions.zxQuestionsId, objvzx_QuestionsCond.zxQuestionsId, strComparisonOpzxQuestionsId);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.UserName) == true)
{
string strComparisonOpUserName = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Questions.UserName, objvzx_QuestionsCond.UserName, strComparisonOpUserName);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.QuestionsTypeName) == true)
{
string strComparisonOpQuestionsTypeName = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.QuestionsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Questions.QuestionsTypeName, objvzx_QuestionsCond.QuestionsTypeName, strComparisonOpQuestionsTypeName);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.TextTitle) == true)
{
string strComparisonOpTextTitle = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.TextTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Questions.TextTitle, objvzx_QuestionsCond.TextTitle, strComparisonOpTextTitle);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Questions.IdCurrEduCls, objvzx_QuestionsCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.IsSubmit) == true)
{
if (objvzx_QuestionsCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_Questions.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_Questions.IsSubmit);
}
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.TextId) == true)
{
string strComparisonOpTextId = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Questions.TextId, objvzx_QuestionsCond.TextId, strComparisonOpTextId);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.QuestionsContent) == true)
{
string strComparisonOpQuestionsContent = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.QuestionsContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Questions.QuestionsContent, objvzx_QuestionsCond.QuestionsContent, strComparisonOpQuestionsContent);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Questions.PdfPageNum, objvzx_QuestionsCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.PdfContent) == true)
{
string strComparisonOpPdfContent = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Questions.PdfContent, objvzx_QuestionsCond.PdfContent, strComparisonOpPdfContent);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.IsDelete) == true)
{
if (objvzx_QuestionsCond.IsDelete == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_Questions.IsDelete);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_Questions.IsDelete);
}
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.IsPublic) == true)
{
if (objvzx_QuestionsCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_Questions.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_Questions.IsPublic);
}
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.IsEnd) == true)
{
if (objvzx_QuestionsCond.IsEnd == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_Questions.IsEnd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_Questions.IsEnd);
}
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.VoteCount) == true)
{
string strComparisonOpVoteCount = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Questions.VoteCount, objvzx_QuestionsCond.VoteCount, strComparisonOpVoteCount);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.AnswerCount) == true)
{
string strComparisonOpAnswerCount = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.AnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Questions.AnswerCount, objvzx_QuestionsCond.AnswerCount, strComparisonOpAnswerCount);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.OrderNum) == true)
{
string strComparisonOpOrderNum = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Questions.OrderNum, objvzx_QuestionsCond.OrderNum, strComparisonOpOrderNum);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.PdfPageTop) == true)
{
string strComparisonOpPdfPageTop = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Questions.PdfPageTop, objvzx_QuestionsCond.PdfPageTop, strComparisonOpPdfPageTop);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.PdfPageNumIn) == true)
{
string strComparisonOpPdfPageNumIn = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Questions.PdfPageNumIn, objvzx_QuestionsCond.PdfPageNumIn, strComparisonOpPdfPageNumIn);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.PdfDivTop) == true)
{
string strComparisonOpPdfDivTop = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Questions.PdfDivTop, objvzx_QuestionsCond.PdfDivTop, strComparisonOpPdfDivTop);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.PdfDivLet) == true)
{
string strComparisonOpPdfDivLet = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Questions.PdfDivLet, objvzx_QuestionsCond.PdfDivLet, strComparisonOpPdfDivLet);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.PdfZoom) == true)
{
string strComparisonOpPdfZoom = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Questions.PdfZoom, objvzx_QuestionsCond.PdfZoom, strComparisonOpPdfZoom);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Questions.UpdUser, objvzx_QuestionsCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Questions.UpdDate, objvzx_QuestionsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.Memo) == true)
{
string strComparisonOpMemo = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Questions.Memo, objvzx_QuestionsCond.Memo, strComparisonOpMemo);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.DiscussCount) == true)
{
string strComparisonOpDiscussCount = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.DiscussCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Questions.DiscussCount, objvzx_QuestionsCond.DiscussCount, strComparisonOpDiscussCount);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.GroupDiscussCount) == true)
{
string strComparisonOpGroupDiscussCount = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.GroupDiscussCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Questions.GroupDiscussCount, objvzx_QuestionsCond.GroupDiscussCount, strComparisonOpGroupDiscussCount);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.ZxqaPaperId) == true)
{
string strComparisonOpZxqaPaperId = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.ZxqaPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Questions.ZxqaPaperId, objvzx_QuestionsCond.ZxqaPaperId, strComparisonOpZxqaPaperId);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.zxQuestionsTypeId) == true)
{
string strComparisonOpzxQuestionsTypeId = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.zxQuestionsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Questions.zxQuestionsTypeId, objvzx_QuestionsCond.zxQuestionsTypeId, strComparisonOpzxQuestionsTypeId);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.RecommendAnswerCount) == true)
{
string strComparisonOpRecommendAnswerCount = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.RecommendAnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Questions.RecommendAnswerCount, objvzx_QuestionsCond.RecommendAnswerCount, strComparisonOpRecommendAnswerCount);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.UserId) == true)
{
string strComparisonOpUserId = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Questions.UserId, objvzx_QuestionsCond.UserId, strComparisonOpUserId);
}
if (objvzx_QuestionsCond.IsUpdated(convzx_Questions.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvzx_QuestionsCond.dicFldComparisonOp[convzx_Questions.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Questions.IdXzMajor, objvzx_QuestionsCond.IdXzMajor, strComparisonOpIdXzMajor);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_Questions
{
public virtual bool UpdRelaTabDate(string strzxQuestionsId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_Questions(vzx_Questions)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_QuestionsBL
{
public static RelatedActions_vzx_Questions relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_QuestionsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_QuestionsDA vzx_QuestionsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_QuestionsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_QuestionsBL()
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
if (string.IsNullOrEmpty(clsvzx_QuestionsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_QuestionsEN._ConnectString);
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
public static DataTable GetDataTable_vzx_Questions(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_QuestionsDA.GetDataTable_vzx_Questions(strWhereCond);
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
objDT = vzx_QuestionsDA.GetDataTable(strWhereCond);
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
objDT = vzx_QuestionsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_QuestionsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_QuestionsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_QuestionsDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_QuestionsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_QuestionsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_QuestionsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxQuestionsIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvzx_QuestionsEN> GetObjLstByZxQuestionsIdLst(List<string> arrZxQuestionsIdLst)
{
List<clsvzx_QuestionsEN> arrObjLst = new List<clsvzx_QuestionsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxQuestionsIdLst, true);
 string strWhereCond = string.Format("zxQuestionsId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_QuestionsEN objvzx_QuestionsEN = new clsvzx_QuestionsEN();
try
{
objvzx_QuestionsEN.zxQuestionsId = objRow[convzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_QuestionsEN.UserName = objRow[convzx_Questions.UserName] == DBNull.Value ? null : objRow[convzx_Questions.UserName].ToString().Trim(); //用户名
objvzx_QuestionsEN.QuestionsTypeName = objRow[convzx_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_QuestionsEN.TextTitle = objRow[convzx_Questions.TextTitle] == DBNull.Value ? null : objRow[convzx_Questions.TextTitle].ToString().Trim(); //TextTitle
objvzx_QuestionsEN.IdCurrEduCls = objRow[convzx_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_QuestionsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsSubmit].ToString().Trim()); //是否提交
objvzx_QuestionsEN.TextId = objRow[convzx_Questions.TextId] == DBNull.Value ? null : objRow[convzx_Questions.TextId].ToString().Trim(); //课件Id
objvzx_QuestionsEN.QuestionsContent = objRow[convzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvzx_QuestionsEN.PdfPageNum = objRow[convzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_QuestionsEN.PdfContent = objRow[convzx_Questions.PdfContent] == DBNull.Value ? null : objRow[convzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvzx_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsDelete].ToString().Trim()); //是否删除
objvzx_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsPublic].ToString().Trim()); //是否公开
objvzx_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsEnd].ToString().Trim()); //是否结束
objvzx_QuestionsEN.VoteCount = objRow[convzx_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objvzx_QuestionsEN.AnswerCount = objRow[convzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objvzx_QuestionsEN.OrderNum = objRow[convzx_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.OrderNum].ToString().Trim()); //序号
objvzx_QuestionsEN.PdfPageTop = objRow[convzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_QuestionsEN.PdfPageNumIn = objRow[convzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_QuestionsEN.PdfDivTop = objRow[convzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_QuestionsEN.PdfDivLet = objRow[convzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_QuestionsEN.PdfZoom = objRow[convzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[convzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_QuestionsEN.UpdUser = objRow[convzx_Questions.UpdUser] == DBNull.Value ? null : objRow[convzx_Questions.UpdUser].ToString().Trim(); //修改人
objvzx_QuestionsEN.UpdDate = objRow[convzx_Questions.UpdDate] == DBNull.Value ? null : objRow[convzx_Questions.UpdDate].ToString().Trim(); //修改日期
objvzx_QuestionsEN.Memo = objRow[convzx_Questions.Memo] == DBNull.Value ? null : objRow[convzx_Questions.Memo].ToString().Trim(); //备注
objvzx_QuestionsEN.DiscussCount = objRow[convzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvzx_QuestionsEN.GroupDiscussCount = objRow[convzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvzx_QuestionsEN.ZxqaPaperId = objRow[convzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_QuestionsEN.zxQuestionsTypeId = objRow[convzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_QuestionsEN.RecommendAnswerCount = objRow[convzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
objvzx_QuestionsEN.UserId = objRow[convzx_Questions.UserId] == DBNull.Value ? null : objRow[convzx_Questions.UserId].ToString().Trim(); //用户ID
objvzx_QuestionsEN.IdXzMajor = objRow[convzx_Questions.IdXzMajor] == DBNull.Value ? null : objRow[convzx_Questions.IdXzMajor].ToString().Trim(); //专业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_QuestionsEN.zxQuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_QuestionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxQuestionsIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_QuestionsEN> GetObjLstByZxQuestionsIdLstCache(List<string> arrZxQuestionsIdLst)
{
string strKey = string.Format("{0}", clsvzx_QuestionsEN._CurrTabName);
List<clsvzx_QuestionsEN> arrvzx_QuestionsObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_QuestionsEN> arrvzx_QuestionsObjLst_Sel =
arrvzx_QuestionsObjLstCache
.Where(x => arrZxQuestionsIdLst.Contains(x.zxQuestionsId));
return arrvzx_QuestionsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_QuestionsEN> GetObjLst(string strWhereCond)
{
List<clsvzx_QuestionsEN> arrObjLst = new List<clsvzx_QuestionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_QuestionsEN objvzx_QuestionsEN = new clsvzx_QuestionsEN();
try
{
objvzx_QuestionsEN.zxQuestionsId = objRow[convzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_QuestionsEN.UserName = objRow[convzx_Questions.UserName] == DBNull.Value ? null : objRow[convzx_Questions.UserName].ToString().Trim(); //用户名
objvzx_QuestionsEN.QuestionsTypeName = objRow[convzx_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_QuestionsEN.TextTitle = objRow[convzx_Questions.TextTitle] == DBNull.Value ? null : objRow[convzx_Questions.TextTitle].ToString().Trim(); //TextTitle
objvzx_QuestionsEN.IdCurrEduCls = objRow[convzx_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_QuestionsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsSubmit].ToString().Trim()); //是否提交
objvzx_QuestionsEN.TextId = objRow[convzx_Questions.TextId] == DBNull.Value ? null : objRow[convzx_Questions.TextId].ToString().Trim(); //课件Id
objvzx_QuestionsEN.QuestionsContent = objRow[convzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvzx_QuestionsEN.PdfPageNum = objRow[convzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_QuestionsEN.PdfContent = objRow[convzx_Questions.PdfContent] == DBNull.Value ? null : objRow[convzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvzx_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsDelete].ToString().Trim()); //是否删除
objvzx_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsPublic].ToString().Trim()); //是否公开
objvzx_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsEnd].ToString().Trim()); //是否结束
objvzx_QuestionsEN.VoteCount = objRow[convzx_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objvzx_QuestionsEN.AnswerCount = objRow[convzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objvzx_QuestionsEN.OrderNum = objRow[convzx_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.OrderNum].ToString().Trim()); //序号
objvzx_QuestionsEN.PdfPageTop = objRow[convzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_QuestionsEN.PdfPageNumIn = objRow[convzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_QuestionsEN.PdfDivTop = objRow[convzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_QuestionsEN.PdfDivLet = objRow[convzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_QuestionsEN.PdfZoom = objRow[convzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[convzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_QuestionsEN.UpdUser = objRow[convzx_Questions.UpdUser] == DBNull.Value ? null : objRow[convzx_Questions.UpdUser].ToString().Trim(); //修改人
objvzx_QuestionsEN.UpdDate = objRow[convzx_Questions.UpdDate] == DBNull.Value ? null : objRow[convzx_Questions.UpdDate].ToString().Trim(); //修改日期
objvzx_QuestionsEN.Memo = objRow[convzx_Questions.Memo] == DBNull.Value ? null : objRow[convzx_Questions.Memo].ToString().Trim(); //备注
objvzx_QuestionsEN.DiscussCount = objRow[convzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvzx_QuestionsEN.GroupDiscussCount = objRow[convzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvzx_QuestionsEN.ZxqaPaperId = objRow[convzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_QuestionsEN.zxQuestionsTypeId = objRow[convzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_QuestionsEN.RecommendAnswerCount = objRow[convzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
objvzx_QuestionsEN.UserId = objRow[convzx_Questions.UserId] == DBNull.Value ? null : objRow[convzx_Questions.UserId].ToString().Trim(); //用户ID
objvzx_QuestionsEN.IdXzMajor = objRow[convzx_Questions.IdXzMajor] == DBNull.Value ? null : objRow[convzx_Questions.IdXzMajor].ToString().Trim(); //专业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_QuestionsEN.zxQuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_QuestionsEN);
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
public static List<clsvzx_QuestionsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_QuestionsEN> arrObjLst = new List<clsvzx_QuestionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_QuestionsEN objvzx_QuestionsEN = new clsvzx_QuestionsEN();
try
{
objvzx_QuestionsEN.zxQuestionsId = objRow[convzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_QuestionsEN.UserName = objRow[convzx_Questions.UserName] == DBNull.Value ? null : objRow[convzx_Questions.UserName].ToString().Trim(); //用户名
objvzx_QuestionsEN.QuestionsTypeName = objRow[convzx_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_QuestionsEN.TextTitle = objRow[convzx_Questions.TextTitle] == DBNull.Value ? null : objRow[convzx_Questions.TextTitle].ToString().Trim(); //TextTitle
objvzx_QuestionsEN.IdCurrEduCls = objRow[convzx_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_QuestionsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsSubmit].ToString().Trim()); //是否提交
objvzx_QuestionsEN.TextId = objRow[convzx_Questions.TextId] == DBNull.Value ? null : objRow[convzx_Questions.TextId].ToString().Trim(); //课件Id
objvzx_QuestionsEN.QuestionsContent = objRow[convzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvzx_QuestionsEN.PdfPageNum = objRow[convzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_QuestionsEN.PdfContent = objRow[convzx_Questions.PdfContent] == DBNull.Value ? null : objRow[convzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvzx_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsDelete].ToString().Trim()); //是否删除
objvzx_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsPublic].ToString().Trim()); //是否公开
objvzx_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsEnd].ToString().Trim()); //是否结束
objvzx_QuestionsEN.VoteCount = objRow[convzx_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objvzx_QuestionsEN.AnswerCount = objRow[convzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objvzx_QuestionsEN.OrderNum = objRow[convzx_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.OrderNum].ToString().Trim()); //序号
objvzx_QuestionsEN.PdfPageTop = objRow[convzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_QuestionsEN.PdfPageNumIn = objRow[convzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_QuestionsEN.PdfDivTop = objRow[convzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_QuestionsEN.PdfDivLet = objRow[convzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_QuestionsEN.PdfZoom = objRow[convzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[convzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_QuestionsEN.UpdUser = objRow[convzx_Questions.UpdUser] == DBNull.Value ? null : objRow[convzx_Questions.UpdUser].ToString().Trim(); //修改人
objvzx_QuestionsEN.UpdDate = objRow[convzx_Questions.UpdDate] == DBNull.Value ? null : objRow[convzx_Questions.UpdDate].ToString().Trim(); //修改日期
objvzx_QuestionsEN.Memo = objRow[convzx_Questions.Memo] == DBNull.Value ? null : objRow[convzx_Questions.Memo].ToString().Trim(); //备注
objvzx_QuestionsEN.DiscussCount = objRow[convzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvzx_QuestionsEN.GroupDiscussCount = objRow[convzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvzx_QuestionsEN.ZxqaPaperId = objRow[convzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_QuestionsEN.zxQuestionsTypeId = objRow[convzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_QuestionsEN.RecommendAnswerCount = objRow[convzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
objvzx_QuestionsEN.UserId = objRow[convzx_Questions.UserId] == DBNull.Value ? null : objRow[convzx_Questions.UserId].ToString().Trim(); //用户ID
objvzx_QuestionsEN.IdXzMajor = objRow[convzx_Questions.IdXzMajor] == DBNull.Value ? null : objRow[convzx_Questions.IdXzMajor].ToString().Trim(); //专业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_QuestionsEN.zxQuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_QuestionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_QuestionsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_QuestionsEN> GetSubObjLstCache(clsvzx_QuestionsEN objvzx_QuestionsCond)
{
List<clsvzx_QuestionsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_QuestionsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_Questions.AttributeName)
{
if (objvzx_QuestionsCond.IsUpdated(strFldName) == false) continue;
if (objvzx_QuestionsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_QuestionsCond[strFldName].ToString());
}
else
{
if (objvzx_QuestionsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_QuestionsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_QuestionsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_QuestionsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_QuestionsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_QuestionsCond[strFldName]));
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
public static List<clsvzx_QuestionsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_QuestionsEN> arrObjLst = new List<clsvzx_QuestionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_QuestionsEN objvzx_QuestionsEN = new clsvzx_QuestionsEN();
try
{
objvzx_QuestionsEN.zxQuestionsId = objRow[convzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_QuestionsEN.UserName = objRow[convzx_Questions.UserName] == DBNull.Value ? null : objRow[convzx_Questions.UserName].ToString().Trim(); //用户名
objvzx_QuestionsEN.QuestionsTypeName = objRow[convzx_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_QuestionsEN.TextTitle = objRow[convzx_Questions.TextTitle] == DBNull.Value ? null : objRow[convzx_Questions.TextTitle].ToString().Trim(); //TextTitle
objvzx_QuestionsEN.IdCurrEduCls = objRow[convzx_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_QuestionsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsSubmit].ToString().Trim()); //是否提交
objvzx_QuestionsEN.TextId = objRow[convzx_Questions.TextId] == DBNull.Value ? null : objRow[convzx_Questions.TextId].ToString().Trim(); //课件Id
objvzx_QuestionsEN.QuestionsContent = objRow[convzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvzx_QuestionsEN.PdfPageNum = objRow[convzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_QuestionsEN.PdfContent = objRow[convzx_Questions.PdfContent] == DBNull.Value ? null : objRow[convzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvzx_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsDelete].ToString().Trim()); //是否删除
objvzx_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsPublic].ToString().Trim()); //是否公开
objvzx_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsEnd].ToString().Trim()); //是否结束
objvzx_QuestionsEN.VoteCount = objRow[convzx_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objvzx_QuestionsEN.AnswerCount = objRow[convzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objvzx_QuestionsEN.OrderNum = objRow[convzx_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.OrderNum].ToString().Trim()); //序号
objvzx_QuestionsEN.PdfPageTop = objRow[convzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_QuestionsEN.PdfPageNumIn = objRow[convzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_QuestionsEN.PdfDivTop = objRow[convzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_QuestionsEN.PdfDivLet = objRow[convzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_QuestionsEN.PdfZoom = objRow[convzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[convzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_QuestionsEN.UpdUser = objRow[convzx_Questions.UpdUser] == DBNull.Value ? null : objRow[convzx_Questions.UpdUser].ToString().Trim(); //修改人
objvzx_QuestionsEN.UpdDate = objRow[convzx_Questions.UpdDate] == DBNull.Value ? null : objRow[convzx_Questions.UpdDate].ToString().Trim(); //修改日期
objvzx_QuestionsEN.Memo = objRow[convzx_Questions.Memo] == DBNull.Value ? null : objRow[convzx_Questions.Memo].ToString().Trim(); //备注
objvzx_QuestionsEN.DiscussCount = objRow[convzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvzx_QuestionsEN.GroupDiscussCount = objRow[convzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvzx_QuestionsEN.ZxqaPaperId = objRow[convzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_QuestionsEN.zxQuestionsTypeId = objRow[convzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_QuestionsEN.RecommendAnswerCount = objRow[convzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
objvzx_QuestionsEN.UserId = objRow[convzx_Questions.UserId] == DBNull.Value ? null : objRow[convzx_Questions.UserId].ToString().Trim(); //用户ID
objvzx_QuestionsEN.IdXzMajor = objRow[convzx_Questions.IdXzMajor] == DBNull.Value ? null : objRow[convzx_Questions.IdXzMajor].ToString().Trim(); //专业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_QuestionsEN.zxQuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_QuestionsEN);
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
public static List<clsvzx_QuestionsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_QuestionsEN> arrObjLst = new List<clsvzx_QuestionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_QuestionsEN objvzx_QuestionsEN = new clsvzx_QuestionsEN();
try
{
objvzx_QuestionsEN.zxQuestionsId = objRow[convzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_QuestionsEN.UserName = objRow[convzx_Questions.UserName] == DBNull.Value ? null : objRow[convzx_Questions.UserName].ToString().Trim(); //用户名
objvzx_QuestionsEN.QuestionsTypeName = objRow[convzx_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_QuestionsEN.TextTitle = objRow[convzx_Questions.TextTitle] == DBNull.Value ? null : objRow[convzx_Questions.TextTitle].ToString().Trim(); //TextTitle
objvzx_QuestionsEN.IdCurrEduCls = objRow[convzx_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_QuestionsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsSubmit].ToString().Trim()); //是否提交
objvzx_QuestionsEN.TextId = objRow[convzx_Questions.TextId] == DBNull.Value ? null : objRow[convzx_Questions.TextId].ToString().Trim(); //课件Id
objvzx_QuestionsEN.QuestionsContent = objRow[convzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvzx_QuestionsEN.PdfPageNum = objRow[convzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_QuestionsEN.PdfContent = objRow[convzx_Questions.PdfContent] == DBNull.Value ? null : objRow[convzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvzx_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsDelete].ToString().Trim()); //是否删除
objvzx_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsPublic].ToString().Trim()); //是否公开
objvzx_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsEnd].ToString().Trim()); //是否结束
objvzx_QuestionsEN.VoteCount = objRow[convzx_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objvzx_QuestionsEN.AnswerCount = objRow[convzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objvzx_QuestionsEN.OrderNum = objRow[convzx_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.OrderNum].ToString().Trim()); //序号
objvzx_QuestionsEN.PdfPageTop = objRow[convzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_QuestionsEN.PdfPageNumIn = objRow[convzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_QuestionsEN.PdfDivTop = objRow[convzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_QuestionsEN.PdfDivLet = objRow[convzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_QuestionsEN.PdfZoom = objRow[convzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[convzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_QuestionsEN.UpdUser = objRow[convzx_Questions.UpdUser] == DBNull.Value ? null : objRow[convzx_Questions.UpdUser].ToString().Trim(); //修改人
objvzx_QuestionsEN.UpdDate = objRow[convzx_Questions.UpdDate] == DBNull.Value ? null : objRow[convzx_Questions.UpdDate].ToString().Trim(); //修改日期
objvzx_QuestionsEN.Memo = objRow[convzx_Questions.Memo] == DBNull.Value ? null : objRow[convzx_Questions.Memo].ToString().Trim(); //备注
objvzx_QuestionsEN.DiscussCount = objRow[convzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvzx_QuestionsEN.GroupDiscussCount = objRow[convzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvzx_QuestionsEN.ZxqaPaperId = objRow[convzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_QuestionsEN.zxQuestionsTypeId = objRow[convzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_QuestionsEN.RecommendAnswerCount = objRow[convzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
objvzx_QuestionsEN.UserId = objRow[convzx_Questions.UserId] == DBNull.Value ? null : objRow[convzx_Questions.UserId].ToString().Trim(); //用户ID
objvzx_QuestionsEN.IdXzMajor = objRow[convzx_Questions.IdXzMajor] == DBNull.Value ? null : objRow[convzx_Questions.IdXzMajor].ToString().Trim(); //专业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_QuestionsEN.zxQuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_QuestionsEN);
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
List<clsvzx_QuestionsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_QuestionsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_QuestionsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_QuestionsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_QuestionsEN> arrObjLst = new List<clsvzx_QuestionsEN>(); 
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
	clsvzx_QuestionsEN objvzx_QuestionsEN = new clsvzx_QuestionsEN();
try
{
objvzx_QuestionsEN.zxQuestionsId = objRow[convzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_QuestionsEN.UserName = objRow[convzx_Questions.UserName] == DBNull.Value ? null : objRow[convzx_Questions.UserName].ToString().Trim(); //用户名
objvzx_QuestionsEN.QuestionsTypeName = objRow[convzx_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_QuestionsEN.TextTitle = objRow[convzx_Questions.TextTitle] == DBNull.Value ? null : objRow[convzx_Questions.TextTitle].ToString().Trim(); //TextTitle
objvzx_QuestionsEN.IdCurrEduCls = objRow[convzx_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_QuestionsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsSubmit].ToString().Trim()); //是否提交
objvzx_QuestionsEN.TextId = objRow[convzx_Questions.TextId] == DBNull.Value ? null : objRow[convzx_Questions.TextId].ToString().Trim(); //课件Id
objvzx_QuestionsEN.QuestionsContent = objRow[convzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvzx_QuestionsEN.PdfPageNum = objRow[convzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_QuestionsEN.PdfContent = objRow[convzx_Questions.PdfContent] == DBNull.Value ? null : objRow[convzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvzx_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsDelete].ToString().Trim()); //是否删除
objvzx_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsPublic].ToString().Trim()); //是否公开
objvzx_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsEnd].ToString().Trim()); //是否结束
objvzx_QuestionsEN.VoteCount = objRow[convzx_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objvzx_QuestionsEN.AnswerCount = objRow[convzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objvzx_QuestionsEN.OrderNum = objRow[convzx_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.OrderNum].ToString().Trim()); //序号
objvzx_QuestionsEN.PdfPageTop = objRow[convzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_QuestionsEN.PdfPageNumIn = objRow[convzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_QuestionsEN.PdfDivTop = objRow[convzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_QuestionsEN.PdfDivLet = objRow[convzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_QuestionsEN.PdfZoom = objRow[convzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[convzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_QuestionsEN.UpdUser = objRow[convzx_Questions.UpdUser] == DBNull.Value ? null : objRow[convzx_Questions.UpdUser].ToString().Trim(); //修改人
objvzx_QuestionsEN.UpdDate = objRow[convzx_Questions.UpdDate] == DBNull.Value ? null : objRow[convzx_Questions.UpdDate].ToString().Trim(); //修改日期
objvzx_QuestionsEN.Memo = objRow[convzx_Questions.Memo] == DBNull.Value ? null : objRow[convzx_Questions.Memo].ToString().Trim(); //备注
objvzx_QuestionsEN.DiscussCount = objRow[convzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvzx_QuestionsEN.GroupDiscussCount = objRow[convzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvzx_QuestionsEN.ZxqaPaperId = objRow[convzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_QuestionsEN.zxQuestionsTypeId = objRow[convzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_QuestionsEN.RecommendAnswerCount = objRow[convzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
objvzx_QuestionsEN.UserId = objRow[convzx_Questions.UserId] == DBNull.Value ? null : objRow[convzx_Questions.UserId].ToString().Trim(); //用户ID
objvzx_QuestionsEN.IdXzMajor = objRow[convzx_Questions.IdXzMajor] == DBNull.Value ? null : objRow[convzx_Questions.IdXzMajor].ToString().Trim(); //专业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_QuestionsEN.zxQuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_QuestionsEN);
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
public static List<clsvzx_QuestionsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_QuestionsEN> arrObjLst = new List<clsvzx_QuestionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_QuestionsEN objvzx_QuestionsEN = new clsvzx_QuestionsEN();
try
{
objvzx_QuestionsEN.zxQuestionsId = objRow[convzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_QuestionsEN.UserName = objRow[convzx_Questions.UserName] == DBNull.Value ? null : objRow[convzx_Questions.UserName].ToString().Trim(); //用户名
objvzx_QuestionsEN.QuestionsTypeName = objRow[convzx_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_QuestionsEN.TextTitle = objRow[convzx_Questions.TextTitle] == DBNull.Value ? null : objRow[convzx_Questions.TextTitle].ToString().Trim(); //TextTitle
objvzx_QuestionsEN.IdCurrEduCls = objRow[convzx_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_QuestionsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsSubmit].ToString().Trim()); //是否提交
objvzx_QuestionsEN.TextId = objRow[convzx_Questions.TextId] == DBNull.Value ? null : objRow[convzx_Questions.TextId].ToString().Trim(); //课件Id
objvzx_QuestionsEN.QuestionsContent = objRow[convzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvzx_QuestionsEN.PdfPageNum = objRow[convzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_QuestionsEN.PdfContent = objRow[convzx_Questions.PdfContent] == DBNull.Value ? null : objRow[convzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvzx_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsDelete].ToString().Trim()); //是否删除
objvzx_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsPublic].ToString().Trim()); //是否公开
objvzx_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsEnd].ToString().Trim()); //是否结束
objvzx_QuestionsEN.VoteCount = objRow[convzx_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objvzx_QuestionsEN.AnswerCount = objRow[convzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objvzx_QuestionsEN.OrderNum = objRow[convzx_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.OrderNum].ToString().Trim()); //序号
objvzx_QuestionsEN.PdfPageTop = objRow[convzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_QuestionsEN.PdfPageNumIn = objRow[convzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_QuestionsEN.PdfDivTop = objRow[convzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_QuestionsEN.PdfDivLet = objRow[convzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_QuestionsEN.PdfZoom = objRow[convzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[convzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_QuestionsEN.UpdUser = objRow[convzx_Questions.UpdUser] == DBNull.Value ? null : objRow[convzx_Questions.UpdUser].ToString().Trim(); //修改人
objvzx_QuestionsEN.UpdDate = objRow[convzx_Questions.UpdDate] == DBNull.Value ? null : objRow[convzx_Questions.UpdDate].ToString().Trim(); //修改日期
objvzx_QuestionsEN.Memo = objRow[convzx_Questions.Memo] == DBNull.Value ? null : objRow[convzx_Questions.Memo].ToString().Trim(); //备注
objvzx_QuestionsEN.DiscussCount = objRow[convzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvzx_QuestionsEN.GroupDiscussCount = objRow[convzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvzx_QuestionsEN.ZxqaPaperId = objRow[convzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_QuestionsEN.zxQuestionsTypeId = objRow[convzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_QuestionsEN.RecommendAnswerCount = objRow[convzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
objvzx_QuestionsEN.UserId = objRow[convzx_Questions.UserId] == DBNull.Value ? null : objRow[convzx_Questions.UserId].ToString().Trim(); //用户ID
objvzx_QuestionsEN.IdXzMajor = objRow[convzx_Questions.IdXzMajor] == DBNull.Value ? null : objRow[convzx_Questions.IdXzMajor].ToString().Trim(); //专业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_QuestionsEN.zxQuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_QuestionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_QuestionsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_QuestionsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_QuestionsEN> arrObjLst = new List<clsvzx_QuestionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_QuestionsEN objvzx_QuestionsEN = new clsvzx_QuestionsEN();
try
{
objvzx_QuestionsEN.zxQuestionsId = objRow[convzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_QuestionsEN.UserName = objRow[convzx_Questions.UserName] == DBNull.Value ? null : objRow[convzx_Questions.UserName].ToString().Trim(); //用户名
objvzx_QuestionsEN.QuestionsTypeName = objRow[convzx_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_QuestionsEN.TextTitle = objRow[convzx_Questions.TextTitle] == DBNull.Value ? null : objRow[convzx_Questions.TextTitle].ToString().Trim(); //TextTitle
objvzx_QuestionsEN.IdCurrEduCls = objRow[convzx_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_QuestionsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsSubmit].ToString().Trim()); //是否提交
objvzx_QuestionsEN.TextId = objRow[convzx_Questions.TextId] == DBNull.Value ? null : objRow[convzx_Questions.TextId].ToString().Trim(); //课件Id
objvzx_QuestionsEN.QuestionsContent = objRow[convzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvzx_QuestionsEN.PdfPageNum = objRow[convzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_QuestionsEN.PdfContent = objRow[convzx_Questions.PdfContent] == DBNull.Value ? null : objRow[convzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvzx_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsDelete].ToString().Trim()); //是否删除
objvzx_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsPublic].ToString().Trim()); //是否公开
objvzx_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsEnd].ToString().Trim()); //是否结束
objvzx_QuestionsEN.VoteCount = objRow[convzx_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objvzx_QuestionsEN.AnswerCount = objRow[convzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objvzx_QuestionsEN.OrderNum = objRow[convzx_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.OrderNum].ToString().Trim()); //序号
objvzx_QuestionsEN.PdfPageTop = objRow[convzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_QuestionsEN.PdfPageNumIn = objRow[convzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_QuestionsEN.PdfDivTop = objRow[convzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_QuestionsEN.PdfDivLet = objRow[convzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_QuestionsEN.PdfZoom = objRow[convzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[convzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_QuestionsEN.UpdUser = objRow[convzx_Questions.UpdUser] == DBNull.Value ? null : objRow[convzx_Questions.UpdUser].ToString().Trim(); //修改人
objvzx_QuestionsEN.UpdDate = objRow[convzx_Questions.UpdDate] == DBNull.Value ? null : objRow[convzx_Questions.UpdDate].ToString().Trim(); //修改日期
objvzx_QuestionsEN.Memo = objRow[convzx_Questions.Memo] == DBNull.Value ? null : objRow[convzx_Questions.Memo].ToString().Trim(); //备注
objvzx_QuestionsEN.DiscussCount = objRow[convzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvzx_QuestionsEN.GroupDiscussCount = objRow[convzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvzx_QuestionsEN.ZxqaPaperId = objRow[convzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_QuestionsEN.zxQuestionsTypeId = objRow[convzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_QuestionsEN.RecommendAnswerCount = objRow[convzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
objvzx_QuestionsEN.UserId = objRow[convzx_Questions.UserId] == DBNull.Value ? null : objRow[convzx_Questions.UserId].ToString().Trim(); //用户ID
objvzx_QuestionsEN.IdXzMajor = objRow[convzx_Questions.IdXzMajor] == DBNull.Value ? null : objRow[convzx_Questions.IdXzMajor].ToString().Trim(); //专业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_QuestionsEN.zxQuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_QuestionsEN);
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
public static List<clsvzx_QuestionsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_QuestionsEN> arrObjLst = new List<clsvzx_QuestionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_QuestionsEN objvzx_QuestionsEN = new clsvzx_QuestionsEN();
try
{
objvzx_QuestionsEN.zxQuestionsId = objRow[convzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_QuestionsEN.UserName = objRow[convzx_Questions.UserName] == DBNull.Value ? null : objRow[convzx_Questions.UserName].ToString().Trim(); //用户名
objvzx_QuestionsEN.QuestionsTypeName = objRow[convzx_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_QuestionsEN.TextTitle = objRow[convzx_Questions.TextTitle] == DBNull.Value ? null : objRow[convzx_Questions.TextTitle].ToString().Trim(); //TextTitle
objvzx_QuestionsEN.IdCurrEduCls = objRow[convzx_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_QuestionsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsSubmit].ToString().Trim()); //是否提交
objvzx_QuestionsEN.TextId = objRow[convzx_Questions.TextId] == DBNull.Value ? null : objRow[convzx_Questions.TextId].ToString().Trim(); //课件Id
objvzx_QuestionsEN.QuestionsContent = objRow[convzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvzx_QuestionsEN.PdfPageNum = objRow[convzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_QuestionsEN.PdfContent = objRow[convzx_Questions.PdfContent] == DBNull.Value ? null : objRow[convzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvzx_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsDelete].ToString().Trim()); //是否删除
objvzx_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsPublic].ToString().Trim()); //是否公开
objvzx_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsEnd].ToString().Trim()); //是否结束
objvzx_QuestionsEN.VoteCount = objRow[convzx_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objvzx_QuestionsEN.AnswerCount = objRow[convzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objvzx_QuestionsEN.OrderNum = objRow[convzx_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.OrderNum].ToString().Trim()); //序号
objvzx_QuestionsEN.PdfPageTop = objRow[convzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_QuestionsEN.PdfPageNumIn = objRow[convzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_QuestionsEN.PdfDivTop = objRow[convzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_QuestionsEN.PdfDivLet = objRow[convzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_QuestionsEN.PdfZoom = objRow[convzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[convzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_QuestionsEN.UpdUser = objRow[convzx_Questions.UpdUser] == DBNull.Value ? null : objRow[convzx_Questions.UpdUser].ToString().Trim(); //修改人
objvzx_QuestionsEN.UpdDate = objRow[convzx_Questions.UpdDate] == DBNull.Value ? null : objRow[convzx_Questions.UpdDate].ToString().Trim(); //修改日期
objvzx_QuestionsEN.Memo = objRow[convzx_Questions.Memo] == DBNull.Value ? null : objRow[convzx_Questions.Memo].ToString().Trim(); //备注
objvzx_QuestionsEN.DiscussCount = objRow[convzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvzx_QuestionsEN.GroupDiscussCount = objRow[convzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvzx_QuestionsEN.ZxqaPaperId = objRow[convzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_QuestionsEN.zxQuestionsTypeId = objRow[convzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_QuestionsEN.RecommendAnswerCount = objRow[convzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
objvzx_QuestionsEN.UserId = objRow[convzx_Questions.UserId] == DBNull.Value ? null : objRow[convzx_Questions.UserId].ToString().Trim(); //用户ID
objvzx_QuestionsEN.IdXzMajor = objRow[convzx_Questions.IdXzMajor] == DBNull.Value ? null : objRow[convzx_Questions.IdXzMajor].ToString().Trim(); //专业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_QuestionsEN.zxQuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_QuestionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_QuestionsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_QuestionsEN> arrObjLst = new List<clsvzx_QuestionsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_QuestionsEN objvzx_QuestionsEN = new clsvzx_QuestionsEN();
try
{
objvzx_QuestionsEN.zxQuestionsId = objRow[convzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_QuestionsEN.UserName = objRow[convzx_Questions.UserName] == DBNull.Value ? null : objRow[convzx_Questions.UserName].ToString().Trim(); //用户名
objvzx_QuestionsEN.QuestionsTypeName = objRow[convzx_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_QuestionsEN.TextTitle = objRow[convzx_Questions.TextTitle] == DBNull.Value ? null : objRow[convzx_Questions.TextTitle].ToString().Trim(); //TextTitle
objvzx_QuestionsEN.IdCurrEduCls = objRow[convzx_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_QuestionsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsSubmit].ToString().Trim()); //是否提交
objvzx_QuestionsEN.TextId = objRow[convzx_Questions.TextId] == DBNull.Value ? null : objRow[convzx_Questions.TextId].ToString().Trim(); //课件Id
objvzx_QuestionsEN.QuestionsContent = objRow[convzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvzx_QuestionsEN.PdfPageNum = objRow[convzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_QuestionsEN.PdfContent = objRow[convzx_Questions.PdfContent] == DBNull.Value ? null : objRow[convzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvzx_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsDelete].ToString().Trim()); //是否删除
objvzx_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsPublic].ToString().Trim()); //是否公开
objvzx_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsEnd].ToString().Trim()); //是否结束
objvzx_QuestionsEN.VoteCount = objRow[convzx_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objvzx_QuestionsEN.AnswerCount = objRow[convzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objvzx_QuestionsEN.OrderNum = objRow[convzx_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.OrderNum].ToString().Trim()); //序号
objvzx_QuestionsEN.PdfPageTop = objRow[convzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_QuestionsEN.PdfPageNumIn = objRow[convzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_QuestionsEN.PdfDivTop = objRow[convzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_QuestionsEN.PdfDivLet = objRow[convzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_QuestionsEN.PdfZoom = objRow[convzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[convzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_QuestionsEN.UpdUser = objRow[convzx_Questions.UpdUser] == DBNull.Value ? null : objRow[convzx_Questions.UpdUser].ToString().Trim(); //修改人
objvzx_QuestionsEN.UpdDate = objRow[convzx_Questions.UpdDate] == DBNull.Value ? null : objRow[convzx_Questions.UpdDate].ToString().Trim(); //修改日期
objvzx_QuestionsEN.Memo = objRow[convzx_Questions.Memo] == DBNull.Value ? null : objRow[convzx_Questions.Memo].ToString().Trim(); //备注
objvzx_QuestionsEN.DiscussCount = objRow[convzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvzx_QuestionsEN.GroupDiscussCount = objRow[convzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvzx_QuestionsEN.ZxqaPaperId = objRow[convzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_QuestionsEN.zxQuestionsTypeId = objRow[convzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_QuestionsEN.RecommendAnswerCount = objRow[convzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
objvzx_QuestionsEN.UserId = objRow[convzx_Questions.UserId] == DBNull.Value ? null : objRow[convzx_Questions.UserId].ToString().Trim(); //用户ID
objvzx_QuestionsEN.IdXzMajor = objRow[convzx_Questions.IdXzMajor] == DBNull.Value ? null : objRow[convzx_Questions.IdXzMajor].ToString().Trim(); //专业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_QuestionsEN.zxQuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_QuestionsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_Questions(ref clsvzx_QuestionsEN objvzx_QuestionsEN)
{
bool bolResult = vzx_QuestionsDA.Getvzx_Questions(ref objvzx_QuestionsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxQuestionsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_QuestionsEN GetObjByzxQuestionsId(string strzxQuestionsId)
{
if (strzxQuestionsId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxQuestionsId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxQuestionsId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxQuestionsId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvzx_QuestionsEN objvzx_QuestionsEN = vzx_QuestionsDA.GetObjByzxQuestionsId(strzxQuestionsId);
return objvzx_QuestionsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_QuestionsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_QuestionsEN objvzx_QuestionsEN = vzx_QuestionsDA.GetFirstObj(strWhereCond);
 return objvzx_QuestionsEN;
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
public static clsvzx_QuestionsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_QuestionsEN objvzx_QuestionsEN = vzx_QuestionsDA.GetObjByDataRow(objRow);
 return objvzx_QuestionsEN;
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
public static clsvzx_QuestionsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_QuestionsEN objvzx_QuestionsEN = vzx_QuestionsDA.GetObjByDataRow(objRow);
 return objvzx_QuestionsEN;
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
 /// <param name = "strzxQuestionsId">所给的关键字</param>
 /// <param name = "lstvzx_QuestionsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_QuestionsEN GetObjByzxQuestionsIdFromList(string strzxQuestionsId, List<clsvzx_QuestionsEN> lstvzx_QuestionsObjLst)
{
foreach (clsvzx_QuestionsEN objvzx_QuestionsEN in lstvzx_QuestionsObjLst)
{
if (objvzx_QuestionsEN.zxQuestionsId == strzxQuestionsId)
{
return objvzx_QuestionsEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxZxQuestionsId;
 try
 {
 strMaxZxQuestionsId = clsvzx_QuestionsDA.GetMaxStrId();
 return strMaxZxQuestionsId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strzxQuestionsId;
 try
 {
 strzxQuestionsId = new clsvzx_QuestionsDA().GetFirstID(strWhereCond);
 return strzxQuestionsId;
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
 arrList = vzx_QuestionsDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_QuestionsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxQuestionsId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxQuestionsId)
{
if (string.IsNullOrEmpty(strzxQuestionsId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxQuestionsId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vzx_QuestionsDA.IsExist(strzxQuestionsId);
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
 bolIsExist = clsvzx_QuestionsDA.IsExistTable();
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
 bolIsExist = vzx_QuestionsDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_QuestionsENS">源对象</param>
 /// <param name = "objvzx_QuestionsENT">目标对象</param>
 public static void CopyTo(clsvzx_QuestionsEN objvzx_QuestionsENS, clsvzx_QuestionsEN objvzx_QuestionsENT)
{
try
{
objvzx_QuestionsENT.zxQuestionsId = objvzx_QuestionsENS.zxQuestionsId; //提问Id
objvzx_QuestionsENT.UserName = objvzx_QuestionsENS.UserName; //用户名
objvzx_QuestionsENT.QuestionsTypeName = objvzx_QuestionsENS.QuestionsTypeName; //问题类型名称
objvzx_QuestionsENT.TextTitle = objvzx_QuestionsENS.TextTitle; //TextTitle
objvzx_QuestionsENT.IdCurrEduCls = objvzx_QuestionsENS.IdCurrEduCls; //教学班流水号
objvzx_QuestionsENT.IsSubmit = objvzx_QuestionsENS.IsSubmit; //是否提交
objvzx_QuestionsENT.TextId = objvzx_QuestionsENS.TextId; //课件Id
objvzx_QuestionsENT.QuestionsContent = objvzx_QuestionsENS.QuestionsContent; //提问内容
objvzx_QuestionsENT.PdfPageNum = objvzx_QuestionsENS.PdfPageNum; //Pdf页码
objvzx_QuestionsENT.PdfContent = objvzx_QuestionsENS.PdfContent; //Pdf内容
objvzx_QuestionsENT.IsDelete = objvzx_QuestionsENS.IsDelete; //是否删除
objvzx_QuestionsENT.IsPublic = objvzx_QuestionsENS.IsPublic; //是否公开
objvzx_QuestionsENT.IsEnd = objvzx_QuestionsENS.IsEnd; //是否结束
objvzx_QuestionsENT.VoteCount = objvzx_QuestionsENS.VoteCount; //点赞计数
objvzx_QuestionsENT.AnswerCount = objvzx_QuestionsENS.AnswerCount; //回答计数
objvzx_QuestionsENT.OrderNum = objvzx_QuestionsENS.OrderNum; //序号
objvzx_QuestionsENT.PdfPageTop = objvzx_QuestionsENS.PdfPageTop; //pdf页面顶部位置
objvzx_QuestionsENT.PdfPageNumIn = objvzx_QuestionsENS.PdfPageNumIn; //PdfPageNumIn
objvzx_QuestionsENT.PdfDivTop = objvzx_QuestionsENS.PdfDivTop; //PdfDivTop
objvzx_QuestionsENT.PdfDivLet = objvzx_QuestionsENS.PdfDivLet; //PdfDivLet
objvzx_QuestionsENT.PdfZoom = objvzx_QuestionsENS.PdfZoom; //PdfZoom
objvzx_QuestionsENT.UpdUser = objvzx_QuestionsENS.UpdUser; //修改人
objvzx_QuestionsENT.UpdDate = objvzx_QuestionsENS.UpdDate; //修改日期
objvzx_QuestionsENT.Memo = objvzx_QuestionsENS.Memo; //备注
objvzx_QuestionsENT.DiscussCount = objvzx_QuestionsENS.DiscussCount; //DiscussCount
objvzx_QuestionsENT.GroupDiscussCount = objvzx_QuestionsENS.GroupDiscussCount; //GroupDiscussCount
objvzx_QuestionsENT.ZxqaPaperId = objvzx_QuestionsENS.ZxqaPaperId; //论文答疑Id
objvzx_QuestionsENT.zxQuestionsTypeId = objvzx_QuestionsENS.zxQuestionsTypeId; //问题类型Id
objvzx_QuestionsENT.RecommendAnswerCount = objvzx_QuestionsENS.RecommendAnswerCount; //RecommendAnswerCount
objvzx_QuestionsENT.UserId = objvzx_QuestionsENS.UserId; //用户ID
objvzx_QuestionsENT.IdXzMajor = objvzx_QuestionsENS.IdXzMajor; //专业流水号
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
 /// <param name = "objvzx_QuestionsEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_QuestionsEN objvzx_QuestionsEN)
{
try
{
objvzx_QuestionsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_QuestionsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_Questions.zxQuestionsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.zxQuestionsId = objvzx_QuestionsEN.zxQuestionsId; //提问Id
}
if (arrFldSet.Contains(convzx_Questions.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.UserName = objvzx_QuestionsEN.UserName == "[null]" ? null :  objvzx_QuestionsEN.UserName; //用户名
}
if (arrFldSet.Contains(convzx_Questions.QuestionsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.QuestionsTypeName = objvzx_QuestionsEN.QuestionsTypeName == "[null]" ? null :  objvzx_QuestionsEN.QuestionsTypeName; //问题类型名称
}
if (arrFldSet.Contains(convzx_Questions.TextTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.TextTitle = objvzx_QuestionsEN.TextTitle == "[null]" ? null :  objvzx_QuestionsEN.TextTitle; //TextTitle
}
if (arrFldSet.Contains(convzx_Questions.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.IdCurrEduCls = objvzx_QuestionsEN.IdCurrEduCls == "[null]" ? null :  objvzx_QuestionsEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convzx_Questions.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.IsSubmit = objvzx_QuestionsEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convzx_Questions.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.TextId = objvzx_QuestionsEN.TextId == "[null]" ? null :  objvzx_QuestionsEN.TextId; //课件Id
}
if (arrFldSet.Contains(convzx_Questions.QuestionsContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.QuestionsContent = objvzx_QuestionsEN.QuestionsContent == "[null]" ? null :  objvzx_QuestionsEN.QuestionsContent; //提问内容
}
if (arrFldSet.Contains(convzx_Questions.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.PdfPageNum = objvzx_QuestionsEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(convzx_Questions.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.PdfContent = objvzx_QuestionsEN.PdfContent == "[null]" ? null :  objvzx_QuestionsEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(convzx_Questions.IsDelete, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.IsDelete = objvzx_QuestionsEN.IsDelete; //是否删除
}
if (arrFldSet.Contains(convzx_Questions.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.IsPublic = objvzx_QuestionsEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(convzx_Questions.IsEnd, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.IsEnd = objvzx_QuestionsEN.IsEnd; //是否结束
}
if (arrFldSet.Contains(convzx_Questions.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.VoteCount = objvzx_QuestionsEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(convzx_Questions.AnswerCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.AnswerCount = objvzx_QuestionsEN.AnswerCount; //回答计数
}
if (arrFldSet.Contains(convzx_Questions.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.OrderNum = objvzx_QuestionsEN.OrderNum; //序号
}
if (arrFldSet.Contains(convzx_Questions.PdfPageTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.PdfPageTop = objvzx_QuestionsEN.PdfPageTop; //pdf页面顶部位置
}
if (arrFldSet.Contains(convzx_Questions.PdfPageNumIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.PdfPageNumIn = objvzx_QuestionsEN.PdfPageNumIn == "[null]" ? null :  objvzx_QuestionsEN.PdfPageNumIn; //PdfPageNumIn
}
if (arrFldSet.Contains(convzx_Questions.PdfDivTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.PdfDivTop = objvzx_QuestionsEN.PdfDivTop == "[null]" ? null :  objvzx_QuestionsEN.PdfDivTop; //PdfDivTop
}
if (arrFldSet.Contains(convzx_Questions.PdfDivLet, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.PdfDivLet = objvzx_QuestionsEN.PdfDivLet == "[null]" ? null :  objvzx_QuestionsEN.PdfDivLet; //PdfDivLet
}
if (arrFldSet.Contains(convzx_Questions.PdfZoom, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.PdfZoom = objvzx_QuestionsEN.PdfZoom == "[null]" ? null :  objvzx_QuestionsEN.PdfZoom; //PdfZoom
}
if (arrFldSet.Contains(convzx_Questions.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.UpdUser = objvzx_QuestionsEN.UpdUser == "[null]" ? null :  objvzx_QuestionsEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_Questions.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.UpdDate = objvzx_QuestionsEN.UpdDate == "[null]" ? null :  objvzx_QuestionsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_Questions.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.Memo = objvzx_QuestionsEN.Memo == "[null]" ? null :  objvzx_QuestionsEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_Questions.DiscussCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.DiscussCount = objvzx_QuestionsEN.DiscussCount; //DiscussCount
}
if (arrFldSet.Contains(convzx_Questions.GroupDiscussCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.GroupDiscussCount = objvzx_QuestionsEN.GroupDiscussCount; //GroupDiscussCount
}
if (arrFldSet.Contains(convzx_Questions.ZxqaPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.ZxqaPaperId = objvzx_QuestionsEN.ZxqaPaperId; //论文答疑Id
}
if (arrFldSet.Contains(convzx_Questions.zxQuestionsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.zxQuestionsTypeId = objvzx_QuestionsEN.zxQuestionsTypeId; //问题类型Id
}
if (arrFldSet.Contains(convzx_Questions.RecommendAnswerCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.RecommendAnswerCount = objvzx_QuestionsEN.RecommendAnswerCount; //RecommendAnswerCount
}
if (arrFldSet.Contains(convzx_Questions.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.UserId = objvzx_QuestionsEN.UserId == "[null]" ? null :  objvzx_QuestionsEN.UserId; //用户ID
}
if (arrFldSet.Contains(convzx_Questions.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_QuestionsEN.IdXzMajor = objvzx_QuestionsEN.IdXzMajor == "[null]" ? null :  objvzx_QuestionsEN.IdXzMajor; //专业流水号
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
 /// <param name = "objvzx_QuestionsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_QuestionsEN objvzx_QuestionsEN)
{
try
{
if (objvzx_QuestionsEN.UserName == "[null]") objvzx_QuestionsEN.UserName = null; //用户名
if (objvzx_QuestionsEN.QuestionsTypeName == "[null]") objvzx_QuestionsEN.QuestionsTypeName = null; //问题类型名称
if (objvzx_QuestionsEN.TextTitle == "[null]") objvzx_QuestionsEN.TextTitle = null; //TextTitle
if (objvzx_QuestionsEN.IdCurrEduCls == "[null]") objvzx_QuestionsEN.IdCurrEduCls = null; //教学班流水号
if (objvzx_QuestionsEN.TextId == "[null]") objvzx_QuestionsEN.TextId = null; //课件Id
if (objvzx_QuestionsEN.QuestionsContent == "[null]") objvzx_QuestionsEN.QuestionsContent = null; //提问内容
if (objvzx_QuestionsEN.PdfContent == "[null]") objvzx_QuestionsEN.PdfContent = null; //Pdf内容
if (objvzx_QuestionsEN.PdfPageNumIn == "[null]") objvzx_QuestionsEN.PdfPageNumIn = null; //PdfPageNumIn
if (objvzx_QuestionsEN.PdfDivTop == "[null]") objvzx_QuestionsEN.PdfDivTop = null; //PdfDivTop
if (objvzx_QuestionsEN.PdfDivLet == "[null]") objvzx_QuestionsEN.PdfDivLet = null; //PdfDivLet
if (objvzx_QuestionsEN.PdfZoom == "[null]") objvzx_QuestionsEN.PdfZoom = null; //PdfZoom
if (objvzx_QuestionsEN.UpdUser == "[null]") objvzx_QuestionsEN.UpdUser = null; //修改人
if (objvzx_QuestionsEN.UpdDate == "[null]") objvzx_QuestionsEN.UpdDate = null; //修改日期
if (objvzx_QuestionsEN.Memo == "[null]") objvzx_QuestionsEN.Memo = null; //备注
if (objvzx_QuestionsEN.UserId == "[null]") objvzx_QuestionsEN.UserId = null; //用户ID
if (objvzx_QuestionsEN.IdXzMajor == "[null]") objvzx_QuestionsEN.IdXzMajor = null; //专业流水号
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
public static void CheckProperty4Condition(clsvzx_QuestionsEN objvzx_QuestionsEN)
{
 vzx_QuestionsDA.CheckProperty4Condition(objvzx_QuestionsEN);
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
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_TextBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TextBL没有刷新缓存机制(clszx_TextBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_QuestionsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_QuestionsBL没有刷新缓存机制(clszx_QuestionsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_QuestionsTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_QuestionsTypeBL没有刷新缓存机制(clszx_QuestionsTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxQuestionsId");
//if (arrvzx_QuestionsObjLstCache == null)
//{
//arrvzx_QuestionsObjLstCache = vzx_QuestionsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxQuestionsId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_QuestionsEN GetObjByzxQuestionsIdCache(string strzxQuestionsId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvzx_QuestionsEN._CurrTabName);
List<clsvzx_QuestionsEN> arrvzx_QuestionsObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_QuestionsEN> arrvzx_QuestionsObjLst_Sel =
arrvzx_QuestionsObjLstCache
.Where(x=> x.zxQuestionsId == strzxQuestionsId 
);
if (arrvzx_QuestionsObjLst_Sel.Count() == 0)
{
   clsvzx_QuestionsEN obj = clsvzx_QuestionsBL.GetObjByzxQuestionsId(strzxQuestionsId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvzx_QuestionsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_QuestionsEN> GetAllvzx_QuestionsObjLstCache()
{
//获取缓存中的对象列表
List<clsvzx_QuestionsEN> arrvzx_QuestionsObjLstCache = GetObjLstCache(); 
return arrvzx_QuestionsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_QuestionsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvzx_QuestionsEN._CurrTabName);
List<clsvzx_QuestionsEN> arrvzx_QuestionsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvzx_QuestionsObjLstCache;
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
string strKey = string.Format("{0}", clsvzx_QuestionsEN._CurrTabName);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strzxQuestionsId)
{
if (strInFldName != convzx_Questions.zxQuestionsId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_Questions.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_Questions.AttributeName));
throw new Exception(strMsg);
}
var objvzx_Questions = clsvzx_QuestionsBL.GetObjByzxQuestionsIdCache(strzxQuestionsId);
if (objvzx_Questions == null) return "";
return objvzx_Questions[strOutFldName].ToString();
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
int intRecCount = clsvzx_QuestionsDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_QuestionsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_QuestionsDA.GetRecCount();
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
int intRecCount = clsvzx_QuestionsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_QuestionsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_QuestionsEN objvzx_QuestionsCond)
{
List<clsvzx_QuestionsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_QuestionsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_Questions.AttributeName)
{
if (objvzx_QuestionsCond.IsUpdated(strFldName) == false) continue;
if (objvzx_QuestionsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_QuestionsCond[strFldName].ToString());
}
else
{
if (objvzx_QuestionsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_QuestionsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_QuestionsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_QuestionsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_QuestionsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_QuestionsCond[strFldName]));
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
 List<string> arrList = clsvzx_QuestionsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_QuestionsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_QuestionsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}