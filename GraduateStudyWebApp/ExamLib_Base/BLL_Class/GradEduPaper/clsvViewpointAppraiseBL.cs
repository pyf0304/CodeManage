﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewpointAppraiseBL
 表名:vViewpointAppraise(01120610)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:05:43
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
public static class  clsvViewpointAppraiseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngViewpointAppraiseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewpointAppraiseEN GetObj(this K_ViewpointAppraiseId_vViewpointAppraise myKey)
{
clsvViewpointAppraiseEN objvViewpointAppraiseEN = clsvViewpointAppraiseBL.vViewpointAppraiseDA.GetObjByViewpointAppraiseId(myKey.Value);
return objvViewpointAppraiseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAppraiseEN SetUserName(this clsvViewpointAppraiseEN objvViewpointAppraiseEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convViewpointAppraise.UserName);
}
objvViewpointAppraiseEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convViewpointAppraise.UserName) == false)
{
objvViewpointAppraiseEN.dicFldComparisonOp.Add(convViewpointAppraise.UserName, strComparisonOp);
}
else
{
objvViewpointAppraiseEN.dicFldComparisonOp[convViewpointAppraise.UserName] = strComparisonOp;
}
}
return objvViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAppraiseEN SetViewpointAppraiseId(this clsvViewpointAppraiseEN objvViewpointAppraiseEN, long lngViewpointAppraiseId, string strComparisonOp="")
	{
objvViewpointAppraiseEN.ViewpointAppraiseId = lngViewpointAppraiseId; //观点评论Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convViewpointAppraise.ViewpointAppraiseId) == false)
{
objvViewpointAppraiseEN.dicFldComparisonOp.Add(convViewpointAppraise.ViewpointAppraiseId, strComparisonOp);
}
else
{
objvViewpointAppraiseEN.dicFldComparisonOp[convViewpointAppraise.ViewpointAppraiseId] = strComparisonOp;
}
}
return objvViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAppraiseEN SetViewpointId(this clsvViewpointAppraiseEN objvViewpointAppraiseEN, string strViewpointId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointId, 8, convViewpointAppraise.ViewpointId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewpointId, 8, convViewpointAppraise.ViewpointId);
}
objvViewpointAppraiseEN.ViewpointId = strViewpointId; //观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convViewpointAppraise.ViewpointId) == false)
{
objvViewpointAppraiseEN.dicFldComparisonOp.Add(convViewpointAppraise.ViewpointId, strComparisonOp);
}
else
{
objvViewpointAppraiseEN.dicFldComparisonOp[convViewpointAppraise.ViewpointId] = strComparisonOp;
}
}
return objvViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAppraiseEN SetAppraiseContent(this clsvViewpointAppraiseEN objvViewpointAppraiseEN, string strAppraiseContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseContent, 2000, convViewpointAppraise.AppraiseContent);
}
objvViewpointAppraiseEN.AppraiseContent = strAppraiseContent; //评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convViewpointAppraise.AppraiseContent) == false)
{
objvViewpointAppraiseEN.dicFldComparisonOp.Add(convViewpointAppraise.AppraiseContent, strComparisonOp);
}
else
{
objvViewpointAppraiseEN.dicFldComparisonOp[convViewpointAppraise.AppraiseContent] = strComparisonOp;
}
}
return objvViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAppraiseEN SetUpdDate(this clsvViewpointAppraiseEN objvViewpointAppraiseEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewpointAppraise.UpdDate);
}
objvViewpointAppraiseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convViewpointAppraise.UpdDate) == false)
{
objvViewpointAppraiseEN.dicFldComparisonOp.Add(convViewpointAppraise.UpdDate, strComparisonOp);
}
else
{
objvViewpointAppraiseEN.dicFldComparisonOp[convViewpointAppraise.UpdDate] = strComparisonOp;
}
}
return objvViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAppraiseEN SetMemo(this clsvViewpointAppraiseEN objvViewpointAppraiseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convViewpointAppraise.Memo);
}
objvViewpointAppraiseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convViewpointAppraise.Memo) == false)
{
objvViewpointAppraiseEN.dicFldComparisonOp.Add(convViewpointAppraise.Memo, strComparisonOp);
}
else
{
objvViewpointAppraiseEN.dicFldComparisonOp[convViewpointAppraise.Memo] = strComparisonOp;
}
}
return objvViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAppraiseEN SetViewpointName(this clsvViewpointAppraiseEN objvViewpointAppraiseEN, string strViewpointName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointName, 500, convViewpointAppraise.ViewpointName);
}
objvViewpointAppraiseEN.ViewpointName = strViewpointName; //观点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convViewpointAppraise.ViewpointName) == false)
{
objvViewpointAppraiseEN.dicFldComparisonOp.Add(convViewpointAppraise.ViewpointName, strComparisonOp);
}
else
{
objvViewpointAppraiseEN.dicFldComparisonOp[convViewpointAppraise.ViewpointName] = strComparisonOp;
}
}
return objvViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAppraiseEN SetViewpointContent(this clsvViewpointAppraiseEN objvViewpointAppraiseEN, string strViewpointContent, string strComparisonOp="")
	{
objvViewpointAppraiseEN.ViewpointContent = strViewpointContent; //观点内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convViewpointAppraise.ViewpointContent) == false)
{
objvViewpointAppraiseEN.dicFldComparisonOp.Add(convViewpointAppraise.ViewpointContent, strComparisonOp);
}
else
{
objvViewpointAppraiseEN.dicFldComparisonOp[convViewpointAppraise.ViewpointContent] = strComparisonOp;
}
}
return objvViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAppraiseEN SetReason(this clsvViewpointAppraiseEN objvViewpointAppraiseEN, string strReason, string strComparisonOp="")
	{
objvViewpointAppraiseEN.Reason = strReason; //理由
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convViewpointAppraise.Reason) == false)
{
objvViewpointAppraiseEN.dicFldComparisonOp.Add(convViewpointAppraise.Reason, strComparisonOp);
}
else
{
objvViewpointAppraiseEN.dicFldComparisonOp[convViewpointAppraise.Reason] = strComparisonOp;
}
}
return objvViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAppraiseEN SetUpdUser(this clsvViewpointAppraiseEN objvViewpointAppraiseEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convViewpointAppraise.UpdUser);
}
objvViewpointAppraiseEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convViewpointAppraise.UpdUser) == false)
{
objvViewpointAppraiseEN.dicFldComparisonOp.Add(convViewpointAppraise.UpdUser, strComparisonOp);
}
else
{
objvViewpointAppraiseEN.dicFldComparisonOp[convViewpointAppraise.UpdUser] = strComparisonOp;
}
}
return objvViewpointAppraiseEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvViewpointAppraiseENS">源对象</param>
 /// <param name = "objvViewpointAppraiseENT">目标对象</param>
 public static void CopyTo(this clsvViewpointAppraiseEN objvViewpointAppraiseENS, clsvViewpointAppraiseEN objvViewpointAppraiseENT)
{
try
{
objvViewpointAppraiseENT.UserName = objvViewpointAppraiseENS.UserName; //用户名
objvViewpointAppraiseENT.ViewpointAppraiseId = objvViewpointAppraiseENS.ViewpointAppraiseId; //观点评论Id
objvViewpointAppraiseENT.ViewpointId = objvViewpointAppraiseENS.ViewpointId; //观点Id
objvViewpointAppraiseENT.AppraiseContent = objvViewpointAppraiseENS.AppraiseContent; //评议内容
objvViewpointAppraiseENT.UpdDate = objvViewpointAppraiseENS.UpdDate; //修改日期
objvViewpointAppraiseENT.Memo = objvViewpointAppraiseENS.Memo; //备注
objvViewpointAppraiseENT.ViewpointName = objvViewpointAppraiseENS.ViewpointName; //观点名称
objvViewpointAppraiseENT.ViewpointContent = objvViewpointAppraiseENS.ViewpointContent; //观点内容
objvViewpointAppraiseENT.Reason = objvViewpointAppraiseENS.Reason; //理由
objvViewpointAppraiseENT.UpdUser = objvViewpointAppraiseENS.UpdUser; //修改人
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
 /// <param name = "objvViewpointAppraiseENS">源对象</param>
 /// <returns>目标对象=>clsvViewpointAppraiseEN:objvViewpointAppraiseENT</returns>
 public static clsvViewpointAppraiseEN CopyTo(this clsvViewpointAppraiseEN objvViewpointAppraiseENS)
{
try
{
 clsvViewpointAppraiseEN objvViewpointAppraiseENT = new clsvViewpointAppraiseEN()
{
UserName = objvViewpointAppraiseENS.UserName, //用户名
ViewpointAppraiseId = objvViewpointAppraiseENS.ViewpointAppraiseId, //观点评论Id
ViewpointId = objvViewpointAppraiseENS.ViewpointId, //观点Id
AppraiseContent = objvViewpointAppraiseENS.AppraiseContent, //评议内容
UpdDate = objvViewpointAppraiseENS.UpdDate, //修改日期
Memo = objvViewpointAppraiseENS.Memo, //备注
ViewpointName = objvViewpointAppraiseENS.ViewpointName, //观点名称
ViewpointContent = objvViewpointAppraiseENS.ViewpointContent, //观点内容
Reason = objvViewpointAppraiseENS.Reason, //理由
UpdUser = objvViewpointAppraiseENS.UpdUser, //修改人
};
 return objvViewpointAppraiseENT;
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
public static void CheckProperty4Condition(this clsvViewpointAppraiseEN objvViewpointAppraiseEN)
{
 clsvViewpointAppraiseBL.vViewpointAppraiseDA.CheckProperty4Condition(objvViewpointAppraiseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvViewpointAppraiseEN objvViewpointAppraiseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvViewpointAppraiseCond.IsUpdated(convViewpointAppraise.UserName) == true)
{
string strComparisonOpUserName = objvViewpointAppraiseCond.dicFldComparisonOp[convViewpointAppraise.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAppraise.UserName, objvViewpointAppraiseCond.UserName, strComparisonOpUserName);
}
if (objvViewpointAppraiseCond.IsUpdated(convViewpointAppraise.ViewpointAppraiseId) == true)
{
string strComparisonOpViewpointAppraiseId = objvViewpointAppraiseCond.dicFldComparisonOp[convViewpointAppraise.ViewpointAppraiseId];
strWhereCond += string.Format(" And {0} {2} {1}", convViewpointAppraise.ViewpointAppraiseId, objvViewpointAppraiseCond.ViewpointAppraiseId, strComparisonOpViewpointAppraiseId);
}
if (objvViewpointAppraiseCond.IsUpdated(convViewpointAppraise.ViewpointId) == true)
{
string strComparisonOpViewpointId = objvViewpointAppraiseCond.dicFldComparisonOp[convViewpointAppraise.ViewpointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAppraise.ViewpointId, objvViewpointAppraiseCond.ViewpointId, strComparisonOpViewpointId);
}
if (objvViewpointAppraiseCond.IsUpdated(convViewpointAppraise.AppraiseContent) == true)
{
string strComparisonOpAppraiseContent = objvViewpointAppraiseCond.dicFldComparisonOp[convViewpointAppraise.AppraiseContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAppraise.AppraiseContent, objvViewpointAppraiseCond.AppraiseContent, strComparisonOpAppraiseContent);
}
if (objvViewpointAppraiseCond.IsUpdated(convViewpointAppraise.UpdDate) == true)
{
string strComparisonOpUpdDate = objvViewpointAppraiseCond.dicFldComparisonOp[convViewpointAppraise.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAppraise.UpdDate, objvViewpointAppraiseCond.UpdDate, strComparisonOpUpdDate);
}
if (objvViewpointAppraiseCond.IsUpdated(convViewpointAppraise.Memo) == true)
{
string strComparisonOpMemo = objvViewpointAppraiseCond.dicFldComparisonOp[convViewpointAppraise.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAppraise.Memo, objvViewpointAppraiseCond.Memo, strComparisonOpMemo);
}
if (objvViewpointAppraiseCond.IsUpdated(convViewpointAppraise.ViewpointName) == true)
{
string strComparisonOpViewpointName = objvViewpointAppraiseCond.dicFldComparisonOp[convViewpointAppraise.ViewpointName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAppraise.ViewpointName, objvViewpointAppraiseCond.ViewpointName, strComparisonOpViewpointName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvViewpointAppraiseCond.IsUpdated(convViewpointAppraise.UpdUser) == true)
{
string strComparisonOpUpdUser = objvViewpointAppraiseCond.dicFldComparisonOp[convViewpointAppraise.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAppraise.UpdUser, objvViewpointAppraiseCond.UpdUser, strComparisonOpUpdUser);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vViewpointAppraise(vViewpointAppraise), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ViewpointAppraiseId_ViewpointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvViewpointAppraiseEN objvViewpointAppraiseEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvViewpointAppraiseEN == null) return true;
if (objvViewpointAppraiseEN.ViewpointAppraiseId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewpointAppraiseId = '{0}'", objvViewpointAppraiseEN.ViewpointAppraiseId);
 if (objvViewpointAppraiseEN.ViewpointId == null)
{
 sbCondition.AppendFormat(" and ViewpointId is null", objvViewpointAppraiseEN.ViewpointId);
}
else
{
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objvViewpointAppraiseEN.ViewpointId);
}
if (clsvViewpointAppraiseBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ViewpointAppraiseId !=  {0}", objvViewpointAppraiseEN.ViewpointAppraiseId);
 sbCondition.AppendFormat(" and ViewpointAppraiseId = '{0}'", objvViewpointAppraiseEN.ViewpointAppraiseId);
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objvViewpointAppraiseEN.ViewpointId);
if (clsvViewpointAppraiseBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--vViewpointAppraise(vViewpointAppraise), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ViewpointAppraiseId_ViewpointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvViewpointAppraiseEN objvViewpointAppraiseEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvViewpointAppraiseEN == null) return "";
if (objvViewpointAppraiseEN.ViewpointAppraiseId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewpointAppraiseId = '{0}'", objvViewpointAppraiseEN.ViewpointAppraiseId);
 if (objvViewpointAppraiseEN.ViewpointId == null)
{
 sbCondition.AppendFormat(" and ViewpointId is null", objvViewpointAppraiseEN.ViewpointId);
}
else
{
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objvViewpointAppraiseEN.ViewpointId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ViewpointAppraiseId !=  {0}", objvViewpointAppraiseEN.ViewpointAppraiseId);
 sbCondition.AppendFormat(" and ViewpointAppraiseId = '{0}'", objvViewpointAppraiseEN.ViewpointAppraiseId);
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objvViewpointAppraiseEN.ViewpointId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vViewpointAppraise
{
public virtual bool UpdRelaTabDate(long lngViewpointAppraiseId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vViewpointAppraise(vViewpointAppraise)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvViewpointAppraiseBL
{
public static RelatedActions_vViewpointAppraise relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvViewpointAppraiseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvViewpointAppraiseDA vViewpointAppraiseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvViewpointAppraiseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvViewpointAppraiseBL()
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
if (string.IsNullOrEmpty(clsvViewpointAppraiseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewpointAppraiseEN._ConnectString);
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
public static DataTable GetDataTable_vViewpointAppraise(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vViewpointAppraiseDA.GetDataTable_vViewpointAppraise(strWhereCond);
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
objDT = vViewpointAppraiseDA.GetDataTable(strWhereCond);
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
objDT = vViewpointAppraiseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vViewpointAppraiseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vViewpointAppraiseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vViewpointAppraiseDA.GetDataTable_Top(objTopPara);
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
objDT = vViewpointAppraiseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vViewpointAppraiseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vViewpointAppraiseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrViewpointAppraiseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvViewpointAppraiseEN> GetObjLstByViewpointAppraiseIdLst(List<long> arrViewpointAppraiseIdLst)
{
List<clsvViewpointAppraiseEN> arrObjLst = new List<clsvViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrViewpointAppraiseIdLst);
 string strWhereCond = string.Format("ViewpointAppraiseId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointAppraiseEN objvViewpointAppraiseEN = new clsvViewpointAppraiseEN();
try
{
objvViewpointAppraiseEN.UserName = objRow[convViewpointAppraise.UserName] == DBNull.Value ? null : objRow[convViewpointAppraise.UserName].ToString().Trim(); //用户名
objvViewpointAppraiseEN.ViewpointAppraiseId = Int32.Parse(objRow[convViewpointAppraise.ViewpointAppraiseId].ToString().Trim()); //观点评论Id
objvViewpointAppraiseEN.ViewpointId = objRow[convViewpointAppraise.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAppraiseEN.AppraiseContent = objRow[convViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvViewpointAppraiseEN.UpdDate = objRow[convViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvViewpointAppraiseEN.Memo = objRow[convViewpointAppraise.Memo] == DBNull.Value ? null : objRow[convViewpointAppraise.Memo].ToString().Trim(); //备注
objvViewpointAppraiseEN.ViewpointName = objRow[convViewpointAppraise.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAppraiseEN.ViewpointContent = objRow[convViewpointAppraise.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAppraiseEN.Reason = objRow[convViewpointAppraise.Reason] == DBNull.Value ? null : objRow[convViewpointAppraise.Reason].ToString().Trim(); //理由
objvViewpointAppraiseEN.UpdUser = objRow[convViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointAppraiseEN.ViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewpointAppraiseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvViewpointAppraiseEN> GetObjLstByViewpointAppraiseIdLstCache(List<long> arrViewpointAppraiseIdLst)
{
string strKey = string.Format("{0}", clsvViewpointAppraiseEN._CurrTabName);
List<clsvViewpointAppraiseEN> arrvViewpointAppraiseObjLstCache = GetObjLstCache();
IEnumerable <clsvViewpointAppraiseEN> arrvViewpointAppraiseObjLst_Sel =
arrvViewpointAppraiseObjLstCache
.Where(x => arrViewpointAppraiseIdLst.Contains(x.ViewpointAppraiseId));
return arrvViewpointAppraiseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewpointAppraiseEN> GetObjLst(string strWhereCond)
{
List<clsvViewpointAppraiseEN> arrObjLst = new List<clsvViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointAppraiseEN objvViewpointAppraiseEN = new clsvViewpointAppraiseEN();
try
{
objvViewpointAppraiseEN.UserName = objRow[convViewpointAppraise.UserName] == DBNull.Value ? null : objRow[convViewpointAppraise.UserName].ToString().Trim(); //用户名
objvViewpointAppraiseEN.ViewpointAppraiseId = Int32.Parse(objRow[convViewpointAppraise.ViewpointAppraiseId].ToString().Trim()); //观点评论Id
objvViewpointAppraiseEN.ViewpointId = objRow[convViewpointAppraise.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAppraiseEN.AppraiseContent = objRow[convViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvViewpointAppraiseEN.UpdDate = objRow[convViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvViewpointAppraiseEN.Memo = objRow[convViewpointAppraise.Memo] == DBNull.Value ? null : objRow[convViewpointAppraise.Memo].ToString().Trim(); //备注
objvViewpointAppraiseEN.ViewpointName = objRow[convViewpointAppraise.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAppraiseEN.ViewpointContent = objRow[convViewpointAppraise.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAppraiseEN.Reason = objRow[convViewpointAppraise.Reason] == DBNull.Value ? null : objRow[convViewpointAppraise.Reason].ToString().Trim(); //理由
objvViewpointAppraiseEN.UpdUser = objRow[convViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointAppraiseEN.ViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointAppraiseEN);
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
public static List<clsvViewpointAppraiseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvViewpointAppraiseEN> arrObjLst = new List<clsvViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointAppraiseEN objvViewpointAppraiseEN = new clsvViewpointAppraiseEN();
try
{
objvViewpointAppraiseEN.UserName = objRow[convViewpointAppraise.UserName] == DBNull.Value ? null : objRow[convViewpointAppraise.UserName].ToString().Trim(); //用户名
objvViewpointAppraiseEN.ViewpointAppraiseId = Int32.Parse(objRow[convViewpointAppraise.ViewpointAppraiseId].ToString().Trim()); //观点评论Id
objvViewpointAppraiseEN.ViewpointId = objRow[convViewpointAppraise.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAppraiseEN.AppraiseContent = objRow[convViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvViewpointAppraiseEN.UpdDate = objRow[convViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvViewpointAppraiseEN.Memo = objRow[convViewpointAppraise.Memo] == DBNull.Value ? null : objRow[convViewpointAppraise.Memo].ToString().Trim(); //备注
objvViewpointAppraiseEN.ViewpointName = objRow[convViewpointAppraise.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAppraiseEN.ViewpointContent = objRow[convViewpointAppraise.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAppraiseEN.Reason = objRow[convViewpointAppraise.Reason] == DBNull.Value ? null : objRow[convViewpointAppraise.Reason].ToString().Trim(); //理由
objvViewpointAppraiseEN.UpdUser = objRow[convViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointAppraiseEN.ViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvViewpointAppraiseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvViewpointAppraiseEN> GetSubObjLstCache(clsvViewpointAppraiseEN objvViewpointAppraiseCond)
{
List<clsvViewpointAppraiseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvViewpointAppraiseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewpointAppraise.AttributeName)
{
if (objvViewpointAppraiseCond.IsUpdated(strFldName) == false) continue;
if (objvViewpointAppraiseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointAppraiseCond[strFldName].ToString());
}
else
{
if (objvViewpointAppraiseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewpointAppraiseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointAppraiseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewpointAppraiseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewpointAppraiseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewpointAppraiseCond[strFldName]));
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
public static List<clsvViewpointAppraiseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvViewpointAppraiseEN> arrObjLst = new List<clsvViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointAppraiseEN objvViewpointAppraiseEN = new clsvViewpointAppraiseEN();
try
{
objvViewpointAppraiseEN.UserName = objRow[convViewpointAppraise.UserName] == DBNull.Value ? null : objRow[convViewpointAppraise.UserName].ToString().Trim(); //用户名
objvViewpointAppraiseEN.ViewpointAppraiseId = Int32.Parse(objRow[convViewpointAppraise.ViewpointAppraiseId].ToString().Trim()); //观点评论Id
objvViewpointAppraiseEN.ViewpointId = objRow[convViewpointAppraise.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAppraiseEN.AppraiseContent = objRow[convViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvViewpointAppraiseEN.UpdDate = objRow[convViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvViewpointAppraiseEN.Memo = objRow[convViewpointAppraise.Memo] == DBNull.Value ? null : objRow[convViewpointAppraise.Memo].ToString().Trim(); //备注
objvViewpointAppraiseEN.ViewpointName = objRow[convViewpointAppraise.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAppraiseEN.ViewpointContent = objRow[convViewpointAppraise.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAppraiseEN.Reason = objRow[convViewpointAppraise.Reason] == DBNull.Value ? null : objRow[convViewpointAppraise.Reason].ToString().Trim(); //理由
objvViewpointAppraiseEN.UpdUser = objRow[convViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointAppraiseEN.ViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointAppraiseEN);
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
public static List<clsvViewpointAppraiseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvViewpointAppraiseEN> arrObjLst = new List<clsvViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointAppraiseEN objvViewpointAppraiseEN = new clsvViewpointAppraiseEN();
try
{
objvViewpointAppraiseEN.UserName = objRow[convViewpointAppraise.UserName] == DBNull.Value ? null : objRow[convViewpointAppraise.UserName].ToString().Trim(); //用户名
objvViewpointAppraiseEN.ViewpointAppraiseId = Int32.Parse(objRow[convViewpointAppraise.ViewpointAppraiseId].ToString().Trim()); //观点评论Id
objvViewpointAppraiseEN.ViewpointId = objRow[convViewpointAppraise.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAppraiseEN.AppraiseContent = objRow[convViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvViewpointAppraiseEN.UpdDate = objRow[convViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvViewpointAppraiseEN.Memo = objRow[convViewpointAppraise.Memo] == DBNull.Value ? null : objRow[convViewpointAppraise.Memo].ToString().Trim(); //备注
objvViewpointAppraiseEN.ViewpointName = objRow[convViewpointAppraise.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAppraiseEN.ViewpointContent = objRow[convViewpointAppraise.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAppraiseEN.Reason = objRow[convViewpointAppraise.Reason] == DBNull.Value ? null : objRow[convViewpointAppraise.Reason].ToString().Trim(); //理由
objvViewpointAppraiseEN.UpdUser = objRow[convViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointAppraiseEN.ViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointAppraiseEN);
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
List<clsvViewpointAppraiseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvViewpointAppraiseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewpointAppraiseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvViewpointAppraiseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvViewpointAppraiseEN> arrObjLst = new List<clsvViewpointAppraiseEN>(); 
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
	clsvViewpointAppraiseEN objvViewpointAppraiseEN = new clsvViewpointAppraiseEN();
try
{
objvViewpointAppraiseEN.UserName = objRow[convViewpointAppraise.UserName] == DBNull.Value ? null : objRow[convViewpointAppraise.UserName].ToString().Trim(); //用户名
objvViewpointAppraiseEN.ViewpointAppraiseId = Int32.Parse(objRow[convViewpointAppraise.ViewpointAppraiseId].ToString().Trim()); //观点评论Id
objvViewpointAppraiseEN.ViewpointId = objRow[convViewpointAppraise.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAppraiseEN.AppraiseContent = objRow[convViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvViewpointAppraiseEN.UpdDate = objRow[convViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvViewpointAppraiseEN.Memo = objRow[convViewpointAppraise.Memo] == DBNull.Value ? null : objRow[convViewpointAppraise.Memo].ToString().Trim(); //备注
objvViewpointAppraiseEN.ViewpointName = objRow[convViewpointAppraise.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAppraiseEN.ViewpointContent = objRow[convViewpointAppraise.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAppraiseEN.Reason = objRow[convViewpointAppraise.Reason] == DBNull.Value ? null : objRow[convViewpointAppraise.Reason].ToString().Trim(); //理由
objvViewpointAppraiseEN.UpdUser = objRow[convViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointAppraiseEN.ViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointAppraiseEN);
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
public static List<clsvViewpointAppraiseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvViewpointAppraiseEN> arrObjLst = new List<clsvViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointAppraiseEN objvViewpointAppraiseEN = new clsvViewpointAppraiseEN();
try
{
objvViewpointAppraiseEN.UserName = objRow[convViewpointAppraise.UserName] == DBNull.Value ? null : objRow[convViewpointAppraise.UserName].ToString().Trim(); //用户名
objvViewpointAppraiseEN.ViewpointAppraiseId = Int32.Parse(objRow[convViewpointAppraise.ViewpointAppraiseId].ToString().Trim()); //观点评论Id
objvViewpointAppraiseEN.ViewpointId = objRow[convViewpointAppraise.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAppraiseEN.AppraiseContent = objRow[convViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvViewpointAppraiseEN.UpdDate = objRow[convViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvViewpointAppraiseEN.Memo = objRow[convViewpointAppraise.Memo] == DBNull.Value ? null : objRow[convViewpointAppraise.Memo].ToString().Trim(); //备注
objvViewpointAppraiseEN.ViewpointName = objRow[convViewpointAppraise.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAppraiseEN.ViewpointContent = objRow[convViewpointAppraise.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAppraiseEN.Reason = objRow[convViewpointAppraise.Reason] == DBNull.Value ? null : objRow[convViewpointAppraise.Reason].ToString().Trim(); //理由
objvViewpointAppraiseEN.UpdUser = objRow[convViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointAppraiseEN.ViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvViewpointAppraiseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvViewpointAppraiseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvViewpointAppraiseEN> arrObjLst = new List<clsvViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointAppraiseEN objvViewpointAppraiseEN = new clsvViewpointAppraiseEN();
try
{
objvViewpointAppraiseEN.UserName = objRow[convViewpointAppraise.UserName] == DBNull.Value ? null : objRow[convViewpointAppraise.UserName].ToString().Trim(); //用户名
objvViewpointAppraiseEN.ViewpointAppraiseId = Int32.Parse(objRow[convViewpointAppraise.ViewpointAppraiseId].ToString().Trim()); //观点评论Id
objvViewpointAppraiseEN.ViewpointId = objRow[convViewpointAppraise.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAppraiseEN.AppraiseContent = objRow[convViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvViewpointAppraiseEN.UpdDate = objRow[convViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvViewpointAppraiseEN.Memo = objRow[convViewpointAppraise.Memo] == DBNull.Value ? null : objRow[convViewpointAppraise.Memo].ToString().Trim(); //备注
objvViewpointAppraiseEN.ViewpointName = objRow[convViewpointAppraise.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAppraiseEN.ViewpointContent = objRow[convViewpointAppraise.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAppraiseEN.Reason = objRow[convViewpointAppraise.Reason] == DBNull.Value ? null : objRow[convViewpointAppraise.Reason].ToString().Trim(); //理由
objvViewpointAppraiseEN.UpdUser = objRow[convViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointAppraiseEN.ViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointAppraiseEN);
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
public static List<clsvViewpointAppraiseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvViewpointAppraiseEN> arrObjLst = new List<clsvViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointAppraiseEN objvViewpointAppraiseEN = new clsvViewpointAppraiseEN();
try
{
objvViewpointAppraiseEN.UserName = objRow[convViewpointAppraise.UserName] == DBNull.Value ? null : objRow[convViewpointAppraise.UserName].ToString().Trim(); //用户名
objvViewpointAppraiseEN.ViewpointAppraiseId = Int32.Parse(objRow[convViewpointAppraise.ViewpointAppraiseId].ToString().Trim()); //观点评论Id
objvViewpointAppraiseEN.ViewpointId = objRow[convViewpointAppraise.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAppraiseEN.AppraiseContent = objRow[convViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvViewpointAppraiseEN.UpdDate = objRow[convViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvViewpointAppraiseEN.Memo = objRow[convViewpointAppraise.Memo] == DBNull.Value ? null : objRow[convViewpointAppraise.Memo].ToString().Trim(); //备注
objvViewpointAppraiseEN.ViewpointName = objRow[convViewpointAppraise.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAppraiseEN.ViewpointContent = objRow[convViewpointAppraise.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAppraiseEN.Reason = objRow[convViewpointAppraise.Reason] == DBNull.Value ? null : objRow[convViewpointAppraise.Reason].ToString().Trim(); //理由
objvViewpointAppraiseEN.UpdUser = objRow[convViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointAppraiseEN.ViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewpointAppraiseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvViewpointAppraiseEN> arrObjLst = new List<clsvViewpointAppraiseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointAppraiseEN objvViewpointAppraiseEN = new clsvViewpointAppraiseEN();
try
{
objvViewpointAppraiseEN.UserName = objRow[convViewpointAppraise.UserName] == DBNull.Value ? null : objRow[convViewpointAppraise.UserName].ToString().Trim(); //用户名
objvViewpointAppraiseEN.ViewpointAppraiseId = Int32.Parse(objRow[convViewpointAppraise.ViewpointAppraiseId].ToString().Trim()); //观点评论Id
objvViewpointAppraiseEN.ViewpointId = objRow[convViewpointAppraise.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAppraiseEN.AppraiseContent = objRow[convViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvViewpointAppraiseEN.UpdDate = objRow[convViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvViewpointAppraiseEN.Memo = objRow[convViewpointAppraise.Memo] == DBNull.Value ? null : objRow[convViewpointAppraise.Memo].ToString().Trim(); //备注
objvViewpointAppraiseEN.ViewpointName = objRow[convViewpointAppraise.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAppraiseEN.ViewpointContent = objRow[convViewpointAppraise.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAppraise.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAppraiseEN.Reason = objRow[convViewpointAppraise.Reason] == DBNull.Value ? null : objRow[convViewpointAppraise.Reason].ToString().Trim(); //理由
objvViewpointAppraiseEN.UpdUser = objRow[convViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointAppraiseEN.ViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointAppraiseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvViewpointAppraise(ref clsvViewpointAppraiseEN objvViewpointAppraiseEN)
{
bool bolResult = vViewpointAppraiseDA.GetvViewpointAppraise(ref objvViewpointAppraiseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngViewpointAppraiseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewpointAppraiseEN GetObjByViewpointAppraiseId(long lngViewpointAppraiseId)
{
clsvViewpointAppraiseEN objvViewpointAppraiseEN = vViewpointAppraiseDA.GetObjByViewpointAppraiseId(lngViewpointAppraiseId);
return objvViewpointAppraiseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvViewpointAppraiseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvViewpointAppraiseEN objvViewpointAppraiseEN = vViewpointAppraiseDA.GetFirstObj(strWhereCond);
 return objvViewpointAppraiseEN;
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
public static clsvViewpointAppraiseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvViewpointAppraiseEN objvViewpointAppraiseEN = vViewpointAppraiseDA.GetObjByDataRow(objRow);
 return objvViewpointAppraiseEN;
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
public static clsvViewpointAppraiseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvViewpointAppraiseEN objvViewpointAppraiseEN = vViewpointAppraiseDA.GetObjByDataRow(objRow);
 return objvViewpointAppraiseEN;
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
 /// <param name = "lngViewpointAppraiseId">所给的关键字</param>
 /// <param name = "lstvViewpointAppraiseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewpointAppraiseEN GetObjByViewpointAppraiseIdFromList(long lngViewpointAppraiseId, List<clsvViewpointAppraiseEN> lstvViewpointAppraiseObjLst)
{
foreach (clsvViewpointAppraiseEN objvViewpointAppraiseEN in lstvViewpointAppraiseObjLst)
{
if (objvViewpointAppraiseEN.ViewpointAppraiseId == lngViewpointAppraiseId)
{
return objvViewpointAppraiseEN;
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
 long lngViewpointAppraiseId;
 try
 {
 lngViewpointAppraiseId = new clsvViewpointAppraiseDA().GetFirstID(strWhereCond);
 return lngViewpointAppraiseId;
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
 arrList = vViewpointAppraiseDA.GetID(strWhereCond);
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
bool bolIsExist = vViewpointAppraiseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngViewpointAppraiseId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngViewpointAppraiseId)
{
//检测记录是否存在
bool bolIsExist = vViewpointAppraiseDA.IsExist(lngViewpointAppraiseId);
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
 bolIsExist = clsvViewpointAppraiseDA.IsExistTable();
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
 bolIsExist = vViewpointAppraiseDA.IsExistTable(strTabName);
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
 /// <param name = "objvViewpointAppraiseENS">源对象</param>
 /// <param name = "objvViewpointAppraiseENT">目标对象</param>
 public static void CopyTo(clsvViewpointAppraiseEN objvViewpointAppraiseENS, clsvViewpointAppraiseEN objvViewpointAppraiseENT)
{
try
{
objvViewpointAppraiseENT.UserName = objvViewpointAppraiseENS.UserName; //用户名
objvViewpointAppraiseENT.ViewpointAppraiseId = objvViewpointAppraiseENS.ViewpointAppraiseId; //观点评论Id
objvViewpointAppraiseENT.ViewpointId = objvViewpointAppraiseENS.ViewpointId; //观点Id
objvViewpointAppraiseENT.AppraiseContent = objvViewpointAppraiseENS.AppraiseContent; //评议内容
objvViewpointAppraiseENT.UpdDate = objvViewpointAppraiseENS.UpdDate; //修改日期
objvViewpointAppraiseENT.Memo = objvViewpointAppraiseENS.Memo; //备注
objvViewpointAppraiseENT.ViewpointName = objvViewpointAppraiseENS.ViewpointName; //观点名称
objvViewpointAppraiseENT.ViewpointContent = objvViewpointAppraiseENS.ViewpointContent; //观点内容
objvViewpointAppraiseENT.Reason = objvViewpointAppraiseENS.Reason; //理由
objvViewpointAppraiseENT.UpdUser = objvViewpointAppraiseENS.UpdUser; //修改人
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
 /// <param name = "objvViewpointAppraiseEN">源简化对象</param>
 public static void SetUpdFlag(clsvViewpointAppraiseEN objvViewpointAppraiseEN)
{
try
{
objvViewpointAppraiseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvViewpointAppraiseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convViewpointAppraise.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAppraiseEN.UserName = objvViewpointAppraiseEN.UserName == "[null]" ? null :  objvViewpointAppraiseEN.UserName; //用户名
}
if (arrFldSet.Contains(convViewpointAppraise.ViewpointAppraiseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAppraiseEN.ViewpointAppraiseId = objvViewpointAppraiseEN.ViewpointAppraiseId; //观点评论Id
}
if (arrFldSet.Contains(convViewpointAppraise.ViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAppraiseEN.ViewpointId = objvViewpointAppraiseEN.ViewpointId == "[null]" ? null :  objvViewpointAppraiseEN.ViewpointId; //观点Id
}
if (arrFldSet.Contains(convViewpointAppraise.AppraiseContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAppraiseEN.AppraiseContent = objvViewpointAppraiseEN.AppraiseContent == "[null]" ? null :  objvViewpointAppraiseEN.AppraiseContent; //评议内容
}
if (arrFldSet.Contains(convViewpointAppraise.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAppraiseEN.UpdDate = objvViewpointAppraiseEN.UpdDate == "[null]" ? null :  objvViewpointAppraiseEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convViewpointAppraise.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAppraiseEN.Memo = objvViewpointAppraiseEN.Memo == "[null]" ? null :  objvViewpointAppraiseEN.Memo; //备注
}
if (arrFldSet.Contains(convViewpointAppraise.ViewpointName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAppraiseEN.ViewpointName = objvViewpointAppraiseEN.ViewpointName == "[null]" ? null :  objvViewpointAppraiseEN.ViewpointName; //观点名称
}
if (arrFldSet.Contains(convViewpointAppraise.ViewpointContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAppraiseEN.ViewpointContent = objvViewpointAppraiseEN.ViewpointContent == "[null]" ? null :  objvViewpointAppraiseEN.ViewpointContent; //观点内容
}
if (arrFldSet.Contains(convViewpointAppraise.Reason, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAppraiseEN.Reason = objvViewpointAppraiseEN.Reason == "[null]" ? null :  objvViewpointAppraiseEN.Reason; //理由
}
if (arrFldSet.Contains(convViewpointAppraise.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAppraiseEN.UpdUser = objvViewpointAppraiseEN.UpdUser == "[null]" ? null :  objvViewpointAppraiseEN.UpdUser; //修改人
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
 /// <param name = "objvViewpointAppraiseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvViewpointAppraiseEN objvViewpointAppraiseEN)
{
try
{
if (objvViewpointAppraiseEN.UserName == "[null]") objvViewpointAppraiseEN.UserName = null; //用户名
if (objvViewpointAppraiseEN.ViewpointId == "[null]") objvViewpointAppraiseEN.ViewpointId = null; //观点Id
if (objvViewpointAppraiseEN.AppraiseContent == "[null]") objvViewpointAppraiseEN.AppraiseContent = null; //评议内容
if (objvViewpointAppraiseEN.UpdDate == "[null]") objvViewpointAppraiseEN.UpdDate = null; //修改日期
if (objvViewpointAppraiseEN.Memo == "[null]") objvViewpointAppraiseEN.Memo = null; //备注
if (objvViewpointAppraiseEN.ViewpointName == "[null]") objvViewpointAppraiseEN.ViewpointName = null; //观点名称
if (objvViewpointAppraiseEN.ViewpointContent == "[null]") objvViewpointAppraiseEN.ViewpointContent = null; //观点内容
if (objvViewpointAppraiseEN.Reason == "[null]") objvViewpointAppraiseEN.Reason = null; //理由
if (objvViewpointAppraiseEN.UpdUser == "[null]") objvViewpointAppraiseEN.UpdUser = null; //修改人
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
public static void CheckProperty4Condition(clsvViewpointAppraiseEN objvViewpointAppraiseEN)
{
 vViewpointAppraiseDA.CheckProperty4Condition(objvViewpointAppraiseEN);
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
if (clsViewpointAppraiseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewpointAppraiseBL没有刷新缓存机制(clsViewpointAppraiseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ViewpointAppraiseId");
//if (arrvViewpointAppraiseObjLstCache == null)
//{
//arrvViewpointAppraiseObjLstCache = vViewpointAppraiseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngViewpointAppraiseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewpointAppraiseEN GetObjByViewpointAppraiseIdCache(long lngViewpointAppraiseId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvViewpointAppraiseEN._CurrTabName);
List<clsvViewpointAppraiseEN> arrvViewpointAppraiseObjLstCache = GetObjLstCache();
IEnumerable <clsvViewpointAppraiseEN> arrvViewpointAppraiseObjLst_Sel =
arrvViewpointAppraiseObjLstCache
.Where(x=> x.ViewpointAppraiseId == lngViewpointAppraiseId 
);
if (arrvViewpointAppraiseObjLst_Sel.Count() == 0)
{
   clsvViewpointAppraiseEN obj = clsvViewpointAppraiseBL.GetObjByViewpointAppraiseId(lngViewpointAppraiseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvViewpointAppraiseObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewpointAppraiseEN> GetAllvViewpointAppraiseObjLstCache()
{
//获取缓存中的对象列表
List<clsvViewpointAppraiseEN> arrvViewpointAppraiseObjLstCache = GetObjLstCache(); 
return arrvViewpointAppraiseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewpointAppraiseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvViewpointAppraiseEN._CurrTabName);
List<clsvViewpointAppraiseEN> arrvViewpointAppraiseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvViewpointAppraiseObjLstCache;
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
string strKey = string.Format("{0}", clsvViewpointAppraiseEN._CurrTabName);
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
 /// 获取检查唯一性条件串(Uniqueness)--vViewpointAppraise(vViewpointAppraise)
 /// 唯一性条件:ViewpointAppraiseId_ViewpointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvViewpointAppraiseEN objvViewpointAppraiseEN)
{
//检测记录是否存在
string strResult = vViewpointAppraiseDA.GetUniCondStr(objvViewpointAppraiseEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngViewpointAppraiseId)
{
if (strInFldName != convViewpointAppraise.ViewpointAppraiseId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convViewpointAppraise.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convViewpointAppraise.AttributeName));
throw new Exception(strMsg);
}
var objvViewpointAppraise = clsvViewpointAppraiseBL.GetObjByViewpointAppraiseIdCache(lngViewpointAppraiseId);
if (objvViewpointAppraise == null) return "";
return objvViewpointAppraise[strOutFldName].ToString();
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
int intRecCount = clsvViewpointAppraiseDA.GetRecCount(strTabName);
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
int intRecCount = clsvViewpointAppraiseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvViewpointAppraiseDA.GetRecCount();
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
int intRecCount = clsvViewpointAppraiseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvViewpointAppraiseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvViewpointAppraiseEN objvViewpointAppraiseCond)
{
List<clsvViewpointAppraiseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvViewpointAppraiseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewpointAppraise.AttributeName)
{
if (objvViewpointAppraiseCond.IsUpdated(strFldName) == false) continue;
if (objvViewpointAppraiseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointAppraiseCond[strFldName].ToString());
}
else
{
if (objvViewpointAppraiseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewpointAppraiseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointAppraiseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewpointAppraiseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewpointAppraiseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewpointAppraiseCond[strFldName]));
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
 List<string> arrList = clsvViewpointAppraiseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vViewpointAppraiseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vViewpointAppraiseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}