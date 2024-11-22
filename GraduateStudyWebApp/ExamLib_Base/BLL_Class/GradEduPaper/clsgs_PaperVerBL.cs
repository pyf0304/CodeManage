
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PaperVerBL
 表名:gs_PaperVer(01120678)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:11:09
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
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
public static class  clsgs_PaperVerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperVId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_PaperVerEN GetObj(this K_PaperVId_gs_PaperVer myKey)
{
clsgs_PaperVerEN objgs_PaperVerEN = clsgs_PaperVerBL.gs_PaperVerDA.GetObjByPaperVId(myKey.Value);
return objgs_PaperVerEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_PaperVerEN objgs_PaperVerEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_PaperVerEN) == false)
{
var strMsg = string.Format("记录已经存在!PaperVId = [{0}]的数据已经存在!(in clsgs_PaperVerBL.AddNewRecord)", objgs_PaperVerEN.PaperVId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsgs_PaperVerBL.gs_PaperVerDA.AddNewRecordBySQL2(objgs_PaperVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperVerBL.ReFreshCache();

if (clsgs_PaperVerBL.relatedActions != null)
{
clsgs_PaperVerBL.relatedActions.UpdRelaTabDate(objgs_PaperVerEN.PaperVId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000082)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 插入记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddRecordEx)
 /// </summary>
 /// <returns>插入记录是否成功？</returns>
public static bool AddRecordEx(this clsgs_PaperVerEN objgs_PaperVerEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
try
{
 //2、检查传进去的对象属性是否合法
objgs_PaperVerEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_PaperVerEN.CheckUniqueness() == false)
{
strMsg = string.Format("(PaperVId(PaperVId)=[{0}])已经存在,不能重复!", objgs_PaperVerEN.PaperVId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objgs_PaperVerEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_PaperVerEN objgs_PaperVerEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_PaperVerEN) == false)
{
var strMsg = string.Format("记录已经存在!PaperVId = [{0}]的数据已经存在!(in clsgs_PaperVerBL.AddNewRecordWithReturnKey)", objgs_PaperVerEN.PaperVId);
throw new Exception(strMsg);
}
try
{
string strKey = clsgs_PaperVerBL.gs_PaperVerDA.AddNewRecordBySQL2WithReturnKey(objgs_PaperVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperVerBL.ReFreshCache();

if (clsgs_PaperVerBL.relatedActions != null)
{
clsgs_PaperVerBL.relatedActions.UpdRelaTabDate(objgs_PaperVerEN.PaperVId, "SetUpdDate");
}
return strKey;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000091)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperVerEN SetPaperVId(this clsgs_PaperVerEN objgs_PaperVerEN, long lngPaperVId, string strComparisonOp="")
	{
objgs_PaperVerEN.PaperVId = lngPaperVId; //PaperVId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperVerEN.dicFldComparisonOp.ContainsKey(congs_PaperVer.PaperVId) == false)
{
objgs_PaperVerEN.dicFldComparisonOp.Add(congs_PaperVer.PaperVId, strComparisonOp);
}
else
{
objgs_PaperVerEN.dicFldComparisonOp[congs_PaperVer.PaperVId] = strComparisonOp;
}
}
return objgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperVerEN SetPaperId(this clsgs_PaperVerEN objgs_PaperVerEN, string strPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperId, congs_PaperVer.PaperId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, congs_PaperVer.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, congs_PaperVer.PaperId);
}
objgs_PaperVerEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperVerEN.dicFldComparisonOp.ContainsKey(congs_PaperVer.PaperId) == false)
{
objgs_PaperVerEN.dicFldComparisonOp.Add(congs_PaperVer.PaperId, strComparisonOp);
}
else
{
objgs_PaperVerEN.dicFldComparisonOp[congs_PaperVer.PaperId] = strComparisonOp;
}
}
return objgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperVerEN SetPaperTitle(this clsgs_PaperVerEN objgs_PaperVerEN, string strPaperTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperTitle, congs_PaperVer.PaperTitle);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, congs_PaperVer.PaperTitle);
}
objgs_PaperVerEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperVerEN.dicFldComparisonOp.ContainsKey(congs_PaperVer.PaperTitle) == false)
{
objgs_PaperVerEN.dicFldComparisonOp.Add(congs_PaperVer.PaperTitle, strComparisonOp);
}
else
{
objgs_PaperVerEN.dicFldComparisonOp[congs_PaperVer.PaperTitle] = strComparisonOp;
}
}
return objgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperVerEN SetPaperContent(this clsgs_PaperVerEN objgs_PaperVerEN, string strPaperContent, string strComparisonOp="")
	{
objgs_PaperVerEN.PaperContent = strPaperContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperVerEN.dicFldComparisonOp.ContainsKey(congs_PaperVer.PaperContent) == false)
{
objgs_PaperVerEN.dicFldComparisonOp.Add(congs_PaperVer.PaperContent, strComparisonOp);
}
else
{
objgs_PaperVerEN.dicFldComparisonOp[congs_PaperVer.PaperContent] = strComparisonOp;
}
}
return objgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperVerEN SetPeriodical(this clsgs_PaperVerEN objgs_PaperVerEN, string strPeriodical, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPeriodical, 100, congs_PaperVer.Periodical);
}
objgs_PaperVerEN.Periodical = strPeriodical; //期刊
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperVerEN.dicFldComparisonOp.ContainsKey(congs_PaperVer.Periodical) == false)
{
objgs_PaperVerEN.dicFldComparisonOp.Add(congs_PaperVer.Periodical, strComparisonOp);
}
else
{
objgs_PaperVerEN.dicFldComparisonOp[congs_PaperVer.Periodical] = strComparisonOp;
}
}
return objgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperVerEN SetAuthor(this clsgs_PaperVerEN objgs_PaperVerEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, congs_PaperVer.Author);
}
objgs_PaperVerEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperVerEN.dicFldComparisonOp.ContainsKey(congs_PaperVer.Author) == false)
{
objgs_PaperVerEN.dicFldComparisonOp.Add(congs_PaperVer.Author, strComparisonOp);
}
else
{
objgs_PaperVerEN.dicFldComparisonOp[congs_PaperVer.Author] = strComparisonOp;
}
}
return objgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperVerEN SetResearchQuestion(this clsgs_PaperVerEN objgs_PaperVerEN, string strResearchQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, congs_PaperVer.ResearchQuestion);
}
objgs_PaperVerEN.ResearchQuestion = strResearchQuestion; //研究问题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperVerEN.dicFldComparisonOp.ContainsKey(congs_PaperVer.ResearchQuestion) == false)
{
objgs_PaperVerEN.dicFldComparisonOp.Add(congs_PaperVer.ResearchQuestion, strComparisonOp);
}
else
{
objgs_PaperVerEN.dicFldComparisonOp[congs_PaperVer.ResearchQuestion] = strComparisonOp;
}
}
return objgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperVerEN SetKeyword(this clsgs_PaperVerEN objgs_PaperVerEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, congs_PaperVer.Keyword);
}
objgs_PaperVerEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperVerEN.dicFldComparisonOp.ContainsKey(congs_PaperVer.Keyword) == false)
{
objgs_PaperVerEN.dicFldComparisonOp.Add(congs_PaperVer.Keyword, strComparisonOp);
}
else
{
objgs_PaperVerEN.dicFldComparisonOp[congs_PaperVer.Keyword] = strComparisonOp;
}
}
return objgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperVerEN SetLiteratureSources(this clsgs_PaperVerEN objgs_PaperVerEN, string strLiteratureSources, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureSources, 1000, congs_PaperVer.LiteratureSources);
}
objgs_PaperVerEN.LiteratureSources = strLiteratureSources; //文献来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperVerEN.dicFldComparisonOp.ContainsKey(congs_PaperVer.LiteratureSources) == false)
{
objgs_PaperVerEN.dicFldComparisonOp.Add(congs_PaperVer.LiteratureSources, strComparisonOp);
}
else
{
objgs_PaperVerEN.dicFldComparisonOp[congs_PaperVer.LiteratureSources] = strComparisonOp;
}
}
return objgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperVerEN SetLiteratureLink(this clsgs_PaperVerEN objgs_PaperVerEN, string strLiteratureLink, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureLink, 1000, congs_PaperVer.LiteratureLink);
}
objgs_PaperVerEN.LiteratureLink = strLiteratureLink; //文献链接
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperVerEN.dicFldComparisonOp.ContainsKey(congs_PaperVer.LiteratureLink) == false)
{
objgs_PaperVerEN.dicFldComparisonOp.Add(congs_PaperVer.LiteratureLink, strComparisonOp);
}
else
{
objgs_PaperVerEN.dicFldComparisonOp[congs_PaperVer.LiteratureLink] = strComparisonOp;
}
}
return objgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperVerEN SetUploadfileUrl(this clsgs_PaperVerEN objgs_PaperVerEN, string strUploadfileUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadfileUrl, 1000, congs_PaperVer.UploadfileUrl);
}
objgs_PaperVerEN.UploadfileUrl = strUploadfileUrl; //文件地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperVerEN.dicFldComparisonOp.ContainsKey(congs_PaperVer.UploadfileUrl) == false)
{
objgs_PaperVerEN.dicFldComparisonOp.Add(congs_PaperVer.UploadfileUrl, strComparisonOp);
}
else
{
objgs_PaperVerEN.dicFldComparisonOp[congs_PaperVer.UploadfileUrl] = strComparisonOp;
}
}
return objgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperVerEN SetIsQuotethesis(this clsgs_PaperVerEN objgs_PaperVerEN, bool bolIsQuotethesis, string strComparisonOp="")
	{
objgs_PaperVerEN.IsQuotethesis = bolIsQuotethesis; //是否引用论文
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperVerEN.dicFldComparisonOp.ContainsKey(congs_PaperVer.IsQuotethesis) == false)
{
objgs_PaperVerEN.dicFldComparisonOp.Add(congs_PaperVer.IsQuotethesis, strComparisonOp);
}
else
{
objgs_PaperVerEN.dicFldComparisonOp[congs_PaperVer.IsQuotethesis] = strComparisonOp;
}
}
return objgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperVerEN SetIsSubmit(this clsgs_PaperVerEN objgs_PaperVerEN, bool bolIsSubmit, string strComparisonOp="")
	{
objgs_PaperVerEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperVerEN.dicFldComparisonOp.ContainsKey(congs_PaperVer.IsSubmit) == false)
{
objgs_PaperVerEN.dicFldComparisonOp.Add(congs_PaperVer.IsSubmit, strComparisonOp);
}
else
{
objgs_PaperVerEN.dicFldComparisonOp[congs_PaperVer.IsSubmit] = strComparisonOp;
}
}
return objgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperVerEN SetIsChecked(this clsgs_PaperVerEN objgs_PaperVerEN, bool bolIsChecked, string strComparisonOp="")
	{
objgs_PaperVerEN.IsChecked = bolIsChecked; //是否检查
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperVerEN.dicFldComparisonOp.ContainsKey(congs_PaperVer.IsChecked) == false)
{
objgs_PaperVerEN.dicFldComparisonOp.Add(congs_PaperVer.IsChecked, strComparisonOp);
}
else
{
objgs_PaperVerEN.dicFldComparisonOp[congs_PaperVer.IsChecked] = strComparisonOp;
}
}
return objgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperVerEN SetQuoteId(this clsgs_PaperVerEN objgs_PaperVerEN, string strQuoteId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuoteId, 8, congs_PaperVer.QuoteId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuoteId, 8, congs_PaperVer.QuoteId);
}
objgs_PaperVerEN.QuoteId = strQuoteId; //引用Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperVerEN.dicFldComparisonOp.ContainsKey(congs_PaperVer.QuoteId) == false)
{
objgs_PaperVerEN.dicFldComparisonOp.Add(congs_PaperVer.QuoteId, strComparisonOp);
}
else
{
objgs_PaperVerEN.dicFldComparisonOp[congs_PaperVer.QuoteId] = strComparisonOp;
}
}
return objgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperVerEN SetChecker(this clsgs_PaperVerEN objgs_PaperVerEN, string strChecker, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChecker, 20, congs_PaperVer.Checker);
}
objgs_PaperVerEN.Checker = strChecker; //审核人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperVerEN.dicFldComparisonOp.ContainsKey(congs_PaperVer.Checker) == false)
{
objgs_PaperVerEN.dicFldComparisonOp.Add(congs_PaperVer.Checker, strComparisonOp);
}
else
{
objgs_PaperVerEN.dicFldComparisonOp[congs_PaperVer.Checker] = strComparisonOp;
}
}
return objgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperVerEN SetLiteratureTypeId(this clsgs_PaperVerEN objgs_PaperVerEN, string strLiteratureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLiteratureTypeId, congs_PaperVer.LiteratureTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureTypeId, 2, congs_PaperVer.LiteratureTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLiteratureTypeId, 2, congs_PaperVer.LiteratureTypeId);
}
objgs_PaperVerEN.LiteratureTypeId = strLiteratureTypeId; //文献类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperVerEN.dicFldComparisonOp.ContainsKey(congs_PaperVer.LiteratureTypeId) == false)
{
objgs_PaperVerEN.dicFldComparisonOp.Add(congs_PaperVer.LiteratureTypeId, strComparisonOp);
}
else
{
objgs_PaperVerEN.dicFldComparisonOp[congs_PaperVer.LiteratureTypeId] = strComparisonOp;
}
}
return objgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperVerEN SetUpdUser(this clsgs_PaperVerEN objgs_PaperVerEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_PaperVer.UpdUser);
}
objgs_PaperVerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperVerEN.dicFldComparisonOp.ContainsKey(congs_PaperVer.UpdUser) == false)
{
objgs_PaperVerEN.dicFldComparisonOp.Add(congs_PaperVer.UpdUser, strComparisonOp);
}
else
{
objgs_PaperVerEN.dicFldComparisonOp[congs_PaperVer.UpdUser] = strComparisonOp;
}
}
return objgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperVerEN SetUpdDate(this clsgs_PaperVerEN objgs_PaperVerEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_PaperVer.UpdDate);
}
objgs_PaperVerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperVerEN.dicFldComparisonOp.ContainsKey(congs_PaperVer.UpdDate) == false)
{
objgs_PaperVerEN.dicFldComparisonOp.Add(congs_PaperVer.UpdDate, strComparisonOp);
}
else
{
objgs_PaperVerEN.dicFldComparisonOp[congs_PaperVer.UpdDate] = strComparisonOp;
}
}
return objgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperVerEN SetIdCurrEduCls(this clsgs_PaperVerEN objgs_PaperVerEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, congs_PaperVer.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, congs_PaperVer.IdCurrEduCls);
}
objgs_PaperVerEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperVerEN.dicFldComparisonOp.ContainsKey(congs_PaperVer.IdCurrEduCls) == false)
{
objgs_PaperVerEN.dicFldComparisonOp.Add(congs_PaperVer.IdCurrEduCls, strComparisonOp);
}
else
{
objgs_PaperVerEN.dicFldComparisonOp[congs_PaperVer.IdCurrEduCls] = strComparisonOp;
}
}
return objgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperVerEN SetPaperTypeId(this clsgs_PaperVerEN objgs_PaperVerEN, string strPaperTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTypeId, 2, congs_PaperVer.PaperTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperTypeId, 2, congs_PaperVer.PaperTypeId);
}
objgs_PaperVerEN.PaperTypeId = strPaperTypeId; //论文类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperVerEN.dicFldComparisonOp.ContainsKey(congs_PaperVer.PaperTypeId) == false)
{
objgs_PaperVerEN.dicFldComparisonOp.Add(congs_PaperVer.PaperTypeId, strComparisonOp);
}
else
{
objgs_PaperVerEN.dicFldComparisonOp[congs_PaperVer.PaperTypeId] = strComparisonOp;
}
}
return objgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperVerEN SetPaperStatusId(this clsgs_PaperVerEN objgs_PaperVerEN, string strPaperStatusId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperStatusId, 2, congs_PaperVer.PaperStatusId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperStatusId, 2, congs_PaperVer.PaperStatusId);
}
objgs_PaperVerEN.PaperStatusId = strPaperStatusId; //论文状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperVerEN.dicFldComparisonOp.ContainsKey(congs_PaperVer.PaperStatusId) == false)
{
objgs_PaperVerEN.dicFldComparisonOp.Add(congs_PaperVer.PaperStatusId, strComparisonOp);
}
else
{
objgs_PaperVerEN.dicFldComparisonOp[congs_PaperVer.PaperStatusId] = strComparisonOp;
}
}
return objgs_PaperVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperVerEN SetMemo(this clsgs_PaperVerEN objgs_PaperVerEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_PaperVer.Memo);
}
objgs_PaperVerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperVerEN.dicFldComparisonOp.ContainsKey(congs_PaperVer.Memo) == false)
{
objgs_PaperVerEN.dicFldComparisonOp.Add(congs_PaperVer.Memo, strComparisonOp);
}
else
{
objgs_PaperVerEN.dicFldComparisonOp[congs_PaperVer.Memo] = strComparisonOp;
}
}
return objgs_PaperVerEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_PaperVerEN objgs_PaperVerEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_PaperVerEN.CheckPropertyNew();
clsgs_PaperVerEN objgs_PaperVerCond = new clsgs_PaperVerEN();
string strCondition = objgs_PaperVerCond
.SetPaperVId(objgs_PaperVerEN.PaperVId, "<>")
.SetPaperVId(objgs_PaperVerEN.PaperVId, "=")
.GetCombineCondition();
objgs_PaperVerEN._IsCheckProperty = true;
bool bolIsExist = clsgs_PaperVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PaperVId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_PaperVerEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改,不存在就添加
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objgs_PaperVer">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_PaperVerEN objgs_PaperVer)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_PaperVerEN objgs_PaperVerCond = new clsgs_PaperVerEN();
string strCondition = objgs_PaperVerCond
.SetPaperVId(objgs_PaperVer.PaperVId, "=")
.GetCombineCondition();
objgs_PaperVer._IsCheckProperty = true;
bool bolIsExist = clsgs_PaperVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_PaperVer.PaperVId = clsgs_PaperVerBL.GetFirstID_S(strCondition);
objgs_PaperVer.UpdateWithCondition(strCondition);
}
else
{
objgs_PaperVer.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_PaperVerEN objgs_PaperVerEN)
{
 if (objgs_PaperVerEN.PaperVId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_PaperVerBL.gs_PaperVerDA.UpdateBySql2(objgs_PaperVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperVerBL.ReFreshCache();

if (clsgs_PaperVerBL.relatedActions != null)
{
clsgs_PaperVerBL.relatedActions.UpdRelaTabDate(objgs_PaperVerEN.PaperVId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000083)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithTransaction)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_PaperVerEN objgs_PaperVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_PaperVerEN.PaperVId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_PaperVerBL.gs_PaperVerDA.UpdateBySql2(objgs_PaperVerEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperVerBL.ReFreshCache();

if (clsgs_PaperVerBL.relatedActions != null)
{
clsgs_PaperVerBL.relatedActions.UpdRelaTabDate(objgs_PaperVerEN.PaperVId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000088)修改记录出错,{1}.(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_PaperVerEN objgs_PaperVerEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_PaperVerBL.gs_PaperVerDA.UpdateBySqlWithCondition(objgs_PaperVerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperVerBL.ReFreshCache();

if (clsgs_PaperVerBL.relatedActions != null)
{
clsgs_PaperVerBL.relatedActions.UpdRelaTabDate(objgs_PaperVerEN.PaperVId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000089)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录.(带事务处理)
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithConditionTransaction)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_PaperVerEN objgs_PaperVerEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_PaperVerBL.gs_PaperVerDA.UpdateBySqlWithConditionTransaction(objgs_PaperVerEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperVerBL.ReFreshCache();

if (clsgs_PaperVerBL.relatedActions != null)
{
clsgs_PaperVerBL.relatedActions.UpdRelaTabDate(objgs_PaperVerEN.PaperVId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000090)根据条件修改记录出错!(带事务处理),{1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Delete)
 /// </summary>
 /// <param name = "lngPaperVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsgs_PaperVerEN objgs_PaperVerEN)
{
try
{
int intRecNum = clsgs_PaperVerBL.gs_PaperVerDA.DelRecord(objgs_PaperVerEN.PaperVId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperVerBL.ReFreshCache();

if (clsgs_PaperVerBL.relatedActions != null)
{
clsgs_PaperVerBL.relatedActions.UpdRelaTabDate(objgs_PaperVerEN.PaperVId, "SetUpdDate");
}
return intRecNum;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000084)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objgs_PaperVerENS">源对象</param>
 /// <param name = "objgs_PaperVerENT">目标对象</param>
 public static void CopyTo(this clsgs_PaperVerEN objgs_PaperVerENS, clsgs_PaperVerEN objgs_PaperVerENT)
{
try
{
objgs_PaperVerENT.PaperVId = objgs_PaperVerENS.PaperVId; //PaperVId
objgs_PaperVerENT.PaperId = objgs_PaperVerENS.PaperId; //论文Id
objgs_PaperVerENT.PaperTitle = objgs_PaperVerENS.PaperTitle; //论文标题
objgs_PaperVerENT.PaperContent = objgs_PaperVerENS.PaperContent; //主题内容
objgs_PaperVerENT.Periodical = objgs_PaperVerENS.Periodical; //期刊
objgs_PaperVerENT.Author = objgs_PaperVerENS.Author; //作者
objgs_PaperVerENT.ResearchQuestion = objgs_PaperVerENS.ResearchQuestion; //研究问题
objgs_PaperVerENT.Keyword = objgs_PaperVerENS.Keyword; //关键字
objgs_PaperVerENT.LiteratureSources = objgs_PaperVerENS.LiteratureSources; //文献来源
objgs_PaperVerENT.LiteratureLink = objgs_PaperVerENS.LiteratureLink; //文献链接
objgs_PaperVerENT.UploadfileUrl = objgs_PaperVerENS.UploadfileUrl; //文件地址
objgs_PaperVerENT.IsQuotethesis = objgs_PaperVerENS.IsQuotethesis; //是否引用论文
objgs_PaperVerENT.IsSubmit = objgs_PaperVerENS.IsSubmit; //是否提交
objgs_PaperVerENT.IsChecked = objgs_PaperVerENS.IsChecked; //是否检查
objgs_PaperVerENT.QuoteId = objgs_PaperVerENS.QuoteId; //引用Id
objgs_PaperVerENT.Checker = objgs_PaperVerENS.Checker; //审核人
objgs_PaperVerENT.LiteratureTypeId = objgs_PaperVerENS.LiteratureTypeId; //文献类型Id
objgs_PaperVerENT.UpdUser = objgs_PaperVerENS.UpdUser; //修改人
objgs_PaperVerENT.UpdDate = objgs_PaperVerENS.UpdDate; //修改日期
objgs_PaperVerENT.IdCurrEduCls = objgs_PaperVerENS.IdCurrEduCls; //教学班流水号
objgs_PaperVerENT.PaperTypeId = objgs_PaperVerENS.PaperTypeId; //论文类型Id
objgs_PaperVerENT.PaperStatusId = objgs_PaperVerENS.PaperStatusId; //论文状态Id
objgs_PaperVerENT.Memo = objgs_PaperVerENS.Memo; //备注
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
 /// <param name = "objgs_PaperVerENS">源对象</param>
 /// <returns>目标对象=>clsgs_PaperVerEN:objgs_PaperVerENT</returns>
 public static clsgs_PaperVerEN CopyTo(this clsgs_PaperVerEN objgs_PaperVerENS)
{
try
{
 clsgs_PaperVerEN objgs_PaperVerENT = new clsgs_PaperVerEN()
{
PaperVId = objgs_PaperVerENS.PaperVId, //PaperVId
PaperId = objgs_PaperVerENS.PaperId, //论文Id
PaperTitle = objgs_PaperVerENS.PaperTitle, //论文标题
PaperContent = objgs_PaperVerENS.PaperContent, //主题内容
Periodical = objgs_PaperVerENS.Periodical, //期刊
Author = objgs_PaperVerENS.Author, //作者
ResearchQuestion = objgs_PaperVerENS.ResearchQuestion, //研究问题
Keyword = objgs_PaperVerENS.Keyword, //关键字
LiteratureSources = objgs_PaperVerENS.LiteratureSources, //文献来源
LiteratureLink = objgs_PaperVerENS.LiteratureLink, //文献链接
UploadfileUrl = objgs_PaperVerENS.UploadfileUrl, //文件地址
IsQuotethesis = objgs_PaperVerENS.IsQuotethesis, //是否引用论文
IsSubmit = objgs_PaperVerENS.IsSubmit, //是否提交
IsChecked = objgs_PaperVerENS.IsChecked, //是否检查
QuoteId = objgs_PaperVerENS.QuoteId, //引用Id
Checker = objgs_PaperVerENS.Checker, //审核人
LiteratureTypeId = objgs_PaperVerENS.LiteratureTypeId, //文献类型Id
UpdUser = objgs_PaperVerENS.UpdUser, //修改人
UpdDate = objgs_PaperVerENS.UpdDate, //修改日期
IdCurrEduCls = objgs_PaperVerENS.IdCurrEduCls, //教学班流水号
PaperTypeId = objgs_PaperVerENS.PaperTypeId, //论文类型Id
PaperStatusId = objgs_PaperVerENS.PaperStatusId, //论文状态Id
Memo = objgs_PaperVerENS.Memo, //备注
};
 return objgs_PaperVerENT;
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(this clsgs_PaperVerEN objgs_PaperVerEN)
{
 clsgs_PaperVerBL.gs_PaperVerDA.CheckPropertyNew(objgs_PaperVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_PaperVerEN objgs_PaperVerEN)
{
 clsgs_PaperVerBL.gs_PaperVerDA.CheckProperty4Condition(objgs_PaperVerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_PaperVerEN objgs_PaperVerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_PaperVerCond.IsUpdated(congs_PaperVer.PaperVId) == true)
{
string strComparisonOpPaperVId = objgs_PaperVerCond.dicFldComparisonOp[congs_PaperVer.PaperVId];
strWhereCond += string.Format(" And {0} {2} {1}", congs_PaperVer.PaperVId, objgs_PaperVerCond.PaperVId, strComparisonOpPaperVId);
}
if (objgs_PaperVerCond.IsUpdated(congs_PaperVer.PaperId) == true)
{
string strComparisonOpPaperId = objgs_PaperVerCond.dicFldComparisonOp[congs_PaperVer.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperVer.PaperId, objgs_PaperVerCond.PaperId, strComparisonOpPaperId);
}
if (objgs_PaperVerCond.IsUpdated(congs_PaperVer.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objgs_PaperVerCond.dicFldComparisonOp[congs_PaperVer.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperVer.PaperTitle, objgs_PaperVerCond.PaperTitle, strComparisonOpPaperTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objgs_PaperVerCond.IsUpdated(congs_PaperVer.Periodical) == true)
{
string strComparisonOpPeriodical = objgs_PaperVerCond.dicFldComparisonOp[congs_PaperVer.Periodical];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperVer.Periodical, objgs_PaperVerCond.Periodical, strComparisonOpPeriodical);
}
if (objgs_PaperVerCond.IsUpdated(congs_PaperVer.Author) == true)
{
string strComparisonOpAuthor = objgs_PaperVerCond.dicFldComparisonOp[congs_PaperVer.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperVer.Author, objgs_PaperVerCond.Author, strComparisonOpAuthor);
}
if (objgs_PaperVerCond.IsUpdated(congs_PaperVer.ResearchQuestion) == true)
{
string strComparisonOpResearchQuestion = objgs_PaperVerCond.dicFldComparisonOp[congs_PaperVer.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperVer.ResearchQuestion, objgs_PaperVerCond.ResearchQuestion, strComparisonOpResearchQuestion);
}
if (objgs_PaperVerCond.IsUpdated(congs_PaperVer.Keyword) == true)
{
string strComparisonOpKeyword = objgs_PaperVerCond.dicFldComparisonOp[congs_PaperVer.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperVer.Keyword, objgs_PaperVerCond.Keyword, strComparisonOpKeyword);
}
if (objgs_PaperVerCond.IsUpdated(congs_PaperVer.LiteratureSources) == true)
{
string strComparisonOpLiteratureSources = objgs_PaperVerCond.dicFldComparisonOp[congs_PaperVer.LiteratureSources];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperVer.LiteratureSources, objgs_PaperVerCond.LiteratureSources, strComparisonOpLiteratureSources);
}
if (objgs_PaperVerCond.IsUpdated(congs_PaperVer.LiteratureLink) == true)
{
string strComparisonOpLiteratureLink = objgs_PaperVerCond.dicFldComparisonOp[congs_PaperVer.LiteratureLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperVer.LiteratureLink, objgs_PaperVerCond.LiteratureLink, strComparisonOpLiteratureLink);
}
if (objgs_PaperVerCond.IsUpdated(congs_PaperVer.UploadfileUrl) == true)
{
string strComparisonOpUploadfileUrl = objgs_PaperVerCond.dicFldComparisonOp[congs_PaperVer.UploadfileUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperVer.UploadfileUrl, objgs_PaperVerCond.UploadfileUrl, strComparisonOpUploadfileUrl);
}
if (objgs_PaperVerCond.IsUpdated(congs_PaperVer.IsQuotethesis) == true)
{
if (objgs_PaperVerCond.IsQuotethesis == true)
{
strWhereCond += string.Format(" And {0} = '1'", congs_PaperVer.IsQuotethesis);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", congs_PaperVer.IsQuotethesis);
}
}
if (objgs_PaperVerCond.IsUpdated(congs_PaperVer.IsSubmit) == true)
{
if (objgs_PaperVerCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", congs_PaperVer.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", congs_PaperVer.IsSubmit);
}
}
if (objgs_PaperVerCond.IsUpdated(congs_PaperVer.IsChecked) == true)
{
if (objgs_PaperVerCond.IsChecked == true)
{
strWhereCond += string.Format(" And {0} = '1'", congs_PaperVer.IsChecked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", congs_PaperVer.IsChecked);
}
}
if (objgs_PaperVerCond.IsUpdated(congs_PaperVer.QuoteId) == true)
{
string strComparisonOpQuoteId = objgs_PaperVerCond.dicFldComparisonOp[congs_PaperVer.QuoteId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperVer.QuoteId, objgs_PaperVerCond.QuoteId, strComparisonOpQuoteId);
}
if (objgs_PaperVerCond.IsUpdated(congs_PaperVer.Checker) == true)
{
string strComparisonOpChecker = objgs_PaperVerCond.dicFldComparisonOp[congs_PaperVer.Checker];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperVer.Checker, objgs_PaperVerCond.Checker, strComparisonOpChecker);
}
if (objgs_PaperVerCond.IsUpdated(congs_PaperVer.LiteratureTypeId) == true)
{
string strComparisonOpLiteratureTypeId = objgs_PaperVerCond.dicFldComparisonOp[congs_PaperVer.LiteratureTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperVer.LiteratureTypeId, objgs_PaperVerCond.LiteratureTypeId, strComparisonOpLiteratureTypeId);
}
if (objgs_PaperVerCond.IsUpdated(congs_PaperVer.UpdUser) == true)
{
string strComparisonOpUpdUser = objgs_PaperVerCond.dicFldComparisonOp[congs_PaperVer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperVer.UpdUser, objgs_PaperVerCond.UpdUser, strComparisonOpUpdUser);
}
if (objgs_PaperVerCond.IsUpdated(congs_PaperVer.UpdDate) == true)
{
string strComparisonOpUpdDate = objgs_PaperVerCond.dicFldComparisonOp[congs_PaperVer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperVer.UpdDate, objgs_PaperVerCond.UpdDate, strComparisonOpUpdDate);
}
if (objgs_PaperVerCond.IsUpdated(congs_PaperVer.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objgs_PaperVerCond.dicFldComparisonOp[congs_PaperVer.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperVer.IdCurrEduCls, objgs_PaperVerCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objgs_PaperVerCond.IsUpdated(congs_PaperVer.PaperTypeId) == true)
{
string strComparisonOpPaperTypeId = objgs_PaperVerCond.dicFldComparisonOp[congs_PaperVer.PaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperVer.PaperTypeId, objgs_PaperVerCond.PaperTypeId, strComparisonOpPaperTypeId);
}
if (objgs_PaperVerCond.IsUpdated(congs_PaperVer.PaperStatusId) == true)
{
string strComparisonOpPaperStatusId = objgs_PaperVerCond.dicFldComparisonOp[congs_PaperVer.PaperStatusId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperVer.PaperStatusId, objgs_PaperVerCond.PaperStatusId, strComparisonOpPaperStatusId);
}
if (objgs_PaperVerCond.IsUpdated(congs_PaperVer.Memo) == true)
{
string strComparisonOpMemo = objgs_PaperVerCond.dicFldComparisonOp[congs_PaperVer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperVer.Memo, objgs_PaperVerCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_PaperVer(论文历史版本表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PaperVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_PaperVerEN objgs_PaperVerEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_PaperVerEN == null) return true;
if (objgs_PaperVerEN.PaperVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PaperVId = '{0}'", objgs_PaperVerEN.PaperVId);
if (clsgs_PaperVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PaperVId !=  {0}", objgs_PaperVerEN.PaperVId);
 sbCondition.AppendFormat(" and PaperVId = '{0}'", objgs_PaperVerEN.PaperVId);
if (clsgs_PaperVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_PaperVer(论文历史版本表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PaperVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_PaperVerEN objgs_PaperVerEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_PaperVerEN == null) return "";
if (objgs_PaperVerEN.PaperVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PaperVId = '{0}'", objgs_PaperVerEN.PaperVId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PaperVId !=  {0}", objgs_PaperVerEN.PaperVId);
 sbCondition.AppendFormat(" and PaperVId = '{0}'", objgs_PaperVerEN.PaperVId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_PaperVer
{
public virtual bool UpdRelaTabDate(long lngPaperVId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文历史版本表(gs_PaperVer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_PaperVerBL
{
public static RelatedActions_gs_PaperVer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_PaperVerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_PaperVerDA gs_PaperVerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_PaperVerDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsgs_PaperVerBL()
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
if (string.IsNullOrEmpty(clsgs_PaperVerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_PaperVerEN._ConnectString);
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
public static DataTable GetDataTable_gs_PaperVer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_PaperVerDA.GetDataTable_gs_PaperVer(strWhereCond);
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
objDT = gs_PaperVerDA.GetDataTable(strWhereCond);
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
objDT = gs_PaperVerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_PaperVerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_PaperVerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_PaperVerDA.GetDataTable_Top(objTopPara);
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
objDT = gs_PaperVerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_PaperVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_PaperVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsgs_PaperVerEN> GetObjLstByPaperVIdLst(List<long> arrPaperVIdLst)
{
List<clsgs_PaperVerEN> arrObjLst = new List<clsgs_PaperVerEN>(); 
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
	clsgs_PaperVerEN objgs_PaperVerEN = new clsgs_PaperVerEN();
try
{
objgs_PaperVerEN.PaperVId = Int32.Parse(objRow[congs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objgs_PaperVerEN.PaperId = objRow[congs_PaperVer.PaperId].ToString().Trim(); //论文Id
objgs_PaperVerEN.PaperTitle = objRow[congs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objgs_PaperVerEN.PaperContent = objRow[congs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[congs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objgs_PaperVerEN.Periodical = objRow[congs_PaperVer.Periodical] == DBNull.Value ? null : objRow[congs_PaperVer.Periodical].ToString().Trim(); //期刊
objgs_PaperVerEN.Author = objRow[congs_PaperVer.Author] == DBNull.Value ? null : objRow[congs_PaperVer.Author].ToString().Trim(); //作者
objgs_PaperVerEN.ResearchQuestion = objRow[congs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[congs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objgs_PaperVerEN.Keyword = objRow[congs_PaperVer.Keyword] == DBNull.Value ? null : objRow[congs_PaperVer.Keyword].ToString().Trim(); //关键字
objgs_PaperVerEN.LiteratureSources = objRow[congs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objgs_PaperVerEN.LiteratureLink = objRow[congs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objgs_PaperVerEN.UploadfileUrl = objRow[congs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[congs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objgs_PaperVerEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objgs_PaperVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperVerEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objgs_PaperVerEN.QuoteId = objRow[congs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[congs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objgs_PaperVerEN.Checker = objRow[congs_PaperVer.Checker] == DBNull.Value ? null : objRow[congs_PaperVer.Checker].ToString().Trim(); //审核人
objgs_PaperVerEN.LiteratureTypeId = objRow[congs_PaperVer.LiteratureTypeId].ToString().Trim(); //文献类型Id
objgs_PaperVerEN.UpdUser = objRow[congs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperVerEN.UpdDate = objRow[congs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperVerEN.IdCurrEduCls = objRow[congs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperVerEN.PaperTypeId = objRow[congs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objgs_PaperVerEN.PaperStatusId = objRow[congs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objgs_PaperVerEN.Memo = objRow[congs_PaperVer.Memo] == DBNull.Value ? null : objRow[congs_PaperVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperVerEN.PaperVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_PaperVerEN> GetObjLstByPaperVIdLstCache(List<long> arrPaperVIdLst)
{
string strKey = string.Format("{0}", clsgs_PaperVerEN._CurrTabName);
List<clsgs_PaperVerEN> arrgs_PaperVerObjLstCache = GetObjLstCache();
IEnumerable <clsgs_PaperVerEN> arrgs_PaperVerObjLst_Sel =
arrgs_PaperVerObjLstCache
.Where(x => arrPaperVIdLst.Contains(x.PaperVId));
return arrgs_PaperVerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_PaperVerEN> GetObjLst(string strWhereCond)
{
List<clsgs_PaperVerEN> arrObjLst = new List<clsgs_PaperVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperVerEN objgs_PaperVerEN = new clsgs_PaperVerEN();
try
{
objgs_PaperVerEN.PaperVId = Int32.Parse(objRow[congs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objgs_PaperVerEN.PaperId = objRow[congs_PaperVer.PaperId].ToString().Trim(); //论文Id
objgs_PaperVerEN.PaperTitle = objRow[congs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objgs_PaperVerEN.PaperContent = objRow[congs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[congs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objgs_PaperVerEN.Periodical = objRow[congs_PaperVer.Periodical] == DBNull.Value ? null : objRow[congs_PaperVer.Periodical].ToString().Trim(); //期刊
objgs_PaperVerEN.Author = objRow[congs_PaperVer.Author] == DBNull.Value ? null : objRow[congs_PaperVer.Author].ToString().Trim(); //作者
objgs_PaperVerEN.ResearchQuestion = objRow[congs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[congs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objgs_PaperVerEN.Keyword = objRow[congs_PaperVer.Keyword] == DBNull.Value ? null : objRow[congs_PaperVer.Keyword].ToString().Trim(); //关键字
objgs_PaperVerEN.LiteratureSources = objRow[congs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objgs_PaperVerEN.LiteratureLink = objRow[congs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objgs_PaperVerEN.UploadfileUrl = objRow[congs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[congs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objgs_PaperVerEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objgs_PaperVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperVerEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objgs_PaperVerEN.QuoteId = objRow[congs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[congs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objgs_PaperVerEN.Checker = objRow[congs_PaperVer.Checker] == DBNull.Value ? null : objRow[congs_PaperVer.Checker].ToString().Trim(); //审核人
objgs_PaperVerEN.LiteratureTypeId = objRow[congs_PaperVer.LiteratureTypeId].ToString().Trim(); //文献类型Id
objgs_PaperVerEN.UpdUser = objRow[congs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperVerEN.UpdDate = objRow[congs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperVerEN.IdCurrEduCls = objRow[congs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperVerEN.PaperTypeId = objRow[congs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objgs_PaperVerEN.PaperStatusId = objRow[congs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objgs_PaperVerEN.Memo = objRow[congs_PaperVer.Memo] == DBNull.Value ? null : objRow[congs_PaperVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperVerEN.PaperVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperVerEN);
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
public static List<clsgs_PaperVerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_PaperVerEN> arrObjLst = new List<clsgs_PaperVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperVerEN objgs_PaperVerEN = new clsgs_PaperVerEN();
try
{
objgs_PaperVerEN.PaperVId = Int32.Parse(objRow[congs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objgs_PaperVerEN.PaperId = objRow[congs_PaperVer.PaperId].ToString().Trim(); //论文Id
objgs_PaperVerEN.PaperTitle = objRow[congs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objgs_PaperVerEN.PaperContent = objRow[congs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[congs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objgs_PaperVerEN.Periodical = objRow[congs_PaperVer.Periodical] == DBNull.Value ? null : objRow[congs_PaperVer.Periodical].ToString().Trim(); //期刊
objgs_PaperVerEN.Author = objRow[congs_PaperVer.Author] == DBNull.Value ? null : objRow[congs_PaperVer.Author].ToString().Trim(); //作者
objgs_PaperVerEN.ResearchQuestion = objRow[congs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[congs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objgs_PaperVerEN.Keyword = objRow[congs_PaperVer.Keyword] == DBNull.Value ? null : objRow[congs_PaperVer.Keyword].ToString().Trim(); //关键字
objgs_PaperVerEN.LiteratureSources = objRow[congs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objgs_PaperVerEN.LiteratureLink = objRow[congs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objgs_PaperVerEN.UploadfileUrl = objRow[congs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[congs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objgs_PaperVerEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objgs_PaperVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperVerEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objgs_PaperVerEN.QuoteId = objRow[congs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[congs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objgs_PaperVerEN.Checker = objRow[congs_PaperVer.Checker] == DBNull.Value ? null : objRow[congs_PaperVer.Checker].ToString().Trim(); //审核人
objgs_PaperVerEN.LiteratureTypeId = objRow[congs_PaperVer.LiteratureTypeId].ToString().Trim(); //文献类型Id
objgs_PaperVerEN.UpdUser = objRow[congs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperVerEN.UpdDate = objRow[congs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperVerEN.IdCurrEduCls = objRow[congs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperVerEN.PaperTypeId = objRow[congs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objgs_PaperVerEN.PaperStatusId = objRow[congs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objgs_PaperVerEN.Memo = objRow[congs_PaperVer.Memo] == DBNull.Value ? null : objRow[congs_PaperVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperVerEN.PaperVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_PaperVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_PaperVerEN> GetSubObjLstCache(clsgs_PaperVerEN objgs_PaperVerCond)
{
List<clsgs_PaperVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_PaperVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_PaperVer.AttributeName)
{
if (objgs_PaperVerCond.IsUpdated(strFldName) == false) continue;
if (objgs_PaperVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_PaperVerCond[strFldName].ToString());
}
else
{
if (objgs_PaperVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_PaperVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_PaperVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_PaperVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_PaperVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_PaperVerCond[strFldName]));
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
public static List<clsgs_PaperVerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_PaperVerEN> arrObjLst = new List<clsgs_PaperVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperVerEN objgs_PaperVerEN = new clsgs_PaperVerEN();
try
{
objgs_PaperVerEN.PaperVId = Int32.Parse(objRow[congs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objgs_PaperVerEN.PaperId = objRow[congs_PaperVer.PaperId].ToString().Trim(); //论文Id
objgs_PaperVerEN.PaperTitle = objRow[congs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objgs_PaperVerEN.PaperContent = objRow[congs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[congs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objgs_PaperVerEN.Periodical = objRow[congs_PaperVer.Periodical] == DBNull.Value ? null : objRow[congs_PaperVer.Periodical].ToString().Trim(); //期刊
objgs_PaperVerEN.Author = objRow[congs_PaperVer.Author] == DBNull.Value ? null : objRow[congs_PaperVer.Author].ToString().Trim(); //作者
objgs_PaperVerEN.ResearchQuestion = objRow[congs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[congs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objgs_PaperVerEN.Keyword = objRow[congs_PaperVer.Keyword] == DBNull.Value ? null : objRow[congs_PaperVer.Keyword].ToString().Trim(); //关键字
objgs_PaperVerEN.LiteratureSources = objRow[congs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objgs_PaperVerEN.LiteratureLink = objRow[congs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objgs_PaperVerEN.UploadfileUrl = objRow[congs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[congs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objgs_PaperVerEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objgs_PaperVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperVerEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objgs_PaperVerEN.QuoteId = objRow[congs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[congs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objgs_PaperVerEN.Checker = objRow[congs_PaperVer.Checker] == DBNull.Value ? null : objRow[congs_PaperVer.Checker].ToString().Trim(); //审核人
objgs_PaperVerEN.LiteratureTypeId = objRow[congs_PaperVer.LiteratureTypeId].ToString().Trim(); //文献类型Id
objgs_PaperVerEN.UpdUser = objRow[congs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperVerEN.UpdDate = objRow[congs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperVerEN.IdCurrEduCls = objRow[congs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperVerEN.PaperTypeId = objRow[congs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objgs_PaperVerEN.PaperStatusId = objRow[congs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objgs_PaperVerEN.Memo = objRow[congs_PaperVer.Memo] == DBNull.Value ? null : objRow[congs_PaperVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperVerEN.PaperVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperVerEN);
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
public static List<clsgs_PaperVerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_PaperVerEN> arrObjLst = new List<clsgs_PaperVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperVerEN objgs_PaperVerEN = new clsgs_PaperVerEN();
try
{
objgs_PaperVerEN.PaperVId = Int32.Parse(objRow[congs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objgs_PaperVerEN.PaperId = objRow[congs_PaperVer.PaperId].ToString().Trim(); //论文Id
objgs_PaperVerEN.PaperTitle = objRow[congs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objgs_PaperVerEN.PaperContent = objRow[congs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[congs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objgs_PaperVerEN.Periodical = objRow[congs_PaperVer.Periodical] == DBNull.Value ? null : objRow[congs_PaperVer.Periodical].ToString().Trim(); //期刊
objgs_PaperVerEN.Author = objRow[congs_PaperVer.Author] == DBNull.Value ? null : objRow[congs_PaperVer.Author].ToString().Trim(); //作者
objgs_PaperVerEN.ResearchQuestion = objRow[congs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[congs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objgs_PaperVerEN.Keyword = objRow[congs_PaperVer.Keyword] == DBNull.Value ? null : objRow[congs_PaperVer.Keyword].ToString().Trim(); //关键字
objgs_PaperVerEN.LiteratureSources = objRow[congs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objgs_PaperVerEN.LiteratureLink = objRow[congs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objgs_PaperVerEN.UploadfileUrl = objRow[congs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[congs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objgs_PaperVerEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objgs_PaperVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperVerEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objgs_PaperVerEN.QuoteId = objRow[congs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[congs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objgs_PaperVerEN.Checker = objRow[congs_PaperVer.Checker] == DBNull.Value ? null : objRow[congs_PaperVer.Checker].ToString().Trim(); //审核人
objgs_PaperVerEN.LiteratureTypeId = objRow[congs_PaperVer.LiteratureTypeId].ToString().Trim(); //文献类型Id
objgs_PaperVerEN.UpdUser = objRow[congs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperVerEN.UpdDate = objRow[congs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperVerEN.IdCurrEduCls = objRow[congs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperVerEN.PaperTypeId = objRow[congs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objgs_PaperVerEN.PaperStatusId = objRow[congs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objgs_PaperVerEN.Memo = objRow[congs_PaperVer.Memo] == DBNull.Value ? null : objRow[congs_PaperVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperVerEN.PaperVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperVerEN);
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
List<clsgs_PaperVerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_PaperVerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_PaperVerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_PaperVerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_PaperVerEN> arrObjLst = new List<clsgs_PaperVerEN>(); 
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
	clsgs_PaperVerEN objgs_PaperVerEN = new clsgs_PaperVerEN();
try
{
objgs_PaperVerEN.PaperVId = Int32.Parse(objRow[congs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objgs_PaperVerEN.PaperId = objRow[congs_PaperVer.PaperId].ToString().Trim(); //论文Id
objgs_PaperVerEN.PaperTitle = objRow[congs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objgs_PaperVerEN.PaperContent = objRow[congs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[congs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objgs_PaperVerEN.Periodical = objRow[congs_PaperVer.Periodical] == DBNull.Value ? null : objRow[congs_PaperVer.Periodical].ToString().Trim(); //期刊
objgs_PaperVerEN.Author = objRow[congs_PaperVer.Author] == DBNull.Value ? null : objRow[congs_PaperVer.Author].ToString().Trim(); //作者
objgs_PaperVerEN.ResearchQuestion = objRow[congs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[congs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objgs_PaperVerEN.Keyword = objRow[congs_PaperVer.Keyword] == DBNull.Value ? null : objRow[congs_PaperVer.Keyword].ToString().Trim(); //关键字
objgs_PaperVerEN.LiteratureSources = objRow[congs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objgs_PaperVerEN.LiteratureLink = objRow[congs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objgs_PaperVerEN.UploadfileUrl = objRow[congs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[congs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objgs_PaperVerEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objgs_PaperVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperVerEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objgs_PaperVerEN.QuoteId = objRow[congs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[congs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objgs_PaperVerEN.Checker = objRow[congs_PaperVer.Checker] == DBNull.Value ? null : objRow[congs_PaperVer.Checker].ToString().Trim(); //审核人
objgs_PaperVerEN.LiteratureTypeId = objRow[congs_PaperVer.LiteratureTypeId].ToString().Trim(); //文献类型Id
objgs_PaperVerEN.UpdUser = objRow[congs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperVerEN.UpdDate = objRow[congs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperVerEN.IdCurrEduCls = objRow[congs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperVerEN.PaperTypeId = objRow[congs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objgs_PaperVerEN.PaperStatusId = objRow[congs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objgs_PaperVerEN.Memo = objRow[congs_PaperVer.Memo] == DBNull.Value ? null : objRow[congs_PaperVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperVerEN.PaperVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperVerEN);
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
public static List<clsgs_PaperVerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_PaperVerEN> arrObjLst = new List<clsgs_PaperVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperVerEN objgs_PaperVerEN = new clsgs_PaperVerEN();
try
{
objgs_PaperVerEN.PaperVId = Int32.Parse(objRow[congs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objgs_PaperVerEN.PaperId = objRow[congs_PaperVer.PaperId].ToString().Trim(); //论文Id
objgs_PaperVerEN.PaperTitle = objRow[congs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objgs_PaperVerEN.PaperContent = objRow[congs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[congs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objgs_PaperVerEN.Periodical = objRow[congs_PaperVer.Periodical] == DBNull.Value ? null : objRow[congs_PaperVer.Periodical].ToString().Trim(); //期刊
objgs_PaperVerEN.Author = objRow[congs_PaperVer.Author] == DBNull.Value ? null : objRow[congs_PaperVer.Author].ToString().Trim(); //作者
objgs_PaperVerEN.ResearchQuestion = objRow[congs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[congs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objgs_PaperVerEN.Keyword = objRow[congs_PaperVer.Keyword] == DBNull.Value ? null : objRow[congs_PaperVer.Keyword].ToString().Trim(); //关键字
objgs_PaperVerEN.LiteratureSources = objRow[congs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objgs_PaperVerEN.LiteratureLink = objRow[congs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objgs_PaperVerEN.UploadfileUrl = objRow[congs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[congs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objgs_PaperVerEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objgs_PaperVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperVerEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objgs_PaperVerEN.QuoteId = objRow[congs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[congs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objgs_PaperVerEN.Checker = objRow[congs_PaperVer.Checker] == DBNull.Value ? null : objRow[congs_PaperVer.Checker].ToString().Trim(); //审核人
objgs_PaperVerEN.LiteratureTypeId = objRow[congs_PaperVer.LiteratureTypeId].ToString().Trim(); //文献类型Id
objgs_PaperVerEN.UpdUser = objRow[congs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperVerEN.UpdDate = objRow[congs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperVerEN.IdCurrEduCls = objRow[congs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperVerEN.PaperTypeId = objRow[congs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objgs_PaperVerEN.PaperStatusId = objRow[congs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objgs_PaperVerEN.Memo = objRow[congs_PaperVer.Memo] == DBNull.Value ? null : objRow[congs_PaperVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperVerEN.PaperVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_PaperVerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_PaperVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_PaperVerEN> arrObjLst = new List<clsgs_PaperVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperVerEN objgs_PaperVerEN = new clsgs_PaperVerEN();
try
{
objgs_PaperVerEN.PaperVId = Int32.Parse(objRow[congs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objgs_PaperVerEN.PaperId = objRow[congs_PaperVer.PaperId].ToString().Trim(); //论文Id
objgs_PaperVerEN.PaperTitle = objRow[congs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objgs_PaperVerEN.PaperContent = objRow[congs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[congs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objgs_PaperVerEN.Periodical = objRow[congs_PaperVer.Periodical] == DBNull.Value ? null : objRow[congs_PaperVer.Periodical].ToString().Trim(); //期刊
objgs_PaperVerEN.Author = objRow[congs_PaperVer.Author] == DBNull.Value ? null : objRow[congs_PaperVer.Author].ToString().Trim(); //作者
objgs_PaperVerEN.ResearchQuestion = objRow[congs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[congs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objgs_PaperVerEN.Keyword = objRow[congs_PaperVer.Keyword] == DBNull.Value ? null : objRow[congs_PaperVer.Keyword].ToString().Trim(); //关键字
objgs_PaperVerEN.LiteratureSources = objRow[congs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objgs_PaperVerEN.LiteratureLink = objRow[congs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objgs_PaperVerEN.UploadfileUrl = objRow[congs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[congs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objgs_PaperVerEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objgs_PaperVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperVerEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objgs_PaperVerEN.QuoteId = objRow[congs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[congs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objgs_PaperVerEN.Checker = objRow[congs_PaperVer.Checker] == DBNull.Value ? null : objRow[congs_PaperVer.Checker].ToString().Trim(); //审核人
objgs_PaperVerEN.LiteratureTypeId = objRow[congs_PaperVer.LiteratureTypeId].ToString().Trim(); //文献类型Id
objgs_PaperVerEN.UpdUser = objRow[congs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperVerEN.UpdDate = objRow[congs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperVerEN.IdCurrEduCls = objRow[congs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperVerEN.PaperTypeId = objRow[congs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objgs_PaperVerEN.PaperStatusId = objRow[congs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objgs_PaperVerEN.Memo = objRow[congs_PaperVer.Memo] == DBNull.Value ? null : objRow[congs_PaperVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperVerEN.PaperVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperVerEN);
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
public static List<clsgs_PaperVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_PaperVerEN> arrObjLst = new List<clsgs_PaperVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperVerEN objgs_PaperVerEN = new clsgs_PaperVerEN();
try
{
objgs_PaperVerEN.PaperVId = Int32.Parse(objRow[congs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objgs_PaperVerEN.PaperId = objRow[congs_PaperVer.PaperId].ToString().Trim(); //论文Id
objgs_PaperVerEN.PaperTitle = objRow[congs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objgs_PaperVerEN.PaperContent = objRow[congs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[congs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objgs_PaperVerEN.Periodical = objRow[congs_PaperVer.Periodical] == DBNull.Value ? null : objRow[congs_PaperVer.Periodical].ToString().Trim(); //期刊
objgs_PaperVerEN.Author = objRow[congs_PaperVer.Author] == DBNull.Value ? null : objRow[congs_PaperVer.Author].ToString().Trim(); //作者
objgs_PaperVerEN.ResearchQuestion = objRow[congs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[congs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objgs_PaperVerEN.Keyword = objRow[congs_PaperVer.Keyword] == DBNull.Value ? null : objRow[congs_PaperVer.Keyword].ToString().Trim(); //关键字
objgs_PaperVerEN.LiteratureSources = objRow[congs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objgs_PaperVerEN.LiteratureLink = objRow[congs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objgs_PaperVerEN.UploadfileUrl = objRow[congs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[congs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objgs_PaperVerEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objgs_PaperVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperVerEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objgs_PaperVerEN.QuoteId = objRow[congs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[congs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objgs_PaperVerEN.Checker = objRow[congs_PaperVer.Checker] == DBNull.Value ? null : objRow[congs_PaperVer.Checker].ToString().Trim(); //审核人
objgs_PaperVerEN.LiteratureTypeId = objRow[congs_PaperVer.LiteratureTypeId].ToString().Trim(); //文献类型Id
objgs_PaperVerEN.UpdUser = objRow[congs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperVerEN.UpdDate = objRow[congs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperVerEN.IdCurrEduCls = objRow[congs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperVerEN.PaperTypeId = objRow[congs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objgs_PaperVerEN.PaperStatusId = objRow[congs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objgs_PaperVerEN.Memo = objRow[congs_PaperVer.Memo] == DBNull.Value ? null : objRow[congs_PaperVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperVerEN.PaperVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_PaperVerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_PaperVerEN> arrObjLst = new List<clsgs_PaperVerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperVerEN objgs_PaperVerEN = new clsgs_PaperVerEN();
try
{
objgs_PaperVerEN.PaperVId = Int32.Parse(objRow[congs_PaperVer.PaperVId].ToString().Trim()); //PaperVId
objgs_PaperVerEN.PaperId = objRow[congs_PaperVer.PaperId].ToString().Trim(); //论文Id
objgs_PaperVerEN.PaperTitle = objRow[congs_PaperVer.PaperTitle].ToString().Trim(); //论文标题
objgs_PaperVerEN.PaperContent = objRow[congs_PaperVer.PaperContent] == DBNull.Value ? null : objRow[congs_PaperVer.PaperContent].ToString().Trim(); //主题内容
objgs_PaperVerEN.Periodical = objRow[congs_PaperVer.Periodical] == DBNull.Value ? null : objRow[congs_PaperVer.Periodical].ToString().Trim(); //期刊
objgs_PaperVerEN.Author = objRow[congs_PaperVer.Author] == DBNull.Value ? null : objRow[congs_PaperVer.Author].ToString().Trim(); //作者
objgs_PaperVerEN.ResearchQuestion = objRow[congs_PaperVer.ResearchQuestion] == DBNull.Value ? null : objRow[congs_PaperVer.ResearchQuestion].ToString().Trim(); //研究问题
objgs_PaperVerEN.Keyword = objRow[congs_PaperVer.Keyword] == DBNull.Value ? null : objRow[congs_PaperVer.Keyword].ToString().Trim(); //关键字
objgs_PaperVerEN.LiteratureSources = objRow[congs_PaperVer.LiteratureSources] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureSources].ToString().Trim(); //文献来源
objgs_PaperVerEN.LiteratureLink = objRow[congs_PaperVer.LiteratureLink] == DBNull.Value ? null : objRow[congs_PaperVer.LiteratureLink].ToString().Trim(); //文献链接
objgs_PaperVerEN.UploadfileUrl = objRow[congs_PaperVer.UploadfileUrl] == DBNull.Value ? null : objRow[congs_PaperVer.UploadfileUrl].ToString().Trim(); //文件地址
objgs_PaperVerEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsQuotethesis].ToString().Trim()); //是否引用论文
objgs_PaperVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperVerEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperVer.IsChecked].ToString().Trim()); //是否检查
objgs_PaperVerEN.QuoteId = objRow[congs_PaperVer.QuoteId] == DBNull.Value ? null : objRow[congs_PaperVer.QuoteId].ToString().Trim(); //引用Id
objgs_PaperVerEN.Checker = objRow[congs_PaperVer.Checker] == DBNull.Value ? null : objRow[congs_PaperVer.Checker].ToString().Trim(); //审核人
objgs_PaperVerEN.LiteratureTypeId = objRow[congs_PaperVer.LiteratureTypeId].ToString().Trim(); //文献类型Id
objgs_PaperVerEN.UpdUser = objRow[congs_PaperVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperVerEN.UpdDate = objRow[congs_PaperVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperVerEN.IdCurrEduCls = objRow[congs_PaperVer.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperVerEN.PaperTypeId = objRow[congs_PaperVer.PaperTypeId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperTypeId].ToString().Trim(); //论文类型Id
objgs_PaperVerEN.PaperStatusId = objRow[congs_PaperVer.PaperStatusId] == DBNull.Value ? null : objRow[congs_PaperVer.PaperStatusId].ToString().Trim(); //论文状态Id
objgs_PaperVerEN.Memo = objRow[congs_PaperVer.Memo] == DBNull.Value ? null : objRow[congs_PaperVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperVerEN.PaperVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperVerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_PaperVer(ref clsgs_PaperVerEN objgs_PaperVerEN)
{
bool bolResult = gs_PaperVerDA.Getgs_PaperVer(ref objgs_PaperVerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperVId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_PaperVerEN GetObjByPaperVId(long lngPaperVId)
{
clsgs_PaperVerEN objgs_PaperVerEN = gs_PaperVerDA.GetObjByPaperVId(lngPaperVId);
return objgs_PaperVerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_PaperVerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_PaperVerEN objgs_PaperVerEN = gs_PaperVerDA.GetFirstObj(strWhereCond);
 return objgs_PaperVerEN;
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
public static clsgs_PaperVerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_PaperVerEN objgs_PaperVerEN = gs_PaperVerDA.GetObjByDataRow(objRow);
 return objgs_PaperVerEN;
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
public static clsgs_PaperVerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_PaperVerEN objgs_PaperVerEN = gs_PaperVerDA.GetObjByDataRow(objRow);
 return objgs_PaperVerEN;
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
 /// <param name = "lstgs_PaperVerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_PaperVerEN GetObjByPaperVIdFromList(long lngPaperVId, List<clsgs_PaperVerEN> lstgs_PaperVerObjLst)
{
foreach (clsgs_PaperVerEN objgs_PaperVerEN in lstgs_PaperVerObjLst)
{
if (objgs_PaperVerEN.PaperVId == lngPaperVId)
{
return objgs_PaperVerEN;
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
 lngPaperVId = new clsgs_PaperVerDA().GetFirstID(strWhereCond);
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
 arrList = gs_PaperVerDA.GetID(strWhereCond);
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
bool bolIsExist = gs_PaperVerDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = gs_PaperVerDA.IsExist(lngPaperVId);
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
 bolIsExist = clsgs_PaperVerDA.IsExistTable();
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
 bolIsExist = gs_PaperVerDA.IsExistTable(strTabName);
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


 #region 添加记录

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_PaperVerEN objgs_PaperVerEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_PaperVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!PaperVId = [{0}]的数据已经存在!(in clsgs_PaperVerBL.AddNewRecordBySql2)", objgs_PaperVerEN.PaperVId);
throw new Exception(strMsg);
}
try
{
bool bolResult = gs_PaperVerDA.AddNewRecordBySQL2(objgs_PaperVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperVerBL.ReFreshCache();

if (clsgs_PaperVerBL.relatedActions != null)
{
clsgs_PaperVerBL.relatedActions.UpdRelaTabDate(objgs_PaperVerEN.PaperVId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000030)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_PaperVerEN objgs_PaperVerEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_PaperVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!PaperVId = [{0}]的数据已经存在!(in clsgs_PaperVerBL.AddNewRecordBySql2WithReturnKey)", objgs_PaperVerEN.PaperVId);
throw new Exception(strMsg);
}
try
{
string strKey = gs_PaperVerDA.AddNewRecordBySQL2WithReturnKey(objgs_PaperVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperVerBL.ReFreshCache();

if (clsgs_PaperVerBL.relatedActions != null)
{
clsgs_PaperVerBL.relatedActions.UpdRelaTabDate(objgs_PaperVerEN.PaperVId, "SetUpdDate");
}
return strKey;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000049)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 添加记录


 #region 修改记录

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Update)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_PaperVerEN objgs_PaperVerEN)
{
try
{
bool bolResult = gs_PaperVerDA.Update(objgs_PaperVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperVerBL.ReFreshCache();

if (clsgs_PaperVerBL.relatedActions != null)
{
clsgs_PaperVerBL.relatedActions.UpdRelaTabDate(objgs_PaperVerEN.PaperVId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000033)修改记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql2)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_PaperVerEN objgs_PaperVerEN)
{
 if (objgs_PaperVerEN.PaperVId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_PaperVerDA.UpdateBySql2(objgs_PaperVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperVerBL.ReFreshCache();

if (clsgs_PaperVerBL.relatedActions != null)
{
clsgs_PaperVerBL.relatedActions.UpdRelaTabDate(objgs_PaperVerEN.PaperVId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000034)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 修改记录


 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord)
 /// </summary>
 /// <param name = "lngPaperVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngPaperVId)
{
try
{
 clsgs_PaperVerEN objgs_PaperVerEN = clsgs_PaperVerBL.GetObjByPaperVId(lngPaperVId);

if (clsgs_PaperVerBL.relatedActions != null)
{
clsgs_PaperVerBL.relatedActions.UpdRelaTabDate(objgs_PaperVerEN.PaperVId, "SetUpdDate");
}
if (objgs_PaperVerEN != null)
{
int intRecNum = gs_PaperVerDA.DelRecord(lngPaperVId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum;
}
            else
{
return 0;
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000039)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="lngPaperVId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngPaperVId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[gs_PaperVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_PaperVer.PaperVId,
//lngPaperVId);
//        clsgs_PaperVerBL.Delgs_PaperVersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_PaperVerBL.DelRecord(lngPaperVId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_PaperVerBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngPaperVId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordWithTransaction_S)
 /// </summary>
 /// <param name = "lngPaperVId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngPaperVId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsgs_PaperVerBL.relatedActions != null)
{
clsgs_PaperVerBL.relatedActions.UpdRelaTabDate(lngPaperVId, "UpdRelaTabDate");
}
bool bolResult = gs_PaperVerDA.DelRecord(lngPaperVId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000040)根据关键字删除记录出错!(使用事务),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecord)
 /// </summary>
 /// <param name = "arrPaperVIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delgs_PaperVers(List<string> arrPaperVIdLst)
{
if (arrPaperVIdLst.Count == 0) return 0;
try
{
if (clsgs_PaperVerBL.relatedActions != null)
{
foreach (var strPaperVId in arrPaperVIdLst)
{
long lngPaperVId = long.Parse(strPaperVId);
clsgs_PaperVerBL.relatedActions.UpdRelaTabDate(lngPaperVId, "UpdRelaTabDate");
}
}
int intDelRecNum = gs_PaperVerDA.Delgs_PaperVer(arrPaperVIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intDelRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000042)删除多关键字记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public static int Delgs_PaperVersByCond(string strWhereCond)
{
try
{
if (clsgs_PaperVerBL.relatedActions != null)
{
List<string> arrPaperVId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPaperVId in arrPaperVId)
{
long lngPaperVId = long.Parse(strPaperVId);
clsgs_PaperVerBL.relatedActions.UpdRelaTabDate(lngPaperVId, "UpdRelaTabDate");
}
}
int intRecNum = gs_PaperVerDA.Delgs_PaperVer(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000043)删除带条件表记录出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_PaperVer]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngPaperVId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngPaperVId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_PaperVerDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[gs_PaperVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_PaperVerBL.DelRecord(lngPaperVId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_PaperVerBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngPaperVId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}


 #endregion 删除记录


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objgs_PaperVerENS">源对象</param>
 /// <param name = "objgs_PaperVerENT">目标对象</param>
 public static void CopyTo(clsgs_PaperVerEN objgs_PaperVerENS, clsgs_PaperVerEN objgs_PaperVerENT)
{
try
{
objgs_PaperVerENT.PaperVId = objgs_PaperVerENS.PaperVId; //PaperVId
objgs_PaperVerENT.PaperId = objgs_PaperVerENS.PaperId; //论文Id
objgs_PaperVerENT.PaperTitle = objgs_PaperVerENS.PaperTitle; //论文标题
objgs_PaperVerENT.PaperContent = objgs_PaperVerENS.PaperContent; //主题内容
objgs_PaperVerENT.Periodical = objgs_PaperVerENS.Periodical; //期刊
objgs_PaperVerENT.Author = objgs_PaperVerENS.Author; //作者
objgs_PaperVerENT.ResearchQuestion = objgs_PaperVerENS.ResearchQuestion; //研究问题
objgs_PaperVerENT.Keyword = objgs_PaperVerENS.Keyword; //关键字
objgs_PaperVerENT.LiteratureSources = objgs_PaperVerENS.LiteratureSources; //文献来源
objgs_PaperVerENT.LiteratureLink = objgs_PaperVerENS.LiteratureLink; //文献链接
objgs_PaperVerENT.UploadfileUrl = objgs_PaperVerENS.UploadfileUrl; //文件地址
objgs_PaperVerENT.IsQuotethesis = objgs_PaperVerENS.IsQuotethesis; //是否引用论文
objgs_PaperVerENT.IsSubmit = objgs_PaperVerENS.IsSubmit; //是否提交
objgs_PaperVerENT.IsChecked = objgs_PaperVerENS.IsChecked; //是否检查
objgs_PaperVerENT.QuoteId = objgs_PaperVerENS.QuoteId; //引用Id
objgs_PaperVerENT.Checker = objgs_PaperVerENS.Checker; //审核人
objgs_PaperVerENT.LiteratureTypeId = objgs_PaperVerENS.LiteratureTypeId; //文献类型Id
objgs_PaperVerENT.UpdUser = objgs_PaperVerENS.UpdUser; //修改人
objgs_PaperVerENT.UpdDate = objgs_PaperVerENS.UpdDate; //修改日期
objgs_PaperVerENT.IdCurrEduCls = objgs_PaperVerENS.IdCurrEduCls; //教学班流水号
objgs_PaperVerENT.PaperTypeId = objgs_PaperVerENS.PaperTypeId; //论文类型Id
objgs_PaperVerENT.PaperStatusId = objgs_PaperVerENS.PaperStatusId; //论文状态Id
objgs_PaperVerENT.Memo = objgs_PaperVerENS.Memo; //备注
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
 /// <param name = "objgs_PaperVerEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_PaperVerEN objgs_PaperVerEN)
{
try
{
objgs_PaperVerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_PaperVerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_PaperVer.PaperVId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperVerEN.PaperVId = objgs_PaperVerEN.PaperVId; //PaperVId
}
if (arrFldSet.Contains(congs_PaperVer.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperVerEN.PaperId = objgs_PaperVerEN.PaperId; //论文Id
}
if (arrFldSet.Contains(congs_PaperVer.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperVerEN.PaperTitle = objgs_PaperVerEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(congs_PaperVer.PaperContent, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperVerEN.PaperContent = objgs_PaperVerEN.PaperContent == "[null]" ? null :  objgs_PaperVerEN.PaperContent; //主题内容
}
if (arrFldSet.Contains(congs_PaperVer.Periodical, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperVerEN.Periodical = objgs_PaperVerEN.Periodical == "[null]" ? null :  objgs_PaperVerEN.Periodical; //期刊
}
if (arrFldSet.Contains(congs_PaperVer.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperVerEN.Author = objgs_PaperVerEN.Author == "[null]" ? null :  objgs_PaperVerEN.Author; //作者
}
if (arrFldSet.Contains(congs_PaperVer.ResearchQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperVerEN.ResearchQuestion = objgs_PaperVerEN.ResearchQuestion == "[null]" ? null :  objgs_PaperVerEN.ResearchQuestion; //研究问题
}
if (arrFldSet.Contains(congs_PaperVer.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperVerEN.Keyword = objgs_PaperVerEN.Keyword == "[null]" ? null :  objgs_PaperVerEN.Keyword; //关键字
}
if (arrFldSet.Contains(congs_PaperVer.LiteratureSources, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperVerEN.LiteratureSources = objgs_PaperVerEN.LiteratureSources == "[null]" ? null :  objgs_PaperVerEN.LiteratureSources; //文献来源
}
if (arrFldSet.Contains(congs_PaperVer.LiteratureLink, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperVerEN.LiteratureLink = objgs_PaperVerEN.LiteratureLink == "[null]" ? null :  objgs_PaperVerEN.LiteratureLink; //文献链接
}
if (arrFldSet.Contains(congs_PaperVer.UploadfileUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperVerEN.UploadfileUrl = objgs_PaperVerEN.UploadfileUrl == "[null]" ? null :  objgs_PaperVerEN.UploadfileUrl; //文件地址
}
if (arrFldSet.Contains(congs_PaperVer.IsQuotethesis, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperVerEN.IsQuotethesis = objgs_PaperVerEN.IsQuotethesis; //是否引用论文
}
if (arrFldSet.Contains(congs_PaperVer.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperVerEN.IsSubmit = objgs_PaperVerEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(congs_PaperVer.IsChecked, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperVerEN.IsChecked = objgs_PaperVerEN.IsChecked; //是否检查
}
if (arrFldSet.Contains(congs_PaperVer.QuoteId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperVerEN.QuoteId = objgs_PaperVerEN.QuoteId == "[null]" ? null :  objgs_PaperVerEN.QuoteId; //引用Id
}
if (arrFldSet.Contains(congs_PaperVer.Checker, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperVerEN.Checker = objgs_PaperVerEN.Checker == "[null]" ? null :  objgs_PaperVerEN.Checker; //审核人
}
if (arrFldSet.Contains(congs_PaperVer.LiteratureTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperVerEN.LiteratureTypeId = objgs_PaperVerEN.LiteratureTypeId; //文献类型Id
}
if (arrFldSet.Contains(congs_PaperVer.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperVerEN.UpdUser = objgs_PaperVerEN.UpdUser == "[null]" ? null :  objgs_PaperVerEN.UpdUser; //修改人
}
if (arrFldSet.Contains(congs_PaperVer.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperVerEN.UpdDate = objgs_PaperVerEN.UpdDate == "[null]" ? null :  objgs_PaperVerEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(congs_PaperVer.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperVerEN.IdCurrEduCls = objgs_PaperVerEN.IdCurrEduCls == "[null]" ? null :  objgs_PaperVerEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(congs_PaperVer.PaperTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperVerEN.PaperTypeId = objgs_PaperVerEN.PaperTypeId == "[null]" ? null :  objgs_PaperVerEN.PaperTypeId; //论文类型Id
}
if (arrFldSet.Contains(congs_PaperVer.PaperStatusId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperVerEN.PaperStatusId = objgs_PaperVerEN.PaperStatusId == "[null]" ? null :  objgs_PaperVerEN.PaperStatusId; //论文状态Id
}
if (arrFldSet.Contains(congs_PaperVer.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperVerEN.Memo = objgs_PaperVerEN.Memo == "[null]" ? null :  objgs_PaperVerEN.Memo; //备注
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
 /// <param name = "objgs_PaperVerEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_PaperVerEN objgs_PaperVerEN)
{
try
{
if (objgs_PaperVerEN.PaperContent == "[null]") objgs_PaperVerEN.PaperContent = null; //主题内容
if (objgs_PaperVerEN.Periodical == "[null]") objgs_PaperVerEN.Periodical = null; //期刊
if (objgs_PaperVerEN.Author == "[null]") objgs_PaperVerEN.Author = null; //作者
if (objgs_PaperVerEN.ResearchQuestion == "[null]") objgs_PaperVerEN.ResearchQuestion = null; //研究问题
if (objgs_PaperVerEN.Keyword == "[null]") objgs_PaperVerEN.Keyword = null; //关键字
if (objgs_PaperVerEN.LiteratureSources == "[null]") objgs_PaperVerEN.LiteratureSources = null; //文献来源
if (objgs_PaperVerEN.LiteratureLink == "[null]") objgs_PaperVerEN.LiteratureLink = null; //文献链接
if (objgs_PaperVerEN.UploadfileUrl == "[null]") objgs_PaperVerEN.UploadfileUrl = null; //文件地址
if (objgs_PaperVerEN.QuoteId == "[null]") objgs_PaperVerEN.QuoteId = null; //引用Id
if (objgs_PaperVerEN.Checker == "[null]") objgs_PaperVerEN.Checker = null; //审核人
if (objgs_PaperVerEN.UpdUser == "[null]") objgs_PaperVerEN.UpdUser = null; //修改人
if (objgs_PaperVerEN.UpdDate == "[null]") objgs_PaperVerEN.UpdDate = null; //修改日期
if (objgs_PaperVerEN.IdCurrEduCls == "[null]") objgs_PaperVerEN.IdCurrEduCls = null; //教学班流水号
if (objgs_PaperVerEN.PaperTypeId == "[null]") objgs_PaperVerEN.PaperTypeId = null; //论文类型Id
if (objgs_PaperVerEN.PaperStatusId == "[null]") objgs_PaperVerEN.PaperStatusId = null; //论文状态Id
if (objgs_PaperVerEN.Memo == "[null]") objgs_PaperVerEN.Memo = null; //备注
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsgs_PaperVerEN objgs_PaperVerEN)
{
 gs_PaperVerDA.CheckPropertyNew(objgs_PaperVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_PaperVerEN objgs_PaperVerEN)
{
 gs_PaperVerDA.CheckProperty4Condition(objgs_PaperVerEN);
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
if (clsgs_PaperVerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PaperVerBL没有刷新缓存机制(clsgs_PaperVerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperVId");
//if (arrgs_PaperVerObjLstCache == null)
//{
//arrgs_PaperVerObjLstCache = gs_PaperVerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngPaperVId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_PaperVerEN GetObjByPaperVIdCache(long lngPaperVId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsgs_PaperVerEN._CurrTabName);
List<clsgs_PaperVerEN> arrgs_PaperVerObjLstCache = GetObjLstCache();
IEnumerable <clsgs_PaperVerEN> arrgs_PaperVerObjLst_Sel =
arrgs_PaperVerObjLstCache
.Where(x=> x.PaperVId == lngPaperVId 
);
if (arrgs_PaperVerObjLst_Sel.Count() == 0)
{
   clsgs_PaperVerEN obj = clsgs_PaperVerBL.GetObjByPaperVId(lngPaperVId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrgs_PaperVerObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_PaperVerEN> GetAllgs_PaperVerObjLstCache()
{
//获取缓存中的对象列表
List<clsgs_PaperVerEN> arrgs_PaperVerObjLstCache = GetObjLstCache(); 
return arrgs_PaperVerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_PaperVerEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsgs_PaperVerEN._CurrTabName);
List<clsgs_PaperVerEN> arrgs_PaperVerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrgs_PaperVerObjLstCache;
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
string strKey = string.Format("{0}", clsgs_PaperVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_PaperVerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsgs_PaperVerEN._RefreshTimeLst.Count == 0) return "";
return clsgs_PaperVerEN._RefreshTimeLst[clsgs_PaperVerEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsgs_PaperVerBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsgs_PaperVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_PaperVerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_PaperVerBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_PaperVer(论文历史版本表)
 /// 唯一性条件:PaperVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_PaperVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_PaperVerEN objgs_PaperVerEN)
{
//检测记录是否存在
string strResult = gs_PaperVerDA.GetUniCondStr(objgs_PaperVerEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-11-13
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngPaperVId)
{
if (strInFldName != congs_PaperVer.PaperVId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_PaperVer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_PaperVer.AttributeName));
throw new Exception(strMsg);
}
var objgs_PaperVer = clsgs_PaperVerBL.GetObjByPaperVIdCache(lngPaperVId);
if (objgs_PaperVer == null) return "";
return objgs_PaperVer[strOutFldName].ToString();
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
int intRecCount = clsgs_PaperVerDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_PaperVerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_PaperVerDA.GetRecCount();
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
int intRecCount = clsgs_PaperVerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_PaperVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_PaperVerEN objgs_PaperVerCond)
{
List<clsgs_PaperVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_PaperVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_PaperVer.AttributeName)
{
if (objgs_PaperVerCond.IsUpdated(strFldName) == false) continue;
if (objgs_PaperVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_PaperVerCond[strFldName].ToString());
}
else
{
if (objgs_PaperVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_PaperVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_PaperVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_PaperVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_PaperVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_PaperVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_PaperVerCond[strFldName]));
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
 List<string> arrList = clsgs_PaperVerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_PaperVerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_PaperVerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = gs_PaperVerDA.SetFldValue(strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}


 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "fltValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clsgs_PaperVerDA.SetFldValue(clsgs_PaperVerEN._CurrTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "intValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = gs_PaperVerDA.SetFldValue( strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = clsgs_PaperVerDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = clsgs_PaperVerDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clsgs_PaperVerDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}



 #endregion 表操作常用函数


 #region 表操作

 /// <summary>
 /// 功能:获取建立表的代码
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GenSQLCode4CreateTab)
 /// </summary>
 /// <returns>建立表的代码</returns>
public static string GetCode4CreateTable() 
{
 StringBuilder strCreateTabCode = new StringBuilder();
  strCreateTabCode.Append("CREATE table [dbo].[gs_PaperVer] "); 
 strCreateTabCode.Append(" ( "); 
 // /**PaperVId*/ 
 strCreateTabCode.Append(" PaperVId bigint primary key identity, "); 
 // /**论文Id*/ 
 strCreateTabCode.Append(" PaperId char(8) not Null, "); 
 // /**论文标题*/ 
 strCreateTabCode.Append(" PaperTitle varchar(500) not Null, "); 
 // /**主题内容*/ 
 strCreateTabCode.Append(" PaperContent text Null, "); 
 // /**期刊*/ 
 strCreateTabCode.Append(" Periodical varchar(100) Null, "); 
 // /**作者*/ 
 strCreateTabCode.Append(" Author varchar(200) Null, "); 
 // /**研究问题*/ 
 strCreateTabCode.Append(" ResearchQuestion varchar(2000) Null, "); 
 // /**关键字*/ 
 strCreateTabCode.Append(" Keyword varchar(1000) Null, "); 
 // /**文献来源*/ 
 strCreateTabCode.Append(" LiteratureSources varchar(1000) Null, "); 
 // /**文献链接*/ 
 strCreateTabCode.Append(" LiteratureLink varchar(1000) Null, "); 
 // /**文件地址*/ 
 strCreateTabCode.Append(" UploadfileUrl varchar(1000) Null, "); 
 // /**是否引用论文*/ 
 strCreateTabCode.Append(" IsQuotethesis bit Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**是否检查*/ 
 strCreateTabCode.Append(" IsChecked bit Null, "); 
 // /**引用Id*/ 
 strCreateTabCode.Append(" QuoteId char(8) Null, "); 
 // /**审核人*/ 
 strCreateTabCode.Append(" Checker varchar(20) Null, "); 
 // /**文献类型Id*/ 
 strCreateTabCode.Append(" LiteratureTypeId char(2) not Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**论文类型Id*/ 
 strCreateTabCode.Append(" PaperTypeId char(2) Null, "); 
 // /**论文状态Id*/ 
 strCreateTabCode.Append(" PaperStatusId char(2) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 论文历史版本表(gs_PaperVer)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_PaperVer : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg;
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
clsgs_PaperVerBL.ReFreshThisCache();
}
}

}