
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperAppraiseBL
 表名:vPaperAppraise(01120568)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:11
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
public static class  clsvPaperAppraiseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperAppraiseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperAppraiseEN GetObj(this K_PaperAppraiseId_vPaperAppraise myKey)
{
clsvPaperAppraiseEN objvPaperAppraiseEN = clsvPaperAppraiseBL.vPaperAppraiseDA.GetObjByPaperAppraiseId(myKey.Value);
return objvPaperAppraiseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperAppraiseEN SetPaperAppraiseId(this clsvPaperAppraiseEN objvPaperAppraiseEN, long lngPaperAppraiseId, string strComparisonOp="")
	{
objvPaperAppraiseEN.PaperAppraiseId = lngPaperAppraiseId; //论文评论Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.PaperAppraiseId) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.PaperAppraiseId, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.PaperAppraiseId] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperAppraiseEN SetPaperAppraiseContent(this clsvPaperAppraiseEN objvPaperAppraiseEN, string strPaperAppraiseContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperAppraiseContent, 2000, convPaperAppraise.PaperAppraiseContent);
}
objvPaperAppraiseEN.PaperAppraiseContent = strPaperAppraiseContent; //论文评论内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.PaperAppraiseContent) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.PaperAppraiseContent, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.PaperAppraiseContent] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperAppraiseEN SetAppraiseScore(this clsvPaperAppraiseEN objvPaperAppraiseEN, float? fltAppraiseScore, string strComparisonOp="")
	{
objvPaperAppraiseEN.AppraiseScore = fltAppraiseScore; //打分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.AppraiseScore) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.AppraiseScore, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.AppraiseScore] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperAppraiseEN SetPaperId(this clsvPaperAppraiseEN objvPaperAppraiseEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convPaperAppraise.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convPaperAppraise.PaperId);
}
objvPaperAppraiseEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.PaperId) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.PaperId, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.PaperId] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperAppraiseEN SetUpdUser(this clsvPaperAppraiseEN objvPaperAppraiseEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPaperAppraise.UpdUser);
}
objvPaperAppraiseEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.UpdUser) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.UpdUser, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.UpdUser] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperAppraiseEN SetUpdDate(this clsvPaperAppraiseEN objvPaperAppraiseEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPaperAppraise.UpdDate);
}
objvPaperAppraiseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.UpdDate) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.UpdDate, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.UpdDate] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperAppraiseEN SetMemo(this clsvPaperAppraiseEN objvPaperAppraiseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPaperAppraise.Memo);
}
objvPaperAppraiseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.Memo) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.Memo, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.Memo] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperAppraiseEN SetPaperTitle(this clsvPaperAppraiseEN objvPaperAppraiseEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convPaperAppraise.PaperTitle);
}
objvPaperAppraiseEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.PaperTitle) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.PaperTitle, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.PaperTitle] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperAppraiseEN SetResearchQuestion(this clsvPaperAppraiseEN objvPaperAppraiseEN, string strResearchQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, convPaperAppraise.ResearchQuestion);
}
objvPaperAppraiseEN.ResearchQuestion = strResearchQuestion; //研究问题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.ResearchQuestion) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.ResearchQuestion, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.ResearchQuestion] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperAppraiseEN SetAuthor(this clsvPaperAppraiseEN objvPaperAppraiseEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convPaperAppraise.Author);
}
objvPaperAppraiseEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.Author) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.Author, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.Author] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperAppraiseEN SetKeyword(this clsvPaperAppraiseEN objvPaperAppraiseEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convPaperAppraise.Keyword);
}
objvPaperAppraiseEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.Keyword) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.Keyword, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.Keyword] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperAppraiseEN SetBrowseNumber(this clsvPaperAppraiseEN objvPaperAppraiseEN, int? intBrowseNumber, string strComparisonOp="")
	{
objvPaperAppraiseEN.BrowseNumber = intBrowseNumber; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.BrowseNumber) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.BrowseNumber, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.BrowseNumber] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperAppraiseEN SetUserName(this clsvPaperAppraiseEN objvPaperAppraiseEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convPaperAppraise.UserName);
}
objvPaperAppraiseEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.UserName) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.UserName, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.UserName] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPaperAppraiseENS">源对象</param>
 /// <param name = "objvPaperAppraiseENT">目标对象</param>
 public static void CopyTo(this clsvPaperAppraiseEN objvPaperAppraiseENS, clsvPaperAppraiseEN objvPaperAppraiseENT)
{
try
{
objvPaperAppraiseENT.PaperAppraiseId = objvPaperAppraiseENS.PaperAppraiseId; //论文评论Id
objvPaperAppraiseENT.PaperAppraiseContent = objvPaperAppraiseENS.PaperAppraiseContent; //论文评论内容
objvPaperAppraiseENT.AppraiseScore = objvPaperAppraiseENS.AppraiseScore; //打分
objvPaperAppraiseENT.PaperId = objvPaperAppraiseENS.PaperId; //论文Id
objvPaperAppraiseENT.UpdUser = objvPaperAppraiseENS.UpdUser; //修改人
objvPaperAppraiseENT.UpdDate = objvPaperAppraiseENS.UpdDate; //修改日期
objvPaperAppraiseENT.Memo = objvPaperAppraiseENS.Memo; //备注
objvPaperAppraiseENT.PaperTitle = objvPaperAppraiseENS.PaperTitle; //论文标题
objvPaperAppraiseENT.ResearchQuestion = objvPaperAppraiseENS.ResearchQuestion; //研究问题
objvPaperAppraiseENT.Author = objvPaperAppraiseENS.Author; //作者
objvPaperAppraiseENT.Keyword = objvPaperAppraiseENS.Keyword; //关键字
objvPaperAppraiseENT.BrowseNumber = objvPaperAppraiseENS.BrowseNumber; //浏览量
objvPaperAppraiseENT.UserName = objvPaperAppraiseENS.UserName; //用户名
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
 /// <param name = "objvPaperAppraiseENS">源对象</param>
 /// <returns>目标对象=>clsvPaperAppraiseEN:objvPaperAppraiseENT</returns>
 public static clsvPaperAppraiseEN CopyTo(this clsvPaperAppraiseEN objvPaperAppraiseENS)
{
try
{
 clsvPaperAppraiseEN objvPaperAppraiseENT = new clsvPaperAppraiseEN()
{
PaperAppraiseId = objvPaperAppraiseENS.PaperAppraiseId, //论文评论Id
PaperAppraiseContent = objvPaperAppraiseENS.PaperAppraiseContent, //论文评论内容
AppraiseScore = objvPaperAppraiseENS.AppraiseScore, //打分
PaperId = objvPaperAppraiseENS.PaperId, //论文Id
UpdUser = objvPaperAppraiseENS.UpdUser, //修改人
UpdDate = objvPaperAppraiseENS.UpdDate, //修改日期
Memo = objvPaperAppraiseENS.Memo, //备注
PaperTitle = objvPaperAppraiseENS.PaperTitle, //论文标题
ResearchQuestion = objvPaperAppraiseENS.ResearchQuestion, //研究问题
Author = objvPaperAppraiseENS.Author, //作者
Keyword = objvPaperAppraiseENS.Keyword, //关键字
BrowseNumber = objvPaperAppraiseENS.BrowseNumber, //浏览量
UserName = objvPaperAppraiseENS.UserName, //用户名
};
 return objvPaperAppraiseENT;
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
public static void CheckProperty4Condition(this clsvPaperAppraiseEN objvPaperAppraiseEN)
{
 clsvPaperAppraiseBL.vPaperAppraiseDA.CheckProperty4Condition(objvPaperAppraiseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPaperAppraiseEN objvPaperAppraiseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPaperAppraiseCond.IsUpdated(convPaperAppraise.PaperAppraiseId) == true)
{
string strComparisonOpPaperAppraiseId = objvPaperAppraiseCond.dicFldComparisonOp[convPaperAppraise.PaperAppraiseId];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperAppraise.PaperAppraiseId, objvPaperAppraiseCond.PaperAppraiseId, strComparisonOpPaperAppraiseId);
}
if (objvPaperAppraiseCond.IsUpdated(convPaperAppraise.PaperAppraiseContent) == true)
{
string strComparisonOpPaperAppraiseContent = objvPaperAppraiseCond.dicFldComparisonOp[convPaperAppraise.PaperAppraiseContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperAppraise.PaperAppraiseContent, objvPaperAppraiseCond.PaperAppraiseContent, strComparisonOpPaperAppraiseContent);
}
if (objvPaperAppraiseCond.IsUpdated(convPaperAppraise.AppraiseScore) == true)
{
string strComparisonOpAppraiseScore = objvPaperAppraiseCond.dicFldComparisonOp[convPaperAppraise.AppraiseScore];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperAppraise.AppraiseScore, objvPaperAppraiseCond.AppraiseScore, strComparisonOpAppraiseScore);
}
if (objvPaperAppraiseCond.IsUpdated(convPaperAppraise.PaperId) == true)
{
string strComparisonOpPaperId = objvPaperAppraiseCond.dicFldComparisonOp[convPaperAppraise.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperAppraise.PaperId, objvPaperAppraiseCond.PaperId, strComparisonOpPaperId);
}
if (objvPaperAppraiseCond.IsUpdated(convPaperAppraise.UpdUser) == true)
{
string strComparisonOpUpdUser = objvPaperAppraiseCond.dicFldComparisonOp[convPaperAppraise.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperAppraise.UpdUser, objvPaperAppraiseCond.UpdUser, strComparisonOpUpdUser);
}
if (objvPaperAppraiseCond.IsUpdated(convPaperAppraise.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPaperAppraiseCond.dicFldComparisonOp[convPaperAppraise.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperAppraise.UpdDate, objvPaperAppraiseCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPaperAppraiseCond.IsUpdated(convPaperAppraise.Memo) == true)
{
string strComparisonOpMemo = objvPaperAppraiseCond.dicFldComparisonOp[convPaperAppraise.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperAppraise.Memo, objvPaperAppraiseCond.Memo, strComparisonOpMemo);
}
if (objvPaperAppraiseCond.IsUpdated(convPaperAppraise.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvPaperAppraiseCond.dicFldComparisonOp[convPaperAppraise.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperAppraise.PaperTitle, objvPaperAppraiseCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvPaperAppraiseCond.IsUpdated(convPaperAppraise.ResearchQuestion) == true)
{
string strComparisonOpResearchQuestion = objvPaperAppraiseCond.dicFldComparisonOp[convPaperAppraise.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperAppraise.ResearchQuestion, objvPaperAppraiseCond.ResearchQuestion, strComparisonOpResearchQuestion);
}
if (objvPaperAppraiseCond.IsUpdated(convPaperAppraise.Author) == true)
{
string strComparisonOpAuthor = objvPaperAppraiseCond.dicFldComparisonOp[convPaperAppraise.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperAppraise.Author, objvPaperAppraiseCond.Author, strComparisonOpAuthor);
}
if (objvPaperAppraiseCond.IsUpdated(convPaperAppraise.Keyword) == true)
{
string strComparisonOpKeyword = objvPaperAppraiseCond.dicFldComparisonOp[convPaperAppraise.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperAppraise.Keyword, objvPaperAppraiseCond.Keyword, strComparisonOpKeyword);
}
if (objvPaperAppraiseCond.IsUpdated(convPaperAppraise.BrowseNumber) == true)
{
string strComparisonOpBrowseNumber = objvPaperAppraiseCond.dicFldComparisonOp[convPaperAppraise.BrowseNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperAppraise.BrowseNumber, objvPaperAppraiseCond.BrowseNumber, strComparisonOpBrowseNumber);
}
if (objvPaperAppraiseCond.IsUpdated(convPaperAppraise.UserName) == true)
{
string strComparisonOpUserName = objvPaperAppraiseCond.dicFldComparisonOp[convPaperAppraise.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperAppraise.UserName, objvPaperAppraiseCond.UserName, strComparisonOpUserName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPaperAppraise
{
public virtual bool UpdRelaTabDate(long lngPaperAppraiseId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v论文评论表(vPaperAppraise)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPaperAppraiseBL
{
public static RelatedActions_vPaperAppraise relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPaperAppraiseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPaperAppraiseDA vPaperAppraiseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPaperAppraiseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPaperAppraiseBL()
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
if (string.IsNullOrEmpty(clsvPaperAppraiseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPaperAppraiseEN._ConnectString);
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
public static DataTable GetDataTable_vPaperAppraise(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPaperAppraiseDA.GetDataTable_vPaperAppraise(strWhereCond);
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
objDT = vPaperAppraiseDA.GetDataTable(strWhereCond);
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
objDT = vPaperAppraiseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPaperAppraiseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPaperAppraiseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPaperAppraiseDA.GetDataTable_Top(objTopPara);
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
objDT = vPaperAppraiseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPaperAppraiseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPaperAppraiseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPaperAppraiseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPaperAppraiseEN> GetObjLstByPaperAppraiseIdLst(List<long> arrPaperAppraiseIdLst)
{
List<clsvPaperAppraiseEN> arrObjLst = new List<clsvPaperAppraiseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPaperAppraiseIdLst);
 string strWhereCond = string.Format("PaperAppraiseId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperAppraiseEN objvPaperAppraiseEN = new clsvPaperAppraiseEN();
try
{
objvPaperAppraiseEN.PaperAppraiseId = Int32.Parse(objRow[convPaperAppraise.PaperAppraiseId].ToString().Trim()); //论文评论Id
objvPaperAppraiseEN.PaperAppraiseContent = objRow[convPaperAppraise.PaperAppraiseContent] == DBNull.Value ? null : objRow[convPaperAppraise.PaperAppraiseContent].ToString().Trim(); //论文评论内容
objvPaperAppraiseEN.AppraiseScore = objRow[convPaperAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperAppraiseEN.PaperId = objRow[convPaperAppraise.PaperId] == DBNull.Value ? null : objRow[convPaperAppraise.PaperId].ToString().Trim(); //论文Id
objvPaperAppraiseEN.UpdUser = objRow[convPaperAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperAppraise.UpdUser].ToString().Trim(); //修改人
objvPaperAppraiseEN.UpdDate = objRow[convPaperAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperAppraiseEN.Memo = objRow[convPaperAppraise.Memo] == DBNull.Value ? null : objRow[convPaperAppraise.Memo].ToString().Trim(); //备注
objvPaperAppraiseEN.PaperTitle = objRow[convPaperAppraise.PaperTitle] == DBNull.Value ? null : objRow[convPaperAppraise.PaperTitle].ToString().Trim(); //论文标题
objvPaperAppraiseEN.ResearchQuestion = objRow[convPaperAppraise.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperAppraise.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperAppraiseEN.Author = objRow[convPaperAppraise.Author] == DBNull.Value ? null : objRow[convPaperAppraise.Author].ToString().Trim(); //作者
objvPaperAppraiseEN.Keyword = objRow[convPaperAppraise.Keyword] == DBNull.Value ? null : objRow[convPaperAppraise.Keyword].ToString().Trim(); //关键字
objvPaperAppraiseEN.BrowseNumber = objRow[convPaperAppraise.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperAppraise.BrowseNumber].ToString().Trim()); //浏览量
objvPaperAppraiseEN.UserName = objRow[convPaperAppraise.UserName] == DBNull.Value ? null : objRow[convPaperAppraise.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperAppraiseEN.PaperAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperAppraiseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPaperAppraiseEN> GetObjLstByPaperAppraiseIdLstCache(List<long> arrPaperAppraiseIdLst)
{
string strKey = string.Format("{0}", clsvPaperAppraiseEN._CurrTabName);
List<clsvPaperAppraiseEN> arrvPaperAppraiseObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperAppraiseEN> arrvPaperAppraiseObjLst_Sel =
arrvPaperAppraiseObjLstCache
.Where(x => arrPaperAppraiseIdLst.Contains(x.PaperAppraiseId));
return arrvPaperAppraiseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperAppraiseEN> GetObjLst(string strWhereCond)
{
List<clsvPaperAppraiseEN> arrObjLst = new List<clsvPaperAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperAppraiseEN objvPaperAppraiseEN = new clsvPaperAppraiseEN();
try
{
objvPaperAppraiseEN.PaperAppraiseId = Int32.Parse(objRow[convPaperAppraise.PaperAppraiseId].ToString().Trim()); //论文评论Id
objvPaperAppraiseEN.PaperAppraiseContent = objRow[convPaperAppraise.PaperAppraiseContent] == DBNull.Value ? null : objRow[convPaperAppraise.PaperAppraiseContent].ToString().Trim(); //论文评论内容
objvPaperAppraiseEN.AppraiseScore = objRow[convPaperAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperAppraiseEN.PaperId = objRow[convPaperAppraise.PaperId] == DBNull.Value ? null : objRow[convPaperAppraise.PaperId].ToString().Trim(); //论文Id
objvPaperAppraiseEN.UpdUser = objRow[convPaperAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperAppraise.UpdUser].ToString().Trim(); //修改人
objvPaperAppraiseEN.UpdDate = objRow[convPaperAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperAppraiseEN.Memo = objRow[convPaperAppraise.Memo] == DBNull.Value ? null : objRow[convPaperAppraise.Memo].ToString().Trim(); //备注
objvPaperAppraiseEN.PaperTitle = objRow[convPaperAppraise.PaperTitle] == DBNull.Value ? null : objRow[convPaperAppraise.PaperTitle].ToString().Trim(); //论文标题
objvPaperAppraiseEN.ResearchQuestion = objRow[convPaperAppraise.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperAppraise.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperAppraiseEN.Author = objRow[convPaperAppraise.Author] == DBNull.Value ? null : objRow[convPaperAppraise.Author].ToString().Trim(); //作者
objvPaperAppraiseEN.Keyword = objRow[convPaperAppraise.Keyword] == DBNull.Value ? null : objRow[convPaperAppraise.Keyword].ToString().Trim(); //关键字
objvPaperAppraiseEN.BrowseNumber = objRow[convPaperAppraise.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperAppraise.BrowseNumber].ToString().Trim()); //浏览量
objvPaperAppraiseEN.UserName = objRow[convPaperAppraise.UserName] == DBNull.Value ? null : objRow[convPaperAppraise.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperAppraiseEN.PaperAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperAppraiseEN);
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
public static List<clsvPaperAppraiseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPaperAppraiseEN> arrObjLst = new List<clsvPaperAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperAppraiseEN objvPaperAppraiseEN = new clsvPaperAppraiseEN();
try
{
objvPaperAppraiseEN.PaperAppraiseId = Int32.Parse(objRow[convPaperAppraise.PaperAppraiseId].ToString().Trim()); //论文评论Id
objvPaperAppraiseEN.PaperAppraiseContent = objRow[convPaperAppraise.PaperAppraiseContent] == DBNull.Value ? null : objRow[convPaperAppraise.PaperAppraiseContent].ToString().Trim(); //论文评论内容
objvPaperAppraiseEN.AppraiseScore = objRow[convPaperAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperAppraiseEN.PaperId = objRow[convPaperAppraise.PaperId] == DBNull.Value ? null : objRow[convPaperAppraise.PaperId].ToString().Trim(); //论文Id
objvPaperAppraiseEN.UpdUser = objRow[convPaperAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperAppraise.UpdUser].ToString().Trim(); //修改人
objvPaperAppraiseEN.UpdDate = objRow[convPaperAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperAppraiseEN.Memo = objRow[convPaperAppraise.Memo] == DBNull.Value ? null : objRow[convPaperAppraise.Memo].ToString().Trim(); //备注
objvPaperAppraiseEN.PaperTitle = objRow[convPaperAppraise.PaperTitle] == DBNull.Value ? null : objRow[convPaperAppraise.PaperTitle].ToString().Trim(); //论文标题
objvPaperAppraiseEN.ResearchQuestion = objRow[convPaperAppraise.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperAppraise.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperAppraiseEN.Author = objRow[convPaperAppraise.Author] == DBNull.Value ? null : objRow[convPaperAppraise.Author].ToString().Trim(); //作者
objvPaperAppraiseEN.Keyword = objRow[convPaperAppraise.Keyword] == DBNull.Value ? null : objRow[convPaperAppraise.Keyword].ToString().Trim(); //关键字
objvPaperAppraiseEN.BrowseNumber = objRow[convPaperAppraise.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperAppraise.BrowseNumber].ToString().Trim()); //浏览量
objvPaperAppraiseEN.UserName = objRow[convPaperAppraise.UserName] == DBNull.Value ? null : objRow[convPaperAppraise.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperAppraiseEN.PaperAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPaperAppraiseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPaperAppraiseEN> GetSubObjLstCache(clsvPaperAppraiseEN objvPaperAppraiseCond)
{
List<clsvPaperAppraiseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperAppraiseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperAppraise.AttributeName)
{
if (objvPaperAppraiseCond.IsUpdated(strFldName) == false) continue;
if (objvPaperAppraiseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperAppraiseCond[strFldName].ToString());
}
else
{
if (objvPaperAppraiseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperAppraiseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperAppraiseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperAppraiseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperAppraiseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperAppraiseCond[strFldName]));
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
public static List<clsvPaperAppraiseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPaperAppraiseEN> arrObjLst = new List<clsvPaperAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperAppraiseEN objvPaperAppraiseEN = new clsvPaperAppraiseEN();
try
{
objvPaperAppraiseEN.PaperAppraiseId = Int32.Parse(objRow[convPaperAppraise.PaperAppraiseId].ToString().Trim()); //论文评论Id
objvPaperAppraiseEN.PaperAppraiseContent = objRow[convPaperAppraise.PaperAppraiseContent] == DBNull.Value ? null : objRow[convPaperAppraise.PaperAppraiseContent].ToString().Trim(); //论文评论内容
objvPaperAppraiseEN.AppraiseScore = objRow[convPaperAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperAppraiseEN.PaperId = objRow[convPaperAppraise.PaperId] == DBNull.Value ? null : objRow[convPaperAppraise.PaperId].ToString().Trim(); //论文Id
objvPaperAppraiseEN.UpdUser = objRow[convPaperAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperAppraise.UpdUser].ToString().Trim(); //修改人
objvPaperAppraiseEN.UpdDate = objRow[convPaperAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperAppraiseEN.Memo = objRow[convPaperAppraise.Memo] == DBNull.Value ? null : objRow[convPaperAppraise.Memo].ToString().Trim(); //备注
objvPaperAppraiseEN.PaperTitle = objRow[convPaperAppraise.PaperTitle] == DBNull.Value ? null : objRow[convPaperAppraise.PaperTitle].ToString().Trim(); //论文标题
objvPaperAppraiseEN.ResearchQuestion = objRow[convPaperAppraise.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperAppraise.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperAppraiseEN.Author = objRow[convPaperAppraise.Author] == DBNull.Value ? null : objRow[convPaperAppraise.Author].ToString().Trim(); //作者
objvPaperAppraiseEN.Keyword = objRow[convPaperAppraise.Keyword] == DBNull.Value ? null : objRow[convPaperAppraise.Keyword].ToString().Trim(); //关键字
objvPaperAppraiseEN.BrowseNumber = objRow[convPaperAppraise.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperAppraise.BrowseNumber].ToString().Trim()); //浏览量
objvPaperAppraiseEN.UserName = objRow[convPaperAppraise.UserName] == DBNull.Value ? null : objRow[convPaperAppraise.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperAppraiseEN.PaperAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperAppraiseEN);
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
public static List<clsvPaperAppraiseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPaperAppraiseEN> arrObjLst = new List<clsvPaperAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperAppraiseEN objvPaperAppraiseEN = new clsvPaperAppraiseEN();
try
{
objvPaperAppraiseEN.PaperAppraiseId = Int32.Parse(objRow[convPaperAppraise.PaperAppraiseId].ToString().Trim()); //论文评论Id
objvPaperAppraiseEN.PaperAppraiseContent = objRow[convPaperAppraise.PaperAppraiseContent] == DBNull.Value ? null : objRow[convPaperAppraise.PaperAppraiseContent].ToString().Trim(); //论文评论内容
objvPaperAppraiseEN.AppraiseScore = objRow[convPaperAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperAppraiseEN.PaperId = objRow[convPaperAppraise.PaperId] == DBNull.Value ? null : objRow[convPaperAppraise.PaperId].ToString().Trim(); //论文Id
objvPaperAppraiseEN.UpdUser = objRow[convPaperAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperAppraise.UpdUser].ToString().Trim(); //修改人
objvPaperAppraiseEN.UpdDate = objRow[convPaperAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperAppraiseEN.Memo = objRow[convPaperAppraise.Memo] == DBNull.Value ? null : objRow[convPaperAppraise.Memo].ToString().Trim(); //备注
objvPaperAppraiseEN.PaperTitle = objRow[convPaperAppraise.PaperTitle] == DBNull.Value ? null : objRow[convPaperAppraise.PaperTitle].ToString().Trim(); //论文标题
objvPaperAppraiseEN.ResearchQuestion = objRow[convPaperAppraise.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperAppraise.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperAppraiseEN.Author = objRow[convPaperAppraise.Author] == DBNull.Value ? null : objRow[convPaperAppraise.Author].ToString().Trim(); //作者
objvPaperAppraiseEN.Keyword = objRow[convPaperAppraise.Keyword] == DBNull.Value ? null : objRow[convPaperAppraise.Keyword].ToString().Trim(); //关键字
objvPaperAppraiseEN.BrowseNumber = objRow[convPaperAppraise.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperAppraise.BrowseNumber].ToString().Trim()); //浏览量
objvPaperAppraiseEN.UserName = objRow[convPaperAppraise.UserName] == DBNull.Value ? null : objRow[convPaperAppraise.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperAppraiseEN.PaperAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperAppraiseEN);
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
List<clsvPaperAppraiseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPaperAppraiseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperAppraiseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPaperAppraiseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperAppraiseEN> arrObjLst = new List<clsvPaperAppraiseEN>(); 
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
	clsvPaperAppraiseEN objvPaperAppraiseEN = new clsvPaperAppraiseEN();
try
{
objvPaperAppraiseEN.PaperAppraiseId = Int32.Parse(objRow[convPaperAppraise.PaperAppraiseId].ToString().Trim()); //论文评论Id
objvPaperAppraiseEN.PaperAppraiseContent = objRow[convPaperAppraise.PaperAppraiseContent] == DBNull.Value ? null : objRow[convPaperAppraise.PaperAppraiseContent].ToString().Trim(); //论文评论内容
objvPaperAppraiseEN.AppraiseScore = objRow[convPaperAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperAppraiseEN.PaperId = objRow[convPaperAppraise.PaperId] == DBNull.Value ? null : objRow[convPaperAppraise.PaperId].ToString().Trim(); //论文Id
objvPaperAppraiseEN.UpdUser = objRow[convPaperAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperAppraise.UpdUser].ToString().Trim(); //修改人
objvPaperAppraiseEN.UpdDate = objRow[convPaperAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperAppraiseEN.Memo = objRow[convPaperAppraise.Memo] == DBNull.Value ? null : objRow[convPaperAppraise.Memo].ToString().Trim(); //备注
objvPaperAppraiseEN.PaperTitle = objRow[convPaperAppraise.PaperTitle] == DBNull.Value ? null : objRow[convPaperAppraise.PaperTitle].ToString().Trim(); //论文标题
objvPaperAppraiseEN.ResearchQuestion = objRow[convPaperAppraise.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperAppraise.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperAppraiseEN.Author = objRow[convPaperAppraise.Author] == DBNull.Value ? null : objRow[convPaperAppraise.Author].ToString().Trim(); //作者
objvPaperAppraiseEN.Keyword = objRow[convPaperAppraise.Keyword] == DBNull.Value ? null : objRow[convPaperAppraise.Keyword].ToString().Trim(); //关键字
objvPaperAppraiseEN.BrowseNumber = objRow[convPaperAppraise.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperAppraise.BrowseNumber].ToString().Trim()); //浏览量
objvPaperAppraiseEN.UserName = objRow[convPaperAppraise.UserName] == DBNull.Value ? null : objRow[convPaperAppraise.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperAppraiseEN.PaperAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperAppraiseEN);
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
public static List<clsvPaperAppraiseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPaperAppraiseEN> arrObjLst = new List<clsvPaperAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperAppraiseEN objvPaperAppraiseEN = new clsvPaperAppraiseEN();
try
{
objvPaperAppraiseEN.PaperAppraiseId = Int32.Parse(objRow[convPaperAppraise.PaperAppraiseId].ToString().Trim()); //论文评论Id
objvPaperAppraiseEN.PaperAppraiseContent = objRow[convPaperAppraise.PaperAppraiseContent] == DBNull.Value ? null : objRow[convPaperAppraise.PaperAppraiseContent].ToString().Trim(); //论文评论内容
objvPaperAppraiseEN.AppraiseScore = objRow[convPaperAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperAppraiseEN.PaperId = objRow[convPaperAppraise.PaperId] == DBNull.Value ? null : objRow[convPaperAppraise.PaperId].ToString().Trim(); //论文Id
objvPaperAppraiseEN.UpdUser = objRow[convPaperAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperAppraise.UpdUser].ToString().Trim(); //修改人
objvPaperAppraiseEN.UpdDate = objRow[convPaperAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperAppraiseEN.Memo = objRow[convPaperAppraise.Memo] == DBNull.Value ? null : objRow[convPaperAppraise.Memo].ToString().Trim(); //备注
objvPaperAppraiseEN.PaperTitle = objRow[convPaperAppraise.PaperTitle] == DBNull.Value ? null : objRow[convPaperAppraise.PaperTitle].ToString().Trim(); //论文标题
objvPaperAppraiseEN.ResearchQuestion = objRow[convPaperAppraise.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperAppraise.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperAppraiseEN.Author = objRow[convPaperAppraise.Author] == DBNull.Value ? null : objRow[convPaperAppraise.Author].ToString().Trim(); //作者
objvPaperAppraiseEN.Keyword = objRow[convPaperAppraise.Keyword] == DBNull.Value ? null : objRow[convPaperAppraise.Keyword].ToString().Trim(); //关键字
objvPaperAppraiseEN.BrowseNumber = objRow[convPaperAppraise.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperAppraise.BrowseNumber].ToString().Trim()); //浏览量
objvPaperAppraiseEN.UserName = objRow[convPaperAppraise.UserName] == DBNull.Value ? null : objRow[convPaperAppraise.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperAppraiseEN.PaperAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPaperAppraiseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPaperAppraiseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperAppraiseEN> arrObjLst = new List<clsvPaperAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperAppraiseEN objvPaperAppraiseEN = new clsvPaperAppraiseEN();
try
{
objvPaperAppraiseEN.PaperAppraiseId = Int32.Parse(objRow[convPaperAppraise.PaperAppraiseId].ToString().Trim()); //论文评论Id
objvPaperAppraiseEN.PaperAppraiseContent = objRow[convPaperAppraise.PaperAppraiseContent] == DBNull.Value ? null : objRow[convPaperAppraise.PaperAppraiseContent].ToString().Trim(); //论文评论内容
objvPaperAppraiseEN.AppraiseScore = objRow[convPaperAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperAppraiseEN.PaperId = objRow[convPaperAppraise.PaperId] == DBNull.Value ? null : objRow[convPaperAppraise.PaperId].ToString().Trim(); //论文Id
objvPaperAppraiseEN.UpdUser = objRow[convPaperAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperAppraise.UpdUser].ToString().Trim(); //修改人
objvPaperAppraiseEN.UpdDate = objRow[convPaperAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperAppraiseEN.Memo = objRow[convPaperAppraise.Memo] == DBNull.Value ? null : objRow[convPaperAppraise.Memo].ToString().Trim(); //备注
objvPaperAppraiseEN.PaperTitle = objRow[convPaperAppraise.PaperTitle] == DBNull.Value ? null : objRow[convPaperAppraise.PaperTitle].ToString().Trim(); //论文标题
objvPaperAppraiseEN.ResearchQuestion = objRow[convPaperAppraise.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperAppraise.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperAppraiseEN.Author = objRow[convPaperAppraise.Author] == DBNull.Value ? null : objRow[convPaperAppraise.Author].ToString().Trim(); //作者
objvPaperAppraiseEN.Keyword = objRow[convPaperAppraise.Keyword] == DBNull.Value ? null : objRow[convPaperAppraise.Keyword].ToString().Trim(); //关键字
objvPaperAppraiseEN.BrowseNumber = objRow[convPaperAppraise.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperAppraise.BrowseNumber].ToString().Trim()); //浏览量
objvPaperAppraiseEN.UserName = objRow[convPaperAppraise.UserName] == DBNull.Value ? null : objRow[convPaperAppraise.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperAppraiseEN.PaperAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperAppraiseEN);
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
public static List<clsvPaperAppraiseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPaperAppraiseEN> arrObjLst = new List<clsvPaperAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperAppraiseEN objvPaperAppraiseEN = new clsvPaperAppraiseEN();
try
{
objvPaperAppraiseEN.PaperAppraiseId = Int32.Parse(objRow[convPaperAppraise.PaperAppraiseId].ToString().Trim()); //论文评论Id
objvPaperAppraiseEN.PaperAppraiseContent = objRow[convPaperAppraise.PaperAppraiseContent] == DBNull.Value ? null : objRow[convPaperAppraise.PaperAppraiseContent].ToString().Trim(); //论文评论内容
objvPaperAppraiseEN.AppraiseScore = objRow[convPaperAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperAppraiseEN.PaperId = objRow[convPaperAppraise.PaperId] == DBNull.Value ? null : objRow[convPaperAppraise.PaperId].ToString().Trim(); //论文Id
objvPaperAppraiseEN.UpdUser = objRow[convPaperAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperAppraise.UpdUser].ToString().Trim(); //修改人
objvPaperAppraiseEN.UpdDate = objRow[convPaperAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperAppraiseEN.Memo = objRow[convPaperAppraise.Memo] == DBNull.Value ? null : objRow[convPaperAppraise.Memo].ToString().Trim(); //备注
objvPaperAppraiseEN.PaperTitle = objRow[convPaperAppraise.PaperTitle] == DBNull.Value ? null : objRow[convPaperAppraise.PaperTitle].ToString().Trim(); //论文标题
objvPaperAppraiseEN.ResearchQuestion = objRow[convPaperAppraise.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperAppraise.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperAppraiseEN.Author = objRow[convPaperAppraise.Author] == DBNull.Value ? null : objRow[convPaperAppraise.Author].ToString().Trim(); //作者
objvPaperAppraiseEN.Keyword = objRow[convPaperAppraise.Keyword] == DBNull.Value ? null : objRow[convPaperAppraise.Keyword].ToString().Trim(); //关键字
objvPaperAppraiseEN.BrowseNumber = objRow[convPaperAppraise.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperAppraise.BrowseNumber].ToString().Trim()); //浏览量
objvPaperAppraiseEN.UserName = objRow[convPaperAppraise.UserName] == DBNull.Value ? null : objRow[convPaperAppraise.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperAppraiseEN.PaperAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperAppraiseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPaperAppraiseEN> arrObjLst = new List<clsvPaperAppraiseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperAppraiseEN objvPaperAppraiseEN = new clsvPaperAppraiseEN();
try
{
objvPaperAppraiseEN.PaperAppraiseId = Int32.Parse(objRow[convPaperAppraise.PaperAppraiseId].ToString().Trim()); //论文评论Id
objvPaperAppraiseEN.PaperAppraiseContent = objRow[convPaperAppraise.PaperAppraiseContent] == DBNull.Value ? null : objRow[convPaperAppraise.PaperAppraiseContent].ToString().Trim(); //论文评论内容
objvPaperAppraiseEN.AppraiseScore = objRow[convPaperAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperAppraiseEN.PaperId = objRow[convPaperAppraise.PaperId] == DBNull.Value ? null : objRow[convPaperAppraise.PaperId].ToString().Trim(); //论文Id
objvPaperAppraiseEN.UpdUser = objRow[convPaperAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperAppraise.UpdUser].ToString().Trim(); //修改人
objvPaperAppraiseEN.UpdDate = objRow[convPaperAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperAppraiseEN.Memo = objRow[convPaperAppraise.Memo] == DBNull.Value ? null : objRow[convPaperAppraise.Memo].ToString().Trim(); //备注
objvPaperAppraiseEN.PaperTitle = objRow[convPaperAppraise.PaperTitle] == DBNull.Value ? null : objRow[convPaperAppraise.PaperTitle].ToString().Trim(); //论文标题
objvPaperAppraiseEN.ResearchQuestion = objRow[convPaperAppraise.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperAppraise.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperAppraiseEN.Author = objRow[convPaperAppraise.Author] == DBNull.Value ? null : objRow[convPaperAppraise.Author].ToString().Trim(); //作者
objvPaperAppraiseEN.Keyword = objRow[convPaperAppraise.Keyword] == DBNull.Value ? null : objRow[convPaperAppraise.Keyword].ToString().Trim(); //关键字
objvPaperAppraiseEN.BrowseNumber = objRow[convPaperAppraise.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperAppraise.BrowseNumber].ToString().Trim()); //浏览量
objvPaperAppraiseEN.UserName = objRow[convPaperAppraise.UserName] == DBNull.Value ? null : objRow[convPaperAppraise.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperAppraiseEN.PaperAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperAppraiseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPaperAppraise(ref clsvPaperAppraiseEN objvPaperAppraiseEN)
{
bool bolResult = vPaperAppraiseDA.GetvPaperAppraise(ref objvPaperAppraiseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperAppraiseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperAppraiseEN GetObjByPaperAppraiseId(long lngPaperAppraiseId)
{
clsvPaperAppraiseEN objvPaperAppraiseEN = vPaperAppraiseDA.GetObjByPaperAppraiseId(lngPaperAppraiseId);
return objvPaperAppraiseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPaperAppraiseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPaperAppraiseEN objvPaperAppraiseEN = vPaperAppraiseDA.GetFirstObj(strWhereCond);
 return objvPaperAppraiseEN;
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
public static clsvPaperAppraiseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPaperAppraiseEN objvPaperAppraiseEN = vPaperAppraiseDA.GetObjByDataRow(objRow);
 return objvPaperAppraiseEN;
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
public static clsvPaperAppraiseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPaperAppraiseEN objvPaperAppraiseEN = vPaperAppraiseDA.GetObjByDataRow(objRow);
 return objvPaperAppraiseEN;
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
 /// <param name = "lngPaperAppraiseId">所给的关键字</param>
 /// <param name = "lstvPaperAppraiseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperAppraiseEN GetObjByPaperAppraiseIdFromList(long lngPaperAppraiseId, List<clsvPaperAppraiseEN> lstvPaperAppraiseObjLst)
{
foreach (clsvPaperAppraiseEN objvPaperAppraiseEN in lstvPaperAppraiseObjLst)
{
if (objvPaperAppraiseEN.PaperAppraiseId == lngPaperAppraiseId)
{
return objvPaperAppraiseEN;
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
 long lngPaperAppraiseId;
 try
 {
 lngPaperAppraiseId = new clsvPaperAppraiseDA().GetFirstID(strWhereCond);
 return lngPaperAppraiseId;
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
 arrList = vPaperAppraiseDA.GetID(strWhereCond);
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
bool bolIsExist = vPaperAppraiseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngPaperAppraiseId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngPaperAppraiseId)
{
//检测记录是否存在
bool bolIsExist = vPaperAppraiseDA.IsExist(lngPaperAppraiseId);
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
 bolIsExist = clsvPaperAppraiseDA.IsExistTable();
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
 bolIsExist = vPaperAppraiseDA.IsExistTable(strTabName);
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
 /// <param name = "objvPaperAppraiseENS">源对象</param>
 /// <param name = "objvPaperAppraiseENT">目标对象</param>
 public static void CopyTo(clsvPaperAppraiseEN objvPaperAppraiseENS, clsvPaperAppraiseEN objvPaperAppraiseENT)
{
try
{
objvPaperAppraiseENT.PaperAppraiseId = objvPaperAppraiseENS.PaperAppraiseId; //论文评论Id
objvPaperAppraiseENT.PaperAppraiseContent = objvPaperAppraiseENS.PaperAppraiseContent; //论文评论内容
objvPaperAppraiseENT.AppraiseScore = objvPaperAppraiseENS.AppraiseScore; //打分
objvPaperAppraiseENT.PaperId = objvPaperAppraiseENS.PaperId; //论文Id
objvPaperAppraiseENT.UpdUser = objvPaperAppraiseENS.UpdUser; //修改人
objvPaperAppraiseENT.UpdDate = objvPaperAppraiseENS.UpdDate; //修改日期
objvPaperAppraiseENT.Memo = objvPaperAppraiseENS.Memo; //备注
objvPaperAppraiseENT.PaperTitle = objvPaperAppraiseENS.PaperTitle; //论文标题
objvPaperAppraiseENT.ResearchQuestion = objvPaperAppraiseENS.ResearchQuestion; //研究问题
objvPaperAppraiseENT.Author = objvPaperAppraiseENS.Author; //作者
objvPaperAppraiseENT.Keyword = objvPaperAppraiseENS.Keyword; //关键字
objvPaperAppraiseENT.BrowseNumber = objvPaperAppraiseENS.BrowseNumber; //浏览量
objvPaperAppraiseENT.UserName = objvPaperAppraiseENS.UserName; //用户名
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
 /// <param name = "objvPaperAppraiseEN">源简化对象</param>
 public static void SetUpdFlag(clsvPaperAppraiseEN objvPaperAppraiseEN)
{
try
{
objvPaperAppraiseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPaperAppraiseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPaperAppraise.PaperAppraiseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperAppraiseEN.PaperAppraiseId = objvPaperAppraiseEN.PaperAppraiseId; //论文评论Id
}
if (arrFldSet.Contains(convPaperAppraise.PaperAppraiseContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperAppraiseEN.PaperAppraiseContent = objvPaperAppraiseEN.PaperAppraiseContent == "[null]" ? null :  objvPaperAppraiseEN.PaperAppraiseContent; //论文评论内容
}
if (arrFldSet.Contains(convPaperAppraise.AppraiseScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperAppraiseEN.AppraiseScore = objvPaperAppraiseEN.AppraiseScore; //打分
}
if (arrFldSet.Contains(convPaperAppraise.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperAppraiseEN.PaperId = objvPaperAppraiseEN.PaperId == "[null]" ? null :  objvPaperAppraiseEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convPaperAppraise.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperAppraiseEN.UpdUser = objvPaperAppraiseEN.UpdUser == "[null]" ? null :  objvPaperAppraiseEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convPaperAppraise.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperAppraiseEN.UpdDate = objvPaperAppraiseEN.UpdDate == "[null]" ? null :  objvPaperAppraiseEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPaperAppraise.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperAppraiseEN.Memo = objvPaperAppraiseEN.Memo == "[null]" ? null :  objvPaperAppraiseEN.Memo; //备注
}
if (arrFldSet.Contains(convPaperAppraise.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperAppraiseEN.PaperTitle = objvPaperAppraiseEN.PaperTitle == "[null]" ? null :  objvPaperAppraiseEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convPaperAppraise.ResearchQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperAppraiseEN.ResearchQuestion = objvPaperAppraiseEN.ResearchQuestion == "[null]" ? null :  objvPaperAppraiseEN.ResearchQuestion; //研究问题
}
if (arrFldSet.Contains(convPaperAppraise.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperAppraiseEN.Author = objvPaperAppraiseEN.Author == "[null]" ? null :  objvPaperAppraiseEN.Author; //作者
}
if (arrFldSet.Contains(convPaperAppraise.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperAppraiseEN.Keyword = objvPaperAppraiseEN.Keyword == "[null]" ? null :  objvPaperAppraiseEN.Keyword; //关键字
}
if (arrFldSet.Contains(convPaperAppraise.BrowseNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperAppraiseEN.BrowseNumber = objvPaperAppraiseEN.BrowseNumber; //浏览量
}
if (arrFldSet.Contains(convPaperAppraise.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperAppraiseEN.UserName = objvPaperAppraiseEN.UserName == "[null]" ? null :  objvPaperAppraiseEN.UserName; //用户名
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
 /// <param name = "objvPaperAppraiseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPaperAppraiseEN objvPaperAppraiseEN)
{
try
{
if (objvPaperAppraiseEN.PaperAppraiseContent == "[null]") objvPaperAppraiseEN.PaperAppraiseContent = null; //论文评论内容
if (objvPaperAppraiseEN.PaperId == "[null]") objvPaperAppraiseEN.PaperId = null; //论文Id
if (objvPaperAppraiseEN.UpdUser == "[null]") objvPaperAppraiseEN.UpdUser = null; //修改人
if (objvPaperAppraiseEN.UpdDate == "[null]") objvPaperAppraiseEN.UpdDate = null; //修改日期
if (objvPaperAppraiseEN.Memo == "[null]") objvPaperAppraiseEN.Memo = null; //备注
if (objvPaperAppraiseEN.PaperTitle == "[null]") objvPaperAppraiseEN.PaperTitle = null; //论文标题
if (objvPaperAppraiseEN.ResearchQuestion == "[null]") objvPaperAppraiseEN.ResearchQuestion = null; //研究问题
if (objvPaperAppraiseEN.Author == "[null]") objvPaperAppraiseEN.Author = null; //作者
if (objvPaperAppraiseEN.Keyword == "[null]") objvPaperAppraiseEN.Keyword = null; //关键字
if (objvPaperAppraiseEN.UserName == "[null]") objvPaperAppraiseEN.UserName = null; //用户名
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
public static void CheckProperty4Condition(clsvPaperAppraiseEN objvPaperAppraiseEN)
{
 vPaperAppraiseDA.CheckProperty4Condition(objvPaperAppraiseEN);
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
if (clsPaperAppraiseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperAppraiseBL没有刷新缓存机制(clsPaperAppraiseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperAppraiseId");
//if (arrvPaperAppraiseObjLstCache == null)
//{
//arrvPaperAppraiseObjLstCache = vPaperAppraiseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngPaperAppraiseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperAppraiseEN GetObjByPaperAppraiseIdCache(long lngPaperAppraiseId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPaperAppraiseEN._CurrTabName);
List<clsvPaperAppraiseEN> arrvPaperAppraiseObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperAppraiseEN> arrvPaperAppraiseObjLst_Sel =
arrvPaperAppraiseObjLstCache
.Where(x=> x.PaperAppraiseId == lngPaperAppraiseId 
);
if (arrvPaperAppraiseObjLst_Sel.Count() == 0)
{
   clsvPaperAppraiseEN obj = clsvPaperAppraiseBL.GetObjByPaperAppraiseId(lngPaperAppraiseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPaperAppraiseObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperAppraiseEN> GetAllvPaperAppraiseObjLstCache()
{
//获取缓存中的对象列表
List<clsvPaperAppraiseEN> arrvPaperAppraiseObjLstCache = GetObjLstCache(); 
return arrvPaperAppraiseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperAppraiseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPaperAppraiseEN._CurrTabName);
List<clsvPaperAppraiseEN> arrvPaperAppraiseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPaperAppraiseObjLstCache;
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
string strKey = string.Format("{0}", clsvPaperAppraiseEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngPaperAppraiseId)
{
if (strInFldName != convPaperAppraise.PaperAppraiseId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPaperAppraise.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPaperAppraise.AttributeName));
throw new Exception(strMsg);
}
var objvPaperAppraise = clsvPaperAppraiseBL.GetObjByPaperAppraiseIdCache(lngPaperAppraiseId);
if (objvPaperAppraise == null) return "";
return objvPaperAppraise[strOutFldName].ToString();
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
int intRecCount = clsvPaperAppraiseDA.GetRecCount(strTabName);
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
int intRecCount = clsvPaperAppraiseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPaperAppraiseDA.GetRecCount();
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
int intRecCount = clsvPaperAppraiseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPaperAppraiseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPaperAppraiseEN objvPaperAppraiseCond)
{
List<clsvPaperAppraiseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperAppraiseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperAppraise.AttributeName)
{
if (objvPaperAppraiseCond.IsUpdated(strFldName) == false) continue;
if (objvPaperAppraiseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperAppraiseCond[strFldName].ToString());
}
else
{
if (objvPaperAppraiseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperAppraiseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperAppraiseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperAppraiseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperAppraiseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperAppraiseCond[strFldName]));
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
 List<string> arrList = clsvPaperAppraiseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPaperAppraiseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPaperAppraiseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}