﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMessagePushWApi
 表名:vMessagePush(01120282)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:28
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:新闻公告
 模块英文名:NewsAnnouncement
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
public static class clsvMessagePushWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMessagePushEN SetMessagePushId(this clsvMessagePushEN objvMessagePushEN, string strMessagePushId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMessagePushId, 8, convMessagePush.MessagePushId);
clsCheckSql.CheckFieldForeignKey(strMessagePushId, 8, convMessagePush.MessagePushId);
objvMessagePushEN.MessagePushId = strMessagePushId; //消息Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushEN.dicFldComparisonOp.ContainsKey(convMessagePush.MessagePushId) == false)
{
objvMessagePushEN.dicFldComparisonOp.Add(convMessagePush.MessagePushId, strComparisonOp);
}
else
{
objvMessagePushEN.dicFldComparisonOp[convMessagePush.MessagePushId] = strComparisonOp;
}
}
return objvMessagePushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMessagePushEN SetMessagePushNumber(this clsvMessagePushEN objvMessagePushEN, string strMessagePushNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMessagePushNumber, 200, convMessagePush.MessagePushNumber);
objvMessagePushEN.MessagePushNumber = strMessagePushNumber; //消息编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushEN.dicFldComparisonOp.ContainsKey(convMessagePush.MessagePushNumber) == false)
{
objvMessagePushEN.dicFldComparisonOp.Add(convMessagePush.MessagePushNumber, strComparisonOp);
}
else
{
objvMessagePushEN.dicFldComparisonOp[convMessagePush.MessagePushNumber] = strComparisonOp;
}
}
return objvMessagePushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMessagePushEN SetMessageTitle(this clsvMessagePushEN objvMessagePushEN, string strMessageTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMessageTitle, 500, convMessagePush.MessageTitle);
objvMessagePushEN.MessageTitle = strMessageTitle; //消息标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushEN.dicFldComparisonOp.ContainsKey(convMessagePush.MessageTitle) == false)
{
objvMessagePushEN.dicFldComparisonOp.Add(convMessagePush.MessageTitle, strComparisonOp);
}
else
{
objvMessagePushEN.dicFldComparisonOp[convMessagePush.MessageTitle] = strComparisonOp;
}
}
return objvMessagePushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMessagePushEN SetMessageContent(this clsvMessagePushEN objvMessagePushEN, string strMessageContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMessageContent, 2000, convMessagePush.MessageContent);
objvMessagePushEN.MessageContent = strMessageContent; //消息内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushEN.dicFldComparisonOp.ContainsKey(convMessagePush.MessageContent) == false)
{
objvMessagePushEN.dicFldComparisonOp.Add(convMessagePush.MessageContent, strComparisonOp);
}
else
{
objvMessagePushEN.dicFldComparisonOp[convMessagePush.MessageContent] = strComparisonOp;
}
}
return objvMessagePushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMessagePushEN SetReceivePeople(this clsvMessagePushEN objvMessagePushEN, string strReceivePeople, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReceivePeople, 50, convMessagePush.ReceivePeople);
objvMessagePushEN.ReceivePeople = strReceivePeople; //接收人员
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushEN.dicFldComparisonOp.ContainsKey(convMessagePush.ReceivePeople) == false)
{
objvMessagePushEN.dicFldComparisonOp.Add(convMessagePush.ReceivePeople, strComparisonOp);
}
else
{
objvMessagePushEN.dicFldComparisonOp[convMessagePush.ReceivePeople] = strComparisonOp;
}
}
return objvMessagePushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMessagePushEN SetMessageTypeId(this clsvMessagePushEN objvMessagePushEN, string strMessageTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMessageTypeId, convMessagePush.MessageTypeId);
clsCheckSql.CheckFieldLen(strMessageTypeId, 8, convMessagePush.MessageTypeId);
clsCheckSql.CheckFieldForeignKey(strMessageTypeId, 8, convMessagePush.MessageTypeId);
objvMessagePushEN.MessageTypeId = strMessageTypeId; //消息类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushEN.dicFldComparisonOp.ContainsKey(convMessagePush.MessageTypeId) == false)
{
objvMessagePushEN.dicFldComparisonOp.Add(convMessagePush.MessageTypeId, strComparisonOp);
}
else
{
objvMessagePushEN.dicFldComparisonOp[convMessagePush.MessageTypeId] = strComparisonOp;
}
}
return objvMessagePushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMessagePushEN SetMessageTypeName(this clsvMessagePushEN objvMessagePushEN, string strMessageTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMessageTypeName, 200, convMessagePush.MessageTypeName);
objvMessagePushEN.MessageTypeName = strMessageTypeName; //消息类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushEN.dicFldComparisonOp.ContainsKey(convMessagePush.MessageTypeName) == false)
{
objvMessagePushEN.dicFldComparisonOp.Add(convMessagePush.MessageTypeName, strComparisonOp);
}
else
{
objvMessagePushEN.dicFldComparisonOp[convMessagePush.MessageTypeName] = strComparisonOp;
}
}
return objvMessagePushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMessagePushEN SetIsAllpush(this clsvMessagePushEN objvMessagePushEN, bool bolIsAllpush, string strComparisonOp="")
	{
objvMessagePushEN.IsAllpush = bolIsAllpush; //是否全体推送
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushEN.dicFldComparisonOp.ContainsKey(convMessagePush.IsAllpush) == false)
{
objvMessagePushEN.dicFldComparisonOp.Add(convMessagePush.IsAllpush, strComparisonOp);
}
else
{
objvMessagePushEN.dicFldComparisonOp[convMessagePush.IsAllpush] = strComparisonOp;
}
}
return objvMessagePushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMessagePushEN SetIsReceive(this clsvMessagePushEN objvMessagePushEN, bool bolIsReceive, string strComparisonOp="")
	{
objvMessagePushEN.IsReceive = bolIsReceive; //是否接收
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushEN.dicFldComparisonOp.ContainsKey(convMessagePush.IsReceive) == false)
{
objvMessagePushEN.dicFldComparisonOp.Add(convMessagePush.IsReceive, strComparisonOp);
}
else
{
objvMessagePushEN.dicFldComparisonOp[convMessagePush.IsReceive] = strComparisonOp;
}
}
return objvMessagePushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMessagePushEN SetClientVersionTypeId(this clsvMessagePushEN objvMessagePushEN, string strClientVersionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClientVersionTypeId, 8, convMessagePush.ClientVersionTypeId);
clsCheckSql.CheckFieldForeignKey(strClientVersionTypeId, 8, convMessagePush.ClientVersionTypeId);
objvMessagePushEN.ClientVersionTypeId = strClientVersionTypeId; //客户端版本类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushEN.dicFldComparisonOp.ContainsKey(convMessagePush.ClientVersionTypeId) == false)
{
objvMessagePushEN.dicFldComparisonOp.Add(convMessagePush.ClientVersionTypeId, strComparisonOp);
}
else
{
objvMessagePushEN.dicFldComparisonOp[convMessagePush.ClientVersionTypeId] = strComparisonOp;
}
}
return objvMessagePushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMessagePushEN SetUpdDate(this clsvMessagePushEN objvMessagePushEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convMessagePush.UpdDate);
objvMessagePushEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushEN.dicFldComparisonOp.ContainsKey(convMessagePush.UpdDate) == false)
{
objvMessagePushEN.dicFldComparisonOp.Add(convMessagePush.UpdDate, strComparisonOp);
}
else
{
objvMessagePushEN.dicFldComparisonOp[convMessagePush.UpdDate] = strComparisonOp;
}
}
return objvMessagePushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMessagePushEN SetMemo(this clsvMessagePushEN objvMessagePushEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMessagePush.Memo);
objvMessagePushEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushEN.dicFldComparisonOp.ContainsKey(convMessagePush.Memo) == false)
{
objvMessagePushEN.dicFldComparisonOp.Add(convMessagePush.Memo, strComparisonOp);
}
else
{
objvMessagePushEN.dicFldComparisonOp[convMessagePush.Memo] = strComparisonOp;
}
}
return objvMessagePushEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMessagePushEN objvMessagePush_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMessagePush_Cond.IsUpdated(convMessagePush.MessagePushId) == true)
{
string strComparisonOp_MessagePushId = objvMessagePush_Cond.dicFldComparisonOp[convMessagePush.MessagePushId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePush.MessagePushId, objvMessagePush_Cond.MessagePushId, strComparisonOp_MessagePushId);
}
if (objvMessagePush_Cond.IsUpdated(convMessagePush.MessagePushNumber) == true)
{
string strComparisonOp_MessagePushNumber = objvMessagePush_Cond.dicFldComparisonOp[convMessagePush.MessagePushNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePush.MessagePushNumber, objvMessagePush_Cond.MessagePushNumber, strComparisonOp_MessagePushNumber);
}
if (objvMessagePush_Cond.IsUpdated(convMessagePush.MessageTitle) == true)
{
string strComparisonOp_MessageTitle = objvMessagePush_Cond.dicFldComparisonOp[convMessagePush.MessageTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePush.MessageTitle, objvMessagePush_Cond.MessageTitle, strComparisonOp_MessageTitle);
}
if (objvMessagePush_Cond.IsUpdated(convMessagePush.MessageContent) == true)
{
string strComparisonOp_MessageContent = objvMessagePush_Cond.dicFldComparisonOp[convMessagePush.MessageContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePush.MessageContent, objvMessagePush_Cond.MessageContent, strComparisonOp_MessageContent);
}
if (objvMessagePush_Cond.IsUpdated(convMessagePush.ReceivePeople) == true)
{
string strComparisonOp_ReceivePeople = objvMessagePush_Cond.dicFldComparisonOp[convMessagePush.ReceivePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePush.ReceivePeople, objvMessagePush_Cond.ReceivePeople, strComparisonOp_ReceivePeople);
}
if (objvMessagePush_Cond.IsUpdated(convMessagePush.MessageTypeId) == true)
{
string strComparisonOp_MessageTypeId = objvMessagePush_Cond.dicFldComparisonOp[convMessagePush.MessageTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePush.MessageTypeId, objvMessagePush_Cond.MessageTypeId, strComparisonOp_MessageTypeId);
}
if (objvMessagePush_Cond.IsUpdated(convMessagePush.MessageTypeName) == true)
{
string strComparisonOp_MessageTypeName = objvMessagePush_Cond.dicFldComparisonOp[convMessagePush.MessageTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePush.MessageTypeName, objvMessagePush_Cond.MessageTypeName, strComparisonOp_MessageTypeName);
}
if (objvMessagePush_Cond.IsUpdated(convMessagePush.IsAllpush) == true)
{
if (objvMessagePush_Cond.IsAllpush == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMessagePush.IsAllpush);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMessagePush.IsAllpush);
}
}
if (objvMessagePush_Cond.IsUpdated(convMessagePush.IsReceive) == true)
{
if (objvMessagePush_Cond.IsReceive == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMessagePush.IsReceive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMessagePush.IsReceive);
}
}
if (objvMessagePush_Cond.IsUpdated(convMessagePush.ClientVersionTypeId) == true)
{
string strComparisonOp_ClientVersionTypeId = objvMessagePush_Cond.dicFldComparisonOp[convMessagePush.ClientVersionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePush.ClientVersionTypeId, objvMessagePush_Cond.ClientVersionTypeId, strComparisonOp_ClientVersionTypeId);
}
if (objvMessagePush_Cond.IsUpdated(convMessagePush.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvMessagePush_Cond.dicFldComparisonOp[convMessagePush.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePush.UpdDate, objvMessagePush_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvMessagePush_Cond.IsUpdated(convMessagePush.Memo) == true)
{
string strComparisonOp_Memo = objvMessagePush_Cond.dicFldComparisonOp[convMessagePush.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePush.Memo, objvMessagePush_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// 消息推送视图(vMessagePush)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvMessagePushWApi
{
private static readonly string mstrApiControllerName = "vMessagePushApi";

 public clsvMessagePushWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMessagePushId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMessagePushEN GetObjByMessagePushId(string strMessagePushId)
{
string strAction = "GetObjByMessagePushId";
string strErrMsg = string.Empty;
string strResult = "";
clsvMessagePushEN objvMessagePushEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MessagePushId"] = strMessagePushId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMessagePushEN = JsonConvert.DeserializeObject<clsvMessagePushEN>((string)jobjReturn["ReturnObj"]);
return objvMessagePushEN;
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
 /// <param name = "strMessagePushId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMessagePushEN GetObjByMessagePushId_WA_Cache(string strMessagePushId)
{
string strAction = "GetObjByMessagePushId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvMessagePushEN objvMessagePushEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MessagePushId"] = strMessagePushId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMessagePushEN = JsonConvert.DeserializeObject<clsvMessagePushEN>((string)jobjReturn["ReturnObj"]);
return objvMessagePushEN;
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
public static clsvMessagePushEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvMessagePushEN objvMessagePushEN = null;
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
objvMessagePushEN = JsonConvert.DeserializeObject<clsvMessagePushEN>((string)jobjReturn["ReturnObj"]);
return objvMessagePushEN;
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
 /// <param name = "strMessagePushId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMessagePushEN GetObjByMessagePushId_Cache(string strMessagePushId)
{
if (string.IsNullOrEmpty(strMessagePushId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvMessagePushEN._CurrTabName_S);
List<clsvMessagePushEN> arrvMessagePushObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMessagePushEN> arrvMessagePushObjLst_Sel =
from objvMessagePushEN in arrvMessagePushObjLst_Cache
where objvMessagePushEN.MessagePushId == strMessagePushId
select objvMessagePushEN;
if (arrvMessagePushObjLst_Sel.Count() == 0)
{
   clsvMessagePushEN obj = clsvMessagePushWApi.GetObjByMessagePushId(strMessagePushId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvMessagePushObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMessagePushEN> GetObjLst(string strWhereCond)
{
 List<clsvMessagePushEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMessagePushEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMessagePushEN> GetObjLstByMessagePushIdLst(List<string> arrMessagePushId)
{
 List<clsvMessagePushEN> arrObjLst = null; 
string strAction = "GetObjLstByMessagePushIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMessagePushId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMessagePushEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strMessagePushId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvMessagePushEN> GetObjLstByMessagePushIdLst_Cache(List<string> arrMessagePushId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMessagePushEN._CurrTabName_S);
List<clsvMessagePushEN> arrvMessagePushObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMessagePushEN> arrvMessagePushObjLst_Sel =
from objvMessagePushEN in arrvMessagePushObjLst_Cache
where arrMessagePushId.Contains(objvMessagePushEN.MessagePushId)
select objvMessagePushEN;
return arrvMessagePushObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMessagePushEN> GetObjLstByMessagePushIdLst_WA_Cache(List<string> arrMessagePushId)
{
 List<clsvMessagePushEN> arrObjLst = null; 
string strAction = "GetObjLstByMessagePushIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMessagePushId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMessagePushEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMessagePushEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvMessagePushEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMessagePushEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMessagePushEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvMessagePushEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMessagePushEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMessagePushEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvMessagePushEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMessagePushEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMessagePushEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvMessagePushEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMessagePushEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strMessagePushId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MessagePushId"] = strMessagePushId
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
 /// <param name = "objvMessagePushENS">源对象</param>
 /// <param name = "objvMessagePushENT">目标对象</param>
 public static void CopyTo(clsvMessagePushEN objvMessagePushENS, clsvMessagePushEN objvMessagePushENT)
{
try
{
objvMessagePushENT.MessagePushId = objvMessagePushENS.MessagePushId; //消息Id
objvMessagePushENT.MessagePushNumber = objvMessagePushENS.MessagePushNumber; //消息编号
objvMessagePushENT.MessageTitle = objvMessagePushENS.MessageTitle; //消息标题
objvMessagePushENT.MessageContent = objvMessagePushENS.MessageContent; //消息内容
objvMessagePushENT.ReceivePeople = objvMessagePushENS.ReceivePeople; //接收人员
objvMessagePushENT.MessageTypeId = objvMessagePushENS.MessageTypeId; //消息类型Id
objvMessagePushENT.MessageTypeName = objvMessagePushENS.MessageTypeName; //消息类型名称
objvMessagePushENT.IsAllpush = objvMessagePushENS.IsAllpush; //是否全体推送
objvMessagePushENT.IsReceive = objvMessagePushENS.IsReceive; //是否接收
objvMessagePushENT.ClientVersionTypeId = objvMessagePushENS.ClientVersionTypeId; //客户端版本类型Id
objvMessagePushENT.UpdDate = objvMessagePushENS.UpdDate; //修改日期
objvMessagePushENT.Memo = objvMessagePushENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvMessagePushEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvMessagePushEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvMessagePushEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvMessagePushEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvMessagePushEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvMessagePushEN.AttributeName)
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
if (clsMessagePushWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMessagePushWApi没有刷新缓存机制(clsMessagePushWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMessagePushTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMessagePushTypeWApi没有刷新缓存机制(clsMessagePushTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by MessagePushId");
//if (arrvMessagePushObjLst_Cache == null)
//{
//arrvMessagePushObjLst_Cache = await clsvMessagePushWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvMessagePushEN._CurrTabName_S);
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
public static List<clsvMessagePushEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvMessagePushEN._CurrTabName_S);
List<clsvMessagePushEN> arrvMessagePushObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMessagePushObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvMessagePushEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convMessagePush.MessagePushId, Type.GetType("System.String"));
objDT.Columns.Add(convMessagePush.MessagePushNumber, Type.GetType("System.String"));
objDT.Columns.Add(convMessagePush.MessageTitle, Type.GetType("System.String"));
objDT.Columns.Add(convMessagePush.MessageContent, Type.GetType("System.String"));
objDT.Columns.Add(convMessagePush.ReceivePeople, Type.GetType("System.String"));
objDT.Columns.Add(convMessagePush.MessageTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convMessagePush.MessageTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMessagePush.IsAllpush, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMessagePush.IsReceive, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMessagePush.ClientVersionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convMessagePush.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convMessagePush.Memo, Type.GetType("System.String"));
foreach (clsvMessagePushEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convMessagePush.MessagePushId] = objInFor[convMessagePush.MessagePushId];
objDR[convMessagePush.MessagePushNumber] = objInFor[convMessagePush.MessagePushNumber];
objDR[convMessagePush.MessageTitle] = objInFor[convMessagePush.MessageTitle];
objDR[convMessagePush.MessageContent] = objInFor[convMessagePush.MessageContent];
objDR[convMessagePush.ReceivePeople] = objInFor[convMessagePush.ReceivePeople];
objDR[convMessagePush.MessageTypeId] = objInFor[convMessagePush.MessageTypeId];
objDR[convMessagePush.MessageTypeName] = objInFor[convMessagePush.MessageTypeName];
objDR[convMessagePush.IsAllpush] = objInFor[convMessagePush.IsAllpush];
objDR[convMessagePush.IsReceive] = objInFor[convMessagePush.IsReceive];
objDR[convMessagePush.ClientVersionTypeId] = objInFor[convMessagePush.ClientVersionTypeId];
objDR[convMessagePush.UpdDate] = objInFor[convMessagePush.UpdDate];
objDR[convMessagePush.Memo] = objInFor[convMessagePush.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}