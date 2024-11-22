
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTResearchResultBL
 表名:vRTResearchResult(01120621)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:05:32
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
public static class  clsvRTResearchResultBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvRTResearchResultEN GetObj(this K_mId_vRTResearchResult myKey)
{
clsvRTResearchResultEN objvRTResearchResultEN = clsvRTResearchResultBL.vRTResearchResultDA.GetObjBymId(myKey.Value);
return objvRTResearchResultEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTResearchResultEN SetTopicId(this clsvRTResearchResultEN objvRTResearchResultEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, convRTResearchResult.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, convRTResearchResult.TopicId);
}
objvRTResearchResultEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTResearchResultEN.dicFldComparisonOp.ContainsKey(convRTResearchResult.TopicId) == false)
{
objvRTResearchResultEN.dicFldComparisonOp.Add(convRTResearchResult.TopicId, strComparisonOp);
}
else
{
objvRTResearchResultEN.dicFldComparisonOp[convRTResearchResult.TopicId] = strComparisonOp;
}
}
return objvRTResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTResearchResultEN SetPaperId(this clsvRTResearchResultEN objvRTResearchResultEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convRTResearchResult.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convRTResearchResult.PaperId);
}
objvRTResearchResultEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTResearchResultEN.dicFldComparisonOp.ContainsKey(convRTResearchResult.PaperId) == false)
{
objvRTResearchResultEN.dicFldComparisonOp.Add(convRTResearchResult.PaperId, strComparisonOp);
}
else
{
objvRTResearchResultEN.dicFldComparisonOp[convRTResearchResult.PaperId] = strComparisonOp;
}
}
return objvRTResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTResearchResultEN SetUpdDate(this clsvRTResearchResultEN objvRTResearchResultEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convRTResearchResult.UpdDate);
}
objvRTResearchResultEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTResearchResultEN.dicFldComparisonOp.ContainsKey(convRTResearchResult.UpdDate) == false)
{
objvRTResearchResultEN.dicFldComparisonOp.Add(convRTResearchResult.UpdDate, strComparisonOp);
}
else
{
objvRTResearchResultEN.dicFldComparisonOp[convRTResearchResult.UpdDate] = strComparisonOp;
}
}
return objvRTResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTResearchResultEN SetUpdUser(this clsvRTResearchResultEN objvRTResearchResultEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convRTResearchResult.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convRTResearchResult.UpdUser);
}
objvRTResearchResultEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTResearchResultEN.dicFldComparisonOp.ContainsKey(convRTResearchResult.UpdUser) == false)
{
objvRTResearchResultEN.dicFldComparisonOp.Add(convRTResearchResult.UpdUser, strComparisonOp);
}
else
{
objvRTResearchResultEN.dicFldComparisonOp[convRTResearchResult.UpdUser] = strComparisonOp;
}
}
return objvRTResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTResearchResultEN SetMemo(this clsvRTResearchResultEN objvRTResearchResultEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convRTResearchResult.Memo);
}
objvRTResearchResultEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTResearchResultEN.dicFldComparisonOp.ContainsKey(convRTResearchResult.Memo) == false)
{
objvRTResearchResultEN.dicFldComparisonOp.Add(convRTResearchResult.Memo, strComparisonOp);
}
else
{
objvRTResearchResultEN.dicFldComparisonOp[convRTResearchResult.Memo] = strComparisonOp;
}
}
return objvRTResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTResearchResultEN SetmId(this clsvRTResearchResultEN objvRTResearchResultEN, long lngmId, string strComparisonOp="")
	{
objvRTResearchResultEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTResearchResultEN.dicFldComparisonOp.ContainsKey(convRTResearchResult.mId) == false)
{
objvRTResearchResultEN.dicFldComparisonOp.Add(convRTResearchResult.mId, strComparisonOp);
}
else
{
objvRTResearchResultEN.dicFldComparisonOp[convRTResearchResult.mId] = strComparisonOp;
}
}
return objvRTResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTResearchResultEN SetUserName(this clsvRTResearchResultEN objvRTResearchResultEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convRTResearchResult.UserName);
}
objvRTResearchResultEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTResearchResultEN.dicFldComparisonOp.ContainsKey(convRTResearchResult.UserName) == false)
{
objvRTResearchResultEN.dicFldComparisonOp.Add(convRTResearchResult.UserName, strComparisonOp);
}
else
{
objvRTResearchResultEN.dicFldComparisonOp[convRTResearchResult.UserName] = strComparisonOp;
}
}
return objvRTResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTResearchResultEN SetPaperTitle(this clsvRTResearchResultEN objvRTResearchResultEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convRTResearchResult.PaperTitle);
}
objvRTResearchResultEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTResearchResultEN.dicFldComparisonOp.ContainsKey(convRTResearchResult.PaperTitle) == false)
{
objvRTResearchResultEN.dicFldComparisonOp.Add(convRTResearchResult.PaperTitle, strComparisonOp);
}
else
{
objvRTResearchResultEN.dicFldComparisonOp[convRTResearchResult.PaperTitle] = strComparisonOp;
}
}
return objvRTResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTResearchResultEN SetPaperContent(this clsvRTResearchResultEN objvRTResearchResultEN, string strPaperContent, string strComparisonOp="")
	{
objvRTResearchResultEN.PaperContent = strPaperContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTResearchResultEN.dicFldComparisonOp.ContainsKey(convRTResearchResult.PaperContent) == false)
{
objvRTResearchResultEN.dicFldComparisonOp.Add(convRTResearchResult.PaperContent, strComparisonOp);
}
else
{
objvRTResearchResultEN.dicFldComparisonOp[convRTResearchResult.PaperContent] = strComparisonOp;
}
}
return objvRTResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTResearchResultEN SetTopicName(this clsvRTResearchResultEN objvRTResearchResultEN, string strTopicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicName, 200, convRTResearchResult.TopicName);
}
objvRTResearchResultEN.TopicName = strTopicName; //栏目主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTResearchResultEN.dicFldComparisonOp.ContainsKey(convRTResearchResult.TopicName) == false)
{
objvRTResearchResultEN.dicFldComparisonOp.Add(convRTResearchResult.TopicName, strComparisonOp);
}
else
{
objvRTResearchResultEN.dicFldComparisonOp[convRTResearchResult.TopicName] = strComparisonOp;
}
}
return objvRTResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTResearchResultEN SetTopicContent(this clsvRTResearchResultEN objvRTResearchResultEN, string strTopicContent, string strComparisonOp="")
	{
objvRTResearchResultEN.TopicContent = strTopicContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTResearchResultEN.dicFldComparisonOp.ContainsKey(convRTResearchResult.TopicContent) == false)
{
objvRTResearchResultEN.dicFldComparisonOp.Add(convRTResearchResult.TopicContent, strComparisonOp);
}
else
{
objvRTResearchResultEN.dicFldComparisonOp[convRTResearchResult.TopicContent] = strComparisonOp;
}
}
return objvRTResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTResearchResultEN SetTopicProposePeople(this clsvRTResearchResultEN objvRTResearchResultEN, string strTopicProposePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicProposePeople, 50, convRTResearchResult.TopicProposePeople);
}
objvRTResearchResultEN.TopicProposePeople = strTopicProposePeople; //主题提出人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTResearchResultEN.dicFldComparisonOp.ContainsKey(convRTResearchResult.TopicProposePeople) == false)
{
objvRTResearchResultEN.dicFldComparisonOp.Add(convRTResearchResult.TopicProposePeople, strComparisonOp);
}
else
{
objvRTResearchResultEN.dicFldComparisonOp[convRTResearchResult.TopicProposePeople] = strComparisonOp;
}
}
return objvRTResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTResearchResultEN SetPeriodical(this clsvRTResearchResultEN objvRTResearchResultEN, string strPeriodical, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPeriodical, 100, convRTResearchResult.Periodical);
}
objvRTResearchResultEN.Periodical = strPeriodical; //期刊
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTResearchResultEN.dicFldComparisonOp.ContainsKey(convRTResearchResult.Periodical) == false)
{
objvRTResearchResultEN.dicFldComparisonOp.Add(convRTResearchResult.Periodical, strComparisonOp);
}
else
{
objvRTResearchResultEN.dicFldComparisonOp[convRTResearchResult.Periodical] = strComparisonOp;
}
}
return objvRTResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTResearchResultEN SetAuthor(this clsvRTResearchResultEN objvRTResearchResultEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convRTResearchResult.Author);
}
objvRTResearchResultEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTResearchResultEN.dicFldComparisonOp.ContainsKey(convRTResearchResult.Author) == false)
{
objvRTResearchResultEN.dicFldComparisonOp.Add(convRTResearchResult.Author, strComparisonOp);
}
else
{
objvRTResearchResultEN.dicFldComparisonOp[convRTResearchResult.Author] = strComparisonOp;
}
}
return objvRTResearchResultEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvRTResearchResultENS">源对象</param>
 /// <param name = "objvRTResearchResultENT">目标对象</param>
 public static void CopyTo(this clsvRTResearchResultEN objvRTResearchResultENS, clsvRTResearchResultEN objvRTResearchResultENT)
{
try
{
objvRTResearchResultENT.TopicId = objvRTResearchResultENS.TopicId; //主题Id
objvRTResearchResultENT.PaperId = objvRTResearchResultENS.PaperId; //论文Id
objvRTResearchResultENT.UpdDate = objvRTResearchResultENS.UpdDate; //修改日期
objvRTResearchResultENT.UpdUser = objvRTResearchResultENS.UpdUser; //修改人
objvRTResearchResultENT.Memo = objvRTResearchResultENS.Memo; //备注
objvRTResearchResultENT.mId = objvRTResearchResultENS.mId; //mId
objvRTResearchResultENT.UserName = objvRTResearchResultENS.UserName; //用户名
objvRTResearchResultENT.PaperTitle = objvRTResearchResultENS.PaperTitle; //论文标题
objvRTResearchResultENT.PaperContent = objvRTResearchResultENS.PaperContent; //主题内容
objvRTResearchResultENT.TopicName = objvRTResearchResultENS.TopicName; //栏目主题
objvRTResearchResultENT.TopicContent = objvRTResearchResultENS.TopicContent; //主题内容
objvRTResearchResultENT.TopicProposePeople = objvRTResearchResultENS.TopicProposePeople; //主题提出人
objvRTResearchResultENT.Periodical = objvRTResearchResultENS.Periodical; //期刊
objvRTResearchResultENT.Author = objvRTResearchResultENS.Author; //作者
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
 /// <param name = "objvRTResearchResultENS">源对象</param>
 /// <returns>目标对象=>clsvRTResearchResultEN:objvRTResearchResultENT</returns>
 public static clsvRTResearchResultEN CopyTo(this clsvRTResearchResultEN objvRTResearchResultENS)
{
try
{
 clsvRTResearchResultEN objvRTResearchResultENT = new clsvRTResearchResultEN()
{
TopicId = objvRTResearchResultENS.TopicId, //主题Id
PaperId = objvRTResearchResultENS.PaperId, //论文Id
UpdDate = objvRTResearchResultENS.UpdDate, //修改日期
UpdUser = objvRTResearchResultENS.UpdUser, //修改人
Memo = objvRTResearchResultENS.Memo, //备注
mId = objvRTResearchResultENS.mId, //mId
UserName = objvRTResearchResultENS.UserName, //用户名
PaperTitle = objvRTResearchResultENS.PaperTitle, //论文标题
PaperContent = objvRTResearchResultENS.PaperContent, //主题内容
TopicName = objvRTResearchResultENS.TopicName, //栏目主题
TopicContent = objvRTResearchResultENS.TopicContent, //主题内容
TopicProposePeople = objvRTResearchResultENS.TopicProposePeople, //主题提出人
Periodical = objvRTResearchResultENS.Periodical, //期刊
Author = objvRTResearchResultENS.Author, //作者
};
 return objvRTResearchResultENT;
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
public static void CheckProperty4Condition(this clsvRTResearchResultEN objvRTResearchResultEN)
{
 clsvRTResearchResultBL.vRTResearchResultDA.CheckProperty4Condition(objvRTResearchResultEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvRTResearchResultEN objvRTResearchResultCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvRTResearchResultCond.IsUpdated(convRTResearchResult.TopicId) == true)
{
string strComparisonOpTopicId = objvRTResearchResultCond.dicFldComparisonOp[convRTResearchResult.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTResearchResult.TopicId, objvRTResearchResultCond.TopicId, strComparisonOpTopicId);
}
if (objvRTResearchResultCond.IsUpdated(convRTResearchResult.PaperId) == true)
{
string strComparisonOpPaperId = objvRTResearchResultCond.dicFldComparisonOp[convRTResearchResult.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTResearchResult.PaperId, objvRTResearchResultCond.PaperId, strComparisonOpPaperId);
}
if (objvRTResearchResultCond.IsUpdated(convRTResearchResult.UpdDate) == true)
{
string strComparisonOpUpdDate = objvRTResearchResultCond.dicFldComparisonOp[convRTResearchResult.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTResearchResult.UpdDate, objvRTResearchResultCond.UpdDate, strComparisonOpUpdDate);
}
if (objvRTResearchResultCond.IsUpdated(convRTResearchResult.UpdUser) == true)
{
string strComparisonOpUpdUser = objvRTResearchResultCond.dicFldComparisonOp[convRTResearchResult.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTResearchResult.UpdUser, objvRTResearchResultCond.UpdUser, strComparisonOpUpdUser);
}
if (objvRTResearchResultCond.IsUpdated(convRTResearchResult.Memo) == true)
{
string strComparisonOpMemo = objvRTResearchResultCond.dicFldComparisonOp[convRTResearchResult.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTResearchResult.Memo, objvRTResearchResultCond.Memo, strComparisonOpMemo);
}
if (objvRTResearchResultCond.IsUpdated(convRTResearchResult.mId) == true)
{
string strComparisonOpmId = objvRTResearchResultCond.dicFldComparisonOp[convRTResearchResult.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convRTResearchResult.mId, objvRTResearchResultCond.mId, strComparisonOpmId);
}
if (objvRTResearchResultCond.IsUpdated(convRTResearchResult.UserName) == true)
{
string strComparisonOpUserName = objvRTResearchResultCond.dicFldComparisonOp[convRTResearchResult.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTResearchResult.UserName, objvRTResearchResultCond.UserName, strComparisonOpUserName);
}
if (objvRTResearchResultCond.IsUpdated(convRTResearchResult.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvRTResearchResultCond.dicFldComparisonOp[convRTResearchResult.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTResearchResult.PaperTitle, objvRTResearchResultCond.PaperTitle, strComparisonOpPaperTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvRTResearchResultCond.IsUpdated(convRTResearchResult.TopicName) == true)
{
string strComparisonOpTopicName = objvRTResearchResultCond.dicFldComparisonOp[convRTResearchResult.TopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTResearchResult.TopicName, objvRTResearchResultCond.TopicName, strComparisonOpTopicName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvRTResearchResultCond.IsUpdated(convRTResearchResult.TopicProposePeople) == true)
{
string strComparisonOpTopicProposePeople = objvRTResearchResultCond.dicFldComparisonOp[convRTResearchResult.TopicProposePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTResearchResult.TopicProposePeople, objvRTResearchResultCond.TopicProposePeople, strComparisonOpTopicProposePeople);
}
if (objvRTResearchResultCond.IsUpdated(convRTResearchResult.Periodical) == true)
{
string strComparisonOpPeriodical = objvRTResearchResultCond.dicFldComparisonOp[convRTResearchResult.Periodical];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTResearchResult.Periodical, objvRTResearchResultCond.Periodical, strComparisonOpPeriodical);
}
if (objvRTResearchResultCond.IsUpdated(convRTResearchResult.Author) == true)
{
string strComparisonOpAuthor = objvRTResearchResultCond.dicFldComparisonOp[convRTResearchResult.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTResearchResult.Author, objvRTResearchResultCond.Author, strComparisonOpAuthor);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vRTResearchResult
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 主题研究结果关系(vRTResearchResult)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvRTResearchResultBL
{
public static RelatedActions_vRTResearchResult relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvRTResearchResultDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvRTResearchResultDA vRTResearchResultDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvRTResearchResultDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvRTResearchResultBL()
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
if (string.IsNullOrEmpty(clsvRTResearchResultEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvRTResearchResultEN._ConnectString);
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
public static DataTable GetDataTable_vRTResearchResult(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vRTResearchResultDA.GetDataTable_vRTResearchResult(strWhereCond);
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
objDT = vRTResearchResultDA.GetDataTable(strWhereCond);
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
objDT = vRTResearchResultDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vRTResearchResultDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vRTResearchResultDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vRTResearchResultDA.GetDataTable_Top(objTopPara);
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
objDT = vRTResearchResultDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vRTResearchResultDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vRTResearchResultDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvRTResearchResultEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvRTResearchResultEN> arrObjLst = new List<clsvRTResearchResultEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTResearchResultEN objvRTResearchResultEN = new clsvRTResearchResultEN();
try
{
objvRTResearchResultEN.TopicId = objRow[convRTResearchResult.TopicId] == DBNull.Value ? null : objRow[convRTResearchResult.TopicId].ToString().Trim(); //主题Id
objvRTResearchResultEN.PaperId = objRow[convRTResearchResult.PaperId] == DBNull.Value ? null : objRow[convRTResearchResult.PaperId].ToString().Trim(); //论文Id
objvRTResearchResultEN.UpdDate = objRow[convRTResearchResult.UpdDate] == DBNull.Value ? null : objRow[convRTResearchResult.UpdDate].ToString().Trim(); //修改日期
objvRTResearchResultEN.UpdUser = objRow[convRTResearchResult.UpdUser].ToString().Trim(); //修改人
objvRTResearchResultEN.Memo = objRow[convRTResearchResult.Memo] == DBNull.Value ? null : objRow[convRTResearchResult.Memo].ToString().Trim(); //备注
objvRTResearchResultEN.mId = Int32.Parse(objRow[convRTResearchResult.mId].ToString().Trim()); //mId
objvRTResearchResultEN.UserName = objRow[convRTResearchResult.UserName] == DBNull.Value ? null : objRow[convRTResearchResult.UserName].ToString().Trim(); //用户名
objvRTResearchResultEN.PaperTitle = objRow[convRTResearchResult.PaperTitle] == DBNull.Value ? null : objRow[convRTResearchResult.PaperTitle].ToString().Trim(); //论文标题
objvRTResearchResultEN.PaperContent = objRow[convRTResearchResult.PaperContent] == DBNull.Value ? null : objRow[convRTResearchResult.PaperContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicName = objRow[convRTResearchResult.TopicName] == DBNull.Value ? null : objRow[convRTResearchResult.TopicName].ToString().Trim(); //栏目主题
objvRTResearchResultEN.TopicContent = objRow[convRTResearchResult.TopicContent] == DBNull.Value ? null : objRow[convRTResearchResult.TopicContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicProposePeople = objRow[convRTResearchResult.TopicProposePeople] == DBNull.Value ? null : objRow[convRTResearchResult.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTResearchResultEN.Periodical = objRow[convRTResearchResult.Periodical] == DBNull.Value ? null : objRow[convRTResearchResult.Periodical].ToString().Trim(); //期刊
objvRTResearchResultEN.Author = objRow[convRTResearchResult.Author] == DBNull.Value ? null : objRow[convRTResearchResult.Author].ToString().Trim(); //作者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTResearchResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTResearchResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvRTResearchResultEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvRTResearchResultEN._CurrTabName);
List<clsvRTResearchResultEN> arrvRTResearchResultObjLstCache = GetObjLstCache();
IEnumerable <clsvRTResearchResultEN> arrvRTResearchResultObjLst_Sel =
arrvRTResearchResultObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvRTResearchResultObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTResearchResultEN> GetObjLst(string strWhereCond)
{
List<clsvRTResearchResultEN> arrObjLst = new List<clsvRTResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTResearchResultEN objvRTResearchResultEN = new clsvRTResearchResultEN();
try
{
objvRTResearchResultEN.TopicId = objRow[convRTResearchResult.TopicId] == DBNull.Value ? null : objRow[convRTResearchResult.TopicId].ToString().Trim(); //主题Id
objvRTResearchResultEN.PaperId = objRow[convRTResearchResult.PaperId] == DBNull.Value ? null : objRow[convRTResearchResult.PaperId].ToString().Trim(); //论文Id
objvRTResearchResultEN.UpdDate = objRow[convRTResearchResult.UpdDate] == DBNull.Value ? null : objRow[convRTResearchResult.UpdDate].ToString().Trim(); //修改日期
objvRTResearchResultEN.UpdUser = objRow[convRTResearchResult.UpdUser].ToString().Trim(); //修改人
objvRTResearchResultEN.Memo = objRow[convRTResearchResult.Memo] == DBNull.Value ? null : objRow[convRTResearchResult.Memo].ToString().Trim(); //备注
objvRTResearchResultEN.mId = Int32.Parse(objRow[convRTResearchResult.mId].ToString().Trim()); //mId
objvRTResearchResultEN.UserName = objRow[convRTResearchResult.UserName] == DBNull.Value ? null : objRow[convRTResearchResult.UserName].ToString().Trim(); //用户名
objvRTResearchResultEN.PaperTitle = objRow[convRTResearchResult.PaperTitle] == DBNull.Value ? null : objRow[convRTResearchResult.PaperTitle].ToString().Trim(); //论文标题
objvRTResearchResultEN.PaperContent = objRow[convRTResearchResult.PaperContent] == DBNull.Value ? null : objRow[convRTResearchResult.PaperContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicName = objRow[convRTResearchResult.TopicName] == DBNull.Value ? null : objRow[convRTResearchResult.TopicName].ToString().Trim(); //栏目主题
objvRTResearchResultEN.TopicContent = objRow[convRTResearchResult.TopicContent] == DBNull.Value ? null : objRow[convRTResearchResult.TopicContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicProposePeople = objRow[convRTResearchResult.TopicProposePeople] == DBNull.Value ? null : objRow[convRTResearchResult.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTResearchResultEN.Periodical = objRow[convRTResearchResult.Periodical] == DBNull.Value ? null : objRow[convRTResearchResult.Periodical].ToString().Trim(); //期刊
objvRTResearchResultEN.Author = objRow[convRTResearchResult.Author] == DBNull.Value ? null : objRow[convRTResearchResult.Author].ToString().Trim(); //作者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTResearchResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTResearchResultEN);
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
public static List<clsvRTResearchResultEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvRTResearchResultEN> arrObjLst = new List<clsvRTResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTResearchResultEN objvRTResearchResultEN = new clsvRTResearchResultEN();
try
{
objvRTResearchResultEN.TopicId = objRow[convRTResearchResult.TopicId] == DBNull.Value ? null : objRow[convRTResearchResult.TopicId].ToString().Trim(); //主题Id
objvRTResearchResultEN.PaperId = objRow[convRTResearchResult.PaperId] == DBNull.Value ? null : objRow[convRTResearchResult.PaperId].ToString().Trim(); //论文Id
objvRTResearchResultEN.UpdDate = objRow[convRTResearchResult.UpdDate] == DBNull.Value ? null : objRow[convRTResearchResult.UpdDate].ToString().Trim(); //修改日期
objvRTResearchResultEN.UpdUser = objRow[convRTResearchResult.UpdUser].ToString().Trim(); //修改人
objvRTResearchResultEN.Memo = objRow[convRTResearchResult.Memo] == DBNull.Value ? null : objRow[convRTResearchResult.Memo].ToString().Trim(); //备注
objvRTResearchResultEN.mId = Int32.Parse(objRow[convRTResearchResult.mId].ToString().Trim()); //mId
objvRTResearchResultEN.UserName = objRow[convRTResearchResult.UserName] == DBNull.Value ? null : objRow[convRTResearchResult.UserName].ToString().Trim(); //用户名
objvRTResearchResultEN.PaperTitle = objRow[convRTResearchResult.PaperTitle] == DBNull.Value ? null : objRow[convRTResearchResult.PaperTitle].ToString().Trim(); //论文标题
objvRTResearchResultEN.PaperContent = objRow[convRTResearchResult.PaperContent] == DBNull.Value ? null : objRow[convRTResearchResult.PaperContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicName = objRow[convRTResearchResult.TopicName] == DBNull.Value ? null : objRow[convRTResearchResult.TopicName].ToString().Trim(); //栏目主题
objvRTResearchResultEN.TopicContent = objRow[convRTResearchResult.TopicContent] == DBNull.Value ? null : objRow[convRTResearchResult.TopicContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicProposePeople = objRow[convRTResearchResult.TopicProposePeople] == DBNull.Value ? null : objRow[convRTResearchResult.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTResearchResultEN.Periodical = objRow[convRTResearchResult.Periodical] == DBNull.Value ? null : objRow[convRTResearchResult.Periodical].ToString().Trim(); //期刊
objvRTResearchResultEN.Author = objRow[convRTResearchResult.Author] == DBNull.Value ? null : objRow[convRTResearchResult.Author].ToString().Trim(); //作者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTResearchResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTResearchResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvRTResearchResultCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvRTResearchResultEN> GetSubObjLstCache(clsvRTResearchResultEN objvRTResearchResultCond)
{
List<clsvRTResearchResultEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvRTResearchResultEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convRTResearchResult.AttributeName)
{
if (objvRTResearchResultCond.IsUpdated(strFldName) == false) continue;
if (objvRTResearchResultCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTResearchResultCond[strFldName].ToString());
}
else
{
if (objvRTResearchResultCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvRTResearchResultCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTResearchResultCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvRTResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvRTResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvRTResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvRTResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvRTResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvRTResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvRTResearchResultCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvRTResearchResultCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvRTResearchResultCond[strFldName]));
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
public static List<clsvRTResearchResultEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvRTResearchResultEN> arrObjLst = new List<clsvRTResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTResearchResultEN objvRTResearchResultEN = new clsvRTResearchResultEN();
try
{
objvRTResearchResultEN.TopicId = objRow[convRTResearchResult.TopicId] == DBNull.Value ? null : objRow[convRTResearchResult.TopicId].ToString().Trim(); //主题Id
objvRTResearchResultEN.PaperId = objRow[convRTResearchResult.PaperId] == DBNull.Value ? null : objRow[convRTResearchResult.PaperId].ToString().Trim(); //论文Id
objvRTResearchResultEN.UpdDate = objRow[convRTResearchResult.UpdDate] == DBNull.Value ? null : objRow[convRTResearchResult.UpdDate].ToString().Trim(); //修改日期
objvRTResearchResultEN.UpdUser = objRow[convRTResearchResult.UpdUser].ToString().Trim(); //修改人
objvRTResearchResultEN.Memo = objRow[convRTResearchResult.Memo] == DBNull.Value ? null : objRow[convRTResearchResult.Memo].ToString().Trim(); //备注
objvRTResearchResultEN.mId = Int32.Parse(objRow[convRTResearchResult.mId].ToString().Trim()); //mId
objvRTResearchResultEN.UserName = objRow[convRTResearchResult.UserName] == DBNull.Value ? null : objRow[convRTResearchResult.UserName].ToString().Trim(); //用户名
objvRTResearchResultEN.PaperTitle = objRow[convRTResearchResult.PaperTitle] == DBNull.Value ? null : objRow[convRTResearchResult.PaperTitle].ToString().Trim(); //论文标题
objvRTResearchResultEN.PaperContent = objRow[convRTResearchResult.PaperContent] == DBNull.Value ? null : objRow[convRTResearchResult.PaperContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicName = objRow[convRTResearchResult.TopicName] == DBNull.Value ? null : objRow[convRTResearchResult.TopicName].ToString().Trim(); //栏目主题
objvRTResearchResultEN.TopicContent = objRow[convRTResearchResult.TopicContent] == DBNull.Value ? null : objRow[convRTResearchResult.TopicContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicProposePeople = objRow[convRTResearchResult.TopicProposePeople] == DBNull.Value ? null : objRow[convRTResearchResult.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTResearchResultEN.Periodical = objRow[convRTResearchResult.Periodical] == DBNull.Value ? null : objRow[convRTResearchResult.Periodical].ToString().Trim(); //期刊
objvRTResearchResultEN.Author = objRow[convRTResearchResult.Author] == DBNull.Value ? null : objRow[convRTResearchResult.Author].ToString().Trim(); //作者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTResearchResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTResearchResultEN);
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
public static List<clsvRTResearchResultEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvRTResearchResultEN> arrObjLst = new List<clsvRTResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTResearchResultEN objvRTResearchResultEN = new clsvRTResearchResultEN();
try
{
objvRTResearchResultEN.TopicId = objRow[convRTResearchResult.TopicId] == DBNull.Value ? null : objRow[convRTResearchResult.TopicId].ToString().Trim(); //主题Id
objvRTResearchResultEN.PaperId = objRow[convRTResearchResult.PaperId] == DBNull.Value ? null : objRow[convRTResearchResult.PaperId].ToString().Trim(); //论文Id
objvRTResearchResultEN.UpdDate = objRow[convRTResearchResult.UpdDate] == DBNull.Value ? null : objRow[convRTResearchResult.UpdDate].ToString().Trim(); //修改日期
objvRTResearchResultEN.UpdUser = objRow[convRTResearchResult.UpdUser].ToString().Trim(); //修改人
objvRTResearchResultEN.Memo = objRow[convRTResearchResult.Memo] == DBNull.Value ? null : objRow[convRTResearchResult.Memo].ToString().Trim(); //备注
objvRTResearchResultEN.mId = Int32.Parse(objRow[convRTResearchResult.mId].ToString().Trim()); //mId
objvRTResearchResultEN.UserName = objRow[convRTResearchResult.UserName] == DBNull.Value ? null : objRow[convRTResearchResult.UserName].ToString().Trim(); //用户名
objvRTResearchResultEN.PaperTitle = objRow[convRTResearchResult.PaperTitle] == DBNull.Value ? null : objRow[convRTResearchResult.PaperTitle].ToString().Trim(); //论文标题
objvRTResearchResultEN.PaperContent = objRow[convRTResearchResult.PaperContent] == DBNull.Value ? null : objRow[convRTResearchResult.PaperContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicName = objRow[convRTResearchResult.TopicName] == DBNull.Value ? null : objRow[convRTResearchResult.TopicName].ToString().Trim(); //栏目主题
objvRTResearchResultEN.TopicContent = objRow[convRTResearchResult.TopicContent] == DBNull.Value ? null : objRow[convRTResearchResult.TopicContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicProposePeople = objRow[convRTResearchResult.TopicProposePeople] == DBNull.Value ? null : objRow[convRTResearchResult.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTResearchResultEN.Periodical = objRow[convRTResearchResult.Periodical] == DBNull.Value ? null : objRow[convRTResearchResult.Periodical].ToString().Trim(); //期刊
objvRTResearchResultEN.Author = objRow[convRTResearchResult.Author] == DBNull.Value ? null : objRow[convRTResearchResult.Author].ToString().Trim(); //作者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTResearchResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTResearchResultEN);
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
List<clsvRTResearchResultEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvRTResearchResultEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTResearchResultEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvRTResearchResultEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvRTResearchResultEN> arrObjLst = new List<clsvRTResearchResultEN>(); 
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
	clsvRTResearchResultEN objvRTResearchResultEN = new clsvRTResearchResultEN();
try
{
objvRTResearchResultEN.TopicId = objRow[convRTResearchResult.TopicId] == DBNull.Value ? null : objRow[convRTResearchResult.TopicId].ToString().Trim(); //主题Id
objvRTResearchResultEN.PaperId = objRow[convRTResearchResult.PaperId] == DBNull.Value ? null : objRow[convRTResearchResult.PaperId].ToString().Trim(); //论文Id
objvRTResearchResultEN.UpdDate = objRow[convRTResearchResult.UpdDate] == DBNull.Value ? null : objRow[convRTResearchResult.UpdDate].ToString().Trim(); //修改日期
objvRTResearchResultEN.UpdUser = objRow[convRTResearchResult.UpdUser].ToString().Trim(); //修改人
objvRTResearchResultEN.Memo = objRow[convRTResearchResult.Memo] == DBNull.Value ? null : objRow[convRTResearchResult.Memo].ToString().Trim(); //备注
objvRTResearchResultEN.mId = Int32.Parse(objRow[convRTResearchResult.mId].ToString().Trim()); //mId
objvRTResearchResultEN.UserName = objRow[convRTResearchResult.UserName] == DBNull.Value ? null : objRow[convRTResearchResult.UserName].ToString().Trim(); //用户名
objvRTResearchResultEN.PaperTitle = objRow[convRTResearchResult.PaperTitle] == DBNull.Value ? null : objRow[convRTResearchResult.PaperTitle].ToString().Trim(); //论文标题
objvRTResearchResultEN.PaperContent = objRow[convRTResearchResult.PaperContent] == DBNull.Value ? null : objRow[convRTResearchResult.PaperContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicName = objRow[convRTResearchResult.TopicName] == DBNull.Value ? null : objRow[convRTResearchResult.TopicName].ToString().Trim(); //栏目主题
objvRTResearchResultEN.TopicContent = objRow[convRTResearchResult.TopicContent] == DBNull.Value ? null : objRow[convRTResearchResult.TopicContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicProposePeople = objRow[convRTResearchResult.TopicProposePeople] == DBNull.Value ? null : objRow[convRTResearchResult.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTResearchResultEN.Periodical = objRow[convRTResearchResult.Periodical] == DBNull.Value ? null : objRow[convRTResearchResult.Periodical].ToString().Trim(); //期刊
objvRTResearchResultEN.Author = objRow[convRTResearchResult.Author] == DBNull.Value ? null : objRow[convRTResearchResult.Author].ToString().Trim(); //作者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTResearchResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTResearchResultEN);
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
public static List<clsvRTResearchResultEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvRTResearchResultEN> arrObjLst = new List<clsvRTResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTResearchResultEN objvRTResearchResultEN = new clsvRTResearchResultEN();
try
{
objvRTResearchResultEN.TopicId = objRow[convRTResearchResult.TopicId] == DBNull.Value ? null : objRow[convRTResearchResult.TopicId].ToString().Trim(); //主题Id
objvRTResearchResultEN.PaperId = objRow[convRTResearchResult.PaperId] == DBNull.Value ? null : objRow[convRTResearchResult.PaperId].ToString().Trim(); //论文Id
objvRTResearchResultEN.UpdDate = objRow[convRTResearchResult.UpdDate] == DBNull.Value ? null : objRow[convRTResearchResult.UpdDate].ToString().Trim(); //修改日期
objvRTResearchResultEN.UpdUser = objRow[convRTResearchResult.UpdUser].ToString().Trim(); //修改人
objvRTResearchResultEN.Memo = objRow[convRTResearchResult.Memo] == DBNull.Value ? null : objRow[convRTResearchResult.Memo].ToString().Trim(); //备注
objvRTResearchResultEN.mId = Int32.Parse(objRow[convRTResearchResult.mId].ToString().Trim()); //mId
objvRTResearchResultEN.UserName = objRow[convRTResearchResult.UserName] == DBNull.Value ? null : objRow[convRTResearchResult.UserName].ToString().Trim(); //用户名
objvRTResearchResultEN.PaperTitle = objRow[convRTResearchResult.PaperTitle] == DBNull.Value ? null : objRow[convRTResearchResult.PaperTitle].ToString().Trim(); //论文标题
objvRTResearchResultEN.PaperContent = objRow[convRTResearchResult.PaperContent] == DBNull.Value ? null : objRow[convRTResearchResult.PaperContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicName = objRow[convRTResearchResult.TopicName] == DBNull.Value ? null : objRow[convRTResearchResult.TopicName].ToString().Trim(); //栏目主题
objvRTResearchResultEN.TopicContent = objRow[convRTResearchResult.TopicContent] == DBNull.Value ? null : objRow[convRTResearchResult.TopicContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicProposePeople = objRow[convRTResearchResult.TopicProposePeople] == DBNull.Value ? null : objRow[convRTResearchResult.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTResearchResultEN.Periodical = objRow[convRTResearchResult.Periodical] == DBNull.Value ? null : objRow[convRTResearchResult.Periodical].ToString().Trim(); //期刊
objvRTResearchResultEN.Author = objRow[convRTResearchResult.Author] == DBNull.Value ? null : objRow[convRTResearchResult.Author].ToString().Trim(); //作者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTResearchResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTResearchResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvRTResearchResultEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvRTResearchResultEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvRTResearchResultEN> arrObjLst = new List<clsvRTResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTResearchResultEN objvRTResearchResultEN = new clsvRTResearchResultEN();
try
{
objvRTResearchResultEN.TopicId = objRow[convRTResearchResult.TopicId] == DBNull.Value ? null : objRow[convRTResearchResult.TopicId].ToString().Trim(); //主题Id
objvRTResearchResultEN.PaperId = objRow[convRTResearchResult.PaperId] == DBNull.Value ? null : objRow[convRTResearchResult.PaperId].ToString().Trim(); //论文Id
objvRTResearchResultEN.UpdDate = objRow[convRTResearchResult.UpdDate] == DBNull.Value ? null : objRow[convRTResearchResult.UpdDate].ToString().Trim(); //修改日期
objvRTResearchResultEN.UpdUser = objRow[convRTResearchResult.UpdUser].ToString().Trim(); //修改人
objvRTResearchResultEN.Memo = objRow[convRTResearchResult.Memo] == DBNull.Value ? null : objRow[convRTResearchResult.Memo].ToString().Trim(); //备注
objvRTResearchResultEN.mId = Int32.Parse(objRow[convRTResearchResult.mId].ToString().Trim()); //mId
objvRTResearchResultEN.UserName = objRow[convRTResearchResult.UserName] == DBNull.Value ? null : objRow[convRTResearchResult.UserName].ToString().Trim(); //用户名
objvRTResearchResultEN.PaperTitle = objRow[convRTResearchResult.PaperTitle] == DBNull.Value ? null : objRow[convRTResearchResult.PaperTitle].ToString().Trim(); //论文标题
objvRTResearchResultEN.PaperContent = objRow[convRTResearchResult.PaperContent] == DBNull.Value ? null : objRow[convRTResearchResult.PaperContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicName = objRow[convRTResearchResult.TopicName] == DBNull.Value ? null : objRow[convRTResearchResult.TopicName].ToString().Trim(); //栏目主题
objvRTResearchResultEN.TopicContent = objRow[convRTResearchResult.TopicContent] == DBNull.Value ? null : objRow[convRTResearchResult.TopicContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicProposePeople = objRow[convRTResearchResult.TopicProposePeople] == DBNull.Value ? null : objRow[convRTResearchResult.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTResearchResultEN.Periodical = objRow[convRTResearchResult.Periodical] == DBNull.Value ? null : objRow[convRTResearchResult.Periodical].ToString().Trim(); //期刊
objvRTResearchResultEN.Author = objRow[convRTResearchResult.Author] == DBNull.Value ? null : objRow[convRTResearchResult.Author].ToString().Trim(); //作者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTResearchResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTResearchResultEN);
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
public static List<clsvRTResearchResultEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvRTResearchResultEN> arrObjLst = new List<clsvRTResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTResearchResultEN objvRTResearchResultEN = new clsvRTResearchResultEN();
try
{
objvRTResearchResultEN.TopicId = objRow[convRTResearchResult.TopicId] == DBNull.Value ? null : objRow[convRTResearchResult.TopicId].ToString().Trim(); //主题Id
objvRTResearchResultEN.PaperId = objRow[convRTResearchResult.PaperId] == DBNull.Value ? null : objRow[convRTResearchResult.PaperId].ToString().Trim(); //论文Id
objvRTResearchResultEN.UpdDate = objRow[convRTResearchResult.UpdDate] == DBNull.Value ? null : objRow[convRTResearchResult.UpdDate].ToString().Trim(); //修改日期
objvRTResearchResultEN.UpdUser = objRow[convRTResearchResult.UpdUser].ToString().Trim(); //修改人
objvRTResearchResultEN.Memo = objRow[convRTResearchResult.Memo] == DBNull.Value ? null : objRow[convRTResearchResult.Memo].ToString().Trim(); //备注
objvRTResearchResultEN.mId = Int32.Parse(objRow[convRTResearchResult.mId].ToString().Trim()); //mId
objvRTResearchResultEN.UserName = objRow[convRTResearchResult.UserName] == DBNull.Value ? null : objRow[convRTResearchResult.UserName].ToString().Trim(); //用户名
objvRTResearchResultEN.PaperTitle = objRow[convRTResearchResult.PaperTitle] == DBNull.Value ? null : objRow[convRTResearchResult.PaperTitle].ToString().Trim(); //论文标题
objvRTResearchResultEN.PaperContent = objRow[convRTResearchResult.PaperContent] == DBNull.Value ? null : objRow[convRTResearchResult.PaperContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicName = objRow[convRTResearchResult.TopicName] == DBNull.Value ? null : objRow[convRTResearchResult.TopicName].ToString().Trim(); //栏目主题
objvRTResearchResultEN.TopicContent = objRow[convRTResearchResult.TopicContent] == DBNull.Value ? null : objRow[convRTResearchResult.TopicContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicProposePeople = objRow[convRTResearchResult.TopicProposePeople] == DBNull.Value ? null : objRow[convRTResearchResult.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTResearchResultEN.Periodical = objRow[convRTResearchResult.Periodical] == DBNull.Value ? null : objRow[convRTResearchResult.Periodical].ToString().Trim(); //期刊
objvRTResearchResultEN.Author = objRow[convRTResearchResult.Author] == DBNull.Value ? null : objRow[convRTResearchResult.Author].ToString().Trim(); //作者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTResearchResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTResearchResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTResearchResultEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvRTResearchResultEN> arrObjLst = new List<clsvRTResearchResultEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTResearchResultEN objvRTResearchResultEN = new clsvRTResearchResultEN();
try
{
objvRTResearchResultEN.TopicId = objRow[convRTResearchResult.TopicId] == DBNull.Value ? null : objRow[convRTResearchResult.TopicId].ToString().Trim(); //主题Id
objvRTResearchResultEN.PaperId = objRow[convRTResearchResult.PaperId] == DBNull.Value ? null : objRow[convRTResearchResult.PaperId].ToString().Trim(); //论文Id
objvRTResearchResultEN.UpdDate = objRow[convRTResearchResult.UpdDate] == DBNull.Value ? null : objRow[convRTResearchResult.UpdDate].ToString().Trim(); //修改日期
objvRTResearchResultEN.UpdUser = objRow[convRTResearchResult.UpdUser].ToString().Trim(); //修改人
objvRTResearchResultEN.Memo = objRow[convRTResearchResult.Memo] == DBNull.Value ? null : objRow[convRTResearchResult.Memo].ToString().Trim(); //备注
objvRTResearchResultEN.mId = Int32.Parse(objRow[convRTResearchResult.mId].ToString().Trim()); //mId
objvRTResearchResultEN.UserName = objRow[convRTResearchResult.UserName] == DBNull.Value ? null : objRow[convRTResearchResult.UserName].ToString().Trim(); //用户名
objvRTResearchResultEN.PaperTitle = objRow[convRTResearchResult.PaperTitle] == DBNull.Value ? null : objRow[convRTResearchResult.PaperTitle].ToString().Trim(); //论文标题
objvRTResearchResultEN.PaperContent = objRow[convRTResearchResult.PaperContent] == DBNull.Value ? null : objRow[convRTResearchResult.PaperContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicName = objRow[convRTResearchResult.TopicName] == DBNull.Value ? null : objRow[convRTResearchResult.TopicName].ToString().Trim(); //栏目主题
objvRTResearchResultEN.TopicContent = objRow[convRTResearchResult.TopicContent] == DBNull.Value ? null : objRow[convRTResearchResult.TopicContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicProposePeople = objRow[convRTResearchResult.TopicProposePeople] == DBNull.Value ? null : objRow[convRTResearchResult.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTResearchResultEN.Periodical = objRow[convRTResearchResult.Periodical] == DBNull.Value ? null : objRow[convRTResearchResult.Periodical].ToString().Trim(); //期刊
objvRTResearchResultEN.Author = objRow[convRTResearchResult.Author] == DBNull.Value ? null : objRow[convRTResearchResult.Author].ToString().Trim(); //作者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTResearchResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTResearchResultEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvRTResearchResultEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvRTResearchResult(ref clsvRTResearchResultEN objvRTResearchResultEN)
{
bool bolResult = vRTResearchResultDA.GetvRTResearchResult(ref objvRTResearchResultEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvRTResearchResultEN GetObjBymId(long lngmId)
{
clsvRTResearchResultEN objvRTResearchResultEN = vRTResearchResultDA.GetObjBymId(lngmId);
return objvRTResearchResultEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvRTResearchResultEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvRTResearchResultEN objvRTResearchResultEN = vRTResearchResultDA.GetFirstObj(strWhereCond);
 return objvRTResearchResultEN;
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
public static clsvRTResearchResultEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvRTResearchResultEN objvRTResearchResultEN = vRTResearchResultDA.GetObjByDataRow(objRow);
 return objvRTResearchResultEN;
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
public static clsvRTResearchResultEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvRTResearchResultEN objvRTResearchResultEN = vRTResearchResultDA.GetObjByDataRow(objRow);
 return objvRTResearchResultEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvRTResearchResultObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvRTResearchResultEN GetObjBymIdFromList(long lngmId, List<clsvRTResearchResultEN> lstvRTResearchResultObjLst)
{
foreach (clsvRTResearchResultEN objvRTResearchResultEN in lstvRTResearchResultObjLst)
{
if (objvRTResearchResultEN.mId == lngmId)
{
return objvRTResearchResultEN;
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
 long lngmId;
 try
 {
 lngmId = new clsvRTResearchResultDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vRTResearchResultDA.GetID(strWhereCond);
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
bool bolIsExist = vRTResearchResultDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vRTResearchResultDA.IsExist(lngmId);
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
 bolIsExist = clsvRTResearchResultDA.IsExistTable();
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
 bolIsExist = vRTResearchResultDA.IsExistTable(strTabName);
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
 /// <param name = "objvRTResearchResultENS">源对象</param>
 /// <param name = "objvRTResearchResultENT">目标对象</param>
 public static void CopyTo(clsvRTResearchResultEN objvRTResearchResultENS, clsvRTResearchResultEN objvRTResearchResultENT)
{
try
{
objvRTResearchResultENT.TopicId = objvRTResearchResultENS.TopicId; //主题Id
objvRTResearchResultENT.PaperId = objvRTResearchResultENS.PaperId; //论文Id
objvRTResearchResultENT.UpdDate = objvRTResearchResultENS.UpdDate; //修改日期
objvRTResearchResultENT.UpdUser = objvRTResearchResultENS.UpdUser; //修改人
objvRTResearchResultENT.Memo = objvRTResearchResultENS.Memo; //备注
objvRTResearchResultENT.mId = objvRTResearchResultENS.mId; //mId
objvRTResearchResultENT.UserName = objvRTResearchResultENS.UserName; //用户名
objvRTResearchResultENT.PaperTitle = objvRTResearchResultENS.PaperTitle; //论文标题
objvRTResearchResultENT.PaperContent = objvRTResearchResultENS.PaperContent; //主题内容
objvRTResearchResultENT.TopicName = objvRTResearchResultENS.TopicName; //栏目主题
objvRTResearchResultENT.TopicContent = objvRTResearchResultENS.TopicContent; //主题内容
objvRTResearchResultENT.TopicProposePeople = objvRTResearchResultENS.TopicProposePeople; //主题提出人
objvRTResearchResultENT.Periodical = objvRTResearchResultENS.Periodical; //期刊
objvRTResearchResultENT.Author = objvRTResearchResultENS.Author; //作者
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
 /// <param name = "objvRTResearchResultEN">源简化对象</param>
 public static void SetUpdFlag(clsvRTResearchResultEN objvRTResearchResultEN)
{
try
{
objvRTResearchResultEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvRTResearchResultEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convRTResearchResult.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTResearchResultEN.TopicId = objvRTResearchResultEN.TopicId == "[null]" ? null :  objvRTResearchResultEN.TopicId; //主题Id
}
if (arrFldSet.Contains(convRTResearchResult.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTResearchResultEN.PaperId = objvRTResearchResultEN.PaperId == "[null]" ? null :  objvRTResearchResultEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convRTResearchResult.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTResearchResultEN.UpdDate = objvRTResearchResultEN.UpdDate == "[null]" ? null :  objvRTResearchResultEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convRTResearchResult.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTResearchResultEN.UpdUser = objvRTResearchResultEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convRTResearchResult.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTResearchResultEN.Memo = objvRTResearchResultEN.Memo == "[null]" ? null :  objvRTResearchResultEN.Memo; //备注
}
if (arrFldSet.Contains(convRTResearchResult.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTResearchResultEN.mId = objvRTResearchResultEN.mId; //mId
}
if (arrFldSet.Contains(convRTResearchResult.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTResearchResultEN.UserName = objvRTResearchResultEN.UserName == "[null]" ? null :  objvRTResearchResultEN.UserName; //用户名
}
if (arrFldSet.Contains(convRTResearchResult.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTResearchResultEN.PaperTitle = objvRTResearchResultEN.PaperTitle == "[null]" ? null :  objvRTResearchResultEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convRTResearchResult.PaperContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTResearchResultEN.PaperContent = objvRTResearchResultEN.PaperContent == "[null]" ? null :  objvRTResearchResultEN.PaperContent; //主题内容
}
if (arrFldSet.Contains(convRTResearchResult.TopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTResearchResultEN.TopicName = objvRTResearchResultEN.TopicName == "[null]" ? null :  objvRTResearchResultEN.TopicName; //栏目主题
}
if (arrFldSet.Contains(convRTResearchResult.TopicContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTResearchResultEN.TopicContent = objvRTResearchResultEN.TopicContent == "[null]" ? null :  objvRTResearchResultEN.TopicContent; //主题内容
}
if (arrFldSet.Contains(convRTResearchResult.TopicProposePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTResearchResultEN.TopicProposePeople = objvRTResearchResultEN.TopicProposePeople == "[null]" ? null :  objvRTResearchResultEN.TopicProposePeople; //主题提出人
}
if (arrFldSet.Contains(convRTResearchResult.Periodical, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTResearchResultEN.Periodical = objvRTResearchResultEN.Periodical == "[null]" ? null :  objvRTResearchResultEN.Periodical; //期刊
}
if (arrFldSet.Contains(convRTResearchResult.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTResearchResultEN.Author = objvRTResearchResultEN.Author == "[null]" ? null :  objvRTResearchResultEN.Author; //作者
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
 /// <param name = "objvRTResearchResultEN">源简化对象</param>
 public static void AccessFldValueNull(clsvRTResearchResultEN objvRTResearchResultEN)
{
try
{
if (objvRTResearchResultEN.TopicId == "[null]") objvRTResearchResultEN.TopicId = null; //主题Id
if (objvRTResearchResultEN.PaperId == "[null]") objvRTResearchResultEN.PaperId = null; //论文Id
if (objvRTResearchResultEN.UpdDate == "[null]") objvRTResearchResultEN.UpdDate = null; //修改日期
if (objvRTResearchResultEN.Memo == "[null]") objvRTResearchResultEN.Memo = null; //备注
if (objvRTResearchResultEN.UserName == "[null]") objvRTResearchResultEN.UserName = null; //用户名
if (objvRTResearchResultEN.PaperTitle == "[null]") objvRTResearchResultEN.PaperTitle = null; //论文标题
if (objvRTResearchResultEN.PaperContent == "[null]") objvRTResearchResultEN.PaperContent = null; //主题内容
if (objvRTResearchResultEN.TopicName == "[null]") objvRTResearchResultEN.TopicName = null; //栏目主题
if (objvRTResearchResultEN.TopicContent == "[null]") objvRTResearchResultEN.TopicContent = null; //主题内容
if (objvRTResearchResultEN.TopicProposePeople == "[null]") objvRTResearchResultEN.TopicProposePeople = null; //主题提出人
if (objvRTResearchResultEN.Periodical == "[null]") objvRTResearchResultEN.Periodical = null; //期刊
if (objvRTResearchResultEN.Author == "[null]") objvRTResearchResultEN.Author = null; //作者
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
public static void CheckProperty4Condition(clsvRTResearchResultEN objvRTResearchResultEN)
{
 vRTResearchResultDA.CheckProperty4Condition(objvRTResearchResultEN);
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
if (clsResearchTopicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResearchTopicBL没有刷新缓存机制(clsResearchTopicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRTResearchResultBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRTResearchResultBL没有刷新缓存机制(clsRTResearchResultBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvRTResearchResultObjLstCache == null)
//{
//arrvRTResearchResultObjLstCache = vRTResearchResultDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvRTResearchResultEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvRTResearchResultEN._CurrTabName);
List<clsvRTResearchResultEN> arrvRTResearchResultObjLstCache = GetObjLstCache();
IEnumerable <clsvRTResearchResultEN> arrvRTResearchResultObjLst_Sel =
arrvRTResearchResultObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvRTResearchResultObjLst_Sel.Count() == 0)
{
   clsvRTResearchResultEN obj = clsvRTResearchResultBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvRTResearchResultObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvRTResearchResultEN> GetAllvRTResearchResultObjLstCache()
{
//获取缓存中的对象列表
List<clsvRTResearchResultEN> arrvRTResearchResultObjLstCache = GetObjLstCache(); 
return arrvRTResearchResultObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvRTResearchResultEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvRTResearchResultEN._CurrTabName);
List<clsvRTResearchResultEN> arrvRTResearchResultObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvRTResearchResultObjLstCache;
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
string strKey = string.Format("{0}", clsvRTResearchResultEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convRTResearchResult.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convRTResearchResult.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convRTResearchResult.AttributeName));
throw new Exception(strMsg);
}
var objvRTResearchResult = clsvRTResearchResultBL.GetObjBymIdCache(lngmId);
if (objvRTResearchResult == null) return "";
return objvRTResearchResult[strOutFldName].ToString();
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
int intRecCount = clsvRTResearchResultDA.GetRecCount(strTabName);
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
int intRecCount = clsvRTResearchResultDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvRTResearchResultDA.GetRecCount();
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
int intRecCount = clsvRTResearchResultDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvRTResearchResultCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvRTResearchResultEN objvRTResearchResultCond)
{
List<clsvRTResearchResultEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvRTResearchResultEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convRTResearchResult.AttributeName)
{
if (objvRTResearchResultCond.IsUpdated(strFldName) == false) continue;
if (objvRTResearchResultCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTResearchResultCond[strFldName].ToString());
}
else
{
if (objvRTResearchResultCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvRTResearchResultCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTResearchResultCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvRTResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvRTResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvRTResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvRTResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvRTResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvRTResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvRTResearchResultCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvRTResearchResultCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvRTResearchResultCond[strFldName]));
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
 List<string> arrList = clsvRTResearchResultDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vRTResearchResultDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vRTResearchResultDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}