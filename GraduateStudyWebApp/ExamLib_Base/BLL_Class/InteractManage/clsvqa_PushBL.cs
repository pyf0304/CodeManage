
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvqa_PushBL
 表名:vqa_Push(01120634)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:06:34
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
public static class  clsvqa_PushBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngPushId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvqa_PushEN GetObj(this K_PushId_vqa_Push myKey)
{
clsvqa_PushEN objvqa_PushEN = clsvqa_PushBL.vqa_PushDA.GetObjByPushId(myKey.Value);
return objvqa_PushEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PushEN SetQuestionsId(this clsvqa_PushEN objvqa_PushEN, string strQuestionsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionsId, convqa_Push.QuestionsId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsId, 8, convqa_Push.QuestionsId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionsId, 8, convqa_Push.QuestionsId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PushEN SetQuestionsContent(this clsvqa_PushEN objvqa_PushEN, string strQuestionsContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsContent, 1000, convqa_Push.QuestionsContent);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PushEN SetReceiveUser(this clsvqa_PushEN objvqa_PushEN, string strReceiveUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReceiveUser, 20, convqa_Push.ReceiveUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PushEN SetReceiveDate(this clsvqa_PushEN objvqa_PushEN, string strReceiveDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReceiveDate, 20, convqa_Push.ReceiveDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PushEN SetUserName(this clsvqa_PushEN objvqa_PushEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convqa_Push.UserName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PushEN SetUpdDate(this clsvqa_PushEN objvqa_PushEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convqa_Push.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PushEN SetAnswerCount(this clsvqa_PushEN objvqa_PushEN, int? intAnswerCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PushEN SetVoteCount(this clsvqa_PushEN objvqa_PushEN, int? intVoteCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PushEN SetMemo(this clsvqa_PushEN objvqa_PushEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convqa_Push.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PushEN SetIdCurrEduCls(this clsvqa_PushEN objvqa_PushEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convqa_Push.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convqa_Push.IdCurrEduCls);
}
objvqa_PushEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.IdCurrEduCls) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.IdCurrEduCls, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.IdCurrEduCls] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PushEN SetPdfContent(this clsvqa_PushEN objvqa_PushEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convqa_Push.PdfContent);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PushEN SetQaPaperId(this clsvqa_PushEN objvqa_PushEN, string strQaPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQaPaperId, 8, convqa_Push.QaPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQaPaperId, 8, convqa_Push.QaPaperId);
}
objvqa_PushEN.QaPaperId = strQaPaperId; //论文答疑Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PushEN.dicFldComparisonOp.ContainsKey(convqa_Push.QaPaperId) == false)
{
objvqa_PushEN.dicFldComparisonOp.Add(convqa_Push.QaPaperId, strComparisonOp);
}
else
{
objvqa_PushEN.dicFldComparisonOp[convqa_Push.QaPaperId] = strComparisonOp;
}
}
return objvqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PushEN SetPaperId(this clsvqa_PushEN objvqa_PushEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convqa_Push.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convqa_Push.PaperId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PushEN SetPaperTitle(this clsvqa_PushEN objvqa_PushEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convqa_Push.PaperTitle);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PushEN SetPdfPageNum(this clsvqa_PushEN objvqa_PushEN, int? intPdfPageNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PushEN SetReplyDate(this clsvqa_PushEN objvqa_PushEN, string strReplyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReplyDate, 20, convqa_Push.ReplyDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PushEN SetQuestionsTypeId(this clsvqa_PushEN objvqa_PushEN, string strQuestionsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsTypeId, 2, convqa_Push.QuestionsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionsTypeId, 2, convqa_Push.QuestionsTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PushEN SetQuestionsTypeName(this clsvqa_PushEN objvqa_PushEN, string strQuestionsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsTypeName, 50, convqa_Push.QuestionsTypeName);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvqa_PushENS">源对象</param>
 /// <param name = "objvqa_PushENT">目标对象</param>
 public static void CopyTo(this clsvqa_PushEN objvqa_PushENS, clsvqa_PushEN objvqa_PushENT)
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
objvqa_PushENT.IdCurrEduCls = objvqa_PushENS.IdCurrEduCls; //教学班流水号
objvqa_PushENT.PdfContent = objvqa_PushENS.PdfContent; //Pdf内容
objvqa_PushENT.QaPaperId = objvqa_PushENS.QaPaperId; //论文答疑Id
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
 /// <param name = "objvqa_PushENS">源对象</param>
 /// <returns>目标对象=>clsvqa_PushEN:objvqa_PushENT</returns>
 public static clsvqa_PushEN CopyTo(this clsvqa_PushEN objvqa_PushENS)
{
try
{
 clsvqa_PushEN objvqa_PushENT = new clsvqa_PushEN()
{
PushId = objvqa_PushENS.PushId, //推送d
QuestionsId = objvqa_PushENS.QuestionsId, //提问Id
QuestionsContent = objvqa_PushENS.QuestionsContent, //提问内容
ReceiveUser = objvqa_PushENS.ReceiveUser, //接收用户
ReceiveDate = objvqa_PushENS.ReceiveDate, //接收日期
UserName = objvqa_PushENS.UserName, //用户名
IsReceive = objvqa_PushENS.IsReceive, //是否接收
UpdDate = objvqa_PushENS.UpdDate, //修改日期
AnswerCount = objvqa_PushENS.AnswerCount, //回答计数
IsEnd = objvqa_PushENS.IsEnd, //是否结束
VoteCount = objvqa_PushENS.VoteCount, //点赞计数
Memo = objvqa_PushENS.Memo, //备注
IdCurrEduCls = objvqa_PushENS.IdCurrEduCls, //教学班流水号
PdfContent = objvqa_PushENS.PdfContent, //Pdf内容
QaPaperId = objvqa_PushENS.QaPaperId, //论文答疑Id
IsPublic = objvqa_PushENS.IsPublic, //是否公开
PaperId = objvqa_PushENS.PaperId, //论文Id
PaperTitle = objvqa_PushENS.PaperTitle, //论文标题
PdfPageNum = objvqa_PushENS.PdfPageNum, //Pdf页码
IsReply = objvqa_PushENS.IsReply, //是否回复
IsRequestReply = objvqa_PushENS.IsRequestReply, //是否要求回复
ReplyDate = objvqa_PushENS.ReplyDate, //回复日期
QuestionsTypeId = objvqa_PushENS.QuestionsTypeId, //问题类型Id
QuestionsTypeName = objvqa_PushENS.QuestionsTypeName, //问题类型名称
};
 return objvqa_PushENT;
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
public static void CheckProperty4Condition(this clsvqa_PushEN objvqa_PushEN)
{
 clsvqa_PushBL.vqa_PushDA.CheckProperty4Condition(objvqa_PushEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvqa_PushEN objvqa_PushCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvqa_PushCond.IsUpdated(convqa_Push.PushId) == true)
{
string strComparisonOpPushId = objvqa_PushCond.dicFldComparisonOp[convqa_Push.PushId];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Push.PushId, objvqa_PushCond.PushId, strComparisonOpPushId);
}
if (objvqa_PushCond.IsUpdated(convqa_Push.QuestionsId) == true)
{
string strComparisonOpQuestionsId = objvqa_PushCond.dicFldComparisonOp[convqa_Push.QuestionsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.QuestionsId, objvqa_PushCond.QuestionsId, strComparisonOpQuestionsId);
}
if (objvqa_PushCond.IsUpdated(convqa_Push.QuestionsContent) == true)
{
string strComparisonOpQuestionsContent = objvqa_PushCond.dicFldComparisonOp[convqa_Push.QuestionsContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.QuestionsContent, objvqa_PushCond.QuestionsContent, strComparisonOpQuestionsContent);
}
if (objvqa_PushCond.IsUpdated(convqa_Push.ReceiveUser) == true)
{
string strComparisonOpReceiveUser = objvqa_PushCond.dicFldComparisonOp[convqa_Push.ReceiveUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.ReceiveUser, objvqa_PushCond.ReceiveUser, strComparisonOpReceiveUser);
}
if (objvqa_PushCond.IsUpdated(convqa_Push.ReceiveDate) == true)
{
string strComparisonOpReceiveDate = objvqa_PushCond.dicFldComparisonOp[convqa_Push.ReceiveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.ReceiveDate, objvqa_PushCond.ReceiveDate, strComparisonOpReceiveDate);
}
if (objvqa_PushCond.IsUpdated(convqa_Push.UserName) == true)
{
string strComparisonOpUserName = objvqa_PushCond.dicFldComparisonOp[convqa_Push.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.UserName, objvqa_PushCond.UserName, strComparisonOpUserName);
}
if (objvqa_PushCond.IsUpdated(convqa_Push.IsReceive) == true)
{
if (objvqa_PushCond.IsReceive == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Push.IsReceive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Push.IsReceive);
}
}
if (objvqa_PushCond.IsUpdated(convqa_Push.UpdDate) == true)
{
string strComparisonOpUpdDate = objvqa_PushCond.dicFldComparisonOp[convqa_Push.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.UpdDate, objvqa_PushCond.UpdDate, strComparisonOpUpdDate);
}
if (objvqa_PushCond.IsUpdated(convqa_Push.AnswerCount) == true)
{
string strComparisonOpAnswerCount = objvqa_PushCond.dicFldComparisonOp[convqa_Push.AnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Push.AnswerCount, objvqa_PushCond.AnswerCount, strComparisonOpAnswerCount);
}
if (objvqa_PushCond.IsUpdated(convqa_Push.IsEnd) == true)
{
if (objvqa_PushCond.IsEnd == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Push.IsEnd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Push.IsEnd);
}
}
if (objvqa_PushCond.IsUpdated(convqa_Push.VoteCount) == true)
{
string strComparisonOpVoteCount = objvqa_PushCond.dicFldComparisonOp[convqa_Push.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Push.VoteCount, objvqa_PushCond.VoteCount, strComparisonOpVoteCount);
}
if (objvqa_PushCond.IsUpdated(convqa_Push.Memo) == true)
{
string strComparisonOpMemo = objvqa_PushCond.dicFldComparisonOp[convqa_Push.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.Memo, objvqa_PushCond.Memo, strComparisonOpMemo);
}
if (objvqa_PushCond.IsUpdated(convqa_Push.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvqa_PushCond.dicFldComparisonOp[convqa_Push.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.IdCurrEduCls, objvqa_PushCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvqa_PushCond.IsUpdated(convqa_Push.PdfContent) == true)
{
string strComparisonOpPdfContent = objvqa_PushCond.dicFldComparisonOp[convqa_Push.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.PdfContent, objvqa_PushCond.PdfContent, strComparisonOpPdfContent);
}
if (objvqa_PushCond.IsUpdated(convqa_Push.QaPaperId) == true)
{
string strComparisonOpQaPaperId = objvqa_PushCond.dicFldComparisonOp[convqa_Push.QaPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.QaPaperId, objvqa_PushCond.QaPaperId, strComparisonOpQaPaperId);
}
if (objvqa_PushCond.IsUpdated(convqa_Push.IsPublic) == true)
{
if (objvqa_PushCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Push.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Push.IsPublic);
}
}
if (objvqa_PushCond.IsUpdated(convqa_Push.PaperId) == true)
{
string strComparisonOpPaperId = objvqa_PushCond.dicFldComparisonOp[convqa_Push.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.PaperId, objvqa_PushCond.PaperId, strComparisonOpPaperId);
}
if (objvqa_PushCond.IsUpdated(convqa_Push.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvqa_PushCond.dicFldComparisonOp[convqa_Push.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.PaperTitle, objvqa_PushCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvqa_PushCond.IsUpdated(convqa_Push.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objvqa_PushCond.dicFldComparisonOp[convqa_Push.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Push.PdfPageNum, objvqa_PushCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objvqa_PushCond.IsUpdated(convqa_Push.IsReply) == true)
{
if (objvqa_PushCond.IsReply == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Push.IsReply);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Push.IsReply);
}
}
if (objvqa_PushCond.IsUpdated(convqa_Push.IsRequestReply) == true)
{
if (objvqa_PushCond.IsRequestReply == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Push.IsRequestReply);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Push.IsRequestReply);
}
}
if (objvqa_PushCond.IsUpdated(convqa_Push.ReplyDate) == true)
{
string strComparisonOpReplyDate = objvqa_PushCond.dicFldComparisonOp[convqa_Push.ReplyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.ReplyDate, objvqa_PushCond.ReplyDate, strComparisonOpReplyDate);
}
if (objvqa_PushCond.IsUpdated(convqa_Push.QuestionsTypeId) == true)
{
string strComparisonOpQuestionsTypeId = objvqa_PushCond.dicFldComparisonOp[convqa_Push.QuestionsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.QuestionsTypeId, objvqa_PushCond.QuestionsTypeId, strComparisonOpQuestionsTypeId);
}
if (objvqa_PushCond.IsUpdated(convqa_Push.QuestionsTypeName) == true)
{
string strComparisonOpQuestionsTypeName = objvqa_PushCond.dicFldComparisonOp[convqa_Push.QuestionsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Push.QuestionsTypeName, objvqa_PushCond.QuestionsTypeName, strComparisonOpQuestionsTypeName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vqa_Push
{
public virtual bool UpdRelaTabDate(long lngPushId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v答疑推送(vqa_Push)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvqa_PushBL
{
public static RelatedActions_vqa_Push relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvqa_PushDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvqa_PushDA vqa_PushDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvqa_PushDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvqa_PushBL()
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
if (string.IsNullOrEmpty(clsvqa_PushEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvqa_PushEN._ConnectString);
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
public static DataTable GetDataTable_vqa_Push(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vqa_PushDA.GetDataTable_vqa_Push(strWhereCond);
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
objDT = vqa_PushDA.GetDataTable(strWhereCond);
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
objDT = vqa_PushDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vqa_PushDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vqa_PushDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vqa_PushDA.GetDataTable_Top(objTopPara);
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
objDT = vqa_PushDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vqa_PushDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vqa_PushDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPushIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvqa_PushEN> GetObjLstByPushIdLst(List<long> arrPushIdLst)
{
List<clsvqa_PushEN> arrObjLst = new List<clsvqa_PushEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPushIdLst);
 string strWhereCond = string.Format("PushId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_PushEN objvqa_PushEN = new clsvqa_PushEN();
try
{
objvqa_PushEN.PushId = Int32.Parse(objRow[convqa_Push.PushId].ToString().Trim()); //推送d
objvqa_PushEN.QuestionsId = objRow[convqa_Push.QuestionsId].ToString().Trim(); //提问Id
objvqa_PushEN.QuestionsContent = objRow[convqa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvqa_PushEN.ReceiveUser = objRow[convqa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convqa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvqa_PushEN.ReceiveDate = objRow[convqa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convqa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvqa_PushEN.UserName = objRow[convqa_Push.UserName] == DBNull.Value ? null : objRow[convqa_Push.UserName].ToString().Trim(); //用户名
objvqa_PushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsReceive].ToString().Trim()); //是否接收
objvqa_PushEN.UpdDate = objRow[convqa_Push.UpdDate] == DBNull.Value ? null : objRow[convqa_Push.UpdDate].ToString().Trim(); //修改日期
objvqa_PushEN.AnswerCount = objRow[convqa_Push.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.AnswerCount].ToString().Trim()); //回答计数
objvqa_PushEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsEnd].ToString().Trim()); //是否结束
objvqa_PushEN.VoteCount = objRow[convqa_Push.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.VoteCount].ToString().Trim()); //点赞计数
objvqa_PushEN.Memo = objRow[convqa_Push.Memo] == DBNull.Value ? null : objRow[convqa_Push.Memo].ToString().Trim(); //备注
objvqa_PushEN.IdCurrEduCls = objRow[convqa_Push.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Push.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PushEN.PdfContent = objRow[convqa_Push.PdfContent] == DBNull.Value ? null : objRow[convqa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvqa_PushEN.QaPaperId = objRow[convqa_Push.QaPaperId] == DBNull.Value ? null : objRow[convqa_Push.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PushEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsPublic].ToString().Trim()); //是否公开
objvqa_PushEN.PaperId = objRow[convqa_Push.PaperId] == DBNull.Value ? null : objRow[convqa_Push.PaperId].ToString().Trim(); //论文Id
objvqa_PushEN.PaperTitle = objRow[convqa_Push.PaperTitle] == DBNull.Value ? null : objRow[convqa_Push.PaperTitle].ToString().Trim(); //论文标题
objvqa_PushEN.PdfPageNum = objRow[convqa_Push.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_PushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsReply].ToString().Trim()); //是否回复
objvqa_PushEN.IsRequestReply = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvqa_PushEN.ReplyDate = objRow[convqa_Push.ReplyDate] == DBNull.Value ? null : objRow[convqa_Push.ReplyDate].ToString().Trim(); //回复日期
objvqa_PushEN.QuestionsTypeId = objRow[convqa_Push.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_PushEN.QuestionsTypeName = objRow[convqa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_PushEN.PushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_PushEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPushIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvqa_PushEN> GetObjLstByPushIdLstCache(List<long> arrPushIdLst)
{
string strKey = string.Format("{0}", clsvqa_PushEN._CurrTabName);
List<clsvqa_PushEN> arrvqa_PushObjLstCache = GetObjLstCache();
IEnumerable <clsvqa_PushEN> arrvqa_PushObjLst_Sel =
arrvqa_PushObjLstCache
.Where(x => arrPushIdLst.Contains(x.PushId));
return arrvqa_PushObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_PushEN> GetObjLst(string strWhereCond)
{
List<clsvqa_PushEN> arrObjLst = new List<clsvqa_PushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_PushEN objvqa_PushEN = new clsvqa_PushEN();
try
{
objvqa_PushEN.PushId = Int32.Parse(objRow[convqa_Push.PushId].ToString().Trim()); //推送d
objvqa_PushEN.QuestionsId = objRow[convqa_Push.QuestionsId].ToString().Trim(); //提问Id
objvqa_PushEN.QuestionsContent = objRow[convqa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvqa_PushEN.ReceiveUser = objRow[convqa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convqa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvqa_PushEN.ReceiveDate = objRow[convqa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convqa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvqa_PushEN.UserName = objRow[convqa_Push.UserName] == DBNull.Value ? null : objRow[convqa_Push.UserName].ToString().Trim(); //用户名
objvqa_PushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsReceive].ToString().Trim()); //是否接收
objvqa_PushEN.UpdDate = objRow[convqa_Push.UpdDate] == DBNull.Value ? null : objRow[convqa_Push.UpdDate].ToString().Trim(); //修改日期
objvqa_PushEN.AnswerCount = objRow[convqa_Push.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.AnswerCount].ToString().Trim()); //回答计数
objvqa_PushEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsEnd].ToString().Trim()); //是否结束
objvqa_PushEN.VoteCount = objRow[convqa_Push.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.VoteCount].ToString().Trim()); //点赞计数
objvqa_PushEN.Memo = objRow[convqa_Push.Memo] == DBNull.Value ? null : objRow[convqa_Push.Memo].ToString().Trim(); //备注
objvqa_PushEN.IdCurrEduCls = objRow[convqa_Push.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Push.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PushEN.PdfContent = objRow[convqa_Push.PdfContent] == DBNull.Value ? null : objRow[convqa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvqa_PushEN.QaPaperId = objRow[convqa_Push.QaPaperId] == DBNull.Value ? null : objRow[convqa_Push.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PushEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsPublic].ToString().Trim()); //是否公开
objvqa_PushEN.PaperId = objRow[convqa_Push.PaperId] == DBNull.Value ? null : objRow[convqa_Push.PaperId].ToString().Trim(); //论文Id
objvqa_PushEN.PaperTitle = objRow[convqa_Push.PaperTitle] == DBNull.Value ? null : objRow[convqa_Push.PaperTitle].ToString().Trim(); //论文标题
objvqa_PushEN.PdfPageNum = objRow[convqa_Push.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_PushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsReply].ToString().Trim()); //是否回复
objvqa_PushEN.IsRequestReply = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvqa_PushEN.ReplyDate = objRow[convqa_Push.ReplyDate] == DBNull.Value ? null : objRow[convqa_Push.ReplyDate].ToString().Trim(); //回复日期
objvqa_PushEN.QuestionsTypeId = objRow[convqa_Push.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_PushEN.QuestionsTypeName = objRow[convqa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_PushEN.PushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_PushEN);
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
public static List<clsvqa_PushEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvqa_PushEN> arrObjLst = new List<clsvqa_PushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_PushEN objvqa_PushEN = new clsvqa_PushEN();
try
{
objvqa_PushEN.PushId = Int32.Parse(objRow[convqa_Push.PushId].ToString().Trim()); //推送d
objvqa_PushEN.QuestionsId = objRow[convqa_Push.QuestionsId].ToString().Trim(); //提问Id
objvqa_PushEN.QuestionsContent = objRow[convqa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvqa_PushEN.ReceiveUser = objRow[convqa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convqa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvqa_PushEN.ReceiveDate = objRow[convqa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convqa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvqa_PushEN.UserName = objRow[convqa_Push.UserName] == DBNull.Value ? null : objRow[convqa_Push.UserName].ToString().Trim(); //用户名
objvqa_PushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsReceive].ToString().Trim()); //是否接收
objvqa_PushEN.UpdDate = objRow[convqa_Push.UpdDate] == DBNull.Value ? null : objRow[convqa_Push.UpdDate].ToString().Trim(); //修改日期
objvqa_PushEN.AnswerCount = objRow[convqa_Push.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.AnswerCount].ToString().Trim()); //回答计数
objvqa_PushEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsEnd].ToString().Trim()); //是否结束
objvqa_PushEN.VoteCount = objRow[convqa_Push.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.VoteCount].ToString().Trim()); //点赞计数
objvqa_PushEN.Memo = objRow[convqa_Push.Memo] == DBNull.Value ? null : objRow[convqa_Push.Memo].ToString().Trim(); //备注
objvqa_PushEN.IdCurrEduCls = objRow[convqa_Push.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Push.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PushEN.PdfContent = objRow[convqa_Push.PdfContent] == DBNull.Value ? null : objRow[convqa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvqa_PushEN.QaPaperId = objRow[convqa_Push.QaPaperId] == DBNull.Value ? null : objRow[convqa_Push.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PushEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsPublic].ToString().Trim()); //是否公开
objvqa_PushEN.PaperId = objRow[convqa_Push.PaperId] == DBNull.Value ? null : objRow[convqa_Push.PaperId].ToString().Trim(); //论文Id
objvqa_PushEN.PaperTitle = objRow[convqa_Push.PaperTitle] == DBNull.Value ? null : objRow[convqa_Push.PaperTitle].ToString().Trim(); //论文标题
objvqa_PushEN.PdfPageNum = objRow[convqa_Push.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_PushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsReply].ToString().Trim()); //是否回复
objvqa_PushEN.IsRequestReply = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvqa_PushEN.ReplyDate = objRow[convqa_Push.ReplyDate] == DBNull.Value ? null : objRow[convqa_Push.ReplyDate].ToString().Trim(); //回复日期
objvqa_PushEN.QuestionsTypeId = objRow[convqa_Push.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_PushEN.QuestionsTypeName = objRow[convqa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_PushEN.PushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_PushEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvqa_PushCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvqa_PushEN> GetSubObjLstCache(clsvqa_PushEN objvqa_PushCond)
{
List<clsvqa_PushEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvqa_PushEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convqa_Push.AttributeName)
{
if (objvqa_PushCond.IsUpdated(strFldName) == false) continue;
if (objvqa_PushCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvqa_PushCond[strFldName].ToString());
}
else
{
if (objvqa_PushCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvqa_PushCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvqa_PushCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvqa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvqa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvqa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvqa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvqa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvqa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvqa_PushCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvqa_PushCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvqa_PushCond[strFldName]));
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
public static List<clsvqa_PushEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvqa_PushEN> arrObjLst = new List<clsvqa_PushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_PushEN objvqa_PushEN = new clsvqa_PushEN();
try
{
objvqa_PushEN.PushId = Int32.Parse(objRow[convqa_Push.PushId].ToString().Trim()); //推送d
objvqa_PushEN.QuestionsId = objRow[convqa_Push.QuestionsId].ToString().Trim(); //提问Id
objvqa_PushEN.QuestionsContent = objRow[convqa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvqa_PushEN.ReceiveUser = objRow[convqa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convqa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvqa_PushEN.ReceiveDate = objRow[convqa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convqa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvqa_PushEN.UserName = objRow[convqa_Push.UserName] == DBNull.Value ? null : objRow[convqa_Push.UserName].ToString().Trim(); //用户名
objvqa_PushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsReceive].ToString().Trim()); //是否接收
objvqa_PushEN.UpdDate = objRow[convqa_Push.UpdDate] == DBNull.Value ? null : objRow[convqa_Push.UpdDate].ToString().Trim(); //修改日期
objvqa_PushEN.AnswerCount = objRow[convqa_Push.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.AnswerCount].ToString().Trim()); //回答计数
objvqa_PushEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsEnd].ToString().Trim()); //是否结束
objvqa_PushEN.VoteCount = objRow[convqa_Push.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.VoteCount].ToString().Trim()); //点赞计数
objvqa_PushEN.Memo = objRow[convqa_Push.Memo] == DBNull.Value ? null : objRow[convqa_Push.Memo].ToString().Trim(); //备注
objvqa_PushEN.IdCurrEduCls = objRow[convqa_Push.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Push.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PushEN.PdfContent = objRow[convqa_Push.PdfContent] == DBNull.Value ? null : objRow[convqa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvqa_PushEN.QaPaperId = objRow[convqa_Push.QaPaperId] == DBNull.Value ? null : objRow[convqa_Push.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PushEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsPublic].ToString().Trim()); //是否公开
objvqa_PushEN.PaperId = objRow[convqa_Push.PaperId] == DBNull.Value ? null : objRow[convqa_Push.PaperId].ToString().Trim(); //论文Id
objvqa_PushEN.PaperTitle = objRow[convqa_Push.PaperTitle] == DBNull.Value ? null : objRow[convqa_Push.PaperTitle].ToString().Trim(); //论文标题
objvqa_PushEN.PdfPageNum = objRow[convqa_Push.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_PushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsReply].ToString().Trim()); //是否回复
objvqa_PushEN.IsRequestReply = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvqa_PushEN.ReplyDate = objRow[convqa_Push.ReplyDate] == DBNull.Value ? null : objRow[convqa_Push.ReplyDate].ToString().Trim(); //回复日期
objvqa_PushEN.QuestionsTypeId = objRow[convqa_Push.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_PushEN.QuestionsTypeName = objRow[convqa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_PushEN.PushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_PushEN);
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
public static List<clsvqa_PushEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvqa_PushEN> arrObjLst = new List<clsvqa_PushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_PushEN objvqa_PushEN = new clsvqa_PushEN();
try
{
objvqa_PushEN.PushId = Int32.Parse(objRow[convqa_Push.PushId].ToString().Trim()); //推送d
objvqa_PushEN.QuestionsId = objRow[convqa_Push.QuestionsId].ToString().Trim(); //提问Id
objvqa_PushEN.QuestionsContent = objRow[convqa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvqa_PushEN.ReceiveUser = objRow[convqa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convqa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvqa_PushEN.ReceiveDate = objRow[convqa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convqa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvqa_PushEN.UserName = objRow[convqa_Push.UserName] == DBNull.Value ? null : objRow[convqa_Push.UserName].ToString().Trim(); //用户名
objvqa_PushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsReceive].ToString().Trim()); //是否接收
objvqa_PushEN.UpdDate = objRow[convqa_Push.UpdDate] == DBNull.Value ? null : objRow[convqa_Push.UpdDate].ToString().Trim(); //修改日期
objvqa_PushEN.AnswerCount = objRow[convqa_Push.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.AnswerCount].ToString().Trim()); //回答计数
objvqa_PushEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsEnd].ToString().Trim()); //是否结束
objvqa_PushEN.VoteCount = objRow[convqa_Push.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.VoteCount].ToString().Trim()); //点赞计数
objvqa_PushEN.Memo = objRow[convqa_Push.Memo] == DBNull.Value ? null : objRow[convqa_Push.Memo].ToString().Trim(); //备注
objvqa_PushEN.IdCurrEduCls = objRow[convqa_Push.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Push.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PushEN.PdfContent = objRow[convqa_Push.PdfContent] == DBNull.Value ? null : objRow[convqa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvqa_PushEN.QaPaperId = objRow[convqa_Push.QaPaperId] == DBNull.Value ? null : objRow[convqa_Push.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PushEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsPublic].ToString().Trim()); //是否公开
objvqa_PushEN.PaperId = objRow[convqa_Push.PaperId] == DBNull.Value ? null : objRow[convqa_Push.PaperId].ToString().Trim(); //论文Id
objvqa_PushEN.PaperTitle = objRow[convqa_Push.PaperTitle] == DBNull.Value ? null : objRow[convqa_Push.PaperTitle].ToString().Trim(); //论文标题
objvqa_PushEN.PdfPageNum = objRow[convqa_Push.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_PushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsReply].ToString().Trim()); //是否回复
objvqa_PushEN.IsRequestReply = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvqa_PushEN.ReplyDate = objRow[convqa_Push.ReplyDate] == DBNull.Value ? null : objRow[convqa_Push.ReplyDate].ToString().Trim(); //回复日期
objvqa_PushEN.QuestionsTypeId = objRow[convqa_Push.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_PushEN.QuestionsTypeName = objRow[convqa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_PushEN.PushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_PushEN);
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
List<clsvqa_PushEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvqa_PushEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_PushEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvqa_PushEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvqa_PushEN> arrObjLst = new List<clsvqa_PushEN>(); 
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
	clsvqa_PushEN objvqa_PushEN = new clsvqa_PushEN();
try
{
objvqa_PushEN.PushId = Int32.Parse(objRow[convqa_Push.PushId].ToString().Trim()); //推送d
objvqa_PushEN.QuestionsId = objRow[convqa_Push.QuestionsId].ToString().Trim(); //提问Id
objvqa_PushEN.QuestionsContent = objRow[convqa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvqa_PushEN.ReceiveUser = objRow[convqa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convqa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvqa_PushEN.ReceiveDate = objRow[convqa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convqa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvqa_PushEN.UserName = objRow[convqa_Push.UserName] == DBNull.Value ? null : objRow[convqa_Push.UserName].ToString().Trim(); //用户名
objvqa_PushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsReceive].ToString().Trim()); //是否接收
objvqa_PushEN.UpdDate = objRow[convqa_Push.UpdDate] == DBNull.Value ? null : objRow[convqa_Push.UpdDate].ToString().Trim(); //修改日期
objvqa_PushEN.AnswerCount = objRow[convqa_Push.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.AnswerCount].ToString().Trim()); //回答计数
objvqa_PushEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsEnd].ToString().Trim()); //是否结束
objvqa_PushEN.VoteCount = objRow[convqa_Push.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.VoteCount].ToString().Trim()); //点赞计数
objvqa_PushEN.Memo = objRow[convqa_Push.Memo] == DBNull.Value ? null : objRow[convqa_Push.Memo].ToString().Trim(); //备注
objvqa_PushEN.IdCurrEduCls = objRow[convqa_Push.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Push.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PushEN.PdfContent = objRow[convqa_Push.PdfContent] == DBNull.Value ? null : objRow[convqa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvqa_PushEN.QaPaperId = objRow[convqa_Push.QaPaperId] == DBNull.Value ? null : objRow[convqa_Push.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PushEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsPublic].ToString().Trim()); //是否公开
objvqa_PushEN.PaperId = objRow[convqa_Push.PaperId] == DBNull.Value ? null : objRow[convqa_Push.PaperId].ToString().Trim(); //论文Id
objvqa_PushEN.PaperTitle = objRow[convqa_Push.PaperTitle] == DBNull.Value ? null : objRow[convqa_Push.PaperTitle].ToString().Trim(); //论文标题
objvqa_PushEN.PdfPageNum = objRow[convqa_Push.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_PushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsReply].ToString().Trim()); //是否回复
objvqa_PushEN.IsRequestReply = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvqa_PushEN.ReplyDate = objRow[convqa_Push.ReplyDate] == DBNull.Value ? null : objRow[convqa_Push.ReplyDate].ToString().Trim(); //回复日期
objvqa_PushEN.QuestionsTypeId = objRow[convqa_Push.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_PushEN.QuestionsTypeName = objRow[convqa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_PushEN.PushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_PushEN);
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
public static List<clsvqa_PushEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvqa_PushEN> arrObjLst = new List<clsvqa_PushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_PushEN objvqa_PushEN = new clsvqa_PushEN();
try
{
objvqa_PushEN.PushId = Int32.Parse(objRow[convqa_Push.PushId].ToString().Trim()); //推送d
objvqa_PushEN.QuestionsId = objRow[convqa_Push.QuestionsId].ToString().Trim(); //提问Id
objvqa_PushEN.QuestionsContent = objRow[convqa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvqa_PushEN.ReceiveUser = objRow[convqa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convqa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvqa_PushEN.ReceiveDate = objRow[convqa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convqa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvqa_PushEN.UserName = objRow[convqa_Push.UserName] == DBNull.Value ? null : objRow[convqa_Push.UserName].ToString().Trim(); //用户名
objvqa_PushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsReceive].ToString().Trim()); //是否接收
objvqa_PushEN.UpdDate = objRow[convqa_Push.UpdDate] == DBNull.Value ? null : objRow[convqa_Push.UpdDate].ToString().Trim(); //修改日期
objvqa_PushEN.AnswerCount = objRow[convqa_Push.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.AnswerCount].ToString().Trim()); //回答计数
objvqa_PushEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsEnd].ToString().Trim()); //是否结束
objvqa_PushEN.VoteCount = objRow[convqa_Push.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.VoteCount].ToString().Trim()); //点赞计数
objvqa_PushEN.Memo = objRow[convqa_Push.Memo] == DBNull.Value ? null : objRow[convqa_Push.Memo].ToString().Trim(); //备注
objvqa_PushEN.IdCurrEduCls = objRow[convqa_Push.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Push.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PushEN.PdfContent = objRow[convqa_Push.PdfContent] == DBNull.Value ? null : objRow[convqa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvqa_PushEN.QaPaperId = objRow[convqa_Push.QaPaperId] == DBNull.Value ? null : objRow[convqa_Push.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PushEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsPublic].ToString().Trim()); //是否公开
objvqa_PushEN.PaperId = objRow[convqa_Push.PaperId] == DBNull.Value ? null : objRow[convqa_Push.PaperId].ToString().Trim(); //论文Id
objvqa_PushEN.PaperTitle = objRow[convqa_Push.PaperTitle] == DBNull.Value ? null : objRow[convqa_Push.PaperTitle].ToString().Trim(); //论文标题
objvqa_PushEN.PdfPageNum = objRow[convqa_Push.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_PushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsReply].ToString().Trim()); //是否回复
objvqa_PushEN.IsRequestReply = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvqa_PushEN.ReplyDate = objRow[convqa_Push.ReplyDate] == DBNull.Value ? null : objRow[convqa_Push.ReplyDate].ToString().Trim(); //回复日期
objvqa_PushEN.QuestionsTypeId = objRow[convqa_Push.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_PushEN.QuestionsTypeName = objRow[convqa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_PushEN.PushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_PushEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvqa_PushEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvqa_PushEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvqa_PushEN> arrObjLst = new List<clsvqa_PushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_PushEN objvqa_PushEN = new clsvqa_PushEN();
try
{
objvqa_PushEN.PushId = Int32.Parse(objRow[convqa_Push.PushId].ToString().Trim()); //推送d
objvqa_PushEN.QuestionsId = objRow[convqa_Push.QuestionsId].ToString().Trim(); //提问Id
objvqa_PushEN.QuestionsContent = objRow[convqa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvqa_PushEN.ReceiveUser = objRow[convqa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convqa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvqa_PushEN.ReceiveDate = objRow[convqa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convqa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvqa_PushEN.UserName = objRow[convqa_Push.UserName] == DBNull.Value ? null : objRow[convqa_Push.UserName].ToString().Trim(); //用户名
objvqa_PushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsReceive].ToString().Trim()); //是否接收
objvqa_PushEN.UpdDate = objRow[convqa_Push.UpdDate] == DBNull.Value ? null : objRow[convqa_Push.UpdDate].ToString().Trim(); //修改日期
objvqa_PushEN.AnswerCount = objRow[convqa_Push.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.AnswerCount].ToString().Trim()); //回答计数
objvqa_PushEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsEnd].ToString().Trim()); //是否结束
objvqa_PushEN.VoteCount = objRow[convqa_Push.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.VoteCount].ToString().Trim()); //点赞计数
objvqa_PushEN.Memo = objRow[convqa_Push.Memo] == DBNull.Value ? null : objRow[convqa_Push.Memo].ToString().Trim(); //备注
objvqa_PushEN.IdCurrEduCls = objRow[convqa_Push.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Push.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PushEN.PdfContent = objRow[convqa_Push.PdfContent] == DBNull.Value ? null : objRow[convqa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvqa_PushEN.QaPaperId = objRow[convqa_Push.QaPaperId] == DBNull.Value ? null : objRow[convqa_Push.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PushEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsPublic].ToString().Trim()); //是否公开
objvqa_PushEN.PaperId = objRow[convqa_Push.PaperId] == DBNull.Value ? null : objRow[convqa_Push.PaperId].ToString().Trim(); //论文Id
objvqa_PushEN.PaperTitle = objRow[convqa_Push.PaperTitle] == DBNull.Value ? null : objRow[convqa_Push.PaperTitle].ToString().Trim(); //论文标题
objvqa_PushEN.PdfPageNum = objRow[convqa_Push.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_PushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsReply].ToString().Trim()); //是否回复
objvqa_PushEN.IsRequestReply = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvqa_PushEN.ReplyDate = objRow[convqa_Push.ReplyDate] == DBNull.Value ? null : objRow[convqa_Push.ReplyDate].ToString().Trim(); //回复日期
objvqa_PushEN.QuestionsTypeId = objRow[convqa_Push.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_PushEN.QuestionsTypeName = objRow[convqa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_PushEN.PushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_PushEN);
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
public static List<clsvqa_PushEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvqa_PushEN> arrObjLst = new List<clsvqa_PushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_PushEN objvqa_PushEN = new clsvqa_PushEN();
try
{
objvqa_PushEN.PushId = Int32.Parse(objRow[convqa_Push.PushId].ToString().Trim()); //推送d
objvqa_PushEN.QuestionsId = objRow[convqa_Push.QuestionsId].ToString().Trim(); //提问Id
objvqa_PushEN.QuestionsContent = objRow[convqa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvqa_PushEN.ReceiveUser = objRow[convqa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convqa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvqa_PushEN.ReceiveDate = objRow[convqa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convqa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvqa_PushEN.UserName = objRow[convqa_Push.UserName] == DBNull.Value ? null : objRow[convqa_Push.UserName].ToString().Trim(); //用户名
objvqa_PushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsReceive].ToString().Trim()); //是否接收
objvqa_PushEN.UpdDate = objRow[convqa_Push.UpdDate] == DBNull.Value ? null : objRow[convqa_Push.UpdDate].ToString().Trim(); //修改日期
objvqa_PushEN.AnswerCount = objRow[convqa_Push.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.AnswerCount].ToString().Trim()); //回答计数
objvqa_PushEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsEnd].ToString().Trim()); //是否结束
objvqa_PushEN.VoteCount = objRow[convqa_Push.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.VoteCount].ToString().Trim()); //点赞计数
objvqa_PushEN.Memo = objRow[convqa_Push.Memo] == DBNull.Value ? null : objRow[convqa_Push.Memo].ToString().Trim(); //备注
objvqa_PushEN.IdCurrEduCls = objRow[convqa_Push.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Push.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PushEN.PdfContent = objRow[convqa_Push.PdfContent] == DBNull.Value ? null : objRow[convqa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvqa_PushEN.QaPaperId = objRow[convqa_Push.QaPaperId] == DBNull.Value ? null : objRow[convqa_Push.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PushEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsPublic].ToString().Trim()); //是否公开
objvqa_PushEN.PaperId = objRow[convqa_Push.PaperId] == DBNull.Value ? null : objRow[convqa_Push.PaperId].ToString().Trim(); //论文Id
objvqa_PushEN.PaperTitle = objRow[convqa_Push.PaperTitle] == DBNull.Value ? null : objRow[convqa_Push.PaperTitle].ToString().Trim(); //论文标题
objvqa_PushEN.PdfPageNum = objRow[convqa_Push.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_PushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsReply].ToString().Trim()); //是否回复
objvqa_PushEN.IsRequestReply = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvqa_PushEN.ReplyDate = objRow[convqa_Push.ReplyDate] == DBNull.Value ? null : objRow[convqa_Push.ReplyDate].ToString().Trim(); //回复日期
objvqa_PushEN.QuestionsTypeId = objRow[convqa_Push.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_PushEN.QuestionsTypeName = objRow[convqa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_PushEN.PushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_PushEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_PushEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvqa_PushEN> arrObjLst = new List<clsvqa_PushEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_PushEN objvqa_PushEN = new clsvqa_PushEN();
try
{
objvqa_PushEN.PushId = Int32.Parse(objRow[convqa_Push.PushId].ToString().Trim()); //推送d
objvqa_PushEN.QuestionsId = objRow[convqa_Push.QuestionsId].ToString().Trim(); //提问Id
objvqa_PushEN.QuestionsContent = objRow[convqa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvqa_PushEN.ReceiveUser = objRow[convqa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convqa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvqa_PushEN.ReceiveDate = objRow[convqa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convqa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvqa_PushEN.UserName = objRow[convqa_Push.UserName] == DBNull.Value ? null : objRow[convqa_Push.UserName].ToString().Trim(); //用户名
objvqa_PushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsReceive].ToString().Trim()); //是否接收
objvqa_PushEN.UpdDate = objRow[convqa_Push.UpdDate] == DBNull.Value ? null : objRow[convqa_Push.UpdDate].ToString().Trim(); //修改日期
objvqa_PushEN.AnswerCount = objRow[convqa_Push.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.AnswerCount].ToString().Trim()); //回答计数
objvqa_PushEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsEnd].ToString().Trim()); //是否结束
objvqa_PushEN.VoteCount = objRow[convqa_Push.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.VoteCount].ToString().Trim()); //点赞计数
objvqa_PushEN.Memo = objRow[convqa_Push.Memo] == DBNull.Value ? null : objRow[convqa_Push.Memo].ToString().Trim(); //备注
objvqa_PushEN.IdCurrEduCls = objRow[convqa_Push.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Push.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PushEN.PdfContent = objRow[convqa_Push.PdfContent] == DBNull.Value ? null : objRow[convqa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvqa_PushEN.QaPaperId = objRow[convqa_Push.QaPaperId] == DBNull.Value ? null : objRow[convqa_Push.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PushEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsPublic].ToString().Trim()); //是否公开
objvqa_PushEN.PaperId = objRow[convqa_Push.PaperId] == DBNull.Value ? null : objRow[convqa_Push.PaperId].ToString().Trim(); //论文Id
objvqa_PushEN.PaperTitle = objRow[convqa_Push.PaperTitle] == DBNull.Value ? null : objRow[convqa_Push.PaperTitle].ToString().Trim(); //论文标题
objvqa_PushEN.PdfPageNum = objRow[convqa_Push.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvqa_PushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsReply].ToString().Trim()); //是否回复
objvqa_PushEN.IsRequestReply = clsEntityBase2.TransNullToBool_S(objRow[convqa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvqa_PushEN.ReplyDate = objRow[convqa_Push.ReplyDate] == DBNull.Value ? null : objRow[convqa_Push.ReplyDate].ToString().Trim(); //回复日期
objvqa_PushEN.QuestionsTypeId = objRow[convqa_Push.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_PushEN.QuestionsTypeName = objRow[convqa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_PushEN.PushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_PushEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvqa_PushEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvqa_Push(ref clsvqa_PushEN objvqa_PushEN)
{
bool bolResult = vqa_PushDA.Getvqa_Push(ref objvqa_PushEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngPushId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvqa_PushEN GetObjByPushId(long lngPushId)
{
clsvqa_PushEN objvqa_PushEN = vqa_PushDA.GetObjByPushId(lngPushId);
return objvqa_PushEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvqa_PushEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvqa_PushEN objvqa_PushEN = vqa_PushDA.GetFirstObj(strWhereCond);
 return objvqa_PushEN;
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
public static clsvqa_PushEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvqa_PushEN objvqa_PushEN = vqa_PushDA.GetObjByDataRow(objRow);
 return objvqa_PushEN;
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
public static clsvqa_PushEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvqa_PushEN objvqa_PushEN = vqa_PushDA.GetObjByDataRow(objRow);
 return objvqa_PushEN;
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
 /// <param name = "lngPushId">所给的关键字</param>
 /// <param name = "lstvqa_PushObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvqa_PushEN GetObjByPushIdFromList(long lngPushId, List<clsvqa_PushEN> lstvqa_PushObjLst)
{
foreach (clsvqa_PushEN objvqa_PushEN in lstvqa_PushObjLst)
{
if (objvqa_PushEN.PushId == lngPushId)
{
return objvqa_PushEN;
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
 long lngPushId;
 try
 {
 lngPushId = new clsvqa_PushDA().GetFirstID(strWhereCond);
 return lngPushId;
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
 arrList = vqa_PushDA.GetID(strWhereCond);
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
bool bolIsExist = vqa_PushDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngPushId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngPushId)
{
//检测记录是否存在
bool bolIsExist = vqa_PushDA.IsExist(lngPushId);
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
 bolIsExist = clsvqa_PushDA.IsExistTable();
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
 bolIsExist = vqa_PushDA.IsExistTable(strTabName);
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
objvqa_PushENT.IdCurrEduCls = objvqa_PushENS.IdCurrEduCls; //教学班流水号
objvqa_PushENT.PdfContent = objvqa_PushENS.PdfContent; //Pdf内容
objvqa_PushENT.QaPaperId = objvqa_PushENS.QaPaperId; //论文答疑Id
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
 /// <param name = "objvqa_PushEN">源简化对象</param>
 public static void SetUpdFlag(clsvqa_PushEN objvqa_PushEN)
{
try
{
objvqa_PushEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvqa_PushEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convqa_Push.PushId, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.PushId = objvqa_PushEN.PushId; //推送d
}
if (arrFldSet.Contains(convqa_Push.QuestionsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.QuestionsId = objvqa_PushEN.QuestionsId; //提问Id
}
if (arrFldSet.Contains(convqa_Push.QuestionsContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.QuestionsContent = objvqa_PushEN.QuestionsContent == "[null]" ? null :  objvqa_PushEN.QuestionsContent; //提问内容
}
if (arrFldSet.Contains(convqa_Push.ReceiveUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.ReceiveUser = objvqa_PushEN.ReceiveUser == "[null]" ? null :  objvqa_PushEN.ReceiveUser; //接收用户
}
if (arrFldSet.Contains(convqa_Push.ReceiveDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.ReceiveDate = objvqa_PushEN.ReceiveDate == "[null]" ? null :  objvqa_PushEN.ReceiveDate; //接收日期
}
if (arrFldSet.Contains(convqa_Push.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.UserName = objvqa_PushEN.UserName == "[null]" ? null :  objvqa_PushEN.UserName; //用户名
}
if (arrFldSet.Contains(convqa_Push.IsReceive, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.IsReceive = objvqa_PushEN.IsReceive; //是否接收
}
if (arrFldSet.Contains(convqa_Push.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.UpdDate = objvqa_PushEN.UpdDate == "[null]" ? null :  objvqa_PushEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convqa_Push.AnswerCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.AnswerCount = objvqa_PushEN.AnswerCount; //回答计数
}
if (arrFldSet.Contains(convqa_Push.IsEnd, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.IsEnd = objvqa_PushEN.IsEnd; //是否结束
}
if (arrFldSet.Contains(convqa_Push.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.VoteCount = objvqa_PushEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(convqa_Push.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.Memo = objvqa_PushEN.Memo == "[null]" ? null :  objvqa_PushEN.Memo; //备注
}
if (arrFldSet.Contains(convqa_Push.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.IdCurrEduCls = objvqa_PushEN.IdCurrEduCls == "[null]" ? null :  objvqa_PushEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convqa_Push.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.PdfContent = objvqa_PushEN.PdfContent == "[null]" ? null :  objvqa_PushEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(convqa_Push.QaPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.QaPaperId = objvqa_PushEN.QaPaperId == "[null]" ? null :  objvqa_PushEN.QaPaperId; //论文答疑Id
}
if (arrFldSet.Contains(convqa_Push.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.IsPublic = objvqa_PushEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(convqa_Push.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.PaperId = objvqa_PushEN.PaperId == "[null]" ? null :  objvqa_PushEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convqa_Push.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.PaperTitle = objvqa_PushEN.PaperTitle == "[null]" ? null :  objvqa_PushEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convqa_Push.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.PdfPageNum = objvqa_PushEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(convqa_Push.IsReply, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.IsReply = objvqa_PushEN.IsReply; //是否回复
}
if (arrFldSet.Contains(convqa_Push.IsRequestReply, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.IsRequestReply = objvqa_PushEN.IsRequestReply; //是否要求回复
}
if (arrFldSet.Contains(convqa_Push.ReplyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.ReplyDate = objvqa_PushEN.ReplyDate == "[null]" ? null :  objvqa_PushEN.ReplyDate; //回复日期
}
if (arrFldSet.Contains(convqa_Push.QuestionsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.QuestionsTypeId = objvqa_PushEN.QuestionsTypeId == "[null]" ? null :  objvqa_PushEN.QuestionsTypeId; //问题类型Id
}
if (arrFldSet.Contains(convqa_Push.QuestionsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PushEN.QuestionsTypeName = objvqa_PushEN.QuestionsTypeName == "[null]" ? null :  objvqa_PushEN.QuestionsTypeName; //问题类型名称
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
 /// <param name = "objvqa_PushEN">源简化对象</param>
 public static void AccessFldValueNull(clsvqa_PushEN objvqa_PushEN)
{
try
{
if (objvqa_PushEN.QuestionsContent == "[null]") objvqa_PushEN.QuestionsContent = null; //提问内容
if (objvqa_PushEN.ReceiveUser == "[null]") objvqa_PushEN.ReceiveUser = null; //接收用户
if (objvqa_PushEN.ReceiveDate == "[null]") objvqa_PushEN.ReceiveDate = null; //接收日期
if (objvqa_PushEN.UserName == "[null]") objvqa_PushEN.UserName = null; //用户名
if (objvqa_PushEN.UpdDate == "[null]") objvqa_PushEN.UpdDate = null; //修改日期
if (objvqa_PushEN.Memo == "[null]") objvqa_PushEN.Memo = null; //备注
if (objvqa_PushEN.IdCurrEduCls == "[null]") objvqa_PushEN.IdCurrEduCls = null; //教学班流水号
if (objvqa_PushEN.PdfContent == "[null]") objvqa_PushEN.PdfContent = null; //Pdf内容
if (objvqa_PushEN.QaPaperId == "[null]") objvqa_PushEN.QaPaperId = null; //论文答疑Id
if (objvqa_PushEN.PaperId == "[null]") objvqa_PushEN.PaperId = null; //论文Id
if (objvqa_PushEN.PaperTitle == "[null]") objvqa_PushEN.PaperTitle = null; //论文标题
if (objvqa_PushEN.ReplyDate == "[null]") objvqa_PushEN.ReplyDate = null; //回复日期
if (objvqa_PushEN.QuestionsTypeId == "[null]") objvqa_PushEN.QuestionsTypeId = null; //问题类型Id
if (objvqa_PushEN.QuestionsTypeName == "[null]") objvqa_PushEN.QuestionsTypeName = null; //问题类型名称
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
public static void CheckProperty4Condition(clsvqa_PushEN objvqa_PushEN)
{
 vqa_PushDA.CheckProperty4Condition(objvqa_PushEN);
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
if (clsqa_PushBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_PushBL没有刷新缓存机制(clsqa_PushBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
//string strWhereCond = string.Format("1 = 1 order by PushId");
//if (arrvqa_PushObjLstCache == null)
//{
//arrvqa_PushObjLstCache = vqa_PushDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngPushId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvqa_PushEN GetObjByPushIdCache(long lngPushId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvqa_PushEN._CurrTabName);
List<clsvqa_PushEN> arrvqa_PushObjLstCache = GetObjLstCache();
IEnumerable <clsvqa_PushEN> arrvqa_PushObjLst_Sel =
arrvqa_PushObjLstCache
.Where(x=> x.PushId == lngPushId 
);
if (arrvqa_PushObjLst_Sel.Count() == 0)
{
   clsvqa_PushEN obj = clsvqa_PushBL.GetObjByPushId(lngPushId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvqa_PushObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvqa_PushEN> GetAllvqa_PushObjLstCache()
{
//获取缓存中的对象列表
List<clsvqa_PushEN> arrvqa_PushObjLstCache = GetObjLstCache(); 
return arrvqa_PushObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvqa_PushEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvqa_PushEN._CurrTabName);
List<clsvqa_PushEN> arrvqa_PushObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvqa_PushObjLstCache;
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
string strKey = string.Format("{0}", clsvqa_PushEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngPushId)
{
if (strInFldName != convqa_Push.PushId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convqa_Push.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convqa_Push.AttributeName));
throw new Exception(strMsg);
}
var objvqa_Push = clsvqa_PushBL.GetObjByPushIdCache(lngPushId);
if (objvqa_Push == null) return "";
return objvqa_Push[strOutFldName].ToString();
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
int intRecCount = clsvqa_PushDA.GetRecCount(strTabName);
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
int intRecCount = clsvqa_PushDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvqa_PushDA.GetRecCount();
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
int intRecCount = clsvqa_PushDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvqa_PushCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvqa_PushEN objvqa_PushCond)
{
List<clsvqa_PushEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvqa_PushEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convqa_Push.AttributeName)
{
if (objvqa_PushCond.IsUpdated(strFldName) == false) continue;
if (objvqa_PushCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvqa_PushCond[strFldName].ToString());
}
else
{
if (objvqa_PushCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvqa_PushCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvqa_PushCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvqa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvqa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvqa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvqa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvqa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvqa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvqa_PushCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvqa_PushCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvqa_PushCond[strFldName]));
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
 List<string> arrList = clsvqa_PushDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vqa_PushDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vqa_PushDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}