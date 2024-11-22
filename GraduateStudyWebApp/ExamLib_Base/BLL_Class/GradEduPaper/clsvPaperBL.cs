
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperBL
 表名:vPaper(01120549)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:08
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
public static class  clsvPaperBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperEN GetObj(this K_PaperId_vPaper myKey)
{
clsvPaperEN objvPaperEN = clsvPaperBL.vPaperDA.GetObjByPaperId(myKey.Value);
return objvPaperEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetPaperId(this clsvPaperEN objvPaperEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convPaper.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convPaper.PaperId);
}
objvPaperEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.PaperId) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.PaperId, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.PaperId] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetPaperTitle(this clsvPaperEN objvPaperEN, string strPaperTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperTitle, convPaper.PaperTitle);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convPaper.PaperTitle);
}
objvPaperEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.PaperTitle) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.PaperTitle, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.PaperTitle] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetPaperContent(this clsvPaperEN objvPaperEN, string strPaperContent, string strComparisonOp="")
	{
objvPaperEN.PaperContent = strPaperContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.PaperContent) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.PaperContent, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.PaperContent] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetPeriodical(this clsvPaperEN objvPaperEN, string strPeriodical, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPeriodical, 100, convPaper.Periodical);
}
objvPaperEN.Periodical = strPeriodical; //期刊
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.Periodical) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.Periodical, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.Periodical] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetAuthor(this clsvPaperEN objvPaperEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convPaper.Author);
}
objvPaperEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.Author) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.Author, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.Author] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetResearchQuestion(this clsvPaperEN objvPaperEN, string strResearchQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, convPaper.ResearchQuestion);
}
objvPaperEN.ResearchQuestion = strResearchQuestion; //研究问题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.ResearchQuestion) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.ResearchQuestion, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.ResearchQuestion] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetKeyword(this clsvPaperEN objvPaperEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convPaper.Keyword);
}
objvPaperEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.Keyword) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.Keyword, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.Keyword] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetLiteratureSources(this clsvPaperEN objvPaperEN, string strLiteratureSources, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureSources, 1000, convPaper.LiteratureSources);
}
objvPaperEN.LiteratureSources = strLiteratureSources; //文献来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.LiteratureSources) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.LiteratureSources, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.LiteratureSources] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetLiteratureLink(this clsvPaperEN objvPaperEN, string strLiteratureLink, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureLink, 1000, convPaper.LiteratureLink);
}
objvPaperEN.LiteratureLink = strLiteratureLink; //文献链接
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.LiteratureLink) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.LiteratureLink, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.LiteratureLink] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetUploadfileUrl(this clsvPaperEN objvPaperEN, string strUploadfileUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadfileUrl, 1000, convPaper.UploadfileUrl);
}
objvPaperEN.UploadfileUrl = strUploadfileUrl; //文件地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.UploadfileUrl) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.UploadfileUrl, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.UploadfileUrl] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetIsQuotethesis(this clsvPaperEN objvPaperEN, bool bolIsQuotethesis, string strComparisonOp="")
	{
objvPaperEN.IsQuotethesis = bolIsQuotethesis; //是否引用论文
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.IsQuotethesis) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.IsQuotethesis, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.IsQuotethesis] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetQuoteId(this clsvPaperEN objvPaperEN, string strQuoteId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuoteId, 8, convPaper.QuoteId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuoteId, 8, convPaper.QuoteId);
}
objvPaperEN.QuoteId = strQuoteId; //引用Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.QuoteId) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.QuoteId, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.QuoteId] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetIsChecked(this clsvPaperEN objvPaperEN, bool bolIsChecked, string strComparisonOp="")
	{
objvPaperEN.IsChecked = bolIsChecked; //是否检查
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.IsChecked) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.IsChecked, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.IsChecked] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetChecker(this clsvPaperEN objvPaperEN, string strChecker, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChecker, 20, convPaper.Checker);
}
objvPaperEN.Checker = strChecker; //审核人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.Checker) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.Checker, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.Checker] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetLiteratureTypeId(this clsvPaperEN objvPaperEN, string strLiteratureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLiteratureTypeId, convPaper.LiteratureTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureTypeId, 2, convPaper.LiteratureTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLiteratureTypeId, 2, convPaper.LiteratureTypeId);
}
objvPaperEN.LiteratureTypeId = strLiteratureTypeId; //作文类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.LiteratureTypeId) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.LiteratureTypeId, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.LiteratureTypeId] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetLiteratureTypeName(this clsvPaperEN objvPaperEN, string strLiteratureTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureTypeName, 100, convPaper.LiteratureTypeName);
}
objvPaperEN.LiteratureTypeName = strLiteratureTypeName; //作文类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.LiteratureTypeName) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.LiteratureTypeName, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.LiteratureTypeName] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetBrowseNumber(this clsvPaperEN objvPaperEN, int? intBrowseNumber, string strComparisonOp="")
	{
objvPaperEN.BrowseNumber = intBrowseNumber; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.BrowseNumber) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.BrowseNumber, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.BrowseNumber] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetIsSubmit(this clsvPaperEN objvPaperEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvPaperEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.IsSubmit) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.IsSubmit, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.IsSubmit] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetAppraiseCount(this clsvPaperEN objvPaperEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvPaperEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.AppraiseCount) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.AppraiseCount, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.AppraiseCount] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetAttachmentCount(this clsvPaperEN objvPaperEN, int? intAttachmentCount, string strComparisonOp="")
	{
objvPaperEN.AttachmentCount = intAttachmentCount; //附件计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.AttachmentCount) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.AttachmentCount, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.AttachmentCount] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetCollectionCount(this clsvPaperEN objvPaperEN, long? lngCollectionCount, string strComparisonOp="")
	{
objvPaperEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.CollectionCount) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.CollectionCount, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.CollectionCount] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetDownloadCount(this clsvPaperEN objvPaperEN, int? intDownloadCount, string strComparisonOp="")
	{
objvPaperEN.DownloadCount = intDownloadCount; //下载数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.DownloadCount) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.DownloadCount, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.DownloadCount] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetOkCount(this clsvPaperEN objvPaperEN, int? intOkCount, string strComparisonOp="")
	{
objvPaperEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.OkCount) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.OkCount, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.OkCount] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetPcount(this clsvPaperEN objvPaperEN, int? intPcount, string strComparisonOp="")
	{
objvPaperEN.Pcount = intPcount; //读写数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.Pcount) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.Pcount, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.Pcount] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetScore(this clsvPaperEN objvPaperEN, float? fltScore, string strComparisonOp="")
	{
objvPaperEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.Score) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.Score, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.Score] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetStuScore(this clsvPaperEN objvPaperEN, float? fltStuScore, string strComparisonOp="")
	{
objvPaperEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.StuScore) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.StuScore, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.StuScore] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetTeaScore(this clsvPaperEN objvPaperEN, float? fltTeaScore, string strComparisonOp="")
	{
objvPaperEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.TeaScore) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.TeaScore, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.TeaScore] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetPaperTypeId(this clsvPaperEN objvPaperEN, string strPaperTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTypeId, 2, convPaper.PaperTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperTypeId, 2, convPaper.PaperTypeId);
}
objvPaperEN.PaperTypeId = strPaperTypeId; //论文类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.PaperTypeId) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.PaperTypeId, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.PaperTypeId] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetPaperTypeName(this clsvPaperEN objvPaperEN, string strPaperTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTypeName, 50, convPaper.PaperTypeName);
}
objvPaperEN.PaperTypeName = strPaperTypeName; //论文类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.PaperTypeName) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.PaperTypeName, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.PaperTypeName] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetPaperStatusId(this clsvPaperEN objvPaperEN, string strPaperStatusId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperStatusId, 2, convPaper.PaperStatusId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperStatusId, 2, convPaper.PaperStatusId);
}
objvPaperEN.PaperStatusId = strPaperStatusId; //论文状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.PaperStatusId) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.PaperStatusId, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.PaperStatusId] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetPaperStatusName(this clsvPaperEN objvPaperEN, string strPaperStatusName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperStatusName, 50, convPaper.PaperStatusName);
}
objvPaperEN.PaperStatusName = strPaperStatusName; //论文状态名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.PaperStatusName) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.PaperStatusName, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.PaperStatusName] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetVersionCount(this clsvPaperEN objvPaperEN, int? intVersionCount, string strComparisonOp="")
	{
objvPaperEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.VersionCount) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.VersionCount, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.VersionCount] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetIsPublic(this clsvPaperEN objvPaperEN, bool bolIsPublic, string strComparisonOp="")
	{
objvPaperEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.IsPublic) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.IsPublic, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.IsPublic] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetAskQuestion(this clsvPaperEN objvPaperEN, string strAskQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAskQuestion, 5000, convPaper.AskQuestion);
}
objvPaperEN.AskQuestion = strAskQuestion; //问题提出
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.AskQuestion) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.AskQuestion, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.AskQuestion] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetResearchStatus(this clsvPaperEN objvPaperEN, string strResearchStatus, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchStatus, 5000, convPaper.ResearchStatus);
}
objvPaperEN.ResearchStatus = strResearchStatus; //目前研究的现状
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.ResearchStatus) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.ResearchStatus, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.ResearchStatus] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetInnovationPoints(this clsvPaperEN objvPaperEN, string strInnovationPoints, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInnovationPoints, 5000, convPaper.InnovationPoints);
}
objvPaperEN.InnovationPoints = strInnovationPoints; //创新点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.InnovationPoints) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.InnovationPoints, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.InnovationPoints] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetResearchDesign(this clsvPaperEN objvPaperEN, string strResearchDesign, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchDesign, 5000, convPaper.ResearchDesign);
}
objvPaperEN.ResearchDesign = strResearchDesign; //研究设计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.ResearchDesign) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.ResearchDesign, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.ResearchDesign] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetDimensionDataProcess(this clsvPaperEN objvPaperEN, string strDimensionDataProcess, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDimensionDataProcess, 5000, convPaper.DimensionDataProcess);
}
objvPaperEN.DimensionDataProcess = strDimensionDataProcess; //数据处理的维度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.DimensionDataProcess) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.DimensionDataProcess, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.DimensionDataProcess] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetExpectedConclusion(this clsvPaperEN objvPaperEN, string strExpectedConclusion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExpectedConclusion, 5000, convPaper.ExpectedConclusion);
}
objvPaperEN.ExpectedConclusion = strExpectedConclusion; //预期结论
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.ExpectedConclusion) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.ExpectedConclusion, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.ExpectedConclusion] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetShareId(this clsvPaperEN objvPaperEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convPaper.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convPaper.ShareId);
}
objvPaperEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.ShareId) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.ShareId, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.ShareId] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetPaperQCount(this clsvPaperEN objvPaperEN, int? intPaperQCount, string strComparisonOp="")
	{
objvPaperEN.PaperQCount = intPaperQCount; //论文答疑数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.PaperQCount) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.PaperQCount, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.PaperQCount] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetSubVCount(this clsvPaperEN objvPaperEN, int? intSubVCount, string strComparisonOp="")
	{
objvPaperEN.SubVCount = intSubVCount; //论文子观点数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.SubVCount) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.SubVCount, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.SubVCount] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetTagsCount(this clsvPaperEN objvPaperEN, int? intTagsCount, string strComparisonOp="")
	{
objvPaperEN.TagsCount = intTagsCount; //论文标注数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.TagsCount) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.TagsCount, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.TagsCount] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetTeaQCount(this clsvPaperEN objvPaperEN, int? intTeaQCount, string strComparisonOp="")
	{
objvPaperEN.TeaQCount = intTeaQCount; //教师提问数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.TeaQCount) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.TeaQCount, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.TeaQCount] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetCreateDate(this clsvPaperEN objvPaperEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convPaper.CreateDate);
}
objvPaperEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.CreateDate) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.CreateDate, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.CreateDate] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetUpdUser(this clsvPaperEN objvPaperEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPaper.UpdUser);
}
objvPaperEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.UpdUser) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.UpdUser, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.UpdUser] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetUserName(this clsvPaperEN objvPaperEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convPaper.UserName);
}
objvPaperEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.UserName) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.UserName, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.UserName] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetIdXzCollege(this clsvPaperEN objvPaperEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convPaper.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convPaper.IdXzCollege);
}
objvPaperEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.IdXzCollege) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.IdXzCollege, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.IdXzCollege] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetUpdDate(this clsvPaperEN objvPaperEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPaper.UpdDate);
}
objvPaperEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.UpdDate) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.UpdDate, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.UpdDate] = strComparisonOp;
}
}
return objvPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEN SetMemo(this clsvPaperEN objvPaperEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPaper.Memo);
}
objvPaperEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEN.dicFldComparisonOp.ContainsKey(convPaper.Memo) == false)
{
objvPaperEN.dicFldComparisonOp.Add(convPaper.Memo, strComparisonOp);
}
else
{
objvPaperEN.dicFldComparisonOp[convPaper.Memo] = strComparisonOp;
}
}
return objvPaperEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPaperENS">源对象</param>
 /// <param name = "objvPaperENT">目标对象</param>
 public static void CopyTo(this clsvPaperEN objvPaperENS, clsvPaperEN objvPaperENT)
{
try
{
objvPaperENT.PaperId = objvPaperENS.PaperId; //论文Id
objvPaperENT.PaperTitle = objvPaperENS.PaperTitle; //论文标题
objvPaperENT.PaperContent = objvPaperENS.PaperContent; //主题内容
objvPaperENT.Periodical = objvPaperENS.Periodical; //期刊
objvPaperENT.Author = objvPaperENS.Author; //作者
objvPaperENT.ResearchQuestion = objvPaperENS.ResearchQuestion; //研究问题
objvPaperENT.Keyword = objvPaperENS.Keyword; //关键字
objvPaperENT.LiteratureSources = objvPaperENS.LiteratureSources; //文献来源
objvPaperENT.LiteratureLink = objvPaperENS.LiteratureLink; //文献链接
objvPaperENT.UploadfileUrl = objvPaperENS.UploadfileUrl; //文件地址
objvPaperENT.IsQuotethesis = objvPaperENS.IsQuotethesis; //是否引用论文
objvPaperENT.QuoteId = objvPaperENS.QuoteId; //引用Id
objvPaperENT.IsChecked = objvPaperENS.IsChecked; //是否检查
objvPaperENT.Checker = objvPaperENS.Checker; //审核人
objvPaperENT.LiteratureTypeId = objvPaperENS.LiteratureTypeId; //作文类型Id
objvPaperENT.LiteratureTypeName = objvPaperENS.LiteratureTypeName; //作文类型名
objvPaperENT.BrowseNumber = objvPaperENS.BrowseNumber; //浏览量
objvPaperENT.IsSubmit = objvPaperENS.IsSubmit; //是否提交
objvPaperENT.AppraiseCount = objvPaperENS.AppraiseCount; //评论数
objvPaperENT.AttachmentCount = objvPaperENS.AttachmentCount; //附件计数
objvPaperENT.CollectionCount = objvPaperENS.CollectionCount; //收藏数量
objvPaperENT.DownloadCount = objvPaperENS.DownloadCount; //下载数
objvPaperENT.OkCount = objvPaperENS.OkCount; //点赞统计
objvPaperENT.Pcount = objvPaperENS.Pcount; //读写数
objvPaperENT.Score = objvPaperENS.Score; //评分
objvPaperENT.StuScore = objvPaperENS.StuScore; //学生平均分
objvPaperENT.TeaScore = objvPaperENS.TeaScore; //教师评分
objvPaperENT.PaperTypeId = objvPaperENS.PaperTypeId; //论文类型Id
objvPaperENT.PaperTypeName = objvPaperENS.PaperTypeName; //论文类型名
objvPaperENT.PaperStatusId = objvPaperENS.PaperStatusId; //论文状态Id
objvPaperENT.PaperStatusName = objvPaperENS.PaperStatusName; //论文状态名
objvPaperENT.VersionCount = objvPaperENS.VersionCount; //版本统计
objvPaperENT.IsPublic = objvPaperENS.IsPublic; //是否公开
objvPaperENT.AskQuestion = objvPaperENS.AskQuestion; //问题提出
objvPaperENT.ResearchStatus = objvPaperENS.ResearchStatus; //目前研究的现状
objvPaperENT.InnovationPoints = objvPaperENS.InnovationPoints; //创新点
objvPaperENT.ResearchDesign = objvPaperENS.ResearchDesign; //研究设计
objvPaperENT.DimensionDataProcess = objvPaperENS.DimensionDataProcess; //数据处理的维度
objvPaperENT.ExpectedConclusion = objvPaperENS.ExpectedConclusion; //预期结论
objvPaperENT.ShareId = objvPaperENS.ShareId; //分享Id
objvPaperENT.PaperQCount = objvPaperENS.PaperQCount; //论文答疑数
objvPaperENT.SubVCount = objvPaperENS.SubVCount; //论文子观点数
objvPaperENT.TagsCount = objvPaperENS.TagsCount; //论文标注数
objvPaperENT.TeaQCount = objvPaperENS.TeaQCount; //教师提问数
objvPaperENT.CreateDate = objvPaperENS.CreateDate; //建立日期
objvPaperENT.UpdUser = objvPaperENS.UpdUser; //修改人
objvPaperENT.UserName = objvPaperENS.UserName; //用户名
objvPaperENT.IdXzCollege = objvPaperENS.IdXzCollege; //学院流水号
objvPaperENT.UpdDate = objvPaperENS.UpdDate; //修改日期
objvPaperENT.Memo = objvPaperENS.Memo; //备注
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
 /// <param name = "objvPaperENS">源对象</param>
 /// <returns>目标对象=>clsvPaperEN:objvPaperENT</returns>
 public static clsvPaperEN CopyTo(this clsvPaperEN objvPaperENS)
{
try
{
 clsvPaperEN objvPaperENT = new clsvPaperEN()
{
PaperId = objvPaperENS.PaperId, //论文Id
PaperTitle = objvPaperENS.PaperTitle, //论文标题
PaperContent = objvPaperENS.PaperContent, //主题内容
Periodical = objvPaperENS.Periodical, //期刊
Author = objvPaperENS.Author, //作者
ResearchQuestion = objvPaperENS.ResearchQuestion, //研究问题
Keyword = objvPaperENS.Keyword, //关键字
LiteratureSources = objvPaperENS.LiteratureSources, //文献来源
LiteratureLink = objvPaperENS.LiteratureLink, //文献链接
UploadfileUrl = objvPaperENS.UploadfileUrl, //文件地址
IsQuotethesis = objvPaperENS.IsQuotethesis, //是否引用论文
QuoteId = objvPaperENS.QuoteId, //引用Id
IsChecked = objvPaperENS.IsChecked, //是否检查
Checker = objvPaperENS.Checker, //审核人
LiteratureTypeId = objvPaperENS.LiteratureTypeId, //作文类型Id
LiteratureTypeName = objvPaperENS.LiteratureTypeName, //作文类型名
BrowseNumber = objvPaperENS.BrowseNumber, //浏览量
IsSubmit = objvPaperENS.IsSubmit, //是否提交
AppraiseCount = objvPaperENS.AppraiseCount, //评论数
AttachmentCount = objvPaperENS.AttachmentCount, //附件计数
CollectionCount = objvPaperENS.CollectionCount, //收藏数量
DownloadCount = objvPaperENS.DownloadCount, //下载数
OkCount = objvPaperENS.OkCount, //点赞统计
Pcount = objvPaperENS.Pcount, //读写数
Score = objvPaperENS.Score, //评分
StuScore = objvPaperENS.StuScore, //学生平均分
TeaScore = objvPaperENS.TeaScore, //教师评分
PaperTypeId = objvPaperENS.PaperTypeId, //论文类型Id
PaperTypeName = objvPaperENS.PaperTypeName, //论文类型名
PaperStatusId = objvPaperENS.PaperStatusId, //论文状态Id
PaperStatusName = objvPaperENS.PaperStatusName, //论文状态名
VersionCount = objvPaperENS.VersionCount, //版本统计
IsPublic = objvPaperENS.IsPublic, //是否公开
AskQuestion = objvPaperENS.AskQuestion, //问题提出
ResearchStatus = objvPaperENS.ResearchStatus, //目前研究的现状
InnovationPoints = objvPaperENS.InnovationPoints, //创新点
ResearchDesign = objvPaperENS.ResearchDesign, //研究设计
DimensionDataProcess = objvPaperENS.DimensionDataProcess, //数据处理的维度
ExpectedConclusion = objvPaperENS.ExpectedConclusion, //预期结论
ShareId = objvPaperENS.ShareId, //分享Id
PaperQCount = objvPaperENS.PaperQCount, //论文答疑数
SubVCount = objvPaperENS.SubVCount, //论文子观点数
TagsCount = objvPaperENS.TagsCount, //论文标注数
TeaQCount = objvPaperENS.TeaQCount, //教师提问数
CreateDate = objvPaperENS.CreateDate, //建立日期
UpdUser = objvPaperENS.UpdUser, //修改人
UserName = objvPaperENS.UserName, //用户名
IdXzCollege = objvPaperENS.IdXzCollege, //学院流水号
UpdDate = objvPaperENS.UpdDate, //修改日期
Memo = objvPaperENS.Memo, //备注
};
 return objvPaperENT;
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
public static void CheckProperty4Condition(this clsvPaperEN objvPaperEN)
{
 clsvPaperBL.vPaperDA.CheckProperty4Condition(objvPaperEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPaperEN objvPaperCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPaperCond.IsUpdated(convPaper.PaperId) == true)
{
string strComparisonOpPaperId = objvPaperCond.dicFldComparisonOp[convPaper.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.PaperId, objvPaperCond.PaperId, strComparisonOpPaperId);
}
if (objvPaperCond.IsUpdated(convPaper.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvPaperCond.dicFldComparisonOp[convPaper.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.PaperTitle, objvPaperCond.PaperTitle, strComparisonOpPaperTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvPaperCond.IsUpdated(convPaper.Periodical) == true)
{
string strComparisonOpPeriodical = objvPaperCond.dicFldComparisonOp[convPaper.Periodical];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.Periodical, objvPaperCond.Periodical, strComparisonOpPeriodical);
}
if (objvPaperCond.IsUpdated(convPaper.Author) == true)
{
string strComparisonOpAuthor = objvPaperCond.dicFldComparisonOp[convPaper.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.Author, objvPaperCond.Author, strComparisonOpAuthor);
}
if (objvPaperCond.IsUpdated(convPaper.ResearchQuestion) == true)
{
string strComparisonOpResearchQuestion = objvPaperCond.dicFldComparisonOp[convPaper.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.ResearchQuestion, objvPaperCond.ResearchQuestion, strComparisonOpResearchQuestion);
}
if (objvPaperCond.IsUpdated(convPaper.Keyword) == true)
{
string strComparisonOpKeyword = objvPaperCond.dicFldComparisonOp[convPaper.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.Keyword, objvPaperCond.Keyword, strComparisonOpKeyword);
}
if (objvPaperCond.IsUpdated(convPaper.LiteratureSources) == true)
{
string strComparisonOpLiteratureSources = objvPaperCond.dicFldComparisonOp[convPaper.LiteratureSources];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.LiteratureSources, objvPaperCond.LiteratureSources, strComparisonOpLiteratureSources);
}
if (objvPaperCond.IsUpdated(convPaper.LiteratureLink) == true)
{
string strComparisonOpLiteratureLink = objvPaperCond.dicFldComparisonOp[convPaper.LiteratureLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.LiteratureLink, objvPaperCond.LiteratureLink, strComparisonOpLiteratureLink);
}
if (objvPaperCond.IsUpdated(convPaper.UploadfileUrl) == true)
{
string strComparisonOpUploadfileUrl = objvPaperCond.dicFldComparisonOp[convPaper.UploadfileUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.UploadfileUrl, objvPaperCond.UploadfileUrl, strComparisonOpUploadfileUrl);
}
if (objvPaperCond.IsUpdated(convPaper.IsQuotethesis) == true)
{
if (objvPaperCond.IsQuotethesis == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPaper.IsQuotethesis);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPaper.IsQuotethesis);
}
}
if (objvPaperCond.IsUpdated(convPaper.QuoteId) == true)
{
string strComparisonOpQuoteId = objvPaperCond.dicFldComparisonOp[convPaper.QuoteId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.QuoteId, objvPaperCond.QuoteId, strComparisonOpQuoteId);
}
if (objvPaperCond.IsUpdated(convPaper.IsChecked) == true)
{
if (objvPaperCond.IsChecked == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPaper.IsChecked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPaper.IsChecked);
}
}
if (objvPaperCond.IsUpdated(convPaper.Checker) == true)
{
string strComparisonOpChecker = objvPaperCond.dicFldComparisonOp[convPaper.Checker];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.Checker, objvPaperCond.Checker, strComparisonOpChecker);
}
if (objvPaperCond.IsUpdated(convPaper.LiteratureTypeId) == true)
{
string strComparisonOpLiteratureTypeId = objvPaperCond.dicFldComparisonOp[convPaper.LiteratureTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.LiteratureTypeId, objvPaperCond.LiteratureTypeId, strComparisonOpLiteratureTypeId);
}
if (objvPaperCond.IsUpdated(convPaper.LiteratureTypeName) == true)
{
string strComparisonOpLiteratureTypeName = objvPaperCond.dicFldComparisonOp[convPaper.LiteratureTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.LiteratureTypeName, objvPaperCond.LiteratureTypeName, strComparisonOpLiteratureTypeName);
}
if (objvPaperCond.IsUpdated(convPaper.BrowseNumber) == true)
{
string strComparisonOpBrowseNumber = objvPaperCond.dicFldComparisonOp[convPaper.BrowseNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convPaper.BrowseNumber, objvPaperCond.BrowseNumber, strComparisonOpBrowseNumber);
}
if (objvPaperCond.IsUpdated(convPaper.IsSubmit) == true)
{
if (objvPaperCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPaper.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPaper.IsSubmit);
}
}
if (objvPaperCond.IsUpdated(convPaper.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvPaperCond.dicFldComparisonOp[convPaper.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaper.AppraiseCount, objvPaperCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvPaperCond.IsUpdated(convPaper.AttachmentCount) == true)
{
string strComparisonOpAttachmentCount = objvPaperCond.dicFldComparisonOp[convPaper.AttachmentCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaper.AttachmentCount, objvPaperCond.AttachmentCount, strComparisonOpAttachmentCount);
}
if (objvPaperCond.IsUpdated(convPaper.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvPaperCond.dicFldComparisonOp[convPaper.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaper.CollectionCount, objvPaperCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objvPaperCond.IsUpdated(convPaper.DownloadCount) == true)
{
string strComparisonOpDownloadCount = objvPaperCond.dicFldComparisonOp[convPaper.DownloadCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaper.DownloadCount, objvPaperCond.DownloadCount, strComparisonOpDownloadCount);
}
if (objvPaperCond.IsUpdated(convPaper.OkCount) == true)
{
string strComparisonOpOkCount = objvPaperCond.dicFldComparisonOp[convPaper.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaper.OkCount, objvPaperCond.OkCount, strComparisonOpOkCount);
}
if (objvPaperCond.IsUpdated(convPaper.Pcount) == true)
{
string strComparisonOpPcount = objvPaperCond.dicFldComparisonOp[convPaper.Pcount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaper.Pcount, objvPaperCond.Pcount, strComparisonOpPcount);
}
if (objvPaperCond.IsUpdated(convPaper.Score) == true)
{
string strComparisonOpScore = objvPaperCond.dicFldComparisonOp[convPaper.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convPaper.Score, objvPaperCond.Score, strComparisonOpScore);
}
if (objvPaperCond.IsUpdated(convPaper.StuScore) == true)
{
string strComparisonOpStuScore = objvPaperCond.dicFldComparisonOp[convPaper.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convPaper.StuScore, objvPaperCond.StuScore, strComparisonOpStuScore);
}
if (objvPaperCond.IsUpdated(convPaper.TeaScore) == true)
{
string strComparisonOpTeaScore = objvPaperCond.dicFldComparisonOp[convPaper.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convPaper.TeaScore, objvPaperCond.TeaScore, strComparisonOpTeaScore);
}
if (objvPaperCond.IsUpdated(convPaper.PaperTypeId) == true)
{
string strComparisonOpPaperTypeId = objvPaperCond.dicFldComparisonOp[convPaper.PaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.PaperTypeId, objvPaperCond.PaperTypeId, strComparisonOpPaperTypeId);
}
if (objvPaperCond.IsUpdated(convPaper.PaperTypeName) == true)
{
string strComparisonOpPaperTypeName = objvPaperCond.dicFldComparisonOp[convPaper.PaperTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.PaperTypeName, objvPaperCond.PaperTypeName, strComparisonOpPaperTypeName);
}
if (objvPaperCond.IsUpdated(convPaper.PaperStatusId) == true)
{
string strComparisonOpPaperStatusId = objvPaperCond.dicFldComparisonOp[convPaper.PaperStatusId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.PaperStatusId, objvPaperCond.PaperStatusId, strComparisonOpPaperStatusId);
}
if (objvPaperCond.IsUpdated(convPaper.PaperStatusName) == true)
{
string strComparisonOpPaperStatusName = objvPaperCond.dicFldComparisonOp[convPaper.PaperStatusName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.PaperStatusName, objvPaperCond.PaperStatusName, strComparisonOpPaperStatusName);
}
if (objvPaperCond.IsUpdated(convPaper.VersionCount) == true)
{
string strComparisonOpVersionCount = objvPaperCond.dicFldComparisonOp[convPaper.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaper.VersionCount, objvPaperCond.VersionCount, strComparisonOpVersionCount);
}
if (objvPaperCond.IsUpdated(convPaper.IsPublic) == true)
{
if (objvPaperCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPaper.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPaper.IsPublic);
}
}
if (objvPaperCond.IsUpdated(convPaper.AskQuestion) == true)
{
string strComparisonOpAskQuestion = objvPaperCond.dicFldComparisonOp[convPaper.AskQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.AskQuestion, objvPaperCond.AskQuestion, strComparisonOpAskQuestion);
}
if (objvPaperCond.IsUpdated(convPaper.ResearchStatus) == true)
{
string strComparisonOpResearchStatus = objvPaperCond.dicFldComparisonOp[convPaper.ResearchStatus];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.ResearchStatus, objvPaperCond.ResearchStatus, strComparisonOpResearchStatus);
}
if (objvPaperCond.IsUpdated(convPaper.InnovationPoints) == true)
{
string strComparisonOpInnovationPoints = objvPaperCond.dicFldComparisonOp[convPaper.InnovationPoints];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.InnovationPoints, objvPaperCond.InnovationPoints, strComparisonOpInnovationPoints);
}
if (objvPaperCond.IsUpdated(convPaper.ResearchDesign) == true)
{
string strComparisonOpResearchDesign = objvPaperCond.dicFldComparisonOp[convPaper.ResearchDesign];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.ResearchDesign, objvPaperCond.ResearchDesign, strComparisonOpResearchDesign);
}
if (objvPaperCond.IsUpdated(convPaper.DimensionDataProcess) == true)
{
string strComparisonOpDimensionDataProcess = objvPaperCond.dicFldComparisonOp[convPaper.DimensionDataProcess];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.DimensionDataProcess, objvPaperCond.DimensionDataProcess, strComparisonOpDimensionDataProcess);
}
if (objvPaperCond.IsUpdated(convPaper.ExpectedConclusion) == true)
{
string strComparisonOpExpectedConclusion = objvPaperCond.dicFldComparisonOp[convPaper.ExpectedConclusion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.ExpectedConclusion, objvPaperCond.ExpectedConclusion, strComparisonOpExpectedConclusion);
}
if (objvPaperCond.IsUpdated(convPaper.ShareId) == true)
{
string strComparisonOpShareId = objvPaperCond.dicFldComparisonOp[convPaper.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.ShareId, objvPaperCond.ShareId, strComparisonOpShareId);
}
if (objvPaperCond.IsUpdated(convPaper.PaperQCount) == true)
{
string strComparisonOpPaperQCount = objvPaperCond.dicFldComparisonOp[convPaper.PaperQCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaper.PaperQCount, objvPaperCond.PaperQCount, strComparisonOpPaperQCount);
}
if (objvPaperCond.IsUpdated(convPaper.SubVCount) == true)
{
string strComparisonOpSubVCount = objvPaperCond.dicFldComparisonOp[convPaper.SubVCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaper.SubVCount, objvPaperCond.SubVCount, strComparisonOpSubVCount);
}
if (objvPaperCond.IsUpdated(convPaper.TagsCount) == true)
{
string strComparisonOpTagsCount = objvPaperCond.dicFldComparisonOp[convPaper.TagsCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaper.TagsCount, objvPaperCond.TagsCount, strComparisonOpTagsCount);
}
if (objvPaperCond.IsUpdated(convPaper.TeaQCount) == true)
{
string strComparisonOpTeaQCount = objvPaperCond.dicFldComparisonOp[convPaper.TeaQCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaper.TeaQCount, objvPaperCond.TeaQCount, strComparisonOpTeaQCount);
}
if (objvPaperCond.IsUpdated(convPaper.CreateDate) == true)
{
string strComparisonOpCreateDate = objvPaperCond.dicFldComparisonOp[convPaper.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.CreateDate, objvPaperCond.CreateDate, strComparisonOpCreateDate);
}
if (objvPaperCond.IsUpdated(convPaper.UpdUser) == true)
{
string strComparisonOpUpdUser = objvPaperCond.dicFldComparisonOp[convPaper.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.UpdUser, objvPaperCond.UpdUser, strComparisonOpUpdUser);
}
if (objvPaperCond.IsUpdated(convPaper.UserName) == true)
{
string strComparisonOpUserName = objvPaperCond.dicFldComparisonOp[convPaper.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.UserName, objvPaperCond.UserName, strComparisonOpUserName);
}
if (objvPaperCond.IsUpdated(convPaper.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvPaperCond.dicFldComparisonOp[convPaper.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.IdXzCollege, objvPaperCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvPaperCond.IsUpdated(convPaper.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPaperCond.dicFldComparisonOp[convPaper.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.UpdDate, objvPaperCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPaperCond.IsUpdated(convPaper.Memo) == true)
{
string strComparisonOpMemo = objvPaperCond.dicFldComparisonOp[convPaper.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaper.Memo, objvPaperCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPaper
{
public virtual bool UpdRelaTabDate(string strPaperId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v论文表(vPaper)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPaperBL
{
public static RelatedActions_vPaper relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPaperDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPaperDA vPaperDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPaperDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPaperBL()
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
if (string.IsNullOrEmpty(clsvPaperEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPaperEN._ConnectString);
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
public static DataTable GetDataTable_vPaper(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPaperDA.GetDataTable_vPaper(strWhereCond);
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
objDT = vPaperDA.GetDataTable(strWhereCond);
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
objDT = vPaperDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPaperDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPaperDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPaperDA.GetDataTable_Top(objTopPara);
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
objDT = vPaperDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPaperDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPaperDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPaperEN> GetObjLstByPaperIdLst(List<string> arrPaperIdLst)
{
List<clsvPaperEN> arrObjLst = new List<clsvPaperEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPaperIdLst, true);
 string strWhereCond = string.Format("PaperId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperEN objvPaperEN = new clsvPaperEN();
try
{
objvPaperEN.PaperId = objRow[convPaper.PaperId].ToString().Trim(); //论文Id
objvPaperEN.PaperTitle = objRow[convPaper.PaperTitle].ToString().Trim(); //论文标题
objvPaperEN.PaperContent = objRow[convPaper.PaperContent] == DBNull.Value ? null : objRow[convPaper.PaperContent].ToString().Trim(); //主题内容
objvPaperEN.Periodical = objRow[convPaper.Periodical] == DBNull.Value ? null : objRow[convPaper.Periodical].ToString().Trim(); //期刊
objvPaperEN.Author = objRow[convPaper.Author] == DBNull.Value ? null : objRow[convPaper.Author].ToString().Trim(); //作者
objvPaperEN.ResearchQuestion = objRow[convPaper.ResearchQuestion] == DBNull.Value ? null : objRow[convPaper.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperEN.Keyword = objRow[convPaper.Keyword] == DBNull.Value ? null : objRow[convPaper.Keyword].ToString().Trim(); //关键字
objvPaperEN.LiteratureSources = objRow[convPaper.LiteratureSources] == DBNull.Value ? null : objRow[convPaper.LiteratureSources].ToString().Trim(); //文献来源
objvPaperEN.LiteratureLink = objRow[convPaper.LiteratureLink] == DBNull.Value ? null : objRow[convPaper.LiteratureLink].ToString().Trim(); //文献链接
objvPaperEN.UploadfileUrl = objRow[convPaper.UploadfileUrl] == DBNull.Value ? null : objRow[convPaper.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperEN.QuoteId = objRow[convPaper.QuoteId] == DBNull.Value ? null : objRow[convPaper.QuoteId].ToString().Trim(); //引用Id
objvPaperEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsChecked].ToString().Trim()); //是否检查
objvPaperEN.Checker = objRow[convPaper.Checker] == DBNull.Value ? null : objRow[convPaper.Checker].ToString().Trim(); //审核人
objvPaperEN.LiteratureTypeId = objRow[convPaper.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperEN.LiteratureTypeName = objRow[convPaper.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaper.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperEN.BrowseNumber = objRow[convPaper.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.BrowseNumber].ToString().Trim()); //浏览量
objvPaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsSubmit].ToString().Trim()); //是否提交
objvPaperEN.AppraiseCount = objRow[convPaper.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.AppraiseCount].ToString().Trim()); //评论数
objvPaperEN.AttachmentCount = objRow[convPaper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.AttachmentCount].ToString().Trim()); //附件计数
objvPaperEN.CollectionCount = objRow[convPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.CollectionCount].ToString().Trim()); //收藏数量
objvPaperEN.DownloadCount = objRow[convPaper.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.DownloadCount].ToString().Trim()); //下载数
objvPaperEN.OkCount = objRow[convPaper.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.OkCount].ToString().Trim()); //点赞统计
objvPaperEN.Pcount = objRow[convPaper.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.Pcount].ToString().Trim()); //读写数
objvPaperEN.Score = objRow[convPaper.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.Score].ToString().Trim()); //评分
objvPaperEN.StuScore = objRow[convPaper.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.StuScore].ToString().Trim()); //学生平均分
objvPaperEN.TeaScore = objRow[convPaper.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.TeaScore].ToString().Trim()); //教师评分
objvPaperEN.PaperTypeId = objRow[convPaper.PaperTypeId] == DBNull.Value ? null : objRow[convPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objvPaperEN.PaperTypeName = objRow[convPaper.PaperTypeName] == DBNull.Value ? null : objRow[convPaper.PaperTypeName].ToString().Trim(); //论文类型名
objvPaperEN.PaperStatusId = objRow[convPaper.PaperStatusId] == DBNull.Value ? null : objRow[convPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objvPaperEN.PaperStatusName = objRow[convPaper.PaperStatusName] == DBNull.Value ? null : objRow[convPaper.PaperStatusName].ToString().Trim(); //论文状态名
objvPaperEN.VersionCount = objRow[convPaper.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.VersionCount].ToString().Trim()); //版本统计
objvPaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsPublic].ToString().Trim()); //是否公开
objvPaperEN.AskQuestion = objRow[convPaper.AskQuestion] == DBNull.Value ? null : objRow[convPaper.AskQuestion].ToString().Trim(); //问题提出
objvPaperEN.ResearchStatus = objRow[convPaper.ResearchStatus] == DBNull.Value ? null : objRow[convPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objvPaperEN.InnovationPoints = objRow[convPaper.InnovationPoints] == DBNull.Value ? null : objRow[convPaper.InnovationPoints].ToString().Trim(); //创新点
objvPaperEN.ResearchDesign = objRow[convPaper.ResearchDesign] == DBNull.Value ? null : objRow[convPaper.ResearchDesign].ToString().Trim(); //研究设计
objvPaperEN.DimensionDataProcess = objRow[convPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[convPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvPaperEN.ExpectedConclusion = objRow[convPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[convPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objvPaperEN.ShareId = objRow[convPaper.ShareId] == DBNull.Value ? null : objRow[convPaper.ShareId].ToString().Trim(); //分享Id
objvPaperEN.PaperQCount = objRow[convPaper.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperEN.SubVCount = objRow[convPaper.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.SubVCount].ToString().Trim()); //论文子观点数
objvPaperEN.TagsCount = objRow[convPaper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.TagsCount].ToString().Trim()); //论文标注数
objvPaperEN.TeaQCount = objRow[convPaper.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.TeaQCount].ToString().Trim()); //教师提问数
objvPaperEN.CreateDate = objRow[convPaper.CreateDate] == DBNull.Value ? null : objRow[convPaper.CreateDate].ToString().Trim(); //建立日期
objvPaperEN.UpdUser = objRow[convPaper.UpdUser] == DBNull.Value ? null : objRow[convPaper.UpdUser].ToString().Trim(); //修改人
objvPaperEN.UserName = objRow[convPaper.UserName] == DBNull.Value ? null : objRow[convPaper.UserName].ToString().Trim(); //用户名
objvPaperEN.IdXzCollege = objRow[convPaper.IdXzCollege] == DBNull.Value ? null : objRow[convPaper.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperEN.UpdDate = objRow[convPaper.UpdDate] == DBNull.Value ? null : objRow[convPaper.UpdDate].ToString().Trim(); //修改日期
objvPaperEN.Memo = objRow[convPaper.Memo] == DBNull.Value ? null : objRow[convPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPaperEN> GetObjLstByPaperIdLstCache(List<string> arrPaperIdLst)
{
string strKey = string.Format("{0}", clsvPaperEN._CurrTabName);
List<clsvPaperEN> arrvPaperObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperEN> arrvPaperObjLst_Sel =
arrvPaperObjLstCache
.Where(x => arrPaperIdLst.Contains(x.PaperId));
return arrvPaperObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperEN> GetObjLst(string strWhereCond)
{
List<clsvPaperEN> arrObjLst = new List<clsvPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperEN objvPaperEN = new clsvPaperEN();
try
{
objvPaperEN.PaperId = objRow[convPaper.PaperId].ToString().Trim(); //论文Id
objvPaperEN.PaperTitle = objRow[convPaper.PaperTitle].ToString().Trim(); //论文标题
objvPaperEN.PaperContent = objRow[convPaper.PaperContent] == DBNull.Value ? null : objRow[convPaper.PaperContent].ToString().Trim(); //主题内容
objvPaperEN.Periodical = objRow[convPaper.Periodical] == DBNull.Value ? null : objRow[convPaper.Periodical].ToString().Trim(); //期刊
objvPaperEN.Author = objRow[convPaper.Author] == DBNull.Value ? null : objRow[convPaper.Author].ToString().Trim(); //作者
objvPaperEN.ResearchQuestion = objRow[convPaper.ResearchQuestion] == DBNull.Value ? null : objRow[convPaper.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperEN.Keyword = objRow[convPaper.Keyword] == DBNull.Value ? null : objRow[convPaper.Keyword].ToString().Trim(); //关键字
objvPaperEN.LiteratureSources = objRow[convPaper.LiteratureSources] == DBNull.Value ? null : objRow[convPaper.LiteratureSources].ToString().Trim(); //文献来源
objvPaperEN.LiteratureLink = objRow[convPaper.LiteratureLink] == DBNull.Value ? null : objRow[convPaper.LiteratureLink].ToString().Trim(); //文献链接
objvPaperEN.UploadfileUrl = objRow[convPaper.UploadfileUrl] == DBNull.Value ? null : objRow[convPaper.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperEN.QuoteId = objRow[convPaper.QuoteId] == DBNull.Value ? null : objRow[convPaper.QuoteId].ToString().Trim(); //引用Id
objvPaperEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsChecked].ToString().Trim()); //是否检查
objvPaperEN.Checker = objRow[convPaper.Checker] == DBNull.Value ? null : objRow[convPaper.Checker].ToString().Trim(); //审核人
objvPaperEN.LiteratureTypeId = objRow[convPaper.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperEN.LiteratureTypeName = objRow[convPaper.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaper.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperEN.BrowseNumber = objRow[convPaper.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.BrowseNumber].ToString().Trim()); //浏览量
objvPaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsSubmit].ToString().Trim()); //是否提交
objvPaperEN.AppraiseCount = objRow[convPaper.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.AppraiseCount].ToString().Trim()); //评论数
objvPaperEN.AttachmentCount = objRow[convPaper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.AttachmentCount].ToString().Trim()); //附件计数
objvPaperEN.CollectionCount = objRow[convPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.CollectionCount].ToString().Trim()); //收藏数量
objvPaperEN.DownloadCount = objRow[convPaper.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.DownloadCount].ToString().Trim()); //下载数
objvPaperEN.OkCount = objRow[convPaper.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.OkCount].ToString().Trim()); //点赞统计
objvPaperEN.Pcount = objRow[convPaper.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.Pcount].ToString().Trim()); //读写数
objvPaperEN.Score = objRow[convPaper.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.Score].ToString().Trim()); //评分
objvPaperEN.StuScore = objRow[convPaper.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.StuScore].ToString().Trim()); //学生平均分
objvPaperEN.TeaScore = objRow[convPaper.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.TeaScore].ToString().Trim()); //教师评分
objvPaperEN.PaperTypeId = objRow[convPaper.PaperTypeId] == DBNull.Value ? null : objRow[convPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objvPaperEN.PaperTypeName = objRow[convPaper.PaperTypeName] == DBNull.Value ? null : objRow[convPaper.PaperTypeName].ToString().Trim(); //论文类型名
objvPaperEN.PaperStatusId = objRow[convPaper.PaperStatusId] == DBNull.Value ? null : objRow[convPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objvPaperEN.PaperStatusName = objRow[convPaper.PaperStatusName] == DBNull.Value ? null : objRow[convPaper.PaperStatusName].ToString().Trim(); //论文状态名
objvPaperEN.VersionCount = objRow[convPaper.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.VersionCount].ToString().Trim()); //版本统计
objvPaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsPublic].ToString().Trim()); //是否公开
objvPaperEN.AskQuestion = objRow[convPaper.AskQuestion] == DBNull.Value ? null : objRow[convPaper.AskQuestion].ToString().Trim(); //问题提出
objvPaperEN.ResearchStatus = objRow[convPaper.ResearchStatus] == DBNull.Value ? null : objRow[convPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objvPaperEN.InnovationPoints = objRow[convPaper.InnovationPoints] == DBNull.Value ? null : objRow[convPaper.InnovationPoints].ToString().Trim(); //创新点
objvPaperEN.ResearchDesign = objRow[convPaper.ResearchDesign] == DBNull.Value ? null : objRow[convPaper.ResearchDesign].ToString().Trim(); //研究设计
objvPaperEN.DimensionDataProcess = objRow[convPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[convPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvPaperEN.ExpectedConclusion = objRow[convPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[convPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objvPaperEN.ShareId = objRow[convPaper.ShareId] == DBNull.Value ? null : objRow[convPaper.ShareId].ToString().Trim(); //分享Id
objvPaperEN.PaperQCount = objRow[convPaper.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperEN.SubVCount = objRow[convPaper.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.SubVCount].ToString().Trim()); //论文子观点数
objvPaperEN.TagsCount = objRow[convPaper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.TagsCount].ToString().Trim()); //论文标注数
objvPaperEN.TeaQCount = objRow[convPaper.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.TeaQCount].ToString().Trim()); //教师提问数
objvPaperEN.CreateDate = objRow[convPaper.CreateDate] == DBNull.Value ? null : objRow[convPaper.CreateDate].ToString().Trim(); //建立日期
objvPaperEN.UpdUser = objRow[convPaper.UpdUser] == DBNull.Value ? null : objRow[convPaper.UpdUser].ToString().Trim(); //修改人
objvPaperEN.UserName = objRow[convPaper.UserName] == DBNull.Value ? null : objRow[convPaper.UserName].ToString().Trim(); //用户名
objvPaperEN.IdXzCollege = objRow[convPaper.IdXzCollege] == DBNull.Value ? null : objRow[convPaper.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperEN.UpdDate = objRow[convPaper.UpdDate] == DBNull.Value ? null : objRow[convPaper.UpdDate].ToString().Trim(); //修改日期
objvPaperEN.Memo = objRow[convPaper.Memo] == DBNull.Value ? null : objRow[convPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperEN);
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
public static List<clsvPaperEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPaperEN> arrObjLst = new List<clsvPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperEN objvPaperEN = new clsvPaperEN();
try
{
objvPaperEN.PaperId = objRow[convPaper.PaperId].ToString().Trim(); //论文Id
objvPaperEN.PaperTitle = objRow[convPaper.PaperTitle].ToString().Trim(); //论文标题
objvPaperEN.PaperContent = objRow[convPaper.PaperContent] == DBNull.Value ? null : objRow[convPaper.PaperContent].ToString().Trim(); //主题内容
objvPaperEN.Periodical = objRow[convPaper.Periodical] == DBNull.Value ? null : objRow[convPaper.Periodical].ToString().Trim(); //期刊
objvPaperEN.Author = objRow[convPaper.Author] == DBNull.Value ? null : objRow[convPaper.Author].ToString().Trim(); //作者
objvPaperEN.ResearchQuestion = objRow[convPaper.ResearchQuestion] == DBNull.Value ? null : objRow[convPaper.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperEN.Keyword = objRow[convPaper.Keyword] == DBNull.Value ? null : objRow[convPaper.Keyword].ToString().Trim(); //关键字
objvPaperEN.LiteratureSources = objRow[convPaper.LiteratureSources] == DBNull.Value ? null : objRow[convPaper.LiteratureSources].ToString().Trim(); //文献来源
objvPaperEN.LiteratureLink = objRow[convPaper.LiteratureLink] == DBNull.Value ? null : objRow[convPaper.LiteratureLink].ToString().Trim(); //文献链接
objvPaperEN.UploadfileUrl = objRow[convPaper.UploadfileUrl] == DBNull.Value ? null : objRow[convPaper.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperEN.QuoteId = objRow[convPaper.QuoteId] == DBNull.Value ? null : objRow[convPaper.QuoteId].ToString().Trim(); //引用Id
objvPaperEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsChecked].ToString().Trim()); //是否检查
objvPaperEN.Checker = objRow[convPaper.Checker] == DBNull.Value ? null : objRow[convPaper.Checker].ToString().Trim(); //审核人
objvPaperEN.LiteratureTypeId = objRow[convPaper.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperEN.LiteratureTypeName = objRow[convPaper.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaper.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperEN.BrowseNumber = objRow[convPaper.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.BrowseNumber].ToString().Trim()); //浏览量
objvPaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsSubmit].ToString().Trim()); //是否提交
objvPaperEN.AppraiseCount = objRow[convPaper.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.AppraiseCount].ToString().Trim()); //评论数
objvPaperEN.AttachmentCount = objRow[convPaper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.AttachmentCount].ToString().Trim()); //附件计数
objvPaperEN.CollectionCount = objRow[convPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.CollectionCount].ToString().Trim()); //收藏数量
objvPaperEN.DownloadCount = objRow[convPaper.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.DownloadCount].ToString().Trim()); //下载数
objvPaperEN.OkCount = objRow[convPaper.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.OkCount].ToString().Trim()); //点赞统计
objvPaperEN.Pcount = objRow[convPaper.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.Pcount].ToString().Trim()); //读写数
objvPaperEN.Score = objRow[convPaper.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.Score].ToString().Trim()); //评分
objvPaperEN.StuScore = objRow[convPaper.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.StuScore].ToString().Trim()); //学生平均分
objvPaperEN.TeaScore = objRow[convPaper.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.TeaScore].ToString().Trim()); //教师评分
objvPaperEN.PaperTypeId = objRow[convPaper.PaperTypeId] == DBNull.Value ? null : objRow[convPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objvPaperEN.PaperTypeName = objRow[convPaper.PaperTypeName] == DBNull.Value ? null : objRow[convPaper.PaperTypeName].ToString().Trim(); //论文类型名
objvPaperEN.PaperStatusId = objRow[convPaper.PaperStatusId] == DBNull.Value ? null : objRow[convPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objvPaperEN.PaperStatusName = objRow[convPaper.PaperStatusName] == DBNull.Value ? null : objRow[convPaper.PaperStatusName].ToString().Trim(); //论文状态名
objvPaperEN.VersionCount = objRow[convPaper.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.VersionCount].ToString().Trim()); //版本统计
objvPaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsPublic].ToString().Trim()); //是否公开
objvPaperEN.AskQuestion = objRow[convPaper.AskQuestion] == DBNull.Value ? null : objRow[convPaper.AskQuestion].ToString().Trim(); //问题提出
objvPaperEN.ResearchStatus = objRow[convPaper.ResearchStatus] == DBNull.Value ? null : objRow[convPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objvPaperEN.InnovationPoints = objRow[convPaper.InnovationPoints] == DBNull.Value ? null : objRow[convPaper.InnovationPoints].ToString().Trim(); //创新点
objvPaperEN.ResearchDesign = objRow[convPaper.ResearchDesign] == DBNull.Value ? null : objRow[convPaper.ResearchDesign].ToString().Trim(); //研究设计
objvPaperEN.DimensionDataProcess = objRow[convPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[convPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvPaperEN.ExpectedConclusion = objRow[convPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[convPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objvPaperEN.ShareId = objRow[convPaper.ShareId] == DBNull.Value ? null : objRow[convPaper.ShareId].ToString().Trim(); //分享Id
objvPaperEN.PaperQCount = objRow[convPaper.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperEN.SubVCount = objRow[convPaper.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.SubVCount].ToString().Trim()); //论文子观点数
objvPaperEN.TagsCount = objRow[convPaper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.TagsCount].ToString().Trim()); //论文标注数
objvPaperEN.TeaQCount = objRow[convPaper.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.TeaQCount].ToString().Trim()); //教师提问数
objvPaperEN.CreateDate = objRow[convPaper.CreateDate] == DBNull.Value ? null : objRow[convPaper.CreateDate].ToString().Trim(); //建立日期
objvPaperEN.UpdUser = objRow[convPaper.UpdUser] == DBNull.Value ? null : objRow[convPaper.UpdUser].ToString().Trim(); //修改人
objvPaperEN.UserName = objRow[convPaper.UserName] == DBNull.Value ? null : objRow[convPaper.UserName].ToString().Trim(); //用户名
objvPaperEN.IdXzCollege = objRow[convPaper.IdXzCollege] == DBNull.Value ? null : objRow[convPaper.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperEN.UpdDate = objRow[convPaper.UpdDate] == DBNull.Value ? null : objRow[convPaper.UpdDate].ToString().Trim(); //修改日期
objvPaperEN.Memo = objRow[convPaper.Memo] == DBNull.Value ? null : objRow[convPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPaperCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPaperEN> GetSubObjLstCache(clsvPaperEN objvPaperCond)
{
List<clsvPaperEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaper.AttributeName)
{
if (objvPaperCond.IsUpdated(strFldName) == false) continue;
if (objvPaperCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperCond[strFldName].ToString());
}
else
{
if (objvPaperCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperCond[strFldName]));
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
public static List<clsvPaperEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPaperEN> arrObjLst = new List<clsvPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperEN objvPaperEN = new clsvPaperEN();
try
{
objvPaperEN.PaperId = objRow[convPaper.PaperId].ToString().Trim(); //论文Id
objvPaperEN.PaperTitle = objRow[convPaper.PaperTitle].ToString().Trim(); //论文标题
objvPaperEN.PaperContent = objRow[convPaper.PaperContent] == DBNull.Value ? null : objRow[convPaper.PaperContent].ToString().Trim(); //主题内容
objvPaperEN.Periodical = objRow[convPaper.Periodical] == DBNull.Value ? null : objRow[convPaper.Periodical].ToString().Trim(); //期刊
objvPaperEN.Author = objRow[convPaper.Author] == DBNull.Value ? null : objRow[convPaper.Author].ToString().Trim(); //作者
objvPaperEN.ResearchQuestion = objRow[convPaper.ResearchQuestion] == DBNull.Value ? null : objRow[convPaper.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperEN.Keyword = objRow[convPaper.Keyword] == DBNull.Value ? null : objRow[convPaper.Keyword].ToString().Trim(); //关键字
objvPaperEN.LiteratureSources = objRow[convPaper.LiteratureSources] == DBNull.Value ? null : objRow[convPaper.LiteratureSources].ToString().Trim(); //文献来源
objvPaperEN.LiteratureLink = objRow[convPaper.LiteratureLink] == DBNull.Value ? null : objRow[convPaper.LiteratureLink].ToString().Trim(); //文献链接
objvPaperEN.UploadfileUrl = objRow[convPaper.UploadfileUrl] == DBNull.Value ? null : objRow[convPaper.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperEN.QuoteId = objRow[convPaper.QuoteId] == DBNull.Value ? null : objRow[convPaper.QuoteId].ToString().Trim(); //引用Id
objvPaperEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsChecked].ToString().Trim()); //是否检查
objvPaperEN.Checker = objRow[convPaper.Checker] == DBNull.Value ? null : objRow[convPaper.Checker].ToString().Trim(); //审核人
objvPaperEN.LiteratureTypeId = objRow[convPaper.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperEN.LiteratureTypeName = objRow[convPaper.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaper.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperEN.BrowseNumber = objRow[convPaper.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.BrowseNumber].ToString().Trim()); //浏览量
objvPaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsSubmit].ToString().Trim()); //是否提交
objvPaperEN.AppraiseCount = objRow[convPaper.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.AppraiseCount].ToString().Trim()); //评论数
objvPaperEN.AttachmentCount = objRow[convPaper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.AttachmentCount].ToString().Trim()); //附件计数
objvPaperEN.CollectionCount = objRow[convPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.CollectionCount].ToString().Trim()); //收藏数量
objvPaperEN.DownloadCount = objRow[convPaper.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.DownloadCount].ToString().Trim()); //下载数
objvPaperEN.OkCount = objRow[convPaper.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.OkCount].ToString().Trim()); //点赞统计
objvPaperEN.Pcount = objRow[convPaper.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.Pcount].ToString().Trim()); //读写数
objvPaperEN.Score = objRow[convPaper.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.Score].ToString().Trim()); //评分
objvPaperEN.StuScore = objRow[convPaper.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.StuScore].ToString().Trim()); //学生平均分
objvPaperEN.TeaScore = objRow[convPaper.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.TeaScore].ToString().Trim()); //教师评分
objvPaperEN.PaperTypeId = objRow[convPaper.PaperTypeId] == DBNull.Value ? null : objRow[convPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objvPaperEN.PaperTypeName = objRow[convPaper.PaperTypeName] == DBNull.Value ? null : objRow[convPaper.PaperTypeName].ToString().Trim(); //论文类型名
objvPaperEN.PaperStatusId = objRow[convPaper.PaperStatusId] == DBNull.Value ? null : objRow[convPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objvPaperEN.PaperStatusName = objRow[convPaper.PaperStatusName] == DBNull.Value ? null : objRow[convPaper.PaperStatusName].ToString().Trim(); //论文状态名
objvPaperEN.VersionCount = objRow[convPaper.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.VersionCount].ToString().Trim()); //版本统计
objvPaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsPublic].ToString().Trim()); //是否公开
objvPaperEN.AskQuestion = objRow[convPaper.AskQuestion] == DBNull.Value ? null : objRow[convPaper.AskQuestion].ToString().Trim(); //问题提出
objvPaperEN.ResearchStatus = objRow[convPaper.ResearchStatus] == DBNull.Value ? null : objRow[convPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objvPaperEN.InnovationPoints = objRow[convPaper.InnovationPoints] == DBNull.Value ? null : objRow[convPaper.InnovationPoints].ToString().Trim(); //创新点
objvPaperEN.ResearchDesign = objRow[convPaper.ResearchDesign] == DBNull.Value ? null : objRow[convPaper.ResearchDesign].ToString().Trim(); //研究设计
objvPaperEN.DimensionDataProcess = objRow[convPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[convPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvPaperEN.ExpectedConclusion = objRow[convPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[convPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objvPaperEN.ShareId = objRow[convPaper.ShareId] == DBNull.Value ? null : objRow[convPaper.ShareId].ToString().Trim(); //分享Id
objvPaperEN.PaperQCount = objRow[convPaper.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperEN.SubVCount = objRow[convPaper.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.SubVCount].ToString().Trim()); //论文子观点数
objvPaperEN.TagsCount = objRow[convPaper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.TagsCount].ToString().Trim()); //论文标注数
objvPaperEN.TeaQCount = objRow[convPaper.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.TeaQCount].ToString().Trim()); //教师提问数
objvPaperEN.CreateDate = objRow[convPaper.CreateDate] == DBNull.Value ? null : objRow[convPaper.CreateDate].ToString().Trim(); //建立日期
objvPaperEN.UpdUser = objRow[convPaper.UpdUser] == DBNull.Value ? null : objRow[convPaper.UpdUser].ToString().Trim(); //修改人
objvPaperEN.UserName = objRow[convPaper.UserName] == DBNull.Value ? null : objRow[convPaper.UserName].ToString().Trim(); //用户名
objvPaperEN.IdXzCollege = objRow[convPaper.IdXzCollege] == DBNull.Value ? null : objRow[convPaper.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperEN.UpdDate = objRow[convPaper.UpdDate] == DBNull.Value ? null : objRow[convPaper.UpdDate].ToString().Trim(); //修改日期
objvPaperEN.Memo = objRow[convPaper.Memo] == DBNull.Value ? null : objRow[convPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperEN);
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
public static List<clsvPaperEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPaperEN> arrObjLst = new List<clsvPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperEN objvPaperEN = new clsvPaperEN();
try
{
objvPaperEN.PaperId = objRow[convPaper.PaperId].ToString().Trim(); //论文Id
objvPaperEN.PaperTitle = objRow[convPaper.PaperTitle].ToString().Trim(); //论文标题
objvPaperEN.PaperContent = objRow[convPaper.PaperContent] == DBNull.Value ? null : objRow[convPaper.PaperContent].ToString().Trim(); //主题内容
objvPaperEN.Periodical = objRow[convPaper.Periodical] == DBNull.Value ? null : objRow[convPaper.Periodical].ToString().Trim(); //期刊
objvPaperEN.Author = objRow[convPaper.Author] == DBNull.Value ? null : objRow[convPaper.Author].ToString().Trim(); //作者
objvPaperEN.ResearchQuestion = objRow[convPaper.ResearchQuestion] == DBNull.Value ? null : objRow[convPaper.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperEN.Keyword = objRow[convPaper.Keyword] == DBNull.Value ? null : objRow[convPaper.Keyword].ToString().Trim(); //关键字
objvPaperEN.LiteratureSources = objRow[convPaper.LiteratureSources] == DBNull.Value ? null : objRow[convPaper.LiteratureSources].ToString().Trim(); //文献来源
objvPaperEN.LiteratureLink = objRow[convPaper.LiteratureLink] == DBNull.Value ? null : objRow[convPaper.LiteratureLink].ToString().Trim(); //文献链接
objvPaperEN.UploadfileUrl = objRow[convPaper.UploadfileUrl] == DBNull.Value ? null : objRow[convPaper.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperEN.QuoteId = objRow[convPaper.QuoteId] == DBNull.Value ? null : objRow[convPaper.QuoteId].ToString().Trim(); //引用Id
objvPaperEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsChecked].ToString().Trim()); //是否检查
objvPaperEN.Checker = objRow[convPaper.Checker] == DBNull.Value ? null : objRow[convPaper.Checker].ToString().Trim(); //审核人
objvPaperEN.LiteratureTypeId = objRow[convPaper.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperEN.LiteratureTypeName = objRow[convPaper.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaper.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperEN.BrowseNumber = objRow[convPaper.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.BrowseNumber].ToString().Trim()); //浏览量
objvPaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsSubmit].ToString().Trim()); //是否提交
objvPaperEN.AppraiseCount = objRow[convPaper.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.AppraiseCount].ToString().Trim()); //评论数
objvPaperEN.AttachmentCount = objRow[convPaper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.AttachmentCount].ToString().Trim()); //附件计数
objvPaperEN.CollectionCount = objRow[convPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.CollectionCount].ToString().Trim()); //收藏数量
objvPaperEN.DownloadCount = objRow[convPaper.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.DownloadCount].ToString().Trim()); //下载数
objvPaperEN.OkCount = objRow[convPaper.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.OkCount].ToString().Trim()); //点赞统计
objvPaperEN.Pcount = objRow[convPaper.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.Pcount].ToString().Trim()); //读写数
objvPaperEN.Score = objRow[convPaper.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.Score].ToString().Trim()); //评分
objvPaperEN.StuScore = objRow[convPaper.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.StuScore].ToString().Trim()); //学生平均分
objvPaperEN.TeaScore = objRow[convPaper.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.TeaScore].ToString().Trim()); //教师评分
objvPaperEN.PaperTypeId = objRow[convPaper.PaperTypeId] == DBNull.Value ? null : objRow[convPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objvPaperEN.PaperTypeName = objRow[convPaper.PaperTypeName] == DBNull.Value ? null : objRow[convPaper.PaperTypeName].ToString().Trim(); //论文类型名
objvPaperEN.PaperStatusId = objRow[convPaper.PaperStatusId] == DBNull.Value ? null : objRow[convPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objvPaperEN.PaperStatusName = objRow[convPaper.PaperStatusName] == DBNull.Value ? null : objRow[convPaper.PaperStatusName].ToString().Trim(); //论文状态名
objvPaperEN.VersionCount = objRow[convPaper.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.VersionCount].ToString().Trim()); //版本统计
objvPaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsPublic].ToString().Trim()); //是否公开
objvPaperEN.AskQuestion = objRow[convPaper.AskQuestion] == DBNull.Value ? null : objRow[convPaper.AskQuestion].ToString().Trim(); //问题提出
objvPaperEN.ResearchStatus = objRow[convPaper.ResearchStatus] == DBNull.Value ? null : objRow[convPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objvPaperEN.InnovationPoints = objRow[convPaper.InnovationPoints] == DBNull.Value ? null : objRow[convPaper.InnovationPoints].ToString().Trim(); //创新点
objvPaperEN.ResearchDesign = objRow[convPaper.ResearchDesign] == DBNull.Value ? null : objRow[convPaper.ResearchDesign].ToString().Trim(); //研究设计
objvPaperEN.DimensionDataProcess = objRow[convPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[convPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvPaperEN.ExpectedConclusion = objRow[convPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[convPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objvPaperEN.ShareId = objRow[convPaper.ShareId] == DBNull.Value ? null : objRow[convPaper.ShareId].ToString().Trim(); //分享Id
objvPaperEN.PaperQCount = objRow[convPaper.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperEN.SubVCount = objRow[convPaper.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.SubVCount].ToString().Trim()); //论文子观点数
objvPaperEN.TagsCount = objRow[convPaper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.TagsCount].ToString().Trim()); //论文标注数
objvPaperEN.TeaQCount = objRow[convPaper.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.TeaQCount].ToString().Trim()); //教师提问数
objvPaperEN.CreateDate = objRow[convPaper.CreateDate] == DBNull.Value ? null : objRow[convPaper.CreateDate].ToString().Trim(); //建立日期
objvPaperEN.UpdUser = objRow[convPaper.UpdUser] == DBNull.Value ? null : objRow[convPaper.UpdUser].ToString().Trim(); //修改人
objvPaperEN.UserName = objRow[convPaper.UserName] == DBNull.Value ? null : objRow[convPaper.UserName].ToString().Trim(); //用户名
objvPaperEN.IdXzCollege = objRow[convPaper.IdXzCollege] == DBNull.Value ? null : objRow[convPaper.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperEN.UpdDate = objRow[convPaper.UpdDate] == DBNull.Value ? null : objRow[convPaper.UpdDate].ToString().Trim(); //修改日期
objvPaperEN.Memo = objRow[convPaper.Memo] == DBNull.Value ? null : objRow[convPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperEN);
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
List<clsvPaperEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPaperEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPaperEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperEN> arrObjLst = new List<clsvPaperEN>(); 
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
	clsvPaperEN objvPaperEN = new clsvPaperEN();
try
{
objvPaperEN.PaperId = objRow[convPaper.PaperId].ToString().Trim(); //论文Id
objvPaperEN.PaperTitle = objRow[convPaper.PaperTitle].ToString().Trim(); //论文标题
objvPaperEN.PaperContent = objRow[convPaper.PaperContent] == DBNull.Value ? null : objRow[convPaper.PaperContent].ToString().Trim(); //主题内容
objvPaperEN.Periodical = objRow[convPaper.Periodical] == DBNull.Value ? null : objRow[convPaper.Periodical].ToString().Trim(); //期刊
objvPaperEN.Author = objRow[convPaper.Author] == DBNull.Value ? null : objRow[convPaper.Author].ToString().Trim(); //作者
objvPaperEN.ResearchQuestion = objRow[convPaper.ResearchQuestion] == DBNull.Value ? null : objRow[convPaper.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperEN.Keyword = objRow[convPaper.Keyword] == DBNull.Value ? null : objRow[convPaper.Keyword].ToString().Trim(); //关键字
objvPaperEN.LiteratureSources = objRow[convPaper.LiteratureSources] == DBNull.Value ? null : objRow[convPaper.LiteratureSources].ToString().Trim(); //文献来源
objvPaperEN.LiteratureLink = objRow[convPaper.LiteratureLink] == DBNull.Value ? null : objRow[convPaper.LiteratureLink].ToString().Trim(); //文献链接
objvPaperEN.UploadfileUrl = objRow[convPaper.UploadfileUrl] == DBNull.Value ? null : objRow[convPaper.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperEN.QuoteId = objRow[convPaper.QuoteId] == DBNull.Value ? null : objRow[convPaper.QuoteId].ToString().Trim(); //引用Id
objvPaperEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsChecked].ToString().Trim()); //是否检查
objvPaperEN.Checker = objRow[convPaper.Checker] == DBNull.Value ? null : objRow[convPaper.Checker].ToString().Trim(); //审核人
objvPaperEN.LiteratureTypeId = objRow[convPaper.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperEN.LiteratureTypeName = objRow[convPaper.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaper.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperEN.BrowseNumber = objRow[convPaper.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.BrowseNumber].ToString().Trim()); //浏览量
objvPaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsSubmit].ToString().Trim()); //是否提交
objvPaperEN.AppraiseCount = objRow[convPaper.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.AppraiseCount].ToString().Trim()); //评论数
objvPaperEN.AttachmentCount = objRow[convPaper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.AttachmentCount].ToString().Trim()); //附件计数
objvPaperEN.CollectionCount = objRow[convPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.CollectionCount].ToString().Trim()); //收藏数量
objvPaperEN.DownloadCount = objRow[convPaper.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.DownloadCount].ToString().Trim()); //下载数
objvPaperEN.OkCount = objRow[convPaper.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.OkCount].ToString().Trim()); //点赞统计
objvPaperEN.Pcount = objRow[convPaper.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.Pcount].ToString().Trim()); //读写数
objvPaperEN.Score = objRow[convPaper.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.Score].ToString().Trim()); //评分
objvPaperEN.StuScore = objRow[convPaper.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.StuScore].ToString().Trim()); //学生平均分
objvPaperEN.TeaScore = objRow[convPaper.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.TeaScore].ToString().Trim()); //教师评分
objvPaperEN.PaperTypeId = objRow[convPaper.PaperTypeId] == DBNull.Value ? null : objRow[convPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objvPaperEN.PaperTypeName = objRow[convPaper.PaperTypeName] == DBNull.Value ? null : objRow[convPaper.PaperTypeName].ToString().Trim(); //论文类型名
objvPaperEN.PaperStatusId = objRow[convPaper.PaperStatusId] == DBNull.Value ? null : objRow[convPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objvPaperEN.PaperStatusName = objRow[convPaper.PaperStatusName] == DBNull.Value ? null : objRow[convPaper.PaperStatusName].ToString().Trim(); //论文状态名
objvPaperEN.VersionCount = objRow[convPaper.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.VersionCount].ToString().Trim()); //版本统计
objvPaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsPublic].ToString().Trim()); //是否公开
objvPaperEN.AskQuestion = objRow[convPaper.AskQuestion] == DBNull.Value ? null : objRow[convPaper.AskQuestion].ToString().Trim(); //问题提出
objvPaperEN.ResearchStatus = objRow[convPaper.ResearchStatus] == DBNull.Value ? null : objRow[convPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objvPaperEN.InnovationPoints = objRow[convPaper.InnovationPoints] == DBNull.Value ? null : objRow[convPaper.InnovationPoints].ToString().Trim(); //创新点
objvPaperEN.ResearchDesign = objRow[convPaper.ResearchDesign] == DBNull.Value ? null : objRow[convPaper.ResearchDesign].ToString().Trim(); //研究设计
objvPaperEN.DimensionDataProcess = objRow[convPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[convPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvPaperEN.ExpectedConclusion = objRow[convPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[convPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objvPaperEN.ShareId = objRow[convPaper.ShareId] == DBNull.Value ? null : objRow[convPaper.ShareId].ToString().Trim(); //分享Id
objvPaperEN.PaperQCount = objRow[convPaper.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperEN.SubVCount = objRow[convPaper.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.SubVCount].ToString().Trim()); //论文子观点数
objvPaperEN.TagsCount = objRow[convPaper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.TagsCount].ToString().Trim()); //论文标注数
objvPaperEN.TeaQCount = objRow[convPaper.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.TeaQCount].ToString().Trim()); //教师提问数
objvPaperEN.CreateDate = objRow[convPaper.CreateDate] == DBNull.Value ? null : objRow[convPaper.CreateDate].ToString().Trim(); //建立日期
objvPaperEN.UpdUser = objRow[convPaper.UpdUser] == DBNull.Value ? null : objRow[convPaper.UpdUser].ToString().Trim(); //修改人
objvPaperEN.UserName = objRow[convPaper.UserName] == DBNull.Value ? null : objRow[convPaper.UserName].ToString().Trim(); //用户名
objvPaperEN.IdXzCollege = objRow[convPaper.IdXzCollege] == DBNull.Value ? null : objRow[convPaper.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperEN.UpdDate = objRow[convPaper.UpdDate] == DBNull.Value ? null : objRow[convPaper.UpdDate].ToString().Trim(); //修改日期
objvPaperEN.Memo = objRow[convPaper.Memo] == DBNull.Value ? null : objRow[convPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperEN);
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
public static List<clsvPaperEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPaperEN> arrObjLst = new List<clsvPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperEN objvPaperEN = new clsvPaperEN();
try
{
objvPaperEN.PaperId = objRow[convPaper.PaperId].ToString().Trim(); //论文Id
objvPaperEN.PaperTitle = objRow[convPaper.PaperTitle].ToString().Trim(); //论文标题
objvPaperEN.PaperContent = objRow[convPaper.PaperContent] == DBNull.Value ? null : objRow[convPaper.PaperContent].ToString().Trim(); //主题内容
objvPaperEN.Periodical = objRow[convPaper.Periodical] == DBNull.Value ? null : objRow[convPaper.Periodical].ToString().Trim(); //期刊
objvPaperEN.Author = objRow[convPaper.Author] == DBNull.Value ? null : objRow[convPaper.Author].ToString().Trim(); //作者
objvPaperEN.ResearchQuestion = objRow[convPaper.ResearchQuestion] == DBNull.Value ? null : objRow[convPaper.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperEN.Keyword = objRow[convPaper.Keyword] == DBNull.Value ? null : objRow[convPaper.Keyword].ToString().Trim(); //关键字
objvPaperEN.LiteratureSources = objRow[convPaper.LiteratureSources] == DBNull.Value ? null : objRow[convPaper.LiteratureSources].ToString().Trim(); //文献来源
objvPaperEN.LiteratureLink = objRow[convPaper.LiteratureLink] == DBNull.Value ? null : objRow[convPaper.LiteratureLink].ToString().Trim(); //文献链接
objvPaperEN.UploadfileUrl = objRow[convPaper.UploadfileUrl] == DBNull.Value ? null : objRow[convPaper.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperEN.QuoteId = objRow[convPaper.QuoteId] == DBNull.Value ? null : objRow[convPaper.QuoteId].ToString().Trim(); //引用Id
objvPaperEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsChecked].ToString().Trim()); //是否检查
objvPaperEN.Checker = objRow[convPaper.Checker] == DBNull.Value ? null : objRow[convPaper.Checker].ToString().Trim(); //审核人
objvPaperEN.LiteratureTypeId = objRow[convPaper.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperEN.LiteratureTypeName = objRow[convPaper.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaper.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperEN.BrowseNumber = objRow[convPaper.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.BrowseNumber].ToString().Trim()); //浏览量
objvPaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsSubmit].ToString().Trim()); //是否提交
objvPaperEN.AppraiseCount = objRow[convPaper.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.AppraiseCount].ToString().Trim()); //评论数
objvPaperEN.AttachmentCount = objRow[convPaper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.AttachmentCount].ToString().Trim()); //附件计数
objvPaperEN.CollectionCount = objRow[convPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.CollectionCount].ToString().Trim()); //收藏数量
objvPaperEN.DownloadCount = objRow[convPaper.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.DownloadCount].ToString().Trim()); //下载数
objvPaperEN.OkCount = objRow[convPaper.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.OkCount].ToString().Trim()); //点赞统计
objvPaperEN.Pcount = objRow[convPaper.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.Pcount].ToString().Trim()); //读写数
objvPaperEN.Score = objRow[convPaper.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.Score].ToString().Trim()); //评分
objvPaperEN.StuScore = objRow[convPaper.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.StuScore].ToString().Trim()); //学生平均分
objvPaperEN.TeaScore = objRow[convPaper.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.TeaScore].ToString().Trim()); //教师评分
objvPaperEN.PaperTypeId = objRow[convPaper.PaperTypeId] == DBNull.Value ? null : objRow[convPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objvPaperEN.PaperTypeName = objRow[convPaper.PaperTypeName] == DBNull.Value ? null : objRow[convPaper.PaperTypeName].ToString().Trim(); //论文类型名
objvPaperEN.PaperStatusId = objRow[convPaper.PaperStatusId] == DBNull.Value ? null : objRow[convPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objvPaperEN.PaperStatusName = objRow[convPaper.PaperStatusName] == DBNull.Value ? null : objRow[convPaper.PaperStatusName].ToString().Trim(); //论文状态名
objvPaperEN.VersionCount = objRow[convPaper.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.VersionCount].ToString().Trim()); //版本统计
objvPaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsPublic].ToString().Trim()); //是否公开
objvPaperEN.AskQuestion = objRow[convPaper.AskQuestion] == DBNull.Value ? null : objRow[convPaper.AskQuestion].ToString().Trim(); //问题提出
objvPaperEN.ResearchStatus = objRow[convPaper.ResearchStatus] == DBNull.Value ? null : objRow[convPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objvPaperEN.InnovationPoints = objRow[convPaper.InnovationPoints] == DBNull.Value ? null : objRow[convPaper.InnovationPoints].ToString().Trim(); //创新点
objvPaperEN.ResearchDesign = objRow[convPaper.ResearchDesign] == DBNull.Value ? null : objRow[convPaper.ResearchDesign].ToString().Trim(); //研究设计
objvPaperEN.DimensionDataProcess = objRow[convPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[convPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvPaperEN.ExpectedConclusion = objRow[convPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[convPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objvPaperEN.ShareId = objRow[convPaper.ShareId] == DBNull.Value ? null : objRow[convPaper.ShareId].ToString().Trim(); //分享Id
objvPaperEN.PaperQCount = objRow[convPaper.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperEN.SubVCount = objRow[convPaper.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.SubVCount].ToString().Trim()); //论文子观点数
objvPaperEN.TagsCount = objRow[convPaper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.TagsCount].ToString().Trim()); //论文标注数
objvPaperEN.TeaQCount = objRow[convPaper.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.TeaQCount].ToString().Trim()); //教师提问数
objvPaperEN.CreateDate = objRow[convPaper.CreateDate] == DBNull.Value ? null : objRow[convPaper.CreateDate].ToString().Trim(); //建立日期
objvPaperEN.UpdUser = objRow[convPaper.UpdUser] == DBNull.Value ? null : objRow[convPaper.UpdUser].ToString().Trim(); //修改人
objvPaperEN.UserName = objRow[convPaper.UserName] == DBNull.Value ? null : objRow[convPaper.UserName].ToString().Trim(); //用户名
objvPaperEN.IdXzCollege = objRow[convPaper.IdXzCollege] == DBNull.Value ? null : objRow[convPaper.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperEN.UpdDate = objRow[convPaper.UpdDate] == DBNull.Value ? null : objRow[convPaper.UpdDate].ToString().Trim(); //修改日期
objvPaperEN.Memo = objRow[convPaper.Memo] == DBNull.Value ? null : objRow[convPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPaperEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPaperEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperEN> arrObjLst = new List<clsvPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperEN objvPaperEN = new clsvPaperEN();
try
{
objvPaperEN.PaperId = objRow[convPaper.PaperId].ToString().Trim(); //论文Id
objvPaperEN.PaperTitle = objRow[convPaper.PaperTitle].ToString().Trim(); //论文标题
objvPaperEN.PaperContent = objRow[convPaper.PaperContent] == DBNull.Value ? null : objRow[convPaper.PaperContent].ToString().Trim(); //主题内容
objvPaperEN.Periodical = objRow[convPaper.Periodical] == DBNull.Value ? null : objRow[convPaper.Periodical].ToString().Trim(); //期刊
objvPaperEN.Author = objRow[convPaper.Author] == DBNull.Value ? null : objRow[convPaper.Author].ToString().Trim(); //作者
objvPaperEN.ResearchQuestion = objRow[convPaper.ResearchQuestion] == DBNull.Value ? null : objRow[convPaper.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperEN.Keyword = objRow[convPaper.Keyword] == DBNull.Value ? null : objRow[convPaper.Keyword].ToString().Trim(); //关键字
objvPaperEN.LiteratureSources = objRow[convPaper.LiteratureSources] == DBNull.Value ? null : objRow[convPaper.LiteratureSources].ToString().Trim(); //文献来源
objvPaperEN.LiteratureLink = objRow[convPaper.LiteratureLink] == DBNull.Value ? null : objRow[convPaper.LiteratureLink].ToString().Trim(); //文献链接
objvPaperEN.UploadfileUrl = objRow[convPaper.UploadfileUrl] == DBNull.Value ? null : objRow[convPaper.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperEN.QuoteId = objRow[convPaper.QuoteId] == DBNull.Value ? null : objRow[convPaper.QuoteId].ToString().Trim(); //引用Id
objvPaperEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsChecked].ToString().Trim()); //是否检查
objvPaperEN.Checker = objRow[convPaper.Checker] == DBNull.Value ? null : objRow[convPaper.Checker].ToString().Trim(); //审核人
objvPaperEN.LiteratureTypeId = objRow[convPaper.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperEN.LiteratureTypeName = objRow[convPaper.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaper.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperEN.BrowseNumber = objRow[convPaper.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.BrowseNumber].ToString().Trim()); //浏览量
objvPaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsSubmit].ToString().Trim()); //是否提交
objvPaperEN.AppraiseCount = objRow[convPaper.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.AppraiseCount].ToString().Trim()); //评论数
objvPaperEN.AttachmentCount = objRow[convPaper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.AttachmentCount].ToString().Trim()); //附件计数
objvPaperEN.CollectionCount = objRow[convPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.CollectionCount].ToString().Trim()); //收藏数量
objvPaperEN.DownloadCount = objRow[convPaper.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.DownloadCount].ToString().Trim()); //下载数
objvPaperEN.OkCount = objRow[convPaper.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.OkCount].ToString().Trim()); //点赞统计
objvPaperEN.Pcount = objRow[convPaper.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.Pcount].ToString().Trim()); //读写数
objvPaperEN.Score = objRow[convPaper.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.Score].ToString().Trim()); //评分
objvPaperEN.StuScore = objRow[convPaper.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.StuScore].ToString().Trim()); //学生平均分
objvPaperEN.TeaScore = objRow[convPaper.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.TeaScore].ToString().Trim()); //教师评分
objvPaperEN.PaperTypeId = objRow[convPaper.PaperTypeId] == DBNull.Value ? null : objRow[convPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objvPaperEN.PaperTypeName = objRow[convPaper.PaperTypeName] == DBNull.Value ? null : objRow[convPaper.PaperTypeName].ToString().Trim(); //论文类型名
objvPaperEN.PaperStatusId = objRow[convPaper.PaperStatusId] == DBNull.Value ? null : objRow[convPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objvPaperEN.PaperStatusName = objRow[convPaper.PaperStatusName] == DBNull.Value ? null : objRow[convPaper.PaperStatusName].ToString().Trim(); //论文状态名
objvPaperEN.VersionCount = objRow[convPaper.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.VersionCount].ToString().Trim()); //版本统计
objvPaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsPublic].ToString().Trim()); //是否公开
objvPaperEN.AskQuestion = objRow[convPaper.AskQuestion] == DBNull.Value ? null : objRow[convPaper.AskQuestion].ToString().Trim(); //问题提出
objvPaperEN.ResearchStatus = objRow[convPaper.ResearchStatus] == DBNull.Value ? null : objRow[convPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objvPaperEN.InnovationPoints = objRow[convPaper.InnovationPoints] == DBNull.Value ? null : objRow[convPaper.InnovationPoints].ToString().Trim(); //创新点
objvPaperEN.ResearchDesign = objRow[convPaper.ResearchDesign] == DBNull.Value ? null : objRow[convPaper.ResearchDesign].ToString().Trim(); //研究设计
objvPaperEN.DimensionDataProcess = objRow[convPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[convPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvPaperEN.ExpectedConclusion = objRow[convPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[convPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objvPaperEN.ShareId = objRow[convPaper.ShareId] == DBNull.Value ? null : objRow[convPaper.ShareId].ToString().Trim(); //分享Id
objvPaperEN.PaperQCount = objRow[convPaper.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperEN.SubVCount = objRow[convPaper.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.SubVCount].ToString().Trim()); //论文子观点数
objvPaperEN.TagsCount = objRow[convPaper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.TagsCount].ToString().Trim()); //论文标注数
objvPaperEN.TeaQCount = objRow[convPaper.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.TeaQCount].ToString().Trim()); //教师提问数
objvPaperEN.CreateDate = objRow[convPaper.CreateDate] == DBNull.Value ? null : objRow[convPaper.CreateDate].ToString().Trim(); //建立日期
objvPaperEN.UpdUser = objRow[convPaper.UpdUser] == DBNull.Value ? null : objRow[convPaper.UpdUser].ToString().Trim(); //修改人
objvPaperEN.UserName = objRow[convPaper.UserName] == DBNull.Value ? null : objRow[convPaper.UserName].ToString().Trim(); //用户名
objvPaperEN.IdXzCollege = objRow[convPaper.IdXzCollege] == DBNull.Value ? null : objRow[convPaper.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperEN.UpdDate = objRow[convPaper.UpdDate] == DBNull.Value ? null : objRow[convPaper.UpdDate].ToString().Trim(); //修改日期
objvPaperEN.Memo = objRow[convPaper.Memo] == DBNull.Value ? null : objRow[convPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperEN);
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
public static List<clsvPaperEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPaperEN> arrObjLst = new List<clsvPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperEN objvPaperEN = new clsvPaperEN();
try
{
objvPaperEN.PaperId = objRow[convPaper.PaperId].ToString().Trim(); //论文Id
objvPaperEN.PaperTitle = objRow[convPaper.PaperTitle].ToString().Trim(); //论文标题
objvPaperEN.PaperContent = objRow[convPaper.PaperContent] == DBNull.Value ? null : objRow[convPaper.PaperContent].ToString().Trim(); //主题内容
objvPaperEN.Periodical = objRow[convPaper.Periodical] == DBNull.Value ? null : objRow[convPaper.Periodical].ToString().Trim(); //期刊
objvPaperEN.Author = objRow[convPaper.Author] == DBNull.Value ? null : objRow[convPaper.Author].ToString().Trim(); //作者
objvPaperEN.ResearchQuestion = objRow[convPaper.ResearchQuestion] == DBNull.Value ? null : objRow[convPaper.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperEN.Keyword = objRow[convPaper.Keyword] == DBNull.Value ? null : objRow[convPaper.Keyword].ToString().Trim(); //关键字
objvPaperEN.LiteratureSources = objRow[convPaper.LiteratureSources] == DBNull.Value ? null : objRow[convPaper.LiteratureSources].ToString().Trim(); //文献来源
objvPaperEN.LiteratureLink = objRow[convPaper.LiteratureLink] == DBNull.Value ? null : objRow[convPaper.LiteratureLink].ToString().Trim(); //文献链接
objvPaperEN.UploadfileUrl = objRow[convPaper.UploadfileUrl] == DBNull.Value ? null : objRow[convPaper.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperEN.QuoteId = objRow[convPaper.QuoteId] == DBNull.Value ? null : objRow[convPaper.QuoteId].ToString().Trim(); //引用Id
objvPaperEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsChecked].ToString().Trim()); //是否检查
objvPaperEN.Checker = objRow[convPaper.Checker] == DBNull.Value ? null : objRow[convPaper.Checker].ToString().Trim(); //审核人
objvPaperEN.LiteratureTypeId = objRow[convPaper.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperEN.LiteratureTypeName = objRow[convPaper.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaper.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperEN.BrowseNumber = objRow[convPaper.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.BrowseNumber].ToString().Trim()); //浏览量
objvPaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsSubmit].ToString().Trim()); //是否提交
objvPaperEN.AppraiseCount = objRow[convPaper.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.AppraiseCount].ToString().Trim()); //评论数
objvPaperEN.AttachmentCount = objRow[convPaper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.AttachmentCount].ToString().Trim()); //附件计数
objvPaperEN.CollectionCount = objRow[convPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.CollectionCount].ToString().Trim()); //收藏数量
objvPaperEN.DownloadCount = objRow[convPaper.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.DownloadCount].ToString().Trim()); //下载数
objvPaperEN.OkCount = objRow[convPaper.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.OkCount].ToString().Trim()); //点赞统计
objvPaperEN.Pcount = objRow[convPaper.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.Pcount].ToString().Trim()); //读写数
objvPaperEN.Score = objRow[convPaper.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.Score].ToString().Trim()); //评分
objvPaperEN.StuScore = objRow[convPaper.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.StuScore].ToString().Trim()); //学生平均分
objvPaperEN.TeaScore = objRow[convPaper.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.TeaScore].ToString().Trim()); //教师评分
objvPaperEN.PaperTypeId = objRow[convPaper.PaperTypeId] == DBNull.Value ? null : objRow[convPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objvPaperEN.PaperTypeName = objRow[convPaper.PaperTypeName] == DBNull.Value ? null : objRow[convPaper.PaperTypeName].ToString().Trim(); //论文类型名
objvPaperEN.PaperStatusId = objRow[convPaper.PaperStatusId] == DBNull.Value ? null : objRow[convPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objvPaperEN.PaperStatusName = objRow[convPaper.PaperStatusName] == DBNull.Value ? null : objRow[convPaper.PaperStatusName].ToString().Trim(); //论文状态名
objvPaperEN.VersionCount = objRow[convPaper.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.VersionCount].ToString().Trim()); //版本统计
objvPaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsPublic].ToString().Trim()); //是否公开
objvPaperEN.AskQuestion = objRow[convPaper.AskQuestion] == DBNull.Value ? null : objRow[convPaper.AskQuestion].ToString().Trim(); //问题提出
objvPaperEN.ResearchStatus = objRow[convPaper.ResearchStatus] == DBNull.Value ? null : objRow[convPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objvPaperEN.InnovationPoints = objRow[convPaper.InnovationPoints] == DBNull.Value ? null : objRow[convPaper.InnovationPoints].ToString().Trim(); //创新点
objvPaperEN.ResearchDesign = objRow[convPaper.ResearchDesign] == DBNull.Value ? null : objRow[convPaper.ResearchDesign].ToString().Trim(); //研究设计
objvPaperEN.DimensionDataProcess = objRow[convPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[convPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvPaperEN.ExpectedConclusion = objRow[convPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[convPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objvPaperEN.ShareId = objRow[convPaper.ShareId] == DBNull.Value ? null : objRow[convPaper.ShareId].ToString().Trim(); //分享Id
objvPaperEN.PaperQCount = objRow[convPaper.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperEN.SubVCount = objRow[convPaper.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.SubVCount].ToString().Trim()); //论文子观点数
objvPaperEN.TagsCount = objRow[convPaper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.TagsCount].ToString().Trim()); //论文标注数
objvPaperEN.TeaQCount = objRow[convPaper.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.TeaQCount].ToString().Trim()); //教师提问数
objvPaperEN.CreateDate = objRow[convPaper.CreateDate] == DBNull.Value ? null : objRow[convPaper.CreateDate].ToString().Trim(); //建立日期
objvPaperEN.UpdUser = objRow[convPaper.UpdUser] == DBNull.Value ? null : objRow[convPaper.UpdUser].ToString().Trim(); //修改人
objvPaperEN.UserName = objRow[convPaper.UserName] == DBNull.Value ? null : objRow[convPaper.UserName].ToString().Trim(); //用户名
objvPaperEN.IdXzCollege = objRow[convPaper.IdXzCollege] == DBNull.Value ? null : objRow[convPaper.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperEN.UpdDate = objRow[convPaper.UpdDate] == DBNull.Value ? null : objRow[convPaper.UpdDate].ToString().Trim(); //修改日期
objvPaperEN.Memo = objRow[convPaper.Memo] == DBNull.Value ? null : objRow[convPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPaperEN> arrObjLst = new List<clsvPaperEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperEN objvPaperEN = new clsvPaperEN();
try
{
objvPaperEN.PaperId = objRow[convPaper.PaperId].ToString().Trim(); //论文Id
objvPaperEN.PaperTitle = objRow[convPaper.PaperTitle].ToString().Trim(); //论文标题
objvPaperEN.PaperContent = objRow[convPaper.PaperContent] == DBNull.Value ? null : objRow[convPaper.PaperContent].ToString().Trim(); //主题内容
objvPaperEN.Periodical = objRow[convPaper.Periodical] == DBNull.Value ? null : objRow[convPaper.Periodical].ToString().Trim(); //期刊
objvPaperEN.Author = objRow[convPaper.Author] == DBNull.Value ? null : objRow[convPaper.Author].ToString().Trim(); //作者
objvPaperEN.ResearchQuestion = objRow[convPaper.ResearchQuestion] == DBNull.Value ? null : objRow[convPaper.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperEN.Keyword = objRow[convPaper.Keyword] == DBNull.Value ? null : objRow[convPaper.Keyword].ToString().Trim(); //关键字
objvPaperEN.LiteratureSources = objRow[convPaper.LiteratureSources] == DBNull.Value ? null : objRow[convPaper.LiteratureSources].ToString().Trim(); //文献来源
objvPaperEN.LiteratureLink = objRow[convPaper.LiteratureLink] == DBNull.Value ? null : objRow[convPaper.LiteratureLink].ToString().Trim(); //文献链接
objvPaperEN.UploadfileUrl = objRow[convPaper.UploadfileUrl] == DBNull.Value ? null : objRow[convPaper.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperEN.QuoteId = objRow[convPaper.QuoteId] == DBNull.Value ? null : objRow[convPaper.QuoteId].ToString().Trim(); //引用Id
objvPaperEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsChecked].ToString().Trim()); //是否检查
objvPaperEN.Checker = objRow[convPaper.Checker] == DBNull.Value ? null : objRow[convPaper.Checker].ToString().Trim(); //审核人
objvPaperEN.LiteratureTypeId = objRow[convPaper.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperEN.LiteratureTypeName = objRow[convPaper.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaper.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperEN.BrowseNumber = objRow[convPaper.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.BrowseNumber].ToString().Trim()); //浏览量
objvPaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsSubmit].ToString().Trim()); //是否提交
objvPaperEN.AppraiseCount = objRow[convPaper.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.AppraiseCount].ToString().Trim()); //评论数
objvPaperEN.AttachmentCount = objRow[convPaper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.AttachmentCount].ToString().Trim()); //附件计数
objvPaperEN.CollectionCount = objRow[convPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.CollectionCount].ToString().Trim()); //收藏数量
objvPaperEN.DownloadCount = objRow[convPaper.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.DownloadCount].ToString().Trim()); //下载数
objvPaperEN.OkCount = objRow[convPaper.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.OkCount].ToString().Trim()); //点赞统计
objvPaperEN.Pcount = objRow[convPaper.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.Pcount].ToString().Trim()); //读写数
objvPaperEN.Score = objRow[convPaper.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.Score].ToString().Trim()); //评分
objvPaperEN.StuScore = objRow[convPaper.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.StuScore].ToString().Trim()); //学生平均分
objvPaperEN.TeaScore = objRow[convPaper.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaper.TeaScore].ToString().Trim()); //教师评分
objvPaperEN.PaperTypeId = objRow[convPaper.PaperTypeId] == DBNull.Value ? null : objRow[convPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objvPaperEN.PaperTypeName = objRow[convPaper.PaperTypeName] == DBNull.Value ? null : objRow[convPaper.PaperTypeName].ToString().Trim(); //论文类型名
objvPaperEN.PaperStatusId = objRow[convPaper.PaperStatusId] == DBNull.Value ? null : objRow[convPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objvPaperEN.PaperStatusName = objRow[convPaper.PaperStatusName] == DBNull.Value ? null : objRow[convPaper.PaperStatusName].ToString().Trim(); //论文状态名
objvPaperEN.VersionCount = objRow[convPaper.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.VersionCount].ToString().Trim()); //版本统计
objvPaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaper.IsPublic].ToString().Trim()); //是否公开
objvPaperEN.AskQuestion = objRow[convPaper.AskQuestion] == DBNull.Value ? null : objRow[convPaper.AskQuestion].ToString().Trim(); //问题提出
objvPaperEN.ResearchStatus = objRow[convPaper.ResearchStatus] == DBNull.Value ? null : objRow[convPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objvPaperEN.InnovationPoints = objRow[convPaper.InnovationPoints] == DBNull.Value ? null : objRow[convPaper.InnovationPoints].ToString().Trim(); //创新点
objvPaperEN.ResearchDesign = objRow[convPaper.ResearchDesign] == DBNull.Value ? null : objRow[convPaper.ResearchDesign].ToString().Trim(); //研究设计
objvPaperEN.DimensionDataProcess = objRow[convPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[convPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvPaperEN.ExpectedConclusion = objRow[convPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[convPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objvPaperEN.ShareId = objRow[convPaper.ShareId] == DBNull.Value ? null : objRow[convPaper.ShareId].ToString().Trim(); //分享Id
objvPaperEN.PaperQCount = objRow[convPaper.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperEN.SubVCount = objRow[convPaper.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.SubVCount].ToString().Trim()); //论文子观点数
objvPaperEN.TagsCount = objRow[convPaper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.TagsCount].ToString().Trim()); //论文标注数
objvPaperEN.TeaQCount = objRow[convPaper.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaper.TeaQCount].ToString().Trim()); //教师提问数
objvPaperEN.CreateDate = objRow[convPaper.CreateDate] == DBNull.Value ? null : objRow[convPaper.CreateDate].ToString().Trim(); //建立日期
objvPaperEN.UpdUser = objRow[convPaper.UpdUser] == DBNull.Value ? null : objRow[convPaper.UpdUser].ToString().Trim(); //修改人
objvPaperEN.UserName = objRow[convPaper.UserName] == DBNull.Value ? null : objRow[convPaper.UserName].ToString().Trim(); //用户名
objvPaperEN.IdXzCollege = objRow[convPaper.IdXzCollege] == DBNull.Value ? null : objRow[convPaper.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperEN.UpdDate = objRow[convPaper.UpdDate] == DBNull.Value ? null : objRow[convPaper.UpdDate].ToString().Trim(); //修改日期
objvPaperEN.Memo = objRow[convPaper.Memo] == DBNull.Value ? null : objRow[convPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPaperEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPaper(ref clsvPaperEN objvPaperEN)
{
bool bolResult = vPaperDA.GetvPaper(ref objvPaperEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperEN GetObjByPaperId(string strPaperId)
{
if (strPaperId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPaperId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPaperId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPaperId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvPaperEN objvPaperEN = vPaperDA.GetObjByPaperId(strPaperId);
return objvPaperEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPaperEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPaperEN objvPaperEN = vPaperDA.GetFirstObj(strWhereCond);
 return objvPaperEN;
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
public static clsvPaperEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPaperEN objvPaperEN = vPaperDA.GetObjByDataRow(objRow);
 return objvPaperEN;
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
public static clsvPaperEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPaperEN objvPaperEN = vPaperDA.GetObjByDataRow(objRow);
 return objvPaperEN;
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
 /// <param name = "strPaperId">所给的关键字</param>
 /// <param name = "lstvPaperObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperEN GetObjByPaperIdFromList(string strPaperId, List<clsvPaperEN> lstvPaperObjLst)
{
foreach (clsvPaperEN objvPaperEN in lstvPaperObjLst)
{
if (objvPaperEN.PaperId == strPaperId)
{
return objvPaperEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxPaperId;
 try
 {
 strMaxPaperId = clsvPaperDA.GetMaxStrId();
 return strMaxPaperId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strPaperId;
 try
 {
 strPaperId = new clsvPaperDA().GetFirstID(strWhereCond);
 return strPaperId;
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
 arrList = vPaperDA.GetID(strWhereCond);
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
bool bolIsExist = vPaperDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPaperId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPaperId)
{
if (string.IsNullOrEmpty(strPaperId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPaperId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vPaperDA.IsExist(strPaperId);
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
 bolIsExist = clsvPaperDA.IsExistTable();
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
 bolIsExist = vPaperDA.IsExistTable(strTabName);
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
 /// <param name = "objvPaperENS">源对象</param>
 /// <param name = "objvPaperENT">目标对象</param>
 public static void CopyTo(clsvPaperEN objvPaperENS, clsvPaperEN objvPaperENT)
{
try
{
objvPaperENT.PaperId = objvPaperENS.PaperId; //论文Id
objvPaperENT.PaperTitle = objvPaperENS.PaperTitle; //论文标题
objvPaperENT.PaperContent = objvPaperENS.PaperContent; //主题内容
objvPaperENT.Periodical = objvPaperENS.Periodical; //期刊
objvPaperENT.Author = objvPaperENS.Author; //作者
objvPaperENT.ResearchQuestion = objvPaperENS.ResearchQuestion; //研究问题
objvPaperENT.Keyword = objvPaperENS.Keyword; //关键字
objvPaperENT.LiteratureSources = objvPaperENS.LiteratureSources; //文献来源
objvPaperENT.LiteratureLink = objvPaperENS.LiteratureLink; //文献链接
objvPaperENT.UploadfileUrl = objvPaperENS.UploadfileUrl; //文件地址
objvPaperENT.IsQuotethesis = objvPaperENS.IsQuotethesis; //是否引用论文
objvPaperENT.QuoteId = objvPaperENS.QuoteId; //引用Id
objvPaperENT.IsChecked = objvPaperENS.IsChecked; //是否检查
objvPaperENT.Checker = objvPaperENS.Checker; //审核人
objvPaperENT.LiteratureTypeId = objvPaperENS.LiteratureTypeId; //作文类型Id
objvPaperENT.LiteratureTypeName = objvPaperENS.LiteratureTypeName; //作文类型名
objvPaperENT.BrowseNumber = objvPaperENS.BrowseNumber; //浏览量
objvPaperENT.IsSubmit = objvPaperENS.IsSubmit; //是否提交
objvPaperENT.AppraiseCount = objvPaperENS.AppraiseCount; //评论数
objvPaperENT.AttachmentCount = objvPaperENS.AttachmentCount; //附件计数
objvPaperENT.CollectionCount = objvPaperENS.CollectionCount; //收藏数量
objvPaperENT.DownloadCount = objvPaperENS.DownloadCount; //下载数
objvPaperENT.OkCount = objvPaperENS.OkCount; //点赞统计
objvPaperENT.Pcount = objvPaperENS.Pcount; //读写数
objvPaperENT.Score = objvPaperENS.Score; //评分
objvPaperENT.StuScore = objvPaperENS.StuScore; //学生平均分
objvPaperENT.TeaScore = objvPaperENS.TeaScore; //教师评分
objvPaperENT.PaperTypeId = objvPaperENS.PaperTypeId; //论文类型Id
objvPaperENT.PaperTypeName = objvPaperENS.PaperTypeName; //论文类型名
objvPaperENT.PaperStatusId = objvPaperENS.PaperStatusId; //论文状态Id
objvPaperENT.PaperStatusName = objvPaperENS.PaperStatusName; //论文状态名
objvPaperENT.VersionCount = objvPaperENS.VersionCount; //版本统计
objvPaperENT.IsPublic = objvPaperENS.IsPublic; //是否公开
objvPaperENT.AskQuestion = objvPaperENS.AskQuestion; //问题提出
objvPaperENT.ResearchStatus = objvPaperENS.ResearchStatus; //目前研究的现状
objvPaperENT.InnovationPoints = objvPaperENS.InnovationPoints; //创新点
objvPaperENT.ResearchDesign = objvPaperENS.ResearchDesign; //研究设计
objvPaperENT.DimensionDataProcess = objvPaperENS.DimensionDataProcess; //数据处理的维度
objvPaperENT.ExpectedConclusion = objvPaperENS.ExpectedConclusion; //预期结论
objvPaperENT.ShareId = objvPaperENS.ShareId; //分享Id
objvPaperENT.PaperQCount = objvPaperENS.PaperQCount; //论文答疑数
objvPaperENT.SubVCount = objvPaperENS.SubVCount; //论文子观点数
objvPaperENT.TagsCount = objvPaperENS.TagsCount; //论文标注数
objvPaperENT.TeaQCount = objvPaperENS.TeaQCount; //教师提问数
objvPaperENT.CreateDate = objvPaperENS.CreateDate; //建立日期
objvPaperENT.UpdUser = objvPaperENS.UpdUser; //修改人
objvPaperENT.UserName = objvPaperENS.UserName; //用户名
objvPaperENT.IdXzCollege = objvPaperENS.IdXzCollege; //学院流水号
objvPaperENT.UpdDate = objvPaperENS.UpdDate; //修改日期
objvPaperENT.Memo = objvPaperENS.Memo; //备注
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
 /// <param name = "objvPaperEN">源简化对象</param>
 public static void SetUpdFlag(clsvPaperEN objvPaperEN)
{
try
{
objvPaperEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPaperEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPaper.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.PaperId = objvPaperEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convPaper.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.PaperTitle = objvPaperEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convPaper.PaperContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.PaperContent = objvPaperEN.PaperContent == "[null]" ? null :  objvPaperEN.PaperContent; //主题内容
}
if (arrFldSet.Contains(convPaper.Periodical, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.Periodical = objvPaperEN.Periodical == "[null]" ? null :  objvPaperEN.Periodical; //期刊
}
if (arrFldSet.Contains(convPaper.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.Author = objvPaperEN.Author == "[null]" ? null :  objvPaperEN.Author; //作者
}
if (arrFldSet.Contains(convPaper.ResearchQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.ResearchQuestion = objvPaperEN.ResearchQuestion == "[null]" ? null :  objvPaperEN.ResearchQuestion; //研究问题
}
if (arrFldSet.Contains(convPaper.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.Keyword = objvPaperEN.Keyword == "[null]" ? null :  objvPaperEN.Keyword; //关键字
}
if (arrFldSet.Contains(convPaper.LiteratureSources, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.LiteratureSources = objvPaperEN.LiteratureSources == "[null]" ? null :  objvPaperEN.LiteratureSources; //文献来源
}
if (arrFldSet.Contains(convPaper.LiteratureLink, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.LiteratureLink = objvPaperEN.LiteratureLink == "[null]" ? null :  objvPaperEN.LiteratureLink; //文献链接
}
if (arrFldSet.Contains(convPaper.UploadfileUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.UploadfileUrl = objvPaperEN.UploadfileUrl == "[null]" ? null :  objvPaperEN.UploadfileUrl; //文件地址
}
if (arrFldSet.Contains(convPaper.IsQuotethesis, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.IsQuotethesis = objvPaperEN.IsQuotethesis; //是否引用论文
}
if (arrFldSet.Contains(convPaper.QuoteId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.QuoteId = objvPaperEN.QuoteId == "[null]" ? null :  objvPaperEN.QuoteId; //引用Id
}
if (arrFldSet.Contains(convPaper.IsChecked, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.IsChecked = objvPaperEN.IsChecked; //是否检查
}
if (arrFldSet.Contains(convPaper.Checker, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.Checker = objvPaperEN.Checker == "[null]" ? null :  objvPaperEN.Checker; //审核人
}
if (arrFldSet.Contains(convPaper.LiteratureTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.LiteratureTypeId = objvPaperEN.LiteratureTypeId; //作文类型Id
}
if (arrFldSet.Contains(convPaper.LiteratureTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.LiteratureTypeName = objvPaperEN.LiteratureTypeName == "[null]" ? null :  objvPaperEN.LiteratureTypeName; //作文类型名
}
if (arrFldSet.Contains(convPaper.BrowseNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.BrowseNumber = objvPaperEN.BrowseNumber; //浏览量
}
if (arrFldSet.Contains(convPaper.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.IsSubmit = objvPaperEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convPaper.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.AppraiseCount = objvPaperEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convPaper.AttachmentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.AttachmentCount = objvPaperEN.AttachmentCount; //附件计数
}
if (arrFldSet.Contains(convPaper.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.CollectionCount = objvPaperEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(convPaper.DownloadCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.DownloadCount = objvPaperEN.DownloadCount; //下载数
}
if (arrFldSet.Contains(convPaper.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.OkCount = objvPaperEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convPaper.Pcount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.Pcount = objvPaperEN.Pcount; //读写数
}
if (arrFldSet.Contains(convPaper.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.Score = objvPaperEN.Score; //评分
}
if (arrFldSet.Contains(convPaper.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.StuScore = objvPaperEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convPaper.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.TeaScore = objvPaperEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convPaper.PaperTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.PaperTypeId = objvPaperEN.PaperTypeId == "[null]" ? null :  objvPaperEN.PaperTypeId; //论文类型Id
}
if (arrFldSet.Contains(convPaper.PaperTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.PaperTypeName = objvPaperEN.PaperTypeName == "[null]" ? null :  objvPaperEN.PaperTypeName; //论文类型名
}
if (arrFldSet.Contains(convPaper.PaperStatusId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.PaperStatusId = objvPaperEN.PaperStatusId == "[null]" ? null :  objvPaperEN.PaperStatusId; //论文状态Id
}
if (arrFldSet.Contains(convPaper.PaperStatusName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.PaperStatusName = objvPaperEN.PaperStatusName == "[null]" ? null :  objvPaperEN.PaperStatusName; //论文状态名
}
if (arrFldSet.Contains(convPaper.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.VersionCount = objvPaperEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convPaper.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.IsPublic = objvPaperEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(convPaper.AskQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.AskQuestion = objvPaperEN.AskQuestion == "[null]" ? null :  objvPaperEN.AskQuestion; //问题提出
}
if (arrFldSet.Contains(convPaper.ResearchStatus, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.ResearchStatus = objvPaperEN.ResearchStatus == "[null]" ? null :  objvPaperEN.ResearchStatus; //目前研究的现状
}
if (arrFldSet.Contains(convPaper.InnovationPoints, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.InnovationPoints = objvPaperEN.InnovationPoints == "[null]" ? null :  objvPaperEN.InnovationPoints; //创新点
}
if (arrFldSet.Contains(convPaper.ResearchDesign, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.ResearchDesign = objvPaperEN.ResearchDesign == "[null]" ? null :  objvPaperEN.ResearchDesign; //研究设计
}
if (arrFldSet.Contains(convPaper.DimensionDataProcess, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.DimensionDataProcess = objvPaperEN.DimensionDataProcess == "[null]" ? null :  objvPaperEN.DimensionDataProcess; //数据处理的维度
}
if (arrFldSet.Contains(convPaper.ExpectedConclusion, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.ExpectedConclusion = objvPaperEN.ExpectedConclusion == "[null]" ? null :  objvPaperEN.ExpectedConclusion; //预期结论
}
if (arrFldSet.Contains(convPaper.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.ShareId = objvPaperEN.ShareId == "[null]" ? null :  objvPaperEN.ShareId; //分享Id
}
if (arrFldSet.Contains(convPaper.PaperQCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.PaperQCount = objvPaperEN.PaperQCount; //论文答疑数
}
if (arrFldSet.Contains(convPaper.SubVCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.SubVCount = objvPaperEN.SubVCount; //论文子观点数
}
if (arrFldSet.Contains(convPaper.TagsCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.TagsCount = objvPaperEN.TagsCount; //论文标注数
}
if (arrFldSet.Contains(convPaper.TeaQCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.TeaQCount = objvPaperEN.TeaQCount; //教师提问数
}
if (arrFldSet.Contains(convPaper.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.CreateDate = objvPaperEN.CreateDate == "[null]" ? null :  objvPaperEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convPaper.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.UpdUser = objvPaperEN.UpdUser == "[null]" ? null :  objvPaperEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convPaper.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.UserName = objvPaperEN.UserName == "[null]" ? null :  objvPaperEN.UserName; //用户名
}
if (arrFldSet.Contains(convPaper.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.IdXzCollege = objvPaperEN.IdXzCollege == "[null]" ? null :  objvPaperEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convPaper.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.UpdDate = objvPaperEN.UpdDate == "[null]" ? null :  objvPaperEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPaper.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEN.Memo = objvPaperEN.Memo == "[null]" ? null :  objvPaperEN.Memo; //备注
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
 /// <param name = "objvPaperEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPaperEN objvPaperEN)
{
try
{
if (objvPaperEN.PaperContent == "[null]") objvPaperEN.PaperContent = null; //主题内容
if (objvPaperEN.Periodical == "[null]") objvPaperEN.Periodical = null; //期刊
if (objvPaperEN.Author == "[null]") objvPaperEN.Author = null; //作者
if (objvPaperEN.ResearchQuestion == "[null]") objvPaperEN.ResearchQuestion = null; //研究问题
if (objvPaperEN.Keyword == "[null]") objvPaperEN.Keyword = null; //关键字
if (objvPaperEN.LiteratureSources == "[null]") objvPaperEN.LiteratureSources = null; //文献来源
if (objvPaperEN.LiteratureLink == "[null]") objvPaperEN.LiteratureLink = null; //文献链接
if (objvPaperEN.UploadfileUrl == "[null]") objvPaperEN.UploadfileUrl = null; //文件地址
if (objvPaperEN.QuoteId == "[null]") objvPaperEN.QuoteId = null; //引用Id
if (objvPaperEN.Checker == "[null]") objvPaperEN.Checker = null; //审核人
if (objvPaperEN.LiteratureTypeName == "[null]") objvPaperEN.LiteratureTypeName = null; //作文类型名
if (objvPaperEN.PaperTypeId == "[null]") objvPaperEN.PaperTypeId = null; //论文类型Id
if (objvPaperEN.PaperTypeName == "[null]") objvPaperEN.PaperTypeName = null; //论文类型名
if (objvPaperEN.PaperStatusId == "[null]") objvPaperEN.PaperStatusId = null; //论文状态Id
if (objvPaperEN.PaperStatusName == "[null]") objvPaperEN.PaperStatusName = null; //论文状态名
if (objvPaperEN.AskQuestion == "[null]") objvPaperEN.AskQuestion = null; //问题提出
if (objvPaperEN.ResearchStatus == "[null]") objvPaperEN.ResearchStatus = null; //目前研究的现状
if (objvPaperEN.InnovationPoints == "[null]") objvPaperEN.InnovationPoints = null; //创新点
if (objvPaperEN.ResearchDesign == "[null]") objvPaperEN.ResearchDesign = null; //研究设计
if (objvPaperEN.DimensionDataProcess == "[null]") objvPaperEN.DimensionDataProcess = null; //数据处理的维度
if (objvPaperEN.ExpectedConclusion == "[null]") objvPaperEN.ExpectedConclusion = null; //预期结论
if (objvPaperEN.ShareId == "[null]") objvPaperEN.ShareId = null; //分享Id
if (objvPaperEN.CreateDate == "[null]") objvPaperEN.CreateDate = null; //建立日期
if (objvPaperEN.UpdUser == "[null]") objvPaperEN.UpdUser = null; //修改人
if (objvPaperEN.UserName == "[null]") objvPaperEN.UserName = null; //用户名
if (objvPaperEN.IdXzCollege == "[null]") objvPaperEN.IdXzCollege = null; //学院流水号
if (objvPaperEN.UpdDate == "[null]") objvPaperEN.UpdDate = null; //修改日期
if (objvPaperEN.Memo == "[null]") objvPaperEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvPaperEN objvPaperEN)
{
 vPaperDA.CheckProperty4Condition(objvPaperEN);
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
if (clsCurrEduClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsBL没有刷新缓存机制(clsCurrEduClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperBL没有刷新缓存机制(clsPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperId");
//if (arrvPaperObjLstCache == null)
//{
//arrvPaperObjLstCache = vPaperDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPaperId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperEN GetObjByPaperIdCache(string strPaperId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPaperEN._CurrTabName);
List<clsvPaperEN> arrvPaperObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperEN> arrvPaperObjLst_Sel =
arrvPaperObjLstCache
.Where(x=> x.PaperId == strPaperId 
);
if (arrvPaperObjLst_Sel.Count() == 0)
{
   clsvPaperEN obj = clsvPaperBL.GetObjByPaperId(strPaperId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPaperObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperEN> GetAllvPaperObjLstCache()
{
//获取缓存中的对象列表
List<clsvPaperEN> arrvPaperObjLstCache = GetObjLstCache(); 
return arrvPaperObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPaperEN._CurrTabName);
List<clsvPaperEN> arrvPaperObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPaperObjLstCache;
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
string strKey = string.Format("{0}", clsvPaperEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strPaperId)
{
if (strInFldName != convPaper.PaperId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPaper.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPaper.AttributeName));
throw new Exception(strMsg);
}
var objvPaper = clsvPaperBL.GetObjByPaperIdCache(strPaperId);
if (objvPaper == null) return "";
return objvPaper[strOutFldName].ToString();
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
int intRecCount = clsvPaperDA.GetRecCount(strTabName);
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
int intRecCount = clsvPaperDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPaperDA.GetRecCount();
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
int intRecCount = clsvPaperDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPaperCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPaperEN objvPaperCond)
{
List<clsvPaperEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaper.AttributeName)
{
if (objvPaperCond.IsUpdated(strFldName) == false) continue;
if (objvPaperCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperCond[strFldName].ToString());
}
else
{
if (objvPaperCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperCond[strFldName]));
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
 List<string> arrList = clsvPaperDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPaperDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPaperDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}