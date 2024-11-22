
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PaperVerBL
 表名:vgs_PaperVer(01120677)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:01:33
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
public static class  clsvgs_PaperVerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperVId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_PaperVerEN GetObj(this K_PaperVId_vgs_PaperVer myKey)
{
clsvgs_PaperVerEN objvgs_PaperVerEN = clsvgs_PaperVerBL.vgs_PaperVerDA.GetObjByPaperVId(myKey.Value);
return objvgs_PaperVerEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetPaperVId(this clsvgs_PaperVerEN objvgs_PaperVerEN, long lngPaperVId, string strComparisonOp="")
	{
objvgs_PaperVerEN.PaperVId = lngPaperVId; //PaperVId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.PaperVId) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.PaperVId, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.PaperVId] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetPaperId(this clsvgs_PaperVerEN objvgs_PaperVerEN, string strPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperId, convgs_PaperVer.PaperId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convgs_PaperVer.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convgs_PaperVer.PaperId);
}
objvgs_PaperVerEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.PaperId) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.PaperId, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.PaperId] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetPaperTitle(this clsvgs_PaperVerEN objvgs_PaperVerEN, string strPaperTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperTitle, convgs_PaperVer.PaperTitle);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convgs_PaperVer.PaperTitle);
}
objvgs_PaperVerEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.PaperTitle) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.PaperTitle, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.PaperTitle] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetPaperContent(this clsvgs_PaperVerEN objvgs_PaperVerEN, string strPaperContent, string strComparisonOp="")
	{
objvgs_PaperVerEN.PaperContent = strPaperContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.PaperContent) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.PaperContent, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.PaperContent] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetPeriodical(this clsvgs_PaperVerEN objvgs_PaperVerEN, string strPeriodical, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPeriodical, 100, convgs_PaperVer.Periodical);
}
objvgs_PaperVerEN.Periodical = strPeriodical; //期刊
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.Periodical) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.Periodical, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.Periodical] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetAuthor(this clsvgs_PaperVerEN objvgs_PaperVerEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convgs_PaperVer.Author);
}
objvgs_PaperVerEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.Author) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.Author, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.Author] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetResearchQuestion(this clsvgs_PaperVerEN objvgs_PaperVerEN, string strResearchQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, convgs_PaperVer.ResearchQuestion);
}
objvgs_PaperVerEN.ResearchQuestion = strResearchQuestion; //研究问题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.ResearchQuestion) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.ResearchQuestion, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.ResearchQuestion] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetKeyword(this clsvgs_PaperVerEN objvgs_PaperVerEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convgs_PaperVer.Keyword);
}
objvgs_PaperVerEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.Keyword) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.Keyword, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.Keyword] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetLiteratureSources(this clsvgs_PaperVerEN objvgs_PaperVerEN, string strLiteratureSources, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureSources, 1000, convgs_PaperVer.LiteratureSources);
}
objvgs_PaperVerEN.LiteratureSources = strLiteratureSources; //文献来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.LiteratureSources) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.LiteratureSources, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.LiteratureSources] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetLiteratureLink(this clsvgs_PaperVerEN objvgs_PaperVerEN, string strLiteratureLink, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureLink, 1000, convgs_PaperVer.LiteratureLink);
}
objvgs_PaperVerEN.LiteratureLink = strLiteratureLink; //文献链接
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.LiteratureLink) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.LiteratureLink, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.LiteratureLink] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetUploadfileUrl(this clsvgs_PaperVerEN objvgs_PaperVerEN, string strUploadfileUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadfileUrl, 1000, convgs_PaperVer.UploadfileUrl);
}
objvgs_PaperVerEN.UploadfileUrl = strUploadfileUrl; //文件地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.UploadfileUrl) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.UploadfileUrl, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.UploadfileUrl] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetIsQuotethesis(this clsvgs_PaperVerEN objvgs_PaperVerEN, bool bolIsQuotethesis, string strComparisonOp="")
	{
objvgs_PaperVerEN.IsQuotethesis = bolIsQuotethesis; //是否引用论文
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.IsQuotethesis) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.IsQuotethesis, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.IsQuotethesis] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetIsSubmit(this clsvgs_PaperVerEN objvgs_PaperVerEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvgs_PaperVerEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.IsSubmit) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.IsSubmit, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.IsSubmit] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetIsChecked(this clsvgs_PaperVerEN objvgs_PaperVerEN, bool bolIsChecked, string strComparisonOp="")
	{
objvgs_PaperVerEN.IsChecked = bolIsChecked; //是否检查
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.IsChecked) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.IsChecked, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.IsChecked] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetQuoteId(this clsvgs_PaperVerEN objvgs_PaperVerEN, string strQuoteId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuoteId, 8, convgs_PaperVer.QuoteId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuoteId, 8, convgs_PaperVer.QuoteId);
}
objvgs_PaperVerEN.QuoteId = strQuoteId; //引用Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.QuoteId) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.QuoteId, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.QuoteId] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetChecker(this clsvgs_PaperVerEN objvgs_PaperVerEN, string strChecker, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChecker, 20, convgs_PaperVer.Checker);
}
objvgs_PaperVerEN.Checker = strChecker; //审核人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.Checker) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.Checker, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.Checker] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetLiteratureTypeId(this clsvgs_PaperVerEN objvgs_PaperVerEN, string strLiteratureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLiteratureTypeId, convgs_PaperVer.LiteratureTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureTypeId, 2, convgs_PaperVer.LiteratureTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLiteratureTypeId, 2, convgs_PaperVer.LiteratureTypeId);
}
objvgs_PaperVerEN.LiteratureTypeId = strLiteratureTypeId; //作文类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.LiteratureTypeId) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.LiteratureTypeId, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.LiteratureTypeId] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetLiteratureTypeName(this clsvgs_PaperVerEN objvgs_PaperVerEN, string strLiteratureTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureTypeName, 100, convgs_PaperVer.LiteratureTypeName);
}
objvgs_PaperVerEN.LiteratureTypeName = strLiteratureTypeName; //作文类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.LiteratureTypeName) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.LiteratureTypeName, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.LiteratureTypeName] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetUpdUser(this clsvgs_PaperVerEN objvgs_PaperVerEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convgs_PaperVer.UpdUser);
}
objvgs_PaperVerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.UpdUser) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.UpdUser, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.UpdUser] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetUpdDate(this clsvgs_PaperVerEN objvgs_PaperVerEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convgs_PaperVer.UpdDate);
}
objvgs_PaperVerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.UpdDate) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.UpdDate, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.UpdDate] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetIdCurrEduCls(this clsvgs_PaperVerEN objvgs_PaperVerEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convgs_PaperVer.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convgs_PaperVer.IdCurrEduCls);
}
objvgs_PaperVerEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.IdCurrEduCls) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.IdCurrEduCls, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.IdCurrEduCls] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetPaperTypeId(this clsvgs_PaperVerEN objvgs_PaperVerEN, string strPaperTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTypeId, 2, convgs_PaperVer.PaperTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperTypeId, 2, convgs_PaperVer.PaperTypeId);
}
objvgs_PaperVerEN.PaperTypeId = strPaperTypeId; //论文类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.PaperTypeId) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.PaperTypeId, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.PaperTypeId] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetPaperTypeName(this clsvgs_PaperVerEN objvgs_PaperVerEN, string strPaperTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTypeName, 50, convgs_PaperVer.PaperTypeName);
}
objvgs_PaperVerEN.PaperTypeName = strPaperTypeName; //论文类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.PaperTypeName) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.PaperTypeName, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.PaperTypeName] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetPaperStatusId(this clsvgs_PaperVerEN objvgs_PaperVerEN, string strPaperStatusId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperStatusId, 2, convgs_PaperVer.PaperStatusId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperStatusId, 2, convgs_PaperVer.PaperStatusId);
}
objvgs_PaperVerEN.PaperStatusId = strPaperStatusId; //论文状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.PaperStatusId) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.PaperStatusId, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.PaperStatusId] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetPaperStatusName(this clsvgs_PaperVerEN objvgs_PaperVerEN, string strPaperStatusName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperStatusName, 50, convgs_PaperVer.PaperStatusName);
}
objvgs_PaperVerEN.PaperStatusName = strPaperStatusName; //论文状态名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.PaperStatusName) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.PaperStatusName, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.PaperStatusName] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperVerEN SetMemo(this clsvgs_PaperVerEN objvgs_PaperVerEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convgs_PaperVer.Memo);
}
objvgs_PaperVerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperVerEN.dicFldComparisonOp.ContainsKey(convgs_PaperVer.Memo) == false)
{
objvgs_PaperVerEN.dicFldComparisonOp.Add(convgs_PaperVer.Memo, strComparisonOp);
}
else
{
objvgs_PaperVerEN.dicFldComparisonOp[convgs_PaperVer.Memo] = strComparisonOp;
}
}
return objvgs_PaperVerEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvgs_PaperVerENS">源对象</param>
 /// <param name = "objvgs_PaperVerENT">目标对象</param>
 public static void CopyTo(this clsvgs_PaperVerEN objvgs_PaperVerENS, clsvgs_PaperVerEN objvgs_PaperVerENT)
{
try
{
objvgs_PaperVerENT.PaperVId = objvgs_PaperVerENS.PaperVId; //PaperVId
objvgs_PaperVerENT.PaperId = objvgs_PaperVerENS.PaperId; //论文Id
objvgs_PaperVerENT.PaperTitle = objvgs_PaperVerENS.PaperTitle; //论文标题
objvgs_PaperVerENT.PaperContent = objvgs_PaperVerENS.PaperContent; //主题内容
objvgs_PaperVerENT.Periodical = objvgs_PaperVerENS.Periodical; //期刊
objvgs_PaperVerENT.Author = objvgs_PaperVerENS.Author; //作者
objvgs_PaperVerENT.ResearchQuestion = objvgs_PaperVerENS.ResearchQuestion; //研究问题
objvgs_PaperVerENT.Keyword = objvgs_PaperVerENS.Keyword; //关键字
objvgs_PaperVerENT.LiteratureSources = objvgs_PaperVerENS.LiteratureSources; //文献来源
objvgs_PaperVerENT.LiteratureLink = objvgs_PaperVerENS.LiteratureLink; //文献链接
objvgs_PaperVerENT.UploadfileUrl = objvgs_PaperVerENS.UploadfileUrl; //文件地址
objvgs_PaperVerENT.IsQuotethesis = objvgs_PaperVerENS.IsQuotethesis; //是否引用论文
objvgs_PaperVerENT.IsSubmit = objvgs_PaperVerENS.IsSubmit; //是否提交
objvgs_PaperVerENT.IsChecked = objvgs_PaperVerENS.IsChecked; //是否检查
objvgs_PaperVerENT.QuoteId = objvgs_PaperVerENS.QuoteId; //引用Id
objvgs_PaperVerENT.Checker = objvgs_PaperVerENS.Checker; //审核人
objvgs_PaperVerENT.LiteratureTypeId = objvgs_PaperVerENS.LiteratureTypeId; //作文类型Id
objvgs_PaperVerENT.LiteratureTypeName = objvgs_PaperVerENS.LiteratureTypeName; //作文类型名
objvgs_PaperVerENT.UpdUser = objvgs_PaperVerENS.UpdUser; //修改人
objvgs_PaperVerENT.UpdDate = objvgs_PaperVerENS.UpdDate; //修改日期
objvgs_PaperVerENT.IdCurrEduCls = objvgs_PaperVerENS.IdCurrEduCls; //教学班流水号
objvgs_PaperVerENT.PaperTypeId = objvgs_PaperVerENS.PaperTypeId; //论文类型Id
objvgs_PaperVerENT.PaperTypeName = objvgs_PaperVerENS.PaperTypeName; //论文类型名
objvgs_PaperVerENT.PaperStatusId = objvgs_PaperVerENS.PaperStatusId; //论文状态Id
objvgs_PaperVerENT.PaperStatusName = objvgs_PaperVerENS.PaperStatusName; //论文状态名
objvgs_PaperVerENT.Memo = objvgs_PaperVerENS.Memo; //备注
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
 /// <param name = "objvgs_PaperVerENS">源对象</param>
 /// <returns>目标对象=>clsvgs_PaperVerEN:objvgs_PaperVerENT</returns>
 public static clsvgs_PaperVerEN CopyTo(this clsvgs_PaperVerEN objvgs_PaperVerENS)
{
try
{
 clsvgs_PaperVerEN objvgs_PaperVerENT = new clsvgs_PaperVerEN()
{
PaperVId = objvgs_PaperVerENS.PaperVId, //PaperVId
PaperId = objvgs_PaperVerENS.PaperId, //论文Id
PaperTitle = objvgs_PaperVerENS.PaperTitle, //论文标题
PaperContent = objvgs_PaperVerENS.PaperContent, //主题内容
Periodical = objvgs_PaperVerENS.Periodical, //期刊
Author = objvgs_PaperVerENS.Author, //作者
ResearchQuestion = objvgs_PaperVerENS.ResearchQuestion, //研究问题
Keyword = objvgs_PaperVerENS.Keyword, //关键字
LiteratureSources = objvgs_PaperVerENS.LiteratureSources, //文献来源
LiteratureLink = objvgs_PaperVerENS.LiteratureLink, //文献链接
UploadfileUrl = objvgs_PaperVerENS.UploadfileUrl, //文件地址
IsQuotethesis = objvgs_PaperVerENS.IsQuotethesis, //是否引用论文
IsSubmit = objvgs_PaperVerENS.IsSubmit, //是否提交
IsChecked = objvgs_PaperVerENS.IsChecked, //是否检查
QuoteId = objvgs_PaperVerENS.QuoteId, //引用Id
Checker = objvgs_PaperVerENS.Checker, //审核人
LiteratureTypeId = objvgs_PaperVerENS.LiteratureTypeId, //作文类型Id
LiteratureTypeName = objvgs_PaperVerENS.LiteratureTypeName, //作文类型名
UpdUser = objvgs_PaperVerENS.UpdUser, //修改人
UpdDate = objvgs_PaperVerENS.UpdDate, //修改日期
IdCurrEduCls = objvgs_PaperVerENS.IdCurrEduCls, //教学班流水号
PaperTypeId = objvgs_PaperVerENS.PaperTypeId, //论文类型Id
PaperTypeName = objvgs_PaperVerENS.PaperTypeName, //论文类型名
PaperStatusId = objvgs_PaperVerENS.PaperStatusId, //论文状态Id
PaperStatusName = objvgs_PaperVerENS.PaperStatusName, //论文状态名
Memo = objvgs_PaperVerENS.Memo, //备注
};
 return objvgs_PaperVerENT;
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
public static void CheckProperty4Condition(this clsvgs_PaperVerEN objvgs_PaperVerEN)
{
 clsvgs_PaperVerBL.vgs_PaperVerDA.CheckProperty4Condition(objvgs_PaperVerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvgs_PaperVerEN objvgs_PaperVerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.PaperVId) == true)
{
string strComparisonOpPaperVId = objvgs_PaperVerCond.dicFldComparisonOp[convgs_PaperVer.PaperVId];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperVer.PaperVId, objvgs_PaperVerCond.PaperVId, strComparisonOpPaperVId);
}
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.PaperId) == true)
{
string strComparisonOpPaperId = objvgs_PaperVerCond.dicFldComparisonOp[convgs_PaperVer.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperVer.PaperId, objvgs_PaperVerCond.PaperId, strComparisonOpPaperId);
}
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvgs_PaperVerCond.dicFldComparisonOp[convgs_PaperVer.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperVer.PaperTitle, objvgs_PaperVerCond.PaperTitle, strComparisonOpPaperTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.Periodical) == true)
{
string strComparisonOpPeriodical = objvgs_PaperVerCond.dicFldComparisonOp[convgs_PaperVer.Periodical];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperVer.Periodical, objvgs_PaperVerCond.Periodical, strComparisonOpPeriodical);
}
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.Author) == true)
{
string strComparisonOpAuthor = objvgs_PaperVerCond.dicFldComparisonOp[convgs_PaperVer.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperVer.Author, objvgs_PaperVerCond.Author, strComparisonOpAuthor);
}
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.ResearchQuestion) == true)
{
string strComparisonOpResearchQuestion = objvgs_PaperVerCond.dicFldComparisonOp[convgs_PaperVer.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperVer.ResearchQuestion, objvgs_PaperVerCond.ResearchQuestion, strComparisonOpResearchQuestion);
}
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.Keyword) == true)
{
string strComparisonOpKeyword = objvgs_PaperVerCond.dicFldComparisonOp[convgs_PaperVer.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperVer.Keyword, objvgs_PaperVerCond.Keyword, strComparisonOpKeyword);
}
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.LiteratureSources) == true)
{
string strComparisonOpLiteratureSources = objvgs_PaperVerCond.dicFldComparisonOp[convgs_PaperVer.LiteratureSources];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperVer.LiteratureSources, objvgs_PaperVerCond.LiteratureSources, strComparisonOpLiteratureSources);
}
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.LiteratureLink) == true)
{
string strComparisonOpLiteratureLink = objvgs_PaperVerCond.dicFldComparisonOp[convgs_PaperVer.LiteratureLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperVer.LiteratureLink, objvgs_PaperVerCond.LiteratureLink, strComparisonOpLiteratureLink);
}
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.UploadfileUrl) == true)
{
string strComparisonOpUploadfileUrl = objvgs_PaperVerCond.dicFldComparisonOp[convgs_PaperVer.UploadfileUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperVer.UploadfileUrl, objvgs_PaperVerCond.UploadfileUrl, strComparisonOpUploadfileUrl);
}
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.IsQuotethesis) == true)
{
if (objvgs_PaperVerCond.IsQuotethesis == true)
{
strWhereCond += string.Format(" And {0} = '1'", convgs_PaperVer.IsQuotethesis);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convgs_PaperVer.IsQuotethesis);
}
}
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.IsSubmit) == true)
{
if (objvgs_PaperVerCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convgs_PaperVer.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convgs_PaperVer.IsSubmit);
}
}
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.IsChecked) == true)
{
if (objvgs_PaperVerCond.IsChecked == true)
{
strWhereCond += string.Format(" And {0} = '1'", convgs_PaperVer.IsChecked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convgs_PaperVer.IsChecked);
}
}
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.QuoteId) == true)
{
string strComparisonOpQuoteId = objvgs_PaperVerCond.dicFldComparisonOp[convgs_PaperVer.QuoteId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperVer.QuoteId, objvgs_PaperVerCond.QuoteId, strComparisonOpQuoteId);
}
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.Checker) == true)
{
string strComparisonOpChecker = objvgs_PaperVerCond.dicFldComparisonOp[convgs_PaperVer.Checker];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperVer.Checker, objvgs_PaperVerCond.Checker, strComparisonOpChecker);
}
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.LiteratureTypeId) == true)
{
string strComparisonOpLiteratureTypeId = objvgs_PaperVerCond.dicFldComparisonOp[convgs_PaperVer.LiteratureTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperVer.LiteratureTypeId, objvgs_PaperVerCond.LiteratureTypeId, strComparisonOpLiteratureTypeId);
}
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.LiteratureTypeName) == true)
{
string strComparisonOpLiteratureTypeName = objvgs_PaperVerCond.dicFldComparisonOp[convgs_PaperVer.LiteratureTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperVer.LiteratureTypeName, objvgs_PaperVerCond.LiteratureTypeName, strComparisonOpLiteratureTypeName);
}
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.UpdUser) == true)
{
string strComparisonOpUpdUser = objvgs_PaperVerCond.dicFldComparisonOp[convgs_PaperVer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperVer.UpdUser, objvgs_PaperVerCond.UpdUser, strComparisonOpUpdUser);
}
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.UpdDate) == true)
{
string strComparisonOpUpdDate = objvgs_PaperVerCond.dicFldComparisonOp[convgs_PaperVer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperVer.UpdDate, objvgs_PaperVerCond.UpdDate, strComparisonOpUpdDate);
}
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvgs_PaperVerCond.dicFldComparisonOp[convgs_PaperVer.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperVer.IdCurrEduCls, objvgs_PaperVerCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.PaperTypeId) == true)
{
string strComparisonOpPaperTypeId = objvgs_PaperVerCond.dicFldComparisonOp[convgs_PaperVer.PaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperVer.PaperTypeId, objvgs_PaperVerCond.PaperTypeId, strComparisonOpPaperTypeId);
}
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.PaperTypeName) == true)
{
string strComparisonOpPaperTypeName = objvgs_PaperVerCond.dicFldComparisonOp[convgs_PaperVer.PaperTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperVer.PaperTypeName, objvgs_PaperVerCond.PaperTypeName, strComparisonOpPaperTypeName);
}
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.PaperStatusId) == true)
{
string strComparisonOpPaperStatusId = objvgs_PaperVerCond.dicFldComparisonOp[convgs_PaperVer.PaperStatusId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperVer.PaperStatusId, objvgs_PaperVerCond.PaperStatusId, strComparisonOpPaperStatusId);
}
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.PaperStatusName) == true)
{
string strComparisonOpPaperStatusName = objvgs_PaperVerCond.dicFldComparisonOp[convgs_PaperVer.PaperStatusName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperVer.PaperStatusName, objvgs_PaperVerCond.PaperStatusName, strComparisonOpPaperStatusName);
}
if (objvgs_PaperVerCond.IsUpdated(convgs_PaperVer.Memo) == true)
{
string strComparisonOpMemo = objvgs_PaperVerCond.dicFldComparisonOp[convgs_PaperVer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperVer.Memo, objvgs_PaperVerCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vgs_PaperVer
{
public virtual bool UpdRelaTabDate(long lngPaperVId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文历史版本视图(vgs_PaperVer)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvgs_PaperVerBL
{
public static RelatedActions_vgs_PaperVer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvgs_PaperVerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvgs_PaperVerDA vgs_PaperVerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvgs_PaperVerDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvgs_PaperVerBL()
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
if (string.IsNullOrEmpty(clsvgs_PaperVerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_PaperVerEN._ConnectString);
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
public static DataTable GetDataTable_vgs_PaperVer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vgs_PaperVerDA.GetDataTable_vgs_PaperVer(strWhereCond);
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
objDT = vgs_PaperVerDA.GetDataTable(strWhereCond);
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
objDT = vgs_PaperVerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vgs_PaperVerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vgs_PaperVerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vgs_PaperVerDA.GetDataTable_Top(objTopPara);
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
objDT = vgs_PaperVerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vgs_PaperVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vgs_PaperVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPaperVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvgs_PaperVerEN> GetObjLstByPaperVIdLst(List<long> arrPaperVIdLst)
{
List<clsvgs_PaperVerEN> arrObjLst = new List<clsvgs_PaperVerEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPaperVIdLst);
 string strWhereCond = string.Format("PaperVId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperVerEN objvgs_PaperVerEN = new clsvgs_PaperVerEN();
try
{
objvgs_PaperVerEN.PaperVId = Int32.Parse(objRow[convgs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objvgs_PaperVerEN.PaperId = objRow[convgs_PaperVer.PaperId].ToString().Trim(); //论文Id
objvgs_PaperVerEN.PaperTitle = objRow[convgs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperVerEN.PaperContent = objRow[convgs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objvgs_PaperVerEN.Periodical = objRow[convgs_PaperVer.Periodical] == DBNull.Value ? null : objRow[convgs_PaperVer.Periodical].ToString().Trim(); //期刊
objvgs_PaperVerEN.Author = objRow[convgs_PaperVer.Author] == DBNull.Value ? null : objRow[convgs_PaperVer.Author].ToString().Trim(); //作者
objvgs_PaperVerEN.ResearchQuestion = objRow[convgs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[convgs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objvgs_PaperVerEN.Keyword = objRow[convgs_PaperVer.Keyword] == DBNull.Value ? null : objRow[convgs_PaperVer.Keyword].ToString().Trim(); //关键字
objvgs_PaperVerEN.LiteratureSources = objRow[convgs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objvgs_PaperVerEN.LiteratureLink = objRow[convgs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objvgs_PaperVerEN.UploadfileUrl = objRow[convgs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[convgs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objvgs_PaperVerEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objvgs_PaperVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperVerEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objvgs_PaperVerEN.QuoteId = objRow[convgs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[convgs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objvgs_PaperVerEN.Checker = objRow[convgs_PaperVer.Checker] == DBNull.Value ? null : objRow[convgs_PaperVer.Checker].ToString().Trim(); //审核人
objvgs_PaperVerEN.LiteratureTypeId = objRow[convgs_PaperVer.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvgs_PaperVerEN.LiteratureTypeName = objRow[convgs_PaperVer.LiteratureTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureTypeName].ToString().Trim(); //作文类型名
objvgs_PaperVerEN.UpdUser = objRow[convgs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdUser].ToString().Trim(); //修改人
objvgs_PaperVerEN.UpdDate = objRow[convgs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperVerEN.IdCurrEduCls = objRow[convgs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperVerEN.PaperTypeId = objRow[convgs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PaperVerEN.PaperTypeName = objRow[convgs_PaperVer.PaperTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeName].ToString().Trim(); //论文类型名
objvgs_PaperVerEN.PaperStatusId = objRow[convgs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objvgs_PaperVerEN.PaperStatusName = objRow[convgs_PaperVer.PaperStatusName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusName].ToString().Trim(); //论文状态名
objvgs_PaperVerEN.Memo = objRow[convgs_PaperVer.Memo] == DBNull.Value ? null : objRow[convgs_PaperVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperVerEN.PaperVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvgs_PaperVerEN> GetObjLstByPaperVIdLstCache(List<long> arrPaperVIdLst)
{
string strKey = string.Format("{0}", clsvgs_PaperVerEN._CurrTabName);
List<clsvgs_PaperVerEN> arrvgs_PaperVerObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PaperVerEN> arrvgs_PaperVerObjLst_Sel =
arrvgs_PaperVerObjLstCache
.Where(x => arrPaperVIdLst.Contains(x.PaperVId));
return arrvgs_PaperVerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PaperVerEN> GetObjLst(string strWhereCond)
{
List<clsvgs_PaperVerEN> arrObjLst = new List<clsvgs_PaperVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperVerEN objvgs_PaperVerEN = new clsvgs_PaperVerEN();
try
{
objvgs_PaperVerEN.PaperVId = Int32.Parse(objRow[convgs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objvgs_PaperVerEN.PaperId = objRow[convgs_PaperVer.PaperId].ToString().Trim(); //论文Id
objvgs_PaperVerEN.PaperTitle = objRow[convgs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperVerEN.PaperContent = objRow[convgs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objvgs_PaperVerEN.Periodical = objRow[convgs_PaperVer.Periodical] == DBNull.Value ? null : objRow[convgs_PaperVer.Periodical].ToString().Trim(); //期刊
objvgs_PaperVerEN.Author = objRow[convgs_PaperVer.Author] == DBNull.Value ? null : objRow[convgs_PaperVer.Author].ToString().Trim(); //作者
objvgs_PaperVerEN.ResearchQuestion = objRow[convgs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[convgs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objvgs_PaperVerEN.Keyword = objRow[convgs_PaperVer.Keyword] == DBNull.Value ? null : objRow[convgs_PaperVer.Keyword].ToString().Trim(); //关键字
objvgs_PaperVerEN.LiteratureSources = objRow[convgs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objvgs_PaperVerEN.LiteratureLink = objRow[convgs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objvgs_PaperVerEN.UploadfileUrl = objRow[convgs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[convgs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objvgs_PaperVerEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objvgs_PaperVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperVerEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objvgs_PaperVerEN.QuoteId = objRow[convgs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[convgs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objvgs_PaperVerEN.Checker = objRow[convgs_PaperVer.Checker] == DBNull.Value ? null : objRow[convgs_PaperVer.Checker].ToString().Trim(); //审核人
objvgs_PaperVerEN.LiteratureTypeId = objRow[convgs_PaperVer.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvgs_PaperVerEN.LiteratureTypeName = objRow[convgs_PaperVer.LiteratureTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureTypeName].ToString().Trim(); //作文类型名
objvgs_PaperVerEN.UpdUser = objRow[convgs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdUser].ToString().Trim(); //修改人
objvgs_PaperVerEN.UpdDate = objRow[convgs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperVerEN.IdCurrEduCls = objRow[convgs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperVerEN.PaperTypeId = objRow[convgs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PaperVerEN.PaperTypeName = objRow[convgs_PaperVer.PaperTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeName].ToString().Trim(); //论文类型名
objvgs_PaperVerEN.PaperStatusId = objRow[convgs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objvgs_PaperVerEN.PaperStatusName = objRow[convgs_PaperVer.PaperStatusName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusName].ToString().Trim(); //论文状态名
objvgs_PaperVerEN.Memo = objRow[convgs_PaperVer.Memo] == DBNull.Value ? null : objRow[convgs_PaperVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperVerEN.PaperVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperVerEN);
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
public static List<clsvgs_PaperVerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvgs_PaperVerEN> arrObjLst = new List<clsvgs_PaperVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperVerEN objvgs_PaperVerEN = new clsvgs_PaperVerEN();
try
{
objvgs_PaperVerEN.PaperVId = Int32.Parse(objRow[convgs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objvgs_PaperVerEN.PaperId = objRow[convgs_PaperVer.PaperId].ToString().Trim(); //论文Id
objvgs_PaperVerEN.PaperTitle = objRow[convgs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperVerEN.PaperContent = objRow[convgs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objvgs_PaperVerEN.Periodical = objRow[convgs_PaperVer.Periodical] == DBNull.Value ? null : objRow[convgs_PaperVer.Periodical].ToString().Trim(); //期刊
objvgs_PaperVerEN.Author = objRow[convgs_PaperVer.Author] == DBNull.Value ? null : objRow[convgs_PaperVer.Author].ToString().Trim(); //作者
objvgs_PaperVerEN.ResearchQuestion = objRow[convgs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[convgs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objvgs_PaperVerEN.Keyword = objRow[convgs_PaperVer.Keyword] == DBNull.Value ? null : objRow[convgs_PaperVer.Keyword].ToString().Trim(); //关键字
objvgs_PaperVerEN.LiteratureSources = objRow[convgs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objvgs_PaperVerEN.LiteratureLink = objRow[convgs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objvgs_PaperVerEN.UploadfileUrl = objRow[convgs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[convgs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objvgs_PaperVerEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objvgs_PaperVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperVerEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objvgs_PaperVerEN.QuoteId = objRow[convgs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[convgs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objvgs_PaperVerEN.Checker = objRow[convgs_PaperVer.Checker] == DBNull.Value ? null : objRow[convgs_PaperVer.Checker].ToString().Trim(); //审核人
objvgs_PaperVerEN.LiteratureTypeId = objRow[convgs_PaperVer.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvgs_PaperVerEN.LiteratureTypeName = objRow[convgs_PaperVer.LiteratureTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureTypeName].ToString().Trim(); //作文类型名
objvgs_PaperVerEN.UpdUser = objRow[convgs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdUser].ToString().Trim(); //修改人
objvgs_PaperVerEN.UpdDate = objRow[convgs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperVerEN.IdCurrEduCls = objRow[convgs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperVerEN.PaperTypeId = objRow[convgs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PaperVerEN.PaperTypeName = objRow[convgs_PaperVer.PaperTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeName].ToString().Trim(); //论文类型名
objvgs_PaperVerEN.PaperStatusId = objRow[convgs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objvgs_PaperVerEN.PaperStatusName = objRow[convgs_PaperVer.PaperStatusName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusName].ToString().Trim(); //论文状态名
objvgs_PaperVerEN.Memo = objRow[convgs_PaperVer.Memo] == DBNull.Value ? null : objRow[convgs_PaperVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperVerEN.PaperVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvgs_PaperVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvgs_PaperVerEN> GetSubObjLstCache(clsvgs_PaperVerEN objvgs_PaperVerCond)
{
List<clsvgs_PaperVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PaperVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_PaperVer.AttributeName)
{
if (objvgs_PaperVerCond.IsUpdated(strFldName) == false) continue;
if (objvgs_PaperVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PaperVerCond[strFldName].ToString());
}
else
{
if (objvgs_PaperVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_PaperVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PaperVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_PaperVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_PaperVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_PaperVerCond[strFldName]));
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
public static List<clsvgs_PaperVerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvgs_PaperVerEN> arrObjLst = new List<clsvgs_PaperVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperVerEN objvgs_PaperVerEN = new clsvgs_PaperVerEN();
try
{
objvgs_PaperVerEN.PaperVId = Int32.Parse(objRow[convgs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objvgs_PaperVerEN.PaperId = objRow[convgs_PaperVer.PaperId].ToString().Trim(); //论文Id
objvgs_PaperVerEN.PaperTitle = objRow[convgs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperVerEN.PaperContent = objRow[convgs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objvgs_PaperVerEN.Periodical = objRow[convgs_PaperVer.Periodical] == DBNull.Value ? null : objRow[convgs_PaperVer.Periodical].ToString().Trim(); //期刊
objvgs_PaperVerEN.Author = objRow[convgs_PaperVer.Author] == DBNull.Value ? null : objRow[convgs_PaperVer.Author].ToString().Trim(); //作者
objvgs_PaperVerEN.ResearchQuestion = objRow[convgs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[convgs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objvgs_PaperVerEN.Keyword = objRow[convgs_PaperVer.Keyword] == DBNull.Value ? null : objRow[convgs_PaperVer.Keyword].ToString().Trim(); //关键字
objvgs_PaperVerEN.LiteratureSources = objRow[convgs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objvgs_PaperVerEN.LiteratureLink = objRow[convgs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objvgs_PaperVerEN.UploadfileUrl = objRow[convgs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[convgs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objvgs_PaperVerEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objvgs_PaperVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperVerEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objvgs_PaperVerEN.QuoteId = objRow[convgs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[convgs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objvgs_PaperVerEN.Checker = objRow[convgs_PaperVer.Checker] == DBNull.Value ? null : objRow[convgs_PaperVer.Checker].ToString().Trim(); //审核人
objvgs_PaperVerEN.LiteratureTypeId = objRow[convgs_PaperVer.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvgs_PaperVerEN.LiteratureTypeName = objRow[convgs_PaperVer.LiteratureTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureTypeName].ToString().Trim(); //作文类型名
objvgs_PaperVerEN.UpdUser = objRow[convgs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdUser].ToString().Trim(); //修改人
objvgs_PaperVerEN.UpdDate = objRow[convgs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperVerEN.IdCurrEduCls = objRow[convgs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperVerEN.PaperTypeId = objRow[convgs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PaperVerEN.PaperTypeName = objRow[convgs_PaperVer.PaperTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeName].ToString().Trim(); //论文类型名
objvgs_PaperVerEN.PaperStatusId = objRow[convgs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objvgs_PaperVerEN.PaperStatusName = objRow[convgs_PaperVer.PaperStatusName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusName].ToString().Trim(); //论文状态名
objvgs_PaperVerEN.Memo = objRow[convgs_PaperVer.Memo] == DBNull.Value ? null : objRow[convgs_PaperVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperVerEN.PaperVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperVerEN);
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
public static List<clsvgs_PaperVerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvgs_PaperVerEN> arrObjLst = new List<clsvgs_PaperVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperVerEN objvgs_PaperVerEN = new clsvgs_PaperVerEN();
try
{
objvgs_PaperVerEN.PaperVId = Int32.Parse(objRow[convgs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objvgs_PaperVerEN.PaperId = objRow[convgs_PaperVer.PaperId].ToString().Trim(); //论文Id
objvgs_PaperVerEN.PaperTitle = objRow[convgs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperVerEN.PaperContent = objRow[convgs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objvgs_PaperVerEN.Periodical = objRow[convgs_PaperVer.Periodical] == DBNull.Value ? null : objRow[convgs_PaperVer.Periodical].ToString().Trim(); //期刊
objvgs_PaperVerEN.Author = objRow[convgs_PaperVer.Author] == DBNull.Value ? null : objRow[convgs_PaperVer.Author].ToString().Trim(); //作者
objvgs_PaperVerEN.ResearchQuestion = objRow[convgs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[convgs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objvgs_PaperVerEN.Keyword = objRow[convgs_PaperVer.Keyword] == DBNull.Value ? null : objRow[convgs_PaperVer.Keyword].ToString().Trim(); //关键字
objvgs_PaperVerEN.LiteratureSources = objRow[convgs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objvgs_PaperVerEN.LiteratureLink = objRow[convgs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objvgs_PaperVerEN.UploadfileUrl = objRow[convgs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[convgs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objvgs_PaperVerEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objvgs_PaperVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperVerEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objvgs_PaperVerEN.QuoteId = objRow[convgs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[convgs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objvgs_PaperVerEN.Checker = objRow[convgs_PaperVer.Checker] == DBNull.Value ? null : objRow[convgs_PaperVer.Checker].ToString().Trim(); //审核人
objvgs_PaperVerEN.LiteratureTypeId = objRow[convgs_PaperVer.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvgs_PaperVerEN.LiteratureTypeName = objRow[convgs_PaperVer.LiteratureTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureTypeName].ToString().Trim(); //作文类型名
objvgs_PaperVerEN.UpdUser = objRow[convgs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdUser].ToString().Trim(); //修改人
objvgs_PaperVerEN.UpdDate = objRow[convgs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperVerEN.IdCurrEduCls = objRow[convgs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperVerEN.PaperTypeId = objRow[convgs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PaperVerEN.PaperTypeName = objRow[convgs_PaperVer.PaperTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeName].ToString().Trim(); //论文类型名
objvgs_PaperVerEN.PaperStatusId = objRow[convgs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objvgs_PaperVerEN.PaperStatusName = objRow[convgs_PaperVer.PaperStatusName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusName].ToString().Trim(); //论文状态名
objvgs_PaperVerEN.Memo = objRow[convgs_PaperVer.Memo] == DBNull.Value ? null : objRow[convgs_PaperVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperVerEN.PaperVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperVerEN);
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
List<clsvgs_PaperVerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvgs_PaperVerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PaperVerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvgs_PaperVerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_PaperVerEN> arrObjLst = new List<clsvgs_PaperVerEN>(); 
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
	clsvgs_PaperVerEN objvgs_PaperVerEN = new clsvgs_PaperVerEN();
try
{
objvgs_PaperVerEN.PaperVId = Int32.Parse(objRow[convgs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objvgs_PaperVerEN.PaperId = objRow[convgs_PaperVer.PaperId].ToString().Trim(); //论文Id
objvgs_PaperVerEN.PaperTitle = objRow[convgs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperVerEN.PaperContent = objRow[convgs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objvgs_PaperVerEN.Periodical = objRow[convgs_PaperVer.Periodical] == DBNull.Value ? null : objRow[convgs_PaperVer.Periodical].ToString().Trim(); //期刊
objvgs_PaperVerEN.Author = objRow[convgs_PaperVer.Author] == DBNull.Value ? null : objRow[convgs_PaperVer.Author].ToString().Trim(); //作者
objvgs_PaperVerEN.ResearchQuestion = objRow[convgs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[convgs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objvgs_PaperVerEN.Keyword = objRow[convgs_PaperVer.Keyword] == DBNull.Value ? null : objRow[convgs_PaperVer.Keyword].ToString().Trim(); //关键字
objvgs_PaperVerEN.LiteratureSources = objRow[convgs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objvgs_PaperVerEN.LiteratureLink = objRow[convgs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objvgs_PaperVerEN.UploadfileUrl = objRow[convgs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[convgs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objvgs_PaperVerEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objvgs_PaperVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperVerEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objvgs_PaperVerEN.QuoteId = objRow[convgs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[convgs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objvgs_PaperVerEN.Checker = objRow[convgs_PaperVer.Checker] == DBNull.Value ? null : objRow[convgs_PaperVer.Checker].ToString().Trim(); //审核人
objvgs_PaperVerEN.LiteratureTypeId = objRow[convgs_PaperVer.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvgs_PaperVerEN.LiteratureTypeName = objRow[convgs_PaperVer.LiteratureTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureTypeName].ToString().Trim(); //作文类型名
objvgs_PaperVerEN.UpdUser = objRow[convgs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdUser].ToString().Trim(); //修改人
objvgs_PaperVerEN.UpdDate = objRow[convgs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperVerEN.IdCurrEduCls = objRow[convgs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperVerEN.PaperTypeId = objRow[convgs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PaperVerEN.PaperTypeName = objRow[convgs_PaperVer.PaperTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeName].ToString().Trim(); //论文类型名
objvgs_PaperVerEN.PaperStatusId = objRow[convgs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objvgs_PaperVerEN.PaperStatusName = objRow[convgs_PaperVer.PaperStatusName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusName].ToString().Trim(); //论文状态名
objvgs_PaperVerEN.Memo = objRow[convgs_PaperVer.Memo] == DBNull.Value ? null : objRow[convgs_PaperVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperVerEN.PaperVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperVerEN);
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
public static List<clsvgs_PaperVerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvgs_PaperVerEN> arrObjLst = new List<clsvgs_PaperVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperVerEN objvgs_PaperVerEN = new clsvgs_PaperVerEN();
try
{
objvgs_PaperVerEN.PaperVId = Int32.Parse(objRow[convgs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objvgs_PaperVerEN.PaperId = objRow[convgs_PaperVer.PaperId].ToString().Trim(); //论文Id
objvgs_PaperVerEN.PaperTitle = objRow[convgs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperVerEN.PaperContent = objRow[convgs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objvgs_PaperVerEN.Periodical = objRow[convgs_PaperVer.Periodical] == DBNull.Value ? null : objRow[convgs_PaperVer.Periodical].ToString().Trim(); //期刊
objvgs_PaperVerEN.Author = objRow[convgs_PaperVer.Author] == DBNull.Value ? null : objRow[convgs_PaperVer.Author].ToString().Trim(); //作者
objvgs_PaperVerEN.ResearchQuestion = objRow[convgs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[convgs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objvgs_PaperVerEN.Keyword = objRow[convgs_PaperVer.Keyword] == DBNull.Value ? null : objRow[convgs_PaperVer.Keyword].ToString().Trim(); //关键字
objvgs_PaperVerEN.LiteratureSources = objRow[convgs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objvgs_PaperVerEN.LiteratureLink = objRow[convgs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objvgs_PaperVerEN.UploadfileUrl = objRow[convgs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[convgs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objvgs_PaperVerEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objvgs_PaperVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperVerEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objvgs_PaperVerEN.QuoteId = objRow[convgs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[convgs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objvgs_PaperVerEN.Checker = objRow[convgs_PaperVer.Checker] == DBNull.Value ? null : objRow[convgs_PaperVer.Checker].ToString().Trim(); //审核人
objvgs_PaperVerEN.LiteratureTypeId = objRow[convgs_PaperVer.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvgs_PaperVerEN.LiteratureTypeName = objRow[convgs_PaperVer.LiteratureTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureTypeName].ToString().Trim(); //作文类型名
objvgs_PaperVerEN.UpdUser = objRow[convgs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdUser].ToString().Trim(); //修改人
objvgs_PaperVerEN.UpdDate = objRow[convgs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperVerEN.IdCurrEduCls = objRow[convgs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperVerEN.PaperTypeId = objRow[convgs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PaperVerEN.PaperTypeName = objRow[convgs_PaperVer.PaperTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeName].ToString().Trim(); //论文类型名
objvgs_PaperVerEN.PaperStatusId = objRow[convgs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objvgs_PaperVerEN.PaperStatusName = objRow[convgs_PaperVer.PaperStatusName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusName].ToString().Trim(); //论文状态名
objvgs_PaperVerEN.Memo = objRow[convgs_PaperVer.Memo] == DBNull.Value ? null : objRow[convgs_PaperVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperVerEN.PaperVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvgs_PaperVerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvgs_PaperVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_PaperVerEN> arrObjLst = new List<clsvgs_PaperVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperVerEN objvgs_PaperVerEN = new clsvgs_PaperVerEN();
try
{
objvgs_PaperVerEN.PaperVId = Int32.Parse(objRow[convgs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objvgs_PaperVerEN.PaperId = objRow[convgs_PaperVer.PaperId].ToString().Trim(); //论文Id
objvgs_PaperVerEN.PaperTitle = objRow[convgs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperVerEN.PaperContent = objRow[convgs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objvgs_PaperVerEN.Periodical = objRow[convgs_PaperVer.Periodical] == DBNull.Value ? null : objRow[convgs_PaperVer.Periodical].ToString().Trim(); //期刊
objvgs_PaperVerEN.Author = objRow[convgs_PaperVer.Author] == DBNull.Value ? null : objRow[convgs_PaperVer.Author].ToString().Trim(); //作者
objvgs_PaperVerEN.ResearchQuestion = objRow[convgs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[convgs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objvgs_PaperVerEN.Keyword = objRow[convgs_PaperVer.Keyword] == DBNull.Value ? null : objRow[convgs_PaperVer.Keyword].ToString().Trim(); //关键字
objvgs_PaperVerEN.LiteratureSources = objRow[convgs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objvgs_PaperVerEN.LiteratureLink = objRow[convgs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objvgs_PaperVerEN.UploadfileUrl = objRow[convgs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[convgs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objvgs_PaperVerEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objvgs_PaperVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperVerEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objvgs_PaperVerEN.QuoteId = objRow[convgs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[convgs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objvgs_PaperVerEN.Checker = objRow[convgs_PaperVer.Checker] == DBNull.Value ? null : objRow[convgs_PaperVer.Checker].ToString().Trim(); //审核人
objvgs_PaperVerEN.LiteratureTypeId = objRow[convgs_PaperVer.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvgs_PaperVerEN.LiteratureTypeName = objRow[convgs_PaperVer.LiteratureTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureTypeName].ToString().Trim(); //作文类型名
objvgs_PaperVerEN.UpdUser = objRow[convgs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdUser].ToString().Trim(); //修改人
objvgs_PaperVerEN.UpdDate = objRow[convgs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperVerEN.IdCurrEduCls = objRow[convgs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperVerEN.PaperTypeId = objRow[convgs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PaperVerEN.PaperTypeName = objRow[convgs_PaperVer.PaperTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeName].ToString().Trim(); //论文类型名
objvgs_PaperVerEN.PaperStatusId = objRow[convgs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objvgs_PaperVerEN.PaperStatusName = objRow[convgs_PaperVer.PaperStatusName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusName].ToString().Trim(); //论文状态名
objvgs_PaperVerEN.Memo = objRow[convgs_PaperVer.Memo] == DBNull.Value ? null : objRow[convgs_PaperVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperVerEN.PaperVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperVerEN);
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
public static List<clsvgs_PaperVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvgs_PaperVerEN> arrObjLst = new List<clsvgs_PaperVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperVerEN objvgs_PaperVerEN = new clsvgs_PaperVerEN();
try
{
objvgs_PaperVerEN.PaperVId = Int32.Parse(objRow[convgs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objvgs_PaperVerEN.PaperId = objRow[convgs_PaperVer.PaperId].ToString().Trim(); //论文Id
objvgs_PaperVerEN.PaperTitle = objRow[convgs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperVerEN.PaperContent = objRow[convgs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objvgs_PaperVerEN.Periodical = objRow[convgs_PaperVer.Periodical] == DBNull.Value ? null : objRow[convgs_PaperVer.Periodical].ToString().Trim(); //期刊
objvgs_PaperVerEN.Author = objRow[convgs_PaperVer.Author] == DBNull.Value ? null : objRow[convgs_PaperVer.Author].ToString().Trim(); //作者
objvgs_PaperVerEN.ResearchQuestion = objRow[convgs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[convgs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objvgs_PaperVerEN.Keyword = objRow[convgs_PaperVer.Keyword] == DBNull.Value ? null : objRow[convgs_PaperVer.Keyword].ToString().Trim(); //关键字
objvgs_PaperVerEN.LiteratureSources = objRow[convgs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objvgs_PaperVerEN.LiteratureLink = objRow[convgs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objvgs_PaperVerEN.UploadfileUrl = objRow[convgs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[convgs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objvgs_PaperVerEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objvgs_PaperVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperVerEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objvgs_PaperVerEN.QuoteId = objRow[convgs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[convgs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objvgs_PaperVerEN.Checker = objRow[convgs_PaperVer.Checker] == DBNull.Value ? null : objRow[convgs_PaperVer.Checker].ToString().Trim(); //审核人
objvgs_PaperVerEN.LiteratureTypeId = objRow[convgs_PaperVer.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvgs_PaperVerEN.LiteratureTypeName = objRow[convgs_PaperVer.LiteratureTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureTypeName].ToString().Trim(); //作文类型名
objvgs_PaperVerEN.UpdUser = objRow[convgs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdUser].ToString().Trim(); //修改人
objvgs_PaperVerEN.UpdDate = objRow[convgs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperVerEN.IdCurrEduCls = objRow[convgs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperVerEN.PaperTypeId = objRow[convgs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PaperVerEN.PaperTypeName = objRow[convgs_PaperVer.PaperTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeName].ToString().Trim(); //论文类型名
objvgs_PaperVerEN.PaperStatusId = objRow[convgs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objvgs_PaperVerEN.PaperStatusName = objRow[convgs_PaperVer.PaperStatusName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusName].ToString().Trim(); //论文状态名
objvgs_PaperVerEN.Memo = objRow[convgs_PaperVer.Memo] == DBNull.Value ? null : objRow[convgs_PaperVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperVerEN.PaperVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PaperVerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvgs_PaperVerEN> arrObjLst = new List<clsvgs_PaperVerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperVerEN objvgs_PaperVerEN = new clsvgs_PaperVerEN();
try
{
objvgs_PaperVerEN.PaperVId = Int32.Parse(objRow[convgs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objvgs_PaperVerEN.PaperId = objRow[convgs_PaperVer.PaperId].ToString().Trim(); //论文Id
objvgs_PaperVerEN.PaperTitle = objRow[convgs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperVerEN.PaperContent = objRow[convgs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objvgs_PaperVerEN.Periodical = objRow[convgs_PaperVer.Periodical] == DBNull.Value ? null : objRow[convgs_PaperVer.Periodical].ToString().Trim(); //期刊
objvgs_PaperVerEN.Author = objRow[convgs_PaperVer.Author] == DBNull.Value ? null : objRow[convgs_PaperVer.Author].ToString().Trim(); //作者
objvgs_PaperVerEN.ResearchQuestion = objRow[convgs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[convgs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objvgs_PaperVerEN.Keyword = objRow[convgs_PaperVer.Keyword] == DBNull.Value ? null : objRow[convgs_PaperVer.Keyword].ToString().Trim(); //关键字
objvgs_PaperVerEN.LiteratureSources = objRow[convgs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objvgs_PaperVerEN.LiteratureLink = objRow[convgs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objvgs_PaperVerEN.UploadfileUrl = objRow[convgs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[convgs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objvgs_PaperVerEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objvgs_PaperVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperVerEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objvgs_PaperVerEN.QuoteId = objRow[convgs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[convgs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objvgs_PaperVerEN.Checker = objRow[convgs_PaperVer.Checker] == DBNull.Value ? null : objRow[convgs_PaperVer.Checker].ToString().Trim(); //审核人
objvgs_PaperVerEN.LiteratureTypeId = objRow[convgs_PaperVer.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvgs_PaperVerEN.LiteratureTypeName = objRow[convgs_PaperVer.LiteratureTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.LiteratureTypeName].ToString().Trim(); //作文类型名
objvgs_PaperVerEN.UpdUser = objRow[convgs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdUser].ToString().Trim(); //修改人
objvgs_PaperVerEN.UpdDate = objRow[convgs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperVerEN.IdCurrEduCls = objRow[convgs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperVerEN.PaperTypeId = objRow[convgs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PaperVerEN.PaperTypeName = objRow[convgs_PaperVer.PaperTypeName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperTypeName].ToString().Trim(); //论文类型名
objvgs_PaperVerEN.PaperStatusId = objRow[convgs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objvgs_PaperVerEN.PaperStatusName = objRow[convgs_PaperVer.PaperStatusName] == DBNull.Value ? null : objRow[convgs_PaperVer.PaperStatusName].ToString().Trim(); //论文状态名
objvgs_PaperVerEN.Memo = objRow[convgs_PaperVer.Memo] == DBNull.Value ? null : objRow[convgs_PaperVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperVerEN.PaperVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperVerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvgs_PaperVerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvgs_PaperVer(ref clsvgs_PaperVerEN objvgs_PaperVerEN)
{
bool bolResult = vgs_PaperVerDA.Getvgs_PaperVer(ref objvgs_PaperVerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperVId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_PaperVerEN GetObjByPaperVId(long lngPaperVId)
{
clsvgs_PaperVerEN objvgs_PaperVerEN = vgs_PaperVerDA.GetObjByPaperVId(lngPaperVId);
return objvgs_PaperVerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvgs_PaperVerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvgs_PaperVerEN objvgs_PaperVerEN = vgs_PaperVerDA.GetFirstObj(strWhereCond);
 return objvgs_PaperVerEN;
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
public static clsvgs_PaperVerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvgs_PaperVerEN objvgs_PaperVerEN = vgs_PaperVerDA.GetObjByDataRow(objRow);
 return objvgs_PaperVerEN;
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
public static clsvgs_PaperVerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvgs_PaperVerEN objvgs_PaperVerEN = vgs_PaperVerDA.GetObjByDataRow(objRow);
 return objvgs_PaperVerEN;
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
 /// <param name = "lngPaperVId">所给的关键字</param>
 /// <param name = "lstvgs_PaperVerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_PaperVerEN GetObjByPaperVIdFromList(long lngPaperVId, List<clsvgs_PaperVerEN> lstvgs_PaperVerObjLst)
{
foreach (clsvgs_PaperVerEN objvgs_PaperVerEN in lstvgs_PaperVerObjLst)
{
if (objvgs_PaperVerEN.PaperVId == lngPaperVId)
{
return objvgs_PaperVerEN;
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
 long lngPaperVId;
 try
 {
 lngPaperVId = new clsvgs_PaperVerDA().GetFirstID(strWhereCond);
 return lngPaperVId;
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
 arrList = vgs_PaperVerDA.GetID(strWhereCond);
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
bool bolIsExist = vgs_PaperVerDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngPaperVId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngPaperVId)
{
//检测记录是否存在
bool bolIsExist = vgs_PaperVerDA.IsExist(lngPaperVId);
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
 bolIsExist = clsvgs_PaperVerDA.IsExistTable();
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
 bolIsExist = vgs_PaperVerDA.IsExistTable(strTabName);
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
 /// <param name = "objvgs_PaperVerENS">源对象</param>
 /// <param name = "objvgs_PaperVerENT">目标对象</param>
 public static void CopyTo(clsvgs_PaperVerEN objvgs_PaperVerENS, clsvgs_PaperVerEN objvgs_PaperVerENT)
{
try
{
objvgs_PaperVerENT.PaperVId = objvgs_PaperVerENS.PaperVId; //PaperVId
objvgs_PaperVerENT.PaperId = objvgs_PaperVerENS.PaperId; //论文Id
objvgs_PaperVerENT.PaperTitle = objvgs_PaperVerENS.PaperTitle; //论文标题
objvgs_PaperVerENT.PaperContent = objvgs_PaperVerENS.PaperContent; //主题内容
objvgs_PaperVerENT.Periodical = objvgs_PaperVerENS.Periodical; //期刊
objvgs_PaperVerENT.Author = objvgs_PaperVerENS.Author; //作者
objvgs_PaperVerENT.ResearchQuestion = objvgs_PaperVerENS.ResearchQuestion; //研究问题
objvgs_PaperVerENT.Keyword = objvgs_PaperVerENS.Keyword; //关键字
objvgs_PaperVerENT.LiteratureSources = objvgs_PaperVerENS.LiteratureSources; //文献来源
objvgs_PaperVerENT.LiteratureLink = objvgs_PaperVerENS.LiteratureLink; //文献链接
objvgs_PaperVerENT.UploadfileUrl = objvgs_PaperVerENS.UploadfileUrl; //文件地址
objvgs_PaperVerENT.IsQuotethesis = objvgs_PaperVerENS.IsQuotethesis; //是否引用论文
objvgs_PaperVerENT.IsSubmit = objvgs_PaperVerENS.IsSubmit; //是否提交
objvgs_PaperVerENT.IsChecked = objvgs_PaperVerENS.IsChecked; //是否检查
objvgs_PaperVerENT.QuoteId = objvgs_PaperVerENS.QuoteId; //引用Id
objvgs_PaperVerENT.Checker = objvgs_PaperVerENS.Checker; //审核人
objvgs_PaperVerENT.LiteratureTypeId = objvgs_PaperVerENS.LiteratureTypeId; //作文类型Id
objvgs_PaperVerENT.LiteratureTypeName = objvgs_PaperVerENS.LiteratureTypeName; //作文类型名
objvgs_PaperVerENT.UpdUser = objvgs_PaperVerENS.UpdUser; //修改人
objvgs_PaperVerENT.UpdDate = objvgs_PaperVerENS.UpdDate; //修改日期
objvgs_PaperVerENT.IdCurrEduCls = objvgs_PaperVerENS.IdCurrEduCls; //教学班流水号
objvgs_PaperVerENT.PaperTypeId = objvgs_PaperVerENS.PaperTypeId; //论文类型Id
objvgs_PaperVerENT.PaperTypeName = objvgs_PaperVerENS.PaperTypeName; //论文类型名
objvgs_PaperVerENT.PaperStatusId = objvgs_PaperVerENS.PaperStatusId; //论文状态Id
objvgs_PaperVerENT.PaperStatusName = objvgs_PaperVerENS.PaperStatusName; //论文状态名
objvgs_PaperVerENT.Memo = objvgs_PaperVerENS.Memo; //备注
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
 /// <param name = "objvgs_PaperVerEN">源简化对象</param>
 public static void SetUpdFlag(clsvgs_PaperVerEN objvgs_PaperVerEN)
{
try
{
objvgs_PaperVerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvgs_PaperVerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convgs_PaperVer.PaperVId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.PaperVId = objvgs_PaperVerEN.PaperVId; //PaperVId
}
if (arrFldSet.Contains(convgs_PaperVer.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.PaperId = objvgs_PaperVerEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convgs_PaperVer.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.PaperTitle = objvgs_PaperVerEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convgs_PaperVer.PaperContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.PaperContent = objvgs_PaperVerEN.PaperContent == "[null]" ? null :  objvgs_PaperVerEN.PaperContent; //主题内容
}
if (arrFldSet.Contains(convgs_PaperVer.Periodical, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.Periodical = objvgs_PaperVerEN.Periodical == "[null]" ? null :  objvgs_PaperVerEN.Periodical; //期刊
}
if (arrFldSet.Contains(convgs_PaperVer.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.Author = objvgs_PaperVerEN.Author == "[null]" ? null :  objvgs_PaperVerEN.Author; //作者
}
if (arrFldSet.Contains(convgs_PaperVer.ResearchQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.ResearchQuestion = objvgs_PaperVerEN.ResearchQuestion == "[null]" ? null :  objvgs_PaperVerEN.ResearchQuestion; //研究问题
}
if (arrFldSet.Contains(convgs_PaperVer.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.Keyword = objvgs_PaperVerEN.Keyword == "[null]" ? null :  objvgs_PaperVerEN.Keyword; //关键字
}
if (arrFldSet.Contains(convgs_PaperVer.LiteratureSources, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.LiteratureSources = objvgs_PaperVerEN.LiteratureSources == "[null]" ? null :  objvgs_PaperVerEN.LiteratureSources; //文献来源
}
if (arrFldSet.Contains(convgs_PaperVer.LiteratureLink, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.LiteratureLink = objvgs_PaperVerEN.LiteratureLink == "[null]" ? null :  objvgs_PaperVerEN.LiteratureLink; //文献链接
}
if (arrFldSet.Contains(convgs_PaperVer.UploadfileUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.UploadfileUrl = objvgs_PaperVerEN.UploadfileUrl == "[null]" ? null :  objvgs_PaperVerEN.UploadfileUrl; //文件地址
}
if (arrFldSet.Contains(convgs_PaperVer.IsQuotethesis, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.IsQuotethesis = objvgs_PaperVerEN.IsQuotethesis; //是否引用论文
}
if (arrFldSet.Contains(convgs_PaperVer.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.IsSubmit = objvgs_PaperVerEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convgs_PaperVer.IsChecked, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.IsChecked = objvgs_PaperVerEN.IsChecked; //是否检查
}
if (arrFldSet.Contains(convgs_PaperVer.QuoteId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.QuoteId = objvgs_PaperVerEN.QuoteId == "[null]" ? null :  objvgs_PaperVerEN.QuoteId; //引用Id
}
if (arrFldSet.Contains(convgs_PaperVer.Checker, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.Checker = objvgs_PaperVerEN.Checker == "[null]" ? null :  objvgs_PaperVerEN.Checker; //审核人
}
if (arrFldSet.Contains(convgs_PaperVer.LiteratureTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.LiteratureTypeId = objvgs_PaperVerEN.LiteratureTypeId; //作文类型Id
}
if (arrFldSet.Contains(convgs_PaperVer.LiteratureTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.LiteratureTypeName = objvgs_PaperVerEN.LiteratureTypeName == "[null]" ? null :  objvgs_PaperVerEN.LiteratureTypeName; //作文类型名
}
if (arrFldSet.Contains(convgs_PaperVer.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.UpdUser = objvgs_PaperVerEN.UpdUser == "[null]" ? null :  objvgs_PaperVerEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convgs_PaperVer.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.UpdDate = objvgs_PaperVerEN.UpdDate == "[null]" ? null :  objvgs_PaperVerEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convgs_PaperVer.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.IdCurrEduCls = objvgs_PaperVerEN.IdCurrEduCls == "[null]" ? null :  objvgs_PaperVerEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convgs_PaperVer.PaperTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.PaperTypeId = objvgs_PaperVerEN.PaperTypeId == "[null]" ? null :  objvgs_PaperVerEN.PaperTypeId; //论文类型Id
}
if (arrFldSet.Contains(convgs_PaperVer.PaperTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.PaperTypeName = objvgs_PaperVerEN.PaperTypeName == "[null]" ? null :  objvgs_PaperVerEN.PaperTypeName; //论文类型名
}
if (arrFldSet.Contains(convgs_PaperVer.PaperStatusId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.PaperStatusId = objvgs_PaperVerEN.PaperStatusId == "[null]" ? null :  objvgs_PaperVerEN.PaperStatusId; //论文状态Id
}
if (arrFldSet.Contains(convgs_PaperVer.PaperStatusName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.PaperStatusName = objvgs_PaperVerEN.PaperStatusName == "[null]" ? null :  objvgs_PaperVerEN.PaperStatusName; //论文状态名
}
if (arrFldSet.Contains(convgs_PaperVer.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperVerEN.Memo = objvgs_PaperVerEN.Memo == "[null]" ? null :  objvgs_PaperVerEN.Memo; //备注
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
 /// <param name = "objvgs_PaperVerEN">源简化对象</param>
 public static void AccessFldValueNull(clsvgs_PaperVerEN objvgs_PaperVerEN)
{
try
{
if (objvgs_PaperVerEN.PaperContent == "[null]") objvgs_PaperVerEN.PaperContent = null; //主题内容
if (objvgs_PaperVerEN.Periodical == "[null]") objvgs_PaperVerEN.Periodical = null; //期刊
if (objvgs_PaperVerEN.Author == "[null]") objvgs_PaperVerEN.Author = null; //作者
if (objvgs_PaperVerEN.ResearchQuestion == "[null]") objvgs_PaperVerEN.ResearchQuestion = null; //研究问题
if (objvgs_PaperVerEN.Keyword == "[null]") objvgs_PaperVerEN.Keyword = null; //关键字
if (objvgs_PaperVerEN.LiteratureSources == "[null]") objvgs_PaperVerEN.LiteratureSources = null; //文献来源
if (objvgs_PaperVerEN.LiteratureLink == "[null]") objvgs_PaperVerEN.LiteratureLink = null; //文献链接
if (objvgs_PaperVerEN.UploadfileUrl == "[null]") objvgs_PaperVerEN.UploadfileUrl = null; //文件地址
if (objvgs_PaperVerEN.QuoteId == "[null]") objvgs_PaperVerEN.QuoteId = null; //引用Id
if (objvgs_PaperVerEN.Checker == "[null]") objvgs_PaperVerEN.Checker = null; //审核人
if (objvgs_PaperVerEN.LiteratureTypeName == "[null]") objvgs_PaperVerEN.LiteratureTypeName = null; //作文类型名
if (objvgs_PaperVerEN.UpdUser == "[null]") objvgs_PaperVerEN.UpdUser = null; //修改人
if (objvgs_PaperVerEN.UpdDate == "[null]") objvgs_PaperVerEN.UpdDate = null; //修改日期
if (objvgs_PaperVerEN.IdCurrEduCls == "[null]") objvgs_PaperVerEN.IdCurrEduCls = null; //教学班流水号
if (objvgs_PaperVerEN.PaperTypeId == "[null]") objvgs_PaperVerEN.PaperTypeId = null; //论文类型Id
if (objvgs_PaperVerEN.PaperTypeName == "[null]") objvgs_PaperVerEN.PaperTypeName = null; //论文类型名
if (objvgs_PaperVerEN.PaperStatusId == "[null]") objvgs_PaperVerEN.PaperStatusId = null; //论文状态Id
if (objvgs_PaperVerEN.PaperStatusName == "[null]") objvgs_PaperVerEN.PaperStatusName = null; //论文状态名
if (objvgs_PaperVerEN.Memo == "[null]") objvgs_PaperVerEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvgs_PaperVerEN objvgs_PaperVerEN)
{
 vgs_PaperVerDA.CheckProperty4Condition(objvgs_PaperVerEN);
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
if (clsLiteratureTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsLiteratureTypeBL没有刷新缓存机制(clsLiteratureTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_PaperTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PaperTypeBL没有刷新缓存机制(clsgs_PaperTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_PaperStatusBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PaperStatusBL没有刷新缓存机制(clsgs_PaperStatusBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_PaperVerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PaperVerBL没有刷新缓存机制(clsgs_PaperVerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperVId");
//if (arrvgs_PaperVerObjLstCache == null)
//{
//arrvgs_PaperVerObjLstCache = vgs_PaperVerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngPaperVId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_PaperVerEN GetObjByPaperVIdCache(long lngPaperVId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvgs_PaperVerEN._CurrTabName);
List<clsvgs_PaperVerEN> arrvgs_PaperVerObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PaperVerEN> arrvgs_PaperVerObjLst_Sel =
arrvgs_PaperVerObjLstCache
.Where(x=> x.PaperVId == lngPaperVId 
);
if (arrvgs_PaperVerObjLst_Sel.Count() == 0)
{
   clsvgs_PaperVerEN obj = clsvgs_PaperVerBL.GetObjByPaperVId(lngPaperVId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvgs_PaperVerObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_PaperVerEN> GetAllvgs_PaperVerObjLstCache()
{
//获取缓存中的对象列表
List<clsvgs_PaperVerEN> arrvgs_PaperVerObjLstCache = GetObjLstCache(); 
return arrvgs_PaperVerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_PaperVerEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvgs_PaperVerEN._CurrTabName);
List<clsvgs_PaperVerEN> arrvgs_PaperVerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvgs_PaperVerObjLstCache;
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
string strKey = string.Format("{0}", clsvgs_PaperVerEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngPaperVId)
{
if (strInFldName != convgs_PaperVer.PaperVId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convgs_PaperVer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convgs_PaperVer.AttributeName));
throw new Exception(strMsg);
}
var objvgs_PaperVer = clsvgs_PaperVerBL.GetObjByPaperVIdCache(lngPaperVId);
if (objvgs_PaperVer == null) return "";
return objvgs_PaperVer[strOutFldName].ToString();
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
int intRecCount = clsvgs_PaperVerDA.GetRecCount(strTabName);
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
int intRecCount = clsvgs_PaperVerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvgs_PaperVerDA.GetRecCount();
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
int intRecCount = clsvgs_PaperVerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvgs_PaperVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvgs_PaperVerEN objvgs_PaperVerCond)
{
List<clsvgs_PaperVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PaperVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_PaperVer.AttributeName)
{
if (objvgs_PaperVerCond.IsUpdated(strFldName) == false) continue;
if (objvgs_PaperVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PaperVerCond[strFldName].ToString());
}
else
{
if (objvgs_PaperVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_PaperVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PaperVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_PaperVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_PaperVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_PaperVerCond[strFldName]));
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
 List<string> arrList = clsvgs_PaperVerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vgs_PaperVerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vgs_PaperVerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}