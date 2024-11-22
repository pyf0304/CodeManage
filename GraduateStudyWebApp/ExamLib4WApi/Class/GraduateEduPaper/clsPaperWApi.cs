
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsPaperWApi
表名:Paper(01120535)
生成代码版本:2021.10.17.1
生成日期:2021/10/17 17:09:49
生成者:pyf
生成服务器IP:103.116.76.183
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培论文
模块英文名:GraduateEduPaper
框架-层名:WA_访问层(WA_Access)
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
	public static class clsPaperWApi_Static
	{

		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetPaperId(this clsPaperEN objPaperEN, string strPaperId, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldLen(strPaperId, 8, conPaper.PaperId);
			clsCheckSql.CheckFieldForeignKey(strPaperId, 8, conPaper.PaperId);
			objPaperEN.PaperId = strPaperId; //论文Id
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.PaperId) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.PaperId, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.PaperId] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetPaperTitle(this clsPaperEN objPaperEN, string strPaperTitle, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldNotNull(strPaperTitle, conPaper.PaperTitle);
			clsCheckSql.CheckFieldLen(strPaperTitle, 500, conPaper.PaperTitle);
			objPaperEN.PaperTitle = strPaperTitle; //论文标题
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.PaperTitle) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.PaperTitle, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.PaperTitle] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetPaperContent(this clsPaperEN objPaperEN, string strPaperContent, string strComparisonOp = "")
		{
			objPaperEN.PaperContent = strPaperContent; //主题内容
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.PaperContent) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.PaperContent, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.PaperContent] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetPeriodical(this clsPaperEN objPaperEN, string strPeriodical, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldLen(strPeriodical, 100, conPaper.Periodical);
			objPaperEN.Periodical = strPeriodical; //期刊
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.Periodical) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.Periodical, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.Periodical] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetAuthor(this clsPaperEN objPaperEN, string strAuthor, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldLen(strAuthor, 200, conPaper.Author);
			objPaperEN.Author = strAuthor; //作者
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.Author) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.Author, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.Author] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetResearchQuestion(this clsPaperEN objPaperEN, string strResearchQuestion, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, conPaper.ResearchQuestion);
			objPaperEN.ResearchQuestion = strResearchQuestion; //研究问题
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.ResearchQuestion) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.ResearchQuestion, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.ResearchQuestion] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetKeyword(this clsPaperEN objPaperEN, string strKeyword, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldLen(strKeyword, 1000, conPaper.Keyword);
			objPaperEN.Keyword = strKeyword; //关键字
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.Keyword) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.Keyword, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.Keyword] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetLiteratureSources(this clsPaperEN objPaperEN, string strLiteratureSources, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldLen(strLiteratureSources, 1000, conPaper.LiteratureSources);
			objPaperEN.LiteratureSources = strLiteratureSources; //文献来源
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.LiteratureSources) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.LiteratureSources, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.LiteratureSources] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetLiteratureLink(this clsPaperEN objPaperEN, string strLiteratureLink, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldLen(strLiteratureLink, 1000, conPaper.LiteratureLink);
			objPaperEN.LiteratureLink = strLiteratureLink; //文献链接
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.LiteratureLink) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.LiteratureLink, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.LiteratureLink] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetUploadfileUrl(this clsPaperEN objPaperEN, string strUploadfileUrl, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldLen(strUploadfileUrl, 1000, conPaper.UploadfileUrl);
			objPaperEN.UploadfileUrl = strUploadfileUrl; //文件地址
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.UploadfileUrl) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.UploadfileUrl, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.UploadfileUrl] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetIsQuotethesis(this clsPaperEN objPaperEN, bool bolIsQuotethesis, string strComparisonOp = "")
		{
			objPaperEN.IsQuotethesis = bolIsQuotethesis; //是否引用论文
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.IsQuotethesis) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.IsQuotethesis, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.IsQuotethesis] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetQuoteId(this clsPaperEN objPaperEN, string strQuoteId, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldLen(strQuoteId, 8, conPaper.QuoteId);
			clsCheckSql.CheckFieldForeignKey(strQuoteId, 8, conPaper.QuoteId);
			objPaperEN.QuoteId = strQuoteId; //引用Id
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.QuoteId) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.QuoteId, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.QuoteId] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetIsChecked(this clsPaperEN objPaperEN, bool bolIsChecked, string strComparisonOp = "")
		{
			objPaperEN.IsChecked = bolIsChecked; //是否检查
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.IsChecked) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.IsChecked, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.IsChecked] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetChecker(this clsPaperEN objPaperEN, string strChecker, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldLen(strChecker, 20, conPaper.Checker);
			objPaperEN.Checker = strChecker; //审核人
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.Checker) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.Checker, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.Checker] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetLiteratureTypeId(this clsPaperEN objPaperEN, string strLiteratureTypeId, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldNotNull(strLiteratureTypeId, conPaper.LiteratureTypeId);
			clsCheckSql.CheckFieldLen(strLiteratureTypeId, 2, conPaper.LiteratureTypeId);
			clsCheckSql.CheckFieldForeignKey(strLiteratureTypeId, 2, conPaper.LiteratureTypeId);
			objPaperEN.LiteratureTypeId = strLiteratureTypeId; //作文类型Id
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.LiteratureTypeId) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.LiteratureTypeId, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.LiteratureTypeId] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetBrowseNumber(this clsPaperEN objPaperEN, int intBrowseNumber, string strComparisonOp = "")
		{
			objPaperEN.BrowseNumber = intBrowseNumber; //浏览量
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.BrowseNumber) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.BrowseNumber, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.BrowseNumber] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetIsSubmit(this clsPaperEN objPaperEN, bool bolIsSubmit, string strComparisonOp = "")
		{
			objPaperEN.IsSubmit = bolIsSubmit; //是否提交
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.IsSubmit) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.IsSubmit, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.IsSubmit] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetAppraiseCount(this clsPaperEN objPaperEN, int intAppraiseCount, string strComparisonOp = "")
		{
			objPaperEN.AppraiseCount = intAppraiseCount; //评论数
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.AppraiseCount) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.AppraiseCount, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.AppraiseCount] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetAttachmentCount(this clsPaperEN objPaperEN, int intAttachmentCount, string strComparisonOp = "")
		{
			objPaperEN.AttachmentCount = intAttachmentCount; //附件计数
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.AttachmentCount) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.AttachmentCount, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.AttachmentCount] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetCollectionCount(this clsPaperEN objPaperEN, int intCollectionCount, string strComparisonOp = "")
		{
			objPaperEN.CollectionCount = intCollectionCount; //收藏数
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.CollectionCount) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.CollectionCount, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.CollectionCount] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetDownloadCount(this clsPaperEN objPaperEN, int intDownloadCount, string strComparisonOp = "")
		{
			objPaperEN.DownloadCount = intDownloadCount; //下载数
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.DownloadCount) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.DownloadCount, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.DownloadCount] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetOkCount(this clsPaperEN objPaperEN, int intOkCount, string strComparisonOp = "")
		{
			objPaperEN.OkCount = intOkCount; //点赞统计
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.OkCount) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.OkCount, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.OkCount] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetPcount(this clsPaperEN objPaperEN, int intPcount, string strComparisonOp = "")
		{
			objPaperEN.Pcount = intPcount; //读写数
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.Pcount) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.Pcount, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.Pcount] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN Setscore(this clsPaperEN objPaperEN, float fltscore, string strComparisonOp = "")
		{
			objPaperEN.score = fltscore; //评分
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.score) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.score, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.score] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetStuScore(this clsPaperEN objPaperEN, float fltStuScore, string strComparisonOp = "")
		{
			objPaperEN.StuScore = fltStuScore; //学生平均分
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.StuScore) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.StuScore, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.StuScore] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetTeaScore(this clsPaperEN objPaperEN, float fltTeaScore, string strComparisonOp = "")
		{
			objPaperEN.TeaScore = fltTeaScore; //教师评分
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.TeaScore) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.TeaScore, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.TeaScore] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetPaperTypeId(this clsPaperEN objPaperEN, string strPaperTypeId, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldLen(strPaperTypeId, 2, conPaper.PaperTypeId);
			clsCheckSql.CheckFieldForeignKey(strPaperTypeId, 2, conPaper.PaperTypeId);
			objPaperEN.PaperTypeId = strPaperTypeId; //论文类型Id
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.PaperTypeId) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.PaperTypeId, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.PaperTypeId] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetPaperStatusId(this clsPaperEN objPaperEN, string strPaperStatusId, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldLen(strPaperStatusId, 2, conPaper.PaperStatusId);
			clsCheckSql.CheckFieldForeignKey(strPaperStatusId, 2, conPaper.PaperStatusId);
			objPaperEN.PaperStatusId = strPaperStatusId; //论文状态Id
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.PaperStatusId) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.PaperStatusId, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.PaperStatusId] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetVersionCount(this clsPaperEN objPaperEN, int intVersionCount, string strComparisonOp = "")
		{
			objPaperEN.VersionCount = intVersionCount; //版本统计
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.VersionCount) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.VersionCount, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.VersionCount] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetIsPublic(this clsPaperEN objPaperEN, bool bolIsPublic, string strComparisonOp = "")
		{
			objPaperEN.IsPublic = bolIsPublic; //是否公开
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.IsPublic) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.IsPublic, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.IsPublic] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetAskQuestion(this clsPaperEN objPaperEN, string strAskQuestion, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldLen(strAskQuestion, 5000, conPaper.AskQuestion);
			objPaperEN.AskQuestion = strAskQuestion; //问题提出
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.AskQuestion) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.AskQuestion, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.AskQuestion] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetResearchStatus(this clsPaperEN objPaperEN, string strResearchStatus, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldLen(strResearchStatus, 5000, conPaper.ResearchStatus);
			objPaperEN.ResearchStatus = strResearchStatus; //目前研究的现状
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.ResearchStatus) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.ResearchStatus, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.ResearchStatus] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetInnovationPoints(this clsPaperEN objPaperEN, string strInnovationPoints, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldLen(strInnovationPoints, 5000, conPaper.InnovationPoints);
			objPaperEN.InnovationPoints = strInnovationPoints; //创新点
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.InnovationPoints) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.InnovationPoints, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.InnovationPoints] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetResearchDesign(this clsPaperEN objPaperEN, string strResearchDesign, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldLen(strResearchDesign, 5000, conPaper.ResearchDesign);
			objPaperEN.ResearchDesign = strResearchDesign; //研究设计
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.ResearchDesign) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.ResearchDesign, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.ResearchDesign] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetDimensionDataProcess(this clsPaperEN objPaperEN, string strDimensionDataProcess, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldLen(strDimensionDataProcess, 5000, conPaper.DimensionDataProcess);
			objPaperEN.DimensionDataProcess = strDimensionDataProcess; //数据处理的维度
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.DimensionDataProcess) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.DimensionDataProcess, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.DimensionDataProcess] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetExpectedConclusion(this clsPaperEN objPaperEN, string strExpectedConclusion, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldLen(strExpectedConclusion, 5000, conPaper.ExpectedConclusion);
			objPaperEN.ExpectedConclusion = strExpectedConclusion; //预期结论
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.ExpectedConclusion) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.ExpectedConclusion, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.ExpectedConclusion] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetShareId(this clsPaperEN objPaperEN, string strShareId, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldLen(strShareId, 2, conPaper.ShareId);
			clsCheckSql.CheckFieldForeignKey(strShareId, 2, conPaper.ShareId);
			objPaperEN.ShareId = strShareId; //分享Id
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.ShareId) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.ShareId, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.ShareId] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetPaperQCount(this clsPaperEN objPaperEN, int intPaperQCount, string strComparisonOp = "")
		{
			objPaperEN.PaperQCount = intPaperQCount; //论文答疑数
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.PaperQCount) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.PaperQCount, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.PaperQCount] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetSubVCount(this clsPaperEN objPaperEN, int intSubVCount, string strComparisonOp = "")
		{
			objPaperEN.SubVCount = intSubVCount; //论文子观点数
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.SubVCount) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.SubVCount, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.SubVCount] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetTagsCount(this clsPaperEN objPaperEN, int intTagsCount, string strComparisonOp = "")
		{
			objPaperEN.TagsCount = intTagsCount; //论文标注数
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.TagsCount) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.TagsCount, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.TagsCount] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetTeaQCount(this clsPaperEN objPaperEN, int intTeaQCount, string strComparisonOp = "")
		{
			objPaperEN.TeaQCount = intTeaQCount; //教师提问数
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.TeaQCount) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.TeaQCount, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.TeaQCount] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetCreateDate(this clsPaperEN objPaperEN, string strCreateDate, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldLen(strCreateDate, 20, conPaper.CreateDate);
			objPaperEN.CreateDate = strCreateDate; //建立日期
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.CreateDate) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.CreateDate, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.CreateDate] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetUpdUser(this clsPaperEN objPaperEN, string strUpdUser, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldLen(strUpdUser, 20, conPaper.UpdUser);
			objPaperEN.UpdUser = strUpdUser; //修改人
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.UpdUser) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.UpdUser, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.UpdUser] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetUpdDate(this clsPaperEN objPaperEN, string strUpdDate, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldLen(strUpdDate, 20, conPaper.UpdDate);
			objPaperEN.UpdDate = strUpdDate; //修改日期
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.UpdDate) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.UpdDate, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.UpdDate] = strComparisonOp;
				}
			}
			return objPaperEN;
		}
		/// <summary>
		/// /// 功能:为对象设置字段值
		/// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
		/// </summary>
		/// <param name = "objPaperEN">需要设置字段值的实体对象</param>
		/// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
		/// <returns>返回对象，可以继续连写</returns>
		public static clsPaperEN SetMemo(this clsPaperEN objPaperEN, string strMemo, string strComparisonOp = "")
		{
			clsCheckSql.CheckFieldLen(strMemo, 1000, conPaper.Memo);
			objPaperEN.Memo = strMemo; //备注
			if (string.IsNullOrEmpty(strComparisonOp) == false)
			{
				if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.Memo) == false)
				{
					objPaperEN.dicFldComparisonOp.Add(conPaper.Memo, strComparisonOp);
				}
				else
				{
					objPaperEN.dicFldComparisonOp[conPaper.Memo] = strComparisonOp;
				}
			}
			return objPaperEN;
		}

		/// <summary>
		/// 根据条件对象中的字段内容组合成一个条件串
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
		/// </summary>
		/// <returns>条件串(strWhereCond)</returns>
		public static string GetCombineCondition(this clsPaperEN objPaper_Cond)
		{
			//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
			//例如 1 = 1 && UserName = '张三'
			string strWhereCond = " 1 = 1 ";
			//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
			if (objPaper_Cond.IsUpdated(conPaper.PaperId) == true)
			{
				string strComparisonOp_PaperId = objPaper_Cond.dicFldComparisonOp[conPaper.PaperId];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.PaperId, objPaper_Cond.PaperId, strComparisonOp_PaperId);
			}
			if (objPaper_Cond.IsUpdated(conPaper.PaperTitle) == true)
			{
				string strComparisonOp_PaperTitle = objPaper_Cond.dicFldComparisonOp[conPaper.PaperTitle];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.PaperTitle, objPaper_Cond.PaperTitle, strComparisonOp_PaperTitle);
			}
			//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
			if (objPaper_Cond.IsUpdated(conPaper.Periodical) == true)
			{
				string strComparisonOp_Periodical = objPaper_Cond.dicFldComparisonOp[conPaper.Periodical];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.Periodical, objPaper_Cond.Periodical, strComparisonOp_Periodical);
			}
			if (objPaper_Cond.IsUpdated(conPaper.Author) == true)
			{
				string strComparisonOp_Author = objPaper_Cond.dicFldComparisonOp[conPaper.Author];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.Author, objPaper_Cond.Author, strComparisonOp_Author);
			}
			if (objPaper_Cond.IsUpdated(conPaper.ResearchQuestion) == true)
			{
				string strComparisonOp_ResearchQuestion = objPaper_Cond.dicFldComparisonOp[conPaper.ResearchQuestion];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.ResearchQuestion, objPaper_Cond.ResearchQuestion, strComparisonOp_ResearchQuestion);
			}
			if (objPaper_Cond.IsUpdated(conPaper.Keyword) == true)
			{
				string strComparisonOp_Keyword = objPaper_Cond.dicFldComparisonOp[conPaper.Keyword];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.Keyword, objPaper_Cond.Keyword, strComparisonOp_Keyword);
			}
			if (objPaper_Cond.IsUpdated(conPaper.LiteratureSources) == true)
			{
				string strComparisonOp_LiteratureSources = objPaper_Cond.dicFldComparisonOp[conPaper.LiteratureSources];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.LiteratureSources, objPaper_Cond.LiteratureSources, strComparisonOp_LiteratureSources);
			}
			if (objPaper_Cond.IsUpdated(conPaper.LiteratureLink) == true)
			{
				string strComparisonOp_LiteratureLink = objPaper_Cond.dicFldComparisonOp[conPaper.LiteratureLink];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.LiteratureLink, objPaper_Cond.LiteratureLink, strComparisonOp_LiteratureLink);
			}
			if (objPaper_Cond.IsUpdated(conPaper.UploadfileUrl) == true)
			{
				string strComparisonOp_UploadfileUrl = objPaper_Cond.dicFldComparisonOp[conPaper.UploadfileUrl];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.UploadfileUrl, objPaper_Cond.UploadfileUrl, strComparisonOp_UploadfileUrl);
			}
			if (objPaper_Cond.IsUpdated(conPaper.IsQuotethesis) == true)
			{
				if (objPaper_Cond.IsQuotethesis == true)
				{
					strWhereCond += string.Format(" And {0} = '1'", conPaper.IsQuotethesis);
				}
				else
				{
					strWhereCond += string.Format(" And {0} = '0'", conPaper.IsQuotethesis);
				}
			}
			if (objPaper_Cond.IsUpdated(conPaper.QuoteId) == true)
			{
				string strComparisonOp_QuoteId = objPaper_Cond.dicFldComparisonOp[conPaper.QuoteId];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.QuoteId, objPaper_Cond.QuoteId, strComparisonOp_QuoteId);
			}
			if (objPaper_Cond.IsUpdated(conPaper.IsChecked) == true)
			{
				if (objPaper_Cond.IsChecked == true)
				{
					strWhereCond += string.Format(" And {0} = '1'", conPaper.IsChecked);
				}
				else
				{
					strWhereCond += string.Format(" And {0} = '0'", conPaper.IsChecked);
				}
			}
			if (objPaper_Cond.IsUpdated(conPaper.Checker) == true)
			{
				string strComparisonOp_Checker = objPaper_Cond.dicFldComparisonOp[conPaper.Checker];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.Checker, objPaper_Cond.Checker, strComparisonOp_Checker);
			}
			if (objPaper_Cond.IsUpdated(conPaper.LiteratureTypeId) == true)
			{
				string strComparisonOp_LiteratureTypeId = objPaper_Cond.dicFldComparisonOp[conPaper.LiteratureTypeId];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.LiteratureTypeId, objPaper_Cond.LiteratureTypeId, strComparisonOp_LiteratureTypeId);
			}
			if (objPaper_Cond.IsUpdated(conPaper.BrowseNumber) == true)
			{
				string strComparisonOp_BrowseNumber = objPaper_Cond.dicFldComparisonOp[conPaper.BrowseNumber];
				strWhereCond += string.Format(" And {0} {2} {1}", conPaper.BrowseNumber, objPaper_Cond.BrowseNumber, strComparisonOp_BrowseNumber);
			}
			if (objPaper_Cond.IsUpdated(conPaper.IsSubmit) == true)
			{
				if (objPaper_Cond.IsSubmit == true)
				{
					strWhereCond += string.Format(" And {0} = '1'", conPaper.IsSubmit);
				}
				else
				{
					strWhereCond += string.Format(" And {0} = '0'", conPaper.IsSubmit);
				}
			}
			if (objPaper_Cond.IsUpdated(conPaper.AppraiseCount) == true)
			{
				string strComparisonOp_AppraiseCount = objPaper_Cond.dicFldComparisonOp[conPaper.AppraiseCount];
				strWhereCond += string.Format(" And {0} {2} {1}", conPaper.AppraiseCount, objPaper_Cond.AppraiseCount, strComparisonOp_AppraiseCount);
			}
			if (objPaper_Cond.IsUpdated(conPaper.AttachmentCount) == true)
			{
				string strComparisonOp_AttachmentCount = objPaper_Cond.dicFldComparisonOp[conPaper.AttachmentCount];
				strWhereCond += string.Format(" And {0} {2} {1}", conPaper.AttachmentCount, objPaper_Cond.AttachmentCount, strComparisonOp_AttachmentCount);
			}
			if (objPaper_Cond.IsUpdated(conPaper.CollectionCount) == true)
			{
				string strComparisonOp_CollectionCount = objPaper_Cond.dicFldComparisonOp[conPaper.CollectionCount];
				strWhereCond += string.Format(" And {0} {2} {1}", conPaper.CollectionCount, objPaper_Cond.CollectionCount, strComparisonOp_CollectionCount);
			}
			if (objPaper_Cond.IsUpdated(conPaper.DownloadCount) == true)
			{
				string strComparisonOp_DownloadCount = objPaper_Cond.dicFldComparisonOp[conPaper.DownloadCount];
				strWhereCond += string.Format(" And {0} {2} {1}", conPaper.DownloadCount, objPaper_Cond.DownloadCount, strComparisonOp_DownloadCount);
			}
			if (objPaper_Cond.IsUpdated(conPaper.OkCount) == true)
			{
				string strComparisonOp_OkCount = objPaper_Cond.dicFldComparisonOp[conPaper.OkCount];
				strWhereCond += string.Format(" And {0} {2} {1}", conPaper.OkCount, objPaper_Cond.OkCount, strComparisonOp_OkCount);
			}
			if (objPaper_Cond.IsUpdated(conPaper.Pcount) == true)
			{
				string strComparisonOp_Pcount = objPaper_Cond.dicFldComparisonOp[conPaper.Pcount];
				strWhereCond += string.Format(" And {0} {2} {1}", conPaper.Pcount, objPaper_Cond.Pcount, strComparisonOp_Pcount);
			}
			if (objPaper_Cond.IsUpdated(conPaper.score) == true)
			{
				string strComparisonOp_score = objPaper_Cond.dicFldComparisonOp[conPaper.score];
				strWhereCond += string.Format(" And {0} {2} {1}", conPaper.score, objPaper_Cond.score, strComparisonOp_score);
			}
			if (objPaper_Cond.IsUpdated(conPaper.StuScore) == true)
			{
				string strComparisonOp_StuScore = objPaper_Cond.dicFldComparisonOp[conPaper.StuScore];
				strWhereCond += string.Format(" And {0} {2} {1}", conPaper.StuScore, objPaper_Cond.StuScore, strComparisonOp_StuScore);
			}
			if (objPaper_Cond.IsUpdated(conPaper.TeaScore) == true)
			{
				string strComparisonOp_TeaScore = objPaper_Cond.dicFldComparisonOp[conPaper.TeaScore];
				strWhereCond += string.Format(" And {0} {2} {1}", conPaper.TeaScore, objPaper_Cond.TeaScore, strComparisonOp_TeaScore);
			}
			if (objPaper_Cond.IsUpdated(conPaper.PaperTypeId) == true)
			{
				string strComparisonOp_PaperTypeId = objPaper_Cond.dicFldComparisonOp[conPaper.PaperTypeId];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.PaperTypeId, objPaper_Cond.PaperTypeId, strComparisonOp_PaperTypeId);
			}
			if (objPaper_Cond.IsUpdated(conPaper.PaperStatusId) == true)
			{
				string strComparisonOp_PaperStatusId = objPaper_Cond.dicFldComparisonOp[conPaper.PaperStatusId];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.PaperStatusId, objPaper_Cond.PaperStatusId, strComparisonOp_PaperStatusId);
			}
			if (objPaper_Cond.IsUpdated(conPaper.VersionCount) == true)
			{
				string strComparisonOp_VersionCount = objPaper_Cond.dicFldComparisonOp[conPaper.VersionCount];
				strWhereCond += string.Format(" And {0} {2} {1}", conPaper.VersionCount, objPaper_Cond.VersionCount, strComparisonOp_VersionCount);
			}
			if (objPaper_Cond.IsUpdated(conPaper.IsPublic) == true)
			{
				if (objPaper_Cond.IsPublic == true)
				{
					strWhereCond += string.Format(" And {0} = '1'", conPaper.IsPublic);
				}
				else
				{
					strWhereCond += string.Format(" And {0} = '0'", conPaper.IsPublic);
				}
			}
			if (objPaper_Cond.IsUpdated(conPaper.AskQuestion) == true)
			{
				string strComparisonOp_AskQuestion = objPaper_Cond.dicFldComparisonOp[conPaper.AskQuestion];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.AskQuestion, objPaper_Cond.AskQuestion, strComparisonOp_AskQuestion);
			}
			if (objPaper_Cond.IsUpdated(conPaper.ResearchStatus) == true)
			{
				string strComparisonOp_ResearchStatus = objPaper_Cond.dicFldComparisonOp[conPaper.ResearchStatus];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.ResearchStatus, objPaper_Cond.ResearchStatus, strComparisonOp_ResearchStatus);
			}
			if (objPaper_Cond.IsUpdated(conPaper.InnovationPoints) == true)
			{
				string strComparisonOp_InnovationPoints = objPaper_Cond.dicFldComparisonOp[conPaper.InnovationPoints];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.InnovationPoints, objPaper_Cond.InnovationPoints, strComparisonOp_InnovationPoints);
			}
			if (objPaper_Cond.IsUpdated(conPaper.ResearchDesign) == true)
			{
				string strComparisonOp_ResearchDesign = objPaper_Cond.dicFldComparisonOp[conPaper.ResearchDesign];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.ResearchDesign, objPaper_Cond.ResearchDesign, strComparisonOp_ResearchDesign);
			}
			if (objPaper_Cond.IsUpdated(conPaper.DimensionDataProcess) == true)
			{
				string strComparisonOp_DimensionDataProcess = objPaper_Cond.dicFldComparisonOp[conPaper.DimensionDataProcess];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.DimensionDataProcess, objPaper_Cond.DimensionDataProcess, strComparisonOp_DimensionDataProcess);
			}
			if (objPaper_Cond.IsUpdated(conPaper.ExpectedConclusion) == true)
			{
				string strComparisonOp_ExpectedConclusion = objPaper_Cond.dicFldComparisonOp[conPaper.ExpectedConclusion];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.ExpectedConclusion, objPaper_Cond.ExpectedConclusion, strComparisonOp_ExpectedConclusion);
			}
			if (objPaper_Cond.IsUpdated(conPaper.ShareId) == true)
			{
				string strComparisonOp_ShareId = objPaper_Cond.dicFldComparisonOp[conPaper.ShareId];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.ShareId, objPaper_Cond.ShareId, strComparisonOp_ShareId);
			}
			if (objPaper_Cond.IsUpdated(conPaper.PaperQCount) == true)
			{
				string strComparisonOp_PaperQCount = objPaper_Cond.dicFldComparisonOp[conPaper.PaperQCount];
				strWhereCond += string.Format(" And {0} {2} {1}", conPaper.PaperQCount, objPaper_Cond.PaperQCount, strComparisonOp_PaperQCount);
			}
			if (objPaper_Cond.IsUpdated(conPaper.SubVCount) == true)
			{
				string strComparisonOp_SubVCount = objPaper_Cond.dicFldComparisonOp[conPaper.SubVCount];
				strWhereCond += string.Format(" And {0} {2} {1}", conPaper.SubVCount, objPaper_Cond.SubVCount, strComparisonOp_SubVCount);
			}
			if (objPaper_Cond.IsUpdated(conPaper.TagsCount) == true)
			{
				string strComparisonOp_TagsCount = objPaper_Cond.dicFldComparisonOp[conPaper.TagsCount];
				strWhereCond += string.Format(" And {0} {2} {1}", conPaper.TagsCount, objPaper_Cond.TagsCount, strComparisonOp_TagsCount);
			}
			if (objPaper_Cond.IsUpdated(conPaper.TeaQCount) == true)
			{
				string strComparisonOp_TeaQCount = objPaper_Cond.dicFldComparisonOp[conPaper.TeaQCount];
				strWhereCond += string.Format(" And {0} {2} {1}", conPaper.TeaQCount, objPaper_Cond.TeaQCount, strComparisonOp_TeaQCount);
			}
			if (objPaper_Cond.IsUpdated(conPaper.CreateDate) == true)
			{
				string strComparisonOp_CreateDate = objPaper_Cond.dicFldComparisonOp[conPaper.CreateDate];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.CreateDate, objPaper_Cond.CreateDate, strComparisonOp_CreateDate);
			}
			if (objPaper_Cond.IsUpdated(conPaper.UpdUser) == true)
			{
				string strComparisonOp_UpdUser = objPaper_Cond.dicFldComparisonOp[conPaper.UpdUser];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.UpdUser, objPaper_Cond.UpdUser, strComparisonOp_UpdUser);
			}
			if (objPaper_Cond.IsUpdated(conPaper.UpdDate) == true)
			{
				string strComparisonOp_UpdDate = objPaper_Cond.dicFldComparisonOp[conPaper.UpdDate];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.UpdDate, objPaper_Cond.UpdDate, strComparisonOp_UpdDate);
			}
			if (objPaper_Cond.IsUpdated(conPaper.Memo) == true)
			{
				string strComparisonOp_Memo = objPaper_Cond.dicFldComparisonOp[conPaper.Memo];
				strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.Memo, objPaper_Cond.Memo, strComparisonOp_Memo);
			}
			return strWhereCond;
		}

		/// <summary>
		/// /// 功能:通过SQL命令来修改记录,该方式是优化方式
		/// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
		/// </summary>
		/// <param name = "objPaperEN">需要添加的实体对象</param>
		/// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
		public static bool Update(this clsPaperEN objPaperEN)
		{
			if (string.IsNullOrEmpty(objPaperEN.PaperId) == true)
			{
				string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
				clsStackTrace.GetCurrClassFunction());
				throw new Exception(strMsg);
			}
			try
			{
				objPaperEN.sf_UpdFldSetStr = objPaperEN.getsf_UpdFldSetStr();
				clsPaperWApi.CheckPropertyNew(objPaperEN);
				bool bolResult = clsPaperWApi.UpdateRecord(objPaperEN);
				// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
				clsPaperWApi.ReFreshCache();
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
		/// 检查唯一性(Uniqueness)--Paper(论文表), 如果不唯一,即存在相同的记录,就返回False
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
		/// </summary>
		/// <param name = "objPaperEN">要求唯一的对象</param>
		/// <returns></returns>
		public static string GetUniConditionStr_PaperTitle_Author(this clsPaperEN objPaperEN)
		{
			//检测记录是否存在
			StringBuilder sbCondition = new StringBuilder();
			if (objPaperEN == null) return "";
			if (objPaperEN.PaperId == null || objPaperEN.PaperId == "")
			{
				sbCondition.AppendFormat("1 = 1");
				sbCondition.AppendFormat(" and PaperTitle = '{0}'", objPaperEN.PaperTitle);
				sbCondition.AppendFormat(" and Author = '{0}'", objPaperEN.Author);
				return sbCondition.ToString();
			}
			else
			{
				sbCondition.AppendFormat("PaperId !=  '{0}'", objPaperEN.PaperId);
				sbCondition.AppendFormat(" and PaperTitle = '{0}'", objPaperEN.PaperTitle);
				sbCondition.AppendFormat(" and Author = '{0}'", objPaperEN.Author);
				return sbCondition.ToString();
			}
		}

		/// <summary>
		/// /// 功能:通过SQL命令来插入记录,该方式是优化方式
		/// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
		/// </summary>
		/// <param name = "objPaperEN">需要添加的实体对象</param>
		/// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
		public static bool AddNewRecord(this clsPaperEN objPaperEN)
		{
			try
			{
				if (string.IsNullOrEmpty(objPaperEN.PaperId) == true || clsPaperWApi.IsExist(objPaperEN.PaperId) == true)
				{
					objPaperEN.PaperId = clsPaperWApi.GetMaxStrId();
				}
				clsPaperWApi.CheckPropertyNew(objPaperEN);
				bool bolResult = clsPaperWApi.AddNewRecord(objPaperEN);
				// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
				clsPaperWApi.ReFreshCache();
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
		/// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
		/// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
		/// </summary>
		/// <param name = "objPaperEN">需要添加的实体对象</param>
		/// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
		public static string AddNewRecordWithMaxId(this clsPaperEN objPaperEN)
		{
			try
			{
				clsPaperWApi.CheckPropertyNew(objPaperEN);
				string strPaperId = clsPaperWApi.AddNewRecordWithMaxId(objPaperEN);
				// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
				clsPaperWApi.ReFreshCache();
				return strPaperId;
			}
			catch (Exception objException)
			{
				string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
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
		/// <param name = "objPaperEN">需要修改的对象</param>
		/// <param name = "strWhereCond">修改记录时的条件</param>
		/// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
		public static bool UpdateWithCondition(this clsPaperEN objPaperEN, string strWhereCond)
		{
			try
			{
				clsPaperWApi.CheckPropertyNew(objPaperEN);
				bool bolResult = clsPaperWApi.UpdateWithCondition(objPaperEN, strWhereCond);
				// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
				clsPaperWApi.ReFreshCache();
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
	/// 论文表(Paper)
	/// (AutoGCLib.WA_Access4CSharp:GeneCode)
	/// </summary>
	public class clsPaperWApi
	{
		private static readonly string mstrApiControllerName = "PaperApi";

		/// <summary>
		/// 专门在逻辑层用于处理缓存等公共函数的对象
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
		/// </summary>
		public static clsCommFun4BL objCommFun4BL = null;

		public clsPaperWApi()
		{
		}

		/// <summary>
		/// 绑定基于Win的下拉框
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
		/// </summary>
		/// <param name = "objComboBox">需要绑定当前表的下拉框</param>
		public static void BindCbo_PaperId(System.Windows.Forms.ComboBox objComboBox)
		{
			//为数据源为表的下拉框设置内容
			string strCondition = string.Format("1 =1 Order By {0}", conPaper.PaperId);
			List<clsPaperEN> arrObjLst = clsPaperWApi.GetObjLst(strCondition);
			//初始化一个对象列表
			//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
			clsPaperEN objPaperEN = new clsPaperEN()
			{
				PaperId = "0",
				PaperTitle = "选[论文表]..."
			};
			arrObjLst.Insert(0, objPaperEN);
			//设置下拉框的数据源、以及设置值项、显示项
			objComboBox.ValueMember = conPaper.PaperId;
			objComboBox.DisplayMember = conPaper.PaperTitle;
			objComboBox.DataSource = arrObjLst;
			objComboBox.SelectedIndex = 0;
		}

		/// <summary>
		/// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
		/// </summary>
		public static void CheckPropertyNew(clsPaperEN objPaperEN)
		{
			if (!Object.Equals(null, objPaperEN.PaperId) && GetStrLen(objPaperEN.PaperId) > 8)
			{
				throw new Exception("字段[论文Id]的长度不能超过8!");
			}
			if (!Object.Equals(null, objPaperEN.PaperTitle) && GetStrLen(objPaperEN.PaperTitle) > 500)
			{
				throw new Exception("字段[论文标题]的长度不能超过500!");
			}
			if (!Object.Equals(null, objPaperEN.Periodical) && GetStrLen(objPaperEN.Periodical) > 100)
			{
				throw new Exception("字段[期刊]的长度不能超过100!");
			}
			if (!Object.Equals(null, objPaperEN.Author) && GetStrLen(objPaperEN.Author) > 200)
			{
				throw new Exception("字段[作者]的长度不能超过200!");
			}
			if (!Object.Equals(null, objPaperEN.ResearchQuestion) && GetStrLen(objPaperEN.ResearchQuestion) > 2000)
			{
				throw new Exception("字段[研究问题]的长度不能超过2000!");
			}
			if (!Object.Equals(null, objPaperEN.Keyword) && GetStrLen(objPaperEN.Keyword) > 1000)
			{
				throw new Exception("字段[关键字]的长度不能超过1000!");
			}
			if (!Object.Equals(null, objPaperEN.LiteratureSources) && GetStrLen(objPaperEN.LiteratureSources) > 1000)
			{
				throw new Exception("字段[文献来源]的长度不能超过1000!");
			}
			if (!Object.Equals(null, objPaperEN.LiteratureLink) && GetStrLen(objPaperEN.LiteratureLink) > 1000)
			{
				throw new Exception("字段[文献链接]的长度不能超过1000!");
			}
			if (!Object.Equals(null, objPaperEN.UploadfileUrl) && GetStrLen(objPaperEN.UploadfileUrl) > 1000)
			{
				throw new Exception("字段[文件地址]的长度不能超过1000!");
			}
			if (!Object.Equals(null, objPaperEN.QuoteId) && GetStrLen(objPaperEN.QuoteId) > 8)
			{
				throw new Exception("字段[引用Id]的长度不能超过8!");
			}
			if (!Object.Equals(null, objPaperEN.Checker) && GetStrLen(objPaperEN.Checker) > 20)
			{
				throw new Exception("字段[审核人]的长度不能超过20!");
			}
			if (!Object.Equals(null, objPaperEN.LiteratureTypeId) && GetStrLen(objPaperEN.LiteratureTypeId) > 2)
			{
				throw new Exception("字段[作文类型Id]的长度不能超过2!");
			}
			if (!Object.Equals(null, objPaperEN.PaperTypeId) && GetStrLen(objPaperEN.PaperTypeId) > 2)
			{
				throw new Exception("字段[论文类型Id]的长度不能超过2!");
			}
			if (!Object.Equals(null, objPaperEN.PaperStatusId) && GetStrLen(objPaperEN.PaperStatusId) > 2)
			{
				throw new Exception("字段[论文状态Id]的长度不能超过2!");
			}
			if (!Object.Equals(null, objPaperEN.AskQuestion) && GetStrLen(objPaperEN.AskQuestion) > 5000)
			{
				throw new Exception("字段[问题提出]的长度不能超过5000!");
			}
			if (!Object.Equals(null, objPaperEN.ResearchStatus) && GetStrLen(objPaperEN.ResearchStatus) > 5000)
			{
				throw new Exception("字段[目前研究的现状]的长度不能超过5000!");
			}
			if (!Object.Equals(null, objPaperEN.InnovationPoints) && GetStrLen(objPaperEN.InnovationPoints) > 5000)
			{
				throw new Exception("字段[创新点]的长度不能超过5000!");
			}
			if (!Object.Equals(null, objPaperEN.ResearchDesign) && GetStrLen(objPaperEN.ResearchDesign) > 5000)
			{
				throw new Exception("字段[研究设计]的长度不能超过5000!");
			}
			if (!Object.Equals(null, objPaperEN.DimensionDataProcess) && GetStrLen(objPaperEN.DimensionDataProcess) > 5000)
			{
				throw new Exception("字段[数据处理的维度]的长度不能超过5000!");
			}
			if (!Object.Equals(null, objPaperEN.ExpectedConclusion) && GetStrLen(objPaperEN.ExpectedConclusion) > 5000)
			{
				throw new Exception("字段[预期结论]的长度不能超过5000!");
			}
			if (!Object.Equals(null, objPaperEN.ShareId) && GetStrLen(objPaperEN.ShareId) > 2)
			{
				throw new Exception("字段[分享Id]的长度不能超过2!");
			}
			if (!Object.Equals(null, objPaperEN.CreateDate) && GetStrLen(objPaperEN.CreateDate) > 20)
			{
				throw new Exception("字段[建立日期]的长度不能超过20!");
			}
			if (!Object.Equals(null, objPaperEN.UpdUser) && GetStrLen(objPaperEN.UpdUser) > 20)
			{
				throw new Exception("字段[修改人]的长度不能超过20!");
			}
			if (!Object.Equals(null, objPaperEN.UpdDate) && GetStrLen(objPaperEN.UpdDate) > 20)
			{
				throw new Exception("字段[修改日期]的长度不能超过20!");
			}
			if (!Object.Equals(null, objPaperEN.Memo) && GetStrLen(objPaperEN.Memo) > 1000)
			{
				throw new Exception("字段[备注]的长度不能超过1000!");
			}
			objPaperEN._IsCheckProperty = true;
		}

		/// <summary>
		/// 获取当前关键字的记录对象,用对象的形式表示.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
		/// </summary>
		/// <param name = "strPaperId">表关键字</param>
		/// <returns>表对象</returns>
		public static clsPaperEN GetObjByPaperId(string strPaperId)
		{
			string strAction = "GetObjByPaperId";
			string strErrMsg = string.Empty;
			string strResult = "";
			clsPaperEN objPaperEN = null;
			Dictionary<string, string> dictParam = new Dictionary<string, string>()
			{
				["PaperId"] = strPaperId
			};
			try
			{
				if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
				{
					JObject jobjReturn = JObject.Parse(strResult);
					if ((int)jobjReturn["ErrorId"] == 0)
					{
						objPaperEN = JsonConvert.DeserializeObject<clsPaperEN>((string)jobjReturn["ReturnObj"]);
						return objPaperEN;
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
		/// <param name = "strPaperId">表关键字</param>
		/// <returns>表对象</returns>
		public static clsPaperEN GetObjByPaperId_WA_Cache(string strPaperId)
		{
			string strAction = "GetObjByPaperId_Cache";
			string strErrMsg = string.Empty;
			string strResult = "";
			clsPaperEN objPaperEN = null;
			Dictionary<string, string> dictParam = new Dictionary<string, string>()
			{
				["PaperId"] = strPaperId
			};
			try
			{
				if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
				{
					JObject jobjReturn = JObject.Parse(strResult);
					if ((int)jobjReturn["ErrorId"] == 0)
					{
						objPaperEN = JsonConvert.DeserializeObject<clsPaperEN>((string)jobjReturn["ReturnObj"]);
						return objPaperEN;
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
		public static string GetFirstID(string strWhereCond)
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
		/// 获取当前表满足条件的第一条记录的对象
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
		/// </summary>
		/// <param name = "strWhereCond">条件串</param>
		/// <returns>返回的第一条记录的关键字值</returns>
		public static clsPaperEN GetFirstObj(string strWhereCond)
		{
			string strAction = "GetFirstObj";
			string strErrMsg = string.Empty;
			string strResult = "";
			clsPaperEN objPaperEN = null;
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
						objPaperEN = JsonConvert.DeserializeObject<clsPaperEN>((string)jobjReturn["ReturnObj"]);
						return objPaperEN;
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
		/// <param name = "strPaperId">所给的关键字</param>
		/// <returns>根据关键字获取的对象</returns>
		public static clsPaperEN GetObjByPaperId_Cache(string strPaperId)
		{
			if (string.IsNullOrEmpty(strPaperId) == true) return null;
			//初始化列表缓存
			string strKey = string.Format("{0}", clsPaperEN._CurrTabName_S);
			List<clsPaperEN> arrPaperObjLst_Cache = GetObjLst_Cache();
			IEnumerable<clsPaperEN> arrPaperObjLst_Sel =
			from objPaperEN in arrPaperObjLst_Cache
			where objPaperEN.PaperId == strPaperId
			select objPaperEN;
			if (arrPaperObjLst_Sel.Count() == 0)
			{
				clsPaperEN obj = clsPaperWApi.GetObjByPaperId(strPaperId);
				if (obj != null)
				{
					CacheHelper.Remove(strKey);
					return obj;
				}
				return null;
			}
			return arrPaperObjLst_Sel.First();
		}

		/// <summary>
		/// 根据条件获取对象列表
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
		/// </summary>
		/// <param name = "strWhereCond">给定条件</param>
		/// <returns>返回对象列表</returns>
		public static List<clsPaperEN> GetObjLst(string strWhereCond)
		{
			List<clsPaperEN> arrObjLst = null;
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
						arrObjLst = JsonConvert.DeserializeObject<List<clsPaperEN>>((string)jobjReturn["ReturnObjLst"]);
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
		public static List<clsPaperEN> GetObjLstByPaperIdLst(List<string> arrPaperId)
		{
			List<clsPaperEN> arrObjLst = null;
			string strAction = "GetObjLstByPaperIdLst";
			string strErrMsg = string.Empty;
			string strResult = "";
			Dictionary<string, string> dictParam = new Dictionary<string, string>();
			try
			{
				string strJSON = clsJSON.GetJsonFromObjLst(arrPaperId);
				if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
				{
					JObject jobjReturn = JObject.Parse(strResult);
					if ((int)jobjReturn["ErrorId"] == 0)
					{
						arrObjLst = JsonConvert.DeserializeObject<List<clsPaperEN>>((string)jobjReturn["ReturnObjLst"]);
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
		/// <param name = "strPaperId">所给的关键字</param>
		/// <returns>根据关键字获取的对象</returns>
		public static IEnumerable<clsPaperEN> GetObjLstByPaperIdLst_Cache(List<string> arrPaperId)
		{
			//初始化列表缓存
			string strKey = string.Format("{0}", clsPaperEN._CurrTabName_S);
			List<clsPaperEN> arrPaperObjLst_Cache = GetObjLst_Cache();
			IEnumerable<clsPaperEN> arrPaperObjLst_Sel =
			from objPaperEN in arrPaperObjLst_Cache
			where arrPaperId.Contains(objPaperEN.PaperId)
			select objPaperEN;
			return arrPaperObjLst_Sel;
		}

		/// <summary>
		/// 根据关键字列表获取对象列表
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
		/// </summary>
		/// <param name = "strWhereCond">给定条件</param>
		/// <returns>返回对象列表</returns>
		public static List<clsPaperEN> GetObjLstByPaperIdLst_WA_Cache(List<string> arrPaperId)
		{
			List<clsPaperEN> arrObjLst = null;
			string strAction = "GetObjLstByPaperIdLst_Cache";
			string strErrMsg = string.Empty;
			string strResult = "";
			Dictionary<string, string> dictParam = new Dictionary<string, string>()
			{
			};
			try
			{
				string strJSON = clsJSON.GetJsonFromObjLst(arrPaperId);
				if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
				{
					JObject jobjReturn = JObject.Parse(strResult);
					if ((int)jobjReturn["ErrorId"] == 0)
					{
						arrObjLst = JsonConvert.DeserializeObject<List<clsPaperEN>>((string)jobjReturn["ReturnObjLst"]);
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
		public static List<clsPaperEN> GetTopObjLst(stuTopPara objTopPara)
		{
			List<clsPaperEN> arrObjLst = null;
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
						arrObjLst = JsonConvert.DeserializeObject<List<clsPaperEN>>((string)jobjReturn["ReturnObjLst"]);
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
		public static List<clsPaperEN> GetObjLstByRange(stuRangePara objRangePara)
		{
			List<clsPaperEN> arrObjLst = null;
			string strAction = "GetObjLstByRange";
			string strErrMsg = string.Empty;
			string strResult = "";
			Dictionary<string, string> dictParam = objRangePara.GetDictParam();
			try
			{
				string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
				if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
				{
					JObject jobjReturn = JObject.Parse(strResult);
					if ((int)jobjReturn["ErrorId"] == 0)
					{
						arrObjLst = JsonConvert.DeserializeObject<List<clsPaperEN>>((string)jobjReturn["ReturnObjLst"]);
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
		public static List<clsPaperEN> GetObjLstByPager(stuPagerPara objPagerPara)
		{
			List<clsPaperEN> arrObjLst = null;
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
						arrObjLst = JsonConvert.DeserializeObject<List<clsPaperEN>>((string)jobjReturn["ReturnObjLst"]);
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
		public static List<clsPaperEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
		{
			List<clsPaperEN> arrObjLst = null;
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
						arrObjLst = JsonConvert.DeserializeObject<List<clsPaperEN>>((string)jobjReturn["ReturnObjLst"]);
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
		public static int DelRecord(string strPaperId)
		{
			string strAction = "DelRecord";
			string strErrMsg = string.Empty;
			string strResult = "";
			try
			{
				clsPaperEN objPaperEN = clsPaperWApi.GetObjByPaperId(strPaperId);
				if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strPaperId.ToString(), out strResult, out strErrMsg) == true)
				{
					JObject jobjReturn = JObject.Parse(strResult);
					if ((int)jobjReturn["ErrorId"] == 0)
					{
						clsPaperWApi.ReFreshCache();
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
		public static int DelPapers(List<string> arrPaperId)
		{
			string strAction = "DelPapers";
			string strErrMsg = string.Empty;
			string strResult = "";
			Dictionary<string, string> dictParam = new Dictionary<string, string>();
			try
			{
				string strJSON = clsJSON.GetJsonFromObjLst(arrPaperId);
				if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
				{
					JObject jobjReturn = JObject.Parse(strResult);
					if ((int)jobjReturn["ErrorId"] == 0)
					{
						clsPaperWApi.ReFreshCache();
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
		public static int DelPapersByCond(string strWhereCond)
		{
			string strAction = "DelPapersByCond";
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
		public static bool AddNewRecord(clsPaperEN objPaperEN)
		{
			string strAction = "AddNewRecord";
			string strErrMsg = string.Empty;
			string strResult = "";
			Dictionary<string, string> dictParam = new Dictionary<string, string>();
			try
			{
				string strJson = clsJSON.GetJsonFromObj<clsPaperEN>(objPaperEN);
				if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
				{
					JObject jobjReturn = JObject.Parse(strResult);
					if ((int)jobjReturn["ErrorId"] == 0)
					{
						// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
						clsPaperWApi.ReFreshCache();
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
		/// 添加记录
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
		/// </summary>
		/// <returns>是否成功?</returns>
		public static string AddNewRecordWithMaxId(clsPaperEN objPaperEN)
		{
			string strAction = "AddNewRecordWithMaxId";
			string strErrMsg = string.Empty;
			string strResult = "";
			Dictionary<string, string> dictParam = new Dictionary<string, string>();
			try
			{
				string strJson = clsJSON.GetJsonFromObj<clsPaperEN>(objPaperEN);
				if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
				{
					JObject jobjReturn = JObject.Parse(strResult);
					if ((int)jobjReturn["ErrorId"] == 0)
					{
						// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
						clsPaperWApi.ReFreshCache();
						var strPaperId = (string)jobjReturn["ReturnStr"];
						return strPaperId;
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
		public static bool UpdateRecord(clsPaperEN objPaperEN)
		{
			if (string.IsNullOrEmpty(objPaperEN.sf_UpdFldSetStr) == true)
			{
				string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
				objPaperEN.PaperId, clsStackTrace.GetCurrClassFunction());
				throw new Exception(strMsg);
			}
			string strAction = "UpdateRecord";
			string strErrMsg = string.Empty;
			string strResult = "";
			Dictionary<string, string> dictParam = new Dictionary<string, string>();
			try
			{
				string strJson = clsJSON.GetJsonFromObj<clsPaperEN>(objPaperEN);
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
		/// <param name = "objPaperEN">需要修改的对象</param>
		/// <param name = "strWhereCond">条件串</param>
		/// <returns>返回的第一条记录的关键字值</returns>
		public static bool UpdateWithCondition(clsPaperEN objPaperEN, string strWhereCond)
		{
			if (string.IsNullOrEmpty(objPaperEN.sf_UpdFldSetStr) == true)
			{
				string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
				objPaperEN.PaperId, clsStackTrace.GetCurrClassFunction());
				throw new Exception(strMsg);
			}
			if (string.IsNullOrEmpty(strWhereCond) == true)
			{
				string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
				objPaperEN.PaperId, clsStackTrace.GetCurrClassFunction());
				throw new Exception(strMsg);
			}
			string strAction = "UpdateWithCondition";
			string strErrMsg = string.Empty;
			string strResult = "";
			Dictionary<string, string> dictParam = new Dictionary<string, string>();
			try
			{
				string strJson = clsJSON.GetJsonFromObj<clsPaperEN>(objPaperEN);
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
		public static bool IsExist(string strPaperId)
		{
			//检测记录是否存在
			string strAction = "IsExist";
			string strErrMsg = string.Empty;
			string strResult = "";
			Dictionary<string, string> dictParam = new Dictionary<string, string>()
			{
				["PaperId"] = strPaperId
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
		/// 获取当前表关键字值的最大值,再加1,避免重复
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
		/// </summary>
		/// <returns>当前表关键字值的最大值,再加1</returns>
		public static string GetMaxStrId()
		{
			string strAction = "GetMaxStrId";
			string strErrMsg = string.Empty;
			string strResult = "";
			Dictionary<string, string> dictParam = new Dictionary<string, string>();
			try
			{
				if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
				{
					JObject jobjReturn = JObject.Parse(strResult);
					if ((int)jobjReturn["ErrorId"] == 0)
					{
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
				string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
				throw new Exception(strMsg);
			}
		}

		/// <summary>
		/// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
		/// </summary>
		/// <returns>当前表关键字值的最大值,再加1</returns>
		public static string GetMaxStrIdByPrefix(string strPrefix)
		{
			//检测记录是否存在
			string strAction = "GetMaxStrIdByPrefix";
			string strErrMsg = string.Empty;
			string strResult = "";
			Dictionary<string, string> dictParam = new Dictionary<string, string>();
			dictParam.Add("strPrefix", strPrefix);
			try
			{
				if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
				{
					JObject jobjReturn = JObject.Parse(strResult);
					if ((int)jobjReturn["ErrorId"] == 0)
					{
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
				string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
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
			int len;
			byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
			len = sarr.Length;//will output as 3+3*2 = 9
			return len;
		}

		/// <summary>
		/// 把同一个类的对象,复制到另一个对象
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
		/// </summary>
		/// <param name = "objPaperENS">源对象</param>
		/// <param name = "objPaperENT">目标对象</param>
		public static void CopyTo(clsPaperEN objPaperENS, clsPaperEN objPaperENT)
		{
			try
			{
				objPaperENT.PaperId = objPaperENS.PaperId; //论文Id
				objPaperENT.PaperTitle = objPaperENS.PaperTitle; //论文标题
				objPaperENT.PaperContent = objPaperENS.PaperContent; //主题内容
				objPaperENT.Periodical = objPaperENS.Periodical; //期刊
				objPaperENT.Author = objPaperENS.Author; //作者
				objPaperENT.ResearchQuestion = objPaperENS.ResearchQuestion; //研究问题
				objPaperENT.Keyword = objPaperENS.Keyword; //关键字
				objPaperENT.LiteratureSources = objPaperENS.LiteratureSources; //文献来源
				objPaperENT.LiteratureLink = objPaperENS.LiteratureLink; //文献链接
				objPaperENT.UploadfileUrl = objPaperENS.UploadfileUrl; //文件地址
				objPaperENT.IsQuotethesis = objPaperENS.IsQuotethesis; //是否引用论文
				objPaperENT.QuoteId = objPaperENS.QuoteId; //引用Id
				objPaperENT.IsChecked = objPaperENS.IsChecked; //是否检查
				objPaperENT.Checker = objPaperENS.Checker; //审核人
				objPaperENT.LiteratureTypeId = objPaperENS.LiteratureTypeId; //作文类型Id
				objPaperENT.BrowseNumber = objPaperENS.BrowseNumber; //浏览量
				objPaperENT.IsSubmit = objPaperENS.IsSubmit; //是否提交
				objPaperENT.AppraiseCount = objPaperENS.AppraiseCount; //评论数
				objPaperENT.AttachmentCount = objPaperENS.AttachmentCount; //附件计数
				objPaperENT.CollectionCount = objPaperENS.CollectionCount; //收藏数
				objPaperENT.DownloadCount = objPaperENS.DownloadCount; //下载数
				objPaperENT.OkCount = objPaperENS.OkCount; //点赞统计
				objPaperENT.Pcount = objPaperENS.Pcount; //读写数
				objPaperENT.score = objPaperENS.score; //评分
				objPaperENT.StuScore = objPaperENS.StuScore; //学生平均分
				objPaperENT.TeaScore = objPaperENS.TeaScore; //教师评分
				objPaperENT.PaperTypeId = objPaperENS.PaperTypeId; //论文类型Id
				objPaperENT.PaperStatusId = objPaperENS.PaperStatusId; //论文状态Id
				objPaperENT.VersionCount = objPaperENS.VersionCount; //版本统计
				objPaperENT.IsPublic = objPaperENS.IsPublic; //是否公开
				objPaperENT.AskQuestion = objPaperENS.AskQuestion; //问题提出
				objPaperENT.ResearchStatus = objPaperENS.ResearchStatus; //目前研究的现状
				objPaperENT.InnovationPoints = objPaperENS.InnovationPoints; //创新点
				objPaperENT.ResearchDesign = objPaperENS.ResearchDesign; //研究设计
				objPaperENT.DimensionDataProcess = objPaperENS.DimensionDataProcess; //数据处理的维度
				objPaperENT.ExpectedConclusion = objPaperENS.ExpectedConclusion; //预期结论
				objPaperENT.ShareId = objPaperENS.ShareId; //分享Id
				objPaperENT.PaperQCount = objPaperENS.PaperQCount; //论文答疑数
				objPaperENT.SubVCount = objPaperENS.SubVCount; //论文子观点数
				objPaperENT.TagsCount = objPaperENS.TagsCount; //论文标注数
				objPaperENT.TeaQCount = objPaperENS.TeaQCount; //教师提问数
				objPaperENT.CreateDate = objPaperENS.CreateDate; //建立日期
				objPaperENT.UpdUser = objPaperENS.UpdUser; //修改人
				objPaperENT.UpdDate = objPaperENS.UpdDate; //修改日期
				objPaperENT.Memo = objPaperENS.Memo; //备注
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
		public static DataTable ToDataTable(List<clsPaperEN> arrObj)
		{
			DataTable dataTable = new DataTable(); //实例化
			DataTable result;
			if (arrObj.Count == 0) return null;
			if (clsPaperEN.AttributeName.Length == 0)
			{
				result = dataTable;
				return result;
			}
			Type type = typeof(clsPaperEN);
			PropertyInfo[] arrPropertyInfo = type.GetProperties();
			try
			{
				//Columns
				foreach (string strAttrName in clsPaperEN.AttributeName)
				{
					PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
					dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
				}
				foreach (clsPaperEN objInFor in arrObj)
				{
					//Rows
					DataRow dataRow = dataTable.NewRow();
					foreach (string strAttrName in clsPaperEN.AttributeName)
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
		/// 刷新本类中的缓存.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
		/// </summary>
		public static void ReFreshThisCache()
		{
			string strMsg = "";
			if (clsSysParaEN.spSetRefreshCacheOn == true)
			{
				string strKey = string.Format("{0}", clsPaperEN._CurrTabName_S);
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
			if (clsPaperWApi.objCommFun4BL != null)
			{
				// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
				string strKey = string.Format("{0}", clsPaperEN._CurrTabName_S);
				CacheHelper.Remove(strKey);
				clsPaperWApi.objCommFun4BL.ReFreshCache();
			}
		}

		/// <summary>
		/// 从缓存中获取所有对象列表.
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
		/// </summary>
		/// <returns>从缓存中获取的所有对象列表</returns>
		public static List<clsPaperEN> GetObjLst_Cache()
		{
			//初始化列表缓存
			string strKey = string.Format("{0}", clsPaperEN._CurrTabName_S);
			List<clsPaperEN> arrPaperObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
			return arrPaperObjLst_Cache;
		}

		/// <summary>
		/// 根据对象列表获取DataTable
		/// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
		/// </summary>
		/// <param name = "arrObjLst">给定的对象列表</param>
		/// <returns>返回DataTable</returns>
		public static DataTable GetDataTableByObjLst(List<clsPaperEN> arrObjLst)
		{
			DataTable objDT = new DataTable();
			objDT.Columns.Add(conPaper.PaperId, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.PaperTitle, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.PaperContent, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.Periodical, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.Author, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.ResearchQuestion, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.Keyword, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.LiteratureSources, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.LiteratureLink, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.UploadfileUrl, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.IsQuotethesis, Type.GetType("System.Boolean"));
			objDT.Columns.Add(conPaper.QuoteId, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.IsChecked, Type.GetType("System.Boolean"));
			objDT.Columns.Add(conPaper.Checker, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.LiteratureTypeId, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.BrowseNumber, Type.GetType("System.Int32"));
			objDT.Columns.Add(conPaper.IsSubmit, Type.GetType("System.Boolean"));
			objDT.Columns.Add(conPaper.AppraiseCount, Type.GetType("System.Int32"));
			objDT.Columns.Add(conPaper.AttachmentCount, Type.GetType("System.Int32"));
			objDT.Columns.Add(conPaper.CollectionCount, Type.GetType("System.Int32"));
			objDT.Columns.Add(conPaper.DownloadCount, Type.GetType("System.Int32"));
			objDT.Columns.Add(conPaper.OkCount, Type.GetType("System.Int32"));
			objDT.Columns.Add(conPaper.Pcount, Type.GetType("System.Int32"));
			objDT.Columns.Add(conPaper.score, Type.GetType("System.Single"));
			objDT.Columns.Add(conPaper.StuScore, Type.GetType("System.Single"));
			objDT.Columns.Add(conPaper.TeaScore, Type.GetType("System.Single"));
			objDT.Columns.Add(conPaper.PaperTypeId, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.PaperStatusId, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.VersionCount, Type.GetType("System.Int32"));
			objDT.Columns.Add(conPaper.IsPublic, Type.GetType("System.Boolean"));
			objDT.Columns.Add(conPaper.AskQuestion, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.ResearchStatus, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.InnovationPoints, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.ResearchDesign, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.DimensionDataProcess, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.ExpectedConclusion, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.ShareId, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.PaperQCount, Type.GetType("System.Int32"));
			objDT.Columns.Add(conPaper.SubVCount, Type.GetType("System.Int32"));
			objDT.Columns.Add(conPaper.TagsCount, Type.GetType("System.Int32"));
			objDT.Columns.Add(conPaper.TeaQCount, Type.GetType("System.Int32"));
			objDT.Columns.Add(conPaper.CreateDate, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.UpdUser, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.UpdDate, Type.GetType("System.String"));
			objDT.Columns.Add(conPaper.Memo, Type.GetType("System.String"));
			foreach (clsPaperEN objInFor in arrObjLst)
			{
				DataRow objDR = objDT.NewRow();
				objDR[conPaper.PaperId] = objInFor[conPaper.PaperId];
				objDR[conPaper.PaperTitle] = objInFor[conPaper.PaperTitle];
				objDR[conPaper.PaperContent] = objInFor[conPaper.PaperContent];
				objDR[conPaper.Periodical] = objInFor[conPaper.Periodical];
				objDR[conPaper.Author] = objInFor[conPaper.Author];
				objDR[conPaper.ResearchQuestion] = objInFor[conPaper.ResearchQuestion];
				objDR[conPaper.Keyword] = objInFor[conPaper.Keyword];
				objDR[conPaper.LiteratureSources] = objInFor[conPaper.LiteratureSources];
				objDR[conPaper.LiteratureLink] = objInFor[conPaper.LiteratureLink];
				objDR[conPaper.UploadfileUrl] = objInFor[conPaper.UploadfileUrl];
				objDR[conPaper.IsQuotethesis] = objInFor[conPaper.IsQuotethesis];
				objDR[conPaper.QuoteId] = objInFor[conPaper.QuoteId];
				objDR[conPaper.IsChecked] = objInFor[conPaper.IsChecked];
				objDR[conPaper.Checker] = objInFor[conPaper.Checker];
				objDR[conPaper.LiteratureTypeId] = objInFor[conPaper.LiteratureTypeId];
				objDR[conPaper.BrowseNumber] = objInFor[conPaper.BrowseNumber];
				objDR[conPaper.IsSubmit] = objInFor[conPaper.IsSubmit];
				objDR[conPaper.AppraiseCount] = objInFor[conPaper.AppraiseCount];
				objDR[conPaper.AttachmentCount] = objInFor[conPaper.AttachmentCount];
				objDR[conPaper.CollectionCount] = objInFor[conPaper.CollectionCount];
				objDR[conPaper.DownloadCount] = objInFor[conPaper.DownloadCount];
				objDR[conPaper.OkCount] = objInFor[conPaper.OkCount];
				objDR[conPaper.Pcount] = objInFor[conPaper.Pcount];
				objDR[conPaper.score] = objInFor[conPaper.score];
				objDR[conPaper.StuScore] = objInFor[conPaper.StuScore];
				objDR[conPaper.TeaScore] = objInFor[conPaper.TeaScore];
				objDR[conPaper.PaperTypeId] = objInFor[conPaper.PaperTypeId];
				objDR[conPaper.PaperStatusId] = objInFor[conPaper.PaperStatusId];
				objDR[conPaper.VersionCount] = objInFor[conPaper.VersionCount];
				objDR[conPaper.IsPublic] = objInFor[conPaper.IsPublic];
				objDR[conPaper.AskQuestion] = objInFor[conPaper.AskQuestion];
				objDR[conPaper.ResearchStatus] = objInFor[conPaper.ResearchStatus];
				objDR[conPaper.InnovationPoints] = objInFor[conPaper.InnovationPoints];
				objDR[conPaper.ResearchDesign] = objInFor[conPaper.ResearchDesign];
				objDR[conPaper.DimensionDataProcess] = objInFor[conPaper.DimensionDataProcess];
				objDR[conPaper.ExpectedConclusion] = objInFor[conPaper.ExpectedConclusion];
				objDR[conPaper.ShareId] = objInFor[conPaper.ShareId];
				objDR[conPaper.PaperQCount] = objInFor[conPaper.PaperQCount];
				objDR[conPaper.SubVCount] = objInFor[conPaper.SubVCount];
				objDR[conPaper.TagsCount] = objInFor[conPaper.TagsCount];
				objDR[conPaper.TeaQCount] = objInFor[conPaper.TeaQCount];
				objDR[conPaper.CreateDate] = objInFor[conPaper.CreateDate];
				objDR[conPaper.UpdUser] = objInFor[conPaper.UpdUser];
				objDR[conPaper.UpdDate] = objInFor[conPaper.UpdDate];
				objDR[conPaper.Memo] = objInFor[conPaper.Memo];
				objDT.Rows.Add(objDR);
			}
			return objDT;
		}
	}
	/// <summary>
	/// 论文表(Paper)
	/// 数据源类型:SQL表
	/// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
	/// </summary>
	public class clsCommFun4WA4Paper : clsCommFun4BL
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
			clsPaperWApi.ReFreshThisCache();
		}
	}

}