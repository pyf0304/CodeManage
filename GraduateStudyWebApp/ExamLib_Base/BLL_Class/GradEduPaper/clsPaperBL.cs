
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperBL
 表名:Paper(01120535)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:36
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
public static class  clsPaperBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPaperEN GetObj(this K_PaperId_Paper myKey)
{
clsPaperEN objPaperEN = clsPaperBL.PaperDA.GetObjByPaperId(myKey.Value);
return objPaperEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPaperEN objPaperEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPaperEN) == false)
{
var strMsg = string.Format("记录已经存在!论文标题 = [{0}],作者 = [{1}]的数据已经存在!(in clsPaperBL.AddNewRecord)", objPaperEN.PaperTitle,objPaperEN.Author);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPaperEN.PaperId) == true || clsPaperBL.IsExist(objPaperEN.PaperId) == true)
 {
     objPaperEN.PaperId = clsPaperBL.GetMaxStrId_S();
 }
bool bolResult = clsPaperBL.PaperDA.AddNewRecordBySQL2(objPaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperBL.ReFreshCache();

if (clsPaperBL.relatedActions != null)
{
clsPaperBL.relatedActions.UpdRelaTabDate(objPaperEN.PaperId, "SetUpdDate");
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
public static bool AddRecordEx(this clsPaperEN objPaperEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsPaperBL.IsExist(objPaperEN.PaperId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objPaperEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objPaperEN.CheckUniqueness() == false)
{
strMsg = string.Format("(论文标题(PaperTitle)=[{0}],作者(Author)=[{1}])已经存在,不能重复!", objPaperEN.PaperTitle, objPaperEN.Author);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objPaperEN.PaperId) == true || clsPaperBL.IsExist(objPaperEN.PaperId) == true)
 {
     objPaperEN.PaperId = clsPaperBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objPaperEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值。该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objPaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsPaperEN objPaperEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPaperEN) == false)
{
var strMsg = string.Format("记录已经存在!论文标题 = [{0}],作者 = [{1}]的数据已经存在!(in clsPaperBL.AddNewRecordWithMaxId)", objPaperEN.PaperTitle,objPaperEN.Author);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPaperEN.PaperId) == true || clsPaperBL.IsExist(objPaperEN.PaperId) == true)
 {
     objPaperEN.PaperId = clsPaperBL.GetMaxStrId_S();
 }
string strPaperId = clsPaperBL.PaperDA.AddNewRecordBySQL2WithReturnKey(objPaperEN);
     objPaperEN.PaperId = strPaperId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperBL.ReFreshCache();

if (clsPaperBL.relatedActions != null)
{
clsPaperBL.relatedActions.UpdRelaTabDate(objPaperEN.PaperId, "SetUpdDate");
}
return strPaperId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000096)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objPaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPaperEN objPaperEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPaperEN) == false)
{
var strMsg = string.Format("记录已经存在!论文标题 = [{0}],作者 = [{1}]的数据已经存在!(in clsPaperBL.AddNewRecordWithReturnKey)", objPaperEN.PaperTitle,objPaperEN.Author);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPaperEN.PaperId) == true || clsPaperBL.IsExist(objPaperEN.PaperId) == true)
 {
     objPaperEN.PaperId = clsPaperBL.GetMaxStrId_S();
 }
