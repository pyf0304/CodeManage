
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLoginLogWApi
 表名:LoginLog(01120357)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:22
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日志管理
 模块英文名:LogManage
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
public static class clsLoginLogWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLoginLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsLoginLogEN SetLoginLogId(this clsLoginLogEN objLoginLogEN, long lngLoginLogId, string strComparisonOp="")
	{
objLoginLogEN.LoginLogId = lngLoginLogId; //LoginLogId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLoginLogEN.dicFldComparisonOp.ContainsKey(conLoginLog.LoginLogId) == false)
{
objLoginLogEN.dicFldComparisonOp.Add(conLoginLog.LoginLogId, strComparisonOp);
}
else
{
objLoginLogEN.dicFldComparisonOp[conLoginLog.LoginLogId] = strComparisonOp;
}
}
return objLoginLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLoginLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsLoginLogEN SetLoginLogNumber(this clsLoginLogEN objLoginLogEN, string strLoginLogNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLoginLogNumber, 500, conLoginLog.LoginLogNumber);
objLoginLogEN.LoginLogNumber = strLoginLogNumber; //LoginLogNumber
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLoginLogEN.dicFldComparisonOp.ContainsKey(conLoginLog.LoginLogNumber) == false)
{
objLoginLogEN.dicFldComparisonOp.Add(conLoginLog.LoginLogNumber, strComparisonOp);
}
else
{
objLoginLogEN.dicFldComparisonOp[conLoginLog.LoginLogNumber] = strComparisonOp;
}
}
return objLoginLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLoginLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsLoginLogEN SetLoginIP(this clsLoginLogEN objLoginLogEN, string strLoginIP, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLoginIP, 200, conLoginLog.LoginIP);
objLoginLogEN.LoginIP = strLoginIP; //LoginIP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLoginLogEN.dicFldComparisonOp.ContainsKey(conLoginLog.LoginIP) == false)
{
objLoginLogEN.dicFldComparisonOp.Add(conLoginLog.LoginIP, strComparisonOp);
}
else
{
objLoginLogEN.dicFldComparisonOp[conLoginLog.LoginIP] = strComparisonOp;
}
}
return objLoginLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLoginLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsLoginLogEN SetFailReason(this clsLoginLogEN objLoginLogEN, string strFailReason, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFailReason, 500, conLoginLog.FailReason);
objLoginLogEN.FailReason = strFailReason; //FailReason
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLoginLogEN.dicFldComparisonOp.ContainsKey(conLoginLog.FailReason) == false)
{
objLoginLogEN.dicFldComparisonOp.Add(conLoginLog.FailReason, strComparisonOp);
}
else
{
objLoginLogEN.dicFldComparisonOp[conLoginLog.FailReason] = strComparisonOp;
}
}
return objLoginLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLoginLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsLoginLogEN SetLoginResult(this clsLoginLogEN objLoginLogEN, string strLoginResult, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLoginResult, 500, conLoginLog.LoginResult);
objLoginLogEN.LoginResult = strLoginResult; //LoginResult
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLoginLogEN.dicFldComparisonOp.ContainsKey(conLoginLog.LoginResult) == false)
{
objLoginLogEN.dicFldComparisonOp.Add(conLoginLog.LoginResult, strComparisonOp);
}
else
{
objLoginLogEN.dicFldComparisonOp[conLoginLog.LoginResult] = strComparisonOp;
}
}
return objLoginLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLoginLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsLoginLogEN SetLoginTime(this clsLoginLogEN objLoginLogEN, string strLoginTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLoginTime, 20, conLoginLog.LoginTime);
objLoginLogEN.LoginTime = strLoginTime; //LoginTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLoginLogEN.dicFldComparisonOp.ContainsKey(conLoginLog.LoginTime) == false)
{
objLoginLogEN.dicFldComparisonOp.Add(conLoginLog.LoginTime, strComparisonOp);
}
else
{
objLoginLogEN.dicFldComparisonOp[conLoginLog.LoginTime] = strComparisonOp;
}
}
return objLoginLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLoginLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsLoginLogEN SetLoginUserId(this clsLoginLogEN objLoginLogEN, string strLoginUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLoginUserId, 200, conLoginLog.LoginUserId);
objLoginLogEN.LoginUserId = strLoginUserId; //LoginUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLoginLogEN.dicFldComparisonOp.ContainsKey(conLoginLog.LoginUserId) == false)
{
objLoginLogEN.dicFldComparisonOp.Add(conLoginLog.LoginUserId, strComparisonOp);
}
else
{
objLoginLogEN.dicFldComparisonOp[conLoginLog.LoginUserId] = strComparisonOp;
}
}
return objLoginLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLoginLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsLoginLogEN SetMemo(this clsLoginLogEN objLoginLogEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conLoginLog.Memo);
objLoginLogEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLoginLogEN.dicFldComparisonOp.ContainsKey(conLoginLog.Memo) == false)
{
objLoginLogEN.dicFldComparisonOp.Add(conLoginLog.Memo, strComparisonOp);
}
else
{
objLoginLogEN.dicFldComparisonOp[conLoginLog.Memo] = strComparisonOp;
}
}
return objLoginLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLoginLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsLoginLogEN SetOnlineTime(this clsLoginLogEN objLoginLogEN, string strOnlineTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOnlineTime, 200, conLoginLog.OnlineTime);
objLoginLogEN.OnlineTime = strOnlineTime; //OnlineTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLoginLogEN.dicFldComparisonOp.ContainsKey(conLoginLog.OnlineTime) == false)
{
objLoginLogEN.dicFldComparisonOp.Add(conLoginLog.OnlineTime, strComparisonOp);
}
else
{
objLoginLogEN.dicFldComparisonOp[conLoginLog.OnlineTime] = strComparisonOp;
}
}
return objLoginLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLoginLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsLoginLogEN SetOutTime(this clsLoginLogEN objLoginLogEN, string strOutTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOutTime, 20, conLoginLog.OutTime);
objLoginLogEN.OutTime = strOutTime; //OutTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLoginLogEN.dicFldComparisonOp.ContainsKey(conLoginLog.OutTime) == false)
{
objLoginLogEN.dicFldComparisonOp.Add(conLoginLog.OutTime, strComparisonOp);
}
else
{
objLoginLogEN.dicFldComparisonOp[conLoginLog.OutTime] = strComparisonOp;
}
}
return objLoginLogEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsLoginLogEN objLoginLog_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objLoginLog_Cond.IsUpdated(conLoginLog.LoginLogId) == true)
{
string strComparisonOp_LoginLogId = objLoginLog_Cond.dicFldComparisonOp[conLoginLog.LoginLogId];
strWhereCond += string.Format(" And {0} {2} {1}", conLoginLog.LoginLogId, objLoginLog_Cond.LoginLogId, strComparisonOp_LoginLogId);
}
if (objLoginLog_Cond.IsUpdated(conLoginLog.LoginLogNumber) == true)
{
string strComparisonOp_LoginLogNumber = objLoginLog_Cond.dicFldComparisonOp[conLoginLog.LoginLogNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLoginLog.LoginLogNumber, objLoginLog_Cond.LoginLogNumber, strComparisonOp_LoginLogNumber);
}
if (objLoginLog_Cond.IsUpdated(conLoginLog.LoginIP) == true)
{
string strComparisonOp_LoginIP = objLoginLog_Cond.dicFldComparisonOp[conLoginLog.LoginIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLoginLog.LoginIP, objLoginLog_Cond.LoginIP, strComparisonOp_LoginIP);
}
if (objLoginLog_Cond.IsUpdated(conLoginLog.FailReason) == true)
{
string strComparisonOp_FailReason = objLoginLog_Cond.dicFldComparisonOp[conLoginLog.FailReason];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLoginLog.FailReason, objLoginLog_Cond.FailReason, strComparisonOp_FailReason);
}
if (objLoginLog_Cond.IsUpdated(conLoginLog.LoginResult) == true)
{
string strComparisonOp_LoginResult = objLoginLog_Cond.dicFldComparisonOp[conLoginLog.LoginResult];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLoginLog.LoginResult, objLoginLog_Cond.LoginResult, strComparisonOp_LoginResult);
}
if (objLoginLog_Cond.IsUpdated(conLoginLog.LoginTime) == true)
{
string strComparisonOp_LoginTime = objLoginLog_Cond.dicFldComparisonOp[conLoginLog.LoginTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLoginLog.LoginTime, objLoginLog_Cond.LoginTime, strComparisonOp_LoginTime);
}
if (objLoginLog_Cond.IsUpdated(conLoginLog.LoginUserId) == true)
{
string strComparisonOp_LoginUserId = objLoginLog_Cond.dicFldComparisonOp[conLoginLog.LoginUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLoginLog.LoginUserId, objLoginLog_Cond.LoginUserId, strComparisonOp_LoginUserId);
}
if (objLoginLog_Cond.IsUpdated(conLoginLog.Memo) == true)
{
string strComparisonOp_Memo = objLoginLog_Cond.dicFldComparisonOp[conLoginLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLoginLog.Memo, objLoginLog_Cond.Memo, strComparisonOp_Memo);
}
if (objLoginLog_Cond.IsUpdated(conLoginLog.OnlineTime) == true)
{
string strComparisonOp_OnlineTime = objLoginLog_Cond.dicFldComparisonOp[conLoginLog.OnlineTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLoginLog.OnlineTime, objLoginLog_Cond.OnlineTime, strComparisonOp_OnlineTime);
}
if (objLoginLog_Cond.IsUpdated(conLoginLog.OutTime) == true)
{
string strComparisonOp_OutTime = objLoginLog_Cond.dicFldComparisonOp[conLoginLog.OutTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLoginLog.OutTime, objLoginLog_Cond.OutTime, strComparisonOp_OutTime);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objLoginLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsLoginLogEN objLoginLogEN)
{
 if (objLoginLogEN.LoginLogId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objLoginLogEN.sf_UpdFldSetStr = objLoginLogEN.getsf_UpdFldSetStr();
clsLoginLogWApi.CheckPropertyNew(objLoginLogEN); 
bool bolResult = clsLoginLogWApi.UpdateRecord(objLoginLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLoginLogWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--LoginLog(登录日志), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objLoginLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_LoginUserId_LoginIP_LoginTime(this clsLoginLogEN objLoginLogEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objLoginLogEN == null) return "";
if (objLoginLogEN.LoginLogId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and LoginUserId = '{0}'", objLoginLogEN.LoginUserId);
 sbCondition.AppendFormat(" and LoginIP = '{0}'", objLoginLogEN.LoginIP);
 sbCondition.AppendFormat(" and LoginTime = '{0}'", objLoginLogEN.LoginTime);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("LoginLogId !=  {0}", objLoginLogEN.LoginLogId);
 sbCondition.AppendFormat(" and LoginUserId = '{0}'", objLoginLogEN.LoginUserId);
 sbCondition.AppendFormat(" and LoginIP = '{0}'", objLoginLogEN.LoginIP);
 sbCondition.AppendFormat(" and LoginTime = '{0}'", objLoginLogEN.LoginTime);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objLoginLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsLoginLogEN objLoginLogEN)
{
try
{
clsLoginLogWApi.CheckPropertyNew(objLoginLogEN); 
bool bolResult = clsLoginLogWApi.AddNewRecord(objLoginLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLoginLogWApi.ReFreshCache();
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
 /// <param name = "objLoginLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsLoginLogEN objLoginLogEN, string strWhereCond)
{
try
{
clsLoginLogWApi.CheckPropertyNew(objLoginLogEN); 
bool bolResult = clsLoginLogWApi.UpdateWithCondition(objLoginLogEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLoginLogWApi.ReFreshCache();
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
 /// 登录日志(LoginLog)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsLoginLogWApi
{
private static readonly string mstrApiControllerName = "LoginLogApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsLoginLogWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsLoginLogEN objLoginLogEN)
{
if (!Object.Equals(null, objLoginLogEN.LoginLogNumber) && GetStrLen(objLoginLogEN.LoginLogNumber) > 500)
{
 throw new Exception("字段[LoginLogNumber]的长度不能超过500!");
}
if (!Object.Equals(null, objLoginLogEN.LoginIP) && GetStrLen(objLoginLogEN.LoginIP) > 200)
{
 throw new Exception("字段[LoginIP]的长度不能超过200!");
}
if (!Object.Equals(null, objLoginLogEN.FailReason) && GetStrLen(objLoginLogEN.FailReason) > 500)
{
 throw new Exception("字段[FailReason]的长度不能超过500!");
}
if (!Object.Equals(null, objLoginLogEN.LoginResult) && GetStrLen(objLoginLogEN.LoginResult) > 500)
{
 throw new Exception("字段[LoginResult]的长度不能超过500!");
}
if (!Object.Equals(null, objLoginLogEN.LoginTime) && GetStrLen(objLoginLogEN.LoginTime) > 20)
{
 throw new Exception("字段[LoginTime]的长度不能超过20!");
}
if (!Object.Equals(null, objLoginLogEN.LoginUserId) && GetStrLen(objLoginLogEN.LoginUserId) > 200)
{
 throw new Exception("字段[LoginUserId]的长度不能超过200!");
}
if (!Object.Equals(null, objLoginLogEN.Memo) && GetStrLen(objLoginLogEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objLoginLogEN.OnlineTime) && GetStrLen(objLoginLogEN.OnlineTime) > 200)
{
 throw new Exception("字段[OnlineTime]的长度不能超过200!");
}
if (!Object.Equals(null, objLoginLogEN.OutTime) && GetStrLen(objLoginLogEN.OutTime) > 20)
{
 throw new Exception("字段[OutTime]的长度不能超过20!");
}
 objLoginLogEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngLoginLogId">表关键字</param>
 /// <returns>表对象</returns>
public static clsLoginLogEN GetObjByLoginLogId(long lngLoginLogId)
{
string strAction = "GetObjByLoginLogId";
string strErrMsg = string.Empty;
string strResult = "";
clsLoginLogEN objLoginLogEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["LoginLogId"] = lngLoginLogId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objLoginLogEN = JsonConvert.DeserializeObject<clsLoginLogEN>((string)jobjReturn["ReturnObj"]);
return objLoginLogEN;
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
 /// <param name = "lngLoginLogId">表关键字</param>
 /// <returns>表对象</returns>
public static clsLoginLogEN GetObjByLoginLogId_WA_Cache(long lngLoginLogId)
{
string strAction = "GetObjByLoginLogId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsLoginLogEN objLoginLogEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["LoginLogId"] = lngLoginLogId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objLoginLogEN = JsonConvert.DeserializeObject<clsLoginLogEN>((string)jobjReturn["ReturnObj"]);
return objLoginLogEN;
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
public static clsLoginLogEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsLoginLogEN objLoginLogEN = null;
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
objLoginLogEN = JsonConvert.DeserializeObject<clsLoginLogEN>((string)jobjReturn["ReturnObj"]);
return objLoginLogEN;
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
 /// <param name = "lngLoginLogId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsLoginLogEN GetObjByLoginLogId_Cache(long lngLoginLogId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsLoginLogEN._CurrTabName_S);
List<clsLoginLogEN> arrLoginLogObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsLoginLogEN> arrLoginLogObjLst_Sel =
from objLoginLogEN in arrLoginLogObjLst_Cache
where objLoginLogEN.LoginLogId == lngLoginLogId
select objLoginLogEN;
if (arrLoginLogObjLst_Sel.Count() == 0)
{
   clsLoginLogEN obj = clsLoginLogWApi.GetObjByLoginLogId(lngLoginLogId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrLoginLogObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsLoginLogEN> GetObjLst(string strWhereCond)
{
 List<clsLoginLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsLoginLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsLoginLogEN> GetObjLstByLoginLogIdLst(List<long> arrLoginLogId)
{
 List<clsLoginLogEN> arrObjLst = null; 
string strAction = "GetObjLstByLoginLogIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrLoginLogId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsLoginLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngLoginLogId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsLoginLogEN> GetObjLstByLoginLogIdLst_Cache(List<long> arrLoginLogId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsLoginLogEN._CurrTabName_S);
List<clsLoginLogEN> arrLoginLogObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsLoginLogEN> arrLoginLogObjLst_Sel =
from objLoginLogEN in arrLoginLogObjLst_Cache
where arrLoginLogId.Contains(objLoginLogEN.LoginLogId)
select objLoginLogEN;
return arrLoginLogObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsLoginLogEN> GetObjLstByLoginLogIdLst_WA_Cache(List<long> arrLoginLogId)
{
 List<clsLoginLogEN> arrObjLst = null; 
string strAction = "GetObjLstByLoginLogIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrLoginLogId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsLoginLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsLoginLogEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsLoginLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsLoginLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsLoginLogEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsLoginLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsLoginLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsLoginLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsLoginLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsLoginLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsLoginLogEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsLoginLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsLoginLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngLoginLogId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsLoginLogEN objLoginLogEN = clsLoginLogWApi.GetObjByLoginLogId(lngLoginLogId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngLoginLogId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsLoginLogWApi.ReFreshCache();
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
public static int DelLoginLogs(List<string> arrLoginLogId)
{
string strAction = "DelLoginLogs";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrLoginLogId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsLoginLogWApi.ReFreshCache();
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
public static int DelLoginLogsByCond(string strWhereCond)
{
string strAction = "DelLoginLogsByCond";
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
public static bool AddNewRecord(clsLoginLogEN objLoginLogEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsLoginLogEN>(objLoginLogEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLoginLogWApi.ReFreshCache();
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
 /// <param name = "objLoginLogEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsLoginLogEN objLoginLogEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsLoginLogEN>(objLoginLogEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLoginLogWApi.ReFreshCache();
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
public static bool UpdateRecord(clsLoginLogEN objLoginLogEN)
{
if (string.IsNullOrEmpty(objLoginLogEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objLoginLogEN.LoginLogId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsLoginLogEN>(objLoginLogEN);
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
 /// <param name = "objLoginLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsLoginLogEN objLoginLogEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objLoginLogEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objLoginLogEN.LoginLogId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objLoginLogEN.LoginLogId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsLoginLogEN>(objLoginLogEN);
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
public static bool IsExist(long lngLoginLogId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["LoginLogId"] = lngLoginLogId.ToString()
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
 /// <param name = "objLoginLogENS">源对象</param>
 /// <param name = "objLoginLogENT">目标对象</param>
 public static void CopyTo(clsLoginLogEN objLoginLogENS, clsLoginLogEN objLoginLogENT)
{
try
{
objLoginLogENT.LoginLogId = objLoginLogENS.LoginLogId; //LoginLogId
objLoginLogENT.LoginLogNumber = objLoginLogENS.LoginLogNumber; //LoginLogNumber
objLoginLogENT.LoginIP = objLoginLogENS.LoginIP; //LoginIP
objLoginLogENT.FailReason = objLoginLogENS.FailReason; //FailReason
objLoginLogENT.LoginResult = objLoginLogENS.LoginResult; //LoginResult
objLoginLogENT.LoginTime = objLoginLogENS.LoginTime; //LoginTime
objLoginLogENT.LoginUserId = objLoginLogENS.LoginUserId; //LoginUserId
objLoginLogENT.Memo = objLoginLogENS.Memo; //备注
objLoginLogENT.OnlineTime = objLoginLogENS.OnlineTime; //OnlineTime
objLoginLogENT.OutTime = objLoginLogENS.OutTime; //OutTime
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
public static DataTable ToDataTable(List<clsLoginLogEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsLoginLogEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsLoginLogEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsLoginLogEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsLoginLogEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsLoginLogEN.AttributeName)
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
if (clsLoginLogWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsLoginLogWApi没有刷新缓存机制(clsLoginLogWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by LoginLogId");
//if (arrLoginLogObjLst_Cache == null)
//{
//arrLoginLogObjLst_Cache = await clsLoginLogWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsLoginLogEN._CurrTabName_S);
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
if (clsLoginLogWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsLoginLogEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsLoginLogWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsLoginLogEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsLoginLogEN._CurrTabName_S);
List<clsLoginLogEN> arrLoginLogObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrLoginLogObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsLoginLogEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conLoginLog.LoginLogId, Type.GetType("System.Int64"));
objDT.Columns.Add(conLoginLog.LoginLogNumber, Type.GetType("System.String"));
objDT.Columns.Add(conLoginLog.LoginIP, Type.GetType("System.String"));
objDT.Columns.Add(conLoginLog.FailReason, Type.GetType("System.String"));
objDT.Columns.Add(conLoginLog.LoginResult, Type.GetType("System.String"));
objDT.Columns.Add(conLoginLog.LoginTime, Type.GetType("System.String"));
objDT.Columns.Add(conLoginLog.LoginUserId, Type.GetType("System.String"));
objDT.Columns.Add(conLoginLog.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conLoginLog.OnlineTime, Type.GetType("System.String"));
objDT.Columns.Add(conLoginLog.OutTime, Type.GetType("System.String"));
foreach (clsLoginLogEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conLoginLog.LoginLogId] = objInFor[conLoginLog.LoginLogId];
objDR[conLoginLog.LoginLogNumber] = objInFor[conLoginLog.LoginLogNumber];
objDR[conLoginLog.LoginIP] = objInFor[conLoginLog.LoginIP];
objDR[conLoginLog.FailReason] = objInFor[conLoginLog.FailReason];
objDR[conLoginLog.LoginResult] = objInFor[conLoginLog.LoginResult];
objDR[conLoginLog.LoginTime] = objInFor[conLoginLog.LoginTime];
objDR[conLoginLog.LoginUserId] = objInFor[conLoginLog.LoginUserId];
objDR[conLoginLog.Memo] = objInFor[conLoginLog.Memo];
objDR[conLoginLog.OnlineTime] = objInFor[conLoginLog.OnlineTime];
objDR[conLoginLog.OutTime] = objInFor[conLoginLog.OutTime];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 登录日志(LoginLog)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4LoginLog : clsCommFun4BL
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
clsLoginLogWApi.ReFreshThisCache();
}
}

}