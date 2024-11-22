
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsqa_QuestionsWApi
 表名:qa_Questions(01120642)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:23
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
public static class clsqa_QuestionsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetQuestionsId(this clsqa_QuestionsEN objqa_QuestionsEN, string strQuestionsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionsId, 8, conqa_Questions.QuestionsId);
clsCheckSql.CheckFieldForeignKey(strQuestionsId, 8, conqa_Questions.QuestionsId);
objqa_QuestionsEN.QuestionsId = strQuestionsId; //提问Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.QuestionsId) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.QuestionsId, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.QuestionsId] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN Setqa_PaperId(this clsqa_QuestionsEN objqa_QuestionsEN, string strqa_PaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strqa_PaperId, 8, conqa_Questions.qa_PaperId);
clsCheckSql.CheckFieldForeignKey(strqa_PaperId, 8, conqa_Questions.qa_PaperId);
objqa_QuestionsEN.qa_PaperId = strqa_PaperId; //论文答疑Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.qa_PaperId) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.qa_PaperId, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.qa_PaperId] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetQuestionsContent(this clsqa_QuestionsEN objqa_QuestionsEN, string strQuestionsContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionsContent, 1000, conqa_Questions.QuestionsContent);
objqa_QuestionsEN.QuestionsContent = strQuestionsContent; //提问内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.QuestionsContent) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.QuestionsContent, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.QuestionsContent] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetPdfContent(this clsqa_QuestionsEN objqa_QuestionsEN, string strPdfContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, conqa_Questions.PdfContent);
objqa_QuestionsEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.PdfContent) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.PdfContent, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.PdfContent] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetPdfPageNum(this clsqa_QuestionsEN objqa_QuestionsEN, int intPdfPageNum, string strComparisonOp="")
	{
objqa_QuestionsEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.PdfPageNum) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.PdfPageNum, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.PdfPageNum] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetIsDelete(this clsqa_QuestionsEN objqa_QuestionsEN, bool bolIsDelete, string strComparisonOp="")
	{
objqa_QuestionsEN.IsDelete = bolIsDelete; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.IsDelete) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.IsDelete, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.IsDelete] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetIsPublic(this clsqa_QuestionsEN objqa_QuestionsEN, bool bolIsPublic, string strComparisonOp="")
	{
objqa_QuestionsEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.IsPublic) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.IsPublic, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.IsPublic] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetIsEnd(this clsqa_QuestionsEN objqa_QuestionsEN, bool bolIsEnd, string strComparisonOp="")
	{
objqa_QuestionsEN.IsEnd = bolIsEnd; //是否结束
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.IsEnd) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.IsEnd, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.IsEnd] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetVoteCount(this clsqa_QuestionsEN objqa_QuestionsEN, int intVoteCount, string strComparisonOp="")
	{
objqa_QuestionsEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.VoteCount) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.VoteCount, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.VoteCount] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetAnswerCount(this clsqa_QuestionsEN objqa_QuestionsEN, int intAnswerCount, string strComparisonOp="")
	{
objqa_QuestionsEN.AnswerCount = intAnswerCount; //回答计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.AnswerCount) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.AnswerCount, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.AnswerCount] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetOrderNum(this clsqa_QuestionsEN objqa_QuestionsEN, int intOrderNum, string strComparisonOp="")
	{
objqa_QuestionsEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.OrderNum) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.OrderNum, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.OrderNum] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetUpdUser(this clsqa_QuestionsEN objqa_QuestionsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conqa_Questions.UpdUser);
objqa_QuestionsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.UpdUser) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.UpdUser, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.UpdUser] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetUpdDate(this clsqa_QuestionsEN objqa_QuestionsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conqa_Questions.UpdDate);
objqa_QuestionsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.UpdDate) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.UpdDate, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.UpdDate] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetMemo(this clsqa_QuestionsEN objqa_QuestionsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conqa_Questions.Memo);
objqa_QuestionsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.Memo) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.Memo, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.Memo] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetPdfDivLet(this clsqa_QuestionsEN objqa_QuestionsEN, string strPdfDivLet, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, conqa_Questions.PdfDivLet);
objqa_QuestionsEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.PdfDivLet) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.PdfDivLet, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.PdfDivLet] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetPdfDivTop(this clsqa_QuestionsEN objqa_QuestionsEN, string strPdfDivTop, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, conqa_Questions.PdfDivTop);
objqa_QuestionsEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.PdfDivTop) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.PdfDivTop, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.PdfDivTop] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetPdfPageNumIn(this clsqa_QuestionsEN objqa_QuestionsEN, string strPdfPageNumIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, conqa_Questions.PdfPageNumIn);
objqa_QuestionsEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.PdfPageNumIn) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.PdfPageNumIn, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.PdfPageNumIn] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetPdfPageTop(this clsqa_QuestionsEN objqa_QuestionsEN, int intPdfPageTop, string strComparisonOp="")
	{
objqa_QuestionsEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.PdfPageTop) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.PdfPageTop, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.PdfPageTop] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetPdfZoom(this clsqa_QuestionsEN objqa_QuestionsEN, string strPdfZoom, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, conqa_Questions.PdfZoom);
objqa_QuestionsEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.PdfZoom) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.PdfZoom, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.PdfZoom] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetPaperId(this clsqa_QuestionsEN objqa_QuestionsEN, string strPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperId, 8, conqa_Questions.PaperId);
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, conqa_Questions.PaperId);
objqa_QuestionsEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.PaperId) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.PaperId, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.PaperId] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetUserId(this clsqa_QuestionsEN objqa_QuestionsEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, conqa_Questions.UserId);
objqa_QuestionsEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.UserId) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.UserId, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.UserId] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetQuestionsTypeId(this clsqa_QuestionsEN objqa_QuestionsEN, string strQuestionsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionsTypeId, 2, conqa_Questions.QuestionsTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionsTypeId, 2, conqa_Questions.QuestionsTypeId);
objqa_QuestionsEN.QuestionsTypeId = strQuestionsTypeId; //问题类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.QuestionsTypeId) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.QuestionsTypeId, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.QuestionsTypeId] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetDiscussCount(this clsqa_QuestionsEN objqa_QuestionsEN, int intDiscussCount, string strComparisonOp="")
	{
objqa_QuestionsEN.DiscussCount = intDiscussCount; //DiscussCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.DiscussCount) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.DiscussCount, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.DiscussCount] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetGroupDiscussCount(this clsqa_QuestionsEN objqa_QuestionsEN, int intGroupDiscussCount, string strComparisonOp="")
	{
objqa_QuestionsEN.GroupDiscussCount = intGroupDiscussCount; //GroupDiscussCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.GroupDiscussCount) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.GroupDiscussCount, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.GroupDiscussCount] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetRecommendAnswerCount(this clsqa_QuestionsEN objqa_QuestionsEN, int intRecommendAnswerCount, string strComparisonOp="")
	{
objqa_QuestionsEN.RecommendAnswerCount = intRecommendAnswerCount; //RecommendAnswerCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.RecommendAnswerCount) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.RecommendAnswerCount, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.RecommendAnswerCount] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN SetCreateDate(this clsqa_QuestionsEN objqa_QuestionsEN, string strCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conqa_Questions.CreateDate);
objqa_QuestionsEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.CreateDate) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.CreateDate, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.CreateDate] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_QuestionsEN Setid_CurrEduCls(this clsqa_QuestionsEN objqa_QuestionsEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, conqa_Questions.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, conqa_Questions.id_CurrEduCls);
objqa_QuestionsEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsEN.dicFldComparisonOp.ContainsKey(conqa_Questions.id_CurrEduCls) == false)
{
objqa_QuestionsEN.dicFldComparisonOp.Add(conqa_Questions.id_CurrEduCls, strComparisonOp);
}
else
{
objqa_QuestionsEN.dicFldComparisonOp[conqa_Questions.id_CurrEduCls] = strComparisonOp;
}
}
return objqa_QuestionsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsqa_QuestionsEN objqa_Questions_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.QuestionsId) == true)
{
string strComparisonOp_QuestionsId = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.QuestionsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Questions.QuestionsId, objqa_Questions_Cond.QuestionsId, strComparisonOp_QuestionsId);
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.qa_PaperId) == true)
{
string strComparisonOp_qa_PaperId = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.qa_PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Questions.qa_PaperId, objqa_Questions_Cond.qa_PaperId, strComparisonOp_qa_PaperId);
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.QuestionsContent) == true)
{
string strComparisonOp_QuestionsContent = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.QuestionsContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Questions.QuestionsContent, objqa_Questions_Cond.QuestionsContent, strComparisonOp_QuestionsContent);
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.PdfContent) == true)
{
string strComparisonOp_PdfContent = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Questions.PdfContent, objqa_Questions_Cond.PdfContent, strComparisonOp_PdfContent);
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.PdfPageNum) == true)
{
string strComparisonOp_PdfPageNum = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Questions.PdfPageNum, objqa_Questions_Cond.PdfPageNum, strComparisonOp_PdfPageNum);
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.IsDelete) == true)
{
if (objqa_Questions_Cond.IsDelete == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_Questions.IsDelete);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_Questions.IsDelete);
}
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.IsPublic) == true)
{
if (objqa_Questions_Cond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_Questions.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_Questions.IsPublic);
}
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.IsEnd) == true)
{
if (objqa_Questions_Cond.IsEnd == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_Questions.IsEnd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_Questions.IsEnd);
}
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.VoteCount) == true)
{
string strComparisonOp_VoteCount = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Questions.VoteCount, objqa_Questions_Cond.VoteCount, strComparisonOp_VoteCount);
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.AnswerCount) == true)
{
string strComparisonOp_AnswerCount = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.AnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Questions.AnswerCount, objqa_Questions_Cond.AnswerCount, strComparisonOp_AnswerCount);
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.OrderNum) == true)
{
string strComparisonOp_OrderNum = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Questions.OrderNum, objqa_Questions_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.UpdUser) == true)
{
string strComparisonOp_UpdUser = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Questions.UpdUser, objqa_Questions_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.UpdDate) == true)
{
string strComparisonOp_UpdDate = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Questions.UpdDate, objqa_Questions_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.Memo) == true)
{
string strComparisonOp_Memo = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Questions.Memo, objqa_Questions_Cond.Memo, strComparisonOp_Memo);
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.PdfDivLet) == true)
{
string strComparisonOp_PdfDivLet = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Questions.PdfDivLet, objqa_Questions_Cond.PdfDivLet, strComparisonOp_PdfDivLet);
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.PdfDivTop) == true)
{
string strComparisonOp_PdfDivTop = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Questions.PdfDivTop, objqa_Questions_Cond.PdfDivTop, strComparisonOp_PdfDivTop);
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.PdfPageNumIn) == true)
{
string strComparisonOp_PdfPageNumIn = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Questions.PdfPageNumIn, objqa_Questions_Cond.PdfPageNumIn, strComparisonOp_PdfPageNumIn);
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.PdfPageTop) == true)
{
string strComparisonOp_PdfPageTop = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Questions.PdfPageTop, objqa_Questions_Cond.PdfPageTop, strComparisonOp_PdfPageTop);
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.PdfZoom) == true)
{
string strComparisonOp_PdfZoom = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Questions.PdfZoom, objqa_Questions_Cond.PdfZoom, strComparisonOp_PdfZoom);
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.PaperId) == true)
{
string strComparisonOp_PaperId = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Questions.PaperId, objqa_Questions_Cond.PaperId, strComparisonOp_PaperId);
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.UserId) == true)
{
string strComparisonOp_UserId = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Questions.UserId, objqa_Questions_Cond.UserId, strComparisonOp_UserId);
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.QuestionsTypeId) == true)
{
string strComparisonOp_QuestionsTypeId = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.QuestionsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Questions.QuestionsTypeId, objqa_Questions_Cond.QuestionsTypeId, strComparisonOp_QuestionsTypeId);
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.DiscussCount) == true)
{
string strComparisonOp_DiscussCount = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.DiscussCount];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Questions.DiscussCount, objqa_Questions_Cond.DiscussCount, strComparisonOp_DiscussCount);
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.GroupDiscussCount) == true)
{
string strComparisonOp_GroupDiscussCount = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.GroupDiscussCount];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Questions.GroupDiscussCount, objqa_Questions_Cond.GroupDiscussCount, strComparisonOp_GroupDiscussCount);
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.RecommendAnswerCount) == true)
{
string strComparisonOp_RecommendAnswerCount = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.RecommendAnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Questions.RecommendAnswerCount, objqa_Questions_Cond.RecommendAnswerCount, strComparisonOp_RecommendAnswerCount);
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.CreateDate) == true)
{
string strComparisonOp_CreateDate = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Questions.CreateDate, objqa_Questions_Cond.CreateDate, strComparisonOp_CreateDate);
}
if (objqa_Questions_Cond.IsUpdated(conqa_Questions.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objqa_Questions_Cond.dicFldComparisonOp[conqa_Questions.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Questions.id_CurrEduCls, objqa_Questions_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsqa_QuestionsEN objqa_QuestionsEN)
{
 if (string.IsNullOrEmpty(objqa_QuestionsEN.QuestionsId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objqa_QuestionsEN.sf_UpdFldSetStr = objqa_QuestionsEN.getsf_UpdFldSetStr();
clsqa_QuestionsWApi.CheckPropertyNew(objqa_QuestionsEN); 
bool bolResult = clsqa_QuestionsWApi.UpdateRecord(objqa_QuestionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_QuestionsWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--qa_Questions(答疑提问表), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_QuestionsId(this clsqa_QuestionsEN objqa_QuestionsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objqa_QuestionsEN == null) return "";
if (objqa_QuestionsEN.QuestionsId == null || objqa_QuestionsEN.QuestionsId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionsId = '{0}'", objqa_QuestionsEN.QuestionsId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("QuestionsId !=  '{0}'", objqa_QuestionsEN.QuestionsId);
 sbCondition.AppendFormat(" and QuestionsId = '{0}'", objqa_QuestionsEN.QuestionsId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsqa_QuestionsEN objqa_QuestionsEN)
{
try
{
 if (string.IsNullOrEmpty(objqa_QuestionsEN.QuestionsId) == true || clsqa_QuestionsWApi.IsExist(objqa_QuestionsEN.QuestionsId) == true)
 {
     objqa_QuestionsEN.QuestionsId = clsqa_QuestionsWApi.GetMaxStrId();
 }
clsqa_QuestionsWApi.CheckPropertyNew(objqa_QuestionsEN); 
bool bolResult = clsqa_QuestionsWApi.AddNewRecord(objqa_QuestionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_QuestionsWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsqa_QuestionsEN objqa_QuestionsEN)
{
try
{
clsqa_QuestionsWApi.CheckPropertyNew(objqa_QuestionsEN); 
string strQuestionsId = clsqa_QuestionsWApi.AddNewRecordWithMaxId(objqa_QuestionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_QuestionsWApi.ReFreshCache();
return strQuestionsId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsqa_QuestionsEN objqa_QuestionsEN, string strWhereCond)
{
try
{
clsqa_QuestionsWApi.CheckPropertyNew(objqa_QuestionsEN); 
bool bolResult = clsqa_QuestionsWApi.UpdateWithCondition(objqa_QuestionsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_QuestionsWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 答疑提问表(qa_Questions)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsqa_QuestionsWApi
{
private static readonly string mstrApiControllerName = "qa_QuestionsApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsqa_QuestionsWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsqa_QuestionsEN objqa_QuestionsEN)
{
if (!Object.Equals(null, objqa_QuestionsEN.QuestionsId) && GetStrLen(objqa_QuestionsEN.QuestionsId) > 8)
{
 throw new Exception("字段[提问Id]的长度不能超过8!");
}
if (!Object.Equals(null, objqa_QuestionsEN.qa_PaperId) && GetStrLen(objqa_QuestionsEN.qa_PaperId) > 8)
{
 throw new Exception("字段[论文答疑Id]的长度不能超过8!");
}
if (!Object.Equals(null, objqa_QuestionsEN.QuestionsContent) && GetStrLen(objqa_QuestionsEN.QuestionsContent) > 1000)
{
 throw new Exception("字段[提问内容]的长度不能超过1000!");
}
if (!Object.Equals(null, objqa_QuestionsEN.PdfContent) && GetStrLen(objqa_QuestionsEN.PdfContent) > 2000)
{
 throw new Exception("字段[Pdf内容]的长度不能超过2000!");
}
if (!Object.Equals(null, objqa_QuestionsEN.UpdUser) && GetStrLen(objqa_QuestionsEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objqa_QuestionsEN.UpdDate) && GetStrLen(objqa_QuestionsEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objqa_QuestionsEN.Memo) && GetStrLen(objqa_QuestionsEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objqa_QuestionsEN.PdfDivLet) && GetStrLen(objqa_QuestionsEN.PdfDivLet) > 50)
{
 throw new Exception("字段[PdfDivLet]的长度不能超过50!");
}
if (!Object.Equals(null, objqa_QuestionsEN.PdfDivTop) && GetStrLen(objqa_QuestionsEN.PdfDivTop) > 50)
{
 throw new Exception("字段[PdfDivTop]的长度不能超过50!");
}
if (!Object.Equals(null, objqa_QuestionsEN.PdfPageNumIn) && GetStrLen(objqa_QuestionsEN.PdfPageNumIn) > 50)
{
 throw new Exception("字段[PdfPageNumIn]的长度不能超过50!");
}
if (!Object.Equals(null, objqa_QuestionsEN.PdfZoom) && GetStrLen(objqa_QuestionsEN.PdfZoom) > 50)
{
 throw new Exception("字段[PdfZoom]的长度不能超过50!");
}
if (!Object.Equals(null, objqa_QuestionsEN.PaperId) && GetStrLen(objqa_QuestionsEN.PaperId) > 8)
{
 throw new Exception("字段[论文Id]的长度不能超过8!");
}
if (!Object.Equals(null, objqa_QuestionsEN.UserId) && GetStrLen(objqa_QuestionsEN.UserId) > 20)
{
 throw new Exception("字段[用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objqa_QuestionsEN.QuestionsTypeId) && GetStrLen(objqa_QuestionsEN.QuestionsTypeId) > 2)
{
 throw new Exception("字段[问题类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objqa_QuestionsEN.CreateDate) && GetStrLen(objqa_QuestionsEN.CreateDate) > 20)
{
 throw new Exception("字段[建立日期]的长度不能超过20!");
}
if (!Object.Equals(null, objqa_QuestionsEN.id_CurrEduCls) && GetStrLen(objqa_QuestionsEN.id_CurrEduCls) > 8)
{
 throw new Exception("字段[当前教学班流水号]的长度不能超过8!");
}
 objqa_QuestionsEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQuestionsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsqa_QuestionsEN GetObjByQuestionsId(string strQuestionsId)
{
string strAction = "GetObjByQuestionsId";
string strErrMsg = string.Empty;
string strResult = "";
clsqa_QuestionsEN objqa_QuestionsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionsId"] = strQuestionsId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objqa_QuestionsEN = JsonConvert.DeserializeObject<clsqa_QuestionsEN>((string)jobjReturn["ReturnObj"]);
return objqa_QuestionsEN;
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
 /// <param name = "strQuestionsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsqa_QuestionsEN GetObjByQuestionsId_WA_Cache(string strQuestionsId)
{
string strAction = "GetObjByQuestionsId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsqa_QuestionsEN objqa_QuestionsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionsId"] = strQuestionsId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objqa_QuestionsEN = JsonConvert.DeserializeObject<clsqa_QuestionsEN>((string)jobjReturn["ReturnObj"]);
return objqa_QuestionsEN;
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
public static clsqa_QuestionsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsqa_QuestionsEN objqa_QuestionsEN = null;
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
objqa_QuestionsEN = JsonConvert.DeserializeObject<clsqa_QuestionsEN>((string)jobjReturn["ReturnObj"]);
return objqa_QuestionsEN;
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
 /// <param name = "strQuestionsId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsqa_QuestionsEN GetObjByQuestionsId_Cache(string strQuestionsId)
{
if (string.IsNullOrEmpty(strQuestionsId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsqa_QuestionsEN._CurrTabName_S);
List<clsqa_QuestionsEN> arrqa_QuestionsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsqa_QuestionsEN> arrqa_QuestionsObjLst_Sel =
from objqa_QuestionsEN in arrqa_QuestionsObjLst_Cache
where objqa_QuestionsEN.QuestionsId == strQuestionsId
select objqa_QuestionsEN;
if (arrqa_QuestionsObjLst_Sel.Count() == 0)
{
   clsqa_QuestionsEN obj = clsqa_QuestionsWApi.GetObjByQuestionsId(strQuestionsId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrqa_QuestionsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsqa_QuestionsEN> GetObjLst(string strWhereCond)
{
 List<clsqa_QuestionsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_QuestionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_QuestionsEN> GetObjLstByQuestionsIdLst(List<string> arrQuestionsId)
{
 List<clsqa_QuestionsEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionsIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionsId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_QuestionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strQuestionsId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsqa_QuestionsEN> GetObjLstByQuestionsIdLst_Cache(List<string> arrQuestionsId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsqa_QuestionsEN._CurrTabName_S);
List<clsqa_QuestionsEN> arrqa_QuestionsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsqa_QuestionsEN> arrqa_QuestionsObjLst_Sel =
from objqa_QuestionsEN in arrqa_QuestionsObjLst_Cache
where arrQuestionsId.Contains(objqa_QuestionsEN.QuestionsId)
select objqa_QuestionsEN;
return arrqa_QuestionsObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsqa_QuestionsEN> GetObjLstByQuestionsIdLst_WA_Cache(List<string> arrQuestionsId)
{
 List<clsqa_QuestionsEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionsIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionsId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_QuestionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_QuestionsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsqa_QuestionsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_QuestionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_QuestionsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsqa_QuestionsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_QuestionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_QuestionsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsqa_QuestionsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_QuestionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_QuestionsEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsqa_QuestionsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_QuestionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strQuestionsId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsqa_QuestionsEN objqa_QuestionsEN = clsqa_QuestionsWApi.GetObjByQuestionsId(strQuestionsId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strQuestionsId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsqa_QuestionsWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int Delqa_Questionss(List<string> arrQuestionsId)
{
string strAction = "Delqa_Questionss";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionsId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsqa_QuestionsWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int Delqa_QuestionssByCond(string strWhereCond)
{
string strAction = "Delqa_QuestionssByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsqa_QuestionsEN objqa_QuestionsEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsqa_QuestionsEN>(objqa_QuestionsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_QuestionsWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clsqa_QuestionsEN objqa_QuestionsEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsqa_QuestionsEN>(objqa_QuestionsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_QuestionsWApi.ReFreshCache();
var strQuestionsId = (string)jobjReturn["ReturnStr"];
return strQuestionsId;
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsqa_QuestionsEN objqa_QuestionsEN)
{
if (string.IsNullOrEmpty(objqa_QuestionsEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objqa_QuestionsEN.QuestionsId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsqa_QuestionsEN>(objqa_QuestionsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objqa_QuestionsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsqa_QuestionsEN objqa_QuestionsEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objqa_QuestionsEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objqa_QuestionsEN.QuestionsId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objqa_QuestionsEN.QuestionsId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsqa_QuestionsEN>(objqa_QuestionsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
public static bool IsExist(string strQuestionsId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionsId"] = strQuestionsId
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objqa_QuestionsENS">源对象</param>
 /// <param name = "objqa_QuestionsENT">目标对象</param>
 public static void CopyTo(clsqa_QuestionsEN objqa_QuestionsENS, clsqa_QuestionsEN objqa_QuestionsENT)
{
try
{
objqa_QuestionsENT.QuestionsId = objqa_QuestionsENS.QuestionsId; //提问Id
objqa_QuestionsENT.qa_PaperId = objqa_QuestionsENS.qa_PaperId; //论文答疑Id
objqa_QuestionsENT.QuestionsContent = objqa_QuestionsENS.QuestionsContent; //提问内容
objqa_QuestionsENT.PdfContent = objqa_QuestionsENS.PdfContent; //Pdf内容
objqa_QuestionsENT.PdfPageNum = objqa_QuestionsENS.PdfPageNum; //Pdf页码
objqa_QuestionsENT.IsDelete = objqa_QuestionsENS.IsDelete; //是否删除
objqa_QuestionsENT.IsPublic = objqa_QuestionsENS.IsPublic; //是否公开
objqa_QuestionsENT.IsEnd = objqa_QuestionsENS.IsEnd; //是否结束
objqa_QuestionsENT.VoteCount = objqa_QuestionsENS.VoteCount; //点赞计数
objqa_QuestionsENT.AnswerCount = objqa_QuestionsENS.AnswerCount; //回答计数
objqa_QuestionsENT.OrderNum = objqa_QuestionsENS.OrderNum; //序号
objqa_QuestionsENT.UpdUser = objqa_QuestionsENS.UpdUser; //修改人
objqa_QuestionsENT.UpdDate = objqa_QuestionsENS.UpdDate; //修改日期
objqa_QuestionsENT.Memo = objqa_QuestionsENS.Memo; //备注
objqa_QuestionsENT.PdfDivLet = objqa_QuestionsENS.PdfDivLet; //PdfDivLet
objqa_QuestionsENT.PdfDivTop = objqa_QuestionsENS.PdfDivTop; //PdfDivTop
objqa_QuestionsENT.PdfPageNumIn = objqa_QuestionsENS.PdfPageNumIn; //PdfPageNumIn
objqa_QuestionsENT.PdfPageTop = objqa_QuestionsENS.PdfPageTop; //pdf页面顶部位置
objqa_QuestionsENT.PdfZoom = objqa_QuestionsENS.PdfZoom; //PdfZoom
objqa_QuestionsENT.PaperId = objqa_QuestionsENS.PaperId; //论文Id
objqa_QuestionsENT.UserId = objqa_QuestionsENS.UserId; //用户ID
objqa_QuestionsENT.QuestionsTypeId = objqa_QuestionsENS.QuestionsTypeId; //问题类型Id
objqa_QuestionsENT.DiscussCount = objqa_QuestionsENS.DiscussCount; //DiscussCount
objqa_QuestionsENT.GroupDiscussCount = objqa_QuestionsENS.GroupDiscussCount; //GroupDiscussCount
objqa_QuestionsENT.RecommendAnswerCount = objqa_QuestionsENS.RecommendAnswerCount; //RecommendAnswerCount
objqa_QuestionsENT.CreateDate = objqa_QuestionsENS.CreateDate; //建立日期
objqa_QuestionsENT.id_CurrEduCls = objqa_QuestionsENS.id_CurrEduCls; //当前教学班流水号
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
public static DataTable ToDataTable(List<clsqa_QuestionsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsqa_QuestionsEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsqa_QuestionsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsqa_QuestionsEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsqa_QuestionsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsqa_QuestionsEN.AttributeName)
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
if (clsqa_QuestionsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_QuestionsWApi没有刷新缓存机制(clsqa_QuestionsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionsId");
//if (arrqa_QuestionsObjLst_Cache == null)
//{
//arrqa_QuestionsObjLst_Cache = await clsqa_QuestionsWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsqa_QuestionsEN._CurrTabName_S);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsqa_QuestionsWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsqa_QuestionsEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsqa_QuestionsWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsqa_QuestionsEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsqa_QuestionsEN._CurrTabName_S);
List<clsqa_QuestionsEN> arrqa_QuestionsObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrqa_QuestionsObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsqa_QuestionsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conqa_Questions.QuestionsId, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Questions.qa_PaperId, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Questions.QuestionsContent, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Questions.PdfContent, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Questions.PdfPageNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conqa_Questions.IsDelete, Type.GetType("System.Boolean"));
objDT.Columns.Add(conqa_Questions.IsPublic, Type.GetType("System.Boolean"));
objDT.Columns.Add(conqa_Questions.IsEnd, Type.GetType("System.Boolean"));
objDT.Columns.Add(conqa_Questions.VoteCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conqa_Questions.AnswerCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conqa_Questions.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conqa_Questions.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Questions.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Questions.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Questions.PdfDivLet, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Questions.PdfDivTop, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Questions.PdfPageNumIn, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Questions.PdfPageTop, Type.GetType("System.Int32"));
objDT.Columns.Add(conqa_Questions.PdfZoom, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Questions.PaperId, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Questions.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Questions.QuestionsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Questions.DiscussCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conqa_Questions.GroupDiscussCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conqa_Questions.RecommendAnswerCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conqa_Questions.CreateDate, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Questions.id_CurrEduCls, Type.GetType("System.String"));
foreach (clsqa_QuestionsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conqa_Questions.QuestionsId] = objInFor[conqa_Questions.QuestionsId];
objDR[conqa_Questions.qa_PaperId] = objInFor[conqa_Questions.qa_PaperId];
objDR[conqa_Questions.QuestionsContent] = objInFor[conqa_Questions.QuestionsContent];
objDR[conqa_Questions.PdfContent] = objInFor[conqa_Questions.PdfContent];
objDR[conqa_Questions.PdfPageNum] = objInFor[conqa_Questions.PdfPageNum];
objDR[conqa_Questions.IsDelete] = objInFor[conqa_Questions.IsDelete];
objDR[conqa_Questions.IsPublic] = objInFor[conqa_Questions.IsPublic];
objDR[conqa_Questions.IsEnd] = objInFor[conqa_Questions.IsEnd];
objDR[conqa_Questions.VoteCount] = objInFor[conqa_Questions.VoteCount];
objDR[conqa_Questions.AnswerCount] = objInFor[conqa_Questions.AnswerCount];
objDR[conqa_Questions.OrderNum] = objInFor[conqa_Questions.OrderNum];
objDR[conqa_Questions.UpdUser] = objInFor[conqa_Questions.UpdUser];
objDR[conqa_Questions.UpdDate] = objInFor[conqa_Questions.UpdDate];
objDR[conqa_Questions.Memo] = objInFor[conqa_Questions.Memo];
objDR[conqa_Questions.PdfDivLet] = objInFor[conqa_Questions.PdfDivLet];
objDR[conqa_Questions.PdfDivTop] = objInFor[conqa_Questions.PdfDivTop];
objDR[conqa_Questions.PdfPageNumIn] = objInFor[conqa_Questions.PdfPageNumIn];
objDR[conqa_Questions.PdfPageTop] = objInFor[conqa_Questions.PdfPageTop];
objDR[conqa_Questions.PdfZoom] = objInFor[conqa_Questions.PdfZoom];
objDR[conqa_Questions.PaperId] = objInFor[conqa_Questions.PaperId];
objDR[conqa_Questions.UserId] = objInFor[conqa_Questions.UserId];
objDR[conqa_Questions.QuestionsTypeId] = objInFor[conqa_Questions.QuestionsTypeId];
objDR[conqa_Questions.DiscussCount] = objInFor[conqa_Questions.DiscussCount];
objDR[conqa_Questions.GroupDiscussCount] = objInFor[conqa_Questions.GroupDiscussCount];
objDR[conqa_Questions.RecommendAnswerCount] = objInFor[conqa_Questions.RecommendAnswerCount];
objDR[conqa_Questions.CreateDate] = objInFor[conqa_Questions.CreateDate];
objDR[conqa_Questions.id_CurrEduCls] = objInFor[conqa_Questions.id_CurrEduCls];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 答疑提问表(qa_Questions)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4qa_Questions : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_QuestionsWApi.ReFreshThisCache();
clsvqa_QuestionsWApi.ReFreshThisCache();
}
}

}