
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMessagePushUsersRelationWApi
 表名:vMessagePushUsersRelation(01120285)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:46
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
public static class clsvMessagePushUsersRelationWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMessagePushUsersRelationEN SetMessagePushId(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN, string strMessagePushId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMessagePushId, convMessagePushUsersRelation.MessagePushId);
clsCheckSql.CheckFieldLen(strMessagePushId, 8, convMessagePushUsersRelation.MessagePushId);
clsCheckSql.CheckFieldForeignKey(strMessagePushId, 8, convMessagePushUsersRelation.MessagePushId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMessagePushUsersRelationEN SetMessagePushNumber(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN, string strMessagePushNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMessagePushNumber, 200, convMessagePushUsersRelation.MessagePushNumber);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMessagePushUsersRelationEN SetMessageTitle(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN, string strMessageTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMessageTitle, 500, convMessagePushUsersRelation.MessageTitle);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMessagePushUsersRelationEN SetMessageContent(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN, string strMessageContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMessageContent, 2000, convMessagePushUsersRelation.MessageContent);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMessagePushUsersRelationEN SetMessageTypeId(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN, string strMessageTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMessageTypeId, 8, convMessagePushUsersRelation.MessageTypeId);
clsCheckSql.CheckFieldForeignKey(strMessageTypeId, 8, convMessagePushUsersRelation.MessageTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMessagePushUsersRelationEN SetClientVersionTypeId(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN, string strClientVersionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClientVersionTypeId, 8, convMessagePushUsersRelation.ClientVersionTypeId);
clsCheckSql.CheckFieldForeignKey(strClientVersionTypeId, 8, convMessagePushUsersRelation.ClientVersionTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMessagePushUsersRelationEN SetReceivePeople(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN, string strReceivePeople, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReceivePeople, convMessagePushUsersRelation.ReceivePeople);
clsCheckSql.CheckFieldLen(strReceivePeople, 50, convMessagePushUsersRelation.ReceivePeople);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMessagePushUsersRelationEN SetCreateTime(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN, string strCreateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateTime, 16, convMessagePushUsersRelation.CreateTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMessagePushUsersRelationEN SetMemo(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMessagePushUsersRelation.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMessagePushUsersRelationEN objvMessagePushUsersRelation_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMessagePushUsersRelation_Cond.IsUpdated(convMessagePushUsersRelation.MessagePushUsersRelationId) == true)
{
string strComparisonOp_MessagePushUsersRelationId = objvMessagePushUsersRelation_Cond.dicFldComparisonOp[convMessagePushUsersRelation.MessagePushUsersRelationId];
strWhereCond += string.Format(" And {0} {2} {1}", convMessagePushUsersRelation.MessagePushUsersRelationId, objvMessagePushUsersRelation_Cond.MessagePushUsersRelationId, strComparisonOp_MessagePushUsersRelationId);
}
if (objvMessagePushUsersRelation_Cond.IsUpdated(convMessagePushUsersRelation.MessagePushId) == true)
{
string strComparisonOp_MessagePushId = objvMessagePushUsersRelation_Cond.dicFldComparisonOp[convMessagePushUsersRelation.MessagePushId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePushUsersRelation.MessagePushId, objvMessagePushUsersRelation_Cond.MessagePushId, strComparisonOp_MessagePushId);
}
if (objvMessagePushUsersRelation_Cond.IsUpdated(convMessagePushUsersRelation.MessagePushNumber) == true)
{
string strComparisonOp_MessagePushNumber = objvMessagePushUsersRelation_Cond.dicFldComparisonOp[convMessagePushUsersRelation.MessagePushNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePushUsersRelation.MessagePushNumber, objvMessagePushUsersRelation_Cond.MessagePushNumber, strComparisonOp_MessagePushNumber);
}
if (objvMessagePushUsersRelation_Cond.IsUpdated(convMessagePushUsersRelation.MessageTitle) == true)
{
string strComparisonOp_MessageTitle = objvMessagePushUsersRelation_Cond.dicFldComparisonOp[convMessagePushUsersRelation.MessageTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePushUsersRelation.MessageTitle, objvMessagePushUsersRelation_Cond.MessageTitle, strComparisonOp_MessageTitle);
}
if (objvMessagePushUsersRelation_Cond.IsUpdated(convMessagePushUsersRelation.MessageContent) == true)
{
string strComparisonOp_MessageContent = objvMessagePushUsersRelation_Cond.dicFldComparisonOp[convMessagePushUsersRelation.MessageContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePushUsersRelation.MessageContent, objvMessagePushUsersRelation_Cond.MessageContent, strComparisonOp_MessageContent);
}
if (objvMessagePushUsersRelation_Cond.IsUpdated(convMessagePushUsersRelation.MessageTypeId) == true)
{
string strComparisonOp_MessageTypeId = objvMessagePushUsersRelation_Cond.dicFldComparisonOp[convMessagePushUsersRelation.MessageTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePushUsersRelation.MessageTypeId, objvMessagePushUsersRelation_Cond.MessageTypeId, strComparisonOp_MessageTypeId);
}
if (objvMessagePushUsersRelation_Cond.IsUpdated(convMessagePushUsersRelation.IsAllpush) == true)
{
if (objvMessagePushUsersRelation_Cond.IsAllpush == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMessagePushUsersRelation.IsAllpush);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMessagePushUsersRelation.IsAllpush);
}
}
if (objvMessagePushUsersRelation_Cond.IsUpdated(convMessagePushUsersRelation.ClientVersionTypeId) == true)
{
string strComparisonOp_ClientVersionTypeId = objvMessagePushUsersRelation_Cond.dicFldComparisonOp[convMessagePushUsersRelation.ClientVersionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePushUsersRelation.ClientVersionTypeId, objvMessagePushUsersRelation_Cond.ClientVersionTypeId, strComparisonOp_ClientVersionTypeId);
}
if (objvMessagePushUsersRelation_Cond.IsUpdated(convMessagePushUsersRelation.ReceivePeople) == true)
{
string strComparisonOp_ReceivePeople = objvMessagePushUsersRelation_Cond.dicFldComparisonOp[convMessagePushUsersRelation.ReceivePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePushUsersRelation.ReceivePeople, objvMessagePushUsersRelation_Cond.ReceivePeople, strComparisonOp_ReceivePeople);
}
if (objvMessagePushUsersRelation_Cond.IsUpdated(convMessagePushUsersRelation.IsReceive) == true)
{
if (objvMessagePushUsersRelation_Cond.IsReceive == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMessagePushUsersRelation.IsReceive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMessagePushUsersRelation.IsReceive);
}
}
if (objvMessagePushUsersRelation_Cond.IsUpdated(convMessagePushUsersRelation.CreateTime) == true)
{
string strComparisonOp_CreateTime = objvMessagePushUsersRelation_Cond.dicFldComparisonOp[convMessagePushUsersRelation.CreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePushUsersRelation.CreateTime, objvMessagePushUsersRelation_Cond.CreateTime, strComparisonOp_CreateTime);
}
if (objvMessagePushUsersRelation_Cond.IsUpdated(convMessagePushUsersRelation.Memo) == true)
{
string strComparisonOp_Memo = objvMessagePushUsersRelation_Cond.dicFldComparisonOp[convMessagePushUsersRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMessagePushUsersRelation.Memo, objvMessagePushUsersRelation_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// 消息推送用户关系视图(vMessagePushUsersRelation)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvMessagePushUsersRelationWApi
{
private static readonly string mstrApiControllerName = "vMessagePushUsersRelationApi";

 public clsvMessagePushUsersRelationWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngMessagePushUsersRelationId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMessagePushUsersRelationEN GetObjByMessagePushUsersRelationId(long lngMessagePushUsersRelationId)
{
string strAction = "GetObjByMessagePushUsersRelationId";
string strErrMsg = string.Empty;
string strResult = "";
clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MessagePushUsersRelationId"] = lngMessagePushUsersRelationId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMessagePushUsersRelationEN = JsonConvert.DeserializeObject<clsvMessagePushUsersRelationEN>((string)jobjReturn["ReturnObj"]);
return objvMessagePushUsersRelationEN;
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
 /// <param name = "lngMessagePushUsersRelationId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMessagePushUsersRelationEN GetObjByMessagePushUsersRelationId_WA_Cache(long lngMessagePushUsersRelationId)
{
string strAction = "GetObjByMessagePushUsersRelationId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MessagePushUsersRelationId"] = lngMessagePushUsersRelationId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMessagePushUsersRelationEN = JsonConvert.DeserializeObject<clsvMessagePushUsersRelationEN>((string)jobjReturn["ReturnObj"]);
return objvMessagePushUsersRelationEN;
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
public static clsvMessagePushUsersRelationEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = null;
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
objvMessagePushUsersRelationEN = JsonConvert.DeserializeObject<clsvMessagePushUsersRelationEN>((string)jobjReturn["ReturnObj"]);
return objvMessagePushUsersRelationEN;
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
 /// <param name = "lngMessagePushUsersRelationId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMessagePushUsersRelationEN GetObjByMessagePushUsersRelationId_Cache(long lngMessagePushUsersRelationId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMessagePushUsersRelationEN._CurrTabName_S);
List<clsvMessagePushUsersRelationEN> arrvMessagePushUsersRelationObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMessagePushUsersRelationEN> arrvMessagePushUsersRelationObjLst_Sel =
from objvMessagePushUsersRelationEN in arrvMessagePushUsersRelationObjLst_Cache
where objvMessagePushUsersRelationEN.MessagePushUsersRelationId == lngMessagePushUsersRelationId
select objvMessagePushUsersRelationEN;
if (arrvMessagePushUsersRelationObjLst_Sel.Count() == 0)
{
   clsvMessagePushUsersRelationEN obj = clsvMessagePushUsersRelationWApi.GetObjByMessagePushUsersRelationId(lngMessagePushUsersRelationId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvMessagePushUsersRelationObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMessagePushUsersRelationEN> GetObjLst(string strWhereCond)
{
 List<clsvMessagePushUsersRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMessagePushUsersRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMessagePushUsersRelationEN> GetObjLstByMessagePushUsersRelationIdLst(List<long> arrMessagePushUsersRelationId)
{
 List<clsvMessagePushUsersRelationEN> arrObjLst = null; 
string strAction = "GetObjLstByMessagePushUsersRelationIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMessagePushUsersRelationId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMessagePushUsersRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngMessagePushUsersRelationId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvMessagePushUsersRelationEN> GetObjLstByMessagePushUsersRelationIdLst_Cache(List<long> arrMessagePushUsersRelationId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMessagePushUsersRelationEN._CurrTabName_S);
List<clsvMessagePushUsersRelationEN> arrvMessagePushUsersRelationObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMessagePushUsersRelationEN> arrvMessagePushUsersRelationObjLst_Sel =
from objvMessagePushUsersRelationEN in arrvMessagePushUsersRelationObjLst_Cache
where arrMessagePushUsersRelationId.Contains(objvMessagePushUsersRelationEN.MessagePushUsersRelationId)
select objvMessagePushUsersRelationEN;
return arrvMessagePushUsersRelationObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMessagePushUsersRelationEN> GetObjLstByMessagePushUsersRelationIdLst_WA_Cache(List<long> arrMessagePushUsersRelationId)
{
 List<clsvMessagePushUsersRelationEN> arrObjLst = null; 
string strAction = "GetObjLstByMessagePushUsersRelationIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMessagePushUsersRelationId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMessagePushUsersRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMessagePushUsersRelationEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvMessagePushUsersRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMessagePushUsersRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMessagePushUsersRelationEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvMessagePushUsersRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMessagePushUsersRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMessagePushUsersRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvMessagePushUsersRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMessagePushUsersRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMessagePushUsersRelationEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvMessagePushUsersRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMessagePushUsersRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngMessagePushUsersRelationId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MessagePushUsersRelationId"] = lngMessagePushUsersRelationId.ToString()
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
public static DataTable ToDataTable(List<clsvMessagePushUsersRelationEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvMessagePushUsersRelationEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvMessagePushUsersRelationEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvMessagePushUsersRelationEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvMessagePushUsersRelationEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvMessagePushUsersRelationEN.AttributeName)
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
if (clsMessagePushUsersRelationWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMessagePushUsersRelationWApi没有刷新缓存机制(clsMessagePushUsersRelationWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by MessagePushUsersRelationId");
//if (arrvMessagePushUsersRelationObjLst_Cache == null)
//{
//arrvMessagePushUsersRelationObjLst_Cache = await clsvMessagePushUsersRelationWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvMessagePushUsersRelationEN._CurrTabName_S);
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
public static List<clsvMessagePushUsersRelationEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvMessagePushUsersRelationEN._CurrTabName_S);
List<clsvMessagePushUsersRelationEN> arrvMessagePushUsersRelationObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMessagePushUsersRelationObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvMessagePushUsersRelationEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convMessagePushUsersRelation.MessagePushUsersRelationId, Type.GetType("System.Int64"));
objDT.Columns.Add(convMessagePushUsersRelation.MessagePushId, Type.GetType("System.String"));
objDT.Columns.Add(convMessagePushUsersRelation.MessagePushNumber, Type.GetType("System.String"));
objDT.Columns.Add(convMessagePushUsersRelation.MessageTitle, Type.GetType("System.String"));
objDT.Columns.Add(convMessagePushUsersRelation.MessageContent, Type.GetType("System.String"));
objDT.Columns.Add(convMessagePushUsersRelation.MessageTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convMessagePushUsersRelation.IsAllpush, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMessagePushUsersRelation.ClientVersionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convMessagePushUsersRelation.ReceivePeople, Type.GetType("System.String"));
objDT.Columns.Add(convMessagePushUsersRelation.IsReceive, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMessagePushUsersRelation.CreateTime, Type.GetType("System.String"));
objDT.Columns.Add(convMessagePushUsersRelation.Memo, Type.GetType("System.String"));
foreach (clsvMessagePushUsersRelationEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convMessagePushUsersRelation.MessagePushUsersRelationId] = objInFor[convMessagePushUsersRelation.MessagePushUsersRelationId];
objDR[convMessagePushUsersRelation.MessagePushId] = objInFor[convMessagePushUsersRelation.MessagePushId];
objDR[convMessagePushUsersRelation.MessagePushNumber] = objInFor[convMessagePushUsersRelation.MessagePushNumber];
objDR[convMessagePushUsersRelation.MessageTitle] = objInFor[convMessagePushUsersRelation.MessageTitle];
objDR[convMessagePushUsersRelation.MessageContent] = objInFor[convMessagePushUsersRelation.MessageContent];
objDR[convMessagePushUsersRelation.MessageTypeId] = objInFor[convMessagePushUsersRelation.MessageTypeId];
objDR[convMessagePushUsersRelation.IsAllpush] = objInFor[convMessagePushUsersRelation.IsAllpush];
objDR[convMessagePushUsersRelation.ClientVersionTypeId] = objInFor[convMessagePushUsersRelation.ClientVersionTypeId];
objDR[convMessagePushUsersRelation.ReceivePeople] = objInFor[convMessagePushUsersRelation.ReceivePeople];
objDR[convMessagePushUsersRelation.IsReceive] = objInFor[convMessagePushUsersRelation.IsReceive];
objDR[convMessagePushUsersRelation.CreateTime] = objInFor[convMessagePushUsersRelation.CreateTime];
objDR[convMessagePushUsersRelation.Memo] = objInFor[convMessagePushUsersRelation.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}