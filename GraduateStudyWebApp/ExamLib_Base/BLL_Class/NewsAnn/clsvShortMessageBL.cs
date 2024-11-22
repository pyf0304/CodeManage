
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvShortMessageBL
 表名:vShortMessage(01120288)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:36
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
public static class  clsvShortMessageBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngShortMessageId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvShortMessageEN GetObj(this K_ShortMessageId_vShortMessage myKey)
{
clsvShortMessageEN objvShortMessageEN = clsvShortMessageBL.vShortMessageDA.GetObjByShortMessageId(myKey.Value);
return objvShortMessageEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvShortMessageEN SetShortMessageId(this clsvShortMessageEN objvShortMessageEN, long lngShortMessageId, string strComparisonOp="")
	{
objvShortMessageEN.ShortMessageId = lngShortMessageId; //短信消息Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvShortMessageEN.dicFldComparisonOp.ContainsKey(convShortMessage.ShortMessageId) == false)
{
objvShortMessageEN.dicFldComparisonOp.Add(convShortMessage.ShortMessageId, strComparisonOp);
}
else
{
objvShortMessageEN.dicFldComparisonOp[convShortMessage.ShortMessageId] = strComparisonOp;
}
}
return objvShortMessageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvShortMessageEN SetMessageNumber(this clsvShortMessageEN objvShortMessageEN, string strMessageNumber, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMessageNumber, 200, convShortMessage.MessageNumber);
}
objvShortMessageEN.MessageNumber = strMessageNumber; //消息编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvShortMessageEN.dicFldComparisonOp.ContainsKey(convShortMessage.MessageNumber) == false)
{
objvShortMessageEN.dicFldComparisonOp.Add(convShortMessage.MessageNumber, strComparisonOp);
}
else
{
objvShortMessageEN.dicFldComparisonOp[convShortMessage.MessageNumber] = strComparisonOp;
}
}
return objvShortMessageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvShortMessageEN SetSendMessageNumber(this clsvShortMessageEN objvShortMessageEN, string strSendMessageNumber, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSendMessageNumber, 200, convShortMessage.SendMessageNumber);
}
objvShortMessageEN.SendMessageNumber = strSendMessageNumber; //发送消息编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvShortMessageEN.dicFldComparisonOp.ContainsKey(convShortMessage.SendMessageNumber) == false)
{
objvShortMessageEN.dicFldComparisonOp.Add(convShortMessage.SendMessageNumber, strComparisonOp);
}
else
{
objvShortMessageEN.dicFldComparisonOp[convShortMessage.SendMessageNumber] = strComparisonOp;
}
}
return objvShortMessageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvShortMessageEN SetShortMessageSendSateName(this clsvShortMessageEN objvShortMessageEN, string strShortMessageSendSateName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShortMessageSendSateName, 200, convShortMessage.ShortMessageSendSateName);
}
objvShortMessageEN.ShortMessageSendSateName = strShortMessageSendSateName; //短消息发送状态名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvShortMessageEN.dicFldComparisonOp.ContainsKey(convShortMessage.ShortMessageSendSateName) == false)
{
objvShortMessageEN.dicFldComparisonOp.Add(convShortMessage.ShortMessageSendSateName, strComparisonOp);
}
else
{
objvShortMessageEN.dicFldComparisonOp[convShortMessage.ShortMessageSendSateName] = strComparisonOp;
}
}
return objvShortMessageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvShortMessageEN SetPhone(this clsvShortMessageEN objvShortMessageEN, string strPhone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPhone, 200, convShortMessage.Phone);
}
objvShortMessageEN.Phone = strPhone; //手机号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvShortMessageEN.dicFldComparisonOp.ContainsKey(convShortMessage.Phone) == false)
{
objvShortMessageEN.dicFldComparisonOp.Add(convShortMessage.Phone, strComparisonOp);
}
else
{
objvShortMessageEN.dicFldComparisonOp[convShortMessage.Phone] = strComparisonOp;
}
}
return objvShortMessageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvShortMessageEN SetMessageContent(this clsvShortMessageEN objvShortMessageEN, string strMessageContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMessageContent, 2000, convShortMessage.MessageContent);
}
objvShortMessageEN.MessageContent = strMessageContent; //消息内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvShortMessageEN.dicFldComparisonOp.ContainsKey(convShortMessage.MessageContent) == false)
{
objvShortMessageEN.dicFldComparisonOp.Add(convShortMessage.MessageContent, strComparisonOp);
}
else
{
objvShortMessageEN.dicFldComparisonOp[convShortMessage.MessageContent] = strComparisonOp;
}
}
return objvShortMessageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvShortMessageEN SetShortMessageSendSateID(this clsvShortMessageEN objvShortMessageEN, string strShortMessageSendSateID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strShortMessageSendSateID, convShortMessage.ShortMessageSendSateID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShortMessageSendSateID, 8, convShortMessage.ShortMessageSendSateID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShortMessageSendSateID, 8, convShortMessage.ShortMessageSendSateID);
}
objvShortMessageEN.ShortMessageSendSateID = strShortMessageSendSateID; //消息发送状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvShortMessageEN.dicFldComparisonOp.ContainsKey(convShortMessage.ShortMessageSendSateID) == false)
{
objvShortMessageEN.dicFldComparisonOp.Add(convShortMessage.ShortMessageSendSateID, strComparisonOp);
}
else
{
objvShortMessageEN.dicFldComparisonOp[convShortMessage.ShortMessageSendSateID] = strComparisonOp;
}
}
return objvShortMessageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvShortMessageEN SetReseiveState(this clsvShortMessageEN objvShortMessageEN, bool bolReseiveState, string strComparisonOp="")
	{
objvShortMessageEN.ReseiveState = bolReseiveState; //接收状态
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvShortMessageEN.dicFldComparisonOp.ContainsKey(convShortMessage.ReseiveState) == false)
{
objvShortMessageEN.dicFldComparisonOp.Add(convShortMessage.ReseiveState, strComparisonOp);
}
else
{
objvShortMessageEN.dicFldComparisonOp[convShortMessage.ReseiveState] = strComparisonOp;
}
}
return objvShortMessageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvShortMessageEN SetReturnTime(this clsvShortMessageEN objvShortMessageEN, string strReturnTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnTime, 20, convShortMessage.ReturnTime);
}
objvShortMessageEN.ReturnTime = strReturnTime; //状态返回时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvShortMessageEN.dicFldComparisonOp.ContainsKey(convShortMessage.ReturnTime) == false)
{
objvShortMessageEN.dicFldComparisonOp.Add(convShortMessage.ReturnTime, strComparisonOp);
}
else
{
objvShortMessageEN.dicFldComparisonOp[convShortMessage.ReturnTime] = strComparisonOp;
}
}
return objvShortMessageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvShortMessageEN SetMemo(this clsvShortMessageEN objvShortMessageEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convShortMessage.Memo);
}
objvShortMessageEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvShortMessageEN.dicFldComparisonOp.ContainsKey(convShortMessage.Memo) == false)
{
objvShortMessageEN.dicFldComparisonOp.Add(convShortMessage.Memo, strComparisonOp);
}
else
{
objvShortMessageEN.dicFldComparisonOp[convShortMessage.Memo] = strComparisonOp;
}
}
return objvShortMessageEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvShortMessageENS">源对象</param>
 /// <param name = "objvShortMessageENT">目标对象</param>
 public static void CopyTo(this clsvShortMessageEN objvShortMessageENS, clsvShortMessageEN objvShortMessageENT)
{
try
{
objvShortMessageENT.ShortMessageId = objvShortMessageENS.ShortMessageId; //短信消息Id
objvShortMessageENT.MessageNumber = objvShortMessageENS.MessageNumber; //消息编号
objvShortMessageENT.SendMessageNumber = objvShortMessageENS.SendMessageNumber; //发送消息编号
objvShortMessageENT.ShortMessageSendSateName = objvShortMessageENS.ShortMessageSendSateName; //短消息发送状态名称
objvShortMessageENT.Phone = objvShortMessageENS.Phone; //手机号
objvShortMessageENT.MessageContent = objvShortMessageENS.MessageContent; //消息内容
objvShortMessageENT.ShortMessageSendSateID = objvShortMessageENS.ShortMessageSendSateID; //消息发送状态Id
objvShortMessageENT.ReseiveState = objvShortMessageENS.ReseiveState; //接收状态
objvShortMessageENT.ReturnTime = objvShortMessageENS.ReturnTime; //状态返回时间
objvShortMessageENT.Memo = objvShortMessageENS.Memo; //备注
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
 /// <param name = "objvShortMessageENS">源对象</param>
 /// <returns>目标对象=>clsvShortMessageEN:objvShortMessageENT</returns>
 public static clsvShortMessageEN CopyTo(this clsvShortMessageEN objvShortMessageENS)
{
try
{
 clsvShortMessageEN objvShortMessageENT = new clsvShortMessageEN()
{
ShortMessageId = objvShortMessageENS.ShortMessageId, //短信消息Id
MessageNumber = objvShortMessageENS.MessageNumber, //消息编号
SendMessageNumber = objvShortMessageENS.SendMessageNumber, //发送消息编号
ShortMessageSendSateName = objvShortMessageENS.ShortMessageSendSateName, //短消息发送状态名称
Phone = objvShortMessageENS.Phone, //手机号
MessageContent = objvShortMessageENS.MessageContent, //消息内容
ShortMessageSendSateID = objvShortMessageENS.ShortMessageSendSateID, //消息发送状态Id
ReseiveState = objvShortMessageENS.ReseiveState, //接收状态
ReturnTime = objvShortMessageENS.ReturnTime, //状态返回时间
Memo = objvShortMessageENS.Memo, //备注
};
 return objvShortMessageENT;
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
public static void CheckProperty4Condition(this clsvShortMessageEN objvShortMessageEN)
{
 clsvShortMessageBL.vShortMessageDA.CheckProperty4Condition(objvShortMessageEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvShortMessageEN objvShortMessageCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvShortMessageCond.IsUpdated(convShortMessage.ShortMessageId) == true)
{
string strComparisonOpShortMessageId = objvShortMessageCond.dicFldComparisonOp[convShortMessage.ShortMessageId];
strWhereCond += string.Format(" And {0} {2} {1}", convShortMessage.ShortMessageId, objvShortMessageCond.ShortMessageId, strComparisonOpShortMessageId);
}
if (objvShortMessageCond.IsUpdated(convShortMessage.MessageNumber) == true)
{
string strComparisonOpMessageNumber = objvShortMessageCond.dicFldComparisonOp[convShortMessage.MessageNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convShortMessage.MessageNumber, objvShortMessageCond.MessageNumber, strComparisonOpMessageNumber);
}
if (objvShortMessageCond.IsUpdated(convShortMessage.SendMessageNumber) == true)
{
string strComparisonOpSendMessageNumber = objvShortMessageCond.dicFldComparisonOp[convShortMessage.SendMessageNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convShortMessage.SendMessageNumber, objvShortMessageCond.SendMessageNumber, strComparisonOpSendMessageNumber);
}
if (objvShortMessageCond.IsUpdated(convShortMessage.ShortMessageSendSateName) == true)
{
string strComparisonOpShortMessageSendSateName = objvShortMessageCond.dicFldComparisonOp[convShortMessage.ShortMessageSendSateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convShortMessage.ShortMessageSendSateName, objvShortMessageCond.ShortMessageSendSateName, strComparisonOpShortMessageSendSateName);
}
if (objvShortMessageCond.IsUpdated(convShortMessage.Phone) == true)
{
string strComparisonOpPhone = objvShortMessageCond.dicFldComparisonOp[convShortMessage.Phone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convShortMessage.Phone, objvShortMessageCond.Phone, strComparisonOpPhone);
}
if (objvShortMessageCond.IsUpdated(convShortMessage.MessageContent) == true)
{
string strComparisonOpMessageContent = objvShortMessageCond.dicFldComparisonOp[convShortMessage.MessageContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convShortMessage.MessageContent, objvShortMessageCond.MessageContent, strComparisonOpMessageContent);
}
if (objvShortMessageCond.IsUpdated(convShortMessage.ShortMessageSendSateID) == true)
{
string strComparisonOpShortMessageSendSateID = objvShortMessageCond.dicFldComparisonOp[convShortMessage.ShortMessageSendSateID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convShortMessage.ShortMessageSendSateID, objvShortMessageCond.ShortMessageSendSateID, strComparisonOpShortMessageSendSateID);
}
if (objvShortMessageCond.IsUpdated(convShortMessage.ReseiveState) == true)
{
if (objvShortMessageCond.ReseiveState == true)
{
strWhereCond += string.Format(" And {0} = '1'", convShortMessage.ReseiveState);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convShortMessage.ReseiveState);
}
}
if (objvShortMessageCond.IsUpdated(convShortMessage.ReturnTime) == true)
{
string strComparisonOpReturnTime = objvShortMessageCond.dicFldComparisonOp[convShortMessage.ReturnTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convShortMessage.ReturnTime, objvShortMessageCond.ReturnTime, strComparisonOpReturnTime);
}
if (objvShortMessageCond.IsUpdated(convShortMessage.Memo) == true)
{
string strComparisonOpMemo = objvShortMessageCond.dicFldComparisonOp[convShortMessage.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convShortMessage.Memo, objvShortMessageCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vShortMessage
{
public virtual bool UpdRelaTabDate(long lngShortMessageId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 短信消息视图(vShortMessage)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvShortMessageBL
{
public static RelatedActions_vShortMessage relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvShortMessageDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvShortMessageDA vShortMessageDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvShortMessageDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvShortMessageBL()
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
if (string.IsNullOrEmpty(clsvShortMessageEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvShortMessageEN._ConnectString);
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
public static DataTable GetDataTable_vShortMessage(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vShortMessageDA.GetDataTable_vShortMessage(strWhereCond);
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
objDT = vShortMessageDA.GetDataTable(strWhereCond);
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
objDT = vShortMessageDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vShortMessageDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vShortMessageDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vShortMessageDA.GetDataTable_Top(objTopPara);
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
objDT = vShortMessageDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vShortMessageDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vShortMessageDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrShortMessageIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvShortMessageEN> GetObjLstByShortMessageIdLst(List<long> arrShortMessageIdLst)
{
List<clsvShortMessageEN> arrObjLst = new List<clsvShortMessageEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrShortMessageIdLst);
 string strWhereCond = string.Format("ShortMessageId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvShortMessageEN objvShortMessageEN = new clsvShortMessageEN();
try
{
objvShortMessageEN.ShortMessageId = Int32.Parse(objRow[convShortMessage.ShortMessageId].ToString().Trim()); //短信消息Id
objvShortMessageEN.MessageNumber = objRow[convShortMessage.MessageNumber] == DBNull.Value ? null : objRow[convShortMessage.MessageNumber].ToString().Trim(); //消息编号
objvShortMessageEN.SendMessageNumber = objRow[convShortMessage.SendMessageNumber] == DBNull.Value ? null : objRow[convShortMessage.SendMessageNumber].ToString().Trim(); //发送消息编号
objvShortMessageEN.ShortMessageSendSateName = objRow[convShortMessage.ShortMessageSendSateName] == DBNull.Value ? null : objRow[convShortMessage.ShortMessageSendSateName].ToString().Trim(); //短消息发送状态名称
objvShortMessageEN.Phone = objRow[convShortMessage.Phone] == DBNull.Value ? null : objRow[convShortMessage.Phone].ToString().Trim(); //手机号
objvShortMessageEN.MessageContent = objRow[convShortMessage.MessageContent] == DBNull.Value ? null : objRow[convShortMessage.MessageContent].ToString().Trim(); //消息内容
objvShortMessageEN.ShortMessageSendSateID = objRow[convShortMessage.ShortMessageSendSateID].ToString().Trim(); //消息发送状态Id
objvShortMessageEN.ReseiveState = clsEntityBase2.TransNullToBool_S(objRow[convShortMessage.ReseiveState].ToString().Trim()); //接收状态
objvShortMessageEN.ReturnTime = objRow[convShortMessage.ReturnTime] == DBNull.Value ? null : objRow[convShortMessage.ReturnTime].ToString().Trim(); //状态返回时间
objvShortMessageEN.Memo = objRow[convShortMessage.Memo] == DBNull.Value ? null : objRow[convShortMessage.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvShortMessageEN.ShortMessageId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvShortMessageEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrShortMessageIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvShortMessageEN> GetObjLstByShortMessageIdLstCache(List<long> arrShortMessageIdLst)
{
string strKey = string.Format("{0}", clsvShortMessageEN._CurrTabName);
List<clsvShortMessageEN> arrvShortMessageObjLstCache = GetObjLstCache();
IEnumerable <clsvShortMessageEN> arrvShortMessageObjLst_Sel =
arrvShortMessageObjLstCache
.Where(x => arrShortMessageIdLst.Contains(x.ShortMessageId));
return arrvShortMessageObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvShortMessageEN> GetObjLst(string strWhereCond)
{
List<clsvShortMessageEN> arrObjLst = new List<clsvShortMessageEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvShortMessageEN objvShortMessageEN = new clsvShortMessageEN();
try
{
objvShortMessageEN.ShortMessageId = Int32.Parse(objRow[convShortMessage.ShortMessageId].ToString().Trim()); //短信消息Id
objvShortMessageEN.MessageNumber = objRow[convShortMessage.MessageNumber] == DBNull.Value ? null : objRow[convShortMessage.MessageNumber].ToString().Trim(); //消息编号
objvShortMessageEN.SendMessageNumber = objRow[convShortMessage.SendMessageNumber] == DBNull.Value ? null : objRow[convShortMessage.SendMessageNumber].ToString().Trim(); //发送消息编号
objvShortMessageEN.ShortMessageSendSateName = objRow[convShortMessage.ShortMessageSendSateName] == DBNull.Value ? null : objRow[convShortMessage.ShortMessageSendSateName].ToString().Trim(); //短消息发送状态名称
objvShortMessageEN.Phone = objRow[convShortMessage.Phone] == DBNull.Value ? null : objRow[convShortMessage.Phone].ToString().Trim(); //手机号
objvShortMessageEN.MessageContent = objRow[convShortMessage.MessageContent] == DBNull.Value ? null : objRow[convShortMessage.MessageContent].ToString().Trim(); //消息内容
objvShortMessageEN.ShortMessageSendSateID = objRow[convShortMessage.ShortMessageSendSateID].ToString().Trim(); //消息发送状态Id
objvShortMessageEN.ReseiveState = clsEntityBase2.TransNullToBool_S(objRow[convShortMessage.ReseiveState].ToString().Trim()); //接收状态
objvShortMessageEN.ReturnTime = objRow[convShortMessage.ReturnTime] == DBNull.Value ? null : objRow[convShortMessage.ReturnTime].ToString().Trim(); //状态返回时间
objvShortMessageEN.Memo = objRow[convShortMessage.Memo] == DBNull.Value ? null : objRow[convShortMessage.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvShortMessageEN.ShortMessageId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvShortMessageEN);
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
public static List<clsvShortMessageEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvShortMessageEN> arrObjLst = new List<clsvShortMessageEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvShortMessageEN objvShortMessageEN = new clsvShortMessageEN();
try
{
objvShortMessageEN.ShortMessageId = Int32.Parse(objRow[convShortMessage.ShortMessageId].ToString().Trim()); //短信消息Id
objvShortMessageEN.MessageNumber = objRow[convShortMessage.MessageNumber] == DBNull.Value ? null : objRow[convShortMessage.MessageNumber].ToString().Trim(); //消息编号
objvShortMessageEN.SendMessageNumber = objRow[convShortMessage.SendMessageNumber] == DBNull.Value ? null : objRow[convShortMessage.SendMessageNumber].ToString().Trim(); //发送消息编号
objvShortMessageEN.ShortMessageSendSateName = objRow[convShortMessage.ShortMessageSendSateName] == DBNull.Value ? null : objRow[convShortMessage.ShortMessageSendSateName].ToString().Trim(); //短消息发送状态名称
objvShortMessageEN.Phone = objRow[convShortMessage.Phone] == DBNull.Value ? null : objRow[convShortMessage.Phone].ToString().Trim(); //手机号
objvShortMessageEN.MessageContent = objRow[convShortMessage.MessageContent] == DBNull.Value ? null : objRow[convShortMessage.MessageContent].ToString().Trim(); //消息内容
objvShortMessageEN.ShortMessageSendSateID = objRow[convShortMessage.ShortMessageSendSateID].ToString().Trim(); //消息发送状态Id
objvShortMessageEN.ReseiveState = clsEntityBase2.TransNullToBool_S(objRow[convShortMessage.ReseiveState].ToString().Trim()); //接收状态
objvShortMessageEN.ReturnTime = objRow[convShortMessage.ReturnTime] == DBNull.Value ? null : objRow[convShortMessage.ReturnTime].ToString().Trim(); //状态返回时间
objvShortMessageEN.Memo = objRow[convShortMessage.Memo] == DBNull.Value ? null : objRow[convShortMessage.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvShortMessageEN.ShortMessageId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvShortMessageEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvShortMessageCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvShortMessageEN> GetSubObjLstCache(clsvShortMessageEN objvShortMessageCond)
{
List<clsvShortMessageEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvShortMessageEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convShortMessage.AttributeName)
{
if (objvShortMessageCond.IsUpdated(strFldName) == false) continue;
if (objvShortMessageCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvShortMessageCond[strFldName].ToString());
}
else
{
if (objvShortMessageCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvShortMessageCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvShortMessageCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvShortMessageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvShortMessageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvShortMessageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvShortMessageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvShortMessageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvShortMessageCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvShortMessageCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvShortMessageCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvShortMessageCond[strFldName]));
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
public static List<clsvShortMessageEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvShortMessageEN> arrObjLst = new List<clsvShortMessageEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvShortMessageEN objvShortMessageEN = new clsvShortMessageEN();
try
{
objvShortMessageEN.ShortMessageId = Int32.Parse(objRow[convShortMessage.ShortMessageId].ToString().Trim()); //短信消息Id
objvShortMessageEN.MessageNumber = objRow[convShortMessage.MessageNumber] == DBNull.Value ? null : objRow[convShortMessage.MessageNumber].ToString().Trim(); //消息编号
objvShortMessageEN.SendMessageNumber = objRow[convShortMessage.SendMessageNumber] == DBNull.Value ? null : objRow[convShortMessage.SendMessageNumber].ToString().Trim(); //发送消息编号
objvShortMessageEN.ShortMessageSendSateName = objRow[convShortMessage.ShortMessageSendSateName] == DBNull.Value ? null : objRow[convShortMessage.ShortMessageSendSateName].ToString().Trim(); //短消息发送状态名称
objvShortMessageEN.Phone = objRow[convShortMessage.Phone] == DBNull.Value ? null : objRow[convShortMessage.Phone].ToString().Trim(); //手机号
objvShortMessageEN.MessageContent = objRow[convShortMessage.MessageContent] == DBNull.Value ? null : objRow[convShortMessage.MessageContent].ToString().Trim(); //消息内容
objvShortMessageEN.ShortMessageSendSateID = objRow[convShortMessage.ShortMessageSendSateID].ToString().Trim(); //消息发送状态Id
objvShortMessageEN.ReseiveState = clsEntityBase2.TransNullToBool_S(objRow[convShortMessage.ReseiveState].ToString().Trim()); //接收状态
objvShortMessageEN.ReturnTime = objRow[convShortMessage.ReturnTime] == DBNull.Value ? null : objRow[convShortMessage.ReturnTime].ToString().Trim(); //状态返回时间
objvShortMessageEN.Memo = objRow[convShortMessage.Memo] == DBNull.Value ? null : objRow[convShortMessage.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvShortMessageEN.ShortMessageId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvShortMessageEN);
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
public static List<clsvShortMessageEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvShortMessageEN> arrObjLst = new List<clsvShortMessageEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvShortMessageEN objvShortMessageEN = new clsvShortMessageEN();
try
{
objvShortMessageEN.ShortMessageId = Int32.Parse(objRow[convShortMessage.ShortMessageId].ToString().Trim()); //短信消息Id
objvShortMessageEN.MessageNumber = objRow[convShortMessage.MessageNumber] == DBNull.Value ? null : objRow[convShortMessage.MessageNumber].ToString().Trim(); //消息编号
objvShortMessageEN.SendMessageNumber = objRow[convShortMessage.SendMessageNumber] == DBNull.Value ? null : objRow[convShortMessage.SendMessageNumber].ToString().Trim(); //发送消息编号
objvShortMessageEN.ShortMessageSendSateName = objRow[convShortMessage.ShortMessageSendSateName] == DBNull.Value ? null : objRow[convShortMessage.ShortMessageSendSateName].ToString().Trim(); //短消息发送状态名称
objvShortMessageEN.Phone = objRow[convShortMessage.Phone] == DBNull.Value ? null : objRow[convShortMessage.Phone].ToString().Trim(); //手机号
objvShortMessageEN.MessageContent = objRow[convShortMessage.MessageContent] == DBNull.Value ? null : objRow[convShortMessage.MessageContent].ToString().Trim(); //消息内容
objvShortMessageEN.ShortMessageSendSateID = objRow[convShortMessage.ShortMessageSendSateID].ToString().Trim(); //消息发送状态Id
objvShortMessageEN.ReseiveState = clsEntityBase2.TransNullToBool_S(objRow[convShortMessage.ReseiveState].ToString().Trim()); //接收状态
objvShortMessageEN.ReturnTime = objRow[convShortMessage.ReturnTime] == DBNull.Value ? null : objRow[convShortMessage.ReturnTime].ToString().Trim(); //状态返回时间
objvShortMessageEN.Memo = objRow[convShortMessage.Memo] == DBNull.Value ? null : objRow[convShortMessage.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvShortMessageEN.ShortMessageId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvShortMessageEN);
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
List<clsvShortMessageEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvShortMessageEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvShortMessageEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvShortMessageEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvShortMessageEN> arrObjLst = new List<clsvShortMessageEN>(); 
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
	clsvShortMessageEN objvShortMessageEN = new clsvShortMessageEN();
try
{
objvShortMessageEN.ShortMessageId = Int32.Parse(objRow[convShortMessage.ShortMessageId].ToString().Trim()); //短信消息Id
objvShortMessageEN.MessageNumber = objRow[convShortMessage.MessageNumber] == DBNull.Value ? null : objRow[convShortMessage.MessageNumber].ToString().Trim(); //消息编号
objvShortMessageEN.SendMessageNumber = objRow[convShortMessage.SendMessageNumber] == DBNull.Value ? null : objRow[convShortMessage.SendMessageNumber].ToString().Trim(); //发送消息编号
objvShortMessageEN.ShortMessageSendSateName = objRow[convShortMessage.ShortMessageSendSateName] == DBNull.Value ? null : objRow[convShortMessage.ShortMessageSendSateName].ToString().Trim(); //短消息发送状态名称
objvShortMessageEN.Phone = objRow[convShortMessage.Phone] == DBNull.Value ? null : objRow[convShortMessage.Phone].ToString().Trim(); //手机号
objvShortMessageEN.MessageContent = objRow[convShortMessage.MessageContent] == DBNull.Value ? null : objRow[convShortMessage.MessageContent].ToString().Trim(); //消息内容
objvShortMessageEN.ShortMessageSendSateID = objRow[convShortMessage.ShortMessageSendSateID].ToString().Trim(); //消息发送状态Id
objvShortMessageEN.ReseiveState = clsEntityBase2.TransNullToBool_S(objRow[convShortMessage.ReseiveState].ToString().Trim()); //接收状态
objvShortMessageEN.ReturnTime = objRow[convShortMessage.ReturnTime] == DBNull.Value ? null : objRow[convShortMessage.ReturnTime].ToString().Trim(); //状态返回时间
objvShortMessageEN.Memo = objRow[convShortMessage.Memo] == DBNull.Value ? null : objRow[convShortMessage.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvShortMessageEN.ShortMessageId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvShortMessageEN);
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
public static List<clsvShortMessageEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvShortMessageEN> arrObjLst = new List<clsvShortMessageEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvShortMessageEN objvShortMessageEN = new clsvShortMessageEN();
try
{
objvShortMessageEN.ShortMessageId = Int32.Parse(objRow[convShortMessage.ShortMessageId].ToString().Trim()); //短信消息Id
objvShortMessageEN.MessageNumber = objRow[convShortMessage.MessageNumber] == DBNull.Value ? null : objRow[convShortMessage.MessageNumber].ToString().Trim(); //消息编号
objvShortMessageEN.SendMessageNumber = objRow[convShortMessage.SendMessageNumber] == DBNull.Value ? null : objRow[convShortMessage.SendMessageNumber].ToString().Trim(); //发送消息编号
objvShortMessageEN.ShortMessageSendSateName = objRow[convShortMessage.ShortMessageSendSateName] == DBNull.Value ? null : objRow[convShortMessage.ShortMessageSendSateName].ToString().Trim(); //短消息发送状态名称
objvShortMessageEN.Phone = objRow[convShortMessage.Phone] == DBNull.Value ? null : objRow[convShortMessage.Phone].ToString().Trim(); //手机号
objvShortMessageEN.MessageContent = objRow[convShortMessage.MessageContent] == DBNull.Value ? null : objRow[convShortMessage.MessageContent].ToString().Trim(); //消息内容
objvShortMessageEN.ShortMessageSendSateID = objRow[convShortMessage.ShortMessageSendSateID].ToString().Trim(); //消息发送状态Id
objvShortMessageEN.ReseiveState = clsEntityBase2.TransNullToBool_S(objRow[convShortMessage.ReseiveState].ToString().Trim()); //接收状态
objvShortMessageEN.ReturnTime = objRow[convShortMessage.ReturnTime] == DBNull.Value ? null : objRow[convShortMessage.ReturnTime].ToString().Trim(); //状态返回时间
objvShortMessageEN.Memo = objRow[convShortMessage.Memo] == DBNull.Value ? null : objRow[convShortMessage.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvShortMessageEN.ShortMessageId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvShortMessageEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvShortMessageEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvShortMessageEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvShortMessageEN> arrObjLst = new List<clsvShortMessageEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvShortMessageEN objvShortMessageEN = new clsvShortMessageEN();
try
{
objvShortMessageEN.ShortMessageId = Int32.Parse(objRow[convShortMessage.ShortMessageId].ToString().Trim()); //短信消息Id
objvShortMessageEN.MessageNumber = objRow[convShortMessage.MessageNumber] == DBNull.Value ? null : objRow[convShortMessage.MessageNumber].ToString().Trim(); //消息编号
objvShortMessageEN.SendMessageNumber = objRow[convShortMessage.SendMessageNumber] == DBNull.Value ? null : objRow[convShortMessage.SendMessageNumber].ToString().Trim(); //发送消息编号
objvShortMessageEN.ShortMessageSendSateName = objRow[convShortMessage.ShortMessageSendSateName] == DBNull.Value ? null : objRow[convShortMessage.ShortMessageSendSateName].ToString().Trim(); //短消息发送状态名称
objvShortMessageEN.Phone = objRow[convShortMessage.Phone] == DBNull.Value ? null : objRow[convShortMessage.Phone].ToString().Trim(); //手机号
objvShortMessageEN.MessageContent = objRow[convShortMessage.MessageContent] == DBNull.Value ? null : objRow[convShortMessage.MessageContent].ToString().Trim(); //消息内容
objvShortMessageEN.ShortMessageSendSateID = objRow[convShortMessage.ShortMessageSendSateID].ToString().Trim(); //消息发送状态Id
objvShortMessageEN.ReseiveState = clsEntityBase2.TransNullToBool_S(objRow[convShortMessage.ReseiveState].ToString().Trim()); //接收状态
objvShortMessageEN.ReturnTime = objRow[convShortMessage.ReturnTime] == DBNull.Value ? null : objRow[convShortMessage.ReturnTime].ToString().Trim(); //状态返回时间
objvShortMessageEN.Memo = objRow[convShortMessage.Memo] == DBNull.Value ? null : objRow[convShortMessage.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvShortMessageEN.ShortMessageId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvShortMessageEN);
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
public static List<clsvShortMessageEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvShortMessageEN> arrObjLst = new List<clsvShortMessageEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvShortMessageEN objvShortMessageEN = new clsvShortMessageEN();
try
{
objvShortMessageEN.ShortMessageId = Int32.Parse(objRow[convShortMessage.ShortMessageId].ToString().Trim()); //短信消息Id
objvShortMessageEN.MessageNumber = objRow[convShortMessage.MessageNumber] == DBNull.Value ? null : objRow[convShortMessage.MessageNumber].ToString().Trim(); //消息编号
objvShortMessageEN.SendMessageNumber = objRow[convShortMessage.SendMessageNumber] == DBNull.Value ? null : objRow[convShortMessage.SendMessageNumber].ToString().Trim(); //发送消息编号
objvShortMessageEN.ShortMessageSendSateName = objRow[convShortMessage.ShortMessageSendSateName] == DBNull.Value ? null : objRow[convShortMessage.ShortMessageSendSateName].ToString().Trim(); //短消息发送状态名称
objvShortMessageEN.Phone = objRow[convShortMessage.Phone] == DBNull.Value ? null : objRow[convShortMessage.Phone].ToString().Trim(); //手机号
objvShortMessageEN.MessageContent = objRow[convShortMessage.MessageContent] == DBNull.Value ? null : objRow[convShortMessage.MessageContent].ToString().Trim(); //消息内容
objvShortMessageEN.ShortMessageSendSateID = objRow[convShortMessage.ShortMessageSendSateID].ToString().Trim(); //消息发送状态Id
objvShortMessageEN.ReseiveState = clsEntityBase2.TransNullToBool_S(objRow[convShortMessage.ReseiveState].ToString().Trim()); //接收状态
objvShortMessageEN.ReturnTime = objRow[convShortMessage.ReturnTime] == DBNull.Value ? null : objRow[convShortMessage.ReturnTime].ToString().Trim(); //状态返回时间
objvShortMessageEN.Memo = objRow[convShortMessage.Memo] == DBNull.Value ? null : objRow[convShortMessage.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvShortMessageEN.ShortMessageId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvShortMessageEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvShortMessageEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvShortMessageEN> arrObjLst = new List<clsvShortMessageEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvShortMessageEN objvShortMessageEN = new clsvShortMessageEN();
try
{
objvShortMessageEN.ShortMessageId = Int32.Parse(objRow[convShortMessage.ShortMessageId].ToString().Trim()); //短信消息Id
objvShortMessageEN.MessageNumber = objRow[convShortMessage.MessageNumber] == DBNull.Value ? null : objRow[convShortMessage.MessageNumber].ToString().Trim(); //消息编号
objvShortMessageEN.SendMessageNumber = objRow[convShortMessage.SendMessageNumber] == DBNull.Value ? null : objRow[convShortMessage.SendMessageNumber].ToString().Trim(); //发送消息编号
objvShortMessageEN.ShortMessageSendSateName = objRow[convShortMessage.ShortMessageSendSateName] == DBNull.Value ? null : objRow[convShortMessage.ShortMessageSendSateName].ToString().Trim(); //短消息发送状态名称
objvShortMessageEN.Phone = objRow[convShortMessage.Phone] == DBNull.Value ? null : objRow[convShortMessage.Phone].ToString().Trim(); //手机号
objvShortMessageEN.MessageContent = objRow[convShortMessage.MessageContent] == DBNull.Value ? null : objRow[convShortMessage.MessageContent].ToString().Trim(); //消息内容
objvShortMessageEN.ShortMessageSendSateID = objRow[convShortMessage.ShortMessageSendSateID].ToString().Trim(); //消息发送状态Id
objvShortMessageEN.ReseiveState = clsEntityBase2.TransNullToBool_S(objRow[convShortMessage.ReseiveState].ToString().Trim()); //接收状态
objvShortMessageEN.ReturnTime = objRow[convShortMessage.ReturnTime] == DBNull.Value ? null : objRow[convShortMessage.ReturnTime].ToString().Trim(); //状态返回时间
objvShortMessageEN.Memo = objRow[convShortMessage.Memo] == DBNull.Value ? null : objRow[convShortMessage.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvShortMessageEN.ShortMessageId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvShortMessageEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvShortMessageEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvShortMessage(ref clsvShortMessageEN objvShortMessageEN)
{
bool bolResult = vShortMessageDA.GetvShortMessage(ref objvShortMessageEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngShortMessageId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvShortMessageEN GetObjByShortMessageId(long lngShortMessageId)
{
clsvShortMessageEN objvShortMessageEN = vShortMessageDA.GetObjByShortMessageId(lngShortMessageId);
return objvShortMessageEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvShortMessageEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvShortMessageEN objvShortMessageEN = vShortMessageDA.GetFirstObj(strWhereCond);
 return objvShortMessageEN;
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
public static clsvShortMessageEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvShortMessageEN objvShortMessageEN = vShortMessageDA.GetObjByDataRow(objRow);
 return objvShortMessageEN;
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
public static clsvShortMessageEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvShortMessageEN objvShortMessageEN = vShortMessageDA.GetObjByDataRow(objRow);
 return objvShortMessageEN;
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
 /// <param name = "lngShortMessageId">所给的关键字</param>
 /// <param name = "lstvShortMessageObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvShortMessageEN GetObjByShortMessageIdFromList(long lngShortMessageId, List<clsvShortMessageEN> lstvShortMessageObjLst)
{
foreach (clsvShortMessageEN objvShortMessageEN in lstvShortMessageObjLst)
{
if (objvShortMessageEN.ShortMessageId == lngShortMessageId)
{
return objvShortMessageEN;
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
 long lngShortMessageId;
 try
 {
 lngShortMessageId = new clsvShortMessageDA().GetFirstID(strWhereCond);
 return lngShortMessageId;
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
 arrList = vShortMessageDA.GetID(strWhereCond);
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
bool bolIsExist = vShortMessageDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngShortMessageId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngShortMessageId)
{
//检测记录是否存在
bool bolIsExist = vShortMessageDA.IsExist(lngShortMessageId);
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
 bolIsExist = clsvShortMessageDA.IsExistTable();
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
 bolIsExist = vShortMessageDA.IsExistTable(strTabName);
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
 /// <param name = "objvShortMessageENS">源对象</param>
 /// <param name = "objvShortMessageENT">目标对象</param>
 public static void CopyTo(clsvShortMessageEN objvShortMessageENS, clsvShortMessageEN objvShortMessageENT)
{
try
{
objvShortMessageENT.ShortMessageId = objvShortMessageENS.ShortMessageId; //短信消息Id
objvShortMessageENT.MessageNumber = objvShortMessageENS.MessageNumber; //消息编号
objvShortMessageENT.SendMessageNumber = objvShortMessageENS.SendMessageNumber; //发送消息编号
objvShortMessageENT.ShortMessageSendSateName = objvShortMessageENS.ShortMessageSendSateName; //短消息发送状态名称
objvShortMessageENT.Phone = objvShortMessageENS.Phone; //手机号
objvShortMessageENT.MessageContent = objvShortMessageENS.MessageContent; //消息内容
objvShortMessageENT.ShortMessageSendSateID = objvShortMessageENS.ShortMessageSendSateID; //消息发送状态Id
objvShortMessageENT.ReseiveState = objvShortMessageENS.ReseiveState; //接收状态
objvShortMessageENT.ReturnTime = objvShortMessageENS.ReturnTime; //状态返回时间
objvShortMessageENT.Memo = objvShortMessageENS.Memo; //备注
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
 /// <param name = "objvShortMessageEN">源简化对象</param>
 public static void SetUpdFlag(clsvShortMessageEN objvShortMessageEN)
{
try
{
objvShortMessageEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvShortMessageEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convShortMessage.ShortMessageId, new clsStrCompareIgnoreCase())  ==  true)
{
objvShortMessageEN.ShortMessageId = objvShortMessageEN.ShortMessageId; //短信消息Id
}
if (arrFldSet.Contains(convShortMessage.MessageNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvShortMessageEN.MessageNumber = objvShortMessageEN.MessageNumber == "[null]" ? null :  objvShortMessageEN.MessageNumber; //消息编号
}
if (arrFldSet.Contains(convShortMessage.SendMessageNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvShortMessageEN.SendMessageNumber = objvShortMessageEN.SendMessageNumber == "[null]" ? null :  objvShortMessageEN.SendMessageNumber; //发送消息编号
}
if (arrFldSet.Contains(convShortMessage.ShortMessageSendSateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvShortMessageEN.ShortMessageSendSateName = objvShortMessageEN.ShortMessageSendSateName == "[null]" ? null :  objvShortMessageEN.ShortMessageSendSateName; //短消息发送状态名称
}
if (arrFldSet.Contains(convShortMessage.Phone, new clsStrCompareIgnoreCase())  ==  true)
{
objvShortMessageEN.Phone = objvShortMessageEN.Phone == "[null]" ? null :  objvShortMessageEN.Phone; //手机号
}
if (arrFldSet.Contains(convShortMessage.MessageContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvShortMessageEN.MessageContent = objvShortMessageEN.MessageContent == "[null]" ? null :  objvShortMessageEN.MessageContent; //消息内容
}
if (arrFldSet.Contains(convShortMessage.ShortMessageSendSateID, new clsStrCompareIgnoreCase())  ==  true)
{
objvShortMessageEN.ShortMessageSendSateID = objvShortMessageEN.ShortMessageSendSateID; //消息发送状态Id
}
if (arrFldSet.Contains(convShortMessage.ReseiveState, new clsStrCompareIgnoreCase())  ==  true)
{
objvShortMessageEN.ReseiveState = objvShortMessageEN.ReseiveState; //接收状态
}
if (arrFldSet.Contains(convShortMessage.ReturnTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvShortMessageEN.ReturnTime = objvShortMessageEN.ReturnTime == "[null]" ? null :  objvShortMessageEN.ReturnTime; //状态返回时间
}
if (arrFldSet.Contains(convShortMessage.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvShortMessageEN.Memo = objvShortMessageEN.Memo == "[null]" ? null :  objvShortMessageEN.Memo; //备注
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
 /// <param name = "objvShortMessageEN">源简化对象</param>
 public static void AccessFldValueNull(clsvShortMessageEN objvShortMessageEN)
{
try
{
if (objvShortMessageEN.MessageNumber == "[null]") objvShortMessageEN.MessageNumber = null; //消息编号
if (objvShortMessageEN.SendMessageNumber == "[null]") objvShortMessageEN.SendMessageNumber = null; //发送消息编号
if (objvShortMessageEN.ShortMessageSendSateName == "[null]") objvShortMessageEN.ShortMessageSendSateName = null; //短消息发送状态名称
if (objvShortMessageEN.Phone == "[null]") objvShortMessageEN.Phone = null; //手机号
if (objvShortMessageEN.MessageContent == "[null]") objvShortMessageEN.MessageContent = null; //消息内容
if (objvShortMessageEN.ReturnTime == "[null]") objvShortMessageEN.ReturnTime = null; //状态返回时间
if (objvShortMessageEN.Memo == "[null]") objvShortMessageEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvShortMessageEN objvShortMessageEN)
{
 vShortMessageDA.CheckProperty4Condition(objvShortMessageEN);
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
if (clsShortMessageBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsShortMessageBL没有刷新缓存机制(clsShortMessageBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsShortMessageSendSateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsShortMessageSendSateBL没有刷新缓存机制(clsShortMessageSendSateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ShortMessageId");
//if (arrvShortMessageObjLstCache == null)
//{
//arrvShortMessageObjLstCache = vShortMessageDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngShortMessageId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvShortMessageEN GetObjByShortMessageIdCache(long lngShortMessageId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvShortMessageEN._CurrTabName);
List<clsvShortMessageEN> arrvShortMessageObjLstCache = GetObjLstCache();
IEnumerable <clsvShortMessageEN> arrvShortMessageObjLst_Sel =
arrvShortMessageObjLstCache
.Where(x=> x.ShortMessageId == lngShortMessageId 
);
if (arrvShortMessageObjLst_Sel.Count() == 0)
{
   clsvShortMessageEN obj = clsvShortMessageBL.GetObjByShortMessageId(lngShortMessageId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvShortMessageObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvShortMessageEN> GetAllvShortMessageObjLstCache()
{
//获取缓存中的对象列表
List<clsvShortMessageEN> arrvShortMessageObjLstCache = GetObjLstCache(); 
return arrvShortMessageObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvShortMessageEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvShortMessageEN._CurrTabName);
List<clsvShortMessageEN> arrvShortMessageObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvShortMessageObjLstCache;
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
string strKey = string.Format("{0}", clsvShortMessageEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngShortMessageId)
{
if (strInFldName != convShortMessage.ShortMessageId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convShortMessage.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convShortMessage.AttributeName));
throw new Exception(strMsg);
}
var objvShortMessage = clsvShortMessageBL.GetObjByShortMessageIdCache(lngShortMessageId);
if (objvShortMessage == null) return "";
return objvShortMessage[strOutFldName].ToString();
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
int intRecCount = clsvShortMessageDA.GetRecCount(strTabName);
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
int intRecCount = clsvShortMessageDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvShortMessageDA.GetRecCount();
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
int intRecCount = clsvShortMessageDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvShortMessageCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvShortMessageEN objvShortMessageCond)
{
List<clsvShortMessageEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvShortMessageEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convShortMessage.AttributeName)
{
if (objvShortMessageCond.IsUpdated(strFldName) == false) continue;
if (objvShortMessageCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvShortMessageCond[strFldName].ToString());
}
else
{
if (objvShortMessageCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvShortMessageCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvShortMessageCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvShortMessageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvShortMessageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvShortMessageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvShortMessageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvShortMessageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvShortMessageCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvShortMessageCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvShortMessageCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvShortMessageCond[strFldName]));
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
 List<string> arrList = clsvShortMessageDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vShortMessageDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vShortMessageDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}