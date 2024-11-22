
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_qa_PushBL
 表名:vzx_qa_Push(01120850)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:13:58
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
public static class  clsvzx_qa_PushBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngPushId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_qa_PushEN GetObj(this K_PushId_vzx_qa_Push myKey)
{
clsvzx_qa_PushEN objvzx_qa_PushEN = clsvzx_qa_PushBL.vzx_qa_PushDA.GetObjByPushId(myKey.Value);
return objvzx_qa_PushEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PushEN SetPushId(this clsvzx_qa_PushEN objvzx_qa_PushEN, long lngPushId, string strComparisonOp="")
	{
objvzx_qa_PushEN.PushId = lngPushId; //推送d
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PushEN.dicFldComparisonOp.ContainsKey(convzx_qa_Push.PushId) == false)
{
objvzx_qa_PushEN.dicFldComparisonOp.Add(convzx_qa_Push.PushId, strComparisonOp);
}
else
{
objvzx_qa_PushEN.dicFldComparisonOp[convzx_qa_Push.PushId] = strComparisonOp;
}
}
return objvzx_qa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PushEN SetzxQuestionsId(this clsvzx_qa_PushEN objvzx_qa_PushEN, string strzxQuestionsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxQuestionsId, convzx_qa_Push.zxQuestionsId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxQuestionsId, 8, convzx_qa_Push.zxQuestionsId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxQuestionsId, 8, convzx_qa_Push.zxQuestionsId);
}
objvzx_qa_PushEN.zxQuestionsId = strzxQuestionsId; //提问Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PushEN.dicFldComparisonOp.ContainsKey(convzx_qa_Push.zxQuestionsId) == false)
{
objvzx_qa_PushEN.dicFldComparisonOp.Add(convzx_qa_Push.zxQuestionsId, strComparisonOp);
}
else
{
objvzx_qa_PushEN.dicFldComparisonOp[convzx_qa_Push.zxQuestionsId] = strComparisonOp;
}
}
return objvzx_qa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PushEN SetReceiveUser(this clsvzx_qa_PushEN objvzx_qa_PushEN, string strReceiveUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReceiveUser, 20, convzx_qa_Push.ReceiveUser);
}
objvzx_qa_PushEN.ReceiveUser = strReceiveUser; //接收用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PushEN.dicFldComparisonOp.ContainsKey(convzx_qa_Push.ReceiveUser) == false)
{
objvzx_qa_PushEN.dicFldComparisonOp.Add(convzx_qa_Push.ReceiveUser, strComparisonOp);
}
else
{
objvzx_qa_PushEN.dicFldComparisonOp[convzx_qa_Push.ReceiveUser] = strComparisonOp;
}
}
return objvzx_qa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PushEN SetReceiveDate(this clsvzx_qa_PushEN objvzx_qa_PushEN, string strReceiveDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReceiveDate, 20, convzx_qa_Push.ReceiveDate);
}
objvzx_qa_PushEN.ReceiveDate = strReceiveDate; //接收日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PushEN.dicFldComparisonOp.ContainsKey(convzx_qa_Push.ReceiveDate) == false)
{
objvzx_qa_PushEN.dicFldComparisonOp.Add(convzx_qa_Push.ReceiveDate, strComparisonOp);
}
else
{
objvzx_qa_PushEN.dicFldComparisonOp[convzx_qa_Push.ReceiveDate] = strComparisonOp;
}
}
return objvzx_qa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PushEN SetIsReceive(this clsvzx_qa_PushEN objvzx_qa_PushEN, bool bolIsReceive, string strComparisonOp="")
	{
objvzx_qa_PushEN.IsReceive = bolIsReceive; //是否接收
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PushEN.dicFldComparisonOp.ContainsKey(convzx_qa_Push.IsReceive) == false)
{
objvzx_qa_PushEN.dicFldComparisonOp.Add(convzx_qa_Push.IsReceive, strComparisonOp);
}
else
{
objvzx_qa_PushEN.dicFldComparisonOp[convzx_qa_Push.IsReceive] = strComparisonOp;
}
}
return objvzx_qa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PushEN SetUpdDate(this clsvzx_qa_PushEN objvzx_qa_PushEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_qa_Push.UpdDate);
}
objvzx_qa_PushEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PushEN.dicFldComparisonOp.ContainsKey(convzx_qa_Push.UpdDate) == false)
{
objvzx_qa_PushEN.dicFldComparisonOp.Add(convzx_qa_Push.UpdDate, strComparisonOp);
}
else
{
objvzx_qa_PushEN.dicFldComparisonOp[convzx_qa_Push.UpdDate] = strComparisonOp;
}
}
return objvzx_qa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PushEN SetMemo(this clsvzx_qa_PushEN objvzx_qa_PushEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_qa_Push.Memo);
}
objvzx_qa_PushEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PushEN.dicFldComparisonOp.ContainsKey(convzx_qa_Push.Memo) == false)
{
objvzx_qa_PushEN.dicFldComparisonOp.Add(convzx_qa_Push.Memo, strComparisonOp);
}
else
{
objvzx_qa_PushEN.dicFldComparisonOp[convzx_qa_Push.Memo] = strComparisonOp;
}
}
return objvzx_qa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PushEN SetIsReply(this clsvzx_qa_PushEN objvzx_qa_PushEN, bool bolIsReply, string strComparisonOp="")
	{
objvzx_qa_PushEN.IsReply = bolIsReply; //是否回复
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PushEN.dicFldComparisonOp.ContainsKey(convzx_qa_Push.IsReply) == false)
{
objvzx_qa_PushEN.dicFldComparisonOp.Add(convzx_qa_Push.IsReply, strComparisonOp);
}
else
{
objvzx_qa_PushEN.dicFldComparisonOp[convzx_qa_Push.IsReply] = strComparisonOp;
}
}
return objvzx_qa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PushEN SetIsRequestReply(this clsvzx_qa_PushEN objvzx_qa_PushEN, bool bolIsRequestReply, string strComparisonOp="")
	{
objvzx_qa_PushEN.IsRequestReply = bolIsRequestReply; //是否要求回复
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PushEN.dicFldComparisonOp.ContainsKey(convzx_qa_Push.IsRequestReply) == false)
{
objvzx_qa_PushEN.dicFldComparisonOp.Add(convzx_qa_Push.IsRequestReply, strComparisonOp);
}
else
{
objvzx_qa_PushEN.dicFldComparisonOp[convzx_qa_Push.IsRequestReply] = strComparisonOp;
}
}
return objvzx_qa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PushEN SetReplyDate(this clsvzx_qa_PushEN objvzx_qa_PushEN, string strReplyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReplyDate, 20, convzx_qa_Push.ReplyDate);
}
objvzx_qa_PushEN.ReplyDate = strReplyDate; //回复日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PushEN.dicFldComparisonOp.ContainsKey(convzx_qa_Push.ReplyDate) == false)
{
objvzx_qa_PushEN.dicFldComparisonOp.Add(convzx_qa_Push.ReplyDate, strComparisonOp);
}
else
{
objvzx_qa_PushEN.dicFldComparisonOp[convzx_qa_Push.ReplyDate] = strComparisonOp;
}
}
return objvzx_qa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PushEN SetTextTitle(this clsvzx_qa_PushEN objvzx_qa_PushEN, string strTextTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextTitle, 500, convzx_qa_Push.TextTitle);
}
objvzx_qa_PushEN.TextTitle = strTextTitle; //TextTitle
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PushEN.dicFldComparisonOp.ContainsKey(convzx_qa_Push.TextTitle) == false)
{
objvzx_qa_PushEN.dicFldComparisonOp.Add(convzx_qa_Push.TextTitle, strComparisonOp);
}
else
{
objvzx_qa_PushEN.dicFldComparisonOp[convzx_qa_Push.TextTitle] = strComparisonOp;
}
}
return objvzx_qa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PushEN SetUserName(this clsvzx_qa_PushEN objvzx_qa_PushEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convzx_qa_Push.UserName);
}
objvzx_qa_PushEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PushEN.dicFldComparisonOp.ContainsKey(convzx_qa_Push.UserName) == false)
{
objvzx_qa_PushEN.dicFldComparisonOp.Add(convzx_qa_Push.UserName, strComparisonOp);
}
else
{
objvzx_qa_PushEN.dicFldComparisonOp[convzx_qa_Push.UserName] = strComparisonOp;
}
}
return objvzx_qa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PushEN SetQuestionsTypeName(this clsvzx_qa_PushEN objvzx_qa_PushEN, string strQuestionsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsTypeName, 50, convzx_qa_Push.QuestionsTypeName);
}
objvzx_qa_PushEN.QuestionsTypeName = strQuestionsTypeName; //问题类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PushEN.dicFldComparisonOp.ContainsKey(convzx_qa_Push.QuestionsTypeName) == false)
{
objvzx_qa_PushEN.dicFldComparisonOp.Add(convzx_qa_Push.QuestionsTypeName, strComparisonOp);
}
else
{
objvzx_qa_PushEN.dicFldComparisonOp[convzx_qa_Push.QuestionsTypeName] = strComparisonOp;
}
}
return objvzx_qa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PushEN SetIsPublic(this clsvzx_qa_PushEN objvzx_qa_PushEN, bool bolIsPublic, string strComparisonOp="")
	{
objvzx_qa_PushEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PushEN.dicFldComparisonOp.ContainsKey(convzx_qa_Push.IsPublic) == false)
{
objvzx_qa_PushEN.dicFldComparisonOp.Add(convzx_qa_Push.IsPublic, strComparisonOp);
}
else
{
objvzx_qa_PushEN.dicFldComparisonOp[convzx_qa_Push.IsPublic] = strComparisonOp;
}
}
return objvzx_qa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PushEN SetzxQuestionsTypeId(this clsvzx_qa_PushEN objvzx_qa_PushEN, string strzxQuestionsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxQuestionsTypeId, 2, convzx_qa_Push.zxQuestionsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxQuestionsTypeId, 2, convzx_qa_Push.zxQuestionsTypeId);
}
objvzx_qa_PushEN.zxQuestionsTypeId = strzxQuestionsTypeId; //问题类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PushEN.dicFldComparisonOp.ContainsKey(convzx_qa_Push.zxQuestionsTypeId) == false)
{
objvzx_qa_PushEN.dicFldComparisonOp.Add(convzx_qa_Push.zxQuestionsTypeId, strComparisonOp);
}
else
{
objvzx_qa_PushEN.dicFldComparisonOp[convzx_qa_Push.zxQuestionsTypeId] = strComparisonOp;
}
}
return objvzx_qa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PushEN SetQuestionsContent(this clsvzx_qa_PushEN objvzx_qa_PushEN, string strQuestionsContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsContent, 1000, convzx_qa_Push.QuestionsContent);
}
objvzx_qa_PushEN.QuestionsContent = strQuestionsContent; //提问内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PushEN.dicFldComparisonOp.ContainsKey(convzx_qa_Push.QuestionsContent) == false)
{
objvzx_qa_PushEN.dicFldComparisonOp.Add(convzx_qa_Push.QuestionsContent, strComparisonOp);
}
else
{
objvzx_qa_PushEN.dicFldComparisonOp[convzx_qa_Push.QuestionsContent] = strComparisonOp;
}
}
return objvzx_qa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PushEN SetPdfPageNum(this clsvzx_qa_PushEN objvzx_qa_PushEN, int? intPdfPageNum, string strComparisonOp="")
	{
objvzx_qa_PushEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PushEN.dicFldComparisonOp.ContainsKey(convzx_qa_Push.PdfPageNum) == false)
{
objvzx_qa_PushEN.dicFldComparisonOp.Add(convzx_qa_Push.PdfPageNum, strComparisonOp);
}
else
{
objvzx_qa_PushEN.dicFldComparisonOp[convzx_qa_Push.PdfPageNum] = strComparisonOp;
}
}
return objvzx_qa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PushEN SetPdfContent(this clsvzx_qa_PushEN objvzx_qa_PushEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convzx_qa_Push.PdfContent);
}
objvzx_qa_PushEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PushEN.dicFldComparisonOp.ContainsKey(convzx_qa_Push.PdfContent) == false)
{
objvzx_qa_PushEN.dicFldComparisonOp.Add(convzx_qa_Push.PdfContent, strComparisonOp);
}
else
{
objvzx_qa_PushEN.dicFldComparisonOp[convzx_qa_Push.PdfContent] = strComparisonOp;
}
}
return objvzx_qa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PushEN SetIsEnd(this clsvzx_qa_PushEN objvzx_qa_PushEN, bool bolIsEnd, string strComparisonOp="")
	{
objvzx_qa_PushEN.IsEnd = bolIsEnd; //是否结束
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PushEN.dicFldComparisonOp.ContainsKey(convzx_qa_Push.IsEnd) == false)
{
objvzx_qa_PushEN.dicFldComparisonOp.Add(convzx_qa_Push.IsEnd, strComparisonOp);
}
else
{
objvzx_qa_PushEN.dicFldComparisonOp[convzx_qa_Push.IsEnd] = strComparisonOp;
}
}
return objvzx_qa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PushEN SetVoteCount(this clsvzx_qa_PushEN objvzx_qa_PushEN, int? intVoteCount, string strComparisonOp="")
	{
objvzx_qa_PushEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PushEN.dicFldComparisonOp.ContainsKey(convzx_qa_Push.VoteCount) == false)
{
objvzx_qa_PushEN.dicFldComparisonOp.Add(convzx_qa_Push.VoteCount, strComparisonOp);
}
else
{
objvzx_qa_PushEN.dicFldComparisonOp[convzx_qa_Push.VoteCount] = strComparisonOp;
}
}
return objvzx_qa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PushEN SetAnswerCount(this clsvzx_qa_PushEN objvzx_qa_PushEN, int? intAnswerCount, string strComparisonOp="")
	{
objvzx_qa_PushEN.AnswerCount = intAnswerCount; //回答计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PushEN.dicFldComparisonOp.ContainsKey(convzx_qa_Push.AnswerCount) == false)
{
objvzx_qa_PushEN.dicFldComparisonOp.Add(convzx_qa_Push.AnswerCount, strComparisonOp);
}
else
{
objvzx_qa_PushEN.dicFldComparisonOp[convzx_qa_Push.AnswerCount] = strComparisonOp;
}
}
return objvzx_qa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PushEN SetTextId(this clsvzx_qa_PushEN objvzx_qa_PushEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, convzx_qa_Push.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, convzx_qa_Push.TextId);
}
objvzx_qa_PushEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PushEN.dicFldComparisonOp.ContainsKey(convzx_qa_Push.TextId) == false)
{
objvzx_qa_PushEN.dicFldComparisonOp.Add(convzx_qa_Push.TextId, strComparisonOp);
}
else
{
objvzx_qa_PushEN.dicFldComparisonOp[convzx_qa_Push.TextId] = strComparisonOp;
}
}
return objvzx_qa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PushEN SetZxqaPaperId(this clsvzx_qa_PushEN objvzx_qa_PushEN, string strZxqaPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strZxqaPaperId, 8, convzx_qa_Push.ZxqaPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strZxqaPaperId, 8, convzx_qa_Push.ZxqaPaperId);
}
objvzx_qa_PushEN.ZxqaPaperId = strZxqaPaperId; //论文答疑Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PushEN.dicFldComparisonOp.ContainsKey(convzx_qa_Push.ZxqaPaperId) == false)
{
objvzx_qa_PushEN.dicFldComparisonOp.Add(convzx_qa_Push.ZxqaPaperId, strComparisonOp);
}
else
{
objvzx_qa_PushEN.dicFldComparisonOp[convzx_qa_Push.ZxqaPaperId] = strComparisonOp;
}
}
return objvzx_qa_PushEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_qa_PushENS">源对象</param>
 /// <param name = "objvzx_qa_PushENT">目标对象</param>
 public static void CopyTo(this clsvzx_qa_PushEN objvzx_qa_PushENS, clsvzx_qa_PushEN objvzx_qa_PushENT)
{
try
{
objvzx_qa_PushENT.PushId = objvzx_qa_PushENS.PushId; //推送d
objvzx_qa_PushENT.zxQuestionsId = objvzx_qa_PushENS.zxQuestionsId; //提问Id
objvzx_qa_PushENT.ReceiveUser = objvzx_qa_PushENS.ReceiveUser; //接收用户
objvzx_qa_PushENT.ReceiveDate = objvzx_qa_PushENS.ReceiveDate; //接收日期
objvzx_qa_PushENT.IsReceive = objvzx_qa_PushENS.IsReceive; //是否接收
objvzx_qa_PushENT.UpdDate = objvzx_qa_PushENS.UpdDate; //修改日期
objvzx_qa_PushENT.Memo = objvzx_qa_PushENS.Memo; //备注
objvzx_qa_PushENT.IsReply = objvzx_qa_PushENS.IsReply; //是否回复
objvzx_qa_PushENT.IsRequestReply = objvzx_qa_PushENS.IsRequestReply; //是否要求回复
objvzx_qa_PushENT.ReplyDate = objvzx_qa_PushENS.ReplyDate; //回复日期
objvzx_qa_PushENT.TextTitle = objvzx_qa_PushENS.TextTitle; //TextTitle
objvzx_qa_PushENT.UserName = objvzx_qa_PushENS.UserName; //用户名
objvzx_qa_PushENT.QuestionsTypeName = objvzx_qa_PushENS.QuestionsTypeName; //问题类型名称
objvzx_qa_PushENT.IsPublic = objvzx_qa_PushENS.IsPublic; //是否公开
objvzx_qa_PushENT.zxQuestionsTypeId = objvzx_qa_PushENS.zxQuestionsTypeId; //问题类型Id
objvzx_qa_PushENT.QuestionsContent = objvzx_qa_PushENS.QuestionsContent; //提问内容
objvzx_qa_PushENT.PdfPageNum = objvzx_qa_PushENS.PdfPageNum; //Pdf页码
objvzx_qa_PushENT.PdfContent = objvzx_qa_PushENS.PdfContent; //Pdf内容
objvzx_qa_PushENT.IsEnd = objvzx_qa_PushENS.IsEnd; //是否结束
objvzx_qa_PushENT.VoteCount = objvzx_qa_PushENS.VoteCount; //点赞计数
objvzx_qa_PushENT.AnswerCount = objvzx_qa_PushENS.AnswerCount; //回答计数
objvzx_qa_PushENT.TextId = objvzx_qa_PushENS.TextId; //课件Id
objvzx_qa_PushENT.ZxqaPaperId = objvzx_qa_PushENS.ZxqaPaperId; //论文答疑Id
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
 /// <param name = "objvzx_qa_PushENS">源对象</param>
 /// <returns>目标对象=>clsvzx_qa_PushEN:objvzx_qa_PushENT</returns>
 public static clsvzx_qa_PushEN CopyTo(this clsvzx_qa_PushEN objvzx_qa_PushENS)
{
try
{
 clsvzx_qa_PushEN objvzx_qa_PushENT = new clsvzx_qa_PushEN()
{
PushId = objvzx_qa_PushENS.PushId, //推送d
zxQuestionsId = objvzx_qa_PushENS.zxQuestionsId, //提问Id
ReceiveUser = objvzx_qa_PushENS.ReceiveUser, //接收用户
ReceiveDate = objvzx_qa_PushENS.ReceiveDate, //接收日期
IsReceive = objvzx_qa_PushENS.IsReceive, //是否接收
UpdDate = objvzx_qa_PushENS.UpdDate, //修改日期
Memo = objvzx_qa_PushENS.Memo, //备注
IsReply = objvzx_qa_PushENS.IsReply, //是否回复
IsRequestReply = objvzx_qa_PushENS.IsRequestReply, //是否要求回复
ReplyDate = objvzx_qa_PushENS.ReplyDate, //回复日期
TextTitle = objvzx_qa_PushENS.TextTitle, //TextTitle
UserName = objvzx_qa_PushENS.UserName, //用户名
QuestionsTypeName = objvzx_qa_PushENS.QuestionsTypeName, //问题类型名称
IsPublic = objvzx_qa_PushENS.IsPublic, //是否公开
zxQuestionsTypeId = objvzx_qa_PushENS.zxQuestionsTypeId, //问题类型Id
QuestionsContent = objvzx_qa_PushENS.QuestionsContent, //提问内容
PdfPageNum = objvzx_qa_PushENS.PdfPageNum, //Pdf页码
PdfContent = objvzx_qa_PushENS.PdfContent, //Pdf内容
IsEnd = objvzx_qa_PushENS.IsEnd, //是否结束
VoteCount = objvzx_qa_PushENS.VoteCount, //点赞计数
AnswerCount = objvzx_qa_PushENS.AnswerCount, //回答计数
TextId = objvzx_qa_PushENS.TextId, //课件Id
ZxqaPaperId = objvzx_qa_PushENS.ZxqaPaperId, //论文答疑Id
};
 return objvzx_qa_PushENT;
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
public static void CheckProperty4Condition(this clsvzx_qa_PushEN objvzx_qa_PushEN)
{
 clsvzx_qa_PushBL.vzx_qa_PushDA.CheckProperty4Condition(objvzx_qa_PushEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_qa_PushEN objvzx_qa_PushCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_qa_PushCond.IsUpdated(convzx_qa_Push.PushId) == true)
{
string strComparisonOpPushId = objvzx_qa_PushCond.dicFldComparisonOp[convzx_qa_Push.PushId];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_qa_Push.PushId, objvzx_qa_PushCond.PushId, strComparisonOpPushId);
}
if (objvzx_qa_PushCond.IsUpdated(convzx_qa_Push.zxQuestionsId) == true)
{
string strComparisonOpzxQuestionsId = objvzx_qa_PushCond.dicFldComparisonOp[convzx_qa_Push.zxQuestionsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Push.zxQuestionsId, objvzx_qa_PushCond.zxQuestionsId, strComparisonOpzxQuestionsId);
}
if (objvzx_qa_PushCond.IsUpdated(convzx_qa_Push.ReceiveUser) == true)
{
string strComparisonOpReceiveUser = objvzx_qa_PushCond.dicFldComparisonOp[convzx_qa_Push.ReceiveUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Push.ReceiveUser, objvzx_qa_PushCond.ReceiveUser, strComparisonOpReceiveUser);
}
if (objvzx_qa_PushCond.IsUpdated(convzx_qa_Push.ReceiveDate) == true)
{
string strComparisonOpReceiveDate = objvzx_qa_PushCond.dicFldComparisonOp[convzx_qa_Push.ReceiveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Push.ReceiveDate, objvzx_qa_PushCond.ReceiveDate, strComparisonOpReceiveDate);
}
if (objvzx_qa_PushCond.IsUpdated(convzx_qa_Push.IsReceive) == true)
{
if (objvzx_qa_PushCond.IsReceive == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_qa_Push.IsReceive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_qa_Push.IsReceive);
}
}
if (objvzx_qa_PushCond.IsUpdated(convzx_qa_Push.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_qa_PushCond.dicFldComparisonOp[convzx_qa_Push.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Push.UpdDate, objvzx_qa_PushCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_qa_PushCond.IsUpdated(convzx_qa_Push.Memo) == true)
{
string strComparisonOpMemo = objvzx_qa_PushCond.dicFldComparisonOp[convzx_qa_Push.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Push.Memo, objvzx_qa_PushCond.Memo, strComparisonOpMemo);
}
if (objvzx_qa_PushCond.IsUpdated(convzx_qa_Push.IsReply) == true)
{
if (objvzx_qa_PushCond.IsReply == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_qa_Push.IsReply);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_qa_Push.IsReply);
}
}
if (objvzx_qa_PushCond.IsUpdated(convzx_qa_Push.IsRequestReply) == true)
{
if (objvzx_qa_PushCond.IsRequestReply == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_qa_Push.IsRequestReply);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_qa_Push.IsRequestReply);
}
}
if (objvzx_qa_PushCond.IsUpdated(convzx_qa_Push.ReplyDate) == true)
{
string strComparisonOpReplyDate = objvzx_qa_PushCond.dicFldComparisonOp[convzx_qa_Push.ReplyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Push.ReplyDate, objvzx_qa_PushCond.ReplyDate, strComparisonOpReplyDate);
}
if (objvzx_qa_PushCond.IsUpdated(convzx_qa_Push.TextTitle) == true)
{
string strComparisonOpTextTitle = objvzx_qa_PushCond.dicFldComparisonOp[convzx_qa_Push.TextTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Push.TextTitle, objvzx_qa_PushCond.TextTitle, strComparisonOpTextTitle);
}
if (objvzx_qa_PushCond.IsUpdated(convzx_qa_Push.UserName) == true)
{
string strComparisonOpUserName = objvzx_qa_PushCond.dicFldComparisonOp[convzx_qa_Push.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Push.UserName, objvzx_qa_PushCond.UserName, strComparisonOpUserName);
}
if (objvzx_qa_PushCond.IsUpdated(convzx_qa_Push.QuestionsTypeName) == true)
{
string strComparisonOpQuestionsTypeName = objvzx_qa_PushCond.dicFldComparisonOp[convzx_qa_Push.QuestionsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Push.QuestionsTypeName, objvzx_qa_PushCond.QuestionsTypeName, strComparisonOpQuestionsTypeName);
}
if (objvzx_qa_PushCond.IsUpdated(convzx_qa_Push.IsPublic) == true)
{
if (objvzx_qa_PushCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_qa_Push.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_qa_Push.IsPublic);
}
}
if (objvzx_qa_PushCond.IsUpdated(convzx_qa_Push.zxQuestionsTypeId) == true)
{
string strComparisonOpzxQuestionsTypeId = objvzx_qa_PushCond.dicFldComparisonOp[convzx_qa_Push.zxQuestionsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Push.zxQuestionsTypeId, objvzx_qa_PushCond.zxQuestionsTypeId, strComparisonOpzxQuestionsTypeId);
}
if (objvzx_qa_PushCond.IsUpdated(convzx_qa_Push.QuestionsContent) == true)
{
string strComparisonOpQuestionsContent = objvzx_qa_PushCond.dicFldComparisonOp[convzx_qa_Push.QuestionsContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Push.QuestionsContent, objvzx_qa_PushCond.QuestionsContent, strComparisonOpQuestionsContent);
}
if (objvzx_qa_PushCond.IsUpdated(convzx_qa_Push.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objvzx_qa_PushCond.dicFldComparisonOp[convzx_qa_Push.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_qa_Push.PdfPageNum, objvzx_qa_PushCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objvzx_qa_PushCond.IsUpdated(convzx_qa_Push.PdfContent) == true)
{
string strComparisonOpPdfContent = objvzx_qa_PushCond.dicFldComparisonOp[convzx_qa_Push.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Push.PdfContent, objvzx_qa_PushCond.PdfContent, strComparisonOpPdfContent);
}
if (objvzx_qa_PushCond.IsUpdated(convzx_qa_Push.IsEnd) == true)
{
if (objvzx_qa_PushCond.IsEnd == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_qa_Push.IsEnd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_qa_Push.IsEnd);
}
}
if (objvzx_qa_PushCond.IsUpdated(convzx_qa_Push.VoteCount) == true)
{
string strComparisonOpVoteCount = objvzx_qa_PushCond.dicFldComparisonOp[convzx_qa_Push.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_qa_Push.VoteCount, objvzx_qa_PushCond.VoteCount, strComparisonOpVoteCount);
}
if (objvzx_qa_PushCond.IsUpdated(convzx_qa_Push.AnswerCount) == true)
{
string strComparisonOpAnswerCount = objvzx_qa_PushCond.dicFldComparisonOp[convzx_qa_Push.AnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_qa_Push.AnswerCount, objvzx_qa_PushCond.AnswerCount, strComparisonOpAnswerCount);
}
if (objvzx_qa_PushCond.IsUpdated(convzx_qa_Push.TextId) == true)
{
string strComparisonOpTextId = objvzx_qa_PushCond.dicFldComparisonOp[convzx_qa_Push.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Push.TextId, objvzx_qa_PushCond.TextId, strComparisonOpTextId);
}
if (objvzx_qa_PushCond.IsUpdated(convzx_qa_Push.ZxqaPaperId) == true)
{
string strComparisonOpZxqaPaperId = objvzx_qa_PushCond.dicFldComparisonOp[convzx_qa_Push.ZxqaPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Push.ZxqaPaperId, objvzx_qa_PushCond.ZxqaPaperId, strComparisonOpZxqaPaperId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_qa_Push
{
public virtual bool UpdRelaTabDate(long lngPushId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_qa_Push(vzx_qa_Push)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_qa_PushBL
{
public static RelatedActions_vzx_qa_Push relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_qa_PushDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_qa_PushDA vzx_qa_PushDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_qa_PushDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_qa_PushBL()
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
if (string.IsNullOrEmpty(clsvzx_qa_PushEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_qa_PushEN._ConnectString);
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
public static DataTable GetDataTable_vzx_qa_Push(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_qa_PushDA.GetDataTable_vzx_qa_Push(strWhereCond);
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
objDT = vzx_qa_PushDA.GetDataTable(strWhereCond);
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
objDT = vzx_qa_PushDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_qa_PushDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_qa_PushDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_qa_PushDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_qa_PushDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_qa_PushDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_qa_PushDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvzx_qa_PushEN> GetObjLstByPushIdLst(List<long> arrPushIdLst)
{
List<clsvzx_qa_PushEN> arrObjLst = new List<clsvzx_qa_PushEN>(); 
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
	clsvzx_qa_PushEN objvzx_qa_PushEN = new clsvzx_qa_PushEN();
try
{
objvzx_qa_PushEN.PushId = Int32.Parse(objRow[convzx_qa_Push.PushId].ToString().Trim()); //推送d
objvzx_qa_PushEN.zxQuestionsId = objRow[convzx_qa_Push.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_qa_PushEN.ReceiveUser = objRow[convzx_qa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvzx_qa_PushEN.ReceiveDate = objRow[convzx_qa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvzx_qa_PushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsReceive].ToString().Trim()); //是否接收
objvzx_qa_PushEN.UpdDate = objRow[convzx_qa_Push.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Push.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PushEN.Memo = objRow[convzx_qa_Push.Memo] == DBNull.Value ? null : objRow[convzx_qa_Push.Memo].ToString().Trim(); //备注
objvzx_qa_PushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsReply].ToString().Trim()); //是否回复
objvzx_qa_PushEN.IsRequestReply = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvzx_qa_PushEN.ReplyDate = objRow[convzx_qa_Push.ReplyDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReplyDate].ToString().Trim(); //回复日期
objvzx_qa_PushEN.TextTitle = objRow[convzx_qa_Push.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Push.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PushEN.UserName = objRow[convzx_qa_Push.UserName] == DBNull.Value ? null : objRow[convzx_qa_Push.UserName].ToString().Trim(); //用户名
objvzx_qa_PushEN.QuestionsTypeName = objRow[convzx_qa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_qa_PushEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PushEN.zxQuestionsTypeId = objRow[convzx_qa_Push.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_qa_Push.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_qa_PushEN.QuestionsContent = objRow[convzx_qa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvzx_qa_PushEN.PdfPageNum = objRow[convzx_qa_Push.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_qa_PushEN.PdfContent = objRow[convzx_qa_Push.PdfContent] == DBNull.Value ? null : objRow[convzx_qa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvzx_qa_PushEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsEnd].ToString().Trim()); //是否结束
objvzx_qa_PushEN.VoteCount = objRow[convzx_qa_Push.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.VoteCount].ToString().Trim()); //点赞计数
objvzx_qa_PushEN.AnswerCount = objRow[convzx_qa_Push.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PushEN.TextId = objRow[convzx_qa_Push.TextId] == DBNull.Value ? null : objRow[convzx_qa_Push.TextId].ToString().Trim(); //课件Id
objvzx_qa_PushEN.ZxqaPaperId = objRow[convzx_qa_Push.ZxqaPaperId] == DBNull.Value ? null : objRow[convzx_qa_Push.ZxqaPaperId].ToString().Trim(); //论文答疑Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_qa_PushEN.PushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_qa_PushEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPushIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_qa_PushEN> GetObjLstByPushIdLstCache(List<long> arrPushIdLst)
{
string strKey = string.Format("{0}", clsvzx_qa_PushEN._CurrTabName);
List<clsvzx_qa_PushEN> arrvzx_qa_PushObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_qa_PushEN> arrvzx_qa_PushObjLst_Sel =
arrvzx_qa_PushObjLstCache
.Where(x => arrPushIdLst.Contains(x.PushId));
return arrvzx_qa_PushObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_qa_PushEN> GetObjLst(string strWhereCond)
{
List<clsvzx_qa_PushEN> arrObjLst = new List<clsvzx_qa_PushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_qa_PushEN objvzx_qa_PushEN = new clsvzx_qa_PushEN();
try
{
objvzx_qa_PushEN.PushId = Int32.Parse(objRow[convzx_qa_Push.PushId].ToString().Trim()); //推送d
objvzx_qa_PushEN.zxQuestionsId = objRow[convzx_qa_Push.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_qa_PushEN.ReceiveUser = objRow[convzx_qa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvzx_qa_PushEN.ReceiveDate = objRow[convzx_qa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvzx_qa_PushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsReceive].ToString().Trim()); //是否接收
objvzx_qa_PushEN.UpdDate = objRow[convzx_qa_Push.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Push.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PushEN.Memo = objRow[convzx_qa_Push.Memo] == DBNull.Value ? null : objRow[convzx_qa_Push.Memo].ToString().Trim(); //备注
objvzx_qa_PushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsReply].ToString().Trim()); //是否回复
objvzx_qa_PushEN.IsRequestReply = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvzx_qa_PushEN.ReplyDate = objRow[convzx_qa_Push.ReplyDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReplyDate].ToString().Trim(); //回复日期
objvzx_qa_PushEN.TextTitle = objRow[convzx_qa_Push.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Push.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PushEN.UserName = objRow[convzx_qa_Push.UserName] == DBNull.Value ? null : objRow[convzx_qa_Push.UserName].ToString().Trim(); //用户名
objvzx_qa_PushEN.QuestionsTypeName = objRow[convzx_qa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_qa_PushEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PushEN.zxQuestionsTypeId = objRow[convzx_qa_Push.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_qa_Push.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_qa_PushEN.QuestionsContent = objRow[convzx_qa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvzx_qa_PushEN.PdfPageNum = objRow[convzx_qa_Push.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_qa_PushEN.PdfContent = objRow[convzx_qa_Push.PdfContent] == DBNull.Value ? null : objRow[convzx_qa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvzx_qa_PushEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsEnd].ToString().Trim()); //是否结束
objvzx_qa_PushEN.VoteCount = objRow[convzx_qa_Push.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.VoteCount].ToString().Trim()); //点赞计数
objvzx_qa_PushEN.AnswerCount = objRow[convzx_qa_Push.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PushEN.TextId = objRow[convzx_qa_Push.TextId] == DBNull.Value ? null : objRow[convzx_qa_Push.TextId].ToString().Trim(); //课件Id
objvzx_qa_PushEN.ZxqaPaperId = objRow[convzx_qa_Push.ZxqaPaperId] == DBNull.Value ? null : objRow[convzx_qa_Push.ZxqaPaperId].ToString().Trim(); //论文答疑Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_qa_PushEN.PushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_qa_PushEN);
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
public static List<clsvzx_qa_PushEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_qa_PushEN> arrObjLst = new List<clsvzx_qa_PushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_qa_PushEN objvzx_qa_PushEN = new clsvzx_qa_PushEN();
try
{
objvzx_qa_PushEN.PushId = Int32.Parse(objRow[convzx_qa_Push.PushId].ToString().Trim()); //推送d
objvzx_qa_PushEN.zxQuestionsId = objRow[convzx_qa_Push.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_qa_PushEN.ReceiveUser = objRow[convzx_qa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvzx_qa_PushEN.ReceiveDate = objRow[convzx_qa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvzx_qa_PushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsReceive].ToString().Trim()); //是否接收
objvzx_qa_PushEN.UpdDate = objRow[convzx_qa_Push.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Push.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PushEN.Memo = objRow[convzx_qa_Push.Memo] == DBNull.Value ? null : objRow[convzx_qa_Push.Memo].ToString().Trim(); //备注
objvzx_qa_PushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsReply].ToString().Trim()); //是否回复
objvzx_qa_PushEN.IsRequestReply = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvzx_qa_PushEN.ReplyDate = objRow[convzx_qa_Push.ReplyDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReplyDate].ToString().Trim(); //回复日期
objvzx_qa_PushEN.TextTitle = objRow[convzx_qa_Push.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Push.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PushEN.UserName = objRow[convzx_qa_Push.UserName] == DBNull.Value ? null : objRow[convzx_qa_Push.UserName].ToString().Trim(); //用户名
objvzx_qa_PushEN.QuestionsTypeName = objRow[convzx_qa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_qa_PushEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PushEN.zxQuestionsTypeId = objRow[convzx_qa_Push.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_qa_Push.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_qa_PushEN.QuestionsContent = objRow[convzx_qa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvzx_qa_PushEN.PdfPageNum = objRow[convzx_qa_Push.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_qa_PushEN.PdfContent = objRow[convzx_qa_Push.PdfContent] == DBNull.Value ? null : objRow[convzx_qa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvzx_qa_PushEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsEnd].ToString().Trim()); //是否结束
objvzx_qa_PushEN.VoteCount = objRow[convzx_qa_Push.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.VoteCount].ToString().Trim()); //点赞计数
objvzx_qa_PushEN.AnswerCount = objRow[convzx_qa_Push.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PushEN.TextId = objRow[convzx_qa_Push.TextId] == DBNull.Value ? null : objRow[convzx_qa_Push.TextId].ToString().Trim(); //课件Id
objvzx_qa_PushEN.ZxqaPaperId = objRow[convzx_qa_Push.ZxqaPaperId] == DBNull.Value ? null : objRow[convzx_qa_Push.ZxqaPaperId].ToString().Trim(); //论文答疑Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_qa_PushEN.PushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_qa_PushEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_qa_PushCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_qa_PushEN> GetSubObjLstCache(clsvzx_qa_PushEN objvzx_qa_PushCond)
{
List<clsvzx_qa_PushEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_qa_PushEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_qa_Push.AttributeName)
{
if (objvzx_qa_PushCond.IsUpdated(strFldName) == false) continue;
if (objvzx_qa_PushCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_qa_PushCond[strFldName].ToString());
}
else
{
if (objvzx_qa_PushCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_qa_PushCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_qa_PushCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_qa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_qa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_qa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_qa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_qa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_qa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_qa_PushCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_qa_PushCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_qa_PushCond[strFldName]));
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
public static List<clsvzx_qa_PushEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_qa_PushEN> arrObjLst = new List<clsvzx_qa_PushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_qa_PushEN objvzx_qa_PushEN = new clsvzx_qa_PushEN();
try
{
objvzx_qa_PushEN.PushId = Int32.Parse(objRow[convzx_qa_Push.PushId].ToString().Trim()); //推送d
objvzx_qa_PushEN.zxQuestionsId = objRow[convzx_qa_Push.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_qa_PushEN.ReceiveUser = objRow[convzx_qa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvzx_qa_PushEN.ReceiveDate = objRow[convzx_qa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvzx_qa_PushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsReceive].ToString().Trim()); //是否接收
objvzx_qa_PushEN.UpdDate = objRow[convzx_qa_Push.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Push.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PushEN.Memo = objRow[convzx_qa_Push.Memo] == DBNull.Value ? null : objRow[convzx_qa_Push.Memo].ToString().Trim(); //备注
objvzx_qa_PushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsReply].ToString().Trim()); //是否回复
objvzx_qa_PushEN.IsRequestReply = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvzx_qa_PushEN.ReplyDate = objRow[convzx_qa_Push.ReplyDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReplyDate].ToString().Trim(); //回复日期
objvzx_qa_PushEN.TextTitle = objRow[convzx_qa_Push.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Push.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PushEN.UserName = objRow[convzx_qa_Push.UserName] == DBNull.Value ? null : objRow[convzx_qa_Push.UserName].ToString().Trim(); //用户名
objvzx_qa_PushEN.QuestionsTypeName = objRow[convzx_qa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_qa_PushEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PushEN.zxQuestionsTypeId = objRow[convzx_qa_Push.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_qa_Push.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_qa_PushEN.QuestionsContent = objRow[convzx_qa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvzx_qa_PushEN.PdfPageNum = objRow[convzx_qa_Push.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_qa_PushEN.PdfContent = objRow[convzx_qa_Push.PdfContent] == DBNull.Value ? null : objRow[convzx_qa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvzx_qa_PushEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsEnd].ToString().Trim()); //是否结束
objvzx_qa_PushEN.VoteCount = objRow[convzx_qa_Push.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.VoteCount].ToString().Trim()); //点赞计数
objvzx_qa_PushEN.AnswerCount = objRow[convzx_qa_Push.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PushEN.TextId = objRow[convzx_qa_Push.TextId] == DBNull.Value ? null : objRow[convzx_qa_Push.TextId].ToString().Trim(); //课件Id
objvzx_qa_PushEN.ZxqaPaperId = objRow[convzx_qa_Push.ZxqaPaperId] == DBNull.Value ? null : objRow[convzx_qa_Push.ZxqaPaperId].ToString().Trim(); //论文答疑Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_qa_PushEN.PushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_qa_PushEN);
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
public static List<clsvzx_qa_PushEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_qa_PushEN> arrObjLst = new List<clsvzx_qa_PushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_qa_PushEN objvzx_qa_PushEN = new clsvzx_qa_PushEN();
try
{
objvzx_qa_PushEN.PushId = Int32.Parse(objRow[convzx_qa_Push.PushId].ToString().Trim()); //推送d
objvzx_qa_PushEN.zxQuestionsId = objRow[convzx_qa_Push.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_qa_PushEN.ReceiveUser = objRow[convzx_qa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvzx_qa_PushEN.ReceiveDate = objRow[convzx_qa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvzx_qa_PushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsReceive].ToString().Trim()); //是否接收
objvzx_qa_PushEN.UpdDate = objRow[convzx_qa_Push.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Push.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PushEN.Memo = objRow[convzx_qa_Push.Memo] == DBNull.Value ? null : objRow[convzx_qa_Push.Memo].ToString().Trim(); //备注
objvzx_qa_PushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsReply].ToString().Trim()); //是否回复
objvzx_qa_PushEN.IsRequestReply = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvzx_qa_PushEN.ReplyDate = objRow[convzx_qa_Push.ReplyDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReplyDate].ToString().Trim(); //回复日期
objvzx_qa_PushEN.TextTitle = objRow[convzx_qa_Push.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Push.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PushEN.UserName = objRow[convzx_qa_Push.UserName] == DBNull.Value ? null : objRow[convzx_qa_Push.UserName].ToString().Trim(); //用户名
objvzx_qa_PushEN.QuestionsTypeName = objRow[convzx_qa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_qa_PushEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PushEN.zxQuestionsTypeId = objRow[convzx_qa_Push.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_qa_Push.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_qa_PushEN.QuestionsContent = objRow[convzx_qa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvzx_qa_PushEN.PdfPageNum = objRow[convzx_qa_Push.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_qa_PushEN.PdfContent = objRow[convzx_qa_Push.PdfContent] == DBNull.Value ? null : objRow[convzx_qa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvzx_qa_PushEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsEnd].ToString().Trim()); //是否结束
objvzx_qa_PushEN.VoteCount = objRow[convzx_qa_Push.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.VoteCount].ToString().Trim()); //点赞计数
objvzx_qa_PushEN.AnswerCount = objRow[convzx_qa_Push.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PushEN.TextId = objRow[convzx_qa_Push.TextId] == DBNull.Value ? null : objRow[convzx_qa_Push.TextId].ToString().Trim(); //课件Id
objvzx_qa_PushEN.ZxqaPaperId = objRow[convzx_qa_Push.ZxqaPaperId] == DBNull.Value ? null : objRow[convzx_qa_Push.ZxqaPaperId].ToString().Trim(); //论文答疑Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_qa_PushEN.PushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_qa_PushEN);
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
List<clsvzx_qa_PushEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_qa_PushEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_qa_PushEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_qa_PushEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_qa_PushEN> arrObjLst = new List<clsvzx_qa_PushEN>(); 
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
	clsvzx_qa_PushEN objvzx_qa_PushEN = new clsvzx_qa_PushEN();
try
{
objvzx_qa_PushEN.PushId = Int32.Parse(objRow[convzx_qa_Push.PushId].ToString().Trim()); //推送d
objvzx_qa_PushEN.zxQuestionsId = objRow[convzx_qa_Push.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_qa_PushEN.ReceiveUser = objRow[convzx_qa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvzx_qa_PushEN.ReceiveDate = objRow[convzx_qa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvzx_qa_PushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsReceive].ToString().Trim()); //是否接收
objvzx_qa_PushEN.UpdDate = objRow[convzx_qa_Push.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Push.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PushEN.Memo = objRow[convzx_qa_Push.Memo] == DBNull.Value ? null : objRow[convzx_qa_Push.Memo].ToString().Trim(); //备注
objvzx_qa_PushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsReply].ToString().Trim()); //是否回复
objvzx_qa_PushEN.IsRequestReply = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvzx_qa_PushEN.ReplyDate = objRow[convzx_qa_Push.ReplyDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReplyDate].ToString().Trim(); //回复日期
objvzx_qa_PushEN.TextTitle = objRow[convzx_qa_Push.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Push.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PushEN.UserName = objRow[convzx_qa_Push.UserName] == DBNull.Value ? null : objRow[convzx_qa_Push.UserName].ToString().Trim(); //用户名
objvzx_qa_PushEN.QuestionsTypeName = objRow[convzx_qa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_qa_PushEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PushEN.zxQuestionsTypeId = objRow[convzx_qa_Push.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_qa_Push.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_qa_PushEN.QuestionsContent = objRow[convzx_qa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvzx_qa_PushEN.PdfPageNum = objRow[convzx_qa_Push.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_qa_PushEN.PdfContent = objRow[convzx_qa_Push.PdfContent] == DBNull.Value ? null : objRow[convzx_qa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvzx_qa_PushEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsEnd].ToString().Trim()); //是否结束
objvzx_qa_PushEN.VoteCount = objRow[convzx_qa_Push.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.VoteCount].ToString().Trim()); //点赞计数
objvzx_qa_PushEN.AnswerCount = objRow[convzx_qa_Push.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PushEN.TextId = objRow[convzx_qa_Push.TextId] == DBNull.Value ? null : objRow[convzx_qa_Push.TextId].ToString().Trim(); //课件Id
objvzx_qa_PushEN.ZxqaPaperId = objRow[convzx_qa_Push.ZxqaPaperId] == DBNull.Value ? null : objRow[convzx_qa_Push.ZxqaPaperId].ToString().Trim(); //论文答疑Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_qa_PushEN.PushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_qa_PushEN);
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
public static List<clsvzx_qa_PushEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_qa_PushEN> arrObjLst = new List<clsvzx_qa_PushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_qa_PushEN objvzx_qa_PushEN = new clsvzx_qa_PushEN();
try
{
objvzx_qa_PushEN.PushId = Int32.Parse(objRow[convzx_qa_Push.PushId].ToString().Trim()); //推送d
objvzx_qa_PushEN.zxQuestionsId = objRow[convzx_qa_Push.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_qa_PushEN.ReceiveUser = objRow[convzx_qa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvzx_qa_PushEN.ReceiveDate = objRow[convzx_qa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvzx_qa_PushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsReceive].ToString().Trim()); //是否接收
objvzx_qa_PushEN.UpdDate = objRow[convzx_qa_Push.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Push.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PushEN.Memo = objRow[convzx_qa_Push.Memo] == DBNull.Value ? null : objRow[convzx_qa_Push.Memo].ToString().Trim(); //备注
objvzx_qa_PushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsReply].ToString().Trim()); //是否回复
objvzx_qa_PushEN.IsRequestReply = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvzx_qa_PushEN.ReplyDate = objRow[convzx_qa_Push.ReplyDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReplyDate].ToString().Trim(); //回复日期
objvzx_qa_PushEN.TextTitle = objRow[convzx_qa_Push.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Push.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PushEN.UserName = objRow[convzx_qa_Push.UserName] == DBNull.Value ? null : objRow[convzx_qa_Push.UserName].ToString().Trim(); //用户名
objvzx_qa_PushEN.QuestionsTypeName = objRow[convzx_qa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_qa_PushEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PushEN.zxQuestionsTypeId = objRow[convzx_qa_Push.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_qa_Push.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_qa_PushEN.QuestionsContent = objRow[convzx_qa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvzx_qa_PushEN.PdfPageNum = objRow[convzx_qa_Push.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_qa_PushEN.PdfContent = objRow[convzx_qa_Push.PdfContent] == DBNull.Value ? null : objRow[convzx_qa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvzx_qa_PushEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsEnd].ToString().Trim()); //是否结束
objvzx_qa_PushEN.VoteCount = objRow[convzx_qa_Push.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.VoteCount].ToString().Trim()); //点赞计数
objvzx_qa_PushEN.AnswerCount = objRow[convzx_qa_Push.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PushEN.TextId = objRow[convzx_qa_Push.TextId] == DBNull.Value ? null : objRow[convzx_qa_Push.TextId].ToString().Trim(); //课件Id
objvzx_qa_PushEN.ZxqaPaperId = objRow[convzx_qa_Push.ZxqaPaperId] == DBNull.Value ? null : objRow[convzx_qa_Push.ZxqaPaperId].ToString().Trim(); //论文答疑Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_qa_PushEN.PushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_qa_PushEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_qa_PushEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_qa_PushEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_qa_PushEN> arrObjLst = new List<clsvzx_qa_PushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_qa_PushEN objvzx_qa_PushEN = new clsvzx_qa_PushEN();
try
{
objvzx_qa_PushEN.PushId = Int32.Parse(objRow[convzx_qa_Push.PushId].ToString().Trim()); //推送d
objvzx_qa_PushEN.zxQuestionsId = objRow[convzx_qa_Push.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_qa_PushEN.ReceiveUser = objRow[convzx_qa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvzx_qa_PushEN.ReceiveDate = objRow[convzx_qa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvzx_qa_PushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsReceive].ToString().Trim()); //是否接收
objvzx_qa_PushEN.UpdDate = objRow[convzx_qa_Push.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Push.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PushEN.Memo = objRow[convzx_qa_Push.Memo] == DBNull.Value ? null : objRow[convzx_qa_Push.Memo].ToString().Trim(); //备注
objvzx_qa_PushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsReply].ToString().Trim()); //是否回复
objvzx_qa_PushEN.IsRequestReply = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvzx_qa_PushEN.ReplyDate = objRow[convzx_qa_Push.ReplyDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReplyDate].ToString().Trim(); //回复日期
objvzx_qa_PushEN.TextTitle = objRow[convzx_qa_Push.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Push.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PushEN.UserName = objRow[convzx_qa_Push.UserName] == DBNull.Value ? null : objRow[convzx_qa_Push.UserName].ToString().Trim(); //用户名
objvzx_qa_PushEN.QuestionsTypeName = objRow[convzx_qa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_qa_PushEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PushEN.zxQuestionsTypeId = objRow[convzx_qa_Push.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_qa_Push.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_qa_PushEN.QuestionsContent = objRow[convzx_qa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvzx_qa_PushEN.PdfPageNum = objRow[convzx_qa_Push.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_qa_PushEN.PdfContent = objRow[convzx_qa_Push.PdfContent] == DBNull.Value ? null : objRow[convzx_qa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvzx_qa_PushEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsEnd].ToString().Trim()); //是否结束
objvzx_qa_PushEN.VoteCount = objRow[convzx_qa_Push.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.VoteCount].ToString().Trim()); //点赞计数
objvzx_qa_PushEN.AnswerCount = objRow[convzx_qa_Push.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PushEN.TextId = objRow[convzx_qa_Push.TextId] == DBNull.Value ? null : objRow[convzx_qa_Push.TextId].ToString().Trim(); //课件Id
objvzx_qa_PushEN.ZxqaPaperId = objRow[convzx_qa_Push.ZxqaPaperId] == DBNull.Value ? null : objRow[convzx_qa_Push.ZxqaPaperId].ToString().Trim(); //论文答疑Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_qa_PushEN.PushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_qa_PushEN);
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
public static List<clsvzx_qa_PushEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_qa_PushEN> arrObjLst = new List<clsvzx_qa_PushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_qa_PushEN objvzx_qa_PushEN = new clsvzx_qa_PushEN();
try
{
objvzx_qa_PushEN.PushId = Int32.Parse(objRow[convzx_qa_Push.PushId].ToString().Trim()); //推送d
objvzx_qa_PushEN.zxQuestionsId = objRow[convzx_qa_Push.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_qa_PushEN.ReceiveUser = objRow[convzx_qa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvzx_qa_PushEN.ReceiveDate = objRow[convzx_qa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvzx_qa_PushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsReceive].ToString().Trim()); //是否接收
objvzx_qa_PushEN.UpdDate = objRow[convzx_qa_Push.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Push.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PushEN.Memo = objRow[convzx_qa_Push.Memo] == DBNull.Value ? null : objRow[convzx_qa_Push.Memo].ToString().Trim(); //备注
objvzx_qa_PushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsReply].ToString().Trim()); //是否回复
objvzx_qa_PushEN.IsRequestReply = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvzx_qa_PushEN.ReplyDate = objRow[convzx_qa_Push.ReplyDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReplyDate].ToString().Trim(); //回复日期
objvzx_qa_PushEN.TextTitle = objRow[convzx_qa_Push.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Push.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PushEN.UserName = objRow[convzx_qa_Push.UserName] == DBNull.Value ? null : objRow[convzx_qa_Push.UserName].ToString().Trim(); //用户名
objvzx_qa_PushEN.QuestionsTypeName = objRow[convzx_qa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_qa_PushEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PushEN.zxQuestionsTypeId = objRow[convzx_qa_Push.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_qa_Push.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_qa_PushEN.QuestionsContent = objRow[convzx_qa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvzx_qa_PushEN.PdfPageNum = objRow[convzx_qa_Push.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_qa_PushEN.PdfContent = objRow[convzx_qa_Push.PdfContent] == DBNull.Value ? null : objRow[convzx_qa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvzx_qa_PushEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsEnd].ToString().Trim()); //是否结束
objvzx_qa_PushEN.VoteCount = objRow[convzx_qa_Push.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.VoteCount].ToString().Trim()); //点赞计数
objvzx_qa_PushEN.AnswerCount = objRow[convzx_qa_Push.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PushEN.TextId = objRow[convzx_qa_Push.TextId] == DBNull.Value ? null : objRow[convzx_qa_Push.TextId].ToString().Trim(); //课件Id
objvzx_qa_PushEN.ZxqaPaperId = objRow[convzx_qa_Push.ZxqaPaperId] == DBNull.Value ? null : objRow[convzx_qa_Push.ZxqaPaperId].ToString().Trim(); //论文答疑Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_qa_PushEN.PushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_qa_PushEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_qa_PushEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_qa_PushEN> arrObjLst = new List<clsvzx_qa_PushEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_qa_PushEN objvzx_qa_PushEN = new clsvzx_qa_PushEN();
try
{
objvzx_qa_PushEN.PushId = Int32.Parse(objRow[convzx_qa_Push.PushId].ToString().Trim()); //推送d
objvzx_qa_PushEN.zxQuestionsId = objRow[convzx_qa_Push.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_qa_PushEN.ReceiveUser = objRow[convzx_qa_Push.ReceiveUser] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveUser].ToString().Trim(); //接收用户
objvzx_qa_PushEN.ReceiveDate = objRow[convzx_qa_Push.ReceiveDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReceiveDate].ToString().Trim(); //接收日期
objvzx_qa_PushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsReceive].ToString().Trim()); //是否接收
objvzx_qa_PushEN.UpdDate = objRow[convzx_qa_Push.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Push.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PushEN.Memo = objRow[convzx_qa_Push.Memo] == DBNull.Value ? null : objRow[convzx_qa_Push.Memo].ToString().Trim(); //备注
objvzx_qa_PushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsReply].ToString().Trim()); //是否回复
objvzx_qa_PushEN.IsRequestReply = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsRequestReply].ToString().Trim()); //是否要求回复
objvzx_qa_PushEN.ReplyDate = objRow[convzx_qa_Push.ReplyDate] == DBNull.Value ? null : objRow[convzx_qa_Push.ReplyDate].ToString().Trim(); //回复日期
objvzx_qa_PushEN.TextTitle = objRow[convzx_qa_Push.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Push.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PushEN.UserName = objRow[convzx_qa_Push.UserName] == DBNull.Value ? null : objRow[convzx_qa_Push.UserName].ToString().Trim(); //用户名
objvzx_qa_PushEN.QuestionsTypeName = objRow[convzx_qa_Push.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_qa_PushEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PushEN.zxQuestionsTypeId = objRow[convzx_qa_Push.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_qa_Push.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_qa_PushEN.QuestionsContent = objRow[convzx_qa_Push.QuestionsContent] == DBNull.Value ? null : objRow[convzx_qa_Push.QuestionsContent].ToString().Trim(); //提问内容
objvzx_qa_PushEN.PdfPageNum = objRow[convzx_qa_Push.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_qa_PushEN.PdfContent = objRow[convzx_qa_Push.PdfContent] == DBNull.Value ? null : objRow[convzx_qa_Push.PdfContent].ToString().Trim(); //Pdf内容
objvzx_qa_PushEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Push.IsEnd].ToString().Trim()); //是否结束
objvzx_qa_PushEN.VoteCount = objRow[convzx_qa_Push.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.VoteCount].ToString().Trim()); //点赞计数
objvzx_qa_PushEN.AnswerCount = objRow[convzx_qa_Push.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Push.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PushEN.TextId = objRow[convzx_qa_Push.TextId] == DBNull.Value ? null : objRow[convzx_qa_Push.TextId].ToString().Trim(); //课件Id
objvzx_qa_PushEN.ZxqaPaperId = objRow[convzx_qa_Push.ZxqaPaperId] == DBNull.Value ? null : objRow[convzx_qa_Push.ZxqaPaperId].ToString().Trim(); //论文答疑Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_qa_PushEN.PushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_qa_PushEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_qa_PushEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_qa_Push(ref clsvzx_qa_PushEN objvzx_qa_PushEN)
{
bool bolResult = vzx_qa_PushDA.Getvzx_qa_Push(ref objvzx_qa_PushEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngPushId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_qa_PushEN GetObjByPushId(long lngPushId)
{
clsvzx_qa_PushEN objvzx_qa_PushEN = vzx_qa_PushDA.GetObjByPushId(lngPushId);
return objvzx_qa_PushEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_qa_PushEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_qa_PushEN objvzx_qa_PushEN = vzx_qa_PushDA.GetFirstObj(strWhereCond);
 return objvzx_qa_PushEN;
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
public static clsvzx_qa_PushEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_qa_PushEN objvzx_qa_PushEN = vzx_qa_PushDA.GetObjByDataRow(objRow);
 return objvzx_qa_PushEN;
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
public static clsvzx_qa_PushEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_qa_PushEN objvzx_qa_PushEN = vzx_qa_PushDA.GetObjByDataRow(objRow);
 return objvzx_qa_PushEN;
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
 /// <param name = "lstvzx_qa_PushObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_qa_PushEN GetObjByPushIdFromList(long lngPushId, List<clsvzx_qa_PushEN> lstvzx_qa_PushObjLst)
{
foreach (clsvzx_qa_PushEN objvzx_qa_PushEN in lstvzx_qa_PushObjLst)
{
if (objvzx_qa_PushEN.PushId == lngPushId)
{
return objvzx_qa_PushEN;
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
 lngPushId = new clsvzx_qa_PushDA().GetFirstID(strWhereCond);
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
 arrList = vzx_qa_PushDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_qa_PushDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vzx_qa_PushDA.IsExist(lngPushId);
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
 bolIsExist = clsvzx_qa_PushDA.IsExistTable();
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
 bolIsExist = vzx_qa_PushDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_qa_PushENS">源对象</param>
 /// <param name = "objvzx_qa_PushENT">目标对象</param>
 public static void CopyTo(clsvzx_qa_PushEN objvzx_qa_PushENS, clsvzx_qa_PushEN objvzx_qa_PushENT)
{
try
{
objvzx_qa_PushENT.PushId = objvzx_qa_PushENS.PushId; //推送d
objvzx_qa_PushENT.zxQuestionsId = objvzx_qa_PushENS.zxQuestionsId; //提问Id
objvzx_qa_PushENT.ReceiveUser = objvzx_qa_PushENS.ReceiveUser; //接收用户
objvzx_qa_PushENT.ReceiveDate = objvzx_qa_PushENS.ReceiveDate; //接收日期
objvzx_qa_PushENT.IsReceive = objvzx_qa_PushENS.IsReceive; //是否接收
objvzx_qa_PushENT.UpdDate = objvzx_qa_PushENS.UpdDate; //修改日期
objvzx_qa_PushENT.Memo = objvzx_qa_PushENS.Memo; //备注
objvzx_qa_PushENT.IsReply = objvzx_qa_PushENS.IsReply; //是否回复
objvzx_qa_PushENT.IsRequestReply = objvzx_qa_PushENS.IsRequestReply; //是否要求回复
objvzx_qa_PushENT.ReplyDate = objvzx_qa_PushENS.ReplyDate; //回复日期
objvzx_qa_PushENT.TextTitle = objvzx_qa_PushENS.TextTitle; //TextTitle
objvzx_qa_PushENT.UserName = objvzx_qa_PushENS.UserName; //用户名
objvzx_qa_PushENT.QuestionsTypeName = objvzx_qa_PushENS.QuestionsTypeName; //问题类型名称
objvzx_qa_PushENT.IsPublic = objvzx_qa_PushENS.IsPublic; //是否公开
objvzx_qa_PushENT.zxQuestionsTypeId = objvzx_qa_PushENS.zxQuestionsTypeId; //问题类型Id
objvzx_qa_PushENT.QuestionsContent = objvzx_qa_PushENS.QuestionsContent; //提问内容
objvzx_qa_PushENT.PdfPageNum = objvzx_qa_PushENS.PdfPageNum; //Pdf页码
objvzx_qa_PushENT.PdfContent = objvzx_qa_PushENS.PdfContent; //Pdf内容
objvzx_qa_PushENT.IsEnd = objvzx_qa_PushENS.IsEnd; //是否结束
objvzx_qa_PushENT.VoteCount = objvzx_qa_PushENS.VoteCount; //点赞计数
objvzx_qa_PushENT.AnswerCount = objvzx_qa_PushENS.AnswerCount; //回答计数
objvzx_qa_PushENT.TextId = objvzx_qa_PushENS.TextId; //课件Id
objvzx_qa_PushENT.ZxqaPaperId = objvzx_qa_PushENS.ZxqaPaperId; //论文答疑Id
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
 /// <param name = "objvzx_qa_PushEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_qa_PushEN objvzx_qa_PushEN)
{
try
{
objvzx_qa_PushEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_qa_PushEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_qa_Push.PushId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PushEN.PushId = objvzx_qa_PushEN.PushId; //推送d
}
if (arrFldSet.Contains(convzx_qa_Push.zxQuestionsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PushEN.zxQuestionsId = objvzx_qa_PushEN.zxQuestionsId; //提问Id
}
if (arrFldSet.Contains(convzx_qa_Push.ReceiveUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PushEN.ReceiveUser = objvzx_qa_PushEN.ReceiveUser == "[null]" ? null :  objvzx_qa_PushEN.ReceiveUser; //接收用户
}
if (arrFldSet.Contains(convzx_qa_Push.ReceiveDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PushEN.ReceiveDate = objvzx_qa_PushEN.ReceiveDate == "[null]" ? null :  objvzx_qa_PushEN.ReceiveDate; //接收日期
}
if (arrFldSet.Contains(convzx_qa_Push.IsReceive, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PushEN.IsReceive = objvzx_qa_PushEN.IsReceive; //是否接收
}
if (arrFldSet.Contains(convzx_qa_Push.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PushEN.UpdDate = objvzx_qa_PushEN.UpdDate == "[null]" ? null :  objvzx_qa_PushEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_qa_Push.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PushEN.Memo = objvzx_qa_PushEN.Memo == "[null]" ? null :  objvzx_qa_PushEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_qa_Push.IsReply, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PushEN.IsReply = objvzx_qa_PushEN.IsReply; //是否回复
}
if (arrFldSet.Contains(convzx_qa_Push.IsRequestReply, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PushEN.IsRequestReply = objvzx_qa_PushEN.IsRequestReply; //是否要求回复
}
if (arrFldSet.Contains(convzx_qa_Push.ReplyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PushEN.ReplyDate = objvzx_qa_PushEN.ReplyDate == "[null]" ? null :  objvzx_qa_PushEN.ReplyDate; //回复日期
}
if (arrFldSet.Contains(convzx_qa_Push.TextTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PushEN.TextTitle = objvzx_qa_PushEN.TextTitle == "[null]" ? null :  objvzx_qa_PushEN.TextTitle; //TextTitle
}
if (arrFldSet.Contains(convzx_qa_Push.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PushEN.UserName = objvzx_qa_PushEN.UserName == "[null]" ? null :  objvzx_qa_PushEN.UserName; //用户名
}
if (arrFldSet.Contains(convzx_qa_Push.QuestionsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PushEN.QuestionsTypeName = objvzx_qa_PushEN.QuestionsTypeName == "[null]" ? null :  objvzx_qa_PushEN.QuestionsTypeName; //问题类型名称
}
if (arrFldSet.Contains(convzx_qa_Push.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PushEN.IsPublic = objvzx_qa_PushEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(convzx_qa_Push.zxQuestionsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PushEN.zxQuestionsTypeId = objvzx_qa_PushEN.zxQuestionsTypeId == "[null]" ? null :  objvzx_qa_PushEN.zxQuestionsTypeId; //问题类型Id
}
if (arrFldSet.Contains(convzx_qa_Push.QuestionsContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PushEN.QuestionsContent = objvzx_qa_PushEN.QuestionsContent == "[null]" ? null :  objvzx_qa_PushEN.QuestionsContent; //提问内容
}
if (arrFldSet.Contains(convzx_qa_Push.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PushEN.PdfPageNum = objvzx_qa_PushEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(convzx_qa_Push.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PushEN.PdfContent = objvzx_qa_PushEN.PdfContent == "[null]" ? null :  objvzx_qa_PushEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(convzx_qa_Push.IsEnd, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PushEN.IsEnd = objvzx_qa_PushEN.IsEnd; //是否结束
}
if (arrFldSet.Contains(convzx_qa_Push.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PushEN.VoteCount = objvzx_qa_PushEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(convzx_qa_Push.AnswerCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PushEN.AnswerCount = objvzx_qa_PushEN.AnswerCount; //回答计数
}
if (arrFldSet.Contains(convzx_qa_Push.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PushEN.TextId = objvzx_qa_PushEN.TextId == "[null]" ? null :  objvzx_qa_PushEN.TextId; //课件Id
}
if (arrFldSet.Contains(convzx_qa_Push.ZxqaPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PushEN.ZxqaPaperId = objvzx_qa_PushEN.ZxqaPaperId == "[null]" ? null :  objvzx_qa_PushEN.ZxqaPaperId; //论文答疑Id
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
 /// <param name = "objvzx_qa_PushEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_qa_PushEN objvzx_qa_PushEN)
{
try
{
if (objvzx_qa_PushEN.ReceiveUser == "[null]") objvzx_qa_PushEN.ReceiveUser = null; //接收用户
if (objvzx_qa_PushEN.ReceiveDate == "[null]") objvzx_qa_PushEN.ReceiveDate = null; //接收日期
if (objvzx_qa_PushEN.UpdDate == "[null]") objvzx_qa_PushEN.UpdDate = null; //修改日期
if (objvzx_qa_PushEN.Memo == "[null]") objvzx_qa_PushEN.Memo = null; //备注
if (objvzx_qa_PushEN.ReplyDate == "[null]") objvzx_qa_PushEN.ReplyDate = null; //回复日期
if (objvzx_qa_PushEN.TextTitle == "[null]") objvzx_qa_PushEN.TextTitle = null; //TextTitle
if (objvzx_qa_PushEN.UserName == "[null]") objvzx_qa_PushEN.UserName = null; //用户名
if (objvzx_qa_PushEN.QuestionsTypeName == "[null]") objvzx_qa_PushEN.QuestionsTypeName = null; //问题类型名称
if (objvzx_qa_PushEN.zxQuestionsTypeId == "[null]") objvzx_qa_PushEN.zxQuestionsTypeId = null; //问题类型Id
if (objvzx_qa_PushEN.QuestionsContent == "[null]") objvzx_qa_PushEN.QuestionsContent = null; //提问内容
if (objvzx_qa_PushEN.PdfContent == "[null]") objvzx_qa_PushEN.PdfContent = null; //Pdf内容
if (objvzx_qa_PushEN.TextId == "[null]") objvzx_qa_PushEN.TextId = null; //课件Id
if (objvzx_qa_PushEN.ZxqaPaperId == "[null]") objvzx_qa_PushEN.ZxqaPaperId = null; //论文答疑Id
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
public static void CheckProperty4Condition(clsvzx_qa_PushEN objvzx_qa_PushEN)
{
 vzx_qa_PushDA.CheckProperty4Condition(objvzx_qa_PushEN);
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
if (clszx_qa_PushBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_qa_PushBL没有刷新缓存机制(clszx_qa_PushBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
//string strWhereCond = string.Format("1 = 1 order by PushId");
//if (arrvzx_qa_PushObjLstCache == null)
//{
//arrvzx_qa_PushObjLstCache = vzx_qa_PushDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngPushId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_qa_PushEN GetObjByPushIdCache(long lngPushId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvzx_qa_PushEN._CurrTabName);
List<clsvzx_qa_PushEN> arrvzx_qa_PushObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_qa_PushEN> arrvzx_qa_PushObjLst_Sel =
arrvzx_qa_PushObjLstCache
.Where(x=> x.PushId == lngPushId 
);
if (arrvzx_qa_PushObjLst_Sel.Count() == 0)
{
   clsvzx_qa_PushEN obj = clsvzx_qa_PushBL.GetObjByPushId(lngPushId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvzx_qa_PushObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_qa_PushEN> GetAllvzx_qa_PushObjLstCache()
{
//获取缓存中的对象列表
List<clsvzx_qa_PushEN> arrvzx_qa_PushObjLstCache = GetObjLstCache(); 
return arrvzx_qa_PushObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_qa_PushEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvzx_qa_PushEN._CurrTabName);
List<clsvzx_qa_PushEN> arrvzx_qa_PushObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvzx_qa_PushObjLstCache;
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
string strKey = string.Format("{0}", clsvzx_qa_PushEN._CurrTabName);
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
if (strInFldName != convzx_qa_Push.PushId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_qa_Push.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_qa_Push.AttributeName));
throw new Exception(strMsg);
}
var objvzx_qa_Push = clsvzx_qa_PushBL.GetObjByPushIdCache(lngPushId);
if (objvzx_qa_Push == null) return "";
return objvzx_qa_Push[strOutFldName].ToString();
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
int intRecCount = clsvzx_qa_PushDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_qa_PushDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_qa_PushDA.GetRecCount();
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
int intRecCount = clsvzx_qa_PushDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_qa_PushCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_qa_PushEN objvzx_qa_PushCond)
{
List<clsvzx_qa_PushEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_qa_PushEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_qa_Push.AttributeName)
{
if (objvzx_qa_PushCond.IsUpdated(strFldName) == false) continue;
if (objvzx_qa_PushCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_qa_PushCond[strFldName].ToString());
}
else
{
if (objvzx_qa_PushCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_qa_PushCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_qa_PushCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_qa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_qa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_qa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_qa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_qa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_qa_PushCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_qa_PushCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_qa_PushCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_qa_PushCond[strFldName]));
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
 List<string> arrList = clsvzx_qa_PushDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_qa_PushDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_qa_PushDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}