
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMessagePushUsersRelationBL
 表名:vMessagePushUsersRelation(01120285)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:38
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
public static class  clsvMessagePushUsersRelationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngMessagePushUsersRelationId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMessagePushUsersRelationEN GetObj(this K_MessagePushUsersRelationId_vMessagePushUsersRelation myKey)
{
clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = clsvMessagePushUsersRelationBL.vMessagePushUsersRelationDA.GetObjByMessagePushUsersRelationId(myKey.Value);
return objvMessagePushUsersRelationEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMessagePushUsersRelationEN SetMessagePushUsersRelationId(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN, long lngMessagePushUsersRelationId, string strComparisonOp="")
	{
objvMessagePushUsersRelationEN.MessagePushUsersRelationId = lngMessagePushUsersRelationId; //消息推送与用户关系Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushUsersRelationEN.dicFldComparisonOp.ContainsKey(convMessagePushUsersRelation.MessagePushUsersRelationId) == false)
{
objvMessagePushUsersRelationEN.dicFldComparisonOp.Add(convMessagePushUsersRelation.MessagePushUsersRelationId, strComparisonOp);
}
else
{
objvMessagePushUsersRelationEN.dicFldComparisonOp[convMessagePushUsersRelation.MessagePushUsersRelationId] = strComparisonOp;
}
}
return objvMessagePushUsersRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMessagePushUsersRelationEN SetMessagePushId(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN, string strMessagePushId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMessagePushId, convMessagePushUsersRelation.MessagePushId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMessagePushId, 8, convMessagePushUsersRelation.MessagePushId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMessagePushId, 8, convMessagePushUsersRelation.MessagePushId);
}
objvMessagePushUsersRelationEN.MessagePushId = strMessagePushId; //消息Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushUsersRelationEN.dicFldComparisonOp.ContainsKey(convMessagePushUsersRelation.MessagePushId) == false)
{
objvMessagePushUsersRelationEN.dicFldComparisonOp.Add(convMessagePushUsersRelation.MessagePushId, strComparisonOp);
}
else
{
objvMessagePushUsersRelationEN.dicFldComparisonOp[convMessagePushUsersRelation.MessagePushId] = strComparisonOp;
}
}
return objvMessagePushUsersRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMessagePushUsersRelationEN SetMessagePushNumber(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN, string strMessagePushNumber, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMessagePushNumber, 200, convMessagePushUsersRelation.MessagePushNumber);
}
objvMessagePushUsersRelationEN.MessagePushNumber = strMessagePushNumber; //消息编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushUsersRelationEN.dicFldComparisonOp.ContainsKey(convMessagePushUsersRelation.MessagePushNumber) == false)
{
objvMessagePushUsersRelationEN.dicFldComparisonOp.Add(convMessagePushUsersRelation.MessagePushNumber, strComparisonOp);
}
else
{
objvMessagePushUsersRelationEN.dicFldComparisonOp[convMessagePushUsersRelation.MessagePushNumber] = strComparisonOp;
}
}
return objvMessagePushUsersRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMessagePushUsersRelationEN SetMessageTitle(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN, string strMessageTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMessageTitle, 500, convMessagePushUsersRelation.MessageTitle);
}
objvMessagePushUsersRelationEN.MessageTitle = strMessageTitle; //消息标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushUsersRelationEN.dicFldComparisonOp.ContainsKey(convMessagePushUsersRelation.MessageTitle) == false)
{
objvMessagePushUsersRelationEN.dicFldComparisonOp.Add(convMessagePushUsersRelation.MessageTitle, strComparisonOp);
}
else
{
objvMessagePushUsersRelationEN.dicFldComparisonOp[convMessagePushUsersRelation.MessageTitle] = strComparisonOp;
}
}
return objvMessagePushUsersRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMessagePushUsersRelationEN SetMessageContent(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN, string strMessageContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMessageContent, 2000, convMessagePushUsersRelation.MessageContent);
}
objvMessagePushUsersRelationEN.MessageContent = strMessageContent; //消息内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushUsersRelationEN.dicFldComparisonOp.ContainsKey(convMessagePushUsersRelation.MessageContent) == false)
{
objvMessagePushUsersRelationEN.dicFldComparisonOp.Add(convMessagePushUsersRelation.MessageContent, strComparisonOp);
}
else
{
objvMessagePushUsersRelationEN.dicFldComparisonOp[convMessagePushUsersRelation.MessageContent] = strComparisonOp;
}
}
return objvMessagePushUsersRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMessagePushUsersRelationEN SetMessageTypeId(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN, string strMessageTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMessageTypeId, 8, convMessagePushUsersRelation.MessageTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMessageTypeId, 8, convMessagePushUsersRelation.MessageTypeId);
}
objvMessagePushUsersRelationEN.MessageTypeId = strMessageTypeId; //消息类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushUsersRelationEN.dicFldComparisonOp.ContainsKey(convMessagePushUsersRelation.MessageTypeId) == false)
{
objvMessagePushUsersRelationEN.dicFldComparisonOp.Add(convMessagePushUsersRelation.MessageTypeId, strComparisonOp);
}
else
{
objvMessagePushUsersRelationEN.dicFldComparisonOp[convMessagePushUsersRelation.MessageTypeId] = strComparisonOp;
}
}
return objvMessagePushUsersRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMessagePushUsersRelationEN SetIsAllpush(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN, bool bolIsAllpush, string strComparisonOp="")
	{
objvMessagePushUsersRelationEN.IsAllpush = bolIsAllpush; //是否全体推送
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushUsersRelationEN.dicFldComparisonOp.ContainsKey(convMessagePushUsersRelation.IsAllpush) == false)
{
objvMessagePushUsersRelationEN.dicFldComparisonOp.Add(convMessagePushUsersRelation.IsAllpush, strComparisonOp);
}
else
{
objvMessagePushUsersRelationEN.dicFldComparisonOp[convMessagePushUsersRelation.IsAllpush] = strComparisonOp;
}
}
return objvMessagePushUsersRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMessagePushUsersRelationEN SetClientVersionTypeId(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN, string strClientVersionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClientVersionTypeId, 8, convMessagePushUsersRelation.ClientVersionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClientVersionTypeId, 8, convMessagePushUsersRelation.ClientVersionTypeId);
}
objvMessagePushUsersRelationEN.ClientVersionTypeId = strClientVersionTypeId; //客户端版本类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushUsersRelationEN.dicFldComparisonOp.ContainsKey(convMessagePushUsersRelation.ClientVersionTypeId) == false)
{
objvMessagePushUsersRelationEN.dicFldComparisonOp.Add(convMessagePushUsersRelation.ClientVersionTypeId, strComparisonOp);
}
else
{
objvMessagePushUsersRelationEN.dicFldComparisonOp[convMessagePushUsersRelation.ClientVersionTypeId] = strComparisonOp;
}
}
return objvMessagePushUsersRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMessagePushUsersRelationEN SetReceivePeople(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN, string strReceivePeople, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReceivePeople, convMessagePushUsersRelation.ReceivePeople);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReceivePeople, 50, convMessagePushUsersRelation.ReceivePeople);
}
objvMessagePushUsersRelationEN.ReceivePeople = strReceivePeople; //接收人员
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushUsersRelationEN.dicFldComparisonOp.ContainsKey(convMessagePushUsersRelation.ReceivePeople) == false)
{
objvMessagePushUsersRelationEN.dicFldComparisonOp.Add(convMessagePushUsersRelation.ReceivePeople, strComparisonOp);
}
else
{
objvMessagePushUsersRelationEN.dicFldComparisonOp[convMessagePushUsersRelation.ReceivePeople] = strComparisonOp;
}
}
return objvMessagePushUsersRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMessagePushUsersRelationEN SetIsReceive(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN, bool bolIsReceive, string strComparisonOp="")
	{
objvMessagePushUsersRelationEN.IsReceive = bolIsReceive; //是否接收
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushUsersRelationEN.dicFldComparisonOp.ContainsKey(convMessagePushUsersRelation.IsReceive) == false)
{
objvMessagePushUsersRelationEN.dicFldComparisonOp.Add(convMessagePushUsersRelation.IsReceive, strComparisonOp);
}
else
{
objvMessagePushUsersRelationEN.dicFldComparisonOp[convMessagePushUsersRelation.IsReceive] = strComparisonOp;
}
}
return objvMessagePushUsersRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMessagePushUsersRelationEN SetCreateTime(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN, string strCreateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateTime, 16, convMessagePushUsersRelation.CreateTime);
}
objvMessagePushUsersRelationEN.CreateTime = strCreateTime; //建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushUsersRelationEN.dicFldComparisonOp.ContainsKey(convMessagePushUsersRelation.CreateTime) == false)
{
objvMessagePushUsersRelationEN.dicFldComparisonOp.Add(convMessagePushUsersRelation.CreateTime, strComparisonOp);
}
else
{
objvMessagePushUsersRelationEN.dicFldComparisonOp[convMessagePushUsersRelation.CreateTime] = strComparisonOp;
}
}
return objvMessagePushUsersRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMessagePushUsersRelationEN SetMemo(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMessagePushUsersRelation.Memo);
}
objvMessagePushUsersRelationEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMessagePushUsersRelationEN.dicFldComparisonOp.ContainsKey(convMessagePushUsersRelation.Memo) == false)
{
objvMessagePushUsersRelationEN.dicFldComparisonOp.Add(convMessagePushUsersRelation.Memo, strComparisonOp);
}
else
{
objvMessagePushUsersRelationEN.dicFldComparisonOp[convMessagePushUsersRelation.Memo] = strComparisonOp;
}
}
return objvMessagePushUsersRelationEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationENS">源对象</param>
 /// <param name = "objvMessagePushUsersRelationENT">目标对象</param>
 public static void CopyTo(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationENS, clsvMessagePushUsersRelationEN objvMessagePushUsersRelationENT)
{
try
{
objvMessagePushUsersRelationENT.MessagePushUsersRelationId = objvMessagePushUsersRelationENS.MessagePushUsersRelationId; //消息推送与用户关系Id
objvMessagePushUsersRelationENT.MessagePushId = objvMessagePushUsersRelationENS.MessagePushId; //消息Id
objvMessagePushUsersRelationENT.MessagePushNumber = objvMessagePushUsersRelationENS.MessagePushNumber; //消息编号
objvMessagePushUsersRelationENT.MessageTitle = objvMessagePushUsersRelationENS.MessageTitle; //消息标题
objvMessagePushUsersRelationENT.MessageContent = objvMessagePushUsersRelationENS.MessageContent; //消息内容
objvMessagePushUsersRelationENT.MessageTypeId = objvMessagePushUsersRelationENS.MessageTypeId; //消息类型Id
objvMessagePushUsersRelationENT.IsAllpush = objvMessagePushUsersRelationENS.IsAllpush; //是否全体推送
objvMessagePushUsersRelationENT.ClientVersionTypeId = objvMessagePushUsersRelationENS.ClientVersionTypeId; //客户端版本类型Id
objvMessagePushUsersRelationENT.ReceivePeople = objvMessagePushUsersRelationENS.ReceivePeople; //接收人员
objvMessagePushUsersRelationENT.IsReceive = objvMessagePushUsersRelationENS.IsReceive; //是否接收
objvMessagePushUsersRelationENT.CreateTime = objvMessagePushUsersRelationENS.CreateTime; //建立时间
objvMessagePushUsersRelationENT.Memo = objvMessagePushUsersRelationENS.Memo; //备注
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
 /// <param name = "objvMessagePushUsersRelationENS">源对象</param>
 /// <returns>目标对象=>clsvMessagePushUsersRelationEN:objvMessagePushUsersRelationENT</returns>
 public static clsvMessagePushUsersRelationEN CopyTo(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationENS)
{
try
{
 clsvMessagePushUsersRelationEN objvMessagePushUsersRelationENT = new clsvMessagePushUsersRelationEN()
{
MessagePushUsersRelationId = objvMessagePushUsersRelationENS.MessagePushUsersRelationId, //消息推送与用户关系Id
MessagePushId = objvMessagePushUsersRelationENS.MessagePushId, //消息Id
MessagePushNumber = objvMessagePushUsersRelationENS.MessagePushNumber, //消息编号
MessageTitle = objvMessagePushUsersRelationENS.MessageTitle, //消息标题
MessageContent = objvMessagePushUsersRelationENS.MessageContent, //消息内容
MessageTypeId = objvMessagePushUsersRelationENS.MessageTypeId, //消息类型Id
IsAllpush = objvMessagePushUsersRelationENS.IsAllpush, //是否全体推送
ClientVersionTypeId = objvMessagePushUsersRelationENS.ClientVersionTypeId, //客户端版本类型Id
ReceivePeople = objvMessagePushUsersRelationENS.ReceivePeople, //接收人员
IsReceive = objvMessagePushUsersRelationENS.IsReceive, //是否接收
CreateTime = objvMessagePushUsersRelationENS.CreateTime, //建立时间
Memo = objvMessagePushUsersRelationENS.Memo, //备注
};
 return objvMessagePushUsersRelationENT;
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
public static void CheckProperty4Condition(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN)
{
 clsvMessagePushUsersRelationBL.vMessagePushUsersRelationDA.CheckProperty4Condition(objvMessagePushUsersRelationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMessagePushUsersRelationCond.IsUpdated(convMessagePushUsersRelation.MessagePushUsersRelationId) == true)
{
string strComparisonOpMessagePushUsersRelationId = objvMessagePushUsersRelationCond.dicFldComparisonOp[convMessagePushUsersRelation.MessagePushUsersRelationId];
strWhereCond += string.Format(" And {0} {2} {1}", convMessagePushUsersRelation.MessagePushUsersRelationId, objvMessagePushUsersRelationCond.MessagePushUsersRelationId, strComparisonOpMessagePushUsersRelationId);
}
if (objvMessagePushUsersRelationCond.IsUpdated(convMessagePushUsersRelation.MessagePushId) == true)
{
string strComparisonOpMessagePushId = objvMessagePushUsersRelationCond.dicFldComparisonOp[convMessagePushUsersRelation.MessagePushId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePushUsersRelation.MessagePushId, objvMessagePushUsersRelationCond.MessagePushId, strComparisonOpMessagePushId);
}
if (objvMessagePushUsersRelationCond.IsUpdated(convMessagePushUsersRelation.MessagePushNumber) == true)
{
string strComparisonOpMessagePushNumber = objvMessagePushUsersRelationCond.dicFldComparisonOp[convMessagePushUsersRelation.MessagePushNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePushUsersRelation.MessagePushNumber, objvMessagePushUsersRelationCond.MessagePushNumber, strComparisonOpMessagePushNumber);
}
if (objvMessagePushUsersRelationCond.IsUpdated(convMessagePushUsersRelation.MessageTitle) == true)
{
string strComparisonOpMessageTitle = objvMessagePushUsersRelationCond.dicFldComparisonOp[convMessagePushUsersRelation.MessageTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePushUsersRelation.MessageTitle, objvMessagePushUsersRelationCond.MessageTitle, strComparisonOpMessageTitle);
}
if (objvMessagePushUsersRelationCond.IsUpdated(convMessagePushUsersRelation.MessageContent) == true)
{
string strComparisonOpMessageContent = objvMessagePushUsersRelationCond.dicFldComparisonOp[convMessagePushUsersRelation.MessageContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePushUsersRelation.MessageContent, objvMessagePushUsersRelationCond.MessageContent, strComparisonOpMessageContent);
}
if (objvMessagePushUsersRelationCond.IsUpdated(convMessagePushUsersRelation.MessageTypeId) == true)
{
string strComparisonOpMessageTypeId = objvMessagePushUsersRelationCond.dicFldComparisonOp[convMessagePushUsersRelation.MessageTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePushUsersRelation.MessageTypeId, objvMessagePushUsersRelationCond.MessageTypeId, strComparisonOpMessageTypeId);
}
if (objvMessagePushUsersRelationCond.IsUpdated(convMessagePushUsersRelation.IsAllpush) == true)
{
if (objvMessagePushUsersRelationCond.IsAllpush == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMessagePushUsersRelation.IsAllpush);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMessagePushUsersRelation.IsAllpush);
}
}
if (objvMessagePushUsersRelationCond.IsUpdated(convMessagePushUsersRelation.ClientVersionTypeId) == true)
{
string strComparisonOpClientVersionTypeId = objvMessagePushUsersRelationCond.dicFldComparisonOp[convMessagePushUsersRelation.ClientVersionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePushUsersRelation.ClientVersionTypeId, objvMessagePushUsersRelationCond.ClientVersionTypeId, strComparisonOpClientVersionTypeId);
}
if (objvMessagePushUsersRelationCond.IsUpdated(convMessagePushUsersRelation.ReceivePeople) == true)
{
string strComparisonOpReceivePeople = objvMessagePushUsersRelationCond.dicFldComparisonOp[convMessagePushUsersRelation.ReceivePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePushUsersRelation.ReceivePeople, objvMessagePushUsersRelationCond.ReceivePeople, strComparisonOpReceivePeople);
}
if (objvMessagePushUsersRelationCond.IsUpdated(convMessagePushUsersRelation.IsReceive) == true)
{
if (objvMessagePushUsersRelationCond.IsReceive == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMessagePushUsersRelation.IsReceive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMessagePushUsersRelation.IsReceive);
}
}
if (objvMessagePushUsersRelationCond.IsUpdated(convMessagePushUsersRelation.CreateTime) == true)
{
string strComparisonOpCreateTime = objvMessagePushUsersRelationCond.dicFldComparisonOp[convMessagePushUsersRelation.CreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePushUsersRelation.CreateTime, objvMessagePushUsersRelationCond.CreateTime, strComparisonOpCreateTime);
}
if (objvMessagePushUsersRelationCond.IsUpdated(convMessagePushUsersRelation.Memo) == true)
{
string strComparisonOpMemo = objvMessagePushUsersRelationCond.dicFldComparisonOp[convMessagePushUsersRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePushUsersRelation.Memo, objvMessagePushUsersRelationCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vMessagePushUsersRelation
{
public virtual bool UpdRelaTabDate(long lngMessagePushUsersRelationId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 消息推送用户关系视图(vMessagePushUsersRelation)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvMessagePushUsersRelationBL
{
public static RelatedActions_vMessagePushUsersRelation relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvMessagePushUsersRelationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvMessagePushUsersRelationDA vMessagePushUsersRelationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvMessagePushUsersRelationDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvMessagePushUsersRelationBL()
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
if (string.IsNullOrEmpty(clsvMessagePushUsersRelationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMessagePushUsersRelationEN._ConnectString);
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
public static DataTable GetDataTable_vMessagePushUsersRelation(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vMessagePushUsersRelationDA.GetDataTable_vMessagePushUsersRelation(strWhereCond);
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
objDT = vMessagePushUsersRelationDA.GetDataTable(strWhereCond);
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
objDT = vMessagePushUsersRelationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vMessagePushUsersRelationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vMessagePushUsersRelationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vMessagePushUsersRelationDA.GetDataTable_Top(objTopPara);
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
objDT = vMessagePushUsersRelationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vMessagePushUsersRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vMessagePushUsersRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMessagePushUsersRelationIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvMessagePushUsersRelationEN> GetObjLstByMessagePushUsersRelationIdLst(List<long> arrMessagePushUsersRelationIdLst)
{
List<clsvMessagePushUsersRelationEN> arrObjLst = new List<clsvMessagePushUsersRelationEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMessagePushUsersRelationIdLst);
 string strWhereCond = string.Format("MessagePushUsersRelationId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = new clsvMessagePushUsersRelationEN();
try
{
objvMessagePushUsersRelationEN.MessagePushUsersRelationId = Int32.Parse(objRow[convMessagePushUsersRelation.MessagePushUsersRelationId].ToString().Trim()); //消息推送与用户关系Id
objvMessagePushUsersRelationEN.MessagePushId = objRow[convMessagePushUsersRelation.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushUsersRelationEN.MessagePushNumber = objRow[convMessagePushUsersRelation.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushUsersRelationEN.MessageTitle = objRow[convMessagePushUsersRelation.MessageTitle] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushUsersRelationEN.MessageContent = objRow[convMessagePushUsersRelation.MessageContent] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageContent].ToString().Trim(); //消息内容
objvMessagePushUsersRelationEN.MessageTypeId = objRow[convMessagePushUsersRelation.MessageTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushUsersRelationEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[convMessagePushUsersRelation.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushUsersRelationEN.ClientVersionTypeId = objRow[convMessagePushUsersRelation.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushUsersRelationEN.ReceivePeople = objRow[convMessagePushUsersRelation.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushUsersRelationEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convMessagePushUsersRelation.IsReceive].ToString().Trim()); //是否接收
objvMessagePushUsersRelationEN.CreateTime = objRow[convMessagePushUsersRelation.CreateTime] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.CreateTime].ToString().Trim(); //建立时间
objvMessagePushUsersRelationEN.Memo = objRow[convMessagePushUsersRelation.Memo] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMessagePushUsersRelationEN.MessagePushUsersRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMessagePushUsersRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMessagePushUsersRelationIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvMessagePushUsersRelationEN> GetObjLstByMessagePushUsersRelationIdLstCache(List<long> arrMessagePushUsersRelationIdLst)
{
string strKey = string.Format("{0}", clsvMessagePushUsersRelationEN._CurrTabName);
List<clsvMessagePushUsersRelationEN> arrvMessagePushUsersRelationObjLstCache = GetObjLstCache();
IEnumerable <clsvMessagePushUsersRelationEN> arrvMessagePushUsersRelationObjLst_Sel =
arrvMessagePushUsersRelationObjLstCache
.Where(x => arrMessagePushUsersRelationIdLst.Contains(x.MessagePushUsersRelationId));
return arrvMessagePushUsersRelationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMessagePushUsersRelationEN> GetObjLst(string strWhereCond)
{
List<clsvMessagePushUsersRelationEN> arrObjLst = new List<clsvMessagePushUsersRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = new clsvMessagePushUsersRelationEN();
try
{
objvMessagePushUsersRelationEN.MessagePushUsersRelationId = Int32.Parse(objRow[convMessagePushUsersRelation.MessagePushUsersRelationId].ToString().Trim()); //消息推送与用户关系Id
objvMessagePushUsersRelationEN.MessagePushId = objRow[convMessagePushUsersRelation.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushUsersRelationEN.MessagePushNumber = objRow[convMessagePushUsersRelation.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushUsersRelationEN.MessageTitle = objRow[convMessagePushUsersRelation.MessageTitle] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushUsersRelationEN.MessageContent = objRow[convMessagePushUsersRelation.MessageContent] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageContent].ToString().Trim(); //消息内容
objvMessagePushUsersRelationEN.MessageTypeId = objRow[convMessagePushUsersRelation.MessageTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushUsersRelationEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[convMessagePushUsersRelation.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushUsersRelationEN.ClientVersionTypeId = objRow[convMessagePushUsersRelation.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushUsersRelationEN.ReceivePeople = objRow[convMessagePushUsersRelation.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushUsersRelationEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convMessagePushUsersRelation.IsReceive].ToString().Trim()); //是否接收
objvMessagePushUsersRelationEN.CreateTime = objRow[convMessagePushUsersRelation.CreateTime] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.CreateTime].ToString().Trim(); //建立时间
objvMessagePushUsersRelationEN.Memo = objRow[convMessagePushUsersRelation.Memo] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMessagePushUsersRelationEN.MessagePushUsersRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMessagePushUsersRelationEN);
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
public static List<clsvMessagePushUsersRelationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvMessagePushUsersRelationEN> arrObjLst = new List<clsvMessagePushUsersRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = new clsvMessagePushUsersRelationEN();
try
{
objvMessagePushUsersRelationEN.MessagePushUsersRelationId = Int32.Parse(objRow[convMessagePushUsersRelation.MessagePushUsersRelationId].ToString().Trim()); //消息推送与用户关系Id
objvMessagePushUsersRelationEN.MessagePushId = objRow[convMessagePushUsersRelation.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushUsersRelationEN.MessagePushNumber = objRow[convMessagePushUsersRelation.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushUsersRelationEN.MessageTitle = objRow[convMessagePushUsersRelation.MessageTitle] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushUsersRelationEN.MessageContent = objRow[convMessagePushUsersRelation.MessageContent] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageContent].ToString().Trim(); //消息内容
objvMessagePushUsersRelationEN.MessageTypeId = objRow[convMessagePushUsersRelation.MessageTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushUsersRelationEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[convMessagePushUsersRelation.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushUsersRelationEN.ClientVersionTypeId = objRow[convMessagePushUsersRelation.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushUsersRelationEN.ReceivePeople = objRow[convMessagePushUsersRelation.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushUsersRelationEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convMessagePushUsersRelation.IsReceive].ToString().Trim()); //是否接收
objvMessagePushUsersRelationEN.CreateTime = objRow[convMessagePushUsersRelation.CreateTime] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.CreateTime].ToString().Trim(); //建立时间
objvMessagePushUsersRelationEN.Memo = objRow[convMessagePushUsersRelation.Memo] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMessagePushUsersRelationEN.MessagePushUsersRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMessagePushUsersRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvMessagePushUsersRelationEN> GetSubObjLstCache(clsvMessagePushUsersRelationEN objvMessagePushUsersRelationCond)
{
List<clsvMessagePushUsersRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMessagePushUsersRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMessagePushUsersRelation.AttributeName)
{
if (objvMessagePushUsersRelationCond.IsUpdated(strFldName) == false) continue;
if (objvMessagePushUsersRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMessagePushUsersRelationCond[strFldName].ToString());
}
else
{
if (objvMessagePushUsersRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMessagePushUsersRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMessagePushUsersRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMessagePushUsersRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMessagePushUsersRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMessagePushUsersRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMessagePushUsersRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMessagePushUsersRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMessagePushUsersRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMessagePushUsersRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMessagePushUsersRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMessagePushUsersRelationCond[strFldName]));
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
public static List<clsvMessagePushUsersRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvMessagePushUsersRelationEN> arrObjLst = new List<clsvMessagePushUsersRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = new clsvMessagePushUsersRelationEN();
try
{
objvMessagePushUsersRelationEN.MessagePushUsersRelationId = Int32.Parse(objRow[convMessagePushUsersRelation.MessagePushUsersRelationId].ToString().Trim()); //消息推送与用户关系Id
objvMessagePushUsersRelationEN.MessagePushId = objRow[convMessagePushUsersRelation.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushUsersRelationEN.MessagePushNumber = objRow[convMessagePushUsersRelation.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushUsersRelationEN.MessageTitle = objRow[convMessagePushUsersRelation.MessageTitle] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushUsersRelationEN.MessageContent = objRow[convMessagePushUsersRelation.MessageContent] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageContent].ToString().Trim(); //消息内容
objvMessagePushUsersRelationEN.MessageTypeId = objRow[convMessagePushUsersRelation.MessageTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushUsersRelationEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[convMessagePushUsersRelation.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushUsersRelationEN.ClientVersionTypeId = objRow[convMessagePushUsersRelation.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushUsersRelationEN.ReceivePeople = objRow[convMessagePushUsersRelation.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushUsersRelationEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convMessagePushUsersRelation.IsReceive].ToString().Trim()); //是否接收
objvMessagePushUsersRelationEN.CreateTime = objRow[convMessagePushUsersRelation.CreateTime] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.CreateTime].ToString().Trim(); //建立时间
objvMessagePushUsersRelationEN.Memo = objRow[convMessagePushUsersRelation.Memo] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMessagePushUsersRelationEN.MessagePushUsersRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMessagePushUsersRelationEN);
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
public static List<clsvMessagePushUsersRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvMessagePushUsersRelationEN> arrObjLst = new List<clsvMessagePushUsersRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = new clsvMessagePushUsersRelationEN();
try
{
objvMessagePushUsersRelationEN.MessagePushUsersRelationId = Int32.Parse(objRow[convMessagePushUsersRelation.MessagePushUsersRelationId].ToString().Trim()); //消息推送与用户关系Id
objvMessagePushUsersRelationEN.MessagePushId = objRow[convMessagePushUsersRelation.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushUsersRelationEN.MessagePushNumber = objRow[convMessagePushUsersRelation.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushUsersRelationEN.MessageTitle = objRow[convMessagePushUsersRelation.MessageTitle] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushUsersRelationEN.MessageContent = objRow[convMessagePushUsersRelation.MessageContent] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageContent].ToString().Trim(); //消息内容
objvMessagePushUsersRelationEN.MessageTypeId = objRow[convMessagePushUsersRelation.MessageTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushUsersRelationEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[convMessagePushUsersRelation.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushUsersRelationEN.ClientVersionTypeId = objRow[convMessagePushUsersRelation.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushUsersRelationEN.ReceivePeople = objRow[convMessagePushUsersRelation.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushUsersRelationEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convMessagePushUsersRelation.IsReceive].ToString().Trim()); //是否接收
objvMessagePushUsersRelationEN.CreateTime = objRow[convMessagePushUsersRelation.CreateTime] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.CreateTime].ToString().Trim(); //建立时间
objvMessagePushUsersRelationEN.Memo = objRow[convMessagePushUsersRelation.Memo] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMessagePushUsersRelationEN.MessagePushUsersRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMessagePushUsersRelationEN);
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
List<clsvMessagePushUsersRelationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvMessagePushUsersRelationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMessagePushUsersRelationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvMessagePushUsersRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvMessagePushUsersRelationEN> arrObjLst = new List<clsvMessagePushUsersRelationEN>(); 
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
	clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = new clsvMessagePushUsersRelationEN();
try
{
objvMessagePushUsersRelationEN.MessagePushUsersRelationId = Int32.Parse(objRow[convMessagePushUsersRelation.MessagePushUsersRelationId].ToString().Trim()); //消息推送与用户关系Id
objvMessagePushUsersRelationEN.MessagePushId = objRow[convMessagePushUsersRelation.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushUsersRelationEN.MessagePushNumber = objRow[convMessagePushUsersRelation.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushUsersRelationEN.MessageTitle = objRow[convMessagePushUsersRelation.MessageTitle] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushUsersRelationEN.MessageContent = objRow[convMessagePushUsersRelation.MessageContent] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageContent].ToString().Trim(); //消息内容
objvMessagePushUsersRelationEN.MessageTypeId = objRow[convMessagePushUsersRelation.MessageTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushUsersRelationEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[convMessagePushUsersRelation.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushUsersRelationEN.ClientVersionTypeId = objRow[convMessagePushUsersRelation.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushUsersRelationEN.ReceivePeople = objRow[convMessagePushUsersRelation.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushUsersRelationEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convMessagePushUsersRelation.IsReceive].ToString().Trim()); //是否接收
objvMessagePushUsersRelationEN.CreateTime = objRow[convMessagePushUsersRelation.CreateTime] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.CreateTime].ToString().Trim(); //建立时间
objvMessagePushUsersRelationEN.Memo = objRow[convMessagePushUsersRelation.Memo] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMessagePushUsersRelationEN.MessagePushUsersRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMessagePushUsersRelationEN);
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
public static List<clsvMessagePushUsersRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvMessagePushUsersRelationEN> arrObjLst = new List<clsvMessagePushUsersRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = new clsvMessagePushUsersRelationEN();
try
{
objvMessagePushUsersRelationEN.MessagePushUsersRelationId = Int32.Parse(objRow[convMessagePushUsersRelation.MessagePushUsersRelationId].ToString().Trim()); //消息推送与用户关系Id
objvMessagePushUsersRelationEN.MessagePushId = objRow[convMessagePushUsersRelation.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushUsersRelationEN.MessagePushNumber = objRow[convMessagePushUsersRelation.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushUsersRelationEN.MessageTitle = objRow[convMessagePushUsersRelation.MessageTitle] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushUsersRelationEN.MessageContent = objRow[convMessagePushUsersRelation.MessageContent] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageContent].ToString().Trim(); //消息内容
objvMessagePushUsersRelationEN.MessageTypeId = objRow[convMessagePushUsersRelation.MessageTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushUsersRelationEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[convMessagePushUsersRelation.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushUsersRelationEN.ClientVersionTypeId = objRow[convMessagePushUsersRelation.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushUsersRelationEN.ReceivePeople = objRow[convMessagePushUsersRelation.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushUsersRelationEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convMessagePushUsersRelation.IsReceive].ToString().Trim()); //是否接收
objvMessagePushUsersRelationEN.CreateTime = objRow[convMessagePushUsersRelation.CreateTime] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.CreateTime].ToString().Trim(); //建立时间
objvMessagePushUsersRelationEN.Memo = objRow[convMessagePushUsersRelation.Memo] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMessagePushUsersRelationEN.MessagePushUsersRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMessagePushUsersRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvMessagePushUsersRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvMessagePushUsersRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvMessagePushUsersRelationEN> arrObjLst = new List<clsvMessagePushUsersRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = new clsvMessagePushUsersRelationEN();
try
{
objvMessagePushUsersRelationEN.MessagePushUsersRelationId = Int32.Parse(objRow[convMessagePushUsersRelation.MessagePushUsersRelationId].ToString().Trim()); //消息推送与用户关系Id
objvMessagePushUsersRelationEN.MessagePushId = objRow[convMessagePushUsersRelation.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushUsersRelationEN.MessagePushNumber = objRow[convMessagePushUsersRelation.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushUsersRelationEN.MessageTitle = objRow[convMessagePushUsersRelation.MessageTitle] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushUsersRelationEN.MessageContent = objRow[convMessagePushUsersRelation.MessageContent] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageContent].ToString().Trim(); //消息内容
objvMessagePushUsersRelationEN.MessageTypeId = objRow[convMessagePushUsersRelation.MessageTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushUsersRelationEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[convMessagePushUsersRelation.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushUsersRelationEN.ClientVersionTypeId = objRow[convMessagePushUsersRelation.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushUsersRelationEN.ReceivePeople = objRow[convMessagePushUsersRelation.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushUsersRelationEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convMessagePushUsersRelation.IsReceive].ToString().Trim()); //是否接收
objvMessagePushUsersRelationEN.CreateTime = objRow[convMessagePushUsersRelation.CreateTime] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.CreateTime].ToString().Trim(); //建立时间
objvMessagePushUsersRelationEN.Memo = objRow[convMessagePushUsersRelation.Memo] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMessagePushUsersRelationEN.MessagePushUsersRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMessagePushUsersRelationEN);
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
public static List<clsvMessagePushUsersRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvMessagePushUsersRelationEN> arrObjLst = new List<clsvMessagePushUsersRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = new clsvMessagePushUsersRelationEN();
try
{
objvMessagePushUsersRelationEN.MessagePushUsersRelationId = Int32.Parse(objRow[convMessagePushUsersRelation.MessagePushUsersRelationId].ToString().Trim()); //消息推送与用户关系Id
objvMessagePushUsersRelationEN.MessagePushId = objRow[convMessagePushUsersRelation.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushUsersRelationEN.MessagePushNumber = objRow[convMessagePushUsersRelation.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushUsersRelationEN.MessageTitle = objRow[convMessagePushUsersRelation.MessageTitle] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushUsersRelationEN.MessageContent = objRow[convMessagePushUsersRelation.MessageContent] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageContent].ToString().Trim(); //消息内容
objvMessagePushUsersRelationEN.MessageTypeId = objRow[convMessagePushUsersRelation.MessageTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushUsersRelationEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[convMessagePushUsersRelation.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushUsersRelationEN.ClientVersionTypeId = objRow[convMessagePushUsersRelation.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushUsersRelationEN.ReceivePeople = objRow[convMessagePushUsersRelation.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushUsersRelationEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convMessagePushUsersRelation.IsReceive].ToString().Trim()); //是否接收
objvMessagePushUsersRelationEN.CreateTime = objRow[convMessagePushUsersRelation.CreateTime] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.CreateTime].ToString().Trim(); //建立时间
objvMessagePushUsersRelationEN.Memo = objRow[convMessagePushUsersRelation.Memo] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMessagePushUsersRelationEN.MessagePushUsersRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMessagePushUsersRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMessagePushUsersRelationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvMessagePushUsersRelationEN> arrObjLst = new List<clsvMessagePushUsersRelationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = new clsvMessagePushUsersRelationEN();
try
{
objvMessagePushUsersRelationEN.MessagePushUsersRelationId = Int32.Parse(objRow[convMessagePushUsersRelation.MessagePushUsersRelationId].ToString().Trim()); //消息推送与用户关系Id
objvMessagePushUsersRelationEN.MessagePushId = objRow[convMessagePushUsersRelation.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushUsersRelationEN.MessagePushNumber = objRow[convMessagePushUsersRelation.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushUsersRelationEN.MessageTitle = objRow[convMessagePushUsersRelation.MessageTitle] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushUsersRelationEN.MessageContent = objRow[convMessagePushUsersRelation.MessageContent] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageContent].ToString().Trim(); //消息内容
objvMessagePushUsersRelationEN.MessageTypeId = objRow[convMessagePushUsersRelation.MessageTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushUsersRelationEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[convMessagePushUsersRelation.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushUsersRelationEN.ClientVersionTypeId = objRow[convMessagePushUsersRelation.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushUsersRelationEN.ReceivePeople = objRow[convMessagePushUsersRelation.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushUsersRelationEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convMessagePushUsersRelation.IsReceive].ToString().Trim()); //是否接收
objvMessagePushUsersRelationEN.CreateTime = objRow[convMessagePushUsersRelation.CreateTime] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.CreateTime].ToString().Trim(); //建立时间
objvMessagePushUsersRelationEN.Memo = objRow[convMessagePushUsersRelation.Memo] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMessagePushUsersRelationEN.MessagePushUsersRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMessagePushUsersRelationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvMessagePushUsersRelation(ref clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN)
{
bool bolResult = vMessagePushUsersRelationDA.GetvMessagePushUsersRelation(ref objvMessagePushUsersRelationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngMessagePushUsersRelationId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMessagePushUsersRelationEN GetObjByMessagePushUsersRelationId(long lngMessagePushUsersRelationId)
{
clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = vMessagePushUsersRelationDA.GetObjByMessagePushUsersRelationId(lngMessagePushUsersRelationId);
return objvMessagePushUsersRelationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvMessagePushUsersRelationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = vMessagePushUsersRelationDA.GetFirstObj(strWhereCond);
 return objvMessagePushUsersRelationEN;
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
public static clsvMessagePushUsersRelationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = vMessagePushUsersRelationDA.GetObjByDataRow(objRow);
 return objvMessagePushUsersRelationEN;
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
public static clsvMessagePushUsersRelationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = vMessagePushUsersRelationDA.GetObjByDataRow(objRow);
 return objvMessagePushUsersRelationEN;
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
 /// <param name = "lngMessagePushUsersRelationId">所给的关键字</param>
 /// <param name = "lstvMessagePushUsersRelationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMessagePushUsersRelationEN GetObjByMessagePushUsersRelationIdFromList(long lngMessagePushUsersRelationId, List<clsvMessagePushUsersRelationEN> lstvMessagePushUsersRelationObjLst)
{
foreach (clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN in lstvMessagePushUsersRelationObjLst)
{
if (objvMessagePushUsersRelationEN.MessagePushUsersRelationId == lngMessagePushUsersRelationId)
{
return objvMessagePushUsersRelationEN;
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
 long lngMessagePushUsersRelationId;
 try
 {
 lngMessagePushUsersRelationId = new clsvMessagePushUsersRelationDA().GetFirstID(strWhereCond);
 return lngMessagePushUsersRelationId;
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
 arrList = vMessagePushUsersRelationDA.GetID(strWhereCond);
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
bool bolIsExist = vMessagePushUsersRelationDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngMessagePushUsersRelationId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngMessagePushUsersRelationId)
{
//检测记录是否存在
bool bolIsExist = vMessagePushUsersRelationDA.IsExist(lngMessagePushUsersRelationId);
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
 bolIsExist = clsvMessagePushUsersRelationDA.IsExistTable();
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
 bolIsExist = vMessagePushUsersRelationDA.IsExistTable(strTabName);
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
 /// <param name = "objvMessagePushUsersRelationENS">源对象</param>
 /// <param name = "objvMessagePushUsersRelationENT">目标对象</param>
 public static void CopyTo(clsvMessagePushUsersRelationEN objvMessagePushUsersRelationENS, clsvMessagePushUsersRelationEN objvMessagePushUsersRelationENT)
{
try
{
objvMessagePushUsersRelationENT.MessagePushUsersRelationId = objvMessagePushUsersRelationENS.MessagePushUsersRelationId; //消息推送与用户关系Id
objvMessagePushUsersRelationENT.MessagePushId = objvMessagePushUsersRelationENS.MessagePushId; //消息Id
objvMessagePushUsersRelationENT.MessagePushNumber = objvMessagePushUsersRelationENS.MessagePushNumber; //消息编号
objvMessagePushUsersRelationENT.MessageTitle = objvMessagePushUsersRelationENS.MessageTitle; //消息标题
objvMessagePushUsersRelationENT.MessageContent = objvMessagePushUsersRelationENS.MessageContent; //消息内容
objvMessagePushUsersRelationENT.MessageTypeId = objvMessagePushUsersRelationENS.MessageTypeId; //消息类型Id
objvMessagePushUsersRelationENT.IsAllpush = objvMessagePushUsersRelationENS.IsAllpush; //是否全体推送
objvMessagePushUsersRelationENT.ClientVersionTypeId = objvMessagePushUsersRelationENS.ClientVersionTypeId; //客户端版本类型Id
objvMessagePushUsersRelationENT.ReceivePeople = objvMessagePushUsersRelationENS.ReceivePeople; //接收人员
objvMessagePushUsersRelationENT.IsReceive = objvMessagePushUsersRelationENS.IsReceive; //是否接收
objvMessagePushUsersRelationENT.CreateTime = objvMessagePushUsersRelationENS.CreateTime; //建立时间
objvMessagePushUsersRelationENT.Memo = objvMessagePushUsersRelationENS.Memo; //备注
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
 /// <param name = "objvMessagePushUsersRelationEN">源简化对象</param>
 public static void SetUpdFlag(clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN)
{
try
{
objvMessagePushUsersRelationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvMessagePushUsersRelationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convMessagePushUsersRelation.MessagePushUsersRelationId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushUsersRelationEN.MessagePushUsersRelationId = objvMessagePushUsersRelationEN.MessagePushUsersRelationId; //消息推送与用户关系Id
}
if (arrFldSet.Contains(convMessagePushUsersRelation.MessagePushId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushUsersRelationEN.MessagePushId = objvMessagePushUsersRelationEN.MessagePushId; //消息Id
}
if (arrFldSet.Contains(convMessagePushUsersRelation.MessagePushNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushUsersRelationEN.MessagePushNumber = objvMessagePushUsersRelationEN.MessagePushNumber == "[null]" ? null :  objvMessagePushUsersRelationEN.MessagePushNumber; //消息编号
}
if (arrFldSet.Contains(convMessagePushUsersRelation.MessageTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushUsersRelationEN.MessageTitle = objvMessagePushUsersRelationEN.MessageTitle == "[null]" ? null :  objvMessagePushUsersRelationEN.MessageTitle; //消息标题
}
if (arrFldSet.Contains(convMessagePushUsersRelation.MessageContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushUsersRelationEN.MessageContent = objvMessagePushUsersRelationEN.MessageContent == "[null]" ? null :  objvMessagePushUsersRelationEN.MessageContent; //消息内容
}
if (arrFldSet.Contains(convMessagePushUsersRelation.MessageTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushUsersRelationEN.MessageTypeId = objvMessagePushUsersRelationEN.MessageTypeId == "[null]" ? null :  objvMessagePushUsersRelationEN.MessageTypeId; //消息类型Id
}
if (arrFldSet.Contains(convMessagePushUsersRelation.IsAllpush, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushUsersRelationEN.IsAllpush = objvMessagePushUsersRelationEN.IsAllpush; //是否全体推送
}
if (arrFldSet.Contains(convMessagePushUsersRelation.ClientVersionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushUsersRelationEN.ClientVersionTypeId = objvMessagePushUsersRelationEN.ClientVersionTypeId == "[null]" ? null :  objvMessagePushUsersRelationEN.ClientVersionTypeId; //客户端版本类型Id
}
if (arrFldSet.Contains(convMessagePushUsersRelation.ReceivePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushUsersRelationEN.ReceivePeople = objvMessagePushUsersRelationEN.ReceivePeople; //接收人员
}
if (arrFldSet.Contains(convMessagePushUsersRelation.IsReceive, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushUsersRelationEN.IsReceive = objvMessagePushUsersRelationEN.IsReceive; //是否接收
}
if (arrFldSet.Contains(convMessagePushUsersRelation.CreateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushUsersRelationEN.CreateTime = objvMessagePushUsersRelationEN.CreateTime == "[null]" ? null :  objvMessagePushUsersRelationEN.CreateTime; //建立时间
}
if (arrFldSet.Contains(convMessagePushUsersRelation.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMessagePushUsersRelationEN.Memo = objvMessagePushUsersRelationEN.Memo == "[null]" ? null :  objvMessagePushUsersRelationEN.Memo; //备注
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
 /// <param name = "objvMessagePushUsersRelationEN">源简化对象</param>
 public static void AccessFldValueNull(clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN)
{
try
{
if (objvMessagePushUsersRelationEN.MessagePushNumber == "[null]") objvMessagePushUsersRelationEN.MessagePushNumber = null; //消息编号
if (objvMessagePushUsersRelationEN.MessageTitle == "[null]") objvMessagePushUsersRelationEN.MessageTitle = null; //消息标题
if (objvMessagePushUsersRelationEN.MessageContent == "[null]") objvMessagePushUsersRelationEN.MessageContent = null; //消息内容
if (objvMessagePushUsersRelationEN.MessageTypeId == "[null]") objvMessagePushUsersRelationEN.MessageTypeId = null; //消息类型Id
if (objvMessagePushUsersRelationEN.ClientVersionTypeId == "[null]") objvMessagePushUsersRelationEN.ClientVersionTypeId = null; //客户端版本类型Id
if (objvMessagePushUsersRelationEN.CreateTime == "[null]") objvMessagePushUsersRelationEN.CreateTime = null; //建立时间
if (objvMessagePushUsersRelationEN.Memo == "[null]") objvMessagePushUsersRelationEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN)
{
 vMessagePushUsersRelationDA.CheckProperty4Condition(objvMessagePushUsersRelationEN);
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
if (clsMessagePushUsersRelationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMessagePushUsersRelationBL没有刷新缓存机制(clsMessagePushUsersRelationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by MessagePushUsersRelationId");
//if (arrvMessagePushUsersRelationObjLstCache == null)
//{
//arrvMessagePushUsersRelationObjLstCache = vMessagePushUsersRelationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngMessagePushUsersRelationId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMessagePushUsersRelationEN GetObjByMessagePushUsersRelationIdCache(long lngMessagePushUsersRelationId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvMessagePushUsersRelationEN._CurrTabName);
List<clsvMessagePushUsersRelationEN> arrvMessagePushUsersRelationObjLstCache = GetObjLstCache();
IEnumerable <clsvMessagePushUsersRelationEN> arrvMessagePushUsersRelationObjLst_Sel =
arrvMessagePushUsersRelationObjLstCache
.Where(x=> x.MessagePushUsersRelationId == lngMessagePushUsersRelationId 
);
if (arrvMessagePushUsersRelationObjLst_Sel.Count() == 0)
{
   clsvMessagePushUsersRelationEN obj = clsvMessagePushUsersRelationBL.GetObjByMessagePushUsersRelationId(lngMessagePushUsersRelationId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvMessagePushUsersRelationObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMessagePushUsersRelationEN> GetAllvMessagePushUsersRelationObjLstCache()
{
//获取缓存中的对象列表
List<clsvMessagePushUsersRelationEN> arrvMessagePushUsersRelationObjLstCache = GetObjLstCache(); 
return arrvMessagePushUsersRelationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMessagePushUsersRelationEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvMessagePushUsersRelationEN._CurrTabName);
List<clsvMessagePushUsersRelationEN> arrvMessagePushUsersRelationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMessagePushUsersRelationObjLstCache;
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
string strKey = string.Format("{0}", clsvMessagePushUsersRelationEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngMessagePushUsersRelationId)
{
if (strInFldName != convMessagePushUsersRelation.MessagePushUsersRelationId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convMessagePushUsersRelation.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convMessagePushUsersRelation.AttributeName));
throw new Exception(strMsg);
}
var objvMessagePushUsersRelation = clsvMessagePushUsersRelationBL.GetObjByMessagePushUsersRelationIdCache(lngMessagePushUsersRelationId);
if (objvMessagePushUsersRelation == null) return "";
return objvMessagePushUsersRelation[strOutFldName].ToString();
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
int intRecCount = clsvMessagePushUsersRelationDA.GetRecCount(strTabName);
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
int intRecCount = clsvMessagePushUsersRelationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvMessagePushUsersRelationDA.GetRecCount();
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
int intRecCount = clsvMessagePushUsersRelationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvMessagePushUsersRelationEN objvMessagePushUsersRelationCond)
{
List<clsvMessagePushUsersRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMessagePushUsersRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMessagePushUsersRelation.AttributeName)
{
if (objvMessagePushUsersRelationCond.IsUpdated(strFldName) == false) continue;
if (objvMessagePushUsersRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMessagePushUsersRelationCond[strFldName].ToString());
}
else
{
if (objvMessagePushUsersRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMessagePushUsersRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMessagePushUsersRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMessagePushUsersRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMessagePushUsersRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMessagePushUsersRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMessagePushUsersRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMessagePushUsersRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMessagePushUsersRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMessagePushUsersRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMessagePushUsersRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMessagePushUsersRelationCond[strFldName]));
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
 List<string> arrList = clsvMessagePushUsersRelationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vMessagePushUsersRelationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vMessagePushUsersRelationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}