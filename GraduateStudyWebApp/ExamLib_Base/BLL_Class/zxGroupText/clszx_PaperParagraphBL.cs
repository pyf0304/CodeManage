
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_PaperParagraphBL
 表名:zx_PaperParagraph(01120759)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:07:49
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
public static class  clszx_PaperParagraphBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxParagraphId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_PaperParagraphEN GetObj(this K_zxParagraphId_zx_PaperParagraph myKey)
{
clszx_PaperParagraphEN objzx_PaperParagraphEN = clszx_PaperParagraphBL.zx_PaperParagraphDA.GetObjByzxParagraphId(myKey.Value);
return objzx_PaperParagraphEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_PaperParagraphEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_PaperParagraphEN objzx_PaperParagraphEN)
{
if (CheckUniqueness(objzx_PaperParagraphEN) == false)
{
var strMsg = string.Format("记录已经存在!段落Id = [{0}]的数据已经存在!(in clszx_PaperParagraphBL.AddNewRecord)", objzx_PaperParagraphEN.zxParagraphId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_PaperParagraphEN.zxParagraphId) == true || clszx_PaperParagraphBL.IsExist(objzx_PaperParagraphEN.zxParagraphId) == true)
 {
     objzx_PaperParagraphEN.zxParagraphId = clszx_PaperParagraphBL.GetMaxStrId_S();
 }
bool bolResult = clszx_PaperParagraphBL.zx_PaperParagraphDA.AddNewRecordBySQL2(objzx_PaperParagraphEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_PaperParagraphBL.ReFreshCache();

if (clszx_PaperParagraphBL.relatedActions != null)
{
clszx_PaperParagraphBL.relatedActions.UpdRelaTabDate(objzx_PaperParagraphEN.zxParagraphId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_PaperParagraphEN objzx_PaperParagraphEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clszx_PaperParagraphBL.IsExist(objzx_PaperParagraphEN.zxParagraphId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objzx_PaperParagraphEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_PaperParagraphEN.CheckUniqueness() == false)
{
strMsg = string.Format("(段落Id(zxParagraphId)=[{0}])已经存在,不能重复!", objzx_PaperParagraphEN.zxParagraphId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objzx_PaperParagraphEN.zxParagraphId) == true || clszx_PaperParagraphBL.IsExist(objzx_PaperParagraphEN.zxParagraphId) == true)
 {
     objzx_PaperParagraphEN.zxParagraphId = clszx_PaperParagraphBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objzx_PaperParagraphEN.AddNewRecord();
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
 /// <param name = "objzx_PaperParagraphEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clszx_PaperParagraphEN objzx_PaperParagraphEN)
{
if (CheckUniqueness(objzx_PaperParagraphEN) == false)
{
var strMsg = string.Format("记录已经存在!段落Id = [{0}]的数据已经存在!(in clszx_PaperParagraphBL.AddNewRecordWithMaxId)", objzx_PaperParagraphEN.zxParagraphId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_PaperParagraphEN.zxParagraphId) == true || clszx_PaperParagraphBL.IsExist(objzx_PaperParagraphEN.zxParagraphId) == true)
 {
     objzx_PaperParagraphEN.zxParagraphId = clszx_PaperParagraphBL.GetMaxStrId_S();
 }
string strzxParagraphId = clszx_PaperParagraphBL.zx_PaperParagraphDA.AddNewRecordBySQL2WithReturnKey(objzx_PaperParagraphEN);
     objzx_PaperParagraphEN.zxParagraphId = strzxParagraphId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_PaperParagraphBL.ReFreshCache();

if (clszx_PaperParagraphBL.relatedActions != null)
{
clszx_PaperParagraphBL.relatedActions.UpdRelaTabDate(objzx_PaperParagraphEN.zxParagraphId, "SetUpdDate");
}
return strzxParagraphId;
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
 /// <param name = "objzx_PaperParagraphEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_PaperParagraphEN objzx_PaperParagraphEN)
{
if (CheckUniqueness(objzx_PaperParagraphEN) == false)
{
var strMsg = string.Format("记录已经存在!段落Id = [{0}]的数据已经存在!(in clszx_PaperParagraphBL.AddNewRecordWithReturnKey)", objzx_PaperParagraphEN.zxParagraphId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_PaperParagraphEN.zxParagraphId) == true || clszx_PaperParagraphBL.IsExist(objzx_PaperParagraphEN.zxParagraphId) == true)
 {
     objzx_PaperParagraphEN.zxParagraphId = clszx_PaperParagraphBL.GetMaxStrId_S();
 }
string strKey = clszx_PaperParagraphBL.zx_PaperParagraphDA.AddNewRecordBySQL2WithReturnKey(objzx_PaperParagraphEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_PaperParagraphBL.ReFreshCache();

if (clszx_PaperParagraphBL.relatedActions != null)
{
clszx_PaperParagraphBL.relatedActions.UpdRelaTabDate(objzx_PaperParagraphEN.zxParagraphId, "SetUpdDate");
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
 /// <param name = "objzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_PaperParagraphEN SetzxParagraphId(this clszx_PaperParagraphEN objzx_PaperParagraphEN, string strzxParagraphId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxParagraphId, 10, conzx_PaperParagraph.zxParagraphId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxParagraphId, 10, conzx_PaperParagraph.zxParagraphId);
}
objzx_PaperParagraphEN.zxParagraphId = strzxParagraphId; //段落Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(conzx_PaperParagraph.zxParagraphId) == false)
{
objzx_PaperParagraphEN.dicFldComparisonOp.Add(conzx_PaperParagraph.zxParagraphId, strComparisonOp);
}
else
{
objzx_PaperParagraphEN.dicFldComparisonOp[conzx_PaperParagraph.zxParagraphId] = strComparisonOp;
}
}
return objzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_PaperParagraphEN SetTextId(this clszx_PaperParagraphEN objzx_PaperParagraphEN, string strTextId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextId, conzx_PaperParagraph.TextId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, conzx_PaperParagraph.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, conzx_PaperParagraph.TextId);
}
objzx_PaperParagraphEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(conzx_PaperParagraph.TextId) == false)
{
objzx_PaperParagraphEN.dicFldComparisonOp.Add(conzx_PaperParagraph.TextId, strComparisonOp);
}
else
{
objzx_PaperParagraphEN.dicFldComparisonOp[conzx_PaperParagraph.TextId] = strComparisonOp;
}
}
return objzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_PaperParagraphEN SetzxSectionId(this clszx_PaperParagraphEN objzx_PaperParagraphEN, string strzxSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxSectionId, conzx_PaperParagraph.zxSectionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxSectionId, 8, conzx_PaperParagraph.zxSectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxSectionId, 8, conzx_PaperParagraph.zxSectionId);
}
objzx_PaperParagraphEN.zxSectionId = strzxSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(conzx_PaperParagraph.zxSectionId) == false)
{
objzx_PaperParagraphEN.dicFldComparisonOp.Add(conzx_PaperParagraph.zxSectionId, strComparisonOp);
}
else
{
objzx_PaperParagraphEN.dicFldComparisonOp[conzx_PaperParagraph.zxSectionId] = strComparisonOp;
}
}
return objzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_PaperParagraphEN SetzxParagraphStateId(this clszx_PaperParagraphEN objzx_PaperParagraphEN, string strzxParagraphStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxParagraphStateId, conzx_PaperParagraph.zxParagraphStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxParagraphStateId, 2, conzx_PaperParagraph.zxParagraphStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxParagraphStateId, 2, conzx_PaperParagraph.zxParagraphStateId);
}
objzx_PaperParagraphEN.zxParagraphStateId = strzxParagraphStateId; //段落状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(conzx_PaperParagraph.zxParagraphStateId) == false)
{
objzx_PaperParagraphEN.dicFldComparisonOp.Add(conzx_PaperParagraph.zxParagraphStateId, strComparisonOp);
}
else
{
objzx_PaperParagraphEN.dicFldComparisonOp[conzx_PaperParagraph.zxParagraphStateId] = strComparisonOp;
}
}
return objzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_PaperParagraphEN SetzxParagraphTypeId(this clszx_PaperParagraphEN objzx_PaperParagraphEN, string strzxParagraphTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxParagraphTypeId, conzx_PaperParagraph.zxParagraphTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxParagraphTypeId, 2, conzx_PaperParagraph.zxParagraphTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxParagraphTypeId, 2, conzx_PaperParagraph.zxParagraphTypeId);
}
objzx_PaperParagraphEN.zxParagraphTypeId = strzxParagraphTypeId; //段落类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(conzx_PaperParagraph.zxParagraphTypeId) == false)
{
objzx_PaperParagraphEN.dicFldComparisonOp.Add(conzx_PaperParagraph.zxParagraphTypeId, strComparisonOp);
}
else
{
objzx_PaperParagraphEN.dicFldComparisonOp[conzx_PaperParagraph.zxParagraphTypeId] = strComparisonOp;
}
}
return objzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_PaperParagraphEN SetParagraphContent(this clszx_PaperParagraphEN objzx_PaperParagraphEN, string strParagraphContent, string strComparisonOp="")
	{
objzx_PaperParagraphEN.ParagraphContent = strParagraphContent; //段落内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(conzx_PaperParagraph.ParagraphContent) == false)
{
objzx_PaperParagraphEN.dicFldComparisonOp.Add(conzx_PaperParagraph.ParagraphContent, strComparisonOp);
}
else
{
objzx_PaperParagraphEN.dicFldComparisonOp[conzx_PaperParagraph.ParagraphContent] = strComparisonOp;
}
}
return objzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_PaperParagraphEN SetVoteCount(this clszx_PaperParagraphEN objzx_PaperParagraphEN, int? intVoteCount, string strComparisonOp="")
	{
objzx_PaperParagraphEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(conzx_PaperParagraph.VoteCount) == false)
{
objzx_PaperParagraphEN.dicFldComparisonOp.Add(conzx_PaperParagraph.VoteCount, strComparisonOp);
}
else
{
objzx_PaperParagraphEN.dicFldComparisonOp[conzx_PaperParagraph.VoteCount] = strComparisonOp;
}
}
return objzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_PaperParagraphEN SetCommentCount(this clszx_PaperParagraphEN objzx_PaperParagraphEN, int? intCommentCount, string strComparisonOp="")
	{
objzx_PaperParagraphEN.CommentCount = intCommentCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(conzx_PaperParagraph.CommentCount) == false)
{
objzx_PaperParagraphEN.dicFldComparisonOp.Add(conzx_PaperParagraph.CommentCount, strComparisonOp);
}
else
{
objzx_PaperParagraphEN.dicFldComparisonOp[conzx_PaperParagraph.CommentCount] = strComparisonOp;
}
}
return objzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_PaperParagraphEN SetVersionCount(this clszx_PaperParagraphEN objzx_PaperParagraphEN, int? intVersionCount, string strComparisonOp="")
	{
objzx_PaperParagraphEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(conzx_PaperParagraph.VersionCount) == false)
{
objzx_PaperParagraphEN.dicFldComparisonOp.Add(conzx_PaperParagraph.VersionCount, strComparisonOp);
}
else
{
objzx_PaperParagraphEN.dicFldComparisonOp[conzx_PaperParagraph.VersionCount] = strComparisonOp;
}
}
return objzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_PaperParagraphEN SetCreateDate(this clszx_PaperParagraphEN objzx_PaperParagraphEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conzx_PaperParagraph.CreateDate);
}
objzx_PaperParagraphEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(conzx_PaperParagraph.CreateDate) == false)
{
objzx_PaperParagraphEN.dicFldComparisonOp.Add(conzx_PaperParagraph.CreateDate, strComparisonOp);
}
else
{
objzx_PaperParagraphEN.dicFldComparisonOp[conzx_PaperParagraph.CreateDate] = strComparisonOp;
}
}
return objzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_PaperParagraphEN SetCreateUser(this clszx_PaperParagraphEN objzx_PaperParagraphEN, string strCreateUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUser, 50, conzx_PaperParagraph.CreateUser);
}
objzx_PaperParagraphEN.CreateUser = strCreateUser; //建立用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(conzx_PaperParagraph.CreateUser) == false)
{
objzx_PaperParagraphEN.dicFldComparisonOp.Add(conzx_PaperParagraph.CreateUser, strComparisonOp);
}
else
{
objzx_PaperParagraphEN.dicFldComparisonOp[conzx_PaperParagraph.CreateUser] = strComparisonOp;
}
}
return objzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_PaperParagraphEN SetUpdDate(this clszx_PaperParagraphEN objzx_PaperParagraphEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_PaperParagraph.UpdDate);
}
objzx_PaperParagraphEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(conzx_PaperParagraph.UpdDate) == false)
{
objzx_PaperParagraphEN.dicFldComparisonOp.Add(conzx_PaperParagraph.UpdDate, strComparisonOp);
}
else
{
objzx_PaperParagraphEN.dicFldComparisonOp[conzx_PaperParagraph.UpdDate] = strComparisonOp;
}
}
return objzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_PaperParagraphEN SetUpdUser(this clszx_PaperParagraphEN objzx_PaperParagraphEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_PaperParagraph.UpdUser);
}
objzx_PaperParagraphEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(conzx_PaperParagraph.UpdUser) == false)
{
objzx_PaperParagraphEN.dicFldComparisonOp.Add(conzx_PaperParagraph.UpdUser, strComparisonOp);
}
else
{
objzx_PaperParagraphEN.dicFldComparisonOp[conzx_PaperParagraph.UpdUser] = strComparisonOp;
}
}
return objzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_PaperParagraphEN SetMemo(this clszx_PaperParagraphEN objzx_PaperParagraphEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_PaperParagraph.Memo);
}
objzx_PaperParagraphEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(conzx_PaperParagraph.Memo) == false)
{
objzx_PaperParagraphEN.dicFldComparisonOp.Add(conzx_PaperParagraph.Memo, strComparisonOp);
}
else
{
objzx_PaperParagraphEN.dicFldComparisonOp[conzx_PaperParagraph.Memo] = strComparisonOp;
}
}
return objzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_PaperParagraphEN SetOrderNum(this clszx_PaperParagraphEN objzx_PaperParagraphEN, int? intOrderNum, string strComparisonOp="")
	{
objzx_PaperParagraphEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(conzx_PaperParagraph.OrderNum) == false)
{
objzx_PaperParagraphEN.dicFldComparisonOp.Add(conzx_PaperParagraph.OrderNum, strComparisonOp);
}
else
{
objzx_PaperParagraphEN.dicFldComparisonOp[conzx_PaperParagraph.OrderNum] = strComparisonOp;
}
}
return objzx_PaperParagraphEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_PaperParagraphEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_PaperParagraphEN objzx_PaperParagraphEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_PaperParagraphEN.CheckPropertyNew();
clszx_PaperParagraphEN objzx_PaperParagraphCond = new clszx_PaperParagraphEN();
string strCondition = objzx_PaperParagraphCond
.SetzxParagraphId(objzx_PaperParagraphEN.zxParagraphId, "<>")
.SetzxParagraphId(objzx_PaperParagraphEN.zxParagraphId, "=")
.GetCombineCondition();
objzx_PaperParagraphEN._IsCheckProperty = true;
bool bolIsExist = clszx_PaperParagraphBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ParagraphId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_PaperParagraphEN.Update();
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
 /// <param name = "objzx_PaperParagraph">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_PaperParagraphEN objzx_PaperParagraph)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_PaperParagraphEN objzx_PaperParagraphCond = new clszx_PaperParagraphEN();
