
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvqa_PushWApi
 表名:vqa_Push(01120634)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:46:44
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
public static class clsvqa_PushWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN SetPushId(this clsvqa_PushEN objvqa_PushEN, long lngPushId, string strComparisonOp="")
	{
objvqa_PushEN.PushId = lngPushId; //推送d
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.PushId) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.PushId, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.PushId] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN SetQuestionsId(this clsvqa_PushEN objvqa_PushEN, string strQuestionsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionsId, convqa_Push.QuestionsId);
clsCheckSql.CheckFieldLen(strQuestionsId, 8, convqa_Push.QuestionsId);
clsCheckSql.CheckFieldForeignKey(strQuestionsId, 8, convqa_Push.QuestionsId);
objvqa_PushEN.QuestionsId = strQuestionsId; //提问Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.QuestionsId) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.QuestionsId, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.QuestionsId] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN SetQuestionsContent(this clsvqa_PushEN objvqa_PushEN, string strQuestionsContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionsContent, 1000, convqa_Push.QuestionsContent);
objvqa_PushEN.QuestionsContent = strQuestionsContent; //提问内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.QuestionsContent) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.QuestionsContent, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.QuestionsContent] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN SetReceiveUser(this clsvqa_PushEN objvqa_PushEN, string strReceiveUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReceiveUser, 20, convqa_Push.ReceiveUser);
objvqa_PushEN.ReceiveUser = strReceiveUser; //接收用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.ReceiveUser) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.ReceiveUser, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.ReceiveUser] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN SetReceiveDate(this clsvqa_PushEN objvqa_PushEN, string strReceiveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReceiveDate, 20, convqa_Push.ReceiveDate);
objvqa_PushEN.ReceiveDate = strReceiveDate; //接收日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.ReceiveDate) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.ReceiveDate, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.ReceiveDate] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN SetUserName(this clsvqa_PushEN objvqa_PushEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convqa_Push.UserName);
objvqa_PushEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.UserName) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.UserName, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.UserName] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN SetIsReceive(this clsvqa_PushEN objvqa_PushEN, bool bolIsReceive, string strComparisonOp="")
	{
objvqa_PushEN.IsReceive = bolIsReceive; //是否接收
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.IsReceive) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.IsReceive, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.IsReceive] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN SetUpdDate(this clsvqa_PushEN objvqa_PushEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convqa_Push.UpdDate);
objvqa_PushEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.UpdDate) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.UpdDate, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.UpdDate] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN SetAnswerCount(this clsvqa_PushEN objvqa_PushEN, int intAnswerCount, string strComparisonOp="")
	{
objvqa_PushEN.AnswerCount = intAnswerCount; //回答计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.AnswerCount) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.AnswerCount, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.AnswerCount] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN SetIsEnd(this clsvqa_PushEN objvqa_PushEN, bool bolIsEnd, string strComparisonOp="")
	{
objvqa_PushEN.IsEnd = bolIsEnd; //是否结束
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.IsEnd) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.IsEnd, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.IsEnd] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN SetVoteCount(this clsvqa_PushEN objvqa_PushEN, int intVoteCount, string strComparisonOp="")
	{
objvqa_PushEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.VoteCount) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.VoteCount, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.VoteCount] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN SetMemo(this clsvqa_PushEN objvqa_PushEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convqa_Push.Memo);
objvqa_PushEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.Memo) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.Memo, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.Memo] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN Setid_CurrEduCls(this clsvqa_PushEN objvqa_PushEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convqa_Push.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convqa_Push.id_CurrEduCls);
objvqa_PushEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.id_CurrEduCls) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.id_CurrEduCls, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.id_CurrEduCls] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN SetPdfContent(this clsvqa_PushEN objvqa_PushEN, string strPdfContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convqa_Push.PdfContent);
objvqa_PushEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.PdfContent) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.PdfContent, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.PdfContent] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN Setqa_PaperId(this clsvqa_PushEN objvqa_PushEN, string strqa_PaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strqa_PaperId, 8, convqa_Push.qa_PaperId);
clsCheckSql.CheckFieldForeignKey(strqa_PaperId, 8, convqa_Push.qa_PaperId);
objvqa_PushEN.qa_PaperId = strqa_PaperId; //论文答疑Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.qa_PaperId) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.qa_PaperId, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.qa_PaperId] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN SetIsPublic(this clsvqa_PushEN objvqa_PushEN, bool bolIsPublic, string strComparisonOp="")
	{
objvqa_PushEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.IsPublic) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.IsPublic, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.IsPublic] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN SetPaperId(this clsvqa_PushEN objvqa_PushEN, string strPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperId, 8, convqa_Push.PaperId);
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convqa_Push.PaperId);
objvqa_PushEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.PaperId) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.PaperId, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.PaperId] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN SetPaperTitle(this clsvqa_PushEN objvqa_PushEN, string strPaperTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convqa_Push.PaperTitle);
objvqa_PushEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.PaperTitle) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.PaperTitle, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.PaperTitle] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN SetPdfPageNum(this clsvqa_PushEN objvqa_PushEN, int intPdfPageNum, string strComparisonOp="")
	{
objvqa_PushEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.PdfPageNum) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.PdfPageNum, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.PdfPageNum] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN SetIsReply(this clsvqa_PushEN objvqa_PushEN, bool bolIsReply, string strComparisonOp="")
	{
objvqa_PushEN.IsReply = bolIsReply; //是否回复
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.IsReply) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.IsReply, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.IsReply] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN SetIsRequestReply(this clsvqa_PushEN objvqa_PushEN, bool bolIsRequestReply, string strComparisonOp="")
	{
objvqa_PushEN.IsRequestReply = bolIsRequestReply; //是否要求回复
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.IsRequestReply) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.IsRequestReply, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.IsRequestReply] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN SetReplyDate(this clsvqa_PushEN objvqa_PushEN, string strReplyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReplyDate, 20, convqa_Push.ReplyDate);
objvqa_PushEN.ReplyDate = strReplyDate; //回复日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.ReplyDate) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.ReplyDate, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.ReplyDate] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN SetQuestionsTypeId(this clsvqa_PushEN objvqa_PushEN, string strQuestionsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionsTypeId, 2, convqa_Push.QuestionsTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionsTypeId, 2, convqa_Push.QuestionsTypeId);
objvqa_PushEN.QuestionsTypeId = strQuestionsTypeId; //问题类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.QuestionsTypeId) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.QuestionsTypeId, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.QuestionsTypeId] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PushEN SetQuestionsTypeName(this clsvqa_PushEN objvqa_PushEN, string strQuestionsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionsTypeName, 50, convqa_Push.QuestionsTypeName);
objvqa_PushEN.QuestionsTypeName = strQuestionsTypeName; //问题类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.QuestionsTypeName) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.QuestionsTypeName, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.QuestionsTypeName] = strComparisonOp;
}
}
return objvqa_PushEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvqa_PushEN objvqa_Push_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvqa_Push_Cond.IsUpdated(convqa_Push.PushId) == true)
{
string strComparisonOp_PushId = objvqa_Push_Cond.dicFldComparisonOp[convqa_Push.PushId];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Push.PushId, objvqa_Push_Cond.PushId, strComparisonOp_PushId);
}
if (objvqa_Push_Cond.IsUpdated(convqa_Push.QuestionsId) == true)
{
string strComparisonOp_QuestionsId = objvqa_Push_Cond.dicFldComparisonOp[convqa_Push.QuestionsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.QuestionsId, objvqa_Push_Cond.QuestionsId, strComparisonOp_QuestionsId);
}
if (objvqa_Push_Cond.IsUpdated(convqa_Push.QuestionsContent) == true)
{
string strComparisonOp_QuestionsContent = objvqa_Push_Cond.dicFldComparisonOp[convqa_Push.QuestionsContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.QuestionsContent, objvqa_Push_Cond.QuestionsContent, strComparisonOp_QuestionsContent);
}
if (objvqa_Push_Cond.IsUpdated(convqa_Push.ReceiveUser) == true)
{
string strComparisonOp_ReceiveUser = objvqa_Push_Cond.dicFldComparisonOp[convqa_Push.ReceiveUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.ReceiveUser, objvqa_Push_Cond.ReceiveUser, strComparisonOp_ReceiveUser);
}
if (objvqa_Push_Cond.IsUpdated(convqa_Push.ReceiveDate) == true)
{
string strComparisonOp_ReceiveDate = objvqa_Push_Cond.dicFldComparisonOp[convqa_Push.ReceiveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.ReceiveDate, objvqa_Push_Cond.ReceiveDate, strComparisonOp_ReceiveDate);
}
if (objvqa_Push_Cond.IsUpdated(convqa_Push.UserName) == true)
{
string strComparisonOp_UserName = objvqa_Push_Cond.dicFldComparisonOp[convqa_Push.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.UserName, objvqa_Push_Cond.UserName, strComparisonOp_UserName);
}
if (objvqa_Push_Cond.IsUpdated(convqa_Push.IsReceive) == true)
{
if (objvqa_Push_Cond.IsReceive == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Push.IsReceive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Push.IsReceive);
}
}
if (objvqa_Push_Cond.IsUpdated(convqa_Push.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvqa_Push_Cond.dicFldComparisonOp[convqa_Push.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.UpdDate, objvqa_Push_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvqa_Push_Cond.IsUpdated(convqa_Push.AnswerCount) == true)
{
string strComparisonOp_AnswerCount = objvqa_Push_Cond.dicFldComparisonOp[convqa_Push.AnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Push.AnswerCount, objvqa_Push_Cond.AnswerCount, strComparisonOp_AnswerCount);
}
if (objvqa_Push_Cond.IsUpdated(convqa_Push.IsEnd) == true)
{
if (objvqa_Push_Cond.IsEnd == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Push.IsEnd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Push.IsEnd);
}
}
if (objvqa_Push_Cond.IsUpdated(convqa_Push.VoteCount) == true)
{
string strComparisonOp_VoteCount = objvqa_Push_Cond.dicFldComparisonOp[convqa_Push.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Push.VoteCount, objvqa_Push_Cond.VoteCount, strComparisonOp_VoteCount);
}
if (objvqa_Push_Cond.IsUpdated(convqa_Push.Memo) == true)
{
string strComparisonOp_Memo = objvqa_Push_Cond.dicFldComparisonOp[convqa_Push.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.Memo, objvqa_Push_Cond.Memo, strComparisonOp_Memo);
}
if (objvqa_Push_Cond.IsUpdated(convqa_Push.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvqa_Push_Cond.dicFldComparisonOp[convqa_Push.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.id_CurrEduCls, objvqa_Push_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvqa_Push_Cond.IsUpdated(convqa_Push.PdfContent) == true)
{
string strComparisonOp_PdfContent = objvqa_Push_Cond.dicFldComparisonOp[convqa_Push.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.PdfContent, objvqa_Push_Cond.PdfContent, strComparisonOp_PdfContent);
}
if (objvqa_Push_Cond.IsUpdated(convqa_Push.qa_PaperId) == true)
{
string strComparisonOp_qa_PaperId = objvqa_Push_Cond.dicFldComparisonOp[convqa_Push.qa_PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.qa_PaperId, objvqa_Push_Cond.qa_PaperId, strComparisonOp_qa_PaperId);
}
if (objvqa_Push_Cond.IsUpdated(convqa_Push.IsPublic) == true)
{
if (objvqa_Push_Cond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Push.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Push.IsPublic);
}
}
if (objvqa_Push_Cond.IsUpdated(convqa_Push.PaperId) == true)
{
string strComparisonOp_PaperId = objvqa_Push_Cond.dicFldComparisonOp[convqa_Push.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.PaperId, objvqa_Push_Cond.PaperId, strComparisonOp_PaperId);
}
if (objvqa_Push_Cond.IsUpdated(convqa_Push.PaperTitle) == true)
{
string strComparisonOp_PaperTitle = objvqa_Push_Cond.dicFldComparisonOp[convqa_Push.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.PaperTitle, objvqa_Push_Cond.PaperTitle, strComparisonOp_PaperTitle);
}
if (objvqa_Push_Cond.IsUpdated(convqa_Push.PdfPageNum) == true)
{
string strComparisonOp_PdfPageNum = objvqa_Push_Cond.dicFldComparisonOp[convqa_Push.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Push.PdfPageNum, objvqa_Push_Cond.PdfPageNum, strComparisonOp_PdfPageNum);
}
if (objvqa_Push_Cond.IsUpdated(convqa_Push.IsReply) == true)
{
if (objvqa_Push_Cond.IsReply == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Push.IsReply);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Push.IsReply);
}
}
if (objvqa_Push_Cond.IsUpdated(convqa_Push.IsRequestReply) == true)
{
if (objvqa_Push_Cond.IsRequestReply == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Push.IsRequestReply);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Push.IsRequestReply);
}
}
if (objvqa_Push_Cond.IsUpdated(convqa_Push.ReplyDate) == true)
{
string strComparisonOp_ReplyDate = objvqa_Push_Cond.dicFldComparisonOp[convqa_Push.ReplyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.ReplyDate, objvqa_Push_Cond.ReplyDate, strComparisonOp_ReplyDate);
}
if (objvqa_Push_Cond.IsUpdated(convqa_Push.QuestionsTypeId) == true)
{
string strComparisonOp_QuestionsTypeId = objvqa_Push_Cond.dicFldComparisonOp[convqa_Push.QuestionsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.QuestionsTypeId, objvqa_Push_Cond.QuestionsTypeId, strComparisonOp_QuestionsTypeId);
}
if (objvqa_Push_Cond.IsUpdated(convqa_Push.QuestionsTypeName) == true)
{
string strComparisonOp_QuestionsTypeName = objvqa_Push_Cond.dicFldComparisonOp[convqa_Push.QuestionsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.QuestionsTypeName, objvqa_Push_Cond.QuestionsTypeName, strComparisonOp_QuestionsTypeName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v答疑推送(vqa_Push)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvqa_PushWApi
{
private static readonly string mstrApiControllerName = "vqa_PushApi";

 public clsvqa_PushWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngPushId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvqa_PushEN GetObjByPushId(long lngPushId)
{
string strAction = "GetObjByPushId";
string strErrMsg = string.Empty;
string strResult = "";
clsvqa_PushEN objvqa_PushEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PushId"] = lngPushId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvqa_PushEN = JsonConvert.DeserializeObject<clsvqa_PushEN>((string)jobjReturn["ReturnObj"]);
return objvqa_PushEN;
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
 /// <param name = "lngPushId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvqa_PushEN GetObjByPushId_WA_Cache(long lngPushId)
{
string strAction = "GetObjByPushId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvqa_PushEN objvqa_PushEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PushId"] = lngPushId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvqa_PushEN = JsonConvert.DeserializeObject<clsvqa_PushEN>((string)jobjReturn["ReturnObj"]);
return objvqa_PushEN;
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
public static clsvqa_PushEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvqa_PushEN objvqa_PushEN = null;
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
objvqa_PushEN = JsonConvert.DeserializeObject<clsvqa_PushEN>((string)jobjReturn["ReturnObj"]);
return objvqa_PushEN;
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
 /// <param name = "lngPushId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvqa_PushEN GetObjByPushId_Cache(long lngPushId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvqa_PushEN._CurrTabName_S);
List<clsvqa_PushEN> arrvqa_PushObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvqa_PushEN> arrvqa_PushObjLst_Sel =
from objvqa_PushEN in arrvqa_PushObjLst_Cache
where objvqa_PushEN.PushId == lngPushId
select objvqa_PushEN;
if (arrvqa_PushObjLst_Sel.Count() == 0)
{
   clsvqa_PushEN obj = clsvqa_PushWApi.GetObjByPushId(lngPushId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvqa_PushObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_PushEN> GetObjLst(string strWhereCond)
{
 List<clsvqa_PushEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_PushEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvqa_PushEN> GetObjLstByPushIdLst(List<long> arrPushId)
{
 List<clsvqa_PushEN> arrObjLst = null; 
string strAction = "GetObjLstByPushIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPushId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_PushEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngPushId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvqa_PushEN> GetObjLstByPushIdLst_Cache(List<long> arrPushId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvqa_PushEN._CurrTabName_S);
List<clsvqa_PushEN> arrvqa_PushObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvqa_PushEN> arrvqa_PushObjLst_Sel =
from objvqa_PushEN in arrvqa_PushObjLst_Cache
where arrPushId.Contains(objvqa_PushEN.PushId)
select objvqa_PushEN;
return arrvqa_PushObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_PushEN> GetObjLstByPushIdLst_WA_Cache(List<long> arrPushId)
{
 List<clsvqa_PushEN> arrObjLst = null; 
string strAction = "GetObjLstByPushIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPushId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_PushEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvqa_PushEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvqa_PushEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_PushEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvqa_PushEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvqa_PushEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_PushEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvqa_PushEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvqa_PushEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_PushEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvqa_PushEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvqa_PushEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_PushEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngPushId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PushId"] = lngPushId.ToString()
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
 /// <param name = "objvqa_PushENS">源对象</param>
 /// <param name = "objvqa_PushENT">目标对象</param>
 public static void CopyTo(clsvqa_PushEN objvqa_PushENS, clsvqa_PushEN objvqa_PushENT)
{
try
{
objvqa_PushENT.PushId = objvqa_PushENS.PushId; //推送d
objvqa_PushENT.QuestionsId = objvqa_PushENS.QuestionsId; //提问Id
objvqa_PushENT.QuestionsContent = objvqa_PushENS.QuestionsContent; //提问内容
objvqa_PushENT.ReceiveUser = objvqa_PushENS.ReceiveUser; //接收用户
objvqa_PushENT.ReceiveDate = objvqa_PushENS.ReceiveDate; //接收日期
objvqa_PushENT.UserName = objvqa_PushENS.UserName; //用户名
objvqa_PushENT.IsReceive = objvqa_PushENS.IsReceive; //是否接收
objvqa_PushENT.UpdDate = objvqa_PushENS.UpdDate; //修改日期
objvqa_PushENT.AnswerCount = objvqa_PushENS.AnswerCount; //回答计数
objvqa_PushENT.IsEnd = objvqa_PushENS.IsEnd; //是否结束
objvqa_PushENT.VoteCount = objvqa_PushENS.VoteCount; //点赞计数
objvqa_PushENT.Memo = objvqa_PushENS.Memo; //备注
objvqa_PushENT.id_CurrEduCls = objvqa_PushENS.id_CurrEduCls; //当前教学班流水号
objvqa_PushENT.PdfContent = objvqa_PushENS.PdfContent; //Pdf内容
objvqa_PushENT.qa_PaperId = objvqa_PushENS.qa_PaperId; //论文答疑Id
objvqa_PushENT.IsPublic = objvqa_PushENS.IsPublic; //是否公开
objvqa_PushENT.PaperId = objvqa_PushENS.PaperId; //论文Id
objvqa_PushENT.PaperTitle = objvqa_PushENS.PaperTitle; //论文标题
objvqa_PushENT.PdfPageNum = objvqa_PushENS.PdfPageNum; //Pdf页码
objvqa_PushENT.IsReply = objvqa_PushENS.IsReply; //是否回复
objvqa_PushENT.IsRequestReply = objvqa_PushENS.IsRequestReply; //是否要求回复
objvqa_PushENT.ReplyDate = objvqa_PushENS.ReplyDate; //回复日期
objvqa_PushENT.QuestionsTypeId = objvqa_PushENS.QuestionsTypeId; //问题类型Id
objvqa_PushENT.QuestionsTypeName = objvqa_PushENS.QuestionsTypeName; //问题类型名称
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
public static DataTable ToDataTable(List<clsvqa_PushEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvqa_PushEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvqa_PushEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvqa_PushEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvqa_PushEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvqa_PushEN.AttributeName)
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
if (clsqa_PushWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_PushWApi没有刷新缓存机制(clsqa_PushWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
//string strWhereCond = string.Format("1 = 1 order by PushId");
//if (arrvqa_PushObjLst_Cache == null)
//{
//arrvqa_PushObjLst_Cache = await clsvqa_PushWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvqa_PushEN._CurrTabName_S);
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
public static List<clsvqa_PushEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvqa_PushEN._CurrTabName_S);
List<clsvqa_PushEN> arrvqa_PushObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvqa_PushObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvqa_PushEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convqa_Push.PushId, Type.GetType("System.Int64"));
objDT.Columns.Add(convqa_Push.QuestionsId, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Push.QuestionsContent, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Push.ReceiveUser, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Push.ReceiveDate, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Push.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Push.IsReceive, Type.GetType("System.Boolean"));
objDT.Columns.Add(convqa_Push.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Push.AnswerCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convqa_Push.IsEnd, Type.GetType("System.Boolean"));
objDT.Columns.Add(convqa_Push.VoteCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convqa_Push.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Push.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Push.PdfContent, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Push.qa_PaperId, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Push.IsPublic, Type.GetType("System.Boolean"));
objDT.Columns.Add(convqa_Push.PaperId, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Push.PaperTitle, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Push.PdfPageNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convqa_Push.IsReply, Type.GetType("System.Boolean"));
objDT.Columns.Add(convqa_Push.IsRequestReply, Type.GetType("System.Boolean"));
objDT.Columns.Add(convqa_Push.ReplyDate, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Push.QuestionsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Push.QuestionsTypeName, Type.GetType("System.String"));
foreach (clsvqa_PushEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convqa_Push.PushId] = objInFor[convqa_Push.PushId];
objDR[convqa_Push.QuestionsId] = objInFor[convqa_Push.QuestionsId];
objDR[convqa_Push.QuestionsContent] = objInFor[convqa_Push.QuestionsContent];
objDR[convqa_Push.ReceiveUser] = objInFor[convqa_Push.ReceiveUser];
objDR[convqa_Push.ReceiveDate] = objInFor[convqa_Push.ReceiveDate];
objDR[convqa_Push.UserName] = objInFor[convqa_Push.UserName];
objDR[convqa_Push.IsReceive] = objInFor[convqa_Push.IsReceive];
objDR[convqa_Push.UpdDate] = objInFor[convqa_Push.UpdDate];
objDR[convqa_Push.AnswerCount] = objInFor[convqa_Push.AnswerCount];
objDR[convqa_Push.IsEnd] = objInFor[convqa_Push.IsEnd];
objDR[convqa_Push.VoteCount] = objInFor[convqa_Push.VoteCount];
objDR[convqa_Push.Memo] = objInFor[convqa_Push.Memo];
objDR[convqa_Push.id_CurrEduCls] = objInFor[convqa_Push.id_CurrEduCls];
objDR[convqa_Push.PdfContent] = objInFor[convqa_Push.PdfContent];
objDR[convqa_Push.qa_PaperId] = objInFor[convqa_Push.qa_PaperId];
objDR[convqa_Push.IsPublic] = objInFor[convqa_Push.IsPublic];
objDR[convqa_Push.PaperId] = objInFor[convqa_Push.PaperId];
objDR[convqa_Push.PaperTitle] = objInFor[convqa_Push.PaperTitle];
objDR[convqa_Push.PdfPageNum] = objInFor[convqa_Push.PdfPageNum];
objDR[convqa_Push.IsReply] = objInFor[convqa_Push.IsReply];
objDR[convqa_Push.IsRequestReply] = objInFor[convqa_Push.IsRequestReply];
objDR[convqa_Push.ReplyDate] = objInFor[convqa_Push.ReplyDate];
objDR[convqa_Push.QuestionsTypeId] = objInFor[convqa_Push.QuestionsTypeId];
objDR[convqa_Push.QuestionsTypeName] = objInFor[convqa_Push.QuestionsTypeName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}