
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvShortMessageWApi
 表名:vShortMessage(01120288)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:29
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
public static class clsvShortMessageWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvShortMessageEN SetMessageNumber(this clsvShortMessageEN objvShortMessageEN, string strMessageNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMessageNumber, 200, convShortMessage.MessageNumber);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvShortMessageEN SetSendMessageNumber(this clsvShortMessageEN objvShortMessageEN, string strSendMessageNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSendMessageNumber, 200, convShortMessage.SendMessageNumber);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvShortMessageEN SetShortMessageSendSateName(this clsvShortMessageEN objvShortMessageEN, string strShortMessageSendSateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strShortMessageSendSateName, 200, convShortMessage.ShortMessageSendSateName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvShortMessageEN SetPhone(this clsvShortMessageEN objvShortMessageEN, string strPhone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPhone, 200, convShortMessage.Phone);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvShortMessageEN SetMessageContent(this clsvShortMessageEN objvShortMessageEN, string strMessageContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMessageContent, 2000, convShortMessage.MessageContent);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvShortMessageEN SetShortMessageSendSateID(this clsvShortMessageEN objvShortMessageEN, string strShortMessageSendSateID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strShortMessageSendSateID, convShortMessage.ShortMessageSendSateID);
clsCheckSql.CheckFieldLen(strShortMessageSendSateID, 8, convShortMessage.ShortMessageSendSateID);
clsCheckSql.CheckFieldForeignKey(strShortMessageSendSateID, 8, convShortMessage.ShortMessageSendSateID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvShortMessageEN SetReturnTime(this clsvShortMessageEN objvShortMessageEN, string strReturnTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnTime, 20, convShortMessage.ReturnTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvShortMessageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvShortMessageEN SetMemo(this clsvShortMessageEN objvShortMessageEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convShortMessage.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvShortMessageEN objvShortMessage_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvShortMessage_Cond.IsUpdated(convShortMessage.ShortMessageId) == true)
{
string strComparisonOp_ShortMessageId = objvShortMessage_Cond.dicFldComparisonOp[convShortMessage.ShortMessageId];
strWhereCond += string.Format(" And {0} {2} {1}", convShortMessage.ShortMessageId, objvShortMessage_Cond.ShortMessageId, strComparisonOp_ShortMessageId);
}
if (objvShortMessage_Cond.IsUpdated(convShortMessage.MessageNumber) == true)
{
string strComparisonOp_MessageNumber = objvShortMessage_Cond.dicFldComparisonOp[convShortMessage.MessageNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convShortMessage.MessageNumber, objvShortMessage_Cond.MessageNumber, strComparisonOp_MessageNumber);
}
if (objvShortMessage_Cond.IsUpdated(convShortMessage.SendMessageNumber) == true)
{
string strComparisonOp_SendMessageNumber = objvShortMessage_Cond.dicFldComparisonOp[convShortMessage.SendMessageNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convShortMessage.SendMessageNumber, objvShortMessage_Cond.SendMessageNumber, strComparisonOp_SendMessageNumber);
}
if (objvShortMessage_Cond.IsUpdated(convShortMessage.ShortMessageSendSateName) == true)
{
string strComparisonOp_ShortMessageSendSateName = objvShortMessage_Cond.dicFldComparisonOp[convShortMessage.ShortMessageSendSateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convShortMessage.ShortMessageSendSateName, objvShortMessage_Cond.ShortMessageSendSateName, strComparisonOp_ShortMessageSendSateName);
}
if (objvShortMessage_Cond.IsUpdated(convShortMessage.Phone) == true)
{
string strComparisonOp_Phone = objvShortMessage_Cond.dicFldComparisonOp[convShortMessage.Phone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convShortMessage.Phone, objvShortMessage_Cond.Phone, strComparisonOp_Phone);
}
if (objvShortMessage_Cond.IsUpdated(convShortMessage.MessageContent) == true)
{
string strComparisonOp_MessageContent = objvShortMessage_Cond.dicFldComparisonOp[convShortMessage.MessageContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convShortMessage.MessageContent, objvShortMessage_Cond.MessageContent, strComparisonOp_MessageContent);
}
if (objvShortMessage_Cond.IsUpdated(convShortMessage.ShortMessageSendSateID) == true)
{
string strComparisonOp_ShortMessageSendSateID = objvShortMessage_Cond.dicFldComparisonOp[convShortMessage.ShortMessageSendSateID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convShortMessage.ShortMessageSendSateID, objvShortMessage_Cond.ShortMessageSendSateID, strComparisonOp_ShortMessageSendSateID);
}
if (objvShortMessage_Cond.IsUpdated(convShortMessage.ReseiveState) == true)
{
if (objvShortMessage_Cond.ReseiveState == true)
{
strWhereCond += string.Format(" And {0} = '1'", convShortMessage.ReseiveState);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convShortMessage.ReseiveState);
}
}
if (objvShortMessage_Cond.IsUpdated(convShortMessage.ReturnTime) == true)
{
string strComparisonOp_ReturnTime = objvShortMessage_Cond.dicFldComparisonOp[convShortMessage.ReturnTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convShortMessage.ReturnTime, objvShortMessage_Cond.ReturnTime, strComparisonOp_ReturnTime);
}
if (objvShortMessage_Cond.IsUpdated(convShortMessage.Memo) == true)
{
string strComparisonOp_Memo = objvShortMessage_Cond.dicFldComparisonOp[convShortMessage.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convShortMessage.Memo, objvShortMessage_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// 短信消息视图(vShortMessage)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvShortMessageWApi
{
private static readonly string mstrApiControllerName = "vShortMessageApi";

 public clsvShortMessageWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngShortMessageId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvShortMessageEN GetObjByShortMessageId(long lngShortMessageId)
{
string strAction = "GetObjByShortMessageId";
string strErrMsg = string.Empty;
string strResult = "";
clsvShortMessageEN objvShortMessageEN = null;
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
objvShortMessageEN = JsonConvert.DeserializeObject<clsvShortMessageEN>((string)jobjReturn["ReturnObj"]);
return objvShortMessageEN;
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
public static clsvShortMessageEN GetObjByShortMessageId_WA_Cache(long lngShortMessageId)
{
string strAction = "GetObjByShortMessageId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvShortMessageEN objvShortMessageEN = null;
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
objvShortMessageEN = JsonConvert.DeserializeObject<clsvShortMessageEN>((string)jobjReturn["ReturnObj"]);
return objvShortMessageEN;
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
public static clsvShortMessageEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvShortMessageEN objvShortMessageEN = null;
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
objvShortMessageEN = JsonConvert.DeserializeObject<clsvShortMessageEN>((string)jobjReturn["ReturnObj"]);
return objvShortMessageEN;
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
public static clsvShortMessageEN GetObjByShortMessageId_Cache(long lngShortMessageId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvShortMessageEN._CurrTabName_S);
List<clsvShortMessageEN> arrvShortMessageObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvShortMessageEN> arrvShortMessageObjLst_Sel =
from objvShortMessageEN in arrvShortMessageObjLst_Cache
where objvShortMessageEN.ShortMessageId == lngShortMessageId
select objvShortMessageEN;
if (arrvShortMessageObjLst_Sel.Count() == 0)
{
   clsvShortMessageEN obj = clsvShortMessageWApi.GetObjByShortMessageId(lngShortMessageId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvShortMessageObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvShortMessageEN> GetObjLst(string strWhereCond)
{
 List<clsvShortMessageEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvShortMessageEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvShortMessageEN> GetObjLstByShortMessageIdLst(List<long> arrShortMessageId)
{
 List<clsvShortMessageEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvShortMessageEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvShortMessageEN> GetObjLstByShortMessageIdLst_Cache(List<long> arrShortMessageId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvShortMessageEN._CurrTabName_S);
List<clsvShortMessageEN> arrvShortMessageObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvShortMessageEN> arrvShortMessageObjLst_Sel =
from objvShortMessageEN in arrvShortMessageObjLst_Cache
where arrShortMessageId.Contains(objvShortMessageEN.ShortMessageId)
select objvShortMessageEN;
return arrvShortMessageObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvShortMessageEN> GetObjLstByShortMessageIdLst_WA_Cache(List<long> arrShortMessageId)
{
 List<clsvShortMessageEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvShortMessageEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvShortMessageEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvShortMessageEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvShortMessageEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvShortMessageEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvShortMessageEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvShortMessageEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvShortMessageEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvShortMessageEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvShortMessageEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvShortMessageEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvShortMessageEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvShortMessageEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
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
public static DataTable ToDataTable(List<clsvShortMessageEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvShortMessageEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvShortMessageEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvShortMessageEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvShortMessageEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvShortMessageEN.AttributeName)
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
if (clsShortMessageSendSateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsShortMessageSendSateWApi没有刷新缓存机制(clsShortMessageSendSateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ShortMessageId");
//if (arrvShortMessageObjLst_Cache == null)
//{
//arrvShortMessageObjLst_Cache = await clsvShortMessageWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvShortMessageEN._CurrTabName_S);
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
public static List<clsvShortMessageEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvShortMessageEN._CurrTabName_S);
List<clsvShortMessageEN> arrvShortMessageObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvShortMessageObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvShortMessageEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convShortMessage.ShortMessageId, Type.GetType("System.Int64"));
objDT.Columns.Add(convShortMessage.MessageNumber, Type.GetType("System.String"));
objDT.Columns.Add(convShortMessage.SendMessageNumber, Type.GetType("System.String"));
objDT.Columns.Add(convShortMessage.ShortMessageSendSateName, Type.GetType("System.String"));
objDT.Columns.Add(convShortMessage.Phone, Type.GetType("System.String"));
objDT.Columns.Add(convShortMessage.MessageContent, Type.GetType("System.String"));
objDT.Columns.Add(convShortMessage.ShortMessageSendSateID, Type.GetType("System.String"));
objDT.Columns.Add(convShortMessage.ReseiveState, Type.GetType("System.Boolean"));
objDT.Columns.Add(convShortMessage.ReturnTime, Type.GetType("System.String"));
objDT.Columns.Add(convShortMessage.Memo, Type.GetType("System.String"));
foreach (clsvShortMessageEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convShortMessage.ShortMessageId] = objInFor[convShortMessage.ShortMessageId];
objDR[convShortMessage.MessageNumber] = objInFor[convShortMessage.MessageNumber];
objDR[convShortMessage.SendMessageNumber] = objInFor[convShortMessage.SendMessageNumber];
objDR[convShortMessage.ShortMessageSendSateName] = objInFor[convShortMessage.ShortMessageSendSateName];
objDR[convShortMessage.Phone] = objInFor[convShortMessage.Phone];
objDR[convShortMessage.MessageContent] = objInFor[convShortMessage.MessageContent];
objDR[convShortMessage.ShortMessageSendSateID] = objInFor[convShortMessage.ShortMessageSendSateID];
objDR[convShortMessage.ReseiveState] = objInFor[convShortMessage.ReseiveState];
objDR[convShortMessage.ReturnTime] = objInFor[convShortMessage.ReturnTime];
objDR[convShortMessage.Memo] = objInFor[convShortMessage.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}