
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewpointScoreBL
 表名:vViewpointScore(01120609)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:06
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研究生培养(GraduateEdu)
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
public static class  clsvViewpointScoreBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngViewpointScoreId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewpointScoreEN GetObj(this K_ViewpointScoreId_vViewpointScore myKey)
{
clsvViewpointScoreEN objvViewpointScoreEN = clsvViewpointScoreBL.vViewpointScoreDA.GetObjByViewpointScoreId(myKey.Value);
return objvViewpointScoreEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointScoreEN SetViewpointScoreId(this clsvViewpointScoreEN objvViewpointScoreEN, long lngViewpointScoreId, string strComparisonOp="")
	{
objvViewpointScoreEN.ViewpointScoreId = lngViewpointScoreId; //评分Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointScoreEN.dicFldComparisonOp.ContainsKey(convViewpointScore.ViewpointScoreId) == false)
{
objvViewpointScoreEN.dicFldComparisonOp.Add(convViewpointScore.ViewpointScoreId, strComparisonOp);
}
else
{
objvViewpointScoreEN.dicFldComparisonOp[convViewpointScore.ViewpointScoreId] = strComparisonOp;
}
}
return objvViewpointScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointScoreEN SetViewpointScore(this clsvViewpointScoreEN objvViewpointScoreEN, float? fltViewpointScore, string strComparisonOp="")
	{
objvViewpointScoreEN.ViewpointScore = fltViewpointScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointScoreEN.dicFldComparisonOp.ContainsKey(convViewpointScore.ViewpointScore) == false)
{
objvViewpointScoreEN.dicFldComparisonOp.Add(convViewpointScore.ViewpointScore, strComparisonOp);
}
else
{
objvViewpointScoreEN.dicFldComparisonOp[convViewpointScore.ViewpointScore] = strComparisonOp;
}
}
return objvViewpointScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointScoreEN SetViewpointId(this clsvViewpointScoreEN objvViewpointScoreEN, string strViewpointId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointId, 8, convViewpointScore.ViewpointId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewpointId, 8, convViewpointScore.ViewpointId);
}
objvViewpointScoreEN.ViewpointId = strViewpointId; //观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointScoreEN.dicFldComparisonOp.ContainsKey(convViewpointScore.ViewpointId) == false)
{
objvViewpointScoreEN.dicFldComparisonOp.Add(convViewpointScore.ViewpointId, strComparisonOp);
}
else
{
objvViewpointScoreEN.dicFldComparisonOp[convViewpointScore.ViewpointId] = strComparisonOp;
}
}
return objvViewpointScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointScoreEN SetUpdDate(this clsvViewpointScoreEN objvViewpointScoreEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewpointScore.UpdDate);
}
objvViewpointScoreEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointScoreEN.dicFldComparisonOp.ContainsKey(convViewpointScore.UpdDate) == false)
{
objvViewpointScoreEN.dicFldComparisonOp.Add(convViewpointScore.UpdDate, strComparisonOp);
}
else
{
objvViewpointScoreEN.dicFldComparisonOp[convViewpointScore.UpdDate] = strComparisonOp;
}
}
return objvViewpointScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointScoreEN SetUpdUserId(this clsvViewpointScoreEN objvViewpointScoreEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convViewpointScore.UpdUserId);
}
objvViewpointScoreEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointScoreEN.dicFldComparisonOp.ContainsKey(convViewpointScore.UpdUserId) == false)
{
objvViewpointScoreEN.dicFldComparisonOp.Add(convViewpointScore.UpdUserId, strComparisonOp);
}
else
{
objvViewpointScoreEN.dicFldComparisonOp[convViewpointScore.UpdUserId] = strComparisonOp;
}
}
return objvViewpointScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointScoreEN SetMemo(this clsvViewpointScoreEN objvViewpointScoreEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convViewpointScore.Memo);
}
objvViewpointScoreEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointScoreEN.dicFldComparisonOp.ContainsKey(convViewpointScore.Memo) == false)
{
objvViewpointScoreEN.dicFldComparisonOp.Add(convViewpointScore.Memo, strComparisonOp);
}
else
{
objvViewpointScoreEN.dicFldComparisonOp[convViewpointScore.Memo] = strComparisonOp;
}
}
return objvViewpointScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointScoreEN SetUserName(this clsvViewpointScoreEN objvViewpointScoreEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convViewpointScore.UserName);
}
objvViewpointScoreEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointScoreEN.dicFldComparisonOp.ContainsKey(convViewpointScore.UserName) == false)
{
objvViewpointScoreEN.dicFldComparisonOp.Add(convViewpointScore.UserName, strComparisonOp);
}
else
{
objvViewpointScoreEN.dicFldComparisonOp[convViewpointScore.UserName] = strComparisonOp;
}
}
return objvViewpointScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointScoreEN SetViewpointName(this clsvViewpointScoreEN objvViewpointScoreEN, string strViewpointName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointName, 500, convViewpointScore.ViewpointName);
}
objvViewpointScoreEN.ViewpointName = strViewpointName; //观点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointScoreEN.dicFldComparisonOp.ContainsKey(convViewpointScore.ViewpointName) == false)
{
objvViewpointScoreEN.dicFldComparisonOp.Add(convViewpointScore.ViewpointName, strComparisonOp);
}
else
{
objvViewpointScoreEN.dicFldComparisonOp[convViewpointScore.ViewpointName] = strComparisonOp;
}
}
return objvViewpointScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointScoreEN SetViewpointContent(this clsvViewpointScoreEN objvViewpointScoreEN, string strViewpointContent, string strComparisonOp="")
	{
objvViewpointScoreEN.ViewpointContent = strViewpointContent; //观点内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointScoreEN.dicFldComparisonOp.ContainsKey(convViewpointScore.ViewpointContent) == false)
{
objvViewpointScoreEN.dicFldComparisonOp.Add(convViewpointScore.ViewpointContent, strComparisonOp);
}
else
{
objvViewpointScoreEN.dicFldComparisonOp[convViewpointScore.ViewpointContent] = strComparisonOp;
}
}
return objvViewpointScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointScoreEN SetReason(this clsvViewpointScoreEN objvViewpointScoreEN, string strReason, string strComparisonOp="")
	{
objvViewpointScoreEN.Reason = strReason; //理由
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointScoreEN.dicFldComparisonOp.ContainsKey(convViewpointScore.Reason) == false)
{
objvViewpointScoreEN.dicFldComparisonOp.Add(convViewpointScore.Reason, strComparisonOp);
}
else
{
objvViewpointScoreEN.dicFldComparisonOp[convViewpointScore.Reason] = strComparisonOp;
}
}
return objvViewpointScoreEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvViewpointScoreENS">源对象</param>
 /// <param name = "objvViewpointScoreENT">目标对象</param>
 public static void CopyTo(this clsvViewpointScoreEN objvViewpointScoreENS, clsvViewpointScoreEN objvViewpointScoreENT)
{
try
{
objvViewpointScoreENT.ViewpointScoreId = objvViewpointScoreENS.ViewpointScoreId; //评分Id
objvViewpointScoreENT.ViewpointScore = objvViewpointScoreENS.ViewpointScore; //评分
objvViewpointScoreENT.ViewpointId = objvViewpointScoreENS.ViewpointId; //观点Id
objvViewpointScoreENT.UpdDate = objvViewpointScoreENS.UpdDate; //修改日期
objvViewpointScoreENT.UpdUserId = objvViewpointScoreENS.UpdUserId; //修改用户Id
objvViewpointScoreENT.Memo = objvViewpointScoreENS.Memo; //备注
objvViewpointScoreENT.UserName = objvViewpointScoreENS.UserName; //用户名
objvViewpointScoreENT.ViewpointName = objvViewpointScoreENS.ViewpointName; //观点名称
objvViewpointScoreENT.ViewpointContent = objvViewpointScoreENS.ViewpointContent; //观点内容
objvViewpointScoreENT.Reason = objvViewpointScoreENS.Reason; //理由
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
 /// <param name = "objvViewpointScoreENS">源对象</param>
 /// <returns>目标对象=>clsvViewpointScoreEN:objvViewpointScoreENT</returns>
 public static clsvViewpointScoreEN CopyTo(this clsvViewpointScoreEN objvViewpointScoreENS)
{
try
{
 clsvViewpointScoreEN objvViewpointScoreENT = new clsvViewpointScoreEN()
{
ViewpointScoreId = objvViewpointScoreENS.ViewpointScoreId, //评分Id
ViewpointScore = objvViewpointScoreENS.ViewpointScore, //评分
ViewpointId = objvViewpointScoreENS.ViewpointId, //观点Id
UpdDate = objvViewpointScoreENS.UpdDate, //修改日期
UpdUserId = objvViewpointScoreENS.UpdUserId, //修改用户Id
Memo = objvViewpointScoreENS.Memo, //备注
UserName = objvViewpointScoreENS.UserName, //用户名
ViewpointName = objvViewpointScoreENS.ViewpointName, //观点名称
ViewpointContent = objvViewpointScoreENS.ViewpointContent, //观点内容
Reason = objvViewpointScoreENS.Reason, //理由
};
 return objvViewpointScoreENT;
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
public static void CheckProperty4Condition(this clsvViewpointScoreEN objvViewpointScoreEN)
{
 clsvViewpointScoreBL.vViewpointScoreDA.CheckProperty4Condition(objvViewpointScoreEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvViewpointScoreEN objvViewpointScoreCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvViewpointScoreCond.IsUpdated(convViewpointScore.ViewpointScoreId) == true)
{
string strComparisonOpViewpointScoreId = objvViewpointScoreCond.dicFldComparisonOp[convViewpointScore.ViewpointScoreId];
strWhereCond += string.Format(" And {0} {2} {1}", convViewpointScore.ViewpointScoreId, objvViewpointScoreCond.ViewpointScoreId, strComparisonOpViewpointScoreId);
}
if (objvViewpointScoreCond.IsUpdated(convViewpointScore.ViewpointScore) == true)
{
string strComparisonOpViewpointScore = objvViewpointScoreCond.dicFldComparisonOp[convViewpointScore.ViewpointScore];
strWhereCond += string.Format(" And {0} {2} {1}", convViewpointScore.ViewpointScore, objvViewpointScoreCond.ViewpointScore, strComparisonOpViewpointScore);
}
if (objvViewpointScoreCond.IsUpdated(convViewpointScore.ViewpointId) == true)
{
string strComparisonOpViewpointId = objvViewpointScoreCond.dicFldComparisonOp[convViewpointScore.ViewpointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointScore.ViewpointId, objvViewpointScoreCond.ViewpointId, strComparisonOpViewpointId);
}
if (objvViewpointScoreCond.IsUpdated(convViewpointScore.UpdDate) == true)
{
string strComparisonOpUpdDate = objvViewpointScoreCond.dicFldComparisonOp[convViewpointScore.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointScore.UpdDate, objvViewpointScoreCond.UpdDate, strComparisonOpUpdDate);
}
if (objvViewpointScoreCond.IsUpdated(convViewpointScore.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvViewpointScoreCond.dicFldComparisonOp[convViewpointScore.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointScore.UpdUserId, objvViewpointScoreCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvViewpointScoreCond.IsUpdated(convViewpointScore.Memo) == true)
{
string strComparisonOpMemo = objvViewpointScoreCond.dicFldComparisonOp[convViewpointScore.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointScore.Memo, objvViewpointScoreCond.Memo, strComparisonOpMemo);
}
if (objvViewpointScoreCond.IsUpdated(convViewpointScore.UserName) == true)
{
string strComparisonOpUserName = objvViewpointScoreCond.dicFldComparisonOp[convViewpointScore.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointScore.UserName, objvViewpointScoreCond.UserName, strComparisonOpUserName);
}
if (objvViewpointScoreCond.IsUpdated(convViewpointScore.ViewpointName) == true)
{
string strComparisonOpViewpointName = objvViewpointScoreCond.dicFldComparisonOp[convViewpointScore.ViewpointName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointScore.ViewpointName, objvViewpointScoreCond.ViewpointName, strComparisonOpViewpointName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vViewpointScore(vViewpointScore), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ViewpointScoreId_ViewpointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvViewpointScoreEN objvViewpointScoreEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvViewpointScoreEN == null) return true;
if (objvViewpointScoreEN.ViewpointScoreId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewpointScoreId = '{0}'", objvViewpointScoreEN.ViewpointScoreId);
 if (objvViewpointScoreEN.ViewpointId == null)
{
 sbCondition.AppendFormat(" and ViewpointId is null", objvViewpointScoreEN.ViewpointId);
}
else
{
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objvViewpointScoreEN.ViewpointId);
}
if (clsvViewpointScoreBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ViewpointScoreId !=  {0}", objvViewpointScoreEN.ViewpointScoreId);
 sbCondition.AppendFormat(" and ViewpointScoreId = '{0}'", objvViewpointScoreEN.ViewpointScoreId);
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objvViewpointScoreEN.ViewpointId);
if (clsvViewpointScoreBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--vViewpointScore(vViewpointScore), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ViewpointScoreId_ViewpointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvViewpointScoreEN objvViewpointScoreEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvViewpointScoreEN == null) return "";
if (objvViewpointScoreEN.ViewpointScoreId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewpointScoreId = '{0}'", objvViewpointScoreEN.ViewpointScoreId);
 if (objvViewpointScoreEN.ViewpointId == null)
{
 sbCondition.AppendFormat(" and ViewpointId is null", objvViewpointScoreEN.ViewpointId);
}
else
{
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objvViewpointScoreEN.ViewpointId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ViewpointScoreId !=  {0}", objvViewpointScoreEN.ViewpointScoreId);
 sbCondition.AppendFormat(" and ViewpointScoreId = '{0}'", objvViewpointScoreEN.ViewpointScoreId);
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objvViewpointScoreEN.ViewpointId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vViewpointScore
{
public virtual bool UpdRelaTabDate(long lngViewpointScoreId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vViewpointScore(vViewpointScore)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvViewpointScoreBL
{
public static RelatedActions_vViewpointScore relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvViewpointScoreDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvViewpointScoreDA vViewpointScoreDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvViewpointScoreDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvViewpointScoreBL()
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
if (string.IsNullOrEmpty(clsvViewpointScoreEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewpointScoreEN._ConnectString);
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
public static DataTable GetDataTable_vViewpointScore(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vViewpointScoreDA.GetDataTable_vViewpointScore(strWhereCond);
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
objDT = vViewpointScoreDA.GetDataTable(strWhereCond);
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
objDT = vViewpointScoreDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vViewpointScoreDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vViewpointScoreDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vViewpointScoreDA.GetDataTable_Top(objTopPara);
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
objDT = vViewpointScoreDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vViewpointScoreDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vViewpointScoreDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrViewpointScoreIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvViewpointScoreEN> GetObjLstByViewpointScoreIdLst(List<long> arrViewpointScoreIdLst)
{
List<clsvViewpointScoreEN> arrObjLst = new List<clsvViewpointScoreEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrViewpointScoreIdLst);
 string strWhereCond = string.Format("ViewpointScoreId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointScoreEN objvViewpointScoreEN = new clsvViewpointScoreEN();
try
{
objvViewpointScoreEN.ViewpointScoreId = Int32.Parse(objRow[convViewpointScore.ViewpointScoreId].ToString().Trim()); //评分Id
objvViewpointScoreEN.ViewpointScore = objRow[convViewpointScore.ViewpointScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpointScore.ViewpointScore].ToString().Trim()); //评分
objvViewpointScoreEN.ViewpointId = objRow[convViewpointScore.ViewpointId] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointId].ToString().Trim(); //观点Id
objvViewpointScoreEN.UpdDate = objRow[convViewpointScore.UpdDate] == DBNull.Value ? null : objRow[convViewpointScore.UpdDate].ToString().Trim(); //修改日期
objvViewpointScoreEN.UpdUserId = objRow[convViewpointScore.UpdUserId] == DBNull.Value ? null : objRow[convViewpointScore.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointScoreEN.Memo = objRow[convViewpointScore.Memo] == DBNull.Value ? null : objRow[convViewpointScore.Memo].ToString().Trim(); //备注
objvViewpointScoreEN.UserName = objRow[convViewpointScore.UserName] == DBNull.Value ? null : objRow[convViewpointScore.UserName].ToString().Trim(); //用户名
objvViewpointScoreEN.ViewpointName = objRow[convViewpointScore.ViewpointName] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointName].ToString().Trim(); //观点名称
objvViewpointScoreEN.ViewpointContent = objRow[convViewpointScore.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointScoreEN.Reason = objRow[convViewpointScore.Reason] == DBNull.Value ? null : objRow[convViewpointScore.Reason].ToString().Trim(); //理由
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointScoreEN.ViewpointScoreId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointScoreEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewpointScoreIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvViewpointScoreEN> GetObjLstByViewpointScoreIdLstCache(List<long> arrViewpointScoreIdLst)
{
string strKey = string.Format("{0}", clsvViewpointScoreEN._CurrTabName);
List<clsvViewpointScoreEN> arrvViewpointScoreObjLstCache = GetObjLstCache();
IEnumerable <clsvViewpointScoreEN> arrvViewpointScoreObjLst_Sel =
arrvViewpointScoreObjLstCache
.Where(x => arrViewpointScoreIdLst.Contains(x.ViewpointScoreId));
return arrvViewpointScoreObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewpointScoreEN> GetObjLst(string strWhereCond)
{
List<clsvViewpointScoreEN> arrObjLst = new List<clsvViewpointScoreEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointScoreEN objvViewpointScoreEN = new clsvViewpointScoreEN();
try
{
objvViewpointScoreEN.ViewpointScoreId = Int32.Parse(objRow[convViewpointScore.ViewpointScoreId].ToString().Trim()); //评分Id
objvViewpointScoreEN.ViewpointScore = objRow[convViewpointScore.ViewpointScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpointScore.ViewpointScore].ToString().Trim()); //评分
objvViewpointScoreEN.ViewpointId = objRow[convViewpointScore.ViewpointId] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointId].ToString().Trim(); //观点Id
objvViewpointScoreEN.UpdDate = objRow[convViewpointScore.UpdDate] == DBNull.Value ? null : objRow[convViewpointScore.UpdDate].ToString().Trim(); //修改日期
objvViewpointScoreEN.UpdUserId = objRow[convViewpointScore.UpdUserId] == DBNull.Value ? null : objRow[convViewpointScore.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointScoreEN.Memo = objRow[convViewpointScore.Memo] == DBNull.Value ? null : objRow[convViewpointScore.Memo].ToString().Trim(); //备注
objvViewpointScoreEN.UserName = objRow[convViewpointScore.UserName] == DBNull.Value ? null : objRow[convViewpointScore.UserName].ToString().Trim(); //用户名
objvViewpointScoreEN.ViewpointName = objRow[convViewpointScore.ViewpointName] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointName].ToString().Trim(); //观点名称
objvViewpointScoreEN.ViewpointContent = objRow[convViewpointScore.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointScoreEN.Reason = objRow[convViewpointScore.Reason] == DBNull.Value ? null : objRow[convViewpointScore.Reason].ToString().Trim(); //理由
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointScoreEN.ViewpointScoreId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointScoreEN);
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
public static List<clsvViewpointScoreEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvViewpointScoreEN> arrObjLst = new List<clsvViewpointScoreEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointScoreEN objvViewpointScoreEN = new clsvViewpointScoreEN();
try
{
objvViewpointScoreEN.ViewpointScoreId = Int32.Parse(objRow[convViewpointScore.ViewpointScoreId].ToString().Trim()); //评分Id
objvViewpointScoreEN.ViewpointScore = objRow[convViewpointScore.ViewpointScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpointScore.ViewpointScore].ToString().Trim()); //评分
objvViewpointScoreEN.ViewpointId = objRow[convViewpointScore.ViewpointId] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointId].ToString().Trim(); //观点Id
objvViewpointScoreEN.UpdDate = objRow[convViewpointScore.UpdDate] == DBNull.Value ? null : objRow[convViewpointScore.UpdDate].ToString().Trim(); //修改日期
objvViewpointScoreEN.UpdUserId = objRow[convViewpointScore.UpdUserId] == DBNull.Value ? null : objRow[convViewpointScore.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointScoreEN.Memo = objRow[convViewpointScore.Memo] == DBNull.Value ? null : objRow[convViewpointScore.Memo].ToString().Trim(); //备注
objvViewpointScoreEN.UserName = objRow[convViewpointScore.UserName] == DBNull.Value ? null : objRow[convViewpointScore.UserName].ToString().Trim(); //用户名
objvViewpointScoreEN.ViewpointName = objRow[convViewpointScore.ViewpointName] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointName].ToString().Trim(); //观点名称
objvViewpointScoreEN.ViewpointContent = objRow[convViewpointScore.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointScoreEN.Reason = objRow[convViewpointScore.Reason] == DBNull.Value ? null : objRow[convViewpointScore.Reason].ToString().Trim(); //理由
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointScoreEN.ViewpointScoreId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointScoreEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvViewpointScoreCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvViewpointScoreEN> GetSubObjLstCache(clsvViewpointScoreEN objvViewpointScoreCond)
{
List<clsvViewpointScoreEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvViewpointScoreEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewpointScore.AttributeName)
{
if (objvViewpointScoreCond.IsUpdated(strFldName) == false) continue;
if (objvViewpointScoreCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointScoreCond[strFldName].ToString());
}
else
{
if (objvViewpointScoreCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewpointScoreCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointScoreCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewpointScoreCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewpointScoreCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewpointScoreCond[strFldName]));
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
public static List<clsvViewpointScoreEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvViewpointScoreEN> arrObjLst = new List<clsvViewpointScoreEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointScoreEN objvViewpointScoreEN = new clsvViewpointScoreEN();
try
{
objvViewpointScoreEN.ViewpointScoreId = Int32.Parse(objRow[convViewpointScore.ViewpointScoreId].ToString().Trim()); //评分Id
objvViewpointScoreEN.ViewpointScore = objRow[convViewpointScore.ViewpointScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpointScore.ViewpointScore].ToString().Trim()); //评分
objvViewpointScoreEN.ViewpointId = objRow[convViewpointScore.ViewpointId] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointId].ToString().Trim(); //观点Id
objvViewpointScoreEN.UpdDate = objRow[convViewpointScore.UpdDate] == DBNull.Value ? null : objRow[convViewpointScore.UpdDate].ToString().Trim(); //修改日期
objvViewpointScoreEN.UpdUserId = objRow[convViewpointScore.UpdUserId] == DBNull.Value ? null : objRow[convViewpointScore.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointScoreEN.Memo = objRow[convViewpointScore.Memo] == DBNull.Value ? null : objRow[convViewpointScore.Memo].ToString().Trim(); //备注
objvViewpointScoreEN.UserName = objRow[convViewpointScore.UserName] == DBNull.Value ? null : objRow[convViewpointScore.UserName].ToString().Trim(); //用户名
objvViewpointScoreEN.ViewpointName = objRow[convViewpointScore.ViewpointName] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointName].ToString().Trim(); //观点名称
objvViewpointScoreEN.ViewpointContent = objRow[convViewpointScore.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointScoreEN.Reason = objRow[convViewpointScore.Reason] == DBNull.Value ? null : objRow[convViewpointScore.Reason].ToString().Trim(); //理由
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointScoreEN.ViewpointScoreId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointScoreEN);
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
public static List<clsvViewpointScoreEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvViewpointScoreEN> arrObjLst = new List<clsvViewpointScoreEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointScoreEN objvViewpointScoreEN = new clsvViewpointScoreEN();
try
{
objvViewpointScoreEN.ViewpointScoreId = Int32.Parse(objRow[convViewpointScore.ViewpointScoreId].ToString().Trim()); //评分Id
objvViewpointScoreEN.ViewpointScore = objRow[convViewpointScore.ViewpointScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpointScore.ViewpointScore].ToString().Trim()); //评分
objvViewpointScoreEN.ViewpointId = objRow[convViewpointScore.ViewpointId] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointId].ToString().Trim(); //观点Id
objvViewpointScoreEN.UpdDate = objRow[convViewpointScore.UpdDate] == DBNull.Value ? null : objRow[convViewpointScore.UpdDate].ToString().Trim(); //修改日期
objvViewpointScoreEN.UpdUserId = objRow[convViewpointScore.UpdUserId] == DBNull.Value ? null : objRow[convViewpointScore.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointScoreEN.Memo = objRow[convViewpointScore.Memo] == DBNull.Value ? null : objRow[convViewpointScore.Memo].ToString().Trim(); //备注
objvViewpointScoreEN.UserName = objRow[convViewpointScore.UserName] == DBNull.Value ? null : objRow[convViewpointScore.UserName].ToString().Trim(); //用户名
objvViewpointScoreEN.ViewpointName = objRow[convViewpointScore.ViewpointName] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointName].ToString().Trim(); //观点名称
objvViewpointScoreEN.ViewpointContent = objRow[convViewpointScore.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointScoreEN.Reason = objRow[convViewpointScore.Reason] == DBNull.Value ? null : objRow[convViewpointScore.Reason].ToString().Trim(); //理由
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointScoreEN.ViewpointScoreId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointScoreEN);
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
List<clsvViewpointScoreEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvViewpointScoreEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewpointScoreEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvViewpointScoreEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvViewpointScoreEN> arrObjLst = new List<clsvViewpointScoreEN>(); 
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
	clsvViewpointScoreEN objvViewpointScoreEN = new clsvViewpointScoreEN();
try
{
objvViewpointScoreEN.ViewpointScoreId = Int32.Parse(objRow[convViewpointScore.ViewpointScoreId].ToString().Trim()); //评分Id
objvViewpointScoreEN.ViewpointScore = objRow[convViewpointScore.ViewpointScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpointScore.ViewpointScore].ToString().Trim()); //评分
objvViewpointScoreEN.ViewpointId = objRow[convViewpointScore.ViewpointId] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointId].ToString().Trim(); //观点Id
objvViewpointScoreEN.UpdDate = objRow[convViewpointScore.UpdDate] == DBNull.Value ? null : objRow[convViewpointScore.UpdDate].ToString().Trim(); //修改日期
objvViewpointScoreEN.UpdUserId = objRow[convViewpointScore.UpdUserId] == DBNull.Value ? null : objRow[convViewpointScore.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointScoreEN.Memo = objRow[convViewpointScore.Memo] == DBNull.Value ? null : objRow[convViewpointScore.Memo].ToString().Trim(); //备注
objvViewpointScoreEN.UserName = objRow[convViewpointScore.UserName] == DBNull.Value ? null : objRow[convViewpointScore.UserName].ToString().Trim(); //用户名
objvViewpointScoreEN.ViewpointName = objRow[convViewpointScore.ViewpointName] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointName].ToString().Trim(); //观点名称
objvViewpointScoreEN.ViewpointContent = objRow[convViewpointScore.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointScoreEN.Reason = objRow[convViewpointScore.Reason] == DBNull.Value ? null : objRow[convViewpointScore.Reason].ToString().Trim(); //理由
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointScoreEN.ViewpointScoreId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointScoreEN);
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
public static List<clsvViewpointScoreEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvViewpointScoreEN> arrObjLst = new List<clsvViewpointScoreEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointScoreEN objvViewpointScoreEN = new clsvViewpointScoreEN();
try
{
objvViewpointScoreEN.ViewpointScoreId = Int32.Parse(objRow[convViewpointScore.ViewpointScoreId].ToString().Trim()); //评分Id
objvViewpointScoreEN.ViewpointScore = objRow[convViewpointScore.ViewpointScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpointScore.ViewpointScore].ToString().Trim()); //评分
objvViewpointScoreEN.ViewpointId = objRow[convViewpointScore.ViewpointId] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointId].ToString().Trim(); //观点Id
objvViewpointScoreEN.UpdDate = objRow[convViewpointScore.UpdDate] == DBNull.Value ? null : objRow[convViewpointScore.UpdDate].ToString().Trim(); //修改日期
objvViewpointScoreEN.UpdUserId = objRow[convViewpointScore.UpdUserId] == DBNull.Value ? null : objRow[convViewpointScore.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointScoreEN.Memo = objRow[convViewpointScore.Memo] == DBNull.Value ? null : objRow[convViewpointScore.Memo].ToString().Trim(); //备注
objvViewpointScoreEN.UserName = objRow[convViewpointScore.UserName] == DBNull.Value ? null : objRow[convViewpointScore.UserName].ToString().Trim(); //用户名
objvViewpointScoreEN.ViewpointName = objRow[convViewpointScore.ViewpointName] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointName].ToString().Trim(); //观点名称
objvViewpointScoreEN.ViewpointContent = objRow[convViewpointScore.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointScoreEN.Reason = objRow[convViewpointScore.Reason] == DBNull.Value ? null : objRow[convViewpointScore.Reason].ToString().Trim(); //理由
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointScoreEN.ViewpointScoreId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointScoreEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvViewpointScoreEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvViewpointScoreEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvViewpointScoreEN> arrObjLst = new List<clsvViewpointScoreEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointScoreEN objvViewpointScoreEN = new clsvViewpointScoreEN();
try
{
objvViewpointScoreEN.ViewpointScoreId = Int32.Parse(objRow[convViewpointScore.ViewpointScoreId].ToString().Trim()); //评分Id
objvViewpointScoreEN.ViewpointScore = objRow[convViewpointScore.ViewpointScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpointScore.ViewpointScore].ToString().Trim()); //评分
objvViewpointScoreEN.ViewpointId = objRow[convViewpointScore.ViewpointId] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointId].ToString().Trim(); //观点Id
objvViewpointScoreEN.UpdDate = objRow[convViewpointScore.UpdDate] == DBNull.Value ? null : objRow[convViewpointScore.UpdDate].ToString().Trim(); //修改日期
objvViewpointScoreEN.UpdUserId = objRow[convViewpointScore.UpdUserId] == DBNull.Value ? null : objRow[convViewpointScore.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointScoreEN.Memo = objRow[convViewpointScore.Memo] == DBNull.Value ? null : objRow[convViewpointScore.Memo].ToString().Trim(); //备注
objvViewpointScoreEN.UserName = objRow[convViewpointScore.UserName] == DBNull.Value ? null : objRow[convViewpointScore.UserName].ToString().Trim(); //用户名
objvViewpointScoreEN.ViewpointName = objRow[convViewpointScore.ViewpointName] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointName].ToString().Trim(); //观点名称
objvViewpointScoreEN.ViewpointContent = objRow[convViewpointScore.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointScoreEN.Reason = objRow[convViewpointScore.Reason] == DBNull.Value ? null : objRow[convViewpointScore.Reason].ToString().Trim(); //理由
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointScoreEN.ViewpointScoreId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointScoreEN);
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
public static List<clsvViewpointScoreEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvViewpointScoreEN> arrObjLst = new List<clsvViewpointScoreEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointScoreEN objvViewpointScoreEN = new clsvViewpointScoreEN();
try
{
objvViewpointScoreEN.ViewpointScoreId = Int32.Parse(objRow[convViewpointScore.ViewpointScoreId].ToString().Trim()); //评分Id
objvViewpointScoreEN.ViewpointScore = objRow[convViewpointScore.ViewpointScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpointScore.ViewpointScore].ToString().Trim()); //评分
objvViewpointScoreEN.ViewpointId = objRow[convViewpointScore.ViewpointId] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointId].ToString().Trim(); //观点Id
objvViewpointScoreEN.UpdDate = objRow[convViewpointScore.UpdDate] == DBNull.Value ? null : objRow[convViewpointScore.UpdDate].ToString().Trim(); //修改日期
objvViewpointScoreEN.UpdUserId = objRow[convViewpointScore.UpdUserId] == DBNull.Value ? null : objRow[convViewpointScore.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointScoreEN.Memo = objRow[convViewpointScore.Memo] == DBNull.Value ? null : objRow[convViewpointScore.Memo].ToString().Trim(); //备注
objvViewpointScoreEN.UserName = objRow[convViewpointScore.UserName] == DBNull.Value ? null : objRow[convViewpointScore.UserName].ToString().Trim(); //用户名
objvViewpointScoreEN.ViewpointName = objRow[convViewpointScore.ViewpointName] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointName].ToString().Trim(); //观点名称
objvViewpointScoreEN.ViewpointContent = objRow[convViewpointScore.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointScoreEN.Reason = objRow[convViewpointScore.Reason] == DBNull.Value ? null : objRow[convViewpointScore.Reason].ToString().Trim(); //理由
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointScoreEN.ViewpointScoreId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointScoreEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewpointScoreEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvViewpointScoreEN> arrObjLst = new List<clsvViewpointScoreEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointScoreEN objvViewpointScoreEN = new clsvViewpointScoreEN();
try
{
objvViewpointScoreEN.ViewpointScoreId = Int32.Parse(objRow[convViewpointScore.ViewpointScoreId].ToString().Trim()); //评分Id
objvViewpointScoreEN.ViewpointScore = objRow[convViewpointScore.ViewpointScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpointScore.ViewpointScore].ToString().Trim()); //评分
objvViewpointScoreEN.ViewpointId = objRow[convViewpointScore.ViewpointId] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointId].ToString().Trim(); //观点Id
objvViewpointScoreEN.UpdDate = objRow[convViewpointScore.UpdDate] == DBNull.Value ? null : objRow[convViewpointScore.UpdDate].ToString().Trim(); //修改日期
objvViewpointScoreEN.UpdUserId = objRow[convViewpointScore.UpdUserId] == DBNull.Value ? null : objRow[convViewpointScore.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointScoreEN.Memo = objRow[convViewpointScore.Memo] == DBNull.Value ? null : objRow[convViewpointScore.Memo].ToString().Trim(); //备注
objvViewpointScoreEN.UserName = objRow[convViewpointScore.UserName] == DBNull.Value ? null : objRow[convViewpointScore.UserName].ToString().Trim(); //用户名
objvViewpointScoreEN.ViewpointName = objRow[convViewpointScore.ViewpointName] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointName].ToString().Trim(); //观点名称
objvViewpointScoreEN.ViewpointContent = objRow[convViewpointScore.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointScore.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointScoreEN.Reason = objRow[convViewpointScore.Reason] == DBNull.Value ? null : objRow[convViewpointScore.Reason].ToString().Trim(); //理由
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointScoreEN.ViewpointScoreId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointScoreEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvViewpointScore(ref clsvViewpointScoreEN objvViewpointScoreEN)
{
bool bolResult = vViewpointScoreDA.GetvViewpointScore(ref objvViewpointScoreEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngViewpointScoreId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewpointScoreEN GetObjByViewpointScoreId(long lngViewpointScoreId)
{
clsvViewpointScoreEN objvViewpointScoreEN = vViewpointScoreDA.GetObjByViewpointScoreId(lngViewpointScoreId);
return objvViewpointScoreEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvViewpointScoreEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvViewpointScoreEN objvViewpointScoreEN = vViewpointScoreDA.GetFirstObj(strWhereCond);
 return objvViewpointScoreEN;
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
public static clsvViewpointScoreEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvViewpointScoreEN objvViewpointScoreEN = vViewpointScoreDA.GetObjByDataRow(objRow);
 return objvViewpointScoreEN;
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
public static clsvViewpointScoreEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvViewpointScoreEN objvViewpointScoreEN = vViewpointScoreDA.GetObjByDataRow(objRow);
 return objvViewpointScoreEN;
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
 /// <param name = "lngViewpointScoreId">所给的关键字</param>
 /// <param name = "lstvViewpointScoreObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewpointScoreEN GetObjByViewpointScoreIdFromList(long lngViewpointScoreId, List<clsvViewpointScoreEN> lstvViewpointScoreObjLst)
{
foreach (clsvViewpointScoreEN objvViewpointScoreEN in lstvViewpointScoreObjLst)
{
if (objvViewpointScoreEN.ViewpointScoreId == lngViewpointScoreId)
{
return objvViewpointScoreEN;
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
 long lngViewpointScoreId;
 try
 {
 lngViewpointScoreId = new clsvViewpointScoreDA().GetFirstID(strWhereCond);
 return lngViewpointScoreId;
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
 arrList = vViewpointScoreDA.GetID(strWhereCond);
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
bool bolIsExist = vViewpointScoreDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngViewpointScoreId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngViewpointScoreId)
{
//检测记录是否存在
bool bolIsExist = vViewpointScoreDA.IsExist(lngViewpointScoreId);
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
 bolIsExist = clsvViewpointScoreDA.IsExistTable();
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
 bolIsExist = vViewpointScoreDA.IsExistTable(strTabName);
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
 /// <param name = "objvViewpointScoreENS">源对象</param>
 /// <param name = "objvViewpointScoreENT">目标对象</param>
 public static void CopyTo(clsvViewpointScoreEN objvViewpointScoreENS, clsvViewpointScoreEN objvViewpointScoreENT)
{
try
{
objvViewpointScoreENT.ViewpointScoreId = objvViewpointScoreENS.ViewpointScoreId; //评分Id
objvViewpointScoreENT.ViewpointScore = objvViewpointScoreENS.ViewpointScore; //评分
objvViewpointScoreENT.ViewpointId = objvViewpointScoreENS.ViewpointId; //观点Id
objvViewpointScoreENT.UpdDate = objvViewpointScoreENS.UpdDate; //修改日期
objvViewpointScoreENT.UpdUserId = objvViewpointScoreENS.UpdUserId; //修改用户Id
objvViewpointScoreENT.Memo = objvViewpointScoreENS.Memo; //备注
objvViewpointScoreENT.UserName = objvViewpointScoreENS.UserName; //用户名
objvViewpointScoreENT.ViewpointName = objvViewpointScoreENS.ViewpointName; //观点名称
objvViewpointScoreENT.ViewpointContent = objvViewpointScoreENS.ViewpointContent; //观点内容
objvViewpointScoreENT.Reason = objvViewpointScoreENS.Reason; //理由
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
 /// <param name = "objvViewpointScoreEN">源简化对象</param>
 public static void SetUpdFlag(clsvViewpointScoreEN objvViewpointScoreEN)
{
try
{
objvViewpointScoreEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvViewpointScoreEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convViewpointScore.ViewpointScoreId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointScoreEN.ViewpointScoreId = objvViewpointScoreEN.ViewpointScoreId; //评分Id
}
if (arrFldSet.Contains(convViewpointScore.ViewpointScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointScoreEN.ViewpointScore = objvViewpointScoreEN.ViewpointScore; //评分
}
if (arrFldSet.Contains(convViewpointScore.ViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointScoreEN.ViewpointId = objvViewpointScoreEN.ViewpointId == "[null]" ? null :  objvViewpointScoreEN.ViewpointId; //观点Id
}
if (arrFldSet.Contains(convViewpointScore.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointScoreEN.UpdDate = objvViewpointScoreEN.UpdDate == "[null]" ? null :  objvViewpointScoreEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convViewpointScore.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointScoreEN.UpdUserId = objvViewpointScoreEN.UpdUserId == "[null]" ? null :  objvViewpointScoreEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convViewpointScore.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointScoreEN.Memo = objvViewpointScoreEN.Memo == "[null]" ? null :  objvViewpointScoreEN.Memo; //备注
}
if (arrFldSet.Contains(convViewpointScore.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointScoreEN.UserName = objvViewpointScoreEN.UserName == "[null]" ? null :  objvViewpointScoreEN.UserName; //用户名
}
if (arrFldSet.Contains(convViewpointScore.ViewpointName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointScoreEN.ViewpointName = objvViewpointScoreEN.ViewpointName == "[null]" ? null :  objvViewpointScoreEN.ViewpointName; //观点名称
}
if (arrFldSet.Contains(convViewpointScore.ViewpointContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointScoreEN.ViewpointContent = objvViewpointScoreEN.ViewpointContent == "[null]" ? null :  objvViewpointScoreEN.ViewpointContent; //观点内容
}
if (arrFldSet.Contains(convViewpointScore.Reason, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointScoreEN.Reason = objvViewpointScoreEN.Reason == "[null]" ? null :  objvViewpointScoreEN.Reason; //理由
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
 /// <param name = "objvViewpointScoreEN">源简化对象</param>
 public static void AccessFldValueNull(clsvViewpointScoreEN objvViewpointScoreEN)
{
try
{
if (objvViewpointScoreEN.ViewpointId == "[null]") objvViewpointScoreEN.ViewpointId = null; //观点Id
if (objvViewpointScoreEN.UpdDate == "[null]") objvViewpointScoreEN.UpdDate = null; //修改日期
if (objvViewpointScoreEN.UpdUserId == "[null]") objvViewpointScoreEN.UpdUserId = null; //修改用户Id
if (objvViewpointScoreEN.Memo == "[null]") objvViewpointScoreEN.Memo = null; //备注
if (objvViewpointScoreEN.UserName == "[null]") objvViewpointScoreEN.UserName = null; //用户名
if (objvViewpointScoreEN.ViewpointName == "[null]") objvViewpointScoreEN.ViewpointName = null; //观点名称
if (objvViewpointScoreEN.ViewpointContent == "[null]") objvViewpointScoreEN.ViewpointContent = null; //观点内容
if (objvViewpointScoreEN.Reason == "[null]") objvViewpointScoreEN.Reason = null; //理由
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
public static void CheckProperty4Condition(clsvViewpointScoreEN objvViewpointScoreEN)
{
 vViewpointScoreDA.CheckProperty4Condition(objvViewpointScoreEN);
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
if (clsViewpointScoreBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewpointScoreBL没有刷新缓存机制(clsViewpointScoreBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ViewpointScoreId");
//if (arrvViewpointScoreObjLstCache == null)
//{
//arrvViewpointScoreObjLstCache = vViewpointScoreDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngViewpointScoreId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewpointScoreEN GetObjByViewpointScoreIdCache(long lngViewpointScoreId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvViewpointScoreEN._CurrTabName);
List<clsvViewpointScoreEN> arrvViewpointScoreObjLstCache = GetObjLstCache();
IEnumerable <clsvViewpointScoreEN> arrvViewpointScoreObjLst_Sel =
arrvViewpointScoreObjLstCache
.Where(x=> x.ViewpointScoreId == lngViewpointScoreId 
);
if (arrvViewpointScoreObjLst_Sel.Count() == 0)
{
   clsvViewpointScoreEN obj = clsvViewpointScoreBL.GetObjByViewpointScoreId(lngViewpointScoreId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvViewpointScoreObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewpointScoreEN> GetAllvViewpointScoreObjLstCache()
{
//获取缓存中的对象列表
List<clsvViewpointScoreEN> arrvViewpointScoreObjLstCache = GetObjLstCache(); 
return arrvViewpointScoreObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewpointScoreEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvViewpointScoreEN._CurrTabName);
List<clsvViewpointScoreEN> arrvViewpointScoreObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvViewpointScoreObjLstCache;
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
string strKey = string.Format("{0}", clsvViewpointScoreEN._CurrTabName);
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
 /// 获取检查唯一性条件串(Uniqueness)--vViewpointScore(vViewpointScore)
 /// 唯一性条件:ViewpointScoreId_ViewpointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvViewpointScoreEN objvViewpointScoreEN)
{
//检测记录是否存在
string strResult = vViewpointScoreDA.GetUniCondStr(objvViewpointScoreEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngViewpointScoreId)
{
if (strInFldName != convViewpointScore.ViewpointScoreId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convViewpointScore.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convViewpointScore.AttributeName));
throw new Exception(strMsg);
}
var objvViewpointScore = clsvViewpointScoreBL.GetObjByViewpointScoreIdCache(lngViewpointScoreId);
if (objvViewpointScore == null) return "";
return objvViewpointScore[strOutFldName].ToString();
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
int intRecCount = clsvViewpointScoreDA.GetRecCount(strTabName);
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
int intRecCount = clsvViewpointScoreDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvViewpointScoreDA.GetRecCount();
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
int intRecCount = clsvViewpointScoreDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvViewpointScoreCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvViewpointScoreEN objvViewpointScoreCond)
{
List<clsvViewpointScoreEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvViewpointScoreEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewpointScore.AttributeName)
{
if (objvViewpointScoreCond.IsUpdated(strFldName) == false) continue;
if (objvViewpointScoreCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointScoreCond[strFldName].ToString());
}
else
{
if (objvViewpointScoreCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewpointScoreCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointScoreCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewpointScoreCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewpointScoreCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewpointScoreCond[strFldName]));
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
 List<string> arrList = clsvViewpointScoreDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vViewpointScoreDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vViewpointScoreDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}