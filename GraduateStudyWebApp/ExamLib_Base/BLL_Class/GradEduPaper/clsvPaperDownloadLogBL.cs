
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperDownloadLogBL
 表名:vPaperDownloadLog(01120572)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:18
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
public static class  clsvPaperDownloadLogBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperDownloadId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperDownloadLogEN GetObj(this K_PaperDownloadId_vPaperDownloadLog myKey)
{
clsvPaperDownloadLogEN objvPaperDownloadLogEN = clsvPaperDownloadLogBL.vPaperDownloadLogDA.GetObjByPaperDownloadId(myKey.Value);
return objvPaperDownloadLogEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperDownloadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperDownloadLogEN SetPaperDownloadId(this clsvPaperDownloadLogEN objvPaperDownloadLogEN, long lngPaperDownloadId, string strComparisonOp="")
	{
objvPaperDownloadLogEN.PaperDownloadId = lngPaperDownloadId; //PaperDownloadId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperDownloadLogEN.dicFldComparisonOp.ContainsKey(convPaperDownloadLog.PaperDownloadId) == false)
{
objvPaperDownloadLogEN.dicFldComparisonOp.Add(convPaperDownloadLog.PaperDownloadId, strComparisonOp);
}
else
{
objvPaperDownloadLogEN.dicFldComparisonOp[convPaperDownloadLog.PaperDownloadId] = strComparisonOp;
}
}
return objvPaperDownloadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperDownloadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperDownloadLogEN SetDownloadFile(this clsvPaperDownloadLogEN objvPaperDownloadLogEN, string strDownloadFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDownloadFile, 500, convPaperDownloadLog.DownloadFile);
}
objvPaperDownloadLogEN.DownloadFile = strDownloadFile; //DownloadFile
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperDownloadLogEN.dicFldComparisonOp.ContainsKey(convPaperDownloadLog.DownloadFile) == false)
{
objvPaperDownloadLogEN.dicFldComparisonOp.Add(convPaperDownloadLog.DownloadFile, strComparisonOp);
}
else
{
objvPaperDownloadLogEN.dicFldComparisonOp[convPaperDownloadLog.DownloadFile] = strComparisonOp;
}
}
return objvPaperDownloadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperDownloadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperDownloadLogEN SetDownloadLink(this clsvPaperDownloadLogEN objvPaperDownloadLogEN, string strDownloadLink, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDownloadLink, 500, convPaperDownloadLog.DownloadLink);
}
objvPaperDownloadLogEN.DownloadLink = strDownloadLink; //DownloadLink
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperDownloadLogEN.dicFldComparisonOp.ContainsKey(convPaperDownloadLog.DownloadLink) == false)
{
objvPaperDownloadLogEN.dicFldComparisonOp.Add(convPaperDownloadLog.DownloadLink, strComparisonOp);
}
else
{
objvPaperDownloadLogEN.dicFldComparisonOp[convPaperDownloadLog.DownloadLink] = strComparisonOp;
}
}
return objvPaperDownloadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperDownloadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperDownloadLogEN SetPaperId(this clsvPaperDownloadLogEN objvPaperDownloadLogEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convPaperDownloadLog.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convPaperDownloadLog.PaperId);
}
objvPaperDownloadLogEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperDownloadLogEN.dicFldComparisonOp.ContainsKey(convPaperDownloadLog.PaperId) == false)
{
objvPaperDownloadLogEN.dicFldComparisonOp.Add(convPaperDownloadLog.PaperId, strComparisonOp);
}
else
{
objvPaperDownloadLogEN.dicFldComparisonOp[convPaperDownloadLog.PaperId] = strComparisonOp;
}
}
return objvPaperDownloadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperDownloadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperDownloadLogEN SetUpdUser(this clsvPaperDownloadLogEN objvPaperDownloadLogEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPaperDownloadLog.UpdUser);
}
objvPaperDownloadLogEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperDownloadLogEN.dicFldComparisonOp.ContainsKey(convPaperDownloadLog.UpdUser) == false)
{
objvPaperDownloadLogEN.dicFldComparisonOp.Add(convPaperDownloadLog.UpdUser, strComparisonOp);
}
else
{
objvPaperDownloadLogEN.dicFldComparisonOp[convPaperDownloadLog.UpdUser] = strComparisonOp;
}
}
return objvPaperDownloadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperDownloadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperDownloadLogEN SetUpdDate(this clsvPaperDownloadLogEN objvPaperDownloadLogEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPaperDownloadLog.UpdDate);
}
objvPaperDownloadLogEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperDownloadLogEN.dicFldComparisonOp.ContainsKey(convPaperDownloadLog.UpdDate) == false)
{
objvPaperDownloadLogEN.dicFldComparisonOp.Add(convPaperDownloadLog.UpdDate, strComparisonOp);
}
else
{
objvPaperDownloadLogEN.dicFldComparisonOp[convPaperDownloadLog.UpdDate] = strComparisonOp;
}
}
return objvPaperDownloadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperDownloadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperDownloadLogEN SetMemo(this clsvPaperDownloadLogEN objvPaperDownloadLogEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPaperDownloadLog.Memo);
}
objvPaperDownloadLogEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperDownloadLogEN.dicFldComparisonOp.ContainsKey(convPaperDownloadLog.Memo) == false)
{
objvPaperDownloadLogEN.dicFldComparisonOp.Add(convPaperDownloadLog.Memo, strComparisonOp);
}
else
{
objvPaperDownloadLogEN.dicFldComparisonOp[convPaperDownloadLog.Memo] = strComparisonOp;
}
}
return objvPaperDownloadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperDownloadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperDownloadLogEN SetPaperTitle(this clsvPaperDownloadLogEN objvPaperDownloadLogEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convPaperDownloadLog.PaperTitle);
}
objvPaperDownloadLogEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperDownloadLogEN.dicFldComparisonOp.ContainsKey(convPaperDownloadLog.PaperTitle) == false)
{
objvPaperDownloadLogEN.dicFldComparisonOp.Add(convPaperDownloadLog.PaperTitle, strComparisonOp);
}
else
{
objvPaperDownloadLogEN.dicFldComparisonOp[convPaperDownloadLog.PaperTitle] = strComparisonOp;
}
}
return objvPaperDownloadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperDownloadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperDownloadLogEN SetAuthor(this clsvPaperDownloadLogEN objvPaperDownloadLogEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convPaperDownloadLog.Author);
}
objvPaperDownloadLogEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperDownloadLogEN.dicFldComparisonOp.ContainsKey(convPaperDownloadLog.Author) == false)
{
objvPaperDownloadLogEN.dicFldComparisonOp.Add(convPaperDownloadLog.Author, strComparisonOp);
}
else
{
objvPaperDownloadLogEN.dicFldComparisonOp[convPaperDownloadLog.Author] = strComparisonOp;
}
}
return objvPaperDownloadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperDownloadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperDownloadLogEN SetKeyword(this clsvPaperDownloadLogEN objvPaperDownloadLogEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convPaperDownloadLog.Keyword);
}
objvPaperDownloadLogEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperDownloadLogEN.dicFldComparisonOp.ContainsKey(convPaperDownloadLog.Keyword) == false)
{
objvPaperDownloadLogEN.dicFldComparisonOp.Add(convPaperDownloadLog.Keyword, strComparisonOp);
}
else
{
objvPaperDownloadLogEN.dicFldComparisonOp[convPaperDownloadLog.Keyword] = strComparisonOp;
}
}
return objvPaperDownloadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperDownloadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperDownloadLogEN SetUserName(this clsvPaperDownloadLogEN objvPaperDownloadLogEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convPaperDownloadLog.UserName);
}
objvPaperDownloadLogEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperDownloadLogEN.dicFldComparisonOp.ContainsKey(convPaperDownloadLog.UserName) == false)
{
objvPaperDownloadLogEN.dicFldComparisonOp.Add(convPaperDownloadLog.UserName, strComparisonOp);
}
else
{
objvPaperDownloadLogEN.dicFldComparisonOp[convPaperDownloadLog.UserName] = strComparisonOp;
}
}
return objvPaperDownloadLogEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPaperDownloadLogENS">源对象</param>
 /// <param name = "objvPaperDownloadLogENT">目标对象</param>
 public static void CopyTo(this clsvPaperDownloadLogEN objvPaperDownloadLogENS, clsvPaperDownloadLogEN objvPaperDownloadLogENT)
{
try
{
objvPaperDownloadLogENT.PaperDownloadId = objvPaperDownloadLogENS.PaperDownloadId; //PaperDownloadId
objvPaperDownloadLogENT.DownloadFile = objvPaperDownloadLogENS.DownloadFile; //DownloadFile
objvPaperDownloadLogENT.DownloadLink = objvPaperDownloadLogENS.DownloadLink; //DownloadLink
objvPaperDownloadLogENT.PaperId = objvPaperDownloadLogENS.PaperId; //论文Id
objvPaperDownloadLogENT.UpdUser = objvPaperDownloadLogENS.UpdUser; //修改人
objvPaperDownloadLogENT.UpdDate = objvPaperDownloadLogENS.UpdDate; //修改日期
objvPaperDownloadLogENT.Memo = objvPaperDownloadLogENS.Memo; //备注
objvPaperDownloadLogENT.PaperTitle = objvPaperDownloadLogENS.PaperTitle; //论文标题
objvPaperDownloadLogENT.Author = objvPaperDownloadLogENS.Author; //作者
objvPaperDownloadLogENT.Keyword = objvPaperDownloadLogENS.Keyword; //关键字
objvPaperDownloadLogENT.UserName = objvPaperDownloadLogENS.UserName; //用户名
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
 /// <param name = "objvPaperDownloadLogENS">源对象</param>
 /// <returns>目标对象=>clsvPaperDownloadLogEN:objvPaperDownloadLogENT</returns>
 public static clsvPaperDownloadLogEN CopyTo(this clsvPaperDownloadLogEN objvPaperDownloadLogENS)
{
try
{
 clsvPaperDownloadLogEN objvPaperDownloadLogENT = new clsvPaperDownloadLogEN()
{
PaperDownloadId = objvPaperDownloadLogENS.PaperDownloadId, //PaperDownloadId
DownloadFile = objvPaperDownloadLogENS.DownloadFile, //DownloadFile
DownloadLink = objvPaperDownloadLogENS.DownloadLink, //DownloadLink
PaperId = objvPaperDownloadLogENS.PaperId, //论文Id
UpdUser = objvPaperDownloadLogENS.UpdUser, //修改人
UpdDate = objvPaperDownloadLogENS.UpdDate, //修改日期
Memo = objvPaperDownloadLogENS.Memo, //备注
PaperTitle = objvPaperDownloadLogENS.PaperTitle, //论文标题
Author = objvPaperDownloadLogENS.Author, //作者
Keyword = objvPaperDownloadLogENS.Keyword, //关键字
UserName = objvPaperDownloadLogENS.UserName, //用户名
};
 return objvPaperDownloadLogENT;
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
public static void CheckProperty4Condition(this clsvPaperDownloadLogEN objvPaperDownloadLogEN)
{
 clsvPaperDownloadLogBL.vPaperDownloadLogDA.CheckProperty4Condition(objvPaperDownloadLogEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPaperDownloadLogEN objvPaperDownloadLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPaperDownloadLogCond.IsUpdated(convPaperDownloadLog.PaperDownloadId) == true)
{
string strComparisonOpPaperDownloadId = objvPaperDownloadLogCond.dicFldComparisonOp[convPaperDownloadLog.PaperDownloadId];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperDownloadLog.PaperDownloadId, objvPaperDownloadLogCond.PaperDownloadId, strComparisonOpPaperDownloadId);
}
if (objvPaperDownloadLogCond.IsUpdated(convPaperDownloadLog.DownloadFile) == true)
{
string strComparisonOpDownloadFile = objvPaperDownloadLogCond.dicFldComparisonOp[convPaperDownloadLog.DownloadFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperDownloadLog.DownloadFile, objvPaperDownloadLogCond.DownloadFile, strComparisonOpDownloadFile);
}
if (objvPaperDownloadLogCond.IsUpdated(convPaperDownloadLog.DownloadLink) == true)
{
string strComparisonOpDownloadLink = objvPaperDownloadLogCond.dicFldComparisonOp[convPaperDownloadLog.DownloadLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperDownloadLog.DownloadLink, objvPaperDownloadLogCond.DownloadLink, strComparisonOpDownloadLink);
}
if (objvPaperDownloadLogCond.IsUpdated(convPaperDownloadLog.PaperId) == true)
{
string strComparisonOpPaperId = objvPaperDownloadLogCond.dicFldComparisonOp[convPaperDownloadLog.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperDownloadLog.PaperId, objvPaperDownloadLogCond.PaperId, strComparisonOpPaperId);
}
if (objvPaperDownloadLogCond.IsUpdated(convPaperDownloadLog.UpdUser) == true)
{
string strComparisonOpUpdUser = objvPaperDownloadLogCond.dicFldComparisonOp[convPaperDownloadLog.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperDownloadLog.UpdUser, objvPaperDownloadLogCond.UpdUser, strComparisonOpUpdUser);
}
if (objvPaperDownloadLogCond.IsUpdated(convPaperDownloadLog.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPaperDownloadLogCond.dicFldComparisonOp[convPaperDownloadLog.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperDownloadLog.UpdDate, objvPaperDownloadLogCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPaperDownloadLogCond.IsUpdated(convPaperDownloadLog.Memo) == true)
{
string strComparisonOpMemo = objvPaperDownloadLogCond.dicFldComparisonOp[convPaperDownloadLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperDownloadLog.Memo, objvPaperDownloadLogCond.Memo, strComparisonOpMemo);
}
if (objvPaperDownloadLogCond.IsUpdated(convPaperDownloadLog.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvPaperDownloadLogCond.dicFldComparisonOp[convPaperDownloadLog.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperDownloadLog.PaperTitle, objvPaperDownloadLogCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvPaperDownloadLogCond.IsUpdated(convPaperDownloadLog.Author) == true)
{
string strComparisonOpAuthor = objvPaperDownloadLogCond.dicFldComparisonOp[convPaperDownloadLog.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperDownloadLog.Author, objvPaperDownloadLogCond.Author, strComparisonOpAuthor);
}
if (objvPaperDownloadLogCond.IsUpdated(convPaperDownloadLog.Keyword) == true)
{
string strComparisonOpKeyword = objvPaperDownloadLogCond.dicFldComparisonOp[convPaperDownloadLog.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperDownloadLog.Keyword, objvPaperDownloadLogCond.Keyword, strComparisonOpKeyword);
}
if (objvPaperDownloadLogCond.IsUpdated(convPaperDownloadLog.UserName) == true)
{
string strComparisonOpUserName = objvPaperDownloadLogCond.dicFldComparisonOp[convPaperDownloadLog.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperDownloadLog.UserName, objvPaperDownloadLogCond.UserName, strComparisonOpUserName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPaperDownloadLog
{
public virtual bool UpdRelaTabDate(long lngPaperDownloadId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v论文下载记录(vPaperDownloadLog)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPaperDownloadLogBL
{
public static RelatedActions_vPaperDownloadLog relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPaperDownloadLogDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPaperDownloadLogDA vPaperDownloadLogDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPaperDownloadLogDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPaperDownloadLogBL()
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
if (string.IsNullOrEmpty(clsvPaperDownloadLogEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPaperDownloadLogEN._ConnectString);
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
public static DataTable GetDataTable_vPaperDownloadLog(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPaperDownloadLogDA.GetDataTable_vPaperDownloadLog(strWhereCond);
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
objDT = vPaperDownloadLogDA.GetDataTable(strWhereCond);
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
objDT = vPaperDownloadLogDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPaperDownloadLogDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPaperDownloadLogDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPaperDownloadLogDA.GetDataTable_Top(objTopPara);
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
objDT = vPaperDownloadLogDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPaperDownloadLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPaperDownloadLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPaperDownloadIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPaperDownloadLogEN> GetObjLstByPaperDownloadIdLst(List<long> arrPaperDownloadIdLst)
{
List<clsvPaperDownloadLogEN> arrObjLst = new List<clsvPaperDownloadLogEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPaperDownloadIdLst);
 string strWhereCond = string.Format("PaperDownloadId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperDownloadLogEN objvPaperDownloadLogEN = new clsvPaperDownloadLogEN();
try
{
objvPaperDownloadLogEN.PaperDownloadId = Int32.Parse(objRow[convPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objvPaperDownloadLogEN.DownloadFile = objRow[convPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objvPaperDownloadLogEN.DownloadLink = objRow[convPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objvPaperDownloadLogEN.PaperId = objRow[convPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objvPaperDownloadLogEN.UpdUser = objRow[convPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objvPaperDownloadLogEN.UpdDate = objRow[convPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objvPaperDownloadLogEN.Memo = objRow[convPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[convPaperDownloadLog.Memo].ToString().Trim(); //备注
objvPaperDownloadLogEN.PaperTitle = objRow[convPaperDownloadLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperDownloadLogEN.Author = objRow[convPaperDownloadLog.Author] == DBNull.Value ? null : objRow[convPaperDownloadLog.Author].ToString().Trim(); //作者
objvPaperDownloadLogEN.Keyword = objRow[convPaperDownloadLog.Keyword] == DBNull.Value ? null : objRow[convPaperDownloadLog.Keyword].ToString().Trim(); //关键字
objvPaperDownloadLogEN.UserName = objRow[convPaperDownloadLog.UserName] == DBNull.Value ? null : objRow[convPaperDownloadLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperDownloadLogEN.PaperDownloadId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperDownloadLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperDownloadIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPaperDownloadLogEN> GetObjLstByPaperDownloadIdLstCache(List<long> arrPaperDownloadIdLst)
{
string strKey = string.Format("{0}", clsvPaperDownloadLogEN._CurrTabName);
List<clsvPaperDownloadLogEN> arrvPaperDownloadLogObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperDownloadLogEN> arrvPaperDownloadLogObjLst_Sel =
arrvPaperDownloadLogObjLstCache
.Where(x => arrPaperDownloadIdLst.Contains(x.PaperDownloadId));
return arrvPaperDownloadLogObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperDownloadLogEN> GetObjLst(string strWhereCond)
{
List<clsvPaperDownloadLogEN> arrObjLst = new List<clsvPaperDownloadLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperDownloadLogEN objvPaperDownloadLogEN = new clsvPaperDownloadLogEN();
try
{
objvPaperDownloadLogEN.PaperDownloadId = Int32.Parse(objRow[convPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objvPaperDownloadLogEN.DownloadFile = objRow[convPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objvPaperDownloadLogEN.DownloadLink = objRow[convPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objvPaperDownloadLogEN.PaperId = objRow[convPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objvPaperDownloadLogEN.UpdUser = objRow[convPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objvPaperDownloadLogEN.UpdDate = objRow[convPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objvPaperDownloadLogEN.Memo = objRow[convPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[convPaperDownloadLog.Memo].ToString().Trim(); //备注
objvPaperDownloadLogEN.PaperTitle = objRow[convPaperDownloadLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperDownloadLogEN.Author = objRow[convPaperDownloadLog.Author] == DBNull.Value ? null : objRow[convPaperDownloadLog.Author].ToString().Trim(); //作者
objvPaperDownloadLogEN.Keyword = objRow[convPaperDownloadLog.Keyword] == DBNull.Value ? null : objRow[convPaperDownloadLog.Keyword].ToString().Trim(); //关键字
objvPaperDownloadLogEN.UserName = objRow[convPaperDownloadLog.UserName] == DBNull.Value ? null : objRow[convPaperDownloadLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperDownloadLogEN.PaperDownloadId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperDownloadLogEN);
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
public static List<clsvPaperDownloadLogEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPaperDownloadLogEN> arrObjLst = new List<clsvPaperDownloadLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperDownloadLogEN objvPaperDownloadLogEN = new clsvPaperDownloadLogEN();
try
{
objvPaperDownloadLogEN.PaperDownloadId = Int32.Parse(objRow[convPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objvPaperDownloadLogEN.DownloadFile = objRow[convPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objvPaperDownloadLogEN.DownloadLink = objRow[convPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objvPaperDownloadLogEN.PaperId = objRow[convPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objvPaperDownloadLogEN.UpdUser = objRow[convPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objvPaperDownloadLogEN.UpdDate = objRow[convPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objvPaperDownloadLogEN.Memo = objRow[convPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[convPaperDownloadLog.Memo].ToString().Trim(); //备注
objvPaperDownloadLogEN.PaperTitle = objRow[convPaperDownloadLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperDownloadLogEN.Author = objRow[convPaperDownloadLog.Author] == DBNull.Value ? null : objRow[convPaperDownloadLog.Author].ToString().Trim(); //作者
objvPaperDownloadLogEN.Keyword = objRow[convPaperDownloadLog.Keyword] == DBNull.Value ? null : objRow[convPaperDownloadLog.Keyword].ToString().Trim(); //关键字
objvPaperDownloadLogEN.UserName = objRow[convPaperDownloadLog.UserName] == DBNull.Value ? null : objRow[convPaperDownloadLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperDownloadLogEN.PaperDownloadId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperDownloadLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPaperDownloadLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPaperDownloadLogEN> GetSubObjLstCache(clsvPaperDownloadLogEN objvPaperDownloadLogCond)
{
List<clsvPaperDownloadLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperDownloadLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperDownloadLog.AttributeName)
{
if (objvPaperDownloadLogCond.IsUpdated(strFldName) == false) continue;
if (objvPaperDownloadLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperDownloadLogCond[strFldName].ToString());
}
else
{
if (objvPaperDownloadLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperDownloadLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperDownloadLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperDownloadLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperDownloadLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperDownloadLogCond[strFldName]));
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
public static List<clsvPaperDownloadLogEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPaperDownloadLogEN> arrObjLst = new List<clsvPaperDownloadLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperDownloadLogEN objvPaperDownloadLogEN = new clsvPaperDownloadLogEN();
try
{
objvPaperDownloadLogEN.PaperDownloadId = Int32.Parse(objRow[convPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objvPaperDownloadLogEN.DownloadFile = objRow[convPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objvPaperDownloadLogEN.DownloadLink = objRow[convPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objvPaperDownloadLogEN.PaperId = objRow[convPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objvPaperDownloadLogEN.UpdUser = objRow[convPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objvPaperDownloadLogEN.UpdDate = objRow[convPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objvPaperDownloadLogEN.Memo = objRow[convPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[convPaperDownloadLog.Memo].ToString().Trim(); //备注
objvPaperDownloadLogEN.PaperTitle = objRow[convPaperDownloadLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperDownloadLogEN.Author = objRow[convPaperDownloadLog.Author] == DBNull.Value ? null : objRow[convPaperDownloadLog.Author].ToString().Trim(); //作者
objvPaperDownloadLogEN.Keyword = objRow[convPaperDownloadLog.Keyword] == DBNull.Value ? null : objRow[convPaperDownloadLog.Keyword].ToString().Trim(); //关键字
objvPaperDownloadLogEN.UserName = objRow[convPaperDownloadLog.UserName] == DBNull.Value ? null : objRow[convPaperDownloadLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperDownloadLogEN.PaperDownloadId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperDownloadLogEN);
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
public static List<clsvPaperDownloadLogEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPaperDownloadLogEN> arrObjLst = new List<clsvPaperDownloadLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperDownloadLogEN objvPaperDownloadLogEN = new clsvPaperDownloadLogEN();
try
{
objvPaperDownloadLogEN.PaperDownloadId = Int32.Parse(objRow[convPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objvPaperDownloadLogEN.DownloadFile = objRow[convPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objvPaperDownloadLogEN.DownloadLink = objRow[convPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objvPaperDownloadLogEN.PaperId = objRow[convPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objvPaperDownloadLogEN.UpdUser = objRow[convPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objvPaperDownloadLogEN.UpdDate = objRow[convPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objvPaperDownloadLogEN.Memo = objRow[convPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[convPaperDownloadLog.Memo].ToString().Trim(); //备注
objvPaperDownloadLogEN.PaperTitle = objRow[convPaperDownloadLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperDownloadLogEN.Author = objRow[convPaperDownloadLog.Author] == DBNull.Value ? null : objRow[convPaperDownloadLog.Author].ToString().Trim(); //作者
objvPaperDownloadLogEN.Keyword = objRow[convPaperDownloadLog.Keyword] == DBNull.Value ? null : objRow[convPaperDownloadLog.Keyword].ToString().Trim(); //关键字
objvPaperDownloadLogEN.UserName = objRow[convPaperDownloadLog.UserName] == DBNull.Value ? null : objRow[convPaperDownloadLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperDownloadLogEN.PaperDownloadId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperDownloadLogEN);
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
List<clsvPaperDownloadLogEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPaperDownloadLogEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperDownloadLogEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPaperDownloadLogEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperDownloadLogEN> arrObjLst = new List<clsvPaperDownloadLogEN>(); 
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
	clsvPaperDownloadLogEN objvPaperDownloadLogEN = new clsvPaperDownloadLogEN();
try
{
objvPaperDownloadLogEN.PaperDownloadId = Int32.Parse(objRow[convPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objvPaperDownloadLogEN.DownloadFile = objRow[convPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objvPaperDownloadLogEN.DownloadLink = objRow[convPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objvPaperDownloadLogEN.PaperId = objRow[convPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objvPaperDownloadLogEN.UpdUser = objRow[convPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objvPaperDownloadLogEN.UpdDate = objRow[convPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objvPaperDownloadLogEN.Memo = objRow[convPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[convPaperDownloadLog.Memo].ToString().Trim(); //备注
objvPaperDownloadLogEN.PaperTitle = objRow[convPaperDownloadLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperDownloadLogEN.Author = objRow[convPaperDownloadLog.Author] == DBNull.Value ? null : objRow[convPaperDownloadLog.Author].ToString().Trim(); //作者
objvPaperDownloadLogEN.Keyword = objRow[convPaperDownloadLog.Keyword] == DBNull.Value ? null : objRow[convPaperDownloadLog.Keyword].ToString().Trim(); //关键字
objvPaperDownloadLogEN.UserName = objRow[convPaperDownloadLog.UserName] == DBNull.Value ? null : objRow[convPaperDownloadLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperDownloadLogEN.PaperDownloadId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperDownloadLogEN);
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
public static List<clsvPaperDownloadLogEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPaperDownloadLogEN> arrObjLst = new List<clsvPaperDownloadLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperDownloadLogEN objvPaperDownloadLogEN = new clsvPaperDownloadLogEN();
try
{
objvPaperDownloadLogEN.PaperDownloadId = Int32.Parse(objRow[convPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objvPaperDownloadLogEN.DownloadFile = objRow[convPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objvPaperDownloadLogEN.DownloadLink = objRow[convPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objvPaperDownloadLogEN.PaperId = objRow[convPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objvPaperDownloadLogEN.UpdUser = objRow[convPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objvPaperDownloadLogEN.UpdDate = objRow[convPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objvPaperDownloadLogEN.Memo = objRow[convPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[convPaperDownloadLog.Memo].ToString().Trim(); //备注
objvPaperDownloadLogEN.PaperTitle = objRow[convPaperDownloadLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperDownloadLogEN.Author = objRow[convPaperDownloadLog.Author] == DBNull.Value ? null : objRow[convPaperDownloadLog.Author].ToString().Trim(); //作者
objvPaperDownloadLogEN.Keyword = objRow[convPaperDownloadLog.Keyword] == DBNull.Value ? null : objRow[convPaperDownloadLog.Keyword].ToString().Trim(); //关键字
objvPaperDownloadLogEN.UserName = objRow[convPaperDownloadLog.UserName] == DBNull.Value ? null : objRow[convPaperDownloadLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperDownloadLogEN.PaperDownloadId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperDownloadLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPaperDownloadLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPaperDownloadLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperDownloadLogEN> arrObjLst = new List<clsvPaperDownloadLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperDownloadLogEN objvPaperDownloadLogEN = new clsvPaperDownloadLogEN();
try
{
objvPaperDownloadLogEN.PaperDownloadId = Int32.Parse(objRow[convPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objvPaperDownloadLogEN.DownloadFile = objRow[convPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objvPaperDownloadLogEN.DownloadLink = objRow[convPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objvPaperDownloadLogEN.PaperId = objRow[convPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objvPaperDownloadLogEN.UpdUser = objRow[convPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objvPaperDownloadLogEN.UpdDate = objRow[convPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objvPaperDownloadLogEN.Memo = objRow[convPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[convPaperDownloadLog.Memo].ToString().Trim(); //备注
objvPaperDownloadLogEN.PaperTitle = objRow[convPaperDownloadLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperDownloadLogEN.Author = objRow[convPaperDownloadLog.Author] == DBNull.Value ? null : objRow[convPaperDownloadLog.Author].ToString().Trim(); //作者
objvPaperDownloadLogEN.Keyword = objRow[convPaperDownloadLog.Keyword] == DBNull.Value ? null : objRow[convPaperDownloadLog.Keyword].ToString().Trim(); //关键字
objvPaperDownloadLogEN.UserName = objRow[convPaperDownloadLog.UserName] == DBNull.Value ? null : objRow[convPaperDownloadLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperDownloadLogEN.PaperDownloadId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperDownloadLogEN);
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
public static List<clsvPaperDownloadLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPaperDownloadLogEN> arrObjLst = new List<clsvPaperDownloadLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperDownloadLogEN objvPaperDownloadLogEN = new clsvPaperDownloadLogEN();
try
{
objvPaperDownloadLogEN.PaperDownloadId = Int32.Parse(objRow[convPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objvPaperDownloadLogEN.DownloadFile = objRow[convPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objvPaperDownloadLogEN.DownloadLink = objRow[convPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objvPaperDownloadLogEN.PaperId = objRow[convPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objvPaperDownloadLogEN.UpdUser = objRow[convPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objvPaperDownloadLogEN.UpdDate = objRow[convPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objvPaperDownloadLogEN.Memo = objRow[convPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[convPaperDownloadLog.Memo].ToString().Trim(); //备注
objvPaperDownloadLogEN.PaperTitle = objRow[convPaperDownloadLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperDownloadLogEN.Author = objRow[convPaperDownloadLog.Author] == DBNull.Value ? null : objRow[convPaperDownloadLog.Author].ToString().Trim(); //作者
objvPaperDownloadLogEN.Keyword = objRow[convPaperDownloadLog.Keyword] == DBNull.Value ? null : objRow[convPaperDownloadLog.Keyword].ToString().Trim(); //关键字
objvPaperDownloadLogEN.UserName = objRow[convPaperDownloadLog.UserName] == DBNull.Value ? null : objRow[convPaperDownloadLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperDownloadLogEN.PaperDownloadId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperDownloadLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperDownloadLogEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPaperDownloadLogEN> arrObjLst = new List<clsvPaperDownloadLogEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperDownloadLogEN objvPaperDownloadLogEN = new clsvPaperDownloadLogEN();
try
{
objvPaperDownloadLogEN.PaperDownloadId = Int32.Parse(objRow[convPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objvPaperDownloadLogEN.DownloadFile = objRow[convPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objvPaperDownloadLogEN.DownloadLink = objRow[convPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[convPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objvPaperDownloadLogEN.PaperId = objRow[convPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objvPaperDownloadLogEN.UpdUser = objRow[convPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objvPaperDownloadLogEN.UpdDate = objRow[convPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[convPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objvPaperDownloadLogEN.Memo = objRow[convPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[convPaperDownloadLog.Memo].ToString().Trim(); //备注
objvPaperDownloadLogEN.PaperTitle = objRow[convPaperDownloadLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperDownloadLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperDownloadLogEN.Author = objRow[convPaperDownloadLog.Author] == DBNull.Value ? null : objRow[convPaperDownloadLog.Author].ToString().Trim(); //作者
objvPaperDownloadLogEN.Keyword = objRow[convPaperDownloadLog.Keyword] == DBNull.Value ? null : objRow[convPaperDownloadLog.Keyword].ToString().Trim(); //关键字
objvPaperDownloadLogEN.UserName = objRow[convPaperDownloadLog.UserName] == DBNull.Value ? null : objRow[convPaperDownloadLog.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperDownloadLogEN.PaperDownloadId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperDownloadLogEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPaperDownloadLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPaperDownloadLog(ref clsvPaperDownloadLogEN objvPaperDownloadLogEN)
{
bool bolResult = vPaperDownloadLogDA.GetvPaperDownloadLog(ref objvPaperDownloadLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperDownloadId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperDownloadLogEN GetObjByPaperDownloadId(long lngPaperDownloadId)
{
clsvPaperDownloadLogEN objvPaperDownloadLogEN = vPaperDownloadLogDA.GetObjByPaperDownloadId(lngPaperDownloadId);
return objvPaperDownloadLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPaperDownloadLogEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPaperDownloadLogEN objvPaperDownloadLogEN = vPaperDownloadLogDA.GetFirstObj(strWhereCond);
 return objvPaperDownloadLogEN;
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
public static clsvPaperDownloadLogEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPaperDownloadLogEN objvPaperDownloadLogEN = vPaperDownloadLogDA.GetObjByDataRow(objRow);
 return objvPaperDownloadLogEN;
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
public static clsvPaperDownloadLogEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPaperDownloadLogEN objvPaperDownloadLogEN = vPaperDownloadLogDA.GetObjByDataRow(objRow);
 return objvPaperDownloadLogEN;
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
 /// <param name = "lngPaperDownloadId">所给的关键字</param>
 /// <param name = "lstvPaperDownloadLogObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperDownloadLogEN GetObjByPaperDownloadIdFromList(long lngPaperDownloadId, List<clsvPaperDownloadLogEN> lstvPaperDownloadLogObjLst)
{
foreach (clsvPaperDownloadLogEN objvPaperDownloadLogEN in lstvPaperDownloadLogObjLst)
{
if (objvPaperDownloadLogEN.PaperDownloadId == lngPaperDownloadId)
{
return objvPaperDownloadLogEN;
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
 long lngPaperDownloadId;
 try
 {
 lngPaperDownloadId = new clsvPaperDownloadLogDA().GetFirstID(strWhereCond);
 return lngPaperDownloadId;
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
 arrList = vPaperDownloadLogDA.GetID(strWhereCond);
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
bool bolIsExist = vPaperDownloadLogDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngPaperDownloadId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngPaperDownloadId)
{
//检测记录是否存在
bool bolIsExist = vPaperDownloadLogDA.IsExist(lngPaperDownloadId);
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
 bolIsExist = clsvPaperDownloadLogDA.IsExistTable();
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
 bolIsExist = vPaperDownloadLogDA.IsExistTable(strTabName);
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
 /// <param name = "objvPaperDownloadLogENS">源对象</param>
 /// <param name = "objvPaperDownloadLogENT">目标对象</param>
 public static void CopyTo(clsvPaperDownloadLogEN objvPaperDownloadLogENS, clsvPaperDownloadLogEN objvPaperDownloadLogENT)
{
try
{
objvPaperDownloadLogENT.PaperDownloadId = objvPaperDownloadLogENS.PaperDownloadId; //PaperDownloadId
objvPaperDownloadLogENT.DownloadFile = objvPaperDownloadLogENS.DownloadFile; //DownloadFile
objvPaperDownloadLogENT.DownloadLink = objvPaperDownloadLogENS.DownloadLink; //DownloadLink
objvPaperDownloadLogENT.PaperId = objvPaperDownloadLogENS.PaperId; //论文Id
objvPaperDownloadLogENT.UpdUser = objvPaperDownloadLogENS.UpdUser; //修改人
objvPaperDownloadLogENT.UpdDate = objvPaperDownloadLogENS.UpdDate; //修改日期
objvPaperDownloadLogENT.Memo = objvPaperDownloadLogENS.Memo; //备注
objvPaperDownloadLogENT.PaperTitle = objvPaperDownloadLogENS.PaperTitle; //论文标题
objvPaperDownloadLogENT.Author = objvPaperDownloadLogENS.Author; //作者
objvPaperDownloadLogENT.Keyword = objvPaperDownloadLogENS.Keyword; //关键字
objvPaperDownloadLogENT.UserName = objvPaperDownloadLogENS.UserName; //用户名
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
 /// <param name = "objvPaperDownloadLogEN">源简化对象</param>
 public static void SetUpdFlag(clsvPaperDownloadLogEN objvPaperDownloadLogEN)
{
try
{
objvPaperDownloadLogEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPaperDownloadLogEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPaperDownloadLog.PaperDownloadId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperDownloadLogEN.PaperDownloadId = objvPaperDownloadLogEN.PaperDownloadId; //PaperDownloadId
}
if (arrFldSet.Contains(convPaperDownloadLog.DownloadFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperDownloadLogEN.DownloadFile = objvPaperDownloadLogEN.DownloadFile == "[null]" ? null :  objvPaperDownloadLogEN.DownloadFile; //DownloadFile
}
if (arrFldSet.Contains(convPaperDownloadLog.DownloadLink, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperDownloadLogEN.DownloadLink = objvPaperDownloadLogEN.DownloadLink == "[null]" ? null :  objvPaperDownloadLogEN.DownloadLink; //DownloadLink
}
if (arrFldSet.Contains(convPaperDownloadLog.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperDownloadLogEN.PaperId = objvPaperDownloadLogEN.PaperId == "[null]" ? null :  objvPaperDownloadLogEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convPaperDownloadLog.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperDownloadLogEN.UpdUser = objvPaperDownloadLogEN.UpdUser == "[null]" ? null :  objvPaperDownloadLogEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convPaperDownloadLog.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperDownloadLogEN.UpdDate = objvPaperDownloadLogEN.UpdDate == "[null]" ? null :  objvPaperDownloadLogEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPaperDownloadLog.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperDownloadLogEN.Memo = objvPaperDownloadLogEN.Memo == "[null]" ? null :  objvPaperDownloadLogEN.Memo; //备注
}
if (arrFldSet.Contains(convPaperDownloadLog.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperDownloadLogEN.PaperTitle = objvPaperDownloadLogEN.PaperTitle == "[null]" ? null :  objvPaperDownloadLogEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convPaperDownloadLog.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperDownloadLogEN.Author = objvPaperDownloadLogEN.Author == "[null]" ? null :  objvPaperDownloadLogEN.Author; //作者
}
if (arrFldSet.Contains(convPaperDownloadLog.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperDownloadLogEN.Keyword = objvPaperDownloadLogEN.Keyword == "[null]" ? null :  objvPaperDownloadLogEN.Keyword; //关键字
}
if (arrFldSet.Contains(convPaperDownloadLog.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperDownloadLogEN.UserName = objvPaperDownloadLogEN.UserName == "[null]" ? null :  objvPaperDownloadLogEN.UserName; //用户名
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
 /// <param name = "objvPaperDownloadLogEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPaperDownloadLogEN objvPaperDownloadLogEN)
{
try
{
if (objvPaperDownloadLogEN.DownloadFile == "[null]") objvPaperDownloadLogEN.DownloadFile = null; //DownloadFile
if (objvPaperDownloadLogEN.DownloadLink == "[null]") objvPaperDownloadLogEN.DownloadLink = null; //DownloadLink
if (objvPaperDownloadLogEN.PaperId == "[null]") objvPaperDownloadLogEN.PaperId = null; //论文Id
if (objvPaperDownloadLogEN.UpdUser == "[null]") objvPaperDownloadLogEN.UpdUser = null; //修改人
if (objvPaperDownloadLogEN.UpdDate == "[null]") objvPaperDownloadLogEN.UpdDate = null; //修改日期
if (objvPaperDownloadLogEN.Memo == "[null]") objvPaperDownloadLogEN.Memo = null; //备注
if (objvPaperDownloadLogEN.PaperTitle == "[null]") objvPaperDownloadLogEN.PaperTitle = null; //论文标题
if (objvPaperDownloadLogEN.Author == "[null]") objvPaperDownloadLogEN.Author = null; //作者
if (objvPaperDownloadLogEN.Keyword == "[null]") objvPaperDownloadLogEN.Keyword = null; //关键字
if (objvPaperDownloadLogEN.UserName == "[null]") objvPaperDownloadLogEN.UserName = null; //用户名
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
public static void CheckProperty4Condition(clsvPaperDownloadLogEN objvPaperDownloadLogEN)
{
 vPaperDownloadLogDA.CheckProperty4Condition(objvPaperDownloadLogEN);
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
if (clsPaperDownloadLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperDownloadLogBL没有刷新缓存机制(clsPaperDownloadLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperDownloadId");
//if (arrvPaperDownloadLogObjLstCache == null)
//{
//arrvPaperDownloadLogObjLstCache = vPaperDownloadLogDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngPaperDownloadId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperDownloadLogEN GetObjByPaperDownloadIdCache(long lngPaperDownloadId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPaperDownloadLogEN._CurrTabName);
List<clsvPaperDownloadLogEN> arrvPaperDownloadLogObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperDownloadLogEN> arrvPaperDownloadLogObjLst_Sel =
arrvPaperDownloadLogObjLstCache
.Where(x=> x.PaperDownloadId == lngPaperDownloadId 
);
if (arrvPaperDownloadLogObjLst_Sel.Count() == 0)
{
   clsvPaperDownloadLogEN obj = clsvPaperDownloadLogBL.GetObjByPaperDownloadId(lngPaperDownloadId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPaperDownloadLogObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperDownloadLogEN> GetAllvPaperDownloadLogObjLstCache()
{
//获取缓存中的对象列表
List<clsvPaperDownloadLogEN> arrvPaperDownloadLogObjLstCache = GetObjLstCache(); 
return arrvPaperDownloadLogObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperDownloadLogEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPaperDownloadLogEN._CurrTabName);
List<clsvPaperDownloadLogEN> arrvPaperDownloadLogObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPaperDownloadLogObjLstCache;
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
string strKey = string.Format("{0}", clsvPaperDownloadLogEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngPaperDownloadId)
{
if (strInFldName != convPaperDownloadLog.PaperDownloadId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPaperDownloadLog.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPaperDownloadLog.AttributeName));
throw new Exception(strMsg);
}
var objvPaperDownloadLog = clsvPaperDownloadLogBL.GetObjByPaperDownloadIdCache(lngPaperDownloadId);
if (objvPaperDownloadLog == null) return "";
return objvPaperDownloadLog[strOutFldName].ToString();
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
int intRecCount = clsvPaperDownloadLogDA.GetRecCount(strTabName);
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
int intRecCount = clsvPaperDownloadLogDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPaperDownloadLogDA.GetRecCount();
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
int intRecCount = clsvPaperDownloadLogDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPaperDownloadLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPaperDownloadLogEN objvPaperDownloadLogCond)
{
List<clsvPaperDownloadLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperDownloadLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperDownloadLog.AttributeName)
{
if (objvPaperDownloadLogCond.IsUpdated(strFldName) == false) continue;
if (objvPaperDownloadLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperDownloadLogCond[strFldName].ToString());
}
else
{
if (objvPaperDownloadLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperDownloadLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperDownloadLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperDownloadLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperDownloadLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperDownloadLogCond[strFldName]));
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
 List<string> arrList = clsvPaperDownloadLogDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPaperDownloadLogDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPaperDownloadLogDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}