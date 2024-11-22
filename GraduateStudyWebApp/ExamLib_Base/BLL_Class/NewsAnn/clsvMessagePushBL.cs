
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMessagePushBL
 表名:vMessagePush(01120282)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:06:30
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:新闻公告(NewsAnn)
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
public static class  clsvMessagePushBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strMessagePushId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMessagePushEN GetObj(this K_MessagePushId_vMessagePush myKey)
{
clsvMessagePushEN objvMessagePushEN = clsvMessagePushBL.vMessagePushDA.GetObjByMessagePushId(myKey.Value);
return objvMessagePushEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMessagePushEN SetMessagePushId(this clsvMessagePushEN objvMessagePushEN, string strMessagePushId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMessagePushId, 8, convMessagePush.MessagePushId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMessagePushId, 8, convMessagePush.MessagePushId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMessagePushEN SetMessagePushNumber(this clsvMessagePushEN objvMessagePushEN, string strMessagePushNumber, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMessagePushNumber, 200, convMessagePush.MessagePushNumber);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMessagePushEN SetMessageTitle(this clsvMessagePushEN objvMessagePushEN, string strMessageTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMessageTitle, 500, convMessagePush.MessageTitle);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMessagePushEN SetMessageContent(this clsvMessagePushEN objvMessagePushEN, string strMessageContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMessageContent, 2000, convMessagePush.MessageContent);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMessagePushEN SetReceivePeople(this clsvMessagePushEN objvMessagePushEN, string strReceivePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReceivePeople, 50, convMessagePush.ReceivePeople);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMessagePushEN SetMessageTypeId(this clsvMessagePushEN objvMessagePushEN, string strMessageTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMessageTypeId, convMessagePush.MessageTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMessageTypeId, 8, convMessagePush.MessageTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMessageTypeId, 8, convMessagePush.MessageTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMessagePushEN SetMessageTypeName(this clsvMessagePushEN objvMessagePushEN, string strMessageTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMessageTypeName, 200, convMessagePush.MessageTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMessagePushEN SetClientVersionTypeId(this clsvMessagePushEN objvMessagePushEN, string strClientVersionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClientVersionTypeId, 8, convMessagePush.ClientVersionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClientVersionTypeId, 8, convMessagePush.ClientVersionTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMessagePushEN SetUpdDate(this clsvMessagePushEN objvMessagePushEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convMessagePush.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMessagePushEN SetMemo(this clsvMessagePushEN objvMessagePushEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMessagePush.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvMessagePushENS">源对象</param>
 /// <param name = "objvMessagePushENT">目标对象</param>
 public static void CopyTo(this clsvMessagePushEN objvMessagePushENS, clsvMessagePushEN objvMessagePushENT)
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
 /// <param name = "objvMessagePushENS">源对象</param>
 /// <returns>目标对象=>clsvMessagePushEN:objvMessagePushENT</returns>
 public static clsvMessagePushEN CopyTo(this clsvMessagePushEN objvMessagePushENS)
{
try
{
 clsvMessagePushEN objvMessagePushENT = new clsvMessagePushEN()
{
MessagePushId = objvMessagePushENS.MessagePushId, //消息Id
MessagePushNumber = objvMessagePushENS.MessagePushNumber, //消息编号
MessageTitle = objvMessagePushENS.MessageTitle, //消息标题
MessageContent = objvMessagePushENS.MessageContent, //消息内容
ReceivePeople = objvMessagePushENS.ReceivePeople, //接收人员
MessageTypeId = objvMessagePushENS.MessageTypeId, //消息类型Id
MessageTypeName = objvMessagePushENS.MessageTypeName, //消息类型名称
IsAllpush = objvMessagePushENS.IsAllpush, //是否全体推送
IsReceive = objvMessagePushENS.IsReceive, //是否接收
ClientVersionTypeId = objvMessagePushENS.ClientVersionTypeId, //客户端版本类型Id
UpdDate = objvMessagePushENS.UpdDate, //修改日期
Memo = objvMessagePushENS.Memo, //备注
};
 return objvMessagePushENT;
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
public static void CheckProperty4Condition(this clsvMessagePushEN objvMessagePushEN)
{
 clsvMessagePushBL.vMessagePushDA.CheckProperty4Condition(objvMessagePushEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMessagePushEN objvMessagePushCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMessagePushCond.IsUpdated(convMessagePush.MessagePushId) == true)
{
string strComparisonOpMessagePushId = objvMessagePushCond.dicFldComparisonOp[convMessagePush.MessagePushId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePush.MessagePushId, objvMessagePushCond.MessagePushId, strComparisonOpMessagePushId);
}
if (objvMessagePushCond.IsUpdated(convMessagePush.MessagePushNumber) == true)
{
string strComparisonOpMessagePushNumber = objvMessagePushCond.dicFldComparisonOp[convMessagePush.MessagePushNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePush.MessagePushNumber, objvMessagePushCond.MessagePushNumber, strComparisonOpMessagePushNumber);
}
if (objvMessagePushCond.IsUpdated(convMessagePush.MessageTitle) == true)
{
string strComparisonOpMessageTitle = objvMessagePushCond.dicFldComparisonOp[convMessagePush.MessageTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePush.MessageTitle, objvMessagePushCond.MessageTitle, strComparisonOpMessageTitle);
}
if (objvMessagePushCond.IsUpdated(convMessagePush.MessageContent) == true)
{
string strComparisonOpMessageContent = objvMessagePushCond.dicFldComparisonOp[convMessagePush.MessageContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePush.MessageContent, objvMessagePushCond.MessageContent, strComparisonOpMessageContent);
}
if (objvMessagePushCond.IsUpdated(convMessagePush.ReceivePeople) == true)
{
string strComparisonOpReceivePeople = objvMessagePushCond.dicFldComparisonOp[convMessagePush.ReceivePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePush.ReceivePeople, objvMessagePushCond.ReceivePeople, strComparisonOpReceivePeople);
}
if (objvMessagePushCond.IsUpdated(convMessagePush.MessageTypeId) == true)
{
string strComparisonOpMessageTypeId = objvMessagePushCond.dicFldComparisonOp[convMessagePush.MessageTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePush.MessageTypeId, objvMessagePushCond.MessageTypeId, strComparisonOpMessageTypeId);
}
if (objvMessagePushCond.IsUpdated(convMessagePush.MessageTypeName) == true)
{
string strComparisonOpMessageTypeName = objvMessagePushCond.dicFldComparisonOp[convMessagePush.MessageTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePush.MessageTypeName, objvMessagePushCond.MessageTypeName, strComparisonOpMessageTypeName);
}
if (objvMessagePushCond.IsUpdated(convMessagePush.IsAllpush) == true)
{
if (objvMessagePushCond.IsAllpush == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMessagePush.IsAllpush);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMessagePush.IsAllpush);
}
}
if (objvMessagePushCond.IsUpdated(convMessagePush.IsReceive) == true)
{
if (objvMessagePushCond.IsReceive == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMessagePush.IsReceive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMessagePush.IsReceive);
}
}
if (objvMessagePushCond.IsUpdated(convMessagePush.ClientVersionTypeId) == true)
{
string strComparisonOpClientVersionTypeId = objvMessagePushCond.dicFldComparisonOp[convMessagePush.ClientVersionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePush.ClientVersionTypeId, objvMessagePushCond.ClientVersionTypeId, strComparisonOpClientVersionTypeId);
}
if (objvMessagePushCond.IsUpdated(convMessagePush.UpdDate) == true)
{
string strComparisonOpUpdDate = objvMessagePushCond.dicFldComparisonOp[convMessagePush.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePush.UpdDate, objvMessagePushCond.UpdDate, strComparisonOpUpdDate);
}
if (objvMessagePushCond.IsUpdated(convMessagePush.Memo) == true)
{
string strComparisonOpMemo = objvMessagePushCond.dicFldComparisonOp[convMessagePush.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePush.Memo, objvMessagePushCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vMessagePush
{
public virtual bool UpdRelaTabDate(string strMessagePushId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 消息推送视图(vMessagePush)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvMessagePushBL
{
public static RelatedActions_vMessagePush relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvMessagePushDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvMessagePushDA vMessagePushDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvMessagePushDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvMessagePushBL()
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
if (string.IsNullOrEmpty(clsvMessagePushEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMessagePushEN._ConnectString);
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
public static DataTable GetDataTable_vMessagePush(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vMessagePushDA.GetDataTable_vMessagePush(strWhereCond);
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
objDT = vMessagePushDA.GetDataTable(strWhereCond);
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
objDT = vMessagePushDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vMessagePushDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vMessagePushDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vMessagePushDA.GetDataTable_Top(objTopPara);
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
objDT = vMessagePushDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vMessagePushDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vMessagePushDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMessagePushIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvMessagePushEN> GetObjLstByMessagePushIdLst(List<string> arrMessagePushIdLst)
{
List<clsvMessagePushEN> arrObjLst = new List<clsvMessagePushEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMessagePushIdLst, true);
 string strWhereCond = string.Format("MessagePushId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMessagePushEN objvMessagePushEN = new clsvMessagePushEN();
try
{
objvMessagePushEN.MessagePushId = objRow[convMessagePush.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushEN.MessagePushNumber = objRow[convMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushEN.MessageTitle = objRow[convMessagePush.MessageTitle] == DBNull.Value ? null : objRow[convMessagePush.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushEN.MessageContent = objRow[convMessagePush.MessageContent] == DBNull.Value ? null : objRow[convMessagePush.MessageContent].ToString().Trim(); //消息内容
objvMessagePushEN.ReceivePeople = objRow[convMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[convMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushEN.MessageTypeId = objRow[convMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushEN.MessageTypeName = objRow[convMessagePush.MessageTypeName] == DBNull.Value ? null : objRow[convMessagePush.MessageTypeName].ToString().Trim(); //消息类型名称
objvMessagePushEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[convMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convMessagePush.IsReceive].ToString().Trim()); //是否接收
objvMessagePushEN.ClientVersionTypeId = objRow[convMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushEN.UpdDate = objRow[convMessagePush.UpdDate] == DBNull.Value ? null : objRow[convMessagePush.UpdDate].ToString().Trim(); //修改日期
objvMessagePushEN.Memo = objRow[convMessagePush.Memo] == DBNull.Value ? null : objRow[convMessagePush.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMessagePushEN.MessagePushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMessagePushEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMessagePushIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvMessagePushEN> GetObjLstByMessagePushIdLstCache(List<string> arrMessagePushIdLst)
{
string strKey = string.Format("{0}", clsvMessagePushEN._CurrTabName);
List<clsvMessagePushEN> arrvMessagePushObjLstCache = GetObjLstCache();
IEnumerable <clsvMessagePushEN> arrvMessagePushObjLst_Sel =
arrvMessagePushObjLstCache
.Where(x => arrMessagePushIdLst.Contains(x.MessagePushId));
return arrvMessagePushObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMessagePushEN> GetObjLst(string strWhereCond)
{
List<clsvMessagePushEN> arrObjLst = new List<clsvMessagePushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMessagePushEN objvMessagePushEN = new clsvMessagePushEN();
try
{
objvMessagePushEN.MessagePushId = objRow[convMessagePush.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushEN.MessagePushNumber = objRow[convMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushEN.MessageTitle = objRow[convMessagePush.MessageTitle] == DBNull.Value ? null : objRow[convMessagePush.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushEN.MessageContent = objRow[convMessagePush.MessageContent] == DBNull.Value ? null : objRow[convMessagePush.MessageContent].ToString().Trim(); //消息内容
objvMessagePushEN.ReceivePeople = objRow[convMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[convMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushEN.MessageTypeId = objRow[convMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushEN.MessageTypeName = objRow[convMessagePush.MessageTypeName] == DBNull.Value ? null : objRow[convMessagePush.MessageTypeName].ToString().Trim(); //消息类型名称
objvMessagePushEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[convMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convMessagePush.IsReceive].ToString().Trim()); //是否接收
objvMessagePushEN.ClientVersionTypeId = objRow[convMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushEN.UpdDate = objRow[convMessagePush.UpdDate] == DBNull.Value ? null : objRow[convMessagePush.UpdDate].ToString().Trim(); //修改日期
objvMessagePushEN.Memo = objRow[convMessagePush.Memo] == DBNull.Value ? null : objRow[convMessagePush.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMessagePushEN.MessagePushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMessagePushEN);
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
public static List<clsvMessagePushEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvMessagePushEN> arrObjLst = new List<clsvMessagePushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMessagePushEN objvMessagePushEN = new clsvMessagePushEN();
try
{
objvMessagePushEN.MessagePushId = objRow[convMessagePush.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushEN.MessagePushNumber = objRow[convMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushEN.MessageTitle = objRow[convMessagePush.MessageTitle] == DBNull.Value ? null : objRow[convMessagePush.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushEN.MessageContent = objRow[convMessagePush.MessageContent] == DBNull.Value ? null : objRow[convMessagePush.MessageContent].ToString().Trim(); //消息内容
objvMessagePushEN.ReceivePeople = objRow[convMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[convMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushEN.MessageTypeId = objRow[convMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushEN.MessageTypeName = objRow[convMessagePush.MessageTypeName] == DBNull.Value ? null : objRow[convMessagePush.MessageTypeName].ToString().Trim(); //消息类型名称
objvMessagePushEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[convMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convMessagePush.IsReceive].ToString().Trim()); //是否接收
objvMessagePushEN.ClientVersionTypeId = objRow[convMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushEN.UpdDate = objRow[convMessagePush.UpdDate] == DBNull.Value ? null : objRow[convMessagePush.UpdDate].ToString().Trim(); //修改日期
objvMessagePushEN.Memo = objRow[convMessagePush.Memo] == DBNull.Value ? null : objRow[convMessagePush.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMessagePushEN.MessagePushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMessagePushEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvMessagePushCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvMessagePushEN> GetSubObjLstCache(clsvMessagePushEN objvMessagePushCond)
{
List<clsvMessagePushEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMessagePushEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMessagePush.AttributeName)
{
if (objvMessagePushCond.IsUpdated(strFldName) == false) continue;
if (objvMessagePushCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMessagePushCond[strFldName].ToString());
}
else
{
if (objvMessagePushCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMessagePushCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMessagePushCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMessagePushCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMessagePushCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMessagePushCond[strFldName]));
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
public static List<clsvMessagePushEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvMessagePushEN> arrObjLst = new List<clsvMessagePushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMessagePushEN objvMessagePushEN = new clsvMessagePushEN();
try
{
objvMessagePushEN.MessagePushId = objRow[convMessagePush.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushEN.MessagePushNumber = objRow[convMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushEN.MessageTitle = objRow[convMessagePush.MessageTitle] == DBNull.Value ? null : objRow[convMessagePush.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushEN.MessageContent = objRow[convMessagePush.MessageContent] == DBNull.Value ? null : objRow[convMessagePush.MessageContent].ToString().Trim(); //消息内容
objvMessagePushEN.ReceivePeople = objRow[convMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[convMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushEN.MessageTypeId = objRow[convMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushEN.MessageTypeName = objRow[convMessagePush.MessageTypeName] == DBNull.Value ? null : objRow[convMessagePush.MessageTypeName].ToString().Trim(); //消息类型名称
objvMessagePushEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[convMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convMessagePush.IsReceive].ToString().Trim()); //是否接收
objvMessagePushEN.ClientVersionTypeId = objRow[convMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushEN.UpdDate = objRow[convMessagePush.UpdDate] == DBNull.Value ? null : objRow[convMessagePush.UpdDate].ToString().Trim(); //修改日期
objvMessagePushEN.Memo = objRow[convMessagePush.Memo] == DBNull.Value ? null : objRow[convMessagePush.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMessagePushEN.MessagePushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMessagePushEN);
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
public static List<clsvMessagePushEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvMessagePushEN> arrObjLst = new List<clsvMessagePushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMessagePushEN objvMessagePushEN = new clsvMessagePushEN();
try
{
objvMessagePushEN.MessagePushId = objRow[convMessagePush.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushEN.MessagePushNumber = objRow[convMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushEN.MessageTitle = objRow[convMessagePush.MessageTitle] == DBNull.Value ? null : objRow[convMessagePush.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushEN.MessageContent = objRow[convMessagePush.MessageContent] == DBNull.Value ? null : objRow[convMessagePush.MessageContent].ToString().Trim(); //消息内容
objvMessagePushEN.ReceivePeople = objRow[convMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[convMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushEN.MessageTypeId = objRow[convMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushEN.MessageTypeName = objRow[convMessagePush.MessageTypeName] == DBNull.Value ? null : objRow[convMessagePush.MessageTypeName].ToString().Trim(); //消息类型名称
objvMessagePushEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[convMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convMessagePush.IsReceive].ToString().Trim()); //是否接收
objvMessagePushEN.ClientVersionTypeId = objRow[convMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushEN.UpdDate = objRow[convMessagePush.UpdDate] == DBNull.Value ? null : objRow[convMessagePush.UpdDate].ToString().Trim(); //修改日期
objvMessagePushEN.Memo = objRow[convMessagePush.Memo] == DBNull.Value ? null : objRow[convMessagePush.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMessagePushEN.MessagePushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMessagePushEN);
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
List<clsvMessagePushEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvMessagePushEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMessagePushEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvMessagePushEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvMessagePushEN> arrObjLst = new List<clsvMessagePushEN>(); 
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
	clsvMessagePushEN objvMessagePushEN = new clsvMessagePushEN();
try
{
objvMessagePushEN.MessagePushId = objRow[convMessagePush.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushEN.MessagePushNumber = objRow[convMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushEN.MessageTitle = objRow[convMessagePush.MessageTitle] == DBNull.Value ? null : objRow[convMessagePush.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushEN.MessageContent = objRow[convMessagePush.MessageContent] == DBNull.Value ? null : objRow[convMessagePush.MessageContent].ToString().Trim(); //消息内容
objvMessagePushEN.ReceivePeople = objRow[convMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[convMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushEN.MessageTypeId = objRow[convMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushEN.MessageTypeName = objRow[convMessagePush.MessageTypeName] == DBNull.Value ? null : objRow[convMessagePush.MessageTypeName].ToString().Trim(); //消息类型名称
objvMessagePushEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[convMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convMessagePush.IsReceive].ToString().Trim()); //是否接收
objvMessagePushEN.ClientVersionTypeId = objRow[convMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushEN.UpdDate = objRow[convMessagePush.UpdDate] == DBNull.Value ? null : objRow[convMessagePush.UpdDate].ToString().Trim(); //修改日期
objvMessagePushEN.Memo = objRow[convMessagePush.Memo] == DBNull.Value ? null : objRow[convMessagePush.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMessagePushEN.MessagePushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMessagePushEN);
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
public static List<clsvMessagePushEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvMessagePushEN> arrObjLst = new List<clsvMessagePushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMessagePushEN objvMessagePushEN = new clsvMessagePushEN();
try
{
objvMessagePushEN.MessagePushId = objRow[convMessagePush.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushEN.MessagePushNumber = objRow[convMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushEN.MessageTitle = objRow[convMessagePush.MessageTitle] == DBNull.Value ? null : objRow[convMessagePush.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushEN.MessageContent = objRow[convMessagePush.MessageContent] == DBNull.Value ? null : objRow[convMessagePush.MessageContent].ToString().Trim(); //消息内容
objvMessagePushEN.ReceivePeople = objRow[convMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[convMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushEN.MessageTypeId = objRow[convMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushEN.MessageTypeName = objRow[convMessagePush.MessageTypeName] == DBNull.Value ? null : objRow[convMessagePush.MessageTypeName].ToString().Trim(); //消息类型名称
objvMessagePushEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[convMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convMessagePush.IsReceive].ToString().Trim()); //是否接收
objvMessagePushEN.ClientVersionTypeId = objRow[convMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushEN.UpdDate = objRow[convMessagePush.UpdDate] == DBNull.Value ? null : objRow[convMessagePush.UpdDate].ToString().Trim(); //修改日期
objvMessagePushEN.Memo = objRow[convMessagePush.Memo] == DBNull.Value ? null : objRow[convMessagePush.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMessagePushEN.MessagePushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMessagePushEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvMessagePushEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvMessagePushEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvMessagePushEN> arrObjLst = new List<clsvMessagePushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMessagePushEN objvMessagePushEN = new clsvMessagePushEN();
try
{
objvMessagePushEN.MessagePushId = objRow[convMessagePush.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushEN.MessagePushNumber = objRow[convMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushEN.MessageTitle = objRow[convMessagePush.MessageTitle] == DBNull.Value ? null : objRow[convMessagePush.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushEN.MessageContent = objRow[convMessagePush.MessageContent] == DBNull.Value ? null : objRow[convMessagePush.MessageContent].ToString().Trim(); //消息内容
objvMessagePushEN.ReceivePeople = objRow[convMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[convMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushEN.MessageTypeId = objRow[convMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushEN.MessageTypeName = objRow[convMessagePush.MessageTypeName] == DBNull.Value ? null : objRow[convMessagePush.MessageTypeName].ToString().Trim(); //消息类型名称
objvMessagePushEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[convMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convMessagePush.IsReceive].ToString().Trim()); //是否接收
objvMessagePushEN.ClientVersionTypeId = objRow[convMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushEN.UpdDate = objRow[convMessagePush.UpdDate] == DBNull.Value ? null : objRow[convMessagePush.UpdDate].ToString().Trim(); //修改日期
objvMessagePushEN.Memo = objRow[convMessagePush.Memo] == DBNull.Value ? null : objRow[convMessagePush.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMessagePushEN.MessagePushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMessagePushEN);
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
public static List<clsvMessagePushEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvMessagePushEN> arrObjLst = new List<clsvMessagePushEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMessagePushEN objvMessagePushEN = new clsvMessagePushEN();
try
{
objvMessagePushEN.MessagePushId = objRow[convMessagePush.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushEN.MessagePushNumber = objRow[convMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushEN.MessageTitle = objRow[convMessagePush.MessageTitle] == DBNull.Value ? null : objRow[convMessagePush.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushEN.MessageContent = objRow[convMessagePush.MessageContent] == DBNull.Value ? null : objRow[convMessagePush.MessageContent].ToString().Trim(); //消息内容
objvMessagePushEN.ReceivePeople = objRow[convMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[convMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushEN.MessageTypeId = objRow[convMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushEN.MessageTypeName = objRow[convMessagePush.MessageTypeName] == DBNull.Value ? null : objRow[convMessagePush.MessageTypeName].ToString().Trim(); //消息类型名称
objvMessagePushEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[convMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convMessagePush.IsReceive].ToString().Trim()); //是否接收
objvMessagePushEN.ClientVersionTypeId = objRow[convMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushEN.UpdDate = objRow[convMessagePush.UpdDate] == DBNull.Value ? null : objRow[convMessagePush.UpdDate].ToString().Trim(); //修改日期
objvMessagePushEN.Memo = objRow[convMessagePush.Memo] == DBNull.Value ? null : objRow[convMessagePush.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMessagePushEN.MessagePushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMessagePushEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMessagePushEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvMessagePushEN> arrObjLst = new List<clsvMessagePushEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMessagePushEN objvMessagePushEN = new clsvMessagePushEN();
try
{
objvMessagePushEN.MessagePushId = objRow[convMessagePush.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushEN.MessagePushNumber = objRow[convMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushEN.MessageTitle = objRow[convMessagePush.MessageTitle] == DBNull.Value ? null : objRow[convMessagePush.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushEN.MessageContent = objRow[convMessagePush.MessageContent] == DBNull.Value ? null : objRow[convMessagePush.MessageContent].ToString().Trim(); //消息内容
objvMessagePushEN.ReceivePeople = objRow[convMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[convMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushEN.MessageTypeId = objRow[convMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushEN.MessageTypeName = objRow[convMessagePush.MessageTypeName] == DBNull.Value ? null : objRow[convMessagePush.MessageTypeName].ToString().Trim(); //消息类型名称
objvMessagePushEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[convMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convMessagePush.IsReceive].ToString().Trim()); //是否接收
objvMessagePushEN.ClientVersionTypeId = objRow[convMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushEN.UpdDate = objRow[convMessagePush.UpdDate] == DBNull.Value ? null : objRow[convMessagePush.UpdDate].ToString().Trim(); //修改日期
objvMessagePushEN.Memo = objRow[convMessagePush.Memo] == DBNull.Value ? null : objRow[convMessagePush.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMessagePushEN.MessagePushId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMessagePushEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvMessagePushEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvMessagePush(ref clsvMessagePushEN objvMessagePushEN)
{
bool bolResult = vMessagePushDA.GetvMessagePush(ref objvMessagePushEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strMessagePushId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMessagePushEN GetObjByMessagePushId(string strMessagePushId)
{
if (strMessagePushId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strMessagePushId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strMessagePushId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strMessagePushId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvMessagePushEN objvMessagePushEN = vMessagePushDA.GetObjByMessagePushId(strMessagePushId);
return objvMessagePushEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvMessagePushEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvMessagePushEN objvMessagePushEN = vMessagePushDA.GetFirstObj(strWhereCond);
 return objvMessagePushEN;
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
public static clsvMessagePushEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvMessagePushEN objvMessagePushEN = vMessagePushDA.GetObjByDataRow(objRow);
 return objvMessagePushEN;
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
public static clsvMessagePushEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvMessagePushEN objvMessagePushEN = vMessagePushDA.GetObjByDataRow(objRow);
 return objvMessagePushEN;
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
 /// <param name = "strMessagePushId">所给的关键字</param>
 /// <param name = "lstvMessagePushObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMessagePushEN GetObjByMessagePushIdFromList(string strMessagePushId, List<clsvMessagePushEN> lstvMessagePushObjLst)
{
foreach (clsvMessagePushEN objvMessagePushEN in lstvMessagePushObjLst)
{
if (objvMessagePushEN.MessagePushId == strMessagePushId)
{
return objvMessagePushEN;
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
 string strMessagePushId;
 try
 {
 strMessagePushId = new clsvMessagePushDA().GetFirstID(strWhereCond);
 return strMessagePushId;
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
 arrList = vMessagePushDA.GetID(strWhereCond);
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
bool bolIsExist = vMessagePushDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strMessagePushId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strMessagePushId)
{
if (string.IsNullOrEmpty(strMessagePushId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strMessagePushId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vMessagePushDA.IsExist(strMessagePushId);
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
 bolIsExist = clsvMessagePushDA.IsExistTable();
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
 bolIsExist = vMessagePushDA.IsExistTable(strTabName);
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
 /// <param name = "objvMessagePushEN">源简化对象</param>
 public static void SetUpdFlag(clsvMessagePushEN objvMessagePushEN)
{
try
{
objvMessagePushEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvMessagePushEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convMessagePush.MessagePushId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushEN.MessagePushId = objvMessagePushEN.MessagePushId; //消息Id
}
if (arrFldSet.Contains(convMessagePush.MessagePushNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushEN.MessagePushNumber = objvMessagePushEN.MessagePushNumber == "[null]" ? null :  objvMessagePushEN.MessagePushNumber; //消息编号
}
if (arrFldSet.Contains(convMessagePush.MessageTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushEN.MessageTitle = objvMessagePushEN.MessageTitle == "[null]" ? null :  objvMessagePushEN.MessageTitle; //消息标题
}
if (arrFldSet.Contains(convMessagePush.MessageContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushEN.MessageContent = objvMessagePushEN.MessageContent == "[null]" ? null :  objvMessagePushEN.MessageContent; //消息内容
}
if (arrFldSet.Contains(convMessagePush.ReceivePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushEN.ReceivePeople = objvMessagePushEN.ReceivePeople == "[null]" ? null :  objvMessagePushEN.ReceivePeople; //接收人员
}
if (arrFldSet.Contains(convMessagePush.MessageTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushEN.MessageTypeId = objvMessagePushEN.MessageTypeId; //消息类型Id
}
if (arrFldSet.Contains(convMessagePush.MessageTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushEN.MessageTypeName = objvMessagePushEN.MessageTypeName == "[null]" ? null :  objvMessagePushEN.MessageTypeName; //消息类型名称
}
if (arrFldSet.Contains(convMessagePush.IsAllpush, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushEN.IsAllpush = objvMessagePushEN.IsAllpush; //是否全体推送
}
if (arrFldSet.Contains(convMessagePush.IsReceive, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushEN.IsReceive = objvMessagePushEN.IsReceive; //是否接收
}
if (arrFldSet.Contains(convMessagePush.ClientVersionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushEN.ClientVersionTypeId = objvMessagePushEN.ClientVersionTypeId == "[null]" ? null :  objvMessagePushEN.ClientVersionTypeId; //客户端版本类型Id
}
if (arrFldSet.Contains(convMessagePush.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushEN.UpdDate = objvMessagePushEN.UpdDate == "[null]" ? null :  objvMessagePushEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convMessagePush.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushEN.Memo = objvMessagePushEN.Memo == "[null]" ? null :  objvMessagePushEN.Memo; //备注
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
 /// <param name = "objvMessagePushEN">源简化对象</param>
 public static void AccessFldValueNull(clsvMessagePushEN objvMessagePushEN)
{
try
{
if (objvMessagePushEN.MessagePushNumber == "[null]") objvMessagePushEN.MessagePushNumber = null; //消息编号
if (objvMessagePushEN.MessageTitle == "[null]") objvMessagePushEN.MessageTitle = null; //消息标题
if (objvMessagePushEN.MessageContent == "[null]") objvMessagePushEN.MessageContent = null; //消息内容
if (objvMessagePushEN.ReceivePeople == "[null]") objvMessagePushEN.ReceivePeople = null; //接收人员
if (objvMessagePushEN.MessageTypeName == "[null]") objvMessagePushEN.MessageTypeName = null; //消息类型名称
if (objvMessagePushEN.ClientVersionTypeId == "[null]") objvMessagePushEN.ClientVersionTypeId = null; //客户端版本类型Id
if (objvMessagePushEN.UpdDate == "[null]") objvMessagePushEN.UpdDate = null; //修改日期
if (objvMessagePushEN.Memo == "[null]") objvMessagePushEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvMessagePushEN objvMessagePushEN)
{
 vMessagePushDA.CheckProperty4Condition(objvMessagePushEN);
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
if (clsMessagePushBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMessagePushBL没有刷新缓存机制(clsMessagePushBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMessagePushTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMessagePushTypeBL没有刷新缓存机制(clsMessagePushTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by MessagePushId");
//if (arrvMessagePushObjLstCache == null)
//{
//arrvMessagePushObjLstCache = vMessagePushDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strMessagePushId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMessagePushEN GetObjByMessagePushIdCache(string strMessagePushId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvMessagePushEN._CurrTabName);
List<clsvMessagePushEN> arrvMessagePushObjLstCache = GetObjLstCache();
IEnumerable <clsvMessagePushEN> arrvMessagePushObjLst_Sel =
arrvMessagePushObjLstCache
.Where(x=> x.MessagePushId == strMessagePushId 
);
if (arrvMessagePushObjLst_Sel.Count() == 0)
{
   clsvMessagePushEN obj = clsvMessagePushBL.GetObjByMessagePushId(strMessagePushId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvMessagePushObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMessagePushEN> GetAllvMessagePushObjLstCache()
{
//获取缓存中的对象列表
List<clsvMessagePushEN> arrvMessagePushObjLstCache = GetObjLstCache(); 
return arrvMessagePushObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMessagePushEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvMessagePushEN._CurrTabName);
List<clsvMessagePushEN> arrvMessagePushObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMessagePushObjLstCache;
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
string strKey = string.Format("{0}", clsvMessagePushEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strMessagePushId)
{
if (strInFldName != convMessagePush.MessagePushId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convMessagePush.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convMessagePush.AttributeName));
throw new Exception(strMsg);
}
var objvMessagePush = clsvMessagePushBL.GetObjByMessagePushIdCache(strMessagePushId);
if (objvMessagePush == null) return "";
return objvMessagePush[strOutFldName].ToString();
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
int intRecCount = clsvMessagePushDA.GetRecCount(strTabName);
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
int intRecCount = clsvMessagePushDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvMessagePushDA.GetRecCount();
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
int intRecCount = clsvMessagePushDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvMessagePushCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvMessagePushEN objvMessagePushCond)
{
List<clsvMessagePushEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMessagePushEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMessagePush.AttributeName)
{
if (objvMessagePushCond.IsUpdated(strFldName) == false) continue;
if (objvMessagePushCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMessagePushCond[strFldName].ToString());
}
else
{
if (objvMessagePushCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMessagePushCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMessagePushCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMessagePushCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMessagePushCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMessagePushCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMessagePushCond[strFldName]));
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
 List<string> arrList = clsvMessagePushDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vMessagePushDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vMessagePushDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}