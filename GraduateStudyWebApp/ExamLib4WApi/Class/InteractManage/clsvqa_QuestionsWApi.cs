
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvqa_QuestionsWApi
 表名:vqa_Questions(01120636)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:23
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
public static class clsvqa_QuestionsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetQuestionsId(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strQuestionsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionsId, 8, convqa_Questions.QuestionsId);
clsCheckSql.CheckFieldForeignKey(strQuestionsId, 8, convqa_Questions.QuestionsId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetPaperId(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperId, 8, convqa_Questions.PaperId);
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convqa_Questions.PaperId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN Setqa_PaperId(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strqa_PaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strqa_PaperId, convqa_Questions.qa_PaperId);
clsCheckSql.CheckFieldLen(strqa_PaperId, 8, convqa_Questions.qa_PaperId);
clsCheckSql.CheckFieldForeignKey(strqa_PaperId, 8, convqa_Questions.qa_PaperId);
objvqa_QuestionsEN.qa_PaperId = strqa_PaperId; //论文答疑Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.qa_PaperId) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.qa_PaperId, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.qa_PaperId] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetQuestionsContent(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strQuestionsContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionsContent, 1000, convqa_Questions.QuestionsContent);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetPdfContent(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strPdfContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convqa_Questions.PdfContent);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetPdfPageNum(this clsvqa_QuestionsEN objvqa_QuestionsEN, int intPdfPageNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetVoteCount(this clsvqa_QuestionsEN objvqa_QuestionsEN, int intVoteCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetAnswerCount(this clsvqa_QuestionsEN objvqa_QuestionsEN, int intAnswerCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetOrderNum(this clsvqa_QuestionsEN objvqa_QuestionsEN, int intOrderNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetUpdUser(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convqa_Questions.UpdUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetUpdDate(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convqa_Questions.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetMemo(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convqa_Questions.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetUserName(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convqa_Questions.UserName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN Setid_CurrEduCls(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convqa_Questions.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convqa_Questions.id_CurrEduCls);
objvqa_QuestionsEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_QuestionsEN.dicFldComparisonOp.ContainsKey(convqa_Questions.id_CurrEduCls) == false)
{
objvqa_QuestionsEN.dicFldComparisonOp.Add(convqa_Questions.id_CurrEduCls, strComparisonOp);
}
else
{
objvqa_QuestionsEN.dicFldComparisonOp[convqa_Questions.id_CurrEduCls] = strComparisonOp;
}
}
return objvqa_QuestionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetPaperTitle(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strPaperTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convqa_Questions.PaperTitle);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetPdfDivLet(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strPdfDivLet, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, convqa_Questions.PdfDivLet);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetPdfDivTop(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strPdfDivTop, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, convqa_Questions.PdfDivTop);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetPdfPageNumIn(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strPdfPageNumIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, convqa_Questions.PdfPageNumIn);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetPdfPageTop(this clsvqa_QuestionsEN objvqa_QuestionsEN, int intPdfPageTop, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetPdfZoom(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strPdfZoom, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, convqa_Questions.PdfZoom);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetUserId(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convqa_Questions.UserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetQuestionsTypeId(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strQuestionsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionsTypeId, 2, convqa_Questions.QuestionsTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionsTypeId, 2, convqa_Questions.QuestionsTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetQuestionsTypeName(this clsvqa_QuestionsEN objvqa_QuestionsEN, string strQuestionsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionsTypeName, 50, convqa_Questions.QuestionsTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetDiscussCount(this clsvqa_QuestionsEN objvqa_QuestionsEN, int intDiscussCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetGroupDiscussCount(this clsvqa_QuestionsEN objvqa_QuestionsEN, int intGroupDiscussCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_QuestionsEN SetRecommendAnswerCount(this clsvqa_QuestionsEN objvqa_QuestionsEN, int intRecommendAnswerCount, string strComparisonOp="")
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvqa_QuestionsEN objvqa_Questions_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.QuestionsId) == true)
{
string strComparisonOp_QuestionsId = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.QuestionsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.QuestionsId, objvqa_Questions_Cond.QuestionsId, strComparisonOp_QuestionsId);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.PaperId) == true)
{
string strComparisonOp_PaperId = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.PaperId, objvqa_Questions_Cond.PaperId, strComparisonOp_PaperId);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.IsSubmit) == true)
{
if (objvqa_Questions_Cond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Questions.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Questions.IsSubmit);
}
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.qa_PaperId) == true)
{
string strComparisonOp_qa_PaperId = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.qa_PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.qa_PaperId, objvqa_Questions_Cond.qa_PaperId, strComparisonOp_qa_PaperId);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.QuestionsContent) == true)
{
string strComparisonOp_QuestionsContent = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.QuestionsContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.QuestionsContent, objvqa_Questions_Cond.QuestionsContent, strComparisonOp_QuestionsContent);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.PdfContent) == true)
{
string strComparisonOp_PdfContent = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.PdfContent, objvqa_Questions_Cond.PdfContent, strComparisonOp_PdfContent);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.PdfPageNum) == true)
{
string strComparisonOp_PdfPageNum = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Questions.PdfPageNum, objvqa_Questions_Cond.PdfPageNum, strComparisonOp_PdfPageNum);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.IsDelete) == true)
{
if (objvqa_Questions_Cond.IsDelete == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Questions.IsDelete);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Questions.IsDelete);
}
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.IsPublic) == true)
{
if (objvqa_Questions_Cond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Questions.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Questions.IsPublic);
}
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.IsEnd) == true)
{
if (objvqa_Questions_Cond.IsEnd == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Questions.IsEnd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Questions.IsEnd);
}
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.VoteCount) == true)
{
string strComparisonOp_VoteCount = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Questions.VoteCount, objvqa_Questions_Cond.VoteCount, strComparisonOp_VoteCount);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.AnswerCount) == true)
{
string strComparisonOp_AnswerCount = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.AnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Questions.AnswerCount, objvqa_Questions_Cond.AnswerCount, strComparisonOp_AnswerCount);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Questions.OrderNum, objvqa_Questions_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.UpdUser, objvqa_Questions_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.UpdDate, objvqa_Questions_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.Memo) == true)
{
string strComparisonOp_Memo = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.Memo, objvqa_Questions_Cond.Memo, strComparisonOp_Memo);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.UserName) == true)
{
string strComparisonOp_UserName = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.UserName, objvqa_Questions_Cond.UserName, strComparisonOp_UserName);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.id_CurrEduCls, objvqa_Questions_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.PaperTitle) == true)
{
string strComparisonOp_PaperTitle = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.PaperTitle, objvqa_Questions_Cond.PaperTitle, strComparisonOp_PaperTitle);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.PdfDivLet) == true)
{
string strComparisonOp_PdfDivLet = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.PdfDivLet, objvqa_Questions_Cond.PdfDivLet, strComparisonOp_PdfDivLet);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.PdfDivTop) == true)
{
string strComparisonOp_PdfDivTop = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.PdfDivTop, objvqa_Questions_Cond.PdfDivTop, strComparisonOp_PdfDivTop);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.PdfPageNumIn) == true)
{
string strComparisonOp_PdfPageNumIn = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.PdfPageNumIn, objvqa_Questions_Cond.PdfPageNumIn, strComparisonOp_PdfPageNumIn);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.PdfPageTop) == true)
{
string strComparisonOp_PdfPageTop = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Questions.PdfPageTop, objvqa_Questions_Cond.PdfPageTop, strComparisonOp_PdfPageTop);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.PdfZoom) == true)
{
string strComparisonOp_PdfZoom = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.PdfZoom, objvqa_Questions_Cond.PdfZoom, strComparisonOp_PdfZoom);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.UserId) == true)
{
string strComparisonOp_UserId = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.UserId, objvqa_Questions_Cond.UserId, strComparisonOp_UserId);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.QuestionsTypeId) == true)
{
string strComparisonOp_QuestionsTypeId = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.QuestionsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.QuestionsTypeId, objvqa_Questions_Cond.QuestionsTypeId, strComparisonOp_QuestionsTypeId);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.QuestionsTypeName) == true)
{
string strComparisonOp_QuestionsTypeName = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.QuestionsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Questions.QuestionsTypeName, objvqa_Questions_Cond.QuestionsTypeName, strComparisonOp_QuestionsTypeName);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.DiscussCount) == true)
{
string strComparisonOp_DiscussCount = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.DiscussCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Questions.DiscussCount, objvqa_Questions_Cond.DiscussCount, strComparisonOp_DiscussCount);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.GroupDiscussCount) == true)
{
string strComparisonOp_GroupDiscussCount = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.GroupDiscussCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Questions.GroupDiscussCount, objvqa_Questions_Cond.GroupDiscussCount, strComparisonOp_GroupDiscussCount);
}
if (objvqa_Questions_Cond.IsUpdated(convqa_Questions.RecommendAnswerCount) == true)
{
string strComparisonOp_RecommendAnswerCount = objvqa_Questions_Cond.dicFldComparisonOp[convqa_Questions.RecommendAnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Questions.RecommendAnswerCount, objvqa_Questions_Cond.RecommendAnswerCount, strComparisonOp_RecommendAnswerCount);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vqa_Questions(v答疑提问), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvqa_QuestionsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_QuestionsId(this clsvqa_QuestionsEN objvqa_QuestionsEN)
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
 /// v答疑提问(vqa_Questions)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvqa_QuestionsWApi
{
private static readonly string mstrApiControllerName = "vqa_QuestionsApi";

 public clsvqa_QuestionsWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQuestionsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvqa_QuestionsEN GetObjByQuestionsId(string strQuestionsId)
{
string strAction = "GetObjByQuestionsId";
string strErrMsg = string.Empty;
string strResult = "";
clsvqa_QuestionsEN objvqa_QuestionsEN = null;
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
objvqa_QuestionsEN = JsonConvert.DeserializeObject<clsvqa_QuestionsEN>((string)jobjReturn["ReturnObj"]);
return objvqa_QuestionsEN;
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
public static clsvqa_QuestionsEN GetObjByQuestionsId_WA_Cache(string strQuestionsId)
{
string strAction = "GetObjByQuestionsId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvqa_QuestionsEN objvqa_QuestionsEN = null;
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
objvqa_QuestionsEN = JsonConvert.DeserializeObject<clsvqa_QuestionsEN>((string)jobjReturn["ReturnObj"]);
return objvqa_QuestionsEN;
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
public static clsvqa_QuestionsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvqa_QuestionsEN objvqa_QuestionsEN = null;
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
objvqa_QuestionsEN = JsonConvert.DeserializeObject<clsvqa_QuestionsEN>((string)jobjReturn["ReturnObj"]);
return objvqa_QuestionsEN;
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
public static clsvqa_QuestionsEN GetObjByQuestionsId_Cache(string strQuestionsId)
{
if (string.IsNullOrEmpty(strQuestionsId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvqa_QuestionsEN._CurrTabName_S);
List<clsvqa_QuestionsEN> arrvqa_QuestionsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvqa_QuestionsEN> arrvqa_QuestionsObjLst_Sel =
from objvqa_QuestionsEN in arrvqa_QuestionsObjLst_Cache
where objvqa_QuestionsEN.QuestionsId == strQuestionsId
select objvqa_QuestionsEN;
if (arrvqa_QuestionsObjLst_Sel.Count() == 0)
{
   clsvqa_QuestionsEN obj = clsvqa_QuestionsWApi.GetObjByQuestionsId(strQuestionsId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvqa_QuestionsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_QuestionsEN> GetObjLst(string strWhereCond)
{
 List<clsvqa_QuestionsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_QuestionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvqa_QuestionsEN> GetObjLstByQuestionsIdLst(List<string> arrQuestionsId)
{
 List<clsvqa_QuestionsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_QuestionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvqa_QuestionsEN> GetObjLstByQuestionsIdLst_Cache(List<string> arrQuestionsId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvqa_QuestionsEN._CurrTabName_S);
List<clsvqa_QuestionsEN> arrvqa_QuestionsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvqa_QuestionsEN> arrvqa_QuestionsObjLst_Sel =
from objvqa_QuestionsEN in arrvqa_QuestionsObjLst_Cache
where arrQuestionsId.Contains(objvqa_QuestionsEN.QuestionsId)
select objvqa_QuestionsEN;
return arrvqa_QuestionsObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_QuestionsEN> GetObjLstByQuestionsIdLst_WA_Cache(List<string> arrQuestionsId)
{
 List<clsvqa_QuestionsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_QuestionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvqa_QuestionsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvqa_QuestionsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_QuestionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvqa_QuestionsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvqa_QuestionsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_QuestionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvqa_QuestionsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvqa_QuestionsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_QuestionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvqa_QuestionsEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvqa_QuestionsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_QuestionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
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
objvqa_QuestionsENT.qa_PaperId = objvqa_QuestionsENS.qa_PaperId; //论文答疑Id
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
objvqa_QuestionsENT.id_CurrEduCls = objvqa_QuestionsENS.id_CurrEduCls; //当前教学班流水号
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
public static DataTable ToDataTable(List<clsvqa_QuestionsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvqa_QuestionsEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvqa_QuestionsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvqa_QuestionsEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvqa_QuestionsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvqa_QuestionsEN.AttributeName)
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
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperWApi没有刷新缓存机制(clsPaperWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsqa_QuestionsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_QuestionsWApi没有刷新缓存机制(clsqa_QuestionsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsqa_QuestionsTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_QuestionsTypeWApi没有刷新缓存机制(clsqa_QuestionsTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionsId");
//if (arrvqa_QuestionsObjLst_Cache == null)
//{
//arrvqa_QuestionsObjLst_Cache = await clsvqa_QuestionsWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvqa_QuestionsEN._CurrTabName_S);
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
public static List<clsvqa_QuestionsEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvqa_QuestionsEN._CurrTabName_S);
List<clsvqa_QuestionsEN> arrvqa_QuestionsObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvqa_QuestionsObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvqa_QuestionsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convqa_Questions.QuestionsId, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Questions.PaperId, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Questions.IsSubmit, Type.GetType("System.Boolean"));
objDT.Columns.Add(convqa_Questions.qa_PaperId, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Questions.QuestionsContent, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Questions.PdfContent, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Questions.PdfPageNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convqa_Questions.IsDelete, Type.GetType("System.Boolean"));
objDT.Columns.Add(convqa_Questions.IsPublic, Type.GetType("System.Boolean"));
objDT.Columns.Add(convqa_Questions.IsEnd, Type.GetType("System.Boolean"));
objDT.Columns.Add(convqa_Questions.VoteCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convqa_Questions.AnswerCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convqa_Questions.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convqa_Questions.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Questions.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Questions.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Questions.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Questions.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Questions.PaperTitle, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Questions.PdfDivLet, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Questions.PdfDivTop, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Questions.PdfPageNumIn, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Questions.PdfPageTop, Type.GetType("System.Int32"));
objDT.Columns.Add(convqa_Questions.PdfZoom, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Questions.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Questions.QuestionsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Questions.QuestionsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Questions.DiscussCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convqa_Questions.GroupDiscussCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convqa_Questions.RecommendAnswerCount, Type.GetType("System.Int32"));
foreach (clsvqa_QuestionsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convqa_Questions.QuestionsId] = objInFor[convqa_Questions.QuestionsId];
objDR[convqa_Questions.PaperId] = objInFor[convqa_Questions.PaperId];
objDR[convqa_Questions.IsSubmit] = objInFor[convqa_Questions.IsSubmit];
objDR[convqa_Questions.qa_PaperId] = objInFor[convqa_Questions.qa_PaperId];
objDR[convqa_Questions.QuestionsContent] = objInFor[convqa_Questions.QuestionsContent];
objDR[convqa_Questions.PdfContent] = objInFor[convqa_Questions.PdfContent];
objDR[convqa_Questions.PdfPageNum] = objInFor[convqa_Questions.PdfPageNum];
objDR[convqa_Questions.IsDelete] = objInFor[convqa_Questions.IsDelete];
objDR[convqa_Questions.IsPublic] = objInFor[convqa_Questions.IsPublic];
objDR[convqa_Questions.IsEnd] = objInFor[convqa_Questions.IsEnd];
objDR[convqa_Questions.VoteCount] = objInFor[convqa_Questions.VoteCount];
objDR[convqa_Questions.AnswerCount] = objInFor[convqa_Questions.AnswerCount];
objDR[convqa_Questions.OrderNum] = objInFor[convqa_Questions.OrderNum];
objDR[convqa_Questions.UpdUser] = objInFor[convqa_Questions.UpdUser];
objDR[convqa_Questions.UpdDate] = objInFor[convqa_Questions.UpdDate];
objDR[convqa_Questions.Memo] = objInFor[convqa_Questions.Memo];
objDR[convqa_Questions.UserName] = objInFor[convqa_Questions.UserName];
objDR[convqa_Questions.id_CurrEduCls] = objInFor[convqa_Questions.id_CurrEduCls];
objDR[convqa_Questions.PaperTitle] = objInFor[convqa_Questions.PaperTitle];
objDR[convqa_Questions.PdfDivLet] = objInFor[convqa_Questions.PdfDivLet];
objDR[convqa_Questions.PdfDivTop] = objInFor[convqa_Questions.PdfDivTop];
objDR[convqa_Questions.PdfPageNumIn] = objInFor[convqa_Questions.PdfPageNumIn];
objDR[convqa_Questions.PdfPageTop] = objInFor[convqa_Questions.PdfPageTop];
objDR[convqa_Questions.PdfZoom] = objInFor[convqa_Questions.PdfZoom];
objDR[convqa_Questions.UserId] = objInFor[convqa_Questions.UserId];
objDR[convqa_Questions.QuestionsTypeId] = objInFor[convqa_Questions.QuestionsTypeId];
objDR[convqa_Questions.QuestionsTypeName] = objInFor[convqa_Questions.QuestionsTypeName];
objDR[convqa_Questions.DiscussCount] = objInFor[convqa_Questions.DiscussCount];
objDR[convqa_Questions.GroupDiscussCount] = objInFor[convqa_Questions.GroupDiscussCount];
objDR[convqa_Questions.RecommendAnswerCount] = objInFor[convqa_Questions.RecommendAnswerCount];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}