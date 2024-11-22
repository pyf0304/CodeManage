﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewpointLikeLogBL
 表名:vViewpointLikeLog(01120608)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:46
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
public static class  clsvViewpointLikeLogBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngViewpointLikeLogId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewpointLikeLogEN GetObj(this K_ViewpointLikeLogId_vViewpointLikeLog myKey)
{
clsvViewpointLikeLogEN objvViewpointLikeLogEN = clsvViewpointLikeLogBL.vViewpointLikeLogDA.GetObjByViewpointLikeLogId(myKey.Value);
return objvViewpointLikeLogEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointLikeLogEN SetMemo(this clsvViewpointLikeLogEN objvViewpointLikeLogEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convViewpointLikeLog.Memo);
}
objvViewpointLikeLogEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convViewpointLikeLog.Memo) == false)
{
objvViewpointLikeLogEN.dicFldComparisonOp.Add(convViewpointLikeLog.Memo, strComparisonOp);
}
else
{
objvViewpointLikeLogEN.dicFldComparisonOp[convViewpointLikeLog.Memo] = strComparisonOp;
}
}
return objvViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointLikeLogEN SetUpdUserId(this clsvViewpointLikeLogEN objvViewpointLikeLogEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convViewpointLikeLog.UpdUserId);
}
objvViewpointLikeLogEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convViewpointLikeLog.UpdUserId) == false)
{
objvViewpointLikeLogEN.dicFldComparisonOp.Add(convViewpointLikeLog.UpdUserId, strComparisonOp);
}
else
{
objvViewpointLikeLogEN.dicFldComparisonOp[convViewpointLikeLog.UpdUserId] = strComparisonOp;
}
}
return objvViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointLikeLogEN SetUpdDate(this clsvViewpointLikeLogEN objvViewpointLikeLogEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewpointLikeLog.UpdDate);
}
objvViewpointLikeLogEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convViewpointLikeLog.UpdDate) == false)
{
objvViewpointLikeLogEN.dicFldComparisonOp.Add(convViewpointLikeLog.UpdDate, strComparisonOp);
}
else
{
objvViewpointLikeLogEN.dicFldComparisonOp[convViewpointLikeLog.UpdDate] = strComparisonOp;
}
}
return objvViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointLikeLogEN SetViewpointId(this clsvViewpointLikeLogEN objvViewpointLikeLogEN, string strViewpointId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointId, 8, convViewpointLikeLog.ViewpointId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewpointId, 8, convViewpointLikeLog.ViewpointId);
}
objvViewpointLikeLogEN.ViewpointId = strViewpointId; //观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convViewpointLikeLog.ViewpointId) == false)
{
objvViewpointLikeLogEN.dicFldComparisonOp.Add(convViewpointLikeLog.ViewpointId, strComparisonOp);
}
else
{
objvViewpointLikeLogEN.dicFldComparisonOp[convViewpointLikeLog.ViewpointId] = strComparisonOp;
}
}
return objvViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointLikeLogEN SetViewpointLikeLogId(this clsvViewpointLikeLogEN objvViewpointLikeLogEN, long lngViewpointLikeLogId, string strComparisonOp="")
	{
objvViewpointLikeLogEN.ViewpointLikeLogId = lngViewpointLikeLogId; //观点点赞Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convViewpointLikeLog.ViewpointLikeLogId) == false)
{
objvViewpointLikeLogEN.dicFldComparisonOp.Add(convViewpointLikeLog.ViewpointLikeLogId, strComparisonOp);
}
else
{
objvViewpointLikeLogEN.dicFldComparisonOp[convViewpointLikeLog.ViewpointLikeLogId] = strComparisonOp;
}
}
return objvViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointLikeLogEN SetViewpointName(this clsvViewpointLikeLogEN objvViewpointLikeLogEN, string strViewpointName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointName, 500, convViewpointLikeLog.ViewpointName);
}
objvViewpointLikeLogEN.ViewpointName = strViewpointName; //观点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convViewpointLikeLog.ViewpointName) == false)
{
objvViewpointLikeLogEN.dicFldComparisonOp.Add(convViewpointLikeLog.ViewpointName, strComparisonOp);
}
else
{
objvViewpointLikeLogEN.dicFldComparisonOp[convViewpointLikeLog.ViewpointName] = strComparisonOp;
}
}
return objvViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointLikeLogEN SetViewpointContent(this clsvViewpointLikeLogEN objvViewpointLikeLogEN, string strViewpointContent, string strComparisonOp="")
	{
objvViewpointLikeLogEN.ViewpointContent = strViewpointContent; //观点内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convViewpointLikeLog.ViewpointContent) == false)
{
objvViewpointLikeLogEN.dicFldComparisonOp.Add(convViewpointLikeLog.ViewpointContent, strComparisonOp);
}
else
{
objvViewpointLikeLogEN.dicFldComparisonOp[convViewpointLikeLog.ViewpointContent] = strComparisonOp;
}
}
return objvViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointLikeLogEN SetReason(this clsvViewpointLikeLogEN objvViewpointLikeLogEN, string strReason, string strComparisonOp="")
	{
objvViewpointLikeLogEN.Reason = strReason; //理由
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convViewpointLikeLog.Reason) == false)
{
objvViewpointLikeLogEN.dicFldComparisonOp.Add(convViewpointLikeLog.Reason, strComparisonOp);
}
else
{
objvViewpointLikeLogEN.dicFldComparisonOp[convViewpointLikeLog.Reason] = strComparisonOp;
}
}
return objvViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointLikeLogEN SetUserName(this clsvViewpointLikeLogEN objvViewpointLikeLogEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convViewpointLikeLog.UserName);
}
objvViewpointLikeLogEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convViewpointLikeLog.UserName) == false)
{
objvViewpointLikeLogEN.dicFldComparisonOp.Add(convViewpointLikeLog.UserName, strComparisonOp);
}
else
{
objvViewpointLikeLogEN.dicFldComparisonOp[convViewpointLikeLog.UserName] = strComparisonOp;
}
}
return objvViewpointLikeLogEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvViewpointLikeLogENS">源对象</param>
 /// <param name = "objvViewpointLikeLogENT">目标对象</param>
 public static void CopyTo(this clsvViewpointLikeLogEN objvViewpointLikeLogENS, clsvViewpointLikeLogEN objvViewpointLikeLogENT)
{
try
{
objvViewpointLikeLogENT.Memo = objvViewpointLikeLogENS.Memo; //备注
objvViewpointLikeLogENT.UpdUserId = objvViewpointLikeLogENS.UpdUserId; //修改用户Id
objvViewpointLikeLogENT.UpdDate = objvViewpointLikeLogENS.UpdDate; //修改日期
objvViewpointLikeLogENT.ViewpointId = objvViewpointLikeLogENS.ViewpointId; //观点Id
objvViewpointLikeLogENT.ViewpointLikeLogId = objvViewpointLikeLogENS.ViewpointLikeLogId; //观点点赞Id
objvViewpointLikeLogENT.ViewpointName = objvViewpointLikeLogENS.ViewpointName; //观点名称
objvViewpointLikeLogENT.ViewpointContent = objvViewpointLikeLogENS.ViewpointContent; //观点内容
objvViewpointLikeLogENT.Reason = objvViewpointLikeLogENS.Reason; //理由
objvViewpointLikeLogENT.UserName = objvViewpointLikeLogENS.UserName; //用户名
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
 /// <param name = "objvViewpointLikeLogENS">源对象</param>
 /// <returns>目标对象=>clsvViewpointLikeLogEN:objvViewpointLikeLogENT</returns>
 public static clsvViewpointLikeLogEN CopyTo(this clsvViewpointLikeLogEN objvViewpointLikeLogENS)
{
try
{
 clsvViewpointLikeLogEN objvViewpointLikeLogENT = new clsvViewpointLikeLogEN()
{
Memo = objvViewpointLikeLogENS.Memo, //备注
UpdUserId = objvViewpointLikeLogENS.UpdUserId, //修改用户Id
UpdDate = objvViewpointLikeLogENS.UpdDate, //修改日期
ViewpointId = objvViewpointLikeLogENS.ViewpointId, //观点Id
ViewpointLikeLogId = objvViewpointLikeLogENS.ViewpointLikeLogId, //观点点赞Id
ViewpointName = objvViewpointLikeLogENS.ViewpointName, //观点名称
ViewpointContent = objvViewpointLikeLogENS.ViewpointContent, //观点内容
Reason = objvViewpointLikeLogENS.Reason, //理由
UserName = objvViewpointLikeLogENS.UserName, //用户名
};
 return objvViewpointLikeLogENT;
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
public static void CheckProperty4Condition(this clsvViewpointLikeLogEN objvViewpointLikeLogEN)
{
 clsvViewpointLikeLogBL.vViewpointLikeLogDA.CheckProperty4Condition(objvViewpointLikeLogEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvViewpointLikeLogEN objvViewpointLikeLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvViewpointLikeLogCond.IsUpdated(convViewpointLikeLog.Memo) == true)
{
string strComparisonOpMemo = objvViewpointLikeLogCond.dicFldComparisonOp[convViewpointLikeLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointLikeLog.Memo, objvViewpointLikeLogCond.Memo, strComparisonOpMemo);
}
if (objvViewpointLikeLogCond.IsUpdated(convViewpointLikeLog.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvViewpointLikeLogCond.dicFldComparisonOp[convViewpointLikeLog.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointLikeLog.UpdUserId, objvViewpointLikeLogCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvViewpointLikeLogCond.IsUpdated(convViewpointLikeLog.UpdDate) == true)
{
string strComparisonOpUpdDate = objvViewpointLikeLogCond.dicFldComparisonOp[convViewpointLikeLog.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointLikeLog.UpdDate, objvViewpointLikeLogCond.UpdDate, strComparisonOpUpdDate);
}
if (objvViewpointLikeLogCond.IsUpdated(convViewpointLikeLog.ViewpointId) == true)
{
string strComparisonOpViewpointId = objvViewpointLikeLogCond.dicFldComparisonOp[convViewpointLikeLog.ViewpointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointLikeLog.ViewpointId, objvViewpointLikeLogCond.ViewpointId, strComparisonOpViewpointId);
}
if (objvViewpointLikeLogCond.IsUpdated(convViewpointLikeLog.ViewpointLikeLogId) == true)
{
string strComparisonOpViewpointLikeLogId = objvViewpointLikeLogCond.dicFldComparisonOp[convViewpointLikeLog.ViewpointLikeLogId];
strWhereCond += string.Format(" And {0} {2} {1}", convViewpointLikeLog.ViewpointLikeLogId, objvViewpointLikeLogCond.ViewpointLikeLogId, strComparisonOpViewpointLikeLogId);
}
if (objvViewpointLikeLogCond.IsUpdated(convViewpointLikeLog.ViewpointName) == true)
{
string strComparisonOpViewpointName = objvViewpointLikeLogCond.dicFldComparisonOp[convViewpointLikeLog.ViewpointName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointLikeLog.ViewpointName, objvViewpointLikeLogCond.ViewpointName, strComparisonOpViewpointName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvViewpointLikeLogCond.IsUpdated(convViewpointLikeLog.UserName) == true)
{
string strComparisonOpUserName = objvViewpointLikeLogCond.dicFldComparisonOp[convViewpointLikeLog.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointLikeLog.UserName, objvViewpointLikeLogCond.UserName, strComparisonOpUserName);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vViewpointLikeLog(vViewpointLikeLog), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ViewpointLikeLogId_ViewpointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvViewpointLikeLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvViewpointLikeLogEN objvViewpointLikeLogEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvViewpointLikeLogEN == null) return true;
if (objvViewpointLikeLogEN.ViewpointLikeLogId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewpointLikeLogId = '{0}'", objvViewpointLikeLogEN.ViewpointLikeLogId);
 if (objvViewpointLikeLogEN.ViewpointId == null)
{
 sbCondition.AppendFormat(" and ViewpointId is null", objvViewpointLikeLogEN.ViewpointId);
}
else
{
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objvViewpointLikeLogEN.ViewpointId);
}
if (clsvViewpointLikeLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ViewpointLikeLogId !=  {0}", objvViewpointLikeLogEN.ViewpointLikeLogId);
 sbCondition.AppendFormat(" and ViewpointLikeLogId = '{0}'", objvViewpointLikeLogEN.ViewpointLikeLogId);
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objvViewpointLikeLogEN.ViewpointId);
if (clsvViewpointLikeLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取唯一性条件串--vViewpointLikeLog(vViewpointLikeLog), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ViewpointLikeLogId_ViewpointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvViewpointLikeLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvViewpointLikeLogEN objvViewpointLikeLogEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvViewpointLikeLogEN == null) return "";
if (objvViewpointLikeLogEN.ViewpointLikeLogId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewpointLikeLogId = '{0}'", objvViewpointLikeLogEN.ViewpointLikeLogId);
 if (objvViewpointLikeLogEN.ViewpointId == null)
{
 sbCondition.AppendFormat(" and ViewpointId is null", objvViewpointLikeLogEN.ViewpointId);
}
else
{
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objvViewpointLikeLogEN.ViewpointId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ViewpointLikeLogId !=  {0}", objvViewpointLikeLogEN.ViewpointLikeLogId);
 sbCondition.AppendFormat(" and ViewpointLikeLogId = '{0}'", objvViewpointLikeLogEN.ViewpointLikeLogId);
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objvViewpointLikeLogEN.ViewpointId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vViewpointLikeLog
{
public virtual bool UpdRelaTabDate(long lngViewpointLikeLogId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vViewpointLikeLog(vViewpointLikeLog)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvViewpointLikeLogBL
{
public static RelatedActions_vViewpointLikeLog relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvViewpointLikeLogDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvViewpointLikeLogDA vViewpointLikeLogDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvViewpointLikeLogDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvViewpointLikeLogBL()
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
if (string.IsNullOrEmpty(clsvViewpointLikeLogEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewpointLikeLogEN._ConnectString);
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
public static DataTable GetDataTable_vViewpointLikeLog(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vViewpointLikeLogDA.GetDataTable_vViewpointLikeLog(strWhereCond);
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
objDT = vViewpointLikeLogDA.GetDataTable(strWhereCond);
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
objDT = vViewpointLikeLogDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vViewpointLikeLogDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vViewpointLikeLogDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vViewpointLikeLogDA.GetDataTable_Top(objTopPara);
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
objDT = vViewpointLikeLogDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vViewpointLikeLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vViewpointLikeLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrViewpointLikeLogIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvViewpointLikeLogEN> GetObjLstByViewpointLikeLogIdLst(List<long> arrViewpointLikeLogIdLst)
{
List<clsvViewpointLikeLogEN> arrObjLst = new List<clsvViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrViewpointLikeLogIdLst);
 string strWhereCond = string.Format("ViewpointLikeLogId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointLikeLogEN objvViewpointLikeLogEN = new clsvViewpointLikeLogEN();
try
{
objvViewpointLikeLogEN.Memo = objRow[convViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[convViewpointLikeLog.Memo].ToString().Trim(); //备注
objvViewpointLikeLogEN.UpdUserId = objRow[convViewpointLikeLog.UpdUserId] == DBNull.Value ? null : objRow[convViewpointLikeLog.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointLikeLogEN.UpdDate = objRow[convViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[convViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objvViewpointLikeLogEN.ViewpointId = objRow[convViewpointLikeLog.ViewpointId] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointId].ToString().Trim(); //观点Id
objvViewpointLikeLogEN.ViewpointLikeLogId = Int32.Parse(objRow[convViewpointLikeLog.ViewpointLikeLogId].ToString().Trim()); //观点点赞Id
objvViewpointLikeLogEN.ViewpointName = objRow[convViewpointLikeLog.ViewpointName] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointName].ToString().Trim(); //观点名称
objvViewpointLikeLogEN.ViewpointContent = objRow[convViewpointLikeLog.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointLikeLogEN.Reason = objRow[convViewpointLikeLog.Reason] == DBNull.Value ? null : objRow[convViewpointLikeLog.Reason].ToString().Trim(); //理由
objvViewpointLikeLogEN.UserName = objRow[convViewpointLikeLog.UserName] == DBNull.Value ? null : objRow[convViewpointLikeLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointLikeLogEN.ViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointLikeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewpointLikeLogIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvViewpointLikeLogEN> GetObjLstByViewpointLikeLogIdLstCache(List<long> arrViewpointLikeLogIdLst)
{
string strKey = string.Format("{0}", clsvViewpointLikeLogEN._CurrTabName);
List<clsvViewpointLikeLogEN> arrvViewpointLikeLogObjLstCache = GetObjLstCache();
IEnumerable <clsvViewpointLikeLogEN> arrvViewpointLikeLogObjLst_Sel =
arrvViewpointLikeLogObjLstCache
.Where(x => arrViewpointLikeLogIdLst.Contains(x.ViewpointLikeLogId));
return arrvViewpointLikeLogObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewpointLikeLogEN> GetObjLst(string strWhereCond)
{
List<clsvViewpointLikeLogEN> arrObjLst = new List<clsvViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointLikeLogEN objvViewpointLikeLogEN = new clsvViewpointLikeLogEN();
try
{
objvViewpointLikeLogEN.Memo = objRow[convViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[convViewpointLikeLog.Memo].ToString().Trim(); //备注
objvViewpointLikeLogEN.UpdUserId = objRow[convViewpointLikeLog.UpdUserId] == DBNull.Value ? null : objRow[convViewpointLikeLog.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointLikeLogEN.UpdDate = objRow[convViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[convViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objvViewpointLikeLogEN.ViewpointId = objRow[convViewpointLikeLog.ViewpointId] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointId].ToString().Trim(); //观点Id
objvViewpointLikeLogEN.ViewpointLikeLogId = Int32.Parse(objRow[convViewpointLikeLog.ViewpointLikeLogId].ToString().Trim()); //观点点赞Id
objvViewpointLikeLogEN.ViewpointName = objRow[convViewpointLikeLog.ViewpointName] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointName].ToString().Trim(); //观点名称
objvViewpointLikeLogEN.ViewpointContent = objRow[convViewpointLikeLog.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointLikeLogEN.Reason = objRow[convViewpointLikeLog.Reason] == DBNull.Value ? null : objRow[convViewpointLikeLog.Reason].ToString().Trim(); //理由
objvViewpointLikeLogEN.UserName = objRow[convViewpointLikeLog.UserName] == DBNull.Value ? null : objRow[convViewpointLikeLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointLikeLogEN.ViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointLikeLogEN);
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
public static List<clsvViewpointLikeLogEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvViewpointLikeLogEN> arrObjLst = new List<clsvViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointLikeLogEN objvViewpointLikeLogEN = new clsvViewpointLikeLogEN();
try
{
objvViewpointLikeLogEN.Memo = objRow[convViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[convViewpointLikeLog.Memo].ToString().Trim(); //备注
objvViewpointLikeLogEN.UpdUserId = objRow[convViewpointLikeLog.UpdUserId] == DBNull.Value ? null : objRow[convViewpointLikeLog.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointLikeLogEN.UpdDate = objRow[convViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[convViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objvViewpointLikeLogEN.ViewpointId = objRow[convViewpointLikeLog.ViewpointId] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointId].ToString().Trim(); //观点Id
objvViewpointLikeLogEN.ViewpointLikeLogId = Int32.Parse(objRow[convViewpointLikeLog.ViewpointLikeLogId].ToString().Trim()); //观点点赞Id
objvViewpointLikeLogEN.ViewpointName = objRow[convViewpointLikeLog.ViewpointName] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointName].ToString().Trim(); //观点名称
objvViewpointLikeLogEN.ViewpointContent = objRow[convViewpointLikeLog.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointLikeLogEN.Reason = objRow[convViewpointLikeLog.Reason] == DBNull.Value ? null : objRow[convViewpointLikeLog.Reason].ToString().Trim(); //理由
objvViewpointLikeLogEN.UserName = objRow[convViewpointLikeLog.UserName] == DBNull.Value ? null : objRow[convViewpointLikeLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointLikeLogEN.ViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointLikeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvViewpointLikeLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvViewpointLikeLogEN> GetSubObjLstCache(clsvViewpointLikeLogEN objvViewpointLikeLogCond)
{
List<clsvViewpointLikeLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvViewpointLikeLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewpointLikeLog.AttributeName)
{
if (objvViewpointLikeLogCond.IsUpdated(strFldName) == false) continue;
if (objvViewpointLikeLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointLikeLogCond[strFldName].ToString());
}
else
{
if (objvViewpointLikeLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewpointLikeLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointLikeLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewpointLikeLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewpointLikeLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewpointLikeLogCond[strFldName]));
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
public static List<clsvViewpointLikeLogEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvViewpointLikeLogEN> arrObjLst = new List<clsvViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointLikeLogEN objvViewpointLikeLogEN = new clsvViewpointLikeLogEN();
try
{
objvViewpointLikeLogEN.Memo = objRow[convViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[convViewpointLikeLog.Memo].ToString().Trim(); //备注
objvViewpointLikeLogEN.UpdUserId = objRow[convViewpointLikeLog.UpdUserId] == DBNull.Value ? null : objRow[convViewpointLikeLog.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointLikeLogEN.UpdDate = objRow[convViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[convViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objvViewpointLikeLogEN.ViewpointId = objRow[convViewpointLikeLog.ViewpointId] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointId].ToString().Trim(); //观点Id
objvViewpointLikeLogEN.ViewpointLikeLogId = Int32.Parse(objRow[convViewpointLikeLog.ViewpointLikeLogId].ToString().Trim()); //观点点赞Id
objvViewpointLikeLogEN.ViewpointName = objRow[convViewpointLikeLog.ViewpointName] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointName].ToString().Trim(); //观点名称
objvViewpointLikeLogEN.ViewpointContent = objRow[convViewpointLikeLog.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointLikeLogEN.Reason = objRow[convViewpointLikeLog.Reason] == DBNull.Value ? null : objRow[convViewpointLikeLog.Reason].ToString().Trim(); //理由
objvViewpointLikeLogEN.UserName = objRow[convViewpointLikeLog.UserName] == DBNull.Value ? null : objRow[convViewpointLikeLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointLikeLogEN.ViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointLikeLogEN);
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
public static List<clsvViewpointLikeLogEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvViewpointLikeLogEN> arrObjLst = new List<clsvViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointLikeLogEN objvViewpointLikeLogEN = new clsvViewpointLikeLogEN();
try
{
objvViewpointLikeLogEN.Memo = objRow[convViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[convViewpointLikeLog.Memo].ToString().Trim(); //备注
objvViewpointLikeLogEN.UpdUserId = objRow[convViewpointLikeLog.UpdUserId] == DBNull.Value ? null : objRow[convViewpointLikeLog.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointLikeLogEN.UpdDate = objRow[convViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[convViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objvViewpointLikeLogEN.ViewpointId = objRow[convViewpointLikeLog.ViewpointId] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointId].ToString().Trim(); //观点Id
objvViewpointLikeLogEN.ViewpointLikeLogId = Int32.Parse(objRow[convViewpointLikeLog.ViewpointLikeLogId].ToString().Trim()); //观点点赞Id
objvViewpointLikeLogEN.ViewpointName = objRow[convViewpointLikeLog.ViewpointName] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointName].ToString().Trim(); //观点名称
objvViewpointLikeLogEN.ViewpointContent = objRow[convViewpointLikeLog.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointLikeLogEN.Reason = objRow[convViewpointLikeLog.Reason] == DBNull.Value ? null : objRow[convViewpointLikeLog.Reason].ToString().Trim(); //理由
objvViewpointLikeLogEN.UserName = objRow[convViewpointLikeLog.UserName] == DBNull.Value ? null : objRow[convViewpointLikeLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointLikeLogEN.ViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointLikeLogEN);
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
List<clsvViewpointLikeLogEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvViewpointLikeLogEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewpointLikeLogEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvViewpointLikeLogEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvViewpointLikeLogEN> arrObjLst = new List<clsvViewpointLikeLogEN>(); 
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
	clsvViewpointLikeLogEN objvViewpointLikeLogEN = new clsvViewpointLikeLogEN();
try
{
objvViewpointLikeLogEN.Memo = objRow[convViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[convViewpointLikeLog.Memo].ToString().Trim(); //备注
objvViewpointLikeLogEN.UpdUserId = objRow[convViewpointLikeLog.UpdUserId] == DBNull.Value ? null : objRow[convViewpointLikeLog.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointLikeLogEN.UpdDate = objRow[convViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[convViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objvViewpointLikeLogEN.ViewpointId = objRow[convViewpointLikeLog.ViewpointId] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointId].ToString().Trim(); //观点Id
objvViewpointLikeLogEN.ViewpointLikeLogId = Int32.Parse(objRow[convViewpointLikeLog.ViewpointLikeLogId].ToString().Trim()); //观点点赞Id
objvViewpointLikeLogEN.ViewpointName = objRow[convViewpointLikeLog.ViewpointName] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointName].ToString().Trim(); //观点名称
objvViewpointLikeLogEN.ViewpointContent = objRow[convViewpointLikeLog.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointLikeLogEN.Reason = objRow[convViewpointLikeLog.Reason] == DBNull.Value ? null : objRow[convViewpointLikeLog.Reason].ToString().Trim(); //理由
objvViewpointLikeLogEN.UserName = objRow[convViewpointLikeLog.UserName] == DBNull.Value ? null : objRow[convViewpointLikeLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointLikeLogEN.ViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointLikeLogEN);
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
public static List<clsvViewpointLikeLogEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvViewpointLikeLogEN> arrObjLst = new List<clsvViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointLikeLogEN objvViewpointLikeLogEN = new clsvViewpointLikeLogEN();
try
{
objvViewpointLikeLogEN.Memo = objRow[convViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[convViewpointLikeLog.Memo].ToString().Trim(); //备注
objvViewpointLikeLogEN.UpdUserId = objRow[convViewpointLikeLog.UpdUserId] == DBNull.Value ? null : objRow[convViewpointLikeLog.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointLikeLogEN.UpdDate = objRow[convViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[convViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objvViewpointLikeLogEN.ViewpointId = objRow[convViewpointLikeLog.ViewpointId] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointId].ToString().Trim(); //观点Id
objvViewpointLikeLogEN.ViewpointLikeLogId = Int32.Parse(objRow[convViewpointLikeLog.ViewpointLikeLogId].ToString().Trim()); //观点点赞Id
objvViewpointLikeLogEN.ViewpointName = objRow[convViewpointLikeLog.ViewpointName] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointName].ToString().Trim(); //观点名称
objvViewpointLikeLogEN.ViewpointContent = objRow[convViewpointLikeLog.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointLikeLogEN.Reason = objRow[convViewpointLikeLog.Reason] == DBNull.Value ? null : objRow[convViewpointLikeLog.Reason].ToString().Trim(); //理由
objvViewpointLikeLogEN.UserName = objRow[convViewpointLikeLog.UserName] == DBNull.Value ? null : objRow[convViewpointLikeLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointLikeLogEN.ViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointLikeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvViewpointLikeLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvViewpointLikeLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvViewpointLikeLogEN> arrObjLst = new List<clsvViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointLikeLogEN objvViewpointLikeLogEN = new clsvViewpointLikeLogEN();
try
{
objvViewpointLikeLogEN.Memo = objRow[convViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[convViewpointLikeLog.Memo].ToString().Trim(); //备注
objvViewpointLikeLogEN.UpdUserId = objRow[convViewpointLikeLog.UpdUserId] == DBNull.Value ? null : objRow[convViewpointLikeLog.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointLikeLogEN.UpdDate = objRow[convViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[convViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objvViewpointLikeLogEN.ViewpointId = objRow[convViewpointLikeLog.ViewpointId] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointId].ToString().Trim(); //观点Id
objvViewpointLikeLogEN.ViewpointLikeLogId = Int32.Parse(objRow[convViewpointLikeLog.ViewpointLikeLogId].ToString().Trim()); //观点点赞Id
objvViewpointLikeLogEN.ViewpointName = objRow[convViewpointLikeLog.ViewpointName] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointName].ToString().Trim(); //观点名称
objvViewpointLikeLogEN.ViewpointContent = objRow[convViewpointLikeLog.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointLikeLogEN.Reason = objRow[convViewpointLikeLog.Reason] == DBNull.Value ? null : objRow[convViewpointLikeLog.Reason].ToString().Trim(); //理由
objvViewpointLikeLogEN.UserName = objRow[convViewpointLikeLog.UserName] == DBNull.Value ? null : objRow[convViewpointLikeLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointLikeLogEN.ViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointLikeLogEN);
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
public static List<clsvViewpointLikeLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvViewpointLikeLogEN> arrObjLst = new List<clsvViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointLikeLogEN objvViewpointLikeLogEN = new clsvViewpointLikeLogEN();
try
{
objvViewpointLikeLogEN.Memo = objRow[convViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[convViewpointLikeLog.Memo].ToString().Trim(); //备注
objvViewpointLikeLogEN.UpdUserId = objRow[convViewpointLikeLog.UpdUserId] == DBNull.Value ? null : objRow[convViewpointLikeLog.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointLikeLogEN.UpdDate = objRow[convViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[convViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objvViewpointLikeLogEN.ViewpointId = objRow[convViewpointLikeLog.ViewpointId] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointId].ToString().Trim(); //观点Id
objvViewpointLikeLogEN.ViewpointLikeLogId = Int32.Parse(objRow[convViewpointLikeLog.ViewpointLikeLogId].ToString().Trim()); //观点点赞Id
objvViewpointLikeLogEN.ViewpointName = objRow[convViewpointLikeLog.ViewpointName] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointName].ToString().Trim(); //观点名称
objvViewpointLikeLogEN.ViewpointContent = objRow[convViewpointLikeLog.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointLikeLogEN.Reason = objRow[convViewpointLikeLog.Reason] == DBNull.Value ? null : objRow[convViewpointLikeLog.Reason].ToString().Trim(); //理由
objvViewpointLikeLogEN.UserName = objRow[convViewpointLikeLog.UserName] == DBNull.Value ? null : objRow[convViewpointLikeLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointLikeLogEN.ViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointLikeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewpointLikeLogEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvViewpointLikeLogEN> arrObjLst = new List<clsvViewpointLikeLogEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointLikeLogEN objvViewpointLikeLogEN = new clsvViewpointLikeLogEN();
try
{
objvViewpointLikeLogEN.Memo = objRow[convViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[convViewpointLikeLog.Memo].ToString().Trim(); //备注
objvViewpointLikeLogEN.UpdUserId = objRow[convViewpointLikeLog.UpdUserId] == DBNull.Value ? null : objRow[convViewpointLikeLog.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointLikeLogEN.UpdDate = objRow[convViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[convViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objvViewpointLikeLogEN.ViewpointId = objRow[convViewpointLikeLog.ViewpointId] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointId].ToString().Trim(); //观点Id
objvViewpointLikeLogEN.ViewpointLikeLogId = Int32.Parse(objRow[convViewpointLikeLog.ViewpointLikeLogId].ToString().Trim()); //观点点赞Id
objvViewpointLikeLogEN.ViewpointName = objRow[convViewpointLikeLog.ViewpointName] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointName].ToString().Trim(); //观点名称
objvViewpointLikeLogEN.ViewpointContent = objRow[convViewpointLikeLog.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointLikeLog.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointLikeLogEN.Reason = objRow[convViewpointLikeLog.Reason] == DBNull.Value ? null : objRow[convViewpointLikeLog.Reason].ToString().Trim(); //理由
objvViewpointLikeLogEN.UserName = objRow[convViewpointLikeLog.UserName] == DBNull.Value ? null : objRow[convViewpointLikeLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointLikeLogEN.ViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointLikeLogEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvViewpointLikeLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvViewpointLikeLog(ref clsvViewpointLikeLogEN objvViewpointLikeLogEN)
{
bool bolResult = vViewpointLikeLogDA.GetvViewpointLikeLog(ref objvViewpointLikeLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngViewpointLikeLogId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewpointLikeLogEN GetObjByViewpointLikeLogId(long lngViewpointLikeLogId)
{
clsvViewpointLikeLogEN objvViewpointLikeLogEN = vViewpointLikeLogDA.GetObjByViewpointLikeLogId(lngViewpointLikeLogId);
return objvViewpointLikeLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvViewpointLikeLogEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvViewpointLikeLogEN objvViewpointLikeLogEN = vViewpointLikeLogDA.GetFirstObj(strWhereCond);
 return objvViewpointLikeLogEN;
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
public static clsvViewpointLikeLogEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvViewpointLikeLogEN objvViewpointLikeLogEN = vViewpointLikeLogDA.GetObjByDataRow(objRow);
 return objvViewpointLikeLogEN;
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
public static clsvViewpointLikeLogEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvViewpointLikeLogEN objvViewpointLikeLogEN = vViewpointLikeLogDA.GetObjByDataRow(objRow);
 return objvViewpointLikeLogEN;
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
 /// <param name = "lngViewpointLikeLogId">所给的关键字</param>
 /// <param name = "lstvViewpointLikeLogObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewpointLikeLogEN GetObjByViewpointLikeLogIdFromList(long lngViewpointLikeLogId, List<clsvViewpointLikeLogEN> lstvViewpointLikeLogObjLst)
{
foreach (clsvViewpointLikeLogEN objvViewpointLikeLogEN in lstvViewpointLikeLogObjLst)
{
if (objvViewpointLikeLogEN.ViewpointLikeLogId == lngViewpointLikeLogId)
{
return objvViewpointLikeLogEN;
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
 long lngViewpointLikeLogId;
 try
 {
 lngViewpointLikeLogId = new clsvViewpointLikeLogDA().GetFirstID(strWhereCond);
 return lngViewpointLikeLogId;
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
 arrList = vViewpointLikeLogDA.GetID(strWhereCond);
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
bool bolIsExist = vViewpointLikeLogDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngViewpointLikeLogId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngViewpointLikeLogId)
{
//检测记录是否存在
bool bolIsExist = vViewpointLikeLogDA.IsExist(lngViewpointLikeLogId);
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
 bolIsExist = clsvViewpointLikeLogDA.IsExistTable();
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
 bolIsExist = vViewpointLikeLogDA.IsExistTable(strTabName);
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
 /// <param name = "objvViewpointLikeLogENS">源对象</param>
 /// <param name = "objvViewpointLikeLogENT">目标对象</param>
 public static void CopyTo(clsvViewpointLikeLogEN objvViewpointLikeLogENS, clsvViewpointLikeLogEN objvViewpointLikeLogENT)
{
try
{
objvViewpointLikeLogENT.Memo = objvViewpointLikeLogENS.Memo; //备注
objvViewpointLikeLogENT.UpdUserId = objvViewpointLikeLogENS.UpdUserId; //修改用户Id
objvViewpointLikeLogENT.UpdDate = objvViewpointLikeLogENS.UpdDate; //修改日期
objvViewpointLikeLogENT.ViewpointId = objvViewpointLikeLogENS.ViewpointId; //观点Id
objvViewpointLikeLogENT.ViewpointLikeLogId = objvViewpointLikeLogENS.ViewpointLikeLogId; //观点点赞Id
objvViewpointLikeLogENT.ViewpointName = objvViewpointLikeLogENS.ViewpointName; //观点名称
objvViewpointLikeLogENT.ViewpointContent = objvViewpointLikeLogENS.ViewpointContent; //观点内容
objvViewpointLikeLogENT.Reason = objvViewpointLikeLogENS.Reason; //理由
objvViewpointLikeLogENT.UserName = objvViewpointLikeLogENS.UserName; //用户名
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
 /// <param name = "objvViewpointLikeLogEN">源简化对象</param>
 public static void SetUpdFlag(clsvViewpointLikeLogEN objvViewpointLikeLogEN)
{
try
{
objvViewpointLikeLogEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvViewpointLikeLogEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convViewpointLikeLog.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointLikeLogEN.Memo = objvViewpointLikeLogEN.Memo == "[null]" ? null :  objvViewpointLikeLogEN.Memo; //备注
}
if (arrFldSet.Contains(convViewpointLikeLog.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointLikeLogEN.UpdUserId = objvViewpointLikeLogEN.UpdUserId == "[null]" ? null :  objvViewpointLikeLogEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convViewpointLikeLog.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointLikeLogEN.UpdDate = objvViewpointLikeLogEN.UpdDate == "[null]" ? null :  objvViewpointLikeLogEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convViewpointLikeLog.ViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointLikeLogEN.ViewpointId = objvViewpointLikeLogEN.ViewpointId == "[null]" ? null :  objvViewpointLikeLogEN.ViewpointId; //观点Id
}
if (arrFldSet.Contains(convViewpointLikeLog.ViewpointLikeLogId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointLikeLogEN.ViewpointLikeLogId = objvViewpointLikeLogEN.ViewpointLikeLogId; //观点点赞Id
}
if (arrFldSet.Contains(convViewpointLikeLog.ViewpointName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointLikeLogEN.ViewpointName = objvViewpointLikeLogEN.ViewpointName == "[null]" ? null :  objvViewpointLikeLogEN.ViewpointName; //观点名称
}
if (arrFldSet.Contains(convViewpointLikeLog.ViewpointContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointLikeLogEN.ViewpointContent = objvViewpointLikeLogEN.ViewpointContent == "[null]" ? null :  objvViewpointLikeLogEN.ViewpointContent; //观点内容
}
if (arrFldSet.Contains(convViewpointLikeLog.Reason, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointLikeLogEN.Reason = objvViewpointLikeLogEN.Reason == "[null]" ? null :  objvViewpointLikeLogEN.Reason; //理由
}
if (arrFldSet.Contains(convViewpointLikeLog.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointLikeLogEN.UserName = objvViewpointLikeLogEN.UserName == "[null]" ? null :  objvViewpointLikeLogEN.UserName; //用户名
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
 /// <param name = "objvViewpointLikeLogEN">源简化对象</param>
 public static void AccessFldValueNull(clsvViewpointLikeLogEN objvViewpointLikeLogEN)
{
try
{
if (objvViewpointLikeLogEN.Memo == "[null]") objvViewpointLikeLogEN.Memo = null; //备注
if (objvViewpointLikeLogEN.UpdUserId == "[null]") objvViewpointLikeLogEN.UpdUserId = null; //修改用户Id
if (objvViewpointLikeLogEN.UpdDate == "[null]") objvViewpointLikeLogEN.UpdDate = null; //修改日期
if (objvViewpointLikeLogEN.ViewpointId == "[null]") objvViewpointLikeLogEN.ViewpointId = null; //观点Id
if (objvViewpointLikeLogEN.ViewpointName == "[null]") objvViewpointLikeLogEN.ViewpointName = null; //观点名称
if (objvViewpointLikeLogEN.ViewpointContent == "[null]") objvViewpointLikeLogEN.ViewpointContent = null; //观点内容
if (objvViewpointLikeLogEN.Reason == "[null]") objvViewpointLikeLogEN.Reason = null; //理由
if (objvViewpointLikeLogEN.UserName == "[null]") objvViewpointLikeLogEN.UserName = null; //用户名
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
public static void CheckProperty4Condition(clsvViewpointLikeLogEN objvViewpointLikeLogEN)
{
 vViewpointLikeLogDA.CheckProperty4Condition(objvViewpointLikeLogEN);
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
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewpointBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewpointBL没有刷新缓存机制(clsViewpointBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewpointLikeLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewpointLikeLogBL没有刷新缓存机制(clsViewpointLikeLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ViewpointLikeLogId");
//if (arrvViewpointLikeLogObjLstCache == null)
//{
//arrvViewpointLikeLogObjLstCache = vViewpointLikeLogDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngViewpointLikeLogId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewpointLikeLogEN GetObjByViewpointLikeLogIdCache(long lngViewpointLikeLogId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvViewpointLikeLogEN._CurrTabName);
List<clsvViewpointLikeLogEN> arrvViewpointLikeLogObjLstCache = GetObjLstCache();
IEnumerable <clsvViewpointLikeLogEN> arrvViewpointLikeLogObjLst_Sel =
arrvViewpointLikeLogObjLstCache
.Where(x=> x.ViewpointLikeLogId == lngViewpointLikeLogId 
);
if (arrvViewpointLikeLogObjLst_Sel.Count() == 0)
{
   clsvViewpointLikeLogEN obj = clsvViewpointLikeLogBL.GetObjByViewpointLikeLogId(lngViewpointLikeLogId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvViewpointLikeLogObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewpointLikeLogEN> GetAllvViewpointLikeLogObjLstCache()
{
//获取缓存中的对象列表
List<clsvViewpointLikeLogEN> arrvViewpointLikeLogObjLstCache = GetObjLstCache(); 
return arrvViewpointLikeLogObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewpointLikeLogEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvViewpointLikeLogEN._CurrTabName);
List<clsvViewpointLikeLogEN> arrvViewpointLikeLogObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvViewpointLikeLogObjLstCache;
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
string strKey = string.Format("{0}", clsvViewpointLikeLogEN._CurrTabName);
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

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--vViewpointLikeLog(vViewpointLikeLog)
 /// 唯一性条件:ViewpointLikeLogId_ViewpointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvViewpointLikeLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvViewpointLikeLogEN objvViewpointLikeLogEN)
{
//检测记录是否存在
string strResult = vViewpointLikeLogDA.GetUniCondStr(objvViewpointLikeLogEN);
return strResult;
}


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
public static string Func(string strInFldName, string strOutFldName, long lngViewpointLikeLogId)
{
if (strInFldName != convViewpointLikeLog.ViewpointLikeLogId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convViewpointLikeLog.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convViewpointLikeLog.AttributeName));
throw new Exception(strMsg);
}
var objvViewpointLikeLog = clsvViewpointLikeLogBL.GetObjByViewpointLikeLogIdCache(lngViewpointLikeLogId);
if (objvViewpointLikeLog == null) return "";
return objvViewpointLikeLog[strOutFldName].ToString();
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
int intRecCount = clsvViewpointLikeLogDA.GetRecCount(strTabName);
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
int intRecCount = clsvViewpointLikeLogDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvViewpointLikeLogDA.GetRecCount();
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
int intRecCount = clsvViewpointLikeLogDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvViewpointLikeLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvViewpointLikeLogEN objvViewpointLikeLogCond)
{
List<clsvViewpointLikeLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvViewpointLikeLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewpointLikeLog.AttributeName)
{
if (objvViewpointLikeLogCond.IsUpdated(strFldName) == false) continue;
if (objvViewpointLikeLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointLikeLogCond[strFldName].ToString());
}
else
{
if (objvViewpointLikeLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewpointLikeLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointLikeLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewpointLikeLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewpointLikeLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewpointLikeLogCond[strFldName]));
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
 List<string> arrList = clsvViewpointLikeLogDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vViewpointLikeLogDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vViewpointLikeLogDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}