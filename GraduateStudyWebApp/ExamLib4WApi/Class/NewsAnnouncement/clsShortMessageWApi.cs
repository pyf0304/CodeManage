
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsShortMessageWApi
 表名:ShortMessage(01120286)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:10
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
public static class clsShortMessageWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsShortMessageEN SetShortMessageId(this clsShortMessageEN objShortMessageEN, long lngShortMessageId, string strComparisonOp="")
	{
objShortMessageEN.ShortMessageId = lngShortMessageId; //短信消息Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objShortMessageEN.dicFldComparisonOp.ContainsKey(conShortMessage.ShortMessageId) == false)
{
objShortMessageEN.dicFldComparisonOp.Add(conShortMessage.ShortMessageId, strComparisonOp);
}
else
{
objShortMessageEN.dicFldComparisonOp[conShortMessage.ShortMessageId] = strComparisonOp;
}
}
return objShortMessageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsShortMessageEN SetMessageNumber(this clsShortMessageEN objShortMessageEN, string strMessageNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMessageNumber, 200, conShortMessage.MessageNumber);
objShortMessageEN.MessageNumber = strMessageNumber; //消息编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objShortMessageEN.dicFldComparisonOp.ContainsKey(conShortMessage.MessageNumber) == false)
{
objShortMessageEN.dicFldComparisonOp.Add(conShortMessage.MessageNumber, strComparisonOp);
}
else
{
objShortMessageEN.dicFldComparisonOp[conShortMessage.MessageNumber] = strComparisonOp;
}
}
return objShortMessageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsShortMessageEN SetSendMessageNumber(this clsShortMessageEN objShortMessageEN, string strSendMessageNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSendMessageNumber, 200, conShortMessage.SendMessageNumber);
objShortMessageEN.SendMessageNumber = strSendMessageNumber; //发送消息编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objShortMessageEN.dicFldComparisonOp.ContainsKey(conShortMessage.SendMessageNumber) == false)
{
objShortMessageEN.dicFldComparisonOp.Add(conShortMessage.SendMessageNumber, strComparisonOp);
}
else
{
objShortMessageEN.dicFldComparisonOp[conShortMessage.SendMessageNumber] = strComparisonOp;
}
}
return objShortMessageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsShortMessageEN SetPhone(this clsShortMessageEN objShortMessageEN, string strPhone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPhone, 200, conShortMessage.Phone);
objShortMessageEN.Phone = strPhone; //手机号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objShortMessageEN.dicFldComparisonOp.ContainsKey(conShortMessage.Phone) == false)
{
objShortMessageEN.dicFldComparisonOp.Add(conShortMessage.Phone, strComparisonOp);
}
else
{
objShortMessageEN.dicFldComparisonOp[conShortMessage.Phone] = strComparisonOp;
}
}
return objShortMessageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsShortMessageEN SetMessageContent(this clsShortMessageEN objShortMessageEN, string strMessageContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMessageContent, 2000, conShortMessage.MessageContent);
objShortMessageEN.MessageContent = strMessageContent; //消息内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objShortMessageEN.dicFldComparisonOp.ContainsKey(conShortMessage.MessageContent) == false)
{
objShortMessageEN.dicFldComparisonOp.Add(conShortMessage.MessageContent, strComparisonOp);
}
else
{
objShortMessageEN.dicFldComparisonOp[conShortMessage.MessageContent] = strComparisonOp;
}
}
return objShortMessageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsShortMessageEN SetShortMessageSendSateID(this clsShortMessageEN objShortMessageEN, string strShortMessageSendSateID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strShortMessageSendSateID, conShortMessage.ShortMessageSendSateID);
clsCheckSql.CheckFieldLen(strShortMessageSendSateID, 8, conShortMessage.ShortMessageSendSateID);
clsCheckSql.CheckFieldForeignKey(strShortMessageSendSateID, 8, conShortMessage.ShortMessageSendSateID);
objShortMessageEN.ShortMessageSendSateID = strShortMessageSendSateID; //消息发送状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objShortMessageEN.dicFldComparisonOp.ContainsKey(conShortMessage.ShortMessageSendSateID) == false)
{
objShortMessageEN.dicFldComparisonOp.Add(conShortMessage.ShortMessageSendSateID, strComparisonOp);
}
else
{
objShortMessageEN.dicFldComparisonOp[conShortMessage.ShortMessageSendSateID] = strComparisonOp;
}
}
return objShortMessageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsShortMessageEN SetReseiveState(this clsShortMessageEN objShortMessageEN, bool bolReseiveState, string strComparisonOp="")
	{
objShortMessageEN.ReseiveState = bolReseiveState; //接收状态
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objShortMessageEN.dicFldComparisonOp.ContainsKey(conShortMessage.ReseiveState) == false)
{
objShortMessageEN.dicFldComparisonOp.Add(conShortMessage.ReseiveState, strComparisonOp);
}
else
{
objShortMessageEN.dicFldComparisonOp[conShortMessage.ReseiveState] = strComparisonOp;
}
}
return objShortMessageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsShortMessageEN SetReturnTime(this clsShortMessageEN objShortMessageEN, string strReturnTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnTime, 20, conShortMessage.ReturnTime);
objShortMessageEN.ReturnTime = strReturnTime; //状态返回时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objShortMessageEN.dicFldComparisonOp.ContainsKey(conShortMessage.ReturnTime) == false)
{
objShortMessageEN.dicFldComparisonOp.Add(conShortMessage.ReturnTime, strComparisonOp);
}
else
{
objShortMessageEN.dicFldComparisonOp[conShortMessage.ReturnTime] = strComparisonOp;
}
}
return objShortMessageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsShortMessageEN SetMemo(this clsShortMessageEN objShortMessageEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conShortMessage.Memo);
objShortMessageEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objShortMessageEN.dicFldComparisonOp.ContainsKey(conShortMessage.Memo) == false)
{
objShortMessageEN.dicFldComparisonOp.Add(conShortMessage.Memo, strComparisonOp);
}
else
{
objShortMessageEN.dicFldComparisonOp[conShortMessage.Memo] = strComparisonOp;
}
}
return objShortMessageEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsShortMessageEN objShortMessage_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objShortMessage_Cond.IsUpdated(conShortMessage.ShortMessageId) == true)
{
string strComparisonOp_ShortMessageId = objShortMessage_Cond.dicFldComparisonOp[conShortMessage.ShortMessageId];
strWhereCond += string.Format(" And {0} {2} {1}", conShortMessage.ShortMessageId, objShortMessage_Cond.ShortMessageId, strComparisonOp_ShortMessageId);
}
if (objShortMessage_Cond.IsUpdated(conShortMessage.MessageNumber) == true)
{
string strComparisonOp_MessageNumber = objShortMessage_Cond.dicFldComparisonOp[conShortMessage.MessageNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", conShortMessage.MessageNumber, objShortMessage_Cond.MessageNumber, strComparisonOp_MessageNumber);
}
if (objShortMessage_Cond.IsUpdated(conShortMessage.SendMessageNumber) == true)
{
string strComparisonOp_SendMessageNumber = objShortMessage_Cond.dicFldComparisonOp[conShortMessage.SendMessageNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", conShortMessage.SendMessageNumber, objShortMessage_Cond.SendMessageNumber, strComparisonOp_SendMessageNumber);
}
if (objShortMessage_Cond.IsUpdated(conShortMessage.Phone) == true)
{
string strComparisonOp_Phone = objShortMessage_Cond.dicFldComparisonOp[conShortMessage.Phone];
strWhereCond += string.Format(" And {0} {2} '{1}'", conShortMessage.Phone, objShortMessage_Cond.Phone, strComparisonOp_Phone);
}
if (objShortMessage_Cond.IsUpdated(conShortMessage.MessageContent) == true)
{
string strComparisonOp_MessageContent = objShortMessage_Cond.dicFldComparisonOp[conShortMessage.MessageContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conShortMessage.MessageContent, objShortMessage_Cond.MessageContent, strComparisonOp_MessageContent);
}
if (objShortMessage_Cond.IsUpdated(conShortMessage.ShortMessageSendSateID) == true)
{
string strComparisonOp_ShortMessageSendSateID = objShortMessage_Cond.dicFldComparisonOp[conShortMessage.ShortMessageSendSateID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conShortMessage.ShortMessageSendSateID, objShortMessage_Cond.ShortMessageSendSateID, strComparisonOp_ShortMessageSendSateID);
}
if (objShortMessage_Cond.IsUpdated(conShortMessage.ReseiveState) == true)
{
if (objShortMessage_Cond.ReseiveState == true)
{
strWhereCond += string.Format(" And {0} = '1'", conShortMessage.ReseiveState);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conShortMessage.ReseiveState);
}
}
if (objShortMessage_Cond.IsUpdated(conShortMessage.ReturnTime) == true)
{
string strComparisonOp_ReturnTime = objShortMessage_Cond.dicFldComparisonOp[conShortMessage.ReturnTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conShortMessage.ReturnTime, objShortMessage_Cond.ReturnTime, strComparisonOp_ReturnTime);
}
if (objShortMessage_Cond.IsUpdated(conShortMessage.Memo) == true)
{
string strComparisonOp_Memo = objShortMessage_Cond.dicFldComparisonOp[conShortMessage.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conShortMessage.Memo, objShortMessage_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objShortMessageEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsShortMessageEN objShortMessageEN)
{
 if (objShortMessageEN.ShortMessageId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objShortMessageEN.sf_UpdFldSetStr = objShortMessageEN.getsf_UpdFldSetStr();
clsShortMessageWApi.CheckPropertyNew(objShortMessageEN); 
bool bolResult = clsShortMessageWApi.UpdateRecord(objShortMessageEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsShortMessageWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--ShortMessage(短信消息), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objShortMessageEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_ShortMessageSendSateID_Phone(this clsShortMessageEN objShortMessageEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objShortMessageEN == null) return "";
if (objShortMessageEN.ShortMessageId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ShortMessageSendSateID = '{0}'", objShortMessageEN.ShortMessageSendSateID);
 sbCondition.AppendFormat(" and Phone = '{0}'", objShortMessageEN.Phone);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ShortMessageId !=  {0}", objShortMessageEN.ShortMessageId);
 sbCondition.AppendFormat(" and ShortMessageSendSateID = '{0}'", objShortMessageEN.ShortMessageSendSateID);
 sbCondition.AppendFormat(" and Phone = '{0}'", objShortMessageEN.Phone);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objShortMessageEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsShortMessageEN objShortMessageEN)
{
try
{
clsShortMessageWApi.CheckPropertyNew(objShortMessageEN); 
bool bolResult = clsShortMessageWApi.AddNewRecord(objShortMessageEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsShortMessageWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objShortMessageEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsShortMessageEN objShortMessageEN, string strWhereCond)
{
try
{
clsShortMessageWApi.CheckPropertyNew(objShortMessageEN); 
bool bolResult = clsShortMessageWApi.UpdateWithCondition(objShortMessageEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsShortMessageWApi.ReFreshCache();
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
 /// 短信消息(ShortMessage)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsShortMessageWApi
{
private static readonly string mstrApiControllerName = "ShortMessageApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsShortMessageWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsShortMessageEN objShortMessageEN)
{
if (!Object.Equals(null, objShortMessageEN.MessageNumber) && GetStrLen(objShortMessageEN.MessageNumber) > 200)
{
 throw new Exception("字段[消息编号]的长度不能超过200!");
}
if (!Object.Equals(null, objShortMessageEN.SendMessageNumber) && GetStrLen(objShortMessageEN.SendMessageNumber) > 200)
{
 throw new Exception("字段[发送消息编号]的长度不能超过200!");
}
if (!Object.Equals(null, objShortMessageEN.Phone) && GetStrLen(objShortMessageEN.Phone) > 200)
{
 throw new Exception("字段[手机号]的长度不能超过200!");
}
if (!Object.Equals(null, objShortMessageEN.MessageContent) && GetStrLen(objShortMessageEN.MessageContent) > 2000)
{
 throw new Exception("字段[消息内容]的长度不能超过2000!");
}
if (!Object.Equals(null, objShortMessageEN.ShortMessageSendSateID) && GetStrLen(objShortMessageEN.ShortMessageSendSateID) > 8)
{
 throw new Exception("字段[消息发送状态Id]的长度不能超过8!");
}
if (!Object.Equals(null, objShortMessageEN.ReturnTime) && GetStrLen(objShortMessageEN.ReturnTime) > 20)
{
 throw new Exception("字段[状态返回时间]的长度不能超过20!");
}
if (!Object.Equals(null, objShortMessageEN.Memo) && GetStrLen(objShortMessageEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objShortMessageEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngShortMessageId">表关键字</param>
 /// <returns>表对象</returns>
public static clsShortMessageEN GetObjByShortMessageId(long lngShortMessageId)
{
string strAction = "GetObjByShortMessageId";
string strErrMsg = string.Empty;
string strResult = "";
clsShortMessageEN objShortMessageEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ShortMessageId"] = lngShortMessageId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objShortMessageEN = JsonConvert.DeserializeObject<clsShortMessageEN>((string)jobjReturn["ReturnObj"]);
return objShortMessageEN;
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
 /// <param name = "lngShortMessageId">表关键字</param>
 /// <returns>表对象</returns>
public static clsShortMessageEN GetObjByShortMessageId_WA_Cache(long lngShortMessageId)
{
string strAction = "GetObjByShortMessageId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsShortMessageEN objShortMessageEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ShortMessageId"] = lngShortMessageId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objShortMessageEN = JsonConvert.DeserializeObject<clsShortMessageEN>((string)jobjReturn["ReturnObj"]);
return objShortMessageEN;
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
public static clsShortMessageEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsShortMessageEN objShortMessageEN = null;
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
objShortMessageEN = JsonConvert.DeserializeObject<clsShortMessageEN>((string)jobjReturn["ReturnObj"]);
return objShortMessageEN;
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
 /// <param name = "lngShortMessageId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsShortMessageEN GetObjByShortMessageId_Cache(long lngShortMessageId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsShortMessageEN._CurrTabName_S);
List<clsShortMessageEN> arrShortMessageObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsShortMessageEN> arrShortMessageObjLst_Sel =
from objShortMessageEN in arrShortMessageObjLst_Cache
where objShortMessageEN.ShortMessageId == lngShortMessageId
select objShortMessageEN;
if (arrShortMessageObjLst_Sel.Count() == 0)
{
   clsShortMessageEN obj = clsShortMessageWApi.GetObjByShortMessageId(lngShortMessageId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrShortMessageObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsShortMessageEN> GetObjLst(string strWhereCond)
{
 List<clsShortMessageEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsShortMessageEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsShortMessageEN> GetObjLstByShortMessageIdLst(List<long> arrShortMessageId)
{
 List<clsShortMessageEN> arrObjLst = null; 
string strAction = "GetObjLstByShortMessageIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrShortMessageId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsShortMessageEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngShortMessageId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsShortMessageEN> GetObjLstByShortMessageIdLst_Cache(List<long> arrShortMessageId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsShortMessageEN._CurrTabName_S);
List<clsShortMessageEN> arrShortMessageObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsShortMessageEN> arrShortMessageObjLst_Sel =
from objShortMessageEN in arrShortMessageObjLst_Cache
where arrShortMessageId.Contains(objShortMessageEN.ShortMessageId)
select objShortMessageEN;
return arrShortMessageObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsShortMessageEN> GetObjLstByShortMessageIdLst_WA_Cache(List<long> arrShortMessageId)
{
 List<clsShortMessageEN> arrObjLst = null; 
string strAction = "GetObjLstByShortMessageIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrShortMessageId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsShortMessageEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsShortMessageEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsShortMessageEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsShortMessageEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsShortMessageEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsShortMessageEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsShortMessageEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsShortMessageEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsShortMessageEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsShortMessageEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsShortMessageEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsShortMessageEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsShortMessageEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngShortMessageId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsShortMessageEN objShortMessageEN = clsShortMessageWApi.GetObjByShortMessageId(lngShortMessageId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngShortMessageId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsShortMessageWApi.ReFreshCache();
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
public static int DelShortMessages(List<string> arrShortMessageId)
{
string strAction = "DelShortMessages";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrShortMessageId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsShortMessageWApi.ReFreshCache();
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
public static int DelShortMessagesByCond(string strWhereCond)
{
string strAction = "DelShortMessagesByCond";
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
public static bool AddNewRecord(clsShortMessageEN objShortMessageEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsShortMessageEN>(objShortMessageEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsShortMessageWApi.ReFreshCache();
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objShortMessageEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsShortMessageEN objShortMessageEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsShortMessageEN>(objShortMessageEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsShortMessageWApi.ReFreshCache();
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsShortMessageEN objShortMessageEN)
{
if (string.IsNullOrEmpty(objShortMessageEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objShortMessageEN.ShortMessageId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsShortMessageEN>(objShortMessageEN);
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
 /// <param name = "objShortMessageEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsShortMessageEN objShortMessageEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objShortMessageEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objShortMessageEN.ShortMessageId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objShortMessageEN.ShortMessageId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsShortMessageEN>(objShortMessageEN);
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
public static bool IsExist(long lngShortMessageId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ShortMessageId"] = lngShortMessageId.ToString()
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
 /// <param name = "objShortMessageENS">源对象</param>
 /// <param name = "objShortMessageENT">目标对象</param>
 public static void CopyTo(clsShortMessageEN objShortMessageENS, clsShortMessageEN objShortMessageENT)
{
try
{
objShortMessageENT.ShortMessageId = objShortMessageENS.ShortMessageId; //短信消息Id
objShortMessageENT.MessageNumber = objShortMessageENS.MessageNumber; //消息编号
objShortMessageENT.SendMessageNumber = objShortMessageENS.SendMessageNumber; //发送消息编号
objShortMessageENT.Phone = objShortMessageENS.Phone; //手机号
objShortMessageENT.MessageContent = objShortMessageENS.MessageContent; //消息内容
objShortMessageENT.ShortMessageSendSateID = objShortMessageENS.ShortMessageSendSateID; //消息发送状态Id
objShortMessageENT.ReseiveState = objShortMessageENS.ReseiveState; //接收状态
objShortMessageENT.ReturnTime = objShortMessageENS.ReturnTime; //状态返回时间
objShortMessageENT.Memo = objShortMessageENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsShortMessageEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsShortMessageEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsShortMessageEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsShortMessageEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsShortMessageEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsShortMessageEN.AttributeName)
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
if (clsShortMessageWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsShortMessageWApi没有刷新缓存机制(clsShortMessageWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ShortMessageId");
//if (arrShortMessageObjLst_Cache == null)
//{
//arrShortMessageObjLst_Cache = await clsShortMessageWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsShortMessageEN._CurrTabName_S);
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
if (clsShortMessageWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsShortMessageEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsShortMessageWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsShortMessageEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsShortMessageEN._CurrTabName_S);
List<clsShortMessageEN> arrShortMessageObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrShortMessageObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsShortMessageEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conShortMessage.ShortMessageId, Type.GetType("System.Int64"));
objDT.Columns.Add(conShortMessage.MessageNumber, Type.GetType("System.String"));
objDT.Columns.Add(conShortMessage.SendMessageNumber, Type.GetType("System.String"));
objDT.Columns.Add(conShortMessage.Phone, Type.GetType("System.String"));
objDT.Columns.Add(conShortMessage.MessageContent, Type.GetType("System.String"));
objDT.Columns.Add(conShortMessage.ShortMessageSendSateID, Type.GetType("System.String"));
objDT.Columns.Add(conShortMessage.ReseiveState, Type.GetType("System.Boolean"));
objDT.Columns.Add(conShortMessage.ReturnTime, Type.GetType("System.String"));
objDT.Columns.Add(conShortMessage.Memo, Type.GetType("System.String"));
foreach (clsShortMessageEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conShortMessage.ShortMessageId] = objInFor[conShortMessage.ShortMessageId];
objDR[conShortMessage.MessageNumber] = objInFor[conShortMessage.MessageNumber];
objDR[conShortMessage.SendMessageNumber] = objInFor[conShortMessage.SendMessageNumber];
objDR[conShortMessage.Phone] = objInFor[conShortMessage.Phone];
objDR[conShortMessage.MessageContent] = objInFor[conShortMessage.MessageContent];
objDR[conShortMessage.ShortMessageSendSateID] = objInFor[conShortMessage.ShortMessageSendSateID];
objDR[conShortMessage.ReseiveState] = objInFor[conShortMessage.ReseiveState];
objDR[conShortMessage.ReturnTime] = objInFor[conShortMessage.ReturnTime];
objDR[conShortMessage.Memo] = objInFor[conShortMessage.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 短信消息(ShortMessage)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4ShortMessage : clsCommFun4BL
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
clsShortMessageWApi.ReFreshThisCache();
}
}

}