string strKey = clsPaperBL.PaperDA.AddNewRecordBySQL2WithReturnKey(objPaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperBL.ReFreshCache();

if (clsPaperBL.relatedActions != null)
{
clsPaperBL.relatedActions.UpdRelaTabDate(objPaperEN.PaperId, "SetUpdDate");
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
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetPaperId(this clsPaperEN objPaperEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, conPaper.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, conPaper.PaperId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetPaperTitle(this clsPaperEN objPaperEN, string strPaperTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperTitle, conPaper.PaperTitle);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, conPaper.PaperTitle);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetPaperContent(this clsPaperEN objPaperEN, string strPaperContent, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetPeriodical(this clsPaperEN objPaperEN, string strPeriodical, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPeriodical, 100, conPaper.Periodical);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetAuthor(this clsPaperEN objPaperEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, conPaper.Author);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetResearchQuestion(this clsPaperEN objPaperEN, string strResearchQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, conPaper.ResearchQuestion);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetKeyword(this clsPaperEN objPaperEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, conPaper.Keyword);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetLiteratureSources(this clsPaperEN objPaperEN, string strLiteratureSources, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureSources, 1000, conPaper.LiteratureSources);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetLiteratureLink(this clsPaperEN objPaperEN, string strLiteratureLink, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureLink, 1000, conPaper.LiteratureLink);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetUploadfileUrl(this clsPaperEN objPaperEN, string strUploadfileUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadfileUrl, 1000, conPaper.UploadfileUrl);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetIsQuotethesis(this clsPaperEN objPaperEN, bool bolIsQuotethesis, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetQuoteId(this clsPaperEN objPaperEN, string strQuoteId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuoteId, 8, conPaper.QuoteId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuoteId, 8, conPaper.QuoteId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetIsChecked(this clsPaperEN objPaperEN, bool bolIsChecked, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetChecker(this clsPaperEN objPaperEN, string strChecker, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChecker, 20, conPaper.Checker);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetLiteratureTypeId(this clsPaperEN objPaperEN, string strLiteratureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLiteratureTypeId, conPaper.LiteratureTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureTypeId, 2, conPaper.LiteratureTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLiteratureTypeId, 2, conPaper.LiteratureTypeId);
}
objPaperEN.LiteratureTypeId = strLiteratureTypeId; //文献类型Id
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetBrowseNumber(this clsPaperEN objPaperEN, int? intBrowseNumber, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetIsSubmit(this clsPaperEN objPaperEN, bool bolIsSubmit, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetAppraiseCount(this clsPaperEN objPaperEN, int? intAppraiseCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetAttachmentCount(this clsPaperEN objPaperEN, int? intAttachmentCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetCollectionCount(this clsPaperEN objPaperEN, long? lngCollectionCount, string strComparisonOp="")
	{
objPaperEN.CollectionCount = lngCollectionCount; //收藏数量
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetDownloadCount(this clsPaperEN objPaperEN, int? intDownloadCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetOkCount(this clsPaperEN objPaperEN, int? intOkCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetPcount(this clsPaperEN objPaperEN, int? intPcount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetScore(this clsPaperEN objPaperEN, float? fltScore, string strComparisonOp="")
	{
objPaperEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.Score) == false)
{
objPaperEN.dicFldComparisonOp.Add(conPaper.Score, strComparisonOp);
}
else
{
objPaperEN.dicFldComparisonOp[conPaper.Score] = strComparisonOp;
}
}
return objPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetStuScore(this clsPaperEN objPaperEN, float? fltStuScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetTeaScore(this clsPaperEN objPaperEN, float? fltTeaScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetPaperTypeId(this clsPaperEN objPaperEN, string strPaperTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTypeId, 2, conPaper.PaperTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperTypeId, 2, conPaper.PaperTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetPaperStatusId(this clsPaperEN objPaperEN, string strPaperStatusId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperStatusId, 2, conPaper.PaperStatusId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperStatusId, 2, conPaper.PaperStatusId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetVersionCount(this clsPaperEN objPaperEN, int? intVersionCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetIsPublic(this clsPaperEN objPaperEN, bool bolIsPublic, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetAskQuestion(this clsPaperEN objPaperEN, string strAskQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAskQuestion, 5000, conPaper.AskQuestion);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetResearchStatus(this clsPaperEN objPaperEN, string strResearchStatus, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchStatus, 5000, conPaper.ResearchStatus);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetInnovationPoints(this clsPaperEN objPaperEN, string strInnovationPoints, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInnovationPoints, 5000, conPaper.InnovationPoints);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetResearchDesign(this clsPaperEN objPaperEN, string strResearchDesign, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchDesign, 5000, conPaper.ResearchDesign);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetDimensionDataProcess(this clsPaperEN objPaperEN, string strDimensionDataProcess, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDimensionDataProcess, 5000, conPaper.DimensionDataProcess);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetExpectedConclusion(this clsPaperEN objPaperEN, string strExpectedConclusion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExpectedConclusion, 5000, conPaper.ExpectedConclusion);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetShareId(this clsPaperEN objPaperEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, conPaper.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, conPaper.ShareId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetPaperQCount(this clsPaperEN objPaperEN, int? intPaperQCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetSubVCount(this clsPaperEN objPaperEN, int? intSubVCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetTagsCount(this clsPaperEN objPaperEN, int? intTagsCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetTeaQCount(this clsPaperEN objPaperEN, int? intTeaQCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetIdStudyLevel(this clsPaperEN objPaperEN, string strIdStudyLevel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, conPaper.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, conPaper.IdStudyLevel);
}
objPaperEN.IdStudyLevel = strIdStudyLevel; //学段流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.IdStudyLevel) == false)
{
objPaperEN.dicFldComparisonOp.Add(conPaper.IdStudyLevel, strComparisonOp);
}
else
{
objPaperEN.dicFldComparisonOp[conPaper.IdStudyLevel] = strComparisonOp;
}
}
return objPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetIdGrade(this clsPaperEN objPaperEN, string strIdGrade, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGrade, 4, conPaper.IdGrade);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGrade, 4, conPaper.IdGrade);
}
objPaperEN.IdGrade = strIdGrade; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperEN.dicFldComparisonOp.ContainsKey(conPaper.IdGrade) == false)
{
objPaperEN.dicFldComparisonOp.Add(conPaper.IdGrade, strComparisonOp);
}
else
{
objPaperEN.dicFldComparisonOp[conPaper.IdGrade] = strComparisonOp;
}
}
return objPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetCreateDate(this clsPaperEN objPaperEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conPaper.CreateDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetUpdUser(this clsPaperEN objPaperEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conPaper.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetUpdDate(this clsPaperEN objPaperEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPaper.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperEN SetMemo(this clsPaperEN objPaperEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPaper.Memo);
}
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
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPaperEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPaperEN objPaperEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPaperEN.CheckPropertyNew();
clsPaperEN objPaperCond = new clsPaperEN();
string strCondition = objPaperCond
.SetPaperId(objPaperEN.PaperId, "<>")
.SetPaperTitle(objPaperEN.PaperTitle, "=")
.SetAuthor(objPaperEN.Author, "=")
.GetCombineCondition();
objPaperEN._IsCheckProperty = true;
bool bolIsExist = clsPaperBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PaperTitle_Author)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPaperEN.Update();
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
 /// <param name = "objPaper">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsPaperEN objPaper)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsPaperEN objPaperCond = new clsPaperEN();
string strCondition = objPaperCond
.SetPaperTitle(objPaper.PaperTitle, "=")
.SetAuthor(objPaper.Author, "=")
.GetCombineCondition();
objPaper._IsCheckProperty = true;
bool bolIsExist = clsPaperBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objPaper.PaperId = clsPaperBL.GetFirstID_S(strCondition);
objPaper.UpdateWithCondition(strCondition);
}
else
{
objPaper.PaperId = clsPaperBL.GetMaxStrId_S();
objPaper.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPaperEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPaperEN objPaperEN)
{
 if (string.IsNullOrEmpty(objPaperEN.PaperId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPaperBL.PaperDA.UpdateBySql2(objPaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperBL.ReFreshCache();

if (clsPaperBL.relatedActions != null)
{
clsPaperBL.relatedActions.UpdRelaTabDate(objPaperEN.PaperId, "SetUpdDate");
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
 /// <param name = "objPaperEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPaperEN objPaperEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objPaperEN.PaperId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPaperBL.PaperDA.UpdateBySql2(objPaperEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperBL.ReFreshCache();

if (clsPaperBL.relatedActions != null)
{
clsPaperBL.relatedActions.UpdRelaTabDate(objPaperEN.PaperId, "SetUpdDate");
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
 /// <param name = "objPaperEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPaperEN objPaperEN, string strWhereCond)
{
try
{
bool bolResult = clsPaperBL.PaperDA.UpdateBySqlWithCondition(objPaperEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperBL.ReFreshCache();

if (clsPaperBL.relatedActions != null)
{
clsPaperBL.relatedActions.UpdRelaTabDate(objPaperEN.PaperId, "SetUpdDate");
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
 /// <param name = "objPaperEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPaperEN objPaperEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPaperBL.PaperDA.UpdateBySqlWithConditionTransaction(objPaperEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperBL.ReFreshCache();

if (clsPaperBL.relatedActions != null)
{
clsPaperBL.relatedActions.UpdRelaTabDate(objPaperEN.PaperId, "SetUpdDate");
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
 /// <param name = "strPaperId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPaperEN objPaperEN)
{
try
{
int intRecNum = clsPaperBL.PaperDA.DelRecord(objPaperEN.PaperId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperBL.ReFreshCache();

if (clsPaperBL.relatedActions != null)
{
clsPaperBL.relatedActions.UpdRelaTabDate(objPaperEN.PaperId, "SetUpdDate");
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
 /// <param name = "objPaperENS">源对象</param>
 /// <param name = "objPaperENT">目标对象</param>
 public static void CopyTo(this clsPaperEN objPaperENS, clsPaperEN objPaperENT)
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
objPaperENT.LiteratureTypeId = objPaperENS.LiteratureTypeId; //文献类型Id
objPaperENT.BrowseNumber = objPaperENS.BrowseNumber; //浏览量
objPaperENT.IsSubmit = objPaperENS.IsSubmit; //是否提交
objPaperENT.AppraiseCount = objPaperENS.AppraiseCount; //评论数
objPaperENT.AttachmentCount = objPaperENS.AttachmentCount; //附件计数
objPaperENT.CollectionCount = objPaperENS.CollectionCount; //收藏数量
objPaperENT.DownloadCount = objPaperENS.DownloadCount; //下载数
objPaperENT.OkCount = objPaperENS.OkCount; //点赞统计
objPaperENT.Pcount = objPaperENS.Pcount; //读写数
objPaperENT.Score = objPaperENS.Score; //评分
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
objPaperENT.IdStudyLevel = objPaperENS.IdStudyLevel; //学段流水号
objPaperENT.IdGrade = objPaperENS.IdGrade; //年级流水号
objPaperENT.CreateDate = objPaperENS.CreateDate; //建立日期
objPaperENT.UpdUser = objPaperENS.UpdUser; //修改人
objPaperENT.UpdDate = objPaperENS.UpdDate; //修改日期
objPaperENT.Memo = objPaperENS.Memo; //备注
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
 /// <param name = "objPaperENS">源对象</param>
 /// <returns>目标对象=>clsPaperEN:objPaperENT</returns>
 public static clsPaperEN CopyTo(this clsPaperEN objPaperENS)
{
try
{
 clsPaperEN objPaperENT = new clsPaperEN()
{
PaperId = objPaperENS.PaperId, //论文Id
PaperTitle = objPaperENS.PaperTitle, //论文标题
PaperContent = objPaperENS.PaperContent, //主题内容
Periodical = objPaperENS.Periodical, //期刊
Author = objPaperENS.Author, //作者
ResearchQuestion = objPaperENS.ResearchQuestion, //研究问题
Keyword = objPaperENS.Keyword, //关键字
LiteratureSources = objPaperENS.LiteratureSources, //文献来源
LiteratureLink = objPaperENS.LiteratureLink, //文献链接
UploadfileUrl = objPaperENS.UploadfileUrl, //文件地址
IsQuotethesis = objPaperENS.IsQuotethesis, //是否引用论文
QuoteId = objPaperENS.QuoteId, //引用Id
IsChecked = objPaperENS.IsChecked, //是否检查
Checker = objPaperENS.Checker, //审核人
LiteratureTypeId = objPaperENS.LiteratureTypeId, //文献类型Id
BrowseNumber = objPaperENS.BrowseNumber, //浏览量
IsSubmit = objPaperENS.IsSubmit, //是否提交
AppraiseCount = objPaperENS.AppraiseCount, //评论数
AttachmentCount = objPaperENS.AttachmentCount, //附件计数
CollectionCount = objPaperENS.CollectionCount, //收藏数量
DownloadCount = objPaperENS.DownloadCount, //下载数
OkCount = objPaperENS.OkCount, //点赞统计
Pcount = objPaperENS.Pcount, //读写数
Score = objPaperENS.Score, //评分
StuScore = objPaperENS.StuScore, //学生平均分
TeaScore = objPaperENS.TeaScore, //教师评分
PaperTypeId = objPaperENS.PaperTypeId, //论文类型Id
PaperStatusId = objPaperENS.PaperStatusId, //论文状态Id
VersionCount = objPaperENS.VersionCount, //版本统计
IsPublic = objPaperENS.IsPublic, //是否公开
AskQuestion = objPaperENS.AskQuestion, //问题提出
ResearchStatus = objPaperENS.ResearchStatus, //目前研究的现状
InnovationPoints = objPaperENS.InnovationPoints, //创新点
ResearchDesign = objPaperENS.ResearchDesign, //研究设计
DimensionDataProcess = objPaperENS.DimensionDataProcess, //数据处理的维度
ExpectedConclusion = objPaperENS.ExpectedConclusion, //预期结论
ShareId = objPaperENS.ShareId, //分享Id
PaperQCount = objPaperENS.PaperQCount, //论文答疑数
SubVCount = objPaperENS.SubVCount, //论文子观点数
TagsCount = objPaperENS.TagsCount, //论文标注数
TeaQCount = objPaperENS.TeaQCount, //教师提问数
IdStudyLevel = objPaperENS.IdStudyLevel, //学段流水号
IdGrade = objPaperENS.IdGrade, //年级流水号
CreateDate = objPaperENS.CreateDate, //建立日期
UpdUser = objPaperENS.UpdUser, //修改人
UpdDate = objPaperENS.UpdDate, //修改日期
Memo = objPaperENS.Memo, //备注
};
 return objPaperENT;
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
public static void CheckPropertyNew(this clsPaperEN objPaperEN)
{
 clsPaperBL.PaperDA.CheckPropertyNew(objPaperEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPaperEN objPaperEN)
{
 clsPaperBL.PaperDA.CheckProperty4Condition(objPaperEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPaperEN objPaperCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPaperCond.IsUpdated(conPaper.PaperId) == true)
{
string strComparisonOpPaperId = objPaperCond.dicFldComparisonOp[conPaper.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.PaperId, objPaperCond.PaperId, strComparisonOpPaperId);
}
if (objPaperCond.IsUpdated(conPaper.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objPaperCond.dicFldComparisonOp[conPaper.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.PaperTitle, objPaperCond.PaperTitle, strComparisonOpPaperTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objPaperCond.IsUpdated(conPaper.Periodical) == true)
{
string strComparisonOpPeriodical = objPaperCond.dicFldComparisonOp[conPaper.Periodical];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.Periodical, objPaperCond.Periodical, strComparisonOpPeriodical);
}
if (objPaperCond.IsUpdated(conPaper.Author) == true)
{
string strComparisonOpAuthor = objPaperCond.dicFldComparisonOp[conPaper.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.Author, objPaperCond.Author, strComparisonOpAuthor);
}
if (objPaperCond.IsUpdated(conPaper.ResearchQuestion) == true)
{
string strComparisonOpResearchQuestion = objPaperCond.dicFldComparisonOp[conPaper.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.ResearchQuestion, objPaperCond.ResearchQuestion, strComparisonOpResearchQuestion);
}
if (objPaperCond.IsUpdated(conPaper.Keyword) == true)
{
string strComparisonOpKeyword = objPaperCond.dicFldComparisonOp[conPaper.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.Keyword, objPaperCond.Keyword, strComparisonOpKeyword);
}
if (objPaperCond.IsUpdated(conPaper.LiteratureSources) == true)
{
string strComparisonOpLiteratureSources = objPaperCond.dicFldComparisonOp[conPaper.LiteratureSources];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.LiteratureSources, objPaperCond.LiteratureSources, strComparisonOpLiteratureSources);
}
if (objPaperCond.IsUpdated(conPaper.LiteratureLink) == true)
{
string strComparisonOpLiteratureLink = objPaperCond.dicFldComparisonOp[conPaper.LiteratureLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.LiteratureLink, objPaperCond.LiteratureLink, strComparisonOpLiteratureLink);
}
if (objPaperCond.IsUpdated(conPaper.UploadfileUrl) == true)
{
string strComparisonOpUploadfileUrl = objPaperCond.dicFldComparisonOp[conPaper.UploadfileUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.UploadfileUrl, objPaperCond.UploadfileUrl, strComparisonOpUploadfileUrl);
}
if (objPaperCond.IsUpdated(conPaper.IsQuotethesis) == true)
{
if (objPaperCond.IsQuotethesis == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPaper.IsQuotethesis);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPaper.IsQuotethesis);
}
}
if (objPaperCond.IsUpdated(conPaper.QuoteId) == true)
{
string strComparisonOpQuoteId = objPaperCond.dicFldComparisonOp[conPaper.QuoteId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.QuoteId, objPaperCond.QuoteId, strComparisonOpQuoteId);
}
if (objPaperCond.IsUpdated(conPaper.IsChecked) == true)
{
if (objPaperCond.IsChecked == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPaper.IsChecked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPaper.IsChecked);
}
}
if (objPaperCond.IsUpdated(conPaper.Checker) == true)
{
string strComparisonOpChecker = objPaperCond.dicFldComparisonOp[conPaper.Checker];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.Checker, objPaperCond.Checker, strComparisonOpChecker);
}
if (objPaperCond.IsUpdated(conPaper.LiteratureTypeId) == true)
{
string strComparisonOpLiteratureTypeId = objPaperCond.dicFldComparisonOp[conPaper.LiteratureTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.LiteratureTypeId, objPaperCond.LiteratureTypeId, strComparisonOpLiteratureTypeId);
}
if (objPaperCond.IsUpdated(conPaper.BrowseNumber) == true)
{
string strComparisonOpBrowseNumber = objPaperCond.dicFldComparisonOp[conPaper.BrowseNumber];
strWhereCond += string.Format(" And {0} {2} {1}", conPaper.BrowseNumber, objPaperCond.BrowseNumber, strComparisonOpBrowseNumber);
}
if (objPaperCond.IsUpdated(conPaper.IsSubmit) == true)
{
if (objPaperCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPaper.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPaper.IsSubmit);
}
}
if (objPaperCond.IsUpdated(conPaper.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objPaperCond.dicFldComparisonOp[conPaper.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPaper.AppraiseCount, objPaperCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objPaperCond.IsUpdated(conPaper.AttachmentCount) == true)
{
string strComparisonOpAttachmentCount = objPaperCond.dicFldComparisonOp[conPaper.AttachmentCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPaper.AttachmentCount, objPaperCond.AttachmentCount, strComparisonOpAttachmentCount);
}
if (objPaperCond.IsUpdated(conPaper.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objPaperCond.dicFldComparisonOp[conPaper.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPaper.CollectionCount, objPaperCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objPaperCond.IsUpdated(conPaper.DownloadCount) == true)
{
string strComparisonOpDownloadCount = objPaperCond.dicFldComparisonOp[conPaper.DownloadCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPaper.DownloadCount, objPaperCond.DownloadCount, strComparisonOpDownloadCount);
}
if (objPaperCond.IsUpdated(conPaper.OkCount) == true)
{
string strComparisonOpOkCount = objPaperCond.dicFldComparisonOp[conPaper.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPaper.OkCount, objPaperCond.OkCount, strComparisonOpOkCount);
}
if (objPaperCond.IsUpdated(conPaper.Pcount) == true)
{
string strComparisonOpPcount = objPaperCond.dicFldComparisonOp[conPaper.Pcount];
strWhereCond += string.Format(" And {0} {2} {1}", conPaper.Pcount, objPaperCond.Pcount, strComparisonOpPcount);
}
if (objPaperCond.IsUpdated(conPaper.Score) == true)
{
string strComparisonOpScore = objPaperCond.dicFldComparisonOp[conPaper.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conPaper.Score, objPaperCond.Score, strComparisonOpScore);
}
if (objPaperCond.IsUpdated(conPaper.StuScore) == true)
{
string strComparisonOpStuScore = objPaperCond.dicFldComparisonOp[conPaper.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conPaper.StuScore, objPaperCond.StuScore, strComparisonOpStuScore);
}
if (objPaperCond.IsUpdated(conPaper.TeaScore) == true)
{
string strComparisonOpTeaScore = objPaperCond.dicFldComparisonOp[conPaper.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conPaper.TeaScore, objPaperCond.TeaScore, strComparisonOpTeaScore);
}
if (objPaperCond.IsUpdated(conPaper.PaperTypeId) == true)
{
string strComparisonOpPaperTypeId = objPaperCond.dicFldComparisonOp[conPaper.PaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.PaperTypeId, objPaperCond.PaperTypeId, strComparisonOpPaperTypeId);
}
if (objPaperCond.IsUpdated(conPaper.PaperStatusId) == true)
{
string strComparisonOpPaperStatusId = objPaperCond.dicFldComparisonOp[conPaper.PaperStatusId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.PaperStatusId, objPaperCond.PaperStatusId, strComparisonOpPaperStatusId);
}
if (objPaperCond.IsUpdated(conPaper.VersionCount) == true)
{
string strComparisonOpVersionCount = objPaperCond.dicFldComparisonOp[conPaper.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPaper.VersionCount, objPaperCond.VersionCount, strComparisonOpVersionCount);
}
if (objPaperCond.IsUpdated(conPaper.IsPublic) == true)
{
if (objPaperCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPaper.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPaper.IsPublic);
}
}
if (objPaperCond.IsUpdated(conPaper.AskQuestion) == true)
{
string strComparisonOpAskQuestion = objPaperCond.dicFldComparisonOp[conPaper.AskQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.AskQuestion, objPaperCond.AskQuestion, strComparisonOpAskQuestion);
}
if (objPaperCond.IsUpdated(conPaper.ResearchStatus) == true)
{
string strComparisonOpResearchStatus = objPaperCond.dicFldComparisonOp[conPaper.ResearchStatus];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.ResearchStatus, objPaperCond.ResearchStatus, strComparisonOpResearchStatus);
}
if (objPaperCond.IsUpdated(conPaper.InnovationPoints) == true)
{
string strComparisonOpInnovationPoints = objPaperCond.dicFldComparisonOp[conPaper.InnovationPoints];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.InnovationPoints, objPaperCond.InnovationPoints, strComparisonOpInnovationPoints);
}
if (objPaperCond.IsUpdated(conPaper.ResearchDesign) == true)
{
string strComparisonOpResearchDesign = objPaperCond.dicFldComparisonOp[conPaper.ResearchDesign];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.ResearchDesign, objPaperCond.ResearchDesign, strComparisonOpResearchDesign);
}
if (objPaperCond.IsUpdated(conPaper.DimensionDataProcess) == true)
{
string strComparisonOpDimensionDataProcess = objPaperCond.dicFldComparisonOp[conPaper.DimensionDataProcess];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.DimensionDataProcess, objPaperCond.DimensionDataProcess, strComparisonOpDimensionDataProcess);
}
if (objPaperCond.IsUpdated(conPaper.ExpectedConclusion) == true)
{
string strComparisonOpExpectedConclusion = objPaperCond.dicFldComparisonOp[conPaper.ExpectedConclusion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.ExpectedConclusion, objPaperCond.ExpectedConclusion, strComparisonOpExpectedConclusion);
}
if (objPaperCond.IsUpdated(conPaper.ShareId) == true)
{
string strComparisonOpShareId = objPaperCond.dicFldComparisonOp[conPaper.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.ShareId, objPaperCond.ShareId, strComparisonOpShareId);
}
if (objPaperCond.IsUpdated(conPaper.PaperQCount) == true)
{
string strComparisonOpPaperQCount = objPaperCond.dicFldComparisonOp[conPaper.PaperQCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPaper.PaperQCount, objPaperCond.PaperQCount, strComparisonOpPaperQCount);
}
if (objPaperCond.IsUpdated(conPaper.SubVCount) == true)
{
string strComparisonOpSubVCount = objPaperCond.dicFldComparisonOp[conPaper.SubVCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPaper.SubVCount, objPaperCond.SubVCount, strComparisonOpSubVCount);
}
if (objPaperCond.IsUpdated(conPaper.TagsCount) == true)
{
string strComparisonOpTagsCount = objPaperCond.dicFldComparisonOp[conPaper.TagsCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPaper.TagsCount, objPaperCond.TagsCount, strComparisonOpTagsCount);
}
if (objPaperCond.IsUpdated(conPaper.TeaQCount) == true)
{
string strComparisonOpTeaQCount = objPaperCond.dicFldComparisonOp[conPaper.TeaQCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPaper.TeaQCount, objPaperCond.TeaQCount, strComparisonOpTeaQCount);
}
if (objPaperCond.IsUpdated(conPaper.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objPaperCond.dicFldComparisonOp[conPaper.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.IdStudyLevel, objPaperCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objPaperCond.IsUpdated(conPaper.IdGrade) == true)
{
string strComparisonOpIdGrade = objPaperCond.dicFldComparisonOp[conPaper.IdGrade];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.IdGrade, objPaperCond.IdGrade, strComparisonOpIdGrade);
}
if (objPaperCond.IsUpdated(conPaper.CreateDate) == true)
{
string strComparisonOpCreateDate = objPaperCond.dicFldComparisonOp[conPaper.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.CreateDate, objPaperCond.CreateDate, strComparisonOpCreateDate);
}
if (objPaperCond.IsUpdated(conPaper.UpdUser) == true)
{
string strComparisonOpUpdUser = objPaperCond.dicFldComparisonOp[conPaper.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.UpdUser, objPaperCond.UpdUser, strComparisonOpUpdUser);
}
if (objPaperCond.IsUpdated(conPaper.UpdDate) == true)
{
string strComparisonOpUpdDate = objPaperCond.dicFldComparisonOp[conPaper.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.UpdDate, objPaperCond.UpdDate, strComparisonOpUpdDate);
}
if (objPaperCond.IsUpdated(conPaper.Memo) == true)
{
string strComparisonOpMemo = objPaperCond.dicFldComparisonOp[conPaper.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaper.Memo, objPaperCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--Paper(论文表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PaperTitle_Author
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objPaperEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsPaperEN objPaperEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objPaperEN == null) return true;
if (objPaperEN.PaperId == null || objPaperEN.PaperId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PaperTitle = '{0}'", objPaperEN.PaperTitle);
 if (objPaperEN.Author == null)
{
 sbCondition.AppendFormat(" and Author is null", objPaperEN.Author);
}
else
{
 sbCondition.AppendFormat(" and Author = '{0}'", objPaperEN.Author);
}
if (clsPaperBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PaperId !=  '{0}'", objPaperEN.PaperId);
 sbCondition.AppendFormat(" and PaperTitle = '{0}'", objPaperEN.PaperTitle);
 sbCondition.AppendFormat(" and Author = '{0}'", objPaperEN.Author);
if (clsPaperBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--Paper(论文表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PaperTitle_Author
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPaperEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsPaperEN objPaperEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPaperEN == null) return "";
if (objPaperEN.PaperId == null || objPaperEN.PaperId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PaperTitle = '{0}'", objPaperEN.PaperTitle);
 if (objPaperEN.Author == null)
{
 sbCondition.AppendFormat(" and Author is null", objPaperEN.Author);
}
else
{
 sbCondition.AppendFormat(" and Author = '{0}'", objPaperEN.Author);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PaperId !=  '{0}'", objPaperEN.PaperId);
 sbCondition.AppendFormat(" and PaperTitle = '{0}'", objPaperEN.PaperTitle);
 sbCondition.AppendFormat(" and Author = '{0}'", objPaperEN.Author);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_Paper
{
public virtual bool UpdRelaTabDate(string strPaperId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文表(Paper)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPaperBL
{
public static RelatedActions_Paper relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPaperDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPaperDA PaperDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPaperDA();
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
 public clsPaperBL()
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
if (string.IsNullOrEmpty(clsPaperEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPaperEN._ConnectString);
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
public static DataTable GetDataTable_Paper(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PaperDA.GetDataTable_Paper(strWhereCond);
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
objDT = PaperDA.GetDataTable(strWhereCond);
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
objDT = PaperDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PaperDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PaperDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PaperDA.GetDataTable_Top(objTopPara);
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
objDT = PaperDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PaperDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PaperDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsPaperEN> GetObjLstByPaperIdLst(List<string> arrPaperIdLst)
{
List<clsPaperEN> arrObjLst = new List<clsPaperEN>(); 
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
	clsPaperEN objPaperEN = new clsPaperEN();
try
{
objPaperEN.PaperId = objRow[conPaper.PaperId].ToString().Trim(); //论文Id
objPaperEN.PaperTitle = objRow[conPaper.PaperTitle].ToString().Trim(); //论文标题
objPaperEN.PaperContent = objRow[conPaper.PaperContent] == DBNull.Value ? null : objRow[conPaper.PaperContent].ToString().Trim(); //主题内容
objPaperEN.Periodical = objRow[conPaper.Periodical] == DBNull.Value ? null : objRow[conPaper.Periodical].ToString().Trim(); //期刊
objPaperEN.Author = objRow[conPaper.Author] == DBNull.Value ? null : objRow[conPaper.Author].ToString().Trim(); //作者
objPaperEN.ResearchQuestion = objRow[conPaper.ResearchQuestion] == DBNull.Value ? null : objRow[conPaper.ResearchQuestion].ToString().Trim(); //研究问题
objPaperEN.Keyword = objRow[conPaper.Keyword] == DBNull.Value ? null : objRow[conPaper.Keyword].ToString().Trim(); //关键字
objPaperEN.LiteratureSources = objRow[conPaper.LiteratureSources] == DBNull.Value ? null : objRow[conPaper.LiteratureSources].ToString().Trim(); //文献来源
objPaperEN.LiteratureLink = objRow[conPaper.LiteratureLink] == DBNull.Value ? null : objRow[conPaper.LiteratureLink].ToString().Trim(); //文献链接
objPaperEN.UploadfileUrl = objRow[conPaper.UploadfileUrl] == DBNull.Value ? null : objRow[conPaper.UploadfileUrl].ToString().Trim(); //文件地址
objPaperEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objPaperEN.QuoteId = objRow[conPaper.QuoteId] == DBNull.Value ? null : objRow[conPaper.QuoteId].ToString().Trim(); //引用Id
objPaperEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsChecked].ToString().Trim()); //是否检查
objPaperEN.Checker = objRow[conPaper.Checker] == DBNull.Value ? null : objRow[conPaper.Checker].ToString().Trim(); //审核人
objPaperEN.LiteratureTypeId = objRow[conPaper.LiteratureTypeId].ToString().Trim(); //文献类型Id
objPaperEN.BrowseNumber = objRow[conPaper.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.BrowseNumber].ToString().Trim()); //浏览量
objPaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsSubmit].ToString().Trim()); //是否提交
objPaperEN.AppraiseCount = objRow[conPaper.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.AppraiseCount].ToString().Trim()); //评论数
objPaperEN.AttachmentCount = objRow[conPaper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.AttachmentCount].ToString().Trim()); //附件计数
objPaperEN.CollectionCount = objRow[conPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.CollectionCount].ToString().Trim()); //收藏数量
objPaperEN.DownloadCount = objRow[conPaper.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.DownloadCount].ToString().Trim()); //下载数
objPaperEN.OkCount = objRow[conPaper.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.OkCount].ToString().Trim()); //点赞统计
objPaperEN.Pcount = objRow[conPaper.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.Pcount].ToString().Trim()); //读写数
objPaperEN.Score = objRow[conPaper.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.Score].ToString().Trim()); //评分
objPaperEN.StuScore = objRow[conPaper.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.StuScore].ToString().Trim()); //学生平均分
objPaperEN.TeaScore = objRow[conPaper.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.TeaScore].ToString().Trim()); //教师评分
objPaperEN.PaperTypeId = objRow[conPaper.PaperTypeId] == DBNull.Value ? null : objRow[conPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objPaperEN.PaperStatusId = objRow[conPaper.PaperStatusId] == DBNull.Value ? null : objRow[conPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objPaperEN.VersionCount = objRow[conPaper.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.VersionCount].ToString().Trim()); //版本统计
objPaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsPublic].ToString().Trim()); //是否公开
objPaperEN.AskQuestion = objRow[conPaper.AskQuestion] == DBNull.Value ? null : objRow[conPaper.AskQuestion].ToString().Trim(); //问题提出
objPaperEN.ResearchStatus = objRow[conPaper.ResearchStatus] == DBNull.Value ? null : objRow[conPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objPaperEN.InnovationPoints = objRow[conPaper.InnovationPoints] == DBNull.Value ? null : objRow[conPaper.InnovationPoints].ToString().Trim(); //创新点
objPaperEN.ResearchDesign = objRow[conPaper.ResearchDesign] == DBNull.Value ? null : objRow[conPaper.ResearchDesign].ToString().Trim(); //研究设计
objPaperEN.DimensionDataProcess = objRow[conPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[conPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objPaperEN.ExpectedConclusion = objRow[conPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[conPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objPaperEN.ShareId = objRow[conPaper.ShareId] == DBNull.Value ? null : objRow[conPaper.ShareId].ToString().Trim(); //分享Id
objPaperEN.PaperQCount = objRow[conPaper.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.PaperQCount].ToString().Trim()); //论文答疑数
objPaperEN.SubVCount = objRow[conPaper.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.SubVCount].ToString().Trim()); //论文子观点数
objPaperEN.TagsCount = objRow[conPaper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.TagsCount].ToString().Trim()); //论文标注数
objPaperEN.TeaQCount = objRow[conPaper.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.TeaQCount].ToString().Trim()); //教师提问数
objPaperEN.IdStudyLevel = objRow[conPaper.IdStudyLevel] == DBNull.Value ? null : objRow[conPaper.IdStudyLevel].ToString().Trim(); //学段流水号
objPaperEN.IdGrade = objRow[conPaper.IdGrade] == DBNull.Value ? null : objRow[conPaper.IdGrade].ToString().Trim(); //年级流水号
objPaperEN.CreateDate = objRow[conPaper.CreateDate] == DBNull.Value ? null : objRow[conPaper.CreateDate].ToString().Trim(); //建立日期
objPaperEN.UpdUser = objRow[conPaper.UpdUser] == DBNull.Value ? null : objRow[conPaper.UpdUser].ToString().Trim(); //修改人
objPaperEN.UpdDate = objRow[conPaper.UpdDate] == DBNull.Value ? null : objRow[conPaper.UpdDate].ToString().Trim(); //修改日期
objPaperEN.Memo = objRow[conPaper.Memo] == DBNull.Value ? null : objRow[conPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPaperEN> GetObjLstByPaperIdLstCache(List<string> arrPaperIdLst)
{
string strKey = string.Format("{0}", clsPaperEN._CurrTabName);
List<clsPaperEN> arrPaperObjLstCache = GetObjLstCache();
IEnumerable <clsPaperEN> arrPaperObjLst_Sel =
arrPaperObjLstCache
.Where(x => arrPaperIdLst.Contains(x.PaperId));
return arrPaperObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperEN> GetObjLst(string strWhereCond)
{
List<clsPaperEN> arrObjLst = new List<clsPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperEN objPaperEN = new clsPaperEN();
try
{
objPaperEN.PaperId = objRow[conPaper.PaperId].ToString().Trim(); //论文Id
objPaperEN.PaperTitle = objRow[conPaper.PaperTitle].ToString().Trim(); //论文标题
objPaperEN.PaperContent = objRow[conPaper.PaperContent] == DBNull.Value ? null : objRow[conPaper.PaperContent].ToString().Trim(); //主题内容
objPaperEN.Periodical = objRow[conPaper.Periodical] == DBNull.Value ? null : objRow[conPaper.Periodical].ToString().Trim(); //期刊
objPaperEN.Author = objRow[conPaper.Author] == DBNull.Value ? null : objRow[conPaper.Author].ToString().Trim(); //作者
objPaperEN.ResearchQuestion = objRow[conPaper.ResearchQuestion] == DBNull.Value ? null : objRow[conPaper.ResearchQuestion].ToString().Trim(); //研究问题
objPaperEN.Keyword = objRow[conPaper.Keyword] == DBNull.Value ? null : objRow[conPaper.Keyword].ToString().Trim(); //关键字
objPaperEN.LiteratureSources = objRow[conPaper.LiteratureSources] == DBNull.Value ? null : objRow[conPaper.LiteratureSources].ToString().Trim(); //文献来源
objPaperEN.LiteratureLink = objRow[conPaper.LiteratureLink] == DBNull.Value ? null : objRow[conPaper.LiteratureLink].ToString().Trim(); //文献链接
objPaperEN.UploadfileUrl = objRow[conPaper.UploadfileUrl] == DBNull.Value ? null : objRow[conPaper.UploadfileUrl].ToString().Trim(); //文件地址
objPaperEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objPaperEN.QuoteId = objRow[conPaper.QuoteId] == DBNull.Value ? null : objRow[conPaper.QuoteId].ToString().Trim(); //引用Id
objPaperEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsChecked].ToString().Trim()); //是否检查
objPaperEN.Checker = objRow[conPaper.Checker] == DBNull.Value ? null : objRow[conPaper.Checker].ToString().Trim(); //审核人
objPaperEN.LiteratureTypeId = objRow[conPaper.LiteratureTypeId].ToString().Trim(); //文献类型Id
objPaperEN.BrowseNumber = objRow[conPaper.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.BrowseNumber].ToString().Trim()); //浏览量
objPaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsSubmit].ToString().Trim()); //是否提交
objPaperEN.AppraiseCount = objRow[conPaper.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.AppraiseCount].ToString().Trim()); //评论数
objPaperEN.AttachmentCount = objRow[conPaper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.AttachmentCount].ToString().Trim()); //附件计数
objPaperEN.CollectionCount = objRow[conPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.CollectionCount].ToString().Trim()); //收藏数量
objPaperEN.DownloadCount = objRow[conPaper.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.DownloadCount].ToString().Trim()); //下载数
objPaperEN.OkCount = objRow[conPaper.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.OkCount].ToString().Trim()); //点赞统计
objPaperEN.Pcount = objRow[conPaper.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.Pcount].ToString().Trim()); //读写数
objPaperEN.Score = objRow[conPaper.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.Score].ToString().Trim()); //评分
objPaperEN.StuScore = objRow[conPaper.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.StuScore].ToString().Trim()); //学生平均分
objPaperEN.TeaScore = objRow[conPaper.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.TeaScore].ToString().Trim()); //教师评分
objPaperEN.PaperTypeId = objRow[conPaper.PaperTypeId] == DBNull.Value ? null : objRow[conPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objPaperEN.PaperStatusId = objRow[conPaper.PaperStatusId] == DBNull.Value ? null : objRow[conPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objPaperEN.VersionCount = objRow[conPaper.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.VersionCount].ToString().Trim()); //版本统计
objPaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsPublic].ToString().Trim()); //是否公开
objPaperEN.AskQuestion = objRow[conPaper.AskQuestion] == DBNull.Value ? null : objRow[conPaper.AskQuestion].ToString().Trim(); //问题提出
objPaperEN.ResearchStatus = objRow[conPaper.ResearchStatus] == DBNull.Value ? null : objRow[conPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objPaperEN.InnovationPoints = objRow[conPaper.InnovationPoints] == DBNull.Value ? null : objRow[conPaper.InnovationPoints].ToString().Trim(); //创新点
objPaperEN.ResearchDesign = objRow[conPaper.ResearchDesign] == DBNull.Value ? null : objRow[conPaper.ResearchDesign].ToString().Trim(); //研究设计
objPaperEN.DimensionDataProcess = objRow[conPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[conPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objPaperEN.ExpectedConclusion = objRow[conPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[conPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objPaperEN.ShareId = objRow[conPaper.ShareId] == DBNull.Value ? null : objRow[conPaper.ShareId].ToString().Trim(); //分享Id
objPaperEN.PaperQCount = objRow[conPaper.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.PaperQCount].ToString().Trim()); //论文答疑数
objPaperEN.SubVCount = objRow[conPaper.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.SubVCount].ToString().Trim()); //论文子观点数
objPaperEN.TagsCount = objRow[conPaper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.TagsCount].ToString().Trim()); //论文标注数
objPaperEN.TeaQCount = objRow[conPaper.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.TeaQCount].ToString().Trim()); //教师提问数
objPaperEN.IdStudyLevel = objRow[conPaper.IdStudyLevel] == DBNull.Value ? null : objRow[conPaper.IdStudyLevel].ToString().Trim(); //学段流水号
objPaperEN.IdGrade = objRow[conPaper.IdGrade] == DBNull.Value ? null : objRow[conPaper.IdGrade].ToString().Trim(); //年级流水号
objPaperEN.CreateDate = objRow[conPaper.CreateDate] == DBNull.Value ? null : objRow[conPaper.CreateDate].ToString().Trim(); //建立日期
objPaperEN.UpdUser = objRow[conPaper.UpdUser] == DBNull.Value ? null : objRow[conPaper.UpdUser].ToString().Trim(); //修改人
objPaperEN.UpdDate = objRow[conPaper.UpdDate] == DBNull.Value ? null : objRow[conPaper.UpdDate].ToString().Trim(); //修改日期
objPaperEN.Memo = objRow[conPaper.Memo] == DBNull.Value ? null : objRow[conPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperEN);
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
public static List<clsPaperEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPaperEN> arrObjLst = new List<clsPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperEN objPaperEN = new clsPaperEN();
try
{
objPaperEN.PaperId = objRow[conPaper.PaperId].ToString().Trim(); //论文Id
objPaperEN.PaperTitle = objRow[conPaper.PaperTitle].ToString().Trim(); //论文标题
objPaperEN.PaperContent = objRow[conPaper.PaperContent] == DBNull.Value ? null : objRow[conPaper.PaperContent].ToString().Trim(); //主题内容
objPaperEN.Periodical = objRow[conPaper.Periodical] == DBNull.Value ? null : objRow[conPaper.Periodical].ToString().Trim(); //期刊
objPaperEN.Author = objRow[conPaper.Author] == DBNull.Value ? null : objRow[conPaper.Author].ToString().Trim(); //作者
objPaperEN.ResearchQuestion = objRow[conPaper.ResearchQuestion] == DBNull.Value ? null : objRow[conPaper.ResearchQuestion].ToString().Trim(); //研究问题
objPaperEN.Keyword = objRow[conPaper.Keyword] == DBNull.Value ? null : objRow[conPaper.Keyword].ToString().Trim(); //关键字
objPaperEN.LiteratureSources = objRow[conPaper.LiteratureSources] == DBNull.Value ? null : objRow[conPaper.LiteratureSources].ToString().Trim(); //文献来源
objPaperEN.LiteratureLink = objRow[conPaper.LiteratureLink] == DBNull.Value ? null : objRow[conPaper.LiteratureLink].ToString().Trim(); //文献链接
objPaperEN.UploadfileUrl = objRow[conPaper.UploadfileUrl] == DBNull.Value ? null : objRow[conPaper.UploadfileUrl].ToString().Trim(); //文件地址
objPaperEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objPaperEN.QuoteId = objRow[conPaper.QuoteId] == DBNull.Value ? null : objRow[conPaper.QuoteId].ToString().Trim(); //引用Id
objPaperEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsChecked].ToString().Trim()); //是否检查
objPaperEN.Checker = objRow[conPaper.Checker] == DBNull.Value ? null : objRow[conPaper.Checker].ToString().Trim(); //审核人
objPaperEN.LiteratureTypeId = objRow[conPaper.LiteratureTypeId].ToString().Trim(); //文献类型Id
objPaperEN.BrowseNumber = objRow[conPaper.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.BrowseNumber].ToString().Trim()); //浏览量
objPaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsSubmit].ToString().Trim()); //是否提交
objPaperEN.AppraiseCount = objRow[conPaper.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.AppraiseCount].ToString().Trim()); //评论数
objPaperEN.AttachmentCount = objRow[conPaper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.AttachmentCount].ToString().Trim()); //附件计数
objPaperEN.CollectionCount = objRow[conPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.CollectionCount].ToString().Trim()); //收藏数量
objPaperEN.DownloadCount = objRow[conPaper.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.DownloadCount].ToString().Trim()); //下载数
objPaperEN.OkCount = objRow[conPaper.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.OkCount].ToString().Trim()); //点赞统计
objPaperEN.Pcount = objRow[conPaper.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.Pcount].ToString().Trim()); //读写数
objPaperEN.Score = objRow[conPaper.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.Score].ToString().Trim()); //评分
objPaperEN.StuScore = objRow[conPaper.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.StuScore].ToString().Trim()); //学生平均分
objPaperEN.TeaScore = objRow[conPaper.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.TeaScore].ToString().Trim()); //教师评分
objPaperEN.PaperTypeId = objRow[conPaper.PaperTypeId] == DBNull.Value ? null : objRow[conPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objPaperEN.PaperStatusId = objRow[conPaper.PaperStatusId] == DBNull.Value ? null : objRow[conPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objPaperEN.VersionCount = objRow[conPaper.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.VersionCount].ToString().Trim()); //版本统计
objPaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsPublic].ToString().Trim()); //是否公开
objPaperEN.AskQuestion = objRow[conPaper.AskQuestion] == DBNull.Value ? null : objRow[conPaper.AskQuestion].ToString().Trim(); //问题提出
objPaperEN.ResearchStatus = objRow[conPaper.ResearchStatus] == DBNull.Value ? null : objRow[conPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objPaperEN.InnovationPoints = objRow[conPaper.InnovationPoints] == DBNull.Value ? null : objRow[conPaper.InnovationPoints].ToString().Trim(); //创新点
objPaperEN.ResearchDesign = objRow[conPaper.ResearchDesign] == DBNull.Value ? null : objRow[conPaper.ResearchDesign].ToString().Trim(); //研究设计
objPaperEN.DimensionDataProcess = objRow[conPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[conPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objPaperEN.ExpectedConclusion = objRow[conPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[conPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objPaperEN.ShareId = objRow[conPaper.ShareId] == DBNull.Value ? null : objRow[conPaper.ShareId].ToString().Trim(); //分享Id
objPaperEN.PaperQCount = objRow[conPaper.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.PaperQCount].ToString().Trim()); //论文答疑数
objPaperEN.SubVCount = objRow[conPaper.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.SubVCount].ToString().Trim()); //论文子观点数
objPaperEN.TagsCount = objRow[conPaper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.TagsCount].ToString().Trim()); //论文标注数
objPaperEN.TeaQCount = objRow[conPaper.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.TeaQCount].ToString().Trim()); //教师提问数
objPaperEN.IdStudyLevel = objRow[conPaper.IdStudyLevel] == DBNull.Value ? null : objRow[conPaper.IdStudyLevel].ToString().Trim(); //学段流水号
objPaperEN.IdGrade = objRow[conPaper.IdGrade] == DBNull.Value ? null : objRow[conPaper.IdGrade].ToString().Trim(); //年级流水号
objPaperEN.CreateDate = objRow[conPaper.CreateDate] == DBNull.Value ? null : objRow[conPaper.CreateDate].ToString().Trim(); //建立日期
objPaperEN.UpdUser = objRow[conPaper.UpdUser] == DBNull.Value ? null : objRow[conPaper.UpdUser].ToString().Trim(); //修改人
objPaperEN.UpdDate = objRow[conPaper.UpdDate] == DBNull.Value ? null : objRow[conPaper.UpdDate].ToString().Trim(); //修改日期
objPaperEN.Memo = objRow[conPaper.Memo] == DBNull.Value ? null : objRow[conPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPaperCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPaperEN> GetSubObjLstCache(clsPaperEN objPaperCond)
{
List<clsPaperEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPaperEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPaper.AttributeName)
{
if (objPaperCond.IsUpdated(strFldName) == false) continue;
if (objPaperCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperCond[strFldName].ToString());
}
else
{
if (objPaperCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPaperCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPaperCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPaperCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPaperCond[strFldName]));
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
public static List<clsPaperEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPaperEN> arrObjLst = new List<clsPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperEN objPaperEN = new clsPaperEN();
try
{
objPaperEN.PaperId = objRow[conPaper.PaperId].ToString().Trim(); //论文Id
objPaperEN.PaperTitle = objRow[conPaper.PaperTitle].ToString().Trim(); //论文标题
objPaperEN.PaperContent = objRow[conPaper.PaperContent] == DBNull.Value ? null : objRow[conPaper.PaperContent].ToString().Trim(); //主题内容
objPaperEN.Periodical = objRow[conPaper.Periodical] == DBNull.Value ? null : objRow[conPaper.Periodical].ToString().Trim(); //期刊
objPaperEN.Author = objRow[conPaper.Author] == DBNull.Value ? null : objRow[conPaper.Author].ToString().Trim(); //作者
objPaperEN.ResearchQuestion = objRow[conPaper.ResearchQuestion] == DBNull.Value ? null : objRow[conPaper.ResearchQuestion].ToString().Trim(); //研究问题
objPaperEN.Keyword = objRow[conPaper.Keyword] == DBNull.Value ? null : objRow[conPaper.Keyword].ToString().Trim(); //关键字
objPaperEN.LiteratureSources = objRow[conPaper.LiteratureSources] == DBNull.Value ? null : objRow[conPaper.LiteratureSources].ToString().Trim(); //文献来源
objPaperEN.LiteratureLink = objRow[conPaper.LiteratureLink] == DBNull.Value ? null : objRow[conPaper.LiteratureLink].ToString().Trim(); //文献链接
objPaperEN.UploadfileUrl = objRow[conPaper.UploadfileUrl] == DBNull.Value ? null : objRow[conPaper.UploadfileUrl].ToString().Trim(); //文件地址
objPaperEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objPaperEN.QuoteId = objRow[conPaper.QuoteId] == DBNull.Value ? null : objRow[conPaper.QuoteId].ToString().Trim(); //引用Id
objPaperEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsChecked].ToString().Trim()); //是否检查
objPaperEN.Checker = objRow[conPaper.Checker] == DBNull.Value ? null : objRow[conPaper.Checker].ToString().Trim(); //审核人
objPaperEN.LiteratureTypeId = objRow[conPaper.LiteratureTypeId].ToString().Trim(); //文献类型Id
objPaperEN.BrowseNumber = objRow[conPaper.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.BrowseNumber].ToString().Trim()); //浏览量
objPaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsSubmit].ToString().Trim()); //是否提交
objPaperEN.AppraiseCount = objRow[conPaper.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.AppraiseCount].ToString().Trim()); //评论数
objPaperEN.AttachmentCount = objRow[conPaper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.AttachmentCount].ToString().Trim()); //附件计数
objPaperEN.CollectionCount = objRow[conPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.CollectionCount].ToString().Trim()); //收藏数量
objPaperEN.DownloadCount = objRow[conPaper.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.DownloadCount].ToString().Trim()); //下载数
objPaperEN.OkCount = objRow[conPaper.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.OkCount].ToString().Trim()); //点赞统计
objPaperEN.Pcount = objRow[conPaper.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.Pcount].ToString().Trim()); //读写数
objPaperEN.Score = objRow[conPaper.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.Score].ToString().Trim()); //评分
objPaperEN.StuScore = objRow[conPaper.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.StuScore].ToString().Trim()); //学生平均分
objPaperEN.TeaScore = objRow[conPaper.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.TeaScore].ToString().Trim()); //教师评分
objPaperEN.PaperTypeId = objRow[conPaper.PaperTypeId] == DBNull.Value ? null : objRow[conPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objPaperEN.PaperStatusId = objRow[conPaper.PaperStatusId] == DBNull.Value ? null : objRow[conPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objPaperEN.VersionCount = objRow[conPaper.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.VersionCount].ToString().Trim()); //版本统计
objPaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsPublic].ToString().Trim()); //是否公开
objPaperEN.AskQuestion = objRow[conPaper.AskQuestion] == DBNull.Value ? null : objRow[conPaper.AskQuestion].ToString().Trim(); //问题提出
objPaperEN.ResearchStatus = objRow[conPaper.ResearchStatus] == DBNull.Value ? null : objRow[conPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objPaperEN.InnovationPoints = objRow[conPaper.InnovationPoints] == DBNull.Value ? null : objRow[conPaper.InnovationPoints].ToString().Trim(); //创新点
objPaperEN.ResearchDesign = objRow[conPaper.ResearchDesign] == DBNull.Value ? null : objRow[conPaper.ResearchDesign].ToString().Trim(); //研究设计
objPaperEN.DimensionDataProcess = objRow[conPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[conPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objPaperEN.ExpectedConclusion = objRow[conPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[conPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objPaperEN.ShareId = objRow[conPaper.ShareId] == DBNull.Value ? null : objRow[conPaper.ShareId].ToString().Trim(); //分享Id
objPaperEN.PaperQCount = objRow[conPaper.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.PaperQCount].ToString().Trim()); //论文答疑数
objPaperEN.SubVCount = objRow[conPaper.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.SubVCount].ToString().Trim()); //论文子观点数
objPaperEN.TagsCount = objRow[conPaper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.TagsCount].ToString().Trim()); //论文标注数
objPaperEN.TeaQCount = objRow[conPaper.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.TeaQCount].ToString().Trim()); //教师提问数
objPaperEN.IdStudyLevel = objRow[conPaper.IdStudyLevel] == DBNull.Value ? null : objRow[conPaper.IdStudyLevel].ToString().Trim(); //学段流水号
objPaperEN.IdGrade = objRow[conPaper.IdGrade] == DBNull.Value ? null : objRow[conPaper.IdGrade].ToString().Trim(); //年级流水号
objPaperEN.CreateDate = objRow[conPaper.CreateDate] == DBNull.Value ? null : objRow[conPaper.CreateDate].ToString().Trim(); //建立日期
objPaperEN.UpdUser = objRow[conPaper.UpdUser] == DBNull.Value ? null : objRow[conPaper.UpdUser].ToString().Trim(); //修改人
objPaperEN.UpdDate = objRow[conPaper.UpdDate] == DBNull.Value ? null : objRow[conPaper.UpdDate].ToString().Trim(); //修改日期
objPaperEN.Memo = objRow[conPaper.Memo] == DBNull.Value ? null : objRow[conPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperEN);
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
public static List<clsPaperEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPaperEN> arrObjLst = new List<clsPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperEN objPaperEN = new clsPaperEN();
try
{
objPaperEN.PaperId = objRow[conPaper.PaperId].ToString().Trim(); //论文Id
objPaperEN.PaperTitle = objRow[conPaper.PaperTitle].ToString().Trim(); //论文标题
objPaperEN.PaperContent = objRow[conPaper.PaperContent] == DBNull.Value ? null : objRow[conPaper.PaperContent].ToString().Trim(); //主题内容
objPaperEN.Periodical = objRow[conPaper.Periodical] == DBNull.Value ? null : objRow[conPaper.Periodical].ToString().Trim(); //期刊
objPaperEN.Author = objRow[conPaper.Author] == DBNull.Value ? null : objRow[conPaper.Author].ToString().Trim(); //作者
objPaperEN.ResearchQuestion = objRow[conPaper.ResearchQuestion] == DBNull.Value ? null : objRow[conPaper.ResearchQuestion].ToString().Trim(); //研究问题
objPaperEN.Keyword = objRow[conPaper.Keyword] == DBNull.Value ? null : objRow[conPaper.Keyword].ToString().Trim(); //关键字
objPaperEN.LiteratureSources = objRow[conPaper.LiteratureSources] == DBNull.Value ? null : objRow[conPaper.LiteratureSources].ToString().Trim(); //文献来源
objPaperEN.LiteratureLink = objRow[conPaper.LiteratureLink] == DBNull.Value ? null : objRow[conPaper.LiteratureLink].ToString().Trim(); //文献链接
objPaperEN.UploadfileUrl = objRow[conPaper.UploadfileUrl] == DBNull.Value ? null : objRow[conPaper.UploadfileUrl].ToString().Trim(); //文件地址
objPaperEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objPaperEN.QuoteId = objRow[conPaper.QuoteId] == DBNull.Value ? null : objRow[conPaper.QuoteId].ToString().Trim(); //引用Id
objPaperEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsChecked].ToString().Trim()); //是否检查
objPaperEN.Checker = objRow[conPaper.Checker] == DBNull.Value ? null : objRow[conPaper.Checker].ToString().Trim(); //审核人
objPaperEN.LiteratureTypeId = objRow[conPaper.LiteratureTypeId].ToString().Trim(); //文献类型Id
objPaperEN.BrowseNumber = objRow[conPaper.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.BrowseNumber].ToString().Trim()); //浏览量
objPaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsSubmit].ToString().Trim()); //是否提交
objPaperEN.AppraiseCount = objRow[conPaper.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.AppraiseCount].ToString().Trim()); //评论数
objPaperEN.AttachmentCount = objRow[conPaper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.AttachmentCount].ToString().Trim()); //附件计数
objPaperEN.CollectionCount = objRow[conPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.CollectionCount].ToString().Trim()); //收藏数量
objPaperEN.DownloadCount = objRow[conPaper.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.DownloadCount].ToString().Trim()); //下载数
objPaperEN.OkCount = objRow[conPaper.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.OkCount].ToString().Trim()); //点赞统计
objPaperEN.Pcount = objRow[conPaper.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.Pcount].ToString().Trim()); //读写数
objPaperEN.Score = objRow[conPaper.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.Score].ToString().Trim()); //评分
objPaperEN.StuScore = objRow[conPaper.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.StuScore].ToString().Trim()); //学生平均分
objPaperEN.TeaScore = objRow[conPaper.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.TeaScore].ToString().Trim()); //教师评分
objPaperEN.PaperTypeId = objRow[conPaper.PaperTypeId] == DBNull.Value ? null : objRow[conPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objPaperEN.PaperStatusId = objRow[conPaper.PaperStatusId] == DBNull.Value ? null : objRow[conPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objPaperEN.VersionCount = objRow[conPaper.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.VersionCount].ToString().Trim()); //版本统计
objPaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsPublic].ToString().Trim()); //是否公开
objPaperEN.AskQuestion = objRow[conPaper.AskQuestion] == DBNull.Value ? null : objRow[conPaper.AskQuestion].ToString().Trim(); //问题提出
objPaperEN.ResearchStatus = objRow[conPaper.ResearchStatus] == DBNull.Value ? null : objRow[conPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objPaperEN.InnovationPoints = objRow[conPaper.InnovationPoints] == DBNull.Value ? null : objRow[conPaper.InnovationPoints].ToString().Trim(); //创新点
objPaperEN.ResearchDesign = objRow[conPaper.ResearchDesign] == DBNull.Value ? null : objRow[conPaper.ResearchDesign].ToString().Trim(); //研究设计
objPaperEN.DimensionDataProcess = objRow[conPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[conPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objPaperEN.ExpectedConclusion = objRow[conPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[conPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objPaperEN.ShareId = objRow[conPaper.ShareId] == DBNull.Value ? null : objRow[conPaper.ShareId].ToString().Trim(); //分享Id
objPaperEN.PaperQCount = objRow[conPaper.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.PaperQCount].ToString().Trim()); //论文答疑数
objPaperEN.SubVCount = objRow[conPaper.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.SubVCount].ToString().Trim()); //论文子观点数
objPaperEN.TagsCount = objRow[conPaper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.TagsCount].ToString().Trim()); //论文标注数
objPaperEN.TeaQCount = objRow[conPaper.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.TeaQCount].ToString().Trim()); //教师提问数
objPaperEN.IdStudyLevel = objRow[conPaper.IdStudyLevel] == DBNull.Value ? null : objRow[conPaper.IdStudyLevel].ToString().Trim(); //学段流水号
objPaperEN.IdGrade = objRow[conPaper.IdGrade] == DBNull.Value ? null : objRow[conPaper.IdGrade].ToString().Trim(); //年级流水号
objPaperEN.CreateDate = objRow[conPaper.CreateDate] == DBNull.Value ? null : objRow[conPaper.CreateDate].ToString().Trim(); //建立日期
objPaperEN.UpdUser = objRow[conPaper.UpdUser] == DBNull.Value ? null : objRow[conPaper.UpdUser].ToString().Trim(); //修改人
objPaperEN.UpdDate = objRow[conPaper.UpdDate] == DBNull.Value ? null : objRow[conPaper.UpdDate].ToString().Trim(); //修改日期
objPaperEN.Memo = objRow[conPaper.Memo] == DBNull.Value ? null : objRow[conPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperEN);
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
List<clsPaperEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPaperEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPaperEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPaperEN> arrObjLst = new List<clsPaperEN>(); 
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
	clsPaperEN objPaperEN = new clsPaperEN();
try
{
objPaperEN.PaperId = objRow[conPaper.PaperId].ToString().Trim(); //论文Id
objPaperEN.PaperTitle = objRow[conPaper.PaperTitle].ToString().Trim(); //论文标题
objPaperEN.PaperContent = objRow[conPaper.PaperContent] == DBNull.Value ? null : objRow[conPaper.PaperContent].ToString().Trim(); //主题内容
objPaperEN.Periodical = objRow[conPaper.Periodical] == DBNull.Value ? null : objRow[conPaper.Periodical].ToString().Trim(); //期刊
objPaperEN.Author = objRow[conPaper.Author] == DBNull.Value ? null : objRow[conPaper.Author].ToString().Trim(); //作者
objPaperEN.ResearchQuestion = objRow[conPaper.ResearchQuestion] == DBNull.Value ? null : objRow[conPaper.ResearchQuestion].ToString().Trim(); //研究问题
objPaperEN.Keyword = objRow[conPaper.Keyword] == DBNull.Value ? null : objRow[conPaper.Keyword].ToString().Trim(); //关键字
objPaperEN.LiteratureSources = objRow[conPaper.LiteratureSources] == DBNull.Value ? null : objRow[conPaper.LiteratureSources].ToString().Trim(); //文献来源
objPaperEN.LiteratureLink = objRow[conPaper.LiteratureLink] == DBNull.Value ? null : objRow[conPaper.LiteratureLink].ToString().Trim(); //文献链接
objPaperEN.UploadfileUrl = objRow[conPaper.UploadfileUrl] == DBNull.Value ? null : objRow[conPaper.UploadfileUrl].ToString().Trim(); //文件地址
objPaperEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objPaperEN.QuoteId = objRow[conPaper.QuoteId] == DBNull.Value ? null : objRow[conPaper.QuoteId].ToString().Trim(); //引用Id
objPaperEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsChecked].ToString().Trim()); //是否检查
objPaperEN.Checker = objRow[conPaper.Checker] == DBNull.Value ? null : objRow[conPaper.Checker].ToString().Trim(); //审核人
objPaperEN.LiteratureTypeId = objRow[conPaper.LiteratureTypeId].ToString().Trim(); //文献类型Id
objPaperEN.BrowseNumber = objRow[conPaper.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.BrowseNumber].ToString().Trim()); //浏览量
objPaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsSubmit].ToString().Trim()); //是否提交
objPaperEN.AppraiseCount = objRow[conPaper.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.AppraiseCount].ToString().Trim()); //评论数
objPaperEN.AttachmentCount = objRow[conPaper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.AttachmentCount].ToString().Trim()); //附件计数
objPaperEN.CollectionCount = objRow[conPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.CollectionCount].ToString().Trim()); //收藏数量
objPaperEN.DownloadCount = objRow[conPaper.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.DownloadCount].ToString().Trim()); //下载数
objPaperEN.OkCount = objRow[conPaper.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.OkCount].ToString().Trim()); //点赞统计
objPaperEN.Pcount = objRow[conPaper.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.Pcount].ToString().Trim()); //读写数
objPaperEN.Score = objRow[conPaper.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.Score].ToString().Trim()); //评分
objPaperEN.StuScore = objRow[conPaper.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.StuScore].ToString().Trim()); //学生平均分
objPaperEN.TeaScore = objRow[conPaper.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.TeaScore].ToString().Trim()); //教师评分
objPaperEN.PaperTypeId = objRow[conPaper.PaperTypeId] == DBNull.Value ? null : objRow[conPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objPaperEN.PaperStatusId = objRow[conPaper.PaperStatusId] == DBNull.Value ? null : objRow[conPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objPaperEN.VersionCount = objRow[conPaper.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.VersionCount].ToString().Trim()); //版本统计
objPaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsPublic].ToString().Trim()); //是否公开
objPaperEN.AskQuestion = objRow[conPaper.AskQuestion] == DBNull.Value ? null : objRow[conPaper.AskQuestion].ToString().Trim(); //问题提出
objPaperEN.ResearchStatus = objRow[conPaper.ResearchStatus] == DBNull.Value ? null : objRow[conPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objPaperEN.InnovationPoints = objRow[conPaper.InnovationPoints] == DBNull.Value ? null : objRow[conPaper.InnovationPoints].ToString().Trim(); //创新点
objPaperEN.ResearchDesign = objRow[conPaper.ResearchDesign] == DBNull.Value ? null : objRow[conPaper.ResearchDesign].ToString().Trim(); //研究设计
objPaperEN.DimensionDataProcess = objRow[conPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[conPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objPaperEN.ExpectedConclusion = objRow[conPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[conPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objPaperEN.ShareId = objRow[conPaper.ShareId] == DBNull.Value ? null : objRow[conPaper.ShareId].ToString().Trim(); //分享Id
objPaperEN.PaperQCount = objRow[conPaper.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.PaperQCount].ToString().Trim()); //论文答疑数
objPaperEN.SubVCount = objRow[conPaper.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.SubVCount].ToString().Trim()); //论文子观点数
objPaperEN.TagsCount = objRow[conPaper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.TagsCount].ToString().Trim()); //论文标注数
objPaperEN.TeaQCount = objRow[conPaper.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.TeaQCount].ToString().Trim()); //教师提问数
objPaperEN.IdStudyLevel = objRow[conPaper.IdStudyLevel] == DBNull.Value ? null : objRow[conPaper.IdStudyLevel].ToString().Trim(); //学段流水号
objPaperEN.IdGrade = objRow[conPaper.IdGrade] == DBNull.Value ? null : objRow[conPaper.IdGrade].ToString().Trim(); //年级流水号
objPaperEN.CreateDate = objRow[conPaper.CreateDate] == DBNull.Value ? null : objRow[conPaper.CreateDate].ToString().Trim(); //建立日期
objPaperEN.UpdUser = objRow[conPaper.UpdUser] == DBNull.Value ? null : objRow[conPaper.UpdUser].ToString().Trim(); //修改人
objPaperEN.UpdDate = objRow[conPaper.UpdDate] == DBNull.Value ? null : objRow[conPaper.UpdDate].ToString().Trim(); //修改日期
objPaperEN.Memo = objRow[conPaper.Memo] == DBNull.Value ? null : objRow[conPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperEN);
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
public static List<clsPaperEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPaperEN> arrObjLst = new List<clsPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperEN objPaperEN = new clsPaperEN();
try
{
objPaperEN.PaperId = objRow[conPaper.PaperId].ToString().Trim(); //论文Id
objPaperEN.PaperTitle = objRow[conPaper.PaperTitle].ToString().Trim(); //论文标题
objPaperEN.PaperContent = objRow[conPaper.PaperContent] == DBNull.Value ? null : objRow[conPaper.PaperContent].ToString().Trim(); //主题内容
objPaperEN.Periodical = objRow[conPaper.Periodical] == DBNull.Value ? null : objRow[conPaper.Periodical].ToString().Trim(); //期刊
objPaperEN.Author = objRow[conPaper.Author] == DBNull.Value ? null : objRow[conPaper.Author].ToString().Trim(); //作者
objPaperEN.ResearchQuestion = objRow[conPaper.ResearchQuestion] == DBNull.Value ? null : objRow[conPaper.ResearchQuestion].ToString().Trim(); //研究问题
objPaperEN.Keyword = objRow[conPaper.Keyword] == DBNull.Value ? null : objRow[conPaper.Keyword].ToString().Trim(); //关键字
objPaperEN.LiteratureSources = objRow[conPaper.LiteratureSources] == DBNull.Value ? null : objRow[conPaper.LiteratureSources].ToString().Trim(); //文献来源
objPaperEN.LiteratureLink = objRow[conPaper.LiteratureLink] == DBNull.Value ? null : objRow[conPaper.LiteratureLink].ToString().Trim(); //文献链接
objPaperEN.UploadfileUrl = objRow[conPaper.UploadfileUrl] == DBNull.Value ? null : objRow[conPaper.UploadfileUrl].ToString().Trim(); //文件地址
objPaperEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objPaperEN.QuoteId = objRow[conPaper.QuoteId] == DBNull.Value ? null : objRow[conPaper.QuoteId].ToString().Trim(); //引用Id
objPaperEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsChecked].ToString().Trim()); //是否检查
objPaperEN.Checker = objRow[conPaper.Checker] == DBNull.Value ? null : objRow[conPaper.Checker].ToString().Trim(); //审核人
objPaperEN.LiteratureTypeId = objRow[conPaper.LiteratureTypeId].ToString().Trim(); //文献类型Id
objPaperEN.BrowseNumber = objRow[conPaper.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.BrowseNumber].ToString().Trim()); //浏览量
objPaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsSubmit].ToString().Trim()); //是否提交
objPaperEN.AppraiseCount = objRow[conPaper.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.AppraiseCount].ToString().Trim()); //评论数
objPaperEN.AttachmentCount = objRow[conPaper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.AttachmentCount].ToString().Trim()); //附件计数
objPaperEN.CollectionCount = objRow[conPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.CollectionCount].ToString().Trim()); //收藏数量
objPaperEN.DownloadCount = objRow[conPaper.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.DownloadCount].ToString().Trim()); //下载数
objPaperEN.OkCount = objRow[conPaper.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.OkCount].ToString().Trim()); //点赞统计
objPaperEN.Pcount = objRow[conPaper.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.Pcount].ToString().Trim()); //读写数
objPaperEN.Score = objRow[conPaper.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.Score].ToString().Trim()); //评分
objPaperEN.StuScore = objRow[conPaper.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.StuScore].ToString().Trim()); //学生平均分
objPaperEN.TeaScore = objRow[conPaper.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.TeaScore].ToString().Trim()); //教师评分
objPaperEN.PaperTypeId = objRow[conPaper.PaperTypeId] == DBNull.Value ? null : objRow[conPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objPaperEN.PaperStatusId = objRow[conPaper.PaperStatusId] == DBNull.Value ? null : objRow[conPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objPaperEN.VersionCount = objRow[conPaper.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.VersionCount].ToString().Trim()); //版本统计
objPaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsPublic].ToString().Trim()); //是否公开
objPaperEN.AskQuestion = objRow[conPaper.AskQuestion] == DBNull.Value ? null : objRow[conPaper.AskQuestion].ToString().Trim(); //问题提出
objPaperEN.ResearchStatus = objRow[conPaper.ResearchStatus] == DBNull.Value ? null : objRow[conPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objPaperEN.InnovationPoints = objRow[conPaper.InnovationPoints] == DBNull.Value ? null : objRow[conPaper.InnovationPoints].ToString().Trim(); //创新点
objPaperEN.ResearchDesign = objRow[conPaper.ResearchDesign] == DBNull.Value ? null : objRow[conPaper.ResearchDesign].ToString().Trim(); //研究设计
objPaperEN.DimensionDataProcess = objRow[conPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[conPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objPaperEN.ExpectedConclusion = objRow[conPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[conPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objPaperEN.ShareId = objRow[conPaper.ShareId] == DBNull.Value ? null : objRow[conPaper.ShareId].ToString().Trim(); //分享Id
objPaperEN.PaperQCount = objRow[conPaper.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.PaperQCount].ToString().Trim()); //论文答疑数
objPaperEN.SubVCount = objRow[conPaper.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.SubVCount].ToString().Trim()); //论文子观点数
objPaperEN.TagsCount = objRow[conPaper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.TagsCount].ToString().Trim()); //论文标注数
objPaperEN.TeaQCount = objRow[conPaper.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.TeaQCount].ToString().Trim()); //教师提问数
objPaperEN.IdStudyLevel = objRow[conPaper.IdStudyLevel] == DBNull.Value ? null : objRow[conPaper.IdStudyLevel].ToString().Trim(); //学段流水号
objPaperEN.IdGrade = objRow[conPaper.IdGrade] == DBNull.Value ? null : objRow[conPaper.IdGrade].ToString().Trim(); //年级流水号
objPaperEN.CreateDate = objRow[conPaper.CreateDate] == DBNull.Value ? null : objRow[conPaper.CreateDate].ToString().Trim(); //建立日期
objPaperEN.UpdUser = objRow[conPaper.UpdUser] == DBNull.Value ? null : objRow[conPaper.UpdUser].ToString().Trim(); //修改人
objPaperEN.UpdDate = objRow[conPaper.UpdDate] == DBNull.Value ? null : objRow[conPaper.UpdDate].ToString().Trim(); //修改日期
objPaperEN.Memo = objRow[conPaper.Memo] == DBNull.Value ? null : objRow[conPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPaperEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPaperEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPaperEN> arrObjLst = new List<clsPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperEN objPaperEN = new clsPaperEN();
try
{
objPaperEN.PaperId = objRow[conPaper.PaperId].ToString().Trim(); //论文Id
objPaperEN.PaperTitle = objRow[conPaper.PaperTitle].ToString().Trim(); //论文标题
objPaperEN.PaperContent = objRow[conPaper.PaperContent] == DBNull.Value ? null : objRow[conPaper.PaperContent].ToString().Trim(); //主题内容
objPaperEN.Periodical = objRow[conPaper.Periodical] == DBNull.Value ? null : objRow[conPaper.Periodical].ToString().Trim(); //期刊
objPaperEN.Author = objRow[conPaper.Author] == DBNull.Value ? null : objRow[conPaper.Author].ToString().Trim(); //作者
objPaperEN.ResearchQuestion = objRow[conPaper.ResearchQuestion] == DBNull.Value ? null : objRow[conPaper.ResearchQuestion].ToString().Trim(); //研究问题
objPaperEN.Keyword = objRow[conPaper.Keyword] == DBNull.Value ? null : objRow[conPaper.Keyword].ToString().Trim(); //关键字
objPaperEN.LiteratureSources = objRow[conPaper.LiteratureSources] == DBNull.Value ? null : objRow[conPaper.LiteratureSources].ToString().Trim(); //文献来源
objPaperEN.LiteratureLink = objRow[conPaper.LiteratureLink] == DBNull.Value ? null : objRow[conPaper.LiteratureLink].ToString().Trim(); //文献链接
objPaperEN.UploadfileUrl = objRow[conPaper.UploadfileUrl] == DBNull.Value ? null : objRow[conPaper.UploadfileUrl].ToString().Trim(); //文件地址
objPaperEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objPaperEN.QuoteId = objRow[conPaper.QuoteId] == DBNull.Value ? null : objRow[conPaper.QuoteId].ToString().Trim(); //引用Id
objPaperEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsChecked].ToString().Trim()); //是否检查
objPaperEN.Checker = objRow[conPaper.Checker] == DBNull.Value ? null : objRow[conPaper.Checker].ToString().Trim(); //审核人
objPaperEN.LiteratureTypeId = objRow[conPaper.LiteratureTypeId].ToString().Trim(); //文献类型Id
objPaperEN.BrowseNumber = objRow[conPaper.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.BrowseNumber].ToString().Trim()); //浏览量
objPaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsSubmit].ToString().Trim()); //是否提交
objPaperEN.AppraiseCount = objRow[conPaper.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.AppraiseCount].ToString().Trim()); //评论数
objPaperEN.AttachmentCount = objRow[conPaper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.AttachmentCount].ToString().Trim()); //附件计数
objPaperEN.CollectionCount = objRow[conPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.CollectionCount].ToString().Trim()); //收藏数量
objPaperEN.DownloadCount = objRow[conPaper.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.DownloadCount].ToString().Trim()); //下载数
objPaperEN.OkCount = objRow[conPaper.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.OkCount].ToString().Trim()); //点赞统计
objPaperEN.Pcount = objRow[conPaper.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.Pcount].ToString().Trim()); //读写数
objPaperEN.Score = objRow[conPaper.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.Score].ToString().Trim()); //评分
objPaperEN.StuScore = objRow[conPaper.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.StuScore].ToString().Trim()); //学生平均分
objPaperEN.TeaScore = objRow[conPaper.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.TeaScore].ToString().Trim()); //教师评分
objPaperEN.PaperTypeId = objRow[conPaper.PaperTypeId] == DBNull.Value ? null : objRow[conPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objPaperEN.PaperStatusId = objRow[conPaper.PaperStatusId] == DBNull.Value ? null : objRow[conPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objPaperEN.VersionCount = objRow[conPaper.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.VersionCount].ToString().Trim()); //版本统计
objPaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsPublic].ToString().Trim()); //是否公开
objPaperEN.AskQuestion = objRow[conPaper.AskQuestion] == DBNull.Value ? null : objRow[conPaper.AskQuestion].ToString().Trim(); //问题提出
objPaperEN.ResearchStatus = objRow[conPaper.ResearchStatus] == DBNull.Value ? null : objRow[conPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objPaperEN.InnovationPoints = objRow[conPaper.InnovationPoints] == DBNull.Value ? null : objRow[conPaper.InnovationPoints].ToString().Trim(); //创新点
objPaperEN.ResearchDesign = objRow[conPaper.ResearchDesign] == DBNull.Value ? null : objRow[conPaper.ResearchDesign].ToString().Trim(); //研究设计
objPaperEN.DimensionDataProcess = objRow[conPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[conPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objPaperEN.ExpectedConclusion = objRow[conPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[conPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objPaperEN.ShareId = objRow[conPaper.ShareId] == DBNull.Value ? null : objRow[conPaper.ShareId].ToString().Trim(); //分享Id
objPaperEN.PaperQCount = objRow[conPaper.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.PaperQCount].ToString().Trim()); //论文答疑数
objPaperEN.SubVCount = objRow[conPaper.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.SubVCount].ToString().Trim()); //论文子观点数
objPaperEN.TagsCount = objRow[conPaper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.TagsCount].ToString().Trim()); //论文标注数
objPaperEN.TeaQCount = objRow[conPaper.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.TeaQCount].ToString().Trim()); //教师提问数
objPaperEN.IdStudyLevel = objRow[conPaper.IdStudyLevel] == DBNull.Value ? null : objRow[conPaper.IdStudyLevel].ToString().Trim(); //学段流水号
objPaperEN.IdGrade = objRow[conPaper.IdGrade] == DBNull.Value ? null : objRow[conPaper.IdGrade].ToString().Trim(); //年级流水号
objPaperEN.CreateDate = objRow[conPaper.CreateDate] == DBNull.Value ? null : objRow[conPaper.CreateDate].ToString().Trim(); //建立日期
objPaperEN.UpdUser = objRow[conPaper.UpdUser] == DBNull.Value ? null : objRow[conPaper.UpdUser].ToString().Trim(); //修改人
objPaperEN.UpdDate = objRow[conPaper.UpdDate] == DBNull.Value ? null : objRow[conPaper.UpdDate].ToString().Trim(); //修改日期
objPaperEN.Memo = objRow[conPaper.Memo] == DBNull.Value ? null : objRow[conPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperEN);
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
public static List<clsPaperEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPaperEN> arrObjLst = new List<clsPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperEN objPaperEN = new clsPaperEN();
try
{
objPaperEN.PaperId = objRow[conPaper.PaperId].ToString().Trim(); //论文Id
objPaperEN.PaperTitle = objRow[conPaper.PaperTitle].ToString().Trim(); //论文标题
objPaperEN.PaperContent = objRow[conPaper.PaperContent] == DBNull.Value ? null : objRow[conPaper.PaperContent].ToString().Trim(); //主题内容
objPaperEN.Periodical = objRow[conPaper.Periodical] == DBNull.Value ? null : objRow[conPaper.Periodical].ToString().Trim(); //期刊
objPaperEN.Author = objRow[conPaper.Author] == DBNull.Value ? null : objRow[conPaper.Author].ToString().Trim(); //作者
objPaperEN.ResearchQuestion = objRow[conPaper.ResearchQuestion] == DBNull.Value ? null : objRow[conPaper.ResearchQuestion].ToString().Trim(); //研究问题
objPaperEN.Keyword = objRow[conPaper.Keyword] == DBNull.Value ? null : objRow[conPaper.Keyword].ToString().Trim(); //关键字
objPaperEN.LiteratureSources = objRow[conPaper.LiteratureSources] == DBNull.Value ? null : objRow[conPaper.LiteratureSources].ToString().Trim(); //文献来源
objPaperEN.LiteratureLink = objRow[conPaper.LiteratureLink] == DBNull.Value ? null : objRow[conPaper.LiteratureLink].ToString().Trim(); //文献链接
objPaperEN.UploadfileUrl = objRow[conPaper.UploadfileUrl] == DBNull.Value ? null : objRow[conPaper.UploadfileUrl].ToString().Trim(); //文件地址
objPaperEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objPaperEN.QuoteId = objRow[conPaper.QuoteId] == DBNull.Value ? null : objRow[conPaper.QuoteId].ToString().Trim(); //引用Id
objPaperEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsChecked].ToString().Trim()); //是否检查
objPaperEN.Checker = objRow[conPaper.Checker] == DBNull.Value ? null : objRow[conPaper.Checker].ToString().Trim(); //审核人
objPaperEN.LiteratureTypeId = objRow[conPaper.LiteratureTypeId].ToString().Trim(); //文献类型Id
objPaperEN.BrowseNumber = objRow[conPaper.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.BrowseNumber].ToString().Trim()); //浏览量
objPaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsSubmit].ToString().Trim()); //是否提交
objPaperEN.AppraiseCount = objRow[conPaper.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.AppraiseCount].ToString().Trim()); //评论数
objPaperEN.AttachmentCount = objRow[conPaper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.AttachmentCount].ToString().Trim()); //附件计数
objPaperEN.CollectionCount = objRow[conPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.CollectionCount].ToString().Trim()); //收藏数量
objPaperEN.DownloadCount = objRow[conPaper.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.DownloadCount].ToString().Trim()); //下载数
objPaperEN.OkCount = objRow[conPaper.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.OkCount].ToString().Trim()); //点赞统计
objPaperEN.Pcount = objRow[conPaper.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.Pcount].ToString().Trim()); //读写数
objPaperEN.Score = objRow[conPaper.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.Score].ToString().Trim()); //评分
objPaperEN.StuScore = objRow[conPaper.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.StuScore].ToString().Trim()); //学生平均分
objPaperEN.TeaScore = objRow[conPaper.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.TeaScore].ToString().Trim()); //教师评分
objPaperEN.PaperTypeId = objRow[conPaper.PaperTypeId] == DBNull.Value ? null : objRow[conPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objPaperEN.PaperStatusId = objRow[conPaper.PaperStatusId] == DBNull.Value ? null : objRow[conPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objPaperEN.VersionCount = objRow[conPaper.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.VersionCount].ToString().Trim()); //版本统计
objPaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsPublic].ToString().Trim()); //是否公开
objPaperEN.AskQuestion = objRow[conPaper.AskQuestion] == DBNull.Value ? null : objRow[conPaper.AskQuestion].ToString().Trim(); //问题提出
objPaperEN.ResearchStatus = objRow[conPaper.ResearchStatus] == DBNull.Value ? null : objRow[conPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objPaperEN.InnovationPoints = objRow[conPaper.InnovationPoints] == DBNull.Value ? null : objRow[conPaper.InnovationPoints].ToString().Trim(); //创新点
objPaperEN.ResearchDesign = objRow[conPaper.ResearchDesign] == DBNull.Value ? null : objRow[conPaper.ResearchDesign].ToString().Trim(); //研究设计
objPaperEN.DimensionDataProcess = objRow[conPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[conPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objPaperEN.ExpectedConclusion = objRow[conPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[conPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objPaperEN.ShareId = objRow[conPaper.ShareId] == DBNull.Value ? null : objRow[conPaper.ShareId].ToString().Trim(); //分享Id
objPaperEN.PaperQCount = objRow[conPaper.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.PaperQCount].ToString().Trim()); //论文答疑数
objPaperEN.SubVCount = objRow[conPaper.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.SubVCount].ToString().Trim()); //论文子观点数
objPaperEN.TagsCount = objRow[conPaper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.TagsCount].ToString().Trim()); //论文标注数
objPaperEN.TeaQCount = objRow[conPaper.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.TeaQCount].ToString().Trim()); //教师提问数
objPaperEN.IdStudyLevel = objRow[conPaper.IdStudyLevel] == DBNull.Value ? null : objRow[conPaper.IdStudyLevel].ToString().Trim(); //学段流水号
objPaperEN.IdGrade = objRow[conPaper.IdGrade] == DBNull.Value ? null : objRow[conPaper.IdGrade].ToString().Trim(); //年级流水号
objPaperEN.CreateDate = objRow[conPaper.CreateDate] == DBNull.Value ? null : objRow[conPaper.CreateDate].ToString().Trim(); //建立日期
objPaperEN.UpdUser = objRow[conPaper.UpdUser] == DBNull.Value ? null : objRow[conPaper.UpdUser].ToString().Trim(); //修改人
objPaperEN.UpdDate = objRow[conPaper.UpdDate] == DBNull.Value ? null : objRow[conPaper.UpdDate].ToString().Trim(); //修改日期
objPaperEN.Memo = objRow[conPaper.Memo] == DBNull.Value ? null : objRow[conPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPaperEN> arrObjLst = new List<clsPaperEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperEN objPaperEN = new clsPaperEN();
try
{
objPaperEN.PaperId = objRow[conPaper.PaperId].ToString().Trim(); //论文Id
objPaperEN.PaperTitle = objRow[conPaper.PaperTitle].ToString().Trim(); //论文标题
objPaperEN.PaperContent = objRow[conPaper.PaperContent] == DBNull.Value ? null : objRow[conPaper.PaperContent].ToString().Trim(); //主题内容
objPaperEN.Periodical = objRow[conPaper.Periodical] == DBNull.Value ? null : objRow[conPaper.Periodical].ToString().Trim(); //期刊
objPaperEN.Author = objRow[conPaper.Author] == DBNull.Value ? null : objRow[conPaper.Author].ToString().Trim(); //作者
objPaperEN.ResearchQuestion = objRow[conPaper.ResearchQuestion] == DBNull.Value ? null : objRow[conPaper.ResearchQuestion].ToString().Trim(); //研究问题
objPaperEN.Keyword = objRow[conPaper.Keyword] == DBNull.Value ? null : objRow[conPaper.Keyword].ToString().Trim(); //关键字
objPaperEN.LiteratureSources = objRow[conPaper.LiteratureSources] == DBNull.Value ? null : objRow[conPaper.LiteratureSources].ToString().Trim(); //文献来源
objPaperEN.LiteratureLink = objRow[conPaper.LiteratureLink] == DBNull.Value ? null : objRow[conPaper.LiteratureLink].ToString().Trim(); //文献链接
objPaperEN.UploadfileUrl = objRow[conPaper.UploadfileUrl] == DBNull.Value ? null : objRow[conPaper.UploadfileUrl].ToString().Trim(); //文件地址
objPaperEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsQuotethesis].ToString().Trim()); //是否引用论文
objPaperEN.QuoteId = objRow[conPaper.QuoteId] == DBNull.Value ? null : objRow[conPaper.QuoteId].ToString().Trim(); //引用Id
objPaperEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsChecked].ToString().Trim()); //是否检查
objPaperEN.Checker = objRow[conPaper.Checker] == DBNull.Value ? null : objRow[conPaper.Checker].ToString().Trim(); //审核人
objPaperEN.LiteratureTypeId = objRow[conPaper.LiteratureTypeId].ToString().Trim(); //文献类型Id
objPaperEN.BrowseNumber = objRow[conPaper.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.BrowseNumber].ToString().Trim()); //浏览量
objPaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsSubmit].ToString().Trim()); //是否提交
objPaperEN.AppraiseCount = objRow[conPaper.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.AppraiseCount].ToString().Trim()); //评论数
objPaperEN.AttachmentCount = objRow[conPaper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.AttachmentCount].ToString().Trim()); //附件计数
objPaperEN.CollectionCount = objRow[conPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.CollectionCount].ToString().Trim()); //收藏数量
objPaperEN.DownloadCount = objRow[conPaper.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.DownloadCount].ToString().Trim()); //下载数
objPaperEN.OkCount = objRow[conPaper.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.OkCount].ToString().Trim()); //点赞统计
objPaperEN.Pcount = objRow[conPaper.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.Pcount].ToString().Trim()); //读写数
objPaperEN.Score = objRow[conPaper.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.Score].ToString().Trim()); //评分
objPaperEN.StuScore = objRow[conPaper.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.StuScore].ToString().Trim()); //学生平均分
objPaperEN.TeaScore = objRow[conPaper.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaper.TeaScore].ToString().Trim()); //教师评分
objPaperEN.PaperTypeId = objRow[conPaper.PaperTypeId] == DBNull.Value ? null : objRow[conPaper.PaperTypeId].ToString().Trim(); //论文类型Id
objPaperEN.PaperStatusId = objRow[conPaper.PaperStatusId] == DBNull.Value ? null : objRow[conPaper.PaperStatusId].ToString().Trim(); //论文状态Id
objPaperEN.VersionCount = objRow[conPaper.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.VersionCount].ToString().Trim()); //版本统计
objPaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaper.IsPublic].ToString().Trim()); //是否公开
objPaperEN.AskQuestion = objRow[conPaper.AskQuestion] == DBNull.Value ? null : objRow[conPaper.AskQuestion].ToString().Trim(); //问题提出
objPaperEN.ResearchStatus = objRow[conPaper.ResearchStatus] == DBNull.Value ? null : objRow[conPaper.ResearchStatus].ToString().Trim(); //目前研究的现状
objPaperEN.InnovationPoints = objRow[conPaper.InnovationPoints] == DBNull.Value ? null : objRow[conPaper.InnovationPoints].ToString().Trim(); //创新点
objPaperEN.ResearchDesign = objRow[conPaper.ResearchDesign] == DBNull.Value ? null : objRow[conPaper.ResearchDesign].ToString().Trim(); //研究设计
objPaperEN.DimensionDataProcess = objRow[conPaper.DimensionDataProcess] == DBNull.Value ? null : objRow[conPaper.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objPaperEN.ExpectedConclusion = objRow[conPaper.ExpectedConclusion] == DBNull.Value ? null : objRow[conPaper.ExpectedConclusion].ToString().Trim(); //预期结论
objPaperEN.ShareId = objRow[conPaper.ShareId] == DBNull.Value ? null : objRow[conPaper.ShareId].ToString().Trim(); //分享Id
objPaperEN.PaperQCount = objRow[conPaper.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.PaperQCount].ToString().Trim()); //论文答疑数
objPaperEN.SubVCount = objRow[conPaper.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.SubVCount].ToString().Trim()); //论文子观点数
objPaperEN.TagsCount = objRow[conPaper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.TagsCount].ToString().Trim()); //论文标注数
objPaperEN.TeaQCount = objRow[conPaper.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaper.TeaQCount].ToString().Trim()); //教师提问数
objPaperEN.IdStudyLevel = objRow[conPaper.IdStudyLevel] == DBNull.Value ? null : objRow[conPaper.IdStudyLevel].ToString().Trim(); //学段流水号
objPaperEN.IdGrade = objRow[conPaper.IdGrade] == DBNull.Value ? null : objRow[conPaper.IdGrade].ToString().Trim(); //年级流水号
objPaperEN.CreateDate = objRow[conPaper.CreateDate] == DBNull.Value ? null : objRow[conPaper.CreateDate].ToString().Trim(); //建立日期
objPaperEN.UpdUser = objRow[conPaper.UpdUser] == DBNull.Value ? null : objRow[conPaper.UpdUser].ToString().Trim(); //修改人
objPaperEN.UpdDate = objRow[conPaper.UpdDate] == DBNull.Value ? null : objRow[conPaper.UpdDate].ToString().Trim(); //修改日期
objPaperEN.Memo = objRow[conPaper.Memo] == DBNull.Value ? null : objRow[conPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPaperEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPaper(ref clsPaperEN objPaperEN)
{
bool bolResult = PaperDA.GetPaper(ref objPaperEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPaperEN GetObjByPaperId(string strPaperId)
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
clsPaperEN objPaperEN = PaperDA.GetObjByPaperId(strPaperId);
return objPaperEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPaperEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPaperEN objPaperEN = PaperDA.GetFirstObj(strWhereCond);
 return objPaperEN;
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
public static clsPaperEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPaperEN objPaperEN = PaperDA.GetObjByDataRow(objRow);
 return objPaperEN;
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
public static clsPaperEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPaperEN objPaperEN = PaperDA.GetObjByDataRow(objRow);
 return objPaperEN;
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
 /// <param name = "lstPaperObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPaperEN GetObjByPaperIdFromList(string strPaperId, List<clsPaperEN> lstPaperObjLst)
{
foreach (clsPaperEN objPaperEN in lstPaperObjLst)
{
if (objPaperEN.PaperId == strPaperId)
{
return objPaperEN;
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
 strMaxPaperId = clsPaperDA.GetMaxStrId();
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
 strPaperId = new clsPaperDA().GetFirstID(strWhereCond);
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
 arrList = PaperDA.GetID(strWhereCond);
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
bool bolIsExist = PaperDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = PaperDA.IsExist(strPaperId);
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
 bolIsExist = clsPaperDA.IsExistTable();
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
 bolIsExist = PaperDA.IsExistTable(strTabName);
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
 /// <param name = "objPaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPaperEN objPaperEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPaperEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!论文标题 = [{0}],作者 = [{1}]的数据已经存在!(in clsPaperBL.AddNewRecordBySql2)", objPaperEN.PaperTitle,objPaperEN.Author);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPaperEN.PaperId) == true || clsPaperBL.IsExist(objPaperEN.PaperId) == true)
 {
     objPaperEN.PaperId = clsPaperBL.GetMaxStrId_S();
 }
bool bolResult = PaperDA.AddNewRecordBySQL2(objPaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperBL.ReFreshCache();

if (clsPaperBL.relatedActions != null)
{
clsPaperBL.relatedActions.UpdRelaTabDate(objPaperEN.PaperId, "SetUpdDate");
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
 /// <param name = "objPaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPaperEN objPaperEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPaperEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!论文标题 = [{0}],作者 = [{1}]的数据已经存在!(in clsPaperBL.AddNewRecordBySql2WithReturnKey)", objPaperEN.PaperTitle,objPaperEN.Author);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPaperEN.PaperId) == true || clsPaperBL.IsExist(objPaperEN.PaperId) == true)
 {
     objPaperEN.PaperId = clsPaperBL.GetMaxStrId_S();
 }
string strKey = PaperDA.AddNewRecordBySQL2WithReturnKey(objPaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperBL.ReFreshCache();

if (clsPaperBL.relatedActions != null)
{
clsPaperBL.relatedActions.UpdRelaTabDate(objPaperEN.PaperId, "SetUpdDate");
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
 /// <param name = "objPaperEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPaperEN objPaperEN)
{
try
{
bool bolResult = PaperDA.Update(objPaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperBL.ReFreshCache();

if (clsPaperBL.relatedActions != null)
{
clsPaperBL.relatedActions.UpdRelaTabDate(objPaperEN.PaperId, "SetUpdDate");
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
 /// <param name = "objPaperEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPaperEN objPaperEN)
{
 if (string.IsNullOrEmpty(objPaperEN.PaperId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PaperDA.UpdateBySql2(objPaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperBL.ReFreshCache();

if (clsPaperBL.relatedActions != null)
{
clsPaperBL.relatedActions.UpdRelaTabDate(objPaperEN.PaperId, "SetUpdDate");
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
 /// <param name = "strPaperId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strPaperId)
{
try
{
 clsPaperEN objPaperEN = clsPaperBL.GetObjByPaperId(strPaperId);

if (clsPaperBL.relatedActions != null)
{
clsPaperBL.relatedActions.UpdRelaTabDate(objPaperEN.PaperId, "SetUpdDate");
}
if (objPaperEN != null)
{
int intRecNum = PaperDA.DelRecord(strPaperId);
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
/// <param name="strPaperId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strPaperId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPaperDA.GetSpecSQLObj();
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
//删除与表:[Paper]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPaper.PaperId,
//strPaperId);
//        clsPaperBL.DelPapersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPaperBL.DelRecord(strPaperId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPaperBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPaperId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strPaperId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strPaperId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPaperBL.relatedActions != null)
{
clsPaperBL.relatedActions.UpdRelaTabDate(strPaperId, "UpdRelaTabDate");
}
bool bolResult = PaperDA.DelRecord(strPaperId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrPaperIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPapers(List<string> arrPaperIdLst)
{
if (arrPaperIdLst.Count == 0) return 0;
try
{
if (clsPaperBL.relatedActions != null)
{
foreach (var strPaperId in arrPaperIdLst)
{
clsPaperBL.relatedActions.UpdRelaTabDate(strPaperId, "UpdRelaTabDate");
}
}
int intDelRecNum = PaperDA.DelPaper(arrPaperIdLst);
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
public static int DelPapersByCond(string strWhereCond)
{
try
{
if (clsPaperBL.relatedActions != null)
{
List<string> arrPaperId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPaperId in arrPaperId)
{
clsPaperBL.relatedActions.UpdRelaTabDate(strPaperId, "UpdRelaTabDate");
}
}
int intRecNum = PaperDA.DelPaper(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[Paper]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strPaperId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strPaperId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPaperDA.GetSpecSQLObj();
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
//删除与表:[Paper]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPaperBL.DelRecord(strPaperId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPaperBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPaperId, clsStackTrace.GetCurrClassFunction());
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
objPaperENT.LiteratureTypeId = objPaperENS.LiteratureTypeId; //文献类型Id
objPaperENT.BrowseNumber = objPaperENS.BrowseNumber; //浏览量
objPaperENT.IsSubmit = objPaperENS.IsSubmit; //是否提交
objPaperENT.AppraiseCount = objPaperENS.AppraiseCount; //评论数
objPaperENT.AttachmentCount = objPaperENS.AttachmentCount; //附件计数
objPaperENT.CollectionCount = objPaperENS.CollectionCount; //收藏数量
objPaperENT.DownloadCount = objPaperENS.DownloadCount; //下载数
objPaperENT.OkCount = objPaperENS.OkCount; //点赞统计
objPaperENT.Pcount = objPaperENS.Pcount; //读写数
objPaperENT.Score = objPaperENS.Score; //评分
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
objPaperENT.IdStudyLevel = objPaperENS.IdStudyLevel; //学段流水号
objPaperENT.IdGrade = objPaperENS.IdGrade; //年级流水号
objPaperENT.CreateDate = objPaperENS.CreateDate; //建立日期
objPaperENT.UpdUser = objPaperENS.UpdUser; //修改人
objPaperENT.UpdDate = objPaperENS.UpdDate; //修改日期
objPaperENT.Memo = objPaperENS.Memo; //备注
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
 /// <param name = "objPaperEN">源简化对象</param>
 public static void SetUpdFlag(clsPaperEN objPaperEN)
{
try
{
objPaperEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPaperEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPaper.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.PaperId = objPaperEN.PaperId; //论文Id
}
if (arrFldSet.Contains(conPaper.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.PaperTitle = objPaperEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(conPaper.PaperContent, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.PaperContent = objPaperEN.PaperContent == "[null]" ? null :  objPaperEN.PaperContent; //主题内容
}
if (arrFldSet.Contains(conPaper.Periodical, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.Periodical = objPaperEN.Periodical == "[null]" ? null :  objPaperEN.Periodical; //期刊
}
if (arrFldSet.Contains(conPaper.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.Author = objPaperEN.Author == "[null]" ? null :  objPaperEN.Author; //作者
}
if (arrFldSet.Contains(conPaper.ResearchQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.ResearchQuestion = objPaperEN.ResearchQuestion == "[null]" ? null :  objPaperEN.ResearchQuestion; //研究问题
}
if (arrFldSet.Contains(conPaper.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.Keyword = objPaperEN.Keyword == "[null]" ? null :  objPaperEN.Keyword; //关键字
}
if (arrFldSet.Contains(conPaper.LiteratureSources, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.LiteratureSources = objPaperEN.LiteratureSources == "[null]" ? null :  objPaperEN.LiteratureSources; //文献来源
}
if (arrFldSet.Contains(conPaper.LiteratureLink, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.LiteratureLink = objPaperEN.LiteratureLink == "[null]" ? null :  objPaperEN.LiteratureLink; //文献链接
}
if (arrFldSet.Contains(conPaper.UploadfileUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.UploadfileUrl = objPaperEN.UploadfileUrl == "[null]" ? null :  objPaperEN.UploadfileUrl; //文件地址
}
if (arrFldSet.Contains(conPaper.IsQuotethesis, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.IsQuotethesis = objPaperEN.IsQuotethesis; //是否引用论文
}
if (arrFldSet.Contains(conPaper.QuoteId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.QuoteId = objPaperEN.QuoteId == "[null]" ? null :  objPaperEN.QuoteId; //引用Id
}
if (arrFldSet.Contains(conPaper.IsChecked, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.IsChecked = objPaperEN.IsChecked; //是否检查
}
if (arrFldSet.Contains(conPaper.Checker, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.Checker = objPaperEN.Checker == "[null]" ? null :  objPaperEN.Checker; //审核人
}
if (arrFldSet.Contains(conPaper.LiteratureTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.LiteratureTypeId = objPaperEN.LiteratureTypeId; //文献类型Id
}
if (arrFldSet.Contains(conPaper.BrowseNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.BrowseNumber = objPaperEN.BrowseNumber; //浏览量
}
if (arrFldSet.Contains(conPaper.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.IsSubmit = objPaperEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conPaper.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.AppraiseCount = objPaperEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(conPaper.AttachmentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.AttachmentCount = objPaperEN.AttachmentCount; //附件计数
}
if (arrFldSet.Contains(conPaper.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.CollectionCount = objPaperEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(conPaper.DownloadCount, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.DownloadCount = objPaperEN.DownloadCount; //下载数
}
if (arrFldSet.Contains(conPaper.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.OkCount = objPaperEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(conPaper.Pcount, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.Pcount = objPaperEN.Pcount; //读写数
}
if (arrFldSet.Contains(conPaper.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.Score = objPaperEN.Score; //评分
}
if (arrFldSet.Contains(conPaper.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.StuScore = objPaperEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(conPaper.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.TeaScore = objPaperEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conPaper.PaperTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.PaperTypeId = objPaperEN.PaperTypeId == "[null]" ? null :  objPaperEN.PaperTypeId; //论文类型Id
}
if (arrFldSet.Contains(conPaper.PaperStatusId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.PaperStatusId = objPaperEN.PaperStatusId == "[null]" ? null :  objPaperEN.PaperStatusId; //论文状态Id
}
if (arrFldSet.Contains(conPaper.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.VersionCount = objPaperEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(conPaper.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.IsPublic = objPaperEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(conPaper.AskQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.AskQuestion = objPaperEN.AskQuestion == "[null]" ? null :  objPaperEN.AskQuestion; //问题提出
}
if (arrFldSet.Contains(conPaper.ResearchStatus, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.ResearchStatus = objPaperEN.ResearchStatus == "[null]" ? null :  objPaperEN.ResearchStatus; //目前研究的现状
}
if (arrFldSet.Contains(conPaper.InnovationPoints, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.InnovationPoints = objPaperEN.InnovationPoints == "[null]" ? null :  objPaperEN.InnovationPoints; //创新点
}
if (arrFldSet.Contains(conPaper.ResearchDesign, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.ResearchDesign = objPaperEN.ResearchDesign == "[null]" ? null :  objPaperEN.ResearchDesign; //研究设计
}
if (arrFldSet.Contains(conPaper.DimensionDataProcess, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.DimensionDataProcess = objPaperEN.DimensionDataProcess == "[null]" ? null :  objPaperEN.DimensionDataProcess; //数据处理的维度
}
if (arrFldSet.Contains(conPaper.ExpectedConclusion, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.ExpectedConclusion = objPaperEN.ExpectedConclusion == "[null]" ? null :  objPaperEN.ExpectedConclusion; //预期结论
}
if (arrFldSet.Contains(conPaper.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.ShareId = objPaperEN.ShareId == "[null]" ? null :  objPaperEN.ShareId; //分享Id
}
if (arrFldSet.Contains(conPaper.PaperQCount, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.PaperQCount = objPaperEN.PaperQCount; //论文答疑数
}
if (arrFldSet.Contains(conPaper.SubVCount, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.SubVCount = objPaperEN.SubVCount; //论文子观点数
}
if (arrFldSet.Contains(conPaper.TagsCount, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.TagsCount = objPaperEN.TagsCount; //论文标注数
}
if (arrFldSet.Contains(conPaper.TeaQCount, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.TeaQCount = objPaperEN.TeaQCount; //教师提问数
}
if (arrFldSet.Contains(conPaper.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.IdStudyLevel = objPaperEN.IdStudyLevel == "[null]" ? null :  objPaperEN.IdStudyLevel; //学段流水号
}
if (arrFldSet.Contains(conPaper.IdGrade, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.IdGrade = objPaperEN.IdGrade == "[null]" ? null :  objPaperEN.IdGrade; //年级流水号
}
if (arrFldSet.Contains(conPaper.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.CreateDate = objPaperEN.CreateDate == "[null]" ? null :  objPaperEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conPaper.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.UpdUser = objPaperEN.UpdUser == "[null]" ? null :  objPaperEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conPaper.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.UpdDate = objPaperEN.UpdDate == "[null]" ? null :  objPaperEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conPaper.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperEN.Memo = objPaperEN.Memo == "[null]" ? null :  objPaperEN.Memo; //备注
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
 /// <param name = "objPaperEN">源简化对象</param>
 public static void AccessFldValueNull(clsPaperEN objPaperEN)
{
try
{
if (objPaperEN.PaperContent == "[null]") objPaperEN.PaperContent = null; //主题内容
if (objPaperEN.Periodical == "[null]") objPaperEN.Periodical = null; //期刊
if (objPaperEN.Author == "[null]") objPaperEN.Author = null; //作者
if (objPaperEN.ResearchQuestion == "[null]") objPaperEN.ResearchQuestion = null; //研究问题
if (objPaperEN.Keyword == "[null]") objPaperEN.Keyword = null; //关键字
if (objPaperEN.LiteratureSources == "[null]") objPaperEN.LiteratureSources = null; //文献来源
if (objPaperEN.LiteratureLink == "[null]") objPaperEN.LiteratureLink = null; //文献链接
if (objPaperEN.UploadfileUrl == "[null]") objPaperEN.UploadfileUrl = null; //文件地址
if (objPaperEN.QuoteId == "[null]") objPaperEN.QuoteId = null; //引用Id
if (objPaperEN.Checker == "[null]") objPaperEN.Checker = null; //审核人
if (objPaperEN.PaperTypeId == "[null]") objPaperEN.PaperTypeId = null; //论文类型Id
if (objPaperEN.PaperStatusId == "[null]") objPaperEN.PaperStatusId = null; //论文状态Id
if (objPaperEN.AskQuestion == "[null]") objPaperEN.AskQuestion = null; //问题提出
if (objPaperEN.ResearchStatus == "[null]") objPaperEN.ResearchStatus = null; //目前研究的现状
if (objPaperEN.InnovationPoints == "[null]") objPaperEN.InnovationPoints = null; //创新点
if (objPaperEN.ResearchDesign == "[null]") objPaperEN.ResearchDesign = null; //研究设计
if (objPaperEN.DimensionDataProcess == "[null]") objPaperEN.DimensionDataProcess = null; //数据处理的维度
if (objPaperEN.ExpectedConclusion == "[null]") objPaperEN.ExpectedConclusion = null; //预期结论
if (objPaperEN.ShareId == "[null]") objPaperEN.ShareId = null; //分享Id
if (objPaperEN.IdStudyLevel == "[null]") objPaperEN.IdStudyLevel = null; //学段流水号
if (objPaperEN.IdGrade == "[null]") objPaperEN.IdGrade = null; //年级流水号
if (objPaperEN.CreateDate == "[null]") objPaperEN.CreateDate = null; //建立日期
if (objPaperEN.UpdUser == "[null]") objPaperEN.UpdUser = null; //修改人
if (objPaperEN.UpdDate == "[null]") objPaperEN.UpdDate = null; //修改日期
if (objPaperEN.Memo == "[null]") objPaperEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsPaperEN objPaperEN)
{
 PaperDA.CheckPropertyNew(objPaperEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPaperEN objPaperEN)
{
 PaperDA.CheckProperty4Condition(objPaperEN);
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
if (clsPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperBL没有刷新缓存机制(clsPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperId");
//if (arrPaperObjLstCache == null)
//{
//arrPaperObjLstCache = PaperDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPaperId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPaperEN GetObjByPaperIdCache(string strPaperId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsPaperEN._CurrTabName);
List<clsPaperEN> arrPaperObjLstCache = GetObjLstCache();
IEnumerable <clsPaperEN> arrPaperObjLst_Sel =
arrPaperObjLstCache
.Where(x=> x.PaperId == strPaperId 
);
if (arrPaperObjLst_Sel.Count() == 0)
{
   clsPaperEN obj = clsPaperBL.GetObjByPaperId(strPaperId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrPaperObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPaperEN> GetAllPaperObjLstCache()
{
//获取缓存中的对象列表
List<clsPaperEN> arrPaperObjLstCache = GetObjLstCache(); 
return arrPaperObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPaperEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsPaperEN._CurrTabName);
List<clsPaperEN> arrPaperObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPaperObjLstCache;
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
string strKey = string.Format("{0}", clsPaperEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPaperEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsPaperEN._RefreshTimeLst.Count == 0) return "";
return clsPaperEN._RefreshTimeLst[clsPaperEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsPaperBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPaperEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPaperEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPaperBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--Paper(论文表)
 /// 唯一性条件:PaperTitle_Author
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPaperEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsPaperEN objPaperEN)
{
//检测记录是否存在
string strResult = PaperDA.GetUniCondStr(objPaperEN);
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
public static string Func(string strInFldName, string strOutFldName, string strPaperId)
{
if (strInFldName != conPaper.PaperId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPaper.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPaper.AttributeName));
throw new Exception(strMsg);
}
var objPaper = clsPaperBL.GetObjByPaperIdCache(strPaperId);
if (objPaper == null) return "";
return objPaper[strOutFldName].ToString();
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
int intRecCount = clsPaperDA.GetRecCount(strTabName);
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
int intRecCount = clsPaperDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPaperDA.GetRecCount();
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
int intRecCount = clsPaperDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPaperCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPaperEN objPaperCond)
{
List<clsPaperEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPaperEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPaper.AttributeName)
{
if (objPaperCond.IsUpdated(strFldName) == false) continue;
if (objPaperCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperCond[strFldName].ToString());
}
else
{
if (objPaperCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPaperCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPaperCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPaperCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPaperCond[strFldName]));
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
 List<string> arrList = clsPaperDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PaperDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PaperDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PaperDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPaperDA.SetFldValue(clsPaperEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PaperDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPaperDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPaperDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPaperDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[Paper] "); 
 strCreateTabCode.Append(" ( "); 
 // /**论文Id*/ 
 strCreateTabCode.Append(" PaperId char(8) primary key, "); 
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
 // /**引用Id*/ 
 strCreateTabCode.Append(" QuoteId char(8) Null, "); 
 // /**是否检查*/ 
 strCreateTabCode.Append(" IsChecked bit Null, "); 
 // /**审核人*/ 
 strCreateTabCode.Append(" Checker varchar(20) Null, "); 
 // /**文献类型Id*/ 
 strCreateTabCode.Append(" LiteratureTypeId char(2) not Null, "); 
 // /**浏览量*/ 
 strCreateTabCode.Append(" BrowseNumber int Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**评论数*/ 
 strCreateTabCode.Append(" AppraiseCount int Null, "); 
 // /**附件计数*/ 
 strCreateTabCode.Append(" AttachmentCount int Null, "); 
 // /**收藏数量*/ 
 strCreateTabCode.Append(" CollectionCount bigint Null, "); 
 // /**下载数*/ 
 strCreateTabCode.Append(" DownloadCount int Null, "); 
 // /**点赞统计*/ 
 strCreateTabCode.Append(" OkCount int Null, "); 
 // /**读写数*/ 
 strCreateTabCode.Append(" Pcount int Null, "); 
 // /**评分*/ 
 strCreateTabCode.Append(" Score float Null, "); 
 // /**学生平均分*/ 
 strCreateTabCode.Append(" StuScore float Null, "); 
 // /**教师评分*/ 
 strCreateTabCode.Append(" TeaScore float Null, "); 
 // /**论文类型Id*/ 
 strCreateTabCode.Append(" PaperTypeId char(2) Null, "); 
 // /**论文状态Id*/ 
 strCreateTabCode.Append(" PaperStatusId char(2) Null, "); 
 // /**版本统计*/ 
 strCreateTabCode.Append(" VersionCount int Null, "); 
 // /**是否公开*/ 
 strCreateTabCode.Append(" IsPublic bit Null, "); 
 // /**问题提出*/ 
 strCreateTabCode.Append(" AskQuestion varchar(5000) Null, "); 
 // /**目前研究的现状*/ 
 strCreateTabCode.Append(" ResearchStatus varchar(5000) Null, "); 
 // /**创新点*/ 
 strCreateTabCode.Append(" InnovationPoints varchar(5000) Null, "); 
 // /**研究设计*/ 
 strCreateTabCode.Append(" ResearchDesign varchar(5000) Null, "); 
 // /**数据处理的维度*/ 
 strCreateTabCode.Append(" DimensionDataProcess varchar(5000) Null, "); 
 // /**预期结论*/ 
 strCreateTabCode.Append(" ExpectedConclusion varchar(5000) Null, "); 
 // /**分享Id*/ 
 strCreateTabCode.Append(" ShareId char(2) Null, "); 
 // /**论文答疑数*/ 
 strCreateTabCode.Append(" PaperQCount int Null, "); 
 // /**论文子观点数*/ 
 strCreateTabCode.Append(" SubVCount int Null, "); 
 // /**论文标注数*/ 
 strCreateTabCode.Append(" TagsCount int Null, "); 
 // /**教师提问数*/ 
 strCreateTabCode.Append(" TeaQCount int Null, "); 
 // /**学段流水号*/ 
 strCreateTabCode.Append(" IdStudyLevel char(4) Null, "); 
 // /**年级流水号*/ 
 strCreateTabCode.Append(" IdGrade char(4) Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**论文类型名*/ 
 strCreateTabCode.Append(" PaperTypeName varchar(50) Null, "); 
 // /**是否投票*/ 
 strCreateTabCode.Append(" IsSysVote bit Null, "); 
 // /**是否收藏*/ 
 strCreateTabCode.Append(" IsCollection bit Null, "); 
 // /**是否收藏*/ 
 strCreateTabCode.Append(" IsHasAttention bit Null, "); 
 // /**UpdUserName*/ 
 strCreateTabCode.Append(" UpdUserName varchar(20) Null, "); 
 // /**作者*/ 
 strCreateTabCode.Append(" DdAuthor varchar(200) Null, "); 
 // /**期刊*/ 
 strCreateTabCode.Append(" DdPeriodical varchar(100) Null, "); 
 // /**关键字*/ 
 strCreateTabCode.Append(" DdKeyword varchar(1000) Null, "); 
 // /**文献来源*/ 
 strCreateTabCode.Append(" DdLiteratureSources varchar(1000) Null, "); 
 // /**文献类型名*/ 
 strCreateTabCode.Append(" LiteratureTypeName varchar(100) Null, "); 
 // /**论文状态名*/ 
 strCreateTabCode.Append(" PaperStatusName varchar(50) Null, "); 
 // /**研究方向Id*/ 
 strCreateTabCode.Append(" MajorDirectionId char(8) Null, "); 
 // /**学段名称*/ 
 strCreateTabCode.Append(" StudyLevelName varchar(50) Null, "); 
 // /**年级名称*/ 
 strCreateTabCode.Append(" GradeName varchar(50) Null, "); 
 // /**节数*/ 
 strCreateTabCode.Append(" SectionNum int Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 论文表(Paper)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4Paper : clsCommFun4BL
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
clsPaperBL.ReFreshThisCache();
}
}

}