string strCondition = objzx_PaperParagraphCond
.SetzxParagraphId(objzx_PaperParagraph.zxParagraphId, "=")
.GetCombineCondition();
objzx_PaperParagraph._IsCheckProperty = true;
bool bolIsExist = clszx_PaperParagraphBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_PaperParagraph.zxParagraphId = clszx_PaperParagraphBL.GetFirstID_S(strCondition);
objzx_PaperParagraph.UpdateWithCondition(strCondition);
}
else
{
objzx_PaperParagraph.zxParagraphId = clszx_PaperParagraphBL.GetMaxStrId_S();
objzx_PaperParagraph.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_PaperParagraphEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_PaperParagraphEN objzx_PaperParagraphEN)
{
 if (string.IsNullOrEmpty(objzx_PaperParagraphEN.zxParagraphId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_PaperParagraphBL.zx_PaperParagraphDA.UpdateBySql2(objzx_PaperParagraphEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_PaperParagraphBL.ReFreshCache();

if (clszx_PaperParagraphBL.relatedActions != null)
{
clszx_PaperParagraphBL.relatedActions.UpdRelaTabDate(objzx_PaperParagraphEN.zxParagraphId, "SetUpdDate");
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
 /// <param name = "objzx_PaperParagraphEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_PaperParagraphEN objzx_PaperParagraphEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_PaperParagraphEN.zxParagraphId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_PaperParagraphBL.zx_PaperParagraphDA.UpdateBySql2(objzx_PaperParagraphEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_PaperParagraphBL.ReFreshCache();

if (clszx_PaperParagraphBL.relatedActions != null)
{
clszx_PaperParagraphBL.relatedActions.UpdRelaTabDate(objzx_PaperParagraphEN.zxParagraphId, "SetUpdDate");
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
 /// <param name = "objzx_PaperParagraphEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_PaperParagraphEN objzx_PaperParagraphEN, string strWhereCond)
{
try
{
bool bolResult = clszx_PaperParagraphBL.zx_PaperParagraphDA.UpdateBySqlWithCondition(objzx_PaperParagraphEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_PaperParagraphBL.ReFreshCache();

if (clszx_PaperParagraphBL.relatedActions != null)
{
clszx_PaperParagraphBL.relatedActions.UpdRelaTabDate(objzx_PaperParagraphEN.zxParagraphId, "SetUpdDate");
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
 /// <param name = "objzx_PaperParagraphEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_PaperParagraphEN objzx_PaperParagraphEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_PaperParagraphBL.zx_PaperParagraphDA.UpdateBySqlWithConditionTransaction(objzx_PaperParagraphEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_PaperParagraphBL.ReFreshCache();

if (clszx_PaperParagraphBL.relatedActions != null)
{
clszx_PaperParagraphBL.relatedActions.UpdRelaTabDate(objzx_PaperParagraphEN.zxParagraphId, "SetUpdDate");
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
 /// <param name = "strzxParagraphId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_PaperParagraphEN objzx_PaperParagraphEN)
{
try
{
int intRecNum = clszx_PaperParagraphBL.zx_PaperParagraphDA.DelRecord(objzx_PaperParagraphEN.zxParagraphId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_PaperParagraphBL.ReFreshCache();

if (clszx_PaperParagraphBL.relatedActions != null)
{
clszx_PaperParagraphBL.relatedActions.UpdRelaTabDate(objzx_PaperParagraphEN.zxParagraphId, "SetUpdDate");
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
 /// <param name = "objzx_PaperParagraphENS">源对象</param>
 /// <param name = "objzx_PaperParagraphENT">目标对象</param>
 public static void CopyTo(this clszx_PaperParagraphEN objzx_PaperParagraphENS, clszx_PaperParagraphEN objzx_PaperParagraphENT)
{
try
{
objzx_PaperParagraphENT.zxParagraphId = objzx_PaperParagraphENS.zxParagraphId; //段落Id
objzx_PaperParagraphENT.TextId = objzx_PaperParagraphENS.TextId; //课件Id
objzx_PaperParagraphENT.zxSectionId = objzx_PaperParagraphENS.zxSectionId; //节Id
objzx_PaperParagraphENT.zxParagraphStateId = objzx_PaperParagraphENS.zxParagraphStateId; //段落状态Id
objzx_PaperParagraphENT.zxParagraphTypeId = objzx_PaperParagraphENS.zxParagraphTypeId; //段落类型Id
objzx_PaperParagraphENT.ParagraphContent = objzx_PaperParagraphENS.ParagraphContent; //段落内容
objzx_PaperParagraphENT.VoteCount = objzx_PaperParagraphENS.VoteCount; //点赞计数
objzx_PaperParagraphENT.CommentCount = objzx_PaperParagraphENS.CommentCount; //评论数
objzx_PaperParagraphENT.VersionCount = objzx_PaperParagraphENS.VersionCount; //版本统计
objzx_PaperParagraphENT.CreateDate = objzx_PaperParagraphENS.CreateDate; //建立日期
objzx_PaperParagraphENT.CreateUser = objzx_PaperParagraphENS.CreateUser; //建立用户
objzx_PaperParagraphENT.UpdDate = objzx_PaperParagraphENS.UpdDate; //修改日期
objzx_PaperParagraphENT.UpdUser = objzx_PaperParagraphENS.UpdUser; //修改人
objzx_PaperParagraphENT.Memo = objzx_PaperParagraphENS.Memo; //备注
objzx_PaperParagraphENT.OrderNum = objzx_PaperParagraphENS.OrderNum; //序号
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
 /// <param name = "objzx_PaperParagraphENS">源对象</param>
 /// <returns>目标对象=>clszx_PaperParagraphEN:objzx_PaperParagraphENT</returns>
 public static clszx_PaperParagraphEN CopyTo(this clszx_PaperParagraphEN objzx_PaperParagraphENS)
{
try
{
 clszx_PaperParagraphEN objzx_PaperParagraphENT = new clszx_PaperParagraphEN()
{
zxParagraphId = objzx_PaperParagraphENS.zxParagraphId, //段落Id
TextId = objzx_PaperParagraphENS.TextId, //课件Id
zxSectionId = objzx_PaperParagraphENS.zxSectionId, //节Id
zxParagraphStateId = objzx_PaperParagraphENS.zxParagraphStateId, //段落状态Id
zxParagraphTypeId = objzx_PaperParagraphENS.zxParagraphTypeId, //段落类型Id
ParagraphContent = objzx_PaperParagraphENS.ParagraphContent, //段落内容
VoteCount = objzx_PaperParagraphENS.VoteCount, //点赞计数
CommentCount = objzx_PaperParagraphENS.CommentCount, //评论数
VersionCount = objzx_PaperParagraphENS.VersionCount, //版本统计
CreateDate = objzx_PaperParagraphENS.CreateDate, //建立日期
CreateUser = objzx_PaperParagraphENS.CreateUser, //建立用户
UpdDate = objzx_PaperParagraphENS.UpdDate, //修改日期
UpdUser = objzx_PaperParagraphENS.UpdUser, //修改人
Memo = objzx_PaperParagraphENS.Memo, //备注
OrderNum = objzx_PaperParagraphENS.OrderNum, //序号
};
 return objzx_PaperParagraphENT;
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
public static void CheckPropertyNew(this clszx_PaperParagraphEN objzx_PaperParagraphEN)
{
 clszx_PaperParagraphBL.zx_PaperParagraphDA.CheckPropertyNew(objzx_PaperParagraphEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_PaperParagraphEN objzx_PaperParagraphEN)
{
 clszx_PaperParagraphBL.zx_PaperParagraphDA.CheckProperty4Condition(objzx_PaperParagraphEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_PaperParagraphEN objzx_PaperParagraphCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_PaperParagraphCond.IsUpdated(conzx_PaperParagraph.zxParagraphId) == true)
{
string strComparisonOpzxParagraphId = objzx_PaperParagraphCond.dicFldComparisonOp[conzx_PaperParagraph.zxParagraphId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_PaperParagraph.zxParagraphId, objzx_PaperParagraphCond.zxParagraphId, strComparisonOpzxParagraphId);
}
if (objzx_PaperParagraphCond.IsUpdated(conzx_PaperParagraph.TextId) == true)
{
string strComparisonOpTextId = objzx_PaperParagraphCond.dicFldComparisonOp[conzx_PaperParagraph.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_PaperParagraph.TextId, objzx_PaperParagraphCond.TextId, strComparisonOpTextId);
}
if (objzx_PaperParagraphCond.IsUpdated(conzx_PaperParagraph.zxSectionId) == true)
{
string strComparisonOpzxSectionId = objzx_PaperParagraphCond.dicFldComparisonOp[conzx_PaperParagraph.zxSectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_PaperParagraph.zxSectionId, objzx_PaperParagraphCond.zxSectionId, strComparisonOpzxSectionId);
}
if (objzx_PaperParagraphCond.IsUpdated(conzx_PaperParagraph.zxParagraphStateId) == true)
{
string strComparisonOpzxParagraphStateId = objzx_PaperParagraphCond.dicFldComparisonOp[conzx_PaperParagraph.zxParagraphStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_PaperParagraph.zxParagraphStateId, objzx_PaperParagraphCond.zxParagraphStateId, strComparisonOpzxParagraphStateId);
}
if (objzx_PaperParagraphCond.IsUpdated(conzx_PaperParagraph.zxParagraphTypeId) == true)
{
string strComparisonOpzxParagraphTypeId = objzx_PaperParagraphCond.dicFldComparisonOp[conzx_PaperParagraph.zxParagraphTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_PaperParagraph.zxParagraphTypeId, objzx_PaperParagraphCond.zxParagraphTypeId, strComparisonOpzxParagraphTypeId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objzx_PaperParagraphCond.IsUpdated(conzx_PaperParagraph.VoteCount) == true)
{
string strComparisonOpVoteCount = objzx_PaperParagraphCond.dicFldComparisonOp[conzx_PaperParagraph.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_PaperParagraph.VoteCount, objzx_PaperParagraphCond.VoteCount, strComparisonOpVoteCount);
}
if (objzx_PaperParagraphCond.IsUpdated(conzx_PaperParagraph.CommentCount) == true)
{
string strComparisonOpCommentCount = objzx_PaperParagraphCond.dicFldComparisonOp[conzx_PaperParagraph.CommentCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_PaperParagraph.CommentCount, objzx_PaperParagraphCond.CommentCount, strComparisonOpCommentCount);
}
if (objzx_PaperParagraphCond.IsUpdated(conzx_PaperParagraph.VersionCount) == true)
{
string strComparisonOpVersionCount = objzx_PaperParagraphCond.dicFldComparisonOp[conzx_PaperParagraph.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_PaperParagraph.VersionCount, objzx_PaperParagraphCond.VersionCount, strComparisonOpVersionCount);
}
if (objzx_PaperParagraphCond.IsUpdated(conzx_PaperParagraph.CreateDate) == true)
{
string strComparisonOpCreateDate = objzx_PaperParagraphCond.dicFldComparisonOp[conzx_PaperParagraph.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_PaperParagraph.CreateDate, objzx_PaperParagraphCond.CreateDate, strComparisonOpCreateDate);
}
if (objzx_PaperParagraphCond.IsUpdated(conzx_PaperParagraph.CreateUser) == true)
{
string strComparisonOpCreateUser = objzx_PaperParagraphCond.dicFldComparisonOp[conzx_PaperParagraph.CreateUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_PaperParagraph.CreateUser, objzx_PaperParagraphCond.CreateUser, strComparisonOpCreateUser);
}
if (objzx_PaperParagraphCond.IsUpdated(conzx_PaperParagraph.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_PaperParagraphCond.dicFldComparisonOp[conzx_PaperParagraph.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_PaperParagraph.UpdDate, objzx_PaperParagraphCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_PaperParagraphCond.IsUpdated(conzx_PaperParagraph.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_PaperParagraphCond.dicFldComparisonOp[conzx_PaperParagraph.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_PaperParagraph.UpdUser, objzx_PaperParagraphCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_PaperParagraphCond.IsUpdated(conzx_PaperParagraph.Memo) == true)
{
string strComparisonOpMemo = objzx_PaperParagraphCond.dicFldComparisonOp[conzx_PaperParagraph.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_PaperParagraph.Memo, objzx_PaperParagraphCond.Memo, strComparisonOpMemo);
}
if (objzx_PaperParagraphCond.IsUpdated(conzx_PaperParagraph.OrderNum) == true)
{
string strComparisonOpOrderNum = objzx_PaperParagraphCond.dicFldComparisonOp[conzx_PaperParagraph.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_PaperParagraph.OrderNum, objzx_PaperParagraphCond.OrderNum, strComparisonOpOrderNum);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_PaperParagraph(作文段落表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ParagraphId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_PaperParagraphEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_PaperParagraphEN objzx_PaperParagraphEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_PaperParagraphEN == null) return true;
if (objzx_PaperParagraphEN.zxParagraphId == null || objzx_PaperParagraphEN.zxParagraphId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxParagraphId = '{0}'", objzx_PaperParagraphEN.zxParagraphId);
if (clszx_PaperParagraphBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("zxParagraphId !=  '{0}'", objzx_PaperParagraphEN.zxParagraphId);
 sbCondition.AppendFormat(" and zxParagraphId = '{0}'", objzx_PaperParagraphEN.zxParagraphId);
if (clszx_PaperParagraphBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_PaperParagraph(作文段落表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ParagraphId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_PaperParagraphEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_PaperParagraphEN objzx_PaperParagraphEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_PaperParagraphEN == null) return "";
if (objzx_PaperParagraphEN.zxParagraphId == null || objzx_PaperParagraphEN.zxParagraphId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxParagraphId = '{0}'", objzx_PaperParagraphEN.zxParagraphId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("zxParagraphId !=  '{0}'", objzx_PaperParagraphEN.zxParagraphId);
 sbCondition.AppendFormat(" and zxParagraphId = '{0}'", objzx_PaperParagraphEN.zxParagraphId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_PaperParagraph
{
public virtual bool UpdRelaTabDate(string strzxParagraphId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 作文段落表(zx_PaperParagraph)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_PaperParagraphBL
{
public static RelatedActions_zx_PaperParagraph relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_PaperParagraphDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_PaperParagraphDA zx_PaperParagraphDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_PaperParagraphDA();
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
 public clszx_PaperParagraphBL()
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
if (string.IsNullOrEmpty(clszx_PaperParagraphEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_PaperParagraphEN._ConnectString);
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
public static DataTable GetDataTable_zx_PaperParagraph(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_PaperParagraphDA.GetDataTable_zx_PaperParagraph(strWhereCond);
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
objDT = zx_PaperParagraphDA.GetDataTable(strWhereCond);
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
objDT = zx_PaperParagraphDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_PaperParagraphDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_PaperParagraphDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_PaperParagraphDA.GetDataTable_Top(objTopPara);
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
objDT = zx_PaperParagraphDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_PaperParagraphDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_PaperParagraphDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxParagraphIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_PaperParagraphEN> GetObjLstByZxParagraphIdLst(List<string> arrZxParagraphIdLst)
{
List<clszx_PaperParagraphEN> arrObjLst = new List<clszx_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxParagraphIdLst, true);
 string strWhereCond = string.Format("zxParagraphId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_PaperParagraphEN objzx_PaperParagraphEN = new clszx_PaperParagraphEN();
try
{
objzx_PaperParagraphEN.zxParagraphId = objRow[conzx_PaperParagraph.zxParagraphId].ToString().Trim(); //段落Id
objzx_PaperParagraphEN.TextId = objRow[conzx_PaperParagraph.TextId].ToString().Trim(); //课件Id
objzx_PaperParagraphEN.zxSectionId = objRow[conzx_PaperParagraph.zxSectionId].ToString().Trim(); //节Id
objzx_PaperParagraphEN.zxParagraphStateId = objRow[conzx_PaperParagraph.zxParagraphStateId].ToString().Trim(); //段落状态Id
objzx_PaperParagraphEN.zxParagraphTypeId = objRow[conzx_PaperParagraph.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objzx_PaperParagraphEN.ParagraphContent = objRow[conzx_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[conzx_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objzx_PaperParagraphEN.VoteCount = objRow[conzx_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objzx_PaperParagraphEN.CommentCount = objRow[conzx_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objzx_PaperParagraphEN.VersionCount = objRow[conzx_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objzx_PaperParagraphEN.CreateDate = objRow[conzx_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[conzx_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objzx_PaperParagraphEN.CreateUser = objRow[conzx_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[conzx_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objzx_PaperParagraphEN.UpdDate = objRow[conzx_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[conzx_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objzx_PaperParagraphEN.UpdUser = objRow[conzx_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[conzx_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objzx_PaperParagraphEN.Memo = objRow[conzx_PaperParagraph.Memo] == DBNull.Value ? null : objRow[conzx_PaperParagraph.Memo].ToString().Trim(); //备注
objzx_PaperParagraphEN.OrderNum = objRow[conzx_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_PaperParagraphEN.zxParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_PaperParagraphEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxParagraphIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_PaperParagraphEN> GetObjLstByZxParagraphIdLstCache(List<string> arrZxParagraphIdLst)
{
string strKey = string.Format("{0}", clszx_PaperParagraphEN._CurrTabName);
List<clszx_PaperParagraphEN> arrzx_PaperParagraphObjLstCache = GetObjLstCache();
IEnumerable <clszx_PaperParagraphEN> arrzx_PaperParagraphObjLst_Sel =
arrzx_PaperParagraphObjLstCache
.Where(x => arrZxParagraphIdLst.Contains(x.zxParagraphId));
return arrzx_PaperParagraphObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_PaperParagraphEN> GetObjLst(string strWhereCond)
{
List<clszx_PaperParagraphEN> arrObjLst = new List<clszx_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_PaperParagraphEN objzx_PaperParagraphEN = new clszx_PaperParagraphEN();
try
{
objzx_PaperParagraphEN.zxParagraphId = objRow[conzx_PaperParagraph.zxParagraphId].ToString().Trim(); //段落Id
objzx_PaperParagraphEN.TextId = objRow[conzx_PaperParagraph.TextId].ToString().Trim(); //课件Id
objzx_PaperParagraphEN.zxSectionId = objRow[conzx_PaperParagraph.zxSectionId].ToString().Trim(); //节Id
objzx_PaperParagraphEN.zxParagraphStateId = objRow[conzx_PaperParagraph.zxParagraphStateId].ToString().Trim(); //段落状态Id
objzx_PaperParagraphEN.zxParagraphTypeId = objRow[conzx_PaperParagraph.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objzx_PaperParagraphEN.ParagraphContent = objRow[conzx_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[conzx_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objzx_PaperParagraphEN.VoteCount = objRow[conzx_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objzx_PaperParagraphEN.CommentCount = objRow[conzx_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objzx_PaperParagraphEN.VersionCount = objRow[conzx_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objzx_PaperParagraphEN.CreateDate = objRow[conzx_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[conzx_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objzx_PaperParagraphEN.CreateUser = objRow[conzx_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[conzx_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objzx_PaperParagraphEN.UpdDate = objRow[conzx_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[conzx_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objzx_PaperParagraphEN.UpdUser = objRow[conzx_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[conzx_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objzx_PaperParagraphEN.Memo = objRow[conzx_PaperParagraph.Memo] == DBNull.Value ? null : objRow[conzx_PaperParagraph.Memo].ToString().Trim(); //备注
objzx_PaperParagraphEN.OrderNum = objRow[conzx_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_PaperParagraphEN.zxParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_PaperParagraphEN);
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
public static List<clszx_PaperParagraphEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_PaperParagraphEN> arrObjLst = new List<clszx_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_PaperParagraphEN objzx_PaperParagraphEN = new clszx_PaperParagraphEN();
try
{
objzx_PaperParagraphEN.zxParagraphId = objRow[conzx_PaperParagraph.zxParagraphId].ToString().Trim(); //段落Id
objzx_PaperParagraphEN.TextId = objRow[conzx_PaperParagraph.TextId].ToString().Trim(); //课件Id
objzx_PaperParagraphEN.zxSectionId = objRow[conzx_PaperParagraph.zxSectionId].ToString().Trim(); //节Id
objzx_PaperParagraphEN.zxParagraphStateId = objRow[conzx_PaperParagraph.zxParagraphStateId].ToString().Trim(); //段落状态Id
objzx_PaperParagraphEN.zxParagraphTypeId = objRow[conzx_PaperParagraph.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objzx_PaperParagraphEN.ParagraphContent = objRow[conzx_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[conzx_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objzx_PaperParagraphEN.VoteCount = objRow[conzx_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objzx_PaperParagraphEN.CommentCount = objRow[conzx_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objzx_PaperParagraphEN.VersionCount = objRow[conzx_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objzx_PaperParagraphEN.CreateDate = objRow[conzx_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[conzx_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objzx_PaperParagraphEN.CreateUser = objRow[conzx_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[conzx_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objzx_PaperParagraphEN.UpdDate = objRow[conzx_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[conzx_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objzx_PaperParagraphEN.UpdUser = objRow[conzx_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[conzx_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objzx_PaperParagraphEN.Memo = objRow[conzx_PaperParagraph.Memo] == DBNull.Value ? null : objRow[conzx_PaperParagraph.Memo].ToString().Trim(); //备注
objzx_PaperParagraphEN.OrderNum = objRow[conzx_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_PaperParagraphEN.zxParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_PaperParagraphEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_PaperParagraphCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_PaperParagraphEN> GetSubObjLstCache(clszx_PaperParagraphEN objzx_PaperParagraphCond)
{
List<clszx_PaperParagraphEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_PaperParagraphEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_PaperParagraph.AttributeName)
{
if (objzx_PaperParagraphCond.IsUpdated(strFldName) == false) continue;
if (objzx_PaperParagraphCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_PaperParagraphCond[strFldName].ToString());
}
else
{
if (objzx_PaperParagraphCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_PaperParagraphCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_PaperParagraphCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_PaperParagraphCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_PaperParagraphCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_PaperParagraphCond[strFldName]));
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
public static List<clszx_PaperParagraphEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_PaperParagraphEN> arrObjLst = new List<clszx_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_PaperParagraphEN objzx_PaperParagraphEN = new clszx_PaperParagraphEN();
try
{
objzx_PaperParagraphEN.zxParagraphId = objRow[conzx_PaperParagraph.zxParagraphId].ToString().Trim(); //段落Id
objzx_PaperParagraphEN.TextId = objRow[conzx_PaperParagraph.TextId].ToString().Trim(); //课件Id
objzx_PaperParagraphEN.zxSectionId = objRow[conzx_PaperParagraph.zxSectionId].ToString().Trim(); //节Id
objzx_PaperParagraphEN.zxParagraphStateId = objRow[conzx_PaperParagraph.zxParagraphStateId].ToString().Trim(); //段落状态Id
objzx_PaperParagraphEN.zxParagraphTypeId = objRow[conzx_PaperParagraph.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objzx_PaperParagraphEN.ParagraphContent = objRow[conzx_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[conzx_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objzx_PaperParagraphEN.VoteCount = objRow[conzx_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objzx_PaperParagraphEN.CommentCount = objRow[conzx_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objzx_PaperParagraphEN.VersionCount = objRow[conzx_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objzx_PaperParagraphEN.CreateDate = objRow[conzx_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[conzx_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objzx_PaperParagraphEN.CreateUser = objRow[conzx_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[conzx_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objzx_PaperParagraphEN.UpdDate = objRow[conzx_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[conzx_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objzx_PaperParagraphEN.UpdUser = objRow[conzx_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[conzx_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objzx_PaperParagraphEN.Memo = objRow[conzx_PaperParagraph.Memo] == DBNull.Value ? null : objRow[conzx_PaperParagraph.Memo].ToString().Trim(); //备注
objzx_PaperParagraphEN.OrderNum = objRow[conzx_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_PaperParagraphEN.zxParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_PaperParagraphEN);
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
public static List<clszx_PaperParagraphEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_PaperParagraphEN> arrObjLst = new List<clszx_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_PaperParagraphEN objzx_PaperParagraphEN = new clszx_PaperParagraphEN();
try
{
objzx_PaperParagraphEN.zxParagraphId = objRow[conzx_PaperParagraph.zxParagraphId].ToString().Trim(); //段落Id
objzx_PaperParagraphEN.TextId = objRow[conzx_PaperParagraph.TextId].ToString().Trim(); //课件Id
objzx_PaperParagraphEN.zxSectionId = objRow[conzx_PaperParagraph.zxSectionId].ToString().Trim(); //节Id
objzx_PaperParagraphEN.zxParagraphStateId = objRow[conzx_PaperParagraph.zxParagraphStateId].ToString().Trim(); //段落状态Id
objzx_PaperParagraphEN.zxParagraphTypeId = objRow[conzx_PaperParagraph.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objzx_PaperParagraphEN.ParagraphContent = objRow[conzx_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[conzx_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objzx_PaperParagraphEN.VoteCount = objRow[conzx_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objzx_PaperParagraphEN.CommentCount = objRow[conzx_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objzx_PaperParagraphEN.VersionCount = objRow[conzx_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objzx_PaperParagraphEN.CreateDate = objRow[conzx_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[conzx_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objzx_PaperParagraphEN.CreateUser = objRow[conzx_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[conzx_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objzx_PaperParagraphEN.UpdDate = objRow[conzx_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[conzx_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objzx_PaperParagraphEN.UpdUser = objRow[conzx_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[conzx_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objzx_PaperParagraphEN.Memo = objRow[conzx_PaperParagraph.Memo] == DBNull.Value ? null : objRow[conzx_PaperParagraph.Memo].ToString().Trim(); //备注
objzx_PaperParagraphEN.OrderNum = objRow[conzx_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_PaperParagraphEN.zxParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_PaperParagraphEN);
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
List<clszx_PaperParagraphEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_PaperParagraphEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_PaperParagraphEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_PaperParagraphEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_PaperParagraphEN> arrObjLst = new List<clszx_PaperParagraphEN>(); 
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
	clszx_PaperParagraphEN objzx_PaperParagraphEN = new clszx_PaperParagraphEN();
try
{
objzx_PaperParagraphEN.zxParagraphId = objRow[conzx_PaperParagraph.zxParagraphId].ToString().Trim(); //段落Id
objzx_PaperParagraphEN.TextId = objRow[conzx_PaperParagraph.TextId].ToString().Trim(); //课件Id
objzx_PaperParagraphEN.zxSectionId = objRow[conzx_PaperParagraph.zxSectionId].ToString().Trim(); //节Id
objzx_PaperParagraphEN.zxParagraphStateId = objRow[conzx_PaperParagraph.zxParagraphStateId].ToString().Trim(); //段落状态Id
objzx_PaperParagraphEN.zxParagraphTypeId = objRow[conzx_PaperParagraph.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objzx_PaperParagraphEN.ParagraphContent = objRow[conzx_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[conzx_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objzx_PaperParagraphEN.VoteCount = objRow[conzx_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objzx_PaperParagraphEN.CommentCount = objRow[conzx_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objzx_PaperParagraphEN.VersionCount = objRow[conzx_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objzx_PaperParagraphEN.CreateDate = objRow[conzx_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[conzx_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objzx_PaperParagraphEN.CreateUser = objRow[conzx_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[conzx_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objzx_PaperParagraphEN.UpdDate = objRow[conzx_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[conzx_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objzx_PaperParagraphEN.UpdUser = objRow[conzx_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[conzx_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objzx_PaperParagraphEN.Memo = objRow[conzx_PaperParagraph.Memo] == DBNull.Value ? null : objRow[conzx_PaperParagraph.Memo].ToString().Trim(); //备注
objzx_PaperParagraphEN.OrderNum = objRow[conzx_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_PaperParagraphEN.zxParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_PaperParagraphEN);
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
public static List<clszx_PaperParagraphEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_PaperParagraphEN> arrObjLst = new List<clszx_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_PaperParagraphEN objzx_PaperParagraphEN = new clszx_PaperParagraphEN();
try
{
objzx_PaperParagraphEN.zxParagraphId = objRow[conzx_PaperParagraph.zxParagraphId].ToString().Trim(); //段落Id
objzx_PaperParagraphEN.TextId = objRow[conzx_PaperParagraph.TextId].ToString().Trim(); //课件Id
objzx_PaperParagraphEN.zxSectionId = objRow[conzx_PaperParagraph.zxSectionId].ToString().Trim(); //节Id
objzx_PaperParagraphEN.zxParagraphStateId = objRow[conzx_PaperParagraph.zxParagraphStateId].ToString().Trim(); //段落状态Id
objzx_PaperParagraphEN.zxParagraphTypeId = objRow[conzx_PaperParagraph.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objzx_PaperParagraphEN.ParagraphContent = objRow[conzx_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[conzx_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objzx_PaperParagraphEN.VoteCount = objRow[conzx_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objzx_PaperParagraphEN.CommentCount = objRow[conzx_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objzx_PaperParagraphEN.VersionCount = objRow[conzx_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objzx_PaperParagraphEN.CreateDate = objRow[conzx_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[conzx_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objzx_PaperParagraphEN.CreateUser = objRow[conzx_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[conzx_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objzx_PaperParagraphEN.UpdDate = objRow[conzx_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[conzx_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objzx_PaperParagraphEN.UpdUser = objRow[conzx_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[conzx_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objzx_PaperParagraphEN.Memo = objRow[conzx_PaperParagraph.Memo] == DBNull.Value ? null : objRow[conzx_PaperParagraph.Memo].ToString().Trim(); //备注
objzx_PaperParagraphEN.OrderNum = objRow[conzx_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_PaperParagraphEN.zxParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_PaperParagraphEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_PaperParagraphEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_PaperParagraphEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_PaperParagraphEN> arrObjLst = new List<clszx_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_PaperParagraphEN objzx_PaperParagraphEN = new clszx_PaperParagraphEN();
try
{
objzx_PaperParagraphEN.zxParagraphId = objRow[conzx_PaperParagraph.zxParagraphId].ToString().Trim(); //段落Id
objzx_PaperParagraphEN.TextId = objRow[conzx_PaperParagraph.TextId].ToString().Trim(); //课件Id
objzx_PaperParagraphEN.zxSectionId = objRow[conzx_PaperParagraph.zxSectionId].ToString().Trim(); //节Id
objzx_PaperParagraphEN.zxParagraphStateId = objRow[conzx_PaperParagraph.zxParagraphStateId].ToString().Trim(); //段落状态Id
objzx_PaperParagraphEN.zxParagraphTypeId = objRow[conzx_PaperParagraph.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objzx_PaperParagraphEN.ParagraphContent = objRow[conzx_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[conzx_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objzx_PaperParagraphEN.VoteCount = objRow[conzx_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objzx_PaperParagraphEN.CommentCount = objRow[conzx_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objzx_PaperParagraphEN.VersionCount = objRow[conzx_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objzx_PaperParagraphEN.CreateDate = objRow[conzx_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[conzx_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objzx_PaperParagraphEN.CreateUser = objRow[conzx_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[conzx_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objzx_PaperParagraphEN.UpdDate = objRow[conzx_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[conzx_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objzx_PaperParagraphEN.UpdUser = objRow[conzx_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[conzx_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objzx_PaperParagraphEN.Memo = objRow[conzx_PaperParagraph.Memo] == DBNull.Value ? null : objRow[conzx_PaperParagraph.Memo].ToString().Trim(); //备注
objzx_PaperParagraphEN.OrderNum = objRow[conzx_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_PaperParagraphEN.zxParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_PaperParagraphEN);
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
public static List<clszx_PaperParagraphEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_PaperParagraphEN> arrObjLst = new List<clszx_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_PaperParagraphEN objzx_PaperParagraphEN = new clszx_PaperParagraphEN();
try
{
objzx_PaperParagraphEN.zxParagraphId = objRow[conzx_PaperParagraph.zxParagraphId].ToString().Trim(); //段落Id
objzx_PaperParagraphEN.TextId = objRow[conzx_PaperParagraph.TextId].ToString().Trim(); //课件Id
objzx_PaperParagraphEN.zxSectionId = objRow[conzx_PaperParagraph.zxSectionId].ToString().Trim(); //节Id
objzx_PaperParagraphEN.zxParagraphStateId = objRow[conzx_PaperParagraph.zxParagraphStateId].ToString().Trim(); //段落状态Id
objzx_PaperParagraphEN.zxParagraphTypeId = objRow[conzx_PaperParagraph.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objzx_PaperParagraphEN.ParagraphContent = objRow[conzx_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[conzx_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objzx_PaperParagraphEN.VoteCount = objRow[conzx_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objzx_PaperParagraphEN.CommentCount = objRow[conzx_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objzx_PaperParagraphEN.VersionCount = objRow[conzx_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objzx_PaperParagraphEN.CreateDate = objRow[conzx_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[conzx_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objzx_PaperParagraphEN.CreateUser = objRow[conzx_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[conzx_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objzx_PaperParagraphEN.UpdDate = objRow[conzx_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[conzx_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objzx_PaperParagraphEN.UpdUser = objRow[conzx_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[conzx_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objzx_PaperParagraphEN.Memo = objRow[conzx_PaperParagraph.Memo] == DBNull.Value ? null : objRow[conzx_PaperParagraph.Memo].ToString().Trim(); //备注
objzx_PaperParagraphEN.OrderNum = objRow[conzx_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_PaperParagraphEN.zxParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_PaperParagraphEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_PaperParagraphEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_PaperParagraphEN> arrObjLst = new List<clszx_PaperParagraphEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_PaperParagraphEN objzx_PaperParagraphEN = new clszx_PaperParagraphEN();
try
{
objzx_PaperParagraphEN.zxParagraphId = objRow[conzx_PaperParagraph.zxParagraphId].ToString().Trim(); //段落Id
objzx_PaperParagraphEN.TextId = objRow[conzx_PaperParagraph.TextId].ToString().Trim(); //课件Id
objzx_PaperParagraphEN.zxSectionId = objRow[conzx_PaperParagraph.zxSectionId].ToString().Trim(); //节Id
objzx_PaperParagraphEN.zxParagraphStateId = objRow[conzx_PaperParagraph.zxParagraphStateId].ToString().Trim(); //段落状态Id
objzx_PaperParagraphEN.zxParagraphTypeId = objRow[conzx_PaperParagraph.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objzx_PaperParagraphEN.ParagraphContent = objRow[conzx_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[conzx_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objzx_PaperParagraphEN.VoteCount = objRow[conzx_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objzx_PaperParagraphEN.CommentCount = objRow[conzx_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objzx_PaperParagraphEN.VersionCount = objRow[conzx_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objzx_PaperParagraphEN.CreateDate = objRow[conzx_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[conzx_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objzx_PaperParagraphEN.CreateUser = objRow[conzx_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[conzx_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objzx_PaperParagraphEN.UpdDate = objRow[conzx_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[conzx_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objzx_PaperParagraphEN.UpdUser = objRow[conzx_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[conzx_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objzx_PaperParagraphEN.Memo = objRow[conzx_PaperParagraph.Memo] == DBNull.Value ? null : objRow[conzx_PaperParagraph.Memo].ToString().Trim(); //备注
objzx_PaperParagraphEN.OrderNum = objRow[conzx_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_PaperParagraphEN.zxParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_PaperParagraphEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_PaperParagraphEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_PaperParagraph(ref clszx_PaperParagraphEN objzx_PaperParagraphEN)
{
bool bolResult = zx_PaperParagraphDA.Getzx_PaperParagraph(ref objzx_PaperParagraphEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxParagraphId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_PaperParagraphEN GetObjByzxParagraphId(string strzxParagraphId)
{
if (strzxParagraphId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxParagraphId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxParagraphId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxParagraphId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clszx_PaperParagraphEN objzx_PaperParagraphEN = zx_PaperParagraphDA.GetObjByzxParagraphId(strzxParagraphId);
return objzx_PaperParagraphEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_PaperParagraphEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_PaperParagraphEN objzx_PaperParagraphEN = zx_PaperParagraphDA.GetFirstObj(strWhereCond);
 return objzx_PaperParagraphEN;
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
public static clszx_PaperParagraphEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_PaperParagraphEN objzx_PaperParagraphEN = zx_PaperParagraphDA.GetObjByDataRow(objRow);
 return objzx_PaperParagraphEN;
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
public static clszx_PaperParagraphEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_PaperParagraphEN objzx_PaperParagraphEN = zx_PaperParagraphDA.GetObjByDataRow(objRow);
 return objzx_PaperParagraphEN;
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
 /// <param name = "strzxParagraphId">所给的关键字</param>
 /// <param name = "lstzx_PaperParagraphObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_PaperParagraphEN GetObjByzxParagraphIdFromList(string strzxParagraphId, List<clszx_PaperParagraphEN> lstzx_PaperParagraphObjLst)
{
foreach (clszx_PaperParagraphEN objzx_PaperParagraphEN in lstzx_PaperParagraphObjLst)
{
if (objzx_PaperParagraphEN.zxParagraphId == strzxParagraphId)
{
return objzx_PaperParagraphEN;
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
 string strMaxZxParagraphId;
 try
 {
 strMaxZxParagraphId = clszx_PaperParagraphDA.GetMaxStrId();
 return strMaxZxParagraphId;
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
 string strzxParagraphId;
 try
 {
 strzxParagraphId = new clszx_PaperParagraphDA().GetFirstID(strWhereCond);
 return strzxParagraphId;
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
 arrList = zx_PaperParagraphDA.GetID(strWhereCond);
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
bool bolIsExist = zx_PaperParagraphDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxParagraphId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxParagraphId)
{
if (string.IsNullOrEmpty(strzxParagraphId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxParagraphId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = zx_PaperParagraphDA.IsExist(strzxParagraphId);
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
 bolIsExist = clszx_PaperParagraphDA.IsExistTable();
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
 bolIsExist = zx_PaperParagraphDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_PaperParagraphEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_PaperParagraphEN objzx_PaperParagraphEN)
{
if (objzx_PaperParagraphEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!段落Id = [{0}]的数据已经存在!(in clszx_PaperParagraphBL.AddNewRecordBySql2)", objzx_PaperParagraphEN.zxParagraphId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_PaperParagraphEN.zxParagraphId) == true || clszx_PaperParagraphBL.IsExist(objzx_PaperParagraphEN.zxParagraphId) == true)
 {
     objzx_PaperParagraphEN.zxParagraphId = clszx_PaperParagraphBL.GetMaxStrId_S();
 }
bool bolResult = zx_PaperParagraphDA.AddNewRecordBySQL2(objzx_PaperParagraphEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_PaperParagraphBL.ReFreshCache();

if (clszx_PaperParagraphBL.relatedActions != null)
{
clszx_PaperParagraphBL.relatedActions.UpdRelaTabDate(objzx_PaperParagraphEN.zxParagraphId, "SetUpdDate");
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
 /// <param name = "objzx_PaperParagraphEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_PaperParagraphEN objzx_PaperParagraphEN)
{
if (objzx_PaperParagraphEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!段落Id = [{0}]的数据已经存在!(in clszx_PaperParagraphBL.AddNewRecordBySql2WithReturnKey)", objzx_PaperParagraphEN.zxParagraphId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_PaperParagraphEN.zxParagraphId) == true || clszx_PaperParagraphBL.IsExist(objzx_PaperParagraphEN.zxParagraphId) == true)
 {
     objzx_PaperParagraphEN.zxParagraphId = clszx_PaperParagraphBL.GetMaxStrId_S();
 }
string strKey = zx_PaperParagraphDA.AddNewRecordBySQL2WithReturnKey(objzx_PaperParagraphEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_PaperParagraphBL.ReFreshCache();

if (clszx_PaperParagraphBL.relatedActions != null)
{
clszx_PaperParagraphBL.relatedActions.UpdRelaTabDate(objzx_PaperParagraphEN.zxParagraphId, "SetUpdDate");
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
 /// <param name = "objzx_PaperParagraphEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_PaperParagraphEN objzx_PaperParagraphEN)
{
try
{
bool bolResult = zx_PaperParagraphDA.Update(objzx_PaperParagraphEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_PaperParagraphBL.ReFreshCache();

if (clszx_PaperParagraphBL.relatedActions != null)
{
clszx_PaperParagraphBL.relatedActions.UpdRelaTabDate(objzx_PaperParagraphEN.zxParagraphId, "SetUpdDate");
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
 /// <param name = "objzx_PaperParagraphEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_PaperParagraphEN objzx_PaperParagraphEN)
{
 if (string.IsNullOrEmpty(objzx_PaperParagraphEN.zxParagraphId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_PaperParagraphDA.UpdateBySql2(objzx_PaperParagraphEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_PaperParagraphBL.ReFreshCache();

if (clszx_PaperParagraphBL.relatedActions != null)
{
clszx_PaperParagraphBL.relatedActions.UpdRelaTabDate(objzx_PaperParagraphEN.zxParagraphId, "SetUpdDate");
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
 /// <param name = "strzxParagraphId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strzxParagraphId)
{
try
{
 clszx_PaperParagraphEN objzx_PaperParagraphEN = clszx_PaperParagraphBL.GetObjByzxParagraphId(strzxParagraphId);

if (clszx_PaperParagraphBL.relatedActions != null)
{
clszx_PaperParagraphBL.relatedActions.UpdRelaTabDate(objzx_PaperParagraphEN.zxParagraphId, "SetUpdDate");
}
if (objzx_PaperParagraphEN != null)
{
int intRecNum = zx_PaperParagraphDA.DelRecord(strzxParagraphId);
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
/// <param name="strzxParagraphId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strzxParagraphId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_PaperParagraphDA.GetSpecSQLObj();
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
//删除与表:[zx_PaperParagraph]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_PaperParagraph.zxParagraphId,
//strzxParagraphId);
//        clszx_PaperParagraphBL.Delzx_PaperParagraphsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_PaperParagraphBL.DelRecord(strzxParagraphId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_PaperParagraphBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxParagraphId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strzxParagraphId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strzxParagraphId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_PaperParagraphBL.relatedActions != null)
{
clszx_PaperParagraphBL.relatedActions.UpdRelaTabDate(strzxParagraphId, "UpdRelaTabDate");
}
bool bolResult = zx_PaperParagraphDA.DelRecord(strzxParagraphId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrzxParagraphIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_PaperParagraphs(List<string> arrzxParagraphIdLst)
{
if (arrzxParagraphIdLst.Count == 0) return 0;
try
{
if (clszx_PaperParagraphBL.relatedActions != null)
{
foreach (var strzxParagraphId in arrzxParagraphIdLst)
{
clszx_PaperParagraphBL.relatedActions.UpdRelaTabDate(strzxParagraphId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_PaperParagraphDA.Delzx_PaperParagraph(arrzxParagraphIdLst);
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
public static int Delzx_PaperParagraphsByCond(string strWhereCond)
{
try
{
if (clszx_PaperParagraphBL.relatedActions != null)
{
List<string> arrzxParagraphId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strzxParagraphId in arrzxParagraphId)
{
clszx_PaperParagraphBL.relatedActions.UpdRelaTabDate(strzxParagraphId, "UpdRelaTabDate");
}
}
int intRecNum = zx_PaperParagraphDA.Delzx_PaperParagraph(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_PaperParagraph]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strzxParagraphId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strzxParagraphId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_PaperParagraphDA.GetSpecSQLObj();
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
//删除与表:[zx_PaperParagraph]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_PaperParagraphBL.DelRecord(strzxParagraphId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_PaperParagraphBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxParagraphId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_PaperParagraphENS">源对象</param>
 /// <param name = "objzx_PaperParagraphENT">目标对象</param>
 public static void CopyTo(clszx_PaperParagraphEN objzx_PaperParagraphENS, clszx_PaperParagraphEN objzx_PaperParagraphENT)
{
try
{
objzx_PaperParagraphENT.zxParagraphId = objzx_PaperParagraphENS.zxParagraphId; //段落Id
objzx_PaperParagraphENT.TextId = objzx_PaperParagraphENS.TextId; //课件Id
objzx_PaperParagraphENT.zxSectionId = objzx_PaperParagraphENS.zxSectionId; //节Id
objzx_PaperParagraphENT.zxParagraphStateId = objzx_PaperParagraphENS.zxParagraphStateId; //段落状态Id
objzx_PaperParagraphENT.zxParagraphTypeId = objzx_PaperParagraphENS.zxParagraphTypeId; //段落类型Id
objzx_PaperParagraphENT.ParagraphContent = objzx_PaperParagraphENS.ParagraphContent; //段落内容
objzx_PaperParagraphENT.VoteCount = objzx_PaperParagraphENS.VoteCount; //点赞计数
objzx_PaperParagraphENT.CommentCount = objzx_PaperParagraphENS.CommentCount; //评论数
objzx_PaperParagraphENT.VersionCount = objzx_PaperParagraphENS.VersionCount; //版本统计
objzx_PaperParagraphENT.CreateDate = objzx_PaperParagraphENS.CreateDate; //建立日期
objzx_PaperParagraphENT.CreateUser = objzx_PaperParagraphENS.CreateUser; //建立用户
objzx_PaperParagraphENT.UpdDate = objzx_PaperParagraphENS.UpdDate; //修改日期
objzx_PaperParagraphENT.UpdUser = objzx_PaperParagraphENS.UpdUser; //修改人
objzx_PaperParagraphENT.Memo = objzx_PaperParagraphENS.Memo; //备注
objzx_PaperParagraphENT.OrderNum = objzx_PaperParagraphENS.OrderNum; //序号
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
 /// <param name = "objzx_PaperParagraphEN">源简化对象</param>
 public static void SetUpdFlag(clszx_PaperParagraphEN objzx_PaperParagraphEN)
{
try
{
objzx_PaperParagraphEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_PaperParagraphEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_PaperParagraph.zxParagraphId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_PaperParagraphEN.zxParagraphId = objzx_PaperParagraphEN.zxParagraphId; //段落Id
}
if (arrFldSet.Contains(conzx_PaperParagraph.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_PaperParagraphEN.TextId = objzx_PaperParagraphEN.TextId; //课件Id
}
if (arrFldSet.Contains(conzx_PaperParagraph.zxSectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_PaperParagraphEN.zxSectionId = objzx_PaperParagraphEN.zxSectionId; //节Id
}
if (arrFldSet.Contains(conzx_PaperParagraph.zxParagraphStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_PaperParagraphEN.zxParagraphStateId = objzx_PaperParagraphEN.zxParagraphStateId; //段落状态Id
}
if (arrFldSet.Contains(conzx_PaperParagraph.zxParagraphTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_PaperParagraphEN.zxParagraphTypeId = objzx_PaperParagraphEN.zxParagraphTypeId; //段落类型Id
}
if (arrFldSet.Contains(conzx_PaperParagraph.ParagraphContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_PaperParagraphEN.ParagraphContent = objzx_PaperParagraphEN.ParagraphContent == "[null]" ? null :  objzx_PaperParagraphEN.ParagraphContent; //段落内容
}
if (arrFldSet.Contains(conzx_PaperParagraph.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_PaperParagraphEN.VoteCount = objzx_PaperParagraphEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(conzx_PaperParagraph.CommentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_PaperParagraphEN.CommentCount = objzx_PaperParagraphEN.CommentCount; //评论数
}
if (arrFldSet.Contains(conzx_PaperParagraph.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_PaperParagraphEN.VersionCount = objzx_PaperParagraphEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(conzx_PaperParagraph.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_PaperParagraphEN.CreateDate = objzx_PaperParagraphEN.CreateDate == "[null]" ? null :  objzx_PaperParagraphEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conzx_PaperParagraph.CreateUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_PaperParagraphEN.CreateUser = objzx_PaperParagraphEN.CreateUser == "[null]" ? null :  objzx_PaperParagraphEN.CreateUser; //建立用户
}
if (arrFldSet.Contains(conzx_PaperParagraph.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_PaperParagraphEN.UpdDate = objzx_PaperParagraphEN.UpdDate == "[null]" ? null :  objzx_PaperParagraphEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_PaperParagraph.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_PaperParagraphEN.UpdUser = objzx_PaperParagraphEN.UpdUser == "[null]" ? null :  objzx_PaperParagraphEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_PaperParagraph.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_PaperParagraphEN.Memo = objzx_PaperParagraphEN.Memo == "[null]" ? null :  objzx_PaperParagraphEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_PaperParagraph.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_PaperParagraphEN.OrderNum = objzx_PaperParagraphEN.OrderNum; //序号
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
 /// <param name = "objzx_PaperParagraphEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_PaperParagraphEN objzx_PaperParagraphEN)
{
try
{
if (objzx_PaperParagraphEN.ParagraphContent == "[null]") objzx_PaperParagraphEN.ParagraphContent = null; //段落内容
if (objzx_PaperParagraphEN.CreateDate == "[null]") objzx_PaperParagraphEN.CreateDate = null; //建立日期
if (objzx_PaperParagraphEN.CreateUser == "[null]") objzx_PaperParagraphEN.CreateUser = null; //建立用户
if (objzx_PaperParagraphEN.UpdDate == "[null]") objzx_PaperParagraphEN.UpdDate = null; //修改日期
if (objzx_PaperParagraphEN.UpdUser == "[null]") objzx_PaperParagraphEN.UpdUser = null; //修改人
if (objzx_PaperParagraphEN.Memo == "[null]") objzx_PaperParagraphEN.Memo = null; //备注
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
public static void CheckPropertyNew(clszx_PaperParagraphEN objzx_PaperParagraphEN)
{
 zx_PaperParagraphDA.CheckPropertyNew(objzx_PaperParagraphEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_PaperParagraphEN objzx_PaperParagraphEN)
{
 zx_PaperParagraphDA.CheckProperty4Condition(objzx_PaperParagraphEN);
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
if (clszx_PaperParagraphBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_PaperParagraphBL没有刷新缓存机制(clszx_PaperParagraphBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxParagraphId");
//if (arrzx_PaperParagraphObjLstCache == null)
//{
//arrzx_PaperParagraphObjLstCache = zx_PaperParagraphDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxParagraphId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_PaperParagraphEN GetObjByzxParagraphIdCache(string strzxParagraphId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_PaperParagraphEN._CurrTabName);
List<clszx_PaperParagraphEN> arrzx_PaperParagraphObjLstCache = GetObjLstCache();
IEnumerable <clszx_PaperParagraphEN> arrzx_PaperParagraphObjLst_Sel =
arrzx_PaperParagraphObjLstCache
.Where(x=> x.zxParagraphId == strzxParagraphId 
);
if (arrzx_PaperParagraphObjLst_Sel.Count() == 0)
{
   clszx_PaperParagraphEN obj = clszx_PaperParagraphBL.GetObjByzxParagraphId(strzxParagraphId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_PaperParagraphObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_PaperParagraphEN> GetAllzx_PaperParagraphObjLstCache()
{
//获取缓存中的对象列表
List<clszx_PaperParagraphEN> arrzx_PaperParagraphObjLstCache = GetObjLstCache(); 
return arrzx_PaperParagraphObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_PaperParagraphEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_PaperParagraphEN._CurrTabName);
List<clszx_PaperParagraphEN> arrzx_PaperParagraphObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_PaperParagraphObjLstCache;
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
string strKey = string.Format("{0}", clszx_PaperParagraphEN._CurrTabName);
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
if (clszx_PaperParagraphBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_PaperParagraphEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_PaperParagraphBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_PaperParagraph(作文段落表)
 /// 唯一性条件:ParagraphId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_PaperParagraphEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_PaperParagraphEN objzx_PaperParagraphEN)
{
//检测记录是否存在
string strResult = zx_PaperParagraphDA.GetUniCondStr(objzx_PaperParagraphEN);
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
public static string Func(string strInFldName, string strOutFldName, string strzxParagraphId)
{
if (strInFldName != conzx_PaperParagraph.zxParagraphId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_PaperParagraph.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_PaperParagraph.AttributeName));
throw new Exception(strMsg);
}
var objzx_PaperParagraph = clszx_PaperParagraphBL.GetObjByzxParagraphIdCache(strzxParagraphId);
if (objzx_PaperParagraph == null) return "";
return objzx_PaperParagraph[strOutFldName].ToString();
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
int intRecCount = clszx_PaperParagraphDA.GetRecCount(strTabName);
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
int intRecCount = clszx_PaperParagraphDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_PaperParagraphDA.GetRecCount();
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
int intRecCount = clszx_PaperParagraphDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_PaperParagraphCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_PaperParagraphEN objzx_PaperParagraphCond)
{
List<clszx_PaperParagraphEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_PaperParagraphEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_PaperParagraph.AttributeName)
{
if (objzx_PaperParagraphCond.IsUpdated(strFldName) == false) continue;
if (objzx_PaperParagraphCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_PaperParagraphCond[strFldName].ToString());
}
else
{
if (objzx_PaperParagraphCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_PaperParagraphCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_PaperParagraphCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_PaperParagraphCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_PaperParagraphCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_PaperParagraphCond[strFldName]));
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
 List<string> arrList = clszx_PaperParagraphDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_PaperParagraphDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_PaperParagraphDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_PaperParagraphDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_PaperParagraphDA.SetFldValue(clszx_PaperParagraphEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_PaperParagraphDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_PaperParagraphDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_PaperParagraphDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_PaperParagraphDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_PaperParagraph] "); 
 strCreateTabCode.Append(" ( "); 
 // /**段落Id*/ 
 strCreateTabCode.Append(" zxParagraphId char(10) primary key, "); 
 // /**课件Id*/ 
 strCreateTabCode.Append(" TextId char(8) not Null, "); 
 // /**节Id*/ 
 strCreateTabCode.Append(" zxSectionId char(8) not Null, "); 
 // /**段落状态Id*/ 
 strCreateTabCode.Append(" zxParagraphStateId char(2) not Null, "); 
 // /**段落类型Id*/ 
 strCreateTabCode.Append(" zxParagraphTypeId char(2) not Null, "); 
 // /**段落内容*/ 
 strCreateTabCode.Append(" ParagraphContent text Null, "); 
 // /**点赞计数*/ 
 strCreateTabCode.Append(" VoteCount int Null, "); 
 // /**评论数*/ 
 strCreateTabCode.Append(" CommentCount int Null, "); 
 // /**版本统计*/ 
 strCreateTabCode.Append(" VersionCount int Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**建立用户*/ 
 strCreateTabCode.Append(" CreateUser varchar(50) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：zxSectionId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strzxSectionId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strzxSectionId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conzx_PaperParagraph.zxSectionId, strzxSectionId);
 strCondition += string.Format(" order by OrderNum ");
List<clszx_PaperParagraphEN> arrzx_PaperParagraphObjList = new clszx_PaperParagraphDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clszx_PaperParagraphEN objzx_PaperParagraph in arrzx_PaperParagraphObjList)
{
objzx_PaperParagraph.OrderNum = intIndex;
UpdateBySql2(objzx_PaperParagraph);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("重序出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 调整所给关键字记录的序号。根据分类字段：zxSectionId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strzxParagraphId">所给的关键字</param>
/// <param name="strzxSectionId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, string strzxParagraphId, string strzxSectionId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[zxParagraphId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字zxParagraphId
//5、把当前关键字zxParagraphId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字zxParagraphId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevzxParagraphId = "";    //上一条序号的关键字zxParagraphId
string strNextzxParagraphId = "";    //下一条序号的关键字zxParagraphId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[zxParagraphId],获取相应的序号[OrderNum]。

clszx_PaperParagraphEN objzx_PaperParagraph = clszx_PaperParagraphBL.GetObjByzxParagraphId(strzxParagraphId);

intOrderNum = objzx_PaperParagraph.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conzx_PaperParagraph.zxSectionId, strzxSectionId);
intTabRecNum = clszx_PaperParagraphBL.GetRecCountByCond(clszx_PaperParagraphEN._CurrTabName, strCondition);    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号,就退出；
//  3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录,不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//		    如果是向上移动,就判断当前序号是否“大于”1,
//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
sbCondition.AppendFormat(" {0} = {1} ", conzx_PaperParagraph.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conzx_PaperParagraph.zxSectionId, strzxSectionId);
//4、获取上一个序号字段的关键字zxParagraphId
strPrevzxParagraphId = clszx_PaperParagraphBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strPrevzxParagraphId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字zxParagraphId所对应记录的序号减1
//6、把下(上)一个序号关键字zxParagraphId所对应的记录序号加1
clszx_PaperParagraphBL.SetFldValue(clszx_PaperParagraphEN._CurrTabName, conzx_PaperParagraph.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conzx_PaperParagraph.zxParagraphId, strzxParagraphId));
clszx_PaperParagraphBL.SetFldValue(clszx_PaperParagraphEN._CurrTabName, conzx_PaperParagraph.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conzx_PaperParagraph.zxParagraphId, strPrevzxParagraphId));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录,不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字zxParagraphId
sbCondition.AppendFormat(" {0} = {1} ", conzx_PaperParagraph.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conzx_PaperParagraph.zxSectionId, strzxSectionId);

strNextzxParagraphId = clszx_PaperParagraphBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strNextzxParagraphId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字zxParagraphId所对应记录的序号加1
//6、把下(上)一个序号关键字zxParagraphId所对应的记录序号减1
clszx_PaperParagraphBL.SetFldValue(clszx_PaperParagraphEN._CurrTabName, conzx_PaperParagraph.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conzx_PaperParagraph.zxParagraphId, strzxParagraphId));
clszx_PaperParagraphBL.SetFldValue(clszx_PaperParagraphEN._CurrTabName, conzx_PaperParagraph.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conzx_PaperParagraph.zxParagraphId, strNextzxParagraphId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
 	 	strDirect,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
return true;
}
catch (Exception objException)
{
string strMsg = string.Format("调整记录次序出错!错误:[{0}]({1})",
 	 	objException.Message,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：zxSectionId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId, string strzxSectionId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conzx_PaperParagraph.zxParagraphId, strKeyList);
List<clszx_PaperParagraphEN> arrzx_PaperParagraphLst = GetObjLst(strCondition);
foreach (clszx_PaperParagraphEN objzx_PaperParagraph in arrzx_PaperParagraphLst)
{
objzx_PaperParagraph.OrderNum = objzx_PaperParagraph.OrderNum + 10000;
UpdateBySql2(objzx_PaperParagraph);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conzx_PaperParagraph.zxSectionId, strzxSectionId);
 strCondition += string.Format(" order by OrderNum ");
List<clszx_PaperParagraphEN> arrzx_PaperParagraphObjList = new clszx_PaperParagraphDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clszx_PaperParagraphEN objzx_PaperParagraph in arrzx_PaperParagraphObjList)
{
objzx_PaperParagraph.OrderNum = intIndex;
UpdateBySql2(objzx_PaperParagraph);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：zxSectionId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strzxSectionId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId, string strzxSectionId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conzx_PaperParagraph.zxParagraphId, strKeyList);
List<clszx_PaperParagraphEN> arrzx_PaperParagraphLst = GetObjLst(strCondition);
foreach (clszx_PaperParagraphEN objzx_PaperParagraph in arrzx_PaperParagraphLst)
{
objzx_PaperParagraph.OrderNum = objzx_PaperParagraph.OrderNum - 10000;
UpdateBySql2(objzx_PaperParagraph);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conzx_PaperParagraph.zxSectionId, strzxSectionId);
 strCondition += string.Format(" order by OrderNum ");
List<clszx_PaperParagraphEN> arrzx_PaperParagraphObjList = new clszx_PaperParagraphDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clszx_PaperParagraphEN objzx_PaperParagraph in arrzx_PaperParagraphObjList)
{
objzx_PaperParagraph.OrderNum = intIndex;
UpdateBySql2(objzx_PaperParagraph);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错,{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 作文段落表(zx_PaperParagraph)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_PaperParagraph : clsCommFun4BL
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
clszx_PaperParagraphBL.ReFreshThisCache();
}
}

}