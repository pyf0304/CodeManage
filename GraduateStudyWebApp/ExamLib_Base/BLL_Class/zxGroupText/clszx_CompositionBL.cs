
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_CompositionBL
 表名:zx_Composition(01120761)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:53:36
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文(zxGroupText)
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
public static class  clszx_CompositionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_CompositionEN GetObj(this K_zxPaperId_zx_Composition myKey)
{
clszx_CompositionEN objzx_CompositionEN = clszx_CompositionBL.zx_CompositionDA.GetObjByzxPaperId(myKey.Value);
return objzx_CompositionEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_CompositionEN objzx_CompositionEN)
{
if (CheckUniqueness(objzx_CompositionEN) == false)
{
var strMsg = string.Format("记录已经存在!论文Id = [{0}]的数据已经存在!(in clszx_CompositionBL.AddNewRecord)", objzx_CompositionEN.zxPaperId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_CompositionEN.zxPaperId) == true || clszx_CompositionBL.IsExist(objzx_CompositionEN.zxPaperId) == true)
 {
     objzx_CompositionEN.zxPaperId = clszx_CompositionBL.GetMaxStrId_S();
 }
bool bolResult = clszx_CompositionBL.zx_CompositionDA.AddNewRecordBySQL2(objzx_CompositionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_CompositionBL.ReFreshCache();

if (clszx_CompositionBL.relatedActions != null)
{
clszx_CompositionBL.relatedActions.UpdRelaTabDate(objzx_CompositionEN.zxPaperId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_CompositionEN objzx_CompositionEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clszx_CompositionBL.IsExist(objzx_CompositionEN.zxPaperId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objzx_CompositionEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_CompositionEN.CheckUniqueness() == false)
{
strMsg = string.Format("(论文Id(zxPaperId)=[{0}])已经存在,不能重复!", objzx_CompositionEN.zxPaperId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objzx_CompositionEN.zxPaperId) == true || clszx_CompositionBL.IsExist(objzx_CompositionEN.zxPaperId) == true)
 {
     objzx_CompositionEN.zxPaperId = clszx_CompositionBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objzx_CompositionEN.AddNewRecord();
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
 /// <param name = "objzx_CompositionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clszx_CompositionEN objzx_CompositionEN)
{
if (CheckUniqueness(objzx_CompositionEN) == false)
{
var strMsg = string.Format("记录已经存在!论文Id = [{0}]的数据已经存在!(in clszx_CompositionBL.AddNewRecordWithMaxId)", objzx_CompositionEN.zxPaperId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_CompositionEN.zxPaperId) == true || clszx_CompositionBL.IsExist(objzx_CompositionEN.zxPaperId) == true)
 {
     objzx_CompositionEN.zxPaperId = clszx_CompositionBL.GetMaxStrId_S();
 }
string strzxPaperId = clszx_CompositionBL.zx_CompositionDA.AddNewRecordBySQL2WithReturnKey(objzx_CompositionEN);
     objzx_CompositionEN.zxPaperId = strzxPaperId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_CompositionBL.ReFreshCache();

if (clszx_CompositionBL.relatedActions != null)
{
clszx_CompositionBL.relatedActions.UpdRelaTabDate(objzx_CompositionEN.zxPaperId, "SetUpdDate");
}
return strzxPaperId;
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
 /// <param name = "objzx_CompositionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_CompositionEN objzx_CompositionEN)
{
if (CheckUniqueness(objzx_CompositionEN) == false)
{
var strMsg = string.Format("记录已经存在!论文Id = [{0}]的数据已经存在!(in clszx_CompositionBL.AddNewRecordWithReturnKey)", objzx_CompositionEN.zxPaperId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_CompositionEN.zxPaperId) == true || clszx_CompositionBL.IsExist(objzx_CompositionEN.zxPaperId) == true)
 {
     objzx_CompositionEN.zxPaperId = clszx_CompositionBL.GetMaxStrId_S();
 }
string strKey = clszx_CompositionBL.zx_CompositionDA.AddNewRecordBySQL2WithReturnKey(objzx_CompositionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_CompositionBL.ReFreshCache();

if (clszx_CompositionBL.relatedActions != null)
{
clszx_CompositionBL.relatedActions.UpdRelaTabDate(objzx_CompositionEN.zxPaperId, "SetUpdDate");
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
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetzxPaperId(this clszx_CompositionEN objzx_CompositionEN, string strzxPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxPaperId, 8, conzx_Composition.zxPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxPaperId, 8, conzx_Composition.zxPaperId);
}
objzx_CompositionEN.zxPaperId = strzxPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.zxPaperId) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.zxPaperId, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.zxPaperId] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetPaperTitle(this clszx_CompositionEN objzx_CompositionEN, string strPaperTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperTitle, conzx_Composition.PaperTitle);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, conzx_Composition.PaperTitle);
}
objzx_CompositionEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.PaperTitle) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.PaperTitle, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.PaperTitle] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetPaperName(this clszx_CompositionEN objzx_CompositionEN, string strPaperName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperName, 500, conzx_Composition.PaperName);
}
objzx_CompositionEN.PaperName = strPaperName; //主题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.PaperName) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.PaperName, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.PaperName] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetPaperContent(this clszx_CompositionEN objzx_CompositionEN, string strPaperContent, string strComparisonOp="")
	{
objzx_CompositionEN.PaperContent = strPaperContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.PaperContent) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.PaperContent, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.PaperContent] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetPeriodical(this clszx_CompositionEN objzx_CompositionEN, string strPeriodical, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPeriodical, 100, conzx_Composition.Periodical);
}
objzx_CompositionEN.Periodical = strPeriodical; //期刊
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.Periodical) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.Periodical, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.Periodical] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetAuthor(this clszx_CompositionEN objzx_CompositionEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, conzx_Composition.Author);
}
objzx_CompositionEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.Author) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.Author, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.Author] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetResearchQuestion(this clszx_CompositionEN objzx_CompositionEN, string strResearchQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, conzx_Composition.ResearchQuestion);
}
objzx_CompositionEN.ResearchQuestion = strResearchQuestion; //研究问题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.ResearchQuestion) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.ResearchQuestion, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.ResearchQuestion] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetUpdDate(this clszx_CompositionEN objzx_CompositionEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_Composition.UpdDate);
}
objzx_CompositionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.UpdDate) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.UpdDate, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.UpdDate] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetMemo(this clszx_CompositionEN objzx_CompositionEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_Composition.Memo);
}
objzx_CompositionEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.Memo) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.Memo, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.Memo] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetKeyword(this clszx_CompositionEN objzx_CompositionEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, conzx_Composition.Keyword);
}
objzx_CompositionEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.Keyword) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.Keyword, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.Keyword] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetLiteratureSources(this clszx_CompositionEN objzx_CompositionEN, string strLiteratureSources, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureSources, 1000, conzx_Composition.LiteratureSources);
}
objzx_CompositionEN.LiteratureSources = strLiteratureSources; //文献来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.LiteratureSources) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.LiteratureSources, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.LiteratureSources] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetLiteratureLink(this clszx_CompositionEN objzx_CompositionEN, string strLiteratureLink, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureLink, 1000, conzx_Composition.LiteratureLink);
}
objzx_CompositionEN.LiteratureLink = strLiteratureLink; //文献链接
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.LiteratureLink) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.LiteratureLink, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.LiteratureLink] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetUploadfileUrl(this clszx_CompositionEN objzx_CompositionEN, string strUploadfileUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadfileUrl, 1000, conzx_Composition.UploadfileUrl);
}
objzx_CompositionEN.UploadfileUrl = strUploadfileUrl; //文件地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.UploadfileUrl) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.UploadfileUrl, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.UploadfileUrl] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetIsQuotethesis(this clszx_CompositionEN objzx_CompositionEN, bool bolIsQuotethesis, string strComparisonOp="")
	{
objzx_CompositionEN.IsQuotethesis = bolIsQuotethesis; //是否引用论文
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.IsQuotethesis) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.IsQuotethesis, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.IsQuotethesis] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetQuoteId(this clszx_CompositionEN objzx_CompositionEN, string strQuoteId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuoteId, 8, conzx_Composition.QuoteId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuoteId, 8, conzx_Composition.QuoteId);
}
objzx_CompositionEN.QuoteId = strQuoteId; //引用Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.QuoteId) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.QuoteId, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.QuoteId] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetIsChecked(this clszx_CompositionEN objzx_CompositionEN, bool bolIsChecked, string strComparisonOp="")
	{
objzx_CompositionEN.IsChecked = bolIsChecked; //是否检查
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.IsChecked) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.IsChecked, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.IsChecked] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetChecker(this clszx_CompositionEN objzx_CompositionEN, string strChecker, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChecker, 20, conzx_Composition.Checker);
}
objzx_CompositionEN.Checker = strChecker; //审核人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.Checker) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.Checker, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.Checker] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetzxLiteratureTypeId(this clszx_CompositionEN objzx_CompositionEN, string strzxLiteratureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxLiteratureTypeId, conzx_Composition.zxLiteratureTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxLiteratureTypeId, 2, conzx_Composition.zxLiteratureTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxLiteratureTypeId, 2, conzx_Composition.zxLiteratureTypeId);
}
objzx_CompositionEN.zxLiteratureTypeId = strzxLiteratureTypeId; //作文类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.zxLiteratureTypeId) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.zxLiteratureTypeId, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.zxLiteratureTypeId] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetBrowseNumber(this clszx_CompositionEN objzx_CompositionEN, int? intBrowseNumber, string strComparisonOp="")
	{
objzx_CompositionEN.BrowseNumber = intBrowseNumber; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.BrowseNumber) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.BrowseNumber, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.BrowseNumber] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetIsSubmit(this clszx_CompositionEN objzx_CompositionEN, bool bolIsSubmit, string strComparisonOp="")
	{
objzx_CompositionEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.IsSubmit) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.IsSubmit, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.IsSubmit] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetAppraiseCount(this clszx_CompositionEN objzx_CompositionEN, int? intAppraiseCount, string strComparisonOp="")
	{
objzx_CompositionEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.AppraiseCount) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.AppraiseCount, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.AppraiseCount] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetAttachmentCount(this clszx_CompositionEN objzx_CompositionEN, int? intAttachmentCount, string strComparisonOp="")
	{
objzx_CompositionEN.AttachmentCount = intAttachmentCount; //附件计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.AttachmentCount) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.AttachmentCount, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.AttachmentCount] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetCollectionCount(this clszx_CompositionEN objzx_CompositionEN, long? lngCollectionCount, string strComparisonOp="")
	{
objzx_CompositionEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.CollectionCount) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.CollectionCount, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.CollectionCount] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetDownloadCount(this clszx_CompositionEN objzx_CompositionEN, int? intDownloadCount, string strComparisonOp="")
	{
objzx_CompositionEN.DownloadCount = intDownloadCount; //下载数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.DownloadCount) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.DownloadCount, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.DownloadCount] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetOkCount(this clszx_CompositionEN objzx_CompositionEN, int? intOkCount, string strComparisonOp="")
	{
objzx_CompositionEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.OkCount) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.OkCount, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.OkCount] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetPcount(this clszx_CompositionEN objzx_CompositionEN, int? intPcount, string strComparisonOp="")
	{
objzx_CompositionEN.Pcount = intPcount; //读写数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.Pcount) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.Pcount, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.Pcount] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetScore(this clszx_CompositionEN objzx_CompositionEN, float? fltScore, string strComparisonOp="")
	{
objzx_CompositionEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.Score) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.Score, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.Score] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetStuScore(this clszx_CompositionEN objzx_CompositionEN, float? fltStuScore, string strComparisonOp="")
	{
objzx_CompositionEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.StuScore) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.StuScore, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.StuScore] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetTeaScore(this clszx_CompositionEN objzx_CompositionEN, float? fltTeaScore, string strComparisonOp="")
	{
objzx_CompositionEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.TeaScore) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.TeaScore, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.TeaScore] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetIdCurrEduCls(this clszx_CompositionEN objzx_CompositionEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_Composition.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_Composition.IdCurrEduCls);
}
objzx_CompositionEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.IdCurrEduCls) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetPaperTypeId(this clszx_CompositionEN objzx_CompositionEN, string strPaperTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTypeId, 2, conzx_Composition.PaperTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperTypeId, 2, conzx_Composition.PaperTypeId);
}
objzx_CompositionEN.PaperTypeId = strPaperTypeId; //论文类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.PaperTypeId) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.PaperTypeId, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.PaperTypeId] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetzxPaperStatusId(this clszx_CompositionEN objzx_CompositionEN, string strzxPaperStatusId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxPaperStatusId, 2, conzx_Composition.zxPaperStatusId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxPaperStatusId, 2, conzx_Composition.zxPaperStatusId);
}
objzx_CompositionEN.zxPaperStatusId = strzxPaperStatusId; //论文状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.zxPaperStatusId) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.zxPaperStatusId, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.zxPaperStatusId] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetVersionCount(this clszx_CompositionEN objzx_CompositionEN, int? intVersionCount, string strComparisonOp="")
	{
objzx_CompositionEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.VersionCount) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.VersionCount, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.VersionCount] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetIsPublic(this clszx_CompositionEN objzx_CompositionEN, bool bolIsPublic, string strComparisonOp="")
	{
objzx_CompositionEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.IsPublic) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.IsPublic, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.IsPublic] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetAskQuestion(this clszx_CompositionEN objzx_CompositionEN, string strAskQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAskQuestion, 5000, conzx_Composition.AskQuestion);
}
objzx_CompositionEN.AskQuestion = strAskQuestion; //问题提出
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.AskQuestion) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.AskQuestion, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.AskQuestion] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetResearchStatus(this clszx_CompositionEN objzx_CompositionEN, string strResearchStatus, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchStatus, 5000, conzx_Composition.ResearchStatus);
}
objzx_CompositionEN.ResearchStatus = strResearchStatus; //目前研究的现状
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.ResearchStatus) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.ResearchStatus, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.ResearchStatus] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetInnovationPoints(this clszx_CompositionEN objzx_CompositionEN, string strInnovationPoints, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInnovationPoints, 5000, conzx_Composition.InnovationPoints);
}
objzx_CompositionEN.InnovationPoints = strInnovationPoints; //创新点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.InnovationPoints) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.InnovationPoints, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.InnovationPoints] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetResearchDesign(this clszx_CompositionEN objzx_CompositionEN, string strResearchDesign, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchDesign, 5000, conzx_Composition.ResearchDesign);
}
objzx_CompositionEN.ResearchDesign = strResearchDesign; //研究设计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.ResearchDesign) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.ResearchDesign, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.ResearchDesign] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetDimensionDataProcess(this clszx_CompositionEN objzx_CompositionEN, string strDimensionDataProcess, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDimensionDataProcess, 5000, conzx_Composition.DimensionDataProcess);
}
objzx_CompositionEN.DimensionDataProcess = strDimensionDataProcess; //数据处理的维度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.DimensionDataProcess) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.DimensionDataProcess, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.DimensionDataProcess] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetExpectedConclusion(this clszx_CompositionEN objzx_CompositionEN, string strExpectedConclusion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExpectedConclusion, 5000, conzx_Composition.ExpectedConclusion);
}
objzx_CompositionEN.ExpectedConclusion = strExpectedConclusion; //预期结论
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.ExpectedConclusion) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.ExpectedConclusion, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.ExpectedConclusion] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetCreateDate(this clszx_CompositionEN objzx_CompositionEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conzx_Composition.CreateDate);
}
objzx_CompositionEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.CreateDate) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.CreateDate, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.CreateDate] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetzxShareId(this clszx_CompositionEN objzx_CompositionEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, conzx_Composition.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, conzx_Composition.zxShareId);
}
objzx_CompositionEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.zxShareId) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.zxShareId, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.zxShareId] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetUpdUser(this clszx_CompositionEN objzx_CompositionEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_Composition.UpdUser);
}
objzx_CompositionEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.UpdUser) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.UpdUser, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.UpdUser] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetPaperQCount(this clszx_CompositionEN objzx_CompositionEN, int? intPaperQCount, string strComparisonOp="")
	{
objzx_CompositionEN.PaperQCount = intPaperQCount; //论文答疑数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.PaperQCount) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.PaperQCount, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.PaperQCount] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetSubVCount(this clszx_CompositionEN objzx_CompositionEN, int? intSubVCount, string strComparisonOp="")
	{
objzx_CompositionEN.SubVCount = intSubVCount; //论文子观点数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.SubVCount) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.SubVCount, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.SubVCount] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetTagsCount(this clszx_CompositionEN objzx_CompositionEN, int? intTagsCount, string strComparisonOp="")
	{
objzx_CompositionEN.TagsCount = intTagsCount; //论文标注数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.TagsCount) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.TagsCount, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.TagsCount] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetTeaQCount(this clszx_CompositionEN objzx_CompositionEN, int? intTeaQCount, string strComparisonOp="")
	{
objzx_CompositionEN.TeaQCount = intTeaQCount; //教师提问数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.TeaQCount) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.TeaQCount, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.TeaQCount] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_CompositionEN SetGroupTextId(this clszx_CompositionEN objzx_CompositionEN, string strGroupTextId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGroupTextId, conzx_Composition.GroupTextId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, conzx_Composition.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, conzx_Composition.GroupTextId);
}
objzx_CompositionEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_CompositionEN.dicFldComparisonOp.ContainsKey(conzx_Composition.GroupTextId) == false)
{
objzx_CompositionEN.dicFldComparisonOp.Add(conzx_Composition.GroupTextId, strComparisonOp);
}
else
{
objzx_CompositionEN.dicFldComparisonOp[conzx_Composition.GroupTextId] = strComparisonOp;
}
}
return objzx_CompositionEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_CompositionEN objzx_CompositionEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_CompositionEN.CheckPropertyNew();
clszx_CompositionEN objzx_CompositionCond = new clszx_CompositionEN();
string strCondition = objzx_CompositionCond
.SetzxPaperId(objzx_CompositionEN.zxPaperId, "<>")
.SetzxPaperId(objzx_CompositionEN.zxPaperId, "=")
.GetCombineCondition();
objzx_CompositionEN._IsCheckProperty = true;
bool bolIsExist = clszx_CompositionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(zxPaperId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_CompositionEN.Update();
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
 /// <param name = "objzx_Composition">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_CompositionEN objzx_Composition)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_CompositionEN objzx_CompositionCond = new clszx_CompositionEN();
string strCondition = objzx_CompositionCond
.SetzxPaperId(objzx_Composition.zxPaperId, "=")
.GetCombineCondition();
objzx_Composition._IsCheckProperty = true;
bool bolIsExist = clszx_CompositionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_Composition.zxPaperId = clszx_CompositionBL.GetFirstID_S(strCondition);
objzx_Composition.UpdateWithCondition(strCondition);
}
else
{
objzx_Composition.zxPaperId = clszx_CompositionBL.GetMaxStrId_S();
objzx_Composition.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_CompositionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_CompositionEN objzx_CompositionEN)
{
 if (string.IsNullOrEmpty(objzx_CompositionEN.zxPaperId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_CompositionBL.zx_CompositionDA.UpdateBySql2(objzx_CompositionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_CompositionBL.ReFreshCache();

if (clszx_CompositionBL.relatedActions != null)
{
clszx_CompositionBL.relatedActions.UpdRelaTabDate(objzx_CompositionEN.zxPaperId, "SetUpdDate");
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
 /// <param name = "objzx_CompositionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_CompositionEN objzx_CompositionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_CompositionEN.zxPaperId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_CompositionBL.zx_CompositionDA.UpdateBySql2(objzx_CompositionEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_CompositionBL.ReFreshCache();

if (clszx_CompositionBL.relatedActions != null)
{
clszx_CompositionBL.relatedActions.UpdRelaTabDate(objzx_CompositionEN.zxPaperId, "SetUpdDate");
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
 /// <param name = "objzx_CompositionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_CompositionEN objzx_CompositionEN, string strWhereCond)
{
try
{
bool bolResult = clszx_CompositionBL.zx_CompositionDA.UpdateBySqlWithCondition(objzx_CompositionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_CompositionBL.ReFreshCache();

if (clszx_CompositionBL.relatedActions != null)
{
clszx_CompositionBL.relatedActions.UpdRelaTabDate(objzx_CompositionEN.zxPaperId, "SetUpdDate");
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
 /// <param name = "objzx_CompositionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_CompositionEN objzx_CompositionEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_CompositionBL.zx_CompositionDA.UpdateBySqlWithConditionTransaction(objzx_CompositionEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_CompositionBL.ReFreshCache();

if (clszx_CompositionBL.relatedActions != null)
{
clszx_CompositionBL.relatedActions.UpdRelaTabDate(objzx_CompositionEN.zxPaperId, "SetUpdDate");
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
 /// <param name = "strzxPaperId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_CompositionEN objzx_CompositionEN)
{
try
{
int intRecNum = clszx_CompositionBL.zx_CompositionDA.DelRecord(objzx_CompositionEN.zxPaperId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_CompositionBL.ReFreshCache();

if (clszx_CompositionBL.relatedActions != null)
{
clszx_CompositionBL.relatedActions.UpdRelaTabDate(objzx_CompositionEN.zxPaperId, "SetUpdDate");
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
 /// <param name = "objzx_CompositionENS">源对象</param>
 /// <param name = "objzx_CompositionENT">目标对象</param>
 public static void CopyTo(this clszx_CompositionEN objzx_CompositionENS, clszx_CompositionEN objzx_CompositionENT)
{
try
{
objzx_CompositionENT.zxPaperId = objzx_CompositionENS.zxPaperId; //论文Id
objzx_CompositionENT.PaperTitle = objzx_CompositionENS.PaperTitle; //论文标题
objzx_CompositionENT.PaperName = objzx_CompositionENS.PaperName; //主题名称
objzx_CompositionENT.PaperContent = objzx_CompositionENS.PaperContent; //主题内容
objzx_CompositionENT.Periodical = objzx_CompositionENS.Periodical; //期刊
objzx_CompositionENT.Author = objzx_CompositionENS.Author; //作者
objzx_CompositionENT.ResearchQuestion = objzx_CompositionENS.ResearchQuestion; //研究问题
objzx_CompositionENT.UpdDate = objzx_CompositionENS.UpdDate; //修改日期
objzx_CompositionENT.Memo = objzx_CompositionENS.Memo; //备注
objzx_CompositionENT.Keyword = objzx_CompositionENS.Keyword; //关键字
objzx_CompositionENT.LiteratureSources = objzx_CompositionENS.LiteratureSources; //文献来源
objzx_CompositionENT.LiteratureLink = objzx_CompositionENS.LiteratureLink; //文献链接
objzx_CompositionENT.UploadfileUrl = objzx_CompositionENS.UploadfileUrl; //文件地址
objzx_CompositionENT.IsQuotethesis = objzx_CompositionENS.IsQuotethesis; //是否引用论文
objzx_CompositionENT.QuoteId = objzx_CompositionENS.QuoteId; //引用Id
objzx_CompositionENT.IsChecked = objzx_CompositionENS.IsChecked; //是否检查
objzx_CompositionENT.Checker = objzx_CompositionENS.Checker; //审核人
objzx_CompositionENT.zxLiteratureTypeId = objzx_CompositionENS.zxLiteratureTypeId; //作文类型Id
objzx_CompositionENT.BrowseNumber = objzx_CompositionENS.BrowseNumber; //浏览量
objzx_CompositionENT.IsSubmit = objzx_CompositionENS.IsSubmit; //是否提交
objzx_CompositionENT.AppraiseCount = objzx_CompositionENS.AppraiseCount; //评论数
objzx_CompositionENT.AttachmentCount = objzx_CompositionENS.AttachmentCount; //附件计数
objzx_CompositionENT.CollectionCount = objzx_CompositionENS.CollectionCount; //收藏数量
objzx_CompositionENT.DownloadCount = objzx_CompositionENS.DownloadCount; //下载数
objzx_CompositionENT.OkCount = objzx_CompositionENS.OkCount; //点赞统计
objzx_CompositionENT.Pcount = objzx_CompositionENS.Pcount; //读写数
objzx_CompositionENT.Score = objzx_CompositionENS.Score; //评分
objzx_CompositionENT.StuScore = objzx_CompositionENS.StuScore; //学生平均分
objzx_CompositionENT.TeaScore = objzx_CompositionENS.TeaScore; //教师评分
objzx_CompositionENT.IdCurrEduCls = objzx_CompositionENS.IdCurrEduCls; //教学班流水号
objzx_CompositionENT.PaperTypeId = objzx_CompositionENS.PaperTypeId; //论文类型Id
objzx_CompositionENT.zxPaperStatusId = objzx_CompositionENS.zxPaperStatusId; //论文状态Id
objzx_CompositionENT.VersionCount = objzx_CompositionENS.VersionCount; //版本统计
objzx_CompositionENT.IsPublic = objzx_CompositionENS.IsPublic; //是否公开
objzx_CompositionENT.AskQuestion = objzx_CompositionENS.AskQuestion; //问题提出
objzx_CompositionENT.ResearchStatus = objzx_CompositionENS.ResearchStatus; //目前研究的现状
objzx_CompositionENT.InnovationPoints = objzx_CompositionENS.InnovationPoints; //创新点
objzx_CompositionENT.ResearchDesign = objzx_CompositionENS.ResearchDesign; //研究设计
objzx_CompositionENT.DimensionDataProcess = objzx_CompositionENS.DimensionDataProcess; //数据处理的维度
objzx_CompositionENT.ExpectedConclusion = objzx_CompositionENS.ExpectedConclusion; //预期结论
objzx_CompositionENT.CreateDate = objzx_CompositionENS.CreateDate; //建立日期
objzx_CompositionENT.zxShareId = objzx_CompositionENS.zxShareId; //分享Id
objzx_CompositionENT.UpdUser = objzx_CompositionENS.UpdUser; //修改人
objzx_CompositionENT.PaperQCount = objzx_CompositionENS.PaperQCount; //论文答疑数
objzx_CompositionENT.SubVCount = objzx_CompositionENS.SubVCount; //论文子观点数
objzx_CompositionENT.TagsCount = objzx_CompositionENS.TagsCount; //论文标注数
objzx_CompositionENT.TeaQCount = objzx_CompositionENS.TeaQCount; //教师提问数
objzx_CompositionENT.GroupTextId = objzx_CompositionENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_CompositionENS">源对象</param>
 /// <returns>目标对象=>clszx_CompositionEN:objzx_CompositionENT</returns>
 public static clszx_CompositionEN CopyTo(this clszx_CompositionEN objzx_CompositionENS)
{
try
{
 clszx_CompositionEN objzx_CompositionENT = new clszx_CompositionEN()
{
zxPaperId = objzx_CompositionENS.zxPaperId, //论文Id
PaperTitle = objzx_CompositionENS.PaperTitle, //论文标题
PaperName = objzx_CompositionENS.PaperName, //主题名称
PaperContent = objzx_CompositionENS.PaperContent, //主题内容
Periodical = objzx_CompositionENS.Periodical, //期刊
Author = objzx_CompositionENS.Author, //作者
ResearchQuestion = objzx_CompositionENS.ResearchQuestion, //研究问题
UpdDate = objzx_CompositionENS.UpdDate, //修改日期
Memo = objzx_CompositionENS.Memo, //备注
Keyword = objzx_CompositionENS.Keyword, //关键字
LiteratureSources = objzx_CompositionENS.LiteratureSources, //文献来源
LiteratureLink = objzx_CompositionENS.LiteratureLink, //文献链接
UploadfileUrl = objzx_CompositionENS.UploadfileUrl, //文件地址
IsQuotethesis = objzx_CompositionENS.IsQuotethesis, //是否引用论文
QuoteId = objzx_CompositionENS.QuoteId, //引用Id
IsChecked = objzx_CompositionENS.IsChecked, //是否检查
Checker = objzx_CompositionENS.Checker, //审核人
zxLiteratureTypeId = objzx_CompositionENS.zxLiteratureTypeId, //作文类型Id
BrowseNumber = objzx_CompositionENS.BrowseNumber, //浏览量
IsSubmit = objzx_CompositionENS.IsSubmit, //是否提交
AppraiseCount = objzx_CompositionENS.AppraiseCount, //评论数
AttachmentCount = objzx_CompositionENS.AttachmentCount, //附件计数
CollectionCount = objzx_CompositionENS.CollectionCount, //收藏数量
DownloadCount = objzx_CompositionENS.DownloadCount, //下载数
OkCount = objzx_CompositionENS.OkCount, //点赞统计
Pcount = objzx_CompositionENS.Pcount, //读写数
Score = objzx_CompositionENS.Score, //评分
StuScore = objzx_CompositionENS.StuScore, //学生平均分
TeaScore = objzx_CompositionENS.TeaScore, //教师评分
IdCurrEduCls = objzx_CompositionENS.IdCurrEduCls, //教学班流水号
PaperTypeId = objzx_CompositionENS.PaperTypeId, //论文类型Id
zxPaperStatusId = objzx_CompositionENS.zxPaperStatusId, //论文状态Id
VersionCount = objzx_CompositionENS.VersionCount, //版本统计
IsPublic = objzx_CompositionENS.IsPublic, //是否公开
AskQuestion = objzx_CompositionENS.AskQuestion, //问题提出
ResearchStatus = objzx_CompositionENS.ResearchStatus, //目前研究的现状
InnovationPoints = objzx_CompositionENS.InnovationPoints, //创新点
ResearchDesign = objzx_CompositionENS.ResearchDesign, //研究设计
DimensionDataProcess = objzx_CompositionENS.DimensionDataProcess, //数据处理的维度
ExpectedConclusion = objzx_CompositionENS.ExpectedConclusion, //预期结论
CreateDate = objzx_CompositionENS.CreateDate, //建立日期
zxShareId = objzx_CompositionENS.zxShareId, //分享Id
UpdUser = objzx_CompositionENS.UpdUser, //修改人
PaperQCount = objzx_CompositionENS.PaperQCount, //论文答疑数
SubVCount = objzx_CompositionENS.SubVCount, //论文子观点数
TagsCount = objzx_CompositionENS.TagsCount, //论文标注数
TeaQCount = objzx_CompositionENS.TeaQCount, //教师提问数
GroupTextId = objzx_CompositionENS.GroupTextId, //小组Id
};
 return objzx_CompositionENT;
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
public static void CheckPropertyNew(this clszx_CompositionEN objzx_CompositionEN)
{
 clszx_CompositionBL.zx_CompositionDA.CheckPropertyNew(objzx_CompositionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_CompositionEN objzx_CompositionEN)
{
 clszx_CompositionBL.zx_CompositionDA.CheckProperty4Condition(objzx_CompositionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_CompositionEN objzx_CompositionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_CompositionCond.IsUpdated(conzx_Composition.zxPaperId) == true)
{
string strComparisonOpzxPaperId = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.zxPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.zxPaperId, objzx_CompositionCond.zxPaperId, strComparisonOpzxPaperId);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.PaperTitle, objzx_CompositionCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.PaperName) == true)
{
string strComparisonOpPaperName = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.PaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.PaperName, objzx_CompositionCond.PaperName, strComparisonOpPaperName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objzx_CompositionCond.IsUpdated(conzx_Composition.Periodical) == true)
{
string strComparisonOpPeriodical = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.Periodical];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.Periodical, objzx_CompositionCond.Periodical, strComparisonOpPeriodical);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.Author) == true)
{
string strComparisonOpAuthor = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.Author, objzx_CompositionCond.Author, strComparisonOpAuthor);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.ResearchQuestion) == true)
{
string strComparisonOpResearchQuestion = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.ResearchQuestion, objzx_CompositionCond.ResearchQuestion, strComparisonOpResearchQuestion);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.UpdDate, objzx_CompositionCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.Memo) == true)
{
string strComparisonOpMemo = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.Memo, objzx_CompositionCond.Memo, strComparisonOpMemo);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.Keyword) == true)
{
string strComparisonOpKeyword = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.Keyword, objzx_CompositionCond.Keyword, strComparisonOpKeyword);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.LiteratureSources) == true)
{
string strComparisonOpLiteratureSources = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.LiteratureSources];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.LiteratureSources, objzx_CompositionCond.LiteratureSources, strComparisonOpLiteratureSources);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.LiteratureLink) == true)
{
string strComparisonOpLiteratureLink = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.LiteratureLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.LiteratureLink, objzx_CompositionCond.LiteratureLink, strComparisonOpLiteratureLink);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.UploadfileUrl) == true)
{
string strComparisonOpUploadfileUrl = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.UploadfileUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.UploadfileUrl, objzx_CompositionCond.UploadfileUrl, strComparisonOpUploadfileUrl);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.IsQuotethesis) == true)
{
if (objzx_CompositionCond.IsQuotethesis == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_Composition.IsQuotethesis);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_Composition.IsQuotethesis);
}
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.QuoteId) == true)
{
string strComparisonOpQuoteId = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.QuoteId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.QuoteId, objzx_CompositionCond.QuoteId, strComparisonOpQuoteId);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.IsChecked) == true)
{
if (objzx_CompositionCond.IsChecked == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_Composition.IsChecked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_Composition.IsChecked);
}
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.Checker) == true)
{
string strComparisonOpChecker = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.Checker];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.Checker, objzx_CompositionCond.Checker, strComparisonOpChecker);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.zxLiteratureTypeId) == true)
{
string strComparisonOpzxLiteratureTypeId = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.zxLiteratureTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.zxLiteratureTypeId, objzx_CompositionCond.zxLiteratureTypeId, strComparisonOpzxLiteratureTypeId);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.BrowseNumber) == true)
{
string strComparisonOpBrowseNumber = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.BrowseNumber];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Composition.BrowseNumber, objzx_CompositionCond.BrowseNumber, strComparisonOpBrowseNumber);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.IsSubmit) == true)
{
if (objzx_CompositionCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_Composition.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_Composition.IsSubmit);
}
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Composition.AppraiseCount, objzx_CompositionCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.AttachmentCount) == true)
{
string strComparisonOpAttachmentCount = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.AttachmentCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Composition.AttachmentCount, objzx_CompositionCond.AttachmentCount, strComparisonOpAttachmentCount);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Composition.CollectionCount, objzx_CompositionCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.DownloadCount) == true)
{
string strComparisonOpDownloadCount = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.DownloadCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Composition.DownloadCount, objzx_CompositionCond.DownloadCount, strComparisonOpDownloadCount);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.OkCount) == true)
{
string strComparisonOpOkCount = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Composition.OkCount, objzx_CompositionCond.OkCount, strComparisonOpOkCount);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.Pcount) == true)
{
string strComparisonOpPcount = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.Pcount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Composition.Pcount, objzx_CompositionCond.Pcount, strComparisonOpPcount);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.Score) == true)
{
string strComparisonOpScore = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Composition.Score, objzx_CompositionCond.Score, strComparisonOpScore);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.StuScore) == true)
{
string strComparisonOpStuScore = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Composition.StuScore, objzx_CompositionCond.StuScore, strComparisonOpStuScore);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.TeaScore) == true)
{
string strComparisonOpTeaScore = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Composition.TeaScore, objzx_CompositionCond.TeaScore, strComparisonOpTeaScore);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.IdCurrEduCls, objzx_CompositionCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.PaperTypeId) == true)
{
string strComparisonOpPaperTypeId = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.PaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.PaperTypeId, objzx_CompositionCond.PaperTypeId, strComparisonOpPaperTypeId);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.zxPaperStatusId) == true)
{
string strComparisonOpzxPaperStatusId = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.zxPaperStatusId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.zxPaperStatusId, objzx_CompositionCond.zxPaperStatusId, strComparisonOpzxPaperStatusId);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.VersionCount) == true)
{
string strComparisonOpVersionCount = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Composition.VersionCount, objzx_CompositionCond.VersionCount, strComparisonOpVersionCount);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.IsPublic) == true)
{
if (objzx_CompositionCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_Composition.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_Composition.IsPublic);
}
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.AskQuestion) == true)
{
string strComparisonOpAskQuestion = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.AskQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.AskQuestion, objzx_CompositionCond.AskQuestion, strComparisonOpAskQuestion);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.ResearchStatus) == true)
{
string strComparisonOpResearchStatus = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.ResearchStatus];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.ResearchStatus, objzx_CompositionCond.ResearchStatus, strComparisonOpResearchStatus);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.InnovationPoints) == true)
{
string strComparisonOpInnovationPoints = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.InnovationPoints];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.InnovationPoints, objzx_CompositionCond.InnovationPoints, strComparisonOpInnovationPoints);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.ResearchDesign) == true)
{
string strComparisonOpResearchDesign = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.ResearchDesign];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.ResearchDesign, objzx_CompositionCond.ResearchDesign, strComparisonOpResearchDesign);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.DimensionDataProcess) == true)
{
string strComparisonOpDimensionDataProcess = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.DimensionDataProcess];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.DimensionDataProcess, objzx_CompositionCond.DimensionDataProcess, strComparisonOpDimensionDataProcess);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.ExpectedConclusion) == true)
{
string strComparisonOpExpectedConclusion = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.ExpectedConclusion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.ExpectedConclusion, objzx_CompositionCond.ExpectedConclusion, strComparisonOpExpectedConclusion);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.CreateDate) == true)
{
string strComparisonOpCreateDate = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.CreateDate, objzx_CompositionCond.CreateDate, strComparisonOpCreateDate);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.zxShareId) == true)
{
string strComparisonOpzxShareId = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.zxShareId, objzx_CompositionCond.zxShareId, strComparisonOpzxShareId);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.UpdUser, objzx_CompositionCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.PaperQCount) == true)
{
string strComparisonOpPaperQCount = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.PaperQCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Composition.PaperQCount, objzx_CompositionCond.PaperQCount, strComparisonOpPaperQCount);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.SubVCount) == true)
{
string strComparisonOpSubVCount = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.SubVCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Composition.SubVCount, objzx_CompositionCond.SubVCount, strComparisonOpSubVCount);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.TagsCount) == true)
{
string strComparisonOpTagsCount = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.TagsCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Composition.TagsCount, objzx_CompositionCond.TagsCount, strComparisonOpTagsCount);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.TeaQCount) == true)
{
string strComparisonOpTeaQCount = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.TeaQCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Composition.TeaQCount, objzx_CompositionCond.TeaQCount, strComparisonOpTeaQCount);
}
if (objzx_CompositionCond.IsUpdated(conzx_Composition.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objzx_CompositionCond.dicFldComparisonOp[conzx_Composition.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Composition.GroupTextId, objzx_CompositionCond.GroupTextId, strComparisonOpGroupTextId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_Composition(作文表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:zxPaperId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_CompositionEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_CompositionEN objzx_CompositionEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_CompositionEN == null) return true;
if (objzx_CompositionEN.zxPaperId == null || objzx_CompositionEN.zxPaperId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxPaperId = '{0}'", objzx_CompositionEN.zxPaperId);
if (clszx_CompositionBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("zxPaperId !=  '{0}'", objzx_CompositionEN.zxPaperId);
 sbCondition.AppendFormat(" and zxPaperId = '{0}'", objzx_CompositionEN.zxPaperId);
if (clszx_CompositionBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_Composition(作文表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:zxPaperId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_CompositionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_CompositionEN objzx_CompositionEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_CompositionEN == null) return "";
if (objzx_CompositionEN.zxPaperId == null || objzx_CompositionEN.zxPaperId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxPaperId = '{0}'", objzx_CompositionEN.zxPaperId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("zxPaperId !=  '{0}'", objzx_CompositionEN.zxPaperId);
 sbCondition.AppendFormat(" and zxPaperId = '{0}'", objzx_CompositionEN.zxPaperId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_Composition
{
public virtual bool UpdRelaTabDate(string strzxPaperId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 作文表(zx_Composition)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_CompositionBL
{
public static RelatedActions_zx_Composition relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_CompositionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_CompositionDA zx_CompositionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_CompositionDA();
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
 public clszx_CompositionBL()
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
if (string.IsNullOrEmpty(clszx_CompositionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_CompositionEN._ConnectString);
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
public static DataTable GetDataTable_zx_Composition(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_CompositionDA.GetDataTable_zx_Composition(strWhereCond);
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
objDT = zx_CompositionDA.GetDataTable(strWhereCond);
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
objDT = zx_CompositionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_CompositionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_CompositionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_CompositionDA.GetDataTable_Top(objTopPara);
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
objDT = zx_CompositionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_CompositionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_CompositionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_CompositionEN> GetObjLstByZxPaperIdLst(List<string> arrZxPaperIdLst)
{
List<clszx_CompositionEN> arrObjLst = new List<clszx_CompositionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxPaperIdLst, true);
 string strWhereCond = string.Format("zxPaperId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_CompositionEN objzx_CompositionEN = new clszx_CompositionEN();
try
{
objzx_CompositionEN.zxPaperId = objRow[conzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objzx_CompositionEN.PaperTitle = objRow[conzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objzx_CompositionEN.PaperName = objRow[conzx_Composition.PaperName] == DBNull.Value ? null : objRow[conzx_Composition.PaperName].ToString().Trim(); //主题名称
objzx_CompositionEN.PaperContent = objRow[conzx_Composition.PaperContent] == DBNull.Value ? null : objRow[conzx_Composition.PaperContent].ToString().Trim(); //主题内容
objzx_CompositionEN.Periodical = objRow[conzx_Composition.Periodical] == DBNull.Value ? null : objRow[conzx_Composition.Periodical].ToString().Trim(); //期刊
objzx_CompositionEN.Author = objRow[conzx_Composition.Author] == DBNull.Value ? null : objRow[conzx_Composition.Author].ToString().Trim(); //作者
objzx_CompositionEN.ResearchQuestion = objRow[conzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objzx_CompositionEN.UpdDate = objRow[conzx_Composition.UpdDate] == DBNull.Value ? null : objRow[conzx_Composition.UpdDate].ToString().Trim(); //修改日期
objzx_CompositionEN.Memo = objRow[conzx_Composition.Memo] == DBNull.Value ? null : objRow[conzx_Composition.Memo].ToString().Trim(); //备注
objzx_CompositionEN.Keyword = objRow[conzx_Composition.Keyword] == DBNull.Value ? null : objRow[conzx_Composition.Keyword].ToString().Trim(); //关键字
objzx_CompositionEN.LiteratureSources = objRow[conzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objzx_CompositionEN.LiteratureLink = objRow[conzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objzx_CompositionEN.UploadfileUrl = objRow[conzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objzx_CompositionEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objzx_CompositionEN.QuoteId = objRow[conzx_Composition.QuoteId] == DBNull.Value ? null : objRow[conzx_Composition.QuoteId].ToString().Trim(); //引用Id
objzx_CompositionEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsChecked].ToString().Trim()); //是否检查
objzx_CompositionEN.Checker = objRow[conzx_Composition.Checker] == DBNull.Value ? null : objRow[conzx_Composition.Checker].ToString().Trim(); //审核人
objzx_CompositionEN.zxLiteratureTypeId = objRow[conzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objzx_CompositionEN.BrowseNumber = objRow[conzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objzx_CompositionEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objzx_CompositionEN.AppraiseCount = objRow[conzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objzx_CompositionEN.AttachmentCount = objRow[conzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objzx_CompositionEN.CollectionCount = objRow[conzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objzx_CompositionEN.DownloadCount = objRow[conzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.DownloadCount].ToString().Trim()); //下载数
objzx_CompositionEN.OkCount = objRow[conzx_Composition.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.OkCount].ToString().Trim()); //点赞统计
objzx_CompositionEN.Pcount = objRow[conzx_Composition.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.Pcount].ToString().Trim()); //读写数
objzx_CompositionEN.Score = objRow[conzx_Composition.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.Score].ToString().Trim()); //评分
objzx_CompositionEN.StuScore = objRow[conzx_Composition.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.StuScore].ToString().Trim()); //学生平均分
objzx_CompositionEN.TeaScore = objRow[conzx_Composition.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.TeaScore].ToString().Trim()); //教师评分
objzx_CompositionEN.IdCurrEduCls = objRow[conzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_CompositionEN.PaperTypeId = objRow[conzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[conzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objzx_CompositionEN.zxPaperStatusId = objRow[conzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[conzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objzx_CompositionEN.VersionCount = objRow[conzx_Composition.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.VersionCount].ToString().Trim()); //版本统计
objzx_CompositionEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsPublic].ToString().Trim()); //是否公开
objzx_CompositionEN.AskQuestion = objRow[conzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[conzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objzx_CompositionEN.ResearchStatus = objRow[conzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[conzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objzx_CompositionEN.InnovationPoints = objRow[conzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[conzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objzx_CompositionEN.ResearchDesign = objRow[conzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[conzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objzx_CompositionEN.DimensionDataProcess = objRow[conzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[conzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objzx_CompositionEN.ExpectedConclusion = objRow[conzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[conzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objzx_CompositionEN.CreateDate = objRow[conzx_Composition.CreateDate] == DBNull.Value ? null : objRow[conzx_Composition.CreateDate].ToString().Trim(); //建立日期
objzx_CompositionEN.zxShareId = objRow[conzx_Composition.zxShareId] == DBNull.Value ? null : objRow[conzx_Composition.zxShareId].ToString().Trim(); //分享Id
objzx_CompositionEN.UpdUser = objRow[conzx_Composition.UpdUser] == DBNull.Value ? null : objRow[conzx_Composition.UpdUser].ToString().Trim(); //修改人
objzx_CompositionEN.PaperQCount = objRow[conzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objzx_CompositionEN.SubVCount = objRow[conzx_Composition.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objzx_CompositionEN.TagsCount = objRow[conzx_Composition.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objzx_CompositionEN.TeaQCount = objRow[conzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objzx_CompositionEN.GroupTextId = objRow[conzx_Composition.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_CompositionEN.zxPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_CompositionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_CompositionEN> GetObjLstByZxPaperIdLstCache(List<string> arrZxPaperIdLst)
{
string strKey = string.Format("{0}", clszx_CompositionEN._CurrTabName);
List<clszx_CompositionEN> arrzx_CompositionObjLstCache = GetObjLstCache();
IEnumerable <clszx_CompositionEN> arrzx_CompositionObjLst_Sel =
arrzx_CompositionObjLstCache
.Where(x => arrZxPaperIdLst.Contains(x.zxPaperId));
return arrzx_CompositionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_CompositionEN> GetObjLst(string strWhereCond)
{
List<clszx_CompositionEN> arrObjLst = new List<clszx_CompositionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_CompositionEN objzx_CompositionEN = new clszx_CompositionEN();
try
{
objzx_CompositionEN.zxPaperId = objRow[conzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objzx_CompositionEN.PaperTitle = objRow[conzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objzx_CompositionEN.PaperName = objRow[conzx_Composition.PaperName] == DBNull.Value ? null : objRow[conzx_Composition.PaperName].ToString().Trim(); //主题名称
objzx_CompositionEN.PaperContent = objRow[conzx_Composition.PaperContent] == DBNull.Value ? null : objRow[conzx_Composition.PaperContent].ToString().Trim(); //主题内容
objzx_CompositionEN.Periodical = objRow[conzx_Composition.Periodical] == DBNull.Value ? null : objRow[conzx_Composition.Periodical].ToString().Trim(); //期刊
objzx_CompositionEN.Author = objRow[conzx_Composition.Author] == DBNull.Value ? null : objRow[conzx_Composition.Author].ToString().Trim(); //作者
objzx_CompositionEN.ResearchQuestion = objRow[conzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objzx_CompositionEN.UpdDate = objRow[conzx_Composition.UpdDate] == DBNull.Value ? null : objRow[conzx_Composition.UpdDate].ToString().Trim(); //修改日期
objzx_CompositionEN.Memo = objRow[conzx_Composition.Memo] == DBNull.Value ? null : objRow[conzx_Composition.Memo].ToString().Trim(); //备注
objzx_CompositionEN.Keyword = objRow[conzx_Composition.Keyword] == DBNull.Value ? null : objRow[conzx_Composition.Keyword].ToString().Trim(); //关键字
objzx_CompositionEN.LiteratureSources = objRow[conzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objzx_CompositionEN.LiteratureLink = objRow[conzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objzx_CompositionEN.UploadfileUrl = objRow[conzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objzx_CompositionEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objzx_CompositionEN.QuoteId = objRow[conzx_Composition.QuoteId] == DBNull.Value ? null : objRow[conzx_Composition.QuoteId].ToString().Trim(); //引用Id
objzx_CompositionEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsChecked].ToString().Trim()); //是否检查
objzx_CompositionEN.Checker = objRow[conzx_Composition.Checker] == DBNull.Value ? null : objRow[conzx_Composition.Checker].ToString().Trim(); //审核人
objzx_CompositionEN.zxLiteratureTypeId = objRow[conzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objzx_CompositionEN.BrowseNumber = objRow[conzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objzx_CompositionEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objzx_CompositionEN.AppraiseCount = objRow[conzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objzx_CompositionEN.AttachmentCount = objRow[conzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objzx_CompositionEN.CollectionCount = objRow[conzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objzx_CompositionEN.DownloadCount = objRow[conzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.DownloadCount].ToString().Trim()); //下载数
objzx_CompositionEN.OkCount = objRow[conzx_Composition.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.OkCount].ToString().Trim()); //点赞统计
objzx_CompositionEN.Pcount = objRow[conzx_Composition.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.Pcount].ToString().Trim()); //读写数
objzx_CompositionEN.Score = objRow[conzx_Composition.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.Score].ToString().Trim()); //评分
objzx_CompositionEN.StuScore = objRow[conzx_Composition.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.StuScore].ToString().Trim()); //学生平均分
objzx_CompositionEN.TeaScore = objRow[conzx_Composition.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.TeaScore].ToString().Trim()); //教师评分
objzx_CompositionEN.IdCurrEduCls = objRow[conzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_CompositionEN.PaperTypeId = objRow[conzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[conzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objzx_CompositionEN.zxPaperStatusId = objRow[conzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[conzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objzx_CompositionEN.VersionCount = objRow[conzx_Composition.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.VersionCount].ToString().Trim()); //版本统计
objzx_CompositionEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsPublic].ToString().Trim()); //是否公开
objzx_CompositionEN.AskQuestion = objRow[conzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[conzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objzx_CompositionEN.ResearchStatus = objRow[conzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[conzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objzx_CompositionEN.InnovationPoints = objRow[conzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[conzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objzx_CompositionEN.ResearchDesign = objRow[conzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[conzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objzx_CompositionEN.DimensionDataProcess = objRow[conzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[conzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objzx_CompositionEN.ExpectedConclusion = objRow[conzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[conzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objzx_CompositionEN.CreateDate = objRow[conzx_Composition.CreateDate] == DBNull.Value ? null : objRow[conzx_Composition.CreateDate].ToString().Trim(); //建立日期
objzx_CompositionEN.zxShareId = objRow[conzx_Composition.zxShareId] == DBNull.Value ? null : objRow[conzx_Composition.zxShareId].ToString().Trim(); //分享Id
objzx_CompositionEN.UpdUser = objRow[conzx_Composition.UpdUser] == DBNull.Value ? null : objRow[conzx_Composition.UpdUser].ToString().Trim(); //修改人
objzx_CompositionEN.PaperQCount = objRow[conzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objzx_CompositionEN.SubVCount = objRow[conzx_Composition.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objzx_CompositionEN.TagsCount = objRow[conzx_Composition.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objzx_CompositionEN.TeaQCount = objRow[conzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objzx_CompositionEN.GroupTextId = objRow[conzx_Composition.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_CompositionEN.zxPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_CompositionEN);
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
public static List<clszx_CompositionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_CompositionEN> arrObjLst = new List<clszx_CompositionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_CompositionEN objzx_CompositionEN = new clszx_CompositionEN();
try
{
objzx_CompositionEN.zxPaperId = objRow[conzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objzx_CompositionEN.PaperTitle = objRow[conzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objzx_CompositionEN.PaperName = objRow[conzx_Composition.PaperName] == DBNull.Value ? null : objRow[conzx_Composition.PaperName].ToString().Trim(); //主题名称
objzx_CompositionEN.PaperContent = objRow[conzx_Composition.PaperContent] == DBNull.Value ? null : objRow[conzx_Composition.PaperContent].ToString().Trim(); //主题内容
objzx_CompositionEN.Periodical = objRow[conzx_Composition.Periodical] == DBNull.Value ? null : objRow[conzx_Composition.Periodical].ToString().Trim(); //期刊
objzx_CompositionEN.Author = objRow[conzx_Composition.Author] == DBNull.Value ? null : objRow[conzx_Composition.Author].ToString().Trim(); //作者
objzx_CompositionEN.ResearchQuestion = objRow[conzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objzx_CompositionEN.UpdDate = objRow[conzx_Composition.UpdDate] == DBNull.Value ? null : objRow[conzx_Composition.UpdDate].ToString().Trim(); //修改日期
objzx_CompositionEN.Memo = objRow[conzx_Composition.Memo] == DBNull.Value ? null : objRow[conzx_Composition.Memo].ToString().Trim(); //备注
objzx_CompositionEN.Keyword = objRow[conzx_Composition.Keyword] == DBNull.Value ? null : objRow[conzx_Composition.Keyword].ToString().Trim(); //关键字
objzx_CompositionEN.LiteratureSources = objRow[conzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objzx_CompositionEN.LiteratureLink = objRow[conzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objzx_CompositionEN.UploadfileUrl = objRow[conzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objzx_CompositionEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objzx_CompositionEN.QuoteId = objRow[conzx_Composition.QuoteId] == DBNull.Value ? null : objRow[conzx_Composition.QuoteId].ToString().Trim(); //引用Id
objzx_CompositionEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsChecked].ToString().Trim()); //是否检查
objzx_CompositionEN.Checker = objRow[conzx_Composition.Checker] == DBNull.Value ? null : objRow[conzx_Composition.Checker].ToString().Trim(); //审核人
objzx_CompositionEN.zxLiteratureTypeId = objRow[conzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objzx_CompositionEN.BrowseNumber = objRow[conzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objzx_CompositionEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objzx_CompositionEN.AppraiseCount = objRow[conzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objzx_CompositionEN.AttachmentCount = objRow[conzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objzx_CompositionEN.CollectionCount = objRow[conzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objzx_CompositionEN.DownloadCount = objRow[conzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.DownloadCount].ToString().Trim()); //下载数
objzx_CompositionEN.OkCount = objRow[conzx_Composition.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.OkCount].ToString().Trim()); //点赞统计
objzx_CompositionEN.Pcount = objRow[conzx_Composition.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.Pcount].ToString().Trim()); //读写数
objzx_CompositionEN.Score = objRow[conzx_Composition.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.Score].ToString().Trim()); //评分
objzx_CompositionEN.StuScore = objRow[conzx_Composition.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.StuScore].ToString().Trim()); //学生平均分
objzx_CompositionEN.TeaScore = objRow[conzx_Composition.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.TeaScore].ToString().Trim()); //教师评分
objzx_CompositionEN.IdCurrEduCls = objRow[conzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_CompositionEN.PaperTypeId = objRow[conzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[conzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objzx_CompositionEN.zxPaperStatusId = objRow[conzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[conzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objzx_CompositionEN.VersionCount = objRow[conzx_Composition.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.VersionCount].ToString().Trim()); //版本统计
objzx_CompositionEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsPublic].ToString().Trim()); //是否公开
objzx_CompositionEN.AskQuestion = objRow[conzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[conzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objzx_CompositionEN.ResearchStatus = objRow[conzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[conzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objzx_CompositionEN.InnovationPoints = objRow[conzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[conzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objzx_CompositionEN.ResearchDesign = objRow[conzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[conzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objzx_CompositionEN.DimensionDataProcess = objRow[conzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[conzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objzx_CompositionEN.ExpectedConclusion = objRow[conzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[conzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objzx_CompositionEN.CreateDate = objRow[conzx_Composition.CreateDate] == DBNull.Value ? null : objRow[conzx_Composition.CreateDate].ToString().Trim(); //建立日期
objzx_CompositionEN.zxShareId = objRow[conzx_Composition.zxShareId] == DBNull.Value ? null : objRow[conzx_Composition.zxShareId].ToString().Trim(); //分享Id
objzx_CompositionEN.UpdUser = objRow[conzx_Composition.UpdUser] == DBNull.Value ? null : objRow[conzx_Composition.UpdUser].ToString().Trim(); //修改人
objzx_CompositionEN.PaperQCount = objRow[conzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objzx_CompositionEN.SubVCount = objRow[conzx_Composition.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objzx_CompositionEN.TagsCount = objRow[conzx_Composition.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objzx_CompositionEN.TeaQCount = objRow[conzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objzx_CompositionEN.GroupTextId = objRow[conzx_Composition.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_CompositionEN.zxPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_CompositionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_CompositionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_CompositionEN> GetSubObjLstCache(clszx_CompositionEN objzx_CompositionCond)
{
List<clszx_CompositionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_CompositionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_Composition.AttributeName)
{
if (objzx_CompositionCond.IsUpdated(strFldName) == false) continue;
if (objzx_CompositionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_CompositionCond[strFldName].ToString());
}
else
{
if (objzx_CompositionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_CompositionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_CompositionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_CompositionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_CompositionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_CompositionCond[strFldName]));
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
public static List<clszx_CompositionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_CompositionEN> arrObjLst = new List<clszx_CompositionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_CompositionEN objzx_CompositionEN = new clszx_CompositionEN();
try
{
objzx_CompositionEN.zxPaperId = objRow[conzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objzx_CompositionEN.PaperTitle = objRow[conzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objzx_CompositionEN.PaperName = objRow[conzx_Composition.PaperName] == DBNull.Value ? null : objRow[conzx_Composition.PaperName].ToString().Trim(); //主题名称
objzx_CompositionEN.PaperContent = objRow[conzx_Composition.PaperContent] == DBNull.Value ? null : objRow[conzx_Composition.PaperContent].ToString().Trim(); //主题内容
objzx_CompositionEN.Periodical = objRow[conzx_Composition.Periodical] == DBNull.Value ? null : objRow[conzx_Composition.Periodical].ToString().Trim(); //期刊
objzx_CompositionEN.Author = objRow[conzx_Composition.Author] == DBNull.Value ? null : objRow[conzx_Composition.Author].ToString().Trim(); //作者
objzx_CompositionEN.ResearchQuestion = objRow[conzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objzx_CompositionEN.UpdDate = objRow[conzx_Composition.UpdDate] == DBNull.Value ? null : objRow[conzx_Composition.UpdDate].ToString().Trim(); //修改日期
objzx_CompositionEN.Memo = objRow[conzx_Composition.Memo] == DBNull.Value ? null : objRow[conzx_Composition.Memo].ToString().Trim(); //备注
objzx_CompositionEN.Keyword = objRow[conzx_Composition.Keyword] == DBNull.Value ? null : objRow[conzx_Composition.Keyword].ToString().Trim(); //关键字
objzx_CompositionEN.LiteratureSources = objRow[conzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objzx_CompositionEN.LiteratureLink = objRow[conzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objzx_CompositionEN.UploadfileUrl = objRow[conzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objzx_CompositionEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objzx_CompositionEN.QuoteId = objRow[conzx_Composition.QuoteId] == DBNull.Value ? null : objRow[conzx_Composition.QuoteId].ToString().Trim(); //引用Id
objzx_CompositionEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsChecked].ToString().Trim()); //是否检查
objzx_CompositionEN.Checker = objRow[conzx_Composition.Checker] == DBNull.Value ? null : objRow[conzx_Composition.Checker].ToString().Trim(); //审核人
objzx_CompositionEN.zxLiteratureTypeId = objRow[conzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objzx_CompositionEN.BrowseNumber = objRow[conzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objzx_CompositionEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objzx_CompositionEN.AppraiseCount = objRow[conzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objzx_CompositionEN.AttachmentCount = objRow[conzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objzx_CompositionEN.CollectionCount = objRow[conzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objzx_CompositionEN.DownloadCount = objRow[conzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.DownloadCount].ToString().Trim()); //下载数
objzx_CompositionEN.OkCount = objRow[conzx_Composition.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.OkCount].ToString().Trim()); //点赞统计
objzx_CompositionEN.Pcount = objRow[conzx_Composition.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.Pcount].ToString().Trim()); //读写数
objzx_CompositionEN.Score = objRow[conzx_Composition.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.Score].ToString().Trim()); //评分
objzx_CompositionEN.StuScore = objRow[conzx_Composition.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.StuScore].ToString().Trim()); //学生平均分
objzx_CompositionEN.TeaScore = objRow[conzx_Composition.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.TeaScore].ToString().Trim()); //教师评分
objzx_CompositionEN.IdCurrEduCls = objRow[conzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_CompositionEN.PaperTypeId = objRow[conzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[conzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objzx_CompositionEN.zxPaperStatusId = objRow[conzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[conzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objzx_CompositionEN.VersionCount = objRow[conzx_Composition.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.VersionCount].ToString().Trim()); //版本统计
objzx_CompositionEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsPublic].ToString().Trim()); //是否公开
objzx_CompositionEN.AskQuestion = objRow[conzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[conzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objzx_CompositionEN.ResearchStatus = objRow[conzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[conzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objzx_CompositionEN.InnovationPoints = objRow[conzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[conzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objzx_CompositionEN.ResearchDesign = objRow[conzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[conzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objzx_CompositionEN.DimensionDataProcess = objRow[conzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[conzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objzx_CompositionEN.ExpectedConclusion = objRow[conzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[conzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objzx_CompositionEN.CreateDate = objRow[conzx_Composition.CreateDate] == DBNull.Value ? null : objRow[conzx_Composition.CreateDate].ToString().Trim(); //建立日期
objzx_CompositionEN.zxShareId = objRow[conzx_Composition.zxShareId] == DBNull.Value ? null : objRow[conzx_Composition.zxShareId].ToString().Trim(); //分享Id
objzx_CompositionEN.UpdUser = objRow[conzx_Composition.UpdUser] == DBNull.Value ? null : objRow[conzx_Composition.UpdUser].ToString().Trim(); //修改人
objzx_CompositionEN.PaperQCount = objRow[conzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objzx_CompositionEN.SubVCount = objRow[conzx_Composition.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objzx_CompositionEN.TagsCount = objRow[conzx_Composition.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objzx_CompositionEN.TeaQCount = objRow[conzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objzx_CompositionEN.GroupTextId = objRow[conzx_Composition.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_CompositionEN.zxPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_CompositionEN);
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
public static List<clszx_CompositionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_CompositionEN> arrObjLst = new List<clszx_CompositionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_CompositionEN objzx_CompositionEN = new clszx_CompositionEN();
try
{
objzx_CompositionEN.zxPaperId = objRow[conzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objzx_CompositionEN.PaperTitle = objRow[conzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objzx_CompositionEN.PaperName = objRow[conzx_Composition.PaperName] == DBNull.Value ? null : objRow[conzx_Composition.PaperName].ToString().Trim(); //主题名称
objzx_CompositionEN.PaperContent = objRow[conzx_Composition.PaperContent] == DBNull.Value ? null : objRow[conzx_Composition.PaperContent].ToString().Trim(); //主题内容
objzx_CompositionEN.Periodical = objRow[conzx_Composition.Periodical] == DBNull.Value ? null : objRow[conzx_Composition.Periodical].ToString().Trim(); //期刊
objzx_CompositionEN.Author = objRow[conzx_Composition.Author] == DBNull.Value ? null : objRow[conzx_Composition.Author].ToString().Trim(); //作者
objzx_CompositionEN.ResearchQuestion = objRow[conzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objzx_CompositionEN.UpdDate = objRow[conzx_Composition.UpdDate] == DBNull.Value ? null : objRow[conzx_Composition.UpdDate].ToString().Trim(); //修改日期
objzx_CompositionEN.Memo = objRow[conzx_Composition.Memo] == DBNull.Value ? null : objRow[conzx_Composition.Memo].ToString().Trim(); //备注
objzx_CompositionEN.Keyword = objRow[conzx_Composition.Keyword] == DBNull.Value ? null : objRow[conzx_Composition.Keyword].ToString().Trim(); //关键字
objzx_CompositionEN.LiteratureSources = objRow[conzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objzx_CompositionEN.LiteratureLink = objRow[conzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objzx_CompositionEN.UploadfileUrl = objRow[conzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objzx_CompositionEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objzx_CompositionEN.QuoteId = objRow[conzx_Composition.QuoteId] == DBNull.Value ? null : objRow[conzx_Composition.QuoteId].ToString().Trim(); //引用Id
objzx_CompositionEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsChecked].ToString().Trim()); //是否检查
objzx_CompositionEN.Checker = objRow[conzx_Composition.Checker] == DBNull.Value ? null : objRow[conzx_Composition.Checker].ToString().Trim(); //审核人
objzx_CompositionEN.zxLiteratureTypeId = objRow[conzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objzx_CompositionEN.BrowseNumber = objRow[conzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objzx_CompositionEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objzx_CompositionEN.AppraiseCount = objRow[conzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objzx_CompositionEN.AttachmentCount = objRow[conzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objzx_CompositionEN.CollectionCount = objRow[conzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objzx_CompositionEN.DownloadCount = objRow[conzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.DownloadCount].ToString().Trim()); //下载数
objzx_CompositionEN.OkCount = objRow[conzx_Composition.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.OkCount].ToString().Trim()); //点赞统计
objzx_CompositionEN.Pcount = objRow[conzx_Composition.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.Pcount].ToString().Trim()); //读写数
objzx_CompositionEN.Score = objRow[conzx_Composition.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.Score].ToString().Trim()); //评分
objzx_CompositionEN.StuScore = objRow[conzx_Composition.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.StuScore].ToString().Trim()); //学生平均分
objzx_CompositionEN.TeaScore = objRow[conzx_Composition.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.TeaScore].ToString().Trim()); //教师评分
objzx_CompositionEN.IdCurrEduCls = objRow[conzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_CompositionEN.PaperTypeId = objRow[conzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[conzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objzx_CompositionEN.zxPaperStatusId = objRow[conzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[conzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objzx_CompositionEN.VersionCount = objRow[conzx_Composition.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.VersionCount].ToString().Trim()); //版本统计
objzx_CompositionEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsPublic].ToString().Trim()); //是否公开
objzx_CompositionEN.AskQuestion = objRow[conzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[conzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objzx_CompositionEN.ResearchStatus = objRow[conzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[conzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objzx_CompositionEN.InnovationPoints = objRow[conzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[conzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objzx_CompositionEN.ResearchDesign = objRow[conzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[conzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objzx_CompositionEN.DimensionDataProcess = objRow[conzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[conzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objzx_CompositionEN.ExpectedConclusion = objRow[conzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[conzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objzx_CompositionEN.CreateDate = objRow[conzx_Composition.CreateDate] == DBNull.Value ? null : objRow[conzx_Composition.CreateDate].ToString().Trim(); //建立日期
objzx_CompositionEN.zxShareId = objRow[conzx_Composition.zxShareId] == DBNull.Value ? null : objRow[conzx_Composition.zxShareId].ToString().Trim(); //分享Id
objzx_CompositionEN.UpdUser = objRow[conzx_Composition.UpdUser] == DBNull.Value ? null : objRow[conzx_Composition.UpdUser].ToString().Trim(); //修改人
objzx_CompositionEN.PaperQCount = objRow[conzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objzx_CompositionEN.SubVCount = objRow[conzx_Composition.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objzx_CompositionEN.TagsCount = objRow[conzx_Composition.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objzx_CompositionEN.TeaQCount = objRow[conzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objzx_CompositionEN.GroupTextId = objRow[conzx_Composition.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_CompositionEN.zxPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_CompositionEN);
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
List<clszx_CompositionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_CompositionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_CompositionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_CompositionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_CompositionEN> arrObjLst = new List<clszx_CompositionEN>(); 
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
	clszx_CompositionEN objzx_CompositionEN = new clszx_CompositionEN();
try
{
objzx_CompositionEN.zxPaperId = objRow[conzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objzx_CompositionEN.PaperTitle = objRow[conzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objzx_CompositionEN.PaperName = objRow[conzx_Composition.PaperName] == DBNull.Value ? null : objRow[conzx_Composition.PaperName].ToString().Trim(); //主题名称
objzx_CompositionEN.PaperContent = objRow[conzx_Composition.PaperContent] == DBNull.Value ? null : objRow[conzx_Composition.PaperContent].ToString().Trim(); //主题内容
objzx_CompositionEN.Periodical = objRow[conzx_Composition.Periodical] == DBNull.Value ? null : objRow[conzx_Composition.Periodical].ToString().Trim(); //期刊
objzx_CompositionEN.Author = objRow[conzx_Composition.Author] == DBNull.Value ? null : objRow[conzx_Composition.Author].ToString().Trim(); //作者
objzx_CompositionEN.ResearchQuestion = objRow[conzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objzx_CompositionEN.UpdDate = objRow[conzx_Composition.UpdDate] == DBNull.Value ? null : objRow[conzx_Composition.UpdDate].ToString().Trim(); //修改日期
objzx_CompositionEN.Memo = objRow[conzx_Composition.Memo] == DBNull.Value ? null : objRow[conzx_Composition.Memo].ToString().Trim(); //备注
objzx_CompositionEN.Keyword = objRow[conzx_Composition.Keyword] == DBNull.Value ? null : objRow[conzx_Composition.Keyword].ToString().Trim(); //关键字
objzx_CompositionEN.LiteratureSources = objRow[conzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objzx_CompositionEN.LiteratureLink = objRow[conzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objzx_CompositionEN.UploadfileUrl = objRow[conzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objzx_CompositionEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objzx_CompositionEN.QuoteId = objRow[conzx_Composition.QuoteId] == DBNull.Value ? null : objRow[conzx_Composition.QuoteId].ToString().Trim(); //引用Id
objzx_CompositionEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsChecked].ToString().Trim()); //是否检查
objzx_CompositionEN.Checker = objRow[conzx_Composition.Checker] == DBNull.Value ? null : objRow[conzx_Composition.Checker].ToString().Trim(); //审核人
objzx_CompositionEN.zxLiteratureTypeId = objRow[conzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objzx_CompositionEN.BrowseNumber = objRow[conzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objzx_CompositionEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objzx_CompositionEN.AppraiseCount = objRow[conzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objzx_CompositionEN.AttachmentCount = objRow[conzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objzx_CompositionEN.CollectionCount = objRow[conzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objzx_CompositionEN.DownloadCount = objRow[conzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.DownloadCount].ToString().Trim()); //下载数
objzx_CompositionEN.OkCount = objRow[conzx_Composition.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.OkCount].ToString().Trim()); //点赞统计
objzx_CompositionEN.Pcount = objRow[conzx_Composition.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.Pcount].ToString().Trim()); //读写数
objzx_CompositionEN.Score = objRow[conzx_Composition.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.Score].ToString().Trim()); //评分
objzx_CompositionEN.StuScore = objRow[conzx_Composition.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.StuScore].ToString().Trim()); //学生平均分
objzx_CompositionEN.TeaScore = objRow[conzx_Composition.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.TeaScore].ToString().Trim()); //教师评分
objzx_CompositionEN.IdCurrEduCls = objRow[conzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_CompositionEN.PaperTypeId = objRow[conzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[conzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objzx_CompositionEN.zxPaperStatusId = objRow[conzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[conzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objzx_CompositionEN.VersionCount = objRow[conzx_Composition.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.VersionCount].ToString().Trim()); //版本统计
objzx_CompositionEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsPublic].ToString().Trim()); //是否公开
objzx_CompositionEN.AskQuestion = objRow[conzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[conzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objzx_CompositionEN.ResearchStatus = objRow[conzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[conzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objzx_CompositionEN.InnovationPoints = objRow[conzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[conzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objzx_CompositionEN.ResearchDesign = objRow[conzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[conzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objzx_CompositionEN.DimensionDataProcess = objRow[conzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[conzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objzx_CompositionEN.ExpectedConclusion = objRow[conzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[conzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objzx_CompositionEN.CreateDate = objRow[conzx_Composition.CreateDate] == DBNull.Value ? null : objRow[conzx_Composition.CreateDate].ToString().Trim(); //建立日期
objzx_CompositionEN.zxShareId = objRow[conzx_Composition.zxShareId] == DBNull.Value ? null : objRow[conzx_Composition.zxShareId].ToString().Trim(); //分享Id
objzx_CompositionEN.UpdUser = objRow[conzx_Composition.UpdUser] == DBNull.Value ? null : objRow[conzx_Composition.UpdUser].ToString().Trim(); //修改人
objzx_CompositionEN.PaperQCount = objRow[conzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objzx_CompositionEN.SubVCount = objRow[conzx_Composition.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objzx_CompositionEN.TagsCount = objRow[conzx_Composition.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objzx_CompositionEN.TeaQCount = objRow[conzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objzx_CompositionEN.GroupTextId = objRow[conzx_Composition.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_CompositionEN.zxPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_CompositionEN);
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
public static List<clszx_CompositionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_CompositionEN> arrObjLst = new List<clszx_CompositionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_CompositionEN objzx_CompositionEN = new clszx_CompositionEN();
try
{
objzx_CompositionEN.zxPaperId = objRow[conzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objzx_CompositionEN.PaperTitle = objRow[conzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objzx_CompositionEN.PaperName = objRow[conzx_Composition.PaperName] == DBNull.Value ? null : objRow[conzx_Composition.PaperName].ToString().Trim(); //主题名称
objzx_CompositionEN.PaperContent = objRow[conzx_Composition.PaperContent] == DBNull.Value ? null : objRow[conzx_Composition.PaperContent].ToString().Trim(); //主题内容
objzx_CompositionEN.Periodical = objRow[conzx_Composition.Periodical] == DBNull.Value ? null : objRow[conzx_Composition.Periodical].ToString().Trim(); //期刊
objzx_CompositionEN.Author = objRow[conzx_Composition.Author] == DBNull.Value ? null : objRow[conzx_Composition.Author].ToString().Trim(); //作者
objzx_CompositionEN.ResearchQuestion = objRow[conzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objzx_CompositionEN.UpdDate = objRow[conzx_Composition.UpdDate] == DBNull.Value ? null : objRow[conzx_Composition.UpdDate].ToString().Trim(); //修改日期
objzx_CompositionEN.Memo = objRow[conzx_Composition.Memo] == DBNull.Value ? null : objRow[conzx_Composition.Memo].ToString().Trim(); //备注
objzx_CompositionEN.Keyword = objRow[conzx_Composition.Keyword] == DBNull.Value ? null : objRow[conzx_Composition.Keyword].ToString().Trim(); //关键字
objzx_CompositionEN.LiteratureSources = objRow[conzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objzx_CompositionEN.LiteratureLink = objRow[conzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objzx_CompositionEN.UploadfileUrl = objRow[conzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objzx_CompositionEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objzx_CompositionEN.QuoteId = objRow[conzx_Composition.QuoteId] == DBNull.Value ? null : objRow[conzx_Composition.QuoteId].ToString().Trim(); //引用Id
objzx_CompositionEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsChecked].ToString().Trim()); //是否检查
objzx_CompositionEN.Checker = objRow[conzx_Composition.Checker] == DBNull.Value ? null : objRow[conzx_Composition.Checker].ToString().Trim(); //审核人
objzx_CompositionEN.zxLiteratureTypeId = objRow[conzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objzx_CompositionEN.BrowseNumber = objRow[conzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objzx_CompositionEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objzx_CompositionEN.AppraiseCount = objRow[conzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objzx_CompositionEN.AttachmentCount = objRow[conzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objzx_CompositionEN.CollectionCount = objRow[conzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objzx_CompositionEN.DownloadCount = objRow[conzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.DownloadCount].ToString().Trim()); //下载数
objzx_CompositionEN.OkCount = objRow[conzx_Composition.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.OkCount].ToString().Trim()); //点赞统计
objzx_CompositionEN.Pcount = objRow[conzx_Composition.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.Pcount].ToString().Trim()); //读写数
objzx_CompositionEN.Score = objRow[conzx_Composition.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.Score].ToString().Trim()); //评分
objzx_CompositionEN.StuScore = objRow[conzx_Composition.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.StuScore].ToString().Trim()); //学生平均分
objzx_CompositionEN.TeaScore = objRow[conzx_Composition.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.TeaScore].ToString().Trim()); //教师评分
objzx_CompositionEN.IdCurrEduCls = objRow[conzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_CompositionEN.PaperTypeId = objRow[conzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[conzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objzx_CompositionEN.zxPaperStatusId = objRow[conzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[conzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objzx_CompositionEN.VersionCount = objRow[conzx_Composition.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.VersionCount].ToString().Trim()); //版本统计
objzx_CompositionEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsPublic].ToString().Trim()); //是否公开
objzx_CompositionEN.AskQuestion = objRow[conzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[conzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objzx_CompositionEN.ResearchStatus = objRow[conzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[conzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objzx_CompositionEN.InnovationPoints = objRow[conzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[conzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objzx_CompositionEN.ResearchDesign = objRow[conzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[conzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objzx_CompositionEN.DimensionDataProcess = objRow[conzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[conzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objzx_CompositionEN.ExpectedConclusion = objRow[conzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[conzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objzx_CompositionEN.CreateDate = objRow[conzx_Composition.CreateDate] == DBNull.Value ? null : objRow[conzx_Composition.CreateDate].ToString().Trim(); //建立日期
objzx_CompositionEN.zxShareId = objRow[conzx_Composition.zxShareId] == DBNull.Value ? null : objRow[conzx_Composition.zxShareId].ToString().Trim(); //分享Id
objzx_CompositionEN.UpdUser = objRow[conzx_Composition.UpdUser] == DBNull.Value ? null : objRow[conzx_Composition.UpdUser].ToString().Trim(); //修改人
objzx_CompositionEN.PaperQCount = objRow[conzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objzx_CompositionEN.SubVCount = objRow[conzx_Composition.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objzx_CompositionEN.TagsCount = objRow[conzx_Composition.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objzx_CompositionEN.TeaQCount = objRow[conzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objzx_CompositionEN.GroupTextId = objRow[conzx_Composition.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_CompositionEN.zxPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_CompositionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_CompositionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_CompositionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_CompositionEN> arrObjLst = new List<clszx_CompositionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_CompositionEN objzx_CompositionEN = new clszx_CompositionEN();
try
{
objzx_CompositionEN.zxPaperId = objRow[conzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objzx_CompositionEN.PaperTitle = objRow[conzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objzx_CompositionEN.PaperName = objRow[conzx_Composition.PaperName] == DBNull.Value ? null : objRow[conzx_Composition.PaperName].ToString().Trim(); //主题名称
objzx_CompositionEN.PaperContent = objRow[conzx_Composition.PaperContent] == DBNull.Value ? null : objRow[conzx_Composition.PaperContent].ToString().Trim(); //主题内容
objzx_CompositionEN.Periodical = objRow[conzx_Composition.Periodical] == DBNull.Value ? null : objRow[conzx_Composition.Periodical].ToString().Trim(); //期刊
objzx_CompositionEN.Author = objRow[conzx_Composition.Author] == DBNull.Value ? null : objRow[conzx_Composition.Author].ToString().Trim(); //作者
objzx_CompositionEN.ResearchQuestion = objRow[conzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objzx_CompositionEN.UpdDate = objRow[conzx_Composition.UpdDate] == DBNull.Value ? null : objRow[conzx_Composition.UpdDate].ToString().Trim(); //修改日期
objzx_CompositionEN.Memo = objRow[conzx_Composition.Memo] == DBNull.Value ? null : objRow[conzx_Composition.Memo].ToString().Trim(); //备注
objzx_CompositionEN.Keyword = objRow[conzx_Composition.Keyword] == DBNull.Value ? null : objRow[conzx_Composition.Keyword].ToString().Trim(); //关键字
objzx_CompositionEN.LiteratureSources = objRow[conzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objzx_CompositionEN.LiteratureLink = objRow[conzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objzx_CompositionEN.UploadfileUrl = objRow[conzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objzx_CompositionEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objzx_CompositionEN.QuoteId = objRow[conzx_Composition.QuoteId] == DBNull.Value ? null : objRow[conzx_Composition.QuoteId].ToString().Trim(); //引用Id
objzx_CompositionEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsChecked].ToString().Trim()); //是否检查
objzx_CompositionEN.Checker = objRow[conzx_Composition.Checker] == DBNull.Value ? null : objRow[conzx_Composition.Checker].ToString().Trim(); //审核人
objzx_CompositionEN.zxLiteratureTypeId = objRow[conzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objzx_CompositionEN.BrowseNumber = objRow[conzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objzx_CompositionEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objzx_CompositionEN.AppraiseCount = objRow[conzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objzx_CompositionEN.AttachmentCount = objRow[conzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objzx_CompositionEN.CollectionCount = objRow[conzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objzx_CompositionEN.DownloadCount = objRow[conzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.DownloadCount].ToString().Trim()); //下载数
objzx_CompositionEN.OkCount = objRow[conzx_Composition.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.OkCount].ToString().Trim()); //点赞统计
objzx_CompositionEN.Pcount = objRow[conzx_Composition.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.Pcount].ToString().Trim()); //读写数
objzx_CompositionEN.Score = objRow[conzx_Composition.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.Score].ToString().Trim()); //评分
objzx_CompositionEN.StuScore = objRow[conzx_Composition.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.StuScore].ToString().Trim()); //学生平均分
objzx_CompositionEN.TeaScore = objRow[conzx_Composition.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.TeaScore].ToString().Trim()); //教师评分
objzx_CompositionEN.IdCurrEduCls = objRow[conzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_CompositionEN.PaperTypeId = objRow[conzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[conzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objzx_CompositionEN.zxPaperStatusId = objRow[conzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[conzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objzx_CompositionEN.VersionCount = objRow[conzx_Composition.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.VersionCount].ToString().Trim()); //版本统计
objzx_CompositionEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsPublic].ToString().Trim()); //是否公开
objzx_CompositionEN.AskQuestion = objRow[conzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[conzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objzx_CompositionEN.ResearchStatus = objRow[conzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[conzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objzx_CompositionEN.InnovationPoints = objRow[conzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[conzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objzx_CompositionEN.ResearchDesign = objRow[conzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[conzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objzx_CompositionEN.DimensionDataProcess = objRow[conzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[conzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objzx_CompositionEN.ExpectedConclusion = objRow[conzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[conzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objzx_CompositionEN.CreateDate = objRow[conzx_Composition.CreateDate] == DBNull.Value ? null : objRow[conzx_Composition.CreateDate].ToString().Trim(); //建立日期
objzx_CompositionEN.zxShareId = objRow[conzx_Composition.zxShareId] == DBNull.Value ? null : objRow[conzx_Composition.zxShareId].ToString().Trim(); //分享Id
objzx_CompositionEN.UpdUser = objRow[conzx_Composition.UpdUser] == DBNull.Value ? null : objRow[conzx_Composition.UpdUser].ToString().Trim(); //修改人
objzx_CompositionEN.PaperQCount = objRow[conzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objzx_CompositionEN.SubVCount = objRow[conzx_Composition.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objzx_CompositionEN.TagsCount = objRow[conzx_Composition.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objzx_CompositionEN.TeaQCount = objRow[conzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objzx_CompositionEN.GroupTextId = objRow[conzx_Composition.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_CompositionEN.zxPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_CompositionEN);
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
public static List<clszx_CompositionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_CompositionEN> arrObjLst = new List<clszx_CompositionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_CompositionEN objzx_CompositionEN = new clszx_CompositionEN();
try
{
objzx_CompositionEN.zxPaperId = objRow[conzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objzx_CompositionEN.PaperTitle = objRow[conzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objzx_CompositionEN.PaperName = objRow[conzx_Composition.PaperName] == DBNull.Value ? null : objRow[conzx_Composition.PaperName].ToString().Trim(); //主题名称
objzx_CompositionEN.PaperContent = objRow[conzx_Composition.PaperContent] == DBNull.Value ? null : objRow[conzx_Composition.PaperContent].ToString().Trim(); //主题内容
objzx_CompositionEN.Periodical = objRow[conzx_Composition.Periodical] == DBNull.Value ? null : objRow[conzx_Composition.Periodical].ToString().Trim(); //期刊
objzx_CompositionEN.Author = objRow[conzx_Composition.Author] == DBNull.Value ? null : objRow[conzx_Composition.Author].ToString().Trim(); //作者
objzx_CompositionEN.ResearchQuestion = objRow[conzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objzx_CompositionEN.UpdDate = objRow[conzx_Composition.UpdDate] == DBNull.Value ? null : objRow[conzx_Composition.UpdDate].ToString().Trim(); //修改日期
objzx_CompositionEN.Memo = objRow[conzx_Composition.Memo] == DBNull.Value ? null : objRow[conzx_Composition.Memo].ToString().Trim(); //备注
objzx_CompositionEN.Keyword = objRow[conzx_Composition.Keyword] == DBNull.Value ? null : objRow[conzx_Composition.Keyword].ToString().Trim(); //关键字
objzx_CompositionEN.LiteratureSources = objRow[conzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objzx_CompositionEN.LiteratureLink = objRow[conzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objzx_CompositionEN.UploadfileUrl = objRow[conzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objzx_CompositionEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objzx_CompositionEN.QuoteId = objRow[conzx_Composition.QuoteId] == DBNull.Value ? null : objRow[conzx_Composition.QuoteId].ToString().Trim(); //引用Id
objzx_CompositionEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsChecked].ToString().Trim()); //是否检查
objzx_CompositionEN.Checker = objRow[conzx_Composition.Checker] == DBNull.Value ? null : objRow[conzx_Composition.Checker].ToString().Trim(); //审核人
objzx_CompositionEN.zxLiteratureTypeId = objRow[conzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objzx_CompositionEN.BrowseNumber = objRow[conzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objzx_CompositionEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objzx_CompositionEN.AppraiseCount = objRow[conzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objzx_CompositionEN.AttachmentCount = objRow[conzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objzx_CompositionEN.CollectionCount = objRow[conzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objzx_CompositionEN.DownloadCount = objRow[conzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.DownloadCount].ToString().Trim()); //下载数
objzx_CompositionEN.OkCount = objRow[conzx_Composition.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.OkCount].ToString().Trim()); //点赞统计
objzx_CompositionEN.Pcount = objRow[conzx_Composition.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.Pcount].ToString().Trim()); //读写数
objzx_CompositionEN.Score = objRow[conzx_Composition.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.Score].ToString().Trim()); //评分
objzx_CompositionEN.StuScore = objRow[conzx_Composition.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.StuScore].ToString().Trim()); //学生平均分
objzx_CompositionEN.TeaScore = objRow[conzx_Composition.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.TeaScore].ToString().Trim()); //教师评分
objzx_CompositionEN.IdCurrEduCls = objRow[conzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_CompositionEN.PaperTypeId = objRow[conzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[conzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objzx_CompositionEN.zxPaperStatusId = objRow[conzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[conzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objzx_CompositionEN.VersionCount = objRow[conzx_Composition.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.VersionCount].ToString().Trim()); //版本统计
objzx_CompositionEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsPublic].ToString().Trim()); //是否公开
objzx_CompositionEN.AskQuestion = objRow[conzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[conzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objzx_CompositionEN.ResearchStatus = objRow[conzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[conzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objzx_CompositionEN.InnovationPoints = objRow[conzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[conzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objzx_CompositionEN.ResearchDesign = objRow[conzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[conzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objzx_CompositionEN.DimensionDataProcess = objRow[conzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[conzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objzx_CompositionEN.ExpectedConclusion = objRow[conzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[conzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objzx_CompositionEN.CreateDate = objRow[conzx_Composition.CreateDate] == DBNull.Value ? null : objRow[conzx_Composition.CreateDate].ToString().Trim(); //建立日期
objzx_CompositionEN.zxShareId = objRow[conzx_Composition.zxShareId] == DBNull.Value ? null : objRow[conzx_Composition.zxShareId].ToString().Trim(); //分享Id
objzx_CompositionEN.UpdUser = objRow[conzx_Composition.UpdUser] == DBNull.Value ? null : objRow[conzx_Composition.UpdUser].ToString().Trim(); //修改人
objzx_CompositionEN.PaperQCount = objRow[conzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objzx_CompositionEN.SubVCount = objRow[conzx_Composition.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objzx_CompositionEN.TagsCount = objRow[conzx_Composition.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objzx_CompositionEN.TeaQCount = objRow[conzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objzx_CompositionEN.GroupTextId = objRow[conzx_Composition.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_CompositionEN.zxPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_CompositionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_CompositionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_CompositionEN> arrObjLst = new List<clszx_CompositionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_CompositionEN objzx_CompositionEN = new clszx_CompositionEN();
try
{
objzx_CompositionEN.zxPaperId = objRow[conzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objzx_CompositionEN.PaperTitle = objRow[conzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objzx_CompositionEN.PaperName = objRow[conzx_Composition.PaperName] == DBNull.Value ? null : objRow[conzx_Composition.PaperName].ToString().Trim(); //主题名称
objzx_CompositionEN.PaperContent = objRow[conzx_Composition.PaperContent] == DBNull.Value ? null : objRow[conzx_Composition.PaperContent].ToString().Trim(); //主题内容
objzx_CompositionEN.Periodical = objRow[conzx_Composition.Periodical] == DBNull.Value ? null : objRow[conzx_Composition.Periodical].ToString().Trim(); //期刊
objzx_CompositionEN.Author = objRow[conzx_Composition.Author] == DBNull.Value ? null : objRow[conzx_Composition.Author].ToString().Trim(); //作者
objzx_CompositionEN.ResearchQuestion = objRow[conzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objzx_CompositionEN.UpdDate = objRow[conzx_Composition.UpdDate] == DBNull.Value ? null : objRow[conzx_Composition.UpdDate].ToString().Trim(); //修改日期
objzx_CompositionEN.Memo = objRow[conzx_Composition.Memo] == DBNull.Value ? null : objRow[conzx_Composition.Memo].ToString().Trim(); //备注
objzx_CompositionEN.Keyword = objRow[conzx_Composition.Keyword] == DBNull.Value ? null : objRow[conzx_Composition.Keyword].ToString().Trim(); //关键字
objzx_CompositionEN.LiteratureSources = objRow[conzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objzx_CompositionEN.LiteratureLink = objRow[conzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objzx_CompositionEN.UploadfileUrl = objRow[conzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objzx_CompositionEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objzx_CompositionEN.QuoteId = objRow[conzx_Composition.QuoteId] == DBNull.Value ? null : objRow[conzx_Composition.QuoteId].ToString().Trim(); //引用Id
objzx_CompositionEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsChecked].ToString().Trim()); //是否检查
objzx_CompositionEN.Checker = objRow[conzx_Composition.Checker] == DBNull.Value ? null : objRow[conzx_Composition.Checker].ToString().Trim(); //审核人
objzx_CompositionEN.zxLiteratureTypeId = objRow[conzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objzx_CompositionEN.BrowseNumber = objRow[conzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objzx_CompositionEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objzx_CompositionEN.AppraiseCount = objRow[conzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objzx_CompositionEN.AttachmentCount = objRow[conzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objzx_CompositionEN.CollectionCount = objRow[conzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objzx_CompositionEN.DownloadCount = objRow[conzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.DownloadCount].ToString().Trim()); //下载数
objzx_CompositionEN.OkCount = objRow[conzx_Composition.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.OkCount].ToString().Trim()); //点赞统计
objzx_CompositionEN.Pcount = objRow[conzx_Composition.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.Pcount].ToString().Trim()); //读写数
objzx_CompositionEN.Score = objRow[conzx_Composition.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.Score].ToString().Trim()); //评分
objzx_CompositionEN.StuScore = objRow[conzx_Composition.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.StuScore].ToString().Trim()); //学生平均分
objzx_CompositionEN.TeaScore = objRow[conzx_Composition.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Composition.TeaScore].ToString().Trim()); //教师评分
objzx_CompositionEN.IdCurrEduCls = objRow[conzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_CompositionEN.PaperTypeId = objRow[conzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[conzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objzx_CompositionEN.zxPaperStatusId = objRow[conzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[conzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objzx_CompositionEN.VersionCount = objRow[conzx_Composition.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.VersionCount].ToString().Trim()); //版本统计
objzx_CompositionEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Composition.IsPublic].ToString().Trim()); //是否公开
objzx_CompositionEN.AskQuestion = objRow[conzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[conzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objzx_CompositionEN.ResearchStatus = objRow[conzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[conzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objzx_CompositionEN.InnovationPoints = objRow[conzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[conzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objzx_CompositionEN.ResearchDesign = objRow[conzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[conzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objzx_CompositionEN.DimensionDataProcess = objRow[conzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[conzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objzx_CompositionEN.ExpectedConclusion = objRow[conzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[conzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objzx_CompositionEN.CreateDate = objRow[conzx_Composition.CreateDate] == DBNull.Value ? null : objRow[conzx_Composition.CreateDate].ToString().Trim(); //建立日期
objzx_CompositionEN.zxShareId = objRow[conzx_Composition.zxShareId] == DBNull.Value ? null : objRow[conzx_Composition.zxShareId].ToString().Trim(); //分享Id
objzx_CompositionEN.UpdUser = objRow[conzx_Composition.UpdUser] == DBNull.Value ? null : objRow[conzx_Composition.UpdUser].ToString().Trim(); //修改人
objzx_CompositionEN.PaperQCount = objRow[conzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objzx_CompositionEN.SubVCount = objRow[conzx_Composition.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objzx_CompositionEN.TagsCount = objRow[conzx_Composition.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objzx_CompositionEN.TeaQCount = objRow[conzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objzx_CompositionEN.GroupTextId = objRow[conzx_Composition.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_CompositionEN.zxPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_CompositionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_CompositionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_Composition(ref clszx_CompositionEN objzx_CompositionEN)
{
bool bolResult = zx_CompositionDA.Getzx_Composition(ref objzx_CompositionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_CompositionEN GetObjByzxPaperId(string strzxPaperId)
{
if (strzxPaperId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxPaperId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxPaperId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxPaperId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clszx_CompositionEN objzx_CompositionEN = zx_CompositionDA.GetObjByzxPaperId(strzxPaperId);
return objzx_CompositionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_CompositionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_CompositionEN objzx_CompositionEN = zx_CompositionDA.GetFirstObj(strWhereCond);
 return objzx_CompositionEN;
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
public static clszx_CompositionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_CompositionEN objzx_CompositionEN = zx_CompositionDA.GetObjByDataRow(objRow);
 return objzx_CompositionEN;
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
public static clszx_CompositionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_CompositionEN objzx_CompositionEN = zx_CompositionDA.GetObjByDataRow(objRow);
 return objzx_CompositionEN;
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
 /// <param name = "strzxPaperId">所给的关键字</param>
 /// <param name = "lstzx_CompositionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_CompositionEN GetObjByzxPaperIdFromList(string strzxPaperId, List<clszx_CompositionEN> lstzx_CompositionObjLst)
{
foreach (clszx_CompositionEN objzx_CompositionEN in lstzx_CompositionObjLst)
{
if (objzx_CompositionEN.zxPaperId == strzxPaperId)
{
return objzx_CompositionEN;
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
 string strMaxZxPaperId;
 try
 {
 strMaxZxPaperId = clszx_CompositionDA.GetMaxStrId();
 return strMaxZxPaperId;
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
 string strzxPaperId;
 try
 {
 strzxPaperId = new clszx_CompositionDA().GetFirstID(strWhereCond);
 return strzxPaperId;
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
 arrList = zx_CompositionDA.GetID(strWhereCond);
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
bool bolIsExist = zx_CompositionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxPaperId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxPaperId)
{
if (string.IsNullOrEmpty(strzxPaperId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxPaperId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = zx_CompositionDA.IsExist(strzxPaperId);
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
 bolIsExist = clszx_CompositionDA.IsExistTable();
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
 bolIsExist = zx_CompositionDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_CompositionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_CompositionEN objzx_CompositionEN)
{
if (objzx_CompositionEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!论文Id = [{0}]的数据已经存在!(in clszx_CompositionBL.AddNewRecordBySql2)", objzx_CompositionEN.zxPaperId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_CompositionEN.zxPaperId) == true || clszx_CompositionBL.IsExist(objzx_CompositionEN.zxPaperId) == true)
 {
     objzx_CompositionEN.zxPaperId = clszx_CompositionBL.GetMaxStrId_S();
 }
bool bolResult = zx_CompositionDA.AddNewRecordBySQL2(objzx_CompositionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_CompositionBL.ReFreshCache();

if (clszx_CompositionBL.relatedActions != null)
{
clszx_CompositionBL.relatedActions.UpdRelaTabDate(objzx_CompositionEN.zxPaperId, "SetUpdDate");
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
 /// <param name = "objzx_CompositionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_CompositionEN objzx_CompositionEN)
{
if (objzx_CompositionEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!论文Id = [{0}]的数据已经存在!(in clszx_CompositionBL.AddNewRecordBySql2WithReturnKey)", objzx_CompositionEN.zxPaperId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_CompositionEN.zxPaperId) == true || clszx_CompositionBL.IsExist(objzx_CompositionEN.zxPaperId) == true)
 {
     objzx_CompositionEN.zxPaperId = clszx_CompositionBL.GetMaxStrId_S();
 }
string strKey = zx_CompositionDA.AddNewRecordBySQL2WithReturnKey(objzx_CompositionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_CompositionBL.ReFreshCache();

if (clszx_CompositionBL.relatedActions != null)
{
clszx_CompositionBL.relatedActions.UpdRelaTabDate(objzx_CompositionEN.zxPaperId, "SetUpdDate");
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
 /// <param name = "objzx_CompositionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_CompositionEN objzx_CompositionEN)
{
try
{
bool bolResult = zx_CompositionDA.Update(objzx_CompositionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_CompositionBL.ReFreshCache();

if (clszx_CompositionBL.relatedActions != null)
{
clszx_CompositionBL.relatedActions.UpdRelaTabDate(objzx_CompositionEN.zxPaperId, "SetUpdDate");
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
 /// <param name = "objzx_CompositionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_CompositionEN objzx_CompositionEN)
{
 if (string.IsNullOrEmpty(objzx_CompositionEN.zxPaperId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_CompositionDA.UpdateBySql2(objzx_CompositionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_CompositionBL.ReFreshCache();

if (clszx_CompositionBL.relatedActions != null)
{
clszx_CompositionBL.relatedActions.UpdRelaTabDate(objzx_CompositionEN.zxPaperId, "SetUpdDate");
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
 /// <param name = "strzxPaperId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strzxPaperId)
{
try
{
 clszx_CompositionEN objzx_CompositionEN = clszx_CompositionBL.GetObjByzxPaperId(strzxPaperId);

if (clszx_CompositionBL.relatedActions != null)
{
clszx_CompositionBL.relatedActions.UpdRelaTabDate(objzx_CompositionEN.zxPaperId, "SetUpdDate");
}
if (objzx_CompositionEN != null)
{
int intRecNum = zx_CompositionDA.DelRecord(strzxPaperId);
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
/// <param name="strzxPaperId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strzxPaperId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_CompositionDA.GetSpecSQLObj();
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
//删除与表:[zx_Composition]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_Composition.zxPaperId,
//strzxPaperId);
//        clszx_CompositionBL.Delzx_CompositionsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_CompositionBL.DelRecord(strzxPaperId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_CompositionBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxPaperId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strzxPaperId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strzxPaperId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_CompositionBL.relatedActions != null)
{
clszx_CompositionBL.relatedActions.UpdRelaTabDate(strzxPaperId, "UpdRelaTabDate");
}
bool bolResult = zx_CompositionDA.DelRecord(strzxPaperId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrzxPaperIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_Compositions(List<string> arrzxPaperIdLst)
{
if (arrzxPaperIdLst.Count == 0) return 0;
try
{
if (clszx_CompositionBL.relatedActions != null)
{
foreach (var strzxPaperId in arrzxPaperIdLst)
{
clszx_CompositionBL.relatedActions.UpdRelaTabDate(strzxPaperId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_CompositionDA.Delzx_Composition(arrzxPaperIdLst);
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
public static int Delzx_CompositionsByCond(string strWhereCond)
{
try
{
if (clszx_CompositionBL.relatedActions != null)
{
List<string> arrzxPaperId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strzxPaperId in arrzxPaperId)
{
clszx_CompositionBL.relatedActions.UpdRelaTabDate(strzxPaperId, "UpdRelaTabDate");
}
}
int intRecNum = zx_CompositionDA.Delzx_Composition(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_Composition]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strzxPaperId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strzxPaperId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_CompositionDA.GetSpecSQLObj();
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
//删除与表:[zx_Composition]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_CompositionBL.DelRecord(strzxPaperId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_CompositionBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxPaperId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_CompositionENS">源对象</param>
 /// <param name = "objzx_CompositionENT">目标对象</param>
 public static void CopyTo(clszx_CompositionEN objzx_CompositionENS, clszx_CompositionEN objzx_CompositionENT)
{
try
{
objzx_CompositionENT.zxPaperId = objzx_CompositionENS.zxPaperId; //论文Id
objzx_CompositionENT.PaperTitle = objzx_CompositionENS.PaperTitle; //论文标题
objzx_CompositionENT.PaperName = objzx_CompositionENS.PaperName; //主题名称
objzx_CompositionENT.PaperContent = objzx_CompositionENS.PaperContent; //主题内容
objzx_CompositionENT.Periodical = objzx_CompositionENS.Periodical; //期刊
objzx_CompositionENT.Author = objzx_CompositionENS.Author; //作者
objzx_CompositionENT.ResearchQuestion = objzx_CompositionENS.ResearchQuestion; //研究问题
objzx_CompositionENT.UpdDate = objzx_CompositionENS.UpdDate; //修改日期
objzx_CompositionENT.Memo = objzx_CompositionENS.Memo; //备注
objzx_CompositionENT.Keyword = objzx_CompositionENS.Keyword; //关键字
objzx_CompositionENT.LiteratureSources = objzx_CompositionENS.LiteratureSources; //文献来源
objzx_CompositionENT.LiteratureLink = objzx_CompositionENS.LiteratureLink; //文献链接
objzx_CompositionENT.UploadfileUrl = objzx_CompositionENS.UploadfileUrl; //文件地址
objzx_CompositionENT.IsQuotethesis = objzx_CompositionENS.IsQuotethesis; //是否引用论文
objzx_CompositionENT.QuoteId = objzx_CompositionENS.QuoteId; //引用Id
objzx_CompositionENT.IsChecked = objzx_CompositionENS.IsChecked; //是否检查
objzx_CompositionENT.Checker = objzx_CompositionENS.Checker; //审核人
objzx_CompositionENT.zxLiteratureTypeId = objzx_CompositionENS.zxLiteratureTypeId; //作文类型Id
objzx_CompositionENT.BrowseNumber = objzx_CompositionENS.BrowseNumber; //浏览量
objzx_CompositionENT.IsSubmit = objzx_CompositionENS.IsSubmit; //是否提交
objzx_CompositionENT.AppraiseCount = objzx_CompositionENS.AppraiseCount; //评论数
objzx_CompositionENT.AttachmentCount = objzx_CompositionENS.AttachmentCount; //附件计数
objzx_CompositionENT.CollectionCount = objzx_CompositionENS.CollectionCount; //收藏数量
objzx_CompositionENT.DownloadCount = objzx_CompositionENS.DownloadCount; //下载数
objzx_CompositionENT.OkCount = objzx_CompositionENS.OkCount; //点赞统计
objzx_CompositionENT.Pcount = objzx_CompositionENS.Pcount; //读写数
objzx_CompositionENT.Score = objzx_CompositionENS.Score; //评分
objzx_CompositionENT.StuScore = objzx_CompositionENS.StuScore; //学生平均分
objzx_CompositionENT.TeaScore = objzx_CompositionENS.TeaScore; //教师评分
objzx_CompositionENT.IdCurrEduCls = objzx_CompositionENS.IdCurrEduCls; //教学班流水号
objzx_CompositionENT.PaperTypeId = objzx_CompositionENS.PaperTypeId; //论文类型Id
objzx_CompositionENT.zxPaperStatusId = objzx_CompositionENS.zxPaperStatusId; //论文状态Id
objzx_CompositionENT.VersionCount = objzx_CompositionENS.VersionCount; //版本统计
objzx_CompositionENT.IsPublic = objzx_CompositionENS.IsPublic; //是否公开
objzx_CompositionENT.AskQuestion = objzx_CompositionENS.AskQuestion; //问题提出
objzx_CompositionENT.ResearchStatus = objzx_CompositionENS.ResearchStatus; //目前研究的现状
objzx_CompositionENT.InnovationPoints = objzx_CompositionENS.InnovationPoints; //创新点
objzx_CompositionENT.ResearchDesign = objzx_CompositionENS.ResearchDesign; //研究设计
objzx_CompositionENT.DimensionDataProcess = objzx_CompositionENS.DimensionDataProcess; //数据处理的维度
objzx_CompositionENT.ExpectedConclusion = objzx_CompositionENS.ExpectedConclusion; //预期结论
objzx_CompositionENT.CreateDate = objzx_CompositionENS.CreateDate; //建立日期
objzx_CompositionENT.zxShareId = objzx_CompositionENS.zxShareId; //分享Id
objzx_CompositionENT.UpdUser = objzx_CompositionENS.UpdUser; //修改人
objzx_CompositionENT.PaperQCount = objzx_CompositionENS.PaperQCount; //论文答疑数
objzx_CompositionENT.SubVCount = objzx_CompositionENS.SubVCount; //论文子观点数
objzx_CompositionENT.TagsCount = objzx_CompositionENS.TagsCount; //论文标注数
objzx_CompositionENT.TeaQCount = objzx_CompositionENS.TeaQCount; //教师提问数
objzx_CompositionENT.GroupTextId = objzx_CompositionENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_CompositionEN">源简化对象</param>
 public static void SetUpdFlag(clszx_CompositionEN objzx_CompositionEN)
{
try
{
objzx_CompositionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_CompositionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_Composition.zxPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.zxPaperId = objzx_CompositionEN.zxPaperId; //论文Id
}
if (arrFldSet.Contains(conzx_Composition.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.PaperTitle = objzx_CompositionEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(conzx_Composition.PaperName, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.PaperName = objzx_CompositionEN.PaperName == "[null]" ? null :  objzx_CompositionEN.PaperName; //主题名称
}
if (arrFldSet.Contains(conzx_Composition.PaperContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.PaperContent = objzx_CompositionEN.PaperContent == "[null]" ? null :  objzx_CompositionEN.PaperContent; //主题内容
}
if (arrFldSet.Contains(conzx_Composition.Periodical, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.Periodical = objzx_CompositionEN.Periodical == "[null]" ? null :  objzx_CompositionEN.Periodical; //期刊
}
if (arrFldSet.Contains(conzx_Composition.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.Author = objzx_CompositionEN.Author == "[null]" ? null :  objzx_CompositionEN.Author; //作者
}
if (arrFldSet.Contains(conzx_Composition.ResearchQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.ResearchQuestion = objzx_CompositionEN.ResearchQuestion == "[null]" ? null :  objzx_CompositionEN.ResearchQuestion; //研究问题
}
if (arrFldSet.Contains(conzx_Composition.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.UpdDate = objzx_CompositionEN.UpdDate == "[null]" ? null :  objzx_CompositionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_Composition.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.Memo = objzx_CompositionEN.Memo == "[null]" ? null :  objzx_CompositionEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_Composition.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.Keyword = objzx_CompositionEN.Keyword == "[null]" ? null :  objzx_CompositionEN.Keyword; //关键字
}
if (arrFldSet.Contains(conzx_Composition.LiteratureSources, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.LiteratureSources = objzx_CompositionEN.LiteratureSources == "[null]" ? null :  objzx_CompositionEN.LiteratureSources; //文献来源
}
if (arrFldSet.Contains(conzx_Composition.LiteratureLink, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.LiteratureLink = objzx_CompositionEN.LiteratureLink == "[null]" ? null :  objzx_CompositionEN.LiteratureLink; //文献链接
}
if (arrFldSet.Contains(conzx_Composition.UploadfileUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.UploadfileUrl = objzx_CompositionEN.UploadfileUrl == "[null]" ? null :  objzx_CompositionEN.UploadfileUrl; //文件地址
}
if (arrFldSet.Contains(conzx_Composition.IsQuotethesis, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.IsQuotethesis = objzx_CompositionEN.IsQuotethesis; //是否引用论文
}
if (arrFldSet.Contains(conzx_Composition.QuoteId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.QuoteId = objzx_CompositionEN.QuoteId == "[null]" ? null :  objzx_CompositionEN.QuoteId; //引用Id
}
if (arrFldSet.Contains(conzx_Composition.IsChecked, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.IsChecked = objzx_CompositionEN.IsChecked; //是否检查
}
if (arrFldSet.Contains(conzx_Composition.Checker, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.Checker = objzx_CompositionEN.Checker == "[null]" ? null :  objzx_CompositionEN.Checker; //审核人
}
if (arrFldSet.Contains(conzx_Composition.zxLiteratureTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.zxLiteratureTypeId = objzx_CompositionEN.zxLiteratureTypeId; //作文类型Id
}
if (arrFldSet.Contains(conzx_Composition.BrowseNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.BrowseNumber = objzx_CompositionEN.BrowseNumber; //浏览量
}
if (arrFldSet.Contains(conzx_Composition.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.IsSubmit = objzx_CompositionEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conzx_Composition.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.AppraiseCount = objzx_CompositionEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(conzx_Composition.AttachmentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.AttachmentCount = objzx_CompositionEN.AttachmentCount; //附件计数
}
if (arrFldSet.Contains(conzx_Composition.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.CollectionCount = objzx_CompositionEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(conzx_Composition.DownloadCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.DownloadCount = objzx_CompositionEN.DownloadCount; //下载数
}
if (arrFldSet.Contains(conzx_Composition.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.OkCount = objzx_CompositionEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(conzx_Composition.Pcount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.Pcount = objzx_CompositionEN.Pcount; //读写数
}
if (arrFldSet.Contains(conzx_Composition.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.Score = objzx_CompositionEN.Score; //评分
}
if (arrFldSet.Contains(conzx_Composition.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.StuScore = objzx_CompositionEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(conzx_Composition.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.TeaScore = objzx_CompositionEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conzx_Composition.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.IdCurrEduCls = objzx_CompositionEN.IdCurrEduCls == "[null]" ? null :  objzx_CompositionEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conzx_Composition.PaperTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.PaperTypeId = objzx_CompositionEN.PaperTypeId == "[null]" ? null :  objzx_CompositionEN.PaperTypeId; //论文类型Id
}
if (arrFldSet.Contains(conzx_Composition.zxPaperStatusId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.zxPaperStatusId = objzx_CompositionEN.zxPaperStatusId == "[null]" ? null :  objzx_CompositionEN.zxPaperStatusId; //论文状态Id
}
if (arrFldSet.Contains(conzx_Composition.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.VersionCount = objzx_CompositionEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(conzx_Composition.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.IsPublic = objzx_CompositionEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(conzx_Composition.AskQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.AskQuestion = objzx_CompositionEN.AskQuestion == "[null]" ? null :  objzx_CompositionEN.AskQuestion; //问题提出
}
if (arrFldSet.Contains(conzx_Composition.ResearchStatus, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.ResearchStatus = objzx_CompositionEN.ResearchStatus == "[null]" ? null :  objzx_CompositionEN.ResearchStatus; //目前研究的现状
}
if (arrFldSet.Contains(conzx_Composition.InnovationPoints, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.InnovationPoints = objzx_CompositionEN.InnovationPoints == "[null]" ? null :  objzx_CompositionEN.InnovationPoints; //创新点
}
if (arrFldSet.Contains(conzx_Composition.ResearchDesign, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.ResearchDesign = objzx_CompositionEN.ResearchDesign == "[null]" ? null :  objzx_CompositionEN.ResearchDesign; //研究设计
}
if (arrFldSet.Contains(conzx_Composition.DimensionDataProcess, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.DimensionDataProcess = objzx_CompositionEN.DimensionDataProcess == "[null]" ? null :  objzx_CompositionEN.DimensionDataProcess; //数据处理的维度
}
if (arrFldSet.Contains(conzx_Composition.ExpectedConclusion, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.ExpectedConclusion = objzx_CompositionEN.ExpectedConclusion == "[null]" ? null :  objzx_CompositionEN.ExpectedConclusion; //预期结论
}
if (arrFldSet.Contains(conzx_Composition.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.CreateDate = objzx_CompositionEN.CreateDate == "[null]" ? null :  objzx_CompositionEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conzx_Composition.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.zxShareId = objzx_CompositionEN.zxShareId == "[null]" ? null :  objzx_CompositionEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(conzx_Composition.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.UpdUser = objzx_CompositionEN.UpdUser == "[null]" ? null :  objzx_CompositionEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_Composition.PaperQCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.PaperQCount = objzx_CompositionEN.PaperQCount; //论文答疑数
}
if (arrFldSet.Contains(conzx_Composition.SubVCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.SubVCount = objzx_CompositionEN.SubVCount; //论文子观点数
}
if (arrFldSet.Contains(conzx_Composition.TagsCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.TagsCount = objzx_CompositionEN.TagsCount; //论文标注数
}
if (arrFldSet.Contains(conzx_Composition.TeaQCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.TeaQCount = objzx_CompositionEN.TeaQCount; //教师提问数
}
if (arrFldSet.Contains(conzx_Composition.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_CompositionEN.GroupTextId = objzx_CompositionEN.GroupTextId; //小组Id
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
 /// <param name = "objzx_CompositionEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_CompositionEN objzx_CompositionEN)
{
try
{
if (objzx_CompositionEN.PaperName == "[null]") objzx_CompositionEN.PaperName = null; //主题名称
if (objzx_CompositionEN.PaperContent == "[null]") objzx_CompositionEN.PaperContent = null; //主题内容
if (objzx_CompositionEN.Periodical == "[null]") objzx_CompositionEN.Periodical = null; //期刊
if (objzx_CompositionEN.Author == "[null]") objzx_CompositionEN.Author = null; //作者
if (objzx_CompositionEN.ResearchQuestion == "[null]") objzx_CompositionEN.ResearchQuestion = null; //研究问题
if (objzx_CompositionEN.UpdDate == "[null]") objzx_CompositionEN.UpdDate = null; //修改日期
if (objzx_CompositionEN.Memo == "[null]") objzx_CompositionEN.Memo = null; //备注
if (objzx_CompositionEN.Keyword == "[null]") objzx_CompositionEN.Keyword = null; //关键字
if (objzx_CompositionEN.LiteratureSources == "[null]") objzx_CompositionEN.LiteratureSources = null; //文献来源
if (objzx_CompositionEN.LiteratureLink == "[null]") objzx_CompositionEN.LiteratureLink = null; //文献链接
if (objzx_CompositionEN.UploadfileUrl == "[null]") objzx_CompositionEN.UploadfileUrl = null; //文件地址
if (objzx_CompositionEN.QuoteId == "[null]") objzx_CompositionEN.QuoteId = null; //引用Id
if (objzx_CompositionEN.Checker == "[null]") objzx_CompositionEN.Checker = null; //审核人
if (objzx_CompositionEN.IdCurrEduCls == "[null]") objzx_CompositionEN.IdCurrEduCls = null; //教学班流水号
if (objzx_CompositionEN.PaperTypeId == "[null]") objzx_CompositionEN.PaperTypeId = null; //论文类型Id
if (objzx_CompositionEN.zxPaperStatusId == "[null]") objzx_CompositionEN.zxPaperStatusId = null; //论文状态Id
if (objzx_CompositionEN.AskQuestion == "[null]") objzx_CompositionEN.AskQuestion = null; //问题提出
if (objzx_CompositionEN.ResearchStatus == "[null]") objzx_CompositionEN.ResearchStatus = null; //目前研究的现状
if (objzx_CompositionEN.InnovationPoints == "[null]") objzx_CompositionEN.InnovationPoints = null; //创新点
if (objzx_CompositionEN.ResearchDesign == "[null]") objzx_CompositionEN.ResearchDesign = null; //研究设计
if (objzx_CompositionEN.DimensionDataProcess == "[null]") objzx_CompositionEN.DimensionDataProcess = null; //数据处理的维度
if (objzx_CompositionEN.ExpectedConclusion == "[null]") objzx_CompositionEN.ExpectedConclusion = null; //预期结论
if (objzx_CompositionEN.CreateDate == "[null]") objzx_CompositionEN.CreateDate = null; //建立日期
if (objzx_CompositionEN.zxShareId == "[null]") objzx_CompositionEN.zxShareId = null; //分享Id
if (objzx_CompositionEN.UpdUser == "[null]") objzx_CompositionEN.UpdUser = null; //修改人
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
public static void CheckPropertyNew(clszx_CompositionEN objzx_CompositionEN)
{
 zx_CompositionDA.CheckPropertyNew(objzx_CompositionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_CompositionEN objzx_CompositionEN)
{
 zx_CompositionDA.CheckProperty4Condition(objzx_CompositionEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_zxPaperId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conzx_Composition.zxPaperId); 
List<clszx_CompositionEN> arrObjLst = clszx_CompositionBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clszx_CompositionEN objzx_CompositionEN = new clszx_CompositionEN()
{
zxPaperId = "0",
PaperName = "选[作文表]..."
};
arrObjLst.Insert(0, objzx_CompositionEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conzx_Composition.zxPaperId;
objComboBox.DisplayMember = conzx_Composition.PaperName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_zxPaperId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[作文表]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conzx_Composition.zxPaperId); 
IEnumerable<clszx_CompositionEN> arrObjLst = clszx_CompositionBL.GetObjLst(strCondition);
objDDL.DataValueField = conzx_Composition.zxPaperId;
objDDL.DataTextField = conzx_Composition.PaperName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_zxPaperIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[作文表]...","0");
List<clszx_CompositionEN> arrzx_CompositionObjLst = GetAllzx_CompositionObjLstCache(); 
objDDL.DataValueField = conzx_Composition.zxPaperId;
objDDL.DataTextField = conzx_Composition.PaperName;
objDDL.DataSource = arrzx_CompositionObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clszx_CompositionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_CompositionBL没有刷新缓存机制(clszx_CompositionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxPaperId");
//if (arrzx_CompositionObjLstCache == null)
//{
//arrzx_CompositionObjLstCache = zx_CompositionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxPaperId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_CompositionEN GetObjByzxPaperIdCache(string strzxPaperId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_CompositionEN._CurrTabName);
List<clszx_CompositionEN> arrzx_CompositionObjLstCache = GetObjLstCache();
IEnumerable <clszx_CompositionEN> arrzx_CompositionObjLst_Sel =
arrzx_CompositionObjLstCache
.Where(x=> x.zxPaperId == strzxPaperId 
);
if (arrzx_CompositionObjLst_Sel.Count() == 0)
{
   clszx_CompositionEN obj = clszx_CompositionBL.GetObjByzxPaperId(strzxPaperId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_CompositionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strzxPaperId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPaperNameByzxPaperIdCache(string strzxPaperId)
{
if (string.IsNullOrEmpty(strzxPaperId) == true) return "";
//获取缓存中的对象列表
clszx_CompositionEN objzx_Composition = GetObjByzxPaperIdCache(strzxPaperId);
if (objzx_Composition == null) return "";
return objzx_Composition.PaperName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strzxPaperId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByzxPaperIdCache(string strzxPaperId)
{
if (string.IsNullOrEmpty(strzxPaperId) == true) return "";
//获取缓存中的对象列表
clszx_CompositionEN objzx_Composition = GetObjByzxPaperIdCache(strzxPaperId);
if (objzx_Composition == null) return "";
return objzx_Composition.PaperName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_CompositionEN> GetAllzx_CompositionObjLstCache()
{
//获取缓存中的对象列表
List<clszx_CompositionEN> arrzx_CompositionObjLstCache = GetObjLstCache(); 
return arrzx_CompositionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_CompositionEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_CompositionEN._CurrTabName);
List<clszx_CompositionEN> arrzx_CompositionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_CompositionObjLstCache;
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
string strKey = string.Format("{0}", clszx_CompositionEN._CurrTabName);
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clszx_CompositionBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_CompositionEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_CompositionBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_Composition(作文表)
 /// 唯一性条件:zxPaperId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_CompositionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_CompositionEN objzx_CompositionEN)
{
//检测记录是否存在
string strResult = zx_CompositionDA.GetUniCondStr(objzx_CompositionEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-11-15
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strzxPaperId)
{
if (strInFldName != conzx_Composition.zxPaperId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_Composition.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_Composition.AttributeName));
throw new Exception(strMsg);
}
var objzx_Composition = clszx_CompositionBL.GetObjByzxPaperIdCache(strzxPaperId);
if (objzx_Composition == null) return "";
return objzx_Composition[strOutFldName].ToString();
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
int intRecCount = clszx_CompositionDA.GetRecCount(strTabName);
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
int intRecCount = clszx_CompositionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_CompositionDA.GetRecCount();
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
int intRecCount = clszx_CompositionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_CompositionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_CompositionEN objzx_CompositionCond)
{
List<clszx_CompositionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_CompositionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_Composition.AttributeName)
{
if (objzx_CompositionCond.IsUpdated(strFldName) == false) continue;
if (objzx_CompositionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_CompositionCond[strFldName].ToString());
}
else
{
if (objzx_CompositionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_CompositionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_CompositionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_CompositionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_CompositionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_CompositionCond[strFldName]));
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
 List<string> arrList = clszx_CompositionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_CompositionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_CompositionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_CompositionDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_CompositionDA.SetFldValue(clszx_CompositionEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_CompositionDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_CompositionDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_CompositionDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_CompositionDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_Composition] "); 
 strCreateTabCode.Append(" ( "); 
 // /**论文Id*/ 
 strCreateTabCode.Append(" zxPaperId char(8) primary key, "); 
 // /**论文标题*/ 
 strCreateTabCode.Append(" PaperTitle varchar(500) not Null, "); 
 // /**主题名称*/ 
 strCreateTabCode.Append(" PaperName varchar(500) Null, "); 
 // /**主题内容*/ 
 strCreateTabCode.Append(" PaperContent text Null, "); 
 // /**期刊*/ 
 strCreateTabCode.Append(" Periodical varchar(100) Null, "); 
 // /**作者*/ 
 strCreateTabCode.Append(" Author varchar(200) Null, "); 
 // /**研究问题*/ 
 strCreateTabCode.Append(" ResearchQuestion varchar(2000) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
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
 // /**作文类型Id*/ 
 strCreateTabCode.Append(" zxLiteratureTypeId char(2) not Null, "); 
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
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**论文类型Id*/ 
 strCreateTabCode.Append(" PaperTypeId char(2) Null, "); 
 // /**论文状态Id*/ 
 strCreateTabCode.Append(" zxPaperStatusId char(2) Null, "); 
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
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**分享Id*/ 
 strCreateTabCode.Append(" zxShareId char(2) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**论文答疑数*/ 
 strCreateTabCode.Append(" PaperQCount int Null, "); 
 // /**论文子观点数*/ 
 strCreateTabCode.Append(" SubVCount int Null, "); 
 // /**论文标注数*/ 
 strCreateTabCode.Append(" TagsCount int Null, "); 
 // /**教师提问数*/ 
 strCreateTabCode.Append(" TeaQCount int Null, "); 
 // /**小组Id*/ 
 strCreateTabCode.Append(" GroupTextId char(8) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 作文表(zx_Composition)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_Composition : clsCommFun4BL
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
clszx_CompositionBL.ReFreshThisCache();
}
}

}