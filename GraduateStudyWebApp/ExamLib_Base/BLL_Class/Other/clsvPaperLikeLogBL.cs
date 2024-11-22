
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperLikeLogBL
 表名:vPaperLikeLog(01120570)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:24
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:其他(Other)
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
public static class  clsvPaperLikeLogBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperLikeLogId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperLikeLogEN GetObj(this K_PaperLikeLogId_vPaperLikeLog myKey)
{
clsvPaperLikeLogEN objvPaperLikeLogEN = clsvPaperLikeLogBL.vPaperLikeLogDA.GetObjByPaperLikeLogId(myKey.Value);
return objvPaperLikeLogEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperLikeLogEN SetPaperLikeLogId(this clsvPaperLikeLogEN objvPaperLikeLogEN, long lngPaperLikeLogId, string strComparisonOp="")
	{
objvPaperLikeLogEN.PaperLikeLogId = lngPaperLikeLogId; //论文点赞表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperLikeLog.PaperLikeLogId) == false)
{
objvPaperLikeLogEN.dicFldComparisonOp.Add(convPaperLikeLog.PaperLikeLogId, strComparisonOp);
}
else
{
objvPaperLikeLogEN.dicFldComparisonOp[convPaperLikeLog.PaperLikeLogId] = strComparisonOp;
}
}
return objvPaperLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperLikeLogEN SetPaperId(this clsvPaperLikeLogEN objvPaperLikeLogEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convPaperLikeLog.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convPaperLikeLog.PaperId);
}
objvPaperLikeLogEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperLikeLog.PaperId) == false)
{
objvPaperLikeLogEN.dicFldComparisonOp.Add(convPaperLikeLog.PaperId, strComparisonOp);
}
else
{
objvPaperLikeLogEN.dicFldComparisonOp[convPaperLikeLog.PaperId] = strComparisonOp;
}
}
return objvPaperLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperLikeLogEN SetUpdUser(this clsvPaperLikeLogEN objvPaperLikeLogEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convPaperLikeLog.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPaperLikeLog.UpdUser);
}
objvPaperLikeLogEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperLikeLog.UpdUser) == false)
{
objvPaperLikeLogEN.dicFldComparisonOp.Add(convPaperLikeLog.UpdUser, strComparisonOp);
}
else
{
objvPaperLikeLogEN.dicFldComparisonOp[convPaperLikeLog.UpdUser] = strComparisonOp;
}
}
return objvPaperLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperLikeLogEN SetUpdDate(this clsvPaperLikeLogEN objvPaperLikeLogEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPaperLikeLog.UpdDate);
}
objvPaperLikeLogEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperLikeLog.UpdDate) == false)
{
objvPaperLikeLogEN.dicFldComparisonOp.Add(convPaperLikeLog.UpdDate, strComparisonOp);
}
else
{
objvPaperLikeLogEN.dicFldComparisonOp[convPaperLikeLog.UpdDate] = strComparisonOp;
}
}
return objvPaperLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperLikeLogEN SetMemo(this clsvPaperLikeLogEN objvPaperLikeLogEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPaperLikeLog.Memo);
}
objvPaperLikeLogEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperLikeLog.Memo) == false)
{
objvPaperLikeLogEN.dicFldComparisonOp.Add(convPaperLikeLog.Memo, strComparisonOp);
}
else
{
objvPaperLikeLogEN.dicFldComparisonOp[convPaperLikeLog.Memo] = strComparisonOp;
}
}
return objvPaperLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperLikeLogEN SetPaperTitle(this clsvPaperLikeLogEN objvPaperLikeLogEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convPaperLikeLog.PaperTitle);
}
objvPaperLikeLogEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperLikeLog.PaperTitle) == false)
{
objvPaperLikeLogEN.dicFldComparisonOp.Add(convPaperLikeLog.PaperTitle, strComparisonOp);
}
else
{
objvPaperLikeLogEN.dicFldComparisonOp[convPaperLikeLog.PaperTitle] = strComparisonOp;
}
}
return objvPaperLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperLikeLogEN SetAuthor(this clsvPaperLikeLogEN objvPaperLikeLogEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convPaperLikeLog.Author);
}
objvPaperLikeLogEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperLikeLog.Author) == false)
{
objvPaperLikeLogEN.dicFldComparisonOp.Add(convPaperLikeLog.Author, strComparisonOp);
}
else
{
objvPaperLikeLogEN.dicFldComparisonOp[convPaperLikeLog.Author] = strComparisonOp;
}
}
return objvPaperLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperLikeLogEN SetKeyword(this clsvPaperLikeLogEN objvPaperLikeLogEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convPaperLikeLog.Keyword);
}
objvPaperLikeLogEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperLikeLog.Keyword) == false)
{
objvPaperLikeLogEN.dicFldComparisonOp.Add(convPaperLikeLog.Keyword, strComparisonOp);
}
else
{
objvPaperLikeLogEN.dicFldComparisonOp[convPaperLikeLog.Keyword] = strComparisonOp;
}
}
return objvPaperLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperLikeLogEN SetBrowseNumber(this clsvPaperLikeLogEN objvPaperLikeLogEN, int? intBrowseNumber, string strComparisonOp="")
	{
objvPaperLikeLogEN.BrowseNumber = intBrowseNumber; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperLikeLog.BrowseNumber) == false)
{
objvPaperLikeLogEN.dicFldComparisonOp.Add(convPaperLikeLog.BrowseNumber, strComparisonOp);
}
else
{
objvPaperLikeLogEN.dicFldComparisonOp[convPaperLikeLog.BrowseNumber] = strComparisonOp;
}
}
return objvPaperLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperLikeLogEN SetUserName(this clsvPaperLikeLogEN objvPaperLikeLogEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convPaperLikeLog.UserName);
}
objvPaperLikeLogEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperLikeLog.UserName) == false)
{
objvPaperLikeLogEN.dicFldComparisonOp.Add(convPaperLikeLog.UserName, strComparisonOp);
}
else
{
objvPaperLikeLogEN.dicFldComparisonOp[convPaperLikeLog.UserName] = strComparisonOp;
}
}
return objvPaperLikeLogEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPaperLikeLogENS">源对象</param>
 /// <param name = "objvPaperLikeLogENT">目标对象</param>
 public static void CopyTo(this clsvPaperLikeLogEN objvPaperLikeLogENS, clsvPaperLikeLogEN objvPaperLikeLogENT)
{
try
{
objvPaperLikeLogENT.PaperLikeLogId = objvPaperLikeLogENS.PaperLikeLogId; //论文点赞表Id
objvPaperLikeLogENT.PaperId = objvPaperLikeLogENS.PaperId; //论文Id
objvPaperLikeLogENT.UpdUser = objvPaperLikeLogENS.UpdUser; //修改人
objvPaperLikeLogENT.UpdDate = objvPaperLikeLogENS.UpdDate; //修改日期
objvPaperLikeLogENT.Memo = objvPaperLikeLogENS.Memo; //备注
objvPaperLikeLogENT.PaperTitle = objvPaperLikeLogENS.PaperTitle; //论文标题
objvPaperLikeLogENT.Author = objvPaperLikeLogENS.Author; //作者
objvPaperLikeLogENT.Keyword = objvPaperLikeLogENS.Keyword; //关键字
objvPaperLikeLogENT.BrowseNumber = objvPaperLikeLogENS.BrowseNumber; //浏览量
objvPaperLikeLogENT.UserName = objvPaperLikeLogENS.UserName; //用户名
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
 /// <param name = "objvPaperLikeLogENS">源对象</param>
 /// <returns>目标对象=>clsvPaperLikeLogEN:objvPaperLikeLogENT</returns>
 public static clsvPaperLikeLogEN CopyTo(this clsvPaperLikeLogEN objvPaperLikeLogENS)
{
try
{
 clsvPaperLikeLogEN objvPaperLikeLogENT = new clsvPaperLikeLogEN()
{
PaperLikeLogId = objvPaperLikeLogENS.PaperLikeLogId, //论文点赞表Id
PaperId = objvPaperLikeLogENS.PaperId, //论文Id
UpdUser = objvPaperLikeLogENS.UpdUser, //修改人
UpdDate = objvPaperLikeLogENS.UpdDate, //修改日期
Memo = objvPaperLikeLogENS.Memo, //备注
PaperTitle = objvPaperLikeLogENS.PaperTitle, //论文标题
Author = objvPaperLikeLogENS.Author, //作者
Keyword = objvPaperLikeLogENS.Keyword, //关键字
BrowseNumber = objvPaperLikeLogENS.BrowseNumber, //浏览量
UserName = objvPaperLikeLogENS.UserName, //用户名
};
 return objvPaperLikeLogENT;
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
public static void CheckProperty4Condition(this clsvPaperLikeLogEN objvPaperLikeLogEN)
{
 clsvPaperLikeLogBL.vPaperLikeLogDA.CheckProperty4Condition(objvPaperLikeLogEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPaperLikeLogEN objvPaperLikeLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPaperLikeLogCond.IsUpdated(convPaperLikeLog.PaperLikeLogId) == true)
{
string strComparisonOpPaperLikeLogId = objvPaperLikeLogCond.dicFldComparisonOp[convPaperLikeLog.PaperLikeLogId];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperLikeLog.PaperLikeLogId, objvPaperLikeLogCond.PaperLikeLogId, strComparisonOpPaperLikeLogId);
}
if (objvPaperLikeLogCond.IsUpdated(convPaperLikeLog.PaperId) == true)
{
string strComparisonOpPaperId = objvPaperLikeLogCond.dicFldComparisonOp[convPaperLikeLog.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperLikeLog.PaperId, objvPaperLikeLogCond.PaperId, strComparisonOpPaperId);
}
if (objvPaperLikeLogCond.IsUpdated(convPaperLikeLog.UpdUser) == true)
{
string strComparisonOpUpdUser = objvPaperLikeLogCond.dicFldComparisonOp[convPaperLikeLog.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperLikeLog.UpdUser, objvPaperLikeLogCond.UpdUser, strComparisonOpUpdUser);
}
if (objvPaperLikeLogCond.IsUpdated(convPaperLikeLog.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPaperLikeLogCond.dicFldComparisonOp[convPaperLikeLog.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperLikeLog.UpdDate, objvPaperLikeLogCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPaperLikeLogCond.IsUpdated(convPaperLikeLog.Memo) == true)
{
string strComparisonOpMemo = objvPaperLikeLogCond.dicFldComparisonOp[convPaperLikeLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperLikeLog.Memo, objvPaperLikeLogCond.Memo, strComparisonOpMemo);
}
if (objvPaperLikeLogCond.IsUpdated(convPaperLikeLog.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvPaperLikeLogCond.dicFldComparisonOp[convPaperLikeLog.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperLikeLog.PaperTitle, objvPaperLikeLogCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvPaperLikeLogCond.IsUpdated(convPaperLikeLog.Author) == true)
{
string strComparisonOpAuthor = objvPaperLikeLogCond.dicFldComparisonOp[convPaperLikeLog.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperLikeLog.Author, objvPaperLikeLogCond.Author, strComparisonOpAuthor);
}
if (objvPaperLikeLogCond.IsUpdated(convPaperLikeLog.Keyword) == true)
{
string strComparisonOpKeyword = objvPaperLikeLogCond.dicFldComparisonOp[convPaperLikeLog.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperLikeLog.Keyword, objvPaperLikeLogCond.Keyword, strComparisonOpKeyword);
}
if (objvPaperLikeLogCond.IsUpdated(convPaperLikeLog.BrowseNumber) == true)
{
string strComparisonOpBrowseNumber = objvPaperLikeLogCond.dicFldComparisonOp[convPaperLikeLog.BrowseNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperLikeLog.BrowseNumber, objvPaperLikeLogCond.BrowseNumber, strComparisonOpBrowseNumber);
}
if (objvPaperLikeLogCond.IsUpdated(convPaperLikeLog.UserName) == true)
{
string strComparisonOpUserName = objvPaperLikeLogCond.dicFldComparisonOp[convPaperLikeLog.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperLikeLog.UserName, objvPaperLikeLogCond.UserName, strComparisonOpUserName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPaperLikeLog
{
public virtual bool UpdRelaTabDate(long lngPaperLikeLogId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v论文点赞表(vPaperLikeLog)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPaperLikeLogBL
{
public static RelatedActions_vPaperLikeLog relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPaperLikeLogDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPaperLikeLogDA vPaperLikeLogDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPaperLikeLogDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPaperLikeLogBL()
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
if (string.IsNullOrEmpty(clsvPaperLikeLogEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPaperLikeLogEN._ConnectString);
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
public static DataTable GetDataTable_vPaperLikeLog(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPaperLikeLogDA.GetDataTable_vPaperLikeLog(strWhereCond);
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
objDT = vPaperLikeLogDA.GetDataTable(strWhereCond);
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
objDT = vPaperLikeLogDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPaperLikeLogDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPaperLikeLogDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPaperLikeLogDA.GetDataTable_Top(objTopPara);
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
objDT = vPaperLikeLogDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPaperLikeLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPaperLikeLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPaperLikeLogIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPaperLikeLogEN> GetObjLstByPaperLikeLogIdLst(List<long> arrPaperLikeLogIdLst)
{
List<clsvPaperLikeLogEN> arrObjLst = new List<clsvPaperLikeLogEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPaperLikeLogIdLst);
 string strWhereCond = string.Format("PaperLikeLogId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperLikeLogEN objvPaperLikeLogEN = new clsvPaperLikeLogEN();
try
{
objvPaperLikeLogEN.PaperLikeLogId = Int32.Parse(objRow[convPaperLikeLog.PaperLikeLogId].ToString().Trim()); //论文点赞表Id
objvPaperLikeLogEN.PaperId = objRow[convPaperLikeLog.PaperId] == DBNull.Value ? null : objRow[convPaperLikeLog.PaperId].ToString().Trim(); //论文Id
objvPaperLikeLogEN.UpdUser = objRow[convPaperLikeLog.UpdUser].ToString().Trim(); //修改人
objvPaperLikeLogEN.UpdDate = objRow[convPaperLikeLog.UpdDate] == DBNull.Value ? null : objRow[convPaperLikeLog.UpdDate].ToString().Trim(); //修改日期
objvPaperLikeLogEN.Memo = objRow[convPaperLikeLog.Memo] == DBNull.Value ? null : objRow[convPaperLikeLog.Memo].ToString().Trim(); //备注
objvPaperLikeLogEN.PaperTitle = objRow[convPaperLikeLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperLikeLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperLikeLogEN.Author = objRow[convPaperLikeLog.Author] == DBNull.Value ? null : objRow[convPaperLikeLog.Author].ToString().Trim(); //作者
objvPaperLikeLogEN.Keyword = objRow[convPaperLikeLog.Keyword] == DBNull.Value ? null : objRow[convPaperLikeLog.Keyword].ToString().Trim(); //关键字
objvPaperLikeLogEN.BrowseNumber = objRow[convPaperLikeLog.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperLikeLog.BrowseNumber].ToString().Trim()); //浏览量
objvPaperLikeLogEN.UserName = objRow[convPaperLikeLog.UserName] == DBNull.Value ? null : objRow[convPaperLikeLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperLikeLogEN.PaperLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperLikeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperLikeLogIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPaperLikeLogEN> GetObjLstByPaperLikeLogIdLstCache(List<long> arrPaperLikeLogIdLst)
{
string strKey = string.Format("{0}", clsvPaperLikeLogEN._CurrTabName);
List<clsvPaperLikeLogEN> arrvPaperLikeLogObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperLikeLogEN> arrvPaperLikeLogObjLst_Sel =
arrvPaperLikeLogObjLstCache
.Where(x => arrPaperLikeLogIdLst.Contains(x.PaperLikeLogId));
return arrvPaperLikeLogObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperLikeLogEN> GetObjLst(string strWhereCond)
{
List<clsvPaperLikeLogEN> arrObjLst = new List<clsvPaperLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperLikeLogEN objvPaperLikeLogEN = new clsvPaperLikeLogEN();
try
{
objvPaperLikeLogEN.PaperLikeLogId = Int32.Parse(objRow[convPaperLikeLog.PaperLikeLogId].ToString().Trim()); //论文点赞表Id
objvPaperLikeLogEN.PaperId = objRow[convPaperLikeLog.PaperId] == DBNull.Value ? null : objRow[convPaperLikeLog.PaperId].ToString().Trim(); //论文Id
objvPaperLikeLogEN.UpdUser = objRow[convPaperLikeLog.UpdUser].ToString().Trim(); //修改人
objvPaperLikeLogEN.UpdDate = objRow[convPaperLikeLog.UpdDate] == DBNull.Value ? null : objRow[convPaperLikeLog.UpdDate].ToString().Trim(); //修改日期
objvPaperLikeLogEN.Memo = objRow[convPaperLikeLog.Memo] == DBNull.Value ? null : objRow[convPaperLikeLog.Memo].ToString().Trim(); //备注
objvPaperLikeLogEN.PaperTitle = objRow[convPaperLikeLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperLikeLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperLikeLogEN.Author = objRow[convPaperLikeLog.Author] == DBNull.Value ? null : objRow[convPaperLikeLog.Author].ToString().Trim(); //作者
objvPaperLikeLogEN.Keyword = objRow[convPaperLikeLog.Keyword] == DBNull.Value ? null : objRow[convPaperLikeLog.Keyword].ToString().Trim(); //关键字
objvPaperLikeLogEN.BrowseNumber = objRow[convPaperLikeLog.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperLikeLog.BrowseNumber].ToString().Trim()); //浏览量
objvPaperLikeLogEN.UserName = objRow[convPaperLikeLog.UserName] == DBNull.Value ? null : objRow[convPaperLikeLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperLikeLogEN.PaperLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperLikeLogEN);
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
public static List<clsvPaperLikeLogEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPaperLikeLogEN> arrObjLst = new List<clsvPaperLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperLikeLogEN objvPaperLikeLogEN = new clsvPaperLikeLogEN();
try
{
objvPaperLikeLogEN.PaperLikeLogId = Int32.Parse(objRow[convPaperLikeLog.PaperLikeLogId].ToString().Trim()); //论文点赞表Id
objvPaperLikeLogEN.PaperId = objRow[convPaperLikeLog.PaperId] == DBNull.Value ? null : objRow[convPaperLikeLog.PaperId].ToString().Trim(); //论文Id
objvPaperLikeLogEN.UpdUser = objRow[convPaperLikeLog.UpdUser].ToString().Trim(); //修改人
objvPaperLikeLogEN.UpdDate = objRow[convPaperLikeLog.UpdDate] == DBNull.Value ? null : objRow[convPaperLikeLog.UpdDate].ToString().Trim(); //修改日期
objvPaperLikeLogEN.Memo = objRow[convPaperLikeLog.Memo] == DBNull.Value ? null : objRow[convPaperLikeLog.Memo].ToString().Trim(); //备注
objvPaperLikeLogEN.PaperTitle = objRow[convPaperLikeLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperLikeLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperLikeLogEN.Author = objRow[convPaperLikeLog.Author] == DBNull.Value ? null : objRow[convPaperLikeLog.Author].ToString().Trim(); //作者
objvPaperLikeLogEN.Keyword = objRow[convPaperLikeLog.Keyword] == DBNull.Value ? null : objRow[convPaperLikeLog.Keyword].ToString().Trim(); //关键字
objvPaperLikeLogEN.BrowseNumber = objRow[convPaperLikeLog.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperLikeLog.BrowseNumber].ToString().Trim()); //浏览量
objvPaperLikeLogEN.UserName = objRow[convPaperLikeLog.UserName] == DBNull.Value ? null : objRow[convPaperLikeLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperLikeLogEN.PaperLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperLikeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPaperLikeLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPaperLikeLogEN> GetSubObjLstCache(clsvPaperLikeLogEN objvPaperLikeLogCond)
{
List<clsvPaperLikeLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperLikeLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperLikeLog.AttributeName)
{
if (objvPaperLikeLogCond.IsUpdated(strFldName) == false) continue;
if (objvPaperLikeLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperLikeLogCond[strFldName].ToString());
}
else
{
if (objvPaperLikeLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperLikeLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperLikeLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperLikeLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperLikeLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperLikeLogCond[strFldName]));
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
public static List<clsvPaperLikeLogEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPaperLikeLogEN> arrObjLst = new List<clsvPaperLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperLikeLogEN objvPaperLikeLogEN = new clsvPaperLikeLogEN();
try
{
objvPaperLikeLogEN.PaperLikeLogId = Int32.Parse(objRow[convPaperLikeLog.PaperLikeLogId].ToString().Trim()); //论文点赞表Id
objvPaperLikeLogEN.PaperId = objRow[convPaperLikeLog.PaperId] == DBNull.Value ? null : objRow[convPaperLikeLog.PaperId].ToString().Trim(); //论文Id
objvPaperLikeLogEN.UpdUser = objRow[convPaperLikeLog.UpdUser].ToString().Trim(); //修改人
objvPaperLikeLogEN.UpdDate = objRow[convPaperLikeLog.UpdDate] == DBNull.Value ? null : objRow[convPaperLikeLog.UpdDate].ToString().Trim(); //修改日期
objvPaperLikeLogEN.Memo = objRow[convPaperLikeLog.Memo] == DBNull.Value ? null : objRow[convPaperLikeLog.Memo].ToString().Trim(); //备注
objvPaperLikeLogEN.PaperTitle = objRow[convPaperLikeLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperLikeLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperLikeLogEN.Author = objRow[convPaperLikeLog.Author] == DBNull.Value ? null : objRow[convPaperLikeLog.Author].ToString().Trim(); //作者
objvPaperLikeLogEN.Keyword = objRow[convPaperLikeLog.Keyword] == DBNull.Value ? null : objRow[convPaperLikeLog.Keyword].ToString().Trim(); //关键字
objvPaperLikeLogEN.BrowseNumber = objRow[convPaperLikeLog.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperLikeLog.BrowseNumber].ToString().Trim()); //浏览量
objvPaperLikeLogEN.UserName = objRow[convPaperLikeLog.UserName] == DBNull.Value ? null : objRow[convPaperLikeLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperLikeLogEN.PaperLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperLikeLogEN);
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
public static List<clsvPaperLikeLogEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPaperLikeLogEN> arrObjLst = new List<clsvPaperLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperLikeLogEN objvPaperLikeLogEN = new clsvPaperLikeLogEN();
try
{
objvPaperLikeLogEN.PaperLikeLogId = Int32.Parse(objRow[convPaperLikeLog.PaperLikeLogId].ToString().Trim()); //论文点赞表Id
objvPaperLikeLogEN.PaperId = objRow[convPaperLikeLog.PaperId] == DBNull.Value ? null : objRow[convPaperLikeLog.PaperId].ToString().Trim(); //论文Id
objvPaperLikeLogEN.UpdUser = objRow[convPaperLikeLog.UpdUser].ToString().Trim(); //修改人
objvPaperLikeLogEN.UpdDate = objRow[convPaperLikeLog.UpdDate] == DBNull.Value ? null : objRow[convPaperLikeLog.UpdDate].ToString().Trim(); //修改日期
objvPaperLikeLogEN.Memo = objRow[convPaperLikeLog.Memo] == DBNull.Value ? null : objRow[convPaperLikeLog.Memo].ToString().Trim(); //备注
objvPaperLikeLogEN.PaperTitle = objRow[convPaperLikeLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperLikeLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperLikeLogEN.Author = objRow[convPaperLikeLog.Author] == DBNull.Value ? null : objRow[convPaperLikeLog.Author].ToString().Trim(); //作者
objvPaperLikeLogEN.Keyword = objRow[convPaperLikeLog.Keyword] == DBNull.Value ? null : objRow[convPaperLikeLog.Keyword].ToString().Trim(); //关键字
objvPaperLikeLogEN.BrowseNumber = objRow[convPaperLikeLog.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperLikeLog.BrowseNumber].ToString().Trim()); //浏览量
objvPaperLikeLogEN.UserName = objRow[convPaperLikeLog.UserName] == DBNull.Value ? null : objRow[convPaperLikeLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperLikeLogEN.PaperLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperLikeLogEN);
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
List<clsvPaperLikeLogEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPaperLikeLogEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperLikeLogEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPaperLikeLogEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperLikeLogEN> arrObjLst = new List<clsvPaperLikeLogEN>(); 
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
	clsvPaperLikeLogEN objvPaperLikeLogEN = new clsvPaperLikeLogEN();
try
{
objvPaperLikeLogEN.PaperLikeLogId = Int32.Parse(objRow[convPaperLikeLog.PaperLikeLogId].ToString().Trim()); //论文点赞表Id
objvPaperLikeLogEN.PaperId = objRow[convPaperLikeLog.PaperId] == DBNull.Value ? null : objRow[convPaperLikeLog.PaperId].ToString().Trim(); //论文Id
objvPaperLikeLogEN.UpdUser = objRow[convPaperLikeLog.UpdUser].ToString().Trim(); //修改人
objvPaperLikeLogEN.UpdDate = objRow[convPaperLikeLog.UpdDate] == DBNull.Value ? null : objRow[convPaperLikeLog.UpdDate].ToString().Trim(); //修改日期
objvPaperLikeLogEN.Memo = objRow[convPaperLikeLog.Memo] == DBNull.Value ? null : objRow[convPaperLikeLog.Memo].ToString().Trim(); //备注
objvPaperLikeLogEN.PaperTitle = objRow[convPaperLikeLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperLikeLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperLikeLogEN.Author = objRow[convPaperLikeLog.Author] == DBNull.Value ? null : objRow[convPaperLikeLog.Author].ToString().Trim(); //作者
objvPaperLikeLogEN.Keyword = objRow[convPaperLikeLog.Keyword] == DBNull.Value ? null : objRow[convPaperLikeLog.Keyword].ToString().Trim(); //关键字
objvPaperLikeLogEN.BrowseNumber = objRow[convPaperLikeLog.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperLikeLog.BrowseNumber].ToString().Trim()); //浏览量
objvPaperLikeLogEN.UserName = objRow[convPaperLikeLog.UserName] == DBNull.Value ? null : objRow[convPaperLikeLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperLikeLogEN.PaperLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperLikeLogEN);
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
public static List<clsvPaperLikeLogEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPaperLikeLogEN> arrObjLst = new List<clsvPaperLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperLikeLogEN objvPaperLikeLogEN = new clsvPaperLikeLogEN();
try
{
objvPaperLikeLogEN.PaperLikeLogId = Int32.Parse(objRow[convPaperLikeLog.PaperLikeLogId].ToString().Trim()); //论文点赞表Id
objvPaperLikeLogEN.PaperId = objRow[convPaperLikeLog.PaperId] == DBNull.Value ? null : objRow[convPaperLikeLog.PaperId].ToString().Trim(); //论文Id
objvPaperLikeLogEN.UpdUser = objRow[convPaperLikeLog.UpdUser].ToString().Trim(); //修改人
objvPaperLikeLogEN.UpdDate = objRow[convPaperLikeLog.UpdDate] == DBNull.Value ? null : objRow[convPaperLikeLog.UpdDate].ToString().Trim(); //修改日期
objvPaperLikeLogEN.Memo = objRow[convPaperLikeLog.Memo] == DBNull.Value ? null : objRow[convPaperLikeLog.Memo].ToString().Trim(); //备注
objvPaperLikeLogEN.PaperTitle = objRow[convPaperLikeLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperLikeLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperLikeLogEN.Author = objRow[convPaperLikeLog.Author] == DBNull.Value ? null : objRow[convPaperLikeLog.Author].ToString().Trim(); //作者
objvPaperLikeLogEN.Keyword = objRow[convPaperLikeLog.Keyword] == DBNull.Value ? null : objRow[convPaperLikeLog.Keyword].ToString().Trim(); //关键字
objvPaperLikeLogEN.BrowseNumber = objRow[convPaperLikeLog.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperLikeLog.BrowseNumber].ToString().Trim()); //浏览量
objvPaperLikeLogEN.UserName = objRow[convPaperLikeLog.UserName] == DBNull.Value ? null : objRow[convPaperLikeLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperLikeLogEN.PaperLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperLikeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPaperLikeLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPaperLikeLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperLikeLogEN> arrObjLst = new List<clsvPaperLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperLikeLogEN objvPaperLikeLogEN = new clsvPaperLikeLogEN();
try
{
objvPaperLikeLogEN.PaperLikeLogId = Int32.Parse(objRow[convPaperLikeLog.PaperLikeLogId].ToString().Trim()); //论文点赞表Id
objvPaperLikeLogEN.PaperId = objRow[convPaperLikeLog.PaperId] == DBNull.Value ? null : objRow[convPaperLikeLog.PaperId].ToString().Trim(); //论文Id
objvPaperLikeLogEN.UpdUser = objRow[convPaperLikeLog.UpdUser].ToString().Trim(); //修改人
objvPaperLikeLogEN.UpdDate = objRow[convPaperLikeLog.UpdDate] == DBNull.Value ? null : objRow[convPaperLikeLog.UpdDate].ToString().Trim(); //修改日期
objvPaperLikeLogEN.Memo = objRow[convPaperLikeLog.Memo] == DBNull.Value ? null : objRow[convPaperLikeLog.Memo].ToString().Trim(); //备注
objvPaperLikeLogEN.PaperTitle = objRow[convPaperLikeLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperLikeLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperLikeLogEN.Author = objRow[convPaperLikeLog.Author] == DBNull.Value ? null : objRow[convPaperLikeLog.Author].ToString().Trim(); //作者
objvPaperLikeLogEN.Keyword = objRow[convPaperLikeLog.Keyword] == DBNull.Value ? null : objRow[convPaperLikeLog.Keyword].ToString().Trim(); //关键字
objvPaperLikeLogEN.BrowseNumber = objRow[convPaperLikeLog.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperLikeLog.BrowseNumber].ToString().Trim()); //浏览量
objvPaperLikeLogEN.UserName = objRow[convPaperLikeLog.UserName] == DBNull.Value ? null : objRow[convPaperLikeLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperLikeLogEN.PaperLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperLikeLogEN);
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
public static List<clsvPaperLikeLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPaperLikeLogEN> arrObjLst = new List<clsvPaperLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperLikeLogEN objvPaperLikeLogEN = new clsvPaperLikeLogEN();
try
{
objvPaperLikeLogEN.PaperLikeLogId = Int32.Parse(objRow[convPaperLikeLog.PaperLikeLogId].ToString().Trim()); //论文点赞表Id
objvPaperLikeLogEN.PaperId = objRow[convPaperLikeLog.PaperId] == DBNull.Value ? null : objRow[convPaperLikeLog.PaperId].ToString().Trim(); //论文Id
objvPaperLikeLogEN.UpdUser = objRow[convPaperLikeLog.UpdUser].ToString().Trim(); //修改人
objvPaperLikeLogEN.UpdDate = objRow[convPaperLikeLog.UpdDate] == DBNull.Value ? null : objRow[convPaperLikeLog.UpdDate].ToString().Trim(); //修改日期
objvPaperLikeLogEN.Memo = objRow[convPaperLikeLog.Memo] == DBNull.Value ? null : objRow[convPaperLikeLog.Memo].ToString().Trim(); //备注
objvPaperLikeLogEN.PaperTitle = objRow[convPaperLikeLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperLikeLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperLikeLogEN.Author = objRow[convPaperLikeLog.Author] == DBNull.Value ? null : objRow[convPaperLikeLog.Author].ToString().Trim(); //作者
objvPaperLikeLogEN.Keyword = objRow[convPaperLikeLog.Keyword] == DBNull.Value ? null : objRow[convPaperLikeLog.Keyword].ToString().Trim(); //关键字
objvPaperLikeLogEN.BrowseNumber = objRow[convPaperLikeLog.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperLikeLog.BrowseNumber].ToString().Trim()); //浏览量
objvPaperLikeLogEN.UserName = objRow[convPaperLikeLog.UserName] == DBNull.Value ? null : objRow[convPaperLikeLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperLikeLogEN.PaperLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperLikeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperLikeLogEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPaperLikeLogEN> arrObjLst = new List<clsvPaperLikeLogEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperLikeLogEN objvPaperLikeLogEN = new clsvPaperLikeLogEN();
try
{
objvPaperLikeLogEN.PaperLikeLogId = Int32.Parse(objRow[convPaperLikeLog.PaperLikeLogId].ToString().Trim()); //论文点赞表Id
objvPaperLikeLogEN.PaperId = objRow[convPaperLikeLog.PaperId] == DBNull.Value ? null : objRow[convPaperLikeLog.PaperId].ToString().Trim(); //论文Id
objvPaperLikeLogEN.UpdUser = objRow[convPaperLikeLog.UpdUser].ToString().Trim(); //修改人
objvPaperLikeLogEN.UpdDate = objRow[convPaperLikeLog.UpdDate] == DBNull.Value ? null : objRow[convPaperLikeLog.UpdDate].ToString().Trim(); //修改日期
objvPaperLikeLogEN.Memo = objRow[convPaperLikeLog.Memo] == DBNull.Value ? null : objRow[convPaperLikeLog.Memo].ToString().Trim(); //备注
objvPaperLikeLogEN.PaperTitle = objRow[convPaperLikeLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperLikeLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperLikeLogEN.Author = objRow[convPaperLikeLog.Author] == DBNull.Value ? null : objRow[convPaperLikeLog.Author].ToString().Trim(); //作者
objvPaperLikeLogEN.Keyword = objRow[convPaperLikeLog.Keyword] == DBNull.Value ? null : objRow[convPaperLikeLog.Keyword].ToString().Trim(); //关键字
objvPaperLikeLogEN.BrowseNumber = objRow[convPaperLikeLog.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperLikeLog.BrowseNumber].ToString().Trim()); //浏览量
objvPaperLikeLogEN.UserName = objRow[convPaperLikeLog.UserName] == DBNull.Value ? null : objRow[convPaperLikeLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperLikeLogEN.PaperLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperLikeLogEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPaperLikeLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPaperLikeLog(ref clsvPaperLikeLogEN objvPaperLikeLogEN)
{
bool bolResult = vPaperLikeLogDA.GetvPaperLikeLog(ref objvPaperLikeLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperLikeLogId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperLikeLogEN GetObjByPaperLikeLogId(long lngPaperLikeLogId)
{
clsvPaperLikeLogEN objvPaperLikeLogEN = vPaperLikeLogDA.GetObjByPaperLikeLogId(lngPaperLikeLogId);
return objvPaperLikeLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPaperLikeLogEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPaperLikeLogEN objvPaperLikeLogEN = vPaperLikeLogDA.GetFirstObj(strWhereCond);
 return objvPaperLikeLogEN;
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
public static clsvPaperLikeLogEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPaperLikeLogEN objvPaperLikeLogEN = vPaperLikeLogDA.GetObjByDataRow(objRow);
 return objvPaperLikeLogEN;
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
public static clsvPaperLikeLogEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPaperLikeLogEN objvPaperLikeLogEN = vPaperLikeLogDA.GetObjByDataRow(objRow);
 return objvPaperLikeLogEN;
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
 /// <param name = "lngPaperLikeLogId">所给的关键字</param>
 /// <param name = "lstvPaperLikeLogObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperLikeLogEN GetObjByPaperLikeLogIdFromList(long lngPaperLikeLogId, List<clsvPaperLikeLogEN> lstvPaperLikeLogObjLst)
{
foreach (clsvPaperLikeLogEN objvPaperLikeLogEN in lstvPaperLikeLogObjLst)
{
if (objvPaperLikeLogEN.PaperLikeLogId == lngPaperLikeLogId)
{
return objvPaperLikeLogEN;
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
 long lngPaperLikeLogId;
 try
 {
 lngPaperLikeLogId = new clsvPaperLikeLogDA().GetFirstID(strWhereCond);
 return lngPaperLikeLogId;
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
 arrList = vPaperLikeLogDA.GetID(strWhereCond);
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
bool bolIsExist = vPaperLikeLogDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngPaperLikeLogId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngPaperLikeLogId)
{
//检测记录是否存在
bool bolIsExist = vPaperLikeLogDA.IsExist(lngPaperLikeLogId);
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
 bolIsExist = clsvPaperLikeLogDA.IsExistTable();
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
 bolIsExist = vPaperLikeLogDA.IsExistTable(strTabName);
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
 /// <param name = "objvPaperLikeLogENS">源对象</param>
 /// <param name = "objvPaperLikeLogENT">目标对象</param>
 public static void CopyTo(clsvPaperLikeLogEN objvPaperLikeLogENS, clsvPaperLikeLogEN objvPaperLikeLogENT)
{
try
{
objvPaperLikeLogENT.PaperLikeLogId = objvPaperLikeLogENS.PaperLikeLogId; //论文点赞表Id
objvPaperLikeLogENT.PaperId = objvPaperLikeLogENS.PaperId; //论文Id
objvPaperLikeLogENT.UpdUser = objvPaperLikeLogENS.UpdUser; //修改人
objvPaperLikeLogENT.UpdDate = objvPaperLikeLogENS.UpdDate; //修改日期
objvPaperLikeLogENT.Memo = objvPaperLikeLogENS.Memo; //备注
objvPaperLikeLogENT.PaperTitle = objvPaperLikeLogENS.PaperTitle; //论文标题
objvPaperLikeLogENT.Author = objvPaperLikeLogENS.Author; //作者
objvPaperLikeLogENT.Keyword = objvPaperLikeLogENS.Keyword; //关键字
objvPaperLikeLogENT.BrowseNumber = objvPaperLikeLogENS.BrowseNumber; //浏览量
objvPaperLikeLogENT.UserName = objvPaperLikeLogENS.UserName; //用户名
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
 /// <param name = "objvPaperLikeLogEN">源简化对象</param>
 public static void SetUpdFlag(clsvPaperLikeLogEN objvPaperLikeLogEN)
{
try
{
objvPaperLikeLogEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPaperLikeLogEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPaperLikeLog.PaperLikeLogId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperLikeLogEN.PaperLikeLogId = objvPaperLikeLogEN.PaperLikeLogId; //论文点赞表Id
}
if (arrFldSet.Contains(convPaperLikeLog.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperLikeLogEN.PaperId = objvPaperLikeLogEN.PaperId == "[null]" ? null :  objvPaperLikeLogEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convPaperLikeLog.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperLikeLogEN.UpdUser = objvPaperLikeLogEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convPaperLikeLog.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperLikeLogEN.UpdDate = objvPaperLikeLogEN.UpdDate == "[null]" ? null :  objvPaperLikeLogEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPaperLikeLog.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperLikeLogEN.Memo = objvPaperLikeLogEN.Memo == "[null]" ? null :  objvPaperLikeLogEN.Memo; //备注
}
if (arrFldSet.Contains(convPaperLikeLog.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperLikeLogEN.PaperTitle = objvPaperLikeLogEN.PaperTitle == "[null]" ? null :  objvPaperLikeLogEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convPaperLikeLog.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperLikeLogEN.Author = objvPaperLikeLogEN.Author == "[null]" ? null :  objvPaperLikeLogEN.Author; //作者
}
if (arrFldSet.Contains(convPaperLikeLog.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperLikeLogEN.Keyword = objvPaperLikeLogEN.Keyword == "[null]" ? null :  objvPaperLikeLogEN.Keyword; //关键字
}
if (arrFldSet.Contains(convPaperLikeLog.BrowseNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperLikeLogEN.BrowseNumber = objvPaperLikeLogEN.BrowseNumber; //浏览量
}
if (arrFldSet.Contains(convPaperLikeLog.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperLikeLogEN.UserName = objvPaperLikeLogEN.UserName == "[null]" ? null :  objvPaperLikeLogEN.UserName; //用户名
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
 /// <param name = "objvPaperLikeLogEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPaperLikeLogEN objvPaperLikeLogEN)
{
try
{
if (objvPaperLikeLogEN.PaperId == "[null]") objvPaperLikeLogEN.PaperId = null; //论文Id
if (objvPaperLikeLogEN.UpdDate == "[null]") objvPaperLikeLogEN.UpdDate = null; //修改日期
if (objvPaperLikeLogEN.Memo == "[null]") objvPaperLikeLogEN.Memo = null; //备注
if (objvPaperLikeLogEN.PaperTitle == "[null]") objvPaperLikeLogEN.PaperTitle = null; //论文标题
if (objvPaperLikeLogEN.Author == "[null]") objvPaperLikeLogEN.Author = null; //作者
if (objvPaperLikeLogEN.Keyword == "[null]") objvPaperLikeLogEN.Keyword = null; //关键字
if (objvPaperLikeLogEN.UserName == "[null]") objvPaperLikeLogEN.UserName = null; //用户名
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
public static void CheckProperty4Condition(clsvPaperLikeLogEN objvPaperLikeLogEN)
{
 vPaperLikeLogDA.CheckProperty4Condition(objvPaperLikeLogEN);
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
if (clsPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperBL没有刷新缓存机制(clsPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperLikeLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperLikeLogBL没有刷新缓存机制(clsPaperLikeLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperLikeLogId");
//if (arrvPaperLikeLogObjLstCache == null)
//{
//arrvPaperLikeLogObjLstCache = vPaperLikeLogDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngPaperLikeLogId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperLikeLogEN GetObjByPaperLikeLogIdCache(long lngPaperLikeLogId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPaperLikeLogEN._CurrTabName);
List<clsvPaperLikeLogEN> arrvPaperLikeLogObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperLikeLogEN> arrvPaperLikeLogObjLst_Sel =
arrvPaperLikeLogObjLstCache
.Where(x=> x.PaperLikeLogId == lngPaperLikeLogId 
);
if (arrvPaperLikeLogObjLst_Sel.Count() == 0)
{
   clsvPaperLikeLogEN obj = clsvPaperLikeLogBL.GetObjByPaperLikeLogId(lngPaperLikeLogId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPaperLikeLogObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperLikeLogEN> GetAllvPaperLikeLogObjLstCache()
{
//获取缓存中的对象列表
List<clsvPaperLikeLogEN> arrvPaperLikeLogObjLstCache = GetObjLstCache(); 
return arrvPaperLikeLogObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperLikeLogEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPaperLikeLogEN._CurrTabName);
List<clsvPaperLikeLogEN> arrvPaperLikeLogObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPaperLikeLogObjLstCache;
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
string strKey = string.Format("{0}", clsvPaperLikeLogEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngPaperLikeLogId)
{
if (strInFldName != convPaperLikeLog.PaperLikeLogId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPaperLikeLog.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPaperLikeLog.AttributeName));
throw new Exception(strMsg);
}
var objvPaperLikeLog = clsvPaperLikeLogBL.GetObjByPaperLikeLogIdCache(lngPaperLikeLogId);
if (objvPaperLikeLog == null) return "";
return objvPaperLikeLog[strOutFldName].ToString();
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
int intRecCount = clsvPaperLikeLogDA.GetRecCount(strTabName);
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
int intRecCount = clsvPaperLikeLogDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPaperLikeLogDA.GetRecCount();
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
int intRecCount = clsvPaperLikeLogDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPaperLikeLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPaperLikeLogEN objvPaperLikeLogCond)
{
List<clsvPaperLikeLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperLikeLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperLikeLog.AttributeName)
{
if (objvPaperLikeLogCond.IsUpdated(strFldName) == false) continue;
if (objvPaperLikeLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperLikeLogCond[strFldName].ToString());
}
else
{
if (objvPaperLikeLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperLikeLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperLikeLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperLikeLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperLikeLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperLikeLogCond[strFldName]));
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
 List<string> arrList = clsvPaperLikeLogDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPaperLikeLogDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPaperLikeLogDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}