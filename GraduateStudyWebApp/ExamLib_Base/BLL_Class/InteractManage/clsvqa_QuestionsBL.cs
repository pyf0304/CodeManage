
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvqa_QuestionsBL
 表名:vqa_Questions(01120636)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:06:37
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
public static class  clsvqa_QuestionsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strQuestionsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvqa_QuestionsEN GetObj(this K_QuestionsId_vqa_Questions myKey)
{
clsvqa_QuestionsEN objvqa_QuestionsEN = clsvqa_QuestionsBL.vqa_QuestionsDA.GetObjByQuestionsId(myKey.Value);
return objvqa_QuestionsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetQuestionsId(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strQuestionsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsId, 8, convqa_Questions.QuestionsId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionsId, 8, convqa_Questions.QuestionsId);
}
objvqa_QuestionsEN.QuestionsId = strQuestionsId; //提问Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.QuestionsId) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.QuestionsId, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.QuestionsId] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetPaperId(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convqa_Questions.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convqa_Questions.PaperId);
}
objvqa_QuestionsEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.PaperId) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.PaperId, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.PaperId] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetIsSubmit(this clsvqa_QuestionsEN objvqa_QuestionsEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvqa_QuestionsEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.IsSubmit) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.IsSubmit, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.IsSubmit] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetQaPaperId(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strQaPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQaPaperId, convqa_Questions.QaPaperId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQaPaperId, 8, convqa_Questions.QaPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQaPaperId, 8, convqa_Questions.QaPaperId);
}
objvqa_QuestionsEN.QaPaperId = strQaPaperId; //论文答疑Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.QaPaperId) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.QaPaperId, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.QaPaperId] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetQuestionsContent(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strQuestionsContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsContent, 1000, convqa_Questions.QuestionsContent);
}
objvqa_QuestionsEN.QuestionsContent = strQuestionsContent; //提问内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.QuestionsContent) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.QuestionsContent, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.QuestionsContent] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetPdfContent(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convqa_Questions.PdfContent);
}
objvqa_QuestionsEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.PdfContent) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.PdfContent, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.PdfContent] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetPdfPageNum(this clsvqa_QuestionsEN objvqa_QuestionsEN, int? intPdfPageNum, string strComparisonOp="")
	{
objvqa_QuestionsEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.PdfPageNum) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.PdfPageNum, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.PdfPageNum] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetIsDelete(this clsvqa_QuestionsEN objvqa_QuestionsEN, bool bolIsDelete, string strComparisonOp="")
	{
objvqa_QuestionsEN.IsDelete = bolIsDelete; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.IsDelete) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.IsDelete, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.IsDelete] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetIsPublic(this clsvqa_QuestionsEN objvqa_QuestionsEN, bool bolIsPublic, string strComparisonOp="")
	{
objvqa_QuestionsEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.IsPublic) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.IsPublic, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.IsPublic] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetIsEnd(this clsvqa_QuestionsEN objvqa_QuestionsEN, bool bolIsEnd, string strComparisonOp="")
	{
objvqa_QuestionsEN.IsEnd = bolIsEnd; //是否结束
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.IsEnd) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.IsEnd, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.IsEnd] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetVoteCount(this clsvqa_QuestionsEN objvqa_QuestionsEN, int? intVoteCount, string strComparisonOp="")
	{
objvqa_QuestionsEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.VoteCount) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.VoteCount, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.VoteCount] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetAnswerCount(this clsvqa_QuestionsEN objvqa_QuestionsEN, int? intAnswerCount, string strComparisonOp="")
	{
objvqa_QuestionsEN.AnswerCount = intAnswerCount; //回答计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.AnswerCount) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.AnswerCount, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.AnswerCount] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetOrderNum(this clsvqa_QuestionsEN objvqa_QuestionsEN, int? intOrderNum, string strComparisonOp="")
	{
objvqa_QuestionsEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.OrderNum) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.OrderNum, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.OrderNum] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetUpdUser(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convqa_Questions.UpdUser);
}
objvqa_QuestionsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.UpdUser) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.UpdUser, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.UpdUser] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetUpdDate(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convqa_Questions.UpdDate);
}
objvqa_QuestionsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.UpdDate) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.UpdDate, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.UpdDate] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetMemo(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convqa_Questions.Memo);
}
objvqa_QuestionsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.Memo) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.Memo, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.Memo] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetUserName(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convqa_Questions.UserName);
}
objvqa_QuestionsEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.UserName) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.UserName, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.UserName] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetIdCurrEduCls(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convqa_Questions.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convqa_Questions.IdCurrEduCls);
}
objvqa_QuestionsEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.IdCurrEduCls) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.IdCurrEduCls, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.IdCurrEduCls] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetPaperTitle(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convqa_Questions.PaperTitle);
}
objvqa_QuestionsEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.PaperTitle) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.PaperTitle, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.PaperTitle] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetPdfDivLet(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strPdfDivLet, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, convqa_Questions.PdfDivLet);
}
objvqa_QuestionsEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.PdfDivLet) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.PdfDivLet, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.PdfDivLet] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetPdfDivTop(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strPdfDivTop, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, convqa_Questions.PdfDivTop);
}
objvqa_QuestionsEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.PdfDivTop) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.PdfDivTop, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.PdfDivTop] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetPdfPageNumIn(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strPdfPageNumIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, convqa_Questions.PdfPageNumIn);
}
objvqa_QuestionsEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.PdfPageNumIn) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.PdfPageNumIn, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.PdfPageNumIn] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetPdfPageTop(this clsvqa_QuestionsEN objvqa_QuestionsEN, int? intPdfPageTop, string strComparisonOp="")
	{
objvqa_QuestionsEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.PdfPageTop) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.PdfPageTop, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.PdfPageTop] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetPdfZoom(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strPdfZoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, convqa_Questions.PdfZoom);
}
objvqa_QuestionsEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.PdfZoom) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.PdfZoom, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.PdfZoom] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetUserId(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convqa_Questions.UserId);
}
objvqa_QuestionsEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.UserId) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.UserId, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.UserId] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetQuestionsTypeId(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strQuestionsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsTypeId, 2, convqa_Questions.QuestionsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionsTypeId, 2, convqa_Questions.QuestionsTypeId);
}
objvqa_QuestionsEN.QuestionsTypeId = strQuestionsTypeId; //问题类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.QuestionsTypeId) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.QuestionsTypeId, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.QuestionsTypeId] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetQuestionsTypeName(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strQuestionsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsTypeName, 50, convqa_Questions.QuestionsTypeName);
}
objvqa_QuestionsEN.QuestionsTypeName = strQuestionsTypeName; //问题类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.QuestionsTypeName) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.QuestionsTypeName, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.QuestionsTypeName] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetDiscussCount(this clsvqa_QuestionsEN objvqa_QuestionsEN, int? intDiscussCount, string strComparisonOp="")
	{
objvqa_QuestionsEN.DiscussCount = intDiscussCount; //DiscussCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.DiscussCount) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.DiscussCount, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.DiscussCount] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetGroupDiscussCount(this clsvqa_QuestionsEN objvqa_QuestionsEN, int? intGroupDiscussCount, string strComparisonOp="")
	{
objvqa_QuestionsEN.GroupDiscussCount = intGroupDiscussCount; //GroupDiscussCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.GroupDiscussCount) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.GroupDiscussCount, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.GroupDiscussCount] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_QuestionsEN SetRecommendAnswerCount(this clsvqa_QuestionsEN objvqa_QuestionsEN, int? intRecommendAnswerCount, string strComparisonOp="")
	{
objvqa_QuestionsEN.RecommendAnswerCount = intRecommendAnswerCount; //RecommendAnswerCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.RecommendAnswerCount) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.RecommendAnswerCount, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.RecommendAnswerCount] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvqa_QuestionsENS">源对象</param>
 /// <param name = "objvqa_QuestionsENT">目标对象</param>
 public static void CopyTo(this clsvqa_QuestionsEN objvqa_QuestionsENS, clsvqa_QuestionsEN objvqa_QuestionsENT)
{
try
{
objvqa_QuestionsENT.QuestionsId = objvqa_QuestionsENS.QuestionsId; //提问Id
objvqa_QuestionsENT.PaperId = objvqa_QuestionsENS.PaperId; //论文Id
objvqa_QuestionsENT.IsSubmit = objvqa_QuestionsENS.IsSubmit; //是否提交
objvqa_QuestionsENT.QaPaperId = objvqa_QuestionsENS.QaPaperId; //论文答疑Id
objvqa_QuestionsENT.QuestionsContent = objvqa_QuestionsENS.QuestionsContent; //提问内容
objvqa_QuestionsENT.PdfContent = objvqa_QuestionsENS.PdfContent; //Pdf内容
objvqa_QuestionsENT.PdfPageNum = objvqa_QuestionsENS.PdfPageNum; //Pdf页码
objvqa_QuestionsENT.IsDelete = objvqa_QuestionsENS.IsDelete; //是否删除
objvqa_QuestionsENT.IsPublic = objvqa_QuestionsENS.IsPublic; //是否公开
objvqa_QuestionsENT.IsEnd = objvqa_QuestionsENS.IsEnd; //是否结束
objvqa_QuestionsENT.VoteCount = objvqa_QuestionsENS.VoteCount; //点赞计数
objvqa_QuestionsENT.AnswerCount = objvqa_QuestionsENS.AnswerCount; //回答计数
objvqa_QuestionsENT.OrderNum = objvqa_QuestionsENS.OrderNum; //序号
objvqa_QuestionsENT.UpdUser = objvqa_QuestionsENS.UpdUser; //修改人
objvqa_QuestionsENT.UpdDate = objvqa_QuestionsENS.UpdDate; //修改日期
objvqa_QuestionsENT.Memo = objvqa_QuestionsENS.Memo; //备注
objvqa_QuestionsENT.UserName = objvqa_QuestionsENS.UserName; //用户名
objvqa_QuestionsENT.IdCurrEduCls = objvqa_QuestionsENS.IdCurrEduCls; //教学班流水号
objvqa_QuestionsENT.PaperTitle = objvqa_QuestionsENS.PaperTitle; //论文标题
objvqa_QuestionsENT.PdfDivLet = objvqa_QuestionsENS.PdfDivLet; //PdfDivLet
objvqa_QuestionsENT.PdfDivTop = objvqa_QuestionsENS.PdfDivTop; //PdfDivTop
objvqa_QuestionsENT.PdfPageNumIn = objvqa_QuestionsENS.PdfPageNumIn; //PdfPageNumIn
objvqa_QuestionsENT.PdfPageTop = objvqa_QuestionsENS.PdfPageTop; //pdf页面顶部位置
objvqa_QuestionsENT.PdfZoom = objvqa_QuestionsENS.PdfZoom; //PdfZoom
objvqa_QuestionsENT.UserId = objvqa_QuestionsENS.UserId; //用户ID
objvqa_QuestionsENT.QuestionsTypeId = objvqa_QuestionsENS.QuestionsTypeId; //问题类型Id
objvqa_QuestionsENT.QuestionsTypeName = objvqa_QuestionsENS.QuestionsTypeName; //问题类型名称
objvqa_QuestionsENT.DiscussCount = objvqa_QuestionsENS.DiscussCount; //DiscussCount
objvqa_QuestionsENT.GroupDiscussCount = objvqa_QuestionsENS.GroupDiscussCount; //GroupDiscussCount
objvqa_QuestionsENT.RecommendAnswerCount = objvqa_QuestionsENS.RecommendAnswerCount; //RecommendAnswerCount
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
 /// <param name = "objvqa_QuestionsENS">源对象</param>
 /// <returns>目标对象=>clsvqa_QuestionsEN:objvqa_QuestionsENT</returns>
 public static clsvqa_QuestionsEN CopyTo(this clsvqa_QuestionsEN objvqa_QuestionsENS)
{
try
{
 clsvqa_QuestionsEN objvqa_QuestionsENT = new clsvqa_QuestionsEN()
{
QuestionsId = objvqa_QuestionsENS.QuestionsId, //提问Id
PaperId = objvqa_QuestionsENS.PaperId, //论文Id
IsSubmit = objvqa_QuestionsENS.IsSubmit, //是否提交
QaPaperId = objvqa_QuestionsENS.QaPaperId, //论文答疑Id
QuestionsContent = objvqa_QuestionsENS.QuestionsContent, //提问内容
PdfContent = objvqa_QuestionsENS.PdfContent, //Pdf内容
PdfPageNum = objvqa_QuestionsENS.PdfPageNum, //Pdf页码
IsDelete = objvqa_QuestionsENS.IsDelete, //是否删除
IsPublic = objvqa_QuestionsENS.IsPublic, //是否公开
IsEnd = objvqa_QuestionsENS.IsEnd, //是否结束
VoteCount = objvqa_QuestionsENS.VoteCount, //点赞计数
AnswerCount = objvqa_QuestionsENS.AnswerCount, //回答计数
OrderNum = objvqa_QuestionsENS.OrderNum, //序号
UpdUser = objvqa_QuestionsENS.UpdUser, //修改人
UpdDate = objvqa_QuestionsENS.UpdDate, //修改日期
Memo = objvqa_QuestionsENS.Memo, //备注
UserName = objvqa_QuestionsENS.UserName, //用户名
IdCurrEduCls = objvqa_QuestionsENS.IdCurrEduCls, //教学班流水号
PaperTitle = objvqa_QuestionsENS.PaperTitle, //论文标题
PdfDivLet = objvqa_QuestionsENS.PdfDivLet, //PdfDivLet
PdfDivTop = objvqa_QuestionsENS.PdfDivTop, //PdfDivTop
PdfPageNumIn = objvqa_QuestionsENS.PdfPageNumIn, //PdfPageNumIn
PdfPageTop = objvqa_QuestionsENS.PdfPageTop, //pdf页面顶部位置
PdfZoom = objvqa_QuestionsENS.PdfZoom, //PdfZoom
UserId = objvqa_QuestionsENS.UserId, //用户ID
QuestionsTypeId = objvqa_QuestionsENS.QuestionsTypeId, //问题类型Id
QuestionsTypeName = objvqa_QuestionsENS.QuestionsTypeName, //问题类型名称
DiscussCount = objvqa_QuestionsENS.DiscussCount, //DiscussCount
GroupDiscussCount = objvqa_QuestionsENS.GroupDiscussCount, //GroupDiscussCount
RecommendAnswerCount = objvqa_QuestionsENS.RecommendAnswerCount, //RecommendAnswerCount
};
 return objvqa_QuestionsENT;
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
public static void CheckProperty4Condition(this clsvqa_QuestionsEN objvqa_QuestionsEN)
{
 clsvqa_QuestionsBL.vqa_QuestionsDA.CheckProperty4Condition(objvqa_QuestionsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvqa_QuestionsEN objvqa_QuestionsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.QuestionsId) == true)
{
string strComparisonOpQuestionsId = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.QuestionsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.QuestionsId, objvqa_QuestionsCond.QuestionsId, strComparisonOpQuestionsId);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.PaperId) == true)
{
string strComparisonOpPaperId = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.PaperId, objvqa_QuestionsCond.PaperId, strComparisonOpPaperId);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.IsSubmit) == true)
{
if (objvqa_QuestionsCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Questions.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Questions.IsSubmit);
}
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.QaPaperId) == true)
{
string strComparisonOpQaPaperId = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.QaPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.QaPaperId, objvqa_QuestionsCond.QaPaperId, strComparisonOpQaPaperId);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.QuestionsContent) == true)
{
string strComparisonOpQuestionsContent = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.QuestionsContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.QuestionsContent, objvqa_QuestionsCond.QuestionsContent, strComparisonOpQuestionsContent);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.PdfContent) == true)
{
string strComparisonOpPdfContent = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.PdfContent, objvqa_QuestionsCond.PdfContent, strComparisonOpPdfContent);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Questions.PdfPageNum, objvqa_QuestionsCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.IsDelete) == true)
{
if (objvqa_QuestionsCond.IsDelete == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Questions.IsDelete);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Questions.IsDelete);
}
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.IsPublic) == true)
{
if (objvqa_QuestionsCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Questions.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Questions.IsPublic);
}
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.IsEnd) == true)
{
if (objvqa_QuestionsCond.IsEnd == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Questions.IsEnd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Questions.IsEnd);
}
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.VoteCount) == true)
{
string strComparisonOpVoteCount = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Questions.VoteCount, objvqa_QuestionsCond.VoteCount, strComparisonOpVoteCount);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.AnswerCount) == true)
{
string strComparisonOpAnswerCount = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.AnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Questions.AnswerCount, objvqa_QuestionsCond.AnswerCount, strComparisonOpAnswerCount);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.OrderNum) == true)
{
string strComparisonOpOrderNum = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Questions.OrderNum, objvqa_QuestionsCond.OrderNum, strComparisonOpOrderNum);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.UpdUser) == true)
{
string strComparisonOpUpdUser = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.UpdUser, objvqa_QuestionsCond.UpdUser, strComparisonOpUpdUser);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.UpdDate) == true)
{
string strComparisonOpUpdDate = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.UpdDate, objvqa_QuestionsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.Memo) == true)
{
string strComparisonOpMemo = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.Memo, objvqa_QuestionsCond.Memo, strComparisonOpMemo);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.UserName) == true)
{
string strComparisonOpUserName = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.UserName, objvqa_QuestionsCond.UserName, strComparisonOpUserName);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.IdCurrEduCls, objvqa_QuestionsCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.PaperTitle, objvqa_QuestionsCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.PdfDivLet) == true)
{
string strComparisonOpPdfDivLet = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.PdfDivLet, objvqa_QuestionsCond.PdfDivLet, strComparisonOpPdfDivLet);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.PdfDivTop) == true)
{
string strComparisonOpPdfDivTop = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.PdfDivTop, objvqa_QuestionsCond.PdfDivTop, strComparisonOpPdfDivTop);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.PdfPageNumIn) == true)
{
string strComparisonOpPdfPageNumIn = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.PdfPageNumIn, objvqa_QuestionsCond.PdfPageNumIn, strComparisonOpPdfPageNumIn);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.PdfPageTop) == true)
{
string strComparisonOpPdfPageTop = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Questions.PdfPageTop, objvqa_QuestionsCond.PdfPageTop, strComparisonOpPdfPageTop);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.PdfZoom) == true)
{
string strComparisonOpPdfZoom = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.PdfZoom, objvqa_QuestionsCond.PdfZoom, strComparisonOpPdfZoom);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.UserId) == true)
{
string strComparisonOpUserId = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.UserId, objvqa_QuestionsCond.UserId, strComparisonOpUserId);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.QuestionsTypeId) == true)
{
string strComparisonOpQuestionsTypeId = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.QuestionsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.QuestionsTypeId, objvqa_QuestionsCond.QuestionsTypeId, strComparisonOpQuestionsTypeId);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.QuestionsTypeName) == true)
{
string strComparisonOpQuestionsTypeName = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.QuestionsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.QuestionsTypeName, objvqa_QuestionsCond.QuestionsTypeName, strComparisonOpQuestionsTypeName);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.DiscussCount) == true)
{
string strComparisonOpDiscussCount = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.DiscussCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Questions.DiscussCount, objvqa_QuestionsCond.DiscussCount, strComparisonOpDiscussCount);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.GroupDiscussCount) == true)
{
string strComparisonOpGroupDiscussCount = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.GroupDiscussCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Questions.GroupDiscussCount, objvqa_QuestionsCond.GroupDiscussCount, strComparisonOpGroupDiscussCount);
}
if (objvqa_QuestionsCond.IsUpdated(convqa_Questions.RecommendAnswerCount) == true)
{
string strComparisonOpRecommendAnswerCount = objvqa_QuestionsCond.dicFldComparisonOp[convqa_Questions.RecommendAnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Questions.RecommendAnswerCount, objvqa_QuestionsCond.RecommendAnswerCount, strComparisonOpRecommendAnswerCount);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vqa_Questions(v答疑提问), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:QuestionsId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvqa_QuestionsEN objvqa_QuestionsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvqa_QuestionsEN == null) return true;
if (objvqa_QuestionsEN.QuestionsId == null || objvqa_QuestionsEN.QuestionsId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionsId = '{0}'", objvqa_QuestionsEN.QuestionsId);
if (clsvqa_QuestionsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("QuestionsId !=  '{0}'", objvqa_QuestionsEN.QuestionsId);
 sbCondition.AppendFormat(" and QuestionsId = '{0}'", objvqa_QuestionsEN.QuestionsId);
if (clsvqa_QuestionsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取唯一性条件串--vqa_Questions(v答疑提问), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:QuestionsId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvqa_QuestionsEN objvqa_QuestionsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvqa_QuestionsEN == null) return "";
if (objvqa_QuestionsEN.QuestionsId == null || objvqa_QuestionsEN.QuestionsId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionsId = '{0}'", objvqa_QuestionsEN.QuestionsId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("QuestionsId !=  '{0}'", objvqa_QuestionsEN.QuestionsId);
 sbCondition.AppendFormat(" and QuestionsId = '{0}'", objvqa_QuestionsEN.QuestionsId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vqa_Questions
{
public virtual bool UpdRelaTabDate(string strQuestionsId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v答疑提问(vqa_Questions)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvqa_QuestionsBL
{
public static RelatedActions_vqa_Questions relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvqa_QuestionsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvqa_QuestionsDA vqa_QuestionsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvqa_QuestionsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvqa_QuestionsBL()
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
if (string.IsNullOrEmpty(clsvqa_QuestionsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvqa_QuestionsEN._ConnectString);
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
public static DataTable GetDataTable_vqa_Questions(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vqa_QuestionsDA.GetDataTable_vqa_Questions(strWhereCond);
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
objDT = vqa_QuestionsDA.GetDataTable(strWhereCond);
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
objDT = vqa_QuestionsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vqa_QuestionsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vqa_QuestionsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vqa_QuestionsDA.GetDataTable_Top(objTopPara);
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
objDT = vqa_QuestionsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vqa_QuestionsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vqa_QuestionsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrQuestionsIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvqa_QuestionsEN> GetObjLstByQuestionsIdLst(List<string> arrQuestionsIdLst)
{
List<clsvqa_QuestionsEN> arrObjLst = new List<clsvqa_QuestionsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrQuestionsIdLst, true);
 string strWhereCond = string.Format("QuestionsId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_QuestionsEN objvqa_QuestionsEN = new clsvqa_QuestionsEN();
try
{
objvqa_QuestionsEN.QuestionsId = objRow[convqa_Questions.QuestionsId].ToString().Trim(); //提问Id
objvqa_QuestionsEN.PaperId = objRow[convqa_Questions.PaperId] == DBNull.Value ? null : objRow[convqa_Questions.PaperId].ToString().Trim(); //论文Id
objvqa_QuestionsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsSubmit].ToString().Trim()); //是否提交
objvqa_QuestionsEN.QaPaperId = objRow[convqa_Questions.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_QuestionsEN.QuestionsContent = objRow[convqa_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvqa_QuestionsEN.PdfContent = objRow[convqa_Questions.PdfContent] == DBNull.Value ? null : objRow[convqa_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvqa_QuestionsEN.PdfPageNum = objRow[convqa_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsDelete].ToString().Trim()); //是否删除
objvqa_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsPublic].ToString().Trim()); //是否公开
objvqa_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsEnd].ToString().Trim()); //是否结束
objvqa_QuestionsEN.VoteCount = objRow[convqa_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.VoteCount].ToString().Trim()); //点赞计数
objvqa_QuestionsEN.AnswerCount = objRow[convqa_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.AnswerCount].ToString().Trim()); //回答计数
objvqa_QuestionsEN.OrderNum = objRow[convqa_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.OrderNum].ToString().Trim()); //序号
objvqa_QuestionsEN.UpdUser = objRow[convqa_Questions.UpdUser] == DBNull.Value ? null : objRow[convqa_Questions.UpdUser].ToString().Trim(); //修改人
objvqa_QuestionsEN.UpdDate = objRow[convqa_Questions.UpdDate] == DBNull.Value ? null : objRow[convqa_Questions.UpdDate].ToString().Trim(); //修改日期
objvqa_QuestionsEN.Memo = objRow[convqa_Questions.Memo] == DBNull.Value ? null : objRow[convqa_Questions.Memo].ToString().Trim(); //备注
objvqa_QuestionsEN.UserName = objRow[convqa_Questions.UserName] == DBNull.Value ? null : objRow[convqa_Questions.UserName].ToString().Trim(); //用户名
objvqa_QuestionsEN.IdCurrEduCls = objRow[convqa_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_QuestionsEN.PaperTitle = objRow[convqa_Questions.PaperTitle] == DBNull.Value ? null : objRow[convqa_Questions.PaperTitle].ToString().Trim(); //论文标题
objvqa_QuestionsEN.PdfDivLet = objRow[convqa_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvqa_QuestionsEN.PdfDivTop = objRow[convqa_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvqa_QuestionsEN.PdfPageNumIn = objRow[convqa_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convqa_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvqa_QuestionsEN.PdfPageTop = objRow[convqa_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvqa_QuestionsEN.PdfZoom = objRow[convqa_Questions.PdfZoom] == DBNull.Value ? null : objRow[convqa_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvqa_QuestionsEN.UserId = objRow[convqa_Questions.UserId] == DBNull.Value ? null : objRow[convqa_Questions.UserId].ToString().Trim(); //用户ID
objvqa_QuestionsEN.QuestionsTypeId = objRow[convqa_Questions.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_QuestionsEN.QuestionsTypeName = objRow[convqa_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_QuestionsEN.DiscussCount = objRow[convqa_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvqa_QuestionsEN.GroupDiscussCount = objRow[convqa_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvqa_QuestionsEN.RecommendAnswerCount = objRow[convqa_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_QuestionsEN.QuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_QuestionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrQuestionsIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvqa_QuestionsEN> GetObjLstByQuestionsIdLstCache(List<string> arrQuestionsIdLst)
{
string strKey = string.Format("{0}", clsvqa_QuestionsEN._CurrTabName);
List<clsvqa_QuestionsEN> arrvqa_QuestionsObjLstCache = GetObjLstCache();
IEnumerable <clsvqa_QuestionsEN> arrvqa_QuestionsObjLst_Sel =
arrvqa_QuestionsObjLstCache
.Where(x => arrQuestionsIdLst.Contains(x.QuestionsId));
return arrvqa_QuestionsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_QuestionsEN> GetObjLst(string strWhereCond)
{
List<clsvqa_QuestionsEN> arrObjLst = new List<clsvqa_QuestionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_QuestionsEN objvqa_QuestionsEN = new clsvqa_QuestionsEN();
try
{
objvqa_QuestionsEN.QuestionsId = objRow[convqa_Questions.QuestionsId].ToString().Trim(); //提问Id
objvqa_QuestionsEN.PaperId = objRow[convqa_Questions.PaperId] == DBNull.Value ? null : objRow[convqa_Questions.PaperId].ToString().Trim(); //论文Id
objvqa_QuestionsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsSubmit].ToString().Trim()); //是否提交
objvqa_QuestionsEN.QaPaperId = objRow[convqa_Questions.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_QuestionsEN.QuestionsContent = objRow[convqa_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvqa_QuestionsEN.PdfContent = objRow[convqa_Questions.PdfContent] == DBNull.Value ? null : objRow[convqa_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvqa_QuestionsEN.PdfPageNum = objRow[convqa_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsDelete].ToString().Trim()); //是否删除
objvqa_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsPublic].ToString().Trim()); //是否公开
objvqa_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsEnd].ToString().Trim()); //是否结束
objvqa_QuestionsEN.VoteCount = objRow[convqa_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.VoteCount].ToString().Trim()); //点赞计数
objvqa_QuestionsEN.AnswerCount = objRow[convqa_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.AnswerCount].ToString().Trim()); //回答计数
objvqa_QuestionsEN.OrderNum = objRow[convqa_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.OrderNum].ToString().Trim()); //序号
objvqa_QuestionsEN.UpdUser = objRow[convqa_Questions.UpdUser] == DBNull.Value ? null : objRow[convqa_Questions.UpdUser].ToString().Trim(); //修改人
objvqa_QuestionsEN.UpdDate = objRow[convqa_Questions.UpdDate] == DBNull.Value ? null : objRow[convqa_Questions.UpdDate].ToString().Trim(); //修改日期
objvqa_QuestionsEN.Memo = objRow[convqa_Questions.Memo] == DBNull.Value ? null : objRow[convqa_Questions.Memo].ToString().Trim(); //备注
objvqa_QuestionsEN.UserName = objRow[convqa_Questions.UserName] == DBNull.Value ? null : objRow[convqa_Questions.UserName].ToString().Trim(); //用户名
objvqa_QuestionsEN.IdCurrEduCls = objRow[convqa_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_QuestionsEN.PaperTitle = objRow[convqa_Questions.PaperTitle] == DBNull.Value ? null : objRow[convqa_Questions.PaperTitle].ToString().Trim(); //论文标题
objvqa_QuestionsEN.PdfDivLet = objRow[convqa_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvqa_QuestionsEN.PdfDivTop = objRow[convqa_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvqa_QuestionsEN.PdfPageNumIn = objRow[convqa_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convqa_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvqa_QuestionsEN.PdfPageTop = objRow[convqa_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvqa_QuestionsEN.PdfZoom = objRow[convqa_Questions.PdfZoom] == DBNull.Value ? null : objRow[convqa_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvqa_QuestionsEN.UserId = objRow[convqa_Questions.UserId] == DBNull.Value ? null : objRow[convqa_Questions.UserId].ToString().Trim(); //用户ID
objvqa_QuestionsEN.QuestionsTypeId = objRow[convqa_Questions.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_QuestionsEN.QuestionsTypeName = objRow[convqa_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_QuestionsEN.DiscussCount = objRow[convqa_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvqa_QuestionsEN.GroupDiscussCount = objRow[convqa_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvqa_QuestionsEN.RecommendAnswerCount = objRow[convqa_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_QuestionsEN.QuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_QuestionsEN);
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
public static List<clsvqa_QuestionsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvqa_QuestionsEN> arrObjLst = new List<clsvqa_QuestionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_QuestionsEN objvqa_QuestionsEN = new clsvqa_QuestionsEN();
try
{
objvqa_QuestionsEN.QuestionsId = objRow[convqa_Questions.QuestionsId].ToString().Trim(); //提问Id
objvqa_QuestionsEN.PaperId = objRow[convqa_Questions.PaperId] == DBNull.Value ? null : objRow[convqa_Questions.PaperId].ToString().Trim(); //论文Id
objvqa_QuestionsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsSubmit].ToString().Trim()); //是否提交
objvqa_QuestionsEN.QaPaperId = objRow[convqa_Questions.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_QuestionsEN.QuestionsContent = objRow[convqa_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvqa_QuestionsEN.PdfContent = objRow[convqa_Questions.PdfContent] == DBNull.Value ? null : objRow[convqa_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvqa_QuestionsEN.PdfPageNum = objRow[convqa_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsDelete].ToString().Trim()); //是否删除
objvqa_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsPublic].ToString().Trim()); //是否公开
objvqa_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsEnd].ToString().Trim()); //是否结束
objvqa_QuestionsEN.VoteCount = objRow[convqa_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.VoteCount].ToString().Trim()); //点赞计数
objvqa_QuestionsEN.AnswerCount = objRow[convqa_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.AnswerCount].ToString().Trim()); //回答计数
objvqa_QuestionsEN.OrderNum = objRow[convqa_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.OrderNum].ToString().Trim()); //序号
objvqa_QuestionsEN.UpdUser = objRow[convqa_Questions.UpdUser] == DBNull.Value ? null : objRow[convqa_Questions.UpdUser].ToString().Trim(); //修改人
objvqa_QuestionsEN.UpdDate = objRow[convqa_Questions.UpdDate] == DBNull.Value ? null : objRow[convqa_Questions.UpdDate].ToString().Trim(); //修改日期
objvqa_QuestionsEN.Memo = objRow[convqa_Questions.Memo] == DBNull.Value ? null : objRow[convqa_Questions.Memo].ToString().Trim(); //备注
objvqa_QuestionsEN.UserName = objRow[convqa_Questions.UserName] == DBNull.Value ? null : objRow[convqa_Questions.UserName].ToString().Trim(); //用户名
objvqa_QuestionsEN.IdCurrEduCls = objRow[convqa_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_QuestionsEN.PaperTitle = objRow[convqa_Questions.PaperTitle] == DBNull.Value ? null : objRow[convqa_Questions.PaperTitle].ToString().Trim(); //论文标题
objvqa_QuestionsEN.PdfDivLet = objRow[convqa_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvqa_QuestionsEN.PdfDivTop = objRow[convqa_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvqa_QuestionsEN.PdfPageNumIn = objRow[convqa_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convqa_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvqa_QuestionsEN.PdfPageTop = objRow[convqa_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvqa_QuestionsEN.PdfZoom = objRow[convqa_Questions.PdfZoom] == DBNull.Value ? null : objRow[convqa_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvqa_QuestionsEN.UserId = objRow[convqa_Questions.UserId] == DBNull.Value ? null : objRow[convqa_Questions.UserId].ToString().Trim(); //用户ID
objvqa_QuestionsEN.QuestionsTypeId = objRow[convqa_Questions.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_QuestionsEN.QuestionsTypeName = objRow[convqa_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_QuestionsEN.DiscussCount = objRow[convqa_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvqa_QuestionsEN.GroupDiscussCount = objRow[convqa_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvqa_QuestionsEN.RecommendAnswerCount = objRow[convqa_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_QuestionsEN.QuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_QuestionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvqa_QuestionsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvqa_QuestionsEN> GetSubObjLstCache(clsvqa_QuestionsEN objvqa_QuestionsCond)
{
List<clsvqa_QuestionsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvqa_QuestionsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convqa_Questions.AttributeName)
{
if (objvqa_QuestionsCond.IsUpdated(strFldName) == false) continue;
if (objvqa_QuestionsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvqa_QuestionsCond[strFldName].ToString());
}
else
{
if (objvqa_QuestionsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvqa_QuestionsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvqa_QuestionsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvqa_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvqa_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvqa_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvqa_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvqa_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvqa_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvqa_QuestionsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvqa_QuestionsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvqa_QuestionsCond[strFldName]));
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
public static List<clsvqa_QuestionsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvqa_QuestionsEN> arrObjLst = new List<clsvqa_QuestionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_QuestionsEN objvqa_QuestionsEN = new clsvqa_QuestionsEN();
try
{
objvqa_QuestionsEN.QuestionsId = objRow[convqa_Questions.QuestionsId].ToString().Trim(); //提问Id
objvqa_QuestionsEN.PaperId = objRow[convqa_Questions.PaperId] == DBNull.Value ? null : objRow[convqa_Questions.PaperId].ToString().Trim(); //论文Id
objvqa_QuestionsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsSubmit].ToString().Trim()); //是否提交
objvqa_QuestionsEN.QaPaperId = objRow[convqa_Questions.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_QuestionsEN.QuestionsContent = objRow[convqa_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvqa_QuestionsEN.PdfContent = objRow[convqa_Questions.PdfContent] == DBNull.Value ? null : objRow[convqa_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvqa_QuestionsEN.PdfPageNum = objRow[convqa_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsDelete].ToString().Trim()); //是否删除
objvqa_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsPublic].ToString().Trim()); //是否公开
objvqa_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsEnd].ToString().Trim()); //是否结束
objvqa_QuestionsEN.VoteCount = objRow[convqa_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.VoteCount].ToString().Trim()); //点赞计数
objvqa_QuestionsEN.AnswerCount = objRow[convqa_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.AnswerCount].ToString().Trim()); //回答计数
objvqa_QuestionsEN.OrderNum = objRow[convqa_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.OrderNum].ToString().Trim()); //序号
objvqa_QuestionsEN.UpdUser = objRow[convqa_Questions.UpdUser] == DBNull.Value ? null : objRow[convqa_Questions.UpdUser].ToString().Trim(); //修改人
objvqa_QuestionsEN.UpdDate = objRow[convqa_Questions.UpdDate] == DBNull.Value ? null : objRow[convqa_Questions.UpdDate].ToString().Trim(); //修改日期
objvqa_QuestionsEN.Memo = objRow[convqa_Questions.Memo] == DBNull.Value ? null : objRow[convqa_Questions.Memo].ToString().Trim(); //备注
objvqa_QuestionsEN.UserName = objRow[convqa_Questions.UserName] == DBNull.Value ? null : objRow[convqa_Questions.UserName].ToString().Trim(); //用户名
objvqa_QuestionsEN.IdCurrEduCls = objRow[convqa_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_QuestionsEN.PaperTitle = objRow[convqa_Questions.PaperTitle] == DBNull.Value ? null : objRow[convqa_Questions.PaperTitle].ToString().Trim(); //论文标题
objvqa_QuestionsEN.PdfDivLet = objRow[convqa_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvqa_QuestionsEN.PdfDivTop = objRow[convqa_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvqa_QuestionsEN.PdfPageNumIn = objRow[convqa_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convqa_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvqa_QuestionsEN.PdfPageTop = objRow[convqa_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvqa_QuestionsEN.PdfZoom = objRow[convqa_Questions.PdfZoom] == DBNull.Value ? null : objRow[convqa_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvqa_QuestionsEN.UserId = objRow[convqa_Questions.UserId] == DBNull.Value ? null : objRow[convqa_Questions.UserId].ToString().Trim(); //用户ID
objvqa_QuestionsEN.QuestionsTypeId = objRow[convqa_Questions.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_QuestionsEN.QuestionsTypeName = objRow[convqa_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_QuestionsEN.DiscussCount = objRow[convqa_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvqa_QuestionsEN.GroupDiscussCount = objRow[convqa_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvqa_QuestionsEN.RecommendAnswerCount = objRow[convqa_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_QuestionsEN.QuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_QuestionsEN);
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
public static List<clsvqa_QuestionsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvqa_QuestionsEN> arrObjLst = new List<clsvqa_QuestionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_QuestionsEN objvqa_QuestionsEN = new clsvqa_QuestionsEN();
try
{
objvqa_QuestionsEN.QuestionsId = objRow[convqa_Questions.QuestionsId].ToString().Trim(); //提问Id
objvqa_QuestionsEN.PaperId = objRow[convqa_Questions.PaperId] == DBNull.Value ? null : objRow[convqa_Questions.PaperId].ToString().Trim(); //论文Id
objvqa_QuestionsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsSubmit].ToString().Trim()); //是否提交
objvqa_QuestionsEN.QaPaperId = objRow[convqa_Questions.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_QuestionsEN.QuestionsContent = objRow[convqa_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvqa_QuestionsEN.PdfContent = objRow[convqa_Questions.PdfContent] == DBNull.Value ? null : objRow[convqa_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvqa_QuestionsEN.PdfPageNum = objRow[convqa_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsDelete].ToString().Trim()); //是否删除
objvqa_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsPublic].ToString().Trim()); //是否公开
objvqa_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsEnd].ToString().Trim()); //是否结束
objvqa_QuestionsEN.VoteCount = objRow[convqa_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.VoteCount].ToString().Trim()); //点赞计数
objvqa_QuestionsEN.AnswerCount = objRow[convqa_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.AnswerCount].ToString().Trim()); //回答计数
objvqa_QuestionsEN.OrderNum = objRow[convqa_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.OrderNum].ToString().Trim()); //序号
objvqa_QuestionsEN.UpdUser = objRow[convqa_Questions.UpdUser] == DBNull.Value ? null : objRow[convqa_Questions.UpdUser].ToString().Trim(); //修改人
objvqa_QuestionsEN.UpdDate = objRow[convqa_Questions.UpdDate] == DBNull.Value ? null : objRow[convqa_Questions.UpdDate].ToString().Trim(); //修改日期
objvqa_QuestionsEN.Memo = objRow[convqa_Questions.Memo] == DBNull.Value ? null : objRow[convqa_Questions.Memo].ToString().Trim(); //备注
objvqa_QuestionsEN.UserName = objRow[convqa_Questions.UserName] == DBNull.Value ? null : objRow[convqa_Questions.UserName].ToString().Trim(); //用户名
objvqa_QuestionsEN.IdCurrEduCls = objRow[convqa_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_QuestionsEN.PaperTitle = objRow[convqa_Questions.PaperTitle] == DBNull.Value ? null : objRow[convqa_Questions.PaperTitle].ToString().Trim(); //论文标题
objvqa_QuestionsEN.PdfDivLet = objRow[convqa_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvqa_QuestionsEN.PdfDivTop = objRow[convqa_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvqa_QuestionsEN.PdfPageNumIn = objRow[convqa_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convqa_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvqa_QuestionsEN.PdfPageTop = objRow[convqa_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvqa_QuestionsEN.PdfZoom = objRow[convqa_Questions.PdfZoom] == DBNull.Value ? null : objRow[convqa_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvqa_QuestionsEN.UserId = objRow[convqa_Questions.UserId] == DBNull.Value ? null : objRow[convqa_Questions.UserId].ToString().Trim(); //用户ID
objvqa_QuestionsEN.QuestionsTypeId = objRow[convqa_Questions.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_QuestionsEN.QuestionsTypeName = objRow[convqa_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_QuestionsEN.DiscussCount = objRow[convqa_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvqa_QuestionsEN.GroupDiscussCount = objRow[convqa_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvqa_QuestionsEN.RecommendAnswerCount = objRow[convqa_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_QuestionsEN.QuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_QuestionsEN);
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
List<clsvqa_QuestionsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvqa_QuestionsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_QuestionsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvqa_QuestionsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvqa_QuestionsEN> arrObjLst = new List<clsvqa_QuestionsEN>(); 
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
	clsvqa_QuestionsEN objvqa_QuestionsEN = new clsvqa_QuestionsEN();
try
{
objvqa_QuestionsEN.QuestionsId = objRow[convqa_Questions.QuestionsId].ToString().Trim(); //提问Id
objvqa_QuestionsEN.PaperId = objRow[convqa_Questions.PaperId] == DBNull.Value ? null : objRow[convqa_Questions.PaperId].ToString().Trim(); //论文Id
objvqa_QuestionsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsSubmit].ToString().Trim()); //是否提交
objvqa_QuestionsEN.QaPaperId = objRow[convqa_Questions.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_QuestionsEN.QuestionsContent = objRow[convqa_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvqa_QuestionsEN.PdfContent = objRow[convqa_Questions.PdfContent] == DBNull.Value ? null : objRow[convqa_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvqa_QuestionsEN.PdfPageNum = objRow[convqa_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsDelete].ToString().Trim()); //是否删除
objvqa_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsPublic].ToString().Trim()); //是否公开
objvqa_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsEnd].ToString().Trim()); //是否结束
objvqa_QuestionsEN.VoteCount = objRow[convqa_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.VoteCount].ToString().Trim()); //点赞计数
objvqa_QuestionsEN.AnswerCount = objRow[convqa_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.AnswerCount].ToString().Trim()); //回答计数
objvqa_QuestionsEN.OrderNum = objRow[convqa_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.OrderNum].ToString().Trim()); //序号
objvqa_QuestionsEN.UpdUser = objRow[convqa_Questions.UpdUser] == DBNull.Value ? null : objRow[convqa_Questions.UpdUser].ToString().Trim(); //修改人
objvqa_QuestionsEN.UpdDate = objRow[convqa_Questions.UpdDate] == DBNull.Value ? null : objRow[convqa_Questions.UpdDate].ToString().Trim(); //修改日期
objvqa_QuestionsEN.Memo = objRow[convqa_Questions.Memo] == DBNull.Value ? null : objRow[convqa_Questions.Memo].ToString().Trim(); //备注
objvqa_QuestionsEN.UserName = objRow[convqa_Questions.UserName] == DBNull.Value ? null : objRow[convqa_Questions.UserName].ToString().Trim(); //用户名
objvqa_QuestionsEN.IdCurrEduCls = objRow[convqa_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_QuestionsEN.PaperTitle = objRow[convqa_Questions.PaperTitle] == DBNull.Value ? null : objRow[convqa_Questions.PaperTitle].ToString().Trim(); //论文标题
objvqa_QuestionsEN.PdfDivLet = objRow[convqa_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvqa_QuestionsEN.PdfDivTop = objRow[convqa_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvqa_QuestionsEN.PdfPageNumIn = objRow[convqa_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convqa_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvqa_QuestionsEN.PdfPageTop = objRow[convqa_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvqa_QuestionsEN.PdfZoom = objRow[convqa_Questions.PdfZoom] == DBNull.Value ? null : objRow[convqa_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvqa_QuestionsEN.UserId = objRow[convqa_Questions.UserId] == DBNull.Value ? null : objRow[convqa_Questions.UserId].ToString().Trim(); //用户ID
objvqa_QuestionsEN.QuestionsTypeId = objRow[convqa_Questions.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_QuestionsEN.QuestionsTypeName = objRow[convqa_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_QuestionsEN.DiscussCount = objRow[convqa_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvqa_QuestionsEN.GroupDiscussCount = objRow[convqa_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvqa_QuestionsEN.RecommendAnswerCount = objRow[convqa_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_QuestionsEN.QuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_QuestionsEN);
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
public static List<clsvqa_QuestionsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvqa_QuestionsEN> arrObjLst = new List<clsvqa_QuestionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_QuestionsEN objvqa_QuestionsEN = new clsvqa_QuestionsEN();
try
{
objvqa_QuestionsEN.QuestionsId = objRow[convqa_Questions.QuestionsId].ToString().Trim(); //提问Id
objvqa_QuestionsEN.PaperId = objRow[convqa_Questions.PaperId] == DBNull.Value ? null : objRow[convqa_Questions.PaperId].ToString().Trim(); //论文Id
objvqa_QuestionsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsSubmit].ToString().Trim()); //是否提交
objvqa_QuestionsEN.QaPaperId = objRow[convqa_Questions.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_QuestionsEN.QuestionsContent = objRow[convqa_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvqa_QuestionsEN.PdfContent = objRow[convqa_Questions.PdfContent] == DBNull.Value ? null : objRow[convqa_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvqa_QuestionsEN.PdfPageNum = objRow[convqa_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsDelete].ToString().Trim()); //是否删除
objvqa_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsPublic].ToString().Trim()); //是否公开
objvqa_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsEnd].ToString().Trim()); //是否结束
objvqa_QuestionsEN.VoteCount = objRow[convqa_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.VoteCount].ToString().Trim()); //点赞计数
objvqa_QuestionsEN.AnswerCount = objRow[convqa_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.AnswerCount].ToString().Trim()); //回答计数
objvqa_QuestionsEN.OrderNum = objRow[convqa_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.OrderNum].ToString().Trim()); //序号
objvqa_QuestionsEN.UpdUser = objRow[convqa_Questions.UpdUser] == DBNull.Value ? null : objRow[convqa_Questions.UpdUser].ToString().Trim(); //修改人
objvqa_QuestionsEN.UpdDate = objRow[convqa_Questions.UpdDate] == DBNull.Value ? null : objRow[convqa_Questions.UpdDate].ToString().Trim(); //修改日期
objvqa_QuestionsEN.Memo = objRow[convqa_Questions.Memo] == DBNull.Value ? null : objRow[convqa_Questions.Memo].ToString().Trim(); //备注
objvqa_QuestionsEN.UserName = objRow[convqa_Questions.UserName] == DBNull.Value ? null : objRow[convqa_Questions.UserName].ToString().Trim(); //用户名
objvqa_QuestionsEN.IdCurrEduCls = objRow[convqa_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_QuestionsEN.PaperTitle = objRow[convqa_Questions.PaperTitle] == DBNull.Value ? null : objRow[convqa_Questions.PaperTitle].ToString().Trim(); //论文标题
objvqa_QuestionsEN.PdfDivLet = objRow[convqa_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvqa_QuestionsEN.PdfDivTop = objRow[convqa_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvqa_QuestionsEN.PdfPageNumIn = objRow[convqa_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convqa_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvqa_QuestionsEN.PdfPageTop = objRow[convqa_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvqa_QuestionsEN.PdfZoom = objRow[convqa_Questions.PdfZoom] == DBNull.Value ? null : objRow[convqa_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvqa_QuestionsEN.UserId = objRow[convqa_Questions.UserId] == DBNull.Value ? null : objRow[convqa_Questions.UserId].ToString().Trim(); //用户ID
objvqa_QuestionsEN.QuestionsTypeId = objRow[convqa_Questions.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_QuestionsEN.QuestionsTypeName = objRow[convqa_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_QuestionsEN.DiscussCount = objRow[convqa_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvqa_QuestionsEN.GroupDiscussCount = objRow[convqa_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvqa_QuestionsEN.RecommendAnswerCount = objRow[convqa_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_QuestionsEN.QuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_QuestionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvqa_QuestionsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvqa_QuestionsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvqa_QuestionsEN> arrObjLst = new List<clsvqa_QuestionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_QuestionsEN objvqa_QuestionsEN = new clsvqa_QuestionsEN();
try
{
objvqa_QuestionsEN.QuestionsId = objRow[convqa_Questions.QuestionsId].ToString().Trim(); //提问Id
objvqa_QuestionsEN.PaperId = objRow[convqa_Questions.PaperId] == DBNull.Value ? null : objRow[convqa_Questions.PaperId].ToString().Trim(); //论文Id
objvqa_QuestionsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsSubmit].ToString().Trim()); //是否提交
objvqa_QuestionsEN.QaPaperId = objRow[convqa_Questions.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_QuestionsEN.QuestionsContent = objRow[convqa_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvqa_QuestionsEN.PdfContent = objRow[convqa_Questions.PdfContent] == DBNull.Value ? null : objRow[convqa_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvqa_QuestionsEN.PdfPageNum = objRow[convqa_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsDelete].ToString().Trim()); //是否删除
objvqa_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsPublic].ToString().Trim()); //是否公开
objvqa_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsEnd].ToString().Trim()); //是否结束
objvqa_QuestionsEN.VoteCount = objRow[convqa_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.VoteCount].ToString().Trim()); //点赞计数
objvqa_QuestionsEN.AnswerCount = objRow[convqa_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.AnswerCount].ToString().Trim()); //回答计数
objvqa_QuestionsEN.OrderNum = objRow[convqa_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.OrderNum].ToString().Trim()); //序号
objvqa_QuestionsEN.UpdUser = objRow[convqa_Questions.UpdUser] == DBNull.Value ? null : objRow[convqa_Questions.UpdUser].ToString().Trim(); //修改人
objvqa_QuestionsEN.UpdDate = objRow[convqa_Questions.UpdDate] == DBNull.Value ? null : objRow[convqa_Questions.UpdDate].ToString().Trim(); //修改日期
objvqa_QuestionsEN.Memo = objRow[convqa_Questions.Memo] == DBNull.Value ? null : objRow[convqa_Questions.Memo].ToString().Trim(); //备注
objvqa_QuestionsEN.UserName = objRow[convqa_Questions.UserName] == DBNull.Value ? null : objRow[convqa_Questions.UserName].ToString().Trim(); //用户名
objvqa_QuestionsEN.IdCurrEduCls = objRow[convqa_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_QuestionsEN.PaperTitle = objRow[convqa_Questions.PaperTitle] == DBNull.Value ? null : objRow[convqa_Questions.PaperTitle].ToString().Trim(); //论文标题
objvqa_QuestionsEN.PdfDivLet = objRow[convqa_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvqa_QuestionsEN.PdfDivTop = objRow[convqa_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvqa_QuestionsEN.PdfPageNumIn = objRow[convqa_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convqa_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvqa_QuestionsEN.PdfPageTop = objRow[convqa_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvqa_QuestionsEN.PdfZoom = objRow[convqa_Questions.PdfZoom] == DBNull.Value ? null : objRow[convqa_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvqa_QuestionsEN.UserId = objRow[convqa_Questions.UserId] == DBNull.Value ? null : objRow[convqa_Questions.UserId].ToString().Trim(); //用户ID
objvqa_QuestionsEN.QuestionsTypeId = objRow[convqa_Questions.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_QuestionsEN.QuestionsTypeName = objRow[convqa_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_QuestionsEN.DiscussCount = objRow[convqa_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvqa_QuestionsEN.GroupDiscussCount = objRow[convqa_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvqa_QuestionsEN.RecommendAnswerCount = objRow[convqa_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_QuestionsEN.QuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_QuestionsEN);
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
public static List<clsvqa_QuestionsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvqa_QuestionsEN> arrObjLst = new List<clsvqa_QuestionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_QuestionsEN objvqa_QuestionsEN = new clsvqa_QuestionsEN();
try
{
objvqa_QuestionsEN.QuestionsId = objRow[convqa_Questions.QuestionsId].ToString().Trim(); //提问Id
objvqa_QuestionsEN.PaperId = objRow[convqa_Questions.PaperId] == DBNull.Value ? null : objRow[convqa_Questions.PaperId].ToString().Trim(); //论文Id
objvqa_QuestionsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsSubmit].ToString().Trim()); //是否提交
objvqa_QuestionsEN.QaPaperId = objRow[convqa_Questions.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_QuestionsEN.QuestionsContent = objRow[convqa_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvqa_QuestionsEN.PdfContent = objRow[convqa_Questions.PdfContent] == DBNull.Value ? null : objRow[convqa_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvqa_QuestionsEN.PdfPageNum = objRow[convqa_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsDelete].ToString().Trim()); //是否删除
objvqa_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsPublic].ToString().Trim()); //是否公开
objvqa_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsEnd].ToString().Trim()); //是否结束
objvqa_QuestionsEN.VoteCount = objRow[convqa_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.VoteCount].ToString().Trim()); //点赞计数
objvqa_QuestionsEN.AnswerCount = objRow[convqa_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.AnswerCount].ToString().Trim()); //回答计数
objvqa_QuestionsEN.OrderNum = objRow[convqa_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.OrderNum].ToString().Trim()); //序号
objvqa_QuestionsEN.UpdUser = objRow[convqa_Questions.UpdUser] == DBNull.Value ? null : objRow[convqa_Questions.UpdUser].ToString().Trim(); //修改人
objvqa_QuestionsEN.UpdDate = objRow[convqa_Questions.UpdDate] == DBNull.Value ? null : objRow[convqa_Questions.UpdDate].ToString().Trim(); //修改日期
objvqa_QuestionsEN.Memo = objRow[convqa_Questions.Memo] == DBNull.Value ? null : objRow[convqa_Questions.Memo].ToString().Trim(); //备注
objvqa_QuestionsEN.UserName = objRow[convqa_Questions.UserName] == DBNull.Value ? null : objRow[convqa_Questions.UserName].ToString().Trim(); //用户名
objvqa_QuestionsEN.IdCurrEduCls = objRow[convqa_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_QuestionsEN.PaperTitle = objRow[convqa_Questions.PaperTitle] == DBNull.Value ? null : objRow[convqa_Questions.PaperTitle].ToString().Trim(); //论文标题
objvqa_QuestionsEN.PdfDivLet = objRow[convqa_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvqa_QuestionsEN.PdfDivTop = objRow[convqa_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvqa_QuestionsEN.PdfPageNumIn = objRow[convqa_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convqa_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvqa_QuestionsEN.PdfPageTop = objRow[convqa_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvqa_QuestionsEN.PdfZoom = objRow[convqa_Questions.PdfZoom] == DBNull.Value ? null : objRow[convqa_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvqa_QuestionsEN.UserId = objRow[convqa_Questions.UserId] == DBNull.Value ? null : objRow[convqa_Questions.UserId].ToString().Trim(); //用户ID
objvqa_QuestionsEN.QuestionsTypeId = objRow[convqa_Questions.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_QuestionsEN.QuestionsTypeName = objRow[convqa_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_QuestionsEN.DiscussCount = objRow[convqa_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvqa_QuestionsEN.GroupDiscussCount = objRow[convqa_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvqa_QuestionsEN.RecommendAnswerCount = objRow[convqa_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_QuestionsEN.QuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_QuestionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_QuestionsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvqa_QuestionsEN> arrObjLst = new List<clsvqa_QuestionsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_QuestionsEN objvqa_QuestionsEN = new clsvqa_QuestionsEN();
try
{
objvqa_QuestionsEN.QuestionsId = objRow[convqa_Questions.QuestionsId].ToString().Trim(); //提问Id
objvqa_QuestionsEN.PaperId = objRow[convqa_Questions.PaperId] == DBNull.Value ? null : objRow[convqa_Questions.PaperId].ToString().Trim(); //论文Id
objvqa_QuestionsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsSubmit].ToString().Trim()); //是否提交
objvqa_QuestionsEN.QaPaperId = objRow[convqa_Questions.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_QuestionsEN.QuestionsContent = objRow[convqa_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvqa_QuestionsEN.PdfContent = objRow[convqa_Questions.PdfContent] == DBNull.Value ? null : objRow[convqa_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvqa_QuestionsEN.PdfPageNum = objRow[convqa_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsDelete].ToString().Trim()); //是否删除
objvqa_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsPublic].ToString().Trim()); //是否公开
objvqa_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convqa_Questions.IsEnd].ToString().Trim()); //是否结束
objvqa_QuestionsEN.VoteCount = objRow[convqa_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.VoteCount].ToString().Trim()); //点赞计数
objvqa_QuestionsEN.AnswerCount = objRow[convqa_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.AnswerCount].ToString().Trim()); //回答计数
objvqa_QuestionsEN.OrderNum = objRow[convqa_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.OrderNum].ToString().Trim()); //序号
objvqa_QuestionsEN.UpdUser = objRow[convqa_Questions.UpdUser] == DBNull.Value ? null : objRow[convqa_Questions.UpdUser].ToString().Trim(); //修改人
objvqa_QuestionsEN.UpdDate = objRow[convqa_Questions.UpdDate] == DBNull.Value ? null : objRow[convqa_Questions.UpdDate].ToString().Trim(); //修改日期
objvqa_QuestionsEN.Memo = objRow[convqa_Questions.Memo] == DBNull.Value ? null : objRow[convqa_Questions.Memo].ToString().Trim(); //备注
objvqa_QuestionsEN.UserName = objRow[convqa_Questions.UserName] == DBNull.Value ? null : objRow[convqa_Questions.UserName].ToString().Trim(); //用户名
objvqa_QuestionsEN.IdCurrEduCls = objRow[convqa_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_QuestionsEN.PaperTitle = objRow[convqa_Questions.PaperTitle] == DBNull.Value ? null : objRow[convqa_Questions.PaperTitle].ToString().Trim(); //论文标题
objvqa_QuestionsEN.PdfDivLet = objRow[convqa_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvqa_QuestionsEN.PdfDivTop = objRow[convqa_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convqa_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvqa_QuestionsEN.PdfPageNumIn = objRow[convqa_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convqa_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvqa_QuestionsEN.PdfPageTop = objRow[convqa_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvqa_QuestionsEN.PdfZoom = objRow[convqa_Questions.PdfZoom] == DBNull.Value ? null : objRow[convqa_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvqa_QuestionsEN.UserId = objRow[convqa_Questions.UserId] == DBNull.Value ? null : objRow[convqa_Questions.UserId].ToString().Trim(); //用户ID
objvqa_QuestionsEN.QuestionsTypeId = objRow[convqa_Questions.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_QuestionsEN.QuestionsTypeName = objRow[convqa_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_QuestionsEN.DiscussCount = objRow[convqa_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvqa_QuestionsEN.GroupDiscussCount = objRow[convqa_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvqa_QuestionsEN.RecommendAnswerCount = objRow[convqa_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_QuestionsEN.QuestionsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_QuestionsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvqa_Questions(ref clsvqa_QuestionsEN objvqa_QuestionsEN)
{
bool bolResult = vqa_QuestionsDA.Getvqa_Questions(ref objvqa_QuestionsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strQuestionsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvqa_QuestionsEN GetObjByQuestionsId(string strQuestionsId)
{
if (strQuestionsId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strQuestionsId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strQuestionsId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strQuestionsId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvqa_QuestionsEN objvqa_QuestionsEN = vqa_QuestionsDA.GetObjByQuestionsId(strQuestionsId);
return objvqa_QuestionsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvqa_QuestionsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvqa_QuestionsEN objvqa_QuestionsEN = vqa_QuestionsDA.GetFirstObj(strWhereCond);
 return objvqa_QuestionsEN;
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
public static clsvqa_QuestionsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvqa_QuestionsEN objvqa_QuestionsEN = vqa_QuestionsDA.GetObjByDataRow(objRow);
 return objvqa_QuestionsEN;
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
public static clsvqa_QuestionsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvqa_QuestionsEN objvqa_QuestionsEN = vqa_QuestionsDA.GetObjByDataRow(objRow);
 return objvqa_QuestionsEN;
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
 /// <param name = "strQuestionsId">所给的关键字</param>
 /// <param name = "lstvqa_QuestionsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvqa_QuestionsEN GetObjByQuestionsIdFromList(string strQuestionsId, List<clsvqa_QuestionsEN> lstvqa_QuestionsObjLst)
{
foreach (clsvqa_QuestionsEN objvqa_QuestionsEN in lstvqa_QuestionsObjLst)
{
if (objvqa_QuestionsEN.QuestionsId == strQuestionsId)
{
return objvqa_QuestionsEN;
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
 string strQuestionsId;
 try
 {
 strQuestionsId = new clsvqa_QuestionsDA().GetFirstID(strWhereCond);
 return strQuestionsId;
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
 arrList = vqa_QuestionsDA.GetID(strWhereCond);
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
bool bolIsExist = vqa_QuestionsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strQuestionsId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strQuestionsId)
{
if (string.IsNullOrEmpty(strQuestionsId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strQuestionsId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vqa_QuestionsDA.IsExist(strQuestionsId);
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
 bolIsExist = clsvqa_QuestionsDA.IsExistTable();
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
 bolIsExist = vqa_QuestionsDA.IsExistTable(strTabName);
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
 /// <param name = "objvqa_QuestionsENS">源对象</param>
 /// <param name = "objvqa_QuestionsENT">目标对象</param>
 public static void CopyTo(clsvqa_QuestionsEN objvqa_QuestionsENS, clsvqa_QuestionsEN objvqa_QuestionsENT)
{
try
{
objvqa_QuestionsENT.QuestionsId = objvqa_QuestionsENS.QuestionsId; //提问Id
objvqa_QuestionsENT.PaperId = objvqa_QuestionsENS.PaperId; //论文Id
objvqa_QuestionsENT.IsSubmit = objvqa_QuestionsENS.IsSubmit; //是否提交
objvqa_QuestionsENT.QaPaperId = objvqa_QuestionsENS.QaPaperId; //论文答疑Id
objvqa_QuestionsENT.QuestionsContent = objvqa_QuestionsENS.QuestionsContent; //提问内容
objvqa_QuestionsENT.PdfContent = objvqa_QuestionsENS.PdfContent; //Pdf内容
objvqa_QuestionsENT.PdfPageNum = objvqa_QuestionsENS.PdfPageNum; //Pdf页码
objvqa_QuestionsENT.IsDelete = objvqa_QuestionsENS.IsDelete; //是否删除
objvqa_QuestionsENT.IsPublic = objvqa_QuestionsENS.IsPublic; //是否公开
objvqa_QuestionsENT.IsEnd = objvqa_QuestionsENS.IsEnd; //是否结束
objvqa_QuestionsENT.VoteCount = objvqa_QuestionsENS.VoteCount; //点赞计数
objvqa_QuestionsENT.AnswerCount = objvqa_QuestionsENS.AnswerCount; //回答计数
objvqa_QuestionsENT.OrderNum = objvqa_QuestionsENS.OrderNum; //序号
objvqa_QuestionsENT.UpdUser = objvqa_QuestionsENS.UpdUser; //修改人
objvqa_QuestionsENT.UpdDate = objvqa_QuestionsENS.UpdDate; //修改日期
objvqa_QuestionsENT.Memo = objvqa_QuestionsENS.Memo; //备注
objvqa_QuestionsENT.UserName = objvqa_QuestionsENS.UserName; //用户名
objvqa_QuestionsENT.IdCurrEduCls = objvqa_QuestionsENS.IdCurrEduCls; //教学班流水号
objvqa_QuestionsENT.PaperTitle = objvqa_QuestionsENS.PaperTitle; //论文标题
objvqa_QuestionsENT.PdfDivLet = objvqa_QuestionsENS.PdfDivLet; //PdfDivLet
objvqa_QuestionsENT.PdfDivTop = objvqa_QuestionsENS.PdfDivTop; //PdfDivTop
objvqa_QuestionsENT.PdfPageNumIn = objvqa_QuestionsENS.PdfPageNumIn; //PdfPageNumIn
objvqa_QuestionsENT.PdfPageTop = objvqa_QuestionsENS.PdfPageTop; //pdf页面顶部位置
objvqa_QuestionsENT.PdfZoom = objvqa_QuestionsENS.PdfZoom; //PdfZoom
objvqa_QuestionsENT.UserId = objvqa_QuestionsENS.UserId; //用户ID
objvqa_QuestionsENT.QuestionsTypeId = objvqa_QuestionsENS.QuestionsTypeId; //问题类型Id
objvqa_QuestionsENT.QuestionsTypeName = objvqa_QuestionsENS.QuestionsTypeName; //问题类型名称
objvqa_QuestionsENT.DiscussCount = objvqa_QuestionsENS.DiscussCount; //DiscussCount
objvqa_QuestionsENT.GroupDiscussCount = objvqa_QuestionsENS.GroupDiscussCount; //GroupDiscussCount
objvqa_QuestionsENT.RecommendAnswerCount = objvqa_QuestionsENS.RecommendAnswerCount; //RecommendAnswerCount
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
 /// <param name = "objvqa_QuestionsEN">源简化对象</param>
 public static void SetUpdFlag(clsvqa_QuestionsEN objvqa_QuestionsEN)
{
try
{
objvqa_QuestionsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvqa_QuestionsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convqa_Questions.QuestionsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.QuestionsId = objvqa_QuestionsEN.QuestionsId; //提问Id
}
if (arrFldSet.Contains(convqa_Questions.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.PaperId = objvqa_QuestionsEN.PaperId == "[null]" ? null :  objvqa_QuestionsEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convqa_Questions.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.IsSubmit = objvqa_QuestionsEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convqa_Questions.QaPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.QaPaperId = objvqa_QuestionsEN.QaPaperId; //论文答疑Id
}
if (arrFldSet.Contains(convqa_Questions.QuestionsContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.QuestionsContent = objvqa_QuestionsEN.QuestionsContent == "[null]" ? null :  objvqa_QuestionsEN.QuestionsContent; //提问内容
}
if (arrFldSet.Contains(convqa_Questions.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.PdfContent = objvqa_QuestionsEN.PdfContent == "[null]" ? null :  objvqa_QuestionsEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(convqa_Questions.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.PdfPageNum = objvqa_QuestionsEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(convqa_Questions.IsDelete, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.IsDelete = objvqa_QuestionsEN.IsDelete; //是否删除
}
if (arrFldSet.Contains(convqa_Questions.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.IsPublic = objvqa_QuestionsEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(convqa_Questions.IsEnd, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.IsEnd = objvqa_QuestionsEN.IsEnd; //是否结束
}
if (arrFldSet.Contains(convqa_Questions.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.VoteCount = objvqa_QuestionsEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(convqa_Questions.AnswerCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.AnswerCount = objvqa_QuestionsEN.AnswerCount; //回答计数
}
if (arrFldSet.Contains(convqa_Questions.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.OrderNum = objvqa_QuestionsEN.OrderNum; //序号
}
if (arrFldSet.Contains(convqa_Questions.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.UpdUser = objvqa_QuestionsEN.UpdUser == "[null]" ? null :  objvqa_QuestionsEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convqa_Questions.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.UpdDate = objvqa_QuestionsEN.UpdDate == "[null]" ? null :  objvqa_QuestionsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convqa_Questions.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.Memo = objvqa_QuestionsEN.Memo == "[null]" ? null :  objvqa_QuestionsEN.Memo; //备注
}
if (arrFldSet.Contains(convqa_Questions.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.UserName = objvqa_QuestionsEN.UserName == "[null]" ? null :  objvqa_QuestionsEN.UserName; //用户名
}
if (arrFldSet.Contains(convqa_Questions.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.IdCurrEduCls = objvqa_QuestionsEN.IdCurrEduCls == "[null]" ? null :  objvqa_QuestionsEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convqa_Questions.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.PaperTitle = objvqa_QuestionsEN.PaperTitle == "[null]" ? null :  objvqa_QuestionsEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convqa_Questions.PdfDivLet, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.PdfDivLet = objvqa_QuestionsEN.PdfDivLet == "[null]" ? null :  objvqa_QuestionsEN.PdfDivLet; //PdfDivLet
}
if (arrFldSet.Contains(convqa_Questions.PdfDivTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.PdfDivTop = objvqa_QuestionsEN.PdfDivTop == "[null]" ? null :  objvqa_QuestionsEN.PdfDivTop; //PdfDivTop
}
if (arrFldSet.Contains(convqa_Questions.PdfPageNumIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.PdfPageNumIn = objvqa_QuestionsEN.PdfPageNumIn == "[null]" ? null :  objvqa_QuestionsEN.PdfPageNumIn; //PdfPageNumIn
}
if (arrFldSet.Contains(convqa_Questions.PdfPageTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.PdfPageTop = objvqa_QuestionsEN.PdfPageTop; //pdf页面顶部位置
}
if (arrFldSet.Contains(convqa_Questions.PdfZoom, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.PdfZoom = objvqa_QuestionsEN.PdfZoom == "[null]" ? null :  objvqa_QuestionsEN.PdfZoom; //PdfZoom
}
if (arrFldSet.Contains(convqa_Questions.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.UserId = objvqa_QuestionsEN.UserId == "[null]" ? null :  objvqa_QuestionsEN.UserId; //用户ID
}
if (arrFldSet.Contains(convqa_Questions.QuestionsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.QuestionsTypeId = objvqa_QuestionsEN.QuestionsTypeId == "[null]" ? null :  objvqa_QuestionsEN.QuestionsTypeId; //问题类型Id
}
if (arrFldSet.Contains(convqa_Questions.QuestionsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.QuestionsTypeName = objvqa_QuestionsEN.QuestionsTypeName == "[null]" ? null :  objvqa_QuestionsEN.QuestionsTypeName; //问题类型名称
}
if (arrFldSet.Contains(convqa_Questions.DiscussCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.DiscussCount = objvqa_QuestionsEN.DiscussCount; //DiscussCount
}
if (arrFldSet.Contains(convqa_Questions.GroupDiscussCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.GroupDiscussCount = objvqa_QuestionsEN.GroupDiscussCount; //GroupDiscussCount
}
if (arrFldSet.Contains(convqa_Questions.RecommendAnswerCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_QuestionsEN.RecommendAnswerCount = objvqa_QuestionsEN.RecommendAnswerCount; //RecommendAnswerCount
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
 /// <param name = "objvqa_QuestionsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvqa_QuestionsEN objvqa_QuestionsEN)
{
try
{
if (objvqa_QuestionsEN.PaperId == "[null]") objvqa_QuestionsEN.PaperId = null; //论文Id
if (objvqa_QuestionsEN.QuestionsContent == "[null]") objvqa_QuestionsEN.QuestionsContent = null; //提问内容
if (objvqa_QuestionsEN.PdfContent == "[null]") objvqa_QuestionsEN.PdfContent = null; //Pdf内容
if (objvqa_QuestionsEN.UpdUser == "[null]") objvqa_QuestionsEN.UpdUser = null; //修改人
if (objvqa_QuestionsEN.UpdDate == "[null]") objvqa_QuestionsEN.UpdDate = null; //修改日期
if (objvqa_QuestionsEN.Memo == "[null]") objvqa_QuestionsEN.Memo = null; //备注
if (objvqa_QuestionsEN.UserName == "[null]") objvqa_QuestionsEN.UserName = null; //用户名
if (objvqa_QuestionsEN.IdCurrEduCls == "[null]") objvqa_QuestionsEN.IdCurrEduCls = null; //教学班流水号
if (objvqa_QuestionsEN.PaperTitle == "[null]") objvqa_QuestionsEN.PaperTitle = null; //论文标题
if (objvqa_QuestionsEN.PdfDivLet == "[null]") objvqa_QuestionsEN.PdfDivLet = null; //PdfDivLet
if (objvqa_QuestionsEN.PdfDivTop == "[null]") objvqa_QuestionsEN.PdfDivTop = null; //PdfDivTop
if (objvqa_QuestionsEN.PdfPageNumIn == "[null]") objvqa_QuestionsEN.PdfPageNumIn = null; //PdfPageNumIn
if (objvqa_QuestionsEN.PdfZoom == "[null]") objvqa_QuestionsEN.PdfZoom = null; //PdfZoom
if (objvqa_QuestionsEN.UserId == "[null]") objvqa_QuestionsEN.UserId = null; //用户ID
if (objvqa_QuestionsEN.QuestionsTypeId == "[null]") objvqa_QuestionsEN.QuestionsTypeId = null; //问题类型Id
if (objvqa_QuestionsEN.QuestionsTypeName == "[null]") objvqa_QuestionsEN.QuestionsTypeName = null; //问题类型名称
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
public static void CheckProperty4Condition(clsvqa_QuestionsEN objvqa_QuestionsEN)
{
 vqa_QuestionsDA.CheckProperty4Condition(objvqa_QuestionsEN);
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
if (clsPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperBL没有刷新缓存机制(clsPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsqa_QuestionsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_QuestionsBL没有刷新缓存机制(clsqa_QuestionsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsqa_QuestionsTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_QuestionsTypeBL没有刷新缓存机制(clsqa_QuestionsTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionsId");
//if (arrvqa_QuestionsObjLstCache == null)
//{
//arrvqa_QuestionsObjLstCache = vqa_QuestionsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strQuestionsId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvqa_QuestionsEN GetObjByQuestionsIdCache(string strQuestionsId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvqa_QuestionsEN._CurrTabName);
List<clsvqa_QuestionsEN> arrvqa_QuestionsObjLstCache = GetObjLstCache();
IEnumerable <clsvqa_QuestionsEN> arrvqa_QuestionsObjLst_Sel =
arrvqa_QuestionsObjLstCache
.Where(x=> x.QuestionsId == strQuestionsId 
);
if (arrvqa_QuestionsObjLst_Sel.Count() == 0)
{
   clsvqa_QuestionsEN obj = clsvqa_QuestionsBL.GetObjByQuestionsId(strQuestionsId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvqa_QuestionsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvqa_QuestionsEN> GetAllvqa_QuestionsObjLstCache()
{
//获取缓存中的对象列表
List<clsvqa_QuestionsEN> arrvqa_QuestionsObjLstCache = GetObjLstCache(); 
return arrvqa_QuestionsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvqa_QuestionsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvqa_QuestionsEN._CurrTabName);
List<clsvqa_QuestionsEN> arrvqa_QuestionsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvqa_QuestionsObjLstCache;
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
string strKey = string.Format("{0}", clsvqa_QuestionsEN._CurrTabName);
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

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--vqa_Questions(v答疑提问)
 /// 唯一性条件:QuestionsId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvqa_QuestionsEN objvqa_QuestionsEN)
{
//检测记录是否存在
string strResult = vqa_QuestionsDA.GetUniCondStr(objvqa_QuestionsEN);
return strResult;
}


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
public static string Func(string strInFldName, string strOutFldName, string strQuestionsId)
{
if (strInFldName != convqa_Questions.QuestionsId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convqa_Questions.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convqa_Questions.AttributeName));
throw new Exception(strMsg);
}
var objvqa_Questions = clsvqa_QuestionsBL.GetObjByQuestionsIdCache(strQuestionsId);
if (objvqa_Questions == null) return "";
return objvqa_Questions[strOutFldName].ToString();
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
int intRecCount = clsvqa_QuestionsDA.GetRecCount(strTabName);
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
int intRecCount = clsvqa_QuestionsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvqa_QuestionsDA.GetRecCount();
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
int intRecCount = clsvqa_QuestionsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvqa_QuestionsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvqa_QuestionsEN objvqa_QuestionsCond)
{
List<clsvqa_QuestionsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvqa_QuestionsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convqa_Questions.AttributeName)
{
if (objvqa_QuestionsCond.IsUpdated(strFldName) == false) continue;
if (objvqa_QuestionsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvqa_QuestionsCond[strFldName].ToString());
}
else
{
if (objvqa_QuestionsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvqa_QuestionsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvqa_QuestionsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvqa_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvqa_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvqa_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvqa_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvqa_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvqa_QuestionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvqa_QuestionsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvqa_QuestionsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvqa_QuestionsCond[strFldName]));
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
 List<string> arrList = clsvqa_QuestionsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vqa_QuestionsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vqa_QuestionsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}